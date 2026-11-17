using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GillaSplashSpectate : MonoBehaviour
{
	[Serializable]
	public struct Footprint
	{
		public Vector2 at;

		public Vector2 half;

		public float yaw;

		public int which;
	}

	public Renderer[] screens;

	public Renderer[] labels;

	public Transform place;

	public TextAsset titleFont;

	public TextAsset textFont;

	public int width;

	public int height;

	public float fps;

	public float range;

	public float fov;

	public float hold;

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

	private GillaMapVote.Canvas[] strips;

	private ScreenFont title;

	private ScreenFont text;

	private MaterialPropertyBlock block;

	private NetworkApe watching;

	private float next;

	private float heldUntil;

	private string shown;

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0223: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_064c: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_0607: Expected Obj, but got I4
		//IL_040e: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I
		//IL_054e: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got I4
		//IL_04d1: Expected I, but got Obj
		//IL_04e1: Expected Obj, but got I
		//IL_0503: Expected Obj, but got I4
		//IL_0525: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I4
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
		int num = 0;
		ScreenFont screenFont = null;
		int num2;
		if (!flag3)
		{
			bool flag4 = (object)titleFont == null;
			num2 = 0;
			if (flag4)
			{
				goto IL_062d;
			}
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			num = 0;
			screenFont = screenFont2;
		}
		object obj5 = this + 128;
		obj5 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v16+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X21_v6-40]");
		bool flag6 = (UnityEngine.Object)0 != null;
		bool flag7 = !flag6;
		num2 = 0;
		ScreenFont screenFont3 = null;
		if (!flag7)
		{
			bool flag8 = (object)textFont == null;
			num2 = 0;
			if (flag8)
			{
				goto IL_062d;
			}
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			num2 = 0;
			screenFont3 = screenFont4;
		}
		Renderer renderer = (Renderer)(this + 136);
		renderer = (Renderer)(object)screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X21_v13 (UnityEngine.Renderer)-60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X21_v13 (UnityEngine.Renderer)-60]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8418]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj11 = this + 120;
			UnityEngine.Object obj12 = default;
			obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v12-50]");
			Renderer[] array = (Renderer[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v12-50]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
				object obj13 = 0;
				object obj15 = default;
				object obj14 = obj15;
				int num4 = default;
				int num3 = num4;
				object obj16 = 32;
				object obj17 = 4;
				int num5 = num2;
				UnityEngine.Object obj18 = obj12;
				GillaMapVote.Canvas canvas = default;
				IndexOutOfRangeException ex = default;
				object obj28;
				do
				{
					object obj19 = obj17 - 4;
					bool flag9 = (nint)obj19 >= array.Length;
					obj15 = obj14;
					num4 = num3;
					num2 = num5;
					if (!flag9)
					{
						bool flag10 = (nint)obj19 < array.Length;
						object obj20 = !flag10;
						if (obj20 == null)
						{
							object obj21 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v33+E4]");
							bool flag11 = (nint)0 == 0;
							object obj22 = !flag11;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v11 (UnityEngine.Renderer[])+v157 @ X24_v5*8]");
							bool flag12 = (UnityEngine.Object)0 != null;
							bool flag13 = !flag12;
							num2 = 0;
							obj18 = null;
							if (flag13)
							{
								goto IL_05c5;
							}
							Renderer[] array2 = labels;
							bool flag14 = labels == null;
							obj15 = obj14;
							num4 = num3;
							num2 = 0;
							if (flag14)
							{
								break;
							}
							bool flag15 = (nint)obj19 < array2.Length;
							object obj23 = !flag15;
							num5 = 0;
							obj18 = null;
							if (obj23 == null)
							{
								GillaMapVote.Canvas[] array3 = strips;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v16 (UnityEngine.Renderer[])+v157 @ X24_v5*8]");
								canvas._002Ector((Renderer)0, 256, 24);
								bool flag16 = strips == null;
								obj15 = 0;
								num4 = 24;
								num2 = 256;
								if (flag16)
								{
									break;
								}
								bool flag17 = canvas == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v16 (UnityEngine.Renderer[])+v157 @ X24_v5*8]");
								UnityEngine.Object obj24 = (UnityEngine.Object)0;
								if (!flag17)
								{
									nint num6 = (nint)array3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v19 (Il2CppClass<Canvas[]>)+40]");
									obj24 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag18 = ex == null;
									obj14 = 0;
									num3 = 24;
									num5 = 256;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v19 (Il2CppClass<Canvas[]>)+40]");
									obj18 = (UnityEngine.Object)0;
									if (flag18)
									{
										goto IL_0671;
									}
								}
								bool flag19 = (nint)obj19 < array3.Length;
								object obj25 = !flag19;
								obj14 = 0;
								num3 = 24;
								num5 = 256;
								obj18 = obj24;
								if (obj25 == null)
								{
									object obj26 = (object)strips + obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj14 = 0;
									num3 = 24;
									num2 = 256;
									obj18 = (UnityEngine.Object)(object)canvas;
									goto IL_05c5;
								}
							}
						}
						ex = new IndexOutOfRangeException();
						goto IL_0671;
					}
					object obj27 = this + 168;
					obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Show(null);
					return;
					IL_05c5:
					array = labels;
					obj17++;
					obj16 += 8;
					bool flag20 = labels == null;
					obj28 = !flag20;
					obj15 = obj14;
					num4 = num3;
					num5 = num2;
					continue;
					IL_0671:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
					throw new ArgumentNullException();
				}
				while (obj28 != null);
			}
		}
		goto IL_062d;
		IL_062d:
		throw new NullReferenceException();
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
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
		//IL_04eb: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I
		//IL_05bd: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current = GillaSplashGame.Current;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj6;
		}
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v13+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+8]");
		UnityEngine.Object obj15 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = (UnityEngine.Object)current != (UnityEngine.Object)null;
		bool flag7 = !flag6;
		object obj17 = 0;
		NetworkApe networkApe = null;
		if (!flag7)
		{
			bool live = current.Live;
			bool flag8 = !live;
			obj17 = 0;
			if (!flag8)
			{
				byte phase = current.Phase;
				int num = phase & 0xFF;
				bool flag9 = num != 2;
				obj17 = 0;
				if (!flag9)
				{
					object obj18 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v47+E4]");
					bool flag10 = (nint)0 == 0;
					object obj19 = !flag10;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+8]");
					bool flag11 = (UnityEngine.Object)0 != null;
					bool flag12 = !flag11;
					obj17 = 0;
					networkApe = null;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X21_v7 (UnityEngine.Object)+90]");
						bool flag13 = (nint)0 != 2;
						obj17 = 0;
						if (flag13)
						{
							goto IL_02b9;
						}
						NetworkApe networkApe2 = Pick(current);
						obj17 = 0;
						networkApe = networkApe2;
					}
					goto IL_02c3;
				}
			}
			goto IL_02b9;
		}
		goto IL_02c3;
		IL_02c3:
		object obj20 = this + 152;
		obj20 = networkApe;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Show((NetworkApe)obj20);
		object obj21 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v21+E4]");
		bool flag14 = (nint)0 == 0;
		object obj22 = !flag14;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = (UnityEngine.Object)obj20 == null;
		bool flag16 = !flag15;
		object obj23 = !flag16;
		if (obj23 != null)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		if (unscaledTime < next)
		{
			return;
		}
		Camera main = Camera.main;
		object obj24 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v15+E4]");
		bool flag17 = (nint)0 == 0;
		object obj25 = !flag17;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag18 = main == null;
		bool flag19 = !flag18;
		object obj26 = !flag19;
		if (obj26 == null)
		{
			Transform eye = main.transform;
			if (Watched(eye))
			{
				float unscaledTime2 = Time.unscaledTime;
				NetworkApe networkApe3 = watching;
				double num2 = ((!((double)fps < 1.0)) ? ((double)fps) : 1.0);
				double num3 = 1.0 / num2;
				float num4 = unscaledTime2 + (float)num3;
				next = num4;
				Render(networkApe3.head);
			}
		}
		return;
		IL_02b9:
		networkApe = null;
		goto IL_02c3;
	}

	private unsafe NetworkApe Pick(GillaSplashGame game)
	{
		//IL_0010: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I4
		//IL_06ad: Expected Obj, but got I
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected Obj, but got Ref
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got I8
		//IL_0154: Expected Obj, but got I8
		//IL_0391: Expected Obj, but got I4
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got I4
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got I4
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Ref, but got Unknown
		//IL_076c: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_05e4: Expected Obj, but got I4
		//IL_05ed: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got I4
		//IL_0546: Expected I, but got Obj
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got I4
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected I, but got Obj
		//IL_0373: Expected I, but got Obj
		//IL_02e1: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplatter._003C_003Ec__DisplayClass34_0 obj4 = default;
		float unscaledTime = default;
		NetworkApe result;
		if (_003CPick_003Eg__Racing_007C34_0(watching, ref obj4))
		{
			unscaledTime = Time.unscaledTime;
			if (unscaledTime < heldUntil)
			{
				result = watching;
				goto IL_0698;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		UnityEngine.Object obj5 = (UnityEngine.Object)0;
		nint num = (nint)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v11 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		nint num2 = num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (nint)obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v12 (Il2CppClass<UnityEngine.Object>)+A0]");
		NetworkApe networkApe = (NetworkApe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v11 (NetworkApe)+8]");
		bool flag3 = (nint)0 == 0;
		NetworkApe networkApe3 = default;
		NetworkApe networkApe2 = networkApe3;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)unscaledTime;
		UnityEngine.Object obj7 = (UnityEngine.Object)(&obj4);
		if (flag3)
		{
			goto IL_057a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v11 (NetworkApe)+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		NetworkApe networkApe4 = (NetworkApe)4286578687L;
		networkApe = (NetworkApe)4286578687L;
		NetworkApe networkApe5 = null;
		NetworkApe networkApe6 = default;
		Enumerator<, > val3 = default;
		object obj15;
		Enumerator<, > val4;
		while (val.MoveNext())
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v45+E4]");
			networkApe = (NetworkApe)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v45+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!_003CPick_003Eg__Racing_007C34_0(networkApe3, ref obj4))
			{
				continue;
			}
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v49+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (place != null)
			{
				bool flag6 = (object)networkApe3 == null;
				obj7 = null;
				if (!flag6)
				{
					bool flag7 = (object)networkApe3.head == null;
					obj7 = null;
					if (flag7)
					{
						goto IL_051c;
					}
					Vector3 position = networkApe3.head.position;
					if ((object)place != null)
					{
						Vector3 vector = place.InverseTransformPoint((Vector3)0);
						goto IL_034a;
					}
					NullReferenceException ex = new NullReferenceException();
					obj7 = null;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_051c;
			}
			bool flag8 = (object)networkApe3 == null;
			obj7 = null;
			if (flag8)
			{
				goto IL_052a;
			}
			bool flag9 = (object)networkApe3.head == null;
			obj7 = null;
			if (!flag9)
			{
				Vector3 position2 = networkApe3.head.position;
				goto IL_034a;
			}
			goto IL_0538;
			IL_052a:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0538;
			IL_034a:
			bool flag10 = System.Runtime.CompilerServices.Unsafe.As<NetworkApe, UIntPtr>(ref networkApe6) <= System.Runtime.CompilerServices.Unsafe.As<NetworkApe, UIntPtr>(ref networkApe4);
			nint num3 = unchecked((nint)null);
			if (!flag10)
			{
				num3 = unchecked((nint)null);
				networkApe4 = networkApe6;
				networkApe5 = networkApe3;
			}
			continue;
			IL_0538:
			NullReferenceException ex4 = new NullReferenceException();
			num3 = unchecked((nint)null);
			networkApe2 = null;
			val = val3;
			obj15 = 0;
			val4 = (Enumerator<, >)(ref val);
			val2 = val3;
			obj5 = networkApe5;
			goto IL_057a;
			IL_051c:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_052a;
		}
		object obj16 = 7;
		networkApe2 = null;
		val = val3;
		obj15 = 0;
		val4 = (Enumerator<, >)(ref val);
		val2 = val3;
		obj5 = networkApe5;
		object obj17 = 0;
		NetworkApe result2 = default;
		object obj20 = default;
		while (true)
		{
			obj7 = (UnityEngine.Object)obj10;
			((Enumerator<, >*)val4)->Dispose();
			bool flag11 = obj17 == null;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				bool flag12 = (object)networkApe2 == null;
				object obj19 = !flag12;
				OutOfMemoryException ex6 = (OutOfMemoryException)val4;
				if (obj19 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex6 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj7 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				networkApe2 = (NetworkApe)1;
				networkApe = (NetworkApe)1;
				obj17 = obj15;
			}
			else
			{
				if ((nint)obj7 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj17 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj15 = obj20;
			}
			obj16 = 0;
		}
		if ((nint)obj16 != 7)
		{
			bool flag13 = obj16 == null;
			object obj21 = !flag13;
			result = (NetworkApe)obj5;
			if (obj21 != null)
			{
				goto IL_0698;
			}
		}
		object obj22 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v16+E4]");
		bool flag14 = (nint)0 == 0;
		object obj23 = !flag14;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = obj5 != watching;
		bool flag16 = !flag15;
		result = (NetworkApe)obj5;
		if (!flag16)
		{
			float unscaledTime2 = Time.unscaledTime;
			float num4 = unscaledTime2 + hold;
			heldUntil = num4;
			result = (NetworkApe)obj5;
		}
		goto IL_0698;
		IL_0698:
		return result;
		IL_057a:
		throw new NullReferenceException();
	}

	private bool Watched(Transform eye)
	{
		//IL_04ab: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected I4, but got Unknown
		//IL_00b3: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I8
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0525: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I4
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_02f6: Invalid comparison between F4 and I4
		//IL_0307: Expected Obj, but got I4
		//IL_038b: Invalid comparison between F4 and I4
		//IL_039c: Expected Obj, but got I4
		//IL_03a5: Invalid comparison between F4 and I4
		Renderer[] array = screens;
		if (screens == null)
		{
			goto IL_048f;
		}
		bool flag = array.Length < 0;
		bool flag2 = array.Length == 0;
		object obj = array.Length ^ array.Length;
		object obj2 = array.Length & obj;
		bool flag3 = (nint)obj2 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		object obj4 = flag4 & obj3;
		bool flag5 = array.Length < 1;
		object obj5 = obj4;
		if (flag5)
		{
			goto IL_047c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		object obj8 = array.Length & 0xFFFFFFFFL;
		object obj9 = screens + 32;
		Transform transform = eye;
		object obj10 = 0;
		object obj11 = obj4;
		float num = default;
		float num3 = default;
		object obj19 = default;
		while (true)
		{
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			object obj12 = !flag6;
			if (obj12 != null)
			{
				break;
			}
			object obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v5+v123 @ X25_v6*8]");
			bool flag8 = (UnityEngine.Object)0 == null;
			bool flag9 = !flag8;
			object obj15 = !flag9;
			num = num;
			transform = null;
			if (obj15 != null)
			{
				goto IL_03c7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v5+v123 @ X25_v6*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v5+v123 @ X25_v6*8]");
				Transform transform2 = ((Component)0).transform;
				if ((object)transform2 != null)
				{
					Vector3 position = transform2.position;
					if ((object)eye != null)
					{
						Vector3 position2 = eye.position;
						object obj16 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v20+E4]");
						bool flag10 = (nint)0 == 0;
						object obj17 = !flag10;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num2 = num3 - num3;
						float num4 = num - num;
						object obj18 = obj19 - obj19;
						float num5 = num2 * num2;
						float num6 = num4 * num4;
						float num7 = num5 + num6;
						object obj20 = obj18 * obj18;
						num3 = (float)obj20 + num7;
						num = range;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						bool flag11 = num3 < range;
						object obj21 = !flag11;
						float num8 = num3 - range;
						bool flag12 = num8 == 0f;
						object obj22 = !flag12;
						object obj23 = obj21 & obj22;
						transform = null;
						if (obj23 == null)
						{
							Vector3 forward = eye.forward;
							float num9 = num2 * num3;
							float num10 = num4 * range;
							float num11 = num9 + num10;
							num = (float)obj18 * (float)obj19;
							num3 = num + num11;
							bool flag13 = num3 == 0f;
							obj3 = !flag13;
							bool flag14 = num3 > 0f;
							transform = null;
							obj5 = obj11;
							if (flag14)
							{
								goto IL_047c;
							}
						}
						goto IL_03c7;
					}
				}
			}
			goto IL_048f;
			IL_03c7:
			obj8 = array.Length;
			obj10++;
			object obj24 = obj10 - array.Length;
			bool flag15 = (nint)obj24 < 0;
			object obj25 = obj10 ^ array.Length;
			object obj26 = obj10 ^ obj24;
			object obj27 = obj25 & obj26;
			bool flag16 = (nint)obj27 < 0;
			bool flag17 = flag15 == flag16;
			object obj28 = !flag17;
			bool flag18 = (nint)obj10 < array.Length;
			obj5 = obj28;
			obj11 = obj28;
			if (flag18)
			{
				continue;
			}
			goto IL_047c;
		}
		goto IL_049d;
		IL_047c:
		return (byte)(obj5 & 1) != 0;
		IL_049d:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_048f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_049d;
	}

	private unsafe void Render(Transform head)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected Obj, but got Unknown
		//IL_0e68: Expected Obj, but got I4
		//IL_004a: Expected F4, but got I4
		//IL_0701: Expected I4, but got Obj
		//IL_0709: Expected I4, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_00b8: Expected F4, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_0ead: Expected Obj, but got I
		//IL_0ec5: Expected Obj, but got I
		//IL_12db: Expected Obj, but got I
		//IL_1313: Expected Obj, but got I
		//IL_1323: Expected Obj, but got I
		//IL_133a: Invalid comparison between F4 and Obj
		//IL_0105: Expected Obj, but got I
		//IL_0ddf: Expected VT, but got I4
		//IL_0f11: Expected F4, but got I
		//IL_0f21: Invalid comparison between F4 and I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I
		//IL_0e2d: Expected VT, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_0196: Expected F4, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_01c2: Expected I4, but got Obj
		//IL_1378: Expected Obj, but got I
		//IL_13a2: Expected Obj, but got I4
		//IL_0f50: Expected Obj, but got I
		//IL_0f60: Expected F4, but got I
		//IL_0f70: Expected F4, but got I
		//IL_0f8b: Expected F4, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_0ff5: Invalid comparison between F4 and I
		//IL_0205: Expected Obj, but got I4
		//IL_0227: Expected F4, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_0858: Expected Obj, but got I
		//IL_0860: Expected F4, but got Obj
		//IL_0870: Expected F4, but got I
		//IL_0287: Expected F4, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_13e7: Expected Obj, but got I
		//IL_1401: Expected F4, but got I
		//IL_1420: Expected F4, but got I
		//IL_02e7: Expected F4, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_0313: Expected I4, but got Obj
		//IL_14c5: Expected Obj, but got I4
		//IL_08d5: Invalid comparison between F4 and I
		//IL_0354: Expected Obj, but got I4
		//IL_0931: Expected Obj, but got I
		//IL_0939: Expected F4, but got Obj
		//IL_0949: Expected F4, but got I
		//IL_0396: Expected F4, but got I
		//IL_03ad: Expected F4, but got I
		//IL_03c5: Expected Obj, but got I4
		//IL_14eb: Expected Obj, but got I
		//IL_150d: Expected Obj, but got I4
		//IL_0987: Expected Obj, but got I4
		//IL_041d: Expected F4, but got I4
		//IL_0426: Expected Obj, but got I4
		//IL_09c8: Expected VT, but got I8
		//IL_09c8: Expected VT, but got Ref
		//IL_0a10: Expected I4, but got I8
		//IL_047e: Expected F4, but got I4
		//IL_0487: Expected Obj, but got I4
		//IL_04cb: Expected I4, but got I8
		//IL_1545: Expected Obj, but got I4
		//IL_04f5: Expected F4, but got I4
		//IL_04fe: Expected Obj, but got I4
		//IL_1194: Expected Obj, but got I
		//IL_11a4: Expected F4, but got I
		//IL_123e: Expected VT, but got F4
		//IL_1266: Expected F4, but got I
		//IL_0a4f: Invalid comparison between F4 and I
		//IL_0aab: Expected Obj, but got I
		//IL_0ab3: Expected F4, but got Obj
		//IL_0ac3: Expected F4, but got I
		//IL_0570: Expected F4, but got I4
		//IL_0579: Expected Obj, but got I4
		//IL_0b14: Expected VT, but got I4
		//IL_0b14: Expected VT, but got I4
		//IL_10d9: Expected F4, but got I
		//IL_10e9: Invalid comparison between F8 and I
		//IL_0b39: Expected VT, but got F4
		//IL_0b49: Expected F4, but got I
		//IL_0b59: Expected F4, but got I
		//IL_05c5: Expected F4, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_0ad8: Expected F8, but got I
		//IL_0bca: Expected Obj, but got I
		//IL_0bd8: Expected VT, but got I4
		//IL_0c02: Expected Obj, but got I4
		//IL_060c: Expected Obj, but got I8
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_0625: Expected Obj, but got I4
		//IL_0c29: Expected VT, but got I4
		//IL_0c40: Expected VT, but got Ref
		//IL_0c50: Expected F4, but got I
		//IL_0c60: Expected F4, but got I
		//IL_0e8f: Expected Obj, but got I4
		//IL_0d5f: Expected F4, but got I4
		//IL_0d68: Expected Obj, but got I4
		//IL_0cd2: Expected VT, but got Ref
		//IL_0ce2: Expected F4, but got I
		//IL_0cf2: Expected F4, but got I
		//IL_0d34: Expected VT, but got I4
		//IL_064c: Expected Obj, but got I
		//IL_066e: Expected Obj, but got I
		//IL_0678: Expected Obj, but got I4
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_069f: Expected F4, but got I4
		//IL_06a8: Expected Obj, but got I4
		//IL_06c4: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		float num = 0f;
		Texture texture = null;
		Renderer renderer = null;
		if (flag3)
		{
			goto IL_06e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8568]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RenderTexture renderTexture = default;
		renderTexture._002Ector(width, height, 16, (RenderTextureFormat)0);
		bool flag4 = (object)renderTexture == null;
		num = 0f;
		object obj6 = 0;
		RenderTextureFormat renderTextureFormat = (RenderTextureFormat)0;
		int num2 = 16;
		int num3 = height;
		int num4 = width;
		QueryTriggerInteraction queryTriggerInteraction = default;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8578]");
			object obj7 = 0;
			renderTexture.name = (string)obj7;
			renderTexture.antiAliasing = 1;
			object obj8 = this + 104;
			obj8 = renderTexture;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8570]");
			object obj10 = 0;
			GameObject gameObject = default;
			gameObject._002Ector((string)obj10);
			bool flag5 = (object)gameObject == null;
			num = 0f;
			obj6 = 0;
			renderTextureFormat = (RenderTextureFormat)0;
			num2 = 16;
			num3 = 0;
			num4 = (int)obj10;
			if (!flag5)
			{
				gameObject.hideFlags = (HideFlags)52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8558]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				int num5 = default;
				obj3 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag6 = obj3 == null;
				num = 0f;
				obj6 = 0;
				renderTextureFormat = (RenderTextureFormat)0;
				num2 = 16;
				num3 = 0;
				num4 = num5;
				if (!flag6)
				{
					((UnityEngine.Behaviour)obj3).enabled = false;
					bool flag7 = obj3 == null;
					num = 0f;
					obj6 = 0;
					renderTextureFormat = (RenderTextureFormat)0;
					num2 = 16;
					num3 = 0;
					num4 = 0;
					if (!flag7)
					{
						((Camera)obj3).targetTexture = (RenderTexture)obj8;
						bool flag8 = obj3 == null;
						num = 0f;
						obj6 = 0;
						renderTextureFormat = (RenderTextureFormat)0;
						num2 = 16;
						num3 = 0;
						num4 = (int)obj8;
						if (!flag8)
						{
							num = fov;
							((Camera)obj3).fieldOfView = fov;
							bool flag9 = (object)cam == null;
							obj6 = 0;
							renderTextureFormat = (RenderTextureFormat)0;
							num2 = 16;
							num3 = 0;
							num4 = 0;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
								num = 0f;
								Camera camera = cam;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
								camera.nearClipPlane = 0f;
								bool flag10 = obj3 == null;
								obj6 = 0;
								renderTextureFormat = (RenderTextureFormat)0;
								num2 = 16;
								num3 = 0;
								num4 = 0;
								if (!flag10)
								{
									((Camera)obj3).farClipPlane = 120f;
									bool flag11 = obj3 == null;
									num = 1.1230249E+09f;
									obj6 = 0;
									renderTextureFormat = (RenderTextureFormat)0;
									num2 = 16;
									num3 = 0;
									num4 = 0;
									if (!flag11)
									{
										((Camera)obj3).clearFlags = (CameraClearFlags)2;
										bool flag12 = obj3 == null;
										num = 1.1230249E+09f;
										obj6 = 0;
										renderTextureFormat = (RenderTextureFormat)0;
										num2 = 16;
										num3 = 0;
										num4 = 2;
										if (!flag12)
										{
											((Camera)obj3).cullingMask = -1793;
											UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData((Camera)obj3);
											bool flag13 = (object)universalAdditionalCameraData == null;
											num = 1.1230249E+09f;
											obj6 = 0;
											renderTextureFormat = (RenderTextureFormat)0;
											num2 = 16;
											num3 = 0;
											num4 = 0;
											if (!flag13)
											{
												universalAdditionalCameraData.m_RenderPostProcessing = false;
												universalAdditionalCameraData.m_RenderShadows = false;
												Renderer[] array = screens;
												bool flag14 = screens == null;
												num = 1.1230249E+09f;
												obj6 = 0;
												renderTextureFormat = (RenderTextureFormat)0;
												num2 = 16;
												num3 = 0;
												num4 = 0;
												if (!flag14)
												{
													bool flag15 = array.Length < 1;
													num = 1.1230249E+09f;
													obj6 = 0;
													queryTriggerInteraction = (QueryTriggerInteraction)0;
													num2 = 16;
													texture = null;
													renderer = null;
													if (flag15)
													{
														goto IL_06e2;
													}
													object obj12 = array.Length & 0xFFFFFFFFL;
													object obj13 = screens + 32;
													object obj14 = 0;
													num3 = 0;
													num4 = 0;
													while (true)
													{
														bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
														object obj15 = !flag16;
														if (obj15 != null)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X24_v8+v308 @ X23_v11*8]");
														renderer = (Renderer)0;
														texture = rt;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X24_v8+v308 @ X23_v11*8]");
														Set((Renderer)0, rt);
														obj12 = array.Length;
														obj14++;
														bool flag17 = (nint)obj14 < array.Length;
														num = 1.1230249E+09f;
														obj6 = 0;
														queryTriggerInteraction = (QueryTriggerInteraction)0;
														num2 = 16;
														num3 = (int)rt;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X24_v8+v308 @ X23_v11*8]");
														num4 = 0;
														if (flag17)
														{
															continue;
														}
														goto IL_06e2;
													}
													IndexOutOfRangeException ex = new IndexOutOfRangeException();
													num = 1.1230249E+09f;
													obj6 = 0;
													renderTextureFormat = (RenderTextureFormat)0;
													num2 = 16;
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
		goto IL_0d7f;
		IL_0d42:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E818");
		return;
		IL_0d7f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d8d;
		IL_06e2:
		bool flag18 = (object)head == null;
		renderTextureFormat = (RenderTextureFormat)queryTriggerInteraction;
		num3 = (int)texture;
		num4 = (int)renderer;
		if (!flag18)
		{
			Vector3 forward = head.forward;
			float num6 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v12+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj19 = 0;
			float num8 = default;
			float num7 = 0f - num8;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v13+20]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v13+20]");
			object obj21 = num9 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v17+A0]");
			object obj22 = 0;
			float num10 = (float)obj21 + num8;
			bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
			float num12 = default;
			float num11 = num12;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v13+18]");
				float num13 = 0f * num;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num14 = num8 - num13;
				float num15 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v13+20]");
				num8 = num15 * 0f;
				float num16 = num14 - num8;
				float num17 = num16 / num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v13+18]");
				float num19 = default;
				float num18 = 0f * num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v13+20]");
				float num20 = 0f * num17;
				num6 -= num18;
				num7 -= num20;
				num11 = num19;
			}
			float num21 = num6 * num6;
			float num22 = num7 * num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			float num23 = num21 + num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			float num24 = 0f;
			float num25 = num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if (num25 < 0f)
			{
				object obj23 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v76+A0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v77+48]");
				num23 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v77+50]");
				num24 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v77+50]");
				num7 = -0;
			}
			Vector3 position = head.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v34+E4]");
			bool flag20 = (nint)0 == 0;
			object obj27 = !flag20;
			float num26 = num7;
			float num27 = num6;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num26 = num7;
				num27 = num6;
			}
			float num28 = num27 * num27;
			float num29 = num27 * num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num30 = num8 + num28;
			float num31 = num29 + num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num32;
			float num33;
			if (num30 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num32 = num26 / num30;
				num33 = num27 / num31;
			}
			else
			{
				object obj28 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v70+A0]");
				object obj29 = 0;
				num33 = (float)obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v71+8]");
				num32 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num34 = num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
			float num35 = num34 * 0f;
			float num36 = num33 * num8;
			object obj30 = obj16;
			float num37 = num23 + num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v33+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
			float num38 = 0f;
			float num39 = num8 + num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v34+20]");
			float num40 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v34+20]");
			float num41 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
			float num42 = num41 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v34+18]");
			float num43 = 0f * num24;
			Vector3 position2 = head.position;
			Vector3 position3 = head.position;
			float num44 = num37 + num43;
			float num45 = num39 + num42;
			object obj32 = obj25;
			float num46 = num45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
			float num47 = num46 - 0f;
			float num48 = num44 - num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X0_v43+E4]");
			bool flag21 = (nint)0 == 0;
			object obj33 = !flag21;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num49 = num48 * num48;
			float num50 = num47 * num47;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			float num51 = num50 + num49;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num52;
			float num53;
			if (num50 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num52 = num47 / num50;
				num53 = num48 / num51;
			}
			else
			{
				object obj34 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v65+A0]");
				object obj35 = 0;
				num53 = (float)obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X8_v66+8]");
				num52 = 0f;
			}
			object obj36 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v46+E4]");
			bool flag22 = (nint)0 == 0;
			object obj38 = !flag22;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj39 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X0_v48+E4]");
			bool flag23 = (nint)0 == 0;
			object obj40 = !flag23;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num54 = default;
			bool flag24 = Physics.Raycast((Vector3)(&num54), (Vector3)4294961403L, out *(RaycastHit*)1, num24, 0, queryTriggerInteraction);
			bool flag25 = !flag24;
			float num55 = num52;
			float num56 = num12;
			float num57 = num44;
			float num58 = num53;
			num = num24;
			num4 = -5893;
			if (!flag25)
			{
				Vector3 position4 = head.position;
				object obj41 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X0_v76+E4]");
				bool flag26 = (nint)0 == 0;
				object obj42 = !flag26;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num59;
				float num60;
				if (num50 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num59 = num47 / num50;
					num60 = num48 / num24;
				}
				else
				{
					object obj43 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X8_v60+A0]");
					object obj44 = 0;
					num60 = (float)obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v61+8]");
					num59 = 0f;
				}
				object obj45 = default;
				double num61 = (double)obj45 + -0.25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				num58 = 0f;
				double num62 = num61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				if (num62 < 0.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					num61 = 0.0;
				}
				object obj46 = default;
				float num63 = num60 * (float)obj46;
				float num64 = num59 * (float)num61;
				num = num24 + num63;
				num45 = num38 + num64;
				num55 = num40;
				num56 = num24;
				num38 = (float)num61;
				num40 = num64;
				num57 = num;
				num4 = 0;
			}
			bool flag27 = obj3 == null;
			float num65 = num50;
			num8 = num38;
			renderTextureFormat = (RenderTextureFormat)queryTriggerInteraction;
			num2 = 0;
			num3 = 1;
			if (!flag27)
			{
				Transform transform = ((Component)obj3).transform;
				Vector3 position5 = head.position;
				object obj47 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X8_v48+A0]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+18]");
				num55 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+18]");
				num56 = 0f * num56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
				float num66 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				float num67 = num66 * 0f;
				float num68 = num + num56;
				float num69 = num38 + num67;
				float num70 = num68 - num57;
				float num71 = num69 - num45;
				Vector3 upwards = default;
				Vector3 forward2 = default;
				Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
				bool flag28 = (object)transform == null;
				forward2 = (Vector3)num70;
				num65 = num50;
				num8 = num71;
				num40 = num57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
				num58 = 0f;
				num = num70;
				renderTextureFormat = (RenderTextureFormat)queryTriggerInteraction;
				num2 = 0;
				num3 = 0;
				num4 = (int)(&upwards);
				if (!flag28)
				{
					transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
					Color fogColor = RenderSettings.fogColor;
					bool flag29 = obj3 == null;
					forward2 = (Vector3)num70;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
					float num72 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
					num65 = 0f;
					num55 = num71;
					num56 = num57;
					num8 = num45;
					num40 = num11;
					num58 = num70;
					num = num57;
					renderTextureFormat = (RenderTextureFormat)queryTriggerInteraction;
					num2 = 0;
					num3 = 0;
					num4 = 0;
					if (!flag29)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
						object obj49 = 0;
						((Camera)obj3).backgroundColor = (Color)0;
						object obj50 = obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v64+E4]");
						bool flag30 = (nint)0 == 0;
						object obj51 = !flag30;
						if (obj51 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NameTag.FaceViewer((Vector3)0);
						bool flag31 = obj3 == null;
						object obj52 = default;
						forward2 = (Vector3)(&obj52);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
						num72 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
						num65 = 0f;
						num55 = num71;
						num56 = num57;
						num8 = num45;
						num40 = num11;
						num58 = num70;
						num = num57;
						renderTextureFormat = (RenderTextureFormat)queryTriggerInteraction;
						num2 = 0;
						num3 = 0;
						num4 = 0;
						if (!flag31)
						{
							((Camera)obj3).Render();
							forward2 = (Vector3)(&obj52);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
							num72 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v49+20]");
							num65 = 0f;
							num55 = num71;
							num56 = num57;
							num8 = num45;
							num40 = num11;
							num58 = num70;
							num = num57;
							num2 = 0;
							Quaternion quaternion2 = (Quaternion)0;
							num4 = 0;
							goto IL_0d42;
						}
						goto IL_0d8d;
					}
				}
			}
		}
		goto IL_0d7f;
		IL_0d8d:
		NullReferenceException ex3 = new NullReferenceException();
		if (num4 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			queryTriggerInteraction = (QueryTriggerInteraction)renderTextureFormat;
			Quaternion quaternion2 = (Quaternion)num3;
		}
		else
		{
			if (num4 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E818");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			queryTriggerInteraction = (QueryTriggerInteraction)renderTextureFormat;
			Quaternion quaternion2 = (Quaternion)num3;
		}
		goto IL_0d42;
	}

	private void Show(NetworkApe who)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07a9: Expected I, but got Obj
		//IL_07cb: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_07e9: Expected Obj, but got I
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected Obj, but got Unknown
		//IL_083f: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0245: Expected I, but got Obj
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I4
		//IL_01c7: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_06e2: Expected Obj, but got I
		//IL_0866: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I
		//IL_050e: Expected Obj, but got I
		//IL_051e: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I4
		//IL_088d: Expected Obj, but got I4
		//IL_0729: Expected Obj, but got I4
		//IL_0b5f: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_03bd: Expected I4, but got Obj
		//IL_0450: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I4
		//IL_0498: Expected I4, but got Obj
		//IL_077c: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got I4
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected Obj, but got Unknown
		//IL_08db: Expected I4, but got Obj
		//IL_05c9: Expected Obj, but got I4
		//IL_08f9: Expected Obj, but got I
		//IL_0922: Expected VT, but got I
		//IL_0922: Expected VT, but got I
		//IL_0922: Expected Obj, but got I
		//IL_06ad: Expected Obj, but got I4
		//IL_0a99: Expected Obj, but got I
		//IL_0aa9: Expected Obj, but got I
		//IL_0ae4: Expected Obj, but got I
		//IL_0ae4: Expected Obj, but got I
		//IL_0b0e: Expected Obj, but got I
		//IL_0b1e: Expected Obj, but got I
		//IL_0b37: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I4
		//IL_0a53: Expected Obj, but got I
		//IL_0a77: Expected Obj, but got I4
		//IL_0a84: Expected Obj, but got I4
		//IL_0957: Expected Obj, but got I
		//IL_0992: Expected Obj, but got I
		//IL_0992: Expected Obj, but got I
		//IL_09d4: Expected I4, but got Obj
		//IL_0a0c: Expected Obj, but got I4
		//IL_0b7d: Expected Obj, but got I
		//IL_0bb6: Expected Obj, but got I
		//IL_0bb6: Expected Obj, but got I
		//IL_0bdb: Expected VT, but got I8
		//IL_0bdb: Expected VT, but got I8
		//IL_0bdb: Expected Obj, but got I
		//IL_0c05: Expected Obj, but got I
		//IL_0c15: Expected Obj, but got I
		//IL_0c2e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		UnityEngine.Object obj = (UnityEngine.Object)0;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)who == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj3 = !flag3;
		string text = null;
		int num2 = default;
		if (obj3 == null)
		{
			string playerName = who.PlayerName;
			string text3;
			if (string.IsNullOrEmpty(playerName))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v81+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = default;
				int playerId = playerRef.PlayerId;
				string text2 = num2.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8430]");
				object obj7 = 0;
				text3 = (string)obj7 + text2;
			}
			else
			{
				string playerName2 = who.PlayerName;
				text3 = playerName2.ToUpperInvariant();
			}
			text = text3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj8 = 0;
		object obj9 = this + 168;
		string text4 = (string)((text != null) ? text : obj8);
		bool flag5 = text4 == (string)obj9;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 != null)
		{
			return;
		}
		obj9 = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag7 = text == null;
		Texture texture = null;
		UnityEngine.Object obj11 = (UnityEngine.Object)(object)text4;
		Texture texture2;
		Renderer renderer;
		if (!flag7)
		{
			nint num3 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v65 (Il2CppClass<UnityEngine.Object>)+E4]");
			bool flag8 = (nint)0 == 0;
			object obj12 = !flag8;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = rt == null;
			bool flag10 = !flag9;
			texture = null;
			obj11 = null;
			if (flag10)
			{
				Renderer[] array = screens;
				object obj13 = array.Length;
				bool flag11 = array.Length < 1;
				texture2 = null;
				renderer = null;
				if (flag11)
				{
					goto IL_04a6;
				}
				num2 = 0;
				object obj14 = 0;
				while (true)
				{
					bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
					object obj15 = !flag12;
					if (obj15 != null)
					{
						break;
					}
					object obj16 = (object)array + obj14;
					texture2 = rt;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v46+20]");
					renderer = (Renderer)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v46+20]");
					Set((Renderer)0, rt);
					obj13 = array.Length;
					obj14 = num2 + 1;
					bool flag13 = (nint)obj14 < array.Length;
					num2 = (int)obj14;
					if (flag13)
					{
						continue;
					}
					goto IL_04a6;
				}
				goto IL_078c;
			}
		}
		nint num4 = (nint)obj;
		object obj17 = this + 112;
		obj = (UnityEngine.Object)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v53 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag14 = (nint)0 == 0;
		object obj18 = !flag14;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = obj == null;
		bool flag16 = !flag15;
		Texture2D texture2D = null;
		if (!flag16)
		{
			Texture2D texture2D2 = (standby = NoSignal());
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			texture2D = texture2D2;
		}
		Renderer[] array2 = screens;
		object obj19 = array2.Length;
		bool flag17 = array2.Length < 1;
		texture2 = null;
		renderer = (Renderer)(object)texture2D;
		if (flag17)
		{
			goto IL_04a6;
		}
		num2 = 0;
		object obj20 = 0;
		while (true)
		{
			bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
			object obj21 = !flag18;
			if (obj21 != null)
			{
				break;
			}
			object obj22 = (object)array2 + obj20;
			texture2 = standby;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v41+20]");
			renderer = (Renderer)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v41+20]");
			Set((Renderer)0, standby);
			obj19 = array2.Length;
			obj20 = num2 + 1;
			bool flag19 = (nint)obj20 < array2.Length;
			num2 = (int)obj20;
			if (flag19)
			{
				continue;
			}
			goto IL_04a6;
		}
		goto IL_078c;
		IL_04a6:
		GillaMapVote.Canvas[] array3 = strips;
		object obj23 = array3.Length;
		if (array3.Length < 1)
		{
			goto IL_06d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8538]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8540]");
		object s = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8548]");
		object obj26 = 0;
		bool flag21 = default;
		bool flag20 = flag21;
		int num6 = default;
		int num5 = num6;
		Color32[] array5 = default;
		Color32[] array4 = array5;
		string text6 = default;
		string text5 = text6;
		int num8 = default;
		int num7 = num8;
		num2 = 0;
		Texture texture3 = texture2;
		Renderer renderer2 = renderer;
		object obj27 = 0;
		while (true)
		{
			bool flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
			object obj28 = !flag22;
			if (obj28 != null)
			{
				break;
			}
			object obj29 = (object)array3 + obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
			if ((nint)0 != 0)
			{
				object obj30 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v26+E4]");
				bool flag23 = (nint)0 == 0;
				object obj31 = !flag23;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj30 = obj24;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v26+A0]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v20+4]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v20+8]");
				((GillaMapVote.Canvas)num9).Clear((Color32)num10, (Color32)0);
				object obj33 = obj24;
				ScreenFont font3;
				int num16;
				GillaMapVote.Canvas canvas;
				if (text != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v31+E4]");
					bool flag24 = (nint)0 == 0;
					object obj34 = !flag24;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj33 = obj24;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v31+A0]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
					nint num11 = 0;
					ScreenFont font = title;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v29+10]");
					((GillaMapVote.Canvas)num11).Text(font, 8, 6, (string)s, (Color32[])0, 1, centred: false);
					obj = (UnityEngine.Object)(object)this.text;
					bool flag25 = text._stringLength < 19;
					int num12 = 6;
					string text7 = text;
					int num13 = 8;
					int num14 = (int)title;
					if (!flag25)
					{
						string text8 = text.Substring(0, 18);
						num12 = 0;
						text7 = text8;
						num13 = 18;
						num14 = 0;
					}
					object obj36 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v40+E4]");
					bool flag26 = (nint)0 == 0;
					object obj37 = !flag26;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj36 = obj24;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v40+A0]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
					nint num15 = 0;
					UnityEngine.Object font2 = obj;
					string s2 = text7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v32+10]");
					((GillaMapVote.Canvas)num15).Text((ScreenFont)(object)font2, 104, 7, s2, (Color32[])0, 1, centred: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
					((GillaMapVote.Canvas)0).Fill((RectInt)38654705874L, (Color32)25769803782L);
					object obj39 = obj24;
					font3 = this.text;
					text5 = (string)obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v35+A0]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v36+10]");
					array4 = (Color32[])0;
					num16 = 220;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
					canvas = (GillaMapVote.Canvas)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v31+E4]");
					bool flag27 = (nint)0 == 0;
					object obj41 = !flag27;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj33 = obj24;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v31+A0]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8550]");
					object s3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
					nint num17 = 0;
					ScreenFont font4 = title;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v24+18]");
					((GillaMapVote.Canvas)num17).Text(font4, 8, 6, (string)s3, (Color32[])0, 1, centred: false);
					object obj43 = obj24;
					font3 = this.text;
					text5 = (string)obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v27+A0]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v28+18]");
					array4 = (Color32[])0;
					num16 = 186;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
					canvas = (GillaMapVote.Canvas)0;
					obj = (UnityEngine.Object)(object)title;
				}
				canvas.Text(font3, num16, 7, text5, array4, 1, centred: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X9_v8+20]");
				((GillaMapVote.Canvas)0).Show();
				flag20 = false;
				num5 = 1;
				num7 = 7;
				texture3 = (Texture)num16;
				renderer2 = null;
				obj27 = num2;
			}
			obj23 = array3.Length;
			obj27++;
			bool flag28 = (nint)obj27 < array3.Length;
			texture2 = texture3;
			renderer = renderer2;
			num2 = (int)obj27;
			if (flag28)
			{
				continue;
			}
			goto IL_06d2;
		}
		goto IL_078c;
		IL_078c:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_06d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj45 = 0;
		if (text != null)
		{
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v16+E4]");
			bool flag29 = (nint)0 == 0;
			object obj47 = !flag29;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (rt == null)
			{
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}
	}

	private void Set(Renderer screen, Texture tex)
	{
		//IL_0010: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I
		//IL_014f: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got I
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
		if (!(screen == null))
		{
			object obj4 = this + 144;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock = default;
				materialPropertyBlock._002Ector();
				obj4 = materialPropertyBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			screen.GetPropertyBlock((MaterialPropertyBlock)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+A0]");
			object obj11 = 0;
			((MaterialPropertyBlock)obj4).SetTexture((int)obj11, tex);
			screen.SetPropertyBlock((MaterialPropertyBlock)obj4);
		}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8588]");
			object s2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+4]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X10_v2+10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v10+18]");
			canvas.Text(font2, x2, y2, (string)s2, (Color32[])0, 1, centred: true);
			return canvas.Bake();
		}
		return (Texture2D)(object)new NullReferenceException();
	}

	public GillaSplashSpectate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0066: Expected F4, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8408]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8418]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 32;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 40;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B7E8]");
		width = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E730]");
		fps = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 120;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaSplashSpectate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8530]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj3 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj5 = 0;
		_ = 4278584838L;
		object obj6 = obj2;
		obj5 = num;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+A0]");
		object obj8 = 0;
		_ = 4279045389L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
			obj6 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v5+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+A0]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj3;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v8+A0]");
		object obj17 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v9+10]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal static bool _003CPick_003Eg__Racing_007C34_0(NetworkApe a, ref GillaSplatter._003C_003Ec__DisplayClass34_0 P_1)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I4
		//IL_01a7: Expected I4, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_00f1: Invalid comparison between VT and I4
		//IL_0113: Expected Obj, but got VT
		//IL_0127: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)a != (UnityEngine.Object)null)
		{
			if ((object)a == null)
			{
				goto IL_0199;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (a.head != null)
			{
				if (P_1 == (GillaSplatter._003C_003Ec__DisplayClass34_0)(object)0)
				{
					goto IL_0199;
				}
				NetworkDictionary<PlayerRef, byte> players = ((GillaSplashGame)P_1).Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
				object obj8 = default;
				object obj7 = obj8 & 1;
				if (obj7 != null)
				{
					object obj10 = default;
					object obj9 = obj10 - 1;
					return obj9 == null;
				}
			}
		}
		return false;
		IL_0199:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
