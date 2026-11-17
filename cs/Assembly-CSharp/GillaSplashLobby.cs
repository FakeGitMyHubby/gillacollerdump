using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaSplashLobby : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass17_1
	{
		public List<Vector2[]> shapes;

		public List<GillaSplashLayout.Spot> spots;
	}

	[Serializable]
	public class MapEntry
	{
		public string label;

		public Texture2D preview;

		public Texture2D cover;

		public MapEntry()
		{
			//IL_0010: Expected Obj, but got I
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8428]");
			object obj = 0;
			object obj2 = this + 16;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Renderer, GillaMapVote.Canvas> _003C_003E9__57_0;

		public static Func<Renderer, GillaMapVote.Canvas> _003C_003E9__57_1;

		public static Func<MapEntry, Color32[]> _003C_003E9__57_2;

		public static Func<KeyValuePair<PlayerRef, byte>, bool> _003C_003E9__64_0;

		public static Func<KeyValuePair<PlayerRef, byte>, int> _003C_003E9__64_1;

		public static Func<int, int> _003C_003E9__64_2;

		public static Func<KeyValuePair<PlayerRef, byte>, string> _003C_003E9__67_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81B8]");
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

		internal GillaMapVote.Canvas _003COnEnable_003Eb__57_0(Renderer r)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c1: Expected Obj, but got I4
			//IL_0064: Expected Obj, but got I
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
			bool flag2 = r != null;
			bool flag3 = !flag2;
			GillaMapVote.Canvas result = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GillaMapVote.Canvas canvas = default;
				canvas._002Ector(r, 512, 128);
				result = canvas;
			}
			return result;
		}

		internal GillaMapVote.Canvas _003COnEnable_003Eb__57_1(Renderer r)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c1: Expected Obj, but got I4
			//IL_0064: Expected Obj, but got I
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
			bool flag2 = r != null;
			bool flag3 = !flag2;
			GillaMapVote.Canvas result = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GillaMapVote.Canvas canvas = default;
				canvas._002Ector(r, 256, 208);
				result = canvas;
			}
			return result;
		}

		internal Color32[] _003COnEnable_003Eb__57_2(MapEntry m)
		{
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected Obj, but got Unknown
			if (m != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(m.preview != null))
				{
					goto IL_0124;
				}
				if ((object)m.preview != null)
				{
					string text = ((Enum)(object)m.preview).ToString();
					object obj4 = text & 1;
					if (obj4 == null)
					{
						goto IL_0124;
					}
					if ((object)m.preview != null)
					{
						return m.preview.GetPixels32();
					}
				}
			}
			return (Color32[])(object)new NullReferenceException();
			IL_0124:
			return null;
		}

		internal bool _003CGoToStart_003Eb__64_0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object obj = kv & 0xFF00000000L;
			object obj2 = obj - 4294967296L;
			return obj2 == null;
		}

		internal int _003CGoToStart_003Eb__64_1(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = default;
			return playerRef.PlayerId;
		}

		internal int _003CGoToStart_003Eb__64_2(int i)
		{
			return i;
		}

		internal string _003CWinners_003Eb__67_1(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0247: Expected Obj, but got I4
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected VT, but got Unknown
			//IL_0147: Expected Obj, but got I
			//IL_015f: Expected Obj, but got I
			//IL_0181: Expected Obj, but got I4
			//IL_0075: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I4
			//IL_00de: Expected I, but got Obj
			//IL_0124: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef player = (PlayerRef)(kv & 0xFFFFFFFFL);
			NetworkApe networkApe = NetworkApe.Find(player);
			bool flag2 = (object)networkApe == null;
			UnityEngine.Object obj4 = null;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v16+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = (UnityEngine.Object)networkApe != (UnityEngine.Object)null;
				bool flag5 = !flag4;
				nint num = unchecked((nint)null);
				obj4 = null;
				if (!flag5)
				{
					string playerName = networkApe.PlayerName;
					bool flag6 = string.IsNullOrEmpty(playerName);
					bool flag7 = !flag6;
					num = unchecked((nint)null);
					obj4 = null;
					if (flag7)
					{
						string playerName2 = networkApe.PlayerName;
						if (playerName2 != null)
						{
							return playerName2.ToUpperInvariant();
						}
						return (string)(object)new NullReferenceException();
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8430]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
			bool flag8 = (nint)0 == 0;
			object obj11 = !flag8;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = default;
			int playerId = playerRef.PlayerId;
			int num2 = default;
			string text = num2.ToString();
			return (string)obj10 + text;
		}
	}

	public MapEntry[] maps;

	public PressKey[] panels;

	public Renderer[] panelScreens;

	public Renderer[] panelCovers;

	public Renderer board;

	public Renderer[] roomBoards;

	public Transform lobby;

	public Transform[] starts;

	public Bounds[] finishes;

	public GillaSplashGate[] gates;

	public NetworkObject gamePrefab;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip tickSound;

	public AudioClip goSound;

	public AudioClip throughSound;

	public AudioClip outSound;

	public AudioClip winSound;

	public Shader darkShader;

	public AudioClip lightsOutSound;

	private static GillaSplashLobby Current__BackingField;

	private const int PW = default(int);

	private const int PH = default(int);

	private const int BW = default(int);

	private const int BH = default(int);

	private static readonly Color32 Black;

	private static readonly Color32 Scan;

	private static readonly Color32 Lit;

	private static readonly Color32 Mid;

	private static readonly Color32 Low;

	private static readonly Color32 Picked;

	private static readonly Color32[] HeadText;

	private static readonly Color32[] WhiteText;

	private static readonly Color32[] PickedText;

	private static readonly Color32[] DimText;

	private GillaMapVote.Canvas boardCanvas;

	private GillaMapVote.Canvas[] roomCanvas;

	private GillaMapVote.Canvas[] panelCanvas;

	private Color32[][] pictures;

	private ScreenFont title;

	private ScreenFont text;

	private int seenStarts;

	private int lastTick;

	private byte seenPhase;

	private bool inGame;

	private bool through;

	private bool wantStart;

	private bool wantBack;

	private GillaDarkness dark;

	private float nextCheck;

	private float nextDraw;

	private string drawn;

	public static GillaSplashLobby Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
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
			return (GillaSplashLobby)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
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
		//IL_0868: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_0886: Expected Obj, but got I
		//IL_0896: Expected Obj, but got I
		//IL_08a6: Expected Obj, but got I
		//IL_08c9: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03e2: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I
		//IL_0978: Expected Obj, but got I
		//IL_099a: Expected Obj, but got I4
		//IL_08e7: Expected Obj, but got I
		//IL_0901: Expected Obj, but got I
		//IL_0912: Expected I, but got Obj
		//IL_0930: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04d0: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_0a39: Expected Obj, but got I
		//IL_0a49: Expected Obj, but got I
		//IL_0a5a: Expected Obj, but got I
		//IL_0a6a: Expected Obj, but got I
		//IL_0a8c: Expected Obj, but got I4
		//IL_09b8: Expected Obj, but got I
		//IL_09d2: Expected Obj, but got I
		//IL_09e3: Expected I, but got Obj
		//IL_0a01: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I
		//IL_0459: Expected Obj, but got I
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_0517: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I4
		//IL_0aaa: Expected Obj, but got I
		//IL_0ac4: Expected Obj, but got I
		//IL_0ad5: Expected I, but got Obj
		//IL_0af3: Expected Obj, but got I
		//IL_0547: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I4
		//IL_0b45: Expected Obj, but got I4
		//IL_0b8a: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_06e3: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I8
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_070e: Expected Obj, but got I4
		//IL_0b6c: Expected Obj, but got I4
		//IL_0743: Expected Obj, but got I4
		//IL_0772: Expected Obj, but got I
		//IL_078e: Expected Obj, but got I4
		//IL_07fc: Expected Obj, but got I4
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected Obj, but got Unknown
		//IL_07b9: Expected I, but got Obj
		//IL_07d3: Expected Obj, but got I
		//IL_07e5: Expected Obj, but got I4
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
		bool flag2 = titleFont != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		ScreenFont screenFont = null;
		if (!flag3)
		{
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			obj4 = 0;
			screenFont = screenFont2;
		}
		object obj6 = this + 224;
		obj6 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X21_v4-60]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		object obj9 = 0;
		ScreenFont screenFont3 = null;
		if (!flag6)
		{
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			obj9 = 0;
			screenFont3 = screenFont4;
		}
		object obj11 = this + 232;
		obj11 = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v7-A8]");
		bool flag8 = (UnityEngine.Object)0 != null;
		bool flag9 = !flag8;
		int num = 0;
		GillaMapVote.Canvas canvas = null;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GillaMapVote.Canvas canvas2 = default;
			canvas2._002Ector(board, 512, 128);
			int num2 = 128;
			num = 512;
			canvas = canvas2;
		}
		object obj16 = this + 192;
		obj16 = canvas;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v26+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v26+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8170]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v45+8]");
		Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v45+8]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v26+E4]");
			bool flag12 = (nint)0 == 0;
			object obj22 = !flag12;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v49+A0]");
				obj19 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8190]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81A0]");
			object obj25 = 0;
			Func<System.__Canon, System.__Canon> func = default;
			func._002Ector(obj19, (IntPtr)obj25);
			object obj26 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v48+A0]");
			object obj27 = (nint)0 + (nint)8;
			obj27 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num2 = 0;
			selector = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X21_v10-78]");
		IEnumerable<System.__Canon> source = Enumerable.Select((IEnumerable<System.__Canon>)0, selector);
		System.__Canon[] array = Enumerable.ToArray(source);
		object obj28 = this + 200;
		obj28 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj29 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v34+E4]");
		bool flag13 = (nint)0 == 0;
		object obj30 = !flag13;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v34+A0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v39+10]");
		Func<System.__Canon, System.__Canon> selector2 = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v39+10]");
		bool flag14 = (nint)0 == 0;
		object obj32 = !flag14;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v34+E4]");
			bool flag15 = (nint)0 == 0;
			object obj33 = !flag15;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj34 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v43+A0]");
				obj31 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8190]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81A8]");
			object obj36 = 0;
			Func<System.__Canon, System.__Canon> func2 = default;
			func2._002Ector(obj31, (IntPtr)obj36);
			object obj37 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v42+A0]");
			object obj38 = (nint)0 + (nint)16;
			obj38 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num2 = 0;
			selector2 = func2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X20_v14-98]");
		IEnumerable<System.__Canon> source2 = Enumerable.Select((IEnumerable<System.__Canon>)0, selector2);
		System.__Canon[] array2 = Enumerable.ToArray(source2);
		object obj39 = this + 208;
		obj39 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj40 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v42+E4]");
		bool flag16 = (nint)0 == 0;
		object obj41 = !flag16;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj40 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v42+A0]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8168]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v33+18]");
		Func<System.__Canon, System.__Canon> selector3 = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v33+18]");
		bool flag17 = (nint)0 == 0;
		object obj45 = !flag17;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v42+E4]");
			bool flag18 = (nint)0 == 0;
			object obj46 = !flag18;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj47 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v37+A0]");
				obj42 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8188]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81B0]");
			object obj49 = 0;
			Func<System.__Canon, System.__Canon> func3 = default;
			func3._002Ector(obj42, (IntPtr)obj49);
			object obj50 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v36+A0]");
			object obj51 = (nint)0 + (nint)24;
			obj51 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num2 = 0;
			selector3 = func3;
		}
		object obj52 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X20_v17-B0]");
		IEnumerable<System.__Canon> source3 = Enumerable.Select((IEnumerable<System.__Canon>)0, selector3);
		System.__Canon[] array3 = Enumerable.ToArray(source3);
		object obj53 = this + 216;
		obj53 = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj54 = this + 272;
		drawn = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Draw(null);
		object obj55 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v53+E4]");
		bool flag19 = (nint)0 == 0;
		object obj56 = !flag19;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
		object obj57 = 0;
		object obj58 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v58+E4]");
		bool flag20 = (nint)0 == 0;
		object obj59 = !flag20;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj60 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v62+E4]");
		bool flag21 = (nint)0 == 0;
		object obj61 = !flag21;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj60 = obj57;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v62+A0]");
		object obj62 = 0;
		obj62 = this;
		object obj63 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PressKey[] array4 = panels;
		if (array4.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8198]");
		object obj65 = 0;
		object obj66 = array4.Length & 0xFFFFFFFFL;
		object obj67 = array4 + 32;
		object obj68 = 0;
		GillaSplashLobby gillaSplashLobby = this;
		Action<System.__Canon> action = default;
		while (true)
		{
			bool flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66);
			object obj69 = !flag22;
			if (obj69 != null)
			{
				break;
			}
			object obj70 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v67+E4]");
			bool flag23 = (nint)0 == 0;
			object obj71 = !flag23;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X27_v6+v147 @ X24_v7*8]");
			bool flag24 = (UnityEngine.Object)0 != null;
			bool flag25 = !flag24;
			obj52 = 0;
			gillaSplashLobby = null;
			if (!flag25)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action._002Ector((object)this, (IntPtr)obj65);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X27_v6+v147 @ X24_v7*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action;
				int num2 = 0;
				obj52 = 0;
				gillaSplashLobby = (GillaSplashLobby)(object)action;
			}
			obj66 = array4.Length;
			obj68++;
			if ((nint)obj68 >= array4.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnDisable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I8
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_013c: Expected I, but got Obj
		//IL_0379: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_03df: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		PressKey[] array = panels;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		if (array.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8198]");
			object obj3 = 0;
			object obj4 = array.Length & 0xFFFFFFFFL;
			object obj5 = array + 32;
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			nint num = default;
			IntPtr intPtr = num;
			object obj10 = 0;
			Action<System.__Canon> action = default;
			bool flag5;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj11 = !flag;
				if (obj11 == null)
				{
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v36+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X27_v5+v83 @ X24_v6*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					obj9 = 0;
					num = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action._002Ector((object)this, (IntPtr)obj3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X27_v5+v83 @ X24_v6*8]");
						((PressKey)0).Pressed -= (Action<PressKey>)action;
						obj6 = 0;
						obj9 = 0;
						num = (nint)action;
					}
					obj4 = array.Length;
					obj10++;
					flag5 = (nint)obj10 < array.Length;
					obj8 = obj9;
					intPtr = num;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag5);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj14;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v9+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj20 == this)
		{
			object obj22 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v13+E4]");
			bool flag9 = (nint)0 == 0;
			object obj23 = !flag9;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj24 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v17+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v17+A0]");
			object obj26 = 0;
			obj26 = 0;
			object obj27 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0e9a: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I4
		//IL_0eb0: Expected I, but got Obj
		//IL_0ec0: Expected Obj, but got I
		//IL_0ee2: Expected Obj, but got I4
		//IL_114d: Expected Obj, but got I
		//IL_115d: Expected Obj, but got I
		//IL_117f: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_00b8: Expected I, but got Obj
		//IL_0f22: Expected Obj, but got I4
		//IL_0f5a: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I
		//IL_0f7e: Expected Obj, but got I
		//IL_0fa9: Expected Obj, but got I
		//IL_053c: Expected Obj, but got I4
		//IL_054c: Expected Obj, but got I
		//IL_1003: Expected Obj, but got I4
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected Obj, but got Unknown
		//IL_102c: Expected Obj, but got I4
		//IL_1047: Invalid comparison between F4 and I4
		//IL_0502: Expected Obj, but got I4
		//IL_0908: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I4
		//IL_0574: Expected Obj, but got I4
		//IL_058f: Invalid comparison between F4 and I4
		//IL_051a: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_0b86: Expected Obj, but got I4
		//IL_0970: Expected Obj, but got I
		//IL_098a: Expected Obj, but got I
		//IL_05bf: Expected Obj, but got I
		//IL_05e1: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_0299: Invalid comparison between F4 and I4
		//IL_0610: Expected Obj, but got I
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected Obj, but got Unknown
		//IL_08ad: Expected Obj, but got I4
		//IL_09d6: Expected Obj, but got I
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected Obj, but got Unknown
		//IL_0402: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I4
		//IL_06ac: Invalid comparison between F4 and I4
		//IL_0c43: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I4
		//IL_037a: Invalid comparison between F4 and I4
		//IL_06dc: Expected Obj, but got I
		//IL_06fe: Expected Obj, but got I4
		//IL_10d6: Expected Obj, but got I
		//IL_1100: Expected Obj, but got I4
		//IL_0caa: Expected Obj, but got I4
		//IL_0cc4: Invalid comparison between F4 and I4
		//IL_0e32: Expected Obj, but got I4
		//IL_0aa1: Expected Obj, but got I4
		//IL_0feb: Expected Obj, but got I4
		//IL_0d78: Expected Obj, but got I4
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected Obj, but got Unknown
		//IL_0b04: Expected Obj, but got I4
		//IL_0867: Expected Obj, but got I
		//IL_0874: Expected Obj, but got I4
		//IL_07aa: Expected Obj, but got I4
		//IL_07c4: Invalid comparison between F4 and I4
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0b4e: Expected Obj, but got I4
		//IL_0814: Expected Obj, but got I4
		//IL_082d: Invalid comparison between F4 and I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		nint num = (nint)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num2 = (nint)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v10 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		nint num3 = num2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)obj4;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v11 (Il2CppClass<UnityEngine.Object>)+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
		UnityEngine.Object obj10 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		UnityEngine.Object obj12 = null;
		NetworkBootstrap networkBootstrap;
		UnityEngine.Object obj13;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
			bool flag7 = (nint)0 == 0;
			obj12 = null;
			networkBootstrap = null;
			obj13 = null;
			if (flag7)
			{
				goto IL_08d3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X21_v6 (UnityEngine.Object)+B0]");
			obj12 = (UnityEngine.Object)0;
		}
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v15+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = obj12 != null;
		bool flag10 = !flag9;
		UnityEngine.Object obj16 = null;
		obj4 = null;
		if (!flag10)
		{
			bool flag11 = (object)obj12 == null;
			networkBootstrap = null;
			obj13 = null;
			obj4 = null;
			if (flag11)
			{
				goto IL_08d3;
			}
			bool isRunning = ((NetworkRunner)obj12).IsRunning;
			bool flag12 = !isRunning;
			obj16 = null;
			obj4 = null;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
				bool flag13 = (nint)0 == 0;
				networkBootstrap = null;
				obj13 = null;
				obj4 = null;
				if (flag13)
				{
					goto IL_08d3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X21_v6 (UnityEngine.Object)+A4]");
				bool flag14 = (nint)0 == 0;
				object obj17 = !flag14;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X21_v6 (UnityEngine.Object)+90]");
					bool flag15 = (nint)0 < (nint)2;
					object obj18 = !flag15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X21_v6 (UnityEngine.Object)+90]");
					float num4 = 0f - 2f;
					bool flag16 = num4 == 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X21_v6 (UnityEngine.Object)+90]");
					if ((nint)0 == 2)
					{
						bool isSharedModeMasterClient = ((NetworkRunner)obj12).IsSharedModeMasterClient;
						bool flag17 = !isSharedModeMasterClient;
						obj16 = null;
						if (!flag17)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
							bool settled = ((NetworkBootstrap)0).Settled;
							bool flag18 = !settled;
							obj16 = null;
							if (!flag18)
							{
								float unscaledTime = Time.unscaledTime;
								double num5 = nextCheck;
								bool flag19 = unscaledTime < nextCheck;
								obj18 = !flag19;
								num4 = unscaledTime - nextCheck;
								flag16 = num4 == 0f;
								bool flag20 = unscaledTime < nextCheck;
								obj16 = null;
								if (!flag20)
								{
									float unscaledTime2 = Time.unscaledTime;
									unscaledTime = unscaledTime2 + 2f;
									nextCheck = unscaledTime;
									MakeGame((NetworkRunner)obj12);
									num5 = 2.0;
									obj16 = obj12;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
						object obj19 = 0;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v56+E4]");
						bool flag21 = (nint)0 == 0;
						object obj21 = !flag21;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaSplashGame current = GillaSplashGame.Current;
						obj4 = current;
						goto IL_0f30;
					}
				}
				obj16 = null;
				obj4 = null;
			}
		}
		goto IL_0f30;
		IL_0f30:
		object obj22 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v20+E4]");
		bool flag22 = (nint)0 == 0;
		object obj23 = !flag22;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj4 != null)
		{
			bool flag23 = (object)obj4 == null;
			networkBootstrap = null;
			obj13 = null;
			if (flag23)
			{
				goto IL_08d3;
			}
			bool live = ((GillaSplashGame)obj4).Live;
			bool flag16 = !live;
			bool flag20 = !flag16;
			object obj24 = !flag20;
			if (obj24 == null)
			{
				object obj18 = 0;
			}
			else
			{
				object obj18 = 0;
				obj4 = null;
			}
		}
		UnityEngine.Object game = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
		Follow((GillaSplashGame)game, (NetworkBootstrap)0);
		GillaSplashGate[] array = gates;
		bool flag24 = gates == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
		networkBootstrap = (NetworkBootstrap)0;
		obj13 = obj4;
		if (!flag24)
		{
			UnityEngine.Object obj25 = (UnityEngine.Object)4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v10+8]");
			NetworkBootstrap networkBootstrap2 = (NetworkBootstrap)0;
			UnityEngine.Object obj26 = obj4;
			GameObject gameObject = default;
			UnityEngine.Object obj38 = default;
			object obj45;
			do
			{
				obj9 = array.Length;
				object obj27 = obj25 - 4;
				bool flag25 = (nint)obj27 < array.Length;
				object obj18 = !flag25;
				float num4 = (float)obj27 - (float)array.Length;
				bool flag16 = num4 == 0f;
				bool flag20 = (nint)obj27 >= array.Length;
				obj12 = obj25;
				networkBootstrap = networkBootstrap2;
				obj13 = obj26;
				bool flag36;
				if (!flag20)
				{
					bool flag26 = (nint)obj27 < array.Length;
					obj18 = !flag26;
					num4 = (float)obj27 - (float)array.Length;
					flag16 = num4 == 0f;
					if (obj18 == null)
					{
						object obj28 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v29+E4]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v29+E4]");
						bool flag27 = (nint)0 == 0;
						object obj29 = !flag27;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v14 (GillaSplashGate[])+v187 @ X22_v6 (UnityEngine.Object)*8]");
						bool flag28 = (UnityEngine.Object)0 != null;
						bool flag29 = !flag28;
						networkBootstrap = null;
						obj13 = null;
						if (flag29)
						{
							goto IL_0879;
						}
						GillaSplashGate[] array2 = gates;
						bool flag30 = gates == null;
						obj12 = obj25;
						networkBootstrap = null;
						obj13 = null;
						if (flag30)
						{
							break;
						}
						bool flag31 = (nint)obj27 < array2.Length;
						obj18 = !flag31;
						num4 = (float)obj27 - (float)array2.Length;
						flag16 = num4 == 0f;
						if (obj18 == null)
						{
							object obj30 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v34+E4]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v34+E4]");
							bool flag32 = (nint)0 == 0;
							object obj31 = !flag32;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (obj4 != null)
							{
								bool flag33 = (object)obj4 == null;
								obj12 = obj25;
								networkBootstrap = null;
								obj13 = null;
								if (flag33)
								{
									break;
								}
								byte phase = ((GillaSplashGame)obj4).Phase;
								int num6 = phase & 0xFF;
								bool flag34 = num6 < 2;
								obj18 = !flag34;
								num4 = (float)num6 - 2f;
								flag16 = num4 == 0f;
								if (num6 == 2)
								{
									int level = ((GillaSplashGame)obj4).Level;
									bool flag35 = (nint)obj27 < level;
									obj18 = !flag35;
									num4 = (float)obj27 - (float)level;
									flag16 = num4 == 0f;
									flag36 = flag16;
									goto IL_0fbf;
								}
							}
							flag36 = false;
							goto IL_0fbf;
						}
					}
					throw new IndexOutOfRangeException();
				}
				object obj32 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v66+E4]");
				bool flag37 = (nint)0 == 0;
				object obj33 = !flag37;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag38 = dark == null;
				bool flag39 = !flag38;
				bool flag40 = false;
				UnityEngine.Object obj34 = null;
				if (!flag39)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8330]");
					object obj36 = 0;
					gameObject._002Ector((string)obj36);
					bool flag41 = (object)gameObject == null;
					networkBootstrap = null;
					obj13 = (UnityEngine.Object)obj36;
					if (flag41)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8328]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					dark = (GillaDarkness)obj38;
					object obj39 = this + 256;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag42 = (object)dark == null;
					networkBootstrap = null;
					obj13 = obj38;
					if (flag42)
					{
						break;
					}
					Transform transform = dark.transform;
					Transform transform2 = base.transform;
					bool flag43 = (object)transform == null;
					networkBootstrap = null;
					obj13 = null;
					if (flag43)
					{
						break;
					}
					transform.SetParent(transform2, worldPositionStays: false);
					bool flag44 = (object)dark == null;
					object obj40 = 0;
					networkBootstrap = null;
					obj13 = transform2;
					if (flag44)
					{
						break;
					}
					obj13 = darkShader;
					object obj41 = dark + 40;
					obj41 = darkShader;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag45 = (object)dark == null;
					obj40 = 0;
					networkBootstrap = null;
					if (flag45)
					{
						break;
					}
					obj34 = lightsOutSound;
					object obj42 = dark + 48;
					obj42 = lightsOutSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj40 = 0;
					flag40 = false;
				}
				object obj43 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v71+E4]");
				bool flag46 = (nint)0 == 0;
				object obj44 = !flag46;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj4 != null && ~(inGame ? 1u : 0u) == 0)
				{
					bool flag47 = (object)obj4 == null;
					networkBootstrap = null;
					obj13 = null;
					if (flag47)
					{
						break;
					}
					byte phase2 = ((GillaSplashGame)obj4).Phase;
					int num7 = phase2 & 0xFF;
					bool flag48 = num7 < 1;
					obj18 = !flag48;
					num4 = (float)num7 - 1f;
					if (num7 != 1)
					{
						byte phase3 = ((GillaSplashGame)obj4).Phase;
						int num8 = phase3 & 0xFF;
						bool flag49 = num8 < 2;
						obj18 = !flag49;
						num4 = (float)num8 - 2f;
						flag16 = num4 == 0f;
						if (num8 != 2)
						{
							byte phase4 = ((GillaSplashGame)obj4).Phase;
							obj12 = dark;
							int num9 = phase4 & 0xFF;
							bool flag50 = num9 < 3;
							obj18 = !flag50;
							num4 = (float)num9 - 3f;
							if (num9 == 3)
							{
								goto IL_10b9;
							}
							goto IL_110e;
						}
					}
					obj12 = dark;
					goto IL_10b9;
				}
				obj12 = dark;
				goto IL_110e;
				IL_0879:
				array = gates;
				obj12 = (UnityEngine.Object)(obj25 + 1);
				bool flag51 = gates == null;
				obj45 = !flag51;
				obj25 = obj12;
				networkBootstrap2 = networkBootstrap;
				obj26 = obj13;
				continue;
				IL_108a:
				float unscaledTime3 = Time.unscaledTime;
				if (!(unscaledTime3 < nextDraw))
				{
					float unscaledTime4 = Time.unscaledTime;
					float num10 = unscaledTime4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					float num11 = num10 + 0f;
					nextDraw = num11;
					Draw((GillaSplashGame)obj4);
				}
				return;
				IL_10b9:
				int round = ((GillaSplashGame)obj4).Round;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
				object obj46 = 0;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v42+E4]");
				bool flag52 = (nint)0 == 0;
				object obj48 = !flag52;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float unscaledTime = GillaSplashGame.Dimness(round);
				bool flag53 = (object)obj12 == null;
				networkBootstrap = null;
				obj13 = null;
				if (flag53)
				{
					break;
				}
				obj12 = dark;
				bool flag54 = ((GillaSplashGame)obj4).Dark;
				bool flag55 = (object)dark == null;
				object obj49 = !flag55;
				if (obj49 == null)
				{
					networkBootstrap = null;
					obj13 = null;
					break;
				}
				goto IL_108a;
				IL_0fbf:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v18 (GillaSplashGate[])+v187 @ X22_v6 (UnityEngine.Object)*8]");
				bool flag56 = (nint)0 == 0;
				obj12 = obj25;
				networkBootstrap = null;
				obj13 = (UnityEngine.Object)flag36;
				if (flag56)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v18 (GillaSplashGate[])+v187 @ X22_v6 (UnityEngine.Object)*8]");
				((GillaSplashGate)0).Set(flag36);
				networkBootstrap = null;
				obj13 = (UnityEngine.Object)flag36;
				goto IL_0879;
				IL_110e:
				bool flag57 = (object)obj12 == null;
				networkBootstrap = null;
				obj13 = null;
				if (flag57)
				{
					break;
				}
				_ = 0;
				flag54 = false;
				goto IL_108a;
			}
			while (obj45 != null);
		}
		goto IL_08d3;
		IL_08d3:
		throw new NullReferenceException();
	}

	private unsafe void MakeGame(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0576: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0107: Expected VT, but got I4
		//IL_05b6: Expected Obj, but got I
		//IL_05c3: Expected VT, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_05d8: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0600: Expected Obj, but got I
		//IL_0608: Expected VT, but got Obj
		//IL_0610: Expected VT, but got Obj
		//IL_061d: Expected VT, but got Obj
		//IL_0232: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_0362: Expected VT, but got I4
		//IL_0263: Expected VT, but got Ref
		//IL_0263: Expected VT, but got I4
		//IL_02a2: Expected VT, but got Obj
		//IL_037e: Invalid comparison between VT and I4
		//IL_02c0: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I4
		//IL_03be: Expected I, but got Obj
		//IL_03c6: Expected Obj, but got I
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_0515: Expected VT, but got I4
		//IL_0537: Expected VT, but got I4
		//IL_040c: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got Ref
		//IL_0450: Expected I, but got Obj
		//IL_045b: Expected Obj, but got I
		//IL_0489: Expected Obj, but got VT
		//IL_04be: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current = GillaSplashGame.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)current != (UnityEngine.Object)null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v75+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplashGame current2 = GillaSplashGame.Current;
			bool flag4 = (object)current2 == null;
			Vector3? vector = (Vector3?)(object)0;
			UnityEngine.Object obj9 = null;
			NetworkRunner networkRunner = runner;
			if (flag4)
			{
				goto IL_04e9;
			}
			bool live = current2.Live;
			bool flag5 = !live;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				return;
			}
		}
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v21+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)gamePrefab == (UnityEngine.Object)null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v69+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8340]");
			object message = 0;
			Debug.LogError(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj16 = 0;
		Vector3? vector2 = (Vector3)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v22+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
		object obj20 = 0;
		Quaternion? quaternion = (Quaternion?)obj19;
		Quaternion quaternion2 = (Quaternion)obj20;
		Quaternion? quaternion3 = (Quaternion)obj20;
		if ((object)runner != null)
		{
			Quaternion? quaternion4 = default;
			NetworkObject networkObject = runner.Spawn(gamePrefab, vector2, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion4), null, (NetworkSpawnFlags)0);
			SessionInfo sessionInfo = runner.SessionInfo__BackingField;
			bool flag8 = runner.SessionInfo__BackingField == null;
			quaternion = quaternion3;
			Vector3? vector = vector2;
			quaternion2 = (Quaternion)gamePrefab;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8338]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5650]");
				object obj22 = 0;
				string message2 = (string)obj21 + sessionInfo.Name__BackingField + (string)obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v59+E4]");
				bool flag9 = (nint)0 == 0;
				object obj25 = !flag9;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message2);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			Vector3? vector = (Vector3?)(object)0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag10 = quaternion2 != (Quaternion)(object)1;
		NullReferenceException ex3 = ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NetworkRunner networkRunner2 = default;
			nint num = (nint)networkRunner2;
			UnityEngine.Object obj9 = (UnityEngine.Object)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj27 = default;
			object obj26 = obj27 & 1;
			bool flag11 = obj26 == null;
			NetworkRunner networkRunner = networkRunner2;
			if (!flag11)
			{
				object obj28 = 0;
				networkRunner = networkRunner2;
				object obj30 = default;
				object obj29 = (object)(&obj30);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				if ((object)networkRunner2 != null)
				{
					nint num2 = (nint)networkRunner;
					SceneRef sceneRef = ((Fusion.NetworkSceneManagerDummy)(object)networkRunner2).GetSceneRef((GameObject)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string text = default;
					string text2 = default;
					string message3 = text + (string)sceneRef + text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v50+E4]");
					bool flag12 = (nint)0 == 0;
					object obj31 = !flag12;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogError(message3);
					return;
				}
				goto IL_04e9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj32 = networkRunner;
			quaternion2 = (Quaternion)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			Vector3? vector = (Vector3?)(object)0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_04e9:
		throw new NullReferenceException();
	}

	public unsafe void VoteFor(int map)
	{
		//IL_0010: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_0200: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current = GillaSplashGame.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v2+8]");
		UnityEngine.Object obj12 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)current == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null || !current.Live)
		{
			return;
		}
		byte phase = current.Phase;
		int num = phase & 0xFF;
		bool flag7 = num == 0;
		object obj15 = !flag7;
		if (obj15 != null)
		{
			return;
		}
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v19+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v2+8]");
		bool flag9 = (UnityEngine.Object)0 == null;
		bool flag10 = !flag9;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X21_v4 (UnityEngine.Object)+90]");
			if ((nint)0 == 2)
			{
				object obj19 = default;
				current.RPC_Vote((byte)map, (RpcInfo)(&obj19));
			}
		}
	}

	private void OnPanel(PressKey key)
	{
		//IL_0026: Expected Obj, but got I4
		int num = Array.IndexOf((System.__Canon[])(object)panels, (System.__Canon)(object)key);
		((GillaSplashLobby)num).VoteFor(num);
	}

	private unsafe void Follow(GillaSplashGame game, NetworkBootstrap boot)
	{
		//IL_1173: Expected Obj, but got I
		//IL_1183: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I
		//IL_037d: Expected I4, but got I8
		//IL_0397: Expected Obj, but got I4
		//IL_03dc: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I4
		//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c6: Expected Obj, but got Unknown
		//IL_0486: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I4
		//IL_1216: Expected VT, but got Ref
		//IL_121e: Expected Obj, but got VT
		//IL_04ed: Expected Obj, but got I4
		//IL_035c: Expected VT, but got Ref
		//IL_0364: Expected Obj, but got VT
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05c6: Expected VT, but got I4
		//IL_1235: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Expected Obj, but got Unknown
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_1247: Expected Obj, but got Unknown
		//IL_0513: Expected Obj, but got I
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected Obj, but got Unknown
		//IL_06d4: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I4
		//IL_060c: Expected VT, but got I4
		//IL_055a: Expected Obj, but got I4
		//IL_0563: Expected VT, but got I4
		//IL_0652: Expected VT, but got I4
		//IL_0736: Expected Obj, but got I4
		//IL_12c6: Expected Obj, but got I4
		//IL_0d55: Expected Obj, but got I4
		//IL_0b42: Expected F4, but got I
		//IL_0b65: Expected F4, but got I
		//IL_0bcc: Expected Obj, but got I
		//IL_0bee: Expected Obj, but got I4
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0787: Expected Obj, but got I4
		//IL_103e: Expected F4, but got I8
		//IL_0f63: Invalid comparison between F4 and I4
		//IL_0c33: Expected Obj, but got I4
		//IL_07d2: Expected VT, but got I4
		//IL_1326: Invalid comparison between F4 and I4
		//IL_0cd6: Expected F4, but got I
		//IL_0cf9: Expected F4, but got I
		//IL_0d02: Expected VT, but got I4
		//IL_0fe2: Invalid comparison between F4 and I4
		//IL_0c59: Expected Obj, but got I
		//IL_105d: Expected I4, but got F4
		//IL_1066: Invalid comparison between F4 and I4
		//IL_1077: Expected Obj, but got I4
		//IL_1090: Invalid comparison between F4 and I4
		//IL_10a1: Expected Obj, but got I4
		//IL_0e77: Expected Obj, but got I4
		//IL_0e91: Expected Obj, but got I4
		//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb5: Expected Obj, but got Unknown
		//IL_0ecf: Expected Obj, but got I4
		//IL_0ca0: Expected Obj, but got I4
		//IL_0ca9: Expected VT, but got I4
		//IL_083f: Expected VT, but got I4
		//IL_10e6: Expected Obj, but got I4
		//IL_12e4: Expected Obj, but got I
		//IL_130e: Expected Obj, but got I4
		//IL_0e31: Expected F4, but got I
		//IL_0e49: Expected F4, but got I
		//IL_1148: Expected F4, but got I
		//IL_0f14: Expected F4, but got I
		//IL_0f2c: Expected F4, but got I
		//IL_08dc: Expected Obj, but got I4
		//IL_08f8: Expected Obj, but got I4
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected VT, but got Unknown
		//IL_0922: Expected Ref, but got VT
		//IL_0946: Expected VT, but got I4
		//IL_094e: Expected Obj, but got Ref
		//IL_097c: Expected Obj, but got I
		//IL_099e: Expected Obj, but got I4
		//IL_09e3: Expected Obj, but got I4
		//IL_0a8c: Expected VT, but got Ref
		//IL_0aa6: Expected F4, but got I
		//IL_0abe: Expected F4, but got I
		//IL_0ac7: Expected VT, but got I4
		//IL_0a09: Expected Obj, but got I
		//IL_0a50: Expected Obj, but got I4
		//IL_0a61: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		bool flag = (byte)(~(wantBack ? 1u : 0u)) != 0;
		NetworkBootstrap networkBootstrap = boot;
		UnityEngine.Object obj3 = game;
		if (!flag)
		{
			object obj4 = obj;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v99+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v128+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (UnityEngine.Object)obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v102+A0]");
				object obj10 = 0;
				object obj11 = obj10;
				if (obj10 == null)
				{
					goto IL_114e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v104+A9]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				networkBootstrap = null;
				obj3 = null;
				if (obj12 != null)
				{
					goto IL_0126;
				}
			}
			Back();
			networkBootstrap = null;
			obj3 = null;
		}
		goto IL_0126;
		IL_0466:
		object obj13 = obj;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v77+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v102+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = (UnityEngine.Object)obj15 == null;
		bool flag8 = !flag7;
		object obj17 = !flag8;
		GillaSplashGame gillaSplashGame;
		PlayerRef playerRef;
		if (obj17 == null)
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v84+A0]");
			object obj19 = 0;
			object obj20 = obj19;
			if (obj19 == null)
			{
				goto IL_114e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v86+A9]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			playerRef = (PlayerRef)0;
			gillaSplashGame = null;
			if (obj21 != null)
			{
				goto IL_0688;
			}
		}
		wantStart = false;
		object obj23 = default;
		object obj22 = obj23 - 1;
		bool flag10 = obj22 == null;
		object obj25 = default;
		object obj24 = obj25 & flag10;
		bool flag11 = (nint)obj24 != 1;
		playerRef = (PlayerRef)0;
		gillaSplashGame = null;
		PlayerRef localPlayer;
		if (!flag11)
		{
			byte phase = game.Phase;
			int num = phase & 0xFF;
			bool flag12 = num == 0;
			playerRef = (PlayerRef)0;
			gillaSplashGame = null;
			if (!flag12)
			{
				byte phase2 = game.Phase;
				int num2 = phase2 & 0xFF;
				bool flag13 = num2 == 4;
				playerRef = (PlayerRef)0;
				gillaSplashGame = null;
				if (!flag13)
				{
					GoToStart(game, localPlayer);
					playerRef = localPlayer;
					gillaSplashGame = game;
				}
			}
		}
		goto IL_0688;
		IL_0688:
		bool flag14 = inGame;
		if (~(inGame ? 1u : 0u) == 0)
		{
			byte phase3 = game.Phase;
			int num3 = phase3 & 0xFF;
			object obj26 = num3 - 2;
			bool flag15 = obj26 == null;
			flag14 = flag15;
		}
		object obj27 = obj25 & 1;
		object obj28 = flag14 & obj27;
		bool flag16 = obj28 == null;
		float num5 = default;
		float num4 = num5;
		AudioClip audioClip = (AudioClip)(object)gillaSplashGame;
		if (!flag16)
		{
			bool flag17 = (nint)obj23 != 1;
			num4 = num5;
			audioClip = (AudioClip)(object)gillaSplashGame;
			if (!flag17)
			{
				bool flag18 = (byte)(~(through ? 1u : 0u)) != 0;
				object obj29 = !flag18;
				num4 = num5;
				audioClip = (AudioClip)(object)gillaSplashGame;
				if (obj29 == null)
				{
					Camera main = Camera.main;
					object obj30 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v60+E4]");
					bool flag19 = (nint)0 == 0;
					object obj31 = !flag19;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag20 = main != null;
					bool flag21 = !flag20;
					num4 = num5;
					playerRef = (PlayerRef)0;
					audioClip = null;
					if (!flag21)
					{
						int level = game.Level;
						Bounds[] array = finishes;
						if (finishes != null)
						{
							bool flag22 = level >= array.Length;
							num4 = num5;
							playerRef = (PlayerRef)0;
							audioClip = null;
							if (flag22)
							{
								goto IL_0acc;
							}
							int level2 = game.Level;
							Camera main2 = Camera.main;
							if ((object)main2 != null)
							{
								Transform transform = main2.transform;
								if ((object)transform != null)
								{
									Vector3 position = transform.position;
									bool flag23 = level2 < array.Length;
									object obj32 = !flag23;
									if (obj32 == null)
									{
										object obj33 = level2 * 24;
										object obj34 = (object)finishes + obj33;
										Bounds bounds = (Bounds)(obj34 + 32);
										Vector3 point = default;
										bool flag24 = ((Bounds*)bounds)->Internal_Contains(ref point);
										bool flag25 = !flag24;
										num4 = num5;
										playerRef = (PlayerRef)0;
										audioClip = (AudioClip)(&point);
										if (!flag25)
										{
											object obj35 = obj;
											object obj36 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X8_v65+A0]");
											object obj37 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X0_v90+E4]");
											bool flag26 = (nint)0 == 0;
											object obj38 = !flag26;
											if (obj38 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag27 = (UnityEngine.Object)obj37 == null;
											bool flag28 = !flag27;
											object obj39 = !flag28;
											if (obj39 == null)
											{
												object obj40 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v70+A0]");
												object obj41 = 0;
												object obj42 = obj41;
												if (obj41 == null)
												{
													goto IL_114e;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v72+A9]");
												bool flag29 = (nint)0 == 0;
												object obj43 = !flag29;
												num4 = num5;
												playerRef = (PlayerRef)0;
												audioClip = null;
												if (obj43 != null)
												{
													goto IL_0acc;
												}
											}
											through = true;
											object obj44 = default;
											game.RPC_Finished((RpcInfo)(&obj44));
											audioClip = throughSound;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
											num4 = 0f;
											AudioClip clip = throughSound;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
											Play(clip, 0f);
											playerRef = (PlayerRef)0;
										}
										goto IL_0acc;
									}
									goto IL_115c;
								}
							}
						}
						goto IL_114e;
					}
				}
			}
		}
		goto IL_0acc;
		IL_0d07:
		if (~(inGame ? 1u : 0u) == 0)
		{
			byte phase4 = game.Phase;
			int num6 = phase4 & 0xFF;
			bool flag30 = num6 == 0;
			object obj45 = !flag30;
			if (obj45 == null)
			{
				inGame = false;
				Back();
			}
		}
		byte phase5 = game.Phase;
		if (seenPhase != phase5)
		{
			if (seenPhase != 255 && ~(inGame ? 1u : 0u) == 0)
			{
				byte phase6 = game.Phase;
				int num7 = phase6 & 0xFF;
				if (num7 == 2)
				{
					audioClip = goSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					num4 = 0f;
					AudioClip clip2 = goSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					Play(clip2, 0f);
				}
				byte phase7 = game.Phase;
				int num8 = phase7 & 0xFF;
				object obj46 = num8 - 4;
				bool flag31 = obj46 == null;
				object obj47 = !flag31;
				object obj48 = ~obj25;
				object obj49 = obj47 | obj48;
				object obj50 = obj49 & 1;
				bool flag32 = obj50 == null;
				object obj51 = !flag32;
				if (obj51 == null && (nint)obj23 != 3)
				{
					audioClip = winSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					num4 = 0f;
					AudioClip clip3 = winSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					Play(clip3, 0f);
				}
			}
			byte phase8 = game.Phase;
			seenPhase = phase8;
		}
		byte phase9 = game.Phase;
		int num9 = phase9 & 0xFF;
		bool flag33 = num9 == 0;
		object obj52 = !flag33;
		if (obj52 == null)
		{
			num4 = game.VoteEnds;
			if (num4 > 0f)
			{
				num4 = game.VoteEnds;
				goto IL_0fd9;
			}
		}
		byte phase10 = game.Phase;
		int num10 = phase10 & 0xFF;
		if (num10 == 1)
		{
			num4 = game.PhaseEnds;
			goto IL_0fd9;
		}
		goto IL_1031;
		IL_131c:
		float num11;
		if (num11 == (float)lastTick)
		{
			return;
		}
		float num12 = num11 - 1f;
		lastTick = (int)num11;
		bool flag34 = num12 < 4f;
		object obj53 = !flag34;
		float num13 = num12 - 4f;
		bool flag35 = num13 == 0f;
		object obj54 = !flag35;
		object obj55 = obj53 & obj54;
		if (obj55 == null)
		{
			object obj56 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X0_v32+E4]");
			bool flag36 = (nint)0 == 0;
			object obj57 = !flag36;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (tickSound != null)
			{
				AudioClip clip4 = tickSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				Play(clip4, 0f);
			}
		}
		return;
		IL_0fd9:
		if (!(num4 > 0f))
		{
			goto IL_1031;
		}
		num4 = game.Now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj58 = 0;
		object obj59 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X0_v42+E4]");
		bool flag37 = (nint)0 == 0;
		object obj60 = !flag37;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		num11 = num4;
		goto IL_131c;
		IL_114e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_115c;
		IL_0126:
		object obj61 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7+E4]");
		bool flag38 = (nint)0 == 0;
		object obj62 = !flag38;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)game == (UnityEngine.Object)null)
		{
			if (~(inGame ? 1u : 0u) == 0)
			{
				object obj63 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v121+E4]");
				bool flag39 = (nint)0 == 0;
				object obj64 = !flag39;
				if (obj64 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (boot != null)
				{
					if ((object)boot == null)
					{
						goto IL_114e;
					}
					if (boot.Kind__BackingField == (NetworkBootstrap.Lobby)2)
					{
						Back();
					}
				}
			}
			inGame = false;
			return;
		}
		if ((object)game != null && (object)((SimulationBehaviour)game)._runner != null)
		{
			localPlayer = ((SimulationBehaviour)game)._runner.LocalPlayer;
			NetworkDictionary<PlayerRef, byte> players = game.Players;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			int num14 = game.Starts;
			if (num14 == seenStarts)
			{
				bool flag40 = (byte)(~(wantStart ? 1u : 0u)) != 0;
				object obj66 = !flag40;
				if (obj66 != null)
				{
					goto IL_0466;
				}
				playerRef = (PlayerRef)(&obj23);
				gillaSplashGame = (GillaSplashGame)localPlayer;
			}
			else
			{
				int num15 = (int)(seenStarts & 0x80000000L);
				bool flag41 = num15 == 0;
				object obj67 = !flag41;
				bool flag42;
				if (obj67 == null)
				{
					flag42 = true;
				}
				else
				{
					byte phase11 = game.Phase;
					int num16 = phase11 & 0xFF;
					object obj68 = num16 - 1;
					bool flag43 = obj68 == null;
					flag42 = flag43;
				}
				int num17 = game.Starts;
				object obj69 = obj25 & flag42;
				seenStarts = num17;
				bool flag44 = (nint)obj69 != 1;
				bool flag45 = false;
				if (!flag44)
				{
					bool flag46 = (nint)obj23 != 1;
					flag45 = false;
					if (!flag46)
					{
						byte phase12 = game.Phase;
						int num18 = phase12 & 0xFF;
						object obj70 = num18 - 1;
						bool flag47 = obj70 == null;
						flag45 = flag47;
					}
				}
				wantStart = flag45;
				bool flag48 = !flag45;
				playerRef = (PlayerRef)(&obj23);
				gillaSplashGame = (GillaSplashGame)localPlayer;
				if (!flag48)
				{
					goto IL_0466;
				}
			}
			goto IL_0688;
		}
		goto IL_114e;
		IL_115c:
		throw new IndexOutOfRangeException();
		IL_1031:
		num11 = 4.2949673E+09f;
		goto IL_131c;
		IL_0acc:
		object obj71 = inGame & obj27;
		bool flag49 = obj71 == null;
		object obj72 = obj23;
		if (!flag49)
		{
			bool flag50 = (nint)obj23 != 3;
			obj72 = obj23;
			if (!flag50)
			{
				audioClip = outSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				num4 = 0f;
				inGame = false;
				AudioClip clip5 = outSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				Play(clip5, 0f);
				Back();
				obj71 = inGame & obj27;
				obj72 = obj23;
			}
		}
		if (obj71 != null && (nint)obj72 == 4)
		{
			object obj73 = obj;
			object obj74 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v48+A0]");
			object obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X0_v67+E4]");
			bool flag51 = (nint)0 == 0;
			object obj76 = !flag51;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag52 = (UnityEngine.Object)obj75 == null;
			bool flag53 = !flag52;
			object obj77 = !flag53;
			if (obj77 == null)
			{
				object obj78 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v52+A0]");
				object obj79 = 0;
				object obj80 = obj79;
				if (obj79 == null)
				{
					goto IL_114e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v54+A9]");
				bool flag54 = (nint)0 == 0;
				object obj81 = !flag54;
				playerRef = (PlayerRef)0;
				audioClip = null;
				if (obj81 != null)
				{
					goto IL_0d07;
				}
			}
			audioClip = outSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			num4 = 0f;
			inGame = false;
			AudioClip clip6 = outSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			Play(clip6, 0f);
			playerRef = (PlayerRef)0;
		}
		goto IL_0d07;
	}

	private void GoToStart(GillaSplashGame game, PlayerRef me)
	{
		//IL_083f: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_0887: Expected Obj, but got I
		//IL_0897: Expected Obj, but got I
		//IL_08b9: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0954: Expected Obj, but got I
		//IL_0964: Expected Obj, but got I
		//IL_0986: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I4
		//IL_08d7: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_0902: Expected I, but got Obj
		//IL_0920: Expected Obj, but got I
		//IL_093f: Expected I, but got Obj
		//IL_0a21: Expected Obj, but got I
		//IL_0a31: Expected Obj, but got I
		//IL_0a53: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I
		//IL_09a4: Expected Obj, but got I
		//IL_09be: Expected Obj, but got I
		//IL_09cf: Expected I, but got Obj
		//IL_09ed: Expected Obj, but got I
		//IL_0a0c: Expected I, but got Obj
		//IL_04cf: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I
		//IL_0a71: Expected Obj, but got I
		//IL_0a8b: Expected Obj, but got I
		//IL_0a9c: Expected I, but got Obj
		//IL_0aba: Expected Obj, but got I
		//IL_0ad9: Expected I, but got Obj
		//IL_0477: Expected Obj, but got I
		//IL_0550: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_06eb: Expected VT, but got I4
		//IL_06eb: Expected VT, but got I4
		//IL_0707: Expected Obj, but got I
		//IL_0767: Expected Obj, but got I
		//IL_0786: Expected Obj, but got I
		//IL_07a7: Expected Obj, but got I
		//IL_07d1: Expected Obj, but got I4
		if ((object)game != null)
		{
			int level = game.Level;
			Transform[] array = starts;
			if (starts != null)
			{
				UnityEngine.Object obj3;
				if (level < array.Length)
				{
					int level2 = game.Level;
					bool flag = level2 < array.Length;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_080b;
					}
					object obj2 = starts + level2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v86+20]");
					obj3 = (UnityEngine.Object)0;
				}
				else
				{
					obj3 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = obj3 == null;
				bool flag4 = !flag3;
				object obj7 = !flag4;
				if (obj7 != null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
				object obj8 = 0;
				object obj9 = obj4;
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v9+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)obj11 != null)
				{
					object obj13 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v81+A0]");
					object obj14 = 0;
					object obj15 = obj14;
					if (obj14 == null)
					{
						goto IL_07fd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v83+A9]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					if (obj16 != null)
					{
						return;
					}
				}
				NetworkDictionary<PlayerRef, byte> players = game.Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81B8]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v16+E4]");
				bool flag7 = (nint)0 == 0;
				object obj20 = !flag7;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v16+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X9_v20+20]");
				Func<KeyValuePair<PlayerRef, byte>, bool> predicate = (Func<KeyValuePair<PlayerRef, byte>, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X9_v20+20]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v16+E4]");
					bool flag9 = (nint)0 == 0;
					object obj23 = !flag9;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj24 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v79+A0]");
						obj21 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8380]");
					object obj26 = 0;
					Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
					func._002Ector(obj21, (IntPtr)obj26);
					object obj27 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v78+A0]");
					object obj28 = (nint)0 + (nint)32;
					obj28 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					predicate = func;
					nint num = unchecked((nint)null);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8360]");
				object obj29 = 0;
				IEnumerable<KeyValuePair<PlayerRef, byte>> source2 = default;
				IEnumerable<KeyValuePair<PlayerRef, byte>> source = Enumerable.Where(source2, predicate);
				object obj30 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21+E4]");
				bool flag10 = (nint)0 == 0;
				object obj31 = !flag10;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj30 = obj18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21+A0]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v18+28]");
				Func<KeyValuePair<PlayerRef, byte>, int> selector = (Func<KeyValuePair<PlayerRef, byte>, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v18+28]");
				bool flag11 = (nint)0 == 0;
				object obj33 = !flag11;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21+E4]");
					bool flag12 = (nint)0 == 0;
					object obj34 = !flag12;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj35 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v71+A0]");
						obj32 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8368]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8388]");
					object obj37 = 0;
					Func<KeyValuePair<PlayerRef, byte>, int> func2 = default;
					func2._002Ector(obj32, (IntPtr)obj37);
					object obj38 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v70+A0]");
					object obj39 = (nint)0 + (nint)40;
					obj39 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					selector = func2;
					nint num = unchecked((nint)null);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8358]");
				object obj40 = 0;
				IEnumerable<int> source3 = Enumerable.Select(source, selector);
				object obj41 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v26+E4]");
				bool flag13 = (nint)0 == 0;
				object obj42 = !flag13;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj41 = obj18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v26+A0]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X9_v16+30]");
				Func<int, int> keySelector = (Func<int, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X9_v16+30]");
				bool flag14 = (nint)0 == 0;
				object obj44 = !flag14;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v26+E4]");
					bool flag15 = (nint)0 == 0;
					object obj45 = !flag15;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj46 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v63+A0]");
						obj43 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8370]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8390]");
					object obj48 = 0;
					Func<int, int> func3 = default;
					func3._002Ector(obj43, (IntPtr)obj48);
					object obj49 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v62+A0]");
					object obj50 = (nint)0 + (nint)48;
					obj50 = func3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					keySelector = func3;
					nint num = unchecked((nint)null);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8350]");
				object obj51 = 0;
				IOrderedEnumerable<int> source4 = Enumerable.OrderBy(source3, keySelector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E20]");
				object obj52 = 0;
				List<int> list = Enumerable.ToList((IEnumerable<int>)source4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj53 = 0;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v34+E4]");
				bool flag16 = (nint)0 == 0;
				object obj55 = !flag16;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = default;
				int playerId = playerRef.PlayerId;
				if (list != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8378]");
					object obj56 = 0;
					int num2 = list.IndexOf(playerId);
					if ((object)obj3 != null)
					{
						int num3 = ~num2;
						int num4 = num2 & num3;
						Vector3 position = ((Transform)obj3).position;
						Vector3 right = ((Transform)obj3).right;
						object obj57 = num4 * 1717986919;
						object obj58 = obj57 >> 33;
						object obj59 = obj58 + obj58;
						object obj60 = num4 - obj59;
						object obj61 = obj60 - 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
						object obj62 = obj61 * 0;
						object obj64 = default;
						object obj63 = obj62 * obj64;
						object obj66 = default;
						object obj65 = obj62 * obj66;
						object obj68 = default;
						object obj67 = obj62 * obj68;
						object obj69 = obj64 + obj63;
						object obj70 = obj66 + obj65;
						object obj71 = obj68 + obj67;
						Vector3 forward = ((Transform)obj3).forward;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
						object obj72 = obj58 * 0;
						object obj73 = obj72 * obj63;
						object obj74 = obj72 * obj65;
						object obj75 = obj72 * obj67;
						object obj76 = obj69 - obj73;
						object obj77 = obj70 - obj74;
						object obj78 = obj71 - obj75;
						Vector3 forward2 = ((Transform)obj3).forward;
						bool flag17 = GillaTeleport.To((Vector3)0, (Vector3)0);
						object obj79 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v45+A0]");
						((KillCam)(object)0)?.Heal();
						wantBack = false;
						inGame = true;
						int round = game.Round;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj80 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8398]");
						object format = 0;
						object arg = default;
						string message = string.Format((string)format, arg);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj81 = 0;
						object obj82 = obj81;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v56+E4]");
						bool flag18 = (nint)0 == 0;
						object obj83 = !flag18;
						if (obj83 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.Log(message);
						return;
					}
				}
			}
		}
		goto IL_07fd;
		IL_07fd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_080b;
		IL_080b:
		throw new IndexOutOfRangeException();
	}

	private void Back()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I
		//IL_040f: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_031a: Expected VT, but got I4
		//IL_031a: Expected VT, but got I4
		//IL_0233: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		through = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = lobby == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj5 = 0;
		object obj6 = obj;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj8 != null)
		{
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v30+A0]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v32+A9]");
			wantBack = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v32+A9]");
			bool flag5 = (byte)(~(nuint)0u) != 0;
			object obj13 = !flag5;
			if (obj13 != null)
			{
				return;
			}
		}
		else
		{
			wantBack = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj14;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v15+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X9_v3+8]");
		UnityEngine.Object obj21 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X9_v3+8]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v28+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = !flag9;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X20_v8 (UnityEngine.Object)+B0]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X20_v8 (UnityEngine.Object)+B0]");
				PlayerRef localPlayer = ((NetworkRunner)0).LocalPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj25 = 0;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v18+E4]");
				bool flag10 = (nint)0 == 0;
				object obj27 = !flag10;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = default;
				int playerId = playerRef.PlayerId;
			}
		}
		Vector3 position = lobby.position;
		Vector3 right = lobby.right;
		Vector3 forward = lobby.forward;
		bool flag11 = GillaTeleport.To((Vector3)0, (Vector3)0);
	}

	private void Play(AudioClip clip, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_01ed: Expected VT, but got I4
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
		if (clip == null)
		{
			return;
		}
		Camera main = Camera.main;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component;
		if (main != null)
		{
			Camera main2 = Camera.main;
			bool flag3 = (object)main2 == null;
			object obj6 = !flag3;
			component = main2;
			if (obj6 == null)
			{
				goto IL_01ee;
			}
		}
		else
		{
			component = this;
		}
		Transform transform = component.transform;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			AudioClip[] array = default;
			if (array != null)
			{
				object obj8 = array + 32;
				obj8 = clip;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v19+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float pitchMin = default;
				float pitchMax = default;
				Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
				return;
			}
		}
		goto IL_01ee;
		IL_01ee:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private string Winners(GillaSplashGame game)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_035c: Expected I, but got Obj
		//IL_037a: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = game;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83D0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8360]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81B8]");
				object obj8 = 0;
				NetworkDictionary<PlayerRef, byte> players = ((GillaSplashGame)obj3).Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
				func._002Ector(obj2, (IntPtr)obj6);
				IEnumerable<KeyValuePair<PlayerRef, byte>> source2 = default;
				IEnumerable<KeyValuePair<PlayerRef, byte>> source = Enumerable.Where(source2, func);
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v7+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v5+38]");
				Func<KeyValuePair<PlayerRef, byte>, System.__Canon> selector = (Func<KeyValuePair<PlayerRef, byte>, System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v5+38]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v7+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj14 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v23+A0]");
						obj11 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83B8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83C8]");
					object obj16 = 0;
					Func<KeyValuePair<PlayerRef, byte>, System.__Canon> func2 = default;
					func2._002Ector(obj11, (IntPtr)obj16);
					object obj17 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v22+A0]");
					object obj18 = (nint)0 + (nint)56;
					obj18 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					selector = func2;
				}
				IEnumerable<System.__Canon> source3 = Enumerable.Select(source, selector);
				List<System.__Canon> list = Enumerable.ToList(source3);
				if (list != null)
				{
					if (list._size != 0)
					{
						if (list._size == 1)
						{
							return (string)(object)list.get_Item(0);
						}
						int num = default;
						string text = num.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83D8]");
						object obj19 = 0;
						return text + (string)obj19;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83E0]");
					return (string)0;
				}
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private unsafe void Draw(GillaSplashGame game)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0018: Expected Obj, but got Ref
		//IL_6806: Expected I, but got Obj
		//IL_680f: Expected Obj, but got I4
		//IL_6843: Expected Obj, but got I4
		//IL_6859: Expected I, but got Obj
		//IL_688b: Expected Obj, but got I4
		//IL_7c66: Expected Obj, but got I
		//IL_7c76: Expected Obj, but got I
		//IL_7c98: Expected Obj, but got I4
		//IL_0043: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_00cc: Expected F4, but got I4
		//IL_00d5: Expected VT, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_0145: Expected F4, but got I4
		//IL_014e: Expected VT, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_03a7: Expected Obj, but got I4
		//IL_03b5: Expected F4, but got I4
		//IL_03be: Expected VT, but got I4
		//IL_7cd5: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_02b6: Expected F4, but got I4
		//IL_02bf: Expected VT, but got I4
		//IL_02d1: Expected Obj, but got VT
		//IL_02da: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_0549: Expected VT, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I4
		//IL_031a: Expected I4, but got Obj
		//IL_7d12: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I4
		//IL_044f: Expected VT, but got I4
		//IL_0461: Expected Obj, but got VT
		//IL_046a: Expected Obj, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I4
		//IL_0495: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I4
		//IL_04aa: Expected I4, but got Obj
		//IL_68b3: Expected Obj, but got I4
		//IL_68d3: Expected VT, but got Ref
		//IL_68db: Expected Obj, but got VT
		//IL_6956: Expected Obj, but got I4
		//IL_05d1: Expected VT, but got I4
		//IL_05e3: Expected Obj, but got VT
		//IL_05ec: Expected Obj, but got I4
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_0529: Expected Obj, but got I4
		//IL_061d: Expected Obj, but got I4
		//IL_68fa: Expected Obj, but got I4
		//IL_691a: Expected VT, but got Ref
		//IL_6922: Expected Obj, but got VT
		//IL_6993: Expected Obj, but got I4
		//IL_06b3: Expected VT, but got I4
		//IL_06c5: Expected Obj, but got VT
		//IL_06ce: Expected Obj, but got I4
		//IL_06f7: Expected Obj, but got I4
		//IL_69d0: Expected Obj, but got I4
		//IL_0795: Expected VT, but got I4
		//IL_07a7: Expected Obj, but got VT
		//IL_07b0: Expected Obj, but got I4
		//IL_0a66: Expected VT, but got I4
		//IL_0a6f: Expected Obj, but got I4
		//IL_0a7c: Expected Obj, but got VT
		//IL_0a85: Expected Obj, but got I4
		//IL_07e1: Expected Obj, but got I4
		//IL_0862: Expected Obj, but got I4
		//IL_0ab0: Expected Obj, but got I
		//IL_0891: Expected Obj, but got I
		//IL_08a5: Expected Obj, but got I
		//IL_0b13: Expected VT, but got I4
		//IL_0b1b: Expected Obj, but got Ref
		//IL_0b31: Expected Obj, but got I4
		//IL_69ee: Expected Obj, but got I
		//IL_69fe: Expected Obj, but got I
		//IL_6a20: Expected Obj, but got I4
		//IL_091e: Expected VT, but got I4
		//IL_0931: Expected Obj, but got I4
		//IL_0b56: Expected Obj, but got Ref
		//IL_1e1b: Expected Obj, but got I4
		//IL_0bd6: Expected VT, but got I4
		//IL_1e4a: Expected Obj, but got I
		//IL_0961: Expected Obj, but got I4
		//IL_09fb: Expected F4, but got I
		//IL_0b6c: Expected I, but got Obj
		//IL_0b7c: Expected Obj, but got I
		//IL_0b9e: Expected VT, but got I4
		//IL_0bae: Expected Obj, but got I
		//IL_1f08: Expected Obj, but got I
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected Obj, but got Unknown
		//IL_1eb6: Expected VT, but got I4
		//IL_0c37: Expected Obj, but got Ref
		//IL_1f44: Expected Obj, but got I4
		//IL_0cb1: Expected Obj, but got I8
		//IL_0cc9: Expected VT, but got I4
		//IL_1f73: Expected Obj, but got I
		//IL_1ee7: Expected Obj, but got I
		//IL_0c4d: Expected I, but got Obj
		//IL_0c5d: Expected Obj, but got I
		//IL_0c7f: Expected VT, but got I4
		//IL_0c8f: Expected Obj, but got I
		//IL_2041: Expected Obj, but got I
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Unknown
		//IL_1fdf: Expected VT, but got I4
		//IL_0d1d: Expected Obj, but got Ref
		//IL_0d9f: Expected Obj, but got I4
		//IL_0daf: Expected Obj, but got I4
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected Obj, but got Unknown
		//IL_0ddd: Expected VT, but got I4
		//IL_2073: Unknown result type (might be due to invalid IL or missing references)
		//IL_2078: Expected Obj, but got Unknown
		//IL_20c9: Expected Obj, but got I
		//IL_20eb: Expected VT, but got I4
		//IL_200f: Expected Obj, but got I
		//IL_2028: Expected Obj, but got I
		//IL_0d33: Expected I, but got Obj
		//IL_0d43: Expected Obj, but got I
		//IL_0d65: Expected VT, but got I4
		//IL_0d75: Expected Obj, but got I
		//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Expected Obj, but got Unknown
		//IL_211e: Expected Obj, but got I
		//IL_212e: Expected F8, but got I
		//IL_2137: Unknown result type (might be due to invalid IL or missing references)
		//IL_213c: Expected Obj, but got Unknown
		//IL_216c: Expected Obj, but got I
		//IL_219f: Expected VT, but got I4
		//IL_0e43: Expected Obj, but got Ref
		//IL_722c: Expected Obj, but got I4
		//IL_7246: Invalid comparison between F4 and I4
		//IL_7255: Invalid comparison between F4 and I4
		//IL_7272: Unknown result type (might be due to invalid IL or missing references)
		//IL_7277: Expected I4, but got Unknown
		//IL_72e8: Expected Obj, but got I
		//IL_72f5: Expected Obj, but got I8
		//IL_0ebd: Expected Obj, but got I8
		//IL_0ed5: Expected VT, but got I4
		//IL_427a: Expected Obj, but got I4
		//IL_0e59: Expected I, but got Obj
		//IL_0e69: Expected Obj, but got I
		//IL_0e8b: Expected VT, but got I4
		//IL_0e9b: Expected Obj, but got I
		//IL_7386: Expected Obj, but got I
		//IL_7397: Expected Obj, but got I
		//IL_73b9: Expected Obj, but got I4
		//IL_2224: Expected Obj, but got I
		//IL_2231: Expected Obj, but got I8
		//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected Obj, but got Unknown
		//IL_0f3b: Expected Obj, but got Ref
		//IL_22c0: Expected Obj, but got I4
		//IL_22da: Invalid comparison between F4 and I4
		//IL_22e9: Invalid comparison between F4 and I4
		//IL_2306: Unknown result type (might be due to invalid IL or missing references)
		//IL_230b: Expected I4, but got Unknown
		//IL_237c: Expected Obj, but got I
		//IL_2389: Expected Obj, but got I8
		//IL_0fbd: Expected Obj, but got I4
		//IL_0fcd: Expected Obj, but got I4
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected Obj, but got Unknown
		//IL_0ffb: Expected VT, but got I4
		//IL_73f6: Expected Obj, but got I4
		//IL_42f1: Expected VT, but got I4
		//IL_0f51: Expected I, but got Obj
		//IL_0f61: Expected Obj, but got I
		//IL_0f83: Expected VT, but got I4
		//IL_0f93: Expected Obj, but got I
		//IL_2418: Expected Obj, but got I4
		//IL_2432: Invalid comparison between F4 and I4
		//IL_2441: Invalid comparison between F4 and I4
		//IL_245e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2463: Expected I4, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected Obj, but got Unknown
		//IL_4610: Expected VT, but got I4
		//IL_1061: Expected Obj, but got Ref
		//IL_4397: Expected Obj, but got I4
		//IL_24d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24da: Expected Obj, but got Unknown
		//IL_24ea: Expected Obj, but got I
		//IL_10e3: Expected Obj, but got I4
		//IL_10f3: Expected Obj, but got I4
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected Obj, but got Unknown
		//IL_1121: Expected VT, but got I4
		//IL_43d2: Expected Obj, but got I
		//IL_4182: Expected Obj, but got I4
		//IL_41c4: Expected Obj, but got I
		//IL_41d1: Expected Obj, but got I8
		//IL_1077: Expected I, but got Obj
		//IL_1087: Expected Obj, but got I
		//IL_10a9: Expected VT, but got I4
		//IL_10b9: Expected Obj, but got I
		//IL_4a51: Invalid comparison between F4 and I4
		//IL_4a60: Invalid comparison between F4 and I4
		//IL_4a73: Expected Obj, but got F4
		//IL_4a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a80: Expected Obj, but got Unknown
		//IL_4a9f: Expected Obj, but got I
		//IL_4ab8: Expected Obj, but got I4
		//IL_4ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ac5: Expected Obj, but got Unknown
		//IL_4ace: Expected I4, but got Obj
		//IL_741c: Expected Obj, but got I
		//IL_743e: Expected Obj, but got I4
		//IL_2539: Expected Obj, but got I4
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected Obj, but got Unknown
		//IL_75df: Invalid comparison between F4 and I4
		//IL_4690: Expected Obj, but got I4
		//IL_46a9: Invalid comparison between F4 and I4
		//IL_46b8: Invalid comparison between F4 and I4
		//IL_46d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_46d9: Expected I4, but got Unknown
		//IL_8063: Expected Obj, but got I
		//IL_8086: Expected Obj, but got I4
		//IL_440f: Expected VT, but got I4
		//IL_6b34: Expected Obj, but got I
		//IL_6b55: Expected VT, but got I
		//IL_6b55: Expected VT, but got I
		//IL_6b84: Expected Obj, but got I4
		//IL_4aec: Expected Obj, but got I
		//IL_4b85: Expected Obj, but got I4
		//IL_4b9e: Invalid comparison between F4 and I4
		//IL_4bad: Invalid comparison between F4 and I4
		//IL_4bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bce: Expected I4, but got Unknown
		//IL_6a3e: Expected Obj, but got I
		//IL_6a68: Expected Obj, but got I4
		//IL_4b01: Expected Obj, but got I
		//IL_4b2b: Expected Obj, but got I4
		//IL_4f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f39: Expected I4, but got Unknown
		//IL_4732: Expected Obj, but got I
		//IL_4941: Expected Obj, but got I
		//IL_4444: Expected Obj, but got I4
		//IL_11ad: Expected Obj, but got Ref
		//IL_76a3: Expected Obj, but got I
		//IL_76cd: Expected Obj, but got I4
		//IL_7603: Expected Obj, but got I
		//IL_760b: Expected F4, but got Obj
		//IL_6674: Expected Obj, but got I
		//IL_4c27: Expected Obj, but got I
		//IL_475b: Expected Obj, but got I
		//IL_747b: Expected Obj, but got I
		//IL_748c: Expected VT, but got I4
		//IL_45b5: Expected Obj, but got I
		//IL_45c6: Expected VT, but got I4
		//IL_4520: Expected F4, but got I
		//IL_4530: Expected Obj, but got I
		//IL_6bb8: Expected Obj, but got I4
		//IL_6bd0: Invalid comparison between F4 and I4
		//IL_6bdf: Invalid comparison between F4 and I4
		//IL_6bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bf2: Expected I4, but got Unknown
		//IL_6bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bff: Expected I4, but got Unknown
		//IL_25e9: Expected Obj, but got I
		//IL_25f6: Expected Obj, but got I8
		//IL_2636: Expected VT, but got I4
		//IL_1237: Expected Obj, but got I4
		//IL_1252: Invalid comparison between F4 and I4
		//IL_1261: Invalid comparison between F4 and I4
		//IL_1281: Unknown result type (might be due to invalid IL or missing references)
		//IL_1286: Expected I4, but got Unknown
		//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b8: Expected I4, but got Unknown
		//IL_12c9: Expected VT, but got I4
		//IL_4cef: Expected Obj, but got F4
		//IL_4cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cfc: Expected I4, but got Unknown
		//IL_7654: Expected Obj, but got I4
		//IL_66ad: Expected Obj, but got I
		//IL_4f83: Expected Obj, but got I
		//IL_4c50: Expected Obj, but got I
		//IL_44fb: Expected F4, but got I
		//IL_11c3: Expected I, but got Obj
		//IL_11d3: Expected Obj, but got I
		//IL_11fd: Expected VT, but got I4
		//IL_120d: Expected Obj, but got I
		//IL_4d36: Invalid comparison between F4 and I4
		//IL_4d47: Expected Obj, but got I4
		//IL_4d50: Invalid comparison between F4 and I4
		//IL_4d5f: Invalid comparison between F4 and I4
		//IL_4d72: Expected I4, but got F4
		//IL_4d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d7f: Expected I4, but got Unknown
		//IL_4d99: Expected Obj, but got I4
		//IL_4da2: Invalid comparison between F4 and I4
		//IL_7b67: Expected Obj, but got I4
		//IL_7ba6: Expected Obj, but got I4
		//IL_4fa2: Expected Obj, but got I
		//IL_4963: Expected Obj, but got I
		//IL_4982: Expected Obj, but got I4
		//IL_49fb: Expected Obj, but got I4
		//IL_4a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a08: Expected I4, but got Unknown
		//IL_6c61: Expected Obj, but got I4
		//IL_12e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e5: Expected Obj, but got Unknown
		//IL_1307: Expected Obj, but got I
		//IL_4e1f: Expected Obj, but got I4
		//IL_7bc4: Expected Obj, but got I
		//IL_7bd4: Expected Obj, but got I
		//IL_74aa: Expected Obj, but got I
		//IL_74d4: Expected Obj, but got I4
		//IL_26e9: Expected Obj, but got I4
		//IL_26f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f6: Expected Obj, but got Unknown
		//IL_26ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2704: Expected Obj, but got Unknown
		//IL_770c: Expected Obj, but got I
		//IL_4dd8: Expected Obj, but got I4
		//IL_66df: Expected I4, but got Obj
		//IL_6704: Expected Obj, but got I
		//IL_6714: Expected Obj, but got I
		//IL_6734: Expected Obj, but got I
		//IL_674e: Expected Obj, but got I4
		//IL_6757: Expected VT, but got I4
		//IL_500e: Expected I4, but got Obj
		//IL_5030: Expected Obj, but got I4
		//IL_51c6: Expected Obj, but got I
		//IL_4ca4: Expected Obj, but got I
		//IL_47c3: Expected Obj, but got F4
		//IL_47cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d0: Expected I4, but got Unknown
		//IL_47f2: Expected Obj, but got I4
		//IL_759e: Expected Obj, but got I
		//IL_75c0: Expected F4, but got I4
		//IL_75c9: Expected VT, but got I4
		//IL_277c: Expected Obj, but got I
		//IL_2789: Expected Obj, but got I8
		//IL_27b9: Expected VT, but got I4
		//IL_80a4: Expected Obj, but got I
		//IL_80d4: Expected I4, but got F4
		//IL_80e5: Expected VT, but got I4
		//IL_80f2: Expected Obj, but got I4
		//IL_76f1: Expected Obj, but got I
		//IL_7c3b: Expected Obj, but got I4
		//IL_5072: Expected Obj, but got I
		//IL_508c: Expected Obj, but got I4
		//IL_5223: Expected Obj, but got I4
		//IL_4834: Expected Obj, but got I
		//IL_6aa1: Expected Obj, but got I4
		//IL_6774: Expected Obj, but got I
		//IL_6794: Expected Obj, but got I
		//IL_67ac: Expected F4, but got I4
		//IL_67bd: Expected VT, but got I4
		//IL_67cd: Expected Obj, but got I4
		//IL_51fc: Expected Obj, but got I4
		//IL_520c: Expected Obj, but got I
		//IL_4856: Expected Obj, but got I
		//IL_4880: Expected Obj, but got I4
		//IL_280a: Expected Obj, but got I4
		//IL_2822: Invalid comparison between F4 and I4
		//IL_2831: Invalid comparison between F4 and I4
		//IL_284c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2851: Expected I4, but got Unknown
		//IL_2875: Expected Obj, but got I4
		//IL_6c7f: Expected Obj, but got I
		//IL_6ca9: Expected Obj, but got I4
		//IL_13ea: Expected VT, but got I4
		//IL_13f2: Expected Obj, but got Ref
		//IL_53ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_53f1: Expected Obj, but got Unknown
		//IL_53fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_53ff: Expected Obj, but got Unknown
		//IL_5419: Expected Obj, but got I4
		//IL_510d: Expected Obj, but got I
		//IL_7722: Expected Obj, but got I
		//IL_774c: Expected Obj, but got I4
		//IL_5591: Expected Obj, but got I4
		//IL_55aa: Invalid comparison between F4 and I4
		//IL_55c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_55cd: Expected I4, but got Unknown
		//IL_55d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_55da: Expected I4, but got Unknown
		//IL_53c0: Expected Obj, but got I
		//IL_513b: Expected Obj, but got I
		//IL_5153: Expected F4, but got I4
		//IL_5164: Expected VT, but got I4
		//IL_5174: Expected Obj, but got I4
		//IL_5257: Expected Obj, but got F4
		//IL_525f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5264: Expected I4, but got Unknown
		//IL_5286: Expected Obj, but got I4
		//IL_750c: Expected Obj, but got I4
		//IL_2923: Unknown result type (might be due to invalid IL or missing references)
		//IL_2928: Expected Obj, but got Unknown
		//IL_142c: Expected Obj, but got Ref
		//IL_57b8: Expected Obj, but got I
		//IL_5450: Expected Obj, but got I4
		//IL_5469: Invalid comparison between F4 and I4
		//IL_5487: Unknown result type (might be due to invalid IL or missing references)
		//IL_548c: Expected I4, but got Unknown
		//IL_5494: Unknown result type (might be due to invalid IL or missing references)
		//IL_5499: Expected I4, but got Unknown
		//IL_52c8: Expected Obj, but got I
		//IL_48d1: Expected I4, but got F4
		//IL_29c5: Expected Obj, but got I4
		//IL_28de: Expected Obj, but got I4
		//IL_14ac: Expected VT, but got I4
		//IL_561e: Expected Obj, but got I4
		//IL_5637: Invalid comparison between F4 and I4
		//IL_5646: Invalid comparison between F4 and I4
		//IL_5655: Unknown result type (might be due to invalid IL or missing references)
		//IL_565a: Expected I4, but got Unknown
		//IL_5662: Unknown result type (might be due to invalid IL or missing references)
		//IL_5667: Expected I4, but got Unknown
		//IL_56d8: Expected VT, but got I4
		//IL_776a: Expected Obj, but got I
		//IL_77c7: Expected Obj, but got I4
		//IL_52f1: Expected Obj, but got I
		//IL_531e: Expected Obj, but got I
		//IL_5347: Expected VT, but got Obj
		//IL_48f7: Expected Obj, but got I
		//IL_6dbb: Expected Obj, but got I
		//IL_6dd2: Expected VT, but got I8
		//IL_6dd2: Expected VT, but got I4
		//IL_6dfc: Expected Obj, but got I4
		//IL_2967: Expected Obj, but got I4
		//IL_6cc7: Expected Obj, but got I
		//IL_6cde: Expected VT, but got I8
		//IL_6cde: Expected VT, but got I4
		//IL_6d08: Expected Obj, but got I4
		//IL_1442: Expected I, but got Obj
		//IL_1452: Expected Obj, but got I
		//IL_1474: Expected VT, but got I4
		//IL_1484: Expected Obj, but got I
		//IL_54dd: Expected Obj, but got I4
		//IL_54f6: Invalid comparison between F4 and I4
		//IL_5505: Invalid comparison between F4 and I4
		//IL_5514: Unknown result type (might be due to invalid IL or missing references)
		//IL_5519: Expected I4, but got Unknown
		//IL_5521: Unknown result type (might be due to invalid IL or missing references)
		//IL_5526: Expected I4, but got Unknown
		//IL_6e20: Expected Obj, but got I
		//IL_6d41: Expected Obj, but got I
		//IL_6d58: Expected VT, but got I8
		//IL_6d58: Expected VT, but got I4
		//IL_6d82: Expected Obj, but got I4
		//IL_6d2c: Expected Obj, but got I
		//IL_14c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c8: Expected Obj, but got Unknown
		//IL_56b3: Expected Obj, but got I
		//IL_5720: Expected Obj, but got I4
		//IL_5739: Invalid comparison between F4 and I4
		//IL_5764: Unknown result type (might be due to invalid IL or missing references)
		//IL_5769: Expected I4, but got Unknown
		//IL_4e91: Expected Obj, but got I
		//IL_492c: Expected Obj, but got I
		//IL_7d28: Expected I4, but got Obj
		//IL_7d43: Expected VT, but got I8
		//IL_7d43: Expected VT, but got I8
		//IL_7da3: Expected Obj, but got I
		//IL_7db0: Expected Obj, but got I8
		//IL_7ddb: Expected VT, but got I8
		//IL_7de8: Expected Obj, but got I8
		//IL_7df8: Expected Obj, but got I4
		//IL_6da6: Expected Obj, but got I
		//IL_150d: Expected Obj, but got Ref
		//IL_5572: Expected Obj, but got I
		//IL_7813: Expected I4, but got Obj
		//IL_781b: Expected I4, but got Obj
		//IL_7833: Expected I4, but got Obj
		//IL_783c: Expected VT, but got I4
		//IL_5816: Expected I4, but got Obj
		//IL_581e: Expected I4, but got Obj
		//IL_5836: Expected I4, but got Obj
		//IL_583f: Expected VT, but got I4
		//IL_4eee: Expected Obj, but got I4
		//IL_7547: Expected Obj, but got I
		//IL_7571: Expected VT, but got Obj
		//IL_1587: Expected Obj, but got I8
		//IL_159f: Expected VT, but got I4
		//IL_57a3: Expected Obj, but got I
		//IL_4ec7: Expected Obj, but got I4
		//IL_4ed7: Expected Obj, but got I
		//IL_2a1c: Expected Obj, but got I4
		//IL_2a36: Invalid comparison between F4 and I4
		//IL_2a45: Invalid comparison between F4 and I4
		//IL_2a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a67: Expected I4, but got Unknown
		//IL_2ab5: Expected VT, but got I8
		//IL_2ac2: Expected Obj, but got I8
		//IL_1523: Expected I, but got Obj
		//IL_1533: Expected Obj, but got I
		//IL_1555: Expected VT, but got I4
		//IL_1565: Expected Obj, but got I
		//IL_5880: Expected Obj, but got I4
		//IL_5888: Expected I4, but got Obj
		//IL_5890: Expected I4, but got Obj
		//IL_58a9: Expected Obj, but got I4
		//IL_58c1: Expected I4, but got Obj
		//IL_58ca: Expected VT, but got I4
		//IL_15b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bb: Expected Obj, but got Unknown
		//IL_2add: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae2: Expected Obj, but got Unknown
		//IL_2af2: Expected Obj, but got I
		//IL_2b48: Expected Obj, but got I
		//IL_2b55: Expected Obj, but got I8
		//IL_2b80: Expected VT, but got I8
		//IL_2b8d: Expected Obj, but got I8
		//IL_2b9d: Expected Obj, but got I4
		//IL_1600: Expected Obj, but got Ref
		//IL_1682: Expected Obj, but got I4
		//IL_1692: Expected Obj, but got I4
		//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b7: Expected Obj, but got Unknown
		//IL_16c0: Expected VT, but got I4
		//IL_58ef: Expected Obj, but got I4
		//IL_5909: Invalid comparison between F4 and I4
		//IL_5918: Invalid comparison between F4 and I4
		//IL_5928: Unknown result type (might be due to invalid IL or missing references)
		//IL_592d: Expected I4, but got Unknown
		//IL_5935: Unknown result type (might be due to invalid IL or missing references)
		//IL_593a: Expected I4, but got Unknown
		//IL_2bc1: Expected Obj, but got I4
		//IL_2bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bce: Expected Obj, but got Unknown
		//IL_2bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf1: Expected Obj, but got Unknown
		//IL_1616: Expected I, but got Obj
		//IL_1626: Expected Obj, but got I
		//IL_1648: Expected VT, but got I4
		//IL_1658: Expected Obj, but got I
		//IL_2c77: Expected Obj, but got I4
		//IL_16d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dc: Expected Obj, but got Unknown
		//IL_6e56: Expected Obj, but got I
		//IL_2c30: Expected Obj, but got I4
		//IL_1714: Expected Obj, but got Ref
		//IL_63ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_63b0: Expected Obj, but got Unknown
		//IL_63cf: Expected Obj, but got I4
		//IL_7e49: Expected Obj, but got I
		//IL_7e99: Expected Obj, but got I
		//IL_7ea9: Expected Obj, but got I
		//IL_7eb6: Expected Obj, but got I8
		//IL_7ee6: Expected VT, but got I4
		//IL_7f00: Expected Obj, but got I
		//IL_6e3b: Expected Obj, but got I
		//IL_178e: Expected Obj, but got I8
		//IL_17a6: Expected VT, but got I4
		//IL_59c5: Expected Obj, but got I4
		//IL_172a: Expected I, but got Obj
		//IL_173a: Expected Obj, but got I
		//IL_175c: Expected VT, but got I4
		//IL_176c: Expected Obj, but got I
		//IL_640a: Expected Obj, but got I
		//IL_2cb7: Expected Obj, but got I4
		//IL_2cd1: Invalid comparison between F4 and I4
		//IL_2ce0: Invalid comparison between F4 and I4
		//IL_2cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d02: Expected I4, but got Unknown
		//IL_17bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c2: Expected Obj, but got Unknown
		//IL_5d13: Expected Obj, but got I4
		//IL_17fa: Expected Obj, but got Ref
		//IL_5a26: Expected Obj, but got I4
		//IL_5a3e: Invalid comparison between F4 and I4
		//IL_5a4d: Invalid comparison between F4 and I4
		//IL_5a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a60: Expected I4, but got Unknown
		//IL_5a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a6d: Expected I4, but got Unknown
		//IL_6eab: Expected Obj, but got I
		//IL_6ebb: Expected Obj, but got I
		//IL_6ec8: Expected Obj, but got I8
		//IL_6ef8: Expected VT, but got I4
		//IL_2d5a: Expected Obj, but got I4
		//IL_2d74: Invalid comparison between F4 and I4
		//IL_2d83: Invalid comparison between F4 and I4
		//IL_2da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da5: Expected I4, but got Unknown
		//IL_2de3: Expected Obj, but got I
		//IL_2dfd: Expected VT, but got I4
		//IL_187c: Expected Obj, but got I4
		//IL_188c: Expected Obj, but got I4
		//IL_18ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b1: Expected Obj, but got Unknown
		//IL_18ba: Expected VT, but got I4
		//IL_60aa: Expected Obj, but got I4
		//IL_1810: Expected I, but got Obj
		//IL_1820: Expected Obj, but got I
		//IL_1842: Expected VT, but got I4
		//IL_1852: Expected Obj, but got I
		//IL_5d74: Expected Obj, but got I4
		//IL_5d8c: Invalid comparison between F4 and I4
		//IL_5d9b: Invalid comparison between F4 and I4
		//IL_5da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dae: Expected I4, but got Unknown
		//IL_5db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dbb: Expected I4, but got Unknown
		//IL_5add: Expected VT, but got I4
		//IL_5af2: Expected Obj, but got I
		//IL_2e5e: Expected Obj, but got I4
		//IL_2e78: Invalid comparison between F4 and I4
		//IL_2e87: Invalid comparison between F4 and I4
		//IL_2ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea9: Expected I4, but got Unknown
		//IL_2ee7: Expected Obj, but got I
		//IL_2f01: Expected VT, but got I4
		//IL_2e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e24: Expected Obj, but got Unknown
		//IL_2e34: Expected Obj, but got I
		//IL_18d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d6: Expected Obj, but got Unknown
		//IL_634c: Expected Obj, but got I
		//IL_190e: Expected Obj, but got Ref
		//IL_7a07: Expected Obj, but got I4
		//IL_7a1f: Invalid comparison between F4 and I4
		//IL_7a2e: Invalid comparison between F4 and I4
		//IL_7a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a41: Expected I4, but got Unknown
		//IL_7a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a4e: Expected I4, but got Unknown
		//IL_610b: Expected Obj, but got I4
		//IL_6123: Invalid comparison between F4 and I4
		//IL_6132: Invalid comparison between F4 and I4
		//IL_6145: Expected I4, but got Obj
		//IL_614d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6152: Expected I4, but got Unknown
		//IL_5e2b: Expected VT, but got I4
		//IL_5e40: Expected Obj, but got I
		//IL_2f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f28: Expected Obj, but got Unknown
		//IL_2f38: Expected Obj, but got I
		//IL_2f84: Expected Obj, but got I
		//IL_2f94: Expected Obj, but got I
		//IL_2fa1: Expected Obj, but got I8
		//IL_2fd1: Expected VT, but got I4
		//IL_1990: Expected Obj, but got I4
		//IL_19a0: Expected Obj, but got I4
		//IL_19c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c5: Expected Obj, but got Unknown
		//IL_19ce: Expected VT, but got I4
		//IL_7ac1: Expected Obj, but got I
		//IL_637b: Expected Obj, but got I
		//IL_1924: Expected I, but got Obj
		//IL_1934: Expected Obj, but got I
		//IL_1956: Expected VT, but got I4
		//IL_1966: Expected Obj, but got I
		//IL_7901: Expected I4, but got Obj
		//IL_7909: Expected I4, but got Obj
		//IL_7921: Expected I4, but got Obj
		//IL_7929: Expected VT, but got Obj
		//IL_6390: Expected Obj, but got I
		//IL_61c2: Expected VT, but got I4
		//IL_61d7: Expected Obj, but got I
		//IL_3004: Unknown result type (might be due to invalid IL or missing references)
		//IL_3009: Expected Obj, but got Unknown
		//IL_3037: Expected Obj, but got I
		//IL_19e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ea: Expected Obj, but got Unknown
		//IL_1a22: Expected Obj, but got Ref
		//IL_785f: Expected Obj, but got I
		//IL_7889: Expected Obj, but got I4
		//IL_6f32: Expected Obj, but got I
		//IL_6f5c: Expected Obj, but got I4
		//IL_1aa4: Expected Obj, but got I4
		//IL_1ab4: Expected Obj, but got I4
		//IL_1ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad9: Expected Obj, but got Unknown
		//IL_1ae2: Expected VT, but got I4
		//IL_5ec5: Expected Obj, but got I
		//IL_5eef: Expected Obj, but got I4
		//IL_5b90: Expected Obj, but got F4
		//IL_5b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b9d: Expected I4, but got Unknown
		//IL_5bba: Expected Obj, but got I
		//IL_30b8: Expected Obj, but got I4
		//IL_30da: Expected Obj, but got I
		//IL_30ec: Expected Obj, but got I4
		//IL_3106: Expected VT, but got I4
		//IL_1a38: Expected I, but got Obj
		//IL_1a48: Expected Obj, but got I
		//IL_1a6a: Expected VT, but got I4
		//IL_1a7a: Expected Obj, but got I
		//IL_6231: Unknown result type (might be due to invalid IL or missing references)
		//IL_6236: Expected Obj, but got Unknown
		//IL_6246: Expected Obj, but got I
		//IL_6260: Expected Obj, but got I4
		//IL_6279: Invalid comparison between F4 and I4
		//IL_6288: Invalid comparison between F4 and I4
		//IL_6297: Unknown result type (might be due to invalid IL or missing references)
		//IL_629c: Expected I4, but got Unknown
		//IL_62a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_62a9: Expected I4, but got Unknown
		//IL_5f55: Expected Obj, but got I4
		//IL_5f6d: Invalid comparison between F4 and I4
		//IL_5f7c: Invalid comparison between F4 and I4
		//IL_5f8f: Expected I4, but got F4
		//IL_5f9c: Expected I4, but got F4
		//IL_5fd1: Expected Obj, but got I4
		//IL_5bd9: Expected Obj, but got I
		//IL_5c0c: Expected Obj, but got I4
		//IL_5c25: Invalid comparison between F4 and I4
		//IL_5c34: Invalid comparison between F4 and I4
		//IL_5c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c55: Expected I4, but got Unknown
		//IL_5c81: Expected Obj, but got I
		//IL_1af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afe: Expected Obj, but got Unknown
		//IL_641f: Expected Obj, but got I
		//IL_6441: Expected Obj, but got I4
		//IL_5cc8: Expected Obj, but got I
		//IL_316c: Expected Obj, but got I
		//IL_317c: Expected Obj, but got I
		//IL_3189: Expected Obj, but got I8
		//IL_31b1: Expected Obj, but got I4
		//IL_31cb: Expected VT, but got I4
		//IL_1b37: Expected Obj, but got Ref
		//IL_7b05: Expected Obj, but got I
		//IL_62f5: Expected Obj, but got I
		//IL_6317: Expected Obj, but got I4
		//IL_5ffc: Expected Obj, but got I
		//IL_78c2: Expected Obj, but got I4
		//IL_3bf7: Expected Obj, but got I
		//IL_3c04: Expected Obj, but got I8
		//IL_1bb1: Expected Obj, but got I8
		//IL_1bc9: Expected VT, but got I4
		//IL_79e1: Expected Obj, but got I
		//IL_601b: Expected Obj, but got I
		//IL_6056: Expected Obj, but got I4
		//IL_8107: Expected Obj, but got I
		//IL_812c: Expected Obj, but got I
		//IL_813c: Expected Obj, but got I
		//IL_8154: Expected Obj, but got I
		//IL_818c: Expected Obj, but got I
		//IL_3d61: Expected Obj, but got I
		//IL_3d6e: Expected Obj, but got I8
		//IL_3211: Expected Obj, but got I4
		//IL_322b: Invalid comparison between F4 and I4
		//IL_323a: Invalid comparison between F4 and I4
		//IL_3257: Unknown result type (might be due to invalid IL or missing references)
		//IL_325c: Expected I4, but got Unknown
		//IL_32ad: Expected Obj, but got I
		//IL_32c7: Expected VT, but got I4
		//IL_1b4d: Expected I, but got Obj
		//IL_1b5d: Expected Obj, but got I
		//IL_1b7f: Expected VT, but got I4
		//IL_1b8f: Expected Obj, but got I
		//IL_7b22: Expected Obj, but got I
		//IL_7b4c: Expected Obj, but got I4
		//IL_7946: Expected Obj, but got I
		//IL_7956: Expected Obj, but got I
		//IL_7966: Expected Obj, but got I
		//IL_797e: Expected Obj, but got I
		//IL_7996: Expected Obj, but got I
		//IL_79b6: Expected Obj, but got I
		//IL_1be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be5: Expected Obj, but got Unknown
		//IL_649f: Expected Obj, but got I4
		//IL_3dee: Expected Obj, but got I4
		//IL_3e07: Invalid comparison between F4 and I4
		//IL_3e16: Invalid comparison between F4 and I4
		//IL_3e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e37: Expected I4, but got Unknown
		//IL_3e63: Expected Obj, but got I
		//IL_3c70: Expected Obj, but got I
		//IL_32f8: Expected Obj, but got I4
		//IL_3312: Invalid comparison between F4 and I4
		//IL_3321: Invalid comparison between F4 and I4
		//IL_333e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3343: Expected I4, but got Unknown
		//IL_3381: Expected Obj, but got I
		//IL_339b: Expected VT, but got I4
		//IL_1c1e: Expected Obj, but got Ref
		//IL_64de: Expected Obj, but got F4
		//IL_64e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_64eb: Expected I4, but got Unknown
		//IL_6510: Expected Obj, but got I
		//IL_6520: Expected Obj, but got I
		//IL_3e98: Expected Obj, but got I
		//IL_3ca5: Expected Obj, but got I
		//IL_1ca0: Expected Obj, but got I4
		//IL_1cbb: Invalid comparison between F4 and I4
		//IL_1cca: Invalid comparison between F4 and I4
		//IL_1cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cef: Expected I4, but got Unknown
		//IL_1d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d21: Expected I4, but got Unknown
		//IL_1d2a: Expected VT, but got I4
		//IL_6549: Expected Obj, but got I
		//IL_6ff4: Expected Obj, but got I4
		//IL_33bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c0: Expected Obj, but got Unknown
		//IL_33d0: Expected Obj, but got I
		//IL_3409: Expected Obj, but got I
		//IL_3423: Expected VT, but got I4
		//IL_1c34: Expected I, but got Obj
		//IL_1c44: Expected Obj, but got I
		//IL_1c66: Expected VT, but got I4
		//IL_1c76: Expected Obj, but got I
		//IL_6573: Expected Obj, but got I
		//IL_65ac: Expected Obj, but got I
		//IL_65ac: Expected Obj, but got I
		//IL_65c4: Expected I4, but got Obj
		//IL_6604: Expected I4, but got Obj
		//IL_6614: Expected VT, but got Obj
		//IL_6624: Expected Obj, but got I
		//IL_7f28: Expected Obj, but got I
		//IL_7f38: Expected Obj, but got I
		//IL_1d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d46: Expected Obj, but got Unknown
		//IL_1d68: Expected Obj, but got I
		//IL_7054: Expected VT, but got I4
		//IL_3489: Expected Obj, but got I
		//IL_3499: Expected Obj, but got I
		//IL_34a6: Expected Obj, but got I8
		//IL_34d6: Expected VT, but got I4
		//IL_34f3: Expected Obj, but got I
		//IL_3f34: Expected Obj, but got I4
		//IL_708a: Expected Obj, but got I
		//IL_3eed: Expected Obj, but got I4
		//IL_3524: Expected Obj, but got I4
		//IL_353e: Invalid comparison between F4 and I4
		//IL_354d: Invalid comparison between F4 and I4
		//IL_356a: Unknown result type (might be due to invalid IL or missing references)
		//IL_356f: Expected I4, but got Unknown
		//IL_35ad: Expected Obj, but got I
		//IL_35c7: Expected VT, but got I4
		//IL_7fd7: Expected VT, but got I4
		//IL_7fe1: Expected VT, but got Obj
		//IL_706f: Expected Obj, but got I
		//IL_3fb1: Expected Obj, but got I
		//IL_3fcb: Expected Obj, but got I4
		//IL_35e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ec: Expected Obj, but got Unknown
		//IL_35fc: Expected Obj, but got I
		//IL_3648: Expected Obj, but got I
		//IL_3658: Expected Obj, but got I
		//IL_3665: Expected Obj, but got I8
		//IL_3695: Expected VT, but got I4
		//IL_36b2: Expected Obj, but got I
		//IL_4055: Expected Obj, but got I
		//IL_3f7d: Expected Obj, but got I4
		//IL_7188: Expected Obj, but got I4
		//IL_36d8: Expected Obj, but got I
		//IL_3724: Expected Obj, but got I
		//IL_3734: Expected Obj, but got I
		//IL_3741: Expected Obj, but got I8
		//IL_3771: Expected VT, but got I4
		//IL_378e: Expected Obj, but got I
		//IL_40c3: Expected Obj, but got I4
		//IL_709f: Expected Obj, but got I
		//IL_70bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_70c1: Expected Obj, but got Unknown
		//IL_70ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_70d3: Expected VT, but got Unknown
		//IL_70e9: Expected VT, but got I8
		//IL_7101: Unknown result type (might be due to invalid IL or missing references)
		//IL_7106: Expected Obj, but got Unknown
		//IL_7126: Expected VT, but got I8
		//IL_7148: Expected I4, but got I8
		//IL_7150: Expected Obj, but got VT
		//IL_720c: Expected Obj, but got I
		//IL_407c: Expected Obj, but got I4
		//IL_37bc: Expected Obj, but got I
		//IL_3816: Expected Obj, but got I
		//IL_3826: Expected Obj, but got I
		//IL_3833: Expected Obj, but got I8
		//IL_3863: Expected VT, but got I4
		//IL_3878: Expected Obj, but got I
		//IL_800f: Expected Obj, but got I4
		//IL_801f: Expected F4, but got I4
		//IL_71e1: Expected Obj, but got I
		//IL_38a9: Expected Obj, but got I4
		//IL_38c3: Invalid comparison between F4 and I4
		//IL_38d2: Invalid comparison between F4 and I4
		//IL_38ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_38f4: Expected I4, but got Unknown
		//IL_3932: Expected Obj, but got I
		//IL_394c: Expected VT, but got I4
		//IL_3964: Unknown result type (might be due to invalid IL or missing references)
		//IL_3969: Expected Obj, but got Unknown
		//IL_3979: Expected Obj, but got I
		//IL_39c5: Expected Obj, but got I
		//IL_39d5: Expected Obj, but got I
		//IL_39e2: Expected Obj, but got I8
		//IL_3a12: Expected VT, but got I4
		//IL_3a27: Expected Obj, but got I
		//IL_3a4d: Expected Obj, but got I
		//IL_3a99: Expected Obj, but got I
		//IL_3aa9: Expected Obj, but got I
		//IL_3ab6: Expected Obj, but got I8
		//IL_3ae6: Expected VT, but got I4
		//IL_3afb: Expected Obj, but got I
		//IL_3b53: Expected I4, but got Obj
		//IL_3b53: Expected Obj, but got I
		//IL_3b6e: Expected Obj, but got I4
		//IL_3b77: Expected Obj, but got I4
		//IL_3b8f: Expected VT, but got Obj
		//IL_3b9f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		string text = (string)0;
		object obj2 = default;
		object obj = (object)(&obj2);
		nint num = (nint)text;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2 (Il2CppClass<System.String>)+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num2 = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		bool flag2 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v5 (Il2CppClass<System.String>)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		nint num3 = num2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)text;
		}
		bool value = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v6 (Il2CppClass<System.String>)+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
		UnityEngine.Object obj6 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7 (System.Boolean)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8;
		GillaMapVote.Canvas canvas;
		PlayerRef playerRef;
		UnityEngine.Object obj10;
		int num4 = default;
		bool flag6 = default;
		UnityEngine.Object obj9;
		float num7;
		Color32 color;
		int num5;
		int num6;
		GillaSplashLobby gillaSplashLobby;
		string text2;
		if ((UnityEngine.Object)game != (UnityEngine.Object)null)
		{
			bool flag5 = (object)game == null;
			num4 = 0;
			flag6 = false;
			num5 = 0;
			num6 = 0;
			obj8 = 0;
			canvas = null;
			num7 = 0f;
			color = (Color32)0;
			obj9 = null;
			gillaSplashLobby = this;
			text2 = (string)109891584;
			if (!flag5)
			{
				bool flag7 = (object)((SimulationBehaviour)game)._runner == null;
				num4 = 0;
				flag6 = false;
				num5 = 0;
				num6 = 0;
				obj8 = 0;
				canvas = null;
				num7 = 0f;
				color = (Color32)0;
				obj9 = null;
				gillaSplashLobby = this;
				text2 = (string)109891584;
				if (!flag7)
				{
					playerRef = ((SimulationBehaviour)game)._runner.LocalPlayer;
					obj10 = null;
					goto IL_01f5;
				}
			}
			goto IL_4245;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v701+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		playerRef = PlayerRef.None;
		obj10 = null;
		goto IL_01f5;
		IL_01f5:
		bool value2 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X0_v328 (System.Boolean)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num8 = default;
		GillaMapVote.Canvas canvas2;
		object obj20 = default;
		float num11 = default;
		float num12 = default;
		bool flag14 = default;
		int num9;
		if ((UnityEngine.Object)game != (UnityEngine.Object)null)
		{
			bool flag10 = (object)game == null;
			num4 = 0;
			flag6 = false;
			num5 = 0;
			num6 = 0;
			obj8 = 0;
			canvas = null;
			num7 = 0f;
			color = (Color32)0;
			obj9 = null;
			gillaSplashLobby = this;
			text = (string)playerRef;
			text2 = (string)109891584;
			if (flag10)
			{
				goto IL_4245;
			}
			NetworkDictionary<PlayerRef, byte> votes = game.Votes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj15 = 0;
			obj = num8;
			num9 = (int)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj17 = default;
			object obj16 = obj17 & 1;
			bool flag11 = (nint)obj16 < 0;
			bool flag12 = obj16 == null;
			bool flag13 = !flag12;
			flag14 = !flag13;
			canvas2 = (flag14 ? ((GillaMapVote.Canvas)(-1)) : canvas);
			bool flag15 = false;
			object obj18 = 0;
			object obj19 = obj20;
			float num10 = num11;
			num7 = num12;
			Color32 color2 = (Color32)(&canvas);
			UnityEngine.Object obj21 = (UnityEngine.Object)playerRef;
		}
		else
		{
			canvas2 = (GillaMapVote.Canvas)255;
			canvas = null;
			num7 = 0f;
			Color32 color2 = (Color32)0;
			UnityEngine.Object obj21 = null;
		}
		bool value3 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v333 (System.Boolean)+E4]");
		bool flag16 = (nint)0 == 0;
		object obj22 = !flag16;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj27;
		GillaMapVote.Canvas canvas3;
		if ((UnityEngine.Object)game != (UnityEngine.Object)null)
		{
			bool flag17 = (object)game == null;
			num4 = 0;
			flag6 = false;
			num5 = 0;
			num6 = 0;
			obj8 = 0;
			canvas3 = canvas2;
			color = (Color32)0;
			obj9 = null;
			gillaSplashLobby = this;
			text = (string)playerRef;
			text2 = (string)109891584;
			if (flag17)
			{
				goto IL_4245;
			}
			NetworkDictionary<PlayerRef, byte> players = game.Players;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj23 = 0;
			obj = num8;
			num9 = (int)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj25 = default;
			object obj24 = obj25 & 1;
			bool flag11 = (nint)obj24 < 0;
			bool flag12 = obj24 == null;
			bool flag13 = !flag12;
			flag14 = !flag13;
			object obj26 = (flag14 ? ((object)0) : obj8);
			obj27 = obj26;
			bool flag15 = false;
			object obj18 = 0;
			object obj19 = obj20;
			float num10 = num11;
			num7 = num12;
			Color32 color3 = (Color32)(&obj8);
			UnityEngine.Object obj28 = (UnityEngine.Object)playerRef;
		}
		else
		{
			obj27 = 0;
			obj8 = 0;
			Color32 color3 = (Color32)0;
			UnityEngine.Object obj28 = null;
		}
		bool value4 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v338 (System.Boolean)+E4]");
		bool flag18 = (nint)0 == 0;
		object obj29 = !flag18;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num14;
		if ((UnityEngine.Object)game != (UnityEngine.Object)null)
		{
			bool flag19 = (object)game == null;
			num4 = 0;
			flag6 = false;
			num5 = 0;
			num6 = 0;
			canvas3 = canvas2;
			color = (Color32)0;
			obj9 = null;
			gillaSplashLobby = this;
			text = (string)playerRef;
			text2 = (string)109891584;
			if (flag19)
			{
				goto IL_4245;
			}
			int num13 = game.Count(1);
			num14 = num13;
			UnityEngine.Object obj30 = (UnityEngine.Object)1;
		}
		else
		{
			num14 = 0;
			UnityEngine.Object obj30 = null;
		}
		bool value5 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X0_v343 (System.Boolean)+E4]");
		bool flag20 = (nint)0 == 0;
		object obj31 = !flag20;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num16;
		if ((UnityEngine.Object)game != (UnityEngine.Object)null)
		{
			bool flag21 = (object)game == null;
			num4 = 0;
			flag6 = false;
			num5 = 0;
			num6 = 0;
			canvas3 = canvas2;
			color = (Color32)0;
			obj9 = null;
			gillaSplashLobby = this;
			text = (string)playerRef;
			text2 = (string)109891584;
			if (flag21)
			{
				goto IL_4245;
			}
			int num15 = game.Count(2);
			UnityEngine.Object obj32 = (UnityEngine.Object)2;
			num16 = num15;
		}
		else
		{
			UnityEngine.Object obj32 = null;
			num16 = 0;
		}
		bool value6 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v348 (System.Boolean)+E4]");
		bool flag22 = (nint)0 == 0;
		object obj33 = !flag22;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)game != (UnityEngine.Object)null)
		{
			bool flag23 = (object)game == null;
			num4 = 0;
			flag6 = false;
			num5 = 0;
			num6 = 0;
			canvas3 = canvas2;
			color = (Color32)0;
			obj9 = null;
			gillaSplashLobby = this;
			text = (string)playerRef;
			text2 = (string)109891584;
			if (flag23)
			{
				goto IL_4245;
			}
			int num17 = game.Count(3);
			int num18 = num17;
			UnityEngine.Object obj34 = (UnityEngine.Object)3;
		}
		else
		{
			int num18 = 0;
			UnityEngine.Object obj34 = null;
		}
		bool value7 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1663 @ X0_v353 (System.Boolean)+E4]");
		bool flag24 = (nint)0 == 0;
		object obj35 = !flag24;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text5;
		int num19;
		int num25;
		if ((UnityEngine.Object)game == (UnityEngine.Object)null)
		{
			bool value8 = ((bool*)(flag2 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1843 @ X0_v661 (System.Boolean)+E4]");
			bool flag25 = (nint)0 == 0;
			object obj36 = !flag25;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
			bool flag26 = (UnityEngine.Object)0 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4698]");
			object obj37 = 0;
			text = (string)obj37;
			if (flag26)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
				bool flag27 = (nint)0 == 0;
				num4 = 0;
				flag6 = false;
				num5 = 0;
				num6 = 0;
				num19 = num16;
				canvas3 = canvas2;
				color = (Color32)0;
				obj9 = null;
				gillaSplashLobby = this;
				text2 = (string)109891584;
				if (flag27)
				{
					goto IL_4245;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				bool flag28 = (nint)0 < (nint)0;
				object obj18 = !flag28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				bool flag11 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				bool flag12 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				int num21 = (int)(num20 ^ 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				int num22 = (int)((nint)0 & (nint)num21);
				bool flag15 = num22 < 0;
				bool flag13 = !flag12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				int num23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v1 (UnityEngine.Object)+A4]");
				float num24 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2030 @ X9_v102+30]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2031 @ X0_v665+E4]");
			bool flag29 = (nint)0 == 0;
			object obj40 = !flag29;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3 = flag6.ToString();
			bool value9 = ((bool*)(flag2 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v455 (System.Boolean)+E4]");
			bool flag30 = (nint)0 == 0;
			object obj41 = !flag30;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
			string text4;
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
				bool flag31 = (nint)0 == 0;
				num4 = 0;
				num5 = 0;
				num6 = 0;
				num19 = num16;
				canvas3 = canvas2;
				color = (Color32)0;
				obj9 = null;
				gillaSplashLobby = this;
				text2 = text3;
				if (flag31)
				{
					goto IL_4245;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
				string offlineWhy = ((NetworkBootstrap)0).OfflineWhy;
				text4 = offlineWhy;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj42 = 0;
				text4 = (string)obj42;
			}
			text5 = text + text3 + text4;
			num9 = 0;
			string text6 = text3;
			num25 = num16;
			text2 = text3;
			goto IL_1f15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool flag32 = (object)game == null;
		num4 = 0;
		flag6 = false;
		num5 = 0;
		num6 = 0;
		num19 = num16;
		canvas3 = canvas2;
		color = (Color32)0;
		obj9 = (UnityEngine.Object)7;
		gillaSplashLobby = this;
		text = (string)playerRef;
		text2 = (string)109891584;
		int num32 = default;
		IndexOutOfRangeException ex = default;
		UnityEngine.Object obj45;
		if (!flag32)
		{
			byte phase = game.Phase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array = default;
			bool flag33 = array == null;
			num4 = 0;
			flag6 = false;
			num5 = 0;
			num6 = 0;
			byte b = phase;
			num19 = num16;
			canvas3 = canvas2;
			color = (Color32)0;
			obj9 = (UnityEngine.Object)(&b);
			gillaSplashLobby = this;
			text = (string)(object)array;
			text2 = (string)109891584;
			if (!flag33)
			{
				object obj44 = default;
				bool flag34 = obj44 == null;
				obj9 = (UnityEngine.Object)(&b);
				if (!flag34)
				{
					nint num26 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2099 @ X8_v450 (Il2CppClass<System.Object[]>)+40]");
					obj9 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag35 = ex == null;
					color = (Color32)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2099 @ X8_v450 (Il2CppClass<System.Object[]>)+40]");
					obj45 = (UnityEngine.Object)0;
					if (flag35)
					{
						goto IL_67e8;
					}
				}
				bool flag36 = array.Length == 0;
				color = (Color32)0;
				if (!flag36)
				{
					object obj46 = array + 32;
					obj46 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					byte map = game.Map;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj47 = default;
					bool flag37 = obj47 == null;
					byte b2 = default;
					obj9 = (UnityEngine.Object)(&b2);
					if (!flag37)
					{
						nint num27 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2543 @ X8_v449 (Il2CppClass<System.Object[]>)+40]");
						obj9 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag38 = ex == null;
						color = (Color32)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2543 @ X8_v449 (Il2CppClass<System.Object[]>)+40]");
						obj45 = (UnityEngine.Object)0;
						if (flag38)
						{
							goto IL_67e8;
						}
					}
					object obj48 = array.Length & 0xFFFFFFFEL;
					bool flag39 = obj48 == null;
					color = (Color32)0;
					if (!flag39)
					{
						object obj49 = array + 40;
						obj49 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj50 = default;
						bool flag40 = obj50 == null;
						GillaMapVote.Canvas canvas4 = default;
						obj9 = (UnityEngine.Object)(&canvas4);
						if (!flag40)
						{
							nint num28 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2544 @ X8_v448 (Il2CppClass<System.Object[]>)+40]");
							obj9 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag41 = ex == null;
							color = (Color32)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2544 @ X8_v448 (Il2CppClass<System.Object[]>)+40]");
							obj45 = (UnityEngine.Object)0;
							if (flag41)
							{
								goto IL_67e8;
							}
						}
						bool flag42 = array.Length < 2;
						object obj51 = !flag42;
						object obj52 = array.Length - 2;
						bool flag43 = obj52 == null;
						object obj53 = ~obj51;
						object obj54 = obj53 | flag43;
						color = (Color32)0;
						if (obj54 == null)
						{
							object obj55 = array + 48;
							obj55 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int num29 = game.VotesFor(0);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj56 = default;
							bool flag44 = obj56 == null;
							obj9 = (UnityEngine.Object)(&num8);
							if (!flag44)
							{
								nint num30 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2545 @ X8_v447 (Il2CppClass<System.Object[]>)+40]");
								obj9 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag45 = ex == null;
								color = (Color32)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2545 @ X8_v447 (Il2CppClass<System.Object[]>)+40]");
								obj45 = (UnityEngine.Object)0;
								if (flag45)
								{
									goto IL_67e8;
								}
							}
							object obj57 = array.Length & 0xFFFFFFFCL;
							bool flag46 = obj57 == null;
							color = (Color32)0;
							if (!flag46)
							{
								object obj58 = array + 56;
								obj58 = obj56;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								int num31 = game.VotesFor(1);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj59 = default;
								bool flag47 = obj59 == null;
								obj9 = (UnityEngine.Object)(&num32);
								if (!flag47)
								{
									nint num33 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ X8_v446 (Il2CppClass<System.Object[]>)+40]");
									obj9 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag48 = ex == null;
									color = (Color32)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ X8_v446 (Il2CppClass<System.Object[]>)+40]");
									obj45 = (UnityEngine.Object)0;
									if (flag48)
									{
										goto IL_67e8;
									}
								}
								bool flag49 = array.Length < 4;
								object obj60 = !flag49;
								object obj61 = array.Length - 4;
								bool flag50 = obj61 == null;
								object obj62 = ~obj60;
								object obj63 = obj62 | flag50;
								color = (Color32)0;
								if (obj63 == null)
								{
									object obj64 = array + 64;
									obj64 = obj59;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num34 = game.VotesFor(2);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj65 = default;
									bool flag51 = obj65 == null;
									int num35 = default;
									obj9 = (UnityEngine.Object)(&num35);
									if (!flag51)
									{
										nint num36 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2547 @ X8_v445 (Il2CppClass<System.Object[]>)+40]");
										obj9 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag52 = ex == null;
										color = (Color32)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2547 @ X8_v445 (Il2CppClass<System.Object[]>)+40]");
										obj45 = (UnityEngine.Object)0;
										if (flag52)
										{
											goto IL_67e8;
										}
									}
									bool flag53 = array.Length < 5;
									object obj66 = !flag53;
									object obj67 = array.Length - 5;
									bool flag54 = obj67 == null;
									object obj68 = ~obj66;
									object obj69 = obj68 | flag54;
									color = (Color32)0;
									if (obj69 == null)
									{
										object obj70 = array + 72;
										obj70 = obj65;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										float voteEnds = game.VoteEnds;
										float now = game.Now;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj71 = 0;
										object obj72 = obj71;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3519 @ X0_v542+E4]");
										bool flag55 = (nint)0 == 0;
										object obj73 = !flag55;
										if (obj73 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										string text7 = default;
										bool flag56 = text7 == null;
										float num37 = default;
										obj9 = (UnityEngine.Object)(&num37);
										if (!flag56)
										{
											nint num38 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2548 @ X8_v443 (Il2CppClass<System.Object[]>)+40]");
											obj9 = (UnityEngine.Object)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag57 = ex == null;
											num7 = now;
											color = (Color32)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2548 @ X8_v443 (Il2CppClass<System.Object[]>)+40]");
											obj45 = (UnityEngine.Object)0;
											if (flag57)
											{
												goto IL_67e8;
											}
										}
										bool flag58 = array.Length < 6;
										object obj18 = !flag58;
										float num24 = (float)array.Length - 6f;
										bool flag11 = num24 < 0f;
										bool flag12 = num24 == 0f;
										int num23 = array.Length ^ 6;
										int num21 = array.Length ^ num24;
										int num22 = num23 & num21;
										bool flag15 = num22 < 0;
										object obj74 = ~obj18;
										bool flag13 = (byte)((obj74 | flag12) ? 1 : 0) != 0;
										num7 = now;
										color = (Color32)0;
										if (!flag13)
										{
											object obj75 = array + 80;
											obj75 = text7;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82D0]");
											object format = 0;
											string text8 = string.Format((string)format, array);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
											float phaseEnds = game.PhaseEnds;
											num7 = game.Now;
											object obj76 = obj71;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3674 @ X0_v557+E4]");
											bool flag59 = (nint)0 == 0;
											object obj77 = !flag59;
											if (obj77 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
											flag2 = false;
											object[] array2 = default;
											bool flag60 = array2 == null;
											num4 = 0;
											flag6 = false;
											num5 = 0;
											num6 = 0;
											float num39 = num7;
											GillaSplashLobby gillaSplashLobby2 = (GillaSplashLobby)(object)canvas2;
											num32 = num31;
											num19 = num16;
											canvas3 = (GillaMapVote.Canvas)(object)array2;
											num8 = num29;
											color = (Color32)0;
											obj9 = (UnityEngine.Object)(&num39);
											gillaSplashLobby = this;
											text = text8;
											text2 = text7;
											if (flag60)
											{
												goto IL_4245;
											}
											object obj78 = default;
											bool flag61 = obj78 == null;
											obj9 = (UnityEngine.Object)(&num39);
											if (!flag61)
											{
												nint num40 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v441 (Il2CppClass<System.Object[]>)+40]");
												obj9 = (UnityEngine.Object)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag62 = ex == null;
												color = (Color32)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v441 (Il2CppClass<System.Object[]>)+40]");
												obj45 = (UnityEngine.Object)0;
												if (flag62)
												{
													goto IL_67e8;
												}
											}
											bool flag63 = array2.Length == 0;
											color = (Color32)0;
											if (!flag63)
											{
												object obj79 = array2 + 32;
												obj79 = obj78;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												int round = game.Round;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												object obj80 = default;
												bool flag64 = obj80 == null;
												int num41 = default;
												obj9 = (UnityEngine.Object)(&num41);
												if (!flag64)
												{
													nint num42 = (nint)array2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2550 @ X8_v440 (Il2CppClass<System.Object[]>)+40]");
													obj9 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag65 = ex == null;
													color = (Color32)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2550 @ X8_v440 (Il2CppClass<System.Object[]>)+40]");
													obj45 = (UnityEngine.Object)0;
													if (flag65)
													{
														goto IL_67e8;
													}
												}
												object obj81 = array2.Length & 0xFFFFFFFEL;
												bool flag66 = obj81 == null;
												color = (Color32)0;
												if (!flag66)
												{
													object obj82 = array2 + 40;
													obj82 = obj80;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													bool tied = game.Tied;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													object obj83 = default;
													bool flag67 = obj83 == null;
													object obj84 = default;
													obj9 = (UnityEngine.Object)(&obj84);
													if (!flag67)
													{
														nint num43 = (nint)array2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2551 @ X8_v439 (Il2CppClass<System.Object[]>)+40]");
														obj9 = (UnityEngine.Object)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag68 = ex == null;
														color = (Color32)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2551 @ X8_v439 (Il2CppClass<System.Object[]>)+40]");
														obj45 = (UnityEngine.Object)0;
														if (flag68)
														{
															goto IL_67e8;
														}
													}
													bool flag69 = array2.Length < 2;
													object obj85 = !flag69;
													object obj86 = array2.Length - 2;
													bool flag70 = obj86 == null;
													object obj87 = ~obj85;
													object obj88 = obj87 | flag70;
													color = (Color32)0;
													if (obj88 == null)
													{
														object obj89 = array2 + 48;
														obj89 = obj83;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														object obj90 = default;
														bool flag71 = obj90 == null;
														int num44 = default;
														obj9 = (UnityEngine.Object)(&num44);
														if (!flag71)
														{
															nint num45 = (nint)array2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2552 @ X8_v438 (Il2CppClass<System.Object[]>)+40]");
															obj9 = (UnityEngine.Object)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag72 = ex == null;
															color = (Color32)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2552 @ X8_v438 (Il2CppClass<System.Object[]>)+40]");
															obj45 = (UnityEngine.Object)0;
															if (flag72)
															{
																goto IL_67e8;
															}
														}
														object obj91 = array2.Length & 0xFFFFFFFCL;
														bool flag73 = obj91 == null;
														color = (Color32)0;
														if (!flag73)
														{
															object obj92 = array2 + 56;
															obj92 = obj90;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
															object obj93 = default;
															bool flag74 = obj93 == null;
															int num46 = default;
															obj9 = (UnityEngine.Object)(&num46);
															if (!flag74)
															{
																nint num47 = (nint)array2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2553 @ X8_v437 (Il2CppClass<System.Object[]>)+40]");
																obj9 = (UnityEngine.Object)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag75 = ex == null;
																color = (Color32)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2553 @ X8_v437 (Il2CppClass<System.Object[]>)+40]");
																obj45 = (UnityEngine.Object)0;
																if (flag75)
																{
																	goto IL_67e8;
																}
															}
															bool flag76 = array2.Length < 4;
															object obj94 = !flag76;
															object obj95 = array2.Length - 4;
															bool flag77 = obj95 == null;
															object obj96 = ~obj94;
															object obj97 = obj96 | flag77;
															color = (Color32)0;
															if (obj97 == null)
															{
																object obj98 = array2 + 64;
																obj98 = obj93;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																object obj99 = default;
																bool flag78 = obj99 == null;
																int num48 = default;
																obj9 = (UnityEngine.Object)(&num48);
																if (!flag78)
																{
																	nint num49 = (nint)array2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2554 @ X8_v436 (Il2CppClass<System.Object[]>)+40]");
																	obj9 = (UnityEngine.Object)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																	bool flag79 = ex == null;
																	color = (Color32)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2554 @ X8_v436 (Il2CppClass<System.Object[]>)+40]");
																	obj45 = (UnityEngine.Object)0;
																	if (flag79)
																	{
																		goto IL_67e8;
																	}
																}
																bool flag80 = array2.Length < 5;
																object obj100 = !flag80;
																object obj101 = array2.Length - 5;
																bool flag81 = obj101 == null;
																object obj102 = ~obj100;
																object obj103 = obj102 | flag81;
																color = (Color32)0;
																if (obj103 == null)
																{
																	object obj104 = array2 + 72;
																	obj104 = obj99;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																	object obj105 = default;
																	bool flag82 = obj105 == null;
																	object obj106 = default;
																	obj9 = (UnityEngine.Object)(&obj106);
																	if (!flag82)
																	{
																		nint num50 = (nint)array2;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2555 @ X8_v435 (Il2CppClass<System.Object[]>)+40]");
																		obj9 = (UnityEngine.Object)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																		bool flag83 = ex == null;
																		color = (Color32)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2555 @ X8_v435 (Il2CppClass<System.Object[]>)+40]");
																		obj45 = (UnityEngine.Object)0;
																		if (flag83)
																		{
																			goto IL_67e8;
																		}
																	}
																	bool flag84 = array2.Length < 6;
																	object obj107 = !flag84;
																	object obj108 = array2.Length - 6;
																	bool flag85 = obj108 == null;
																	object obj109 = ~obj107;
																	object obj110 = obj109 | flag85;
																	color = (Color32)0;
																	if (obj110 == null)
																	{
																		object obj111 = array2 + 80;
																		obj111 = obj105;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																		object obj112 = default;
																		bool flag86 = obj112 == null;
																		bool flag87 = default;
																		obj9 = (UnityEngine.Object)(&flag87);
																		if (!flag86)
																		{
																			nint num51 = (nint)array2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2556 @ X8_v434 (Il2CppClass<System.Object[]>)+40]");
																			obj9 = (UnityEngine.Object)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																			bool flag88 = ex == null;
																			color = (Color32)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2556 @ X8_v434 (Il2CppClass<System.Object[]>)+40]");
																			obj45 = (UnityEngine.Object)0;
																			if (flag88)
																			{
																				goto IL_67e8;
																			}
																		}
																		object obj113 = array2.Length & 0xFFFFFFF8L;
																		bool flag89 = obj113 == null;
																		color = (Color32)0;
																		if (!flag89)
																		{
																			object obj114 = array2 + 88;
																			obj114 = obj112;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																			string text9 = default;
																			bool flag90 = text9 == null;
																			bool flag91 = default;
																			obj9 = (UnityEngine.Object)(&flag91);
																			if (!flag90)
																			{
																				nint num52 = (nint)array2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2557 @ X8_v433 (Il2CppClass<System.Object[]>)+40]");
																				obj9 = (UnityEngine.Object)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																				bool flag92 = ex == null;
																				color = (Color32)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2557 @ X8_v433 (Il2CppClass<System.Object[]>)+40]");
																				obj45 = (UnityEngine.Object)0;
																				if (flag92)
																				{
																					goto IL_67e8;
																				}
																			}
																			bool flag93 = array2.Length < 8;
																			obj18 = !flag93;
																			num24 = (float)array2.Length - 8f;
																			flag11 = num24 < 0f;
																			flag12 = num24 == 0f;
																			num23 = array2.Length ^ 8;
																			num21 = array2.Length ^ num24;
																			num22 = num23 & num21;
																			flag15 = num22 < 0;
																			object obj115 = ~obj18;
																			flag13 = (byte)((obj115 | flag12) ? 1 : 0) != 0;
																			color = (Color32)0;
																			if (!flag13)
																			{
																				object obj116 = array2 + 96;
																				obj116 = text9;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8200]");
																				object format2 = 0;
																				string text10 = string.Format((string)format2, array2);
																				text5 = text8 + text10;
																				flag6 = false;
																				gillaSplashLobby2 = (GillaSplashLobby)(object)canvas2;
																				num32 = num31;
																				num8 = num29;
																				string text4 = null;
																				string text6 = text10;
																				text2 = text9;
																				goto IL_1f15;
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
				goto IL_67d2;
			}
		}
		goto IL_4245;
		IL_4245:
		throw new NullReferenceException();
		IL_67e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_1f15:
		bool value10 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2742 @ X0_v358 (System.Boolean)+E4]");
		bool flag94 = (nint)0 == 0;
		object obj117 = !flag94;
		if (obj117 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
			bool flag95 = (nint)0 == 0;
			num4 = 0;
			num5 = 0;
			num6 = 0;
			num19 = num16;
			canvas3 = canvas2;
			color = (Color32)0;
			obj9 = null;
			gillaSplashLobby = this;
			text = text5;
			if (flag95)
			{
				goto IL_4245;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
			object obj118 = 0;
			text2 = (string)obj118;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
			int playerCount = ((NetworkBootstrap)0).PlayerCount;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
			object obj119 = 0;
			text2 = (string)obj119;
		}
		string text11 = num4.ToString();
		string text12 = text5 + text2 + text11;
		if (text12 == drawn)
		{
			return;
		}
		object obj120 = this + 272;
		drawn = text12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		GillaMapVote.Canvas[] array3 = panelCanvas;
		bool flag96 = panelCanvas == null;
		num5 = 0;
		num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
		UnityEngine.Object obj121 = (UnityEngine.Object)0;
		num19 = num16;
		canvas3 = canvas2;
		num9 = 0;
		color = (Color32)0;
		obj9 = (UnityEngine.Object)(object)text12;
		gillaSplashLobby = this;
		text = text12;
		if (!flag96)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			double num53 = 0.0;
			object obj122 = canvas2 & 0xFF;
			bool flag98 = default;
			bool flag97 = flag98;
			int num55 = default;
			int num54 = num55;
			Color32[] array5 = default;
			Color32[] array4 = array5;
			string text14 = default;
			string text13 = text14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
			UnityEngine.Object obj123 = (UnityEngine.Object)0;
			bool flag99 = flag2;
			int num56 = 0;
			bool flag100 = flag14;
			int num57 = 0;
			float num58 = num7;
			Color32 color4 = (Color32)0;
			UnityEngine.Object obj124 = (UnityEngine.Object)(object)text12;
			GillaSplashLobby gillaSplashLobby3 = this;
			string text15 = text12;
			string text16 = text2;
			Texture2D texture2D2 = default;
			int num62 = default;
			object arg = default;
			object arg2 = default;
			object obj211 = default;
			object obj214 = default;
			object obj218 = default;
			object obj225 = default;
			object arg3 = default;
			object arg4 = default;
			string text34 = default;
			object obj239 = default;
			int num71 = default;
			object obj261;
			object arg5 = default;
			object arg6 = default;
			object arg7 = default;
			object arg8 = default;
			int num81 = default;
			do
			{
				bool flag101 = num56 < array3.Length;
				object obj18 = !flag101;
				float num24 = (float)num56 - (float)array3.Length;
				bool flag11 = num24 < 0f;
				bool flag12 = num24 == 0f;
				int num23 = num56 ^ array3.Length;
				int num21 = num56 ^ num24;
				int num22 = num23 & num21;
				bool flag15 = num22 < 0;
				bool flag13 = num56 >= array3.Length;
				num5 = 0;
				num6 = 0;
				flag98 = flag97;
				num55 = num54;
				array5 = array4;
				text14 = text13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
				obj121 = (UnityEngine.Object)0;
				object obj71 = 712964571136L;
				GillaSplashLobby gillaSplashLobby2 = this;
				flag2 = flag99;
				num19 = num16;
				int num18 = num56;
				canvas3 = canvas2;
				flag14 = flag100;
				num9 = num57;
				num7 = num58;
				color = color4;
				obj9 = obj124;
				gillaSplashLobby = gillaSplashLobby3;
				text = text15;
				text2 = text16;
				bool flag109;
				Renderer renderer;
				Texture2D texture2D;
				if (!flag13)
				{
					MapEntry[] array6 = gillaSplashLobby3.maps;
					bool flag102 = gillaSplashLobby3.maps == null;
					num5 = 0;
					num6 = 0;
					flag98 = flag97;
					num55 = num54;
					array5 = array4;
					text14 = text13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
					obj121 = (UnityEngine.Object)0;
					obj71 = 712964571136L;
					gillaSplashLobby2 = this;
					flag2 = flag99;
					num19 = num16;
					num18 = num56;
					canvas3 = canvas2;
					flag14 = flag100;
					num9 = num57;
					num7 = num58;
					color = color4;
					obj9 = obj124;
					gillaSplashLobby = gillaSplashLobby3;
					text = text15;
					text2 = text16;
					if (flag102)
					{
						break;
					}
					bool flag103 = num56 < array6.Length;
					obj18 = !flag103;
					num24 = (float)num56 - (float)array6.Length;
					flag11 = num24 < 0f;
					flag12 = num24 == 0f;
					num23 = num56 ^ array6.Length;
					num21 = num56 ^ num24;
					num22 = num23 & num21;
					flag15 = num22 < 0;
					flag13 = num56 >= array6.Length;
					num5 = 0;
					num6 = 0;
					flag98 = flag97;
					num55 = num54;
					array5 = array4;
					text14 = text13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
					obj121 = (UnityEngine.Object)0;
					obj71 = 712964571136L;
					gillaSplashLobby2 = this;
					flag2 = flag99;
					num19 = num16;
					num18 = num56;
					canvas3 = canvas2;
					flag14 = flag100;
					num9 = num57;
					num7 = num58;
					color = color4;
					obj9 = obj124;
					gillaSplashLobby = gillaSplashLobby3;
					text = text15;
					text2 = text16;
					if (!flag13)
					{
						bool flag104 = num56 < array3.Length;
						obj18 = !flag104;
						num24 = (float)num56 - (float)array3.Length;
						flag11 = num24 < 0f;
						flag12 = num24 == 0f;
						num23 = num56 ^ array3.Length;
						num21 = num56 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						flag98 = flag97;
						num55 = num54;
						array5 = array4;
						text14 = text13;
						num9 = num57;
						num7 = num58;
						color = color4;
						obj9 = obj124;
						if (obj18 == null)
						{
							object obj125 = array3 + num56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3248 @ X8_v272+20]");
							canvas3 = (GillaMapVote.Canvas)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3248 @ X8_v272+20]");
							if ((nint)0 == 0)
							{
								goto IL_4148;
							}
							object obj126 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3369 @ X0_v373+E4]");
							bool flag105 = (nint)0 == 0;
							object obj127 = !flag105;
							if (obj127 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj126 = obj43;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3369 @ X0_v373+A0]");
							object obj128 = 0;
							GillaMapVote.Canvas canvas5 = canvas3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3371 @ X8_v276+8]");
							nint num59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3371 @ X8_v276+C]");
							canvas5.Clear((Color32)num59, (Color32)0);
							bool value11 = ((bool*)(flag99 ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3389 @ X0_v375 (System.Boolean)+E4]");
							bool flag106 = (nint)0 == 0;
							object obj129 = !flag106;
							if (obj129 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)game != (UnityEngine.Object)null)
							{
								bool flag107 = (object)game == null;
								num5 = 0;
								num6 = 0;
								flag98 = flag97;
								num55 = num54;
								array5 = array4;
								text14 = text13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
								obj121 = (UnityEngine.Object)0;
								obj71 = 712964571136L;
								gillaSplashLobby2 = this;
								flag2 = flag99;
								num19 = num16;
								num18 = num56;
								flag14 = flag100;
								num9 = 0;
								num7 = num58;
								color = (Color32)0;
								obj9 = null;
								gillaSplashLobby = gillaSplashLobby3;
								text = text15;
								text2 = text16;
								if (flag107)
								{
									break;
								}
								byte phase2 = game.Phase;
								int num60 = phase2 & 0xFF;
								bool flag108 = num60 == 0;
								flag109 = flag108;
							}
							else
							{
								flag109 = false;
							}
							bool value12 = ((bool*)(flag99 ? 1 : 0))->m_value;
							bool flag110 = num56 < (nint)obj122;
							obj18 = !flag110;
							num24 = (float)num56 - (float)obj122;
							flag11 = num24 < 0f;
							flag12 = num24 == 0f;
							num23 = num56 ^ obj122;
							num21 = num56 ^ num24;
							num22 = num23 & num21;
							flag15 = num22 < 0;
							flag2 = flag12 && flag109;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3483 @ X0_v380 (System.Boolean)+E4]");
							bool flag111 = (nint)0 == 0;
							object obj130 = !flag111;
							if (obj130 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag112 = (UnityEngine.Object)game != (UnityEngine.Object)null;
							object obj131 = !flag112;
							object obj132 = flag109 | obj131;
							object obj133 = obj132 & 1;
							if (obj133 != null)
							{
								obj123 = null;
							}
							else
							{
								bool flag113 = (object)game == null;
								num5 = 0;
								num6 = 0;
								flag98 = flag97;
								num55 = num54;
								array5 = array4;
								text14 = text13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
								obj121 = (UnityEngine.Object)0;
								obj71 = 712964571136L;
								gillaSplashLobby2 = this;
								num19 = num16;
								num18 = num56;
								num9 = 0;
								num7 = num58;
								color = (Color32)0;
								obj9 = null;
								gillaSplashLobby = gillaSplashLobby3;
								text = text15;
								text2 = text16;
								if (flag113)
								{
									break;
								}
								byte map2 = game.Map;
								bool flag114 = num56 < map2;
								obj18 = !flag114;
								num24 = (float)num56 - (float)(int)map2;
								flag11 = num24 < 0f;
								flag12 = num24 == 0f;
								num23 = num56 ^ map2;
								num21 = num56 ^ num24;
								num22 = num23 & num21;
								flag15 = num22 < 0;
								obj123 = (UnityEngine.Object)flag12;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj134 = 0;
							object obj135 = obj134;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3571 @ X0_v385+E4]");
							bool flag115 = (nint)0 == 0;
							object obj136 = !flag115;
							if (obj136 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag116 = (UnityEngine.Object)game != (UnityEngine.Object)null;
							object obj137 = obj43;
							object obj142;
							if (flag2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3643 @ X8_v354+E4]");
								bool flag117 = (nint)0 == 0;
								object obj138 = !flag117;
								if (obj138 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj137 = obj43;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3643 @ X8_v354+A0]");
								object obj139 = 0;
								canvas3.Outline((RectInt)0, (Color32)893353197824L);
								object obj140 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3656 @ X0_v473+E4]");
								bool flag118 = (nint)0 == 0;
								object obj141 = !flag118;
								if (obj141 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj140 = obj43;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3656 @ X0_v473+A0]");
								obj142 = (nint)0 + (nint)28;
							}
							else
							{
								object obj143 = obj123 & 1;
								if (obj143 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3643 @ X8_v354+E4]");
									bool flag119 = (nint)0 == 0;
									object obj144 = !flag119;
									if (obj144 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj137 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3643 @ X8_v354+A0]");
									object obj145 = 0;
									canvas3.Outline((RectInt)0, (Color32)893353197824L);
									object obj146 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3684 @ X0_v465+E4]");
									bool flag120 = (nint)0 == 0;
									object obj147 = !flag120;
									if (obj147 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj146 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3684 @ X0_v465+A0]");
									obj142 = (nint)0 + (nint)16;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3643 @ X8_v354+E4]");
									bool flag121 = (nint)0 == 0;
									object obj148 = !flag121;
									if (obj148 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj137 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3643 @ X8_v354+A0]");
									object obj149 = 0;
									canvas3.Outline((RectInt)0, (Color32)893353197824L);
									object obj150 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3683 @ X0_v457+E4]");
									bool flag122 = (nint)0 == 0;
									object obj151 = !flag122;
									if (obj151 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj150 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3683 @ X0_v457+A0]");
									obj142 = (nint)0 + (nint)24;
								}
							}
							num9 = (int)obj142;
							canvas3.Outline((RectInt)4294967297L, (Color32)884763263230L);
							MapEntry[] array7 = gillaSplashLobby3.maps;
							bool flag123 = gillaSplashLobby3.maps == null;
							num5 = 0;
							num6 = 0;
							flag98 = flag97;
							num55 = num54;
							array5 = array4;
							text14 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
							obj121 = (UnityEngine.Object)0;
							obj71 = 712964571136L;
							gillaSplashLobby2 = this;
							num19 = num16;
							num18 = num56;
							num7 = num58;
							color = (Color32)884763263230L;
							obj9 = (UnityEngine.Object)4294967297L;
							gillaSplashLobby = gillaSplashLobby3;
							text = (string)flag116;
							text2 = text16;
							if (flag123)
							{
								break;
							}
							bool flag124 = num56 < array7.Length;
							obj18 = !flag124;
							num24 = (float)num56 - (float)array7.Length;
							flag11 = num24 < 0f;
							flag12 = num24 == 0f;
							num23 = num56 ^ array7.Length;
							num21 = num56 ^ num24;
							num22 = num23 & num21;
							flag15 = num22 < 0;
							flag98 = flag97;
							num55 = num54;
							array5 = array4;
							text14 = null;
							num7 = num58;
							color = (Color32)884763263230L;
							obj9 = (UnityEngine.Object)4294967297L;
							if (obj18 == null)
							{
								object obj152 = gillaSplashLobby3.maps + num56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3702 @ X8_v286+20]");
								object obj153 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3702 @ X8_v286+20]");
								bool flag125 = (nint)0 == 0;
								num5 = 0;
								num6 = 0;
								flag98 = flag97;
								num55 = num54;
								array5 = array4;
								text14 = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
								obj121 = (UnityEngine.Object)0;
								obj71 = 712964571136L;
								gillaSplashLobby2 = this;
								num19 = num16;
								num18 = num56;
								num7 = num58;
								color = (Color32)884763263230L;
								obj9 = (UnityEngine.Object)4294967297L;
								gillaSplashLobby = gillaSplashLobby3;
								text = (string)flag116;
								text2 = text16;
								if (flag125)
								{
									break;
								}
								object obj154 = (flag116 ? 1 : 0) ^ 1;
								object obj155 = flag109 | obj123;
								object obj156 = obj43;
								gillaSplashLobby = (GillaSplashLobby)(obj154 | obj155);
								object obj157 = gillaSplashLobby & 1;
								object obj159;
								if (obj157 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3727 @ X0_v448+E4]");
									bool flag126 = (nint)0 == 0;
									object obj158 = !flag126;
									if (obj158 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj156 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3727 @ X0_v448+A0]");
									obj159 = (nint)0 + (nint)32;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3727 @ X0_v448+E4]");
									bool flag127 = (nint)0 == 0;
									object obj160 = !flag127;
									if (obj160 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj156 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3727 @ X0_v448+A0]");
									obj159 = (nint)0 + (nint)56;
								}
								array5 = (Color32[])obj159;
								GillaMapVote.Canvas canvas6 = canvas3;
								ScreenFont font = title;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
								canvas6.Text(font, 10, 6, (string)0, (Color32[])obj159, 2, centred: false);
								Renderer[] array8 = panelCovers;
								bool flag128 = panelCovers == null;
								num5 = 0;
								num6 = 0;
								flag98 = false;
								num55 = 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
								text14 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
								obj121 = (UnityEngine.Object)0;
								obj71 = 712964571136L;
								gillaSplashLobby2 = this;
								num19 = num16;
								num18 = num56;
								num9 = 6;
								num7 = num58;
								color = (Color32)10;
								obj9 = (UnityEngine.Object)(object)title;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
								text = (string)0;
								text2 = (string)(object)title;
								if (flag128)
								{
									break;
								}
								bool flag129 = num56 < array8.Length;
								obj18 = !flag129;
								num24 = (float)num56 - (float)array8.Length;
								flag11 = num24 < 0f;
								flag12 = num24 == 0f;
								num23 = num56 ^ array8.Length;
								num21 = num56 ^ num24;
								num22 = num23 & num21;
								flag15 = num22 < 0;
								if (num56 < array8.Length)
								{
									bool flag130 = num56 < array8.Length;
									obj18 = !flag130;
									num24 = (float)num56 - (float)array8.Length;
									flag11 = num24 < 0f;
									flag12 = num24 == 0f;
									num23 = num56 ^ array8.Length;
									num21 = num56 ^ num24;
									num22 = num23 & num21;
									flag15 = num22 < 0;
									flag98 = false;
									num55 = 2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
									text14 = (string)0;
									num9 = 6;
									num7 = num58;
									color = (Color32)10;
									obj9 = (UnityEngine.Object)(object)title;
									if (obj18 != null)
									{
										goto IL_67d2;
									}
									object obj161 = panelCovers + num56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3760 @ X8_v349+20]");
									renderer = (Renderer)0;
								}
								else
								{
									renderer = null;
								}
								MapEntry[] array9 = maps;
								bool flag131 = maps == null;
								num5 = 0;
								num6 = 0;
								flag98 = false;
								num55 = 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
								text14 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
								obj121 = (UnityEngine.Object)0;
								obj71 = 712964571136L;
								gillaSplashLobby2 = this;
								num19 = num16;
								num18 = num56;
								num9 = 6;
								num7 = num58;
								color = (Color32)10;
								obj9 = (UnityEngine.Object)(object)title;
								text = (string)(object)renderer;
								text2 = (string)(object)title;
								if (flag131)
								{
									break;
								}
								bool flag132 = num56 < array9.Length;
								obj18 = !flag132;
								num24 = (float)num56 - (float)array9.Length;
								flag11 = num24 < 0f;
								flag12 = num24 == 0f;
								num23 = num56 ^ array9.Length;
								num21 = num56 ^ num24;
								num22 = num23 & num21;
								flag15 = num22 < 0;
								flag98 = false;
								num55 = 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
								text14 = (string)0;
								num9 = 6;
								num7 = num58;
								color = (Color32)10;
								obj9 = (UnityEngine.Object)(object)title;
								if (obj18 == null)
								{
									object obj162 = maps + num56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3770 @ X8_v295+20]");
									object obj163 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3770 @ X8_v295+20]");
									bool flag133 = (nint)0 == 0;
									num5 = 0;
									num6 = 0;
									flag98 = false;
									num55 = 2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
									text14 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
									obj121 = (UnityEngine.Object)0;
									obj71 = 712964571136L;
									gillaSplashLobby2 = this;
									num19 = num16;
									num18 = num56;
									num9 = 6;
									num7 = num58;
									color = (Color32)10;
									obj9 = (UnityEngine.Object)(object)title;
									text = (string)(object)renderer;
									text2 = (string)(object)title;
									if (flag133)
									{
										break;
									}
									object obj164 = gillaSplashLobby & 1;
									flag11 = (nint)obj164 < 0;
									flag12 = obj164 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
									object obj165 = 0;
									flag13 = !flag12;
									flag14 = !flag13;
									double num61 = (flag14 ? num53 : 1.0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v296+20]");
									texture2D = (Texture2D)0;
									object obj166 = obj165;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3788 @ X0_v394+E4]");
									bool flag134 = (nint)0 == 0;
									object obj167 = !flag134;
									if (obj167 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag135 = GillaMapVote.ShowCover(renderer, texture2D, (float)num61);
									bool flag136 = !flag135;
									object obj168 = !flag136;
									flag98 = false;
									num55 = 2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
									text14 = (string)0;
									flag15 = false;
									obj18 = 0;
									num9 = 6;
									num7 = (float)num61;
									color = (Color32)0;
									obj9 = texture2D;
									if (obj168 == null)
									{
										Color32[][] array10 = pictures;
										bool flag137 = pictures == null;
										num5 = 0;
										num6 = 0;
										flag98 = false;
										num55 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
										text14 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
										obj121 = (UnityEngine.Object)0;
										obj71 = 712964571136L;
										gillaSplashLobby2 = this;
										num19 = num16;
										num18 = num56;
										flag15 = false;
										obj18 = 0;
										num9 = 6;
										num7 = (float)num61;
										color = (Color32)0;
										obj9 = texture2D;
										gillaSplashLobby = this;
										text = (string)(object)renderer;
										text2 = (string)(object)texture2D;
										if (flag137)
										{
											break;
										}
										bool flag138 = num56 < array10.Length;
										obj18 = !flag138;
										num24 = (float)num56 - (float)array10.Length;
										flag11 = num24 < 0f;
										flag12 = num24 == 0f;
										num23 = num56 ^ array10.Length;
										num21 = num56 ^ num24;
										num22 = num23 & num21;
										flag15 = num22 < 0;
										flag13 = num56 >= array10.Length;
										flag98 = false;
										num55 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
										text14 = (string)0;
										num9 = 6;
										num7 = (float)num61;
										color = (Color32)0;
										obj9 = texture2D;
										if (!flag13)
										{
											bool flag139 = num56 < array10.Length;
											obj18 = !flag139;
											num24 = (float)num56 - (float)array10.Length;
											flag11 = num24 < 0f;
											flag12 = num24 == 0f;
											num23 = num56 ^ array10.Length;
											num21 = num56 ^ num24;
											num22 = num23 & num21;
											flag15 = num22 < 0;
											flag98 = false;
											num55 = 2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
											text14 = (string)0;
											num9 = 6;
											num7 = (float)num61;
											color = (Color32)0;
											obj9 = texture2D;
											if (obj18 == null)
											{
												object obj169 = pictures + num56;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
												renderer = (Renderer)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
												bool flag140 = (nint)0 == 0;
												flag98 = false;
												num55 = 2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
												text14 = (string)0;
												num9 = 6;
												num7 = (float)num61;
												color = (Color32)0;
												obj9 = texture2D;
												if (flag140)
												{
													goto IL_3bac;
												}
												MapEntry[] array11 = maps;
												bool flag141 = maps == null;
												num5 = 0;
												num6 = 0;
												flag98 = false;
												num55 = 2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
												text14 = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
												obj121 = (UnityEngine.Object)0;
												obj71 = 712964571136L;
												gillaSplashLobby2 = this;
												num19 = num16;
												num18 = num56;
												num9 = 6;
												num7 = (float)num61;
												color = (Color32)0;
												obj9 = texture2D;
												gillaSplashLobby = this;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
												text = (string)0;
												text2 = (string)(object)texture2D;
												if (flag141)
												{
													break;
												}
												bool flag142 = num56 < array11.Length;
												obj18 = !flag142;
												num24 = (float)num56 - (float)array11.Length;
												flag11 = num24 < 0f;
												flag12 = num24 == 0f;
												num23 = num56 ^ array11.Length;
												num21 = num56 ^ num24;
												num22 = num23 & num21;
												flag15 = num22 < 0;
												flag98 = false;
												num55 = 2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
												text14 = (string)0;
												num9 = 6;
												num7 = (float)num61;
												color = (Color32)0;
												obj9 = texture2D;
												if (obj18 == null)
												{
													object obj170 = maps + num56;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3928 @ X8_v342+20]");
													object obj171 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3928 @ X8_v342+20]");
													bool flag143 = (nint)0 == 0;
													num5 = 0;
													num6 = 0;
													flag98 = false;
													num55 = 2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
													text14 = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
													obj121 = (UnityEngine.Object)0;
													obj71 = 712964571136L;
													gillaSplashLobby2 = this;
													num19 = num16;
													num18 = num56;
													num9 = 6;
													num7 = (float)num61;
													color = (Color32)0;
													obj9 = texture2D;
													gillaSplashLobby = this;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
													text = (string)0;
													text2 = (string)(object)texture2D;
													if (flag143)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X8_v343+18]");
													object obj172 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X8_v343+18]");
													bool flag144 = (nint)0 == 0;
													num5 = 0;
													num6 = 0;
													flag98 = false;
													num55 = 2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
													text14 = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
													obj121 = (UnityEngine.Object)0;
													obj71 = 712964571136L;
													gillaSplashLobby2 = this;
													num19 = num16;
													num18 = num56;
													num9 = 6;
													num7 = (float)num61;
													color = (Color32)0;
													obj9 = texture2D;
													gillaSplashLobby = this;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
													text = (string)0;
													text2 = (string)(object)texture2D;
													if (flag144)
													{
														break;
													}
													object obj173 = obj172;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3958 @ X8_v344+190]");
													obj9 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3958 @ X8_v344+188] (should have been resolved before IL gen)");
													MapEntry[] array12 = maps;
													bool flag145 = maps == null;
													num5 = 0;
													num6 = 0;
													flag98 = false;
													num55 = 2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
													text14 = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
													obj121 = (UnityEngine.Object)0;
													obj71 = 712964571136L;
													gillaSplashLobby2 = this;
													num19 = num16;
													num18 = num56;
													num9 = 6;
													num7 = (float)num61;
													color = (Color32)0;
													gillaSplashLobby = this;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
													text = (string)0;
													text2 = (string)(object)texture2D;
													if (flag145)
													{
														break;
													}
													bool flag146 = num56 < array12.Length;
													obj18 = !flag146;
													num24 = (float)num56 - (float)array12.Length;
													flag11 = num24 < 0f;
													flag12 = num24 == 0f;
													num23 = num56 ^ array12.Length;
													num21 = num56 ^ num24;
													num22 = num23 & num21;
													flag15 = num22 < 0;
													flag98 = false;
													num55 = 2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
													text14 = (string)0;
													num9 = 6;
													num7 = (float)num61;
													color = (Color32)0;
													if (obj18 == null)
													{
														object obj174 = maps + num56;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4021 @ X8_v346+20]");
														object obj175 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4021 @ X8_v346+20]");
														bool flag147 = (nint)0 == 0;
														num5 = 0;
														num6 = 0;
														flag98 = false;
														num55 = 2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
														text14 = (string)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
														obj121 = (UnityEngine.Object)0;
														obj71 = 712964571136L;
														gillaSplashLobby2 = this;
														num19 = num16;
														num18 = num56;
														num9 = 6;
														num7 = (float)num61;
														color = (Color32)0;
														gillaSplashLobby = this;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
														text = (string)0;
														text2 = (string)(object)texture2D;
														if (flag147)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v347+18]");
														object obj176 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v347+18]");
														bool flag148 = (nint)0 == 0;
														num5 = 0;
														num6 = 0;
														flag98 = false;
														num55 = 2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v287+10]");
														text14 = (string)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
														obj121 = (UnityEngine.Object)0;
														obj71 = 712964571136L;
														gillaSplashLobby2 = this;
														num19 = num16;
														num18 = num56;
														num9 = 6;
														num7 = (float)num61;
														color = (Color32)0;
														gillaSplashLobby = this;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
														text = (string)0;
														text2 = (string)(object)texture2D2;
														if (flag148)
														{
															break;
														}
														object obj177 = obj176;
														Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3825 @ X8_v348+1A8] (should have been resolved before IL gen)");
														GillaMapVote.Canvas canvas7 = canvas3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
														canvas7.Picture((Color32[])0, (int)texture2D2, num62, 8, 30, 2, (float)num61);
														flag98 = false;
														num55 = 2;
														array5 = (Color32[])30;
														text14 = (string)8;
														num9 = num62;
														num7 = (float)num61;
														color = (Color32)texture2D2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ X8_v340+20]");
														obj9 = (UnityEngine.Object)0;
														texture2D = texture2D2;
														goto IL_3bac;
													}
												}
											}
											goto IL_67d2;
										}
									}
									goto IL_3bac;
								}
							}
						}
						goto IL_67d2;
					}
				}
				object obj178 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X0_v17+E4]");
				bool flag149 = (nint)0 == 0;
				object obj179 = !flag149;
				if (obj179 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj178 = obj43;
				}
				bool value13 = ((bool*)(flag2 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X0_v17+A0]");
				object obj180 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X9_v5+28]");
				Color32[] array13 = (Color32[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v12 (System.Boolean)+E4]");
				bool flag150 = (nint)0 == 0;
				object obj181 = !flag150;
				if (obj181 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num63;
				if (obj121 != null)
				{
					bool flag151 = (object)obj121 == null;
					color = (Color32)0;
					obj9 = null;
					if (flag151)
					{
						break;
					}
					num63 = ((NetworkBootstrap)obj121).PlayerCount;
					UnityEngine.Object obj182 = null;
				}
				else
				{
					UnityEngine.Object obj182 = null;
					num63 = 0;
				}
				bool value14 = ((bool*)(flag2 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X8_v13 (System.Boolean)+E4]");
				bool flag152 = (nint)0 == 0;
				object obj183 = !flag152;
				if (obj183 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text20;
				string text17;
				Color32[] array14;
				string text18;
				string text25;
				object obj193;
				if ((UnityEngine.Object)game == (UnityEngine.Object)null)
				{
					bool value15 = ((bool*)(flag2 ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X0_v297 (System.Boolean)+E4]");
					bool flag153 = (nint)0 == 0;
					object obj184 = !flag153;
					if (obj184 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag154 = obj121 != null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
					object obj185 = 0;
					if (flag154)
					{
						bool flag155 = (object)obj121 == null;
						num5 = num63;
						color = (Color32)0;
						obj9 = null;
						if (flag155)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
						bool flag156 = (nint)0 < (nint)0;
						obj18 = !flag156;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
						flag11 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
						flag12 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
						nint num64 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
						num21 = (int)(num64 ^ 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
						num22 = (int)((nint)0 & (nint)num21);
						flag15 = num22 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
							num23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
							num24 = 0f;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
							num23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ stack_-188_v3 (UnityEngine.Object)+A4]");
							num24 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82D8]");
							obj185 = 0;
						}
					}
					object obj186 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8240]");
					object obj187 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X0_v302+E4]");
					bool flag157 = (nint)0 == 0;
					object obj188 = !flag157;
					if (obj188 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj186 = obj43;
					}
					bool value16 = ((bool*)(flag2 ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X0_v302+A0]");
					object obj189 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X8_v247 (System.Boolean)+E4]");
					bool flag158 = (nint)0 == 0;
					object obj190 = !flag158;
					if (obj190 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text19;
					if (obj121 != null)
					{
						bool flag159 = (object)obj121 == null;
						num5 = num63;
						text17 = (string)obj187;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X9_v62+38]");
						array14 = (Color32[])0;
						text18 = (string)obj185;
						color = (Color32)0;
						obj9 = null;
						if (flag159)
						{
							break;
						}
						text19 = ((NetworkBootstrap)obj121).OfflineWhy;
						obj9 = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj191 = 0;
						text19 = (string)obj191;
						obj9 = null;
					}
					bool flag160 = text19 == null;
					num5 = num63;
					text17 = (string)obj187;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X9_v62+38]");
					array14 = (Color32[])0;
					text18 = (string)obj185;
					color = (Color32)0;
					if (flag160)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8238]");
					object obj192 = 0;
					bool flag161 = text19._stringLength < 0;
					obj18 = !flag161;
					flag11 = text19._stringLength < 0;
					flag12 = text19._stringLength == 0;
					num21 = text19._stringLength ^ text19._stringLength;
					num22 = text19._stringLength & num21;
					flag15 = num22 < 0;
					bool flag162 = flag11 == flag15;
					obj193 = !flag12;
					text20 = (string)((((flag162 & obj193) ? 1 : 0) == 0) ? obj192 : text19);
					text17 = (string)obj187;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X9_v62+38]");
					array14 = (Color32[])0;
					text18 = (string)obj185;
					num23 = text19._stringLength;
					num24 = text19._stringLength;
					Color32 color5 = (Color32)0;
					string text21 = (string)(object)obj9;
				}
				else
				{
					bool flag163 = (object)game == null;
					num5 = num63;
					color = (Color32)0;
					obj9 = null;
					if (flag163)
					{
						break;
					}
					byte phase3 = game.Phase;
					Color32 color5;
					string text21;
					if ((phase3 & 0xFF) != 0)
					{
						byte phase4 = game.Phase;
						int num65 = phase4 & 0xFF;
						bool flag164 = num65 < 1;
						obj18 = !flag164;
						num24 = (float)num65 - 1f;
						flag11 = num24 < 0f;
						flag12 = num24 == 0f;
						num23 = num65 ^ 1;
						num21 = num65 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						if (num65 == 1)
						{
							int round2 = game.Round;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj194 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8288]");
							object format3 = 0;
							string text22 = string.Format((string)format3, arg, arg2);
							float phaseEnds2 = game.PhaseEnds;
							float now2 = game.Now;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj195 = 0;
							object obj196 = obj195;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X0_v262+E4]");
							bool flag165 = (nint)0 == 0;
							object obj197 = !flag165;
							if (obj197 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
							object obj198 = obj43;
							object obj199 = ~now2;
							int seconds = now2 & obj199;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1674 @ X0_v264+E4]");
							bool flag166 = (nint)0 == 0;
							object obj200 = !flag166;
							if (obj200 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text23 = Clock(seconds);
							object obj201 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ X8_v222+A0]");
							object obj202 = 0;
							int round3 = game.Round;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
							object obj203 = 0;
							object obj204 = obj203;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1872 @ X8_v227+E4]");
							bool flag167 = (nint)0 == 0;
							object obj205 = !flag167;
							if (obj205 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num7 = GillaSplashGame.RaceSeconds(round3);
							object obj206 = obj195;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1991 @ X0_v273+E4]");
							bool flag168 = (nint)0 == 0;
							object obj207 = !flag168;
							if (obj207 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
							string text24 = Clock((int)num7);
							bool flag169 = game.Dark;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8308]");
							object obj208 = 0;
							text2 = (string)obj208;
							object obj209;
							if (flag169)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82E0]");
								obj209 = 0;
							}
							else
							{
								NetworkBool sinking = game.Sinking;
								bool flag170 = sinking;
								flag11 = (flag170 ? 1 : 0) < (false ? 1 : 0);
								flag12 = !flag170;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								obj209 = 0;
								if (!flag12)
								{
									flag15 = false;
									obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82E8]");
									obj209 = 0;
								}
								else
								{
									flag15 = false;
									obj18 = 0;
								}
							}
							text25 = text2 + text24 + (string)obj209;
							text17 = text23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1817 @ X8_v223+30]");
							array14 = (Color32[])0;
							text18 = text22;
							num32 = 7;
							num9 = 0;
							num8 = round2;
							color5 = (Color32)obj209;
							text21 = text24;
							text = text24;
						}
						else
						{
							byte phase5 = game.Phase;
							int num66 = phase5 & 0xFF;
							bool flag171 = num66 < 2;
							obj18 = !flag171;
							num24 = (float)num66 - 2f;
							flag11 = num24 < 0f;
							flag12 = num24 == 0f;
							num23 = num66 ^ 2;
							num21 = num66 ^ num24;
							num22 = num23 & num21;
							flag15 = num22 < 0;
							if (num66 != 2)
							{
								byte phase6 = game.Phase;
								int num67 = phase6 & 0xFF;
								num24 = (float)num67 - 3f;
								num23 = num67 ^ 3;
								num21 = num67 ^ num24;
								num22 = num23 & num21;
								if (num67 == 3)
								{
									int round4 = game.Round;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj210 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82A8]");
									object format4 = 0;
									string text26 = string.Format((string)format4, obj211);
									float phaseEnds3 = game.PhaseEnds;
									float now3 = game.Now;
									num7 = phaseEnds3 - now3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E10774");
									object obj212 = obj43;
									object obj213 = ~obj214;
									int num68 = obj214 & obj213;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1830 @ X0_v207+E4]");
									bool flag172 = (nint)0 == 0;
									object obj215 = !flag172;
									if (obj215 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									string text27 = Clock(num68);
									object obj216 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1905 @ X8_v177+A0]");
									object obj217 = 0;
									bool flag173 = num19 < 0;
									obj18 = !flag173;
									flag11 = num19 < 0;
									flag12 = num19 == 0;
									num21 = num19 ^ num19;
									num22 = num19 & num21;
									flag15 = num22 < 0;
									if (num19 > 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8230]");
										object format5 = 0;
										text25 = string.Format((string)format5, obj218);
										text17 = text27;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X8_v178+28]");
										array14 = (Color32[])0;
										text18 = text26;
										num23 = num19;
										num24 = num19;
										num8 = num19;
										color5 = (Color32)0;
										text21 = (string)obj218;
										text = (string)num68;
										goto IL_535c;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8268]");
									object obj219 = 0;
									text20 = (string)obj219;
									text17 = text27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X8_v178+28]");
									array14 = (Color32[])0;
									text18 = text26;
									num23 = num19;
									num24 = num19;
									num8 = round4;
									color5 = (Color32)0;
									text21 = (string)obj211;
									text = (string)num68;
								}
								else
								{
									bool tied2 = game.Tied;
									flag11 = (tied2 ? 1 : 0) < (false ? 1 : 0);
									flag12 = !tied2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8218]");
									object obj220 = 0;
									if (flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82B0]");
										obj220 = 0;
									}
									string text28 = ((GillaSplashLobby)tied2).Winners(game);
									string text29 = (string)obj220 + text28;
									object obj221 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1836 @ X8_v164+E4]");
									bool flag174 = (nint)0 == 0;
									object obj222 = !flag174;
									if (obj222 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj221 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1836 @ X8_v164+A0]");
									object obj223 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1838 @ X8_v165+30]");
									array13 = (Color32[])0;
									float phaseEnds4 = game.PhaseEnds;
									float now4 = game.Now;
									num7 = phaseEnds4 - now4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E10774");
									object obj224 = ~obj225;
									int seconds2 = obj225 & obj224;
									string text30 = Clock(seconds2);
									object obj226 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ X8_v166+A0]");
									object obj227 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81C8]");
									object obj228 = 0;
									text20 = (string)obj228;
									text17 = text30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2014 @ X8_v167+30]");
									array14 = (Color32[])0;
									text18 = text29;
									flag15 = false;
									obj18 = 0;
									color5 = (Color32)0;
									text21 = text28;
								}
								goto IL_7c0c;
							}
							int round5 = game.Round;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj229 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81D0]");
							object format6 = 0;
							string text31 = string.Format((string)format6, arg3, arg4);
							object obj230;
							if (game.Dark)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8208]");
								obj230 = 0;
							}
							else
							{
								NetworkBool sinking2 = game.Sinking;
								bool flag175 = sinking2;
								flag11 = (flag175 ? 1 : 0) < (false ? 1 : 0);
								flag12 = !flag175;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								obj230 = 0;
								if (!flag12)
								{
									flag15 = false;
									obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8300]");
									obj230 = 0;
								}
								else
								{
									flag15 = false;
									obj18 = 0;
								}
							}
							string text32 = text31 + (string)obj230;
							float phaseEnds5 = game.PhaseEnds;
							num7 = game.Now;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj231 = 0;
							object obj232 = obj231;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1965 @ X0_v231+E4]");
							bool flag176 = (nint)0 == 0;
							object obj233 = !flag176;
							if (obj233 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
							object obj234 = obj43;
							object obj235 = ~num7;
							int seconds3 = num7 & obj235;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1997 @ X0_v233+E4]");
							bool flag177 = (nint)0 == 0;
							object obj236 = !flag177;
							if (obj236 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text33 = Clock(seconds3);
							object obj237 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2066 @ X8_v198+A0]");
							object obj238 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8320]");
							object format7 = 0;
							text25 = string.Format((string)format7, text34, obj239);
							text17 = text33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2068 @ X8_v199+20]");
							array14 = (Color32[])0;
							text18 = text32;
							num32 = num14;
							num9 = 0;
							num8 = num19;
							color5 = (Color32)obj239;
							text21 = text34;
							text = text34;
						}
						goto IL_535c;
					}
					float voteEnds2 = game.VoteEnds;
					bool flag178 = voteEnds2 < 0f;
					bool flag179 = voteEnds2 == 0f;
					object obj240 = voteEnds2 ^ voteEnds2;
					object obj241 = voteEnds2 & obj240;
					bool flag180 = (nint)obj241 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8280]");
					object obj242 = 0;
					bool flag181 = flag178 == flag180;
					object obj243 = !flag181;
					object obj244 = obj243 | flag179;
					if ((int)(~obj244) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81E8]");
						obj242 = 0;
					}
					float num69;
					int num70;
					if (!(voteEnds2 > 0f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
						object obj245 = 0;
						object obj246 = obj245;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1378 @ X0_v172+E4]");
						bool flag182 = (nint)0 == 0;
						object obj247 = !flag182;
						if (obj247 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj246 = obj245;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1378 @ X0_v172+A0]");
						object obj248 = 0;
						num7 = (float)obj248;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E10774");
						num69 = (float)num53;
						num70 = num71;
					}
					else
					{
						float voteEnds3 = game.VoteEnds;
						num7 = game.Now;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj249 = 0;
						object obj250 = obj249;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ X0_v165+E4]");
						bool flag183 = (nint)0 == 0;
						object obj251 = !flag183;
						if (obj251 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						object obj252 = ~num7;
						num70 = num7 & obj252;
						num69 = num7;
					}
					object obj253 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X0_v150+E4]");
					bool flag184 = (nint)0 == 0;
					object obj254 = !flag184;
					if (obj254 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text35 = Clock(num70);
					object obj255 = obj43;
					bool flag185 = voteEnds2 < 0f;
					obj18 = !flag185;
					flag11 = voteEnds2 < 0f;
					flag12 = voteEnds2 == 0f;
					num21 = voteEnds2 ^ voteEnds2;
					num22 = voteEnds2 & num21;
					flag15 = num22 < 0;
					obj193 = !flag12;
					object obj257;
					if (!(voteEnds2 > 0f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1752 @ X8_v137+E4]");
						bool flag186 = (nint)0 == 0;
						object obj256 = !flag186;
						if (obj256 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj255 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1752 @ X8_v137+A0]");
						obj257 = (nint)0 + (nint)56;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1752 @ X8_v137+E4]");
						bool flag187 = (nint)0 == 0;
						object obj258 = !flag187;
						if (obj258 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj255 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1752 @ X8_v137+A0]");
						obj257 = (nint)0 + (nint)40;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8260]");
					object obj259 = 0;
					text20 = (string)obj259;
					text17 = text35;
					array14 = (Color32[])obj257;
					text18 = (string)obj242;
					num53 = num69;
					num23 = (int)voteEnds2;
					num24 = voteEnds2;
					color5 = (Color32)0;
					text21 = null;
					text = (string)num70;
				}
				goto IL_7c0c;
				IL_53a3:
				string text36 = num5.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81D8]");
				object obj260 = 0;
				string text37 = (string)obj260 + text36;
				string text38 = text37;
				goto IL_775a;
				IL_4148:
				array3 = gillaSplashLobby3.panelCanvas;
				num18 = num56 + 1;
				bool flag188 = gillaSplashLobby3.panelCanvas == null;
				obj261 = !flag188;
				num5 = 0;
				num6 = 0;
				flag98 = flag97;
				num55 = num54;
				array5 = array4;
				text14 = text13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
				obj121 = (UnityEngine.Object)0;
				obj71 = 712964571136L;
				gillaSplashLobby2 = this;
				flag2 = flag99;
				num19 = num16;
				flag14 = flag100;
				num9 = num57;
				num7 = num58;
				color = color4;
				obj9 = obj124;
				gillaSplashLobby = gillaSplashLobby3;
				text = text15;
				text2 = text16;
				num56 = num18;
				canvas2 = canvas3;
				continue;
				IL_40e8:
				canvas3.Show();
				flag97 = flag98;
				num54 = num55;
				array4 = array5;
				text13 = text14;
				flag99 = flag2;
				flag100 = flag14;
				num57 = num9;
				num58 = num7;
				color4 = color;
				obj124 = null;
				gillaSplashLobby3 = this;
				goto IL_4148;
				IL_7c0c:
				bool value17 = ((bool*)(flag2 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ X0_v26 (System.Boolean)+E4]");
				bool flag189 = (nint)0 == 0;
				object obj262 = !flag189;
				if (obj262 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)game == (UnityEngine.Object)null)
				{
					goto IL_53a3;
				}
				object obj263 = obj27 & 0xFF;
				object obj264 = obj263 - 2;
				bool flag190 = obj264 == null;
				obj193 = !flag190;
				object obj265;
				if ((nint)obj263 <= 2)
				{
					bool flag191 = (nint)obj263 < 1;
					obj18 = !flag191;
					num24 = (float)obj263 - 1f;
					flag11 = num24 < 0f;
					flag12 = (nint)obj263 == 1;
					num23 = obj263 ^ 1;
					num21 = obj263 ^ num24;
					num22 = num23 & num21;
					flag15 = num22 < 0;
					if (!flag12)
					{
						bool flag192 = (nint)obj263 < 2;
						obj18 = !flag192;
						num24 = (float)obj263 - 2f;
						flag11 = num24 < 0f;
						flag12 = num24 == 0f;
						num23 = obj263 ^ 2;
						num21 = obj263 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						if ((nint)obj263 != 2)
						{
							goto IL_53a3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8290]");
						obj265 = 0;
					}
					else
					{
						bool flag193 = (object)game == null;
						num5 = num63;
						color = (Color32)0;
						obj9 = null;
						if (flag193)
						{
							break;
						}
						byte phase7 = game.Phase;
						int num72 = phase7 & 0xFF;
						bool flag194 = num72 < 4;
						obj18 = !flag194;
						num24 = (float)num72 - 4f;
						flag11 = num24 < 0f;
						flag12 = num72 == 4;
						num23 = num72 ^ 4;
						num21 = num72 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						if (flag12)
						{
							goto IL_53a3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82A0]");
						obj265 = 0;
					}
				}
				else
				{
					bool flag195 = (nint)obj263 < 3;
					obj18 = !flag195;
					num24 = (float)obj263 - 3f;
					flag11 = num24 < 0f;
					flag12 = (nint)obj263 == 3;
					num23 = obj263 ^ 3;
					num21 = obj263 ^ num24;
					num22 = num23 & num21;
					flag15 = num22 < 0;
					if (!flag12)
					{
						bool flag196 = (nint)obj263 < 4;
						obj18 = !flag196;
						num24 = (float)obj263 - 4f;
						flag11 = num24 < 0f;
						flag12 = num24 == 0f;
						num23 = obj263 ^ 4;
						num21 = obj263 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						if ((nint)obj263 != 4)
						{
							goto IL_53a3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82B8]");
						obj265 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8270]");
						obj265 = 0;
					}
				}
				text38 = (string)obj265;
				goto IL_775a;
				IL_775a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8310]");
				object head = 0;
				gillaSplashLobby.Board(gillaSplashLobby.boardCanvas, (string)head, text18, array13, text17, array14, text20, text38);
				bool value18 = ((bool*)(flag2 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1981 @ X0_v32 (System.Boolean)+E4]");
				bool flag197 = (nint)0 == 0;
				object obj266 = !flag197;
				if (obj266 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num73;
				if ((UnityEngine.Object)game != (UnityEngine.Object)null)
				{
					bool flag198 = (object)game == null;
					num5 = num63;
					flag98 = (byte)(int)text20 != 0;
					num55 = (int)array14;
					array5 = (Color32[])(object)text17;
					text14 = (string)(object)array13;
					num9 = (int)text18;
					color = (Color32)0;
					obj9 = null;
					if (flag198)
					{
						break;
					}
					num73 = game.Level;
				}
				else
				{
					num73 = 0;
				}
				GillaMapVote.Canvas[] array15 = gillaSplashLobby.roomCanvas;
				bool flag199 = gillaSplashLobby.roomCanvas == null;
				num5 = num63;
				flag98 = (byte)(int)text20 != 0;
				num55 = (int)array14;
				array5 = (Color32[])(object)text17;
				text14 = (string)(object)array13;
				num9 = (int)text18;
				color = (Color32)0;
				obj9 = null;
				if (flag199)
				{
					break;
				}
				object obj267 = num73 + 1;
				flag98 = (byte)(int)text20 != 0;
				num55 = (int)array14;
				array5 = (Color32[])(object)text17;
				text14 = (string)(object)array13;
				obj71 = 0;
				string text39 = text20;
				string foot = text38;
				num9 = (int)text18;
				color = (Color32)0;
				obj9 = null;
				while (true)
				{
					if ((nint)obj71 >= array15.Length)
					{
						return;
					}
					bool flag200 = (nint)obj71 < array15.Length;
					obj18 = !flag200;
					num24 = (float)obj71 - (float)array15.Length;
					flag11 = num24 < 0f;
					flag12 = num24 == 0f;
					num23 = obj71 ^ array15.Length;
					num21 = obj71 ^ num24;
					num22 = num23 & num21;
					flag15 = num22 < 0;
					if (obj18 != null)
					{
						break;
					}
					object obj268 = (object)array15 + obj71;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
					if ((nint)0 == 0)
					{
						goto IL_6395;
					}
					bool value19 = ((bool*)(flag2 ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2841 @ X0_v39 (System.Boolean)+E4]");
					bool flag201 = (nint)0 == 0;
					object obj269 = !flag201;
					if (obj269 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Color32[] array16;
					string text42;
					Color32[] array17;
					string text43;
					string text44;
					GillaMapVote.Canvas canvas8;
					GillaSplashLobby gillaSplashLobby4;
					if ((UnityEngine.Object)game != (UnityEngine.Object)null)
					{
						bool flag202 = num73 < (nint)obj71;
						obj18 = !flag202;
						num24 = (float)num73 - (float)obj71;
						flag11 = num24 < 0f;
						flag12 = num24 == 0f;
						num23 = num73 ^ obj71;
						num21 = num73 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						if (num73 == (nint)obj71)
						{
							bool flag203 = (object)game == null;
							num5 = num63;
							obj121 = (UnityEngine.Object)(object)text20;
							num53 = -2.5;
							color = (Color32)0;
							obj9 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
							text = (string)0;
							if (flag203)
							{
								goto end_IL_7211;
							}
							byte phase8 = game.Phase;
							int num74 = phase8 & 0xFF;
							if (num74 == 1)
							{
								float phaseEnds6 = game.PhaseEnds;
								float now5 = game.Now;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								object obj270 = 0;
								object obj271 = obj270;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3167 @ X0_v114+E4]");
								bool flag204 = (nint)0 == 0;
								object obj272 = !flag204;
								if (obj272 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								num7 = phaseEnds6 - now5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
								object obj273 = ~num7;
								int num75 = num7 & obj273;
								int round6 = game.Round;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj274 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81F8]");
								object format8 = 0;
								string text40 = string.Format((string)format8, arg5);
								object obj275 = obj43;
								bool flag205 = num75 < 4;
								obj18 = !flag205;
								num24 = (float)num75 - 4f;
								flag11 = num24 < 0f;
								flag12 = num24 == 0f;
								num23 = num75 ^ 4;
								num21 = num75 ^ num24;
								num22 = num23 & num21;
								flag15 = num22 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8250]");
								object obj276 = 0;
								if (flag11 == flag15)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F0]");
									obj276 = 0;
								}
								text2 = (string)obj276;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3396 @ X8_v106+E4]");
								bool flag206 = (nint)0 == 0;
								object obj277 = !flag206;
								if (obj277 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj275 = obj43;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3396 @ X8_v106+A0]");
								object obj278 = 0;
								string text41 = num6.ToString();
								object obj279 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3418 @ X8_v108+A0]");
								object obj280 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3311 @ X8_v109+30]");
								array16 = (Color32[])0;
								text42 = text41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3398 @ X8_v107+28]");
								array17 = (Color32[])0;
								text39 = text20;
								foot = text38;
								text43 = text2;
								num8 = round6;
								text44 = text40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
								canvas8 = (GillaMapVote.Canvas)0;
								gillaSplashLobby4 = gillaSplashLobby;
								goto IL_78d0;
							}
						}
					}
					bool value20 = ((bool*)(flag2 ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2977 @ X0_v45 (System.Boolean)+E4]");
					bool flag207 = (nint)0 == 0;
					object obj281 = !flag207;
					if (obj281 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)game != (UnityEngine.Object)null)
					{
						bool flag208 = num73 < (nint)obj71;
						obj18 = !flag208;
						num24 = (float)num73 - (float)obj71;
						flag11 = num24 < 0f;
						flag12 = num24 == 0f;
						num23 = num73 ^ obj71;
						num21 = num73 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						if (num73 == (nint)obj71)
						{
							bool flag209 = (object)game == null;
							num5 = num63;
							obj121 = (UnityEngine.Object)(object)text20;
							num53 = -2.5;
							color = (Color32)0;
							obj9 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
							text = (string)0;
							if (flag209)
							{
								goto end_IL_7211;
							}
							byte phase9 = game.Phase;
							int num76 = phase9 & 0xFF;
							if (num76 == 2)
							{
								float phaseEnds7 = game.PhaseEnds;
								float now6 = game.Now;
								int round7 = game.Round;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
								object obj282 = 0;
								object obj283 = obj282;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3052 @ X8_v75+E4]");
								bool flag210 = (nint)0 == 0;
								object obj284 = !flag210;
								if (obj284 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num77 = GillaSplashGame.RaceSeconds(round7);
								float num10 = phaseEnds7 - now6;
								num7 = num77 + -2.5f;
								bool flag211 = num10 < num7;
								obj18 = !flag211;
								num24 = num10 - num7;
								flag11 = num24 < 0f;
								flag12 = num24 == 0f;
								num23 = num10 ^ num7;
								num21 = num10 ^ num24;
								num22 = num23 & num21;
								flag15 = num22 < 0;
								flag13 = !(num10 > num7);
								text2 = (string)round7;
								if (!flag13)
								{
									int round8 = game.Round;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj285 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81F8]");
									object format9 = 0;
									string text45 = string.Format((string)format9, arg6);
									object obj286 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3457 @ X8_v83+E4]");
									bool flag212 = (nint)0 == 0;
									object obj287 = !flag212;
									if (obj287 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj286 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3457 @ X8_v83+A0]");
									object obj288 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3459 @ X8_v84+30]");
									array17 = (Color32[])0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8318]");
									object obj289 = 0;
									text43 = (string)obj289;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8220]");
									object obj290 = 0;
									text42 = (string)obj290;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3459 @ X8_v84+30]");
									array16 = (Color32[])0;
									num8 = round8;
									text44 = text45;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
									canvas8 = (GillaMapVote.Canvas)0;
									gillaSplashLobby4 = gillaSplashLobby;
									text2 = text45;
									goto IL_78d0;
								}
							}
						}
					}
					bool value21 = ((bool*)(flag2 ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3054 @ X0_v50 (System.Boolean)+E4]");
					bool flag213 = (nint)0 == 0;
					object obj291 = !flag213;
					if (obj291 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)game != (UnityEngine.Object)null)
					{
						bool flag214 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj267) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71);
						obj18 = !flag214;
						num24 = (float)obj267 - (float)obj71;
						flag11 = num24 < 0f;
						flag12 = num24 == 0f;
						num23 = obj267 ^ obj71;
						num21 = obj267 ^ num24;
						num22 = num23 & num21;
						flag15 = num22 < 0;
						if (obj267 == obj71)
						{
							bool flag215 = (object)game == null;
							num5 = num63;
							obj121 = (UnityEngine.Object)(object)text20;
							num53 = -2.5;
							color = (Color32)0;
							obj9 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
							text = (string)0;
							if (flag215)
							{
								goto end_IL_7211;
							}
							byte phase10 = game.Phase;
							int num78 = phase10 & 0xFF;
							if (num78 == 2)
							{
								object obj292 = obj43;
								object obj293 = obj27 & 0xFF;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81C0]");
								object obj294 = 0;
								bool flag216 = (nint)obj293 < 2;
								obj18 = !flag216;
								num24 = (float)obj293 - 2f;
								flag11 = num24 < 0f;
								flag12 = num24 == 0f;
								num23 = obj293 ^ 2;
								num21 = obj293 ^ num24;
								num22 = num23 & num21;
								flag15 = num22 < 0;
								object obj297;
								string text46;
								if ((nint)obj293 == 2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8290]");
									object obj295 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3364 @ X0_v81+E4]");
									bool flag217 = (nint)0 == 0;
									object obj296 = !flag217;
									if (obj296 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj292 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3364 @ X0_v81+A0]");
									obj297 = (nint)0 + (nint)48;
									text46 = (string)obj295;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81E0]");
									object obj298 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3364 @ X0_v81+E4]");
									bool flag218 = (nint)0 == 0;
									object obj299 = !flag218;
									if (obj299 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj292 = obj43;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3364 @ X0_v81+A0]");
									obj297 = (nint)0 + (nint)40;
									text46 = (string)obj298;
								}
								float phaseEnds8 = game.PhaseEnds;
								float now7 = game.Now;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								object obj300 = 0;
								object obj301 = obj300;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3447 @ X0_v63+E4]");
								bool flag219 = (nint)0 == 0;
								object obj302 = !flag219;
								if (obj302 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj303 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3465 @ X0_v65+E4]");
								bool flag220 = (nint)0 == 0;
								object obj304 = !flag220;
								if (obj304 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								num7 = phaseEnds8 - now7;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
								object obj305 = ~num7;
								int seconds4 = num7 & obj305;
								string text47 = Clock(seconds4);
								object obj306 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3500 @ X8_v57+A0]");
								object obj307 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj308 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8298]");
								object format10 = 0;
								string text48 = string.Format((string)format10, arg7, arg8);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8248]");
								object foot2 = 0;
								GillaSplashLobby gillaSplashLobby5 = gillaSplashLobby2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
								nint num79 = 0;
								string what = text46;
								object whatColours = obj297;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3504 @ X8_v58+20]");
								gillaSplashLobby5.Board((GillaMapVote.Canvas)num79, (string)obj294, what, (Color32[])whatColours, text47, (Color32[])0, text48, (string)foot2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								flag2 = false;
								flag98 = (byte)(int)text48 != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3504 @ X8_v58+20]");
								num55 = 0;
								array5 = (Color32[])(object)text47;
								text14 = (string)obj297;
								num32 = num14;
								text39 = text20;
								foot = text38;
								num9 = (int)text46;
								num8 = num19;
								color = (Color32)obj294;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
								obj9 = (UnityEngine.Object)0;
								gillaSplashLobby = gillaSplashLobby2;
								text2 = (string)(object)array13;
								goto IL_6395;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8310]");
					object obj309 = 0;
					if (obj267 == obj71)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81C0]");
						obj309 = 0;
					}
					bool flag221 = num73 < (nint)obj71;
					obj18 = !flag221;
					num24 = (float)num73 - (float)obj71;
					flag11 = num24 < 0f;
					flag12 = num24 == 0f;
					num23 = num73 ^ obj71;
					num21 = num73 ^ num24;
					num22 = num23 & num21;
					flag15 = num22 < 0;
					if (num73 == (nint)obj71)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8278]");
						obj309 = 0;
					}
					text44 = (string)obj309;
					array16 = array14;
					text42 = text17;
					array17 = array13;
					text43 = text18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
					canvas8 = (GillaMapVote.Canvas)0;
					gillaSplashLobby4 = gillaSplashLobby;
					goto IL_78d0;
					IL_6395:
					array15 = gillaSplashLobby.roomCanvas;
					obj71++;
					bool flag222 = gillaSplashLobby.roomCanvas == null;
					object obj310 = !flag222;
					if (obj310 == null)
					{
						num5 = num63;
						obj121 = (UnityEngine.Object)(object)text20;
						num53 = -2.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v22+20]");
						text = (string)0;
						goto end_IL_7211;
					}
					continue;
					IL_78d0:
					gillaSplashLobby4.Board(canvas8, text44, text43, array17, text42, array16, text39, foot);
					flag98 = (byte)(int)text39 != 0;
					num55 = (int)array16;
					array5 = (Color32[])(object)text42;
					text14 = (string)(object)array17;
					num9 = (int)text43;
					color = (Color32)text44;
					obj9 = (UnityEngine.Object)(object)canvas8;
					goto IL_6395;
				}
				goto IL_67d2;
				IL_535c:
				text20 = text25;
				goto IL_7c0c;
				IL_3bac:
				bool flag231;
				Color32[] array18;
				int num88;
				ScreenFont font2;
				GillaMapVote.Canvas canvas9;
				if (flag109)
				{
					bool flag223 = (object)game == null;
					num5 = 0;
					num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
					obj121 = (UnityEngine.Object)0;
					obj71 = 712964571136L;
					gillaSplashLobby2 = this;
					num19 = num16;
					num18 = num56;
					gillaSplashLobby = this;
					text = (string)(object)renderer;
					text2 = (string)(object)texture2D;
					if (flag223)
					{
						break;
					}
					int num80 = game.VotesFor(num56);
					string text49 = num81.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8210]");
					object obj311 = 0;
					if (num81 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8258]");
						obj311 = 0;
					}
					string text50 = (string)obj311;
					string text51 = text49 + (string)obj311;
					int num83;
					if (this.text != null)
					{
						int num82 = this.text.Measure(text51, 1);
						num83 = num82;
						num9 = 0;
						int num84 = 1;
						text50 = text51;
					}
					else
					{
						num83 = 40;
						int num84 = 0;
					}
					object obj312 = obj43;
					object colours;
					if (num81 > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4036 @ X0_v434+E4]");
						bool flag224 = (nint)0 == 0;
						object obj313 = !flag224;
						if (obj313 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj312 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4036 @ X0_v434+A0]");
						colours = (nint)0 + (nint)40;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4036 @ X0_v434+E4]");
						bool flag225 = (nint)0 == 0;
						object obj314 = !flag225;
						if (obj314 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj312 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4036 @ X0_v434+A0]");
						colours = (nint)0 + (nint)56;
					}
					int num85 = 246 - num83;
					canvas3.Text(this.text, num85, 10, text51, (Color32[])colours, 1, centred: false);
					bool flag226 = num81 < 1;
					string text52 = text51;
					int num86 = 10;
					Color32 color6 = (Color32)num85;
					RectInt rectInt = (RectInt)this.text;
					num25 = (flag109 ? 1 : 0);
					if (!flag226)
					{
						string text53 = text51;
						int num87 = 10;
						ScreenFont screenFont = this.text;
						object obj315 = 12;
						bool flag228;
						do
						{
							object obj316 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4146 @ X0_v430+E4]");
							bool flag227 = (nint)0 == 0;
							object obj317 = !flag227;
							if (obj317 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj316 = obj43;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4146 @ X0_v430+A0]");
							object obj318 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4148 @ X8_v330+10]");
							num86 = 0;
							object obj319 = obj315 & 0xFFFFFFFEL;
							rectInt = (RectInt)(obj319 | 0xA600000000L);
							canvas3.Fill(rectInt, (Color32)30064771079L);
							num25 = 0 + 1;
							obj315 += 10;
							flag228 = num25 < num81;
							text52 = null;
							color6 = (Color32)30064771079L;
							text53 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4148 @ X8_v330+10]");
							num87 = 0;
							num85 = 7;
							screenFont = (ScreenFont)rectInt;
						}
						while (flag228);
					}
					object obj320 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82C0]");
					object obj321 = 0;
					bool flag229 = (flag2 ? 1 : 0) < (false ? 1 : 0);
					obj18 = !flag229;
					flag11 = (flag2 ? 1 : 0) < (false ? 1 : 0);
					flag12 = !flag2;
					num21 = ((flag2 ^ flag2) ? 1 : 0);
					num22 = (flag2 ? 1 : 0) & num21;
					flag15 = num22 < 0;
					text16 = (string)(object)this.text;
					flag13 = !flag12;
					flag14 = !flag13;
					if (flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8228]");
						obj321 = 0;
					}
					text15 = (string)obj321;
					object obj323;
					if (flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4173 @ X0_v422+E4]");
						bool flag230 = (nint)0 == 0;
						object obj322 = !flag230;
						if (obj322 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj320 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						flag231 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4173 @ X0_v422+A0]");
						obj323 = (nint)0 + (nint)48;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4173 @ X0_v422+E4]");
						bool flag232 = (nint)0 == 0;
						object obj324 = !flag232;
						if (obj324 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj320 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						flag231 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4173 @ X0_v422+A0]");
						obj323 = (nint)0 + (nint)40;
					}
					array18 = (Color32[])obj323;
					text14 = text15;
					obj123 = (UnityEngine.Object)num83;
					num23 = (flag2 ? 1 : 0);
					num24 = (flag2 ? 1 : 0);
					num9 = 186;
					num88 = 128;
					font2 = (ScreenFont)(object)text16;
					canvas9 = canvas3;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					flag2 = false;
					bool flag233 = (object)obj123 == null;
					num25 = (flag109 ? 1 : 0);
					text15 = (string)(object)renderer;
					text16 = (string)(object)texture2D;
					if (flag233)
					{
						goto IL_40e8;
					}
					bool flag234 = (object)game == null;
					num5 = 0;
					num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v1+8]");
					obj121 = (UnityEngine.Object)0;
					obj71 = 712964571136L;
					gillaSplashLobby2 = this;
					num19 = num16;
					num18 = num56;
					gillaSplashLobby = this;
					text = (string)(object)renderer;
					text2 = (string)(object)texture2D;
					if (flag234)
					{
						break;
					}
					text15 = (string)(object)this.text;
					byte phase11 = game.Phase;
					object obj325 = obj43;
					int num89 = phase11 & 0xFF;
					bool flag235 = num89 < 4;
					obj18 = !flag235;
					num24 = (float)num89 - 4f;
					flag11 = num24 < 0f;
					flag12 = num24 == 0f;
					num23 = num89 ^ 4;
					num21 = num89 ^ num24;
					num22 = num23 & num21;
					flag15 = num22 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81F0]");
					object obj326 = 0;
					flag14 = num89 != 4;
					if (flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82C8]");
						obj326 = 0;
					}
					text16 = (string)obj326;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3945 @ X0_v405+E4]");
					bool flag236 = (nint)0 == 0;
					object obj327 = !flag236;
					if (obj327 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj325 = obj43;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3945 @ X0_v405+A0]");
					object obj328 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3947 @ X8_v305+20]");
					array18 = (Color32[])0;
					text14 = text16;
					flag231 = flag2;
					num9 = 186;
					num88 = 128;
					font2 = (ScreenFont)(object)text15;
					canvas9 = canvas3;
					num25 = (flag109 ? 1 : 0);
				}
				canvas9.Text(font2, num88, num9, text14, array18, 2, centred: true);
				flag98 = true;
				num55 = 2;
				array5 = array18;
				flag2 = flag231;
				color = (Color32)num88;
				goto IL_40e8;
				continue;
				end_IL_7211:
				break;
			}
			while (obj261 != null);
		}
		goto IL_4245;
		IL_67d2:
		ex = new IndexOutOfRangeException();
		obj45 = obj9;
		goto IL_67e8;
	}

	private void Board(GillaMapVote.Canvas b, string head, string what, Color32[] whatColours, string clock, Color32[] clockColours, string small, string foot)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I
		//IL_0335: Expected VT, but got I
		//IL_0335: Expected VT, but got I
		//IL_034d: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I
		//IL_0374: Expected VT, but got I8
		//IL_0374: Expected VT, but got I4
		//IL_037d: Expected Obj, but got I4
		//IL_0386: Expected VT, but got I4
		//IL_0393: Expected VT, but got I8
		//IL_039c: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected VT, but got Unknown
		//IL_03d3: Expected Obj, but got I
		//IL_03e9: Expected VT, but got I8
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0411: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I4
		//IL_0430: Expected VT, but got I8
		//IL_00a5: Expected Obj, but got I4
		//IL_0486: Expected Obj, but got I
		//IL_04b9: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_0545: Expected Obj, but got I
		if (b == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+C]");
		b.Clear((Color32)num, (Color32)0);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v5+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v6+14]");
		object obj7 = 0;
		b.Outline((RectInt)0, (Color32)549755814400L);
		object obj8 = 0;
		RectInt rectInt = (RectInt)0;
		Color32 color = (Color32)549755814400L;
		object obj9 = -6;
		object obj14;
		do
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v8+A0]");
			object obj12 = 0;
			rectInt = (RectInt)(obj9 + 8589934606L);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v9+10]");
			obj7 = 0;
			b.Fill(rectInt, (Color32)8589934600L);
			obj9 += 14;
			bool flag3 = (nint)obj9 < 490;
			object obj13 = !flag3;
			obj14 = ~obj13;
			obj8 = 0;
			color = (Color32)8589934600L;
		}
		while (obj14 != null);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v11+A0]");
		object obj17 = 0;
		ScreenFont font = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v11+20]");
		b.Text(font, 256, 8, head, (Color32[])0, 2, centred: true);
		b.Text(this.text, 256, 28, what, whatColours, 2, centred: true);
		b.Text(this.text, 256, 46, clock, clockColours, 6, centred: true);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v12+A0]");
		object obj19 = 0;
		ScreenFont font2 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+20]");
		b.Text(font2, 256, 96, small, (Color32[])0, 1, centred: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83F0]");
		object obj20 = 0;
		string text = (string)obj20;
		bool flag5 = foot.StartsWith((string)obj20);
		bool flag6 = !flag5;
		object obj21 = !flag6;
		object obj22 = 0;
		object colours;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83F8]");
			object obj23 = 0;
			text = (string)obj23;
			bool flag7 = foot.StartsWith((string)obj23);
			bool flag8 = !flag7;
			obj22 = 0;
			if (flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83E8]");
				object value = 0;
				bool flag9 = foot.StartsWith((string)value);
				object obj24 = obj;
				if (flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v32+E4]");
					bool flag10 = (nint)0 == 0;
					object obj25 = !flag10;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v32+A0]");
					colours = (nint)0 + (nint)48;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v32+E4]");
					bool flag11 = (nint)0 == 0;
					object obj26 = !flag11;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v32+A0]");
					colours = (nint)0 + (nint)56;
				}
				goto IL_0565;
			}
		}
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v24+E4]");
		bool flag12 = (nint)0 == 0;
		object obj28 = !flag12;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v24+A0]");
		colours = (nint)0 + (nint)40;
		goto IL_0565;
		IL_0565:
		b.Text(this.text, 256, 110, foot, (Color32[])colours, 1, centred: true);
		b.Show();
	}

	private static string Clock(int seconds)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
		object obj2 = 0;
		int num = default;
		string text = num.ToString();
		string text2 = num.ToString((string)obj);
		return text + (string)obj2 + text2;
	}

	public GillaSplashLobby()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8400]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6188]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8408]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5048]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8410]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8418]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8420]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj17 = this + 72;
		object obj18 = default;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj19 = this + 88;
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj21 = this + 96;
		object obj22 = default;
		obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj23 = this + 104;
		object obj24 = default;
		obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj25 = this + 200;
		object obj26 = default;
		obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj27 = this + 208;
		object obj28 = default;
		obj27 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj29 = this + 216;
		object obj30 = default;
		obj29 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		seenPhase = 255;
		seenStarts = -1;
		base._002Ector();
	}

	static GillaSplashLobby()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+A0]");
		object obj5 = 0;
		_ = 4278584838L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+A0]");
		object obj6 = 0;
		_ = 4279045389L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v4+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+A0]");
		object obj10 = 0;
		_ = 4284506208L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+A0]");
		object obj11 = 0;
		_ = 4280821800L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+A0]");
		object obj12 = 0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+A0]");
		object obj14 = (nint)0 + (nint)32;
		obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = obj2;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v10+A0]");
		object obj18 = (nint)0 + (nint)40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = obj2;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X9_v11+A0]");
		object obj22 = (nint)0 + (nint)48;
		obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj23 = obj2;
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v12+A0]");
		object obj26 = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10+10]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
