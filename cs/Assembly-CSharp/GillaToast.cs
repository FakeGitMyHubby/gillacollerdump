using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaToast : MonoBehaviour
{
	public Material material;

	public TextAsset titleFont;

	public TextAsset textFont;

	private const float Life = default(float);

	private const float PopIn = default(float);

	private const float ShrinkOut = default(float);

	private const float Lag = default(float);

	private const float OverHand = default(float);

	private const float MetresAPixel = default(float);

	private const int Pad = default(int);

	private const int BarWide = default(int);

	private const int TitleScale = default(int);

	private const int Gap = default(int);

	private static readonly int BaseMap;

	private static readonly Color32 Panel;

	private static readonly Color32 Good;

	private static readonly Color32 Bad;

	private static readonly Color32 Line;

	private static GillaToast here;

	private ScreenFont title;

	private ScreenFont text;

	private Transform quad;

	private MeshRenderer shown;

	private MaterialPropertyBlock block;

	private Texture2D tex;

	private Color32[] px;

	private int hand;

	private float age = 3f;

	private float wide;

	private float high;

	private Vector3 at;

	private Vector3 moving;

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
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
		object obj4 = (nint)0 + (nint)24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v1+18]");
		bool flag3 = (UnityEngine.Object)0 == this;
		bool flag4 = !flag3;
		UnityEngine.Object obj8 = this;
		if (!flag4)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v18+A0]");
			object obj11 = (nint)0 + (nint)24;
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj8 = null;
		}
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (shown != null)
		{
			shown.enabled = false;
		}
		age = 3f;
	}

	public static void Bought(int hand, string what, int coins)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF990]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7A0]");
		object obj5 = 0;
		int num = default;
		string text = num.ToString((string)obj);
		string line = what + (string)obj2 + text + (string)obj3;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Show(hand, (string)obj5, line, error: false);
	}

	public static void NotEnough(int hand, int coins)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF998]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF310]");
		object obj8 = 0;
		int balance = Coins.Balance;
		object obj9 = coins - balance;
		object obj10 = obj9 - 1;
		bool flag2 = (nint)obj10 < 0;
		bool flag3 = obj10 == null;
		object obj11 = obj9 ^ 1;
		object obj12 = obj9 ^ obj10;
		object obj13 = obj11 & obj12;
		bool flag4 = (nint)obj13 < 0;
		bool flag5 = flag2 == flag4;
		object obj14 = !flag3;
		object obj15 = flag5 & obj14;
		object obj16 = ~obj15;
		if (obj16 == null)
		{
		}
		int num = default;
		string text = num.ToString((string)obj2);
		string line = (string)obj4 + text + (string)obj5;
		object obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Show(hand, (string)obj8, line, error: true);
	}

	public static void Show(int hand, string title, string line, bool error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v1+18]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+18]");
			((GillaToast)0).Begin(hand, title, line, error);
		}
	}

	public static int NearerHand(Vector3 to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I4
		//IL_03ca: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform = Hand(0);
		Transform transform2 = Hand(1);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = transform == null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (obj7 == null)
		{
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v27+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = transform2 == null;
			bool flag7 = !flag6;
			obj8 = 0;
			obj9 = null;
			if (flag7)
			{
				if ((object)transform2 != null)
				{
					Vector3 position = transform2.position;
					if ((object)transform != null)
					{
						object obj13 = default;
						object obj12 = obj13 - obj13;
						object obj15 = default;
						object obj14 = obj15 - obj15;
						object obj17 = default;
						object obj16 = obj17 - obj17;
						object obj18 = obj12 * obj12;
						object obj19 = obj14 * obj14;
						object obj20 = obj18 + obj19;
						object obj21 = obj16 * obj16;
						object obj22 = obj21 + obj20;
						Vector3 position2 = transform.position;
						object obj23 = obj20 - obj13;
						object obj24 = obj21 - obj15;
						object obj25 = obj16 - obj17;
						object obj26 = obj23 * obj23;
						object obj27 = obj24 * obj24;
						object obj28 = obj26 + obj27;
						object obj29 = obj25 * obj25;
						object obj30 = obj29 + obj28;
						object obj31 = obj22 - obj30;
						return ((nint)obj31 < 0) ? 1 : 0;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
		}
		object obj32 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj33 = !flag8;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (transform != null)
		{
			return 0;
		}
		object obj34 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj35 = !flag9;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = transform2 != null;
		bool flag11 = !flag10;
		object obj36 = !flag11;
		if (obj36 == null)
		{
			return 1 + 1;
		}
		return 1;
	}

	private static Transform Hand(int h)
	{
		//IL_0010: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I4
		//IL_03f7: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		object obj13;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v1+8]");
			if ((nint)0 == 0)
			{
				goto IL_0307;
			}
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v1+8]");
			obj13 = (nint)0 + (nint)56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v35+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = (UnityEngine.Object)obj13 != null;
			bool flag8 = !flag7;
			obj10 = 0;
			obj11 = null;
			if (!flag8)
			{
				if (h != 0)
				{
					if (h != 1)
					{
						goto IL_02cd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v1+8]");
					obj13 = (nint)0 + (nint)64;
				}
				goto IL_0395;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v18+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v22+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj15;
		}
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v22+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v17+E4]");
		bool flag11 = (nint)0 == 0;
		object obj22 = !flag11;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = (UnityEngine.Object)obj21 == null;
		bool flag13 = !flag12;
		object obj23 = !flag13;
		Transform result = null;
		if (obj23 == null)
		{
			if (h != 0)
			{
				if (h != 1)
				{
					goto IL_02cd;
				}
				if (obj21 == null)
				{
					goto IL_0307;
				}
				obj13 = obj21 + 56;
			}
			else
			{
				if (obj21 == null)
				{
					goto IL_0307;
				}
				obj13 = obj21 + 48;
			}
			goto IL_0395;
		}
		goto IL_03da;
		IL_0307:
		return (Transform)(object)new NullReferenceException();
		IL_0395:
		result = (Transform)obj13;
		goto IL_03da;
		IL_02cd:
		result = null;
		goto IL_03da;
		IL_03da:
		return result;
	}

	private void Begin(int onHand, string titleLine, string line, bool error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I
		//IL_0167: Expected I4, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I
		//IL_0239: Expected VT, but got Obj
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
		if (!(material == null))
		{
			Draw(titleLine, line, error);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
			object obj6 = 0;
			if (quad == null)
			{
				MakeQuad();
			}
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7+A0]");
			object obj10 = 0;
			block.SetTexture((int)obj10, tex);
			shown.SetPropertyBlock(block);
			shown.enabled = true;
			hand = onHand;
			age = 0f;
			Vector3 vector = Target();
			Vector3 vector2 = default;
			at = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v12+A0]");
			object obj13 = 0;
			moving = (Vector3)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+8]");
			_ = 0;
			Place(0f);
		}
	}

	private unsafe void Draw(string titleLine, string line, bool error)
	{
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected Obj, but got Unknown
		//IL_0bdb: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected I4, but got Unknown
		//IL_0207: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected I4, but got Unknown
		//IL_02e9: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I
		//IL_05b7: Expected Obj, but got I4
		//IL_05c7: Expected Obj, but got I
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_060e: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I
		//IL_0426: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_062b: Expected Obj, but got I
		//IL_0c47: Expected Obj, but got I
		//IL_0c24: Expected Obj, but got I
		//IL_0837: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I4
		//IL_06f0: Expected Obj, but got I4
		//IL_087b: Expected Obj, but got Ref
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected Obj, but got Unknown
		//IL_070e: Expected Obj, but got I4
		//IL_0c9c: Expected I4, but got Obj
		//IL_0cb6: Expected Obj, but got I4
		//IL_0916: Expected Obj, but got I4
		//IL_073d: Expected Obj, but got I4
		//IL_09ff: Expected Obj, but got I
		//IL_0a33: Expected Obj, but got I4
		//IL_0790: Expected Obj, but got I4
		//IL_0c7d: Expected Obj, but got I
		//IL_0c8d: Expected Obj, but got I
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected Obj, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_0a68: Expected Obj, but got I
		//IL_0959: Expected Obj, but got I
		//IL_0a92: Expected Obj, but got I
		//IL_0d70: Expected Obj, but got Ref
		//IL_09a0: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I4
		//IL_0d02: Expected Obj, but got I
		//IL_0d12: Expected Obj, but got I
		object obj = this + 56;
		bool flag = obj == null;
		object obj2 = !flag;
		string text = line;
		if (obj2 == null)
		{
			if ((object)titleFont == null)
			{
				goto IL_0ba1;
			}
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont = default;
			screenFont._002Ector(baked);
			obj = screenFont;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			text = null;
		}
		object obj4 = this + 64;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			if ((object)textFont == null)
			{
				goto IL_0ba1;
			}
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked2);
			obj4 = screenFont2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		int num7;
		object obj14;
		int num9;
		if (obj != null)
		{
			int num = ((ScreenFont)obj).Measure(titleLine, 2);
			if (obj4 != null)
			{
				int num2 = ((ScreenFont)obj4).Measure(line, 1);
				object obj7 = obj;
				object obj8 = num - num2;
				bool flag3 = (nint)obj8 < 0;
				bool flag4 = obj8 == null;
				int num3 = num ^ num2;
				int num4 = num ^ obj8;
				int num5 = num3 & num4;
				bool flag5 = num5 < 0;
				bool flag6 = flag3 == flag5;
				object obj9 = !flag4;
				object obj10 = flag6 & obj9;
				object obj11 = ~obj10;
				int num6 = ((obj11 != null) ? num2 : num);
				if (obj != null)
				{
					object obj12 = obj4;
					if (obj4 != null)
					{
						num7 = num6 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj13 = 0;
						obj14 = this + 96;
						object obj15 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X10_v3+10]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v3+10]");
						object obj16 = num8 + 0;
						num9 = obj16 + 15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v12+E4]");
						bool flag7 = (nint)0 == 0;
						object obj17 = !flag7;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = (UnityEngine.Object)obj14 == null;
						bool flag9 = !flag8;
						object obj18 = !flag9;
						UnityEngine.Object obj19 = null;
						object obj28;
						if (obj18 == null)
						{
							object obj20 = obj14;
							if (obj14 == null)
							{
								goto IL_0ba1;
							}
							object obj21 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v56+188]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v56+190]");
							obj19 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v328 @ X8_v56+188] (should have been resolved before IL gen)");
							object obj22 = default;
							if ((nint)obj22 == num7)
							{
								object obj23 = obj14;
								if (obj14 == null)
								{
									goto IL_0ba1;
								}
								object obj24 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v57+1B0]");
								obj19 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v544 @ X8_v57+1A8] (should have been resolved before IL gen)");
								object obj25 = default;
								bool flag10 = (nint)obj25 == num9;
								IntPtr intPtr = default;
								bool flag11 = (byte)(nint)intPtr != 0;
								TextureFormat textureFormat = (TextureFormat)0;
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v57+1B0]");
								UnityEngine.Object obj27 = (UnityEngine.Object)0;
								obj28 = 109895680;
								if (flag10)
								{
									goto IL_061b;
								}
							}
						}
						object obj29 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v60+E4]");
						bool flag12 = (nint)0 == 0;
						object obj30 = !flag12;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
						obj28 = 0;
						bool flag13 = (UnityEngine.Object)obj14 != null;
						bool flag14 = !flag13;
						UnityEngine.Object obj31 = null;
						if (!flag14)
						{
							object obj32 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v76+E4]");
							bool flag15 = (nint)0 == 0;
							object obj33 = !flag15;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Object.Destroy((UnityEngine.Object)obj14);
							obj31 = null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Texture2D texture2D = default;
						texture2D._002Ector(num7, num9, (TextureFormat)4, mipChain: false);
						if ((object)texture2D != null)
						{
							texture2D.filterMode = (FilterMode)0;
							texture2D.wrapMode = (TextureWrapMode)1;
							tex = texture2D;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj34 = num9 * num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							object obj36 = this + 104;
							UnityEngine.Object obj37 = default;
							obj36 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag11 = false;
							TextureFormat textureFormat = (TextureFormat)4;
							object obj26 = 0;
							UnityEngine.Object obj27 = obj37;
							goto IL_061b;
						}
					}
				}
			}
		}
		goto IL_0ba1;
		IL_0baf:
		throw new IndexOutOfRangeException();
		IL_0ba1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0baf;
		IL_061b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj38 = 0;
		object obj39 = obj38;
		object obj40;
		string text2;
		if (error)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v46+E4]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj39 = obj38;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v46+A0]");
			obj40 = (nint)0 + (nint)12;
			text2 = titleLine;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v46+E4]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj39 = obj38;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v46+A0]");
			obj40 = (nint)0 + (nint)8;
			text2 = titleLine;
		}
		if (num9 < 1)
		{
			goto IL_0827;
		}
		object obj41 = 0;
		object obj42 = 0;
		bool flag16 = error;
		while (true)
		{
			if (num7 >= 1)
			{
				object obj43 = obj39;
				object obj44 = 0;
				while (true)
				{
					flag16 = (byte)(int)px != 0;
					bool flag17 = (nint)obj44 < 4;
					object obj45 = !flag17;
					object obj46 = ~obj45;
					obj40 = obj40;
					if (obj46 == null)
					{
						obj43 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v48+E4]");
						bool flag18 = (nint)0 == 0;
						object obj47 = !flag18;
						if (obj47 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj43 = obj38;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v48+A0]");
						object obj48 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v44+4]");
						obj40 = 0;
					}
					if (!flag16)
					{
						break;
					}
					object obj49 = obj42 + obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X22_v8 (System.Boolean)+18]");
					bool flag19 = (nint)obj49 < 0;
					object obj50 = !flag19;
					if (obj50 == null)
					{
						object obj51 = flag16 + obj49;
						object obj28 = obj44 + 1;
						bool flag20 = num7 != (nint)obj28;
						obj39 = obj43;
						obj44 = obj28;
						if (flag20)
						{
							continue;
						}
						goto IL_07ed;
					}
					goto IL_0baf;
				}
				break;
			}
			goto IL_07ed;
			IL_07ed:
			obj41++;
			obj42 += num7;
			if ((nint)obj41 != num9)
			{
				continue;
			}
			goto IL_0827;
		}
		goto IL_0ba1;
		IL_0827:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj53 = default;
		ShiftAuth.Style s = default;
		ScreenFont screenFont3;
		string text3;
		if (obj53 != null)
		{
			object obj54 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (title != null)
			{
				int num10 = title.Draw(px, num7, num9, 10, 6, text2, ref s);
				screenFont3 = title;
				if (title != null)
				{
					bool flag21 = !error;
					object obj55 = !flag21;
					int num11 = num7;
					if (obj55 == null)
					{
						if (line == null)
						{
							goto IL_0ba1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6E8]");
						object value = 0;
						bool flag22 = line.Contains((string)value);
						bool flag23 = !flag22;
						num11 = 0;
						if (!flag23)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
							object obj56 = 0;
							object obj57 = obj56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v42+E4]");
							bool flag24 = (nint)0 == 0;
							object obj58 = !flag24;
							if (obj58 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj57 = obj56;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v42+A0]");
							object obj59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X8_v37+30]");
							object obj60 = 0;
							num11 = 0;
							text3 = line;
							goto IL_0d62;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
					object obj61 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj62 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v27+E4]");
					bool flag25 = (nint)0 == 0;
					object obj63 = !flag25;
					if (obj63 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj62 = obj38;
					}
					object obj64 = default;
					if (obj64 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v27+A0]");
						object obj65 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v28+10]");
						_ = 0;
						object obj66 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v30+A0]");
						object obj67 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v31+10]");
						_ = 0;
						text3 = line;
						object obj60 = obj64;
						goto IL_0d62;
					}
				}
			}
		}
		goto IL_0ba1;
		IL_0d62:
		object obj68 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (this.text != null)
		{
			int num12 = screenFont3.size << 1;
			int y = num12 + 9;
			int num13 = this.text.Draw(px, num7, num9, 10, y, text3, ref s);
			if (obj14 != null)
			{
				((Texture2D)obj14).SetPixels32(px);
				if ((object)tex != null)
				{
					tex.Apply(updateMipmaps: false);
					float num14 = num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB94]");
					float num15 = num14 * 0f;
					float num16 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB94]");
					float num17 = num16 * 0f;
					wide = num15;
					high = num17;
					return;
				}
			}
		}
		goto IL_0ba1;
	}

	private unsafe void MakeQuad()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_028b: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I
		//IL_034e: Expected I4, but got Obj
		//IL_053a: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I
		//IL_0562: Expected Obj, but got I
		//IL_0584: Expected Obj, but got I
		//IL_05a1: Expected Obj, but got I
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05d0: Expected VT, but got Ref
		//IL_038f: Expected Obj, but got I
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got I
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		GameObject gameObject2 = base.gameObject;
		if ((object)gameObject2 != null)
		{
			int layer = gameObject2.layer;
			if ((object)gameObject != null)
			{
				gameObject.layer = layer;
				Transform transform = gameObject.transform;
				object obj3 = this + 72;
				obj3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Transform parent = base.transform;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
					object obj4 = 0;
					((Transform)obj3).SetParent(parent, false);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Mesh mesh = default;
					mesh._002Ector();
					if ((object)mesh != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
						object obj5 = 0;
						mesh.name = (string)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Vector3[] array = default;
						if (array != null)
						{
							_ = 0;
							_ = 191;
							bool flag = array.Length < 2;
							object obj6 = !flag;
							object obj7 = array.Length - 2;
							bool flag2 = obj7 == null;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B750]");
							_ = 0;
							object obj8 = ~obj6;
							object obj9 = obj8 | flag2;
							if (obj9 != null)
							{
								goto IL_04fd;
							}
							_ = 0;
							_ = 63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
							object obj10 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C118]");
							_ = 0;
							mesh.SetVertices(array);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Vector2[] array2 = default;
							if (array2 != null)
							{
								_ = 0;
								bool flag3 = array2.Length < 2;
								object obj11 = !flag3;
								object obj12 = array2.Length - 2;
								bool flag4 = obj12 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
								_ = 0;
								object obj13 = ~obj11;
								object obj14 = obj13 | flag4;
								if (obj14 != null)
								{
									goto IL_04fd;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9B0]");
								object obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3E8]");
								_ = 0;
								mesh.SetUVs(0, array2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj17 = obj16;
								int[] array3 = default;
								array3[0] = (int)obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v9+10]");
								array3[4] = 0;
								mesh.SetTriangles(array3, 0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj18 = 0;
								object obj19 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v13+A0]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15+C]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15+C]");
								object obj22 = num + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15+14]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15+14]");
								object obj23 = num2 + 0;
								object obj24 = obj22 * 63;
								double num3 = (double)obj23 * 0.5;
								object obj25 = default;
								mesh.bounds = (Bounds)(&obj25);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
								MeshFilter meshFilter = default;
								if ((object)meshFilter != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
									object obj26 = 0;
									meshFilter.sharedMesh = mesh;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
									object obj27 = this + 80;
									object obj28 = default;
									obj27 = obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (obj27 != null)
									{
										((Renderer)obj27).sharedMaterial = material;
										if ((object)shown != null)
										{
											shown.shadowCastingMode = (ShadowCastingMode)0;
											if (obj27 != null)
											{
												((Renderer)obj27).receiveShadows = false;
												if (obj27 != null)
												{
													((Renderer)obj27).lightProbeUsage = (LightProbeUsage)0;
													if (obj27 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
														object obj29 = 0;
														((Renderer)obj27).reflectionProbeUsage = (ReflectionProbeUsage)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
														MaterialPropertyBlock materialPropertyBlock = default;
														materialPropertyBlock._002Ector();
														object obj30 = this + 88;
														obj30 = materialPropertyBlock;
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
		NullReferenceException ex = new NullReferenceException();
		goto IL_04fd;
		IL_04fd:
		throw new IndexOutOfRangeException();
	}

	private Vector3 Target()
	{
		//IL_0010: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_0233: Expected VT, but got I4
		//IL_0246: Expected VT, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I4
		//IL_02de: Expected VT, but got Obj
		//IL_0300: Expected Obj, but got I4
		//IL_0104: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform = Hand(hand);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 result;
		if (transform != null)
		{
			if ((object)transform == null)
			{
				goto IL_0238;
			}
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v28+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			result = (Vector3)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v9 (UnityEngine.Vector3)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result = (Vector3)obj7;
			}
		}
		else
		{
			Camera main = Camera.main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE000]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = main != null;
			if (flag6)
			{
				if ((object)main != null)
				{
					Transform transform2 = main.transform;
					if ((object)transform2 != null)
					{
						Vector3 position2 = transform2.position;
						Transform transform3 = main.transform;
						if ((object)transform3 != null)
						{
							result = transform3.forward;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							goto IL_030e;
						}
					}
				}
				goto IL_0238;
			}
			result = (Vector3)flag6;
		}
		goto IL_030e;
		IL_030e:
		return result;
		IL_0238:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private void LateUpdate()
	{
		if ((double)age < 3.0)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if ((double)(age += unscaledDeltaTime) < 3.0)
			{
				float unscaledDeltaTime2 = Time.unscaledDeltaTime;
				Place(unscaledDeltaTime2);
			}
			else
			{
				shown.enabled = false;
			}
		}
	}

	private void Place(float dt)
	{
		//IL_037a: Invalid comparison between F4 and I4
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00b8: Expected VT, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected VT, but got Unknown
		//IL_004a: Expected F4, but got I
		//IL_004a: Expected F4, but got I
		//IL_004a: Expected F4, but got VT
		//IL_004a: Expected VT, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_013c: Expected VT, but got I4
		//IL_0270: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got VT
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got I
		//IL_01eb: Expected VT, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_020b: Invalid comparison between VT and I
		//IL_021d: Expected Obj, but got I4
		//IL_0226: Expected VT, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_032d: Invalid comparison between F8 and I4
		//IL_0370: Expected VT, but got I4
		//IL_03a1: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I
		//IL_03c9: Expected VT, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_0249: Expected VT, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_025b: Expected VT, but got I4
		if (dt > 0f)
		{
			Vector3 vector = Target();
			Vector3 current = (Vector3)(this + 140);
			Vector3 vector2 = at;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+84]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+88]");
			ref Vector3 currentVelocity = default;
			Vector3 vector3 = Vector3.SmoothDamp(current, (Vector3)0, ref currentVelocity, (float)vector2, num, 0f);
			at = at;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+84]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+88]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+84]");
		object obj2 = 0;
		Vector3 vector4 = at;
		quad.position = (Vector3)0;
		Camera main = Camera.main;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		bool flag3 = !flag2;
		object obj5 = 0;
		Quaternion quaternion = (Quaternion)0;
		if (!flag3)
		{
			Transform transform = main.transform;
			Vector3 position = transform.position;
			object obj6 = at - vector4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+84]");
			object obj7 = 0 - obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+88]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaToast)+88]");
			object obj8 = num2 - 0;
			object obj9 = obj6 * obj6;
			object obj10 = obj7 * obj7;
			object obj11 = obj9 + obj10;
			object obj12 = obj8 * obj8;
			vector4 = (Vector3)(obj12 + obj11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			obj2 = 0;
			Vector3 vector5 = vector4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			bool flag4 = vector5 <= (object)0;
			obj5 = 0;
			quaternion = (Quaternion)0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj13 = 0;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v19+18]");
				vector4 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v19+20]");
				obj2 = 0;
				Vector3 forward = default;
				Vector3 upwards = default;
				Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
				quad.rotation = (Quaternion)0;
				obj5 = 0;
				quaternion = (Quaternion)0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj22 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float t = age + age;
		float num3 = CosmeticToy.Elastic(t);
		double num4 = 3.0 - (double)age;
		double num5 = num4 * 4.0;
		if (num5 < 0.0 || num5 > 1.0)
		{
		}
		quad.localScale = (Vector3)0;
	}

	static GillaToast()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		_ = 3943697934L;
		object obj5 = obj2;
		obj4 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v3+A0]");
		object obj6 = 0;
		_ = 4285589588L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v3+A0]");
		object obj7 = 0;
		_ = 4282403071L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v3+A0]");
		object obj8 = 0;
		_ = 4293717228L;
	}
}
