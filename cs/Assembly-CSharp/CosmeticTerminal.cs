using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class CosmeticTerminal : MonoBehaviour
{
	private sealed class _003CWaitTrying_003Ed__145 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public int mine;

		private float _003Cuntil_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CWaitTrying_003Ed__145(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0076: Expected I4, but got I8
			//IL_01b7: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I4
			//IL_0155: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_01f1: Expected Obj, but got I
			//IL_00fd: Expected Obj, but got I4
			//IL_022a: Expected Obj, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected Obj, but got Unknown
			//IL_023e: Expected Obj, but got I4
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					return false;
				}
				_003C_003E1__state = -1;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				float num = realtimeSinceStartup + seconds;
				_003Cuntil_003E5__2 = num;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj2 = 0;
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			if (realtimeSinceStartup2 < _003Cuntil_003E5__2)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v13+A0]");
				object obj5 = 0;
				int num2 = mine;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v10+B4]");
				if ((nint)num2 == 0)
				{
					float realtimeSinceStartup3 = Time.realtimeSinceStartup;
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v16+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v16+A0]");
					object obj8 = 0;
					object obj9 = this + 24;
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 1;
					return true;
				}
			}
			float realtimeSinceStartup4 = Time.realtimeSinceStartup;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v9+A0]");
			object obj12 = 0;
			return false;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private class Tile
	{
		public GameObject root;

		public GameObject model;

		public byte id;

		public int title;

		public int bundle = -1;

		public int outfit;

		public int monster;

		public float pop;

		public Vector2 at;

		public Vector2 to;

		public float k = 1f;

		public float kV;

		public Vector2 lean;

		public Vector2 leanV;

		public RectInt place;
	}

	public Renderer screen;

	public Transform tileRoot;

	public ScrollDrum drum;

	public TryOnTube tube;

	public ParticleSystem buyCoins;

	public Transform[] fingertips;

	public TextAsset titleFont;

	public TextAsset textFont;

	public Material wire;

	public Material wirePicked;

	public float wakeRange;

	public AudioClip clickSound;

	public AudioClip hoverSound;

	public AudioClip bootSound;

	public AudioClip offSound;

	public AudioClip buySound;

	public AudioClip errorSound;

	public AudioClip coinSound;

	public AudioClip equipSound;

	public AudioClip sparkleSound;

	public AudioClip toggleSound;

	public AudioClip fillSound;

	private const int W = default(int);

	private const int H = default(int);

	private static readonly int BaseMap;

	private const CosmeticSlot BundleSlot = default(CosmeticSlot);

	private const CosmeticSlot TitleSlot = default(CosmeticSlot);

	private const CosmeticSlot SavedSlot = default(CosmeticSlot);

	private const CosmeticSlot MonsterSlot = default(CosmeticSlot);

	private static readonly (string, CosmeticSlot)[] Categories;

	private static readonly string[] Filters;

	private static readonly RectInt ShowRect;

	private const int CatX = default(int);

	private const int CatY = default(int);

	private const int CatW = default(int);

	private const int CatH = default(int);

	private const int CatStep = default(int);

	private const int CatRows = default(int);

	private const int GridX = default(int);

	private const int GridY = default(int);

	private const int TileW = default(int);

	private const int TileH = default(int);

	private const int TileGap = default(int);

	private const int Cols = default(int);

	private const int Rows = default(int);

	private static readonly RectInt UpRect;

	private static readonly RectInt DownRect;

	private static readonly RectInt CartRect;

	private static readonly RectInt WalletRect;

	private static readonly RectInt ButtonRect;

	private static readonly Color32 Black;

	private static readonly Color32 Scan;

	private static readonly Color32 Line;

	private static readonly Color32 Dim;

	private static readonly Color32 Dark;

	private static readonly Color32 Bright;

	private static readonly Color32 White;

	private static readonly Color32 Warn;

	private static readonly Color32 Grey;

	private static readonly Color32 Coin;

	private static readonly Color32[] Plain;

	private static readonly Color32[] Picked;

	private static readonly Color32[] DimText;

	private static readonly Color32[] Warning;

	private static readonly Color32[] DarkText;

	private const float GlideRate = default(float);

	private const float FrontFrom = default(float);

	private const float FrontWide = default(float);

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private readonly Tile[] tiles;

	private readonly List<Tile> leaving;

	private Color32[] underneath;

	private int glideDir;

	private float catAt;

	private float firstAt;

	private readonly List<byte> shown;

	private readonly List<int> shownBundles;

	private readonly List<int> shownTitles;

	private readonly List<int> shownOutfits;

	private readonly List<int> shownMonsters;

	private readonly byte[] cart;

	private readonly byte[] tryOn;

	private int category;

	private int filter;

	private int scroll;

	private float barAt;

	private int catFirst;

	private byte picked;

	private int pickedBundle;

	private int pickedTitle;

	private int pickedOutfit;

	private int pickedMonster;

	private int deleteArmed;

	private float armedAt;

	private int drumAt;

	private float awake;

	private bool wanted;

	private float holdFill;

	private float banner;

	private float reboot;

	private float pressFlash;

	private string bannerText;

	private bool bannerBad;

	private string hovered;

	private string pressedThing;

	private readonly bool[] down;

	private readonly string[] downOn;

	private bool mouseDown;

	private bool dirty;

	private int lastBalance;

	private Vector3 overAt;

	private float[] tabPush;

	private float[] tabPushV;

	private const float MonsterTileSize = default(float);

	private const float MonsterTileDrop = default(float);

	private const float PopSeconds = default(float);

	private const float PopStagger = default(float);

	private static int MonsterNow
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I
			//IL_0070: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF348]");
			object fallback = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return MonsterChoice.NumberOr((string)fallback);
		}
	}

	private Vector2 Size
	{
		get
		{
			//IL_00c3: Expected VT, but got Obj
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
	}

	private static bool IsBundles(int c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)c;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj7 = -c;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
				object obj10 = (nint)0 + (nint)c;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
				object obj11 = -255;
				return obj11 == null;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private static bool IsTitles(int c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)c;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj7 = -c;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
				object obj10 = (nint)0 + (nint)c;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
				object obj11 = -254;
				return obj11 == null;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private static bool IsSaved(int c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)c;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj7 = -c;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
				object obj10 = (nint)0 + (nint)c;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
				object obj11 = -253;
				return obj11 == null;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private static bool IsMonsters(int c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)c;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj7 = -c;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
				object obj10 = (nint)0 + (nint)c;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
				object obj11 = -252;
				return obj11 == null;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private static Color32 C(byte r, byte g, byte b)
	{
		//IL_0045: Expected VT, but got I8
		int num = g & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02e0: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_028c: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		bool flag2 = !isPlaying;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(screen == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(512, 256, (TextureFormat)4, mipChain: true);
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF278]");
			object obj9 = 0;
			texture2D.name = (string)obj9;
			texture2D.hideFlags = (HideFlags)52;
			object obj10 = this + 208;
			obj10 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj12 = this + 216;
			object obj13 = default;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v26+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v8-88]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			object obj16 = 0;
			ScreenFont screenFont = null;
			if (!flag6)
			{
				string baked = titleFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont2 = default;
				screenFont2._002Ector(baked);
				obj16 = 0;
				screenFont = screenFont2;
			}
			object obj18 = this + 232;
			obj18 = screenFont;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj19 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v33+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v7-90]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			object obj21 = 0;
			ScreenFont screenFont3 = null;
			if (!flag9)
			{
				string baked2 = textFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont4 = default;
				screenFont4._002Ector(baked2);
				obj21 = 0;
				screenFont3 = screenFont4;
			}
			object obj23 = this + 240;
			obj23 = screenFont3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			awake = 0f;
			Draw();
		}
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05b2: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_032e: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I
		//IL_04c2: Expected I, but got Obj
		//IL_04d7: Expected Obj, but got I
		//IL_0501: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I4
		//IL_0544: Expected F4, but got I4
		//IL_0550: Expected F4, but got I4
		//IL_038d: Expected I, but got Obj
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Texture2D texture2D = default;
		texture2D._002Ector(512, 256, (TextureFormat)4, mipChain: true);
		texture2D.filterMode = (FilterMode)0;
		texture2D.wrapMode = (TextureWrapMode)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF278]");
		object obj5 = 0;
		texture2D.name = (string)obj5;
		object obj6 = this + 208;
		obj6 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 216;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v21+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7-88]");
		bool flag3 = (UnityEngine.Object)0 != null;
		bool flag4 = !flag3;
		object obj13 = 0;
		ScreenFont screenFont = null;
		if (!flag4)
		{
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			obj13 = 0;
			screenFont = screenFont2;
		}
		object obj15 = this + 232;
		obj15 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj16 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v28+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X21_v8-90]");
		bool flag6 = (UnityEngine.Object)0 != null;
		bool flag7 = !flag6;
		object obj18 = 0;
		ScreenFont screenFont3 = null;
		if (!flag7)
		{
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			obj18 = 0;
			screenFont3 = screenFont4;
		}
		object obj20 = this + 240;
		obj20 = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X21_v11+8]");
		Tile[] array = (Tile[])0;
		object obj21 = 32;
		ScreenFont screenFont5 = screenFont3;
		int num = 0;
		IndexOutOfRangeException ex = default;
		Action action = default;
		while (true)
		{
			if (num < array.Length)
			{
				Tile tile = MakeTile(num);
				bool flag8 = tile == null;
				int num2 = num;
				int num4;
				if (!flag8)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v29 (Il2CppClass<Tile[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag9 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v29 (Il2CppClass<Tile[]>)+40]");
					num4 = 0;
					if (flag9)
					{
						break;
					}
				}
				bool flag10 = num < array.Length;
				object obj22 = !flag10;
				if (obj22 == null)
				{
					object obj23 = array + num;
					object obj24 = (object)array + obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					array = tiles;
					num++;
					obj21 += 8;
					bool flag11 = tiles == null;
					object obj25 = !flag11;
					screenFont5 = (ScreenFont)(object)tile;
					if (obj25 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				ex = new IndexOutOfRangeException();
				num4 = num2;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF288]");
			object obj27 = 0;
			action._002Ector(this, (IntPtr)obj27);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v38+E4]");
			bool flag12 = (nint)0 == 0;
			object obj30 = !flag12;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coins.Changed += action;
			Refill();
			SyncDrum();
			catAt = category;
			firstAt = catFirst;
			Draw();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF288]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coins.Changed -= action;
	}

	private void OnCoins()
	{
		dirty = true;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b6c: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_0ba4: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I4
		//IL_04ab: Invalid comparison between Obj and F8
		//IL_0ca6: Expected Obj, but got I4
		//IL_0568: Expected Obj, but got I4
		//IL_06ff: Expected F8, but got I4
		//IL_06df: Expected Obj, but got I
		//IL_0596: Expected Obj, but got I4
		//IL_04d4: Invalid comparison between F8 and I4
		//IL_04e3: Invalid comparison between F8 and I4
		//IL_04f6: Expected Obj, but got F8
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_052b: Expected Obj, but got I4
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected I4, but got Unknown
		//IL_0c64: Expected Obj, but got I
		//IL_0c82: Expected F4, but got I
		//IL_0c82: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I4
		//IL_0e08: Invalid comparison between F8 and I4
		//IL_0e1b: Expected Obj, but got F8
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected Obj, but got Unknown
		//IL_0e59: Expected Obj, but got I4
		//IL_0714: Expected Obj, but got I
		//IL_071d: Expected F8, but got I4
		//IL_0bc2: Expected Obj, but got I
		//IL_0bec: Expected Obj, but got I4
		//IL_0cf6: Expected Obj, but got I4
		//IL_0d0e: Invalid comparison between F4 and I4
		//IL_0d1f: Expected Obj, but got I4
		//IL_0e79: Invalid comparison between F4 and I4
		//IL_0e8a: Expected Obj, but got I4
		//IL_0e93: Invalid comparison between F4 and I4
		//IL_0ea4: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I4
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_0606: Expected Obj, but got I4
		//IL_07f3: Expected Obj, but got I4
		//IL_0771: Invalid comparison between F4 and I4
		//IL_0782: Expected Obj, but got I4
		//IL_078d: Invalid comparison between F4 and I4
		//IL_079e: Expected Obj, but got I4
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Obj, but got Unknown
		//IL_0927: Invalid comparison between F4 and I4
		//IL_0d76: Invalid comparison between F4 and I4
		//IL_0d95: Invalid comparison between F4 and I4
		//IL_0958: Invalid comparison between F4 and I4
		//IL_0969: Expected Obj, but got I4
		//IL_0972: Invalid comparison between F4 and I4
		//IL_098d: Expected Obj, but got I4
		//IL_02fe: Unsupported input type for neg.
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0364: Invalid comparison between F8 and I
		//IL_0ed9: Expected Obj, but got I
		//IL_0f03: Expected Obj, but got I4
		//IL_0385: Invalid comparison between Obj and F4
		//IL_0acb: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
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
		float deltaTime = Time.deltaTime;
		Camera main = Camera.main;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = main != null;
		bool flag4 = !flag3;
		UnityEngine.Object obj7 = null;
		UnityEngine.Object obj8 = null;
		if (!flag4)
		{
			Camera main2 = Camera.main;
			if ((object)main2 == null)
			{
				goto IL_0b2d;
			}
			Transform transform = main2.transform;
			obj7 = null;
			obj8 = transform;
		}
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num4;
		float num5;
		object obj24;
		UnityEngine.Object obj25;
		float num12;
		bool flag8;
		bool flag9;
		if (obj8 != null)
		{
			if ((object)obj8 != null)
			{
				Vector3 position = ((Transform)obj8).position;
				if ((object)screen != null)
				{
					Transform transform2 = screen.transform;
					if ((object)transform2 != null)
					{
						Vector3 position2 = transform2.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v58+E4]");
						bool flag6 = (nint)0 == 0;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 position3 = ((Transform)obj8).position;
						Transform transform3 = base.transform;
						if ((object)transform3 != null)
						{
							Vector3 position4 = transform3.position;
							Transform transform4 = base.transform;
							if ((object)transform4 != null)
							{
								Vector3 forward = transform4.forward;
								Transform transform5 = base.transform;
								if ((object)transform5 != null)
								{
									object obj15 = default;
									object obj14 = obj15 - obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									float num = deltaTime - deltaTime;
									object obj17 = default;
									object obj16 = obj17 - obj17;
									object obj18 = obj15 - obj15;
									object obj19 = obj17 * obj16;
									object obj20 = 0 - obj19;
									float num2 = num * deltaTime;
									float num3 = (float)obj20 - num2;
									object obj21 = obj18 * obj15;
									num4 = (double)num3 - (double)obj21;
									Vector3 right = transform5.right;
									num5 = wakeRange;
									double num6 = num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
									if (num6 > 0.0 && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)wakeRange))
									{
										float num7 = num * num3;
										object obj22 = obj16 * obj21;
										float num8 = num7 + (float)obj22;
										object obj23 = obj18 * obj14;
										float num9 = (float)obj23 + num8;
										double num10 = num4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
										double num11 = num10 + 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
										bool flag7 = !((double)num9 < num11);
										obj24 = obj15;
										obj25 = null;
										num12 = deltaTime;
										if (!flag7)
										{
											flag8 = wanted;
											obj25 = null;
											num12 = deltaTime;
											flag9 = true;
											goto IL_0c26;
										}
									}
									else
									{
										obj24 = obj15;
										obj25 = null;
										num12 = deltaTime;
									}
									goto IL_0bfa;
								}
							}
						}
					}
				}
			}
			goto IL_0b2d;
		}
		num5 = wakeRange;
		obj24 = 1120272384;
		num4 = -1.0;
		obj25 = null;
		num12 = deltaTime;
		goto IL_0bfa;
		IL_0c26:
		bool flag10 = flag8 == flag9;
		AudioClip audioClip = (AudioClip)obj25;
		if (flag10)
		{
			goto IL_068e;
		}
		bool flag11 = !flag9;
		object obj26 = !flag11;
		object obj27 = ~obj26;
		if (obj27 == null)
		{
			object obj28 = 136;
		}
		else
		{
			object obj28 = 144;
		}
		wanted = flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CosmeticTerminal)+v712 @ X8_v31]");
		audioClip = (AudioClip)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CosmeticTerminal)+v712 @ X8_v31]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		Play((AudioClip)num13, 0f);
		if (flag9)
		{
			Tile[] array = tiles;
			if (tiles != null)
			{
				if (array.Length < 1)
				{
					goto IL_068e;
				}
				object obj29 = ~array.Length;
				object obj30 = array.Length & obj29;
				object obj31 = 0;
				while (true)
				{
					object obj32 = (object)tiles + obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X12_v5+20]");
					if ((nint)0 == 0)
					{
						break;
					}
					object obj33 = obj31 + 1;
					object obj34 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
					object obj35 = obj34 * 0;
					bool flag12 = obj30 != obj33;
					obj31 = obj33;
					if (flag12)
					{
						continue;
					}
					goto IL_068e;
				}
			}
			goto IL_0b2d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		object obj36 = 0;
		double num14 = 0.0;
		goto IL_0ddf;
		IL_068e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		obj36 = 0;
		bool flag13 = !flag9;
		object obj37 = !flag13;
		object obj38 = ~obj37;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			obj36 = 0;
		}
		object obj39 = !flag13;
		object obj40 = ~obj39;
		num14 = ((obj40 != null) ? 0.0 : 1.0);
		goto IL_0ddf;
		IL_0ddf:
		float num15 = num12 / (float)obj36;
		double num16 = num14 - (double)awake;
		bool flag14 = num16 < 0.0;
		object obj41 = num16 ^ num16;
		object obj42 = num16 & obj41;
		bool flag15 = (nint)obj42 < 0;
		float num17 = 0f - num15;
		bool flag16 = flag14 == flag15;
		object obj43 = !flag16;
		object obj44 = ~obj43;
		float num18 = ((obj44 != null) ? num15 : num17);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num19 = awake + num18;
		bool flag17 = num17 < num15;
		object obj45 = !flag17;
		float num20 = num17 - num15;
		bool flag18 = num20 == 0f;
		object obj46 = !flag18;
		object obj47 = obj45 & obj46;
		object obj48 = ~obj47;
		float num21 = ((obj48 != null) ? ((float)num14) : num19);
		bool flag19 = num21 == awake;
		awake = num21;
		if (!flag19)
		{
			dirty = true;
		}
		bool flag20 = num21 < 0f;
		object obj49 = !flag20;
		bool flag21 = num21 == 0f;
		object obj50 = !flag21;
		object obj51 = obj49 & obj50;
		if (obj51 == null)
		{
			bool flag22 = awake < 0f;
			object obj52 = !flag22;
			bool flag23 = awake == 0f;
			object obj53 = !flag23;
			object obj54 = obj52 & obj53;
			if (obj54 == null)
			{
				ShowTiles(0f, num12);
				return;
			}
		}
		object obj55 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v20+E4]");
		bool flag24 = (nint)0 == 0;
		object obj56 = !flag24;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = drum != null;
		bool flag26 = !flag25;
		int num22 = 0;
		if (!flag26)
		{
			if ((object)drum == null)
			{
				goto IL_0b2d;
			}
			int step = drum.Step;
			bool flag27 = step == drumAt;
			num22 = 0;
			if (!flag27)
			{
				if ((object)drum == null)
				{
					goto IL_0b2d;
				}
				int step2 = drum.Step;
				Rolled(step2);
				num22 = step2;
			}
		}
		double num23 = awake;
		if (!((double)awake < 1.0))
		{
			Touch(num12);
		}
		if (banner > 0f)
		{
			float num24 = banner - num12;
			bool flag28 = num24 < 0f;
			object obj57 = !flag28;
			bool flag29 = num24 == 0f;
			banner = num24;
			object obj58 = !flag29;
			object obj59 = obj57 & obj58;
			if (obj59 == null)
			{
				dirty = true;
			}
		}
		if (!(reboot < 0f))
		{
			dirty = true;
			float num25 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			float num26 = num25 / 0f;
			bool flag30 = (double)(reboot = num26 + reboot) < 1.0;
			num23 = 1.0;
			if (!flag30)
			{
				reboot = -1f;
				num23 = 1.0;
			}
		}
		if (pressFlash > 0f)
		{
			float num27 = pressFlash - num12;
			dirty = true;
			pressFlash = num27;
		}
		Tabs(num12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj60 = 0;
		object obj61 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v27+E4]");
		bool flag31 = (nint)0 == 0;
		object obj62 = !flag31;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int balance = Coins.Balance;
		if (balance != lastBalance)
		{
			object obj63 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v35+E4]");
			bool flag32 = (nint)0 == 0;
			object obj64 = !flag32;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int balance2 = Coins.Balance;
			lastBalance = balance2;
			dirty = true;
		}
		GlideTabs(num12);
		ShowTiles(awake, num12);
		if (~(dirty ? 1u : 0u) == 0)
		{
			Draw();
		}
		return;
		IL_0bfa:
		flag8 = wanted;
		bool flag33 = (byte)(~(wanted ? 1u : 0u)) != 0;
		flag9 = false;
		if (!flag33)
		{
			double num28 = (double)num5 + 1.5;
			bool flag34 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num28);
			flag9 = false;
			if (!flag34)
			{
				bool flag35 = num4 < 0.0;
				bool flag36 = num4 == 0.0;
				object obj65 = num4 ^ num4;
				object obj66 = num4 & obj65;
				bool flag37 = (nint)obj66 < 0;
				bool flag38 = flag35 == flag37;
				object obj67 = !flag36;
				bool flag39 = (byte)((flag38 & obj67) ? 1 : 0) != 0;
				flag8 = true;
				flag9 = flag39;
			}
		}
		goto IL_0c26;
		IL_0b2d:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Touch(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1031: Expected Obj, but got I
		//IL_1041: Expected Obj, but got I
		//IL_1052: Expected Obj, but got I4
		//IL_106c: Expected Obj, but got I4
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_0753: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0a5e: Expected Obj, but got I4
		//IL_118c: Expected Obj, but got I
		//IL_11a4: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0118: Expected VT, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_0a8a: Expected Obj, but got I4
		//IL_0799: Expected Obj, but got I4
		//IL_0aae: Expected Obj, but got I4
		//IL_0bfa: Expected Obj, but got I
		//IL_0c25: Expected Obj, but got I4
		//IL_0c2e: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0ad1: Invalid comparison between F4 and I4
		//IL_11d9: Expected Obj, but got I
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected Obj, but got Unknown
		//IL_0c4c: Expected Obj, but got I
		//IL_0c75: Expected Obj, but got I4
		//IL_0c86: Expected Obj, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0b3f: Invalid comparison between F4 and I4
		//IL_0b52: Expected Obj, but got F4
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected Obj, but got Unknown
		//IL_0b91: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I
		//IL_13da: Expected Obj, but got I4
		//IL_13f2: Invalid comparison between F4 and I4
		//IL_1412: Expected Obj, but got I4
		//IL_0826: Expected Obj, but got I
		//IL_0bc8: Expected F4, but got I4
		//IL_01f5: Expected VT, but got I4
		//IL_0204: Expected VT, but got I4
		//IL_1449: Expected F8, but got I4
		//IL_0855: Expected VT, but got I4
		//IL_021c: Expected VT, but got I4
		//IL_025d: Invalid comparison between F4 and I4
		//IL_026c: Invalid comparison between F4 and I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got F4
		//IL_02c9: Expected Obj, but got I4
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_108a: Expected Obj, but got I4
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected Obj, but got Unknown
		//IL_120e: Expected Obj, but got I
		//IL_1238: Expected Obj, but got I4
		//IL_08ff: Expected Obj, but got I4
		//IL_0938: Expected Obj, but got I4
		//IL_0941: Expected Obj, but got I4
		//IL_094a: Expected Obj, but got I4
		//IL_10be: Invalid comparison between F4 and I
		//IL_0392: Invalid comparison between F4 and I4
		//IL_10f5: Expected VT, but got I4
		//IL_1498: Expected Obj, but got I
		//IL_095c: Unsupported input type for neg.
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_0972: Unsupported input type for neg.
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got Unknown
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected Obj, but got Unknown
		//IL_03bb: Invalid comparison between F4 and I
		//IL_061a: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got I
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_0660: Expected Obj, but got I4
		//IL_03fe: Expected VT, but got F4
		//IL_1265: Expected Obj, but got I
		//IL_1291: Expected Obj, but got I
		//IL_12b8: Expected F4, but got I
		//IL_12d8: Invalid comparison between F4 and I4
		//IL_12e7: Invalid comparison between F4 and I4
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1302: Expected Obj, but got Unknown
		//IL_130f: Expected Obj, but got F8
		//IL_1344: Expected Obj, but got I4
		//IL_134c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Expected Obj, but got Unknown
		//IL_068c: Expected I, but got Obj
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0a2c: Expected F8, but got I
		//IL_067f: Expected I, but got Obj
		//IL_1371: Invalid comparison between I4 and F8
		//IL_1383: Expected F4, but got I4
		//IL_05a4: Expected VT, but got I4
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected Obj, but got Unknown
		//IL_0da4: Invalid comparison between F4 and I4
		//IL_06ac: Expected Obj, but got I4
		//IL_05d1: Expected VT, but got I4
		//IL_04df: Expected Obj, but got I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected Obj, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_0511: Expected Obj, but got I
		//IL_0ea5: Expected VT, but got I4
		//IL_0eb4: Expected VT, but got I4
		//IL_0ecc: Expected VT, but got I4
		//IL_0f19: Expected VT, but got F4
		//IL_0f46: Expected Obj, but got I4
		//IL_0fe7: Expected I4, but got I8
		//IL_0f89: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2D8]");
		object obj3 = 0;
		string text = (string)obj;
		object obj4 = 32;
		int num = 0;
		float num2 = dt;
		object obj5 = 17276928;
		object obj60 = default;
		object obj62 = default;
		object obj75 = default;
		float num26 = default;
		object obj92 = default;
		object obj94 = default;
		float num6 = default;
		while (true)
		{
			Transform[] array = fingertips;
			bool flag = fingertips == null;
			float num3 = num2;
			string text2;
			bool flag16;
			Vector3 vector;
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
						goto IL_101a;
					}
					object obj7 = obj2;
					object obj8 = fingertips + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v77+E4]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v77+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v64+20]");
					bool flag5 = (UnityEngine.Object)0 == null;
					bool flag6 = !flag5;
					object obj10 = !flag6;
					num3 = num2;
					vector = (Vector3)0;
					nint num4 = unchecked((nint)null);
					if (obj10 == null)
					{
						Transform[] array2 = fingertips;
						if (fingertips != null)
						{
							bool flag7 = num < array2.Length;
							object obj11 = !flag7;
							if (obj11 != null)
							{
								goto IL_101a;
							}
							object obj12 = fingertips + num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v66+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v66+20]");
								Vector3 position = ((Transform)0).position;
								if ((object)tileRoot != null)
								{
									Vector3 vector2 = tileRoot.InverseTransformPoint((Vector3)0);
									Vector2Int at = ToPixel((Vector3)0);
									text2 = Hit(at, (Vector3)0);
									if (text2 != null)
									{
										float num5 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF44]");
										float num7 = num5 - 0f;
										bool flag8 = num7 < 0f;
										bool flag9 = num7 == 0f;
										float num8 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF44]");
										object obj13 = num8 ^ 0;
										object obj14 = num6 ^ num7;
										object obj15 = obj13 & obj14;
										bool flag10 = (nint)obj15 < 0;
										bool flag11 = flag8 == flag10;
										object obj16 = !flag9;
										object obj17 = flag11 & obj16;
										object obj18 = ~obj17;
										bool flag12;
										bool flag13;
										bool flag14;
										if (obj18 == null)
										{
											flag12 = text2._stringLength < 0;
											flag13 = text2._stringLength == 0;
											int num9 = text2._stringLength ^ text2._stringLength;
											int num10 = text2._stringLength & num9;
											flag14 = num10 < 0;
										}
										else
										{
											flag14 = false;
											flag13 = true;
											flag12 = false;
										}
										bool flag15 = flag12 == flag14;
										object obj19 = !flag13;
										object obj20 = flag15 & obj19;
										object obj21 = ~obj20;
										if (obj21 == null)
										{
											float num11 = num6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
											float num12 = num11 - 0f;
											flag16 = num12 < 0f;
										}
										else
										{
											flag16 = false;
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
										bool flag17 = !flag16;
										num3 = num2;
										vector = (Vector3)0;
										if (flag17)
										{
											goto IL_05d6;
										}
										bool[] array3 = down;
										if (down != null)
										{
											bool flag18 = num < array3.Length;
											object obj22 = !flag18;
											if (obj22 == null)
											{
												object obj23 = down + num;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v73+20]");
												if ((nint)0 != 0)
												{
													string[] array4 = downOn;
													if (downOn == null)
													{
														goto IL_100c;
													}
													bool flag19 = num < array4.Length;
													object obj24 = !flag19;
													if (obj24 != null)
													{
														goto IL_101a;
													}
													object obj25 = downOn + num;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v78+20]");
													if (!(text2 != (string)0) || !(text2 != (string)obj3))
													{
														goto IL_0573;
													}
												}
												Press(text2, num);
												goto IL_0573;
											}
											goto IL_101a;
										}
									}
								}
							}
						}
						goto IL_100c;
					}
				}
			}
			goto IL_06ec;
			IL_101a:
			throw new IndexOutOfRangeException();
			IL_0a31:
			bool isPressed;
			mouseDown = isPressed;
			goto IL_1153;
			IL_1153:
			bool[] array5 = down;
			if (down != null)
			{
				bool flag20 = (byte)(~(array5[0] ? 1u : 0u)) != 0;
				object obj26 = !flag20;
				if (obj26 == null)
				{
					bool flag21 = (byte)(~(array5[1] ? 1u : 0u)) != 0;
					object obj27 = !flag21;
					if (obj27 == null)
					{
						bool flag22 = (byte)(~(mouseDown ? 1u : 0u)) != 0;
						object obj28 = !flag22;
						if (obj28 == null)
						{
							num3 = holdFill;
							if (holdFill > 0f)
							{
								dirty = true;
								float num15 = dt * 3f;
								float num16 = dt * 3f;
								num6 = 0f - num16;
								float num17 = 0f - holdFill;
								bool flag23 = num17 < 0f;
								object obj29 = num17 ^ num17;
								object obj30 = num17 & obj29;
								bool flag24 = (nint)obj30 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								bool flag25 = flag23 == flag24;
								object obj31 = !flag25;
								object obj32 = ~obj31;
								if (obj32 != null)
								{
									num6 = num15;
								}
								bool flag26 = num17 < num15;
								object obj33 = !flag26;
								float num18 = num17 - num15;
								bool flag27 = num18 == 0f;
								num3 += num6;
								object obj34 = !flag27;
								object obj35 = obj33 & obj34;
								object obj36 = ~obj35;
								if (obj36 != null)
								{
									num3 = 0f;
								}
								holdFill = num3;
								double num19 = 0.0;
							}
						}
					}
				}
				if (!(text != hovered))
				{
					break;
				}
				if (text != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E0]");
					object value = 0;
					bool flag28 = text.StartsWith((string)value);
					bool flag29 = !flag28;
					object obj37 = !flag29;
					object obj38 = 0;
					double num20;
					object obj39;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
						object value2 = 0;
						bool flag30 = text.StartsWith((string)value2);
						bool flag31 = !flag30;
						obj38 = 0;
						num20 = num3;
						obj39 = 0;
						if (flag31)
						{
							goto IL_0cc3;
						}
					}
					Play(hoverSound, 0.25f);
					num20 = 0.25;
					obj39 = obj38;
					goto IL_0cc3;
				}
			}
			goto IL_100c;
			IL_0573:
			bool flag32 = text2 == (string)obj3;
			bool flag33 = !flag32;
			num3 = num2;
			vector = (Vector3)0;
			if (!flag33)
			{
				Hold(dt, num);
				num3 = dt;
				vector = (Vector3)0;
			}
			goto IL_05d6;
			IL_100c:
			NullReferenceException ex = new NullReferenceException();
			goto IL_101a;
			IL_0cc3:
			object obj40 = this + 440;
			hovered = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			dirty = true;
			break;
			IL_05d6:
			bool[] array6 = down;
			if (down == null)
			{
				goto IL_100c;
			}
			bool flag34 = num < array6.Length;
			object obj41 = !flag34;
			if (obj41 == null)
			{
				object obj42 = down + num;
				bool flag35 = !flag16;
				string[] array7 = downOn;
				object obj43 = !flag35;
				object obj44 = ~obj43;
				if (obj44 == null)
				{
					nint num4 = (nint)text2;
				}
				else
				{
					nint num4 = (nint)obj;
				}
				if (downOn == null)
				{
					goto IL_100c;
				}
				bool flag36 = num < array7.Length;
				object obj45 = !flag36;
				if (obj45 == null)
				{
					obj5 = downOn + num;
					object obj46 = (object)downOn + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_06ec;
				}
			}
			goto IL_101a;
			IL_06ec:
			num++;
			obj4 += 8;
			bool flag37 = num != 2;
			num2 = num3;
			if (flag37)
			{
				continue;
			}
			bool isDeviceActive = XRSettings.isDeviceActive;
			bool flag38 = !isDeviceActive;
			object obj47 = !flag38;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj48 = 0;
				object obj49 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v25+A0]");
				object obj50 = 0;
				if (obj50 != null)
				{
					Camera main = Camera.main;
					object obj51 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v28+E4]");
					bool flag39 = (nint)0 == 0;
					object obj52 = !flag39;
					if (obj52 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (main != null)
					{
						Camera main2 = Camera.main;
						object obj53 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X8_v31+A0]");
						object obj54 = 0;
						object obj55 = obj54;
						if (obj54 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v33+188]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v33+188]");
								Vector2 vector3 = ((InputControl<Vector2>)0).ReadValue();
								if ((object)main2 != null)
								{
									Ray ray = main2.ScreenPointToRay((Vector3)0);
									if ((object)tileRoot != null)
									{
										Vector3 forward = tileRoot.forward;
										if ((object)tileRoot != null)
										{
											Vector3 position2 = tileRoot.position;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
											object obj56 = 0;
											object obj57 = obj56;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v41+E4]");
											bool flag40 = (nint)0 == 0;
											object obj58 = !flag40;
											if (obj58 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj59 = obj60 * obj60;
											object obj61 = obj62 * obj62;
											object obj63 = obj59 + obj61;
											object obj64 = 0 * 0;
											object obj65 = obj64 + obj63;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
											bool flag41 = (nint)obj65 <= 0;
											object obj66 = 0;
											object obj67 = 0;
											object obj68 = 0;
											if (!flag41)
											{
												object obj69 = 0 - obj60;
												obj68 = obj69 / obj65;
												object obj70 = 0 - obj62;
												obj67 = obj70 / obj65;
												obj66 = 0 / obj65;
											}
											object obj71 = obj48;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v45+A0]");
											object obj72 = 0;
											object obj73 = obj72;
											if (obj72 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v47+1C0]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v47+1C0]");
													isPressed = ((ButtonControl)0).isPressed;
													object obj74 = obj75 * obj68;
													object obj76 = obj62 * obj67;
													object obj77 = obj74 + obj76;
													object obj78 = obj60 * obj66;
													object obj79 = obj77 + obj78;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
													object obj80 = 0;
													object obj81 = obj80;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ X8_v52+A0]");
													object obj82 = 0;
													double num21 = (double)obj78;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
													double num19 = num21 * 0.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v53+4]");
													num6 = 0f;
													float num22 = (float)num19;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v53+4]");
													float num23 = num22 - 0f;
													bool flag42 = num23 < 0f;
													bool flag43 = num23 == 0f;
													double num24 = num19;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v53+4]");
													object obj83 = num24 ^ 0;
													object obj84 = num19 ^ (double)num23;
													object obj85 = obj83 & obj84;
													bool flag44 = (nint)obj85 < 0;
													bool flag45 = flag42 == flag44;
													object obj86 = !flag43;
													object obj87 = flag45 & obj86;
													object obj88 = ~obj87;
													if (obj88 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v53+4]");
														num19 = 0.0;
													}
													bool flag46 = !(0.0 < num19);
													num3 = 0f;
													if (flag46)
													{
														object obj89 = obj60 * obj68;
														object obj90 = obj62 * obj67;
														float num25 = num26 * (float)obj68;
														object obj91 = obj92 * obj67;
														object obj93 = obj89 + obj90;
														num6 = num25 + (float)obj91;
														float num17 = (float)obj94 * (float)obj66;
														object obj95 = 0 * obj66;
														object obj96 = obj93 + obj95;
														num19 = (double)num6 + (double)num17;
														double num27 = (double)obj96 - num19;
														num3 = (float)num27 / (float)obj79;
														bool flag47 = !(num3 > 0f);
														object obj97 = obj92;
														object obj98 = obj94;
														float num15 = num26;
														if (!flag47)
														{
															bool flag48 = !((double)num3 < 6.0);
															obj97 = obj92;
															obj98 = obj94;
															num15 = num26;
															num19 = 6.0;
															if (!flag48)
															{
																if ((object)tileRoot != null)
																{
																	float num28 = (float)obj60 * num3;
																	num17 = (float)obj62 * num3;
																	float num29 = (float)obj75 * num3;
																	num6 = (float)obj94 + num28;
																	num19 = (double)obj92 + (double)num17;
																	num3 = num26 + num29;
																	Vector3 vector4 = tileRoot.InverseTransformPoint((Vector3)0);
																	Vector2Int at2 = ToPixel((Vector3)0);
																	string text3 = Hit(at2, (Vector3)0);
																	if (text3 != null)
																	{
																		if (text3._stringLength >= 1)
																		{
																			overAt = (Vector3)num3;
																			text = text3;
																		}
																		bool flag49 = !isPressed;
																		obj97 = obj92;
																		obj98 = obj94;
																		num15 = num26;
																		if (!flag49)
																		{
																			bool flag50 = (byte)(~(mouseDown ? 1u : 0u)) != 0;
																			object obj99 = !flag50;
																			if (obj99 == null && text3._stringLength >= 1)
																			{
																				Press(text3, -1);
																			}
																			bool flag51 = text3 == (string)obj3;
																			bool flag52 = !flag51;
																			obj97 = obj92;
																			obj98 = obj94;
																			num15 = num26;
																			if (!flag52)
																			{
																				Hold(dt, -1);
																				obj97 = obj92;
																				obj98 = obj94;
																				num15 = num26;
																				num3 = dt;
																			}
																		}
																		goto IL_0a31;
																	}
																}
																goto IL_100c;
															}
														}
													}
													goto IL_0a31;
												}
											}
										}
									}
								}
							}
						}
						goto IL_100c;
					}
				}
			}
			goto IL_1153;
		}
	}

	private string Hit(Vector2Int at, Vector3 p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0766: Expected I4, but got Obj
		//IL_076f: Expected Obj, but got I4
		//IL_0784: Expected VT, but got I8
		//IL_0a08: Expected Obj, but got I4
		//IL_09b1: Expected Obj, but got I
		//IL_09c1: Expected Obj, but got I
		//IL_0027: Expected I4, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Expected Obj, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected VT, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected I4, but got Unknown
		//IL_00b3: Expected VT, but got I8
		//IL_00d1: Expected Obj, but got I4
		//IL_0546: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_00e7: Expected I4, but got Obj
		//IL_00fc: Expected VT, but got I8
		//IL_0a31: Expected Obj, but got I4
		//IL_0a4d: Expected Obj, but got I4
		//IL_0575: Expected Obj, but got I4
		//IL_0867: Expected Obj, but got I
		//IL_0884: Expected VT, but got I
		//IL_0884: Expected VT, but got I
		//IL_032b: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I4
		//IL_08c2: Expected Obj, but got I
		//IL_08df: Expected VT, but got I
		//IL_08df: Expected VT, but got I
		//IL_05aa: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I4
		//IL_0681: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I
		//IL_0915: Expected Obj, but got I
		//IL_0932: Expected VT, but got I
		//IL_0932: Expected VT, but got I
		//IL_0630: Expected Obj, but got I
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I4
		//IL_06e5: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I4
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected Obj, but got Unknown
		//IL_07f1: Expected Obj, but got I4
		//IL_07fa: Expected Obj, but got I4
		//IL_0963: Expected Obj, but got I
		//IL_0980: Expected VT, but got I
		//IL_0980: Expected VT, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected VT, but got Unknown
		//IL_0493: Expected VT, but got I8
		//IL_04b1: Expected Obj, but got I4
		//IL_04c6: Expected VT, but got I8
		//IL_022f: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I
		//IL_0652: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected VT, but got Unknown
		//IL_029f: Expected VT, but got I8
		//IL_071a: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_05cc: Expected Obj, but got I
		//IL_02ef: Expected VT, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		bool flag = (byte)(int)obj != 0;
		object obj2 = 0;
		Vector2Int vector2Int = at;
		RectInt rectInt = (RectInt)137438953484L;
		string text;
		object obj9;
		Vector3 vector = default;
		int num = default;
		int num7 = default;
		int num8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v60 (System.Boolean)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag = (byte)(int)obj != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v60 (System.Boolean)+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v5+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v5+8]");
			Tile[] array;
			int num2;
			if ((nint)0 != 0)
			{
				object obj6 = obj2 + catFirst;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v6+18]");
				if ((nint)obj6 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v60 (System.Boolean)+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = Inside(rectInt, (Vector2Int)137438953580L);
					bool flag5 = !flag4;
					object obj8 = !flag5;
					if (obj8 != null)
					{
						text = num.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E0]");
						obj9 = 0;
						break;
					}
					flag = (byte)(int)obj != 0;
					vector = (Vector3)at;
					vector2Int = (Vector2Int)137438953580L;
				}
				obj2++;
				rectInt = (RectInt)(rectInt + 163208757248L);
				if ((nint)obj2 != 5)
				{
					continue;
				}
				object obj10 = catFirst + obj2;
				array = tiles;
				num2 = obj10 - 1;
				if (tiles == null)
				{
					goto IL_02f4;
				}
				Vector3 vector2 = vector;
				Vector2Int vector2Int2 = vector2Int;
				Tile[] array2 = tiles;
				object obj11 = 0;
				while (true)
				{
					bool flag6 = (nint)obj11 < array2.Length;
					object obj12 = !flag6;
					bool flag7 = (nint)obj11 >= array2.Length;
					obj2 = 28;
					vector = vector2;
					vector2Int = vector2Int2;
					array = array2;
					if (flag7)
					{
						break;
					}
					if (obj12 == null)
					{
						object obj13 = (object)array2 + obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X9_v20+20]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X9_v20+20]");
						bool flag8 = (nint)0 == 0;
						obj2 = 28;
						vector = vector2;
						vector2Int = vector2Int2;
						array = array2;
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X9_v21+2C]");
							if ((nint)0 >= (nint)1)
							{
								object obj15 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v61+E4]");
								bool flag9 = (nint)0 == 0;
								object obj16 = !flag9;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj17 = obj11 & 3;
								object obj18 = obj17 * 62;
								RectInt tile = (RectInt)(132 + obj18);
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
								RectInt r = DeleteRect(tile);
								flag = Inside(r, (Vector2Int)446676598842L);
								bool flag10 = !flag;
								object obj19 = !flag10;
								if (obj19 != null)
								{
									goto IL_05af;
								}
								array2 = tiles;
								vector2 = (Vector3)at;
								vector2Int2 = (Vector2Int)446676598842L;
							}
							obj11++;
							bool flag11 = array2 == null;
							object obj20 = !flag11;
							obj2 = 28;
							vector = vector2;
							vector2Int = vector2Int2;
							array = array2;
							if (obj20 != null)
							{
								continue;
							}
						}
						goto IL_02f4;
					}
					goto IL_0742;
				}
				goto IL_0302;
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0742;
			IL_0750:
			return (string)(object)new IndexOutOfRangeException();
			IL_0302:
			object obj21 = 0;
			while (true)
			{
				if ((nint)obj21 < array.Length)
				{
					bool flag12 = (nint)obj21 < array.Length;
					object obj22 = !flag12;
					if (obj22 != null)
					{
						break;
					}
					object obj23 = obj;
					object obj24 = (object)array + obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v43+E4]");
					bool flag13 = (nint)0 == 0;
					object obj25 = !flag13;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v37+20]");
					if (Has((Tile)0))
					{
						object obj26 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v49+E4]");
						bool flag14 = (nint)0 == 0;
						object obj27 = !flag14;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj28 = obj21 & 3;
						object obj29 = obj21 >> 2;
						object obj30 = obj29 & 0x3FFFFFFF;
						object obj31 = obj28 << 6;
						object obj32 = obj30 * 108;
						object obj33 = obj2 + obj32;
						object obj34 = obj31 - obj28;
						object obj35 = obj34 | obj33;
						RectInt r2 = (RectInt)(obj35 + 132);
						bool flag15 = Inside(r2, (Vector2Int)446676598842L);
						bool flag16 = !flag15;
						object obj36 = !flag16;
						vector = (Vector3)at;
						vector2Int = (Vector2Int)446676598842L;
						if (obj36 != null)
						{
							goto IL_0635;
						}
					}
					array = tiles;
					obj21++;
					bool flag17 = tiles == null;
					object obj37 = !flag17;
					if (obj37 == null)
					{
						num = num2;
						throw new NullReferenceException();
					}
					continue;
				}
				object obj38 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v18+E4]");
				bool flag18 = (nint)0 == 0;
				object obj39 = !flag18;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj38 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v18+A0]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v19+28]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v19+30]");
				object result;
				if (Inside((RectInt)num3, (Vector2Int)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E8]");
					result = 0;
				}
				else
				{
					object obj41 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v24+E4]");
					bool flag19 = (nint)0 == 0;
					object obj42 = !flag19;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj41 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v24+A0]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v22+38]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v22+40]");
					if (Inside((RectInt)num4, (Vector2Int)0))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2F0]");
						result = 0;
					}
					else
					{
						object obj44 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v28+E4]");
						bool flag20 = (nint)0 == 0;
						object obj45 = !flag20;
						if (obj45 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj44 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v28+A0]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v24+68]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v24+70]");
						if (Inside((RectInt)num5, (Vector2Int)0))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2D8]");
							result = 0;
						}
						else
						{
							object obj47 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v32+E4]");
							bool flag21 = (nint)0 == 0;
							object obj48 = !flag21;
							if (obj48 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj47 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v32+A0]");
							object obj49 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v26+48]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v26+50]");
							if (Inside((RectInt)num6, (Vector2Int)0))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF300]");
								result = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								result = 0;
							}
						}
					}
				}
				return (string)result;
			}
			goto IL_0750;
			IL_0635:
			text = num7.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
			obj9 = 0;
			break;
			IL_0742:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			goto IL_0750;
			IL_02f4:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0302;
			IL_05af:
			text = num8.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2F8]");
			obj9 = 0;
			break;
		}
		return (string)obj9 + text;
	}

	private void Press(string thing, int finger)
	{
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Obj, but got Unknown
		//IL_0799: Expected Obj, but got I
		//IL_07d5: Expected I4, but got I8
		//IL_07ef: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00b9: Expected F4, but got I
		//IL_0830: Expected F4, but got I
		//IL_0830: Expected F4, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_0849: Expected Obj, but got I
		//IL_0859: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_019d: Expected I4, but got Obj
		//IL_0410: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I4
		//IL_02de: Expected I4, but got Obj
		//IL_02eb: Expected I4, but got I8
		//IL_051f: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected I4, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected I4, but got Unknown
		//IL_03b4: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got I
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_05e2: Expected Obj, but got I
		//IL_0642: Expected I4, but got I8
		//IL_065c: Expected Obj, but got I4
		//IL_0713: Expected I4, but got I8
		//IL_072d: Expected Obj, but got I4
		object obj = this + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2D8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF308]");
		object obj7 = 0;
		AudioClip clip = clickSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		Play(clip, 0f);
		if (thing == (string)obj7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v48+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v48+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v34+10]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v34+10]");
			if ((nint)0 != 0)
			{
				object obj13 = filter + 1;
				scroll = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v35+18]");
				object obj14 = obj13 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v35+18]");
				object obj15 = obj14 * 0;
				int num3 = obj13 - obj15;
				filter = num3;
				Refill();
				SyncDrum();
				Play(toggleSound, 0.5f);
				return;
			}
		}
		else if (thing != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E0]");
			object value = 0;
			if (thing.StartsWith((string)value))
			{
				string s = thing.Substring(3);
				int c = int.Parse(s);
				PushTab(c);
				SelectCategory(c, fromWheel: false, 0);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E8]");
			object obj16 = 0;
			int num4;
			int num5;
			if (thing == (string)obj16)
			{
				object obj17 = scroll - 1;
				object obj18 = ~obj17;
				num4 = obj17 & obj18;
				num5 = -1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2F0]");
				object obj19 = 0;
				if (!(thing == (string)obj19))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2F8]");
					object value2 = 0;
					if (thing.StartsWith((string)value2))
					{
						Tile[] array = tiles;
						string s2 = thing.Substring(3);
						int num6 = int.Parse(s2);
						if (tiles != null)
						{
							bool flag7 = num6 < array.Length;
							object obj20 = !flag7;
							if (obj20 != null)
							{
								goto IL_0777;
							}
							object obj21 = tiles + num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v25+20]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v25+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v26+2C]");
								DeleteOutfit(0);
								return;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
						object value3 = 0;
						if (!thing.StartsWith((string)value3))
						{
							return;
						}
						Tile[] array2 = tiles;
						string s3 = thing.Substring(4);
						int num7 = int.Parse(s3);
						if (tiles != null)
						{
							bool flag8 = num7 < array2.Length;
							object obj23 = !flag8;
							if (obj23 != null)
							{
								goto IL_0777;
							}
							object obj24 = tiles + num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v22+20]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v22+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+4C]");
								double num8 = 0.0 + 9.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+2C]");
								int num9 = 0;
								bool flag9 = num9 == 0;
								object obj26 = !flag9;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+2C]");
									PickOutfit(0);
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+30]");
								if ((nint)0 >= (nint)1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+30]");
									PickMonster(0);
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+24]");
								if ((nint)0 >= (nint)1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+24]");
									PickTitle(0);
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+28]");
								int num10 = 0;
								bool flag10 = num10 == 0;
								object obj27 = !flag10;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+28]");
									PickBundle(0);
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23+20]");
									Pick(0);
								}
								return;
							}
						}
					}
					goto IL_0769;
				}
				int num11 = MaxScroll();
				object obj28 = scroll + 1;
				object obj29 = num11 - obj28;
				bool flag11 = (nint)obj29 < 0;
				int num12 = num11 ^ obj28;
				int num13 = num11 ^ obj29;
				int num14 = num12 & num13;
				bool flag12 = num14 < 0;
				bool flag13 = flag11 == flag12;
				object obj30 = !flag13;
				object obj31 = ~obj30;
				if (obj31 == null)
				{
					num5 = 1;
					num4 = num11;
				}
				else
				{
					num4 = scroll + 1;
					num5 = 1;
				}
			}
			scroll = num4;
			glideDir = num5;
			Refill();
			SyncDrum();
			return;
		}
		goto IL_0769;
		IL_0777:
		throw new IndexOutOfRangeException();
		IL_0769:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0777;
	}

	private void SelectCategory(int c, bool fromWheel, int row = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I
		//IL_03a2: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I4, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected I4, but got Unknown
		//IL_0309: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected I4, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected I4, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+18]");
		int num = (int)(-1);
		object obj6 = c - num;
		bool flag2 = (nint)obj6 < 0;
		int num2 = c ^ num;
		int num3 = c ^ obj6;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag2 == flag3;
		object obj7 = !flag4;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			num = c;
		}
		bool flag5 = c < 0;
		int num5 = c ^ c;
		int num6 = c & num5;
		bool flag6 = num6 < 0;
		bool flag7 = flag5 == flag6;
		object obj9 = !flag7;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			num = 0;
		}
		object obj11 = num - catFirst;
		bool flag8 = (nint)obj11 < 0;
		int num7 = num ^ catFirst;
		int num8 = num ^ obj11;
		int num9 = num7 & num8;
		bool flag9 = num9 < 0;
		category = num;
		bool flag10 = flag8 == flag9;
		object obj12 = !flag10;
		object obj13 = ~obj12;
		int num10 = ((obj13 != null) ? catFirst : num);
		object obj14 = num10 + 5;
		bool flag11;
		bool flag12;
		if (num >= catFirst)
		{
			object obj15 = num - obj14;
			flag11 = (nint)obj15 < 0;
			int num11 = num ^ obj14;
			int num12 = num ^ obj15;
			int num13 = num11 & num12;
			flag12 = num13 < 0;
		}
		else
		{
			flag12 = false;
			flag11 = false;
		}
		bool flag13 = flag11 == flag12;
		object obj16 = !flag13;
		if (obj16 == null)
		{
			int num14 = num - 4;
			if (num >= (nint)obj14)
			{
				num10 = num14;
			}
			catFirst = num10;
		}
		bool flag14 = num == category;
		scroll = row;
		if (!flag14)
		{
			ClearPick();
		}
		Refill();
		bool flag15 = !fromWheel;
		object obj17 = !flag15;
		if (obj17 == null)
		{
			SyncDrum();
		}
		dirty = true;
	}

	private void ClearPick()
	{
		//IL_0024: Expected I4, but got I8
		//IL_0033: Expected I4, but got I8
		picked = 0;
		Array array = cart;
		deleteArmed = -1;
		pickedBundle = -1;
		byte[] array2 = cart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X0_v1 (System.Array)+18]");
		Array.Clear(array2, 0, 0);
	}

	private List<(int, int)> WheelPlaces()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02e2: Expected VT, but got Obj
		//IL_0460: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_03c8: Expected Obj, but got I4
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_022d: Expected VT, but got I4
		//IL_025a: Expected VT, but got I4
		//IL_01c1: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_027f: Expected VT, but got I4
		//IL_0288: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		(int, int) tuple = ((int, int))obj2;
		List<(int, int)> list = default;
		list._002Ector();
		int num = 0;
		while (true)
		{
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v5+8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v5+8]");
			if ((nint)0 == 0)
			{
				break;
			}
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+18]");
			(int, int) tuple2;
			if ((nint)num2 < (nint)0)
			{
				int num3 = CountIn(num);
				object obj10 = num3 + 3;
				object obj11 = num3 + 6;
				bool flag2 = (nint)obj10 < 0;
				object obj12 = obj10 ^ obj10;
				object obj13 = obj10 & obj12;
				bool flag3 = (nint)obj13 < 0;
				bool flag4 = flag2 == flag3;
				object obj14 = !flag4;
				object obj15 = ~obj14;
				if (obj15 == null)
				{
					obj10 = obj11;
				}
				object obj16 = obj10 >> 2;
				object obj17 = obj16 - 2;
				bool flag5 = (nint)obj17 < 0;
				bool flag6 = obj17 == null;
				object obj18 = obj16 ^ 2;
				object obj19 = obj16 ^ obj17;
				object obj20 = obj18 & obj19;
				bool flag7 = (nint)obj20 < 0;
				bool flag8 = flag5 == flag7;
				object obj21 = !flag6;
				object obj22 = flag8 & obj21;
				object obj23 = ~obj22;
				if (obj23 != null)
				{
					obj16 = 2;
				}
				object obj24 = obj16 - 1;
				int num4 = 0;
				while (true)
				{
					tuple2 = (num, num4);
					if (list == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					object obj25 = 0;
					object obj26 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
					object obj27 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v14+18]");
					bool flag9 = num5 < 0;
					object obj28 = !flag9;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj29 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj30 = (nint)0 + (nint)1;
						_ = 0;
						int num7 = num4;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v5+20]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v16+A8]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v17+70]");
						int num7 = 0;
						list.AddWithResize(((int, int))0);
					}
					num4++;
					bool flag10 = (nint)obj24 != num4;
					tuple2 = ((int, int))0;
					if (!flag10)
					{
						goto IL_0268;
					}
				}
				break;
			}
			return list;
			IL_0268:
			num++;
			tuple2 = ((int, int))0;
			tuple = ((int, int))0;
		}
		return (List<(int, int)>)(object)new NullReferenceException();
	}

	private void SyncDrum()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_00a6: Expected F4, but got Obj
		//IL_00d8: Expected VT, but got I4
		//IL_0115: Expected F4, but got I4
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
		bool flag2 = drum == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			List<(int, int)> list = WheelPlaces();
			ScrollDrum scrollDrum = drum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v8 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
			object obj5 = -1;
			object obj6 = ~obj5;
			float max = obj5 & obj6;
			scrollDrum.max = max;
			(int, int) tuple = (category, scroll);
			int num = list.IndexOf(((int, int))0);
			int num2 = ~num;
			int num3 = (drumAt = num & num2);
			drum.Set(num3);
		}
	}

	private void Rolled(int at)
	{
		//IL_0133: Expected I4, but got I8
		//IL_014d: Expected Obj, but got I4
		//IL_0090: Expected I4, but got VT
		//IL_009a: Invalid comparison between I4 and VT
		//IL_00f7: Expected I4, but got VT
		List<(int, int)> list = WheelPlaces();
		drumAt = at;
		int num = ((drumAt < at) ? 1 : (-1));
		glideDir = num;
		int num2 = (int)(at & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
			if ((nint)0 > (nint)at)
			{
				(int, int) tuple = list.get_Item(at);
				int num3 = tuple >> 32;
				if ((object)category == (object)tuple)
				{
					if (scroll != num3)
					{
						scroll = num3;
						Refill();
					}
				}
				else
				{
					SelectCategory((int)tuple, fromWheel: true, num3);
				}
			}
		}
		glideDir = 0;
	}

	private void GlideTabs(float dt)
	{
		//IL_03d7: Invalid comparison between F4 and I4
		//IL_0412: Expected Obj, but got I
		//IL_041e: Invalid comparison between F4 and I4
		//IL_055e: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I
		//IL_0034: Invalid comparison between F8 and I
		//IL_0051: Expected F8, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_00ed: Invalid comparison between F8 and I
		//IL_026f: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I4
		//IL_048e: Expected F4, but got I4
		//IL_0068: Invalid comparison between F8 and I4
		//IL_0077: Expected F8, but got I4
		//IL_051f: Expected Obj, but got I
		//IL_052f: Expected Obj, but got I
		//IL_010a: Invalid comparison between F8 and I4
		//IL_0119: Expected F8, but got I4
		//IL_02de: Expected F8, but got I4
		//IL_01cb: Invalid comparison between F4 and I4
		//IL_04d7: Expected I4, but got F8
		//IL_04f8: Invalid comparison between F4 and I
		//IL_030e: Expected Obj, but got I4
		//IL_0204: Invalid comparison between F8 and I4
		//IL_0213: Expected F8, but got I4
		//IL_0369: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I
		float num = dt * -12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num2 = 1.0 - (double)num;
		bool flag = catAt == (float)category;
		double num3 = 1.0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			bool flag2 = 1.0 < 0.0;
			num3 = 1.0;
			double num4 = category;
			if (!flag2)
			{
				bool flag3 = num2 < 0.0;
				num3 = 0.0;
				if (!flag3)
				{
					bool flag4 = !(num2 > 1.0);
					num3 = num2;
					if (!flag4)
					{
						num3 = 1.0;
					}
				}
				float num5 = (float)category - catAt;
				double num6 = (double)num5 * num3;
				num4 = (double)catAt + num6;
			}
			catAt = (float)num4;
			dirty = true;
		}
		int num7 = catFirst;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		if (firstAt != (float)catFirst)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj = 0;
			double num8 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if (!(num8 < 0.0))
			{
				bool flag5 = num2 < 0.0;
				num3 = 0.0;
				if (!flag5)
				{
					bool flag6 = !(num2 > 1.0);
					num3 = num2;
					if (!flag6)
					{
						num3 = 1.0;
					}
				}
				float num9 = (float)num7 - firstAt;
				num2 = (double)num9 * num3;
				double num10 = (double)firstAt + num2;
				num7 = (int)num10;
			}
			firstAt = num7;
			dirty = true;
		}
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v3+E4]");
		bool flag7 = (nint)0 == 0;
		object obj4 = !flag7;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num12;
		if (drum != null)
		{
			ScrollDrum scrollDrum = drum;
			num2 = scrollDrum.max;
			if (scrollDrum.max > 0f)
			{
				double num11 = (double)scrollDrum.turned / (double)scrollDrum.max;
				bool flag8 = num11 < 0.0;
				num12 = 0.0;
				if (!flag8)
				{
					bool flag9 = !(num11 > 1.0);
					num12 = num11;
					if (!flag9)
					{
						num12 = 1.0;
					}
				}
				goto IL_04dc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj7 = !flag10;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v11+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v16+18]");
		bool flag11 = (nint)0 < (nint)2;
		num12 = 0.0;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v11+E4]");
			bool flag12 = (nint)0 == 0;
			object obj10 = !flag12;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v19+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v20+8]");
				obj9 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v16+18]");
			object obj13 = -1;
			num12 = (double)catAt / (double)obj13;
		}
		goto IL_04dc;
		IL_04dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num13 = barAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		if (num13 > 0f)
		{
			barAt = (float)num12;
			dirty = true;
		}
	}

	private int CountIn(int c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0743: Expected Obj, but got I4
		//IL_0886: Expected Obj, but got I
		//IL_0896: Expected Obj, but got I
		//IL_0719: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I4
		//IL_061a: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I4
		//IL_067e: Expected Obj, but got I4
		//IL_0698: Expected Obj, but got I4
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_06b0: Expected Obj, but got I4
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected I4, but got Unknown
		//IL_0262: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected I4, but got Unknown
		//IL_03ca: Expected Obj, but got I4
		//IL_040e: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+8]");
		if ((nint)0 == 0)
		{
			goto IL_06fd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+18]");
		int num = default;
		bool flag2 = (nint)0 < (nint)num;
		object obj7 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+18]");
		object obj8 = -num;
		bool flag3 = obj8 == null;
		object obj9 = ~obj7;
		object obj10 = obj9 | flag3;
		if (obj10 != null)
		{
			goto IL_070b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+8]");
		object obj11 = (nint)0 + (nint)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8+28]");
		int num2;
		if ((nint)0 <= (nint)253)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8+28]");
			if ((nint)0 != 252)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8+28]");
				if ((nint)0 != 253)
				{
					goto IL_02f8;
				}
				int count = GillaOutfits.Count;
				num2 = count + 1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v57+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				List<int> list = MonsterChoice.Choices();
				if (list == null)
				{
					goto IL_06fd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v60 (System.Collections.Generic.List`1<System.Int32>)+18]");
				num2 = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8+28]");
			if ((nint)0 == 255)
			{
				int bundleCount = CosmeticCatalog.BundleCount;
				if (bundleCount < 1)
				{
					goto IL_06ef;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj15 = 0;
				num2 = 0;
				int num3 = 0;
				while (true)
				{
					Coins.Bundle b = CosmeticCatalog.BundleAt(num3);
					List<byte> list2 = CosmeticCatalog.IdsOf(b);
					if (list2 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v37 (System.Collections.Generic.List`1<System.Byte>)+18]");
					if ((nint)0 >= (nint)1)
					{
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v41+E4]");
						bool flag5 = (nint)0 == 0;
						object obj17 = !flag5;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = Coins.OwnsAll(b);
						object obj18 = filter - 1;
						bool flag7 = obj18 == null;
						object obj19 = !flag7;
						object obj20 = filter - 2;
						bool flag8 = obj20 == null;
						object obj21 = !flag8;
						obj6 = flag6 | obj19;
						object obj22 = !flag6;
						object obj23 = obj21 | obj22;
						object obj24 = obj6 & obj23;
						object obj25 = obj24 & 1;
						num2 += obj25;
					}
					num3++;
					int bundleCount2 = CosmeticCatalog.BundleCount;
					if (num3 < bundleCount2)
					{
						continue;
					}
					goto IL_0751;
				}
				goto IL_06fd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8+28]");
			if ((nint)0 != 254)
			{
				goto IL_02f8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj26 = 0;
			num2 = 0;
			int num4 = 1;
			while (true)
			{
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v47+E4]");
				bool flag9 = (nint)0 == 0;
				object obj28 = !flag9;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int count2 = NameTitles.Count;
				if (num4 > count2)
				{
					break;
				}
				object obj29 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v51+E4]");
				bool flag10 = (nint)0 == 0;
				object obj30 = !flag10;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag11 = NameTitles.MayWear(num4);
				num4++;
				object obj31 = filter - 1;
				bool flag12 = obj31 == null;
				object obj32 = !flag12;
				object obj33 = filter - 2;
				bool flag13 = obj33 == null;
				object obj34 = !flag13;
				object obj35 = flag11 | obj32;
				object obj36 = !flag11;
				object obj37 = obj34 | obj36;
				object obj38 = obj35 & obj37;
				object obj39 = obj38 & 1;
				num2 += obj39;
			}
		}
		goto IL_0751;
		IL_0751:
		return num2;
		IL_02f8:
		int count3 = CosmeticCatalog.Count;
		if (count3 < 1)
		{
			goto IL_06ef;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj40 = 0;
		num2 = 0;
		int num5 = 1;
		while (true)
		{
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num5);
			if (entry == null)
			{
				break;
			}
			CosmeticSlot slot = entry.slot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8+28]");
			if ((nint)slot == 0 && string.IsNullOrEmpty(entry.wornWith))
			{
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v21+E4]");
				bool flag14 = (nint)0 == 0;
				object obj42 = !flag14;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag15 = Coins.Owns((byte)num5);
				bool flag16 = !flag15;
				object obj43 = !flag16;
				object obj44 = ~obj43;
				obj6 = ((obj44 != null) ? ((object)1) : ((object)(1 + 1)));
				if (filter != (nint)obj6)
				{
					if (~(entry.retired ? 1u : 0u) == 0)
					{
						object obj45 = obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v26+E4]");
						bool flag17 = (nint)0 == 0;
						object obj46 = !flag17;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!Coins.Owns((byte)num5))
						{
							goto IL_078e;
						}
					}
					num2++;
				}
			}
			goto IL_078e;
			IL_078e:
			num5++;
			int count4 = CosmeticCatalog.Count;
			if (num5 <= count4)
			{
				continue;
			}
			goto IL_0751;
		}
		goto IL_06fd;
		IL_06fd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_070b;
		IL_06ef:
		num2 = 0;
		goto IL_0751;
		IL_070b:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	private bool Shows(bool own)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected I4, but got Unknown
		object obj = filter - 1;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = filter - 2;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 | own;
		object obj6 = !own;
		object obj7 = obj4 | obj6;
		object obj8 = obj5 & obj7;
		return (byte)(obj8 & 1) != 0;
	}

	private unsafe void Unequip()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0855: Expected Obj, but got I4
		//IL_090a: Expected Obj, but got I
		//IL_091a: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_06d0: Expected Obj, but got I
		//IL_06ea: Expected Obj, but got I
		//IL_06f2: Expected I, but got Obj
		//IL_071a: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I
		//IL_0272: Expected I, but got Obj
		//IL_0280: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I4
		//IL_029d: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0537: Expected Obj, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_02c3: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I4
		//IL_02fc: Expected I, but got Obj
		//IL_0305: Expected Obj, but got I4
		//IL_030d: Expected I, but got Obj
		//IL_04e9: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I4
		//IL_0599: Expected Obj, but got I4
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I4
		//IL_0655: Expected F4, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_0670: Expected Obj, but got I
		//IL_01a8: Expected F4, but got I
		//IL_08c1: Expected Obj, but got I
		//IL_08c9: Expected I, but got Obj
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected Ref, but got Unknown
		//IL_08ec: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected I, but got Obj
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I
		//IL_05e2: Expected Obj, but got I4
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I4
		//IL_07c6: Expected Obj, but got I4
		//IL_062f: Expected Obj, but got I4
		//IL_0825: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+8]");
		nint num4;
		object obj24;
		List<byte> list3;
		nint num2 = default;
		object obj22 = default;
		if ((nint)0 != 0)
		{
			int num = category;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+18]");
			bool flag2 = (nint)num < (nint)0;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_075c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+8]");
			object obj7 = (nint)0 + (nint)category;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v24+28]");
			if ((nint)0 != 255)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v24+28]");
				if ((nint)0 == 254)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v69+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (NameTitles.Worn != 0)
					{
						object obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v73+E4]");
						bool flag4 = (nint)0 == 0;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NameTitles.Wear(0);
						AudioClip clip = equipSound;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						Play(clip, 0f);
						object obj13 = this + 424;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF340]");
						object obj14 = 0;
						bannerText = (string)obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bannerBad = false;
						dirty = true;
						banner = 1.6f;
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
					object obj15 = 0;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v60+E4]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v24+28]");
					byte b = Cosmetics.In((CosmeticSlot)0);
					if ((b & 0xFF) != 0)
					{
						object obj18 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v64+E4]");
						bool flag6 = (nint)0 == 0;
						object obj19 = !flag6;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v24+28]");
						Cosmetics.TakeOff((CosmeticSlot)0);
						goto IL_063d;
					}
				}
				goto IL_051c;
			}
			Coins.Bundle bundle = CosmeticCatalog.BundleAt(pickedBundle);
			if (bundle != null)
			{
				List<byte> list = CosmeticCatalog.IdsOf(bundle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4758]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF328]");
				object obj21 = 0;
				num2 = (nint)obj21;
				Predicate<byte> predicate = default;
				predicate._002Ector((object)null, (IntPtr)obj21);
				bool flag7 = list == null;
				obj22 = 0;
				nint num3 = unchecked((nint)null);
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF330]");
					object obj23 = 0;
					num4 = (nint)obj23;
					List<byte> list2 = list.FindAll(predicate);
					bool flag8 = list2 == null;
					obj24 = 0;
					list3 = list2;
					num2 = (nint)obj23;
					obj22 = 0;
					num3 = (nint)predicate;
					if (!flag8)
					{
						goto IL_031b;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45C8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D0]");
				object obj26 = 0;
				nint num3 = (nint)obj26;
				List<byte> list4 = default;
				list4._002Ector();
				bool flag9 = list4 == null;
				object obj27 = !flag9;
				num4 = num2;
				obj24 = obj22;
				list3 = list4;
				if (obj27 != null)
				{
					goto IL_031b;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_074e;
		IL_074e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_075c;
		IL_075c:
		throw new IndexOutOfRangeException();
		IL_051c:
		object obj28 = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF338]");
		object obj29 = 0;
		bannerText = (string)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bannerBad = true;
		banner = 1.6f;
		dirty = true;
		Play(errorSound, 0.5f);
		return;
		IL_031b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X20_v21 (System.Collections.Generic.List`1<System.Byte>)+18]");
		bool flag10 = (nint)0 == 0;
		num2 = num4;
		obj22 = obj24;
		if (flag10)
		{
			goto IL_051c;
		}
		Enumerator<, > enumerator = list3.GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj30 = 0;
		Enumerator<, > val = default;
		object obj31;
		object obj32;
		Enumerator<, > val2;
		while (val.MoveNext())
		{
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(0);
			bool flag11 = entry == null;
			obj31 = 0;
			obj32 = 0;
			val2 = (Enumerator<, >)(ref val);
			num2 = num4;
			obj22 = obj24;
			nint num3 = unchecked((nint)null);
			if (!flag11)
			{
				object obj33 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v39+E4]");
				bool flag12 = (nint)0 == 0;
				object obj34 = !flag12;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cosmetics.TakeOff(entry.slot);
				continue;
			}
			goto IL_074e;
		}
		obj31 = 0;
		obj32 = 0;
		val2 = (Enumerator<, >)(ref val);
		num2 = num4;
		obj22 = obj24;
		object obj35 = 0;
		object obj36 = 10;
		object obj40 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
			object obj37 = 0;
			nint num3 = (nint)obj37;
			((Enumerator<, >*)val2)->Dispose();
			bool flag13 = obj35 == null;
			object obj38 = !flag13;
			if (obj38 == null)
			{
				bool flag14 = obj31 == null;
				object obj39 = !flag14;
				OutOfMemoryException ex3 = (OutOfMemoryException)val2;
				if (obj39 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch ((long)num3)
			{
			case 2L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj31 = 1;
				obj35 = obj32;
				break;
			case 1L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj35 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj32 = obj40;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			obj36 = 0;
		}
		if ((nint)obj36 != 10)
		{
			bool flag15 = obj36 == null;
			object obj41 = !flag15;
			if (obj41 != null)
			{
				return;
			}
		}
		goto IL_063d;
		IL_063d:
		AudioClip clip2 = equipSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		Play(clip2, 0f);
		object obj42 = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF340]");
		object obj43 = 0;
		bannerText = (string)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bannerBad = false;
		banner = 1.6f;
		dirty = true;
		UpdateTryOn();
		dirty = true;
	}

	private void Pick(byte id)
	{
		//IL_0048: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		int num = id & 0xFF;
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num);
		if (entry == null)
		{
			return;
		}
		ClearPick();
		if (picked != num)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj = 0;
			picked = (byte)num;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaQuests.Report((GillaQuests.Stat)11, 1);
		}
		Tile[] array = tiles;
		if (tiles != null)
		{
			if (array.Length < 1)
			{
				goto IL_0194;
			}
			object obj4 = ~array.Length;
			object obj5 = array.Length & obj4;
			object obj6 = 0;
			while (true)
			{
				object obj7 = (object)tiles + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X13_v6+20]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X13_v6+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X13_v7+20]");
				if ((nint)0 == num)
				{
					_ = 1058642330;
				}
				obj6++;
				if (obj5 != obj6)
				{
					continue;
				}
				goto IL_0194;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0194:
		UpdateTryOn();
		dirty = true;
	}

	private void PickBundle(int i)
	{
		//IL_003a: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		Coins.Bundle bundle = CosmeticCatalog.BundleAt(i);
		if (bundle == null)
		{
			return;
		}
		ClearPick();
		if (pickedBundle != i)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj = 0;
			pickedBundle = i;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaQuests.Report((GillaQuests.Stat)11, 1);
		}
		Tile[] array = tiles;
		if (tiles != null)
		{
			if (array.Length < 1)
			{
				goto IL_0186;
			}
			object obj4 = ~array.Length;
			object obj5 = array.Length & obj4;
			object obj6 = 0;
			while (true)
			{
				object obj7 = (object)tiles + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X13_v6+20]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X13_v6+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X13_v7+28]");
				if ((nint)0 == i)
				{
					_ = 1058642330;
				}
				obj6++;
				if (obj5 != obj6)
				{
					continue;
				}
				goto IL_0186;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0186:
		UpdateTryOn();
		dirty = true;
	}

	private void PickOutfit(int k)
	{
		//IL_005d: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		ClearPick();
		if (pickedOutfit != k)
		{
			pickedOutfit = k;
		}
		Tile[] array = tiles;
		if (tiles != null)
		{
			if (array.Length < 1)
			{
				goto IL_00f0;
			}
			object obj = ~array.Length;
			object obj2 = array.Length & obj;
			object obj3 = 0;
			while (true)
			{
				object obj4 = (object)tiles + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X13_v5+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X13_v5+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X13_v6+2C]");
				if ((nint)0 == k)
				{
					_ = 1058642330;
				}
				obj3++;
				if (obj2 != obj3)
				{
					continue;
				}
				goto IL_00f0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_00f0:
		UpdateTryOn();
		dirty = true;
	}

	private void DeleteOutfit(int k)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I
		//IL_00ee: Expected F4, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I
		//IL_016c: Expected F4, but got I
		int i = k - 1;
		if (k < 1)
		{
			return;
		}
		if (deleteArmed == k)
		{
			float time = Time.time;
			float num = time - armedAt;
			if (!((double)num > 3.0))
			{
				GillaOutfits.Delete(i);
				ClearPick();
				object obj = this + 424;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF320]");
				object obj2 = 0;
				bannerText = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bannerBad = false;
				banner = 1.6f;
				dirty = true;
				AudioClip clip = equipSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				Play(clip, 0f);
				Refill();
				SyncDrum();
				return;
			}
		}
		deleteArmed = k;
		float time2 = Time.time;
		object obj3 = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF318]");
		object obj4 = 0;
		armedAt = time2;
		bannerText = (string)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bannerBad = true;
		banner = 1.6f;
		dirty = true;
		AudioClip clip2 = errorSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		Play(clip2, 0f);
	}

	private void PickMonster(int m)
	{
		//IL_005d: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		ClearPick();
		if (pickedMonster != m)
		{
			pickedMonster = m;
		}
		Tile[] array = tiles;
		if (tiles != null)
		{
			if (array.Length < 1)
			{
				goto IL_00f0;
			}
			object obj = ~array.Length;
			object obj2 = array.Length & obj;
			object obj3 = 0;
			while (true)
			{
				object obj4 = (object)tiles + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X13_v5+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X13_v5+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X13_v6+30]");
				if ((nint)0 == m)
				{
					_ = 1058642330;
				}
				obj3++;
				if (obj2 != obj3)
				{
					continue;
				}
				goto IL_00f0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_00f0:
		UpdateTryOn();
		dirty = true;
	}

	private void PickTitle(int t)
	{
		//IL_005d: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		ClearPick();
		if (pickedTitle != t)
		{
			pickedTitle = t;
		}
		Tile[] array = tiles;
		if (tiles != null)
		{
			if (array.Length < 1)
			{
				goto IL_00f0;
			}
			object obj = ~array.Length;
			object obj2 = array.Length & obj;
			object obj3 = 0;
			while (true)
			{
				object obj4 = (object)tiles + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X13_v5+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X13_v5+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X13_v6+24]");
				if ((nint)0 == t)
				{
					_ = 1058642330;
				}
				obj3++;
				if (obj2 != obj3)
				{
					continue;
				}
				goto IL_00f0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_00f0:
		dirty = true;
	}

	private void Hold(float dt, int finger)
	{
		//IL_01fe: Invalid comparison between F4 and I4
		//IL_0225: Expected Obj, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_026e: Expected Obj, but got I
		//IL_02bb: Expected F4, but got I
		string text = ButtonAction(out var _);
		if (holdFill == 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD08]");
			object obj = 0;
			if (text == (string)obj)
			{
				object obj2 = this + 424;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF310]");
				object obj3 = 0;
				bannerText = (string)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bannerBad = true;
				dirty = true;
				banner = 1.6f;
				AudioClip clip = errorSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				Play(clip, 0f);
				holdFill = 0.001f;
			}
		}
	}

	private unsafe string ButtonAction(out bool ok)
	{
		//IL_01fe: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_0675: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got I
		//IL_06ef: Expected Obj, but got I
		//IL_0544: Expected Obj, but got I
		//IL_056e: Expected Obj, but got I4
		//IL_0481: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_06d1: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I
		//IL_0415: Expected I, but got Obj
		//IL_0502: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_0638: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I4
		ref bool reference = ref *(bool*)1;
		object result;
		if (pickedOutfit != 0)
		{
			int i = pickedOutfit - 1;
			if (pickedOutfit >= 1)
			{
				if (!GillaOutfits.IsOn(i))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF368]");
					result = 0;
					goto IL_0738;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF378]");
				result = 0;
			}
			else if (pickedTitle >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v55+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (NameTitles.MayWear(pickedTitle))
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v59+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int worn = NameTitles.Worn;
					if (worn == pickedTitle)
					{
						goto IL_01c4;
					}
					goto IL_0646;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC20]");
				result = 0;
			}
			else if (pickedMonster >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v40+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (MonsterChoice.Locked(pickedMonster))
				{
					reference = ref *(bool*)null;
					object obj9 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v48+E4]");
					bool flag4 = (nint)0 == 0;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return MonsterChoice.LockLabel(pickedMonster);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v45+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int monsterNow = MonsterNow;
				if (monsterNow != pickedMonster)
				{
					goto IL_0646;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF360]");
				result = 0;
			}
			else
			{
				Coins.Bundle bundle = CosmeticCatalog.BundleAt(pickedBundle);
				if (bundle != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
					object obj14 = 0;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v28+E4]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (Coins.OwnsAll(bundle))
					{
						List<byte> list = CosmeticCatalog.IdsOf(bundle);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4758]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF328]");
						object obj18 = 0;
						Predicate<byte> predicate = default;
						predicate._002Ector((object)null, (IntPtr)obj18);
						if (list != null)
						{
							bool flag7 = list.TrueForAll(predicate);
							bool flag8 = !flag7;
							object obj19 = !flag8;
							if (obj19 != null)
							{
								goto IL_01c4;
							}
							goto IL_0646;
						}
						return (string)(object)new NullReferenceException();
					}
				}
				CosmeticCatalog.Entry entry = CosmeticCatalog.Of(picked);
				if (entry != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
					object obj20 = 0;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v18+E4]");
					bool flag9 = (nint)0 == 0;
					object obj22 = !flag9;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (Coins.Owns(picked))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
						object obj23 = 0;
						object obj24 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v22+E4]");
						bool flag10 = (nint)0 == 0;
						object obj25 = !flag10;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = Cosmetics.IsWearing(picked);
						bool flag12 = !flag11;
						object obj26 = !flag12;
						if (obj26 != null)
						{
							goto IL_01c4;
						}
						goto IL_0646;
					}
				}
				bool flag13 = bundle == null;
				object obj27 = !flag13;
				if (obj27 == null)
				{
					bool flag14 = picked == 0;
					object obj28 = !flag14;
					if (obj28 == null)
					{
						bool flag15 = WearingHere();
						bool flag16 = !flag15;
						object obj29 = !flag16;
						if (obj29 != null)
						{
							goto IL_01c4;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF380]");
				result = 0;
			}
		}
		else
		{
			int count = GillaOutfits.Count;
			if (count < 8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF358]");
				result = 0;
				goto IL_0738;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF370]");
			result = 0;
		}
		reference = ref *(bool*)null;
		goto IL_0738;
		IL_01c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF350]");
		result = 0;
		goto IL_0738;
		IL_0738:
		return (string)result;
		IL_0646:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF388]");
		result = 0;
		goto IL_0738;
	}

	private bool WearingHere()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I
		//IL_0238: Expected I4, but got Obj
		//IL_004f: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			int num = category;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+18]");
			bool flag2 = (nint)num < (nint)0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+8]");
				object obj7 = (nint)0 + (nint)category;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+28]");
				object obj8 = -252;
				bool flag3 = (nint)obj8 < 2;
				object obj9 = !flag3;
				object obj10 = ~obj9;
				bool result = false;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+28]");
					bool flag4 = (nint)0 == 255;
					result = false;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+28]");
						bool flag6;
						if ((nint)0 == 254)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
							object obj11 = 0;
							object obj12 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v16+E4]");
							bool flag5 = (nint)0 == 0;
							object obj13 = !flag5;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int worn = NameTitles.Worn;
							flag6 = worn == 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
							object obj14 = 0;
							object obj15 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v11+E4]");
							bool flag7 = (nint)0 == 0;
							object obj16 = !flag7;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+28]");
							byte b = Cosmetics.In((CosmeticSlot)0);
							int num2 = b & 0xFF;
							flag6 = num2 == 0;
						}
						bool flag8 = !flag6;
						result = flag8;
					}
				}
				return result;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private void Act(string action)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_044a: Expected Obj, but got I
		//IL_0497: Expected F4, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_00ae: Expected F4, but got I
		//IL_00c6: Expected F4, but got I
		//IL_01b7: Expected F4, but got I
		//IL_01da: Expected F4, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I4
		//IL_086f: Expected Obj, but got I
		//IL_0574: Expected Obj, but got I4
		//IL_0303: Expected F4, but got I
		//IL_031b: Expected F4, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I
		//IL_162b: Expected Obj, but got I4
		//IL_06a5: Expected Obj, but got I4
		//IL_164a: Expected Obj, but got I
		//IL_1674: Expected Obj, but got I4
		//IL_0367: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_08ad: Expected Obj, but got I
		//IL_08c7: Expected Obj, but got I
		//IL_059c: Expected Obj, but got I4
		//IL_060c: Expected F4, but got I
		//IL_0617: Expected Obj, but got I4
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got I
		//IL_16c2: Expected Obj, but got I
		//IL_16c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Expected Obj, but got Unknown
		//IL_16d8: Expected Obj, but got I4
		//IL_0f2c: Expected Obj, but got I
		//IL_0f56: Expected Obj, but got I4
		//IL_0919: Expected Obj, but got I4
		//IL_0944: Expected I4, but got Obj
		//IL_0658: Expected Obj, but got I
		//IL_063e: Expected F4, but got I
		//IL_1026: Expected Obj, but got I
		//IL_1050: Expected Obj, but got I4
		//IL_0f8e: Expected F4, but got I
		//IL_0fa6: Expected F4, but got I
		//IL_1968: Expected Obj, but got I
		//IL_197d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1981: Unknown result type (might be due to invalid IL or missing references)
		//IL_1985: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Expected F4, but got I
		//IL_10a3: Expected F4, but got I
		//IL_0fbb: Expected Obj, but got I
		//IL_0fc4: Expected Obj, but got I4
		//IL_0962: Expected Obj, but got I
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Expected F4, but got Unknown
		//IL_10b8: Expected Obj, but got I
		//IL_10c1: Expected Obj, but got I4
		//IL_18c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c7: Expected Obj, but got Unknown
		//IL_176c: Expected Obj, but got I4
		//IL_1770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected Obj, but got I
		//IL_0c16: Expected Obj, but got I4
		//IL_1323: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got I4
		//IL_0c3d: Expected VT, but got I4
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected Obj, but got Unknown
		//IL_0826: Expected Obj, but got I4
		//IL_0b48: Expected Obj, but got I4
		//IL_0b86: Expected Obj, but got I4
		//IL_0c6e: Expected Obj, but got I
		//IL_0ca5: Expected Obj, but got I4
		//IL_09ed: Expected Obj, but got I
		//IL_11b0: Expected Obj, but got I
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected Obj, but got Unknown
		//IL_126b: Expected Obj, but got I
		//IL_12ca: Expected Obj, but got I4
		//IL_0a0b: Expected Obj, but got I
		//IL_0a29: Expected Obj, but got I
		//IL_0a5d: Expected Obj, but got I
		//IL_1120: Expected Obj, but got I
		//IL_1128: Expected I4, but got Obj
		//IL_130c: Expected F4, but got I
		//IL_0d27: Expected Obj, but got I4
		//IL_144e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1453: Expected Obj, but got Unknown
		//IL_1463: Expected Obj, but got I
		//IL_1911: Expected Obj, but got I
		//IL_193b: Expected Obj, but got I4
		//IL_0a94: Expected Obj, but got I4
		//IL_148c: Expected Obj, but got I
		//IL_14d7: Expected Obj, but got I4
		//IL_1205: Expected I4, but got I8
		//IL_1223: Expected Obj, but got I4
		//IL_1239: Expected I4, but got I8
		//IL_179a: Expected Obj, but got I4
		//IL_0b04: Expected Obj, but got I
		//IL_0b14: Expected Obj, but got I
		//IL_0ab8: Expected Obj, but got I
		//IL_0ad5: Expected Obj, but got I
		//IL_1596: Expected F4, but got I
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected Obj, but got I
		//IL_0dcf: Expected Obj, but got I
		//IL_1544: Expected Obj, but got I4
		//IL_17dd: Expected Obj, but got I4
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF358]");
		object obj = 0;
		if (action == (string)obj)
		{
			if (GillaOutfits.Save())
			{
				ClearPick();
				object obj2 = this + 424;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3C0]");
				object obj3 = 0;
				bannerText = (string)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bannerBad = false;
				banner = 1.6f;
				dirty = true;
				AudioClip clip = equipSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				Play(clip, 0f);
				AudioClip clip2 = sparkleSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				Play(clip2, 0f);
				Refill();
				SyncDrum();
			}
			else
			{
				object obj4 = this + 424;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF390]");
				object obj5 = 0;
				bannerText = (string)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bannerBad = true;
				banner = 1.6f;
				dirty = true;
				AudioClip clip3 = errorSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				Play(clip3, 0f);
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF368]");
		object obj6 = 0;
		if (action == (string)obj6)
		{
			int i = pickedOutfit - 1;
			if (pickedOutfit >= 1)
			{
				GillaOutfits.Wear(i);
				object obj7 = this + 424;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3B8]");
				object obj8 = 0;
				bannerText = (string)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				AudioClip audioClip = equipSound;
				bannerBad = false;
				banner = 1.6f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				float num = 0f;
				dirty = true;
				AudioClip clip4 = equipSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				Play(clip4, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj9 = 0;
				object obj10 = obj9;
				object obj11 = 0;
				goto IL_1609;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF388]");
		object obj12 = 0;
		if (action == (string)obj12 && pickedMonster >= 1)
		{
			MonsterDirector.Entry entry = MonsterCatalog.Of(pickedMonster);
			if (entry != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
				object obj13 = 0;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v124+E4]");
				bool flag = (nint)0 == 0;
				object obj15 = !flag;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				MonsterChoice.Pick(entry.name);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			float num = 0f;
			AudioClip clip5 = equipSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			Play(clip5, 0f);
			object obj16 = this + 424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF398]");
			AudioClip audioClip = (AudioClip)(object)(bannerText = (string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj17 = 0;
			bannerBad = false;
			banner = 1.6f;
			object obj10 = obj17;
			dirty = true;
			object obj11 = 0;
			goto IL_1609;
		}
		CosmeticCatalog.Entry entry2 = CosmeticCatalog.Of(picked);
		Coins.Bundle bundle = CosmeticCatalog.BundleAt(pickedBundle);
		if (pickedTitle >= 1)
		{
			int id = ((action == (string)obj12) ? pickedTitle : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v177+E4]");
			bool flag2 = (nint)0 == 0;
			object obj20 = !flag2;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NameTitles.Wear(id);
			bool flag3 = action == (string)obj12;
			bool flag4 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float volume = 0f;
			object obj21 = !flag4;
			object obj22 = ~obj21;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				volume = 0f;
			}
			Play(equipSound, volume);
			bool flag5 = action == (string)obj12;
			bool flag6 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF398]");
			object obj23 = 0;
			object obj24 = this + 424;
			object obj25 = !flag6;
			object obj26 = ~obj25;
			if (obj26 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3A8]");
				obj23 = 0;
			}
			bannerText = (string)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bannerBad = false;
			dirty = true;
			banner = 1.6f;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF350]");
		object obj27 = 0;
		if (action == (string)obj27)
		{
			bool flag7 = entry2 == null;
			object obj28 = !flag7;
			if (obj28 == null)
			{
				bool flag8 = bundle == null;
				object obj29 = !flag8;
				if (obj29 == null)
				{
					Unequip();
					return;
				}
			}
		}
		if (bundle == null)
		{
			goto IL_085f;
		}
		bool flag9 = action == (string)obj12;
		bool flag10 = !flag9;
		object obj30 = !flag10;
		int num2 = 0;
		if (obj30 == null)
		{
			bool flag11 = action == (string)obj27;
			bool flag12 = !flag11;
			num2 = 0;
			if (flag12)
			{
				goto IL_085f;
			}
		}
		List<byte> list = CosmeticCatalog.IdsOf(bundle);
		bool flag13 = list == null;
		UnityEngine.Object obj31 = null;
		Enumerator<, > val = default;
		int id2 = default;
		Enumerator<, > val4 = default;
		NullReferenceException ex2;
		Enumerator<, > val2;
		Enumerator<, > val3;
		if (!flag13)
		{
			Enumerator<, > enumerator = list.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj32 = 0;
			while (val.MoveNext())
			{
				if (action == (string)obj12)
				{
					object obj33 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X0_v168+E4]");
					bool flag14 = (nint)0 == 0;
					object obj34 = !flag14;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cosmetics.Wear((byte)id2);
					num2 = 0;
					continue;
				}
				CosmeticCatalog.Entry entry3 = CosmeticCatalog.Of(id2);
				if (entry3 != null)
				{
					object obj35 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v103+E4]");
					bool flag15 = (nint)0 == 0;
					object obj36 = !flag15;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cosmetics.TakeOff(entry3.slot);
					num2 = 0;
					continue;
				}
				goto IL_1316;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
			object obj37 = 0;
			obj31 = (UnityEngine.Object)obj37;
			val.Dispose();
			val2 = (Enumerator<, >)(ref val);
			val3 = val4;
			OutOfMemoryException ex = new OutOfMemoryException();
			float num = (float)val3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj31 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			}
			else
			{
				bool flag16 = (nint)obj31 != 1;
				NullReferenceException ex3 = default;
				ex2 = ex3;
				if (flag16)
				{
					goto IL_1949;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			}
			goto IL_13f9;
		}
		goto IL_15a6;
		IL_085f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD10]");
		object obj38 = 0;
		List<byte> list2 = default;
		int num4;
		int num3;
		if (action == (string)obj38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45C8]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D0]");
			object obj40 = 0;
			obj31 = (UnityEngine.Object)obj40;
			list2._002Ector();
			byte[] array = cart;
			bool flag17 = cart == null;
			num2 = 0;
			if (!flag17)
			{
				object obj41 = array.Length;
				bool flag18 = array.Length < 1;
				num3 = 0;
				num2 = 0;
				byte b = (byte)(int)obj40;
				if (flag18)
				{
					goto IL_0b94;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
				object obj42 = 0;
				num3 = 0;
				num4 = 0;
				int num5 = 0;
				float num = default;
				while (true)
				{
					bool flag19 = num5 < (nint)obj41;
					object obj43 = !flag19;
					val3 = (Enumerator<, >)num;
					if (obj43 != null)
					{
						break;
					}
					object obj44 = cart + num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v80+20]");
					b = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v80+20]");
					if ((nint)0 == 0)
					{
						goto IL_0b3e;
					}
					bool flag20 = list2 == null;
					num2 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v80+20]");
					obj31 = (UnityEngine.Object)0;
					if (!flag20)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+10]");
						object obj45 = 0;
						object obj46 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+1C]");
						object obj47 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+10]");
						bool flag21 = (nint)0 == 0;
						num2 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v80+20]");
						obj31 = (UnityEngine.Object)0;
						if (!flag21)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+18]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v83+18]");
							bool flag22 = num6 < 0;
							object obj48 = !flag22;
							if (obj48 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+18]");
								obj46 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+10]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+18]");
								object obj49 = num7 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v80+20]");
								_ = 0;
								num5 = num3;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X9_v16+20]");
								object obj50 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X8_v84+A8]");
								object obj51 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v85+70]");
								num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v80+20]");
								list2.AddWithResize((byte)0);
							}
							goto IL_0b3e;
						}
					}
					goto IL_15a6;
					IL_0b3e:
					obj41 = array.Length;
					num5++;
					bool flag23 = num5 < array.Length;
					num3 = num5;
					num2 = num4;
					num3 = num5;
					obj31 = (UnityEngine.Object)b;
					if (flag23)
					{
						continue;
					}
					goto IL_0b94;
				}
				goto IL_1342;
			}
			goto IL_15a6;
		}
		object obj55;
		if (action == (string)obj12 && entry2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj52 = 0;
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X0_v77+E4]");
			bool flag24 = (nint)0 == 0;
			object obj54 = !flag24;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cosmetics.Wear(picked);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			float num8 = 0f;
			AudioClip clip6 = equipSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			Play(clip6, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF398]");
			obj55 = 0;
			object obj56 = 0;
		}
		else
		{
			if (!(action == (string)obj27) || entry2 == null)
			{
				goto IL_0419;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj57 = 0;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v72+E4]");
			bool flag25 = (nint)0 == 0;
			object obj59 = !flag25;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cosmetics.TakeOff(entry2.slot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num8 = 0f;
			AudioClip clip7 = equipSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			Play(clip7, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3A8]");
			obj55 = 0;
			object obj56 = 0;
		}
		object obj60 = this + 424;
		bannerText = (string)obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bannerBad = false;
		dirty = true;
		banner = 1.6f;
		goto IL_0419;
		IL_1949:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_13f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
		Array array2 = cart;
		object obj66;
		if (cart != null)
		{
			byte[] array3 = cart;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v36 (System.Array)+18]");
			Array.Clear(array3, 0, 0);
			object obj61 = this + 424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3A0]");
			object obj62 = 0;
			bannerText = (string)obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj63 = 0;
			bannerBad = false;
			banner = 1.6f;
			object obj64 = obj63;
			dirty = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X0_v39+E4]");
			bool flag26 = (nint)0 == 0;
			object obj65 = !flag26;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag27 = buyCoins != null;
			bool flag28 = !flag27;
			int num9 = 0;
			if (!flag28)
			{
				bool flag29 = (object)buyCoins == null;
				obj66 = 0;
				num2 = 0;
				obj31 = null;
				if (flag29)
				{
					goto IL_15a6;
				}
				buyCoins.Emit(36);
				num9 = 0;
			}
			AudioClip clip8 = buySound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			Play(clip8, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CCC4");
			return;
		}
		goto IL_15a6;
		IL_1342:
		num2 = num4;
		throw new IndexOutOfRangeException();
		IL_1609:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v13+E4]");
		bool flag30 = (nint)0 == 0;
		object obj67 = !flag30;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tube != null)
		{
			bool flag31 = (object)tube == null;
			num2 = 0;
			obj31 = null;
			if (flag31)
			{
				goto IL_15a6;
			}
			tube.Flash();
		}
		goto IL_0419;
		IL_15a6:
		NullReferenceException ex4 = new NullReferenceException();
		ex2 = ex4;
		goto IL_1949;
		IL_0cfd:
		object obj69;
		object obj68 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1310 @ X0_v116+E4]");
		bool flag32 = (nint)0 == 0;
		object obj70 = !flag32;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int hand;
		string text;
		int num10;
		GillaToast.Bought(hand, text, num10);
		bool flag33 = bundle == null;
		obj31 = (UnityEngine.Object)(object)text;
		List<byte> list3 = list2;
		if (!flag33)
		{
			List<byte> list4 = CosmeticCatalog.IdsOf(bundle);
			obj31 = null;
			list3 = list4;
		}
		bool flag34 = list3 == null;
		obj66 = 0;
		num2 = num10;
		if (!flag34)
		{
			Enumerator<, > enumerator2 = list3.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4728]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj72 = 0;
			float num11 = default;
			while (true)
			{
				obj31 = (UnityEngine.Object)obj71;
				bool flag35 = val.MoveNext();
				bool flag36 = !flag35;
				obj66 = 0;
				val2 = (Enumerator<, >)(ref val);
				num2 = num10;
				float num = num11;
				if (flag36)
				{
					break;
				}
				object obj73 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1424 @ X0_v125+E4]");
				bool flag37 = (nint)0 == 0;
				object obj74 = !flag37;
				if (obj74 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cosmetics.Wear((byte)id2);
			}
			goto IL_13f9;
		}
		goto IL_15a6;
		IL_0419:
		UpdateTryOn();
		dirty = true;
		return;
		IL_0b94:
		num10 = CartTotal();
		Transform transform = base.transform;
		bool flag38 = (object)transform == null;
		obj31 = null;
		if (!flag38)
		{
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
			obj69 = 0;
			object obj75 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X0_v90+E4]");
			bool flag39 = (nint)0 == 0;
			object obj76 = !flag39;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			hand = GillaToast.NearerHand((Vector3)0);
			if (bundle != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj77 = 0;
				text = bundle.label;
				object obj78 = obj77;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X0_v132+E4]");
				bool flag40 = (nint)0 == 0;
				object obj79 = !flag40;
				if (obj79 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag41 = Coins.Buy(bundle);
				bool flag42 = !flag41;
				int num12 = 0;
				int num13 = num2;
				if (!flag42)
				{
					goto IL_0cfd;
				}
			}
			else
			{
				bool flag43 = list2 == null;
				obj31 = null;
				if (flag43)
				{
					goto IL_15a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v83 (System.Collections.Generic.List`1<System.Byte>)+18]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A0]");
					object obj80 = 0;
					num2 = (int)obj80;
					byte b2 = list2.get_Item(0);
					int id3 = b2 & 0xFF;
					CosmeticCatalog.Entry entry4 = CosmeticCatalog.Of(id3);
					bool flag44 = entry4 == null;
					obj31 = null;
					if (flag44)
					{
						goto IL_15a6;
					}
					text = entry4.label;
					string text2 = null;
				}
				else
				{
					string text3 = num3.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3B0]");
					object obj81 = 0;
					string text2 = (string)obj81;
					string text4 = text3 + (string)obj81;
					num2 = 0;
					text = text4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj82 = 0;
				object obj83 = obj82;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X0_v103+E4]");
				bool flag45 = (nint)0 == 0;
				object obj84 = !flag45;
				if (obj84 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag46 = Coins.Buy((IEnumerable<byte>)list2, -1);
				bool flag47 = !flag46;
				object obj85 = !flag47;
				num2 = 0;
				int num12 = -1;
				int num13 = 0;
				if (obj85 != null)
				{
					goto IL_0cfd;
				}
			}
			object obj86 = this + 424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF310]");
			object obj87 = 0;
			bannerText = (string)obj87;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj88 = obj69;
			bannerBad = true;
			banner = 1.6f;
			dirty = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1338 @ X0_v97+E4]");
			bool flag48 = (nint)0 == 0;
			object obj89 = !flag48;
			if (obj89 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaToast.NotEnough(hand, num10);
			AudioClip clip9 = errorSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			Play(clip9, 0f);
			return;
		}
		goto IL_15a6;
		IL_1316:
		NullReferenceException ex5 = new NullReferenceException();
		val2 = (Enumerator<, >)(ref val);
		num4 = 0;
		val3 = val4;
		obj31 = null;
		goto IL_1342;
	}

	private void Banner(string s, bool bad)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		bannerText = s;
		object obj = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bannerBad = bad;
		dirty = true;
		banner = 1.6f;
	}

	private int CartTotal()
	{
		//IL_01ee: Expected Obj, but got I
		//IL_01de: Expected I4, but got Obj
		//IL_002f: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I8
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		Coins.Bundle bundle = CosmeticCatalog.BundleAt(pickedBundle);
		if (bundle != null)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Coins.PriceOf(bundle);
		}
		byte[] array = cart;
		int num;
		if (cart != null)
		{
			if (array.Length < 1)
			{
				num = 0;
				goto IL_0250;
			}
			object obj4 = array.Length & 0xFFFFFFFFL;
			object obj5 = cart + 32;
			object obj6 = 0;
			num = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj7 = !flag2;
				if (obj7 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X25_v4+v112 @ X24_v5]");
				CosmeticCatalog.Entry entry = CosmeticCatalog.Of(0);
				if (entry != null)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v13+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X25_v4+v112 @ X24_v5]");
					bool flag4 = Coins.Owns(0);
					bool flag5 = !flag4;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						num = entry.price + num;
					}
				}
				obj4 = array.Length;
				obj6++;
				if ((nint)obj6 < array.Length)
				{
					continue;
				}
				goto IL_0250;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_0250:
		return num;
	}

	private unsafe void UpdateTryOn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d43: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_040c: Expected I4, but got Obj
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I
		//IL_0467: Expected I4, but got Obj
		//IL_0e14: Expected Obj, but got I4
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e29: Expected Obj, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I4
		//IL_047b: Expected I4, but got Obj
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I4
		//IL_016f: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I4
		//IL_0a48: Expected Obj, but got I4
		//IL_0699: Expected I4, but got Obj
		//IL_04f5: Expected Obj, but got I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got I4
		//IL_0715: Expected Obj, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I4
		//IL_0aaa: Expected Obj, but got I4
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected I4, but got Unknown
		//IL_0554: Expected Obj, but got I4
		//IL_0da2: Expected Obj, but got I4
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected Obj, but got Unknown
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got I4
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got I4
		//IL_056a: Expected I, but got Obj
		//IL_058c: Expected Obj, but got I4
		//IL_0f01: Expected Obj, but got I
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected Ref, but got Unknown
		//IL_0f2c: Expected Obj, but got I4
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected Obj, but got I4
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected I4, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_05fa: Expected I4, but got Obj
		//IL_0616: Expected Obj, but got I4
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected I4, but got Obj
		//IL_05b2: Expected I4, but got Obj
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got I4
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected Obj, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got I4
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8b: Expected Obj, but got I4
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected Obj, but got Unknown
		//IL_0c5e: Expected Obj, but got I4
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Expected Obj, but got Unknown
		//IL_08ae: Expected Obj, but got I4
		//IL_08c2: Expected Obj, but got I4
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected Obj, but got I4
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		UnityEngine.Object obj3 = tube;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj3 != null;
		bool flag3 = !flag2;
		object obj5 = 0;
		MonsterDirector.Entry entry = null;
		object obj8 = default;
		Enumerator<, > val;
		int num4;
		int c;
		object obj7;
		object obj10;
		bool flag6;
		int num2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
			byte[] array = (byte[])0;
			obj3 = tube;
			c = category;
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v73 (Il2CppClass<System.Byte[]>)+E4]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v73 (Il2CppClass<System.Byte[]>)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (IsMonsters(c))
			{
				bool flag5 = pickedMonster < 0;
				obj7 = !flag5;
				flag6 = pickedMonster == 0;
				obj8 = !flag6;
				bool flag7 = pickedMonster > 0;
				int monsterNow = pickedMonster;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v83 (Il2CppClass<System.Byte[]>)+E4]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v83 (Il2CppClass<System.Byte[]>)+E4]");
					bool flag8 = (nint)0 == 0;
					object obj9 = !flag8;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					monsterNow = MonsterNow;
				}
				MonsterDirector.Entry entry2 = MonsterCatalog.Of(monsterNow);
				obj10 = pickedMonster;
				entry = entry2;
			}
			else
			{
				entry = null;
			}
			bool flag9 = (object)obj3 == null;
			num4 = 0;
			val = (Enumerator<, >)0;
			obj5 = 0;
			if (flag9)
			{
				goto IL_0658;
			}
			((TryOnTube)obj3).ShowMonster(entry);
			obj5 = 0;
		}
		num2 = pickedOutfit;
		int i = pickedOutfit - 1;
		bool flag10 = pickedOutfit < 1;
		obj7 = !flag10;
		obj10 = pickedOutfit - 1;
		flag6 = obj10 == null;
		if (pickedOutfit >= 1)
		{
			GillaOutfits.Outfit outfit = GillaOutfits.At(i);
			bool flag11 = outfit == null;
			entry = null;
			if (!flag11)
			{
				byte[] sourceArray = GillaOutfits.IdsOf(outfit);
				Array array2 = tryOn;
				bool flag12 = tryOn == null;
				num4 = 0;
				val = (Enumerator<, >)0;
				if (!flag12)
				{
					byte[] destinationArray = tryOn;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X1_v30 (System.Array)+18]");
					Array.Copy(sourceArray, destinationArray, 0);
					object obj11 = obj;
					obj3 = tube;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v67+E4]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v67+E4]");
					bool flag13 = (nint)0 == 0;
					object obj12 = !flag13;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(obj3 != null))
					{
						return;
					}
					bool flag14 = (object)tube == null;
					num4 = 0;
					val = (Enumerator<, >)0;
					object obj13 = 0;
					obj5 = 0;
					if (!flag14)
					{
						tube.TryOn(tryOn);
						return;
					}
				}
				goto IL_0658;
			}
		}
		c = (int)tryOn;
		bool flag15 = tryOn == null;
		num4 = 0;
		val = (Enumerator<, >)0;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			byte[] array = (byte[])0;
			byte b2 = default;
			byte b = b2;
			CosmeticSlot cosmeticSlot2 = default;
			CosmeticSlot cosmeticSlot = cosmeticSlot2;
			int num5 = (int)tryOn;
			UnityEngine.Object obj14 = null;
			Enumerator<, > val2 = default;
			object obj13 = default;
			object obj33 = default;
			int num7 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X21_v2 (System.Int32)+18]");
				num2 = 0;
				UnityEngine.Object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X21_v2 (System.Int32)+18]");
				bool flag16 = (nint)obj15 < 0;
				obj7 = !flag16;
				UnityEngine.Object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X21_v2 (System.Int32)+18]");
				obj10 = obj16 - 0;
				flag6 = obj10 == null;
				UnityEngine.Object obj17 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X21_v2 (System.Int32)+18]");
				bool flag7 = (nint)obj17 >= 0;
				num4 = 0;
				val = (Enumerator<, >)0;
				b2 = b;
				cosmeticSlot2 = cosmeticSlot;
				c = num5;
				obj3 = obj14;
				if (!flag7)
				{
					cosmeticSlot2 = (CosmeticSlot)cart;
					bool flag17 = cart == null;
					num4 = 0;
					val = (Enumerator<, >)0;
					b2 = b;
					c = num5;
					obj3 = obj14;
					if (flag17)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v3 (CosmeticSlot)+18]");
					b2 = 0;
					UnityEngine.Object obj18 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v3 (CosmeticSlot)+18]");
					bool flag18 = (nint)obj18 < 0;
					object obj19 = !flag18;
					num4 = 0;
					val = (Enumerator<, >)0;
					if (obj19 == null)
					{
						cosmeticSlot2 = (CosmeticSlot)(cosmeticSlot2 + obj14);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v3 (CosmeticSlot)+20]");
						byte b3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v3 (CosmeticSlot)+20]");
						bool flag19 = (nint)0 == 0;
						object obj20 = !flag19;
						if (obj20 == null)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v60 (Il2CppClass<System.Byte[]>)+E4]");
							bool flag20 = (nint)0 == 0;
							object obj21 = !flag20;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							b3 = Cosmetics.In((CosmeticSlot)obj14);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X21_v2 (System.Int32)+18]");
							num2 = 0;
							entry = null;
						}
						bool flag21 = (nint)obj14 < num2;
						obj7 = !flag21;
						obj10 = obj14 - num2;
						flag6 = obj10 == null;
						num4 = 0;
						val = (Enumerator<, >)0;
						if (obj7 == null)
						{
							num2 = num5 + obj14;
							obj3 = (UnityEngine.Object)(obj14 + 1);
							c = (int)tryOn;
							bool flag22 = tryOn == null;
							object obj22 = !flag22;
							num4 = 0;
							val = (Enumerator<, >)0;
							b = b2;
							cosmeticSlot = cosmeticSlot2;
							num5 = (int)tryOn;
							obj14 = obj3;
							if (obj22 == null)
							{
								break;
							}
							continue;
						}
					}
					goto IL_0acf;
				}
				CosmeticCatalog.Entry entry3 = CosmeticCatalog.Of(picked);
				if (entry3 != null)
				{
					num2 = (int)tryOn;
					if (tryOn == null)
					{
						break;
					}
					cosmeticSlot2 = entry3.slot;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v34 (System.Int32)+18]");
					b2 = 0;
					CosmeticSlot slot = entry3.slot;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v34 (System.Int32)+18]");
					bool flag23 = (nint)slot < (nint)0;
					obj7 = !flag23;
					CosmeticSlot slot2 = entry3.slot;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v34 (System.Int32)+18]");
					obj10 = (nint)slot2 - (nint)0;
					flag6 = obj10 == null;
					num5 = c;
					entry = null;
					if (obj7 != null)
					{
						goto IL_0acf;
					}
					b2 = picked;
					num2 = (int)(num2 + entry3.slot);
					_ = picked;
				}
				Coins.Bundle bundle = CosmeticCatalog.BundleAt(pickedBundle);
				bool flag24 = bundle == null;
				MonsterDirector.Entry entry4 = null;
				if (!flag24)
				{
					List<byte> list = CosmeticCatalog.IdsOf(bundle);
					if (list == null)
					{
						break;
					}
					Enumerator<, > enumerator = list.GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4728]");
					num5 = 0;
					cosmeticSlot2 = (CosmeticSlot)(int)(&val);
					object obj23;
					Enumerator<, > val3;
					Enumerator<, > val4;
					while (val.MoveNext())
					{
						array = tryOn;
						CosmeticCatalog.Entry entry5 = CosmeticCatalog.Of(num7);
						bool flag25 = entry5 == null;
						num7 = 0;
						num4 = 0;
						val = val2;
						obj23 = 0;
						val3 = val2;
						val4 = (Enumerator<, >)(ref val);
						entry = null;
						if (flag25)
						{
							goto IL_0af3;
						}
						bool flag26 = tryOn == null;
						num7 = 0;
						num4 = 0;
						val = val2;
						obj23 = 0;
						val3 = val2;
						val4 = (Enumerator<, >)(ref val);
						entry = null;
						if (!flag26)
						{
							cosmeticSlot2 = (CosmeticSlot)array.Length;
							bool flag27 = (int)entry5.slot < array.Length;
							obj7 = !flag27;
							obj10 = entry5.slot - array.Length;
							flag6 = obj10 == null;
							num7 = 0;
							num4 = 0;
							val = val2;
							obj23 = 0;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							entry = null;
							if (obj7 == null)
							{
								object obj24 = tryOn + entry5.slot;
								_ = 0;
								continue;
							}
							goto IL_0ae5;
						}
						goto IL_0b01;
					}
					num7 = 0;
					num4 = 0;
					val = val2;
					obj23 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					object obj25 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
						object obj26 = 0;
						entry = (MonsterDirector.Entry)obj26;
						((Enumerator<, >*)val4)->Dispose();
						bool flag28 = obj25 == null;
						object obj27 = !flag28;
						int num8;
						object obj29;
						Enumerator<, > val5;
						byte b4;
						CosmeticSlot cosmeticSlot3;
						object obj30;
						object obj31;
						byte[] array3;
						object obj32;
						if (obj27 == null)
						{
							bool flag29 = num7 == 0;
							object obj28 = !flag29;
							c = num5;
							entry4 = (MonsterDirector.Entry)obj26;
							num8 = num4;
							obj29 = obj23;
							val5 = val3;
							b4 = b2;
							cosmeticSlot3 = cosmeticSlot2;
							obj30 = obj13;
							obj31 = obj8;
							array3 = array;
							obj32 = obj5;
							OutOfMemoryException ex = (OutOfMemoryException)val4;
							if (obj28 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
							num8 = num4;
							obj29 = obj23;
							val5 = val3;
							b4 = b2;
							cosmeticSlot3 = cosmeticSlot2;
							obj30 = obj13;
							obj31 = obj8;
							array3 = array;
							obj32 = obj5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						bool flag30 = (nint)entry < 2;
						obj7 = !flag30;
						obj10 = entry - 2;
						flag6 = obj10 == null;
						if ((nint)entry == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							num7 = 1;
							num4 = num8;
							obj23 = obj29;
							val3 = val5;
							b2 = b4;
							cosmeticSlot2 = cosmeticSlot3;
							obj13 = obj30;
							obj8 = obj31;
							array = array3;
							obj5 = obj32;
							obj25 = obj29;
							continue;
						}
						bool flag31 = (nint)entry < 1;
						obj7 = !flag31;
						obj10 = entry - 1;
						flag6 = obj10 == null;
						if ((nint)entry == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj25 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							num4 = num8;
							obj23 = obj33;
							val3 = val5;
							b2 = b4;
							cosmeticSlot2 = cosmeticSlot3;
							obj13 = obj30;
							obj8 = obj31;
							array = array3;
							obj5 = obj32;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				object obj34 = obj;
				obj3 = tube;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v34+E4]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v34+E4]");
				bool flag32 = (nint)0 == 0;
				object obj35 = !flag32;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj3 != null)
				{
					bool flag33 = (object)tube == null;
					obj5 = 0;
					if (flag33)
					{
						break;
					}
					tube.TryOn(tryOn);
				}
				return;
				IL_0ae5:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				goto IL_0af3;
				IL_0b01:
				throw new NullReferenceException();
				IL_0acf:
				IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
				num7 = num7;
				goto IL_0ae5;
				IL_0af3:
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_0b01;
			}
		}
		goto IL_0658;
		IL_0658:
		throw new NullReferenceException();
	}

	private unsafe void Refill()
	{
		//IL_232f: Unknown result type (might be due to invalid IL or missing references)
		//IL_233b: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_2362: Expected Obj, but got I
		//IL_2372: Expected Obj, but got I
		//IL_238f: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c09: Expected Obj, but got I4
		//IL_1c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c36: Expected I4, but got Unknown
		//IL_1c75: Expected Obj, but got I4
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I4
		//IL_108f: Expected Obj, but got I
		//IL_109f: Expected Obj, but got I
		//IL_10af: Expected Obj, but got I
		//IL_10bf: Expected Obj, but got I
		//IL_10cf: Expected Obj, but got I
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2624: Expected Obj, but got I4
		//IL_255c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got I
		//IL_07a5: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got I
		//IL_17d5: Expected Obj, but got I
		//IL_241d: Expected Obj, but got I4
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected Obj, but got I
		//IL_0cb2: Expected Obj, but got I
		//IL_0303: Expected I4, but got I8
		//IL_031d: Expected Obj, but got I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d09: Expected Obj, but got I4
		//IL_10f9: Expected I, but got Obj
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ea: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I
		//IL_1d27: Expected Obj, but got I
		//IL_1d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_113e: Expected Obj, but got I4
		//IL_182e: Expected I, but got Obj
		//IL_0837: Expected Obj, but got I4
		//IL_2781: Expected Obj, but got I
		//IL_2789: Unknown result type (might be due to invalid IL or missing references)
		//IL_2792: Expected Ref, but got Unknown
		//IL_27ac: Expected Obj, but got I4
		//IL_27ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b4: Expected I4, but got Unknown
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1178: Expected Obj, but got I4
		//IL_1192: Expected Obj, but got I4
		//IL_11a2: Expected Obj, but got I4
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Expected I4, but got Unknown
		//IL_11e0: Expected I, but got Obj
		//IL_087b: Expected Obj, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1862: Expected I, but got Obj
		//IL_1712: Expected Obj, but got I4
		//IL_1712: Unknown result type (might be due to invalid IL or missing references)
		//IL_171a: Expected I4, but got Unknown
		//IL_171a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1722: Expected Obj, but got Unknown
		//IL_0d32: Expected Obj, but got I
		//IL_0d3a: Expected I4, but got Obj
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd7: Expected Obj, but got I4
		//IL_1de0: Expected Obj, but got I4
		//IL_1de9: Expected Obj, but got I4
		//IL_1203: Expected Obj, but got I4
		//IL_120c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1211: Expected Obj, but got Unknown
		//IL_122b: Expected Obj, but got I4
		//IL_1230: Expected I, but got Obj
		//IL_23e5: Expected I, but got Obj
		//IL_0420: Expected Obj, but got I
		//IL_0428: Expected I4, but got Obj
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I4
		//IL_1878: Expected I, but got Obj
		//IL_189a: Expected Obj, but got I4
		//IL_1747: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Expected I4, but got Unknown
		//IL_1757: Expected I, but got Obj
		//IL_0ded: Expected Obj, but got I4
		//IL_1e2c: Expected Obj, but got I4
		//IL_1e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e64: Expected Obj, but got I4
		//IL_1e6d: Expected Obj, but got I4
		//IL_1e76: Expected Obj, but got I4
		//IL_1270: Expected Obj, but got I4
		//IL_18d4: Expected Obj, but got I4
		//IL_18ee: Expected Obj, but got I4
		//IL_18fe: Expected Obj, but got I4
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_191a: Expected I4, but got Unknown
		//IL_193c: Expected I, but got Obj
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected Obj, but got I
		//IL_0e5e: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got I4
		//IL_246d: Expected Obj, but got I
		//IL_247d: Expected Obj, but got I
		//IL_249f: Expected Obj, but got I4
		//IL_22d5: Expected I4, but got Obj
		//IL_22e7: Expected I4, but got Obj
		//IL_177c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1784: Expected I4, but got Unknown
		//IL_178c: Expected I, but got Obj
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I
		//IL_1e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9b: Expected I4, but got Unknown
		//IL_1eab: Expected Obj, but got I
		//IL_1ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efb: Expected Obj, but got I4
		//IL_1f04: Expected Obj, but got I4
		//IL_1304: Expected I4, but got Obj
		//IL_1347: Expected Obj, but got I4
		//IL_1957: Expected Obj, but got I4
		//IL_1960: Unknown result type (might be due to invalid IL or missing references)
		//IL_1965: Expected Obj, but got Unknown
		//IL_197f: Expected Obj, but got I4
		//IL_1984: Expected I, but got Obj
		//IL_0905: Expected Obj, but got I
		//IL_090d: Expected I4, but got Obj
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fd: Expected Obj, but got I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_1395: Expected Obj, but got I4
		//IL_12c7: Expected Obj, but got I4
		//IL_0eeb: Expected Obj, but got I
		//IL_0f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_135d: Expected I4, but got Obj
		//IL_24c5: Expected Obj, but got I
		//IL_24df: Expected Obj, but got I
		//IL_24f0: Expected I, but got Obj
		//IL_250e: Expected Obj, but got I
		//IL_19b3: Expected Obj, but got I4
		//IL_19bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c1: Expected Obj, but got Unknown
		//IL_19d5: Expected I, but got Obj
		//IL_09ae: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I
		//IL_05aa: Expected I4, but got Obj
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got I4
		//IL_2098: Unknown result type (might be due to invalid IL or missing references)
		//IL_209c: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c1: Expected Obj, but got I4
		//IL_20ca: Expected Obj, but got I4
		//IL_13b8: Expected I4, but got Obj
		//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f9: Expected Obj, but got I4
		//IL_12f7: Expected Obj, but got I
		//IL_0a14: Expected Obj, but got I
		//IL_0a24: Expected Obj, but got I
		//IL_0fab: Expected Obj, but got I4
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected Obj, but got I
		//IL_100b: Expected Obj, but got I
		//IL_101b: Expected Obj, but got I
		//IL_0645: Expected Obj, but got I4
		//IL_210d: Expected Obj, but got I4
		//IL_2115: Unknown result type (might be due to invalid IL or missing references)
		//IL_2119: Unknown result type (might be due to invalid IL or missing references)
		//IL_213e: Expected Obj, but got I4
		//IL_2147: Expected Obj, but got I4
		//IL_1414: Expected I4, but got Obj
		//IL_144a: Expected Obj, but got I4
		//IL_0fd6: Expected Obj, but got I
		//IL_06ad: Expected Obj, but got I
		//IL_06bd: Expected Obj, but got I
		//IL_14b1: Expected Obj, but got I
		//IL_14c1: Expected Obj, but got I
		//IL_1a41: Expected Obj, but got I
		//IL_0a9a: Expected Obj, but got I
		//IL_0aa2: Expected I4, but got Obj
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected Obj, but got I
		//IL_2167: Unknown result type (might be due to invalid IL or missing references)
		//IL_216c: Expected Obj, but got Unknown
		//IL_219b: Unknown result type (might be due to invalid IL or missing references)
		//IL_219f: Unknown result type (might be due to invalid IL or missing references)
		//IL_21bc: Expected Obj, but got I4
		//IL_21c5: Expected Obj, but got I4
		//IL_1504: Unknown result type (might be due to invalid IL or missing references)
		//IL_1510: Expected Obj, but got I4
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Expected Obj, but got Unknown
		//IL_149c: Expected I4, but got Obj
		//IL_1aec: Expected Obj, but got I4
		//IL_0b3e: Expected Obj, but got I4
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f0: Expected Obj, but got I
		//IL_152e: Expected Obj, but got I
		//IL_1536: Expected I4, but got Obj
		//IL_156e: Unknown result type (might be due to invalid IL or missing references)
		//IL_157a: Expected Obj, but got I4
		//IL_1b51: Expected Obj, but got I
		//IL_1b61: Expected Obj, but got I
		//IL_0ba6: Expected Obj, but got I
		//IL_0bb6: Expected Obj, but got I
		//IL_272a: Expected Obj, but got I
		//IL_272e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2d: Expected Obj, but got I
		//IL_1b3c: Expected I, but got Obj
		//IL_0b69: Expected Obj, but got I
		//IL_0b91: Expected I, but got Obj
		//IL_268a: Expected Obj, but got I4
		//IL_269a: Unknown result type (might be due to invalid IL or missing references)
		//IL_269e: Unknown result type (might be due to invalid IL or missing references)
		//IL_26bb: Expected Obj, but got I4
		//IL_26c4: Expected Obj, but got I4
		//IL_26f4: Expected I4, but got Obj
		//IL_15d1: Expected Obj, but got I4
		//IL_1639: Expected Obj, but got I
		//IL_1649: Expected Obj, but got I
		//IL_15fc: Expected Obj, but got I
		List<byte> list = shown;
		filter = 1;
		bool flag = shown == null;
		Enumerator<, > val = (Enumerator<, >)0;
		nint num = default;
		Tile tile = (Tile)num;
		int num2 = 1;
		int num29 = default;
		int num24 = default;
		byte b5 = default;
		int num23;
		object obj15;
		int num6 = default;
		Enumerator<, > val3 = default;
		byte b = default;
		int num7 = default;
		object obj9;
		Coins.Bundle bundle;
		int num3;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (System.Collections.Generic.List`1<System.Byte>)+1C]");
			num2 = (int)((nint)0 + (nint)1);
			_ = 0;
			List<int> list2 = shownBundles;
			bool flag2 = shownBundles == null;
			val = (Enumerator<, >)0;
			tile = (Tile)num;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v53 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				num2 = (int)((nint)0 + (nint)1);
				_ = 0;
				List<int> list3 = shownTitles;
				bool flag3 = shownTitles == null;
				val = (Enumerator<, >)0;
				tile = (Tile)num;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v54 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					num2 = (int)((nint)0 + (nint)1);
					_ = 0;
					List<int> list4 = shownOutfits;
					bool flag4 = shownOutfits == null;
					val = (Enumerator<, >)0;
					tile = (Tile)num;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v55 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						num2 = (int)((nint)0 + (nint)1);
						_ = 0;
						List<int> list5 = shownMonsters;
						bool flag5 = shownMonsters == null;
						val = (Enumerator<, >)0;
						tile = (Tile)num;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
							object obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v56 (System.Collections.Generic.List`1<System.Int32>)+1C]");
							num2 = (int)((nint)0 + (nint)1);
							object obj2 = obj;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v62+E4]");
							bool flag6 = (nint)0 == 0;
							object obj3 = !flag6;
							if (obj3 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj2 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v62+A0]");
							object obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v58+8]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v58+8]");
							bool flag7 = (nint)0 == 0;
							val = (Enumerator<, >)0;
							tile = (Tile)num;
							if (!flag7)
							{
								num2 = category;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v59+18]");
								num3 = 0;
								int num4 = category;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v59+18]");
								bool flag8 = (nint)num4 < (nint)0;
								object obj6 = !flag8;
								val = (Enumerator<, >)0;
								tile = (Tile)num;
								if (obj6 != null)
								{
									goto IL_2208;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v58+8]");
								object obj7 = (nint)0 + (nint)category;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v60+28]");
								bundle = (Coins.Bundle)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v60+28]");
								if ((nint)0 > (nint)253)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v60+28]");
									if ((nint)0 != 255)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v60+28]");
										bool flag9 = (nint)0 != 254;
										val = (Enumerator<, >)0;
										if (flag9)
										{
											goto IL_179f;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
										object obj8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
										bundle = (Coins.Bundle)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
										obj9 = 0;
										int num5 = 1;
										while (true)
										{
											object obj10 = obj8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v98+E4]");
											bool flag10 = (nint)0 == 0;
											object obj11 = !flag10;
											if (obj11 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											int count = NameTitles.Count;
											bool flag11 = num5 > count;
											val = (Enumerator<, >)0;
											num6 = 1;
											if (flag11)
											{
												break;
											}
											object obj12 = obj8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v102+E4]");
											bool flag12 = (nint)0 == 0;
											object obj13 = !flag12;
											if (obj13 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag13 = NameTitles.MayWear(num5);
											bool flag14 = !flag13;
											object obj14 = !flag14;
											obj15 = ~obj14;
											num2 = ((obj15 != null) ? 1 : (1 + 1));
											bool flag15 = filter == num2;
											num = unchecked((nint)null);
											if (flag15)
											{
												goto IL_0be2;
											}
											List<byte> list6 = shown;
											bool flag16 = shown == null;
											val = (Enumerator<, >)0;
											num6 = 1;
											tile = null;
											if (!flag16)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+10]");
												object obj16 = 0;
												num2 = (int)bundle;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+1C]");
												num3 = (int)((nint)0 + (nint)1);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+10]");
												bool flag17 = (nint)0 == 0;
												val = (Enumerator<, >)0;
												num6 = 1;
												tile = null;
												if (!flag17)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+18]");
													num3 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v93+18]");
													num7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+18]");
													nint num8 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v93+18]");
													bool flag18 = num8 < 0;
													object obj17 = !flag18;
													if (obj17 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+18]");
														num2 = (int)((nint)0 + (nint)1);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+10]");
														nint num9 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v107 (System.Collections.Generic.List`1<System.Byte>)+18]");
														object obj18 = num9 + 0;
														_ = 0;
														tile = null;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
														object obj19 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1631 @ X8_v99+A8]");
														object obj20 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v100+70]");
														b = 0;
														shown.AddWithResize((byte)0);
														tile = null;
													}
													List<int> list7 = shownTitles;
													bool flag19 = shownTitles == null;
													val = (Enumerator<, >)0;
													num6 = 1;
													if (!flag19)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+10]");
														object obj21 = 0;
														num2 = (int)obj9;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+1C]");
														num3 = (int)((nint)0 + (nint)1);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+10]");
														bool flag20 = (nint)0 == 0;
														val = (Enumerator<, >)0;
														num6 = 1;
														if (!flag20)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+18]");
															num3 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v95+18]");
															num7 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+18]");
															nint num10 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v95+18]");
															bool flag21 = num10 < 0;
															object obj22 = !flag21;
															if (obj22 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+10]");
																nint num11 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+18]");
																object obj23 = num11 + 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v108 (System.Collections.Generic.List`1<System.Int32>)+18]");
																num2 = (int)((nint)0 + (nint)1);
																num = (nint)tile;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
																object obj24 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1738 @ X8_v96+A8]");
																object obj25 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ X8_v97+70]");
																b = 0;
																shownTitles.AddWithResize(num5);
																num = num5;
															}
															goto IL_0be2;
														}
													}
												}
											}
											goto IL_21fa;
											IL_0be2:
											num5++;
										}
									}
									else
									{
										int bundleCount = CosmeticCatalog.BundleCount;
										bool flag22 = bundleCount < 1;
										val = (Enumerator<, >)0;
										if (!flag22)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
											num6 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2A8]");
											object obj26 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF298]");
											object obj27 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A0]");
											object obj28 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
											object obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
											object obj30 = 0;
											int num12 = 0;
											Predicate<byte> predicate = default;
											while (true)
											{
												Coins.Bundle bundle2 = CosmeticCatalog.BundleAt(num12);
												List<byte> list8 = CosmeticCatalog.IdsOf(bundle2);
												bool flag23 = list8 == null;
												val = (Enumerator<, >)0;
												tile = null;
												bundle = bundle2;
												if (flag23)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v68 (System.Collections.Generic.List`1<System.Byte>)+18]");
												bool flag24 = (nint)0 == 0;
												num = unchecked((nint)null);
												bundle = bundle2;
												if (!flag24)
												{
													int value = ((int*)num6)->m_value;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X0_v72 (System.Int32)+E4]");
													bool flag25 = (nint)0 == 0;
													object obj31 = !flag25;
													if (obj31 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													bool flag26 = Coins.OwnsAll(bundle2);
													object obj32 = filter - 1;
													bool flag27 = obj32 == null;
													object obj33 = !flag27;
													object obj34 = filter - 2;
													bool flag28 = obj34 == null;
													num2 = ((obj33 | flag26) ? 1 : 0);
													int num13 = num2 & 1;
													bool flag29 = num13 == 0;
													num = unchecked((nint)null);
													bundle = bundle2;
													if (!flag29)
													{
														object obj35 = flag26 & flag28;
														object obj36 = obj35 & 1;
														bool flag30 = obj36 == null;
														object obj37 = !flag30;
														num = unchecked((nint)null);
														bundle = bundle2;
														if (obj37 == null)
														{
															object obj38 = obj26;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1617 @ X0_v77+E4]");
															bool flag31 = (nint)0 == 0;
															object obj39 = !flag31;
															if (obj39 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																obj38 = obj26;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1617 @ X0_v77+A0]");
															object obj40 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X8_v80+8]");
															Predicate<byte> match = (Predicate<byte>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X8_v80+8]");
															bool flag32 = (nint)0 == 0;
															object obj41 = !flag32;
															if (obj41 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1617 @ X0_v77+E4]");
																num2 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1617 @ X0_v77+E4]");
																bool flag33 = (nint)0 == 0;
																object obj42 = !flag33;
																if (obj42 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	object obj43 = obj26;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ X8_v86+A0]");
																	obj40 = 0;
																}
																obj9 = obj40;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4758]");
																object obj44 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2A0]");
																object obj45 = 0;
																predicate._002Ector(obj40, (IntPtr)obj45);
																object obj46 = obj26;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1649 @ X8_v85+A0]");
																object obj47 = (nint)0 + (nint)8;
																obj47 = predicate;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																match = predicate;
															}
															b = (byte)(int)obj27;
															byte b2 = list8.Find(match);
															bundle = (Coins.Bundle)(object)shown;
															int num14 = b2 & 0xFF;
															bool flag34 = num14 == 0;
															object obj48 = !flag34;
															if (obj48 == null)
															{
																b = (byte)(int)obj28;
																b2 = list8.get_Item(0);
															}
															bool flag35 = bundle == null;
															val = (Enumerator<, >)0;
															tile = (Tile)b2;
															if (flag35)
															{
																break;
															}
															string text = bundle.name;
															num2 = (int)obj29;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X22_v1 (Coins+Bundle)+1C]");
															num3 = (int)((nint)0 + (nint)1);
															bool flag36 = bundle.name == null;
															val = (Enumerator<, >)0;
															tile = (Tile)b2;
															if (flag36)
															{
																break;
															}
															num3 = (int)bundle.label;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v71 (System.String)+18]");
															num7 = 0;
															string label = bundle.label;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v71 (System.String)+18]");
															bool flag37 = (nint)label < 0;
															object obj49 = !flag37;
															if (obj49 == null)
															{
																string text2 = bundle.label + 1;
																object obj50 = bundle.name + bundle.label;
																bundle.label = text2;
																num2 = (int)text2;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
																object obj51 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X8_v77+A8]");
																object obj52 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1745 @ X8_v78+70]");
																b = 0;
																((List<byte>)(object)bundle).AddWithResize(b2);
															}
															List<int> list9 = shownBundles;
															bool flag38 = shownBundles == null;
															val = (Enumerator<, >)0;
															tile = (Tile)b2;
															if (flag38)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+10]");
															object obj53 = 0;
															num2 = (int)obj30;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															num3 = (int)((nint)0 + (nint)1);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+10]");
															bool flag39 = (nint)0 == 0;
															val = (Enumerator<, >)0;
															tile = (Tile)b2;
															if (flag39)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+18]");
															num3 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v73+18]");
															num7 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+18]");
															nint num15 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v73+18]");
															bool flag40 = num15 < 0;
															object obj54 = !flag40;
															if (obj54 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+10]");
																nint num16 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+18]");
																object obj55 = num16 + 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83 (System.Collections.Generic.List`1<System.Int32>)+18]");
																num2 = (int)((nint)0 + (nint)1);
																num = (int)b2;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
																object obj56 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1767 @ X8_v74+A8]");
																object obj57 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1444 @ X8_v75+70]");
																b = 0;
																shownBundles.AddWithResize(num12);
																num = num12;
															}
														}
													}
												}
												num12++;
												int bundleCount2 = CosmeticCatalog.BundleCount;
												if (num12 < bundleCount2)
												{
													continue;
												}
												goto IL_16a8;
											}
											goto IL_21fa;
										}
									}
									goto IL_1bf0;
								}
								if ((nint)bundle != 252)
								{
									bool flag41 = (nint)bundle != 253;
									val = (Enumerator<, >)0;
									if (flag41)
									{
										goto IL_179f;
									}
									int count2 = GillaOutfits.Count;
									int num17 = (int)(count2 & 0x80000000L);
									bool flag42 = num17 == 0;
									object obj58 = !flag42;
									val = (Enumerator<, >)0;
									if (obj58 != null)
									{
										goto IL_1bf0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
									bundle = (Coins.Bundle)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
									obj9 = 0;
									int num18 = 0;
									while (true)
									{
										List<byte> list10 = shown;
										byte b4;
										if (num18 != 0)
										{
											int i = num18 - 1;
											GillaOutfits.Outfit o = GillaOutfits.At(i);
											byte b3 = GillaOutfits.FaceOf(o);
											bool flag43 = shown == null;
											object obj59 = !flag43;
											b4 = b3;
											if (obj59 == null)
											{
												val = (Enumerator<, >)0;
												tile = (Tile)b3;
												break;
											}
										}
										else
										{
											bool flag44 = shown == null;
											b4 = 0;
											val = (Enumerator<, >)0;
											tile = null;
											if (flag44)
											{
												break;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+10]");
										object obj60 = 0;
										num2 = (int)bundle;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+1C]");
										num3 = (int)((nint)0 + (nint)1);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+10]");
										bool flag45 = (nint)0 == 0;
										val = (Enumerator<, >)0;
										tile = (Tile)b4;
										if (flag45)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+18]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v120+18]");
										num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+18]");
										nint num19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v120+18]");
										bool flag46 = num19 < 0;
										object obj61 = !flag46;
										if (obj61 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+18]");
											num2 = (int)((nint)0 + (nint)1);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+10]");
											nint num20 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v26 (System.Collections.Generic.List`1<System.Byte>)+18]");
											object obj62 = num20 + 0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
											object obj63 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1454 @ X8_v127+A8]");
											object obj64 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1456 @ X8_v128+70]");
											b = 0;
											shown.AddWithResize(b4);
										}
										List<int> list11 = shownOutfits;
										bool flag47 = shownOutfits == null;
										val = (Enumerator<, >)0;
										tile = (Tile)b4;
										if (flag47)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+10]");
										object obj65 = 0;
										num2 = (int)obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										num3 = (int)((nint)0 + (nint)1);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+10]");
										bool flag48 = (nint)0 == 0;
										val = (Enumerator<, >)0;
										tile = (Tile)b4;
										if (flag48)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+18]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v122+18]");
										num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v122+18]");
										bool flag49 = num21 < 0;
										object obj66 = !flag49;
										if (obj66 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+10]");
											nint num22 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj67 = num22 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v127 (System.Collections.Generic.List`1<System.Int32>)+18]");
											num2 = (int)((nint)0 + (nint)1);
											num = (int)b4;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
											object obj68 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1608 @ X8_v124+A8]");
											object obj69 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1610 @ X8_v125+70]");
											b = 0;
											shownOutfits.AddWithResize(num18);
											num = num18;
										}
										num18++;
										int count3 = GillaOutfits.Count;
										if (num18 <= count3)
										{
											continue;
										}
										goto IL_071f;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
									object obj70 = 0;
									object obj71 = obj70;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v111+E4]");
									bool flag50 = (nint)0 == 0;
									object obj72 = !flag50;
									if (obj72 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									List<int> list12 = MonsterChoice.Choices();
									bool flag51 = list12 == null;
									val = (Enumerator<, >)0;
									tile = (Tile)num;
									if (!flag51)
									{
										Enumerator<, > enumerator = list12.GetEnumerator();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
										object obj73 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
										obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
										num6 = 0;
										num2 = (int)(&val);
										Enumerator<, > val2 = default;
										while (true)
										{
											tile = (Tile)obj73;
											if (!val.MoveNext())
											{
												break;
											}
											List<byte> list13 = shown;
											bool flag52 = shown == null;
											num23 = 0;
											num24 = 0;
											val = val2;
											val3 = val2;
											b5 = (byte)(&val);
											if (!flag52)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+10]");
												object obj74 = 0;
												num2 = (int)obj9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+1C]");
												num3 = (int)((nint)0 + (nint)1);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+10]");
												bool flag53 = (nint)0 == 0;
												num23 = 0;
												num24 = 0;
												val = val2;
												val3 = val2;
												b5 = (byte)(&val);
												if (!flag53)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+18]");
													num3 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v110+18]");
													num7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+18]");
													nint num25 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v110+18]");
													bool flag54 = num25 < 0;
													object obj75 = !flag54;
													if (obj75 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+18]");
														num2 = (int)((nint)0 + (nint)1);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+10]");
														nint num26 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v119 (System.Collections.Generic.List`1<System.Byte>)+18]");
														object obj76 = num26 + 0;
														_ = 0;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
														object obj77 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ X8_v116+A8]");
														object obj78 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v117+70]");
														b = 0;
														shown.AddWithResize((byte)0);
														tile = null;
													}
													List<int> list14 = shownMonsters;
													bool flag55 = shownMonsters == null;
													num23 = 0;
													num24 = 0;
													val = val2;
													val3 = val2;
													b5 = (byte)(&val);
													if (!flag55)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+10]");
														object obj79 = 0;
														num2 = ((int*)num6)->m_value;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+1C]");
														num3 = (int)((nint)0 + (nint)1);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+10]");
														bool flag56 = (nint)0 == 0;
														num23 = 0;
														num24 = 0;
														val = val2;
														val3 = val2;
														b5 = (byte)(&val);
														if (!flag56)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+18]");
															num3 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v112+18]");
															num7 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+18]");
															nint num27 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v112+18]");
															bool flag57 = num27 < 0;
															object obj80 = !flag57;
															if (obj80 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+10]");
																nint num28 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+18]");
																object obj81 = num28 + 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v120 (System.Collections.Generic.List`1<System.Int32>)+18]");
																num2 = (int)((nint)0 + (nint)1);
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
																object obj82 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1658 @ X8_v113+A8]");
																object obj83 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1318 @ X8_v114+70]");
																b = 0;
																shownMonsters.AddWithResize(num29);
															}
															continue;
														}
													}
													goto IL_222c;
												}
											}
											goto IL_221e;
										}
										num23 = 0;
										num24 = 0;
										val = val2;
										val3 = val2;
										Enumerator<, > val4 = (Enumerator<, >)(ref val);
										object obj84 = 5;
										int num30 = 0;
										object obj85;
										object obj88 = default;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
											obj85 = 0;
											tile = (Tile)obj85;
											((Enumerator<, >*)val4)->Dispose();
											bool flag58 = num30 == 0;
											object obj86 = !flag58;
											b5 = (byte)(int)val4;
											if (obj86 == null)
											{
												bool flag59 = num23 == 0;
												object obj87 = !flag59;
												b5 = (byte)(int)val4;
												OutOfMemoryException ex = (OutOfMemoryException)val4;
												if (obj87 == null)
												{
													break;
												}
											}
											else
											{
												OutOfMemoryException ex = new OutOfMemoryException();
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
											if ((nint)tile == 2)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
												num23 = 1;
												num30 = num24;
											}
											else
											{
												if ((nint)tile != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
													return;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
												num30 = (int)obj88;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
												num24 = (int)obj88;
											}
											val4 = (Enumerator<, >)b5;
											obj84 = 0;
										}
										bool flag60 = obj84 == null;
										num29 = num23;
										b5 = (byte)(int)val4;
										num = (nint)obj85;
										if (flag60)
										{
											goto IL_179f;
										}
										bool flag61 = (nint)obj84 == 5;
										num29 = num23;
										b5 = (byte)(int)val4;
										num = (nint)obj85;
										if (!flag61)
										{
											return;
										}
										goto IL_1bf0;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_21fa;
		IL_071f:
		val = (Enumerator<, >)0;
		goto IL_1bf0;
		IL_2208:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		num23 = num29;
		goto IL_221e;
		IL_221e:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_222c;
		IL_21fa:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_2208;
		IL_16a8:
		val = (Enumerator<, >)0;
		goto IL_1bf0;
		IL_222c:
		throw new NullReferenceException();
		IL_179f:
		int count4 = CosmeticCatalog.Count;
		if (count4 < 1)
		{
			goto IL_1bf0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
		num6 = 0;
		byte b6 = b;
		int num31 = num7;
		int num32 = num3;
		int num33 = num2;
		int num34 = 1;
		while (true)
		{
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num34);
			bool flag62 = entry == null;
			b = b6;
			num7 = num31;
			tile = null;
			num3 = num32;
			num2 = num33;
			if (flag62)
			{
				break;
			}
			bool flag63 = (nint)entry.slot != (nint)bundle;
			num = unchecked((nint)null);
			if (!flag63)
			{
				bool flag64 = string.IsNullOrEmpty(entry.wornWith);
				bool flag65 = !flag64;
				num = unchecked((nint)null);
				if (!flag65)
				{
					nint num35 = (nint)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X0_v55 (Il2CppClass<System.Object>)+E4]");
					bool flag66 = (nint)0 == 0;
					object obj89 = !flag66;
					if (obj89 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag67 = Coins.Owns((byte)num34);
					object obj90 = filter - 1;
					bool flag68 = obj90 == null;
					object obj91 = !flag68;
					object obj92 = filter - 2;
					bool flag69 = obj92 == null;
					num33 = ((obj91 | flag67) ? 1 : 0);
					int num36 = num33 & 1;
					bool flag70 = num36 == 0;
					num = unchecked((nint)null);
					if (!flag70)
					{
						object obj93 = flag67 & flag69;
						object obj94 = obj93 & 1;
						bool flag71 = obj94 == null;
						object obj95 = !flag71;
						num = unchecked((nint)null);
						if (obj95 == null)
						{
							bool flag72 = !entry.retired;
							object obj96 = flag72 | flag67;
							object obj97 = obj96 & 1;
							bool flag73 = obj97 == null;
							num = unchecked((nint)null);
							if (!flag73)
							{
								List<byte> list15 = shown;
								bool flag74 = shown == null;
								b = b6;
								num7 = num31;
								tile = null;
								num3 = num32;
								num2 = num33;
								if (flag74)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+10]");
								object obj98 = 0;
								num2 = ((int*)num6)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+1C]");
								num3 = (int)((nint)0 + (nint)1);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+10]");
								bool flag75 = (nint)0 == 0;
								b = b6;
								num7 = num31;
								tile = null;
								if (flag75)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+18]");
								num32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v49+18]");
								num31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+18]");
								nint num37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v49+18]");
								bool flag76 = num37 < 0;
								object obj99 = !flag76;
								if (obj99 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+18]");
									num33 = (int)((nint)0 + (nint)1);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+10]");
									nint num38 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59 (System.Collections.Generic.List`1<System.Byte>)+18]");
									object obj100 = num38 + 0;
									num = unchecked((nint)null);
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
									object obj101 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1737 @ X8_v50+A8]");
									object obj102 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X8_v51+70]");
									b6 = 0;
									shown.AddWithResize((byte)num34);
									num = num34;
									num33 = ((int*)num6)->m_value;
								}
							}
						}
					}
				}
			}
			num34++;
			int count5 = CosmeticCatalog.Count;
			bool flag77 = num34 <= count5;
			b = b6;
			num7 = num31;
			num3 = num32;
			num2 = num33;
			if (flag77)
			{
				continue;
			}
			goto IL_1bf0;
		}
		goto IL_21fa;
		IL_1bf0:
		int num39 = MaxScroll();
		object obj103 = scroll - num39;
		bool flag78 = (nint)obj103 < 0;
		int num40 = scroll ^ num39;
		int num41 = scroll ^ obj103;
		int num42 = num40 & num41;
		bool flag79 = num42 < 0;
		int num43 = glideDir;
		bool flag80 = flag78 == flag79;
		object obj104 = !flag80;
		object obj105 = ~obj104;
		int num44 = ((obj105 != null) ? num39 : scroll);
		bool flag81 = scroll < 0;
		int num45 = scroll ^ scroll;
		int num46 = scroll & num45;
		bool flag82 = num46 < 0;
		bool flag83 = flag81 == flag82;
		object obj106 = !flag83;
		obj15 = ~obj106;
		if (obj15 == null)
		{
			num44 = 0;
		}
		scroll = num44;
		if (num43 != 0)
		{
			GlideTiles(num43);
		}
		else
		{
			Tile[] array = tiles;
			bool flag84 = tiles == null;
			tile = (Tile)num43;
			if (flag84)
			{
				goto IL_21fa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
			object obj107 = 0;
			int num48 = default;
			int num47 = num48;
			byte b8 = default;
			byte b7 = b8;
			Enumerator<, > val5 = val3;
			int num49 = num6;
			byte b9 = b;
			int num50 = num7;
			int num51 = num3;
			int num52 = 17276928;
			int num53 = 0;
			int num54 = default;
			int num55 = default;
			while (num53 < array.Length)
			{
				(byte, int, int, int, int) tuple = Wanted(num53);
				Tile[] array2 = tiles;
				bool flag85 = tiles == null;
				num48 = num47;
				b8 = b7;
				val3 = val5;
				num6 = num49;
				b = b9;
				num7 = num50;
				tile = (Tile)num53;
				obj9 = 1;
				bundle = (Coins.Bundle)109891584;
				num3 = num51;
				num2 = num52;
				if (!flag85)
				{
					num2 = array2.Length;
					bool flag86 = num53 < array2.Length;
					object obj108 = !flag86;
					num48 = num47;
					b8 = b7;
					val3 = val5;
					num6 = num49;
					b = b9;
					num7 = num50;
					tile = (Tile)num53;
					obj9 = 1;
					bundle = (Coins.Bundle)109891584;
					num3 = num51;
					if (obj108 != null)
					{
						goto IL_2208;
					}
					num2 = tiles + num53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
					tile = (Tile)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v43 (System.Int32)+20]");
					bool flag87 = (nint)0 == 0;
					num48 = num47;
					b8 = b7;
					val3 = val5;
					num6 = num53;
					b = b9;
					num7 = num50;
					obj9 = 1;
					bundle = (Coins.Bundle)109891584;
					num3 = num51;
					if (!flag87)
					{
						b8 = tile.id;
						if (tile.id == b5)
						{
							bool flag88 = tile.bundle != num54;
							b8 = (byte)tile.bundle;
							if (!flag88)
							{
								b8 = (byte)tile.title;
								if (tile.title == num24)
								{
									b8 = (byte)tile.outfit;
									if (tile.outfit == num55)
									{
										b8 = (byte)tile.monster;
										bool flag89 = tile.monster == num29;
										b7 = (byte)tile.monster;
										num6 = num53;
										num2 = num54;
										array = tiles;
										if (flag89)
										{
											goto IL_2662;
										}
									}
								}
							}
						}
						tile.title = num24;
						tile.bundle = num54;
						tile.outfit = num55;
						tile.monster = num29;
						Fill(tile, b5);
						Tile[] array3 = tiles;
						bool flag90 = tiles == null;
						num48 = num29;
						val3 = val5;
						num6 = num53;
						b = b5;
						num7 = num55;
						obj9 = 1;
						bundle = (Coins.Bundle)109891584;
						num3 = num24;
						num2 = num54;
						if (!flag90)
						{
							num2 = array3.Length;
							bool flag91 = num53 < array3.Length;
							object obj109 = !flag91;
							num48 = num29;
							val3 = val5;
							num6 = num53;
							b = b5;
							num7 = num55;
							obj9 = 1;
							bundle = (Coins.Bundle)109891584;
							num3 = num24;
							if (obj109 != null)
							{
								goto IL_2208;
							}
							object obj110 = tiles + num53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v27+20]");
							num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v27+20]");
							bool flag92 = (nint)0 == 0;
							num48 = num29;
							val3 = val5;
							b = b5;
							num7 = num55;
							obj9 = 1;
							bundle = (Coins.Bundle)109891584;
							num3 = num24;
							if (!flag92)
							{
								int num56 = num53;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
								object obj111 = (nint)num56 * (nint)0;
								object obj112 = obj107;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1765 @ X8_v29+A0]");
								object obj113 = 0;
								val5 = (Enumerator<, >)obj113;
								array = tiles;
								b7 = b8;
								goto IL_2662;
							}
						}
					}
				}
				goto IL_21fa;
				IL_2662:
				num53++;
				bool flag93 = array == null;
				object obj114 = !flag93;
				num48 = num29;
				b8 = b7;
				val3 = val5;
				b = b5;
				num7 = num55;
				obj9 = 1;
				bundle = (Coins.Bundle)109891584;
				num3 = num24;
				num47 = num29;
				num49 = num6;
				b9 = b5;
				num50 = num55;
				num43 = (int)tile;
				num51 = num24;
				num52 = num2;
				if (obj114 != null)
				{
					continue;
				}
				goto IL_21fa;
			}
		}
		glideDir = 0;
		UpdateTryOn();
		dirty = true;
	}

	private unsafe (byte, int, int, int, int) Wanted(int i)
	{
		//IL_01d9: Expected VT, but got Obj
		//IL_00bf: Expected I4, but got I8
		//IL_016f: Expected I4, but got I8
		//IL_02af: Expected VT, but got I4
		//IL_02d3: Expected native int or pointer, but got VT
		List<byte> list = shown;
		if (shown != null)
		{
			int num = i + scroll;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+18]");
			byte item;
			if ((nint)num < (nint)0)
			{
				byte b = shown.get_Item(num);
				item = b;
			}
			else
			{
				item = 0;
			}
			List<int> list2 = shownBundles;
			if (shownBundles != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				int item2;
				if ((nint)num < (nint)0)
				{
					int num2 = shownBundles.get_Item(num);
					item2 = num2;
				}
				else
				{
					item2 = -1;
				}
				List<int> list3 = shownTitles;
				if (shownTitles != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
					int item3;
					if ((nint)num < (nint)0)
					{
						int num3 = shownTitles.get_Item(num);
						item3 = num3;
					}
					else
					{
						item3 = 0;
					}
					List<int> list4 = shownOutfits;
					if (shownOutfits != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
						int item4;
						if ((nint)num < (nint)0)
						{
							int num4 = shownOutfits.get_Item(num);
							item4 = num4;
						}
						else
						{
							item4 = -1;
						}
						List<int> list5 = shownMonsters;
						if (shownMonsters != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v12 (System.Collections.Generic.List`1<System.Int32>)+18]");
							int item5;
							if ((nint)num < (nint)0)
							{
								int num5 = shownMonsters.get_Item(num);
								item5 = num5;
							}
							else
							{
								item5 = 0;
							}
							(byte, int, int, int, int) tuple = ((byte, int, int, int, int))0;
							_ = 0;
							_ = 0;
							*((byte, int, int, int, int)*)(nint)tuple = (item, item2, item3, item4, item5);
							return tuple;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return ((byte, int, int, int, int))ex;
	}

	private unsafe void GlideTiles(int dir)
	{
		//IL_0010: Expected Obj, but got I
		//IL_28bd: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_268f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2694: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a8: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got I4
		//IL_2fb2: Expected I4, but got Obj
		//IL_2740: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I4
		//IL_2fec: Expected Obj, but got I
		//IL_2ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ffd: Expected Ref, but got Unknown
		//IL_3017: Expected Obj, but got I4
		//IL_26b6: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I4
		//IL_276c: Expected Obj, but got I4
		//IL_276c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2774: Expected Obj, but got Unknown
		//IL_27b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I4
		//IL_29fc: Expected Obj, but got I4
		//IL_2a11: Expected Obj, but got I
		//IL_2a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a51: Expected I4, but got Unknown
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected Obj, but got Unknown
		//IL_0ee7: Expected Obj, but got I
		//IL_0ef2: Expected Obj, but got I4
		//IL_2876: Expected I4, but got Obj
		//IL_0237: Expected Obj, but got I4
		//IL_288d: Expected I4, but got Obj
		//IL_2b8d: Expected Obj, but got I
		//IL_2b95: Expected I4, but got Obj
		//IL_2bae: Expected Obj, but got I
		//IL_2bd0: Expected Obj, but got I4
		//IL_2be6: Expected Obj, but got I
		//IL_2c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2f: Expected I4, but got Unknown
		//IL_2c74: Expected Obj, but got I4
		//IL_2c7d: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_0329: Expected Obj, but got I
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected I4, but got Unknown
		//IL_1d9d: Expected Obj, but got I4
		//IL_081d: Expected Obj, but got I4
		//IL_0839: Expected Obj, but got I4
		//IL_0841: Expected I4, but got Obj
		//IL_025f: Expected Obj, but got I4
		//IL_0f4f: Expected Obj, but got I4
		//IL_0f58: Expected Obj, but got I4
		//IL_0f61: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I4
		//IL_1ddb: Expected Obj, but got I
		//IL_1e12: Expected Obj, but got I4
		//IL_0858: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_3058: Expected Obj, but got I
		//IL_3079: Expected Obj, but got I4
		//IL_308e: Expected Obj, but got I
		//IL_30c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ce: Expected I4, but got Unknown
		//IL_312c: Expected Obj, but got I4
		//IL_3135: Expected Obj, but got I4
		//IL_3146: Expected Obj, but got I4
		//IL_0fb9: Expected Obj, but got I8
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected Obj, but got Unknown
		//IL_0fd5: Expected Obj, but got I4
		//IL_0ff0: Expected Obj, but got I4
		//IL_1012: Expected Obj, but got I4
		//IL_102a: Expected I4, but got Obj
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_2d14: Expected Obj, but got I
		//IL_2d35: Expected Obj, but got I4
		//IL_2d4f: Expected Obj, but got I4
		//IL_2d94: Expected Obj, but got I8
		//IL_28ec: Expected Obj, but got I4
		//IL_28fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2901: Expected Obj, but got Unknown
		//IL_2936: Unknown result type (might be due to invalid IL or missing references)
		//IL_293b: Expected I4, but got Unknown
		//IL_294b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2950: Expected I4, but got Unknown
		//IL_298d: Expected Obj, but got I4
		//IL_29b5: Expected Obj, but got I4
		//IL_1e6b: Expected Obj, but got I4
		//IL_1e80: Expected Obj, but got I
		//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec0: Expected I4, but got Unknown
		//IL_1ef5: Expected Obj, but got I4
		//IL_1efe: Expected Obj, but got I4
		//IL_2795: Expected Obj, but got I4
		//IL_103f: Expected Obj, but got I
		//IL_1061: Expected Obj, but got I4
		//IL_04b9: Expected Obj, but got I4
		//IL_1f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f49: Expected Obj, but got Unknown
		//IL_1f59: Expected Obj, but got I
		//IL_1f7b: Expected Obj, but got I4
		//IL_1c5e: Expected Obj, but got I
		//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6c: Expected Obj, but got Unknown
		//IL_1c8d: Expected Obj, but got I4
		//IL_1c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca2: Expected Obj, but got Unknown
		//IL_1cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd5: Expected I4, but got Unknown
		//IL_1ce2: Expected I4, but got Obj
		//IL_1d2d: Expected Obj, but got I4
		//IL_1d52: Expected Obj, but got I8
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected Obj, but got Unknown
		//IL_0745: Expected Obj, but got I4
		//IL_077d: Expected I4, but got Obj
		//IL_078a: Expected I4, but got Obj
		//IL_2db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dbe: Expected Obj, but got Unknown
		//IL_2dd8: Expected Obj, but got I4
		//IL_2e01: Expected Obj, but got I4
		//IL_2e0a: Expected Obj, but got I4
		//IL_2e13: Expected Obj, but got I4
		//IL_1088: Expected Obj, but got I4
		//IL_10a2: Expected Obj, but got I4
		//IL_10e7: Expected Obj, but got I8
		//IL_051f: Expected Obj, but got I4
		//IL_0530: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_1fc1: Expected Obj, but got I4
		//IL_1fca: Expected Obj, but got I4
		//IL_1fdb: Expected Obj, but got I4
		//IL_1105: Expected Obj, but got I
		//IL_1115: Expected Obj, but got I
		//IL_113f: Expected Obj, but got I4
		//IL_2053: Expected Obj, but got I4
		//IL_2066: Expected Obj, but got I4
		//IL_20a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a9: Expected I4, but got Unknown
		//IL_1179: Expected Obj, but got I
		//IL_119a: Expected Obj, but got I4
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Expected Obj, but got Unknown
		//IL_11dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Expected I4, but got Unknown
		//IL_11ef: Expected I4, but got Obj
		//IL_197c: Expected I4, but got Obj
		//IL_1985: Expected Obj, but got I4
		//IL_19ca: Expected Obj, but got I8
		//IL_2ea7: Expected Obj, but got I4
		//IL_2eb0: Expected Obj, but got I4
		//IL_2ec1: Expected Obj, but got I4
		//IL_2ee9: Expected Obj, but got Ref
		//IL_2109: Expected Obj, but got I
		//IL_2124: Expected I, but got Obj
		//IL_1241: Expected I4, but got Obj
		//IL_124a: Expected Obj, but got I4
		//IL_128f: Expected Obj, but got I8
		//IL_1a00: Expected I4, but got Obj
		//IL_1a09: Expected Obj, but got I4
		//IL_1a2a: Expected Obj, but got I4
		//IL_1a67: Expected Obj, but got I8
		//IL_2189: Expected Obj, but got I4
		//IL_2199: Unknown result type (might be due to invalid IL or missing references)
		//IL_219e: Expected Obj, but got Unknown
		//IL_21b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b5: Expected I4, but got Unknown
		//IL_21c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ca: Expected I4, but got Unknown
		//IL_12ad: Expected Obj, but got I
		//IL_12bd: Expected Obj, but got I
		//IL_12d5: Expected Obj, but got I
		//IL_12f7: Expected Obj, but got I4
		//IL_2385: Expected I4, but got Obj
		//IL_23cd: Expected I, but got Obj
		//IL_23d5: Expected I4, but got Obj
		//IL_1aa2: Expected Obj, but got I
		//IL_1af7: Expected I4, but got Obj
		//IL_1b00: Expected Obj, but got I4
		//IL_1b19: Expected Obj, but got I4
		//IL_1b4e: Expected Obj, but got I8
		//IL_133c: Expected I4, but got Obj
		//IL_1345: Expected Obj, but got I4
		//IL_1366: Expected Obj, but got I4
		//IL_13a3: Expected Obj, but got I8
		//IL_23f2: Expected Obj, but got I
		//IL_2422: Expected Obj, but got I4
		//IL_221c: Expected Obj, but got I
		//IL_223e: Expected Obj, but got I4
		//IL_2283: Expected Obj, but got I4
		//IL_228b: Expected I4, but got Obj
		//IL_2293: Expected I4, but got Obj
		//IL_1b90: Expected Obj, but got I4
		//IL_13c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cd: Expected Obj, but got Unknown
		//IL_13d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected Obj, but got Unknown
		//IL_13e9: Expected I4, but got Obj
		//IL_13f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f7: Expected Obj, but got Unknown
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Expected Obj, but got Unknown
		//IL_140d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1412: Expected Obj, but got Unknown
		//IL_1428: Unknown result type (might be due to invalid IL or missing references)
		//IL_142d: Expected VT, but got Unknown
		//IL_1465: Expected Obj, but got I4
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected Obj, but got Unknown
		//IL_14a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ad: Expected I4, but got Unknown
		//IL_14ba: Expected I4, but got Obj
		//IL_14ef: Expected I4, but got Obj
		//IL_14f8: Expected Obj, but got I4
		//IL_1501: Expected Obj, but got I4
		//IL_153e: Expected Obj, but got I8
		//IL_0680: Expected Obj, but got I4
		//IL_0695: Expected Obj, but got I
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected I4, but got Unknown
		//IL_1c1a: Expected Obj, but got I
		//IL_08c0: Expected Obj, but got I4
		//IL_08d1: Expected Obj, but got I4
		//IL_08f1: Expected Obj, but got I4
		//IL_2f90: Expected I, but got Obj
		//IL_2fa0: Expected Obj, but got I
		//IL_22bb: Expected Obj, but got I4
		//IL_22c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c9: Expected Obj, but got Unknown
		//IL_22d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d9: Expected I4, but got Unknown
		//IL_22e6: Expected I4, but got Obj
		//IL_230b: Expected I4, but got Obj
		//IL_2313: Expected I4, but got Obj
		//IL_231b: Expected I4, but got Obj
		//IL_2358: Expected I, but got Obj
		//IL_2369: Expected I4, but got Obj
		//IL_2cd2: Expected Obj, but got I
		//IL_2cf7: Expected I4, but got Obj
		//IL_2cff: Expected I4, but got Obj
		//IL_1bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb5: Expected Obj, but got Unknown
		//IL_1bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be3: Expected Obj, but got Unknown
		//IL_1bf3: Expected Obj, but got I
		//IL_155c: Expected Obj, but got I
		//IL_158c: Expected I4, but got Obj
		//IL_1595: Expected Obj, but got I4
		//IL_15a6: Expected Obj, but got I4
		//IL_15b7: Expected Obj, but got I4
		//IL_15f4: Expected Obj, but got I8
		//IL_2f07: Expected I, but got Obj
		//IL_2f17: Expected Obj, but got I
		//IL_2f1f: Expected I4, but got Obj
		//IL_2f2e: Expected I4, but got Obj
		//IL_2f47: Expected I4, but got Obj
		//IL_2f50: Expected Obj, but got I4
		//IL_2f59: Expected Obj, but got I4
		//IL_2f6a: Expected Obj, but got I4
		//IL_2cad: Expected I4, but got Obj
		//IL_2cb5: Expected Obj, but got I4
		//IL_0927: Expected I, but got Obj
		//IL_0979: Expected Obj, but got I4
		//IL_098a: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I4
		//IL_161d: Expected Obj, but got I
		//IL_163e: Expected Obj, but got I4
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1653: Expected Obj, but got Unknown
		//IL_1681: Unknown result type (might be due to invalid IL or missing references)
		//IL_1686: Expected I4, but got Unknown
		//IL_1693: Expected I4, but got Obj
		//IL_16c8: Expected I4, but got Obj
		//IL_16d1: Expected Obj, but got I4
		//IL_16da: Expected Obj, but got I4
		//IL_1717: Expected Obj, but got I8
		//IL_24bc: Expected I4, but got Obj
		//IL_24c5: Expected Obj, but got I4
		//IL_24ce: Expected Obj, but got I4
		//IL_24df: Expected Obj, but got I4
		//IL_09e3: Expected Obj, but got I4
		//IL_0a14: Expected Obj, but got I4
		//IL_0a3c: Expected Obj, but got I4
		//IL_1759: Expected I4, but got Obj
		//IL_1762: Expected Obj, but got I4
		//IL_1773: Expected Obj, but got I4
		//IL_1784: Expected Obj, but got I4
		//IL_17c1: Expected Obj, but got I8
		//IL_251e: Expected Obj, but got I4
		//IL_2533: Expected Obj, but got I
		//IL_256e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2573: Expected I4, but got Unknown
		//IL_2597: Expected I4, but got Obj
		//IL_25a1: Expected I4, but got Obj
		//IL_25b2: Expected Obj, but got I4
		//IL_25bb: Expected Obj, but got I4
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected Obj, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got Unknown
		//IL_0a87: Expected Obj, but got I
		//IL_0aa1: Expected Obj, but got I
		//IL_0acb: Expected Obj, but got I4
		//IL_17fc: Expected Obj, but got I
		//IL_1851: Expected I4, but got Obj
		//IL_185a: Expected Obj, but got I4
		//IL_186b: Expected Obj, but got I4
		//IL_187c: Expected Obj, but got I4
		//IL_18b1: Expected Obj, but got I8
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected Obj, but got Unknown
		//IL_0b3e: Expected Obj, but got I
		//IL_0b57: Expected Obj, but got I4
		//IL_25eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f0: Expected Obj, but got Unknown
		//IL_2620: Expected I4, but got Obj
		//IL_2628: Expected I4, but got Obj
		//IL_2632: Expected I4, but got Obj
		//IL_2652: Expected I4, but got Obj
		//IL_18f3: Expected Obj, but got I4
		//IL_2abe: Expected Obj, but got I4
		//IL_1c49: Expected Obj, but got I
		//IL_0bc9: Expected Obj, but got I4
		//IL_0c34: Expected Obj, but got I4
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_1918: Expected Obj, but got Unknown
		//IL_1941: Unknown result type (might be due to invalid IL or missing references)
		//IL_1946: Expected Obj, but got Unknown
		//IL_1956: Expected Obj, but got I
		//IL_2af3: Expected Obj, but got I4
		//IL_2b14: Expected Obj, but got I4
		//IL_2b1d: Expected Obj, but got I4
		//IL_2b3d: Expected Obj, but got I4
		//IL_2b55: Expected Obj, but got I4
		//IL_0c79: Expected Obj, but got I4
		//IL_0c88: Expected Obj, but got I4
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected I4, but got Unknown
		//IL_0cff: Expected Obj, but got I4
		//IL_0d1f: Expected Obj, but got I4
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Expected Obj, but got Unknown
		//IL_0d6a: Expected Obj, but got I
		//IL_0da2: Expected Obj, but got I4
		//IL_0dab: Expected Obj, but got I4
		//IL_0dcb: Expected Obj, but got I4
		//IL_0de3: Expected Obj, but got I4
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected Obj, but got Unknown
		//IL_0e2f: Expected I4, but got Obj
		//IL_0e4e: Expected I4, but got Obj
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Expected Obj, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected Obj, but got Unknown
		//IL_0e8a: Expected I4, but got Obj
		//IL_0e9c: Expected Obj, but got I4
		//IL_0eb5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE54B]");
		Array array = (Array)0;
		bool flag = tiles == null;
		int num = dir;
		int num2 = dir;
		Tile[] array2 = (Tile[])109895680;
		int num3 = default;
		Array array3 = default;
		object obj6 = default;
		object obj7;
		Tile[] array6 = default;
		List<System.__Canon> list3 = default;
		int num6;
		int num19;
		UnityEngine.Object obj19;
		List<System.__Canon> list = default;
		int num4;
		int num24;
		int num20 = default;
		UnityEngine.Object obj21 = default;
		object obj5;
		nint num5;
		object obj3;
		int num21;
		int num16 = default;
		int num15 = default;
		Enumerator<, > val;
		NullReferenceException ex = default;
		if (!flag)
		{
			object obj = tiles.Clone();
			bool flag2 = obj == null;
			num = 0;
			num2 = dir;
			array2 = (Tile[])109895680;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF400]");
				object obj2 = 0;
				list = (List<System.__Canon>)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag3 = num3 == 0;
				val = (Enumerator<, >)array3;
				obj3 = obj;
				num2 = dir;
				array2 = (Tile[])109895680;
				if (flag3)
				{
					List<System.__Canon> list2 = list;
					throw new InvalidCastException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				array = tiles;
				bool flag4 = tiles == null;
				num4 = num3;
				obj3 = obj;
				num2 = dir;
				array2 = (Tile[])109895680;
				if (!flag4)
				{
					Tile[] array4 = tiles;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
					Array.Clear(array4, 0, 0);
					array = tiles;
					bool flag5 = tiles == null;
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
					num5 = 0;
					num4 = num3;
					obj3 = obj6;
					num = 0;
					num2 = dir;
					array2 = (Tile[])109895680;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B800]");
						num6 = 0;
						object obj8 = obj6 + 32;
						object obj9 = num3 + 32;
						int num7 = 0;
						num = 0;
						array2 = null;
						object obj15 = default;
						object obj38;
						object obj18;
						object obj10;
						object obj11;
						bool flag7;
						bool flag8;
						int num11;
						int num12;
						int num13;
						bool flag9;
						bool flag14;
						int num25;
						int num18 = default;
						Tile[] array5;
						while (true)
						{
							int num8 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
							bool flag6 = (nint)num8 < (nint)0;
							obj10 = !flag6;
							int num9 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
							obj11 = (nint)num9 - (nint)0;
							flag7 = (nint)obj11 < 0;
							flag8 = obj11 == null;
							int num10 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
							num11 = (int)((nint)num10 ^ (nint)0);
							num12 = num7 ^ obj11;
							num13 = num11 & num12;
							flag9 = num13 < 0;
							int num14 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
							if ((nint)num14 >= (nint)0)
							{
								break;
							}
							(byte, int, int, int, int) tuple = Wanted(num7);
							bool flag10 = array3 == null;
							object obj12 = !flag10;
							int num17;
							object obj16;
							if (obj12 == null)
							{
								bool flag11 = num15 == 0;
								object obj13 = !flag11;
								if (obj13 == null)
								{
									object obj14 = obj15 & 0x80000000L;
									if (obj14 != null)
									{
										bool flag12 = num16 == 0;
										num17 = num16;
										obj16 = obj15;
										num18 = num15;
										array5 = array6;
										num = num7;
										if (flag12)
										{
											goto IL_0805;
										}
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
							bool flag13 = (nint)0 < (nint)1;
							obj10 = !flag13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
							obj11 = -1;
							flag7 = (nint)obj11 < 0;
							flag8 = obj11 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
							num11 = (int)((nint)0 ^ (nint)1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
							num12 = 0 ^ obj11;
							num13 = num11 & num12;
							flag9 = num13 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
							flag14 = (nint)0 < (nint)1;
							num17 = num16;
							obj16 = obj15;
							num18 = num15;
							array5 = array6;
							num = num7;
							if (flag14)
							{
								goto IL_0805;
							}
							bool flag15 = obj6 == null;
							num17 = num16;
							obj16 = obj15;
							num18 = num15;
							obj18 = 1;
							array5 = array6;
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
							num5 = 0;
							num4 = num3;
							list = (List<System.__Canon>)num7;
							obj3 = obj6;
							num = num7;
							array = array3;
							num2 = dir;
							if (flag15)
							{
								goto IL_265f;
							}
							obj17 &= 0xFFFFFFFFL;
							num19 = num20;
							obj19 = null;
							bool flag16 = flag14;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44 (System.Object)+18]");
								bool flag17 = 0 < (nint)obj19;
								obj10 = !flag17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44 (System.Object)+18]");
								obj11 = 0 - obj19;
								flag7 = (nint)obj11 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44 (System.Object)+18]");
								flag8 = 0 == (nint)obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44 (System.Object)+18]");
								num11 = 0 ^ obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44 (System.Object)+18]");
								num12 = 0 ^ obj11;
								num13 = num11 & num12;
								flag9 = num13 < 0;
								num17 = num16;
								obj16 = obj15;
								num18 = num15;
								obj18 = 1;
								array5 = array6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
								num5 = 0;
								num4 = num3;
								list = (List<System.__Canon>)num7;
								obj3 = obj6;
								num21 = num7;
								num2 = dir;
								if (flag8)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X26_v11+v1420 @ X25_v16 (UnityEngine.Object)]");
								bool flag18 = (nint)0 == 0;
								object obj20 = !flag18;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
									num20 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
									bool flag19 = (nint)0 == 0;
									obj21 = obj19;
									flag14 = flag16;
									num17 = num16;
									obj16 = obj15;
									num18 = num15;
									obj18 = 1;
									array5 = array6;
									obj5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
									num5 = 0;
									num4 = num3;
									list = (List<System.__Canon>)num7;
									obj3 = obj6;
									num = num7;
									array = array3;
									num2 = dir;
									if (flag19)
									{
										goto IL_265f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+20]");
									bool flag20 = 0 != (nint)array3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
									num19 = 0;
									if (!flag20)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+28]");
										bool flag21 = 0 != (nint)array6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
										num19 = 0;
										if (!flag21)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+24]");
											bool flag22 = (nint)0 != num15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
											num19 = 0;
											if (!flag22)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+2C]");
												flag14 = 0 != (nint)obj15;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
												num19 = 0;
												if (!flag14)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+30]");
													bool flag23 = (nint)0 < (nint)num16;
													obj10 = !flag23;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+30]");
													obj11 = -num16;
													flag7 = (nint)obj11 < 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+30]");
													flag8 = (nint)0 == num16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+30]");
													num11 = (int)((nint)0 ^ (nint)num16);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+30]");
													num12 = 0 ^ obj11;
													num13 = num11 & num12;
													flag9 = num13 < 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
													num19 = 0;
													if (flag8)
													{
														goto IL_0876;
													}
												}
											}
										}
									}
								}
								obj21 = (UnityEngine.Object)(obj19 + 1);
								bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj21);
								obj10 = !flag24;
								obj11 = obj17 - (object)obj21;
								flag7 = (nint)obj11 < 0;
								flag8 = obj11 == null;
								num11 = obj17 ^ (object)obj21;
								num12 = obj17 ^ obj11;
								num13 = num11 & num12;
								flag9 = num13 < 0;
								flag14 = obj17 != obj21;
								num20 = num19;
								num17 = num16;
								obj16 = obj15;
								num18 = num15;
								array5 = array6;
								num = num7;
								obj19 = obj21;
								flag16 = flag14;
								if (flag14)
								{
									continue;
								}
								goto IL_0805;
							}
							goto IL_2783;
							IL_0805:
							array = tiles;
							list = (List<System.__Canon>)(num7 + 1);
							bool flag25 = tiles == null;
							object obj22 = !flag25;
							num7 = (int)list;
							if (obj22 != null)
							{
								continue;
							}
							obj18 = 1;
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
							num5 = 0;
							goto IL_265f;
							IL_0876:
							_ = 1;
							array2 = tiles;
							bool flag26 = tiles == null;
							obj21 = obj19;
							num17 = num16;
							obj16 = obj15;
							num18 = num15;
							obj18 = 1;
							array5 = array6;
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ stack_-A0 (System.Array)+18]");
							num5 = 0;
							num4 = num3;
							list = (List<System.__Canon>)num7;
							obj3 = obj6;
							num = num7;
							array = array3;
							num2 = dir;
							if (!flag26)
							{
								nint num22 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v98 (Il2CppClass<Tile[]>)+40]");
								num21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag27 = ex == null;
								obj21 = obj19;
								num17 = num16;
								obj16 = obj15;
								num18 = num15;
								obj18 = 1;
								array5 = array6;
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ stack_-A0 (System.Array)+18]");
								num5 = 0;
								num4 = num3;
								list = (List<System.__Canon>)num7;
								obj3 = obj6;
								num2 = dir;
								if (flag27)
								{
									goto IL_27a8;
								}
								bool flag28 = num7 < array2.Length;
								object obj23 = !flag28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
								num19 = 0;
								num17 = num16;
								obj16 = obj15;
								num18 = num15;
								obj18 = 1;
								array5 = array6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ stack_-A0 (System.Array)+18]");
								num5 = 0;
								num4 = num3;
								list = (List<System.__Canon>)num7;
								obj3 = obj6;
								num2 = dir;
								if (obj23 != null)
								{
									goto IL_2783;
								}
								object obj24 = tiles + num7;
								object obj25 = obj24 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v1420 @ X25_v16 (UnityEngine.Object)*8]");
								obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
								object obj26 = 0;
								object obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ X0_v111+E4]");
								bool flag29 = (nint)0 == 0;
								object obj28 = !flag29;
								if (obj28 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object obj29 = (UnityEngine.Object)(obj19 + 3);
								bool flag30 = (nint)obj19 < 0;
								object obj30 = (object)obj19 ^ (object)obj19;
								object obj31 = (object)obj19 & obj30;
								bool flag31 = (nint)obj31 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
								object obj32 = 0;
								bool flag32 = flag30 == flag31;
								object obj33 = !flag32;
								object obj34 = ~obj33;
								UnityEngine.Object obj35 = ((obj34 != null) ? obj19 : obj29);
								object obj36 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ X0_v113+E4]");
								bool flag33 = (nint)0 == 0;
								object obj37 = !flag33;
								if (obj37 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								array5 = tiles;
								int num23 = num7 + 3;
								bool flag34 = num7 < 0;
								obj10 = !flag34;
								flag7 = num7 < 0;
								flag8 = num7 == 0;
								num12 = num7 ^ num7;
								num13 = num7 & num12;
								flag9 = num13 < 0;
								bool flag35 = flag7 == flag9;
								flag14 = !flag35;
								obj38 = !flag14;
								if (obj38 != null)
								{
									num23 = num7;
								}
								bool flag36 = array5 == null;
								obj21 = obj19;
								num11 = num7;
								obj11 = num7;
								num17 = num16;
								obj16 = obj15;
								num18 = num15;
								obj18 = 1;
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
								num5 = 0;
								num4 = num3;
								list = (List<System.__Canon>)num7;
								obj3 = obj6;
								num = num20;
								array = (Array)num23;
								num2 = dir;
								array2 = (Tile[])(object)obj35;
								if (!flag36)
								{
									num18 = array5.Length;
									bool flag37 = num7 < array5.Length;
									obj10 = !flag37;
									obj11 = num7 - array5.Length;
									flag7 = (nint)obj11 < 0;
									flag8 = obj11 == null;
									num11 = num7 ^ array5.Length;
									num12 = num7 ^ obj11;
									num13 = num11 & num12;
									flag9 = num13 < 0;
									num19 = num20;
									num17 = num16;
									obj16 = obj15;
									obj18 = 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v107 (System.Int32)+18]");
									num5 = 0;
									num4 = num3;
									list = (List<System.__Canon>)num7;
									obj3 = obj6;
									num21 = num20;
									num2 = dir;
									array2 = (Tile[])(object)obj35;
									if (obj10 != null)
									{
										goto IL_2783;
									}
									object obj39 = array5 + num7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1557 @ X9_v47+20]");
									array5 = (Tile[])0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1557 @ X9_v47+20]");
									bool flag38 = (nint)0 == 0;
									obj21 = obj19;
									num17 = num16;
									obj16 = obj15;
									obj18 = 1;
									obj5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v107 (System.Int32)+18]");
									num5 = 0;
									num4 = num3;
									list = (List<System.__Canon>)num7;
									obj3 = obj6;
									num = num20;
									array = (Array)num23;
									num2 = dir;
									array2 = (Tile[])(object)obj35;
									if (!flag38)
									{
										object obj40 = obj35 & 0xFFFFFFFCL;
										num17 = num7 & 3;
										num18 = (object)obj35 >> 2;
										object obj41 = (object)obj19 - obj40;
										num24 = (int)array5[3];
										obj16 = obj41 - num17;
										object obj42 = obj16 * num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
										num25 = (int)((object)array5[3] + obj42);
										array5[3] = (Tile)num25;
										obj21 = obj19;
										num = num20;
										array2 = (Tile[])1;
										goto IL_0805;
									}
								}
							}
							goto IL_265f;
						}
						object obj43 = array2 & 1;
						bool flag39 = obj43 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3F8]");
						object obj44 = 0;
						object obj45 = !flag39;
						obj38 = ~obj45;
						num6 = ((obj38 != null) ? 1129840640 : 1121452032);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3F0]");
						object obj46 = 0;
						num = (int)obj46;
						list3._002Ector();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
						array = (Array)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
						bool flag40 = (nint)0 < (nint)1;
						obj10 = !flag40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
						obj11 = -1;
						flag7 = (nint)obj11 < 0;
						flag8 = obj11 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
						num11 = (int)((nint)0 ^ (nint)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
						num12 = 0 ^ obj11;
						num13 = num11 & num12;
						flag9 = num13 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
						flag14 = (nint)0 < (nint)1;
						num25 = 1129840640;
						obj18 = 1;
						array5 = (Tile[])1121452032;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
						num5 = 0;
						if (flag14)
						{
							goto IL_1d70;
						}
						bool flag41 = obj6 == null;
						num25 = 1129840640;
						num24 = 1121452032;
						obj18 = 1;
						array5 = (Tile[])1121452032;
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
						num5 = 0;
						num4 = num3;
						list = list3;
						obj3 = obj6;
						num2 = dir;
						if (!flag41)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
							object obj47 = 0 & 0xFFFFFFFFL;
							obj9 = obj6 + 32;
							obj18 = num3 + 32;
							int num26 = -dir;
							object obj48 = num6 * num26;
							num19 = num20;
							bool flag42 = flag14;
							int num27 = num18;
							object obj49 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
							nint num28 = 0;
							num21 = (int)obj46;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44 (System.Object)+18]");
								array5 = (Tile[])0;
								object obj50 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44 (System.Object)+18]");
								bool flag43 = (nint)obj50 < 0;
								object obj51 = !flag43;
								num25 = num26;
								num24 = 1121452032;
								obj19 = (UnityEngine.Object)28;
								num18 = num27;
								obj8 = obj49;
								num5 = num28;
								num4 = num3;
								list = list3;
								obj3 = obj6;
								num2 = dir;
								array2 = (Tile[])446676598842L;
								if (obj51 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v358 @ X26_v17]");
								array5 = (Tile[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X28_v11+v358 @ X26_v17]");
								bool flag44 = (nint)0 == 0;
								object obj52 = !flag44;
								if (obj52 != null)
								{
									goto IL_1c4e;
								}
								bool flag45 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47);
								object obj53 = !flag45;
								num25 = num26;
								num24 = 1121452032;
								obj19 = (UnityEngine.Object)28;
								num18 = num27;
								obj8 = obj49;
								num5 = num28;
								num4 = num3;
								list = list3;
								obj3 = obj6;
								num2 = dir;
								array2 = (Tile[])446676598842L;
								if (obj53 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
								object obj54 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
								Tile tile = (Tile)0;
								object obj55 = obj54;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1322 @ X0_v87+E4]");
								bool flag46 = (nint)0 == 0;
								object obj56 = !flag46;
								if (obj56 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag47 = Has(tile);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								array = (Array)0;
								object obj57 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								bool flag48 = (nint)obj57 < 0;
								obj10 = !flag48;
								object obj58 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								obj11 = obj58 - 0;
								flag7 = (nint)obj11 < 0;
								flag8 = obj11 == null;
								object obj59 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								num11 = obj59 ^ 0;
								num12 = obj49 ^ obj11;
								num13 = num11 & num12;
								flag9 = num13 < 0;
								List<System.__Canon> list4;
								int num29;
								System.__Canon _Canon;
								if (flag47)
								{
									num25 = num26;
									num24 = 1121452032;
									num19 = (int)tile;
									obj19 = (UnityEngine.Object)28;
									num18 = num27;
									obj8 = obj49;
									num5 = num28;
									num4 = num3;
									list = list3;
									obj3 = obj6;
									num2 = dir;
									array2 = (Tile[])446676598842L;
									if (obj10 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
									object obj60 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
									tile = (Tile)0;
									object obj61 = obj60;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X0_v97+E4]");
									array = (Array)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X0_v97+E4]");
									bool flag49 = (nint)0 == 0;
									object obj62 = !flag49;
									if (obj62 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag50 = tile == null;
									num25 = num26;
									num24 = 1121452032;
									num20 = (int)tile;
									obj21 = (UnityEngine.Object)28;
									flag14 = flag42;
									num18 = num27;
									obj8 = obj49;
									obj5 = 0;
									num5 = num28;
									num4 = num3;
									list = list3;
									obj3 = obj6;
									num = num21;
									num2 = dir;
									array2 = (Tile[])446676598842L;
									if (!flag50)
									{
										object obj63 = obj49 >> 2;
										object obj64 = obj63 & 0x3FFFFFFF;
										object obj65 = obj49 & 3;
										num18 = obj65 << 6;
										object obj66 = obj64 * 108;
										object obj67 = 28 + obj66;
										array5 = (Tile[])(num18 - obj65);
										object obj68 = (object)array5 | obj67;
										RectInt place = (RectInt)(obj68 + 132);
										tile.place = place;
										_ = 446676598842L;
										object obj69 = obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
										bool flag51 = (nint)obj69 < 0;
										obj10 = !flag51;
										object obj70 = obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
										obj11 = obj70 - 0;
										flag7 = (nint)obj11 < 0;
										flag8 = obj11 == null;
										object obj71 = obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
										num11 = obj71 ^ 0;
										num12 = obj49 ^ obj11;
										num13 = num11 & num12;
										flag9 = num13 < 0;
										num25 = num26;
										num24 = 1121452032;
										num19 = (int)tile;
										obj19 = (UnityEngine.Object)28;
										object obj16 = 108;
										obj8 = obj49;
										num5 = num28;
										num4 = num3;
										list = list3;
										obj3 = obj6;
										num2 = dir;
										array2 = (Tile[])446676598842L;
										if (obj10 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
										array = (Array)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
										bool flag52 = (nint)0 == 0;
										num25 = num26;
										num24 = 1121452032;
										num20 = (int)tile;
										obj21 = (UnityEngine.Object)28;
										flag14 = flag42;
										obj16 = 108;
										obj8 = obj49;
										obj5 = 0;
										num5 = num28;
										num4 = num3;
										list = list3;
										obj3 = obj6;
										num = num21;
										num2 = dir;
										array2 = (Tile[])446676598842L;
										if (!flag52)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
											array = (Array)0;
											object obj72 = obj49;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
											bool flag53 = (nint)obj72 < 0;
											obj10 = !flag53;
											object obj73 = obj49;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
											obj11 = obj73 - 0;
											flag7 = (nint)obj11 < 0;
											flag8 = obj11 == null;
											object obj74 = obj49;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
											num11 = obj74 ^ 0;
											num12 = obj49 ^ obj11;
											num13 = num11 & num12;
											flag9 = num13 < 0;
											num25 = num26;
											num24 = 1121452032;
											num19 = (int)tile;
											obj19 = (UnityEngine.Object)28;
											obj16 = 108;
											obj8 = obj49;
											num5 = num28;
											num4 = num3;
											list = list3;
											obj3 = obj6;
											num2 = dir;
											array2 = (Tile[])446676598842L;
											if (obj10 != null)
											{
												break;
											}
											list4 = (List<System.__Canon>)(object)leaving;
											bool flag54 = leaving == null;
											num25 = num26;
											num24 = 1121452032;
											num20 = (int)tile;
											obj21 = (UnityEngine.Object)28;
											flag14 = flag42;
											obj16 = 108;
											obj8 = obj49;
											obj5 = 0;
											num5 = num28;
											num4 = num3;
											list = list3;
											obj3 = obj6;
											num = num21;
											num2 = dir;
											array2 = (Tile[])446676598842L;
											if (!flag54)
											{
												array = list4._items;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
												num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3E0]");
												object obj75 = 0;
												num18 = list4._version + 1;
												array5 = (Tile[])obj75;
												list4._version = num18;
												bool flag55 = list4._items == null;
												num25 = num26;
												num24 = 1121452032;
												num20 = (int)tile;
												obj21 = (UnityEngine.Object)28;
												flag14 = flag42;
												obj16 = 108;
												obj8 = obj49;
												obj5 = 0;
												num5 = num28;
												num4 = num3;
												list = list3;
												obj3 = obj6;
												num2 = dir;
												array2 = (Tile[])446676598842L;
												if (!flag55)
												{
													num27 = list4._size;
													int size = list4._size;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
													bool flag56 = (nint)size < (nint)0;
													object obj76 = !flag56;
													if (obj76 == null)
													{
														object obj77 = list4._items + list4._size;
														num29 = ++list4._size;
														object obj78 = obj77 + 32;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
														obj78 = 0;
														object obj79 = obj78;
														goto IL_2c9b;
													}
													Tile tile2 = array5[0];
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
													_Canon = (System.__Canon)0;
													goto IL_2cc2;
												}
											}
										}
									}
								}
								else
								{
									num25 = num26;
									num24 = 1121452032;
									num19 = (int)tile;
									obj19 = (UnityEngine.Object)28;
									num18 = num27;
									obj8 = obj49;
									num5 = num28;
									num4 = num3;
									list = list3;
									obj3 = obj6;
									num2 = dir;
									array2 = (Tile[])446676598842L;
									if (obj10 != null)
									{
										break;
									}
									bool flag57 = list3 == null;
									num25 = num26;
									num24 = 1121452032;
									num20 = (int)tile;
									obj21 = (UnityEngine.Object)28;
									flag14 = flag42;
									num18 = num27;
									obj8 = obj49;
									obj5 = 0;
									num5 = num28;
									num4 = num3;
									list = list3;
									obj3 = obj6;
									num = num21;
									num2 = dir;
									array2 = (Tile[])446676598842L;
									if (!flag57)
									{
										array = list3._items;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3E0]");
										object obj80 = 0;
										num18 = list3._version + 1;
										array5 = (Tile[])obj80;
										list3._version = num18;
										bool flag58 = list3._items == null;
										num25 = num26;
										num24 = 1121452032;
										num20 = (int)tile;
										obj21 = (UnityEngine.Object)28;
										flag14 = flag42;
										obj8 = obj49;
										obj5 = 0;
										num5 = num28;
										num4 = num3;
										list = list3;
										obj3 = obj6;
										num2 = dir;
										array2 = (Tile[])446676598842L;
										if (!flag58)
										{
											num27 = list3._size;
											int size2 = list3._size;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v26 (System.Array)+18]");
											bool flag59 = (nint)size2 < (nint)0;
											object obj81 = !flag59;
											if (obj81 == null)
											{
												object obj82 = list3._items + list3._size;
												num29 = ++list3._size;
												object obj79 = obj82 + 32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
												obj79 = 0;
												goto IL_2c9b;
											}
											Tile tile2 = array5[0];
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X29_v6+v358 @ X26_v17*8]");
											_Canon = (System.__Canon)0;
											list4 = list3;
											goto IL_2cc2;
										}
									}
								}
								goto IL_265f;
								IL_1c4e:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								obj47 = 0;
								obj8 = obj49 + 1;
								object obj83 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								bool flag60 = (nint)obj83 < 0;
								obj10 = !flag60;
								object obj84 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								obj11 = obj84 - 0;
								flag7 = (nint)obj11 < 0;
								flag8 = obj11 == null;
								object obj85 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								num11 = obj85 ^ 0;
								num12 = obj8 ^ obj11;
								num13 = num11 & num12;
								flag9 = num13 < 0;
								object obj86 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v42 (System.Int32)+18]");
								flag14 = (nint)obj86 < 0;
								num25 = num26;
								num20 = num19;
								obj21 = (UnityEngine.Object)28;
								num18 = num27;
								num5 = num28;
								num = num21;
								array2 = (Tile[])446676598842L;
								flag42 = flag14;
								obj49 = obj8;
								if (flag14)
								{
									continue;
								}
								goto IL_1d70;
								IL_2cc2:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v74 (CosmeticTerminal+Tile)+A8]");
								object obj87 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ X8_v75+70]");
								num28 = 0;
								list4.AddWithResize(_Canon);
								num19 = (int)tile;
								num21 = (int)_Canon;
								goto IL_1c4e;
								IL_2c9b:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								num19 = (int)tile;
								array5 = (Tile[])num29;
								num21 = num;
								goto IL_1c4e;
							}
							goto IL_2783;
						}
					}
				}
			}
		}
		goto IL_265f;
		IL_27a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Enumerator<, > val2 = default;
		val = (Enumerator<, >)(ref val2);
		throw new ArgumentNullException();
		IL_2783:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		obj5 = 0;
		goto IL_279a;
		IL_1d70:
		array = tiles;
		bool flag61 = tiles == null;
		num24 = 1121452032;
		obj5 = 0;
		num4 = num3;
		list = list3;
		obj3 = obj6;
		num2 = dir;
		if (flag61)
		{
			goto IL_265f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		array2 = (Tile[])0;
		num6 *= dir;
		int num30 = dir;
		int num31 = 1121452032;
		num19 = num20;
		obj19 = obj21;
		object obj88 = 32;
		nint num32 = num5;
		int num33 = 0;
		object obj89 = obj6;
		num21 = num;
		Array array7 = tiles;
		int num34 = dir;
		object obj97 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			Tile[] array5 = (Tile[])0;
			int num35 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			bool flag62 = (nint)num35 < (nint)0;
			object obj10 = !flag62;
			int num36 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			object obj11 = (nint)num36 - (nint)0;
			bool flag7 = (nint)obj11 < 0;
			bool flag8 = obj11 == null;
			int num37 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			int num11 = (int)((nint)num37 ^ (nint)0);
			int num12 = num33 ^ obj11;
			int num13 = num11 & num12;
			bool flag9 = num13 < 0;
			int num38 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			bool flag14 = (nint)num38 >= (nint)0;
			int num25 = num30;
			num24 = num31;
			num20 = num19;
			obj21 = obj19;
			object obj18 = 1065353216;
			object obj9 = 109891584;
			object obj8 = obj88;
			obj5 = 0;
			num5 = num32;
			num4 = num33;
			list = list3;
			obj3 = obj89;
			num = num21;
			array = array7;
			num2 = num34;
			if (flag14)
			{
				break;
			}
			int num39 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			bool flag63 = (nint)num39 < (nint)0;
			obj10 = !flag63;
			int num40 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			obj11 = (nint)num40 - (nint)0;
			flag7 = (nint)obj11 < 0;
			flag8 = obj11 == null;
			int num41 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38 (System.Array)+18]");
			num11 = (int)((nint)num41 ^ (nint)0);
			num12 = num33 ^ obj11;
			num13 = num11 & num12;
			flag9 = num13 < 0;
			num25 = num30;
			num24 = num31;
			obj18 = 1065353216;
			obj9 = 109891584;
			obj8 = obj88;
			num5 = num32;
			num4 = num33;
			list = list3;
			obj3 = obj89;
			num2 = num34;
			if (obj10 != null)
			{
				goto IL_2783;
			}
			object obj90 = array7 + num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1316 @ X9_v19+20]");
			array5 = (Tile[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1316 @ X9_v19+20]");
			bool flag64 = (nint)0 == 0;
			object obj91 = !flag64;
			if (obj91 == null)
			{
				bool flag65 = list3 == null;
				num25 = num30;
				num24 = num31;
				num20 = num19;
				obj21 = obj19;
				obj18 = 1065353216;
				obj9 = 109891584;
				obj8 = obj88;
				obj5 = 0;
				num5 = num32;
				num4 = num33;
				list = list3;
				obj3 = obj89;
				num = num21;
				array = array7;
				num2 = num34;
				if (!flag65)
				{
					int index = list3._size - 1;
					bool flag66 = list3._size < 1;
					obj10 = !flag66;
					obj11 = list3._size - 1;
					flag7 = (nint)obj11 < 0;
					flag8 = obj11 == null;
					num11 = list3._size ^ 1;
					num12 = list3._size ^ obj11;
					num13 = num11 & num12;
					flag9 = num13 < 0;
					if (list3._size >= 1)
					{
						System.__Canon _Canon2 = list3.get_Item(index);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2B8]");
						array5 = (Tile[])0;
						int index2 = list3._size - 1;
						num32 = (nint)array5;
						list3.RemoveAt(index2);
						obj3 = _Canon2;
					}
					else
					{
						Tile tile3 = MakeTile(num33);
						obj3 = tile3;
					}
					(byte, int, int, int, int) tuple2 = Wanted(num33);
					bool flag67 = obj3 == null;
					num25 = num30;
					num24 = num31;
					num20 = num19;
					obj21 = obj19;
					obj18 = 1065353216;
					obj9 = 109891584;
					obj8 = obj88;
					obj5 = 0;
					num5 = num32;
					num4 = num33;
					list = list3;
					num = num33;
					array = (Array)(&array3);
					num2 = num34;
					if (!flag67)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X22_v3 (System.Object)+20]");
						bool flag68 = 0 < (nint)array3;
						object obj92 = !flag68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X22_v3 (System.Object)+20]");
						object obj93 = 0 - array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X22_v3 (System.Object)+20]");
						int num42 = 0 ^ array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X22_v3 (System.Object)+20]");
						int num43 = 0 ^ obj93;
						int num44 = num42 & num43;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X22_v3 (System.Object)+20]");
						bool flag69 = 0 != (nint)array3;
						int num45;
						if (!flag69)
						{
							object obj94 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X22_v3 (System.Object)+18]");
							obj19 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v75+E4]");
							bool flag70 = (nint)0 == 0;
							object obj95 = !flag70;
							if (obj95 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag71 = obj19 != null;
							bool flag72 = !flag71;
							object obj96 = !flag72;
							num30 = (int)array6;
							num34 = (int)array6;
							if (obj96 == null)
							{
								bool flag73 = (nint)obj97 < 1;
								obj92 = !flag73;
								obj93 = obj97 - 1;
								num42 = obj97 ^ 1;
								num43 = obj97 ^ obj93;
								num44 = num42 & num43;
								flag69 = (nint)obj97 < 1;
								num30 = (int)array6;
								num34 = (int)array6;
								num45 = (int)array6;
								obj21 = obj19;
								flag14 = flag69;
								num13 = num44;
								num12 = num43;
								num11 = num42;
								obj11 = obj93;
								obj10 = obj92;
								num5 = unchecked((nint)null);
								num = 0;
								num2 = (int)array6;
								if (flag69)
								{
									goto IL_23e2;
								}
							}
						}
						Fill((Tile)obj3, (byte)(int)array3);
						num45 = num30;
						obj21 = obj19;
						flag14 = flag69;
						num13 = num44;
						num12 = num43;
						num11 = num42;
						obj11 = obj93;
						obj10 = obj92;
						num5 = (nint)array3;
						num = (int)obj3;
						num2 = num34;
						goto IL_23e2;
					}
				}
				goto IL_265f;
			}
			goto IL_2da2;
			IL_23e2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
			object obj98 = 0;
			_ = 1065353216;
			object obj99 = obj98;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1485 @ X0_v58+E4]");
			bool flag74 = (nint)0 == 0;
			object obj100 = !flag74;
			if (obj100 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Has((Tile)obj3))
			{
				_ = 0;
			}
			else
			{
				nint num46 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ X8_v56 (Il2CppClass<Tile[]>)+A0]");
				object obj101 = 0;
			}
			nint num47 = (nint)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v49 (Il2CppClass<Tile[]>)+A0]");
			array = (Array)0;
			num25 = (int)array;
			num20 = (int)tiles;
			bool flag75 = tiles == null;
			num24 = (int)array6;
			obj18 = 1065353216;
			obj9 = 109891584;
			obj8 = obj88;
			obj5 = 0;
			num4 = num33;
			list = list3;
			if (flag75)
			{
				goto IL_265f;
			}
			int value = ((int*)num20)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v51 (System.Int32)+40]");
			num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag76 = ex == null;
			num24 = (int)array6;
			obj18 = 1065353216;
			obj9 = 109891584;
			obj8 = obj88;
			obj5 = 0;
			num4 = num33;
			list = list3;
			if (flag76)
			{
				goto IL_27a8;
			}
			int num48 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+18]");
			bool flag77 = (nint)num48 < (nint)0;
			obj10 = !flag77;
			int num49 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+18]");
			obj11 = (nint)num49 - (nint)0;
			flag7 = (nint)obj11 < 0;
			flag8 = obj11 == null;
			int num50 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X24_v12 (System.Int32)+18]");
			num11 = (int)((nint)num50 ^ (nint)0);
			num12 = num33 ^ obj11;
			num13 = num11 & num12;
			flag9 = num13 < 0;
			num24 = (int)array6;
			num19 = (int)tiles;
			obj19 = obj21;
			obj18 = 1065353216;
			obj9 = 109891584;
			obj8 = obj88;
			num4 = num33;
			list = list3;
			if (obj10 != null)
			{
				goto IL_2783;
			}
			object obj102 = tiles + num33;
			object obj103 = (object)tiles + obj88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			array7 = tiles;
			num30 = (int)array;
			num31 = (int)array6;
			num19 = (int)tiles;
			obj19 = obj21;
			num32 = num5;
			obj89 = obj3;
			num21 = (int)obj3;
			num34 = num2;
			goto IL_2da2;
			IL_2da2:
			num4 = num33 + 1;
			obj8 = obj88 + 8;
			bool flag78 = array7 == null;
			object obj104 = !flag78;
			num25 = num30;
			num24 = num31;
			num20 = num19;
			obj21 = obj19;
			obj18 = 1065353216;
			obj9 = 109891584;
			obj5 = 0;
			num5 = num32;
			list = list3;
			obj3 = obj89;
			num = num21;
			array = array7;
			num2 = num34;
			obj88 = obj8;
			num33 = num4;
			if (obj104 != null)
			{
				continue;
			}
			goto IL_265f;
		}
		goto IL_266d;
		IL_266d:
		if (list == null)
		{
			goto IL_265f;
		}
		Enumerator<, > enumerator = list.GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3D0]");
		array2 = (Tile[])0;
		num21 = (int)array2;
		if (val2.MoveNext())
		{
			object obj105 = 0;
			num16 = 0;
			num15 = 0;
			goto IL_279a;
		}
		num16 = 0;
		num15 = 0;
		val = (Enumerator<, >)(ref val2);
		int num51 = 0;
		object obj109 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3C8]");
			object obj106 = 0;
			List<System.__Canon> list2 = (List<System.__Canon>)obj106;
			((Enumerator<, >*)val)->Dispose();
			bool flag79 = num51 == 0;
			object obj107 = !flag79;
			if (obj107 == null)
			{
				bool flag80 = num16 == 0;
				object obj108 = !flag80;
				OutOfMemoryException ex3 = (OutOfMemoryException)val;
				if (obj108 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)list2 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num16 = 1;
				num51 = num15;
				continue;
			}
			if ((nint)list2 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			num51 = (int)obj109;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num15 = (int)obj109;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0518");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_279a:
		ex = new NullReferenceException();
		goto IL_27a8;
		IL_265f:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_266d;
	}

	private int MaxScroll()
	{
		//IL_00cc: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected I4, but got Unknown
		List<byte> list = shown;
		if (shown != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
			object obj = (nint)0 + (nint)3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
			object obj2 = (nint)0 + (nint)6;
			bool flag = (nint)obj < 0;
			object obj3 = obj ^ obj;
			object obj4 = obj & obj3;
			bool flag2 = (nint)obj4 < 0;
			bool flag3 = flag == flag2;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			if (obj6 != null)
			{
				obj2 = obj;
			}
			object obj7 = obj2 >> 2;
			object obj8 = obj7 - 2;
			bool flag4 = (nint)obj8 < 0;
			bool flag5 = obj8 == null;
			object obj9 = obj7 ^ 2;
			object obj10 = obj7 ^ obj8;
			object obj11 = obj9 & obj10;
			bool flag6 = (nint)obj11 < 0;
			bool flag7 = flag4 == flag6;
			object obj12 = !flag5;
			object obj13 = flag7 & obj12;
			object obj14 = ~obj13;
			if (obj14 != null)
			{
				obj7 = 2;
			}
			return obj7 - 2;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private static bool Has(Tile t)
	{
		//IL_0155: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_008e: Expected I4, but got I8
		//IL_00a8: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected I4, but got Unknown
		if (t != null)
		{
			bool flag = t.id == 0;
			object obj = !flag;
			if (obj == null)
			{
				bool flag2 = t.title == 0;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					int num = (int)(t.outfit & 0x80000000L);
					bool flag3 = num == 0;
					object obj3 = !flag3;
					if (obj3 != null)
					{
						bool flag4 = t.monster < 0;
						bool flag5 = t.monster == 0;
						int num2 = t.monster ^ t.monster;
						int num3 = t.monster & num2;
						bool flag6 = num3 < 0;
						bool flag7 = flag4 == flag6;
						object obj4 = !flag5;
						return (byte)((flag7 & obj4) ? 1 : 0) != 0;
					}
				}
			}
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private Tile MakeTile(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I4
		//IL_0249: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF290]");
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
		if (tile != null)
		{
			object obj4 = tile + 16;
			obj4 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (obj4 != null)
			{
				Transform transform = ((GameObject)obj4).transform;
				if ((object)transform != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
					object obj6 = 0;
					transform.SetParent(tileRoot, worldPositionStays: false);
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v16+E4]");
					bool flag = (nint)0 == 0;
					object obj8 = !flag;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj9 = obj6;
					bool flag2 = num < 0;
					int num2 = num ^ num;
					int num3 = num & num2;
					bool flag3 = num3 < 0;
					bool flag4 = flag2 == flag3;
					object obj10 = !flag4;
					object obj11 = ~obj10;
					if (obj11 == null)
					{
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v18+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj4 != null)
					{
						Transform transform2 = ((GameObject)obj4).transform;
						Vector2 size = Size;
						if ((object)transform2 != null)
						{
							transform2.localPosition = (Vector3)0;
							if (obj4 != null)
							{
								((GameObject)obj4).SetActive(false);
								return tile;
							}
						}
					}
				}
			}
		}
		return (Tile)(object)new NullReferenceException();
	}

	private void Fill(Tile t, byte id)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I
		//IL_0466: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I4
		//IL_04dd: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I
		//IL_1343: Expected Obj, but got I
		//IL_135b: Expected Obj, but got I
		//IL_136b: Expected Obj, but got I
		//IL_1383: Expected F8, but got I
		//IL_02a5: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I
		//IL_0337: Expected I4, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_0359: Expected VT, but got I4
		//IL_1261: Expected Obj, but got I
		//IL_127b: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I4
		//IL_0587: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I
		//IL_0747: Expected Obj, but got I
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_060f: Expected Obj, but got I4
		//IL_13c3: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I4
		//IL_07cc: Expected Obj, but got I
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Obj, but got Unknown
		//IL_064a: Expected Obj, but got I
		//IL_06a9: Expected Obj, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_0862: Expected Obj, but got I8
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0f58: Invalid comparison between F8 and I4
		//IL_0f67: Invalid comparison between F8 and I4
		//IL_0f7a: Expected Obj, but got F8
		//IL_0f87: Expected Obj, but got F8
		//IL_0fbc: Expected Obj, but got I4
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected Obj, but got Unknown
		//IL_0906: Expected Obj, but got I4
		//IL_13da: Unknown result type (might be due to invalid IL or missing references)
		//IL_13df: Expected Obj, but got Unknown
		//IL_13f7: Invalid comparison between F8 and I4
		//IL_1406: Invalid comparison between F8 and I4
		//IL_1414: Unknown result type (might be due to invalid IL or missing references)
		//IL_1419: Expected Obj, but got Unknown
		//IL_1421: Unknown result type (might be due to invalid IL or missing references)
		//IL_1426: Expected Obj, but got Unknown
		//IL_145b: Expected Obj, but got I4
		//IL_1463: Unknown result type (might be due to invalid IL or missing references)
		//IL_1468: Expected Obj, but got Unknown
		//IL_1224: Unknown result type (might be due to invalid IL or missing references)
		//IL_1229: Expected Obj, but got Unknown
		//IL_0893: Expected F8, but got Obj
		//IL_10db: Invalid comparison between F8 and I4
		//IL_10ea: Invalid comparison between F8 and I4
		//IL_10fd: Expected Obj, but got F8
		//IL_110a: Expected Obj, but got F8
		//IL_113f: Expected Obj, but got I4
		//IL_1147: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected Obj, but got Unknown
		//IL_0d1f: Expected VT, but got I4
		//IL_1205: Expected VT, but got F8
		//IL_0d4e: Expected Obj, but got I
		//IL_0d73: Expected VT, but got I4
		//IL_0c4f: Expected Obj, but got F8
		//IL_0c58: Expected Obj, but got F8
		//IL_0c61: Expected Obj, but got F8
		//IL_0dc4: Expected Obj, but got F8
		//IL_0de1: Expected VT, but got I4
		//IL_0e1d: Expected Obj, but got I
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Expected Obj, but got Unknown
		//IL_0e59: Expected Obj, but got I4
		//IL_1325: Expected Obj, but got I4
		//IL_0e99: Expected Obj, but got I
		//IL_0ea9: Expected Obj, but got I
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Expected Obj, but got Unknown
		CosmeticCatalog.Entry entry;
		double num = default;
		double num2 = default;
		double num3 = default;
		GameObject gameObject2;
		object obj2;
		if (t != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			obj2 = t + 24;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj2 != null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v117+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy((UnityEngine.Object)obj2);
			}
			t.model = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (t.monster >= 1)
			{
				FillMonster(t);
				return;
			}
			int id2 = id & 0xFF;
			entry = CosmeticCatalog.Of(id2);
			if (entry == null)
			{
				return;
			}
			if (entry.slot == (CosmeticSlot)2)
			{
				GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)0);
				if ((object)gameObject != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v68+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj10 = default;
					UnityEngine.Object.Destroy(obj10);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF418]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					Renderer renderer = default;
					if ((object)renderer != null)
					{
						renderer.sharedMaterial = wire;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						MaterialPropertyBlock materialPropertyBlock = default;
						materialPropertyBlock._002Ector();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
						object obj13 = 0;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X0_v108+E4]");
						bool flag4 = (nint)0 == 0;
						object obj15 = !flag4;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (materialPropertyBlock != null)
						{
							object obj16 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v74+A0]");
							object obj17 = 0;
							materialPropertyBlock.SetTexture((int)obj17, entry.eyeTexture);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
							object obj18 = 0;
							materialPropertyBlock.SetColor((string)obj18, (Color)0);
							renderer.SetPropertyBlock(materialPropertyBlock);
							num = 1.0;
							num2 = 1.0;
							num3 = 1.0;
							double num4 = 1.0;
							object obj19 = 0;
							gameObject2 = gameObject;
							goto IL_1333;
						}
					}
				}
			}
			else
			{
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v86+E4]");
				bool flag5 = (nint)0 == 0;
				object obj21 = !flag5;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(entry.prefab != null))
				{
					return;
				}
				GameObject gameObject3 = CosmeticCatalog.Display(entry);
				if ((object)gameObject3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF410]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v64+E4]");
					bool flag6 = (nint)0 == 0;
					object obj24 = !flag6;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj25 = default;
					bool flag7 = obj25 != null;
					bool flag8 = !flag7;
					object obj19 = 0;
					gameObject2 = gameObject3;
					if (!flag8)
					{
						if ((object)obj25 == null)
						{
							goto IL_0f09;
						}
						_ = 1131413504;
						obj19 = 0;
						gameObject2 = gameObject3;
					}
					goto IL_1333;
				}
			}
		}
		goto IL_0f09;
		IL_12c4:
		Transform transform;
		object obj27;
		double num6;
		double num9;
		if ((object)transform != null)
		{
			transform.localRotation = (Quaternion)0;
			Transform transform2 = gameObject2.transform;
			if ((object)transform2 != null)
			{
				object obj26 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X8_v26+A0]");
				object obj28 = 0;
				double num5 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v27+C]");
				double num7 = num5 * 0.0;
				transform2.localScale = (Vector3)0;
				Transform transform3 = gameObject2.transform;
				if ((object)transform3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					double num8 = num9 * num6;
					object obj29 = 0.0 - num8;
					object obj30 = default;
					double num10 = num7 * (double)obj30;
					transform3.localPosition = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
					object obj31 = default;
					if (obj31 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v41+18]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v41+18]");
						if ((nint)0 < (nint)1)
						{
							goto IL_0ee4;
						}
						object obj33 = obj31 + 32;
						object obj34 = 0;
						while (true)
						{
							bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
							object obj35 = !flag9;
							if (obj35 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X23_v11+v457 @ X21_v10*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X23_v11+v457 @ X21_v10*8]");
								((Renderer)0).shadowCastingMode = (ShadowCastingMode)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v41+18]");
								obj32 = 0;
								obj34++;
								object obj36 = obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v41+18]");
								bool flag10 = (nint)obj36 < 0;
								bool flag11 = false;
								if (flag10)
								{
									continue;
								}
								goto IL_0ee4;
							}
							goto IL_0f09;
						}
						goto IL_0f17;
					}
				}
			}
		}
		goto IL_0f09;
		IL_0f09:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0f17;
		IL_0ee4:
		Transform transform4;
		GameObject gameObject4 = transform4.gameObject;
		obj2 = gameObject4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return;
		IL_1333:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		obj27 = 0;
		object obj37 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v13+A0]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C30]");
		object obj39 = 0;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v14+8]");
		num9 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
		object obj41 = default;
		double num11;
		double num13;
		double num15;
		Quaternion rotation = default;
		if (obj41 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+18]");
			if ((nint)0 == 0)
			{
				num6 = 1.0;
				num11 = 1.0;
				goto IL_1251;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+20]");
				Bounds bounds = ((Renderer)0).bounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+18]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+18]");
				bool flag12 = (nint)0 < (nint)1;
				double num12 = default;
				num = num12;
				double num14 = default;
				num13 = num14;
				double num16 = default;
				num15 = num16;
				if (flag12)
				{
					goto IL_0737;
				}
				object obj43 = obj41 + 32;
				double num17 = num12;
				double num18 = num14;
				Quaternion quaternion = rotation;
				double num19 = num16;
				object obj44 = 0;
				object obj52 = default;
				while (true)
				{
					bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
					object obj45 = !flag13;
					if (obj45 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X28_v7+v271 @ X27_v8*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X28_v7+v271 @ X27_v8*8]");
						Bounds bounds2 = ((Renderer)0).bounds;
						double num20 = num19 - num18;
						double num21 = num18 + num19;
						double num22 = num16 - num14;
						double num23 = num16 + num14;
						double num24 = (double)rotation + num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+18]");
						obj42 = 0;
						double num25 = (double)quaternion - num17;
						obj44++;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						if (!(num20 < num22))
						{
							num20 = num22;
						}
						double num26 = num21 - num22;
						bool flag14 = num26 < 0.0;
						bool flag15 = num26 == 0.0;
						object obj46 = num21 ^ num22;
						object obj47 = num21 ^ num26;
						object obj48 = obj46 & obj47;
						bool flag16 = (nint)obj48 < 0;
						bool flag17 = flag14 == flag16;
						object obj49 = !flag15;
						object obj50 = flag17 & obj49;
						object obj51 = ~obj50;
						if (obj51 == null)
						{
							num22 = num21;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						double num27 = num22 - num20;
						double num28 = (double)obj52 - num25;
						double num29 = num27 * 0.5;
						double num30 = num28 * 63.0;
						double num31 = num20 + num29;
						double num32 = num25 + num30;
						num3 = num31 - num29;
						double num33 = num29 + num31;
						double num34 = num32 - num30;
						double num35 = num30 + num32;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						if (!(num3 < num23))
						{
							num3 = num23;
						}
						double num36 = num33 - num23;
						bool flag18 = num36 < 0.0;
						bool flag19 = num36 == 0.0;
						object obj53 = num33 ^ num23;
						object obj54 = num33 ^ num36;
						object obj55 = obj53 & obj54;
						bool flag20 = (nint)obj55 < 0;
						bool flag21 = flag18 == flag20;
						object obj56 = !flag19;
						object obj57 = flag21 & obj56;
						object obj58 = ~obj57;
						if (obj58 == null)
						{
							num23 = num33;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						double num4 = num23 - num3;
						double num37 = num30 - num31;
						num13 = num4 * 0.5;
						num = num37 * 63.0;
						num15 = num3 + num13;
						double num38 = num31 + num;
						bool flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
						num2 = num31;
						num17 = num;
						num18 = num13;
						quaternion = (Quaternion)num38;
						num19 = num15;
						if (flag22)
						{
							continue;
						}
						goto IL_0737;
					}
					goto IL_0f09;
				}
				goto IL_0f17;
			}
		}
		goto IL_0f09;
		IL_1251:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
		object obj60 = 0;
		GameObject gameObject5 = default;
		gameObject5._002Ector((string)obj60);
		if ((object)gameObject5 != null)
		{
			transform4 = gameObject5.transform;
			if ((object)t.root != null)
			{
				Transform parent = t.root.transform;
				if ((object)transform4 != null)
				{
					transform4.SetParent(parent, worldPositionStays: false);
					Transform transform5 = gameObject2.transform;
					if ((object)transform5 != null)
					{
						transform5.SetParent(transform4, worldPositionStays: false);
						transform = gameObject2.transform;
						if (entry.slot != (CosmeticSlot)2)
						{
							bool flag11 = false;
							goto IL_12c4;
						}
						Quaternion rotation2 = transform4.rotation;
						Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation);
						if ((object)tileRoot != null)
						{
							Vector3 up = tileRoot.up;
							Vector3 axis = default;
							Quaternion quaternion3 = Quaternion.Internal_AngleAxis(entry.eyeTurn, ref axis);
							if ((object)tileRoot != null)
							{
								double num39 = num * (double)entry.eyeTurn;
								double num40 = num11 * num;
								double num41 = num * num3;
								double num42 = num3 * num;
								double num43 = num * num2;
								double num44 = num2 * num;
								double num45 = num * num;
								double num46 = num11 * (double)entry.eyeTurn;
								double num47 = num39 + num40;
								double num48 = num3 * num2;
								double num49 = num2 * num3;
								double num50 = num41 + num42;
								double num51 = num2 * (double)entry.eyeTurn;
								double num52 = num11 * num2;
								double num53 = num43 + num44;
								double num54 = num11 * num3;
								double num55 = num3 * (double)entry.eyeTurn;
								double num56 = num45 - num46;
								double num57 = num3 * num3;
								double num58 = num48 + num47;
								double num59 = num51 + num50;
								double num60 = num2 * num2;
								double num61 = num54 + num53;
								double num62 = num56 - num57;
								double num63 = num58 - num49;
								double num64 = num59 - num52;
								double num65 = num61 - num55;
								double num66 = num62 - num60;
								Vector3 forward = tileRoot.forward;
								object obj61 = 0.0 - num58;
								object obj62 = 0.0 - num59;
								object obj63 = 0.0 - num60;
								Vector3 toDirection = default;
								Quaternion quaternion4 = Quaternion.Internal_FromToRotation(ref axis, ref toDirection);
								double num67 = num66 * (double)obj62;
								double num68 = num64 * num61;
								double num69 = num66 * (double)obj63;
								double num70 = num65 * num61;
								double num35 = num67 + num68;
								double num30 = num65 * (double)obj61;
								double num71 = num69 + num70;
								double num72 = num63 * (double)obj62;
								double num34 = num72 + num71;
								bool flag11 = false;
								goto IL_12c4;
							}
						}
					}
				}
			}
		}
		goto IL_0f09;
		IL_0737:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj65 = default;
		if (obj65 != null)
		{
			double num73 = num + num;
			object obj67 = default;
			object obj66 = obj67 + obj67;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v76+18]");
			bool flag23 = (nint)0 < (nint)2;
			object obj68 = !flag23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v76+18]");
			object obj69 = -2;
			bool flag24 = obj69 == null;
			object obj70 = ~obj68;
			object obj71 = obj70 | flag24;
			if (obj71 != null)
			{
				goto IL_0f17;
			}
			double num74 = num13 + num13;
			_ = 1008981770;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v76+18]");
			if ((nint)0 >= (nint)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v76+18]");
				object obj72 = 0 & 0xFFFFFFFFL;
				object obj73 = obj65 + 36;
				object obj74 = obj72 - 1;
				double num75 = num73;
				bool flag29;
				do
				{
					obj73 += 4;
					double num76 = (double)obj73 - num75;
					bool flag25 = num76 < 0.0;
					bool flag26 = num76 == 0.0;
					object obj75 = obj73 ^ num75;
					object obj76 = obj73 ^ num76;
					object obj77 = obj75 & obj76;
					bool flag27 = (nint)obj77 < 0;
					bool flag28 = flag25 == flag27;
					object obj78 = !flag26;
					object obj79 = flag28 & obj78;
					object obj80 = ~obj79;
					if (obj80 == null)
					{
						num75 = (double)obj73;
					}
					obj74--;
					flag29 = (nint)obj74 != 1;
					num73 = num75;
				}
				while (flag29);
			}
			Transform transform6 = gameObject2.transform;
			if ((object)transform6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				num11 = 0.0 / num73;
				Vector3 position = transform6.position;
				num9 = num15 - num2;
				num6 = num11;
				obj40 = 0;
				goto IL_1251;
			}
		}
		goto IL_0f09;
		IL_0f17:
		throw new IndexOutOfRangeException();
	}

	private void FillMonster(Tile t)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I8
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_077c: Expected Obj, but got I4
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Obj, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I
		//IL_0679: Expected VT, but got I4
		//IL_03ca: Expected VT, but got I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_0404: Expected VT, but got I4
		//IL_046b: Unsupported input type for neg.
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0481: Unsupported input type for neg.
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0497: Unsupported input type for neg.
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04aa: Expected VT, but got I4
		//IL_04ba: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_053b: Expected Obj, but got I4
		//IL_06de: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got I
		//IL_058b: Expected Obj, but got I
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		Transform transform2;
		if (t != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			MonsterDirector.Entry e = MonsterCatalog.Of(t.monster);
			MonsterDisplay monsterDisplay = MonsterDisplay.Make(e, showOff: false);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = monsterDisplay == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			if ((object)monsterDisplay != null)
			{
				GameObject gameObject = monsterDisplay.gameObject;
				Bounds bounds = MonsterDisplay.Posed(gameObject);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj6 = default;
				if (obj6 != null)
				{
					object obj8 = default;
					object obj7 = obj8 + obj8;
					object obj10 = default;
					object obj9 = obj10 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v17+18]");
					bool flag4 = (nint)0 < (nint)2;
					object obj11 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v17+18]");
					object obj12 = -2;
					bool flag5 = obj12 == null;
					object obj13 = ~obj11;
					object obj14 = obj13 | flag5;
					if (obj14 != null)
					{
						goto IL_0607;
					}
					object obj16 = default;
					object obj15 = obj16 + obj16;
					_ = 1008981770;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v17+18]");
					if ((nint)0 >= (nint)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v17+18]");
						object obj17 = 0 & 0xFFFFFFFFL;
						object obj18 = obj6 + 36;
						object obj19 = obj17 - 1;
						object obj20 = obj7;
						bool flag10;
						do
						{
							obj15 = obj18;
							obj18 += 4;
							object obj21 = obj18 - obj20;
							bool flag6 = (nint)obj21 < 0;
							bool flag7 = obj21 == null;
							object obj22 = obj18 ^ obj20;
							object obj23 = obj18 ^ obj21;
							object obj24 = obj22 & obj23;
							bool flag8 = (nint)obj24 < 0;
							bool flag9 = flag6 == flag8;
							object obj25 = !flag7;
							object obj26 = flag9 & obj25;
							object obj27 = ~obj26;
							if (obj27 == null)
							{
								obj20 = obj18;
							}
							obj19--;
							flag10 = (nint)obj19 != 1;
							obj7 = obj20;
						}
						while (flag10);
					}
					if ((object)gameObject != null)
					{
						Transform transform = gameObject.transform;
						if ((object)transform != null)
						{
							Vector3 position = transform.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
							object obj29 = 0;
							GameObject gameObject2 = default;
							gameObject2._002Ector((string)obj29);
							if ((object)gameObject2 != null)
							{
								transform2 = gameObject2.transform;
								if ((object)t.root != null)
								{
									Transform parent = t.root.transform;
									if ((object)transform2 != null)
									{
										transform2.SetParent(parent, worldPositionStays: false);
										Vector2 size = Size;
										transform2.localPosition = (Vector3)0;
										Transform transform3 = gameObject.transform;
										if ((object)transform3 != null)
										{
											transform3.SetParent(transform2, worldPositionStays: false);
											Transform transform4 = gameObject.transform;
											if ((object)transform4 != null)
											{
												transform4.localRotation = (Quaternion)0;
												Transform transform5 = gameObject.transform;
												if ((object)transform5 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
													object obj30 = 0 / obj7;
													transform5.localScale = (Vector3)0;
													Transform transform6 = gameObject.transform;
													if ((object)transform6 != null)
													{
														object obj32 = default;
														object obj31 = obj32 - obj15;
														object obj34 = default;
														object obj35 = default;
														object obj33 = obj34 - obj35;
														object obj37 = default;
														object obj38 = default;
														object obj36 = obj37 - obj38;
														object obj39 = obj33 * obj30;
														object obj40 = 0 - obj39;
														object obj41 = obj36 * obj30;
														object obj42 = 0 - obj41;
														object obj43 = obj31 * obj30;
														object obj44 = 0 - obj43;
														transform6.localPosition = (Vector3)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C30]");
														object obj45 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
														object obj46 = default;
														if (obj46 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v45+18]");
															object obj47 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v45+18]");
															bool flag11 = (nint)0 < (nint)1;
															bool flag12 = false;
															if (flag11)
															{
																goto IL_05c6;
															}
															object obj48 = obj46 + 32;
															object obj49 = 0;
															while (true)
															{
																bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47);
																object obj50 = !flag13;
																if (obj50 != null)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X23_v9+v243 @ X21_v10*8]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X23_v9+v243 @ X21_v10*8]");
																	((Renderer)0).shadowCastingMode = (ShadowCastingMode)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v45+18]");
																	obj47 = 0;
																	obj49++;
																	object obj51 = obj49;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v45+18]");
																	bool flag14 = (nint)obj51 < 0;
																	flag12 = false;
																	if (flag14)
																	{
																		continue;
																	}
																	goto IL_05c6;
																}
																goto IL_05f9;
															}
															goto IL_0607;
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
		goto IL_05f9;
		IL_0607:
		throw new IndexOutOfRangeException();
		IL_05c6:
		GameObject gameObject3 = transform2.gameObject;
		object obj52 = t + 24;
		obj52 = gameObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return;
		IL_05f9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0607;
	}

	private unsafe void ShowTiles(float on, float dt)
	{
		//IL_0589: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I4
		//IL_05bc: Expected Obj, but got I4
		//IL_05d6: Invalid comparison between F4 and I4
		//IL_027b: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00a5: Invalid comparison between F4 and I4
		//IL_00e8: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected VT, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I8
		//IL_0211: Expected Obj, but got I8
		//IL_02e4: Expected VT, but got Obj
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected I4, but got Unknown
		//IL_033c: Expected VT, but got I
		//IL_034c: Expected Obj, but got I
		//IL_036a: Expected VT, but got I
		//IL_0388: Expected Obj, but got I4
		//IL_03a5: Invalid comparison between F4 and I4
		//IL_04bc: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I4
		//IL_03f1: Expected F4, but got I
		//IL_0439: Invalid comparison between F4 and I
		//IL_044a: Expected Obj, but got I4
		//IL_046a: Invalid comparison between F4 and I4
		//IL_0485: Invalid comparison between F4 and I
		//IL_0646: Expected Obj, but got I4
		//IL_0672: Expected F4, but got I4
		//IL_067a: Expected Obj, but got I4
		//IL_053e: Expected VT, but got Obj
		Tile[] array = tiles;
		bool flag = tiles == null;
		Tile tile = (Tile)109895680;
		if (flag)
		{
			goto IL_0237;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		bool flag2 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2B8]");
		object obj3 = 0;
		RectInt rectInt2 = default;
		RectInt rectInt = rectInt2;
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		System.__Canon _Canon = null;
		Tile tile2 = (Tile)109895680;
		float num2 = default;
		float num3 = default;
		while (true)
		{
			object obj8 = array.Length;
			bool flag3 = (nint)_Canon < array.Length;
			object obj9 = !flag3;
			float num = (float)_Canon - (float)array.Length;
			bool flag4 = num < 0f;
			bool flag5 = (nint)_Canon >= array.Length;
			rectInt2 = rectInt;
			obj5 = obj4;
			obj7 = obj6;
			System.__Canon _Canon2 = _Canon;
			tile = tile2;
			if (flag5)
			{
				break;
			}
			bool flag6 = (nint)_Canon < array.Length;
			obj9 = !flag6;
			num = (float)_Canon - (float)array.Length;
			flag4 = num < 0f;
			if (obj9 == null)
			{
				bool value = ((bool*)(flag2 ? 1 : 0))->m_value;
				object obj10 = (object)array + (object)_Canon;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v13+20]");
				tile = (Tile)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v18 (System.Boolean)+E4]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = _Canon & 3;
				object obj13 = (object)_Canon >> 2;
				object obj14 = obj13 & 0x3FFFFFFF;
				obj7 = obj12 << 6;
				object obj15 = obj14 * 108;
				obj8 = 28 + obj15;
				object obj16 = obj7 - obj12;
				object obj17 = obj16 | obj8;
				rectInt2 = (RectInt)(obj17 + 132);
				ShowTile(tile, rectInt2, num2, num3);
				array = tiles;
				_Canon2 = (System.__Canon)(_Canon + 1);
				bool flag8 = tiles == null;
				object obj18 = !flag8;
				obj5 = 446676598842L;
				rectInt = rectInt2;
				obj4 = 446676598842L;
				obj6 = obj7;
				_Canon = _Canon2;
				tile2 = tile;
				if (obj18 != null)
				{
					continue;
				}
				goto IL_0237;
			}
			throw new IndexOutOfRangeException();
		}
		goto IL_0245;
		IL_0245:
		List<Tile> list = leaving;
		if (leaving != null)
		{
			tile = (Tile)list._size;
			bool flag9 = list._size < 1;
			object obj9 = !flag9;
			float num = (float)list._size - 1f;
			if (list._size < 1)
			{
				return;
			}
			while (true)
			{
				bool flag10 = leaving == null;
				flag2 = true;
				if (flag10)
				{
					break;
				}
				rectInt2 = (RectInt)obj;
				int num4 = tile - 1;
				System.__Canon _Canon3 = ((List<System.__Canon>)(object)leaving).get_Item(num4);
				bool flag11 = _Canon3 == null;
				flag2 = true;
				if (flag11)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v6 (System.__Canon)+60]");
				rectInt2 = (RectInt)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v6 (System.__Canon)+68]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v6 (System.__Canon)+60]");
				ShowTile((Tile)(object)_Canon3, (RectInt)0, num2, num3);
				bool flag12 = (double)num2 < 1.0;
				obj9 = !flag12;
				num = num2 - 1f;
				bool flag4 = num < 0f;
				bool flag5 = (double)num2 < 1.0;
				float num5 = num3;
				float num6 = num2;
				System.__Canon _Canon2;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v6 (System.__Canon)+40]");
					num5 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v6 (System.__Canon)+38]");
					float num7 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v6 (System.__Canon)+40]");
					float num8 = num7 - 0f;
					num6 = num8 * num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					float num9 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					bool flag13 = num9 < 0f;
					obj9 = !flag13;
					float num10 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					num = num10 - 0f;
					flag4 = num < 0f;
					float num11 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					flag5 = !(num11 < 0f);
					_Canon2 = _Canon3;
					if (flag5)
					{
						goto IL_062c;
					}
				}
				object obj19 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v6 (System.__Canon)+10]");
				_Canon2 = (System.__Canon)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v9+E4]");
				bool flag14 = (nint)0 == 0;
				object obj20 = !flag14;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy((UnityEngine.Object)(object)_Canon2);
				bool flag15 = leaving == null;
				flag2 = true;
				tile = (Tile)num4;
				if (flag15)
				{
					break;
				}
				rectInt2 = (RectInt)obj3;
				((List<System.__Canon>)(object)leaving).RemoveAt(num4);
				dirty = true;
				goto IL_062c;
				IL_062c:
				bool flag16 = num4 < 0;
				obj9 = !flag16;
				flag4 = num4 < 0;
				flag5 = num4 > 0;
				num = num4;
				tile = (Tile)num4;
				if (!flag5)
				{
					return;
				}
			}
		}
		goto IL_0237;
		IL_0237:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0245;
	}

	private unsafe void ShowTile(Tile t, RectInt place, float on, float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c7b: Expected Obj, but got I4
		//IL_004e: Invalid comparison between F4 and I4
		//IL_0066: Expected Obj, but got F8
		//IL_0073: Expected Obj, but got F4
		//IL_00e8: Expected Obj, but got I4
		//IL_0123: Expected VT, but got I4
		//IL_0c97: Expected Obj, but got VT
		//IL_0cc5: Expected Obj, but got VT
		//IL_0d03: Invalid comparison between F4 and I4
		//IL_0d12: Invalid comparison between F4 and I4
		//IL_0d2a: Expected Obj, but got F8
		//IL_0d37: Expected Obj, but got F4
		//IL_0d76: Expected Obj, but got I4
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected Obj, but got Unknown
		//IL_10dc: Expected Obj, but got I
		//IL_1106: Expected Obj, but got I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_01ae: Invalid comparison between Obj and F8
		//IL_01ce: Expected F4, but got VT
		//IL_0dd8: Expected VT, but got F4
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Expected Obj, but got Unknown
		//IL_0217: Invalid comparison between F8 and I4
		//IL_0dff: Expected Obj, but got VT
		//IL_0ea5: Invalid comparison between F8 and I4
		//IL_0eb4: Expected F8, but got I4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_0401: Expected VT, but got I4
		//IL_0411: Expected Obj, but got I
		//IL_0419: Expected VT, but got Obj
		//IL_0443: Expected I4, but got I8
		//IL_045d: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I4
		//IL_0488: Expected Obj, but got I
		//IL_04f7: Expected F8, but got I
		//IL_04ba: Expected VT, but got I4
		//IL_04c2: Expected Obj, but got I4
		//IL_0f12: Expected Obj, but got I4
		//IL_0f4b: Expected Obj, but got I4
		//IL_050c: Expected F8, but got I
		//IL_0791: Expected Obj, but got I4
		//IL_0683: Expected F4, but got I
		//IL_07af: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I
		//IL_07cf: Expected F4, but got Obj
		//IL_07df: Expected F8, but got I
		//IL_0f69: Expected F8, but got I
		//IL_1006: Expected Obj, but got I4
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Ref, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Ref, but got Unknown
		//IL_08bb: Expected VT, but got I4
		//IL_0955: Expected VT, but got I4
		//IL_1024: Expected Obj, but got I
		//IL_1044: Expected Obj, but got I
		//IL_1066: Expected Obj, but got I4
		//IL_098e: Invalid comparison between F4 and I4
		//IL_099f: Expected Obj, but got I4
		//IL_09ad: Invalid comparison between F4 and I4
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected Obj, but got Unknown
		//IL_09d2: Expected F8, but got I4
		//IL_0afc: Expected VT, but got I4
		//IL_0b32: Expected Obj, but got I
		//IL_0b3d: Expected Obj, but got I4
		//IL_0b6b: Expected Obj, but got I4
		//IL_0b5d: Expected Obj, but got I4
		//IL_0b86: Expected Obj, but got I4
		//IL_10be: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = Has(t);
		float num = on - 1f;
		bool flag3 = num < 0f;
		object obj4 = (double)on ^ 1.0;
		object obj5 = on ^ num;
		object obj6 = obj4 & obj5;
		bool flag4 = (nint)obj6 < 0;
		bool flag5 = flag3 == flag4;
		bool flag6 = flag5 & flag2;
		bool activeSelf = t.root.activeSelf;
		bool flag7 = flag6 == activeSelf;
		RectInt rectInt = place;
		bool flag8 = false;
		GameObject gameObject = (GameObject)activeSelf;
		if (!flag7)
		{
			gameObject = t.root;
			t.root.SetActive(flag6);
			rectInt = (RectInt)0;
			flag8 = flag6;
		}
		if (!flag6)
		{
			return;
		}
		if ((double)t.pop < 1.0)
		{
			dirty = true;
		}
		object obj7 = place >> 32;
		float num2 = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
		float num3 = num2 / 0f;
		object obj8 = t.at - t.to;
		float num4 = num3 + t.pop;
		object obj9 = obj8 * obj8;
		float num5 = num4 - 1f;
		bool flag9 = num5 < 0f;
		bool flag10 = num5 == 0f;
		object obj10 = (double)num4 ^ 1.0;
		object obj11 = num4 ^ num5;
		object obj12 = obj10 & obj11;
		bool flag11 = (nint)obj12 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		bool flag12 = flag9 == flag11;
		object obj13 = !flag10;
		object obj14 = flag12 & obj13;
		object obj15 = ~obj14;
		float pop = ((obj15 != null) ? num4 : 1f);
		object obj16 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		bool flag13 = (nint)obj16 < 0;
		t.pop = pop;
		if (!flag13)
		{
			bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25);
			pop = 0.25f;
			float num6 = (float)t.to;
			if (!flag14)
			{
				float num7 = dt * -12f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
				double num8 = 1.0 - (double)num7;
				if (!(num8 < 0.0) && num8 > 1.0)
				{
					goto IL_024a;
				}
				obj9 = t.to - t.at;
				object obj17 = default;
				pop = (float)obj9 * (float)obj17;
				num6 = (float)t.at + pop;
				num4 = 1f;
			}
			t.at = (Vector2)num6;
			dirty = true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v13+E4]");
		bool flag15 = (nint)0 == 0;
		object obj20 = !flag15;
		if (obj20 == null)
		{
			goto IL_024a;
		}
		goto IL_0259;
		IL_024a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0259;
		IL_063c:
		Vector2 size = Size;
		double num10;
		double num11;
		double num9 = num10 * num11;
		double num13;
		double num14;
		double num12 = num13 * num14;
		Vector2 size2 = Size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
		float num15 = 0f;
		double num16 = (double)overAt - num9;
		double num17 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
		double num18 = num17 * 0.0;
		double num19 = num16 / num18;
		bool flag16 = num19 < -1.0;
		double num20 = -1.0;
		if (!flag16)
		{
			bool flag17 = !(num19 > 1.0);
			num20 = num19;
			if (!flag17)
			{
				num20 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		double num21 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CosmeticTerminal)+1E4]");
		double num22 = 0.0 - num12;
		double num23 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		num14 = num23 * 0.0;
		num11 = num22 / num14;
		bool flag18 = num11 < -1.0;
		float w = (float)num20;
		double num24 = -1.0;
		if (!flag18)
		{
			bool flag19 = num11 > 1.0;
			w = (float)num20;
			num24 = 1.0;
			if (!flag19)
			{
				w = (float)num20;
				num24 = num11;
			}
		}
		goto IL_0fdc;
		IL_0fdc:
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v28+E4]");
		bool flag20 = (nint)0 == 0;
		object obj22 = !flag20;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 target;
		Spring2(ref *(Vector2*)(t + 80), ref *(Vector2*)(t + 88), target, w, (float)num24, 11f);
		bool flag21;
		int num27;
		if (flag21)
		{
			float time = Time.time;
			float num25 = time * 3f;
			float num26 = num25 + (float)num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		}
		Transform transform = t.root.transform;
		Vector3 localPosition = transform.localPosition;
		transform.localPosition = (Vector3)0;
		Transform transform2 = t.root.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (CosmeticTerminal+Tile)+54]");
		double num28 = 0.0 * 18.0;
		double num29 = (double)t.lean * -18.0;
		double num30 = num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		double num31 = num30 * 0.0;
		double num32 = num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		double num33 = num32 * 0.0;
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		transform2.localRotation = (Quaternion)0;
		Transform transform3 = t.root.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj23 = 0;
		object obj24 = obj;
		object obj25 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X8_v39+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ X0_v45+E4]");
		bool flag22 = (nint)0 == 0;
		object obj27 = !flag22;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag23 = t.pop < 0f;
		object obj28 = !flag23;
		bool flag24 = t.pop == 0f;
		object obj29 = ~obj28;
		object obj30 = obj29 | flag24;
		double num34 = 0.0;
		if (obj30 == null)
		{
			bool flag25 = !((double)t.pop < 1.0);
			num34 = 1.0;
			if (!flag25)
			{
				double num35 = (double)t.pop * -10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				double num36 = (double)t.pop * 10.0;
				double num37 = num36 + -0.75;
				double num38 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				double num39 = num38 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				double num40 = num35 * num39;
				num34 = num40 + 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v40+14]");
		double num41 = 0.0 * num34;
		double num43;
		double num42 = num43 * num41;
		double num44 = num42 * (double)t.k;
		transform3.localScale = (Vector3)0;
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(t.id);
		bool flag26 = !flag21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj31 = 0;
		object obj32 = !flag26;
		object obj33 = ~obj32;
		object obj34 = ((obj33 != null) ? ((object)1109393408) : ((object)1117782016));
		object obj35 = obj31;
		object obj37;
		object obj36 = ((obj37 != null) ? ((object)1124859904) : obj34);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v45+E4]");
		bool flag27 = (nint)0 == 0;
		object obj38 = !flag27;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (t.model != null && (entry == null || entry.slot != (CosmeticSlot)2))
		{
			Transform transform4 = t.model.transform;
			float yAngle = (float)obj36 * dt;
			transform4.Rotate(0f, yAngle, 0f, (Space)0);
		}
		return;
		IL_0259:
		object obj39 = obj7 + 40;
		nint num45 = default;
		bool flag28 = num45 < 0;
		object obj40 = num45 ^ num45;
		object obj41 = num45 & obj40;
		bool flag29 = (nint)obj41 < 0;
		bool flag30 = flag28 == flag29;
		object obj42 = !flag30;
		object obj43 = ~obj42;
		IntPtr intPtr = ((obj43 != null) ? num45 : (num45 + 1));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (CosmeticTerminal+Tile)+3C]");
		object obj44 = 0 + obj39;
		double num46 = (double)obj44 + -28.0;
		double num47 = 1131413504.0 - (double)obj44;
		if (!(num46 < num47))
		{
			num46 = num47;
		}
		double num48 = num46 / 1107820544.0;
		bool flag31 = num48 < 0.0;
		num43 = 0.0;
		if (!flag31)
		{
			bool flag32 = !(num48 > 1.0);
			num43 = num48;
			if (!flag32)
			{
				num43 = 1.0;
			}
		}
		Transform transform5 = t.root.transform;
		Vector2 size3 = Size;
		object obj45 = place + (nint)intPtr;
		double num49 = (double)obj44 + 0.5;
		object obj46 = t.at + obj45;
		double num50 = (double)obj46 + 0.5;
		double num51 = num50 * 59.0;
		double num52 = num49 * 3145728000.0;
		num10 = num51 + -0.5;
		num13 = num52 + 0.5;
		transform5.localPosition = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF420]");
		object obj47 = 0;
		target = (Vector2)obj47;
		num27 = Array.IndexOf((System.__Canon[])(object)tiles, (System.__Canon)(object)t);
		int num53 = (int)(num27 & 0x80000000L);
		bool flag33 = num53 == 0;
		object obj48 = !flag33;
		if (obj48 == null)
		{
			int num54 = default;
			string text = num54.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
			object obj49 = 0;
			string text2 = (string)obj49 + text;
			bool flag34 = hovered == text2;
			target = (Vector2)0;
			obj37 = flag34;
		}
		else
		{
			obj37 = 0;
		}
		flag21 = IsPicked(t);
		double num55;
		if (obj37 == null)
		{
			num55 = 1.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			num55 = 0.0;
		}
		bool flag35 = !flag21;
		object obj50 = obj;
		object obj51 = !flag35;
		object obj52 = ~obj51;
		double num56;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A96C]");
			num56 = 0.0;
		}
		else
		{
			num56 = num55;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v25+E4]");
		bool flag36 = (nint)0 == 0;
		object obj53 = !flag36;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num57 = (double)t.k - num56;
		float num58 = t.kV;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF48]");
		num15 = num58 * 0f;
		double num59 = num57 * 3274244096.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		double num60 = (double)num15 + num59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num61 = 0.0 * num60;
		num14 = (double)t.kV + num61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		num21 = 0.0 * num14;
		num11 = (double)t.k + num21;
		t.k = (float)num11;
		t.kV = (float)num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC15]");
		if ((nint)0 != 0)
		{
			if (obj37 != null)
			{
				goto IL_063c;
			}
		}
		else
		{
			_ = 1;
			bool flag37 = obj37 == null;
			object obj54 = !flag37;
			if (obj54 != null)
			{
				goto IL_063c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		object obj55 = 0;
		object obj56 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v54+A0]");
		object obj57 = 0;
		w = (float)obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v55+4]");
		num24 = 0.0;
		goto IL_0fdc;
	}

	private bool IsPicked(Tile t)
	{
		//IL_01a7: Expected I4, but got Obj
		//IL_0041: Expected I4, but got I8
		//IL_005b: Expected Obj, but got I4
		//IL_011e: Expected I4, but got I8
		//IL_0138: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		if (t != null)
		{
			int num = t.outfit;
			int num2 = (int)(t.outfit & 0x80000000L);
			bool flag = num2 == 0;
			object obj = !flag;
			int num3;
			if (obj == null)
			{
				num3 = pickedOutfit;
			}
			else
			{
				num = t.monster;
				if (t.monster > 0)
				{
					num3 = pickedMonster;
				}
				else
				{
					num = t.title;
					if (t.title > 0)
					{
						num3 = pickedTitle;
					}
					else
					{
						num = t.bundle;
						int num4 = (int)(t.bundle & 0x80000000L);
						bool flag2 = num4 == 0;
						object obj2 = !flag2;
						if (obj2 == null)
						{
							num3 = pickedBundle;
						}
						else
						{
							num = t.id;
							if (t.id == 0)
							{
								return false;
							}
							num3 = picked;
						}
					}
				}
			}
			object obj3 = num3 - num;
			return obj3 == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void PushTab(int c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0261: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		float[] array = tabPush;
		object obj2 = obj;
		if (tabPush != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v9+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v17+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v17+8]");
			if ((nint)0 == 0)
			{
				goto IL_02b9;
			}
			int num = array.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v18+18]");
			if ((nint)num == 0)
			{
				goto IL_0182;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v9+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v12+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v12+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			float[] array2 = default;
			tabPush = array2;
			object obj10 = this + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v14+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v15+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v15+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				float[] array3 = default;
				tabPushV = array3;
				object obj14 = this + 504;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				goto IL_0182;
			}
		}
		goto IL_02b9;
		IL_02b9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02c7;
		IL_02c7:
		throw new IndexOutOfRangeException();
		IL_0182:
		float[] array4 = tabPush;
		if (tabPush == null)
		{
			goto IL_02b9;
		}
		bool flag3 = array4.Length < c;
		object obj15 = !flag3;
		object obj16 = array4.Length - c;
		bool flag4 = obj16 == null;
		object obj17 = ~obj15;
		object obj18 = obj17 | flag4;
		if (obj18 == null)
		{
			object obj19 = tabPush + c;
			float[] array5 = tabPushV;
			_ = 1065353216;
			if (tabPushV == null)
			{
				goto IL_02b9;
			}
			bool flag5 = array5.Length < c;
			object obj20 = !flag5;
			object obj21 = array5.Length - c;
			bool flag6 = obj21 == null;
			object obj22 = ~obj20;
			object obj23 = obj22 | flag6;
			if (obj23 == null)
			{
				object obj24 = tabPushV + c;
				_ = 0;
				return;
			}
		}
		goto IL_02c7;
	}

	private void Tabs(float dt)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I4
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_0081: Expected F4, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_00ec: Expected F4, but got I
		//IL_018c: Expected Obj, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_0261: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I4
		float[] array = tabPush;
		if (tabPush == null)
		{
			return;
		}
		object obj = tabPush + 24;
		if ((nint)obj < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj2 = 0;
		object obj3 = obj & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		object obj4 = 8;
		CosmeticTerminal cosmeticTerminal = this;
		while (true)
		{
			object obj5 = obj4 - 8;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8 (System.Single[])+v173 @ X23_v4*4]");
			float num = 0f;
			float[] array2 = tabPushV;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8 (System.Single[])+v173 @ X23_v4*4]");
			if ((nint)0 == 0)
			{
				bool flag2 = (nint)obj5 < array2.Length;
				object obj7 = !flag2;
				if (obj7 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X27_v6 (System.Single[])+v173 @ X23_v4*4]");
				num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X27_v6 (System.Single[])+v173 @ X23_v4*4]");
				if ((nint)0 == 0)
				{
					goto IL_0369;
				}
			}
			cosmeticTerminal = (CosmeticTerminal)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8 (CosmeticTerminal)+E4]");
			object obj8;
			if ((nint)0 != 0)
			{
				obj8 = obj3 & 0xFFFFFFFFL;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			object obj9 = !flag3;
			if (obj9 != null)
			{
				break;
			}
			bool flag4 = (nint)obj5 < array2.Length;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X27_v6 (System.Single[])+v173 @ X23_v4*4]");
			double num2 = 0.0 * -20.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8 (System.Single[])+v173 @ X23_v4*4]");
			float num3 = 0f * 3.2846643E+09f;
			double num4 = num2 + (double)num3;
			float num5 = dt * (float)num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X27_v6 (System.Single[])+v173 @ X23_v4*4]");
			float num6 = 0f + num5;
			float num7 = dt * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8 (System.Single[])+v173 @ X23_v4*4]");
			float num8 = 0f + num7;
			array = tabPush;
			bool flag5 = (nint)obj5 < array.Length;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8 (System.Single[])+v173 @ X23_v4*4]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if (num9 < 0)
			{
				float[] array3 = tabPushV;
				bool flag6 = (nint)obj5 < array3.Length;
				object obj12 = !flag6;
				if (obj12 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v15 (System.Single[])+v173 @ X23_v4*4]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				if (num10 < 0)
				{
					_ = 0;
					_ = 0;
				}
			}
			dirty = true;
			goto IL_0369;
			IL_0369:
			object obj13 = obj4 - 7;
			obj4++;
			obj = array + 24;
			obj3 = obj;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
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

	private unsafe void Draw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07ed: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_02da: Expected VT, but got I4
		//IL_05c1: Invalid comparison between F4 and I4
		//IL_00a5: Expected Obj, but got I4
		//IL_0804: Invalid comparison between F4 and I4
		//IL_0813: Invalid comparison between F4 and I4
		//IL_0826: Expected Obj, but got F4
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected Obj, but got Unknown
		//IL_085b: Expected Obj, but got I4
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		//IL_0878: Expected VT, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_01f5: Expected F8, but got I4
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I4
		//IL_0a83: Expected Obj, but got I
		//IL_0aad: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I
		//IL_0263: Invalid comparison between F8 and I4
		//IL_0156: Expected Obj, but got I
		//IL_0171: Expected Obj, but got Ref
		//IL_018b: Expected Obj, but got I
		//IL_0688: Expected Obj, but got I
		//IL_070f: Expected Obj, but got I4
		//IL_09a3: Invalid comparison between F8 and I4
		//IL_0517: Invalid comparison between F8 and I4
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got F8
		//IL_056d: Expected Obj, but got I4
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_0981: Expected Obj, but got I4
		//IL_0761: Expected Obj, but got I
		//IL_0774: Expected I4, but got Obj
		//IL_059a: Expected F8, but got I4
		//IL_0a65: Expected Obj, but got I4
		//IL_0a3e: Expected Obj, but got I4
		//IL_0aea: Expected Obj, but got I
		//IL_0af8: Expected VT, but got F8
		//IL_0b1b: Expected VT, but got I8
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected Obj, but got Unknown
		//IL_0a27: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_09e8: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got I
		//IL_0453: Invalid comparison between F8 and I4
		//IL_0464: Expected Obj, but got I4
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04df: Invalid comparison between F8 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		dirty = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj4 = 0;
		GillaBoardLook.Clear(px, 512, 256);
		float num = awake;
		double num17;
		double num18;
		RectInt rectInt;
		int num2;
		double num5;
		if ((double)awake < 1.0)
		{
			bool flag2 = title == null;
			num2 = 0;
			int num3 = 256;
			Color32[] array = (Color32[])512;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v40+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj4;
				}
				object obj8 = default;
				if (obj8 == null)
				{
					goto IL_07a3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v40+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v41+88]");
				_ = 0;
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v43+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v44+88]");
				_ = 0;
				ShiftAuth.Style s = default;
				object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF280]");
				object obj13 = 0;
				int num4 = title.DrawCentred(px, 512, 256, 256, 116, (string)obj13, ref s);
				num = awake;
				num2 = 256;
				num3 = 512;
				array = px;
			}
			bool flag4 = num < 0f;
			bool flag5 = num == 0f;
			object obj14 = num ^ num;
			object obj15 = num & obj14;
			bool flag6 = (nint)obj15 < 0;
			bool flag7 = flag4 == flag6;
			object obj16 = !flag7;
			object obj17 = obj16 | flag5;
			num5 = num;
			rectInt = (RectInt)array;
			if (obj17 == null)
			{
				double num6 = 0.0;
				if (!flag4)
				{
					bool flag8 = !((double)num > 1.0);
					num6 = num;
					if (!flag8)
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
				double num13 = 1.0 - num12;
				double num14 = num13 * 0.0;
				double num15 = num12 + num14;
				double num16 = num15 * 1132462080.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v28+E4]");
				bool flag9 = (nint)0 == 0;
				object obj20 = !flag9;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
				double num19 = default;
				if (num16 < 0.0)
				{
					if (num16 == -0.5)
					{
						num17 = -1.0;
						num18 = num19;
						goto IL_094a;
					}
					num18 = num16 + -0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					num5 = -0.5;
				}
				else
				{
					if (num16 == 0.5)
					{
						num17 = 1.0;
						num18 = num19;
						goto IL_094a;
					}
					num18 = num16 + 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					num5 = 0.5;
				}
				goto IL_0994;
			}
		}
		else
		{
			DrawUi();
			num5 = awake;
			num2 = 0;
			rectInt = (RectInt)512;
		}
		goto IL_05b6;
		IL_07b1:
		throw new IndexOutOfRangeException();
		IL_07a3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_07b1;
		IL_04f6:
		object obj21 = obj4;
		double num20 = num18 - 254.0;
		bool flag10 = num20 < 0.0;
		object obj22 = num18 ^ 0xFE;
		object obj23 = num18 ^ num20;
		object obj24 = obj22 & obj23;
		bool flag11 = (nint)obj24 < 0;
		bool flag12 = flag10 == flag11;
		object obj25 = !flag12;
		object obj26 = ~obj25;
		double num21 = ((obj26 != null) ? 254.0 : num18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v35+E4]");
		bool flag13 = (nint)0 == 0;
		object obj27 = !flag13;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v35+A0]");
		object obj28 = 0;
		rectInt = (RectInt)(num21 << 32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v24+80]");
		num2 = 0;
		FillRect(rectInt, (Color32)8589935104L);
		goto IL_05b6;
		IL_05b6:
		if (!(reboot < 0f))
		{
			Glitch(reboot);
		}
		if ((object)tex != null)
		{
			tex.SetPixels32(px);
			if ((object)tex != null)
			{
				tex.Apply(updateMipmaps: true);
				object obj29 = this + 224;
				bool flag14 = obj29 == null;
				object obj30 = !flag14;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					obj29 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				if ((object)screen != null)
				{
					screen.GetPropertyBlock((MaterialPropertyBlock)obj29);
					object obj32 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v15+E4]");
					bool flag15 = (nint)0 == 0;
					object obj33 = !flag15;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj29 != null)
					{
						object obj34 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v10+A0]");
						object obj35 = 0;
						((MaterialPropertyBlock)obj29).SetTexture((int)obj35, (Texture)tex);
						if ((object)screen != null)
						{
							screen.SetPropertyBlock((MaterialPropertyBlock)obj29);
							return;
						}
					}
				}
			}
		}
		goto IL_07a3;
		IL_094a:
		num5 = num18 + num17;
		object obj36 = num18 & 1;
		bool flag16 = obj36 == null;
		object obj37 = !flag16;
		if (obj37 != null)
		{
			num18 = num5;
		}
		goto IL_0994;
		IL_0994:
		DrawUi();
		if (num18 > 255.0)
		{
			goto IL_04f6;
		}
		double num22 = 130560.0 - num18;
		double num23 = num18;
		while (true)
		{
			object obj38 = 0;
			while (true)
			{
				object obj39 = obj4;
				Color32[] array2 = px;
				object obj40 = num23 & 1;
				bool flag17 = obj40 == null;
				object obj41 = !flag17;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v43+E4]");
					bool flag18 = (nint)0 == 0;
					object obj42 = !flag18;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj39 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v43+A0]");
					object obj43 = (nint)0 + (nint)120;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v43+E4]");
					bool flag19 = (nint)0 == 0;
					object obj44 = !flag19;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj39 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v43+A0]");
					object obj43 = (nint)0 + (nint)124;
				}
				if (px == null)
				{
					break;
				}
				double num24 = num22 + (double)obj38;
				bool flag20 = num24 < (double)array2.Length;
				object obj45 = !flag20;
				if (obj45 == null)
				{
					double num25 = (double)px + num24;
					obj38++;
					if ((nint)obj38 != 512)
					{
						continue;
					}
					goto IL_04b6;
				}
				goto IL_07b1;
			}
			break;
			IL_04b6:
			num23++;
			num22 -= 512.0;
			if (num23 != 256.0)
			{
				continue;
			}
			goto IL_04f6;
		}
		goto IL_07a3;
	}

	private unsafe void DrawUi()
	{
		//IL_0010: Expected Obj, but got I
		//IL_2643: Expected Obj, but got I
		//IL_2665: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_2683: Expected Obj, but got I
		//IL_2693: Expected Obj, but got I
		//IL_26a3: Expected Obj, but got I
		//IL_26b3: Expected Obj, but got I
		//IL_26e3: Expected Obj, but got I
		//IL_26f3: Expected Obj, but got I
		//IL_271d: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0143: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I8
		//IL_015b: Expected VT, but got I8
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I4
		//IL_2734: Unknown result type (might be due to invalid IL or missing references)
		//IL_2739: Expected Obj, but got Unknown
		//IL_2742: Unknown result type (might be due to invalid IL or missing references)
		//IL_2747: Expected Obj, but got Unknown
		//IL_276e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2773: Expected Obj, but got Unknown
		//IL_27b5: Expected Obj, but got I4
		//IL_27bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c2: Expected Obj, but got Unknown
		//IL_027e: Expected Obj, but got I4
		//IL_27e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e7: Expected Obj, but got Unknown
		//IL_3211: Expected Obj, but got I
		//IL_323b: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02b5: Invalid comparison between F4 and I4
		//IL_2858: Unknown result type (might be due to invalid IL or missing references)
		//IL_285d: Expected VT, but got Unknown
		//IL_286d: Expected Obj, but got I
		//IL_2886: Unknown result type (might be due to invalid IL or missing references)
		//IL_288b: Expected VT, but got Unknown
		//IL_28b1: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I8
		//IL_03d2: Expected VT, but got I8
		//IL_2815: Unknown result type (might be due to invalid IL or missing references)
		//IL_281a: Expected Obj, but got Unknown
		//IL_2834: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I
		//IL_042d: Expected I4, but got Obj
		//IL_043a: Expected I4, but got I8
		//IL_0447: Expected Obj, but got I8
		//IL_0638: Expected Obj, but got I
		//IL_0905: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I4
		//IL_2ac8: Expected Obj, but got I
		//IL_2ad8: Expected Obj, but got I
		//IL_2af6: Expected VT, but got I
		//IL_2af6: Expected VT, but got I
		//IL_2b06: Expected Obj, but got I
		//IL_2b30: Expected Obj, but got I4
		//IL_067f: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I4
		//IL_04c5: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I
		//IL_04ef: Expected I4, but got Obj
		//IL_04fc: Expected I4, but got I8
		//IL_0509: Expected Obj, but got I8
		//IL_0959: Expected Obj, but got I
		//IL_0969: Expected Obj, but got I
		//IL_09c3: Expected Obj, but got I
		//IL_29b9: Expected Obj, but got I
		//IL_29df: Expected I4, but got Obj
		//IL_29df: Expected Obj, but got I
		//IL_29df: Expected VT, but got I
		//IL_29f7: Expected Obj, but got I
		//IL_2a15: Expected VT, but got I
		//IL_2a2d: Expected Obj, but got I
		//IL_2a53: Expected I4, but got Obj
		//IL_2a53: Expected Obj, but got I
		//IL_2a53: Expected VT, but got I
		//IL_06ee: Expected Obj, but got I
		//IL_070c: Expected VT, but got I
		//IL_071c: Expected Obj, but got I
		//IL_0746: Expected Obj, but got I4
		//IL_0541: Expected Obj, but got I4
		//IL_0db9: Expected Obj, but got I4
		//IL_077b: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I4
		//IL_0597: Expected Obj, but got I
		//IL_05b1: Expected I4, but got Obj
		//IL_05be: Expected I4, but got I8
		//IL_05cb: Expected Obj, but got I8
		//IL_0df5: Expected Obj, but got I
		//IL_0a04: Expected Obj, but got I
		//IL_2a7a: Expected Obj, but got I4
		//IL_0603: Expected Obj, but got I4
		//IL_3259: Expected Obj, but got I
		//IL_327f: Expected Obj, but got I
		//IL_32ae: Expected Obj, but got I
		//IL_32be: Expected Obj, but got I
		//IL_32e8: Expected Obj, but got I4
		//IL_28c6: Expected Obj, but got I
		//IL_28d6: Expected Obj, but got I
		//IL_2906: Expected Obj, but got I
		//IL_291e: Expected Obj, but got I
		//IL_292e: Expected Obj, but got I
		//IL_2948: Expected Obj, but got I
		//IL_2980: Expected Obj, but got I
		//IL_0a48: Expected Obj, but got I
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0a82: Expected Obj, but got I8
		//IL_0809: Expected Obj, but got I
		//IL_084e: Expected Obj, but got I
		//IL_0866: Expected Obj, but got I
		//IL_11c2: Expected Obj, but got I
		//IL_11cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected Obj, but got Unknown
		//IL_11fc: Expected Obj, but got I8
		//IL_0e56: Expected Obj, but got I
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e64: Expected Obj, but got Unknown
		//IL_0e90: Expected Obj, but got I8
		//IL_0aaf: Expected Obj, but got I
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected Obj, but got Unknown
		//IL_0af1: Expected Obj, but got I4
		//IL_0b07: Expected Obj, but got I
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_1229: Expected Obj, but got I
		//IL_1232: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Expected Obj, but got Unknown
		//IL_126b: Expected Obj, but got I4
		//IL_1281: Expected Obj, but got I
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Expected Obj, but got Unknown
		//IL_2aaa: Expected Obj, but got I4
		//IL_0ebd: Expected Obj, but got I
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Expected Obj, but got Unknown
		//IL_0eff: Expected Obj, but got I4
		//IL_0f15: Expected Obj, but got I
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected Obj, but got Unknown
		//IL_0b4a: Expected Obj, but got I
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected Obj, but got Unknown
		//IL_0b84: Expected Obj, but got I8
		//IL_3306: Expected Obj, but got I
		//IL_332c: Expected Obj, but got I
		//IL_335b: Expected Obj, but got I
		//IL_12c4: Expected Obj, but got I
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d2: Expected Obj, but got Unknown
		//IL_12fe: Expected Obj, but got I8
		//IL_0f58: Expected Obj, but got I
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0f92: Expected Obj, but got I8
		//IL_0bb1: Expected Obj, but got I
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected Obj, but got Unknown
		//IL_0bf3: Expected Obj, but got I4
		//IL_0c09: Expected Obj, but got I
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Expected Obj, but got Unknown
		//IL_132b: Expected Obj, but got I
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_1339: Expected Obj, but got Unknown
		//IL_136d: Expected Obj, but got I4
		//IL_1383: Expected Obj, but got I
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Expected Obj, but got Unknown
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected Obj, but got Unknown
		//IL_0ff1: Expected Obj, but got I4
		//IL_1007: Expected Obj, but got I
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Expected Obj, but got Unknown
		//IL_0c4c: Expected Obj, but got I
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected Obj, but got Unknown
		//IL_0c8e: Expected Obj, but got I4
		//IL_0ca4: Expected Obj, but got I
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Expected Obj, but got Unknown
		//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c4: Expected Obj, but got Unknown
		//IL_13f8: Expected Obj, but got I4
		//IL_140e: Expected Obj, but got I
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Expected Obj, but got Unknown
		//IL_104a: Expected Obj, but got I
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected Obj, but got Unknown
		//IL_108c: Expected Obj, but got I4
		//IL_10a2: Expected Obj, but got I
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Expected Obj, but got Unknown
		//IL_0ce7: Expected Obj, but got I
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected Obj, but got Unknown
		//IL_0d29: Expected Obj, but got I4
		//IL_0d3f: Expected Obj, but got I
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected Obj, but got Unknown
		//IL_1451: Expected Obj, but got I
		//IL_145a: Unknown result type (might be due to invalid IL or missing references)
		//IL_145f: Expected Obj, but got Unknown
		//IL_1493: Expected Obj, but got I4
		//IL_14a9: Expected Obj, but got I
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ce: Expected Obj, but got Unknown
		//IL_10e5: Expected Obj, but got I
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f3: Expected Obj, but got Unknown
		//IL_1127: Expected Obj, but got I4
		//IL_113d: Expected Obj, but got I
		//IL_115d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1162: Expected Obj, but got Unknown
		//IL_0d82: Expected Obj, but got I
		//IL_14ec: Expected Obj, but got I
		//IL_2b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b54: Expected Obj, but got Unknown
		//IL_1180: Expected Obj, but got I
		//IL_16fd: Expected Obj, but got I4
		//IL_2c13: Expected Obj, but got I
		//IL_2c23: Expected Obj, but got I
		//IL_2c41: Expected VT, but got I
		//IL_2c41: Expected VT, but got I
		//IL_2c51: Expected Obj, but got I
		//IL_2c7b: Expected Obj, but got I4
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Expected Obj, but got Unknown
		//IL_1510: Expected Obj, but got I4
		//IL_1519: Expected Obj, but got I4
		//IL_1749: Expected Obj, but got I
		//IL_17a3: Expected Obj, but got I
		//IL_17c5: Expected Obj, but got I4
		//IL_2bf5: Expected Obj, but got I4
		//IL_1803: Expected Obj, but got I
		//IL_156f: Expected Obj, but got I
		//IL_1599: Expected Obj, but got I4
		//IL_185f: Expected Obj, but got I4
		//IL_15d7: Expected Obj, but got I4
		//IL_2c99: Expected Obj, but got I
		//IL_2cf3: Expected Obj, but got I
		//IL_2d0b: Expected Obj, but got I
		//IL_2d5d: Expected Obj, but got I
		//IL_189c: Expected Obj, but got I
		//IL_190d: Expected Obj, but got I
		//IL_193b: Expected Obj, but got I
		//IL_1607: Expected Obj, but got I4
		//IL_1617: Expected Obj, but got I
		//IL_169e: Expected Obj, but got I4
		//IL_2bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc6: Expected Obj, but got Unknown
		//IL_1647: Expected Obj, but got I4
		//IL_33bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c0: Expected I4, but got Unknown
		//IL_33ee: Expected Obj, but got I
		//IL_33f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_33fc: Expected Obj, but got Unknown
		//IL_3405: Unknown result type (might be due to invalid IL or missing references)
		//IL_340a: Expected Obj, but got Unknown
		//IL_3442: Expected Obj, but got I
		//IL_3476: Expected Obj, but got I
		//IL_16ce: Expected Obj, but got I
		//IL_2bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb3: Expected Obj, but got Unknown
		//IL_198c: Expected Obj, but got I
		//IL_19a7: Expected Obj, but got Ref
		//IL_1677: Expected Obj, but got I
		//IL_1a6b: Expected Obj, but got I8
		//IL_1ced: Expected Obj, but got I4
		//IL_1a20: Expected Obj, but got I4
		//IL_2dc3: Expected Obj, but got I
		//IL_2dd3: Expected F8, but got I
		//IL_1acc: Expected Obj, but got I8
		//IL_1be3: Expected Obj, but got I4
		//IL_2d7b: Expected Obj, but got I
		//IL_2da5: Expected Obj, but got I4
		//IL_1c10: Expected Obj, but got I
		//IL_1c3a: Expected Obj, but got I4
		//IL_1b26: Expected Obj, but got I4
		//IL_1c6f: Expected F8, but got I
		//IL_1c7f: Expected Obj, but got I
		//IL_1c8f: Expected F8, but got I
		//IL_2de8: Expected Obj, but got I
		//IL_2e12: Expected Obj, but got I4
		//IL_1d4d: Invalid comparison between F4 and I4
		//IL_1f2f: Expected Obj, but got I
		//IL_1f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3c: Expected VT, but got Unknown
		//IL_2e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e3d: Expected Obj, but got Unknown
		//IL_2e57: Expected Obj, but got I4
		//IL_1fdb: Expected Obj, but got I4
		//IL_1e77: Invalid comparison between F4 and I4
		//IL_1e88: Expected VT, but got I4
		//IL_1e90: Expected VT, but got Obj
		//IL_2fa7: Expected Obj, but got I
		//IL_1f94: Expected Obj, but got I4
		//IL_2e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea0: Expected VT, but got Unknown
		//IL_2ec2: Expected Obj, but got I4
		//IL_2f3e: Expected Obj, but got I
		//IL_2f68: Expected Obj, but got I4
		//IL_2f8c: Expected Obj, but got I
		//IL_34ca: Expected Obj, but got I
		//IL_1ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec1: Expected VT, but got Unknown
		//IL_1ee3: Expected Obj, but got I4
		//IL_2020: Unknown result type (might be due to invalid IL or missing references)
		//IL_2025: Expected Obj, but got Unknown
		//IL_202e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2033: Expected Obj, but got Unknown
		//IL_203c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2041: Expected Obj, but got Unknown
		//IL_204e: Expected VT, but got Obj
		//IL_2066: Unknown result type (might be due to invalid IL or missing references)
		//IL_206b: Expected VT, but got Unknown
		//IL_2ee0: Expected Obj, but got I
		//IL_2ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eed: Expected VT, but got Unknown
		//IL_20ed: Expected Obj, but got I4
		//IL_2fdd: Expected Obj, but got I
		//IL_20a6: Expected Obj, but got I4
		//IL_34ed: Expected Obj, but got I
		//IL_2fc2: Expected Obj, but got I
		//IL_219a: Expected Obj, but got I4
		//IL_2155: Expected Obj, but got I4
		//IL_2ff2: Expected Obj, but got I
		//IL_3002: Expected Obj, but got I
		//IL_21b8: Expected Obj, but got I
		//IL_3523: Invalid comparison between VT and I4
		//IL_3536: Expected Obj, but got VT
		//IL_353e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3543: Expected Obj, but got Unknown
		//IL_355b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3560: Expected I4, but got Unknown
		//IL_3579: Expected Obj, but got I4
		//IL_2245: Expected Obj, but got I
		//IL_2279: Expected Obj, but got I4
		//IL_2210: Expected Obj, but got I4
		//IL_3034: Unknown result type (might be due to invalid IL or missing references)
		//IL_3039: Expected I4, but got Unknown
		//IL_2334: Unknown result type (might be due to invalid IL or missing references)
		//IL_2339: Expected VT, but got Unknown
		//IL_3017: Expected Obj, but got I
		//IL_3027: Expected Obj, but got I
		//IL_240c: Invalid comparison between F4 and I4
		//IL_22cd: Expected Obj, but got I
		//IL_235b: Expected Obj, but got I
		//IL_2385: Expected Obj, but got I4
		//IL_2433: Expected Obj, but got I
		//IL_245d: Expected Obj, but got I4
		//IL_23ba: Expected Obj, but got I
		//IL_23dc: Expected Obj, but got I4
		//IL_2311: Expected Obj, but got I
		//IL_24a4: Expected Obj, but got I4
		//IL_30bc: Expected Obj, but got I
		//IL_30cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d2: Expected I4, but got Unknown
		//IL_30e2: Expected Obj, but got I
		//IL_3110: Expected Obj, but got I
		//IL_3149: Expected Obj, but got I
		//IL_315c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3161: Expected VT, but got Unknown
		//IL_3174: Expected VT, but got I8
		//IL_2532: Expected Obj, but got I4
		//IL_31c6: Expected Obj, but got I
		//IL_24eb: Expected Obj, but got I4
		//IL_35a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35a8: Expected VT, but got Unknown
		//IL_35bb: Expected VT, but got I8
		//IL_35cb: Expected Obj, but got I
		//IL_35f5: Expected Obj, but got I4
		//IL_31ab: Expected Obj, but got I
		//IL_25f0: Expected Obj, but got I4
		//IL_31fc: Expected Obj, but got I
		//IL_25a9: Expected Obj, but got I4
		//IL_31e1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF280]");
		object s = 0;
		GillaBoardLook.Frame(px, 512, 256, 3);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF498]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF428]");
		object obj10 = 0;
		ScreenFont font = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v5+A0]");
		Text(font, 10, 6, (string)s, (Color32[])0, 2, centred: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj3;
		string text = (string)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v9+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+18]");
		int x = (int)((nint)0 + (nint)6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+1C]");
		int y = (int)((nint)0 + (nint)5);
		ScreenFont font2 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+B0]");
		Text(font2, x, y, (string)obj7, (Color32[])0, 1, centred: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj10);
		Clipped((RectInt)128849018890L, (Action)816043786356L);
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v13+18]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v13+18]");
		object obj20 = -5;
		bool flag4 = (nint)obj20 < 0;
		bool flag5 = obj20 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v13+18]");
		object obj21 = (nint)0 ^ (nint)5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v13+18]");
		object obj22 = 0 ^ obj20;
		object obj23 = obj21 & obj22;
		bool flag6 = (nint)obj23 < 0;
		bool flag7 = flag4 == flag6;
		object obj24 = !flag5;
		object obj25 = flag7 & obj24;
		object obj26 = ~obj25;
		if (obj26 != null)
		{
			obj19 = 5;
		}
		object obj27 = 920 / obj19;
		object obj28 = obj27 - 8;
		bool flag8 = (nint)obj28 < 0;
		bool flag9 = obj28 == null;
		object obj29 = obj27 ^ 8;
		object obj30 = obj27 ^ obj28;
		object obj31 = obj29 & obj30;
		bool flag10 = (nint)obj31 < 0;
		bool flag11 = flag8 == flag10;
		object obj32 = !flag9;
		object obj33 = flag11 & obj32;
		object obj34 = ~obj33;
		object obj35 = ((obj34 != null) ? ((object)8) : obj27);
		object obj36 = 184 - obj35;
		float num = barAt * (float)obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj37 = 0;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v17+E4]");
		bool flag12 = (nint)0 == 0;
		object obj39 = !flag12;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF430]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num3 = default;
		double num4;
		double num2;
		double num5;
		if (num < 0f)
		{
			if ((double)num == -0.5)
			{
				num2 = num3;
				num4 = -1.0;
				goto IL_27fd;
			}
			num2 = (double)num + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num5 = -0.5;
		}
		else
		{
			if ((double)num == 0.5)
			{
				num2 = num3;
				num4 = 1.0;
				goto IL_27fd;
			}
			num2 = (double)num + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num5 = 0.5;
		}
		goto IL_2847;
		IL_2616:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_1bb9:
		object obj41 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X0_v171+E4]");
		bool flag13 = (nint)0 == 0;
		object obj42 = !flag13;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj43 = 0;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1658 @ X0_v173+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj46 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7C0]");
		num5 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1691 @ X8_v159+A0]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1682 @ X8_v160+68]");
		num2 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1682 @ X8_v160+68]");
		double num6 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7C0]");
		double num7 = num6 + 0.0;
		int num9;
		int num8 = num9;
		string text3;
		string text2 = text3;
		goto IL_2d6b;
		IL_212b:
		object obj48 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1949 @ X0_v136+E4]");
		bool flag15 = (nint)0 == 0;
		object obj49 = !flag15;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj48 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1949 @ X0_v136+A0]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1951 @ X8_v135+A0]");
		Color32[] array = (Color32[])0;
		goto IL_351a;
		IL_351a:
		Color32 color = default;
		bool flag16 = color < (object)0;
		object obj51 = color ^ color;
		object obj52 = color & obj51;
		bool flag17 = (nint)obj52 < 0;
		object obj53 = default;
		int y2 = obj53 + 26;
		bool flag18 = flag16 == flag17;
		object obj54 = !flag18;
		object obj55 = ~obj54;
		Color32 color2 = ((obj55 != null) ? color : ((Color32)(color + 1)));
		int num10 = (int)(num7 + color2);
		string text4;
		Text(this.text, num10, y2, text4, array, 2, centred: true);
		bool ok;
		bool flag19 = !ok;
		Color32[] array2 = array;
		bool flag20 = true;
		int num11 = 2;
		string text5 = text4;
		int num12 = num10;
		ScreenFont screenFont = this.text;
		if (!flag19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj56 = 0;
			object obj57 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2017 @ X0_v113+E4]");
			bool flag21 = (nint)0 == 0;
			object obj58 = !flag21;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj59 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CE0]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2079 @ X0_v116+E4]");
			bool flag22 = (nint)0 == 0;
			object obj61 = !flag22;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj59 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2079 @ X0_v116+A0]");
			object obj62 = 0;
			text5 = (string)obj60;
			y2 = obj53 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2042 @ X8_v117+A0]");
			array2 = (Color32[])0;
			ScreenFont font3 = this.text;
			int y3 = y2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2042 @ X8_v117+A0]");
			Text(font3, num10, y3, (string)obj60, (Color32[])0, 1, centred: true);
			flag20 = true;
			num11 = 1;
			num12 = num10;
			screenFont = this.text;
		}
		if (!(banner > 0f))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj63 = 0;
		object obj64 = obj63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2057 @ X0_v84+E4]");
		bool flag23 = (nint)0 == 0;
		object obj65 = !flag23;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj66 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X0_v87+E4]");
		bool flag24 = (nint)0 == 0;
		object obj67 = !flag24;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj66 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X0_v87+A0]");
		object obj68 = 0;
		Color32 c = (Color32)(typeof(_0021_00210) | 0x1800000000L);
		FillRect((RectInt)481036337294L, c);
		object obj69 = obj3;
		if (~(bannerBad ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v104+E4]");
			bool flag25 = (nint)0 == 0;
			object obj70 = !flag25;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj69 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v104+A0]");
			object obj71 = (nint)0 + (nint)148;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v104+E4]");
			bool flag26 = (nint)0 == 0;
			object obj72 = !flag26;
			if (obj72 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj69 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v104+A0]");
			object obj71 = (nint)0 + (nint)128;
		}
		Color32 c2 = (Color32)(typeof(_0021_00210) | 0x1800000000L);
		Outline((RectInt)481036337294L, c2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj73 = 0;
		object obj74 = obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ X0_v92+E4]");
		bool flag27 = (nint)0 == 0;
		object obj75 = !flag27;
		if (obj75 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj76 = obj3;
		object colours;
		if (~(bannerBad ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2145 @ X0_v97+E4]");
			bool flag28 = (nint)0 == 0;
			object obj77 = !flag28;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj76 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2145 @ X0_v97+A0]");
			colours = (nint)0 + (nint)184;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2145 @ X0_v97+E4]");
			bool flag29 = (nint)0 == 0;
			object obj78 = !flag29;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj76 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2145 @ X0_v97+A0]");
			colours = (nint)0 + (nint)160;
		}
		Text(this.text, 253, 118, bannerText, (Color32[])colours, 2, centred: true);
		return;
		IL_2d6b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj79 = 0;
		object obj80 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ X0_v65+E4]");
		bool flag30 = (nint)0 == 0;
		object obj81 = !flag30;
		if (obj81 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num13 = holdFill * (float)color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj82 = 0;
		object obj83 = obj82;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X0_v68+E4]");
		bool flag31 = (nint)0 == 0;
		object obj84 = !flag31;
		if (obj84 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num14;
		double num15;
		double num16;
		double num17;
		if (num13 < 0f)
		{
			if ((double)num13 == -0.5)
			{
				num14 = num3;
				num15 = -1.0;
				goto IL_2e20;
			}
			num14 = (double)num13 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num16 = num7;
			num17 = -0.5;
		}
		else
		{
			if ((double)num13 == 0.5)
			{
				num14 = num3;
				num15 = 1.0;
				goto IL_2e20;
			}
			num14 = (double)num13 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num16 = num7;
			num17 = 0.5;
		}
		goto IL_2e72;
		IL_2b3e:
		object obj85;
		ScreenFont screenFont2 = (ScreenFont)obj85;
		object obj87;
		object obj86 = obj87 + 80;
		obj86 = obj85;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X20_v12+18]");
		bool flag32 = (nint)0 < (nint)1;
		Color32[] array4;
		Color32[] array3 = array4;
		bool flag33 = false;
		int num18 = 1;
		if (flag32)
		{
			goto IL_16d3;
		}
		object obj88 = obj87 + 32;
		object obj89 = 20;
		object obj90 = 0;
		bool flag34 = false;
		int num19 = 1;
		string text7;
		string text6 = text7;
		int num21;
		int num20 = num21;
		int num23;
		int num22 = num23;
		ScreenFont screenFont3 = (ScreenFont)obj85;
		while (true)
		{
			object obj91 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1463 @ X0_v197+E4]");
			bool flag35 = (nint)0 == 0;
			object obj92 = !flag35;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj93 = 0;
			object obj94 = obj93;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X0_v199+E4]");
			bool flag36 = (nint)0 == 0;
			object obj95 = !flag36;
			if (obj95 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj96 = obj90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X20_v12+18]");
			bool flag37 = (nint)obj96 < 0;
			object obj97 = !flag37;
			if (obj97 != null)
			{
				break;
			}
			object obj98 = obj3;
			bool flag38 = (nint)obj90 < 4;
			object obj99 = !flag38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X0_v201+A0]");
			object obj100 = 0;
			object obj103;
			if (obj99 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X0_v201+E4]");
				bool flag39 = (nint)0 == 0;
				object obj101 = !flag39;
				if (obj101 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj102 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v186+A0]");
					obj100 = 0;
				}
				obj103 = obj100 + 160;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X0_v201+E4]");
				bool flag40 = (nint)0 == 0;
				object obj104 = !flag40;
				if (obj104 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj105 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1549 @ X8_v182+A0]");
					obj100 = 0;
				}
				obj103 = obj100 + 176;
			}
			array3 = (Color32[])obj103;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1535 @ X8_v180+48]");
			num23 = (int)((nint)0 + (nint)6);
			object obj106 = obj89;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1535 @ X8_v180+4C]");
			num21 = obj106 + 0;
			ScreenFont font4 = this.text;
			int x2 = num23;
			int y4 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X29_v8+v964 @ X28_v6*8]");
			Text(font4, x2, y4, (string)0, (Color32[])obj103, 1, centred: false);
			obj90++;
			obj89 += 11;
			object obj107 = obj90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X20_v12+18]");
			bool flag41 = (nint)obj107 < 0;
			flag33 = false;
			num18 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X29_v8+v964 @ X28_v6*8]");
			text7 = (string)0;
			screenFont2 = this.text;
			array4 = (Color32[])obj103;
			flag34 = false;
			num19 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X29_v8+v964 @ X28_v6*8]");
			text6 = (string)0;
			num20 = num21;
			num22 = num23;
			screenFont3 = this.text;
			if (flag41)
			{
				continue;
			}
			goto IL_16d3;
		}
		goto IL_2616;
		IL_2e72:
		object obj110 = default;
		RectInt r;
		int num24;
		if (ok)
		{
			num17 = holdFill;
			bool flag42 = !(holdFill > 0f);
			Color32 color3 = (Color32)num8;
			RectInt rectInt = (RectInt)text2;
			if (!flag42)
			{
				object obj108 = obj3;
				object obj109 = obj110 << 32;
				RectInt rectInt2 = (RectInt)(num16 | obj53);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1858 @ X0_v161+E4]");
				bool flag43 = (nint)0 == 0;
				object obj111 = !flag43;
				if (obj111 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj108 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1858 @ X0_v161+A0]");
				object obj112 = 0;
				color3 = (Color32)(obj109 | num14);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1844 @ X8_v151+84]");
				num24 = 0;
				FillRect(rectInt2, color3);
				num16 = num7;
				rectInt = rectInt2;
			}
			object obj113 = obj3;
			r = (RectInt)(num16 | obj53);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1861 @ X0_v157+E4]");
			bool flag44 = (nint)0 == 0;
			object obj114 = !flag44;
			if (obj114 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj113 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1861 @ X0_v157+A0]");
			object obj115 = (nint)0 + (nint)128;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD08]");
			object obj116 = 0;
			r = (RectInt)(num16 | obj53);
			bool flag45 = text4 == (string)obj116;
			object obj117 = obj3;
			if (flag45)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ X0_v149+E4]");
				bool flag46 = (nint)0 == 0;
				object obj118 = !flag46;
				if (obj118 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj117 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ X0_v149+A0]");
				object obj115 = (nint)0 + (nint)148;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ X0_v149+E4]");
				bool flag47 = (nint)0 == 0;
				object obj119 = !flag47;
				if (obj119 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj117 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ X0_v149+A0]");
				object obj115 = (nint)0 + (nint)152;
			}
		}
		Outline(r, color);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj120 = 0;
		object obj121 = obj120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X0_v74+E4]");
		bool flag48 = (nint)0 == 0;
		object obj122 = !flag48;
		if (obj122 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj123 = obj3;
		object obj124 = obj53 + 2;
		object obj125 = color - 4;
		object obj126 = obj110 - 4;
		Color32 c3 = (Color32)(obj125 | obj126);
		double num25 = num7 + 2.0;
		RectInt r2 = (RectInt)(num25 | obj124);
		if (ok)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1916 @ X0_v139+E4]");
			bool flag49 = (nint)0 == 0;
			object obj127 = !flag49;
			if (obj127 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj123 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1916 @ X0_v139+A0]");
			object obj128 = (nint)0 + (nint)132;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1916 @ X0_v139+E4]");
			bool flag50 = (nint)0 == 0;
			object obj129 = !flag50;
			if (obj129 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj123 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1916 @ X0_v139+A0]");
			object obj128 = (nint)0 + (nint)136;
		}
		Outline(r2, c3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj130 = 0;
		object obj131 = obj130;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1928 @ X0_v79+E4]");
		if ((nint)0 != 0)
		{
			if (ok)
			{
				goto IL_212b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag51 = !ok;
			object obj132 = !flag51;
			if (obj132 != null)
			{
				goto IL_212b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD08]");
		object obj133 = 0;
		if (text4 == (string)obj133)
		{
			object obj134 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1969 @ X0_v130+E4]");
			bool flag52 = (nint)0 == 0;
			object obj135 = !flag52;
			if (obj135 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj134 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1969 @ X0_v130+A0]");
			object obj136 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1974 @ X8_v133+B8]");
			array = (Color32[])0;
			goto IL_351a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj138 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v125+E4]");
		bool flag53 = (nint)0 == 0;
		object obj139 = !flag53;
		if (obj139 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj138 = obj3;
		}
		Color32[] array5 = default;
		if (array5.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v125+A0]");
			object obj140 = 0;
			bool flag54 = array5.Length == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2047 @ X8_v126+98]");
			_ = 0;
			if (!flag54)
			{
				object obj141 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2076 @ X8_v128+A0]");
				object obj142 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X8_v129+98]");
				_ = 0;
				array = array5;
				goto IL_351a;
			}
		}
		goto IL_2616;
		IL_2e20:
		num17 = num14 + num15;
		object obj143 = num14 & 1;
		bool flag55 = obj143 == null;
		object obj144 = !flag55;
		if (obj144 != null)
		{
			num14 = num17;
		}
		num16 = num7;
		goto IL_2e72;
		IL_2847:
		object obj145 = obj3;
		Color32 c4 = (Color32)(3 | obj35);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X9_v6+A0]");
		object obj146 = 0;
		double num26 = num2 + 32.0;
		RectInt r3 = (RectInt)(4 | num26);
		FillRect(r3, c4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(this, (IntPtr)obj40);
		Clipped((RectInt)115964117123L, (Action)927712936184L);
		List<byte> list = shown;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v28 (System.Collections.Generic.List`1<System.Byte>)+18]");
		bool flag56 = (nint)0 == 0;
		object obj147 = !flag56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+B0]");
		Color32[] array6 = (Color32[])0;
		bool flag57 = false;
		int num27 = 1;
		int num28 = (int)action2;
		int num29 = 248;
		ScreenFont screenFont4 = (ScreenFont)115964117123L;
		if (obj147 == null)
		{
			object obj148 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v291+E4]");
			bool flag58 = (nint)0 == 0;
			object obj149 = !flag58;
			if (obj149 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag59 = IsSaved(category);
			bool flag60 = !flag59;
			object obj150 = !flag60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+B0]");
			array6 = (Color32[])0;
			flag57 = false;
			num27 = 1;
			num28 = (int)action2;
			num29 = 248;
			screenFont4 = (ScreenFont)115964117123L;
			if (obj150 == null)
			{
				object obj151 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X0_v295+E4]");
				bool flag61 = (nint)0 == 0;
				object obj152 = !flag61;
				if (obj152 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag62 = IsMonsters(category);
				bool flag63 = !flag62;
				object obj153 = !flag63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+B0]");
				array6 = (Color32[])0;
				flag57 = false;
				num27 = 1;
				num28 = (int)action2;
				num29 = 248;
				screenFont4 = (ScreenFont)115964117123L;
				if (obj153 == null)
				{
					object obj154 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X0_v300+E4]");
					bool flag64 = (nint)0 == 0;
					object obj155 = !flag64;
					if (obj155 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj154 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X0_v300+A0]");
					object obj156 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4B8]");
					object s2 = 0;
					ScreenFont font5 = this.text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v283+A0]");
					Text(font5, 256, 112, (string)s2, (Color32[])0, 1, centred: true);
					object obj157 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X8_v284+A0]");
					object obj158 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF490]");
					object obj159 = 0;
					screenFont4 = this.text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v285+B0]");
					array6 = (Color32[])0;
					text = (string)obj159;
					ScreenFont font6 = this.text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v285+B0]");
					Text(font6, 256, 126, (string)obj159, (Color32[])0, 1, centred: true);
					flag57 = true;
					num27 = 1;
					num28 = 126;
					num29 = 256;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj160 = 0;
		int num30 = MaxScroll();
		bool flag65 = num30 < 1;
		Color32[] array7 = array6;
		if (!flag65)
		{
			object obj161 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E8]");
			object obj162 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2F0]");
			object obj163 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v261+E4]");
			bool flag66 = (nint)0 == 0;
			object obj164 = !flag66;
			if (obj164 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj161 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v261+A0]");
			object obj165 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v255+28]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v255+30]");
			Button((RectInt)num31, (string)0, (string)obj160, (int)obj162);
			object obj166 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v256+A0]");
			object obj167 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v257+28]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v257+30]");
			Arrow((RectInt)num32, up: false);
			object obj168 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v258+A0]");
			object obj169 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v259+38]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v259+40]");
			Button((RectInt)num33, (string)0, (string)obj160, (int)obj163);
			object obj170 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v260+A0]");
			object obj171 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X8_v261+38]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X8_v261+40]");
			Arrow((RectInt)num34, up: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj172 = 0;
			object obj173 = obj172;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X0_v266+E4]");
			bool flag67 = (nint)0 == 0;
			object obj174 = !flag67;
			if (obj174 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj175 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v265+A0]");
			object obj176 = 0;
			int num35 = default;
			string text8 = num35.ToString();
			object obj177 = obj3;
			string s3 = (string)((text8 != null) ? text8 : obj160);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1230 @ X0_v271+E4]");
			bool flag68 = (nint)0 == 0;
			object obj178 = !flag68;
			if (obj178 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj177 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1230 @ X0_v271+A0]");
			object obj179 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v266+28]");
			int x3 = (int)((nint)0 + (nint)8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
			object s4 = 0;
			ScreenFont font7 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v269+A0]");
			Text(font7, x3, 112, s3, (Color32[])0, 1, centred: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj180 = 0;
			object obj181 = obj180;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ X0_v273+E4]");
			bool flag69 = (nint)0 == 0;
			object obj182 = !flag69;
			if (obj182 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj183 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X8_v273+A0]");
			object obj184 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v274+28]");
			int x4 = (int)((nint)0 + (nint)8);
			ScreenFont font8 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v274+A0]");
			Text(font8, x4, 122, (string)s4, (Color32[])0, 1, centred: true);
			object obj185 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X8_v275+A0]");
			object obj186 = 0;
			int num36 = MaxScroll();
			string text9 = num35.ToString();
			object obj187 = obj3;
			string text10 = (string)((text9 != null) ? text9 : obj160);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ X0_v281+E4]");
			bool flag70 = (nint)0 == 0;
			object obj188 = !flag70;
			if (obj188 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj187 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ X0_v281+A0]");
			object obj189 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1280 @ X8_v276+28]");
			num29 = (int)((nint)0 + (nint)8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v279+A0]");
			array7 = (Color32[])0;
			ScreenFont font9 = this.text;
			int x5 = num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v279+A0]");
			Text(font9, x5, 132, text10, (Color32[])0, 1, centred: true);
			flag57 = true;
			num27 = 1;
			text = text10;
			num28 = 132;
			screenFont4 = this.text;
		}
		object obj190 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v30+E4]");
		bool flag71 = (nint)0 == 0;
		object obj191 = !flag71;
		if (obj191 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj190 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v30+A0]");
		object obj192 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF478]");
		object obj193 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v33+48]");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v33+50]");
		Outline((RectInt)num37, (Color32)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj194 = 0;
		object obj195 = obj194;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v32+E4]");
		bool flag72 = (nint)0 == 0;
		object obj196 = !flag72;
		if (obj196 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj197 = obj3;
		text7 = (string)obj193;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v37+A0]");
		object obj198 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v38+A0]");
		array4 = (Color32[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v38+48]");
		num23 = (int)((nint)0 + (nint)6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v38+4C]");
		num21 = (int)((nint)0 + (nint)5);
		ScreenFont font10 = this.text;
		int x6 = num23;
		int y5 = num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v38+A0]");
		Text(font10, x6, y5, (string)obj193, (Color32[])0, 1, centred: false);
		if (IsSaved(category))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj199 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v244+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4A0]");
				object obj200 = 0;
				object obj202 = default;
				object obj201 = obj202 + 32;
				obj201 = obj200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ X21_v51-8]");
				object obj203 = 0 & 0xFFFFFFFEL;
				if (obj203 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF480]");
					object obj204 = 0;
					object obj205 = obj202 + 40;
					obj205 = obj204;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X21_v53-10]");
					bool flag73 = (nint)0 < (nint)2;
					object obj206 = !flag73;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X21_v53-10]");
					object obj207 = -2;
					bool flag74 = obj207 == null;
					object obj208 = ~obj206;
					object obj209 = obj208 | flag74;
					if (obj209 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4D0]");
						object obj210 = 0;
						object obj211 = obj202 + 48;
						obj211 = obj210;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X21_v55-18]");
						object obj212 = 0 & 0xFFFFFFFCL;
						if (obj212 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF468]");
							object obj213 = 0;
							object obj214 = obj202 + 56;
							obj214 = obj213;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X21_v57-20]");
							bool flag75 = (nint)0 < (nint)4;
							object obj215 = !flag75;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X21_v57-20]");
							object obj216 = -4;
							bool flag76 = obj216 == null;
							object obj217 = ~obj215;
							object obj218 = obj217 | flag76;
							if (obj218 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4D8]");
								object obj219 = 0;
								object obj220 = obj202 + 64;
								obj220 = obj219;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X21_v59-28]");
								bool flag77 = (nint)0 < (nint)5;
								object obj221 = !flag77;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X21_v59-28]");
								object obj222 = -5;
								bool flag78 = obj222 == null;
								object obj223 = ~obj221;
								object obj224 = obj223 | flag78;
								if (obj224 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4B0]");
									object obj225 = 0;
									object obj226 = obj202 + 72;
									obj226 = obj225;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X21_v61-30]");
									bool flag79 = (nint)0 < (nint)6;
									object obj227 = !flag79;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X21_v61-30]");
									object obj228 = -6;
									bool flag80 = obj228 == null;
									object obj229 = ~obj227;
									object obj230 = obj229 | flag80;
									if (obj230 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF488]");
										obj85 = 0;
										obj87 = obj202;
										goto IL_2b3e;
									}
								}
							}
						}
					}
				}
			}
		}
		else
		{
			object obj231 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X0_v212+E4]");
			bool flag81 = (nint)0 == 0;
			object obj232 = !flag81;
			if (obj232 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag82 = IsMonsters(category);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj233 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj236 = default;
			if (flag82)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v217+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4A8]");
					object obj234 = 0;
					object obj235 = obj236 + 32;
					obj235 = obj234;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X21_v39-8]");
					object obj237 = 0 & 0xFFFFFFFEL;
					if (obj237 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF458]");
						object obj238 = 0;
						object obj239 = obj236 + 40;
						obj239 = obj238;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X21_v41-10]");
						bool flag83 = (nint)0 < (nint)2;
						object obj240 = !flag83;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X21_v41-10]");
						object obj241 = -2;
						bool flag84 = obj241 == null;
						object obj242 = ~obj240;
						object obj243 = obj242 | flag84;
						if (obj243 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4C0]");
							object obj244 = 0;
							object obj245 = obj236 + 48;
							obj245 = obj244;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X21_v43-18]");
							object obj246 = 0 & 0xFFFFFFFCL;
							if (obj246 != null)
							{
								object obj247 = obj236 + 56;
								obj247 = obj160;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X21_v45-20]");
								bool flag85 = (nint)0 < (nint)4;
								object obj248 = !flag85;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X21_v45-20]");
								object obj249 = -4;
								bool flag86 = obj249 == null;
								object obj250 = ~obj248;
								object obj251 = obj250 | flag86;
								if (obj251 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4C8]");
									object obj252 = 0;
									object obj253 = obj236 + 64;
									obj253 = obj252;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X21_v47-28]");
									bool flag87 = (nint)0 < (nint)5;
									object obj254 = !flag87;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X21_v47-28]");
									object obj255 = -5;
									bool flag88 = obj255 == null;
									object obj256 = ~obj254;
									object obj257 = obj256 | flag88;
									if (obj257 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC518]");
										object obj258 = 0;
										object obj259 = obj236 + 72;
										obj259 = obj258;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X21_v49-30]");
										bool flag89 = (nint)0 < (nint)6;
										object obj260 = !flag89;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X21_v49-30]");
										object obj261 = -6;
										bool flag90 = obj261 == null;
										object obj262 = ~obj260;
										object obj263 = obj262 | flag90;
										if (obj263 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF450]");
											obj85 = 0;
											obj87 = obj236;
											goto IL_2b3e;
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v217+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF440]");
					object obj264 = 0;
					object obj265 = obj236 + 32;
					obj265 = obj264;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X21_v27-8]");
					object obj266 = 0 & 0xFFFFFFFEL;
					if (obj266 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF460]");
						object obj267 = 0;
						object obj268 = obj236 + 40;
						obj268 = obj267;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X21_v29-10]");
						bool flag91 = (nint)0 < (nint)2;
						object obj269 = !flag91;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X21_v29-10]");
						object obj270 = -2;
						bool flag92 = obj270 == null;
						object obj271 = ~obj269;
						object obj272 = obj271 | flag92;
						if (obj272 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF458]");
							object obj273 = 0;
							object obj274 = obj236 + 48;
							obj274 = obj273;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X21_v31-18]");
							object obj275 = 0 & 0xFFFFFFFCL;
							if (obj275 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF470]");
								object obj276 = 0;
								object obj277 = obj236 + 56;
								obj277 = obj276;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X21_v33-20]");
								bool flag93 = (nint)0 < (nint)4;
								object obj278 = !flag93;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X21_v33-20]");
								object obj279 = -4;
								bool flag94 = obj279 == null;
								object obj280 = ~obj278;
								object obj281 = obj280 | flag94;
								if (obj281 == null)
								{
									object obj282 = obj236 + 64;
									obj282 = obj160;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X21_v35-28]");
									bool flag95 = (nint)0 < (nint)5;
									object obj283 = !flag95;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X21_v35-28]");
									object obj284 = -5;
									bool flag96 = obj284 == null;
									object obj285 = ~obj283;
									object obj286 = obj285 | flag96;
									if (obj286 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF438]");
										object obj287 = 0;
										object obj288 = obj236 + 72;
										obj288 = obj287;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X21_v37-30]");
										bool flag97 = (nint)0 < (nint)6;
										object obj289 = !flag97;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X21_v37-30]");
										object obj290 = -6;
										bool flag98 = obj290 == null;
										object obj291 = ~obj289;
										object obj292 = obj291 | flag98;
										if (obj292 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF448]");
											obj85 = 0;
											obj87 = obj236;
											goto IL_2b3e;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_2616;
		IL_16d3:
		object obj293 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X0_v43+E4]");
		bool flag99 = (nint)0 == 0;
		object obj294 = !flag99;
		if (obj294 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj293 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X0_v43+A0]");
		object obj295 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj296 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X8_v43+58]");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X8_v43+60]");
		Outline((RectInt)num38, (Color32)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj297 = 0;
		object obj298 = obj297;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X0_v45+E4]");
		bool flag100 = (nint)0 == 0;
		object obj299 = !flag100;
		if (obj299 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj300 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X8_v47+A0]");
		object obj301 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v48+58]");
		int x7 = (int)((nint)0 + (nint)6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v48+5C]");
		int y6 = (int)((nint)0 + (nint)5);
		CoinIcon(x7, y6);
		object obj302 = obj3;
		object obj303 = obj296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X8_v50+A0]");
		object obj304 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1513 @ X0_v48+E4]");
		bool flag101 = (nint)0 == 0;
		object obj305 = !flag101;
		if (obj305 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string s5 = Coins.Text;
		object obj306 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1538 @ X8_v52+A0]");
		object obj307 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1542 @ X8_v53+60]");
		int width = (int)(-22);
		string s6 = Fit(s5, width, 1);
		object obj308 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1560 @ X8_v56+E4]");
		bool flag102 = (nint)0 == 0;
		object obj309 = !flag102;
		if (obj309 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj308 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1560 @ X8_v56+A0]");
		object obj310 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1515 @ X8_v51+58]");
		int x8 = (int)((nint)0 + (nint)17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1515 @ X8_v51+5C]");
		int y7 = (int)((nint)0 + (nint)5);
		ScreenFont font11 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ X8_v57+30]");
		Text(font11, x8, y7, s6, (Color32[])0, 1, centred: false);
		object obj311 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1571 @ X8_v58+A0]");
		object obj312 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X8_v59+58]");
		int x9 = (int)((nint)0 + (nint)6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X8_v59+5C]");
		int y8 = (int)((nint)0 + (nint)19);
		BoltIcon(x9, y8);
		object obj313 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X8_v61+A0]");
		object obj314 = 0;
		string boltsText = Coins.BoltsText;
		object obj315 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1581 @ X8_v63+A0]");
		object obj316 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1585 @ X8_v64+60]");
		int width2 = (int)(-22);
		string s7 = Fit(boltsText, width2, 1);
		object obj317 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1579 @ X8_v62+58]");
		num8 = (int)((nint)0 + (nint)17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1579 @ X8_v62+5C]");
		num24 = (int)((nint)0 + (nint)19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1589 @ X8_v66+A0]");
		object obj318 = 0;
		ScreenFont font12 = this.text;
		int x10 = num8;
		int y9 = num24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X8_v67+A0]");
		Text(font12, x10, y9, s7, (Color32[])0, 1, centred: false);
		text4 = ButtonAction(out ok);
		bool[] array8 = down;
		if (array8.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2D8]");
			object obj319 = 0;
			bool flag103 = (byte)(~(array8[0] ? 1u : 0u)) != 0;
			text2 = (string)(&ok);
			if (!flag103)
			{
				string[] array9 = downOn;
				if (array9.Length == 0)
				{
					goto IL_2616;
				}
				text3 = (string)obj319;
				bool flag104 = array9[0] == (string)obj319;
				bool flag105 = !flag104;
				object obj320 = !flag105;
				num9 = 0;
				if (obj320 != null)
				{
					goto IL_1bb9;
				}
				array8 = down;
				num8 = 0;
				text2 = (string)obj319;
			}
			object obj321 = array8.Length & 0xFFFFFFFEL;
			if (obj321 != null)
			{
				if (~(array8[1] ? 1u : 0u) == 0)
				{
					string[] array10 = downOn;
					object obj322 = array10.Length & 0xFFFFFFFEL;
					if (obj322 == null)
					{
						goto IL_2616;
					}
					text2 = (string)obj319;
					bool flag106 = array10[1] == (string)obj319;
					bool flag107 = !flag106;
					object obj323 = !flag107;
					num8 = 0;
					num9 = 0;
					text3 = (string)obj319;
					if (obj323 != null)
					{
						goto IL_1bb9;
					}
				}
				if (~(mouseDown ? 1u : 0u) == 0)
				{
					text3 = (string)obj319;
					bool flag108 = hovered == (string)obj319;
					bool flag109 = !flag108;
					num9 = 0;
					num8 = 0;
					text2 = (string)obj319;
					if (!flag109)
					{
						goto IL_1bb9;
					}
				}
				object obj324 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X0_v181+E4]");
				bool flag110 = (nint)0 == 0;
				object obj325 = !flag110;
				if (obj325 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj324 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X0_v181+A0]");
				object obj326 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1652 @ X8_v166+68]");
				num7 = 0.0;
				goto IL_2d6b;
			}
		}
		goto IL_2616;
		IL_27fd:
		num5 = num2 + num4;
		object obj327 = num2 & 1;
		bool flag111 = obj327 == null;
		object obj328 = !flag111;
		if (obj328 != null)
		{
			num2 = num5;
		}
		goto IL_2847;
	}

	private void DrawTile(Tile t, RectInt place, int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1090: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_10ae: Expected Obj, but got I
		//IL_10d8: Expected Obj, but got I4
		//IL_00f6: Invalid comparison between VT and I4
		//IL_0158: Invalid comparison between VT and F8
		//IL_011a: Invalid comparison between VT and F8
		//IL_150c: Expected Obj, but got VT
		//IL_152e: Expected Obj, but got I4
		//IL_10fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1103: Expected Obj, but got Unknown
		//IL_111d: Expected Obj, but got I4
		//IL_029f: Invalid comparison between I and F8
		//IL_1133: Expected VT, but got F8
		//IL_0259: Invalid comparison between I and F8
		//IL_1194: Expected Obj, but got VT
		//IL_0389: Expected I4, but got I8
		//IL_03a3: Expected Obj, but got I4
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected Obj, but got Unknown
		//IL_1174: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected VT, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected VT, but got Unknown
		//IL_044c: Expected Obj, but got I
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected VT, but got Unknown
		//IL_05a7: Expected Obj, but got I4
		//IL_05d8: Expected Obj, but got I4
		//IL_0617: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected VT, but got Unknown
		//IL_06c9: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I
		//IL_052a: Expected I, but got Obj
		//IL_06f4: Invalid comparison between F4 and I4
		//IL_0705: Expected Obj, but got I4
		//IL_0713: Invalid comparison between F4 and I4
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_0738: Expected F8, but got I4
		//IL_11e2: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected Obj, but got Unknown
		//IL_121b: Expected Obj, but got I
		//IL_1245: Expected Obj, but got I4
		//IL_0948: Expected Obj, but got I4
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1260: Expected I4, but got Unknown
		//IL_1279: Expected Obj, but got I4
		//IL_0c4d: Expected Obj, but got I
		//IL_0993: Expected Obj, but got I8
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected Obj, but got Unknown
		//IL_09e0: Expected Obj, but got I4
		//IL_0a05: Expected Obj, but got I8
		//IL_0a0e: Expected Obj, but got I4
		//IL_0b3c: Expected Obj, but got I
		//IL_0b54: Expected Obj, but got I
		//IL_0b76: Expected Obj, but got I4
		//IL_1304: Expected Obj, but got I
		//IL_132e: Expected Obj, but got I4
		//IL_0c7a: Expected Obj, but got I
		//IL_0ca4: Expected Obj, but got I4
		//IL_0ba3: Expected Obj, but got I
		//IL_0bc5: Expected Obj, but got I4
		//IL_12b0: Expected Obj, but got I4
		//IL_0bf1: Expected Obj, but got I
		//IL_0a27: Expected Obj, but got I4
		//IL_13a3: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I
		//IL_0da4: Expected Obj, but got I4
		//IL_0cfd: Expected Obj, but got I4
		//IL_0ada: Expected Obj, but got I4
		//IL_1406: Expected Obj, but got I
		//IL_1430: Expected Obj, but got I4
		//IL_0d73: Expected Obj, but got I4
		//IL_13f1: Expected Obj, but got I
		//IL_0c18: Expected Obj, but got I4
		//IL_12ef: Expected Obj, but got I
		//IL_0a83: Expected Obj, but got I4
		//IL_0e09: Expected Obj, but got I4
		//IL_1665: Expected I4, but got F8
		//IL_138e: Expected Obj, but got I
		//IL_155e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1563: Expected I4, but got Unknown
		//IL_1591: Expected Obj, but got I
		//IL_159b: Expected Obj, but got I4
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a9: Expected Obj, but got Unknown
		//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b7: Expected Obj, but got Unknown
		//IL_15d7: Expected Obj, but got I
		//IL_1613: Expected Obj, but got I
		//IL_0b02: Expected Obj, but got I
		//IL_12d4: Expected Obj, but got I
		//IL_0aab: Expected Obj, but got I
		//IL_0e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected Obj, but got Unknown
		//IL_0f79: Expected Obj, but got I
		//IL_0fa3: Expected Obj, but got I4
		//IL_148c: Expected Obj, but got I
		//IL_0e69: Expected Obj, but got I
		//IL_0e93: Expected Obj, but got I4
		//IL_0f1e: Expected Obj, but got I4
		//IL_1684: Unknown result type (might be due to invalid IL or missing references)
		//IL_1689: Expected Obj, but got Unknown
		//IL_16b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b5: Expected VT, but got Unknown
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected VT, but got Unknown
		//IL_16e5: Expected Obj, but got I
		//IL_170f: Expected Obj, but got I4
		//IL_1471: Expected Obj, but got I
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe5: Expected I4, but got Unknown
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Expected I4, but got Unknown
		//IL_102b: Expected Obj, but got I4
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f40: Expected Obj, but got Unknown
		//IL_14a1: Expected Obj, but got I
		//IL_14aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_14af: Expected I4, but got Unknown
		//IL_14b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bd: Expected I4, but got Unknown
		//IL_14cd: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Has(t))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (t == null)
		{
			goto IL_1051;
		}
		Vector2 vector = t.at;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num;
		double num3 = default;
		double num2;
		double num4;
		if (vector < (object)0)
		{
			if (vector == (Vector2)(object)(-0.5))
			{
				num = -1.0;
				num2 = num3;
				goto IL_10e6;
			}
			num2 = (double)vector + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num4 = -0.5;
		}
		else
		{
			if (vector == (Vector2)(object)0.5)
			{
				num = 1.0;
				num2 = num3;
				goto IL_10e6;
			}
			num2 = (double)vector + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num4 = 0.5;
		}
		goto IL_14f6;
		IL_0b0f:
		bool flag4;
		bool flag7;
		int num6;
		double num7;
		Color32[] colours;
		bool centred;
		int scale;
		string s;
		int y;
		ScreenFont font;
		int x;
		int num9;
		if (flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X0_v79+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF378]");
			object obj14 = 0;
			object obj15 = obj12;
			bool flag6 = !flag7;
			object obj16 = !flag6;
			object obj17 = ~obj16;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4E0]");
				obj14 = 0;
			}
			double num5 = (double)num6 + num7;
			double num8 = num5 - 10.0;
			object obj19;
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v84+E4]");
				bool flag8 = (nint)0 == 0;
				object obj18 = !flag8;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v84+A0]");
				obj19 = (nint)0 + (nint)168;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v84+E4]");
				bool flag9 = (nint)0 == 0;
				object obj20 = !flag9;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v84+A0]");
				obj19 = (nint)0 + (nint)160;
			}
			colours = (Color32[])obj19;
			centred = true;
			scale = 1;
			s = (string)obj14;
			y = (int)num8;
			font = this.text;
			x = num9;
			goto IL_171d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj21 = 0;
		Coins.Bundle bundle;
		CosmeticCatalog.Entry entry;
		CosmeticCatalog.Entry entry2;
		if (bundle != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v74+E4]");
			bool flag10 = (nint)0 == 0;
			object obj24 = !flag10;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num10 = Coins.PriceOf(bundle);
			entry = entry2;
		}
		else
		{
			if (entry2 == null)
			{
				goto IL_1051;
			}
			entry = entry2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
		object obj25 = 0;
		string text = (string)obj25;
		int num11 = default;
		string text2 = num11.ToString((string)obj25);
		object obj26;
		int num13;
		if (this.text != null)
		{
			int num12 = this.text.Measure(text2, 1);
			obj26 = num12 + 14;
			num13 = 0;
			text = text2;
			int num14 = 1;
		}
		else
		{
			int num14 = 0;
			obj26 = 40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X0_v49+E4]");
		bool flag11 = (nint)0 == 0;
		object obj29 = !flag11;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = (nint)obj26 < 0;
		object obj30 = obj26 ^ obj26;
		object obj31 = obj26 & obj30;
		bool flag13 = (nint)obj31 < 0;
		bool flag14 = flag12 == flag13;
		object obj32 = !flag14;
		object obj33 = ~obj32;
		object obj34 = ((obj33 != null) ? obj26 : ((object)(obj26 + 1)));
		bool flag15;
		if (bundle != null)
		{
			if (flag15)
			{
				goto IL_0e59;
			}
			goto IL_0f69;
		}
		if (entry != null)
		{
			byte[] array = cart;
			if (cart != null)
			{
				bool flag16 = (int)entry.slot < array.Length;
				object obj35 = !flag16;
				if (obj35 == null)
				{
					object obj36 = cart + entry.slot;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ X8_v56+20]");
					if ((nint)0 == (int)t.id)
					{
						goto IL_0e59;
					}
					goto IL_0f69;
				}
				goto IL_105f;
			}
		}
		goto IL_1051;
		IL_1187:
		RectInt rectInt = default;
		object obj37 = vector + rectInt;
		double num15;
		object obj38;
		num7 = num15 + (double)obj38;
		if (t.title >= 1)
		{
			RectInt r = (RectInt)(obj37 | num7);
			TitleTile(t, r, i);
			return;
		}
		int num16 = (int)(t.outfit & 0x80000000L);
		bool flag17 = num16 == 0;
		object obj39 = !flag17;
		if (obj39 == null)
		{
			RectInt r2 = (RectInt)(obj37 | num7);
			OutfitTile(t, r2, i);
			return;
		}
		if (t.monster >= 1)
		{
			RectInt r3 = (RectInt)(obj37 | num7);
			MonsterTile(t, r3, i);
			return;
		}
		entry2 = CosmeticCatalog.Of(t.id);
		bundle = CosmeticCatalog.BundleAt(t.bundle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj40 = 0;
		object obj41 = obj40;
		if (bundle != null)
		{
			object obj42 = t.bundle - pickedBundle;
			bool flag18 = obj42 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v27+E4]");
			bool flag19 = (nint)0 == 0;
			object obj43 = !flag19;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag20 = Coins.OwnsAll(bundle);
			List<byte> list = CosmeticCatalog.IdsOf(bundle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4758]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF328]");
			object obj45 = 0;
			Predicate<byte> predicate = default;
			predicate._002Ector((object)null, (IntPtr)obj45);
			if (list == null)
			{
				goto IL_1051;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4748]");
			object obj46 = 0;
			flag7 = list.TrueForAll(predicate);
			flag15 = flag18;
			int num17 = 0;
			Predicate<byte> predicate2 = predicate;
			flag4 = flag20;
		}
		else
		{
			object obj47 = t.id - picked;
			bool flag21 = obj47 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v27+E4]");
			bool flag22 = (nint)0 == 0;
			object obj48 = !flag22;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag23 = Coins.Owns(t.id);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj49 = 0;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v104+E4]");
			bool flag24 = (nint)0 == 0;
			object obj51 = !flag24;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag7 = Cosmetics.IsWearing(t.id);
			flag15 = flag21;
			int num17 = i;
			Predicate<byte> predicate2 = null;
			flag4 = flag23;
		}
		object obj52 = obj;
		RectInt r4 = (RectInt)(obj37 | num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X0_v30+E4]");
		bool flag25 = (nint)0 == 0;
		object obj53 = !flag25;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag26 = t.pop < 0f;
		object obj54 = !flag26;
		bool flag27 = t.pop == 0f;
		object obj55 = ~obj54;
		object obj56 = obj55 | flag27;
		double num18 = 0.0;
		double num25;
		if (obj56 == null)
		{
			bool flag28 = !((double)t.pop < 1.0);
			num18 = 1.0;
			if (!flag28)
			{
				double num19 = (double)t.pop * -10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				double num20 = (double)t.pop * 10.0;
				double num21 = num20 + -0.75;
				double num22 = num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				double num23 = num22 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				double num24 = num19 * num23;
				num18 = num24 + 1.0;
				num25 = 1.0;
			}
		}
		int num26 = default;
		string text3 = num26.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
		object obj57 = 0;
		string text4 = (string)obj57 + text3;
		bool flag29 = hovered == text4;
		TileOutline(r4, (float)num18, (byte)i != 0, flag15);
		object obj58;
		if (bundle != null)
		{
			obj58 = bundle + 24;
		}
		else
		{
			if (entry2 == null)
			{
				goto IL_1051;
			}
			obj58 = entry2 + 24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj59 = 0;
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v39+E4]");
		bool flag30 = (nint)0 == 0;
		object obj61 = !flag30;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num27 = i - 4;
		string[] array2 = Wrap((string)obj58, num27);
		if (array2 == null)
		{
			goto IL_1051;
		}
		bool flag31 = i < 0;
		int num28 = i ^ i;
		int num29 = i & num28;
		bool flag32 = num29 < 0;
		num6 = i >> 32;
		bool flag33 = flag31 == flag32;
		object obj62 = !flag33;
		object obj63 = ~obj62;
		int num30 = ((obj63 != null) ? i : (i + 1));
		num9 = obj37 + num30;
		bool flag34 = array2.Length < 1;
		string text5 = (string)flag29;
		num13 = (flag15 ? 1 : 0);
		ScreenFont screenFont = (ScreenFont)obj58;
		if (flag34)
		{
			goto IL_0b0f;
		}
		object obj64 = array2.Length & 0xFFFFFFFFL;
		object obj65 = array2 + 32;
		double num31 = (double)num6 + num7;
		double num32 = num31 - 20.0;
		bool flag36 = default;
		bool flag35 = flag36;
		int num34 = default;
		int num33 = num34;
		Color32[] array4 = default;
		Color32[] array3 = array4;
		string text6 = (string)flag29;
		bool flag37 = flag15;
		string text7 = (string)obj58;
		int num35 = num27;
		object obj66 = 4294967295L;
		object obj67 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj68 = 0;
			object obj69 = obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v92+E4]");
			bool flag38 = (nint)0 == 0;
			object obj70 = !flag38;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj64 = array2.Length;
			}
			bool flag39 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj67) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj64);
			object obj71 = !flag39;
			if (obj71 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
			object obj72 = 0;
			object obj73 = obj72;
			object obj76;
			if (flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X0_v97+E4]");
				bool flag40 = (nint)0 == 0;
				object obj74 = !flag40;
				if (obj74 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
					object obj75 = 0;
					obj73 = obj75;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X0_v97+A0]");
				obj76 = (nint)0 + (nint)168;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X0_v97+E4]");
				bool flag41 = (nint)0 == 0;
				object obj77 = !flag41;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
					object obj78 = 0;
					obj73 = obj78;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X0_v97+A0]");
				obj76 = (nint)0 + (nint)160;
			}
			object obj79 = obj66 + obj64;
			object obj80 = obj79 + obj79;
			num13 = (int)(num32 - obj80);
			ScreenFont font2 = this.text;
			int y2 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X24_v14+v621 @ X22_v12*8]");
			Text(font2, num9, y2, (string)0, (Color32[])obj76, 1, centred: true);
			obj64 = array2.Length;
			obj67++;
			obj66--;
			bool flag42 = (nint)obj67 < array2.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X24_v14+v621 @ X22_v12*8]");
			text5 = (string)0;
			screenFont = this.text;
			num27 = num9;
			flag35 = true;
			num33 = 1;
			array3 = (Color32[])obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X24_v14+v621 @ X22_v12*8]");
			text6 = (string)0;
			flag37 = (byte)num13 != 0;
			text7 = (string)(object)this.text;
			num35 = num9;
			if (flag42)
			{
				continue;
			}
			goto IL_0b0f;
		}
		goto IL_105f;
		IL_0f69:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj81 = 0;
		object obj82 = obj81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X0_v63+E4]");
		bool flag43 = (nint)0 == 0;
		object obj83 = !flag43;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj82 = obj81;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X0_v63+A0]");
		object obj84 = (nint)0 + (nint)80;
		goto IL_167c;
		IL_113d:
		double num36;
		num25 = num15 + num36;
		object obj85 = num15 & 1;
		bool flag44 = obj85 == null;
		object obj86 = !flag44;
		if (obj86 != null)
		{
			num15 = num25;
		}
		goto IL_1187;
		IL_10e6:
		num4 = num2 + num;
		object obj87 = num2 & 1;
		bool flag45 = obj87 == null;
		object obj88 = !flag45;
		double num37 = ((obj88 != null) ? num4 : num2);
		vector = (Vector2)num37;
		goto IL_14f6;
		IL_0e59:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj89 = 0;
		object obj90 = obj89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X0_v67+E4]");
		bool flag46 = (nint)0 == 0;
		object obj91 = !flag46;
		if (obj91 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj90 = obj89;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X0_v67+A0]");
		obj84 = (nint)0 + (nint)84;
		goto IL_167c;
		IL_14f6:
		object obj92 = obj7;
		obj38 = rectInt >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v19+E4]");
		bool flag47 = (nint)0 == 0;
		object obj93 = !flag47;
		if (obj93 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (CosmeticTerminal+Tile)+3C]");
		if ((nint)0 < (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (CosmeticTerminal+Tile)+3C]");
			if (0.0 == -0.5)
			{
				num36 = -1.0;
				num15 = num3;
				goto IL_113d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (CosmeticTerminal+Tile)+3C]");
			num15 = 0.0 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num25 = -0.5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (CosmeticTerminal+Tile)+3C]");
			if (0.0 == 0.5)
			{
				num36 = 1.0;
				num15 = num3;
				goto IL_113d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (CosmeticTerminal+Tile)+3C]");
			num15 = 0.0 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num25 = 0.5;
		}
		goto IL_1187;
		IL_171d:
		Text(font, x, y, s, colours, scale, centred);
		return;
		IL_167c:
		object obj94 = num9 - obj34;
		double num38 = num7 + (double)num6;
		double num39 = num38 - 11.0;
		RectInt r5 = (RectInt)(obj94 | num39);
		Color32 c = (Color32)(obj26 | 0xA00000000L);
		FillRect(r5, c);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj95 = 0;
		object obj96 = obj95;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ X0_v53+E4]");
		bool flag48 = (nint)0 == 0;
		object obj97 = !flag48;
		if (obj97 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int y3 = (int)(num38 - 10);
		int x2 = obj94 + 2;
		CoinIcon(x2, y3);
		object obj98 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X0_v57+E4]");
		bool flag49 = (nint)0 == 0;
		object obj99 = !flag49;
		if (obj99 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj98 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X0_v57+A0]");
		object obj100 = 0;
		y = (int)(num38 - 9);
		x = obj94 + 11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X8_v50+C0]");
		colours = (Color32[])0;
		centred = false;
		scale = 1;
		s = text2;
		font = this.text;
		goto IL_171d;
		IL_105f:
		throw new IndexOutOfRangeException();
		IL_1051:
		NullReferenceException ex = new NullReferenceException();
		goto IL_105f;
	}

	private void Clipped(RectInt clip, Action draw)
	{
		//IL_0043: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got VT
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected VT, but got Unknown
		//IL_018a: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_039b: Expected Obj, but got VT
		//IL_03c6: Expected Obj, but got VT
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I4
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected I4, but got Unknown
		//IL_0443: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected I4, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_04b1: Expected I4, but got Obj
		//IL_0245: Expected Obj, but got I4
		//IL_0293: Expected VT, but got Obj
		//IL_02b5: Expected Obj, but got I4
		//IL_02ed: Expected I4, but got VT
		//IL_02ed: Expected Obj, but got VT
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected I4, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected I4, but got Unknown
		Color32[] array = underneath;
		Array array2 = px;
		if (underneath != null)
		{
			int num = array.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v5 (System.Array)+18]");
			if ((nint)num == 0)
			{
				goto IL_0080;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Color32[] array3 = default;
		underneath = array3;
		object obj2 = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		array2 = px;
		goto IL_0080;
		IL_0080:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v5 (System.Array)+18]");
		int num2 = 0;
		Array sourceArray = array2;
		Color32[] destinationArray = underneath;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v5 (System.Array)+18]");
		Array.Copy(sourceArray, destinationArray, 0);
		object obj3 = (object)draw >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X3 (Il2CppMethodInfo)+28]");
		int num3 = 0;
		object obj5 = clip >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [methodInfo @ X3 (Il2CppMethodInfo)+18] (should have been resolved before IL gen)");
		object obj6 = obj3 + obj5;
		RectInt rectInt = (RectInt)(draw + clip);
		object obj7 = obj5 - obj6;
		bool flag = (nint)obj7 < 0;
		bool flag2 = obj7 == null;
		object obj8 = obj5 ^ obj6;
		object obj9 = obj5 ^ obj7;
		object obj10 = obj8 & obj9;
		bool flag3 = (nint)obj10 < 0;
		bool flag4 = flag == flag3;
		object obj11 = !flag2;
		object obj12 = flag4 & obj11;
		object obj13 = ~obj12;
		object obj14 = ((obj13 != null) ? obj6 : obj5);
		object obj15 = clip - rectInt;
		bool flag5 = (nint)obj15 < 0;
		bool flag6 = obj15 == null;
		object obj16 = clip ^ rectInt;
		object obj17 = clip ^ obj15;
		object obj18 = obj16 & obj17;
		bool flag7 = (nint)obj18 < 0;
		bool flag8 = flag5 == flag7;
		object obj19 = !flag6;
		object obj20 = flag8 & obj19;
		object obj21 = ~obj20;
		RectInt rectInt2 = ((obj21 != null) ? rectInt : clip);
		int num4 = 512 - rectInt2;
		object obj22 = 0;
		object obj23 = 0;
		RectInt rectInt3 = clip;
		int num5 = 0;
		bool flag12;
		do
		{
			object obj24 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v9+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num6 = obj23 ^ 0x1FE00;
			Array sourceArray2;
			Array array4;
			int length;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj26 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v14+E4]");
				bool flag10 = (nint)0 == 0;
				object obj27 = !flag10;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
				{
					object obj28 = obj4;
					rectInt3 = (RectInt)px;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v16+E4]");
					bool flag11 = (nint)0 == 0;
					object obj29 = !flag11;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Array.Copy(underneath, num6, (Array)rectInt3, num6, (int)clip);
					sourceArray2 = underneath;
					array4 = px;
					num3 = num6 + rectInt2;
					num5 = num6 + rectInt2;
					length = num4;
					goto IL_0462;
				}
			}
			sourceArray2 = underneath;
			array4 = px;
			length = 512;
			num5 = num6;
			num3 = num6;
			goto IL_0462;
			IL_0462:
			Array.Copy(sourceArray2, num3, array4, num5, length);
			obj22++;
			obj23 += 512;
			flag12 = (nint)obj22 != 256;
			num2 = (int)array4;
		}
		while (flag12);
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
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
			obj5 = (nint)0 + (nint)140;
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
				obj5 = (nint)0 + (nint)128;
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
				obj5 = (nint)0 + (nint)132;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v57+8C]");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v47+8C]");
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
						obj77 = (nint)0 + (nint)140;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v42+80]");
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
						obj77 = (nint)0 + (nint)128;
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

	private void TitleTile(Tile t, RectInt r, int i)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00e9: Invalid comparison between F4 and I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0108: Invalid comparison between F4 and I4
		//IL_011e: Expected Obj, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Expected F8, but got I4
		//IL_0b36: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got VT
		//IL_02ab: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_0302: Expected Obj, but got I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I4
		//IL_0b89: Expected Obj, but got I4
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Expected Obj, but got Unknown
		//IL_0bb1: Expected VT, but got Obj
		//IL_0bbe: Expected VT, but got Obj
		//IL_0bf3: Expected I4, but got VT
		//IL_0bfb: Expected Obj, but got I4
		//IL_0c03: Expected I4, but got VT
		//IL_0c0b: Expected Obj, but got VT
		//IL_0652: Expected Obj, but got I
		//IL_067c: Expected Obj, but got I4
		//IL_0720: Expected Obj, but got I4
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I8
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_0443: Expected Obj, but got I4
		//IL_0cdb: Expected Obj, but got I
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Expected I4, but got Unknown
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected I4, but got Unknown
		//IL_0c5c: Expected Obj, but got I4
		//IL_0c75: Expected Obj, but got I4
		//IL_0c8a: Expected Obj, but got I
		//IL_0cb4: Expected Obj, but got I4
		//IL_07a5: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I4
		//IL_0e5b: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_04ae: Expected Obj, but got I
		//IL_04c2: Expected Obj, but got I
		//IL_082d: Expected Obj, but got I
		//IL_04e1: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I
		//IL_08b9: Expected Obj, but got I
		//IL_08c9: Expected Obj, but got I
		//IL_08e2: Expected Obj, but got I4
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected I4, but got Unknown
		//IL_0cfe: Expected Obj, but got I
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected I4, but got Unknown
		//IL_0d4e: Expected Obj, but got I
		//IL_0d80: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I
		//IL_09fc: Expected Obj, but got I4
		//IL_05b7: Expected Obj, but got I4
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_061a: Expected VT, but got I4
		//IL_062a: Expected VT, but got I4
		//IL_0634: Expected VT, but got Obj
		//IL_0ae8: Expected Obj, but got I4
		//IL_0a50: Expected Obj, but got I
		//IL_0e1d: Expected Obj, but got I
		//IL_0e2d: Expected Obj, but got I
		//IL_0993: Expected Obj, but got I4
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected Obj, but got Unknown
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Expected I4, but got Unknown
		//IL_0d9e: Expected Obj, but got I
		//IL_0dae: Expected Obj, but got I
		//IL_0a94: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = NameTitles.MayWear(t.title);
		int worn = NameTitles.Worn;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		int num = worn;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = t.pop < 0f;
		object obj7 = !flag4;
		bool flag5 = t.pop == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
		object obj8 = 0;
		object obj9 = ~obj7;
		object obj10 = obj9 | flag5;
		double num2 = 0.0;
		if (obj10 == null)
		{
			bool flag6 = !((double)t.pop < 1.0);
			num2 = 1.0;
			if (!flag6)
			{
				double num3 = (double)t.pop * -10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				double num4 = (double)t.pop * 10.0;
				double num5 = num4 + -0.75;
				double num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				double num7 = num6 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				double num8 = num3 * num7;
				num2 = num8 + 1.0;
			}
		}
		object obj11 = pickedTitle - t.title;
		bool hover = obj11 == null;
		int num9 = default;
		string text = num9.ToString();
		string text2 = (string)obj8 + text;
		bool flag7 = hovered == text2;
		TileOutline(r, (float)num2, (byte)i != 0, hover);
		Color32 color = NameTitles.Colour(t.title);
		string text3 = NameTitles.Label(t.title);
		string[] array = text3.Split(' ', (StringSplitOptions)0);
		object obj12 = r >> 32;
		int num10 = i >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj13 = 0;
		object obj14 = array.Length + array.Length;
		object obj15 = obj13;
		object obj16 = obj14 << 1;
		object obj17 = obj16 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v24+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = num10 - obj16;
		object obj20 = obj19 - 28;
		object obj21 = obj19 - 27;
		bool flag9 = (nint)obj20 < 0;
		object obj22 = obj20 ^ obj20;
		object obj23 = obj20 & obj22;
		bool flag10 = (nint)obj23 < 0;
		bool flag11 = flag9 == flag10;
		object obj24 = !flag11;
		object obj25 = ~obj24;
		if (obj25 != null)
		{
			obj21 = obj20;
		}
		object obj26 = i - 8;
		object obj27 = obj12 + obj21;
		object obj28 = r + 4;
		Color32 color2 = (Color32)(obj26 | obj17);
		RectInt rectInt = (RectInt)(obj28 | obj27);
		FillRect(rectInt, color2);
		Outline(rectInt, color2);
		bool flag12 = array.Length < 1;
		int num11 = (int)color;
		string text4 = (string)flag7;
		int num12 = (int)color2;
		ScreenFont screenFont = (ScreenFont)rectInt;
		if (flag12)
		{
			goto IL_0642;
		}
		object obj29 = array.Length & 0xFFFFFFFFL;
		object obj30 = array + 32;
		bool flag13 = i < 0;
		int num13 = i ^ i;
		int num14 = i & num13;
		bool flag14 = num14 < 0;
		int width = i - 10;
		bool flag15 = flag13 == flag14;
		object obj31 = !flag15;
		object obj32 = ~obj31;
		int num15 = ((obj32 != null) ? i : (i + 1));
		int num16 = r + num15;
		int num17 = obj27 + 4;
		bool flag17 = default;
		bool flag16 = flag17;
		int num19 = default;
		int num18 = num19;
		Color32[] array3 = default;
		Color32[] array2 = array3;
		Color32 color3 = color;
		string text5 = (string)flag7;
		Color32 color4 = color2;
		RectInt rectInt2 = rectInt;
		object obj33 = 0;
		Color32[] array4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v63+E4]");
			bool flag18 = (nint)0 == 0;
			object obj36 = !flag18;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj29 = array.Length;
			}
			bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
			object obj37 = !flag19;
			if (obj37 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X25_v9+v323 @ X24_v9*8]");
			string text6 = Fit((string)0, width, 1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj39 = 0;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v65+E4]");
			bool flag20 = (nint)0 == 0;
			object obj41 = !flag20;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Color32 color5 = NameTitles.Light(t.title);
			if (array4.Length == 0 || array4.Length == 1)
			{
				break;
			}
			Text(this.text, num16, num17, text6, array4, 1, centred: true);
			obj29 = array.Length;
			obj33++;
			bool flag21 = (nint)obj33 < array.Length;
			num11 = num17;
			text4 = text6;
			num12 = num16;
			screenFont = this.text;
			flag16 = true;
			num18 = 1;
			array2 = array4;
			color3 = (Color32)num17;
			text5 = text6;
			color4 = (Color32)num16;
			rectInt2 = (RectInt)this.text;
			if (flag21)
			{
				continue;
			}
			goto IL_0642;
		}
		goto IL_0b0d;
		IL_0642:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v31+E4]");
		bool flag22 = (nint)0 == 0;
		object obj44 = !flag22;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj45 = obj27 + obj17;
		object obj46 = obj27 - obj45;
		bool flag23 = (nint)obj46 < 0;
		bool flag24 = obj46 == null;
		object obj47 = obj27 ^ obj45;
		object obj48 = obj27 ^ obj46;
		object obj49 = obj47 & obj48;
		bool flag25 = (nint)obj49 < 0;
		bool flag26 = flag23 == flag25;
		object obj50 = !flag24;
		object obj51 = flag26 & obj50;
		object obj52 = ~obj51;
		object obj53 = ((obj52 != null) ? obj45 : obj27);
		string current = GillaName.Current;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj54 = 0;
		string s = current.ToUpperInvariant();
		int width2 = i - 10;
		string s2 = Fit(s, width2, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj56 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v31+E4]");
		bool flag27 = (nint)0 == 0;
		object obj57 = !flag27;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj56 = obj54;
		}
		Color32[] array5 = default;
		int x;
		string s3;
		Color32[] colours;
		int num23;
		object obj72;
		if (array5.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v31+A0]");
			object obj58 = 0;
			bool flag28 = array5.Length == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v32+90]");
			_ = 0;
			if (!flag28)
			{
				object obj59 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF378]");
				object obj60 = 0;
				bool flag29 = i < 0;
				int num20 = i ^ i;
				int num21 = i & num20;
				bool flag30 = num21 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v34+A0]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF388]");
				object obj62 = 0;
				bool flag31 = flag29 == flag30;
				object obj63 = !flag31;
				object obj64 = ~obj63;
				int num22 = ((obj64 != null) ? i : (i + 1));
				int y = obj53 - 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC20]");
				object obj65 = 0;
				x = r + num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v35+90]");
				_ = 0;
				Text(this.text, x, y, s2, array5, 1, centred: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj66 = 0;
				s3 = (string)obj62;
				object obj67 = obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X0_v42+E4]");
				bool flag32 = (nint)0 == 0;
				object obj68 = !flag32;
				if (obj68 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (flag2)
				{
					object obj69 = obj54;
					if (worn == t.title)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v52+E4]");
						bool flag33 = (nint)0 == 0;
						object obj70 = !flag33;
						if (obj70 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj69 = obj54;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v52+A0]");
						object obj71 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v55+A8]");
						colours = (Color32[])0;
						num23 = num10;
						obj72 = obj12;
						s3 = (string)obj60;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v52+E4]");
						bool flag34 = (nint)0 == 0;
						object obj73 = !flag34;
						if (obj73 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj69 = obj54;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v52+A0]");
						object obj74 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v54+A0]");
						colours = (Color32[])0;
						num23 = num10;
						obj72 = obj12;
					}
					goto IL_0dcb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
				object obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj76 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v46+E4]");
				bool flag35 = (nint)0 == 0;
				object obj77 = !flag35;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj76 = obj54;
				}
				Color32[] array6 = default;
				if (array6.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v46+A0]");
					object obj78 = 0;
					bool flag36 = array6.Length == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v47+98]");
					_ = 0;
					if (!flag36)
					{
						object obj79 = obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v49+A0]");
						object obj80 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v50+98]");
						_ = 0;
						num23 = num10;
						colours = array6;
						obj72 = obj12;
						s3 = (string)obj65;
						goto IL_0dcb;
					}
				}
			}
		}
		goto IL_0b0d;
		IL_0dcb:
		object obj81 = obj72 + num23;
		int y2 = obj81 - 10;
		Text(this.text, x, y2, s3, colours, 1, centred: true);
		return;
		IL_0b0d:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void MonsterTile(Tile t, RectInt r, int i)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00ec: Invalid comparison between F4 and I4
		//IL_00fd: Expected Obj, but got I4
		//IL_010b: Invalid comparison between F4 and I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0130: Expected F8, but got I4
		//IL_07fa: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I4
		//IL_084f: Expected Obj, but got I
		//IL_0879: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I
		//IL_037e: Expected Obj, but got VT
		//IL_0397: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected I4, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08f9: Expected Obj, but got I4
		//IL_056e: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03f0: Expected Obj, but got I8
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I8
		//IL_0782: Expected Obj, but got I
		//IL_07ac: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_0930: Expected Obj, but got I4
		//IL_09f9: Expected Obj, but got I
		//IL_0a09: Expected Obj, but got I
		//IL_0723: Expected Obj, but got I
		//IL_074d: Expected Obj, but got I4
		//IL_05f4: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I4
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected I4, but got Unknown
		//IL_09d4: Expected Obj, but got I
		//IL_09e4: Expected Obj, but got I
		//IL_062d: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got I4
		//IL_096f: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I4
		//IL_0681: Expected Obj, but got I
		//IL_0a35: Expected I4, but got Obj
		//IL_0a63: Expected Obj, but got I
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		//IL_0a8f: Expected Obj, but got I
		//IL_0a99: Expected Obj, but got I4
		//IL_0ae2: Expected Obj, but got I
		//IL_0b2e: Expected Obj, but got I
		//IL_0954: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int monsterNow = MonsterNow;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
		object obj7 = 0;
		bool flag3 = MonsterChoice.Locked(t.monster);
		bool flag4 = t.pop < 0f;
		object obj8 = !flag4;
		bool flag5 = t.pop == 0f;
		object obj9 = ~obj8;
		object obj10 = obj9 | flag5;
		double num = 0.0;
		if (obj10 == null)
		{
			bool flag6 = !((double)t.pop < 1.0);
			num = 1.0;
			if (!flag6)
			{
				double num2 = (double)t.pop * -10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				double num3 = (double)t.pop * 10.0;
				double num4 = num3 + -0.75;
				double num5 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				double num6 = num5 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				double num7 = num2 * num6;
				num = num7 + 1.0;
			}
		}
		object obj11 = pickedMonster - t.monster;
		bool flag7 = obj11 == null;
		int num8 = default;
		string text = num8.ToString();
		string text2 = (string)obj7 + text;
		bool flag8 = hovered == text2;
		TileOutline(r, (float)num, (byte)i != 0, flag7);
		MonsterDirector.Entry entry = MonsterCatalog.Of(t.monster);
		string text4;
		if (entry != null)
		{
			if (string.IsNullOrEmpty(entry.label))
			{
				string text3 = entry.name.ToUpperInvariant();
				text4 = text3;
				object obj12 = 0;
			}
			else
			{
				text4 = entry.label;
				object obj12 = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4F8]");
			object obj13 = 0;
			text4 = (string)obj13;
			object obj12 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v21+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num9 = i - 4;
		string[] array = Wrap(text4, num9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj17 = 0;
		bool flag10 = i < 0;
		int num10 = i ^ i;
		int num11 = i & num10;
		bool flag11 = num11 < 0;
		object obj18 = r >> 32;
		bool flag12 = flag10 == flag11;
		object obj19 = !flag12;
		object obj20 = ~obj19;
		int num12 = ((obj20 != null) ? i : (i + 1));
		int num13 = i >> 32;
		object obj21 = obj17;
		int num14 = r + num12;
		ScreenFont font = this.text;
		object obj22 = num13 + obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v28+E4]");
		bool flag13 = (nint)0 == 0;
		bool flag14 = array.Length < 1;
		int num15 = (flag7 ? 1 : 0);
		string text5 = (string)flag8;
		ScreenFont screenFont = (ScreenFont)(object)text4;
		bool flag15 = flag13;
		if (flag14)
		{
			goto IL_0536;
		}
		object obj23 = obj22 - 20;
		object obj24 = array.Length & 0xFFFFFFFFL;
		object obj25 = array + 32;
		bool flag17 = default;
		bool flag16 = flag17;
		int num17 = default;
		int num16 = num17;
		Color32[] array3 = default;
		Color32[] array2 = array3;
		bool flag18 = flag7;
		string text6 = (string)flag8;
		int num18 = num9;
		string text7 = text4;
		object obj26 = 0;
		object obj27 = 4294967295L;
		object obj28 = obj21;
		bool flag19 = flag13;
		while (true)
		{
			if (flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = array.Length;
			}
			bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
			object obj29 = !flag20;
			if (obj29 != null)
			{
				break;
			}
			object obj30 = obj;
			object obj32;
			if (pickedMonster == t.monster)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v56+E4]");
				bool flag21 = (nint)0 == 0;
				object obj31 = !flag21;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj30 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v56+A0]");
				obj32 = (nint)0 + (nint)168;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v56+E4]");
				bool flag22 = (nint)0 == 0;
				object obj33 = !flag22;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj30 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v56+A0]");
				obj32 = (nint)0 + (nint)160;
			}
			object obj34 = obj27 + obj24;
			object obj35 = obj34 + obj34;
			num15 = obj23 - obj35;
			ScreenFont font2 = this.text;
			int y = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X28_v6+v552 @ X23_v7*8]");
			Text(font2, num14, y, (string)0, (Color32[])obj32, 1, centred: true);
			obj26++;
			obj27--;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj36 = 0;
			obj24 = array.Length;
			font = this.text;
			obj21 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v28+E4]");
			bool flag23 = (nint)0 == 0;
			bool flag24 = (nint)obj26 < array.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X28_v6+v552 @ X23_v7*8]");
			text5 = (string)0;
			num9 = num14;
			screenFont = this.text;
			flag15 = flag23;
			flag16 = true;
			num16 = 1;
			array2 = (Color32[])obj32;
			flag18 = (byte)num15 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X28_v6+v552 @ X23_v7*8]");
			text6 = (string)0;
			num18 = num14;
			text7 = (string)(object)this.text;
			obj28 = obj21;
			flag19 = flag23;
			if (flag24)
			{
				continue;
			}
			goto IL_0536;
		}
		goto IL_07d1;
		IL_07d1:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0991:
		int y2 = obj22 - 10;
		string s;
		Color32[] colours;
		Text(font, num14, y2, s, colours, 1, centred: true);
		return;
		IL_0536:
		if (flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj37 = 0;
		if (flag3)
		{
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v39+E4]");
			bool flag25 = (nint)0 == 0;
			object obj39 = !flag25;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text8 = MonsterChoice.LockLabel(t.monster);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj41 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v31+E4]");
			bool flag26 = (nint)0 == 0;
			object obj42 = !flag26;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj41 = obj;
			}
			Color32[] array4 = default;
			if (array4.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v31+A0]");
				object obj43 = 0;
				bool flag27 = array4.Length == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v32+98]");
				_ = 0;
				if (!flag27)
				{
					object obj44 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v34+A0]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v35+98]");
					_ = 0;
					colours = array4;
					s = text8;
					goto IL_0991;
				}
			}
			goto IL_07d1;
		}
		object obj46 = obj;
		if (monsterNow == t.monster)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF398]");
			object obj47 = 0;
			s = (string)obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v33+E4]");
			bool flag28 = (nint)0 == 0;
			object obj48 = !flag28;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj46 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v33+A0]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v25+A8]");
			colours = (Color32[])0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF388]");
			object obj50 = 0;
			s = (string)obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v33+E4]");
			bool flag29 = (nint)0 == 0;
			object obj51 = !flag29;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj46 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v33+A0]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v24+A0]");
			colours = (Color32[])0;
		}
		goto IL_0991;
	}

	private unsafe void OutfitTile(Tile t, RectInt r, int i)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d2: Expected F8, but got I4
		//IL_121e: Expected Obj, but got I4
		//IL_01fe: Invalid comparison between F4 and I4
		//IL_020f: Expected Obj, but got I4
		//IL_021d: Invalid comparison between F4 and I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_00f5: Invalid comparison between I and F8
		//IL_017f: Expected Obj, but got I
		//IL_035d: Expected Obj, but got VT
		//IL_037b: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I
		//IL_126b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected I4, but got Unknown
		//IL_086c: Expected Obj, but got I4
		//IL_089f: Expected Obj, but got I4
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_094d: Expected Obj, but got I4
		//IL_1362: Expected Obj, but got I
		//IL_0906: Expected Obj, but got I4
		//IL_04ab: Expected I4, but got I8
		//IL_04c5: Expected Obj, but got I4
		//IL_04d5: Expected VT, but got I4
		//IL_04de: Expected VT, but got I4
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d1: Expected VT, but got Unknown
		//IL_17e4: Expected VT, but got I8
		//IL_180e: Expected Obj, but got I4
		//IL_1347: Expected Obj, but got I
		//IL_0646: Expected Obj, but got I4
		//IL_0997: Expected Obj, but got I4
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		//IL_067e: Expected Obj, but got VT
		//IL_0516: Expected Obj, but got I4
		//IL_0a45: Expected Obj, but got I4
		//IL_074d: Expected Obj, but got I
		//IL_12bc: Expected Obj, but got I4
		//IL_1398: Expected Obj, but got I
		//IL_09fe: Expected Obj, but got I4
		//IL_078e: Expected VT, but got I4
		//IL_0796: Expected VT, but got Obj
		//IL_06dc: Expected Obj, but got I4
		//IL_06f9: Invalid comparison between F4 and I4
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected VT, but got Unknown
		//IL_059d: Expected VT, but got I8
		//IL_1829: Unknown result type (might be due to invalid IL or missing references)
		//IL_182e: Expected VT, but got Unknown
		//IL_1841: Expected VT, but got I8
		//IL_186b: Expected Obj, but got I4
		//IL_137d: Expected Obj, but got I
		//IL_081d: Expected Obj, but got I4
		//IL_0d81: Expected Obj, but got I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected VT, but got Unknown
		//IL_060a: Expected VT, but got I8
		//IL_0617: Expected VT, but got I8
		//IL_0a89: Expected Obj, but got I
		//IL_1323: Expected Obj, but got I
		//IL_132c: Expected Obj, but got I4
		//IL_07ce: Expected Obj, but got I4
		//IL_1457: Expected Obj, but got I
		//IL_1465: Expected VT, but got I4
		//IL_148f: Expected Obj, but got I4
		//IL_0b20: Expected Obj, but got I4
		//IL_16ea: Expected VT, but got Obj
		//IL_16f8: Expected VT, but got I4
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_1705: Expected VT, but got Unknown
		//IL_1713: Expected Obj, but got I4
		//IL_1720: Expected Obj, but got VT
		//IL_174b: Expected Obj, but got VT
		//IL_1753: Unknown result type (might be due to invalid IL or missing references)
		//IL_1758: Expected Obj, but got Unknown
		//IL_177d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1782: Expected I4, but got Unknown
		//IL_179b: Expected Obj, but got I4
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a8: Expected Obj, but got Unknown
		//IL_12da: Expected Obj, but got I
		//IL_12f8: Expected VT, but got I4
		//IL_1300: Expected VT, but got I4
		//IL_14b3: Expected Obj, but got I
		//IL_14bc: Expected Obj, but got I4
		//IL_13ce: Expected Obj, but got I
		//IL_0ad9: Expected Obj, but got I4
		//IL_14d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dc: Expected Obj, but got Unknown
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_1508: Expected Obj, but got Unknown
		//IL_153a: Unknown result type (might be due to invalid IL or missing references)
		//IL_153f: Expected I4, but got Unknown
		//IL_1558: Expected Obj, but got I4
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_1565: Expected Obj, but got Unknown
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Expected Obj, but got Unknown
		//IL_188f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1894: Expected I4, but got Unknown
		//IL_18e4: Expected Obj, but got I4
		//IL_13b3: Expected Obj, but got I
		//IL_0dd8: Expected Obj, but got I4
		//IL_0b64: Expected Obj, but got I
		//IL_1585: Unknown result type (might be due to invalid IL or missing references)
		//IL_158a: Expected I4, but got Unknown
		//IL_1593: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Expected Obj, but got Unknown
		//IL_15a0: Expected VT, but got I4
		//IL_0bfb: Expected Obj, but got I4
		//IL_1643: Expected Obj, but got I4
		//IL_1404: Expected Obj, but got I
		//IL_0bb4: Expected Obj, but got I4
		//IL_18fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1900: Expected I4, but got Unknown
		//IL_1959: Expected Obj, but got I4
		//IL_13e9: Expected Obj, but got I
		//IL_0fef: Expected Obj, but got I4
		//IL_1029: Expected Obj, but got I
		//IL_0e33: Expected Obj, but got I4
		//IL_0cee: Expected Obj, but got I
		//IL_0c67: Expected Obj, but got I
		//IL_0c91: Expected Obj, but got I4
		//IL_10d6: Expected Obj, but got I4
		//IL_0ede: Expected Obj, but got I4
		//IL_0d32: Expected Obj, but got I4
		//IL_141f: Expected Obj, but got I
		//IL_1682: Expected Obj, but got I
		//IL_108f: Expected Obj, but got I4
		//IL_15de: Expected Obj, but got I
		//IL_0e97: Expected Obj, but got I4
		//IL_143a: Expected Obj, but got I
		//IL_1978: Unknown result type (might be due to invalid IL or missing references)
		//IL_197d: Expected I4, but got Unknown
		//IL_1a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a45: Expected Obj, but got Unknown
		//IL_1a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Expected I4, but got Unknown
		//IL_1ac3: Expected Obj, but got I4
		//IL_1667: Expected Obj, but got I
		//IL_19a6: Expected VT, but got Obj
		//IL_19d0: Expected Obj, but got I4
		//IL_15c3: Expected Obj, but got I
		//IL_1129: Expected Obj, but got I
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Expected I4, but got Unknown
		//IL_114a: Expected Obj, but got I4
		//IL_1176: Expected Obj, but got I
		//IL_0fa0: Expected Obj, but got I4
		//IL_1614: Expected Obj, but got I
		//IL_0f59: Expected Obj, but got I4
		//IL_11e4: Expected Obj, but got I4
		//IL_19e6: Expected VT, but got Obj
		//IL_19f8: Expected VT, but got Obj
		//IL_1a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a06: Expected Obj, but got Unknown
		//IL_1a2b: Expected VT, but got I4
		//IL_1a33: Expected VT, but got I4
		//IL_15f9: Expected Obj, but got I
		//IL_16dd: Expected Obj, but got I
		//IL_119d: Expected Obj, but got I4
		//IL_16c2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		int num = t + 44;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v3 (System.Int32)+8]");
		bool flag2 = (nint)0 < (nint)0;
		object obj4 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v3 (System.Int32)+8]");
		bool flag3 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
		object obj5 = 0;
		object obj6 = ~obj4;
		object obj7 = obj6 | flag3;
		double num2 = 0.0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v3 (System.Int32)+8]");
			bool flag4 = !(0.0 < 1.0);
			num2 = 1.0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v3 (System.Int32)+8]");
				double num3 = 0.0 * -10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v3 (System.Int32)+8]");
				double num4 = 0.0 * 10.0;
				double num5 = num4 + -0.75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				object obj8 = 0;
				double num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
				double num7 = num6 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				double num8 = num3 * num7;
				num2 = num8 + 1.0;
				double num9 = 1.0;
			}
		}
		object obj9 = pickedOutfit - ((int*)num)->m_value;
		bool flag5 = obj9 == null;
		int num10 = default;
		string text = num10.ToString();
		string text2 = (string)obj5 + text;
		bool flag6 = hovered == text2;
		TileOutline(r, (float)num2, (byte)i != 0, flag5);
		bool flag7 = t.pop < 0f;
		object obj10 = !flag7;
		bool flag8 = t.pop == 0f;
		object obj11 = ~obj10;
		object obj12 = obj11 | flag8;
		if (obj12 != null)
		{
			return;
		}
		bool flag9 = !((double)t.pop < 1.0);
		float num11 = (float)num2;
		if (!flag9)
		{
			double num12 = (double)t.pop * -10.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
			double num13 = (double)t.pop * 10.0;
			double num14 = num13 + -0.75;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
			object obj8 = 0;
			double num15 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A970]");
			double num16 = num15 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			double num17 = num12 * num16;
			num11 = (float)num17 + 1f;
			bool flag10 = (double)num11 < 0.5;
			double num9 = 0.5;
			if (flag10)
			{
				return;
			}
		}
		object obj13 = r >> 32;
		int num18 = i >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v15+E4]");
		bool flag11 = (nint)0 == 0;
		object obj16 = !flag11;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = i < 0;
		int num19 = i ^ i;
		int num20 = i & num19;
		bool flag13 = num20 < 0;
		bool flag14 = flag12 == flag13;
		object obj17 = !flag14;
		object obj18 = ~obj17;
		int num21 = ((obj18 != null) ? i : (i + 1));
		int num22 = r + num21;
		RectInt rectInt2;
		object obj31;
		object obj40;
		object obj41;
		if (((int*)num)->m_value != 0)
		{
			int i2 = ((int*)num)->m_value - 1;
			GillaOutfits.Outfit outfit = GillaOutfits.At(i2);
			if (outfit == null)
			{
				return;
			}
			int colour = outfit.colour;
			int num23 = (int)(outfit.colour & 0x80000000L);
			bool flag15 = num23 == 0;
			object obj19 = !flag15;
			bool flag16 = flag5;
			Color32 color = (Color32)i;
			RectInt rectInt = (RectInt)0;
			if (obj19 == null)
			{
				object obj20 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v182+E4]");
				bool flag17 = (nint)0 == 0;
				object obj21 = !flag17;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					colour = outfit.colour;
				}
				object obj22 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v184+E4]");
				bool flag18 = (nint)0 == 0;
				object obj23 = !flag18;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Color32 color2 = FurOf(colour);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
				object obj24 = r & -4294967296L;
				RectInt r2 = (RectInt)(r + 17179869184L);
				FillRect(r2, (Color32)38654705673L);
				object obj25 = obj;
				object obj26 = r + 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v125+A0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v126+84]");
				flag16 = false;
				object obj28 = obj24 | obj26;
				rectInt = (RectInt)(obj28 + 12884901888L);
				Outline(rectInt, (Color32)47244640267L);
				color = (Color32)47244640267L;
			}
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v91+E4]");
			bool flag19 = (nint)0 == 0;
			object obj30 = !flag19;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			rectInt2 = DeleteRect(r);
			obj31 = rectInt2 >> 32;
			if (deleteArmed == ((int*)num)->m_value)
			{
				float time = Time.time;
				num11 = time - armedAt;
				bool flag20 = (double)num11 < 3.0;
				object obj32 = !flag20;
				float num24 = num11 - 3f;
				bool flag21 = num24 == 0f;
				object obj33 = ~obj32;
				object obj34 = obj33 | flag21;
				double num9 = 3.0;
				if (obj34 != null)
				{
					object obj35 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v173+E4]");
					bool flag22 = (nint)0 == 0;
					object obj36 = !flag22;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj35 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v173+A0]");
					object obj37 = 0;
					FillRect(rectInt2, (Color32)i);
					object obj38 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v176+E4]");
					bool flag23 = (nint)0 == 0;
					object obj39 = !flag23;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj38 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v176+A0]");
					obj40 = (nint)0 + (nint)140;
					obj41 = 0;
					num9 = 3.0;
					goto IL_16e2;
				}
			}
			string text3 = num10.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2F8]");
			object obj42 = 0;
			string text4 = (string)obj42 + text3;
			bool flag24 = hovered == text4;
			bool flag25 = !flag24;
			Color32 color3 = (Color32)0;
			RectInt rectInt3 = (RectInt)text4;
			if (!flag25)
			{
				object obj43 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v167+E4]");
				bool flag26 = (nint)0 == 0;
				object obj44 = !flag26;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj43 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v167+A0]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v116+88]");
				flag16 = false;
				FillRect(rectInt2, (Color32)i);
				color3 = (Color32)i;
				rectInt3 = rectInt2;
			}
			object obj46 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v163+E4]");
			bool flag27 = (nint)0 == 0;
			object obj47 = !flag27;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj46 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v163+A0]");
			obj40 = (nint)0 + (nint)128;
			obj41 = 1;
			goto IL_16e2;
		}
		object obj48 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v18+E4]");
		bool flag28 = (nint)0 == 0;
		object obj49 = !flag28;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj50 = obj;
		object obj51 = num22 - 10;
		object obj52 = r & -4294967296L;
		object obj53 = obj52 | obj51;
		if (pickedOutfit == ((int*)num)->m_value)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v81+E4]");
			bool flag29 = (nint)0 == 0;
			object obj54 = !flag29;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj50 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v81+A0]");
			object obj55 = (nint)0 + (nint)140;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v81+E4]");
			bool flag30 = (nint)0 == 0;
			object obj56 = !flag30;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj50 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v81+A0]");
			object obj55 = (nint)0 + (nint)128;
		}
		RectInt r3 = (RectInt)(obj53 + 137438953472L);
		FillRect(r3, (Color32)17179869204L);
		object obj57 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v23+E4]");
		bool flag31 = (nint)0 == 0;
		object obj58 = !flag31;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj59 = obj;
		object obj60 = num22 - 2;
		object obj61 = r & -4294967296L;
		object obj62 = obj61 | obj60;
		if (pickedOutfit == ((int*)num)->m_value)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v74+E4]");
			bool flag32 = (nint)0 == 0;
			object obj63 = !flag32;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj59 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v74+A0]");
			object obj64 = (nint)0 + (nint)140;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v74+E4]");
			bool flag33 = (nint)0 == 0;
			object obj65 = !flag33;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj59 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v74+A0]");
			object obj64 = (nint)0 + (nint)128;
		}
		RectInt r4 = (RectInt)(obj62 + 103079215104L);
		FillRect(r4, (Color32)85899345924L);
		object obj66 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X0_v28+E4]");
		bool flag34 = (nint)0 == 0;
		object obj67 = !flag34;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF358]");
		object s = 0;
		object obj68 = obj;
		object colours;
		if (pickedOutfit == ((int*)num)->m_value)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v67+E4]");
			bool flag35 = (nint)0 == 0;
			object obj69 = !flag35;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj68 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v67+A0]");
			colours = (nint)0 + (nint)168;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v67+E4]");
			bool flag36 = (nint)0 == 0;
			object obj70 = !flag36;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj68 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v67+A0]");
			colours = (nint)0 + (nint)160;
		}
		object obj71 = num18 + obj13;
		int y = obj71 - 30;
		Text(this.text, num22, y, (string)s, (Color32[])colours, 1, centred: true);
		object obj72 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v33+E4]");
		bool flag37 = (nint)0 == 0;
		object obj73 = !flag37;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4E8]");
		object s2 = 0;
		object obj74 = obj;
		object colours2;
		if (pickedOutfit == ((int*)num)->m_value)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X0_v60+E4]");
			bool flag38 = (nint)0 == 0;
			object obj75 = !flag38;
			if (obj75 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj74 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X0_v60+A0]");
			colours2 = (nint)0 + (nint)168;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X0_v60+E4]");
			bool flag39 = (nint)0 == 0;
			object obj76 = !flag39;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj74 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X0_v60+A0]");
			colours2 = (nint)0 + (nint)160;
		}
		int y2 = obj71 - 20;
		Text(this.text, num22, y2, (string)s2, (Color32[])colours2, 1, centred: true);
		int count = GillaOutfits.Count;
		object obj77 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v27+E4]");
		bool flag40 = (nint)0 == 0;
		object obj78 = !flag40;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string s3;
		object obj82;
		if (count > 7)
		{
			object obj79 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF370]");
			object obj80 = 0;
			s3 = (string)obj80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X0_v55+E4]");
			bool flag41 = (nint)0 == 0;
			object obj81 = !flag41;
			if (obj81 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj79 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X0_v55+A0]");
			obj82 = (nint)0 + (nint)184;
		}
		else
		{
			int count2 = GillaOutfits.Count;
			int num25 = default;
			string text5 = num25.ToString();
			string text6 = num25.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
			object obj83 = 0;
			string text7 = text5 + (string)obj83 + text6;
			object obj84 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v33+E4]");
			bool flag42 = (nint)0 == 0;
			object obj85 = !flag42;
			if (obj85 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj84 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v33+A0]");
			obj82 = (nint)0 + (nint)176;
			s3 = text7;
		}
		Color32[] colours3 = (Color32[])obj82;
		int y3 = obj71 - 10;
		int x = num22;
		ScreenFont font = this.text;
		goto IL_1af8;
		IL_1af8:
		Text(font, x, y3, s3, colours3, 1, centred: true);
		return;
		IL_16e2:
		Color32 color4 = (Color32)obj40;
		Outline(rectInt2, (Color32)i);
		RectInt rectInt4 = (RectInt)(i + rectInt2);
		object obj86 = i - 2;
		object obj87 = rectInt2 - rectInt4;
		bool flag43 = (nint)obj87 < 0;
		bool flag44 = obj87 == null;
		object obj88 = rectInt2 ^ rectInt4;
		object obj89 = rectInt2 ^ obj87;
		object obj90 = obj88 & obj89;
		bool flag45 = (nint)obj90 < 0;
		int num26 = obj31 + 2;
		bool flag46 = flag43 == flag45;
		object obj91 = !flag44;
		object obj92 = flag46 & obj91;
		object obj93 = ~obj92;
		if (obj93 == null)
		{
			rectInt4 = rectInt2;
		}
		object obj94 = obj86 - 2;
		bool flag47 = (nint)obj94 < 0;
		bool flag48 = obj94 == null;
		object obj95 = obj86 ^ 2;
		object obj96 = obj86 ^ obj94;
		object obj97 = obj95 & obj96;
		bool flag49 = (nint)obj97 < 0;
		int num27 = rectInt2 + 2;
		bool flag50 = flag47 == flag49;
		object obj98 = !flag48;
		object obj99 = flag50 & obj98;
		object obj100 = ~obj99;
		if (obj100 != null)
		{
			obj86 = 2;
		}
		int num28 = rectInt4 - 3;
		object obj101 = obj86 - 2;
		Color32 color5 = (Color32)i;
		RectInt rectInt5 = rectInt2;
		while (true)
		{
			object obj102 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X0_v98+E4]");
			bool flag51 = (nint)0 == 0;
			object obj103 = !flag51;
			if (obj103 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (obj101 == null)
			{
				break;
			}
			object obj104 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X0_v129+E4]");
			bool flag52 = (nint)0 == 0;
			object obj105 = !flag52;
			if (obj105 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj106 = obj;
			object obj108;
			if (obj41 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v146+E4]");
				bool flag53 = (nint)0 == 0;
				object obj107 = !flag53;
				if (obj107 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj106 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v146+A0]");
				obj108 = (nint)0 + (nint)128;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v146+E4]");
				bool flag54 = (nint)0 == 0;
				object obj109 = !flag54;
				if (obj109 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj106 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v146+A0]");
				obj108 = (nint)0 + (nint)120;
			}
			Set(num27, num26, (Color32)obj108);
			object obj110 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v134+E4]");
			bool flag55 = (nint)0 == 0;
			object obj111 = !flag55;
			if (obj111 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj112 = obj;
			object obj114;
			if (obj41 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X0_v139+E4]");
				bool flag56 = (nint)0 == 0;
				object obj113 = !flag56;
				if (obj113 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj112 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X0_v139+A0]");
				obj114 = (nint)0 + (nint)128;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X0_v139+E4]");
				bool flag57 = (nint)0 == 0;
				object obj115 = !flag57;
				if (obj115 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj112 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X0_v139+A0]");
				obj114 = (nint)0 + (nint)120;
			}
			color4 = (Color32)obj114;
			Set(num28, num26, (Color32)obj114);
			obj101--;
			num26++;
			num27++;
			color5 = (Color32)num26;
			rectInt5 = (RectInt)num28;
		}
		object obj116 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v100+E4]");
		bool flag58 = (nint)0 == 0;
		object obj117 = !flag58;
		if (obj117 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text8 = ((int*)num)->ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4F0]");
		object obj118 = 0;
		string s4 = (string)obj118 + text8;
		object obj119 = obj;
		object colours4;
		if (pickedOutfit == ((int*)num)->m_value)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v84+E4]");
			bool flag59 = (nint)0 == 0;
			object obj120 = !flag59;
			if (obj120 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj119 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v84+A0]");
			colours4 = (nint)0 + (nint)168;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v84+E4]");
			bool flag60 = (nint)0 == 0;
			object obj121 = !flag60;
			if (obj121 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj119 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v84+A0]");
			colours4 = (nint)0 + (nint)160;
		}
		object obj122 = num18 + obj13;
		int y4 = obj122 - 20;
		Text(this.text, num22, y4, s4, (Color32[])colours4, 1, centred: true);
		int i3 = ((int*)num)->m_value - 1;
		bool flag61 = GillaOutfits.IsOn(i3);
		object obj123 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X8_v72+E4]");
		bool flag62 = (nint)0 == 0;
		object obj124 = !flag62;
		if (obj124 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag63 = !flag61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF378]");
		object obj125 = 0;
		object obj126 = obj;
		int num29 = obj122 - 10;
		object obj127 = !flag63;
		object obj128 = ~obj127;
		if (obj128 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF368]");
			obj125 = 0;
		}
		s3 = (string)obj125;
		object obj130;
		if (flag61)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ X0_v114+E4]");
			bool flag64 = (nint)0 == 0;
			object obj129 = !flag64;
			if (obj129 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj126 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ X0_v114+A0]");
			obj130 = (nint)0 + (nint)168;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ X0_v114+E4]");
			bool flag65 = (nint)0 == 0;
			object obj131 = !flag65;
			if (obj131 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj126 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ X0_v114+A0]");
			obj130 = (nint)0 + (nint)160;
		}
		colours3 = (Color32[])obj130;
		y3 = num29;
		x = num22;
		font = this.text;
		goto IL_1af8;
	}

	private static RectInt DeleteRect(RectInt tile)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected VT, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got VT
		//IL_007b: Expected Obj, but got VT
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IntPtr intPtr = default;
		RectInt rectInt = (RectInt)((nint)intPtr + tile);
		object obj4 = tile & -4294967296L;
		object obj5 = tile - rectInt;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = obj5 == null;
		object obj6 = tile ^ rectInt;
		object obj7 = tile ^ obj5;
		object obj8 = obj6 & obj7;
		bool flag4 = (nint)obj8 < 0;
		bool flag5 = flag2 == flag4;
		object obj9 = !flag3;
		object obj10 = flag5 & obj9;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			rectInt = tile;
		}
		object obj12 = rectInt - 15;
		object obj13 = obj4 | obj12;
		return (RectInt)(obj13 + 12884901888L);
	}

	private static Color32 FurOf(int code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ad: Expected I4, but got Obj
		//IL_00c8: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0143: Expected I4, but got Obj
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected I4, but got Unknown
		//IL_01c2: Expected VT, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = code * 1374389535;
		object obj5 = obj4 >> 63;
		object obj6 = obj4 >> 37;
		object obj7 = obj6 + obj5;
		object obj8 = obj7 * 1717986919;
		object obj9 = obj8 >> 63;
		object obj10 = obj8 >> 34;
		object obj11 = obj10 + obj9;
		object obj12 = obj11 * 10;
		int d = obj7 - obj12;
		byte b = _003CFurOf_003Eg__V_007C184_0(d);
		object obj13 = code * 1717986919;
		object obj14 = obj13 >> 63;
		object obj15 = obj13 >> 34;
		object obj16 = obj15 + obj14;
		object obj17 = obj16 * 1717986919;
		object obj18 = obj17 >> 63;
		object obj19 = obj17 >> 34;
		object obj20 = obj19 + obj18;
		object obj21 = obj20 * 10;
		int d2 = obj16 - obj21;
		byte b2 = _003CFurOf_003Eg__V_007C184_0(d2);
		object obj22 = obj16 * 10;
		int d3 = code - obj22;
		byte b3 = _003CFurOf_003Eg__V_007C184_0(d3);
		int num = b2 & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	private void Glitch(float k)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0751: Expected I4, but got F4
		//IL_075a: Invalid comparison between F4 and I4
		//IL_0769: Expected F8, but got I4
		//IL_0aa4: Expected Obj, but got I
		//IL_0ace: Expected Obj, but got I4
		//IL_0075: Invalid comparison between F8 and I4
		//IL_07fe: Expected Obj, but got I
		//IL_0807: Invalid comparison between F8 and I4
		//IL_0816: Expected Obj, but got I4
		//IL_081e: Expected I4, but got F4
		//IL_0433: Expected Obj, but got I
		//IL_0443: Invalid comparison between F4 and I
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_07db: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I4
		//IL_0994: Expected I, but got Obj
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected Obj, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected Obj, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_0a2b: Expected Obj, but got I4
		//IL_0a73: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_0846: Expected Obj, but got I4
		//IL_0853: Expected I4, but got I8
		//IL_049c: Expected Obj, but got I4
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_040c: Invalid comparison between Obj and F8
		//IL_01c7: Expected Obj, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01f6: Expected Obj, but got I4
		//IL_04e1: Expected Obj, but got I4
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected I4, but got Unknown
		//IL_0946: Expected Obj, but got I
		//IL_0a5b: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_0503: Expected Obj, but got I4
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_0530: Expected Obj, but got I
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_054e: Expected Obj, but got I
		//IL_0582: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_065f: Expected Obj, but got I
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected Obj, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected Obj, but got Unknown
		//IL_0709: Expected Obj, but got I4
		//IL_021a: Unsupported input type for neg.
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected Obj, but got Unknown
		//IL_0898: Expected Obj, but got I4
		//IL_0246: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_08bc: Expected Obj, but got I
		//IL_08cc: Expected Obj, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
		object obj = 0;
		float num = k * 1.1093934E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.Random random = default;
		random._002Ector((int)num);
		bool flag = k < 0f;
		double num2 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)k > 1.0);
			num2 = k;
			if (!flag2)
			{
				num2 = 1.0;
			}
		}
		double num3 = num2 * 14.0;
		double num4 = 14.0 - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
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
				goto IL_07a4;
			}
			num6 = num4 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num8 = -0.5;
		}
		else
		{
			if (num4 == 0.5)
			{
				num5 = 1.0;
				num6 = num7;
				goto IL_07a4;
			}
			num6 = num4 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num8 = 0.5;
		}
		goto IL_07ee;
		IL_07a4:
		num8 = num6 + num5;
		object obj5 = num6 & 1;
		bool flag4 = obj5 == null;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			num6 = num8;
		}
		goto IL_07ee;
		IL_0723:
		throw new IndexOutOfRangeException();
		IL_07ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj7 = 0;
		bool flag5 = num6 < 1.0;
		object obj8 = 0;
		int num9 = (int)num;
		if (flag5)
		{
			goto IL_0423;
		}
		object obj10 = default;
		object obj9 = obj10;
		int num11 = default;
		int num10 = num11;
		object obj11 = 0;
		Array array = default;
		while (true)
		{
			string text = ((System.Empty)(object)random).ToString();
			int hashCode = random.GetHashCode();
			nint num12 = (nint)random;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v35 (Il2CppClass<System.Random>)+1A0]");
			int num13 = 0;
			int hashCode2 = random.GetHashCode();
			object obj12 = hashCode + text;
			object obj13 = obj12 - 256;
			bool flag6 = (nint)obj13 < 0;
			object obj14 = obj12 ^ 0x100;
			object obj15 = obj12 ^ obj13;
			object obj16 = obj14 & obj15;
			bool flag7 = (nint)obj16 < 0;
			bool flag8 = flag6 == flag7;
			object obj17 = !flag8;
			object obj18 = ~obj17;
			object obj19 = ((obj18 != null) ? ((object)256) : obj12);
			bool flag9 = System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
			obj8 = 25;
			num9 = -24;
			if (!flag9)
			{
				object obj20 = -hashCode2;
				object obj21 = 130560 - text;
				object obj22 = obj9;
				int num14 = num10;
				int num15 = num13;
				object obj23 = 25;
				string text2 = text;
				while (true)
				{
					int sourceIndex = 130560 - text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Array.Copy(px, sourceIndex, array, 0, 512);
					object obj25 = 0;
					while (true)
					{
						object obj26 = obj20 + obj25;
						object obj27 = 0 - obj26;
						object obj28 = obj26 & 0x1FF;
						object obj29 = obj27 & 0x1FF;
						if (0 >= (nint)obj26)
						{
							obj28 = 0 - obj29;
						}
						object obj30 = obj28 + 512;
						object obj31 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v29 (System.Array)+18]");
						bool flag10 = (nint)obj31 < 0;
						object obj32 = !flag10;
						if (obj32 != null)
						{
							break;
						}
						object obj33 = (object)array + obj28;
						nint num16 = (nint)random;
						Color32[] array2 = px;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v50+20]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v28 (Il2CppClass<System.Random>)+1B0]");
						obj8 = 0;
						string text3 = ((System.Empty)(object)random).ToString();
						bool flag11 = text3 == null;
						object obj35 = !flag11;
						if (obj35 == null)
						{
							object obj36 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X0_v36+E4]");
							bool flag12 = (nint)0 == 0;
							object obj37 = !flag12;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj36 = obj7;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X0_v36+A0]");
							object obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v56+80]");
							obj34 = 0;
						}
						object obj39 = obj21 + obj25;
						bool flag13 = (nint)obj39 < array2.Length;
						object obj40 = !flag13;
						if (obj40 != null)
						{
							break;
						}
						object obj41 = (object)px + obj39;
						obj25++;
						if ((nint)obj25 != 512)
						{
							continue;
						}
						goto IL_036c;
					}
					break;
					IL_036c:
					text2++;
					object obj42 = obj21 - 512;
					bool flag14 = text2 != obj19;
					obj9 = 0;
					num10 = 512;
					num13 = 0;
					num9 = 5;
					obj22 = 0;
					num14 = 512;
					num15 = 0;
					obj21 = obj42;
					obj23 = obj8;
					if (flag14)
					{
						continue;
					}
					goto IL_03f6;
				}
				break;
			}
			goto IL_03f6;
			IL_03f6:
			obj11++;
			if (obj11 != (object)num6)
			{
				continue;
			}
			goto IL_0423;
		}
		goto IL_0723;
		IL_0423:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		if (!(k < 0f))
		{
			return;
		}
		Color32[] array3 = px;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj44 = 0;
		object obj69 = default;
		while (true)
		{
			object obj45 = array3.Length;
			if ((nint)obj44 < array3.Length)
			{
				bool flag15 = (nint)obj44 < array3.Length;
				object obj46 = !flag15;
				if (obj46 != null)
				{
					break;
				}
				object obj47 = obj7;
				object obj48 = (object)array3 + obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v16+E4]");
				bool flag16 = (nint)0 == 0;
				object obj49 = !flag16;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj45 = array3.Length;
				}
				bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45);
				object obj50 = !flag17;
				if (obj50 != null)
				{
					break;
				}
				object obj51 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X21_v10+20]");
				object obj52 = (nint)0 >> 24;
				obj44++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v21+A0]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v22+90]");
				object obj54 = (nint)0 >> 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v22+90]");
				object obj55 = (nint)0 & (nint)0xFF;
				object obj56 = obj54 - obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X21_v10+20]");
				object obj57 = obj55 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
				object obj58 = obj43 & 0xFF000000FFL;
				object obj59 = num8 & 0xFF000000FFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				object obj60 = obj56 * 0;
				object obj61 = obj59 - obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				object obj62 = obj60 + obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				double num17 = (double)obj61 * num4;
				double num18 = num17 + (double)obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X21_v10+20]");
				object obj63 = (nint)0 & (nint)0xFF;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				object obj64 = obj57 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
				num8 = (double)obj64 + (double)obj63;
				obj43 = num18 & 0xFF0000FF0000L;
				object obj65 = num8 & 0xFF;
				object obj66 = obj43 | obj62;
				object obj67 = obj66 | obj65;
				object obj68 = obj67 | obj69;
				array3 = px;
				bool flag18 = px == null;
				object obj70 = !flag18;
				if (obj70 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		goto IL_0723;
	}

	private void Button(RectInt r, string label, string id, int scale)
	{
		//IL_02c2: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I4
		//IL_005f: Invalid comparison between F4 and I4
		//IL_0104: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_0328: Expected VT, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_0469: Expected VT, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I
		//IL_035b: Expected VT, but got Obj
		//IL_01eb: Expected Obj, but got VT
		//IL_01fb: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected I4, but got Unknown
		//IL_0405: Expected Obj, but got I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected I4, but got Unknown
		//IL_0456: Expected Obj, but got I
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		bool flag = hovered == (string)scale;
		bool flag2 = !flag;
		string text = id;
		if (!flag2)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v36+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v36+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v22+88]");
			text = (string)0;
			FillRect(r, (Color32)label);
		}
		if (pressFlash > 0f && pressedThing == (string)scale)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v31+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v31+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v20+90]");
			text = (string)0;
			FillRect(r, (Color32)label);
		}
		bool flag5 = hovered == (string)scale;
		object obj8 = obj;
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v22+A0]");
			object obj10 = (nint)0 + (nint)128;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v22+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v22+A0]");
			object obj10 = (nint)0 + (nint)132;
		}
		Outline(r, (Color32)label);
		if (id._stringLength >= 1)
		{
			object obj12 = r >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v16+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v16+A0]");
			object obj18 = 0;
			bool flag10 = (nint)label < 0;
			object obj19 = (object)label ^ (object)label;
			object obj20 = (object)label & obj19;
			bool flag11 = (nint)obj20 < 0;
			int y = obj12 + 5;
			bool flag12 = flag10 == flag11;
			object obj21 = !flag12;
			object obj22 = ~obj21;
			string text2 = ((obj22 != null) ? label : (label + 1));
			int x = (int)(r + text2);
			ScreenFont font = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+A0]");
			IntPtr intPtr = default;
			Text(font, x, y, id, (Color32[])0, (int)(nint)intPtr, centred: true);
		}
	}

	private void Arrow(RectInt r, bool up)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0245: Expected VT, but got I8
		//IL_024e: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_00e8: Expected VT, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected VT, but got Unknown
		bool flag = default;
		object obj = (flag ? 1 : 0) >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (flag ? 1 : 0) < (false ? 1 : 0);
		object obj5 = flag ^ flag;
		object obj6 = flag & obj5;
		bool flag4 = (nint)obj6 < 0;
		bool flag5 = flag3 == flag4;
		object obj7 = !flag5;
		object obj8 = ~obj7;
		bool flag6 = ((obj8 != null) ? flag : ((byte)((flag ? 1u : 0u) + 1u) != 0));
		bool flag7 = (nint)obj < 0;
		object obj9 = obj ^ obj;
		object obj10 = obj & obj9;
		bool flag8 = (nint)obj10 < 0;
		bool flag9 = flag7 == flag8;
		object obj11 = !flag9;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj13 = 0;
		RectInt rectInt = default;
		object obj14 = rectInt + flag6;
		nint num2 = default;
		nint num = num2;
		Color32 color = (Color32)4294967297L;
		object obj15 = 0;
		object obj16 = -2;
		bool flag12;
		do
		{
			object obj17 = obj13;
			object obj18 = num2 & 1;
			bool flag10 = obj18 == null;
			object obj19 = !flag10;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v5+E4]");
			bool flag11 = (nint)0 == 0;
			object obj21 = !flag11;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj22 = obj13;
			rectInt = (RectInt)(obj14 + obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v8+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9+80]");
			num = 0;
			FillRect(rectInt, color);
			obj16++;
			obj15--;
			Color32 color2 = (Color32)(color + 2);
			flag12 = (nint)obj16 != 3;
			color = color2;
		}
		while (flag12);
	}

	private void BoltIcon(int x, int y)
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected VT, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I8
		//IL_00b6: Expected Obj, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I8
		//IL_01b8: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01fa: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_0310: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I4
		//IL_060b: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_046c: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I4
		//IL_041a: Expected VT, but got I8
		//IL_048f: Expected Obj, but got I
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected I4, but got Unknown
		//IL_0431: Expected Obj, but got I4
		//IL_0446: Expected VT, but got I8
		//IL_04eb: Expected Obj, but got I4
		//IL_04f8: Expected VT, but got I8
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got I4
		//IL_0524: Expected VT, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64F0]");
			Color32 color = (Color32)0;
			object obj3 = default;
			object obj2 = obj3 + 32;
			obj2 = color.rgba;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X23_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64E0]");
				object obj5 = 0;
				object obj6 = obj3 + 40;
				obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X23_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj7 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X23_v8-10]");
				object obj8 = -2;
				bool flag2 = obj8 == null;
				object obj9 = ~obj7;
				object obj10 = obj9 | flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64E8]");
					object obj11 = 0;
					object obj12 = obj3 + 48;
					obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X23_v10-18]");
					object obj13 = 0 & 0xFFFFFFFCL;
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64F8]");
						object obj14 = 0;
						object obj15 = obj3 + 56;
						obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X23_v12-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj16 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X23_v12-20]");
						object obj17 = -4;
						bool flag4 = obj17 == null;
						object obj18 = ~obj16;
						object obj19 = obj18 | flag4;
						if (obj19 == null)
						{
							object obj20 = obj3 + 64;
							obj20 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X23_v14-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj21 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X23_v14-28]");
							object obj22 = -5;
							bool flag6 = obj22 == null;
							object obj23 = ~obj21;
							object obj24 = obj23 | flag6;
							if (obj24 == null)
							{
								object obj25 = obj3 + 72;
								obj25 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X23_v16-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj26 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X23_v16-30]");
								object obj27 = -6;
								bool flag8 = obj27 == null;
								object obj28 = ~obj26;
								object obj29 = obj28 | flag8;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
									object obj30 = 0;
									object obj31 = obj3 + 80;
									obj31 = color.rgba;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj32 = 0;
									while (true)
									{
										object obj33 = obj3 + obj32;
										int num = 0;
										while (true)
										{
											object obj34 = obj32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+18]");
											bool flag9 = (nint)obj34 < 0;
											object obj35 = !flag9;
											if (obj35 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X27_v4+20]");
											char c = ((string)0).get_Chars(num);
											int num2 = c & 0xFFFF;
											if (num2 == 35)
											{
												object obj36 = obj30;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v27+E4]");
												bool flag10 = (nint)0 == 0;
												object obj37 = !flag10;
												color = (Color32)4288059030L;
												if (obj37 != null)
												{
													goto IL_0529;
												}
												object obj38 = 0;
												int num3 = num;
												color = (Color32)4288059030L;
											}
											else
											{
												object obj39 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+18]");
												bool flag11 = (nint)obj39 < 0;
												object obj40 = !flag11;
												if (obj40 != null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X27_v4+20]");
												char c2 = ((string)0).get_Chars(num);
												int num4 = c2 & 0xFFFF;
												if (num4 != 76)
												{
													goto IL_055a;
												}
												object obj36 = obj30;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v27+E4]");
												bool flag12 = (nint)0 == 0;
												object obj41 = !flag12;
												color = (Color32)4292335575L;
												if (obj41 != null)
												{
													goto IL_0529;
												}
												object obj38 = 0;
												int num3 = num;
												color = (Color32)4292335575L;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											goto IL_0529;
											IL_055a:
											num++;
											if (num != 7)
											{
												continue;
											}
											goto IL_0588;
											IL_0529:
											int x2 = x + num;
											int y2 = obj32 + y;
											Set(x2, y2, color);
											goto IL_055a;
										}
										break;
										IL_0588:
										obj32++;
										if ((nint)obj32 == 7)
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void CoinIcon(int x, int y)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Coin(px, 512, 256, x, y, 1);
	}

	private string[] Wrap(string s, int width)
	{
		//IL_0378: Expected Obj, but got I
		//IL_0033: Expected I, but got Obj
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected I4, but got Unknown
		//IL_0439: Expected Obj, but got I4
		//IL_0161: Expected I, but got Obj
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I8
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		bool flag = this.text == null;
		int num2 = default;
		int num = num2;
		string[] result;
		object obj9;
		int num17;
		string text3;
		if (!flag)
		{
			int num3 = this.text.Measure(s, 1);
			bool flag2 = num3 <= num2;
			nint num4 = unchecked((nint)null);
			num = 1;
			if (!flag2)
			{
				if (s != null)
				{
					bool flag3 = s._stringLength < 0;
					int num5 = s._stringLength ^ s._stringLength;
					int num6 = s._stringLength & num5;
					bool flag4 = num6 < 0;
					bool flag5 = flag3 == flag4;
					object obj2 = !flag5;
					object obj3 = ~obj2;
					int num7 = ((obj3 != null) ? s._stringLength : (s._stringLength + 1));
					int num8 = s._stringLength - 1;
					int num9 = num7 >> 1;
					int num10 = num9 + 3;
					object obj4 = num8 - num10;
					bool flag6 = (nint)obj4 < 0;
					int num11 = num8 ^ num10;
					int num12 = num8 ^ obj4;
					int num13 = num11 & num12;
					bool flag7 = num13 < 0;
					bool flag8 = flag6 == flag7;
					object obj5 = !flag8;
					object obj6 = ~obj5;
					int startIndex = ((obj6 != null) ? num10 : num8);
					int num14 = s.LastIndexOf(' ', startIndex);
					bool flag9 = num14 > 0;
					int num15 = num14;
					if (!flag9)
					{
						int num16 = s.IndexOf(' ');
						bool flag10 = num16 <= 0;
						num15 = num16;
						startIndex = 0;
						num4 = unchecked((nint)null);
						num = 0;
						if (flag10)
						{
							goto IL_02b6;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					string s2 = s.Substring(0, num15);
					string text = Fit(s2, num2, 1);
					string[] array = default;
					if (array != null)
					{
						if (array.Length != 0)
						{
							object obj7 = array + 32;
							obj7 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int startIndex2 = num15 + 1;
							string s3 = s.Substring(startIndex2);
							string text2 = Fit(s3, num2, 1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X24_v5-8]");
							object obj8 = 0 & 0xFFFFFFFEL;
							if (obj8 != null)
							{
								obj9 = array + 40;
								obj9 = text2;
								num17 = 1;
								text3 = text2;
								result = array;
								goto IL_048b;
							}
						}
						goto IL_035a;
					}
				}
				goto IL_034c;
			}
		}
		goto IL_02b6;
		IL_02b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string text4 = Fit(s, num2, 1);
		string[] array2 = default;
		if (array2 == null)
		{
			goto IL_034c;
		}
		if (array2.Length == 0)
		{
			goto IL_035a;
		}
		obj9 = array2 + 32;
		obj9 = text4;
		num17 = 1;
		text3 = text4;
		result = array2;
		goto IL_048b;
		IL_035a:
		return (string[])(object)new IndexOutOfRangeException();
		IL_048b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return result;
		IL_034c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_035a;
	}

	private string Fit(string s, int width, int scale)
	{
		//IL_0101: Expected Obj, but got I4
		bool flag = this.text == null;
		string result = s;
		if (!flag)
		{
			bool flag2 = s == null;
			result = s;
			if (flag2)
			{
				goto IL_011f;
			}
			string text = s;
			while (true)
			{
				bool flag3 = text._stringLength < 2;
				result = text;
				if (flag3)
				{
					break;
				}
				bool flag4 = this.text == null;
				result = text;
				if (!flag4)
				{
					int num = this.text.Measure(text, scale);
					bool flag5 = num <= width;
					result = text;
					if (flag5)
					{
						break;
					}
					int length = text._stringLength - 1;
					string text2 = text.Substring(0, length);
					bool flag6 = text2 == null;
					object obj = !flag6;
					result = text2;
					text = text2;
					if (obj != null)
					{
						continue;
					}
				}
				goto IL_011f;
			}
		}
		return result;
		IL_011f:
		throw new NullReferenceException();
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
				int num = font.DrawCentred(px, 512, 256, x, y, s, ref s2);
			}
			else
			{
				int num2 = font.Draw(px, 512, 256, x, y, s, ref s2);
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
		//IL_00e0: Expected Obj, but got I4
		if (y > 255 || x > 511)
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
			object obj3 = obj2 + 130560;
			bool flag2 = (nint)obj3 < array.Length;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				object obj5 = (object)px + obj3;
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
		//IL_005f: Expected Obj, but got I4
		//IL_009a: Expected I4, but got I8
		//IL_00a7: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected VT, but got Unknown
		int num = i + 3;
		bool flag = i < 0;
		int num2 = i ^ i;
		int num3 = i & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj = !flag3;
		object obj2 = ~obj;
		if (obj2 != null)
		{
			num = i;
		}
		int num4 = (int)(num & 0xFFFFFFFCL);
		object obj3 = i - num4;
		object obj4 = obj3 * 62;
		RectInt result = (RectInt)(132 + obj4);
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
		double num2 = num * 1132462080.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num3 = (double)obj8 + 0.5;
		double num4 = num3 * 68.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		return (Vector2Int)(num4 | num2);
	}

	private Vector3 ToLocal(Vector2Int p)
	{
		return Size;
	}

	private Vector3 ToLocal(Vector2 p)
	{
		return Size;
	}

	private void Play(AudioClip clip, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_016f: Expected VT, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj5 = array + 32;
			obj5 = clip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)screen != null)
			{
				Transform transform = screen.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
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

	public CosmeticTerminal()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02dd: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I8
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_03c0: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF400]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45C8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj6 = 0;
		wakeRange = 2.8f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 248;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj9 = obj7 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<byte> list2 = default;
		list2._002Ector();
		object obj10 = obj7 + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list3 = default;
		list3._002Ector();
		object obj11 = obj7 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list4 = default;
		list4._002Ector();
		object obj12 = obj7 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list5 = default;
		list5._002Ector();
		object obj13 = obj7 + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list6 = default;
		list6._002Ector();
		object obj14 = obj7 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = obj7 + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = obj7 + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj17 = obj7 + 176;
		_ = 4294967295L;
		_ = 4294967295L;
		_ = 4294967295L;
		_ = 4294967295L;
		_ = 3212836864L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj18 = obj7 + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = obj7 + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj21 = obj7 + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			object obj23 = array + 32;
			obj23 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X21_v12-8]");
			object obj24 = 0 & 0xFFFFFFFEL;
			if (obj24 != null)
			{
				object obj25 = array + 40;
				obj25 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj26 = this + 464;
				downOn = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				dirty = true;
				lastBalance = -1;
				base._002Ector();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static CosmeticTerminal()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0b66: Expected Obj, but got I
		//IL_0b6e: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I8
		//IL_0109: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I8
		//IL_023b: Expected Obj, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0305: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03a1: Expected Obj, but got I
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I4
		//IL_0411: Expected Obj, but got I
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_0454: Expected Obj, but got I
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_046b: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I8
		//IL_04d3: Expected Obj, but got I
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_04ea: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0586: Expected Obj, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_059d: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I4
		//IL_05f6: Expected Obj, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_0639: Expected Obj, but got I
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected Obj, but got Unknown
		//IL_0650: Expected Obj, but got I4
		//IL_0693: Expected Obj, but got I4
		//IL_06a9: Expected Obj, but got I
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected Obj, but got Unknown
		//IL_06ec: Expected Obj, but got I
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected Obj, but got Unknown
		//IL_0703: Expected Obj, but got I4
		//IL_072b: Expected Obj, but got I
		//IL_0786: Expected Obj, but got I
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_07c0: Expected Obj, but got I8
		//IL_07ed: Expected Obj, but got I
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_082f: Expected Obj, but got I4
		//IL_0845: Expected Obj, but got I
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_0888: Expected Obj, but got I
		//IL_0898: Expected Obj, but got I
		//IL_08a8: Expected Obj, but got I
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08e6: Expected Obj, but got I
		//IL_091d: Expected Obj, but got I
		//IL_093a: Expected Obj, but got I
		//IL_0957: Expected Obj, but got I
		//IL_0974: Expected Obj, but got I
		//IL_0991: Expected Obj, but got I
		//IL_09ae: Expected Obj, but got I
		//IL_09cb: Expected Obj, but got I
		//IL_09e5: Expected Obj, but got I
		//IL_0a11: Expected Obj, but got I4
		//IL_0b9f: Expected Obj, but got I
		//IL_0baf: Expected Obj, but got I
		//IL_0bcc: Expected Obj, but got I
		//IL_0be6: Expected Obj, but got I
		//IL_0c00: Expected Obj, but got I
		//IL_0c1a: Expected Obj, but got I
		//IL_0c34: Expected Obj, but got I
		//IL_0c4e: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got I
		//IL_0c82: Expected Obj, but got I
		//IL_0c98: Expected Obj, but got I
		//IL_0ca8: Expected Obj, but got I
		//IL_0cd2: Expected Obj, but got I
		//IL_0ce8: Expected Obj, but got I
		//IL_0d1a: Expected Obj, but got I
		//IL_0d30: Expected Obj, but got I
		//IL_0d40: Expected Obj, but got I
		//IL_0a5e: Expected Obj, but got I
		//IL_0a74: Expected Obj, but got I
		//IL_0a84: Expected Obj, but got I
		//IL_0b19: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF500]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBAB8]");
		object item = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF508]");
		object obj4 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple = ((System.__Canon)item, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)253);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF558]");
			object item2 = 0;
			object obj8 = default;
			object obj7 = obj8 + 32;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple2 = ((System.__Canon)item2, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)255);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v6-8]");
			object obj9 = 0 & 0xFFFFFFFEL;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF520]");
				object item3 = 0;
				object obj10 = obj8 + 48;
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple3 = ((System.__Canon)item3, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X20_v8-18]");
				bool flag = (nint)0 < (nint)2;
				object obj11 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X20_v8-18]");
				object obj12 = -2;
				bool flag2 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF528]");
					object item4 = 0;
					object obj15 = obj8 + 64;
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple4 = ((System.__Canon)item4, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)7);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X20_v10-28]");
					object obj16 = 0 & 0xFFFFFFFCL;
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF530]");
						object item5 = 0;
						object obj17 = obj8 + 80;
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple5 = ((System.__Canon)item5, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X20_v12-38]");
						bool flag3 = (nint)0 < (nint)4;
						object obj18 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X20_v12-38]");
						object obj19 = -4;
						bool flag4 = obj19 == null;
						object obj20 = ~obj18;
						object obj21 = obj20 | flag4;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF548]");
							object item6 = 0;
							object obj22 = obj8 + 96;
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple6 = ((System.__Canon)item6, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X20_v14-48]");
							bool flag5 = (nint)0 < (nint)5;
							object obj23 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X20_v14-48]");
							object obj24 = -5;
							bool flag6 = obj24 == null;
							object obj25 = ~obj23;
							object obj26 = obj25 | flag6;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF560]");
								object item7 = 0;
								object obj27 = obj8 + 112;
								obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple7 = ((System.__Canon)item7, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X20_v16-58]");
								bool flag7 = (nint)0 < (nint)6;
								object obj28 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X20_v16-58]");
								object obj29 = -6;
								bool flag8 = obj29 == null;
								object obj30 = ~obj28;
								object obj31 = obj30 | flag8;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF538]");
									object item8 = 0;
									object obj32 = obj8 + 128;
									obj32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple8 = ((System.__Canon)item8, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X20_v18-68]");
									object obj33 = 0 & 0xFFFFFFF8L;
									if (obj33 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA9F0]");
										object item9 = 0;
										object obj34 = obj8 + 144;
										obj34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple9 = ((System.__Canon)item9, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)5);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X20_v20-78]");
										bool flag9 = (nint)0 < (nint)8;
										object obj35 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X20_v20-78]");
										object obj36 = -8;
										bool flag10 = obj36 == null;
										object obj37 = ~obj35;
										object obj38 = obj37 | flag10;
										if (obj38 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF540]");
											object item10 = 0;
											object obj39 = obj8 + 160;
											obj39 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple10 = ((System.__Canon)item10, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)254);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X20_v22-88]");
											bool flag11 = (nint)0 < (nint)9;
											object obj40 = !flag11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X20_v22-88]");
											object obj41 = -9;
											bool flag12 = obj41 == null;
											object obj42 = ~obj40;
											object obj43 = obj42 | flag12;
											if (obj43 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CAEF0]");
												object item11 = 0;
												object obj44 = obj8 + 176;
												obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) tuple11 = ((System.__Canon)item11, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)252);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X20_v24-98]");
												bool flag13 = (nint)0 < (nint)10;
												object obj45 = !flag13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X20_v24-98]");
												object obj46 = -10;
												bool flag14 = obj46 == null;
												object obj47 = ~obj45;
												object obj48 = obj47 | flag14;
												if (obj48 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
													object obj49 = 0;
													object obj50 = obj8 + 192;
													obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													object obj51 = obj2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v18+A0]");
													object obj52 = (nint)0 + (nint)8;
													obj52 = obj8;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v48+18]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF550]");
														object obj53 = 0;
														object obj55 = default;
														object obj54 = obj55 + 32;
														obj54 = obj53;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X20_v28-8]");
														object obj56 = 0 & 0xFFFFFFFEL;
														if (obj56 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF518]");
															object obj57 = 0;
															object obj58 = obj55 + 40;
															obj58 = obj57;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X20_v30-10]");
															bool flag15 = (nint)0 < (nint)2;
															object obj59 = !flag15;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X20_v30-10]");
															object obj60 = -2;
															bool flag16 = obj60 == null;
															object obj61 = ~obj59;
															object obj62 = obj61 | flag16;
															if (obj62 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF510]");
																object obj63 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
																object obj64 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
																object obj65 = 0;
																object obj66 = obj55 + 48;
																obj66 = obj63;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj67 = obj2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v28+A0]");
																object obj68 = (nint)0 + (nint)16;
																obj68 = obj55;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj69 = obj2;
																object obj70 = obj64;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj71 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DBC0]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj72 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D9C0]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj73 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D140]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj74 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DEB0]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj75 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DEC0]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj76 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD70]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj77 = 0;
																_ = 4278584838L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj78 = 0;
																_ = 4279045389L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v60+E4]");
																bool flag17 = (nint)0 == 0;
																object obj79 = !flag17;
																if (obj79 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	obj70 = obj64;
																	obj69 = obj2;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v60+A0]");
																object obj80 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj81 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X9_v13+2C]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj82 = 0;
																_ = 4284506208L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj83 = 0;
																_ = 4280821800L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj84 = 0;
																_ = 4294967295L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj85 = 0;
																_ = 4294967295L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj86 = 0;
																_ = 4288059030L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj87 = 0;
																_ = 4282795590L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj88 = 0;
																_ = 4293454056L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v60+A0]");
																object obj89 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
																object obj90 = (nint)0 + (nint)160;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X9_v22+8]");
																obj90 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj91 = obj64;
																object obj92 = obj2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v31+A0]");
																object obj93 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X9_v23+A0]");
																object obj94 = (nint)0 + (nint)168;
																obj94 = obj93;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj95 = obj64;
																object obj96 = obj2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v33+A0]");
																object obj97 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X9_v24+A0]");
																object obj98 = (nint)0 + (nint)176;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v34+10]");
																obj98 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj99 = obj64;
																object obj100 = obj2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v35+A0]");
																object obj101 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v25+A0]");
																object obj102 = (nint)0 + (nint)184;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v36+10]");
																obj102 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v74+18]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v74+18]");
																	bool flag18 = (nint)0 == 1;
																	_ = 4278584838L;
																	if (!flag18)
																	{
																		_ = 4278584838L;
																		object obj103 = obj2;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v38+A0]");
																		object obj104 = (nint)0 + (nint)192;
																		object obj105 = default;
																		obj104 = obj105;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void _003CDrawUi_003Eb__176_0()
	{
		//IL_0eef: Expected Obj, but got I
		//IL_0f19: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0037: Invalid comparison between F4 and I4
		//IL_0bc9: Expected Obj, but got I4
		//IL_0f37: Expected Obj, but got I
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected VT, but got Unknown
		//IL_0f68: Expected VT, but got I8
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Expected Obj, but got Unknown
		//IL_0b7c: Expected Obj, but got I4
		//IL_0c01: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I
		//IL_0199: Expected VT, but got I8
		//IL_0ed1: Expected Obj, but got I4
		//IL_0c1f: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I
		//IL_01cd: Invalid comparison between F8 and I
		//IL_03cb: Expected F8, but got I4
		//IL_0233: Invalid comparison between F8 and I4
		//IL_0244: Expected Obj, but got I4
		//IL_024e: Invalid comparison between F8 and I4
		//IL_0fcf: Expected Obj, but got I4
		//IL_04b8: Invalid comparison between F8 and I4
		//IL_05e6: Expected F8, but got I4
		//IL_02b2: Expected F8, but got I
		//IL_0d0b: Expected Obj, but got I4
		//IL_05b2: Expected F8, but got I4
		//IL_0658: Expected I4, but got F8
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected Obj, but got Unknown
		//IL_0cce: Expected Obj, but got I4
		//IL_0f97: Expected Obj, but got I4
		//IL_02d5: Invalid comparison between I and F8
		//IL_02ee: Expected F8, but got I
		//IL_073e: Invalid comparison between F4 and I4
		//IL_035e: Invalid comparison between F8 and I4
		//IL_0683: Expected Obj, but got I
		//IL_08b0: Expected Obj, but got I
		//IL_0772: Expected Obj, but got I
		//IL_06c4: Expected VT, but got I4
		//IL_06cc: Expected VT, but got Obj
		//IL_0866: Expected Obj, but got I4
		//IL_07b3: Expected VT, but got I4
		//IL_07bb: Expected VT, but got Obj
		//IL_096e: Expected Obj, but got I4
		//IL_0dd3: Expected Obj, but got I
		//IL_0704: Expected Obj, but got I4
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected Obj, but got Unknown
		//IL_0c81: Expected Obj, but got I4
		//IL_0dee: Expected Obj, but got I
		//IL_0920: Expected Obj, but got I4
		//IL_0fea: Expected VT, but got F8
		//IL_0ffd: Expected VT, but got I8
		//IL_1027: Expected Obj, but got I4
		//IL_07f3: Expected Obj, but got I4
		//IL_0d29: Expected Obj, but got I
		//IL_0d36: Expected VT, but got F8
		//IL_0d59: Expected VT, but got I8
		//IL_0d66: Expected VT, but got I8
		//IL_09cc: Expected Obj, but got I4
		//IL_0d7b: Expected Obj, but got I
		//IL_0d88: Expected VT, but got F8
		//IL_0dab: Expected VT, but got I8
		//IL_0db8: Expected VT, but got I8
		//IL_0937: Expected VT, but got I4
		//IL_093f: Expected VT, but got Obj
		//IL_0e03: Expected Obj, but got I
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e21: Expected VT, but got Unknown
		//IL_0e34: Expected VT, but got I8
		//IL_0e4c: Expected Obj, but got I
		//IL_0e5c: Expected Obj, but got I
		//IL_0a01: Invalid comparison between F8 and I
		//IL_0a12: Expected Obj, but got I4
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Obj, but got Unknown
		//IL_0ad2: Expected Obj, but got I4
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected Obj, but got Unknown
		//IL_0a7b: Expected Obj, but got I4
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1043: Expected I4, but got Unknown
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1051: Expected I4, but got Unknown
		//IL_107f: Expected Obj, but got I
		//IL_1097: Expected VT, but got I4
		//IL_10a1: Expected VT, but got Obj
		//IL_0b02: Expected Obj, but got I
		//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected Obj, but got Unknown
		//IL_0aab: Expected Obj, but got I
		float num = catAt - firstAt;
		float num2 = num * 1.1088691E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num3;
		double num5 = default;
		double num4;
		double num6;
		if (num2 < 0f)
		{
			if ((double)num2 == -0.5)
			{
				num3 = -1.0;
				num4 = num5;
				goto IL_0b45;
			}
			num4 = (double)num2 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num6 = -0.5;
		}
		else
		{
			if ((double)num2 == 0.5)
			{
				num3 = 1.0;
				num4 = num5;
				goto IL_0b45;
			}
			num4 = (double)num2 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num6 = 0.5;
		}
		goto IL_0b8f;
		IL_0b8f:
		object obj5 = obj4;
		double num7 = num4 + 32.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v8+A0]");
		object obj7 = 0;
		RectInt r = (RectInt)(0xC | num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v9+80]");
		int num8 = 0;
		FillRect(r, (Color32)137438953580L);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj10 = 0;
		double num9 = num4 + 5.0;
		Color32 color = (Color32)137438953580L;
		double num10 = num4;
		object obj19;
		while (true)
		{
			object obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v15+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v16+8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v16+8]");
			if ((nint)0 == 0)
			{
				goto IL_0b08;
			}
			double num11 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v17+18]");
			if (!(num11 < 0.0) || num10 > num9)
			{
				return;
			}
			float[] array = tabPush;
			double num16;
			if (tabPush != null)
			{
				bool flag5 = num10 < (double)array.Length;
				object obj15 = !flag5;
				if (num10 < (double)array.Length)
				{
					if (obj15 != null)
					{
						break;
					}
					double num12 = (double)tabPush + num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v73 (System.Double)+20]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8E0]");
					bool flag6 = num13 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8E0]");
					double num14 = 0.0;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v73 (System.Double)+20]");
						bool flag7 = !(0.0 > 1.0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v73 (System.Double)+20]");
						num14 = 0.0;
						num6 = 1.0;
						if (!flag7)
						{
							num14 = 1.0;
							num6 = 1.0;
						}
					}
					object obj16 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v89+E4]");
					bool flag8 = (nint)0 == 0;
					object obj17 = !flag8;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num15 = num14 * 3.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					if (num15 < 0.0)
					{
						if (num15 == -0.5)
						{
							num6 = num5 + -1.0;
							num4 = num5;
							num16 = num5;
							goto IL_0c59;
						}
						num4 = num15 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					}
					else
					{
						if (num15 == 0.5)
						{
							num6 = num5 + 1.0;
							num4 = num5;
							num16 = num5;
							goto IL_0c59;
						}
						num4 = num15 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					}
					goto IL_0c99;
				}
			}
			double num17 = 0.0;
			goto IL_0fa5;
			IL_0c59:
			object obj18 = num16 & 1;
			bool flag9 = obj18 == null;
			obj19 = !flag9;
			if (obj19 != null)
			{
				num4 = num6;
			}
			goto IL_0c99;
			IL_0ce1:
			object obj20 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v26+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num6 = catAt;
			double num18 = num17 + 12.0;
			double num20;
			double num19 = num17 + num20;
			double num21 = num19 + 32.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			double num22;
			bool flag11 = num22 < 0.5;
			int num23 = (int)num10;
			if (!flag11)
			{
				string text = num23.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E0]");
				object obj22 = 0;
				string text2 = (string)obj22 + text;
				bool flag12 = hovered == text2;
				bool flag13 = !flag12;
				color = (Color32)0;
				r = (RectInt)text2;
				if (!flag13)
				{
					object obj23 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X0_v80+E4]");
					bool flag14 = (nint)0 == 0;
					object obj24 = !flag14;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj23 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X0_v80+A0]");
					object obj25 = 0;
					r = (RectInt)(num18 | num21);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v68+88]");
					num8 = 0;
					FillRect(r, (Color32)137438953580L);
					color = (Color32)137438953580L;
				}
			}
			num4 = pressFlash;
			if (pressFlash > 0f)
			{
				string text3 = num23.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E0]");
				object obj26 = 0;
				string text4 = (string)obj26 + text3;
				bool flag15 = pressedThing == text4;
				bool flag16 = !flag15;
				color = (Color32)0;
				r = (RectInt)text4;
				if (!flag16)
				{
					object obj27 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v69+E4]");
					bool flag17 = (nint)0 == 0;
					object obj28 = !flag17;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj27 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v69+A0]");
					object obj29 = 0;
					r = (RectInt)(num18 | num21);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v63+90]");
					num8 = 0;
					FillRect(r, (Color32)137438953580L);
					color = (Color32)137438953580L;
				}
			}
			object obj32;
			object obj35;
			if (num22 < 0.5)
			{
				object obj30 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X0_v58+E4]");
				bool flag18 = (nint)0 == 0;
				object obj31 = !flag18;
				obj32 = obj30;
				if (obj31 == null)
				{
					goto IL_087c;
				}
			}
			else
			{
				string text5 = num23.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2E0]");
				object obj33 = 0;
				string text6 = (string)obj33 + text5;
				bool flag19 = hovered == text6;
				obj32 = obj4;
				if (!flag19)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v55+E4]");
					bool flag20 = (nint)0 == 0;
					object obj34 = !flag20;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj32 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v55+A0]");
					obj35 = (nint)0 + (nint)132;
					goto IL_0fdd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v55+E4]");
				bool flag21 = (nint)0 == 0;
				object obj36 = !flag21;
				if (obj36 == null)
				{
					color = (Color32)0;
					r = (RectInt)text6;
					object obj30 = obj32;
					goto IL_087c;
				}
			}
			goto IL_0dbd;
			IL_0fdd:
			RectInt r2 = (RectInt)(num18 | num21);
			Outline(r2, (Color32)137438953580L);
			object obj37 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v32+E4]");
			bool flag22 = (nint)0 == 0;
			object obj38 = !flag22;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj39 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X0_v35+E4]");
			bool flag23 = (nint)0 == 0;
			object obj40 = !flag23;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj39 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X0_v35+A0]");
			object obj41 = 0;
			double num24 = num20 + 35.0;
			RectInt r3 = (RectInt)(0xF | num24);
			Outline(r3, (Color32)137438953580L);
			object obj42 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v37+A0]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v40+8]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v40+8]");
			if ((nint)0 != 0)
			{
				double num25 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X9_v9+18]");
				bool flag24 = num25 < 0.0;
				object obj45 = !flag24;
				if (obj45 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v40+8]");
				object obj46 = 0 + num10;
				object colours;
				if (num22 < 0.5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v37+E4]");
					bool flag25 = (nint)0 == 0;
					object obj47 = !flag25;
					if (obj47 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj48 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X8_v46+A0]");
						obj43 = 0;
					}
					colours = obj43 + 192;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v37+E4]");
					bool flag26 = (nint)0 == 0;
					object obj49 = !flag26;
					if (obj49 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj50 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v42+A0]");
						obj43 = 0;
					}
					colours = obj43 + 160;
				}
				int num26 = (int)(num17 + 20);
				num8 = (int)(num21 + 9);
				ScreenFont font = this.text;
				int y = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X9_v10+20]");
				Text(font, num26, y, (string)0, (Color32[])colours, 2, centred: false);
				num10++;
				color = (Color32)num26;
				r = (RectInt)this.text;
				continue;
			}
			goto IL_0b08;
			IL_0c99:
			num17 = num4;
			goto IL_0fa5;
			IL_0fa5:
			object obj51 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v22+E4]");
			bool flag27 = (nint)0 == 0;
			object obj52 = !flag27;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num27 = num10 - (double)firstAt;
			num22 = num27 * 1108869120.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num30;
			double num29;
			double num28;
			if (num22 < 0.0)
			{
				if (num22 == -0.5)
				{
					num28 = num5 + -1.0;
					num29 = num5;
					num30 = num5;
					goto IL_0ca6;
				}
				num29 = num22 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				num20 = num22;
				num28 = 1108869120.0;
			}
			else
			{
				if (num22 == 0.5)
				{
					num28 = num5 + 1.0;
					num29 = num5;
					num30 = num5;
					goto IL_0ca6;
				}
				num29 = num22 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num20 = num22;
				num28 = 1108869120.0;
			}
			goto IL_0ce1;
			IL_087c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj4;
			goto IL_0dbd;
			IL_0ca6:
			object obj53 = num30 & 1;
			bool flag28 = obj53 == null;
			obj19 = !flag28;
			num20 = ((obj19 != null) ? num28 : num29);
			goto IL_0ce1;
			IL_0b08:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0dbd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v55+A0]");
			obj35 = (nint)0 + (nint)128;
			goto IL_0fdd;
		}
		throw new IndexOutOfRangeException();
		IL_0b45:
		num6 = num4 + num3;
		object obj54 = num4 & 1;
		bool flag29 = obj54 == null;
		obj19 = !flag29;
		if (obj19 != null)
		{
			num4 = num6;
		}
		goto IL_0b8f;
	}

	private unsafe void _003CDrawUi_003Eb__176_1()
	{
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0428: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got Ref
		//IL_00c0: Expected Obj, but got I8
		//IL_0135: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected VT, but got Unknown
		//IL_025d: Expected I4, but got I8
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I4
		//IL_02a6: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF3C8]");
		Tile tile = (Tile)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF270]");
		object obj = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)leaving).GetEnumerator();
		Enumerator<, > val = default;
		Tile tile2 = default;
		object obj7 = default;
		while (true)
		{
			Tile tile3;
			object obj2;
			Tile tile5;
			if (val.MoveNext())
			{
				bool flag = tile2 == null;
				tile3 = null;
				obj2 = 0;
				Tile tile4 = tile2;
				tile5 = tile2;
				if (flag)
				{
					break;
				}
				RectInt place = tile2.place;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ stack_-68 (CosmeticTerminal+Tile)+68]");
				int num = 0;
				RectInt place2 = tile2.place;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ stack_-68 (CosmeticTerminal+Tile)+68]");
				DrawTile(tile2, place2, 0);
				object obj3 = 4294967295L;
				continue;
			}
			tile3 = null;
			obj2 = 0;
			tile5 = tile2;
			object obj4 = 0;
			while (true)
			{
				Tile tile4 = tile;
				val.Dispose();
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					bool flag3 = tile3 == null;
					object obj6 = !flag3;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					tile5 = tile3;
					if (obj6 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)tile4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					tile3 = (Tile)1;
					tile5 = (Tile)1;
					obj4 = obj2;
					continue;
				}
				if ((nint)tile4 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj4 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj2 = obj7;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0518");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			tile5 = (Tile)(object)tiles;
			object obj8 = 0;
			while (true)
			{
				object obj9 = obj8;
				GameObject model = tile5.model;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref model))
				{
					object obj10 = obj8;
					GameObject model2 = tile5.model;
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref model2);
					object obj11 = !flag4;
					if (obj11 != null)
					{
						break;
					}
					object obj12 = obj;
					object obj13 = (object)tile5 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v13+20]");
					tile = (Tile)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v14+E4]");
					bool flag5 = (nint)0 == 0;
					object obj14 = !flag5;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj15 = obj8 & 3;
					object obj16 = obj8 >> 2;
					object obj17 = obj16 & 0x3FFFFFFF;
					object obj18 = obj15 << 6;
					object obj19 = obj17 * 108;
					object obj20 = 28 + obj19;
					object obj21 = obj18 - obj15;
					object obj22 = obj21 | obj20;
					RectInt place = (RectInt)(obj22 + 132);
					DrawTile(tile, place, 58);
					tile5 = (Tile)(object)tiles;
					object obj23 = obj8 + 1;
					bool flag6 = tiles == null;
					object obj24 = !flag6;
					object obj3 = obj8;
					int num = 58;
					Tile tile4 = tile;
					obj8 = obj23;
					if (obj24 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				return;
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			break;
		}
		throw new NullReferenceException();
	}

	internal static byte _003CFurOf_003Eg__V_007C184_0(int d)
	{
		//IL_0146: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I4
		//IL_004b: Invalid comparison between F8 and I4
		//IL_01cd: Expected I4, but got F8
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I4
		double num = (double)d / 9.0;
		double num2 = num * 1132396544.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num3;
		double num4;
		double num5 = default;
		if (num2 < 0.0)
		{
			if (num2 == -0.5)
			{
				num3 = -1.0;
				num4 = num5;
				goto IL_017e;
			}
			num4 = num2 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num2 == 0.5)
			{
				num3 = 1.0;
				num4 = num5;
				goto IL_017e;
			}
			num4 = num2 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_01c8;
		IL_01c8:
		return (byte)(int)num4;
		IL_017e:
		double num6 = num4 + num3;
		object obj4 = num4 & 1;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			num4 = num6;
		}
		goto IL_01c8;
	}
}
