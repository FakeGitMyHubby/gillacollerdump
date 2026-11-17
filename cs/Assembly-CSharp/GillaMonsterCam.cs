using System;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GillaMonsterCam : MonoBehaviour
{
	public Renderer screen;

	public Renderer label;

	public TextAsset titleFont;

	public TextAsset textFont;

	public int width;

	public int height;

	public float fps;

	public float range;

	public float fov = 80f;

	public static bool ShowYours;

	private static float drawnAt;

	private const int LW = default(int);

	private const int LH = default(int);

	private static readonly int BaseMap;

	private static readonly Color32 Black;

	private static readonly Color32 Scan;

	private static readonly Color32 Lit;

	private static readonly Color32[] HeadText;

	private static readonly Color32[] DimText;

	private Camera cam;

	private RenderTexture rt;

	private Texture2D standby;

	private GillaMapVote.Canvas strip;

	private ScreenFont title;

	private ScreenFont text;

	private MaterialPropertyBlock block;

	private float next;

	private int shown;

	public static bool Watched
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_005f: Expected Obj, but got I4
			//IL_007d: Expected Obj, but got I
			//IL_00b1: Invalid comparison between F4 and I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
			object obj = 0;
			float unscaledTime = Time.unscaledTime;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+A0]");
			object obj4 = 0;
			float num = unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+4]");
			float num2 = num - 0f;
			float num3 = num2 - 0.5f;
			return num3 < 0f;
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I4
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
		//IL_02f0: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I
		//IL_036c: Expected I4, but got I8
		//IL_026b: Expected Obj, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
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
		object obj6 = this + 120;
		obj6 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X21_v4-40]");
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
		object obj11 = this + 128;
		obj11 = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X21_v7-58]");
		bool flag8 = (UnityEngine.Object)0 != null;
		bool flag9 = !flag8;
		int num = 0;
		UnityEngine.Object obj15 = null;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GillaMapVote.Canvas canvas = default;
			canvas._002Ector(label, 256, 24);
			object obj17 = this + 112;
			obj17 = canvas;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num = 256;
			obj15 = (UnityEngine.Object)(object)canvas;
		}
		object obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v24+A0]");
		object obj20 = 0;
		shown = -1;
		_ = 4286578688L;
		Show(live: false);
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
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
		bool flag2 = rt != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			rt.Release();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v31+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Gone(rt);
			obj4 = null;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (standby != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v25+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Gone(standby);
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (cam != null)
		{
			GameObject o = cam.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v11+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Gone(o);
		}
	}

	private static void Gone(UnityEngine.Object o)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		object obj5 = obj3;
		if (isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(o);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(o);
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_084a: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0870: Expected Obj, but got I
		//IL_0892: Expected Obj, but got I4
		//IL_09a5: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I
		//IL_09d7: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_08ca: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I4
		//IL_0428: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I4
		//IL_04a5: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_08e8: Expected Obj, but got I
		//IL_08f2: Expected I4, but got Obj
		//IL_08fb: Expected I4, but got Obj
		//IL_0906: Expected Obj, but got I4
		//IL_090e: Expected I4, but got Obj
		//IL_0578: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I4
		//IL_063c: Expected Obj, but got I4
		//IL_06c1: Expected Obj, but got I
		//IL_06f8: Expected Obj, but got I4
		//IL_092c: Expected Obj, but got I
		//IL_0808: Invalid comparison between F4 and I4
		//IL_0988: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj6;
		}
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v13+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X9_v3+8]");
		UnityEngine.Object obj15 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = (UnityEngine.Object)current != (UnityEngine.Object)null;
		bool flag7 = !flag6;
		object obj17 = 0;
		UnityEngine.Object obj18 = null;
		UnityEngine.Object obj19 = null;
		if (!flag7)
		{
			bool live = current.Live;
			bool flag8 = !live;
			obj17 = 0;
			obj18 = null;
			if (!flag8)
			{
				byte phase = current.Phase;
				int num = phase & 0xFF;
				bool flag9 = num != 1;
				obj17 = 0;
				obj18 = null;
				if (!flag9)
				{
					object obj20 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v82+E4]");
					bool flag10 = (nint)0 == 0;
					object obj21 = !flag10;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X9_v3+8]");
					bool flag11 = (UnityEngine.Object)0 != null;
					bool flag12 = !flag11;
					obj17 = 0;
					obj18 = null;
					obj19 = null;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X22_v4 (UnityEngine.Object)+90]");
						bool flag13 = (nint)0 != 1;
						obj17 = 0;
						obj18 = null;
						if (flag13)
						{
							goto IL_032d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v86+E4]");
						bool flag14 = (nint)0 == 0;
						object obj24 = !flag14;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NetworkApe networkApe = Hunter(current);
						obj17 = 0;
						obj18 = null;
						obj19 = networkApe;
					}
					goto IL_08a0;
				}
			}
			goto IL_032d;
		}
		goto IL_08a0;
		IL_08a0:
		object obj25 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v18+E4]");
		bool flag15 = (nint)0 == 0;
		object obj26 = !flag15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj19 != null)
		{
			object obj27 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v24+E4]");
			bool flag16 = (nint)0 == 0;
			object obj28 = !flag16;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v8 (UnityEngine.Object)+68]");
			if ((UnityEngine.Object)0 != null && ((NetworkApe)obj19).IsMonster)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj29 = 0;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v30+E4]");
				bool flag17 = (nint)0 == 0;
				object obj31 = !flag17;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (MonsterPlayer.IsMonster)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
					object obj32 = 0;
					object obj33 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v68+E4]");
					bool flag18 = (nint)0 == 0;
					object obj34 = !flag18;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj33 = obj32;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v68+A0]");
					object obj35 = 0;
					Show((byte)(int)obj35 != 0);
					bool flag19 = (byte)(int)(~obj35) != 0;
					object obj36 = !flag19;
					bool flag20 = (byte)(int)obj35 != 0;
					if (obj36 == null)
					{
						return;
					}
				}
				else
				{
					Show(live: true);
					bool flag20 = true;
				}
				float unscaledTime = Time.unscaledTime;
				if (unscaledTime < next)
				{
					return;
				}
				Camera main = Camera.main;
				object obj37 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v21+E4]");
				bool flag21 = (nint)0 == 0;
				object obj38 = !flag21;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag22 = main == null;
				bool flag23 = !flag22;
				object obj39 = !flag23;
				if (obj39 != null)
				{
					return;
				}
				object obj40 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v41+E4]");
				bool flag24 = (nint)0 == 0;
				object obj41 = !flag24;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag25 = screen == null;
				bool flag26 = !flag25;
				object obj42 = !flag26;
				if (obj42 != null)
				{
					return;
				}
				Transform transform = screen.transform;
				Vector3 position = transform.position;
				Transform transform2 = main.transform;
				Vector3 position2 = transform2.position;
				float num2 = unscaledTime - unscaledTime;
				float num3 = next - next;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
				object obj43 = 0;
				object obj45 = default;
				object obj44 = obj45 - obj45;
				object obj46 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v52+E4]");
				bool flag27 = (nint)0 == 0;
				object obj47 = !flag27;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj46 = obj43;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v52+A0]");
				object obj48 = 0;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
					if (num2 > range)
					{
						return;
					}
					Transform transform3 = main.transform;
					Vector3 forward = transform3.forward;
					object obj49 = default;
					float num4 = (float)obj49 * num2;
					float num5 = num3 * range;
					float num6 = num4 + num5;
					object obj50 = obj44 * obj44;
					float num7 = (float)obj50 + num6;
					if (num7 < 0f)
					{
						return;
					}
				}
				float unscaledTime2 = Time.unscaledTime;
				double num8 = ((!((double)fps < 1.0)) ? ((double)fps) : 1.0);
				double num9 = 1.0 / num8;
				float num10 = unscaledTime2 + (float)num9;
				next = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v8 (UnityEngine.Object)+68]");
				Render((Transform)0);
				return;
			}
		}
		Show(live: false);
		return;
		IL_032d:
		obj19 = null;
		goto IL_08a0;
	}

	private unsafe static NetworkApe Hunter(GillaModeRound round)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_068c: Expected Obj, but got I4
		//IL_06ce: Expected Obj, but got I4
		//IL_06d6: Expected Obj, but got I
		//IL_06df: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_0493: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got Ref
		//IL_04ce: Expected Obj, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0737: Expected Obj, but got I
		//IL_0763: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_04f5: Expected Obj, but got I4
		//IL_02e3: Invalid comparison between VT and Obj
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected VT, but got Unknown
		//IL_0387: Expected Obj, but got I4
		//IL_061a: Expected Obj, but got I4
		//IL_03ca: Expected Obj, but got I4
		//IL_0679: Expected Obj, but got I4
		//IL_056a: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got Ref
		//IL_059e: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got Ref
		//IL_046c: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = (object)round == null;
		object obj3 = 0;
		IntPtr intPtr = default;
		UnityEngine.Object obj4 = (UnityEngine.Object)(nint)intPtr;
		NetworkApe networkApe = (NetworkApe)109895680;
		NetworkApe networkApe4;
		object obj36;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			PlayerRef monster = round.Monster;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkApe networkApe2 = NetworkApe.Find(monster);
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11;
			if ((UnityEngine.Object)networkApe2 != (UnityEngine.Object)null)
			{
				bool flag4 = (object)networkApe2 == null;
				obj3 = 0;
				obj11 = 0;
				obj4 = null;
				networkApe = networkApe2;
				if (flag4)
				{
					goto IL_05b0;
				}
				if (networkApe2.IsMonster)
				{
					PlayerRef monster2 = round.Monster;
					bool flag5 = round.Hunting(monster2);
					bool flag6 = !flag5;
					object obj12 = !flag6;
					networkApe = networkApe2;
					if (obj12 != null)
					{
						goto IL_06ed;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E98]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E50]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj16 = 0;
			NetworkDictionary<PlayerRef, byte> players = round.Players;
			object obj17 = default;
			obj = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			obj11 = 72;
			object obj19 = default;
			object obj21 = default;
			object obj30 = default;
			object obj32 = default;
			object obj34 = default;
			object obj35 = default;
			NetworkApe result = default;
			object obj41 = default;
			object obj28;
			object obj29;
			OutOfMemoryException ex;
			object obj31;
			object obj33;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
				object obj18 = obj19 & 1;
				object obj37;
				if (obj18 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
					object obj20 = obj21 & 0xFF00000000L;
					if ((long)obj20 != 12884901888L)
					{
						continue;
					}
					PlayerRef monster3 = round.Monster;
					object obj22 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v48+E4]");
					bool flag7 = (nint)0 == 0;
					object obj23 = !flag7;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (monster3 == (PlayerRef)obj21)
					{
						continue;
					}
					object obj24 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v50+E4]");
					bool flag8 = (nint)0 == 0;
					object obj25 = !flag8;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef player = (PlayerRef)(obj21 & 0xFFFFFFFFL);
					NetworkApe networkApe3 = NetworkApe.Find(player);
					object obj26 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v54+E4]");
					bool flag9 = (nint)0 == 0;
					object obj27 = !flag9;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag10 = (UnityEngine.Object)networkApe3 != (UnityEngine.Object)null;
					bool flag11 = !flag10;
					obj11 = 0;
					if (flag11)
					{
						continue;
					}
					if ((object)networkApe3 == null)
					{
						break;
					}
					bool isMonster = networkApe3.IsMonster;
					bool flag12 = !isMonster;
					obj11 = 0;
					if (flag12)
					{
						continue;
					}
					obj28 = 0;
					obj29 = 0;
					ex = (OutOfMemoryException)(&obj30);
					obj31 = obj32;
					obj33 = obj34;
					obj3 = obj35;
					networkApe4 = networkApe3;
					obj11 = 0;
					obj36 = obj19;
					obj37 = 0;
					networkApe = networkApe2;
					goto IL_0727;
				}
				obj28 = 0;
				obj29 = 0;
				ex = (OutOfMemoryException)(&obj30);
				obj31 = obj32;
				obj33 = obj34;
				obj3 = obj35;
				obj36 = obj19;
				obj37 = 0;
				networkApe = networkApe2;
				goto IL_0795;
				IL_0795:
				networkApe4 = null;
				goto IL_0727;
				IL_0727:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E40]");
				object obj38 = 0;
				obj4 = (UnityEngine.Object)obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
				bool flag13 = obj37 == null;
				object obj39 = !flag13;
				if (obj39 == null)
				{
					bool flag14 = obj28 == null;
					object obj40 = !flag14;
					OutOfMemoryException ex2 = ex;
					if (obj40 == null)
					{
						goto IL_050c;
					}
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj28 = 1;
					obj37 = obj29;
				}
				else
				{
					if ((nint)obj4 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E3F0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj37 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj29 = obj41;
				}
				obj36 = 0;
				goto IL_0795;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj28 = 0;
			obj29 = 0;
			ex = (OutOfMemoryException)(&obj30);
			obj31 = obj32;
			obj33 = obj34;
			obj3 = obj35;
			obj11 = 0;
			obj4 = null;
			networkApe = networkApe2;
		}
		goto IL_05b0;
		IL_06ed:
		return networkApe;
		IL_050c:
		object obj42 = obj36 & 1;
		bool flag15 = obj42 == null;
		object obj43 = !flag15;
		object obj44 = ~obj43;
		if (obj44 == null)
		{
			networkApe = networkApe4;
		}
		goto IL_06ed;
		IL_05b0:
		throw new NullReferenceException();
	}

	private unsafe void Render(Transform head)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected Obj, but got Unknown
		//IL_0b9a: Expected Obj, but got I4
		//IL_004a: Expected VT, but got I4
		//IL_0bcd: Expected Obj, but got I4
		//IL_0bd6: Expected Obj, but got I4
		//IL_0bdf: Expected F4, but got I4
		//IL_0be7: Expected I4, but got VT
		//IL_0bef: Expected I4, but got Obj
		//IL_006d: Expected Obj, but got I
		//IL_0713: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I4
		//IL_0725: Expected F4, but got I4
		//IL_072d: Expected I4, but got VT
		//IL_00d3: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_0b19: Expected VT, but got I4
		//IL_0795: Expected Obj, but got I4
		//IL_079e: Expected Obj, but got I4
		//IL_07a7: Expected F4, but got I4
		//IL_07af: Expected I4, but got VT
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I
		//IL_0b5f: Expected VT, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_01eb: Expected I4, but got Obj
		//IL_07dc: Expected Obj, but got I
		//IL_07f2: Expected Obj, but got I
		//IL_0802: Expected Obj, but got I
		//IL_0812: Expected Obj, but got I
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected Obj, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0840: Expected VT, but got I4
		//IL_0878: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_0c15: Expected Obj, but got I
		//IL_0c3c: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I4
		//IL_08e8: Expected Obj, but got I4
		//IL_08f1: Expected Obj, but got I4
		//IL_08fa: Expected F8, but got I4
		//IL_0902: Expected I4, but got VT
		//IL_02e7: Expected Obj, but got I4
		//IL_0958: Expected Obj, but got I4
		//IL_0961: Expected Obj, but got I4
		//IL_096a: Expected F8, but got I4
		//IL_0972: Expected I4, but got VT
		//IL_035e: Expected Obj, but got I4
		//IL_0381: Expected I4, but got Obj
		//IL_0999: Expected Obj, but got I
		//IL_09d0: Expected Obj, but got I4
		//IL_09f7: Expected VT, but got I4
		//IL_0a0e: Expected Obj, but got Ref
		//IL_0a31: Expected Obj, but got I4
		//IL_0a3a: Expected Obj, but got I4
		//IL_0a43: Expected F8, but got I4
		//IL_0a4b: Expected I4, but got VT
		//IL_03da: Expected Obj, but got I4
		//IL_0a73: Expected Obj, but got Ref
		//IL_0a96: Expected Obj, but got I4
		//IL_0a9f: Expected Obj, but got I4
		//IL_0aa8: Expected F8, but got I4
		//IL_045d: Expected Obj, but got I4
		//IL_04cd: Expected F4, but got I4
		//IL_04d6: Expected Obj, but got I4
		//IL_0546: Expected F4, but got I4
		//IL_054f: Expected Obj, but got I4
		//IL_058f: Expected VT, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I4
		//IL_05c6: Expected F4, but got I4
		//IL_05cf: Expected Obj, but got I4
		//IL_0613: Expected I4, but got I8
		//IL_064a: Expected Obj, but got I4
		//IL_0653: Expected Obj, but got I4
		//IL_065c: Expected F4, but got I4
		//IL_0665: Expected Obj, but got I4
		//IL_06bc: Expected Obj, but got I4
		//IL_06d7: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		Quaternion quaternion = (Quaternion)0;
		UnityEngine.Object obj5 = null;
		int num6;
		object obj7;
		object obj9;
		float num3;
		double num;
		int num7;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8568]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			RenderTexture renderTexture = default;
			renderTexture._002Ector(width, height, 16, (RenderTextureFormat)0);
			bool flag4 = (object)renderTexture == null;
			double num2 = default;
			num = num2;
			object obj8 = default;
			obj7 = obj8;
			object obj10 = default;
			obj9 = obj10;
			float num4 = default;
			num3 = num4;
			object obj11 = 0;
			RenderTextureFormat renderTextureFormat = (RenderTextureFormat)0;
			int num5 = 16;
			num6 = height;
			num7 = width;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D10]");
				object obj12 = 0;
				renderTexture.name = (string)obj12;
				renderTexture.antiAliasing = 1;
				object obj13 = this + 96;
				obj13 = renderTexture;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D08]");
				object obj15 = 0;
				GameObject gameObject = default;
				gameObject._002Ector((string)obj15);
				bool flag5 = (object)gameObject == null;
				num = num2;
				obj7 = obj8;
				obj9 = obj10;
				num3 = num4;
				obj11 = 0;
				renderTextureFormat = (RenderTextureFormat)0;
				num5 = 16;
				num6 = 0;
				num7 = (int)obj15;
				if (!flag5)
				{
					gameObject.hideFlags = (HideFlags)52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8558]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					int num8 = default;
					obj3 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag6 = obj3 == null;
					num = num2;
					obj7 = obj8;
					obj9 = obj10;
					num3 = num4;
					obj11 = 0;
					renderTextureFormat = (RenderTextureFormat)0;
					num5 = 16;
					num6 = 0;
					num7 = num8;
					if (!flag6)
					{
						((UnityEngine.Behaviour)obj3).enabled = false;
						bool flag7 = obj3 == null;
						num = num2;
						obj7 = obj8;
						obj9 = obj10;
						num3 = num4;
						obj11 = 0;
						renderTextureFormat = (RenderTextureFormat)0;
						num5 = 16;
						num6 = 0;
						num7 = 0;
						if (!flag7)
						{
							((Camera)obj3).targetTexture = (RenderTexture)obj13;
							bool flag8 = obj3 == null;
							num = num2;
							obj7 = obj8;
							obj9 = obj10;
							num3 = num4;
							obj11 = 0;
							renderTextureFormat = (RenderTextureFormat)0;
							num5 = 16;
							num6 = 0;
							num7 = (int)obj13;
							if (!flag8)
							{
								num3 = fov;
								((Camera)obj3).fieldOfView = fov;
								bool flag9 = (object)cam == null;
								num = num2;
								obj7 = obj8;
								obj9 = obj10;
								obj11 = 0;
								renderTextureFormat = (RenderTextureFormat)0;
								num5 = 16;
								num6 = 0;
								num7 = 0;
								if (!flag9)
								{
									cam.nearClipPlane = 0.25f;
									bool flag10 = obj3 == null;
									num = num2;
									obj7 = obj8;
									obj9 = obj10;
									num3 = 0.25f;
									obj11 = 0;
									renderTextureFormat = (RenderTextureFormat)0;
									num5 = 16;
									num6 = 0;
									num7 = 0;
									if (!flag10)
									{
										((Camera)obj3).farClipPlane = 60f;
										bool flag11 = obj3 == null;
										num = num2;
										obj7 = obj8;
										obj9 = obj10;
										num3 = 1.1146363E+09f;
										obj11 = 0;
										renderTextureFormat = (RenderTextureFormat)0;
										num5 = 16;
										num6 = 0;
										num7 = 0;
										if (!flag11)
										{
											((Camera)obj3).clearFlags = (CameraClearFlags)2;
											bool flag12 = obj3 == null;
											num = num2;
											obj7 = obj8;
											obj9 = obj10;
											num3 = 1.1146363E+09f;
											obj11 = 0;
											renderTextureFormat = (RenderTextureFormat)0;
											num5 = 16;
											num6 = 0;
											num7 = 2;
											if (!flag12)
											{
												((Camera)obj3).backgroundColor = (Color)0;
												bool flag13 = obj3 == null;
												num = 1.0;
												obj7 = 0;
												obj9 = 0;
												num3 = 0f;
												obj11 = 0;
												renderTextureFormat = (RenderTextureFormat)0;
												num5 = 16;
												num6 = 0;
												num7 = 0;
												if (!flag13)
												{
													((Camera)obj3).cullingMask = -1793;
													UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData((Camera)obj3);
													bool flag14 = (object)universalAdditionalCameraData == null;
													num = 1.0;
													obj7 = 0;
													obj9 = 0;
													num3 = 0f;
													obj11 = 0;
													renderTextureFormat = (RenderTextureFormat)0;
													num5 = 16;
													num6 = 0;
													num7 = 0;
													if (!flag14)
													{
														universalAdditionalCameraData.m_RenderPostProcessing = false;
														universalAdditionalCameraData.m_RenderShadows = false;
														obj11 = 0;
														renderTextureFormat = (RenderTextureFormat)0;
														num5 = 16;
														quaternion = (Quaternion)0;
														obj5 = null;
														goto IL_0ba8;
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
			goto IL_0ac1;
		}
		goto IL_0ba8;
		IL_0acf:
		NullReferenceException ex = new NullReferenceException();
		if (num7 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			quaternion = (Quaternion)num6;
		}
		else
		{
			if (num7 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A13AC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			quaternion = (Quaternion)num6;
		}
		goto IL_0ab6;
		IL_0ac1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0acf;
		IL_0ba8:
		bool flag15 = obj3 == null;
		num = 1.0;
		obj7 = 0;
		obj9 = 0;
		num3 = 0f;
		num6 = (int)quaternion;
		num7 = (int)obj5;
		if (!flag15)
		{
			Transform transform = ((Component)obj3).transform;
			bool flag16 = (object)head == null;
			num = 1.0;
			obj7 = 0;
			obj9 = 0;
			num3 = 0f;
			num6 = (int)quaternion;
			num7 = 0;
			if (!flag16)
			{
				Vector3 position = head.position;
				Vector3 forward = head.forward;
				Quaternion rotation = head.rotation;
				bool flag17 = (object)transform == null;
				num = 1.0;
				obj7 = 0;
				obj9 = 0;
				num3 = 0f;
				num6 = (int)quaternion;
				num7 = 0;
				if (!flag17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					object obj17 = (nint)0 * (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					object obj18 = (nint)0 * (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
					object obj20 = 0;
					obj7 = 0 + obj17;
					obj9 = 0 + obj18;
					transform.SetPositionAndRotation((Vector3)0, quaternion);
					num3 = Time.unscaledTime;
					object obj21 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v18+E4]");
					bool flag18 = (nint)0 == 0;
					object obj22 = !flag18;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj21 = obj19;
					}
					object obj23 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v18+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v7+E4]");
					bool flag19 = (nint)0 == 0;
					object obj25 = !flag19;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaSonar.ForScreen(drawing: true);
					bool flag20 = obj3 == null;
					double num9 = 1.0;
					double num10 = 1.0;
					object obj26 = 0;
					object obj27 = 0;
					num = 0.0;
					num6 = (int)quaternion;
					num7 = 0;
					if (!flag20)
					{
						Transform transform2 = ((Component)obj3).transform;
						bool flag21 = (object)transform2 == null;
						num9 = 1.0;
						num10 = 1.0;
						obj26 = 0;
						obj27 = 0;
						num = 0.0;
						num6 = (int)quaternion;
						num7 = 0;
						if (!flag21)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
							object obj28 = 0;
							Vector3 position2 = transform2.position;
							object obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v24+E4]");
							bool flag22 = (nint)0 == 0;
							object obj30 = !flag22;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							NameTag.FaceViewer((Vector3)0);
							bool flag23 = obj3 == null;
							object obj32 = default;
							object obj31 = (object)(&obj32);
							num9 = 1.0;
							num10 = 1.0;
							obj26 = 0;
							obj27 = 0;
							num = 0.0;
							num6 = (int)quaternion;
							num7 = 0;
							if (!flag23)
							{
								((Camera)obj3).Render();
								obj31 = (object)(&obj32);
								num9 = 1.0;
								num10 = 1.0;
								obj26 = 0;
								obj27 = 0;
								num = 0.0;
								num7 = 0;
								goto IL_0ab6;
							}
							goto IL_0acf;
						}
					}
				}
			}
		}
		goto IL_0ac1;
		IL_0ab6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A13AC");
	}

	private void Show(bool live)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_0438: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got I4
		//IL_06ee: Expected Obj, but got I
		//IL_0711: Expected VT, but got I
		//IL_0711: Expected VT, but got I
		//IL_0227: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_049f: Expected Obj, but got I
		//IL_04af: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_06c1: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_05f1: Expected Obj, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0626: Expected Obj, but got I
		//IL_0636: Expected Obj, but got I
		//IL_0646: Expected Obj, but got I
		//IL_052b: Expected Obj, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_0567: Expected VT, but got I8
		//IL_0567: Expected VT, but got I8
		//IL_0353: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I4
		//IL_040c: Expected I4, but got I8
		//IL_0415: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I4
		if (shown == (live ? 1 : 0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		shown = (live ? 1 : 0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = screen != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		object obj12;
		object obj20;
		if (!flag3)
		{
			bool flag4 = !live;
			object obj6 = !flag4;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (obj6 == null)
			{
				object obj9 = obj;
				object obj10 = this + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v52+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = (UnityEngine.Object)obj10 == null;
				bool flag7 = !flag6;
				obj7 = 0;
				obj8 = null;
				if (!flag7)
				{
					Texture2D texture2D = (standby = NoSignal());
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj7 = 0;
					obj8 = texture2D;
				}
			}
			obj12 = this + 136;
			bool flag8 = obj12 == null;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock = default;
				materialPropertyBlock._002Ector();
				obj12 = materialPropertyBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			screen.GetPropertyBlock((MaterialPropertyBlock)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v31+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v31+A0]");
			object obj18 = 0;
			if (live)
			{
				object obj19 = obj;
				obj20 = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v41+E4]");
				bool flag10 = (nint)0 == 0;
				object obj21 = !flag10;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag11 = (UnityEngine.Object)obj20 != null;
				bool flag12 = !flag11;
				object obj22 = !flag12;
				if (obj22 != null)
				{
					goto IL_030e;
				}
			}
			obj20 = this + 104;
			goto IL_030e;
		}
		goto IL_0692;
		IL_030e:
		object obj23 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v24+8]");
		((MaterialPropertyBlock)obj23).SetTexture(0, (Texture)obj20);
		screen.SetPropertyBlock((MaterialPropertyBlock)obj12);
		bool flag13 = !live;
		object obj24 = 0;
		obj4 = 0;
		obj5 = (UnityEngine.Object)obj12;
		if (!flag13)
		{
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v35+E4]");
			bool flag14 = (nint)0 == 0;
			object obj26 = !flag14;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = rt == null;
			bool flag16 = !flag15;
			obj24 = 0;
			obj4 = 0;
			obj5 = null;
			if (!flag16)
			{
				shown = -1;
				obj24 = 0;
				obj4 = 0;
				obj5 = null;
			}
		}
		goto IL_0692;
		IL_0692:
		if (strip == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v9+E4]");
		bool flag17 = (nint)0 == 0;
		object obj29 = !flag17;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v9+A0]");
		object obj30 = 0;
		GillaMapVote.Canvas canvas = strip;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v7+C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v7+10]");
		canvas.Clear((Color32)num, (Color32)0);
		object obj31 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v8+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D00]");
		object s = 0;
		GillaMapVote.Canvas canvas2 = strip;
		ScreenFont font = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v9+18]");
		canvas2.Text(font, 8, 6, (string)s, (Color32[])0, 1, centred: false);
		GillaMapVote.Canvas canvas3;
		object s2;
		ScreenFont font2;
		Color32[] colours;
		int x;
		if (live)
		{
			object obj33 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v18+E4]");
			bool flag18 = (nint)0 == 0;
			object obj34 = !flag18;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			strip.Fill((RectInt)38654705862L, (Color32)25769803782L);
			canvas3 = strip;
			object obj35 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v17+A0]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8548]");
			s2 = 0;
			font2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v18+18]");
			colours = (Color32[])0;
			x = 208;
		}
		else
		{
			object obj37 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v14+E4]");
			bool flag19 = (nint)0 == 0;
			object obj38 = !flag19;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj39 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v12+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CF8]");
			s2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v13+20]");
			colours = (Color32[])0;
			x = 186;
			font2 = text;
			canvas3 = strip;
		}
		canvas3.Text(font2, x, 7, (string)s2, colours, 1, centred: false);
		strip.Show();
	}

	private Texture2D NoSignal()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00f2: Expected VT, but got I
		//IL_00f2: Expected VT, but got I
		//IL_016e: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I
		//IL_0432: Expected Obj, but got I
		//IL_049b: Expected Obj, but got I4
		//IL_051b: Expected Obj, but got I4
		//IL_058d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		bool flag = width < 0;
		int num = width ^ width;
		int num2 = width & num;
		bool flag2 = num2 < 0;
		bool flag3 = flag == flag2;
		object obj3 = !flag3;
		object obj4 = ~obj3;
		int num3 = ((obj4 != null) ? width : (width + 1));
		bool flag4 = height < 0;
		int num4 = height ^ height;
		int num5 = height & num4;
		bool flag5 = num5 < 0;
		bool flag6 = flag4 == flag5;
		object obj5 = !flag6;
		object obj6 = ~obj5;
		int num6 = ((obj6 != null) ? height : (height + 1));
		int num7 = num3 >> 1;
		int num8 = num6 >> 1;
		GillaMapVote.Canvas canvas = default;
		canvas._002Ector(null, num7, num8);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj8 = !flag7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (canvas != null)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8580]");
			object s = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v5+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D18]");
			object s2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+10]");
			canvas.Clear((Color32)num9, (Color32)0);
			int num10 = width;
			int num11 = height;
			object obj11 = obj2;
			int num12 = width + 3;
			bool flag8 = width < 0;
			int num13 = width ^ width;
			int num14 = width & num13;
			bool flag9 = num14 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X10_v1+A0]");
			object obj12 = 0;
			bool flag10 = flag8 == flag9;
			object obj13 = !flag10;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				num10 = num12;
			}
			int num15 = num11 + 3;
			bool flag11 = num11 < 0;
			int num16 = num11 ^ num11;
			int num17 = num11 & num16;
			bool flag12 = num17 < 0;
			bool flag13 = flag11 == flag12;
			object obj15 = !flag13;
			object obj16 = ~obj15;
			if (obj16 == null)
			{
				num11 = num15;
			}
			int x = num10 >> 2;
			int num18 = num11 >> 2;
			int y = num18 - 10;
			ScreenFont font = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X10_v2+20]");
			canvas.Text(font, x, y, (string)s, (Color32[])0, 2, centred: true);
			int num19 = width;
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v9+A0]");
			object obj18 = 0;
			int num20 = width + 3;
			bool flag14 = width < 0;
			int num21 = width ^ width;
			int num22 = width & num21;
			bool flag15 = num22 < 0;
			bool flag16 = flag14 == flag15;
			object obj19 = !flag16;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				num19 = num20;
			}
			int num23 = height + 3;
			bool flag17 = height < 0;
			int num24 = height ^ height;
			int num25 = height & num24;
			bool flag18 = num25 < 0;
			bool flag19 = flag17 == flag18;
			object obj21 = !flag19;
			object obj22 = ~obj21;
			int num26 = ((obj22 != null) ? height : num23);
			int x2 = num19 >> 2;
			int num27 = num26 >> 2;
			int y2 = num27 + 12;
			ScreenFont font2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v10+20]");
			canvas.Text(font2, x2, y2, (string)s2, (Color32[])0, 1, centred: true);
			return canvas.Bake();
		}
		return (Texture2D)(object)new NullReferenceException();
	}

	public GillaMonsterCam()
	{
		//IL_002f: Expected F4, but got I
		//IL_003e: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B7E8]");
		width = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5C8]");
		fps = 0f;
		shown = -1;
		base._002Ector();
	}

	static GillaMonsterCam()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		_ = 4286578688L;
		int num = Shader.PropertyToID((string)obj2);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+A0]");
		object obj7 = 0;
		_ = 4278584838L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+A0]");
		object obj8 = 0;
		object obj9 = obj3;
		_ = 4279045389L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v6+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+A0]");
		object obj14 = (nint)0 + (nint)24;
		obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = obj3;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v9+A0]");
		object obj18 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+10]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
