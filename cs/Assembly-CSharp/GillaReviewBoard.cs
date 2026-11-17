using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaReviewBoard : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public GillaItem item;

		internal bool _003CWatch_003Eb__0(GillaRecycler.Going g)
		{
			//IL_0087: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			if (g != null)
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
				return g.item == item;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Renderer screen;

	public GillaLinkButton button;

	public Renderer label;

	public TextAsset titleFont;

	public TextAsset textFont;

	public const int W = default(int);

	public const int H = default(int);

	public const string Ask = null;

	public const string Thanks = null;

	public const string PlateAsk = null;

	private const int StarW = default(int);

	private const int StarH = default(int);

	private const int StarGap = default(int);

	private const int StarTop = default(int);

	private const float Every = default(float);

	private const float Empty = default(float);

	private const float Step = default(float);

	private const float Flash = default(float);

	private const float ThanksFor = default(float);

	private const int BarX = default(int);

	private const int BarY = default(int);

	private const int BarW = default(int);

	private const int BarH = default(int);

	private const float LabelPx = default(float);

	private const int LabelScale = default(int);

	private static readonly Color32[] Orange;

	private static readonly Color32[] Green;

	private static readonly Color32 StarRim;

	private static readonly Color32 StarGlint;

	private static readonly Color32 Hollow;

	private static readonly int BaseMap;

	private Texture2D tex;

	private Texture2D plateTex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private string shown;

	private float thanksUntil;

	private float start;

	private GillaLinkButton heard;

	private static sbyte[] starMask;

	private static readonly (int, int)[] Glint;

	private int Filled__BackingField;

	private string Showing__BackingField;

	private float BarShown__BackingField;

	private string PlateShowing__BackingField;

	public int Filled
	{
		get
		{
			return Filled__BackingField;
		}
		private set
		{
			Filled__BackingField = value;
		}
	}

	public string Showing
	{
		get
		{
			return Showing__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 152;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public float BarShown
	{
		get
		{
			return BarShown__BackingField;
		}
		private set
		{
			BarShown__BackingField = value;
		}
	}

	public Texture Drawn => tex;

	public string PlateShowing
	{
		get
		{
			return PlateShowing__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 168;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static float LabelWidth(TextAsset font)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66E8]");
		object obj4 = 0;
		int num;
		if (font != null)
		{
			string baked = font.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont = default;
			screenFont._002Ector(baked);
			num = screenFont.Measure((string)obj4, 3);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num = PixelFont.Measure((string)obj4, 3);
		}
		return (float)num / 1.1339039E+09f;
	}

	private void OnEnable()
	{
		float value = UnityEngine.Random.value;
		float num = value * 7f;
		start = num;
		Redraw(force: true);
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0090: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj5 = 0;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6738]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action action = default;
			action._002Ector(this, (IntPtr)obj7);
			heard.Opened -= action;
			obj5 = 0;
		}
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public void Refresh()
	{
		Redraw(force: true);
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01a0: Expected I, but got Obj
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
		object obj5 = this + 136;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == null)
		{
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (button != null)
			{
				heard = button;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6738]");
				object obj11 = 0;
				Action action = default;
				action._002Ector(this, (IntPtr)obj11);
				heard.Opened += action;
			}
		}
		Redraw(force: false);
	}

	private void Thanked()
	{
		float time = Time.time;
		float num = time + 1.1146363E+09f;
		thanksUntil = num;
		float time2 = Time.time;
		start = time2;
		Redraw(force: true);
	}

	private unsafe void Redraw(bool force)
	{
		//IL_0010: Expected Obj, but got I
		//IL_153f: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_00de: Expected F4, but got I4
		//IL_1577: Expected Obj, but got I4
		//IL_00be: Invalid comparison between F4 and I4
		//IL_011a: Expected F4, but got I4
		//IL_028f: Expected F4, but got I
		//IL_02d6: Invalid comparison between F4 and I4
		//IL_1abd: Expected Obj, but got I
		//IL_1ae7: Expected Obj, but got I4
		//IL_15f4: Invalid comparison between F4 and I
		//IL_0263: Invalid comparison between F4 and I
		//IL_016d: Expected Obj, but got I
		//IL_0180: Invalid comparison between F4 and I4
		//IL_02f8: Invalid comparison between F4 and I4
		//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b7: Expected Obj, but got Unknown
		//IL_15d1: Expected Obj, but got I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I8
		//IL_03f7: Expected Obj, but got I
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I
		//IL_0459: Expected Obj, but got I4
		//IL_049f: Expected Obj, but got I4
		//IL_04af: Expected Obj, but got I4
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_051c: Expected Obj, but got I8
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_058d: Expected Obj, but got I4
		//IL_05a3: Expected Obj, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected Obj, but got Unknown
		//IL_0618: Expected Obj, but got I4
		//IL_062e: Expected Obj, but got I
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected Obj, but got Unknown
		//IL_06b5: Expected Obj, but got I4
		//IL_06cb: Expected Obj, but got I
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected Obj, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected Obj, but got Unknown
		//IL_074a: Expected Obj, but got I4
		//IL_0753: Expected Obj, but got I4
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_087c: Expected Obj, but got I
		//IL_078c: Expected Obj, but got I4
		//IL_1638: Unknown result type (might be due to invalid IL or missing references)
		//IL_163d: Expected Obj, but got Unknown
		//IL_0867: Expected Obj, but got I
		//IL_08a6: Expected Obj, but got I
		//IL_07c4: Expected Obj, but got I4
		//IL_167f: Expected Obj, but got I
		//IL_169d: Expected Obj, but got I4
		//IL_0891: Expected Obj, but got I
		//IL_080b: Expected Obj, but got I4
		//IL_0814: Expected Obj, but got I4
		//IL_0903: Expected Obj, but got I
		//IL_08ee: Expected Obj, but got I
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected Obj, but got Unknown
		//IL_093d: Expected Obj, but got I4
		//IL_0980: Expected Obj, but got I4
		//IL_0a96: Expected Obj, but got I
		//IL_0ac0: Expected Obj, but got I4
		//IL_09a3: Expected Obj, but got I
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected Obj, but got Unknown
		//IL_0b36: Expected Obj, but got I4
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Expected Obj, but got Unknown
		//IL_0c71: Expected Obj, but got I4
		//IL_0a0e: Expected Obj, but got I
		//IL_0d8d: Expected Obj, but got I
		//IL_0daf: Expected Obj, but got I4
		//IL_0b80: Expected Obj, but got I4
		//IL_0a44: Expected Obj, but got I
		//IL_16da: Expected Obj, but got I
		//IL_16ea: Expected Obj, but got I
		//IL_16fa: Expected Obj, but got I
		//IL_1708: Expected Obj, but got Ref
		//IL_1733: Expected VT, but got Ref
		//IL_0ca9: Expected Obj, but got I4
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected Obj, but got Unknown
		//IL_0a79: Expected Obj, but got I4
		//IL_0de6: Expected Obj, but got I4
		//IL_0c35: Expected Obj, but got I4
		//IL_0d5e: Expected Obj, but got I4
		//IL_0bfb: Expected Obj, but got I
		//IL_0e13: Expected Obj, but got I4
		//IL_0e1c: Expected I4, but got Obj
		//IL_0d24: Expected Obj, but got I
		//IL_0c28: Expected I4, but got Obj
		//IL_0d51: Expected I4, but got Obj
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e37: Expected Obj, but got Unknown
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected I4, but got Unknown
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected I4, but got Unknown
		//IL_1764: Unknown result type (might be due to invalid IL or missing references)
		//IL_1769: Expected Obj, but got Unknown
		//IL_1780: Unknown result type (might be due to invalid IL or missing references)
		//IL_1785: Expected I4, but got Unknown
		//IL_179a: Unknown result type (might be due to invalid IL or missing references)
		//IL_179f: Expected I4, but got Unknown
		//IL_17e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ec: Expected Obj, but got Unknown
		//IL_0f2a: Expected Obj, but got I4
		//IL_189c: Expected Obj, but got I
		//IL_18ac: Expected Obj, but got I
		//IL_18b4: Expected VT, but got Ref
		//IL_0edb: Expected Obj, but got I4
		//IL_1b03: Expected Obj, but got Ref
		//IL_1b16: Expected native int or pointer, but got VT
		//IL_1b23: Expected native int or pointer, but got VT
		//IL_1b73: Expected Obj, but got I4
		//IL_1869: Expected Obj, but got I
		//IL_187f: Expected Obj, but got I
		//IL_1887: Expected VT, but got Ref
		//IL_18c9: Expected Obj, but got I
		//IL_18d7: Expected Obj, but got Ref
		//IL_1904: Expected VT, but got Ref
		//IL_0f7e: Expected Obj, but got I
		//IL_0fa4: Expected VT, but got I
		//IL_0fad: Invalid comparison between F4 and I4
		//IL_0fbc: Invalid comparison between F4 and I4
		//IL_0fcf: Expected Obj, but got F4
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Expected Obj, but got Unknown
		//IL_100c: Expected Obj, but got I4
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected Obj, but got Unknown
		//IL_1055: Expected Obj, but got I
		//IL_194f: Expected Obj, but got I4
		//IL_1040: Expected Obj, but got I
		//IL_1b91: Expected Obj, but got I
		//IL_1b9a: Invalid comparison between F4 and I4
		//IL_1ba9: Invalid comparison between F4 and I4
		//IL_1bbc: Expected Obj, but got F4
		//IL_1bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc9: Expected Obj, but got Unknown
		//IL_1be6: Expected Obj, but got Ref
		//IL_1bff: Expected Obj, but got I4
		//IL_1c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0c: Expected Obj, but got Unknown
		//IL_1c39: Expected VT, but got Ref
		//IL_1c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4e: Expected Obj, but got Unknown
		//IL_10da: Expected Obj, but got I4
		//IL_198e: Expected Obj, but got I
		//IL_1093: Expected Obj, but got I4
		//IL_1c8d: Expected Obj, but got I4
		//IL_1973: Expected Obj, but got I
		//IL_113b: Expected VT, but got Obj
		//IL_1144: Invalid comparison between F4 and I4
		//IL_1155: Expected Obj, but got I4
		//IL_115e: Invalid comparison between F4 and I4
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_117a: Expected Obj, but got Unknown
		//IL_199e: Expected Obj, but got I4
		//IL_19c4: Expected VT, but got I4
		//IL_1311: Expected Obj, but got I4
		//IL_1a5f: Expected Obj, but got I
		//IL_1a6d: Expected Obj, but got Ref
		//IL_1a87: Expected Obj, but got I
		//IL_1aa8: Expected VT, but got Ref
		//IL_1357: Expected Obj, but got I
		//IL_1396: Expected Obj, but got I4
		//IL_13dd: Expected Obj, but got I4
		//IL_126f: Expected Obj, but got I4
		//IL_1a3a: Expected Obj, but got I
		//IL_1a4a: Expected Obj, but got I
		//IL_1220: Expected Obj, but got I4
		//IL_13f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f6: Expected Obj, but got Unknown
		//IL_1410: Expected Obj, but got I4
		//IL_12ae: Expected Obj, but got I8
		//IL_1a25: Expected Obj, but got I
		//IL_1496: Expected Obj, but got I4
		//IL_1ca3: Expected VT, but got Obj
		//IL_1cc0: Expected VT, but got Obj
		//IL_14cb: Expected Obj, but got I
		//IL_142e: Expected Obj, but got I
		//IL_12d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
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
			float time = Time.time;
			float num = time - start;
			float num2 = num / 7f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num3 = num2 * 7f;
			float num4 = num - num3;
			if (!(num4 < 0f))
			{
				bool flag2 = (double)num4 > 7.0;
				float num5 = 7f;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
					bool flag3 = num4 < 0f;
					num5 = num4;
					if (flag3)
					{
						goto IL_1608;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
				num3 = 0f;
				float num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC44]");
				float num7 = num6 + 0f;
				float num8 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
				float num9 = num8 / 0f;
				float num10 = num9 + 1f;
				if (!(num10 < 5f))
				{
				}
				float num11 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB74]");
				if (!(num11 < 0f) && num10 < 5f)
				{
				}
			}
			goto IL_1608;
		}
		float num12 = 0f;
		goto IL_154d;
		IL_0908:
		object obj5 = obj4;
		object obj6 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X0_v59+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)obj6 == null;
		bool flag6 = !flag5;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(320, 240, (TextureFormat)4, mipChain: true);
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.hideFlags = (HideFlags)52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6710]");
			object obj11 = 0;
			texture2D.name = (string)obj11;
			tex = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj13 = this + 88;
			UnityEngine.Object obj14 = default;
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj8 = 0;
			obj9 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v64+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 320, 240);
		GillaBoardLook.Frame(px, 320, 240, 3);
		object obj18 = this + 104;
		bool flag8 = obj18 == null;
		object obj19 = !flag8;
		int num13 = 240;
		int num14 = 320;
		if (obj19 == null)
		{
			object obj20 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X0_v167+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = titleFont != null;
			bool flag11 = !flag10;
			num13 = 0;
			int num15 = 0;
			if (!flag11)
			{
				string baked = titleFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont = default;
				screenFont._002Ector(baked);
				num13 = 0;
				num15 = (int)screenFont;
			}
			obj18 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num14 = num15;
		}
		object obj23 = this + 112;
		bool flag12 = obj23 == null;
		object obj24 = !flag12;
		if (obj24 == null)
		{
			object obj25 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X0_v155+E4]");
			bool flag13 = (nint)0 == 0;
			object obj26 = !flag13;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = textFont != null;
			bool flag15 = !flag14;
			num13 = 0;
			int num16 = 0;
			if (!flag15)
			{
				string baked2 = textFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont2 = default;
				screenFont2._002Ector(baked2);
				num13 = 0;
				num16 = (int)screenFont2;
			}
			obj23 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num14 = num16;
		}
		object obj28 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6730]");
		object line = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X0_v71+E4]");
		bool flag16 = (nint)0 == 0;
		object obj29 = !flag16;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66F0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6700]");
		object line2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X0_v71+A0]");
		object obj31 = 0;
		object obj33 = default;
		object obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj33, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj34 = default;
		Line((ScreenFont)obj18, 12, 9, (string)line, (ShiftAuth.Style)(&obj34), centred: false);
		GillaBoardLook.Rule(px, 320, 240, 10, 309, 30);
		int num17 = 19;
		object obj35 = 0;
		bool flag17 = default;
		bool flag19 = default;
		int num18 = default;
		do
		{
			bool bright;
			if (flag17)
			{
				bright = true;
			}
			else
			{
				bool flag18 = !flag19;
				object obj36 = !flag18;
				bool flag20;
				bool flag21;
				if ((int)(~obj36) == 0)
				{
					object obj37 = obj35 - num18;
					flag20 = (nint)obj37 < 0;
					int num19 = obj35 ^ num18;
					object obj38 = obj35 ^ obj37;
					int num20 = num19 & obj38;
					flag21 = num20 < 0;
				}
				else
				{
					flag21 = false;
					flag20 = false;
				}
				bool flag22 = flag20 == flag21;
				bool flag23 = !flag22;
				bright = flag23;
			}
			object obj39 = obj35 - num18;
			bool flag24 = (nint)obj39 < 0;
			int num21 = obj35 ^ num18;
			object obj40 = obj35 ^ obj39;
			int num22 = num21 & obj40;
			bool flag25 = num22 < 0;
			bool flag26 = flag24 == flag25;
			bool filled = !flag26;
			Star(num17, 40, filled, bright);
			obj35++;
			num17 += 58;
		}
		while ((nint)obj35 != 5);
		object line3;
		object colours;
		ShiftAuth.Style style;
		if (flag19)
		{
			object obj41 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X0_v150+E4]");
			bool flag27 = (nint)0 == 0;
			object obj42 = !flag27;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj41 = obj30;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6708]");
			line3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X0_v150+A0]");
			colours = (nint)0 + (nint)8;
			object obj43 = default;
			style = (ShiftAuth.Style)(&obj43);
		}
		else
		{
			object obj44 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X0_v146+E4]");
			bool flag28 = (nint)0 == 0;
			object obj45 = !flag28;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj44 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X0_v146+A0]");
			colours = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6718]");
			line3 = 0;
			object obj46 = default;
			style = (ShiftAuth.Style)(&obj46);
		}
		object obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj33, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((ShiftAuth.Style*)(nint)style)->scale = 2;
		System.Runtime.CompilerServices.Unsafe.Write(&((ShiftAuth.Style*)(nint)style)->colours, colours);
		Line((ScreenFont)obj23, 160, 100, (string)line3, style, centred: true);
		object obj48 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1443 @ X0_v83+E4]");
		bool flag29 = (nint)0 == 0;
		object obj49 = !flag29;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj48 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1443 @ X0_v83+A0]");
		object obj50 = 0;
		object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj33, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj52 = default;
		Line(this.text, 160, 120, (string)line2, (ShiftAuth.Style)(&obj52), centred: true);
		GillaBoardLook.Rule(px, 320, 240, 10, 309, 138);
		object obj53 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v46+A0]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X8_v47+18]");
		Fill(10, 146, 300, 84, (Color32)0);
		float num23;
		bool flag30 = num23 < 0f;
		bool flag31 = num23 == 0f;
		object obj55 = num23 ^ num23;
		object obj56 = num23 & obj55;
		bool flag32 = (nint)obj56 < 0;
		object obj57 = obj30;
		bool flag33 = flag30 == flag32;
		object obj58 = !flag31;
		object obj59 = flag33 & obj58;
		object obj60 = ~obj59;
		object line4;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6720]");
			line4 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6728]");
			line4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1500 @ X0_v90+E4]");
		bool flag34 = (nint)0 == 0;
		object obj61 = !flag34;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj57 = obj30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1500 @ X0_v90+A0]");
		object obj62 = 0;
		bool flag35 = num23 < 0f;
		bool flag36 = num23 == 0f;
		object obj63 = num23 ^ num23;
		object obj64 = num23 & obj63;
		bool flag37 = (nint)obj64 < 0;
		object obj65 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj33, 16));
		bool flag38 = flag35 == flag37;
		object obj66 = !flag36;
		object obj67 = flag38 & obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj68 = default;
		Line(this.text, 160, 160, (string)line4, (ShiftAuth.Style)(&obj68), centred: true);
		object obj69 = obj15;
		object obj70 = flag19 | obj67;
		object obj72;
		if (obj70 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X0_v95+E4]");
			bool flag39 = (nint)0 == 0;
			object obj71 = !flag39;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj69 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X0_v95+A0]");
			obj72 = (nint)0 + (nint)44;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X0_v95+E4]");
			bool flag40 = (nint)0 == 0;
			object obj73 = !flag40;
			if (obj73 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj69 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X0_v95+A0]");
			obj72 = (nint)0 + (nint)40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X0_v95+E4]");
		bool flag41 = (nint)0 == 0;
		object obj74 = !flag41;
		if (obj74 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Box(px, 320, 240, 60, 178, 200, 12, (Color32)obj72);
		bool flag42 = num23 < 0f;
		object obj75 = !flag42;
		bool flag43 = num23 == 0f;
		object obj76 = ~obj75;
		object obj77 = obj76 | flag43;
		object obj78 = ~obj77;
		bool flag44 = obj78 != null || !flag19;
		object obj79 = !flag44;
		int num25 = default;
		int num24 = ((obj79 != null) ? 196 : num25);
		bool flag45 = num24 < 1;
		Color32 color = (Color32)200;
		int num26 = 178;
		int num27 = 60;
		int num28 = 240;
		int num29 = 320;
		if (!flag45)
		{
			int num30 = (flag19 ? num24 : num25);
			object obj82;
			if (flag44)
			{
				object obj80 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ X0_v131+E4]");
				bool flag46 = (nint)0 == 0;
				object obj81 = !flag46;
				if (obj81 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj80 = obj15;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ X0_v131+A0]");
				obj82 = (nint)0 + (nint)44;
			}
			else
			{
				object obj83 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v127+E4]");
				bool flag47 = (nint)0 == 0;
				object obj84 = !flag47;
				if (obj84 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj83 = obj30;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v127+A0]");
				object obj85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1659 @ X8_v69+8]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v70+18]");
				object obj87 = 0 & 0xFFFFFFFEL;
				if (obj87 == null)
				{
					goto IL_1500;
				}
				obj82 = obj86 + 36;
				num30 = 196;
			}
			color = (Color32)obj82;
			Fill(62, 180, num30, 8, (Color32)obj82);
			num26 = 8;
			num27 = num30;
			num28 = 180;
			num29 = 62;
		}
		object obj88 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1635 @ X0_v100+E4]");
		bool flag48 = (nint)0 == 0;
		object obj89 = !flag48;
		if (obj89 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj88 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1635 @ X0_v100+A0]");
		object obj90 = 0;
		object obj91 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj33, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66F8]");
		object line5 = 0;
		object obj92 = default;
		Line((ScreenFont)obj23, 160, 204, (string)line5, (ShiftAuth.Style)(&obj92), centred: true);
		tex.SetPixels32(px);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj93 = 0;
		tex.Apply(updateMipmaps: true);
		object obj94 = obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X0_v106+E4]");
		bool flag49 = (nint)0 == 0;
		object obj95 = !flag49;
		if (obj95 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag50 = screen == null;
		bool flag51 = !flag50;
		object obj96 = !flag51;
		if (obj96 == null)
		{
			object obj97 = this + 96;
			bool flag52 = obj97 == null;
			object obj98 = !flag52;
			if (obj98 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj99 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock = default;
				materialPropertyBlock._002Ector();
				obj97 = materialPropertyBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			screen.GetPropertyBlock((MaterialPropertyBlock)obj97);
			object obj100 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ X0_v112+E4]");
			bool flag53 = (nint)0 == 0;
			object obj101 = !flag53;
			if (obj101 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj102 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X8_v63+A0]");
			object obj103 = 0;
			object obj104 = obj97;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v64+1C]");
			((MaterialPropertyBlock)obj104).SetTexture(0, (Texture)tex);
			screen.SetPropertyBlock((MaterialPropertyBlock)obj97);
		}
		return;
		IL_1616:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string text = num18.ToString();
		string[] array = default;
		if (array.Length != 0)
		{
			object obj105 = array + 32;
			obj105 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X22_v4-8]");
			object obj106 = 0 & 0xFFFFFFFEL;
			if (obj106 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
				object obj107 = 0;
				object obj108 = array + 40;
				obj108 = obj107;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj109 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v17+30]");
				object obj110 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X0_v28+E4]");
				bool flag54 = (nint)0 == 0;
				object obj111 = !flag54;
				if (obj111 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text2 = flag17.ToString();
				bool flag55 = array.Length < 2;
				object obj112 = !flag55;
				object obj113 = array.Length - 2;
				bool flag56 = obj113 == null;
				object obj114 = ~obj112;
				object obj115 = obj114 | flag56;
				if (obj115 == null)
				{
					object obj116 = array + 48;
					obj116 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X22_v6-18]");
					object obj117 = 0 & 0xFFFFFFFCL;
					if (obj117 != null)
					{
						object obj118 = array + 56;
						obj118 = obj107;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						string text3 = flag19.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X22_v8-20]");
						bool flag57 = (nint)0 < (nint)4;
						object obj119 = !flag57;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X22_v8-20]");
						object obj120 = -4;
						bool flag58 = obj120 == null;
						object obj121 = ~obj119;
						object obj122 = obj121 | flag58;
						if (obj122 == null)
						{
							object obj123 = array + 64;
							obj123 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X22_v10-28]");
							bool flag59 = (nint)0 < (nint)5;
							object obj124 = !flag59;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X22_v10-28]");
							object obj125 = -5;
							bool flag60 = obj125 == null;
							object obj126 = ~obj124;
							object obj127 = obj126 | flag60;
							if (obj127 == null)
							{
								object obj128 = array + 72;
								obj128 = obj107;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text4 = num25.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X22_v12-30]");
								bool flag61 = (nint)0 < (nint)6;
								object obj129 = !flag61;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X22_v12-30]");
								object obj130 = -6;
								bool flag62 = obj130 == null;
								object obj131 = ~obj129;
								object obj132 = obj131 | flag62;
								if (obj132 == null)
								{
									object obj133 = array + 80;
									obj133 = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text5 = string.Concat(array);
									bool flag63 = !force;
									object obj134 = !flag63;
									object obj135 = 0;
									if (obj134 == null)
									{
										bool flag64 = text5 == shown;
										bool flag65 = !flag64;
										obj135 = 0;
										if (!flag65)
										{
											object obj136 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X0_v197+E4]");
											bool flag66 = (nint)0 == 0;
											object obj137 = !flag66;
											if (obj137 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag67 = tex != null;
											bool flag68 = !flag67;
											object obj138 = !flag68;
											obj135 = 0;
											if (obj138 != null)
											{
												return;
											}
										}
									}
									object obj139 = this + 120;
									obj139 = text5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Filled__BackingField = num18;
									object obj140;
									if (!flag19)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6718]");
										obj140 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6708]");
										obj140 = 0;
									}
									object obj141 = this + 152;
									obj141 = obj140;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj142;
									if (!flag19)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66E8]");
										obj142 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6708]");
										obj142 = 0;
									}
									string text6 = (string)obj142;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X21_v13+10]");
									bool flag69 = (string)0 != (string)obj142;
									bool flag70 = !flag69;
									object obj143 = !flag70;
									bool flag72;
									if (obj143 == null)
									{
										bool flag71 = !force;
										flag72 = flag19;
										if (flag71)
										{
											goto IL_0908;
										}
									}
									object obj144;
									if (!flag19)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66E8]");
										obj144 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6708]");
										obj144 = 0;
									}
									text6 = (string)obj144;
									Plate((string)obj144);
									flag72 = flag19;
									goto IL_0908;
								}
							}
						}
					}
				}
			}
		}
		goto IL_1500;
		IL_1608:
		num12 = Time.time;
		goto IL_154d;
		IL_159a:
		double num33;
		double num32;
		double num31 = num32 + num33;
		object obj145 = num32 & 1;
		bool flag73 = obj145 == null;
		object obj146 = !flag73;
		if (obj146 != null)
		{
			num32 = num31;
		}
		goto IL_1616;
		IL_154d:
		object obj147 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v7+E4]");
		bool flag74 = (nint)0 == 0;
		object obj148 = !flag74;
		if (obj148 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag75 = button != null;
		bool flag76 = !flag75;
		num23 = 0f;
		UnityEngine.Object obj149 = null;
		if (!flag76)
		{
			float held = button.Held;
			num23 = held;
			obj149 = null;
		}
		float num34 = num23 * 1.1285299E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj150 = 0;
		object obj151 = obj150;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v13+E4]");
		bool flag77 = (nint)0 == 0;
		object obj152 = !flag77;
		if (obj152 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj153 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num35 = default;
		if (num34 < 0f)
		{
			if ((double)num34 == -0.5)
			{
				num33 = -1.0;
				num32 = num35;
				goto IL_159a;
			}
			num32 = (double)num34 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num31 = -0.5;
		}
		else
		{
			if ((double)num34 == 0.5)
			{
				num33 = 1.0;
				num32 = num35;
				goto IL_159a;
			}
			num32 = (double)num34 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num31 = 0.5;
		}
		goto IL_1616;
		IL_1500:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void Plate(string line)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected Obj, but got Unknown
		//IL_0d7a: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_0d98: Expected Obj, but got I
		//IL_0dc2: Expected Obj, but got I4
		//IL_0125: Invalid comparison between Obj and F8
		//IL_00e7: Invalid comparison between Obj and F8
		//IL_0e3d: Invalid comparison between F8 and I4
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Expected Obj, but got Unknown
		//IL_0e5e: Expected Obj, but got F8
		//IL_0ea3: Expected Obj, but got I4
		//IL_01c4: Expected F8, but got I4
		//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ded: Expected Obj, but got Unknown
		//IL_0e07: Expected Obj, but got I4
		//IL_0ed3: Invalid comparison between F8 and I4
		//IL_0ee2: Invalid comparison between F8 and I4
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected Obj, but got Unknown
		//IL_0f03: Expected Obj, but got F8
		//IL_0f38: Expected Obj, but got I4
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected Obj, but got Unknown
		//IL_01df: Expected F8, but got I4
		//IL_130a: Expected Obj, but got I4
		//IL_0206: Invalid comparison between F8 and I4
		//IL_0fc4: Invalid comparison between F8 and I4
		//IL_0fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Expected Obj, but got Unknown
		//IL_0fe5: Expected Obj, but got F8
		//IL_101a: Expected Obj, but got I4
		//IL_0321: Expected F8, but got I4
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected Obj, but got Unknown
		//IL_0f98: Expected Obj, but got I4
		//IL_104a: Invalid comparison between F8 and I4
		//IL_1059: Invalid comparison between F8 and I4
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Expected Obj, but got Unknown
		//IL_107a: Expected Obj, but got F8
		//IL_10af: Expected Obj, but got I4
		//IL_10b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bc: Expected Obj, but got Unknown
		//IL_033c: Expected F8, but got I4
		//IL_10e3: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_0510: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I8
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I
		//IL_043e: Invalid comparison between F8 and I4
		//IL_0451: Expected Obj, but got F8
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I4
		//IL_111a: Expected Obj, but got I4
		//IL_060b: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I4
		//IL_1151: Invalid comparison between F8 and I4
		//IL_1160: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Expected Obj, but got Unknown
		//IL_1172: Expected Obj, but got F8
		//IL_11af: Expected Obj, but got I4
		//IL_0693: Expected Obj, but got I
		//IL_069c: Invalid comparison between F8 and I4
		//IL_06af: Expected Obj, but got F8
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06e4: Expected Obj, but got I4
		//IL_0587: Expected Obj, but got I
		//IL_11d4: Expected I4, but got F8
		//IL_11e2: Expected I4, but got F8
		//IL_1204: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_1328: Expected Obj, but got I
		//IL_1336: Expected Obj, but got Ref
		//IL_1365: Expected I4, but got F8
		//IL_1365: Expected I4, but got F8
		//IL_1371: Expected VT, but got Obj
		//IL_1379: Expected Obj, but got I4
		//IL_1391: Expected I4, but got F8
		//IL_139a: Expected F8, but got I4
		//IL_13a2: Expected I4, but got F8
		//IL_13aa: Expected I4, but got Obj
		//IL_123b: Invalid comparison between F8 and I4
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_124f: Expected Obj, but got Unknown
		//IL_125c: Expected Obj, but got F8
		//IL_1299: Expected Obj, but got I4
		//IL_05d4: Expected Obj, but got I4
		//IL_05e5: Expected Obj, but got I4
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected Obj, but got Unknown
		//IL_087f: Expected Obj, but got I4
		//IL_08c4: Expected Obj, but got I4
		//IL_12d2: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I4
		//IL_13bf: Expected Obj, but got I
		//IL_0b30: Expected Obj, but got I
		//IL_0b55: Expected I4, but got F8
		//IL_0b55: Expected I4, but got F8
		//IL_08fc: Expected Obj, but got I
		//IL_090e: Invalid comparison between Obj and F8
		//IL_0a07: Expected Obj, but got I
		//IL_0a31: Expected Obj, but got I4
		//IL_0789: Expected I4, but got F8
		//IL_0797: Expected I4, but got F8
		//IL_07b9: Expected Obj, but got I4
		//IL_0b99: Expected Obj, but got I
		//IL_0804: Expected VT, but got I
		//IL_0804: Expected I4, but got F8
		//IL_0804: Expected I4, but got F8
		//IL_0814: Expected VT, but got I
		//IL_083d: Expected I4, but got F8
		//IL_0845: Expected I4, but got F8
		//IL_0af0: Expected Obj, but got I4
		//IL_094a: Expected Obj, but got I
		//IL_095c: Invalid comparison between Obj and F8
		//IL_0a9e: Expected Obj, but got I4
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Expected Obj, but got Unknown
		//IL_0c1e: Expected Obj, but got I4
		//IL_0c8a: Expected Obj, but got I
		//IL_0cb4: Expected Obj, but got I4
		//IL_0ce9: Expected Obj, but got I
		//IL_0c3c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = this + 168;
		obj2 = line;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v3-78]");
		bool flag2 = (UnityEngine.Object)0 == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		Transform transform = label.transform;
		Vector3 lossyScale = transform.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj6 = 0 * 1133903872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num;
		double num2;
		double num3 = default;
		if ((nint)obj6 < 0)
		{
			if (obj6 == (object)(-0.5))
			{
				num = -1.0;
				num2 = num3;
				goto IL_0dd0;
			}
			num2 = (double)obj6 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (obj6 == (object)0.5)
			{
				num = 1.0;
				num2 = num3;
				goto IL_0dd0;
			}
			num2 = (double)obj6 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0e1a;
		IL_0400:
		ScreenFont screenFont;
		int num4 = screenFont.Measure(line, 3);
		double num6;
		double num5 = num6 - (double)num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj10 = 0;
		bool flag5 = num5 < 0.0;
		object obj11 = num5 ^ num5;
		object obj12 = num5 & obj11;
		bool flag6 = (nint)obj12 < 0;
		double num8;
		double num7 = num8 - 20.0;
		bool flag7 = flag5 == flag6;
		object obj13 = !flag7;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			num5++;
		}
		double num9 = num8 - 21.0;
		double num10 = num8 - 21.0;
		bool flag8 = num10 < 0.0;
		object obj15 = num8 ^ 0x15;
		object obj16 = num8 ^ num10;
		object obj17 = obj15 & obj16;
		bool flag9 = (nint)obj17 < 0;
		object obj18 = obj10;
		bool flag10 = flag8 == flag9;
		object obj19 = !flag10;
		object obj20 = ~obj19;
		if (obj20 == null)
		{
			num9 = num7;
		}
		int num11 = num9 >> 1;
		int num12 = num5 >> 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v108+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v108+A0]");
		object obj22 = 0;
		ShiftAuth.Style s = default;
		object obj23 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Color32[] array = default;
		int num13 = screenFont.Draw(array, (int)num6, (int)num8, num12, num11, line, ref s);
		Color32 color = (Color32)line;
		string text = (string)num11;
		int num14 = num12;
		int num15 = (int)(&s);
		int num16 = (int)num8;
		double num17 = 0.0;
		int num18 = (int)num6;
		int num19 = (int)array;
		goto IL_084a;
		IL_0d1e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0dd0:
		double num20 = num2 + num;
		object obj24 = num2 & 1;
		bool flag12 = obj24 == null;
		object obj25 = !flag12;
		if (obj25 != null)
		{
			num2 = num20;
		}
		goto IL_0e1a;
		IL_0e1a:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num21 = num2 - 1024.0;
		bool flag13 = num21 < 0.0;
		object obj26 = num2 ^ 0x400;
		object obj27 = num2 ^ num21;
		object obj28 = obj26 & obj27;
		bool flag14 = (nint)obj28 < 0;
		double num22 = num2 * 1133903872.0;
		bool flag15 = flag13 == flag14;
		object obj29 = !flag15;
		object obj30 = ~obj29;
		double num23 = ((obj30 != null) ? 1024.0 : num2);
		double num24 = num23 - 16.0;
		bool flag16 = num24 < 0.0;
		bool flag17 = num24 == 0.0;
		object obj31 = num23 ^ 0x10;
		object obj32 = num23 ^ num24;
		object obj33 = obj31 & obj32;
		bool flag18 = (nint)obj33 < 0;
		bool flag19 = flag16 == flag18;
		object obj34 = !flag17;
		object obj35 = flag19 & obj34;
		object obj36 = ~obj35;
		num6 = ((obj36 != null) ? 16.0 : num23);
		object obj37 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v20+E4]");
		bool flag20 = (nint)0 == 0;
		object obj38 = !flag20;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num25;
		double num26;
		if (num22 < 0.0)
		{
			if (num22 == -0.5)
			{
				num25 = -1.0;
				num17 = num3;
				goto IL_0f61;
			}
			num17 = num22 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num26 = -0.5;
		}
		else
		{
			if (num22 == 0.5)
			{
				num25 = 1.0;
				num17 = num3;
				goto IL_0f61;
			}
			num17 = num22 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num26 = 0.5;
		}
		goto IL_0fab;
		IL_0f61:
		num26 = num17 + num25;
		object obj39 = num17 & 1;
		bool flag21 = obj39 == null;
		object obj40 = !flag21;
		if (obj40 != null)
		{
			num17 = num26;
		}
		goto IL_0fab;
		IL_0fab:
		double num27 = num17 - 256.0;
		bool flag22 = num27 < 0.0;
		object obj41 = num17 ^ 0x100;
		object obj42 = num17 ^ num27;
		object obj43 = obj41 & obj42;
		bool flag23 = (nint)obj43 < 0;
		bool flag24 = flag22 == flag23;
		object obj44 = !flag24;
		object obj45 = ~obj44;
		double num28 = ((obj45 != null) ? 256.0 : num17);
		double num29 = num28 - 8.0;
		bool flag25 = num29 < 0.0;
		bool flag26 = num29 == 0.0;
		object obj46 = num28 ^ 8;
		object obj47 = num28 ^ num29;
		object obj48 = obj46 & obj47;
		bool flag27 = (nint)obj48 < 0;
		bool flag28 = flag25 == flag27;
		object obj49 = !flag26;
		object obj50 = flag28 & obj49;
		object obj51 = ~obj50;
		num8 = ((obj51 != null) ? 8.0 : num28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj52 = 0;
		double num30 = num8 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (array.Length < 1)
		{
			goto IL_03d0;
		}
		object obj53 = array.Length & 0xFFFFFFFFL;
		object obj54 = array + 32;
		object obj55 = 0;
		while (true)
		{
			bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53);
			object obj56 = !flag29;
			if (obj56 != null)
			{
				break;
			}
			obj53 = array.Length;
			_ = 4278190080L;
			obj55++;
			if ((nint)obj55 < array.Length)
			{
				continue;
			}
			goto IL_03d0;
		}
		goto IL_0d1e;
		IL_0bd9:
		object obj57;
		((Texture2D)obj57).SetPixels32(array);
		((Texture2D)obj57).Apply(true);
		object obj58 = this + 96;
		bool flag30 = obj58 == null;
		object obj59 = !flag30;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj58 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		label.GetPropertyBlock((MaterialPropertyBlock)obj58);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66F0]");
		object obj61 = 0;
		object obj62 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X0_v38+E4]");
		bool flag31 = (nint)0 == 0;
		object obj63 = !flag31;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj64 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v28+A0]");
		object obj65 = 0;
		object obj66 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v29+1C]");
		((MaterialPropertyBlock)obj66).SetTexture(0, (Texture)plateTex);
		label.SetPropertyBlock((MaterialPropertyBlock)obj58);
		return;
		IL_03d0:
		object obj67 = this + 104;
		screenFont = (ScreenFont)obj67;
		if (obj67 != null)
		{
			goto IL_0400;
		}
		object obj68 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v79+E4]");
		bool flag32 = (nint)0 == 0;
		object obj69 = !flag32;
		if (obj69 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag33 = titleFont != null;
		bool flag34 = !flag33;
		object obj70 = 0;
		UnityEngine.Object obj71 = null;
		if (!flag34)
		{
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			obj67 = screenFont2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag35 = screenFont2 == null;
			object obj73 = !flag35;
			screenFont = screenFont2;
			obj70 = 0;
			obj71 = (UnityEngine.Object)(object)screenFont2;
			if (obj73 != null)
			{
				goto IL_0400;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj74 = 0;
		object obj75 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v84+E4]");
		bool flag36 = (nint)0 == 0;
		object obj76 = !flag36;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num31 = PixelFont.Measure(line, 3);
		double num32 = num6 - (double)num31;
		double num33 = num8 - 20.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj77 = 0;
		bool flag37 = num32 < 0.0;
		object obj78 = num32 ^ num32;
		object obj79 = num32 & obj78;
		bool flag38 = (nint)obj79 < 0;
		bool flag39 = flag37 == flag38;
		object obj80 = !flag39;
		object obj81 = ~obj80;
		double num34 = ((obj81 != null) ? num32 : (num32 + 1.0));
		double num35 = num8 - 21.0;
		double num36 = num8 - 21.0;
		bool flag40 = num36 < 0.0;
		object obj82 = num8 ^ 0x15;
		object obj83 = num8 ^ num36;
		object obj84 = obj82 & obj83;
		bool flag41 = (nint)obj84 < 0;
		object obj85 = obj77;
		bool flag42 = flag40 == flag41;
		object obj86 = !flag42;
		object obj87 = ~obj86;
		double num37 = ((obj87 != null) ? num35 : num33);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v89+E4]");
		bool flag43 = (nint)0 == 0;
		object obj88 = !flag43;
		if (obj88 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj85 = obj77;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v89+A0]");
		object obj89 = 0;
		object obj90 = obj89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v51+18]");
		if ((nint)0 != 0)
		{
			object obj91 = obj74;
			int num38 = num34 >> 1;
			int num39 = num37 >> 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v90+E4]");
			bool flag44 = (nint)0 == 0;
			object obj92 = !flag44;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v51+20]");
			PixelFont.Draw(array, (int)num6, (int)num8, num38, num39, line, (Color32)0, 3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v51+20]");
			color = (Color32)0;
			text = line;
			num14 = num39;
			num15 = 3;
			num16 = num38;
			num18 = (int)num8;
			num19 = (int)num6;
			goto IL_084a;
		}
		goto IL_0d1e;
		IL_084a:
		object obj93 = obj;
		obj57 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X0_v29+E4]");
		bool flag45 = (nint)0 == 0;
		object obj94 = !flag45;
		if (obj94 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag46 = (UnityEngine.Object)obj57 == null;
		bool flag47 = !flag46;
		object obj95 = !flag47;
		UnityEngine.Object obj96 = null;
		bool flag49;
		TextureFormat textureFormat;
		if (obj95 == null)
		{
			object obj97 = obj57;
			object obj98 = obj97;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v43+190]");
			obj96 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v405 @ X8_v43+188] (should have been resolved before IL gen)");
			object obj99 = default;
			if (obj99 == (object)num6)
			{
				object obj100 = obj57;
				object obj101 = obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v44+1B0]");
				obj96 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v968 @ X8_v44+1A8] (should have been resolved before IL gen)");
				object obj102 = default;
				bool flag48 = obj102 == (object)num8;
				flag49 = (byte)num14 != 0;
				textureFormat = (TextureFormat)num16;
				if (flag48)
				{
					goto IL_0bd9;
				}
			}
		}
		object obj103 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X0_v48+E4]");
		bool flag50 = (nint)0 == 0;
		object obj104 = !flag50;
		if (obj104 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag51 = (UnityEngine.Object)obj57 != null;
		bool flag52 = !flag51;
		UnityEngine.Object obj105 = null;
		if (!flag52)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj106 = 0;
			object obj107 = obj106;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X0_v61+E4]");
			bool flag53 = (nint)0 == 0;
			object obj108 = !flag53;
			if (obj108 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			object obj109 = obj;
			if (isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v65+E4]");
				bool flag54 = (nint)0 == 0;
				object obj110 = !flag54;
				if (obj110 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy((UnityEngine.Object)obj57);
				obj105 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v65+E4]");
				bool flag55 = (nint)0 == 0;
				object obj111 = !flag55;
				if (obj111 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)obj57);
				obj105 = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Texture2D texture2D = default;
		texture2D._002Ector((int)num6, (int)num8, (TextureFormat)4, mipChain: true);
		texture2D.filterMode = (FilterMode)0;
		texture2D.wrapMode = (TextureWrapMode)1;
		texture2D.hideFlags = (HideFlags)52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6740]");
		object obj113 = 0;
		texture2D.name = (string)obj113;
		obj57 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		text = null;
		flag49 = true;
		textureFormat = (TextureFormat)4;
		goto IL_0bd9;
	}

	private void Star(int x, int y, bool filled, bool bright)
	{
		//IL_0010: Expected Obj, but got I
		//IL_08b2: Expected Obj, but got I4
		//IL_0d6e: Expected Obj, but got I
		//IL_0d7e: Expected Obj, but got I
		//IL_0da0: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_08d0: Expected Obj, but got I
		//IL_08e0: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		//IL_00ac: Expected I4, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_026b: Invalid comparison between F8 and I4
		//IL_027a: Invalid comparison between F8 and I4
		//IL_0292: Expected Obj, but got F8
		//IL_029f: Expected Obj, but got F8
		//IL_02d4: Expected Obj, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_090f: Invalid comparison between F8 and I4
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected Obj, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09d7: Expected VT, but got Obj
		//IL_0320: Expected F8, but got I4
		//IL_0dbf: Expected Obj, but got I4
		//IL_0de6: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_0e04: Expected Obj, but got I
		//IL_0e14: Expected Obj, but got I
		//IL_0a0c: Expected Obj, but got I
		//IL_0a24: Expected Obj, but got VT
		//IL_0a4e: Expected Obj, but got I
		//IL_0a64: Expected Obj, but got I
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected Obj, but got Unknown
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got Unknown
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected Obj, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Expected Obj, but got Unknown
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected Obj, but got Unknown
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected Obj, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected Obj, but got Unknown
		//IL_0ba4: Expected VT, but got Obj
		//IL_03be: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I8
		//IL_041a: Expected Obj, but got I4
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected Obj, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_0587: Expected Obj, but got I4
		//IL_0c45: Expected Obj, but got I
		//IL_0c55: Expected VT, but got I
		//IL_0528: Expected Obj, but got I4
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected I4, but got Unknown
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Expected I4, but got Unknown
		//IL_0c1b: Expected I4, but got VT
		//IL_0c30: Expected VT, but got I
		//IL_067e: Expected Obj, but got I4
		//IL_0558: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I4
		//IL_0ca4: Expected Obj, but got I
		//IL_0cb4: Expected Obj, but got I
		//IL_0c6a: Expected VT, but got I
		//IL_04ac: Expected Obj, but got I8
		//IL_06b3: Expected Obj, but got I
		//IL_05fe: Expected Obj, but got I
		//IL_04d9: Expected VT, but got I
		//IL_06e1: Expected Obj, but got I4
		//IL_0d50: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I4
		//IL_0cc9: Expected Obj, but got I
		//IL_0cd9: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected Obj, but got Unknown
		//IL_078e: Expected Obj, but got I4
		//IL_07cb: Expected Obj, but got I4
		//IL_0840: Expected Obj, but got I
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_07fb: Expected Obj, but got I4
		//IL_0d22: Expected VT, but got I
		//IL_082b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66F0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v49+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v49+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v4+20]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		int num = x;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v49+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			sbyte[] array = MakeStar();
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v62+A0]");
			object obj9 = (nint)0 + (nint)32;
			obj9 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num = (int)array;
		}
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v6+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v8+30]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj14 = 0;
		int num2 = y;
		bool flag5 = filled;
		object obj15 = 0;
		object obj16 = 0;
		double num4 = default;
		double num5 = default;
		object obj34 = default;
		object obj40 = default;
		object obj55 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+18]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+18]");
			if ((nint)0 == 1)
			{
				break;
			}
			object obj17 = obj;
			double num3 = (double)obj15 / 1111228416.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+24]");
			object obj18 = (nint)0 >> 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+20]");
			object obj19 = (nint)0 >> 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+24]");
			object obj20 = (nint)0 & (nint)0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+20]");
			object obj21 = obj20 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+20]");
			object obj22 = (nint)0 & (nint)0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
			object obj23 = obj18 - obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			object obj24 = num4 & 0xFF000000FFL;
			object obj25 = num5 & 0xFF000000FFL;
			double num6 = num3 - 1.0;
			bool flag6 = num6 < 0.0;
			bool flag7 = num6 == 0.0;
			object obj26 = num3 ^ 1.0;
			object obj27 = num3 ^ num6;
			object obj28 = obj26 & obj27;
			bool flag8 = (nint)obj28 < 0;
			bool flag9 = flag6 == flag8;
			object obj29 = !flag9;
			object obj30 = obj29 | flag7;
			object obj31 = ~obj30;
			double num7 = ((obj31 != null) ? 1.0 : num3);
			object obj32 = obj24 - obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			double num8 = ((!(num3 < 0.0)) ? num7 : 0.0);
			object obj33 = obj32 * obj34;
			double num9 = num8 * (double)obj23;
			double num10 = num8 * (double)obj21;
			object obj35 = obj33 + obj25;
			num4 = num10 + (double)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			num5 = num9 + (double)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
			object obj36 = num4 & 0xFF;
			object obj37 = obj35 & 0xFF0000FF0000L;
			object obj38 = obj37 | num5;
			object obj39 = obj38 | obj36;
			Color32 color = (Color32)(obj39 | obj40);
			bool flag10 = !bright;
			object obj41 = obj22;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
				bool flag11 = (nint)0 == 0;
				object obj42 = !flag11;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+A0]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj44 = color >> 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v52+14]");
				object obj45 = (nint)0 >> 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v52+14]");
				object obj46 = (nint)0 & (nint)0xFF;
				object obj47 = obj46 - obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				object obj48 = obj45 - obj44;
				object obj49 = num4 & 0xFF;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
				object obj50 = obj37 & 0xFF000000FFL;
				double num11 = (double)obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
				num9 = num11 * 0.0;
				object obj51 = num5 & 0xFF000000FFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
				object obj52 = obj48 * 0;
				object obj53 = obj51 - obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				object obj54 = obj53 * obj55;
				object obj56 = obj54 + obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				num5 = (double)obj52 + (double)obj44;
				num4 = num9 + (double)obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
				obj37 = obj56 & 0xFF0000FF0000L;
				object obj57 = num4 & 0xFF;
				object obj58 = obj37 | num5;
				object obj59 = obj58 | obj57;
				color = (Color32)(obj59 | obj40);
				obj41 = obj49;
			}
			object obj60 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
				bool flag12 = (nint)0 == 0;
				object obj61 = !flag12;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+A0]");
				object obj62 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v47+20]");
				object obj63 = 0;
				object obj64 = obj16 + obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X9_v14+18]");
				bool flag13 = (nint)obj64 < 0;
				object obj65 = !flag13;
				if (obj65 != null)
				{
					break;
				}
				object obj66 = obj63 + obj16;
				object obj67 = obj66 + obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v16+20]");
				object obj68 = 0 & 0x80000000L;
				bool flag14 = obj68 == null;
				object obj69 = !flag14;
				if (obj69 == null)
				{
					Color32 color2;
					if (filled)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v16+20]");
						bool flag15 = (nint)0 != 1;
						color2 = color;
						if (!flag15)
						{
							if (bright)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+18]");
								object obj70 = 0 & 0xFFFFFFFEL;
								if (obj70 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+24]");
								color2 = (Color32)0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
								bool flag16 = (nint)0 == 0;
								object obj71 = !flag16;
								if (obj71 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj72 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v48+A0]");
									obj62 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v47+10]");
								color2 = (Color32)0;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v16+20]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
							bool flag17 = (nint)0 == 0;
							object obj73 = !flag17;
							if (obj73 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj74 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v45+A0]");
								obj62 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v47+18]");
							color2 = (Color32)0;
						}
						else
						{
							object obj75 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v34+E4]");
							bool flag18 = (nint)0 == 0;
							object obj76 = !flag18;
							if (obj76 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj75 = obj14;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v34+A0]");
							object obj77 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v43+1C]");
							color2 = (Color32)0;
						}
					}
					num = x + obj60;
					num2 = obj15 + y;
					Dot(num, num2, color2);
					obj17 = obj;
					flag5 = (byte)(int)color2 != 0;
				}
				obj60++;
				if ((nint)obj60 != 50)
				{
					continue;
				}
				goto IL_0603;
			}
			break;
			IL_0603:
			obj15++;
			obj16 += 50;
			if ((nint)obj15 != 48)
			{
				continue;
			}
			if (!filled)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
			bool flag19 = (nint)0 == 0;
			object obj78 = !flag19;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+A0]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v31+28]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X20_v11+18]");
			object obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X20_v11+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			object obj82 = 0;
			while (true)
			{
				bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj82) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj81);
				object obj83 = !flag20;
				if (obj83 != null)
				{
					break;
				}
				object obj84 = obj80 + obj82;
				object obj85 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v21+E4]");
				bool flag21 = (nint)0 == 0;
				object obj86 = !flag21;
				if (obj86 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj85 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v21+A0]");
				object obj87 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v38+20]");
				object obj88 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v34+24]");
				object obj89 = (nint)0 * (nint)50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v34+20]");
				object obj90 = 0 + obj89;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v22+18]");
				bool flag22 = (nint)obj90 < 0;
				object obj91 = !flag22;
				if (obj91 != null)
				{
					break;
				}
				object obj92 = obj88 + obj90;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X9_v23+20]");
				bool flag23 = (nint)0 == 0;
				object obj93 = !flag23;
				if (obj93 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v21+E4]");
					bool flag24 = (nint)0 == 0;
					object obj94 = !flag24;
					if (obj94 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj95 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v39+A0]");
						obj87 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v34+20]");
					num = (int)((nint)0 + (nint)x);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v34+24]");
					num2 = (int)((nint)0 + (nint)y);
					int x2 = num;
					int y2 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v38+14]");
					Dot(x2, y2, (Color32)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v38+14]");
					flag5 = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X20_v11+18]");
				obj81 = 0;
				obj82++;
				object obj96 = obj82;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X20_v11+18]");
				if ((nint)obj96 >= 0)
				{
					return;
				}
			}
			break;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Dot(int x, int y, Color32 c)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		bool flag = x < 319;
		object obj = !flag;
		object obj2 = x - 319;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		bool flag3 = y < 239;
		object obj5 = !flag3;
		object obj6 = y - 239;
		bool flag4 = obj6 == null;
		object obj7 = !flag4;
		object obj8 = obj5 & obj7;
		if (obj8 != null)
		{
			return;
		}
		Color32[] array = px;
		if (px != null)
		{
			object obj9 = 239 - y;
			object obj10 = obj9 * 320;
			object obj11 = x + obj10;
			bool flag5 = (nint)obj11 < array.Length;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				object obj13 = (object)px + obj11;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe static sbyte[] MakeStar()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_095b: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected Obj, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_090c: Expected Obj, but got F8
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected Obj, but got Unknown
		//IL_0a26: Expected Obj, but got I4
		//IL_09e4: Expected Obj, but got I4
		//IL_09ed: Expected Obj, but got I4
		//IL_09f6: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0135: Expected F8, but got Obj
		//IL_015a: Invalid comparison between F8 and I4
		//IL_0169: Invalid comparison between F8 and I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01eb: Invalid comparison between F8 and I4
		//IL_01fa: Invalid comparison between F8 and I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected Obj, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I
		//IL_0370: Invalid comparison between VT and I4
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_03b2: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_046e: Expected Obj, but got I4
		//IL_0aa8: Expected I4, but got Obj
		//IL_0ada: Invalid comparison between VT and I4
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04b2: Expected Obj, but got I4
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_0529: Expected Obj, but got I4
		//IL_07bd: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got Ref
		//IL_0749: Expected Obj, but got I4
		//IL_07d4: Expected Obj, but got I4
		//IL_05c0: Expected Obj, but got I4
		//IL_0617: Expected Obj, but got Ref
		//IL_0769: Expected Obj, but got I4
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected Obj, but got Unknown
		//IL_080f: Expected Obj, but got I4
		//IL_0657: Expected Obj, but got I4
		//IL_06a0: Expected Obj, but got Ref
		//IL_06e0: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I4
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected Obj, but got Unknown
		//IL_0733: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6750]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66F0]");
			object obj5 = 0;
			object obj6 = obj2 + 36;
			object obj7 = 0;
			object obj15 = default;
			object obj16 = default;
			GillaRip.Shape._003C_003Ec__DisplayClass71_0 obj45 = default;
			sbyte[] array = default;
			while (true)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+18]");
				bool flag = (nint)obj8 < 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					object obj10 = obj7 & 1;
					bool flag2 = obj10 == null;
					object obj11 = !flag2;
					double num = ((obj11 != null) ? 10.5 : 25.0);
					object obj12 = obj7 * 1108344832;
					object obj13 = obj12 + 1119092736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
					object obj14 = obj13 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
					obj7++;
					double num2 = num * (double)obj15;
					double num3 = num * (double)obj16;
					double num4 = num2 + 25.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB28]");
					double num5 = 0.0 - num3;
					obj6 = num5;
					obj6 += 8;
					if ((nint)obj7 != 10)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj17 = obj2 + 32;
					object obj18 = obj2 + 36;
					object obj19 = 0;
					while (true)
					{
						object obj20 = obj19 * 50;
						double num6 = (double)obj19 + 0.5;
						object obj21 = 0;
						object obj38;
						while (true)
						{
							double num7 = (double)obj21 + 0.5;
							object obj22 = obj18;
							object obj23 = 0;
							object obj24 = 0;
							object obj25 = 9;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+18]");
								if (0 == (nint)obj23)
								{
									break;
								}
								object obj26 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+18]");
								bool flag3 = (nint)obj26 < 0;
								object obj27 = !flag3;
								if (obj27 != null)
								{
									break;
								}
								double num8 = (double)obj22;
								object obj28 = obj17 + obj25;
								double num9 = (double)obj22 - num6;
								bool flag4 = num9 < 0.0;
								bool flag5 = num9 == 0.0;
								object obj29 = obj22 ^ num6;
								object obj30 = obj22 ^ num9;
								object obj31 = obj29 & obj30;
								bool flag6 = (nint)obj31 < 0;
								bool flag7 = flag4 == flag6;
								object obj32 = !flag5;
								object obj33 = flag7 & obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X1_v11+4]");
								double num10 = 0.0 - num6;
								bool flag8 = num10 < 0.0;
								bool flag9 = num10 == 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X1_v11+4]");
								object obj34 = 0 ^ num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X1_v11+4]");
								object obj35 = 0 ^ num10;
								object obj36 = obj34 & obj35;
								bool flag10 = (nint)obj36 < 0;
								bool flag11 = flag8 == flag10;
								object obj37 = !flag11;
								obj38 = obj37 | flag9;
								object obj39 = obj33 ^ obj38;
								object obj40 = obj39 & 1;
								bool flag12 = obj40 == null;
								object obj41 = !flag12;
								if (obj41 == null)
								{
									object obj42 = obj25 << 3;
									double num11 = num6 - (double)obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X1_v11+4]");
									double num12 = 0.0 - (double)obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X10_v3+v628 @ X0_v50]");
									nint num13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X17_v6-4]");
									object obj43 = num13 - 0;
									double num14 = num11 * (double)obj43;
									double num15 = num14 / num12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X17_v6-4]");
									num8 = 0.0 + num15;
									if (num7 < num8)
									{
										obj24 ^= 1;
									}
								}
								object obj44 = obj23 + 1;
								obj25 = obj23 & 0xFFFFFFFFL;
								obj22 += 8;
								bool flag13 = (nint)obj44 != 10;
								obj23 = obj44;
								if (flag13)
								{
									continue;
								}
								goto IL_0367;
							}
							break;
							IL_0367:
							if (obj45 == (GillaRip.Shape._003C_003Ec__DisplayClass71_0)(object)0)
							{
								goto end_IL_093a;
							}
							object obj46 = obj21 + obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ stack_-88_v5 (GillaRip+Shape+<>c__DisplayClass71_0)+18]");
							bool flag14 = (nint)obj46 < 0;
							object obj47 = !flag14;
							if (obj47 != null)
							{
								break;
							}
							obj21++;
							object obj48 = obj24 & 1;
							object obj49 = obj45 + obj46;
							if ((nint)obj21 != 50)
							{
								continue;
							}
							goto IL_040e;
						}
						break;
						IL_040e:
						obj19++;
						if ((nint)obj19 != 48)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj50 = array + 32;
						object obj51 = obj38;
						int num16 = 2400;
						object obj52 = 0;
						sbyte[] array2 = array;
						int num17 = 0;
						while (true)
						{
							int num18 = num17 + 1;
							int num19 = num17 - 1;
							int num20 = 0;
							bool flag15 = (byte)(int)array2 != 0;
							while (obj45 != (GillaRip.Shape._003C_003Ec__DisplayClass71_0)(object)0)
							{
								object obj53 = obj52 + num20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ stack_-88_v5 (GillaRip+Shape+<>c__DisplayClass71_0)+18]");
								bool flag16 = (nint)obj53 < 0;
								object obj54 = !flag16;
								if (obj54 != null)
								{
									goto end_IL_09fb;
								}
								object obj55 = obj45 + obj52;
								object obj56 = obj55 + num20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v15+20]");
								object obj66;
								if ((nint)0 != 0)
								{
									object obj57 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v28+E4]");
									bool flag17 = (nint)0 == 0;
									object obj58 = !flag17;
									if (obj58 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int a = num20 - 1;
									flag15 = _003CMakeStar_003Eg__In_007C71_0(a, num17, ref obj45);
									bool flag18 = !flag15;
									obj51 = (object)(&obj45);
									num16 = num17;
									if (!flag18)
									{
										object obj59 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v34+E4]");
										bool flag19 = (nint)0 == 0;
										object obj60 = !flag19;
										if (obj60 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int a2 = num20 + 1;
										flag15 = _003CMakeStar_003Eg__In_007C71_0(a2, num17, ref obj45);
										bool flag20 = !flag15;
										obj51 = (object)(&obj45);
										num16 = num17;
										if (!flag20)
										{
											object obj61 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v38+E4]");
											bool flag21 = (nint)0 == 0;
											object obj62 = !flag21;
											if (obj62 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											flag15 = _003CMakeStar_003Eg__In_007C71_0(num20, num19, ref obj45);
											bool flag22 = !flag15;
											obj51 = (object)(&obj45);
											num16 = num19;
											if (!flag22)
											{
												object obj63 = obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v42+E4]");
												bool flag23 = (nint)0 == 0;
												object obj64 = !flag23;
												if (obj64 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												flag15 = _003CMakeStar_003Eg__In_007C71_0(num20, num18, ref obj45);
												object obj65 = !flag15;
												obj66 = 1 & obj65;
												obj51 = (object)(&obj45);
												num16 = num18;
												goto IL_0a2b;
											}
										}
									}
									obj66 = 1;
									goto IL_0a2b;
								}
								if (array == null)
								{
									break;
								}
								bool flag24 = (nint)obj53 < array.Length;
								object obj67 = !flag24;
								if (obj67 != null)
								{
									goto end_IL_09fb;
								}
								obj66 = 255;
								goto IL_0a48;
								IL_0a2b:
								if (array == null)
								{
									break;
								}
								bool flag25 = (nint)obj53 < array.Length;
								object obj68 = !flag25;
								object obj69 = ~obj68;
								if (obj69 == null)
								{
									goto end_IL_09fb;
								}
								goto IL_0a48;
								IL_0a48:
								num20++;
								if (num20 != 50)
								{
									continue;
								}
								goto IL_07d9;
							}
							break;
							IL_07d9:
							obj50 += 50;
							obj52 += 50;
							bool flag26 = num18 != 48;
							array2 = (sbyte[])flag15;
							num17 = num18;
							if (!flag26)
							{
								return array;
							}
						}
						goto end_IL_093a;
						continue;
						end_IL_09fb:
						break;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				break;
				continue;
				end_IL_093a:
				break;
			}
		}
		return (sbyte[])(object)new NullReferenceException();
	}

	private unsafe void Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style, bool centred = default(bool))
	{
		//IL_0067: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I4, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_031e: Expected I4, but got Obj
		//IL_02cb: Expected Ref, but got VT
		//IL_004b: Expected Ref, but got VT
		//IL_0133: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_029d: Expected VT, but got Ref
		int num2 = default;
		if (font != null)
		{
			if (centred)
			{
				int num = font.DrawCentred(px, 320, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
			}
			else
			{
				int num3 = font.Draw(px, 320, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
			}
			return;
		}
		object obj = style.scale - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num4 = style.scale ^ 1;
		int num5 = style.scale ^ obj;
		int num6 = num4 & num5;
		bool flag3 = num6 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num7 = ((obj4 != null) ? 1 : style.scale);
		bool flag5 = !centred;
		int num8 = (int)font;
		int x2 = num2;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num9 = PixelFont.Measure(line, num7);
			bool flag7 = num9 < 0;
			int num10 = num9 ^ num9;
			int num11 = num9 & num10;
			bool flag8 = num11 < 0;
			bool flag9 = flag7 == flag8;
			object obj8 = !flag9;
			object obj9 = ~obj8;
			int num12 = ((obj9 != null) ? num9 : (num9 + 1));
			x2 = num2 - num12;
			num8 = num7;
		}
		Color32[] colours = style.colours;
		if (style.colours != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v7+E4]");
			bool flag10 = (nint)0 == 0;
			object obj12 = !flag10;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PixelFont.Draw(px, 320, 240, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), num7);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Fill(int x, int y, int w, int h, Color32 colour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
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
		PixelFont.Fill(px, 320, 240, x, y, w, h, colour2);
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I8
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I8
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6758]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj3 = default;
			object obj2 = obj3 + 32;
			obj2 = tex;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X21_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				Texture2D texture2D = plateTex;
				object obj5 = obj3 + 40;
				obj5 = plateTex;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X20_v5-10]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X20_v5-10]");
				object obj8 = 0 & 0xFFFFFFFFL;
				object obj9 = obj3 + 32;
				object obj10 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
					object obj11 = !flag;
					if (obj11 != null)
					{
						break;
					}
					object obj12 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v14+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X24_v5+v140 @ X21_v10*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					UnityEngine.Object obj14 = null;
					if (!flag4)
					{
						object obj15 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v19+E4]");
						bool flag5 = (nint)0 == 0;
						object obj16 = !flag5;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool isPlaying = Application.isPlaying;
						object obj17 = obj6;
						if (isPlaying)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v23+E4]");
							bool flag6 = (nint)0 == 0;
							object obj18 = !flag6;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X24_v5+v140 @ X21_v10*8]");
							UnityEngine.Object.Destroy((UnityEngine.Object)0);
							obj14 = null;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v23+E4]");
							bool flag7 = (nint)0 == 0;
							object obj19 = !flag7;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X24_v5+v140 @ X21_v10*8]");
							UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0);
							obj14 = null;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
					obj8 = 0;
					obj10++;
					object obj20 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
					bool flag8 = (nint)obj20 < 0;
					texture2D = (Texture2D)obj14;
					if (!flag8)
					{
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public GillaReviewBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6718]");
		object obj = 0;
		thanksUntil = -1f;
		Filled__BackingField = 5;
		object obj2 = this + 152;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaReviewBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I8
		//IL_02d9: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I8
		//IL_03ad: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0431: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_049e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 4285120255L;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66F0]");
				object obj2 = 0;
				_ = 4279859440L;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v8+A0]");
				object obj4 = 0;
				object obj5 = default;
				obj4 = obj5;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+18]");
					bool flag2 = (nint)0 == 1;
					_ = 4285464460L;
					if (!flag2)
					{
						_ = 4280866600L;
						object obj7 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6760]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E0]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v14+A0]");
						object obj11 = (nint)0 + (nint)8;
						object obj12 = default;
						obj11 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj13 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+A0]");
						object obj14 = 0;
						_ = 4279794366L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+A0]");
						object obj15 = 0;
						_ = 4292672255L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+A0]");
						object obj16 = 0;
						_ = 4282795590L;
						int num = Shader.PropertyToID((string)obj8);
						object obj17 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v17+A0]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						(int, int) tuple = (23, 8);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
						if ((nint)0 != 0)
						{
							_ = 0;
							(int, int) tuple2 = (23, 9);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
							object obj19 = 0 & 0xFFFFFFFEL;
							if (obj19 != null)
							{
								_ = 0;
								(int, int) tuple3 = (22, 10);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
								bool flag3 = (nint)0 < (nint)2;
								object obj20 = !flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
								object obj21 = -2;
								bool flag4 = obj21 == null;
								object obj22 = ~obj20;
								object obj23 = obj22 | flag4;
								if (obj23 == null)
								{
									_ = 0;
									(int, int) tuple4 = (22, 11);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
									object obj24 = 0 & 0xFFFFFFFCL;
									if (obj24 != null)
									{
										_ = 0;
										(int, int) tuple5 = (22, 12);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
										bool flag5 = (nint)0 < (nint)4;
										object obj25 = !flag5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
										object obj26 = -4;
										bool flag6 = obj26 == null;
										object obj27 = ~obj25;
										object obj28 = obj27 | flag6;
										if (obj28 == null)
										{
											_ = 0;
											(int, int) tuple6 = (21, 13);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
											bool flag7 = (nint)0 < (nint)5;
											object obj29 = !flag7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+18]");
											object obj30 = -5;
											bool flag8 = obj30 == null;
											object obj31 = ~obj29;
											object obj32 = obj31 | flag8;
											if (obj32 == null)
											{
												_ = 0;
												object obj33 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v31+A0]");
												object obj34 = (nint)0 + (nint)40;
												object obj35 = default;
												obj34 = obj35;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal static bool _003CMakeStar_003Eg__In_007C71_0(int a, int b, ref GillaRip.Shape._003C_003Ec__DisplayClass71_0 P_2)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got VT
		//IL_00e7: Invalid comparison between VT and I4
		//IL_01a2: Expected I4, but got Obj
		//IL_0109: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		bool flag = a < 49;
		object obj = !flag;
		object obj2 = a - 49;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		bool result = false;
		if (obj4 == null)
		{
			bool flag3 = b < 47;
			object obj5 = !flag3;
			object obj6 = b - 47;
			bool flag4 = obj6 == null;
			object obj7 = !flag4;
			object obj8 = obj5 & obj7;
			result = false;
			if (obj8 == null)
			{
				object obj9 = P_2;
				if (P_2 != (GillaRip.Shape._003C_003Ec__DisplayClass71_0)(object)0)
				{
					object obj10 = b * 50;
					object obj11 = a + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+18]");
					bool flag5 = (nint)obj11 < 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						object obj13 = P_2 + obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4+20]");
						bool flag6 = (nint)0 == 0;
						bool flag7 = !flag6;
						result = flag7;
						goto IL_01a2;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				return (byte)(int)ex2 != 0;
			}
		}
		goto IL_01a2;
		IL_01a2:
		return result;
	}
}
