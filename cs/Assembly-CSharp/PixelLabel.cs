using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class PixelLabel : MonoBehaviour
{
	public string text;

	public int width;

	public int height;

	public int scale;

	public Color32 colour;

	public Color32 accent;

	public Color32 background;

	public bool repeat;

	private static readonly int BaseMap;

	private Texture2D tex;

	private MaterialPropertyBlock block;

	private void OnEnable()
	{
		Redraw();
	}

	public void Redraw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected Obj, but got Unknown
		//IL_0a2a: Expected Obj, but got I
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected I4, but got Unknown
		//IL_0aa8: Expected Obj, but got I4
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected Obj, but got Unknown
		//IL_0ae2: Expected Obj, but got I
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected I4, but got Unknown
		//IL_0b60: Expected Obj, but got I4
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		//IL_0ba6: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I8
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I4
		//IL_0bcd: Expected Obj, but got I4
		//IL_03ee: Expected Obj, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I4
		//IL_04fd: Expected Obj, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_0529: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I4
		//IL_0866: Expected Obj, but got I
		//IL_0c06: Expected I4, but got Obj
		//IL_0c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c14: Expected Obj, but got Unknown
		//IL_0c2d: Expected Obj, but got I4
		//IL_0d6a: Expected Obj, but got I4
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_0893: Expected Obj, but got I
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected Obj, but got Unknown
		//IL_08d5: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I
		//IL_08f3: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I
		//IL_05fe: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I4
		//IL_0622: Expected I4, but got Obj
		//IL_0976: Expected Obj, but got I4
		//IL_0c6d: Expected Obj, but got I4
		//IL_0646: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I
		//IL_09d9: Expected I4, but got Obj
		//IL_06c2: Expected Obj, but got I4
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_0c95: Expected Obj, but got I4
		//IL_070d: Expected Obj, but got I4
		//IL_0736: Expected Obj, but got I4
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected Obj, but got Unknown
		//IL_0d0a: Expected Obj, but got I4
		//IL_0728: Expected Obj, but got I4
		//IL_0d43: Expected Obj, but got I4
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected Obj, but got Unknown
		//IL_0778: Expected I4, but got Obj
		//IL_07a7: Expected VT, but got I
		//IL_07b1: Expected Obj, but got I4
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected Obj, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected I4, but got Unknown
		//IL_0806: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-20]");
		object obj4 = -8;
		bool flag = (nint)obj4 < 0;
		bool flag2 = obj4 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-20]");
		int num = (int)((nint)0 ^ (nint)8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-20]");
		int num2 = 0 ^ obj4;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		int num4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-20]");
			num4 = 0;
		}
		else
		{
			num4 = 8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-1C]");
		object obj8 = -8;
		bool flag5 = (nint)obj8 < 0;
		bool flag6 = obj8 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-1C]");
		int num5 = (int)((nint)0 ^ (nint)8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-1C]");
		int num6 = 0 ^ obj8;
		int num7 = num5 & num6;
		bool flag7 = num7 < 0;
		bool flag8 = flag5 == flag7;
		object obj9 = !flag6;
		object obj10 = flag8 & obj9;
		object obj11 = ~obj10;
		int num8;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3-1C]");
			num8 = 0;
		}
		else
		{
			num8 = 8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE770]");
		object obj13 = 0;
		bool flag10 = (UnityEngine.Object)obj3 == null;
		bool flag11 = !flag10;
		object obj14 = !flag11;
		UnityEngine.Object obj15 = null;
		if (obj14 == null)
		{
			object obj16 = obj3;
			if (obj3 == null)
			{
				goto IL_09ec;
			}
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v41+190]");
			obj15 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ X8_v41+188] (should have been resolved before IL gen)");
			object obj18 = default;
			if ((nint)obj18 == num4)
			{
				object obj19 = obj3;
				if (obj3 == null)
				{
					goto IL_09ec;
				}
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v42+1B0]");
				obj15 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v444 @ X8_v42+1A8] (should have been resolved before IL gen)");
				object obj21 = default;
				if ((nint)obj21 == num8)
				{
					goto IL_0312;
				}
			}
		}
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v48+E4]");
		bool flag12 = (nint)0 == 0;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj24 = 0;
		if ((UnityEngine.Object)obj3 != null)
		{
			object obj25 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v61+E4]");
			bool flag13 = (nint)0 == 0;
			object obj26 = !flag13;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Kill((UnityEngine.Object)obj3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Texture2D texture2D = default;
		texture2D._002Ector(num4, num8, (TextureFormat)4, mipChain: false);
		string text = default;
		bool flag14 = default;
		if ((object)texture2D != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE778]");
			object obj27 = 0;
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.hideFlags = (HideFlags)52;
			texture2D.name = (string)obj27;
			obj3 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			text = null;
			flag14 = false;
			goto IL_0312;
		}
		goto IL_09ec;
		IL_0421:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj28 = 0;
		string text2 = (string)((this.text != null) ? this.text : obj28);
		Color32[] array2 = default;
		if (text2 != null)
		{
			string[] array = text2.Split('\n', (StringSplitOptions)0);
			if (array != null)
			{
				object obj29 = array.Length;
				bool flag15 = array.Length < 1;
				int num9 = (flag14 ? 1 : 0);
				int num10 = 0;
				if (flag15)
				{
					goto IL_082c;
				}
				object obj30 = scale + scale;
				object obj31 = num8 + scale;
				object obj32 = obj30 * array.Length;
				object obj33 = obj31 - obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
				object obj34 = 0;
				bool flag16 = (nint)obj33 < 0;
				object obj35 = obj33 ^ obj33;
				object obj36 = obj33 & obj35;
				bool flag17 = (nint)obj36 < 0;
				bool flag18 = flag16 == flag17;
				object obj37 = !flag18;
				object obj38 = ~obj37;
				if (obj38 == null)
				{
					obj33++;
				}
				int num11 = obj33 >> 1;
				object obj39 = array + 32;
				int num13 = default;
				int num12 = num13;
				Color32 color2 = default;
				Color32 color = color2;
				object obj40 = 0;
				string text3 = text;
				int num14 = 0;
				while (true)
				{
					bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
					object obj41 = !flag19;
					if (obj41 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X9_v13+v211 @ X29_v6*8]");
					string text4 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X9_v13+v211 @ X29_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE780]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X9_v13+v211 @ X29_v6*8]");
						bool flag20 = ((string)0).StartsWith((string)obj42);
						bool flag21 = !flag20;
						object obj43 = 0;
						int num15 = (int)obj42;
						if (!flag21)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X9_v13+v211 @ X29_v6*8]");
							string text5 = ((string)0).Substring(1);
							text4 = text5;
							obj43 = 0;
							num15 = 1;
						}
						object obj44 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v36+E4]");
						bool flag22 = (nint)0 == 0;
						object obj45 = !flag22;
						if (obj45 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (text4 != null)
						{
							object obj46 = obj34;
							int num16 = text4._stringLength << 1;
							object obj47 = num16 - text4._stringLength;
							object obj48 = obj47 | 1;
							object obj49 = obj48 * scale;
							object obj50 = ((text4._stringLength != 0) ? obj49 : ((object)0));
							bool flag23 = !flag20;
							object obj51 = !flag23;
							object obj52 = ~obj51;
							if (obj52 == null)
							{
								object obj53 = 56;
							}
							else
							{
								object obj53 = 52;
							}
							object obj54 = obj50 + num4;
							bool flag24 = (nint)obj54 < 0;
							object obj55 = obj54 ^ obj54;
							object obj56 = obj54 & obj55;
							bool flag25 = (nint)obj56 < 0;
							bool flag26 = flag24 == flag25;
							object obj57 = !flag26;
							object obj58 = ~obj57;
							object obj59 = ((obj58 != null) ? obj54 : ((object)(obj54 + 1)));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X0_v38+E4]");
							bool flag27 = (nint)0 == 0;
							object obj60 = !flag27;
							if (obj60 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num10 = obj59 >> 1;
							int w = num4;
							int h = num8;
							int x = num10;
							string text6 = text4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PixelLabel)+v741 @ X9_v20]");
							PixelFont.Draw(array2, w, h, x, num11, text6, (Color32)0, scale);
							obj29 = array.Length;
							obj40++;
							int num17 = num11 + obj30;
							bool flag28 = (nint)obj40 < array.Length;
							text = text4;
							num9 = num11;
							num12 = scale;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PixelLabel)+v741 @ X9_v20]");
							color = (Color32)0;
							text3 = text4;
							flag14 = (byte)num17 != 0;
							num14 = num10;
							if (flag28)
							{
								continue;
							}
							goto IL_082c;
						}
					}
					goto IL_09ec;
				}
				goto IL_09fa;
			}
		}
		goto IL_09ec;
		IL_09fa:
		throw new IndexOutOfRangeException();
		IL_0312:
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj61 = 0;
			TextureWrapMode wrapMode = (TextureWrapMode)((repeat ? 1 : 0) ^ 1);
			((Texture)obj3).wrapMode = wrapMode;
			object obj62 = num8 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			if (array2 != null)
			{
				if (array2.Length < 1)
				{
					goto IL_0421;
				}
				object obj63 = array2.Length & 0xFFFFFFFFL;
				object obj64 = array2 + 32;
				object obj65 = 0;
				while (true)
				{
					bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj63);
					object obj66 = !flag29;
					if (obj66 != null)
					{
						break;
					}
					obj63 = array2.Length;
					_ = background;
					obj65++;
					if ((nint)obj65 < array2.Length)
					{
						continue;
					}
					goto IL_0421;
				}
				goto IL_09fa;
			}
		}
		goto IL_09ec;
		IL_09ec:
		NullReferenceException ex = new NullReferenceException();
		goto IL_09fa;
		IL_082c:
		if (obj3 != null)
		{
			((Texture2D)obj3).SetPixels32(array2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE770]");
			object obj67 = 0;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
				object obj68 = 0;
				((Texture2D)obj3).Apply(false);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				object obj69 = this + 80;
				bool flag30 = obj69 == null;
				object obj70 = !flag30;
				if (obj70 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj71 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					obj69 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				Renderer renderer = default;
				if ((object)renderer != null)
				{
					renderer.GetPropertyBlock((MaterialPropertyBlock)obj69);
					object obj72 = obj67;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v23+E4]");
					bool flag31 = (nint)0 == 0;
					object obj73 = !flag31;
					if (obj73 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj69 != null)
					{
						object obj74 = obj67;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v19+A0]");
						object obj75 = 0;
						((MaterialPropertyBlock)obj69).SetTexture((int)obj75, (Texture)obj3);
						renderer.SetPropertyBlock((MaterialPropertyBlock)obj69);
						return;
					}
				}
			}
		}
		goto IL_09ec;
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
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
		if (tex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE770]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Kill(tex);
		}
	}

	private static void Kill(UnityEngine.Object o)
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

	public PixelLabel()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0056: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE788]");
		object obj = 0;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F4C0]");
		width = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C510]");
		accent = (Color32)0;
		base._002Ector();
	}

	static PixelLabel()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE770]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
