using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Fusion;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.XR;

public class GillaSawHits : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass60_0
	{
		public List<Vector3> verts;

		public List<Vector3> faces;

		public List<Vector2> uv;

		public List<Vector4> opening;

		public Vector4 open;

		public List<Vector2> depth;

		public GillaRip.Along along;

		public int sign;

		public int seed;

		public float visible;

		public List<Vector3> wayOut;

		public Vector3 way;
	}

	private class Cut
	{
		public NetworkApe ape;

		public GillaDummy dummy;

		public GillaCorpse body;

		public GillaWounds wounds;

		public GoreSection section;

		public int slot;

		public GillaRip.Along along;

		public Vector3 entry;

		public Vector3 way;

		public string bone;

		public float units;

		public float halfLength;

		public float through;

		public float depth;

		public float touched;

		public bool done;

		public bool Same(NetworkApe a, GillaDummy d, GillaCorpse b, GoreSection s)
		{
			//IL_0010: Expected Obj, but got I
			//IL_01a5: Expected Obj, but got I4
			//IL_007e: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I4
			//IL_0151: Expected Obj, but got I4
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
			if ((UnityEngine.Object)ape == (UnityEngine.Object)a)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)dummy == (UnityEngine.Object)d)
				{
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v13+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (body == b)
					{
						object obj8 = section - s;
						return obj8 == null;
					}
				}
			}
			return false;
		}
	}

	private class Foreseen
	{
		public GillaWounds w;

		public GillaRip.Along along;

		public List<Mesh> meshes;

		public CancellationTokenSource drop;

		public float at;

		public float seen;
	}

	private struct Plane
	{
		public string bone;

		public Vector3 entry;

		public Vector3 way;

		public float units;

		public float stretch;

		public GillaRip.Along along;
	}

	public RobotSaw saw;

	private string Sawing__BackingField;

	private float Through__BackingField;

	private int Bites__BackingField;

	private int Throughs__BackingField;

	private GoreSection LastThroughSection__BackingField;

	private GillaRip.Along LastThrough__BackingField;

	private Vector3 BiteAt__BackingField;

	private Vector3 BiteNormal__BackingField;

	private Vector3 BiteWay__BackingField;

	private const float KeepCut = default(float);

	private const float MostSlant = default(float);

	private static readonly Vector3 HeadMiddle;

	private const float HeadRadius = default(float);

	private const float HeadLowest = default(float);

	private const float SprayEvery = default(float);

	private const float BitsEvery = default(float);

	internal const int SprayDrops = default(int);

	internal const int SpurtDrops = default(int);

	private Transform sprocket;

	private Transform nose;

	private Transform[] links;

	private readonly List<(GoreSection, Vector3, Vector3, float)> shapes;

	private readonly List<Cut> cuts;

	private readonly HashSet<(UnityEngine.Object, GoreSection)> outFirst;

	private readonly HashSet<(UnityEngine.Object, GoreSection)> inPart;

	private float sprayIn;

	private float bitsIn;

	private readonly Dictionary<UnityEngine.Object, float> killed;

	private readonly Dictionary<int, float> killedOwners;

	private const float KilledFor = default(float);

	private const float ForeseeReach = default(float);

	private const float ForeseeEvery = default(float);

	private const float ForeseeKeep = default(float);

	private const float NearAngle = default(float);

	private const float NearOff = default(float);

	private readonly Dictionary<(UnityEngine.Object, GoreSection), Foreseen> foreseen;

	private int Foresaw__BackingField;

	private int UsedForeseen__BackingField;

	private string LastForeseeMiss__BackingField;

	private const float PieceSeconds = default(float);

	private Vector3 lastBack;

	private Vector3 lastTip;

	private bool hadBar;

	private int Slices__BackingField;

	private readonly Dictionary<PieceKey, float> inPiece;

	private readonly List<(GillaPieceId, Vector3)> touching;

	private readonly List<PieceKey> stillIn;

	private readonly HashSet<PieceKey> touchingNow;

	private readonly HashSet<PieceKey> waiting;

	private const float JustCut = default(float);

	public string Sawing
	{
		get
		{
			return Sawing__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public float Through
	{
		get
		{
			return Through__BackingField;
		}
		private set
		{
			Through__BackingField = value;
		}
	}

	public int Bites
	{
		get
		{
			return Bites__BackingField;
		}
		private set
		{
			Bites__BackingField = value;
		}
	}

	public int Throughs
	{
		get
		{
			return Throughs__BackingField;
		}
		private set
		{
			Throughs__BackingField = value;
		}
	}

	public GoreSection LastThroughSection
	{
		get
		{
			return LastThroughSection__BackingField;
		}
		private set
		{
			LastThroughSection__BackingField = value;
		}
	}

	public unsafe GillaRip.Along LastThrough
	{
		get
		{
			//IL_0017: Expected native int or pointer, but got VT
			//IL_002b: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSawHits)+60]");
			_ = 0;
			GillaRip.Along along = default;
			((GillaRip.Along*)(nint)along)->n = (Vector3)LastThrough__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSawHits)+50]");
			_ = 0;
			return (GillaRip.Along)this;
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X1 (GillaRip+Along)+20]");
			_ = 0;
			LastThrough__BackingField = (GillaRip.Along)value.n;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X1 (GillaRip+Along)+10]");
			_ = 0;
		}
	}

	public Vector3 BiteAt
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		private set
		{
			Vector3 vector = default;
			BiteAt__BackingField = vector;
		}
	}

	public Vector3 BiteNormal
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		private set
		{
			Vector3 vector = default;
			BiteNormal__BackingField = vector;
		}
	}

	public Vector3 BiteWay
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		private set
		{
			Vector3 vector = default;
			BiteWay__BackingField = vector;
		}
	}

	public int Foresaw
	{
		get
		{
			return Foresaw__BackingField;
		}
		private set
		{
			Foresaw__BackingField = value;
		}
	}

	public int UsedForeseen
	{
		get
		{
			return UsedForeseen__BackingField;
		}
		private set
		{
			UsedForeseen__BackingField = value;
		}
	}

	public string LastForeseeMiss
	{
		get
		{
			return LastForeseeMiss__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 240;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public int Slices
	{
		get
		{
			return Slices__BackingField;
		}
		private set
		{
			Slices__BackingField = value;
		}
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_051c: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_0552: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I4
		//IL_0367: Expected I4, but got Obj
		//IL_03c9: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_047f: Expected Obj, but got I
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_042c: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D98]");
		object obj6 = 0;
		if ((UnityEngine.Object)obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D78]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			RobotSaw robotSaw = default;
			saw = robotSaw;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj9 = default;
		if (obj9 == null)
		{
			goto IL_04d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0484;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DB0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DA0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DA8]");
		object value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D80]");
		object obj13 = 0;
		object obj14 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
			object obj15 = !flag2;
			if (obj15 != null)
			{
				break;
			}
			object obj16 = obj9 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
			if ((nint)0 == 0)
			{
				goto IL_04d2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
			string text = ((UnityEngine.Object)0).name;
			if (text == (string)obj11)
			{
				object obj17 = this + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
				sprocket = (Transform)0;
				obj8 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
				string text2 = ((UnityEngine.Object)0).name;
				object obj17;
				if (!(text2 == (string)obj12))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
					string text3 = ((UnityEngine.Object)0).name;
					if (text3 != null)
					{
						bool flag3 = text3.StartsWith((string)value);
						bool flag4 = !flag3;
						obj8 = 0;
						if (flag4)
						{
							goto IL_0285;
						}
						if (list != null)
						{
							System.__Canon[] items = list._items;
							int num = (int)obj13;
							int version = list._version + 1;
							list._version = version;
							if (list._items != null)
							{
								bool flag5 = list._size < items.Length;
								object obj18 = !flag5;
								if (obj18 == null)
								{
									object obj19 = list._items + list._size;
									num = list._size + 1;
									list._size = num;
									obj17 = obj19 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
									obj17 = 0;
									obj8 = 0;
									goto IL_052a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v6 (System.Int32)+20]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v18+A8]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v19+70]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
								list.AddWithResize((System.__Canon)0);
								goto IL_0285;
							}
						}
					}
					goto IL_04d2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
				nose = (Transform)0;
				obj17 = this + 152;
				obj8 = 0;
			}
			goto IL_052a;
			IL_0285:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+18]");
			obj10 = 0;
			obj14++;
			object obj22 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+18]");
			if ((nint)obj22 < 0)
			{
				continue;
			}
			goto IL_0484;
			IL_052a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_0285;
		}
		goto IL_04e0;
		IL_04d2:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04e0;
		IL_04e0:
		throw new IndexOutOfRangeException();
		IL_0484:
		if (list != null)
		{
			System.__Canon[] array = list.ToArray();
			object obj23 = this + 160;
			obj23 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		goto IL_04d2;
	}

	public unsafe bool Bar(out Vector3 back, out Vector3 tip, out Vector3 normal, out float half)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0668: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_0608: Expected I4, but got Obj
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected Obj, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected Obj, but got Unknown
		//IL_06ad: Expected Obj, but got I
		//IL_06d7: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_033d: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I4
		//IL_0872: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected Obj, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_0739: Expected Obj, but got I
		//IL_075f: Expected Obj, but got I4
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)null;
		ref Vector3 reference2 = ref *(Vector3*)null;
		_ = 0;
		_ = 0;
		ref Vector3 reference3 = ref *(Vector3*)null;
		ref float reference4 = ref *(float*)null;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = sprocket == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj17;
		object obj18;
		object obj20;
		object obj21;
		object obj23;
		object obj24 = default;
		object obj36 = default;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = nose == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				Transform[] array = links;
				if (links != null && array.Length >= 8)
				{
					if ((object)sprocket != null)
					{
						Vector3 position = sprocket.position;
						object obj8 = default;
						reference3 = ref *(Vector3*)obj8;
						if ((object)nose != null)
						{
							Vector3 position2 = nose.position;
							reference2 = ref *(Vector3*)obj8;
							object obj9 = obj8 - back;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X1 (UnityEngine.Vector3&)+8]");
							object obj11 = default;
							object obj10 = obj11 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj12 = 0;
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v22+E4]");
							bool flag7 = (nint)0 == 0;
							object obj14 = !flag7;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj15 = obj10 * obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
							if ((nint)obj15 < 0)
							{
								goto IL_04c0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							Transform[] array2 = links;
							if (links != null)
							{
								object obj16 = array2.Length;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								obj17 = obj9 / 0;
								obj18 = obj10 / obj15;
								bool flag8 = array2.Length < 1;
								object obj19 = obj15;
								obj20 = obj11;
								obj21 = obj15;
								object obj22 = obj17;
								obj23 = obj24;
								if (flag8)
								{
									goto IL_0487;
								}
								object obj25 = obj17 * obj17;
								object obj26 = obj24 * obj24;
								object obj27 = obj25 + obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
								object obj28 = 0;
								object obj29 = obj18 * obj18;
								object obj30 = obj29 + obj27;
								object obj32 = default;
								object obj31 = obj32;
								object obj33 = obj24;
								object obj34 = obj11;
								object obj35 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								obj36 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								object obj37 = 0;
								object obj38 = obj15;
								object obj39 = obj11;
								object obj40 = 0;
								while (true)
								{
									bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
									object obj41 = !flag9;
									if (obj41 != null)
									{
										break;
									}
									object obj42 = (object)links + obj40;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v23+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v23+20]");
										Vector3 position3 = ((Transform)0).position;
										object obj43 = obj28;
										obj23 = obj27 - back;
										object obj44 = obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X1 (UnityEngine.Vector3&)+4]");
										obj19 = obj44 - 0;
										object obj45 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X1 (UnityEngine.Vector3&)+8]");
										obj22 = obj45 - 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v25+A0]");
										object obj46 = 0;
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46))
										{
											object obj47 = obj17 * obj23;
											object obj48 = obj24 * obj19;
											object obj49 = obj18 * obj22;
											object obj50 = obj47 + obj48;
											object obj51 = obj49 + obj50;
											object obj52 = obj51 / obj30;
											object obj53 = obj17 * obj52;
											object obj54 = obj24 * obj52;
											object obj55 = obj18 * obj52;
											obj23 -= obj53;
											obj19 -= obj54;
											obj22 -= obj55;
											obj31 = obj17;
										}
										object obj56 = obj23 * obj23;
										object obj57 = obj19 * obj19;
										object obj58 = obj37 * obj37;
										object obj59 = obj38 * obj38;
										object obj60 = obj56 + obj57;
										object obj61 = obj22 * obj22;
										object obj62 = obj58 + obj59;
										object obj63 = obj39 * obj39;
										object obj64 = obj60 + obj61;
										object obj65 = obj62 + obj63;
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj64) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65))
										{
											obj34 = obj22;
											obj35 = obj19;
											obj36 = obj23;
											obj37 = obj23;
											obj38 = obj19;
											obj39 = obj22;
										}
										obj16 = array2.Length;
										obj40++;
										bool flag10 = (nint)obj40 < array2.Length;
										obj20 = obj34;
										obj21 = obj35;
										obj33 = obj19;
										obj29 = obj22;
										obj27 = obj23;
										if (flag10)
										{
											continue;
										}
										goto IL_0487;
									}
									goto IL_05ec;
								}
								goto IL_05fa;
							}
						}
					}
					goto IL_05ec;
				}
			}
		}
		goto IL_04c0;
		IL_05ec:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05fa;
		IL_05fa:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_0487:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
		reference4 = ref *(float*)obj23;
		object obj66 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if ((nint)obj66 < 0)
		{
			goto IL_04c0;
		}
		object obj67 = obj24 * obj20;
		object obj68 = obj18 * obj21;
		object obj69 = obj18 * obj36;
		object obj70 = obj17 * obj20;
		object obj71 = obj17 * obj21;
		object obj72 = obj24 * obj36;
		object obj73 = obj67 - obj68;
		object obj74 = obj69 - obj70;
		object obj75 = obj71 - obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
		reference = ref *(Vector3*)obj75;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj77 = default;
		object obj76 = obj17 * obj77;
		object obj78 = obj18 * half;
		object obj79 = obj76 * obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj80 = obj78 * 0;
		object obj81 = tip + obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tip @ X2 (UnityEngine.Vector3&)+8]");
		object obj82 = 0 + obj80;
		reference2 = ref *(Vector3*)obj81;
		return true;
		IL_04c0:
		return false;
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1eda: Expected F4, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_2166: Expected VT, but got Ref
		//IL_216e: Expected VT, but got Ref
		//IL_0095: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_011a: Expected F4, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Ref, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Ref, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Ref, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Ref, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I4
		//IL_1efd: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ec: Expected Obj, but got I
		//IL_2303: Unknown result type (might be due to invalid IL or missing references)
		//IL_2312: Expected VT, but got I4
		//IL_2318: Unknown result type (might be due to invalid IL or missing references)
		//IL_2322: Unknown result type (might be due to invalid IL or missing references)
		//IL_232f: Expected F4, but got I4
		//IL_2338: Expected Obj, but got I4
		//IL_233c: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d1: Expected VT, but got Ref
		//IL_19d9: Expected VT, but got Ref
		//IL_033b: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got I4
		//IL_1e19: Expected F4, but got I4
		//IL_1f7e: Expected Obj, but got I4
		//IL_1e78: Expected Obj, but got I4
		//IL_1e88: Expected Ref, but got VT
		//IL_1e90: Expected Ref, but got VT
		//IL_2361: Unknown result type (might be due to invalid IL or missing references)
		//IL_2375: Unknown result type (might be due to invalid IL or missing references)
		//IL_237d: Expected Obj, but got Unknown
		//IL_239f: Expected Obj, but got I4
		//IL_229b: Expected Obj, but got I
		//IL_22a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ac: Expected Ref, but got Unknown
		//IL_22c6: Expected Obj, but got I4
		//IL_0b92: Invalid comparison between F4 and I4
		//IL_0ba3: Expected Obj, but got I4
		//IL_0bb3: Expected VT, but got Ref
		//IL_0bbb: Expected VT, but got Ref
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected Obj, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected VT, but got I4
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected F4, but got I4
		//IL_0477: Expected Obj, but got I4
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got I
		//IL_04dc: Expected Obj, but got I4
		//IL_0c26: Expected Obj, but got I
		//IL_0c50: Expected Obj, but got I4
		//IL_2003: Expected Obj, but got I
		//IL_0c08: Expected Obj, but got I4
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected VT, but got I4
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected F4, but got I4
		//IL_0583: Expected Obj, but got I4
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Expected Obj, but got I
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Expected Obj, but got I
		//IL_0ca3: Expected VT, but got Ref
		//IL_05bc: Expected Obj, but got I
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected VT, but got I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected F4, but got I4
		//IL_060a: Expected Obj, but got I4
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2224: Expected Obj, but got I
		//IL_2239: Unknown result type (might be due to invalid IL or missing references)
		//IL_2246: Expected F4, but got I4
		//IL_224f: Expected Obj, but got I4
		//IL_2253: Unknown result type (might be due to invalid IL or missing references)
		//IL_225b: Unknown result type (might be due to invalid IL or missing references)
		//IL_226f: Expected Ref, but got VT
		//IL_0cd2: Expected Obj, but got I4
		//IL_0cf9: Expected Obj, but got F4
		//IL_0693: Expected Obj, but got I4
		//IL_0d28: Invalid comparison between F4 and I4
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3f: Expected F4, but got I4
		//IL_0d48: Expected Obj, but got I4
		//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected Ref, but got VT
		//IL_06c1: Expected Obj, but got I
		//IL_06e6: Expected Obj, but got I4
		//IL_06f6: Expected Obj, but got I
		//IL_0d89: Expected Obj, but got F4
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected F4, but got I4
		//IL_0db6: Expected Obj, but got I4
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected Ref, but got VT
		//IL_0e26: Expected Obj, but got F4
		//IL_0e3d: Expected Obj, but got F4
		//IL_0e4b: Expected Obj, but got I4
		//IL_0e53: Expected VT, but got Obj
		//IL_0e5b: Expected Ref, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DB8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaSkin._003C_003Ec__DisplayClass61_0 obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		float num = 0f;
		UnityEngine.Object obj3 = null;
		ref Vector3 reference2 = default;
		ref float reference3 = default;
		NullReferenceException ex9;
		Vector3 vector;
		Vector3 vector2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj2 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = this + 40;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj4;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X21_v6-8]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			ref Vector3 reference = ref *(Vector3*)null;
			if (obj9 == null)
			{
				RobotSaw robotSaw = saw;
				bool flag5 = (object)saw == null;
				num = 0f;
				reference = ref *(Vector3*)null;
				obj3 = null;
				if (flag5)
				{
					goto IL_1d6e;
				}
				bool flag6 = robotSaw.phase != (RobotSaw.Phase)2;
				reference = ref *(Vector3*)null;
				if (!flag6)
				{
					ref Vector3 back = ref *(Vector3*)(obj2 + 24);
					reference = ref *(Vector3*)(obj2 + 36);
					reference2 = ref *(Vector3*)(obj2 + 52);
					reference3 = ref *(float*)(obj2 + 48);
					if (Bar(out back, out reference, out reference2, out reference3))
					{
						float deltaTime = Time.deltaTime;
						List<System.__Canon> list = (List<System.__Canon>)(obj2 + 72);
						list = (List<System.__Canon>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 0;
						list._items = null;
						list._size = 0;
						_ = 0;
						bool flag7 = inPart == null;
						num = deltaTime;
						obj3 = null;
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6E38]");
							object obj10 = 0;
							obj3 = (UnityEngine.Object)obj10;
							((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)inPart).Clear();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
							object obj11 = 0;
							object obj12 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X0_v33+E4]");
							bool flag8 = (nint)0 == 0;
							object obj13 = !flag8;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj12 = obj11;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X0_v33+A0]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v13+8]");
							bool flag9 = (nint)0 == 0;
							num = deltaTime;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v13+8]");
								Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
								object obj16 = 0;
								Enumerator<, > val2 = default;
								Enumerator<, > val = (Enumerator<, >)(ref val2);
								UnityEngine.Object obj19 = default;
								float num4 = default;
								object obj36 = default;
								float num6 = default;
								UnityEngine.Object obj25 = default;
								while (true)
								{
									Enumerator<, > val4;
									UnityEngine.Object obj29;
									Enumerator<, > val3;
									Dictionary<System.__Canon, float>.Enumerator enumerator2;
									Enumerator<, > val5;
									float num3;
									object obj27;
									Enumerator<, > val6;
									if (val2.MoveNext())
									{
										object obj17 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ X0_v202+E4]");
										bool flag10 = (nint)0 == 0;
										object obj18 = !flag10;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag11 = obj19 != null;
										bool flag12 = !flag11;
										reference = ref *(Vector3*)null;
										if (flag12)
										{
											continue;
										}
										object obj20 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X0_v206+E4]");
										bool flag13 = (nint)0 == 0;
										object obj21 = !flag13;
										if (obj21 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj22 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X0_v210+E4]");
										bool flag14 = (nint)0 == 0;
										object obj23 = !flag14;
										if (obj23 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj22 = obj11;
										}
										object obj24 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X0_v210+A0]");
										val = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v119+E4]");
										int num2 = 0;
										obj25 = (UnityEngine.Object)val;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v119+E4]");
										bool flag15 = (nint)0 == 0;
										object obj26 = !flag15;
										if (obj26 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag16 = obj19 != obj25;
										bool flag17 = !flag16;
										reference = ref *(Vector3*)null;
										if (flag17)
										{
											continue;
										}
										bool flag18 = (object)obj19 == null;
										val3 = (Enumerator<, >)0;
										enumerator2 = (Dictionary<System.__Canon, float>.Enumerator)0;
										val4 = (Enumerator<, >)0;
										val5 = (Enumerator<, >)0;
										num3 = 0f;
										obj27 = 0;
										val6 = (Enumerator<, >)(ref val2);
										num = num4;
										reference = ref *(Vector3*)null;
										obj3 = obj25;
										if (!flag18)
										{
											object obj28 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ stack_-180 (UnityEngine.Object)+A8]");
											obj29 = (UnityEngine.Object)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X0_v214+E4]");
											bool flag19 = (nint)0 == 0;
											object obj30 = !flag19;
											if (obj30 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag20 = obj29 != null;
											bool flag21 = !flag20;
											obj25 = obj29;
											reference = ref *(Vector3*)null;
											if (flag21)
											{
												continue;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ stack_-180 (UnityEngine.Object)+A8]");
											bool flag22 = (nint)0 == 0;
											val3 = (Enumerator<, >)0;
											enumerator2 = (Dictionary<System.__Canon, float>.Enumerator)0;
											val4 = (Enumerator<, >)0;
											val5 = (Enumerator<, >)0;
											num3 = 0f;
											obj27 = 0;
											val6 = (Enumerator<, >)(ref val2);
											num = num4;
											reference = ref *(Vector3*)null;
											obj3 = null;
											if (flag22)
											{
												goto IL_1975;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ stack_-180 (UnityEngine.Object)+A8]");
											GameObject gameObject = ((Component)0).gameObject;
											bool flag23 = (object)gameObject == null;
											val3 = (Enumerator<, >)0;
											enumerator2 = (Dictionary<System.__Canon, float>.Enumerator)0;
											val4 = (Enumerator<, >)0;
											val5 = (Enumerator<, >)0;
											num3 = 0f;
											obj27 = 0;
											val6 = (Enumerator<, >)(ref val2);
											num = num4;
											reference = ref *(Vector3*)null;
											obj3 = null;
											if (!flag23)
											{
												bool activeInHierarchy = gameObject.activeInHierarchy;
												bool flag24 = !activeInHierarchy;
												obj25 = obj29;
												reference = ref *(Vector3*)null;
												if (!flag24)
												{
													object obj31 = obj16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1930 @ X0_v221+E4]");
													bool flag25 = (nint)0 == 0;
													object obj32 = !flag25;
													if (obj32 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ stack_-180 (UnityEngine.Object)+A8]");
													GillaWounds gillaWounds = GillaWounds.On((Dismemberment)0);
													obj2._003CLateUpdate_003Eg__Try_007C0((NetworkApe)obj19, null, null, gillaWounds);
													object obj33 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ stack_-180 (UnityEngine.Object)+A8]");
													obj25 = (UnityEngine.Object)0;
													reference3 = ref *(float*)gillaWounds;
													reference2 = ref *(Vector3*)null;
													reference = ref *(Vector3*)null;
												}
												continue;
											}
											goto IL_1983;
										}
										NullReferenceException ex = new NullReferenceException();
										goto IL_1951;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
									object obj34 = 0;
									obj3 = (UnityEngine.Object)obj34;
									val2.Dispose();
									val3 = (Enumerator<, >)0;
									enumerator2 = (Dictionary<System.__Canon, float>.Enumerator)0;
									val4 = (Enumerator<, >)0;
									val5 = (Enumerator<, >)0;
									num3 = 0f;
									obj27 = 0;
									val6 = (Enumerator<, >)(ref val2);
									num = num4;
									while (true)
									{
										IL_19c0:
										OutOfMemoryException ex2 = new OutOfMemoryException();
										vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
										vector2 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
										object obj37;
										float num5;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
											object obj35;
											if ((nint)obj3 == 2)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
												num3 = 1f;
												obj35 = obj27;
											}
											else
											{
												if ((nint)obj3 != 1)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
												obj35 = obj36;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
												obj27 = obj36;
											}
											obj37 = 0;
											num5 = num3;
											reference3 = ref *(float*)vector;
											reference2 = ref *(Vector3*)vector2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C40]");
											object obj38 = 0;
											obj3 = (UnityEngine.Object)obj38;
											((Enumerator<, >*)val6)->Dispose();
											bool flag26 = obj35 == null;
											object obj39 = !flag26;
											num3 = num5;
											if (obj39 != null)
											{
												goto IL_19c0;
											}
											bool flag27 = num5 == 0f;
											object obj40 = !flag27;
											num3 = num5;
											vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
											vector2 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
											ex2 = (OutOfMemoryException)val6;
											if (obj40 != null)
											{
												continue;
											}
											goto IL_0bd1;
										}
										break;
										IL_0bd1:
										if ((nint)obj37 != 9)
										{
											bool flag28 = obj37 == null;
											object obj41 = !flag28;
											if (obj41 != null)
											{
												return;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
										object obj42 = 0;
										object obj43 = obj42;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ X0_v42+E4]");
										bool flag29 = (nint)0 == 0;
										object obj44 = !flag29;
										if (obj44 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj43 = obj42;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ X0_v42+A0]");
										object obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v24+8]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v24+8]");
											Enumerator<, > enumerator3 = ((List<System.__Canon>)0).GetEnumerator();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CC0]");
											object obj46 = 0;
											vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
											while (val4.MoveNext())
											{
												object obj47 = obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ X0_v124+E4]");
												bool flag30 = (nint)0 == 0;
												object obj48 = !flag30;
												if (obj48 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag31 = (UnityEngine.Object)num5 != null;
												bool flag32 = !flag31;
												reference = ref *(Vector3*)null;
												if (flag32)
												{
													continue;
												}
												bool flag33 = num5 == 0f;
												val4 = (Enumerator<, >)num6;
												num3 = 0f;
												obj27 = 0;
												val = (Enumerator<, >)(ref val4);
												val6 = (Enumerator<, >)(ref val4);
												num = num6;
												reference3 = ref *(float*)vector;
												reference = ref *(Vector3*)null;
												obj3 = null;
												if (flag33)
												{
													goto IL_1951;
												}
												GameObject gameObject2 = ((Component)num5).gameObject;
												bool flag34 = (object)gameObject2 == null;
												val4 = (Enumerator<, >)num6;
												num3 = 0f;
												obj27 = 0;
												val = (Enumerator<, >)(ref val4);
												val6 = (Enumerator<, >)(ref val4);
												num = num6;
												reference3 = ref *(float*)vector;
												reference = ref *(Vector3*)null;
												obj3 = null;
												if (!flag34)
												{
													bool activeInHierarchy2 = gameObject2.activeInHierarchy;
													bool flag35 = !activeInHierarchy2;
													reference = ref *(Vector3*)null;
													if (!flag35)
													{
														GillaWounds sawable = ((GillaCorpse)num5).Sawable;
														obj2._003CLateUpdate_003Eg__Try_007C0(null, null, (GillaCorpse)num5, sawable);
														object obj33 = 0;
														vector = (Vector3)sawable;
														reference2 = ref *(Vector3*)num5;
														reference = ref *(Vector3*)null;
													}
													continue;
												}
												goto IL_195f;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CA8]");
											object obj49 = 0;
											obj3 = (UnityEngine.Object)obj49;
											val4.Dispose();
											val4 = (Enumerator<, >)num6;
											num3 = 0f;
											obj27 = 0;
											val = (Enumerator<, >)(ref val4);
											val6 = (Enumerator<, >)(ref val4);
											num = num6;
											reference3 = ref *(float*)vector;
											continue;
										}
										goto IL_1d6e;
									}
									break;
									IL_1975:
									NullReferenceException ex3 = new NullReferenceException();
									goto IL_1983;
									IL_1983:
									NullReferenceException ex4 = new NullReferenceException();
									NullReferenceException ex5 = new NullReferenceException();
									NullReferenceException ex6 = new NullReferenceException();
									obj25 = obj29;
									throw new NullReferenceException();
									IL_195f:
									NullReferenceException ex7 = new NullReferenceException();
									obj29 = obj25;
									goto IL_1975;
									IL_1951:
									NullReferenceException ex8 = new NullReferenceException();
									goto IL_195f;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7A8");
								NullReferenceException ex10 = default;
								ex9 = ex10;
								goto IL_1e95;
							}
						}
						goto IL_1d6e;
					}
				}
			}
			Forget();
			DropForeseen(all: true);
			return;
		}
		goto IL_1d6e;
		IL_1d6e:
		NullReferenceException ex11 = new NullReferenceException();
		NullReferenceException ex12 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC20");
		ex9 = ex12;
		vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
		vector2 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		goto IL_1e95;
		IL_1e95:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private unsafe void Foresee(UnityEngine.Object who, GillaWounds w, GoreSection section, Vector3 onBar, Vector3 onShape, float radius, Vector3 normal, Vector3 limb)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05dc: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_011e: Invalid comparison between VT and I4
		//IL_012c: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_0240: Expected Ref, but got VT
		//IL_0240: Expected VT, but got Obj
		//IL_0240: Expected VT, but got Ref
		//IL_026a: Invalid comparison between VT and I4
		//IL_0278: Expected VT, but got Ref
		//IL_0280: Expected Obj, but got I4
		//IL_0288: Expected VT, but got Obj
		//IL_0164: Expected Obj, but got VT
		//IL_017a: Invalid comparison between F4 and I
		//IL_043d: Expected Obj, but got I
		//IL_045d: Expected Obj, but got Ref
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_02a6: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I
		//IL_04b1: Expected VT, but got I
		//IL_0302: Expected Obj, but got I
		//IL_0322: Expected VT, but got Obj
		//IL_01ee: Expected Obj, but got VT
		//IL_0209: Expected Obj, but got I4
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_03ec: Invalid comparison between VT and I4
		//IL_0524: Expected Obj, but got Ref
		//IL_0338: Expected Obj, but got Ref
		//IL_0352: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I4
		//IL_03a6: Expected VT, but got Ref
		//IL_03a6: Expected VT, but got Ref
		//IL_03c4: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I4
		//IL_03d5: Expected VT, but got Ref
		//IL_055a: Expected VT, but got Ref
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = section & (GoreSection)0xFF;
		object obj5 = section & (GoreSection)0xFE;
		object obj6 = obj4 - 2;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		ApePart part = ((obj8 != null) ? ((ApePart)1) : ((ApePart)2));
		if ((nint)obj5 == 2)
		{
			bool flag3 = w.Stump(part);
			bool flag4 = !flag3;
			object obj9 = !flag4;
			if (obj9 != null)
			{
				return;
			}
		}
		(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) tuple = ((System.__Canon)(object)who, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)section);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7058]");
		object obj10 = 0;
		bool flag5 = ((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)this.foreseen).TryGetValue(tuple, out *(System.__Canon*)null);
		Vector3 vector = default;
		bool flag6 = vector == (Vector3)(object)0;
		GillaSawHits gillaSawHits = (GillaSawHits)flag5;
		if (!flag6)
		{
			float time = Time.time;
			float time2 = Time.time;
			float num = time2 - ((Foreseen)vector).at;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			if (num < 0f)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v53+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = Done((Foreseen)vector);
			bool flag9 = !flag8;
			gillaSawHits = (GillaSawHits)flag8;
			if (flag9)
			{
				return;
			}
		}
		object obj14 = default;
		float radius2 = default;
		if (!gillaSawHits.PlaneOf(w, section, (Vector3)(&obj14), (Vector3)obj10, radius2, onShape, normal, out *(Plane*)limb))
		{
			return;
		}
		bool flag10 = vector == (Vector3)(object)0;
		Vector3 vector2 = (Vector3)(&obj14);
		Foreseen foreseen = (Foreseen)section;
		(UnityEngine.Object, GoreSection) tuple2 = ((UnityEngine.Object, GoreSection))w;
		object obj19 = default;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v37+E4]");
			bool flag11 = (nint)0 == 0;
			object obj17 = !flag11;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ stack_-98_v4 (UnityEngine.Vector3)+10]");
			bool flag12 = (UnityEngine.Object)0 == w;
			bool flag13 = !flag12;
			foreseen = null;
			tuple2 = ((UnityEngine.Object, GoreSection))w;
			if (!flag13)
			{
				object obj18 = (object)(&obj19);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
				object obj20 = 0;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v45+E4]");
				bool flag14 = (nint)0 == 0;
				object obj22 = !flag14;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj23 = default;
				object obj24 = default;
				bool flag15 = Near((GillaRip.Along)(&obj23), (GillaRip.Along)(&obj24));
				bool flag16 = !flag15;
				object obj25 = !flag16;
				foreseen = (Foreseen)80;
				tuple2 = ((UnityEngine.Object, GoreSection))(&obj24);
				if (obj25 != null)
				{
					return;
				}
			}
			bool flag17 = vector == (Vector3)(object)0;
			vector2 = vector;
			if (!flag17)
			{
				Drop(((UnityEngine.Object, GoreSection))tuple, null);
				vector2 = vector;
				foreseen = null;
				tuple2 = ((UnityEngine.Object, GoreSection))tuple;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7068]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Foreseen foreseen2 = default;
		foreseen2._002Ector();
		object obj27 = (object)(&obj19);
		object obj28 = foreseen2 + 16;
		obj28 = w;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7050]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X23_v6+28]");
		foreseen2.along = (GillaRip.Along)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X23_v6+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		CancellationTokenSource cancellationTokenSource = default;
		cancellationTokenSource._002Ector();
		object obj30 = foreseen2 + 72;
		obj30 = cancellationTokenSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float time3 = Time.time;
		float time4 = Time.time;
		object obj32 = default;
		object obj31 = (object)(&obj32);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		CancellationToken token = ((CancellationTokenSource)obj30).Token;
		object obj33 = default;
		List<Mesh> list = w.BeginSaw(section, (GillaRip.Along)(&obj33), token);
		object obj34 = foreseen2 + 64;
		obj34 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)this.foreseen).set_Item(tuple, (System.__Canon)null);
		int num2 = Foresaw__BackingField + 1;
		Foresaw__BackingField = num2;
	}

	private unsafe static bool Near(GillaRip.Along a, GillaRip.Along b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I4
		//IL_0031: Expected VT, but got Ref
		//IL_0031: Expected VT, but got Ref
		//IL_0053: Expected Obj, but got I4
		//IL_0070: Invalid comparison between F4 and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got VT
		//IL_0123: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I4
		//IL_023e: Invalid comparison between F4 and I
		//IL_024f: Expected Obj, but got I4
		//IL_026f: Invalid comparison between F4 and I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector = default;
		Vector3 vector2 = default;
		float num = Turned((GillaRip.Along)(&vector), (GillaRip.Along)(&vector2));
		bool flag2 = (double)num < 15.0;
		object obj4 = !flag2;
		float num2 = num - 15f;
		bool flag3 = num2 == 0f;
		object obj5 = ~obj4;
		object obj6 = obj5 | flag3;
		if (obj6 == null)
		{
			return false;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = a.n * b.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
		object obj10 = num3 * 0;
		object obj11 = obj9 + obj10;
		object obj13 = default;
		object obj12 = obj13 + obj11;
		float num4 = 0f - b.off;
		bool flag5 = (nint)obj12 < 0;
		object obj14 = obj12 ^ obj12;
		object obj15 = obj12 & obj14;
		bool flag6 = (nint)obj15 < 0;
		bool flag7 = flag5 == flag6;
		object obj16 = !flag7;
		object obj17 = ~obj16;
		float num5 = ((obj17 != null) ? num4 : b.off);
		float num6 = a.off + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		bool flag8 = num6 < 0f;
		object obj18 = !flag8;
		float num7 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		float num8 = num7 - 0f;
		bool flag9 = num8 == 0f;
		object obj19 = ~obj18;
		return (byte)((obj19 | flag9) ? 1 : 0) != 0;
	}

	private static float Turned(GillaRip.Along a, GillaRip.Along b)
	{
		//IL_0301: Expected Obj, but got VT
		//IL_031e: Expected Obj, but got I
		//IL_0335: Expected Obj, but got VT
		//IL_0352: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I4
		//IL_003d: Expected F8, but got I4
		//IL_04b8: Expected Obj, but got VT
		//IL_04d5: Expected Obj, but got I
		//IL_04f4: Expected Obj, but got VT
		//IL_0511: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I
		//IL_05a1: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got VT
		//IL_007f: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_019e: Expected F8, but got I4
		//IL_0437: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got VT
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		object obj = a.n * a.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
		object obj2 = num * 0;
		object obj3 = b.n * b.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
		object obj4 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+8]");
		object obj8 = num3 * 0;
		object obj9 = obj3 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+8]");
		object obj10 = num4 * 0;
		object obj11 = obj8 + obj7;
		object obj12 = obj10 + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
		bool flag2 = (nint)obj11 < 0;
		double num5 = 0.0;
		if (!flag2)
		{
			object obj14 = a.n * b.n;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
			object obj15 = num6 * 0;
			object obj16 = obj14 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+8]");
			object obj17 = num7 * 0;
			object obj18 = obj17 + obj16;
			double num8 = (double)obj18 / (double)obj11;
			bool flag3 = num8 < -1.0;
			double num9 = -1.0;
			if (!flag3)
			{
				bool flag4 = !(num8 > 1.0);
				num9 = num8;
				if (!flag4)
				{
					num9 = 1.0;
				}
			}
			object obj19 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
			double num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			num5 = num10 * 0.0;
		}
		object obj21 = a.n * a.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
		object obj22 = num11 * 0;
		object obj23 = obj5;
		object obj24 = b.n * b.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
		object obj25 = num12 * 0;
		object obj26 = obj21 + obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+8]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+8]");
		object obj27 = num13 * 0;
		object obj28 = obj24 + obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+8]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+8]");
		object obj29 = num14 * 0;
		object obj30 = obj27 + obj26;
		object obj31 = obj29 + obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj32 = !flag6;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
		bool flag7 = (nint)obj30 < 0;
		double num15 = 0.0;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
			object obj33 = -0;
			object obj34 = a.n * b.n;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
			object obj35 = 0 * obj33;
			object obj36 = obj35 - obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+8]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+8]");
			object obj37 = num16 * 0;
			object obj38 = obj36 - obj37;
			double num17 = (double)obj38 / (double)obj30;
			bool flag8 = num17 < -1.0;
			double num18 = -1.0;
			if (!flag8)
			{
				bool flag9 = !(num17 > 1.0);
				num18 = num17;
				if (!flag9)
				{
					num18 = 1.0;
				}
			}
			object obj39 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v10+E4]");
			bool flag10 = (nint)0 == 0;
			object obj40 = !flag10;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
			double num19 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			num15 = num19 * 0.0;
		}
		if (num5 < num15)
		{
			return (float)num5;
		}
		return (float)num15;
	}

	private static float Moved(GillaRip.Along a, GillaRip.Along b)
	{
		//IL_0017: Expected Obj, but got VT
		//IL_0034: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		object obj = a.n * b.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (GillaRip+Along)+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (GillaRip+Along)+4]");
		object obj2 = num * 0;
		object obj3 = obj + obj2;
		object obj5 = default;
		object obj4 = obj5 + obj3;
		float num2 = 0f - b.off;
		bool flag = (nint)obj4 < 0;
		object obj6 = obj4 ^ obj4;
		object obj7 = obj4 & obj6;
		bool flag2 = (nint)obj7 < 0;
		bool flag3 = flag == flag2;
		object obj8 = !flag3;
		object obj9 = ~obj8;
		float num3 = ((obj9 != null) ? num2 : b.off);
		float result = a.off + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		return result;
	}

	private unsafe static bool Done(Foreseen f)
	{
		//IL_02ab: Expected Obj, but got I4
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected I4, but got Unknown
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got I4
		//IL_043d: Expected Obj, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0125: Expected VT, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got I4
		//IL_01bc: Expected VT, but got Ref
		//IL_01da: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected VT, but got Ref
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected VT, but got Ref
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got I4
		object obj16;
		if ((object)f.meshes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
			object obj4 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)f.meshes).GetEnumerator();
			UnityEngine.Object obj6 = default;
			UnityEngine.Object obj5 = obj6;
			GillaRip.Along along2 = default;
			GillaRip.Along along = along2;
			Enumerator<, > val2 = default;
			Enumerator<, > val = (Enumerator<, >)(ref val2);
			Enumerator<, > val4 = default;
			Enumerator<, > val3 = val4;
			UnityEngine.Object obj8 = default;
			UnityEngine.Object obj7 = obj8;
			bool flag;
			Enumerator<, > val7 = default;
			while (true)
			{
				flag = val2.MoveNext();
				bool flag2 = !flag;
				UnityEngine.Object obj9 = obj5;
				GillaRip.Along along3 = along;
				Enumerator<, > val5 = val;
				Enumerator<, > val6 = val3;
				UnityEngine.Object obj10 = obj7;
				if (flag2)
				{
					break;
				}
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v30+E4]");
				obj7 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = obj8 != null;
				bool flag5 = !flag4;
				along = (GillaRip.Along)0;
				if (!flag5)
				{
					object obj13 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X0 (GillaSawHits+Foreseen)+28]");
					obj9 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X0 (GillaSawHits+Foreseen)+38]");
					obj10 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v34+E4]");
					val5 = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v34+E4]");
					bool flag6 = (nint)0 == 0;
					object obj14 = !flag6;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag7 = GillaRip.IsReady((Mesh)obj8, 9, (GillaRip.Along)(&val7));
					bool flag8 = !flag7;
					object obj15 = !flag8;
					val7 = (Enumerator<, >)f.along;
					along3 = (GillaRip.Along)(&val7);
					val6 = (Enumerator<, >)f.along;
					val7 = (Enumerator<, >)f.along;
					obj5 = obj9;
					along = (GillaRip.Along)(&val7);
					val = val5;
					val3 = (Enumerator<, >)f.along;
					obj7 = obj10;
					if (obj15 == null)
					{
						break;
					}
				}
			}
			obj16 = (flag ? 1 : 0) ^ 1;
			UnityEngine.Object obj17 = null;
			val2 = val4;
			Enumerator<, > val8 = (Enumerator<, >)(ref val2);
			object obj18 = 0;
			IntPtr intPtr = default;
			object obj22 = default;
			object obj20 = default;
			UnityEngine.Object obj21 = default;
			bool result = default;
			Enumerator<, > val9 = default;
			object obj23 = default;
			while (true)
			{
				val2.Dispose();
				bool flag9 = obj18 == null;
				object obj19 = !flag9;
				val2 = (Enumerator<, >)0;
				if (obj19 != null)
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					switch ((long)intPtr)
					{
					case 2L:
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj17 = (UnityEngine.Object)1;
						UnityEngine.Object obj10 = (UnityEngine.Object)1;
						obj18 = obj22;
						break;
					}
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj18 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj17 = obj21;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
					UnityEngine.Object obj9 = obj6;
					GillaRip.Along along3 = along2;
					Enumerator<, > val6 = val9;
					obj4 = obj23;
					obj16 = 1;
					continue;
				}
				break;
			}
			if ((object)obj17 == null)
			{
				goto IL_03e4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		}
		obj16 = 1;
		goto IL_03e4;
		IL_03e4:
		return (byte)(obj16 & 1) != 0;
	}

	private unsafe void Drop((UnityEngine.Object, GoreSection) key, Foreseen f)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_002d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0109: Expected VT, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Ref
		//IL_023e: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got I4
		//IL_0412: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got Ref
		//IL_02e0: Invalid comparison between VT and I4
		//IL_01c9: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I4
		//IL_0340: Invalid comparison between VT and I4
		//IL_0217: Expected VT, but got Ref
		//IL_0227: Expected Obj, but got I
		//IL_022f: Expected Obj, but got Ref
		//IL_0319: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC06]");
		object obj = 0;
		bool flag = (object)this.foreseen == null;
		IntPtr intPtr = default;
		nint num = intPtr;
		(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))key;
		Foreseen foreseen = default;
		Foreseen foreseen2;
		(UnityEngine.Object, GoreSection) tuple2;
		object obj2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7098]");
			obj = 0;
			num = (nint)obj;
			bool flag2 = ((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)this.foreseen).Remove(((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))key);
			bool flag3 = intPtr == (IntPtr)0;
			tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))key;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X3 (Il2CppMethodInfo)+48]");
				bool flag4 = (nint)0 == 0;
				tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))key;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X3 (Il2CppMethodInfo)+48]");
					((CancellationTokenSource)0).Cancel();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X3 (Il2CppMethodInfo)+40]");
					if ((nint)0 == 0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
					GillaSawHits gillaSawHits = (GillaSawHits)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
					tuple2 = ((UnityEngine.Object, GoreSection))0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X3 (Il2CppMethodInfo)+40]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Enumerator<, > val = default;
					obj = (object)(&val);
					object obj8 = default;
					while (val.MoveNext())
					{
						object obj4 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v31+E4]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v31+E4]");
						bool flag5 = (nint)0 == 0;
						object obj5 = !flag5;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = (UnityEngine.Object)null != (UnityEngine.Object)null;
						bool flag7 = !flag6;
						foreseen = null;
						if (!flag7)
						{
							object obj6 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X3 (Il2CppMethodInfo)+38]");
							obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v35+E4]");
							bool flag8 = (nint)0 == 0;
							object obj7 = !flag8;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaRip.Forget(null, 9, (GillaRip.Along)(&obj8));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X3 (Il2CppMethodInfo)+18]");
							obj8 = 0;
							foreseen = (Foreseen)(&obj8);
						}
					}
					object obj9 = 0;
					object obj10 = 0;
					Enumerator<, > val2 = (Enumerator<, >)(ref val);
					object obj11 = 0;
					object obj14 = default;
					while (true)
					{
						tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))tuple2;
						val.Dispose();
						bool flag9 = obj11 == null;
						object obj12 = !flag9;
						foreseen2 = foreseen;
						if (obj12 == null)
						{
							bool flag10 = obj9 == null;
							object obj13 = !flag10;
							foreseen2 = foreseen;
							OutOfMemoryException ex = (OutOfMemoryException)(&val);
							if (obj13 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if (tuple == ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))(object)2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj9 = 1;
							foreseen = foreseen2;
							obj = 1;
							obj11 = obj10;
							continue;
						}
						if (tuple != ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))(object)1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj11 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj10 = obj14;
						foreseen = foreseen2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
			}
		}
		foreseen2 = foreseen;
		tuple2 = key;
		obj2 = 109891584;
		throw new NullReferenceException();
	}

	private unsafe void DropForeseen(bool all)
	{
		//IL_0010: Expected VT, but got I
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected VT, but got I4
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_090f: Expected VT, but got Obj
		//IL_0061: Expected VT, but got I
		//IL_0071: Expected Obj, but got I
		//IL_0083: Expected I4, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected VT, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0141: Expected VT, but got Ref
		//IL_061e: Expected Obj, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected VT, but got I4
		//IL_0638: Expected Obj, but got I4
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected VT, but got Ref
		//IL_065f: Expected Obj, but got I4
		//IL_0afd: Expected I4, but got Obj
		//IL_0b06: Expected Ref, but got VT
		//IL_0b20: Expected Obj, but got I4
		//IL_0b28: Expected Obj, but got VT
		//IL_0160: Expected Obj, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Invalid comparison between VT and I4
		//IL_0686: Expected Obj, but got I4
		//IL_068e: Expected Obj, but got VT
		//IL_0696: Expected Obj, but got VT
		//IL_0852: Expected VT, but got I4
		//IL_085b: Expected Obj, but got I4
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected VT, but got Ref
		//IL_01be: Expected VT, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got VT
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected I4, but got Obj
		//IL_0472: Expected VT, but got I
		//IL_0490: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_023a: Expected I, but got Obj
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got VT
		//IL_04ca: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Invalid comparison between Unknown and I4
		//IL_0279: Expected I, but got Obj
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected VT, but got Ref
		//IL_06e3: Expected Obj, but got I4
		//IL_05b3: Expected Obj, but got I
		//IL_05c3: Expected VT, but got I
		//IL_05d3: Expected Obj, but got I
		//IL_05e0: Expected VT, but got Obj
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected Obj, but got I
		//IL_0745: Expected Obj, but got Ref
		//IL_051e: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected VT, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected VT, but got I
		//IL_0326: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I4
		//IL_0378: Expected I, but got Obj
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected VT, but got I
		//IL_0aa5: Expected I4, but got VT
		//IL_0ab7: Expected VT, but got I4
		//IL_0ac0: Expected Obj, but got I4
		//IL_0ac8: Expected VT, but got Ref
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_0787: Expected VT, but got I4
		//IL_0790: Expected Obj, but got I4
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected VT, but got Unknown
		//IL_07a8: Expected VT, but got Ref
		//IL_07b0: Expected VT, but got Ref
		//IL_03bc: Expected Obj, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected VT, but got Unknown
		//IL_03de: Invalid comparison between VT and F8
		//IL_03ec: Expected I, but got Obj
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected I, but got Obj
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got I
		//IL_07d1: Expected VT, but got I4
		//IL_07e7: Expected VT, but got I4
		//IL_07fc: Expected I, but got Obj
		//IL_096a: Expected VT, but got I4
		//IL_0973: Expected VT, but got I4
		//IL_09d2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC07]");
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
		bool flag = (object)this.foreseen == null;
		Enumerator<, > val = (Enumerator<, >)0;
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator2 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		bool flag2 = all;
		GillaSawHits gillaSawHits = this;
		List<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)> list = (List<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)109891584;
		List<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)> list2 = default;
		UnityEngine.Object obj8 = default;
		Enumerator<, > val3 = default;
		UnityEngine.Object obj9;
		UnityEngine.Object obj11;
		nint num;
		Enumerator<, > val4;
		UnityEngine.Object obj13;
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator6;
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator7;
		Enumerator<, > val6 = default;
		UnityEngine.Object obj17;
		UnityEngine.Object obj34;
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator11;
		NullReferenceException ex;
		nint num2 = default;
		Enumerator<, > val5 = default;
		UnityEngine.Object obj12 = default;
		UnityEngine.Object obj7;
		object obj18;
		Enumerator<, > val7;
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator8;
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator9;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6EB8]");
			object obj = 0;
			if (((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)this.foreseen).Count == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F20]");
			enumerator = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			flag2 = (byte)(int)obj2 != 0;
			list2._002Ector();
			bool flag3 = (object)this.foreseen == null;
			val = (Enumerator<, >)0;
			enumerator2 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
			val2 = (Enumerator<, >)0;
			gillaSawHits = this;
			list = list2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6ED8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F08]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6ED0]");
				object obj6 = 0;
				Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator3 = ((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)this.foreseen).GetEnumerator();
				obj7 = obj8;
				Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator5 = default;
				Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator enumerator4 = enumerator5;
				enumerator = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(&val3);
				bool flag6 = default;
				IntPtr intPtr = default;
				while (true)
				{
					obj9 = (UnityEngine.Object)obj3;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					bool flag4 = !all;
					object obj10 = !flag4;
					bool flag5 = flag6;
					obj11 = obj12;
					num = num2;
					val4 = val5;
					obj13 = obj7;
					enumerator6 = enumerator4;
					enumerator7 = enumerator;
					if (obj10 == null)
					{
						object obj14 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v55+E4]");
						enumerator7 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v55+E4]");
						bool flag7 = (nint)0 == 0;
						object obj15 = !flag7;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = obj8 == null;
						bool flag9 = !flag8;
						object obj16 = !flag9;
						flag5 = flag6;
						obj11 = obj12;
						num = unchecked((nint)null);
						val4 = val6;
						obj13 = obj7;
						enumerator6 = enumerator4;
						obj9 = null;
						if (obj16 == null)
						{
							bool flag10 = (int)val6 == 0;
							num = unchecked((nint)null);
							val4 = val6;
							val = (Enumerator<, >)obj8;
							enumerator2 = enumerator5;
							obj17 = null;
							obj18 = 0;
							val7 = val6;
							val2 = (Enumerator<, >)enumerator4;
							enumerator8 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(&val3);
							flag2 = false;
							gillaSawHits = this;
							list = list2;
							if (flag10)
							{
								goto IL_08bc;
							}
							object obj19 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ stack_-D0 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>+Enumerator<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEn…");
							obj11 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v59+E4]");
							enumerator7 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v59+E4]");
							bool flag11 = (nint)0 == 0;
							object obj20 = !flag11;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag12 = obj11 == null;
							bool flag13 = !flag12;
							object obj21 = !flag13;
							flag5 = flag6;
							num = unchecked((nint)null);
							val4 = val6;
							obj13 = obj7;
							enumerator6 = enumerator4;
							obj9 = null;
							if (obj21 == null)
							{
								float time = Time.time;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ stack_-D0 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>+Enumerator<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEn…");
								obj13 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ stack_-D0 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>+Enumerator<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEn…");
								enumerator6 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(time - 0);
								flag5 = enumerator6 <= (object)1.0;
								num = unchecked((nint)null);
								val4 = val6;
								obj9 = null;
								flag6 = flag5;
								obj12 = obj11;
								num2 = unchecked((nint)null);
								val5 = val6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ stack_-D0 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>+Enumerator<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEn…");
								obj7 = (UnityEngine.Object)0;
								enumerator4 = enumerator6;
								enumerator = enumerator7;
								if (flag5)
								{
									continue;
								}
							}
						}
					}
					if (list2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+10]");
						enumerator7 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
						object obj22 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+1C]");
						object obj23 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+18]");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+18]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v17 (System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>, System.__Canon>+Enumerator<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppB…");
							bool flag14 = num3 < 0;
							object obj24 = !flag14;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+10]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+18]");
								object obj25 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+18]");
								obj22 = (nint)0 + (nint)1;
								object obj26 = obj25 + 32;
								obj26 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								flag6 = flag5;
								obj12 = obj11;
								num2 = num;
								val5 = val4;
								obj7 = obj13;
								enumerator4 = enumerator6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v43 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+10]");
								enumerator = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v6+20]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v32+A8]");
								enumerator = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v12 (System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>, System.__Canon>+Enumerator<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppB…");
								System.__Canon _Canon = (System.__Canon)0;
								list2.AddWithResize(((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))obj8);
								flag6 = flag5;
								obj12 = obj11;
								num2 = intPtr;
								val5 = val4;
								obj7 = obj13;
								enumerator4 = enumerator6;
							}
							continue;
						}
					}
					goto IL_0838;
				}
				object obj28 = 6;
				val = (Enumerator<, >)obj8;
				enumerator9 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
				obj18 = 0;
				val7 = val6;
				val2 = (Enumerator<, >)enumerator4;
				enumerator8 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(&val3);
				gillaSawHits = this;
				object obj29 = 0;
				list = list2;
				Enumerator<, > val8 = default;
				Foreseen foreseen = default;
				object obj35 = default;
				while (true)
				{
					flag2 = (byte)(int)obj6 != 0;
					((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator*)enumerator8)->Dispose();
					bool flag15 = obj29 == null;
					object obj30 = !flag15;
					obj8 = (UnityEngine.Object)enumerator9;
					if (obj30 != null)
					{
						break;
					}
					bool flag16 = enumerator9 == (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(object)0;
					object obj31 = !flag16;
					obj8 = (UnityEngine.Object)enumerator9;
					ex = (NullReferenceException)enumerator8;
					enumerator = enumerator9;
					if (obj31 == null)
					{
						if ((nint)obj28 != 6)
						{
							bool flag17 = obj28 == null;
							object obj32 = !flag17;
							if (obj32 != null)
							{
								return;
							}
						}
						bool flag18 = list == null;
						obj8 = (UnityEngine.Object)enumerator9;
						enumerator = enumerator9;
						if (!flag18)
						{
							Enumerator<, > enumerator10 = list.GetEnumerator();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6EE0]");
							object obj33 = 0;
							list = (List<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(&val8);
							while (true)
							{
								obj9 = (UnityEngine.Object)obj33;
								if (!val8.MoveNext())
								{
									break;
								}
								bool flag19 = (object)gillaSawHits.foreseen == null;
								obj11 = obj12;
								num = num2;
								val4 = val5;
								obj34 = (UnityEngine.Object)val;
								enumerator11 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
								obj18 = 0;
								obj13 = obj7;
								enumerator6 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)val2;
								enumerator8 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(&val8);
								enumerator7 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(&val8);
								if (!flag19)
								{
									System.__Canon _Canon2 = ((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)gillaSawHits.foreseen).get_Item(((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0);
									gillaSawHits.Drop(((UnityEngine.Object, GoreSection))0, foreseen);
									System.__Canon _Canon = _Canon2;
									num2 = (nint)foreseen;
									list = null;
									continue;
								}
								goto IL_087e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6EC8]");
							enumerator = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
							flag2 = (byte)(int)enumerator != 0;
							val8.Dispose();
							enumerator9 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
							obj18 = 0;
							enumerator8 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(&val8);
							gillaSawHits = null;
							OutOfMemoryException ex2 = new OutOfMemoryException();
							switch (flag2)
							{
							case true:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								enumerator9 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)1;
								enumerator = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)1;
								obj29 = obj18;
								break;
							case true:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj29 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj18 = obj35;
								break;
							default:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC98");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							obj28 = 0;
							continue;
						}
						goto IL_08ea;
					}
					goto IL_08f8;
				}
				goto IL_0907;
			}
		}
		goto IL_08ea;
		IL_08ea:
		ex = new NullReferenceException();
		goto IL_08f8;
		IL_08bc:
		NullReferenceException ex3 = new NullReferenceException();
		num2 = num;
		val5 = val4;
		obj8 = obj17;
		enumerator = enumerator7;
		goto IL_08ea;
		IL_087e:
		NullReferenceException ex4 = new NullReferenceException();
		obj12 = obj11;
		val = (Enumerator<, >)obj34;
		obj17 = (UnityEngine.Object)enumerator11;
		obj7 = obj13;
		val2 = (Enumerator<, >)enumerator6;
		flag2 = (byte)(int)obj9 != 0;
		goto IL_08bc;
		IL_0838:
		NullReferenceException ex5 = new NullReferenceException();
		obj34 = obj8;
		enumerator11 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)0;
		obj18 = 0;
		val7 = val6;
		enumerator8 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)(&val3);
		gillaSawHits = this;
		list = list2;
		goto IL_087e;
		IL_0907:
		enumerator9 = (Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>.Enumerator)obj8;
		throw new OutOfMemoryException();
		IL_08f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0907;
	}

	public bool Waiting(PieceKey key)
	{
		//IL_002c: Expected I4, but got Obj
		if (waiting != null)
		{
			return waiting.Contains(key);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe void Pieces(Vector3 back, Vector3 tip, Vector3 normal, float half, float dt)
	{
		//IL_2866: Expected Obj, but got I
		//IL_2d45: Expected F4, but got I
		//IL_2d52: Expected VT, but got Obj
		//IL_2d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_2896: Expected VT, but got Obj
		//IL_28a6: Expected Obj, but got I
		//IL_28be: Expected F4, but got I
		//IL_28e0: Expected Obj, but got I4
		//IL_0067: Expected VT, but got I4
		//IL_0067: Expected VT, but got I4
		//IL_0067: Expected VT, but got I4
		//IL_0067: Expected VT, but got Obj
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected VT, but got F4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected VT, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected VT, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected VT, but got I4
		//IL_013a: Expected VT, but got I4
		//IL_0143: Expected VT, but got I4
		//IL_014c: Expected VT, but got I4
		//IL_015c: Expected F4, but got VT
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected F4, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected F8, but got I
		//IL_01a7: Expected F4, but got I
		//IL_01ab: Expected native int or pointer, but got F4
		//IL_01b4: Expected VT, but got F4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected VT, but got I4
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected VT, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected VT, but got I4
		//IL_025f: Expected VT, but got I4
		//IL_0268: Expected VT, but got I4
		//IL_0278: Expected F4, but got VT
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected F4, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected F4, but got I
		//IL_02d3: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2712: Expected VT, but got F4
		//IL_28f6: Expected VT, but got Obj
		//IL_2c63: Expected VT, but got Obj
		//IL_2c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c80: Expected VT, but got I4
		//IL_2c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cae: Expected VT, but got I4
		//IL_2cb7: Expected F4, but got I4
		//IL_2cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce9: Expected VT, but got I4
		//IL_2cf2: Expected VT, but got I4
		//IL_2cfb: Expected VT, but got I4
		//IL_2d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d0b: Expected F4, but got Unknown
		//IL_2d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Invalid comparison between F4 and I4
		//IL_2591: Expected VT, but got I4
		//IL_259f: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bf: Expected VT, but got I4
		//IL_25c8: Expected F4, but got I4
		//IL_25c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_25dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f2: Expected VT, but got I4
		//IL_25fb: Expected VT, but got I4
		//IL_2604: Expected VT, but got I4
		//IL_260c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2614: Expected F4, but got Unknown
		//IL_261c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2620: Unknown result type (might be due to invalid IL or missing references)
		//IL_2642: Expected Obj, but got VT
		//IL_03b9: Expected Obj, but got I
		//IL_03c1: Expected I4, but got Obj
		//IL_03d8: Expected VT, but got I
		//IL_2664: Unknown result type (might be due to invalid IL or missing references)
		//IL_2691: Expected F4, but got VT
		//IL_26b5: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj = 0;
		float num = default;
		double num3 = default;
		Enumerator<, > val2 = default;
		Vector3 vector3 = default;
		if (~(hadBar ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			num = 0f;
			Vector3? vector = (Vector3)obj;
			bool flag = (byte)(~(hadBar ? 1u : 0u)) != 0;
			double num2 = num3;
			Enumerator<, > val = val2;
			Vector3 vector2 = vector3;
			if (!flag)
			{
				vector2 = lastTip;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSawHits)+108]");
				val = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSawHits)+10C]");
				num2 = 0.0;
			}
		}
		object obj2 = default;
		float num4 = (float)obj2 * num;
		Vector3? vector4 = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v4+E4]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSlice.Touching((Vector3)touching, (Vector3)1, half, null, all: false, (Vector3?)(object)0, (Vector3?)(object)0);
		lastBack = (Vector3)half;
		hadBar = true;
		lastTip = vector3;
		bool flag3 = touchingNow == null;
		Enumerator<> val3 = (Enumerator<>)0;
		InputDevice inputDevice = (InputDevice)0;
		byte b = 0;
		Enumerator<, > val4 = (Enumerator<, >)0;
		byte b2 = 0;
		Enumerator<, > val5 = (Enumerator<, >)0;
		PieceKey pieceKey = (PieceKey)0;
		float num7 = default;
		float num6 = num7;
		Enumerator<, > val6 = (Enumerator<, >)0;
		bool flag4 = false;
		Enumerator<, > val7 = (Enumerator<, >)0;
		float num8 = num4;
		Vector3 vector5 = (Vector3)0;
		bool flag5 = false;
		List<(GillaPieceId, Vector3)> list = null;
		Vector3 vector6 = (Vector3)1;
		Vector3? vector7 = (Vector3?)(object)0;
		Vector3? vector8 = (Vector3?)(object)0;
		float num9 = num4;
		float num10 = (float)vector3;
		Enumerator<, > val8 = default;
		float num11 = (float)val8;
		float num12 = dt;
		Enumerator<, > val9 = val2;
		GillaSawHits gillaSawHits = this;
		Enumerator<, > val10 = val8;
		double num13 = num3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6FE8]");
			num5 = 0f;
			vector6 = (Vector3)((float*)(nint)num5)->m_value;
			touchingNow.Clear();
			bool flag6 = (object)touching == null;
			val3 = (Enumerator<>)0;
			inputDevice = (InputDevice)0;
			b = 0;
			val4 = (Enumerator<, >)0;
			b2 = 0;
			val5 = (Enumerator<, >)0;
			pieceKey = (PieceKey)0;
			num6 = num7;
			val6 = (Enumerator<, >)0;
			flag4 = false;
			val7 = (Enumerator<, >)0;
			num8 = num4;
			vector5 = (Vector3)0;
			flag5 = false;
			list = null;
			vector7 = (Vector3?)(object)0;
			vector8 = (Vector3?)(object)0;
			num9 = num4;
			num10 = (float)vector3;
			num11 = (float)val8;
			num12 = dt;
			val9 = val2;
			gillaSawHits = this;
			val10 = val8;
			num13 = num3;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7028]");
				float num14 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6FA8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6FE0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F98]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7048]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6FD8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6FF8]");
				UnityEngine.Object obj11 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6FF0]");
				object obj13 = 0;
				Enumerator<, > enumerator = ((List<(System.__Canon, Vector3)>)(object)touching).GetEnumerator();
				flag5 = false;
				list = null;
				float num15 = default;
				num5 = num15;
				Vector3 vector9;
				Enumerator<, > val11 = default;
				float num16 = default;
				Enumerator<, > val12;
				while (true)
				{
					vector9 = (Vector3)obj6;
					if (val6.MoveNext())
					{
						if (num7 != 0f)
						{
							if (touchingNow == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ stack_-188 (System.Single)+28]");
							list = (List<(GillaPieceId, Vector3)>)0;
							flag5 = (byte)(int)obj7 != 0;
							HashSet<PieceKey> hashSet = touchingNow;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ stack_-188 (System.Single)+20]");
							bool flag7 = hashSet.Add((PieceKey)0);
							num5 = num7;
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						break;
					}
					vector6 = (Vector3)obj8;
					val6.Dispose();
					val3 = (Enumerator<>)0;
					inputDevice = (InputDevice)0;
					b = 0;
					val4 = (Enumerator<, >)0;
					b2 = 0;
					val5 = (Enumerator<, >)0;
					pieceKey = (PieceKey)0;
					num6 = 0f;
					val6 = val11;
					flag4 = false;
					val12 = (Enumerator<, >)(ref val6);
					val7 = (Enumerator<, >)(ref val6);
					num8 = num16;
					vector5 = (Vector3)0;
					vector7 = (Vector3?)(object)0;
					vector8 = (Vector3?)(object)0;
					num9 = num4;
					num11 = (float)val8;
					num12 = num7;
					val9 = val11;
					gillaSawHits = this;
					val10 = val8;
					num13 = num3;
					throw new OutOfMemoryException();
				}
				NullReferenceException ex2 = new NullReferenceException();
				inputDevice = (InputDevice)0;
				b = 0;
				val4 = (Enumerator<, >)0;
				b2 = 0;
				val5 = (Enumerator<, >)0;
				pieceKey = (PieceKey)0;
				num6 = 0f;
				val6 = val11;
				flag4 = false;
				val12 = (Enumerator<, >)(ref val6);
				val7 = (Enumerator<, >)(ref val6);
				vector5 = (Vector3)0;
				vector7 = (Vector3?)(object)0;
				vector8 = (Vector3?)(object)0;
				num9 = num4;
				num11 = (float)val8;
				num12 = num7;
				val9 = val11;
				num5 = num7;
				NullReferenceException ex3 = new NullReferenceException();
				UnityEngine.Object obj14 = (UnityEngine.Object)vector9;
				NullReferenceException ex4 = new NullReferenceException();
				NullReferenceException ex5 = new NullReferenceException();
				val3 = (Enumerator<>)0;
				gillaSawHits = this;
				NullReferenceException ex6 = new NullReferenceException();
				NullReferenceException ex7 = new NullReferenceException();
				num10 = (float)vector3;
				NullReferenceException ex8 = new NullReferenceException();
				NullReferenceException ex9 = new NullReferenceException();
				vector6 = (Vector3)obj14;
				NullReferenceException ex10 = new NullReferenceException();
			}
		}
		NullReferenceException ex11 = new NullReferenceException();
		NullReferenceException ex12 = new NullReferenceException();
		NullReferenceException ex13 = new NullReferenceException();
		NullReferenceException ex14 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		vector3 = (Vector3)num10;
		throw new NullReferenceException();
	}

	private unsafe Cut Find(NetworkApe ape, GillaDummy dummy, GillaCorpse body, GoreSection section)
	{
		//IL_0249: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Ref, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		bool flag = cuts == null;
		object obj = 109891584;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70A0]");
			obj = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)cuts).GetEnumerator();
			Enumerator<, > val = default;
			bool flag2;
			object obj3;
			Enumerator<, > val2;
			NetworkApe networkApe;
			if (!val.MoveNext())
			{
				flag2 = false;
				obj3 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj4 = 0;
				object obj7 = default;
				while (true)
				{
					Cut result = null;
					networkApe = (NetworkApe)obj;
					((Enumerator<, >*)val2)->Dispose();
					bool flag3 = obj4 == null;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						bool flag4 = !flag2;
						object obj6 = !flag4;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj6 == null)
						{
							return result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)networkApe == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						flag2 = true;
						obj4 = obj3;
						continue;
					}
					if ((nint)networkApe != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj4 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj3 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DDC4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Cut result2 = default;
				return result2;
			}
			Cut cut = null;
			NullReferenceException ex2 = new NullReferenceException();
			flag2 = false;
			obj3 = 0;
			val2 = (Enumerator<, >)(ref val);
			networkApe = (NetworkApe)obj2;
		}
		throw new NullReferenceException();
	}

	private unsafe bool PlaneOf(GillaWounds w, GoreSection section, Vector3 onBar, Vector3 onShape, float radius, Vector3 normal, Vector3 limb, out Plane p)
	{
		//IL_13c5: Expected native int or pointer, but got VT
		//IL_13bc: Expected I4, but got Obj
		//IL_0017: Expected VT, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01d7: Expected VT, but got I4
		//IL_01df: Expected VT, but got Obj
		//IL_1454: Invalid comparison between F8 and I
		//IL_00a7: Expected Obj, but got I4
		//IL_00da: Expected VT, but got I4
		//IL_00e2: Expected VT, but got Obj
		//IL_152b: Invalid comparison between F4 and I
		//IL_0227: Expected VT, but got I4
		//IL_023b: Expected F8, but got I
		//IL_024d: Expected VT, but got I4
		//IL_028e: Expected Obj, but got I4
		//IL_0297: Expected VT, but got I4
		//IL_029f: Expected VT, but got Obj
		//IL_02c0: Expected Obj, but got I4
		//IL_0149: Expected VT, but got I4
		//IL_0151: Expected VT, but got Obj
		//IL_178d: Expected Obj, but got I4
		//IL_1729: Expected Obj, but got I
		//IL_1739: Expected F4, but got I
		//IL_1749: Expected F4, but got I
		//IL_1759: Expected F4, but got I
		//IL_1d04: Expected Obj, but got I4
		//IL_07b2: Invalid comparison between F4 and I
		//IL_1d57: Expected Obj, but got I
		//IL_1d64: Expected Obj, but got I
		//IL_1d74: Expected Obj, but got I
		//IL_1da8: Expected Obj, but got I
		//IL_1dbf: Expected F4, but got Obj
		//IL_1dc7: Invalid comparison between F4 and Obj
		//IL_02f3: Expected F8, but got I
		//IL_0308: Invalid comparison between F8 and I
		//IL_0813: Expected Obj, but got I
		//IL_081b: Expected F4, but got Obj
		//IL_082b: Expected F4, but got I
		//IL_083b: Expected F4, but got I
		//IL_0380: Expected Obj, but got I
		//IL_0388: Expected F8, but got Obj
		//IL_0398: Expected F8, but got I
		//IL_03a8: Expected F8, but got I
		//IL_1557: Expected Obj, but got I
		//IL_155f: Expected VT, but got Obj
		//IL_1581: Expected Obj, but got I4
		//IL_1ded: Expected Obj, but got I
		//IL_1dfa: Expected Obj, but got I
		//IL_1e0a: Expected Obj, but got I
		//IL_1e59: Expected Obj, but got I
		//IL_1e70: Invalid comparison between F4 and Obj
		//IL_03cd: Expected F4, but got I
		//IL_17fb: Invalid comparison between F4 and I
		//IL_180c: Expected I, but got F8
		//IL_1825: Expected Obj, but got I4
		//IL_182e: Expected Obj, but got I4
		//IL_159c: Expected Obj, but got I
		//IL_15a9: Expected Obj, but got I
		//IL_15fe: Expected Obj, but got I4
		//IL_03ff: Invalid comparison between F8 and I
		//IL_040e: Expected F8, but got I4
		//IL_1916: Expected Obj, but got I4
		//IL_0902: Expected Obj, but got I4
		//IL_0b4b: Invalid comparison between F4 and I
		//IL_0b5d: Expected F4, but got I4
		//IL_0b66: Expected F4, but got I4
		//IL_0b6f: Expected F4, but got I4
		//IL_099b: Expected Obj, but got I
		//IL_09ab: Expected F4, but got I
		//IL_09bb: Expected F4, but got I
		//IL_09cb: Expected F4, but got I
		//IL_1d3c: Expected Obj, but got I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_1936: Expected VT, but got I4
		//IL_1966: Expected Obj, but got I
		//IL_197b: Expected Obj, but got I
		//IL_19ba: Expected VT, but got I4
		//IL_19e0: Expected Obj, but got I4
		//IL_18b1: Expected Obj, but got I
		//IL_18ba: Expected Obj, but got I4
		//IL_093f: Expected Obj, but got I
		//IL_094f: Expected F4, but got I
		//IL_095f: Expected F4, but got I
		//IL_096f: Expected F4, but got I
		//IL_0978: Expected Obj, but got I4
		//IL_0540: Invalid comparison between F8 and I
		//IL_054f: Expected F8, but got I4
		//IL_163b: Expected Obj, but got I4
		//IL_184c: Expected Obj, but got I
		//IL_1864: Expected Obj, but got I
		//IL_186c: Invalid comparison between F4 and Obj
		//IL_187a: Expected I, but got F8
		//IL_1893: Expected Obj, but got I4
		//IL_0505: Expected F4, but got I
		//IL_1ee0: Expected Obj, but got I4
		//IL_16d4: Expected Obj, but got I4
		//IL_0561: Unsupported input type for neg.
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0c2e: Invalid comparison between F4 and I
		//IL_0aa5: Expected Obj, but got I4
		//IL_1692: Expected Obj, but got I4
		//IL_0c9f: Expected Obj, but got I
		//IL_0caf: Expected F4, but got I
		//IL_0cb7: Expected F4, but got Obj
		//IL_0cc7: Expected F4, but got I
		//IL_1a77: Expected VT, but got I4
		//IL_1a90: Expected Obj, but got I
		//IL_1ac6: Expected Obj, but got I
		//IL_1afb: Expected F4, but got Obj
		//IL_1b30: Invalid comparison between F4 and Obj
		//IL_1b69: Expected Obj, but got I4
		//IL_1ba1: Expected Obj, but got I4
		//IL_0e29: Invalid comparison between F4 and I
		//IL_0e92: Expected Obj, but got I
		//IL_0ea2: Expected F4, but got I
		//IL_0eb2: Expected F4, but got I
		//IL_0eba: Expected F4, but got Obj
		//IL_1bd1: Expected Obj, but got I4
		//IL_1f0b: Expected Obj, but got I
		//IL_1f28: Expected Obj, but got I
		//IL_1f45: Expected Obj, but got I
		//IL_1f62: Expected Obj, but got I
		//IL_1fa1: Expected VT, but got I4
		//IL_1c09: Expected Obj, but got I4
		//IL_1011: Invalid comparison between F4 and I4
		//IL_1022: Expected Obj, but got I4
		//IL_102b: Invalid comparison between F4 and I4
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_1047: Expected Obj, but got Unknown
		//IL_106e: Expected Obj, but got I
		//IL_1098: Expected Obj, but got I4
		//IL_10c3: Expected Obj, but got I4
		//IL_11f5: Expected Obj, but got I4
		//IL_126d: Invalid comparison between F4 and I4
		//IL_1280: Expected Obj, but got F4
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Expected Obj, but got Unknown
		//IL_12ac: Expected Obj, but got I
		//IL_12cd: Expected Obj, but got I4
		//IL_10f1: Expected Obj, but got I4
		//IL_10fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected Obj, but got Unknown
		//IL_1130: Expected Obj, but got I4
		//IL_125f: Expected VT, but got I4
		//IL_1ccc: Expected Obj, but got I4
		//IL_1c32: Expected VT, but got I4
		//IL_1fba: Expected Obj, but got I
		//IL_1fca: Expected F4, but got I
		//IL_1391: Expected VT, but got I4
		//IL_11bd: Expected VT, but got I4
		//IL_1373: Expected VT, but got I4
		((Vector3*)(nint)onBar)->x = 0f;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		string text;
		object obj;
		object obj3;
		nint num3;
		float num6;
		nint num8;
		double num9;
		double num10 = default;
		object obj10 = default;
		double num11;
		double num13 = default;
		double num16;
		double num17;
		if ((object)w != null)
		{
			text = w.SawBone(section, (Vector3)0);
			if (!w.HasBone(text))
			{
				goto IL_11ca;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj = 0;
			object obj2 = section & (GoreSection)0xFF;
			bool flag = obj2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			obj3 = 0;
			double num;
			double num2 = default;
			IntPtr intPtr = default;
			object obj5;
			object obj6 = default;
			double num4;
			double num5 = default;
			float num7 = default;
			IntPtr intPtr2 = default;
			object obj7;
			object obj8 = default;
			Vector3 axis;
			object obj9;
			double num12;
			double num14;
			float num15;
			if (!flag)
			{
				object obj4 = section & (GoreSection)0xFF;
				bool flag2 = (nint)obj4 != 1;
				num = num2;
				num3 = intPtr;
				obj5 = obj6;
				Vector3 vector = (Vector3)0;
				axis = (Vector3)text;
				num4 = num5;
				num6 = num7;
				num8 = intPtr2;
				num9 = num10;
				obj7 = obj8;
				if (!flag2)
				{
					obj9 = obj10;
					num11 = num5;
					num12 = num13;
					num14 = num10;
					num3 = intPtr;
					vector = (Vector3)0;
					axis = (Vector3)text;
					num15 = (float)num5;
					num6 = num7;
					num8 = intPtr2;
					num9 = num10;
					num16 = num13;
					num17 = num5;
					goto IL_14a3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
				object obj11 = 0;
				bool flag3 = w.HasBone((string)obj11);
				bool flag4 = !flag3;
				num = num2;
				num3 = intPtr;
				obj5 = obj6;
				Vector3 vector = (Vector3)0;
				axis = (Vector3)obj11;
				num4 = num5;
				num6 = num7;
				num8 = intPtr2;
				num9 = num10;
				obj7 = obj8;
				if (!flag4)
				{
					Vector3 vector2 = w.World((string)obj11, (Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					num4 = 0.0;
					Vector3 vector3 = w.World((string)obj11, (Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					double num18 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					double num19 = num18 - 0.0;
					num = num19;
					num3 = intPtr;
					obj5 = 0;
					vector = (Vector3)0;
					axis = (Vector3)obj11;
					num6 = num7;
					num8 = intPtr2;
					num9 = num10;
					obj7 = 0;
				}
			}
			object obj12 = obj7 * obj7;
			object obj13 = obj5 * obj5;
			object obj14 = obj13 + obj12;
			double num20 = num * num;
			double num21 = num20 + (double)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
			bool flag5 = !(num21 > 0.0);
			obj9 = obj10;
			num11 = num5;
			num12 = num13;
			num14 = num10;
			num15 = (float)num4;
			num16 = num13;
			num17 = num5;
			if (!flag5)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v117+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				double num22 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				double num23;
				double num24;
				double num25;
				if (1.0 > 0.0)
				{
					num23 = (double)obj7 / 1.0;
					num24 = (double)obj5 / 1.0;
					num25 = num / 1.0;
					num22 = num;
				}
				else
				{
					object obj17 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v128+A0]");
					object obj18 = 0;
					num23 = (double)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v129+4]");
					num24 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v129+8]");
					num25 = 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
				object obj19 = 0;
				Vector3 normal2 = (Vector3)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X0_v120 (UnityEngine.Vector3)+E4]");
				bool flag7 = (nint)0 == 0;
				object obj20 = !flag7;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Vector3 vector4 = Across(normal2, axis, num8);
				object obj21 = num8 * num8;
				object obj22 = num3 * num3;
				object obj23 = obj;
				object obj24 = obj21 + obj22;
				float num26 = num6 * num6;
				double num27 = (double)num26 + (double)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X0_v123+E4]");
				bool flag8 = (nint)0 == 0;
				object obj25 = !flag8;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				double num28 = num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
				bool flag9 = num28 < 0.0;
				double num29 = 0.0;
				if (!flag9)
				{
					object obj26 = obj7 * num8;
					object obj27 = obj5 * num3;
					object obj28 = obj26 + obj27;
					float num30 = (float)num * num6;
					float num31 = num30 + (float)obj28;
					double num32 = (double)num31 / num25;
					bool flag10 = num32 < -1.0;
					num27 = -1.0;
					if (!flag10)
					{
						bool flag11 = !(num32 > 1.0);
						num27 = num32;
						if (!flag11)
						{
							num27 = 1.0;
						}
					}
					object obj29 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X0_v140+E4]");
					bool flag12 = (nint)0 == 0;
					object obj30 = !flag12;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
					num26 = 0f;
					double num33 = num27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
					num29 = num33 * 0.0;
				}
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1374 @ X0_v129+E4]");
				bool flag13 = (nint)0 == 0;
				object obj32 = !flag13;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num34 = num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
				bool flag14 = num34 < 0.0;
				double num35 = 0.0;
				if (!flag14)
				{
					object obj33 = 0 - obj5;
					object obj34 = obj7 * num8;
					object obj35 = num3 * obj33;
					object obj36 = obj35 - obj34;
					float num36 = (float)num * num6;
					float num37 = (float)obj36 - num36;
					double num38 = (double)num37 / num25;
					bool flag15 = num38 < -1.0;
					double num39 = -1.0;
					if (!flag15)
					{
						bool flag16 = !(num38 > 1.0);
						num39 = num38;
						if (!flag16)
						{
							num39 = 1.0;
						}
					}
					object obj37 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X0_v132+E4]");
					bool flag17 = (nint)0 == 0;
					object obj38 = !flag17;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
					double num40 = num39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
					num35 = num40 * 0.0;
				}
				if (num29 < num35)
				{
					num35 = num29;
				}
				double num41 = num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				double num42 = num41 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D100");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				obj9 = 1114636288;
				num11 = num25;
				num12 = num24;
				num14 = num23;
				num15 = num6;
				num9 = num10;
				num16 = num13;
				num17 = num5;
			}
			goto IL_14a3;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_11ca:
		bool result = false;
		goto IL_1c17;
		IL_14a3:
		float num43 = radius - (float)num9;
		object obj39 = default;
		float num44 = (float)obj39 - (float)num16;
		object obj40 = default;
		float num45 = (float)obj40 - (float)num17;
		float num46 = num43 * num43;
		float num47 = num44 * num44;
		float num48 = num46 + num47;
		float num49 = num45 * num45;
		float num50 = num49 + num48;
		float num51 = num50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if (num51 < 0f)
		{
			object obj41 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v92+A0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v93+18]");
			num43 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v93+1C]");
			num44 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v93+20]");
			num45 = 0f;
			object obj43 = num8 * num8;
			object obj44 = num3 * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj45 = 0;
			object obj46 = obj45;
			object obj47 = obj43 + obj44;
			float num52 = num6 * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v97+A0]");
			object obj48 = 0;
			num50 = num52 + (float)obj47;
			num49 = (float)obj48;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num50) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48))
			{
				float num53 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v93+18]");
				float num54 = num53 * 0f;
				float num55 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v93+1C]");
				float num56 = num55 * 0f;
				double num57 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v93+20]");
				double num14 = num57 * 0.0;
				float num58 = num54 + num56;
				float num59 = (float)num14 + num58;
				float num60 = num59 / num50;
				num49 = (float)num8 * num60;
				float num15 = (float)num3 * num60;
				num50 = num6 * num60;
				num43 -= num49;
				num44 -= num15;
				num45 -= num50;
			}
		}
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v14+E4]");
		bool flag18 = (nint)0 == 0;
		object obj50 = !flag18;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num61 = num43 * num43;
		float num62 = num44 * num44;
		float num63 = num61 + num62;
		float num64 = num45 * num45;
		float num65 = num63 + num64;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num66;
		float num67;
		float num68;
		if (num65 > 0f)
		{
			num66 = num43 / num65;
			num67 = num44 / num65;
			num68 = num45 / num65;
		}
		else
		{
			object obj51 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v86+A0]");
			object obj52 = 0;
			num66 = (float)obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v87+4]");
			num67 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v87+8]");
			num68 = 0f;
		}
		object obj53 = num8 * num8;
		object obj54 = num3 * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj55 = 0;
		float num69 = 0f - num44;
		float num70 = 0f - num45;
		object obj56 = obj55;
		object obj57 = obj53 + obj54;
		float num71 = num6 * num6;
		float num72 = 0f - num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v18+A0]");
		object obj58 = 0;
		float num73 = num71 + (float)obj57;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num73) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58))
		{
			float num74 = (float)num3 * num69;
			float num75 = (float)num8 * num43;
			float num76 = num6 * num45;
			float num77 = num74 - num75;
			float num78 = num77 - num76;
			float num79 = num78 / num73;
			float num80 = (float)num8 * num79;
			float num15 = (float)num3 * num79;
			float num81 = num6 * num79;
			num72 -= num80;
			num69 -= num15;
			num70 -= num81;
		}
		float num82 = num72 * num72;
		float num83 = num69 * num69;
		float num84 = num82 + num83;
		float num85 = num70 * num70;
		float num86 = num84 + num85;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		bool flag19 = !(num86 < 0f);
		nint num87 = (nint)num11;
		IntPtr intPtr3 = num8;
		float num88 = num6;
		object obj59 = 109891584;
		object obj60 = 109891584;
		if (!flag19)
		{
			object obj61 = 109891584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A4]");
			if ((nint)0 != 0)
			{
				object obj62 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ X8_v83+A0]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v84+24]");
				num72 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v84+28]");
				num69 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v84+2C]");
				num70 = 0f;
				obj60 = 109891584;
			}
			else
			{
				object obj64 = obj3;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X8_v81+A0]");
				object obj65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1210 @ X8_v82+24]");
				num72 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1210 @ X8_v82+28]");
				num69 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1210 @ X8_v82+2C]");
				num70 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				obj = 0;
				obj60 = 109891584;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj66 = 0;
			object obj67 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X8_v79+A0]");
			object obj68 = 0;
			bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num73) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68);
			num87 = (nint)num11;
			intPtr3 = num8;
			num88 = num6;
			obj59 = 109891584;
			if (!flag20)
			{
				float num89 = (float)num3 * num69;
				float num90 = (float)num8 * num72;
				float num91 = num6 * num70;
				float num92 = num90 + num89;
				float num93 = num91 + num92;
				float num94 = num93 / num73;
				num85 = (float)num8 * num94;
				float num15 = (float)num3 * num94;
				float num95 = num6 * num94;
				num72 -= num85;
				num69 -= num15;
				num70 -= num95;
				num87 = num8;
				intPtr3 = num3;
				num88 = num6;
				obj59 = 109891584;
			}
		}
		object obj69 = obj;
		float num96 = num66 * (float)obj10;
		float num97 = num67 * (float)obj10;
		float num98 = num68 * (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X0_v19+E4]");
		bool flag21 = (nint)0 == 0;
		object obj70 = !flag21;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num99 = num72 * num72;
		float num100 = num69 * num69;
		float num101 = num99 + num100;
		float num102 = num70 * num70;
		float num103 = num101 + num102;
		float num104 = (float)num10 + num96;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num105 = (float)num13 + num97;
		float num106 = (float)num17 + num98;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		bool flag22 = !(num103 > 0f);
		float num107 = 0f;
		float num108 = 0f;
		float num109 = 0f;
		if (!flag22)
		{
			num108 = num72 / num103;
			num109 = num69 / num103;
			num107 = num70 / num103;
		}
		Vector3 vector5 = w.OnBody(text, (Vector3)0);
		float num110 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num111 = num110 * 0f;
		nint num112 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		object obj71 = num112 * 0;
		nint num113 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		object obj72 = num113 * 0;
		float num114 = num111 + num106;
		float num115 = (float)obj71 + num104;
		float num116 = (float)obj72 + num105;
		Vector3 vector6 = w.OnBody(text, (Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X26_v5+99E]");
		bool flag23 = (nint)0 == 0;
		object obj73 = !flag23;
		if (obj73 == null)
		{
			_ = 1;
		}
		float num117 = num115 - num104;
		object obj74 = obj;
		float num118 = num116 - num105;
		float num119 = num114 - num106;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1433 @ X0_v27+E4]");
		bool flag24 = (nint)0 == 0;
		object obj75 = !flag24;
		if (obj75 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num120 = num117 * num117;
		float num121 = num118 * num118;
		float num122 = num120 + num121;
		float num123 = num119 * num119;
		float num124 = num123 + num122;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num127;
		float num128;
		float num129;
		if (num124 > 0f)
		{
			float num125 = num117 / num124;
			float num126 = num118 / num124;
			num127 = num119 / num124;
			num128 = num125;
			num129 = num126;
		}
		else
		{
			object obj76 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v70+A0]");
			object obj77 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1467 @ X8_v71+8]");
			num127 = 0f;
			num128 = (float)obj77;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1467 @ X8_v71+4]");
			num129 = 0f;
		}
		float num130 = num109;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num131 = num130 * 0f;
		float num132 = num108;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num133 = num132 * 0f;
		float num134 = num107;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num135 = num134 * 0f;
		float num136 = num105 + num131;
		float num137 = num104 + num133;
		float num138 = num106 + num135;
		Vector3 vector7 = w.OnBody(text, (Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj78 = 0;
		float num139 = num128 * num128;
		float num140 = num129 * num129;
		object obj79 = obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1509 @ X8_v35+A0]");
		object obj80 = 0;
		float num141 = num139 + num140;
		float num142 = num127 * num127;
		float num143 = num142 + num141;
		float num144 = (float)obj80;
		float num145 = num137 - num104;
		float num146 = num136 - num105;
		float num147 = num138 - num106;
		float num150;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num143) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj80))
		{
			float num148 = num105;
			float num149 = num106;
			num150 = num127;
		}
		else
		{
			float num151 = num128 * num145;
			float num152 = num129 * num146;
			float num153 = num127 * num147;
			float num154 = num151 + num152;
			float num155 = num153 + num154;
			float num156 = num155 / num143;
			float num149 = num128 * num156;
			float num148 = num129 * num156;
			num144 = num127 * num156;
			num145 -= num149;
			num146 -= num148;
			num147 -= num144;
			num150 = num127;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X26_v5+99E]");
		bool flag25 = (nint)0 == 0;
		object obj81 = !flag25;
		if (obj81 == null)
		{
			_ = 1;
		}
		object obj82 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ X0_v34+E4]");
		bool flag26 = (nint)0 == 0;
		object obj83 = !flag26;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num157 = num145 * num145;
		float num158 = num146 * num146;
		float num159 = num157 + num158;
		float num160 = num147 * num147;
		float num161 = num159 + num160;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num163;
		float num164;
		float num165;
		if (num161 > 0f)
		{
			float num162 = num145 / num161;
			num163 = num146 / num161;
			num164 = num147 / num161;
			num165 = num162;
		}
		else
		{
			object obj84 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ X8_v65+A0]");
			object obj85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X8_v66+4]");
			num163 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X8_v66+8]");
			num164 = 0f;
			num165 = (float)obj85;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X27_v6+9A0]");
		bool flag27 = (nint)0 == 0;
		object obj86 = !flag27;
		if (obj86 == null)
		{
			_ = 1;
		}
		object obj87 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ X8_v45+A0]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X8_v46+20]");
		nint num166 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj89 = num166 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X8_v46+1C]");
		nint num167 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj90 = num167 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X8_v46+18]");
		nint num168 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj91 = num168 * 0;
		float num169 = num105 + (float)obj90;
		float num170 = num104 + (float)obj91;
		float num171 = num106 + (float)obj89;
		Vector3 vector8 = w.OnBody(text, (Vector3)0);
		object obj92 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X0_v40+E4]");
		bool flag28 = (nint)0 == 0;
		object obj93 = !flag28;
		if (obj93 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((double)num143 < 0.5)
		{
			goto IL_11ca;
		}
		float num172 = num163 * num163;
		float num173 = num165 * num165;
		float num174 = num173 + num172;
		float num175 = num164 * num164;
		float num176 = num174 + num175;
		bool flag29 = (double)num176 < 0.5;
		result = false;
		if (!flag29)
		{
			float num177 = num170 - num104;
			float num178 = num171 - num106;
			float num179 = num169 - num105;
			float num180 = num177 * num177;
			float num181 = num178 * num178;
			float num182 = num179 * num179;
			float num183 = num180 + num182;
			float num184 = num181 + num183;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num185 = num184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num186 = num185 / 0f;
			bool flag30 = num186 < 0f;
			object obj94 = !flag30;
			bool flag31 = num186 == 0f;
			object obj95 = ~obj94;
			object obj96 = obj95 | flag31;
			result = false;
			if (obj96 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
				object obj97 = 0;
				object obj98 = obj97;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ X0_v43+E4]");
				bool flag32 = (nint)0 == 0;
				object obj99 = !flag32;
				if (obj99 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj100 = section & (GoreSection)0xFE;
				if ((nint)obj100 == 2)
				{
					object obj101 = section & (GoreSection)0xFF;
					object obj102 = obj101 - 2;
					bool flag33 = obj102 == null;
					float num187 = num186;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
					float num188 = num187 * 0f;
					object obj103 = !flag33;
					object obj104 = ~obj103;
					ApePart part = ((obj104 != null) ? ((ApePart)1) : ((ApePart)2));
					if (!w.OnStump(part, (Vector3)0, num104))
					{
						goto IL_11ca;
					}
					float num189 = num104 * num128;
					float num190 = num105 * num129;
					float num191 = num189 + num190;
					float num192 = num106 * num150;
					float num193 = num192 + num191;
					Vector3 vector9 = (Vector3)0;
					num181 = num106;
				}
				else
				{
					float num194 = num104 * num128;
					object obj105 = section & (GoreSection)0xFF;
					bool flag34 = obj105 == null;
					float num195 = num105 * num129;
					float num196 = num194 + num195;
					float num192 = num106 * num150;
					float num193 = num192 + num196;
					if (!flag34)
					{
						float num188 = num106;
						Vector3 vector9 = (Vector3)0;
					}
					else
					{
						bool flag35 = num150 < 0f;
						object obj106 = num150 ^ num150;
						object obj107 = num150 & obj106;
						bool flag36 = (nint)obj107 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
						object obj108 = 0;
						object obj109 = obj108;
						bool flag37 = flag35 == flag36;
						object obj110 = !flag37;
						object obj111 = ~obj110;
						double num197 = ((obj111 != null) ? 1.0 : (-1.0));
						float num198 = num128 * (float)num197;
						float num199 = num129 * (float)num197;
						float num200 = num150 * (float)num197;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1740 @ X0_v55+E4]");
						bool flag38 = (nint)0 == 0;
						object obj112 = !flag38;
						if (obj112 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj109 = obj108;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1740 @ X0_v55+A0]");
						object obj113 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X8_v58+8]");
						num181 = 0f;
						float num201 = num198 * (float)obj113;
						float num202 = num199;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X8_v58+4]");
						float num203 = num202 * 0f;
						float num204 = num201 + num203;
						float num205 = num200;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X8_v58+8]");
						float num206 = num205 * 0f;
						float num207 = num206 + num204;
						float num208 = num207;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD54]");
						float num209 = num208 + 0f;
						num192 = num193 * (float)num197;
						if (num192 < num209)
						{
							double num210 = num197 * (double)num209;
							double num211 = num210 - (double)num193;
							num181 = num128 * (float)num211;
							float num188 = num129 * (float)num211;
							num192 = num150 * (float)num211;
							Vector3 vector9 = (Vector3)0;
							num193 = (float)num210;
						}
						else
						{
							float num188 = num106;
							Vector3 vector9 = (Vector3)0;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Vector3 normal3 = default;
				GillaRip.Along along = GillaRip.Along.Across(normal3, num128);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = true;
			}
		}
		goto IL_1c17;
		IL_1c17:
		return result;
	}

	private unsafe Cut Begin(NetworkApe ape, GillaDummy dummy, GillaCorpse body, GillaWounds w, GoreSection section, Vector3 onBar, Vector3 onShape, float radius, Vector3 normal, Vector3 limb)
	{
		//IL_15c5: Expected Ref, but got VT
		//IL_15c5: Expected VT, but got I4
		//IL_15c5: Expected VT, but got Obj
		//IL_15c5: Expected VT, but got Ref
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_0162: Expected Obj, but got Ref
		//IL_017b: Expected VT, but got I4
		//IL_019c: Expected VT, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_165b: Expected VT, but got I4
		//IL_166b: Expected Obj, but got Ref
		//IL_16f3: Expected F4, but got I
		//IL_1703: Expected Obj, but got I
		//IL_1722: Expected Obj, but got I
		//IL_1732: Expected F4, but got I
		//IL_176b: Expected Obj, but got Ref
		//IL_01c9: Expected Obj, but got Ref
		//IL_0cc1: Expected Obj, but got I4
		//IL_1182: Expected VT, but got Ref
		//IL_1196: Expected Obj, but got I
		//IL_0cf3: Expected Obj, but got I
		//IL_0d0f: Expected VT, but got I4
		//IL_0d1f: Expected Obj, but got Ref
		//IL_020f: Expected Obj, but got I4
		//IL_11de: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_0d4c: Expected Obj, but got Ref
		//IL_03c5: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_1227: Expected Obj, but got Unknown
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_1247: Expected Obj, but got Unknown
		//IL_041d: Expected Obj, but got Ref
		//IL_0425: Expected Obj, but got Ref
		//IL_029a: Expected Obj, but got Ref
		//IL_1267: Unknown result type (might be due to invalid IL or missing references)
		//IL_126c: Expected Obj, but got Unknown
		//IL_1287: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Expected Obj, but got Unknown
		//IL_0d73: Expected Obj, but got Ref
		//IL_0d8d: Expected Obj, but got I
		//IL_0db7: Expected Obj, but got I4
		//IL_12ba: Expected I4, but got I8
		//IL_0de4: Expected F4, but got I
		//IL_0df4: Expected Obj, but got I
		//IL_0e01: Expected VT, but got Ref
		//IL_0e01: Expected VT, but got Ref
		//IL_0e1d: Expected VT, but got I4
		//IL_0e2d: Expected Obj, but got Ref
		//IL_044a: Expected Obj, but got Ref
		//IL_02c1: Expected Obj, but got Ref
		//IL_02db: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I4
		//IL_17ce: Expected VT, but got I
		//IL_04f8: Expected Obj, but got Ref
		//IL_0332: Expected F4, but got I
		//IL_0342: Expected Obj, but got I
		//IL_034f: Expected VT, but got Ref
		//IL_034f: Expected VT, but got Ref
		//IL_036d: Expected Obj, but got I4
		//IL_0386: Expected Obj, but got I
		//IL_0396: Expected F4, but got I
		//IL_03a7: Expected VT, but got Ref
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Expected Obj, but got Unknown
		//IL_1335: Expected Obj, but got I4
		//IL_1344: Expected Obj, but got I4
		//IL_134d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Expected Obj, but got Unknown
		//IL_136a: Unknown result type (might be due to invalid IL or missing references)
		//IL_136f: Expected Obj, but got Unknown
		//IL_138f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1394: Expected Obj, but got Unknown
		//IL_0e4b: Expected Obj, but got I
		//IL_0e75: Expected Obj, but got I4
		//IL_0460: Expected I, but got Obj
		//IL_0470: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got Ref
		//IL_04b9: Expected Obj, but got I
		//IL_13ef: Expected Obj, but got I4
		//IL_0ea0: Expected Obj, but got I4
		//IL_0eae: Expected Obj, but got I4
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebc: Expected Obj, but got Unknown
		//IL_0ed6: Expected Obj, but got I4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_055d: Expected Obj, but got Ref
		//IL_147a: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got Ref
		//IL_0595: Expected Obj, but got I
		//IL_05bf: Expected Obj, but got I4
		//IL_1003: Expected Obj, but got Ref
		//IL_100b: Expected Obj, but got I4
		//IL_05ec: Expected Obj, but got I
		//IL_05f9: Expected VT, but got Ref
		//IL_05f9: Expected VT, but got Ref
		//IL_060d: Expected Obj, but got I
		//IL_14d1: Expected Obj, but got I4
		//IL_0f2e: Expected Obj, but got Ref
		//IL_0f3f: Expected Obj, but got I4
		//IL_0633: Expected Obj, but got Ref
		//IL_1057: Expected Obj, but got I4
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected Obj, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Expected Obj, but got Unknown
		//IL_10f6: Expected Obj, but got I4
		//IL_06c5: Expected Obj, but got I8
		//IL_06ec: Expected Obj, but got Ref
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected Obj, but got Unknown
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected Obj, but got Unknown
		//IL_0649: Expected I, but got Obj
		//IL_0659: Expected Obj, but got I
		//IL_068a: Expected Obj, but got Ref
		//IL_06a3: Expected Obj, but got I
		//IL_1114: Expected Obj, but got I
		//IL_112c: Expected VT, but got I4
		//IL_1153: Expected VT, but got I4
		//IL_116c: Expected Obj, but got I4
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_0752: Expected Obj, but got Ref
		//IL_0f97: Expected VT, but got I4
		//IL_0faf: Expected Obj, but got I
		//IL_0fbf: Expected F4, but got I
		//IL_0781: Expected Obj, but got I
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected Obj, but got Unknown
		//IL_07b3: Expected Obj, but got I
		//IL_07d1: Unsupported input type for neg.
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected Obj, but got Unknown
		//IL_0827: Expected Obj, but got I4
		//IL_1689: Expected Obj, but got I
		//IL_16cb: Expected Obj, but got Ref
		//IL_08ec: Expected Obj, but got I4
		//IL_08fc: Expected Obj, but got I4
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected Obj, but got Unknown
		//IL_0931: Expected Obj, but got Ref
		//IL_0860: Expected I, but got Obj
		//IL_0870: Expected Obj, but got I
		//IL_0899: Expected Obj, but got Ref
		//IL_08b2: Expected Obj, but got I
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected Obj, but got Unknown
		//IL_09a6: Expected Obj, but got Ref
		//IL_0a40: Expected Obj, but got I8
		//IL_0a5f: Expected Obj, but got Ref
		//IL_09bc: Expected I, but got Obj
		//IL_09cc: Expected Obj, but got I
		//IL_09f5: Expected Obj, but got Ref
		//IL_0a0e: Expected Obj, but got I
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected Obj, but got Unknown
		//IL_0ad4: Expected Obj, but got Ref
		//IL_0b6a: Expected Obj, but got I
		//IL_0b86: Expected Obj, but got I4
		//IL_0b96: Expected Obj, but got I4
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected Obj, but got Unknown
		//IL_0bcb: Expected Obj, but got Ref
		//IL_0aea: Expected I, but got Obj
		//IL_0afa: Expected Obj, but got I
		//IL_0b23: Expected Obj, but got Ref
		//IL_0b3c: Expected Obj, but got I
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected Obj, but got Unknown
		//IL_0c2a: Expected Obj, but got I
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Expected Obj, but got Unknown
		//IL_0c6d: Expected Obj, but got I
		//IL_0c82: Expected VT, but got Obj
		System.__Canon _Canon = default;
		float num = default;
		bool flag = PlaneOf(w, section, (Vector3)(&_Canon), (Vector3)w, num, (Vector3)section, onBar, out *(Plane*)onShape);
		bool flag2 = !flag;
		Cut result = null;
		if (flag2)
		{
			goto IL_1561;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F48]");
		object obj4 = 0;
		bool flag4 = (UnityEngine.Object)ape != (UnityEngine.Object)null;
		bool flag5 = !flag4;
		object obj5 = !flag5;
		NetworkApe networkApe = ape;
		if (obj5 == null)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v144+E4]");
			bool flag6 = (nint)0 == 0;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = (UnityEngine.Object)dummy != (UnityEngine.Object)null;
			bool flag8 = !flag7;
			object obj8 = !flag8;
			object obj9 = ~obj8;
			networkApe = (NetworkApe)((obj9 != null) ? ((MonoBehaviour)body) : ((MonoBehaviour)dummy));
		}
		object obj10 = obj4;
		(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) tuple = ((System.__Canon)(object)networkApe, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)section);
		bool flag9 = (object)foreseen == null;
		object obj12 = default;
		object obj11 = obj12;
		GillaWounds gillaWounds = w;
		Unity.IL2CPP.Metadata.__Il2CppByteEnum _Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)section;
		System.__Canon _Canon2 = (System.__Canon)(object)networkApe;
		object obj15 = default;
		object obj42 = default;
		object obj48 = default;
		object obj40 = default;
		object obj57 = default;
		IndexOutOfRangeException ex = default;
		object obj56 = default;
		object obj19 = default;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7058]");
			object obj13 = 0;
			object obj14 = (object)(&tuple);
			gillaWounds = (GillaWounds)obj13;
			bool flag10 = ((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)foreseen).TryGetValue(((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0, out *(System.__Canon*)null);
			bool flag11 = !flag10;
			ref System.__Canon reference = ref *(System.__Canon*)null;
			(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) tuple2 = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0;
			if (flag11)
			{
				goto IL_1643;
			}
			bool flag12 = obj15 == null;
			obj11 = obj12;
			obj10 = (object)(&obj15);
			_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
			_Canon2 = null;
			if (!flag12)
			{
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X0_v78+E4]");
				bool flag13 = (nint)0 == 0;
				object obj17 = !flag13;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+10]");
				bool flag14 = (UnityEngine.Object)0 == w;
				bool flag15 = !flag14;
				object obj18 = obj19;
				float num2 = num;
				_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
				if (!flag15)
				{
					bool flag16 = obj15 == null;
					obj11 = obj12;
					obj10 = (object)(&obj15);
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
					_Canon2 = (System.__Canon)(object)w;
					if (flag16)
					{
						goto IL_1566;
					}
					object obj20 = (object)(&tuple);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
					object obj21 = 0;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1152 @ X0_v138+E4]");
					bool flag17 = (nint)0 == 0;
					object obj23 = !flag17;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X26_v19+28]");
					num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X26_v19+38]");
					obj18 = 0;
					object obj24 = default;
					object obj25 = default;
					bool flag18 = Near((GillaRip.Along)(&obj24), (GillaRip.Along)(&obj25));
					bool flag19 = !flag18;
					object obj26 = !flag19;
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X26_v19+38]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X26_v19+28]");
					num = 0f;
					reference = ref *(System.__Canon*)80;
					tuple2 = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))(&obj25);
					if (obj26 != null)
					{
						goto IL_1643;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F38]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object[] array = default;
				bool flag20 = array == null;
				obj11 = obj12;
				obj19 = obj18;
				num = num2;
				obj10 = (object)(&obj15);
				object obj29 = default;
				_Canon2 = (System.__Canon)(&obj29);
				if (!flag20)
				{
					System.__Canon _Canon3 = default;
					bool flag21 = _Canon3 == null;
					System.__Canon _Canon4 = (System.__Canon)(&obj29);
					if (!flag21)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v84 (Il2CppClass<System.Object[]>)+40]");
						_Canon4 = (System.__Canon)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag22 = ex == null;
						obj11 = obj12;
						obj19 = obj18;
						num = num2;
						obj10 = (object)(&obj15);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v84 (Il2CppClass<System.Object[]>)+40]");
						_Canon2 = (System.__Canon)0;
						if (flag22)
						{
							goto IL_1582;
						}
					}
					bool flag23 = array.Length == 0;
					obj11 = obj12;
					obj19 = obj18;
					num = num2;
					obj10 = (object)(&obj15);
					_Canon2 = _Canon4;
					if (!flag23)
					{
						object obj30 = array + 32;
						obj30 = _Canon3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag24 = obj15 == null;
						obj11 = obj12;
						obj19 = obj18;
						num = num2;
						obj10 = (object)(&obj15);
						_Canon2 = _Canon3;
						if (flag24)
						{
							goto IL_1566;
						}
						object obj31 = (object)(&tuple);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
						object obj32 = 0;
						object obj33 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v93+E4]");
						bool flag25 = (nint)0 == 0;
						object obj34 = !flag25;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X27_v10+38]");
						obj19 = 0;
						object obj35 = default;
						object obj36 = default;
						float num4 = Turned((GillaRip.Along)(&obj35), (GillaRip.Along)(&obj36));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						System.__Canon _Canon5 = default;
						bool flag26 = _Canon5 == null;
						float num5 = default;
						System.__Canon _Canon6 = (System.__Canon)(&num5);
						if (!flag26)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X8_v83 (Il2CppClass<System.Object[]>)+40]");
							_Canon6 = (System.__Canon)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag27 = ex == null;
							obj11 = obj12;
							num = num4;
							obj10 = (object)(&obj15);
							_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X8_v83 (Il2CppClass<System.Object[]>)+40]");
							_Canon2 = (System.__Canon)0;
							if (flag27)
							{
								goto IL_1582;
							}
						}
						object obj38 = array.Length & 0xFFFFFFFEL;
						bool flag28 = obj38 == null;
						obj11 = obj12;
						num = num4;
						obj10 = (object)(&obj15);
						_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
						_Canon2 = _Canon6;
						if (!flag28)
						{
							object obj39 = array + 40;
							obj39 = _Canon5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag29 = obj15 == null;
							obj11 = obj12;
							num = num4;
							obj10 = (object)(&obj15);
							_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
							_Canon2 = _Canon5;
							if (flag29)
							{
								goto IL_1566;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+84]");
							obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+18]");
							object obj41 = 0 * obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+1C]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+84]");
							object obj43 = num7 * 0;
							object obj44 = obj41 + obj43;
							object obj46 = default;
							object obj45 = obj46 + obj44;
							object obj47 = 0 - obj48;
							bool flag30 = (nint)obj45 < 0;
							object obj49 = obj45 ^ obj45;
							object obj50 = obj45 & obj49;
							bool flag31 = (nint)obj50 < 0;
							bool flag32 = flag30 == flag31;
							object obj51 = !flag32;
							object obj52 = ~obj51;
							object obj53 = ((obj52 != null) ? obj47 : obj48);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+3C]");
							obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+3C]");
							num = 0f + (float)obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj54 = default;
							bool flag33 = obj54 == null;
							object obj55 = default;
							System.__Canon _Canon7 = (System.__Canon)(&obj55);
							if (!flag33)
							{
								nint num8 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
								_Canon7 = (System.__Canon)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag34 = ex == null;
								obj11 = obj12;
								obj10 = (object)(&obj15);
								_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
								_Canon2 = (System.__Canon)0;
								obj56 = obj48;
								obj57 = obj42;
								if (flag34)
								{
									goto IL_1582;
								}
							}
							bool flag35 = array.Length < 2;
							object obj58 = !flag35;
							object obj59 = array.Length - 2;
							bool flag36 = obj59 == null;
							object obj60 = ~obj58;
							object obj61 = obj60 | flag36;
							obj11 = obj12;
							obj10 = (object)(&obj15);
							_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
							_Canon2 = _Canon7;
							obj56 = obj48;
							obj57 = obj42;
							if (obj61 == null)
							{
								object obj62 = array + 48;
								obj62 = obj54;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj63 = default;
								bool flag37 = obj63 == null;
								object obj64 = default;
								System.__Canon _Canon8 = (System.__Canon)(&obj64);
								if (!flag37)
								{
									nint num9 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
									_Canon8 = (System.__Canon)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag38 = ex == null;
									obj11 = obj12;
									obj10 = (object)(&obj15);
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
									_Canon2 = (System.__Canon)0;
									obj56 = obj48;
									obj57 = obj42;
									if (flag38)
									{
										goto IL_1582;
									}
								}
								object obj65 = array.Length & 0xFFFFFFFCL;
								bool flag39 = obj65 == null;
								obj11 = obj12;
								obj10 = (object)(&obj15);
								_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
								_Canon2 = _Canon8;
								obj56 = obj48;
								obj57 = obj42;
								if (!flag39)
								{
									object obj66 = array + 56;
									obj66 = obj63;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj67 = default;
									bool flag40 = obj67 == null;
									object obj68 = default;
									System.__Canon _Canon9 = (System.__Canon)(&obj68);
									if (!flag40)
									{
										nint num10 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
										_Canon9 = (System.__Canon)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag41 = ex == null;
										obj11 = obj12;
										obj10 = (object)(&obj15);
										_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
										_Canon2 = (System.__Canon)0;
										obj56 = obj48;
										obj57 = obj42;
										if (flag41)
										{
											goto IL_1582;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F48]");
									obj4 = 0;
									bool flag42 = array.Length < 4;
									object obj69 = !flag42;
									object obj70 = array.Length - 4;
									bool flag43 = obj70 == null;
									object obj71 = ~obj69;
									object obj72 = obj71 | flag43;
									obj11 = obj12;
									obj10 = (object)(&obj15);
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
									_Canon2 = _Canon9;
									obj56 = obj48;
									obj57 = obj42;
									if (obj72 == null)
									{
										object obj73 = array + 64;
										obj73 = obj67;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70D0]");
										object format = 0;
										string text = string.Format((string)format, array);
										object obj74 = this + 240;
										obj74 = text;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										obj = 0;
										num5 = num4;
										reference = ref *(System.__Canon*)null;
										tuple2 = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))text;
										obj56 = obj48;
										obj57 = obj42;
										goto IL_1643;
									}
								}
							}
						}
					}
					goto IL_1574;
				}
			}
		}
		goto IL_1566;
		IL_1582:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (Cut)(object)new ArgumentNullException();
		IL_1171:
		object obj75 = default;
		int num11 = w.KerfOn(section, (GillaRip.Along)(&obj75));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70C0]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cut cut = default;
		cut._002Ector();
		bool flag44 = cut == null;
		object obj77;
		obj11 = obj77;
		object obj78;
		obj19 = obj78;
		float num12;
		num = num12;
		obj10 = 0;
		_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(byte)(&obj75);
		_Canon2 = null;
		object obj80;
		object obj79 = obj80;
		object obj81;
		obj56 = obj81;
		object obj82;
		obj57 = obj82;
		object obj83;
		obj40 = obj83;
		if (!flag44)
		{
			object obj84 = cut + 16;
			obj84 = ape;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj85 = cut + 24;
			obj85 = dummy;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj86 = cut + 32;
			obj86 = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj87 = cut + 40;
			obj87 = w;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num13 = (int)(num11 & 0x80000000L);
			bool flag45 = num13 == 0;
			int slot = num11;
			if (!flag45)
			{
				int num14 = w.FreeKerf(section);
				slot = num14;
			}
			cut.slot = slot;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+28]");
			cut.along = (GillaRip.Along)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Vector3 entry = default;
			cut.entry = entry;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj88 = cut + 120;
			obj88 = _Canon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj89 = section & (GoreSection)0xFF;
			object obj90 = 17285120 + 1272;
			object obj91 = obj89 - 1;
			bool flag46 = obj91 == null;
			object obj92 = 0 * obj12;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X9_v11+v772 @ Z_v9 (System.Boolean)*4]");
			obj40 = obj92 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			obj19 = obj40 * obj82;
			num = Time.time;
			List<System.__Canon> list = (List<System.__Canon>)(object)cuts;
			bool flag47 = cuts == null;
			obj11 = obj77;
			obj10 = 0;
			_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
			_Canon2 = _Canon;
			obj79 = obj80;
			obj56 = obj81;
			obj57 = obj82;
			if (!flag47)
			{
				System.__Canon[] items = list._items;
				int version = list._version + 1;
				list._version = version;
				bool flag48 = list._items == null;
				obj11 = obj77;
				obj10 = 0;
				_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
				_Canon2 = _Canon;
				obj79 = obj80;
				obj56 = obj81;
				obj57 = obj82;
				if (!flag48)
				{
					bool flag49 = list._size < items.Length;
					object obj93 = !flag49;
					if (obj93 == null)
					{
						object obj94 = list._items + list._size;
						int size = list._size + 1;
						list._size = size;
						object obj95 = obj94 + 32;
						obj95 = cut;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						result = cut;
					}
					else
					{
						((List<System.__Canon>)(object)cuts).AddWithResize((System.__Canon)(object)cut);
						result = cut;
					}
					goto IL_1561;
				}
			}
		}
		goto IL_1566;
		IL_1561:
		return result;
		IL_1574:
		ex = new IndexOutOfRangeException();
		goto IL_1582;
		IL_1566:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1574;
		IL_1643:
		bool flag50 = obj15 == null;
		tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0;
		obj77 = obj12;
		obj10 = (object)(&obj15);
		if (!flag50)
		{
			object obj96 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X0_v55+E4]");
			bool flag51 = (nint)0 == 0;
			object obj97 = !flag51;
			if (obj97 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+10]");
			bool flag52 = (UnityEngine.Object)0 == w;
			bool flag53 = !flag52;
			tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0;
			obj77 = obj12;
			obj10 = (object)(&obj15);
			if (!flag53)
			{
				bool flag54 = obj15 == null;
				obj11 = obj12;
				obj10 = (object)(&obj15);
				_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
				_Canon2 = (System.__Canon)(object)w;
				if (!flag54)
				{
					object obj98 = (object)(&tuple);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
					object obj99 = 0;
					object obj100 = obj99;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X0_v61+E4]");
					bool flag55 = (nint)0 == 0;
					object obj101 = !flag55;
					if (obj101 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X26_v14+28]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X26_v14+38]");
					obj19 = 0;
					object obj102 = default;
					object obj103 = default;
					bool flag56 = Near((GillaRip.Along)(&obj102), (GillaRip.Along)(&obj103));
					bool flag57 = !flag56;
					tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0;
					obj77 = obj12;
					obj10 = (object)(&obj15);
					if (flag57)
					{
						goto IL_16d9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
					object obj104 = 0;
					object obj105 = obj104;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1190 @ X0_v65+E4]");
					bool flag58 = (nint)0 == 0;
					object obj106 = !flag58;
					if (obj106 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj107 = section & (GoreSection)0xFF;
					object obj108 = section & (GoreSection)0xFE;
					object obj109 = obj107 - 2;
					bool flag59 = obj109 == null;
					object obj110 = !flag59;
					object obj111 = ~obj110;
					ApePart apePart = ((obj111 != null) ? ((ApePart)1) : ((ApePart)2));
					bool flag60 = (nint)obj108 != 2;
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
					if (!flag60)
					{
						bool flag61 = (object)w == null;
						obj11 = obj12;
						obj10 = (object)(&obj15);
						_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
						_Canon2 = (System.__Canon)apePart;
						if (flag61)
						{
							goto IL_1566;
						}
						bool flag62 = w.Stump(apePart);
						bool flag63 = !flag62;
						_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
						if (!flag63)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0;
							obj77 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+38]");
							obj78 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+28]");
							num12 = 0f;
							obj80 = obj79;
							obj81 = obj56;
							obj82 = obj57;
							obj83 = obj40;
							goto IL_1171;
						}
					}
					bool flag64 = obj15 == null;
					obj11 = obj12;
					obj10 = (object)(&obj15);
					_Canon2 = (System.__Canon)apePart;
					if (!flag64)
					{
						obj10 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ stack_-F8_v6+28]");
						_ = 0;
						object obj113 = default;
						object obj112 = obj113 * obj42;
						obj11 = 0 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						object obj114 = obj11 + obj112;
						object obj115 = obj114 - obj48;
						object obj116 = default;
						obj40 = obj42 * obj116;
						obj57 = 0 * obj115;
						num = (float)obj113 - (float)obj40;
						obj19 = 0 - obj57;
						tuple = ((System.__Canon)(object)networkApe, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)section);
						bool flag65 = (object)foreseen == null;
						_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)section;
						_Canon2 = (System.__Canon)(object)networkApe;
						obj79 = obj48;
						obj56 = 0;
						if (!flag65)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7098]");
							object obj117 = 0;
							obj10 = obj117;
							bool flag66 = ((Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon>)(object)foreseen).Remove(((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0);
							int num15 = UsedForeseen__BackingField + 1;
							UsedForeseen__BackingField = num15;
							tuple = ((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0;
							obj77 = obj11;
							obj79 = obj48;
							obj56 = 0;
							goto IL_16d9;
						}
					}
				}
				goto IL_1566;
			}
		}
		goto IL_16d9;
		IL_16d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+28]");
		num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+38]");
		obj19 = 0;
		bool flag67 = (object)w == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+38]");
		obj78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X28_v6+28]");
		num12 = 0f;
		obj80 = obj79;
		obj81 = obj56;
		obj82 = obj57;
		obj83 = obj40;
		obj11 = obj77;
		_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)80;
		_Canon2 = (System.__Canon)(&_Canon);
		if (!flag67)
		{
			goto IL_1171;
		}
		goto IL_1566;
	}

	private unsafe void Saw(Cut c, float dt, Vector3 at, Vector3 onBar, Vector3 barWay, float half)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_0b95: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_029d: Expected Obj, but got Ref
		//IL_02ed: Expected Obj, but got I
		//IL_0309: Expected VT, but got I4
		//IL_0340: Expected VT, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0c75: Expected Obj, but got I4
		//IL_0756: Expected Obj, but got I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03ee: Expected VT, but got I4
		//IL_03fc: Expected VT, but got F8
		//IL_0446: Expected Obj, but got I
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0486: Expected VT, but got I4
		//IL_082b: Expected Obj, but got I
		//IL_083b: Expected VT, but got I4
		//IL_085e: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I4
		//IL_088b: Expected Obj, but got I4
		//IL_08a1: Expected VT, but got I4
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_07a4: Expected Obj, but got I4
		//IL_04a6: Expected VT, but got I4
		//IL_0b61: Expected VT, but got Obj
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_07f7: Expected Obj, but got I4
		//IL_08d9: Expected Obj, but got I4
		//IL_0d25: Expected Obj, but got I
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected Obj, but got Unknown
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected Obj, but got Unknown
		//IL_0d79: Expected Obj, but got I4
		//IL_091e: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I
		//IL_056d: Expected F8, but got Obj
		//IL_057d: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I
		//IL_0a1b: Expected Obj, but got I4
		//IL_0956: Expected Obj, but got I4
		//IL_0c92: Expected VT, but got F8
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_099e: Expected VT, but got I4
		//IL_05cd: Expected Obj, but got I
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_060d: Expected VT, but got I4
		//IL_062d: Expected VT, but got I4
		//IL_0b08: Expected Obj, but got I
		//IL_0b24: Expected VT, but got Obj
		//IL_0a79: Expected Obj, but got I
		//IL_0aa4: Expected Obj, but got I4
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected Obj, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected Obj, but got Unknown
		//IL_0def: Expected Obj, but got I4
		//IL_06d4: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got I
		//IL_06f4: Expected F8, but got Obj
		//IL_0704: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I
		//IL_0cb0: Expected VT, but got F8
		//IL_0cc3: Expected VT, but got I4
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected Obj, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		float time = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = c + 16;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X23_v3+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef = default;
		string text;
		int num = default;
		object obj8;
		string text3;
		string text4;
		if ((UnityEngine.Object)obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v119+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int playerId = playerRef.PlayerId;
			text = num.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F60]");
			obj8 = 0;
		}
		else
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v102+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)c.dummy != (UnityEngine.Object)null))
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v106+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (c.body != null)
				{
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F68]");
				object obj13 = 0;
				string text2 = num.ToString();
				text3 = text2;
				text4 = (string)obj13;
				goto IL_0ceb;
			}
			int bodyId = c.dummy.BodyId;
			text = num.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F58]");
			obj8 = 0;
		}
		text3 = text;
		text4 = (string)obj8;
		goto IL_0ceb;
		IL_0b3c:
		sprayIn = 0f;
		Vector3 at2;
		object obj14;
		float dt2;
		Spray(c, at2, (Vector3)obj14, barWay, dt2);
		return;
		IL_0ceb:
		string text5 = text4 + text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
		object obj15 = 0;
		object obj16 = this + 40;
		obj16 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) tuple = default;
		string text6 = ((Enum)(&tuple)).ToString();
		string text7 = (string)obj16 + (string)obj15 + text6;
		obj16 = text7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
		object obj17 = 0;
		string bone = c.wounds.BodyBone(c.section, (Vector3)0);
		bool flag5 = c.wounds.HasBone(bone);
		bool flag6 = !flag5;
		Vector3 vector = (Vector3)0;
		GillaSawHits gillaSawHits = (GillaSawHits)flag5;
		dt2 = half;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+70]");
			object obj19 = default;
			object obj18 = 0 * obj19;
			float num2 = c.depth * (float)c.way;
			object obj20 = obj18 * 63;
			double num3 = (double)num2 * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+64]");
			object obj21 = 0 + obj20;
			double num4 = (double)c.entry + num3;
			Vector3 vector2 = c.wounds.World(bone, (Vector3)0);
			BiteAt__BackingField = (Vector3)num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			double num5 = (double)c.along * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+40]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			object obj22 = num6 * 0;
			double num7 = (double)c.entry + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
			object obj23 = 0 + obj22;
			Vector3 vector3 = c.wounds.World(bone, (Vector3)0);
			Vector3 vector4 = c.wounds.World(bone, (Vector3)0);
			double num8 = num7 - (double)c.entry;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+64]");
			object obj26 = default;
			object obj25 = obj26 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
			object obj27 = obj23 - 0;
			object obj28 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v76+E4]");
			bool flag7 = (nint)0 == 0;
			object obj29 = !flag7;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			double num11;
			if (num9 > 0)
			{
				double num10 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
				num11 = num10 / 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
				object obj30 = obj25 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
				object obj31 = obj27 / 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj32 = 0;
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v60+A0]");
				object obj34 = 0;
				num11 = (double)obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v61+4]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v61+8]");
				object obj31 = 0;
			}
			BiteNormal__BackingField = (Vector3)num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			double num12 = (double)c.way * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+74]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			object obj35 = num13 * 0;
			double num14 = (double)c.entry + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
			object obj36 = 0 + obj35;
			Vector3 vector5 = c.wounds.World(bone, (Vector3)0);
			Vector3 vector6 = c.wounds.World(bone, (Vector3)0);
			gillaSawHits = (GillaSawHits)obj24;
			double num15 = num14 - (double)c.entry;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+64]");
			object obj37 = obj26 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
			object obj38 = obj36 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v23 (GillaSawHits)+E4]");
			bool flag8 = (nint)0 == 0;
			object obj39 = !flag8;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			double num18;
			if (num16 > 0)
			{
				double num17 = num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
				num18 = num17 / 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
				object obj40 = obj37 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
				obj17 = obj38 / 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj41 = 0;
				object obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v54+A0]");
				object obj43 = 0;
				num18 = (double)obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v55+4]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v55+8]");
				obj17 = 0;
			}
			BiteWay__BackingField = (Vector3)num18;
			vector = (Vector3)0;
			dt2 = half;
		}
		gillaSawHits.Send(c);
		int num19 = Bites__BackingField + 1;
		Bites__BackingField = num19;
		c.done = true;
		gillaSawHits.SendThrough(c);
		object obj44 = obj;
		int num20 = Throughs__BackingField + 1;
		Throughs__BackingField = num20;
		LastThroughSection__BackingField = c.section;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+58]");
		_ = 0;
		LastThrough__BackingField = c.along;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v24+E4]");
		bool flag9 = (nint)0 == 0;
		object obj45 = !flag9;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = (UnityEngine.Object)c.ape != (UnityEngine.Object)null;
		bool flag11 = !flag10;
		object obj46 = !flag11;
		object obj47 = obj2;
		if (obj46 == null)
		{
			object obj48 = obj;
			object obj49 = c + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v62+E4]");
			bool flag12 = (nint)0 == 0;
			object obj50 = !flag12;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = (UnityEngine.Object)obj49 != null;
			obj47 = c + 32;
			bool flag14 = !flag13;
			object obj51 = !flag14;
			object obj52 = ~obj51;
			if (obj52 == null)
			{
				obj47 = obj49;
			}
		}
		tuple = ((System.__Canon)obj47, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)c.section);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F40]");
		obj14 = 0;
		bool flag15 = ((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)outFirst).Add(((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))0);
		bool flag16 = (int)c.section < 1;
		object obj53 = !flag16;
		object obj54 = c.section - 1;
		bool flag17 = obj54 == null;
		object obj55 = !flag17;
		object obj56 = obj53 & obj55;
		at2 = (Vector3)0;
		if (obj56 == null)
		{
			object obj57 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v34+E4]");
			bool flag18 = (nint)0 == 0;
			object obj58 = !flag18;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = (UnityEngine.Object)obj2 != null;
			bool flag20 = !flag19;
			object obj59 = !flag20;
			if (obj59 == null)
			{
				object obj60 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v56+E4]");
				bool flag21 = (nint)0 == 0;
				object obj61 = !flag21;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag22 = (UnityEngine.Object)c.dummy != (UnityEngine.Object)null;
				bool flag23 = !flag22;
				at2 = (Vector3)0;
				if (flag23)
				{
					goto IL_0b3c;
				}
			}
			float time2 = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F30]");
			object obj62 = 0;
			float value = time2 + 0.75f;
			((Dictionary<System.__Canon, float>)(object)killed).set_Item((System.__Canon)obj47, value);
			object obj63 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v41+E4]");
			bool flag24 = (nint)0 == 0;
			object obj64 = !flag24;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int key;
			if ((UnityEngine.Object)obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj65 = 0;
				object obj66 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X0_v50+E4]");
				bool flag25 = (nint)0 == 0;
				object obj67 = !flag25;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				key = playerRef.PlayerId;
			}
			else
			{
				key = c.dummy.BodyId;
			}
			float time3 = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F28]");
			object obj68 = 0;
			float value2 = time3 + 0.75f;
			at2 = (Vector3)obj68;
			killedOwners.set_Item(key, value2);
		}
		goto IL_0b3c;
	}

	internal static Vector3 Across(Vector3 normal, Vector3 axis, float most)
	{
		//IL_0031: Unsupported input type for neg.
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0049: Unsupported input type for neg.
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0061: Unsupported input type for neg.
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_006f: Invalid comparison between F4 and I4
		//IL_04c7: Invalid comparison between F4 and I4
		//IL_04e7: Invalid comparison between F4 and I4
		//IL_06ac: Expected Obj, but got I
		//IL_06d2: Expected VT, but got Obj
		//IL_072a: Expected Obj, but got I4
		//IL_00fd: Expected F4, but got I
		//IL_010d: Invalid comparison between F4 and I
		//IL_011c: Expected F4, but got I4
		//IL_050b: Invalid comparison between F4 and Obj
		//IL_051c: Expected Obj, but got I4
		//IL_0534: Invalid comparison between F4 and I4
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0588: Expected Obj, but got I4
		//IL_05a6: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I
		//IL_0748: Invalid comparison between F4 and I
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0789: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I
		//IL_0401: Expected Obj, but got I
		//IL_0409: Expected F4, but got Obj
		//IL_0419: Expected F4, but got I
		//IL_0429: Expected F4, but got I
		//IL_079f: Expected VT, but got Obj
		//IL_07ee: Expected Obj, but got I4
		//IL_04a2: Invalid comparison between F4 and I
		object obj = default;
		float num = most * (float)obj;
		float num3 = default;
		object obj2 = default;
		float num2 = num3 * (float)obj2;
		float num5 = default;
		object obj3 = default;
		float num4 = num5 * (float)obj3;
		object obj4 = 0 - obj3;
		float num6 = num + num2;
		object obj5 = 0 - obj;
		float num7 = num4 + num6;
		object obj6 = 0 - obj2;
		object obj7 = ((!(num7 < 0f)) ? obj : obj5);
		object obj8 = ((!(num7 < 0f)) ? obj2 : obj6);
		object obj9 = ((!(num7 < 0f)) ? obj3 : obj4);
		float num8 = most * most;
		float num9 = num3 * num3;
		object obj10 = obj7 * obj7;
		object obj11 = obj8 * obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj12 = 0;
		float num10 = num8 + num9;
		float num11 = num5 * num5;
		Vector3 result = (Vector3)obj12;
		object obj13 = obj10 + obj11;
		object obj14 = obj9 * obj9;
		float num12 = num11 + num10;
		object obj15 = obj14 + obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v6 (UnityEngine.Vector3)+E4]");
		bool flag = (nint)0 == 0;
		object obj16 = !flag;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
		float num13 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
		bool flag2 = num10 < 0f;
		float num14 = 0f;
		if (!flag2)
		{
			float num15 = most * (float)obj7;
			float num16 = num3 * (float)obj8;
			float num17 = num15 + num16;
			num13 = num5 * (float)obj9;
			float num18 = num13 + num17;
			float num19 = num18 / num10;
			bool flag3 = (double)num19 < -1.0;
			double num20 = -1.0;
			if (!flag3)
			{
				bool flag4 = !((double)num19 > 1.0);
				num20 = num19;
				if (!flag4)
				{
					num20 = 1.0;
				}
			}
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v35+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
			double num21 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			double num22 = num21 * 0.0;
			num14 = (float)num22;
		}
		object obj19 = default;
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
		object obj20 = !flag6;
		float num23 = num14 - (float)obj19;
		bool flag7 = num23 == 0f;
		object obj21 = ~obj20;
		object obj22 = obj21 | flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v11+A0]");
			object obj25 = 0;
			bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25);
			float num24 = num5;
			float num25 = most;
			float num26 = num3;
			if (!flag8)
			{
				float num27 = most * (float)obj7;
				float num28 = num3 * (float)obj8;
				float num29 = num27 + num28;
				float num30 = num5 * (float)obj9;
				float num31 = num30 + num29;
				float num32 = num31 / (float)obj15;
				float num33 = (float)obj7 * num32;
				num13 = (float)obj8 * num32;
				float num34 = (float)obj9 * num32;
				num25 = most - num33;
				num26 = num3 - num13;
				num24 = num5 - num34;
				float num35 = num25 * num25;
				float num36 = num26 * num26;
				float num37 = num35 + num36;
				num14 = num24 * num24;
				num12 = num37 + num14;
				obj14 = obj9;
			}
			float num38 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
			if (!(num38 < 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				object obj26 = obj19 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D100");
				object obj27 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v11+E4]");
				bool flag9 = (nint)0 == 0;
				object obj28 = !flag9;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num39;
				float num40;
				float num41;
				if ((nint)obj26 > 0)
				{
					num39 = num25 / (float)obj26;
					num40 = num26 / (float)obj26;
					num41 = num24 / (float)obj26;
				}
				else
				{
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v31+A0]");
					object obj31 = 0;
					num39 = (float)obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v32+4]");
					num40 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v32+8]");
					num41 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				object obj32 = obj26 * obj7;
				float num42 = (float)obj26 * num39;
				float num43 = (float)obj26 * num40;
				float num44 = (float)obj26 * num41;
				object obj33 = obj26 * obj8;
				object obj34 = obj26 * obj9;
				result = (Vector3)obj12;
				float num45 = (float)obj32 + num42;
				float num46 = (float)obj33 + num43;
				float num47 = (float)obj34 + num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v6 (UnityEngine.Vector3)+E4]");
				bool flag10 = (nint)0 == 0;
				object obj35 = !flag10;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num48 = num45 * num45;
				float num49 = num46 * num46;
				float num50 = num48 + num49;
				float num51 = num47 * num47;
				float num52 = num50 + num51;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (!(num52 > 0f))
				{
				}
			}
		}
		return result;
	}

	private unsafe void Send(Cut c)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_019c: Expected VT, but got I4
		//IL_019c: Expected F4, but got VT
		//IL_019c: Expected VT, but got Ref
		//IL_0278: Expected Obj, but got I4
		//IL_0249: Expected VT, but got I4
		//IL_0249: Expected VT, but got Ref
		//IL_02d5: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I4
		//IL_0602: Expected Obj, but got I4
		//IL_0660: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I4
		//IL_05d2: Expected I4, but got VT
		//IL_05d2: Expected VT, but got I4
		//IL_05d2: Expected VT, but got I4
		//IL_05d2: Expected VT, but got Ref
		//IL_03d9: Expected Obj, but got I
		//IL_03f5: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I
		//IL_063a: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_04a0: Expected Obj, but got I4
		//IL_0529: Expected VT, but got I
		//IL_0529: Expected VT, but got I4
		//IL_0529: Expected VT, but got Ref
		//IL_0529: Expected F4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj2 = default;
		object obj = c.way * obj2;
		object obj4 = default;
		object obj3 = c.way * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+74]");
		float num = 0f * c.depth;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+74]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A890]");
		object obj5 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		object obj7 = c.entry + obj;
		object obj8 = obj6;
		object obj9 = c.entry + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
		float num3 = 0f + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+68]");
		object obj10 = 0 + obj5;
		object obj11 = obj9 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj11 * 63;
		Vector3 way = default;
		Vector3 half = default;
		RpcInfo rpcInfo = default;
		if ((UnityEngine.Object)c.ape != (UnityEngine.Object)null)
		{
			object obj14 = default;
			c.ape.RPC_SawBite((byte)c.section, (byte)c.slot, (Vector3)(&obj14), (float)c.along, (Vector3)0, way, half, rpcInfo);
			return;
		}
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)c.dummy != (UnityEngine.Object)null)
		{
			object obj17 = default;
			c.dummy.SawBite(c.section, c.slot, (GillaRip.Along)(&obj17), (Vector3)0, way, half);
			return;
		}
		object obj18 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(c.body != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj24 = !flag5;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj20;
		}
		object obj25 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v21+A0]");
		object obj26 = 0;
		UnityEngine.Object obj27 = (UnityEngine.Object)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj28 = !flag6;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = (UnityEngine.Object)obj26 != null;
		bool flag8 = !flag7;
		object obj29 = 0;
		UnityEngine.Object obj30 = null;
		if (!flag8)
		{
			object obj31 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v30+E4]");
			bool flag9 = (nint)0 == 0;
			object obj32 = !flag9;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X20_v10 (UnityEngine.Object)+40]");
			bool flag10 = (UnityEngine.Object)0 != null;
			bool flag11 = !flag10;
			obj29 = 0;
			obj30 = null;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X20_v10 (UnityEngine.Object)+40]");
				UnityEngine.Object obj33 = (UnityEngine.Object)0;
				object obj34 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v35+E4]");
				bool flag12 = (nint)0 == 0;
				object obj35 = !flag12;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X21_v8 (UnityEngine.Object)+30]");
				bool flag13 = (UnityEngine.Object)0;
				bool flag14 = !flag13;
				obj29 = 0;
				obj30 = null;
				if (!flag14)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj36 = ex & 1;
					bool flag15 = obj36 == null;
					obj29 = 0;
					obj30 = obj33;
					if (!flag15)
					{
						GillaCorpse body = c.body;
						NetworkBool normal = false;
						int corpse = body.Id__BackingField;
						GoreSection section = c.section;
						int slot = c.slot;
						GillaRip.Along along = c.along;
						Vector3 way2 = c.way;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+74]");
						object obj37 = default;
						((NetworkApe)obj26).RPC_SawCorpse(corpse, (byte)section, (byte)slot, (Vector3)normal, (float)along, (Vector3)(&obj37), (Vector3)0, (Vector3)rpcInfo, (NetworkBool)way2, (RpcInfo)0);
						return;
					}
				}
			}
		}
		GillaCorpse body2 = c.body;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v26+E4]");
		bool flag16 = (nint)0 == 0;
		object obj40 = !flag16;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj41 = default;
		GillaCorpse.SawBite(body2.Id__BackingField, c.section, c.slot, (GillaRip.Along)(&obj41), (Vector3)0, (Vector3)0, half, (byte)(int)rpcInfo != 0);
	}

	private unsafe void SendThrough(Cut c)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_0270: Expected VT, but got Ref
		//IL_02fc: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I4
		//IL_0664: Expected Obj, but got I4
		//IL_06c2: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got I4
		//IL_062c: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I
		//IL_05c4: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_05fc: Expected VT, but got Ref
		//IL_0400: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I4
		//IL_01d9: Expected VT, but got I4
		//IL_01d9: Expected F4, but got VT
		//IL_01d9: Expected VT, but got Ref
		//IL_043f: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I4
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_04c7: Expected Obj, but got I4
		//IL_0573: Expected VT, but got I
		//IL_0573: Expected VT, but got I4
		//IL_0573: Expected VT, but got Ref
		//IL_0573: Expected F4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)c.ape != (UnityEngine.Object)null)
		{
			NetworkApe ape = c.ape;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v66+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)((SimulationBehaviour)ape)._object != (UnityEngine.Object)null))
			{
				return;
			}
			NetworkApe ape2 = c.ape;
			NetworkObject networkObject = ((SimulationBehaviour)ape2)._object;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v71+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((bool)networkObject._runner)
			{
				ArgumentNullException ex = new ArgumentNullException();
				object obj8 = ex & 1;
				if (obj8 != null)
				{
					object obj9 = default;
					c.ape.RPC_SawThrough((byte)c.section, (Vector3)(&obj9), (float)c.along, (RpcInfo)0);
				}
			}
			return;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)c.dummy != (UnityEngine.Object)null)
		{
			object obj12 = default;
			c.dummy.SawThrough(c.section, (GillaRip.Along)(&obj12));
			return;
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(c.body != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v21+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj15;
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v21+A0]");
		object obj21 = 0;
		UnityEngine.Object obj22 = (UnityEngine.Object)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = (UnityEngine.Object)obj21 != null;
		bool flag10 = !flag9;
		object obj24 = 0;
		UnityEngine.Object obj25 = null;
		if (!flag10)
		{
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v30+E4]");
			bool flag11 = (nint)0 == 0;
			object obj27 = !flag11;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X20_v10 (UnityEngine.Object)+40]");
			bool flag12 = (UnityEngine.Object)0 != null;
			bool flag13 = !flag12;
			obj24 = 0;
			obj25 = null;
			if (!flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X20_v10 (UnityEngine.Object)+40]");
				UnityEngine.Object obj28 = (UnityEngine.Object)0;
				object obj29 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v35+E4]");
				bool flag14 = (nint)0 == 0;
				object obj30 = !flag14;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X21_v7 (UnityEngine.Object)+30]");
				bool flag15 = (UnityEngine.Object)0;
				bool flag16 = !flag15;
				obj24 = 0;
				obj25 = null;
				if (!flag16)
				{
					ArgumentNullException ex2 = new ArgumentNullException();
					object obj31 = ex2 & 1;
					bool flag17 = obj31 == null;
					obj24 = 0;
					obj25 = obj28;
					if (!flag17)
					{
						GillaCorpse body = c.body;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DDA8AC");
						NetworkBool normal = true;
						int corpse = body.Id__BackingField;
						GoreSection section = c.section;
						int slot = c.slot;
						GillaRip.Along along = c.along;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaSawHits+Cut)+5C]");
						object obj32 = default;
						Vector3 half = default;
						RpcInfo info = default;
						((NetworkApe)obj21).RPC_SawCorpse(corpse, (byte)section, (byte)slot, (Vector3)normal, (float)along, (Vector3)(&obj32), (Vector3)0, half, (NetworkBool)0, info);
						return;
					}
				}
			}
		}
		GillaCorpse body2 = c.body;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj33 = 0;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v26+E4]");
		bool flag18 = (nint)0 == 0;
		object obj35 = !flag18;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj36 = default;
		GillaCorpse.SawThrough(body2.Id__BackingField, c.section, (GillaRip.Along)(&obj36));
	}

	private void Spray(Cut c, Vector3 at, Vector3 onBar, Vector3 barWay, float dt)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0a3a: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_03df: Expected VT, but got I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_074a: Invalid comparison between F4 and I4
		//IL_075b: Expected Obj, but got I4
		//IL_0766: Invalid comparison between F4 and I4
		//IL_0777: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_03f8: Invalid comparison between F4 and I4
		//IL_0409: Expected Obj, but got I4
		//IL_0414: Invalid comparison between F4 and I4
		//IL_0425: Expected Obj, but got I4
		//IL_0444: Expected VT, but got I4
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_09c3: Expected F4, but got I
		//IL_09c3: Expected F4, but got I
		//IL_0da3: Expected Obj, but got I
		//IL_0dcd: Expected Obj, but got I4
		//IL_07c1: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I
		//IL_0c59: Expected Obj, but got I4
		//IL_0877: Expected Obj, but got I
		//IL_088f: Expected Obj, but got I
		//IL_089f: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I
		//IL_054c: Expected Obj, but got I
		//IL_0df3: Expected Obj, but got I
		//IL_0a66: Invalid comparison between F4 and I
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e15: Expected Obj, but got Unknown
		//IL_0e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2a: Expected Obj, but got Unknown
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected Obj, but got Unknown
		//IL_0e61: Expected Obj, but got I4
		//IL_0be7: Expected Obj, but got I
		//IL_0c11: Expected Obj, but got I4
		//IL_0aca: Expected Obj, but got I4
		//IL_0951: Expected I4, but got VT
		//IL_0951: Expected VT, but got I4
		//IL_0951: Expected VT, but got I4
		//IL_05ce: Invalid comparison between F8 and I
		//IL_0622: Expected Obj, but got I
		//IL_063a: Expected Obj, but got I
		//IL_0642: Expected F4, but got Obj
		//IL_0652: Expected F8, but got I
		//IL_0c7c: Expected Obj, but got I
		//IL_0cbc: Expected Obj, but got I
		//IL_0cd9: Expected Obj, but got I
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected Obj, but got Unknown
		//IL_0b6e: Expected Obj, but got I
		//IL_0d4e: Expected Obj, but got I4
		//IL_06b7: Invalid comparison between F8 and I
		//IL_0713: Expected Obj, but got I
		//IL_071b: Expected F4, but got Obj
		//IL_072b: Expected F8, but got I
		//IL_0b90: Expected Obj, but got I
		//IL_0bba: Expected Obj, but got I4
		//IL_0d74: Expected I4, but got VT
		//IL_0d74: Expected VT, but got I4
		//IL_0d74: Expected VT, but got I4
		//IL_0d8e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)c.ape != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		Dismemberment tearing;
		object obj9;
		UnityEngine.Object obj10;
		if (!flag3)
		{
			NetworkApe ape = c.ape;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v116+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = ape.tearing != null;
			bool flag6 = !flag5;
			obj4 = 0;
			obj5 = null;
			if (!flag6)
			{
				NetworkApe ape2 = c.ape;
				tearing = ape2.tearing;
				bool flag7 = (object)ape2.tearing == null;
				object obj8 = !flag7;
				obj9 = 0;
				obj10 = null;
				if (obj8 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_02de;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v100+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = (UnityEngine.Object)c.dummy != (UnityEngine.Object)null;
		bool flag10 = !flag9;
		object obj13 = 0;
		UnityEngine.Object obj14 = null;
		if (!flag10)
		{
			GillaDummy dummy = c.dummy;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v110+E4]");
			bool flag11 = (nint)0 == 0;
			object obj16 = !flag11;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag12 = dummy.tearing != null;
			bool flag13 = !flag12;
			obj13 = 0;
			obj14 = null;
			if (!flag13)
			{
				GillaDummy dummy2 = c.dummy;
				tearing = dummy2.tearing;
				obj9 = 0;
				obj10 = null;
				goto IL_02de;
			}
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v105+E4]");
		bool flag14 = (nint)0 == 0;
		object obj18 = !flag14;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = c.body != null;
		bool flag16 = !flag15;
		obj9 = 0;
		obj10 = null;
		UnityEngine.Object obj19 = null;
		object obj20;
		if (!flag16)
		{
			obj20 = c.body + 224;
			obj9 = 0;
			obj10 = null;
			goto IL_09d4;
		}
		goto IL_09e1;
		IL_09d4:
		obj19 = (UnityEngine.Object)obj20;
		goto IL_09e1;
		IL_02de:
		obj20 = tearing + 48;
		goto IL_09d4;
		IL_09e1:
		float num = sprayIn;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj22 = default;
		float num2 = sprayIn - (float)obj22;
		sprayIn = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v9+E4]");
		bool flag17 = (nint)0 == 0;
		object obj23 = !flag17;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag18 = obj19 != null;
		bool flag19 = !flag18;
		int num3 = 0;
		Vector3 vector = (Vector3)0;
		object obj31 = default;
		object obj33 = default;
		object obj36 = default;
		if (!flag19)
		{
			bool flag20 = sprayIn < 0f;
			object obj24 = !flag20;
			bool flag21 = sprayIn == 0f;
			object obj25 = !flag21;
			object obj26 = obj24 & obj25;
			num3 = 0;
			vector = (Vector3)0;
			if (obj26 == null)
			{
				sprayIn = 0.045f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj27 = 0;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v54+E4]");
				bool flag22 = (nint)0 == 0;
				object obj29 = !flag22;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj30 = obj31 * obj31;
				object obj32 = obj33 * obj33;
				object obj34 = obj30 + obj32;
				object obj35 = obj36 * obj36;
				object obj37 = obj35 + obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				object obj38;
				object obj39;
				if ((nint)obj37 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					obj38 = obj36 / obj37;
					obj39 = obj31 / obj31;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj40 = 0;
					object obj41 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v85+A0]");
					object obj42 = 0;
					obj39 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v86+8]");
					obj38 = 0;
				}
				float value = UnityEngine.Random.value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				double num4 = ((!(value < 0f)) ? (-1.0) : 1.0);
				object obj43 = obj27;
				float num6 = default;
				float num5 = num6 - dt;
				double num8 = default;
				object obj44 = default;
				double num7 = num8 - (double)obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v59+E4]");
				bool flag23 = (nint)0 == 0;
				object obj45 = !flag23;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				object obj47 = default;
				object obj46 = obj39 * obj47;
				double num9 = (double)obj38 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				double num10;
				float num11;
				if (num8 > 0.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num10 = num7 / num8;
					object obj48 = default;
					num11 = num5 / (float)obj48;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj49 = 0;
					object obj50 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v79+A0]");
					object obj51 = 0;
					num11 = (float)obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v80+8]");
					num10 = 0.0;
				}
				float num12 = (float)obj46 * dt;
				double num13 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				double num14 = num13 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				double num15 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				double num16 = num15 * 0.0;
				object obj52 = default;
				float num17 = num11 * (float)obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj53 = 0;
				float num18 = num12 + num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				double num19 = num14 + num16;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v59+A0]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v60+20]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
				object obj56 = num20 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v60+18]");
				object obj57 = 0 * obj46;
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				double num21 = num19 + (double)obj56;
				float num22 = num18 + (float)obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
				nint num23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				object obj58 = num23 * 0;
				object obj59 = obj46 * obj44;
				object obj60 = obj27;
				float num24 = num22 + (float)obj59;
				double num25 = num21 + (double)obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X0_v66+E4]");
				bool flag24 = (nint)0 == 0;
				object obj61 = !flag24;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num26 = num24 * num24;
				double num27 = num25 * num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				double num28 = num27 + (double)num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (num28 > 0.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num6 = num24 / (float)num27;
					double num29 = num25 / num28;
				}
				else
				{
					object obj62 = obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v72+A0]");
					object obj63 = 0;
					num6 = (float)obj63;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v73+8]");
					double num29 = 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
				object obj64 = 0;
				object obj65 = obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X0_v68+E4]");
				bool flag25 = (nint)0 == 0;
				object obj66 = !flag25;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Blood.Chain((Vector3)5, (Vector3)0, 0, (int)onBar);
				float num30 = default;
				num = num30;
				num3 = 0;
				vector = (Vector3)0;
			}
		}
		bool flag26 = bitsIn < 0f;
		object obj67 = !flag26;
		bool flag27 = bitsIn == 0f;
		object obj68 = !flag27;
		object obj69 = obj67 & obj68;
		if (obj69 == null)
		{
			bitsIn = 0.16f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj70 = 0;
			object obj71 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v24+E4]");
			bool flag28 = (nint)0 == 0;
			object obj72 = !flag28;
			if (obj72 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj73 = 0;
			object obj74 = obj31 * obj31;
			object obj75 = obj33 * obj33;
			object obj76 = obj74 + obj75;
			object obj77 = obj36 * obj36;
			object obj78 = obj77 + obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj79;
			object obj80;
			object obj81;
			if ((nint)obj78 > 0)
			{
				obj79 = obj31 / obj78;
				obj80 = obj33 / obj78;
				obj81 = obj36 / obj78;
			}
			else
			{
				object obj82 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v36+A0]");
				object obj83 = 0;
				obj79 = obj83;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v37+4]");
				obj80 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v37+8]");
				obj81 = 0;
			}
			object obj84 = obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v21+A0]");
			object obj85 = 0;
			object obj86 = obj70;
			object obj87 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v22+18]");
			object obj88 = obj87 + 0;
			object obj89 = obj80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v22+1C]");
			object obj90 = obj89 + 0;
			object obj91 = obj81;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v22+20]");
			object obj92 = obj91 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v29+E4]");
			bool flag29 = (nint)0 == 0;
			object obj93 = !flag29;
			if (obj93 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj94 = obj88 * obj88;
			object obj95 = obj90 * obj90;
			object obj96 = obj94 + obj95;
			object obj97 = obj92 * obj92;
			object obj98 = obj96 + obj97;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj98 > 0)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj99 = 0;
			object obj100 = obj99;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v31+E4]");
			bool flag30 = (nint)0 == 0;
			object obj101 = !flag30;
			if (obj101 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Blood.Chain((Vector3)0, (Vector3)1, 0, (int)onBar);
		}
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)5);
		InputDevice inputDevice = default;
		if (inputDevice.isValid)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			bool flag31 = inputDevice.SendHapticImpulse(0u, num31, 0f);
		}
	}

	private void Forget()
	{
		//IL_009e: Expected Obj, but got I4
		hadBar = false;
		((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)outFirst).Clear();
		List<Cut> list = cuts;
		int num = list._size;
		if (list._size < 1)
		{
			return;
		}
		float num3 = default;
		float num4 = default;
		bool flag3;
		do
		{
			num--;
			System.__Canon _Canon = ((List<System.__Canon>)(object)cuts).get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8 (System.__Canon)+94]");
			bool flag = (nint)0 == 0;
			object obj = !flag;
			float num5;
			float num6;
			if (obj == null)
			{
				float time = Time.time;
				System.__Canon _Canon2 = ((List<System.__Canon>)(object)cuts).get_Item(num);
				float num2 = time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v14 (System.__Canon)+90]");
				num3 = num2 - 0f;
				bool flag2 = !((double)num3 > 3.0);
				num4 = time;
				num5 = time;
				num6 = num3;
				if (flag2)
				{
					goto IL_0149;
				}
			}
			((List<System.__Canon>)(object)cuts).RemoveAt(num);
			num5 = num4;
			num6 = num3;
			goto IL_0149;
			IL_0149:
			flag3 = num > 0;
			num4 = num5;
			num3 = num6;
		}
		while (flag3);
	}

	private unsafe static float Closest(Vector3 a0, Vector3 a1, Vector3 b0, Vector3 b1, out Vector3 onA, out Vector3 onB)
	{
		//IL_00e4: Expected Obj, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0576: Invalid comparison between F8 and I4
		//IL_0585: Expected F8, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I4
		//IL_01a1: Expected F8, but got I4
		//IL_01b8: Expected F8, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_08cb: Expected native int or pointer, but got VT
		//IL_08d8: Expected native int or pointer, but got VT
		//IL_08e5: Expected native int or pointer, but got VT
		//IL_08f2: Expected native int or pointer, but got VT
		//IL_08ff: Expected native int or pointer, but got VT
		//IL_090c: Expected native int or pointer, but got VT
		//IL_05bc: Expected F8, but got I4
		//IL_05e4: Unsupported input type for neg.
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_0601: Invalid comparison between F8 and I4
		//IL_0610: Expected F8, but got I4
		//IL_078a: Expected Obj, but got I
		//IL_07b4: Expected Obj, but got I4
		//IL_0467: Expected F8, but got I4
		//IL_05db: Expected F8, but got I4
		//IL_07f8: Invalid comparison between F8 and I4
		//IL_04b4: Invalid comparison between F8 and I4
		//IL_04c3: Expected F8, but got I4
		//IL_0655: Expected F8, but got I4
		//IL_0513: Unsupported input type for neg.
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0530: Invalid comparison between F8 and I4
		//IL_06a3: Invalid comparison between F8 and I4
		//IL_06bf: Expected F8, but got I4
		//IL_0741: Expected F8, but got I4
		//IL_074a: Expected F8, but got I4
		//IL_0550: Expected F8, but got I4
		//IL_0559: Expected F8, but got I4
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj8 = default;
		object obj9 = default;
		object obj7 = obj8 - obj9;
		object obj10 = obj * obj;
		object obj11 = obj4 * obj4;
		object obj13 = default;
		object obj14 = default;
		object obj12 = obj13 - obj14;
		object obj16 = default;
		object obj17 = default;
		object obj15 = obj16 - obj17;
		object obj19 = default;
		object obj20 = default;
		object obj18 = obj19 - obj20;
		object obj21 = obj7 * obj7;
		object obj22 = obj10 + obj11;
		object obj23 = obj15 * obj15;
		object obj24 = obj18 * obj18;
		object obj25 = obj21 + obj22;
		object obj26 = obj12 * obj12;
		object obj27 = obj23 + obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
		bool flag = (nint)obj25 < 0;
		object obj28 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
		object obj29 = obj25 - 0;
		bool flag2 = obj29 == null;
		object obj30 = obj26 + obj27;
		object obj31 = !flag2;
		object obj32 = obj28 & obj31;
		double num;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
			bool flag3 = (nint)obj30 < 0;
			object obj33 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
			object obj34 = obj30 - 0;
			bool flag4 = obj34 == null;
			object obj35 = !flag4;
			object obj36 = obj33 & obj35;
			num = 0.0;
			if (obj36 == null)
			{
				goto IL_01af;
			}
		}
		object obj37 = obj3 - obj17;
		object obj38 = obj6 - obj20;
		object obj39 = obj9 - obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
		bool flag5 = (nint)obj25 < 0;
		object obj40 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
		object obj41 = obj25 - 0;
		bool flag6 = obj41 == null;
		object obj42 = obj37 * obj15;
		object obj43 = obj38 * obj18;
		object obj44 = obj42 + obj43;
		object obj45 = obj39 * obj12;
		object obj46 = obj45 + obj44;
		object obj47 = ~obj40;
		object obj48 = obj47 | flag6;
		double num2;
		double num3;
		double num7;
		if (obj48 == null)
		{
			object obj49 = obj * obj37;
			object obj50 = obj4 * obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
			bool flag7 = (nint)obj30 < 0;
			object obj51 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
			object obj52 = obj30 - 0;
			bool flag8 = obj52 == null;
			object obj53 = obj7 * obj39;
			object obj54 = obj49 + obj50;
			object obj55 = obj53 + obj54;
			object obj56 = ~obj51;
			object obj57 = obj56 | flag8;
			if (obj57 != null)
			{
				object obj58 = 0 - obj55;
				num2 = (double)obj58 / (double)obj25;
				bool flag9 = num2 < 0.0;
				num = 0.0;
				if (!flag9)
				{
					bool flag10 = num2 > 1.0;
					num = 1.0;
					if (!flag10)
					{
						num3 = 0.0;
						goto IL_0765;
					}
				}
				goto IL_01af;
			}
			object obj59 = obj * obj15;
			object obj60 = obj4 * obj18;
			object obj61 = obj59 + obj60;
			object obj62 = obj7 * obj12;
			object obj63 = obj62 + obj61;
			object obj64 = obj25 * obj30;
			object obj65 = obj63 * obj63;
			object obj66 = obj64 - obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
			bool flag11 = (nint)obj66 <= 0;
			num = 0.0;
			if (!flag11)
			{
				object obj67 = obj63 * obj46;
				object obj68 = obj55 * obj30;
				object obj69 = obj67 - obj68;
				double num4 = (double)obj69 / (double)obj66;
				bool flag12 = num4 < 0.0;
				num = 0.0;
				if (!flag12)
				{
					bool flag13 = !(num4 > 1.0);
					num = num4;
					if (!flag13)
					{
						num = 1.0;
					}
				}
			}
			double num5 = (double)obj63 * num;
			double num6 = (double)obj46 + num5;
			num7 = num6 / (double)obj30;
			if (num7 < 0.0)
			{
				object obj70 = 0 - obj55;
				num2 = (double)obj70 / (double)obj25;
				if (num2 < 0.0)
				{
					num7 = 0.0;
					num = 0.0;
				}
				else
				{
					bool flag14 = num2 > 1.0;
					num3 = 0.0;
					num7 = 0.0;
					num = 1.0;
					if (!flag14)
					{
						goto IL_0765;
					}
				}
			}
			else if (num7 > 1.0)
			{
				object obj71 = obj63 - obj55;
				double num8 = (double)obj71 / (double)obj25;
				bool flag15 = num8 < 0.0;
				num7 = 1.0;
				num = 0.0;
				if (!flag15)
				{
					bool flag16 = !(num8 > 1.0);
					num7 = 1.0;
					num = num8;
					if (!flag16)
					{
						num7 = 1.0;
						num = 1.0;
					}
				}
			}
		}
		else
		{
			double num9 = (double)obj46 / (double)obj30;
			bool flag17 = num9 < 0.0;
			num = 0.0;
			if (flag17)
			{
				goto IL_01af;
			}
			bool flag18 = num9 > 1.0;
			num7 = 1.0;
			num = 0.0;
			if (!flag18)
			{
				num7 = num9;
				num = 0.0;
			}
		}
		goto IL_080f;
		IL_080f:
		double num10 = (double)obj * num;
		double num11 = (double)obj4 * num;
		double num12 = (double)obj7 * num;
		double num13 = (double)obj15 * num7;
		double num14 = (double)obj18 * num7;
		double num15 = (double)obj3 + num10;
		double num16 = (double)obj12 * num7;
		double num17 = (double)obj6 + num11;
		double num18 = (double)obj9 + num12;
		double num19 = (double)obj17 + num13;
		double num20 = (double)obj20 + num14;
		double num21 = (double)obj14 + num16;
		((Vector3*)(nint)a0)->x = (float)num15;
		((Vector3*)(nint)a0)->y = (float)num17;
		((Vector3*)(nint)a0)->z = (float)num18;
		((Vector3*)(nint)a1)->x = (float)num19;
		((Vector3*)(nint)a1)->y = (float)num20;
		((Vector3*)(nint)a1)->z = (float)num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj72 = 0;
		object obj73 = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v2+E4]");
		bool flag19 = (nint)0 == 0;
		object obj74 = !flag19;
		if (obj74 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num22 = a0.y - (float)num20;
		float num23 = a0.x - (float)num19;
		float num24 = a0.z - (float)num21;
		float num25 = num23 * num23;
		float num26 = num22 * num22;
		float num27 = num25 + num26;
		float num28 = num24 * num24;
		float result = num27 + num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
		IL_01af:
		num7 = 0.0;
		goto IL_080f;
		IL_0765:
		num7 = num3;
		num = num2;
		goto IL_080f;
	}

	public GillaSawHits()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_029a: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7108]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7118]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3, Vector3, float)> list = default;
		list._002Ector();
		object obj6 = this + 168;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj7 = this + 176;
		obj7 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)> hashSet = default;
		hashSet._002Ector();
		object obj8 = this + 184;
		obj8 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)> hashSet2 = default;
		hashSet2._002Ector();
		object obj9 = this + 192;
		obj9 = hashSet2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, float> dictionary = default;
		dictionary._002Ector();
		object obj10 = this + 208;
		obj10 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7138]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, float> dictionary2 = default;
		dictionary2._002Ector();
		object obj12 = this + 216;
		obj12 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7140]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum), System.__Canon> dictionary3 = default;
		dictionary3._002Ector();
		object obj14 = this + 224;
		obj14 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj15 = 0;
		object obj16 = this + 240;
		obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7148]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<PieceKey, float> dictionary4 = default;
		dictionary4._002Ector();
		object obj18 = this + 280;
		inPiece = dictionary4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7160]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, Vector3)> list3 = default;
		list3._002Ector();
		object obj20 = this + 288;
		touching = (List<(GillaPieceId, Vector3)>)(object)list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7040]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<PieceKey> list4 = default;
		list4._002Ector();
		object obj22 = this + 296;
		stillIn = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<PieceKey> hashSet3 = default;
		hashSet3._002Ector();
		object obj23 = this + 304;
		touchingNow = hashSet3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<PieceKey> hashSet4 = default;
		hashSet4._002Ector();
		object obj24 = this + 312;
		waiting = hashSet4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaSawHits()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C768]");
		obj3 = 0;
		_ = 1052166324;
	}

	private bool _003CPieces_003Eb__103_0(PieceKey k)
	{
		//IL_0069: Expected I4, but got Obj
		//IL_0024: Expected Obj, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected I4, but got Unknown
		if (touchingNow != null)
		{
			bool flag = touchingNow.Contains(k);
			object obj = !flag;
			return (byte)(1 & obj) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
