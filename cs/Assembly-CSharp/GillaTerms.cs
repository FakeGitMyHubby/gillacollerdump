using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class GillaTerms : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GillaStrands> _003C_003E9__50_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FF0]");
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

		internal bool _003CBetween_003Eb__50_0(GillaStrands s)
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
			return s == null;
		}
	}

	private struct Row
	{
		public int y;

		public int x;

		public string text;

		public bool heading;
	}

	private class Hand
	{
		public bool right;

		public LineRenderer line;

		public bool tracked;

		public bool aimed;

		public bool down;

		public Vector2 at;

		public bool dragging;

		public float grabY;

		public float grabScroll;

		public float grabAt;

		public float moved;

		public float lastY;

		public float velocity;
	}

	public const int Version = default(int);

	public const string Key = null;

	public Renderer board;

	public TextAsset terms;

	public TextAsset titleFont;

	public TextAsset textFont;

	public Transform rig;

	public Material pointerMaterial;

	public static Vector2? TestStick;

	public static bool? TestButton;

	public static readonly Pose?[] TestAim;

	public static readonly bool[] TestPress;

	public const int W = default(int);

	public const int H = default(int);

	public const float PixelSize = default(float);

	private const int Left = default(int);

	private const int Right = default(int);

	private const int BodyTop = default(int);

	private const int BodyBottom = default(int);

	private const int BarX = default(int);

	private const int BarW = default(int);

	private const int Pitch = default(int);

	private const int Gap = default(int);

	private const int HeadGap = default(int);

	private const float InTime = default(float);

	private const float OutTime = default(float);

	private const float Settle = default(float);

	private const float Speed = default(float);

	private const float Fastest = default(float);

	private const float RampTime = default(float);

	private const float RayLength = default(float);

	private const float RayWidth = default(float);

	private const float TapSlop = default(float);

	private const float TapTime = default(float);

	private const float Friction = default(float);

	private const float FlingLeast = default(float);

	private const float StickDeadzone = default(float);

	private const string ReadOn = null;

	private const string PressAny = null;

	private const string AcceptedLine = null;

	private static readonly Color32[] Silver;

	private static readonly Color32[] Words;

	private static readonly Color32[] Orange;

	private static readonly Color32[] Help;

	private static readonly Color32[] Lime;

	private static readonly Color32[] Dim;

	private static readonly Color32 Shadow;

	private static readonly Color32 Frame;

	private static readonly Color32 Track;

	private static readonly Color32 Thumb;

	private static readonly Color32 Black;

	private static readonly Color32 ArrowFill;

	private static readonly Color32 ArrowHeld;

	private static readonly Color32 ArrowEdge;

	private static readonly Color RayColour;

	private static readonly string[] Arrow;

	private static readonly int CellsId;

	private static readonly int LodId;

	private static readonly int LevelsId;

	private static readonly int GainId;

	private static readonly int RevealId;

	private static readonly int GlitchId;

	private static readonly int BandId;

	private static readonly int TintId;

	private static readonly int MainTexId;

	private static readonly int BaseColorId;

	private readonly List<Row> rows;

	private readonly Hand[] hands;

	private float shownAt;

	private float acceptedAt;

	private float endAt;

	private float scroll;

	private float heldFor;

	private int heldWay;

	private float fling;

	private bool tapped;

	private int maxScroll;

	private int bodyH;

	private bool atEnd;

	private bool held;

	private string prompt;

	private string drawn;

	private Texture2D tex;

	private Color32[] px;

	private Color32[] basePx;

	private Color32[] bodyPx;

	private ScreenFont title;

	private ScreenFont text;

	private Material mat;

	private Material madePointer;

	private static readonly List<UnityEngine.XR.InputDevice> devices;

	private static readonly InputFeatureUsage<bool>[] Usages;

	private static readonly string[] Named;

	private static readonly string[] PointerNamed;

	public static bool Accepted
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I4
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected I4, but got Unknown
			//IL_00a3: Expected Obj, but got I4
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9180]");
			object key = 0;
			int num = PlayerPrefs.GetInt((string)key, 0);
			object obj = num - 1;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num2 = num ^ 1;
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			return (byte)((flag4 & obj2) ? 1 : 0) != 0;
		}
	}

	public bool Showing
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_0022: Expected Obj, but got F4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			bool flag = shownAt < 0f;
			object obj = shownAt ^ shownAt;
			object obj2 = shownAt & obj;
			bool flag2 = (nint)obj2 < 0;
			return flag == flag2;
		}
	}

	public bool AtEnd => atEnd;

	public bool AcceptedHere
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_0022: Expected Obj, but got F4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			bool flag = acceptedAt < 0f;
			object obj = acceptedAt ^ acceptedAt;
			object obj2 = acceptedAt & obj;
			bool flag2 = (nint)obj2 < 0;
			return flag == flag2;
		}
	}

	public bool Done
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_0062: Invalid comparison between F4 and I4
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected Obj, but got Unknown
			//IL_008a: Expected Obj, but got F4
			if (acceptedAt < 0f)
			{
				return false;
			}
			float unscaledTime = Time.unscaledTime;
			float num = unscaledTime - acceptedAt;
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num3 = num2 - 0f;
			bool flag = num3 < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj = num ^ 0;
			object obj2 = num ^ num3;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			return flag == flag2;
		}
	}

	public float Scroll => scroll;

	public int MaxScroll => maxScroll;

	public int Lines
	{
		get
		{
			//IL_0020: Expected I4, but got Obj
			List<Row> list = rows;
			if (rows != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public string Prompt => prompt;

	public Texture2D Picture => tex;

	public bool Dragging
	{
		get
		{
			//IL_014b: Expected I4, but got Obj
			Hand[] array = hands;
			if (hands != null)
			{
				if (array.Length == 0)
				{
					goto IL_013d;
				}
				Hand hand = array[0];
				if (array[0] != null)
				{
					if (~(hand.dragging ? 1u : 0u) == 0)
					{
						return true;
					}
					if (array.Length == 1)
					{
						goto IL_013d;
					}
					Hand hand2 = array[1];
					if (array[1] != null)
					{
						bool flag = !hand2.dragging;
						return !flag;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_013d;
			IL_013d:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
	}

	public bool Flicking
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			bool flag = fling == 0f;
			return !flag;
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

	private static Color32 G(byte v)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected VT, but got Unknown
		int num = v & 0xFF;
		object obj = num * 65793;
		return (Color32)(obj | 0xFF000000L);
	}

	public bool Aimed(int hand)
	{
		//IL_00f3: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		Hand[] array = hands;
		if (hands != null)
		{
			bool flag = array.Length < hand;
			object obj = !flag;
			object obj2 = array.Length - hand;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_00e5;
			}
			object obj5 = hands + hand;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+21]");
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00e5;
		IL_00e5:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public Vector2 AimedAt(int hand)
	{
		//IL_00d8: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00bc: Expected VT, but got Obj
		Hand[] array = hands;
		if (hands != null)
		{
			bool flag = array.Length < hand;
			object obj = !flag;
			object obj2 = array.Length - hand;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_00ca;
			}
			object obj5 = hands + hand;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				return (Vector2)this;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ca;
		IL_00ca:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector2)ex2;
	}

	public LineRenderer Ray(int hand)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		Hand[] array = hands;
		if (hands != null)
		{
			bool flag = array.Length < hand;
			object obj = !flag;
			object obj2 = array.Length - hand;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_00e5;
			}
			object obj5 = hands + hand;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+18]");
				return (LineRenderer)0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00e5;
		IL_00e5:
		return (LineRenderer)(object)new IndexOutOfRangeException();
	}

	public void Show(float after = default(float))
	{
		//IL_00fc: Invalid comparison between F4 and I4
		//IL_0017: Invalid comparison between F4 and I4
		//IL_0142: Expected Obj, but got I
		//IL_0037: Expected F4, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		if (shownAt < 0f)
		{
			float unscaledTime = Time.unscaledTime;
			float num = ((!(after < 0f)) ? after : 0f);
			float num2 = num + unscaledTime;
			shownAt = num2;
			Lay();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9190]");
			object format = 0;
			object arg = default;
			object arg2 = default;
			object arg3 = default;
			string message = string.Format((string)format, arg, arg2, arg3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
		}
	}

	private void Update()
	{
		//IL_033a: Invalid comparison between F4 and I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00ad: Invalid comparison between F4 and I4
		//IL_00dd: Invalid comparison between F4 and I4
		//IL_013c: Invalid comparison between F4 and I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got F4
		//IL_023a: Invalid comparison between F4 and I
		//IL_02b8: Invalid comparison between F4 and I4
		//IL_02cf: Expected Obj, but got F4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I4
		//IL_0259: Invalid comparison between F4 and I4
		if (shownAt < 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (board == null)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime - shownAt;
		bool flag2;
		if (num < 0f)
		{
			flag2 = false;
		}
		else if (acceptedAt < 0f)
		{
			flag2 = true;
		}
		else
		{
			float unscaledTime2 = Time.unscaledTime;
			float num2 = unscaledTime2 - acceptedAt;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num4 = num3 - 0f;
			bool flag3 = num4 < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj4 = num2 ^ 0;
			object obj5 = num2 ^ num4;
			object obj6 = obj4 & obj5;
			bool flag4 = (nint)obj6 < 0;
			bool flag5 = flag3 == flag4;
			bool flag6 = !flag5;
			flag2 = flag6;
		}
		GameObject gameObject = board.gameObject;
		bool activeSelf = gameObject.activeSelf;
		if (flag2 != activeSelf)
		{
			GameObject gameObject2 = board.gameObject;
			gameObject2.SetActive(flag2);
		}
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			if (!(num < 0f) && acceptedAt < 0f)
			{
				Steer(unscaledTime);
			}
			else
			{
				Rays(on: false);
			}
			float sinceAccepted = unscaledTime - acceptedAt;
			bool flag7 = acceptedAt < 0f;
			object obj7 = acceptedAt ^ acceptedAt;
			object obj8 = acceptedAt & obj7;
			bool flag8 = (nint)obj8 < 0;
			bool flag9 = flag7 == flag8;
			object obj9 = !flag9;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				sinceAccepted = -1f;
			}
			Look(num, sinceAccepted);
		}
		else
		{
			Rays(on: false);
		}
	}

	private void Steer(float now)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_093a: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0133: Expected F4, but got I
		//IL_0152: Expected F4, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_01d6: Invalid comparison between F4 and I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I4
		//IL_09ee: Expected Obj, but got I
		//IL_0a06: Expected Obj, but got I
		//IL_0a16: Expected F4, but got I
		//IL_00ac: Expected F4, but got I
		//IL_0981: Expected Obj, but got I4
		//IL_09b7: Expected F4, but got I
		//IL_09d0: Expected F4, but got I
		//IL_0d02: Expected Obj, but got I
		//IL_0d25: Expected Obj, but got I4
		//IL_0d2e: Expected F4, but got I4
		//IL_0a3b: Invalid comparison between F8 and I
		//IL_05fe: Invalid comparison between F8 and I
		//IL_08c4: Invalid comparison between F4 and I4
		//IL_08de: Expected F4, but got I4
		//IL_0a62: Expected Obj, but got I
		//IL_0a7a: Expected Obj, but got I
		//IL_0cc5: Invalid comparison between F4 and I4
		//IL_0cd4: Expected F8, but got I4
		//IL_0622: Expected I4, but got I8
		//IL_0b91: Expected F4, but got I4
		//IL_04d0: Expected F4, but got I4
		//IL_0c4b: Invalid comparison between F4 and I4
		//IL_0c5a: Expected F4, but got I4
		//IL_08f5: Expected F4, but got I4
		//IL_0c88: Expected Obj, but got I4
		//IL_0c9a: Expected F4, but got I4
		//IL_0d4c: Expected Obj, but got I
		//IL_0d64: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		//IL_0685: Invalid comparison between F4 and I4
		//IL_07d6: Expected Obj, but got I4
		//IL_04ed: Expected Obj, but got I
		//IL_04f5: Expected I4, but got Obj
		//IL_0506: Expected Obj, but got I
		//IL_0541: Invalid comparison between F8 and I4
		//IL_0550: Invalid comparison between F8 and I4
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_05aa: Expected Obj, but got I4
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_06ae: Expected F4, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_0702: Expected Obj, but got I
		//IL_0741: Expected Obj, but got I4
		//IL_076e: Expected Obj, but got I
		//IL_03e3: Expected F4, but got I
		//IL_03ee: Expected Obj, but got I4
		//IL_088d: Invalid comparison between F4 and I
		//IL_0423: Expected F4, but got I4
		//IL_0af9: Expected Obj, but got I4
		//IL_0415: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj = 0;
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		float num = default;
		Point(now, num);
		bool dragging = Dragging;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+A0]");
		object obj4 = 0;
		bool flag3;
		float num2;
		float num3;
		float num4;
		bool flag4;
		if (obj4 != null)
		{
			bool flag2 = !dragging;
			object obj5 = !flag2;
			IntPtr intPtr = default;
			flag3 = (byte)(nint)intPtr != 0;
			num2 = now;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+8]");
				num3 = 0f;
				flag4 = (byte)(nint)intPtr != 0;
				num4 = now;
				goto IL_0957;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v76+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Vector2 vector = GillaSticks.Read((XRNode)4, 0f, trustPushes: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Vector2 vector2 = GillaSticks.Read((XRNode)5, 0f, trustPushes: false);
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v82+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num5 = 0f - num;
			bool flag7 = num5 < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			object obj11 = 0 ^ num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			object obj12 = 0 ^ num5;
			object obj13 = obj11 & obj12;
			bool flag8 = (nint)obj13 < 0;
			bool flag9 = flag7 == flag8;
			object obj14 = !flag9;
			object obj15 = ~obj14;
			num3 = ((obj15 != null) ? num : num);
			bool flag10 = !dragging;
			flag3 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num2 = 0f;
			flag4 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num4 = 0f;
			if (flag10)
			{
				goto IL_0957;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v64+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v65+4]");
		num3 = 0f;
		flag4 = flag3;
		num4 = num2;
		goto IL_0957;
		IL_0ce2:
		fling = 0f;
		goto IL_0ca8;
		IL_0ca8:
		float num7;
		float num6 = num7 / 3f;
		bool flag11 = num6 < 0f;
		double num8 = 0.0;
		if (!flag11)
		{
			bool flag12 = !((double)num6 > 1.0);
			num8 = num6;
			if (!flag12)
			{
				num8 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num9 = num8 * 7.0;
		double num11;
		double num10 = num11 * 10.0;
		double num12 = num8 * num9;
		double num13 = num10 * 1129447424.0;
		double num14 = num12 + 1.0;
		double num15 = num13 * num14;
		float num16 = num * (float)num15;
		float num17 = scroll + num16;
		float num19;
		float num18 = num19 + num17;
		bool flag13 = num18 < 0f;
		float num20 = 0f;
		if (!flag13)
		{
			bool flag14 = !(num18 > (float)maxScroll);
			num20 = num18;
			if (!flag14)
			{
				num20 = maxScroll;
			}
		}
		scroll = num20;
		bool flag15 = (byte)(~(atEnd ? 1u : 0u)) != 0;
		object obj19 = !flag15;
		double num21 = num18;
		float num22 = maxScroll;
		if (obj19 == null)
		{
			num22 = (float)maxScroll + -0.5f;
			bool flag16 = num20 < num22;
			num21 = -0.5;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj20 = 0;
				endAt = now;
				object obj21 = obj20;
				atEnd = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v23+E4]");
				bool flag17 = (nint)0 == 0;
				object obj22 = !flag17;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9230]");
				object message = 0;
				Debug.Log(message);
				num21 = -0.5;
			}
		}
		bool pointsLeft = Points(0);
		bool pointsRight = Points(1);
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v18+E4]");
		bool flag18 = (nint)0 == 0;
		object obj24 = !flag18;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag19 = AnyButton(pointsLeft, pointsRight);
		if (~(atEnd ? 1u : 0u) == 0 && ((flag19 && ~(held ? 1u : 0u) != 0) || ~(tapped ? 1u : 0u) == 0))
		{
			float num23 = now - endAt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			if (!(num23 < 0f))
			{
				Accept(now);
			}
		}
		held = flag19;
		return;
		IL_0aa9:
		object obj25;
		KeyControl pageDownKey = ((Keyboard)obj25).pageDownKey;
		bool wasPressedThisFrame = pageDownKey.wasPressedThisFrame;
		KeyControl pageUpKey = ((Keyboard)obj25).pageUpKey;
		bool flag20 = !wasPressedThisFrame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB78]");
		float num24 = 0f;
		object obj26 = !flag20;
		object obj27 = ~obj26;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB78]");
			num19 = 0f;
		}
		else
		{
			num19 = 0f;
		}
		bool wasPressedThisFrame2 = pageUpKey.wasPressedThisFrame;
		bool flag21 = !wasPressedThisFrame2;
		float num25 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB34]");
		float num26 = num25 + 0f;
		object obj28 = !flag21;
		object obj29 = ~obj28;
		if (obj29 == null)
		{
			num19 = num26;
		}
		KeyControl endKey = ((Keyboard)obj25).endKey;
		if (endKey.wasPressedThisFrame)
		{
			num19 += (float)maxScroll;
		}
		KeyControl homeKey = ((Keyboard)obj25).homeKey;
		bool wasPressedThisFrame3 = homeKey.wasPressedThisFrame;
		bool flag22 = !wasPressedThisFrame3;
		flag4 = false;
		if (!flag22)
		{
			num19 -= (float)maxScroll;
			flag4 = false;
		}
		goto IL_0d3c;
		IL_0a97:
		KeyControl upArrowKey = ((Keyboard)obj25).upArrowKey;
		bool isPressed = upArrowKey.isPressed;
		bool flag23 = !isPressed;
		object obj30 = !flag23;
		if (obj30 == null)
		{
			KeyControl wKey = ((Keyboard)obj25).wKey;
			if (!wKey.isPressed)
			{
				goto IL_0aa9;
			}
		}
		num11 = -1.0;
		goto IL_0aa9;
		IL_0957:
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v9+E4]");
		bool flag24 = (nint)0 == 0;
		object obj32 = !flag24;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v9+A0]");
		object obj33 = 0;
		num11 = 0f - num3;
		bool flag25 = obj33 == null;
		object obj34 = !flag25;
		num19 = 0f;
		if (obj34 != null)
		{
			goto IL_0a2b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D08]");
		object obj35 = 0;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v41+A0]");
		obj25 = 0;
		if (obj25 != null)
		{
			KeyControl downArrowKey = ((Keyboard)obj25).downArrowKey;
			bool isPressed2 = downArrowKey.isPressed;
			bool flag26 = !isPressed2;
			object obj37 = !flag26;
			if (obj37 == null)
			{
				KeyControl sKey = ((Keyboard)obj25).sKey;
				if (!sKey.isPressed)
				{
					goto IL_0a97;
				}
			}
			num11 = 1.0;
			goto IL_0a97;
		}
		num19 = 0f;
		num24 = num;
		goto IL_0d3c;
		IL_0d3c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v48+A0]");
		object obj40 = 0;
		object obj41 = obj40;
		if (obj40 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CF8]");
			object obj42 = 0;
			flag4 = (byte)(int)obj42 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v50+1B8]");
			Vector2 vector3 = ((InputControl<Vector2>)0).ReadValue();
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			float num27 = num24 / 1.1230249E+09f;
			object obj43 = default;
			double num28 = (double)obj43 - 10.0;
			bool flag27 = num28 < 0.0;
			bool flag28 = num28 == 0.0;
			object obj44 = obj43 ^ 10.0;
			object obj45 = obj43 ^ num28;
			object obj46 = obj44 & obj45;
			bool flag29 = (nint)obj46 < 0;
			bool flag30 = flag27 == flag29;
			object obj47 = !flag28;
			object obj48 = flag30 & obj47;
			object obj49 = ~obj48;
			if (obj49 != null)
			{
				num27 = num24;
			}
			float num29 = num27 * -3f;
			float num30 = num29 * 10f;
			num19 += num30;
		}
		goto IL_0a2b;
		IL_0a2b:
		double num31 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		int num32;
		if (num31 > 0.0)
		{
			num32 = 1;
		}
		else
		{
			double num33 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A978]");
			if (!(num33 < 0.0))
			{
				bool flag31 = num19 == 0f;
				heldFor = 0f;
				num7 = 0f;
				if (flag31)
				{
					goto IL_0ca8;
				}
				num7 = 0f;
				goto IL_0ce2;
			}
			num32 = -1;
		}
		bool flag32 = num32 != heldWay;
		num7 = 0f;
		if (!flag32)
		{
			num7 = num + heldFor;
		}
		heldFor = num7;
		heldWay = num32;
		goto IL_0ce2;
	}

	private bool Points(int i)
	{
		//IL_0148: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		Hand[] array = hands;
		if (hands != null)
		{
			bool flag = array.Length < i;
			object obj = !flag;
			object obj2 = array.Length - i;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_013a;
			}
			object obj5 = hands + i;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+21]");
				if ((nint)0 != 0)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+2C]");
				bool flag3 = (nint)0 == 0;
				return !flag3;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_013a;
		IL_013a:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe void Point(float now, float dt)
	{
		//IL_0b2d: Expected Obj, but got I
		//IL_0b3d: Expected Obj, but got I
		//IL_0ba1: Invalid comparison between F8 and I4
		//IL_0bb0: Invalid comparison between F8 and I4
		//IL_0bc8: Expected Obj, but got F8
		//IL_0bd5: Expected Obj, but got F8
		//IL_0c0a: Expected Obj, but got I4
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected Obj, but got Unknown
		//IL_0c37: Invalid comparison between F8 and I4
		//IL_0c57: Expected VT, but got I4
		//IL_0c60: Expected F8, but got I4
		//IL_0c69: Expected Obj, but got I4
		//IL_0c72: Expected Obj, but got I4
		//IL_0c7b: Expected F8, but got I4
		//IL_0c8b: Expected F8, but got I
		//IL_0c94: Expected Obj, but got I4
		//IL_002d: Expected F8, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0d1e: Expected VT, but got Obj
		//IL_0d26: Expected Obj, but got Ref
		//IL_0d2e: Expected VT, but got Ref
		//IL_0d3e: Expected VT, but got F8
		//IL_017a: Expected Obj, but got I4
		//IL_0d6e: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_020c: Expected VT, but got Ref
		//IL_020c: Expected VT, but got Ref
		//IL_022f: Expected VT, but got Ref
		//IL_0237: Expected Obj, but got Ref
		//IL_023f: Expected VT, but got Ref
		//IL_0248: Expected F8, but got I4
		//IL_0e42: Expected Obj, but got I
		//IL_0e64: Expected Obj, but got I4
		//IL_0279: Invalid comparison between VT and I4
		//IL_028a: Expected Obj, but got I4
		//IL_066d: Expected Obj, but got I4
		//IL_08a0: Invalid comparison between I and F8
		//IL_02ff: Expected F8, but got I4
		//IL_0317: Expected VT, but got Ref
		//IL_031f: Expected Obj, but got Ref
		//IL_0327: Expected VT, but got Ref
		//IL_0330: Expected F8, but got I4
		//IL_06ac: Expected I, but got Obj
		//IL_06b5: Expected VT, but got I4
		//IL_0964: Expected VT, but got I
		//IL_0977: Invalid comparison between F8 and I4
		//IL_098e: Expected F8, but got I4
		//IL_041e: Expected VT, but got I
		//IL_0448: Invalid comparison between F8 and I4
		//IL_0457: Invalid comparison between F8 and I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_04bc: Expected Obj, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04d2: Expected I4, but got Obj
		//IL_02bf: Expected VT, but got Ref
		//IL_02c7: Expected Obj, but got Ref
		//IL_02cf: Expected VT, but got Ref
		//IL_02d8: Expected F8, but got I4
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_0858: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I4
		//IL_0869: Expected F8, but got VT
		//IL_0872: Expected Obj, but got I4
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected VT, but got Unknown
		//IL_08e9: Invalid comparison between VT and I
		//IL_08fa: Expected Obj, but got I4
		//IL_091a: Invalid comparison between F8 and I4
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected Obj, but got Unknown
		//IL_0946: Expected F8, but got I
		//IL_03e4: Expected VT, but got F4
		//IL_09ae: Expected F4, but got I
		//IL_09bf: Expected F8, but got I4
		//IL_09e7: Expected F8, but got I
		//IL_0fe0: Invalid comparison between F4 and I4
		//IL_0ff2: Expected F4, but got I4
		//IL_04f0: Expected F8, but got I
		//IL_1010: Expected F8, but got I
		//IL_105f: Expected VT, but got F8
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_052a: Invalid comparison between F4 and I4
		//IL_0539: Expected F4, but got I4
		//IL_09f7: Invalid comparison between F4 and I4
		//IL_06fd: Expected Obj, but got I
		//IL_0718: Expected I, but got Obj
		//IL_0721: Expected VT, but got I4
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_0551: Invalid comparison between F4 and I4
		//IL_0a2f: Expected Obj, but got I4
		//IL_057a: Expected F4, but got I4
		//IL_0a68: Invalid comparison between F4 and I4
		//IL_0a77: Expected F4, but got I4
		//IL_078b: Expected Obj, but got I
		//IL_079c: Expected VT, but got I4
		//IL_0eb5: Invalid comparison between F4 and I4
		//IL_0ec6: Expected Obj, but got I4
		//IL_0ecf: Invalid comparison between F4 and I4
		//IL_0eea: Expected Obj, but got I4
		//IL_07d1: Expected VT, but got I4
		//IL_0a8f: Invalid comparison between F4 and I4
		//IL_0f19: Expected Obj, but got I4
		//IL_0f33: Invalid comparison between F4 and I4
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected Obj, but got Unknown
		//IL_0f55: Expected Obj, but got F4
		//IL_0f8a: Expected Obj, but got I4
		//IL_0fb1: Expected Obj, but got I4
		//IL_0adc: Invalid comparison between F8 and I4
		//IL_0801: Expected VT, but got I4
		//IL_0813: Expected VT, but got I4
		//IL_082b: Expected VT, but got F8
		//IL_0b03: Expected F4, but got I4
		//IL_0ab8: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		tapped = false;
		Transform transform = Space();
		float num = dt * -12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num2 = 1.0 - (double)num;
		double num3 = num2 - 1.0;
		bool flag = num3 < 0.0;
		bool flag2 = num3 == 0.0;
		object obj3 = num2 ^ 1.0;
		object obj4 = num2 ^ num3;
		object obj5 = obj3 & obj4;
		bool flag3 = (nint)obj5 < 0;
		bool flag4 = flag == flag3;
		object obj6 = !flag2;
		object obj7 = flag4 & obj6;
		object obj8 = ~obj7;
		double num4 = ((obj8 != null) ? num2 : 1.0);
		double num5 = ((!(num2 < 0.0)) ? num4 : 0.0);
		Vector2 at = (Vector2)0;
		double num6 = 0.0;
		object obj9 = 0;
		object obj10 = 1;
		double num7 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
		double num8 = 0.0;
		object obj11 = 0;
		object obj20 = default;
		double num13 = default;
		ref Vector3 point = default;
		ref bool inside = default;
		double num15 = default;
		float num18;
		while (true)
		{
			Hand[] array = hands;
			Vector3 dir;
			double num11;
			double num12;
			double num14;
			Vector3 vector3;
			if (hands != null)
			{
				bool flag5 = (nint)obj11 < array.Length;
				object obj12 = !flag5;
				if (obj12 != null)
				{
					goto IL_0b16;
				}
				object obj13 = (object)hands + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v7+20]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v7+20]");
				if ((nint)0 != 0)
				{
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v10+E4]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+10]");
					bool flag7 = (nint)0 == 0;
					bool right = !flag7;
					object obj19;
					if (Aim(right, transform, out var from, out dir))
					{
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v45+E4]");
						bool flag8 = (nint)0 == 0;
						object obj18 = !flag8;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+10]");
						bool flag9 = (nint)0 == 0;
						bool right2 = !flag9;
						bool flag10 = PointerDown(right2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+20]");
						obj19 = 0;
					}
					else
					{
						bool flag10 = false;
						obj19 = 0;
					}
					double num9 = (double)dir * 1.5;
					num4 = (double)obj20 * 1.5;
					_ = 0;
					double num10 = 0.0 * 1.5;
					num11 = (double)from + num9;
					num12 = num13 + num4;
					bool flag11 = obj19 == null;
					num14 = num10;
					Vector3 vector = (Vector3)transform;
					object obj21 = (object)(&dir);
					Vector3 vector2 = (Vector3)(&from);
					num7 = num10;
					vector3 = (Vector3)num9;
					if (!flag11)
					{
						bool flag12 = OnBoard((Vector3)(&obj9), (Vector3)(&num6), out at, out point, out inside);
						bool flag13 = !flag12;
						num14 = num10;
						vector = (Vector3)(&obj9);
						obj21 = (object)(&at);
						vector2 = (Vector3)(&num6);
						num7 = 0.0;
						num4 = num13;
						vector3 = from;
						if (!flag13)
						{
							bool flag14 = at == (Vector2)(object)0;
							object obj22 = !flag14;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+2C]");
								bool flag15 = (nint)0 == 0;
								num14 = num10;
								vector = (Vector3)(&obj9);
								obj21 = (object)(&at);
								vector2 = (Vector3)(&num6);
								num7 = 0.0;
								num4 = num13;
								vector3 = from;
								if (flag15)
								{
									goto IL_0d4c;
								}
							}
							num14 = 0.0;
							num12 = num15;
							num11 = num6;
							vector = (Vector3)(&obj9);
							obj21 = (object)(&at);
							vector2 = (Vector3)(&num6);
							num7 = 0.0;
							num4 = num13;
							vector3 = from;
						}
					}
					goto IL_0d4c;
				}
			}
			goto IL_0b08;
			IL_0830:
			object obj23 = obj10 & 1;
			bool flag16 = obj23 == null;
			object obj24 = !flag16;
			obj10 = 0;
			num8 = (double)vector3;
			obj11 = 1;
			if (obj24 != null)
			{
				continue;
			}
			if (fling == 0f)
			{
				return;
			}
			bool dragging = Dragging;
			bool flag17 = !dragging;
			object obj25 = !flag17;
			if (obj25 != null)
			{
				return;
			}
			float num16 = fling * dt;
			float num17 = scroll + num16;
			bool flag18 = num17 < 0f;
			num18 = 0f;
			if (!flag18)
			{
				bool flag19 = !(num17 > (float)maxScroll);
				num18 = num17;
				if (!flag19)
				{
					num18 = maxScroll;
				}
			}
			break;
			IL_0d4c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+22]");
			bool flag20 = (nint)0 == 0;
			object obj26 = !flag20;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+22]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+21]");
					if ((nint)0 != 0)
					{
						num4 = scroll;
						_ = 1;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+28]");
						_ = 0;
						_ = scroll;
						_ = 0;
						fling = 0f;
						vector3 = (Vector3)now;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+2C]");
			bool flag21 = (nint)0 == 0;
			Vector3 vector4 = dir;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+22]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+28]");
					vector3 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+3C]");
					double num19 = 0.0 - num7;
					bool flag22 = num19 < 0.0;
					bool flag23 = num19 == 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+3C]");
					object obj27 = 0 ^ num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+3C]");
					object obj28 = 0 ^ num19;
					object obj29 = obj27 & obj28;
					bool flag24 = (nint)obj29 < 0;
					bool flag25 = flag22 == flag24;
					obj6 = !flag23;
					object obj30 = flag25 & obj6;
					if ((int)(~obj30) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+3C]");
						num7 = 0.0;
					}
					if (!(num7 < 6.0))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+30]");
						object obj31 = 0 - vector3;
						float num20 = (float)obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+34]");
						float num21 = num20 + 0f;
						bool flag26 = num21 < 0f;
						float num22 = 0f;
						if (!flag26)
						{
							bool flag27 = !(num21 > (float)maxScroll);
							num22 = num21;
							if (!flag27)
							{
								num22 = maxScroll;
							}
						}
						scroll = num22;
					}
					bool flag28 = !(dt > 0f);
					float num23 = 0f;
					if (!flag28)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+40]");
						object obj32 = 0 - vector3;
						num23 = (float)obj32 / dt;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+44]");
					num7 = 0.0;
					float num24 = num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+44]");
					float num25 = num24 - 0f;
					float num26 = num25 * (float)num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+44]");
					num4 = 0.0 + (double)num26;
					vector4 = (Vector3)num5;
				}
				else
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+3C]");
					bool flag29 = !(0.0 < 6.0);
					num4 = 6.0;
					if (!flag29)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+38]");
						vector3 = (Vector3)(now - 0);
						Vector3 vector5 = vector3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						bool flag30 = vector5 < (object)0;
						object obj33 = !flag30;
						double num27 = (double)vector3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						double num28 = num27 - 0.0;
						bool flag31 = num28 == 0.0;
						object obj34 = ~obj33;
						object obj35 = obj34 | flag31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						num4 = 0.0;
						if (obj35 != null)
						{
							tapped = true;
							vector4 = dir;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
							num4 = 0.0;
							goto IL_0e24;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+44]");
					vector3 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					bool flag32 = num4 < 1109393408.0;
					vector4 = dir;
					num7 = 1109393408.0;
					if (!flag32)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+44]");
						fling = 0f;
						vector4 = dir;
						num7 = 1109393408.0;
					}
				}
			}
			goto IL_0e24;
			IL_0b08:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0b16;
			IL_0b16:
			throw new IndexOutOfRangeException();
			IL_0e24:
			object obj36 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v7+20]");
			object obj37 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v16+E4]");
			bool flag33 = (nint)0 == 0;
			object obj38 = !flag33;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag34 = (UnityEngine.Object)obj37 == null;
			bool flag35 = !flag34;
			UnityEngine.Object obj39 = null;
			if (!flag35)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+20]");
				bool flag36 = (nint)0 == 0;
				obj39 = null;
				if (!flag36)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+10]");
					LineRenderer lineRenderer = MakeRay(right: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj39 = lineRenderer;
				}
			}
			object obj40 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v21+E4]");
			bool flag37 = (nint)0 == 0;
			object obj41 = !flag37;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag38 = (UnityEngine.Object)obj37 != null;
			bool flag39 = !flag38;
			nint num29 = unchecked((nint)null);
			Vector3 vector6 = (Vector3)0;
			if (flag39)
			{
				goto IL_0830;
			}
			if (obj37 != null)
			{
				bool flag40 = ((Renderer)obj37).enabled;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+20]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+20]");
				bool flag41 = (nint)0 == (flag40 ? 1 : 0);
				num29 = unchecked((nint)null);
				vector6 = (Vector3)0;
				if (!flag41)
				{
					if (obj37 == null)
					{
						goto IL_0b08;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+20]");
					bool flag42 = (nint)0 == 0;
					bool flag43 = (((Renderer)obj37).enabled = !flag42);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X28_v4+20]");
					obj42 = 0;
					num29 = (flag43 ? 1 : 0);
					vector6 = (Vector3)0;
				}
				if (obj42 == null)
				{
					goto IL_0830;
				}
				if (obj37 != null)
				{
					((LineRenderer)obj37).SetPosition(0, (Vector3)0);
					if (obj37 != null)
					{
						((LineRenderer)obj37).SetPosition(1, (Vector3)0);
						num29 = 1;
						vector6 = (Vector3)0;
						num7 = num14;
						num4 = num12;
						vector3 = (Vector3)num11;
						goto IL_0830;
					}
				}
			}
			goto IL_0b08;
		}
		scroll = num18;
		float num30 = dt * -3f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		float num31 = num30 * fling;
		bool flag45 = num18 < 0f;
		object obj43 = !flag45;
		bool flag46 = num18 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj44 = !flag46;
		object obj45 = obj43 & obj44;
		object obj46 = ~obj45;
		bool flag47;
		if (obj46 == null)
		{
			double num32 = (double)maxScroll - 20.0;
			flag47 = num32 < 0.0;
		}
		else
		{
			flag47 = true;
		}
		object obj47 = !flag47;
		float num33 = num18 - (float)maxScroll;
		bool flag48 = num33 < 0f;
		object obj48 = num18 ^ maxScroll;
		object obj49 = num18 ^ num33;
		object obj50 = obj48 & obj49;
		bool flag49 = (nint)obj50 < 0;
		bool flag50 = flag48 == flag49;
		object obj51 = !flag50;
		object obj52 = obj47 & obj51;
		bool flag51 = obj52 == null;
		object obj53 = !flag51;
		object obj54 = ~obj53;
		if (obj54 != null)
		{
			num31 = 0f;
		}
		fling = num31;
	}

	private void Rays(bool on)
	{
		//IL_0256: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I8
		//IL_0048: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_013f: Expected I, but got Obj
		//IL_0210: Expected Obj, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I
		//IL_01a3: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_01f9: Expected I, but got Obj
		Hand[] array = hands;
		if (hands == null)
		{
			goto IL_0274;
		}
		if (array.Length < 1)
		{
			goto IL_023c;
		}
		object obj = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = hands + 32;
		bool flag = on;
		object obj4 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj5 = !flag2;
			if (obj5 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v5+v77 @ X23_v6*8]");
			object obj6 = 0;
			if (on)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v5+v77 @ X23_v6*8]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					goto IL_0274;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v5+v77 @ X23_v6*8]");
				if ((nint)0 == 0)
				{
					goto IL_0274;
				}
				_ = 0;
				_ = 0;
			}
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v6+18]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			nint num = unchecked((nint)null);
			flag = false;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v6+18]");
				if ((nint)0 == 0)
				{
					goto IL_0274;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v6+18]");
				bool flag7 = ((Renderer)0).enabled;
				bool flag8 = flag7 == on;
				num = unchecked((nint)null);
				flag = false;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v6+18]");
					if ((nint)0 == 0)
					{
						goto IL_0274;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v6+18]");
					((Renderer)0).enabled = on;
					num = unchecked((nint)null);
					flag = on;
				}
			}
			obj = array.Length;
			obj4++;
			if ((nint)obj4 < array.Length)
			{
				continue;
			}
			goto IL_023c;
		}
		goto IL_0282;
		IL_0282:
		throw new IndexOutOfRangeException();
		IL_0274:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0282;
		IL_023c:
		bool flag9 = !on;
		object obj10 = !flag9;
		if (obj10 == null)
		{
			fling = 0f;
		}
	}

	private Transform Space()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_02df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9270]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj9 = default;
		bool flag5 = obj9 != null;
		bool flag6 = !flag5;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		if (flag6)
		{
			goto IL_01e7;
		}
		Transform transform;
		if ((object)obj9 != null)
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v30+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v9 (UnityEngine.Object)+20]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			obj10 = 0;
			obj11 = null;
			if (flag9)
			{
				goto IL_01e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v9 (UnityEngine.Object)+20]");
			transform = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v9 (UnityEngine.Object)+20]");
			bool flag10 = (nint)0 == 0;
			object obj14 = !flag10;
			object obj15 = 0;
			if (obj14 != null)
			{
				goto IL_02bb;
			}
		}
		goto IL_02e4;
		IL_01e7:
		Camera main = Camera.main;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v11+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(main != null))
		{
			goto IL_02df;
		}
		Camera main2 = Camera.main;
		if ((object)main2 != null)
		{
			transform = main2.transform;
			bool flag12 = (object)transform == null;
			object obj15 = 0;
			if (!flag12)
			{
				goto IL_02bb;
			}
		}
		goto IL_02e4;
		IL_02df:
		return (Transform)obj3;
		IL_02bb:
		Transform parent = transform.parent;
		obj3 = parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_02df;
		IL_02e4:
		return (Transform)(object)new NullReferenceException();
	}

	private unsafe static bool Aim(bool right, Transform space, out Vector3 from, out Vector3 dir)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I
		//IL_05ec: Expected Obj, but got I
		//IL_044b: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected VT, but got Unknown
		//IL_017f: Expected Ref, but got VT
		//IL_01a8: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0556: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I
		//IL_0229: Expected VT, but got Obj
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected VT, but got Unknown
		//IL_0240: Expected Ref, but got VT
		//IL_0348: Expected VT, but got I4
		//IL_035d: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I
		//IL_0596: Expected Obj, but got I
		//IL_059e: Expected VT, but got Obj
		//IL_05ae: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I
		//IL_05c7: Expected VT, but got I4
		//IL_061f: Expected VT, but got I4
		//IL_062b: Expected Ref, but got VT
		//IL_0651: Expected VT, but got I4
		//IL_0425: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+10]");
		Vector3 vector3;
		Vector3 vector4;
		ref Vector3 reference;
		if ((nint)0 != 0)
		{
			bool flag2 = right;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v31+18]");
			bool flag3 = (nint)(flag2 ? 1 : 0) < (nint)0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+10]");
				object obj7 = (nint)0 + (nint)(right ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X9_v4+20]");
				if ((nint)0 == 0)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v12+A0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v13+48]");
					reference = ref *(Vector3*)null;
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v13+50]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v14+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (PointerPose(right, out var pos, out var _))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj13 = 0;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+E4]");
						bool flag5 = (nint)0 == 0;
						object obj15 = !flag5;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 vector2;
						object obj16;
						object obj17;
						object obj18 = default;
						if (space != null)
						{
							if ((object)space == null)
							{
								goto IL_043d;
							}
							Vector3 vector = space.TransformPoint((Vector3)0);
							vector2 = pos;
							obj16 = 0;
							obj17 = obj18;
							UnityEngine.Object obj19 = null;
						}
						else
						{
							vector2 = pos;
							obj16 = 0;
							obj17 = obj18;
							UnityEngine.Object obj19 = null;
						}
						object obj20 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v24+E4]");
						bool flag6 = (nint)0 == 0;
						object obj21 = !flag6;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (space != null)
						{
							if ((object)space == null)
							{
								goto IL_043d;
							}
							Quaternion rotation = space.rotation;
							object obj22 = obj16;
							object obj23 = obj17;
							vector3 = vector2;
							vector4 = (Vector3)0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
							object obj24 = 0;
							object obj25 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v27+A0]");
							object obj26 = 0;
							vector3 = (Vector3)obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v28+4]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v28+8]");
							object obj22 = 0;
							vector4 = (Vector3)0;
						}
						Vector3 vector5 = (Quaternion)0 * vector4;
						goto IL_0611;
					}
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
				bool flag7 = (nint)0 == 0;
				object obj27 = !flag7;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj28 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v45+A0]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v46+10]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v46+10]");
					if ((nint)0 == 0)
					{
						goto IL_043d;
					}
				}
				bool flag8 = right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v31+18]");
				bool flag9 = (nint)(flag8 ? 1 : 0) < (nint)0;
				object obj30 = !flag9;
				if (obj30 == null)
				{
					object obj31 = obj5 + right;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9280]");
					object obj32 = 0;
					Pose? pose = (Pose?)(object)(obj31 + 32);
					Pose value = ((Pose?*)pose)->Value;
					object obj33 = default;
					ref Vector3 reference2 = ref *(Vector3*)obj33;
					object obj34 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v34+A0]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v35+10]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v35+10]");
					if ((nint)0 == 0)
					{
						goto IL_043d;
					}
					bool flag10 = right;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v36+18]");
					bool flag11 = (nint)(flag10 ? 1 : 0) < (nint)0;
					object obj37 = !flag11;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v35+10]");
						object obj38 = (nint)0 + (nint)(right ? 1 : 0);
						vector4 = (Vector3)obj32;
						Pose? pose2 = (Pose?)(object)(obj38 + 32);
						Pose value2 = ((Pose?*)pose2)->Value;
						object obj39 = default;
						object obj22 = obj39;
						object obj40 = default;
						object obj23 = obj40;
						Vector3 vector6 = default;
						vector3 = vector6;
						goto IL_0611;
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_043d;
		IL_0611:
		Vector3 vector7 = (Quaternion)0 * vector4;
		reference = ref *(Vector3*)vector3;
		return true;
		IL_043d:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe static bool PointerPose(bool right, out Vector3 pos, out Quaternion rot)
	{
		//IL_0232: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_07f8: Expected Obj, but got I
		//IL_0810: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_06fc: Expected Obj, but got I
		//IL_070d: Expected VT, but got Obj
		//IL_071c: Expected Obj, but got I4
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got I4
		//IL_0764: Expected Obj, but got I
		//IL_077d: Expected VT, but got I
		//IL_0204: Invalid comparison between Obj and F8
		//IL_0343: Expected Obj, but got I4
		//IL_07ae: Expected Obj, but got I
		//IL_07c7: Expected VT, but got I
		//IL_037f: Expected Obj, but got VT
		//IL_039c: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_040a: Invalid comparison between Obj and F8
		//IL_044b: Expected Obj, but got I
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_0535: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_0662: Expected Ref, but got F8
		XRController xRController = ((!right) ? XRController.leftHand : XRController.rightHand);
		bool flag = xRController == null;
		ref Quaternion reference = ref rot;
		object obj13 = default;
		object obj16 = default;
		ref Vector3 reference2;
		ref Quaternion reference3;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92C0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EE0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92C8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92D0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92B0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
			reference = ref *(Quaternion*)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
			InputControl<Vector3> inputControl = default;
			InputControl<Quaternion> inputControl2 = default;
			ButtonControl buttonControl = default;
			if (inputControl != null && inputControl2 != null && (buttonControl == null || buttonControl.isPressed))
			{
				Vector3 vector = inputControl.ReadValue();
				object obj7 = default;
				reference2 = ref *(Vector3*)obj7;
				Quaternion quaternion = inputControl2.ReadValue();
				object obj8 = obj7 * obj7;
				object obj10 = default;
				object obj9 = obj10 * obj10;
				reference3 = ref *(Quaternion*)obj7;
				object obj11 = obj8 + obj9;
				object obj12 = obj13 * obj13;
				object obj14 = obj12 + obj11;
				object obj15 = obj16 * obj16;
				object obj17 = obj15 + obj14;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5))
				{
					goto IL_06a7;
				}
			}
		}
		bool flag2 = !right;
		object obj18 = !flag2;
		object obj19 = ~obj18;
		XRNode node = ((obj19 != null) ? ((XRNode)4) : ((XRNode)5));
		UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		UnityEngine.XR.InputDevice inputDevice = default;
		if (inputDevice.isValid)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj22 = !flag3;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v19+A0]");
			object obj23 = 0;
			bool flag4 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)obj23, out var value);
			object obj24 = !flag4;
			object obj25 = 1 & obj24;
			object obj26 = value | obj25;
			if (obj26 != null)
			{
				object obj27 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v23+E4]");
				bool flag5 = (nint)0 == 0;
				object obj28 = !flag5;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj20;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v23+A0]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v20+98]");
				if (inputDevice.TryGetFeatureValue((InputFeatureUsage<Vector3>)0, out pos))
				{
					object obj30 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v27+E4]");
					bool flag6 = (nint)0 == 0;
					object obj31 = !flag6;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj30 = obj20;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v27+A0]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v22+160]");
					if (inputDevice.TryGetFeatureValue((InputFeatureUsage<Quaternion>)0, out rot))
					{
						object obj33 = rot * rot;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+4]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+4]");
						object obj34 = num * 0;
						object obj35 = obj33 + obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+8]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+8]");
						object obj36 = num2 * 0;
						object obj37 = obj36 + obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+C]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+C]");
						object obj38 = num3 * 0;
						object obj39 = obj38 + obj37;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5))
						{
							Vector3 euler = default;
							Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+C]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5A0]");
							object obj40 = num4 * 0;
							object obj41 = rot * obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+C]");
							double num5 = 0.0 * 0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+4]");
							object obj42 = 0 * obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+C]");
							object obj43 = 0 * obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+8]");
							object obj44 = 0 * obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+C]");
							object obj45 = 0 * obj16;
							Quaternion quaternion3 = rot;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5A0]");
							object obj46 = quaternion3 * 0;
							object obj47 = obj40 + obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+4]");
							object obj48 = 0 * obj13;
							double num6 = num5 + (double)obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+8]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5A0]");
							object obj49 = num7 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+4]");
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5A0]");
							object obj50 = num8 * 0;
							object obj51 = obj43 + obj44;
							double num9 = (double)rot * 0.5;
							object obj52 = obj45 - obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+4]");
							double num10 = 0.0 * 0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+8]");
							double num11 = 0.0 * 0.5;
							object obj53 = obj48 + obj47;
							double num12 = (double)obj49 + num6;
							object obj54 = rot * obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rot @ X2 (UnityEngine.Quaternion&)+8]");
							object obj55 = 0 * obj13;
							double num13 = num9 + (double)obj51;
							double num14 = (double)obj52 - num10;
							double num15 = (double)obj53 - num11;
							double num16 = num12 - (double)obj54;
							double num17 = num13 - (double)obj50;
							double num18 = num14 - (double)obj55;
							reference3 = ref *(Quaternion*)num15;
							goto IL_06a7;
						}
					}
				}
			}
		}
		_ = 0;
		reference2 = ref *(Vector3*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj56 = 0;
		object obj57 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v12+A0]");
		object obj58 = 0;
		reference3 = ref *(Quaternion*)obj58;
		return false;
		IL_06a7:
		return true;
	}

	private unsafe static bool PointerDown(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04c6: Expected Obj, but got I4
		//IL_067f: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I
		//IL_049c: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_0540: Expected VT, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I
		//IL_0577: Expected VT, but got I
		//IL_025f: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_05a8: Expected Obj, but got I
		//IL_05b8: Expected VT, but got I
		//IL_05d1: Expected VT, but got I
		//IL_05ed: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got Ref
		//IL_0227: Expected Obj, but got I4
		//IL_0613: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got Ref
		//IL_03a0: Expected Obj, but got I8
		//IL_03b0: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I4
		//IL_0661: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0422: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v25+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v25+10]");
		if ((nint)0 != 0)
		{
			bool flag2 = right;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v1+18]");
			bool flag3 = (nint)(flag2 ? 1 : 0) < (nint)0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v25+10]");
				object obj7 = (nint)0 + (nint)(right ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X9_v4+20]");
				if ((nint)0 == 0)
				{
					bool flag4 = !right;
					object obj8 = !flag4;
					object obj9 = ~obj8;
					XRNode node = ((obj9 != null) ? ((XRNode)4) : ((XRNode)5));
					UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
					UnityEngine.XR.InputDevice inputDevice = default;
					bool isValid = inputDevice.isValid;
					bool flag5 = !isValid;
					InputFeatureUsage<bool> inputFeatureUsage = (InputFeatureUsage<bool>)0;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
						object obj10 = 0;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v32+E4]");
						bool flag6 = (nint)0 == 0;
						object obj12 = !flag6;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj11 = obj10;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v32+A0]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v19+30]");
						if (inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out var value))
						{
							bool flag7 = !value;
							object obj14 = !flag7;
							if (obj14 != null)
							{
								goto IL_02ae;
							}
						}
						object obj15 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v36+E4]");
						bool flag8 = (nint)0 == 0;
						object obj16 = !flag8;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj15 = obj10;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v36+A0]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v22+28]");
						inputFeatureUsage = (InputFeatureUsage<bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v22+28]");
						bool flag9 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out var value2);
						bool flag10 = !flag9;
						object obj18 = 0;
						object obj19 = (object)(&value2);
						if (!flag10)
						{
							bool flag11 = !value2;
							obj18 = 0;
							obj19 = (object)(&value2);
							if (!flag11)
							{
								goto IL_02ae;
							}
						}
					}
					XRController xRController = ((!right) ? XRController.leftHand : XRController.rightHand);
					if (xRController != null)
					{
						object obj20 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v19+E4]");
						bool flag12 = (nint)0 == 0;
						object obj21 = !flag12;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj20 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v19+A0]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12+C8]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12+C8]");
						if ((nint)0 == 0)
						{
							goto IL_048e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v8+18]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v8+18]");
							object obj24 = 0 & 0xFFFFFFFFL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EE0]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12+C8]");
							object obj26 = (nint)0 + (nint)32;
							object obj27 = 0;
							ButtonControl buttonControl = default;
							while (true)
							{
								bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
								object obj28 = !flag13;
								if (obj28 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
								if (buttonControl != null)
								{
									bool isPressed = buttonControl.isPressed;
									bool flag14 = !isPressed;
									object obj29 = !flag14;
									if (obj29 != null)
									{
										goto IL_02ae;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v8+18]");
								obj24 = 0;
								obj27++;
								object obj30 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v8+18]");
								if ((nint)obj30 < 0)
								{
									continue;
								}
								goto IL_0472;
							}
							goto IL_0480;
						}
					}
					goto IL_0472;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
				bool flag15 = (nint)0 == 0;
				object obj31 = !flag15;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj32 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v29+A0]");
					obj4 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v25+18]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v25+18]");
				if ((nint)0 == 0)
				{
					goto IL_048e;
				}
				bool flag16 = right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v26+18]");
				bool flag17 = (nint)(flag16 ? 1 : 0) < (nint)0;
				object obj34 = !flag17;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v25+18]");
					object obj35 = (nint)0 + (nint)(right ? 1 : 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v27+20]");
					bool flag18 = (nint)0 == 0;
					return !flag18;
				}
			}
			goto IL_0480;
		}
		goto IL_048e;
		IL_0480:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_048e;
		IL_0472:
		return false;
		IL_048e:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_02ae:
		return true;
	}

	private unsafe bool OnBoard(Vector3 from, Vector3 dir, out Vector2 at, out Vector3 point, out bool inside)
	{
		//IL_0009: Expected native int or pointer, but got VT
		//IL_0017: Expected native int or pointer, but got VT
		//IL_0025: Expected native int or pointer, but got VT
		//IL_0499: Expected I4, but got Obj
		//IL_04a9: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I4
		//IL_0625: Expected Obj, but got I
		//IL_0651: Expected Obj, but got I
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected Obj, but got Unknown
		//IL_06f0: Expected Obj, but got I4
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I
		//IL_034c: Expected native int or pointer, but got VT
		//IL_0359: Expected native int or pointer, but got VT
		//IL_0366: Expected native int or pointer, but got VT
		//IL_0379: Expected VT, but got I4
		//IL_03de: Invalid comparison between F8 and I4
		//IL_03ec: Expected native int or pointer, but got VT
		//IL_03f9: Expected native int or pointer, but got VT
		//IL_0407: Invalid comparison between F8 and I4
		//IL_05c0: Invalid comparison between F8 and I4
		//IL_05d3: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I4
		//IL_0424: Invalid comparison between F8 and I4
		//IL_0437: Expected Obj, but got F8
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got I4
		((Vector3*)(nint)from)->x = 0f;
		((Vector3*)(nint)dir)->z = 0f;
		((Vector3*)(nint)dir)->x = 0f;
		ref Vector2 reference = ref *(Vector2*)null;
		if ((object)board != null)
		{
			Transform transform = board.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = default;
			object obj4 = obj5 * obj5;
			object obj7 = default;
			object obj6 = obj7 * obj7;
			object obj8 = obj4 + obj6;
			object obj10 = default;
			object obj9 = obj10 * obj10;
			object obj11 = obj9 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			bool flag2 = (nint)obj11 <= 0;
			object obj12 = 0;
			object obj13 = 0;
			object obj14 = 0;
			if (!flag2)
			{
				obj14 = obj5 / obj11;
				obj13 = obj7 / obj11;
				obj12 = obj10 / obj11;
			}
			if ((object)transform != null)
			{
				Vector3 forward = transform.forward;
				Vector3 position = transform.position;
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v13+E4]");
				bool flag3 = (nint)0 == 0;
				object obj16 = !flag3;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj17 = obj11 * obj11;
				object obj18 = obj14 * obj14;
				object obj19 = obj17 + obj18;
				object obj20 = obj13 * obj13;
				object obj21 = obj20 + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				bool flag4 = (nint)obj21 <= 0;
				object obj22 = 0;
				object obj23 = 0;
				object obj24 = 0;
				if (!flag4)
				{
					obj24 = obj11 / obj21;
					obj23 = obj14 / obj21;
					obj22 = obj13 / obj21;
				}
				object obj25 = obj14 * obj24;
				object obj26 = obj13 * obj23;
				object obj27 = obj25 + obj26;
				object obj28 = obj12 * obj22;
				object obj29 = obj27 + obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
				object obj30 = 0;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v13+A0]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				object obj33 = obj28 * 0;
				object obj34 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v14+4]");
				object obj35 = obj34 - 0;
				bool flag5 = (nint)obj35 < 0;
				bool flag6 = obj35 == null;
				object obj36 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v14+4]");
				object obj37 = obj36 ^ 0;
				object obj38 = obj33 ^ obj35;
				object obj39 = obj37 & obj38;
				bool flag7 = (nint)obj39 < 0;
				bool flag8 = flag5 == flag7;
				object obj40 = !flag6;
				object obj41 = flag8 & obj40;
				object obj42 = ~obj41;
				if (obj42 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v14+4]");
					obj33 = 0;
				}
				if (0 >= (nint)obj33)
				{
					object obj44 = default;
					object obj43 = obj44 * obj23;
					object obj45 = obj11 * obj24;
					object obj46 = obj14 * obj23;
					object obj48 = default;
					object obj47 = obj48 * obj24;
					object obj49 = obj45 + obj46;
					object obj50 = obj47 + obj43;
					object obj52 = default;
					object obj51 = obj52 * obj22;
					object obj53 = obj13 * obj22;
					object obj54 = obj49 + obj53;
					object obj55 = obj50 + obj51;
					object obj56 = obj54 - obj55;
					object obj57 = obj56 / obj29;
					if ((nint)obj57 > 0)
					{
						object obj58 = obj14 * obj57;
						object obj59 = obj13 * obj57;
						object obj60 = obj12 * obj57;
						float num = (float)obj48 + (float)obj58;
						float num2 = (float)obj44 + (float)obj59;
						float z = (float)obj52 + (float)obj60;
						((Vector3*)(nint)dir)->x = num;
						((Vector3*)(nint)dir)->y = num2;
						((Vector3*)(nint)dir)->z = z;
						Vector3 vector = transform.InverseTransformPoint((Vector3)0);
						double num3 = (double)num + 0.5;
						double num4 = 0.5 - (double)num2;
						double num5 = num3 * 1136656384.0;
						double num6 = num4 * 1134559232.0;
						double num7 = num5 - 1136656384.0;
						bool flag9 = num7 < 0.0;
						((Vector3*)(nint)from)->x = (float)num5;
						((Vector3*)(nint)from)->y = (float)num6;
						bool flag10;
						bool flag11;
						if (!(num6 < 0.0))
						{
							flag10 = num5 < 0.0;
							object obj61 = num5 ^ num5;
							object obj62 = num5 & obj61;
							flag11 = (nint)obj62 < 0;
						}
						else
						{
							flag11 = false;
							flag10 = true;
						}
						bool flag12 = flag10 == flag11;
						double num8 = num6 - 1134559232.0;
						bool flag13 = num8 < 0.0;
						object obj63 = flag12 & flag9;
						object obj64 = !flag13;
						object obj65 = ~obj64;
						if (obj65 == null)
						{
							obj63 = 0;
						}
						reference = ref *(Vector2*)obj63;
						return true;
					}
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private LineRenderer MakeRay(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_015f: Expected F4, but got I
		//IL_0174: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		bool flag = !right;
		object obj2 = !flag;
		object obj3 = ~obj2;
		object obj4;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9288]");
			obj4 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9290]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj4);
		if ((object)board != null)
		{
			GameObject gameObject2 = board.gameObject;
			if ((object)gameObject2 != null)
			{
				int layer = gameObject2.layer;
				if ((object)gameObject != null)
				{
					gameObject.layer = layer;
					Transform transform = gameObject.transform;
					Transform parent = base.transform;
					if ((object)transform != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9298]");
						object obj5 = 0;
						transform.SetParent(parent, worldPositionStays: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						LineRenderer lineRenderer = default;
						if ((object)lineRenderer != null)
						{
							lineRenderer.useWorldSpace = true;
							lineRenderer.positionCount = 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB20]");
							lineRenderer.startWidth = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A97C]");
							lineRenderer.endWidth = 0f;
							lineRenderer.numCapVertices = 2;
							lineRenderer.shadowCastingMode = (ShadowCastingMode)0;
							lineRenderer.receiveShadows = false;
							lineRenderer.lightProbeUsage = (LightProbeUsage)0;
							Material sharedMaterial = PointerMaterial();
							lineRenderer.sharedMaterial = sharedMaterial;
							lineRenderer.enabled = false;
							return lineRenderer;
						}
					}
				}
			}
		}
		return (LineRenderer)(object)new NullReferenceException();
	}

	private Material PointerMaterial()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02de: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I
		//IL_0289: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj7;
		if (obj5 == null)
		{
			object obj6 = obj;
			obj7 = this + 216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B40]");
				object obj9 = 0;
				Shader shader = Shader.Find((string)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (shader != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Material material = default;
					material._002Ector(shader);
					if ((object)material != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92D8]");
						object obj13 = 0;
						material.name = (string)obj13;
						obj7 = material;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
						object obj14 = 0;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v25+E4]");
						bool flag6 = (nint)0 == 0;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (obj7 != null)
						{
							object obj17 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v16+A0]");
							object obj18 = 0;
							object obj19 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v17+AC]");
							((Material)obj19).SetColor(0, (Color)0);
							goto IL_028e;
						}
					}
					return (Material)(object)new NullReferenceException();
				}
			}
			goto IL_028e;
		}
		goto IL_02ec;
		IL_02ec:
		return (Material)obj3;
		IL_028e:
		obj3 = obj7;
		goto IL_02ec;
	}

	private void Accept(float now)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9180]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9268]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj = 0;
		acceptedAt = now;
		PlayerPrefs.SetInt((string)key, 2);
		PlayerPrefs.Save();
		Rays(on: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string message = string.Format((string)format, arg);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
	}

	private static Vector2 Stronger(Vector2 a, Vector2 b)
	{
		//IL_007f: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		bool flag = (nint)obj < 0;
		object obj4 = obj2 ^ obj3;
		object obj5 = obj2 ^ obj;
		object obj6 = obj4 & obj5;
		bool flag2 = (nint)obj6 < 0;
		bool flag3 = flag == flag2;
		object obj7 = !flag3;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
		}
		bool flag4 = flag == flag2;
		object obj9 = !flag4;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
		}
		return a;
	}

	private unsafe static bool AnyButton(bool pointsLeft, bool pointsRight)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0aff: Expected Obj, but got I4
		//IL_0e29: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0b3d: Expected Obj, but got I
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected VT, but got Unknown
		//IL_0b24: Expected Ref, but got VT
		//IL_00f1: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I, but got Obj
		//IL_04dc: Expected Obj, but got I4
		//IL_04e5: Expected Obj, but got I4
		//IL_0ce0: Expected Obj, but got I
		//IL_0d0b: Expected Obj, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Ref
		//IL_0253: Expected Obj, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_0e5e: Expected Obj, but got I
		//IL_0e6e: Expected Obj, but got I
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected Obj, but got I
		//IL_0df4: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I8
		//IL_02df: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I4
		//IL_0cc2: Expected Obj, but got I4
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected Obj, but got I
		//IL_09ba: Expected Obj, but got I4
		//IL_03c1: Expected VT, but got I
		//IL_03df: Expected Obj, but got I4
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0414: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got I4
		//IL_042d: Expected VT, but got I
		//IL_04a3: Expected Obj, but got I4
		//IL_04ac: Expected Obj, but got I4
		//IL_04b5: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got I4
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got I
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_047f: Expected Obj, but got VT
		//IL_0bdd: Expected Obj, but got I
		//IL_0bfa: Expected Obj, but got I
		//IL_0bfa: Expected Obj, but got I
		//IL_0c18: Expected Obj, but got I4
		//IL_0c28: Expected VT, but got I
		//IL_0c2d: Expected I, but got Obj
		//IL_0a0b: Expected Obj, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got I4
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got I
		//IL_0c86: Expected Obj, but got I4
		//IL_0c96: Expected VT, but got I
		//IL_0c9b: Expected I, but got Obj
		//IL_0a8b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v5+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v75+A0]");
				obj4 = 0;
			}
			bool? flag3 = (bool?)(object)(obj4 + 12);
			return ((bool?*)flag3)->Value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v72+A0]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v5+B0]");
		List<UnityEngine.XR.InputDevice> list = (List<UnityEngine.XR.InputDevice>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v5+B0]");
		bool flag5 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		NullReferenceException ex3;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X1_v20 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+1C]");
			object obj9 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v5+B0]");
			InputDevices.GetDevicesWithCharacteristics((InputDeviceCharacteristics)64u, (List<UnityEngine.XR.InputDevice>)0);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v10+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11+B0]");
			bool flag6 = (nint)0 == 0;
			val = (Enumerator<, >)0;
			nint num = unchecked((nint)null);
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11+B0]");
				Enumerator<, > enumerator = ((List<UnityEngine.XR.InputDevice>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
				object obj12 = 0;
				bool value = false;
				Enumerator<, > val2 = default;
				val = val2;
				num = unchecked((nint)null);
				Enumerator<, > val3 = default;
				UnityEngine.XR.InputDevice inputDevice = default;
				Enumerator<, > val4 = default;
				object obj17;
				while (true)
				{
					object obj14;
					if (val3.MoveNext())
					{
						bool isValid = inputDevice.isValid;
						bool flag7 = !isValid;
						val = val4;
						if (flag7)
						{
							continue;
						}
						InputDeviceCharacteristics characteristics = inputDevice.characteristics;
						if (pointsLeft)
						{
							object obj13 = characteristics & (InputDeviceCharacteristics)0x100u;
							if (obj13 != null)
							{
								obj14 = 1;
								list = null;
								goto IL_0b95;
							}
						}
						InputDeviceCharacteristics characteristics2 = inputDevice.characteristics;
						object obj15 = (pointsRight ? 1 : 0) & (int)characteristics2;
						obj14 = obj15 & 1;
						list = null;
						goto IL_0b95;
					}
					object obj16 = 12;
					obj17 = 0;
					bool flag8 = false;
					break;
					IL_049a:
					object obj18 = 0;
					obj16 = 11;
					obj17 = 0;
					val = val4;
					num = (nint)(&value);
					flag8 = true;
					break;
					IL_0b95:
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v91+E4]");
					bool flag9 = (nint)0 == 0;
					object obj20 = !flag9;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj19 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v91+A0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v56+B8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v56+B8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X26_v12+18]");
						bool flag10 = (nint)0 < (nint)1;
						val = val4;
						if (flag10)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X26_v12+18]");
						object obj23 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v56+B8]");
						object obj24 = (nint)0 + (nint)32;
						object obj25 = 0;
						while (true)
						{
							bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
							object obj26 = !flag11;
							if (obj26 != null)
							{
								break;
							}
							if (obj14 == null)
							{
								goto IL_03a8;
							}
							object obj27 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X0_v101+E4]");
							bool flag12 = (nint)0 == 0;
							object obj28 = !flag12;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj27 = obj12;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X0_v101+A0]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X28_v13+v507 @ X27_v14*8]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v68+30]");
							bool flag13 = (string)num2 == (string)0;
							bool flag14 = !flag13;
							object obj30 = !flag14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v68+30]");
							InputFeatureUsage<bool> inputFeatureUsage = (InputFeatureUsage<bool>)0;
							num = unchecked((nint)null);
							if (obj30 == null)
							{
								object obj31 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X0_v105+E4]");
								bool flag15 = (nint)0 == 0;
								object obj32 = !flag15;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj31 = obj12;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X0_v105+A0]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X28_v13+v507 @ X27_v14*8]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v70+28]");
								bool flag16 = (string)num3 == (string)0;
								bool flag17 = !flag16;
								object obj34 = !flag17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v70+28]");
								inputFeatureUsage = (InputFeatureUsage<bool>)0;
								num = unchecked((nint)null);
								if (obj34 == null)
								{
									goto IL_03a8;
								}
							}
							goto IL_0443;
							IL_0443:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X26_v12+18]");
							obj23 = 0;
							obj25++;
							object obj35 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X26_v12+18]");
							bool flag18 = (nint)obj35 < 0;
							list = (List<UnityEngine.XR.InputDevice>)inputFeatureUsage;
							if (flag18)
							{
								continue;
							}
							goto IL_048d;
							IL_03a8:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X28_v13+v507 @ X27_v14*8]");
							bool flag19 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out value);
							bool flag20 = !value;
							object obj36 = !flag20;
							object obj37 = flag19 & obj36;
							object obj38 = obj37 & 1;
							bool flag21 = obj38 == null;
							object obj39 = !flag21;
							obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X28_v13+v507 @ X27_v14*8]");
							inputFeatureUsage = (InputFeatureUsage<bool>)0;
							num = (nint)(&value);
							if (obj39 == null)
							{
								goto IL_0443;
							}
							goto IL_049a;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
					}
					val = val4;
					throw new NullReferenceException();
					IL_048d:
					val = val4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB8]");
				object obj40 = 0;
				list = (List<UnityEngine.XR.InputDevice>)obj40;
				val3.Dispose();
				bool flag22 = obj17 == null;
				object obj41 = !flag22;
				if (obj41 == null)
				{
					OutOfMemoryException ex2 = (OutOfMemoryException)(&val3);
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				Enumerator<, > val6;
				if ((nint)list == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					Enumerator<, > val5 = (Enumerator<, >)(ref val3);
				}
				else
				{
					bool flag23 = (nint)list != 1;
					val6 = val4;
					Enumerator<, > val5 = (Enumerator<, >)(ref val3);
					NullReferenceException ex4 = default;
					ex3 = ex4;
					if (flag23)
					{
						goto IL_0dbd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					val5 = (Enumerator<, >)(ref val3);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289ED78");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj42 = 0;
				object obj43 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X8_v46+A0]");
				object obj44 = 0;
				object obj45 = obj44;
				if (obj44 == null)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v14+1C0]");
				bool flag24 = (nint)0 == 0;
				val6 = val4;
				if (!flag24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v14+1C0]");
					bool isPressed = ((ButtonControl)0).isPressed;
					bool flag25 = !isPressed;
					object obj46 = !flag25;
					if (obj46 != null)
					{
						goto IL_0a2c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v14+1D0]");
					bool flag26 = (nint)0 == 0;
					val6 = val4;
					list = null;
					if (!flag26)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v14+1D0]");
						if (((ButtonControl)0).isPressed)
						{
							goto IL_0a2c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v14+1C8]");
						bool flag27 = (nint)0 == 0;
						val6 = val4;
						list = null;
						if (!flag27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v14+1C8]");
							return ((ButtonControl)0).isPressed;
						}
					}
				}
			}
		}
		NullReferenceException ex5 = new NullReferenceException();
		ex3 = ex5;
		goto IL_0dbd;
		IL_0a2c:
		return true;
		IL_0dbd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289ED78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
	}

	private static bool Pressed(XRController c, bool points)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_0252: Expected I4, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I8
		//IL_00d9: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_0163: Expected I, but got Obj
		//IL_01e8: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I
		//IL_02cc: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_02ff: Expected I4, but got I8
		if (c != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v6+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v6+C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v6+C0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v4+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_021a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4708]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EE0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v4+18]");
				object obj8 = 0 & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v6+C0]");
				object obj9 = (nint)0 + (nint)32;
				bool flag2 = points;
				object obj10 = 0;
				ButtonControl buttonControl = default;
				while (true)
				{
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
					object obj11 = !flag3;
					if (obj11 != null)
					{
						break;
					}
					nint num;
					if (points)
					{
						object obj12 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v18+E4]");
						bool flag4 = (nint)0 == 0;
						object obj13 = !flag4;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v18+A0]");
						object obj14 = 0;
						num = (nint)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v15+C8]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X27_v5+v135 @ X24_v6*8]");
						int num3 = Array.IndexOf((System.__Canon[])num2, (System.__Canon)0);
						int num4 = (int)(num3 & 0x80000000L);
						bool flag5 = num4 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X27_v5+v135 @ X24_v6*8]");
						flag2 = false;
						if (flag5)
						{
							goto IL_01d8;
						}
					}
					num = (nint)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
					bool flag6 = buttonControl == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X27_v5+v135 @ X24_v6*8]");
					flag2 = false;
					if (!flag6)
					{
						bool isPressed = buttonControl.isPressed;
						bool flag7 = !isPressed;
						object obj15 = !flag7;
						flag2 = false;
						if (obj15 != null)
						{
							return true;
						}
					}
					goto IL_01d8;
					IL_01d8:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v4+18]");
					obj8 = 0;
					obj10++;
					object obj16 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v4+18]");
					if ((nint)obj16 < 0)
					{
						continue;
					}
					goto IL_021a;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
		}
		goto IL_021a;
		IL_021a:
		return false;
	}

	private static bool Scrolls(Key k)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I8
		//IL_0050: Expected I4, but got Obj
		object obj = k - 33;
		bool flag = (nint)obj < 37;
		object obj2 = !flag;
		object obj3 = 132070244369L >> (int)obj;
		object obj4 = ~obj2;
		return (byte)(obj4 & obj3) != 0;
	}

	public void Preview(float since, float fraction, bool end)
	{
		//IL_000f: Invalid comparison between F4 and I4
		//IL_001e: Expected F8, but got I4
		//IL_0049: Invalid comparison between F4 and I4
		//IL_0058: Invalid comparison between F4 and I4
		//IL_0070: Expected Obj, but got F8
		//IL_007d: Expected Obj, but got F4
		//IL_00b2: Expected Obj, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		Lay();
		bool flag = fraction < 0f;
		double num = 0.0;
		if (!flag)
		{
			float num2 = fraction - 1f;
			bool flag2 = num2 < 0f;
			bool flag3 = num2 == 0f;
			object obj = (double)fraction ^ 1.0;
			object obj2 = fraction ^ num2;
			object obj3 = obj & obj2;
			bool flag4 = (nint)obj3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag5;
			object obj5 = obj4 | flag3;
			object obj6 = ~obj5;
			num = ((obj6 != null) ? 1.0 : ((double)fraction));
		}
		atEnd = end;
		acceptedAt = -1f;
		double num3 = num * (double)maxScroll;
		scroll = (float)num3;
		Look(since, -1f);
	}

	private void Look(float since, float sinceAccepted)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I4
		//IL_0060: Expected F4, but got I
		//IL_0080: Invalid comparison between F4 and I4
		//IL_008f: Expected F8, but got I4
		//IL_0815: Invalid comparison between F8 and I4
		//IL_0824: Expected F8, but got I4
		//IL_0851: Expected Obj, but got I
		//IL_085a: Invalid comparison between F4 and I4
		//IL_08c6: Invalid comparison between F4 and I4
		//IL_0122: Expected F4, but got I4
		//IL_045d: Invalid comparison between F4 and I4
		//IL_046c: Expected F8, but got I4
		//IL_04db: Expected F8, but got I4
		//IL_04f1: Expected F4, but got I4
		//IL_0b2f: Expected F4, but got I4
		//IL_0c3a: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_051d: Expected Obj, but got I
		//IL_0560: Expected Obj, but got I4
		//IL_0245: Invalid comparison between F4 and I4
		//IL_05ae: Expected I4, but got Obj
		//IL_02e5: Expected Obj, but got I4
		//IL_0635: Expected Obj, but got I4
		//IL_0361: Invalid comparison between F4 and I4
		//IL_0370: Expected F8, but got I4
		//IL_0b8e: Expected Obj, but got I
		//IL_0ba8: Expected VT, but got I4
		//IL_0bc0: Expected Obj, but got I
		//IL_0bf2: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I4
		//IL_096e: Invalid comparison between F4 and I4
		//IL_0765: Expected F8, but got I4
		//IL_0788: Expected F4, but got I4
		//IL_0672: Expected Obj, but got I
		//IL_06a3: Expected Obj, but got I
		//IL_0b44: Expected Obj, but got I
		//IL_0a10: Invalid comparison between F4 and I4
		//IL_0a1f: Expected F8, but got I4
		//IL_0297: Invalid comparison between F4 and I
		//IL_06d9: Expected Obj, but got I
		//IL_070a: Expected Obj, but got I
		//IL_0724: Expected VT, but got I4
		//IL_0a64: Expected F8, but got I
		//IL_0741: Expected Obj, but got I
		//IL_075b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Compose();
		Material material = Mat();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (material == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num = 0f;
		float num2 = since;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num3 = num2 / 0f;
		bool flag2 = num3 < 0f;
		double num4 = 0.0;
		if (!flag2)
		{
			bool flag3 = !((double)num3 > 1.0);
			num4 = num3;
			if (!flag3)
			{
				num4 = 1.0;
			}
		}
		double num5 = 1.0 - num4;
		double num6 = num5 * num5;
		double num7 = 1.0 - num6;
		bool flag4 = num7 < 0.0;
		double num8 = 0.0;
		if (!flag4)
		{
			bool flag5 = !(num7 > 1.0);
			num8 = num7;
			if (!flag5)
			{
				num8 = 1.0;
			}
		}
		double num9 = num8 * (double)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj4 = 0;
		float num10 = ((!(since < 0f)) ? since : 0f);
		double num11 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		double num12 = num11 + 0.0;
		float num13 = num10 * 2.5f;
		float num14 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		float num15 = num14 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		double num28;
		float value;
		double num34 = default;
		double num27;
		if (sinceAccepted < 0f)
		{
			if (since < num)
			{
				object obj5 = obj4;
				float num16 = since;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF84]");
				float num17 = num16 / 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v39+E4]");
				bool flag6 = (nint)0 == 0;
				object obj6 = !flag6;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num18 = since;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
				float num19 = num18 * 0f;
				float num20 = num19 + 5f;
				float num21 = num20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
				float num22 = num21 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				float num23 = num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
				float num24 = num23 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num = num24 - 5f;
				bool flag7 = num < 0f;
				double num25 = 5.0;
				if (flag7)
				{
					goto IL_02bb;
				}
				if (!((double)num > 1.0))
				{
					float num26 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					bool flag8 = !(num26 < 0f);
					num25 = 1.0;
					if (!flag8)
					{
						goto IL_02bb;
					}
				}
				num27 = 0.0;
				num9 = 1.0;
				num28 = 3.0;
				value = 0f;
			}
			else
			{
				num27 = 0.0;
				num28 = 6.0;
				value = 0f;
			}
		}
		else
		{
			float num29 = sinceAccepted;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num30 = num29 / 0f;
			bool flag9 = num30 < 0f;
			num27 = 0.0;
			if (!flag9)
			{
				bool flag10 = !((double)num30 > 1.0);
				num27 = num30;
				if (!flag10)
				{
					num27 = 1.0;
				}
			}
			double num31 = num27 * num27;
			double num32 = 1.0 - num31;
			num9 = 1.0 - num27;
			double num33 = num32 * 1.5;
			num12 *= num9;
			float num35 = default;
			num34 = ((!((double)num35 < num33)) ? num33 : ((double)num35));
			num15 = 1.5f;
			num = (float)num33;
			num28 = 3.0;
			value = 0f;
		}
		goto IL_0c10;
		IL_02bb:
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v42+E4]");
		bool flag11 = (nint)0 == 0;
		object obj8 = !flag11;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num36 = since + 13f;
		float num37 = num36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
		float num38 = num37 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num39 = num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
		float num40 = num39 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		bool flag12 = num40 < 0f;
		double num41 = 0.0;
		if (!flag12)
		{
			bool flag13 = !((double)num40 > 1.0);
			num41 = num40;
			if (!flag13)
			{
				num41 = 1.0;
			}
		}
		double num42 = num41 + num41;
		float num43 = since + 29f;
		double num44 = num42 + -1.0;
		float num45 = num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
		float num46 = num45 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num47 = num46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
		float num48 = num47 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num49 = num48 - num43;
		bool flag14 = num49 < 0f;
		double num50 = num43;
		if (!flag14)
		{
			bool flag15 = !((double)num49 > 1.0);
			num50 = 1.0;
			if (!flag15)
			{
				num50 = 1.0;
			}
		}
		double num51 = num44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num52 = num51 * 0.0;
		float num53 = since + 1.108607E+09f;
		float num54 = num53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
		float num55 = num54 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num56 = num55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
		float num57 = num56 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num58 = num57 - -1f;
		bool flag16 = num58 < 0f;
		double num59 = 0.0;
		if (!flag16)
		{
			bool flag17 = !((double)num58 > 1.0);
			num59 = num58;
			if (!flag17)
			{
				num59 = 1.0;
			}
		}
		double num60 = num52 * 1136656384.0;
		float num61 = (float)num59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		num = num61 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		num9 = 0.0;
		num27 = -1.0;
		num28 = 3.0;
		value = (float)num60;
		goto IL_0c10;
		IL_0c10:
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v9+E4]");
		bool flag18 = (nint)0 == 0;
		object obj10 = !flag18;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v9+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v10+A8]");
		Texture texture = material.GetTexture(0);
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v11+E4]");
		bool flag19 = (nint)0 == 0;
		object obj14 = !flag19;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = texture != tex;
		bool flag21 = !flag20;
		Texture texture2 = null;
		int num62 = (int)tex;
		if (!flag21)
		{
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v31+E4]");
			bool flag22 = (nint)0 == 0;
			object obj16 = !flag22;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v31+A0]");
			object obj17 = 0;
			texture2 = tex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v32+A8]");
			num62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v32+A8]");
			material.SetTexture(0, tex);
		}
		object obj18 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v19+E4]");
		bool flag23 = (nint)0 == 0;
		object obj19 = !flag23;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v19+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v14+88]");
		material.SetVector(0, (Vector4)0);
		object obj21 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v17+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v18+8C]");
		material.SetFloat(0, 0f);
		object obj23 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v19+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v20+90]");
		material.SetFloat(0, (float)num28);
		object obj25 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v21+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v22+94]");
		material.SetFloat(0, (float)num12);
		object obj27 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v23+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v24+98]");
		material.SetFloat(0, (float)num34);
		object obj29 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v25+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v26+9C]");
		material.SetFloat(0, value);
		object obj31 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v27+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v28+A0]");
		material.SetVector(0, (Vector4)0);
		object obj33 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v29+A0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v30+A4]");
		material.SetColor(0, (Color)0);
	}

	private static float Hash(float n)
	{
		//IL_0062: Invalid comparison between F4 and I4
		//IL_0071: Expected F4, but got I4
		float num = n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
		float num2 = num * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
		float num4 = num3 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
		float num6 = num5 - 0f;
		bool flag = num6 < 0f;
		float result = 0f;
		if (!flag)
		{
			bool flag2 = !((double)num6 > 1.0);
			result = num6;
			if (!flag2)
			{
				result = 1f;
			}
		}
		return result;
	}

	private Material Mat()
	{
		//IL_0010: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I4
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
		bool flag2 = board == null;
		bool flag3 = !flag2;
		Material result = null;
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!Application.isPlaying)
			{
				if ((object)board != null)
				{
					return board.sharedMaterial;
				}
				goto IL_01e7;
			}
			object obj7 = obj;
			object obj8 = this + 208;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj8 != null)
			{
				result = (Material)obj8;
			}
			else
			{
				if ((object)board == null)
				{
					goto IL_01e7;
				}
				Material material = board.material;
				obj8 = material;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = material;
			}
		}
		return result;
		IL_01e7:
		return (Material)(object)new NullReferenceException();
	}

	private unsafe void Lay()
	{
		//IL_2b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b32: Expected VT, but got Unknown
		//IL_2b51: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected VT, but got Unknown
		//IL_01f3: Expected Obj, but got I4
		//IL_03c4: Expected VT, but got I4
		//IL_03cd: Expected VT, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected VT, but got I4
		//IL_03f3: Expected VT, but got I4
		//IL_0410: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I4
		//IL_00c5: Expected I, but got Obj
		//IL_043c: Expected VT, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected I4, but got Unknown
		//IL_027c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_055a: Expected Obj, but got I
		//IL_0584: Expected Obj, but got I4
		//IL_037d: Expected native int or pointer, but got VT
		//IL_00f4: Expected VT, but got I4
		//IL_00fd: Expected VT, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected VT, but got I4
		//IL_0123: Expected VT, but got I4
		//IL_014b: Expected I, but got Obj
		//IL_0533: Expected Obj, but got I
		//IL_02b4: Expected VT, but got I4
		//IL_02bd: Expected VT, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected VT, but got I4
		//IL_02e3: Expected VT, but got I4
		//IL_0678: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_2b7e: Expected VT, but got I4
		//IL_2b87: Expected VT, but got I4
		//IL_2b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9b: Expected VT, but got I4
		//IL_2bad: Expected VT, but got I4
		//IL_05ef: Expected VT, but got I4
		//IL_05f8: Expected VT, but got I4
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected VT, but got I4
		//IL_061e: Expected VT, but got I4
		//IL_033b: Expected Obj, but got I
		//IL_01a5: Expected I, but got Obj
		//IL_0367: Expected I, but got Obj
		//IL_06c0: Expected VT, but got I4
		//IL_06c9: Expected VT, but got I4
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected VT, but got I4
		//IL_06ef: Expected VT, but got I4
		//IL_0717: Expected Obj, but got I4
		//IL_0737: Expected Obj, but got I4
		//IL_0753: Expected Obj, but got I4
		//IL_0763: Expected Obj, but got I4
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected I4, but got Unknown
		//IL_1be2: Expected VT, but got I4
		//IL_1bf4: Expected VT, but got I4
		//IL_1c02: Expected VT, but got I4
		//IL_1c14: Expected I4, but got Obj
		//IL_3105: Unknown result type (might be due to invalid IL or missing references)
		//IL_310a: Expected I4, but got Unknown
		//IL_3113: Unknown result type (might be due to invalid IL or missing references)
		//IL_3118: Expected Obj, but got Unknown
		//IL_3128: Expected Obj, but got I
		//IL_3135: Expected VT, but got I4
		//IL_314b: Expected VT, but got Obj
		//IL_3159: Expected Obj, but got VT
		//IL_3163: Expected I4, but got VT
		//IL_3195: Expected I, but got Obj
		//IL_31b1: Expected VT, but got I4
		//IL_31ba: Expected VT, but got I4
		//IL_31c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected VT, but got I
		//IL_0809: Expected Obj, but got Ref
		//IL_0817: Expected VT, but got I4
		//IL_0829: Expected VT, but got I4
		//IL_0837: Expected VT, but got I4
		//IL_0840: Expected Obj, but got I4
		//IL_0850: Expected VT, but got Ref
		//IL_085a: Expected I4, but got Obj
		//IL_3055: Expected Obj, but got I4
		//IL_308d: Expected I4, but got Obj
		//IL_309a: Expected I4, but got Obj
		//IL_30c1: Expected VT, but got I4
		//IL_30ca: Expected VT, but got I4
		//IL_30d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3a: Expected Obj, but got I
		//IL_3328: Expected Obj, but got I
		//IL_3349: Expected Obj, but got I4
		//IL_3359: Unknown result type (might be due to invalid IL or missing references)
		//IL_335e: Expected Obj, but got Unknown
		//IL_338c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3391: Expected I4, but got Unknown
		//IL_339e: Expected I4, but got Obj
		//IL_0893: Expected Obj, but got I
		//IL_08a3: Expected Obj, but got I
		//IL_08bd: Expected Obj, but got I
		//IL_08cd: Expected VT, but got Obj
		//IL_08df: Expected I4, but got Obj
		//IL_091b: Expected VT, but got I4
		//IL_0924: Expected VT, but got I4
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got I4
		//IL_1d99: Expected VT, but got I4
		//IL_1da2: Expected VT, but got I4
		//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2203: Unknown result type (might be due to invalid IL or missing references)
		//IL_2208: Expected VT, but got Unknown
		//IL_2215: Expected I4, but got Obj
		//IL_2210: Expected native int or pointer, but got VT
		//IL_1c5c: Expected VT, but got I
		//IL_1c7e: Expected Obj, but got I4
		//IL_0974: Expected Obj, but got I
		//IL_0992: Expected VT, but got I4
		//IL_099b: Expected VT, but got I4
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df0: Expected VT, but got I4
		//IL_1df9: Expected VT, but got I4
		//IL_1e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_3261: Expected Obj, but got I4
		//IL_3299: Expected I4, but got Obj
		//IL_32a6: Expected I4, but got Obj
		//IL_32cd: Expected VT, but got I4
		//IL_32d6: Expected VT, but got I4
		//IL_32dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_330a: Expected I4, but got Obj
		//IL_1ca6: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I
		//IL_0a19: Expected Obj, but got I4
		//IL_0a32: Expected I4, but got Obj
		//IL_1e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e63: Expected Obj, but got I
		//IL_1e6e: Expected VT, but got I4
		//IL_1e77: Expected VT, but got I4
		//IL_1e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc0: Expected VT, but got Unknown
		//IL_1cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cce: Expected Obj, but got Unknown
		//IL_1cde: Expected Obj, but got I
		//IL_1d17: Expected Obj, but got I4
		//IL_1a1d: Expected Obj, but got I4
		//IL_1a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2b: Expected Obj, but got Unknown
		//IL_1a46: Expected Obj, but got I4
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a55: Expected Obj, but got Unknown
		//IL_1a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a82: Expected I4, but got Unknown
		//IL_1a8f: Expected I4, but got Obj
		//IL_3556: Expected Obj, but got I
		//IL_3577: Expected Obj, but got I4
		//IL_3587: Unknown result type (might be due to invalid IL or missing references)
		//IL_358c: Expected Obj, but got Unknown
		//IL_35ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_35bf: Expected I4, but got Unknown
		//IL_35cc: Expected I4, but got Obj
		//IL_208e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2092: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a4: Expected VT, but got I4
		//IL_20a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b5: Expected VT, but got I4
		//IL_20d2: Expected VT, but got Ref
		//IL_20da: Expected Obj, but got Ref
		//IL_20e3: Expected Obj, but got I4
		//IL_1d30: Expected VT, but got I4
		//IL_1d39: Expected VT, but got I4
		//IL_1d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Expected VT, but got Unknown
		//IL_0e2b: Expected I4, but got Obj
		//IL_36d8: Expected Obj, but got I4
		//IL_36fa: Expected Obj, but got I4
		//IL_229a: Expected VT, but got I
		//IL_22bc: Expected Obj, but got I4
		//IL_3aad: Expected Obj, but got I
		//IL_3ab5: Expected I4, but got Obj
		//IL_3ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3abe: Expected Ref, but got Unknown
		//IL_3ace: Expected Obj, but got I
		//IL_3ae8: Expected Obj, but got I4
		//IL_3ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af0: Expected VT, but got Unknown
		//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ead: Expected Obj, but got Unknown
		//IL_1ec7: Expected Obj, but got I4
		//IL_0a72: Expected Obj, but got I
		//IL_3647: Expected Obj, but got I
		//IL_3657: Expected VT, but got I
		//IL_367a: Expected VT, but got I
		//IL_36b5: Expected Obj, but got I4
		//IL_34bf: Expected Obj, but got I4
		//IL_34f7: Expected I4, but got Obj
		//IL_3504: Expected I4, but got Obj
		//IL_3530: Expected I4, but got Obj
		//IL_2a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4e: Expected Obj, but got I4
		//IL_0e40: Expected Obj, but got I
		//IL_22e4: Expected Obj, but got I
		//IL_20f1: Invalid comparison between VT and I4
		//IL_2102: Expected Obj, but got I4
		//IL_2102: Unknown result type (might be due to invalid IL or missing references)
		//IL_210a: Expected VT, but got Unknown
		//IL_210a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2112: Expected Obj, but got Unknown
		//IL_343e: Expected Obj, but got I
		//IL_345c: Expected Obj, but got Ref
		//IL_3477: Expected VT, but got I
		//IL_1eff: Expected Obj, but got I4
		//IL_0ac6: Expected VT, but got I4
		//IL_0acf: Expected VT, but got I4
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d0: Expected VT, but got I
		//IL_23f1: Expected Obj, but got I4
		//IL_22f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fe: Expected VT, but got Unknown
		//IL_2307: Unknown result type (might be due to invalid IL or missing references)
		//IL_230c: Expected Obj, but got Unknown
		//IL_231c: Expected Obj, but got I
		//IL_2355: Expected Obj, but got I4
		//IL_1f8e: Expected VT, but got I4
		//IL_1f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fac: Expected VT, but got I4
		//IL_1fb5: Expected VT, but got I4
		//IL_1fbe: Expected VT, but got I4
		//IL_1fde: Expected VT, but got Ref
		//IL_1fee: Expected Obj, but got Ref
		//IL_33f1: Expected Obj, but got I
		//IL_340f: Expected Obj, but got Ref
		//IL_3429: Expected VT, but got I
		//IL_2c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c91: Expected I4, but got Unknown
		//IL_2cbd: Expected VT, but got I4
		//IL_2cc6: Expected VT, but got I4
		//IL_2ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd9: Expected Obj, but got I4
		//IL_0e9a: Expected VT, but got I4
		//IL_0ea3: Expected VT, but got I4
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got I4
		//IL_0ee9: Expected Obj, but got I4
		//IL_213a: Expected Obj, but got I4
		//IL_2143: Unknown result type (might be due to invalid IL or missing references)
		//IL_2148: Expected Obj, but got Unknown
		//IL_216f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2174: Expected I4, but got Unknown
		//IL_2181: Expected I4, but got Obj
		//IL_21a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ad: Expected VT, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected VT, but got Unknown
		//IL_0b54: Expected Obj, but got I4
		//IL_0b6a: Expected Obj, but got I
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb3: Expected I4, but got Unknown
		//IL_0bf3: Expected Obj, but got I4
		//IL_2433: Expected Obj, but got I4
		//IL_2443: Expected Obj, but got I
		//IL_2453: Expected VT, but got I
		//IL_2478: Expected Obj, but got I
		//IL_24a0: Expected VT, but got I
		//IL_24a0: Expected Obj, but got I4
		//IL_24b8: Expected Obj, but got I
		//IL_24c8: Expected VT, but got I
		//IL_24f0: Expected VT, but got I
		//IL_24f0: Expected Obj, but got I4
		//IL_2026: Expected Obj, but got I4
		//IL_2026: Expected I4, but got VT
		//IL_2026: Expected I4, but got Obj
		//IL_2033: Expected Obj, but got I4
		//IL_203b: Expected I4, but got VT
		//IL_2043: Expected VT, but got Obj
		//IL_204b: Expected Obj, but got Ref
		//IL_2055: Expected VT, but got I4
		//IL_2062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f63: Expected I, but got Obj
		//IL_0f73: Expected VT, but got I
		//IL_0f83: Expected VT, but got I
		//IL_0f14: Expected Obj, but got I
		//IL_0c16: Expected I4, but got VT
		//IL_251d: Expected Obj, but got I4
		//IL_252b: Expected Obj, but got I4
		//IL_255f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2564: Expected I4, but got Unknown
		//IL_25ac: Expected Obj, but got I4
		//IL_21d5: Expected Obj, but got I4
		//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e5: Expected VT, but got Unknown
		//IL_0f37: Expected Obj, but got I4
		//IL_2c05: Expected VT, but got I4
		//IL_2c0e: Expected VT, but got I4
		//IL_2c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c22: Expected Obj, but got I4
		//IL_2c33: Expected VT, but got I4
		//IL_2c75: Expected Obj, but got I4
		//IL_0c09: Expected I4, but got VT
		//IL_2d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbe: Expected VT, but got I
		//IL_2ac3: Expected VT, but got I4
		//IL_171c: Expected VT, but got I4
		//IL_1725: Expected VT, but got I4
		//IL_172c: Unknown result type (might be due to invalid IL or missing references)
		//IL_173e: Expected VT, but got I4
		//IL_2d20: Expected Obj, but got I
		//IL_380a: Expected Obj, but got I4
		//IL_2b22: Expected Obj, but got I4
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected Obj, but got Unknown
		//IL_10f7: Expected VT, but got I4
		//IL_1109: Expected Obj, but got I
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_1117: Expected Obj, but got Unknown
		//IL_0c3f: Expected VT, but got I
		//IL_0c4f: Expected Obj, but got I
		//IL_0c65: Expected VT, but got I
		//IL_0c8c: Expected VT, but got I4
		//IL_0c95: Expected VT, but got I4
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected Obj, but got I4
		//IL_0cba: Expected VT, but got I4
		//IL_3718: Expected Obj, but got I
		//IL_3740: Expected VT, but got I
		//IL_3740: Expected Obj, but got I4
		//IL_3758: Expected Obj, but got I
		//IL_3768: Expected VT, but got I
		//IL_3790: Expected VT, but got I
		//IL_3790: Expected Obj, but got I4
		//IL_2f03: Expected I, but got Obj
		//IL_2f13: Expected VT, but got I
		//IL_0fe1: Expected VT, but got I
		//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Expected VT, but got Unknown
		//IL_0ff8: Invalid comparison between VT and I4
		//IL_0d1c: Expected VT, but got I
		//IL_0d2c: Expected Obj, but got I
		//IL_0d55: Expected Obj, but got I4
		//IL_2632: Expected Obj, but got I4
		//IL_2dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df1: Expected Obj, but got Unknown
		//IL_11ae: Expected VT, but got I
		//IL_1047: Expected Obj, but got I
		//IL_104f: Expected Obj, but got Ref
		//IL_1057: Expected VT, but got Obj
		//IL_1067: Expected Obj, but got I
		//IL_1086: Expected VT, but got Ref
		//IL_108f: Expected VT, but got I4
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected VT, but got I4
		//IL_321f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3223: Unknown result type (might be due to invalid IL or missing references)
		//IL_322b: Expected Obj, but got Unknown
		//IL_322b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3234: Invalid comparison between Unknown and I4
		//IL_2da0: Expected Obj, but got I
		//IL_10bb: Expected VT, but got I4
		//IL_10c4: Expected Obj, but got I4
		//IL_10d5: Expected VT, but got I4
		//IL_0d6b: Expected Obj, but got Ref
		//IL_0d81: Expected Obj, but got I
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Expected Obj, but got Unknown
		//IL_0dac: Expected VT, but got I
		//IL_0db4: Expected VT, but got Obj
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc7: Expected Obj, but got Unknown
		//IL_0de4: Expected Obj, but got Ref
		//IL_0ded: Expected VT, but got I4
		//IL_266a: Expected Obj, but got I4
		//IL_2f4b: Expected VT, but got I4
		//IL_2f54: Expected VT, but got I4
		//IL_2f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7d: Expected VT, but got I4
		//IL_1234: Expected VT, but got I4
		//IL_1246: Expected Obj, but got I
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected Obj, but got Unknown
		//IL_3a78: Expected Obj, but got I4
		//IL_26e3: Expected Obj, but got I4
		//IL_3828: Expected Obj, but got I
		//IL_3836: Expected Obj, but got Ref
		//IL_3852: Expected VT, but got I
		//IL_3860: Expected Obj, but got I4
		//IL_3893: Expected Obj, but got I4
		//IL_3893: Expected Obj, but got I4
		//IL_38b2: Expected Obj, but got Ref
		//IL_38bf: Expected VT, but got I8
		//IL_38c8: Expected VT, but got I4
		//IL_38e7: Expected Obj, but got I4
		//IL_177c: Expected VT, but got I
		//IL_178c: Expected VT, but got I
		//IL_1b6c: Expected VT, but got I4
		//IL_1b75: Expected VT, but got I4
		//IL_1b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8e: Expected VT, but got I4
		//IL_1b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d1: Expected VT, but got I
		//IL_11da: Unknown result type (might be due to invalid IL or missing references)
		//IL_11df: Expected VT, but got Unknown
		//IL_11e8: Invalid comparison between VT and I4
		//IL_39cd: Expected Obj, but got I
		//IL_39f5: Expected VT, but got I
		//IL_39f5: Expected Obj, but got I4
		//IL_3a40: Expected Obj, but got I4
		//IL_38fc: Expected Obj, but got I
		//IL_390a: Expected Obj, but got Ref
		//IL_3924: Expected Obj, but got I
		//IL_395f: Expected Obj, but got I4
		//IL_395f: Expected Obj, but got I4
		//IL_397e: Expected Obj, but got Ref
		//IL_3987: Expected VT, but got I4
		//IL_3990: Expected VT, but got I4
		//IL_39a2: Expected VT, but got I4
		//IL_39b8: Expected Obj, but got I4
		//IL_1296: Expected I, but got Obj
		//IL_12a6: Expected Obj, but got I
		//IL_12b6: Expected VT, but got I
		//IL_17c7: Expected VT, but got I
		//IL_2755: Expected Obj, but got I4
		//IL_2763: Expected Obj, but got I4
		//IL_2797: Unknown result type (might be due to invalid IL or missing references)
		//IL_279c: Expected I4, but got Unknown
		//IL_27f3: Expected Obj, but got I4
		//IL_2ff4: Expected Obj, but got I
		//IL_12f1: Expected VT, but got I
		//IL_183d: Expected VT, but got I4
		//IL_184a: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Expected Obj, but got Unknown
		//IL_1858: Unknown result type (might be due to invalid IL or missing references)
		//IL_185d: Expected Obj, but got Unknown
		//IL_141f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Expected Obj, but got Unknown
		//IL_142f: Expected Obj, but got I4
		//IL_2e1e: Expected Obj, but got I
		//IL_2819: Expected Obj, but got I
		//IL_281f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2824: Expected I, but got Unknown
		//IL_284e: Expected Obj, but got I4
		//IL_17e2: Expected VT, but got I
		//IL_17eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f0: Expected VT, but got Unknown
		//IL_17f9: Invalid comparison between VT and I4
		//IL_1453: Expected Obj, but got Ref
		//IL_1374: Expected Obj, but got I
		//IL_137d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1382: Expected Obj, but got Unknown
		//IL_2875: Expected Obj, but got I
		//IL_28a9: Expected Obj, but got I4
		//IL_2ed0: Expected Obj, but got I4
		//IL_1482: Expected Obj, but got Ref
		//IL_1307: Unknown result type (might be due to invalid IL or missing references)
		//IL_130c: Expected Obj, but got Unknown
		//IL_1315: Unknown result type (might be due to invalid IL or missing references)
		//IL_131a: Expected VT, but got Unknown
		//IL_29e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e6: Expected Obj, but got Unknown
		//IL_2e9c: Expected Obj, but got I4
		//IL_2ea5: Expected Obj, but got I4
		//IL_2ead: Expected I4, but got Obj
		//IL_13d2: Expected Obj, but got I
		//IL_2a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a08: Expected Obj, but got Unknown
		//IL_2a11: Expected Obj, but got I4
		//IL_28c7: Expected Obj, but got I
		//IL_2eee: Expected Obj, but got Ref
		//IL_2ef6: Expected I4, but got Obj
		//IL_3b06: Expected Obj, but got I4
		//IL_3b29: Expected VT, but got Obj
		//IL_2914: Expected VT, but got I4
		//IL_292f: Expected Obj, but got I4
		//IL_1aea: Expected VT, but got I4
		//IL_1af3: Expected VT, but got I4
		//IL_1afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0c: Expected VT, but got I4
		//IL_1b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1d: Expected VT, but got I4
		//IL_1497: Expected Obj, but got I
		//IL_149f: Expected VT, but got I
		//IL_14b5: Expected VT, but got I
		//IL_2984: Expected Obj, but got I
		//IL_14ef: Expected VT, but got I
		//IL_14ff: Expected Obj, but got I
		//IL_1528: Expected Obj, but got I4
		//IL_299e: Expected I, but got Obj
		//IL_29cc: Expected Obj, but got I4
		//IL_15de: Expected Obj, but got I
		//IL_15e6: Expected Obj, but got Ref
		//IL_15ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Expected Obj, but got I
		//IL_161d: Expected VT, but got Ref
		//IL_1626: Expected VT, but got I4
		//IL_162a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1637: Expected VT, but got I4
		//IL_164d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1652: Expected VT, but got Unknown
		//IL_166c: Expected Obj, but got I4
		//IL_1684: Expected I4, but got VT
		//IL_168d: Expected VT, but got I4
		//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b3: Expected VT, but got Unknown
		//IL_16cb: Expected I4, but got VT
		//IL_16d4: Expected VT, but got I4
		//IL_153e: Expected Obj, but got Ref
		//IL_1554: Expected Obj, but got I
		//IL_1564: Unknown result type (might be due to invalid IL or missing references)
		//IL_1569: Expected Obj, but got Unknown
		//IL_157f: Expected VT, but got I
		//IL_1583: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a5: Expected Obj, but got Unknown
		//IL_15b7: Expected Obj, but got Ref
		//IL_15c0: Expected VT, but got I4
		ShiftAuth.Style style = (ShiftAuth.Style)(this + 184);
		bool flag = style.scale == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Texture2D texture2D = (Texture2D)(this + 192);
		bool flag2 = (object)texture2D == null;
		object obj2 = !flag2;
		nint num = 109891584;
		IEnumerable<string> enumerable;
		ShiftAuth.Style s;
		Enumerator<, > val;
		int num2;
		nint num3 = default;
		ShiftAuth.Style style4;
		string text;
		UnityEngine.Object obj6;
		ShiftAuth.Style style2;
		ShiftAuth.Style style3;
		ShiftAuth.Style style5;
		StringSplitOptions stringSplitOptions;
		Texture2D texture2D2;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v233+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = titleFont != null;
			bool flag5 = !flag4;
			stringSplitOptions = (StringSplitOptions)0;
			num = unchecked((nint)null);
			if (!flag5)
			{
				bool flag6 = (object)titleFont == null;
				enumerable = null;
				style2 = (ShiftAuth.Style)0;
				s = (ShiftAuth.Style)0;
				val = (Enumerator<, >)0;
				style3 = (ShiftAuth.Style)0;
				num2 = 0;
				style4 = (ShiftAuth.Style)0;
				text = null;
				style5 = style;
				stringSplitOptions = (StringSplitOptions)0;
				obj6 = null;
				texture2D2 = texture2D;
				num = unchecked((nint)null);
				if (flag6)
				{
					goto IL_2390;
				}
				string baked = titleFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont = default;
				screenFont._002Ector(baked);
				stringSplitOptions = (StringSplitOptions)0;
				num = (nint)screenFont;
			}
			texture2D = (Texture2D)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num3 = num;
		}
		ShiftAuth.Style style6 = (ShiftAuth.Style)(this + 200);
		bool flag7 = style6.scale == 0;
		object obj8 = !flag7;
		ShiftAuth.Style style7;
		Color32[] array;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v221+E4]");
			bool flag8 = (nint)0 == 0;
			object obj11 = !flag8;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = textFont != null;
			bool flag10 = !flag9;
			nint num4 = unchecked((nint)null);
			stringSplitOptions = (StringSplitOptions)0;
			if (!flag10)
			{
				bool flag11 = (object)textFont == null;
				enumerable = null;
				style2 = (ShiftAuth.Style)0;
				s = (ShiftAuth.Style)0;
				val = (Enumerator<, >)0;
				style3 = (ShiftAuth.Style)0;
				num2 = 0;
				style4 = (ShiftAuth.Style)0;
				text = null;
				style7 = style6;
				style5 = style6;
				stringSplitOptions = (StringSplitOptions)0;
				obj6 = null;
				texture2D2 = texture2D;
				if (flag11)
				{
					goto IL_2390;
				}
				string text2 = textFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont2 = default;
				screenFont2._002Ector(text2);
				array = (Color32[])(object)text2;
				num4 = (nint)screenFont2;
				stringSplitOptions = (StringSplitOptions)0;
			}
			((ShiftAuth.Style*)(nint)style6)->scale = (int)num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num3 = num4;
		}
		List<Row> list = rows;
		bool flag12 = rows == null;
		enumerable = null;
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		style3 = (ShiftAuth.Style)0;
		num2 = 0;
		style4 = (ShiftAuth.Style)0;
		text = null;
		style7 = style6;
		style5 = style6;
		obj6 = (UnityEngine.Object)num3;
		texture2D2 = texture2D;
		string[] array2;
		object obj20;
		string text5;
		Enumerator<, > val2 = default;
		ShiftAuth.Style style12;
		string[] array5 = default;
		object obj30 = default;
		object obj28 = default;
		string text6;
		bool flag17;
		string text4;
		ShiftAuth.Style style10;
		ShiftAuth.Style style8;
		string[] array3;
		int num12;
		ShiftAuth.Style style11 = default;
		Texture2D texture2D3;
		int num10;
		int num11;
		ShiftAuth.Style style9;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+1C]");
			style5 = (ShiftAuth.Style)((nint)0 + (nint)1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
			bool flag13 = (nint)0 < (nint)1;
			object obj13 = !flag13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
			object obj14 = -1;
			bool flag14 = (nint)obj14 < 0;
			bool flag15 = obj14 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
			int num5 = (int)((nint)0 ^ (nint)1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
			int num6 = 0 ^ obj14;
			int num7 = num5 & num6;
			bool flag16 = num7 < 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
			flag17 = (nint)0 < (nint)1;
			int num8 = (int)num3;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+10]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v72 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
				Array.Clear((Array)num9, 0, 0);
				num10 = 0;
				num8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v107+E4]");
			bool flag18 = (nint)0 == 0;
			object obj17 = !flag18;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3;
			if (terms != null)
			{
				bool flag19 = (object)terms == null;
				enumerable = null;
				style2 = (ShiftAuth.Style)0;
				s = (ShiftAuth.Style)0;
				val = (Enumerator<, >)0;
				style3 = (ShiftAuth.Style)0;
				num2 = 0;
				style4 = (ShiftAuth.Style)0;
				text = null;
				style7 = style6;
				stringSplitOptions = (StringSplitOptions)0;
				obj6 = null;
				texture2D2 = texture2D;
				if (flag19)
				{
					goto IL_2390;
				}
				text3 = terms.text;
				obj6 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9200]");
				object obj18 = 0;
				text3 = (string)obj18;
				obj6 = null;
			}
			bool flag20 = text3 == null;
			enumerable = null;
			style2 = (ShiftAuth.Style)0;
			s = (ShiftAuth.Style)0;
			val = (Enumerator<, >)0;
			style3 = (ShiftAuth.Style)0;
			num2 = 0;
			style4 = (ShiftAuth.Style)0;
			text = null;
			style7 = style6;
			stringSplitOptions = (StringSplitOptions)0;
			texture2D2 = texture2D;
			if (!flag20)
			{
				array2 = text3.Split('\n', (StringSplitOptions)0);
				bool flag21 = array2 == null;
				enumerable = null;
				style2 = (ShiftAuth.Style)0;
				s = (ShiftAuth.Style)0;
				val = (Enumerator<, >)0;
				style3 = (ShiftAuth.Style)0;
				num2 = 0;
				style4 = (ShiftAuth.Style)0;
				text = null;
				num10 = 0;
				style7 = style6;
				stringSplitOptions = (StringSplitOptions)0;
				obj6 = (UnityEngine.Object)10;
				texture2D2 = texture2D;
				if (!flag21)
				{
					object obj19 = array2.Length;
					bool flag22 = array2.Length < 1;
					obj13 = !flag22;
					obj14 = array2.Length - 1;
					flag14 = (nint)obj14 < 0;
					flag15 = obj14 == null;
					num5 = array2.Length ^ 1;
					num6 = array2.Length ^ obj14;
					num7 = num5 & num6;
					flag16 = num7 < 0;
					flag17 = array2.Length < 1;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91C8]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
						style8 = (ShiftAuth.Style)0;
						array = (Color32[])System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num2, 2));
						enumerable = null;
						style3 = (ShiftAuth.Style)0;
						num2 = 0;
						style4 = (ShiftAuth.Style)0;
						text = null;
						style9 = (ShiftAuth.Style)6;
						obj20 = 0;
						array3 = array2;
						style5 = (ShiftAuth.Style)(&num2);
						num11 = (int)terms;
						stringSplitOptions = (StringSplitOptions)0;
						num12 = 10;
						texture2D2 = null;
						char[] array4 = default;
						while (true)
						{
							bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
							obj13 = !flag23;
							obj14 = obj20 - obj19;
							flag14 = (nint)obj14 < 0;
							flag15 = obj14 == null;
							num5 = obj20 ^ obj19;
							num6 = obj20 ^ obj14;
							num7 = num5 & num6;
							flag16 = num7 < 0;
							style2 = (ShiftAuth.Style)0;
							s = (ShiftAuth.Style)0;
							val = (Enumerator<, >)0;
							texture2D3 = texture2D;
							num10 = 0;
							style7 = style6;
							if (obj13 != null)
							{
								break;
							}
							object obj21 = (object)array3 + obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v101+20]");
							text4 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91E0]");
							object obj23 = 0;
							object obj24 = obj23;
							style5 = (ShiftAuth.Style)obj24;
							array4[0] = (char)(int)obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X8_v106+4]");
							array4[2] = '\0';
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v101+20]");
							bool flag24 = (nint)0 == 0;
							style2 = (ShiftAuth.Style)0;
							s = (ShiftAuth.Style)0;
							val = (Enumerator<, >)0;
							texture2D3 = texture2D;
							num10 = 0;
							style7 = style6;
							obj6 = (UnityEngine.Object)3;
							if (!flag24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v101+20]");
								text5 = ((string)0).TrimEnd(array4);
								bool flag25 = text5 == null;
								style2 = (ShiftAuth.Style)0;
								s = (ShiftAuth.Style)0;
								val = (Enumerator<, >)0;
								texture2D3 = texture2D;
								num10 = 0;
								style7 = style6;
								stringSplitOptions = (StringSplitOptions)0;
								obj6 = (UnityEngine.Object)(object)array4;
								if (!flag25)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91E8]");
									object obj25 = 0;
									bool flag26 = text5.StartsWith((string)obj25);
									bool flag27 = !flag26;
									object obj26 = !flag27;
									text6 = text5;
									stringSplitOptions = (StringSplitOptions)0;
									num12 = (int)obj25;
									if (obj26 == null)
									{
										if (text5._stringLength != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9210]");
											object obj27 = 0;
											if (!text5.StartsWith((string)obj27))
											{
												goto IL_0e30;
											}
											List<Row> list2 = rows;
											bool flag28 = rows == null;
											style2 = (ShiftAuth.Style)0;
											s = (ShiftAuth.Style)0;
											val = (Enumerator<, >)0;
											text6 = text5;
											text4 = (string)(object)rows;
											texture2D3 = texture2D;
											num10 = 0;
											style7 = style6;
											stringSplitOptions = (StringSplitOptions)0;
											obj6 = (UnityEngine.Object)obj27;
											if (!flag28)
											{
												style5 = (ShiftAuth.Style)(style9 + 6);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
												bool flag29 = (nint)0 < (nint)1;
												obj13 = !flag29;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
												obj14 = -1;
												flag14 = (nint)obj14 < 0;
												flag15 = obj14 == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
												num5 = (int)((nint)0 ^ (nint)1);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
												num6 = 0 ^ obj14;
												num7 = num5 & num6;
												flag16 = num7 < 0;
												bool flag30 = flag14 == flag16;
												flag17 = !flag30;
												obj28 = !flag17;
												num11 = ((obj28 != null) ? ((int)style5) : ((int)style9));
												string text7 = text5.Substring(2);
												bool flag31 = text7 == null;
												style2 = (ShiftAuth.Style)0;
												s = (ShiftAuth.Style)0;
												val = (Enumerator<, >)0;
												array5 = (string[])10;
												num2 = num11;
												style4 = (ShiftAuth.Style)0;
												text = null;
												text6 = text5;
												text4 = (string)(object)rows;
												texture2D3 = texture2D;
												num10 = 0;
												style7 = style6;
												stringSplitOptions = (StringSplitOptions)0;
												obj6 = (UnityEngine.Object)2;
												if (!flag31)
												{
													string text8 = text7.Trim();
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													style5 = (ShiftAuth.Style)num;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+10]");
													object obj29 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+1C]");
													style10 = (ShiftAuth.Style)((nint)0 + (nint)1);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+10]");
													bool flag32 = (nint)0 == 0;
													style2 = (ShiftAuth.Style)0;
													s = (ShiftAuth.Style)0;
													val = (Enumerator<, >)0;
													array5 = (string[])10;
													num2 = num11;
													style4 = (ShiftAuth.Style)1;
													text = text8;
													text6 = text5;
													text4 = (string)(object)rows;
													texture2D3 = texture2D;
													num10 = 0;
													style7 = style6;
													stringSplitOptions = (StringSplitOptions)0;
													obj6 = (UnityEngine.Object)(object)text8;
													if (!flag32)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
														style10 = (ShiftAuth.Style)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v158+18]");
														obj30 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
														nint num13 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v158+18]");
														bool flag33 = num13 < 0;
														object obj31 = !flag33;
														if (obj31 == null)
														{
															object obj32 = (object)(&num2);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
															object obj33 = (nint)0 * (nint)24;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+10]");
															object obj34 = 0 + obj33;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X25_v28 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
															style5 = (ShiftAuth.Style)((nint)0 + (nint)1);
															style3 = (ShiftAuth.Style)obj32;
															object obj35 = obj34 + 40;
															_ = 1;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															obj30 = (object)(&num2);
															style10 = (ShiftAuth.Style)1;
															stringSplitOptions = (StringSplitOptions)0;
															num12 = 0;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ X9_v5 (ShiftAuth+Style)+20]");
															object obj36 = 0;
															object obj37 = (object)(&num2);
															style3 = (ShiftAuth.Style)obj37;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2174 @ X8_v160+A8]");
															object obj38 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v161+70]");
															stringSplitOptions = (StringSplitOptions)0;
															rows.AddWithResize((Row)(&val2));
															style11 = (ShiftAuth.Style)1;
															val2 = (Enumerator<, >)obj37;
															style5 = (ShiftAuth.Style)1;
															num12 = (int)(&val2);
														}
														style9 = (ShiftAuth.Style)(num11 + 12);
														array5 = (string[])10;
														num2 = num11;
														style4 = (ShiftAuth.Style)1;
														text = text8;
														text6 = text5;
														goto IL_1a13;
													}
												}
											}
											goto IL_2390;
										}
										style9 = (ShiftAuth.Style)(style9 + 5);
										text6 = text5;
										stringSplitOptions = (StringSplitOptions)0;
										num12 = (int)obj25;
									}
									goto IL_1a13;
								}
							}
							goto IL_2390;
							IL_1a13:
							obj19 = array3.Length;
							obj20++;
							bool flag34 = (nint)obj20 < array3.Length;
							obj13 = !flag34;
							obj14 = obj20 - array3.Length;
							flag14 = (nint)obj14 < 0;
							flag15 = obj14 == null;
							num5 = obj20 ^ array3.Length;
							num6 = obj20 ^ obj14;
							num7 = num5 & num6;
							flag16 = num7 < 0;
							flag17 = (nint)obj20 < array3.Length;
							if (flag17)
							{
								continue;
							}
							goto IL_1ac9;
						}
						goto IL_2a21;
					}
					enumerable = null;
					style12 = style11;
					style3 = (ShiftAuth.Style)0;
					num2 = 0;
					style4 = (ShiftAuth.Style)0;
					text = null;
					style9 = (ShiftAuth.Style)6;
					array3 = array2;
					num11 = (int)terms;
					stringSplitOptions = (StringSplitOptions)0;
					texture2D2 = texture2D;
					goto IL_30fc;
				}
			}
		}
		goto IL_2390;
		IL_2f38:
		IEnumerable<string> enumerable2 = default;
		enumerable = enumerable2;
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		NullReferenceException ex = null;
		ShiftAuth.Style style14;
		ShiftAuth.Style style13 = style14;
		string[] array6;
		array5 = array6;
		style11 = (ShiftAuth.Style)0;
		object obj39;
		obj30 = obj39;
		ShiftAuth.Style style15;
		style10 = style15;
		object obj40;
		obj28 = obj40;
		ShiftAuth.Style style16;
		style4 = style16;
		string text9;
		text = text9;
		ShiftAuth.Style style17;
		style9 = style17;
		texture2D3 = texture2D;
		array3 = array2;
		num10 = 0;
		style7 = style6;
		num11 = 13;
		Texture2D texture2D4;
		texture2D2 = texture2D4;
		goto IL_2a4c;
		IL_2a2f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_2a3d;
		IL_1ad6:
		NullReferenceException ex3 = new NullReferenceException();
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		ex = null;
		style11 = (ShiftAuth.Style)0;
		Enumerator<, > val3 = (Enumerator<, >)style3;
		style4 = (ShiftAuth.Style)0;
		text = null;
		texture2D3 = texture2D;
		num10 = 0;
		style7 = style6;
		int num14;
		num11 = num14;
		texture2D2 = texture2D4;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		goto IL_3204;
		IL_2a3d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_2a4c;
		IL_1818:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		stringSplitOptions = (StringSplitOptions)0;
		goto IL_301d;
		IL_2d49:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2201 @ X0_v156+8]");
		num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2201 @ X0_v156] (should have been resolved before IL gen)");
		bool flag35 = enumerable2 == null;
		val3 = (Enumerator<, >)style3;
		int num15;
		stringSplitOptions = (StringSplitOptions)num15;
		if (flag35)
		{
			goto IL_1708;
		}
		array3 = (string[])(array3 + 10);
		style14 = style13;
		array6 = array5;
		obj39 = obj30;
		style15 = style10;
		obj40 = obj28;
		style16 = style4;
		text9 = text;
		text6 = (string)(object)enumerable2;
		style17 = style9;
		num14 = 1;
		texture2D4 = texture2D2;
		object obj44 = default;
		bool flag38;
		string text11 = default;
		Enumerator<, > val4 = default;
		while (true)
		{
			nint num16 = (nint)text6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2257 @ X8_v125 (Il2CppClass<System.String>)+12E]");
			style5 = (ShiftAuth.Style)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2257 @ X8_v125 (Il2CppClass<System.String>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_120f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2257 @ X8_v125 (Il2CppClass<System.String>)+98]");
			ShiftAuth.Style style18 = (ShiftAuth.Style)((nint)0 + (nint)8);
			bool flag36 = flag17;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2295 @ X10_v48 (ShiftAuth+Style)-8]");
				obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2295 @ X10_v48 (ShiftAuth+Style)-8]");
				if ((nint)0 == style8.scale)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2257 @ X8_v125 (Il2CppClass<System.String>)+12E]");
				style5 = (ShiftAuth.Style)(-1);
				style15 = (ShiftAuth.Style)(style18 + 16);
				flag17 = style5 != (ShiftAuth.Style)(object)1;
				style18 = style15;
				flag36 = flag17;
				if (flag17)
				{
					continue;
				}
				goto IL_120f;
			}
			style5 = (ShiftAuth.Style)style18.scale;
			object obj41 = num16 + style18.scale;
			object obj42 = obj41 + 312;
			style15 = style18;
			flag17 = flag36;
			stringSplitOptions = (StringSplitOptions)num15;
			goto IL_2dc9;
			IL_2dc9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2319 @ X0_v162+8]");
			num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2319 @ X0_v162] (should have been resolved before IL gen)");
			object obj43 = obj44 & 1;
			if (obj43 == null)
			{
				break;
			}
			if (enumerable2 == null)
			{
				goto IL_1b58;
			}
			nint num17 = (nint)enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2325 @ X8_v135 (Il2CppClass<System.String>)+12E]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91C0]");
			style10 = (ShiftAuth.Style)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2325 @ X8_v135 (Il2CppClass<System.String>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_134a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2325 @ X8_v135 (Il2CppClass<System.String>)+98]");
			ShiftAuth.Style style19 = (ShiftAuth.Style)((nint)0 + (nint)8);
			bool flag37 = flag17;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2388 @ X10_v43 (ShiftAuth+Style)-8]");
				obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2388 @ X10_v43 (ShiftAuth+Style)-8]");
				if ((nint)0 == style10.scale)
				{
					break;
				}
				obj45--;
				style10 = (ShiftAuth.Style)(style19 + 16);
				flag17 = (nint)obj45 != 1;
				style19 = style10;
				flag37 = flag17;
				if (flag17)
				{
					continue;
				}
				goto IL_134a;
			}
			object obj46 = num17 + style19.scale;
			object obj47 = obj46 + 312;
			style10 = style19;
			flag17 = flag37;
			goto IL_2e47;
			IL_2e47:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2450 @ X0_v174] (should have been resolved before IL gen)");
			List<Row> list3 = rows;
			int num18 = (flag38 ? 1 : 0) & num14;
			string[] array7;
			Color32[] array8;
			if ((num18 & 1) != 0)
			{
				string text12;
				if ((num18 & 1) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9218]");
					object obj48 = 0;
					string text10 = (string)obj48 + text11;
					stringSplitOptions = (StringSplitOptions)0;
					text12 = text10;
				}
				else
				{
					text12 = text11;
					texture2D4 = (Texture2D)(&num2);
				}
				array5 = (string[])10;
				array7 = (string[])10;
				num12 = (int)text12;
				array8 = array;
			}
			else
			{
				int num19 = num18 & 1;
				bool flag39 = num19 == 0;
				Color32[] array9 = (Color32[])(texture2D4 + 8);
				object obj49 = !flag39;
				object obj50 = ~obj49;
				if (obj50 != null)
				{
					texture2D4 = (Texture2D)(&num2);
				}
				flag17 = !flag39;
				obj40 = !flag17;
				if (obj40 == null)
				{
					array8 = array9;
				}
				else
				{
					array8 = array;
				}
				array5 = array3;
				array7 = (string[])(&num2);
				num12 = (int)text11;
			}
			array8 = (Color32[])num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag40 = rows == null;
			style5 = (ShiftAuth.Style)array7;
			if (!flag40)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+10]");
				object obj51 = 0;
				style5 = (ShiftAuth.Style)num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+1C]");
				style10 = (ShiftAuth.Style)((nint)0 + (nint)1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
					style10 = (ShiftAuth.Style)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2533 @ X8_v141+18]");
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2533 @ X8_v141+18]");
					bool flag41 = num20 < 0;
					object obj52 = !flag41;
					if (obj52 == null)
					{
						object obj53 = (object)(&num2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
						object obj54 = (nint)0 * (nint)24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+10]");
						object obj55 = 0 + obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X26_v25 (System.Collections.Generic.List`1<GillaTerms+Row>)+18]");
						style5 = (ShiftAuth.Style)((nint)0 + (nint)1);
						val3 = (Enumerator<, >)obj53;
						_ = 0;
						object obj56 = obj55 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj30 = (object)(&num2);
						style10 = (ShiftAuth.Style)0;
						num12 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ X9_v5 (ShiftAuth+Style)+20]");
						object obj57 = 0;
						object obj58 = (object)(&num2);
						val3 = (Enumerator<, >)obj58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2550 @ X8_v143+A8]");
						object obj59 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2554 @ X8_v144+70]");
						stringSplitOptions = (StringSplitOptions)0;
						rows.AddWithResize((Row)(&val4));
						style14 = (ShiftAuth.Style)0;
						val4 = (Enumerator<, >)obj58;
						style5 = (ShiftAuth.Style)0;
						num12 = (int)(&val4);
					}
					style9 = (ShiftAuth.Style)(style17 + 10);
					bool flag42 = enumerable2 == null;
					object obj60 = !flag42;
					style13 = style14;
					obj28 = obj40;
					num2 = (int)style17;
					style4 = (ShiftAuth.Style)0;
					text = null;
					num11 = 0;
					texture2D2 = texture2D4;
					array6 = array5;
					style3 = (ShiftAuth.Style)val3;
					obj39 = obj30;
					style15 = style10;
					num2 = (int)style17;
					style16 = (ShiftAuth.Style)0;
					text9 = null;
					text6 = (string)(object)enumerable2;
					style17 = style9;
					num14 = 0;
					num15 = (int)stringSplitOptions;
					if (obj60 != null)
					{
						continue;
					}
					goto IL_1708;
				}
			}
			goto IL_1ad6;
			IL_134a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			stringSplitOptions = (StringSplitOptions)0;
			goto IL_2e47;
			IL_120f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			stringSplitOptions = (StringSplitOptions)0;
			goto IL_2dc9;
		}
		Enumerator<, > val5 = (Enumerator<, >)(ref enumerable);
		object obj61 = val5;
		if ((int)val5 == 0)
		{
			goto IL_2f38;
		}
		object obj62 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2362 @ X8_v131+12E]");
		style5 = (ShiftAuth.Style)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		style15 = (ShiftAuth.Style)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2362 @ X8_v131+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1818;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2362 @ X8_v131+98]");
		ShiftAuth.Style style20 = (ShiftAuth.Style)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X10_v29 (ShiftAuth+Style)-8]");
			obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X10_v29 (ShiftAuth+Style)-8]");
			if ((nint)0 == style15.scale)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2362 @ X8_v131+12E]");
			style5 = (ShiftAuth.Style)(-1);
			style15 = (ShiftAuth.Style)(style20 + 16);
			bool flag43 = style5 != (ShiftAuth.Style)(object)1;
			style20 = style15;
			if (flag43)
			{
				continue;
			}
			goto IL_1818;
		}
		style5 = (ShiftAuth.Style)style20.scale;
		object obj63 = obj62 + style20.scale;
		object obj64 = obj63 + 312;
		style15 = style20;
		goto IL_301d;
		IL_101f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num15 = 0;
		goto IL_2d49;
		IL_1d25:
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		style11 = style12;
		style8 = style;
		texture2D3 = texture2D;
		num10 = 0;
		style7 = style6;
		UnityEngine.Object obj65 = default;
		obj6 = obj65;
		goto IL_2390;
		IL_3a9d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9198]");
		object obj66 = 0;
		num12 = (int)obj66;
		((Enumerator<, >*)val2)->Dispose();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		text4 = (string)0;
		NullReferenceException ex5;
		bool flag44 = ex5 == null;
		object obj67 = !flag44;
		style3 = (ShiftAuth.Style)val3;
		object obj69;
		if (obj67 == null)
		{
			bool flag45 = style11 == (ShiftAuth.Style)(object)0;
			object obj68 = !flag45;
			style3 = (ShiftAuth.Style)val3;
			ex2 = (NullReferenceException)val2;
			if (obj68 == null)
			{
				bool flag46 = (nint)obj69 < 30;
				object obj13 = !flag46;
				object obj14 = obj69 - 30;
				bool flag14 = (nint)obj14 < 0;
				bool flag15 = (nint)obj69 == 30;
				int num5 = obj69 ^ 0x1E;
				int num6 = obj69 ^ obj14;
				int num7 = num5 & num6;
				bool flag16 = num7 < 0;
				style12 = style11;
				style3 = (ShiftAuth.Style)val3;
				if (!flag15)
				{
					bool flag47 = obj69 == null;
					object obj70 = !flag47;
					style12 = style11;
					style3 = (ShiftAuth.Style)val3;
					if (obj70 != null)
					{
						return;
					}
				}
				goto IL_21f3;
			}
			goto IL_2a3d;
		}
		ex4 = new OutOfMemoryException();
		val3 = (Enumerator<, >)style3;
		goto IL_3204;
		IL_2a4c:
		throw new OutOfMemoryException();
		IL_1ac9:
		style12 = style11;
		goto IL_30fc;
		IL_2390:
		throw new NullReferenceException();
		IL_1708:
		NullReferenceException ex6 = new NullReferenceException();
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		ex = null;
		style11 = (ShiftAuth.Style)0;
		texture2D3 = texture2D;
		num10 = 0;
		style7 = style6;
		ex4 = (OutOfMemoryException)(object)ex6;
		goto IL_3204;
		IL_3204:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		OutOfMemoryException ex7 = ex4;
		object obj71 = default;
		OutOfMemoryException ex8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			if (num12 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				style11 = (ShiftAuth.Style)1;
				ex5 = ex;
				break;
			}
			if (num12 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				ex5 = (NullReferenceException)obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (NullReferenceException)obj71;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EDB4");
			ex7 = ex8;
		}
		obj69 = 0;
		goto IL_3a9d;
		IL_301d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2500 @ X0_v167+8]");
		num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2500 @ X0_v167] (should have been resolved before IL gen)");
		goto IL_2f38;
		IL_0e30:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9218]");
		object value = 0;
		flag38 = text5.StartsWith((string)value);
		if (flag38)
		{
			string text13 = text5.Substring(2);
			bool flag48 = text13 == null;
			style2 = (ShiftAuth.Style)0;
			s = (ShiftAuth.Style)0;
			val = (Enumerator<, >)0;
			text6 = text5;
			text4 = (string)flag38;
			texture2D3 = texture2D;
			num10 = 0;
			style7 = style6;
			stringSplitOptions = (StringSplitOptions)0;
			obj6 = (UnityEngine.Object)2;
			if (flag48)
			{
				goto IL_2390;
			}
			string text14 = text13.Trim();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9218]");
			object s2 = 0;
			int num21 = Measure((string)s2);
			text6 = text14;
			array3 = (string[])num21;
		}
		else
		{
			string text15 = text5.Trim();
			text6 = text15;
			array3 = null;
		}
		num15 = 358 - array3;
		IEnumerable<string> enumerable3 = Wrap(text6, num15);
		bool flag49 = enumerable3 == null;
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		text4 = (string)flag38;
		texture2D3 = texture2D;
		num10 = 0;
		style7 = style6;
		stringSplitOptions = (StringSplitOptions)num15;
		obj6 = (UnityEngine.Object)(object)text6;
		if (flag49)
		{
			goto IL_2390;
		}
		nint num22 = (nint)enumerable3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X8_v119 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		style5 = (ShiftAuth.Style)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B8]");
		style10 = (ShiftAuth.Style)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X8_v119 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_101f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X8_v119 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+98]");
		ShiftAuth.Style style21 = (ShiftAuth.Style)((nint)0 + (nint)8);
		bool flag50 = flag17;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2141 @ X10_v53 (ShiftAuth+Style)-8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2141 @ X10_v53 (ShiftAuth+Style)-8]");
			if ((nint)0 == style10.scale)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X8_v119 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
			style5 = (ShiftAuth.Style)(-1);
			style10 = (ShiftAuth.Style)(style21 + 16);
			flag17 = style5 != (ShiftAuth.Style)(object)1;
			style21 = style10;
			flag50 = flag17;
			if (flag17)
			{
				continue;
			}
			goto IL_101f;
		}
		style5 = (ShiftAuth.Style)style21.scale;
		object obj72 = num22 + style21.scale;
		object obj73 = obj72 + 312;
		style10 = style21;
		flag17 = flag50;
		goto IL_2d49;
		IL_21f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		style8 = (ShiftAuth.Style)(this + 176);
		UnityEngine.Object obj74 = default;
		((ShiftAuth.Style*)(nint)style8)->scale = (int)obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		num = style8.scale;
		bool flag51 = style8.scale == 0;
		style11 = style12;
		obj6 = obj74;
		if (flag51)
		{
			goto IL_2390;
		}
		ShiftAuth.Style style22 = style5;
		Texture2D texture2D5 = null;
		nint num23 = style8.scale;
		Texture2D texture2D10 = default;
		object obj117 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X20_v22 (Il2CppMethodInfo)+18]");
			object obj75 = 0;
			Texture2D texture2D6 = texture2D5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X20_v22 (Il2CppMethodInfo)+18]");
			bool flag52 = (nint)texture2D6 < 0;
			object obj13 = !flag52;
			Texture2D texture2D7 = texture2D5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X20_v22 (Il2CppMethodInfo)+18]");
			object obj14 = texture2D7 - 0;
			bool flag14 = (nint)obj14 < 0;
			bool flag15 = obj14 == null;
			Texture2D texture2D8 = texture2D5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X20_v22 (Il2CppMethodInfo)+18]");
			int num5 = texture2D8 ^ 0;
			int num6 = (object)texture2D5 ^ obj14;
			int num7 = num5 & num6;
			bool flag16 = num7 < 0;
			Texture2D texture2D9 = texture2D5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X20_v22 (Il2CppMethodInfo)+18]");
			flag17 = (nint)texture2D9 >= 0;
			style11 = style12;
			style5 = style22;
			obj6 = obj74;
			texture2D2 = texture2D5;
			num = num23;
			if (!flag17)
			{
				object obj76 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1994 @ X0_v101+E4]");
				style5 = (ShiftAuth.Style)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1994 @ X0_v101+E4]");
				bool flag53 = (nint)0 == 0;
				object obj77 = !flag53;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X20_v22 (Il2CppMethodInfo)+18]");
					obj75 = 0;
				}
				bool flag54 = System.Runtime.CompilerServices.Unsafe.As<Texture2D, UIntPtr>(ref texture2D5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj75);
				obj13 = !flag54;
				obj14 = (object)texture2D5 - obj75;
				flag14 = (nint)obj14 < 0;
				flag15 = obj14 == null;
				num5 = (object)texture2D5 ^ obj75;
				num6 = (object)texture2D5 ^ obj14;
				num7 = num5 & num6;
				flag16 = num7 < 0;
				style11 = style12;
				num12 = (int)obj74;
				texture2D2 = texture2D5;
				if (obj13 != null)
				{
					break;
				}
				object obj78 = obj20;
				style5 = (ShiftAuth.Style)(num23 + texture2D5);
				texture2D2 = (Texture2D)(texture2D5 + 1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2049 @ X8_v65+A0]");
				object obj79 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2050 @ X8_v66+60]");
				_ = 0;
				num = style8.scale;
				bool flag55 = style8.scale == 0;
				object obj80 = !flag55;
				style11 = style12;
				obj6 = obj74;
				style22 = style5;
				texture2D5 = texture2D2;
				num23 = style8.scale;
				if (obj80 != null)
				{
					continue;
				}
			}
			else
			{
				num11 = 0;
				while (true)
				{
					object obj81 = obj20;
					array = (Color32[])style8.scale;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v34+E4]");
					bool flag56 = (nint)0 == 0;
					object obj82 = !flag56;
					if (obj82 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj81 = obj20;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v34+A0]");
					object obj83 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v21+54]");
					Color32 color = (Color32)0;
					Color32[] buf = array;
					int x = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v21+54]");
					Put(buf, 320, x, 0, (Color32)0);
					int scale = style8.scale;
					bool flag57 = style8.scale == 0;
					num10 = 0;
					stringSplitOptions = (StringSplitOptions)num11;
					obj6 = (UnityEngine.Object)320;
					if (flag57)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v22 (System.Int32)+18]");
					style5 = (ShiftAuth.Style)0;
					int num24 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v22 (System.Int32)+18]");
					bool flag58 = (nint)num24 < (nint)0;
					object obj84 = !flag58;
					num10 = 0;
					stringSplitOptions = (StringSplitOptions)num11;
					num12 = 320;
					if (obj84 != null)
					{
						goto end_IL_3546;
					}
					object obj85 = obj20;
					object obj86 = style8.scale + num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X9_v14+A0]");
					object obj87 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X9_v15+54]");
					style5 = (ShiftAuth.Style)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X9_v15+54]");
					_ = 0;
					object obj88 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v24+A0]");
					object obj89 = 0;
					int scale2 = style8.scale;
					int x2 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X8_v25+54]");
					Put((Color32[])scale2, 320, x2, 36, (Color32)0);
					object obj90 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v26+A0]");
					object obj91 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v27+54]");
					color = (Color32)0;
					int scale3 = style8.scale;
					int x3 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v27+54]");
					Put((Color32[])scale3, 320, x3, 291, (Color32)0);
					num11++;
					bool flag59 = num11 < 384;
					obj13 = !flag59;
					obj14 = num11 - 384;
					flag14 = (nint)obj14 < 0;
					flag15 = obj14 == null;
					num5 = num11 ^ 0x180;
					num6 = num11 ^ obj14;
					num7 = num5 & num6;
					flag16 = num7 < 0;
					flag17 = num11 != 384;
					num10 = 291;
					stringSplitOptions = (StringSplitOptions)num11;
					obj6 = (UnityEngine.Object)320;
					if (flag17)
					{
						continue;
					}
					int num25 = 291;
					int num26 = 0;
					int num27 = num11;
					int num28 = 320;
					int num29;
					bool flag61;
					do
					{
						object obj92 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1432 @ X0_v40+E4]");
						bool flag60 = (nint)0 == 0;
						object obj93 = !flag60;
						if (obj93 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj92 = obj20;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1432 @ X0_v40+A0]");
						object obj94 = 0;
						int scale4 = style8.scale;
						int y = num26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1434 @ X8_v30+54]");
						Put((Color32[])scale4, 320, 0, y, (Color32)0);
						object obj95 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1578 @ X8_v31+A0]");
						object obj96 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X8_v32+54]");
						color = (Color32)0;
						int scale5 = style8.scale;
						int y2 = num26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X8_v32+54]");
						Put((Color32[])scale5, 320, 383, y2, (Color32)0);
						num29 = num26 + 1;
						flag61 = num29 != 320;
						num25 = num26;
						num26 = num29;
						num27 = 383;
						num28 = 320;
					}
					while (flag61);
					bool flag62 = (object)texture2D3 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X8_v32+54]");
					int num30 = 0;
					int num31 = num29;
					int num32 = 383;
					Color32[] array10 = (Color32[])320;
					if (!flag62)
					{
						object obj97 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ X0_v82+E4]");
						bool flag63 = (nint)0 == 0;
						object obj98 = !flag63;
						if (obj98 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj97 = obj20;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ X0_v82+A0]");
						object obj99 = 0;
						object obj100 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91F0]");
						style5 = (ShiftAuth.Style)0;
						string text16 = (string)style5.scale;
						int num33 = ((ScreenFont)(object)texture2D3).DrawCentred((Color32[])style8.scale, 384, 320, 192, 5, (string)style5.scale, ref s);
						int num34 = 5;
						num30 = 192;
						object obj101 = (object)(&s);
						s = (ShiftAuth.Style)4503599627370496002L;
						style3 = (ShiftAuth.Style)0;
						num31 = 320;
						num32 = 384;
						array10 = (Color32[])style8.scale;
					}
					bool flag64 = style7.scale == 0;
					Color32[] array11 = array10;
					if (!flag64)
					{
						object obj102 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X0_v74+E4]");
						bool flag65 = (nint)0 == 0;
						object obj103 = !flag65;
						if (obj103 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj102 = obj20;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X0_v74+A0]");
						object obj104 = 0;
						object obj105 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91F8]");
						object obj106 = 0;
						string text16 = (string)obj106;
						int num35 = ((ScreenFont)style7.scale).DrawCentred((Color32[])style8.scale, 384, 320, 192, 26, (string)obj106, ref s);
						int num34 = 26;
						num30 = 192;
						object obj101 = (object)(&s);
						s = (ShiftAuth.Style)1;
						style3 = (ShiftAuth.Style)0;
						num31 = 320;
						style5 = (ShiftAuth.Style)1;
						num32 = 384;
						array11 = (Color32[])style8.scale;
					}
					int num36 = 41;
					while (true)
					{
						object obj107 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1934 @ X0_v48+E4]");
						bool flag66 = (nint)0 == 0;
						object obj108 = !flag66;
						if (obj108 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj107 = obj20;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1934 @ X0_v48+A0]");
						object obj109 = 0;
						int scale6 = style8.scale;
						int y3 = num36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1843 @ X8_v40+58]");
						Put((Color32[])scale6, 320, 374, y3, (Color32)0);
						int num37 = 374 + 1;
						bool flag67 = num37 != 377;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1843 @ X8_v40+58]");
						num30 = 0;
						num31 = num36;
						num32 = 374;
						array11 = (Color32[])320;
						if (!flag67)
						{
							int num38 = num36 + 1;
							bool flag68 = num38 < 287;
							obj13 = !flag68;
							obj14 = num38 - 287;
							flag14 = (nint)obj14 < 0;
							flag15 = obj14 == null;
							num5 = num38 ^ 0x11F;
							num6 = num38 ^ obj14;
							num7 = num5 & num6;
							flag16 = num7 < 0;
							flag17 = num38 != 287;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1843 @ X8_v40+58]");
							num30 = 0;
							num31 = num36;
							num32 = num37;
							array11 = (Color32[])320;
							num36 = num38;
							if (!flag17)
							{
								break;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj110 = 0;
					num = (nint)(this + 160);
					object obj111 = obj110;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2025 @ X0_v50+E4]");
					bool flag69 = (nint)0 == 0;
					object obj112 = !flag69;
					if (obj112 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag70 = (UnityEngine.Object)num == null;
					bool flag71 = !flag70;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1843 @ X8_v40+58]");
					bool flag72 = false;
					TextureFormat textureFormat = (TextureFormat)num36;
					object obj113 = 0;
					if (!flag71)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
						object obj114 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						texture2D10._002Ector(384, 320, (TextureFormat)4, mipChain: false);
						bool flag73 = (object)texture2D10 == null;
						int num34 = 0;
						color = (Color32)0;
						num10 = 4;
						stringSplitOptions = (StringSplitOptions)320;
						obj6 = (UnityEngine.Object)384;
						texture2D2 = texture2D10;
						if (flag73)
						{
							break;
						}
						texture2D10.filterMode = (FilterMode)0;
						texture2D10.wrapMode = (TextureWrapMode)1;
						texture2D10.hideFlags = (HideFlags)52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9208]");
						object obj115 = 0;
						texture2D10.name = (string)obj115;
						num = (nint)texture2D10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						num34 = 0;
						flag72 = false;
						textureFormat = (TextureFormat)4;
						obj113 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj116 = this + 168;
					obj116 = obj117;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj118 = this + 152;
					obj118 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
			}
			goto IL_2390;
			continue;
			end_IL_3546:
			break;
		}
		goto IL_2a21;
		IL_2a21:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_2a2f;
		IL_1b58:
		NullReferenceException ex10 = new NullReferenceException();
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		ex = null;
		style11 = (ShiftAuth.Style)0;
		val3 = (Enumerator<, >)style3;
		texture2D3 = texture2D;
		num10 = 0;
		style7 = style6;
		num11 = num14;
		texture2D2 = texture2D4;
		ex4 = (OutOfMemoryException)(object)ex10;
		goto IL_3204;
		IL_30fc:
		int num39 = style9 + 12;
		object obj119 = style9 - 236;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		text4 = (string)0;
		style10 = (ShiftAuth.Style)(num39 + num39);
		object obj120 = ~obj119;
		style5 = (ShiftAuth.Style)(obj119 & obj120);
		object obj121 = style10 << 7;
		maxScroll = (int)style5;
		bodyH = num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bodyPx = (Color32[])(object)obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		num = (nint)bodyPx;
		bool flag74 = bodyPx == null;
		style2 = (ShiftAuth.Style)0;
		s = (ShiftAuth.Style)0;
		val = (Enumerator<, >)0;
		style11 = style12;
		style8 = style;
		texture2D3 = texture2D;
		num10 = 0;
		style7 = style6;
		obj6 = obj65;
		if (!flag74)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
			obj20 = 0;
			texture2D2 = null;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X20_v27 (Il2CppMethodInfo)+18]");
				object obj122 = 0;
				Texture2D texture2D11 = texture2D2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X20_v27 (Il2CppMethodInfo)+18]");
				bool flag75 = (nint)texture2D11 < 0;
				object obj13 = !flag75;
				Texture2D texture2D12 = texture2D2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X20_v27 (Il2CppMethodInfo)+18]");
				object obj14 = texture2D12 - 0;
				bool flag14 = (nint)obj14 < 0;
				bool flag15 = obj14 == null;
				Texture2D texture2D13 = texture2D2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X20_v27 (Il2CppMethodInfo)+18]");
				int num5 = texture2D13 ^ 0;
				int num6 = (object)texture2D2 ^ obj14;
				int num7 = num5 & num6;
				bool flag16 = num7 < 0;
				Texture2D texture2D14 = texture2D2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X20_v27 (Il2CppMethodInfo)+18]");
				if ((nint)texture2D14 >= 0)
				{
					break;
				}
				object obj123 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1644 @ X0_v139+E4]");
				style5 = (ShiftAuth.Style)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1644 @ X0_v139+E4]");
				bool flag76 = (nint)0 == 0;
				object obj124 = !flag76;
				if (obj124 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X20_v27 (Il2CppMethodInfo)+18]");
					obj122 = 0;
				}
				bool flag77 = System.Runtime.CompilerServices.Unsafe.As<Texture2D, UIntPtr>(ref texture2D2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj122);
				obj13 = !flag77;
				obj14 = (object)texture2D2 - obj122;
				flag14 = (nint)obj14 < 0;
				flag15 = obj14 == null;
				num5 = (object)texture2D2 ^ obj122;
				num6 = (object)texture2D2 ^ obj14;
				num7 = num5 & num6;
				flag16 = num7 < 0;
				style2 = (ShiftAuth.Style)0;
				s = (ShiftAuth.Style)0;
				val = (Enumerator<, >)0;
				style11 = style12;
				texture2D3 = texture2D;
				num10 = 0;
				style7 = style6;
				num12 = (int)obj65;
				if (obj13 == null)
				{
					object obj125 = obj20;
					style5 = (ShiftAuth.Style)(num + texture2D2);
					texture2D2 = (Texture2D)(texture2D2 + 1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ X8_v96+A0]");
					object obj126 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1796 @ X8_v97+60]");
					_ = 0;
					num = style.scale;
					bool flag78 = style.scale == 0;
					object obj127 = !flag78;
					if (obj127 != null)
					{
						continue;
					}
					goto IL_1d25;
				}
				goto IL_2a21;
			}
			bool flag79 = style6.scale == 0;
			style2 = (ShiftAuth.Style)0;
			s = (ShiftAuth.Style)0;
			val = (Enumerator<, >)0;
			texture2D3 = texture2D;
			num10 = 0;
			style7 = style6;
			if (flag79)
			{
				goto IL_21f3;
			}
			bool flag80 = rows == null;
			style2 = (ShiftAuth.Style)0;
			s = (ShiftAuth.Style)0;
			val = (Enumerator<, >)0;
			style11 = style12;
			style8 = style;
			texture2D3 = texture2D;
			num10 = 0;
			style7 = style6;
			obj6 = obj65;
			if (!flag80)
			{
				Enumerator<, > enumerator = rows.GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91A0]");
				object obj128 = 0;
				style2 = (ShiftAuth.Style)0;
				s = (ShiftAuth.Style)0;
				ShiftAuth.Style style23 = style12;
				Enumerator<, > val6 = default;
				val3 = val6;
				num10 = 0;
				object obj130 = default;
				Color32[] array12 = default;
				int num40 = default;
				while (val.MoveNext())
				{
					array3 = (string[])(object)bodyPx;
					object obj129 = obj130 & 1;
					bool flag81 = obj129 == null;
					object obj131 = !flag81;
					if (obj131 == null)
					{
						object obj132 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2034 @ X0_v134+E4]");
						bool flag82 = (nint)0 == 0;
						object obj133 = !flag82;
						if (obj133 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj132 = obj20;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2034 @ X0_v134+A0]");
						object obj134 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2036 @ X8_v94+28]");
						num12 = 0;
						object obj135 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2036 @ X8_v94+28]");
						style2 = (ShiftAuth.Style)0;
					}
					else
					{
						object obj136 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2042 @ X0_v128+E4]");
						bool flag83 = (nint)0 == 0;
						object obj137 = !flag83;
						if (obj137 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj136 = obj20;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2042 @ X0_v128+A0]");
						object obj138 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2044 @ X8_v92+30]");
						num12 = 0;
						object obj139 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2044 @ X8_v92+30]");
						style2 = (ShiftAuth.Style)0;
					}
					bool flag84 = this.text == null;
					s = (ShiftAuth.Style)1;
					val = val6;
					ex = null;
					style23 = style2;
					style11 = (ShiftAuth.Style)0;
					style3 = (ShiftAuth.Style)1;
					style9 = (ShiftAuth.Style)1;
					texture2D3 = texture2D;
					array = array12;
					style7 = style6;
					style5 = (ShiftAuth.Style)(&val);
					num11 = num40;
					texture2D2 = (Texture2D)(&s);
					if (!flag84)
					{
						int num41 = this.text.Draw((Color32[])(object)array3, 384, bodyH, (int)array12, (int)style12, (string)num40, ref s);
						string text16 = (string)num40;
						int num34 = (int)style12;
						Color32 color = (Color32)array12;
						object obj101 = (object)(&s);
						s = (ShiftAuth.Style)1;
						style23 = style2;
						val3 = (Enumerator<, >)1;
						num10 = bodyH;
						array = array12;
						num11 = num40;
						stringSplitOptions = (StringSplitOptions)384;
						continue;
					}
					goto IL_2a2f;
				}
				val = val6;
				ex = null;
				style11 = (ShiftAuth.Style)0;
				val2 = (Enumerator<, >)(ref val);
				style9 = (ShiftAuth.Style)1;
				ex5 = null;
				texture2D3 = texture2D;
				style7 = style6;
				style5 = (ShiftAuth.Style)(&val);
				texture2D2 = (Texture2D)(&s);
				obj69 = 30;
				goto IL_3a9d;
			}
		}
		goto IL_2390;
	}

	private unsafe void Compose()
	{
		//IL_13b4: Expected Obj, but got I4
		//IL_13d2: Expected Obj, but got I
		//IL_13fc: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected I4, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_1443: Expected Obj, but got I4
		//IL_144c: Expected I4, but got Obj
		//IL_1520: Expected Obj, but got I
		//IL_152b: Invalid comparison between F4 and I4
		//IL_0284: Expected Obj, but got I
		//IL_1489: Expected Obj, but got I
		//IL_14b3: Expected Obj, but got I4
		//IL_1ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Expected Obj, but got Unknown
		//IL_0127: Invalid comparison between F4 and I4
		//IL_026f: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_154f: Expected I4, but got F8
		//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14de: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I4
		//IL_03ce: Expected Obj, but got I4
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Obj, but got Unknown
		//IL_068d: Expected Obj, but got I4
		//IL_162b: Expected Obj, but got I4
		//IL_0402: Expected F8, but got I
		//IL_073b: Expected Obj, but got I4
		//IL_1641: Unknown result type (might be due to invalid IL or missing references)
		//IL_1646: Expected Obj, but got Unknown
		//IL_1683: Expected Obj, but got I4
		//IL_168b: Expected I4, but got Obj
		//IL_05e9: Expected Obj, but got I4
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_0610: Expected F8, but got I4
		//IL_0461: Invalid comparison between F4 and I4
		//IL_09b5: Expected F8, but got I4
		//IL_074f: Expected Obj, but got I4
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected I4, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_080c: Expected I4, but got Obj
		//IL_0814: Expected Obj, but got I4
		//IL_1748: Expected VT, but got I4
		//IL_1750: Expected I4, but got Obj
		//IL_0880: Expected Obj, but got I4
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected I4, but got Unknown
		//IL_08ee: Expected Obj, but got I4
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_0b5e: Expected I4, but got VT
		//IL_0b66: Expected Obj, but got I4
		//IL_0b6e: Expected I4, but got Obj
		//IL_0a9b: Expected I4, but got F8
		//IL_16b7: Expected Obj, but got I4
		//IL_0b92: Expected Obj, but got I4
		//IL_183c: Expected I4, but got Obj
		//IL_185e: Expected Obj, but got I4
		//IL_1be3: Expected Obj, but got I
		//IL_1c0d: Expected Obj, but got I4
		//IL_157b: Expected Obj, but got I
		//IL_15a5: Expected Obj, but got I4
		//IL_0dbf: Expected Obj, but got I4
		//IL_187c: Expected F8, but got I
		//IL_1886: Expected I4, but got Obj
		//IL_1890: Expected I4, but got Obj
		//IL_1894: Expected native int or pointer, but got F8
		//IL_1799: Expected Obj, but got I
		//IL_17a9: Expected VT, but got I
		//IL_17cc: Expected VT, but got I
		//IL_17cc: Expected Obj, but got I4
		//IL_180e: Expected Obj, but got I4
		//IL_094f: Invalid comparison between F4 and I4
		//IL_0c72: Expected Obj, but got I4
		//IL_0bb4: Invalid comparison between F4 and I4
		//IL_0bcb: Expected Obj, but got F4
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected Obj, but got Unknown
		//IL_0dee: Expected Obj, but got I
		//IL_0df7: Expected Obj, but got I4
		//IL_18eb: Expected Obj, but got I
		//IL_0c26: Expected Obj, but got I4
		//IL_0ad2: Invalid comparison between I4 and F8
		//IL_0afc: Expected Obj, but got I4
		//IL_0b1c: Expected Obj, but got I4
		//IL_04ef: Expected I4, but got F4
		//IL_1b90: Expected Obj, but got I4
		//IL_1c5e: Expected Obj, but got I4
		//IL_1c5e: Expected Obj, but got I4
		//IL_1c7c: Expected Obj, but got I4
		//IL_1c84: Expected Obj, but got I4
		//IL_1c8c: Expected Obj, but got Ref
		//IL_1cb8: Expected Obj, but got I4
		//IL_1cc1: Expected F8, but got I4
		//IL_1cc9: Expected F8, but got Ref
		//IL_0c8e: Expected native int or pointer, but got F8
		//IL_18d0: Expected Obj, but got I
		//IL_0c42: Expected native int or pointer, but got F8
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e8: Expected Obj, but got Unknown
		//IL_1702: Expected Obj, but got I4
		//IL_0532: Expected F4, but got I
		//IL_0e1b: Expected Obj, but got I
		//IL_0cc3: Expected Obj, but got I
		//IL_15c3: Expected Obj, but got I
		//IL_15ed: Expected Obj, but got I4
		//IL_12f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f6: Expected Obj, but got Unknown
		//IL_1300: Expected Obj, but got I4
		//IL_057a: Expected I4, but got F4
		//IL_0e70: Invalid comparison between F4 and I4
		//IL_0d37: Expected native int or pointer, but got F8
		//IL_0d62: Expected Obj, but got I4
		//IL_1900: Expected Obj, but got I
		//IL_1966: Expected Obj, but got Ref
		//IL_1980: Expected I4, but got Obj
		//IL_199d: Expected I4, but got Obj
		//IL_19a6: Expected F8, but got I4
		//IL_19ae: Expected F8, but got Ref
		//IL_0e97: Expected F4, but got I
		//IL_0d7e: Expected native int or pointer, but got F8
		//IL_19c3: Expected Obj, but got I
		//IL_1a00: Expected F4, but got I
		//IL_1ce7: Expected Obj, but got I
		//IL_1d11: Expected Obj, but got I4
		//IL_0edb: Expected I4, but got Obj
		//IL_0ee4: Expected F8, but got I4
		//IL_1b69: Expected Obj, but got I4
		//IL_1a15: Expected Obj, but got I
		//IL_1a25: Expected Obj, but got I
		//IL_0efb: Expected I4, but got Obj
		//IL_0f10: Invalid comparison between F8 and I
		//IL_1b39: Expected Obj, but got I4
		//IL_1a5a: Expected Obj, but got I
		//IL_1a6a: Expected Obj, but got I
		//IL_0f47: Expected I4, but got Obj
		//IL_0f5c: Invalid comparison between F8 and I
		//IL_0f6d: Expected Obj, but got I4
		//IL_0f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f90: Expected Obj, but got Unknown
		//IL_0fa0: Expected Obj, but got I
		//IL_100e: Expected Obj, but got I4
		//IL_1083: Invalid comparison between F8 and I
		//IL_1094: Expected Obj, but got I4
		//IL_103e: Expected Obj, but got I
		//IL_104e: Expected Obj, but got I
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Expected Obj, but got Unknown
		//IL_10e9: Expected Obj, but got I
		//IL_11b4: Expected I4, but got Obj
		//IL_1242: Expected Obj, but got I4
		//IL_113b: Expected Obj, but got I4
		//IL_1b12: Expected Obj, but got I
		//IL_11fb: Expected Obj, but got I4
		//IL_12b8: Expected I4, but got Obj
		//IL_1d55: Expected I4, but got Obj
		//IL_1d77: Expected Obj, but got I4
		//IL_1af7: Expected Obj, but got I
		//IL_115b: Expected I4, but got Obj
		//IL_117d: Expected Obj, but got I4
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_1285: Expected I4, but got Unknown
		//IL_1292: Expected I4, but got F8
		//IL_129a: Expected VT, but got I4
		//IL_12ab: Expected Obj, but got I4
		//IL_1a9f: Expected Obj, but got I
		//IL_1aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aae: Expected I4, but got Unknown
		//IL_1abb: Expected I4, but got F8
		//IL_1acb: Expected VT, but got I
		//IL_1adc: Expected Obj, but got I4
		//IL_1d40: Expected I4, but got VT
		//IL_1d48: Expected Obj, but got I4
		bool flag = px == null;
		object obj = !flag;
		if (obj == null)
		{
			Lay();
		}
		float num = scroll;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj5 = -maxScroll;
		bool flag3 = (nint)obj5 < 0;
		int num2 = maxScroll & obj5;
		bool flag4 = num2 < 0;
		bool flag5 = flag3 == flag4;
		object obj6 = !flag5;
		object obj7 = ~obj6;
		int num3 = ((obj7 != null) ? maxScroll : 0);
		bool flag6 = 0 < 0;
		bool flag7 = 0 < 0;
		bool flag8 = flag6 == flag7;
		object obj8 = !flag8;
		int num4 = (((int)(~obj8) != 0) ? num3 : 0);
		double num7;
		double num8;
		double num9 = default;
		double num10 = default;
		float num6;
		if (maxScroll >= 1)
		{
			float num5 = scroll * 1.1204035E+09f;
			num6 = num5 / (float)maxScroll;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v156+E4]");
			bool flag9 = (nint)0 == 0;
			object obj11 = !flag9;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			if (num6 < 0f)
			{
				if ((double)num6 == -0.5)
				{
					num7 = -1.0;
					num8 = num9;
					goto IL_14c1;
				}
				num8 = (double)num6 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				num10 = -0.5;
			}
			else
			{
				if ((double)num6 == 0.5)
				{
					num7 = 1.0;
					num8 = num9;
					goto IL_14c1;
				}
				num8 = (double)num6 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num10 = 0.5;
			}
			goto IL_1547;
		}
		int value = 100;
		goto IL_1506;
		IL_14c1:
		num10 = num8 + num7;
		object obj12 = num8 & 1;
		if (obj12 != null)
		{
			num8 = num10;
		}
		goto IL_1547;
		IL_1383:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1391;
		IL_1547:
		value = (int)num8;
		num = num6;
		goto IL_1506;
		IL_1506:
		float num11 = acceptedAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj13 = 0;
		object obj14;
		if (acceptedAt < 0f)
		{
			if (!atEnd)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92F8]");
				obj14 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92F0]");
				obj14 = 0;
			}
			bool flag10 = atEnd;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92E0]");
			obj14 = 0;
		}
		StringBuilder stringBuilder = (StringBuilder)(this + 144);
		stringBuilder = (StringBuilder)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder2 = default;
		stringBuilder2._002Ector();
		StringBuilder stringBuilder7;
		if (stringBuilder2 != null)
		{
			StringBuilder stringBuilder3 = stringBuilder2.Append(num4);
			if (stringBuilder3 != null)
			{
				StringBuilder stringBuilder4 = stringBuilder3.Append('|');
				if (stringBuilder4 != null)
				{
					StringBuilder stringBuilder5 = stringBuilder4.Append((string)(object)stringBuilder);
					if (stringBuilder5 != null)
					{
						StringBuilder stringBuilder6 = stringBuilder5.Append('|');
						if (stringBuilder6 != null)
						{
							stringBuilder7 = stringBuilder6.Append(value);
							Hand[] array = hands;
							if (hands != null)
							{
								object obj15 = array.Length;
								if (array.Length < 1)
								{
									goto IL_062f;
								}
								object obj16 = 0;
								float num12 = num11;
								float num13 = num;
								while (true)
								{
									bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
									object obj17 = !flag11;
									if (obj17 != null)
									{
										break;
									}
									object obj18 = (object)hands + obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v101+20]");
									double num14 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v101+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X28_v8 (System.Double)+21]");
										if ((nint)0 != 0)
										{
											num12 = acceptedAt;
											if (acceptedAt < 0f)
											{
												if (stringBuilder7 != null)
												{
													StringBuilder stringBuilder8 = stringBuilder7.Append('|');
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
													object obj19 = 0;
													object obj20 = obj19;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X0_v135+E4]");
													bool flag12 = (nint)0 == 0;
													object obj21 = !flag12;
													if (obj21 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													if (stringBuilder8 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
														StringBuilder stringBuilder9 = stringBuilder8.Append((int)num12);
														if (stringBuilder9 != null)
														{
															StringBuilder stringBuilder10 = stringBuilder9.Append(',');
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X28_v8 (System.Double)+28]");
															num13 = 0f;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
															object obj22 = 0;
															object obj23 = obj22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X0_v141+E4]");
															bool flag13 = (nint)0 == 0;
															object obj24 = !flag13;
															if (obj24 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															if (stringBuilder10 != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
																StringBuilder stringBuilder11 = stringBuilder10.Append((int)num12);
																if (stringBuilder11 != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X28_v8 (System.Double)+22]");
																	char value2 = (((nint)0 != 0) ? '+' : '-');
																	StringBuilder stringBuilder12 = stringBuilder11.Append(value2);
																	goto IL_05df;
																}
															}
														}
													}
												}
												goto IL_1383;
											}
										}
										goto IL_05df;
									}
									goto IL_1383;
									IL_05df:
									obj15 = array.Length;
									obj16++;
									bool flag14 = (nint)obj16 < array.Length;
									double num15 = 1.0;
									num11 = num12;
									num = num13;
									if (flag14)
									{
										continue;
									}
									goto IL_062f;
								}
								goto IL_1391;
							}
						}
					}
				}
			}
		}
		goto IL_1383;
		IL_1391:
		throw new IndexOutOfRangeException();
		IL_062f:
		int num25;
		Array array5;
		int num32;
		double num33;
		double num35;
		int num22;
		Array array4;
		double num34;
		int num23;
		if (stringBuilder7 != null)
		{
			((SymmetricAlgorithm)(object)stringBuilder7).BlockSize = 0;
			object obj25 = this + 152;
			string text = default;
			bool flag15 = text == (string)obj25;
			bool flag16 = !flag15;
			object obj26 = !flag16;
			if (obj26 != null)
			{
				return;
			}
			drawn = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Array array2 = px;
			if (px != null)
			{
				Array array3 = basePx;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X1_v16 (System.Array)+18]");
				int num16 = 0;
				Color32[] sourceArray = basePx;
				Color32[] destinationArray = px;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X1_v16 (System.Array)+18]");
				Array.Copy(sourceArray, destinationArray, 0);
				int num17 = ~num4;
				int num18 = 0;
				int num19 = num17;
				int num20 = 107137;
				object obj27 = 0;
				bool flag18;
				do
				{
					object obj28 = num4 + obj27;
					bool flag17 = (nint)obj28 >= bodyH;
					int num21 = 0;
					num22 = 372;
					num23 = num18;
					int num24 = num19;
					array4 = (Array)num16;
					num25 = (int)array2;
					int num26 = num20;
					array5 = array3;
					if (flag17)
					{
						break;
					}
					object obj29 = num19 + bodyH;
					array5 = bodyPx;
					array4 = px;
					object obj30 = obj29 + obj29;
					num25 = 1 | obj30;
					Array.Copy(bodyPx, num25, px, num20, 372);
					obj27++;
					num24 = num19 - 1;
					num26 = num20 - 384;
					flag18 = (nint)obj27 != 248;
					num21 = 0;
					num22 = 372;
					num23 = num20;
					num18 = num20;
					num19 = num24;
					num16 = (int)px;
					array2 = (Array)num25;
					num20 = num26;
					array3 = bodyPx;
				}
				while (flag18);
				if (maxScroll >= 1)
				{
					int num27 = 61008 / bodyH;
					int num28 = num4 / maxScroll;
					object obj31 = num27 - 12;
					bool flag19 = (nint)obj31 < 0;
					bool flag20 = obj31 == null;
					int num29 = num27 ^ 0xC;
					int num30 = num27 ^ obj31;
					int num31 = num29 & num30;
					bool flag21 = num31 < 0;
					bool flag22 = flag19 == flag21;
					object obj32 = !flag20;
					object obj33 = flag22 & obj32;
					object obj34 = ~obj33;
					num32 = ((obj34 != null) ? 12 : num27);
					object obj35 = 246 - num32;
					num6 = (float)num28 * (float)obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj36 = 0;
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X0_v121+E4]");
					bool flag23 = (nint)0 == 0;
					object obj38 = !flag23;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					if (num6 < 0f)
					{
						if ((double)num6 == -0.5)
						{
							num33 = -1.0;
							num34 = num9;
							goto IL_16cb;
						}
						num34 = (double)num6 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						num10 = -0.5;
					}
					else
					{
						if ((double)num6 == 0.5)
						{
							num33 = 1.0;
							num34 = num9;
							goto IL_16cb;
						}
						num34 = (double)num6 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num10 = 0.5;
					}
					goto IL_1774;
				}
				num34 = num11;
				num35 = 0.0;
				num32 = 246;
				goto IL_1710;
			}
		}
		goto IL_1383;
		IL_16cb:
		num10 = num34 + num33;
		object obj39 = num34 & 1;
		bool flag24 = obj39 == null;
		object obj40 = !flag24;
		if (obj40 != null)
		{
			num34 = num10;
		}
		goto IL_1774;
		IL_1710:
		double num36 = num35 + 41.0;
		double num37 = num36 + (double)num32;
		bool flag25 = !(num36 < num37);
		Color32 color = (Color32)num22;
		int num38 = (int)array4;
		int num39 = 1;
		Color32[] array6 = (Color32[])array5;
		if (!flag25)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
			num39 = 0;
			int num40 = num23;
			int num41 = num25;
			int num42 = (int)num36;
			while (true)
			{
				int value3 = ((int*)num39)->m_value;
				int num24 = (int)px;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X0_v116 (System.Int32)+E4]");
				bool flag26 = (nint)0 == 0;
				object obj41 = !flag26;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value3 = ((int*)num39)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X0_v116 (System.Int32)+A0]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v86+5C]");
				color = (Color32)0;
				int num43 = num24;
				int y = num42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v86+5C]");
				Put((Color32[])num43, 320, 374, y, (Color32)0);
				int num26 = 374 + 1;
				bool flag27 = num26 != 377;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v86+5C]");
				num22 = 0;
				num40 = num42;
				array4 = (Array)374;
				num41 = 320;
				if (!flag27)
				{
					int num44 = num42 + 1;
					bool flag28 = (double)num44 != num37;
					num23 = num42;
					num38 = num26;
					num25 = 320;
					array6 = (Color32[])num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v86+5C]");
					num22 = 0;
					num40 = num42;
					array4 = (Array)num26;
					num41 = 320;
					num42 = num44;
					if (!flag28)
					{
						break;
					}
				}
			}
		}
		ScreenFont screenFont = this.text;
		bool flag29 = this.text == null;
		int num45 = (int)color;
		Color32[] array7 = (Color32[])num25;
		int num46 = (int)array6;
		if (!flag29)
		{
			bool flag30 = (byte)(~(atEnd ? 1u : 0u)) != 0;
			object obj43 = !flag30;
			bool flag31 = true;
			if (obj43 == null)
			{
				bool flag32 = acceptedAt < 0f;
				object obj44 = acceptedAt ^ acceptedAt;
				object obj45 = acceptedAt & obj44;
				bool flag33 = (nint)obj45 < 0;
				bool flag34 = flag32 == flag33;
				flag31 = flag34;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
			double num15 = 0.0;
			int num24 = (int)px;
			int num26 = (int)prompt;
			double value4 = ((double*)(nint)num15)->m_value;
			if (flag31)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X0_v107 (System.Double)+E4]");
				bool flag35 = (nint)0 == 0;
				object obj46 = !flag35;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value4 = ((double*)(nint)num15)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X0_v107 (System.Double)+A0]");
				object obj47 = (nint)0 + (nint)64;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X0_v107 (System.Double)+E4]");
				bool flag36 = (nint)0 == 0;
				object obj48 = !flag36;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value4 = ((double*)(nint)num15)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X0_v107 (System.Double)+A0]");
				object obj47 = (nint)0 + (nint)56;
			}
			int num48 = default;
			double num47 = (double)(ref num48) + 16.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			ShiftAuth.Style s = default;
			num46 = screenFont.DrawCentred((Color32[])num24, 384, 320, 192, 299, (string)num26, ref s);
			bool flag37 = !flag31;
			object obj49 = !flag37;
			string text2 = (string)num26;
			object obj50 = (object)(&s);
			int num21 = 299;
			num45 = 192;
			num23 = 320;
			num38 = 384;
			array7 = (Color32[])num24;
			num34 = 0.0;
			num37 = (nint)(&num48);
			if (obj49 == null)
			{
				screenFont = this.text;
				int num49 = default;
				string text3 = num49.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92E8]");
				object obj51 = 0;
				string text4 = text3 + (string)obj51;
				if (this.text == null)
				{
					goto IL_1383;
				}
				int num50 = this.text.Measure(text4, 1);
				string text5 = num49.ToString();
				string text6 = text5 + (string)obj51;
				double value5 = ((double*)(nint)num15)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ X0_v100 (System.Double)+E4]");
				bool flag38 = (nint)0 == 0;
				object obj52 = !flag38;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value5 = ((double*)(nint)num15)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ X0_v100 (System.Double)+A0]");
				object obj53 = 0;
				double num51 = (double)(ref num48) + 16.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num45 = 372 - num50;
				ShiftAuth.Style s2 = default;
				num46 = screenFont.Draw(px, 384, 320, num45, 299, text6, ref s2);
				text2 = text6;
				obj50 = (object)(&s2);
				num21 = 299;
				num23 = 320;
				num24 = (int)text6;
				num38 = 384;
				array7 = px;
				num26 = (int)px;
				num34 = 0.0;
				num37 = (nint)(&num48);
			}
		}
		Hand[] array8 = hands;
		if (hands == null)
		{
			goto IL_1383;
		}
		object obj54 = array8.Length;
		if (array8.Length < 1)
		{
			goto IL_131e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj55 = 0;
		object obj56 = 0;
		while (true)
		{
			bool flag39 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54);
			object obj57 = !flag39;
			if (obj57 != null)
			{
				break;
			}
			object obj58 = (object)hands + obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v28+20]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v28+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X29_v8+21]");
				if ((nint)0 == 0 || !(acceptedAt < 0f))
				{
					goto IL_12e8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X29_v8+24]");
				num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj60 = 0;
				object obj61 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ X0_v40+E4]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X29_v8+28]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj62 = 0;
				object obj63 = obj62;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1536 @ X0_v43+E4]");
				bool flag40 = (nint)0 == 0;
				object obj64 = !flag40;
				if (obj64 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num46 = (int)obj55;
				num37 = 0.0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v49 (System.Int32)+E4]");
					bool flag41 = (nint)0 == 0;
					object obj65 = !flag41;
					if (obj65 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num46 = (int)obj55;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v49 (System.Int32)+A0]");
					object obj66 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1569 @ X8_v45+80]");
					object obj67 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1569 @ X8_v45+80]");
					if ((nint)0 == 0)
					{
						break;
					}
					double num52 = num37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v46+18]");
					if (num52 < 0.0)
					{
						int num53 = 0;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v49 (System.Int32)+E4]");
							bool flag42 = (nint)0 == 0;
							object obj68 = !flag42;
							if (obj68 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num46 = (int)obj55;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v49 (System.Int32)+A0]");
							object obj69 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1601 @ X8_v50+80]");
							object obj70 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1601 @ X8_v50+80]");
							if ((nint)0 == 0)
							{
								break;
							}
							double num54 = num37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v52+18]");
							bool flag43 = num54 < 0.0;
							object obj71 = !flag43;
							if (obj71 != null)
							{
								goto end_IL_1b77;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1601 @ X8_v50+80]");
							object obj72 = 0 + num37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ X9_v23+20]");
							object obj73 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ X9_v23+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							int num55 = num53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X9_v24+10]");
							if ((nint)num55 < (nint)0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v49 (System.Int32)+E4]");
								bool flag44 = (nint)0 == 0;
								object obj74 = !flag44;
								if (obj74 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj75 = obj55;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1608 @ X8_v65+A0]");
									object obj76 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ X8_v66+80]");
									obj70 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ X8_v66+80]");
									if ((nint)0 == 0)
									{
										break;
									}
								}
								double num56 = num37;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v52+18]");
								bool flag45 = num56 < 0.0;
								object obj77 = !flag45;
								if (obj77 != null)
								{
									goto end_IL_1b77;
								}
								object obj78 = obj70 + num37;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v53+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v53+20]");
								char c = ((string)0).get_Chars(num53);
								int num57 = c & 0xFFFF;
								Color32 color2;
								int num58;
								Color32[] buf;
								if (num57 != 111)
								{
									bool flag46 = num57 != 88;
									num38 = 0;
									array7 = (Color32[])num53;
									if (flag46)
									{
										goto IL_12b0;
									}
									object obj79 = obj55;
									int num26 = (int)px;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1668 @ X0_v68+E4]");
									bool flag47 = (nint)0 == 0;
									object obj80 = !flag47;
									if (obj80 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj79 = obj55;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1668 @ X0_v68+A0]");
									object obj81 = 0;
									num38 = (int)(acceptedAt + num53);
									num23 = (int)(num37 + num10);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ X8_v64+6C]");
									color2 = (Color32)0;
									num58 = 320;
									buf = (Color32[])num26;
								}
								else
								{
									object obj82 = obj55;
									int num26 = (int)px;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X29_v8+22]");
									object obj84;
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X0_v57+E4]");
										bool flag48 = (nint)0 == 0;
										object obj83 = !flag48;
										if (obj83 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj82 = obj55;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X0_v57+A0]");
										obj84 = (nint)0 + (nint)104;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X0_v57+E4]");
										bool flag49 = (nint)0 == 0;
										object obj85 = !flag49;
										if (obj85 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj82 = obj55;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X0_v57+A0]");
										obj84 = (nint)0 + (nint)100;
									}
									int num24 = (int)obj84;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X0_v57+E4]");
									bool flag50 = (nint)0 == 0;
									object obj86 = !flag50;
									if (obj86 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									num38 = (int)(acceptedAt + num53);
									num23 = (int)(num37 + num10);
									color2 = (Color32)num24;
									num58 = 320;
									buf = (Color32[])num26;
								}
								Put(buf, num58, num38, num23, color2);
								num45 = (int)color2;
								array7 = (Color32[])num58;
								goto IL_12b0;
							}
							goto IL_12cb;
							IL_12b0:
							num46 = (int)obj55;
							num53++;
						}
						break;
					}
					goto IL_12e8;
					IL_12cb:
					double num59 = num37 + 1.0;
					num37 = num59;
				}
			}
			goto IL_1383;
			IL_12e8:
			obj56++;
			obj54 = array8.Length;
			if ((nint)obj56 < array8.Length)
			{
				continue;
			}
			goto IL_131e;
			continue;
			end_IL_1b77:
			break;
		}
		goto IL_1391;
		IL_131e:
		if ((object)tex != null)
		{
			tex.SetPixels32(px);
			if ((object)tex != null)
			{
				tex.Apply(updateMipmaps: false);
				return;
			}
		}
		goto IL_1383;
		IL_1774:
		num = num6;
		num35 = num34;
		goto IL_1710;
	}

	private static void Put(Color32[] buf, int h, int x, int y, Color32 c)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_008e: Expected I4, but got I8
		//IL_00a8: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		if (y >= h)
		{
			return;
		}
		bool flag = x < 383;
		object obj = !flag;
		object obj2 = x - 383;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		int num = (int)(y & 0x80000000L);
		bool flag3 = num == 0;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		if (buf != null)
		{
			int num2 = ~y;
			object obj6 = num2 + h;
			object obj7 = obj6 * 384;
			object obj8 = x + obj7;
			bool flag4 = (nint)obj8 < buf.Length;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				object obj10 = (object)buf + obj8;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private int Measure(string s)
	{
		//IL_0091: Expected I4, but got Obj
		//IL_0070: Expected Obj, but got I4
		//IL_007e: Expected I4, but got Obj
		if (text != null)
		{
			return text.Measure(s, 1);
		}
		if (s != null)
		{
			object obj = s._stringLength + s._stringLength;
			return obj << 1;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private IEnumerable<string> Wrap(string body, int width)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0093: Expected I4, but got I8
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9300]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaThreads._003CWrap_003Ed__151 obj2 = default;
		obj2._002Ector(-2);
		if (obj2 != null)
		{
			object obj3 = obj2 + 56;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 48;
			obj4 = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj2._003C_003E3__width = width;
			return (IEnumerable<string>)(object)obj2;
		}
		return (IEnumerable<string>)new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
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
		bool flag2 = tex != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			object obj8 = obj;
			if (isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v31+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(tex);
				obj4 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v31+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.DestroyImmediate(tex);
				obj4 = null;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = mat != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj13 = null;
		if (!flag9)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v22+E4]");
			bool flag10 = (nint)0 == 0;
			object obj15 = !flag10;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(mat);
			obj13 = null;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v12+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (madePointer != null)
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v16+E4]");
			bool flag12 = (nint)0 == 0;
			object obj19 = !flag12;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(madePointer);
		}
	}

	public GillaTerms()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9308]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9318]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9320]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Row> list = default;
		list._002Ector();
		object obj4 = this + 80;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Hand hand = default;
		hand._002Ector();
		bool flag = hand == null;
		object obj5 = 0;
		NullReferenceException ex = default;
		if (!flag)
		{
			hand.right = false;
			object obj6 = default;
			bool flag2 = obj6 == null;
			obj5 = 0;
			if (!flag2)
			{
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				if (ex != null)
				{
					object obj8 = obj6 + 32;
					obj8 = hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Hand hand2 = default;
					hand2._002Ector();
					bool flag3 = hand2 == null;
					obj5 = 0;
					if (flag3)
					{
						goto IL_0238;
					}
					hand2.right = true;
					object obj9 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v10+40]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					if (ex != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92F8]");
						object obj10 = 0;
						object obj11 = obj6 + 40;
						obj11 = hand2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj12 = this + 88;
						obj12 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						endAt = -1f;
						held = true;
						object obj13 = this + 144;
						obj13 = obj10;
						shownAt = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						base._002Ector();
						return;
					}
				}
				goto IL_0246;
			}
		}
		goto IL_0238;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new IndexOutOfRangeException();
		IL_0238:
		ex = new NullReferenceException();
		goto IL_0246;
	}

	static GillaTerms()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_18b2: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I
		//IL_03ab: Expected Obj, but got I
		//IL_03d5: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I
		//IL_0423: Expected Obj, but got I
		//IL_043d: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_0530: Expected Obj, but got I8
		//IL_055d: Expected Obj, but got I
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected Obj, but got Unknown
		//IL_059f: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got Unknown
		//IL_0632: Expected Obj, but got I8
		//IL_065f: Expected Obj, but got I
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_06a1: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got I
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_06fa: Expected Obj, but got I
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		//IL_073c: Expected Obj, but got I4
		//IL_0752: Expected Obj, but got I
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0795: Expected Obj, but got I
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07d7: Expected Obj, but got I4
		//IL_07ed: Expected Obj, but got I
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_0830: Expected Obj, but got I
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_086a: Expected Obj, but got I8
		//IL_0897: Expected Obj, but got I
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected Obj, but got Unknown
		//IL_08d9: Expected Obj, but got I4
		//IL_08ef: Expected Obj, but got I
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0964: Expected Obj, but got I4
		//IL_097a: Expected Obj, but got I
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected Obj, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_09ef: Expected Obj, but got I4
		//IL_0a05: Expected Obj, but got I
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a48: Expected Obj, but got I
		//IL_0a58: Expected Obj, but got I
		//IL_0a68: Expected Obj, but got I
		//IL_0a78: Expected Obj, but got I
		//IL_0a88: Expected Obj, but got I
		//IL_0a98: Expected Obj, but got I
		//IL_0aa8: Expected Obj, but got I
		//IL_0ab8: Expected Obj, but got I
		//IL_0ac8: Expected Obj, but got I
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected Obj, but got Unknown
		//IL_0b06: Expected Obj, but got I
		//IL_0b42: Expected Obj, but got I
		//IL_0b71: Expected Obj, but got I
		//IL_0b9b: Expected Obj, but got I
		//IL_0bca: Expected Obj, but got I
		//IL_0bf4: Expected Obj, but got I
		//IL_0c23: Expected Obj, but got I
		//IL_0c4d: Expected Obj, but got I
		//IL_0c7c: Expected Obj, but got I
		//IL_0c8c: Expected Obj, but got I
		//IL_0cb6: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I
		//IL_0cf5: Expected Obj, but got I
		//IL_0d05: Expected Obj, but got I
		//IL_0d41: Expected Obj, but got I
		//IL_0d63: Expected Obj, but got I
		//IL_0d9c: Expected Obj, but got I4
		//IL_18e3: Expected Obj, but got I
		//IL_0df6: Expected Obj, but got I
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Expected Obj, but got Unknown
		//IL_0e14: Expected Obj, but got I
		//IL_0e38: Expected Obj, but got I8
		//IL_0e6d: Expected Obj, but got I
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected Obj, but got Unknown
		//IL_0e8b: Expected Obj, but got I
		//IL_0eb7: Expected Obj, but got I4
		//IL_0ecd: Expected Obj, but got I
		//IL_0eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef2: Expected Obj, but got Unknown
		//IL_0f18: Expected Obj, but got I
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected Obj, but got Unknown
		//IL_0f36: Expected Obj, but got I
		//IL_0f5a: Expected Obj, but got I8
		//IL_0f8f: Expected Obj, but got I
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Expected Obj, but got Unknown
		//IL_0fad: Expected Obj, but got I
		//IL_0fd9: Expected Obj, but got I4
		//IL_0fef: Expected Obj, but got I
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1014: Expected Obj, but got Unknown
		//IL_103a: Expected Obj, but got I
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected Obj, but got Unknown
		//IL_1058: Expected Obj, but got I
		//IL_1084: Expected Obj, but got I4
		//IL_109a: Expected Obj, but got I
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf: Expected Obj, but got Unknown
		//IL_10e5: Expected Obj, but got I
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f3: Expected Obj, but got Unknown
		//IL_1103: Expected Obj, but got I
		//IL_112b: Expected Obj, but got I
		//IL_1186: Expected Obj, but got I
		//IL_118f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Expected Obj, but got Unknown
		//IL_11c0: Expected Obj, but got I8
		//IL_11ed: Expected Obj, but got I
		//IL_11f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Expected Obj, but got Unknown
		//IL_122f: Expected Obj, but got I4
		//IL_1245: Expected Obj, but got I
		//IL_1265: Unknown result type (might be due to invalid IL or missing references)
		//IL_126a: Expected Obj, but got Unknown
		//IL_1288: Expected Obj, but got I
		//IL_1291: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected Obj, but got Unknown
		//IL_12c2: Expected Obj, but got I8
		//IL_12ef: Expected Obj, but got I
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fd: Expected Obj, but got Unknown
		//IL_1331: Expected Obj, but got I4
		//IL_1347: Expected Obj, but got I
		//IL_1367: Unknown result type (might be due to invalid IL or missing references)
		//IL_136c: Expected Obj, but got Unknown
		//IL_138a: Expected Obj, but got I
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Expected Obj, but got Unknown
		//IL_13cc: Expected Obj, but got I4
		//IL_13e2: Expected Obj, but got I
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_1407: Expected Obj, but got Unknown
		//IL_1425: Expected Obj, but got I
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Expected Obj, but got Unknown
		//IL_1467: Expected Obj, but got I4
		//IL_147d: Expected Obj, but got I
		//IL_149d: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Expected Obj, but got Unknown
		//IL_14c0: Expected Obj, but got I
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ce: Expected Obj, but got Unknown
		//IL_14fa: Expected Obj, but got I8
		//IL_1527: Expected Obj, but got I
		//IL_1530: Unknown result type (might be due to invalid IL or missing references)
		//IL_1535: Expected Obj, but got Unknown
		//IL_1569: Expected Obj, but got I4
		//IL_157f: Expected Obj, but got I
		//IL_159f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Expected Obj, but got Unknown
		//IL_15c2: Expected Obj, but got I
		//IL_15cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d0: Expected Obj, but got Unknown
		//IL_1604: Expected Obj, but got I4
		//IL_161a: Expected Obj, but got I
		//IL_163a: Unknown result type (might be due to invalid IL or missing references)
		//IL_163f: Expected Obj, but got Unknown
		//IL_165d: Expected Obj, but got I
		//IL_1666: Unknown result type (might be due to invalid IL or missing references)
		//IL_166b: Expected Obj, but got Unknown
		//IL_169b: Expected Obj, but got I
		//IL_16ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f4: Expected Obj, but got Unknown
		//IL_1720: Expected Obj, but got I8
		//IL_1746: Unknown result type (might be due to invalid IL or missing references)
		//IL_174b: Expected Obj, but got Unknown
		//IL_177f: Expected Obj, but got I4
		//IL_1795: Expected Obj, but got I
		//IL_17b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ba: Expected Obj, but got Unknown
		//IL_17d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d6: Expected Obj, but got Unknown
		//IL_1802: Expected Obj, but got I8
		//IL_1828: Unknown result type (might be due to invalid IL or missing references)
		//IL_182d: Expected Obj, but got Unknown
		//IL_185d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9328]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+A0]");
		object obj6 = (nint)0 + (nint)16;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+A0]");
		object obj9 = (nint)0 + (nint)24;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v11+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v11+18]");
			bool flag = (nint)0 == 1;
			_ = 4294967295L;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v11+18]");
				bool flag2 = (nint)0 < (nint)2;
				object obj11 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v11+18]");
				object obj12 = -2;
				bool flag3 = obj12 == null;
				_ = 4291348680L;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag3;
				if (obj14 == null)
				{
					_ = 4287401100L;
					object obj15 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v14+A0]");
					object obj16 = (nint)0 + (nint)32;
					object obj17 = default;
					obj16 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v20+18]");
					if ((nint)0 != 0)
					{
						_ = 4291611852L;
						object obj18 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v18+A0]");
						object obj19 = (nint)0 + (nint)40;
						object obj20 = default;
						obj19 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v25+18]");
						if ((nint)0 != 0)
						{
							_ = 4281571839L;
							object obj21 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v22+A0]");
							object obj22 = (nint)0 + (nint)48;
							object obj23 = default;
							obj22 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v30+18]");
							if ((nint)0 != 0)
							{
								_ = 4284927231L;
								object obj24 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v26+A0]");
								object obj25 = (nint)0 + (nint)56;
								object obj26 = default;
								obj25 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v35+18]");
								if ((nint)0 != 0)
								{
									_ = 4284940134L;
									object obj27 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v28+A0]");
									object obj28 = (nint)0 + (nint)64;
									object obj29 = default;
									obj28 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v40+18]");
									if ((nint)0 != 0)
									{
										_ = 4288256409L;
										object obj30 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
										object obj31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v30+A0]");
										object obj32 = (nint)0 + (nint)72;
										object obj33 = default;
										obj32 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj34 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj35 = 0;
										_ = 4281545523L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj36 = 0;
										_ = 4281545523L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj37 = 0;
										_ = 4281545523L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj38 = 0;
										_ = 4288256409L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj39 = 0;
										_ = 4278190080L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj40 = 0;
										_ = 4294967295L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj41 = 0;
										_ = 4284940134L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj42 = 0;
										_ = 4278190080L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v31+A0]");
										object obj43 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E1A0]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v45+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9390]");
											object obj44 = 0;
											object obj46 = default;
											object obj45 = obj46 + 32;
											obj45 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X20_v8-8]");
											object obj47 = 0 & 0xFFFFFFFEL;
											if (obj47 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9350]");
												object obj48 = 0;
												object obj49 = obj46 + 40;
												obj49 = obj48;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X20_v10-10]");
												bool flag4 = (nint)0 < (nint)2;
												object obj50 = !flag4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X20_v10-10]");
												object obj51 = -2;
												bool flag5 = obj51 == null;
												object obj52 = ~obj50;
												object obj53 = obj52 | flag5;
												if (obj53 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93B0]");
													object obj54 = 0;
													object obj55 = obj46 + 48;
													obj55 = obj54;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X20_v12-18]");
													object obj56 = 0 & 0xFFFFFFFCL;
													if (obj56 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93F8]");
														object obj57 = 0;
														object obj58 = obj46 + 56;
														obj58 = obj57;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X20_v14-20]");
														bool flag6 = (nint)0 < (nint)4;
														object obj59 = !flag6;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X20_v14-20]");
														object obj60 = -4;
														bool flag7 = obj60 == null;
														object obj61 = ~obj59;
														object obj62 = obj61 | flag7;
														if (obj62 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93C8]");
															object obj63 = 0;
															object obj64 = obj46 + 64;
															obj64 = obj63;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X20_v16-28]");
															bool flag8 = (nint)0 < (nint)5;
															object obj65 = !flag8;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X20_v16-28]");
															object obj66 = -5;
															bool flag9 = obj66 == null;
															object obj67 = ~obj65;
															object obj68 = obj67 | flag9;
															if (obj68 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9348]");
																object obj69 = 0;
																object obj70 = obj46 + 72;
																obj70 = obj69;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X20_v18-30]");
																bool flag10 = (nint)0 < (nint)6;
																object obj71 = !flag10;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X20_v18-30]");
																object obj72 = -6;
																bool flag11 = obj72 == null;
																object obj73 = ~obj71;
																object obj74 = obj73 | flag11;
																if (obj74 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93E8]");
																	object obj75 = 0;
																	object obj76 = obj46 + 80;
																	obj76 = obj75;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X20_v20-38]");
																	object obj77 = 0 & 0xFFFFFFF8L;
																	if (obj77 != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9408]");
																		object obj78 = 0;
																		object obj79 = obj46 + 88;
																		obj79 = obj78;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X20_v22-40]");
																		bool flag12 = (nint)0 < (nint)8;
																		object obj80 = !flag12;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X20_v22-40]");
																		object obj81 = -8;
																		bool flag13 = obj81 == null;
																		object obj82 = ~obj80;
																		object obj83 = obj82 | flag13;
																		if (obj83 == null)
																		{
																			object obj84 = obj46 + 96;
																			obj84 = obj54;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X20_v24-48]");
																			bool flag14 = (nint)0 < (nint)9;
																			object obj85 = !flag14;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X20_v24-48]");
																			object obj86 = -9;
																			bool flag15 = obj86 == null;
																			object obj87 = ~obj85;
																			object obj88 = obj87 | flag15;
																			if (obj88 == null)
																			{
																				object obj89 = obj46 + 104;
																				obj89 = obj48;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X20_v26-50]");
																				bool flag16 = (nint)0 < (nint)10;
																				object obj90 = !flag16;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X20_v26-50]");
																				object obj91 = -10;
																				bool flag17 = obj91 == null;
																				object obj92 = ~obj90;
																				object obj93 = obj92 | flag17;
																				if (obj93 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9398]");
																					object obj94 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9340]");
																					object obj95 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9378]");
																					object obj96 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93D8]");
																					object obj97 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9400]");
																					object obj98 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9388]");
																					object obj99 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9370]");
																					object obj100 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93F0]");
																					object obj101 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
																					object obj102 = 0;
																					object obj103 = obj46 + 112;
																					obj103 = obj44;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					object obj104 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v54+A0]");
																					object obj105 = (nint)0 + (nint)128;
																					obj105 = obj46;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					int num = Shader.PropertyToID((string)obj94);
																					object obj106 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v55+A0]");
																					object obj107 = 0;
																					int num2 = Shader.PropertyToID((string)obj95);
																					object obj108 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v57+A0]");
																					object obj109 = 0;
																					int num3 = Shader.PropertyToID((string)obj96);
																					object obj110 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v59+A0]");
																					object obj111 = 0;
																					int num4 = Shader.PropertyToID((string)obj97);
																					object obj112 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v61+A0]");
																					object obj113 = 0;
																					int num5 = Shader.PropertyToID((string)obj98);
																					object obj114 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v63+A0]");
																					object obj115 = 0;
																					int num6 = Shader.PropertyToID((string)obj99);
																					object obj116 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ X8_v65+A0]");
																					object obj117 = 0;
																					int num7 = Shader.PropertyToID((string)obj100);
																					object obj118 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v67+A0]");
																					object obj119 = 0;
																					int num8 = Shader.PropertyToID((string)obj101);
																					object obj120 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X8_v69+A0]");
																					object obj121 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9360]");
																					object obj122 = 0;
																					int num9 = Shader.PropertyToID((string)obj122);
																					object obj123 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v73+A0]");
																					object obj124 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
																					object obj125 = 0;
																					int num10 = Shader.PropertyToID((string)obj125);
																					object obj126 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v77+A0]");
																					object obj127 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F98]");
																					object obj128 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																					List<UnityEngine.XR.InputDevice> list = default;
																					list._002Ector();
																					object obj129 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v83+A0]");
																					object obj130 = (nint)0 + (nint)176;
																					obj130 = list;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9330]");
																					object obj131 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																					object obj132 = obj102;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v87+E4]");
																					bool flag18 = (nint)0 == 0;
																					object obj133 = !flag18;
																					if (obj133 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																						obj132 = obj102;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
																					object obj134 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X0_v98+18]");
																					if ((nint)0 != 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v87+A0]");
																						object obj135 = 0;
																						object obj137 = default;
																						object obj136 = obj137 + 32;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X8_v88+8]");
																						obj136 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X20_v30-8]");
																						object obj138 = 0 & 0xFFFFFFFEL;
																						if (obj138 != null)
																						{
																							object obj139 = obj102;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v91+A0]");
																							object obj140 = 0;
																							object obj141 = obj137 + 40;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v92+18]");
																							obj141 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X20_v32-10]");
																							bool flag19 = (nint)0 < (nint)2;
																							object obj142 = !flag19;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X20_v32-10]");
																							object obj143 = -2;
																							bool flag20 = obj143 == null;
																							object obj144 = ~obj142;
																							object obj145 = obj144 | flag20;
																							if (obj145 == null)
																							{
																								object obj146 = obj102;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X8_v95+A0]");
																								object obj147 = 0;
																								object obj148 = obj137 + 48;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v96+30]");
																								obj148 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X20_v34-18]");
																								object obj149 = 0 & 0xFFFFFFFCL;
																								if (obj149 != null)
																								{
																									object obj150 = obj102;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X8_v99+A0]");
																									object obj151 = 0;
																									object obj152 = obj137 + 56;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X8_v100+28]");
																									obj152 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X20_v36-20]");
																									bool flag21 = (nint)0 < (nint)4;
																									object obj153 = !flag21;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X20_v36-20]");
																									object obj154 = -4;
																									bool flag22 = obj154 == null;
																									object obj155 = ~obj153;
																									object obj156 = obj155 | flag22;
																									if (obj156 == null)
																									{
																										object obj157 = obj102;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v103+A0]");
																										object obj158 = 0;
																										object obj159 = obj137 + 64;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v104+40]");
																										obj159 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X20_v38-28]");
																										bool flag23 = (nint)0 < (nint)5;
																										object obj160 = !flag23;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X20_v38-28]");
																										object obj161 = -5;
																										bool flag24 = obj161 == null;
																										object obj162 = ~obj160;
																										object obj163 = obj162 | flag24;
																										if (obj163 == null)
																										{
																											object obj164 = obj102;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v107+A0]");
																											object obj165 = 0;
																											object obj166 = obj137 + 72;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ X8_v108+38]");
																											obj166 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											object obj167 = obj2;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v110+A0]");
																											object obj168 = (nint)0 + (nint)184;
																											obj168 = obj137;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v117+18]");
																											if ((nint)0 != 0)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9380]");
																												object obj169 = 0;
																												object obj171 = default;
																												object obj170 = obj171 + 32;
																												obj170 = obj169;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X20_v40-8]");
																												object obj172 = 0 & 0xFFFFFFFEL;
																												if (obj172 != null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9358]");
																													object obj173 = 0;
																													object obj174 = obj171 + 40;
																													obj174 = obj173;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X20_v42-10]");
																													bool flag25 = (nint)0 < (nint)2;
																													object obj175 = !flag25;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X20_v42-10]");
																													object obj176 = -2;
																													bool flag26 = obj176 == null;
																													object obj177 = ~obj175;
																													object obj178 = obj177 | flag26;
																													if (obj178 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93B8]");
																														object obj179 = 0;
																														object obj180 = obj171 + 48;
																														obj180 = obj179;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X20_v44-18]");
																														object obj181 = 0 & 0xFFFFFFFCL;
																														if (obj181 != null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93E0]");
																															object obj182 = 0;
																															object obj183 = obj171 + 56;
																															obj183 = obj182;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X20_v46-20]");
																															bool flag27 = (nint)0 < (nint)4;
																															object obj184 = !flag27;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X20_v46-20]");
																															object obj185 = -4;
																															bool flag28 = obj185 == null;
																															object obj186 = ~obj184;
																															object obj187 = obj186 | flag28;
																															if (obj187 == null)
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93A0]");
																																object obj188 = 0;
																																object obj189 = obj171 + 64;
																																obj189 = obj188;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X20_v48-28]");
																																bool flag29 = (nint)0 < (nint)5;
																																object obj190 = !flag29;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X20_v48-28]");
																																object obj191 = -5;
																																bool flag30 = obj191 == null;
																																object obj192 = ~obj190;
																																object obj193 = obj192 | flag30;
																																if (obj193 == null)
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9368]");
																																	object obj194 = 0;
																																	object obj195 = obj171 + 72;
																																	obj195 = obj194;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X20_v50-30]");
																																	bool flag31 = (nint)0 < (nint)6;
																																	object obj196 = !flag31;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X20_v50-30]");
																																	object obj197 = -6;
																																	bool flag32 = obj197 == null;
																																	object obj198 = ~obj196;
																																	object obj199 = obj198 | flag32;
																																	if (obj199 == null)
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93D0]");
																																		object obj200 = 0;
																																		object obj201 = obj171 + 80;
																																		obj201 = obj200;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X20_v52-38]");
																																		object obj202 = 0 & 0xFFFFFFF8L;
																																		if (obj202 != null)
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93C0]");
																																			object obj203 = 0;
																																			object obj204 = obj171 + 88;
																																			obj204 = obj203;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X20_v54-40]");
																																			bool flag33 = (nint)0 < (nint)8;
																																			object obj205 = !flag33;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X20_v54-40]");
																																			object obj206 = -8;
																																			bool flag34 = obj206 == null;
																																			object obj207 = ~obj205;
																																			object obj208 = obj207 | flag34;
																																			if (obj208 == null)
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9338]");
																																				object obj209 = 0;
																																				object obj210 = obj171 + 96;
																																				obj210 = obj209;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X20_v56-48]");
																																				bool flag35 = (nint)0 < (nint)9;
																																				object obj211 = !flag35;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X20_v56-48]");
																																				object obj212 = -9;
																																				bool flag36 = obj212 == null;
																																				object obj213 = ~obj211;
																																				object obj214 = obj213 | flag36;
																																				if (obj214 == null)
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93A8]");
																																					object obj215 = 0;
																																					object obj216 = obj171 + 104;
																																					obj216 = obj215;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																					object obj217 = obj2;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v133+A0]");
																																					object obj218 = (nint)0 + (nint)192;
																																					obj218 = obj171;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v143+18]");
																																					if ((nint)0 != 0)
																																					{
																																						object obj220 = default;
																																						object obj219 = obj220 + 32;
																																						obj219 = obj179;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X20_v58-8]");
																																						object obj221 = 0 & 0xFFFFFFFEL;
																																						if (obj221 != null)
																																						{
																																							object obj222 = obj220 + 40;
																																							obj222 = obj182;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X20_v60-10]");
																																							bool flag37 = (nint)0 < (nint)2;
																																							object obj223 = !flag37;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X20_v60-10]");
																																							object obj224 = -2;
																																							bool flag38 = obj224 == null;
																																							object obj225 = ~obj223;
																																							object obj226 = obj225 | flag38;
																																							if (obj226 == null)
																																							{
																																								object obj227 = obj220 + 48;
																																								obj227 = obj188;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X20_v62-18]");
																																								object obj228 = 0 & 0xFFFFFFFCL;
																																								if (obj228 != null)
																																								{
																																									object obj229 = obj220 + 56;
																																									obj229 = obj194;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																									object obj230 = obj2;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v138+A0]");
																																									object obj231 = (nint)0 + (nint)200;
																																									obj231 = obj220;
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
}
