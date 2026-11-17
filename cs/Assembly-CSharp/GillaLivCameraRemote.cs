using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class GillaLivCameraRemote : MonoBehaviour
{
	private static readonly Dictionary<int, GillaLivCameraRemote> byPlayer;

	private static ScreenFont titleFont;

	private static ScreenFont textFont;

	private static TextAsset titleFrom;

	private static TextAsset textFrom;

	private static readonly int BaseMap;

	private static readonly int PreviewOn;

	private static readonly int BaseColor;

	private const int W = default(int);

	private const int H = default(int);

	private const float FarthestInHand = default(float);

	private const float FarthestOut = default(float);

	private const int LongestName = default(int);

	private static readonly Color32[] Silver;

	private static readonly Color32[] Orange;

	private static readonly Color32[] Lime;

	private static readonly Color32[] Red;

	private static readonly Color32 Shadow;

	private int player;

	private Func<bool, Transform> handOf;

	private readonly List<Renderer> looks;

	private Renderer body;

	private int screenSlot;

	private int tallySlot;

	private byte state;

	private Vector3 at;

	private Quaternion turn;

	private string whose;

	private bool shown;

	private Texture2D page;

	private Color32[] px;

	private string pageSays;

	private MaterialPropertyBlock screenBlock;

	private MaterialPropertyBlock tallyBlock;

	public static IReadOnlyCollection<GillaLivCameraRemote> All
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0077: Expected Obj, but got I4
			//IL_0095: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
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
			if (obj4 != null)
			{
				return (IReadOnlyCollection<GillaLivCameraRemote>)((Dictionary<int, System.__Canon>)obj4).Values;
			}
			return (IReadOnlyCollection<GillaLivCameraRemote>)new NullReferenceException();
		}
	}

	public int Player => player;

	public bool Shown => shown;

	public byte State => state;

	public Texture2D Page => page;

	public string PageSays => pageSays;

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
		//IL_012f: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
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
		((Dictionary<int, System.__Canon>)obj4).Clear();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v7+A0]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v8+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9+A0]");
		object obj10 = (nint)0 + (nint)32;
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v10+A0]");
		object obj12 = (nint)0 + (nint)24;
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe static GillaLivCameraRemote Of(int player, Func<bool, Transform> handOf)
	{
		//IL_0010: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0080: Expected Obj, but got Ref
		//IL_01df: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I4
		//IL_0523: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
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
		object obj6;
		System.__Canon result;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj6 = 0;
			bool flag2 = ((Dictionary<int, System.__Canon>)obj4).TryGetValue(player, out System.__Canon value);
			bool flag3 = !flag2;
			int num = player;
			object obj7 = (object)(&value);
			if (flag3)
			{
				goto IL_01cf;
			}
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v43+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)(object)value != null)
			{
				if (value != null)
				{
					object obj10 = value + 40;
					obj10 = handOf;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = value;
					goto IL_0401;
				}
			}
			else
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v48+E4]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v48+A0]");
				object obj13 = 0;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2098]");
					object obj14 = 0;
					obj7 = obj14;
					bool flag6 = ((Dictionary<int, System.__Canon>)obj13).Remove(player);
					num = player;
					goto IL_01cf;
				}
			}
		}
		goto IL_0406;
		IL_0406:
		return (GillaLivCameraRemote)(object)new NullReferenceException();
		IL_01cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v15+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj15;
		}
		object obj20 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v15+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v3+28]");
		bool flag10 = (UnityEngine.Object)0 == null;
		bool flag11 = !flag10;
		object obj23 = !flag11;
		result = null;
		if (obj23 != null)
		{
			goto IL_0401;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20B8]");
		object format = 0;
		object arg = default;
		string text = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(text);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20B0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			System.__Canon _Canon = default;
			if (_Canon != null)
			{
				object obj27 = _Canon + 40;
				obj27 = handOf;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v3+28]");
				((GillaLivCameraRemote)(object)_Canon).CopyLooks((GillaLivCamera)0);
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v31+E4]");
				bool flag12 = (nint)0 == 0;
				object obj29 = !flag12;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v31+A0]");
				object obj30 = 0;
				if (obj30 != null)
				{
					((Dictionary<int, System.__Canon>)obj30).set_Item(player, _Canon);
					result = _Canon;
					goto IL_0401;
				}
			}
		}
		goto IL_0406;
		IL_0401:
		return (GillaLivCameraRemote)(object)result;
	}

	public static void Drop(int player)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
		object obj = 0;
		object obj2 = obj;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20A0]");
		object obj5 = 0;
		if (!((Dictionary<int, System.__Canon>)obj4).TryGetValue(player, out System.__Canon value))
		{
			return;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v10+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2098]");
		object obj9 = 0;
		bool flag3 = ((Dictionary<int, System.__Canon>)obj8).Remove(player);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)(object)value != null)
		{
			GameObject obj13 = ((Component)(object)value).gameObject;
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj13);
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20C8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender += unityAction;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20C8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction;
	}

	private unsafe void OnDestroy()
	{
		//IL_029f: Expected Obj, but got I
		//IL_02b3: Expected I4, but got I8
		//IL_02cd: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got Ref
		//IL_00e4: Expected Obj, but got I4
		//IL_0123: Expected I4, but got Obj
		//IL_012c: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		int num = (int)(player & 0x80000000L);
		bool flag = num == 0;
		object obj2 = !flag;
		IntPtr intPtr = default;
		int num2 = (int)(nint)intPtr;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v14+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20A0]");
			object obj7 = 0;
			num2 = player;
			bool flag3 = ((Dictionary<int, System.__Canon>)obj6).TryGetValue(player, out System.__Canon value);
			bool flag4 = !flag3;
			object obj8 = (object)(&value);
			if (!flag4)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v19+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = (UnityEngine.Object)(object)value == this;
				bool flag7 = !flag6;
				num2 = (int)this;
				obj8 = 0;
				if (!flag7)
				{
					object obj11 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v24+E4]");
					bool flag8 = (nint)0 == 0;
					object obj12 = !flag8;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj11 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v24+A0]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2098]");
					object obj14 = 0;
					num2 = player;
					obj8 = obj14;
					bool flag9 = ((Dictionary<int, System.__Canon>)obj13).Remove(player);
				}
			}
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (page != null)
		{
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(page);
		}
	}

	private void CopyLooks(GillaLivCamera source)
	{
		//IL_00e8: Expected Obj, but got I
		//IL_00f6: Expected VT, but got I4
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I4
		//IL_0d0b: Expected Obj, but got I4
		//IL_0d4b: Expected Obj, but got I
		//IL_0d63: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_0f28: Expected Obj, but got I4
		//IL_13a2: Expected Obj, but got I4
		//IL_0da0: Expected Obj, but got I4
		//IL_123d: Expected Obj, but got I
		//IL_125f: Expected Obj, but got I4
		//IL_0f9f: Expected Obj, but got I4
		//IL_0dee: Expected Obj, but got I
		//IL_0e0a: Expected Obj, but got I4
		//IL_0e1a: Expected Obj, but got I
		//IL_12ef: Expected Obj, but got I
		//IL_1311: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_0fed: Expected Obj, but got I
		//IL_0e52: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I4
		//IL_1283: Expected Obj, but got I
		//IL_12b2: Expected Obj, but got I
		//IL_1116: Expected Obj, but got I
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected Obj, but got Unknown
		//IL_1038: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I4
		//IL_1335: Expected Obj, but got I
		//IL_1364: Expected Obj, but got I
		//IL_0e88: Expected Obj, but got I
		//IL_0e9c: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got I4
		//IL_0ed6: Expected Obj, but got I
		//IL_0ef1: Expected Obj, but got I4
		//IL_106e: Expected Obj, but got I
		//IL_1082: Expected Obj, but got I
		//IL_10bc: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I
		//IL_05bb: Expected VT, but got I4
		//IL_05d2: Expected VT, but got I4
		//IL_0602: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got VT
		//IL_07e5: Expected VT, but got I4
		//IL_07fb: Expected Obj, but got I
		//IL_084b: Expected Obj, but got I
		//IL_0875: Expected Obj, but got I4
		//IL_08c0: Invalid comparison between F8 and I
		//IL_1180: Invalid comparison between F8 and I
		//IL_11b6: Invalid comparison between F8 and I
		//IL_11f9: Expected VT, but got I4
		//IL_1209: Expected Obj, but got I
		//IL_096e: Expected Obj, but got I
		//IL_098e: Expected Obj, but got I
		//IL_09cd: Expected Obj, but got I
		//IL_09f4: Expected Obj, but got I
		//IL_0a1b: Expected Obj, but got I
		//IL_0a8a: Expected Obj, but got I
		//IL_0ac2: Expected Obj, but got I
		//IL_0b04: Expected Obj, but got I4
		//IL_0b8f: Expected Obj, but got I
		//IL_0b9f: Expected Obj, but got I
		//IL_0baf: Expected Obj, but got I
		//IL_0c02: Expected Obj, but got I4
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected Obj, but got Unknown
		//IL_0b72: Expected Obj, but got I4
		//IL_0c34: Expected Obj, but got I
		//IL_0c4f: Expected VT, but got F8
		//IL_0c60: Expected Obj, but got I4
		//IL_0c69: Expected Obj, but got I4
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected Obj, but got Unknown
		//IL_0cab: Expected VT, but got I4
		//IL_0ccb: Expected Obj, but got I4
		//IL_0cd4: Expected Obj, but got I4
		object obj5;
		GillaLivCamera gillaLivCamera;
		if ((object)source != null)
		{
			Transform transform = source.transform;
			GameObject gameObject = base.gameObject;
			GameObject gameObject2 = source.gameObject;
			if ((object)gameObject2 != null)
			{
				int layer = gameObject2.layer;
				if ((object)gameObject != null)
				{
					gameObject.layer = layer;
					Transform transform2 = base.transform;
					if ((object)transform != null)
					{
						Vector3 lossyScale = transform.lossyScale;
						if ((object)transform2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5050]");
							object obj = 0;
							transform2.localScale = (Vector3)0;
							object obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
							object obj3 = default;
							if (obj3 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v20+18]");
								object obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v20+18]");
								bool flag = (nint)0 < (nint)1;
								UnityEngine.Object obj6 = (UnityEngine.Object)1;
								gillaLivCamera = source;
								if (flag)
								{
									goto IL_0ce1;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20C0]");
								object obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47F0]");
								object obj8 = 0;
								double num2 = default;
								double num = num2;
								double num4 = default;
								double num3 = num4;
								Quaternion quaternion2 = default;
								Quaternion quaternion = quaternion2;
								double num6 = default;
								double num5 = num6;
								double num8 = default;
								double num7 = num8;
								double num10 = default;
								double num9 = num10;
								double num12 = default;
								double num11 = num12;
								double num14 = default;
								double num13 = num14;
								object obj10 = default;
								object obj9 = obj10;
								object obj11 = 0;
								UnityEngine.Object obj16 = default;
								UnityEngine.Object obj20 = default;
								GameObject gameObject3 = default;
								Quaternion rotation2 = default;
								MeshFilter meshFilter = default;
								Renderer renderer = default;
								while (true)
								{
									bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
									object obj12 = !flag2;
									if (obj12 != null)
									{
										break;
									}
									object obj13 = obj3 + obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
									if ((nint)0 == 0)
									{
										goto IL_10d4;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F56C");
									object obj14 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v31+E4]");
									bool flag3 = (nint)0 == 0;
									object obj15 = !flag3;
									if (obj15 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag4 = obj16 != null;
									bool flag5 = !flag4;
									object obj17 = !flag5;
									num2 = num;
									num4 = num3;
									quaternion2 = quaternion;
									num6 = num5;
									obj2 = 0;
									obj6 = null;
									if (obj17 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
										object obj18 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v34+E4]");
										bool flag6 = (nint)0 == 0;
										object obj19 = !flag6;
										if (obj19 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag7 = obj20 == null;
										bool flag8 = !flag7;
										object obj21 = !flag8;
										num2 = num;
										num4 = num3;
										quaternion2 = quaternion;
										num6 = num5;
										obj2 = 0;
										obj6 = null;
										if (obj21 == null)
										{
											if ((object)obj20 != null)
											{
												Mesh sharedMesh = ((MeshFilter)obj20).sharedMesh;
												object obj22 = obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X8_v35+E4]");
												bool flag9 = (nint)0 == 0;
												object obj23 = !flag9;
												if (obj23 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag10 = sharedMesh == null;
												bool flag11 = !flag10;
												object obj24 = !flag11;
												num2 = num;
												num4 = num3;
												quaternion2 = quaternion;
												num6 = num5;
												UnityEngine.Object obj25 = sharedMesh;
												obj2 = 0;
												obj6 = null;
												if (obj24 != null)
												{
													goto IL_1106;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
												string text = ((UnityEngine.Object)0).name;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
												object obj26 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												gameObject3._002Ector(text);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
												GameObject gameObject4 = ((Component)0).gameObject;
												if ((object)gameObject4 != null)
												{
													int layer2 = gameObject4.layer;
													if ((object)gameObject3 != null)
													{
														gameObject3.layer = layer2;
														Transform transform3 = gameObject3.transform;
														Transform parent = base.transform;
														if ((object)transform3 != null)
														{
															transform3.SetParent(parent, worldPositionStays: false);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
															Transform transform4 = ((Component)0).transform;
															if ((object)transform4 != null)
															{
																Vector3 position = transform4.position;
																Vector3 vector = transform.InverseTransformPoint((Vector3)0);
																transform3.localPosition = (Vector3)0;
																Quaternion rotation = transform.rotation;
																Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation2);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
																Transform transform5 = ((Component)0).transform;
																if ((object)transform5 != null)
																{
																	Quaternion rotation3 = transform5.rotation;
																	double num15 = num5 * (double)quaternion;
																	double num16 = (double)quaternion * num5;
																	double num17 = num5 * num3;
																	double num18 = num3 * num5;
																	double num19 = num5 * num;
																	double num20 = num * num5;
																	double num21 = num5 * num5;
																	object obj27 = quaternion * quaternion;
																	double num22 = num15 + num16;
																	double num23 = num3 * num;
																	double num24 = num3 * (double)quaternion;
																	num9 = num17 + num18;
																	num7 = num * (double)quaternion;
																	double num25 = num * num3;
																	double num26 = num19 + num20;
																	double num27 = (double)quaternion * num3;
																	double num28 = num * num;
																	double num29 = num21 - (double)obj27;
																	double num30 = num3 * num3;
																	double num31 = (double)quaternion * num;
																	double num32 = num23 + num22;
																	num13 = num7 + num9;
																	num11 = num27 + num26;
																	double num33 = num29 - num30;
																	double num34 = num32 - num25;
																	double num35 = num13 - num31;
																	double num36 = num11 - num24;
																	num6 = num33 - num28;
																	transform3.localRotation = (Quaternion)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
																	Transform transform6 = ((Component)0).transform;
																	if ((object)transform6 != null)
																	{
																		Vector3 lossyScale2 = transform6.lossyScale;
																		Vector3 lossyScale3 = transform.lossyScale;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
																		object obj28 = 0;
																		object obj29 = obj28;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X0_v129+E4]");
																		bool flag12 = (nint)0 == 0;
																		object obj30 = !flag12;
																		if (obj30 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
																		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
																		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
																		double num37 = ((!(num34 < 0.0)) ? num34 : 1.0);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
																		double num38 = ((!(num35 < 0.0)) ? num35 : 1.0);
																		double num39 = num34 / num37;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
																		double num40 = ((!(num36 < 0.0)) ? num36 : 1.0);
																		num4 = num35 / num38;
																		num2 = num36 / num40;
																		transform3.localScale = (Vector3)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
																		object obj31 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																		Mesh sharedMesh2 = ((MeshFilter)obj20).sharedMesh;
																		if ((object)meshFilter != null)
																		{
																			meshFilter.sharedMesh = sharedMesh2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
																			object obj32 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
																			Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
																			if ((object)renderer != null)
																			{
																				renderer.sharedMaterials = sharedMaterials;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
																				ShadowCastingMode shadowCastingMode = ((Renderer)0).shadowCastingMode;
																				renderer.shadowCastingMode = shadowCastingMode;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
																				bool receiveShadows = ((Renderer)0).receiveShadows;
																				renderer.receiveShadows = receiveShadows;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
																				LightProbeUsage lightProbeUsage = ((Renderer)0).lightProbeUsage;
																				renderer.lightProbeUsage = lightProbeUsage;
																				renderer.enabled = false;
																				List<System.__Canon> list = (List<System.__Canon>)(object)looks;
																				if ((object)looks != null)
																				{
																					System.__Canon[] items = list._items;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
																					object obj33 = 0;
																					int version = list._version + 1;
																					list._version = version;
																					object obj34 = obj33;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20C0]");
																					obj7 = 0;
																					if (list._items != null)
																					{
																						bool flag13 = list._size < items.Length;
																						object obj35 = !flag13;
																						if (obj35 == null)
																						{
																							object obj36 = list._items + list._size;
																							int size = list._size + 1;
																							list._size = size;
																							object obj37 = obj36 + 32;
																							obj37 = renderer;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							object obj38 = 0;
																							System.__Canon _Canon = (System.__Canon)(object)renderer;
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v16+20]");
																							object obj39 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v49+A8]");
																							object obj40 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v50+70]");
																							object obj38 = 0;
																							((List<System.__Canon>)(object)looks).AddWithResize((System.__Canon)(object)renderer);
																							System.__Canon _Canon = (System.__Canon)(object)renderer;
																						}
																						object obj41 = obj5;
																						obj25 = source.body;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v154+E4]");
																						bool flag14 = (nint)0 == 0;
																						object obj42 = !flag14;
																						if (obj42 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v30+20]");
																						bool flag15 = (UnityEngine.Object)0 == obj25;
																						bool flag16 = !flag15;
																						quaternion2 = (Quaternion)num39;
																						rotation2 = quaternion;
																						obj9 = 0;
																						obj2 = 0;
																						obj6 = obj25;
																						if (!flag16)
																						{
																							object obj43 = this + 56;
																							body = renderer;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							quaternion2 = (Quaternion)source.screenSlot;
																							screenSlot = source.screenSlot;
																							rotation2 = quaternion;
																							obj9 = 0;
																							obj2 = 0;
																							obj6 = renderer;
																						}
																						goto IL_1106;
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
											goto IL_10d4;
										}
									}
									goto IL_1106;
									IL_1106:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v20+18]");
									obj4 = 0;
									obj11++;
									object obj44 = obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v20+18]");
									bool flag17 = (nint)obj44 < 0;
									gillaLivCamera = source;
									num = num2;
									num3 = num4;
									quaternion = quaternion2;
									num5 = num6;
									if (flag17)
									{
										continue;
									}
									goto IL_0ce1;
								}
								goto IL_10e2;
							}
						}
					}
				}
			}
		}
		goto IL_10d4;
		IL_10e2:
		throw new IndexOutOfRangeException();
		IL_10d4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_10e2;
		IL_0ce1:
		object obj45 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v22+E4]");
		bool flag18 = (nint)0 == 0;
		object obj46 = !flag18;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag19 = gillaLivCamera.titleFont != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
		object obj47 = 0;
		bool flag20 = !flag19;
		object obj48 = 0;
		UnityEngine.Object obj49 = null;
		if (!flag20)
		{
			object obj50 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v57+E4]");
			bool flag21 = (nint)0 == 0;
			object obj51 = !flag21;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj50 = obj47;
			}
			object obj52 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v57+A0]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v21+E4]");
			bool flag22 = (nint)0 == 0;
			object obj54 = !flag22;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TextAsset textAsset = gillaLivCamera.titleFont;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X9_v7+18]");
			bool flag23 = textAsset != (UnityEngine.Object)0;
			bool flag24 = !flag23;
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X9_v7+18]");
			obj49 = (UnityEngine.Object)0;
			if (!flag24)
			{
				object obj55 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v62+E4]");
				bool flag25 = (nint)0 == 0;
				object obj56 = !flag25;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj55 = obj47;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v62+A0]");
				object obj57 = (nint)0 + (nint)24;
				obj57 = gillaLivCamera.titleFont;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj58 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v23+A0]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v24+18]");
				if ((nint)0 == 0)
				{
					goto IL_10d4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v24+18]");
				string text2 = ((TextAsset)0).text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont = default;
				screenFont._002Ector(text2);
				object obj61 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v28+A0]");
				object obj62 = (nint)0 + (nint)8;
				obj62 = screenFont;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj48 = 0;
				obj49 = (UnityEngine.Object)(object)screenFont;
			}
		}
		object obj63 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v27+E4]");
		bool flag26 = (nint)0 == 0;
		object obj64 = !flag26;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaLivCamera.textFont != null)
		{
			object obj65 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v33+E4]");
			bool flag27 = (nint)0 == 0;
			object obj66 = !flag27;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj65 = obj47;
			}
			object obj67 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v33+A0]");
			object obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v12+E4]");
			bool flag28 = (nint)0 == 0;
			object obj69 = !flag28;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TextAsset textAsset2 = gillaLivCamera.textFont;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X9_v6+20]");
			if (textAsset2 != (UnityEngine.Object)0)
			{
				object obj70 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v38+E4]");
				bool flag29 = (nint)0 == 0;
				object obj71 = !flag29;
				if (obj71 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj70 = obj47;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v38+A0]");
				object obj72 = (nint)0 + (nint)32;
				obj72 = gillaLivCamera.textFont;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj73 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v14+A0]");
				object obj74 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v15+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v15+20]");
					string text3 = ((TextAsset)0).text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
					object obj75 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					ScreenFont screenFont2 = default;
					screenFont2._002Ector(text3);
					object obj76 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v19+A0]");
					object obj77 = (nint)0 + (nint)16;
					obj77 = screenFont2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
				goto IL_10d4;
			}
		}
	}

	private static float Nonzero(float f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		object obj = default;
		if ((nint)obj < 0)
		{
		}
		return 1f;
	}

	public void Set(byte said, Vector3 where, Quaternion how, string name)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got VT
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0100: Expected VT, but got Obj
		//IL_0122: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got VT
		//IL_02aa: Invalid comparison between Obj and F8
		//IL_02bb: Expected Obj, but got I4
		//IL_02d3: Invalid comparison between F8 and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_01cd: Expected F8, but got I
		//IL_031b: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I
		//IL_0244: Expected VT, but got Obj
		//IL_0466: Expected Obj, but got I
		//IL_0479: Invalid comparison between VT and I4
		//IL_03f2: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I
		//IL_0412: Expected VT, but got Obj
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_042a: Expected Obj, but got VT
		//IL_0251: Expected VT, but got Obj
		int num = said & 3;
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector = default;
			object obj4 = ~vector;
			object obj5 = 0x7F800000 & obj4;
			if (obj5 != null)
			{
				object obj7 = default;
				object obj6 = ~obj7;
				object obj8 = 0x7F800000 & obj6;
				if (obj8 != null)
				{
					object obj10 = default;
					object obj9 = ~obj10;
					object obj11 = 0x7F800000 & obj9;
					if (obj11 != null)
					{
						Quaternion q = (Quaternion)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v10 (UnityEngine.Quaternion)+E4]");
						bool flag2 = (nint)0 == 0;
						object obj12 = !flag2;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (Real(q))
						{
							object obj13 = vector * vector;
							object obj14 = obj7 * obj7;
							object obj15 = obj10 * obj10;
							object obj16 = obj13 + obj14;
							double num2;
							if (num == 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC1C]");
								num2 = 0.0;
							}
							else
							{
								num2 = 2.25;
							}
							object obj17 = obj15 + obj16;
							bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2);
							object obj18 = !flag3;
							double num3 = (double)obj17 - num2;
							bool flag4 = num3 == 0.0;
							object obj19 = ~obj18;
							object obj20 = obj19 | flag4;
							object obj21 = ~obj20;
							byte b = (byte)((obj21 == null) ? said : 0);
							state = b;
							object obj22 = !flag4;
							object obj23 = obj18 & obj22;
							if (obj23 == null)
							{
								at = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
								object obj24 = 0;
								object obj26 = default;
								object obj25 = obj26 * obj26;
								object obj27 = obj24;
								object obj29 = default;
								object obj28 = obj29 * obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v16+A0]");
								object obj30 = 0;
								object obj31 = obj25 + obj28;
								object obj33 = default;
								object obj32 = obj33 * obj33;
								object obj34 = obj32 + obj31;
								object obj36 = default;
								object obj35 = obj36 * obj36;
								object obj37 = obj35 + obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Quaternion quaternion;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									quaternion = (Quaternion)(obj26 / obj37);
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
									object obj38 = 0;
									object obj39 = obj38;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v26+A0]");
									object obj40 = 0;
									quaternion = (Quaternion)obj40;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								object obj41 = 0;
								turn = quaternion;
								Vector3 vector2 = ((where != (Vector3)(object)0) ? where : ((Vector3)obj41));
								object obj42 = this + 104;
								obj42 = vector2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Show(on: true);
								Screen();
								Tally();
								return;
							}
							goto IL_044a;
						}
					}
				}
			}
		}
		state = 0;
		goto IL_044a;
		IL_044a:
		Show(on: false);
	}

	private unsafe void Show(bool on)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Ref, but got Unknown
		//IL_03b8: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_00e6: Expected I, but got Obj
		//IL_0180: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0212: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		if (shown == on)
		{
			return;
		}
		shown = on;
		bool flag = (object)looks == null;
		UnityEngine.Object obj2 = default;
		UnityEngine.Object obj = obj2;
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj3 = (UnityEngine.Object)on;
		if (!flag)
		{
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)looks).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Enumerator<, > val2 = default;
			object obj15 = default;
			nint num;
			object obj8;
			Enumerator<, > val3;
			Enumerator<, > val4;
			while (true)
			{
				if (val.MoveNext())
				{
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v30+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = obj2 != null;
					bool flag4 = !flag3;
					num = unchecked((nint)null);
					if (!flag4)
					{
						if ((object)obj2 == null)
						{
							break;
						}
						((Renderer)obj2).enabled = on;
						num = unchecked((nint)null);
					}
					continue;
				}
				obj = null;
				obj8 = 0;
				val = val2;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				object obj9 = 0;
				object obj10 = 5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
					object obj11 = 0;
					obj3 = (UnityEngine.Object)obj11;
					((Enumerator<, >*)val4)->Dispose();
					bool flag5 = obj9 == null;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						bool flag6 = (object)obj == null;
						object obj13 = !flag6;
						OutOfMemoryException ex = (OutOfMemoryException)val4;
						if (obj13 == null)
						{
							if ((nint)obj10 != 5)
							{
								bool flag7 = obj10 == null;
								object obj14 = !flag7;
								if (obj14 != null)
								{
									return;
								}
							}
							if (on)
							{
								Place();
							}
							return;
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
						obj = (UnityEngine.Object)1;
						obj9 = obj8;
					}
					else
					{
						if ((nint)obj3 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj9 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj8 = obj15;
					}
					obj10 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D088");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			NullReferenceException ex2 = new NullReferenceException();
			num = unchecked((nint)null);
			obj = null;
			obj8 = 0;
			val = val2;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			obj3 = null;
		}
		throw new NullReferenceException();
	}

	private void Place()
	{
		//IL_01a8: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_00a7: Expected VT, but got I
		//IL_0197: Expected VT, but got I4
		//IL_0140: Expected VT, but got I4
		//IL_0140: Expected VT, but got I4
		//IL_015f: Expected VT, but got I4
		if (~(shown ? 1u : 0u) != 0)
		{
			return;
		}
		int num = state & 3;
		Transform transform2;
		Quaternion quaternion = default;
		if (num == 3)
		{
			Transform transform = base.transform;
			transform2 = transform;
		}
		else
		{
			Func<bool, Transform> func = handOf;
			UnityEngine.Object obj2;
			if (handOf != null)
			{
				object obj = num - 2;
				bool flag = obj == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v4 (System.Func`2<System.Boolean, UnityEngine.Transform>)+28]");
				quaternion = (Quaternion)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ X9_v4 (System.Func`2<System.Boolean, UnityEngine.Transform>)+18] (should have been resolved before IL gen)");
				UnityEngine.Object obj3 = default;
				obj2 = obj3;
			}
			else
			{
				obj2 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (obj2 == null)
			{
				return;
			}
			Transform transform3 = base.transform;
			Vector3 position = ((Transform)obj2).position;
			Quaternion rotation = ((Transform)obj2).rotation;
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			Quaternion rotation2 = ((Transform)obj2).rotation;
			quaternion = (Quaternion)0;
			transform2 = transform3;
		}
		transform2.SetPositionAndRotation((Vector3)0, quaternion);
	}

	private static bool Real(Vector3 v)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		object obj2 = default;
		object obj = ~obj2;
		object obj3 = 0x7F800000 & obj;
		bool flag = obj3 == null;
		bool flag2 = !flag;
		object obj5 = default;
		object obj4 = ~obj5;
		object obj6 = 0x7F800000 & obj4;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		bool result = obj7 != null && flag2;
		object obj9 = default;
		object obj8 = ~obj9;
		object obj10 = 0x7F800000 & obj8;
		bool flag4 = obj10 == null;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			return false;
		}
		return result;
	}

	private static bool Real(Quaternion q)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_0159: Invalid comparison between F8 and I4
		//IL_0168: Invalid comparison between F8 and I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected I4, but got Unknown
		object obj2 = default;
		object obj = ~obj2;
		object obj3 = 0x7F800000 & obj;
		if (obj3 != null)
		{
			object obj5 = default;
			object obj4 = ~obj5;
			object obj6 = 0x7F800000 & obj4;
			if (obj6 != null)
			{
				object obj8 = default;
				object obj7 = ~obj8;
				object obj9 = 0x7F800000 & obj7;
				if (obj9 != null)
				{
					object obj11 = default;
					object obj10 = ~obj11;
					object obj12 = 0x7F800000 & obj10;
					bool flag = obj12 == null;
					object obj13 = !flag;
					if (obj13 != null)
					{
						object obj14 = obj2 * obj2;
						object obj15 = obj5 * obj5;
						object obj16 = obj14 + obj15;
						object obj17 = obj8 * obj8;
						object obj18 = obj17 + obj16;
						object obj19 = obj11 * obj11;
						object obj20 = obj19 + obj18;
						double num = (double)obj20 - 0.5;
						bool flag2 = num < 0.0;
						bool flag3 = num == 0.0;
						object obj21 = obj20 ^ 0.5;
						object obj22 = obj20 ^ num;
						object obj23 = obj21 & obj22;
						bool flag4 = (nint)obj23 < 0;
						bool flag5 = flag2 == flag4;
						object obj24 = !flag3;
						return (byte)((flag5 & obj24) ? 1 : 0) != 0;
					}
				}
			}
		}
		return false;
	}

	private unsafe void Screen()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0800: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0070: Expected I4, but got I8
		//IL_008a: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_04a4: Expected Obj, but got I4
		//IL_081e: Expected Obj, but got I
		//IL_082c: Expected Obj, but got Ref
		//IL_0846: Expected Obj, but got I
		//IL_0865: Expected VT, but got Ref
		//IL_0865: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_04e1: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03e2: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I
		//IL_057e: Expected Obj, but got I
		//IL_088c: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got I
		//IL_0943: Expected Obj, but got I
		//IL_0951: Expected Obj, but got Ref
		//IL_097a: Expected VT, but got Ref
		//IL_097a: Expected Obj, but got I
		//IL_0992: Expected Obj, but got I
		//IL_09b1: Expected Obj, but got I
		//IL_05af: Expected Obj, but got I
		//IL_08a5: Expected Obj, but got I4
		//IL_05d1: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I4
		//IL_064f: Expected Obj, but got I4
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got Ref
		//IL_09f6: Expected VT, but got Ref
		//IL_09f6: Expected Obj, but got I
		//IL_067f: Expected Obj, but got I
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected Obj, but got Unknown
		//IL_0628: Expected Obj, but got I
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_06d7: Expected Obj, but got I4
		//IL_0925: Expected Obj, but got I4
		//IL_0764: Expected Obj, but got I
		//IL_06fe: Expected Obj, but got I
		//IL_079a: Expected Obj, but got I
		//IL_0738: Expected I4, but got Obj
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
		bool flag2 = body == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		int num = (int)(screenSlot & 0x80000000L);
		bool flag4 = num == 0;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Clean(whose);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v10+30]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = default;
		string text2 = flag7.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
		object obj12 = 0;
		string text3 = text + (string)obj12 + text2;
		object obj13 = this + 136;
		bool flag8 = text3 == (string)obj13;
		bool flag9 = !flag8;
		object obj14 = 0;
		if (!flag9)
		{
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v83+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = page != null;
			bool flag12 = !flag11;
			object obj17 = !flag12;
			obj14 = 0;
			if (obj17 != null)
			{
				return;
			}
		}
		pageSays = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj18 = obj;
		object obj19 = this + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v20+E4]");
		bool flag13 = (nint)0 == 0;
		object obj20 = !flag13;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = (UnityEngine.Object)obj19 == null;
		bool flag15 = !flag14;
		TextureFormat textureFormat = (TextureFormat)0;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(320, 200, (TextureFormat)4, mipChain: true);
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20D8]");
			object obj24 = 0;
			texture2D.name = (string)obj24;
			page = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj26 = this + 128;
			UnityEngine.Object obj27 = default;
			obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			textureFormat = (TextureFormat)4;
			obj21 = 0;
			obj22 = obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj28 = 0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v27+E4]");
		bool flag16 = (nint)0 == 0;
		object obj30 = !flag16;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 320, 200);
		GillaBoardLook.Frame(px, 320, 200, 3);
		object obj31 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v32+E4]");
		bool flag17 = (nint)0 == 0;
		object obj32 = !flag17;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v32+A0]");
		object obj33 = 0;
		object obj35 = default;
		object obj34 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj35, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1F68]");
		object text4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v22+8]");
		object obj36 = default;
		Line((ScreenFont)0, 52, (string)text4, (ShiftAuth.Style)(&obj36));
		object obj37 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v30+A0]");
		object obj38 = 0;
		string text6;
		if (text._stringLength > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20D0]");
			object obj39 = 0;
			string text5 = text + (string)obj39;
			obj37 = obj6;
			text6 = text5;
			int num2 = 0;
			ScreenFont screenFont = (ScreenFont)obj39;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20E8]");
			object obj40 = 0;
			text6 = (string)obj40;
			int num2 = 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v22+8]");
			ScreenFont screenFont = (ScreenFont)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v30+E4]");
		bool flag18 = (nint)0 == 0;
		object obj41 = !flag18;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj37 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v30+A0]");
		object obj42 = 0;
		object obj43 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj35, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X9_v7+10]");
		object obj44 = default;
		Line((ScreenFont)0, 98, text6, (ShiftAuth.Style)(&obj44));
		object obj45 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20E0]");
		object text7 = 0;
		bool flag19 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v41+A0]");
		object obj46 = 0;
		if (flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1CE8]");
			text7 = 0;
		}
		object obj47 = !flag19;
		object obj48 = ~obj47;
		if (obj48 == null)
		{
			object obj49 = 1 + 1;
		}
		else
		{
			object obj49 = 1;
		}
		if (flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v41+E4]");
			bool flag20 = (nint)0 == 0;
			object obj50 = !flag20;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj51 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v48+A0]");
				obj46 = 0;
			}
			object obj52 = obj46 + 80;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v41+E4]");
			bool flag21 = (nint)0 == 0;
			object obj53 = !flag21;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj54 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v44+A0]");
				obj46 = 0;
			}
			object obj52 = obj46 + 72;
		}
		object obj55 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj35, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v42+10]");
		object obj56 = default;
		Line((ScreenFont)0, 120, (string)text7, (ShiftAuth.Style)(&obj56));
		page.SetPixels32(px);
		page.Apply(updateMipmaps: true);
		object obj57 = this + 144;
		MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)obj57;
		bool flag22 = obj57 == null;
		object obj58 = !flag22;
		bool flag23 = true;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock2 = default;
			materialPropertyBlock2._002Ector();
			obj57 = materialPropertyBlock2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			materialPropertyBlock = (MaterialPropertyBlock)obj57;
			flag23 = (byte)(int)materialPropertyBlock2 != 0;
		}
		object obj60 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v49+E4]");
		bool flag24 = (nint)0 == 0;
		object obj61 = !flag24;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj62 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v36+A0]");
		object obj63 = 0;
		MaterialPropertyBlock materialPropertyBlock3 = materialPropertyBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v37+28]");
		materialPropertyBlock3.SetTexture(0, (Texture)obj19);
		object obj64 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v38+A0]");
		object obj65 = 0;
		object obj66 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v39+2C]");
		((MaterialPropertyBlock)obj66).SetFloat(0, 0f);
		body.SetPropertyBlock(screenBlock, screenSlot);
	}

	private static string Clean(string name)
	{
		//IL_0015: Expected Obj, but got I
		string text;
		if (string.IsNullOrEmpty(name))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			text = (string)obj;
			goto IL_00d1;
		}
		if (name != null)
		{
			string text2 = name.Trim();
			if (text2 != null)
			{
				text = text2.ToUpperInvariant();
				if (text != null)
				{
					if (text._stringLength >= 17)
					{
						return text.Substring(0, 16);
					}
					goto IL_00d1;
				}
			}
		}
		return (string)(object)new NullReferenceException();
		IL_00d1:
		return text;
	}

	private unsafe void Line(ScreenFont font, int y, string text, ShiftAuth.Style style)
	{
		//IL_0048: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected I4, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_002f: Expected Ref, but got VT
		//IL_024b: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_029a: Expected VT, but got Ref
		if (font != null)
		{
			int num = font.DrawCentred(px, 320, 200, 160, y, text, ref *(ShiftAuth.Style*)style);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = style.scale - 1;
		bool flag = (nint)obj3 < 0;
		bool flag2 = obj3 == null;
		int num2 = style.scale ^ 1;
		int num3 = style.scale ^ obj3;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		int scale = ((obj6 != null) ? 1 : style.scale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5 = PixelFont.Measure(text, scale);
		Color32[] colours = style.colours;
		if (style.colours != null)
		{
			bool flag6 = num5 < 0;
			int num6 = num5 ^ num5;
			int num7 = num5 & num6;
			bool flag7 = num7 < 0;
			bool flag8 = flag6 == flag7;
			object obj8 = !flag8;
			object obj9 = ~obj8;
			int num8 = ((obj9 != null) ? num5 : (num5 + 1));
			int x = 160 - num8;
			PixelFont.Draw(px, 320, 200, x, y, text, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), scale);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Tally()
	{
		//IL_0010: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0070: Expected I4, but got I8
		//IL_008a: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_0193: Invalid comparison between F4 and I4
		//IL_01a4: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I
		//IL_030e: Expected VT, but got I4
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
		if (obj5 == null)
		{
			object obj6 = this + 152;
			bool flag5 = obj6 == null;
			object obj7 = !flag5;
			UnityEngine.Object obj8 = null;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock = default;
				materialPropertyBlock._002Ector();
				obj6 = materialPropertyBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj8 = (UnityEngine.Object)(object)materialPropertyBlock;
			}
			int num2 = state & 4;
			bool flag6 = num2 == 0;
			object obj10 = !flag6;
			object obj11;
			if (obj10 == null)
			{
				obj11 = 1;
			}
			else
			{
				float unscaledTime = Time.unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0F0");
				float num3 = unscaledTime - 0.75f;
				bool flag7 = num3 < 0f;
				object obj12 = !flag7;
				obj11 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v8+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v14+A0]");
			object obj23 = 0;
			object obj24 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v15+30]");
			((MaterialPropertyBlock)obj24).SetColor(0, (Color)0);
			body.SetPropertyBlock(tallyBlock, tallySlot);
		}
	}

	public unsafe bool On(Transform target, float mm, float degrees, out float offBy, out float turnedBy)
	{
		//IL_0269: Expected I4, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I4
		//IL_00dd: Expected Ref, but got F4
		//IL_0141: Expected Obj, but got I4
		//IL_01ac: Invalid comparison between F4 and I
		//IL_01bb: Expected F4, but got I4
		//IL_02e4: Expected Ref, but got F4
		//IL_02fd: Expected Obj, but got I4
		//IL_0315: Invalid comparison between F4 and I4
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected I4, but got Unknown
		//IL_021c: Expected Obj, but got I4
		//IL_0239: Invalid comparison between F4 and I4
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			if ((object)target != null)
			{
				Vector3 position2 = target.position;
				float num = mm - mm;
				float num2 = degrees - degrees;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj = 0;
				object obj3 = default;
				object obj2 = obj3 - obj3;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num3 = num * num;
				float num4 = num2 * num2;
				float num5 = num3 + num4;
				object obj6 = obj2 * obj2;
				float num6 = (float)obj6 + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				float num7 = num6 * 1.1488461E+09f;
				ref float reference = ref *(float*)num7;
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Quaternion rotation = transform2.rotation;
					Quaternion rotation2 = target.rotation;
					float num8 = num7 * num7;
					object obj7 = unchecked(1148846080 * 1148846080);
					float num9 = num8 + (float)obj7;
					object obj8 = obj3 * obj3;
					float num10 = (float)obj8 + num9;
					object obj10 = default;
					object obj9 = obj10 * obj10;
					float num11 = (float)obj9 + num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
					bool flag2 = num11 > 0f;
					float num12 = 0f;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFE0");
						float num13 = num11 + num11;
						float num14 = num13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
						num12 = num14 * 0f;
					}
					ref float reference2 = ref *(float*)num12;
					bool flag3 = num12 < degrees;
					object obj11 = !flag3;
					float num15 = num12 - degrees;
					bool flag4 = num15 == 0f;
					object obj12 = ~obj11;
					object obj13 = obj12 | flag4;
					object obj14 = ~obj13;
					object obj15;
					bool flag6;
					if (obj14 == null)
					{
						bool flag5 = offBy < mm;
						obj15 = !flag5;
						float num16 = offBy - mm;
						flag6 = num16 == 0f;
					}
					else
					{
						flag6 = false;
						obj15 = 1;
					}
					object obj16 = ~obj15;
					return (byte)((obj16 | flag6) ? 1 : 0) != 0;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public GillaLivCameraRemote()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0040: Expected I4, but got I8
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0085: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00ba: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj2 = 0;
		player = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = this + 48;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v8+A0]");
		object obj6 = 0;
		object obj7 = this + 104;
		obj7 = obj2;
		turn = (Quaternion)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaLivCameraRemote()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I8
		//IL_0294: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_03f8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D20F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2018]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+A0]");
		object obj8 = 0;
		obj8 = dictionary;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)obj3);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+A0]");
		object obj11 = 0;
		int num2 = Shader.PropertyToID((string)obj4);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8+A0]");
		object obj13 = 0;
		int num3 = Shader.PropertyToID((string)obj5);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v10+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v13+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v13+18]");
			bool flag = (nint)0 == 1;
			_ = 4294967295L;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v13+18]");
				bool flag2 = (nint)0 < (nint)2;
				object obj16 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v13+18]");
				object obj17 = -2;
				bool flag3 = obj17 == null;
				_ = 4291348680L;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag3;
				if (obj19 == null)
				{
					_ = 4287401100L;
					object obj20 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v17+A0]");
					object obj21 = (nint)0 + (nint)56;
					object obj22 = default;
					obj21 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v22+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v22+18]");
						bool flag4 = (nint)0 == 1;
						object obj23 = 4284444415L + 675840;
						if (!flag4)
						{
							_ = 4279859440L;
							object obj24 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v21+A0]");
							object obj25 = (nint)0 + (nint)64;
							object obj26 = default;
							obj25 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v27+18]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v27+18]");
								bool flag5 = (nint)0 == 1;
								_ = 4285464460L;
								if (!flag5)
								{
									_ = 4280866600L;
									object obj27 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v25+A0]");
									object obj28 = (nint)0 + (nint)72;
									object obj29 = default;
									obj28 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v32+18]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v32+18]");
										bool flag6 = (nint)0 == 1;
										_ = 4284444415L;
										if (!flag6)
										{
											_ = 4279837665L;
											object obj30 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v29+A0]");
											object obj31 = (nint)0 + (nint)80;
											object obj32 = default;
											obj31 = obj32;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj33 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v30+A0]");
											object obj34 = 0;
											_ = 4281348144L;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
