using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class GillaStash : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public string key;

		internal bool _003CShowWorn_003Eb__0((string, Renderer, Mesh) w)
		{
			//IL_000f: Expected Obj, but got VT
			return w == key;
		}
	}

	private class Coming
	{
		public GillaItem item;

		public Vector3 from;

		public Vector3 to;

		public float t;

		public float seconds;
	}

	private class Going
	{
		public GillaItem item;

		public float t;

		public Vector3 from;

		public Vector3 size;

		public Vector3 spin;

		public Quaternion turn;
	}

	private class Tile
	{
		public GameObject root;

		public GameObject model;

		public string label;

		public float pop;

		public float k = 1f;

		public float kV;

		public Vector2 lean;

		public Vector2 leanV;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<(string, int), string> _003C_003E9__138_0;

		public static Func<Tile, string> _003C_003E9__142_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B18]");
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

		internal string _003CKinds_003Eb__138_0((string, int) i)
		{
			//IL_0005: Expected Obj, but got VT
			return i;
		}

		internal string _003CMakeTiles_003Eb__142_0(Tile t)
		{
			if (t != null)
			{
				return t.label;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public string label;

		internal bool _003CEject_003Eb__0(Tile x)
		{
			//IL_0048: Expected I4, but got Obj
			if (x != null)
			{
				return x.label == label;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public GillaItem item;

		internal bool _003CTrayFull_003Eb__0(Coming c)
		{
			//IL_0087: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			if (c != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return c.item == item;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass134_0
	{
		public bool any;

		public Bounds b;
	}

	public Renderer screen;

	public Transform hopper;

	public Transform chute;

	public Transform tray;

	public Renderer body;

	public int lampSlot;

	public Transform[] fingertips;

	public TextAsset titleFont;

	public TextAsset textFont;

	public float wakeRange;

	public float ejectEvery;

	public AudioClip[] putInSounds;

	public AudioClip storedSound;

	public AudioClip ejectSound;

	public AudioClip denySound;

	public AudioClip clickSound;

	public AudioClip hoverSound;

	public AudioClip fillSound;

	public AudioClip bootSound;

	public AudioClip offSound;

	private const int W = default(int);

	private const int H = default(int);

	private const int GridX = default(int);

	private const int GridY = default(int);

	private const int TileW = default(int);

	private const int TileH = default(int);

	private const int TileGap = default(int);

	private const int Cols = default(int);

	private const int Rows = default(int);

	private const int PerPage = default(int);

	private static readonly RectInt InfoRect;

	private static readonly RectInt PageRect;

	private static readonly RectInt ButtonRect;

	private static readonly RectInt PrevRect;

	private static readonly RectInt NextRect;

	private static readonly int BaseMap;

	private static readonly int BaseColor;

	private static readonly Color32 Black;

	private static readonly Color32 Scan;

	private static readonly Color32 Line;

	private static readonly Color32 Dim;

	private static readonly Color32 Dark;

	private static readonly Color32 Bright;

	private static readonly Color32 Warn;

	private static readonly Color32[] Plain;

	private static readonly Color32[] Picked;

	private static readonly Color32[] DimText;

	private static readonly Color32[] Warning;

	private static readonly Color32[] DarkText;

	private static readonly Color32[] BoltText;

	private static readonly Color32 CountTag;

	private static readonly Color32 CountTagPicked;

	private const float GoingDown = default(float);

	private const float PopSeconds = default(float);

	private const float PopStagger = default(float);

	private const float ModelSize = default(float);

	private const float ModelOut = default(float);

	private const float ModelDown = default(float);

	private const float ModelTilt = default(float);

	private const float BayBelow = default(float);

	private const float BayAbove = default(float);

	private const float BayWide = default(float);

	private const float ClearAhead = default(float);

	private const float PushSpeed = default(float);

	private const float PopOut = default(float);

	private const float PopUp = default(float);

	private const float CrowdOut = default(float);

	private const float CrowdAcross = default(float);

	private const int TrayMost = default(int);

	public static readonly List<GillaStash> All;

	private readonly List<Going> going;

	private readonly List<Coming> coming;

	private readonly HashSet<GillaItem> refused;

	private readonly List<Tile> tiles;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private MaterialPropertyBlock lampBlock;

	private ScreenFont title;

	private ScreenFont text;

	private Transform tileRoot;

	private string selected;

	private int page;

	private int shownPage;

	private int shownCount;

	private float awake;

	private float holdFill;

	private float nextEject;

	private float pressFlash;

	private float bannerUntil;

	private float work;

	private float flash;

	private const float ClunkEvery = default(float);

	private const float DenyEvery = default(float);

	private float clunkedAt;

	private float deniedAt;

	private bool wanted;

	private bool mouseDown;

	private bool dirty;

	private string banner;

	private string hovered;

	private string pressedThing;

	private bool bannerBad;

	private Vector3 overAt;

	private readonly bool[] down;

	private readonly string[] downOn;

	private Color lampColour;

	private static readonly Dictionary<string, GameObject> prefabs;

	private static float prefabsAt;

	private const float ShaftFloor = default(float);

	private const float OverOpening = default(float);

	public static bool OfflineForTest;

	private int Pages
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0187: Expected Obj, but got I4
			//IL_015d: Expected I4, but got Obj
			//IL_005d: Expected Obj, but got I4
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected Obj, but got Unknown
			//IL_0094: Expected I4, but got Obj
			//IL_00a2: Expected Obj, but got I4
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected I4, but got Unknown
			//IL_0110: Expected Obj, but got I4
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			List<string> list = Kinds();
			if ((object)list != null)
			{
				object obj4 = list._size + 5;
				object obj5 = obj4 * 715827883;
				object obj6 = obj5 >> 63;
				object obj7 = obj5 >> 32;
				int num = (int)(obj7 + obj6);
				object obj8 = num - 1;
				bool flag2 = (nint)obj8 < 0;
				bool flag3 = obj8 == null;
				int num2 = num ^ 1;
				int num3 = num ^ obj8;
				int num4 = num2 & num3;
				bool flag4 = num4 < 0;
				bool flag5 = flag2 == flag4;
				object obj9 = !flag3;
				object obj10 = flag5 & obj9;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
					return num;
				}
				return 1;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private Vector2 Size
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_014b: Expected Obj, but got I4
			//IL_0166: Expected VT, but got I4
			//IL_0121: Expected VT, but got Obj
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
			bool flag2 = screen != null;
			if (flag2)
			{
				if ((object)screen != null)
				{
					Transform transform = screen.transform;
					if ((object)transform != null)
					{
						Vector3 lossyScale = transform.lossyScale;
						if ((object)screen != null)
						{
							Transform transform2 = screen.transform;
							if ((object)transform2 != null)
							{
								return transform2.lossyScale;
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (Vector2)ex;
			}
			return (Vector2)flag2;
		}
	}

	public string Selected => selected;

	public string Banner
	{
		get
		{
			float time = Time.time;
			bool flag = !(time < bannerUntil);
			string result = null;
			if (!flag)
			{
				result = banner;
			}
			return result;
		}
	}

	public bool IsOn
	{
		get
		{
			//IL_001f: Invalid comparison between F4 and I4
			//IL_0039: Expected Obj, but got F8
			//IL_0048: Expected Obj, but got F4
			float num = awake - 1f;
			bool flag = num < 0f;
			object obj = (double)awake ^ 1.0;
			object obj2 = awake ^ num;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			return flag == flag2;
		}
	}

	public int Page => page;

	public int TileCount
	{
		get
		{
			//IL_001d: Expected I4, but got Obj
			List<Tile> list = tiles;
			if (tiles != null)
			{
				return list._size;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public Vector3 ButtonAt
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01d0: Expected Obj, but got I4
			//IL_01a6: Expected VT, but got Obj
			//IL_0061: Expected Obj, but got I
			//IL_0079: Expected Obj, but got I
			//IL_009b: Expected Obj, but got I4
			//IL_00e2: Expected Obj, but got I4
			//IL_0156: Expected VT, but got I4
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
			if (tileRoot != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Vector2 size = Size;
				if ((object)tileRoot != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					return tileRoot.TransformPoint((Vector3)0);
				}
			}
			else
			{
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public int GoingIn
	{
		get
		{
			//IL_001d: Expected I4, but got Obj
			List<Going> list = going;
			if (going != null)
			{
				return list._size;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int ComingOut
	{
		get
		{
			//IL_001d: Expected I4, but got Obj
			List<Coming> list = coming;
			if (coming != null)
			{
				return list._size;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public Vector3 OutOfItsFront => Ahead();

	private static Color32 C(byte r, byte g, byte b)
	{
		//IL_0045: Expected VT, but got I8
		int num = g & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	public static GameObject PrefabOf(string label)
	{
		//IL_031e: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(label);
		bool flag2 = !flag;
		object obj = !flag2;
		GameObject result = null;
		object obj2;
		System.__Canon _Canon;
		float num4 = default;
		double num;
		float num3;
		object obj11 = default;
		System.__Canon _Canon2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
			obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6+B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F0]");
				object obj6 = 0;
				_Canon = (System.__Canon)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6+B8]");
				int count = ((Dictionary<System.__Canon, System.__Canon>)0).Count;
				object obj7 = obj2;
				if (count == 0)
				{
					goto IL_01c6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v23+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v23+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v20+B8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89E8]");
					object obj10 = 0;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v20+B8]");
					bool flag5 = ((Dictionary<System.__Canon, System.__Canon>)0).ContainsKey((System.__Canon)(object)label);
					bool flag6 = !flag5;
					object obj12 = !flag6;
					double num2 = default;
					num = num2;
					num3 = num4;
					_Canon2 = (System.__Canon)(object)label;
					if (obj12 == null)
					{
						float unscaledTime = Time.unscaledTime;
						obj7 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v23+E4]");
						bool flag7 = (nint)0 == 0;
						object obj13 = !flag7;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj7 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v23+A0]");
						object obj14 = 0;
						float num5 = unscaledTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v24+C0]");
						num4 = num5 - 0f;
						bool flag8 = !((double)num4 > 5.0);
						_Canon = (System.__Canon)(object)label;
						num = 5.0;
						num3 = num4;
						_Canon2 = (System.__Canon)(object)label;
						if (!flag8)
						{
							goto IL_01c6;
						}
					}
					goto IL_0234;
				}
			}
			goto IL_02e9;
		}
		goto IL_0331;
		IL_02e9:
		return (GameObject)(object)new NullReferenceException();
		IL_0234:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v15+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v15+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+B8]");
		if ((nint)0 == 0)
		{
			goto IL_02e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+B8]");
		bool flag10 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)label, out var value);
		bool flag11 = !flag10;
		object obj18 = !flag11;
		object obj19 = ~obj18;
		result = (GameObject)(object)((obj19 != null) ? null : value);
		goto IL_0331;
		IL_0331:
		return result;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v23+E4]");
		bool flag12 = (nint)0 == 0;
		object obj20 = !flag12;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Learn();
		num = 5.0;
		num3 = num4;
		obj11 = obj11;
		_Canon2 = _Canon;
		goto IL_0234;
	}

	private static void Learn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0813: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I
		//IL_0841: Expected Obj, but got I
		//IL_08d6: Expected Obj, but got I
		//IL_08f6: Expected Obj, but got I
		//IL_0920: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I8
		//IL_00f0: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0947: Expected Obj, but got I4
		//IL_0286: Expected Obj, but got I8
		//IL_029c: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_0487: Expected Obj, but got I8
		//IL_096e: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04eb: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_0573: Expected Obj, but got I8
		//IL_02ef: Expected Obj, but got I
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05d7: Expected Obj, but got I4
		//IL_05ed: Expected Obj, but got I
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I4
		//IL_0384: Expected Obj, but got I
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_0667: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_0714: Expected Obj, but got I8
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_072b: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I4
		//IL_075a: Expected Obj, but got I4
		//IL_0788: Expected Obj, but got I
		//IL_0798: Expected Obj, but got I
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		float unscaledTime = Time.unscaledTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
		object obj6 = 0;
		object obj7 = obj5;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8+A0]");
		object obj9 = 0;
		UnityEngine.Object obj10 = (UnityEngine.Object)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v11 (UnityEngine.Object)+20]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v11 (UnityEngine.Object)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X23_v11+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X23_v11+18]");
					object obj13 = 0 & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v11 (UnityEngine.Object)+20]");
					object obj14 = (nint)0 + (nint)32;
					object obj15 = 0;
					while (true)
					{
						bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
						object obj16 = !flag3;
						if (obj16 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X25_v5+v312 @ X24_v8*8]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X25_v5+v312 @ X24_v8*8]");
						if ((nint)0 != 0)
						{
							object obj18 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v56+E4]");
							bool flag4 = (nint)0 == 0;
							object obj19 = !flag4;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v13+10]");
							_003CLearn_003Eg__Add_007C114_0((GameObject)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X23_v11+18]");
							obj13 = 0;
						}
						obj15++;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
						{
							continue;
						}
						goto IL_01a0;
					}
					goto IL_07cb;
				}
			}
		}
		goto IL_01a0;
		IL_07cb:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0389:
		GillaSpawnables gillaSpawnables = GillaSpawnables.Get();
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(gillaSpawnables != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v27+18]");
		if ((nint)0 != 0)
		{
			object obj24 = default;
			object obj23 = obj24 + 32;
			obj23 = gillaSpawnables.egg;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v8-8]");
			object obj25 = 0 & 0xFFFFFFFEL;
			if (obj25 != null)
			{
				object obj26 = obj24 + 40;
				obj26 = gillaSpawnables.bearTrap;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X21_v10-10]");
				bool flag6 = (nint)0 < (nint)2;
				object obj27 = !flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X21_v10-10]");
				object obj28 = -2;
				bool flag7 = obj28 == null;
				object obj29 = ~obj27;
				object obj30 = obj29 | flag7;
				if (obj30 == null)
				{
					object obj31 = obj24 + 48;
					obj31 = gillaSpawnables.dynamite;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X21_v12-18]");
					object obj32 = 0 & 0xFFFFFFFCL;
					if (obj32 != null)
					{
						object obj33 = obj24 + 56;
						obj33 = gillaSpawnables.woodPickaxe;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X21_v14-20]");
						bool flag8 = (nint)0 < (nint)4;
						object obj34 = !flag8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X21_v14-20]");
						object obj35 = -4;
						bool flag9 = obj35 == null;
						object obj36 = ~obj34;
						object obj37 = obj36 | flag9;
						if (obj37 == null)
						{
							object obj38 = obj24 + 64;
							obj38 = gillaSpawnables.metalPickaxe;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X21_v16-28]");
							bool flag10 = (nint)0 < (nint)5;
							object obj39 = !flag10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X21_v16-28]");
							object obj40 = -5;
							bool flag11 = obj40 == null;
							object obj41 = ~obj39;
							object obj42 = obj41 | flag11;
							if (obj42 == null)
							{
								object obj43 = obj24 + 72;
								obj43 = gillaSpawnables.backpack;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X20_v9-30]");
								if ((nint)0 < (nint)1)
								{
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X20_v9-30]");
								object obj44 = 0 & 0xFFFFFFFFL;
								object obj45 = obj24 + 32;
								object obj46 = 0;
								while (true)
								{
									bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44);
									object obj47 = !flag12;
									if (obj47 != null)
									{
										break;
									}
									object obj48 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v41+E4]");
									bool flag13 = (nint)0 == 0;
									object obj49 = !flag13;
									if (obj49 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X23_v7+v343 @ X21_v18*8]");
									_003CLearn_003Eg__Add_007C114_0((GameObject)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v27+18]");
									obj44 = 0;
									obj46++;
									object obj50 = obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v27+18]");
									if ((nint)obj50 >= 0)
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
		goto IL_07cb;
		IL_01a0:
		object obj51 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v15+E4]");
		bool flag14 = (nint)0 == 0;
		object obj52 = !flag14;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v11 (UnityEngine.Object)+60]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v11 (UnityEngine.Object)+60]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X20_v12+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X20_v12+18]");
					object obj54 = 0 & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v11 (UnityEngine.Object)+60]");
					object obj55 = (nint)0 + (nint)32;
					object obj56 = 0;
					while (true)
					{
						bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54);
						object obj57 = !flag15;
						if (obj57 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X24_v6+v399 @ X23_v9*8]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X24_v6+v399 @ X23_v9*8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X9_v9+10]");
							object obj59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X9_v9+10]");
							if ((nint)0 != 0)
							{
								object obj60 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X9_v11+10]");
								obj10 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v49+E4]");
								bool flag16 = (nint)0 == 0;
								object obj61 = !flag16;
								if (obj61 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								_003CLearn_003Eg__Add_007C114_0((GameObject)obj10);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X20_v12+18]");
								obj54 = 0;
							}
						}
						obj56++;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54))
						{
							continue;
						}
						goto IL_0389;
					}
					goto IL_07cb;
				}
			}
		}
		goto IL_0389;
	}

	public static bool Takes(GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0398: Expected I4, but got Obj
		//IL_0090: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I4
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
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			if ((object)item == null)
			{
				goto IL_038a;
			}
			bool flag4 = (byte)(~(item.keeps ? 1u : 0u)) != 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				bool flag5 = (byte)(~(item.Floats__BackingField ? 1u : 0u)) != 0;
				object obj6 = !flag5;
				if (obj6 == null)
				{
					bool flag6 = (byte)(~(item.StaffOnly__BackingField ? 1u : 0u)) != 0;
					object obj7 = !flag6;
					if (obj7 == null)
					{
						bool flag7 = (byte)(~(item.Gone__BackingField ? 1u : 0u)) != 0;
						object obj8 = !flag7;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
							object obj9 = 0;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v11+E4]");
							bool flag8 = (nint)0 == 0;
							object obj11 = !flag8;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GameObject gameObject = PrefabOf(item.label);
							object obj12 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v14+E4]");
							bool flag9 = (nint)0 == 0;
							object obj13 = !flag9;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!(gameObject == null))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A08]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
								object obj16 = default;
								object obj15 = obj16 & 1;
								if (obj15 == null)
								{
									goto IL_02e5;
								}
								GillaDynamite gillaDynamite = default;
								if ((object)gillaDynamite == null)
								{
									goto IL_038a;
								}
								bool isLit = gillaDynamite.IsLit;
								bool flag10 = !isLit;
								object obj17 = !flag10;
								if (obj17 == null)
								{
									if ((object)gillaDynamite == null)
									{
										goto IL_038a;
									}
									bool isBlown = gillaDynamite.IsBlown;
									bool flag11 = !isBlown;
									object obj18 = !flag11;
									if (obj18 == null)
									{
										goto IL_02e5;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_01ee;
		IL_02e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A00]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		object obj21 = default;
		object obj20 = obj21 & 1;
		if (obj20 != null)
		{
			GillaBearTrap gillaBearTrap = default;
			if ((object)gillaBearTrap == null)
			{
				goto IL_038a;
			}
			bool spent = gillaBearTrap.Spent;
			bool flag12 = !spent;
			object obj22 = !flag12;
			if (obj22 != null)
			{
				goto IL_01ee;
			}
		}
		return true;
		IL_038a:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01ee:
		return false;
	}

	private static List<string> Contents(GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_0221: Expected I4, but got Obj
		//IL_0266: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I
		//IL_02eb: Expected Obj, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5228]");
			System.__Canon[] array = (System.__Canon[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj7 = default;
			object obj6 = obj7 & 1;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
				object obj9 = 0;
				GillaBackpack gillaBackpack2 = default;
				GillaBackpack gillaBackpack = gillaBackpack2;
				int num = 0;
				while (true)
				{
					int count = gillaBackpack.Count;
					if (num >= count)
					{
						break;
					}
					string text = gillaBackpack2.LabelAt(num);
					bool flag2 = string.IsNullOrEmpty(text);
					bool flag3 = !flag2;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						object obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v22+E4]");
						bool flag4 = (nint)0 == 0;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GameObject gameObject = PrefabOf(text);
						array = (System.__Canon[])obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v9 (System.__Canon[])+E4]");
						int num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v9 (System.__Canon[])+E4]");
						bool flag5 = (nint)0 == 0;
						object obj13 = !flag5;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (gameObject != null)
						{
							array = list._items;
							num2 = (int)obj9;
							int version = list._version + 1;
							list._version = version;
							bool flag6 = list._size < array.Length;
							object obj14 = !flag6;
							if (obj14 == null)
							{
								object obj15 = array + list._size;
								num2 = list._size + 1;
								list._size = num2;
								object obj16 = obj15 + 32;
								obj16 = text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X9_v4 (System.Int32)+20]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v13+A8]");
								array = (System.__Canon[])0;
								list.AddWithResize((System.__Canon)(object)text);
							}
						}
					}
					num++;
					bool flag7 = (object)gillaBackpack2 == null;
					object obj18 = !flag7;
					gillaBackpack = gillaBackpack2;
					if (obj18 == null)
					{
						throw new NullReferenceException();
					}
				}
			}
		}
		return (List<string>)(object)list;
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I4
		//IL_0727: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0315: Expected Obj, but got I4
		//IL_06b9: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_040d: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0472: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I4
		//IL_0556: Expected Obj, but got I4
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected Obj, but got Unknown
		//IL_0708: Expected Obj, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_05e6: Expected Obj, but got I4
		//IL_0639: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I
		//IL_0661: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A20]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+B0]");
		bool flag2 = ((List<System.__Canon>)0).Contains((System.__Canon)(object)this);
		bool flag3 = !flag2;
		object obj7 = !flag3;
		System.__Canon _Canon = (System.__Canon)(object)this;
		if (obj7 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v68+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v68+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v35+B0]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A18]");
			object obj11 = 0;
			System.__Canon[] items = list._items;
			object obj12 = obj11;
			int version = list._version + 1;
			list._version = version;
			bool flag5 = list._size < items.Length;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				object obj14 = items + list._size;
				int size = list._size + 1;
				list._size = size;
				object obj15 = obj14 + 32;
				obj15 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_Canon = (System.__Canon)(object)this;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v5+20]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v37+A8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v38+70]");
				obj6 = 0;
				list.AddWithResize((System.__Canon)(object)this);
				_Canon = (System.__Canon)(object)this;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = titleFont != null;
		bool flag8 = !flag7;
		object obj21 = 0;
		ScreenFont screenFont = null;
		if (!flag8)
		{
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			obj21 = 0;
			screenFont = screenFont2;
		}
		object obj23 = this + 248;
		obj23 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj24 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v16+E4]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X21_v5-98]");
		bool flag10 = (UnityEngine.Object)0 != null;
		bool flag11 = !flag10;
		object obj26 = 0;
		ScreenFont screenFont3 = null;
		if (!flag11)
		{
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			obj26 = 0;
			screenFont3 = screenFont4;
		}
		object obj28 = this + 256;
		text = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj29 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v23+E4]");
		bool flag12 = (nint)0 == 0;
		object obj30 = !flag12;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = screen == null;
		bool flag14 = !flag13;
		object obj31 = !flag14;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(512, 288, (TextureFormat)4, mipChain: true);
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A28]");
			object obj33 = 0;
			texture2D.name = (string)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v33+E4]");
			bool flag15 = (nint)0 == 0;
			object obj36 = !flag15;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			bool flag16 = !isPlaying;
			object obj37 = !flag16;
			object obj38 = ~obj37;
			HideFlags hideFlags = ((obj38 != null) ? ((HideFlags)52) : ((HideFlags)0));
			texture2D.hideFlags = hideFlags;
			object obj39 = this + 216;
			obj39 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj41 = this + 224;
			object obj42 = default;
			obj41 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			awake = 0f;
			Draw();
			object obj43 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v47+E4]");
			bool flag17 = (nint)0 == 0;
			object obj44 = !flag17;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A10]");
				object obj46 = 0;
				Action action = default;
				action._002Ector(this, (IntPtr)obj46);
				GillaStashSave.Changed += action;
			}
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I
		//IL_03db: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_0097: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I4
		//IL_00c4: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got Ref
		//IL_0146: Expected Obj, but got I4
		//IL_0357: Expected I, but got Obj
		//IL_037a: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got Ref
		//IL_0288: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
		List<Coming> list = (List<Coming>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v8 (System.Collections.Generic.List`1<GillaStash+Coming>)+B0]");
		bool flag2 = (nint)0 == 0;
		object obj4 = 109891584;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A60]");
			list = (List<Coming>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A10]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v8 (System.Collections.Generic.List`1<GillaStash+Coming>)+B0]");
			bool flag3 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			nint num = (nint)obj4;
			Action action = default;
			action._002Ector(this, (IntPtr)obj4);
			GillaStashSave.Changed -= action;
			bool flag4 = coming == null;
			object obj6 = 0;
			nint num2 = unchecked((nint)null);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A38]");
				obj4 = 0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)coming).GetEnumerator();
				Enumerator<, > val = default;
				while (true)
				{
					bool flag5 = val.MoveNext();
					if (!flag5)
					{
						break;
					}
					((GillaStash)flag5).LetGo(null, pop: false);
					num = 0;
				}
				List<Coming> list2 = null;
				object obj7 = 0;
				Enumerator<, > val2 = (Enumerator<, >)(ref val);
				obj6 = 0;
				list = (List<Coming>)(&val);
				object obj8 = 0;
				object obj11 = default;
				while (true)
				{
					num2 = (nint)obj4;
					val.Dispose();
					bool flag6 = obj8 == null;
					object obj9 = !flag6;
					if (obj9 == null)
					{
						bool flag7 = list2 == null;
						object obj10 = !flag7;
						OutOfMemoryException ex = (OutOfMemoryException)(&val);
						list = list2;
						if (obj10 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num2)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list2 = (List<Coming>)1;
						list = (List<Coming>)1;
						obj8 = obj7;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj8 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj7 = obj11;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EAF0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				list = coming;
				if (coming != null)
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
		}
		throw new NullReferenceException();
	}

	private void OnChanged()
	{
		dirty = true;
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0918: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_037a: Expected Obj, but got I4
		//IL_0936: Expected Obj, but got I
		//IL_0950: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got I4
		//IL_03a5: Expected I4, but got I8
		//IL_03bf: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I
		//IL_0448: Expected Obj, but got I4
		//IL_04c7: Expected Obj, but got I4
		//IL_0833: Expected VT, but got I4
		//IL_0833: Expected VT, but got I4
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		//IL_050e: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I
		//IL_0559: Expected Obj, but got I4
		//IL_08cd: Expected VT, but got I4
		//IL_05d8: Expected Obj, but got I4
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_0605: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_06dc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (screen == null)
		{
			return;
		}
		object obj7 = this + 80;
		object obj8 = obj7;
		UnityEngine.Object obj10;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v6+18]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj10 = null;
			if (obj9 != null)
			{
				goto IL_030b;
			}
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v59+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A68]");
		object obj13 = 0;
		obj10 = (UnityEngine.Object)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v62+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_030b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v62+18]");
			object obj15 = ~(nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v62+18]");
			object obj16 = 0 & obj15;
			object obj17 = 0;
			while (true)
			{
				object obj18 = obj14 + obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X11_v5+20]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X11_v5+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X11_v6+28]");
				obj10 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X11_v6+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X1_v5 (UnityEngine.Object)+18]");
					bool flag5 = (nint)0 == 0;
					object obj20 = !flag5;
					if (obj20 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X11_v6+28]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						goto IL_030b;
					}
				}
				obj17++;
				if (obj16 != obj17)
				{
					continue;
				}
				goto IL_030b;
			}
		}
		goto IL_08d9;
		IL_0926:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A70]");
		object obj22 = 0;
		GameObject gameObject = default;
		gameObject._002Ector((string)obj22);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			tileRoot = transform;
			object obj23 = this + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform parent = base.transform;
			if ((object)tileRoot != null)
			{
				tileRoot.SetParent(parent, worldPositionStays: false);
				if ((object)screen != null)
				{
					Transform transform2 = screen.transform;
					if ((object)transform2 != null)
					{
						Vector3 position = transform2.position;
						if ((object)screen != null)
						{
							Transform transform3 = screen.transform;
							if ((object)transform3 != null)
							{
								Quaternion rotation = transform3.rotation;
								if ((object)tileRoot != null)
								{
									tileRoot.SetPositionAndRotation((Vector3)0, (Quaternion)0);
									Transform transform4 = base.transform;
									if ((object)transform4 != null)
									{
										Vector3 lossyScale = transform4.lossyScale;
										if ((object)tileRoot != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
											tileRoot.localScale = (Vector3)0;
											Draw();
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
		goto IL_08d9;
		IL_08e7:
		throw new IndexOutOfRangeException();
		IL_08d9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_08e7;
		IL_030b:
		object obj24 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = body != null;
		bool flag8 = !flag7;
		object obj26 = 0;
		int num = 0;
		if (!flag8)
		{
			int num2 = (int)(lampSlot & 0x80000000L);
			bool flag9 = num2 == 0;
			object obj27 = !flag9;
			obj26 = 0;
			num = 0;
			if (obj27 == null)
			{
				if ((object)body != null)
				{
					Material[] sharedMaterials = body.sharedMaterials;
					if (sharedMaterials != null)
					{
						bool flag10 = lampSlot >= sharedMaterials.Length;
						obj26 = 0;
						num = 0;
						if (flag10)
						{
							goto IL_0926;
						}
						if ((object)body != null)
						{
							Material[] sharedMaterials2 = body.sharedMaterials;
							if (sharedMaterials2 != null)
							{
								bool flag11 = lampSlot < sharedMaterials2.Length;
								object obj28 = !flag11;
								if (obj28 != null)
								{
									goto IL_08e7;
								}
								object obj29 = obj4;
								object obj30 = sharedMaterials2 + lampSlot;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v21+E4]");
								bool flag12 = (nint)0 == 0;
								object obj31 = !flag12;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X9_v6+20]");
								bool flag13 = (UnityEngine.Object)0 != null;
								bool flag14 = !flag13;
								obj26 = 0;
								num = 0;
								if (flag14)
								{
									goto IL_0926;
								}
								if ((object)body != null)
								{
									Material[] sharedMaterials3 = body.sharedMaterials;
									if (sharedMaterials3 != null)
									{
										bool flag15 = lampSlot < sharedMaterials3.Length;
										object obj32 = !flag15;
										if (obj32 != null)
										{
											goto IL_08e7;
										}
										object obj33 = sharedMaterials3 + lampSlot;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
										object obj34 = 0;
										object obj35 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v23+E4]");
										bool flag16 = (nint)0 == 0;
										object obj36 = !flag16;
										if (obj36 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X9_v8+20]");
										if ((nint)0 != 0)
										{
											object obj37 = obj34;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v24+A0]");
											object obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v25+54]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X9_v8+20]");
											nint num3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v25+54]");
											Color color = ((Material)num3).GetColor(0);
											Color color2 = default;
											lampColour = color2;
											obj26 = 0;
											goto IL_0926;
										}
									}
								}
							}
						}
					}
				}
				goto IL_08d9;
			}
		}
		goto IL_0926;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_00e7: Invalid comparison between F4 and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying || px == null)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		GillaStashSave.Tick();
		Wake(deltaTime);
		Take();
		GoDown(deltaTime);
		PushOut(deltaTime);
		if (!((double)awake < 1.0))
		{
			Touch(deltaTime);
		}
		if (pressFlash > 0f)
		{
			float num = pressFlash - deltaTime;
			dirty = true;
			pressFlash = num;
		}
		if (banner != null)
		{
			float time = Time.time;
			if (!(time < bannerUntil))
			{
				object obj4 = this + 336;
				banner = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				dirty = true;
			}
		}
		int count = GillaStashSave.Count;
		if (count != shownCount)
		{
			int count2 = GillaStashSave.Count;
			shownCount = count2;
			Fix();
			dirty = true;
		}
		ShowTiles(deltaTime);
		Lamps(deltaTime);
		if (~(dirty ? 1u : 0u) == 0)
		{
			Draw();
		}
	}

	private void Wake(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I4
		//IL_05f6: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I4
		//IL_06d2: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I4
		//IL_0533: Expected F8, but got I4
		//IL_0691: Expected Obj, but got I4
		//IL_03f8: Expected F8, but got I
		//IL_07e1: Invalid comparison between F8 and I4
		//IL_07f4: Expected Obj, but got F8
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Obj, but got Unknown
		//IL_0832: Expected Obj, but got I4
		//IL_042a: Expected F8, but got I4
		//IL_0614: Expected Obj, but got I
		//IL_063e: Expected Obj, but got I4
		//IL_0743: Expected Obj, but got I4
		//IL_075b: Invalid comparison between F4 and I4
		//IL_076c: Expected Obj, but got I4
		//IL_01d8: Unsupported input type for neg.
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_0227: Invalid comparison between F4 and I
		//IL_04dd: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected I4, but got Unknown
		//IL_0657: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
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
			Camera main2 = Camera.main;
			Transform transform = main2.transform;
			obj4 = null;
			obj5 = transform;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8;
		if (obj5 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (screen != null)
			{
				Vector3 position = ((Transform)obj5).position;
				Transform transform2 = screen.transform;
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj10 = 0;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v31+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Transform transform3 = screen.transform;
				float num = dt - dt;
				object obj14 = default;
				object obj13 = obj14 - obj14;
				object obj16 = default;
				object obj15 = obj16 - obj16;
				Vector3 forward = transform3.forward;
				object obj17 = obj14 * obj13;
				object obj18 = 0 - obj17;
				float num2 = num * dt;
				float num3 = (float)obj18 - num2;
				object obj19 = obj15 * obj16;
				float num4 = num3 - (float)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				if (!(num4 > 0f))
				{
					goto IL_0306;
				}
				float num5 = num * num;
				object obj20 = obj13 * obj13;
				float num6 = num5 + (float)obj20;
				object obj21 = obj15 * obj15;
				float num7 = (float)obj21 + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				if (!(num7 < wakeRange))
				{
					double num8 = (double)wakeRange + 1.0;
					bool flag7 = !((double)num7 < num8) || !wanted;
					object obj22 = !flag7;
					if (obj22 == null)
					{
						goto IL_0306;
					}
				}
				flag8 = true;
				goto IL_0665;
			}
		}
		flag8 = false;
		goto IL_0665;
		IL_07b8:
		double num10;
		float num9 = dt / (float)num10;
		double num12;
		double num11 = num12 - (double)awake;
		bool flag9 = num11 < 0.0;
		object obj23 = num11 ^ num11;
		object obj24 = num11 & obj23;
		bool flag10 = (nint)obj24 < 0;
		float num13 = 0f - num9;
		bool flag11 = flag9 == flag10;
		object obj25 = !flag11;
		object obj26 = ~obj25;
		float num14 = ((obj26 != null) ? num9 : num13);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num15 = awake + num14;
		bool flag12 = num13 < num9;
		object obj27 = !flag12;
		float num16 = num13 - num9;
		bool flag13 = num16 == 0f;
		object obj28 = !flag13;
		object obj29 = obj27 & obj28;
		object obj30 = ~obj29;
		if (obj30 == null)
		{
			num12 = num15;
		}
		bool flag14 = num12 == (double)awake;
		awake = (float)num12;
		if (!flag14)
		{
			dirty = true;
		}
		return;
		IL_0306:
		List<Going> list = going;
		bool flag15 = list._size < 0;
		bool flag16 = list._size == 0;
		int num17 = list._size ^ list._size;
		int num18 = list._size & num17;
		bool flag17 = num18 < 0;
		bool flag18 = flag15 == flag17;
		object obj31 = !flag16;
		bool flag19 = (byte)((flag18 & obj31) ? 1 : 0) != 0;
		flag8 = flag19;
		goto IL_0665;
		IL_0665:
		if (wanted != flag8)
		{
			bool flag20 = !flag8;
			object obj32 = !flag20;
			object obj33 = ~obj32;
			if (obj33 == null)
			{
				object obj34 = 168;
			}
			else
			{
				object obj34 = 176;
			}
			wanted = flag8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaStash)+v228 @ X8_v11]");
			Play((AudioClip)0, 0.5f);
			if (!flag8)
			{
				holdFill = 0f;
				num12 = 0.0;
				num10 = 0.25;
				goto IL_07b8;
			}
			List<System.__Canon> list2 = (List<System.__Canon>)(object)tiles;
			int num19 = 0;
			while (num19 < list2._size)
			{
				System.__Canon _Canon = list2.get_Item(num19);
				list2 = (List<System.__Canon>)(object)tiles;
				int num20 = num19 + 1;
				int num21 = num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
				object obj35 = (nint)num21 * (nint)0;
				bool flag21 = tiles == null;
				object obj36 = !flag21;
				num19 = num20;
				if (obj36 == null)
				{
					throw new NullReferenceException();
				}
			}
		}
		bool flag22 = !flag8;
		object obj37 = !flag22;
		object obj38 = ~obj37;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num10 = 0.0;
		}
		else
		{
			num10 = 0.25;
		}
		object obj39 = !flag22;
		object obj40 = ~obj39;
		num12 = ((obj40 != null) ? 0.0 : 1.0);
		goto IL_07b8;
	}

	private unsafe void Take()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1021: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_103f: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0118: Expected I4, but got Obj
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1086: Expected Obj, but got I4
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11df: Expected Obj, but got I
		//IL_11e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f0: Expected Ref, but got Unknown
		//IL_120a: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I4
		//IL_0f67: Expected Obj, but got I4
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Expected Obj, but got Unknown
		//IL_0e64: Expected Obj, but got I4
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I8
		//IL_0377: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected I4, but got Obj
		//IL_046c: Expected Obj, but got I4
		//IL_04b5: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I
		//IL_0560: Expected Obj, but got I4
		//IL_05a7: Expected Obj, but got I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got I4
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got I4
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got Unknown
		//IL_072c: Expected Obj, but got I
		//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Invalid comparison between Unknown and F8
		//IL_07b3: Expected Obj, but got I
		//IL_07c9: Expected I4, but got I8
		//IL_07de: Expected Obj, but got I
		//IL_075c: Expected F4, but got I
		//IL_0813: Expected Obj, but got I4
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_0881: Expected Obj, but got I
		//IL_089e: Expected Obj, but got I4
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected VT, but got Unknown
		//IL_091d: Expected Obj, but got I4
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected VT, but got Unknown
		//IL_09a9: Expected Obj, but got I4
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected VT, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected Obj, but got I4
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got I
		//IL_0aba: Expected I4, but got Obj
		//IL_0ad4: Expected Obj, but got I
		//IL_0ae6: Expected Obj, but got I
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected Obj, but got Unknown
		//IL_0b10: Expected Obj, but got I
		//IL_0b3a: Expected Obj, but got I4
		//IL_0b85: Expected Obj, but got I4
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Expected Obj, but got I
		//IL_0bd9: Expected Obj, but got I4
		//IL_0be7: Expected I4, but got Obj
		//IL_0c9b: Expected Obj, but got I
		//IL_0cb0: Expected Obj, but got I
		//IL_116b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected Obj, but got I
		//IL_0c43: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got I
		//IL_0e11: Expected F4, but got I
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Expected Obj, but got I4
		//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected Obj, but got I
		//IL_0dbb: Expected Obj, but got I4
		//IL_0df4: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = hopper == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		HashSet<System.__Canon> hashSet = (HashSet<System.__Canon>)(object)refused;
		bool flag4 = refused == null;
		bool flag5 = false;
		UnityEngine.Object obj5 = null;
		Enumerator<, > val3 = default;
		UnityEngine.Object obj17;
		object obj18 = default;
		Enumerator<, > val4 = default;
		if (!flag4)
		{
			bool flag6 = hashSet._count < 1;
			flag5 = false;
			obj5 = null;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5338]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A90]");
				object obj7 = 0;
				Predicate<System.__Canon> predicate = default;
				predicate._002Ector((object)this, (IntPtr)obj7);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5328]");
				object obj8 = 0;
				flag5 = (byte)(int)obj8 != 0;
				int num = ((HashSet<System.__Canon>)(object)refused).RemoveWhere(predicate);
				string text = null;
				obj5 = (UnityEngine.Object)(object)predicate;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v50+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v50+A0]");
			object obj12 = 0;
			if (obj12 != null)
			{
				Enumerator<, > enumerator = ((List<System.__Canon>)obj12).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5320]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AB8]");
				object obj16 = 0;
				int num2 = 0;
				Enumerator<, > val2 = default;
				Enumerator<, > val = val2;
				UnityEngine.Object obj21 = default;
				Enumerator<, > val5 = default;
				Going going = default;
				Enumerator<, > val6 = default;
				float num5 = default;
				float num6 = default;
				while (true)
				{
					bool flag8 = val3.MoveNext();
					bool flag9 = !flag8;
					obj17 = null;
					obj18 = 0;
					val4 = (Enumerator<, >)(ref val3);
					if (flag9)
					{
						break;
					}
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X0_v56+E4]");
					bool flag10 = (nint)0 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag11 = obj21 == null;
					bool flag12 = !flag11;
					object obj22 = !flag12;
					flag5 = false;
					if (obj22 != null)
					{
						continue;
					}
					if ((object)obj21 == null)
					{
						goto IL_0e52;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+40]");
					bool flag13 = (nint)0 == 0;
					object obj23 = !flag13;
					flag5 = false;
					if (obj23 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+41]");
					bool flag14 = (nint)0 == 0;
					object obj24 = !flag14;
					flag5 = false;
					if (obj24 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+3C]");
					object obj25 = 0 & 0x80000000L;
					bool flag15 = obj25 == null;
					flag5 = false;
					if (flag15)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+49]");
					bool flag16 = (nint)0 == 0;
					object obj26 = !flag16;
					flag5 = false;
					if (obj26 != null)
					{
						continue;
					}
					bool mine = ((GillaItem)obj21).Mine;
					bool flag17 = !mine;
					flag5 = false;
					if (flag17)
					{
						continue;
					}
					bool heldLastByMe = ((GillaItem)obj21).HeldLastByMe;
					bool flag18 = !heldLastByMe;
					flag5 = false;
					if (flag18)
					{
						continue;
					}
					bool flag19 = refused == null;
					obj17 = null;
					obj18 = 0;
					val4 = (Enumerator<, >)(ref val3);
					flag5 = false;
					obj5 = null;
					if (flag19)
					{
						goto IL_0e92;
					}
					flag5 = (byte)(int)obj14 != 0;
					bool flag20 = ((HashSet<System.__Canon>)(object)refused).Contains((System.__Canon)(object)obj21);
					bool flag21 = !flag20;
					object obj27 = !flag21;
					if (obj27 != null || !InHopper((GillaItem)obj21))
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
					object obj28 = 0;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X0_v69+E4]");
					bool flag22 = (nint)0 == 0;
					object obj30 = !flag22;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!Takes((GillaItem)obj21))
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
					object obj31 = 0;
					object obj32 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ X0_v73+E4]");
					bool flag23 = (nint)0 == 0;
					object obj33 = !flag23;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					List<string> list = Contents((GillaItem)obj21);
					bool flag24 = (object)list == null;
					obj17 = null;
					obj18 = 0;
					val4 = (Enumerator<, >)(ref val3);
					obj5 = obj21;
					if (flag24)
					{
						goto IL_0ea0;
					}
					int more = list._size + 1;
					if (GillaStashSave.Fits(more))
					{
						Enumerator<, > enumerator2 = ((List<System.__Canon>)(object)list).GetEnumerator();
						while (val5.MoveNext())
						{
							bool flag25 = GillaStashSave.Add(null);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+20]");
						bool flag26 = GillaStashSave.Add((string)0);
						((GillaItem)obj21).Swallow(-1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A98]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						going._002Ector();
						bool flag27 = going == null;
						obj17 = null;
						obj18 = 0;
						val = val6;
						val4 = (Enumerator<, >)(ref val3);
						flag5 = false;
						obj5 = null;
						if (flag27)
						{
							goto IL_0ebc;
						}
						object obj35 = going + 16;
						obj35 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Transform transform = ((Component)obj21).transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AB8]");
						obj16 = 0;
						bool flag28 = (object)transform == null;
						obj17 = null;
						obj18 = 0;
						val = val6;
						val4 = (Enumerator<, >)(ref val3);
						flag5 = false;
						obj5 = null;
						if (flag28)
						{
							goto IL_0eca;
						}
						Vector3 position = transform.position;
						going.from = (Vector3)val6;
						Transform transform2 = ((Component)obj21).transform;
						bool flag29 = (object)transform2 == null;
						obj17 = null;
						obj18 = 0;
						val = val6;
						val4 = (Enumerator<, >)(ref val3);
						flag5 = false;
						obj5 = null;
						if (flag29)
						{
							goto IL_0ed8;
						}
						Quaternion rotation = transform2.rotation;
						going.turn = (Quaternion)val6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						_ = 0;
						Transform transform3 = ((Component)obj21).transform;
						bool flag30 = (object)transform3 == null;
						obj17 = null;
						obj18 = 0;
						val = val6;
						val4 = (Enumerator<, >)(ref val3);
						flag5 = false;
						obj5 = null;
						if (flag30)
						{
							goto IL_0ee6;
						}
						Vector3 localScale = transform3.localScale;
						going.size = (Vector3)val6;
						Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
						float num3 = UnityEngine.Random.Range(90f, 200f);
						float num4 = num5 * num3;
						num5 = (float)val6 * num3;
						val = (Enumerator<, >)(num6 * num3);
						bool flag31 = this.going == null;
						num6 = num4;
						obj17 = null;
						obj18 = 0;
						val4 = (Enumerator<, >)(ref val3);
						flag5 = false;
						obj5 = (UnityEngine.Object)(object)going;
						if (flag31)
						{
							goto IL_0ef4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AA0]");
						object obj36 = 0;
						flag5 = (byte)(int)obj36 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D100");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+20]");
						obj5 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+20]");
						selected = (string)0;
						object obj37 = this + 272;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
						object obj38 = 0;
						object obj39 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ X0_v116+E4]");
						bool flag32 = (nint)0 == 0;
						object obj40 = !flag32;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						List<string> list2 = Kinds();
						bool flag33 = (object)list2 == null;
						num6 = num4;
						obj17 = null;
						obj18 = 0;
						val4 = (Enumerator<, >)(ref val3);
						if (!flag33)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+20]");
							int num7 = ((List<System.__Canon>)(object)list2).IndexOf((System.__Canon)0);
							int num8 = ~num7;
							int num9 = num7 & num8;
							object obj41 = num9 * 715827883;
							int num10 = obj41 >> 32;
							page = num10;
							string text4;
							if (list._size > 0)
							{
								string text2 = num2.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AC8]");
								object obj42 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AB0]");
								object obj43 = 0;
								string text = (string)obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+20]");
								string text3 = (string)0 + (string)obj42 + text2 + (string)obj43;
								num2 = list._size;
								text4 = text3;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AD0]");
								object obj44 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ stack_-F0_v16 (UnityEngine.Object)+20]");
								string text5 = (string)0 + (string)obj44;
								text4 = text5;
							}
							Say(text4, bad: false);
							float time = Time.time;
							num5 = clunkedAt;
							float num11 = time - clunkedAt;
							bool flag34 = (double)num11 < 0.25;
							val = (Enumerator<, >)num11;
							if (!flag34)
							{
								float time2 = Time.time;
								AudioClip[] array = putInSounds;
								clunkedAt = time2;
								if (putInSounds != null && array.Length != 0)
								{
									bool flag35 = (object)hopper == null;
									num6 = num4;
									obj17 = null;
									obj18 = 0;
									val = (Enumerator<, >)time2;
									val4 = (Enumerator<, >)(ref val3);
									flag5 = false;
									obj5 = (UnityEngine.Object)(object)text4;
									if (flag35)
									{
										goto IL_0f10;
									}
									Vector3 position2 = hopper.position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
									object obj45 = 0;
									object obj46 = obj45;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X0_v128+E4]");
									bool flag36 = (nint)0 == 0;
									object obj47 = !flag36;
									if (obj47 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Sfx.Play(putInSounds, (Vector3)0, time2, num5, num4);
								}
								AudioClip clip = storedSound;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
								Play(clip, 0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
								val = (Enumerator<, >)0;
							}
							flash = 1f;
							dirty = true;
							num6 = num4;
							flag5 = false;
							continue;
						}
						goto IL_0f02;
					}
					bool flag37 = refused == null;
					obj17 = null;
					obj18 = 0;
					val4 = (Enumerator<, >)(ref val3);
					obj5 = null;
					if (!flag37)
					{
						bool flag38 = ((HashSet<System.__Canon>)(object)refused).Add((System.__Canon)(object)obj21);
						bool flag39 = list._size < 0;
						bool flag40 = list._size == 0;
						int num12 = list._size ^ list._size;
						int num13 = list._size & num12;
						bool flag41 = num13 < 0;
						bool flag42 = flag39 == flag41;
						object obj48 = !flag40;
						object obj49 = flag42 & obj48;
						object obj50 = ~obj49;
						object s;
						if (obj50 == null)
						{
							s = obj16;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AC0]");
							s = 0;
						}
						Say((string)s, bad: true);
						float time3 = Time.time;
						num5 = deniedAt;
						val = (Enumerator<, >)(time3 - deniedAt);
						bool flag43 = (double)val < 0.5;
						flag5 = true;
						if (!flag43)
						{
							float time4 = Time.time;
							deniedAt = time4;
							AudioClip clip2 = denySound;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							Play(clip2, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							val = (Enumerator<, >)0;
							flag5 = true;
						}
						continue;
					}
					goto IL_0eae;
				}
				goto IL_0f40;
			}
		}
		goto IL_0e7f;
		IL_0eca:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ed8;
		IL_0e7f:
		NullReferenceException ex2 = new NullReferenceException();
		obj17 = null;
		goto IL_0e92;
		IL_11ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0ed8:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0ee6;
		IL_0ebc:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0eca;
		IL_0f02:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0f10;
		IL_0f40:
		object obj51 = obj18;
		goto IL_11cf;
		IL_11cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
		object obj52 = 0;
		obj5 = (UnityEngine.Object)obj52;
		((Enumerator<, >*)val4)->Dispose();
		bool flag44 = obj51 == null;
		object obj53 = !flag44;
		if (obj53 == null)
		{
			bool flag45 = (object)obj17 == null;
			object obj54 = !flag45;
			OutOfMemoryException ex6 = (OutOfMemoryException)val4;
			if (obj54 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex6 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex8 = default;
		NullReferenceException ex7 = ex8;
		goto IL_11ac;
		IL_0e92:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0ea0;
		IL_0f10:
		NullReferenceException ex10 = new NullReferenceException();
		if ((nint)obj5 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj17 = (UnityEngine.Object)1;
			goto IL_0f40;
		}
		bool flag46 = (nint)obj5 != 1;
		ex7 = ex10;
		if (flag46)
		{
			goto IL_11ac;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		object obj55 = default;
		obj51 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		goto IL_11cf;
		IL_0ee6:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0ef4;
		IL_0eae:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_0ebc;
		IL_0ea0:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_0eae;
		IL_0ef4:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_0f02;
		IL_0e52:
		NullReferenceException ex15 = new NullReferenceException();
		obj18 = 0;
		val4 = (Enumerator<, >)(ref val3);
		flag5 = false;
		obj5 = null;
		goto IL_0e7f;
	}

	private bool InHopper(GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05b4: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_058a: Expected I4, but got Obj
		//IL_020c: Expected VT, but got I4
		//IL_029d: Expected Obj, but got I8
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02b9: Expected F8, but got I4
		//IL_02c2: Expected F8, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_02d4: Expected F8, but got I4
		//IL_02dd: Expected Obj, but got I4
		//IL_02e6: Expected F8, but got I4
		//IL_02ef: Expected F8, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_0301: Expected VT, but got I4
		//IL_08bb: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I
		//IL_037b: Expected VT, but got I4
		//IL_05d1: Expected Obj, but got I4
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I4
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I
		//IL_03db: Expected VT, but got I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0507: Expected Obj, but got I
		//IL_08da: Expected Obj, but got I4
		//IL_08e3: Expected VT, but got I4
		//IL_0425: Expected Obj, but got I
		//IL_061e: Invalid comparison between F8 and I4
		//IL_062d: Invalid comparison between F8 and I4
		//IL_0640: Expected Obj, but got F8
		//IL_064d: Expected Obj, but got F8
		//IL_0682: Expected Obj, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_07a1: Invalid comparison between F8 and I4
		//IL_07b0: Invalid comparison between F8 and I4
		//IL_07c3: Expected Obj, but got F8
		//IL_07d0: Expected Obj, but got F8
		//IL_0805: Expected Obj, but got I4
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
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
		bool flag2 = hopper == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj13;
		Vector3 vector;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = item == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				if ((object)item != null)
				{
					Transform transform = item.transform;
					if ((object)transform != null)
					{
						Vector3 position = transform.position;
						if ((object)hopper != null)
						{
							Vector3 position2 = hopper.position;
							object obj9 = default;
							object obj8 = obj9 - obj9;
							double num2 = default;
							double num = num2 - num2;
							double num4 = default;
							double num3 = num4 - num4;
							object obj10 = obj8 * obj8;
							double num5 = num * num;
							double num6 = (double)obj10 + num5;
							double num7 = num3 * num3;
							double num8 = num7 + num6;
							if (!(num8 > 2.25))
							{
								if (InSpace((Vector3)0))
								{
									return true;
								}
								Collider[] array = item.Colliders__BackingField;
								if (item.Colliders__BackingField != null && array.Length >= 1)
								{
									object obj11 = array.Length & 0xFFFFFFFFL;
									object obj12 = item.Colliders__BackingField + 32;
									double num9 = 0.0;
									double num10 = 0.0;
									obj13 = 0;
									double num11 = 0.0;
									object obj14 = 0;
									double num12 = 0.0;
									double num13 = 0.0;
									object obj15 = 0;
									vector = (Vector3)0;
									double num17 = default;
									double num18 = default;
									double num21 = default;
									double num22 = default;
									object obj26 = default;
									while (true)
									{
										bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
										object obj16 = !flag7;
										if (obj16 != null)
										{
											break;
										}
										object obj17 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v26+E4]");
										bool flag8 = (nint)0 == 0;
										object obj18 = !flag8;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X24_v6+v380 @ X23_v7*8]");
										bool flag9 = (UnityEngine.Object)0 != null;
										bool flag10 = !flag9;
										vector = (Vector3)0;
										if (!flag10)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X24_v6+v380 @ X23_v7*8]");
											if ((nint)0 == 0)
											{
												goto IL_056e;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X24_v6+v380 @ X23_v7*8]");
											bool flag11 = ((Collider)0).enabled;
											bool flag12 = !flag11;
											vector = (Vector3)0;
											if (!flag12)
											{
												object obj19 = obj13 & 1;
												if (obj19 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X24_v6+v380 @ X23_v7*8]");
													Bounds bounds = ((Collider)0).bounds;
													double num14 = num13 - num11;
													double num15 = num11 + num13;
													double num16 = num17 - num18;
													double num19 = num17 + num18;
													double num20 = num21 + num22;
													double num23 = num9 - num10;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													if (!(num14 < num16))
													{
														num14 = num16;
													}
													double num24 = num15 - num16;
													bool flag13 = num24 < 0.0;
													bool flag14 = num24 == 0.0;
													object obj20 = num15 ^ num16;
													object obj21 = num15 ^ num24;
													object obj22 = obj20 & obj21;
													bool flag15 = (nint)obj22 < 0;
													bool flag16 = flag13 == flag15;
													object obj23 = !flag14;
													object obj24 = flag16 & obj23;
													object obj25 = ~obj24;
													if (obj25 == null)
													{
														num16 = num15;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
													double num25 = num16 - num14;
													double num26 = (double)obj26 - num23;
													double num27 = num25 * 0.5;
													double num28 = num26 * 63.0;
													double num29 = num14 + num27;
													double num30 = num23 + num28;
													num2 = num29 - num27;
													double num31 = num27 + num29;
													double num32 = num30 - num28;
													double num33 = num28 + num30;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													if (!(num2 < num19))
													{
														num2 = num19;
													}
													double num34 = num31 - num19;
													bool flag17 = num34 < 0.0;
													bool flag18 = num34 == 0.0;
													object obj27 = num31 ^ num19;
													object obj28 = num31 ^ num34;
													object obj29 = obj27 & obj28;
													bool flag19 = (nint)obj29 < 0;
													bool flag20 = flag17 == flag19;
													object obj30 = !flag18;
													object obj31 = flag20 & obj30;
													object obj32 = ~obj31;
													if (obj32 == null)
													{
														num19 = num31;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
													double num35 = num19 - num2;
													double num36 = num28 - num29;
													num11 = num35 * 0.5;
													num10 = num36 * 63.0;
													num13 = num2 + num11;
													num12 = num29 + num10;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X24_v6+v380 @ X23_v7*8]");
													Bounds bounds2 = ((Collider)0).bounds;
													num10 = num22;
													num11 = num18;
													num12 = num21;
													num13 = num17;
												}
												num9 = num12;
												obj13 = 1;
												vector = (Vector3)0;
											}
										}
										obj11 = array.Length;
										obj14++;
										bool flag21 = (nint)obj14 < array.Length;
										obj15 = 0;
										if (flag21)
										{
											continue;
										}
										goto IL_0530;
									}
									goto IL_057c;
								}
							}
							goto IL_01f3;
						}
					}
				}
				goto IL_056e;
			}
		}
		goto IL_01f3;
		IL_056e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_057c;
		IL_057c:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_01f3:
		return false;
		IL_0530:
		object obj33 = obj13 & 1;
		if (obj33 != null)
		{
			return InSpace(vector);
		}
		goto IL_01f3;
	}

	private bool InSpace(Vector3 p)
	{
		//IL_0253: Expected I4, but got Obj
		//IL_002f: Expected VT, but got I4
		//IL_007b: Expected Obj, but got I
		//IL_0260: Invalid comparison between Obj and F8
		//IL_0271: Expected Obj, but got I4
		//IL_028e: Invalid comparison between F8 and I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_00cb: Invalid comparison between Obj and F8
		//IL_00dc: Expected Obj, but got I4
		//IL_00f9: Invalid comparison between F8 and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_014c: Invalid comparison between Obj and F8
		//IL_015d: Expected Obj, but got I4
		//IL_0175: Invalid comparison between F8 and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01ee: Invalid comparison between F8 and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		if ((object)hopper != null)
		{
			Vector3 vector = hopper.InverseTransformPoint((Vector3)0);
			if ((object)hopper != null)
			{
				Vector3 lossyScale = hopper.lossyScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				object obj2 = default;
				if ((nint)obj2 >= 0)
				{
					obj = obj2;
				}
				object obj3 = default;
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5);
				object obj4 = !flag;
				double num = (double)obj3 - 0.5;
				bool flag2 = num == 0.0;
				object obj5 = ~obj4;
				object obj6 = obj5 | flag2;
				object obj7 = ~obj6;
				object obj9;
				bool flag4;
				if (obj7 == null)
				{
					object obj8 = default;
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5);
					obj9 = !flag3;
					double num2 = (double)obj8 - 0.5;
					flag4 = num2 == 0.0;
				}
				else
				{
					flag4 = false;
					obj9 = 1;
				}
				object obj10 = !flag4;
				object obj11 = obj9 & obj10;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					object obj12 = 0 / obj;
					double num3 = (double)obj12 + 0.5;
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3);
					object obj13 = !flag5;
					double num4 = (double)obj2 - num3;
					bool flag6 = num4 == 0.0;
					object obj14 = ~obj13;
					object obj15 = obj14 | flag6;
					if (obj15 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
						object obj16 = 0 / obj;
						double num5 = (double)obj16 + -0.5;
						double num6 = (double)obj2 - num5;
						bool flag7 = num6 < 0.0;
						object obj17 = obj2 ^ num5;
						object obj18 = obj2 ^ num6;
						object obj19 = obj17 & obj18;
						bool flag8 = (nint)obj19 < 0;
						return flag7 == flag8;
					}
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void GoDown(float dt)
	{
		//IL_0630: Expected Obj, but got I4
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_066f: Expected F8, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_07d4: Expected Obj, but got I4
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_0839: Invalid comparison between F8 and I4
		//IL_084c: Expected Obj, but got F8
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_088b: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_08bb: Expected Obj, but got I4
		//IL_08d3: Invalid comparison between F8 and I4
		//IL_08f5: Expected Obj, but got I4
		//IL_0157: Invalid comparison between F4 and I4
		//IL_016b: Expected F4, but got I4
		//IL_06f0: Expected Obj, but got I4
		//IL_0196: Invalid comparison between F4 and I4
		//IL_01a5: Invalid comparison between F4 and I4
		//IL_01bd: Expected Obj, but got F8
		//IL_01ca: Expected Obj, but got F4
		//IL_01ff: Expected Obj, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0349: Expected Obj, but got I
		//IL_0356: Invalid comparison between F4 and I4
		//IL_0397: Expected VT, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_047e: Expected VT, but got I4
		//IL_04aa: Invalid comparison between F4 and I4
		//IL_04b9: Invalid comparison between F4 and I4
		//IL_04d1: Expected Obj, but got F8
		//IL_04de: Expected Obj, but got F4
		//IL_0513: Expected Obj, but got I4
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0772: Expected VT, but got I4
		//IL_0782: Expected F4, but got I
		//IL_0797: Invalid comparison between I and F8
		//IL_07a5: Expected VT, but got F4
		//IL_055a: Expected Obj, but got I
		//IL_0562: Expected VT, but got F4
		List<Going> list = going;
		int num = list._size;
		bool flag = list._size < 1;
		float num2 = dt;
		if (!flag)
		{
			float num3 = dt + dt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AE0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num4 = num3;
			float num5 = dt;
			object obj15 = default;
			Vector3 euler = default;
			float num23 = default;
			do
			{
				num--;
				System.__Canon _Canon = ((List<System.__Canon>)(object)going).get_Item(num);
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+10]");
				bool flag3 = (UnityEngine.Object)0 == null;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					float num6 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+18]");
					float num7 = num6 + 0f;
					bool flag5 = num7 < 0f;
					float num8 = 0f;
					if (!flag5)
					{
						float num9 = num7 - 1f;
						bool flag6 = num9 < 0f;
						bool flag7 = num9 == 0f;
						object obj6 = (double)num7 ^ 1.0;
						object obj7 = num7 ^ num9;
						object obj8 = obj6 & obj7;
						bool flag8 = (nint)obj8 < 0;
						bool flag9 = flag6 == flag8;
						object obj9 = !flag7;
						object obj10 = flag9 & obj9;
						object obj11 = ~obj10;
						num8 = ((obj11 != null) ? num7 : 1f);
					}
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v15+E4]");
					bool flag10 = (nint)0 == 0;
					object obj13 = !flag10;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (chute != null)
					{
						Vector3 position = chute.position;
					}
					else
					{
						Vector3 position2 = hopper.position;
					}
					float num10 = num8 + num8;
					double num11 = (double)num8 * 3.0;
					float num12 = num8 * num10;
					double num13 = (double)num8 * num11;
					float num14 = num8 * num12;
					double num15 = num13 - (double)num14;
					double num16 = 1.0 - num15;
					double num17 = num16 * 0.0;
					num5 = (float)num15 + (float)num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+10]");
					Transform transform = ((Component)0).transform;
					if (num5 < 0f || (double)num5 > 1.0)
					{
					}
					transform.position = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+34]");
					object obj14 = 0 * obj15;
					float num18 = (float)obj14 * num3;
					Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					float num19 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+40]");
					float num20 = num19 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
					float num21 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+1C]");
					float num22 = num21 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
					num23 += num22;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					transform.rotation = (Quaternion)0;
					float num24 = num5 * num5;
					float num25 = num24 - 1f;
					bool flag11 = num25 < 0f;
					bool flag12 = num25 == 0f;
					object obj16 = (double)num24 ^ 1.0;
					object obj17 = num24 ^ num25;
					object obj18 = obj16 & obj17;
					bool flag13 = (nint)obj18 < 0;
					bool flag14 = flag11 == flag13;
					object obj19 = !flag12;
					object obj20 = flag14 & obj19;
					object obj21 = ~obj20;
					if (obj21 == null)
					{
						num24 = 1f;
					}
					float num26 = num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E4]");
					float num27 = num26 * 0f;
					float num28 = num27 + 1f;
					float num29 = num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+2C]");
					float num30 = num29 * 0f;
					float num31 = num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+30]");
					float num32 = num31 * 0f;
					transform.localScale = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+18]");
					num4 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+18]");
					bool flag15 = 0.0 < 1.0;
					euler = (Vector3)num18;
					float num33 = num3;
					if (flag15)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7 (System.__Canon)+10]");
					((GillaItem)0).Recycle();
					euler = (Vector3)num18;
					num33 = num3;
				}
				((List<System.__Canon>)(object)going).RemoveAt(num);
			}
			while (num > 0);
			list = going;
			num2 = dt;
		}
		bool flag16 = list._size < 0;
		bool flag17 = list._size == 0;
		int num34 = list._size ^ list._size;
		int num35 = list._size & num34;
		bool flag18 = num35 < 0;
		bool flag19 = flag16 == flag18;
		object obj22 = !flag17;
		object obj23 = flag19 & obj22;
		object obj24 = ~obj23;
		double num36 = ((obj24 != null) ? 0.0 : 1.0);
		bool flag20 = flag16 == flag18;
		object obj25 = !flag17;
		object obj26 = flag20 & obj25;
		object obj27 = ~obj26;
		double num37 = ((obj27 != null) ? 1.5 : 4.0);
		double num38 = num36 - (double)work;
		double num39 = num37 * (double)num2;
		double num40 = num37 * (double)num2;
		double num41 = 0.0 - num40;
		bool flag21 = num38 < 0.0;
		object obj28 = num38 ^ num38;
		object obj29 = num38 & obj28;
		bool flag22 = (nint)obj29 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag23 = flag21 == flag22;
		object obj30 = !flag23;
		object obj31 = ~obj30;
		if (obj31 != null)
		{
			num41 = num39;
		}
		bool flag24 = num38 < num39;
		object obj32 = !flag24;
		double num42 = num38 - num39;
		bool flag25 = num42 == 0.0;
		double num43 = (double)work + num41;
		object obj33 = !flag25;
		object obj34 = obj32 & obj33;
		object obj35 = ~obj34;
		if (obj35 == null)
		{
			num36 = num43;
		}
		work = (float)num36;
	}

	public bool Eject()
	{
		//IL_0010: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0345: Expected I4, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got I
		//IL_03a0: Expected F4, but got I
		//IL_021a: Expected Obj, but got I
		//IL_0257: Expected F4, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_0297: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass129_0 obj2 = default;
		obj2._002Ector();
		float time = Time.time;
		if (!(time < nextEject))
		{
			bool flag = string.IsNullOrEmpty(selected);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				float time2 = Time.time;
				float num = time2 + ejectEvery;
				nextEject = num;
				if (obj2 == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				object obj4 = obj2 + 16;
				obj4 = selected;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int num2 = GillaStashSave.CountOf((string)obj4);
				if (num2 > 0)
				{
					AudioClip audioClip;
					if (TrayFull())
					{
						object obj5 = this + 336;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B58]");
						object obj6 = 0;
						banner = (string)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bannerBad = true;
						float time3 = Time.time;
						audioClip = denySound;
						dirty = true;
						float num3 = time3 + 2.5f;
						bannerUntil = num3;
					}
					else
					{
						if (!GillaStashSave.Take((string)obj4))
						{
							goto IL_02f9;
						}
						if (Spawn((string)obj4, out var why))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B50]");
							object obj7 = 0;
							string s = (string)obj4 + (string)obj7;
							Say(s, bad: false);
							AudioClip clip = ejectSound;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
							Play(clip, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B40]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B48]");
							object obj9 = 0;
							Func<System.__Canon, bool> func = default;
							func._002Ector((object)obj2, (IntPtr)obj9);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B38]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CBB88");
							object obj11 = default;
							if (obj11 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v34+30]");
								double num4 = 0.0 + 12.0;
							}
							flash = 1f;
							Fix();
							return true;
						}
						bool flag3 = GillaStashSave.Add((string)obj4);
						Say(why, bad: true);
						audioClip = denySound;
					}
					AudioClip clip2 = audioClip;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					Play(clip2, 0f);
				}
				else
				{
					Fix();
				}
			}
		}
		goto IL_02f9;
		IL_02f9:
		return false;
	}

	private unsafe bool TrayFull()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bfa: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got I4
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected I4, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		//IL_013c: Expected F8, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_0c8c: Expected Obj, but got I
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got I
		//IL_0262: Expected F8, but got I
		//IL_0289: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_093f: Expected Obj, but got I4
		//IL_0948: Expected Obj, but got I4
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got I4
		//IL_096a: Expected Obj, but got I4
		//IL_0d5e: Expected Obj, but got I
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6f: Expected Ref, but got Unknown
		//IL_0d89: Expected Obj, but got I4
		//IL_0989: Expected Obj, but got I4
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected Obj, but got Unknown
		//IL_0ab7: Expected Obj, but got I4
		//IL_0ac0: Expected Obj, but got I4
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I4
		//IL_0a02: Expected Obj, but got I4
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected I4, but got Unknown
		//IL_0a70: Expected Obj, but got I4
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		//IL_09de: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I4
		//IL_0b5f: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_0bc6: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I8
		//IL_04d9: Expected Obj, but got I
		//IL_04eb: Expected I, but got Obj
		//IL_04fc: Expected I, but got Obj
		//IL_051b: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got I4
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected I, but got Obj
		//IL_059a: Expected Obj, but got I4
		//IL_05a3: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I4
		//IL_05f6: Expected Obj, but got I4
		//IL_05ff: Expected Obj, but got I4
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got I4
		//IL_0665: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I4
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got I4
		//IL_06d3: Expected Obj, but got I4
		//IL_06dc: Expected Obj, but got I4
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got I4
		//IL_07e5: Invalid comparison between F8 and I4
		//IL_07f7: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I4
		//IL_08c0: Expected Obj, but got I4
		//IL_0907: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4;
		if (tray == null)
		{
			obj4 = 0;
			goto IL_0c08;
		}
		Transform transform = base.transform;
		bool flag2 = (object)transform == null;
		object obj6 = default;
		object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		double num2 = default;
		double num = num2;
		double num4 = default;
		double num3 = num4;
		double num6 = default;
		double num5 = num6;
		nint num7 = 0;
		UnityEngine.Object obj7 = null;
		int num8;
		object obj35;
		if (!flag2)
		{
			Vector3 lossyScale = transform.lossyScale;
			Vector3 vector = Ahead();
			List<Coming> list = coming;
			bool flag3 = coming == null;
			obj5 = obj6;
			val = (Enumerator<, >)0;
			num = num2;
			num3 = num4;
			num5 = num6;
			num7 = 0;
			obj7 = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
				object obj9 = 0;
				num8 = list._size;
				object obj10 = obj8;
				object obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X9_v12+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X9_v3+20]");
				double num9 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X0_v44+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X0_v44+A0]");
				object obj14 = 0;
				bool flag5 = obj14 == null;
				obj5 = obj6;
				val = (Enumerator<, >)0;
				num = num2;
				num3 = num4;
				num5 = num6;
				num7 = 0;
				obj7 = null;
				if (!flag5)
				{
					double num10 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X9_v3+1C]");
					double num11 = num10 * 0.0;
					double num12 = num4 * num9;
					num = num6 * num9;
					double num13 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X9_v3+18]");
					double num14 = num13 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					double num15 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X9_v3+18]");
					double num16 = num15 * 0.0;
					double num17 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X9_v3+1C]");
					double num18 = num17 * 0.0;
					double num19 = num11 - num12;
					double num20 = num - num14;
					double num21 = num16 - num18;
					Enumerator<, > enumerator = ((List<System.__Canon>)obj14).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					num3 = 0.0;
					double num22 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					double num23 = num22 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B78]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B70]");
					object obj17 = 0;
					num9 = num6 * 0.75;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B60]");
					object obj18 = 0;
					num5 = 0.75;
					obj12 = 17276928;
					num7 = 0;
					_003C_003Ec__DisplayClass130_0 obj19 = default;
					Predicate<System.__Canon> predicate = default;
					Enumerator<, > val2 = default;
					int num24 = default;
					bool result = default;
					object obj39 = default;
					while (true)
					{
						object obj32;
						object obj31;
						Enumerator<, > val3;
						if (val.MoveNext())
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							obj19._002Ector();
							if (obj19 != null)
							{
								object obj20 = obj19 + 16;
								obj20 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj21 = obj;
								UnityEngine.Object obj22 = (UnityEngine.Object)obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v57+E4]");
								bool flag6 = (nint)0 == 0;
								object obj23 = !flag6;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag7 = obj22 == null;
								bool flag8 = !flag7;
								object obj24 = !flag8;
								num7 = 0;
								if (obj24 != null)
								{
									continue;
								}
								object obj25 = obj20;
								bool flag9 = obj20 == null;
								num7 = 0;
								obj7 = null;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v31+41]");
									obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v31+41]");
									bool flag10 = (nint)0 == 0;
									object obj26 = !flag10;
									num7 = 0;
									if (obj26 != null)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v31+40]");
									obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v31+40]");
									bool flag11 = (nint)0 == 0;
									object obj27 = !flag11;
									num7 = 0;
									if (obj27 != null)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v31+3C]");
									object obj28 = 0 & 0x80000000L;
									bool flag12 = obj28 == null;
									num7 = 0;
									if (flag12)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B68]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									num7 = (nint)obj17;
									predicate._002Ector((object)obj19, (IntPtr)obj17);
									bool flag13 = coming == null;
									object obj30 = 0;
									num24 = num8;
									obj22 = (UnityEngine.Object)(object)coming;
									obj5 = 0;
									obj31 = 0;
									val = val2;
									val3 = (Enumerator<, >)(ref val);
									obj32 = obj19;
									if (flag13)
									{
										goto IL_0b05;
									}
									num7 = (nint)obj18;
									bool flag14 = ((List<System.__Canon>)(object)coming).Exists(predicate);
									bool flag15 = !flag14;
									object obj33 = !flag15;
									obj30 = 0;
									num24 = num8;
									obj22 = (UnityEngine.Object)(object)coming;
									if (obj33 != null)
									{
										continue;
									}
									bool flag16 = obj20 == null;
									obj30 = 0;
									num24 = num8;
									obj22 = (UnityEngine.Object)(object)coming;
									obj5 = 0;
									obj31 = 0;
									val = val2;
									val3 = (Enumerator<, >)(ref val);
									obj32 = predicate;
									if (!flag16)
									{
										Transform transform2 = ((Component)obj20).transform;
										bool flag17 = (object)transform2 == null;
										obj30 = 0;
										num24 = num8;
										obj22 = (UnityEngine.Object)(object)coming;
										obj5 = 0;
										obj31 = 0;
										val = val2;
										val3 = (Enumerator<, >)(ref val);
										obj32 = null;
										if (!flag17)
										{
											Vector3 position = transform2.position;
											bool flag18 = (object)tray == null;
											obj30 = 0;
											num24 = num8;
											obj22 = (UnityEngine.Object)(object)coming;
											obj5 = 0;
											obj31 = 0;
											val = val2;
											val3 = (Enumerator<, >)(ref val);
											obj32 = null;
											if (!flag18)
											{
												Vector3 position2 = tray.position;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
												bool flag19 = !(num14 < 1.0);
												obj30 = 0;
												num24 = num8;
												obj22 = (UnityEngine.Object)(object)coming;
												num16 = 1.0;
												if (flag19)
												{
													continue;
												}
												num5 -= num5;
												num3 -= num3;
												num -= num;
												double num25 = num6 * num5;
												double num26 = num4 * num3;
												double num27 = num25 + num26;
												num16 = num2 * num;
												num14 = num16 + num27;
												bool flag20 = !(num14 > 0.0);
												obj30 = 0;
												num24 = num8;
												obj22 = (UnityEngine.Object)(object)coming;
												if (flag20)
												{
													continue;
												}
												bool flag21 = !(num14 < num23);
												obj30 = 0;
												num24 = num8;
												obj22 = (UnityEngine.Object)(object)coming;
												if (!flag21)
												{
													double num28 = num19 * num5;
													num3 = num20 * num3;
													num = num21 * num;
													double num29 = num28 + num3;
													num5 = num + num29;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
													bool flag22 = !(num5 < num9);
													obj30 = 0;
													num24 = num8;
													obj22 = (UnityEngine.Object)(object)coming;
													num16 = num19;
													num14 = num21;
													if (!flag22)
													{
														int num30 = num8 + 1;
														obj30 = 0;
														num24 = num8;
														obj22 = (UnityEngine.Object)(object)coming;
														num16 = num19;
														num14 = num21;
														num8 = num30;
													}
												}
												continue;
											}
											goto IL_0b13;
										}
										goto IL_0b21;
									}
									goto IL_0b2f;
								}
							}
							else
							{
								NullReferenceException ex = new NullReferenceException();
								obj7 = null;
							}
							NullReferenceException ex2 = new NullReferenceException();
							num24 = num8;
							obj5 = 0;
							obj31 = 0;
							val = val2;
							val3 = (Enumerator<, >)(ref val);
							break;
						}
						obj5 = 0;
						obj31 = 0;
						val = val2;
						val3 = (Enumerator<, >)(ref val);
						object obj34 = 0;
						obj35 = 5;
						goto IL_0d4e;
						IL_0d4e:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
						object obj36 = 0;
						obj7 = (UnityEngine.Object)obj36;
						((Enumerator<, >*)val3)->Dispose();
						bool flag23 = obj34 == null;
						object obj37 = !flag23;
						if (obj37 == null)
						{
							bool flag24 = obj5 == null;
							object obj38 = !flag24;
							obj32 = obj36;
							OutOfMemoryException ex3 = (OutOfMemoryException)val3;
							if (obj38 == null)
							{
								goto IL_09a7;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
							obj32 = obj7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						goto IL_0b05;
						IL_0b13:
						NullReferenceException ex4 = new NullReferenceException();
						goto IL_0b21;
						IL_0b2f:
						NullReferenceException ex5 = new NullReferenceException();
						if ((nint)obj32 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj5 = 1;
							obj34 = obj31;
						}
						else
						{
							if ((nint)obj32 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return result;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj34 = obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj31 = obj39;
						}
						num8 = num24;
						obj35 = 0;
						goto IL_0d4e;
						IL_0b05:
						NullReferenceException ex6 = new NullReferenceException();
						goto IL_0b13;
						IL_0b21:
						NullReferenceException ex7 = new NullReferenceException();
						goto IL_0b2f;
					}
				}
			}
		}
		throw new NullReferenceException();
		IL_09a7:
		if ((nint)obj35 != 5)
		{
			bool flag25 = obj35 == null;
			object obj40 = !flag25;
			obj4 = obj5;
			if (obj40 != null)
			{
				goto IL_0c08;
			}
		}
		object obj41 = num8 - 2;
		bool flag26 = (nint)obj41 < 0;
		bool flag27 = obj41 == null;
		int num31 = num8 ^ 2;
		int num32 = num8 ^ obj41;
		int num33 = num31 & num32;
		bool flag28 = num33 < 0;
		bool flag29 = flag26 == flag28;
		object obj42 = !flag27;
		object obj43 = flag29 & obj42;
		obj4 = obj43;
		goto IL_0c08;
		IL_0c08:
		return (byte)(obj4 & 1) != 0;
	}

	private Vector3 Ahead()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I4
		//IL_028e: Expected VT, but got Obj
		//IL_0127: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I
		//IL_0347: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_00ad: Unsupported input type for neg.
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00b6: Unsupported input type for neg.
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bf: Unsupported input type for neg.
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_042f: Expected Obj, but got I
		//IL_0437: Expected VT, but got Obj
		//IL_0459: Expected Obj, but got I4
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
		object obj4;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8;
		object obj9 = default;
		if (screen != null)
		{
			if ((object)screen != null)
			{
				Transform transform = screen.transform;
				if ((object)transform != null)
				{
					Vector3 forward = transform.forward;
					obj4 = 0 - obj5;
					obj6 = 0 - obj7;
					obj8 = 0 - obj9;
					object obj10 = 0;
					goto IL_038a;
				}
			}
		}
		else
		{
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Vector3 forward2 = transform2.forward;
				obj8 = obj9;
				obj6 = obj7;
				obj4 = obj5;
				object obj10 = 0;
				goto IL_038a;
			}
		}
		goto IL_0280;
		IL_0280:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_038a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v6+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+18]");
		object obj14 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+1C]");
		object obj15 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj16 = 0;
		object obj17 = obj16;
		object obj18 = obj14 + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+20]");
		object obj19 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v11+A0]");
		object obj20 = 0;
		object obj21 = obj19 + obj18;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
		{
			object obj22 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+18]");
			object obj23 = obj22 * 0;
			object obj24 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+1C]");
			object obj25 = obj24 * 0;
			object obj26 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+20]");
			object obj27 = obj26 * 0;
			object obj28 = obj23 + obj25;
			object obj29 = obj27 + obj28;
			object obj30 = obj29 / obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+18]");
			object obj31 = 0 * obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+1C]");
			obj9 = 0 * obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v7+20]");
			object obj32 = 0 * obj30;
			obj4 -= obj31;
			obj6 -= obj9;
			obj8 -= obj32;
		}
		object obj33 = obj4 * obj4;
		object obj34 = obj6 * obj6;
		object obj35 = obj33 + obj34;
		object obj36 = obj8 * obj8;
		object obj37 = obj35 + obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		Vector3 result;
		if ((nint)obj37 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj38 = 0;
			result = (Vector3)obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v9 (UnityEngine.Vector3)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj39 = !flag2;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj40 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj40 <= 0)
			{
			}
		}
		else
		{
			Transform transform3 = base.transform;
			if ((object)transform3 == null)
			{
				goto IL_0280;
			}
			result = transform3.forward;
		}
		return result;
	}

	private unsafe bool Spawn(string label, out string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0cdc: Expected Obj, but got I
		//IL_0d19: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_0d53: Expected Obj, but got I
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected VT, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Expected VT, but got Unknown
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected VT, but got Unknown
		//IL_0da2: Expected VT, but got I
		//IL_0db2: Expected VT, but got I
		//IL_0de0: Expected Obj, but got I
		//IL_0df0: Expected VT, but got I
		//IL_0e00: Expected VT, but got I
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e15: Expected VT, but got Unknown
		//IL_0e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2a: Expected Obj, but got Unknown
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected Obj, but got Unknown
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e54: Expected Obj, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected Obj, but got Unknown
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected Obj, but got Unknown
		//IL_0e8b: Expected VT, but got Obj
		//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e98: Expected VT, but got Unknown
		//IL_0ea5: Expected VT, but got Obj
		//IL_0ec6: Expected Obj, but got I
		//IL_0f06: Expected VT, but got I
		//IL_0f16: Expected VT, but got I
		//IL_0f26: Expected VT, but got I
		//IL_0f2f: Expected Obj, but got I4
		//IL_0f4d: Expected Obj, but got I
		//IL_0f77: Expected Obj, but got I4
		//IL_1046: Expected Obj, but got I4
		//IL_0f9d: Expected Obj, but got I
		//IL_0fad: Expected VT, but got I
		//IL_0fbd: Expected VT, but got I
		//IL_0fe6: Expected VT, but got I
		//IL_0ff6: Expected VT, but got I
		//IL_1006: Expected VT, but got I
		//IL_100f: Expected Obj, but got I4
		//IL_1017: Expected Obj, but got Ref
		//IL_10f5: Expected Obj, but got I
		//IL_1105: Expected Obj, but got I
		//IL_1127: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_107e: Expected Obj, but got I4
		//IL_02ac: Expected VT, but got I
		//IL_02b5: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I4
		//IL_0350: Expected VT, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I4
		//IL_03ca: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I4
		//IL_109c: Expected Obj, but got I
		//IL_06ce: Expected VT, but got I
		//IL_06d7: Expected Obj, but got I4
		//IL_061d: Expected Obj, but got I4
		//IL_0781: Expected VT, but got I
		//IL_078a: Expected Obj, but got I4
		//IL_0645: Expected Obj, but got I
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_0724: Expected Obj, but got I
		//IL_0744: Expected VT, but got I
		//IL_074d: Expected Obj, but got I4
		//IL_07b2: Expected Obj, but got I
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_08fb: Expected Obj, but got I
		//IL_091b: Expected VT, but got I
		//IL_07ff: Expected Obj, but got I
		//IL_080c: Expected VT, but got Obj
		//IL_081c: Expected Obj, but got I
		//IL_0829: Expected VT, but got Obj
		//IL_084e: Expected VT, but got Ref
		//IL_084e: Expected VT, but got I4
		//IL_087c: Expected Obj, but got I4
		//IL_08d4: Expected Obj, but got I
		//IL_09c0: Expected Obj, but got I4
		//IL_09d6: Expected VT, but got Ref
		//IL_09db: Expected I, but got Obj
		//IL_0a04: Expected Obj, but got I4
		//IL_0953: Expected Obj, but got I4
		//IL_0969: Expected VT, but got Ref
		//IL_096e: Expected I, but got Obj
		//IL_0997: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		ref string reference = ref *(string*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameObject gameObject = PrefabOf(label);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7;
		if (gameObject == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B90]");
			obj7 = 0;
			object obj8 = 0;
			goto IL_10c6;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = tray != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj11 = 0;
		Quaternion? quaternion;
		Quaternion? quaternion3;
		Vector3 vector;
		Quaternion? quaternion2 = default;
		Quaternion? quaternion4 = default;
		Vector3 vector2 = default;
		object obj12;
		UnityEngine.Object obj13;
		GillaStash gillaStash;
		if (flag4)
		{
			bool flag5 = (object)tray == null;
			obj12 = 0;
			obj13 = null;
			gillaStash = this;
			if (flag5)
			{
				goto IL_0c53;
			}
			Vector3 position = tray.position;
			quaternion = quaternion2;
			quaternion3 = quaternion4;
			vector = vector2;
		}
		else
		{
			Transform transform = base.transform;
			bool flag6 = (object)transform == null;
			obj12 = 0;
			obj13 = null;
			gillaStash = this;
			if (flag6)
			{
				goto IL_0c53;
			}
			Vector3 position2 = transform.position;
			object obj14 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v67+A0]");
			object obj15 = 0;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v68+20]");
			vector = vector3 + 0;
			Quaternion? quaternion5 = quaternion2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v68+18]");
			Quaternion? quaternion6 = (Quaternion?)(object)((_003F?)quaternion5 + 0);
			Quaternion? quaternion7 = quaternion4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v68+1C]");
			quaternion2 = (Quaternion?)(object)((_003F?)quaternion7 + 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v68+1C]");
			quaternion4 = (Quaternion?)(object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v68+20]");
			vector2 = (Vector3)0;
			quaternion = quaternion6;
			quaternion3 = quaternion2;
		}
		Vector3 vector4 = Ahead();
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v11+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+1C]");
		Quaternion? quaternion8 = (Quaternion?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+20]");
		Quaternion? quaternion9 = (Quaternion?)(object)0;
		Vector3 vector5 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
		Vector3 vector6 = vector5 * 0;
		Quaternion? quaternion10 = quaternion4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
		object obj18 = (_003F?)quaternion10 * 0;
		Vector3 vector7 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+1C]");
		object obj19 = vector7 * 0;
		Quaternion? quaternion11 = quaternion4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+20]");
		object obj20 = (_003F?)quaternion11 * 0;
		Quaternion? quaternion12 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+20]");
		object obj21 = (_003F?)quaternion12 * 0;
		Quaternion? quaternion13 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+1C]");
		object obj22 = (_003F?)quaternion13 * 0;
		Vector3 vector8 = (Vector3)(obj19 - obj20);
		Quaternion? quaternion14 = (Quaternion?)(object)(obj21 - vector6);
		Vector3 vector9 = (Vector3)(obj18 - obj22);
		Vector3 forward = default;
		Vector3 upwards = default;
		Quaternion quaternion15 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B80]");
		object obj23 = 0;
		string text = (string)obj23;
		bool flag7 = label == (string)obj23;
		bool flag8 = !flag7;
		Vector3 vector10 = vector8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
		Vector3 vector11 = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+20]");
		Quaternion? quaternion16 = (Quaternion?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+1C]");
		Vector3 vector12 = (Vector3)0;
		object obj24 = 0;
		if (!flag8)
		{
			object obj25 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v57+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v58+18]");
			quaternion8 = (Quaternion?)(object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v58+20]");
			quaternion9 = (Quaternion?)(object)0;
			Quaternion quaternion17 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			vector10 = vector8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
			vector11 = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v58+20]");
			quaternion16 = (Quaternion?)(object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v58+18]");
			vector12 = (Vector3)0;
			obj24 = 0;
			text = (string)(&upwards);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v28+E4]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj30 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v32+E4]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj27;
		}
		object obj32 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v32+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X9_v4+8]");
		UnityEngine.Object obj34 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v20+E4]");
		bool flag11 = (nint)0 == 0;
		object obj35 = !flag11;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X9_v4+8]");
		bool flag12 = (UnityEngine.Object)0 != null;
		bool flag13 = !flag12;
		UnityEngine.Object obj36 = null;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X9_v4+8]");
			bool flag14 = (nint)0 == 0;
			quaternion2 = quaternion8;
			quaternion4 = quaternion9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
			vector2 = (Vector3)0;
			obj12 = 0;
			obj13 = null;
			gillaStash = this;
			if (flag14)
			{
				goto IL_0c53;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X23_v8 (UnityEngine.Object)+B0]");
			obj36 = (UnityEngine.Object)0;
		}
		object obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v36+E4]");
		bool flag15 = (nint)0 == 0;
		object obj38 = !flag15;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = obj36 != null;
		bool flag17 = !flag16;
		UnityEngine.Object obj39 = null;
		UnityEngine.Object obj53;
		if (!flag17)
		{
			bool flag18 = (object)obj36 == null;
			quaternion2 = quaternion8;
			quaternion4 = quaternion9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
			vector2 = (Vector3)0;
			obj12 = 0;
			obj13 = null;
			gillaStash = this;
			if (flag18)
			{
				goto IL_0c53;
			}
			bool isRunning = ((NetworkRunner)obj36).IsRunning;
			bool flag19 = !isRunning;
			obj39 = null;
			if (!flag19)
			{
				object obj40 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v63+E4]");
				bool flag20 = (nint)0 == 0;
				object obj41 = !flag20;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj40 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v63+A0]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v32+C4]");
				bool flag21 = (nint)0 == 0;
				obj39 = null;
				if (flag21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X9_v4+8]");
					bool flag22 = (nint)0 == 0;
					quaternion2 = quaternion8;
					quaternion4 = quaternion9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
					vector2 = (Vector3)0;
					obj12 = 0;
					obj13 = null;
					gillaStash = this;
					if (flag22)
					{
						goto IL_0c53;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X23_v8 (UnityEngine.Object)+A4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B88]");
						obj7 = 0;
						quaternion2 = quaternion8;
						quaternion4 = quaternion9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
						vector2 = (Vector3)0;
						object obj8 = 0;
					}
					else
					{
						bool flag23 = (object)gameObject == null;
						quaternion2 = quaternion8;
						quaternion4 = quaternion9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
						vector2 = (Vector3)0;
						obj12 = 0;
						obj13 = null;
						gillaStash = this;
						if (flag23)
						{
							goto IL_0c53;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5358]");
						object obj43 = 0;
						object obj8 = obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
						object obj45 = default;
						object obj44 = obj45 & 1;
						if (obj44 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
							object obj46 = 0;
							Vector3? position3 = (Vector3)obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
							object obj47 = 0;
							Quaternion? quaternion18 = (Quaternion)obj47;
							NetworkObject prefab = default;
							Quaternion? quaternion19 = default;
							NetworkObject networkObject = ((NetworkRunner)obj36).Spawn(prefab, position3, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion19), (NetworkRunner.OnBeforeSpawned)null, (NetworkSpawnFlags)0);
							object obj48 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v70+E4]");
							bool flag24 = (nint)0 == 0;
							object obj49 = !flag24;
							if (obj49 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)networkObject == (UnityEngine.Object)null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B98]");
								object obj50 = 0;
								reference = ref *(string*)obj50;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								goto IL_00c1;
							}
							object obj51;
							NetworkSpawnFlags networkSpawnFlags;
							NetworkRunner.OnBeforeSpawned onBeforeSpawned;
							PlayerRef? playerRef;
							nint num;
							if ((object)networkObject != null)
							{
								GameObject gameObject2 = networkObject.gameObject;
								obj51 = 4;
								networkSpawnFlags = (NetworkSpawnFlags)0;
								onBeforeSpawned = null;
								playerRef = (PlayerRef?)(object)(&quaternion19);
								num = unchecked((nint)null);
								quaternion2 = quaternion18;
								quaternion4 = quaternion16;
								vector8 = vector10;
								vector2 = vector11;
								object obj52 = 0;
								string text2 = null;
								obj53 = gameObject2;
								goto IL_0593;
							}
							NullReferenceException ex = new NullReferenceException();
							obj51 = 4;
							networkSpawnFlags = (NetworkSpawnFlags)0;
							onBeforeSpawned = null;
							playerRef = (PlayerRef?)(object)(&quaternion19);
							num = unchecked((nint)null);
							quaternion2 = quaternion18;
							quaternion4 = quaternion16;
							vector8 = vector10;
							vector2 = vector11;
							object obj54 = 0;
							UnityEngine.Object obj55 = null;
							NullReferenceException ex2 = ex;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							bool result = default;
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B98]");
						obj7 = 0;
						quaternion2 = quaternion8;
						quaternion4 = quaternion9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v12+18]");
						vector2 = (Vector3)0;
					}
					goto IL_10c6;
				}
			}
		}
		object obj56 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X0_v52+E4]");
		bool flag25 = (nint)0 == 0;
		object obj57 = !flag25;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
		object obj58 = 0;
		obj13 = (UnityEngine.Object)obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
		bool flag26 = (object)gameObject == null;
		quaternion2 = quaternion;
		quaternion4 = quaternion3;
		vector6 = vector10;
		vector9 = vector11;
		quaternion14 = quaternion16;
		vector8 = vector12;
		vector2 = vector;
		obj12 = 0;
		gillaStash = this;
		if (!flag26)
		{
			string text3 = gameObject.name;
			UnityEngine.Object obj59 = default;
			bool flag27 = (object)obj59 == null;
			quaternion2 = quaternion;
			quaternion4 = quaternion3;
			vector6 = vector10;
			vector9 = vector11;
			quaternion14 = quaternion16;
			vector8 = vector12;
			vector2 = vector;
			obj12 = 0;
			obj13 = null;
			gillaStash = this;
			if (!flag27)
			{
				obj59.name = text3;
				quaternion2 = quaternion;
				quaternion4 = quaternion3;
				vector6 = vector10;
				vector9 = vector11;
				quaternion14 = quaternion16;
				vector8 = vector12;
				vector2 = vector;
				object obj52 = 0;
				string text2 = text3;
				obj53 = obj59;
				goto IL_0593;
			}
		}
		goto IL_0c53;
		IL_00c1:
		return false;
		IL_0c53:
		throw new NullReferenceException();
		IL_0593:
		object obj60 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X0_v41+E4]");
		bool flag28 = (nint)0 == 0;
		object obj61 = !flag28;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj53 != null)
		{
			bool flag29 = (object)obj53 == null;
			obj12 = 0;
			obj13 = null;
			gillaStash = this;
			if (flag29)
			{
				goto IL_0c53;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5350]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
			object obj64 = default;
			object obj63 = obj64 & 1;
			if (obj63 != null)
			{
				GillaItem item = default;
				Push(item);
			}
		}
		return true;
		IL_10c6:
		reference = ref *(string*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_00c1;
	}

	private void Push(GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a5e: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0393: Expected Obj, but got VT
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Obj, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_0665: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I4
		//IL_0ad8: Expected Obj, but got VT
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected Obj, but got Unknown
		//IL_0b5a: Expected VT, but got I4
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Expected Obj, but got Unknown
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected Obj, but got Unknown
		//IL_0c35: Expected Obj, but got I4
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_078a: Invalid comparison between F8 and I4
		//IL_0799: Invalid comparison between F8 and I4
		//IL_07ac: Expected Obj, but got F8
		//IL_07b9: Expected Obj, but got F8
		//IL_07ee: Expected Obj, but got I4
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_04a2: Expected VT, but got I4
		//IL_04cc: Expected Obj, but got I4
		//IL_0890: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got VT
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected Obj, but got Unknown
		//IL_09ba: Expected Obj, but got I4
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected Obj, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
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
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = item.Body__BackingField == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = tray == null;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 lossyScale = transform.lossyScale;
		Vector3 vector = Ahead();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v12+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+1C]");
		object obj15 = default;
		object obj14 = obj15 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+20]");
		object obj17 = default;
		object obj16 = obj17 * 0;
		Vector3 position = tray.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v25+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj21 = obj14 - obj16;
		Physics.SyncTransforms();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v28+E4]");
		bool flag11 = (nint)0 == 0;
		object obj24 = !flag11;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Bounds bounds = WholeOf(item);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+1C]");
		object obj26 = default;
		object obj25 = 0 * obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+20]");
		object obj28 = default;
		object obj27 = 0 * obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+18]");
		object obj30 = default;
		object obj29 = 0 * obj30;
		object obj31 = obj25 + obj27;
		object obj32 = obj31 + obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8DC]");
		object obj34 = default;
		object obj33 = obj34 * 0;
		object obj35 = obj32 + obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33);
		Vector3 axis = default;
		object obj36 = axis;
		object obj37 = obj28;
		object obj38 = obj34;
		object obj40 = default;
		object obj39 = obj40;
		object obj41 = obj26;
		object obj42 = obj30;
		object obj44 = default;
		object obj43 = obj44;
		if (!flag12)
		{
			object obj45 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v53+E4]");
			bool flag13 = (nint)0 == 0;
			object obj46 = !flag13;
			obj41 = obj26;
			obj42 = obj30;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj41 = obj26;
				obj42 = obj30;
			}
			object obj47 = obj35 * obj28;
			object obj48 = obj33 * obj41;
			object obj49 = obj48 + obj47;
			object obj50 = obj21 * obj42;
			object obj51 = obj49 + obj50;
			bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
			obj36 = axis;
			obj37 = obj28;
			obj38 = obj34;
			obj39 = obj40;
			obj43 = obj44;
			if (!flag14)
			{
				Transform transform2 = item.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
				Quaternion quaternion = Quaternion.Internal_AngleAxis(90f, ref axis);
				Transform transform3 = item.transform;
				Quaternion rotation = transform3.rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				transform2.rotation = (Quaternion)0;
				object obj52 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X0_v67+E4]");
				bool flag15 = (nint)0 == 0;
				object obj53 = !flag15;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Physics.SyncTransforms();
				object obj54 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v70+E4]");
				bool flag16 = (nint)0 == 0;
				object obj55 = !flag16;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Bounds bounds2 = WholeOf(item);
				obj36 = axis;
				obj37 = obj28;
				obj38 = obj34;
				obj39 = obj17;
				obj41 = obj26;
				obj42 = obj30;
				obj43 = obj50;
			}
		}
		Transform transform4 = item.transform;
		object obj56 = obj37 + obj37;
		object obj57 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		object obj58 = obj57 * 0;
		object obj59 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAA0]");
		object obj60 = obj59 * 0;
		object obj61 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		object obj62 = obj61 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+20]");
		object obj63 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+20]");
		object obj64 = 0 + obj60;
		object obj65 = obj64 + obj63;
		object obj66 = obj62 + obj64;
		object obj67 = obj62 + obj56;
		object obj68 = obj63 - obj64;
		double num = (double)obj65 * 0.5;
		double num2 = (double)obj66 + (double)obj37;
		bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj67) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68);
		object obj69 = !flag17;
		object obj70 = obj67 - obj68;
		bool flag18 = obj70 == null;
		object obj71 = !flag18;
		object obj72 = obj69 & obj71;
		object obj73 = ~obj72;
		double num3 = ((obj73 != null) ? num2 : num);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+18]");
		object obj74 = 0 - obj39;
		double num4 = num3 - (double)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+1C]");
		object obj75 = 0 - obj36;
		Vector3 position2 = transform4.position;
		transform4.position = (Vector3)0;
		object obj76 = obj36 + obj75;
		double num5 = (double)obj43 + num4;
		object obj77 = obj22;
		object obj78 = obj39 + obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+1C]");
		object obj79 = obj76 - 0;
		double num6 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+20]");
		double num7 = num6 - 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v13+18]");
		object obj80 = obj78 - 0;
		object obj81 = obj34 * obj79;
		double num8 = (double)obj17 * num7;
		double num9 = (double)obj81 + num8;
		object obj82 = obj15 * obj80;
		double num10 = (double)obj82 + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v37+E4]");
		bool flag19 = (nint)0 == 0;
		object obj83 = !flag19;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj84 = obj33 * obj41;
		object obj85 = obj35 * obj37;
		object obj86 = obj85 + obj84;
		object obj87 = obj21 * obj42;
		object obj88 = obj87 + obj86;
		object obj89 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC88]");
		object obj90 = obj89 * 0;
		item.Pinned__BackingField = true;
		double num11 = (double)obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num12 = num11 * 0.0;
		double num13 = num10 - (double)obj88;
		double num14 = (double)obj90 - num13;
		double num15 = num12 - num14;
		bool flag20 = num15 < 0.0;
		bool flag21 = num15 == 0.0;
		object obj91 = num12 ^ num14;
		object obj92 = num12 ^ num15;
		object obj93 = obj91 & obj92;
		bool flag22 = (nint)obj93 < 0;
		bool flag23 = flag20 == flag22;
		object obj94 = !flag21;
		object obj95 = flag23 & obj94;
		object obj96 = ~obj95;
		double num16 = ((obj96 != null) ? num14 : num12);
		item.Body__BackingField.isKinematic = true;
		item.Body__BackingField.interpolation = (RigidbodyInterpolation)0;
		Transform transform5 = item.transform;
		Vector3 position3 = transform5.position;
		List<System.__Canon> list = (List<System.__Canon>)(object)this.coming;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BA8]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Coming coming = default;
		coming._002Ector();
		object obj98 = coming + 16;
		obj98 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		double num17 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		double num18 = num17 / 0.0;
		double num19 = (double)obj34 * num16;
		double num20 = (double)obj17 * num16;
		double num21 = (double)obj15 * num16;
		double num22 = num19 + num14;
		double num23 = num20 + (double)obj90;
		double num24 = num21 + num12;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag24 = list._size < items.Length;
		object obj99 = !flag24;
		if (obj99 == null)
		{
			object obj100 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj101 = obj100 + 32;
			obj101 = coming;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)coming);
		}
	}

	private unsafe static Bounds WholeOf(GillaItem item)
	{
		//IL_0548: Expected VT, but got Obj
		//IL_0575: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05e4: Expected Obj, but got I
		//IL_0601: Expected VT, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_0291: Invalid comparison between VT and I4
		//IL_005c: Expected VT, but got I4
		//IL_0522: Expected native int or pointer, but got VT
		//IL_007e: Expected Obj, but got I8
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Expected VT, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I8
		//IL_02fc: Expected Obj, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0313: Expected Obj, but got I4
		//IL_0628: Expected Obj, but got I4
		//IL_064f: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		//IL_03a1: Expected VT, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_024f: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_04da: Expected Obj, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_0507: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I
		//IL_0405: Expected VT, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_042e: Expected VT, but got I4
		//IL_0201: Expected VT, but got Ref
		//IL_0211: Expected Obj, but got Ref
		//IL_044d: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I4
		//IL_04a5: Expected VT, but got Ref
		//IL_04bd: Expected Obj, but got Ref
		//IL_04c5: Expected VT, but got Ref
		object obj4;
		object obj6;
		_003C_003Ec__DisplayClass134_0 obj7;
		if ((object)item != null)
		{
			Transform transform = item.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v7+A0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj4 = 0;
				Collider[] array = item.Colliders__BackingField;
				object obj5 = obj3 * 63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v8+8]");
				double num = 0.0 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
				obj6 = 0;
				bool flag = item.Colliders__BackingField == null;
				obj7 = (_003C_003Ec__DisplayClass134_0)0;
				if (!flag)
				{
					bool flag2 = array.Length < 1;
					obj7 = (_003C_003Ec__DisplayClass134_0)0;
					if (!flag2)
					{
						object obj8 = array.Length & 0xFFFFFFFFL;
						object obj9 = item.Colliders__BackingField + 32;
						obj7 = (_003C_003Ec__DisplayClass134_0)0;
						object obj10 = obj5;
						object obj12 = default;
						object obj11 = obj12;
						object obj13 = 0;
						UnityEngine.Object obj14 = null;
						object obj20 = default;
						object obj21 = default;
						while (true)
						{
							bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
							object obj15 = !flag3;
							if (obj15 != null)
							{
								break;
							}
							object obj16 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v30+E4]");
							bool flag4 = (nint)0 == 0;
							object obj17 = !flag4;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X26_v7+v138 @ X25_v9*8]");
							bool flag5 = (UnityEngine.Object)0 != null;
							bool flag6 = !flag5;
							obj14 = null;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X26_v7+v138 @ X25_v9*8]");
								if ((nint)0 == 0)
								{
									goto IL_053a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X26_v7+v138 @ X25_v9*8]");
								bool flag7 = ((Collider)0).enabled;
								bool flag8 = !flag7;
								obj14 = null;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X26_v7+v138 @ X25_v9*8]");
									Bounds bounds = ((Collider)0).bounds;
									object obj18 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v39+E4]");
									bool flag9 = (nint)0 == 0;
									object obj19 = !flag9;
									if (obj19 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									_003CWholeOf_003Eg__Add_007C134_0((Bounds)(&obj20), ref obj7);
									obj10 = obj21;
									obj14 = (UnityEngine.Object)(&obj7);
								}
							}
							obj8 = array.Length;
							obj13++;
							bool flag10 = (nint)obj13 < array.Length;
							obj5 = obj10;
							obj12 = 0;
							obj11 = 0;
							if (flag10)
							{
								continue;
							}
							goto IL_0266;
						}
						goto IL_052c;
					}
				}
				goto IL_0266;
			}
		}
		goto IL_053a;
		IL_0266:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
		object obj22 = 0;
		UnityEngine.Object obj23 = (UnityEngine.Object)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
		Bounds bounds2 = default;
		Bounds result;
		if (bounds2 != (Bounds)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v12 (UnityEngine.Bounds)+18]");
			bool flag11 = (nint)0 < (nint)1;
			result = bounds2;
			if (flag11)
			{
				goto IL_0515;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v12 (UnityEngine.Bounds)+18]");
			object obj24 = 0 & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BB8]");
			object obj25 = 0;
			object obj26 = bounds2 + 32;
			object obj27 = 0;
			object obj34 = default;
			object obj35 = default;
			while (true)
			{
				bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
				object obj28 = !flag12;
				if (obj28 != null)
				{
					break;
				}
				object obj29 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X26_v6+v99 @ X24_v7*8]");
				UnityEngine.Object obj30 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v15+E4]");
				bool flag13 = (nint)0 == 0;
				object obj31 = !flag13;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X26_v6+v99 @ X24_v7*8]");
				bool flag14 = (UnityEngine.Object)0 != null;
				bool flag15 = !flag14;
				obj23 = null;
				result = (Bounds)flag14;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X26_v6+v99 @ X24_v7*8]");
					if ((nint)0 == 0)
					{
						goto IL_053a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X26_v6+v99 @ X24_v7*8]");
					bool flag16 = ((Renderer)0).enabled;
					bool flag17 = !flag16;
					obj23 = null;
					result = (Bounds)flag16;
					if (!flag17)
					{
						bool flag18 = obj30 == obj25;
						obj23 = null;
						result = (Bounds)flag16;
						if (!flag18)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X26_v6+v99 @ X24_v7*8]");
							Bounds bounds3 = ((Renderer)0).bounds;
							object obj32 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v24+E4]");
							bool flag19 = (nint)0 == 0;
							object obj33 = !flag19;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							_003CWholeOf_003Eg__Add_007C134_0((Bounds)(&obj34), ref obj7);
							obj34 = obj35;
							object obj5 = obj35;
							obj23 = (UnityEngine.Object)(&obj7);
							result = (Bounds)(&obj34);
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v12 (UnityEngine.Bounds)+18]");
				obj24 = 0;
				obj27++;
				object obj36 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v12 (UnityEngine.Bounds)+18]");
				bool flag20 = (nint)obj36 < 0;
				object obj12 = 0;
				if (flag20)
				{
					continue;
				}
				goto IL_0515;
			}
			goto IL_052c;
		}
		goto IL_053a;
		IL_053a:
		NullReferenceException ex = new NullReferenceException();
		return (Bounds)ex;
		IL_0515:
		Bounds bounds4 = default;
		Vector3 center = default;
		((Bounds*)(nint)bounds4)->m_Center = center;
		return result;
		IL_052c:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_053a;
	}

	private static float Reach(Bounds b, Vector3 dir)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj2 = default;
		object obj = obj2 * b.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X0 (UnityEngine.Bounds)+10]");
		object obj4 = default;
		object obj3 = obj4 * 0;
		object obj5 = obj + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X0 (UnityEngine.Bounds)+14]");
		object obj7 = default;
		object obj6 = obj7 * 0;
		return (float)obj5 + (float)obj6;
	}

	private void PushOut(float dt)
	{
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I8
		//IL_0356: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03fc: Expected F8, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02d6: Expected VT, but got I4
		//IL_02e6: Expected F4, but got I
		//IL_02fb: Invalid comparison between I and F8
		//IL_0235: Expected Obj, but got I
		//IL_024f: Invalid comparison between I and F8
		//IL_0280: Expected F8, but got I
		List<Coming> list = coming;
		int num = list._size;
		if (list._size < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		float num2 = dt;
		object obj13 = default;
		do
		{
			num--;
			System.__Canon _Canon = ((List<System.__Canon>)(object)coming).get_Item(num);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+10]");
			UnityEngine.Object obj4 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+10]");
			bool flag2 = (UnityEngine.Object)0 == null;
			bool flag3 = !flag2;
			object obj6 = !flag3;
			Coming c;
			bool pop;
			GillaStash gillaStash;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v5 (UnityEngine.Object)+41]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v5 (UnityEngine.Object)+40]");
					bool flag5 = (nint)0 == 0;
					object obj8 = !flag5;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v5 (UnityEngine.Object)+3C]");
						object obj9 = 0 & 0x80000000L;
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+10]");
							flag2 = ((GillaItem)0).Mine;
							if (flag2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+34]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+34]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
								if (num3 < 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
									obj10 = 0;
								}
								float num4 = dt / (float)obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+30]");
								float num5 = 0f + num4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+10]");
								Transform transform = ((Component)0).transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+30]");
								bool flag6 = (nint)0 < (nint)0;
								double num6 = 0.0;
								if (!flag6)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+30]");
									bool flag7 = 0.0 > 1.0;
									num6 = 1.0;
									if (!flag7)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+30]");
										num6 = 0.0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+2C]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+20]");
								object obj11 = num7 - 0;
								double num8 = (double)obj11 * num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+20]");
								double num9 = 0.0 + num8;
								transform.position = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+30]");
								num2 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v7 (System.__Canon)+30]");
								bool flag8 = 0.0 < 1.0;
								object obj12 = obj13;
								if (flag8)
								{
									continue;
								}
								obj12 = obj13;
								c = (Coming)(object)_Canon;
								pop = true;
								gillaStash = (GillaStash)(object)transform;
								goto IL_040a;
							}
						}
						c = (Coming)(object)_Canon;
						pop = false;
						gillaStash = (GillaStash)flag2;
						goto IL_040a;
					}
				}
			}
			goto IL_035b;
			IL_035b:
			((List<System.__Canon>)(object)coming).RemoveAt(num);
			continue;
			IL_040a:
			gillaStash.LetGo(c, pop);
			goto IL_035b;
		}
		while (num > 0);
	}

	private void LetGo(Coming c, bool pop)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I8
		//IL_0103: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got VT
		//IL_01a4: Expected Obj, but got I
		//IL_02b8: Expected VT, but got I4
		//IL_02b8: Expected VT, but got I4
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_026f: Expected F4, but got I
		//IL_026f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		UnityEngine.Object item = c.item;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = c.item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X19_v3 (UnityEngine.Object)+3C]");
		object obj5 = 0 & 0x80000000L;
		if (obj5 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X19_v3 (UnityEngine.Object)+41]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X19_v3 (UnityEngine.Object)+40]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null && c.item.Mine)
		{
			object obj8 = c.to - c.from;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaStash+Coming)+2C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaStash+Coming)+20]");
			object obj9 = num - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
			if (pop)
			{
				object obj10 = obj9 * obj8;
				object obj11 = obj8 * obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaStash+Coming)+2C]");
				object obj12 = obj8 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaStash+Coming)+2C]");
				object obj13 = 0 * obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaStash+Coming)+2C]");
				object obj14 = 0 * obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (GillaStash+Coming)+2C]");
				object obj15 = obj9 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				float num3 = UnityEngine.Random.Range(num2, 0f);
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
			}
			c.item.Release((Vector3)0, (Vector3)0);
		}
	}

	private static List<string> Kinds()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_0179: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B18]");
		object obj = 0;
		IReadOnlyList<(string, int)> items = GillaStashSave.Items;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v4+8]");
		Func<(System.__Canon, int), System.__Canon> selector = (Func<(System.__Canon, int), System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v4+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v12+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6308]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B28]");
			object obj9 = 0;
			Func<(System.__Canon, int), System.__Canon> func = default;
			func._002Ector(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v11+A0]");
			object obj11 = (nint)0 + (nint)8;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			selector = func;
		}
		IEnumerable<System.__Canon> source = Enumerable.Select((IEnumerable<(System.__Canon, int)>)items, selector);
		return (List<string>)(object)Enumerable.ToList(source);
	}

	private void Fix()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected I4, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I
		//IL_01e5: Expected I4, but got Obj
		//IL_01f2: Expected Obj, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected I4, but got Unknown
		//IL_0250: Expected Obj, but got I4
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<string> list = Kinds();
		bool flag2 = selected == null;
		GillaStash gillaStash = (GillaStash)(object)list;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B10]");
			object obj4 = 0;
			bool flag3 = ((List<System.__Canon>)(object)list).Contains((System.__Canon)(object)selected);
			bool flag4 = !flag3;
			object obj5 = !flag4;
			gillaStash = (GillaStash)flag3;
			if (obj5 == null)
			{
				object obj6 = this + 272;
				selected = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}
		int pages = gillaStash.Pages;
		int num = pages - 1;
		object obj7 = page - num;
		bool flag5 = (nint)obj7 < 0;
		int num2 = page ^ num;
		int num3 = page ^ obj7;
		int num4 = num2 & num3;
		bool flag6 = num4 < 0;
		bool flag7 = flag5 == flag6;
		object obj8 = !flag7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			num = page;
		}
		bool flag8 = page < 0;
		int num5 = page ^ page;
		int num6 = page & num5;
		bool flag9 = num6 < 0;
		bool flag10 = flag8 == flag9;
		object obj10 = !flag10;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			num = 0;
		}
		page = num;
		bool flag11 = selected == null;
		object obj12 = !flag11;
		if (obj12 == null)
		{
			int num7 = list._size - 1;
			if (num7 >= 1)
			{
				object obj13 = num + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83C0]");
				object obj14 = 0;
				int num8 = obj13 << 1;
				object obj15 = num8 - num7;
				bool flag12 = (nint)obj15 < 0;
				int num9 = num8 ^ num7;
				int num10 = num8 ^ obj15;
				int num11 = num9 & num10;
				bool flag13 = num11 < 0;
				bool flag14 = flag12 == flag13;
				object obj16 = !flag14;
				object obj17 = ~obj16;
				int index = ((obj17 != null) ? num7 : num8);
				System.__Canon _Canon = ((List<System.__Canon>)(object)list).get_Item(index);
				selected = (string)(object)_Canon;
				object obj18 = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}
		MakeTiles();
		dirty = true;
	}

	private unsafe void MakeTiles()
	{
		//IL_0010: Expected Obj, but got I
		//IL_08d3: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0122: Expected I4, but got Obj
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got I4
		//IL_04cc: Expected Obj, but got I4
		//IL_0aaf: Expected Obj, but got I
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected Ref, but got Unknown
		//IL_0ada: Expected Obj, but got I4
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected Obj, but got I4
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got I4
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I
		//IL_092c: Expected Obj, but got I
		//IL_093c: Expected Obj, but got I
		//IL_095e: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_030a: Expected I4, but got Obj
		//IL_044f: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_0844: Expected Obj, but got I4
		//IL_0538: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I
		//IL_097c: Expected Obj, but got I
		//IL_0997: Expected Obj, but got I
		//IL_09a8: Expected I, but got Obj
		//IL_09c6: Expected Obj, but got I
		//IL_09e1: Expected Obj, but got I4
		//IL_08a3: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I
		//IL_05f1: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I
		//IL_0a66: Expected I4, but got Obj
		//IL_0a6e: Expected Obj, but got I4
		//IL_066e: Expected I4, but got Obj
		//IL_06aa: Expected I4, but got Obj
		//IL_06b2: Expected Obj, but got I4
		//IL_06ed: Expected Obj, but got I4
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected Obj, but got Unknown
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
		bool flag2 = tileRoot == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BD0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BD8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83B0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<string> list = Kinds();
		object obj11 = page + page;
		object obj12 = obj11 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E0E0C");
		int num = (int)obj8;
		IEnumerable<System.__Canon> source2 = default;
		IEnumerable<System.__Canon> source = Enumerable.Take(source2, 6);
		IEnumerable<System.__Canon> enumerable = (IEnumerable<System.__Canon>)obj9;
		List<System.__Canon> list2 = Enumerable.ToList(source);
		int num2 = page;
		object obj14 = default;
		Enumerator<, > val;
		object obj13;
		if (shownPage == page)
		{
			IEnumerable<System.__Canon> enumerable2 = (IEnumerable<System.__Canon>)tiles;
			bool flag5 = tiles == null;
			obj13 = obj14;
			val = (Enumerator<, >)0;
			if (!flag5)
			{
				bool flag6 = list2 == null;
				obj13 = obj14;
				val = (Enumerator<, >)0;
				if (!flag6)
				{
					int size = list2._size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v21 (System.Collections.Generic.IEnumerable`1<System.__Canon>)+18]");
					bool flag7 = (nint)0 != list2._size;
					num2 = shownPage;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B18]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v63+E4]");
						bool flag8 = (nint)0 == 0;
						object obj17 = !flag8;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj16 = obj15;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v63+A0]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v43+10]");
						Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v43+10]");
						bool flag9 = (nint)0 == 0;
						object obj19 = !flag9;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v63+E4]");
							bool flag10 = (nint)0 == 0;
							object obj20 = !flag10;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj21 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v47+A0]");
								obj18 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BF8]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C18]");
							object obj23 = 0;
							Func<System.__Canon, System.__Canon> func = default;
							func._002Ector(obj18, (IntPtr)obj23);
							object obj24 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v46+A0]");
							object obj25 = (nint)0 + (nint)16;
							obj25 = func;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj26 = 0;
							selector = func;
						}
						IEnumerable<System.__Canon> first = Enumerable.Select((IEnumerable<System.__Canon>)tiles, selector);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BC8]");
						object obj27 = 0;
						num = (int)obj27;
						bool flag11 = Enumerable.SequenceEqual(first, (IEnumerable<System.__Canon>)list2);
						bool flag12 = !flag11;
						object obj28 = !flag12;
						if (obj28 != null)
						{
							return;
						}
						num2 = page;
						enumerable = (IEnumerable<System.__Canon>)list2;
					}
					goto IL_08e1;
				}
			}
			goto IL_07da;
		}
		goto IL_08e1;
		IL_07da:
		throw new NullReferenceException();
		IL_08e1:
		shownPage = num2;
		bool flag13 = tiles == null;
		obj13 = obj14;
		val = (Enumerator<, >)0;
		if (!flag13)
		{
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)tiles).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BE8]");
			object obj29 = 0;
			Enumerator<, > val2 = default;
			object obj40 = default;
			while (true)
			{
				enumerable = (IEnumerable<System.__Canon>)obj29;
				object obj34;
				Enumerator<, > val3;
				Enumerator<, > val4;
				if (val.MoveNext())
				{
					if (obj14 != null)
					{
						object obj30 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v34+E4]");
						bool flag14 = (nint)0 == 0;
						object obj31 = !flag14;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ stack_-68 (System.Object)+10]");
						bool flag15 = (UnityEngine.Object)0 != null;
						bool flag16 = !flag15;
						num = 0;
						if (!flag16)
						{
							object obj32 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v38+E4]");
							bool flag17 = (nint)0 == 0;
							object obj33 = !flag17;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ stack_-68 (System.Object)+10]");
							UnityEngine.Object.Destroy((UnityEngine.Object)0);
							num = 0;
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					obj13 = null;
					val = val2;
					obj34 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					num2 = (int)(&val);
					break;
				}
				obj13 = null;
				val = val2;
				obj34 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				num2 = (int)(&val);
				object obj35 = 0;
				object obj36 = 7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BE0]");
					object obj37 = 0;
					enumerable = (IEnumerable<System.__Canon>)obj37;
					((Enumerator<, >*)val4)->Dispose();
					bool flag18 = obj35 == null;
					object obj38 = !flag18;
					if (obj38 == null)
					{
						bool flag19 = obj13 == null;
						object obj39 = !flag19;
						OutOfMemoryException ex2 = (OutOfMemoryException)val4;
						if (obj39 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)enumerable == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = 1;
						obj35 = obj34;
					}
					else
					{
						if ((nint)enumerable != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EB2C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj35 = obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj34 = obj40;
					}
					obj36 = 0;
				}
				if ((nint)obj36 != 7)
				{
					bool flag20 = obj36 == null;
					object obj41 = !flag20;
					if (obj41 != null)
					{
						return;
					}
				}
				List<Tile> list3 = tiles;
				if (tiles == null)
				{
					break;
				}
				num = list3._size;
				num2 = list3._version + 1;
				list3._size = 0;
				list3._version = num2;
				if (list3._size >= 1)
				{
					Array.Clear(list3._items, 0, list3._size);
					object obj26 = 0;
					enumerable = null;
				}
				if (list2 == null)
				{
					break;
				}
				if (list2._size < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C00]");
				obj = 0;
				int num3 = 0;
				while (true)
				{
					List<System.__Canon> list4 = (List<System.__Canon>)(object)tiles;
					System.__Canon _Canon = list2.get_Item(num3);
					Tile tile = MakeTile(num3, (string)(object)_Canon);
					bool flag21 = tiles == null;
					num = (int)_Canon;
					enumerable = (IEnumerable<System.__Canon>)num3;
					if (flag21)
					{
						break;
					}
					System.__Canon[] items = list4._items;
					num2 = (int)obj;
					int size = list4._version + 1;
					list4._version = size;
					bool flag22 = list4._items == null;
					num = (int)_Canon;
					enumerable = (IEnumerable<System.__Canon>)num3;
					if (flag22)
					{
						break;
					}
					size = list4._size;
					bool flag23 = list4._size < items.Length;
					object obj42 = !flag23;
					if (obj42 == null)
					{
						object obj43 = list4._items + list4._size;
						num2 = list4._size + 1;
						list4._size = num2;
						object obj44 = obj43 + 32;
						obj44 = tile;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						((List<System.__Canon>)(object)tiles).AddWithResize((System.__Canon)(object)tile);
					}
					num3++;
					if (num3 >= list2._size)
					{
						return;
					}
				}
				break;
			}
		}
		goto IL_07da;
	}

	private Tile MakeTile(int i, string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00d4: Expected F8, but got I
		//IL_00fd: Invalid comparison between F8 and I4
		//IL_0117: Expected Obj, but got F8
		//IL_0126: Expected Obj, but got F8
		//IL_0172: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_0266: Expected VT, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_02e4: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I4
		//IL_0b9a: Invalid comparison between F8 and I4
		//IL_0bb4: Expected Obj, but got F8
		//IL_0bc3: Expected Obj, but got F8
		//IL_03ad: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I
		//IL_0862: Expected Obj, but got I
		//IL_0872: Expected F8, but got I
		//IL_0fb2: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I
		//IL_0621: Expected Obj, but got I
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04e1: Expected Obj, but got I4
		//IL_0923: Expected Obj, but got I
		//IL_102f: Expected Obj, but got I4
		//IL_06d5: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got I
		//IL_0583: Expected Obj, but got I
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_0c97: Invalid comparison between F8 and I4
		//IL_0ca6: Invalid comparison between F8 and I4
		//IL_0cb9: Expected Obj, but got F8
		//IL_0cc6: Expected Obj, but got F8
		//IL_0cfb: Expected Obj, but got I4
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected Obj, but got Unknown
		//IL_0e1a: Invalid comparison between F8 and I4
		//IL_0e29: Invalid comparison between F8 and I4
		//IL_0e3c: Expected Obj, but got F8
		//IL_0e49: Expected Obj, but got F8
		//IL_0e7e: Expected Obj, but got I4
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected Obj, but got Unknown
		//IL_07a1: Expected Obj, but got I8
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected Obj, but got Unknown
		//IL_0f4c: Expected VT, but got F8
		//IL_09ef: Expected VT, but got I4
		//IL_0845: Expected Obj, but got I4
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Expected Obj, but got Unknown
		//IL_1063: Invalid comparison between F4 and I4
		//IL_1072: Invalid comparison between F4 and I4
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_1085: Expected Obj, but got Unknown
		//IL_108d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1092: Expected Obj, but got Unknown
		//IL_10c7: Expected Obj, but got I4
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected Obj, but got Unknown
		//IL_0f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f70: Expected Obj, but got Unknown
		//IL_07d2: Expected F4, but got Obj
		//IL_0a1e: Expected Obj, but got I
		//IL_0a43: Expected VT, but got I4
		//IL_0a94: Expected Obj, but got F8
		//IL_0ab1: Expected VT, but got I4
		//IL_0ade: Expected Obj, but got I
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected Obj, but got Unknown
		//IL_0b27: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Tile tile = default;
		tile._002Ector();
		int num = default;
		string text = num.ToString();
		string text2 = (string)obj2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(text2);
		object obj4;
		GameObject gameObject3;
		object obj22;
		double num7;
		double num9;
		float num3;
		Vector3 euler = default;
		double num36;
		double num37;
		double num12;
		if (tile != null)
		{
			obj4 = tile + 16;
			obj4 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = tile + 32;
			obj5 = label;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
			double num2 = 0.0;
			num3 = awake;
			double num4 = (double)awake - 1.0;
			bool flag = num4 < 0.0;
			object obj6 = (double)awake ^ 1.0;
			object obj7 = (double)awake ^ num4;
			object obj8 = obj6 & obj7;
			bool flag2 = (nint)obj8 < 0;
			double num5 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
			double num6 = num5 * 0.0;
			bool flag3 = flag == flag2;
			object obj9 = !flag3;
			object obj10 = ~obj9;
			if (obj10 != null)
			{
				num6 = 1.0;
			}
			if (obj4 != null)
			{
				Transform transform = ((GameObject)obj4).transform;
				if ((object)transform != null)
				{
					transform.SetParent(tileRoot, worldPositionStays: false);
					if (obj4 != null)
					{
						Transform transform2 = ((GameObject)obj4).transform;
						Vector3 vector = ModelAt(num);
						if ((object)transform2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj12 = 0;
							transform2.localPosition = (Vector3)0;
							object obj13 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v25+E4]");
							bool flag4 = (nint)0 == 0;
							object obj14 = !flag4;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GameObject gameObject2 = PrefabOf(label);
							object obj15 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v9+E4]");
							bool flag5 = (nint)0 == 0;
							object obj16 = !flag5;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!(gameObject2 != null))
							{
								goto IL_0b5e;
							}
							object obj17 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v35+E4]");
							bool flag6 = (nint)0 == 0;
							object obj18 = !flag6;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							gameObject3 = Looks(gameObject2);
							if ((object)gameObject3 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C30]");
								object obj19 = 0;
								object obj20 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
								object obj21 = default;
								if (obj21 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v39+18]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v39+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v39+20]");
											if ((nint)0 == 0)
											{
												goto IL_0bff;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v39+20]");
											Bounds bounds = ((Renderer)0).bounds;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v39+18]");
											object obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v39+18]");
											bool flag7 = (nint)0 < (nint)1;
											double num8 = default;
											num7 = num8;
											double num10 = default;
											num9 = num10;
											float num11 = default;
											num3 = num11;
											num12 = 1.0;
											if (flag7)
											{
												goto IL_0611;
											}
											object obj24 = obj21 + 32;
											double num13 = num8;
											double num14 = num10;
											Vector3 vector2 = euler;
											object obj25 = 0;
											float num15 = num11;
											object obj33 = default;
											while (true)
											{
												bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
												object obj26 = !flag8;
												if (obj26 != null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X28_v9+v221 @ X26_v13*8]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X28_v9+v221 @ X26_v13*8]");
													Bounds bounds2 = ((Renderer)0).bounds;
													double num16 = num14 - num13;
													double num17 = num13 + num14;
													double num18 = num10 - num8;
													double num19 = num10 + num8;
													float num20 = (float)euler + num11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v39+18]");
													obj23 = 0;
													float num21 = (float)vector2 - num15;
													obj25++;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													if (!(num16 < num18))
													{
														num16 = num18;
													}
													double num22 = num17 - num18;
													bool flag9 = num22 < 0.0;
													bool flag10 = num22 == 0.0;
													object obj27 = num17 ^ num18;
													object obj28 = num17 ^ num22;
													object obj29 = obj27 & obj28;
													bool flag11 = (nint)obj29 < 0;
													bool flag12 = flag9 == flag11;
													object obj30 = !flag10;
													object obj31 = flag12 & obj30;
													object obj32 = ~obj31;
													if (obj32 == null)
													{
														num18 = num17;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
													double num23 = num18 - num16;
													float num24 = (float)obj33 - num21;
													double num25 = num23 * 0.5;
													float num26 = num24 * 63f;
													double num27 = num16 + num25;
													float num28 = num21 + num26;
													num2 = num27 - num25;
													double num29 = num25 + num27;
													float num30 = num28 - num26;
													float num31 = num26 + num28;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
													if (!(num2 < num19))
													{
														num2 = num19;
													}
													double num32 = num29 - num19;
													bool flag13 = num32 < 0.0;
													bool flag14 = num32 == 0.0;
													object obj34 = num29 ^ num19;
													object obj35 = num29 ^ num32;
													object obj36 = obj34 & obj35;
													bool flag15 = (nint)obj36 < 0;
													bool flag16 = flag13 == flag15;
													object obj37 = !flag14;
													object obj38 = flag16 & obj37;
													object obj39 = ~obj38;
													if (obj39 == null)
													{
														num19 = num29;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
													num6 = num19 - num2;
													double num33 = (double)num26 - num27;
													num7 = num6 * 0.5;
													double num34 = num33 * 63.0;
													num9 = num2 + num7;
													double num35 = num27 + num34;
													bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
													num3 = (float)num34;
													num12 = num27;
													num13 = num7;
													num14 = num9;
													vector2 = (Vector3)num35;
													num15 = (float)num34;
													if (flag17)
													{
														continue;
													}
													goto IL_0611;
												}
												goto IL_0bff;
											}
										}
										goto IL_0c0d;
									}
									object obj40 = obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v40+A0]");
									object obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v41+8]");
									num36 = 0.0;
									num37 = 1.0;
									num12 = 1.0;
									double num38 = 1.0;
									goto IL_0f98;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0bff;
		IL_0611:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj43 = default;
		if (obj43 == null)
		{
			goto IL_0bff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v86+18]");
		if ((nint)0 != 0)
		{
			float num39 = num3 + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v86+18]");
			if ((nint)0 != 1)
			{
				object obj45 = default;
				object obj44 = obj45 + obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v86+18]");
				bool flag18 = (nint)0 < (nint)2;
				object obj46 = !flag18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v86+18]");
				object obj47 = -2;
				bool flag19 = obj47 == null;
				object obj48 = ~obj46;
				object obj49 = obj48 | flag19;
				if (obj49 == null)
				{
					double num40 = num7 + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v86+18]");
					if ((nint)0 != 3)
					{
						_ = 1008981770;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v86+18]");
						if ((nint)0 >= (nint)2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v86+18]");
							object obj50 = 0 & 0xFFFFFFFFL;
							object obj51 = obj43 + 36;
							object obj52 = obj50 - 1;
							float num41 = num39;
							bool flag24;
							do
							{
								obj51 += 4;
								float num42 = (float)obj51 - num41;
								bool flag20 = num42 < 0f;
								bool flag21 = num42 == 0f;
								object obj53 = obj51 ^ num41;
								object obj54 = obj51 ^ num42;
								object obj55 = obj53 & obj54;
								bool flag22 = (nint)obj55 < 0;
								bool flag23 = flag20 == flag22;
								object obj56 = !flag21;
								object obj57 = flag23 & obj56;
								object obj58 = ~obj57;
								if (obj58 == null)
								{
									num41 = (float)obj51;
								}
								obj52--;
								flag24 = (nint)obj52 != 1;
								num39 = num41;
							}
							while (flag24);
						}
						Transform transform3 = gameObject3.transform;
						if ((object)transform3 == null)
						{
							goto IL_0bff;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
						double num38 = 0.0 / (double)num39;
						Vector3 position = transform3.position;
						num36 = num9 - num12;
						num37 = num38;
						object obj20 = 0;
						goto IL_0f98;
					}
				}
			}
		}
		goto IL_0c0d;
		IL_0c0d:
		return (Tile)(object)new IndexOutOfRangeException();
		IL_0bff:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0c0d;
		IL_0b5e:
		if (obj4 != null)
		{
			double num43 = (double)awake - 1.0;
			bool flag25 = num43 < 0.0;
			object obj59 = (double)awake ^ 1.0;
			object obj60 = (double)awake ^ num43;
			object obj61 = obj59 & obj60;
			bool flag26 = (nint)obj61 < 0;
			bool active = flag25 == flag26;
			((GameObject)obj4).SetActive(active);
			return tile;
		}
		goto IL_0bff;
		IL_0f98:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C40]");
		object obj62 = 0;
		GameObject gameObject4 = default;
		gameObject4._002Ector((string)obj62);
		if ((object)gameObject4 != null)
		{
			Transform transform4 = gameObject4.transform;
			if (obj4 != null)
			{
				Transform parent = ((GameObject)obj4).transform;
				if ((object)transform4 != null)
				{
					transform4.SetParent(parent, worldPositionStays: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
					object obj63 = 0;
					GameObject gameObject5 = default;
					gameObject5._002Ector((string)obj63);
					if ((object)gameObject5 != null)
					{
						Transform transform5 = gameObject5.transform;
						if ((object)transform5 != null)
						{
							transform5.SetParent(transform4, worldPositionStays: false);
							Transform transform6 = gameObject3.transform;
							if ((object)transform6 != null)
							{
								transform6.SetParent(transform5, worldPositionStays: false);
								Transform transform7 = gameObject3.transform;
								if ((object)transform7 != null)
								{
									transform7.localRotation = (Quaternion)0;
									Transform transform8 = gameObject3.transform;
									if ((object)transform8 != null)
									{
										object obj64 = obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v31+A0]");
										object obj65 = 0;
										double num44 = num37;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v32+C]");
										double num45 = num44 * 0.0;
										transform8.localScale = (Vector3)0;
										Transform transform9 = gameObject3.transform;
										if ((object)transform9 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
											double num46 = num36 * num37;
											object obj66 = 0.0 - num46;
											object obj67 = default;
											double num47 = num45 * (double)obj67;
											transform9.localPosition = (Vector3)0;
											if (label != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C38]");
												object value = 0;
												if (label.EndsWith((string)value))
												{
													Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
													transform5.localRotation = (Quaternion)0;
												}
												GameObject gameObject6 = transform4.gameObject;
												object obj68 = tile + 24;
												obj68 = gameObject6;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												goto IL_0b5e;
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
		goto IL_0bff;
	}

	private unsafe static GameObject Looks(GameObject prefab)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_009e: Expected Obj, but got Ref
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_04e2: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got I
		//IL_0540: Expected Obj, but got VT
		//IL_07a7: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got I4
		//IL_07ce: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_059f: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_0716: Expected Obj, but got I
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_0742: Expected Obj, but got VT
		//IL_062b: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got I4
		//IL_06f9: Expected Obj, but got Ref
		//IL_03c8: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I
		//IL_0401: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got Ref
		GillaStashSave._003C_003Ec__DisplayClass144_0 obj5 = default;
		object obj8;
		object obj9;
		if ((object)prefab != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C68]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C50]");
			UnityEngine.Object obj3 = (UnityEngine.Object)0;
			string text = prefab.name;
			string text2 = text + (string)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector(text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = prefab.transform;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Material[] array = (Material[])(object)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v18+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v18+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_04d2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C60]");
				object obj11 = 0;
				object obj13 = default;
				object obj12 = obj13;
				object obj14 = 0;
				UnityEngine.Object obj19 = default;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj15 = !flag;
					if (obj15 != null)
					{
						break;
					}
					object obj16 = obj6 + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v19+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
						object obj17 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v20+E4]");
						bool flag2 = (nint)0 == 0;
						object obj18 = !flag2;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag3 = obj19 == null;
						bool flag4 = !flag3;
						object obj20 = !flag4;
						array = null;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v19+20]");
							Mesh sharedMesh = ((MeshFilter)0).sharedMesh;
							object obj21 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v23+E4]");
							bool flag5 = (nint)0 == 0;
							object obj22 = !flag5;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag6 = sharedMesh == null;
							bool flag7 = !flag6;
							object obj23 = !flag7;
							array = null;
							if (obj23 == null)
							{
								if ((object)obj19 == null)
								{
									goto IL_0755;
								}
								bool flag8 = ((Renderer)obj19).enabled;
								bool flag9 = !flag8;
								array = null;
								if (!flag9)
								{
									GameObject gameObject2 = ((Component)obj19).gameObject;
									if ((object)gameObject2 == null)
									{
										goto IL_0755;
									}
									bool activeSelf = gameObject2.activeSelf;
									bool flag10 = !activeSelf;
									array = null;
									if (!flag10)
									{
										GameObject gameObject3 = ((Component)obj19).gameObject;
										if ((object)gameObject3 == null)
										{
											goto IL_0755;
										}
										string text3 = gameObject3.name;
										bool flag11 = text3 == (string)obj11;
										bool flag12 = !flag11;
										object obj24 = !flag12;
										array = null;
										if (obj24 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v19+20]");
											Transform transform2 = ((Component)0).transform;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v19+20]");
											Mesh sharedMesh2 = ((MeshFilter)0).sharedMesh;
											Material[] sharedMaterials = ((Renderer)obj19).sharedMaterials;
											object obj25 = obj9;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v24+E4]");
											bool flag13 = (nint)0 == 0;
											object obj26 = !flag13;
											if (obj26 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											_003CLooks_003Eg__Copy_007C144_0(transform2, sharedMesh2, sharedMaterials, ref obj5);
											obj12 = (object)(&obj5);
											array = sharedMaterials;
										}
									}
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v18+18]");
						obj7 = 0;
						obj14++;
						object obj27 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v18+18]");
						bool flag14 = (nint)obj27 < 0;
						obj13 = obj12;
						if (flag14)
						{
							continue;
						}
						goto IL_04d2;
					}
					goto IL_0755;
				}
				goto IL_0763;
			}
		}
		goto IL_0755;
		IL_0763:
		return (GameObject)(object)new IndexOutOfRangeException();
		IL_0755:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0763;
		IL_0750:
		GameObject result;
		return result;
		IL_04d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C58]");
		object obj28 = 0;
		Material[] array2 = (Material[])obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj29 = default;
		if (obj29 == null)
		{
			goto IL_0755;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v21+18]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v21+18]");
		bool flag15 = (nint)0 < (nint)1;
		result = (GameObject)obj5;
		if (flag15)
		{
			goto IL_0750;
		}
		object obj31 = 0;
		while (true)
		{
			bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
			object obj32 = !flag16;
			if (obj32 != null)
			{
				break;
			}
			object obj33 = obj29 + obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+20]");
				Mesh sharedMesh3 = ((SkinnedMeshRenderer)0).sharedMesh;
				object obj34 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v14+E4]");
				bool flag17 = (nint)0 == 0;
				object obj35 = !flag17;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag18 = sharedMesh3 != null;
				bool flag19 = !flag18;
				array2 = null;
				if (!flag19)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+20]");
					bool flag20 = ((Renderer)0).enabled;
					bool flag21 = !flag20;
					array2 = null;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+20]");
						Transform transform3 = ((Component)0).transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+20]");
						Mesh sharedMesh4 = ((SkinnedMeshRenderer)0).sharedMesh;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+20]");
						Material[] sharedMaterials2 = ((Renderer)0).sharedMaterials;
						object obj36 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v17+E4]");
						bool flag22 = (nint)0 == 0;
						object obj37 = !flag22;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						_003CLooks_003Eg__Copy_007C144_0(transform3, sharedMesh4, sharedMaterials2, ref obj5);
						object obj13 = (object)(&obj5);
						array2 = sharedMaterials2;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v21+18]");
				obj30 = 0;
				obj31++;
				object obj38 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v21+18]");
				bool flag23 = (nint)obj38 < 0;
				result = (GameObject)obj5;
				if (flag23)
				{
					continue;
				}
				goto IL_0750;
			}
			goto IL_0755;
		}
		goto IL_0763;
	}

	private unsafe void ShowTiles(float dt)
	{
		//IL_0016: Expected F4, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0057: Expected F4, but got I
		//IL_0067: Expected Obj, but got I
		//IL_00b4: Invalid comparison between F8 and I4
		//IL_00ce: Expected Obj, but got F8
		//IL_00dd: Expected Obj, but got F8
		//IL_0118: Expected Obj, but got I
		//IL_0a2b: Expected Obj, but got I4
		//IL_0157: Invalid comparison between F8 and I4
		//IL_0171: Expected Obj, but got F8
		//IL_0180: Expected Obj, but got F8
		//IL_01bf: Expected Obj, but got I
		//IL_01fc: Invalid comparison between I and F8
		//IL_0ace: Invalid comparison between F4 and I4
		//IL_0add: Invalid comparison between F4 and I4
		//IL_0af5: Expected Obj, but got F8
		//IL_0b02: Expected Obj, but got F4
		//IL_0b37: Expected Obj, but got I4
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected Obj, but got Unknown
		//IL_0b7d: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_0bc8: Expected Obj, but got I4
		//IL_02a1: Expected F8, but got I
		//IL_0c01: Expected Obj, but got I4
		//IL_02c8: Expected F8, but got I
		//IL_031d: Expected Obj, but got I
		//IL_051e: Expected Obj, but got I4
		//IL_053c: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I
		//IL_055c: Expected F4, but got Obj
		//IL_056c: Expected F8, but got I
		//IL_0579: Expected Obj, but got I8
		//IL_0c7c: Expected Obj, but got I
		//IL_0c8c: Expected F8, but got I
		//IL_0c9c: Expected Obj, but got I4
		//IL_0cd4: Expected Obj, but got I4
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected Ref, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Ref, but got Unknown
		//IL_05cc: Expected VT, but got I4
		//IL_0635: Expected Obj, but got I
		//IL_0a5e: Expected Obj, but got I
		//IL_0a6e: Expected F8, but got I
		//IL_0a7e: Expected Obj, but got I4
		//IL_065a: Expected VT, but got I4
		//IL_04d9: Expected Obj, but got I
		//IL_04e9: Expected F8, but got I
		//IL_04f9: Expected Obj, but got I4
		//IL_0670: Expected Obj, but got I
		//IL_070e: Expected VT, but got I4
		//IL_0724: Expected Obj, but got I
		//IL_0d02: Expected Obj, but got I
		//IL_0d24: Expected Obj, but got I4
		//IL_075e: Expected Obj, but got I4
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_0794: Expected F8, but got I4
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected Obj, but got Unknown
		//IL_08df: Expected VT, but got I4
		//IL_08ef: Expected Obj, but got I
		//IL_0919: Expected Obj, but got I4
		//IL_0948: Expected Obj, but got I
		//IL_0964: Expected VT, but got F8
		//IL_07b7: Invalid comparison between I and F8
		//IL_0993: Expected Obj, but got I
		//IL_09b6: Expected Obj, but got I4
		//IL_09e4: Expected Obj, but got I4
		//IL_0d4c: Expected Obj, but got I4
		//IL_09d6: Expected Obj, but got I4
		//IL_0d97: Expected VT, but got F8
		//IL_0da8: Expected F4, but got I4
		//IL_0db1: Expected F4, but got I4
		//IL_09f2: Expected Obj, but got I4
		List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		float num2 = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float num3 = num2 / 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		int num5 = 0;
		int num6 = 0;
		object obj23 = default;
		Vector3 euler = default;
		object obj39 = default;
		object obj40 = default;
		float num43 = default;
		object obj48;
		do
		{
			if (num6 >= list._size)
			{
				return;
			}
			System.__Canon _Canon = list.get_Item(num6);
			double num7 = (double)awake - 1.0;
			bool flag = num7 < 0.0;
			object obj3 = (double)awake ^ 1.0;
			object obj4 = (double)awake ^ num7;
			object obj5 = obj3 & obj4;
			bool flag2 = (nint)obj5 < 0;
			bool flag3 = flag == flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+10]");
			bool activeSelf = ((GameObject)0).activeSelf;
			if (flag3 != activeSelf)
			{
				double num8 = (double)awake - 1.0;
				bool flag4 = num8 < 0.0;
				object obj6 = (double)awake ^ 1.0;
				object obj7 = (double)awake ^ num8;
				object obj8 = obj6 & obj7;
				bool flag5 = (nint)obj8 < 0;
				bool active = flag4 == flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+10]");
				((GameObject)0).SetActive(active);
			}
			if ((double)awake < 1.0)
			{
				goto IL_09f7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+28]");
			if (0.0 < 1.0)
			{
				dirty = true;
			}
			float num9 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+28]");
			float num10 = num9 + 0f;
			float num11 = num10 - 1f;
			bool flag6 = num11 < 0f;
			bool flag7 = num11 == 0f;
			object obj9 = (double)num10 ^ 1.0;
			object obj10 = num10 ^ num11;
			object obj11 = obj9 & obj10;
			bool flag8 = (nint)obj11 < 0;
			bool flag9 = flag6 == flag8;
			object obj12 = !flag7;
			object obj13 = flag9 & obj12;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				num10 = 1f;
			}
			string text = num5.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
			object obj15 = 0;
			string text2 = (string)obj15 + text;
			bool flag10 = hovered == text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+20]");
			string text3 = (string)0;
			string text4 = selected;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+20]");
			bool flag11 = text4 == (string)0;
			bool flag12 = !flag10;
			object obj16 = !flag12;
			object obj17 = ~obj16;
			double num12;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
				num12 = 0.0;
			}
			else
			{
				num12 = 1.0;
			}
			bool flag13 = !flag11;
			object obj18 = obj;
			object obj19 = !flag13;
			object obj20 = ~obj19;
			double num13;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A96C]");
				num13 = 0.0;
			}
			else
			{
				num13 = num12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v20+E4]");
			bool flag14 = (nint)0 == 0;
			object obj21 = !flag14;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+2C]");
			double num14 = 0.0 - num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+30]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF48]");
			object obj22 = num15 * 0;
			double num16 = num14 * 3274244096.0;
			double num17 = (double)obj22 + num16;
			double num18 = (double)obj23 * num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+30]");
			double num19 = 0.0 + num18;
			double num20 = (double)obj23 * num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+2C]");
			double num21 = 0.0 + num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC15]");
			if ((nint)0 != 0)
			{
				if (flag10)
				{
					goto IL_03d8;
				}
			}
			else
			{
				_ = 1;
				bool flag15 = !flag10;
				object obj24 = !flag15;
				if (obj24 != null)
				{
					goto IL_03d8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v37+A0]");
			object obj27 = 0;
			float w = (float)obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v38+4]");
			double num22 = 0.0;
			object obj28 = 3274244096L;
			goto IL_0caa;
			IL_0caa:
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v23+E4]");
			bool flag16 = (nint)0 == 0;
			object obj30 = !flag16;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Spring2(ref *(Vector2*)(_Canon + 52), ref *(Vector2*)(_Canon + 60), (Vector2)0, w, (float)num22, 11f);
			if (flag11)
			{
				float time = Time.time;
				float num23 = time * 3f;
				float num24 = num23 + (float)num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+10]");
			Transform transform = ((GameObject)0).transform;
			Vector3 vector = ModelAt(num5);
			transform.localPosition = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+10]");
			Transform transform2 = ((GameObject)0).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+38]");
			double num25 = 0.0 * 18.0;
			double num26 = num25 + -22.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+34]");
			double num27 = 0.0 * -18.0;
			double num28 = num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num29 = num28 * 0.0;
			double num30 = num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num31 = num30 * 0.0;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			transform2.localRotation = (Quaternion)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+10]");
			Transform transform3 = ((GameObject)0).transform;
			object obj31 = obj2;
			object obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v25+A0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v41+E4]");
			bool flag17 = (nint)0 == 0;
			object obj34 = !flag17;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+28]");
			bool flag18 = (nint)0 < (nint)0;
			object obj35 = !flag18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+28]");
			bool flag19 = (nint)0 == 0;
			object obj36 = ~obj35;
			object obj37 = obj36 | flag19;
			double num32 = 0.0;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+28]");
				bool flag20 = !(0.0 < 1.0);
				num32 = 1.0;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+28]");
					double num33 = 0.0 * -10.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+28]");
					double num34 = 0.0 * 10.0;
					double num35 = num34 + -0.75;
					double num36 = num35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
					double num37 = num36 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					double num38 = num33 * num37;
					num32 = num38 + 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v26+C]");
			object obj38 = 0 * obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v26+14]");
			double num39 = 0.0 * num32;
			num4 = (float)obj38 * (float)obj40;
			float num40 = (float)num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+2C]");
			float num41 = num40 * 0f;
			transform3.localScale = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj41 = 0;
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X0_v44+E4]");
			bool flag21 = (nint)0 == 0;
			object obj43 = !flag21;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+18]");
			bool flag22 = (UnityEngine.Object)0 != null;
			bool flag23 = !flag22;
			euler = (Vector3)num29;
			float num42 = dt;
			num = num43;
			if (!flag23)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v6 (System.__Canon)+18]");
				Transform transform4 = ((GameObject)0).transform;
				bool flag24 = !flag11;
				object obj44 = !flag24;
				object obj45 = ~obj44;
				object obj46 = ((obj45 != null) ? ((object)1109393408) : ((object)1117782016));
				bool flag25 = !flag10;
				object obj47 = !flag25;
				obj20 = ~obj47;
				if (obj20 == null)
				{
					obj46 = 1124859904;
				}
				num = (float)obj46 * dt;
				transform4.Rotate(0f, num, 0f, (Space)1);
				euler = (Vector3)num29;
				num42 = dt;
				num41 = 0f;
				num4 = 0f;
			}
			goto IL_09f7;
			IL_03d8:
			Vector3 vector2 = ModelAt(num5);
			Vector2 size = Size;
			double num44 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			double num45 = num44 * 0.0;
			double num46 = (double)overAt - num21;
			double num47 = num46 / num45;
			bool flag26 = num47 < -1.0;
			double num48 = -1.0;
			if (!flag26)
			{
				bool flag27 = !(num47 > 1.0);
				num48 = num47;
				if (!flag27)
				{
					num48 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaStash)+170]");
			double num49 = 0.0 - num19;
			double num50 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			num19 = num50 * 0.0;
			num21 = num49 / num19;
			bool flag28 = num21 < -1.0;
			num22 = -1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			num20 = 0.0;
			w = (float)num48;
			text3 = (string)num5;
			if (!flag28)
			{
				if (num21 > 1.0)
				{
					num22 = 1.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num20 = 0.0;
					w = (float)num48;
					text3 = (string)num5;
				}
				else
				{
					num22 = num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num20 = 0.0;
					w = (float)num48;
					text3 = (string)num5;
				}
			}
			goto IL_0caa;
			IL_09f7:
			list = (List<System.__Canon>)(object)tiles;
			num6 = num5 + 1;
			bool flag29 = tiles == null;
			obj48 = !flag29;
			num5 = num6;
		}
		while (obj48 != null);
		throw new NullReferenceException();
	}

	private Vector3 ModelAt(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Size;
	}

	private void Touch(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0f52: Expected Obj, but got I
		//IL_0f62: Expected Obj, but got I
		//IL_0f73: Expected Obj, but got I4
		//IL_0f8d: Expected Obj, but got I4
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_1074: Expected Obj, but got I
		//IL_108c: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_0a25: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_0763: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_0bc3: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_01b2: Expected I, but got Obj
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected Obj, but got Unknown
		//IL_0a70: Expected Obj, but got I4
		//IL_07d5: Expected Obj, but got I4
		//IL_0a94: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I4
		//IL_0ab7: Invalid comparison between F4 and I4
		//IL_10c1: Expected Obj, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_083f: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_0b25: Invalid comparison between F4 and I4
		//IL_0b38: Expected Obj, but got F4
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0b77: Expected Obj, but got I4
		//IL_0856: Expected VT, but got I4
		//IL_0234: Expected VT, but got I4
		//IL_0243: Expected VT, but got I4
		//IL_12aa: Expected Obj, but got I4
		//IL_12c2: Invalid comparison between F4 and I4
		//IL_12e2: Expected Obj, but got I4
		//IL_027f: Invalid comparison between F4 and I4
		//IL_028e: Invalid comparison between F4 and I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02b6: Expected Obj, but got F4
		//IL_02eb: Expected Obj, but got I4
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0bae: Expected F4, but got I4
		//IL_10de: Expected Obj, but got I
		//IL_1108: Expected Obj, but got I4
		//IL_1319: Expected F8, but got I4
		//IL_08cc: Expected Obj, but got I4
		//IL_0905: Expected Obj, but got I4
		//IL_090e: Expected Obj, but got I4
		//IL_0917: Expected Obj, but got I4
		//IL_0fab: Expected Obj, but got I4
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Expected Obj, but got Unknown
		//IL_1368: Expected Obj, but got I
		//IL_0929: Unsupported input type for neg.
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected Obj, but got Unknown
		//IL_093f: Unsupported input type for neg.
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected Obj, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		//IL_0fdf: Invalid comparison between F4 and I
		//IL_03b4: Invalid comparison between F4 and I4
		//IL_0975: Expected Obj, but got I
		//IL_1016: Expected Obj, but got I4
		//IL_1135: Expected Obj, but got I
		//IL_1161: Expected Obj, but got I
		//IL_1188: Expected F4, but got I
		//IL_11a8: Invalid comparison between F4 and I4
		//IL_11b7: Invalid comparison between F4 and I4
		//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d2: Expected Obj, but got Unknown
		//IL_11df: Expected Obj, but got F8
		//IL_1214: Expected Obj, but got I4
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Expected Obj, but got Unknown
		//IL_03dd: Invalid comparison between F4 and I
		//IL_09d4: Expected F8, but got I
		//IL_05ea: Expected Obj, but got I4
		//IL_1241: Invalid comparison between I4 and F8
		//IL_1253: Expected F4, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected Obj, but got Unknown
		//IL_0d01: Invalid comparison between F4 and I4
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_062e: Expected Obj, but got I4
		//IL_065a: Expected I, but got Obj
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0420: Expected VT, but got F4
		//IL_067a: Expected Obj, but got I4
		//IL_064d: Expected I, but got Obj
		//IL_058e: Expected Obj, but got I4
		//IL_0de3: Expected VT, but got I4
		//IL_0df2: Expected VT, but got I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		//IL_04cb: Expected Obj, but got I4
		//IL_05bb: Expected Obj, but got I4
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_04fb: Expected Obj, but got I
		//IL_0e3a: Expected VT, but got F4
		//IL_0e67: Expected Obj, but got I4
		//IL_0f08: Expected I4, but got I8
		//IL_0eaa: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B00]");
		object obj3 = 0;
		string text = (string)obj;
		object obj4 = 32;
		int num = 0;
		float num2 = dt;
		object obj5 = 17276928;
		float num3;
		object obj51 = default;
		object obj53 = default;
		object obj66 = default;
		float num21 = default;
		object obj83 = default;
		object obj85 = default;
		float num6 = default;
		while (true)
		{
			Transform[] array = fingertips;
			bool flag = fingertips == null;
			num3 = num2;
			string text2;
			bool flag19;
			object obj11;
			if (!flag)
			{
				obj5 = array.Length;
				bool flag2 = num >= array.Length;
				num3 = num2;
				if (!flag2)
				{
					bool flag3 = num < array.Length;
					object obj6 = !flag3;
					if (obj6 != null)
					{
						goto IL_0f2d;
					}
					object obj7 = obj2;
					object obj8 = fingertips + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v79+E4]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v79+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v61+20]");
					bool flag5 = (UnityEngine.Object)0 == null;
					bool flag6 = !flag5;
					object obj10 = !flag6;
					num3 = num2;
					obj11 = 0;
					nint num4 = unchecked((nint)null);
					if (obj10 == null)
					{
						object obj12 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v83+E4]");
						bool flag7 = (nint)0 == 0;
						object obj13 = !flag7;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = tileRoot == null;
						bool flag9 = !flag8;
						object obj14 = !flag9;
						num3 = num2;
						obj11 = 0;
						num4 = unchecked((nint)null);
						if (obj14 == null)
						{
							Transform[] array2 = fingertips;
							bool flag10 = num < array2.Length;
							object obj15 = !flag10;
							if (obj15 == null)
							{
								object obj16 = array2 + num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v64+20]");
								Vector3 position = ((Transform)0).position;
								Vector3 vector = tileRoot.InverseTransformPoint((Vector3)0);
								Vector2Int at = ToPixel((Vector3)0);
								text2 = Hit(at);
								float num5 = num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF44]");
								float num7 = num5 - 0f;
								bool flag11 = num7 < 0f;
								bool flag12 = num7 == 0f;
								float num8 = num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF44]");
								object obj17 = num8 ^ 0;
								object obj18 = num6 ^ num7;
								object obj19 = obj17 & obj18;
								bool flag13 = (nint)obj19 < 0;
								bool flag14 = flag11 == flag13;
								object obj20 = !flag12;
								object obj21 = flag14 & obj20;
								object obj22 = ~obj21;
								bool flag15;
								bool flag16;
								bool flag17;
								if (obj22 == null)
								{
									flag15 = text2._stringLength < 0;
									flag16 = text2._stringLength == 0;
									int num9 = text2._stringLength ^ text2._stringLength;
									int num10 = text2._stringLength & num9;
									flag17 = num10 < 0;
								}
								else
								{
									flag17 = false;
									flag16 = true;
									flag15 = false;
								}
								bool flag18 = flag15 == flag17;
								object obj23 = !flag16;
								object obj24 = flag18 & obj23;
								object obj25 = ~obj24;
								if (obj25 == null)
								{
									float num11 = num6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
									float num12 = num11 - 0f;
									flag19 = num12 < 0f;
								}
								else
								{
									flag19 = false;
								}
								float num13 = num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC4C]");
								if (num13 > 0f)
								{
									float num14 = num6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
									if (num14 < 0f && text2._stringLength >= 1)
									{
										overAt = (Vector3)num2;
										text = text2;
									}
								}
								bool flag20 = !flag19;
								num3 = num2;
								obj11 = 0;
								if (flag20)
								{
									goto IL_05c0;
								}
								bool[] array3 = down;
								bool flag21 = num < array3.Length;
								object obj26 = !flag21;
								if (obj26 == null)
								{
									object obj27 = array3 + num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v71+20]");
									if ((nint)0 != 0)
									{
										string[] array4 = downOn;
										bool flag22 = num < array4.Length;
										object obj28 = !flag22;
										if (obj28 != null)
										{
											goto IL_0f2d;
										}
										object obj29 = array4 + num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v76+20]");
										if (!(text2 != (string)0) || !(text2 != (string)obj3))
										{
											goto IL_055d;
										}
									}
									Press(text2, num);
									goto IL_055d;
								}
							}
							goto IL_0f2d;
						}
					}
				}
			}
			goto IL_06b6;
			IL_0f2d:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			throw new NullReferenceException();
			IL_05c0:
			bool[] array5 = down;
			bool flag23 = num < array5.Length;
			object obj30 = !flag23;
			if (obj30 == null)
			{
				object obj31 = array5 + num;
				bool flag24 = !flag19;
				string[] array6 = downOn;
				object obj32 = !flag24;
				object obj33 = ~obj32;
				if (obj33 == null)
				{
					nint num4 = (nint)text2;
				}
				else
				{
					nint num4 = (nint)obj;
				}
				bool flag25 = num < array6.Length;
				object obj34 = !flag25;
				if (obj34 == null)
				{
					obj5 = array6 + num;
					object obj35 = (object)array6 + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_06b6;
				}
			}
			goto IL_0f2d;
			IL_055d:
			bool flag26 = text2 == (string)obj3;
			bool flag27 = !flag26;
			num3 = num2;
			obj11 = 0;
			if (!flag27)
			{
				Hold(dt, num);
				num3 = dt;
				obj11 = 0;
			}
			goto IL_05c0;
			IL_06b6:
			num++;
			obj4 += 8;
			bool flag28 = num != 2;
			num2 = num3;
			if (flag28)
			{
				continue;
			}
			bool isDeviceActive = XRSettings.isDeviceActive;
			bool flag29 = !isDeviceActive;
			object obj36 = !flag29;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj37 = 0;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v21+A0]");
				object obj39 = 0;
				if (obj39 != null)
				{
					Camera main = Camera.main;
					object obj40 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v24+E4]");
					bool flag30 = (nint)0 == 0;
					object obj41 = !flag30;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (main != null)
					{
						object obj42 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v26+E4]");
						bool flag31 = (nint)0 == 0;
						object obj43 = !flag31;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (tileRoot != null)
						{
							Camera main2 = Camera.main;
							object obj44 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v28+A0]");
							object obj45 = 0;
							object obj46 = obj45;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v30+188]");
							Vector2 vector2 = ((InputControl<Vector2>)0).ReadValue();
							Ray ray = main2.ScreenPointToRay((Vector3)0);
							Vector3 forward = tileRoot.forward;
							Vector3 position2 = tileRoot.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj47 = 0;
							object obj48 = obj47;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v42+E4]");
							bool flag32 = (nint)0 == 0;
							object obj49 = !flag32;
							if (obj49 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj50 = obj51 * obj51;
							object obj52 = obj53 * obj53;
							object obj54 = obj50 + obj52;
							object obj55 = 0 * 0;
							object obj56 = obj55 + obj54;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							bool flag33 = (nint)obj56 <= 0;
							object obj57 = 0;
							object obj58 = 0;
							object obj59 = 0;
							if (!flag33)
							{
								object obj60 = 0 - obj51;
								obj59 = obj60 / obj56;
								object obj61 = 0 - obj53;
								obj58 = obj61 / obj56;
								obj57 = 0 / obj56;
							}
							object obj62 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v42+A0]");
							object obj63 = 0;
							object obj64 = obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v44+1C0]");
							bool isPressed = ((ButtonControl)0).isPressed;
							object obj65 = obj66 * obj59;
							object obj67 = obj53 * obj58;
							object obj68 = obj65 + obj67;
							object obj69 = obj51 * obj57;
							object obj70 = obj68 + obj69;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
							object obj71 = 0;
							object obj72 = obj71;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X8_v49+A0]");
							object obj73 = 0;
							double num15 = (double)obj69;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
							double num16 = num15 * 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v50+4]");
							num6 = 0f;
							float num17 = (float)num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v50+4]");
							float num18 = num17 - 0f;
							bool flag34 = num18 < 0f;
							bool flag35 = num18 == 0f;
							double num19 = num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v50+4]");
							object obj74 = num19 ^ 0;
							object obj75 = num16 ^ (double)num18;
							object obj76 = obj74 & obj75;
							bool flag36 = (nint)obj76 < 0;
							bool flag37 = flag34 == flag36;
							object obj77 = !flag35;
							object obj78 = flag37 & obj77;
							object obj79 = ~obj78;
							if (obj79 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v50+4]");
								num16 = 0.0;
							}
							bool flag38 = !(0.0 < num16);
							num3 = 0f;
							if (flag38)
							{
								object obj80 = obj51 * obj59;
								object obj81 = obj53 * obj58;
								float num20 = num21 * (float)obj59;
								object obj82 = obj83 * obj58;
								object obj84 = obj80 + obj81;
								num6 = num20 + (float)obj82;
								float num22 = (float)obj85 * (float)obj57;
								object obj86 = 0 * obj57;
								object obj87 = obj84 + obj86;
								num16 = (double)num6 + (double)num22;
								double num23 = (double)obj87 - num16;
								num3 = (float)num23 / (float)obj70;
								bool flag39 = !(num3 > 0f);
								object obj88 = obj83;
								object obj89 = obj85;
								float num24 = num21;
								if (!flag39)
								{
									bool flag40 = !((double)num3 < 6.0);
									obj88 = obj83;
									obj89 = obj85;
									num24 = num21;
									num16 = 6.0;
									if (!flag40)
									{
										float num25 = (float)obj51 * num3;
										num22 = (float)obj53 * num3;
										float num26 = (float)obj66 * num3;
										num6 = (float)obj85 + num25;
										num16 = (double)obj83 + (double)num22;
										num3 = num21 + num26;
										Vector3 vector3 = tileRoot.InverseTransformPoint((Vector3)0);
										Vector2Int at2 = ToPixel((Vector3)0);
										string text3 = Hit(at2);
										if (text3._stringLength >= 1)
										{
											overAt = (Vector3)num3;
											text = text3;
										}
										bool flag41 = !isPressed;
										obj88 = obj83;
										obj89 = obj85;
										num24 = num21;
										if (!flag41)
										{
											bool flag42 = (byte)(~(mouseDown ? 1u : 0u)) != 0;
											object obj90 = !flag42;
											if (obj90 == null && text3._stringLength >= 1)
											{
												Press(text3, -1);
											}
											bool flag43 = text3 == (string)obj3;
											bool flag44 = !flag43;
											obj88 = obj83;
											obj89 = obj85;
											num24 = num21;
											if (!flag44)
											{
												Hold(dt, -1);
												obj88 = obj83;
												obj89 = obj85;
												num24 = num21;
												num3 = dt;
											}
										}
									}
								}
							}
							mouseDown = isPressed;
						}
					}
				}
			}
			bool[] array7 = down;
			if (array7.Length != 0)
			{
				bool flag45 = (byte)(~(array7[0] ? 1u : 0u)) != 0;
				object obj91 = !flag45;
				if (obj91 != null)
				{
					break;
				}
				if (array7.Length != 1)
				{
					bool flag46 = (byte)(~(array7[1] ? 1u : 0u)) != 0;
					object obj92 = !flag46;
					if (obj92 != null)
					{
						break;
					}
					bool flag47 = (byte)(~(mouseDown ? 1u : 0u)) != 0;
					object obj93 = !flag47;
					if (obj93 != null)
					{
						break;
					}
					num3 = holdFill;
					if (holdFill > 0f)
					{
						dirty = true;
						float num24 = dt * 3f;
						float num27 = dt * 3f;
						num6 = 0f - num27;
						float num22 = 0f - holdFill;
						bool flag48 = num22 < 0f;
						object obj94 = num22 ^ num22;
						object obj95 = num22 & obj94;
						bool flag49 = (nint)obj95 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
						bool flag50 = flag48 == flag49;
						object obj96 = !flag50;
						object obj97 = ~obj96;
						if (obj97 != null)
						{
							num6 = num24;
						}
						bool flag51 = num22 < num24;
						object obj98 = !flag51;
						float num28 = num22 - num24;
						bool flag52 = num28 == 0f;
						num3 += num6;
						object obj99 = !flag52;
						object obj100 = obj98 & obj99;
						object obj101 = ~obj100;
						if (obj101 != null)
						{
							num3 = 0f;
						}
						holdFill = num3;
						double num16 = 0.0;
					}
					break;
				}
			}
			goto IL_0f2d;
		}
		if (text != hovered)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
			object value = 0;
			bool flag53 = text.StartsWith((string)value);
			bool flag54 = !flag53;
			double num29 = num3;
			if (!flag54)
			{
				Play(hoverSound, 0.25f);
				num29 = 0.25;
			}
			object obj102 = this + 344;
			hovered = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			dirty = true;
		}
	}

	private string Hit(Vector2Int at)
	{
		//IL_0399: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_04e1: Expected Obj, but got I
		//IL_04fe: Expected VT, but got I
		//IL_04fe: Expected VT, but got I
		//IL_02cd: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I
		//IL_040b: Expected VT, but got I
		//IL_0428: Expected VT, but got I
		//IL_0428: Expected VT, but got I
		//IL_0443: Expected I, but got VT
		//IL_044b: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00bb: Expected VT, but got Obj
		//IL_00d7: Expected VT, but got I8
		//IL_00f5: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		//IL_048b: Expected VT, but got I
		//IL_04a8: Expected VT, but got I
		//IL_04a8: Expected VT, but got I
		//IL_04c3: Expected I, but got VT
		//IL_025e: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0145: Expected Obj, but got I4
		//IL_014d: Expected I, but got VT
		//IL_015a: Expected VT, but got I8
		//IL_0162: Expected I, but got VT
		//IL_016f: Expected VT, but got I8
		//IL_0177: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		List<Tile> list = tiles;
		object obj;
		GillaStash gillaStash;
		nint num;
		Vector2Int vector2Int2;
		nint num2 = default;
		Vector2Int vector2Int;
		if (tiles != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
			obj = 0;
			vector2Int = at;
			object obj2 = 10;
			object obj3 = 0;
			gillaStash = this;
			int num3 = default;
			while ((nint)obj3 < list._size)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v31+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj3 * 2863311531L;
				object obj7 = obj6 >> 33;
				object obj8 = obj7 * 306;
				RectInt r = (RectInt)(obj2 - obj8);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
				bool flag2 = Inside(r, (Vector2Int)515396075616L);
				bool flag3 = !flag2;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					list = tiles;
					obj3++;
					obj2 += 102;
					bool flag4 = tiles == null;
					object obj10 = !flag4;
					num = (nint)at;
					vector2Int2 = (Vector2Int)515396075616L;
					num2 = (nint)at;
					vector2Int = (Vector2Int)515396075616L;
					gillaStash = (GillaStash)flag2;
					if (obj10 != null)
					{
						continue;
					}
					goto IL_0185;
				}
				string text = num3.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
				object obj11 = 0;
				return (string)obj11 + text;
			}
			goto IL_01ab;
		}
		num = num2;
		vector2Int2 = at;
		obj = 109891584;
		goto IL_0185;
		IL_01ab:
		int pages = gillaStash.Pages;
		bool flag5 = pages < 2;
		GillaStash gillaStash2 = (GillaStash)pages;
		object result;
		if (!flag5)
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v23+A0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20+38]");
			vector2Int = (Vector2Int)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20+30]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20+38]");
			bool flag7 = Inside((RectInt)num4, (Vector2Int)0);
			bool flag8 = !flag7;
			num2 = (nint)at;
			gillaStash2 = (GillaStash)flag7;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C70]");
				result = 0;
				goto IL_0459;
			}
		}
		int pages2 = gillaStash2.Pages;
		if (pages2 >= 2)
		{
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v17+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v17+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v16+48]");
			vector2Int = (Vector2Int)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v16+40]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v16+48]");
			bool flag10 = Inside((RectInt)num5, (Vector2Int)0);
			bool flag11 = !flag10;
			num2 = (nint)at;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C78]");
				result = 0;
				goto IL_0459;
			}
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v11+E4]");
		bool flag12 = (nint)0 == 0;
		object obj19 = !flag12;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v11+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v10+20]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v10+28]");
		if (Inside((RectInt)num6, (Vector2Int)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B00]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			result = 0;
		}
		goto IL_0459;
		IL_0459:
		return (string)result;
		IL_0185:
		NullReferenceException ex = new NullReferenceException();
		num2 = num;
		vector2Int = vector2Int2;
		gillaStash = (GillaStash)(object)ex;
		goto IL_01ab;
	}

	private void Press(string thing, int finger)
	{
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I
		//IL_0215: Expected I4, but got I8
		//IL_022f: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		//IL_00a9: Expected F4, but got I
		//IL_00be: Expected Obj, but got I
		//IL_0270: Expected F4, but got I
		//IL_0270: Expected F4, but got I
		//IL_012f: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_016b: Expected I4, but got I8
		object obj = this + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B00]");
		object obj2 = 0;
		pressedThing = thing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		dirty = true;
		pressFlash = 0.15f;
		int num = (int)(finger & 0x80000000L);
		bool flag = num == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			bool flag2 = finger == 0;
			object obj4 = !flag2;
			object obj5 = ~obj4;
			XRNode node = ((obj5 != null) ? ((XRNode)4) : ((XRNode)5));
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			UnityEngine.XR.InputDevice inputDevice = default;
			bool flag3 = inputDevice.SendHapticImpulse(0u, num2, 0f);
		}
		bool flag4 = thing == (string)obj2;
		bool flag5 = !flag4;
		object obj6 = !flag5;
		if (obj6 != null)
		{
			return;
		}
		AudioClip clip = clickSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		Play(clip, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
		object value = 0;
		if (thing.StartsWith((string)value))
		{
			string s = thing.Substring(4);
			int i = int.Parse(s);
			Pick(i);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C70]");
		object obj7 = 0;
		int num3;
		if (thing == (string)obj7)
		{
			num3 = -1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C78]");
			object obj8 = 0;
			if (!(thing == (string)obj8))
			{
				return;
			}
			num3 = 1;
		}
		Turn(num3);
	}

	public void Pick(int i)
	{
		//IL_0166: Expected I4, but got I8
		//IL_0180: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		int num = (int)(i & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
		if (list._size > i)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A88]");
			object obj2 = 0;
			System.__Canon _Canon = list.get_Item(i);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6 (System.__Canon)+30]");
			double num2 = 0.0 + 9.0;
			System.__Canon _Canon2 = ((List<System.__Canon>)(object)tiles).get_Item(i);
			string text = selected;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8 (System.__Canon)+20]");
			if (text != (string)0)
			{
				holdFill = 0f;
			}
			System.__Canon _Canon3 = ((List<System.__Canon>)(object)tiles).get_Item(i);
			object obj3 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v12 (System.__Canon)+20]");
			selected = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = this + 336;
			banner = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			dirty = true;
		}
	}

	public void Turn(int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected I4, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected I4, but got Unknown
		//IL_0148: Expected Obj, but got I4
		//IL_0155: Expected I4, but got Obj
		//IL_0181: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0051: Expected I4, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		int pages = Pages;
		object obj2 = page + by;
		int num = obj2 / pages;
		object obj3 = num * pages;
		object obj4 = obj2 - obj3;
		object obj5 = obj4 + pages;
		int num2 = obj5 / pages;
		object obj6 = obj;
		object obj7 = num2 * pages;
		int num3 = obj5 - obj7;
		page = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<string> list = Kinds();
		object obj9 = page + page;
		int num4 = obj9 << 1;
		if (num4 < list._size)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83C0]");
			object obj10 = 0;
			System.__Canon _Canon = ((List<System.__Canon>)(object)list).get_Item(num4);
			selected = (string)(object)_Canon;
			object obj11 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		holdFill = 0f;
		MakeTiles();
		dirty = true;
	}

	private void Hold(float dt, int finger)
	{
		//IL_0029: Expected Obj, but got I4
		//IL_00cf: Invalid comparison between F4 and I4
		//IL_00de: Invalid comparison between F4 and I4
		//IL_00f6: Expected Obj, but got F8
		//IL_0103: Expected Obj, but got F4
		//IL_0138: Expected Obj, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_029b: Invalid comparison between F4 and I4
		//IL_019b: Expected I4, but got I8
		//IL_01b5: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(selected);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		int num = GillaStashSave.CountOf(selected);
		if (num < 1)
		{
			return;
		}
		float time = Time.time;
		if (!(time < nextEject))
		{
			float num2 = dt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num3 = num2 / 0f;
			float num4 = num3 + holdFill;
			float num5 = num4 - 1f;
			bool flag3 = num5 < 0f;
			bool flag4 = num5 == 0f;
			object obj2 = (double)num4 ^ 1.0;
			object obj3 = num4 ^ num5;
			object obj4 = obj2 & obj3;
			bool flag5 = (nint)obj4 < 0;
			bool flag6 = flag3 == flag5;
			object obj5 = !flag4;
			object obj6 = flag6 & obj5;
			object obj7 = ~obj6;
			if (obj7 == null)
			{
				num4 = 1f;
			}
			holdFill = num4;
			if (holdFill == 0f)
			{
				Play(fillSound, 0.5f);
			}
			int num6 = (int)(finger & 0x80000000L);
			bool flag7 = num6 == 0;
			object obj8 = !flag7;
			if (obj8 == null)
			{
				bool flag8 = finger == 0;
				object obj9 = !flag8;
				object obj10 = ~obj9;
				XRNode node = ((obj10 != null) ? ((XRNode)4) : ((XRNode)5));
				UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
				float num7 = holdFill;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num8 = num7 * 0f;
				float duration = dt * 1.5f;
				float num9 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				float amplitude = num9 + 0f;
				UnityEngine.XR.InputDevice inputDevice = default;
				bool flag9 = inputDevice.SendHapticImpulse(0u, amplitude, duration);
			}
			dirty = true;
			if ((double)holdFill < 1.0 && !((double)holdFill < 1.0))
			{
				bool flag10 = Eject();
				holdFill = 0f;
			}
		}
	}

	private void Say(string s, bool bad)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		banner = s;
		object obj = this + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bannerBad = bad;
		float time = Time.time;
		dirty = true;
		float num = time + 2.5f;
		bannerUntil = num;
	}

	private void Play(AudioClip clip, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_01e3: Expected VT, but got I4
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
		if (!(clip != null))
		{
			return;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(screen != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj7 = array + 32;
			obj7 = clip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)screen != null)
			{
				Transform transform = screen.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v23+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float pitchMin = default;
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Lamps(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0344: Invalid comparison between F4 and I4
		//IL_0357: Expected Obj, but got F4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0396: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_03de: Invalid comparison between F4 and I4
		//IL_0400: Expected Obj, but got I4
		//IL_003d: Expected F4, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_009d: Expected I4, but got I8
		//IL_00b7: Expected Obj, but got I4
		//IL_0156: Invalid comparison between F4 and I4
		//IL_0165: Expected F8, but got I4
		//IL_0499: Invalid comparison between F8 and I4
		//IL_04b8: Invalid comparison between F4 and I4
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_04f1: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_02d2: Expected VT, but got I4
		//IL_0201: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		float num = dt * 1.5f;
		float num2 = dt * 1.5f;
		float num3 = 0f - num2;
		float num4 = 0f - flash;
		bool flag = num4 < 0f;
		object obj3 = num4 ^ num4;
		object obj4 = num4 & obj3;
		bool flag2 = (nint)obj4 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag3 = flag == flag2;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num3 = num;
		}
		bool flag4 = num4 < num;
		object obj7 = !flag4;
		float num5 = num4 - num;
		bool flag5 = num5 == 0f;
		float num6 = flash + num3;
		object obj8 = !flag5;
		object obj9 = obj7 & obj8;
		object obj10 = ~obj9;
		float num7 = ((obj10 != null) ? 0f : num6);
		flash = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = body == null;
		bool flag8 = !flag7;
		object obj12 = !flag8;
		if (obj12 != null)
		{
			return;
		}
		int num8 = (int)(lampSlot & 0x80000000L);
		bool flag9 = num8 == 0;
		object obj13 = !flag9;
		if (obj13 != null)
		{
			return;
		}
		float time = Time.time;
		float num9 = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
		float num10 = num9 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float time2 = Time.time;
		float num11 = time2 * 6f;
		float num12 = num11 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num13 = num12 + num12;
		float num14 = num11 - num13;
		bool flag10 = num14 < 0f;
		double num15 = 0.0;
		if (!flag10)
		{
			bool flag11 = !((double)num14 > 2.0);
			num15 = num14;
			if (!flag11)
			{
				num15 = 2.0;
			}
		}
		double num16 = num15 + -1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num17 = 1.0 - num16;
		object obj14;
		if (((num17 < 0.0 || !(num17 > 1.0)) && work < 0f) || !((double)work > 1.0))
		{
			obj14 = this + 240;
			bool flag12 = obj14 == null;
			object obj15 = !flag12;
			if (obj15 != null)
			{
				goto IL_0230;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MaterialPropertyBlock materialPropertyBlock = default;
		materialPropertyBlock._002Ector();
		obj14 = materialPropertyBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_0230;
		IL_0230:
		body.GetPropertyBlock(lampBlock, lampSlot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v13+E4]");
		bool flag13 = (nint)0 == 0;
		object obj19 = !flag13;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj20 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v14+A0]");
		object obj21 = 0;
		MaterialPropertyBlock materialPropertyBlock2 = lampBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15+54]");
		materialPropertyBlock2.SetColor(0, (Color)0);
		body.SetPropertyBlock(lampBlock, lampSlot);
	}

	private unsafe static void Spring(ref float p, ref float v, float target, float w, float z, float dt)
	{
		//IL_00cc: Expected Ref, but got F4
		//IL_00e8: Expected Ref, but got F4
		float num = z * -2f;
		float num2 = p - target;
		float num3 = num * w;
		float num4 = w * w;
		float num5 = num3 * v;
		float num6 = num4 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		float num7 = num5 - num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num8 = 0f * num7;
		float num9 = v + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num10 = 0f * num9;
		ref float reference = ref *(float*)num9;
		float num11 = p + num10;
		ref float reference2 = ref *(float*)num11;
	}

	private unsafe static void Spring2(ref Vector2 p, ref Vector2 v, Vector2 target, float w, float z, float dt)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		object obj = p - w;
		object obj3 = default;
		object obj2 = v * obj3;
		object obj5 = default;
		object obj4 = obj * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		object obj6 = obj2 - obj4;
		object obj7 = obj6 * obj5;
		object obj8 = v + obj7;
		object obj9 = obj8 * obj5;
		ref Vector2 reference = ref *(Vector2*)obj8;
		object obj10 = p + obj9;
		ref Vector2 reference2 = ref *(Vector2*)obj10;
	}

	private static float Elastic(float k)
	{
		//IL_0009: Invalid comparison between F4 and I4
		//IL_001a: Expected Obj, but got I4
		//IL_0023: Invalid comparison between F4 and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0048: Expected F4, but got I4
		bool flag = k < 0f;
		object obj = !flag;
		bool flag2 = k == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		float result = 0f;
		if (obj3 == null)
		{
			bool flag3 = !((double)k < 1.0);
			result = 1f;
			if (!flag3)
			{
				float num = k * -10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				float num2 = k * 10f;
				float num3 = num2 + -0.75f;
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				float num5 = num4 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				float num6 = num * num5;
				result = num6 + 1f;
			}
		}
		return result;
	}

	private void Draw()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected Obj, but got Unknown
		//IL_0623: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_02b2: Invalid comparison between F4 and I4
		//IL_02c3: Invalid comparison between F4 and I4
		//IL_0641: Expected Obj, but got I
		//IL_0313: Expected F8, but got I4
		//IL_06ae: Expected Obj, but got I
		//IL_06d8: Expected Obj, but got I4
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_0535: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_072a: Expected Obj, but got I
		//IL_094d: Expected Obj, but got I4
		//IL_0926: Expected Obj, but got I4
		//IL_098a: Expected Obj, but got I
		//IL_0998: Expected VT, but got Obj
		//IL_09bb: Expected VT, but got I8
		//IL_09de: Expected F4, but got I4
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_090f: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_08d0: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_08b5: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		dirty = false;
		if (px == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tex == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (screen == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 512, 288);
		float num = awake;
		object obj11;
		Color32[] array = default;
		object obj17 = default;
		double num4;
		int num5;
		bool flag9;
		int num3;
		Color32[] array2;
		if ((double)awake < 1.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
			obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj11;
			}
			if (array != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v23+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v24+68]");
				_ = 0;
				object obj15 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v26+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A30]");
				object s = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v27+68]");
				_ = 0;
				Text(title, 256, 132, (string)s, array, 3, centred: true);
				double num2 = awake;
				bool flag7 = awake < 0f;
				bool flag8 = !(awake > 0f);
				flag9 = true;
				num3 = 3;
				array2 = array;
				num4 = 1.0;
				num5 = 132;
				if (flag8)
				{
					goto IL_059f;
				}
				double num6 = 0.0;
				if (!flag7)
				{
					bool flag10 = !((double)awake > 1.0);
					num6 = awake;
					if (!flag10)
					{
						num6 = 1.0;
					}
				}
				double num7 = num6 + num6;
				double num8 = num6 * 3.0;
				double num9 = num6 * num7;
				double num10 = num6 * num9;
				double num11 = num6 * num8;
				double num12 = num11 - num10;
				num2 = 1.0 - num12;
				double num13 = num2 * 0.0;
				double num14 = num12 + num13;
				num4 = num14 * 1133510656.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7F0");
				DrawUi();
				if ((nint)obj17 > 287)
				{
					goto IL_04c0;
				}
				object obj18 = 146944 - obj17;
				object obj19 = obj17;
				while (true)
				{
					object obj20 = 0;
					while (true)
					{
						object obj21 = obj11;
						Color32[] array3 = px;
						object obj22 = obj19 & 1;
						bool flag11 = obj22 == null;
						object obj23 = !flag11;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v50+E4]");
							bool flag12 = (nint)0 == 0;
							object obj24 = !flag12;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj21 = obj11;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v50+A0]");
							object obj25 = (nint)0 + (nint)88;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v50+E4]");
							bool flag13 = (nint)0 == 0;
							object obj26 = !flag13;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj21 = obj11;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v50+A0]");
							object obj25 = (nint)0 + (nint)92;
						}
						if (px == null)
						{
							break;
						}
						object obj27 = obj18 + obj20;
						bool flag14 = (nint)obj27 < array3.Length;
						object obj28 = !flag14;
						if (obj28 == null)
						{
							object obj29 = (object)px + obj27;
							obj20++;
							if ((nint)obj20 != 512)
							{
								continue;
							}
							goto IL_0484;
						}
						goto IL_0782;
					}
					break;
					IL_0484:
					obj19++;
					obj18 -= 512;
					if ((nint)obj19 != 288)
					{
						continue;
					}
					goto IL_04c0;
				}
			}
			goto IL_0774;
		}
		DrawUi();
		num4 = 1.0;
		num5 = 0;
		goto IL_059f;
		IL_059f:
		if ((object)tex != null)
		{
			tex.SetPixels32(px);
			if ((object)tex != null)
			{
				tex.Apply(updateMipmaps: true);
				object obj30 = this + 232;
				bool flag15 = obj30 == null;
				object obj31 = !flag15;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					obj30 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				if ((object)screen != null)
				{
					screen.GetPropertyBlock((MaterialPropertyBlock)obj30);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
					object obj33 = 0;
					object obj34 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v23+E4]");
					bool flag16 = (nint)0 == 0;
					object obj35 = !flag16;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj30 != null)
					{
						object obj36 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v16+A0]");
						object obj37 = 0;
						object obj38 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17+50]");
						((MaterialPropertyBlock)obj38).SetTexture(0, (Texture)tex);
						if ((object)screen != null)
						{
							screen.SetPropertyBlock((MaterialPropertyBlock)obj30);
							return;
						}
					}
				}
			}
		}
		goto IL_0774;
		IL_04c0:
		object obj39 = obj11;
		object obj40 = obj17 - 286;
		bool flag17 = (nint)obj40 < 0;
		object obj41 = obj17 ^ 0x11E;
		object obj42 = obj17 ^ obj40;
		object obj43 = obj41 & obj42;
		bool flag18 = (nint)obj43 < 0;
		bool flag19 = flag17 == flag18;
		object obj44 = !flag19;
		object obj45 = ~obj44;
		object obj46 = ((obj45 != null) ? ((object)286) : obj17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v42+E4]");
		bool flag20 = (nint)0 == 0;
		object obj47 = !flag20;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj39 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v42+A0]");
		object obj48 = 0;
		RectInt r = (RectInt)(obj46 << 32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v32+60]");
		num5 = 0;
		FillRect(r, (Color32)8589935104L);
		flag9 = true;
		num3 = 3;
		array2 = array;
		num = 1.1335107E+09f;
		goto IL_059f;
		IL_0782:
		throw new IndexOutOfRangeException();
		IL_0774:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0782;
	}

	private void DrawUi()
	{
		//IL_0010: Expected Obj, but got I
		//IL_2537: Expected Obj, but got I
		//IL_2559: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_2577: Expected Obj, but got I
		//IL_25a7: Expected Obj, but got I
		//IL_25de: Expected Obj, but got I
		//IL_25ee: Expected Obj, but got I
		//IL_2610: Expected Obj, but got I4
		//IL_3110: Expected Obj, but got I
		//IL_314d: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_2677: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I4
		//IL_31cd: Expected Obj, but got I4
		//IL_265c: Expected Obj, but got I
		//IL_02ca: Expected I4, but got Obj
		//IL_02e8: Expected Obj, but got I
		//IL_0339: Expected I4, but got Obj
		//IL_0491: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I4
		//IL_039f: Expected I4, but got Obj
		//IL_26f6: Expected VT, but got I8
		//IL_26f6: Expected VT, but got I8
		//IL_270e: Expected Obj, but got I
		//IL_271e: Expected Obj, but got I
		//IL_274e: Expected Obj, but got I
		//IL_2766: Expected Obj, but got I
		//IL_2776: Expected Obj, but got I
		//IL_27a6: Expected Obj, but got I
		//IL_0515: Expected Obj, but got I
		//IL_0525: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I4
		//IL_27bb: Expected Obj, but got I
		//IL_27d1: Expected VT, but got I
		//IL_27d1: Expected VT, but got Obj
		//IL_27fb: Expected Obj, but got I4
		//IL_0616: Expected Obj, but got I
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_063a: Expected Obj, but got I
		//IL_0647: Expected VT, but got Obj
		//IL_065d: Expected VT, but got I
		//IL_0401: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I4
		//IL_2833: Expected Obj, but got I4
		//IL_06ad: Expected VT, but got I4
		//IL_0e28: Expected Obj, but got I
		//IL_0e38: Expected Obj, but got I
		//IL_0e50: Expected Obj, but got I
		//IL_0e60: Expected Obj, but got I
		//IL_0e70: Expected Obj, but got I
		//IL_0e92: Expected Obj, but got I4
		//IL_0ec7: Expected Obj, but got I
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Expected I4, but got Unknown
		//IL_0f19: Expected Obj, but got I
		//IL_0f31: Expected Obj, but got I
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Expected I4, but got Unknown
		//IL_0f83: Expected Obj, but got I
		//IL_06db: Expected VT, but got I4
		//IL_0fa0: Expected Obj, but got I
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected I4, but got Unknown
		//IL_0ff2: Expected Obj, but got I
		//IL_100a: Expected Obj, but got I
		//IL_1013: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Expected I4, but got Unknown
		//IL_105c: Expected Obj, but got I
		//IL_108b: Expected Obj, but got I
		//IL_109b: Expected Obj, but got I
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a9: Expected I4, but got Unknown
		//IL_0713: Expected Obj, but got I4
		//IL_28b5: Expected I4, but got Obj
		//IL_075a: Expected Obj, but got I4
		//IL_1904: Expected Obj, but got I4
		//IL_078f: Expected Obj, but got I
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected I4, but got Unknown
		//IL_07fa: Expected Obj, but got I
		//IL_0828: Expected Obj, but got I
		//IL_11ed: Expected Obj, but got I4
		//IL_0845: Expected Obj, but got I
		//IL_0862: Expected Obj, but got I
		//IL_2cb8: Expected Obj, but got I4
		//IL_2cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc5: Expected Obj, but got Unknown
		//IL_28d3: Expected Obj, but got I
		//IL_28f1: Expected VT, but got I
		//IL_28f1: Expected VT, but got I
		//IL_2901: Expected Obj, but got I
		//IL_2923: Expected Obj, but got I
		//IL_2933: Expected Obj, but got I
		//IL_2943: Expected Obj, but got I
		//IL_2953: Expected Obj, but got I
		//IL_2988: Expected Obj, but got I
		//IL_2988: Expected VT, but got I
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected I4, but got Unknown
		//IL_08b4: Expected Obj, but got I
		//IL_08e2: Expected Obj, but got I
		//IL_122a: Expected VT, but got I4
		//IL_1233: Expected VT, but got I4
		//IL_123c: Expected VT, but got I4
		//IL_1256: Expected I4, but got Obj
		//IL_08ff: Invalid comparison between VT and I4
		//IL_0915: Expected Obj, but got I
		//IL_1997: Expected Obj, but got I
		//IL_1abb: Expected Obj, but got I4
		//IL_128d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1292: Expected Obj, but got Unknown
		//IL_12c0: Expected Obj, but got I
		//IL_12d0: Expected Obj, but got I
		//IL_12e0: Expected Obj, but got I
		//IL_131d: Expected Obj, but got I
		//IL_131d: Expected VT, but got I
		//IL_0be9: Invalid comparison between VT and I4
		//IL_0971: Expected Obj, but got I4
		//IL_132b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Expected Obj, but got Unknown
		//IL_1356: Expected Obj, but got I
		//IL_1376: Expected VT, but got I4
		//IL_1399: Expected I4, but got Obj
		//IL_10e6: Expected Obj, but got I4
		//IL_0ac7: Expected Obj, but got I4
		//IL_09b8: Expected Obj, but got I4
		//IL_1cec: Expected Obj, but got I4
		//IL_1728: Expected Obj, but got I4
		//IL_112d: Expected Obj, but got I4
		//IL_0c1f: Expected Obj, but got I4
		//IL_0b0e: Expected Obj, but got I4
		//IL_09ed: Expected Obj, but got I
		//IL_09fd: Expected Obj, but got I
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected I4, but got Unknown
		//IL_0a4f: Expected Obj, but got I
		//IL_0a4f: Expected Obj, but got VT
		//IL_0a69: Expected Obj, but got VT
		//IL_2d21: Expected Obj, but got I
		//IL_2d31: Expected Obj, but got I
		//IL_1a36: Expected Obj, but got I4
		//IL_175d: Expected Obj, but got I
		//IL_177f: Expected Obj, but got I4
		//IL_1162: Expected Obj, but got I
		//IL_1172: Expected Obj, but got I
		//IL_1182: Expected VT, but got I
		//IL_1192: Expected Obj, but got I
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected I4, but got Unknown
		//IL_0c66: Expected Obj, but got I4
		//IL_0b43: Expected Obj, but got I
		//IL_0b53: Expected Obj, but got I
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b61: Expected I4, but got Unknown
		//IL_0ba5: Expected Obj, but got I
		//IL_1b47: Expected Obj, but got I4
		//IL_1c04: Expected Obj, but got I4
		//IL_17b4: Expected Obj, but got I
		//IL_17c4: Expected Obj, but got I
		//IL_2bd3: Expected Obj, but got I4
		//IL_2849: Expected I4, but got VT
		//IL_0c9b: Expected Obj, but got I
		//IL_0cab: Expected Obj, but got I
		//IL_0cbb: Expected VT, but got I
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Expected I4, but got Unknown
		//IL_0d0b: Expected Obj, but got I
		//IL_0d23: Expected Obj, but got I
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected I4, but got Unknown
		//IL_1e34: Expected VT, but got Obj
		//IL_1e56: Expected Obj, but got I4
		//IL_1c4b: Expected Obj, but got I4
		//IL_1a81: Expected I4, but got Obj
		//IL_1a92: Expected I4, but got Obj
		//IL_1800: Expected Obj, but got I
		//IL_0d77: Expected Obj, but got I
		//IL_0d87: Expected Obj, but got I
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected I4, but got Unknown
		//IL_0dde: Expected Obj, but got I
		//IL_0dee: Expected Obj, but got I
		//IL_2dea: Expected Obj, but got I
		//IL_2dfa: Expected F8, but got VT
		//IL_1d26: Invalid comparison between F4 and I4
		//IL_1d41: Expected VT, but got I4
		//IL_1d49: Expected VT, but got Obj
		//IL_1c80: Expected Obj, but got I
		//IL_1c90: Expected VT, but got I
		//IL_1cad: Expected Obj, but got I
		//IL_185a: Expected Obj, but got I
		//IL_186a: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Expected Obj, but got Unknown
		//IL_1897: Expected Obj, but got I4
		//IL_140d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1412: Expected Obj, but got Unknown
		//IL_1429: Expected Obj, but got I
		//IL_1437: Expected VT, but got F4
		//IL_1442: Invalid comparison between F4 and I4
		//IL_1454: Expected VT, but got I4
		//IL_1464: Expected VT, but got I
		//IL_337a: Expected Obj, but got I4
		//IL_2d4b: Expected VT, but got Obj
		//IL_2d6d: Expected Obj, but got I4
		//IL_18d9: Expected Obj, but got I
		//IL_1f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f64: Expected Obj, but got Unknown
		//IL_1f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f72: Expected Obj, but got Unknown
		//IL_1f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f80: Expected Obj, but got Unknown
		//IL_1f8d: Expected VT, but got Obj
		//IL_1f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9b: Expected Obj, but got Unknown
		//IL_1fa8: Expected VT, but got Obj
		//IL_1fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb6: Expected Obj, but got Unknown
		//IL_32ed: Expected Obj, but got I
		//IL_1d81: Expected Obj, but got I4
		//IL_2bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bef: Expected I4, but got Unknown
		//IL_2bff: Expected Obj, but got I
		//IL_2c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c14: Expected I4, but got Unknown
		//IL_2c42: Expected Obj, but got I
		//IL_2c4c: Expected VT, but got I4
		//IL_2c55: Expected VT, but got I4
		//IL_2c5e: Expected VT, but got I4
		//IL_2c6e: Expected Obj, but got I
		//IL_2c9a: Expected I4, but got Obj
		//IL_18c4: Expected Obj, but got I
		//IL_15e7: Expected Obj, but got I4
		//IL_1489: Expected Obj, but got I
		//IL_14a5: Expected VT, but got I4
		//IL_14b5: Expected VT, but got I
		//IL_203c: Expected Obj, but got I4
		//IL_2a74: Expected Obj, but got I
		//IL_15a0: Expected Obj, but got I4
		//IL_2e7b: Expected Obj, but got I
		//IL_1ff5: Expected Obj, but got I4
		//IL_330a: Expected Obj, but got I
		//IL_3334: Expected Obj, but got I4
		//IL_31f9: Expected VT, but got I
		//IL_31f9: Expected VT, but got I
		//IL_3223: Expected Obj, but got I4
		//IL_2a59: Expected Obj, but got I
		//IL_14ed: Expected Obj, but got I4
		//IL_33f5: Expected Obj, but got I
		//IL_342d: Expected Obj, but got I4
		//IL_2e60: Expected Obj, but got I
		//IL_1dca: Invalid comparison between F4 and I4
		//IL_1534: Expected Obj, but got I4
		//IL_2081: Unknown result type (might be due to invalid IL or missing references)
		//IL_2086: Expected Obj, but got Unknown
		//IL_16a9: Expected Obj, but got I4
		//IL_299d: Expected Obj, but got I
		//IL_29b3: Expected Obj, but got I
		//IL_29cd: Expected Obj, but got I8
		//IL_29e7: Expected Obj, but got I
		//IL_2a0e: Expected VT, but got I8
		//IL_2a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a20: Expected VT, but got Unknown
		//IL_2a3e: Expected VT, but got I
		//IL_210c: Expected Obj, but got I4
		//IL_2aaa: Expected Obj, but got I
		//IL_1662: Expected Obj, but got I4
		//IL_2eb1: Expected Obj, but got I
		//IL_20c5: Expected Obj, but got I4
		//IL_2e3c: Expected Obj, but got I4
		//IL_3265: Expected Obj, but got I
		//IL_3275: Unknown result type (might be due to invalid IL or missing references)
		//IL_327a: Expected Obj, but got Unknown
		//IL_329f: Expected Obj, but got I
		//IL_32c0: Expected Obj, but got I4
		//IL_2a8f: Expected Obj, but got I
		//IL_3444: Invalid comparison between VT and I4
		//IL_3457: Expected Obj, but got VT
		//IL_345f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3464: Expected Obj, but got Unknown
		//IL_348c: Expected Obj, but got I4
		//IL_2e96: Expected Obj, but got I
		//IL_3398: Expected Obj, but got I
		//IL_33a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a5: Expected VT, but got Unknown
		//IL_33c2: Expected VT, but got Obj
		//IL_33e0: Expected Obj, but got I
		//IL_2da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dac: Expected Obj, but got Unknown
		//IL_2dc6: Expected Obj, but got I4
		//IL_16f9: Expected VT, but got I
		//IL_2abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac4: Expected I4, but got Unknown
		//IL_2acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad2: Expected I4, but got Unknown
		//IL_2b00: Expected Obj, but got I
		//IL_2b10: Expected Obj, but got I
		//IL_2b68: Expected Obj, but got I
		//IL_2ba4: Expected Obj, but got I
		//IL_2bac: Expected Obj, but got I4
		//IL_16e4: Expected VT, but got I
		//IL_2ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec3: Expected I4, but got Unknown
		//IL_2ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed1: Expected I4, but got Unknown
		//IL_2f07: Expected Obj, but got I
		//IL_2f31: Expected Obj, but got I4
		//IL_213a: Unknown result type (might be due to invalid IL or missing references)
		//IL_213f: Expected VT, but got Unknown
		//IL_21ad: Expected Obj, but got I
		//IL_2f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4d: Expected Obj, but got Unknown
		//IL_2198: Expected Obj, but got I
		//IL_2287: Expected Obj, but got I
		//IL_22a9: Expected Obj, but got I4
		//IL_22d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_22dc: Expected I4, but got Unknown
		//IL_22ec: Expected Obj, but got I
		//IL_22fc: Expected Obj, but got I
		//IL_21c2: Expected Obj, but got I
		//IL_21d2: Expected Obj, but got I
		//IL_21f4: Expected Obj, but got I4
		//IL_2f7a: Expected Obj, but got I
		//IL_2f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f88: Expected I4, but got Unknown
		//IL_2fb6: Expected Obj, but got I
		//IL_2fe0: Expected Obj, but got I4
		//IL_2252: Expected Obj, but got I4
		//IL_2345: Expected Obj, but got I4
		//IL_2ffe: Expected Obj, but got I
		//IL_3007: Unknown result type (might be due to invalid IL or missing references)
		//IL_300c: Expected I4, but got Unknown
		//IL_301c: Expected Obj, but got I
		//IL_302c: Expected Obj, but got I
		//IL_238c: Expected Obj, but got I4
		//IL_305b: Expected Obj, but got I
		//IL_3073: Expected VT, but got I8
		//IL_3073: Expected VT, but got I8
		//IL_241a: Expected Obj, but got I4
		//IL_30c5: Expected Obj, but got I
		//IL_23d3: Expected Obj, but got I4
		//IL_34fe: Expected VT, but got I8
		//IL_34fe: Expected VT, but got I8
		//IL_3528: Expected Obj, but got I4
		//IL_30aa: Expected Obj, but got I
		//IL_24f2: Expected Obj, but got I4
		//IL_30fb: Expected Obj, but got I
		//IL_24ab: Expected Obj, but got I4
		//IL_30e0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A30]");
		object obj5 = 0;
		GillaBoardLook.Frame(px, 512, 288, 3);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+A0]");
		object obj8 = 0;
		ScreenFont font = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v5+78]");
		Text(font, 10, 6, (string)obj5, (Color32[])0, 2, centred: false);
		int num4;
		if (title != null)
		{
			int num = title.Measure((string)obj5, 2);
			int num2 = 0;
			int num3 = 2;
			ScreenFont screenFont = (ScreenFont)obj5;
			num4 = num;
		}
		else
		{
			int num2 = 6;
			int num3 = 10;
			ScreenFont screenFont = title;
			num4 = 80;
		}
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CC0]");
		object s = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v11+A0]");
		object obj12 = 0;
		int x = num4 + 22;
		ScreenFont font2 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v7+88]");
		Text(font2, x, 11, (string)s, (Color32[])0, 1, centred: false);
		int count = GillaStashSave.Count;
		int num5 = default;
		string text = num5.ToString();
		int num6 = default;
		string text2 = num6.ToString();
		string text3 = (string)obj10;
		string text4 = text + (string)obj10 + text2;
		ScreenFont screenFont2;
		int num8;
		if (this.text != null)
		{
			int num7 = this.text.Measure(text4, 2);
			screenFont2 = this.text;
			object obj13 = 0;
			string text5 = (string)2;
			text3 = text4;
			num8 = num7;
		}
		else
		{
			screenFont2 = null;
			object obj13 = 0;
			string text5 = text2;
			num8 = 40;
		}
		object obj14 = obj3;
		object obj16;
		if (num5 > 39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v311+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v311+A0]");
			obj16 = (nint)0 + (nint)144;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v311+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v311+A0]");
			obj16 = (nint)0 + (nint)120;
		}
		Color32[] array = (Color32[])obj16;
		int x2 = 502 - num8;
		Text(screenFont2, x2, 7, text4, (Color32[])obj16, 2, centred: false);
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v26+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<string> list = Kinds();
		bool flag7 = (object)list == null;
		int num9 = 0;
		bool flag8 = false;
		int num10 = 2;
		num6 = 40;
		string text6 = text4;
		int num11 = 7;
		int num12 = (int)screenFont2;
		if (flag7)
		{
			goto IL_045c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj20 = 0;
		bool flag9 = list._size == 0;
		num9 = 0;
		flag8 = false;
		num10 = 2;
		num6 = 40;
		text6 = text4;
		num11 = 7;
		num12 = (int)screenFont2;
		if (!flag9)
		{
			List<Tile> list2 = tiles;
			bool flag10 = tiles == null;
			num9 = 0;
			flag8 = false;
			num10 = 2;
			num6 = 40;
			text6 = text4;
			num11 = 7;
			num12 = (int)screenFont2;
			if (flag10)
			{
				goto IL_045c;
			}
			ScreenFont screenFont3 = screenFont2;
			int num13 = 0;
			while (true)
			{
				bool flag11 = num13 >= list2._size;
				num9 = 0;
				Color32[] array2 = array;
				bool flag12 = false;
				int num14 = 2;
				num6 = 40;
				string text7 = text4;
				int num15 = 7;
				if (flag11)
				{
					break;
				}
				DrawTile(num13);
				list2 = tiles;
				int num16 = num13 + 1;
				bool flag13 = tiles == null;
				object obj21 = !flag13;
				num9 = 0;
				flag8 = false;
				num10 = 2;
				num6 = 40;
				text6 = text4;
				num11 = 7;
				num12 = num13;
				screenFont3 = (ScreenFont)num13;
				num13 = num16;
				if (obj21 != null)
				{
					continue;
				}
				goto IL_045c;
			}
		}
		else
		{
			object obj22 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v295+E4]");
			bool flag14 = (nint)0 == 0;
			object obj23 = !flag14;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj24 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v298+E4]");
			bool flag15 = (nint)0 == 0;
			object obj25 = !flag15;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj3;
			}
			Outline((RectInt)128849018890L, (Color32)1056561955116L);
			object obj26 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v209+A0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CC8]");
			object s2 = 0;
			ScreenFont font3 = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v210+78]");
			Text(font3, 160, 119, (string)s2, (Color32[])0, 2, centred: true);
			object obj28 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v211+A0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CF8]");
			object s3 = 0;
			ScreenFont font4 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v212+78]");
			Text(font4, 160, 155, (string)s3, (Color32[])0, 1, centred: true);
			object obj30 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v213+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C98]");
			object obj32 = 0;
			ScreenFont screenFont3 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v214+88]");
			Color32[] array2 = (Color32[])0;
			string text7 = (string)obj32;
			ScreenFont font5 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v214+88]");
			Text(font5, 160, 169, (string)obj32, (Color32[])0, 1, centred: true);
			bool flag12 = true;
			int num14 = 1;
			int num15 = 169;
			x2 = 160;
		}
		object obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v30+E4]");
		bool flag16 = (nint)0 == 0;
		object obj34 = !flag16;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v30+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v14+8]");
		Outline((RectInt)obj35, (Color32)0);
		object obj36 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v32+E4]");
		bool flag17 = (nint)0 == 0;
		object obj37 = !flag17;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj38 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v16+A0]");
		object obj39 = 0;
		object obj40 = obj39 + 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v17+4]");
		object obj41 = (nint)0 + (nint)3;
		RectInt rectInt = (RectInt)(obj40 | obj41);
		RectInt r = rectInt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v17+8]");
		Outline(r, (Color32)0);
		int num18;
		Color32[] array5;
		ScreenFont screenFont6;
		RectInt rectInt2 = default;
		(RectInt, System.__Canon, System.__Canon) tuple2 = default;
		if (selected != null)
		{
			int num17 = GillaStashSave.CountOf(selected);
			bool flag18 = selected == null;
			num18 = num17;
			rectInt = (RectInt)0;
			if (!flag18)
			{
				bool flag19 = num17 < 1;
				num18 = num17;
				rectInt = (RectInt)0;
				if (!flag19)
				{
					object obj42 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v242+E4]");
					bool flag20 = (nint)0 == 0;
					object obj43 = !flag20;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj44 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v244+E4]");
					bool flag21 = (nint)0 == 0;
					object obj45 = !flag21;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj46 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v167+A0]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v168+8]");
					int width = (int)(-16);
					string s4 = Fit(selected, width, 2);
					object obj48 = obj3;
					int x3 = obj47 + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v168+4]");
					int y = (int)((nint)0 + (nint)8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v169+A0]");
					object obj49 = 0;
					ScreenFont font6 = this.text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v170+80]");
					Text(font6, x3, y, s4, (Color32[])0, 2, centred: false);
					object obj50 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v171+A0]");
					object obj51 = 0;
					string text8 = num18.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D18]");
					object obj52 = 0;
					string text9 = (string)obj52 + text8;
					object obj53 = obj3;
					int num19 = obj51 + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v172+4]");
					int num20 = (int)((nint)0 + (nint)32);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X8_v176+A0]");
					object obj54 = 0;
					ScreenFont font7 = this.text;
					int x4 = num19;
					int y2 = num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v177+78]");
					Text(font7, x4, y2, text9, (Color32[])0, 1, centred: false);
					(string, string, int) tuple = About(selected);
					bool flag22 = tuple2 == ((RectInt, System.__Canon, System.__Canon))(object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v177+78]");
					Color32[] array3 = (Color32[])0;
					bool flag23 = false;
					int num21 = 1;
					string text10 = text9;
					ScreenFont screenFont4 = this.text;
					if (!flag22)
					{
						object obj55 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ X0_v282+E4]");
						bool flag24 = (nint)0 == 0;
						object obj56 = !flag24;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj57 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X0_v284+E4]");
						bool flag25 = (nint)0 == 0;
						object obj58 = !flag25;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj59 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v203+A0]");
						object obj60 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v204+78]");
						array3 = (Color32[])0;
						num19 = obj60 + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v204+4]");
						num20 = (int)((nint)0 + (nint)46);
						ScreenFont font8 = this.text;
						int x5 = num19;
						int y3 = num20;
						(RectInt, System.__Canon, System.__Canon) tuple3 = tuple2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v204+78]");
						Text(font8, x5, y3, (string)tuple3, (Color32[])0, 1, centred: false);
						flag23 = false;
						num21 = 1;
						text10 = (string)tuple2;
						screenFont4 = this.text;
					}
					string text11 = default;
					bool flag26 = text11 == null;
					Color32[] array4 = array3;
					if (!flag26)
					{
						object obj61 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X0_v275+E4]");
						bool flag27 = (nint)0 == 0;
						object obj62 = !flag27;
						if (obj62 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj63 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X0_v277+E4]");
						bool flag28 = (nint)0 == 0;
						object obj64 = !flag28;
						if (obj64 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj65 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v199+A0]");
						object obj66 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ X8_v200+78]");
						array4 = (Color32[])0;
						num19 = obj66 + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ X8_v200+4]");
						num20 = (int)((nint)0 + (nint)58);
						ScreenFont font9 = this.text;
						int x6 = num19;
						int y4 = num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ X8_v200+78]");
						Text(font9, x6, y4, text11, (Color32[])0, 1, centred: false);
						flag23 = false;
						num21 = 1;
						text10 = text11;
						screenFont4 = this.text;
					}
					object obj67 = obj3;
					ScreenFont screenFont5 = this.text;
					(RectInt, System.__Canon, System.__Canon) tuple4 = default;
					if (tuple4 >= (object)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X0_v258+E4]");
						bool flag29 = (nint)0 == 0;
						object obj68 = !flag29;
						if (obj68 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj69 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v267+E4]");
						bool flag30 = (nint)0 == 0;
						object obj70 = !flag30;
						if (obj70 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj71 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X8_v188+A0]");
						object obj72 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D00]");
						object s5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ X8_v189+4]");
						rectInt2 = (RectInt)0;
						int x7 = obj72 + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ X8_v189+4]");
						int y5 = (int)((nint)0 + (nint)76);
						ScreenFont font10 = screenFont5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ X8_v189+88]");
						Text(font10, x7, y5, (string)s5, (Color32[])0, 1, centred: false);
						object obj73 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ X8_v190+A0]");
						object obj74 = 0;
						int x8 = obj74 + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X8_v191+4]");
						int y6 = (int)((nint)0 + (nint)88);
						BoltIcon(x8, y6, 1);
						object obj75 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X8_v193+A0]");
						object obj76 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
						object obj77 = 0;
						screenFont5 = this.text;
						string text12 = num9.ToString((string)obj77);
						object obj78 = obj3;
						x2 = obj76 + 20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X8_v194+4]");
						num11 = (int)((nint)0 + (nint)88);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X8_v195+A0]");
						object obj79 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X8_v196+A0]");
						array5 = (Color32[])0;
						text6 = text12;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X0_v258+E4]");
						bool flag31 = (nint)0 == 0;
						object obj80 = !flag31;
						if (obj80 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj81 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X0_v262+E4]");
						bool flag32 = (nint)0 == 0;
						object obj82 = !flag32;
						if (obj82 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj83 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X8_v185+A0]");
						object obj84 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CF0]");
						object obj85 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X8_v186+4]");
						rectInt2 = (RectInt)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X8_v186+88]");
						array5 = (Color32[])0;
						text6 = (string)obj85;
						x2 = obj84 + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X8_v186+4]");
						num11 = (int)((nint)0 + (nint)80);
					}
					num9 = (int)tuple4;
					screenFont6 = screenFont5;
					goto IL_2856;
				}
			}
		}
		else
		{
			num18 = 0;
		}
		object obj86 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v230+E4]");
		bool flag33 = (nint)0 == 0;
		object obj87 = !flag33;
		if (obj87 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CB8]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CE8]");
		object obj89 = 0;
		object obj90 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D08]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CA0]");
		object s6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CD0]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v232+E4]");
		bool flag34 = (nint)0 == 0;
		object obj92 = !flag34;
		if (obj92 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj93 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v154+A0]");
		object obj94 = 0;
		int x9 = obj94 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v155+4]");
		int y7 = (int)((nint)0 + (nint)10);
		ScreenFont font11 = this.text;
		object s7 = obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v155+80]");
		Text(font11, x9, y7, (string)s7, (Color32[])0, 1, centred: false);
		object obj95 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v156+A0]");
		object obj96 = 0;
		int x10 = obj96 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v157+4]");
		int y8 = (int)((nint)0 + (nint)24);
		ScreenFont font12 = this.text;
		object s8 = obj89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v157+78]");
		Text(font12, x10, y8, (string)s8, (Color32[])0, 1, centred: false);
		object obj97 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v158+A0]");
		object obj98 = 0;
		int x11 = obj98 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v159+4]");
		int y9 = (int)((nint)0 + (nint)44);
		ScreenFont font13 = this.text;
		object s9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v159+78]");
		Text(font13, x11, y9, (string)s9, (Color32[])0, 1, centred: false);
		object obj99 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v160+A0]");
		object obj100 = 0;
		int x12 = obj100 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v161+4]");
		int y10 = (int)((nint)0 + (nint)58);
		ScreenFont font14 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v161+78]");
		Text(font14, x12, y10, (string)s6, (Color32[])0, 1, centred: false);
		object obj101 = obj3;
		screenFont6 = this.text;
		text6 = (string)obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v162+A0]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v163+78]");
		array5 = (Color32[])0;
		x2 = obj102 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v163+4]");
		num11 = (int)((nint)0 + (nint)72);
		goto IL_2856;
		IL_3342:
		RectInt r2;
		Color32 color = default;
		Outline(r2, color);
		object obj103 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X0_v44+E4]");
		bool flag35 = (nint)0 == 0;
		object obj104 = !flag35;
		if (obj104 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj105 = obj3;
		object obj107 = default;
		object obj106 = obj107 + 2;
		object obj108 = color - 4;
		object obj110 = default;
		object obj109 = obj110 - 4;
		Color32 c = (Color32)(obj108 | obj109);
		object obj112;
		object obj111 = obj112 + 2;
		RectInt r3 = (RectInt)(obj111 | obj106);
		object obj114;
		object obj113 = obj114 & 1;
		if (obj113 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X0_v112+E4]");
			bool flag36 = (nint)0 == 0;
			object obj115 = !flag36;
			if (obj115 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj105 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X0_v112+A0]");
			object obj116 = (nint)0 + (nint)100;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X0_v112+E4]");
			bool flag37 = (nint)0 == 0;
			object obj117 = !flag37;
			if (obj117 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj105 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X0_v112+A0]");
			object obj116 = (nint)0 + (nint)104;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CB0]");
		object s10 = 0;
		Outline(r3, c);
		object obj118 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X0_v49+E4]");
		bool flag38 = (nint)0 == 0;
		object obj119 = !flag38;
		if (obj119 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj120 = obj3;
		object obj121 = obj114 & 1;
		object colours;
		if (obj121 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ X0_v105+E4]");
			bool flag39 = (nint)0 == 0;
			object obj122 = !flag39;
			if (obj122 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj120 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ X0_v105+A0]");
			colours = (nint)0 + (nint)120;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ X0_v105+E4]");
			bool flag40 = (nint)0 == 0;
			object obj123 = !flag40;
			if (obj123 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj120 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ X0_v105+A0]");
			colours = (nint)0 + (nint)144;
		}
		bool flag41 = color < (object)0;
		object obj124 = color ^ color;
		object obj125 = color & obj124;
		bool flag42 = (nint)obj125 < 0;
		bool flag43 = flag41 == flag42;
		object obj126 = !flag43;
		object obj127 = ~obj126;
		Color32 color2 = ((obj127 != null) ? color : ((Color32)(color + 1)));
		int num22 = (int)(obj112 + color2);
		int y11 = obj107 + 24;
		Text(title, num22, y11, (string)s10, (Color32[])colours, 2, centred: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj128 = 0;
		object obj129 = obj128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2000 @ X0_v54+E4]");
		bool flag44 = (nint)0 == 0;
		object obj130 = !flag44;
		if (obj130 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj131 = obj3;
		object obj132;
		if (num5 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CD8]");
			obj132 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CA8]");
			obj132 = 0;
		}
		object obj133 = obj114 & 1;
		object obj134;
		int y13;
		Color32[] colours2;
		string s12;
		int x13;
		ScreenFont font16;
		if (obj133 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CE0]");
			object s11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			obj134 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ X0_v92+E4]");
			bool flag45 = (nint)0 == 0;
			object obj135 = !flag45;
			if (obj135 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj131 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ X0_v92+A0]");
			object obj136 = 0;
			int y12 = obj107 + 56;
			ScreenFont font15 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2030 @ X8_v62+78]");
			Text(font15, num22, y12, (string)s11, (Color32[])0, 1, centred: true);
			object obj137 = obj134;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2049 @ X0_v94+E4]");
			bool flag46 = (nint)0 == 0;
			object obj138 = !flag46;
			if (obj138 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj139 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2087 @ X0_v97+E4]");
			bool flag47 = (nint)0 == 0;
			object obj140 = !flag47;
			if (obj140 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj139 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2087 @ X0_v97+A0]");
			object obj141 = 0;
			y13 = obj107 + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CF0]");
			object obj142 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2075 @ X8_v65+88]");
			colours2 = (Color32[])0;
			s12 = (string)obj142;
			x13 = num22;
			font16 = this.text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			obj134 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ X0_v92+E4]");
			bool flag48 = (nint)0 == 0;
			object obj143 = !flag48;
			if (obj143 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj144 = obj3;
			y13 = obj107 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2041 @ X8_v60+A0]");
			object obj145 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2047 @ X8_v61+90]");
			colours2 = (Color32[])0;
			s12 = (string)obj132;
			x13 = num22;
			font16 = this.text;
		}
		Text(font16, x13, y13, s12, colours2, 1, centred: true);
		if (banner == null)
		{
			return;
		}
		object obj146 = obj134;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2090 @ X0_v59+E4]");
		bool flag49 = (nint)0 == 0;
		object obj147 = !flag49;
		if (obj147 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj148 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2117 @ X0_v62+E4]");
		bool flag50 = (nint)0 == 0;
		object obj149 = !flag50;
		if (obj149 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj148 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2117 @ X0_v62+A0]");
		object obj150 = 0;
		FillRect((RectInt)609885356052L, (Color32)103079215384L);
		object obj151 = obj3;
		if (~(bannerBad ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2140 @ X0_v80+E4]");
			bool flag51 = (nint)0 == 0;
			object obj152 = !flag51;
			if (obj152 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj151 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2140 @ X0_v80+A0]");
			object obj153 = (nint)0 + (nint)112;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2140 @ X0_v80+E4]");
			bool flag52 = (nint)0 == 0;
			object obj154 = !flag52;
			if (obj154 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj151 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2140 @ X0_v80+A0]");
			object obj153 = (nint)0 + (nint)96;
		}
		Outline((RectInt)609885356052L, (Color32)103079215384L);
		object obj155 = obj134;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2153 @ X0_v67+E4]");
		bool flag53 = (nint)0 == 0;
		object obj156 = !flag53;
		if (obj156 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string s13 = Fit(banner, 270, 1);
		object obj157 = obj3;
		object colours3;
		if (~(bannerBad ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v48+E4]");
			bool flag54 = (nint)0 == 0;
			object obj158 = !flag54;
			if (obj158 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj157 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v48+A0]");
			colours3 = (nint)0 + (nint)144;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v48+E4]");
			bool flag55 = (nint)0 == 0;
			object obj159 = !flag55;
			if (obj159 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj157 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v48+A0]");
			colours3 = (nint)0 + (nint)128;
		}
		Text(this.text, 160, 148, s13, (Color32[])colours3, 1, centred: true);
		return;
		IL_2e04:
		object obj160 = obj3;
		object obj161 = obj110 << 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1910 @ X0_v136+E4]");
		bool flag56 = (nint)0 == 0;
		object obj162 = !flag56;
		if (obj162 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj160 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1910 @ X0_v136+A0]");
		object obj163 = 0;
		double num23;
		Color32 c2 = (Color32)(obj161 | num23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1591 @ X9_v32+64]");
		num11 = 0;
		RectInt r4 = (RectInt)(obj112 | obj107);
		FillRect(r4, c2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		obj20 = 0;
		goto IL_2d36;
		IL_2d36:
		object obj164 = obj3;
		r2 = (RectInt)(obj112 | obj107);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ X0_v125+E4]");
		bool flag57 = (nint)0 == 0;
		object obj165 = !flag57;
		if (obj165 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj164 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ X0_v125+A0]");
		object obj166 = (nint)0 + (nint)96;
		object obj167 = obj112;
		goto IL_3342;
		IL_045c:
		throw new NullReferenceException();
		IL_2856:
		Text(screenFont6, x2, num11, text6, array5, 1, centred: false);
		int pages = Pages;
		bool flag58 = pages < 2;
		array = array5;
		flag8 = false;
		num10 = 1;
		num12 = (int)screenFont6;
		(RectInt, System.__Canon, System.__Canon) tuple5 = default;
		if (!flag58)
		{
			object obj168 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X0_v166+E4]");
			bool flag59 = (nint)0 == 0;
			object obj169 = !flag59;
			if (obj169 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj168 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X0_v166+A0]");
			object obj170 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v107+10]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v107+18]");
			Outline((RectInt)num24, (Color32)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C80]");
			object obj171 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj172 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72B0]");
			object obj173 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C70]");
			object obj174 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X8_v110+A0]");
			object obj175 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C88]");
			object obj176 = 0;
			text6 = (string)obj174;
			array = (Color32[])obj176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v111+30]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v111+38]");
			tuple2 = ((RectInt)num25, (System.__Canon)0, (System.__Canon)obj173);
			object obj177 = default;
			bool flag60 = obj177 == null;
			(RectInt, System.__Canon, System.__Canon) tuple4 = ((RectInt, System.__Canon, System.__Canon))0;
			tuple5 = ((RectInt, System.__Canon, System.__Canon))0;
			tuple2 = ((RectInt, System.__Canon, System.__Canon))0;
			flag8 = false;
			num10 = 1;
			num11 = (int)obj173;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v111+38]");
			x2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v111+30]");
			num12 = 0;
			if (flag60)
			{
				goto IL_045c;
			}
			object obj178 = obj177 + 48;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj179 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D10]");
			object obj180 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1347 @ X8_v113+A0]");
			object obj181 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C78]");
			object obj182 = 0;
			Color32[] array6 = (Color32[])obj176;
			System.__Canon _Canon = (System.__Canon)obj180;
			string text13 = (string)obj182;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X8_v114+40]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X8_v114+48]");
			(RectInt, System.__Canon, System.__Canon) tuple6 = ((RectInt)num26, (System.__Canon)0, (System.__Canon)obj180);
			object obj183 = obj177 + 80;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X0_v169+18]");
			object obj184 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X0_v169+18]");
			bool flag61 = (nint)0 < (nint)1;
			tuple5 = ((RectInt, System.__Canon, System.__Canon))0;
			bool flag62 = false;
			int num27 = 1;
			num6 = 0;
			int num28 = (int)obj180;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X8_v114+48]");
			int num29 = 0;
			ScreenFont screenFont7 = null;
			if (!flag61)
			{
				object obj185 = obj185;
				RectInt rectInt3 = rectInt2;
				Color32[] array7 = (Color32[])obj176;
				bool flag63 = false;
				int num30 = 1;
				int num31 = 0;
				num6 = 0;
				string text14 = (string)obj182;
				bool flag79;
				do
				{
					bool flag64 = num31 < (nint)obj184;
					object obj186 = !flag64;
					if (obj186 == null)
					{
						object obj187 = obj177 + num31;
						string text15 = hovered;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+38]");
						bool flag65 = text15 == (string)0;
						tuple5 = ((RectInt, System.__Canon, System.__Canon))pressFlash;
						bool flag66 = !(pressFlash > 0f);
						Color32 color3 = (Color32)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+38]");
						RectInt rectInt4 = (RectInt)0;
						if (!flag66)
						{
							string text16 = pressedThing;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+38]");
							bool flag67 = text16 == (string)0;
							bool flag68 = !flag67;
							color3 = (Color32)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+38]");
							rectInt4 = (RectInt)0;
							if (!flag68)
							{
								object obj188 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1780 @ X0_v218+E4]");
								bool flag69 = (nint)0 == 0;
								object obj189 = !flag69;
								if (obj189 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj190 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ X0_v221+E4]");
								bool flag70 = (nint)0 == 0;
								object obj191 = !flag70;
								if (obj191 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj190 = obj3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ X0_v221+A0]");
								object obj192 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
								object obj193 = -2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
								obj185 = 0 & -4294967296L;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1861 @ X8_v148+68]");
								_Canon = (System.__Canon)0;
								object obj194 = obj185 | obj193;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+20]");
								rectInt4 = (RectInt)(0 + 4294967296L);
								color3 = (Color32)(obj194 + -8589934592L);
								FillRect(rectInt4, color3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+20]");
								rectInt3 = (RectInt)0;
							}
						}
						object obj195 = obj3;
						if (flag65)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ X0_v210+E4]");
							bool flag71 = (nint)0 == 0;
							object obj196 = !flag71;
							if (obj196 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj195 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ X0_v210+A0]");
							object obj197 = (nint)0 + (nint)108;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ X0_v210+E4]");
							bool flag72 = (nint)0 == 0;
							object obj198 = !flag72;
							if (obj198 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj195 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ X0_v210+A0]");
							object obj197 = (nint)0 + (nint)96;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+20]");
						nint num32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
						Outline((RectInt)num32, (Color32)0);
						object obj199 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1862 @ X0_v198+E4]");
						bool flag73 = (nint)0 == 0;
						object obj200 = !flag73;
						if (obj200 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj201 = obj3;
						object obj203;
						if (flag65)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1934 @ X0_v203+E4]");
							bool flag74 = (nint)0 == 0;
							object obj202 = !flag74;
							if (obj202 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj201 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1934 @ X0_v203+A0]");
							obj203 = (nint)0 + (nint)128;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1934 @ X0_v203+E4]");
							bool flag75 = (nint)0 == 0;
							object obj204 = !flag75;
							if (obj204 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj201 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1934 @ X0_v203+A0]");
							obj203 = (nint)0 + (nint)120;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
						bool flag76 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
						nint num33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
						object obj205 = num33 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
						object obj206 = 0 & obj205;
						bool flag77 = (nint)obj206 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+20]");
						object obj207 = (nint)0 >> 32;
						array6 = (Color32[])obj203;
						bool flag78 = flag76 == flag77;
						object obj208 = !flag78;
						object obj209 = ~obj208;
						Color32 color4;
						if (obj209 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
							color4 = (Color32)((nint)0 + (nint)1);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+28]");
							color4 = (Color32)0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+20]");
						num29 = 0 + color4;
						num28 = obj207 + 7;
						ScreenFont font17 = title;
						int x14 = num29;
						int y14 = num28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+30]");
						Text(font17, x14, y14, (string)0, array6, 2, centred: true);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X0_v169+18]");
						obj184 = 0;
						num31 = num6 + 1;
						int num34 = num31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X0_v169+18]");
						flag79 = (nint)num34 < (nint)0;
						rectInt2 = rectInt3;
						flag62 = true;
						num27 = 2;
						num6 = num31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+30]");
						text13 = (string)0;
						screenFont7 = title;
						array7 = array6;
						flag63 = true;
						num30 = 2;
						num6 = num31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ X8_v130+30]");
						text14 = (string)0;
						_Canon = (System.__Canon)num28;
						continue;
					}
					throw new IndexOutOfRangeException();
				}
				while (flag79);
			}
			object obj210 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1515 @ X0_v177+E4]");
			bool flag80 = (nint)0 == 0;
			object obj211 = !flag80;
			if (obj211 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj212 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
			obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1552 @ X0_v179+E4]");
			bool flag81 = (nint)0 == 0;
			object obj213 = !flag81;
			if (obj213 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj214 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1628 @ X8_v120+A0]");
			object obj215 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+14]");
			obj89 = 0;
			string text17 = num6.ToString();
			int pages2 = ((GillaStash)(object)text17).Pages;
			string text18 = num6.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C90]");
			object obj216 = 0;
			string text19 = (string)obj216 + text17 + (string)obj88 + text18;
			object obj217 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+18]");
			bool flag82 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+18]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+18]");
			object obj218 = num35 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+18]");
			object obj219 = 0 & obj218;
			bool flag83 = (nint)obj219 < 0;
			bool flag84 = flag82 == flag83;
			object obj220 = !flag84;
			object obj221 = ~obj220;
			object obj222;
			if (obj221 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+18]");
				obj222 = (nint)0 + (nint)1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+18]");
				obj222 = 0;
			}
			num11 = obj89 + 11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1794 @ X8_v126+A0]");
			object obj223 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X8_v121+10]");
			x2 = 0 + obj222;
			ScreenFont font18 = this.text;
			int x15 = x2;
			int y15 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v127+78]");
			Text(font18, x15, y15, text19, (Color32[])0, 1, centred: true);
			tuple6 = ((RectInt, System.__Canon, System.__Canon))0;
			tuple4 = ((RectInt, System.__Canon, System.__Canon))0;
			tuple2 = ((RectInt, System.__Canon, System.__Canon))0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v127+78]");
			array = (Color32[])0;
			flag8 = true;
			num10 = 1;
			num6 = pages2;
			text6 = text19;
			num12 = (int)this.text;
		}
		bool flag85 = selected == null;
		bool[] array8 = down;
		object obj224 = !flag85;
		object obj225 = ~obj224;
		bool flag86;
		bool flag87;
		bool flag88;
		if (obj225 == null)
		{
			flag86 = num18 < 0;
			flag87 = num18 == 0;
			int num36 = num18 ^ num18;
			int num37 = num18 & num36;
			flag88 = num37 < 0;
		}
		else
		{
			flag88 = false;
			flag87 = true;
			flag86 = false;
		}
		bool flag89 = flag86 == flag88;
		object obj226 = !flag87;
		obj114 = flag89 & obj226;
		bool flag90 = array8 == null;
		obj10 = obj114;
		object obj227;
		int num38;
		int num39;
		string text20;
		int num40;
		if (!flag90)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B00]");
			obj227 = 0;
			bool flag91 = (byte)(~(array8[0] ? 1u : 0u)) != 0;
			num38 = x2;
			num39 = num12;
			if (flag91)
			{
				goto IL_1aa0;
			}
			string[] array9 = downOn;
			bool flag92 = downOn == null;
			obj10 = obj114;
			if (!flag92)
			{
				text20 = (string)obj227;
				bool flag93 = array9[0] == (string)obj227;
				bool flag94 = !flag93;
				object obj228 = !flag94;
				num40 = 0;
				if (obj228 != null)
				{
					goto IL_1bda;
				}
				array8 = down;
				bool flag95 = down == null;
				obj10 = obj114;
				x2 = 0;
				num12 = (int)obj227;
				num38 = 0;
				num39 = (int)obj227;
				if (!flag95)
				{
					goto IL_1aa0;
				}
			}
		}
		goto IL_045c;
		IL_1bda:
		object obj229 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X0_v146+E4]");
		bool flag96 = (nint)0 == 0;
		object obj230 = !flag96;
		if (obj230 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj231 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1425 @ X0_v148+E4]");
		bool flag97 = (nint)0 == 0;
		object obj232 = !flag97;
		if (obj232 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj233 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X8_v95+A0]");
		object obj234 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v96+20]");
		tuple5 = ((RectInt, System.__Canon, System.__Canon))0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v96+20]");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7C0]");
		obj112 = num41 + 0;
		num38 = num40;
		string text21 = text20;
		goto IL_2cea;
		IL_1aa0:
		bool flag98 = (byte)(~(array8[1] ? 1u : 0u)) != 0;
		text21 = (string)num39;
		if (!flag98)
		{
			string[] array10 = downOn;
			bool flag99 = downOn == null;
			obj10 = obj114;
			x2 = num38;
			num12 = num39;
			if (flag99)
			{
				goto IL_045c;
			}
			text21 = (string)obj227;
			bool flag100 = array10[1] == (string)obj227;
			bool flag101 = !flag100;
			object obj235 = !flag101;
			num38 = 0;
			num40 = 0;
			text20 = (string)obj227;
			if (obj235 != null)
			{
				goto IL_1bda;
			}
		}
		if (~(mouseDown ? 1u : 0u) == 0)
		{
			text20 = (string)obj227;
			bool flag102 = hovered == (string)obj227;
			bool flag103 = !flag102;
			num40 = 0;
			num38 = 0;
			text21 = (string)obj227;
			if (!flag103)
			{
				goto IL_1bda;
			}
		}
		object obj236 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v156+E4]");
		bool flag104 = (nint)0 == 0;
		object obj237 = !flag104;
		if (obj237 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj236 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v156+A0]");
		object obj238 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ X8_v102+20]");
		obj112 = 0;
		goto IL_2cea;
		IL_2cea:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		double num44;
		if (obj114 != null)
		{
			float num42 = holdFill;
			bool flag105 = !(holdFill > 0f);
			num23 = holdFill;
			c2 = (Color32)num38;
			r4 = (RectInt)text21;
			if (flag105)
			{
				goto IL_2d36;
			}
			object obj239 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X0_v128+E4]");
			bool flag106 = (nint)0 == 0;
			object obj240 = !flag106;
			if (obj240 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num42 = holdFill;
			}
			float num43 = num42 * (float)color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj241 = 0;
			object obj242 = obj241;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1697 @ X0_v131+E4]");
			bool flag107 = (nint)0 == 0;
			object obj243 = !flag107;
			if (obj243 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num45 = default;
			if (num43 < 0f)
			{
				if ((double)num43 == -0.5)
				{
					num44 = -1.0;
					num23 = num45;
					goto IL_2d8f;
				}
				num23 = (double)num43 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			}
			else
			{
				if ((double)num43 == 0.5)
				{
					num44 = 1.0;
					num23 = num45;
					goto IL_2d8f;
				}
				num23 = (double)num43 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			}
			goto IL_2e04;
		}
		object obj244 = obj3;
		r2 = (RectInt)(obj112 | obj107);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1615 @ X0_v120+E4]");
		bool flag108 = (nint)0 == 0;
		object obj245 = !flag108;
		if (obj245 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj244 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1615 @ X0_v120+A0]");
		obj166 = (nint)0 + (nint)112;
		obj167 = obj112;
		num23 = (double)tuple5;
		goto IL_3342;
		IL_2d8f:
		double num46 = num23 + num44;
		object obj246 = num23 & 1;
		bool flag109 = obj246 == null;
		object obj247 = !flag109;
		if (obj247 != null)
		{
			num23 = num46;
		}
		goto IL_2e04;
	}

	private unsafe static (string, string, int) About(string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I
		//IL_0348: Expected VT, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got Ref
		//IL_01cf: Expected Obj, but got I
		//IL_03f5: Expected VT, but got I4
		//IL_0411: Expected native int or pointer, but got VT
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got Ref
		//IL_0221: Expected Obj, but got I
		//IL_018c: Expected Obj, but got Ref
		//IL_0327: Expected Obj, but got Ref
		//IL_025b: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameObject gameObject = PrefabOf(label);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = gameObject != null;
		bool flag4 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		int item;
		if (!flag4)
		{
			if ((object)gameObject == null)
			{
				goto IL_032c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5350]");
			object obj9 = 0;
			obj7 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
			object obj11 = default;
			object obj10 = obj11 & 1;
			bool flag5 = obj10 == null;
			object obj12 = default;
			obj8 = (UnityEngine.Object)(&obj12);
			if (!flag5)
			{
				if (obj12 == null)
				{
					goto IL_032c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ stack_-48_v6+39]");
				bool flag6 = (nint)0 == 0;
				obj8 = (UnityEngine.Object)(&obj12);
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ stack_-48_v6+38]");
					bool flag7 = (nint)0 == 0;
					obj8 = (UnityEngine.Object)(&obj12);
					if (flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ stack_-48_v6+28]");
						item = 0;
						obj8 = (UnityEngine.Object)(&obj12);
						goto IL_041b;
					}
				}
			}
		}
		item = 0;
		goto IL_041b;
		IL_033a:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return ((string, string, int))ex;
		IL_03ec:
		(string, string, int) tuple = ((string, string, int))0;
		_ = 0;
		_ = 0;
		(string, string, int) tuple2;
		System.__Canon item2;
		System.__Canon item3;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple2, (item2, item3, item));
		return tuple2;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X26_v5+20]");
		item2 = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X26_v5+28]");
		item3 = (System.__Canon)0;
		tuple2 = tuple;
		goto IL_03ec;
		IL_02c9:
		item3 = null;
		item2 = null;
		tuple2 = tuple;
		goto IL_03ec;
		IL_041b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v11+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v11+A0]");
		object obj16 = 0;
		object obj17 = obj16;
		if (obj16 == null)
		{
			goto IL_032c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X23_v1+18]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X23_v1+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_02c9;
		}
		object obj19 = obj16 + 32;
		object obj20 = 0;
		while (true)
		{
			bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
			object obj21 = !flag9;
			if (obj21 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X25_v4+v116 @ X24_v5*8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X25_v4+v116 @ X24_v5*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X26_v5+18]");
				bool flag10 = (string)0 == label;
				bool flag11 = !flag10;
				object obj23 = !flag11;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X23_v1+18]");
					obj18 = 0;
					obj20++;
					object obj24 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X23_v1+18]");
					if ((nint)obj24 < 0)
					{
						continue;
					}
					goto IL_02c9;
				}
				goto IL_02e1;
			}
			goto IL_032c;
		}
		goto IL_033a;
		IL_032c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_033a;
	}

	private void DrawTile(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_085c: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Expected F8, but got I4
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_089d: Expected Obj, but got I
		//IL_0245: Invalid comparison between F4 and I4
		//IL_015f: Invalid comparison between I and F8
		//IL_037e: Expected VT, but got Obj
		//IL_0399: Expected I4, but got I8
		//IL_03ca: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_0428: Expected Obj, but got I
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected I4, but got Unknown
		//IL_0460: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_034c: Expected Obj, but got I4
		//IL_05fd: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I8
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_04c6: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I8
		//IL_08d2: Expected VT, but got Obj
		//IL_08e5: Expected VT, but got I8
		//IL_067b: Expected Obj, but got I4
		//IL_0957: Expected Obj, but got I
		//IL_0981: Expected Obj, but got I4
		//IL_099f: Expected Obj, but got I
		//IL_09c9: Expected Obj, but got I4
		//IL_0653: Expected Obj, but got I4
		//IL_0903: Expected Obj, but got I4
		//IL_06f9: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I4
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Obj, but got Unknown
		//IL_09ff: Expected VT, but got Obj
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I4
		//IL_0799: Expected Obj, but got I4
		//IL_0942: Expected Obj, but got I
		//IL_055a: Expected Obj, but got I4
		//IL_0a4d: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I4
		//IL_0ad8: Expected I4, but got Obj
		//IL_0b06: Expected Obj, but got I
		//IL_0b10: Expected Obj, but got I4
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected Obj, but got Unknown
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_0b4c: Expected Obj, but got I
		//IL_0b7e: Expected Obj, but got I
		//IL_0927: Expected Obj, but got I
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected VT, but got Unknown
		//IL_0bce: Expected Obj, but got I
		//IL_0bf8: Expected Obj, but got I4
		//IL_0a32: Expected Obj, but got I
		//IL_07f7: Expected Obj, but got I4
		//IL_0a62: Expected Obj, but got I
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected I4, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected I4, but got Unknown
		//IL_0aac: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A88]");
		object obj4 = 0;
		System.__Canon _Canon = ((List<System.__Canon>)(object)tiles).get_Item(i);
		object obj5 = i * 1431655766;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+28]");
		bool flag2 = (nint)0 < (nint)0;
		object obj6 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+28]");
		bool flag3 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
		object obj7 = 0;
		object obj8 = obj5 >> 63;
		object obj9 = obj5 >> 32;
		object obj10 = obj9 + obj8;
		object obj11 = obj10 + obj10;
		object obj12 = obj10 << 7;
		object obj13 = i - obj11;
		object obj14 = obj12 - obj10;
		object obj15 = obj13 * 102;
		object obj16 = obj14 + 30;
		object obj17 = ~obj6;
		object obj18 = obj17 | flag3;
		double num = 0.0;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+28]");
			bool flag4 = !(0.0 < 1.0);
			num = 1.0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+28]");
				double num2 = 0.0 * -10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+28]");
				double num3 = 0.0 * 10.0;
				double num4 = num3 + -0.75;
				double num5 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				double num6 = num5 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				double num7 = num2 * num6;
				num = num7 + 1.0;
			}
		}
		object obj19 = obj16 << 32;
		object obj20 = obj15 + 10;
		string text = selected;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+20]");
		bool flag5 = text == (string)0;
		int num8 = default;
		string text2 = num8.ToString();
		string text3 = (string)obj7 + text2;
		bool flag6 = hovered == text3;
		if (pressFlash > 0f)
		{
			string text4 = num8.ToString();
			string text5 = (string)obj7 + text4;
			if (pressedThing == text5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj21 = 0;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v75+E4]");
				bool flag7 = (nint)0 == 0;
				object obj23 = !flag7;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj24 = obj;
				object obj25 = obj15 + 11;
				object obj26 = obj14 + 31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v78+E4]");
				bool flag8 = (nint)0 == 0;
				object obj27 = !flag8;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj24 = obj;
				}
				RectInt r = (RectInt)(obj25 | obj26);
				FillRect(r, (Color32)506806141022L);
			}
		}
		RectInt r2 = (RectInt)(obj19 | obj20);
		TileOutline(r2, (float)num, sel: true, flag5);
		if (num < 0.5)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj28 = 0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+20]");
		string[] array = Wrap((string)0, 90);
		int num9 = obj15 + 58;
		bool flag10 = array.Length < 1;
		int num10 = (flag5 ? 1 : 0);
		string text6 = (string)flag6;
		if (!flag10)
		{
			object obj31 = array.Length & 0xFFFFFFFFL;
			object obj32 = array + 32;
			object obj33 = obj14 + 128;
			bool flag12 = default;
			bool flag11 = flag12;
			int num12 = default;
			int num11 = num12;
			Color32[] array3 = default;
			Color32[] array2 = array3;
			bool flag13 = flag5;
			string text7 = (string)flag6;
			object obj34 = 0;
			int num13 = 90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+20]");
			string text8 = (string)0;
			object obj35 = 4294967295L;
			bool flag18;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj36 = 0;
				object obj37 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v55+E4]");
				bool flag14 = (nint)0 == 0;
				object obj38 = !flag14;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj31 = array.Length;
				}
				bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
				object obj39 = !flag15;
				if (obj39 == null)
				{
					object obj40 = obj;
					object obj42;
					if (flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v61+E4]");
						bool flag16 = (nint)0 == 0;
						object obj41 = !flag16;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj40 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v61+A0]");
						obj42 = (nint)0 + (nint)128;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v61+E4]");
						bool flag17 = (nint)0 == 0;
						object obj43 = !flag17;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj40 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v61+A0]");
						obj42 = (nint)0 + (nint)120;
					}
					object obj44 = obj35 + obj31;
					object obj45 = obj44 + obj44;
					num10 = obj33 - obj45;
					ScreenFont font = this.text;
					int y = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X20_v10+v138 @ X29_v7*8]");
					Text(font, num9, y, (string)0, (Color32[])obj42, 1, centred: true);
					obj31 = array.Length;
					obj34++;
					obj35--;
					flag18 = (nint)obj34 < array.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X20_v10+v138 @ X29_v7*8]");
					text6 = (string)0;
					flag11 = true;
					num11 = 1;
					array2 = (Color32[])obj42;
					flag13 = (byte)num10 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X20_v10+v138 @ X29_v7*8]");
					text7 = (string)0;
					num13 = num9;
					text8 = (string)(object)this.text;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag18);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7 (System.__Canon)+20]");
		int num14 = GillaStashSave.CountOf((string)0);
		int num15 = default;
		string text9 = num15.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D20]");
		object obj46 = 0;
		string text10 = (string)obj46 + text9;
		object obj47;
		if (this.text != null)
		{
			int num16 = this.text.Measure(text10, 1);
			obj47 = num16 + 8;
			num10 = 0;
			int num17 = 1;
			string text11 = text10;
		}
		else
		{
			obj47 = 30;
			int num17 = 0;
			string text11 = text9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj48 = 0;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v32+E4]");
		bool flag19 = (nint)0 == 0;
		object obj50 = !flag19;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = (nint)obj47 < 0;
		object obj51 = obj47 ^ obj47;
		object obj52 = obj47 & obj51;
		bool flag21 = (nint)obj52 < 0;
		object obj53 = obj;
		bool flag22 = flag20 == flag21;
		object obj54 = !flag22;
		object obj55 = ~obj54;
		object obj56 = ((obj55 != null) ? obj47 : ((object)(obj47 + 1)));
		object obj57 = num9 - obj56;
		object obj58 = obj14 + 138;
		RectInt r3 = (RectInt)(obj57 | obj58);
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v45+E4]");
			bool flag23 = (nint)0 == 0;
			object obj59 = !flag23;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj53 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v45+A0]");
			object obj60 = (nint)0 + (nint)172;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v45+E4]");
			bool flag24 = (nint)0 == 0;
			object obj61 = !flag24;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj53 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v45+A0]");
			object obj60 = (nint)0 + (nint)168;
		}
		Color32 c = (Color32)(obj47 | 0xA00000000L);
		FillRect(r3, c);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj62 = 0;
		object obj63 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X0_v37+E4]");
		bool flag25 = (nint)0 == 0;
		object obj64 = !flag25;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj65 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v40+E4]");
		bool flag26 = (nint)0 == 0;
		object obj66 = !flag26;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj65 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v40+A0]");
		object obj67 = 0;
		int x = obj57 + 4;
		int y2 = obj14 + 140;
		ScreenFont font2 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v38+98]");
		Text(font2, x, y2, text10, (Color32[])0, 1, centred: false);
	}

	private void TileOutline(RectInt r, float k, bool sel, bool hover)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b42: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_0bab: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_0b75: Expected Obj, but got I
		//IL_0fb0: Expected Obj, but got I4
		//IL_0b90: Expected Obj, but got I
		//IL_012d: Invalid comparison between F4 and I4
		//IL_013c: Expected F8, but got I4
		//IL_0fcc: Expected Obj, but got I4
		//IL_0fdc: Expected Obj, but got I
		//IL_1006: Expected Obj, but got I4
		//IL_01aa: Invalid comparison between F8 and I4
		//IL_0c2b: Invalid comparison between F4 and I4
		//IL_0c3a: Expected F8, but got I4
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected Obj, but got Unknown
		//IL_0c0f: Expected Obj, but got I4
		//IL_103e: Expected Obj, but got I4
		//IL_02e5: Invalid comparison between F8 and I4
		//IL_0cd6: Expected Obj, but got I4
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected Obj, but got Unknown
		//IL_0d00: Expected Obj, but got F8
		//IL_0d19: Expected Obj, but got I4
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected Obj, but got Unknown
		//IL_0ca7: Expected Obj, but got I4
		//IL_0d81: Expected Obj, but got I4
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0380: Expected F8, but got VT
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0435: Expected Obj, but got I
		//IL_044b: Expected Obj, but got F8
		//IL_046d: Expected Obj, but got I4
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Expected Obj, but got Unknown
		//IL_0498: Expected Obj, but got VT
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected VT, but got Unknown
		//IL_04ea: Expected VT, but got F8
		//IL_0508: Expected Obj, but got I
		//IL_0600: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I4
		//IL_0661: Expected Obj, but got I
		//IL_067c: Expected I4, but got F8
		//IL_067c: Expected I4, but got F8
		//IL_0557: Expected Obj, but got I4
		//IL_0589: Expected VT, but got Obj
		//IL_05cb: Expected Obj, but got I4
		//IL_06c0: Invalid comparison between F8 and I4
		//IL_06cf: Invalid comparison between F8 and I4
		//IL_06e2: Expected Obj, but got F8
		//IL_06ef: Expected Obj, but got F8
		//IL_072a: Expected Obj, but got I4
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_0dfe: Expected Obj, but got I
		//IL_0e0b: Expected VT, but got F8
		//IL_0e1b: Expected Obj, but got I
		//IL_0e65: Expected I4, but got I8
		//IL_0e65: Expected I4, but got F8
		//IL_0e65: Expected I4, but got F8
		//IL_0788: Invalid comparison between F8 and I4
		//IL_0797: Invalid comparison between F8 and I4
		//IL_07aa: Expected Obj, but got F8
		//IL_07b7: Expected Obj, but got F8
		//IL_07ec: Expected Obj, but got I4
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_0e99: Expected I4, but got I8
		//IL_0e99: Expected I4, but got F8
		//IL_0e99: Expected I4, but got F8
		//IL_0ebb: Expected Obj, but got I4
		//IL_0ed1: Expected Obj, but got I
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected Obj, but got Unknown
		//IL_0846: Expected I4, but got I8
		//IL_0846: Expected I4, but got I8
		//IL_0846: Expected I4, but got F8
		//IL_0846: Expected I4, but got F8
		//IL_0865: Expected Obj, but got I8
		//IL_0891: Expected Obj, but got I4
		//IL_0899: Expected I4, but got F8
		//IL_08a6: Expected I4, but got I8
		//IL_08ae: Expected I4, but got F8
		//IL_0f78: Expected Obj, but got I4
		//IL_08e1: Expected Obj, but got I4
		//IL_09ea: Expected Obj, but got I4
		//IL_0908: Expected Obj, but got I4
		//IL_0a39: Expected Obj, but got I
		//IL_0a5b: Expected VT, but got I
		//IL_0a85: Expected Obj, but got I4
		//IL_0f35: Expected Obj, but got I
		//IL_0957: Expected Obj, but got I
		//IL_0979: Expected VT, but got I
		//IL_09a3: Expected Obj, but got I4
		//IL_106e: Expected VT, but got Obj
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_107c: Expected Obj, but got Unknown
		//IL_10d8: Expected I4, but got Obj
		//IL_0f1a: Expected Obj, but got I
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected Obj, but got Unknown
		//IL_0ac8: Expected Obj, but got I
		//IL_0af6: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj3 = 0;
		object obj5;
		if (hover)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v72+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v72+A0]");
			obj5 = (nint)0 + (nint)108;
		}
		else
		{
			nint num = default;
			object obj6 = num & 1;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v72+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v72+A0]");
				obj5 = (nint)0 + (nint)96;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v72+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v72+A0]");
				obj5 = (nint)0 + (nint)100;
			}
		}
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = k < 0f;
		double num2 = 0.0;
		if (!flag5)
		{
			bool flag6 = !((double)k > 1.0);
			num2 = k;
			if (!flag6)
			{
				num2 = 1.0;
			}
		}
		double num3 = (double)(sel ? 1 : 0) * 0.5;
		double num4 = num3 * num2;
		object obj11 = (sel ? 1 : 0) >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num5;
		double num6;
		double num7 = default;
		double num8;
		if (num4 < 0.0)
		{
			if (num4 == -0.5)
			{
				num5 = -1.0;
				num6 = num7;
				goto IL_0bd8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num8 = num4;
		}
		else
		{
			if (num4 == 0.5)
			{
				num5 = 1.0;
				num6 = num7;
				goto IL_0bd8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num8 = num4;
		}
		goto IL_0c22;
		IL_0c70:
		(int, int, int, int) tuple;
		double num10;
		double num9 = (double)tuple + num10;
		object obj15 = tuple & 1;
		bool flag8 = obj15 == null;
		object obj16 = !flag8;
		double num11 = ((obj16 != null) ? num9 : ((double)tuple));
		goto IL_0cba;
		IL_0c22:
		bool flag9 = k < 0f;
		double num12 = 0.0;
		if (!flag9)
		{
			bool flag10 = !((double)k > 1.0);
			num12 = k;
			if (!flag10)
			{
				num12 = 1.0;
			}
		}
		double num13 = (double)obj11 * 0.5;
		double num14 = num13 * num12;
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v12+E4]");
		bool flag11 = (nint)0 == 0;
		object obj18 = !flag11;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		(int, int, int, int) tuple2 = default;
		if (num14 < 0.0)
		{
			if (num14 == -0.5)
			{
				num10 = -1.0;
				tuple = tuple2;
				goto IL_0c70;
			}
			num11 = num14 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num9 = -0.5;
		}
		else
		{
			if (num14 == 0.5)
			{
				num10 = 1.0;
				tuple = tuple2;
				goto IL_0c70;
			}
			num11 = num14 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num9 = 0.5;
		}
		goto IL_0cba;
		IL_0b23:
		throw new IndexOutOfRangeException();
		IL_0cba:
		bool flag12 = (sel ? 1 : 0) < (false ? 1 : 0);
		object obj19 = sel ^ sel;
		object obj20 = sel & obj19;
		bool flag13 = (nint)obj20 < 0;
		object obj21 = num8 << 1;
		bool flag14 = flag12 == flag13;
		object obj22 = !flag14;
		object obj23 = ~obj22;
		bool flag15 = ((obj23 != null) ? sel : ((byte)((sel ? 1u : 0u) + 1u) != 0));
		bool flag16 = (nint)obj11 < 0;
		object obj24 = obj11 ^ obj11;
		object obj25 = obj11 & obj24;
		bool flag17 = (nint)obj25 < 0;
		bool flag18 = flag16 == flag17;
		object obj26 = !flag18;
		object obj27 = ~obj26;
		if (obj27 == null)
		{
			obj11++;
		}
		object obj28 = obj21 - 2;
		if ((nint)obj21 < 2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj29 = 0;
		object obj30 = obj29;
		object obj31 = num11 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v17+E4]");
		bool flag19 = (nint)0 == 0;
		object obj32 = !flag19;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj33 = obj31 - 2;
		if ((nint)obj31 < 2)
		{
			return;
		}
		object obj34 = r >> 32;
		object obj35 = r + flag15;
		Color32 c = (Color32)(obj21 | num11);
		object obj36 = obj34 + obj11;
		double num15 = (double)obj35 - num8;
		double num16 = (double)obj36 - num11;
		RectInt r2 = (RectInt)(num15 | num16);
		Outline(r2, c);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj37 = 0;
		bool flag20 = !hover;
		object obj38 = obj5;
		if (!flag20)
		{
			object obj39 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v53+E4]");
			bool flag21 = (nint)0 == 0;
			object obj40 = !flag21;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj41 = obj;
			Color32 color = (Color32)(obj28 | obj33);
			double num17 = num15 + 1.0;
			double num18 = num16 + 1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X0_v56+E4]");
			bool flag22 = (nint)0 == 0;
			object obj42 = !flag22;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj41 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X0_v56+A0]");
			object obj43 = 0;
			RectInt r3 = (RectInt)(num17 | num18);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v57+6C]");
			obj38 = 0;
			Outline(r3, color);
			c = color;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D30]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj45 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v22+E4]");
		bool flag23 = (nint)0 == 0;
		object obj46 = !flag23;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D38]");
		object obj47 = 0;
		tuple2 = ((int)num15, (int)num16, 1, 1);
		object obj48 = default;
		if (obj48 == null)
		{
			goto IL_0b15;
		}
		double num19 = (double)obj21 + num15;
		double num20 = num15 - num19;
		bool flag24 = num20 < 0.0;
		bool flag25 = num20 == 0.0;
		object obj49 = num15 ^ num19;
		object obj50 = num15 ^ num20;
		object obj51 = obj49 & obj50;
		bool flag26 = (nint)obj51 < 0;
		_ = 0;
		bool flag27 = flag24 == flag26;
		object obj52 = !flag25;
		object obj53 = flag27 & obj52;
		object obj54 = ~obj53;
		if (obj54 == null)
		{
			num19 = num15;
		}
		double num21 = num19 - 1.0;
		(int, int, int, int) tuple3 = ((int)num21, (int)num16, -1, 1);
		double num22 = (double)obj31 + num16;
		_ = 0;
		double num23 = num16 - num22;
		bool flag28 = num23 < 0.0;
		bool flag29 = num23 == 0.0;
		object obj55 = num16 ^ num22;
		object obj56 = num16 ^ num23;
		object obj57 = obj55 & obj56;
		bool flag30 = (nint)obj57 < 0;
		bool flag31 = flag28 == flag30;
		object obj58 = !flag29;
		object obj59 = flag31 & obj58;
		object obj60 = ~obj59;
		if (obj60 == null)
		{
			num22 = num16;
		}
		double num24 = num22 - 1.0;
		(int, int, int, int) tuple4 = ((int)num15, (int)num24, 1, -1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v22+18]");
		bool flag32 = (nint)0 < (nint)2;
		object obj61 = !flag32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v22+18]");
		object obj62 = -2;
		bool flag33 = obj62 == null;
		object obj63 = ~obj61;
		object obj64 = obj63 | flag33;
		if (obj64 == null)
		{
			_ = 0;
			(int, int, int, int) tuple5 = ((int)num21, (int)num24, -1, -1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v22+18]");
			object obj65 = 0 & 0xFFFFFFFFL;
			_ = 0;
			if ((nint)obj65 < 1)
			{
				return;
			}
			object obj66 = 0;
			int num25 = (int)num21;
			int num26 = -1;
			int num27 = (int)num24;
			object obj67 = obj48;
			while (true)
			{
				bool flag34 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65);
				object obj68 = !flag34;
				if (obj68 != null)
				{
					break;
				}
				object obj69 = obj67 + obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+20]");
				int num28 = 0;
				object obj70 = 5;
				object obj77;
				int num33;
				while (true)
				{
					object obj71 = obj;
					if (hover)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v34+E4]");
						bool flag35 = (nint)0 == 0;
						object obj72 = !flag35;
						if (obj72 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((object)this == null)
						{
							break;
						}
						object obj73 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v46+A0]");
						object obj74 = 0;
						int x = num28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+24]");
						nint num29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v47+6C]");
						Set(x, (int)num29, (Color32)0);
						object obj75 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X0_v47+E4]");
						bool flag36 = (nint)0 == 0;
						object obj76 = !flag36;
						if (obj76 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj75 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X0_v47+A0]");
						obj77 = (nint)0 + (nint)108;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v34+E4]");
						bool flag37 = (nint)0 == 0;
						object obj78 = !flag37;
						if (obj78 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((object)this == null)
						{
							break;
						}
						object obj79 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X8_v41+A0]");
						object obj80 = 0;
						int x2 = num28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+24]");
						nint num30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v42+60]");
						Set(x2, (int)num30, (Color32)0);
						object obj81 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v40+E4]");
						bool flag38 = (nint)0 == 0;
						object obj82 = !flag38;
						if (obj82 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj81 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v40+A0]");
						obj77 = (nint)0 + (nint)96;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+20]");
					nint num31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+24]");
					Set((int)num31, 0, (Color32)obj77);
					obj70--;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+24]");
					nint num32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+2C]");
					num33 = (int)(num32 + 0);
					int num34 = num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+28]");
					num28 = (int)((nint)num34 + (nint)0);
					bool flag39 = (nint)obj70 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+20]");
					num25 = 0;
					num26 = (int)obj77;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+24]");
					num27 = 0;
					if (flag39)
					{
						continue;
					}
					goto IL_0aaa;
				}
				goto IL_0b15;
				IL_0aaa:
				obj66++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v22+18]");
				obj65 = 0;
				object obj83 = obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v22+18]");
				bool flag40 = (nint)obj83 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v36+20]");
				num25 = 0;
				num26 = (int)obj77;
				num27 = num33;
				obj67 = obj48;
				if (!flag40)
				{
					return;
				}
			}
		}
		goto IL_0b23;
		IL_0b15:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b23;
		IL_0bd8:
		double num35 = num6 + num5;
		object obj84 = num6 & 1;
		bool flag41 = obj84 == null;
		object obj85 = !flag41;
		num8 = ((obj85 != null) ? num35 : num6);
		goto IL_0c22;
	}

	private string[] Wrap(string s, int width)
	{
		//IL_04dd: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I
		//IL_0579: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I8
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0826: Expected Obj, but got I4
		//IL_072a: Expected Obj, but got I4
		//IL_0607: Expected Obj, but got I
		//IL_061c: Expected I4, but got Obj
		//IL_01ba: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I
		//IL_047b: Expected I4, but got Obj
		//IL_068e: Expected Obj, but got I4
		//IL_07d9: Expected Obj, but got I4
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I4
		//IL_022a: Expected I4, but got Obj
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_02ba: Expected I4, but got Obj
		//IL_02c2: Expected Obj, but got I4
		//IL_0312: Expected I4, but got Obj
		//IL_0384: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I4
		bool flag = this.text == null;
		int num = width;
		List<System.__Canon> list = default;
		string text4 = default;
		int num5;
		string text5;
		int num4 = default;
		List<System.__Canon> list2;
		if (!flag)
		{
			int num2 = this.text.Measure(s, 1);
			bool flag2 = num2 <= width;
			num = 1;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				list._002Ector();
				bool flag3 = s == null;
				list2 = list;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj2 = 0;
					string text = (string)obj2;
					string[] array = s.Split(' ', (StringSplitOptions)0);
					bool flag4 = array == null;
					list2 = list;
					if (!flag4)
					{
						object obj8;
						StringSplitOptions stringSplitOptions;
						if (array.Length >= 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
							object obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
							object obj4 = 0;
							object obj5 = array.Length & 0xFFFFFFFFL;
							object obj6 = array + 32;
							object obj7 = 0;
							obj8 = 0;
							stringSplitOptions = (StringSplitOptions)0;
							char c = ' ';
							string[] array2 = array;
							while (true)
							{
								bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
								object obj9 = !flag5;
								if (obj9 != null)
								{
									break;
								}
								bool flag6 = text == null;
								list2 = list;
								System.__Canon _Canon;
								List<System.__Canon> list3;
								if (!flag6)
								{
									bool flag7 = text._stringLength == 0;
									_Canon = (System.__Canon)c;
									list3 = (List<System.__Canon>)(object)array2;
									if (flag7)
									{
										goto IL_0463;
									}
									string text2 = text;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X29_v8+v151 @ X26_v9*8]");
									string text3 = text2 + (string)obj3 + (string)0;
									bool flag8 = text._stringLength < 1;
									text4 = text3;
									obj8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X29_v8+v151 @ X26_v9*8]");
									stringSplitOptions = (StringSplitOptions)0;
									c = (char)(int)obj3;
									array2 = (string[])(object)text3;
									if (flag8)
									{
										goto IL_07cf;
									}
									bool flag9 = this.text == null;
									text4 = text3;
									list2 = list;
									if (!flag9)
									{
										int num3 = this.text.Measure(text3, 1);
										bool flag10 = num3 <= width;
										text4 = text3;
										obj8 = 0;
										stringSplitOptions = (StringSplitOptions)1;
										c = (char)(int)text3;
										array2 = (string[])num3;
										if (flag10)
										{
											goto IL_07cf;
										}
										bool flag11 = list == null;
										text4 = text3;
										list2 = list;
										if (!flag11)
										{
											System.__Canon[] items = list._items;
											num4 = (int)obj4;
											int version = list._version + 1;
											list._version = version;
											bool flag12 = list._items == null;
											text4 = text3;
											list2 = list;
											if (!flag12)
											{
												bool flag13 = list._size < items.Length;
												object obj10 = !flag13;
												if (obj10 == null)
												{
													object obj11 = list._items + list._size;
													num4 = ++list._size;
													object obj12 = obj11 + 32;
													obj12 = text;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													obj8 = 0;
													stringSplitOptions = (StringSplitOptions)1;
													_Canon = (System.__Canon)(object)text;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X9_v11 (System.Int32)+20]");
													object obj13 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v32+A8]");
													object obj14 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v33+70]");
													stringSplitOptions = (StringSplitOptions)0;
													list.AddWithResize((System.__Canon)(object)text);
													obj8 = 0;
													_Canon = (System.__Canon)(object)text;
													list3 = list;
												}
												goto IL_0463;
											}
										}
									}
								}
								goto IL_0758;
								IL_0463:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X29_v8+v151 @ X26_v9*8]");
								text4 = (string)0;
								c = (char)(int)_Canon;
								array2 = (string[])(object)list3;
								goto IL_07cf;
								IL_07cf:
								obj5 = array.Length;
								obj7++;
								bool flag14 = (nint)obj7 < array.Length;
								text = text4;
								if (flag14)
								{
									continue;
								}
								goto IL_0488;
							}
							goto IL_079a;
						}
						bool flag15 = obj2 == null;
						num5 = num4;
						text5 = (string)obj2;
						obj8 = 0;
						stringSplitOptions = (StringSplitOptions)0;
						text4 = (string)obj2;
						list2 = list;
						if (!flag15)
						{
							goto IL_05a0;
						}
					}
				}
				goto IL_0758;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array3 = default;
		bool flag16 = array3 == null;
		list2 = (List<System.__Canon>)109891584;
		if (flag16)
		{
			goto IL_0758;
		}
		if (array3.Length != 0)
		{
			object obj16 = array3 + 32;
			obj16 = s;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return array3;
		}
		goto IL_079a;
		IL_0787:
		List<System.__Canon> list4;
		return (string[])(object)list4.ToArray();
		IL_079a:
		return (string[])(object)new IndexOutOfRangeException();
		IL_05a0:
		System.__Canon item;
		if (text5._stringLength >= 1)
		{
			bool flag17 = list == null;
			num4 = num5;
			text4 = text5;
			list2 = list;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
				object obj17 = 0;
				System.__Canon[] items2 = list._items;
				num4 = (int)obj17;
				int version2 = list._version + 1;
				list._version = version2;
				bool flag18 = list._items == null;
				text4 = text5;
				list2 = list;
				if (!flag18)
				{
					bool flag19 = list._size < items2.Length;
					object obj18 = !flag19;
					item = (System.__Canon)(object)text5;
					list2 = list;
					if (obj18 == null)
					{
						object obj19 = list._items + list._size;
						int size = list._size + 1;
						list._size = size;
						object obj20 = obj19 + 32;
						obj20 = text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						list4 = list;
					}
					else
					{
						list2.AddWithResize(item);
						list4 = list2;
					}
					goto IL_0787;
				}
			}
		}
		else
		{
			bool flag20 = list == null;
			object obj21 = !flag20;
			num4 = num5;
			text4 = text5;
			list2 = list;
			list4 = list;
			if (obj21 != null)
			{
				goto IL_0787;
			}
		}
		goto IL_0758;
		IL_0488:
		bool flag21 = text4 == null;
		object obj22 = !flag21;
		num5 = num4;
		text5 = text4;
		if (obj22 != null)
		{
			goto IL_05a0;
		}
		list2 = list;
		goto IL_0758;
		IL_0758:
		item = (System.__Canon)(object)text4;
		throw new NullReferenceException();
	}

	private string Fit(string s, int width, int scale)
	{
		//IL_013d: Expected Obj, but got I4
		bool flag = this.text == null;
		string text = s;
		if (!flag)
		{
			bool flag2 = string.IsNullOrEmpty(s);
			bool flag3 = !flag2;
			text = s;
			if (flag3)
			{
				bool flag4 = s == null;
				text = s;
				if (flag4)
				{
					goto IL_0153;
				}
				while (text._stringLength >= 2)
				{
					if (this.text != null)
					{
						int num = this.text.Measure(text, scale);
						if (num <= width)
						{
							break;
						}
						int length = text._stringLength - 1;
						string text2 = text.Substring(0, length);
						bool flag5 = text2 == null;
						object obj = !flag5;
						text = text2;
						if (obj != null)
						{
							continue;
						}
					}
					goto IL_0153;
				}
			}
		}
		return text;
		IL_0153:
		return (string)(object)new NullReferenceException();
	}

	private void BoltIcon(int x, int y, int scale)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_005a: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_0502: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected VT, but got Unknown
		//IL_04dc: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_0485;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64F0]");
		object obj3 = 0;
		object obj4 = obj2 + 32;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64E0]");
		object obj5 = 0;
		object obj6 = obj2 + 40;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X24_v6-10]");
		bool flag = (nint)0 < (nint)2;
		object obj7 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X24_v6-10]");
		object obj8 = -2;
		bool flag2 = obj8 == null;
		object obj9 = ~obj7;
		object obj10 = obj9 | flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64E8]");
			object obj11 = 0;
			object obj12 = obj2 + 48;
			obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64F8]");
			object obj13 = 0;
			object obj14 = obj2 + 56;
			obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X24_v10-20]");
			bool flag3 = (nint)0 < (nint)4;
			object obj15 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X24_v10-20]");
			object obj16 = -4;
			bool flag4 = obj16 == null;
			object obj17 = ~obj15;
			object obj18 = obj17 | flag4;
			if (obj18 == null)
			{
				object obj19 = obj2 + 64;
				obj19 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X24_v12-28]");
				bool flag5 = (nint)0 < (nint)5;
				object obj20 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X24_v12-28]");
				object obj21 = -5;
				bool flag6 = obj21 == null;
				object obj22 = ~obj20;
				object obj23 = obj22 | flag6;
				if (obj23 == null)
				{
					object obj24 = obj2 + 72;
					obj24 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X24_v14-30]");
					bool flag7 = (nint)0 < (nint)6;
					object obj25 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X24_v14-30]");
					object obj26 = -6;
					bool flag8 = obj26 == null;
					object obj27 = ~obj25;
					object obj28 = obj27 | flag8;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
						object obj29 = 0;
						object obj30 = obj2 + 80;
						obj30 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj31 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v23+E4]");
						bool flag9 = (nint)0 == 0;
						object obj32 = !flag9;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num = scale | scale;
						object obj33 = 0;
						while (true)
						{
							object obj34 = obj33 * scale;
							object obj35 = y + obj34;
							object obj36 = obj2 + obj33;
							object obj37 = obj35 << 32;
							int num2 = 0;
							int num3 = x;
							while (true)
							{
								object obj38 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
								bool flag10 = (nint)obj38 < 0;
								object obj39 = !flag10;
								if (obj39 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X29_v4+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X29_v4+20]");
									char c = ((string)0).get_Chars(num2);
									int num4 = c & 0xFFFF;
									if (num4 != 46)
									{
										if ((object)this == null)
										{
											goto IL_0485;
										}
										int num5 = c & 0xFFFF;
										if (num5 == 35)
										{
										}
										RectInt r = (RectInt)(obj37 | num3);
										FillRect(r, (Color32)num);
									}
									num2++;
									num3 += scale;
									if (num2 != 7)
									{
										continue;
									}
									goto IL_0456;
								}
								goto IL_0485;
							}
							break;
							IL_0456:
							obj33++;
							if ((nint)obj33 == 7)
							{
								return;
							}
						}
					}
				}
			}
		}
		goto IL_0493;
		IL_0485:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0493;
		IL_0493:
		throw new IndexOutOfRangeException();
	}

	private unsafe void Text(ScreenFont font, int x, int y, string s, Color32[] colours, int scale, bool centred = default(bool))
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got Ref
		if (font == null)
		{
			return;
		}
		bool flag = string.IsNullOrEmpty(s);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			ShiftAuth.Style style = default;
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref style, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			ShiftAuth.Style s2 = default;
			if (centred)
			{
				int num = font.DrawCentred(px, 512, 288, x, y, s, ref s2);
			}
			else
			{
				int num2 = font.Draw(px, 512, 288, x, y, s, ref s2);
			}
		}
	}

	private void Set(int x, int y, Color32 c)
	{
		//IL_0059: Expected I4, but got I8
		//IL_0073: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		if (y > 287 || x > 511)
		{
			return;
		}
		int num = y | x;
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Color32[] array = px;
		if (px != null)
		{
			object obj2 = x - y;
			object obj3 = obj2 + 143360;
			object obj4 = obj3 + 3584;
			bool flag2 = (nint)obj4 < array.Length;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				object obj6 = (object)px + obj4;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private void FillRect(RectInt r, Color32 c)
	{
		//IL_000e: Expected I4, but got VT
		//IL_001c: Expected Obj, but got VT
		//IL_002c: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_0067: Expected Obj, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected I4, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got VT
		//IL_02cf: Expected Obj, but got VT
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_0311: Expected Obj, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I4
		//IL_01e0: Expected VT, but got I8
		//IL_01f2: Expected I4, but got VT
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected VT, but got Unknown
		//IL_0210: Expected I, but got VT
		int num = r >> 32;
		Color32 color = default;
		object obj = color >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num2 = obj + num;
		RectInt rectInt = (RectInt)(color + r);
		object obj5 = num - num2;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = obj5 == null;
		int num3 = num ^ num2;
		int num4 = num ^ obj5;
		int num5 = num3 & num4;
		bool flag4 = num5 < 0;
		bool flag5 = flag2 == flag4;
		object obj6 = !flag3;
		object obj7 = flag5 & obj6;
		object obj8 = ~obj7;
		int num6 = ((obj8 != null) ? num2 : num);
		object obj9 = r - rectInt;
		bool flag6 = (nint)obj9 < 0;
		bool flag7 = obj9 == null;
		object obj10 = r ^ rectInt;
		object obj11 = r ^ obj9;
		object obj12 = obj10 & obj11;
		bool flag8 = (nint)obj12 < 0;
		bool flag9 = flag6 == flag8;
		object obj13 = !flag7;
		object obj14 = flag9 & obj13;
		object obj15 = ~obj14;
		IntPtr intPtr = default;
		RectInt rectInt3;
		if (obj15 == null)
		{
			RectInt rectInt2 = r;
			nint num7 = intPtr;
			rectInt3 = r;
		}
		else
		{
			RectInt rectInt2 = r;
			nint num7 = intPtr;
			rectInt3 = rectInt;
		}
		while (true)
		{
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (num == num6)
			{
				break;
			}
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v7+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			RectInt rectInt4 = r;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				rectInt4 = r;
			}
			while (true)
			{
				object obj20 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v9+E4]");
				bool flag12 = (nint)0 == 0;
				object obj21 = !flag12;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (rectInt3 != rectInt4)
				{
					Color32 color2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
					Set((int)rectInt4, num, color2);
					RectInt rectInt5 = (RectInt)(rectInt4 + 1);
					RectInt rectInt2 = rectInt4;
					nint num7 = (nint)color2;
					rectInt4 = rectInt5;
					continue;
				}
				break;
			}
			num++;
		}
	}

	private void Outline(RectInt r, Color32 c)
	{
		//IL_000e: Expected I4, but got VT
		//IL_001c: Expected Obj, but got VT
		//IL_002c: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
		//IL_0067: Expected Obj, but got VT
		//IL_0092: Expected Obj, but got VT
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected I4, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected I4, but got Unknown
		//IL_0181: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_01b0: Expected VT, but got I8
		//IL_01c2: Expected I4, but got VT
		//IL_01d4: Expected VT, but got I8
		//IL_01e6: Expected I4, but got VT
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected VT, but got Unknown
		//IL_0201: Expected VT, but got I4
		//IL_0211: Expected I, but got VT
		//IL_02c5: Expected Obj, but got I4
		//IL_02f4: Expected VT, but got I8
		//IL_0306: Expected I4, but got VT
		//IL_0318: Expected VT, but got I8
		//IL_0345: Expected VT, but got I4
		//IL_034d: Expected VT, but got I4
		//IL_0355: Expected I, but got VT
		int num = r >> 32;
		Color32 color = default;
		object obj = color >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RectInt rectInt = (RectInt)(color + r);
		int num2 = obj + num;
		object obj5 = r - rectInt;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = obj5 == null;
		object obj6 = r ^ rectInt;
		object obj7 = r ^ obj5;
		object obj8 = obj6 & obj7;
		bool flag4 = (nint)obj8 < 0;
		bool flag5 = flag2 == flag4;
		object obj9 = !flag3;
		object obj10 = flag5 & obj9;
		object obj11 = ~obj10;
		RectInt rectInt2 = ((obj11 != null) ? rectInt : r);
		object obj12 = num - num2;
		bool flag6 = (nint)obj12 < 0;
		bool flag7 = obj12 == null;
		int num3 = num ^ num2;
		int num4 = num ^ obj12;
		int num5 = num3 & num4;
		bool flag8 = num5 < 0;
		bool flag9 = flag6 == flag8;
		object obj13 = !flag7;
		object obj14 = flag9 & obj13;
		object obj15 = ~obj14;
		int num6 = ((obj15 != null) ? num2 : num);
		int num7 = num6 - 1;
		RectInt rectInt3 = r;
		IntPtr intPtr = default;
		nint num8 = intPtr;
		RectInt rectInt4 = r;
		while (true)
		{
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj18 = obj2;
			if (rectInt2 == rectInt4)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Color32 c2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
			Set((int)rectInt4, num, c2);
			Color32 color2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
			Set((int)rectInt4, num7, color2);
			RectInt rectInt5 = (RectInt)(rectInt4 + 1);
			color = (Color32)num7;
			rectInt3 = rectInt4;
			num8 = (nint)color2;
			rectInt4 = rectInt5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
		bool flag12 = (nint)0 == 0;
		object obj20 = !flag12;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num9 = rectInt2 - 1;
		while (true)
		{
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v10+E4]");
			bool flag13 = (nint)0 == 0;
			object obj22 = !flag13;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (num6 != num)
			{
				object obj23 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v12+E4]");
				bool flag14 = (nint)0 == 0;
				object obj24 = !flag14;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Color32 c3 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
				Set((int)r, num, c3);
				Color32 color3 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
				Set(num9, num, color3);
				int num10 = num + 1;
				color = (Color32)num;
				rectInt3 = (RectInt)num9;
				num8 = (nint)color3;
				num = num10;
				continue;
			}
			break;
		}
	}

	private static RectInt TileRect(int i)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected VT, but got Unknown
		object obj = i * 1431655766;
		object obj2 = obj >> 63;
		object obj3 = obj >> 32;
		object obj4 = obj3 + obj2;
		object obj5 = obj4 + obj4;
		object obj6 = i - obj5;
		object obj7 = obj6 * 102;
		RectInt result = (RectInt)(10 + obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		return result;
	}

	private static bool Inside(RectInt r, Vector2Int p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I4
		//IL_002c: Invalid comparison between I and VT
		//IL_006a: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got VT
		//IL_00cc: Expected Obj, but got VT
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_031c: Invalid comparison between VT and I
		//IL_0155: Expected Obj, but got VT
		//IL_0163: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got VT
		//IL_0207: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) >= System.Runtime.CompilerServices.Unsafe.As<RectInt, UIntPtr>(ref r))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RectInt rectInt = (RectInt)(p + r);
			object obj6 = r - rectInt;
			bool flag3 = (nint)obj6 < 0;
			bool flag4 = obj6 == null;
			object obj7 = r ^ rectInt;
			object obj8 = r ^ obj6;
			object obj9 = obj7 & obj8;
			bool flag5 = (nint)obj9 < 0;
			bool flag6 = flag3 == flag5;
			object obj10 = !flag4;
			object obj11 = flag6 & obj10;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				rectInt = r;
			}
			if (rectInt > (object)num)
			{
				object obj13 = obj;
				object obj14 = r >> 32;
				object obj15 = num >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v9+E4]");
				bool flag7 = (nint)0 == 0;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
				{
					object obj17 = obj;
					object obj18 = p >> 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v11+E4]");
					bool flag8 = (nint)0 == 0;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj20 = obj18 + obj14;
					object obj21 = obj14 - obj20;
					bool flag9 = (nint)obj21 < 0;
					bool flag10 = obj21 == null;
					object obj22 = obj14 ^ obj20;
					object obj23 = obj14 ^ obj21;
					object obj24 = obj22 & obj23;
					bool flag11 = (nint)obj24 < 0;
					bool flag12 = flag9 == flag11;
					object obj25 = !flag10;
					object obj26 = flag12 & obj25;
					object obj27 = ~obj26;
					if (obj27 == null)
					{
						obj20 = obj14;
					}
					object obj28 = obj20 - obj15;
					bool flag13 = (nint)obj28 < 0;
					bool flag14 = obj28 == null;
					object obj29 = obj20 ^ obj15;
					object obj30 = obj20 ^ obj28;
					object obj31 = obj29 & obj30;
					bool flag15 = (nint)obj31 < 0;
					bool flag16 = flag13 == flag15;
					object obj32 = !flag14;
					return (byte)((flag16 & obj32) ? 1 : 0) != 0;
				}
			}
		}
		return false;
	}

	private Vector2Int ToPixel(Vector3 local)
	{
		//IL_00c5: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_00b0: Expected VT, but got F8
		Vector2 size = Size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default;
		object obj6 = obj7 / obj7;
		object obj9 = default;
		object obj8 = obj9 / obj9;
		double num = 0.5 - (double)obj6;
		double num2 = num * 1133510656.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num3 = (double)obj8 + 0.5;
		double num4 = num3 * 68.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		return (Vector2Int)(num4 | num2);
	}

	private Vector3 ToLocal(Vector2 p)
	{
		return Size;
	}

	public Vector3 TileAt(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_0188: Expected VT, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_0138: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tileRoot != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector2 size = Size;
			if ((object)tileRoot != null)
			{
				return tileRoot.TransformPoint((Vector3)0);
			}
		}
		else
		{
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				return transform.position;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public GameObject ModelOf(int i)
	{
		//IL_00c2: Expected I4, but got I8
		//IL_00dc: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		int num = (int)(i & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
			if (tiles != null)
			{
				if (list._size <= i)
				{
					goto IL_0098;
				}
				System.__Canon _Canon = ((List<System.__Canon>)(object)tiles).get_Item(i);
				if (_Canon != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8 (System.__Canon)+18]");
					return (GameObject)0;
				}
			}
			return (GameObject)(object)new NullReferenceException();
		}
		goto IL_0098;
		IL_0098:
		return null;
	}

	public void PickLabel(string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		//IL_0065: Expected I4, but got I8
		//IL_007f: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I8
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00c2: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<string> list = Kinds();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8AA8]");
		object obj4 = 0;
		int num = ((List<System.__Canon>)(object)list).IndexOf((System.__Canon)(object)label);
		int num2 = (int)(num & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			selected = label;
			object obj6 = num * 2863311531L;
			object obj7 = this + 272;
			int num3 = obj6 >> 34;
			page = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			MakeTiles();
			dirty = true;
		}
	}

	public GillaStash()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_02e4: Expected I4, but got I8
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_031d: Expected F4, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I8
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02b9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D50]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj6 = 0;
		lampSlot = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 80;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B7F0]");
		wakeRange = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj9 = this + 184;
		obj9 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj10 = this + 192;
		obj10 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj11 = this + 200;
		obj11 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list3 = default;
		list3._002Ector();
		object obj12 = this + 208;
		obj12 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = obj12 + 136;
		_ = -1;
		_ = 1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj12 + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = obj12 + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			object obj18 = array + 32;
			obj18 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X21_v7-8]");
			object obj19 = 0 & 0xFFFFFFFEL;
			if (obj19 != null)
			{
				object obj20 = array + 40;
				obj20 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj21 = this + 384;
				downOn = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj22 = this + 392;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E8B0]");
				obj22 = 0;
				base._002Ector();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static GillaStash()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		//IL_0376: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I
		//IL_03b0: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I
		//IL_03f2: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I
		//IL_04ba: Expected Obj, but got I
		//IL_04d4: Expected Obj, but got I
		//IL_04ee: Expected Obj, but got I
		//IL_0508: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj4 = 0;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F720]");
		obj6 = 0;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E090]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CB50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C910]");
		_ = 0;
		int num = Shader.PropertyToID((string)obj2);
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+A0]");
		object obj14 = 0;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj16 = 0;
		_ = 4278584838L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj17 = 0;
		object obj18 = obj4;
		_ = 4279045389L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj19 = !flag;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj4;
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v11+2C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj22 = 0;
		_ = 4284506208L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj23 = 0;
		_ = 4280821800L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj24 = 0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj25 = 0;
		_ = 4288059030L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A0]");
		object obj27 = (nint)0 + (nint)120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v17+8]");
		obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj28 = obj4;
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v11+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v18+A0]");
		object obj31 = (nint)0 + (nint)128;
		obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj32 = obj4;
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v13+A0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X9_v19+A0]");
		object obj35 = (nint)0 + (nint)136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+10]");
		obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj36 = obj4;
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v15+A0]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X9_v20+A0]");
		object obj39 = (nint)0 + (nint)144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v16+10]");
		obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v21+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v21+18]");
			bool flag2 = (nint)0 == 1;
			_ = 4278584838L;
			if (!flag2)
			{
				_ = 4278584838L;
				object obj40 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v20+A0]");
				object obj41 = (nint)0 + (nint)152;
				object obj42 = default;
				obj41 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v30+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v30+18]");
					bool flag3 = (nint)0 == 1;
					_ = 4294768368L;
					if (!flag3)
					{
						_ = 4291671712L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D78]");
						object obj43 = 0;
						object obj44 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5420]");
						object obj45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v24+A0]");
						object obj46 = (nint)0 + (nint)160;
						object obj47 = default;
						obj46 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj48 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v25+A0]");
						object obj49 = 0;
						_ = 4292793028L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v25+A0]");
						object obj50 = 0;
						_ = 4294636780L;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						List<System.__Canon> list = default;
						list._002Ector();
						object obj51 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v27+A0]");
						object obj52 = (nint)0 + (nint)176;
						obj52 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Dictionary<System.__Canon, System.__Canon> dictionary = default;
						dictionary._002Ector();
						object obj53 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v28+A0]");
						object obj54 = (nint)0 + (nint)184;
						obj54 = dictionary;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj55 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v29+A0]");
						object obj56 = 0;
						_ = 3212836864L;
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal static void _003CLearn_003Eg__Add_007C114_0(GameObject p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
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
		bool flag2 = p == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5350]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
		object obj7 = default;
		object obj6 = obj7 & 1;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ stack_-28_v4+38]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ stack_-28_v4+20]");
		bool flag5 = string.IsNullOrEmpty((string)0);
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89F8]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v14+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89E8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v4+B8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ stack_-28_v4+20]");
		bool flag8 = ((Dictionary<System.__Canon, System.__Canon>)num).ContainsKey((System.__Canon)0);
		bool flag9 = !flag8;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			object obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v18+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v18+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v7+B8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ stack_-28_v4+20]");
			((Dictionary<System.__Canon, System.__Canon>)num2).set_Item((System.__Canon)0, (System.__Canon)(object)p);
		}
	}

	private bool _003CTake_003Eb__123_0(GillaItem i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected I4, but got Unknown
		//IL_0058: Expected Obj, but got I4
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
		object obj4;
		if (i == null)
		{
			obj4 = 1;
		}
		else
		{
			bool flag2 = InHopper(i);
			obj4 = (flag2 ? 1 : 0) ^ 1;
		}
		return (byte)(obj4 & 1) != 0;
	}

	internal unsafe static void _003CWholeOf_003Eg__Add_007C134_0(Bounds x, ref _003C_003Ec__DisplayClass134_0 P_1)
	{
		//IL_000e: Expected Obj, but got Ref
		//IL_001c: Invalid comparison between VT and I4
		//IL_014d: Expected Obj, but got VT
		//IL_004d: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got VT
		//IL_01d1: Expected Obj, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_02e7: Invalid comparison between F8 and I4
		//IL_02f6: Invalid comparison between F8 and I4
		//IL_0309: Expected Obj, but got F8
		//IL_0316: Expected Obj, but got F8
		//IL_035f: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref P_1, 4));
		if (P_1 != (_003C_003Ec__DisplayClass134_0)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [x @ X0 (UnityEngine.Bounds)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [x @ X0 (UnityEngine.Bounds)+14]");
			object obj2 = num - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [x @ X0 (UnityEngine.Bounds)+8]");
			double num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [x @ X0 (UnityEngine.Bounds)+14]");
			double num3 = num2 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass134_0&)+C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass134_0&)+18]");
			object obj3 = num4 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass134_0&)+C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass134_0&)+18]");
			object obj4 = num5 + 0;
			object obj5 = x.m_Center - x.m_Extents;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				obj3 = obj2;
			}
			object obj6 = obj4 - obj2;
			bool flag = (nint)obj6 < 0;
			bool flag2 = obj6 == null;
			object obj7 = obj4 ^ obj2;
			object obj8 = obj4 ^ obj6;
			object obj9 = obj7 & obj8;
			bool flag3 = (nint)obj9 < 0;
			bool flag4 = flag == flag3;
			object obj10 = !flag2;
			object obj11 = flag4 & obj10;
			object obj12 = ~obj11;
			if (obj12 != null)
			{
				obj4 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
			object obj13 = obj4 - obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass134_0&)+10]");
			object obj14 = obj5 - 0;
			double num6 = (double)obj13 * 0.5;
			object obj15 = obj14 * 63;
			double num7 = (double)obj3 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass134_0&)+10]");
			object obj16 = 0 + obj15;
			double num8 = num7 - num6;
			double num9 = num6 + num7;
			object obj17 = obj15 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			if (!(num8 < num3))
			{
				num8 = num3;
			}
			double num10 = num9 - num3;
			bool flag5 = num10 < 0.0;
			bool flag6 = num10 == 0.0;
			object obj18 = num9 ^ num3;
			object obj19 = num9 ^ num10;
			object obj20 = obj18 & obj19;
			bool flag7 = (nint)obj20 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
			bool flag8 = flag5 == flag7;
			object obj21 = !flag6;
			object obj22 = flag8 & obj21;
			object obj23 = ~obj22;
			if (obj23 == null)
			{
				num3 = num9;
			}
			object obj24 = obj17 - obj16;
			double num11 = num3 - num8;
			object obj25 = obj24 * 63;
			double num12 = num11 * 0.5;
			object obj26 = obj16 + obj25;
			double num13 = num8 + num12;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [x @ X0 (UnityEngine.Bounds)+10]");
			_ = 0;
			obj = x.m_Center;
			ref _003C_003Ec__DisplayClass134_0 reference = ref *(_003C_003Ec__DisplayClass134_0*)1;
		}
	}

	internal static void _003CLooks_003Eg__Copy_007C144_0(Transform from, Mesh mesh, Material[] mats, ref GillaStashSave._003C_003Ec__DisplayClass144_0 P_3)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0063: Expected Obj, but got VT
		//IL_00b8: Expected VT, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_00cf: Expected VT, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_0294: Expected VT, but got I4
		//IL_0411: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I
		//IL_0432: Expected Obj, but got I
		//IL_0447: Expected VT, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_03b3: Expected VT, but got I4
		//IL_02fe: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I
		//IL_0386: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		string text = from.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(text);
		Transform transform = gameObject.transform;
		Transform parent = ((GameObject)P_3).transform;
		transform.SetParent(parent, worldPositionStays: false);
		Transform transform2 = gameObject.transform;
		Vector3 position = from.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass144_0&)+8]");
		Vector3 vector = ((Transform)0).InverseTransformPoint((Vector3)0);
		transform2.localPosition = (Vector3)0;
		Transform transform3 = gameObject.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass144_0&)+8]");
		Quaternion rotation = ((Transform)0).rotation;
		Quaternion rotation2 = default;
		Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
		Quaternion rotation3 = from.rotation;
		object obj3 = default;
		object obj2 = obj3 * obj3;
		object obj5 = default;
		object obj4 = obj5 * obj5;
		object obj7 = default;
		object obj6 = obj3 * obj7;
		object obj8 = obj7 * obj3;
		object obj10 = default;
		object obj9 = obj3 * obj10;
		object obj11 = obj10 * obj3;
		object obj12 = obj3 * obj5;
		object obj13 = obj5 * obj3;
		object obj14 = obj2 - obj4;
		object obj15 = obj10 * obj10;
		object obj16 = obj5 * obj7;
		object obj17 = obj6 + obj8;
		object obj18 = obj5 * obj10;
		object obj19 = obj7 * obj10;
		object obj20 = obj9 + obj11;
		object obj21 = obj7 * obj5;
		object obj22 = obj10 * obj5;
		object obj23 = obj12 + obj13;
		object obj24 = obj10 * obj7;
		object obj25 = obj7 * obj7;
		object obj26 = obj14 - obj15;
		object obj27 = obj18 + obj17;
		object obj28 = obj21 + obj20;
		object obj29 = obj24 + obj23;
		object obj30 = obj26 - obj25;
		object obj31 = obj27 - obj22;
		object obj32 = obj28 - obj16;
		object obj33 = obj29 - obj19;
		transform3.localRotation = (Quaternion)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
		object obj36 = 0;
		bool flag = false;
		Quaternion quaternion2 = (Quaternion)0;
		Transform transform4 = from;
		while (true)
		{
			object obj37 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj38 = !flag2;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(transform4 != null))
			{
				break;
			}
			object obj39 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v43+E4]");
			bool flag3 = (nint)0 == 0;
			object obj40 = !flag3;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform transform5 = transform4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass144_0&)+8]");
			if (!(transform5 != (UnityEngine.Object)0))
			{
				break;
			}
			Vector3 localScale = transform4.localScale;
			Transform parent2 = transform4.parent;
			flag = false;
			quaternion2 = (Quaternion)0;
			transform4 = parent2;
		}
		Transform transform6 = gameObject.transform;
		transform6.localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		MeshFilter meshFilter = default;
		meshFilter.sharedMesh = mesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Renderer renderer = default;
		renderer.sharedMaterials = mats;
		renderer.shadowCastingMode = (ShadowCastingMode)0;
	}
}
