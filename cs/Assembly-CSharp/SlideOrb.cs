using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class SlideOrb : MonoBehaviour
{
	public Transform frame;

	public Vector3 from;

	public Vector3 to;

	public float reach;

	public float lean;

	public AudioClip grabSound;

	public AudioClip tickSound;

	public Action<int> Dropped;

	public bool Locked;

	private static readonly List<SlideOrb> all;

	private static readonly bool[] gripWas;

	private static int gripFrame;

	private static readonly bool[] gripNow;

	private static readonly bool[] gripDown;

	private Vector3 rest;

	private int hand = -1;

	private float x;

	private float v;

	private float swell = 1f;

	private float swellV;

	private Vector3 off;

	private Vector3 offV;

	private float ticked;

	private float shake;

	private float popT;

	private float appear;

	private float appearV;

	private bool snapped;

	private Transform ring;

	private float ringShow;

	public float Along => x;

	public int Hand => hand;

	public bool AtEnd
	{
		get
		{
			//IL_0014: Expected I4, but got I8
			//IL_002e: Expected Obj, but got I4
			int num = (int)(hand & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				bool flag2 = !snapped;
				return !flag2;
			}
			return false;
		}
	}

	public static SlideOrb On(Transform orb, Transform frame, Vector3 from, Vector3 to, AudioClip grab, AudioClip tick)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got VT
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got VT
		//IL_0089: Expected Obj, but got I
		SlideOrb slideOrb2;
		if ((object)orb != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5A0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			SlideOrb slideOrb = default;
			bool flag = (object)slideOrb == null;
			object obj2 = !flag;
			slideOrb2 = slideOrb;
			if (obj2 != null)
			{
				goto IL_00b8;
			}
			GameObject gameObject = orb.gameObject;
			if ((object)gameObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5A8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				SlideOrb slideOrb3 = default;
				bool flag2 = (object)slideOrb3 == null;
				slideOrb2 = slideOrb3;
				if (!flag2)
				{
					goto IL_00b8;
				}
			}
		}
		return (SlideOrb)(object)new NullReferenceException();
		IL_00b8:
		object obj4 = slideOrb2 + 32;
		obj4 = frame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Vector3 vector = default;
		slideOrb2.from = vector;
		Vector3 vector2 = default;
		slideOrb2.to = vector2;
		object obj5 = slideOrb2 + 72;
		obj5 = from;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = slideOrb2 + 80;
		obj6 = to;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return slideOrb2;
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
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
		List<System.__Canon> list = (List<System.__Canon>)obj4;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag2 = list._size < items.Length;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)this);
		}
		Transform transform = base.transform;
		Vector3 localScale = transform.localScale;
		Vector3 vector = default;
		rest = vector;
		MakeRing();
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I
		//IL_004f: Expected I4, but got I8
		//IL_0069: Expected Obj, but got I4
		//IL_0086: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
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
		bool flag2 = ((List<System.__Canon>)obj4).Remove((System.__Canon)(object)this);
		int num = (int)(hand & 0x80000000L);
		bool flag3 = num == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			hand = -1;
		}
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1932: Expected Obj, but got I
		//IL_1965: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_199d: Expected Obj, but got I4
		//IL_22aa: Expected Obj, but got I
		//IL_22cd: Expected Obj, but got I4
		//IL_1a04: Expected I4, but got I8
		//IL_19bb: Expected Obj, but got I
		//IL_19d3: Expected Obj, but got I
		//IL_1b4a: Expected Obj, but got I
		//IL_1b5a: Expected Obj, but got I
		//IL_1b6e: Expected I4, but got I8
		//IL_1b88: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0935: Expected Obj, but got I
		//IL_0945: Expected F8, but got I
		//IL_094d: Expected F4, but got Obj
		//IL_095d: Expected F8, but got I
		//IL_0966: Expected F8, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I4
		//IL_1c48: Expected Obj, but got I4
		//IL_0169: Invalid comparison between F4 and I4
		//IL_010d: Expected I, but got Obj
		//IL_23a9: Expected I4, but got I8
		//IL_23c3: Expected Obj, but got I4
		//IL_09a2: Expected Obj, but got I4
		//IL_10be: Expected F4, but got I
		//IL_10ce: Invalid comparison between F4 and I
		//IL_1c66: Expected Obj, but got I
		//IL_1c76: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_0fca: Expected F4, but got I
		//IL_0fe6: Invalid comparison between F4 and I
		//IL_0ffe: Expected VT, but got I4
		//IL_1a98: Expected Obj, but got I4
		//IL_219b: Expected Obj, but got I
		//IL_21a3: Expected F4, but got Obj
		//IL_21b3: Expected F4, but got I
		//IL_21db: Expected F4, but got I
		//IL_21f3: Expected VT, but got I4
		//IL_10ff: Expected F4, but got I
		//IL_202e: Expected F4, but got I
		//IL_203e: Invalid comparison between F4 and I
		//IL_204f: Expected I4, but got VT
		//IL_09ea: Expected Obj, but got I4
		//IL_2175: Expected Obj, but got I4
		//IL_145a: Expected I4, but got I8
		//IL_14a1: Expected VT, but got I4
		//IL_1015: Invalid comparison between F4 and I4
		//IL_1024: Expected F8, but got I4
		//IL_1ba6: Expected Obj, but got I
		//IL_1bbe: Expected Obj, but got I
		//IL_0621: Expected Obj, but got I4
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d6: Expected Ref, but got Unknown
		//IL_14dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e1: Expected Ref, but got Unknown
		//IL_1512: Expected I4, but got I8
		//IL_152c: Expected Obj, but got I4
		//IL_1441: Expected I4, but got VT
		//IL_2084: Invalid comparison between F8 and I4
		//IL_0a0f: Expected Obj, but got I
		//IL_0a5d: Expected Obj, but got VT
		//IL_0a7a: Expected Obj, but got I
		//IL_0a8a: Expected VT, but got I4
		//IL_0a9e: Expected F8, but got I
		//IL_0b24: Invalid comparison between F8 and I
		//IL_0b72: Expected F8, but got I
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected Obj, but got Unknown
		//IL_0b9d: Invalid comparison between F8 and I4
		//IL_0bac: Invalid comparison between F8 and I4
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected Obj, but got Unknown
		//IL_0bd4: Expected Obj, but got F8
		//IL_0c09: Expected Obj, but got I4
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected Obj, but got Unknown
		//IL_24f7: Expected Obj, but got I4
		//IL_154a: Expected F4, but got I
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected Obj, but got Unknown
		//IL_1ab6: Expected Obj, but got I
		//IL_1ace: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I4
		//IL_1668: Invalid comparison between F4 and I4
		//IL_157c: Expected F8, but got I
		//IL_20f5: Expected Obj, but got I
		//IL_213d: Expected Obj, but got I4
		//IL_1cab: Expected Obj, but got I
		//IL_1cda: Invalid comparison between F8 and I4
		//IL_1ce9: Invalid comparison between F8 and I4
		//IL_1cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d04: Expected Obj, but got Unknown
		//IL_1d11: Expected Obj, but got F8
		//IL_1d46: Expected Obj, but got I4
		//IL_1d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d53: Expected Obj, but got Unknown
		//IL_0c3d: Expected F8, but got I
		//IL_0c81: Expected Obj, but got I
		//IL_0c91: Invalid comparison between F8 and I
		//IL_090c: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		//IL_1795: Expected Obj, but got I8
		//IL_1205: Expected VT, but got I4
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b8: Expected Obj, but got Unknown
		//IL_20d2: Expected Obj, but got I4
		//IL_1d9a: Expected Obj, but got I4
		//IL_1a39: Expected Obj, but got I
		//IL_1a49: Expected Obj, but got I
		//IL_17a5: Invalid comparison between F4 and I4
		//IL_16a9: Expected Obj, but got I4
		//IL_13d3: Expected F4, but got I
		//IL_23da: Invalid comparison between F8 and I4
		//IL_23e9: Expected F8, but got I4
		//IL_0cd3: Expected Obj, but got I4
		//IL_2226: Expected I4, but got I8
		//IL_1779: Expected Obj, but got I8
		//IL_1223: Expected Obj, but got I
		//IL_1f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f12: Expected Obj, but got Unknown
		//IL_0d58: Expected Obj, but got I4
		//IL_06a9: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_17d6: Invalid comparison between F4 and I4
		//IL_1e0b: Invalid comparison between F8 and I4
		//IL_1e1a: Expected F8, but got I4
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_1258: Expected Obj, but got Unknown
		//IL_1f7f: Expected Obj, but got I4
		//IL_1e72: Invalid comparison between F8 and I4
		//IL_1e81: Expected F8, but got I4
		//IL_06fa: Expected Obj, but got I
		//IL_0702: Expected I4, but got Obj
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_032f: Expected Obj, but got I
		//IL_0354: Expected I, but got Obj
		//IL_1858: Unknown result type (might be due to invalid IL or missing references)
		//IL_185d: Expected Obj, but got Unknown
		//IL_1893: Expected VT, but got I4
		//IL_189e: Invalid comparison between F4 and I4
		//IL_17f6: Expected F4, but got I4
		//IL_2477: Expected I4, but got I8
		//IL_2491: Expected Obj, but got I4
		//IL_24bf: Expected F4, but got I4
		//IL_0e3f: Expected Obj, but got I
		//IL_0e69: Expected Obj, but got I4
		//IL_0e95: Expected I4, but got I8
		//IL_038c: Expected Obj, but got I4
		//IL_12b5: Expected Obj, but got I
		//IL_12df: Expected Obj, but got I4
		//IL_0f7d: Expected F4, but got I4
		//IL_0f92: Expected I4, but got I8
		//IL_1b0b: Expected Obj, but got I
		//IL_03d4: Expected I, but got Obj
		//IL_130c: Expected F4, but got I
		//IL_136f: Expected VT, but got I4
		//IL_1388: Expected VT, but got I4
		//IL_18cd: Expected VT, but got I4
		//IL_1fdc: Expected Obj, but got I
		//IL_2002: Expected F4, but got I4
		//IL_040c: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_045e: Expected I, but got Obj
		//IL_0794: Expected Obj, but got I
		//IL_07c3: Expected VT, but got I4
		//IL_04c0: Expected Obj, but got I4
		//IL_07fe: Expected VT, but got Ref
		//IL_081a: Expected Obj, but got I4
		//IL_0823: Expected F8, but got I4
		//IL_04eb: Expected VT, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I4
		//IL_056c: Expected I, but got Obj
		//IL_0862: Expected Obj, but got I4
		//IL_086b: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj2 = 0;
		float deltaTime = Time.deltaTime;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ReadGrips();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v9+A0]");
		object obj9 = 0;
		bool isDeviceActive = XRSettings.isDeviceActive;
		bool flag4 = !isDeviceActive;
		object obj10 = !flag4;
		bool flag8;
		bool flag7 = default;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v168+A0]");
			object obj13 = 0;
			if (obj13 != null)
			{
				Camera main = Camera.main;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v173+E4]");
				bool flag5 = (nint)0 == 0;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = main != null;
				flag7 = false;
				nint num = unchecked((nint)null);
				flag8 = flag6;
				goto IL_19f0;
			}
		}
		flag8 = false;
		goto IL_19f0;
		IL_190d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_191b;
		IL_191b:
		throw new IndexOutOfRangeException();
		IL_1446:
		int num2 = (int)(hand & 0x80000000L);
		bool flag9 = num2 == 0;
		float num4;
		float num3 = num4;
		double num6 = default;
		double num5 = num6;
		float num8;
		float num7 = num8;
		double num10;
		float num9 = (float)num10;
		float num12;
		float num11 = num12;
		float num14;
		float num13 = num14;
		Vector3 target = (Vector3)flag7;
		int num16;
		int num15 = num16;
		if (flag9)
		{
			goto IL_214b;
		}
		goto IL_2183;
		IL_1d80:
		object obj17;
		bool flag10 = obj17 == null;
		object obj18 = !flag10;
		double num17 = 1.0;
		double num19;
		if (obj18 == null)
		{
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ X0_v102+E4]");
			bool flag11 = (nint)0 == 0;
			object obj20 = !flag11;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num18 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAB4]");
			double num20 = num18 + 0.0;
			double num21 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADB0]");
			double num22 = num21 / 0.0;
			bool flag12 = num22 < 0.0;
			double num23 = 0.0;
			if (!flag12)
			{
				bool flag13 = !(num22 > 1.0);
				num23 = num22;
				if (!flag13)
				{
					num23 = 1.0;
				}
			}
			double num24 = num23 + num23;
			double num25 = num23 * num23;
			double num26 = 3.0 - num24;
			double num27 = num25 * num26;
			bool flag14 = num27 < 0.0;
			double num28 = 0.0;
			if (!flag14)
			{
				bool flag15 = !(num27 > 1.0);
				num28 = num27;
				if (!flag15)
				{
					num28 = 1.0;
				}
			}
			double num29 = 1.0 - num19;
			double num30 = num29 * num28;
			num17 = num19 + num30;
		}
		bool flag16 = num19 < 0.0;
		double num31 = 0.0;
		if (!flag16)
		{
			bool flag17 = !(num19 > 1.0);
			num31 = num19;
			if (!flag17)
			{
				num31 = 1.0;
			}
		}
		object obj21;
		double num32 = (double)obj21 * num31;
		object obj23;
		object obj24 = default;
		object obj22 = obj23 * obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		double num33 = (double)from + num32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlideOrb)+2C]");
		object obj25 = 0 + obj22;
		double num35;
		double num34 = num35 - num33;
		double num36 = num6 - (double)obj25;
		double num37 = num34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		double num38 = num37 * 0.0;
		double num39 = num36 * num39;
		double num40 = num38 * num38;
		double num41 = num39 * num39;
		double num42 = num40 + num41;
		float num44 = default;
		double num43 = (double)num44 + num42;
		double num45 = (double)lean * (double)lean;
		if (num43 > num45)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj26 = 0;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X0_v96+E4]");
			bool flag18 = (nint)0 == 0;
			object obj28 = !flag18;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num45 = num39 / num45;
			object obj29 = default;
			num39 = num45 * (double)obj29;
		}
		num16 = hand;
		bool flag20;
		bool flag19 = !flag20;
		object obj30 = !flag19;
		flag7 = flag8;
		double num47;
		float num48;
		object obj31;
		double num46 = default;
		if (obj30 == null)
		{
			hand = -1;
			snapped = false;
			if (~(snapped ? 1u : 0u) == 0)
			{
				Action<int> dropped = Dropped;
				if (Dropped != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1915 @ X8_v97 (System.Action`1<System.Int32>)+28]");
					flag7 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1915 @ X8_v97 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
					num16 = hand;
					goto IL_2465;
				}
			}
			obj31 = obj23;
			num10 = num39;
			num46 = num44;
			num47 = 11.0;
			num48 = 0f;
			flag7 = flag8;
			num16 = -1;
			goto IL_1c14;
		}
		goto IL_2465;
		IL_2014:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		num14 = 0f;
		float num50;
		float num49 = num50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		bool flag21 = !(num49 > 0f);
		Vector3 vector;
		num16 = (int)vector;
		if (!flag21)
		{
			float num51 = num50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			float num52 = num51 * 0f;
			float num53 = num52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			num50 = num53 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
			Buzz(num50, deltaTime);
			num14 = deltaTime;
			num16 = (int)vector;
		}
		goto IL_1446;
		IL_2183:
		object obj33;
		object obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X8_v50+A0]");
		object obj34 = 0;
		num48 = (float)obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v51+4]");
		num50 = 0f;
		num3 = num4;
		num5 = num6;
		num7 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v51+4]");
		num9 = 0f;
		num11 = num12;
		num13 = num14;
		target = (Vector3)flag7;
		num15 = num16;
		goto IL_214b;
		IL_2465:
		int num54 = (int)(num16 & 0x80000000L);
		bool flag22 = num54 == 0;
		object obj35 = !flag22;
		obj31 = obj23;
		num10 = num39;
		num46 = num44;
		num47 = 11.0;
		num48 = 0f;
		object obj36;
		if (obj35 == null)
		{
			num47 = ((obj17 != null) ? 26.0 : 20.0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAF8]");
			obj36 = 0;
			obj31 = obj23;
			num10 = num39;
			num46 = 20.0;
			num48 = 0f;
			num45 = 26.0;
		}
		goto IL_1c14;
		IL_20e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj37 = 0;
		double num56;
		double num55 = num56 / 10.0;
		object obj38 = obj37;
		ticked = (float)num55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X0_v63+E4]");
		bool flag23 = (nint)0 == 0;
		object obj39 = !flag23;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = tickSound != null;
		bool flag25 = !flag24;
		double num57;
		num12 = (float)num57;
		vector = (Vector3)0;
		if (flag25)
		{
			goto IL_138d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj41 = array + 32;
			obj41 = tickSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj42 = 0;
				object obj43 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1997 @ X0_v77+E4]");
				bool flag26 = (nint)0 == 0;
				object obj44 = !flag26;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
				num8 = 0f;
				float num58 = ticked;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				float num59 = num58 * 0f;
				double num60 = (double)num59 + 0.75;
				double num61 = num59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A860]");
				num6 = num61 + 0.0;
				Sfx.Play(array, (Vector3)0, (float)num55, 10f, (float)num57);
				num4 = (float)num60;
				num12 = (float)num57;
				vector = (Vector3)0;
				goto IL_138d;
			}
		}
		goto IL_190d;
		IL_1db5:
		bool flag27;
		Snap(flag27);
		double num62;
		num6 = num62;
		double num63;
		num39 = num63;
		goto IL_1d80;
		IL_1b30:
		num16 = hand;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB48]");
		obj36 = 0;
		int num64 = (int)(hand & 0x80000000L);
		bool flag28 = num64 == 0;
		object obj45 = !flag28;
		if (obj45 == null)
		{
			if (hand == 2)
			{
				if (flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
					object obj46 = 0;
					object obj47 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v120+A0]");
					object obj48 = 0;
					object obj49 = obj48;
					if (obj48 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v122+1C0]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v122+1C0]");
							bool isPressed = ((ButtonControl)0).isPressed;
							flag20 = isPressed;
							goto IL_1be3;
						}
					}
					goto IL_190d;
				}
				flag20 = false;
			}
			else
			{
				object obj50 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v106+E4]");
				bool flag29 = (nint)0 == 0;
				object obj51 = !flag29;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj50 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v106+A0]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v112+18]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v112+18]");
				if ((nint)0 == 0)
				{
					goto IL_190d;
				}
				int num65 = hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v113+18]");
				bool flag30 = (nint)num65 < (nint)0;
				object obj54 = !flag30;
				if (obj54 != null)
				{
					goto IL_191b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v112+18]");
				object obj55 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v114+20]");
				bool flag31 = (nint)0 == 0;
				bool flag32 = !flag31;
				flag20 = flag32;
			}
			goto IL_1be3;
		}
		object obj56 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v79+A0]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v80+4]");
		num45 = 0.0;
		num48 = (float)obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v80+4]");
		num10 = 0.0;
		num17 = 0.0;
		num47 = 11.0;
		goto IL_1c14;
		IL_209b:
		double num66 = num56 + num57;
		object obj58 = num56 & 1;
		bool flag33 = obj58 == null;
		object obj59 = !flag33;
		if (obj59 != null)
		{
			num56 = num66;
		}
		goto IL_20e5;
		IL_19f0:
		int num67 = (int)(hand & 0x80000000L);
		bool flag34 = num67 == 0;
		num35 = deltaTime;
		if (!flag34)
		{
			bool flag35 = (byte)(~(Locked ? 1u : 0u)) != 0;
			object obj60 = !flag35;
			num35 = deltaTime;
			if (obj60 == null)
			{
				num35 = popT;
				if (popT < 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj61 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
					object obj62 = 0;
					object obj63 = obj9 + 56;
					object obj64 = obj9 + 48;
					int num68 = 0;
					object obj93 = default;
					Collider collider = default;
					object obj97 = default;
					while (true)
					{
						object obj65 = obj61;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v119+E4]");
						bool flag36 = (nint)0 == 0;
						object obj66 = !flag36;
						if (obj66 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag37 = (UnityEngine.Object)obj9 != null;
						bool flag38 = !flag37;
						double num69 = num39;
						double num70 = num46;
						double num71 = num35;
						bool flag39 = false;
						if (!flag38)
						{
							object obj68;
							if (num68 != 0)
							{
								bool flag40 = obj9 == null;
								object obj67 = !flag40;
								obj68 = obj63;
								if (obj67 == null)
								{
									break;
								}
							}
							else
							{
								bool flag41 = obj9 == null;
								obj68 = obj64;
								if (flag41)
								{
									break;
								}
							}
							object obj69 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v146+E4]");
							bool flag42 = (nint)0 == 0;
							object obj70 = !flag42;
							if (obj70 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj69 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v146+A0]");
							object obj71 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v151+20]");
							object obj72 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v151+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							int num72 = num68;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v152+18]");
							bool flag43 = (nint)num72 < (nint)0;
							object obj73 = !flag43;
							if (obj73 != null)
							{
								goto IL_191b;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v151+20]");
							object obj74 = (nint)0 + (nint)num68;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v153+20]");
							bool flag44 = (nint)0 == 0;
							flag39 = false;
							nint num = unchecked((nint)null);
							if (!flag44)
							{
								object obj75 = obj61;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X0_v148+E4]");
								bool flag45 = (nint)0 == 0;
								object obj76 = !flag45;
								if (obj76 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag46 = (UnityEngine.Object)obj68 != null;
								bool flag47 = !flag46;
								flag39 = false;
								num = unchecked((nint)null);
								if (!flag47)
								{
									object obj77 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1814 @ X0_v152+E4]");
									bool flag48 = (nint)0 == 0;
									object obj78 = !flag48;
									if (obj78 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag49 = GillaOneArm.Resting(num68);
									bool flag50 = !flag49;
									object obj79 = !flag50;
									flag39 = false;
									num = unchecked((nint)null);
									if (obj79 == null)
									{
										if (obj68 == null)
										{
											break;
										}
										Vector3 position2 = ((Transform)obj68).position;
										object obj80 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X0_v158+E4]");
										bool flag51 = (nint)0 == 0;
										object obj81 = !flag51;
										if (obj81 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										SlideOrb slideOrb = Nearest((Vector3)num68, 0);
										object obj82 = obj61;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v159+E4]");
										bool flag52 = (nint)0 == 0;
										object obj83 = !flag52;
										if (obj83 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag53 = slideOrb == this;
										bool flag54 = !flag53;
										object obj84 = !flag54;
										flag39 = false;
										num = (nint)this;
										if (obj84 != null)
										{
											Grab(num68);
											num69 = num39;
											num70 = num46;
											num71 = num35;
											flag39 = false;
											goto IL_05c8;
										}
									}
								}
							}
							num68++;
							bool flag55 = num68 != 2;
							num69 = num39;
							num70 = num46;
							num71 = num35;
							flag7 = flag39;
							if (flag55)
							{
								continue;
							}
						}
						goto IL_05c8;
						IL_05c8:
						bool flag56 = hand < 0;
						int num73 = hand ^ hand;
						int num74 = hand & num73;
						bool flag57 = num74 < 0;
						bool flag58 = flag56 == flag57;
						object obj85 = !flag58;
						object obj86 = flag8 & obj85;
						bool flag59 = (nint)obj86 != 1;
						num39 = num69;
						num46 = num70;
						num35 = num71;
						flag7 = flag39;
						if (!flag59)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
							object obj87 = 0;
							object obj88 = obj87;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X8_v134+A0]");
							object obj89 = 0;
							object obj90 = obj89;
							if (obj89 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v136+1C0]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v136+1C0]");
							bool wasPressedThisFrame = ((ButtonControl)0).wasPressedThisFrame;
							bool flag60 = !wasPressedThisFrame;
							num39 = num69;
							num46 = num70;
							num35 = num71;
							flag7 = flag39;
							if (!flag60)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA80]");
								object obj91 = 0;
								flag7 = (byte)(int)obj91 != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
								object obj92 = obj93 & 1;
								bool flag61 = obj92 == null;
								num39 = num69;
								num46 = num70;
								num35 = num71;
								if (!flag61)
								{
									Camera main2 = Camera.main;
									object obj94 = obj87;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ X8_v141+A0]");
									object obj95 = 0;
									object obj96 = obj95;
									if (obj95 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v143+188]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v143+188]");
									Vector2 vector2 = ((InputControl<Vector2>)0).ReadValue();
									if ((object)main2 == null)
									{
										break;
									}
									Ray ray = main2.ScreenPointToRay((Vector3)0);
									if ((object)collider == null)
									{
										break;
									}
									bool flag62 = collider.Raycast((Ray)(&obj97), out var hitInfo, 6f);
									bool flag63 = !flag62;
									object obj98 = 0;
									num39 = 0.0;
									num46 = num70;
									num35 = 6.0;
									flag7 = (byte)(&hitInfo) != 0;
									if (!flag63)
									{
										Grab(2);
										obj98 = 0;
										num39 = 0.0;
										num46 = num70;
										num35 = 6.0;
										flag7 = (byte)(&hitInfo) != 0;
									}
								}
							}
						}
						goto IL_1b30;
					}
					goto IL_190d;
				}
			}
		}
		goto IL_1b30;
		IL_138d:
		float num75 = ticked;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num76 = num75 * 0f;
		float num77 = num76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		float amplitude = num77 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		Buzz(amplitude, 0f);
		num50 = v;
		flag7 = false;
		goto IL_2014;
		IL_1be3:
		Vector3 vector3 = HandAt((Player)obj9, flag8);
		if ((object)frame == null)
		{
			goto IL_190d;
		}
		obj21 = to - from;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlideOrb)+38]");
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlideOrb)+2C]");
		obj23 = num78 - 0;
		Vector3 vector4 = frame.InverseTransformPoint((Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
		num19 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj99 = default;
		double num79 = num31 * (double)obj99;
		object obj101 = default;
		object obj100 = obj23 * obj101;
		double num80 = num79 + (double)obj100;
		object obj102 = default;
		double num81 = (double)obj23 * (double)obj102;
		double num82 = num81 + num80;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		double num83 = num82 / num81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
		bool flag65;
		object obj109;
		if (num83 < 0.0)
		{
			obj17 = this + 176;
			bool flag64 = obj17 == null;
			flag65 = flag64;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
			num81 = 0.0;
			obj17 = this + 176;
			double num84 = num83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
			double num85 = num84 - 0.0;
			bool flag66 = num85 < 0.0;
			bool flag67 = num85 == 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
			object obj103 = num83 ^ 0;
			object obj104 = num83 ^ num85;
			object obj105 = obj103 & obj104;
			bool flag68 = (nint)obj105 < 0;
			bool flag69 = flag66 == flag68;
			object obj106 = !flag67;
			object obj107 = flag69 & obj106;
			object obj108 = ~obj107;
			if (obj108 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
				num19 = 0.0;
			}
			else
			{
				num19 = num83;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			obj109 = 0;
			bool flag70 = obj17 == null;
			double num86 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			double num87 = num86 - 0.0;
			bool flag71 = num87 < 0.0;
			bool flag72 = num87 == 0.0;
			double num88 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj110 = num88 ^ 0;
			object obj111 = num19 ^ num87;
			object obj112 = obj110 & obj111;
			bool flag73 = (nint)obj112 < 0;
			bool flag74 = flag71 == flag73;
			object obj113 = !flag72;
			object obj114 = flag74 & obj113;
			object obj115 = ~obj114;
			bool flag75 = obj115 == null && obj17 == null;
			flag65 = flag70;
			if (flag75)
			{
				num62 = num46;
				num63 = num39;
				flag27 = true;
				goto IL_1db5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		obj109 = 0;
		double num89 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		bool flag76 = !(num89 < 0.0);
		num6 = num46;
		flag27 = false;
		if (!flag76)
		{
			bool flag77 = !flag65;
			object obj116 = !flag77;
			num6 = num46;
			flag27 = false;
			if (obj116 == null)
			{
				num62 = num46;
				num63 = num39;
				flag27 = false;
				goto IL_1db5;
			}
		}
		goto IL_1d80;
		IL_1c14:
		object obj117 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v20+E4]");
		bool flag78 = (nint)0 == 0;
		object obj118 = !flag78;
		if (obj118 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num16 = hand;
		}
		num4 = v;
		double num90 = (double)obj36 * num47;
		double num91 = num47 * num47;
		num8 = x - (float)num17;
		double num92 = num90 * (double)v;
		double num93 = num91 * (double)num8;
		double num94 = num92 - num93;
		float num95 = deltaTime * (float)num94;
		num50 = v + num95;
		float num96 = deltaTime * num50;
		num14 = (x += num96);
		v = num50;
		int num97 = (int)(num16 & 0x80000000L);
		bool flag79 = num97 == 0;
		object obj119 = !flag79;
		if (obj119 == null)
		{
			num57 = ticked;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			num8 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			float num98 = ticked;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			bool flag80 = num98 < 0f;
			num12 = ticked;
			vector = (Vector3)num16;
			if (flag80)
			{
				goto IL_2014;
			}
			bool flag81 = num14 < 0f;
			double num99 = 0.0;
			if (!flag81)
			{
				bool flag82 = !((double)num14 > 1.0);
				num99 = num14;
				if (!flag82)
				{
					num99 = 1.0;
				}
			}
			double num100 = num99 * 10.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num101 = default;
			if (num100 < 0.0)
			{
				if (num100 == -0.5)
				{
					num57 = -1.0;
					num56 = num101;
					goto IL_209b;
				}
				num56 = num100 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			}
			else
			{
				if (num100 == 0.5)
				{
					num57 = 1.0;
					num56 = num101;
					goto IL_209b;
				}
				num56 = num100 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			}
			goto IL_20e5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAA0]");
		num12 = 0f;
		float num102 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAA0]");
		if (num102 < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			num14 = 0f;
			x = -0.06f;
			float num103 = num50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			num50 = num103 * 0f;
			v = num50;
			goto IL_1446;
		}
		goto IL_2183;
		IL_214b:
		object obj120 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X0_v23+E4]");
		bool flag83 = (nint)0 == 0;
		object obj121 = !flag83;
		if (obj121 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Spring3(ref *(Vector3*)(this + 132), ref *(Vector3*)(this + 144), target, num48, num9, num44);
		int num104 = (int)(hand & 0x80000000L);
		bool flag84 = num104 == 0;
		object obj122 = !flag84;
		double num106;
		if (obj122 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A93C]");
			float num105 = 0f;
			if (!snapped)
			{
				num106 = 1.25;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A93C]");
				num106 = 0.0;
			}
			float num107 = 1.25f;
		}
		else
		{
			float num105 = num9;
			num106 = 1.0;
			float num107 = num48;
		}
		object obj123 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1617 @ X0_v26+E4]");
		bool flag85 = (nint)0 == 0;
		object obj124 = !flag85;
		if (obj124 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num108 = (double)swell - num106;
		float num109 = swellV;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF5C]");
		float num110 = num109 * 0f;
		double num111 = num108 * 3276013568.0;
		double num112 = (double)num110 + num111;
		float num113 = popT;
		float num114 = deltaTime * (float)num112;
		float num115 = swellV + num114;
		float num116 = deltaTime * num115;
		float num117 = swell + num116;
		swell = num117;
		swellV = num115;
		if (popT < 0f)
		{
			object obj125 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v48+E4]");
			bool flag86 = (nint)0 == 0;
			object obj126 = !flag86;
			if (obj126 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num118 = (double)appear + -1.0;
			float num119 = appearV;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD14]");
			num113 = num119 * 0f;
			double num120 = num118 * 3270639616.0;
			double num121 = (double)num113 + num120;
			float num122 = deltaTime * (float)num121;
			float num123 = appearV + num122;
			num116 = deltaTime * num123;
			float num124 = appear + num116;
			appear = num124;
			appearV = num123;
			object obj127 = 3270639616L;
		}
		else
		{
			Popping(deltaTime);
			object obj127 = 3276013568L;
		}
		if (shake > 0f)
		{
			float num125 = shake - deltaTime;
			if (num125 < 0f)
			{
				num125 = 0f;
			}
			shake = num125;
		}
		if ((int)(hand & 0x80000000L) != 0)
		{
			float time = Time.time;
			float num126 = time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
			float num127 = num126 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		}
		Transform transform2 = base.transform;
		if ((object)transform2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlideOrb)+68]");
			object obj129 = default;
			object obj128 = 0 * obj129;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			double num128 = (double)obj128 / 1.0;
			transform2.localScale = (Vector3)0;
			if (shake > 0f)
			{
				float num129 = shake * 1.1133256E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			}
			Transform transform3 = base.transform;
			if ((object)transform3 != null)
			{
				transform3.localPosition = (Vector3)0;
				ShowRing(deltaTime);
				return;
			}
		}
		goto IL_190d;
	}

	public void Pop()
	{
		//IL_003f: Expected F4, but got I
		//IL_003f: Expected F4, but got I
		popT = 0f;
		x = 0f;
		v = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		Buzz(num, 0f);
	}

	public void Reject()
	{
		//IL_0031: Expected F4, but got I
		shake = 0.45f;
		v = -2f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		Buzz(0.5f, 0f);
	}

	private void Grab(int h)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I4
		//IL_017b: Expected F4, but got I
		//IL_017b: Expected F4, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_0157: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		hand = h;
		ticked = 0f;
		double num = (double)swellV + 6.0;
		snapped = false;
		swellV = (float)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (grabSound != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			AudioClip[] array = default;
			if (array != null)
			{
				object obj5 = array + 32;
				obj5 = grabSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v20+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, (float)num, swellV, pitchMax);
					goto IL_015d;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
		goto IL_015d;
		IL_015d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		Buzz(num2, 0f);
	}

	private void Release()
	{
		//IL_0019: Expected I4, but got I8
		//IL_0076: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		int num = hand;
		hand = -1;
		snapped = false;
		if (~(snapped ? 1u : 0u) == 0)
		{
			Action<int> dropped = Dropped;
			if (Dropped != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v3 (System.Action`1<System.Int32>)+40]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v3 (System.Action`1<System.Int32>)+28]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v3 (System.Action`1<System.Int32>)+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v11 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private void Snap(bool on)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0033: Expected F4, but got I
		//IL_0033: Expected F4, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		//IL_01ba: Expected F4, but got I
		//IL_01ba: Expected F4, but got I
		//IL_01ba: Expected VT, but got I4
		snapped = on;
		if (!on)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		Buzz(num, 0f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(tickSound != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj5 = array + 32;
			obj5 = tickSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				float pitchMax = default;
				Sfx.Play(array, (Vector3)0, num2, 0f, pitchMax);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Popping(float dt)
	{
		//IL_002b: Invalid comparison between F4 and I
		//IL_00cd: Invalid comparison between F4 and I
		//IL_0186: Invalid comparison between F4 and I
		//IL_0062: Invalid comparison between F4 and I4
		//IL_0071: Expected F8, but got I4
		//IL_01c6: Expected F4, but got I
		//IL_011b: Invalid comparison between F4 and I4
		//IL_012a: Expected F8, but got I4
		float num = (popT += dt);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		double num7;
		if (num < 0f)
		{
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			float num3 = num2 / 0f;
			bool flag = num3 < 0f;
			double num4 = 0.0;
			if (!flag)
			{
				bool flag2 = !((double)num3 > 1.0);
				num4 = num3;
				if (!flag2)
				{
					num4 = 1.0;
				}
			}
			double num5 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A864]");
			double num6 = num5 * 0.0;
			num7 = num6 + 1.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE4C]");
			if (!(num < 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				if (num < 0f)
				{
					appear = 0f;
					return;
				}
				appearV = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BD98]");
				popT = 0f;
				return;
			}
			float num8 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
			float num9 = num8 + 0f;
			float num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			float num11 = num10 / 0f;
			bool flag3 = num11 < 0f;
			double num12 = 0.0;
			if (!flag3)
			{
				bool flag4 = !((double)num11 > 1.0);
				num12 = num11;
				if (!flag4)
				{
					num12 = 1.0;
				}
			}
			double num13 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
			double num14 = num13 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
			num7 = 0.0 - num14;
		}
		appear = (float)num7;
	}

	private Vector3 HandAt(Player gt, bool mouse)
	{
		//IL_02c9: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_05b3: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I
		//IL_04b9: Expected Obj, but got I
		//IL_046f: Expected VT, but got Obj
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I
		//IL_0096: Expected VT, but got I4
		//IL_04ee: Expected Obj, but got I
		//IL_04f6: Expected VT, but got Obj
		//IL_0518: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I
		//IL_0614: Expected Obj, but got I
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		//IL_06b3: Expected Obj, but got I4
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got Unknown
		//IL_019b: Unsupported input type for neg.
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b1: Unsupported input type for neg.
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01c7: Unsupported input type for neg.
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I
		Vector3 result;
		Transform transform;
		if (hand == 2 && mouse)
		{
			Camera main = Camera.main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v19+A0]");
			object obj3 = 0;
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v21+188]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v21+188]");
					Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
					if ((object)main != null)
					{
						Ray ray = main.ScreenPointToRay((Vector3)0);
						if ((object)frame != null)
						{
							Vector3 forward = frame.forward;
							if ((object)frame != null)
							{
								Vector3 position = frame.position;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								object obj5 = 0;
								result = (Vector3)obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v4 (UnityEngine.Vector3)+E4]");
								bool flag = (nint)0 == 0;
								object obj6 = !flag;
								if (obj6 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj8 = default;
								object obj7 = obj8 * obj8;
								object obj10 = default;
								object obj9 = obj10 * obj10;
								object obj11 = obj7 + obj9;
								object obj13 = default;
								object obj12 = obj13 * obj13;
								object obj14 = obj12 + obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								bool flag2 = (nint)obj14 <= 0;
								object obj15 = 0;
								object obj16 = 0;
								object obj17 = 0;
								if (!flag2)
								{
									object obj18 = 0 - obj8;
									obj17 = obj18 / obj14;
									object obj19 = 0 - obj10;
									obj16 = obj19 / obj14;
									object obj20 = 0 - obj13;
									obj15 = obj20 / obj14;
								}
								object obj22 = default;
								object obj21 = obj22 * obj17;
								object obj24 = default;
								object obj23 = obj24 * obj16;
								object obj25 = obj21 + obj23;
								object obj26 = obj8 * obj15;
								object obj27 = obj25 + obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
								object obj28 = 0;
								object obj29 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v35+A0]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
								object obj31 = obj26 * 0;
								object obj32 = obj31;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v36+4]");
								object obj33 = obj32 - 0;
								bool flag3 = (nint)obj33 < 0;
								bool flag4 = obj33 == null;
								object obj34 = obj31;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v36+4]");
								object obj35 = obj34 ^ 0;
								object obj36 = obj31 ^ obj33;
								object obj37 = obj35 & obj36;
								bool flag5 = (nint)obj37 < 0;
								bool flag6 = flag3 == flag5;
								object obj38 = !flag4;
								object obj39 = flag6 & obj38;
								object obj40 = ~obj39;
								if (obj40 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v36+4]");
									obj31 = 0;
								}
								if (0 >= (nint)obj31)
								{
									object obj41 = obj10 * obj17;
									object obj42 = obj8 * obj17;
									object obj43 = obj10 * obj16;
									object obj44 = obj13 * obj16;
									object obj45 = obj42 + obj43;
									object obj46 = obj41 + obj44;
									object obj47 = obj13 * obj15;
									object obj49 = default;
									object obj48 = obj49 * obj15;
									object obj50 = obj45 + obj47;
									object obj51 = obj46 + obj48;
									object obj52 = obj50 - obj51;
									object obj53 = obj52 / obj27;
									if ((nint)obj53 > 0)
									{
										goto IL_045c;
									}
								}
								goto IL_0423;
							}
						}
					}
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj54 = 0;
			object obj55 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v10+E4]");
			bool flag7 = (nint)0 == 0;
			object obj56 = !flag7;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = gt != null;
			bool flag9 = !flag8;
			UnityEngine.Object obj57 = null;
			if (!flag9)
			{
				object obj58;
				if (hand != 0)
				{
					if ((object)gt == null)
					{
						goto IL_0461;
					}
					obj58 = gt + 56;
				}
				else
				{
					if ((object)gt == null)
					{
						goto IL_0461;
					}
					obj58 = gt + 48;
				}
				obj57 = (UnityEngine.Object)obj58;
			}
			object obj59 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj60 = !flag10;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(obj57 != null))
			{
				goto IL_0423;
			}
			if ((object)obj57 != null)
			{
				transform = (Transform)obj57;
				goto IL_044a;
			}
		}
		goto IL_0461;
		IL_045c:
		return result;
		IL_0423:
		transform = base.transform;
		if ((object)transform != null)
		{
			goto IL_044a;
		}
		goto IL_0461;
		IL_0461:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_044a:
		result = transform.position;
		goto IL_045c;
	}

	private void Buzz(float amplitude, float seconds)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		bool flag = hand < 1;
		object obj = !flag;
		object obj2 = hand - 1;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			bool flag3 = hand == 0;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			XRNode node = ((obj6 != null) ? ((XRNode)4) : ((XRNode)5));
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			UnityEngine.XR.InputDevice inputDevice = default;
			bool flag4 = inputDevice.SendHapticImpulse(0u, amplitude, seconds);
		}
	}

	private unsafe static SlideOrb Nearest(Vector3 at, int h)
	{
		//IL_0010: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I4
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Invalid comparison between Unknown and I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected I4, but got Obj
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got I4
		//IL_067c: Expected I4, but got Obj
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Ref, but got Unknown
		//IL_069f: Expected Obj, but got I4
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between I and VT
		//IL_03fd: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I8
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I4
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Invalid comparison between Unknown and I
		//IL_02b7: Expected Obj, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0334: Expected Obj, but got I4
		//IL_0620: Expected Obj, but got I4
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		bool flag2 = (int)val == 0;
		Component component2 = default;
		Component component = component2;
		Enumerator<, > val2 = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA90]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA88]");
			object obj5 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)val).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj = 0;
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			Enumerator<, > val3 = (Enumerator<, >)2139095039;
			Component result = null;
			Enumerator<, > val5 = default;
			Enumerator<, > val4 = val5;
			val = (Enumerator<, >)2139095039;
			SlideOrb result2 = default;
			object obj35 = default;
			object obj12;
			Enumerator<, > val7 = default;
			Enumerator<, > val6;
			while (true)
			{
				int num = (int)obj4;
				bool flag3 = val2.MoveNext();
				if (flag3)
				{
					if ((object)component2 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+70]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+70]");
					if ((object)0 != (object)at)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+70]");
						object obj10 = 0 & 0x80000000L;
						if (obj10 == null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+60]");
						val = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+60]");
						bool flag4 = (nint)0 == 0;
						object obj11 = !flag4;
						if (obj11 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+A4]");
						val4 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+A4]");
						if ((nint)0 >= (nint)0)
						{
							continue;
						}
						Transform transform = component2.transform;
						bool flag5 = (object)transform == null;
						component = null;
						val2 = val5;
						obj12 = 0;
						val6 = (Enumerator<, >)(ref val2);
						num = 0;
						if (!flag5)
						{
							Vector3 position = transform.position;
							object obj13 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v40+E4]");
							bool flag6 = (nint)0 == 0;
							object obj14 = !flag6;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj15 = val4 - val7;
							object obj16 = obj8 - obj9;
							obj6 -= obj7;
							object obj17 = obj15 * obj15;
							object obj18 = obj16 * obj16;
							object obj19 = obj17 + obj18;
							object obj20 = obj6 * obj6;
							Enumerator<, > val8 = (Enumerator<, >)(obj20 + obj19);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+40]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+40]");
							bool flag7 = (nint)val8 < (nint)0;
							object obj21 = !flag7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-B8 (UnityEngine.Component)+40]");
							object obj22 = val8 - 0;
							bool flag8 = obj22 == null;
							object obj23 = ~obj21;
							Enumerator<, > val9 = (Enumerator<, >)(obj23 | flag8);
							object obj24 = val8 - val3;
							bool flag9 = (nint)obj24 < 0;
							object obj25 = val9 & flag9;
							bool flag10 = obj25 == null;
							object obj26 = !flag10;
							object obj27 = ~obj26;
							if (obj27 == null)
							{
								val3 = val8;
							}
							object obj28 = !flag10;
							object obj29 = ~obj28;
							if (obj29 == null)
							{
								result = component2;
							}
							val4 = val8;
							val = val9;
							continue;
						}
						goto IL_04b1;
					}
				}
				bool flag11 = flag3;
				component = null;
				val2 = val5;
				obj12 = 0;
				val6 = (Enumerator<, >)(ref val2);
				object obj30 = 0;
				goto IL_0674;
				IL_0674:
				num = (int)obj5;
				((Enumerator<, >*)val6)->Dispose();
				bool flag12 = obj30 == null;
				object obj31 = !flag12;
				obj7 = obj6;
				obj9 = obj8;
				val7 = val4;
				if (obj31 == null)
				{
					bool flag13 = (object)component == null;
					object obj32 = !flag13;
					obj7 = obj6;
					obj9 = obj8;
					val7 = val4;
					OutOfMemoryException ex = (OutOfMemoryException)val6;
					if (obj32 == null)
					{
						bool flag14 = !flag11;
						object obj33 = !flag14;
						object obj34 = ~obj33;
						if (obj34 == null)
						{
							return null;
						}
						return (SlideOrb)result;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				obj6 = obj7;
				obj8 = obj9;
				val4 = val7;
				goto IL_04b1;
				IL_04b1:
				NullReferenceException ex2 = new NullReferenceException();
				if (num == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					component = (Component)1;
					obj30 = obj12;
					val = (Enumerator<, >)1;
				}
				else
				{
					if (num != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0694");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj30 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = obj35;
				}
				flag11 = false;
				goto IL_0674;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj7 = obj6;
			obj9 = obj8;
			component = null;
			val2 = val5;
			obj12 = 0;
			val7 = val4;
			val6 = (Enumerator<, >)(ref val2);
		}
		throw new NullReferenceException();
	}

	private unsafe static void ReadGrips()
	{
		//IL_0010: Expected Obj, but got I
		//IL_054c: Expected Obj, but got I4
		//IL_07da: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_056a: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I
		//IL_0588: Expected F4, but got I4
		//IL_0591: Expected Obj, but got I4
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07b3: Expected Obj, but got I4
		//IL_05cd: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I
		//IL_05fb: Expected Obj, but got I
		//IL_0620: Expected VT, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I
		//IL_064e: Expected VT, but got I
		//IL_0667: Expected VT, but got I
		//IL_0683: Expected Obj, but got I4
		//IL_068b: Expected Obj, but got Ref
		//IL_01f5: Expected Obj, but got I4
		//IL_012d: Invalid comparison between F4 and I4
		//IL_013c: Invalid comparison between F4 and I4
		//IL_0158: Expected Obj, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got Ref
		//IL_0232: Expected Obj, but got I4
		//IL_06ce: Expected Obj, but got I
		//IL_06de: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_0713: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_0748: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_045f: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I4
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		object obj4 = 0;
		int frameCount = Time.frameCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+10]");
		if ((nint)0 == frameCount)
		{
			return;
		}
		int frameCount2 = Time.frameCount;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v7+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
		object obj8 = 0;
		float value = 0f;
		object obj9 = 32;
		UnityEngine.XR.InputDevice inputDevice = default;
		while (true)
		{
			object obj10 = obj9 - 32;
			object obj11 = obj9 - 32;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			object obj13 = ~obj12;
			XRNode node = ((obj13 != null) ? ((XRNode)4) : ((XRNode)5));
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v14+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v11+18]");
			object obj17 = 0;
			bool isValid = inputDevice.isValid;
			bool flag5 = !isValid;
			InputFeatureUsage<float> inputFeatureUsage = (InputFeatureUsage<float>)0;
			object obj28;
			if (!flag5)
			{
				object obj18 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v35+E4]");
				bool flag6 = (nint)0 == 0;
				object obj19 = !flag6;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v35+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v28+80]");
				inputFeatureUsage = (InputFeatureUsage<float>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v28+80]");
				bool flag7 = inputDevice.TryGetFeatureValue((InputFeatureUsage<float>)0, out value);
				bool flag8 = !flag7;
				object obj21 = 0;
				object obj22 = (object)(&value);
				if (!flag8)
				{
					float num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					float num2 = num - 0f;
					bool flag9 = num2 < 0f;
					bool flag10 = num2 == 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					object obj23 = (nint)0 ^ (nint)0;
					object obj24 = 0 ^ num2;
					object obj25 = obj23 & obj24;
					bool flag11 = (nint)obj25 < 0;
					bool flag12 = flag9 == flag11;
					object obj26 = !flag10;
					object obj27 = flag12 & obj26;
					obj21 = 0;
					obj22 = (object)(&value);
					obj28 = obj27;
					goto IL_0699;
				}
			}
			obj28 = 0;
			goto IL_0699;
			IL_03c3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X24_v7+18]");
			bool flag13 = (nint)obj10 < 0;
			object obj29 = !flag13;
			if (obj29 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v25+E4]");
			bool flag14 = (nint)0 == 0;
			object obj30 = !flag14;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v25+A0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v15+18]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v15+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v17+18]");
				bool flag15 = (nint)obj10 < 0;
				object obj34 = !flag15;
				if (obj34 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v15+8]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v15+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v16+18]");
					bool flag16 = (nint)obj10 < 0;
					object obj36 = !flag16;
					if (obj36 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v17+v195 @ X19_v7]");
					_ = 0;
					obj9++;
					if ((nint)obj9 == 34)
					{
						return;
					}
					continue;
				}
			}
			goto IL_050d;
			IL_050d:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0699:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v11+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X24_v4+18]");
				bool flag17 = (nint)obj10 < 0;
				object obj37 = !flag17;
				if (obj37 != null)
				{
					break;
				}
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v25+E4]");
				bool flag18 = (nint)0 == 0;
				object obj38 = !flag18;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj31 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v25+A0]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v20+18]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v20+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X9_v10+18]");
					bool flag19 = (nint)obj10 < 0;
					object obj41 = !flag19;
					if (obj41 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v20+20]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X9_v10+v195 @ X19_v7]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v25+E4]");
						bool flag20 = (nint)0 == 0;
						object obj43 = !flag20;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj31 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v25+A0]");
							obj39 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v20+8]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v20+8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v21+18]");
							bool flag21 = (nint)obj10 < 0;
							object obj45 = !flag21;
							if (obj45 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v21+v195 @ X19_v7]");
							bool flag22 = (nint)0 == 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v20+20]");
							bool flag23 = (nint)0 == 0;
							object obj46 = !flag23;
							bool flag24 = flag22;
							if (obj46 != null)
							{
								goto IL_03c3;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v20+20]");
						bool flag25 = (nint)0 == 0;
						bool flag24 = false;
						if (!flag25)
						{
							goto IL_03c3;
						}
					}
				}
			}
			goto IL_050d;
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe static void Spring(ref float p, ref float vel, float target, float w, float z, float dt)
	{
		//IL_00b2: Expected Ref, but got F4
		//IL_00ce: Expected Ref, but got F4
		float num = z * -2f;
		float num2 = p - target;
		float num3 = num * w;
		float num4 = w * w;
		float num5 = num3 * vel;
		float num6 = num4 * num2;
		float num7 = num5 - num6;
		float num8 = num7 * dt;
		float num9 = vel + num8;
		float num10 = num9 * dt;
		ref float reference = ref *(float*)num9;
		float num11 = p + num10;
		ref float reference2 = ref *(float*)num11;
	}

	private unsafe static void Spring3(ref Vector3 p, ref Vector3 vel, Vector3 target, float w, float z, float dt)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 * obj2;
		object obj3 = default;
		double num = (double)obj3 * -2.0;
		object obj4 = p - w;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (UnityEngine.Vector3&)+8]");
		float num2 = 0f - dt;
		double num3 = num * (double)obj2;
		object obj6 = default;
		object obj5 = obj4 * obj6;
		float num4 = (float)obj * num2;
		object obj8 = default;
		object obj7 = vel * obj8;
		double num5 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vel @ X1 (UnityEngine.Vector3&)+8]");
		double num6 = num5 * 0.0;
		object obj9 = obj7 - obj5;
		double num7 = num6 - (double)num4;
		object obj11 = default;
		object obj10 = obj9 * obj11;
		object obj12 = default;
		double num8 = num7 * (double)obj12;
		object obj13 = vel + obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vel @ X1 (UnityEngine.Vector3&)+8]");
		double num9 = 0.0 + num8;
		ref Vector3 reference = ref *(Vector3*)obj13;
		object obj14 = obj13 * obj11;
		double num10 = num9 * (double)obj12;
		object obj15 = p + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (UnityEngine.Vector3&)+8]");
		double num11 = 0.0 + num10;
		ref Vector3 reference2 = ref *(Vector3*)obj15;
	}

	private static float Smooth(float a, float b, float t)
	{
		//IL_0036: Invalid comparison between F4 and I4
		//IL_0045: Expected F8, but got I4
		float num = t - a;
		float num2 = b - a;
		float num3 = num / num2;
		bool flag = num3 < 0f;
		double num4 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)num3 > 1.0);
			num4 = num3;
			if (!flag2)
			{
				num4 = 1.0;
			}
		}
		double num5 = num4 + num4;
		double num6 = num4 * num4;
		double num7 = 3.0 - num5;
		return (float)num6 * (float)num7;
	}

	private void MakeRing()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected Obj, but got Unknown
		//IL_0a32: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I4
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected Obj, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b98: Expected F8, but got I4
		//IL_0aa9: Invalid comparison between F8 and I4
		//IL_0ab8: Expected F8, but got I4
		//IL_0a78: Expected Obj, but got I
		//IL_0a96: Expected Obj, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02ea: Expected VT, but got I
		//IL_02f3: Expected F8, but got I4
		//IL_0308: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0383: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I
		//IL_0419: Expected VT, but got I
		//IL_0422: Expected F8, but got I4
		//IL_0440: Invalid comparison between F8 and I4
		//IL_03a7: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I4
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_0500: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got I
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_05b6: Expected Obj, but got I4
		//IL_05cc: Expected Obj, but got I
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected Obj, but got Unknown
		//IL_06e8: Expected Obj, but got I4
		//IL_06fe: Expected Obj, but got I
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_0782: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected Obj, but got Unknown
		//IL_08ad: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_0912: Expected Obj, but got I
		//IL_093c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA68]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj6);
		Transform transform = gameObject.transform;
		Transform transform2 = base.transform;
		Transform parent = transform2.parent;
		transform.SetParent(parent, worldPositionStays: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA70]");
		object obj8 = 0;
		mesh.name = (string)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
		object obj10 = 0;
		List<Vector3> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list2 = default;
		list2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BA8]");
		object obj14 = 0;
		object obj15 = 0;
		object obj16 = 0;
		object obj25 = default;
		object obj27 = default;
		IEnumerable<int> collection = default;
		IEnumerable<int> collection2 = default;
		do
		{
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			object obj18 = obj17 + 0;
			object obj19 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
			object obj20 = obj19 + 0;
			double num = (double)obj18 / 10.0;
			double num2 = (double)obj20 / 10.0;
			double num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
			double num4 = num3 * 0.0;
			double num5 = num4 + num4;
			double num6 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
			double num7 = num6 * 0.0;
			double num8 = num7 + num7;
			double num9 = num8 - num5;
			double num10 = 10.0;
			double num11 = 0.0;
			do
			{
				bool flag2 = num11 < 0.0;
				double num12 = 0.0;
				if (!flag2)
				{
					bool flag3 = !(num11 > 1.0);
					num12 = num11;
					if (!flag3)
					{
						num12 = 1.0;
					}
				}
				double num13 = num9 * num12;
				double num14 = num5 + num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj21 = 0;
				object obj22 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj23 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE68]");
				object obj24 = obj25 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE68]");
				object obj26 = obj27 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v24+18]");
				bool flag4 = num15 < 0;
				object obj28 = !flag4;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj29 = (nint)0 * (nint)12;
					object obj30 = obj21 + obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj31 = (nint)0 + (nint)1;
					_ = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v5+20]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v45+A8]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v46+70]");
					list.AddWithResize((Vector3)0);
					num10 = 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj34 = 0;
				object obj35 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj36 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA0C]");
				object obj37 = obj25 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA0C]");
				object obj38 = obj27 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v26+18]");
				bool flag5 = num16 < 0;
				object obj39 = !flag5;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj40 = (nint)0 * (nint)12;
					object obj41 = obj34 + obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj42 = (nint)0 + (nint)1;
					_ = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v7+20]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v42+A8]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v43+70]");
					list.AddWithResize((Vector3)0);
					num10 = 0.0;
				}
				num11++;
			}
			while (num11 != 5.0);
			object obj45 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj46 = 0 + obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj47 = 0 + obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
						bool flag6 = (nint)0 < (nint)2;
						object obj48 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
						object obj49 = -2;
						bool flag7 = obj49 == null;
						object obj50 = obj47 + 1;
						object obj51 = ~obj48;
						object obj52 = obj51 | flag7;
						if (obj52 == null)
						{
							object obj53 = obj47 + 3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							if ((nint)0 != 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
								bool flag8 = (nint)0 < (nint)4;
								object obj54 = !flag8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
								object obj55 = -4;
								bool flag9 = obj55 == null;
								object obj56 = ~obj54;
								object obj57 = obj56 | flag9;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v31 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
									if ((nint)0 != 5)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										object obj58 = 0 + obj45;
										object obj59 = obj58 + 2;
										list2.AddRange(collection);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
											if ((nint)0 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
												bool flag10 = (nint)0 < (nint)2;
												object obj60 = !flag10;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
												object obj61 = -2;
												bool flag11 = obj61 == null;
												object obj62 = ~obj60;
												object obj63 = obj62 | flag11;
												if (obj63 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
													if ((nint)0 != 3)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
														bool flag12 = (nint)0 < (nint)4;
														object obj64 = !flag12;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
														object obj65 = -4;
														bool flag13 = obj65 == null;
														object obj66 = ~obj64;
														object obj67 = obj66 | flag13;
														if (obj67 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
															if ((nint)0 != 5)
															{
																obj16 = obj14;
																list2.AddRange(collection2);
																obj45 += 2;
																if ((nint)obj45 == 8)
																{
																	break;
																}
																continue;
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
			obj15++;
		}
		while ((nint)obj15 != 10);
		mesh.SetVertices(list);
		mesh.SetTriangles(list2, 0);
		mesh.RecalculateBounds();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		MeshFilter meshFilter = default;
		meshFilter.sharedMesh = mesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj71 = 0;
		object obj72 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v41+E4]");
		bool flag14 = (nint)0 == 0;
		object obj73 = !flag14;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj74 = default;
		bool flag15 = obj74 != null;
		bool flag16 = !flag15;
		Material sharedMaterial = null;
		if (!flag16)
		{
			Material sharedMaterial2 = ((Renderer)obj74).sharedMaterial;
			sharedMaterial = sharedMaterial2;
		}
		Renderer renderer = default;
		renderer.sharedMaterial = sharedMaterial;
		renderer.shadowCastingMode = (ShadowCastingMode)0;
		Transform transform3 = gameObject.transform;
		obj3 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void ShowRing(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0070: Expected I4, but got I8
		//IL_0088: Expected F8, but got I4
		//IL_043b: Invalid comparison between F8 and I4
		//IL_044e: Expected Obj, but got F8
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0483: Expected Obj, but got I4
		//IL_00a1: Invalid comparison between F4 and I4
		//IL_00b3: Expected F8, but got I4
		//IL_04ce: Expected Obj, but got I4
		//IL_04e6: Invalid comparison between F4 and I4
		//IL_04f7: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_00e0: Expected F8, but got I4
		//IL_018f: Invalid comparison between F4 and I4
		//IL_019e: Invalid comparison between F4 and I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got F4
		//IL_01ff: Expected Obj, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected I4, but got Unknown
		//IL_022b: Invalid comparison between F4 and I
		//IL_023c: Expected Obj, but got I4
		//IL_025e: Invalid comparison between F4 and I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0100: Invalid comparison between F4 and I
		//IL_0112: Expected F8, but got I4
		//IL_02b9: Expected VT, but got I4
		//IL_02e9: Expected VT, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_03b2: Expected VT, but got I4
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
		bool flag2 = ring == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		int num = (int)(hand & 0x80000000L);
		bool flag4 = num == 0;
		double num2 = 0.0;
		if (!flag4)
		{
			bool flag5 = !(popT < 0f);
			num2 = 0.0;
			if (!flag5)
			{
				bool flag6 = (byte)(~(Locked ? 1u : 0u)) != 0;
				object obj5 = !flag6;
				num2 = 0.0;
				if (obj5 == null)
				{
					float num3 = x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
					bool flag7 = !(num3 < 0f);
					num2 = 0.0;
					if (!flag7)
					{
						num2 = 1.0;
					}
				}
			}
		}
		double num4 = num2 - (double)ringShow;
		float num5 = dt * 4f;
		float num6 = dt * 4f;
		float num7 = 0f - num6;
		bool flag8 = num4 < 0.0;
		object obj6 = num4 ^ num4;
		object obj7 = num4 & obj6;
		bool flag9 = (nint)obj7 < 0;
		bool flag10 = flag8 == flag9;
		object obj8 = !flag10;
		object obj9 = ~obj8;
		float num8 = ((obj9 != null) ? num5 : num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num9 = ringShow + num8;
		bool flag11 = num7 < num5;
		object obj10 = !flag11;
		float num10 = num7 - num5;
		bool flag12 = num10 == 0f;
		object obj11 = !flag12;
		object obj12 = obj10 & obj11;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			num2 = num9;
		}
		ringShow = (float)num2;
		GameObject gameObject = ring.gameObject;
		float num11 = ringShow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		float num12 = num11 - 0f;
		bool flag13 = num12 < 0f;
		bool flag14 = num12 == 0f;
		float num13 = ringShow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		object obj14 = num13 ^ 0;
		object obj15 = ringShow ^ num12;
		object obj16 = obj14 & obj15;
		bool flag15 = (nint)obj16 < 0;
		bool flag16 = flag13 == flag15;
		object obj17 = !flag14;
		bool active = (byte)((flag16 & obj17) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		float num14 = ringShow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		bool flag17 = num14 < 0f;
		object obj18 = !flag17;
		float num15 = ringShow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		float num16 = num15 - 0f;
		bool flag18 = num16 == 0f;
		object obj19 = ~obj18;
		object obj20 = obj19 | flag18;
		if (obj20 == null)
		{
			Transform transform = base.transform;
			Vector3 localPosition = transform.localPosition;
			ring.localPosition = (Vector3)0;
			float time = Time.time;
			Vector3 euler = default;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			ring.localRotation = (Quaternion)0;
			Vector3 vector = rest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlideOrb)+68]");
			object obj21 = vector - 0;
			bool flag19 = (nint)obj21 < 0;
			bool flag20 = obj21 == null;
			Vector3 vector2 = rest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlideOrb)+68]");
			object obj22 = vector2 ^ 0;
			object obj23 = rest ^ obj21;
			object obj24 = obj22 & obj23;
			bool flag21 = (nint)obj24 < 0;
			bool flag22 = flag19 == flag21;
			object obj25 = !flag20;
			object obj26 = flag22 & obj25;
			object obj27 = ~obj26;
			if (obj27 == null)
			{
			}
			float time2 = Time.time;
			float num17 = time2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
			float num18 = num17 * 0f;
			float num19 = num18 + 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			ring.localScale = (Vector3)0;
		}
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
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
		if (ring != null)
		{
			GameObject obj4 = ring.gameObject;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj4);
		}
	}

	public SlideOrb()
	{
		//IL_000f: Expected I4, but got I8
		//IL_002c: Expected F4, but got I
		//IL_003e: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5B8]");
		reach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCD0]");
		popT = 0f;
		ringShow = 1f;
		base._002Ector();
	}

	static SlideOrb()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = list;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)8;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v9+A0]");
		object obj11 = 0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v11+A0]");
		object obj13 = (nint)0 + (nint)24;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v14+A0]");
		object obj16 = (nint)0 + (nint)32;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
