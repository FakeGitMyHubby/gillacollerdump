using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class GillaBoltShop : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public Vector3 mouth;

		internal void _003CSprung_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			//IL_0035: Expected F4, but got VT
			//IL_0035: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplatter.Around((Vector3)0, (float)mouth);
		}
	}

	public class Item
	{
		public string name;

		public string label;

		public string line1;

		public string line2;

		public int price;

		public float tileSize = 1f;
	}

	private class Tile
	{
		public GameObject root;

		public GameObject model;

		public float pop;

		public float k = 1f;

		public float kV;

		public Vector2 lean;

		public Vector2 leanV;
	}

	public static readonly Item[] Catalog;

	public const float SellsBack = default(float);

	public Renderer screen;

	public Transform tray;

	public Transform[] fingertips;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip buySound;

	public AudioClip denySound;

	public AudioClip clickSound;

	public AudioClip hoverSound;

	public AudioClip fillSound;

	public float wakeRange;

	public float buyEvery;

	public PressKey buyKey;

	public Renderer buyCap;

	public PressKey nextKey;

	public Renderer nextCap;

	public AudioClip nextSound;

	private const int W = default(int);

	private const int H = default(int);

	private const int GridX = default(int);

	private const int GridY = default(int);

	private const int TileW = default(int);

	private const int TileH = default(int);

	private const int TileGap = default(int);

	private const int Cols = default(int);

	private const int Rows = default(int);

	private static readonly RectInt InfoRect;

	private static readonly RectInt WalletRect;

	private static readonly RectInt ButtonRect;

	private static readonly int BaseMap;

	private static readonly Color32 Black;

	private static readonly Color32 Scan;

	private static readonly Color32 Line;

	private static readonly Color32 Dim;

	private static readonly Color32 Dark;

	private static readonly Color32 Bright;

	private static readonly Color32 Warn;

	private static readonly Color32 Grey;

	private static readonly Color32[] Plain;

	private static readonly Color32[] Picked;

	private static readonly Color32[] DimText;

	private static readonly Color32[] Warning;

	private static readonly Color32[] DarkText;

	private static readonly Color32[] BoltText;

	private static readonly Color32 BoltTag;

	private static readonly Color32 BoltTagPicked;

	private const float PopSeconds = default(float);

	private const float PopStagger = default(float);

	private const float GlideRate = default(float);

	private const float ModelSize = default(float);

	private const float ModelOut = default(float);

	private const float ModelDown = default(float);

	private const float ModelTilt = default(float);

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private Transform tileRoot;

	private readonly List<Tile> tiles;

	private int selected;

	private float awake;

	private float holdFill;

	private float nextBuy;

	private float pressFlash;

	private float bannerUntil;

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

	private int shownBolts;

	public int Selected => selected;

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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
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

	public static int SellBack(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
		//IL_02a9: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_0347: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_01e9: Invalid comparison between Obj and F8
		//IL_01ab: Invalid comparison between Obj and F8
		//IL_03b8: Invalid comparison between F8 and I4
		//IL_03c7: Invalid comparison between F8 and I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e8: Expected Obj, but got F8
		//IL_041d: Expected Obj, but got I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_038c: Expected Obj, but got I4
		//IL_027a: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 == null)
		{
			goto IL_028d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X20_v3+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X20_v3+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0135;
		}
		object obj7 = obj4 + 32;
		object obj8 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			object obj9 = !flag2;
			if (obj9 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X22_v6+v110 @ X21_v8*8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X22_v6+v110 @ X21_v8*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X23_v7+10]");
				bool flag3 = (string)0 == name;
				bool flag4 = !flag3;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X20_v3+18]");
					obj6 = 0;
					obj8++;
					object obj12 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X20_v3+18]");
					if ((nint)obj12 < 0)
					{
						continue;
					}
					goto IL_0135;
				}
				goto IL_0143;
			}
			goto IL_028d;
		}
		goto IL_029b;
		IL_029b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_028d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_029b;
		IL_039f:
		double num2;
		double num = num2 - 1.0;
		bool flag5 = num < 0.0;
		bool flag6 = num == 0.0;
		object obj13 = num2 ^ 1;
		object obj14 = num2 ^ num;
		object obj15 = obj13 & obj14;
		bool flag7 = (nint)obj15 < 0;
		bool flag8 = flag5 == flag7;
		object obj16 = !flag6;
		object obj17 = flag8 & obj16;
		object obj18 = ~obj17;
		if (obj18 == null)
		{
			return (int)num2;
		}
		return 1;
		IL_0143:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X23_v7+30]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		object obj19 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v15+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num4;
		double num5 = default;
		if ((nint)obj19 < 0)
		{
			if (obj19 == (object)(-0.5))
			{
				num4 = -1.0;
				num2 = num5;
				goto IL_0355;
			}
			num2 = (double)obj19 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (obj19 == (object)0.5)
			{
				num4 = 1.0;
				num2 = num5;
				goto IL_0355;
			}
			num2 = (double)obj19 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_039f;
		IL_0355:
		double num6 = num2 + num4;
		object obj23 = num2 & 1;
		bool flag10 = obj23 == null;
		object obj24 = !flag10;
		if (obj24 != null)
		{
			num2 = num6;
		}
		goto IL_039f;
		IL_0135:
		return 0;
	}

	public static bool Sells(string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c8: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_0123: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC48]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC50]");
			object obj5 = 0;
			object obj6 = obj2 + 16;
			obj6 = label;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v9+A0]");
			object array = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Predicate<System.__Canon> predicate = default;
			predicate._002Ector(obj2, (IntPtr)obj5);
			return Array.Exists((System.__Canon[])array, predicate);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static GameObject PrefabOf(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_0295: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaSpawnables gillaSpawnables = GillaSpawnables.Get();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = gillaSpawnables == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		GameObject result = null;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC68]");
			object obj5 = 0;
			object obj6;
			if (name == (string)obj5)
			{
				if ((object)gillaSpawnables == null)
				{
					goto IL_02f8;
				}
				obj6 = gillaSpawnables + 24;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC70]");
				object obj7 = 0;
				if (name == (string)obj7)
				{
					if ((object)gillaSpawnables == null)
					{
						goto IL_02f8;
					}
					obj6 = gillaSpawnables + 48;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC60]");
					object obj8 = 0;
					if (name == (string)obj8)
					{
						if ((object)gillaSpawnables == null)
						{
							goto IL_02f8;
						}
						obj6 = gillaSpawnables + 40;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC58]");
						object obj9 = 0;
						if (name == (string)obj9)
						{
							if ((object)gillaSpawnables == null)
							{
								goto IL_02f8;
							}
							obj6 = gillaSpawnables + 64;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC78]");
							object obj10 = 0;
							if (name == (string)obj10)
							{
								if ((object)gillaSpawnables == null)
								{
									goto IL_02f8;
								}
								obj6 = gillaSpawnables + 72;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC80]");
								object obj11 = 0;
								bool flag4 = name == (string)obj11;
								bool flag5 = !flag4;
								result = null;
								if (flag5)
								{
									goto IL_0347;
								}
								if ((object)gillaSpawnables == null)
								{
									goto IL_02f8;
								}
								obj6 = gillaSpawnables + 80;
							}
						}
					}
				}
			}
			result = (GameObject)obj6;
		}
		goto IL_0347;
		IL_02f8:
		return (GameObject)(object)new NullReferenceException();
		IL_0347:
		return result;
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
		//IL_0588: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_025b: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got I
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0471: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I
		//IL_04ec: Expected I, but got Obj
		//IL_0501: Expected Obj, but got I
		//IL_052b: Expected Obj, but got I4
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
		bool flag2 = titleFont != null;
		bool flag3 = !flag2;
		int num = 0;
		ScreenFont screenFont = null;
		int num2;
		UnityEngine.Object obj4;
		TextAsset textAsset;
		if (!flag3)
		{
			textAsset = titleFont;
			bool flag4 = (object)titleFont == null;
			num2 = 0;
			obj4 = null;
			if (flag4)
			{
				goto IL_0553;
			}
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			num = 0;
			screenFont = screenFont2;
		}
		object obj6 = this + 184;
		obj6 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X21_v4-78]");
		bool flag6 = (UnityEngine.Object)0 != null;
		bool flag7 = !flag6;
		int num3 = 0;
		ScreenFont screenFont3 = null;
		if (!flag7)
		{
			textAsset = textFont;
			bool flag8 = (object)textFont == null;
			num2 = 0;
			obj4 = null;
			if (flag8)
			{
				goto IL_0553;
			}
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			num3 = 0;
			screenFont3 = screenFont4;
		}
		object obj10 = this + 192;
		obj10 = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v18+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v7-A0]");
		bool flag10 = (UnityEngine.Object)0 == null;
		bool flag11 = !flag10;
		object obj13 = !flag11;
		if (obj13 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Texture2D texture2D = default;
		texture2D._002Ector(512, 288, (TextureFormat)4, mipChain: true);
		bool flag12 = (object)texture2D == null;
		num2 = 288;
		obj4 = (UnityEngine.Object)512;
		textAsset = (TextAsset)(object)texture2D;
		if (!flag12)
		{
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC90]");
			object obj15 = 0;
			texture2D.name = (string)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v28+E4]");
			bool flag13 = (nint)0 == 0;
			object obj18 = !flag13;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			bool flag14 = !isPlaying;
			object obj19 = !flag14;
			object obj20 = ~obj19;
			HideFlags hideFlags = ((obj20 != null) ? ((HideFlags)52) : ((HideFlags)0));
			texture2D.hideFlags = hideFlags;
			object obj21 = this + 160;
			obj21 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj23 = this + 168;
			object obj24 = default;
			obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			awake = 0f;
			Draw();
			object obj25 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v42+E4]");
			bool flag15 = (nint)0 == 0;
			object obj26 = !flag15;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC88]");
				object obj28 = 0;
				Action action = default;
				action._002Ector(this, (IntPtr)obj28);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj29 = 0;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v48+E4]");
				bool flag16 = (nint)0 == 0;
				object obj31 = !flag16;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Coins.Changed += action;
			}
			return;
		}
		goto IL_0553;
		IL_0553:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E48");
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC88]");
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

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bce: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I4
		//IL_04b5: Expected Obj, but got I4
		//IL_0566: Expected Obj, but got I4
		//IL_032b: Expected Obj, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0349: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_0667: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_052e: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected Obj, but got Unknown
		//IL_0624: Expected Obj, but got I4
		//IL_087e: Expected VT, but got I4
		//IL_087e: Expected VT, but got I4
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected Obj, but got Unknown
		//IL_0936: Expected VT, but got I4
		//IL_0946: Expected Obj, but got I
		//IL_0956: Expected Obj, but got I
		//IL_0968: Expected VT, but got I4
		//IL_0c3b: Expected Obj, but got I4
		//IL_0bec: Expected Obj, but got I
		//IL_09a7: Expected Obj, but got I4
		//IL_09b5: Expected Obj, but got I4
		//IL_09cf: Expected Obj, but got I4
		//IL_0abf: Expected Obj, but got I4
		//IL_0b39: Expected Obj, but got I
		//IL_0b49: Expected Obj, but got I
		//IL_0b83: Expected VT, but got Obj
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected Obj, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected Obj, but got Unknown
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
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+E4]");
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
		object obj7 = this + 48;
		object obj8 = obj7;
		object obj10;
		UnityEngine.Object obj11;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v6+18]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj10 = 0;
			obj11 = null;
			if (obj9 != null)
			{
				goto IL_021a;
			}
		}
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v81+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = buyKey != null;
		bool flag6 = !flag5;
		obj10 = 0;
		obj11 = null;
		if (!flag6)
		{
			PressKey pressKey = buyKey;
			if ((object)buyKey == null)
			{
				goto IL_0b8f;
			}
			obj11 = (UnityEngine.Object)(object)pressKey.fingertips;
			obj7 = pressKey.fingertips;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj10 = 0;
		}
		goto IL_021a;
		IL_021a:
		object obj14 = obj7;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v10+18]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 != null)
			{
				goto IL_0446;
			}
		}
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v74+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A68]");
		object obj18 = 0;
		obj11 = (UnityEngine.Object)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v77+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_0446;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v77+18]");
			object obj20 = ~(nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v77+18]");
			object obj21 = 0 & obj20;
			object obj22 = 0;
			while (true)
			{
				object obj23 = obj19 + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X11_v7+20]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X11_v7+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X11_v8+28]");
				obj11 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X11_v8+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X1_v6 (UnityEngine.Object)+18]");
					bool flag9 = (nint)0 == 0;
					object obj25 = !flag9;
					if (obj25 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X11_v8+28]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						goto IL_0446;
					}
				}
				obj22++;
				if (obj21 != obj22)
				{
					continue;
				}
				goto IL_0446;
			}
		}
		goto IL_0b8f;
		IL_0b8f:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_053c:
		object obj26 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v22+E4]");
		bool flag10 = (nint)0 == 0;
		object obj27 = !flag10;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = nextKey != null;
		bool flag12 = !flag11;
		object obj28 = 0;
		bool flag13 = false;
		if (flag12)
		{
			goto IL_0632;
		}
		if ((object)nextKey != null)
		{
			GameObject gameObject = nextKey.gameObject;
			if ((object)gameObject != null)
			{
				gameObject.SetActive(value: false);
				obj28 = 0;
				flag13 = false;
				goto IL_0632;
			}
		}
		goto IL_0b8f;
		IL_0632:
		object obj29 = obj4;
		object obj30 = this + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v27+E4]");
		bool flag14 = (nint)0 == 0;
		object obj31 = !flag14;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = (UnityEngine.Object)obj30 == null;
		bool flag16 = !flag15;
		UnityEngine.Object obj32 = null;
		if (!flag16)
		{
			obj32 = nextSound;
			clickSound = nextSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCA8]");
		object obj34 = 0;
		GameObject gameObject2 = default;
		gameObject2._002Ector((string)obj34);
		if ((object)gameObject2 != null)
		{
			Transform transform = gameObject2.transform;
			object obj35 = this + 200;
			obj35 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform parent = base.transform;
			if (obj35 != null)
			{
				((Transform)obj35).SetParent(parent, false);
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
										if (obj35 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
											object obj37 = default;
											object obj36 = 0 / obj37;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
											object obj38 = default;
											double num = 1.0 / (double)obj38;
											((Transform)obj35).localScale = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
											object obj39 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCA0]");
											object obj40 = 0;
											bool flag17 = false;
											Vector3 vector = (Vector3)0;
											int num2 = 0;
											while (true)
											{
												object obj41 = obj39;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v54+E4]");
												bool flag18 = (nint)0 == 0;
												object obj42 = !flag18;
												if (obj42 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj41 = obj39;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v54+A0]");
												object obj43 = 0;
												object obj44 = obj43;
												if (obj43 == null)
												{
													break;
												}
												bool flag19 = num2 < 5;
												object obj45 = !flag19;
												object obj46 = num2 - 5;
												bool flag20 = obj46 == null;
												object obj47 = !flag20;
												object obj48 = obj45 & obj47;
												if (obj48 == null)
												{
													int num3 = num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v25+18]");
													if ((nint)num3 < (nint)0)
													{
														List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
														Tile tile = MakeTile(num2);
														if (tiles == null)
														{
															break;
														}
														System.__Canon[] items = list._items;
														object obj49 = obj40;
														int version = list._version + 1;
														list._version = version;
														if (list._items == null)
														{
															break;
														}
														bool flag21 = list._size < items.Length;
														object obj50 = !flag21;
														if (obj50 == null)
														{
															object obj51 = list._items + list._size;
															int size = list._size + 1;
															list._size = size;
															object obj52 = obj51 + 32;
															obj52 = tile;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v5+20]");
															object obj53 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v30+A8]");
															object obj54 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v31+70]");
															flag17 = false;
															((List<System.__Canon>)(object)tiles).AddWithResize((System.__Canon)(object)tile);
														}
														num2++;
														vector = (Vector3)tile;
														continue;
													}
												}
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
		}
		goto IL_0b8f;
		IL_0446:
		object obj55 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v17+E4]");
		bool flag22 = (nint)0 == 0;
		object obj56 = !flag22;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag23 = buyKey != null;
		bool flag24 = !flag23;
		object obj57 = 0;
		bool flag25 = false;
		if (flag24)
		{
			goto IL_053c;
		}
		if ((object)buyKey != null)
		{
			GameObject gameObject3 = buyKey.gameObject;
			if ((object)gameObject3 != null)
			{
				gameObject3.SetActive(value: false);
				obj57 = 0;
				flag25 = false;
				goto IL_053c;
			}
		}
		goto IL_0b8f;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_0161: Invalid comparison between F4 and I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I4
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
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = screen == null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 != null || px == null)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		Wake(deltaTime);
		float num = awake;
		if (!((double)awake < 1.0))
		{
			Touch(deltaTime);
		}
		float num2 = pressFlash;
		if (pressFlash > 0f)
		{
			num2 -= deltaTime;
			dirty = true;
			pressFlash = num2;
		}
		object obj8 = this + 248;
		bool flag5 = obj8 == null;
		UnityEngine.Object obj9 = null;
		if (!flag5)
		{
			num2 = Time.time;
			num = bannerUntil;
			bool flag6 = num2 < bannerUntil;
			obj9 = null;
			if (!flag6)
			{
				banner = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				dirty = true;
				obj9 = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int bolts = Coins.Bolts;
		if (bolts != shownBolts)
		{
			dirty = true;
		}
		ShowTiles(deltaTime);
		if (~(dirty ? 1u : 0u) == 0)
		{
			Draw();
		}
	}

	private void Wake(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I4
		//IL_04da: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I4
		//IL_037c: Expected F8, but got I4
		//IL_0621: Expected Obj, but got I4
		//IL_03bc: Expected F8, but got I4
		//IL_04f8: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_0559: Invalid comparison between F8 and I4
		//IL_056c: Expected Obj, but got F8
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_05aa: Expected Obj, but got I4
		//IL_0391: Expected F8, but got I
		//IL_0162: Unsupported input type for neg.
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_01b1: Invalid comparison between F4 and I
		//IL_0671: Expected Obj, but got I4
		//IL_0689: Invalid comparison between F4 and I4
		//IL_069a: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I4
		//IL_044c: Invalid comparison between F4 and I4
		//IL_026d: Expected F8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6;
		double num8;
		double num9;
		if (obj5 != null)
		{
			Vector3 position = ((Transform)obj5).position;
			Transform transform2 = screen.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v27+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform transform3 = screen.transform;
			float num = dt - dt;
			object obj12 = default;
			object obj11 = obj12 - obj12;
			object obj14 = default;
			object obj13 = obj14 - obj14;
			Vector3 forward = transform3.forward;
			object obj15 = obj12 * obj11;
			object obj16 = 0 - obj15;
			float num2 = num * dt;
			float num3 = (float)obj16 - num2;
			object obj17 = obj13 * obj14;
			float num4 = num3 - (float)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			if (num4 > 0f)
			{
				float num5 = num * num;
				object obj18 = obj11 * obj11;
				flag6 = wanted;
				float num6 = num5 + (float)obj18;
				object obj19 = obj13 * obj13;
				float num7 = (float)obj19 + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				if (num7 < wakeRange)
				{
					if (flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						num8 = 0.0;
						num9 = 1.0;
						goto IL_0530;
					}
					wanted = true;
					goto IL_02b0;
				}
				if (~(wanted ? 1u : 0u) == 0)
				{
					double num10 = (double)wakeRange + 1.0;
					float num11 = num7 - (float)num10;
					bool flag7 = num11 < 0f;
					flag6 = flag7;
				}
				goto IL_06e6;
			}
		}
		flag6 = false;
		goto IL_06e6;
		IL_02b0:
		List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
		int num12 = 0;
		while (num12 < list._size)
		{
			System.__Canon _Canon = list.get_Item(num12);
			list = (List<System.__Canon>)(object)tiles;
			int num13 = num12 + 1;
			int num14 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
			object obj20 = (nint)num14 * (nint)0;
			bool flag8 = tiles == null;
			object obj21 = !flag8;
			num12 = num13;
			if (obj21 == null)
			{
				throw new NullReferenceException();
			}
		}
		flag6 = true;
		goto IL_05c1;
		IL_0530:
		float num15 = dt / (float)num8;
		double num16 = num9 - (double)awake;
		bool flag9 = num16 < 0.0;
		object obj22 = num16 ^ num16;
		object obj23 = num16 & obj22;
		bool flag10 = (nint)obj23 < 0;
		float num17 = 0f - num15;
		bool flag11 = flag9 == flag10;
		object obj24 = !flag11;
		object obj25 = ~obj24;
		float num18 = ((obj25 != null) ? num15 : num17);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num19 = awake + num18;
		bool flag12 = num17 < num15;
		object obj26 = !flag12;
		float num20 = num17 - num15;
		bool flag13 = num20 == 0f;
		object obj27 = !flag13;
		object obj28 = obj26 & obj27;
		object obj29 = ~obj28;
		if (obj29 == null)
		{
			num9 = num19;
		}
		bool flag14 = num9 == (double)awake;
		awake = (float)num9;
		if (!flag14)
		{
			dirty = true;
		}
		return;
		IL_06e6:
		if (wanted != flag6)
		{
			wanted = flag6;
			if (flag6)
			{
				goto IL_02b0;
			}
			holdFill = 0f;
			num9 = 0.0;
			num8 = 0.25;
			goto IL_0530;
		}
		goto IL_05c1;
		IL_05c1:
		bool flag15 = !flag6;
		object obj30 = !flag15;
		object obj31 = ~obj30;
		num9 = ((obj31 != null) ? 0.0 : 1.0);
		object obj32 = !flag15;
		object obj33 = ~obj32;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num8 = 0.0;
		}
		else
		{
			num8 = 0.25;
		}
		goto IL_0530;
	}

	private void Touch(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0fbb: Expected Obj, but got I
		//IL_0fcb: Expected Obj, but got I
		//IL_0fdc: Expected Obj, but got I4
		//IL_0ff6: Expected Obj, but got I4
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_074e: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0a59: Expected Obj, but got I4
		//IL_1116: Expected Obj, but got I
		//IL_112e: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_0a85: Expected Obj, but got I4
		//IL_0794: Expected Obj, but got I4
		//IL_0aa9: Expected Obj, but got I4
		//IL_0bf5: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5d: Expected Obj, but got Unknown
		//IL_0acc: Invalid comparison between F4 and I4
		//IL_1163: Expected Obj, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0b3a: Invalid comparison between F4 and I4
		//IL_0b4d: Expected Obj, but got F4
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected Obj, but got Unknown
		//IL_0b8c: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I
		//IL_1364: Expected Obj, but got I4
		//IL_137c: Invalid comparison between F4 and I4
		//IL_139c: Expected Obj, but got I4
		//IL_0821: Expected Obj, but got I
		//IL_0bc3: Expected F4, but got I4
		//IL_01f5: Expected VT, but got I4
		//IL_0204: Expected VT, but got I4
		//IL_13d3: Expected F8, but got I4
		//IL_0850: Expected VT, but got I4
		//IL_0258: Invalid comparison between F4 and I4
		//IL_0267: Invalid comparison between F4 and I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got F4
		//IL_02c4: Expected Obj, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_1014: Expected Obj, but got I4
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1021: Expected Obj, but got Unknown
		//IL_1198: Expected Obj, but got I
		//IL_11c2: Expected Obj, but got I4
		//IL_08fa: Expected Obj, but got I4
		//IL_0933: Expected Obj, but got I4
		//IL_093c: Expected Obj, but got I4
		//IL_0945: Expected Obj, but got I4
		//IL_1048: Invalid comparison between F4 and I
		//IL_038d: Invalid comparison between F4 and I4
		//IL_107f: Expected Obj, but got I4
		//IL_1422: Expected Obj, but got I
		//IL_0957: Unsupported input type for neg.
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected Obj, but got Unknown
		//IL_096d: Unsupported input type for neg.
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected Obj, but got Unknown
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected Obj, but got Unknown
		//IL_03b6: Invalid comparison between F4 and I
		//IL_0615: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_065b: Expected Obj, but got I4
		//IL_03f9: Expected VT, but got F4
		//IL_11ef: Expected Obj, but got I
		//IL_121b: Expected Obj, but got I
		//IL_1242: Expected F4, but got I
		//IL_1262: Invalid comparison between F4 and I4
		//IL_1271: Invalid comparison between F4 and I4
		//IL_1287: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Expected Obj, but got Unknown
		//IL_1299: Expected Obj, but got F8
		//IL_12ce: Expected Obj, but got I4
		//IL_12d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12db: Expected Obj, but got Unknown
		//IL_0687: Expected I, but got Obj
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0a27: Expected F8, but got I
		//IL_067a: Expected I, but got Obj
		//IL_12fb: Invalid comparison between I4 and F8
		//IL_130d: Expected F4, but got I4
		//IL_059f: Expected Obj, but got I4
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_0d33: Invalid comparison between F4 and I4
		//IL_06a7: Expected Obj, but got I4
		//IL_05cc: Expected Obj, but got I4
		//IL_04da: Expected Obj, but got I4
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_050c: Expected Obj, but got I
		//IL_0e34: Expected VT, but got I4
		//IL_0e43: Expected VT, but got I4
		//IL_0ea3: Expected VT, but got F4
		//IL_0ed0: Expected Obj, but got I4
		//IL_0f71: Expected I4, but got I8
		//IL_0f13: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCD0]");
		object obj3 = 0;
		string text = (string)obj;
		object obj4 = 32;
		int num = 0;
		float num2 = dt;
		object obj5 = 17276928;
		object obj40 = default;
		object obj42 = default;
		object obj55 = default;
		float num21 = default;
		object obj72 = default;
		object obj74 = default;
		float num6 = default;
		while (true)
		{
			Transform[] array = fingertips;
			bool flag = fingertips == null;
			float num3 = num2;
			string text2;
			bool flag16;
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
						goto IL_0fa4;
					}
					object obj7 = obj2;
					object obj8 = fingertips + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v74+E4]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v74+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v60+20]");
					bool flag5 = (UnityEngine.Object)0 == null;
					bool flag6 = !flag5;
					object obj10 = !flag6;
					num3 = num2;
					obj11 = 0;
					nint num4 = unchecked((nint)null);
					if (obj10 == null)
					{
						Transform[] array2 = fingertips;
						if (fingertips != null)
						{
							bool flag7 = num < array2.Length;
							object obj12 = !flag7;
							if (obj12 != null)
							{
								goto IL_0fa4;
							}
							object obj13 = fingertips + num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v62+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v62+20]");
								Vector3 position = ((Transform)0).position;
								if ((object)tileRoot != null)
								{
									Vector3 vector = tileRoot.InverseTransformPoint((Vector3)0);
									Vector2Int at = ToPixel((Vector3)0);
									text2 = Hit(at);
									if (text2 != null)
									{
										float num5 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF44]");
										float num7 = num5 - 0f;
										bool flag8 = num7 < 0f;
										bool flag9 = num7 == 0f;
										float num8 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF44]");
										object obj14 = num8 ^ 0;
										object obj15 = num6 ^ num7;
										object obj16 = obj14 & obj15;
										bool flag10 = (nint)obj16 < 0;
										bool flag11 = flag8 == flag10;
										object obj17 = !flag9;
										object obj18 = flag11 & obj17;
										object obj19 = ~obj18;
										bool flag12;
										bool flag13;
										bool flag14;
										if (obj19 == null)
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
										object obj20 = !flag13;
										object obj21 = flag15 & obj20;
										object obj22 = ~obj21;
										if (obj22 == null)
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
										obj11 = 0;
										if (flag17)
										{
											goto IL_05d1;
										}
										bool[] array3 = down;
										if (down != null)
										{
											bool flag18 = num < array3.Length;
											object obj23 = !flag18;
											if (obj23 == null)
											{
												object obj24 = down + num;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X8_v69+20]");
												if ((nint)0 != 0)
												{
													string[] array4 = downOn;
													if (downOn == null)
													{
														goto IL_0f96;
													}
													bool flag19 = num < array4.Length;
													object obj25 = !flag19;
													if (obj25 != null)
													{
														goto IL_0fa4;
													}
													object obj26 = downOn + num;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v74+20]");
													if (!(text2 != (string)0) || !(text2 != (string)obj3))
													{
														goto IL_056e;
													}
												}
												Press(text2, num);
												goto IL_056e;
											}
											goto IL_0fa4;
										}
									}
								}
							}
						}
						goto IL_0f96;
					}
				}
			}
			goto IL_06e7;
			IL_056e:
			bool flag20 = text2 == (string)obj3;
			bool flag21 = !flag20;
			num3 = num2;
			obj11 = 0;
			if (!flag21)
			{
				Hold(dt, num);
				num3 = dt;
				obj11 = 0;
			}
			goto IL_05d1;
			IL_06e7:
			num++;
			obj4 += 8;
			bool flag22 = num != 2;
			num2 = num3;
			if (flag22)
			{
				continue;
			}
			bool isDeviceActive = XRSettings.isDeviceActive;
			bool flag23 = !isDeviceActive;
			object obj27 = !flag23;
			bool isPressed;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v21+A0]");
				object obj30 = 0;
				if (obj30 != null)
				{
					Camera main = Camera.main;
					object obj31 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v24+E4]");
					bool flag24 = (nint)0 == 0;
					object obj32 = !flag24;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (main != null)
					{
						Camera main2 = Camera.main;
						object obj33 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v27+A0]");
						object obj34 = 0;
						object obj35 = obj34;
						if (obj34 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v29+188]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v29+188]");
								Vector2 vector2 = ((InputControl<Vector2>)0).ReadValue();
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
											object obj36 = 0;
											object obj37 = obj36;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X0_v38+E4]");
											bool flag25 = (nint)0 == 0;
											object obj38 = !flag25;
											if (obj38 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj39 = obj40 * obj40;
											object obj41 = obj42 * obj42;
											object obj43 = obj39 + obj41;
											object obj44 = 0 * 0;
											object obj45 = obj44 + obj43;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
											bool flag26 = (nint)obj45 <= 0;
											object obj46 = 0;
											object obj47 = 0;
											object obj48 = 0;
											if (!flag26)
											{
												object obj49 = 0 - obj40;
												obj48 = obj49 / obj45;
												object obj50 = 0 - obj42;
												obj47 = obj50 / obj45;
												obj46 = 0 / obj45;
											}
											object obj51 = obj28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v41+A0]");
											object obj52 = 0;
											object obj53 = obj52;
											if (obj52 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v43+1C0]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v43+1C0]");
													isPressed = ((ButtonControl)0).isPressed;
													object obj54 = obj55 * obj48;
													object obj56 = obj42 * obj47;
													object obj57 = obj54 + obj56;
													object obj58 = obj40 * obj46;
													object obj59 = obj57 + obj58;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
													object obj60 = 0;
													object obj61 = obj60;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v48+A0]");
													object obj62 = 0;
													double num15 = (double)obj58;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
													double num16 = num15 * 0.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v49+4]");
													num6 = 0f;
													float num17 = (float)num16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v49+4]");
													float num18 = num17 - 0f;
													bool flag27 = num18 < 0f;
													bool flag28 = num18 == 0f;
													double num19 = num16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v49+4]");
													object obj63 = num19 ^ 0;
													object obj64 = num16 ^ (double)num18;
													object obj65 = obj63 & obj64;
													bool flag29 = (nint)obj65 < 0;
													bool flag30 = flag27 == flag29;
													object obj66 = !flag28;
													object obj67 = flag30 & obj66;
													object obj68 = ~obj67;
													if (obj68 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v49+4]");
														num16 = 0.0;
													}
													bool flag31 = !(0.0 < num16);
													num3 = 0f;
													if (flag31)
													{
														object obj69 = obj40 * obj48;
														object obj70 = obj42 * obj47;
														float num20 = num21 * (float)obj48;
														object obj71 = obj72 * obj47;
														object obj73 = obj69 + obj70;
														num6 = num20 + (float)obj71;
														float num22 = (float)obj74 * (float)obj46;
														object obj75 = 0 * obj46;
														object obj76 = obj73 + obj75;
														num16 = (double)num6 + (double)num22;
														double num23 = (double)obj76 - num16;
														num3 = (float)num23 / (float)obj59;
														bool flag32 = !(num3 > 0f);
														object obj77 = obj72;
														object obj78 = obj74;
														float num24 = num21;
														if (!flag32)
														{
															bool flag33 = !((double)num3 < 6.0);
															obj77 = obj72;
															obj78 = obj74;
															num24 = num21;
															num16 = 6.0;
															if (!flag33)
															{
																if ((object)tileRoot != null)
																{
																	float num25 = (float)obj40 * num3;
																	num22 = (float)obj42 * num3;
																	float num26 = (float)obj55 * num3;
																	num6 = (float)obj74 + num25;
																	num16 = (double)obj72 + (double)num22;
																	num3 = num21 + num26;
																	Vector3 vector3 = tileRoot.InverseTransformPoint((Vector3)0);
																	Vector2Int at2 = ToPixel((Vector3)0);
																	string text3 = Hit(at2);
																	if (text3 != null)
																	{
																		if (text3._stringLength >= 1)
																		{
																			overAt = (Vector3)num3;
																			text = text3;
																		}
																		bool flag34 = !isPressed;
																		obj77 = obj72;
																		obj78 = obj74;
																		num24 = num21;
																		if (!flag34)
																		{
																			bool flag35 = (byte)(~(mouseDown ? 1u : 0u)) != 0;
																			object obj79 = !flag35;
																			if (obj79 == null && text3._stringLength >= 1)
																			{
																				Press(text3, -1);
																			}
																			bool flag36 = text3 == (string)obj3;
																			bool flag37 = !flag36;
																			obj77 = obj72;
																			obj78 = obj74;
																			num24 = num21;
																			if (!flag37)
																			{
																				Hold(dt, -1);
																				obj77 = obj72;
																				obj78 = obj74;
																				num24 = num21;
																				num3 = dt;
																			}
																		}
																		goto IL_0a2c;
																	}
																}
																goto IL_0f96;
															}
														}
													}
													goto IL_0a2c;
												}
											}
										}
									}
								}
							}
						}
						goto IL_0f96;
					}
				}
			}
			goto IL_10dd;
			IL_05d1:
			bool[] array5 = down;
			if (down == null)
			{
				goto IL_0f96;
			}
			bool flag38 = num < array5.Length;
			object obj80 = !flag38;
			if (obj80 == null)
			{
				object obj81 = down + num;
				bool flag39 = !flag16;
				string[] array6 = downOn;
				object obj82 = !flag39;
				object obj83 = ~obj82;
				if (obj83 == null)
				{
					nint num4 = (nint)text2;
				}
				else
				{
					nint num4 = (nint)obj;
				}
				if (downOn == null)
				{
					goto IL_0f96;
				}
				bool flag40 = num < array6.Length;
				object obj84 = !flag40;
				if (obj84 == null)
				{
					obj5 = downOn + num;
					object obj85 = (object)downOn + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_06e7;
				}
			}
			goto IL_0fa4;
			IL_0fa4:
			throw new IndexOutOfRangeException();
			IL_10dd:
			bool[] array7 = down;
			if (down != null)
			{
				bool flag41 = (byte)(~(array7[0] ? 1u : 0u)) != 0;
				object obj86 = !flag41;
				if (obj86 == null)
				{
					bool flag42 = (byte)(~(array7[1] ? 1u : 0u)) != 0;
					object obj87 = !flag42;
					if (obj87 == null)
					{
						bool flag43 = (byte)(~(mouseDown ? 1u : 0u)) != 0;
						object obj88 = !flag43;
						if (obj88 == null)
						{
							num3 = holdFill;
							if (holdFill > 0f)
							{
								dirty = true;
								float num24 = dt * 3f;
								float num27 = dt * 3f;
								num6 = 0f - num27;
								float num22 = 0f - holdFill;
								bool flag44 = num22 < 0f;
								object obj89 = num22 ^ num22;
								object obj90 = num22 & obj89;
								bool flag45 = (nint)obj90 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								bool flag46 = flag44 == flag45;
								object obj91 = !flag46;
								object obj92 = ~obj91;
								if (obj92 != null)
								{
									num6 = num24;
								}
								bool flag47 = num22 < num24;
								object obj93 = !flag47;
								float num28 = num22 - num24;
								bool flag48 = num28 == 0f;
								num3 += num6;
								object obj94 = !flag48;
								object obj95 = obj93 & obj94;
								object obj96 = ~obj95;
								if (obj96 != null)
								{
									num3 = 0f;
								}
								holdFill = num3;
								double num16 = 0.0;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
					object value = 0;
					bool flag49 = text.StartsWith((string)value);
					bool flag50 = !flag49;
					double num29 = num3;
					if (!flag50)
					{
						Play(hoverSound, 0.25f);
						num29 = 0.25;
					}
					object obj97 = this + 256;
					hovered = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					dirty = true;
					break;
				}
			}
			goto IL_0f96;
			IL_0f96:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0fa4;
			IL_0a2c:
			mouseDown = isPressed;
			goto IL_10dd;
		}
	}

	private string Hit(Vector2Int at)
	{
		//IL_025d: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I
		//IL_02dc: Expected VT, but got I
		//IL_02dc: Expected VT, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b6: Expected VT, but got Obj
		//IL_00d2: Expected VT, but got I8
		//IL_00f0: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_0148: Expected I, but got VT
		//IL_0155: Expected VT, but got I8
		//IL_015d: Expected I, but got VT
		//IL_016a: Expected VT, but got I8
		List<Tile> list = tiles;
		nint num;
		Vector2Int vector2Int2;
		nint num2 = default;
		Vector2Int vector2Int;
		if (tiles != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
			object obj = 0;
			vector2Int = at;
			object obj2 = 10;
			object obj3 = 0;
			object obj10;
			int num3 = default;
			do
			{
				if ((nint)obj3 < list._size)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v14+E4]");
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
						obj10 = !flag4;
						num = (nint)at;
						vector2Int2 = (Vector2Int)515396075616L;
						num2 = (nint)at;
						vector2Int = (Vector2Int)515396075616L;
						continue;
					}
					string text = num3.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
					object obj11 = 0;
					return (string)obj11 + text;
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v5+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v5+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7+28]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7+30]");
				object result;
				if (Inside((RectInt)num4, (Vector2Int)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCD0]");
					result = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					result = 0;
				}
				return (string)result;
			}
			while (obj10 != null);
		}
		else
		{
			num = num2;
			vector2Int2 = at;
			object obj = 109895680;
		}
		num2 = num;
		vector2Int = vector2Int2;
		throw new NullReferenceException();
	}

	private void Press(string thing, int finger)
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I
		//IL_0177: Expected I4, but got I8
		//IL_0191: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		//IL_00a9: Expected F4, but got I
		//IL_00be: Expected Obj, but got I
		//IL_01d2: Expected F4, but got I
		//IL_01d2: Expected F4, but got I
		object obj = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCD0]");
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
		if (obj6 == null)
		{
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
			}
		}
	}

	public void Pick(int i)
	{
		//IL_012c: Expected I4, but got I8
		//IL_0146: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I
		int num = (int)(i & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v4+A0]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6+18]");
		if ((nint)0 > (nint)i)
		{
			List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
			if (list._size > i)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCC8]");
				object obj7 = 0;
				System.__Canon _Canon = list.get_Item(i);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v11 (System.__Canon)+28]");
				double num2 = 0.0 + 9.0;
			}
			if (selected != i)
			{
				holdFill = 0f;
			}
			object obj8 = this + 248;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 1;
		}
	}

	private void Hold(float dt, int finger)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I4
		//IL_072b: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected I4, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_0637: Expected Obj, but got I4
		//IL_066f: Expected Obj, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_01ef: Invalid comparison between F4 and I4
		//IL_0230: Expected Obj, but got I4
		//IL_03e5: Invalid comparison between F4 and I4
		//IL_03f4: Invalid comparison between F4 and I4
		//IL_040c: Expected Obj, but got F8
		//IL_0419: Expected Obj, but got F4
		//IL_044e: Expected Obj, but got I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0692: Invalid comparison between F4 and I4
		//IL_04b1: Expected I4, but got I8
		//IL_04cb: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_04f4: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_038b: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+18]");
			int num = (int)(-1);
			object obj6 = selected - num;
			bool flag2 = (nint)obj6 < 0;
			int num2 = selected ^ num;
			int num3 = selected ^ obj6;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag2 == flag3;
			object obj7 = !flag4;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				num = selected;
			}
			bool flag5 = selected < 0;
			int num5 = selected ^ selected;
			int num6 = selected & num5;
			bool flag6 = num6 < 0;
			bool flag7 = flag5 == flag6;
			object obj9 = !flag7;
			object obj10 = ~obj9;
			int num7 = ((obj10 != null) ? num : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+18]");
			bool flag8 = (nint)num7 < (nint)0;
			object obj11 = !flag8;
			if (obj11 != null)
			{
				goto IL_059f;
			}
			object obj12 = obj4 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v8+20]");
			object obj14 = 0;
			object obj15 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v8+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int bolts = Coins.Bolts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v8+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X22_v4+30]");
				if ((nint)bolts >= (nint)0)
				{
					float time = Time.time;
					if (!(time < nextBuy))
					{
						float num8 = dt;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						float num9 = num8 / 0f;
						float num10 = num9 + holdFill;
						float num11 = num10 - 1f;
						bool flag10 = num11 < 0f;
						bool flag11 = num11 == 0f;
						object obj17 = (double)num10 ^ 1.0;
						object obj18 = num10 ^ num11;
						object obj19 = obj17 & obj18;
						bool flag12 = (nint)obj19 < 0;
						bool flag13 = flag10 == flag12;
						object obj20 = !flag11;
						object obj21 = flag13 & obj20;
						object obj22 = ~obj21;
						if (obj22 == null)
						{
							num10 = 1f;
						}
						holdFill = num10;
						if (holdFill == 0f)
						{
							Play(fillSound, 0.5f);
						}
						int num12 = (int)(finger & 0x80000000L);
						bool flag14 = num12 == 0;
						object obj23 = !flag14;
						if (obj23 == null)
						{
							bool flag15 = finger == 0;
							object obj24 = !flag15;
							object obj25 = ~obj24;
							XRNode node = ((obj25 != null) ? ((XRNode)4) : ((XRNode)5));
							UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
							float num13 = holdFill;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							float num14 = num13 * 0f;
							float duration = dt * 1.5f;
							float num15 = num14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							float amplitude = num15 + 0f;
							UnityEngine.XR.InputDevice inputDevice = default;
							bool flag16 = inputDevice.SendHapticImpulse(0u, amplitude, duration);
						}
						dirty = true;
						if ((double)holdFill < 1.0 && !((double)holdFill < 1.0))
						{
							bool flag17 = Buy();
						}
						return;
					}
				}
				if (holdFill != 0f)
				{
					return;
				}
				object obj26 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v14+E4]");
				bool flag18 = (nint)0 == 0;
				object obj27 = !flag18;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int bolts2 = Coins.Bolts;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X22_v4+30]");
				if ((nint)bolts2 < (nint)0)
				{
					object obj28 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v18+E4]");
					bool flag19 = (nint)0 == 0;
					object obj29 = !flag19;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int bolts3 = Coins.Bolts;
					int num16 = default;
					string text = num16.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCE0]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCD8]");
					object obj31 = 0;
					string text2 = (string)obj30 + text + (string)obj31;
					object obj32 = this + 248;
					obj32 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bannerBad = true;
					float time2 = Time.time;
					dirty = true;
					float num17 = time2 + 3f;
					bannerUntil = num17;
					AudioClip clip = denySound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					Play(clip, 0f);
					holdFill = 0.001f;
				}
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_059f;
		IL_059f:
		throw new IndexOutOfRangeException();
	}

	public unsafe bool Buy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_052a: Expected Obj, but got I4
		//IL_06a1: Expected Obj, but got I
		//IL_0500: Expected I4, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_0548: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected I4, but got Unknown
		//IL_0172: Expected Obj, but got I4
		//IL_05c6: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I
		//IL_04c9: Expected Obj, but got Ref
		//IL_02a3: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_067e: Expected F4, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_0419: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				float time = Time.time;
				if (!(time < nextBuy))
				{
					float time2 = Time.time;
					object obj6 = obj;
					float num = time2 + buyEvery;
					nextBuy = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v14+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v14+A0]");
					object obj8 = 0;
					object obj9 = obj8;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v13+18]");
						int num2 = (int)(-1);
						object obj10 = selected - num2;
						bool flag3 = (nint)obj10 < 0;
						int num3 = selected ^ num2;
						int num4 = selected ^ obj10;
						int num5 = num3 & num4;
						bool flag4 = num5 < 0;
						bool flag5 = flag3 == flag4;
						object obj11 = !flag5;
						object obj12 = ~obj11;
						if (obj12 == null)
						{
							num2 = selected;
						}
						bool flag6 = selected < 0;
						int num6 = selected ^ selected;
						int num7 = selected & num6;
						bool flag7 = num7 < 0;
						bool flag8 = flag6 == flag7;
						object obj13 = !flag8;
						object obj14 = ~obj13;
						int num8 = ((obj14 != null) ? num2 : 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v13+18]");
						bool flag9 = (nint)num8 < (nint)0;
						object obj15 = !flag9;
						if (obj15 != null)
						{
							goto IL_04f2;
						}
						object obj16 = obj8 + num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+20]");
						Item item = (Item)0;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v15+E4]");
						bool flag10 = (nint)0 == 0;
						object obj19 = !flag10;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int bolts = Coins.Bolts;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+20]");
						if ((nint)0 != 0)
						{
							object obj20 = item.price - bolts;
							string text4;
							if ((nint)obj20 > bolts)
							{
								int num9 = default;
								string text = num9.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCE0]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCD8]");
								object obj22 = 0;
								string text2 = (string)obj22;
								string text3 = (string)obj21 + text + (string)obj22;
								text4 = text3;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+20]");
								if (Spawn((Item)0, out var why))
								{
									object obj23 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v27+E4]");
									bool flag11 = (nint)0 == 0;
									object obj24 = !flag11;
									if (obj24 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Coins.SpendBolts(item.price, item.name);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCE8]");
									object obj25 = 0;
									string text5 = item.label + (string)obj25;
									object obj26 = this + 248;
									obj26 = text5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bannerBad = false;
									float time3 = Time.time;
									dirty = true;
									float num10 = time3 + 3f;
									bannerUntil = num10;
									AudioClip clip = buySound;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
									Play(clip, 0f);
									List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
									if (tiles != null)
									{
										if (selected < list._size)
										{
											System.__Canon _Canon = ((List<System.__Canon>)(object)tiles).get_Item(selected);
											if (_Canon == null)
											{
												goto IL_04e4;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v40 (System.__Canon)+28]");
											double num11 = 0.0 + 12.0;
										}
										return true;
									}
									goto IL_04e4;
								}
								string text2 = (string)(&why);
								text4 = why;
							}
							object obj27 = this + 248;
							obj27 = text4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bannerBad = true;
							float time4 = Time.time;
							dirty = true;
							float num12 = time4 + 3f;
							bannerUntil = num12;
							AudioClip clip2 = denySound;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							Play(clip2, 0f);
							goto IL_04d6;
						}
					}
					goto IL_04e4;
				}
			}
			goto IL_04d6;
		}
		goto IL_04e4;
		IL_04f2:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_04d6:
		return false;
		IL_04e4:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_04f2;
	}

	private void Say(string s, bool bad)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 248;
		obj = s;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float time = Time.time;
		_ = 1;
		float num = time + 3f;
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

	private unsafe bool Spawn(Item item, out string why)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0a24: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I
		//IL_0a4c: Expected VT, but got I
		//IL_0a5c: Expected Obj, but got I
		//IL_0a6c: Expected Obj, but got I
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected Obj, but got Unknown
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected VT, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected Obj, but got Unknown
		//IL_0ab4: Expected Obj, but got I4
		//IL_0e17: Expected Obj, but got I4
		//IL_0960: Expected Obj, but got I
		//IL_0978: Expected Obj, but got I
		//IL_0988: Expected VT, but got I
		//IL_09a5: Expected Obj, but got I
		//IL_09c2: Expected Obj, but got I
		//IL_09df: Expected VT, but got I
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected VT, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected Obj, but got Unknown
		//IL_0a0f: Expected Obj, but got I4
		//IL_0bbf: Expected Obj, but got I
		//IL_0bd7: Expected Obj, but got I
		//IL_0bdf: Expected VT, but got Obj
		//IL_0bef: Expected Obj, but got I
		//IL_0bff: Expected Obj, but got I
		//IL_0c0f: Expected VT, but got I
		//IL_0b6f: Expected Obj, but got I
		//IL_0c24: Expected Obj, but got I
		//IL_0c4e: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I4
		//IL_0ac9: Expected Obj, but got I
		//IL_0ae1: Expected Obj, but got I
		//IL_0af1: Expected Obj, but got I
		//IL_0b1a: Expected VT, but got I
		//IL_0b2a: Expected VT, but got I
		//IL_0b4a: Expected Obj, but got I
		//IL_0b5a: Expected VT, but got I
		//IL_0d90: Expected Obj, but got I4
		//IL_0e3d: Expected Obj, but got I
		//IL_0e4d: Expected Obj, but got I
		//IL_0e6f: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I
		//IL_0d07: Expected Obj, but got I
		//IL_0d1f: Expected Obj, but got I
		//IL_0d27: Expected VT, but got Obj
		//IL_0d37: Expected Obj, but got I
		//IL_0d47: Expected Obj, but got I
		//IL_0d57: Expected VT, but got I
		//IL_0dc8: Expected Obj, but got I4
		//IL_05cc: Expected Obj, but got I4
		//IL_0c6c: Expected Obj, but got I
		//IL_0c84: Expected Obj, but got I
		//IL_0c94: Expected VT, but got I
		//IL_0ca4: Expected Obj, but got I
		//IL_0cd5: Expected Obj, but got I
		//IL_0ce5: Expected VT, but got I
		//IL_0cf2: Expected Obj, but got Ref
		//IL_05f9: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_0580: Expected Obj, but got I
		//IL_0740: Expected Obj, but got I
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected Obj, but got Unknown
		//IL_0889: Expected Obj, but got I
		//IL_078d: Expected Obj, but got I
		//IL_079a: Expected VT, but got Obj
		//IL_07aa: Expected Obj, but got I
		//IL_07b7: Expected VT, but got Obj
		//IL_07dc: Expected VT, but got Ref
		//IL_07dc: Expected VT, but got I4
		//IL_080a: Expected Obj, but got I4
		//IL_0862: Expected Obj, but got I
		ref string reference = ref *(string*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = item == null;
		ref string reference2 = ref why;
		UnityEngine.Object obj = null;
		GillaBoltShop gillaBoltShop = this;
		object obj4;
		GameObject gameObject;
		object obj8;
		Vector3 vector3;
		object obj16;
		object obj18;
		Vector3 vector6;
		object obj31;
		object obj32;
		Vector3 vector7;
		Vector3 vector = default;
		object obj19 = default;
		object obj17 = default;
		Vector3 vector4 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			gameObject = PrefabOf(item.name);
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (gameObject == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCF0]");
				obj8 = 0;
				ref string reference3 = ref *(string*)null;
				goto IL_0dd6;
			}
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v24+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14;
			object obj15;
			Vector3 vector2;
			if (tray != null)
			{
				bool flag5 = (object)tray == null;
				reference2 = ref *(string*)null;
				obj = null;
				gillaBoltShop = this;
				if (flag5)
				{
					goto IL_08a6;
				}
				Vector3 position = tray.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v84+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v85+20]");
				vector = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v85+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				obj14 = num * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v85+1C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				obj15 = num2 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v85+20]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				vector2 = (Vector3)(num3 * 0);
				vector3 = vector4 + obj14;
				obj16 = obj17 + obj15;
				obj18 = obj19 + vector2;
				object obj20 = 0;
			}
			else
			{
				Transform transform = base.transform;
				bool flag6 = (object)transform == null;
				reference2 = ref *(string*)null;
				obj = null;
				gillaBoltShop = this;
				if (flag6)
				{
					goto IL_08a6;
				}
				Vector3 position2 = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj21 = 0;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v77+A0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v78+18]");
				vector2 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v78+1C]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v78+20]");
				obj15 = 0;
				object obj24 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v78+20]");
				obj18 = obj24 + 0;
				Vector3 vector5 = vector4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v78+18]");
				vector3 = vector5 + 0;
				object obj25 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v78+1C]");
				obj16 = obj25 + 0;
				object obj20 = 0;
			}
			object obj26 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v29+E4]");
			bool flag7 = (nint)0 == 0;
			object obj27 = !flag7;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 forward = default;
			Vector3 upwards = default;
			if (tray != null)
			{
				bool flag8 = (object)tray == null;
				obj19 = obj15;
				obj17 = obj14;
				vector4 = vector2;
				reference2 = ref *(string*)null;
				obj = null;
				gillaBoltShop = this;
				if (flag8)
				{
					goto IL_08a6;
				}
				Vector3 right = tray.right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v70+A0]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v71+20]");
				obj14 = 0;
				Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
				forward = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v71+18]");
				upwards = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v71+18]");
				vector2 = (Vector3)0;
				vector6 = vector;
				obj31 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v71+20]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v71+18]");
				vector7 = (Vector3)0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
				object obj33 = 0;
				object obj34 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v63+A0]");
				object obj35 = 0;
				vector7 = (Vector3)obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v64+4]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v64+8]");
				obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v64+C]");
				vector6 = (Vector3)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC80]");
			object obj36 = 0;
			bool flag9 = item.name == (string)obj36;
			bool flag10 = !flag9;
			ref string reference4 = ref *(string*)null;
			UnityEngine.Object obj37 = (UnityEngine.Object)obj36;
			if (!flag10)
			{
				object obj38 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v84+E4]");
				bool flag11 = (nint)0 == 0;
				object obj39 = !flag11;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (tray != null)
				{
					bool flag12 = (object)tray == null;
					obj19 = obj15;
					obj17 = obj14;
					vector4 = vector2;
					reference2 = ref *(string*)null;
					obj = null;
					gillaBoltShop = this;
					if (flag12)
					{
						goto IL_08a6;
					}
					Vector3 forward2 = tray.forward;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj40 = 0;
					object obj41 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v56+A0]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v57+18]");
					vector2 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v57+20]");
					obj14 = 0;
					Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
					vector6 = vector;
					obj31 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v57+20]");
					obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v57+18]");
					vector7 = (Vector3)0;
					reference4 = ref *(string*)null;
					obj37 = (UnityEngine.Object)(&upwards);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
					object obj43 = 0;
					object obj44 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v49+A0]");
					object obj45 = 0;
					vector7 = (Vector3)obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v50+4]");
					obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v50+8]");
					obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v50+C]");
					vector6 = (Vector3)0;
					reference4 = ref *(string*)null;
					obj37 = null;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj46 = 0;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v37+E4]");
			bool flag13 = (nint)0 == 0;
			object obj48 = !flag13;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj49 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v41+E4]");
			bool flag14 = (nint)0 == 0;
			object obj50 = !flag14;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj49 = obj46;
			}
			object obj51 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v41+A0]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v6+8]");
			UnityEngine.Object obj53 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v22+E4]");
			bool flag15 = (nint)0 == 0;
			object obj54 = !flag15;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v6+8]");
			bool flag16 = (UnityEngine.Object)0 != null;
			bool flag17 = !flag16;
			gillaBoltShop = null;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v6+8]");
				bool flag18 = (nint)0 == 0;
				obj19 = obj15;
				obj17 = obj14;
				vector4 = vector2;
				reference2 = ref *(string*)null;
				obj = null;
				gillaBoltShop = null;
				if (flag18)
				{
					goto IL_08a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X22_v8 (UnityEngine.Object)+B0]");
				gillaBoltShop = (GillaBoltShop)0;
			}
			object obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v45+E4]");
			bool flag19 = (nint)0 == 0;
			object obj56 = !flag19;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag20 = gillaBoltShop != null;
			bool flag21 = !flag20;
			UnityEngine.Object obj57 = null;
			if (flag21)
			{
				goto IL_05a2;
			}
			bool flag22 = (object)gillaBoltShop == null;
			obj19 = obj15;
			obj17 = obj14;
			vector4 = vector2;
			reference2 = ref *(string*)null;
			obj = null;
			if (!flag22)
			{
				bool isRunning = ((NetworkRunner)(object)gillaBoltShop).IsRunning;
				bool flag23 = !isRunning;
				obj57 = null;
				if (flag23)
				{
					goto IL_05a2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v6+8]");
				bool flag24 = (nint)0 == 0;
				obj19 = obj15;
				obj17 = obj14;
				vector4 = vector2;
				reference2 = ref *(string*)null;
				obj = null;
				if (!flag24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X22_v8 (UnityEngine.Object)+A4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B88]");
						obj8 = 0;
						obj19 = obj15;
						obj17 = obj14;
						vector4 = vector2;
						ref string reference3 = ref *(string*)null;
					}
					else
					{
						bool flag25 = (object)gameObject == null;
						obj19 = obj15;
						obj17 = obj14;
						vector4 = vector2;
						reference2 = ref *(string*)null;
						obj = null;
						if (flag25)
						{
							goto IL_08a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5358]");
						object obj58 = 0;
						ref string reference3 = ref *(string*)obj58;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
						object obj60 = default;
						object obj59 = obj60 & 1;
						if (obj59 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
							object obj61 = 0;
							Vector3? position3 = (Vector3)obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
							object obj62 = 0;
							Quaternion? quaternion3 = (Quaternion)obj62;
							NetworkObject prefab = default;
							Quaternion? quaternion4 = default;
							NetworkObject networkObject = ((NetworkRunner)(object)gillaBoltShop).Spawn(prefab, position3, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion4), (NetworkRunner.OnBeforeSpawned)null, (NetworkSpawnFlags)0);
							object obj63 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X0_v68+E4]");
							bool flag26 = (nint)0 == 0;
							object obj64 = !flag26;
							if (obj64 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)networkObject == (UnityEngine.Object)null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B98]");
								object obj65 = 0;
								reference = ref *(string*)obj65;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								goto IL_010a;
							}
							goto IL_06e3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B98]");
						obj8 = 0;
						obj19 = obj15;
						obj17 = obj14;
						vector4 = vector2;
					}
					goto IL_0dd6;
				}
			}
		}
		goto IL_08a6;
		IL_08a6:
		throw new NullReferenceException();
		IL_06e3:
		return true;
		IL_0dd6:
		reference = ref *(string*)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_010a;
		IL_05a2:
		object obj66 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v52+E4]");
		bool flag27 = (nint)0 == 0;
		object obj67 = !flag27;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
		object obj68 = 0;
		obj = (UnityEngine.Object)obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
		bool flag28 = (object)gameObject == null;
		Vector3 vector8 = vector6;
		object obj69 = obj31;
		object obj70 = obj32;
		vector = vector7;
		obj19 = obj18;
		obj17 = obj16;
		vector4 = vector3;
		reference2 = ref *(string*)null;
		if (!flag28)
		{
			string text = gameObject.name;
			UnityEngine.Object obj71 = default;
			bool flag29 = (object)obj71 == null;
			vector8 = vector6;
			obj69 = obj31;
			obj70 = obj32;
			vector = vector7;
			obj19 = obj18;
			obj17 = obj16;
			vector4 = vector3;
			reference2 = ref *(string*)null;
			obj = null;
			if (!flag29)
			{
				obj71.name = text;
				goto IL_06e3;
			}
		}
		goto IL_08a6;
		IL_010a:
		return false;
	}

	private static int PaysBack(Item item)
	{
		//IL_0218: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		if (item != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GameObject gameObject = PrefabOf(item.name);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = gameObject != null;
			bool flag4 = !flag3;
			UnityEngine.Object obj7 = null;
			UnityEngine.Object obj8 = null;
			if (!flag4)
			{
				if ((object)gameObject == null)
				{
					goto IL_020a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD00]");
				object obj9 = 0;
				obj7 = (UnityEngine.Object)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
				UnityEngine.Object obj10 = default;
				obj8 = obj10;
			}
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (obj8 != null)
			{
				if ((object)obj8 == null)
				{
					goto IL_020a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v5 (UnityEngine.Object)+39]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v5 (UnityEngine.Object)+38]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v5 (UnityEngine.Object)+28]");
						return 0;
					}
				}
			}
			return 0;
		}
		goto IL_020a;
		IL_020a:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private Tile MakeTile(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_015a: Expected VT, but got I4
		//IL_0172: Expected F8, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_0d2a: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_08e4: Expected Obj, but got I
		//IL_08f4: Expected F8, but got I
		//IL_10cd: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_1058: Expected Obj, but got I
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I4
		//IL_0998: Expected Obj, but got I
		//IL_117f: Expected Obj, but got I4
		//IL_062e: Expected Obj, but got I4
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got I
		//IL_04d1: Expected Obj, but got I
		//IL_0530: Expected Obj, but got I
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_068e: Expected Obj, but got I
		//IL_0d84: Invalid comparison between F8 and I4
		//IL_0d93: Invalid comparison between F8 and I4
		//IL_0da6: Expected Obj, but got F8
		//IL_0db3: Expected Obj, but got F8
		//IL_0de8: Expected Obj, but got I4
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected Obj, but got Unknown
		//IL_0f07: Invalid comparison between F8 and I4
		//IL_0f16: Invalid comparison between F8 and I4
		//IL_0f29: Expected Obj, but got F8
		//IL_0f36: Expected Obj, but got F8
		//IL_0f6b: Expected Obj, but got I4
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Expected Obj, but got Unknown
		//IL_101a: Expected Obj, but got I4
		//IL_103a: Expected VT, but got F8
		//IL_0a64: Expected VT, but got I4
		//IL_0742: Expected Obj, but got I4
		//IL_0758: Expected Obj, but got I
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_0a93: Expected Obj, but got I
		//IL_0ab8: Expected VT, but got I4
		//IL_080e: Expected Obj, but got I8
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected Obj, but got Unknown
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected Obj, but got Unknown
		//IL_0b09: Expected Obj, but got F8
		//IL_0b26: Expected VT, but got I4
		//IL_0b50: Expected Obj, but got I4
		//IL_088b: Expected Obj, but got I
		//IL_08c7: Expected Obj, but got I4
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected Obj, but got Unknown
		//IL_11b3: Invalid comparison between F8 and I4
		//IL_11c2: Invalid comparison between F8 and I4
		//IL_11d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d5: Expected Obj, but got Unknown
		//IL_11dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Expected Obj, but got Unknown
		//IL_1217: Expected Obj, but got I4
		//IL_121f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1224: Expected Obj, but got Unknown
		//IL_1141: Expected Obj, but got I
		//IL_1086: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Expected Obj, but got Unknown
		//IL_083f: Expected F8, but got Obj
		//IL_0b96: Expected Obj, but got I4
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Expected Obj, but got Unknown
		//IL_0bc1: Expected Obj, but got I
		//IL_0c1b: Expected Obj, but got I
		//IL_0c30: Expected Obj, but got I
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Expected Obj, but got Unknown
		//IL_0c6c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCB0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_ = 1065353216;
		object obj4 = default;
		obj4._002Ector();
		int num = default;
		string text = num.ToString();
		string text2 = (string)obj2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(text2);
		object obj5 = obj4 + 16;
		obj5 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6;
		GameObject gameObject3;
		object obj22;
		double num6;
		double num8;
		double num10;
		Vector3 euler = default;
		double num26 = default;
		double num34;
		double num35;
		if (obj5 != null)
		{
			Transform transform = ((GameObject)obj5).transform;
			if ((object)transform != null)
			{
				transform.SetParent(tileRoot, worldPositionStays: false);
				if (obj5 != null)
				{
					Transform transform2 = ((GameObject)obj5).transform;
					Vector3 vector = ModelAt(num);
					if ((object)transform2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
						obj6 = 0;
						transform2.localPosition = (Vector3)0;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
						double num2 = 0.0;
						double num3 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
						double num4 = num3 * 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v24+E4]");
						bool flag = (nint)0 == 0;
						object obj8 = !flag;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj7 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v24+A0]");
						object obj9 = 0;
						object obj10 = obj9;
						if (obj9 != null)
						{
							int num5 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v11+18]");
							bool flag2 = (nint)num5 < (nint)0;
							object obj11 = !flag2;
							if (obj11 != null)
							{
								goto IL_0ce1;
							}
							object obj12 = obj9 + num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v12+20]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v12+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v13+10]");
								GameObject gameObject2 = PrefabOf((string)0);
								object obj15 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v14+E4]");
								bool flag3 = (nint)0 == 0;
								object obj16 = !flag3;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (!(gameObject2 != null))
								{
									goto IL_0ca3;
								}
								object obj17 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v33+E4]");
								bool flag4 = (nint)0 == 0;
								object obj18 = !flag4;
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
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v37+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v37+18]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v37+20]");
												if ((nint)0 == 0)
												{
													goto IL_0cd3;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v37+20]");
												Bounds bounds = ((Renderer)0).bounds;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v37+18]");
												object obj23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v37+18]");
												bool flag5 = (nint)0 < (nint)1;
												double num7 = default;
												num6 = num7;
												double num9 = default;
												num8 = num9;
												double num11 = default;
												num10 = num11;
												object obj24 = 0;
												if (flag5)
												{
													goto IL_05be;
												}
												object obj25 = obj21 + 32;
												double num12 = num7;
												double num13 = num9;
												double num14 = num11;
												Vector3 vector2 = euler;
												object obj26 = 0;
												object obj34 = default;
												while (true)
												{
													bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
													object obj27 = !flag6;
													if (obj27 != null)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X27_v9+v253 @ X24_v11*8]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X27_v9+v253 @ X24_v11*8]");
														Bounds bounds2 = ((Renderer)0).bounds;
														double num15 = num14 - num12;
														double num16 = num12 + num14;
														double num17 = num11 - num7;
														double num18 = num11 + num7;
														double num19 = (double)euler + num9;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v37+18]");
														obj23 = 0;
														double num20 = (double)vector2 - num13;
														obj26++;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
														if (!(num15 < num17))
														{
															num15 = num17;
														}
														double num21 = num16 - num17;
														bool flag7 = num21 < 0.0;
														bool flag8 = num21 == 0.0;
														object obj28 = num16 ^ num17;
														object obj29 = num16 ^ num21;
														object obj30 = obj28 & obj29;
														bool flag9 = (nint)obj30 < 0;
														bool flag10 = flag7 == flag9;
														object obj31 = !flag8;
														object obj32 = flag10 & obj31;
														object obj33 = ~obj32;
														if (obj33 == null)
														{
															num17 = num16;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
														double num22 = num17 - num15;
														double num23 = (double)obj34 - num20;
														double num24 = num22 * 0.5;
														double num25 = num23 * 63.0;
														num26 = num15 + num24;
														double num27 = num20 + num25;
														num2 = num26 - num24;
														double num28 = num24 + num26;
														double num29 = num27 - num25;
														double num30 = num25 + num27;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
														if (!(num2 < num18))
														{
															num2 = num18;
														}
														double num31 = num28 - num18;
														bool flag11 = num31 < 0.0;
														bool flag12 = num31 == 0.0;
														object obj35 = num28 ^ num18;
														object obj36 = num28 ^ num31;
														object obj37 = obj35 & obj36;
														bool flag13 = (nint)obj37 < 0;
														bool flag14 = flag11 == flag13;
														object obj38 = !flag12;
														object obj39 = flag14 & obj38;
														object obj40 = ~obj39;
														if (obj40 == null)
														{
															num18 = num28;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
														num4 = num18 - num2;
														double num32 = num25 - num26;
														num6 = num4 * 0.5;
														num8 = num32 * 63.0;
														num10 = num2 + num6;
														double num33 = num26 + num8;
														bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
														obj24 = 0;
														num12 = num6;
														num13 = num8;
														num14 = num10;
														vector2 = (Vector3)num33;
														if (flag15)
														{
															continue;
														}
														goto IL_05be;
													}
													goto IL_0cd3;
												}
											}
											goto IL_0ce1;
										}
										object obj41 = obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v50+A0]");
										object obj42 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v51+8]");
										num34 = 0.0;
										num35 = 1.0;
										double num36 = 1.0;
										goto IL_10b3;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0cd3;
		IL_10b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C40]");
		object obj43 = 0;
		GameObject gameObject4 = default;
		gameObject4._002Ector((string)obj43);
		if ((object)gameObject4 != null)
		{
			Transform transform3 = gameObject4.transform;
			if (obj5 != null)
			{
				Transform parent = ((GameObject)obj5).transform;
				if ((object)transform3 != null)
				{
					transform3.SetParent(parent, worldPositionStays: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
					object obj44 = 0;
					GameObject gameObject5 = default;
					gameObject5._002Ector((string)obj44);
					if ((object)gameObject5 != null)
					{
						Transform transform4 = gameObject5.transform;
						if ((object)transform4 != null)
						{
							transform4.SetParent(transform3, worldPositionStays: false);
							Transform transform5 = gameObject3.transform;
							if ((object)transform5 != null)
							{
								transform5.SetParent(transform4, worldPositionStays: false);
								Transform transform6 = gameObject3.transform;
								if ((object)transform6 != null)
								{
									transform6.localRotation = (Quaternion)0;
									Transform transform7 = gameObject3.transform;
									if ((object)transform7 != null)
									{
										object obj45 = obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v36+A0]");
										object obj46 = 0;
										double num37 = num35;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v37+C]");
										double num38 = num37 * 0.0;
										transform7.localScale = (Vector3)0;
										Transform transform8 = gameObject3.transform;
										if ((object)transform8 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
											double num39 = num34 * num35;
											object obj47 = 0.0 - num39;
											object obj48 = default;
											double num40 = num38 * (double)obj48;
											transform8.localPosition = (Vector3)0;
											object obj49 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v64+E4]");
											bool flag16 = (nint)0 == 0;
											object obj50 = !flag16;
											if (obj50 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj49 = obj6;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v64+A0]");
											object obj51 = 0;
											object obj52 = obj51;
											if (obj51 != null)
											{
												int num41 = num;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v40+18]");
												bool flag17 = (nint)num41 < (nint)0;
												object obj53 = !flag17;
												if (obj53 != null)
												{
													goto IL_0ce1;
												}
												object obj54 = obj51 + num;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v41+20]");
												object obj55 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v41+20]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v42+10]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCB8]");
														object value = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v42+10]");
														if (((string)0).EndsWith((string)value))
														{
															Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
															transform4.localRotation = (Quaternion)0;
														}
														GameObject gameObject6 = transform3.gameObject;
														object obj56 = obj4 + 24;
														obj56 = gameObject6;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														goto IL_0ca3;
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
		goto IL_0cd3;
		IL_0cd3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ce1;
		IL_0ca3:
		if (obj5 != null)
		{
			((GameObject)obj5).SetActive(false);
			return (Tile)obj4;
		}
		goto IL_0cd3;
		IL_0ce1:
		return (Tile)(object)new IndexOutOfRangeException();
		IL_05be:
		object obj57 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v88+E4]");
		bool flag18 = (nint)0 == 0;
		object obj58 = !flag18;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj57 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v88+A0]");
		object obj59 = 0;
		object obj60 = obj59;
		if (obj59 != null)
		{
			int num42 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v57+18]");
			bool flag19 = (nint)num42 < (nint)0;
			object obj61 = !flag19;
			if (obj61 != null)
			{
				goto IL_0ce1;
			}
			object obj62 = obj59 + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v58+20]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v58+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj65 = default;
				if (obj65 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v90+18]");
					if ((nint)0 != 0)
					{
						double num43 = num8 + num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v90+18]");
						if ((nint)0 != 1)
						{
							object obj67 = default;
							object obj66 = obj67 + obj67;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v90+18]");
							bool flag20 = (nint)0 < (nint)2;
							object obj68 = !flag20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v90+18]");
							object obj69 = -2;
							bool flag21 = obj69 == null;
							object obj70 = ~obj68;
							object obj71 = obj70 | flag21;
							if (obj71 == null)
							{
								double num44 = num6 + num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v90+18]");
								if ((nint)0 != 3)
								{
									_ = 1008981770;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v90+18]");
									if ((nint)0 >= (nint)2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v90+18]");
										object obj72 = 0 & 0xFFFFFFFFL;
										object obj73 = obj65 + 36;
										object obj74 = obj72 - 1;
										double num45 = num43;
										bool flag26;
										do
										{
											obj73 += 4;
											double num46 = (double)obj73 - num45;
											bool flag22 = num46 < 0.0;
											bool flag23 = num46 == 0.0;
											object obj75 = obj73 ^ num45;
											object obj76 = obj73 ^ num46;
											object obj77 = obj75 & obj76;
											bool flag24 = (nint)obj77 < 0;
											bool flag25 = flag22 == flag24;
											object obj78 = !flag23;
											object obj79 = flag25 & obj78;
											object obj80 = ~obj79;
											if (obj80 == null)
											{
												num45 = (double)obj73;
											}
											obj74--;
											flag26 = (nint)obj74 != 1;
											num43 = num45;
										}
										while (flag26);
									}
									Transform transform9 = gameObject3.transform;
									if ((object)transform9 == null)
									{
										goto IL_0cd3;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v59+34]");
									nint num47 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD10]");
									object obj81 = num47 * 0;
									double num36 = (double)obj81 / num43;
									Vector3 position = transform9.position;
									num34 = num10 - num26;
									num35 = num36;
									object obj20 = 0;
									goto IL_10b3;
								}
							}
						}
					}
					goto IL_0ce1;
				}
			}
		}
		goto IL_0cd3;
	}

	private static GameObject Looks(GameObject prefab)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_09ce: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_0a0d: Expected Obj, but got I
		//IL_0a1d: Expected Obj, but got I
		//IL_123b: Expected Obj, but got I4
		//IL_0a4b: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_1214: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_1141: Expected Obj, but got I
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected Obj, but got Unknown
		//IL_0a93: Expected Obj, but got I
		//IL_0ac1: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_0b06: Expected Obj, but got I4
		//IL_0b2f: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_10a1: Expected Obj, but got I
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Expected Obj, but got Unknown
		//IL_0b4e: Expected Obj, but got I
		//IL_0b8a: Expected Obj, but got I4
		//IL_0ba9: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_0c6f: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I4
		//IL_0cc8: Expected VT, but got I4
		//IL_0cf7: Expected VT, but got I4
		//IL_0d39: Expected Obj, but got I
		//IL_0d9e: Expected Obj, but got VT
		//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Expected Obj, but got Unknown
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dec: Expected Obj, but got Unknown
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected Obj, but got Unknown
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2d: Expected Obj, but got Unknown
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e54: Expected Obj, but got Unknown
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e61: Expected Obj, but got Unknown
		//IL_0ef0: Expected VT, but got Obj
		//IL_0efe: Expected VT, but got I4
		//IL_0f21: Expected Obj, but got I
		//IL_0f4f: Expected Obj, but got I4
		//IL_05f8: Expected VT, but got I4
		//IL_0fa8: Expected VT, but got I4
		//IL_0fb8: Expected Obj, but got I
		//IL_0fd8: Expected Obj, but got I
		//IL_0627: Expected VT, but got I4
		//IL_1016: Expected Obj, but got I
		//IL_1036: Expected Obj, but got I
		//IL_1083: Expected Obj, but got I4
		//IL_108c: Expected Obj, but got I4
		//IL_06c6: Expected Obj, but got VT
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected Obj, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected Obj, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected Obj, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected Obj, but got Unknown
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Obj, but got Unknown
		//IL_0818: Expected VT, but got Obj
		//IL_0826: Expected VT, but got I4
		//IL_0855: Expected Obj, but got I
		//IL_087f: Expected Obj, but got I4
		//IL_08d8: Expected VT, but got I4
		//IL_08e8: Expected Obj, but got I
		//IL_093e: Expected Obj, but got I
		//IL_09a8: Expected Obj, but got I4
		//IL_09b9: Expected Obj, but got I4
		Transform transform;
		object obj6;
		GameObject gameObject3;
		object obj10 = default;
		object obj12 = default;
		Quaternion quaternion2 = default;
		object obj18 = default;
		Quaternion rotation2 = default;
		if ((object)prefab != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C68]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C50]");
			object obj3 = 0;
			string text = prefab.name;
			string text2 = text + (string)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector(text2);
			transform = prefab.transform;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj5 = default;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v14+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v14+18]");
				bool flag = (nint)0 < (nint)1;
				GameObject gameObject2 = prefab;
				gameObject3 = gameObject;
				if (flag)
				{
					goto IL_09be;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B8]");
				object obj8 = 0;
				object obj9 = obj10;
				object obj11 = obj12;
				Quaternion quaternion = quaternion2;
				object obj14 = default;
				object obj13 = obj14;
				object obj16 = default;
				object obj15 = obj16;
				object obj17 = obj18;
				object obj20 = default;
				object obj19 = obj20;
				object obj22 = default;
				object obj21 = obj22;
				object obj24 = default;
				object obj23 = obj24;
				object obj26 = default;
				object obj25 = obj26;
				object obj28 = default;
				object obj27 = obj28;
				object obj30 = default;
				object obj29 = obj30;
				object obj32 = default;
				object obj31 = obj32;
				object obj34 = default;
				object obj33 = obj34;
				object obj35 = 0;
				UnityEngine.Object obj40 = default;
				GameObject gameObject6 = default;
				MeshFilter meshFilter2 = default;
				MeshFilter meshFilter3 = default;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj36 = !flag2;
					if (obj36 != null)
					{
						break;
					}
					object obj37 = obj5 + obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v24+20]");
					MeshFilter meshFilter = (MeshFilter)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v24+20]");
					if ((nint)0 == 0)
					{
						goto IL_10f8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
					object obj38 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v25+E4]");
					bool flag3 = (nint)0 == 0;
					object obj39 = !flag3;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj40 == null;
					bool flag5 = !flag4;
					object obj41 = !flag5;
					obj10 = obj9;
					obj12 = obj11;
					quaternion2 = quaternion;
					obj18 = obj17;
					obj4 = 0;
					if (obj41 == null)
					{
						Mesh sharedMesh = meshFilter.sharedMesh;
						object obj42 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v28+E4]");
						bool flag6 = (nint)0 == 0;
						object obj43 = !flag6;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = sharedMesh == null;
						bool flag8 = !flag7;
						object obj44 = !flag8;
						obj10 = obj9;
						obj12 = obj11;
						quaternion2 = quaternion;
						obj18 = obj17;
						obj4 = 0;
						if (obj44 == null)
						{
							if ((object)obj40 != null)
							{
								bool flag9 = ((Renderer)obj40).enabled;
								bool flag10 = !flag9;
								obj10 = obj9;
								obj12 = obj11;
								quaternion2 = quaternion;
								obj18 = obj17;
								obj4 = 0;
								if (flag10)
								{
									goto IL_1131;
								}
								GameObject gameObject4 = ((Component)obj40).gameObject;
								if ((object)gameObject4 != null)
								{
									bool activeSelf = gameObject4.activeSelf;
									bool flag11 = !activeSelf;
									obj10 = obj9;
									obj12 = obj11;
									quaternion2 = quaternion;
									obj18 = obj17;
									obj4 = 0;
									if (flag11)
									{
										goto IL_1131;
									}
									GameObject gameObject5 = ((Component)obj40).gameObject;
									if ((object)gameObject5 != null)
									{
										string text3 = gameObject5.name;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C60]");
										object obj45 = 0;
										bool flag12 = text3 == (string)obj45;
										bool flag13 = !flag12;
										object obj46 = !flag13;
										obj10 = obj9;
										obj12 = obj11;
										quaternion2 = quaternion;
										obj18 = obj17;
										obj4 = 0;
										if (obj46 != null)
										{
											goto IL_1131;
										}
										string text4 = meshFilter.name;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										gameObject6._002Ector(text4);
										if ((object)gameObject6 != null)
										{
											Transform transform2 = gameObject6.transform;
											if ((object)gameObject != null)
											{
												Transform parent = gameObject.transform;
												if ((object)transform2 != null)
												{
													transform2.SetParent(parent, worldPositionStays: false);
													Transform transform3 = gameObject6.transform;
													Transform transform4 = meshFilter.transform;
													if ((object)transform4 != null)
													{
														Vector3 position = transform4.position;
														if ((object)transform != null)
														{
															Vector3 vector = transform.InverseTransformPoint((Vector3)0);
															if ((object)transform3 != null)
															{
																transform3.localPosition = (Vector3)0;
																Transform transform5 = gameObject6.transform;
																Quaternion rotation = transform.rotation;
																Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation2);
																Transform transform6 = meshFilter.transform;
																if ((object)transform6 != null)
																{
																	Quaternion rotation3 = transform6.rotation;
																	if ((object)transform5 != null)
																	{
																		object obj47 = obj17 * obj17;
																		object obj48 = quaternion * quaternion;
																		object obj49 = obj17 * obj11;
																		object obj50 = obj11 * obj17;
																		object obj51 = obj17 * obj9;
																		object obj52 = obj9 * obj17;
																		object obj53 = obj17 * quaternion;
																		object obj54 = quaternion * obj17;
																		object obj55 = obj47 - obj48;
																		object obj56 = obj9 * obj9;
																		obj15 = quaternion * obj11;
																		object obj57 = obj49 + obj50;
																		obj25 = quaternion * obj9;
																		obj13 = obj11 * obj9;
																		obj23 = obj51 + obj52;
																		obj21 = obj11 * quaternion;
																		object obj58 = obj9 * quaternion;
																		object obj59 = obj53 + obj54;
																		obj19 = obj9 * obj11;
																		object obj60 = obj11 * obj11;
																		object obj61 = obj55 - obj56;
																		obj31 = obj25 + obj57;
																		obj29 = obj21 + obj23;
																		obj27 = obj19 + obj59;
																		obj18 = obj61 - obj60;
																		obj12 = obj31 - obj58;
																		obj10 = obj29 - obj15;
																		quaternion2 = (Quaternion)(obj27 - obj13);
																		transform5.localRotation = (Quaternion)0;
																		Transform transform7 = gameObject6.transform;
																		Transform t = meshFilter.transform;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
																		object obj62 = 0;
																		object obj63 = obj62;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v34+E4]");
																		bool flag14 = (nint)0 == 0;
																		object obj64 = !flag14;
																		if (obj64 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		Vector3 vector2 = Scale(t, transform);
																		if ((object)transform7 != null)
																		{
																			transform7.localScale = (Vector3)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
																			object obj65 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																			Mesh sharedMesh2 = meshFilter.sharedMesh;
																			if ((object)meshFilter2 != null)
																			{
																				meshFilter2.sharedMesh = sharedMesh2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
																				object obj66 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																				Material[] sharedMaterials = ((Renderer)obj40).sharedMaterials;
																				if ((object)meshFilter3 != null)
																				{
																					((Renderer)(object)meshFilter3).sharedMaterials = sharedMaterials;
																					((Renderer)(object)meshFilter3).shadowCastingMode = (ShadowCastingMode)0;
																					rotation2 = quaternion;
																					obj33 = 0;
																					meshFilter = meshFilter3;
																					obj4 = 0;
																					goto IL_1131;
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
							goto IL_10f8;
						}
					}
					goto IL_1131;
					IL_1131:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v14+18]");
					obj7 = 0;
					obj35++;
					object obj67 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v14+18]");
					bool flag15 = (nint)obj67 < 0;
					obj14 = obj13;
					obj16 = obj15;
					obj20 = obj19;
					obj22 = obj21;
					obj24 = obj23;
					obj26 = obj25;
					obj28 = obj27;
					obj30 = obj29;
					obj32 = obj31;
					obj34 = obj33;
					obj2 = obj2;
					gameObject2 = prefab;
					gameObject3 = gameObject;
					obj9 = obj10;
					obj11 = obj12;
					quaternion = quaternion2;
					obj17 = obj18;
					if (flag15)
					{
						continue;
					}
					goto IL_09be;
				}
				goto IL_1106;
			}
		}
		goto IL_10f8;
		IL_10f8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1106;
		IL_1106:
		return (GameObject)(object)new IndexOutOfRangeException();
		IL_10f3:
		return gameObject3;
		IL_09be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C58]");
		object obj68 = 0;
		object obj69 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj70 = default;
		if (obj70 == null)
		{
			goto IL_10f8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v17+18]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v17+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_10f3;
		}
		object obj73 = 0;
		GameObject gameObject7 = default;
		MeshFilter meshFilter4 = default;
		Renderer renderer = default;
		while (true)
		{
			bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj73) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71);
			object obj74 = !flag16;
			if (obj74 != null)
			{
				break;
			}
			object obj75 = obj70 + obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
			object obj79;
			object obj80;
			Quaternion quaternion4;
			object obj81;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
				Mesh sharedMesh3 = ((SkinnedMeshRenderer)0).sharedMesh;
				object obj76 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v14+E4]");
				bool flag17 = (nint)0 == 0;
				object obj77 = !flag17;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag18 = sharedMesh3 == null;
				bool flag19 = !flag18;
				object obj78 = !flag19;
				obj79 = obj10;
				obj80 = obj12;
				quaternion4 = quaternion2;
				obj81 = obj18;
				obj69 = 0;
				if (obj78 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
					bool flag20 = ((Renderer)0).enabled;
					bool flag21 = !flag20;
					obj79 = obj10;
					obj80 = obj12;
					quaternion4 = quaternion2;
					obj81 = obj18;
					obj69 = 0;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
						string text5 = ((UnityEngine.Object)0).name;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						gameObject7._002Ector(text5);
						if ((object)gameObject7 != null)
						{
							Transform transform8 = gameObject7.transform;
							if ((object)gameObject3 != null)
							{
								Transform parent2 = gameObject3.transform;
								if ((object)transform8 != null)
								{
									transform8.SetParent(parent2, worldPositionStays: false);
									Transform transform9 = gameObject7.transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
									Transform transform10 = ((Component)0).transform;
									if ((object)transform10 != null)
									{
										Vector3 position2 = transform10.position;
										if ((object)transform != null)
										{
											Vector3 vector3 = transform.InverseTransformPoint((Vector3)0);
											if ((object)transform9 != null)
											{
												transform9.localPosition = (Vector3)0;
												Transform transform11 = gameObject7.transform;
												Quaternion rotation4 = transform.rotation;
												Quaternion quaternion5 = Quaternion.Internal_Inverse(ref rotation2);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
												Transform transform12 = ((Component)0).transform;
												if ((object)transform12 != null)
												{
													Quaternion rotation5 = transform12.rotation;
													if ((object)transform11 != null)
													{
														object obj82 = obj18 * obj18;
														object obj83 = quaternion2 * quaternion2;
														object obj84 = obj18 * obj12;
														object obj85 = obj12 * obj18;
														object obj86 = obj18 * obj10;
														object obj87 = obj10 * obj18;
														object obj88 = obj18 * quaternion2;
														object obj89 = quaternion2 * obj18;
														object obj90 = obj82 - obj83;
														object obj91 = obj10 * obj10;
														object obj16 = quaternion2 * obj12;
														object obj92 = obj84 + obj85;
														object obj26 = quaternion2 * obj10;
														object obj14 = obj12 * obj10;
														object obj24 = obj86 + obj87;
														object obj22 = obj12 * quaternion2;
														object obj93 = obj10 * quaternion2;
														object obj94 = obj88 + obj89;
														object obj20 = obj10 * obj12;
														object obj95 = obj12 * obj12;
														object obj96 = obj90 - obj91;
														object obj32 = obj26 + obj92;
														object obj30 = obj22 + obj24;
														object obj28 = obj20 + obj94;
														obj81 = obj96 - obj95;
														obj80 = obj32 - obj93;
														obj79 = obj30 - obj16;
														quaternion4 = (Quaternion)(obj28 - obj14);
														transform11.localRotation = (Quaternion)0;
														Transform transform13 = gameObject7.transform;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
														Transform t2 = ((Component)0).transform;
														object obj97 = obj72;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18+E4]");
														bool flag22 = (nint)0 == 0;
														object obj98 = !flag22;
														if (obj98 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Vector3 vector4 = Scale(t2, transform);
														if ((object)transform13 != null)
														{
															transform13.localScale = (Vector3)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
															object obj99 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
															Mesh sharedMesh4 = ((SkinnedMeshRenderer)0).sharedMesh;
															if ((object)meshFilter4 != null)
															{
																meshFilter4.sharedMesh = sharedMesh4;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
																object obj100 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v13+20]");
																Material[] sharedMaterials2 = ((Renderer)0).sharedMaterials;
																if ((object)renderer != null)
																{
																	renderer.sharedMaterials = sharedMaterials2;
																	renderer.shadowCastingMode = (ShadowCastingMode)0;
																	rotation2 = quaternion2;
																	object obj34 = 0;
																	obj69 = 0;
																	goto IL_1091;
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
						goto IL_10f8;
					}
				}
				goto IL_1091;
			}
			goto IL_10f8;
			IL_1091:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v17+18]");
			obj71 = 0;
			obj73++;
			object obj101 = obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v17+18]");
			bool flag23 = (nint)obj101 < 0;
			obj10 = obj79;
			obj12 = obj80;
			quaternion2 = quaternion4;
			obj18 = obj81;
			if (flag23)
			{
				continue;
			}
			goto IL_10f3;
		}
		goto IL_1106;
	}

	private static Vector3 Scale(Transform t, Transform top)
	{
		//IL_0178: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0039: Expected VT, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_00b6: Expected VT, but got I4
		//IL_0128: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Transform transform = top;
		Transform transform2 = t;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = transform2 != null;
			bool flag3 = !flag2;
			Vector3 result = (Vector3)flag2;
			if (!flag3)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = transform2 != top;
				bool flag6 = !flag5;
				result = (Vector3)flag5;
				if (!flag6)
				{
					if ((object)transform2 == null)
					{
						break;
					}
					Vector3 localScale = transform2.localScale;
					Transform parent = transform2.parent;
					transform = null;
					transform2 = parent;
					continue;
				}
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
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
		//IL_0a04: Expected Obj, but got I4
		//IL_0157: Invalid comparison between F8 and I4
		//IL_0171: Expected Obj, but got F8
		//IL_0180: Expected Obj, but got F8
		//IL_01bf: Expected Obj, but got I
		//IL_01fc: Invalid comparison between I and F8
		//IL_0aa7: Invalid comparison between F4 and I4
		//IL_0ab6: Invalid comparison between F4 and I4
		//IL_0ace: Expected Obj, but got F8
		//IL_0adb: Expected Obj, but got F4
		//IL_0b10: Expected Obj, but got I4
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected Obj, but got Unknown
		//IL_0b56: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I4
		//IL_027e: Expected F8, but got I
		//IL_0bc2: Expected Obj, but got I4
		//IL_02a5: Expected F8, but got I
		//IL_02fa: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I
		//IL_0531: Expected Obj, but got I
		//IL_0539: Expected F4, but got Obj
		//IL_0549: Expected F8, but got I
		//IL_0556: Expected Obj, but got I8
		//IL_0c3d: Expected Obj, but got I
		//IL_0c4d: Expected F8, but got I
		//IL_0c5d: Expected Obj, but got I4
		//IL_0c95: Expected Obj, but got I4
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Ref, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Ref, but got Unknown
		//IL_05b1: Expected VT, but got I4
		//IL_061e: Expected Obj, but got I
		//IL_0a37: Expected Obj, but got I
		//IL_0a47: Expected F8, but got I
		//IL_0a57: Expected Obj, but got I4
		//IL_0643: Expected VT, but got I4
		//IL_04b6: Expected Obj, but got I
		//IL_04c6: Expected F8, but got I
		//IL_04d6: Expected Obj, but got I4
		//IL_0659: Expected Obj, but got I
		//IL_06f7: Expected VT, but got I4
		//IL_070d: Expected Obj, but got I
		//IL_0cc3: Expected Obj, but got I
		//IL_0ce5: Expected Obj, but got I4
		//IL_0747: Expected Obj, but got I4
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_077d: Expected F8, but got I4
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_08c8: Expected VT, but got I4
		//IL_08d8: Expected Obj, but got I
		//IL_0902: Expected Obj, but got I4
		//IL_0931: Expected Obj, but got I
		//IL_094d: Expected VT, but got F8
		//IL_07a0: Invalid comparison between I and F8
		//IL_097c: Expected Obj, but got I
		//IL_09bd: Expected Obj, but got I4
		//IL_0d0d: Expected Obj, but got I4
		//IL_0d16: Expected I4, but got Obj
		//IL_09af: Expected Obj, but got I4
		//IL_0d58: Expected VT, but got F8
		//IL_0d69: Expected F4, but got I4
		//IL_0d72: Expected F4, but got I4
		//IL_09cb: Expected Obj, but got I4
		List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
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
		object obj21 = default;
		Vector3 euler = default;
		object obj37 = default;
		object obj38 = default;
		float num43 = default;
		object obj44;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+10]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+10]");
				((GameObject)0).SetActive(active);
			}
			if ((double)awake < 1.0)
			{
				goto IL_09d0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+20]");
			if (0.0 < 1.0)
			{
				dirty = true;
			}
			float num9 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+20]");
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
			bool flag11 = !flag10;
			object obj16 = obj;
			object obj17 = !flag11;
			object obj18 = ~obj17;
			double num12;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
				num12 = 0.0;
			}
			else
			{
				num12 = 1.0;
			}
			double num13;
			if (selected == num5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A96C]");
				num13 = 0.0;
			}
			else
			{
				num13 = num12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v18+E4]");
			bool flag12 = (nint)0 == 0;
			object obj19 = !flag12;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+24]");
			double num14 = 0.0 - num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+28]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF48]");
			object obj20 = num15 * 0;
			double num16 = num14 * 3274244096.0;
			double num17 = (double)obj20 + num16;
			double num18 = (double)obj21 * num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+28]");
			double num19 = 0.0 + num18;
			double num20 = (double)obj21 * num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+24]");
			double num21 = 0.0 + num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC15]");
			if ((nint)0 != 0)
			{
				if (flag10)
				{
					goto IL_03b5;
				}
			}
			else
			{
				_ = 1;
				bool flag13 = !flag10;
				object obj22 = !flag13;
				if (obj22 != null)
				{
					goto IL_03b5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v40+A0]");
			object obj25 = 0;
			float w = (float)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v41+4]");
			double num22 = 0.0;
			object obj26 = 3274244096L;
			string text3 = text2;
			goto IL_0c6b;
			IL_0c6b:
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v21+E4]");
			bool flag14 = (nint)0 == 0;
			object obj28 = !flag14;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Spring2(ref *(Vector2*)(_Canon + 44), ref *(Vector2*)(_Canon + 52), (Vector2)0, w, (float)num22, 11f);
			if (selected == num5)
			{
				float time = Time.time;
				float num23 = time * 3f;
				float num24 = num23 + (float)num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+10]");
			Transform transform = ((GameObject)0).transform;
			Vector3 vector = ModelAt(num5);
			transform.localPosition = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+10]");
			Transform transform2 = ((GameObject)0).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+30]");
			double num25 = 0.0 * 18.0;
			double num26 = num25 + -22.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+2C]");
			double num27 = 0.0 * -18.0;
			double num28 = num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num29 = num28 * 0.0;
			double num30 = num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num31 = num30 * 0.0;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			transform2.localRotation = (Quaternion)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+10]");
			Transform transform3 = ((GameObject)0).transform;
			object obj29 = obj2;
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v26+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v39+E4]");
			bool flag15 = (nint)0 == 0;
			object obj32 = !flag15;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+20]");
			bool flag16 = (nint)0 < (nint)0;
			object obj33 = !flag16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+20]");
			bool flag17 = (nint)0 == 0;
			object obj34 = ~obj33;
			object obj35 = obj34 | flag17;
			double num32 = 0.0;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+20]");
				bool flag18 = !(0.0 < 1.0);
				num32 = 1.0;
				if (!flag18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+20]");
					double num33 = 0.0 * -10.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+20]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v27+C]");
			object obj36 = 0 * obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v27+14]");
			double num39 = 0.0 * num32;
			num4 = (float)obj36 * (float)obj38;
			float num40 = (float)num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+24]");
			float num41 = num40 * 0f;
			transform3.localScale = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj39 = 0;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v42+E4]");
			bool flag19 = (nint)0 == 0;
			object obj41 = !flag19;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+18]");
			bool flag20 = (UnityEngine.Object)0 != null;
			bool flag21 = !flag20;
			euler = (Vector3)num29;
			float num42 = dt;
			num = num43;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6 (System.__Canon)+18]");
				Transform transform4 = ((GameObject)0).transform;
				object obj42 = ((selected != num5) ? ((object)1109393408) : ((object)1117782016));
				bool flag22 = !flag10;
				object obj43 = !flag22;
				if ((int)(~obj43) == 0)
				{
					obj42 = 1124859904;
				}
				num = (float)obj42 * dt;
				transform4.Rotate(0f, num, 0f, (Space)1);
				euler = (Vector3)num29;
				num42 = dt;
				num41 = 0f;
				num4 = 0f;
			}
			goto IL_09d0;
			IL_03b5:
			Vector3 vector2 = ModelAt(num5);
			Vector2 size = Size;
			double num44 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			double num45 = num44 * 0.0;
			double num46 = (double)overAt - num21;
			double num47 = num46 / num45;
			bool flag23 = num47 < -1.0;
			double num48 = -1.0;
			if (!flag23)
			{
				bool flag24 = !(num47 > 1.0);
				num48 = num47;
				if (!flag24)
				{
					num48 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBoltShop)+118]");
			double num49 = 0.0 - num19;
			double num50 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			num19 = num50 * 0.0;
			num21 = num49 / num19;
			bool flag25 = num21 < -1.0;
			num22 = -1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			num20 = 0.0;
			w = (float)num48;
			text3 = (string)num5;
			if (!flag25)
			{
				if (num21 > 1.0)
				{
					num22 = 1.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num20 = 0.0;
					w = (float)num48;
					text3 = (string)num5;
				}
				else
				{
					num22 = num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num20 = 0.0;
					w = (float)num48;
					text3 = (string)num5;
				}
			}
			goto IL_0c6b;
			IL_09d0:
			list = (List<System.__Canon>)(object)tiles;
			num6 = num5 + 1;
			bool flag26 = tiles == null;
			obj44 = !flag26;
			num5 = num6;
		}
		while (obj44 != null);
		throw new NullReferenceException();
	}

	private Vector3 ModelAt(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
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
		//IL_0179: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0684: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_031c: Invalid comparison between F4 and I4
		//IL_032d: Invalid comparison between F4 and I4
		//IL_06a2: Expected Obj, but got I
		//IL_037d: Expected F8, but got I4
		//IL_070f: Expected Obj, but got I
		//IL_0739: Expected Obj, but got I4
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_059f: Expected Obj, but got I4
		//IL_05cc: Expected Obj, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_078b: Expected Obj, but got I
		//IL_09ae: Expected Obj, but got I4
		//IL_0987: Expected Obj, but got I4
		//IL_09eb: Expected Obj, but got I
		//IL_09f9: Expected VT, but got Obj
		//IL_0a1c: Expected VT, but got I8
		//IL_0a3f: Expected F4, but got I4
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected Obj, but got Unknown
		//IL_0970: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I4
		//IL_0931: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I4
		//IL_0916: Expected Obj, but got I
		//IL_049e: Expected Obj, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int bolts = Coins.Bolts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj10 = 0;
		shownBolts = bolts;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 512, 288);
		float num = awake;
		object obj14;
		Color32[] array = default;
		object obj20 = default;
		double num5;
		int num4;
		bool flag10;
		int num3;
		Color32[] array2;
		if ((double)awake < 1.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
			obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v24+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj14;
			}
			if (array != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v24+A0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v25+4C]");
				_ = 0;
				object obj18 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v27+A0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC98]");
				object s = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v28+4C]");
				_ = 0;
				Text(title, 256, 132, (string)s, array, 3, centred: true);
				double num2 = awake;
				bool flag8 = awake < 0f;
				bool flag9 = !(awake > 0f);
				flag10 = true;
				num3 = 3;
				array2 = array;
				num4 = 132;
				num5 = 1.0;
				if (flag9)
				{
					goto IL_0600;
				}
				double num6 = 0.0;
				if (!flag8)
				{
					bool flag11 = !((double)awake > 1.0);
					num6 = awake;
					if (!flag11)
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
				num5 = num14 * 1133510656.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7F0");
				DrawUi();
				if ((nint)obj20 > 287)
				{
					goto IL_052a;
				}
				object obj21 = 146944 - obj20;
				object obj22 = obj20;
				while (true)
				{
					object obj23 = 0;
					while (true)
					{
						object obj24 = obj14;
						Color32[] array3 = px;
						object obj25 = obj22 & 1;
						bool flag12 = obj25 == null;
						object obj26 = !flag12;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v54+E4]");
							bool flag13 = (nint)0 == 0;
							object obj27 = !flag13;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj24 = obj14;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v54+A0]");
							object obj28 = (nint)0 + (nint)60;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v54+E4]");
							bool flag14 = (nint)0 == 0;
							object obj29 = !flag14;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj24 = obj14;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v54+A0]");
							object obj28 = (nint)0 + (nint)64;
						}
						if (px == null)
						{
							break;
						}
						object obj30 = obj21 + obj23;
						bool flag15 = (nint)obj30 < array3.Length;
						object obj31 = !flag15;
						if (obj31 == null)
						{
							object obj32 = (object)px + obj30;
							obj23++;
							if ((nint)obj23 != 512)
							{
								continue;
							}
							goto IL_04ee;
						}
						goto IL_07e3;
					}
					break;
					IL_04ee:
					obj22++;
					obj21 -= 512;
					if ((nint)obj22 != 288)
					{
						continue;
					}
					goto IL_052a;
				}
			}
			goto IL_07d5;
		}
		DrawUi();
		num5 = 1.0;
		goto IL_0600;
		IL_07d5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_07e3;
		IL_07e3:
		throw new IndexOutOfRangeException();
		IL_0600:
		if ((object)tex != null)
		{
			tex.SetPixels32(px);
			if ((object)tex != null)
			{
				tex.Apply(updateMipmaps: true);
				object obj33 = this + 176;
				bool flag16 = obj33 == null;
				object obj34 = !flag16;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					obj33 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				if ((object)screen != null)
				{
					screen.GetPropertyBlock((MaterialPropertyBlock)obj33);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
					object obj36 = 0;
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v27+E4]");
					bool flag17 = (nint)0 == 0;
					object obj38 = !flag17;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj33 != null)
					{
						object obj39 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v17+A0]");
						object obj40 = 0;
						object obj41 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v18+38]");
						((MaterialPropertyBlock)obj41).SetTexture(0, (Texture)tex);
						if ((object)screen != null)
						{
							screen.SetPropertyBlock((MaterialPropertyBlock)obj33);
							return;
						}
					}
				}
			}
		}
		goto IL_07d5;
		IL_052a:
		object obj42 = obj14;
		object obj43 = obj20 - 286;
		bool flag18 = (nint)obj43 < 0;
		object obj44 = obj20 ^ 0x11E;
		object obj45 = obj20 ^ obj43;
		object obj46 = obj44 & obj45;
		bool flag19 = (nint)obj46 < 0;
		bool flag20 = flag18 == flag19;
		object obj47 = !flag20;
		object obj48 = ~obj47;
		object obj49 = ((obj48 != null) ? ((object)286) : obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v46+E4]");
		bool flag21 = (nint)0 == 0;
		object obj50 = !flag21;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj42 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v46+A0]");
		object obj51 = 0;
		RectInt r = (RectInt)(obj49 << 32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v33+44]");
		num4 = 0;
		FillRect(r, (Color32)8589935104L);
		flag10 = true;
		num3 = 3;
		array2 = array;
		num = 1.1335107E+09f;
		goto IL_0600;
	}

	private unsafe void DrawUi()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1a00: Expected Obj, but got I
		//IL_1a22: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_1a40: Expected Obj, but got I
		//IL_1a70: Expected Obj, but got I
		//IL_1aa7: Expected Obj, but got I
		//IL_1ab7: Expected Obj, but got I
		//IL_1ad9: Expected Obj, but got I4
		//IL_20eb: Expected Obj, but got I
		//IL_2128: Expected Obj, but got I
		//IL_2152: Expected Obj, but got I4
		//IL_1b11: Expected Obj, but got I4
		//IL_2170: Expected Obj, but got I
		//IL_2180: Expected Obj, but got I
		//IL_2190: Expected Obj, but got I
		//IL_21a0: Expected Obj, but got I
		//IL_21b0: Expected Obj, but got I
		//IL_21c0: Expected Obj, but got I
		//IL_21fb: Expected Obj, but got I
		//IL_1b7e: Expected Obj, but got I4
		//IL_1b2f: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected I4, but got Unknown
		//IL_03a0: Expected Obj, but got I4
		//IL_1be5: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I
		//IL_1c1d: Expected Obj, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I
		//IL_041c: Expected VT, but got I
		//IL_041c: Expected VT, but got I
		//IL_042c: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I4
		//IL_048b: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I
		//IL_04c4: Expected VT, but got Obj
		//IL_04da: Expected VT, but got I
		//IL_0517: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got I
		//IL_0637: Expected Obj, but got I
		//IL_064f: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I
		//IL_0766: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I
		//IL_0965: Expected Obj, but got I4
		//IL_0992: Expected Obj, but got I
		//IL_09aa: Expected Obj, but got I
		//IL_09cc: Expected Obj, but got I4
		//IL_07b0: Expected Obj, but got I4
		//IL_0a01: Expected Obj, but got I
		//IL_0a65: Expected Obj, but got I
		//IL_0a87: Expected Obj, but got I4
		//IL_07dd: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I4
		//IL_083c: Expected Obj, but got I
		//IL_0b42: Expected Obj, but got I4
		//IL_08a7: Expected Obj, but got I
		//IL_08b7: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I
		//IL_1c5c: Expected Obj, but got I
		//IL_0afb: Expected Obj, but got I4
		//IL_22ac: Expected Obj, but got I4
		//IL_1c41: Expected Obj, but got I
		//IL_1c71: Expected Obj, but got I
		//IL_1c8f: Expected VT, but got I
		//IL_1c8f: Expected VT, but got I
		//IL_1c9f: Expected Obj, but got I
		//IL_1cc9: Expected Obj, but got I4
		//IL_0ba5: Expected Obj, but got I
		//IL_0c09: Expected Obj, but got I
		//IL_0c2b: Expected Obj, but got I4
		//IL_0c7f: Expected Obj, but got I
		//IL_0cf0: Expected Obj, but got I
		//IL_0d1e: Expected Obj, but got I
		//IL_1065: Expected Obj, but got I4
		//IL_1d15: Expected Obj, but got I
		//IL_1d25: Expected F8, but got I
		//IL_0de6: Expected Obj, but got I4
		//IL_0ebe: Expected Obj, but got I4
		//IL_0f7b: Expected Obj, but got I4
		//IL_1198: Invalid comparison between F4 and I4
		//IL_11b3: Expected VT, but got I4
		//IL_11bb: Expected VT, but got Obj
		//IL_0fa8: Expected Obj, but got I
		//IL_0fd2: Expected Obj, but got I4
		//IL_1da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dad: Expected VT, but got Unknown
		//IL_1dcf: Expected Obj, but got I4
		//IL_10b5: Expected VT, but got I4
		//IL_10bd: Expected VT, but got Obj
		//IL_1007: Expected Obj, but got I
		//IL_2326: Expected Obj, but got I
		//IL_11d9: Expected Obj, but got I
		//IL_1203: Expected Obj, but got I4
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Expected VT, but got Unknown
		//IL_115e: Expected Obj, but got I4
		//IL_22d8: Expected Obj, but got I
		//IL_2302: Expected Obj, but got I4
		//IL_1d83: Expected Obj, but got I
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected VT, but got Unknown
		//IL_1102: Expected Obj, but got I4
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_138a: Expected Obj, but got Unknown
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Expected Obj, but got Unknown
		//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Expected Obj, but got Unknown
		//IL_13b3: Expected VT, but got Obj
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Expected VT, but got Unknown
		//IL_2343: Expected Obj, but got I
		//IL_236d: Expected Obj, but got I4
		//IL_1d3a: Expected Obj, but got I
		//IL_145d: Expected Obj, but got I4
		//IL_124c: Invalid comparison between F4 and I4
		//IL_1eb2: Expected Obj, but got I
		//IL_1416: Expected Obj, but got I4
		//IL_23e6: Expected Obj, but got I
		//IL_2410: Expected Obj, but got I4
		//IL_1e97: Expected Obj, but got I
		//IL_149a: Invalid comparison between VT and I4
		//IL_14ad: Expected Obj, but got VT
		//IL_14b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ba: Expected Obj, but got Unknown
		//IL_14ea: Expected Obj, but got I4
		//IL_1e73: Expected Obj, but got I4
		//IL_238b: Expected Obj, but got I
		//IL_2393: Unknown result type (might be due to invalid IL or missing references)
		//IL_2398: Expected VT, but got Unknown
		//IL_23b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b5: Expected VT, but got Unknown
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0e: Expected Obj, but got Unknown
		//IL_1e28: Expected Obj, but got I4
		//IL_1ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec4: Expected I4, but got Unknown
		//IL_150a: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Expected VT, but got Unknown
		//IL_1721: Expected Obj, but got I
		//IL_1743: Expected Obj, but got I4
		//IL_1f45: Expected Obj, but got I
		//IL_1f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f53: Expected I4, but got Unknown
		//IL_1f81: Expected Obj, but got I
		//IL_1f91: Expected Obj, but got I
		//IL_1fbb: Expected Obj, but got I4
		//IL_1531: Expected Obj, but got I
		//IL_1553: Expected Obj, but got I4
		//IL_17a1: Expected Obj, but got I4
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_1586: Expected I4, but got Unknown
		//IL_1596: Expected Obj, but got I
		//IL_15c4: Expected Obj, but got I
		//IL_15d4: Expected Obj, but got I
		//IL_15ec: Expected Obj, but got I
		//IL_160e: Expected Obj, but got I4
		//IL_1fd9: Expected Obj, but got I
		//IL_1fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe7: Expected I4, but got Unknown
		//IL_1ff7: Expected Obj, but got I
		//IL_2007: Expected Obj, but got I
		//IL_1655: Expected Obj, but got I4
		//IL_168b: Expected Obj, but got I
		//IL_16b1: Expected Obj, but got I
		//IL_16ec: Expected Obj, but got I4
		//IL_17d6: Expected Obj, but got I
		//IL_1800: Expected Obj, but got I4
		//IL_1ef8: Expected Obj, but got I
		//IL_1f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f06: Expected I4, but got Unknown
		//IL_1f16: Expected Obj, but got I
		//IL_1847: Expected Obj, but got I4
		//IL_2036: Expected Obj, but got I
		//IL_204e: Expected VT, but got I8
		//IL_204e: Expected VT, but got I8
		//IL_18d5: Expected Obj, but got I4
		//IL_20a0: Expected Obj, but got I
		//IL_188e: Expected Obj, but got I4
		//IL_2479: Expected VT, but got I8
		//IL_2479: Expected VT, but got I8
		//IL_2489: Expected Obj, but got I
		//IL_24b3: Expected Obj, but got I4
		//IL_2085: Expected Obj, but got I
		//IL_19ad: Expected Obj, but got I4
		//IL_20d6: Expected Obj, but got I
		//IL_1966: Expected Obj, but got I4
		//IL_20bb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC98]");
		object obj5 = 0;
		GillaBoardLook.Frame(px, 512, 288, 3);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+A0]");
		object obj8 = 0;
		ScreenFont font = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+60]");
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
			num4 = 120;
		}
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62B0]");
		object s = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v11+A0]");
		object obj12 = 0;
		int num5 = num4 + 22;
		ScreenFont font2 = this.text;
		int x = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+70]");
		Text(font2, x, 11, (string)s, (Color32[])0, 1, centred: false);
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string boltsText = Coins.BoltsText;
		ScreenFont screenFont2;
		int num8;
		if (this.text != null)
		{
			int num6 = this.text.Measure(boltsText, 2);
			screenFont2 = this.text;
			int num7 = 0;
			num5 = 2;
			ScreenFont screenFont3 = (ScreenFont)(object)boltsText;
			num8 = num6;
		}
		else
		{
			screenFont2 = null;
			int num7 = 11;
			ScreenFont screenFont3 = this.text;
			num8 = 30;
		}
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD20]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD28]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD18]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D18]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCD0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v19+A0]");
		object obj22 = 0;
		int x2 = 502 - num8;
		ScreenFont font3 = screenFont2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v11+88]");
		Text(font3, x2, 7, boltsText, (Color32[])0, 2, centred: false);
		int x3 = 484 - num8;
		BoltIcon(x3, 8, 2, onTag: false);
		int num9 = 0;
		Item item;
		int num23 = default;
		int num26;
		int bolts2;
		string text4;
		double num29;
		int num27;
		while (true)
		{
			object obj23 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v24+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj23 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v24+A0]");
			object obj25 = 0;
			object obj26 = obj25;
			bool[] array2;
			string text5;
			int num28;
			if (obj25 != null)
			{
				bool flag7 = num9 < 5;
				object obj27 = !flag7;
				object obj28 = num9 - 5;
				bool flag8 = obj28 == null;
				object obj29 = !flag8;
				object obj30 = obj27 & obj29;
				if (obj30 == null)
				{
					int num10 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X9_v5+18]");
					if ((nint)num10 < (nint)0)
					{
						DrawTile(num9);
						int num11 = num9 + 1;
						x3 = num9;
						num9 = num11;
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v24+E4]");
				bool flag9 = (nint)0 == 0;
				object obj31 = !flag9;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj32 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v185+A0]");
					obj25 = 0;
					obj26 = obj25;
					if (obj25 == null)
					{
						goto IL_19d3;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X9_v5+18]");
				int num12 = (int)(-1);
				object obj33 = selected - num12;
				bool flag10 = (nint)obj33 < 0;
				int num13 = selected ^ num12;
				int num14 = selected ^ obj33;
				int num15 = num13 & num14;
				bool flag11 = num15 < 0;
				bool flag12 = flag10 == flag11;
				object obj34 = !flag12;
				object obj35 = ~obj34;
				if (obj35 == null)
				{
					num12 = selected;
				}
				bool flag13 = selected < 0;
				int num16 = selected ^ selected;
				int num17 = selected & num16;
				bool flag14 = num17 < 0;
				bool flag15 = flag13 == flag14;
				object obj36 = !flag15;
				object obj37 = ~obj36;
				int num18 = ((obj37 != null) ? num12 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X9_v5+18]");
				bool flag16 = (nint)num18 < (nint)0;
				object obj38 = !flag16;
				if (obj38 != null)
				{
					goto IL_19e1;
				}
				object obj39 = obj26 + num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X9_v6+20]");
				item = (Item)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v19+8]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v19+10]");
				Outline((RectInt)num19, (Color32)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj40 = 0;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v31+E4]");
				bool flag17 = (nint)0 == 0;
				object obj42 = !flag17;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj43 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v23+A0]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v24+8]");
				object obj45 = (nint)0 + (nint)3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v24+C]");
				object obj46 = (nint)0 + (nint)3;
				RectInt r = (RectInt)(obj45 | obj46);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v24+10]");
				Outline(r, (Color32)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X9_v6+20]");
				if ((nint)0 != 0)
				{
					object obj47 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v25+A0]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26+10]");
					int width = (int)(-16);
					string s2 = Fit(item.label, width, 2);
					object obj49 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26+8]");
					int x4 = (int)((nint)0 + (nint)8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26+C]");
					int y = (int)((nint)0 + (nint)8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v27+A0]");
					object obj50 = 0;
					ScreenFont font4 = this.text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v28+68]");
					Text(font4, x4, y, s2, (Color32[])0, 2, centred: false);
					object obj51 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v29+A0]");
					object obj52 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v30+8]");
					int x5 = (int)((nint)0 + (nint)8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v30+C]");
					int y2 = (int)((nint)0 + (nint)34);
					ScreenFont font5 = this.text;
					string line = item.line1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v30+60]");
					Text(font5, x5, y2, line, (Color32[])0, 1, centred: false);
					object obj53 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v31+A0]");
					object obj54 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v32+8]");
					int x6 = (int)((nint)0 + (nint)8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v32+C]");
					int y3 = (int)((nint)0 + (nint)46);
					ScreenFont font6 = this.text;
					string line2 = item.line2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v32+60]");
					Text(font6, x6, y3, line2, (Color32[])0, 1, centred: false);
					object obj55 = obj3;
					string text = (string)obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v33+A0]");
					object obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v34+8]");
					int x7 = (int)((nint)0 + (nint)8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v34+C]");
					int num20 = (int)((nint)0 + (nint)62);
					ScreenFont font7 = this.text;
					int y4 = num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v34+70]");
					Text(font7, x7, y4, (string)obj17, (Color32[])0, 1, centred: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X9_v6+20]");
					int num21 = PaysBack((Item)0);
					bool flag18 = num21 < 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v34+70]");
					Color32[] array = (Color32[])0;
					bool flag19 = false;
					int num22 = 1;
					if (!flag18)
					{
						object obj57 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v222+E4]");
						bool flag20 = (nint)0 == 0;
						object obj58 = !flag20;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
						object obj59 = 0;
						object obj60 = obj59;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v224+E4]");
						bool flag21 = (nint)0 == 0;
						object obj61 = !flag21;
						if (obj61 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj62 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v180+A0]");
						object obj63 = 0;
						string text2 = num23.ToString();
						string text3 = (string)obj18 + text2 + (string)obj19;
						object obj64 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v181+8]");
						int x8 = (int)((nint)0 + (nint)8);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v181+C]");
						num20 = (int)((nint)0 + (nint)74);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v183+A0]");
						object obj65 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v184+70]");
						array = (Color32[])0;
						ScreenFont font8 = this.text;
						int y5 = num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v184+70]");
						Text(font8, x8, y5, text3, (Color32[])0, 1, centred: false);
						flag19 = false;
						num22 = 1;
						text = text3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X9_v6+20]");
					int num24 = (int)((nint)0 + (nint)48);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
					object obj66 = 0;
					string s3 = ((int*)num24)->ToString((string)obj66);
					object obj67 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v38+E4]");
					bool flag22 = (nint)0 == 0;
					object obj68 = !flag22;
					if (obj68 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
					object obj69 = 0;
					object obj70 = obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
					object obj71 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v46+E4]");
					bool flag23 = (nint)0 == 0;
					object obj72 = !flag23;
					if (obj72 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj73 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v42+A0]");
					object obj74 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v43+8]");
					int x9 = (int)((nint)0 + (nint)8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v43+C]");
					int y6 = (int)((nint)0 + (nint)94);
					BoltIcon(x9, y6, 2, onTag: false);
					object obj75 = obj3;
					object obj76 = obj71;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v45+A0]");
					object obj77 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v49+E4]");
					bool flag24 = (nint)0 == 0;
					object obj78 = !flag24;
					if (obj78 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int bolts = Coins.Bolts;
					object obj79 = obj3;
					object colours;
					if (bolts < item.price)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v212+E4]");
						bool flag25 = (nint)0 == 0;
						object obj80 = !flag25;
						if (obj80 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj79 = obj3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v212+A0]");
						colours = (nint)0 + (nint)120;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v212+E4]");
						bool flag26 = (nint)0 == 0;
						object obj81 = !flag26;
						if (obj81 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj79 = obj3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v212+A0]");
						colours = (nint)0 + (nint)136;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v46+8]");
					int x10 = (int)((nint)0 + (nint)28);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v46+C]");
					int y7 = (int)((nint)0 + (nint)92);
					Text(this.text, x10, y7, s3, (Color32[])colours, 2, centred: false);
					object obj82 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v57+E4]");
					bool flag27 = (nint)0 == 0;
					object obj83 = !flag27;
					if (obj83 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj82 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v57+A0]");
					object obj84 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v50+18]");
					nint num25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v50+20]");
					Outline((RectInt)num25, (Color32)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
					object obj85 = 0;
					object obj86 = obj85;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X0_v59+E4]");
					bool flag28 = (nint)0 == 0;
					object obj87 = !flag28;
					if (obj87 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj88 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v54+A0]");
					object obj89 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v55+18]");
					int x11 = (int)((nint)0 + (nint)6);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v55+1C]");
					int y8 = (int)((nint)0 + (nint)10);
					BoltIcon(x11, y8, 1, onTag: false);
					object obj90 = obj3;
					object obj91 = obj71;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v57+A0]");
					object obj92 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v62+E4]");
					bool flag29 = (nint)0 == 0;
					object obj93 = !flag29;
					if (obj93 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string boltsText2 = Coins.BoltsText;
					string s4 = (string)obj20 + boltsText2;
					object obj94 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v60+A0]");
					object obj95 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v61+20]");
					int width2 = (int)(-24);
					string s5 = Fit(s4, width2, 1);
					object obj96 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v58+18]");
					num26 = (int)((nint)0 + (nint)18);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v58+1C]");
					num27 = (int)((nint)0 + (nint)10);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v63+A0]");
					object obj97 = 0;
					ScreenFont font9 = this.text;
					int x12 = num26;
					int y9 = num27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v64+60]");
					Text(font9, x12, y9, s5, (Color32[])0, 1, centred: false);
					bolts2 = Coins.Bolts;
					array2 = down;
					if (down != null)
					{
						bool flag30 = (byte)(~(array2[0] ? 1u : 0u)) != 0;
						text4 = (string)(object)this.text;
						if (flag30)
						{
							goto IL_0e37;
						}
						string[] array3 = downOn;
						if (downOn != null)
						{
							text5 = (string)obj21;
							bool flag31 = array3[0] == (string)obj21;
							bool flag32 = !flag31;
							object obj98 = !flag32;
							num28 = 0;
							if (obj98 != null)
							{
								goto IL_0f51;
							}
							array2 = down;
							bool flag33 = down == null;
							num26 = 0;
							text4 = (string)obj21;
							if (!flag33)
							{
								goto IL_0e37;
							}
						}
					}
				}
			}
			goto IL_19d3;
			IL_0e37:
			if (~(array2[1] ? 1u : 0u) == 0)
			{
				string[] array4 = downOn;
				if (downOn == null)
				{
					goto IL_19d3;
				}
				text4 = (string)obj21;
				bool flag34 = array4[1] == (string)obj21;
				bool flag35 = !flag34;
				object obj99 = !flag35;
				num26 = 0;
				num28 = 0;
				text5 = (string)obj21;
				if (obj99 != null)
				{
					goto IL_0f51;
				}
			}
			if (~(mouseDown ? 1u : 0u) == 0)
			{
				text5 = (string)obj21;
				bool flag36 = hovered == (string)obj21;
				bool flag37 = !flag36;
				num28 = 0;
				num26 = 0;
				text4 = (string)obj21;
				if (!flag37)
				{
					goto IL_0f51;
				}
			}
			object obj100 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X0_v199+E4]");
			bool flag38 = (nint)0 == 0;
			object obj101 = !flag38;
			if (obj101 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj100 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X0_v199+A0]");
			object obj102 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v168+28]");
			num29 = 0.0;
			break;
			IL_19d3:
			NullReferenceException ex = new NullReferenceException();
			goto IL_19e1;
			IL_0f51:
			object obj103 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X0_v189+E4]");
			bool flag39 = (nint)0 == 0;
			object obj104 = !flag39;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj105 = 0;
			object obj106 = obj105;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X0_v191+E4]");
			bool flag40 = (nint)0 == 0;
			object obj107 = !flag40;
			if (obj107 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj108 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v161+A0]");
			object obj109 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X8_v162+28]");
			double num30 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7C0]");
			num29 = num30 + 0.0;
			num26 = num28;
			text4 = text5;
			break;
			IL_19e1:
			throw new IndexOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		object obj111 = default;
		Color32 color2 = default;
		RectInt r2;
		double num31;
		object obj116;
		double num32;
		if (bolts2 < item.price)
		{
			bool flag41 = hovered == (string)obj21;
			bool flag42 = !flag41;
			Color32 color = (Color32)0;
			RectInt rectInt = (RectInt)obj21;
			if (!flag42)
			{
				object obj110 = obj3;
				RectInt rectInt2 = (RectInt)(num29 | obj111);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X0_v184+E4]");
				bool flag43 = (nint)0 == 0;
				object obj112 = !flag43;
				if (obj112 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj110 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X0_v184+A0]");
				object obj113 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v155+4C]");
				num27 = 0;
				FillRect(rectInt2, color2);
				color = color2;
				rectInt = rectInt2;
			}
			object obj114 = obj3;
			r2 = (RectInt)(num29 | obj111);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X0_v180+E4]");
			bool flag44 = (nint)0 == 0;
			object obj115 = !flag44;
			if (obj115 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj114 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X0_v180+A0]");
			obj116 = (nint)0 + (nint)84;
			num31 = num29;
			num32 = num29;
			goto IL_22ba;
		}
		float num33 = holdFill;
		bool flag45 = !(holdFill > 0f);
		num31 = holdFill;
		Color32 color3 = (Color32)num26;
		RectInt rectInt3 = (RectInt)text4;
		if (flag45)
		{
			goto IL_1d98;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj117 = 0;
		object obj118 = obj117;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X0_v159+E4]");
		bool flag46 = (nint)0 == 0;
		object obj119 = !flag46;
		if (obj119 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num33 = holdFill;
		}
		float num34 = num33 * (float)color2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj120 = 0;
		object obj121 = obj120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X0_v162+E4]");
		bool flag47 = (nint)0 == 0;
		object obj122 = !flag47;
		if (obj122 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num35 = default;
		double num36;
		if (num34 < 0f)
		{
			if ((double)num34 == -0.5)
			{
				num31 = num35;
				num36 = -1.0;
				goto IL_1df1;
			}
			num31 = (double)num34 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if ((double)num34 == 0.5)
			{
				num31 = num35;
				num36 = 1.0;
				goto IL_1df1;
			}
			num31 = (double)num34 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_1e3b;
		IL_22ba:
		Outline(r2, color2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj123 = 0;
		object obj124 = obj123;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1128 @ X0_v76+E4]");
		bool flag48 = (nint)0 == 0;
		object obj125 = !flag48;
		if (obj125 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj126 = obj3;
		object obj127 = color2 - 4;
		object obj129 = default;
		object obj128 = obj129 - 4;
		object obj130 = obj111 + 2;
		Color32 c = (Color32)(obj127 | obj128);
		double num37 = num29 + 2.0;
		RectInt r3 = (RectInt)(num37 | obj130);
		if (bolts2 < item.price)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X0_v147+E4]");
			bool flag49 = (nint)0 == 0;
			object obj131 = !flag49;
			if (obj131 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj126 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X0_v147+A0]");
			object obj132 = (nint)0 + (nint)76;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X0_v147+E4]");
			bool flag50 = (nint)0 == 0;
			object obj133 = !flag50;
			if (obj133 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj126 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X0_v147+A0]");
			object obj132 = (nint)0 + (nint)72;
		}
		Outline(r3, c);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj134 = 0;
		object obj135 = obj134;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1248 @ X0_v81+E4]");
		bool flag51 = (nint)0 == 0;
		object obj136 = !flag51;
		if (obj136 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag52 = color2 < (object)0;
		object obj137 = color2 ^ color2;
		object obj138 = color2 & obj137;
		bool flag53 = (nint)obj138 < 0;
		object obj139 = obj3;
		bool flag54 = flag52 == flag53;
		object obj140 = !flag54;
		object obj141 = ~obj140;
		Color32 color4 = ((obj141 != null) ? color2 : ((Color32)(color2 + 1)));
		int num38 = (int)(num29 + color4);
		int y11;
		Color32[] colours2;
		string s7;
		int x13;
		ScreenFont font11;
		if (bolts2 < item.price)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD08]");
			object s6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v116+E4]");
			bool flag55 = (nint)0 == 0;
			object obj142 = !flag55;
			if (obj142 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj143 = obj3;
			int y10 = obj111 + 22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ X8_v112+A0]");
			object obj144 = 0;
			ScreenFont font10 = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ X8_v113+78]");
			Text(font10, num38, y10, (string)s6, (Color32[])0, 2, centred: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj145 = 0;
			object obj146 = obj145;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj147 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1310 @ X0_v130+E4]");
			bool flag56 = (nint)0 == 0;
			object obj148 = !flag56;
			if (obj148 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj149 = obj147;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X0_v132+E4]");
			bool flag57 = (nint)0 == 0;
			object obj150 = !flag57;
			if (obj150 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int bolts3 = Coins.Bolts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
			object obj151 = 0;
			int num39 = default;
			string text6 = num39.ToString((string)obj151);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCD8]");
			object obj152 = 0;
			string text7 = text6 + (string)obj152;
			object obj153 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v124+E4]");
			bool flag58 = (nint)0 == 0;
			object obj154 = !flag58;
			if (obj154 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj153 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v124+A0]");
			object obj155 = 0;
			y11 = obj111 + 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1379 @ X8_v125+78]");
			colours2 = (Color32[])0;
			s7 = text7;
			x13 = num38;
			font11 = this.text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD10]");
			object s8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v116+E4]");
			bool flag59 = (nint)0 == 0;
			object obj156 = !flag59;
			if (obj156 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj139 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v116+A0]");
			object obj157 = 0;
			int y12 = obj111 + 22;
			ScreenFont font12 = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X8_v106+60]");
			Text(font12, num38, y12, (string)s8, (Color32[])0, 2, centred: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj158 = 0;
			object obj159 = obj158;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1318 @ X0_v118+E4]");
			bool flag60 = (nint)0 == 0;
			object obj160 = !flag60;
			if (obj160 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj161 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X0_v121+E4]");
			bool flag61 = (nint)0 == 0;
			object obj162 = !flag61;
			if (obj162 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj161 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X0_v121+A0]");
			object obj163 = 0;
			y11 = obj111 + 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8CE0]");
			object obj164 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ X8_v111+60]");
			colours2 = (Color32[])0;
			s7 = (string)obj164;
			x13 = num38;
			font11 = this.text;
		}
		Text(font11, x13, y11, s7, colours2, 1, centred: true);
		if (banner == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj165 = 0;
		object obj166 = obj165;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X0_v86+E4]");
		bool flag62 = (nint)0 == 0;
		object obj167 = !flag62;
		if (obj167 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj168 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X0_v89+E4]");
		bool flag63 = (nint)0 == 0;
		object obj169 = !flag63;
		if (obj169 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj168 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X0_v89+A0]");
		object obj170 = 0;
		FillRect((RectInt)609885356052L, (Color32)103079215384L);
		object obj171 = obj3;
		if (~(bannerBad ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ X0_v107+E4]");
			bool flag64 = (nint)0 == 0;
			object obj172 = !flag64;
			if (obj172 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj171 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ X0_v107+A0]");
			object obj173 = (nint)0 + (nint)84;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ X0_v107+E4]");
			bool flag65 = (nint)0 == 0;
			object obj174 = !flag65;
			if (obj174 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj171 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ X0_v107+A0]");
			object obj173 = (nint)0 + (nint)68;
		}
		Outline((RectInt)609885356052L, (Color32)103079215384L);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj175 = 0;
		object obj176 = obj175;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X0_v94+E4]");
		bool flag66 = (nint)0 == 0;
		object obj177 = !flag66;
		if (obj177 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string s9 = Fit(banner, 270, 1);
		object obj178 = obj3;
		object colours3;
		if (~(bannerBad ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X8_v94+E4]");
			bool flag67 = (nint)0 == 0;
			object obj179 = !flag67;
			if (obj179 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj178 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X8_v94+A0]");
			colours3 = (nint)0 + (nint)120;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X8_v94+E4]");
			bool flag68 = (nint)0 == 0;
			object obj180 = !flag68;
			if (obj180 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj178 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X8_v94+A0]");
			colours3 = (nint)0 + (nint)104;
		}
		Text(this.text, 160, 148, s9, (Color32[])colours3, 1, centred: true);
		return;
		IL_1df1:
		double num40 = num31 + num36;
		object obj181 = num31 & 1;
		bool flag69 = obj181 == null;
		object obj182 = !flag69;
		if (obj182 != null)
		{
			num31 = num40;
		}
		goto IL_1e3b;
		IL_1d98:
		object obj183 = obj3;
		r2 = (RectInt)(num29 | obj111);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X0_v156+E4]");
		bool flag70 = (nint)0 == 0;
		object obj184 = !flag70;
		if (obj184 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj183 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X0_v156+A0]");
		obj116 = (nint)0 + (nint)68;
		num32 = num29;
		goto IL_22ba;
		IL_1e3b:
		object obj185 = obj3;
		object obj186 = obj129 << 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ X0_v167+E4]");
		bool flag71 = (nint)0 == 0;
		object obj187 = !flag71;
		if (obj187 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj185 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ X0_v167+A0]");
		object obj188 = 0;
		color3 = (Color32)(obj186 | num31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X9_v37+48]");
		num27 = 0;
		rectInt3 = (RectInt)(num29 | obj111);
		FillRect(rectInt3, color3);
		goto IL_1d98;
	}

	private unsafe void DrawTile(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a00: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_02dc: Invalid comparison between F4 and I4
		//IL_010c: Expected Obj, but got I
		//IL_0415: Expected VT, but got Obj
		//IL_0424: Expected Obj, but got I4
		//IL_044e: Expected I4, but got I8
		//IL_0171: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01e6: Expected F8, but got I4
		//IL_0a96: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I4
		//IL_0209: Invalid comparison between I and F8
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03e3: Expected Obj, but got I4
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got I
		//IL_0a6e: Expected VT, but got Obj
		//IL_0a81: Expected VT, but got I8
		//IL_051f: Expected Obj, but got I
		//IL_0549: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected I4, but got Unknown
		//IL_05b5: Expected Obj, but got I4
		//IL_075f: Expected Obj, but got I
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected I4, but got Unknown
		//IL_07fc: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I8
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_0614: Expected Obj, but got I4
		//IL_0624: Expected Obj, but got I4
		//IL_063d: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I8
		//IL_0b58: Expected Obj, but got I
		//IL_0b68: Expected Obj, but got I
		//IL_0b92: Expected Obj, but got I4
		//IL_07cb: Expected Obj, but got I4
		//IL_0b10: Expected Obj, but got I
		//IL_0b3a: Expected Obj, but got I4
		//IL_0869: Expected Obj, but got I4
		//IL_0abc: Expected Obj, but got I4
		//IL_0663: Expected Obj, but got I4
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected Obj, but got Unknown
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected Obj, but got Unknown
		//IL_0bc8: Expected VT, but got Obj
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected Obj, but got Unknown
		//IL_0678: Expected Obj, but got I
		//IL_0909: Expected Obj, but got I4
		//IL_071a: Expected Obj, but got I4
		//IL_0c1a: Expected Obj, but got I
		//IL_08c2: Expected Obj, but got I4
		//IL_0afb: Expected Obj, but got I
		//IL_06c3: Expected Obj, but got I4
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Expected VT, but got Unknown
		//IL_0d9b: Expected Obj, but got I
		//IL_0dc5: Expected Obj, but got I4
		//IL_0bff: Expected Obj, but got I
		//IL_0ca5: Expected I4, but got Obj
		//IL_0cd3: Expected Obj, but got I
		//IL_0cdd: Expected Obj, but got I4
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected Obj, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_0d19: Expected Obj, but got I
		//IL_0d4b: Expected Obj, but got I
		//IL_0742: Expected Obj, but got I
		//IL_0ae0: Expected Obj, but got I
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected I4, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected I4, but got Unknown
		//IL_099b: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected I4, but got Unknown
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Expected I4, but got Unknown
		//IL_0c79: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<System.__Canon> list = (List<System.__Canon>)(object)tiles;
		object obj4 = i * 1431655766;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B08]");
		object obj5 = 0;
		object obj6 = obj4 >> 63;
		object obj7 = obj4 >> 32;
		object obj8 = obj7 + obj6;
		object obj9 = obj8 + obj8;
		object obj10 = obj8 << 7;
		object obj11 = i - obj9;
		object obj12 = obj10 - obj8;
		object obj13 = obj11 * 102;
		object obj14 = obj12 + 30;
		bool flag2 = list._size <= i;
		double num = 1.0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCC8]");
			object obj15 = 0;
			System.__Canon _Canon = list.get_Item(i);
			bool flag3 = _Canon == null;
			num = 1.0;
			if (!flag3)
			{
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v74+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v83 (System.__Canon)+20]");
				bool flag5 = (nint)0 < (nint)0;
				object obj18 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v83 (System.__Canon)+20]");
				bool flag6 = (nint)0 == 0;
				object obj19 = ~obj18;
				object obj20 = obj19 | flag6;
				num = 0.0;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v83 (System.__Canon)+20]");
					bool flag7 = !(0.0 < 1.0);
					num = 1.0;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v83 (System.__Canon)+20]");
						double num2 = 0.0 * -10.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v83 (System.__Canon)+20]");
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
			}
		}
		object obj21 = obj14 << 32;
		object obj22 = obj13 + 10;
		int num8 = default;
		string text = num8.ToString();
		string text2 = (string)obj5 + text;
		bool flag8 = hovered == text2;
		if (pressFlash > 0f)
		{
			string text3 = num8.ToString();
			string text4 = (string)obj5 + text3;
			if (pressedThing == text4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v74+E4]");
				bool flag9 = (nint)0 == 0;
				object obj25 = !flag9;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj26 = obj;
				object obj27 = obj13 + 11;
				object obj28 = obj12 + 31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v77+E4]");
				bool flag10 = (nint)0 == 0;
				object obj29 = !flag10;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj26 = obj;
				}
				RectInt r = (RectInt)(obj27 | obj28);
				FillRect(r, (Color32)506806141022L);
			}
		}
		RectInt r2 = (RectInt)(obj21 | obj22);
		object obj30 = selected - i;
		bool flag11 = obj30 == null;
		TileOutline(r2, (float)num, sel: true, flag11);
		if (num < 0.5)
		{
			return;
		}
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v18+E4]");
		bool flag12 = (nint)0 == 0;
		object obj32 = !flag12;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v18+A0]");
		object obj33 = 0;
		object obj34 = obj33;
		int num9 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v18+18]");
		bool flag13 = (nint)num9 < (nint)0;
		object obj35 = !flag13;
		object obj37;
		int num10;
		if (obj35 == null)
		{
			object obj36 = obj34 + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v20+20]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj38 = 0;
			object obj39 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v21+E4]");
			bool flag14 = (nint)0 == 0;
			object obj40 = !flag14;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X9_v9+18]");
			string[] array = Wrap((string)0, 90);
			num10 = obj13 + 58;
			bool flag15 = array.Length < 1;
			int num11 = (flag11 ? 1 : 0);
			string text5 = (string)flag8;
			if (flag15)
			{
				goto IL_074f;
			}
			object obj41 = array.Length & 0xFFFFFFFFL;
			object obj42 = array + 32;
			object obj43 = obj12 + 128;
			bool flag17 = default;
			bool flag16 = flag17;
			int num13 = default;
			int num12 = num13;
			Color32[] array3 = default;
			Color32[] array2 = array3;
			object obj44 = 0;
			bool flag18 = flag11;
			string text6 = (string)flag8;
			int num14 = 90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X9_v9+18]");
			string text7 = (string)0;
			object obj45 = 4294967295L;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj46 = 0;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v53+E4]");
				bool flag19 = (nint)0 == 0;
				object obj48 = !flag19;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj41 = array.Length;
				}
				bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41);
				object obj49 = !flag20;
				if (obj49 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
				object obj50 = 0;
				object obj51 = obj50;
				object obj54;
				if (selected == i)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v58+E4]");
					bool flag21 = (nint)0 == 0;
					object obj52 = !flag21;
					if (obj52 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
						object obj53 = 0;
						obj51 = obj53;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v58+A0]");
					obj54 = (nint)0 + (nint)104;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v58+E4]");
					bool flag22 = (nint)0 == 0;
					object obj55 = !flag22;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
						object obj56 = 0;
						obj51 = obj56;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v58+A0]");
					obj54 = (nint)0 + (nint)96;
				}
				object obj57 = obj45 + obj41;
				object obj58 = obj57 + obj57;
				num11 = obj43 - obj58;
				ScreenFont font = this.text;
				int y = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X25_v8+v540 @ X26_v10*8]");
				Text(font, num10, y, (string)0, (Color32[])obj54, 1, centred: true);
				obj41 = array.Length;
				obj44++;
				obj45--;
				bool flag23 = (nint)obj44 < array.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X25_v8+v540 @ X26_v10*8]");
				text5 = (string)0;
				flag16 = true;
				num12 = 1;
				array2 = (Color32[])obj54;
				flag18 = (byte)num11 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X25_v8+v540 @ X26_v10*8]");
				text6 = (string)0;
				num14 = num10;
				text7 = (string)(object)this.text;
				if (flag23)
				{
					continue;
				}
				goto IL_074f;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_074f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
		object obj59 = 0;
		string text8 = (string)obj59;
		int num15 = obj37 + 48;
		string text9 = ((int*)num15)->ToString((string)obj59);
		object obj60;
		if (this.text != null)
		{
			int num16 = this.text.Measure(text9, 1);
			obj60 = num16 + 14;
			int num11 = 0;
			int num17 = 1;
			text8 = text9;
		}
		else
		{
			int num17 = 0;
			obj60 = 40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj62 = 0;
		object obj63 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v29+E4]");
		bool flag24 = (nint)0 == 0;
		object obj64 = !flag24;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = (nint)obj60 < 0;
		object obj65 = obj60 ^ obj60;
		object obj66 = obj60 & obj65;
		bool flag26 = (nint)obj66 < 0;
		object obj67 = obj61;
		bool flag27 = flag25 == flag26;
		object obj68 = !flag27;
		object obj69 = ~obj68;
		object obj70 = ((obj69 != null) ? obj60 : ((object)(obj60 + 1)));
		object obj71 = num10 - obj70;
		object obj72 = obj12 + 138;
		RectInt r3 = (RectInt)(obj71 | obj72);
		if (selected == i)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v43+E4]");
			bool flag28 = (nint)0 == 0;
			object obj73 = !flag28;
			if (obj73 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj67 = obj61;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v43+A0]");
			object obj74 = (nint)0 + (nint)148;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v43+E4]");
			bool flag29 = (nint)0 == 0;
			object obj75 = !flag29;
			if (obj75 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj67 = obj61;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v43+A0]");
			object obj74 = (nint)0 + (nint)144;
		}
		Color32 c = (Color32)(obj60 | 0xA00000000L);
		FillRect(r3, c);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj76 = 0;
		object obj77 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X0_v34+E4]");
		bool flag30 = (nint)0 == 0;
		object obj78 = !flag30;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int x = obj71 + 2;
		int y2 = obj12 + 139;
		BoltIcon(x, y2, 1, onTag: true);
		object obj79 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v38+E4]");
		bool flag31 = (nint)0 == 0;
		object obj80 = !flag31;
		if (obj80 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj79 = obj61;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v38+A0]");
		object obj81 = 0;
		int x2 = obj71 + 11;
		int y3 = obj12 + 140;
		ScreenFont font2 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v41+80]");
		Text(font2, x2, y3, text9, (Color32[])0, 1, centred: false);
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
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
			obj5 = (nint)0 + (nint)80;
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
				obj5 = (nint)0 + (nint)68;
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
				obj5 = (nint)0 + (nint)72;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v57+50]");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v47+50]");
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
						obj77 = (nint)0 + (nint)80;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v42+44]");
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
						obj77 = (nint)0 + (nint)68;
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
		//IL_04c6: Expected Obj, but got I
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_0559: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I8
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0810: Expected Obj, but got I4
		//IL_0714: Expected Obj, but got I4
		//IL_05ef: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I
		//IL_067a: Expected Obj, but got I4
		//IL_07c3: Expected Obj, but got I4
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I4
		//IL_06b2: Expected Obj, but got I
		//IL_06c8: Expected Obj, but got I
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_048b: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I4
		//IL_03a7: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03eb: Expected Obj, but got I4
		bool flag = this.text == null;
		int num = width;
		List<System.__Canon> list = default;
		object obj2;
		string text5 = default;
		string text6;
		object obj10;
		string text;
		if (!flag)
		{
			int num2 = this.text.Measure(s, 1);
			bool flag2 = num2 <= width;
			num = 1;
			if (!flag2)
			{
				bool flag3 = s == null;
				text = s;
				if (!flag3)
				{
					string[] array = s.Split(' ', (StringSplitOptions)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					list._002Ector();
					bool flag4 = array == null;
					text = (string)(object)list;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						obj2 = 0;
						string text2 = (string)obj2;
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
							List<System.__Canon> list2 = list;
							while (true)
							{
								bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
								object obj9 = !flag5;
								if (obj9 != null)
								{
									break;
								}
								bool flag6 = text2 == null;
								obj10 = obj2;
								text = (string)(object)list;
								List<System.__Canon> list3;
								if (!flag6)
								{
									bool flag7 = text2._stringLength == 0;
									list3 = list2;
									if (flag7)
									{
										goto IL_0454;
									}
									string text3 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X29_v8+v141 @ X26_v9*8]");
									string text4 = text3 + (string)obj3 + (string)0;
									bool flag8 = text2._stringLength < 1;
									text5 = text4;
									obj8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X29_v8+v141 @ X26_v9*8]");
									stringSplitOptions = (StringSplitOptions)0;
									list2 = (List<System.__Canon>)(object)text4;
									if (flag8)
									{
										goto IL_07b9;
									}
									bool flag9 = this.text == null;
									text5 = text4;
									obj10 = obj2;
									text = (string)(object)list;
									if (!flag9)
									{
										int num3 = this.text.Measure(text4, 1);
										bool flag10 = num3 <= width;
										text5 = text4;
										obj8 = 0;
										stringSplitOptions = (StringSplitOptions)1;
										list2 = (List<System.__Canon>)num3;
										if (flag10)
										{
											goto IL_07b9;
										}
										bool flag11 = list == null;
										text5 = text4;
										obj10 = obj2;
										text = (string)(object)list;
										if (!flag11)
										{
											int stringLength = ((string)(object)list)._stringLength;
											obj10 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+1C]");
											object obj11 = (nint)0 + (nint)1;
											bool flag12 = ((string)(object)list)._stringLength == 0;
											text5 = text4;
											text = (string)(object)list;
											if (!flag12)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+18]");
												nint num4 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v30 (System.Int32)+18]");
												bool flag13 = num4 < 0;
												object obj12 = !flag13;
												if (obj12 == null)
												{
													int stringLength2 = ((string)(object)list)._stringLength;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+18]");
													object obj13 = (nint)stringLength2 + (nint)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+18]");
													obj2 = (nint)0 + (nint)1;
													object obj14 = obj13 + 32;
													obj14 = text2;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													obj8 = 0;
													stringSplitOptions = (StringSplitOptions)1;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X9_v3+20]");
													object obj15 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v31+A8]");
													object obj16 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v32+70]");
													stringSplitOptions = (StringSplitOptions)0;
													list.AddWithResize((System.__Canon)(object)text2);
													obj2 = obj10;
													obj8 = 0;
													list3 = list;
												}
												goto IL_0454;
											}
										}
									}
								}
								goto IL_0742;
								IL_0454:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X29_v8+v141 @ X26_v9*8]");
								text5 = (string)0;
								list2 = list3;
								goto IL_07b9;
								IL_07b9:
								obj5 = array.Length;
								obj7++;
								bool flag14 = (nint)obj7 < array.Length;
								text2 = text5;
								if (flag14)
								{
									continue;
								}
								goto IL_0471;
							}
							goto IL_0784;
						}
						bool flag15 = obj2 == null;
						text6 = (string)obj2;
						obj8 = 0;
						stringSplitOptions = (StringSplitOptions)0;
						text5 = (string)obj2;
						obj10 = obj2;
						text = (string)(object)list;
						if (!flag15)
						{
							goto IL_0588;
						}
					}
				}
				goto IL_0742;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array2 = default;
		bool flag16 = array2 == null;
		text = s;
		if (flag16)
		{
			goto IL_0742;
		}
		if (array2.Length != 0)
		{
			object obj18 = array2 + 32;
			obj18 = s;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return array2;
		}
		goto IL_0784;
		IL_0771:
		string text7;
		return (string[])(object)((List<System.__Canon>)(object)text7).ToArray();
		IL_0784:
		return (string[])(object)new IndexOutOfRangeException();
		IL_0588:
		System.__Canon item;
		if (text6._stringLength >= 1)
		{
			bool flag17 = list == null;
			text5 = text6;
			obj10 = obj2;
			text = (string)(object)list;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
				object obj19 = 0;
				int stringLength3 = ((string)(object)list)._stringLength;
				obj10 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+1C]");
				object obj20 = (nint)0 + (nint)1;
				bool flag18 = ((string)(object)list)._stringLength == 0;
				text5 = text6;
				text = (string)(object)list;
				if (!flag18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+18]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v22 (System.Int32)+18]");
					bool flag19 = num5 < 0;
					object obj21 = !flag19;
					item = (System.__Canon)(object)text6;
					text = (string)(object)list;
					if (obj21 == null)
					{
						int stringLength4 = ((string)(object)list)._stringLength;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+18]");
						object obj22 = (nint)stringLength4 + (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23 (System.Collections.Generic.List`1<System.__Canon>)+18]");
						object obj23 = (nint)0 + (nint)1;
						object obj24 = obj22 + 32;
						obj24 = text6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						text7 = (string)(object)list;
					}
					else
					{
						((List<System.__Canon>)(object)text).AddWithResize(item);
						text7 = text;
					}
					goto IL_0771;
				}
			}
		}
		else
		{
			bool flag20 = list == null;
			object obj25 = !flag20;
			text5 = text6;
			obj10 = obj2;
			text = (string)(object)list;
			text7 = (string)(object)list;
			if (obj25 != null)
			{
				goto IL_0771;
			}
		}
		goto IL_0742;
		IL_0471:
		bool flag21 = text5 == null;
		object obj26 = !flag21;
		text6 = text5;
		if (obj26 != null)
		{
			goto IL_0588;
		}
		obj10 = obj2;
		text = (string)(object)list;
		goto IL_0742;
		IL_0742:
		item = (System.__Canon)(object)text5;
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

	private void BoltIcon(int x, int y, int scale, bool onTag = default(bool))
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
		//IL_037b: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_03c1: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I4
		//IL_0438: Expected Obj, but got I
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected VT, but got Unknown
		//IL_057c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_0525;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X25_v6-10]");
		bool flag = (nint)0 < (nint)2;
		object obj7 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X25_v6-10]");
		object obj8 = -2;
		bool flag2 = obj8 == null;
		object obj9 = ~obj7;
		object obj10 = obj9 | flag2;
		object obj29;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X25_v10-20]");
			bool flag3 = (nint)0 < (nint)4;
			object obj15 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X25_v10-20]");
			object obj16 = -4;
			bool flag4 = obj16 == null;
			object obj17 = ~obj15;
			object obj18 = obj17 | flag4;
			if (obj18 == null)
			{
				object obj19 = obj2 + 64;
				obj19 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X25_v12-28]");
				bool flag5 = (nint)0 < (nint)5;
				object obj20 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X25_v12-28]");
				object obj21 = -5;
				bool flag6 = obj21 == null;
				object obj22 = ~obj20;
				object obj23 = obj22 | flag6;
				if (obj23 == null)
				{
					object obj24 = obj2 + 72;
					obj24 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X25_v14-30]");
					bool flag7 = (nint)0 < (nint)6;
					object obj25 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X25_v14-30]");
					object obj26 = -6;
					bool flag8 = obj26 == null;
					object obj27 = ~obj25;
					object obj28 = obj27 | flag8;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
						obj29 = 0;
						object obj30 = obj2 + 80;
						obj30 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj31 = obj29;
						if (onTag)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v23+E4]");
							bool flag9 = (nint)0 == 0;
							object obj32 = !flag9;
							if (obj32 == null)
							{
								goto IL_038d;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v23+E4]");
							bool flag10 = (nint)0 == 0;
							object obj33 = !flag10;
							if (obj33 == null)
							{
								goto IL_038d;
							}
						}
						goto IL_03e2;
					}
				}
			}
		}
		goto IL_0533;
		IL_0533:
		throw new IndexOutOfRangeException();
		IL_0525:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0533;
		IL_03e2:
		int num = scale | scale;
		object obj34 = 0;
		while (true)
		{
			object obj35 = obj34 * scale;
			object obj36 = y + obj35;
			object obj37 = obj2 + obj34;
			object obj38 = obj36 << 32;
			int num2 = 0;
			int num3 = x;
			while (true)
			{
				object obj39 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+18]");
				bool flag11 = (nint)obj39 < 0;
				object obj40 = !flag11;
				if (obj40 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X29_v4+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X29_v4+20]");
					char c = ((string)0).get_Chars(num2);
					int num4 = c & 0xFFFF;
					if (num4 != 46)
					{
						if ((object)this == null)
						{
							goto IL_0525;
						}
						int num5 = c & 0xFFFF;
						if (num5 == 35)
						{
						}
						RectInt r = (RectInt)(obj38 | num3);
						FillRect(r, (Color32)num);
					}
					num2++;
					num3 += scale;
					if (num2 != 7)
					{
						continue;
					}
					goto IL_04f6;
				}
				goto IL_0525;
			}
			break;
			IL_04f6:
			obj34++;
			if ((nint)obj34 == 7)
			{
				return;
			}
		}
		goto IL_0533;
		IL_038d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj41 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v32+E4]");
		bool flag12 = (nint)0 == 0;
		object obj42 = !flag12;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		goto IL_03e2;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
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

	public GillaBoltShop()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_021f: Expected F4, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_015a: Expected Obj, but got I8
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ca: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 48;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C350]");
		wakeRange = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj8 = this + 208;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj8 + 48;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj8 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = obj8 + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			object obj12 = array + 32;
			obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X21_v8-8]");
			object obj13 = 0 & 0xFFFFFFFEL;
			if (obj13 != null)
			{
				object obj14 = array + 40;
				obj14 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj15 = this + 296;
				downOn = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				shownBolts = -1;
				base._002Ector();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static GillaBoltShop()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I8
		//IL_02f2: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got I
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04af: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected Obj, but got Unknown
		//IL_05cb: Expected Obj, but got I
		//IL_0611: Expected Obj, but got I8
		//IL_063e: Expected Obj, but got I
		//IL_064e: Expected Obj, but got I
		//IL_065e: Expected Obj, but got I
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected Obj, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected Obj, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_074a: Expected Obj, but got I
		//IL_0798: Expected Obj, but got I4
		//IL_07ae: Expected Obj, but got I
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07f1: Expected Obj, but got I
		//IL_0801: Expected Obj, but got I
		//IL_0811: Expected Obj, but got I
		//IL_0821: Expected Obj, but got I
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected Obj, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected Obj, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Obj, but got Unknown
		//IL_0907: Expected Obj, but got I
		//IL_0955: Expected Obj, but got I4
		//IL_096b: Expected Obj, but got I
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected Obj, but got Unknown
		//IL_09ae: Expected Obj, but got I
		//IL_09be: Expected Obj, but got I
		//IL_09ce: Expected Obj, but got I
		//IL_09de: Expected Obj, but got I
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected Obj, but got Unknown
		//IL_0a16: Expected Obj, but got I
		//IL_0a4d: Expected Obj, but got I
		//IL_0a6a: Expected Obj, but got I
		//IL_0a87: Expected Obj, but got I
		//IL_0ab9: Expected Obj, but got I
		//IL_0ad3: Expected Obj, but got I
		//IL_0b0c: Expected Obj, but got I4
		//IL_0d85: Expected Obj, but got I
		//IL_0d95: Expected Obj, but got I
		//IL_0db2: Expected Obj, but got I
		//IL_0dcc: Expected Obj, but got I
		//IL_0de6: Expected Obj, but got I
		//IL_0e00: Expected Obj, but got I
		//IL_0e1a: Expected Obj, but got I
		//IL_0e34: Expected Obj, but got I
		//IL_0e4a: Expected Obj, but got I
		//IL_0e5a: Expected Obj, but got I
		//IL_0e84: Expected Obj, but got I
		//IL_0e9a: Expected Obj, but got I
		//IL_0ecc: Expected Obj, but got I
		//IL_0ee2: Expected Obj, but got I
		//IL_0ef2: Expected Obj, but got I
		//IL_0b59: Expected Obj, but got I
		//IL_0b6f: Expected Obj, but got I
		//IL_0b7f: Expected Obj, but got I
		//IL_0c24: Expected Obj, but got I
		//IL_0cd1: Expected Obj, but got I
		//IL_0cfb: Expected Obj, but got I
		//IL_0d15: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD48]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD50]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD58]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_ = 1065353216;
		object obj7 = default;
		obj7._002Ector();
		object obj8 = obj7 + 16;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj7 + 24;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 5;
		object obj10 = obj7 + 32;
		obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj7 + 40;
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = default;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+40]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		IndexOutOfRangeException ex = default;
		if (ex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC70]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDC0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD98]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD90]");
				object obj18 = 0;
				object obj19 = obj13 + 32;
				obj19 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				_ = 1065353216;
				object obj20 = default;
				obj20._002Ector();
				object obj21 = obj20 + 16;
				obj21 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj22 = obj20 + 24;
				obj22 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = 35;
				object obj23 = obj20 + 32;
				obj23 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj24 = obj20 + 40;
				obj24 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj25 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13+40]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				if (ex == null)
				{
					goto IL_0d2e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
				object obj26 = 0 & 0xFFFFFFFEL;
				if (obj26 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC68]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDC8]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDB8]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD88]");
					object obj30 = 0;
					object obj31 = obj13 + 40;
					obj31 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					_ = 1065353216;
					object obj32 = default;
					obj32._002Ector();
					object obj33 = obj32 + 16;
					obj33 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj34 = obj32 + 24;
					obj34 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 50;
					object obj35 = obj32 + 32;
					obj35 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj36 = obj32 + 40;
					obj36 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj37 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v17+40]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					if (ex == null)
					{
						goto IL_0d2e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
					bool flag = (nint)0 < (nint)2;
					object obj38 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
					object obj39 = -2;
					bool flag2 = obj39 == null;
					object obj40 = ~obj38;
					object obj41 = obj40 | flag2;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC58]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD78]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD70]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDA8]");
						object obj45 = 0;
						object obj46 = obj13 + 48;
						obj46 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						_ = 1065353216;
						object obj47 = default;
						obj47._002Ector();
						object obj48 = obj47 + 16;
						obj48 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj49 = obj47 + 24;
						obj49 = obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 100;
						object obj50 = obj47 + 32;
						obj50 = obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj51 = obj47 + 40;
						obj51 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1066611507;
						object obj52 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v23+40]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (ex == null)
						{
							goto IL_0d2e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
						object obj53 = 0 & 0xFFFFFFFCL;
						if (obj53 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC78]");
							object obj54 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD68]");
							object obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD80]");
							object obj56 = 0;
							object obj57 = obj13 + 56;
							obj57 = obj47;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							_ = 1065353216;
							object obj58 = default;
							obj58._002Ector();
							object obj59 = obj58 + 16;
							obj59 = obj54;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj60 = obj58 + 24;
							obj60 = obj55;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 400;
							object obj61 = obj58 + 32;
							obj61 = obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj62 = obj58 + 40;
							obj62 = obj56;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 1066611507;
							object obj63 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v29+40]");
							obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							if (ex == null)
							{
								goto IL_0d2e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
							bool flag3 = (nint)0 < (nint)4;
							object obj64 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
							object obj65 = -4;
							bool flag4 = obj65 == null;
							object obj66 = ~obj64;
							object obj67 = obj66 | flag4;
							if (obj67 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC80]");
								object obj68 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B80]");
								object obj69 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDA0]");
								object obj70 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDB0]");
								object obj71 = 0;
								object obj72 = obj13 + 64;
								obj72 = obj58;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								_ = 1065353216;
								object obj73 = default;
								obj73._002Ector();
								object obj74 = obj73 + 16;
								obj74 = obj68;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj75 = obj73 + 24;
								obj75 = obj69;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_ = 150;
								object obj76 = obj73 + 32;
								obj76 = obj70;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj77 = obj73 + 40;
								obj77 = obj71;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj78 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v33+40]");
								obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								if (ex == null)
								{
									goto IL_0d2e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
								bool flag5 = (nint)0 < (nint)5;
								object obj79 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
								object obj80 = -5;
								bool flag6 = obj80 == null;
								object obj81 = ~obj79;
								object obj82 = obj81 | flag6;
								if (obj82 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
									object obj83 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
									object obj84 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj85 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
									object obj86 = 0;
									object obj87 = obj13 + 72;
									obj87 = obj73;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj88 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v35+A0]");
									object obj89 = 0;
									obj89 = obj13;
									object obj90 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj91 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v38+A0]");
									object obj92 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F730]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v38+A0]");
									object obj93 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C7C0]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v38+A0]");
									object obj94 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7E0]");
									_ = 0;
									int num = Shader.PropertyToID((string)obj84);
									object obj95 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj96 = 0;
									_ = 4278584838L;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj97 = 0;
									object obj98 = obj85;
									_ = 4279045389L;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v130+E4]");
									bool flag7 = (nint)0 == 0;
									object obj99 = !flag7;
									if (obj99 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj98 = obj85;
										obj95 = obj83;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v130+A0]");
									object obj100 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj101 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X9_v11+2C]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj102 = 0;
									_ = 4284506208L;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj103 = 0;
									_ = 4280821800L;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj104 = 0;
									_ = 4294967295L;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj105 = 0;
									_ = 4288059030L;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj106 = 0;
									_ = 4282795590L;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v130+A0]");
									object obj107 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v41+A0]");
									object obj108 = (nint)0 + (nint)96;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X9_v18+8]");
									obj108 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj109 = obj85;
									object obj110 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v42+A0]");
									object obj111 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X9_v19+A0]");
									object obj112 = (nint)0 + (nint)104;
									obj112 = obj111;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj113 = obj85;
									object obj114 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v44+A0]");
									object obj115 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X9_v20+A0]");
									object obj116 = (nint)0 + (nint)112;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v45+10]");
									obj116 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj117 = obj85;
									object obj118 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v46+A0]");
									object obj119 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v21+A0]");
									object obj120 = (nint)0 + (nint)120;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v47+10]");
									obj120 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v144+18]");
									bool flag8 = (nint)0 == 0;
									object obj121 = default;
									obj14 = obj121;
									if (!flag8)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v144+18]");
										bool flag9 = (nint)0 == 1;
										_ = 4278584838L;
										obj14 = obj121;
										if (!flag9)
										{
											_ = 4278584838L;
											object obj122 = obj83;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v49+A0]");
											object obj123 = (nint)0 + (nint)128;
											obj123 = obj121;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v149+18]");
											bool flag10 = (nint)0 == 0;
											object obj124 = default;
											obj14 = obj124;
											if (!flag10)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v149+18]");
												bool flag11 = (nint)0 == 1;
												_ = 4294768368L;
												obj14 = obj124;
												if (!flag11)
												{
													_ = 4291671712L;
													object obj125 = obj83;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v53+A0]");
													object obj126 = (nint)0 + (nint)136;
													obj126 = obj124;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													object obj127 = obj83;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v54+A0]");
													object obj128 = 0;
													_ = 4292793028L;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v54+A0]");
													object obj129 = 0;
													_ = 4294636780L;
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
			ex = new IndexOutOfRangeException();
		}
		goto IL_0d2e;
		IL_0d2e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
	}
}
