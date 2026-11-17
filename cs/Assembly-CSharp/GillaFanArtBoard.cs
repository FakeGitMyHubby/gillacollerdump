using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaFanArtBoard : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public int player;

		internal bool _003CRPC_Broke_003Eb__0(NetworkApe a)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I4
			//IL_00b8: Expected I4, but got Obj
			//IL_0080: Expected Obj, but got I4
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
			if ((UnityEngine.Object)a != (UnityEngine.Object)null)
			{
				if ((object)a != null)
				{
					object obj4 = a.owner - player;
					return obj4 == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public Texture2D[] pieces;

	public Renderer[] arts;

	public Renderer label;

	public TextAsset font;

	public const string Join = null;

	private const float Border = default(float);

	private const float Gap = default(float);

	private const float RowGap = default(float);

	private const float InsetX = default(float);

	private const float InsetY = default(float);

	private const float LabelPx = default(float);

	private const int LabelScale = default(int);

	public static readonly Color32 Paper;

	private static readonly int BaseMap;

	private readonly List<Texture2D> made;

	private MaterialPropertyBlock block;

	private ScreenFont words;

	private void OnEnable()
	{
		Refresh();
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0848]");
		object text = 0;
		int num;
		if (font != null)
		{
			string text2 = font.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont = default;
			screenFont._002Ector(text2);
			num = screenFont.Measure((string)text, 3);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num = PixelFont.Measure((string)text, 3);
		}
		return (float)num / 1.1339039E+09f;
	}

	public static GillaFreecam.Print[] Layout(Vector2[] sizes, Vector2 area)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02ff: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I8
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Expected F8, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected Obj, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected Obj, but got Unknown
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected Obj, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected Obj, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected Obj, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_08e9: Expected Obj, but got I4
		//IL_08f3: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I4
		//IL_093f: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0395: Expected I4, but got Obj
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected I, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03d8: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_0966: Expected Obj, but got I4
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected Obj, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I4
		//IL_01f6: Expected F8, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_09e6: Expected Obj, but got I4
		//IL_0a35: Expected Obj, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0658: Expected Obj, but got I4
		//IL_0673: Expected Obj, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		object obj3;
		object obj4;
		object obj7 = default;
		double num;
		if (sizes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0850]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			if (sizes.Length == 0)
			{
				goto IL_076c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag = sizes.Length < 1;
			obj3 = sizes.Length;
			if (flag)
			{
				goto IL_0290;
			}
			obj4 = sizes.Length & 0xFFFFFFFFL;
			object obj5 = sizes + 36;
			object obj6 = obj7 + 32;
			num = 0.0;
			object obj8 = 0;
			while (sizes.Length != (nint)obj8)
			{
				bool flag2 = (nint)obj5 <= 0;
				double num2 = 1.0;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X11_v12-4]");
					num2 = 0.0 / (double)obj5;
				}
				if (obj7 != null)
				{
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v9+18]");
					bool flag3 = (nint)obj9 < 0;
					object obj10 = !flag3;
					if (obj10 != null)
					{
						break;
					}
					num += num2;
					obj8++;
					obj5 += 8;
					if (obj4 != obj8)
					{
						continue;
					}
					goto IL_018f;
				}
				goto IL_077f;
			}
			goto IL_0771;
		}
		goto IL_077f;
		IL_0290:
		object obj11 = obj3 - sizes.Length;
		bool flag4 = (nint)obj11 < 0;
		object obj12 = obj3 ^ sizes.Length;
		object obj13 = obj3 ^ obj11;
		object obj14 = obj12 & obj13;
		bool flag5 = (nint)obj14 < 0;
		bool flag6 = flag4 == flag5;
		object obj15 = !flag6;
		object obj16 = ~obj15;
		object obj17 = ((obj16 != null) ? ((object)1) : ((object)(1 + 1)));
		object obj18 = obj17 - 1;
		GillaFreecam.Print[] array = default;
		object obj19 = array + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF64]");
		object obj21 = default;
		object obj20 = obj21 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		object obj22 = obj18 * 0;
		object obj23 = obj20 - obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC18]");
		object obj25 = default;
		object obj24 = obj25 + 0;
		object obj26 = obj23 / obj17;
		object obj27 = obj7 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAA0]");
		object obj28 = obj26 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		object obj29 = obj26 + 0;
		object obj30 = 0;
		object obj31 = sizes.Length;
		while (true)
		{
			object obj32 = ((obj30 != null) ? obj3 : ((object)0));
			object obj33 = ((obj30 != null) ? ((object)sizes.Length) : obj3);
			object obj34 = obj33 - obj32;
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
			object obj35 = 0;
			if (flag7)
			{
				goto IL_0480;
			}
			if (obj7 == null)
			{
				break;
			}
			bool flag8 = (byte)(int)(~obj32) != 0;
			nint num3 = (nint)(obj33 + flag8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v9+18]");
			obj31 = 0 - obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v9+18]");
			bool flag9 = 0 < (nint)obj32;
			object obj36 = !flag9;
			object obj37 = obj27 + obj32;
			object obj38 = obj33 - obj32;
			object obj39 = ~obj36;
			object obj40 = ~obj39;
			object obj41;
			if (obj40 == null)
			{
				obj41 = 0;
				obj31 = 0;
			}
			else
			{
				obj41 = 0;
			}
			while (true)
			{
				bool flag10 = (nint)obj31 < num3;
				object obj42 = !flag10;
				object obj43 = obj31 - num3;
				bool flag11 = obj43 == null;
				object obj44 = ~obj42;
				object obj45 = obj44 | flag11;
				if (obj45 != null)
				{
					break;
				}
				obj37 += 4;
				object obj46 = obj38 - 1;
				obj35 = obj41 + obj37;
				if ((nint)obj46 != 1)
				{
					continue;
				}
				goto IL_0480;
			}
			goto IL_0771;
			IL_0480:
			object obj47 = obj34 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			object obj48 = obj34 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
			object obj49 = obj47 * 0;
			object obj50 = obj24 - obj49;
			object obj51 = obj50 - obj48;
			object obj52 = obj51 / obj35;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52))
			{
				obj52 = obj28;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32))
			{
				goto IL_073f;
			}
			if (obj7 == null)
			{
				break;
			}
			object obj53 = obj35 * obj52;
			object obj54 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			object obj55 = obj54 + 0;
			object obj56 = obj27 + obj32;
			object obj57 = obj33 - obj32;
			object obj58 = obj19 + obj32;
			object obj59 = obj49 + obj53;
			object obj60 = obj29 * obj30;
			object obj61 = obj26 - obj55;
			object obj62 = obj48 + obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			object obj63 = obj60 + 0;
			double num4 = (double)obj61 * 0.5;
			object obj64 = obj24 - obj62;
			double num5 = (double)obj63 + num4;
			double num6 = (double)obj64 * 0.5;
			double num7 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			double num8 = num7 + 0.0;
			double num9 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
			double num10 = num9 + 0.0;
			while (true)
			{
				object obj65 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v9+18]");
				bool flag12 = (nint)obj65 < 0;
				object obj66 = !flag12;
				if (obj66 != null)
				{
					break;
				}
				if (array == null)
				{
					goto end_IL_09f4;
				}
				object obj46 = array.Length;
				bool flag13 = (nint)obj32 < array.Length;
				object obj67 = !flag13;
				if (obj67 != null)
				{
					break;
				}
				obj56 += 4;
				double num11 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
				double num12 = num11 + 0.0;
				obj57--;
				obj32++;
				object obj68 = obj52 * obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				object obj69 = obj68 + 0;
				obj58 = obj52;
				obj58 += 32;
				if ((nint)obj57 != 1)
				{
					continue;
				}
				goto IL_073f;
			}
			goto IL_0771;
			IL_073f:
			obj30++;
			if (obj30 != obj17)
			{
				continue;
			}
			goto IL_076c;
			continue;
			end_IL_09f4:
			break;
		}
		goto IL_077f;
		IL_076c:
		return array;
		IL_018f:
		bool flag14 = sizes.Length < 4;
		obj3 = sizes.Length;
		if (flag14)
		{
			goto IL_0290;
		}
		object obj70 = sizes.Length - 2;
		object obj71 = obj7 + 32;
		object obj72 = obj4 - 1;
		object obj73 = 0;
		double num13 = 2139095039.0;
		object obj74 = 0;
		object obj75 = sizes.Length;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v9+18]");
			bool flag15 = (nint)obj70 < 0;
			object obj76 = !flag15;
			if (obj76 != null)
			{
				break;
			}
			obj74++;
			object obj77 = obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X13_v15+v527 @ X10_v11*4]");
			obj73 = obj77 + 0;
			double num14 = num - (double)obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			double num15 = ((!(num14 < num13)) ? num13 : num14);
			if (num14 < num13)
			{
				obj75 = obj74;
			}
			bool flag16 = obj72 != obj74;
			obj3 = obj75;
			num13 = num15;
			if (flag16)
			{
				continue;
			}
			goto IL_0290;
		}
		goto IL_0771;
		IL_0771:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_077f;
		IL_077f:
		return (GillaFreecam.Print[])(object)new NullReferenceException();
	}

	public unsafe void Refresh()
	{
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected Obj, but got I
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got I4
		//IL_0cf7: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got Ref
		//IL_0ab3: Expected Obj, but got I4
		//IL_0b2c: Expected Obj, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got I4
		//IL_0b05: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected I4, but got Unknown
		//IL_01e1: Expected I4, but got Obj
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I4
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03c1: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I4
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I4
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected Obj, but got Unknown
		//IL_0c18: Expected Obj, but got I4
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I
		//IL_0368: Expected I4, but got Obj
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got I4
		//IL_0526: Expected Obj, but got I
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected Obj, but got Unknown
		//IL_08b0: Expected Obj, but got I4
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected Obj, but got I
		//IL_0a23: Expected Obj, but got I4
		//IL_0c88: Expected Obj, but got I
		//IL_0c98: Expected Obj, but got I
		//IL_0cb3: Expected VT, but got Obj
		//IL_0cb3: Expected Obj, but got I8
		//IL_0cb3: Expected VT, but got Obj
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got I4
		//IL_062a: Expected Obj, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected Obj, but got I4
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected Obj, but got I4
		//IL_0857: Expected Obj, but got I
		//IL_0857: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I
		bool flag = (object)made == null;
		UnityEngine.Object obj2 = default;
		UnityEngine.Object obj = obj2;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj3 = (UnityEngine.Object)(nint)intPtr;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0820]");
			string text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0830]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0818]");
			MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)made).GetEnumerator();
			UnityEngine.Object obj6 = obj2;
			while (val.MoveNext())
			{
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v79+E4]");
				obj6 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v79+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Gone(obj2);
			}
			obj = null;
			object obj9 = 0;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			object obj10 = 0;
			object obj14 = default;
			while (true)
			{
				obj3 = (UnityEngine.Object)(object)materialPropertyBlock;
				val.Dispose();
				bool flag3 = obj10 == null;
				object obj11 = !flag3;
				Renderer[] array = (Renderer[])(object)obj6;
				if (obj11 == null)
				{
					bool flag4 = (object)obj == null;
					object obj12 = !flag4;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					obj6 = obj;
					if (obj12 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					obj6 = (UnityEngine.Object)(object)array;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				bool flag5 = (nint)obj3 < 2;
				object obj13 = !flag5;
				if ((nint)obj3 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj = (UnityEngine.Object)1;
					obj6 = (UnityEngine.Object)1;
					obj10 = obj9;
					continue;
				}
				bool flag6 = (nint)obj3 < 1;
				obj13 = !flag6;
				if ((nint)obj3 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj10 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj9 = obj14;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0BE4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			List<Texture2D> list = made;
			bool flag7 = (object)made == null;
			Enumerator<, > val3 = default;
			val = val3;
			Enumerator<, > val4 = val3;
			Enumerator<, > val5 = (Enumerator<, >)(ref val);
			if (!flag7)
			{
				int num = list._size;
				val2 = (Enumerator<, >)(list._version + 1);
				bool flag8 = list._size < 1;
				object obj13 = !flag8;
				list._size = 0;
				list._version = (int)val2;
				bool flag9 = list._size < 1;
				int num2 = (int)materialPropertyBlock;
				if (!flag9)
				{
					Array.Clear(list._items, 0, list._size);
					num2 = 0;
				}
				object obj15 = this + 80;
				bool flag10 = obj15 == null;
				object obj16 = !flag10;
				if (obj16 == null)
				{
					object obj17 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v66+E4]");
					bool flag11 = (nint)0 == 0;
					object obj18 = !flag11;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag12 = font != null;
					bool flag13 = !flag12;
					num = 0;
					int num3 = 0;
					if (!flag13)
					{
						bool flag14 = (object)font == null;
						num = 0;
						val = val3;
						val4 = val3;
						val5 = (Enumerator<, >)(ref val);
						obj3 = null;
						materialPropertyBlock = null;
						if (flag14)
						{
							goto IL_08f6;
						}
						string text2 = font.text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						ScreenFont screenFont = default;
						screenFont._002Ector(text2);
						num = 0;
						num3 = (int)screenFont;
						text = text2;
					}
					obj15 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num2 = num3;
					materialPropertyBlock = (MaterialPropertyBlock)num3;
				}
				object obj20 = this + 72;
				bool flag15 = obj20 == null;
				object obj21 = !flag15;
				obj3 = (UnityEngine.Object)num2;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock2 = default;
					materialPropertyBlock2._002Ector();
					obj20 = materialPropertyBlock2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj3 = (UnityEngine.Object)(object)materialPropertyBlock2;
					materialPropertyBlock = materialPropertyBlock2;
				}
				Renderer[] array = arts;
				bool flag16 = arts == null;
				val = val3;
				val4 = val3;
				val5 = (Enumerator<, >)(ref val);
				if (!flag16)
				{
					int num5 = default;
					int num4 = num5;
					int num6 = num;
					UnityEngine.Object obj23 = obj3;
					MaterialPropertyBlock materialPropertyBlock3 = (MaterialPropertyBlock)4;
					Color32[] colours = default;
					object obj35;
					do
					{
						val2 = (Enumerator<, >)array.Length;
						text = (string)(materialPropertyBlock3 - 4);
						bool flag17 = (nint)text < array.Length;
						obj13 = !flag17;
						flag9 = (nint)text >= array.Length;
						num5 = num4;
						num = num6;
						val = val3;
						val4 = val3;
						val5 = (Enumerator<, >)(ref val);
						obj3 = obj23;
						materialPropertyBlock = materialPropertyBlock3;
						if (!flag9)
						{
							bool flag18 = (nint)text < array.Length;
							obj13 = !flag18;
							if (obj13 == null)
							{
								object obj24 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v50+E4]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v50+E4]");
								bool flag19 = (nint)0 == 0;
								object obj25 = !flag19;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v17 (UnityEngine.Renderer[])+v215 @ X21_v15 (UnityEngine.MaterialPropertyBlock)*8]");
								bool flag20 = (UnityEngine.Object)0 != null;
								bool flag21 = !flag20;
								num = 0;
								obj3 = null;
								if (!flag21)
								{
									array = (Renderer[])(object)pieces;
									bool flag22 = pieces == null;
									num5 = num4;
									num = 0;
									val = val3;
									val4 = val3;
									val5 = (Enumerator<, >)(ref val);
									obj3 = null;
									materialPropertyBlock = materialPropertyBlock3;
									if (flag22)
									{
										break;
									}
									val2 = (Enumerator<, >)array.Length;
									bool flag23 = (nint)text < array.Length;
									obj13 = !flag23;
									flag9 = (nint)text >= array.Length;
									num = 0;
									obj3 = null;
									if (!flag9)
									{
										bool flag24 = (nint)text < array.Length;
										obj13 = !flag24;
										num6 = 0;
										obj23 = null;
										if (obj13 == null)
										{
											object obj26 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v55+E4]");
											val2 = (Enumerator<, >)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v55+E4]");
											bool flag25 = (nint)0 == 0;
											object obj27 = !flag25;
											if (obj27 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v17 (UnityEngine.Renderer[])+v215 @ X21_v15 (UnityEngine.MaterialPropertyBlock)*8]");
											bool flag26 = (UnityEngine.Object)0 != null;
											bool flag27 = !flag26;
											num = 0;
											obj3 = null;
											if (flag27)
											{
												goto IL_087c;
											}
											array = arts;
											bool flag28 = arts == null;
											num5 = num4;
											num = 0;
											val = val3;
											val4 = val3;
											val5 = (Enumerator<, >)(ref val);
											obj3 = null;
											materialPropertyBlock = materialPropertyBlock3;
											if (flag28)
											{
												break;
											}
											val2 = (Enumerator<, >)array.Length;
											bool flag29 = (nint)text < array.Length;
											obj13 = !flag29;
											num6 = 0;
											obj23 = null;
											if (obj13 == null)
											{
												val2 = (Enumerator<, >)pieces;
												bool flag30 = pieces == null;
												num5 = num4;
												num = 0;
												val = val3;
												val4 = val3;
												val5 = (Enumerator<, >)(ref val);
												obj3 = null;
												materialPropertyBlock = materialPropertyBlock3;
												if (flag30)
												{
													break;
												}
												num4 = val2._index;
												bool flag31 = (nint)text < val2._index;
												obj13 = !flag31;
												num6 = 0;
												obj23 = null;
												if (obj13 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v17 (UnityEngine.Renderer[])+v215 @ X21_v15 (UnityEngine.MaterialPropertyBlock)*8]");
													nint num7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X9_v14 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+v215 @ X21_v15 (UnityEngine.MaterialPropertyBlock)*8]");
													Show((Renderer)num7, (Texture)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X9_v14 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+v215 @ X21_v15 (UnityEngine.MaterialPropertyBlock)*8]");
													num = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v17 (UnityEngine.Renderer[])+v215 @ X21_v15 (UnityEngine.MaterialPropertyBlock)*8]");
													obj3 = (UnityEngine.Object)0;
													goto IL_087c;
												}
											}
										}
										goto IL_0a49;
									}
								}
								goto IL_087c;
							}
							goto IL_0a49;
						}
						object obj28 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v4+E4]");
						bool flag32 = (nint)0 == 0;
						object obj29 = !flag32;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (label != null)
						{
							bool flag33 = (object)label == null;
							num = 0;
							obj3 = null;
							if (flag33)
							{
								break;
							}
							Transform transform = label.transform;
							bool flag34 = (object)transform == null;
							num = 0;
							obj3 = null;
							if (flag34)
							{
								break;
							}
							Vector3 lossyScale = transform.lossyScale;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
							object obj30 = 0;
							object obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v13+E4]");
							bool flag35 = (nint)0 == 0;
							object obj32 = !flag35;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj31 = obj30;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v13+A0]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0848]");
							object obj34 = 0;
							Texture2D tex = Words((Vector3)obj34, (string)4278190080L, (Color32)obj33, colours);
							Show(label, tex);
						}
						return;
						IL_087c:
						array = arts;
						materialPropertyBlock = (MaterialPropertyBlock)(materialPropertyBlock3 + 1);
						bool flag36 = arts == null;
						obj35 = !flag36;
						num5 = num4;
						val = val3;
						val4 = val3;
						val5 = (Enumerator<, >)(ref val);
						num6 = num;
						obj23 = obj3;
						materialPropertyBlock3 = materialPropertyBlock;
						continue;
						IL_0a49:
						num5 = num4;
						num = num6;
						obj3 = obj23;
						materialPropertyBlock = materialPropertyBlock3;
						throw new IndexOutOfRangeException();
					}
					while (obj35 != null);
				}
			}
		}
		goto IL_08f6;
		IL_08f6:
		throw new NullReferenceException();
	}

	private void Show(Renderer r, Texture tex)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0830]");
		object obj = 0;
		r.GetPropertyBlock(block);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+A0]");
		object obj5 = 0;
		MaterialPropertyBlock materialPropertyBlock = block;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+4]");
		materialPropertyBlock.SetTexture(0, tex);
		r.SetPropertyBlock(block);
	}

	private unsafe Texture2D Words(Vector3 size, string line, Color32 ground, Color32[] colours)
	{
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected Obj, but got Unknown
		//IL_0cc2: Expected Obj, but got I
		//IL_0cec: Expected Obj, but got I4
		//IL_0089: Invalid comparison between Obj and F8
		//IL_004b: Invalid comparison between Obj and F8
		//IL_08ee: Invalid comparison between F8 and I4
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected Obj, but got Unknown
		//IL_090f: Expected Obj, but got F8
		//IL_0954: Expected Obj, but got I4
		//IL_0128: Expected F8, but got I4
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_08b8: Expected Obj, but got I4
		//IL_0984: Invalid comparison between F8 and I4
		//IL_0993: Invalid comparison between F8 and I4
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Expected Obj, but got Unknown
		//IL_09b4: Expected Obj, but got F8
		//IL_09e9: Expected Obj, but got I4
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected Obj, but got Unknown
		//IL_0143: Expected F8, but got I4
		//IL_0d24: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I
		//IL_017a: Invalid comparison between F8 and I4
		//IL_0a75: Invalid comparison between F8 and I4
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected Obj, but got Unknown
		//IL_0a96: Expected Obj, but got F8
		//IL_0acb: Expected Obj, but got I4
		//IL_0295: Expected F8, but got I4
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected Obj, but got Unknown
		//IL_0a49: Expected Obj, but got I4
		//IL_0afb: Invalid comparison between F8 and I4
		//IL_0b0a: Invalid comparison between F8 and I4
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected Obj, but got Unknown
		//IL_0b2b: Expected Obj, but got F8
		//IL_0b60: Expected Obj, but got I4
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		//IL_02b0: Expected F8, but got I4
		//IL_03a5: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I8
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_02ff: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got VT
		//IL_0372: Expected Obj, but got VT
		//IL_037f: Expected VT, but got I4
		//IL_0390: Expected I4, but got VT
		//IL_0bd3: Expected Obj, but got I4
		//IL_0445: Invalid comparison between F8 and I4
		//IL_0458: Expected Obj, but got F8
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_048d: Expected Obj, but got I4
		//IL_0c0a: Invalid comparison between F8 and I4
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected Obj, but got Unknown
		//IL_0c2b: Expected Obj, but got F8
		//IL_0c60: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_0c85: Expected I4, but got F8
		//IL_0c93: Expected I4, but got F8
		//IL_055d: Invalid comparison between VT and I4
		//IL_04d4: Expected Obj, but got Ref
		//IL_0505: Expected Obj, but got VT
		//IL_0505: Expected I4, but got F8
		//IL_0505: Expected I4, but got F8
		//IL_051e: Expected Obj, but got I4
		//IL_0536: Expected I4, but got F8
		//IL_053e: Expected I4, but got F8
		//IL_0546: Expected I4, but got Obj
		//IL_054f: Expected F8, but got I4
		//IL_0671: Expected Obj, but got I
		//IL_0696: Expected I4, but got F8
		//IL_0696: Expected I4, but got F8
		//IL_05a6: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I4
		//IL_061b: Expected VT, but got I
		//IL_061b: Expected Obj, but got VT
		//IL_061b: Expected I4, but got F8
		//IL_061b: Expected I4, but got F8
		//IL_062b: Expected VT, but got I
		//IL_0633: Expected Obj, but got VT
		//IL_0654: Expected I4, but got F8
		//IL_065c: Expected I4, but got F8
		//IL_06c8: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj2 = default;
		object obj = obj2 * 1133903872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num;
		double num2;
		double num3 = default;
		if ((nint)obj < 0)
		{
			if (obj == (object)(-0.5))
			{
				num = -1.0;
				num2 = num3;
				goto IL_0881;
			}
			num2 = (double)obj + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (obj == (object)0.5)
			{
				num = 1.0;
				num2 = num3;
				goto IL_0881;
			}
			num2 = (double)obj + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_08cb;
		IL_0881:
		double num4 = num2 + num;
		object obj6 = num2 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			num2 = num4;
		}
		goto IL_08cb;
		IL_0848:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0856;
		IL_08cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num5 = num2 - 1024.0;
		bool flag3 = num5 < 0.0;
		object obj8 = num2 ^ 0x400;
		object obj9 = num2 ^ num5;
		object obj10 = obj8 & obj9;
		bool flag4 = (nint)obj10 < 0;
		double num6 = num2 * 1133903872.0;
		bool flag5 = flag3 == flag4;
		object obj11 = !flag5;
		object obj12 = ~obj11;
		double num7 = ((obj12 != null) ? 1024.0 : num2);
		double num8 = num7 - 16.0;
		bool flag6 = num8 < 0.0;
		bool flag7 = num8 == 0.0;
		object obj13 = num7 ^ 0x10;
		object obj14 = num7 ^ num8;
		object obj15 = obj13 & obj14;
		bool flag8 = (nint)obj15 < 0;
		bool flag9 = flag6 == flag8;
		object obj16 = !flag7;
		object obj17 = flag9 & obj16;
		object obj18 = ~obj17;
		double num9 = ((obj18 != null) ? 16.0 : num7);
		object obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v8+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num10;
		double num12;
		double num11;
		if (num6 < 0.0)
		{
			if (num6 == -0.5)
			{
				num10 = -1.0;
				num11 = num3;
				goto IL_0a12;
			}
			num11 = num6 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num12 = -0.5;
		}
		else
		{
			if (num6 == 0.5)
			{
				num10 = 1.0;
				num11 = num3;
				goto IL_0a12;
			}
			num11 = num6 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num12 = 0.5;
		}
		goto IL_0a5c;
		IL_0856:
		return (Texture2D)(object)new NullReferenceException();
		IL_0a12:
		num12 = num11 + num10;
		object obj22 = num11 & 1;
		bool flag11 = obj22 == null;
		object obj23 = !flag11;
		if (obj23 != null)
		{
			num11 = num12;
		}
		goto IL_0a5c;
		IL_033f:
		int num13;
		if (words != null)
		{
			num13 = words.Measure((string)size, 3);
			Color32 color = (Color32)0;
			int num14 = 3;
			int num15 = (int)size;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj24 = 0;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v42+E4]");
			bool flag12 = (nint)0 == 0;
			object obj26 = !flag12;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num13 = PixelFont.Measure((string)size, 3);
			Color32 color = ground;
			int num14 = 0;
			int num15 = 3;
		}
		double num16 = num9 - (double)num13;
		double num18;
		double num17 = num18 - 20.0;
		bool flag13 = num16 < 0.0;
		object obj27 = num16 ^ num16;
		object obj28 = num16 & obj27;
		bool flag14 = (nint)obj28 < 0;
		bool flag15 = flag13 == flag14;
		object obj29 = !flag15;
		object obj30 = ~obj29;
		if (obj30 == null)
		{
			num16++;
		}
		double num19 = num18 - 21.0;
		double num20 = num18 - 21.0;
		bool flag16 = num20 < 0.0;
		object obj31 = num18 ^ 0x15;
		object obj32 = num18 ^ num20;
		object obj33 = obj31 & obj32;
		bool flag17 = (nint)obj33 < 0;
		bool flag18 = flag16 == flag17;
		object obj34 = !flag18;
		object obj35 = ~obj34;
		if (obj35 == null)
		{
			num19 = num17;
		}
		int num21 = num16 >> 1;
		int num22 = num19 >> 1;
		Color32[] array = default;
		if (words != null)
		{
			ShiftAuth.Style s = default;
			object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num23 = words.Draw(array, (int)num9, (int)num18, num21, num22, (string)size, ref s);
			Color32 color2 = (Color32)size;
			string text = (string)num22;
			int num24 = num21;
			int num25 = (int)(&s);
			int num26 = (int)num18;
			int num27 = (int)num9;
			int num28 = (int)array;
			num11 = 0.0;
		}
		else
		{
			if (ground == (Color32)(object)0)
			{
				goto IL_0856;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ground @ X3 (UnityEngine.Color32)+18]");
			if ((nint)0 == 0)
			{
				goto IL_0848;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v34+E4]");
			bool flag19 = (nint)0 == 0;
			object obj39 = !flag19;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ground @ X3 (UnityEngine.Color32)+20]");
			PixelFont.Draw(array, (int)num9, (int)num18, num21, num22, (string)size, (Color32)0, 3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ground @ X3 (UnityEngine.Color32)+20]");
			Color32 color2 = (Color32)0;
			string text = (string)size;
			int num24 = num22;
			int num25 = 3;
			int num26 = num21;
			int num27 = (int)num18;
			int num28 = (int)num9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Texture2D texture2D = default;
		texture2D._002Ector((int)num9, (int)num18, (TextureFormat)4, mipChain: true);
		if ((object)texture2D != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0860]");
			object obj41 = 0;
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.hideFlags = (HideFlags)52;
			texture2D.name = (string)obj41;
			texture2D.SetPixels32(array);
			texture2D.Apply(updateMipmaps: true);
			List<System.__Canon> list = (List<System.__Canon>)(object)made;
			if ((object)made != null)
			{
				System.__Canon[] items = list._items;
				int version = list._version + 1;
				list._version = version;
				if (list._items != null)
				{
					bool flag20 = list._size < items.Length;
					object obj42 = !flag20;
					if (obj42 == null)
					{
						object obj43 = list._items + list._size;
						int size2 = list._size + 1;
						list._size = size2;
						object obj44 = obj43 + 32;
						obj44 = texture2D;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						((List<System.__Canon>)(object)made).AddWithResize((System.__Canon)(object)texture2D);
					}
					return texture2D;
				}
			}
		}
		goto IL_0856;
		IL_0a5c:
		double num29 = num11 - 256.0;
		bool flag21 = num29 < 0.0;
		object obj45 = num11 ^ 0x100;
		object obj46 = num11 ^ num29;
		object obj47 = obj45 & obj46;
		bool flag22 = (nint)obj47 < 0;
		bool flag23 = flag21 == flag22;
		object obj48 = !flag23;
		object obj49 = ~obj48;
		double num30 = ((obj49 != null) ? 256.0 : num11);
		double num31 = num30 - 8.0;
		bool flag24 = num31 < 0.0;
		bool flag25 = num31 == 0.0;
		object obj50 = num30 ^ 8;
		object obj51 = num30 ^ num31;
		object obj52 = obj50 & obj51;
		bool flag26 = (nint)obj52 < 0;
		bool flag27 = flag24 == flag26;
		object obj53 = !flag25;
		object obj54 = flag27 & obj53;
		object obj55 = ~obj54;
		num18 = ((obj55 != null) ? 8.0 : num30);
		double num32 = num18 * num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (array != null)
		{
			if (array.Length < 1)
			{
				goto IL_033f;
			}
			object obj56 = array.Length & 0xFFFFFFFFL;
			object obj57 = array + 32;
			object obj58 = 0;
			while (true)
			{
				bool flag28 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56);
				object obj59 = !flag28;
				if (obj59 != null)
				{
					break;
				}
				obj56 = array.Length;
				obj58++;
				if ((nint)obj58 < array.Length)
				{
					continue;
				}
				goto IL_033f;
			}
			goto IL_0848;
		}
		goto IL_0856;
	}

	private static void Gone(UnityEngine.Object o)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
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
		if (o == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		object obj7 = obj;
		if (isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(o);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(o);
		}
	}

	private unsafe void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Ref
		//IL_00d2: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got Ref
		//IL_0225: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE7EA]");
		List<Texture2D> list = (List<Texture2D>)0;
		if ((object)made != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0820]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0830]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0818]");
			object obj3 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)made).GetEnumerator();
			Enumerator<, > val = default;
			list = (List<Texture2D>)(&val);
			while (val.MoveNext())
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v29+E4]");
				list = (List<Texture2D>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Gone(null);
			}
			List<Texture2D> list2 = null;
			object obj6 = 0;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			object obj7 = 0;
			object obj10 = default;
			while (true)
			{
				val.Dispose();
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					bool flag3 = (object)list2 == null;
					object obj9 = !flag3;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					list = list2;
					if (obj9 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj3 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					list2 = (List<Texture2D>)1;
					list = (List<Texture2D>)1;
					obj7 = obj6;
					continue;
				}
				if ((nint)obj3 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj7 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj6 = obj10;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0BE4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			list = made;
			if ((object)made != null)
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
		throw new NullReferenceException();
	}

	public GillaFanArtBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6758]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8408]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0868]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = this + 32;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 40;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj8 = this + 64;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaFanArtBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I8
		//IL_006f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0830]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = 4292930028L;
		int num = Shader.PropertyToID((string)obj2);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+A0]");
		object obj6 = 0;
	}
}
