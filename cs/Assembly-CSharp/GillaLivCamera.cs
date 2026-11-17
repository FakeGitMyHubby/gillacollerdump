using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Liv.Lck;
using Liv.Lck.DependencyInjection;
using Liv.Lck.Recorder;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR;

public class GillaLivCamera : MonoBehaviour, _00210
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GillaLeaderboard.Row> _003C_003E9__87_0;

		public static Comparison<GillaFriends.Friend> _003C_003E9__87_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19E0]");
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

		internal unsafe int _003CGather_003Eb__87_0(GillaLeaderboard.Row p, GillaLeaderboard.Row q)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			int num = q + 24;
			if (p.level == ((int*)num)->m_value)
			{
				return string.CompareOrdinal(p.name, q.name);
			}
			return ((int*)num)->CompareTo(p.level);
		}

		internal int _003CGather_003Eb__87_1(GillaFriends.Friend a, GillaFriends.Friend b)
		{
			//IL_00e8: Expected I4, but got Obj
			//IL_00a7: Expected Obj, but got I4
			if (a != null && b != null)
			{
				if (a.on == b.on)
				{
					return string.Compare(a.name, b.name, (StringComparison)5);
				}
				bool flag = !a.on;
				object obj = !flag;
				object obj2 = ~obj;
				if (obj2 == null)
				{
					return -1;
				}
				return 1;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public enum Mode
	{
		// error: enumerator has no value
		Selfie,
		// error: enumerator has no value
		FirstPerson,
		// error: enumerator has no value
		ThirdPerson
	}

	private sealed class _003C_003Ec__DisplayClass236_0
	{
		public LckResult r;

		public GillaLivCamera _003C_003E4__this;

		internal void _003CStarted_003Eb__0()
		{
			//IL_0050: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I4
			//IL_00a7: Expected Obj, but got I
			//IL_00d5: Expected Obj, but got I
			//IL_00f9: Expected Obj, but got I
			LckResult lckResult = r;
			GillaLivCamera gillaLivCamera = _003C_003E4__this;
			if (~(lckResult._success ? 1u : 0u) == 0)
			{
				_003C_003E4__this.Sound(gillaLivCamera.startSound);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F28]");
			object doing = 0;
			string words = Short(lckResult, (string)doing);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+A0]");
			object obj5 = 0;
			GillaLivCamera gillaLivCamera2 = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+88]");
			gillaLivCamera2.Say(words, (Color32[])0, 3f);
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public LckResult r;

		public GillaLivCamera _003C_003E4__this;

		internal void _003CStopped_003Eb__0()
		{
			//IL_0015: Expected Obj, but got I
			//IL_00dc: Expected Obj, but got I4
			//IL_0109: Expected Obj, but got I
			//IL_005b: Expected Obj, but got I4
			//IL_0137: Expected Obj, but got I
			//IL_0090: Expected Obj, but got I
			//IL_00a0: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			LckResult lckResult = r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			object obj = 0;
			object obj2 = obj;
			string text;
			float seconds;
			if (~(lckResult._success ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2028]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+A0]");
				object obj6 = 0;
				text = (string)obj5;
				seconds = 8f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2030]");
				object doing = 0;
				string text2 = Short(lckResult, (string)doing);
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+A0]");
				object obj6 = 0;
				text = text2;
				seconds = 3f;
			}
			GillaLivCamera gillaLivCamera = _003C_003E4__this;
			string words = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5+88]");
			gillaLivCamera.Say(words, (Color32[])0, seconds);
		}
	}

	private sealed class _003C_003Ec__DisplayClass238_0
	{
		public GillaLivCamera _003C_003E4__this;

		public LckResult<RecordingData> r;

		internal void _003CSaved_003Eb__0()
		{
			//IL_0079: Expected Obj, but got I
			//IL_008e: Expected Obj, but got I
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_003a: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_00e0: Expected Obj, but got I
			//IL_020e: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got I
			//IL_0253: Expected Obj, but got I
			//IL_0263: Expected Obj, but got I
			//IL_016b: Expected Obj, but got I4
			//IL_01a0: Expected Obj, but got I
			//IL_01b0: Expected Obj, but got I
			//IL_01c8: Expected Obj, but got I
			LckResult<RecordingData> lckResult = r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Liv.Lck.LckResult`1<Liv.Lck.Recorder.RecordingData>)+10]");
			string text;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Liv.Lck.LckResult`1<Liv.Lck.Recorder.RecordingData>)+28]");
				text = (string)0;
				bool flag = (object)_003C_003E4__this == null;
				object obj = !flag;
				if (obj == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2058]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Liv.Lck.LckResult`1<Liv.Lck.Recorder.RecordingData>)+18]");
				string text2 = (string)obj2 + (string)0;
				text = text2;
			}
			object obj3 = _003C_003E4__this + 176;
			obj3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			LckResult<RecordingData> lckResult2 = r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			object obj4 = 0;
			GillaLivCamera gillaLivCamera = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5 (Liv.Lck.LckResult`1<Liv.Lck.Recorder.RecordingData>)+10]");
			string words;
			Color32[] colours;
			float seconds;
			GillaLivCamera gillaLivCamera2;
			if ((nint)0 != 0)
			{
				int num = gillaLivCamera.VideosSaved__BackingField + 1;
				gillaLivCamera.VideosSaved__BackingField = num;
				gillaLivCamera.Sound(gillaLivCamera.saveSound);
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2060]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v14+A0]");
				object obj9 = 0;
				words = (string)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v15+90]");
				colours = (Color32[])0;
				seconds = 2.5f;
				gillaLivCamera2 = _003C_003E4__this;
			}
			else
			{
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v9+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2050]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v10+88]");
				colours = (Color32[])0;
				words = (string)obj14;
				seconds = 3f;
				gillaLivCamera2 = gillaLivCamera;
			}
			gillaLivCamera2.Say(words, colours, seconds);
		}
	}

	public Renderer body;

	public int screenSlot;

	public int tallySlot;

	public Transform selfieEye;

	public Transform selfieAim;

	public Transform lensEye;

	public Transform lensAim;

	public Transform upMark;

	public Transform seat;

	public Transform seatAim;

	public Transform seatUp;

	public PressKey[] keys;

	public TextAsset titleFont;

	public TextAsset textFont;

	public LckQualityConfig quality;

	public AudioClip startSound;

	public AudioClip saveSound;

	public AudioClip shutterSound;

	public const int W = default(int);

	public const int H = default(int);

	public static readonly RectInt Preview;

	public static readonly RectInt PortraitPreview;

	public static readonly (string, RectInt)[] Buttons;

	private static GillaLivCamera Yours__BackingField;

	private bool MadeKeys__BackingField;

	private string LastSaved__BackingField;

	private int PhotosSaved__BackingField;

	private int VideosSaved__BackingField;

	private int PressesRefused__BackingField;

	private string LastRefusal__BackingField;

	private const string MonitorName = null;

	private const float WakeNear = default(float);

	private const float HomeFar = default(float);

	private const float HomeAfter = default(float);

	private const float DockSnap = default(float);

	private const float FollowAfter = default(float);

	private const int FovMin = default(int);

	private const int FovMax = default(int);

	private const int FovStep = default(int);

	private const int SmoothMost = default(int);

	private const float DistMin = default(float);

	private const float DistMax = default(float);

	private const float DistStep = default(float);

	private const float ThirdHeight = default(float);

	private static readonly int BaseMap;

	private static readonly int PreviewTex;

	private static readonly int PreviewOn;

	private static readonly int PreviewBox;

	private static readonly int BaseColor;

	private static ILckService service;

	private static string trouble;

	private static bool started;

	private GillaItem item;

	private GillaLivLens lens;

	private bool docked;

	private bool awake;

	private bool wasHeld;

	private bool hooked;

	private bool monitorOn;

	private bool activeSet;

	private bool presetDone;

	private bool dirty;

	private int startedIn;

	private float farSince;

	private float noticeUntil;

	private float flashUntil;

	private float pressedUntil;

	private float nextDraw;

	private string notice;

	private string pressedId;

	private Color32[] noticeColours;

	private Mode mode;

	private readonly int[] fov;

	private readonly int[] smooth;

	private float distance;

	private bool selfieBack;

	private bool thirdFront;

	private bool mic;

	private bool portrait;

	private List<QualityOption> options;

	private int qualityAt;

	private Vector3 deviceFront;

	private Vector3 deviceUp;

	private Vector3 lensPos;

	private Quaternion lensRot;

	private bool lensPlaced;

	private RenderTexture seen;

	private Texture2D tex;

	private Color32[] px;

	private string shown;

	private ScreenFont title;

	private ScreenFont text;

	private MaterialPropertyBlock screenBlock;

	private MaterialPropertyBlock tallyBlock;

	private readonly Queue<Action> later;

	private const int Trail = default(int);

	private const float PokeFastest = default(float);

	private const float InFrontBefore = default(float);

	private const float RunningFrom = default(float);

	private const float LookBack = default(float);

	private readonly Vector3[,] tipTrail;

	private readonly float[] trailTime;

	private int trailHead;

	private int trailCount;

	private Transform[] tips;

	private Rigidbody you;

	private const float RecallAhead = default(float);

	private const float RecallBelow = default(float);

	private const float RecallTime = default(float);

	private float flyT;

	private const float TapLongest = default(float);

	private const float GripOpenUnder = default(float);

	private bool equipped;

	private bool hidden;

	private bool xWas;

	private bool xSpoilt;

	private bool recNow;

	private float xDownAt;

	private readonly List<Renderer> hiddenLooks;

	private static readonly List<UnityEngine.XR.InputDevice> lefts;

	private Camera eyesCam;

	private UniversalAdditionalCameraData eyesData;

	private const float ThirdTurnTime = default(float);

	private Vector3 thirdOffset;

	private Renderer[] ownLooks;

	private static int solidMask;

	private static int firstPersonLayer;

	private static int mirrorOnlyLayer;

	private static int rigLayer;

	private Vector3 flyFrom;

	private Vector3 flyTo;

	private Quaternion flyFromTurn;

	private Quaternion flyToTurn;

	private static readonly Color32[] Silver;

	private static readonly Color32[] Milk;

	private static readonly Color32[] Orange;

	private static readonly Color32[] Lime;

	private static readonly Color32[] Grey;

	private static readonly Color32[] Dim;

	private static readonly Color32[] Red;

	private static readonly Color32 Shadow;

	private static readonly Color32 Clear;

	private static readonly Color32 ButtonFill;

	private static readonly Color32 ButtonLit;

	private static readonly Color32 PickedFill;

	private static readonly Color32 RecFill;

	private static readonly Color32 Band;

	private int dockedIn;

	public bool Docked => docked;

	public bool IsAwake => awake;

	public bool Hidden => hidden;

	public bool Equipped => equipped;

	public static GillaLivCamera Yours
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+28]");
			return (GillaLivCamera)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
			object obj4 = (nint)0 + (nint)40;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public Mode Filming => mode;

	public bool Flipped
	{
		get
		{
			if (mode == (Mode)2)
			{
				return !thirdFront;
			}
			bool flag = !selfieBack;
			return !flag;
		}
	}

	public int Fov
	{
		get
		{
			//IL_008e: Expected I4, but got Obj
			//IL_0046: Expected Obj, but got I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			int[] array = fov;
			if (fov != null)
			{
				bool flag = (int)mode < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = fov + mode;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v2+20]");
					return 0;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
	}

	public float Distance => distance;

	public int Smoothing
	{
		get
		{
			//IL_00c6: Expected I4, but got Obj
			//IL_0076: Expected Obj, but got I4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			if (mode == (Mode)2)
			{
				return 0;
			}
			int[] array = smooth;
			if (smooth != null)
			{
				bool flag = (int)mode < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = smooth + mode;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+20]");
					return 0;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
	}

	public bool Mic => mic;

	public bool Portrait => portrait;

	public RectInt Picture
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_00ef: Expected Obj, but got I
			//IL_0037: Expected Obj, but got I4
			//IL_00f9: Expected VT, but got Obj
			//IL_00da: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			object obj = 0;
			object obj2 = obj;
			object obj4;
			if (~(portrait ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+A0]");
				obj4 = (nint)0 + (nint)16;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+A0]");
				obj4 = 0;
			}
			return (RectInt)obj4;
		}
	}

	public bool MadeKeys
	{
		get
		{
			return MadeKeys__BackingField;
		}
		private set
		{
			MadeKeys__BackingField = value;
		}
	}

	public string QualityName
	{
		get
		{
			//IL_0060: Expected Obj, but got I
			List<QualityOption> list = options;
			if (options != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
				if ((nint)0 > (nint)0)
				{
					QualityOption qualityOption = options.get_Item(qualityAt);
					string result = default;
					return result;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			return (string)0;
		}
	}

	public bool Recording
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01d2: Expected Obj, but got I4
			//IL_0230: Expected Obj, but got I
			//IL_0240: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I4
			//IL_00cb: Expected Obj, but got I
			//IL_00db: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I
			//IL_008e: Expected Obj, but got I
			//IL_0116: Expected Obj, but got I
			//IL_01a8: Expected I4, but got Obj
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected Obj, but got Unknown
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected Obj, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected Obj, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+48]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+48]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+A0]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v12+48]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v12+48]");
					if ((nint)0 == 0)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
				}
				object obj9 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0157;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+98]");
				object obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v7-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj11--;
					obj12 += 16;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_0157;
				}
				object obj13 = obj12 + 39;
				object obj14 = obj9 + obj13;
				object obj15 = obj14 + 312;
				goto IL_0204;
			}
			return false;
			IL_0157:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0204;
			IL_0204:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v6] (should have been resolved before IL gen)");
			LckResult<bool> r = default;
			return Ok(r);
		}
	}

	public string Notice
	{
		get
		{
			float unscaledTime = Time.unscaledTime;
			bool flag = !(unscaledTime < noticeUntil);
			string result = null;
			if (!flag)
			{
				result = notice;
			}
			return result;
		}
	}

	public GillaLivLens Lens => lens;

	public RenderTexture PreviewTexture => seen;

	public Texture2D Page => tex;

	public string Trouble
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+50]");
			return (string)0;
		}
	}

	public string LastSaved
	{
		get
		{
			return LastSaved__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 176;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public int PhotosSaved
	{
		get
		{
			return PhotosSaved__BackingField;
		}
		private set
		{
			PhotosSaved__BackingField = value;
		}
	}

	public int VideosSaved
	{
		get
		{
			return VideosSaved__BackingField;
		}
		private set
		{
			VideosSaved__BackingField = value;
		}
	}

	public int PressesRefused
	{
		get
		{
			return PressesRefused__BackingField;
		}
		private set
		{
			PressesRefused__BackingField = value;
		}
	}

	public string LastRefusal
	{
		get
		{
			return LastRefusal__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 200;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static bool CanRecordHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01d4: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got I4
			//IL_014c: Expected Obj, but got I4
			//IL_0171: Expected Obj, but got I4
			//IL_0095: Expected Obj, but got I4
			//IL_00af: Expected Obj, but got I4
			//IL_00d4: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj = 0;
			GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool result;
			switch (Application.platform)
			{
			case (RuntimePlatform)11:
			{
				object obj8 = graphicsDeviceType - 21;
				bool flag3 = obj8 == null;
				object obj9 = !flag3;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					object obj11 = graphicsDeviceType - 11;
					result = obj11 == null;
				}
				else
				{
					result = true;
				}
				break;
			}
			case (RuntimePlatform)2:
			case (RuntimePlatform)7:
			{
				if (graphicsDeviceType == (GraphicsDeviceType)21)
				{
					return true;
				}
				object obj4 = graphicsDeviceType - 2;
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
					object obj7 = graphicsDeviceType - 17;
					result = obj7 == null;
				}
				else
				{
					result = true;
				}
				break;
			}
			default:
				return false;
			}
			return result;
		}
	}

	public string MonitorId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D10]");
			return (string)0;
		}
	}

	public unsafe (byte, Vector3, Quaternion) ForOthers()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I
		//IL_02f1: Expected VT, but got I4
		//IL_030c: Expected VT, but got Obj
		//IL_0307: Expected native int or pointer, but got VT
		//IL_0084: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_02a0: Expected VT, but got Obj
		//IL_0181: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_0208: Expected I4, but got Obj
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte item;
		if (Application.isPlaying)
		{
			bool flag2 = (byte)(~(docked ? 1u : 0u)) != 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				bool flag3 = (byte)(~(hidden ? 1u : 0u)) != 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v17+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = this.item == null;
					bool flag6 = !flag5;
					object obj9 = !flag6;
					if (obj9 == null && isActiveAndEnabled)
					{
						GillaItem gillaItem = this.item;
						if ((object)this.item != null)
						{
							object obj10 = (recNow ? 1u : 0u) << 2;
							bool flag7 = gillaItem.Hand__BackingField < 1;
							object obj11 = !flag7;
							object obj12 = gillaItem.Hand__BackingField - 1;
							bool flag8 = obj12 == null;
							object obj13 = !flag8;
							object obj14 = obj11 & obj13;
							if (obj14 == null)
							{
								object obj15 = gillaItem.Hand__BackingField + 1;
								item = (byte)(obj15 | obj10);
								goto IL_02d8;
							}
							Transform transform = base.transform;
							if ((object)transform != null)
							{
								Vector3 position = transform.position;
								Transform transform2 = base.transform;
								if ((object)transform2 != null)
								{
									item = (byte)(obj10 | 3);
									Quaternion rotation = transform2.rotation;
									goto IL_02d8;
								}
							}
						}
						NullReferenceException ex = new NullReferenceException();
						return ((byte, Vector3, Quaternion))ex;
					}
				}
			}
		}
		item = 0;
		goto IL_02d8;
		IL_02d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C50]");
		object obj16 = 0;
		(byte, Vector3, Quaternion) tuple = ((byte, Vector3, Quaternion))0;
		_ = 0;
		Quaternion item2 = default;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (item, (Vector3)obj16, item2));
		return tuple;
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

	private static Color32 G(byte v)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected VT, but got Unknown
		int num = v & 0xFF;
		object obj = num * 65793;
		return (Color32)(obj | 0xFF000000L);
	}

	private static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
		object obj4 = (nint)0 + (nint)72;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+A0]");
		object obj6 = (nint)0 + (nint)80;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v12+A0]");
		object obj8 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v12+A0]");
		object obj10 = (nint)0 + (nint)40;
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07af: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_02cb: Expected VT, but got I4
		//IL_07f6: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_04a0: Expected VT, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected Obj, but got Unknown
		//IL_0360: Expected Obj, but got I4
		//IL_0369: Expected VT, but got I4
		//IL_0ad3: Expected Obj, but got I
		//IL_0afd: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I
		//IL_098d: Expected Obj, but got I
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected Obj, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected Obj, but got Unknown
		//IL_04f8: Expected Obj, but got VT
		//IL_0506: Expected VT, but got I4
		//IL_0bc7: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I
		//IL_061c: Expected Obj, but got I
		//IL_095b: Expected Obj, but got I
		//IL_096b: Expected Obj, but got I
		//IL_0b65: Expected Obj, but got I
		//IL_0b8f: Expected Obj, but got I4
		//IL_03d5: Expected Obj, but got VT
		//IL_03e3: Expected VT, but got I4
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_0a17: Expected Obj, but got I
		//IL_0a29: Expected VT, but got I
		//IL_08f3: Expected Obj, but got I
		//IL_06a5: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I
		//IL_0577: Expected VT, but got Obj
		//IL_0587: Expected Obj, but got I
		//IL_0a83: Expected Obj, but got I
		//IL_0aad: Expected Obj, but got I4
		//IL_093c: Expected VT, but got I4
		//IL_0545: Expected VT, but got Obj
		//IL_044c: Expected Obj, but got I
		//IL_0454: Expected VT, but got Obj
		//IL_0464: Expected Obj, but got I
		//IL_086f: Expected Obj, but got I4
		//IL_0878: Expected VT, but got I4
		//IL_0422: Expected VT, but got Obj
		//IL_0721: Expected Obj, but got I
		//IL_074b: Expected Obj, but got I4
		//IL_0a65: Expected Obj, but got I4
		//IL_0beb: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		if (Application.isPlaying)
		{
			Transform transform = base.transform;
			Transform parent = transform.parent;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v64+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = parent != null;
			bool flag4 = !flag3;
			bool flag5 = false;
			if (!flag4)
			{
				Transform transform2 = base.transform;
				transform2.SetParent(null, worldPositionStays: true);
				flag5 = true;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj8 = this + 208;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = (UnityEngine.Object)obj8 != null;
		bool flag8 = !flag7;
		object obj12 = 0;
		if (!flag8)
		{
			GillaItem gillaItem = (GillaItem)obj8;
			gillaItem.Floats__BackingField = true;
			gillaItem.Passes = true;
			object obj13 = obj8;
			_ = 1;
			obj12 = 0;
		}
		Transform transform3 = base.transform;
		Vector3 position = transform3.position;
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v21+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = selfieEye != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj16 = 0;
		bool flag11 = !flag10;
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		object obj18 = default;
		object obj17 = obj18;
		object obj20 = default;
		object obj19 = obj20;
		object obj21 = 0;
		Vector3 vector3 = (Vector3)0;
		if (!flag11)
		{
			object obj22 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v96+E4]");
			bool flag12 = (nint)0 == 0;
			object obj23 = !flag12;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = selfieAim != null;
			bool flag14 = !flag13;
			vector = vector2;
			obj17 = obj18;
			obj19 = obj20;
			obj21 = 0;
			vector3 = (Vector3)0;
			if (!flag14)
			{
				Transform transform4 = base.transform;
				Vector3 position2 = selfieAim.position;
				Vector3 position3 = selfieEye.position;
				object obj24 = obj20 - obj20;
				object obj25 = obj18 - obj18;
				object obj26 = vector2 - vector2;
				Vector3 vector4 = transform4.InverseTransformDirection((Vector3)0);
				object obj27 = obj25;
				obj19 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v110+E4]");
				bool flag15 = (nint)0 == 0;
				object obj30 = !flag15;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj25;
					obj19 = obj24;
				}
				object obj31 = obj19 * obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if ((nint)obj32 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					vector = (Vector3)(obj26 / obj31);
					obj17 = obj27 / obj19;
				}
				else
				{
					object obj33 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v59+A0]");
					object obj34 = 0;
					vector = (Vector3)obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v60+4]");
					obj17 = 0;
				}
				deviceFront = vector;
				obj21 = 0;
				vector3 = (Vector3)0;
			}
		}
		object obj35 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v26+E4]");
		bool flag16 = (nint)0 == 0;
		object obj36 = !flag16;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = upMark != null;
		bool flag18 = !flag17;
		Vector3 vector5 = (Vector3)0;
		if (!flag18)
		{
			Transform transform5 = base.transform;
			Vector3 position4 = upMark.position;
			object obj37 = obj19 - obj20;
			object obj38 = obj17 - obj18;
			object obj39 = vector - vector2;
			Vector3 vector6 = transform5.InverseTransformDirection((Vector3)0);
			object obj40 = obj39;
			object obj41 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v86+E4]");
			bool flag19 = (nint)0 == 0;
			object obj44 = !flag19;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj40 = obj39;
				obj41 = obj38;
			}
			object obj45 = obj40 * obj40;
			object obj46 = obj41 * obj41;
			object obj47 = obj45 + obj46;
			object obj48 = obj37 * obj37;
			obj19 = obj48 + obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj49 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			Vector3 vector7;
			if ((nint)obj49 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				vector7 = (Vector3)(obj40 / obj41);
				object obj50 = obj37 / obj19;
			}
			else
			{
				object obj51 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v44+A0]");
				object obj52 = 0;
				vector7 = (Vector3)obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v45+8]");
				object obj50 = 0;
			}
			deviceUp = vector7;
			vector5 = (Vector3)0;
		}
		object obj53 = this + 324;
		object obj54 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v30+A0]");
		object obj55 = 0;
		object obj56 = obj53 - obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+14C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X9_v10+8]");
		object obj57 = num - 0;
		object obj58 = obj56 * obj56;
		object obj59 = obj57 * obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj60 = obj59 + obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		Vector3 vector8;
		object obj61;
		if ((nint)obj60 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99C]");
			if ((nint)0 == 0)
			{
				obj54 = obj16;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v30+A0]");
				obj55 = 0;
			}
			vector8 = deviceUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+158]");
			obj61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X9_v10+48]");
			obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X9_v10+50]");
			_ = 0;
		}
		else
		{
			vector8 = deviceUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+158]");
			obj61 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v30+A0]");
		object obj62 = 0;
		object obj63 = vector8 - obj62;
		object obj64 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v27+8]");
		object obj65 = obj64 - 0;
		object obj66 = obj63 * obj63;
		object obj67 = obj65 * obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj68 = obj67 + obj66;
		object obj69 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if ((nint)obj69 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v27+20]");
			obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v27+18]");
			deviceUp = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v27+20]");
			_ = 0;
		}
		object obj70 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v34+E4]");
		bool flag20 = (nint)0 == 0;
		object obj71 = !flag20;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA360]");
		object obj72 = 0;
		if (Application.isPlaying)
		{
			AddMissingKeys();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		Renderer[] array = default;
		ownLooks = array;
		object obj73 = this + 552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj74 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v43+E4]");
		bool flag21 = (nint)0 == 0;
		object obj75 = !flag21;
		if (obj75 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Transform transform6 = base.transform;
			transform6.SetParent(null, worldPositionStays: true);
			Dock();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			object obj76 = 0;
			object obj77 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v50+E4]");
			bool flag22 = (nint)0 == 0;
			object obj78 = !flag22;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj79 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X0_v54+E4]");
			bool flag23 = (nint)0 == 0;
			object obj80 = !flag23;
			if (obj80 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj79 = obj76;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X0_v54+A0]");
			object obj81 = (nint)0 + (nint)40;
			obj81 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void AddMissingKeys()
	{
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f2: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I8
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_1346: Expected Obj, but got I
		//IL_1356: Expected Obj, but got I
		//IL_1328: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I8
		//IL_03d6: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_145f: Expected Obj, but got I4
		//IL_1244: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I
		//IL_128e: Expected Obj, but got I
		//IL_138b: Expected Obj, but got I
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_1399: Expected Obj, but got Unknown
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_0513: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I
		//IL_0783: Invalid comparison between Obj and F8
		//IL_07a7: Expected Obj, but got I
		//IL_07d1: Expected Obj, but got I4
		//IL_09a7: Expected Obj, but got I
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected Obj, but got Unknown
		//IL_0a66: Expected VT, but got I4
		//IL_0ae0: Expected Obj, but got I
		//IL_0b0a: Expected Obj, but got I4
		//IL_0b6b: Expected Obj, but got I
		//IL_0cda: Expected Obj, but got I
		//IL_0cf4: Expected Obj, but got I
		//IL_0d09: Expected Obj, but got I
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Expected Obj, but got Unknown
		//IL_0d5a: Expected Obj, but got I
		//IL_0d96: Expected Obj, but got I
		//IL_0e07: Expected Obj, but got I
		//IL_0e31: Expected Obj, but got I4
		//IL_10aa: Expected Obj, but got I
		//IL_1114: Expected Obj, but got I4
		//IL_0ec0: Expected Obj, but got I4
		//IL_1196: Expected Obj, but got I
		//IL_11a6: Expected Obj, but got I
		//IL_11b6: Expected Obj, but got I
		//IL_13f4: Expected Obj, but got I
		//IL_1404: Expected Obj, but got I
		//IL_1414: Expected Obj, but got I
		//IL_11e0: Expected Obj, but got I
		//IL_11f0: Expected Obj, but got I
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected Obj, but got Unknown
		//IL_1162: Unknown result type (might be due to invalid IL or missing references)
		//IL_1167: Expected Obj, but got Unknown
		//IL_0f06: Expected Obj, but got I4
		//IL_0f3f: Expected Obj, but got I4
		//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Expected Obj, but got Unknown
		//IL_0f71: Expected Obj, but got I
		//IL_0f9b: Expected Obj, but got I4
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1009: Expected Obj, but got Unknown
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected Obj, but got Unknown
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected Obj, but got Unknown
		//IL_104e: Expected VT, but got I4
		//IL_1066: Expected Obj, but got I
		object obj = this + 112;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CA0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.__Canon _Canon = (System.__Canon)obj3;
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj4 = obj;
		if (obj == null)
		{
			goto IL_12d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X19_v6+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_02c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C98]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X19_v6+18]");
		object obj7 = 0 & 0xFFFFFFFFL;
		object obj8 = obj + 32;
		object obj10 = default;
		object obj9 = obj10;
		System.__Canon _Canon3 = default;
		System.__Canon _Canon2 = _Canon3;
		System.__Canon _Canon4 = (System.__Canon)obj3;
		object obj11 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj12 = !flag;
			if (obj12 != null)
			{
				break;
			}
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X25_v14+v826 @ X20_v11*8]");
			UnityEngine.Object obj14 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X0_v113+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X25_v14+v826 @ X20_v11*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			_Canon3 = null;
			_Canon = null;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X25_v14+v826 @ X20_v11*8]");
				if ((nint)0 == 0)
				{
					goto IL_12d2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X22_v8 (UnityEngine.Object)+20]");
				bool flag5 = string.IsNullOrEmpty((string)0);
				bool flag6 = !flag5;
				object obj16 = !flag6;
				_Canon3 = null;
				_Canon = null;
				if (obj16 == null)
				{
					if (dictionary == null)
					{
						goto IL_12d2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X22_v8 (UnityEngine.Object)+20]");
					_Canon = (System.__Canon)0;
					obj9 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X22_v8 (UnityEngine.Object)+20]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X25_v14+v826 @ X20_v11*8]");
					dictionary.set_Item((System.__Canon)num, (System.__Canon)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X25_v14+v826 @ X20_v11*8]");
					_Canon3 = (System.__Canon)0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X19_v6+18]");
			obj7 = 0;
			obj11++;
			object obj17 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X19_v6+18]");
			bool flag7 = (nint)obj17 < 0;
			obj10 = obj9;
			_Canon2 = _Canon3;
			_Canon4 = _Canon;
			if (flag7)
			{
				continue;
			}
			goto IL_02c2;
		}
		goto IL_12e0;
		IL_11f5:
		List<System.__Canon> list = default;
		if (list != null)
		{
			if (list._size == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list2 = default;
			list2._002Ector((IEnumerable<System.__Canon>)obj);
			if (list2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CB0]");
				object obj19 = 0;
				list2.AddRange((IEnumerable<System.__Canon>)list);
				System.__Canon[] array = list2.ToArray();
				keys = (PressKey[])(object)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				MadeKeys__BackingField = true;
				return;
			}
		}
		goto IL_12d2;
		IL_02c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CC8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.__Canon _Canon5 = (System.__Canon)obj21;
		list._002Ector();
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v13+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v15+20]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v15+20]");
		if ((nint)0 == 0)
		{
			goto IL_12d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v8+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_11f5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C80]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CF0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v8+18]");
		object obj29 = 0 & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v15+20]");
		object obj30 = (nint)0 + (nint)52;
		object obj32 = default;
		object obj31 = obj32;
		object obj34 = default;
		object obj33 = obj34;
		object obj36 = default;
		object obj35 = obj36;
		object obj38 = default;
		object obj37 = obj38;
		object obj40 = default;
		object obj39 = obj40;
		object obj42 = default;
		object obj41 = obj42;
		object obj44 = default;
		object obj43 = obj44;
		object obj46 = default;
		object obj45 = obj46;
		System.__Canon value = null;
		System.__Canon value2 = null;
		System.__Canon value3 = null;
		object obj47 = 0;
		object obj48 = obj10;
		object obj74 = default;
		object obj76 = default;
		object obj78 = default;
		object obj92 = default;
		object obj98 = default;
		object obj108 = default;
		object obj130 = default;
		UnityEngine.Object obj133 = default;
		UnityEngine.Object obj136 = default;
		UnityEngine.Object obj140 = default;
		while (true)
		{
			bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
			object obj49 = !flag9;
			if (obj49 != null)
			{
				break;
			}
			if (dictionary != null)
			{
				_Canon3 = (System.__Canon)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-14]");
				bool flag10 = dictionary.ContainsKey((System.__Canon)0);
				bool flag11 = !flag10;
				object obj50 = !flag11;
				obj40 = obj39;
				obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-14]");
				_Canon5 = (System.__Canon)0;
				if (obj50 != null)
				{
					goto IL_137b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C88]");
				object obj51 = 0;
				if (!dictionary.TryGetValue((System.__Canon)obj28, out value3))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D00]");
				object key = 0;
				if (!dictionary.TryGetValue((System.__Canon)key, out value2))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE8]");
				object key2 = 0;
				obj48 = obj51;
				if (!dictionary.TryGetValue((System.__Canon)key2, out value))
				{
					return;
				}
				object obj52 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X0_v32+E4]");
				bool flag12 = (nint)0 == 0;
				object obj53 = !flag12;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Vector2 vector = Middle((string)obj28);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D00]");
				object id = 0;
				Vector2 vector2 = Middle((string)id);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE8]");
				object id2 = 0;
				Vector2 vector3 = Middle((string)id2);
				if (value3 != null)
				{
					Transform transform = ((Component)(object)value3).transform;
					if ((object)transform != null)
					{
						Vector3 localPosition = transform.localPosition;
						if (value2 != null)
						{
							Transform transform2 = ((Component)(object)value2).transform;
							if ((object)transform2 != null)
							{
								Vector3 localPosition2 = transform2.localPosition;
								if (value != null)
								{
									Transform transform3 = ((Component)(object)value).transform;
									if ((object)transform3 != null)
									{
										Vector3 localPosition3 = transform3.localPosition;
										object obj54 = obj39 - obj39;
										object obj55 = obj39 - obj39;
										object obj56 = obj41 - obj41;
										object obj57 = obj41 - obj41;
										object obj58 = obj56 * obj55;
										object obj59 = obj54 * obj57;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
										{
											return;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
										object obj60 = 0;
										object obj61 = obj60;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X0_v49+E4]");
										bool flag13 = (nint)0 == 0;
										object obj62 = !flag13;
										if (obj62 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (value3 != null)
										{
											Transform transform4 = ((Component)(object)value3).transform;
											if ((object)transform4 != null)
											{
												Transform parent = transform4.parent;
												if (value3 != null)
												{
													GameObject gameObject = ((Component)(object)value3).gameObject;
													if ((object)parent != null)
													{
														object obj63 = obj31 - obj31;
														object obj64 = obj31 - obj31;
														object obj65 = obj55 * obj63;
														object obj66 = obj54 * obj64;
														object obj67 = obj57 * obj63;
														object obj68 = obj58 - obj59;
														object obj69 = obj65 - obj66;
														object obj70 = obj41 - obj41;
														object obj71 = obj41 - obj41;
														object obj72 = obj69 / obj68;
														object obj73 = obj70 * obj74;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
														object obj75 = obj70 * obj76;
														object obj77 = obj71 * obj78;
														object obj79 = obj73 - obj77;
														object obj80 = obj71 * obj78;
														object obj81 = obj56 * obj64;
														object obj82 = obj79 / obj55;
														object obj83 = obj80 - obj75;
														object obj84 = obj81 - obj67;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-4]");
														nint num2 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-C]");
														object obj85 = num2 + 0;
														object obj86 = obj83 / obj55;
														object obj87 = obj85 - obj41;
														object obj88 = obj84 / obj68;
														object obj89 = obj30;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-8]");
														object obj90 = obj89 + 0;
														object obj91 = obj82 * obj92;
														object obj93 = obj87 * obj72;
														object obj94 = obj90 - obj39;
														object obj95 = obj41 + obj91;
														object obj96 = obj31 + obj93;
														object obj97 = obj86 * obj98;
														object obj99 = obj94 * obj88;
														object obj100 = obj97 + obj95;
														object obj101 = obj99 + obj96;
														Vector3 vector4 = parent.TransformPoint((Vector3)0);
														Quaternion rotation = parent.rotation;
														if (value3 != null)
														{
															Transform transform5 = ((Component)(object)value3).transform;
															if ((object)transform5 != null)
															{
																Quaternion localRotation = transform5.localRotation;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																object obj102 = 0;
																object obj103 = obj102;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v63+E4]");
																bool flag14 = (nint)0 == 0;
																object obj104 = !flag14;
																if (obj104 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																object obj105 = obj97 * obj100;
																object obj106 = obj100 * obj97;
																object obj107 = obj97 * obj108;
																object obj109 = obj108 * obj97;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E20]");
																object obj110 = 0;
																object obj111 = obj97 * obj101;
																object obj112 = obj101 * obj97;
																object obj113 = obj97 * obj97;
																object obj114 = obj100 * obj100;
																object obj115 = obj105 + obj106;
																object obj116 = obj108 * obj101;
																object obj117 = obj108 * obj100;
																object obj118 = obj107 + obj109;
																object obj119 = obj101 * obj100;
																object obj120 = obj101 * obj108;
																object obj121 = obj111 + obj112;
																object obj122 = obj100 * obj108;
																object obj123 = obj100 * obj101;
																object obj124 = obj113 - obj114;
																obj35 = obj108 * obj108;
																object obj125 = obj101 * obj101;
																object obj126 = obj116 + obj115;
																object obj127 = obj119 + obj118;
																object obj128 = obj122 + obj121;
																object obj129 = obj124 - obj35;
																obj45 = obj126 - obj120;
																obj43 = obj127 - obj123;
																obj37 = obj128 - obj117;
																obj33 = obj129 - obj125;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDDA0");
																if (obj130 != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CA8]");
																	object obj131 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CF8]");
																	object obj132 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-14]");
																	string text = (string)obj132 + (string)0;
																	if ((object)obj133 != null)
																	{
																		obj133.name = text;
																		object obj134 = obj133 + 32;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-14]");
																		obj134 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		if (value3 != null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F40]");
																			object obj135 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
																			bool flag15 = obj136 != null;
																			bool flag16 = !flag15;
																			obj31 = obj101;
																			obj40 = obj108;
																			obj42 = obj100;
																			_Canon3 = null;
																			if (!flag16)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																				object obj137 = 0;
																				object obj138 = obj137;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1239 @ X0_v86+E4]");
																				bool flag17 = (nint)0 == 0;
																				object obj139 = !flag17;
																				if (obj139 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				}
																				bool flag18 = obj140 != null;
																				bool flag19 = !flag18;
																				obj31 = obj101;
																				obj40 = obj108;
																				obj42 = obj100;
																				_Canon3 = null;
																				if (!flag19)
																				{
																					object obj141 = obj22;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v91+E4]");
																					bool flag20 = (nint)0 == 0;
																					object obj142 = !flag20;
																					if (obj142 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																						obj141 = obj22;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v91+A0]");
																					object obj143 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ X8_v66+20]");
																					object obj144 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CF0]");
																					object id3 = 0;
																					int num3 = Index((string)id3);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ X8_v66+20]");
																					if ((nint)0 != 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X27_v11+18]");
																						bool flag21 = (nint)num3 < (nint)0;
																						object obj145 = !flag21;
																						if (obj145 != null)
																						{
																							break;
																						}
																						if ((object)obj136 != null)
																						{
																							object obj146 = num3 * 24;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ X8_v66+20]");
																							object obj147 = 0 + obj146;
																							Vector3 size = ((BoxCollider)obj136).size;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
																							object obj148 = 0;
																							object obj149 = obj148;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v96+E4]");
																							bool flag22 = (nint)0 == 0;
																							object obj150 = !flag22;
																							if (obj150 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																							}
																							Vector3 size2 = ((BoxCollider)obj136).size;
																							Vector3 size3 = ((BoxCollider)obj136).size;
																							if ((object)obj140 != null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ X8_v71+34]");
																								object obj151 = obj101 / 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ X8_v71+30]");
																								object obj152 = obj100 / 0;
																								obj31 = obj151 * obj30;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-4]");
																								obj42 = obj152 * 0;
																								((BoxCollider)obj140).size = (Vector3)0;
																								obj40 = obj108;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X26_v7-4]");
																								obj45 = 0;
																								_Canon3 = null;
																								goto IL_1070;
																							}
																						}
																					}
																					goto IL_12d2;
																				}
																			}
																			goto IL_1070;
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
			goto IL_12d2;
			IL_1070:
			if (list != null)
			{
				System.__Canon[] items = list._items;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CB8]");
				object obj153 = 0;
				int version = list._version + 1;
				object obj154 = obj153;
				list._version = version;
				if (list._items != null)
				{
					bool flag23 = list._size < items.Length;
					object obj155 = !flag23;
					if (obj155 == null)
					{
						object obj156 = list._items + list._size;
						int size4 = list._size + 1;
						list._size = size4;
						object obj157 = obj156 + 32;
						obj157 = obj133;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_Canon5 = (System.__Canon)(object)obj133;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X9_v12+20]");
						object obj158 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X8_v60+A8]");
						object obj159 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X8_v61+70]");
						_Canon3 = (System.__Canon)0;
						list.AddWithResize((System.__Canon)(object)obj133);
						_Canon5 = (System.__Canon)(object)obj133;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C80]");
					obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CF0]");
					obj28 = 0;
					goto IL_137b;
				}
			}
			goto IL_12d2;
			IL_137b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v8+18]");
			obj29 = 0;
			obj47++;
			obj30 += 24;
			object obj160 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v8+18]");
			bool flag24 = (nint)obj160 < 0;
			obj10 = obj48;
			obj39 = obj40;
			obj41 = obj42;
			if (flag24)
			{
				continue;
			}
			goto IL_11f5;
		}
		goto IL_12e0;
		IL_12e0:
		throw new IndexOutOfRangeException();
		IL_12d2:
		NullReferenceException ex = new NullReferenceException();
		goto IL_12e0;
	}

	private static int Index(string id)
	{
		//IL_0199: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_0189: Expected I4, but got Obj
		//IL_0168: Expected I4, but got I8
		//IL_0065: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		object obj2 = 32;
		int num = 0;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+20]");
			if ((nint)0 == 0)
			{
				goto IL_016d;
			}
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+18]");
			if ((nint)num2 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v11+A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v12+20]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v12+20]");
					if ((nint)0 == 0)
					{
						goto IL_016d;
					}
				}
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+18]");
				bool flag3 = (nint)num3 < (nint)0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+v42 @ X22_v2]");
					bool flag4 = (string)0 == id;
					bool flag5 = !flag4;
					object obj11 = !flag5;
					if (obj11 != null)
					{
						break;
					}
					num++;
					obj2 += 24;
					continue;
				}
				goto IL_017b;
			}
			num = -1;
			break;
			IL_017b:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (int)ex;
			IL_016d:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_017b;
		}
		return num;
	}

	private static Vector2 Middle(string id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_00e7: Expected VT, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_0073: Expected VT, but got Obj
		//IL_0095: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
		object obj5 = 0;
		int num = Index(id);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v3+18]");
			bool flag2 = (nint)num < (nint)0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj7 = 0;
				Vector2 result = (Vector2)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v10 (UnityEngine.Vector2)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				return result;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector2)ex2;
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_055d: Expected Obj, but got I4
		//IL_0583: Expected Obj, but got I
		//IL_05a5: Expected Obj, but got I4
		//IL_06de: Expected Obj, but got I
		//IL_0700: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I4
		//IL_0618: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_0724: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I4
		//IL_0650: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I
		//IL_067e: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_049e: Expected Obj, but got I4
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v1+28]");
		if ((UnityEngine.Object)0 == this)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v62+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v66+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v66+A0]");
			object obj14 = (nint)0 + (nint)40;
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Hook(on: false);
		bool flag6 = (byte)(~(monitorOn ? 1u : 0u)) != 0;
		bool flag7 = false;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D08]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D10]");
			object id = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v53+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ILckMonitor monitorById = LckMediator.GetMonitorById((string)id);
			bool flag9 = monitorById != this;
			flag7 = false;
			if (!flag9)
			{
				object obj18 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v57+E4]");
				bool flag10 = (nint)0 == 0;
				object obj19 = !flag10;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				LckMediator.UnregisterMonitor((ILckMonitor)this);
				flag7 = false;
			}
		}
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v13+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = lens != null;
		bool flag13 = !flag12;
		UnityEngine.Object obj22 = null;
		if (!flag13)
		{
			GameObject obj23 = lens.gameObject;
			object obj24 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v26+E4]");
			bool flag14 = (nint)0 == 0;
			object obj25 = !flag14;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj23);
			obj22 = null;
		}
		GillaLivCamera gillaLivCamera = (GillaLivCamera)obj;
		bool flag15 = (byte)(~(gillaLivCamera.monitorOn ? 1u : 0u)) != 0;
		object obj26 = !flag15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaLivCamera = (GillaLivCamera)obj;
		}
		AudioClip audioClip = gillaLivCamera.shutterSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v15 (UnityEngine.AudioClip)+48]");
		bool flag16 = (nint)0 == 0;
		object obj27 = 0;
		if (!flag16)
		{
			bool recording = gillaLivCamera.Recording;
			bool flag17 = !recording;
			obj27 = 0;
			if (!flag17)
			{
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v34+E4]");
				bool flag18 = (nint)0 == 0;
				object obj29 = !flag18;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v34+A0]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v21+48]");
				object obj31 = 0;
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v22+12E]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v22+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0454;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v22+98]");
				object obj35 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X10_v9-8]");
					if (0 == (nint)obj33)
					{
						break;
					}
					obj34--;
					obj35 += 16;
					if ((nint)obj34 != 1)
					{
						continue;
					}
					goto IL_0454;
				}
				object obj36 = obj35 + 24;
				object obj37 = obj32 + obj36;
				object obj38 = obj37 + 312;
				obj27 = 0;
				goto IL_06a7;
			}
		}
		goto IL_0626;
		IL_0454:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj27 = 24;
		goto IL_06a7;
		IL_06a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v35+8]");
		obj22 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v401 @ X0_v35] (should have been resolved before IL gen)");
		goto IL_0626;
		IL_0626:
		object obj39 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v23+E4]");
		bool flag19 = (nint)0 == 0;
		object obj40 = !flag19;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tex != null)
		{
			object obj41 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v27+E4]");
			bool flag20 = (nint)0 == 0;
			object obj42 = !flag20;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(tex);
		}
	}

	public void Dock()
	{
		//IL_0258: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got VT
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got VT
		//IL_01a5: Expected Obj, but got VT
		//IL_01d8: Expected Obj, but got VT
		//IL_0219: Expected VT, but got I4
		//IL_0219: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		if (~(hidden ? 1u : 0u) == 0)
		{
			hidden = false;
			Showing(on: true);
			object obj2 = this + 408;
			shown = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			dirty = true;
		}
		(Transform, Transform, Transform) tuple = SeatHere();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 forward = default;
		if ((UnityEngine.Object)forward != null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj7 = default;
			if (obj7 != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v16+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj10 = default;
				if (obj10 != null)
				{
					Vector3 position = ((Transform)obj7).position;
					Vector3 position2 = ((Transform)forward).position;
					Vector3 position3 = ((Transform)obj10).position;
					Vector3 position4 = ((Transform)forward).position;
					Vector3 upwards = default;
					Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
					Transform transform = base.transform;
					Vector3 position5 = ((Transform)forward).position;
					Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
					Quaternion rotation = default;
					Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation);
					transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
				}
			}
		}
		docked = true;
		int current = GillaPlaces.Current;
		dockedIn = current;
		farSince = -1f;
	}

	private unsafe (Transform, Transform, Transform) SeatHere()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0fa2: Expected Obj, but got I
		//IL_0fc4: Expected Obj, but got I4
		//IL_0ff7: Expected Obj, but got I4
		//IL_1018: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_1043: Expected Obj, but got I
		//IL_106d: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		//IL_10a5: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I4
		//IL_0f28: Expected Obj, but got I4
		//IL_13a3: Expected Obj, but got I
		//IL_13c3: Expected Obj, but got I4
		//IL_13cc: Expected Obj, but got I4
		//IL_0f77: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_12fa: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I4
		//IL_0c91: Expected Obj, but got I
		//IL_0ca1: Expected Obj, but got I
		//IL_1112: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I
		//IL_0d8f: Expected Obj, but got I4
		//IL_0d40: Expected Obj, but got I4
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected Obj, but got Unknown
		//IL_133c: Expected Obj, but got I
		//IL_0cdc: Expected Obj, but got I
		//IL_04b3: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_049e: Expected Obj, but got I4
		//IL_03da: Expected Obj, but got I
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0dfc: Expected VT, but got I4
		//IL_0e07: Expected native int or pointer, but got VT
		//IL_0e1c: Expected native int or pointer, but got VT
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected Obj, but got Unknown
		//IL_12ae: Expected Obj, but got I
		//IL_0ddc: Expected Obj, but got I4
		//IL_0de4: Expected VT, but got Obj
		//IL_0cf7: Expected Obj, but got I
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected Obj, but got Unknown
		//IL_05d5: Expected Obj, but got I4
		//IL_1198: Expected Obj, but got I
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected Obj, but got Unknown
		//IL_052f: Expected Obj, but got I
		//IL_0c5d: Expected Obj, but got Ref
		//IL_0c6b: Expected Obj, but got I4
		//IL_0c74: Expected Obj, but got I4
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected Obj, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_0552: Expected Obj, but got I
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_0e52: Expected Obj, but got Ref
		//IL_0e60: Expected Obj, but got I4
		//IL_064f: Expected Obj, but got I
		//IL_0730: Expected Obj, but got I4
		//IL_1288: Expected Obj, but got I4
		//IL_068a: Expected Obj, but got I
		//IL_07a4: Expected Obj, but got I4
		//IL_07ad: Expected Obj, but got I4
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected Obj, but got Unknown
		//IL_0b10: Expected Obj, but got I4
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected Obj, but got Unknown
		//IL_07d8: Expected Obj, but got I4
		//IL_06ad: Expected Obj, but got I
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_0815: Expected Obj, but got I4
		//IL_0844: Expected Obj, but got I
		//IL_0862: Expected Obj, but got I4
		//IL_086b: Expected Obj, but got I4
		//IL_08a8: Expected Obj, but got I4
		//IL_08d7: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I4
		//IL_08fe: Expected Obj, but got I4
		//IL_093b: Expected Obj, but got I4
		//IL_096a: Expected Obj, but got I
		//IL_0988: Expected Obj, but got I4
		//IL_0991: Expected Obj, but got I4
		//IL_09c3: Expected Obj, but got Ref
		//IL_09d9: Expected Obj, but got I4
		//IL_0a12: Expected Obj, but got I4
		//IL_0a3e: Expected Obj, but got I
		//IL_0ae3: Expected Obj, but got I4
		//IL_0b7b: Expected Obj, but got I
		//IL_0b8b: Expected Obj, but got I
		//IL_0b9b: Expected Obj, but got I
		//IL_0bb5: Expected Obj, but got I4
		//IL_0bde: Expected Obj, but got I4
		//IL_0c03: Expected Obj, but got I
		//IL_0c13: Expected Obj, but got I
		//IL_0c1c: Expected Obj, but got I4
		//IL_0c2c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5;
		object obj7 = default;
		object obj9 = default;
		object obj11 = default;
		Component component;
		Camera camera;
		object obj6;
		object obj8;
		object obj10;
		object obj12;
		UnityEngine.Object obj13;
		if (main != null)
		{
			bool flag2 = (object)main == null;
			obj5 = 0;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = 0;
			obj13 = null;
			camera = main;
			if (flag2)
			{
				goto IL_0e9d;
			}
			component = main;
		}
		else
		{
			component = this;
		}
		Transform transform = component.transform;
		bool flag3 = (object)transform == null;
		obj5 = 0;
		obj6 = obj7;
		obj8 = obj9;
		obj10 = obj11;
		obj12 = 0;
		obj13 = null;
		camera = main;
		Transform transform2 = default;
		Transform transform3 = default;
		object obj20;
		if (!flag3)
		{
			Vector3 position = transform.position;
			object obj14 = obj;
			camera = (Camera)(object)seat;
			transform2 = seatAim;
			transform3 = seatUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v21+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = camera != null;
			bool flag6 = !flag5;
			obj13 = null;
			if (flag6)
			{
				goto IL_0303;
			}
			bool flag7 = (object)seat == null;
			obj5 = 0;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = 0;
			obj13 = null;
			if (!flag7)
			{
				GameObject gameObject = seat.gameObject;
				bool flag8 = (object)gameObject == null;
				obj5 = 0;
				obj6 = obj7;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = 0;
				obj13 = null;
				if (!flag8)
				{
					bool activeInHierarchy = gameObject.activeInHierarchy;
					bool flag9 = !activeInHierarchy;
					obj13 = null;
					if (flag9)
					{
						goto IL_0303;
					}
					bool flag10 = (object)seat == null;
					obj5 = 0;
					obj6 = obj7;
					obj8 = obj9;
					obj10 = obj11;
					obj12 = 0;
					obj13 = null;
					if (!flag10)
					{
						Vector3 position2 = seat.position;
						object obj16 = obj11 - obj11;
						object obj17 = obj9 - obj9;
						obj6 = obj7 - obj7;
						object obj18 = obj16 * obj16;
						object obj19 = obj17 * obj17;
						obj10 = obj18 + obj19;
						obj8 = obj6 * obj6;
						obj20 = obj8 + obj10;
						obj13 = null;
						goto IL_1033;
					}
				}
			}
		}
		goto IL_0e9d;
		IL_1033:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D50]");
		object obj21 = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v26+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v30+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v30+A0]");
		object obj26 = 0;
		object obj27 = obj26;
		bool flag13 = obj26 == null;
		obj5 = 0;
		obj12 = 0;
		if (flag13)
		{
			goto IL_0e9d;
		}
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D58]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v21+12E]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v21+12E]");
		if ((nint)0 == 0)
		{
			goto IL_044a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v21+98]");
		object obj30 = (nint)0 + (nint)8;
		bool flag15 = default;
		bool flag14 = flag15;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X10_v34-8]");
			object obj31 = 0 - obj29;
			bool flag16 = (nint)obj31 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X10_v34-8]");
			if (0 == (nint)obj29)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v21+12E]");
			obj3 = -1;
			obj31 = obj3 - 1;
			flag16 = (nint)obj31 < 0;
			bool flag17 = obj31 == null;
			obj29 = obj30 + 16;
			flag15 = (nint)obj3 != 1;
			flag14 = flag15;
			obj30 = obj29;
			if (flag15)
			{
				continue;
			}
			goto IL_044a;
		}
		obj3 = obj30;
		object obj32 = obj28 + obj30;
		object obj33 = obj32 + 312;
		flag15 = flag14;
		obj29 = obj30;
		obj12 = 0;
		goto IL_1102;
		IL_0ed7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj34 = default;
		OutOfMemoryException ex = default;
		if ((nint)obj13 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj34 = 1;
		}
		else
		{
			if ((nint)obj13 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				(Transform, Transform, Transform) result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj35 = default;
			ex = (OutOfMemoryException)obj35;
		}
		object obj36 = 0;
		goto IL_136e;
		IL_0ebb:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ec9;
		IL_132c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X0_v12+8]");
		obj13 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v747 @ X0_v12] (should have been resolved before IL gen)");
		goto IL_12e0;
		IL_0d2d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj12 = 0;
		goto IL_132c;
		IL_12e0:
		bool flag18 = ex == null;
		object obj37 = !flag18;
		if (obj37 != null)
		{
			goto IL_0ec9;
		}
		bool flag19 = obj34 == null;
		object obj38 = !flag19;
		OutOfMemoryException ex3 = ex;
		(Transform, Transform, Transform) result2;
		System.__Canon item2;
		System.__Canon item;
		if (obj38 == null)
		{
			if ((nint)obj36 != 9)
			{
				bool flag20 = obj36 == null;
				object obj39 = !flag20;
				result2 = ((Transform, Transform, Transform))ex;
				if (obj39 != null)
				{
					goto IL_0e2e;
				}
			}
			(System.__Canon, System.__Canon, System.__Canon) tuple = ((System.__Canon, System.__Canon, System.__Canon))0;
			_ = 0;
			System.Runtime.CompilerServices.Unsafe.Write(&((ValueTuple<System.__Canon, System.__Canon, System.__Canon>*)(nint)tuple)->Item1, null);
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, ((System.__Canon)(object)camera, item, item2));
			result2 = ((Transform, Transform, Transform))tuple;
			goto IL_0e2e;
		}
		goto IL_0ed7;
		IL_0e2e:
		return result2;
		IL_0e9d:
		NullReferenceException ex4 = new NullReferenceException();
		item2 = (System.__Canon)(object)transform3;
		item = (System.__Canon)(object)transform2;
		goto IL_0ebb;
		IL_0ec9:
		ex3 = new OutOfMemoryException();
		goto IL_0ed7;
		IL_136e:
		object obj41 = default;
		object obj40 = obj41;
		if (obj41 == null)
		{
			goto IL_12e0;
		}
		object obj42 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v10+12E]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0d2d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v10+98]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v9-8]");
			if (0 == (nint)obj29)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v10+12E]");
			obj3 = -1;
			obj29 = obj43 + 16;
			bool flag21 = (nint)obj3 != 1;
			obj43 = obj29;
			if (flag21)
			{
				continue;
			}
			goto IL_0d2d;
		}
		obj3 = obj43;
		object obj44 = obj42 + obj43;
		object obj45 = obj44 + 312;
		obj29 = obj43;
		goto IL_132c;
		IL_0c3a:
		item2 = (System.__Canon)(object)transform3;
		item = (System.__Canon)(object)transform2;
		throw new NullReferenceException();
		IL_044a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj12 = 0;
		goto IL_1102;
		IL_0303:
		obj20 = 2139095039;
		obj6 = obj7;
		obj8 = obj9;
		obj10 = obj11;
		goto IL_1033;
		IL_1102:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v31+8]");
		obj13 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v776 @ X0_v31] (should have been resolved before IL gen)");
		object obj46 = default;
		if (obj46 == null)
		{
			goto IL_0c3a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D60]");
		object obj48 = 0;
		object obj49 = obj29;
		object obj50 = obj46;
		object obj51 = obj20;
		object obj52 = obj6;
		object obj53 = obj8;
		object obj54 = obj10;
		Transform transform4 = transform3;
		Transform transform5 = transform2;
		object obj55 = obj12;
		Camera camera2 = camera;
		UnityEngine.Object obj62 = default;
		object obj79 = default;
		while (true)
		{
			obj20 = obj51;
			while (true)
			{
				object obj56 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v29+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v29+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05c2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v29+98]");
				object obj57 = (nint)0 + (nint)8;
				bool flag22 = flag15;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X10_v29-8]");
					object obj31 = 0 - obj47;
					bool flag16 = (nint)obj31 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X10_v29-8]");
					if (0 == (nint)obj47)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v29+12E]");
					obj3 = -1;
					obj31 = obj3 - 1;
					flag16 = (nint)obj31 < 0;
					bool flag17 = obj31 == null;
					obj49 = obj57 + 16;
					flag15 = (nint)obj3 != 1;
					flag22 = flag15;
					obj57 = obj49;
					if (flag15)
					{
						continue;
					}
					goto IL_05c2;
				}
				obj3 = obj57;
				object obj58 = obj56 + obj57;
				object obj59 = obj58 + 312;
				flag15 = flag22;
				obj49 = obj57;
				obj12 = obj55;
				goto IL_1188;
				IL_071d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj12 = 0;
				goto IL_1254;
				IL_0e41:
				NullReferenceException ex5 = new NullReferenceException();
				obj41 = (object)(&obj5);
				ex = null;
				obj34 = 0;
				obj29 = obj49;
				obj6 = obj52;
				obj8 = obj53;
				obj10 = obj54;
				transform3 = transform4;
				transform2 = transform5;
				camera = camera2;
				goto IL_0e9d;
				IL_1254:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1045 @ X0_v45] (should have been resolved before IL gen)");
				object obj60 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v48+E4]");
				bool flag23 = (nint)0 == 0;
				object obj61 = !flag23;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag24 = obj62 == null;
				bool flag25 = !flag24;
				object obj63 = !flag25;
				obj55 = 0;
				obj13 = null;
				if (obj63 == null)
				{
					bool flag26 = (object)obj62 == null;
					obj12 = 0;
					obj13 = null;
					if (flag26)
					{
						goto IL_0e41;
					}
					object obj64 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X0_v53+E4]");
					bool flag27 = (nint)0 == 0;
					object obj65 = !flag27;
					if (obj65 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+20]");
					bool flag28 = (UnityEngine.Object)0 == null;
					bool flag29 = !flag28;
					object obj66 = !flag29;
					obj55 = 0;
					obj13 = null;
					if (obj66 == null)
					{
						object obj67 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ X0_v57+E4]");
						bool flag30 = (nint)0 == 0;
						object obj68 = !flag30;
						if (obj68 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+28]");
						bool flag31 = (UnityEngine.Object)0 == null;
						bool flag32 = !flag31;
						object obj69 = !flag32;
						obj55 = 0;
						obj13 = null;
						if (obj69 == null)
						{
							object obj70 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X0_v61+E4]");
							bool flag33 = (nint)0 == 0;
							object obj71 = !flag33;
							if (obj71 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+30]");
							bool flag34 = (UnityEngine.Object)0 == null;
							bool flag35 = !flag34;
							object obj72 = !flag35;
							obj55 = 0;
							obj13 = null;
							if (obj72 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+20]");
								bool flag36 = (nint)0 == 0;
								obj41 = (object)(&obj5);
								obj5 = obj46;
								ex = null;
								obj34 = 0;
								obj29 = obj49;
								obj6 = obj52;
								obj8 = obj53;
								obj10 = obj54;
								item2 = (System.__Canon)(object)transform4;
								item = (System.__Canon)(object)transform5;
								obj12 = 0;
								obj13 = null;
								camera = camera2;
								if (flag36)
								{
									goto IL_0ebb;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+20]");
								Vector3 position3 = ((Transform)0).position;
								object obj73 = obj54 - obj11;
								object obj74 = obj53 - obj9;
								obj52 -= obj7;
								object obj75 = obj73 * obj73;
								object obj76 = obj74 * obj74;
								obj54 = obj75 + obj76;
								obj53 = obj52 * obj52;
								obj20 = obj53 + obj54;
								object obj31 = obj20 - obj51;
								bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51);
								bool flag17 = obj31 == null;
								obj55 = 0;
								obj13 = null;
								if (flag16)
								{
									goto IL_0b6b;
								}
							}
						}
					}
				}
				bool flag37 = obj46 == null;
				object obj77 = !flag37;
				obj50 = obj46;
				if (obj77 != null)
				{
					continue;
				}
				goto IL_0b26;
				IL_05c2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj12 = 0;
				goto IL_1188;
				IL_1188:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X0_v39+8]");
				obj13 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v973 @ X0_v39] (should have been resolved before IL gen)");
				object obj78 = obj79 & 1;
				bool flag38 = obj78 == null;
				obj29 = obj49;
				obj6 = obj52;
				obj8 = obj53;
				obj10 = obj54;
				item2 = (System.__Canon)(object)transform4;
				item = (System.__Canon)(object)transform5;
				camera = camera2;
				if (flag38)
				{
					break;
				}
				if (obj46 != null)
				{
					object obj80 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X8_v33+12E]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X8_v33+12E]");
					if ((nint)0 == 0)
					{
						goto IL_071d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X8_v33+98]");
					object obj81 = (nint)0 + (nint)8;
					bool flag39 = flag15;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X10_v24-8]");
						object obj31 = 0 - obj48;
						bool flag16 = (nint)obj31 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X10_v24-8]");
						if (0 == (nint)obj48)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X8_v33+12E]");
						obj3 = -1;
						obj31 = obj3 - 1;
						flag16 = (nint)obj31 < 0;
						bool flag17 = obj31 == null;
						obj49 = obj81 + 16;
						flag15 = (nint)obj3 != 1;
						flag39 = flag15;
						obj81 = obj49;
						if (flag15)
						{
							continue;
						}
						goto IL_071d;
					}
					obj3 = obj81;
					object obj82 = obj80 + obj81;
					object obj83 = obj82 + 312;
					flag15 = flag39;
					obj49 = obj81;
					goto IL_1254;
				}
				NullReferenceException ex6 = new NullReferenceException();
				goto IL_0e41;
			}
			break;
			IL_0b26:
			obj29 = obj49;
			obj6 = obj52;
			obj8 = obj53;
			obj10 = obj54;
			transform3 = transform4;
			transform2 = transform5;
			obj12 = obj55;
			camera = camera2;
			goto IL_0c3a;
			IL_0b6b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+20]");
			camera = (Camera)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+28]");
			transform2 = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+30]");
			transform3 = (Transform)0;
			bool flag40 = obj46 == null;
			object obj84 = !flag40;
			obj29 = obj49;
			obj6 = obj52;
			obj8 = obj53;
			obj10 = obj54;
			obj12 = 0;
			obj13 = null;
			obj50 = obj46;
			obj51 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+30]");
			transform4 = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+28]");
			transform5 = (Transform)0;
			obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v47 (UnityEngine.Object)+20]");
			camera2 = (Camera)0;
			if (obj84 != null)
			{
				continue;
			}
			goto IL_0c3a;
		}
		obj41 = (object)(&obj5);
		ex = null;
		obj34 = 0;
		obj36 = 9;
		goto IL_136e;
	}

	public unsafe void ComeToYou(bool now = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_09d3: Expected Obj, but got I
		//IL_09eb: Expected Obj, but got I
		//IL_00f4: Expected I4, but got I8
		//IL_0e50: Expected Obj, but got I
		//IL_0e6d: Expected Obj, but got I
		//IL_0e7d: Expected Obj, but got I
		//IL_0eaf: Expected Obj, but got I
		//IL_0ebf: Expected Obj, but got I
		//IL_0ef3: Expected Obj, but got I4
		//IL_0a62: Expected Obj, but got I
		//IL_0a6b: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0fe7: Expected Obj, but got I
		//IL_1011: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_03a2: Expected Obj, but got I4
		//IL_0a91: Expected Obj, but got I
		//IL_0abd: Invalid comparison between I and F8
		//IL_0f1e: Expected Obj, but got I
		//IL_0f3b: Expected Obj, but got I
		//IL_0f53: Expected Obj, but got I
		//IL_0f7d: Expected Obj, but got I
		//IL_0fb8: Expected Obj, but got I
		//IL_0fc9: Expected Obj, but got I4
		//IL_03fe: Expected F8, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I4
		//IL_0b67: Expected Obj, but got I
		//IL_0b8b: Expected Obj, but got I
		//IL_1076: Expected Obj, but got I4
		//IL_0cf1: Invalid comparison between F8 and I
		//IL_0464: Expected Obj, but got I
		//IL_046c: Expected F8, but got Obj
		//IL_047c: Expected F8, but got I
		//IL_048c: Expected F8, but got I
		//IL_10ae: Expected Obj, but got I4
		//IL_04b0: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I4
		//IL_0510: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I4
		//IL_057a: Expected VT, but got I4
		//IL_057a: Expected VT, but got Ref
		//IL_0d17: Expected VT, but got F8
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Expected Obj, but got Unknown
		//IL_0dfe: Expected Obj, but got I
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected Obj, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected Obj, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected Obj, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_070b: Expected Obj, but got I
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_077f: Expected Obj, but got I
		//IL_07a9: Expected Obj, but got I
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_0810: Expected Obj, but got I
		//IL_0883: Expected VT, but got F8
		//IL_10e6: Expected Obj, but got I4
		//IL_08f9: Expected VT, but got F8
		//IL_08c1: Expected VT, but got I
		//IL_05cc: Invalid comparison between F8 and I
		//IL_092e: Expected VT, but got F8
		//IL_062d: Expected Obj, but got I
		//IL_0635: Expected F8, but got Obj
		//IL_0645: Expected F8, but got I
		//IL_0655: Expected F8, but got I
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item != null)
		{
			GillaItem gillaItem = item;
			if ((int)(gillaItem.Hand__BackingField & 0x80000000L) == 0)
			{
				return;
			}
		}
		Transform transform = main.transform;
		Vector3 forward = transform.forward;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v10+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+18]");
		object obj10 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+1C]");
		object obj11 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = obj10 + obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+20]");
		object obj15 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v13+A0]");
		object obj16 = 0;
		object obj17 = obj15 + obj14;
		bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
		object obj19 = default;
		object obj18 = obj19;
		object obj21 = default;
		object obj20 = obj21;
		object obj22 = 0;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+18]");
			object obj23 = (nint)0 * (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+1C]");
			object obj24 = obj21 * 0;
			object obj25 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+20]");
			object obj26 = obj25 * 0;
			object obj27 = obj23 + obj24;
			object obj28 = obj26 + obj27;
			object obj29 = obj28 / obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+18]");
			object obj30 = 0 * obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+1C]");
			object obj31 = 0 * obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v11+20]");
			object obj32 = 0 * obj29;
			obj22 = 0 - obj30;
			obj20 = obj21 - obj31;
			obj18 = obj19 - obj32;
			obj19 = obj31;
		}
		object obj33 = obj22 * obj22;
		object obj34 = obj20 * obj20;
		object obj35 = obj33 + obj34;
		object obj36 = obj18 * obj18;
		object obj37 = obj35 + obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		bool flag6 = (nint)obj37 >= 0;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		object obj39 = 0;
		object obj40 = 0;
		if (!flag6)
		{
			Vector3 up = transform.up;
			object obj41 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v69+A0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+18]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+18]");
			object obj43 = num4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+1C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+1C]");
			object obj44 = num5 * 0;
			object obj45 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v72+A0]");
			object obj46 = 0;
			object obj47 = obj43 + obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+20]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+20]");
			object obj48 = num6 * 0;
			obj38 = obj48 + obj47;
			obj39 = obj46;
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46);
			obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			obj20 = 0;
			obj22 = obj37;
			obj40 = 0;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+18]");
				object obj49 = obj37 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+1C]");
				object obj50 = num7 * 0;
				object obj51 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+20]");
				object obj26 = obj51 * 0;
				object obj52 = obj49 + obj50;
				object obj53 = obj26 + obj52;
				object obj54 = obj53 / obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+18]");
				obj39 = 0 * obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+1C]");
				object obj55 = 0 * obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v70+20]");
				obj38 = 0 * obj54;
				obj22 = obj37 - obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				obj20 = 0 - obj55;
				obj18 = obj19 - obj38;
				obj19 = obj55;
				obj40 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj56 = 0;
		object obj57 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v21+E4]");
		bool flag8 = (nint)0 == 0;
		object obj58 = !flag8;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj59 = obj22 * obj22;
		object obj60 = obj20 * obj20;
		object obj61 = obj59 + obj60;
		object obj62 = obj18 * obj18;
		object obj63 = obj61 + obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		bool flag9 = (nint)obj63 <= 0;
		object obj64 = 0;
		object obj65 = 0;
		object obj66 = 0;
		if (!flag9)
		{
			obj66 = obj22 / obj63;
			obj65 = obj20 / obj63;
			obj64 = obj18 / obj63;
		}
		Vector3 lossyScale = transform.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		double num8;
		if (0.0 < 1.0)
		{
			num8 = 1.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num8 = 0.0;
		}
		Vector3 position = transform.position;
		double num9 = (double)obj66 * 0.5;
		double num10 = (double)obj65 * 0.5;
		double num11 = (double)obj64 * 0.5;
		double num12 = num9 * num8;
		double num13 = num10 * num8;
		double num14 = num11 * num8;
		object obj67 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		object obj68 = 0;
		double num15 = 1.0 + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v23+A0]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		double num16 = 0.0 + num13;
		double num17 = (double)obj19 + num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v24+20]");
		double num18 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		double num19 = num18 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v24+18]");
		float num20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num21 = num20 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v24+1C]");
		float num22 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num23 = num22 * 0f;
		double num24 = num8 * (double)num21;
		double num25 = num8 * (double)num23;
		double num26 = num8 * num19;
		Vector3 position2 = transform.position;
		Vector3 position3 = transform.position;
		double num27 = num15 - num24;
		double num28 = num16 - num25;
		double num29 = num17 - num26;
		object obj70 = obj56;
		double num30 = num28 - (double)num23;
		double num31 = num29 - num19;
		double num32 = num27 - (double)num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v34+E4]");
		bool flag10 = (nint)0 == 0;
		object obj71 = !flag10;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num25 = num30;
		}
		double num33 = num32 * num32;
		double num34 = num30 * num30;
		double num35 = num33 + num34;
		double num36 = num31 * num31;
		double num37 = num35 + num36;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num38 = num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if (num38 > 0.0)
		{
			double num39 = num32 / num25;
			double num40 = num30 / num25;
			double num41 = num31 / num25;
		}
		else
		{
			object obj72 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v61+A0]");
			object obj73 = 0;
			double num39 = (double)obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v62+4]");
			double num40 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v62+8]");
			double num41 = 0.0;
		}
		object obj74 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v37+E4]");
		bool flag11 = (nint)0 == 0;
		object obj75 = !flag11;
		if (obj75 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj76 = 0;
		object obj77 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v40+E4]");
		bool flag12 = (nint)0 == 0;
		object obj78 = !flag12;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num42 = Solid();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj79 = 0;
		object obj80 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v39+E4]");
		bool flag13 = (nint)0 == 0;
		object obj81 = !flag13;
		if (obj81 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj82 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		if (Physics.SphereCast((Vector3)(&obj82), num21, (Vector3)num42, out *(RaycastHit*)1, num23, 0, queryTriggerInteraction))
		{
			Vector3 position4 = transform.position;
			object obj83 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X0_v71+E4]");
			bool flag14 = (nint)0 == 0;
			object obj84 = !flag14;
			if (obj84 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num43 = num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			double num44;
			double num45;
			double num46;
			if (num43 > 0.0)
			{
				num44 = num32 / num25;
				num45 = num30 / num25;
				num46 = num31 / num25;
			}
			else
			{
				object obj85 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v56+A0]");
				object obj86 = 0;
				num44 = (double)obj86;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v57+4]");
				num45 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v57+8]");
				num46 = 0.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
			object obj87 = default;
			obj68 = obj87 + 0;
			object obj88 = obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			if ((nint)obj88 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				obj68 = 0;
			}
			double num47 = num44 * (double)obj68;
			double num48 = num45 * (double)obj68;
			double num49 = num46 * (double)obj68;
			num27 = (double)num21 + num47;
			num28 = (double)num23 + num48;
			num29 = num19 + num49;
			num19 = num49;
		}
		flyTo = (Vector3)num27;
		object obj89 = this + 324;
		Vector3 position5 = transform.position;
		object obj90 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v43+A0]");
		object obj91 = 0;
		Vector3 forward2 = default;
		Vector3 upwards = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
		Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
		Quaternion quaternion3 = Quaternion.Internal_Inverse(ref *(Quaternion*)(&forward2));
		object obj92 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+158]");
		object obj93 = obj92 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+18]");
		object obj94 = 0 * obj68;
		object obj95 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+14C]");
		object obj96 = obj95 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+20]");
		object obj97 = 0 * obj68;
		object obj98 = obj68 * deviceUp;
		double num50 = num19 * (double)obj68;
		object obj99 = obj68 * obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+18]");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+158]");
		object obj100 = num51 * 0;
		object obj101 = obj93 + obj94;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+20]");
		object obj102 = 0 * deviceUp;
		object obj103 = obj96 + obj97;
		double num52 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+158]");
		double num53 = num52 * 0.0;
		double num54 = (double)obj98 + num50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+18]");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+14C]");
		object obj104 = num55 * 0;
		object obj105 = obj99 - obj100;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+20]");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+14C]");
		object obj106 = num56 * 0;
		double num57 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+14C]");
		double num58 = num57 * 0.0;
		object obj107 = obj102 + obj101;
		double num59 = num53 + (double)obj103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+18]");
		object obj108 = 0 * deviceUp;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v44+20]");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+158]");
		object obj109 = num60 * 0;
		double num61 = (double)obj104 + num54;
		double num62 = num19 * (double)deviceUp;
		object obj110 = obj105 - obj106;
		double num63 = (double)obj107 - num58;
		double num64 = num59 - (double)obj108;
		double num65 = num61 - (double)obj109;
		double num66 = (double)obj110 - num62;
		flyToTurn = (Quaternion)num63;
		if (now)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X22_v9+F8]");
			flyFrom = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+244]");
			_ = 0;
		}
		else
		{
			Transform transform2 = base.transform;
			Vector3 position6 = transform2.position;
			flyFrom = (Vector3)num63;
			Transform transform3 = base.transform;
			Quaternion rotation = transform3.rotation;
		}
		flyFromTurn = (Quaternion)num63;
		flyT = 0f;
		docked = false;
		farSince = -1f;
		int current = GillaPlaces.Current;
		startedIn = current;
		dirty = true;
	}

	private void Fly()
	{
		//IL_0229: Invalid comparison between F4 and I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_011a: Invalid comparison between F4 and I4
		//IL_0129: Invalid comparison between F4 and I4
		//IL_0141: Expected Obj, but got F8
		//IL_014e: Expected Obj, but got F4
		//IL_0183: Expected Obj, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_029b: Invalid comparison between F4 and I4
		//IL_00af: Expected I4, but got I8
		//IL_01eb: Expected VT, but got I4
		//IL_01eb: Expected VT, but got I4
		if (flyT < 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item != null)
		{
			GillaItem gillaItem = item;
			if ((int)(gillaItem.Hand__BackingField & 0x80000000L) == 0)
			{
				goto IL_020e;
			}
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		float num = unscaledDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num2 = num / 0f;
		float num3 = flyT + num2;
		float num4 = num3 - 1f;
		bool flag2 = num4 < 0f;
		bool flag3 = num4 == 0f;
		object obj4 = (double)num3 ^ 1.0;
		object obj5 = num3 ^ num4;
		object obj6 = obj4 & obj5;
		bool flag4 = (nint)obj6 < 0;
		bool flag5 = flag2 == flag4;
		object obj7 = !flag3;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			num3 = 1f;
		}
		float num5 = num3 + num3;
		float num6 = num3 * num3;
		flyT = num3;
		double num7 = 3.0 - (double)num5;
		float num8 = num6 * (float)num7;
		Transform transform = base.transform;
		if (num8 < 0f || !((double)num8 > 1.0))
		{
			Quaternion a = default;
			Quaternion b = default;
			Quaternion quaternion = Quaternion.Internal_Slerp(ref a, ref b, num8);
		}
		transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
		if (!((double)flyT < 1.0))
		{
			goto IL_020e;
		}
		return;
		IL_020e:
		flyT = -1f;
	}

	public void GoHome()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0078: Expected I4, but got I8
		//IL_0092: Expected Obj, but got I4
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
		if (item != null)
		{
			GillaItem gillaItem = item;
			int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				GillaHands.Drop(gillaItem);
			}
		}
		Dock();
	}

	private unsafe void Update()
	{
		//IL_0cf5: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got Ref
		//IL_005c: Expected Obj, but got Ref
		//IL_0065: Expected Obj, but got I4
		//IL_0d0d: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9A60]");
		object obj = 0;
		Trace();
		System.__Canon _Canon = null;
		bool lockTaken = default;
		Monitor.Enter(later, ref lockTaken);
		Queue<System.__Canon> queue = (Queue<System.__Canon>)(object)later;
		if ((object)later != null)
		{
			if (queue._size != 0)
			{
				UnityEngine.Object obj2 = (UnityEngine.Object)obj;
				System.__Canon _Canon2 = ((Queue<System.__Canon>)(object)later).Dequeue();
				_Canon = _Canon2;
				object obj3 = 5;
			}
			else
			{
				UnityEngine.Object obj2 = (UnityEngine.Object)(&lockTaken);
				object obj3 = 4;
			}
			object obj4 = (object)(&lockTaken);
			if (obj4 != null)
			{
				object obj6 = default;
				object obj5 = (object)(&obj6);
				Monitor.Exit(obj5);
				UnityEngine.Object obj2 = null;
			}
			object obj7 = 0;
			OutOfMemoryException ex = new OutOfMemoryException();
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		}
		else
		{
			NullReferenceException ex3 = new NullReferenceException();
			object obj7 = 0;
			UnityEngine.Object obj2 = (UnityEngine.Object)(&lockTaken);
			IndexOutOfRangeException ex2 = (IndexOutOfRangeException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private void LetGo()
	{
		//IL_0187: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		int current = GillaPlaces.Current;
		startedIn = current;
		bool flag = (byte)(~(hidden ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		(Transform, Transform, Transform) tuple = SeatHere();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = default;
		if (obj5 != null)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Vector3 position2 = ((Transform)obj5).position;
			object obj7 = default;
			object obj6 = obj7 - obj7;
			object obj9 = default;
			object obj8 = obj9 - obj9;
			object obj11 = default;
			object obj10 = obj11 - obj11;
			object obj12 = obj6 * obj6;
			object obj13 = obj8 * obj8;
			object obj14 = obj12 + obj13;
			object obj15 = obj10 * obj10;
			object obj16 = obj15 + obj14;
			if ((nint)obj16 < 1031798784)
			{
				equipped = false;
				Dock();
			}
		}
	}

	private unsafe static void ReadLeft(out bool x, out float grip)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I4
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected Obj, but got I
		//IL_04c9: Expected F4, but got I4
		//IL_04db: Expected VT, but got I4
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected F4, but got I4
		//IL_00f7: Expected VT, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected I, but got Obj
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I4
		//IL_07d3: Expected Obj, but got I4
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected VT, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Invalid comparison between Unknown and I4
		//IL_02e9: Expected Obj, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Ref
		//IL_017d: Expected Obj, but got I4
		//IL_065b: Expected Obj, but got I
		//IL_0674: Expected VT, but got I
		//IL_0692: Expected Obj, but got I4
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_06f4: Expected Obj, but got I4
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected VT, but got I
		//IL_0873: Expected Obj, but got I4
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected VT, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got I4
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I
		//IL_0392: Expected Obj, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Invalid comparison between F4 and I4
		//IL_0200: Invalid comparison between F4 and I4
		//IL_0218: Expected Obj, but got F4
		//IL_022a: Expected Obj, but got F4
		//IL_025f: Expected Obj, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0741: Expected Obj, but got I
		//IL_0751: Expected Obj, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Ref, but got Unknown
		//IL_0713: Expected Obj, but got I4
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected VT, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Invalid comparison between F4 and I4
		//IL_042b: Invalid comparison between F4 and I4
		//IL_0443: Expected Obj, but got F4
		//IL_0455: Expected Obj, but got F4
		//IL_048a: Expected Obj, but got I4
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_0780: Expected Ref, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		ref bool reference = ref *(bool*)null;
		ref float reference2 = ref *(float*)null;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v17 (System.Collections.Generic.LowLevelDictionary`2<UnityEngine.XR.InputDevice>+Enumerator<UnityEngine.XR.InputDevice>)+60]");
		List<UnityEngine.XR.InputDevice> list = (List<UnityEngine.XR.InputDevice>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v17 (System.Collections.Generic.LowLevelDictionary`2<UnityEngine.XR.InputDevice>+Enumerator<UnityEngine.XR.InputDevice>)+60]");
		float value;
		Enumerator<, > val6 = default;
		bool value2;
		UnityEngine.XR.InputDevice inputDevice;
		Enumerator<, > val4;
		object obj7;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X1_v10 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+1C]");
			object obj4 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v17 (System.Collections.Generic.LowLevelDictionary`2<UnityEngine.XR.InputDevice>+Enumerator<UnityEngine.XR.InputDevice>)+60]");
			InputDevices.GetDevicesWithCharacteristics((InputDeviceCharacteristics)320u, (List<UnityEngine.XR.InputDevice>)0);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v23+A0]");
			val = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v17 (System.Collections.Generic.LowLevelDictionary`2<UnityEngine.XR.InputDevice>+Enumerator<UnityEngine.XR.InputDevice>)+60]");
			bool flag2 = (nint)0 == 0;
			nint num = unchecked((nint)null);
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v17 (System.Collections.Generic.LowLevelDictionary`2<UnityEngine.XR.InputDevice>+Enumerator<UnityEngine.XR.InputDevice>)+60]");
				Enumerator<, > enumerator = ((List<UnityEngine.XR.InputDevice>)0).GetEnumerator();
				value = 0f;
				value2 = false;
				inputDevice = (UnityEngine.XR.InputDevice)0;
				Enumerator<, > val3 = default;
				Enumerator<, > val2 = val3;
				Enumerator<, > val5 = default;
				val4 = val5;
				num = unchecked((nint)null);
				val = (Enumerator<, >)(ref val6);
				while (val6.MoveNext())
				{
					bool isValid = inputDevice.isValid;
					bool flag3 = !isValid;
					inputDevice = (UnityEngine.XR.InputDevice)val3;
					val4 = val3;
					if (flag3)
					{
						continue;
					}
					object obj8 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v42+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj8 = obj6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v42+A0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v31+8]");
					bool flag5 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out value2);
					bool flag6 = !value2;
					object obj11 = !flag6;
					object obj12 = flag5 & obj11;
					object obj13 = obj12 & 1;
					if (obj13 != null)
					{
						reference = ref *(bool*)1;
					}
					object obj14 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v46+E4]");
					bool flag7 = (nint)0 == 0;
					object obj15 = !flag7;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj14 = obj6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v46+A0]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v17 (System.Collections.Generic.LowLevelDictionary`2<UnityEngine.XR.InputDevice>+Enumerator<UnityEngine.XR.InputDevice>)+80]");
					bool flag8 = inputDevice.TryGetFeatureValue((InputFeatureUsage<float>)0, out value);
					bool flag9 = !flag8;
					object obj16 = 0;
					inputDevice = (UnityEngine.XR.InputDevice)val3;
					val4 = val3;
					num = (nint)(&value);
					if (!flag9)
					{
						val4 = (Enumerator<, >)grip;
						float num2 = grip - value;
						bool flag10 = num2 < 0f;
						bool flag11 = num2 == 0f;
						object obj17 = grip ^ value;
						object obj18 = grip ^ num2;
						object obj19 = obj17 & obj18;
						bool flag12 = (nint)obj19 < 0;
						bool flag13 = flag10 == flag12;
						object obj20 = !flag11;
						object obj21 = flag13 & obj20;
						object obj22 = ~obj21;
						if (obj22 != null)
						{
							val4 = (Enumerator<, >)value;
						}
						reference2 = ref *(float*)val4;
						obj16 = 0;
						inputDevice = (UnityEngine.XR.InputDevice)val3;
						val2 = (Enumerator<, >)value;
						num = (nint)(&value);
					}
				}
				Enumerator<, > val7 = (Enumerator<, >)0;
				val6 = val5;
				object obj23 = 0;
				Enumerator<, > val8 = (Enumerator<, >)(ref val6);
				object obj24 = 5;
				object obj25 = 0;
				ButtonControl buttonControl = default;
				InputControl<float> inputControl = default;
				object obj39 = default;
				while (true)
				{
					list = (List<UnityEngine.XR.InputDevice>)obj7;
					val6.Dispose();
					bool flag14 = obj25 == null;
					object obj26 = !flag14;
					val3 = val7;
					if (obj26 == null)
					{
						bool flag15 = (int)val7 == 0;
						object obj27 = !flag15;
						val3 = val7;
						OutOfMemoryException ex = (OutOfMemoryException)(&val6);
						if (obj27 == null)
						{
							if ((nint)obj24 != 5)
							{
								bool flag16 = obj24 == null;
								object obj28 = !flag16;
								if (obj28 != null)
								{
									return;
								}
							}
							XRController leftHand = XRController.leftHand;
							if (leftHand == null)
							{
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9380]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EE0]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
							if (buttonControl != null && buttonControl.isPressed)
							{
								reference = ref *(bool*)1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F18]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8ED8]");
							object obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
							if (inputControl != null)
							{
								float num3 = inputControl.ReadValue();
								float num4 = grip - num3;
								bool flag17 = num4 < 0f;
								bool flag18 = num4 == 0f;
								object obj33 = grip ^ num3;
								object obj34 = grip ^ num4;
								object obj35 = obj33 & obj34;
								bool flag19 = (nint)obj35 < 0;
								bool flag20 = flag17 == flag19;
								object obj36 = !flag18;
								object obj37 = flag20 & obj36;
								object obj38 = ~obj37;
								if (obj38 == null)
								{
									num3 = grip;
								}
								reference2 = ref *(float*)num3;
							}
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)list == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						val3 = (Enumerator<, >)1;
						val = (Enumerator<, >)1;
						obj25 = obj23;
					}
					else
					{
						if ((nint)list != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj25 = obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj23 = obj39;
					}
					val7 = val3;
					obj24 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EC00");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
		}
		value = 0f;
		value2 = false;
		inputDevice = (UnityEngine.XR.InputDevice)0;
		val6 = (Enumerator<, >)0;
		val4 = (Enumerator<, >)0;
		obj7 = 109895680;
		throw new NullReferenceException();
	}

	private void XInput(bool down, float grip)
	{
		//IL_0096: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_00f9: Invalid comparison between F4 and I4
		//IL_010a: Expected Obj, but got I4
		if (down)
		{
			bool flag = (double)grip < 0.5;
			if (~(xWas ? 1u : 0u) == 0)
			{
				if (!flag)
				{
					xSpoilt = true;
				}
			}
			else
			{
				bool flag2 = !flag;
				float unscaledTime = Time.unscaledTime;
				xSpoilt = flag2;
				xDownAt = unscaledTime;
			}
		}
		else if (~(xWas ? 1u : 0u) == 0)
		{
			bool flag3 = (byte)(~(xSpoilt ? 1u : 0u)) != 0;
			object obj = !flag3;
			if (obj == null)
			{
				float unscaledTime2 = Time.unscaledTime;
				float num = unscaledTime2 - xDownAt;
				bool flag4 = (double)num < 0.5;
				object obj2 = !flag4;
				float num2 = num - 0.5f;
				bool flag5 = num2 == 0f;
				object obj3 = !flag5;
				object obj4 = obj2 & obj3;
				if (obj4 == null)
				{
					TapX();
				}
			}
		}
		xWas = down;
	}

	public void XInputForTest(bool down, float grip)
	{
		XInput(down, grip);
	}

	public void TapX()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0105: Expected F4, but got I
		//IL_0105: Expected F4, but got I
		if (~(equipped ? 1u : 0u) == 0)
		{
			if (~(hidden ? 1u : 0u) == 0)
			{
				hidden = false;
				Showing(on: true);
				object obj = this + 408;
				shown = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				dirty = true;
			}
			else if (~(docked ? 1u : 0u) != 0)
			{
				Hide();
				goto IL_00a2;
			}
			ComeToYou(now: false);
			goto IL_00a2;
		}
		return;
		IL_00a2:
		UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)4);
		UnityEngine.XR.InputDevice inputDevice = default;
		if (inputDevice.isValid)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			bool flag = inputDevice.SendHapticImpulse(0u, num, 0f);
		}
	}

	private void Hide()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0077: Expected I4, but got I8
		//IL_0091: Expected Obj, but got I4
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
		if (item != null)
		{
			GillaItem gillaItem = item;
			int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				GillaHands.Drop(gillaItem);
			}
		}
		flyT = -1f;
		hidden = true;
		Showing(on: false);
	}

	private void Show()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		hidden = false;
		Showing(on: true);
		object obj = this + 408;
		shown = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		dirty = true;
	}

	private unsafe void Showing(bool on)
	{
		//IL_0aef: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got I
		//IL_0222: Expected I4, but got Obj
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected I4, but got Obj
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got I4
		//IL_05bf: Expected Obj, but got I4
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got I4
		//IL_0768: Expected Obj, but got I4
		//IL_0bd0: Expected Obj, but got I
		//IL_0bd8: Expected I4, but got Obj
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Expected Ref, but got Unknown
		//IL_0bfb: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_07b2: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_00c9: Expected I, but got Obj
		//IL_0b59: Expected Obj, but got I4
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got I4
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_07d9: Expected I, but got Obj
		//IL_00eb: Expected I, but got Obj
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected I, but got Obj
		//IL_0148: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_0a7a: Expected Obj, but got I4
		//IL_0651: Expected Obj, but got I4
		//IL_0864: Expected I, but got Obj
		//IL_054a: Expected Obj, but got I
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0ad9: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I
		//IL_038c: Expected I, but got Obj
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got I4
		//IL_03c7: Expected I4, but got Obj
		//IL_0400: Expected I, but got Obj
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got I8
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Obj, but got Unknown
		//IL_08c5: Expected I, but got Obj
		//IL_08ce: Expected Obj, but got I4
		//IL_0b8f: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I
		//IL_0525: Expected Obj, but got I
		//IL_08f3: Expected Obj, but got I
		//IL_0915: Expected Obj, but got I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04b6: Expected Obj, but got I
		//IL_0954: Expected I, but got Obj
		//IL_09bf: Expected Obj, but got I4
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_097f: Expected I, but got Obj
		//IL_09a8: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		List<System.__Canon> list = (List<System.__Canon>)(object)hiddenLooks;
		Enumerator<, > val;
		UnityEngine.Object obj5 = default;
		GillaLivCamera gillaLivCamera;
		nint num;
		bool flag2;
		UnityEngine.Object obj6;
		if (on)
		{
			bool flag = (object)hiddenLooks == null;
			val = (Enumerator<, >)0;
			flag2 = on;
			gillaLivCamera = this;
			if (!flag)
			{
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)hiddenLooks).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
				object obj2 = 0;
				Enumerator<, > val2 = default;
				object obj7;
				Enumerator<, > val3;
				Enumerator<, > val4;
				int num2;
				while (val.MoveNext())
				{
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v61+E4]");
					bool flag3 = (nint)0 == 0;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj5 != null;
					bool flag5 = !flag4;
					num = unchecked((nint)null);
					if (flag5)
					{
						continue;
					}
					bool flag6 = (object)obj5 == null;
					num = unchecked((nint)null);
					obj6 = null;
					val = val2;
					obj7 = 0;
					num2 = (int)(&val);
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					flag2 = false;
					gillaLivCamera = this;
					if (!flag6)
					{
						((Renderer)obj5).enabled = true;
						num = unchecked((nint)null);
						continue;
					}
					goto IL_0a10;
				}
				obj6 = null;
				val = val2;
				object obj8 = 9;
				obj7 = 0;
				num2 = (int)(&val);
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				gillaLivCamera = this;
				object obj9 = 0;
				object obj13 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
					object obj10 = 0;
					flag2 = (byte)(int)obj10 != 0;
					((Enumerator<, >*)val4)->Dispose();
					bool flag7 = obj9 == null;
					object obj11 = !flag7;
					if (obj11 == null)
					{
						bool flag8 = (object)obj6 == null;
						object obj12 = !flag8;
						OutOfMemoryException ex = (OutOfMemoryException)val4;
						if (obj12 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch (flag2)
					{
					case true:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj6 = (UnityEngine.Object)1;
						obj9 = obj7;
						break;
					case true:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj9 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj7 = obj13;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D088");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					obj8 = 0;
				}
				if ((nint)obj8 != 9)
				{
					bool flag9 = obj8 == null;
					object obj14 = !flag9;
					if (obj14 != null)
					{
						return;
					}
				}
				List<Renderer> list2 = gillaLivCamera.hiddenLooks;
				bool flag10 = (object)gillaLivCamera.hiddenLooks == null;
				obj5 = obj6;
				if (!flag10)
				{
					int size = list2._size;
					num2 = list2._version + 1;
					list2._size = 0;
					list2._version = num2;
					bool flag11 = list2._size < 1;
					obj5 = obj6;
					int num3 = (flag2 ? 1 : 0);
					if (!flag11)
					{
						Array.Clear(list2._items, 0, list2._size);
						object obj15 = 0;
						obj5 = obj6;
						num3 = 0;
					}
					goto IL_073e;
				}
			}
		}
		else
		{
			bool flag12 = (object)hiddenLooks == null;
			val = (Enumerator<, >)0;
			flag2 = on;
			gillaLivCamera = this;
			if (!flag12)
			{
				int size = list._size;
				int version = list._version + 1;
				list._size = 0;
				list._version = version;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
					object obj15 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
				object obj16 = 0;
				flag2 = (byte)(int)obj16 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
				object obj17 = default;
				bool flag13 = obj17 == null;
				num = size;
				val = (Enumerator<, >)0;
				gillaLivCamera = this;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v47+18]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v47+18]");
					bool flag14 = (nint)0 < (nint)1;
					val = (Enumerator<, >)0;
					int num3 = (int)obj16;
					gillaLivCamera = this;
					if (flag14)
					{
						goto IL_073e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
					object obj19 = 0;
					object obj20 = 0;
					num = size;
					while (true)
					{
						bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
						object obj21 = !flag15;
						val = (Enumerator<, >)0;
						gillaLivCamera = this;
						if (obj21 != null)
						{
							break;
						}
						object obj22 = obj17 + obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v30+20]");
						bool flag16 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						gillaLivCamera = this;
						if (!flag16)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v30+20]");
							bool flag17 = ((Renderer)0).enabled;
							bool flag18 = !flag17;
							size = (int)num;
							num3 = 0;
							if (flag18)
							{
								goto IL_053a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v30+20]");
							((Renderer)0).enabled = false;
							List<System.__Canon> list3 = (List<System.__Canon>)(object)hiddenLooks;
							bool flag19 = (object)hiddenLooks == null;
							num = unchecked((nint)null);
							val = (Enumerator<, >)0;
							flag2 = false;
							gillaLivCamera = this;
							if (!flag19)
							{
								System.__Canon[] items = list3._items;
								int num2 = (int)obj19;
								int version2 = list3._version + 1;
								list3._version = version2;
								bool flag20 = list3._items == null;
								num = unchecked((nint)null);
								val = (Enumerator<, >)0;
								flag2 = false;
								gillaLivCamera = this;
								if (!flag20)
								{
									version2 = list3._size;
									bool flag21 = list3._size < items.Length;
									object obj23 = !flag21;
									if (obj23 == null)
									{
										object obj24 = list3._items + list3._size;
										num2 = list3._size + 1;
										list3._size = num2;
										object obj25 = obj24 + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v30+20]");
										obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										size = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v30+20]");
										num3 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X9_v12 (System.Int32)+20]");
										object obj26 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v34+A8]");
										object obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v35+70]");
										size = 0;
										List<Renderer> list4 = hiddenLooks;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v30+20]");
										((List<System.__Canon>)(object)list4).AddWithResize((System.__Canon)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v30+20]");
										num3 = 0;
									}
									goto IL_053a;
								}
							}
						}
						goto IL_09ec;
						IL_053a:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v47+18]");
						obj18 = 0;
						obj20++;
						object obj28 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v47+18]");
						bool flag22 = (nint)obj28 < 0;
						num = size;
						flag2 = (byte)num3 != 0;
						if (flag22)
						{
							continue;
						}
						goto IL_058c;
					}
					goto IL_09fa;
				}
			}
		}
		goto IL_09ec;
		IL_058c:
		val = (Enumerator<, >)0;
		gillaLivCamera = this;
		goto IL_073e;
		IL_09ec:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_09fa;
		IL_073e:
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v31+E4]");
		bool flag23 = (nint)0 == 0;
		object obj30 = !flag23;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = gillaLivCamera.item == null;
		bool flag25 = !flag24;
		object obj31 = !flag25;
		if (obj31 != null)
		{
			return;
		}
		bool flag26 = (object)gillaLivCamera.item == null;
		num = unchecked((nint)null);
		flag2 = false;
		if (!flag26)
		{
			gillaLivCamera.item.enabled = on;
			GillaItem gillaItem = gillaLivCamera.item;
			bool flag27 = (object)gillaLivCamera.item == null;
			num = unchecked((nint)null);
			flag2 = on;
			if (!flag27)
			{
				Collider[] array = gillaItem.Colliders__BackingField;
				bool flag28 = gillaItem.Colliders__BackingField == null;
				num = unchecked((nint)null);
				flag2 = on;
				if (!flag28)
				{
					if (array.Length < 1)
					{
						return;
					}
					object obj32 = array.Length & 0xFFFFFFFFL;
					object obj19 = gillaItem.Colliders__BackingField + 32;
					num = unchecked((nint)null);
					object obj33 = 0;
					flag2 = on;
					while (true)
					{
						bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
						object obj34 = !flag29;
						if (obj34 != null)
						{
							break;
						}
						object obj35 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X24_v2+v177 @ X22_v12*8]");
						gillaLivCamera = (GillaLivCamera)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v37+E4]");
						bool flag30 = (nint)0 == 0;
						object obj36 = !flag30;
						if (obj36 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag31 = gillaLivCamera != null;
						bool flag32 = !flag31;
						num = unchecked((nint)null);
						flag2 = false;
						if (!flag32)
						{
							bool flag33 = (object)gillaLivCamera == null;
							num = unchecked((nint)null);
							flag2 = false;
							if (flag33)
							{
								goto IL_09ec;
							}
							((Collider)(object)gillaLivCamera).enabled = on;
							num = unchecked((nint)null);
							flag2 = on;
						}
						obj32 = array.Length;
						obj33++;
						if ((nint)obj33 >= array.Length)
						{
							return;
						}
					}
					goto IL_09fa;
				}
			}
		}
		goto IL_09ec;
		IL_0a10:
		throw new NullReferenceException();
		IL_09fa:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		obj6 = obj5;
		goto IL_0a10;
	}

	private void SetAwake(bool on)
	{
		//IL_0202: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02ae: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		awake = on;
		dirty = true;
		if (on)
		{
			ILckService lckService = Service();
			if (lckService != null)
			{
				Ready();
			}
		}
		GillaLivCamera gillaLivCamera = (GillaLivCamera)obj;
		bool flag = (byte)(~(gillaLivCamera.monitorOn ? 1u : 0u)) != 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaLivCamera = (GillaLivCamera)obj;
		}
		AudioClip audioClip = gillaLivCamera.shutterSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5 (UnityEngine.AudioClip)+48]");
		if ((nint)0 != 0)
		{
			bool recording = gillaLivCamera.Recording;
			bool flag2 = !recording;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v8+A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+48]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v10+12E]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v10+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01a5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v10+98]");
				object obj11 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X10_v8-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					obj10--;
					obj11 += 16;
					if ((nint)obj10 != 1)
					{
						continue;
					}
					goto IL_01a5;
				}
				object obj12 = obj11 + 38;
				object obj13 = obj8 + obj12;
				object obj14 = obj13 + 312;
				goto IL_02d7;
			}
		}
		goto IL_0266;
		IL_0266:
		bool flag4 = !on;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			lensPlaced = false;
		}
		return;
		IL_01a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_02d7;
		IL_02d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ X0_v10] (should have been resolved before IL gen)");
		goto IL_0266;
	}

	private unsafe ILckService Service()
	{
		//IL_0010: Expected Obj, but got I
		//IL_051e: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got I
		//IL_06a2: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I4
		//IL_0598: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I
		//IL_05c2: Expected Obj, but got I
		//IL_05e4: Expected Obj, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got Ref
		//IL_060a: Expected Obj, but got I
		//IL_0612: Expected I, but got Obj
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_037a: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I
		//IL_0485: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v5+48]");
		ILckService result = (ILckService)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v5+48]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				goto IL_005c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v5+58]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v35+A0]");
					obj4 = 0;
				}
				_ = 1;
				LckDiContainer instance = LckDiContainer.Instance;
				nint num = default;
				if ((object)instance != null)
				{
					bool flag5 = instance.HasService<T>();
					bool flag6 = !flag5;
					object obj9 = !flag6;
					if (obj9 == null)
					{
						LckServiceInitializer.ConfigureServices(instance, (ILckQualityConfig)quality);
						Action<LckDiContainer> action = null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D98]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @367B900");
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v64+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj11 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v64+A0]");
					object obj13 = (nint)0 + (nint)72;
					IntPtr intPtr = default;
					obj13 = (nint)intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj14 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v30+A0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v69+48]");
					bool flag8 = (nint)0 == 0;
					object obj16 = !flag8;
					num = intPtr;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v30+E4]");
						bool flag9 = (nint)0 == 0;
						object obj17 = !flag9;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj18 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v34+A0]");
							obj15 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DA8]");
						object obj19 = 0;
						num = (nint)obj19;
						object obj20 = obj15 + 80;
						obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					goto IL_023b;
				}
				NullReferenceException ex = new NullReferenceException();
				bool flag10 = num != 1;
				NullReferenceException ex2 = ex;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj22 = default;
					object obj21 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj24 = default;
					object obj23 = obj24 & 1;
					Action<LckDiContainer> action;
					if (obj23 != null)
					{
						object obj25 = 0;
						object obj26 = obj22;
						object obj28 = default;
						object obj27 = (object)(&obj28);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v29+E4]");
						bool flag11 = (nint)0 == 0;
						object obj29 = !flag11;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v34+A0]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v36+A0]");
						object obj31 = (nint)0 + (nint)80;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						string text;
						if (obj22 != null)
						{
							object obj32 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ X8_v22+168] (should have been resolved before IL gen)");
							string text2 = default;
							text = text2;
						}
						else
						{
							text = null;
						}
						string text3 = default;
						string message = text3 + text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v49+E4]");
						bool flag12 = (nint)0 == 0;
						object obj33 = !flag12;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogWarning(message);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
						obj = 0;
						action = null;
						num = unchecked((nint)null);
						goto IL_023b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj34 = obj22;
					num = 101790920;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					action = null;
					NullReferenceException ex3 = default;
					ex2 = ex3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				ILckService result2 = default;
				return result2;
			}
			result = null;
		}
		goto IL_052c;
		IL_0270:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v6+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v7+48]");
		result = (ILckService)0;
		goto IL_052c;
		IL_005c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj36 = obj;
		goto IL_0270;
		IL_023b:
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
		bool flag13 = (nint)0 == 0;
		obj36 = obj2;
		if (flag13)
		{
			goto IL_005c;
		}
		goto IL_0270;
		IL_052c:
		return result;
	}

	private void Ready()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected Obj, but got Unknown
		//IL_0d5c: Expected Obj, but got I4
		//IL_0d80: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_01be: Expected I, but got Obj
		//IL_04a4: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I4
		//IL_0d9e: Expected Obj, but got I
		//IL_0dae: Expected Obj, but got I
		//IL_0dca: Expected I, but got Obj
		//IL_0ea0: Expected Obj, but got I
		//IL_0eb0: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_0253: Expected I, but got Obj
		//IL_0263: Expected Obj, but got I
		//IL_0283: Expected I, but got Obj
		//IL_0524: Expected I, but got Obj
		//IL_0534: Expected Obj, but got I
		//IL_0e5c: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I
		//IL_0f6b: Expected Obj, but got I
		//IL_0f7b: Expected Obj, but got I
		//IL_0f8b: Expected Obj, but got I
		//IL_0579: Expected Obj, but got I
		//IL_0ded: Expected Obj, but got I
		//IL_0e0e: Expected Obj, but got I4
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected Obj, but got Unknown
		//IL_0eea: Expected Obj, but got I
		//IL_0f0b: Expected Obj, but got I4
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected Obj, but got Unknown
		//IL_03d0: Expected Obj, but got I4
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected I4, but got Unknown
		//IL_037f: Expected Obj, but got I
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_066b: Expected I, but got Obj
		//IL_0675: Expected Obj, but got I4
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected I4, but got Unknown
		//IL_0640: Expected Obj, but got I
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_05b6: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got I4
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_03f6: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_041f: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I4
		//IL_1013: Expected Obj, but got I4
		//IL_1062: Expected Obj, but got I4
		//IL_06ba: Expected Obj, but got I
		//IL_047e: Expected I, but got Obj
		//IL_10b5: Expected Obj, but got I4
		//IL_0fc5: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I
		//IL_077a: Expected Obj, but got I4
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected I4, but got Unknown
		//IL_0735: Expected Obj, but got I
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected Obj, but got Unknown
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Expected Obj, but got Unknown
		//IL_1208: Expected I, but got Obj
		//IL_10d3: Expected Obj, but got I
		//IL_10e3: Expected Obj, but got I
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_09f4: Expected Obj, but got I
		//IL_0934: Expected I, but got Obj
		//IL_079a: Expected Obj, but got I
		//IL_0973: Expected Obj, but got I
		//IL_0978: Expected I, but got Obj
		//IL_07a7: Expected I, but got Obj
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected Obj, but got Unknown
		//IL_1377: Expected Obj, but got I4
		//IL_138c: Expected Obj, but got I
		//IL_13ce: Expected Obj, but got I4
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected Obj, but got Unknown
		//IL_0a8c: Expected Obj, but got I4
		//IL_0aa2: Expected Obj, but got I
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_11b9: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I
		//IL_098e: Expected I, but got Obj
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected Obj, but got Unknown
		//IL_1126: Expected Obj, but got I
		//IL_1147: Expected Obj, but got I4
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Expected Obj, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Expected Obj, but got Unknown
		//IL_1233: Expected Obj, but got I4
		//IL_124f: Expected Obj, but got I4
		//IL_1264: Expected I4, but got Obj
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected I4, but got Unknown
		//IL_08bc: Expected Obj, but got I
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_0832: Expected Obj, but got I4
		//IL_0840: Expected Obj, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		//IL_0b46: Expected Obj, but got I8
		//IL_0b4f: Expected Obj, but got I4
		//IL_13f5: Expected Obj, but got I4
		//IL_0b79: Expected Obj, but got I
		//IL_0b95: Expected Obj, but got I4
		//IL_0bd4: Expected I, but got Obj
		//IL_1282: Expected Obj, but got I
		//IL_128b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1290: Expected Obj, but got Unknown
		//IL_0bef: Expected Obj, but got I
		//IL_0c11: Expected Obj, but got I4
		//IL_12cc: Expected Obj, but got I
		//IL_12dc: Expected Obj, but got I
		//IL_12f8: Expected I, but got Obj
		//IL_0c31: Expected Obj, but got I
		//IL_0c3e: Expected I, but got Obj
		//IL_0c4e: Expected Obj, but got I
		//IL_133a: Expected Obj, but got I
		//IL_1349: Expected I, but got Obj
		//IL_0c89: Expected Obj, but got I
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected Obj, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected Obj, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected Obj, but got Unknown
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected Obj, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 216;
		UnityEngine.Object obj4 = (UnityEngine.Object)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj4 == null;
		bool flag3 = !flag2;
		GillaLivLens gillaLivLens = null;
		if (!flag3)
		{
			GillaLivLens gillaLivLens2 = (lens = GillaLivLens.Make());
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			lensPlaced = false;
			gillaLivLens = gillaLivLens2;
		}
		bool flag4 = (byte)(~(monitorOn ? 1u : 0u)) != 0;
		object obj6 = !flag4;
		bool flag7;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D08]");
			object obj7 = 0;
			monitorOn = true;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v100+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D10]");
			object id = 0;
			ILckMonitor monitorById = LckMediator.GetMonitorById((string)id);
			bool flag6 = monitorById == null;
			object obj10 = !flag6;
			flag7 = true;
			gillaLivLens = null;
			if (obj10 == null)
			{
				object obj11 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v104+E4]");
				bool flag8 = (nint)0 == 0;
				object obj12 = !flag8;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				LckMediator.RegisterMonitor((ILckMonitor)this);
				flag7 = true;
				gillaLivLens = null;
			}
		}
		bool flag9 = (byte)(~(activeSet ? 1u : 0u)) != 0;
		object obj13 = !flag9;
		nint num = unchecked((nint)null);
		if (obj13 != null)
		{
			goto IL_0483;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v84+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v84+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v55+48]");
		UnityEngine.Object obj18 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v55+48]");
		bool flag11 = (nint)0 == 0;
		num = unchecked((nint)null);
		GillaLivCamera gillaLivCamera = this;
		if (flag11)
		{
			goto IL_09d9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DC0]");
		object obj20 = 0;
		nint num2 = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D10]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v56 (Il2CppClass<UnityEngine.Object>)+12E]");
		flag7 = false;
		obj4 = (UnityEngine.Object)obj20;
		nint num3 = (nint)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v56 (Il2CppClass<UnityEngine.Object>)+12E]");
		if ((uint)(~(nuint)0u) != 0)
		{
			goto IL_0355;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v56 (Il2CppClass<UnityEngine.Object>)+98]");
		object obj22 = (nint)0 + (nint)8;
		bool flag13 = default;
		bool flag12 = flag13;
		object obj23;
		object obj24;
		bool flag16;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X10_v39-8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X10_v39-8]");
			bool flag14 = 0 < (nint)obj19;
			obj23 = !flag14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X10_v39-8]");
			obj24 = 0 - obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X10_v39-8]");
			if (0 == (nint)obj19)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v56 (Il2CppClass<UnityEngine.Object>)+12E]");
			flag7 = (byte)(-1) != 0;
			bool flag15 = (flag7 ? 1 : 0) < (true ? 1 : 0);
			obj23 = !flag15;
			obj24 = (flag7 ? 1 : 0) - 1;
			flag16 = obj24 == null;
			obj19 = obj22 + 16;
			flag13 = !flag7;
			flag12 = flag13;
			obj22 = obj19;
			if (flag13)
			{
				continue;
			}
			goto IL_0355;
		}
		flag7 = (byte)(obj22 + 49) != 0;
		object obj25 = num2 + (flag7 ? 1 : 0);
		object obj26 = obj25 + 312;
		flag13 = flag12;
		obj19 = obj22;
		goto IL_0e4c;
		IL_0fe9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v46+8]");
		num = 0;
		bool flag17 = (nint)obj4 < 0;
		obj23 = !flag17;
		flag16 = (object)obj4 == null;
		flag13 = !flag16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v778 @ X0_v46] (should have been resolved before IL gen)");
		GillaLivCamera gillaLivCamera2 = default;
		bool recording = gillaLivCamera2.Recording;
		bool flag18 = !recording;
		object obj27 = !flag18;
		obj24 = obj4;
		bool flag19 = flag13;
		if (obj27 != null)
		{
			goto IL_1081;
		}
		object obj28 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v66+E4]");
		bool flag20 = (nint)0 == 0;
		object obj29 = !flag20;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v66+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v47+48]");
		obj18 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v47+48]");
		bool flag21 = (nint)0 == 0;
		obj24 = obj4;
		gillaLivCamera = this;
		if (flag21)
		{
			goto IL_09d9;
		}
		nint num4 = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v48 (Il2CppClass<UnityEngine.Object>)+12E]");
		flag7 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v48 (Il2CppClass<UnityEngine.Object>)+12E]");
		bool flag22 = (byte)(~(nuint)0u) != 0;
		obj24 = obj4;
		if (flag22)
		{
			goto IL_0892;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v48 (Il2CppClass<UnityEngine.Object>)+98]");
		object obj31 = (nint)0 + (nint)8;
		bool flag23 = flag13;
		object obj32;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X10_v21-8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X10_v21-8]");
			bool flag24 = 0 < (nint)obj32;
			obj23 = !flag24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X10_v21-8]");
			obj24 = 0 - obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X10_v21-8]");
			if (0 == (nint)obj32)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v48 (Il2CppClass<UnityEngine.Object>)+12E]");
			flag7 = (byte)(-1) != 0;
			bool flag25 = (flag7 ? 1 : 0) < (true ? 1 : 0);
			obj23 = !flag25;
			obj24 = (flag7 ? 1 : 0) - 1;
			flag16 = obj24 == null;
			obj19 = obj31 + 16;
			flag13 = !flag7;
			flag23 = flag13;
			obj31 = obj19;
			if (flag13)
			{
				continue;
			}
			goto IL_0892;
		}
		flag7 = (byte)(obj31 + 34) != 0;
		object obj33 = num4 + (flag7 ? 1 : 0);
		object obj34 = obj33 + 312;
		flag13 = flag23;
		obj19 = obj31;
		goto IL_1185;
		IL_070b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0fe9;
		IL_0483:
		Hook(on: true);
		bool flag26 = (byte)(~(presetDone ? 1u : 0u)) != 0;
		object obj35 = !flag26;
		if (obj35 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		num3 = 0;
		presetDone = true;
		object obj36 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v42+E4]");
		bool flag27 = (nint)0 == 0;
		object obj37 = !flag27;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v42+A0]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v31+48]");
		obj18 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v31+48]");
		bool flag28 = (nint)0 == 0;
		gillaLivCamera = this;
		if (flag28)
		{
			goto IL_09d9;
		}
		nint num5 = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v32 (Il2CppClass<UnityEngine.Object>)+12E]");
		flag7 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v32 (Il2CppClass<UnityEngine.Object>)+12E]");
		if ((uint)(~(nuint)0u) != 0)
		{
			goto IL_0616;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v32 (Il2CppClass<UnityEngine.Object>)+98]");
		object obj39 = (nint)0 + (nint)8;
		bool flag29 = flag13;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X10_v31-8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X10_v31-8]");
			bool flag30 = 0 < (nint)obj32;
			obj23 = !flag30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X10_v31-8]");
			obj24 = 0 - obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X10_v31-8]");
			if (0 == (nint)obj32)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v32 (Il2CppClass<UnityEngine.Object>)+12E]");
			flag7 = (byte)(-1) != 0;
			bool flag31 = (flag7 ? 1 : 0) < (true ? 1 : 0);
			obj23 = !flag31;
			obj24 = (flag7 ? 1 : 0) - 1;
			flag16 = obj24 == null;
			obj19 = obj39 + 16;
			flag13 = !flag7;
			flag29 = flag13;
			obj39 = obj19;
			if (flag13)
			{
				continue;
			}
			goto IL_0616;
		}
		flag7 = (byte)(obj39 + 42) != 0;
		object obj40 = num5 + (flag7 ? 1 : 0);
		object obj41 = obj40 + 312;
		flag13 = flag29;
		obj19 = obj39;
		goto IL_0f49;
		IL_09d9:
		throw new NullReferenceException();
		IL_0f49:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v43+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v690 @ X0_v43] (should have been resolved before IL gen)");
		object obj42 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v35+A0]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v36+48]");
		obj18 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v36+48]");
		bool flag32 = (nint)0 == 0;
		gillaLivCamera = this;
		if (flag32)
		{
			goto IL_09d9;
		}
		nint num6 = (nint)obj18;
		obj4 = (UnityEngine.Object)mic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v37 (Il2CppClass<UnityEngine.Object>)+12E]");
		flag7 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v37 (Il2CppClass<UnityEngine.Object>)+12E]");
		if ((uint)(~(nuint)0u) != 0)
		{
			goto IL_070b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v37 (Il2CppClass<UnityEngine.Object>)+98]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X10_v26-8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X10_v26-8]");
			if (0 == (nint)obj32)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v37 (Il2CppClass<UnityEngine.Object>)+12E]");
			flag7 = (byte)(-1) != 0;
			obj19 = obj44 + 16;
			bool flag33 = !flag7;
			obj44 = obj19;
			if (flag33)
			{
				continue;
			}
			goto IL_070b;
		}
		flag7 = (byte)(obj44 + 43) != 0;
		object obj45 = num6 + (flag7 ? 1 : 0);
		object obj46 = obj45 + 312;
		obj19 = obj44;
		goto IL_0fe9;
		IL_0892:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_1185;
		IL_0616:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0f49;
		IL_0355:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0e4c;
		IL_1081:
		object obj47 = obj;
		obj18 = quality;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X0_v51+E4]");
		bool flag34 = (nint)0 == 0;
		object obj48 = !flag34;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag35 = obj18 != null;
		bool flag36 = !flag35;
		List<QualityOption> list = null;
		if (!flag36)
		{
			bool flag37 = (object)quality == null;
			num = unchecked((nint)null);
			gillaLivCamera = this;
			if (flag37)
			{
				goto IL_09d9;
			}
			List<QualityOption> qualityOptionsForSystem = quality.GetQualityOptionsForSystem();
			list = qualityOptionsForSystem;
		}
		object obj49 = this + 312;
		options = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		List<QualityOption> list2 = options;
		qualityAt = 0;
		bool flag38 = options == null;
		num = unchecked((nint)null);
		gillaLivCamera = this;
		if (!flag38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C60]");
			obj4 = (UnityEngine.Object)0;
			nint num7 = unchecked((nint)null);
			int num8 = 0;
			object obj51 = default;
			while (true)
			{
				int num9 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v59 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
				bool flag39 = (nint)num9 < (nint)0;
				obj23 = !flag39;
				int num10 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v59 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
				obj24 = (nint)num10 - (nint)0;
				flag16 = obj24 == null;
				int num11 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v59 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
				flag13 = (nint)num11 >= (nint)0;
				num = num7;
				gillaLivCamera = this;
				obj18 = (UnityEngine.Object)num8;
				if (flag13)
				{
					break;
				}
				num = (nint)obj4;
				QualityOption qualityOption = list2.get_Item(num8);
				object obj50 = obj51 & 1;
				if (obj50 != null)
				{
					qualityAt = num8;
				}
				list2 = options;
				obj18 = (UnityEngine.Object)(num8 + 1);
				bool flag40 = options == null;
				object obj52 = !flag40;
				gillaLivCamera = this;
				num7 = num;
				num8 = (int)obj18;
				if (obj52 != null)
				{
					continue;
				}
				goto IL_09d9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		UnityEngine.Object obj54 = default;
		object obj76;
		if ((object)obj54 != null)
		{
			object obj55 = obj54 + 32;
			obj55 = gillaLivCamera.startSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj4 = (UnityEngine.Object)(obj54 + 40);
			obj4 = gillaLivCamera.saveSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X21_v11 (UnityEngine.Object)-10]");
			bool flag41 = (nint)0 < (nint)2;
			object obj56 = !flag41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X21_v11 (UnityEngine.Object)-10]");
			object obj57 = -2;
			bool flag42 = obj57 == null;
			object obj58 = ~obj56;
			object obj59 = obj58 | flag42;
			if (obj59 == null)
			{
				AudioClip audioClip = gillaLivCamera.shutterSound;
				object obj60 = obj54 + 48;
				obj60 = gillaLivCamera.shutterSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X19_v7-18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X19_v7-18]");
				object obj61 = 0 & 0xFFFFFFFFL;
				object obj62 = 0;
				while (true)
				{
					bool flag43 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61);
					obj23 = !flag43;
					obj24 = obj62 - obj61;
					flag16 = obj24 == null;
					if (obj23 != null)
					{
						break;
					}
					object obj63 = obj;
					object obj64 = (object)obj54 + obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v18+20]");
					gillaLivCamera = (GillaLivCamera)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v21+E4]");
					bool flag44 = (byte)(~(nuint)0u) != 0;
					object obj65 = !flag44;
					if (obj65 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag45 = gillaLivCamera != null;
					bool flag46 = !flag45;
					num = unchecked((nint)null);
					UnityEngine.Object obj66 = null;
					if (flag46)
					{
						goto IL_1272;
					}
					object obj67 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v27+E4]");
					bool flag47 = (nint)0 == 0;
					object obj68 = !flag47;
					if (obj68 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj67 = num3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v27+A0]");
					object obj69 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v22+48]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v22+48]");
					bool flag48 = (nint)0 == 0;
					num = unchecked((nint)null);
					if (flag48)
					{
						goto IL_09d9;
					}
					nint num12 = (nint)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v23 (Il2CppClass<UnityEngine.Object>)+12E]");
					object obj70 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v23 (Il2CppClass<UnityEngine.Object>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0cd2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v23 (Il2CppClass<UnityEngine.Object>)+98]");
					object obj71 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X10_v10-8]");
						if (0 == (nint)obj32)
						{
							break;
						}
						obj70--;
						obj19 = obj71 + 16;
						bool flag49 = (nint)obj70 != 1;
						obj71 = obj19;
						if (flag49)
						{
							continue;
						}
						goto IL_0cd2;
					}
					object obj72 = obj71 + 51;
					object obj73 = num12 + obj72;
					object obj74 = obj73 + 312;
					obj19 = obj71;
					goto IL_132a;
					IL_1272:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v11 (UnityEngine.Object)+18]");
					obj61 = 0;
					obj62++;
					object obj75 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v11 (UnityEngine.Object)+18]");
					flag13 = (nint)obj75 < 0;
					audioClip = (AudioClip)obj66;
					if (!flag13)
					{
						return;
					}
					continue;
					IL_0cd2:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_132a;
					IL_132a:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X0_v28+8]");
					obj76 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1034 @ X0_v28] (should have been resolved before IL gen)");
					num = unchecked((nint)null);
					obj66 = gillaLivCamera;
					goto IL_1272;
				}
			}
			throw new IndexOutOfRangeException();
		}
		goto IL_09d9;
		IL_0e4c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v85+8]");
		obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v592 @ X0_v85] (should have been resolved before IL gen)");
		object obj77 = default;
		bool flag50 = obj77 == null;
		num = num3;
		gillaLivCamera = this;
		if (!flag50)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v87+10]");
			activeSet = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v87+10]");
			bool flag51 = (byte)(~(nuint)0u) != 0;
			object obj78 = !flag51;
			num = num3;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DB8]");
				object obj79 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v87+18]");
				string message = (string)obj79 + (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj80 = 0;
				object obj81 = obj80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v64+E4]");
				flag7 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v64+E4]");
				bool flag52 = (byte)(~(nuint)0u) != 0;
				object obj82 = !flag52;
				if (obj82 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				num = unchecked((nint)null);
			}
			goto IL_0483;
		}
		goto IL_09d9;
		IL_1185:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X0_v67+8]");
		num = 0;
		flag19 = (byte)((portrait ? 1u : 0u) ^ 1u) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v953 @ X0_v67] (should have been resolved before IL gen)");
		obj4 = (UnityEngine.Object)portrait;
		goto IL_1081;
	}

	private void Hook(bool on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I4
		//IL_0f0c: Expected Obj, but got I
		//IL_0f1c: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_0a81: Expected Obj, but got I
		//IL_0a9b: Expected Obj, but got I
		//IL_0aa9: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_09c1: Expected Obj, but got I
		//IL_09db: Expected Obj, but got I
		//IL_09e9: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_0af4: Expected Obj, but got I
		//IL_0b04: Expected Obj, but got I
		//IL_0b1e: Expected Obj, but got I
		//IL_0b2c: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_0a34: Expected Obj, but got I
		//IL_0a44: Expected Obj, but got I
		//IL_0a5e: Expected Obj, but got I
		//IL_0a6c: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I
		//IL_0c0a: Expected Obj, but got I
		//IL_0c1a: Expected Obj, but got I
		//IL_0c2a: Expected Obj, but got I
		//IL_0c44: Expected Obj, but got I
		//IL_0c52: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_0554: Expected Obj, but got I
		//IL_0b77: Expected Obj, but got I
		//IL_0b87: Expected Obj, but got I
		//IL_0b97: Expected Obj, but got I
		//IL_0bb1: Expected Obj, but got I
		//IL_0bbf: Expected I, but got Obj
		//IL_031c: Expected Obj, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0483: Expected Obj, but got I
		//IL_0d20: Expected Obj, but got I
		//IL_0d30: Expected Obj, but got I
		//IL_0d4a: Expected Obj, but got I
		//IL_0d58: Expected I, but got Obj
		//IL_058f: Expected Obj, but got I
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_06f6: Expected Obj, but got I
		//IL_0c9d: Expected Obj, but got I
		//IL_0cad: Expected Obj, but got I
		//IL_0cc7: Expected Obj, but got I
		//IL_0cd5: Expected I, but got Obj
		//IL_04be: Expected Obj, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected Obj, but got Unknown
		//IL_0625: Expected Obj, but got I
		//IL_0e26: Expected Obj, but got I
		//IL_0e36: Expected Obj, but got I
		//IL_0e50: Expected Obj, but got I
		//IL_0e5e: Expected I, but got Obj
		//IL_0731: Expected Obj, but got I
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Obj, but got Unknown
		//IL_08b8: Expected Obj, but got I
		//IL_0da3: Expected Obj, but got I
		//IL_0db3: Expected Obj, but got I
		//IL_0dcd: Expected Obj, but got I
		//IL_0ddb: Expected I, but got Obj
		//IL_0660: Expected Obj, but got I
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_093d: Expected Obj, but got I4
		//IL_0946: Expected Obj, but got I4
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected Obj, but got Unknown
		//IL_07cf: Expected Obj, but got I
		//IL_08f3: Expected Obj, but got I
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_0854: Expected Obj, but got I4
		//IL_085d: Expected Obj, but got I4
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected Obj, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_0ed2: Expected Obj, but got I
		//IL_080a: Expected Obj, but got I
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected Obj, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected Obj, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected Obj, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+48]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+48]");
		if ((nint)0 == 0 || hooked == on)
		{
			return;
		}
		hooked = on;
		object obj12;
		if (on)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v86+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v87+48]");
				obj5 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D40]");
			object obj10 = 0;
			Action<System.__Canon> action = default;
			action._002Ector((object)this, (IntPtr)obj10);
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v53+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v53+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0180;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v53+98]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v61-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj13--;
				obj14 += 16;
				if ((nint)obj13 != 1)
				{
					continue;
				}
				goto IL_0180;
			}
			object obj15 = obj11 + obj14;
			object obj16 = obj15 + 312;
			goto IL_0a12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v48+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v49+48]");
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D20]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D40]");
		object obj21 = 0;
		Action<System.__Canon> action2 = default;
		action2._002Ector((object)this, (IntPtr)obj21);
		object obj22 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v15+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_029a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v15+98]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X10_v32-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj24--;
			obj25 += 16;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_029a;
		}
		object obj26 = obj25 + 1;
		object obj27 = obj22 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0ad2;
		IL_0e87:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0eba;
		IL_0772:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0e04;
		IL_05d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0cfe;
		IL_0cfe:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v818 @ X0_v25] (should have been resolved before IL gen)");
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v32+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v33+48]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D30]");
		object obj32 = 0;
		Action<System.__Canon> action3 = default;
		action3._002Ector((object)this, (IntPtr)obj32);
		object obj33 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v36+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v36+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0772;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v36+98]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X10_v17-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj34--;
			obj35 += 16;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_0772;
		}
		object obj36 = obj35 + 17;
		object obj37 = obj33 + obj36;
		object obj38 = obj37 + 312;
		goto IL_0e04;
		IL_0c7b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v802 @ X0_v62] (should have been resolved before IL gen)");
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v70+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v71+48]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D30]");
		object obj42 = 0;
		Action<System.__Canon> action4 = default;
		action4._002Ector((object)this, (IntPtr)obj42);
		object obj43 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v74+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v74+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06a1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v74+98]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X10_v46-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj44--;
			obj45 += 16;
			if ((nint)obj44 != 1)
			{
				continue;
			}
			goto IL_06a1;
		}
		object obj46 = obj45 + 16;
		object obj47 = obj43 + obj46;
		object obj48 = obj47 + 312;
		goto IL_0d81;
		IL_0e04:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v960 @ X0_v30] (should have been resolved before IL gen)");
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v39+A0]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v40+48]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D28]");
		object obj52 = 0;
		Action<System.__Canon> action5 = default;
		action5._002Ector((object)this, (IntPtr)obj52);
		object obj53 = obj51;
		object obj54 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v7+12E]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0934;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v7+98]");
		object obj56 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X10_v12-8]");
			if (0 == (nint)obj54)
			{
				break;
			}
			obj55--;
			obj56 += 16;
			if ((nint)obj55 != 1)
			{
				continue;
			}
			goto IL_0934;
		}
		object obj57 = obj56 + 13;
		goto IL_0edc;
		IL_0a12:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v514 @ X0_v52] (should have been resolved before IL gen)");
		object obj58 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v56+A0]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v57+48]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D48]");
		object obj61 = 0;
		Action<System.__Canon> action6 = default;
		action6._002Ector((object)this, (IntPtr)obj61);
		object obj62 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v60+12E]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v60+12E]");
		if ((nint)0 == 0)
		{
			goto IL_035d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v60+98]");
		object obj64 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X10_v56-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj63--;
			obj64 += 16;
			if ((nint)obj63 != 1)
			{
				continue;
			}
			goto IL_035d;
		}
		object obj65 = obj64 + 6;
		object obj66 = obj62 + obj65;
		object obj67 = obj66 + 312;
		goto IL_0b55;
		IL_06a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0d81;
		IL_0edc:
		object obj68 = obj53 + obj57;
		object obj69 = obj68 + 312;
		goto IL_0eba;
		IL_0d81:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v944 @ X0_v67] (should have been resolved before IL gen)");
		object obj70 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v77+A0]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v78+48]");
		obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D28]");
		object obj72 = 0;
		Action<System.__Canon> action7 = default;
		action7._002Ector((object)this, (IntPtr)obj72);
		obj53 = obj51;
		obj54 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v7+12E]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_084b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v7+98]");
		object obj74 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X10_v41-8]");
			if (0 == (nint)obj54)
			{
				break;
			}
			obj73--;
			obj74 += 16;
			if ((nint)obj73 != 1)
			{
				continue;
			}
			goto IL_084b;
		}
		obj57 = obj74 + 12;
		goto IL_0edc;
		IL_0180:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0a12;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0ad2;
		IL_0ad2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v530 @ X0_v15] (should have been resolved before IL gen)");
		object obj75 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v18+A0]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v19+48]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D48]");
		object obj78 = 0;
		Action<System.__Canon> action8 = default;
		action8._002Ector((object)this, (IntPtr)obj78);
		object obj79 = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v22+12E]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v22+12E]");
		if ((nint)0 == 0)
		{
			goto IL_042e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v22+98]");
		object obj81 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X10_v27-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj80--;
			obj81 += 16;
			if ((nint)obj80 != 1)
			{
				continue;
			}
			goto IL_042e;
		}
		object obj82 = obj81 + 7;
		object obj83 = obj79 + obj82;
		object obj84 = obj83 + 312;
		goto IL_0be8;
		IL_035d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0b55;
		IL_0b55:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v657 @ X0_v57] (should have been resolved before IL gen)");
		object obj85 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v63+A0]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D18]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v64+48]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D38]");
		object obj89 = 0;
		Action<System.__Canon> action9 = default;
		action9._002Ector((object)this, (IntPtr)obj89);
		object obj90 = obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v67+12E]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v67+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v67+98]");
		object obj92 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X10_v51-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj91--;
			obj92 += 16;
			if ((nint)obj91 != 1)
			{
				continue;
			}
			goto IL_04ff;
		}
		object obj93 = obj92 + 14;
		object obj94 = obj90 + obj93;
		object obj95 = obj94 + 312;
		goto IL_0c7b;
		IL_0934:
		object obj96 = 13;
		object obj97 = 0;
		object obj98 = obj51;
		goto IL_0e87;
		IL_084b:
		obj96 = 12;
		obj97 = 0;
		obj98 = obj51;
		goto IL_0e87;
		IL_042e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0be8;
		IL_0be8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v675 @ X0_v20] (should have been resolved before IL gen)");
		object obj99 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v25+A0]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D18]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v26+48]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D38]");
		object obj103 = 0;
		Action<System.__Canon> action10 = default;
		action10._002Ector((object)this, (IntPtr)obj103);
		object obj104 = obj102;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v29+12E]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v29+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v29+98]");
		object obj106 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X10_v22-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj105--;
			obj106 += 16;
			if ((nint)obj105 != 1)
			{
				continue;
			}
			goto IL_05d0;
		}
		object obj107 = obj106 + 15;
		object obj108 = obj104 + obj107;
		object obj109 = obj108 + 312;
		goto IL_0cfe;
		IL_04ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0c7b;
		IL_0eba:
		object obj110 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ X0_v6+8]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v120 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_0edc;
	}

	private unsafe void Later(Action a)
	{
		//IL_01c7: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got Ref
		//IL_01d8: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got Ref
		//IL_00a1: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got Ref
		//IL_014d: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(later, ref lockTaken);
		bool flag = (object)later == null;
		NullReferenceException ex = null;
		object obj = 0;
		System.__Canon _Canon = (System.__Canon)(&lockTaken);
		object obj2 = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9A48]");
			object obj3 = 0;
			obj2 = obj3;
			((Queue<System.__Canon>)(object)later).Enqueue((System.__Canon)(object)a);
			ex = null;
			obj = 0;
			_Canon = (System.__Canon)(object)a;
			goto IL_0047;
		}
		goto IL_00ee;
		IL_00ee:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_00fc;
		IL_0047:
		object obj4 = (object)(&lockTaken);
		if (obj4 != null)
		{
			object obj6 = default;
			object obj5 = (object)(&obj6);
			Monitor.Exit(obj5);
			_Canon = null;
		}
		bool flag2 = ex == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			bool flag3 = obj == null;
			object obj8 = !flag3;
			ex2 = ex;
			if (obj8 == null)
			{
				return;
			}
			goto IL_00fc;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_00ee;
		IL_00fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)_Canon == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)_Canon != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj9 = default;
			ex = (NullReferenceException)obj9;
		}
		goto IL_0047;
	}

	private void Started(LckResult r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0092: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass236_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DD0]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = r;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj4);
		Later(action);
	}

	private void Stopped(LckResult r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0092: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DD8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass237_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DE0]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = r;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj4);
		Later(action);
	}

	private void Saved(LckResult<RecordingData> r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0092: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DE8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass238_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DF0]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 24;
		obj6 = r;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj4);
		Later(action);
	}

	private void PhotoSaved(LckResult r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0092: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaLoading._003C_003Ec__DisplayClass239_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E00]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 24;
		obj6 = r;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj4);
		Later(action);
	}

	private void LowStorage(LckResult r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003e: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E08]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj2);
		Later(action);
	}

	private static string Short(LckResult r, string doing)
	{
		//IL_0077: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		if (r == null)
		{
			goto IL_019d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r @ X0 (Liv.Lck.LckResult)+24]");
		string result;
		object obj5;
		if ((nint)0 != 6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r @ X0 (Liv.Lck.LckResult)+24]");
			if ((nint)0 != 13)
			{
				bool flag = string.IsNullOrEmpty(r._message);
				bool flag2 = !flag;
				object obj = !flag2;
				result = doing;
				if (obj == null)
				{
					if (r._message == null)
					{
						goto IL_019d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E30]");
					object value = 0;
					int num = r._message.IndexOf((string)value, (StringComparison)5);
					bool flag3 = num < 0;
					int num2 = num ^ num;
					int num3 = num & num2;
					bool flag4 = num3 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E18]");
					object obj2 = 0;
					bool flag5 = flag3 == flag4;
					object obj3 = !flag5;
					object obj4 = ~obj3;
					result = (string)((obj4 != null) ? obj2 : doing);
				}
				goto IL_01d5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E28]");
			obj5 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E20]");
			obj5 = 0;
		}
		result = (string)obj5;
		goto IL_01d5;
		IL_01d5:
		return result;
		IL_019d:
		return (string)(object)new NullReferenceException();
	}

	private static bool Ok(LckResult<bool> r)
	{
		if (r != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r @ X0 (Liv.Lck.LckResult`1<System.Boolean>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r @ X0 (Liv.Lck.LckResult`1<System.Boolean>)+28]");
				bool flag = (nint)0 == 0;
				return !flag;
			}
		}
		return false;
	}

	private void Sound(AudioClip clip)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_014e: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I4
		//IL_0348: Expected VT, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
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
		if (clip == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v7+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v5+48]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v5+48]");
		bool flag3 = (nint)0 == 0;
		object obj9 = 0;
		if (flag3)
		{
			goto IL_0247;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v23+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v24+48]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v24+48]");
			if ((nint)0 == 0)
			{
				goto IL_0349;
			}
		}
		object obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v18+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01da;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v18+98]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X10_v10-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj15--;
			obj16 += 16;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_01da;
		}
		object obj17 = obj16 + 52;
		object obj18 = obj13 + obj17;
		object obj19 = obj18 + 312;
		goto IL_0408;
		IL_0408:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v26+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v336 @ X0_v26] (should have been resolved before IL gen)");
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v28+10]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 != null)
			{
				return;
			}
		}
		goto IL_0247;
		IL_0247:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj23 = array + 32;
			obj23 = clip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj24 = 0;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj26 = !flag6;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float volume = default;
				float pitchMin = default;
				float pitchMax = default;
				Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
				return;
			}
		}
		goto IL_0349;
		IL_0349:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_01da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0408;
	}

	public void SetRenderTexture(RenderTexture renderTexture)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		seen = renderTexture;
		object obj = this + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 408;
		shown = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		dirty = true;
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_02bc: Expected I, but got Obj
		//IL_0047: Expected I, but got Obj
		//IL_0055: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I8
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_01db: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_020c: Expected I, but got Obj
		//IL_021a: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA568]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E38]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E40]");
		Func<System.__Canon, int, bool> func = (Func<System.__Canon, int, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<ScriptableRenderContext, System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj2);
		RenderPipelineManager.beginCameraRendering += (Action<ScriptableRenderContext, Camera>)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num = (nint)func;
		Action<ScriptableRenderContext, System.__Canon> action2 = default;
		action2._002Ector((object)this, (IntPtr)func);
		RenderPipelineManager.endCameraRendering += (Action<ScriptableRenderContext, Camera>)action2;
		PressKey[] array = keys;
		if (keys == null || array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E58]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E48]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E50]");
		object obj7 = 0;
		object obj8 = array.Length & 0xFFFFFFFFL;
		object obj9 = keys + 32;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		object obj12 = 0;
		Action<System.__Canon> action3 = default;
		Func<System.__Canon, int, bool> func2 = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			object obj13 = !flag;
			if (obj13 != null)
			{
				break;
			}
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v3+v229 @ X23_v5*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			obj11 = null;
			num = 0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action3._002Ector((object)this, (IntPtr)obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v3+v229 @ X23_v5*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				num = (nint)obj7;
				func2._002Ector((object)this, (IntPtr)obj7);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v3+v229 @ X23_v5*8]");
				object obj16 = (nint)0 + (nint)88;
				obj16 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj10 = 0;
				obj11 = (UnityEngine.Object)(object)func2;
			}
			obj8 = array.Length;
			obj12++;
			if ((nint)obj12 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_02df: Expected I, but got Obj
		//IL_005d: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I4
		//IL_02fc: Expected VT, but got I4
		//IL_0134: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I8
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_0220: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA568]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E38]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E40]");
		Action<System.__Canon> action = (Action<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<ScriptableRenderContext, System.__Canon> action2 = default;
		action2._002Ector((object)this, (IntPtr)obj2);
		RenderPipelineManager.beginCameraRendering -= (Action<ScriptableRenderContext, Camera>)action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<ScriptableRenderContext, System.__Canon> action3 = default;
		action3._002Ector((object)this, (IntPtr)action);
		RenderPipelineManager.endCameraRendering -= (Action<ScriptableRenderContext, Camera>)action3;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = lens != null;
		bool flag3 = !flag2;
		Camera c = null;
		if (!flag3)
		{
			GillaLivLens gillaLivLens = lens;
			c = gillaLivLens.Cam__BackingField;
		}
		AfterCamera((ScriptableRenderContext)0, c);
		PressKey[] array = keys;
		if (keys == null || array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E58]");
		object obj7 = 0;
		object obj8 = array.Length & 0xFFFFFFFFL;
		object obj9 = keys + 32;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		object obj12 = 0;
		Action<System.__Canon> action4 = default;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			object obj13 = !flag4;
			if (obj13 != null)
			{
				break;
			}
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X27_v3+v166 @ X24_v5*8]");
			bool flag6 = (UnityEngine.Object)0 != null;
			bool flag7 = !flag6;
			obj11 = null;
			c = null;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action4._002Ector((object)this, (IntPtr)obj7);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X27_v3+v166 @ X24_v5*8]");
				((PressKey)0).Pressed -= (Action<PressKey>)action4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X27_v3+v166 @ X24_v5*8]");
				object obj16 = (nint)0 + (nint)88;
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj10 = 0;
				obj11 = null;
				c = null;
			}
			obj8 = array.Length;
			obj12++;
			if ((nint)obj12 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void BeforeCamera(ScriptableRenderContext context, Camera c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I4
		//IL_01ed: Expected VT, but got I4
		//IL_0249: Expected Obj, but got I8
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I4
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
		bool flag2 = lens == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = c == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		GillaLivLens gillaLivLens = lens;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = c != gillaLivLens.Cam__BackingField;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		Transform transform = c.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NameTag.FaceViewer((Vector3)0);
		Renderer[] array = ownLooks;
		if (ownLooks == null || array.Length < 1)
		{
			return;
		}
		object obj14 = array.Length & 0xFFFFFFFFL;
		object obj15 = ownLooks + 32;
		object obj16 = 0;
		bool flag11 = false;
		object obj17 = 0;
		while (true)
		{
			bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
			object obj18 = !flag12;
			if (obj18 != null)
			{
				break;
			}
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v25+E4]");
			bool flag13 = (nint)0 == 0;
			object obj20 = !flag13;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v4+v249 @ X21_v8*8]");
			bool flag14 = (UnityEngine.Object)0 != null;
			bool flag15 = !flag14;
			obj16 = 0;
			flag11 = false;
			if (!flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v4+v249 @ X21_v8*8]");
				((Renderer)0).forceRenderingOff = true;
				obj16 = 0;
				flag11 = true;
			}
			obj14 = array.Length;
			obj17++;
			if ((nint)obj17 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void AfterCamera(ScriptableRenderContext context, Camera c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I8
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I4
		//IL_02fc: Expected VT, but got I4
		//IL_0305: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I4
		//IL_0444: Expected Obj, but got I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I4
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
		bool flag2 = lens == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = c == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		GillaLivLens gillaLivLens = lens;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = c != gillaLivLens.Cam__BackingField;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		Camera main = Camera.main;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v8+E4]");
		bool flag10 = (nint)0 == 0;
		object obj12 = !flag10;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = main != null;
		bool flag12 = !flag11;
		object obj13 = 0;
		UnityEngine.Object obj14 = null;
		if (!flag12)
		{
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v32+E4]");
			bool flag13 = (nint)0 == 0;
			object obj16 = !flag13;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = main != c;
			bool flag15 = !flag14;
			obj13 = 0;
			obj14 = c;
			if (!flag15)
			{
				Transform transform = main.transform;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v39+E4]");
				bool flag16 = (nint)0 == 0;
				object obj19 = !flag16;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NameTag.FaceViewer((Vector3)0);
				obj13 = 0;
				obj14 = null;
			}
		}
		Renderer[] array = ownLooks;
		if (ownLooks == null || array.Length < 1)
		{
			return;
		}
		object obj20 = array.Length & 0xFFFFFFFFL;
		object obj21 = ownLooks + 32;
		object obj22 = 0;
		while (true)
		{
			bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
			object obj23 = !flag17;
			if (obj23 != null)
			{
				break;
			}
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v25+E4]");
			bool flag18 = (nint)0 == 0;
			object obj25 = !flag18;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v4+v256 @ X21_v9*8]");
			bool flag19 = (UnityEngine.Object)0 != null;
			bool flag20 = !flag19;
			obj13 = 0;
			obj14 = null;
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v4+v256 @ X21_v9*8]");
				((Renderer)0).forceRenderingOff = false;
				obj13 = 0;
				obj14 = null;
			}
			obj20 = array.Length;
			obj22++;
			if ((nint)obj22 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnKey(PressKey key)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		if (~(awake ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (key != null)
			{
				Press(key.id);
			}
		}
	}

	private bool AllowPress(PressKey key, int hand)
	{
		//IL_0017: Expected I4, but got I8
		//IL_0031: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I4
		//IL_019e: Expected I4, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		if (~(awake ? 1u : 0u) == 0)
		{
			int num = (int)(hand & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (item != null)
				{
					GillaItem gillaItem = item;
					if ((object)item == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					if (gillaItem.Hand__BackingField == hand)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EC0]");
						object obj5 = 0;
						object obj6 = this + 200;
						obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X19_v6-8]");
						object obj7 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						goto IL_015d;
					}
				}
				return Meant(hand, key);
			}
			return true;
		}
		goto IL_015d;
		IL_015d:
		return false;
	}

	private bool Refuse(string why)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I
		object obj = this + 200;
		obj = why;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X0_v1-8]");
		object obj2 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return false;
	}

	private void Trace()
	{
		//IL_05dc: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0257: Expected I4, but got Obj
		//IL_028a: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02b5: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_00f8: Expected I, but got Obj
		//IL_02fc: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_037a: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I
		//IL_060a: Expected F4, but got Obj
		//IL_060f: Expected I, but got Obj
		//IL_0158: Expected I, but got Obj
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_0518: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I4
		//IL_0417: Expected VT, but got I4
		//IL_0420: Expected I, but got Obj
		//IL_0551: Expected Obj, but got I4
		Transform[] array = tips;
		bool flag = tips == null;
		object obj = !flag;
		if (obj == null)
		{
			PressKey[] array2 = keys;
			if (keys != null && array2.Length != 0)
			{
				if (array2.Length == 0)
				{
					goto IL_05a1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v27+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = array2[0] != null;
				bool flag4 = !flag3;
				object obj5 = 0;
				nint num = unchecked((nint)null);
				if (!flag4)
				{
					PressKey[] array3 = keys;
					if (array3.Length == 0)
					{
						goto IL_05a1;
					}
					PressKey pressKey = array3[0];
					num = (nint)pressKey.fingertips;
					object obj6 = this + 480;
					tips = pressKey.fingertips;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj5 = 0;
				}
			}
			array = tips;
			if (tips == null)
			{
				goto IL_0591;
			}
		}
		if (array.Length < 2 || ~(awake ? 1u : 0u) != 0)
		{
			goto IL_0591;
		}
		float[] array4 = trailTime;
		object obj7 = trailHead + 1;
		object obj8 = obj7 * 1717986919;
		object obj9 = obj8 >> 63;
		object obj10 = obj8 >> 34;
		object obj11 = obj10 + obj9;
		object obj12 = obj11 * 10;
		int num2 = (trailHead = obj7 - obj12);
		float unscaledTime = Time.unscaledTime;
		bool flag5 = num2 < array4.Length;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			object obj14 = array4 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj16 = 0;
			object obj17 = 0;
			object obj18 = 1;
			while (true)
			{
				Transform[] array5 = tips;
				bool flag6 = (nint)obj17 < array5.Length;
				object obj19 = !flag6;
				if (obj19 != null)
				{
					break;
				}
				object obj20 = obj15;
				object obj21 = (object)array5 + obj17;
				Vector3[,] array6 = tipTrail;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v11+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v18+20]");
				if ((UnityEngine.Object)0 != null)
				{
					Transform transform = base.transform;
					Transform[] array7 = tips;
					bool flag8 = (nint)obj17 < array7.Length;
					object obj23 = !flag8;
					if (obj23 != null)
					{
						break;
					}
					object obj24 = (object)array7 + obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v30+20]");
					Vector3 position = ((Transform)0).position;
					Vector3 vector = transform.InverseTransformPoint((Vector3)0);
					nint num = unchecked((nint)null);
				}
				else
				{
					object obj25 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v27+A0]");
					object obj26 = 0;
					unscaledTime = (float)obj26;
					nint num = unchecked((nint)null);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X28_v6 (UnityEngine.Vector3[2])+10]");
				object obj27 = 0;
				bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
				object obj28 = !flag9;
				if (obj28 != null)
				{
					break;
				}
				int num3 = trailHead;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v20+10]");
				bool flag10 = (nint)num3 < (nint)0;
				object obj29 = !flag10;
				if (obj29 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v20+10]");
				object obj30 = 0 * obj17;
				object obj31 = trailHead + obj30;
				object obj32 = obj31 * 12;
				object obj33 = (object)array6 + obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v28+4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v28+8]");
				_ = 0;
				object obj34 = obj18 & 1;
				bool flag11 = obj34 == null;
				object obj35 = !flag11;
				obj17 = 1;
				object obj5 = 0;
				obj18 = 0;
				if (obj35 == null)
				{
					object obj36 = trailCount + 1;
					int num4 = (((nint)obj36 < 10) ? (trailCount + 1) : 10);
					trailCount = num4;
					return;
				}
			}
		}
		goto IL_05a1;
		IL_0591:
		trailCount = 0;
		return;
		IL_05a1:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private bool Meant(int h, PressKey key)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0ad2: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I8
		//IL_020a: Expected F4, but got I4
		//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Expected Obj, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got Unknown
		//IL_0c19: Expected Obj, but got I4
		//IL_0245: Invalid comparison between F4 and I
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02dd: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I
		//IL_03ef: Expected VT, but got I4
		//IL_0439: Expected Obj, but got I
		//IL_04aa: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I
		//IL_0524: Invalid comparison between F4 and I
		//IL_054b: Expected Obj, but got I
		//IL_056c: Expected Obj, but got I
		//IL_0ba7: Expected Obj, but got I
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected Obj, but got Unknown
		//IL_0b75: Expected Obj, but got I
		//IL_05fa: Expected VT, but got I4
		//IL_06b7: Invalid comparison between F4 and I
		//IL_0757: Expected Obj, but got I4
		//IL_079c: Expected Obj, but got I4
		//IL_06de: Expected Obj, but got I
		//IL_070f: Expected Obj, but got I
		//IL_071f: Expected Obj, but got I
		//IL_0728: Expected Obj, but got I4
		//IL_0977: Expected Obj, but got I4
		//IL_07bf: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I4
		//IL_083a: Expected Obj, but got I4
		//IL_087d: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I4
		//IL_0a0e: Expected Obj, but got I
		//IL_0a1e: Invalid comparison between F4 and I
		//IL_090e: Expected Obj, but got I
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_0940: Expected Obj, but got I4
		//IL_0a82: Expected Obj, but got I
		//IL_0aa3: Expected Obj, but got I
		Transform[] array = tips;
		object obj5;
		float unscaledTime;
		object obj11;
		float num2;
		float num4;
		if (tips != null && array.Length > h)
		{
			bool flag = array.Length < h;
			object obj = !flag;
			object obj2 = array.Length - h;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_0ab6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj5 = 0;
			object obj6 = tips + h;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v8+20]");
			bool flag4 = (UnityEngine.Object)0 == null;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			if (obj9 == null && trailCount >= 3)
			{
				unscaledTime = Time.unscaledTime;
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Vector3 lossyScale = transform.lossyScale;
					int num = trailCount;
					if (trailCount < 1)
					{
						goto IL_0aa8;
					}
					float[] array2 = trailTime;
					if (trailTime != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
						object obj10 = trailHead + 10;
						obj11 = 4294967295L;
						num2 = 2.139095E+09f;
						while (true)
						{
							object obj12 = obj10 * 1717986919;
							object obj13 = obj12 >> 63;
							object obj14 = obj12 >> 34;
							object obj15 = obj14 + obj13;
							object obj16 = obj15 * 10;
							object obj17 = obj10 - obj16;
							bool flag6 = (nint)obj17 < array2.Length;
							object obj18 = !flag6;
							if (obj18 != null)
							{
								break;
							}
							object obj19 = (object)trailTime + obj17;
							float num3 = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X15_v7+20]");
							num4 = num3 - 0f;
							float num5 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
							if (num5 > 0f)
							{
								float num6 = num4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
								num4 = num6 + 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								if (num4 < num2)
								{
									obj11 = obj17;
									num2 = num4;
								}
							}
							num--;
							obj10--;
							if (num != 1)
							{
								continue;
							}
							goto IL_02b1;
						}
						goto IL_0ab6;
					}
				}
				goto IL_0ac4;
			}
		}
		goto IL_0aa8;
		IL_0b97:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EC8]");
		object obj20 = 0;
		goto IL_0b37;
		IL_0ac4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0aa8:
		return true;
		IL_0ab6:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0ac4;
		IL_02b1:
		object obj21 = obj11 & 0x80000000L;
		bool flag7 = obj21 == null;
		object obj22 = !flag7;
		if (obj22 != null)
		{
			goto IL_0aa8;
		}
		Transform transform2 = base.transform;
		Transform[] array3 = tips;
		string text;
		object obj35;
		if (tips != null)
		{
			bool flag8 = array3.Length < h;
			object obj23 = !flag8;
			object obj24 = array3.Length - h;
			bool flag9 = obj24 == null;
			object obj25 = ~obj23;
			object obj26 = obj25 | flag9;
			if (obj26 != null)
			{
				goto IL_0ab6;
			}
			object obj27 = tips + h;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v14+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v14+20]");
				Vector3 position = ((Transform)0).position;
				if ((object)transform2 != null)
				{
					Vector3 vector = transform2.InverseTransformPoint((Vector3)0);
					if (tipTrail != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A11B0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
						object obj28 = num7 - 0;
						float num8 = num2 - num2;
						float num9 = num4 - num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
						float[] array4 = trailTime;
						if (trailTime != null)
						{
							bool flag10 = (nint)obj11 < array4.Length;
							object obj29 = !flag10;
							if (obj29 != null)
							{
								goto IL_0ab6;
							}
							object obj30 = (object)trailTime + obj11;
							object obj32 = default;
							object obj31 = obj32 * obj28;
							float num10 = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v16+20]");
							float num11 = num10 - 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
							float num12 = (float)obj31 / num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
							object obj33 = 0;
							float num13 = num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
							if (num13 > 0f)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EE0]");
								object obj34 = 0;
								float num14 = default;
								text = num14.ToString((string)obj34);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EF0]");
								obj35 = 0;
								goto IL_0b97;
							}
							Transform transform3 = base.transform;
							if ((object)key != null)
							{
								Transform transform4 = key.transform;
								if ((object)transform4 != null)
								{
									Vector3 position2 = transform4.position;
									if ((object)transform3 != null)
									{
										Vector3 vector2 = transform3.InverseTransformPoint((Vector3)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
										float num15 = 0f - num12;
										float num16 = num2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
										float num17 = num16 - 0f;
										num9 = num4 - num9;
										float num18 = (float)deviceFront * num15;
										float num19 = num17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+148]");
										float num20 = num19 * 0f;
										float num21 = num18 + num20;
										float num22 = num9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+14C]");
										float num23 = num22 * 0f;
										float num24 = num23 + num21;
										num12 = (float)obj32 * num24;
										float num25 = num12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
										float num26 = default;
										if (num25 < 0f)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EE0]");
											object obj36 = 0;
											num12 *= 1.1204035E+09f;
											text = num26.ToString((string)obj36);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EE8]");
											obj35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1ED8]");
											obj20 = 0;
											obj33 = 1120403456;
											goto IL_0b37;
										}
										object obj37 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v41+E4]");
										bool flag11 = (nint)0 == 0;
										object obj38 = !flag11;
										if (obj38 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag12 = you == null;
										bool flag13 = !flag12;
										object obj39 = 0;
										UnityEngine.Object obj40 = null;
										if (!flag13)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
											object obj41 = 0;
											object obj42 = obj41;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v61+E4]");
											bool flag14 = (nint)0 == 0;
											object obj43 = !flag14;
											if (obj43 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E64938");
											object obj44 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v33+E4]");
											bool flag15 = (nint)0 == 0;
											object obj45 = !flag15;
											if (obj45 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											UnityEngine.Object obj46 = default;
											bool flag16 = obj46 != null;
											bool flag17 = !flag16;
											obj39 = 0;
											obj40 = null;
											if (!flag17)
											{
												object obj47 = obj41;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X0_v68+E4]");
												bool flag18 = (nint)0 == 0;
												object obj48 = !flag18;
												if (obj48 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E64938");
												object obj49 = default;
												if (obj49 == null)
												{
													goto IL_0ac4;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
												object obj50 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
												UnityEngine.Object obj51 = default;
												you = (Rigidbody)obj51;
												object obj52 = this + 488;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												obj39 = 0;
												obj40 = obj51;
											}
										}
										object obj53 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X0_v46+E4]");
										bool flag19 = (nint)0 == 0;
										object obj54 = !flag19;
										if (obj54 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (!(you != null))
										{
											goto IL_0aa8;
										}
										if ((object)you != null)
										{
											Vector3 linearVelocity = you.linearVelocity;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
											obj33 = 0;
											float num27 = num12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
											if (!(num27 > 0f))
											{
												goto IL_0aa8;
											}
											if ((object)you != null)
											{
												Vector3 linearVelocity2 = you.linearVelocity;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EE0]");
												object obj55 = 0;
												text = num26.ToString((string)obj55);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1ED0]");
												obj35 = 0;
												goto IL_0b97;
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
		goto IL_0ac4;
		IL_0b37:
		string text2 = (string)obj35 + text + (string)obj20;
		object obj56 = this + 200;
		obj56 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X19_v4-8]");
		object obj57 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return false;
	}

	public void FingertipsForTest(Transform[] t)
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I8
		//IL_0048: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I
		object obj = this + 480;
		tips = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PressKey[] array = keys;
		trailCount = 0;
		if (keys == null || array.Length < 1)
		{
			return;
		}
		object obj2 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = keys + 32;
		Transform[] array2 = t;
		object obj5 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X24_v3+v122 @ X22_v4*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			array2 = null;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X24_v3+v122 @ X22_v4*8]");
				object obj9 = (nint)0 + (nint)40;
				obj9 = t;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				array2 = t;
			}
			obj2 = array.Length;
			obj5++;
			if ((nint)obj5 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public void Press(string id)
	{
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I
		//IL_047d: Expected Obj, but got I
		//IL_04c2: Expected Obj, but got I
		//IL_0508: Expected Obj, but got I
		//IL_054c: Expected Obj, but got I4
		//IL_08d4: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_0e64: Expected Obj, but got I
		//IL_0e74: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I
		//IL_06fd: Expected Obj, but got I
		//IL_065c: Expected Obj, but got I
		//IL_0593: Expected Obj, but got I4
		//IL_097a: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I
		//IL_0608: Expected Obj, but got I
		//IL_093d: Expected Obj, but got I4
		//IL_0ca4: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I
		//IL_05d3: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I
		//IL_0ef7: Expected Obj, but got I
		//IL_0683: Expected Obj, but got I4
		//IL_0771: Expected Obj, but got I4
		//IL_0aca: Expected Obj, but got I
		//IL_0f25: Expected F4, but got I
		//IL_0ec8: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I4
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected Obj, but got Unknown
		//IL_07a6: Expected Obj, but got I
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Expected Obj, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_0822: Expected Obj, but got I4
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected Obj, but got Unknown
		//IL_0a23: Expected Obj, but got I
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Expected Obj, but got Unknown
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected Obj, but got Unknown
		//IL_0a90: Expected Obj, but got I4
		//IL_0854: Expected Obj, but got I4
		//IL_0ab5: Expected Obj, but got I4
		//IL_0b4d: Invalid comparison between F8 and I4
		//IL_0b5c: Invalid comparison between F8 and I4
		//IL_0b74: Expected Obj, but got F8
		//IL_0b81: Expected Obj, but got F8
		//IL_0bb6: Expected Obj, but got I4
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected Obj, but got Unknown
		//IL_0c32: Expected Obj, but got I4
		//IL_0d2e: Expected Obj, but got I4
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c67: Expected Obj, but got I
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected Obj, but got Unknown
		//IL_0d63: Expected Obj, but got I
		//IL_0da4: Expected Obj, but got I
		//IL_0d89: Expected Obj, but got I4
		object obj = this + 264;
		pressedId = id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float unscaledTime = Time.unscaledTime;
		dirty = true;
		float num = unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num2 = num + 0f;
		pressedUntil = num2;
		if (id == null)
		{
			return;
		}
		if (id._stringLength <= 5)
		{
			if (id._stringLength == 3)
			{
				char c = id.get_Chars(0);
				switch (c & 0xFFFF)
				{
				case 82:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE8]");
					object obj2 = 0;
					if (id == (string)obj2)
					{
						Record();
					}
					return;
				}
				case 77:
					break;
				default:
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D00]");
				object obj3 = 0;
				string text = (string)obj3;
				if (!(id == (string)obj3))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
				object obj4 = 0;
				object obj5 = obj4;
				bool flag = (byte)((mic ? 1u : 0u) ^ 1u) != 0;
				mic = flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v24+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v24+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v23+48]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v23+48]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v24+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj10 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v40+A0]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+48]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+48]");
						if ((nint)0 == 0)
						{
							goto IL_0da9;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
					object obj12 = 0;
					text = (string)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A113C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EB0]");
				object obj13 = 0;
				object obj14 = obj4;
				if (mic)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EA8]");
					obj13 = 0;
				}
				object obj16;
				if (~(mic ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v29+E4]");
					bool flag4 = (nint)0 == 0;
					object obj15 = !flag4;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj14 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v29+A0]");
					obj16 = (nint)0 + (nint)144;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v29+E4]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj14 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v29+A0]");
					obj16 = (nint)0 + (nint)136;
				}
				object words = obj13;
				object colours = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
				Say((string)words, (Color32[])colours, 0f);
				return;
			}
			if (id._stringLength != 4)
			{
				if (id._stringLength != 5)
				{
					return;
				}
				char c2 = id.get_Chars(0);
				Mode mode;
				switch (c2 & 0xFFFF)
				{
				case 84:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EB8]");
					object obj20 = 0;
					if (id == (string)obj20 && this.mode != (Mode)2)
					{
						mode = (Mode)2;
						break;
					}
					return;
				}
				case 80:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E60]");
					object obj19 = 0;
					if (id == (string)obj19)
					{
						Photo();
					}
					return;
				}
				case 70:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E98]");
					object obj18 = 0;
					if (id == (string)obj18 && this.mode != (Mode)1)
					{
						mode = (Mode)1;
						break;
					}
					return;
				}
				default:
					return;
				}
				this.mode = mode;
			}
			else
			{
				char c3 = id.get_Chars(2);
				int num3 = c3 & 0xFFFF;
				if (num3 != 73)
				{
					if (num3 == 86)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E90]");
						object obj21 = 0;
						if (id == (string)obj21)
						{
							int[] array = fov;
							if (fov == null)
							{
								goto IL_0da9;
							}
							bool flag6 = (int)this.mode < array.Length;
							object obj22 = !flag6;
							if (obj22 == null)
							{
								object obj23 = fov + this.mode;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v52+20]");
								object obj24 = -10;
								object obj25 = obj24 - 30;
								bool flag7 = (nint)obj25 < 0;
								bool flag8 = obj25 == null;
								object obj26 = obj24 ^ 0x1E;
								object obj27 = obj24 ^ obj25;
								object obj28 = obj26 & obj27;
								bool flag9 = (nint)obj28 < 0;
								bool flag10 = flag7 == flag9;
								object obj29 = !flag8;
								object obj30 = flag10 & obj29;
								object obj31 = ~obj30;
								if (obj31 != null)
								{
									obj24 = 30;
								}
								return;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E88]");
							object obj32 = 0;
							if (!(id == (string)obj32))
							{
								return;
							}
							int[] array2 = fov;
							if (fov == null)
							{
								goto IL_0da9;
							}
							bool flag11 = (int)this.mode < array2.Length;
							object obj33 = !flag11;
							if (obj33 == null)
							{
								object obj23 = fov + this.mode;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v52+20]");
								object obj24 = (nint)0 + (nint)10;
								object obj34 = obj24 - 100;
								bool flag12 = (nint)obj34 < 0;
								object obj35 = obj24 ^ 0x64;
								object obj36 = obj24 ^ obj34;
								object obj37 = obj35 & obj36;
								bool flag13 = (nint)obj37 < 0;
								bool flag14 = flag12 == flag13;
								object obj38 = !flag14;
								object obj39 = ~obj38;
								if (obj39 != null)
								{
									obj24 = 100;
								}
								return;
							}
						}
						goto IL_0db7;
					}
					if (num3 != 87)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E70]");
					object obj40 = 0;
					double num4;
					if (id == (string)obj40)
					{
						if (this.mode != (Mode)2)
						{
							int[] array3 = smooth;
							if (smooth == null)
							{
								goto IL_0da9;
							}
							bool flag15 = (int)this.mode < array3.Length;
							object obj41 = !flag15;
							if (obj41 == null)
							{
								object obj23 = smooth + this.mode;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v52+20]");
								object obj42 = -1;
								object obj43 = ~obj42;
								object obj24 = obj42 & obj43;
								return;
							}
							goto IL_0db7;
						}
						num4 = (double)distance + -0.5;
						if (num4 < 1.0)
						{
							num4 = 1.0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E78]");
						object obj44 = 0;
						if (!(id == (string)obj44))
						{
							return;
						}
						if (this.mode != (Mode)2)
						{
							int[] array4 = smooth;
							if (smooth == null)
							{
								goto IL_0da9;
							}
							bool flag16 = (int)this.mode < array4.Length;
							object obj45 = !flag16;
							if (obj45 == null)
							{
								object obj23 = smooth + this.mode;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v52+20]");
								object obj46 = (nint)0 + (nint)1;
								object obj24;
								if ((nint)obj46 >= 5)
								{
									obj24 = 5;
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v52+20]");
								obj24 = (nint)0 + (nint)1;
								return;
							}
							goto IL_0db7;
						}
						num4 = (double)distance + 0.5;
						double num5 = num4 - 5.0;
						bool flag17 = num5 < 0.0;
						bool flag18 = num5 == 0.0;
						object obj47 = num4 ^ 5.0;
						object obj48 = num4 ^ num5;
						object obj49 = obj47 & obj48;
						bool flag19 = (nint)obj49 < 0;
						bool flag20 = flag17 == flag19;
						object obj50 = !flag18;
						object obj51 = flag20 & obj50;
						object obj52 = ~obj51;
						if (obj52 == null)
						{
							num4 = 5.0;
						}
					}
					distance = (float)num4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E80]");
					object obj53 = 0;
					if (!(id == (string)obj53))
					{
						return;
					}
					if (this.mode != (Mode)2)
					{
						bool flag21 = this.mode == 0;
						object obj54 = !flag21;
						if (obj54 == null)
						{
							bool flag22 = (byte)((selfieBack ? 1u : 0u) ^ 1u) != 0;
							selfieBack = flag22;
						}
					}
					else
					{
						bool flag23 = (byte)((thirdFront ? 1u : 0u) ^ 1u) != 0;
						thirdFront = flag23;
					}
				}
			}
		}
		else
		{
			if (id._stringLength != 6)
			{
				if (id._stringLength != 7)
				{
					if (id._stringLength == 8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E68]");
						object obj55 = 0;
						if (id == (string)obj55)
						{
							bool tall = !portrait;
							Orient(tall);
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EA0]");
					object obj56 = 0;
					if (id == (string)obj56)
					{
						NextQuality();
					}
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CF0]");
			object obj57 = 0;
			if (!(id == (string)obj57) || this.mode == 0)
			{
				return;
			}
			this.mode = (Mode)0;
		}
		lensPlaced = false;
		return;
		IL_0db7:
		throw new IndexOutOfRangeException();
		IL_0da9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0db7;
	}

	private unsafe void Orient(bool tall)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_074d: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I
		//IL_0958: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I4
		//IL_0778: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_07b1: Expected Obj, but got I
		//IL_07bc: Expected Obj, but got I4
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0608: Expected Obj, but got I
		//IL_061d: Expected Obj, but got I
		//IL_0631: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_06ab: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I
		//IL_08d2: Expected Obj, but got I
		//IL_08e2: Expected Obj, but got I
		//IL_08f2: Expected Obj, but got I
		//IL_07fb: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I
		//IL_0406: Expected F4, but got I
		//IL_082c: Expected Obj, but got I
		//IL_083d: Expected Obj, but got I
		//IL_085b: Expected Obj, but got I4
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected I4, but got Unknown
		//IL_04f7: Expected Obj, but got I
		//IL_08b3: Expected Obj, but got I
		//IL_0532: Expected Obj, but got I
		//IL_05d2: Expected Obj, but got I4
		//IL_05da: Expected Obj, but got Ref
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected Obj, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		GillaLivCamera gillaLivCamera = (GillaLivCamera)obj;
		bool flag = (byte)(~(gillaLivCamera.monitorOn ? 1u : 0u)) != 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaLivCamera = (GillaLivCamera)obj;
		}
		AudioClip audioClip = gillaLivCamera.shutterSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (UnityEngine.AudioClip)+48]");
		object obj7;
		string text;
		float seconds;
		if ((nint)0 != 0)
		{
			bool flag2 = (byte)(~(recNow ? 1u : 0u)) != 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				bool recording = gillaLivCamera.Recording;
				gillaLivCamera = (GillaLivCamera)obj;
				if (!recording)
				{
					bool flag3 = (byte)(~(gillaLivCamera.monitorOn ? 1u : 0u)) != 0;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						gillaLivCamera = (GillaLivCamera)obj;
					}
					AudioClip audioClip2 = gillaLivCamera.shutterSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v19 (UnityEngine.AudioClip)+48]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v20+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v20+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02e5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v20+98]");
					object obj9 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X10_v21-8]");
						if (0 == (nint)obj7)
						{
							break;
						}
						obj8--;
						obj9 += 16;
						if ((nint)obj8 != 1)
						{
							continue;
						}
						goto IL_02e5;
					}
					object obj10 = obj9 + 34;
					object obj11 = obj6 + obj10;
					object obj12 = obj11 + 312;
					goto IL_07a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EF8]");
			object obj13 = 0;
			bool flag4 = (byte)(~(gillaLivCamera.monitorOn ? 1u : 0u)) != 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				gillaLivCamera = (GillaLivCamera)obj;
			}
			AudioClip audioClip3 = gillaLivCamera.shutterSound;
			text = (string)obj13;
			seconds = 2f;
		}
		else
		{
			string text2;
			if (~(gillaLivCamera.monitorOn ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F10]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (UnityEngine.AudioClip)+50]");
				if ((nint)0 == 0)
				{
					text2 = (string)obj15;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (UnityEngine.AudioClip)+50]");
					text2 = (string)0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v10+A0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F10]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v10+50]");
				if ((nint)0 == 0)
				{
					text2 = (string)obj18;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v10+50]");
					text2 = (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v10+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
			}
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v8+A0]");
			AudioClip audioClip3 = (AudioClip)0;
			text = text2;
			seconds = 2.5f;
		}
		string words = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v5 (UnityEngine.AudioClip)+88]");
		Say(words, (Color32[])0, seconds);
		return;
		IL_05f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F40]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v25+18]");
		string message = (string)obj21 + (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v28+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v31+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v31+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F00]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v30+88]");
		Color32[] colours = (Color32[])0;
		string words2 = (string)obj28;
		float seconds2 = 2f;
		goto IL_0809;
		IL_07a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v20+8]");
		object obj29 = 0;
		object obj30 = !tall;
		object obj31 = 1 & obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v443 @ X0_v20] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v22+10]");
		if ((nint)0 != 0)
		{
			goto IL_0347;
		}
		List<QualityOption> list = options;
		bool flag8 = options == null;
		CameraResolutionDescriptor cameraResolutionDescriptor2 = default;
		CameraResolutionDescriptor cameraResolutionDescriptor = cameraResolutionDescriptor2;
		object obj33 = default;
		object obj32 = obj33;
		CameraResolutionDescriptor resolutionInOrientation;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v37 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
			bool flag9 = (nint)0 < (nint)1;
			cameraResolutionDescriptor = cameraResolutionDescriptor2;
			obj32 = obj33;
			if (!flag9)
			{
				object obj34 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v32+E4]");
				bool flag10 = (nint)0 == 0;
				object obj35 = !flag10;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					list = options;
					obj34 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v32+A0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v33+48]");
				object obj37 = 0;
				QualityOption qualityOption = list.get_Item(qualityAt);
				object obj38 = !tall;
				LckCameraOrientation orientation = (LckCameraOrientation)(1 & obj38);
				CameraResolutionDescriptor cameraResolutionDescriptor3 = default;
				resolutionInOrientation = cameraResolutionDescriptor3.GetResolutionInOrientation(orientation);
				object obj39 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v36+12E]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v36+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0573;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v36+98]");
				object obj41 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X10_v13-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj40--;
					obj41 += 16;
					if ((nint)obj40 != 1)
					{
						continue;
					}
					goto IL_0573;
				}
				object obj42 = obj41 + 30;
				object obj43 = obj39 + obj42;
				object obj44 = obj43 + 312;
				goto IL_08a3;
			}
		}
		goto IL_05f8;
		IL_0347:
		object obj45 = obj;
		bool flag11 = !tall;
		portrait = tall;
		lensPlaced = false;
		object obj46 = !flag11;
		object obj47 = ~obj46;
		object obj48;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F38]");
			obj48 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F48]");
			obj48 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v51+E4]");
		bool flag12 = (nint)0 == 0;
		object obj49 = !flag12;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj50 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v45+A0]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v46+90]");
		colours = (Color32[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		seconds2 = 0f;
		words2 = (string)obj48;
		goto IL_0809;
		IL_08a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v41+8]");
		obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v654 @ X0_v41] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v43+10]");
		bool flag13 = (nint)0 == 0;
		object obj52 = !flag13;
		object obj53 = default;
		obj31 = (object)(&obj53);
		cameraResolutionDescriptor = resolutionInOrientation;
		object obj54 = default;
		obj32 = obj54;
		if (obj52 != null)
		{
			goto IL_0347;
		}
		goto IL_05f8;
		IL_0573:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_08a3;
		IL_0809:
		Say(words2, colours, seconds2);
		return;
		IL_02e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_07a1;
	}

	private unsafe static CameraTrackDescriptor Oriented(CameraTrackDescriptor d, bool tall)
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		//IL_0026: Expected Ref, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0044: Expected native int or pointer, but got VT
		//IL_0056: Expected native int or pointer, but got VT
		object obj = !tall;
		LckCameraOrientation orientation = (LckCameraOrientation)(1 & obj);
		CameraTrackDescriptor result = (CameraTrackDescriptor)(((CameraTrackDescriptor*)(nint)d)->CameraResolutionDescriptor = ((CameraResolutionDescriptor*)d)->GetResolutionInOrientation(orientation));
		CameraTrackDescriptor cameraTrackDescriptor = default;
		((CameraTrackDescriptor*)(nint)cameraTrackDescriptor)->AudioBitrate = d.AudioBitrate;
		((CameraTrackDescriptor*)(nint)cameraTrackDescriptor)->CameraResolutionDescriptor = d.CameraResolutionDescriptor;
		return result;
	}

	private void Switch(Mode to)
	{
		if (mode != to)
		{
			mode = to;
			lensPlaced = false;
		}
	}

	private void NextQuality()
	{
		//IL_003a: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_0386: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03ac: Expected Obj, but got I
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03ce: Expected I4, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0448: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		List<QualityOption> list = options;
		if (options == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
		if ((nint)0 < (nint)2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		GillaLivCamera gillaLivCamera = (GillaLivCamera)obj;
		bool flag = (byte)(~(gillaLivCamera.monitorOn ? 1u : 0u)) != 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaLivCamera = (GillaLivCamera)obj;
		}
		AudioClip audioClip = gillaLivCamera.shutterSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v7 (UnityEngine.AudioClip)+48]");
		if ((nint)0 == 0)
		{
			return;
		}
		if (gillaLivCamera.Recording)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v28+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EF8]");
			object words = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v24+88]");
			Say((string)words, (Color32[])0, 2f);
			return;
		}
		List<QualityOption> list2 = options;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			list2 = options;
			obj6 = obj;
		}
		object obj8 = qualityAt + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v9 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
		object obj10 = obj8 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v12+48]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v9 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
		object obj12 = obj10 * 0;
		int index = obj8 - obj12;
		QualityOption qualityOption = list2.get_Item(index);
		LckCameraOrientation orientation = (LckCameraOrientation)((portrait ? 1 : 0) ^ 1);
		CameraResolutionDescriptor cameraResolutionDescriptor = default;
		CameraResolutionDescriptor resolutionInOrientation = cameraResolutionDescriptor.GetResolutionInOrientation(orientation);
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v15+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_020a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v15+98]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X10_v10-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj15--;
			obj16 += 16;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_020a;
		}
		object obj17 = obj16 + 30;
		object obj18 = obj13 + obj17;
		object obj19 = obj18 + 312;
		goto IL_0429;
		IL_0429:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X0_v13] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v15+10]");
		if ((nint)0 != 0)
		{
			qualityAt = index;
			return;
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v17+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F00]");
		object words2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v20+88]");
		Say((string)words2, (Color32[])0, 2f);
		return;
		IL_020a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0429;
	}

	private void Photo()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I
		//IL_046d: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+48]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+48]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v24+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v25+48]");
				obj5 = 0;
			}
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v14+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v14+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0137;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v14+98]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X10_v11-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj11--;
				obj12 += 16;
				if ((nint)obj11 != 1)
				{
					continue;
				}
				goto IL_0137;
			}
			object obj13 = obj12 + 67;
			object obj14 = obj9 + obj13;
			object obj15 = obj14 + 312;
			goto IL_03de;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F10]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+50]");
			if ((nint)0 == 0)
			{
				text = (string)obj16;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+50]");
				text = (string)0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v10+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F10]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+50]");
			if ((nint)0 == 0)
			{
				text = (string)obj19;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+50]");
				text = (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj20 = !flag3;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
		}
		object obj21 = obj;
		float seconds = 2.5f;
		string text2 = text;
		goto IL_03f2;
		IL_03f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v5+A0]");
		object obj22 = 0;
		string words = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v6+88]");
		Say(words, (Color32[])0, seconds);
		return;
		IL_03de:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X0_v13] (should have been resolved before IL gen)");
		LckResult lckResult = default;
		if (~(lckResult._success ? 1u : 0u) == 0)
		{
			float unscaledTime = Time.unscaledTime;
			float num = unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
			float num2 = num + 0f;
			flashUntil = num2;
			Sound(shutterSound);
			return;
		}
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F08]");
		object doing = 0;
		string text3 = Short(lckResult, (string)doing);
		obj21 = obj;
		seconds = 3f;
		text2 = text3;
		goto IL_03f2;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_03de;
	}

	private unsafe void Record()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I4
		//IL_083c: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_07de: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I
		//IL_04cd: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_0740: Expected Obj, but got I
		//IL_0750: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got Ref
		//IL_02e9: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_06e3: Expected Obj, but got I
		//IL_06f3: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I
		//IL_07b7: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I4
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_053e: Expected Obj, but got I4
		//IL_0670: Expected Obj, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_080f: Expected Obj, but got I
		//IL_081f: Expected Obj, but got I
		//IL_0576: Expected Obj, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_05a3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v12+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+48]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool canRecordHere = CanRecordHere;
			bool flag3 = !canRecordHere;
			object obj6 = !flag3;
			GillaLivCamera gillaLivCamera = (GillaLivCamera)canRecordHere;
			if (obj6 == null)
			{
				bool recording = ((GillaLivCamera)canRecordHere).Recording;
				bool flag4 = !recording;
				gillaLivCamera = (GillaLivCamera)recording;
				if (flag4)
				{
					GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
					object obj7 = default;
					string text = ((Enum)(&obj7)).ToString();
					string text2 = text.ToUpperInvariant();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F20]");
					object obj8 = 0;
					string words = (string)obj8 + text2;
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v44+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v44+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v45+88]");
					Say(words, (Color32[])0, 3f);
					return;
				}
			}
			bool recording2 = gillaLivCamera.Recording;
			object obj12 = obj;
			if (recording2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v27+48]");
				object obj15 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v28+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v28+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01f3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v28+98]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X10_v22-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					obj18--;
					obj19 += 16;
					if ((nint)obj18 != 1)
					{
						continue;
					}
					goto IL_01f3;
				}
				object obj20 = obj19 + 24;
				object obj21 = obj16 + obj20;
				object obj22 = obj21 + 312;
				goto IL_071c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+A0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v17+48]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v18+12E]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v18+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0375;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v18+98]");
			object obj29 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X10_v14-8]");
				if (0 == (nint)obj27)
				{
					break;
				}
				obj28--;
				obj29 += 16;
				if ((nint)obj28 != 1)
				{
					continue;
				}
				goto IL_0375;
			}
			object obj30 = obj29 + 20;
			object obj31 = obj26 + obj30;
			object obj32 = obj31 + 312;
			goto IL_0779;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v12+E4]");
		string text3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F10]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+50]");
			if ((nint)0 == 0)
			{
				text3 = (string)obj33;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+50]");
				text3 = (string)0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj34 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v10+A0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F10]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v10+50]");
			if ((nint)0 == 0)
			{
				text3 = (string)obj36;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v10+50]");
				text3 = (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v10+E4]");
			bool flag8 = (nint)0 == 0;
			object obj37 = !flag8;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
		}
		object obj38 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+A0]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v9+88]");
		Color32[] colours = (Color32[])0;
		float seconds = 2.5f;
		string words2 = text3;
		goto IL_07ec;
		IL_0779:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v483 @ X0_v21] (should have been resolved before IL gen)");
		LckResult lckResult = default;
		if (~(lckResult._success ? 1u : 0u) == 0)
		{
			return;
		}
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v24+E4]");
		bool flag9 = (nint)0 == 0;
		object obj41 = !flag9;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F28]");
		object doing = 0;
		string text4 = Short(lckResult, (string)doing);
		object obj42 = obj;
		seconds = 3f;
		goto IL_07ff;
		IL_071c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ X0_v35] (should have been resolved before IL gen)");
		LckResult lckResult2 = default;
		bool flag10 = (byte)(~(lckResult2._success ? 1u : 0u)) != 0;
		object obj43 = !flag10;
		if (obj43 == null)
		{
			object obj44 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v38+E4]");
			bool flag11 = (nint)0 == 0;
			object obj45 = !flag11;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F30]");
			object doing2 = 0;
			text4 = Short(lckResult2, (string)doing2);
			obj42 = obj;
			seconds = 2.5f;
			goto IL_07ff;
		}
		return;
		IL_01f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		object obj46 = 24;
		goto IL_071c;
		IL_07ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v15+A0]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v16+88]");
		colours = (Color32[])0;
		words2 = text4;
		goto IL_07ec;
		IL_07ec:
		Say(words2, colours, seconds);
		return;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj46 = 20;
		goto IL_0779;
	}

	private void Say(string words, Color32[] colours, float seconds)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		notice = words;
		object obj = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 272;
		noticeColours = colours;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + seconds;
		dirty = true;
		noticeUntil = num;
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_15e4: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_1602: Expected Obj, but got I
		//IL_1618: Expected Obj, but got I
		//IL_1632: Expected Obj, but got I4
		//IL_1c13: Expected Obj, but got I4
		//IL_16e8: Expected Obj, but got I
		//IL_1712: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I4
		//IL_1655: Expected Obj, but got I
		//IL_1665: Expected Obj, but got I
		//IL_168f: Expected Obj, but got I
		//IL_169f: Expected Obj, but got I
		//IL_16c9: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got I
		//IL_040c: Expected Obj, but got I4
		//IL_054c: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_05f7: Expected Obj, but got I4
		//IL_060d: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_063c: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I4
		//IL_17cd: Expected Obj, but got I
		//IL_17dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e2: Expected Obj, but got Unknown
		//IL_180a: Expected Obj, but got I4
		//IL_06b0: Expected Obj, but got I4
		//IL_06db: Expected F4, but got I
		//IL_065c: Expected Obj, but got I4
		//IL_1855: Expected Obj, but got I
		//IL_1865: Unknown result type (might be due to invalid IL or missing references)
		//IL_186a: Expected Obj, but got Unknown
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Expected I4, but got Unknown
		//IL_189f: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I8
		//IL_0752: Expected VT, but got I4
		//IL_18cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d0: Expected I4, but got Unknown
		//IL_068e: Expected Obj, but got I8
		//IL_07d8: Invalid comparison between I4 and F8
		//IL_080a: Expected F8, but got I4
		//IL_082b: Expected Obj, but got I4
		//IL_0868: Expected Obj, but got I4
		//IL_1966: Expected Obj, but got I
		//IL_197e: Expected Obj, but got I
		//IL_085a: Expected Obj, but got I4
		//IL_1c3e: Expected Obj, but got I
		//IL_1c5b: Expected Obj, but got I
		//IL_1c6b: Expected Obj, but got I
		//IL_1c9d: Expected Obj, but got I
		//IL_1cad: Expected Obj, but got I
		//IL_1ce9: Expected F4, but got I4
		//IL_0884: Expected Obj, but got I4
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_0a7c: Expected F8, but got I4
		//IL_0a95: Expected VT, but got I4
		//IL_0a9e: Expected Obj, but got I4
		//IL_19de: Invalid comparison between F4 and I
		//IL_1a00: Expected Obj, but got I4
		//IL_192f: Expected Obj, but got I4
		//IL_0876: Expected Obj, but got I4
		//IL_08aa: Expected Obj, but got I
		//IL_1ba4: Expected VT, but got F4
		//IL_1bbd: Expected VT, but got F4
		//IL_1ddf: Expected Obj, but got I
		//IL_1e09: Expected Obj, but got I4
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Expected Obj, but got Unknown
		//IL_1492: Expected Obj, but got I4
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b7: Expected Obj, but got Unknown
		//IL_0d29: Invalid comparison between F4 and I
		//IL_0d3b: Expected F4, but got I4
		//IL_0d44: Expected F4, but got I4
		//IL_0d4d: Expected F4, but got I4
		//IL_08ed: Expected Obj, but got I4
		//IL_08fd: Expected Obj, but got I
		//IL_10ee: Expected Obj, but got I4
		//IL_14cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d0: Expected Obj, but got Unknown
		//IL_14d9: Expected Obj, but got F4
		//IL_14f8: Expected F4, but got Obj
		//IL_1537: Expected VT, but got I4
		//IL_1a26: Expected Obj, but got I
		//IL_159f: Expected VT, but got I4
		//IL_1d1c: Expected Obj, but got I
		//IL_1d39: Expected Obj, but got I
		//IL_1d51: Expected Obj, but got I
		//IL_1d7b: Expected Obj, but got I
		//IL_1d92: Expected F4, but got Obj
		//IL_1d9a: Invalid comparison between F4 and Obj
		//IL_1dc1: Expected Obj, but got I4
		//IL_0cfb: Expected Obj, but got I4
		//IL_1201: Expected Obj, but got I4
		//IL_1b8c: Expected Obj, but got I4
		//IL_1227: Expected Obj, but got I
		//IL_1e2f: Expected Obj, but got I
		//IL_1ee5: Expected VT, but got I4
		//IL_1ee5: Expected VT, but got I4
		//IL_1f61: Expected VT, but got F4
		//IL_1f6a: Expected VT, but got I4
		//IL_1f73: Expected VT, but got I4
		//IL_1a8a: Expected VT, but got F8
		//IL_1272: Expected Obj, but got I4
		//IL_11b7: Expected Obj, but got I4
		//IL_1fab: Expected Obj, but got I4
		//IL_0e06: Expected F4, but got VT
		//IL_13af: Expected F8, but got I4
		//IL_12a1: Expected Obj, but got I
		//IL_0efc: Invalid comparison between F8 and I
		//IL_0e3c: Expected VT, but got F8
		//IL_0e58: Expected F8, but got VT
		//IL_0e7b: Expected VT, but got I4
		//IL_0e83: Expected VT, but got Ref
		//IL_1ac3: Expected Obj, but got I4
		//IL_0fac: Expected Obj, but got I
		//IL_0fd6: Expected Obj, but got I4
		//IL_0f68: Expected F8, but got I
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fc: Expected Obj, but got Unknown
		//IL_1404: Expected VT, but got F4
		//IL_140c: Expected VT, but got F4
		//IL_1425: Expected F8, but got I4
		//IL_1456: Expected VT, but got I4
		//IL_145e: Expected Obj, but got Ref
		//IL_1003: Expected F8, but got I
		//IL_1027: Expected VT, but got I4
		//IL_1027: Expected VT, but got Ref
		//IL_1052: Invalid comparison between F8 and I
		//IL_12f8: Expected Obj, but got I
		//IL_1aeb: Expected Obj, but got I4
		//IL_1079: Expected F8, but got I
		//IL_1332: Expected Obj, but got I
		//IL_1fd1: Expected Obj, but got I
		//IL_1fe1: Expected F4, but got I
		//IL_1ff1: Expected F8, but got I
		//IL_2013: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = lens == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		bool flag4 = (byte)(~(awake ? 1u : 0u)) != 0;
		object obj5 = !flag4;
		if (obj5 == null && ~(recNow ? 1u : 0u) != 0)
		{
			return;
		}
		Camera main = Camera.main;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = main == null;
		bool flag7 = !flag6;
		object obj8 = !flag7;
		if (obj8 != null)
		{
			return;
		}
		GillaLivLens gillaLivLens = lens;
		object obj9;
		if ((object)lens != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v13+E4]");
			bool flag8 = (nint)0 == 0;
			object obj11 = !flag8;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v13+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X9_v6+6C]");
			object obj13 = (nint)0 + (nint)2;
			bool flag9 = obj13 == null;
			object obj14 = !flag9;
			UnityEngine.Object obj15 = null;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
				object layerName = 0;
				int num = LayerMask.NameToLayer((string)layerName);
				object obj16 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v109+E4]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
				object layerName2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v109+A0]");
				object obj18 = 0;
				int num2 = LayerMask.NameToLayer((string)layerName2);
				object obj19 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
				object layerName3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v111+A0]");
				object obj20 = 0;
				int num3 = LayerMask.NameToLayer((string)layerName3);
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v13+A0]");
				object obj21 = 0;
				obj15 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v13+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v13+A0]");
			object obj23 = 0;
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v19+E4]");
			bool flag12 = (nint)0 == 0;
			object obj25 = !flag12;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = main != eyesCam;
			bool flag14 = !flag13;
			object obj26 = 0;
			UnityEngine.Object obj27 = eyesCam;
			if (!flag14)
			{
				object obj28 = this + 520;
				eyesCam = main;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj29 = this + 528;
				eyesData = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((object)main == null)
				{
					goto IL_15a5;
				}
				obj27 = (UnityEngine.Object)(this + 528);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE50]");
				object obj30 = 0;
				obj26 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			}
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v24+E4]");
			bool flag15 = (nint)0 == 0;
			object obj32 = !flag15;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18;
			if (eyesData != null)
			{
				UniversalAdditionalCameraData universalAdditionalCameraData = eyesData;
				if ((object)eyesData == null)
				{
					goto IL_15a5;
				}
				bool flag16 = !universalAdditionalCameraData.m_RenderPostProcessing;
				bool flag17 = !flag16;
				flag18 = flag17;
			}
			else
			{
				flag18 = false;
			}
			GillaLivLens gillaLivLens2 = lens;
			if ((object)lens != null)
			{
				object obj33 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v28+E4]");
				bool flag19 = (nint)0 == 0;
				object obj34 = !flag19;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(gillaLivLens2.Data__BackingField != null))
				{
					goto IL_1749;
				}
				GillaLivLens gillaLivLens3 = lens;
				if ((object)lens != null)
				{
					UniversalAdditionalCameraData universalAdditionalCameraData2 = gillaLivLens3.Data__BackingField;
					if ((object)gillaLivLens3.Data__BackingField != null)
					{
						bool flag20 = !universalAdditionalCameraData2.m_RenderPostProcessing;
						object obj35 = !flag20;
						if ((flag18 ? 1 : 0) != (nint)obj35)
						{
							universalAdditionalCameraData2.m_RenderPostProcessing = flag18;
						}
						goto IL_1749;
					}
				}
			}
		}
		goto IL_15a5;
		IL_13bc:
		Vector3 upwards = default;
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref axis, ref upwards);
		if (smooth == null)
		{
			goto IL_15a5;
		}
		object obj36 = smooth + 32;
		float num4;
		Quaternion b = (Quaternion)num4;
		float num5;
		Quaternion a = (Quaternion)num5;
		float num7 = default;
		double num6 = num7;
		double num8 = num7;
		double num9 = 1112014848.0;
		float unscaledDeltaTime;
		float num10 = unscaledDeltaTime;
		float num11 = num5;
		double num13;
		double num12 = num13;
		double num15;
		float num14 = (float)num15;
		double num16 = num7;
		Quaternion rotation = (Quaternion)0;
		object obj37 = (object)(&upwards);
		goto IL_193d;
		IL_10b7:
		Transform transform;
		Vector3 position = transform.position;
		object obj38 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X0_v137+E4]");
		bool flag21 = (nint)0 == 0;
		object obj39 = !flag21;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (upMark != null)
		{
			if ((object)upMark != null)
			{
				Vector3 position2 = upMark.position;
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Vector3 position3 = transform2.position;
					num4 = unscaledDeltaTime - unscaledDeltaTime;
					object obj40 = 0;
					goto IL_1b62;
				}
			}
		}
		else
		{
			Transform transform3 = base.transform;
			if ((object)transform3 != null)
			{
				Vector3 up = transform3.up;
				num4 = unscaledDeltaTime;
				object obj40 = 0;
				goto IL_1b62;
			}
		}
		goto IL_15a5;
		IL_1749:
		float num106;
		double num107;
		float num108;
		if ((object)main != null)
		{
			int cullingMask = main.cullingMask;
			int cullingMask2;
			if (mode == (Mode)1)
			{
				bool flag22 = (object)gillaLivLens.Cam__BackingField == null;
				object obj41 = !flag22;
				cullingMask2 = cullingMask;
				if (obj41 == null)
				{
					goto IL_15a5;
				}
			}
			else
			{
				if ((object)gillaLivLens.Cam__BackingField == null)
				{
					goto IL_15a5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+70]");
				bool flag23 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+70]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+70]");
				object obj42 = num17 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+70]");
				object obj43 = 0 & obj42;
				bool flag24 = (nint)obj43 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+70]");
				object obj44 = 1 << 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+6C]");
				object obj45 = 1 << 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+74]");
				object obj46 = 1 << 0;
				bool flag25 = flag23 == flag24;
				object obj47 = !flag25;
				object obj48 = ~obj47;
				if (obj48 == null)
				{
					obj44 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+6C]");
				bool flag26 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+6C]");
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+6C]");
				object obj49 = num18 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+6C]");
				object obj50 = 0 & obj49;
				bool flag27 = (nint)obj50 < 0;
				bool flag28 = flag26 == flag27;
				object obj51 = !flag28;
				object obj52 = ~obj51;
				object obj53 = ((obj52 != null) ? (~obj45) : ((object)4294967295L));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+74]");
				bool flag29 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+74]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+74]");
				object obj54 = num19 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v14+74]");
				object obj55 = 0 & obj54;
				bool flag30 = (nint)obj55 < 0;
				int num20 = cullingMask | obj44;
				bool flag31 = flag29 == flag30;
				object obj56 = !flag31;
				object obj57 = ~obj56;
				object obj58 = ((obj57 != null) ? (~obj46) : ((object)4294967295L));
				object obj59 = obj58 & obj53;
				cullingMask2 = obj59 & num20;
			}
			gillaLivLens.Cam__BackingField.cullingMask = cullingMask2;
			float fieldOfView = LensFov();
			gillaLivLens.Cam__BackingField.fieldOfView = fieldOfView;
			object obj60 = 17285120 + 1560;
			bool flag32 = mode == 0;
			Camera camera = gillaLivLens.Cam__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X9_v15+v545 @ Z_v9 (System.Boolean)*4]");
			camera.nearClipPlane = 0f;
			float farClipPlane = main.farClipPlane;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			gillaLivLens.Cam__BackingField.farClipPlane = farClipPlane;
			CameraClearFlags clearFlags = main.clearFlags;
			gillaLivLens.Cam__BackingField.clearFlags = clearFlags;
			Color backgroundColor = main.backgroundColor;
			gillaLivLens.Cam__BackingField.backgroundColor = (Color)0;
			Transform transform4 = main.transform;
			if ((object)transform4 != null)
			{
				Vector3 position4 = transform4.position;
				Transform transform5 = main.transform;
				if ((object)transform5 != null)
				{
					Vector3 lossyScale = transform5.lossyScale;
					double num21 = ((!(1112014848.0 < 1.0)) ? 1112014848.0 : 1.0);
					unscaledDeltaTime = Time.unscaledDeltaTime;
					double num27 = default;
					if (mode != (Mode)1)
					{
						bool flag33 = mode == 0;
						object obj61 = !flag33;
						if (obj61 == null)
						{
							object obj62 = obj;
							if (!selfieBack)
							{
								object obj63 = 48;
							}
							else
							{
								object obj63 = 64;
							}
							if (!selfieBack)
							{
								object obj64 = 56;
							}
							else
							{
								object obj64 = 72;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X0_v131+E4]");
							bool flag34 = (nint)0 == 0;
							object obj65 = !flag34;
							if (obj65 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v685 @ X8_v83]");
							if ((UnityEngine.Object)0 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v685 @ X8_v83]");
								bool flag35 = (nint)0 == 0;
								object obj66 = !flag35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v685 @ X8_v83]");
								transform = (Transform)0;
								if (obj66 != null)
								{
									goto IL_10b7;
								}
							}
							else
							{
								transform = base.transform;
								if ((object)transform != null)
								{
									goto IL_10b7;
								}
							}
						}
						else
						{
							Transform transform6 = main.transform;
							if ((object)transform6 != null)
							{
								Vector3 forward = transform6.forward;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj67 = 0;
								object obj68 = obj67;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v35+A0]");
								object obj69 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+18]");
								nint num22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+18]");
								object obj70 = num22 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+1C]");
								nint num23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+1C]");
								object obj71 = num23 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
								object obj72 = 0;
								object obj73 = obj72;
								object obj74 = obj70 + obj71;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+20]");
								nint num24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+20]");
								object obj75 = num24 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ X8_v38+A0]");
								object obj76 = 0;
								object obj77 = obj75 + obj74;
								bool flag36 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj77) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj76);
								float num25 = num7;
								float num26 = (float)num27;
								float num28 = num7;
								float num29 = 1.1120148E+09f;
								float num30 = unscaledDeltaTime;
								if (!flag36)
								{
									float num31 = unscaledDeltaTime;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+18]");
									float num32 = num31 * 0f;
									float num33 = 1.1120148E+09f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+1C]");
									float num34 = num33 * 0f;
									float num35 = num7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+20]");
									num26 = num35 * 0f;
									float num36 = num32 + num34;
									float num37 = num26 + num36;
									float num38 = num37 / (float)obj77;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+18]");
									float num39 = 0f * num38;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+1C]");
									num25 = 0f * num38;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v36+20]");
									float num40 = 0f * num38;
									num30 = unscaledDeltaTime - num39;
									num29 = 1.1120148E+09f - num25;
									num28 = num7 - num40;
								}
								float num41 = num30 * num30;
								float num42 = num29 * num29;
								float num43 = num41 + num42;
								float num44 = num28 * num28;
								float num45 = num43 + num44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								bool flag37 = !(num45 < 0f);
								float num46 = num44;
								float num47 = num45;
								object obj78 = 0;
								if (!flag37)
								{
									Transform transform7 = main.transform;
									if ((object)transform7 == null)
									{
										goto IL_15a5;
									}
									Vector3 up2 = transform7.up;
									object obj79 = obj67;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X8_v72+A0]");
									object obj80 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+18]");
									nint num48 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+18]");
									object obj81 = num48 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+1C]");
									nint num49 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+1C]");
									object obj82 = num49 * 0;
									object obj83 = obj72;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X8_v75+A0]");
									object obj84 = 0;
									object obj85 = obj81 + obj82;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+20]");
									nint num50 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+20]");
									object obj86 = num50 * 0;
									num47 = (float)obj86 + (float)obj85;
									num46 = (float)obj84;
									bool flag38 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num47) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj84);
									num28 = num25;
									num29 = num44;
									num30 = num45;
									obj78 = 0;
									if (!flag38)
									{
										float num51 = num45;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+18]");
										float num52 = num51 * 0f;
										float num53 = num44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+1C]");
										float num54 = num53 * 0f;
										float num55 = num25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+20]");
										num26 = num55 * 0f;
										float num56 = num52 + num54;
										float num57 = num26 + num56;
										float num58 = num57 / num47;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+18]");
										num46 = 0f * num58;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+1C]");
										float num59 = 0f * num58;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v73+20]");
										num47 = 0f * num58;
										num30 = num45 - num46;
										num29 = num44 - num59;
										num28 = num25 - num47;
										num25 = num59;
										obj78 = 0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								object obj87 = 0;
								object obj88 = obj87;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X0_v74+E4]");
								bool flag39 = (nint)0 == 0;
								object obj89 = !flag39;
								if (obj89 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								float num60 = num26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								bool flag40 = !(num60 > 0f);
								float num61 = 0f;
								float num62 = 0f;
								float num63 = 0f;
								if (!flag40)
								{
									num63 = num30 / num26;
									num62 = num29 / num26;
									num61 = num28 / num26;
								}
								float num64 = 0f - num63;
								float num65 = 0f - num62;
								float num66 = 0f - num61;
								float num67 = (thirdFront ? num63 : num64);
								float num68 = (thirdFront ? num62 : num65);
								float num69 = (thirdFront ? num61 : num66);
								object obj90 = obj67;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1444 @ X8_v49+A0]");
								object obj91 = 0;
								float num70 = num69;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v50+18]");
								float num71 = num70 * 0f;
								float num72 = num68;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v50+18]");
								float num73 = num72 * 0f;
								float num74 = num69;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v50+1C]");
								float num75 = num74 * 0f;
								float num76 = num68;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v50+20]");
								float num77 = num76 * 0f;
								float num78 = num67;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v50+20]");
								float num79 = num78 * 0f;
								float num80 = num75 - num77;
								float num81 = num79 - num71;
								Quaternion quaternion2 = Quaternion.Internal_AngleAxis(-25f, ref axis);
								Vector3 vector = (Quaternion)0 * (Vector3)0;
								double num82 = -25.0 * (double)distance;
								float num83 = num81 * distance;
								float num84 = num73 * distance;
								double num85 = num21 * num82;
								double num86 = num21 * (double)num83;
								double num87 = num21 * (double)num84;
								bool flag41 = (byte)(~(lensPlaced ? 1u : 0u)) != 0;
								axis = (Vector3)num80;
								Quaternion quaternion3 = (Quaternion)0;
								Vector3 vector2 = (Vector3)0;
								if (!flag41)
								{
									float num88 = unscaledDeltaTime;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
									float num89 = num88 / 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
									num83 = (float)thirdOffset;
									num84 = 1f - num89;
									Vector3 vector3 = Vector3.Internal_Slerp(ref axis, ref upwards, num84);
									upwards = (Vector3)num85;
									axis = thirdOffset;
									num85 = num84;
									num87 = (double)thirdOffset;
									num86 = 1.0;
									num82 = 1.0;
									quaternion3 = (Quaternion)0;
									vector2 = (Vector3)(&upwards);
								}
								thirdOffset = (Vector3)num85;
								object obj92 = obj87;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1549 @ X0_v83+E4]");
								bool flag42 = (nint)0 == 0;
								object obj93 = !flag42;
								if (obj93 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								double num90 = num85 * num85;
								double num91 = num86 * num86;
								double num92 = num90 + num91;
								double num93 = num87 * num87;
								double num94 = num92 + num93;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								double num95 = num85;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								bool flag43 = !(num95 > 0.0);
								double num96 = num73;
								double num97 = num81;
								double num98 = -25.0;
								if (!flag43)
								{
									num98 = (double)thirdOffset / num85;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+21C]");
									num97 = 0.0 / num85;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+220]");
									num94 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+220]");
									num96 = 0.0 / num85;
								}
								object obj94 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ X0_v86+E4]");
								bool flag44 = (nint)0 == 0;
								object obj95 = !flag44;
								if (obj95 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								int num99 = Solid();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
								object obj96 = 0;
								object obj97 = obj96;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ X8_v59+E4]");
								bool flag45 = (nint)0 == 0;
								object obj98 = !flag45;
								if (obj98 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
								num6 = 0.0;
								object obj99 = default;
								QueryTriggerInteraction queryTriggerInteraction = default;
								bool flag46 = Physics.SphereCast((Vector3)(&obj99), farClipPlane, (Vector3)num99, out *(RaycastHit*)1, 50f, 0, queryTriggerInteraction);
								object obj100 = default;
								double num100 = (double)obj100;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
								double num101 = num100 + 0.0;
								double num102 = num101;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
								if (num102 < 0.0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
									num101 = 0.0;
								}
								bool flag47 = !flag46;
								object obj101 = !flag47;
								object obj102 = ~obj101;
								if (obj102 != null)
								{
									num101 = num85;
								}
								double num103 = num98 * num101;
								double num104 = num97 * num101;
								double num105 = num96 * num101;
								num10 = farClipPlane + (float)num103;
								num9 = 1112014848.0 + num104;
								num8 = (double)num7 + num105;
								object obj103 = obj67;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1652 @ X8_v64+A0]");
								object obj104 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X8_v65+18]");
								num106 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X8_v65+20]");
								num107 = 0.0;
								Quaternion quaternion4 = Quaternion.Internal_LookRotation(ref axis, ref upwards);
								num108 = (float)num104;
								rotation = (Quaternion)0;
								goto IL_153c;
							}
						}
					}
					else
					{
						Transform transform8 = main.transform;
						if ((object)transform8 != null)
						{
							Vector3 forward2 = transform8.forward;
							Transform transform9 = main.transform;
							if ((object)transform9 != null)
							{
								quaternion = transform9.rotation;
								if (smooth != null)
								{
									obj36 = smooth + 36;
									float num109 = unscaledDeltaTime;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
									float num110 = num109 * 0f;
									double num111 = 1112014848.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
									double num112 = num111 * 0.0;
									float num113 = num7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
									float num114 = num113 * 0f;
									double num115 = num21 * (double)num110;
									num15 = num21 * num112;
									double num116 = num21 * (double)num114;
									num10 = farClipPlane + (float)num115;
									num9 = 1112014848.0 + num15;
									num8 = (double)num7 + num116;
									b = (Quaternion)upwards;
									a = (Quaternion)axis;
									num6 = num21;
									num11 = unscaledDeltaTime;
									num12 = 1112014848.0;
									num14 = num7;
									num16 = num27;
									rotation = (Quaternion)0;
									obj37 = 0;
									goto IL_193d;
								}
							}
						}
					}
				}
			}
		}
		goto IL_15a5;
		IL_15a5:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_1b62:
		object obj105 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1425 @ X0_v142+E4]");
		bool flag48 = (nint)0 == 0;
		object obj106 = !flag48;
		if (obj106 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v685 @ X8_v83]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj107 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X0_v153+E4]");
			bool flag49 = (nint)0 == 0;
			object obj108 = !flag49;
			if (obj108 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v595 @ X9_v27]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v595 @ X9_v27]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v595 @ X9_v27]");
					Vector3 position5 = ((Transform)0).position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v685 @ X8_v83]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLivCamera)+v685 @ X8_v83]");
						Vector3 position6 = ((Transform)0).position;
						num5 = unscaledDeltaTime - unscaledDeltaTime;
						num13 = 1112014848.0 - 1112014848.0;
						num15 = (double)num7 - (double)num7;
						goto IL_13bc;
					}
				}
				goto IL_15a5;
			}
		}
		Transform transform10 = base.transform;
		if ((object)transform10 != null)
		{
			Vector3 forward3 = transform10.forward;
			num15 = num7;
			num13 = 1112014848.0;
			num5 = unscaledDeltaTime;
			goto IL_13bc;
		}
		goto IL_15a5;
		IL_153c:
		num11 = num106;
		num12 = num107;
		num14 = num108;
		num16 = num6;
		goto IL_1b9a;
		IL_1b9a:
		lensRot = (Quaternion)num11;
		lensPos = (Vector3)num10;
		lensPlaced = true;
		if ((object)lens != null)
		{
			Transform transform11 = lens.transform;
			if ((object)transform11 != null)
			{
				transform11.SetPositionAndRotation((Vector3)0, rotation);
				return;
			}
		}
		goto IL_15a5;
		IL_193d:
		if (~(lensPlaced ? 1u : 0u) == 0)
		{
			object obj109 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			object obj110 = obj109 * 0;
			bool flag50 = (nint)obj110 < 0;
			object obj111 = !flag50;
			bool flag51 = obj110 == null;
			object obj112 = ~obj111;
			object obj113 = obj112 | flag51;
			if (obj113 == null)
			{
				object obj114 = this + 360;
				object obj115 = 0f - unscaledDeltaTime;
				object obj116 = obj115 / obj110;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
				num108 = (float)obj114;
				num106 = 1f - (float)obj116;
				Quaternion quaternion5 = Quaternion.Internal_Slerp(ref a, ref b, num106);
				num107 = 1.0;
				rotation = (Quaternion)0;
				goto IL_153c;
			}
		}
		goto IL_1b9a;
	}

	public float LensFov()
	{
		//IL_0022: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0280: Expected F4, but got I
		//IL_006a: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I4
		//IL_00db: Expected F4, but got I
		//IL_02df: Expected F4, but got I
		//IL_011f: Expected I, but got Obj
		//IL_014e: Expected I, but got Obj
		//IL_017d: Expected I, but got Obj
		//IL_018f: Expected I, but got Obj
		//IL_01a1: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_02fa: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I4
		int[] array = fov;
		if (fov == null)
		{
			goto IL_0280;
		}
		bool flag = (int)mode < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = fov + mode;
			if (~(portrait ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj3 = 0;
				UnityEngine.Object obj4 = seen;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = seen != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF68]");
				float aspectRatio = 0f;
				if (flag3)
				{
					if ((object)seen == null)
					{
						goto IL_0280;
					}
					nint num = (nint)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ X8_v13 (Il2CppClass<UnityEngine.Object>)+188] (should have been resolved before IL gen)");
					object obj7 = default;
					if ((nint)obj7 >= 1)
					{
						nint num2 = (nint)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X8_v14 (Il2CppClass<UnityEngine.Object>)+1A8] (should have been resolved before IL gen)");
						object obj8 = default;
						if ((nint)obj8 >= 1)
						{
							nint num3 = (nint)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ X8_v15 (Il2CppClass<UnityEngine.Object>)+188] (should have been resolved before IL gen)");
							nint num4 = (nint)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X8_v16 (Il2CppClass<UnityEngine.Object>)+1A8] (should have been resolved before IL gen)");
							nint num5 = (nint)obj4;
							object obj10 = default;
							object obj11 = default;
							object obj9 = obj10 - obj11;
							bool flag4 = (nint)obj9 < 0;
							bool flag5 = obj9 == null;
							object obj12 = obj10 ^ obj11;
							object obj13 = obj10 ^ obj9;
							object obj14 = obj12 & obj13;
							bool flag6 = (nint)obj14 < 0;
							bool flag7 = flag4 == flag6;
							object obj15 = !flag5;
							object obj16 = flag7 & obj15;
							object obj17 = ~obj16;
							object obj18 = ((obj17 != null) ? obj11 : obj10);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ X8_v17 (Il2CppClass<UnityEngine.Object>)+188] (should have been resolved before IL gen)");
							nint num6 = (nint)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ X8_v18 (Il2CppClass<UnityEngine.Object>)+1A8] (should have been resolved before IL gen)");
							object obj20 = default;
							object obj21 = default;
							object obj19 = obj20 - obj21;
							bool flag8 = (nint)obj19 < 0;
							object obj22 = obj20 ^ obj21;
							object obj23 = obj20 ^ obj19;
							object obj24 = obj22 & obj23;
							bool flag9 = (nint)obj24 < 0;
							bool flag10 = flag8 == flag9;
							object obj25 = !flag10;
							object obj26 = ~obj25;
							object obj27 = ((obj26 != null) ? obj21 : obj20);
							aspectRatio = (float)obj18 / (float)obj27;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+20]");
				return Camera.VerticalToHorizontalFieldOfView(0f, aspectRatio);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+20]");
			return 0f;
		}
		goto IL_028e;
		IL_028e:
		throw new IndexOutOfRangeException();
		IL_0280:
		NullReferenceException ex = new NullReferenceException();
		goto IL_028e;
	}

	private static int Solid()
	{
		//IL_0010: Expected Obj, but got I
		//IL_04d9: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_04af: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I8
		//IL_0166: Expected Obj, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I8
		//IL_0268: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0477: Expected I4, but got I8
		//IL_053f: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I8
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_0381: Expected Obj, but got I4
		//IL_038e: Expected I4, but got I8
		//IL_05c9: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I4
		//IL_0449: Expected I4, but got I8
		//IL_0465: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+68]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+68]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v33+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v34+68]");
				num = 0;
			}
			goto IL_04e7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = default;
		object obj29;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
				object obj10 = 0;
				object obj11 = obj9 + 32;
				obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X20_v7-8]");
				object obj12 = 0 & 0xFFFFFFFEL;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
					object obj13 = 0;
					object obj14 = obj9 + 40;
					obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v9-10]");
					bool flag3 = (nint)0 < (nint)2;
					object obj15 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v9-10]");
					object obj16 = -2;
					bool flag4 = obj16 == null;
					object obj17 = ~obj15;
					object obj18 = obj17 | flag4;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
						object obj19 = 0;
						object obj20 = obj9 + 48;
						obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X20_v11-18]");
						object obj21 = 0 & 0xFFFFFFFCL;
						if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C0]");
							object obj22 = 0;
							object obj23 = obj9 + 56;
							obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X20_v13-20]");
							bool flag5 = (nint)0 < (nint)4;
							object obj24 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X20_v13-20]");
							object obj25 = -4;
							bool flag6 = obj25 == null;
							object obj26 = ~obj24;
							object obj27 = obj26 | flag6;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B0]");
								object obj28 = 0;
								obj29 = obj28;
								object obj30 = obj9 + 64;
								obj30 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X20_v15-28]");
								if ((nint)0 < (nint)1)
								{
									num = -5;
									goto IL_0515;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X20_v15-28]");
								object obj31 = 0 & 0xFFFFFFFFL;
								object obj32 = obj9 + 32;
								object obj33 = 0;
								num = -5;
								while (true)
								{
									bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
									object obj34 = !flag7;
									if (obj34 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X23_v6+v225 @ X22_v7*8]");
									int num2 = LayerMask.NameToLayer((string)0);
									int num3 = 1 << num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7+18]");
									obj31 = 0;
									bool flag8 = num2 < 0;
									int num4 = num2 ^ num2;
									int num5 = num2 & num4;
									bool flag9 = num5 < 0;
									obj33++;
									bool flag10 = flag8 == flag9;
									object obj35 = !flag10;
									object obj36 = ~obj35;
									int num6 = (int)((obj36 != null) ? (~num3) : 4294967295L);
									num = num6 & num;
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31))
									{
										continue;
									}
									goto IL_045c;
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_045c:
		obj29 = 0;
		goto IL_0515;
		IL_0515:
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v24+E4]");
		bool flag11 = (nint)0 == 0;
		object obj38 = !flag11;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj37 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v24+A0]");
		object obj39 = 0;
		goto IL_04e7;
		IL_04e7:
		return num;
	}

	private void Tally(bool recording)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0070: Expected I4, but got I8
		//IL_008a: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_0113: Invalid comparison between F4 and I4
		//IL_0124: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_0326: Expected VT, but got I4
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
		bool flag2 = body == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		int num = (int)(tallySlot & 0x80000000L);
		bool flag4 = num == 0;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			return;
		}
		UnityEngine.Object obj6;
		UnityEngine.Object obj7;
		if (tallyBlock != null)
		{
			bool flag5 = !recording;
			obj6 = null;
			obj7 = null;
			if (!flag5)
			{
				goto IL_00de;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			object obj9 = this + 440;
			tallyBlock = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag6 = !recording;
			object obj10 = !flag6;
			obj6 = (UnityEngine.Object)(object)materialPropertyBlock;
			obj7 = (UnityEngine.Object)(object)materialPropertyBlock;
			if (obj10 != null)
			{
				goto IL_00de;
			}
		}
		object obj11 = 1;
		goto IL_026e;
		IL_00de:
		float unscaledTime = Time.unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0F0");
		float num2 = unscaledTime - 0.75f;
		bool flag7 = num2 < 0f;
		object obj12 = !flag7;
		obj7 = obj6;
		obj11 = obj12;
		goto IL_026e;
		IL_026e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v7+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = obj13;
		bool flag9 = obj11 == null;
		object obj17 = !flag9;
		object obj18 = ~obj17;
		if (obj18 == null)
		{
		}
		object obj19 = !flag9;
		object obj20 = ~obj19;
		if (obj20 == null)
		{
		}
		object obj21 = !flag9;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v13+A0]");
		object obj23 = 0;
		MaterialPropertyBlock materialPropertyBlock2 = tallyBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v14+40]");
		materialPropertyBlock2.SetColor(0, (Color)0);
		body.SetPropertyBlock(tallyBlock, tallySlot);
	}

	private string Seconds(TimeSpan t)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = default;
		double totalMinutes = timeSpan.TotalMinutes;
		int num = default;
		string text = num.ToString();
		int seconds = timeSpan.Seconds;
		string text2 = num.ToString((string)obj3);
		return text + (string)obj4 + text2;
	}

	private unsafe void Redraw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1c0f: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_1c2d: Expected Obj, but got I
		//IL_1c3d: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_031d: Expected VT, but got Obj
		//IL_014a: Expected Obj, but got I4
		//IL_1d0c: Expected Obj, but got I
		//IL_1d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d21: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got I4
		//IL_1c74: Expected Obj, but got I
		//IL_1c84: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I
		//IL_01d0: Expected F4, but got I4
		//IL_03a2: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I8
		//IL_0261: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0442: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_035d: Expected VT, but got I4
		//IL_036f: Expected VT, but got I4
		//IL_1d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6a: Expected Obj, but got Unknown
		//IL_1d9e: Expected Obj, but got I4
		//IL_1db4: Expected Obj, but got I
		//IL_1dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd9: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_048b: Expected Obj, but got I
		//IL_0496: Expected Obj, but got I4
		//IL_04c2: Expected Obj, but got I
		//IL_1df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df5: Expected Obj, but got Unknown
		//IL_1e2e: Expected Obj, but got I8
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_0513: Expected Obj, but got I4
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected I4, but got Unknown
		//IL_0567: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got I4
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05ec: Expected Obj, but got I4
		//IL_0602: Expected Obj, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_0645: Expected Obj, but got I
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected I4, but got Unknown
		//IL_06ca: Expected Obj, but got I4
		//IL_06da: Expected Obj, but got I4
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_0750: Expected Obj, but got I8
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected I4, but got Unknown
		//IL_079c: Expected Obj, but got I8
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07ef: Expected Ref, but got F4
		//IL_081a: Expected Obj, but got I4
		//IL_0830: Expected Obj, but got I
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected Obj, but got Unknown
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected Obj, but got Unknown
		//IL_0893: Expected Obj, but got I
		//IL_08a3: Expected Obj, but got I
		//IL_08c5: Expected Obj, but got I4
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected I4, but got Unknown
		//IL_0916: Expected Obj, but got I4
		//IL_0926: Expected Obj, but got I4
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected Obj, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected I4, but got Unknown
		//IL_09b8: Expected Obj, but got I4
		//IL_09ce: Expected Obj, but got I
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected Obj, but got Unknown
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected Obj, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected I4, but got Unknown
		//IL_0a60: Expected Obj, but got I4
		//IL_0a76: Expected Obj, but got I
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected Obj, but got Unknown
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected I4, but got Unknown
		//IL_0b08: Expected Obj, but got I4
		//IL_0b1e: Expected Obj, but got I
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Expected Obj, but got Unknown
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected Obj, but got Unknown
		//IL_0ba2: Expected Obj, but got I4
		//IL_0bb8: Expected Obj, but got I
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected Obj, but got Unknown
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Expected Obj, but got Unknown
		//IL_0c2d: Expected Obj, but got I4
		//IL_0c43: Expected Obj, but got I
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected Obj, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0cc2: Expected Obj, but got I8
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected Obj, but got Unknown
		//IL_0d21: Expected Obj, but got I4
		//IL_0d37: Expected Obj, but got I
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Expected Obj, but got Unknown
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Expected Obj, but got Unknown
		//IL_0da4: Expected Obj, but got I4
		//IL_1e7a: Expected Obj, but got I4
		//IL_1e90: Expected Obj, but got I
		//IL_1eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb5: Expected Obj, but got Unknown
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected Obj, but got Unknown
		//IL_0e02: Expected Obj, but got I4
		//IL_0e18: Expected Obj, but got I
		//IL_0e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3d: Expected Obj, but got Unknown
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_1edf: Expected Obj, but got I4
		//IL_1eef: Expected Obj, but got I4
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f14: Expected Obj, but got Unknown
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebc: Expected Obj, but got Unknown
		//IL_0ef0: Expected Obj, but got I4
		//IL_0f06: Expected Obj, but got I
		//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2b: Expected Obj, but got Unknown
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected Obj, but got Unknown
		//IL_0f7b: Expected Obj, but got I4
		//IL_0f91: Expected Obj, but got I
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected Obj, but got Unknown
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected Obj, but got Unknown
		//IL_1018: Expected Obj, but got I4
		//IL_102e: Expected Obj, but got I
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected Obj, but got Unknown
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected Obj, but got Unknown
		//IL_10ab: Expected Obj, but got I4
		//IL_10e4: Expected Obj, but got I4
		//IL_10f4: Expected Obj, but got I4
		//IL_1114: Unknown result type (might be due to invalid IL or missing references)
		//IL_1119: Expected Obj, but got Unknown
		//IL_113f: Expected Obj, but got I
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_114d: Expected Obj, but got Unknown
		//IL_115d: Expected Obj, but got I
		//IL_11a4: Expected Obj, but got I4
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Expected Obj, but got Unknown
		//IL_1283: Expected Obj, but got I4
		//IL_12c8: Expected Obj, but got I4
		//IL_11dc: Expected Obj, but got I4
		//IL_13f2: Expected Obj, but got I4
		//IL_1223: Expected Obj, but got I4
		//IL_122c: Expected Obj, but got I4
		//IL_151b: Expected Obj, but got I4
		//IL_12eb: Expected Obj, but got I
		//IL_1638: Expected Obj, but got I
		//IL_1662: Expected Obj, but got I4
		//IL_142a: Expected Obj, but got I4
		//IL_1553: Expected Obj, but got I4
		//IL_1474: Expected Obj, but got I4
		//IL_1348: Expected Obj, but got I
		//IL_135b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1360: Expected Obj, but got Unknown
		//IL_159d: Expected Obj, but got I4
		//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14de: Expected Obj, but got Unknown
		//IL_1389: Expected Obj, but got I
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Expected Obj, but got Unknown
		//IL_13c9: Expected Obj, but got I4
		//IL_16cd: Invalid comparison between F4 and I4
		//IL_1602: Unknown result type (might be due to invalid IL or missing references)
		//IL_1607: Expected Obj, but got Unknown
		//IL_14a1: Expected Obj, but got I
		//IL_176e: Expected Obj, but got I4
		//IL_15ca: Expected Obj, but got I
		//IL_14ce: Expected Obj, but got I4
		//IL_17b5: Expected Obj, but got I4
		//IL_15f7: Expected Obj, but got I4
		//IL_17d7: Expected I4, but got I8
		//IL_17f1: Expected Obj, but got I4
		//IL_1825: Expected Obj, but got I4
		//IL_1f4c: Expected Obj, but got I4
		//IL_18bd: Expected Obj, but got I
		//IL_1902: Expected Obj, but got I4
		//IL_1848: Expected Obj, but got I
		//IL_1947: Expected Obj, but got I4
		//IL_1866: Unknown result type (might be due to invalid IL or missing references)
		//IL_186b: Expected Obj, but got Unknown
		//IL_1a31: Expected Obj, but got I4
		//IL_1a75: Expected Obj, but got I
		//IL_1a80: Expected Obj, but got I4
		//IL_198d: Expected Obj, but got I4
		//IL_1ab2: Expected F4, but got I4
		//IL_19cc: Expected Obj, but got I
		//IL_1a02: Expected Obj, but got I4
		//IL_1fa9: Expected Obj, but got I4
		//IL_1fc7: Expected Obj, but got I
		//IL_1fd7: Expected Obj, but got I
		//IL_2001: Expected Obj, but got I4
		//IL_1aeb: Expected Obj, but got VT
		//IL_1b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0e: Expected Obj, but got Unknown
		//IL_1b88: Expected Obj, but got I4
		//IL_2028: Expected Obj, but got I4
		//IL_2030: Unknown result type (might be due to invalid IL or missing references)
		//IL_2035: Expected Obj, but got Unknown
		//IL_205c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2061: Expected Obj, but got Unknown
		//IL_2069: Unknown result type (might be due to invalid IL or missing references)
		//IL_206e: Expected Obj, but got Unknown
		//IL_2094: Unknown result type (might be due to invalid IL or missing references)
		//IL_2099: Expected Obj, but got Unknown
		//IL_20a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a6: Expected Obj, but got Unknown
		//IL_20db: Expected Obj, but got I4
		//IL_20e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e8: Expected Obj, but got Unknown
		//IL_2118: Expected Obj, but got I4
		//IL_214b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tex != null)
		{
			bool flag2 = (byte)(~(dirty ? 1u : 0u)) != 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				float unscaledTime = Time.unscaledTime;
				if (unscaledTime < nextDraw)
				{
					return;
				}
			}
		}
		float unscaledTime2 = Time.unscaledTime;
		dirty = false;
		float num = unscaledTime2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float num2 = num + 0f;
		nextDraw = num2;
		UnityEngine.Object obj8;
		bool flag5;
		object obj7;
		if (~(awake ? 1u : 0u) == 0)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v223+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = seen != null;
			obj7 = 0;
			obj8 = null;
			flag5 = flag4;
		}
		else
		{
			obj7 = 0;
			obj8 = null;
			flag5 = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj10 = 0;
		float unscaledTime3 = Time.unscaledTime;
		bool flag6 = (byte)(~(recNow ? 1u : 0u)) != 0;
		string text = null;
		float num3;
		if (!flag6)
		{
			text = (string)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v11 (System.String)+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				text = (string)obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v11 (System.String)+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v124+48]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v124+48]");
			num3 = (((nint)0 != 0) ? unscaledTime3 : 0f);
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v11 (System.String)+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj15 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v131+A0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v132+48]");
					obj13 = 0;
				}
				object obj17 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C68]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v127+12E]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v127+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02ed;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v127+98]");
				object obj20 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X10_v20-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj19--;
					obj20 += 16;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_02ed;
				}
				object obj21 = obj20 + 27;
				object obj22 = obj17 + obj21;
				object obj23 = obj22 + 312;
				goto IL_1ced;
			}
		}
		string text2 = (string)obj10;
		num3 = unscaledTime3;
		TimeSpan timeSpan = (TimeSpan)obj8;
		goto IL_1cfc;
		IL_1ced:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v767 @ X0_v213] (should have been resolved before IL gen)");
		GillaLivCamera gillaLivCamera = default;
		timeSpan = (TimeSpan)gillaLivCamera.screenSlot;
		text = gillaLivCamera.Seconds((TimeSpan)gillaLivCamera.screenSlot);
		text2 = text;
		goto IL_1cfc;
		IL_1cfc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0F0");
		object obj25 = this + 264;
		if (!(num3 < pressedUntil))
		{
			obj25 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj26;
		if (!awake)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB20]");
			obj26 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D90]");
			obj26 = 0;
		}
		string[] array = default;
		if (array.Length != 0)
		{
			object obj27 = array + 32;
			obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X24_v7-8]");
			object obj28 = 0 & 0xFFFFFFFEL;
			if (obj28 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D78]");
				object obj29 = 0;
				if (docked)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A20]");
					obj29 = 0;
				}
				object obj30 = array + 40;
				obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X24_v9-10]");
				bool flag9 = (nint)0 < (nint)2;
				object obj31 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X24_v9-10]");
				object obj32 = -2;
				bool flag10 = obj32 == null;
				object obj33 = ~obj31;
				object obj34 = obj33 | flag10;
				if (obj34 == null)
				{
					bool flag11 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5D0]");
					object obj35 = 0;
					object obj36 = !flag11;
					object obj37 = ~obj36;
					if (obj37 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D88]");
						obj35 = 0;
					}
					object obj38 = array + 48;
					obj38 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int num4 = default;
					string text3 = num4.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X24_v11-18]");
					object obj39 = 0 & 0xFFFFFFFCL;
					if (obj39 != null)
					{
						object obj40 = array + 56;
						obj40 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						int[] array2 = fov;
						bool flag12 = (int)mode < array2.Length;
						object obj41 = !flag12;
						if (obj41 == null)
						{
							object obj42 = array2 + mode;
							int num5 = obj42 + 32;
							string text4 = ((int*)num5)->ToString();
							bool flag13 = array.Length < 4;
							object obj43 = !flag13;
							object obj44 = array.Length - 4;
							bool flag14 = obj44 == null;
							object obj45 = ~obj43;
							object obj46 = obj45 | flag14;
							if (obj46 == null)
							{
								object obj47 = array + 64;
								obj47 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X24_v13-28]");
								bool flag15 = (nint)0 < (nint)5;
								object obj48 = !flag15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X24_v13-28]");
								object obj49 = -5;
								bool flag16 = obj49 == null;
								object obj50 = ~obj48;
								object obj51 = obj50 | flag16;
								if (obj51 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
									object obj52 = 0;
									object obj53 = array + 72;
									obj53 = obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int[] array3 = smooth;
									if (array3.Length != 0)
									{
										int num6 = array3 + 32;
										string text5 = ((int*)num6)->ToString();
										bool flag17 = array.Length < 6;
										object obj54 = !flag17;
										object obj55 = array.Length - 6;
										bool flag18 = obj55 == null;
										object obj56 = ~obj54;
										object obj57 = obj56 | flag18;
										if (obj57 == null)
										{
											object obj58 = array + 80;
											obj58 = text5;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											int[] array4 = smooth;
											object obj59 = array4.Length & 0xFFFFFFFEL;
											if (obj59 != null)
											{
												int num7 = array4 + 36;
												string text6 = ((int*)num7)->ToString();
												object obj60 = array.Length & 0xFFFFFFF8L;
												if (obj60 != null)
												{
													object obj61 = array + 88;
													obj61 = text6;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													float num8 = (float)this + 304f;
													string text7 = ((float*)num8)->ToString();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X24_v15-40]");
													bool flag19 = (nint)0 < (nint)8;
													object obj62 = !flag19;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X24_v15-40]");
													object obj63 = -8;
													bool flag20 = obj63 == null;
													object obj64 = ~obj62;
													object obj65 = obj64 | flag20;
													if (obj65 == null)
													{
														object obj66 = array + 96;
														obj66 = text7;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
														object obj67 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ X8_v36+30]");
														object obj68 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X0_v49+E4]");
														bool flag21 = (nint)0 == 0;
														object obj69 = !flag21;
														if (obj69 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														bool flag22 = (byte)(this + 308) != 0;
														string text8 = (flag22 ? ((bool*)1) : ((bool*)null))->ToString();
														bool flag23 = array.Length < 9;
														object obj70 = !flag23;
														object obj71 = array.Length - 9;
														bool flag24 = obj71 == null;
														object obj72 = ~obj70;
														object obj73 = obj72 | flag24;
														if (obj73 == null)
														{
															object obj74 = array + 104;
															obj74 = text8;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															bool flag25 = (byte)(this + 309) != 0;
															string text9 = (flag25 ? ((bool*)1) : ((bool*)null))->ToString();
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X24_v17-50]");
															bool flag26 = (nint)0 < (nint)10;
															object obj75 = !flag26;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X24_v17-50]");
															object obj76 = -10;
															bool flag27 = obj76 == null;
															object obj77 = ~obj75;
															object obj78 = obj77 | flag27;
															if (obj78 == null)
															{
																object obj79 = array + 112;
																obj79 = text9;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																bool flag28 = (byte)(this + 310) != 0;
																string text10 = (flag28 ? ((bool*)1) : ((bool*)null))->ToString();
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X24_v19-58]");
																bool flag29 = (nint)0 < (nint)11;
																object obj80 = !flag29;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X24_v19-58]");
																object obj81 = -11;
																bool flag30 = obj81 == null;
																object obj82 = ~obj80;
																object obj83 = obj82 | flag30;
																if (obj83 == null)
																{
																	object obj84 = array + 120;
																	obj84 = text10;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	bool flag31 = (byte)(this + 311) != 0;
																	string text11 = (flag31 ? ((bool*)1) : ((bool*)null))->ToString();
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X24_v21-60]");
																	bool flag32 = (nint)0 < (nint)12;
																	object obj85 = !flag32;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X24_v21-60]");
																	object obj86 = -12;
																	bool flag33 = obj86 == null;
																	object obj87 = ~obj85;
																	object obj88 = obj87 | flag33;
																	if (obj88 == null)
																	{
																		object obj89 = array + 128;
																		obj89 = text11;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		string qualityName = QualityName;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X24_v23-68]");
																		bool flag34 = (nint)0 < (nint)13;
																		object obj90 = !flag34;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X24_v23-68]");
																		object obj91 = -13;
																		bool flag35 = obj91 == null;
																		object obj92 = ~obj90;
																		object obj93 = obj92 | flag35;
																		if (obj93 == null)
																		{
																			object obj94 = array + 136;
																			obj94 = qualityName;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X24_v25-70]");
																			bool flag36 = (nint)0 < (nint)14;
																			object obj95 = !flag36;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X24_v25-70]");
																			object obj96 = -14;
																			bool flag37 = obj96 == null;
																			object obj97 = ~obj95;
																			object obj98 = obj97 | flag37;
																			if (obj98 == null)
																			{
																				object obj99 = array + 144;
																				obj99 = obj52;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				bool flag38 = default;
																				string text12 = flag38.ToString();
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X24_v27-78]");
																				object obj100 = 0 & 0xFFFFFFF0L;
																				if (obj100 != null)
																				{
																					object obj101 = array + 152;
																					obj101 = text12;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X24_v29-80]");
																					bool flag39 = (nint)0 < (nint)16;
																					object obj102 = !flag39;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X24_v29-80]");
																					object obj103 = -16;
																					bool flag40 = obj103 == null;
																					object obj104 = ~obj102;
																					object obj105 = obj104 | flag40;
																					if (obj105 == null)
																					{
																						object obj106 = array + 160;
																						obj106 = text2;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						bool flag41 = !flag38;
																						object obj107 = !flag41;
																						object obj108 = ~obj107;
																						if (obj108 == null)
																						{
																						}
																						bool flag42 = default;
																						string text13 = flag42.ToString();
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v31-88]");
																						bool flag43 = (nint)0 < (nint)17;
																						object obj109 = !flag43;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v31-88]");
																						object obj110 = -17;
																						bool flag44 = obj110 == null;
																						object obj111 = ~obj109;
																						object obj112 = obj111 | flag44;
																						if (obj112 == null)
																						{
																							object obj113 = array + 168;
																							obj113 = text13;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X24_v33-90]");
																							bool flag45 = (nint)0 < (nint)18;
																							object obj114 = !flag45;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X24_v33-90]");
																							object obj115 = -18;
																							bool flag46 = obj115 == null;
																							object obj116 = ~obj114;
																							object obj117 = obj116 | flag46;
																							if (obj117 == null)
																							{
																								object obj118 = array + 176;
																								obj118 = obj52;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								float unscaledTime4 = Time.unscaledTime;
																								bool flag47 = !(unscaledTime4 < noticeUntil);
																								string text14 = null;
																								if (!flag47)
																								{
																									text14 = notice;
																								}
																								bool flag48 = array.Length < 19;
																								object obj119 = !flag48;
																								object obj120 = array.Length - 19;
																								bool flag49 = obj120 == null;
																								object obj121 = ~obj119;
																								object obj122 = obj121 | flag49;
																								if (obj122 == null)
																								{
																									object obj123 = array + 184;
																									obj123 = text14;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X24_v35-A0]");
																									bool flag50 = (nint)0 < (nint)20;
																									object obj124 = !flag50;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X24_v35-A0]");
																									object obj125 = -20;
																									bool flag51 = obj125 == null;
																									object obj126 = ~obj124;
																									object obj127 = obj126 | flag51;
																									if (obj127 == null)
																									{
																										object obj128 = array + 192;
																										obj128 = obj52;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X24_v37-A8]");
																										bool flag52 = (nint)0 < (nint)21;
																										object obj129 = !flag52;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X24_v37-A8]");
																										object obj130 = -21;
																										bool flag53 = obj130 == null;
																										object obj131 = ~obj129;
																										object obj132 = obj131 | flag53;
																										if (obj132 == null)
																										{
																											object obj133 = array + 200;
																											obj133 = obj25;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											bool flash = default;
																											string text15 = flash.ToString();
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X24_v39-B0]");
																											bool flag54 = (nint)0 < (nint)22;
																											object obj134 = !flag54;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X24_v39-B0]");
																											object obj135 = -22;
																											bool flag55 = obj135 == null;
																											object obj136 = ~obj134;
																											object obj137 = obj136 | flag55;
																											if (obj137 == null)
																											{
																												object obj138 = array + 208;
																												obj138 = text15;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												object obj139 = obj9;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X0_v98+E4]");
																												bool flag56 = (nint)0 == 0;
																												object obj140 = !flag56;
																												if (obj140 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																												}
																												bool flag57 = array.Length < 23;
																												object obj141 = !flag57;
																												object obj142 = array.Length - 23;
																												bool flag58 = obj142 == null;
																												object obj143 = ~obj141;
																												object obj144 = obj143 | flag58;
																												if (obj144 == null)
																												{
																													object obj145 = obj9;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X8_v56+A0]");
																													object obj146 = 0;
																													object obj147 = array + 216;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X8_v57+50]");
																													obj147 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																													string text16 = string.Concat(array);
																													bool flag59 = text16 == shown;
																													bool flag60 = !flag59;
																													object obj148 = 0;
																													if (!flag60)
																													{
																														object obj149 = obj;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X0_v200+E4]");
																														bool flag61 = (nint)0 == 0;
																														object obj150 = !flag61;
																														if (obj150 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														}
																														bool flag62 = tex != null;
																														bool flag63 = !flag62;
																														object obj151 = !flag63;
																														obj148 = 0;
																														if (obj151 != null)
																														{
																															return;
																														}
																													}
																													object obj152 = this + 408;
																													shown = text16;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																													object obj153 = obj;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X0_v109+E4]");
																													bool flag64 = (nint)0 == 0;
																													object obj154 = !flag64;
																													if (obj154 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													bool flag65 = tex == null;
																													bool flag66 = !flag65;
																													object obj155 = 0;
																													UnityEngine.Object obj156 = null;
																													if (!flag66)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
																														object obj157 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																														Texture2D texture2D = default;
																														texture2D._002Ector(320, 200, (TextureFormat)4, mipChain: true);
																														texture2D.filterMode = (FilterMode)0;
																														texture2D.wrapMode = (TextureWrapMode)1;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D80]");
																														object obj158 = 0;
																														texture2D.name = (string)obj158;
																														object obj159 = this + 392;
																														tex = texture2D;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
																														object obj160 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																														UnityEngine.Object obj161 = default;
																														px = (Color32[])(object)obj161;
																														object obj162 = this + 400;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														string text17 = null;
																														bool flag67 = true;
																														obj155 = 0;
																														obj156 = obj161;
																													}
																													bool flag68 = title == null;
																													object obj163 = !flag68;
																													if (obj163 == null)
																													{
																														object obj164 = obj;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X0_v176+E4]");
																														bool flag69 = (nint)0 == 0;
																														object obj165 = !flag69;
																														if (obj165 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														}
																														bool flag70 = titleFont != null;
																														bool flag71 = !flag70;
																														UnityEngine.Object obj166 = null;
																														obj155 = 0;
																														if (!flag71)
																														{
																															string baked = titleFont.text;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																															object obj167 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																															ScreenFont screenFont = default;
																															screenFont._002Ector(baked);
																															obj166 = (UnityEngine.Object)(object)screenFont;
																															obj155 = 0;
																														}
																														object obj168 = this + 416;
																														title = (ScreenFont)(object)obj166;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														obj156 = obj166;
																													}
																													bool flag72 = this.text == null;
																													object obj169 = !flag72;
																													if (obj169 == null)
																													{
																														object obj170 = obj;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v164+E4]");
																														bool flag73 = (nint)0 == 0;
																														object obj171 = !flag73;
																														if (obj171 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														}
																														bool flag74 = textFont != null;
																														bool flag75 = !flag74;
																														UnityEngine.Object obj172 = null;
																														obj155 = 0;
																														if (!flag75)
																														{
																															string baked2 = textFont.text;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																															object obj173 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																															ScreenFont screenFont2 = default;
																															screenFont2._002Ector(baked2);
																															obj172 = (UnityEngine.Object)(object)screenFont2;
																															obj155 = 0;
																														}
																														object obj174 = this + 424;
																														this.text = (ScreenFont)(object)obj172;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														obj156 = obj172;
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
																													object obj175 = 0;
																													object obj176 = obj175;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X0_v116+E4]");
																													bool flag76 = (nint)0 == 0;
																													object obj177 = !flag76;
																													if (obj177 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													GillaBoardLook.Clear(px, 320, 200);
																													if (~(awake ? 1u : 0u) == 0)
																													{
																														float num9 = num3;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
																														float num10 = num9 - 0f;
																														bool flag77 = num10 < 0f;
																														DrawCamera(flag5, flag38, text2, flag77, (string)obj25, flash);
																														string text17 = (string)obj25;
																														bool flag67 = flag77;
																														string text18 = text2;
																													}
																													else
																													{
																														DrawStandby();
																														string text18 = null;
																													}
																													tex.SetPixels32(px);
																													tex.Apply(updateMipmaps: true);
																													object obj178 = obj;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v122+E4]");
																													bool flag78 = (nint)0 == 0;
																													object obj179 = !flag78;
																													if (obj179 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													bool flag79 = body == null;
																													bool flag80 = !flag79;
																													object obj180 = !flag80;
																													if (obj180 != null)
																													{
																														return;
																													}
																													int num11 = (int)(screenSlot & 0x80000000L);
																													bool flag81 = num11 == 0;
																													object obj181 = !flag81;
																													if (obj181 != null)
																													{
																														return;
																													}
																													MaterialPropertyBlock materialPropertyBlock = screenBlock;
																													bool flag82 = screenBlock == null;
																													object obj182 = !flag82;
																													UnityEngine.Object obj183 = null;
																													if (obj182 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
																														object obj184 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																														MaterialPropertyBlock materialPropertyBlock2 = default;
																														materialPropertyBlock2._002Ector();
																														object obj185 = this + 432;
																														screenBlock = materialPropertyBlock2;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														materialPropertyBlock = screenBlock;
																														obj183 = (UnityEngine.Object)(object)materialPropertyBlock2;
																													}
																													object obj186 = obj9;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X0_v127+E4]");
																													bool flag83 = (nint)0 == 0;
																													object obj187 = !flag83;
																													if (obj187 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													object obj188 = obj9;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ X8_v73+A0]");
																													object obj189 = 0;
																													MaterialPropertyBlock materialPropertyBlock3 = materialPropertyBlock;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1462 @ X8_v74+30]");
																													materialPropertyBlock3.SetTexture(0, tex);
																													object obj190 = obj;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ X0_v130+E4]");
																													bool flag84 = (nint)0 == 0;
																													object obj191 = !flag84;
																													if (obj191 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													bool flag85 = seen != null;
																													bool flag86 = !flag85;
																													object obj192 = 0;
																													Texture texture = null;
																													int num12 = 0;
																													if (!flag86)
																													{
																														object obj193 = obj9;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1475 @ X0_v150+E4]");
																														bool flag87 = (nint)0 == 0;
																														object obj194 = !flag87;
																														if (obj194 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														}
																														object obj195 = obj9;
																														texture = seen;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1492 @ X8_v92+A0]");
																														object obj196 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X8_v93+34]");
																														num12 = 0;
																														MaterialPropertyBlock materialPropertyBlock4 = screenBlock;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X8_v93+34]");
																														materialPropertyBlock4.SetTexture(0, seen);
																														obj192 = 0;
																													}
																													object obj197 = obj9;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X0_v135+E4]");
																													bool flag88 = (nint)0 == 0;
																													object obj198 = !flag88;
																													if (obj198 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													object obj199 = obj9;
																													bool flag89 = !flag5;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X8_v78+A0]");
																													object obj200 = 0;
																													object obj201 = !flag89;
																													object obj202 = ~obj201;
																													float value = ((obj202 != null) ? 0f : 1f);
																													MaterialPropertyBlock materialPropertyBlock5 = screenBlock;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v79+38]");
																													materialPropertyBlock5.SetFloat(0, value);
																													RectInt picture = Picture;
																													object obj203 = obj9;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ X0_v141+E4]");
																													bool flag90 = (nint)0 == 0;
																													object obj204 = !flag90;
																													if (obj204 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														obj203 = obj9;
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
																													object obj205 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ X0_v141+A0]");
																													object obj206 = 0;
																													object obj207 = obj205;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v83+E4]");
																													bool flag91 = (nint)0 == 0;
																													object obj208 = !flag91;
																													if (obj208 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													object obj209 = picture >> 32;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v79+38]");
																													int num13 = (int)((nint)0 >> 32);
																													object obj210 = num13 + obj209;
																													object obj211 = obj209 - obj210;
																													bool flag92 = (nint)obj211 < 0;
																													bool flag93 = obj211 == null;
																													object obj212 = obj209 ^ obj210;
																													object obj213 = obj209 ^ obj211;
																													object obj214 = obj212 & obj213;
																													bool flag94 = (nint)obj214 < 0;
																													bool flag95 = flag92 == flag94;
																													object obj215 = !flag95;
																													object obj216 = ~obj215;
																													if (obj216 == null)
																													{
																													}
																													bool flag96 = flag92 == flag94;
																													object obj217 = !flag93;
																													object obj218 = flag96 & obj217;
																													object obj219 = ~obj218;
																													if (obj219 == null)
																													{
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v79+38]");
																													object obj220 = 0 + picture;
																													object obj221 = picture - obj220;
																													bool flag97 = (nint)obj221 < 0;
																													bool flag98 = obj221 == null;
																													object obj222 = picture ^ obj220;
																													object obj223 = picture ^ obj221;
																													object obj224 = obj222 & obj223;
																													bool flag99 = (nint)obj224 < 0;
																													bool flag100 = flag97 == flag99;
																													object obj225 = !flag98;
																													object obj226 = flag100 & obj225;
																													object obj227 = ~obj226;
																													if (obj227 == null)
																													{
																													}
																													bool flag101 = flag97 == flag99;
																													object obj228 = !flag101;
																													object obj229 = ~obj228;
																													if (obj229 == null)
																													{
																													}
																													MaterialPropertyBlock materialPropertyBlock6 = screenBlock;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X9_v12+3C]");
																													materialPropertyBlock6.SetVector(0, (Vector4)0);
																													body.SetPropertyBlock(screenBlock, screenSlot);
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
		IL_02ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj7 = 27;
		goto IL_1ced;
	}

	private unsafe void DrawStandby()
	{
		//IL_0010: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_029c: Expected Obj, but got Ref
		//IL_02c9: Expected VT, but got Ref
		//IL_00c2: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_0377: Expected Obj, but got Ref
		//IL_03a4: Expected VT, but got Ref
		//IL_03be: Expected Obj, but got Ref
		//IL_03ce: Expected Obj, but got I
		//IL_0101: Expected VT, but got Ref
		//IL_011b: Expected Obj, but got Ref
		//IL_012b: Expected Obj, but got I
		//IL_015d: Expected VT, but got Ref
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got Ref
		//IL_0350: Expected VT, but got Ref
		//IL_0200: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F68]");
		object line = 0;
		GillaBoardLook.Frame(px, 320, 200, 3);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v6+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FE8]");
		object line2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FD0]");
		object line3 = 0;
		object obj9 = default;
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = default;
		int num = Line(title, 160, 52, (string)line, (ShiftAuth.Style)(&obj10), centred: true);
		object obj11 = obj3;
		object line4;
		if (!docked)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FD8]");
			line4 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FE0]");
			line4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v12+A0]");
		object obj13 = 0;
		object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = default;
		int num2 = Line(text, 160, 98, (string)line4, (ShiftAuth.Style)(&obj15), centred: true);
		object obj16 = obj3;
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v13+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = default;
		int num3 = Line(text, 160, 114, (string)line2, (ShiftAuth.Style)(&obj19), centred: true);
		object obj20 = obj3;
		object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v15+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj23 = default;
		int num4 = Line(text, 160, 125, (string)line3, (ShiftAuth.Style)(&obj23), centred: true);
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v25+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v19+50]");
		string line5 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v19+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v25+E4]");
			bool flag4 = (nint)0 == 0;
			object obj26 = !flag4;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v20+A0]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v19+50]");
				line5 = (string)0;
			}
			object obj28 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj29 = default;
			int num5 = Line(text, 160, 150, line5, (ShiftAuth.Style)(&obj29), centred: true);
		}
	}

	private unsafe void DrawCamera(bool live, bool recording, string time, bool blink, string pressed, bool flash)
	{
		//IL_0010: Expected Obj, but got I
		//IL_2b1f: Expected Obj, but got I
		//IL_2b3f: Expected I4, but got VT
		//IL_2b61: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected VT, but got Unknown
		//IL_009e: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_2b7c: Expected Obj, but got VT
		//IL_2ba7: Expected Obj, but got VT
		//IL_2baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb4: Expected Obj, but got Unknown
		//IL_2be9: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I
		//IL_2c19: Expected Obj, but got I4
		//IL_2c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c26: Expected Obj, but got Unknown
		//IL_2c57: Expected Obj, but got I4
		//IL_2c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c8f: Expected I4, but got Unknown
		//IL_2cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb9: Expected Obj, but got Unknown
		//IL_2cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc7: Expected Obj, but got Unknown
		//IL_2ce0: Expected Obj, but got I4
		//IL_2d10: Expected Obj, but got I4
		//IL_2d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1d: Expected Obj, but got Unknown
		//IL_2e2f: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02ff: Expected Obj, but got I4
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_08d3: Expected Obj, but got I4
		//IL_0908: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_0967: Expected Obj, but got I
		//IL_0989: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I4
		//IL_2e4d: Expected Obj, but got I
		//IL_2e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5b: Expected I4, but got Unknown
		//IL_2ebf: Expected VT, but got I
		//IL_2ed2: Expected VT, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0453: Expected Obj, but got I4
		//IL_0b3f: Expected Obj, but got I4
		//IL_0b4f: Expected Obj, but got I4
		//IL_0b57: Expected VT, but got I4
		//IL_0b5f: Expected Obj, but got I4
		//IL_0cbe: Expected Obj, but got I4
		//IL_09d8: Expected Obj, but got I4
		//IL_2dff: Expected Obj, but got I4
		//IL_2ffe: Expected Obj, but got I
		//IL_300c: Expected Obj, but got Ref
		//IL_3026: Expected Obj, but got I
		//IL_3051: Expected VT, but got Ref
		//IL_3065: Expected Obj, but got I
		//IL_0b97: Expected Obj, but got I4
		//IL_0a1f: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_0bde: Expected Obj, but got I4
		//IL_2f08: Expected Obj, but got I
		//IL_2f18: Expected Obj, but got I
		//IL_2f42: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_0581: Expected Obj, but got I4
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_0c13: Expected Obj, but got I
		//IL_0c23: Expected Obj, but got I
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected I4, but got Unknown
		//IL_0a93: Expected VT, but got I
		//IL_0aab: Expected Obj, but got I
		//IL_0abb: Expected VT, but got I
		//IL_0aed: Expected VT, but got I
		//IL_0aed: Expected I4, but got VT
		//IL_0b20: Expected I4, but got VT
		//IL_0d18: Expected Obj, but got I
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected Obj, but got Unknown
		//IL_0d52: Expected Obj, but got I8
		//IL_0c68: Expected Obj, but got I
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected Obj, but got Unknown
		//IL_2fe0: Expected Obj, but got I4
		//IL_05bc: Expected VT, but got Obj
		//IL_0d7f: Expected Obj, but got I
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected Obj, but got Unknown
		//IL_0dc1: Expected Obj, but got I4
		//IL_0dd7: Expected Obj, but got I
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Expected Obj, but got Unknown
		//IL_38c0: Expected Obj, but got Ref
		//IL_38eb: Expected VT, but got Ref
		//IL_38eb: Expected I4, but got F8
		//IL_38eb: Expected I4, but got F8
		//IL_3908: Expected VT, but got Ref
		//IL_3910: Expected I4, but got F8
		//IL_3922: Expected I4, but got F8
		//IL_07f8: Expected Obj, but got I4
		//IL_0c8f: Expected Obj, but got I
		//IL_0822: Expected Obj, but got I8
		//IL_0603: Expected Obj, but got I4
		//IL_0e1a: Expected Obj, but got I
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected Obj, but got Unknown
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected Obj, but got Unknown
		//IL_0e58: Expected Obj, but got F4
		//IL_0e68: Expected Obj, but got I
		//IL_0e79: Expected VT, but got Ref
		//IL_0e94: Expected Obj, but got I4
		//IL_0e9d: Expected Obj, but got I4
		//IL_0855: Expected Obj, but got I4
		//IL_311f: Expected Obj, but got I4
		//IL_2daa: Expected Obj, but got I4
		//IL_3084: Expected Obj, but got I
		//IL_3094: Expected Obj, but got I
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_063c: Invalid comparison between VT and Obj
		//IL_0eda: Expected Obj, but got I4
		//IL_067a: Expected Obj, but got I4
		//IL_0f8f: Expected Obj, but got I4
		//IL_30b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ba: Expected Obj, but got Unknown
		//IL_0f38: Expected Obj, but got I4
		//IL_06dd: Expected Obj, but got I4
		//IL_3949: Expected Obj, but got I4
		//IL_0fbf: Expected Obj, but got I
		//IL_30a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a7: Expected Obj, but got Unknown
		//IL_0702: Invalid comparison between VT and Obj
		//IL_3e02: Expected Obj, but got I
		//IL_3e12: Expected Obj, but got I
		//IL_0f68: Expected Obj, but got I
		//IL_0ffc: Expected Obj, but got I4
		//IL_0743: Expected Obj, but got I4
		//IL_102c: Expected Obj, but got I
		//IL_1052: Expected I4, but got Obj
		//IL_1052: Expected VT, but got I
		//IL_1052: Expected VT, but got I
		//IL_1081: Expected Obj, but got I4
		//IL_07a9: Expected Obj, but got I4
		//IL_10bf: Expected Obj, but got I4
		//IL_2dc8: Expected Obj, but got I
		//IL_2dd8: Expected Obj, but got I
		//IL_115f: Expected Obj, but got I4
		//IL_30f0: Expected Obj, but got I
		//IL_1118: Expected Obj, but got I4
		//IL_396d: Expected Obj, but got I
		//IL_397b: Expected Obj, but got Ref
		//IL_39ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b0: Expected I4, but got Unknown
		//IL_39d9: Expected VT, but got Ref
		//IL_39d9: Expected Obj, but got I
		//IL_39e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_39eb: Expected Obj, but got Unknown
		//IL_39f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f9: Expected Obj, but got Unknown
		//IL_3a13: Expected Obj, but got F4
		//IL_3a1b: Expected Obj, but got F4
		//IL_3a3c: Expected Obj, but got I
		//IL_3a44: Expected VT, but got Ref
		//IL_30d5: Expected Obj, but got I
		//IL_11ae: Expected Obj, but got I4
		//IL_313d: Expected Obj, but got I
		//IL_314d: Expected Obj, but got I
		//IL_315b: Expected Obj, but got Ref
		//IL_3188: Expected VT, but got Ref
		//IL_11f0: Expected Obj, but got I4
		//IL_1208: Unknown result type (might be due to invalid IL or missing references)
		//IL_120d: Expected Obj, but got Unknown
		//IL_1216: Unknown result type (might be due to invalid IL or missing references)
		//IL_121b: Expected I4, but got Unknown
		//IL_1258: Expected Obj, but got I
		//IL_128f: Expected Obj, but got I
		//IL_31bd: Expected Obj, but got I4
		//IL_3a74: Expected Obj, but got I
		//IL_3a82: Expected Obj, but got Ref
		//IL_3aaf: Expected VT, but got Ref
		//IL_1373: Expected Obj, but got I4
		//IL_12bb: Expected Obj, but got I
		//IL_12e5: Expected Obj, but got I4
		//IL_1328: Expected Obj, but got I
		//IL_1339: Expected Ref, but got F4
		//IL_138b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1390: Expected Obj, but got Unknown
		//IL_1399: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Expected I4, but got Unknown
		//IL_13ed: Expected Obj, but got I4
		//IL_31db: Expected Obj, but got I
		//IL_31eb: Expected Obj, but got I
		//IL_1434: Expected Obj, but got I4
		//IL_144a: Expected Obj, but got I
		//IL_146a: Unknown result type (might be due to invalid IL or missing references)
		//IL_146f: Expected Obj, but got Unknown
		//IL_150f: Expected Obj, but got I4
		//IL_320c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3211: Expected Obj, but got Unknown
		//IL_14b8: Expected Obj, but got I4
		//IL_3ae5: Expected Obj, but got I
		//IL_3afb: Expected Obj, but got I
		//IL_3b2e: Expected I4, but got Obj
		//IL_3b2e: Expected VT, but got I
		//IL_3b2e: Expected VT, but got I
		//IL_3b58: Expected Obj, but got I4
		//IL_153f: Expected Obj, but got I
		//IL_31f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fe: Expected Obj, but got Unknown
		//IL_1563: Expected Obj, but got I
		//IL_14e8: Expected Obj, but got I
		//IL_15ad: Expected Obj, but got I
		//IL_1619: Expected Obj, but got I
		//IL_169b: Expected Obj, but got I4
		//IL_15c2: Expected Obj, but got I
		//IL_15e4: Expected Obj, but got I4
		//IL_327f: Expected Obj, but got I
		//IL_1654: Expected Obj, but got I4
		//IL_3249: Expected Obj, but got I
		//IL_3b74: Expected Obj, but got Ref
		//IL_3b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b8c: Expected I4, but got Unknown
		//IL_3bad: Expected VT, but got Ref
		//IL_3264: Expected Obj, but got I
		//IL_176f: Expected Obj, but got I
		//IL_1787: Expected Obj, but got I
		//IL_1797: Expected Obj, but got I
		//IL_17a7: Expected Obj, but got I
		//IL_17b7: Expected Obj, but got I
		//IL_17d9: Expected Obj, but got I4
		//IL_32bd: Expected Obj, but got I
		//IL_16d0: Expected Obj, but got I
		//IL_16e8: Expected Obj, but got I
		//IL_16f8: Expected Obj, but got I
		//IL_1708: Expected Obj, but got I
		//IL_1718: Expected Obj, but got I
		//IL_173a: Expected Obj, but got I4
		//IL_329a: Expected Obj, but got I
		//IL_1869: Expected Obj, but got I
		//IL_1879: Expected Obj, but got I
		//IL_2a81: Expected Obj, but got I
		//IL_3889: Expected Obj, but got I4
		//IL_183a: Expected Obj, but got I
		//IL_184a: Expected Obj, but got I
		//IL_3d88: Expected Obj, but got I
		//IL_2ad5: Expected Obj, but got I4
		//IL_3dd3: Expected Obj, but got F4
		//IL_38ad: Expected Obj, but got I
		//IL_18ce: Expected Obj, but got F4
		//IL_197e: Expected Obj, but got I
		//IL_1a0b: Expected Obj, but got I4
		//IL_190b: Expected Obj, but got Ref
		//IL_191b: Expected Obj, but got I
		//IL_33c6: Expected Obj, but got I
		//IL_19c4: Expected Obj, but got I4
		//IL_3c51: Expected Obj, but got I4
		//IL_33ab: Expected Obj, but got I
		//IL_3355: Expected Obj, but got I
		//IL_33db: Expected Obj, but got I
		//IL_33eb: Expected Obj, but got I
		//IL_340e: Expected Obj, but got I
		//IL_3426: Expected Obj, but got I
		//IL_3436: Expected Obj, but got I
		//IL_1a69: Expected Obj, but got I4
		//IL_1a7f: Expected Obj, but got I
		//IL_1a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa4: Expected Obj, but got Unknown
		//IL_1b48: Expected Obj, but got I4
		//IL_3457: Unknown result type (might be due to invalid IL or missing references)
		//IL_345c: Expected Obj, but got Unknown
		//IL_1af1: Expected Obj, but got I4
		//IL_3c92: Expected I4, but got Obj
		//IL_3c92: Expected VT, but got I
		//IL_3c92: Expected VT, but got I
		//IL_3cbc: Expected Obj, but got I4
		//IL_1b78: Expected Obj, but got I
		//IL_3444: Unknown result type (might be due to invalid IL or missing references)
		//IL_3449: Expected Obj, but got Unknown
		//IL_1b21: Expected Obj, but got I
		//IL_1c24: Expected Obj, but got I4
		//IL_34cf: Expected Obj, but got I
		//IL_34df: Expected Obj, but got I
		//IL_1bd3: Expected Obj, but got I4
		//IL_1c63: Expected Obj, but got I8
		//IL_1bfd: Expected VT, but got I8
		//IL_3477: Expected Obj, but got I
		//IL_3487: Expected Obj, but got I
		//IL_34b1: Expected Obj, but got I4
		//IL_1c90: Expected VT, but got I
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc8: Expected I4, but got Unknown
		//IL_1d0d: Expected Obj, but got I4
		//IL_1de3: Expected Obj, but got I4
		//IL_1e1f: Expected Obj, but got I
		//IL_1e32: Expected Obj, but got I4
		//IL_1d57: Expected Obj, but got I4
		//IL_1d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d98: Expected I4, but got Unknown
		//IL_1ec4: Expected Obj, but got I4
		//IL_3532: Expected Obj, but got I
		//IL_1e7d: Expected Obj, but got I4
		//IL_3cd8: Expected Obj, but got Ref
		//IL_3d0c: Expected Obj, but got I4
		//IL_3517: Expected Obj, but got I
		//IL_3556: Unknown result type (might be due to invalid IL or missing references)
		//IL_355b: Expected I4, but got Unknown
		//IL_357c: Expected VT, but got Ref
		//IL_2371: Expected VT, but got Ref
		//IL_1f22: Expected Obj, but got I4
		//IL_23bb: Expected Obj, but got I4
		//IL_1f63: Expected Obj, but got I4
		//IL_1f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8d: Expected I4, but got Unknown
		//IL_1fc2: Expected Obj, but got I4
		//IL_2402: Expected Obj, but got I4
		//IL_280d: Expected Obj, but got I4
		//IL_369e: Expected Obj, but got I
		//IL_36ae: Expected Obj, but got I
		//IL_36d8: Expected Obj, but got I4
		//IL_35bf: Expected Obj, but got I4
		//IL_2837: Expected Obj, but got VT
		//IL_2853: Expected Obj, but got VT
		//IL_285b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2860: Expected Obj, but got Unknown
		//IL_2895: Expected Obj, but got I4
		//IL_25aa: Expected Obj, but got I4
		//IL_243f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2444: Expected I4, but got Unknown
		//IL_2485: Expected VT, but got I
		//IL_249d: Expected Obj, but got I
		//IL_24ab: Expected Obj, but got Ref
		//IL_3d2a: Expected Obj, but got I
		//IL_3d3a: Expected Obj, but got I
		//IL_3d64: Expected Obj, but got I4
		//IL_25f1: Expected Obj, but got I4
		//IL_24c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c8: Expected I4, but got Unknown
		//IL_24e6: Expected Obj, but got I
		//IL_24fe: Expected VT, but got I
		//IL_2506: Expected VT, but got Ref
		//IL_2023: Unknown result type (might be due to invalid IL or missing references)
		//IL_2028: Expected I4, but got Unknown
		//IL_2068: Expected VT, but got I
		//IL_2087: Expected VT, but got I
		//IL_37ba: Expected Obj, but got I4
		//IL_37c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c7: Expected Obj, but got Unknown
		//IL_37d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d5: Expected Obj, but got Unknown
		//IL_37e2: Expected Obj, but got VT
		//IL_2626: Expected Obj, but got I
		//IL_2636: Expected Obj, but got I
		//IL_2693: Expected Obj, but got I4
		//IL_22b4: Expected Obj, but got I4
		//IL_3851: Expected Obj, but got I4
		//IL_26b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26be: Expected I4, but got Unknown
		//IL_26f8: Expected VT, but got I
		//IL_26f8: Expected I4, but got Obj
		//IL_271a: Expected Obj, but got I
		//IL_2761: Expected Obj, but got I4
		//IL_22e1: Expected Obj, but got I
		//IL_231c: Expected Obj, but got I4
		//IL_20e2: Expected Obj, but got I4
		//IL_3704: Expected Obj, but got Ref
		//IL_3731: Expected VT, but got Ref
		//IL_3731: Expected I4, but got F8
		//IL_3731: Expected I4, but got F8
		//IL_3745: Expected F4, but got Obj
		//IL_3755: Expected VT, but got I
		//IL_3770: Expected VT, but got Ref
		//IL_3778: Expected I4, but got F8
		//IL_378a: Expected I4, but got F8
		//IL_3792: Expected I4, but got F8
		//IL_3602: Expected Obj, but got I
		//IL_3610: Expected Obj, but got Ref
		//IL_3623: Unknown result type (might be due to invalid IL or missing references)
		//IL_3628: Expected I4, but got Unknown
		//IL_3646: Expected VT, but got Ref
		//IL_2129: Expected Obj, but got I4
		//IL_2791: Expected Obj, but got I4
		//IL_35dd: Expected Obj, but got I
		//IL_35ed: Expected Obj, but got I
		//IL_291b: Expected Obj, but got I4
		//IL_37a7: Expected Obj, but got I
		//IL_2168: Expected Obj, but got I8
		//IL_3819: Expected Obj, but got I4
		//IL_27c1: Expected Obj, but got I
		//IL_2a39: Expected Obj, but got I4
		//IL_2195: Expected Obj, but got I
		//IL_21bf: Expected Obj, but got I4
		//IL_296a: Expected I4, but got Obj
		//IL_298c: Expected Obj, but got I4
		//IL_21e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ea: Expected I4, but got Unknown
		//IL_222b: Expected VT, but got I
		//IL_2234: Unknown result type (might be due to invalid IL or missing references)
		//IL_2239: Expected I4, but got Unknown
		//IL_226a: Expected VT, but got I
		//IL_29ca: Expected Obj, but got I4
		//IL_2a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a55: Expected Obj, but got Unknown
		//IL_29e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e5: Expected Obj, but got Unknown
		//IL_29ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f3: Expected Obj, but got Unknown
		//IL_29fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a01: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj2 = 0;
		RectInt picture = Picture;
		object obj3 = obj;
		int num = picture >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj;
		RectInt rectInt = (RectInt)(live + picture);
		int num2 = (live ? 1 : 0) >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v9+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5+C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5+4]");
		object obj9 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5+4]");
		object obj10 = 0 - obj9;
		bool flag3 = (nint)obj10 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5+4]");
		object obj11 = 0 ^ obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5+4]");
		object obj12 = 0 ^ obj10;
		object obj13 = obj11 & obj12;
		bool flag4 = (nint)obj13 < 0;
		bool flag5 = flag3 == flag4;
		object obj14 = !flag5;
		object obj15 = ~obj14;
		object obj16;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5+4]");
			obj16 = 0;
		}
		else
		{
			obj16 = obj9;
		}
		object obj17 = picture - rectInt;
		bool flag6 = (nint)obj17 < 0;
		bool flag7 = obj17 == null;
		object obj18 = picture ^ rectInt;
		object obj19 = picture ^ obj17;
		object obj20 = obj18 & obj19;
		bool flag8 = (nint)obj20 < 0;
		bool flag9 = flag6 == flag8;
		object obj21 = !flag9;
		object obj22 = ~obj21;
		RectInt rectInt2 = ((obj22 != null) ? rectInt : picture);
		bool flag10 = flag6 == flag8;
		object obj23 = !flag7;
		object obj24 = flag10 & obj23;
		object obj25 = ~obj24;
		RectInt rectInt3 = ((obj25 != null) ? rectInt : picture);
		int num4 = num2 + num;
		object obj26 = num - num4;
		bool flag11 = (nint)obj26 < 0;
		bool flag12 = obj26 == null;
		int num5 = num ^ num4;
		int num6 = num ^ obj26;
		int num7 = num5 & num6;
		bool flag13 = num7 < 0;
		object obj27 = obj16 * 320;
		object obj28 = 63680 - obj27;
		bool flag14 = flag11 == flag13;
		object obj29 = !flag14;
		object obj30 = ~obj29;
		int num8 = ((obj30 != null) ? num4 : num);
		bool flag15 = flag11 == flag13;
		object obj31 = !flag12;
		object obj32 = flag15 & obj31;
		object obj33 = ~obj32;
		if (obj33 == null)
		{
			num4 = num;
		}
		RectInt rectInt4 = picture;
		IntPtr intPtr = default;
		float num22 = default;
		object obj122 = default;
		object obj128 = default;
		object obj132 = default;
		object obj173 = default;
		object obj178 = default;
		object obj185 = default;
		object obj216 = default;
		object obj249 = default;
		object obj279 = default;
		object obj280 = default;
		float num52 = default;
		object obj281 = default;
		object obj330 = default;
		object obj359 = default;
		object obj372 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v9+E4]");
			bool flag16 = (nint)0 == 0;
			object obj34 = !flag16;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj35 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v11+E4]");
			bool flag17 = (nint)0 == 0;
			object obj36 = !flag17;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+A0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+4]");
			object obj40 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+4]");
			object obj41 = 0 - obj40;
			bool flag18 = (nint)obj41 < 0;
			bool flag19 = obj41 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+4]");
			object obj42 = 0 ^ obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+4]");
			object obj43 = 0 ^ obj41;
			object obj44 = obj42 & obj43;
			bool flag20 = (nint)obj44 < 0;
			bool flag21 = flag18 == flag20;
			object obj45 = !flag19;
			object obj46 = flag21 & obj45;
			object obj47 = ~obj46;
			if (obj47 != null)
			{
				obj39 = obj40;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+E4]");
				bool flag22 = (nint)0 == 0;
				object obj48 = !flag22;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj49 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v351+E4]");
				bool flag23 = (nint)0 == 0;
				object obj50 = !flag23;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj51 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v354+A0]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v273+8]");
				object obj53 = 0 + obj52;
				object obj54 = obj52 - obj53;
				bool flag24 = (nint)obj54 < 0;
				object obj55 = obj52 ^ obj53;
				object obj56 = obj52 ^ obj54;
				object obj57 = obj55 & obj56;
				bool flag25 = (nint)obj57 < 0;
				bool flag26 = flag24 == flag25;
				object obj58 = !flag26;
				object obj59 = ~obj58;
				object obj60 = ((obj59 != null) ? obj53 : obj52);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v354+E4]");
					bool flag27 = (nint)0 == 0;
					object obj61 = !flag27;
					if (obj61 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj62 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v356+E4]");
					bool flag28 = (nint)0 == 0;
					object obj63 = !flag28;
					if (obj63 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v9+A0]");
					object obj64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v279+8]");
					object obj65 = 0 + obj64;
					object obj66 = obj64 - obj65;
					bool flag29 = (nint)obj66 < 0;
					bool flag30 = obj66 == null;
					object obj67 = obj64 ^ obj65;
					object obj68 = obj64 ^ obj66;
					object obj69 = obj67 & obj68;
					bool flag31 = (nint)obj69 < 0;
					bool flag32 = flag29 == flag31;
					object obj70 = !flag30;
					object obj71 = flag32 & obj70;
					object obj72 = ~obj71;
					if (obj72 == null)
					{
						obj65 = obj64;
					}
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65))
					{
						break;
					}
					rectInt4 = (RectInt)px;
					object obj86;
					if (live)
					{
						object obj73 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v365+E4]");
						bool flag33 = (nint)0 == 0;
						object obj74 = !flag33;
						if (obj74 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj75 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X0_v368+E4]");
						bool flag34 = (nint)0 == 0;
						object obj76 = !flag34;
						if (obj76 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (rectInt2 <= obj60)
						{
							object obj77 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X0_v370+E4]");
							bool flag35 = (nint)0 == 0;
							object obj78 = !flag35;
							if (obj78 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (num8 <= (nint)obj16)
							{
								object obj79 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ X0_v372+E4]");
								bool flag36 = (nint)0 == 0;
								object obj80 = !flag36;
								if (obj80 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (rectInt3 > obj60)
								{
									object obj81 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X0_v374+E4]");
									bool flag37 = (nint)0 == 0;
									object obj82 = !flag37;
									if (obj82 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if (num4 > (nint)obj16)
									{
										object obj83 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1248 @ X0_v377+E4]");
										bool flag38 = (nint)0 == 0;
										object obj84 = !flag38;
										if (obj84 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj83 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1248 @ X0_v377+A0]");
										object obj85 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1554 @ X8_v299+B4]");
										obj86 = 0;
										goto IL_0827;
									}
								}
							}
						}
					}
					object obj87 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X0_v362+E4]");
					bool flag39 = (nint)0 == 0;
					object obj88 = !flag39;
					if (obj88 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj86 = 4278584838L;
					goto IL_0827;
					IL_0827:
					object obj89 = obj28 + obj60;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X23_v38 (UnityEngine.RectInt)+18]");
					bool flag40 = (nint)obj89 < 0;
					object obj90 = !flag40;
					if (obj90 != null)
					{
						goto end_IL_2e0d;
					}
					object obj91 = rectInt4 + obj89;
					obj60++;
					obj51 = obj;
				}
				obj16++;
				obj28 -= 320;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+E4]");
			bool flag41 = (nint)0 == 0;
			object obj92 = !flag41;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj93 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
			object obj94 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v19+E4]");
			bool flag42 = (nint)0 == 0;
			object obj95 = !flag42;
			if (obj95 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj96 = obj;
			object obj97 = obj94;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v21+A0]");
			object obj98 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v22+E4]");
			bool flag43 = (nint)0 == 0;
			object obj99 = !flag43;
			if (obj99 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj97 = obj94;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v22+A0]");
			object obj100 = 0;
			int num10 = obj98 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v22+4]");
			int num11 = (int)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v22+8]");
			int num12 = (int)((nint)0 + (nint)2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v22+C]");
			int num13 = (int)((nint)0 + (nint)2);
			int x = num10;
			int y = num11;
			int w = num12;
			int h = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+28]");
			Outline(x, y, w, h, (Color32)0);
			bool flag44 = (byte)(~(portrait ? 1u : 0u)) != 0;
			Color32 color = (Color32)(nint)intPtr;
			int num14 = (flash ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+28]");
			int num15 = 0;
			if (!flag44)
			{
				object obj101 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v334+E4]");
				bool flag45 = (nint)0 == 0;
				object obj102 = !flag45;
				if (obj102 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj103 = obj94;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v337+E4]");
				bool flag46 = (nint)0 == 0;
				object obj104 = !flag46;
				if (obj104 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj103 = obj94;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
				object obj105 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v337+A0]");
				object obj106 = 0;
				object obj107 = obj105;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v269+E4]");
				bool flag47 = (nint)0 == 0;
				object obj108 = !flag47;
				if (obj108 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int x2 = picture - 1;
				Color32[] array = px;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X9_v92+28]");
				PixelFont.Fill(array, 320, 200, x2, num, 1, num2, (Color32)0);
				object obj109 = obj94;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v270+A0]");
				object obj110 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v271+28]");
				color = (Color32)0;
				Color32[] array2 = px;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v271+28]");
				PixelFont.Fill(array2, 320, 200, (int)rectInt3, num, 1, num2, (Color32)0);
				num14 = num2;
				num13 = num;
				num15 = 1;
				num11 = 200;
				num10 = 320;
				num12 = (int)rectInt3;
			}
			bool flag48 = !live;
			object obj111 = !flag48;
			bool flag49 = (byte)num14 != 0;
			string text = (string)num13;
			ShiftAuth.Style style = (ShiftAuth.Style)num15;
			ScreenFont screenFont = (ScreenFont)num10;
			if (obj111 == null)
			{
				object obj112 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v321+E4]");
				bool flag50 = (nint)0 == 0;
				object obj113 = !flag50;
				if (obj113 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj114 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v323+E4]");
				bool flag51 = (nint)0 == 0;
				object obj115 = !flag51;
				if (obj115 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj116 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v325+A0]");
				object obj117 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F70]");
				object obj118 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v261+50]");
				string text2;
				if ((nint)0 == 0)
				{
					text2 = (string)obj118;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v261+50]");
					text2 = (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v261+C]");
				double num16 = 0.0 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v261+8]");
				double num17 = 0.0 * 0.5;
				double num18 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v261+4]");
				double num19 = num18 + 0.0;
				double num20 = num17 + (double)obj117;
				double num21 = num19 - 4.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v325+E4]");
				bool flag52 = (nint)0 == 0;
				object obj119 = !flag52;
				if (obj119 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj120 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v263+A0]");
					obj117 = 0;
				}
				object obj121 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int num23 = Line(this.text, (int)num20, (int)num21, text2, (ShiftAuth.Style)(&obj122), centred: true);
				flag49 = true;
				text = text2;
				style = (ShiftAuth.Style)(&obj122);
				num11 = (int)num20;
				screenFont = this.text;
				num12 = (int)num21;
			}
			object obj123 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v27+E4]");
			bool flag53 = (nint)0 == 0;
			object obj124 = !flag53;
			if (obj124 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj123 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v27+A0]");
			object obj125 = 0;
			object obj126 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F68]");
			object obj127 = 0;
			string text3 = (string)obj127;
			int num24 = Line(title, 266, 9, (string)obj127, (ShiftAuth.Style)(&obj128), centred: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj129 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X0_v33+18]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CF0]");
			object obj130 = 0;
			object obj131 = obj132 + 32;
			obj131 = obj130;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X23_v8-8]");
			object obj133 = 0 & 0xFFFFFFFEL;
			if (obj133 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F58]");
			object obj134 = 0;
			object obj135 = obj132 + 40;
			obj135 = obj134;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X23_v10-10]");
			bool flag54 = (nint)0 < (nint)2;
			object obj136 = !flag54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X23_v10-10]");
			object obj137 = -2;
			bool flag55 = obj137 == null;
			object obj138 = ~obj136;
			object obj139 = obj138 | flag55;
			if (obj139 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FB0]");
			object obj140 = 0;
			ScreenFont screenFont2 = (ScreenFont)obj140;
			object obj141 = obj132 + 48;
			obj141 = obj140;
			object obj142 = obj141 - 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj143 = num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v28+78]");
			object obj144 = 0;
			bool flag56 = true;
			ShiftAuth.Style style2 = (ShiftAuth.Style)(&obj128);
			int num25 = 266;
			int num26 = 9;
			object obj145 = 0;
			object obj146 = 0;
			while (true)
			{
				object obj147 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+E4]");
				bool flag57 = (nint)0 == 0;
				object obj148 = !flag57;
				if (obj148 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj147 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+A0]");
				object obj149 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1572 @ X8_v252+20]");
				object obj150 = 0;
				object obj151 = obj145;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X9_v17+18]");
				bool flag58 = (nint)obj151 < 0;
				object obj152 = !flag58;
				if (obj152 != null)
				{
					break;
				}
				object obj153 = obj150 + obj146;
				object obj155;
				if ((nint)obj145 == (nint)mode)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+E4]");
					bool flag59 = (nint)0 == 0;
					object obj154 = !flag59;
					if (obj154 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj147 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+A0]");
						obj149 = 0;
					}
					obj155 = obj149 + 192;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+E4]");
					bool flag60 = (nint)0 == 0;
					object obj156 = !flag60;
					if (obj156 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj147 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+A0]");
						obj149 = 0;
					}
					obj155 = obj149 + 184;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+E4]");
				bool flag61 = (nint)0 == 0;
				object obj157 = !flag61;
				if (obj157 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj147 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v45+A0]");
				object obj158 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ X8_v51+20]");
				object obj159 = 0;
				object obj160 = obj145;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X8_v52+18]");
				bool flag62 = (nint)obj160 < 0;
				object obj161 = !flag62;
				if (obj161 != null)
				{
					break;
				}
				object obj162 = obj159 + obj146;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1584 @ X8_v53+20]");
				bool flag63 = pressed == (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1555 @ X9_v18+28]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1555 @ X9_v18+30]");
				Button((RectInt)num27, (Color32)0, (byte)(int)obj155 != 0);
				object obj163 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X0_v49+E4]");
				bool flag64 = (nint)0 == 0;
				object obj164 = !flag64;
				if (obj164 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj165 = obj145;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X0_v33+18]");
				bool flag65 = (nint)obj165 < 0;
				object obj166 = !flag65;
				if (obj166 != null)
				{
					break;
				}
				object obj167 = obj;
				object obj169;
				if ((nint)obj145 == (nint)mode)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ X0_v302+E4]");
					bool flag66 = (nint)0 == 0;
					object obj168 = !flag66;
					if (obj168 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj167 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ X0_v302+A0]");
					obj169 = (nint)0 + (nint)128;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ X0_v302+E4]");
					bool flag67 = (nint)0 == 0;
					object obj170 = !flag67;
					if (obj170 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj167 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ X0_v302+A0]");
					obj169 = (nint)0 + (nint)160;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1555 @ X9_v18+28]");
				object obj171 = (nint)0 >> 32;
				object obj172 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1555 @ X9_v18+30]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1555 @ X9_v18+28]");
				int num29 = (int)(num28 + 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num26 = obj171 + 8;
				ScreenFont font = this.text;
				int y2 = num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ X8_v46+v1137 @ X26_v6*8]");
				int num30 = Line(font, num29, y2, (string)0, (ShiftAuth.Style)(&obj173), centred: true);
				obj145++;
				obj146 += 24;
				bool flag68 = (nint)obj145 != 3;
				obj173 = num22;
				obj143 = num22;
				obj144 = obj169;
				flag56 = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ X8_v46+v1137 @ X26_v6*8]");
				text3 = (string)0;
				style2 = (ShiftAuth.Style)(&obj173);
				num25 = num29;
				screenFont2 = this.text;
				if (flag68)
				{
					continue;
				}
				object obj174 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X0_v58+E4]");
				bool flag69 = (nint)0 == 0;
				object obj175 = !flag69;
				if (obj175 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj174 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FA8]");
				object line = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X0_v58+A0]");
				object obj176 = 0;
				object obj177 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int num31 = Line(this.text, 266, 32, (string)line, (ShiftAuth.Style)(&obj178), centred: true);
				int[] array3 = fov;
				bool flag70 = (int)mode < array3.Length;
				object obj179 = !flag70;
				if (obj179 != null)
				{
					break;
				}
				object obj180 = array3 + mode;
				int num32 = obj180 + 32;
				string value = ((int*)num32)->ToString();
				Stepper(3, value, pressed);
				object obj181 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F80]");
				object line2 = 0;
				if (mode != (Mode)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF70]");
					line2 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X0_v67+E4]");
				bool flag71 = (nint)0 == 0;
				object obj182 = !flag71;
				if (obj182 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj181 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X0_v67+A0]");
				object obj183 = 0;
				object obj184 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int num33 = Line(this.text, 266, 88, (string)line2, (ShiftAuth.Style)(&obj185), centred: true);
				string value2;
				if (mode == (Mode)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB160]");
					object obj186 = 0;
					object obj187 = obj186;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X0_v291+E4]");
					bool flag72 = (nint)0 == 0;
					object obj188 = !flag72;
					if (obj188 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					float num34 = (float)this + 304f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED80]");
					object obj189 = 0;
					value2 = ((float*)num34)->ToString((string)obj189, (IFormatProvider)invariantCulture);
				}
				else
				{
					int[] array4 = smooth;
					bool flag73 = (int)mode < array4.Length;
					object obj190 = !flag73;
					if (obj190 != null)
					{
						break;
					}
					object obj191 = array4 + mode;
					int num35 = obj191 + 32;
					value2 = ((int*)num35)->ToString();
				}
				Stepper(5, value2, pressed);
				object obj192 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X0_v75+E4]");
				bool flag74 = (nint)0 == 0;
				object obj193 = !flag74;
				if (obj193 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj192 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X0_v75+A0]");
				object obj194 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1755 @ X8_v232+20]");
				object obj195 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v31+18]");
				bool flag75 = (nint)0 < (nint)12;
				object obj196 = !flag75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v31+18]");
				object obj197 = -12;
				bool flag76 = obj197 == null;
				object obj198 = ~obj196;
				object obj199 = obj198 | flag76;
				if (obj199 != null)
				{
					break;
				}
				object obj202;
				if (~(portrait ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X0_v75+E4]");
					bool flag77 = (nint)0 == 0;
					object obj200 = !flag77;
					if (obj200 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj201 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ X8_v238+A0]");
						obj194 = 0;
					}
					obj202 = obj194 + 192;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X0_v75+E4]");
					bool flag78 = (nint)0 == 0;
					object obj203 = !flag78;
					if (obj203 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj204 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1770 @ X8_v234+A0]");
						obj194 = 0;
					}
					obj202 = obj194 + 184;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E68]");
				object obj205 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v31+148]");
				object obj206 = (nint)0 >> 32;
				bool flag79 = pressed == (string)obj205;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v31+148]");
				nint num36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v31+150]");
				Button((RectInt)num36, (Color32)0, (byte)(int)obj202 != 0);
				object obj207 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1776 @ X0_v80+E4]");
				bool flag80 = (nint)0 == 0;
				object obj208 = !flag80;
				if (obj208 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F50]");
				object line3 = 0;
				object obj209 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v31+150]");
				nint num37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v31+148]");
				int x3 = (int)(num37 + 0);
				if (portrait)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F60]");
					line3 = 0;
				}
				object obj210;
				object obj212;
				if (recording)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D00]");
					obj210 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v273+E4]");
					bool flag81 = (nint)0 == 0;
					object obj211 = !flag81;
					if (obj211 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj209 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v273+A0]");
					obj212 = (nint)0 + (nint)160;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D00]");
					obj210 = 0;
					if (~(portrait ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v273+E4]");
						bool flag82 = (nint)0 == 0;
						object obj213 = !flag82;
						if (obj213 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj209 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v273+A0]");
						obj212 = (nint)0 + (nint)144;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v273+E4]");
						bool flag83 = (nint)0 == 0;
						object obj214 = !flag83;
						if (obj214 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj209 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v273+A0]");
						obj212 = (nint)0 + (nint)152;
					}
				}
				object obj215 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int y3 = obj206 + 6;
				int num38 = Line(this.text, x3, y3, (string)line3, (ShiftAuth.Style)(&obj216), centred: true);
				object obj217 = obj;
				string value3;
				object obj219;
				object obj220;
				object obj221;
				object obj222;
				object colours;
				bool flag85;
				if (~(mic ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FB8]");
					object obj218 = 0;
					value3 = (string)obj218;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE8]");
					obj219 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					obj220 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F90]");
					obj221 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E80]");
					obj222 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ X0_v267+E4]");
					bool flag84 = (nint)0 == 0;
					object obj223 = !flag84;
					if (obj223 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj217 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ X0_v267+A0]");
					colours = (nint)0 + (nint)144;
					flag85 = recording;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA190]");
					object obj224 = 0;
					value3 = (string)obj224;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE8]");
					obj219 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					obj220 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F90]");
					obj221 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E80]");
					obj222 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ X0_v267+E4]");
					bool flag86 = (nint)0 == 0;
					object obj225 = !flag86;
					if (obj225 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj217 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ X0_v267+A0]");
					colours = (nint)0 + (nint)160;
					flag85 = recording;
				}
				Foot(7, (string)obj210, value3, (Color32[])colours, pressed);
				string text4;
				object colours2;
				bool flag88;
				object obj229;
				object obj230;
				if (mode != 0)
				{
					if (mode != (Mode)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
						object obj226 = 0;
						text4 = (string)obj226;
						if (mode != (Mode)1)
						{
							goto IL_385f;
						}
						object obj227 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1998 @ X0_v264+E4]");
						bool flag87 = (nint)0 == 0;
						object obj228 = !flag87;
						if (obj228 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj227 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1998 @ X0_v264+A0]");
						colours2 = (nint)0 + (nint)160;
						goto IL_3d8d;
					}
					flag88 = thirdFront;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FA0]");
					obj229 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FC0]");
					obj230 = 0;
				}
				else
				{
					flag88 = selfieBack;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA9F0]");
					obj229 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FA0]");
					obj230 = 0;
				}
				object obj231 = (flag88 ? obj229 : obj230);
				text4 = (string)obj231;
				goto IL_385f;
				IL_385f:
				object obj232 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2003 @ X0_v260+E4]");
				bool flag89 = (nint)0 == 0;
				object obj233 = !flag89;
				if (obj233 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj232 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2003 @ X0_v260+A0]");
				colours2 = (nint)0 + (nint)128;
				goto IL_3d8d;
				IL_251d:
				float unscaledTime = Time.unscaledTime;
				float num39 = noticeUntil;
				bool flag90 = !(unscaledTime < noticeUntil);
				bool flag91 = live;
				int num48;
				int num49;
				string text5;
				ShiftAuth.Style style3;
				ScreenFont screenFont3;
				bool flag98;
				if (!flag90)
				{
					bool flag92 = notice == null;
					flag91 = live;
					if (!flag92)
					{
						object obj234 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2497 @ X0_v150+E4]");
						bool flag93 = (nint)0 == 0;
						object obj235 = !flag93;
						if (obj235 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj236 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2545 @ X0_v152+E4]");
						bool flag94 = (nint)0 == 0;
						object obj237 = !flag94;
						if (obj237 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj238 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2581 @ X8_v139+A0]");
						object obj239 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
						object obj240 = 0;
						object obj241 = obj240;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2583 @ X8_v140+C]");
						double num40 = 0.0 * 0.5;
						double num41 = num40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2583 @ X8_v140+4]");
						double num42 = num41 + 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2591 @ X0_v154+E4]");
						bool flag95 = (nint)0 == 0;
						object obj242 = !flag95;
						if (obj242 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int y4 = (int)(num42 - 9);
						Color32[] array5 = px;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2583 @ X8_v140+8]");
						nint num43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2583 @ X8_v140+C8]");
						PixelFont.Fill(array5, 320, 200, (int)obj239, y4, (int)num43, 18, (Color32)0);
						object obj243 = obj;
						Color32[] array6 = noticeColours;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2690 @ X0_v157+A0]");
						object obj244 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2745 @ X8_v144+8]");
						double num44 = 0.0 * 0.5;
						double num45 = num44 + (double)obj244;
						bool flag96 = noticeColours == null;
						object obj245 = !flag96;
						if (obj245 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2690 @ X0_v157+E4]");
							bool flag97 = (nint)0 == 0;
							object obj246 = !flag97;
							if (obj246 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj247 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2771 @ X8_v145+A0]");
								obj244 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2745 @ X8_v144+80]");
							array6 = (Color32[])0;
						}
						double num46 = num42 - 4.0;
						object obj248 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						int num47 = Line(this.text, (int)num45, (int)num46, notice, (ShiftAuth.Style)(&obj249), centred: true);
						unscaledTime = num22;
						num39 = (float)array6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2583 @ X8_v140+C8]");
						Color32 color2 = (Color32)0;
						flag98 = true;
						text5 = notice;
						style3 = (ShiftAuth.Style)(&obj249);
						num48 = (int)num45;
						screenFont3 = this.text;
						num49 = (int)num46;
						flag91 = (byte)(int)num45 != 0;
					}
				}
				if (!flash)
				{
					return;
				}
				object obj250 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2501 @ X0_v134+E4]");
				bool flag99 = (nint)0 == 0;
				object obj251 = !flag99;
				if (obj251 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RectInt rectInt5;
				object obj252 = rectInt - rectInt5;
				bool flag100 = (nint)obj252 < 0;
				object obj253 = rectInt ^ rectInt5;
				object obj254 = rectInt ^ obj252;
				object obj255 = obj253 & obj254;
				bool flag101 = (nint)obj255 < 0;
				bool flag102 = flag100 == flag101;
				object obj256 = !flag102;
				object obj257 = ~obj256;
				RectInt rectInt6 = ((obj257 != null) ? rectInt5 : rectInt);
				object obj258 = num8 * 320;
				object obj259 = rectInt6 - obj258;
				object obj260 = obj259 + 63680;
				object obj261 = rectInt3 - rectInt2;
				int num50 = num8;
				while (true)
				{
					object obj262 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2724 @ X0_v137+E4]");
					bool flag103 = (nint)0 == 0;
					object obj263 = !flag103;
					if (obj263 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (num50 == num4)
					{
						break;
					}
					object obj264 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2761 @ X0_v139+E4]");
					bool flag104 = (nint)0 == 0;
					object obj265 = !flag104;
					object obj266 = obj260;
					object obj267 = obj261;
					if (obj265 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj266 = obj260;
						obj267 = obj261;
					}
					while (true)
					{
						object obj268 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2781 @ X0_v141+E4]");
						bool flag105 = (nint)0 == 0;
						object obj269 = !flag105;
						if (obj269 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag106 = obj267 == null;
						object obj270 = !flag106;
						if (obj270 != null)
						{
							object obj271 = obj;
							flag91 = (byte)(int)px != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2794 @ X0_v143+E4]");
							bool flag107 = (nint)0 == 0;
							object obj272 = !flag107;
							if (obj272 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj273 = obj266;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2720 @ X27_v11 (System.Boolean)+18]");
							bool flag108 = (nint)obj273 < 0;
							object obj274 = !flag108;
							if (obj274 != null)
							{
								goto end_IL_2e0d;
							}
							object obj275 = flag91 + obj266;
							obj266++;
							obj267--;
							_ = 4294967295L;
							continue;
						}
						break;
					}
					obj260 -= 320;
					int num51 = num50 + 1;
					num50 = num51;
				}
				return;
				IL_3d8d:
				Foot(8, (string)obj222, text4, (Color32[])colours2, pressed);
				List<QualityOption> list = options;
				string value4 = (string)obj221;
				bool flag109 = options == null;
				object obj276 = num22;
				object obj277 = obj212;
				string text6 = text4;
				if (!flag109)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ X0_v93 (System.Collections.Generic.List`1<Liv.Lck.QualityOption>)+18]");
					bool flag110 = (nint)0 < (nint)1;
					obj276 = num22;
					obj277 = obj212;
					text6 = text4;
					if (!flag110)
					{
						QualityOption qualityOption = options.get_Item(qualityAt);
						object obj278 = (object)(&obj279);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2080 @ X8_v204+FF]");
						obj276 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2080 @ X8_v204+FF]");
						if (0 >= (nint)obj280)
						{
							obj276 = obj280;
						}
						string text7 = num52.ToString();
						uint num53 = (uint)((nuint)(&obj281) | (nuint)0xCu);
						string text8 = ((uint*)num53)->ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FC8]");
						object obj282 = 0;
						string text9 = text7 + (string)obj282 + text8;
						obj277 = obj280;
						text6 = null;
						value4 = text9;
					}
				}
				string qualityName = QualityName;
				string text10;
				if (qualityName == (string)obj220)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F78]");
					object obj283 = 0;
					text10 = (string)obj283;
				}
				else
				{
					string qualityName2 = QualityName;
					text10 = qualityName2;
				}
				object obj284 = obj;
				object colours3;
				if (flag85)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ X0_v244+E4]");
					bool flag111 = (nint)0 == 0;
					object obj285 = !flag111;
					if (obj285 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj284 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ X0_v244+A0]");
					colours3 = (nint)0 + (nint)160;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ X0_v244+E4]");
					bool flag112 = (nint)0 == 0;
					object obj286 = !flag112;
					if (obj286 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj284 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ X0_v244+A0]");
					colours3 = (nint)0 + (nint)128;
				}
				Foot(9, text10, value4, (Color32[])colours3, pressed);
				object obj287 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2144 @ X0_v103+E4]");
				bool flag113 = (nint)0 == 0;
				object obj288 = !flag113;
				if (obj288 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj287 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E60]");
				object obj289 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2144 @ X0_v103+A0]");
				object obj290 = 0;
				object value5 = obj220;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2148 @ X8_v93+80]");
				Foot(10, (string)obj289, (string)value5, (Color32[])0, pressed);
				object obj291 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X0_v105+A0]");
				object obj292 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2166 @ X8_v186+20]");
				object obj293 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+18]");
				bool flag114 = (nint)0 < (nint)11;
				object obj294 = !flag114;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+18]");
				object obj295 = -11;
				bool flag115 = obj295 == null;
				object obj296 = ~obj294;
				object obj297 = obj296 | flag115;
				if (obj297 != null)
				{
					break;
				}
				object obj300;
				if (flag85)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X0_v105+E4]");
					bool flag116 = (nint)0 == 0;
					object obj298 = !flag116;
					if (obj298 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj299 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2169 @ X8_v192+A0]");
						obj292 = 0;
					}
					obj300 = obj292 + 196;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X0_v105+E4]");
					bool flag117 = (nint)0 == 0;
					object obj301 = !flag117;
					if (obj301 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj302 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ X8_v188+A0]");
						obj292 = 0;
					}
					obj300 = obj292 + 184;
				}
				bool flag118 = pressed == (string)obj219;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+130]");
				nint num54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+138]");
				Button((RectInt)num54, (Color32)0, (byte)(int)obj300 != 0);
				object obj303 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2179 @ X0_v110+E4]");
				bool flag119 = (nint)0 == 0;
				object obj304 = !flag119;
				if (obj304 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj305 = obj;
				Color32 color3;
				if (flag85)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v232+E4]");
					bool flag120 = (nint)0 == 0;
					object obj306 = !flag120;
					if (obj306 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					color3 = (Color32)4294967295L;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v232+E4]");
					bool flag121 = (nint)0 == 0;
					object obj307 = !flag121;
					if (obj307 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj305 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v232+A0]");
					object obj308 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v184+A8]");
					object obj309 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v185+18]");
					object obj310 = 0 & 0xFFFFFFFEL;
					if (obj310 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v185+24]");
					color3 = (Color32)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+130]");
				object obj311 = (nint)0 >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
				object obj312 = 0;
				object obj313 = obj312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X0_v114+E4]");
				bool flag122 = (nint)0 == 0;
				object obj314 = !flag122;
				if (obj314 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+130]");
				int x4 = (int)((nint)0 + (nint)14);
				int y5 = obj311 + 16;
				PixelFont.Fill(px, 320, 200, x4, y5, 12, 12, color3);
				bool flag123 = !flag85;
				object obj315 = !flag123;
				int num55 = 200;
				int num56 = 320;
				if (obj315 == null)
				{
					object obj316 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2229 @ X0_v227+E4]");
					bool flag124 = (nint)0 == 0;
					object obj317 = !flag124;
					if (obj317 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+130]");
					num56 = (int)((nint)0 + (nint)14);
					num55 = obj311 + 16;
					Round(num56, num55, 12);
					x4 = 12;
				}
				object obj318 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2243 @ X0_v118+E4]");
				bool flag125 = (nint)0 == 0;
				object obj319 = !flag125;
				if (obj319 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag126 = !flag85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F98]");
				object obj320 = 0;
				object obj321 = obj;
				object obj322 = !flag126;
				object obj323 = ~obj322;
				if (obj323 != null)
				{
					obj320 = obj219;
				}
				if (flag85)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2283 @ X0_v220+E4]");
					bool flag127 = (nint)0 == 0;
					object obj324 = !flag127;
					if (obj324 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj321 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2283 @ X0_v220+A0]");
					object obj325 = (nint)0 + (nint)128;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2283 @ X0_v220+E4]");
					bool flag128 = (nint)0 == 0;
					object obj326 = !flag128;
					if (obj326 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj321 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2283 @ X0_v220+A0]");
					object obj325 = (nint)0 + (nint)168;
				}
				object obj327 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj328 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2294 @ X0_v124+E4]");
				bool flag129 = (nint)0 == 0;
				object obj329 = !flag129;
				if (obj329 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v43+130]");
				num48 = (int)((nint)0 + (nint)62);
				num49 = obj311 + 18;
				int num57 = Line(this.text, num48, num49, (string)obj320, (ShiftAuth.Style)(&obj330), centred: true);
				if (flag85)
				{
					object obj331 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2313 @ X0_v182+E4]");
					bool flag130 = (nint)0 == 0;
					object obj332 = !flag130;
					if (obj332 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj333 = obj;
					int num58 = (live ? 1 : 0) - 4;
					object obj334 = num58 - 66;
					bool flag131 = (nint)obj334 < 0;
					int num59 = num58 ^ 0x42;
					int num60 = num58 ^ obj334;
					int num61 = num59 & num60;
					bool flag132 = num61 < 0;
					bool flag133 = flag131 == flag132;
					object obj335 = !flag133;
					object obj336 = ~obj335;
					int num62 = ((obj336 != null) ? 66 : num58);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2477 @ X0_v185+E4]");
					bool flag134 = (nint)0 == 0;
					object obj337 = !flag134;
					if (obj337 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj333 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
					object obj338 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2477 @ X0_v185+A0]");
					object obj339 = 0;
					object obj340 = obj338;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2481 @ X8_v162+E4]");
					bool flag135 = (nint)0 == 0;
					object obj341 = !flag135;
					if (obj341 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num63 = picture + 2;
					int num64 = num + 2;
					Color32[] array7 = px;
					int x5 = num63;
					int y6 = num64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X9_v66+C8]");
					PixelFont.Fill(array7, 320, 200, x5, y6, num62, 13, (Color32)0);
					bool flag136 = !blink;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X9_v66+C8]");
					Color32 color2 = (Color32)0;
					int num65 = 13;
					int num66 = num62;
					int num67 = 200;
					int num68 = 320;
					if (!flag136)
					{
						object obj342 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2600 @ X0_v201+E4]");
						bool flag137 = (nint)0 == 0;
						object obj343 = !flag137;
						if (obj343 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj344 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X0_v204+E4]");
						bool flag138 = (nint)0 == 0;
						object obj345 = !flag138;
						if (obj345 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj344 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X0_v204+A0]");
						object obj346 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2729 @ X8_v175+A8]");
						object obj347 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v176+18]");
						object obj348 = 0 & 0xFFFFFFFEL;
						if (obj348 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
						object obj349 = 0;
						object obj350 = obj349;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2769 @ X0_v205+E4]");
						bool flag139 = (nint)0 == 0;
						object obj351 = !flag139;
						if (obj351 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int x6 = picture + 5;
						num64 = num + 5;
						Color32[] array8 = px;
						int y7 = num64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v176+24]");
						PixelFont.Fill(array8, 320, 200, x6, y7, 7, 7, (Color32)0);
						num68 = picture + 5;
						num67 = num + 5;
						Round(num68, num67, 7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v176+24]");
						color2 = (Color32)0;
						num65 = 7;
						num66 = 7;
						num63 = 7;
					}
					object obj352 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2636 @ X0_v189+E4]");
					bool flag140 = (nint)0 == 0;
					object obj353 = !flag140;
					if (obj353 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F88]");
					object obj354 = 0;
					string text11 = (string)obj354 + time;
					object obj355 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2751 @ X0_v194+E4]");
					bool flag141 = (nint)0 == 0;
					object obj356 = !flag141;
					if (obj356 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj355 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2751 @ X0_v194+A0]");
					object obj357 = 0;
					object obj358 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num48 = picture + 15;
					num49 = num + 5;
					text5 = text11;
					style3 = (ShiftAuth.Style)(&obj359);
					screenFont3 = this.text;
					rectInt5 = picture;
				}
				else
				{
					bool flag142 = !live;
					Color32 color2 = color3;
					flag98 = true;
					text5 = (string)obj320;
					style3 = (ShiftAuth.Style)(&obj330);
					screenFont3 = this.text;
					rectInt5 = picture;
					if (flag142)
					{
						goto IL_251d;
					}
					object obj360 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2330 @ X0_v168+E4]");
					bool flag143 = (nint)0 == 0;
					object obj361 = !flag143;
					if (obj361 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj362 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2427 @ X0_v171+E4]");
					bool flag144 = (nint)0 == 0;
					object obj363 = !flag144;
					if (obj363 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj362 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
					object obj364 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2427 @ X0_v171+A0]");
					object obj365 = 0;
					object obj366 = obj364;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2432 @ X8_v151+E4]");
					bool flag145 = (nint)0 == 0;
					object obj367 = !flag145;
					if (obj367 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int x7 = picture + 2;
					int y8 = num + 2;
					Color32[] array9 = px;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2431 @ X9_v63+C8]");
					PixelFont.Fill(array9, 320, 200, x7, y8, 30, 13, (Color32)0);
					object obj368 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2530 @ X8_v152+A0]");
					object obj369 = 0;
					object obj370 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num22, 4));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num48 = picture + 5;
					num49 = num + 5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8548]");
					object obj371 = 0;
					text5 = (string)obj371;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2431 @ X9_v63+C8]");
					color2 = (Color32)0;
					style3 = (ShiftAuth.Style)(&obj372);
					screenFont3 = this.text;
					rectInt5 = picture;
				}
				int num69 = Line(screenFont3, num48, num49, text5, style3, centred: false);
				flag98 = false;
				goto IL_251d;
			}
			break;
			continue;
			end_IL_2e0d:
			break;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Button(RectInt box, Color32 fill, bool down)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_0032: Expected I4, but got VT
		//IL_0040: Expected I4, but got VT
		//IL_0050: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_012a: Expected VT, but got I4
		//IL_012a: Expected I4, but got VT
		//IL_012a: Expected I4, but got VT
		//IL_0154: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0287: Expected VT, but got I
		//IL_0287: Expected I4, but got VT
		//IL_0287: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int y = box >> 32;
		int num = fill >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj4 = 0;
		nint num2 = default;
		object obj5 = num2 & 1;
		bool flag2 = obj5 == null;
		bool flag3 = down;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v18+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+BC]");
			flag3 = false;
		}
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj12 = 0;
		PixelFont.Fill(px, 320, 200, (int)box, y, (int)fill, num, (Color32)flag3);
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v11+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v8+28]");
		Outline((int)box, y, (int)fill, num, (Color32)0);
	}

	private void Outline(int x, int y, int w, int h, Color32 colour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected VT, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected VT, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected VT, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Color32 colour2 = (Color32)(colour & 0xFFFFFFFFL);
		PixelFont.Fill(px, 320, 200, x, y, w, 1, colour2);
		object obj4 = y + h;
		Color32 colour3 = (Color32)(colour & 0xFFFFFFFFL);
		int y2 = obj4 - 1;
		PixelFont.Fill(px, 320, 200, x, y2, w, 1, colour3);
		Color32 colour4 = (Color32)(colour & 0xFFFFFFFFL);
		PixelFont.Fill(px, 320, 200, x, y, 1, h, colour4);
		object obj5 = x + w;
		Color32 colour5 = (Color32)(colour & 0xFFFFFFFFL);
		int x2 = obj5 - 1;
		PixelFont.Fill(px, 320, 200, x2, y, 1, h, colour5);
	}

	private unsafe void Stepper(int i, string value, string pressed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04f1: Expected Obj, but got I4
		//IL_0678: Expected Obj, but got I
		//IL_0688: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_0134: Expected VT, but got I
		//IL_0144: Expected VT, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0187: Expected VT, but got I
		//IL_0187: Expected VT, but got I
		//IL_01a4: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_0266: Expected VT, but got I
		//IL_0266: Expected VT, but got I
		//IL_0281: Expected Obj, but got Ref
		//IL_0291: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got VT
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected I4, but got Unknown
		//IL_030c: Expected Obj, but got VT
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected I4, but got Unknown
		//IL_0342: Expected VT, but got Ref
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected I4, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected I4, but got Unknown
		//IL_0379: Expected Obj, but got I
		//IL_039a: Expected VT, but got Ref
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected VT, but got Unknown
		//IL_03c8: Expected Obj, but got I
		//IL_03d5: Expected Obj, but got VT
		//IL_0400: Expected Obj, but got VT
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected VT, but got Unknown
		//IL_0457: Expected Obj, but got I4
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_050c: Expected Obj, but got VT
		//IL_0528: Expected Obj, but got VT
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0567: Expected Obj, but got Ref
		//IL_0580: Expected Obj, but got I4
		//IL_05a7: Expected Obj, but got I
		//IL_05be: Expected Obj, but got VT
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected I4, but got Unknown
		//IL_061d: Expected Obj, but got I4
		//IL_0642: Expected I4, but got Obj
		//IL_0663: Expected VT, but got Ref
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+20]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v1+18]");
		bool flag2 = (nint)0 < (nint)i;
		object obj6 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v1+18]");
		object obj7 = -i;
		bool flag3 = obj7 == null;
		object obj8 = ~obj6;
		object obj9 = obj8 | flag3;
		if (obj9 == null)
		{
			object obj10 = i + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v1+18]");
			bool flag4 = (nint)obj10 < 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				object obj12 = obj5 + 32;
				object obj13 = i * 24;
				object obj14 = obj12 + obj13;
				object obj15 = obj10 * 24;
				object obj16 = obj12 + obj15;
				object obj17 = i * 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X12_v4+8]");
				RectInt rectInt = (RectInt)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X13_v3+8]");
				RectInt rectInt2 = (RectInt)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X9_v4+v132 @ X10_v5]");
				bool flag5 = pressed == (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X12_v4+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X12_v4+10]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+B8]");
				Button((RectInt)num, (Color32)num2, down: false);
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v7+A0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8+20]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v5+18]");
				bool flag6 = (nint)obj10 < 0;
				object obj21 = !flag6;
				if (obj21 == null)
				{
					object obj22 = obj10 * 24;
					object obj23 = obj20 + obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
					object line = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v6+20]");
					bool flag7 = pressed == (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X13_v3+8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X13_v3+10]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8+B8]");
					Button((RectInt)num3, (Color32)num4, down: false);
					object obj25 = obj;
					object obj27 = default;
					object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj27, 16));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v9+A0]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj29 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v16+E4]");
					bool flag8 = (nint)0 == 0;
					object obj30 = !flag8;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj31 = rectInt >> 32;
					int y = obj31 + 7;
					object obj32 = rectInt2 >> 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X12_v4+10]");
					int x = 0 + rectInt;
					object obj33 = default;
					int num5 = Line(text, x, y, (string)line, (ShiftAuth.Style)(&obj33), centred: true);
					int y2 = obj32 + 7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X13_v3+10]");
					int x2 = 0 + rectInt2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
					object line2 = 0;
					object obj34 = default;
					int num6 = Line(text, x2, y2, (string)line2, (ShiftAuth.Style)(&obj34), centred: true);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X12_v4+10]");
					RectInt rectInt3 = (RectInt)(0 + rectInt);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
					object obj35 = 0;
					object obj36 = rectInt - rectInt3;
					bool flag9 = (nint)obj36 < 0;
					bool flag10 = obj36 == null;
					object obj37 = rectInt ^ rectInt3;
					object obj38 = rectInt ^ obj36;
					object obj39 = obj37 & obj38;
					bool flag11 = (nint)obj39 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X13_v3+10]");
					RectInt rectInt4 = (RectInt)(0 + rectInt2);
					bool flag12 = flag9 == flag11;
					object obj40 = !flag10;
					object obj41 = flag12 & obj40;
					object obj42 = ~obj41;
					if (obj42 != null)
					{
						rectInt = rectInt3;
					}
					object obj43 = rectInt2 - rectInt4;
					bool flag13 = (nint)obj43 < 0;
					object obj44 = rectInt2 ^ rectInt4;
					object obj45 = rectInt2 ^ obj43;
					object obj46 = obj44 & obj45;
					bool flag14 = (nint)obj46 < 0;
					object obj47 = obj35;
					object obj48 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj27, 16));
					bool flag15 = flag13 == flag14;
					object obj49 = !flag15;
					object obj50 = ~obj49;
					if (obj50 != null)
					{
						rectInt2 = rectInt4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v16+A0]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj52 = rectInt2 + rectInt;
					bool flag16 = (nint)obj52 < 0;
					object obj53 = obj52 ^ obj52;
					object obj54 = obj52 & obj53;
					bool flag17 = (nint)obj54 < 0;
					int y3 = obj31 + 7;
					bool flag18 = flag16 == flag17;
					object obj55 = !flag18;
					object obj56 = ~obj55;
					if (obj56 == null)
					{
						obj52++;
					}
					int x3 = obj52 >> 1;
					object obj57 = default;
					int num7 = Line(text, x3, y3, value, (ShiftAuth.Style)(&obj57), centred: true);
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void Foot(int i, string name, string value, Color32[] colours, string pressed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I4
		//IL_04ae: Expected Obj, but got I
		//IL_04be: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0121: Expected VT, but got I
		//IL_0121: Expected VT, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got Ref
		//IL_0203: Expected I4, but got Obj
		//IL_0224: Expected VT, but got Ref
		//IL_0247: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I4
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I4
		//IL_04f1: Expected Obj, but got Ref
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected I4, but got Unknown
		//IL_052a: Expected VT, but got Ref
		//IL_03a4: Expected Obj, but got I
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+20]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v1+18]");
			bool flag2 = (nint)0 < (nint)i;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v1+18]");
			object obj7 = -i;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = i * 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+20]");
				object obj11 = 0 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v2+28]");
				object obj13 = (nint)0 >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v2+20]");
				bool flag4 = pressed == (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v2+28]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v2+30]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+B8]");
				Button((RectInt)num, (Color32)num2, down: false);
				bool flag5 = string.IsNullOrEmpty(value);
				object obj14 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v5+E4]");
				bool flag6 = (nint)0 == 0;
				object obj15 = !flag6;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj16 = obj12;
				bool flag7 = !flag5;
				object obj17 = !flag7;
				object obj18 = ~obj17;
				object obj19 = ((obj18 != null) ? ((object)11) : ((object)18));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v2+30]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v2+28]");
				int x = (int)(num3 + 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj22 = default;
				object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj22, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int y = (int)(obj19 + obj13);
				object obj23 = default;
				int num4 = Line(text, x, y, name, (ShiftAuth.Style)(&obj23), centred: true);
				bool flag9 = !flag5;
				object obj24 = !flag9;
				if (obj24 != null)
				{
					return;
				}
				object obj25 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v20+E4]");
				bool flag10 = (nint)0 == 0;
				object obj26 = !flag10;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
				object obj27 = 0;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v23+E4]");
				bool flag11 = (nint)0 == 0;
				object obj29 = !flag11;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj27;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v23+A0]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v13+A0]");
				if (0 != (nint)colours)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v23+E4]");
					bool flag12 = (nint)0 == 0;
					object obj31 = !flag12;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj32 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v19+A0]");
						obj30 = 0;
					}
					object obj33 = obj30 + 152;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v23+E4]");
					bool flag13 = (nint)0 == 0;
					object obj34 = !flag13;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj35 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v15+A0]");
						obj30 = 0;
					}
					object obj33 = obj30 + 160;
				}
				object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj22, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int y2 = obj13 + 25;
				object obj37 = default;
				int num5 = Line(text, x, y2, value, (ShiftAuth.Style)(&obj37), centred: true);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private void Round(int x, int y, int size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected I4, but got Unknown
		//IL_0087: Expected Obj, but got I8
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected I4, but got Unknown
		//IL_00ea: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected I4, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected I4, but got Unknown
		//IL_017e: Expected Obj, but got I8
		//IL_01b5: Expected Obj, but got I8
		//IL_01e6: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01fd: Expected Obj, but got I4
		//IL_0578: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I8
		//IL_0236: Expected Obj, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I4
		//IL_0421: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_04fa: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6760]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		(int, int) tuple = (x, y);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj2 = size - 1;
			int item = obj2 + x;
			_ = 0;
			(int, int) tuple2 = (item, y);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+18]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				int item2 = obj2 + y;
				_ = 0;
				(int, int) tuple3 = (x, item2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+18]");
				bool flag = (nint)0 < (nint)2;
				object obj4 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+18]");
				object obj5 = -2;
				bool flag2 = obj5 == null;
				object obj6 = ~obj4;
				object obj7 = obj6 | flag2;
				if (obj7 == null)
				{
					int item3 = obj2 + x;
					int item4 = obj2 + y;
					_ = 0;
					(int, int) tuple4 = (item3, item4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+18]");
					object obj8 = 0 & 0xFFFFFFFCL;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+18]");
						object obj9 = 0 & 0xFFFFFFFFL;
						_ = 0;
						if ((nint)obj9 < 1)
						{
							return;
						}
						object obj10 = x - 1;
						object obj12 = default;
						object obj11 = obj12 + 32;
						object obj13 = 0;
						while (true)
						{
							bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
							object obj14 = !flag3;
							if (obj14 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
							object obj15 = 0 & -9223372036854775808L;
							bool flag4 = obj15 == null;
							object obj16 = !flag4;
							object obj23;
							object obj24;
							Color32[] array;
							object obj25;
							Color32[] array2;
							object obj28;
							object obj30;
							object obj21;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
								bool flag5 = (nint)0 < (nint)319;
								object obj17 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
								object obj18 = -319;
								bool flag6 = obj18 == null;
								object obj19 = !flag6;
								object obj20 = obj17 & obj19;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
									obj21 = (nint)0 >> 32;
									if ((nint)obj21 <= 199)
									{
										object obj22 = 199 - obj21;
										obj23 = obj22 + obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
										obj24 = 0 + obj23;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
										if ((nint)0 == x)
										{
											array = px;
											bool flag7 = x < 1;
											obj25 = obj10;
											if (!flag7)
											{
												bool flag8 = array == null;
												object obj26 = !flag8;
												obj25 = obj10;
												array2 = array;
												if (obj26 != null)
												{
													goto IL_0409;
												}
												goto IL_050e;
											}
										}
										else
										{
											array2 = px;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
											bool flag9 = (nint)0 < (nint)319;
											object obj27 = !flag9;
											array = px;
											if (obj27 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v4+v195 @ X8_v15*8]");
												obj25 = (nint)0 + (nint)1;
												goto IL_0409;
											}
										}
										obj28 = array.Length;
										bool flag10 = (nint)obj24 < array.Length;
										object obj29 = !flag10;
										obj30 = obj24;
										if (obj29 != null)
										{
											break;
										}
										goto IL_04a8;
									}
								}
							}
							goto IL_0535;
							IL_0535:
							obj13++;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
							{
								return;
							}
							continue;
							IL_0409:
							object obj31 = obj23 << 6;
							obj28 = array2.Length;
							obj30 = obj25 + obj31;
							bool flag11 = (nint)obj30 < array2.Length;
							object obj32 = !flag11;
							object obj33 = ~obj32;
							array = array2;
							if (obj33 == null)
							{
								break;
							}
							goto IL_04a8;
							IL_04a8:
							bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28);
							object obj34 = !flag12;
							if (obj34 != null)
							{
								break;
							}
							obj21 = array + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X13_v5+v208 @ X14_v7*4]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+18]");
							obj9 = 0;
							goto IL_0535;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_050e;
		IL_050e:
		throw new NullReferenceException();
	}

	private unsafe int Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style, bool centred = default(bool))
	{
		//IL_0064: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I4
		//IL_02cf: Expected Ref, but got VT
		//IL_004b: Expected Ref, but got VT
		//IL_01d1: Expected Obj, but got I4
		//IL_02f9: Expected I4, but got Obj
		//IL_0251: Expected Obj, but got I4
		//IL_02a1: Expected VT, but got Ref
		int num4;
		if (font == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = style.scale - 1;
			bool flag = (nint)obj3 < 0;
			bool flag2 = obj3 == null;
			int num = style.scale ^ 1;
			int num2 = style.scale ^ obj3;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			int scale = ((obj6 != null) ? 1 : style.scale);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num4 = PixelFont.Measure(line, scale);
			bool flag6 = !centred;
			int x2 = x;
			if (!flag6)
			{
				bool flag7 = num4 < 0;
				int num5 = num4 ^ num4;
				int num6 = num4 & num5;
				bool flag8 = num6 < 0;
				bool flag9 = flag7 == flag8;
				object obj8 = !flag9;
				object obj9 = ~obj8;
				int num7 = ((obj9 != null) ? num4 : (num4 + 1));
				x2 = x - num7;
			}
			Color32[] colours = style.colours;
			if (style.colours != null)
			{
				if (colours.Length != 0)
				{
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v10+E4]");
					bool flag10 = (nint)0 == 0;
					object obj11 = !flag10;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PixelFont.Draw(px, 320, 200, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), scale);
					goto IL_02d8;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
		num4 = ((!centred) ? font.Draw(px, 320, 200, x, y, line, ref *(ShiftAuth.Style*)style) : font.DrawCentred(px, 320, 200, x, y, line, ref *(ShiftAuth.Style*)style));
		goto IL_02d8;
		IL_02d8:
		return num4;
	}

	public GillaLivCamera()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0261: Expected I4, but got I8
		//IL_0285: Expected I4, but got Obj
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0109: Expected Obj, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01bf: Expected I4, but got I8
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0210: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FF0]");
		object obj2 = 0;
		docked = true;
		dirty = true;
		screenSlot = -1;
		startedIn = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = obj2;
		int[] array = default;
		array[0] = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+8]");
		array[2] = 0;
		fov = array;
		object obj4 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int[] array2 = default;
		if (array2.Length != 0)
		{
			bool flag = array2.Length == 1;
			array2[0] = 1;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9F50]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1190]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
				object obj8 = 0;
				object obj9 = this + 296;
				array2[1] = 3;
				smooth = array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj10 = this + 309;
				distance = 2f;
				obj10 = 257;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Queue<System.__Canon> queue = default;
				queue._002Ector();
				object obj11 = this + 448;
				later = (Queue<Action>)(object)queue;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj12 = 17289216 + 384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F00");
				Vector3[,] array3 = default;
				tipTrail = array3;
				object obj13 = this + 456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				float[] array4 = default;
				trailTime = array4;
				object obj14 = this + 464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				trailHead = -1;
				flyT = -1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				List<System.__Canon> list = default;
				list._002Ector();
				object obj15 = this + 512;
				hiddenLooks = (List<Renderer>)(object)list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				dockedIn = -1;
				base._002Ector();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	unsafe static GillaLivCamera()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_10b0: Expected Obj, but got I
		//IL_10c0: Expected Obj, but got I
		//IL_10d8: Expected Obj, but got I
		//IL_1105: Expected VT, but got I8
		//IL_0072: Expected Obj, but got Ref
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00db: Expected VT, but got I8
		//IL_00fa: Expected Obj, but got I8
		//IL_011f: Expected Obj, but got Ref
		//IL_012f: Expected Obj, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0170: Expected VT, but got I8
		//IL_0197: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_022a: Expected VT, but got I8
		//IL_0249: Expected Obj, but got I8
		//IL_0276: Expected Obj, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_02b7: Expected VT, but got I8
		//IL_02de: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0337: Expected Obj, but got I
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_0371: Expected VT, but got I8
		//IL_0398: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03f1: Expected Obj, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_042a: Expected VT, but got I8
		//IL_0451: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_04aa: Expected Obj, but got I
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04e4: Expected VT, but got I8
		//IL_0503: Expected Obj, but got I8
		//IL_0530: Expected Obj, but got I
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_056a: Expected VT, but got I8
		//IL_0591: Expected Obj, but got I4
		//IL_05a7: Expected Obj, but got I
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_05ea: Expected Obj, but got I
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0624: Expected VT, but got I8
		//IL_064b: Expected Obj, but got I4
		//IL_0661: Expected Obj, but got I
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_06a4: Expected Obj, but got I
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected VT, but got Unknown
		//IL_0718: Expected Obj, but got I4
		//IL_072e: Expected Obj, but got I
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_0771: Expected Obj, but got I
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_07ab: Expected VT, but got I8
		//IL_07d2: Expected Obj, but got I4
		//IL_07e8: Expected Obj, but got I
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_0839: Expected Obj, but got I
		//IL_0848: Expected Obj, but got I4
		//IL_0868: Expected VT, but got I8
		//IL_088f: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got I
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_08e8: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_0908: Expected Obj, but got I
		//IL_0918: Expected Obj, but got I
		//IL_0928: Expected Obj, but got I
		//IL_0938: Expected Obj, but got I
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected Obj, but got Unknown
		//IL_0957: Expected Obj, but got I
		//IL_098b: Expected Obj, but got I
		//IL_09c7: Expected Obj, but got I
		//IL_09f6: Expected Obj, but got I
		//IL_0a20: Expected Obj, but got I
		//IL_0a4f: Expected Obj, but got I
		//IL_0a79: Expected Obj, but got I
		//IL_0ab4: Expected Obj, but got I
		//IL_0ae3: Expected Obj, but got I
		//IL_0b7f: Expected Obj, but got I4
		//IL_0b95: Expected Obj, but got I
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected Obj, but got Unknown
		//IL_0bfa: Expected Obj, but got I
		//IL_0c97: Expected Obj, but got I
		//IL_0d07: Expected Obj, but got I8
		//IL_0d42: Expected Obj, but got I
		//IL_0ddf: Expected Obj, but got I
		//IL_0e7c: Expected Obj, but got I
		//IL_0f19: Expected Obj, but got I
		//IL_0fb6: Expected Obj, but got I
		//IL_0fe0: Expected Obj, but got I
		//IL_0ffa: Expected Obj, but got I
		//IL_1010: Expected Obj, but got I
		//IL_102a: Expected Obj, but got I
		//IL_1044: Expected Obj, but got I
		//IL_105e: Expected Obj, but got I
		//IL_1078: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1FF8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CF0]");
		object item = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2000]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D160]");
		obj5 = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D170]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		(System.__Canon, RectInt) tuple = ((System.__Canon)item, (RectInt)17179869188L);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj9 = default;
			object obj8 = (object)(&obj9);
			object obj11 = default;
			object obj10 = obj11 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E98]");
			object item2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v10+FF]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj12 = typeof(_0021_00210) | 0x1600000000L;
			(System.__Canon, RectInt) tuple2 = ((System.__Canon)item2, (RectInt)17179869257L);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
			object obj13 = 0 & 0xFFFFFFFEL;
			if (obj13 != null)
			{
				(System.__Canon, RectInt) tuple3 = default;
				object obj14 = (object)(&tuple3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EB8]");
				object item3 = 0;
				object obj15 = obj11 + 56;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X22_v7+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				(System.__Canon, RectInt) tuple4 = ((System.__Canon)item3, (RectInt)17179869328L);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
				bool flag = (nint)0 < (nint)2;
				object obj16 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
				object obj17 = -2;
				bool flag2 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag2;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E90]");
					object item4 = 0;
					object obj20 = obj11 + 80;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					(System.__Canon, RectInt) tuple5 = ((System.__Canon)item4, (RectInt)180388626648L);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
					object obj21 = 0 & 0xFFFFFFFCL;
					if (obj21 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E88]");
						object item5 = 0;
						object obj22 = obj11 + 104;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X22_v7+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						(System.__Canon, RectInt) tuple6 = ((System.__Canon)item5, (RectInt)180388626718L);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
						bool flag3 = (nint)0 < (nint)4;
						object obj23 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
						object obj24 = -4;
						bool flag4 = obj24 == null;
						object obj25 = ~obj23;
						object obj26 = obj25 | flag4;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E70]");
							object item6 = 0;
							object obj27 = obj11 + 128;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							tuple3 = ((System.__Canon)item6, (RectInt)420906795224L);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
							bool flag5 = (nint)0 < (nint)5;
							object obj28 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
							object obj29 = -5;
							bool flag6 = obj29 == null;
							object obj30 = ~obj28;
							object obj31 = obj30 | flag6;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E78]");
								object item7 = 0;
								object obj32 = obj11 + 152;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								(System.__Canon, RectInt) tuple7 = ((System.__Canon)item7, (RectInt)420906795294L);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
								bool flag7 = (nint)0 < (nint)6;
								object obj33 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
								object obj34 = -6;
								bool flag8 = obj34 == null;
								object obj35 = ~obj33;
								object obj36 = obj35 | flag8;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D00]");
									object item8 = 0;
									object obj37 = obj11 + 176;
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									(System.__Canon, RectInt) tuple8 = ((System.__Canon)item8, (RectInt)652835028996L);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
									object obj38 = 0 & 0xFFFFFFF8L;
									if (obj38 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E80]");
										object item9 = 0;
										object obj39 = obj11 + 200;
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										(System.__Canon, RectInt) tuple9 = ((System.__Canon)item9, (RectInt)652835029050L);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
										bool flag9 = (nint)0 < (nint)8;
										object obj40 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
										object obj41 = -8;
										bool flag10 = obj41 == null;
										object obj42 = ~obj40;
										object obj43 = obj42 | flag10;
										if (obj43 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1EA0]");
											object item10 = 0;
											object obj44 = obj11 + 224;
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											(System.__Canon, RectInt) tuple10 = ((System.__Canon)item10, (RectInt)652835029104L);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
											bool flag11 = (nint)0 < (nint)9;
											object obj45 = !flag11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
											object obj46 = -9;
											bool flag12 = obj46 == null;
											object obj47 = ~obj45;
											object obj48 = obj47 | flag12;
											if (obj48 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E60]");
												object item11 = 0;
												object obj49 = obj11 + 248;
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												RectInt item12 = (RectInt)(typeof(_0021_00210) | 0x9800000000L);
												(System.__Canon, RectInt) tuple11 = ((System.__Canon)item11, item12);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
												bool flag13 = (nint)0 < (nint)10;
												object obj50 = !flag13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
												object obj51 = -10;
												bool flag14 = obj51 == null;
												object obj52 = ~obj50;
												object obj53 = obj52 | flag14;
												if (obj53 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE8]");
													object item13 = 0;
													object obj54 = obj11 + 272;
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													(System.__Canon, RectInt) tuple12 = ((System.__Canon)item13, (RectInt)652835029208L);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
													bool flag15 = (nint)0 < (nint)11;
													object obj55 = !flag15;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
													object obj56 = -11;
													bool flag16 = obj56 == null;
													object obj57 = ~obj55;
													object obj58 = obj57 | flag16;
													if (obj58 == null)
													{
														object obj59 = obj11 + 296;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1E68]");
														object item14 = 0;
														_ = 0;
														obj59 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														(System.__Canon, RectInt) tuple13 = ((System.__Canon)item14, (RectInt)554050781400L);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
														bool flag17 = (nint)0 < (nint)12;
														object obj60 = !flag17;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
														object obj61 = -12;
														bool flag18 = obj61 == null;
														object obj62 = ~obj60;
														object obj63 = obj62 | flag18;
														if (obj63 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
															object obj64 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2008]");
															object obj65 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2018]");
															object obj66 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2010]");
															object obj67 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
															object obj68 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F98]");
															object obj69 = 0;
															object obj70 = obj11 + 320;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
															object obj71 = 0;
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj72 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X8_v36+A0]");
															object obj73 = (nint)0 + (nint)32;
															obj73 = obj11;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															int num = Shader.PropertyToID((string)obj64);
															object obj74 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X8_v37+A0]");
															object obj75 = 0;
															int num2 = Shader.PropertyToID((string)obj65);
															object obj76 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v39+A0]");
															object obj77 = 0;
															int num3 = Shader.PropertyToID((string)obj66);
															object obj78 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v41+A0]");
															object obj79 = 0;
															int num4 = Shader.PropertyToID((string)obj67);
															object obj80 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v43+A0]");
															object obj81 = 0;
															int num5 = Shader.PropertyToID((string)obj68);
															object obj82 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X8_v45+A0]");
															object obj83 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
															List<UnityEngine.XR.InputDevice> list = default;
															list._002Ector();
															object obj84 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X8_v47+A0]");
															object obj85 = (nint)0 + (nint)96;
															obj85 = list;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj86 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X8_v48+A0]");
															object obj87 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B1F8]");
															_ = 0;
															_ = 4294967295L;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v66+18]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v66+18]");
																bool flag19 = (nint)0 == 1;
																_ = 4294967295L;
																if (!flag19)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v66+18]");
																	bool flag20 = (nint)0 < (nint)2;
																	object obj88 = !flag20;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v66+18]");
																	object obj89 = -2;
																	bool flag21 = obj89 == null;
																	_ = 4291348680L;
																	object obj90 = ~obj88;
																	object obj91 = obj90 | flag21;
																	if (obj91 == null)
																	{
																		_ = 4287401100L;
																		object obj92 = obj;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v53+A0]");
																		object obj93 = (nint)0 + (nint)120;
																		object obj94 = default;
																		obj93 = obj94;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v71+18]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v71+18]");
																			bool flag22 = (nint)0 == 1;
																			_ = 4294967295L;
																			if (!flag22)
																			{
																				_ = 4291677645L;
																				object obj95 = obj;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v57+A0]");
																				object obj96 = (nint)0 + (nint)128;
																				object obj97 = default;
																				obj96 = obj97;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v76+18]");
																				if ((nint)0 != 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v76+18]");
																					bool flag23 = (nint)0 == 1;
																					object obj98 = 4284444415L + 675840;
																					if (!flag23)
																					{
																						_ = 4279859440L;
																						object obj99 = obj;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v61+A0]");
																						object obj100 = (nint)0 + (nint)136;
																						object obj101 = default;
																						obj100 = obj101;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v81+18]");
																						if ((nint)0 != 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v81+18]");
																							bool flag24 = (nint)0 == 1;
																							_ = 4285464460L;
																							if (!flag24)
																							{
																								_ = 4280866600L;
																								object obj102 = obj;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v65+A0]");
																								object obj103 = (nint)0 + (nint)144;
																								object obj104 = default;
																								obj103 = obj104;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v86+18]");
																								if ((nint)0 != 0)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v86+18]");
																									bool flag25 = (nint)0 == 1;
																									_ = 4291348680L;
																									if (!flag25)
																									{
																										_ = 4289374890L;
																										object obj105 = obj;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v69+A0]");
																										object obj106 = (nint)0 + (nint)152;
																										object obj107 = default;
																										obj106 = obj107;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v91+18]");
																										if ((nint)0 != 0)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v91+18]");
																											bool flag26 = (nint)0 == 1;
																											_ = 4286348412L;
																											if (!flag26)
																											{
																												_ = 4284374622L;
																												object obj108 = obj;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v73+A0]");
																												object obj109 = (nint)0 + (nint)160;
																												object obj110 = default;
																												obj109 = obj110;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v96+18]");
																												if ((nint)0 != 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v96+18]");
																													bool flag27 = (nint)0 == 1;
																													_ = 4284444415L;
																													if (!flag27)
																													{
																														_ = 4279837665L;
																														object obj111 = obj;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v77+A0]");
																														object obj112 = (nint)0 + (nint)168;
																														object obj113 = default;
																														obj112 = obj113;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														object obj114 = obj;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v78+A0]");
																														object obj115 = 0;
																														_ = 4281348144L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v78+A0]");
																														object obj116 = 0;
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v78+A0]");
																														object obj117 = 0;
																														_ = 4279637526L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v78+A0]");
																														object obj118 = 0;
																														_ = 4282795590L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v78+A0]");
																														object obj119 = 0;
																														_ = 4281874488L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v78+A0]");
																														object obj120 = 0;
																														_ = 4278849174L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v78+A0]");
																														object obj121 = 0;
																														_ = 2852126720L;
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

	private void _003CLowStorage_003Eb__240_0()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2020]");
		object words = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+88]");
		Say((string)words, (Color32[])0, 4f);
	}
}
