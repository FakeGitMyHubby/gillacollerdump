using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.XR;

public class GillaMinePick : NetworkBehaviour
{
	public GillaItem item;

	public int hitsPerOre;

	public Vector3 headMiddle;

	public Vector3 tip;

	public Vector3 edge;

	public Vector3 balance;

	public float strikeSpeed;

	public float clangSpeed;

	public float headReach;

	public bool sparks;

	public AudioClip[] stoneSounds;

	public AudioClip[] metalSounds;

	public float loudness;

	private const float SwingLasts = default(float);

	private const float MostSpeed = default(float);

	private Vector3 wasTip;

	private Vector3 wasEdge;

	private Vector3 swung;

	private float swungAt;

	private float clangAt;

	private bool started;

	private readonly GillaNetGuard.Holder holder;

	private const float ClangSlack = default(float);

	private const float ClangBudget = default(float);

	public int MiningDamage
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01b4: Expected Obj, but got I4
			//IL_023e: Expected Obj, but got I
			//IL_018a: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got I4
			//IL_0064: Expected Obj, but got I
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			//IL_01d2: Expected Obj, but got I
			//IL_01fc: Expected Obj, but got I4
			//IL_00bb: Expected Obj, but got I4
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected I4, but got Unknown
			//IL_012d: Expected Obj, but got I4
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
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
			object obj5 = obj4;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				bool flag2 = (nint)0 < (nint)4;
				object obj6 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj7 = -4;
				bool flag3 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj13 = hitsPerOre - 1;
					bool flag5 = (nint)obj13 < 0;
					bool flag6 = obj13 == null;
					int num = hitsPerOre ^ 1;
					int num2 = hitsPerOre ^ obj13;
					int num3 = num & num2;
					bool flag7 = num3 < 0;
					bool flag8 = flag5 == flag7;
					object obj14 = !flag6;
					object obj15 = flag8 & obj14;
					object obj16 = ~obj15;
					int num4 = ((obj16 != null) ? 1 : hitsPerOre);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+170]");
					int result = (int)((nint)0 / (nint)num4);
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					return result;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
	}

	private bool Live
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0101: Expected I4, but got Obj
			//IL_0163: Expected Obj, but got I4
			//IL_00ed: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)((SimulationBehaviour)this)._object != (UnityEngine.Object)null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!networkObject._runner)
					{
						goto IL_00ed;
					}
					if ((object)networkObject._runner != null)
					{
						ArgumentNullException ex = new ArgumentNullException();
						return (byte)(int)ex != 0;
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			goto IL_00ed;
			IL_00ed:
			return false;
		}
	}

	public float Swing
	{
		get
		{
			//IL_007d: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I4
			//IL_0025: Expected Obj, but got VT
			//IL_0042: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = swung * swung;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+E8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+E8]");
			object obj5 = num * 0;
			object obj6 = obj4 + obj5;
			object obj7 = default;
			float result = (float)obj6 + (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			return result;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0155: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B70]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2618]");
		object obj6 = 0;
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj9 = default;
			item = (GillaItem)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj7 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<Vector3, Vector3, float, System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj6);
		object obj10 = item + 80;
		obj10 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
		object obj12 = 0;
		_ = loudness;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		object obj14 = default;
		object obj13 = obj14 & 1;
		if (obj13 != null)
		{
			Rigidbody rigidbody = default;
			rigidbody.centerOfMass = (Vector3)0;
		}
	}

	private void LateUpdate()
	{
		//IL_03fb: Expected Obj, but got I
		//IL_0037: Invalid comparison between F4 and I4
		//IL_0048: Expected Obj, but got I4
		//IL_0051: Invalid comparison between F4 and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0127: Expected VT, but got I4
		//IL_0148: Expected VT, but got I4
		//IL_0225: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
		//IL_0419: Expected Obj, but got VT
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got VT
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_05d0: Invalid comparison between F4 and I4
		//IL_05e3: Expected Obj, but got F4
		//IL_05f0: Expected Obj, but got F4
		//IL_0625: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I4
		//IL_0685: Expected Obj, but got I4
		//IL_06f0: Invalid comparison between F4 and I4
		//IL_0752: Expected Obj, but got I
		//IL_076a: Expected Obj, but got I
		//IL_0772: Expected F4, but got Obj
		//IL_0782: Expected F4, but got I
		//IL_0792: Expected F4, but got I
		//IL_072e: Invalid comparison between F4 and I
		//IL_02da: Expected I4, but got I8
		//IL_03b8: Expected VT, but got F4
		//IL_0319: Expected Obj, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got I4
		bool live = Live;
		bool flag = !live;
		IntPtr intPtr = default;
		NetworkObject networkObject = (NetworkObject)(nint)intPtr;
		if (!flag)
		{
			networkObject = ((SimulationBehaviour)this)._object;
			holder.Watch(((SimulationBehaviour)this)._object);
		}
		float deltaTime = Time.deltaTime;
		bool flag2 = deltaTime < 0f;
		object obj = !flag2;
		bool flag3 = deltaTime == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag3;
		if (obj3 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = item == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 vector = transform.TransformPoint((Vector3)0);
		Transform transform2 = base.transform;
		Vector3 vector2 = transform2.TransformPoint((Vector3)0);
		Vector3 vector3;
		object obj8;
		object obj9;
		Vector3 vector4;
		object obj10;
		object obj11;
		if (~(started ? 1u : 0u) == 0)
		{
			vector3 = wasTip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+D0]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+D4]");
			obj9 = 0;
			vector4 = wasEdge;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+DC]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+E0]");
			obj11 = 0;
		}
		else
		{
			wasTip = tip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+84]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+88]");
			_ = 0;
			wasEdge = edge;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+94]");
			_ = 0;
			started = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+94]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+90]");
			obj10 = 0;
			vector4 = edge;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+88]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+84]");
			obj8 = 0;
			vector3 = tip;
		}
		object obj12 = tip - vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+84]");
		object obj13 = 0 - obj8;
		object obj14 = edge - vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+90]");
		object obj15 = 0 - obj10;
		wasTip = tip;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+84]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+88]");
		object obj16 = 0 - obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+94]");
		object obj17 = 0 - obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+88]");
		_ = 0;
		wasEdge = edge;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+94]");
		_ = 0;
		float num = (float)obj12 / deltaTime;
		float num2 = (float)obj13 / deltaTime;
		float num3 = num * num;
		float num4 = (float)obj14 / deltaTime;
		float num5 = num2 * num2;
		float num6 = num3 + num5;
		float num7 = (float)obj15 / deltaTime;
		float num8 = num4 * num4;
		float num9 = (float)obj16 / deltaTime;
		float num10 = num7 * num7;
		float num11 = num8 + num10;
		float num12 = (float)obj17 / deltaTime;
		float num13 = num9 * num9;
		float num14 = num6 + num13;
		float num15 = num12 * num12;
		float num16 = num11 + num15;
		float num17 = num14 - num16;
		bool flag7 = num17 < 0f;
		object obj18 = num14 ^ num16;
		object obj19 = num14 ^ num17;
		object obj20 = obj18 & obj19;
		bool flag8 = (nint)obj20 < 0;
		bool flag9 = flag7 == flag8;
		object obj21 = !flag9;
		object obj22 = ~obj21;
		if (obj22 != null)
		{
			num4 = num;
		}
		bool flag10 = flag7 == flag8;
		object obj23 = !flag10;
		object obj24 = ~obj23;
		float num18 = ((obj24 != null) ? num2 : num7);
		bool flag11 = flag7 == flag8;
		object obj25 = !flag11;
		object obj26 = ~obj25;
		float num19 = ((obj26 != null) ? num9 : num12);
		float num20 = num4 * num4;
		float num21 = num18 * num18;
		float num22 = num20 + num21;
		float num23 = num19 * num19;
		float num24 = num23 + num22;
		if (!(num24 > 1.1539579E+09f))
		{
			GillaItem gillaItem = item;
			if ((int)(gillaItem.Hand__BackingField & 0x80000000L) == 0)
			{
				goto IL_0704;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v21+A0]");
		object obj29 = 0;
		num4 = (float)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v22+4]");
		num18 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v22+8]");
		num19 = 0f;
		goto IL_0704;
		IL_0704:
		float time = Time.time;
		float num25 = time - swungAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
		if (!(num25 > 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+E8]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+E8]");
			object obj30 = num26 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num27 = num4 * num4;
			float num28 = num27 + num24;
			float num29 = num28 + (float)obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGE not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			object obj31 = num29 & 1;
			bool flag12 = obj31 == null;
			object obj32 = !flag12;
			if (obj32 != null)
			{
				return;
			}
		}
		swung = (Vector3)num4;
		float time2 = Time.time;
		swungAt = time2;
	}

	private void HeldKnock(Vector3 at, Vector3 faces, float speed, Collider on)
	{
		Hit(at, faces, speed, on);
	}

	public unsafe void Hit(Vector3 at, Vector3 faces, float speed, Collider on)
	{
		//IL_003c: Expected VT, but got I4
		//IL_033e: Expected VT, but got I4
		//IL_02af: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I4
		//IL_04ef: Expected Obj, but got I
		//IL_0519: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got VT
		//IL_031c: Expected VT, but got I4
		//IL_008f: Expected Obj, but got VT
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_0549: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got VT
		//IL_03f0: Expected Obj, but got VT
		//IL_0560: Expected VT, but got I4
		//IL_04c0: Expected I4, but got Obj
		//IL_04c0: Expected VT, but got I4
		//IL_04c0: Expected VT, but got I4
		//IL_0456: Invalid comparison between F8 and I4
		//IL_04a3: Expected VT, but got I
		//IL_04a3: Expected I4, but got Obj
		//IL_04a3: Expected VT, but got Ref
		//IL_04a3: Expected VT, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01b5: Expected VT, but got I4
		//IL_01e8: Expected VT, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_0220: Expected VT, but got I4
		//IL_0256: Expected I4, but got Obj
		//IL_0256: Expected VT, but got I4
		//IL_0256: Expected VT, but got I4
		//IL_026b: Expected F4, but got I
		//IL_0289: Expected F4, but got I
		//IL_0289: Expected F4, but got I
		//IL_0292: Expected VT, but got I4
		//IL_029a: Expected Obj, but got I4
		if (!item.Mine)
		{
			return;
		}
		bool flag = OnHead((Vector3)0);
		bool flag2 = !flag;
		UnityEngine.Object obj = null;
		float num2 = default;
		float num = num2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v29+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = swung * swung;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+E8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMinePick)+E8]");
			object obj6 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			object obj8 = obj7;
			object obj9 = obj5 + obj6;
			float num5 = default;
			float num4 = (float)obj9 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			num = ((!(num4 < num2)) ? num4 : num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v31+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)at != null && !(num < strikeSpeed))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B90]");
				object obj11 = 0;
				obj = (UnityEngine.Object)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
				GillaOre gillaOre = default;
				bool flag5 = (object)gillaOre == null;
				Vector3 vector = (Vector3)0;
				float num6 = num5;
				if (!flag5)
				{
					bool flag6 = gillaOre.Shown__BackingField == 0;
					vector = (Vector3)0;
					num6 = num5;
					if (!flag6)
					{
						bool flag7 = (byte)(~(gillaOre.BrokeHere__BackingField ? 1u : 0u)) != 0;
						object obj12 = !flag7;
						vector = (Vector3)0;
						num6 = num5;
						if (obj12 == null)
						{
							int miningDamage = MiningDamage;
							gillaOre.Struck((Vector3)miningDamage, (Vector3)0, (int)on);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							num6 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							Buzz(num7, 0f);
							vector = (Vector3)0;
							obj = (UnityEngine.Object)miningDamage;
						}
					}
				}
			}
			else
			{
				Vector3 vector = (Vector3)0;
				float num6 = num5;
				obj = null;
			}
		}
		byte b;
		if (!(num < clangSpeed))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = (UnityEngine.Object)at == null;
			bool flag10 = !flag9;
			Vector3 vector = (Vector3)0;
			if (flag10)
			{
				float time = Time.time;
				if (time < clangAt)
				{
					return;
				}
				float time2 = Time.time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
				object obj16 = 0;
				float num8 = time2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				float num9 = num8 + 0f;
				object obj17 = obj16;
				clangAt = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v18+E4]");
				bool flag11 = (nint)0 == 0;
				object obj18 = !flag11;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				b = GillaPickaxe.StuffOf((Collider)at);
				if ((double)clangSpeed != 6.0)
				{
					float num10 = num - clangSpeed;
					double num11 = 6.0 - (double)clangSpeed;
					double num12 = (double)num10 / num11;
					if (!(num12 < 0.0) && num12 > 1.0)
					{
						goto IL_0489;
					}
				}
				if (!Live)
				{
					Clang((Vector3)b, (Vector3)0, (byte)(int)on, speed);
					return;
				}
				goto IL_0489;
			}
		}
		item.Knock((Vector3)0, speed);
		return;
		IL_0489:
		object obj19 = default;
		IntPtr intPtr = default;
		RPC_Clang((Vector3)b, (Vector3)(&obj19), (byte)(int)on, speed, (RpcInfo)(nint)intPtr);
	}

	public bool OnHead(Vector3 at)
	{
		//IL_00a9: Expected I4, but got Obj
		//IL_0035: Expected VT, but got I4
		//IL_004b: Expected VT, but got I
		//IL_004b: Expected VT, but got I4
		//IL_0066: Expected VT, but got I
		//IL_0066: Expected VT, but got I4
		//IL_00c3: Invalid comparison between F4 and I4
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 p = transform.InverseTransformPoint((Vector3)0);
			IntPtr intPtr = default;
			float num = Off(p, (Vector3)0, (Vector3)(nint)intPtr);
			float num2 = Off(p, (Vector3)0, (Vector3)(nint)intPtr);
			if (!(num < num2))
			{
				num = num2;
			}
			float num3 = num - headReach;
			return num3 < 0f;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static float Off(Vector3 p, Vector3 a, Vector3 b)
	{
		//IL_007c: Expected F8, but got I
		//IL_008c: Invalid comparison between F8 and I
		//IL_009e: Expected F8, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_012e: Invalid comparison between F8 and I4
		//IL_013d: Expected F8, but got I4
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj8 = default;
		object obj9 = default;
		object obj7 = obj8 - obj9;
		object obj10 = obj * obj;
		object obj11 = obj4 * obj4;
		double num = (double)obj10 + (double)obj11;
		object obj12 = obj7 * obj7;
		double num2 = (double)obj12 + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		double num3 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		bool flag = !(num2 > 0.0);
		double num4 = 0.0;
		object obj14 = default;
		object obj16 = default;
		object obj18 = default;
		if (!flag)
		{
			object obj13 = obj14 - obj3;
			object obj15 = obj16 - obj6;
			object obj17 = obj18 - obj9;
			object obj19 = obj13 * obj;
			object obj20 = obj15 * obj4;
			object obj21 = obj17 * obj7;
			object obj22 = obj19 + obj20;
			num3 = (double)obj21 + (double)obj22;
			num = num3 / num2;
			bool flag2 = num < 0.0;
			num4 = 0.0;
			if (!flag2)
			{
				bool flag3 = !(num > 1.0);
				num4 = num;
				num3 = 1.0;
				if (!flag3)
				{
					num4 = 1.0;
					num3 = 1.0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj25 = !flag4;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num5 = (double)obj4 * num4;
		double num6 = (double)obj * num4;
		double num7 = (double)obj7 * num4;
		double num8 = (double)obj6 + num5;
		double num9 = (double)obj3 + num6;
		double num10 = (double)obj9 + num7;
		double num11 = (double)obj14 - num9;
		double num12 = (double)obj16 - num8;
		double num13 = (double)obj18 - num10;
		double num14 = num11 * num11;
		double num15 = num12 * num12;
		double num16 = num14 + num15;
		double num17 = num13 * num13;
		float result = (float)num17 + (float)num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
	}

	public unsafe void RPC_Clang(Vector3 at, Vector3 normal, byte stuff, float hard, RpcInfo info = default(RpcInfo))
	{
		//IL_0e3f: Expected VT, but got I4
		//IL_052f: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I4
		//IL_059b: Expected Obj, but got I4
		//IL_0465: Expected VT, but got I
		//IL_0625: Expected VT, but got I4
		//IL_0ee7: Expected Obj, but got I
		//IL_0eff: Expected Obj, but got I
		//IL_0f0f: Expected Obj, but got I
		//IL_0f1f: Expected Obj, but got I
		//IL_0f2f: Expected Obj, but got I
		//IL_0f38: Expected VT, but got I4
		//IL_0659: Expected Obj, but got I4
		//IL_0666: Expected Obj, but got I4
		//IL_0673: Expected I4, but got Obj
		//IL_0e75: Invalid comparison between F4 and I4
		//IL_0e84: Expected F8, but got I4
		//IL_0094: Expected VT, but got F4
		//IL_06be: Expected Obj, but got VT
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06e6: Expected Obj, but got I4
		//IL_0fea: Expected Obj, but got I
		//IL_1014: Expected Obj, but got I4
		//IL_07d7: Expected Obj, but got I4
		//IL_0c59: Expected VT, but got F8
		//IL_04ba: Expected Obj, but got I
		//IL_04ca: Invalid comparison between VT and I
		//IL_00e2: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_080d: Expected Obj, but got I
		//IL_081f: Expected VT, but got I8
		//IL_0836: Expected I, but got Obj
		//IL_0be0: Expected Obj, but got I
		//IL_0bf8: Expected Obj, but got I
		//IL_0c10: Expected Obj, but got I
		//IL_0c20: Expected Obj, but got I
		//IL_0c29: Expected VT, but got I4
		//IL_012b: Expected VT, but got I4
		//IL_0859: Expected Obj, but got VT
		//IL_0873: Expected Obj, but got I4
		//IL_088c: Expected F4, but got I4
		//IL_0c81: Expected VT, but got F8
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0511: Expected VT, but got I4
		//IL_051a: Expected Obj, but got I4
		//IL_0cee: Expected Obj, but got I4
		//IL_0cff: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I4
		//IL_0971: Expected Obj, but got I4
		//IL_0979: Expected VT, but got Ref
		//IL_09b1: Expected VT, but got F4
		//IL_09b9: Expected I4, but got VT
		//IL_09d2: Expected Obj, but got Ref
		//IL_09e3: Expected Obj, but got I4
		//IL_09eb: Expected I4, but got VT
		//IL_0731: Expected I, but got Obj
		//IL_073e: Expected VT, but got Obj
		//IL_0747: Expected VT, but got I4
		//IL_017d: Expected VT, but got F4
		//IL_019c: Expected VT, but got F4
		//IL_0d56: Expected Ref, but got VT
		//IL_08aa: Expected Obj, but got I
		//IL_08bc: Expected I4, but got Obj
		//IL_08bc: Expected VT, but got I4
		//IL_08ce: Expected I4, but got Obj
		//IL_08ce: Expected VT, but got I4
		//IL_08e3: Expected Obj, but got I
		//IL_08eb: Expected VT, but got Obj
		//IL_0905: Expected Obj, but got I
		//IL_090d: Expected VT, but got Obj
		//IL_075e: Invalid comparison between VT and I4
		//IL_0233: Invalid comparison between F4 and I4
		//IL_0d97: Expected Obj, but got VT
		//IL_0da0: Expected Obj, but got I4
		//IL_0a45: Expected Obj, but got I
		//IL_0a6f: Expected Obj, but got I4
		//IL_077b: Invalid comparison between VT and I4
		//IL_0789: Expected I, but got Obj
		//IL_0796: Expected VT, but got Obj
		//IL_079f: Expected VT, but got I4
		//IL_0276: Expected Obj, but got I4
		//IL_0ea2: Expected Obj, but got I
		//IL_0a27: Expected Obj, but got I4
		//IL_029d: Expected VT, but got I4
		//IL_103c: Expected Obj, but got I4
		//IL_0aa4: Expected Obj, but got I
		//IL_0aad: Expected VT, but got Obj
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected I4, but got Unknown
		//IL_0ae8: Expected Obj, but got I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I4
		//IL_0bc6: Expected VT, but got I4
		//IL_0b20: Expected I4, but got I8
		//IL_0b37: Expected VT, but got I4
		//IL_0b37: Expected VT, but got I4
		//IL_0b5a: Expected I, but got VT
		//IL_0b63: Expected VT, but got I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0364: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I4
		//IL_03d0: Expected VT, but got F4
		//IL_0406: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		float num2 = default;
		float num = num2;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		object obj10 = default;
		object obj9 = obj10;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		RpcChannel rpcChannel = (RpcChannel)0;
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		int num3 = 109895680;
		object obj11 = default;
		int bytePayloadSize4;
		MethodBase methodBase = default;
		int num5 = default;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		bool flag4;
		object obj12;
		int num4;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj11 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			flag4 = (object)((SimulationBehaviour)this)._runner == null;
			num = num2;
			num4 = bytePayloadSize4;
			methodBase = (MethodBase)(object)((SimulationBehaviour)this)._runner;
			num5 = bytePayloadSize2;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			rpcBuilder = (Fusion.RpcBuilder)0;
			rpcChannel = (RpcChannel)0;
			vector = vector2;
			num3 = bytePayloadSize;
			if (!flag4)
			{
				object obj14 = bytePayloadSize2 + bytePayloadSize;
				object obj15 = bytePayloadSize3 + bytePayloadSize4;
				int payloadByteCount = (int)(obj14 + obj15);
				Fusion.RpcBuilder rpcBuilder2 = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(612542847u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				methodBase = (MethodBase)(rpcInvokeInfo >> 32);
				object obj16 = methodBase - 522;
				bool flag5 = (nint)obj16 < 2;
				object obj17 = !flag5;
				object obj18 = ~obj17;
				nint num6;
				if (obj18 == null && (nint)methodBase != 518)
				{
					bool flag6 = (nint)methodBase != 524;
					num6 = unchecked((nint)null);
					playerRef = invalid;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_084b;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						num6 = unchecked((nint)null);
						playerRef = invalid;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_084b;
						}
					}
				}
				object obj19 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X0_v71+E4]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2628]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				num6 = unchecked((nint)null);
				playerRef = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_084b;
			}
			goto IL_0ca2;
		}
		goto IL_0005;
		IL_0f8a:
		object obj21 = default;
		bool flag9 = obj21 == null;
		flag4 = !flag9;
		Vector3 vector3;
		vector2 = vector3;
		Fusion.RpcBuilder rpcBuilder4 = default;
		RpcInfo rpcInfo;
		byte stuff2 = default;
		if (!flag4)
		{
			if ((nint)obj12 != 10)
			{
				bool flag10 = obj12 == null;
				object obj22 = !flag10;
				if (obj22 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v6+E4]");
			bool flag11 = (nint)0 == 0;
			object obj25 = !flag11;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v6+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X8_v5+18]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2620]");
				object obj27 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj27);
				object obj28 = obj11;
				int num7 = num3 | methodBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v10+E4]");
				bool flag12 = (nint)0 == 0;
				object obj29 = !flag12;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num5 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num7, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v403 @ X26_v1 (System.Int32)+18] (should have been resolved before IL gen)");
				object obj30 = default;
				obj21 = obj30;
				nint num6 = (nint)invalid2;
				rpcInfo = (RpcInfo)0;
				methodBase = methodFromHandle;
				object obj31 = default;
				obj7 = obj31;
			}
			bool flag13 = num3 == 0;
			object obj32 = !flag13;
			if (obj32 == null)
			{
				RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				obj9 = obj21;
				rpcBuilder = rpcBuilder4;
				stuff2 = 0;
				rpcChannel = (RpcChannel)0;
				vector2 = (Vector3)0;
				goto IL_0005;
			}
			return;
		}
		goto IL_0cb0;
		IL_0414:
		object obj33 = obj6 * obj6;
		object obj34 = obj4 * obj4;
		object obj35 = obj33 + obj34;
		obj9 = obj2 * obj2;
		object obj36 = obj9 + obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		rpcBuilder = (Fusion.RpcBuilder)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if ((nint)obj36 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v89+E4]");
			bool flag14 = (nint)0 == 0;
			object obj39 = !flag14;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			obj9 = 0;
			Fusion.RpcBuilder rpcBuilder5 = rpcBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (rpcBuilder5 > (object)0)
			{
				obj5 = obj6 / rpcBuilder;
				obj3 = obj4 / rpcBuilder;
				obj = obj2 / rpcBuilder;
				vector = (Vector3)109891584;
				obj12 = 17276928;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj40 = 0;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v57+A0]");
				obj12 = 0;
				obj5 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v16+4]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v16+8]");
				obj = 0;
				vector = (Vector3)109891584;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v44+A0]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v16+18]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v16+1C]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v16+20]");
			obj = 0;
			vector = (Vector3)109891584;
		}
		bool flag15 = num2 < 0f;
		double num8 = 0.0;
		if (!flag15)
		{
			bool flag16 = !((double)num2 > 1.0);
			num8 = num2;
			rpcBuilder = (Fusion.RpcBuilder)1.0;
			if (!flag16)
			{
				num8 = 1.0;
				rpcBuilder = (Fusion.RpcBuilder)1.0;
			}
		}
		flag4 = (object)this == null;
		num = (float)num8;
		GillaNetGuard.Kind kind;
		rpcChannel = (RpcChannel)kind;
		if (!flag4)
		{
			Clang(at, vector2, stuff2, hard);
			return;
		}
		goto IL_0ca2;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X21_v2 (UnityEngine.Vector3)+18]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X21_v2 (UnityEngine.Vector3)+18]");
		object obj44 = (nint)0 & (nint)1;
		bool flag17 = obj44 == null;
		object obj45 = !flag17;
		kind = (GillaNetGuard.Kind)rpcChannel;
		if (obj45 != null)
		{
			goto IL_0414;
		}
		if (holder != null)
		{
			if (!holder.Is(((SimulationBehaviour)this)._object, (PlayerRef)vector.y))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			num3 = 0;
			int value = ((int*)num3)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v100 (System.Int32)+E4]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v100 (System.Int32)+E4]");
			bool flag18 = (nint)0 == 0;
			object obj46 = !flag18;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!NetworkApe.Sane((Vector3)0))
			{
				return;
			}
			Transform transform = base.transform;
			flag4 = (object)transform == null;
			obj7 = obj8;
			obj9 = obj10;
			rpcBuilder = (Fusion.RpcBuilder)hard;
			stuff2 = 0;
			rpcChannel = (RpcChannel)0;
			vector2 = (Vector3)vector.y;
			if (!flag4)
			{
				Vector3 position = transform.position;
				float num9 = hard - hard;
				object obj47 = obj10 - obj10;
				object obj48 = obj8 - obj8;
				float num10 = num9 * num9;
				object obj49 = obj47 * obj47;
				float num11 = num10 + (float)obj49;
				object obj50 = obj48 * obj48;
				float num12 = (float)obj50 + num11;
				if (!(num12 > 1.1083448E+09f))
				{
					int value2 = ((int*)num3)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v107 (System.Int32)+E4]");
					bool flag19 = (nint)0 == 0;
					object obj51 = !flag19;
					if (obj51 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (NetworkApe.Sane((Vector3)0))
					{
						object obj52 = at & 0xFF;
						bool flag20 = (nint)obj52 < 2;
						object obj53 = !flag20;
						object obj54 = obj52 - 2;
						bool flag21 = obj54 == null;
						object obj55 = !flag21;
						object obj56 = obj53 & obj55;
						if (obj56 == null)
						{
							object obj57 = num2 & 0x7F800000;
							if ((nint)obj57 != 2139095040)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
								object obj58 = 0;
								object obj59 = obj58;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v111+E4]");
								bool flag22 = (nint)0 == 0;
								object obj60 = !flag22;
								if (obj60 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag23 = GillaNetGuard.Spend((PlayerRef)vector.y, (GillaNetGuard.Kind)2, 8f, 16f);
								bool flag24 = !flag23;
								obj7 = obj2;
								stuff2 = 0;
								kind = (GillaNetGuard.Kind)2;
								vector2 = (Vector3)0;
								if (!flag24)
								{
									goto IL_0414;
								}
								return;
							}
							return;
						}
						return;
					}
					return;
				}
				return;
			}
		}
		goto IL_0ca2;
		IL_0cb0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex2 = default;
		OutOfMemoryException ex = ex2;
		object obj62 = default;
		object obj63 = default;
		OutOfMemoryException ex4 = default;
		while (true)
		{
			object obj61;
			if (rpcChannel == (RpcChannel)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj21 = 1;
				obj61 = obj62;
				obj12 = 1;
			}
			else
			{
				if (rpcChannel != (RpcChannel)1)
				{
					goto IL_0f67;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj61 = obj63;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj62 = obj63;
			}
			((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
			if (obj61 == null)
			{
				break;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex = ex3;
			rpcChannel = (RpcChannel)0;
			goto IL_0f67;
			IL_0f67:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			methodBase = null;
			ex = ex4;
			num5 = 0;
			num3 = 0;
		}
		rpcChannel = (RpcChannel)0;
		vector3 = vector2;
		NullReferenceException ex5 = (NullReferenceException)rpcBuilder4;
		obj12 = 0;
		goto IL_0f8a;
		IL_084b:
		object obj64 = rpcInvokeInfo >> 32;
		bool flag25 = obj64 == null;
		object obj65 = !flag25;
		obj7 = obj8;
		obj9 = obj10;
		float num13 = 0f;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj66 = 0;
			writer.Write((Vector3)12, (int)obj66);
			writer.Write((Vector3)12, (int)obj66);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj67 = 0;
			playerRef2 = (PlayerRef)obj67;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD0]");
			object obj68 = 0;
			rpcInvokeInfo2 = (RpcInvokeInfo)obj68;
			writer.Write(num2, 4);
			int num14 = rpcBuilder3.Send();
			obj7 = obj2;
			obj9 = obj4;
			num13 = num2;
		}
		rpcBuilder3.Dispose();
		num = num2;
		obj21 = 0;
		obj62 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		rpcInfo = (RpcInfo)playerRef;
		num4 = bytePayloadSize4;
		num5 = (int)(&writer);
		obj = obj2;
		obj3 = obj4;
		obj5 = obj6;
		rpcBuilder = (Fusion.RpcBuilder)num13;
		stuff2 = (byte)(int)playerRef2;
		rpcChannel = (RpcChannel)0;
		vector3 = (Vector3)rpcInvokeInfo2;
		ex5 = (NullReferenceException)(&rpcBuilder3);
		vector = vector2;
		obj12 = 10;
		num3 = (int)rpcInvokeInfo;
		goto IL_0f8a;
		IL_0ca2:
		ex5 = new NullReferenceException();
		goto IL_0cb0;
	}

	private void Clang(Vector3 at, Vector3 normal, byte stuff, float hard)
	{
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_032a: Expected Obj, but got I4
		//IL_0178: Expected F4, but got I
		//IL_0181: Invalid comparison between F8 and I4
		//IL_0190: Expected F8, but got I4
		//IL_03f2: Expected F4, but got I
		//IL_0402: Invalid comparison between F8 and I
		//IL_00c7: Invalid comparison between F8 and I4
		//IL_00d6: Expected F8, but got I4
		//IL_0348: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_015c: Expected VT, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_027d: Expected VT, but got I4
		//IL_043b: Expected Obj, but got I4
		//IL_026f: Expected VT, but got I4
		//IL_02a7: Expected I4, but got VT
		//IL_02a7: Expected VT, but got I4
		object obj = at & 0xFF;
		object obj2;
		if ((nint)obj == 2)
		{
			obj2 = this + 192;
		}
		else
		{
			if ((nint)obj != 1)
			{
				goto IL_009d;
			}
			obj2 = this + 184;
		}
		AudioClip[] array = (AudioClip[])obj2;
		if (obj2 == null || array.Length == 0)
		{
			goto IL_009d;
		}
		GillaItem gillaItem = item;
		bool flag = (object)item == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0303;
		IL_0303:
		bool justKnocked = gillaItem.JustKnocked;
		bool flag2 = !justKnocked;
		object obj4 = !flag2;
		double num = default;
		if (obj4 == null)
		{
			bool flag3 = num < 0.0;
			double num2 = 0.0;
			if (!flag3)
			{
				bool flag4 = !(num > 1.0);
				num2 = num;
				if (!flag4)
				{
					num2 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj5 = 0;
			double num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			double num4 = num3 * 0.0;
			object obj6 = obj5;
			double num5 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			double num6 = num5 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num7 = (double)loudness * num6;
			float pitchMin = default;
			float pitchMax = default;
			Sfx.Play(array, (Vector3)0, hard, pitchMin, pitchMax);
		}
		GillaItem gillaItem2 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		gillaItem2.Hush(0f);
		bool flag6 = num < 0.0;
		double num8 = 0.0;
		if (!flag6)
		{
			bool flag7 = !(num > 1.0);
			num8 = num;
			if (!flag7)
			{
				num8 = 1.0;
			}
		}
		double num9 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAE4]");
		double num10 = num9 * 0.0;
		float num11 = (float)num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float strength = num11 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		Buzz(strength, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		if (!(num > 0.0))
		{
			return;
		}
		object obj8 = at & 0xFF;
		if (obj8 != null && ~(sparks ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
			object obj9 = 0;
			object obj10 = obj9;
			object obj11 = at & 0xFF;
			Vector3 at2 = (((nint)obj11 != 2) ? ((Vector3)14) : ((Vector3)30));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v7+E4]");
			bool flag8 = (nint)0 == 0;
			object obj12 = !flag8;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaPickaxe.Sparks(at2, (Vector3)0, (int)normal, hard);
		}
		return;
		IL_009d:
		gillaItem = item;
		array = gillaItem.knocks;
		goto IL_0303;
	}

	private void Buzz(float strength, float seconds)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			GillaItem gillaItem = item;
			bool flag4 = gillaItem.Hand__BackingField < 1;
			object obj5 = !flag4;
			object obj6 = gillaItem.Hand__BackingField - 1;
			bool flag5 = obj6 == null;
			object obj7 = !flag5;
			object obj8 = obj5 & obj7;
			if (obj8 == null)
			{
				bool flag6 = gillaItem.Hand__BackingField == 0;
				object obj9 = !flag6;
				object obj10 = ~obj9;
				XRNode node = ((obj10 != null) ? ((XRNode)4) : ((XRNode)5));
				InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
				InputDevice inputDevice = default;
				bool flag7 = inputDevice.SendHapticImpulse(0u, strength, seconds);
			}
		}
	}

	public GillaMinePick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected VT, but got I
		//IL_0056: Expected F4, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E18]");
		object obj = 0;
		hitsPerOre = 5;
		sparks = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DEF0]");
		balance = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C620]");
		clangSpeed = 0f;
		loudness = 0.45f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaNetGuard.Holder holder = default;
		holder._002Ector();
		object obj2 = this + 256;
		this.holder = holder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	public override void CopyStateToBackingFields()
	{
	}

	protected unsafe static void RPC_Clang_0040Invoker612542847([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_00c7: Expected VT, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01bf: Expected F4, but got VT
		//IL_01bf: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out float _, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		byte stuff = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2620]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X21_v3+18] (should have been resolved before IL gen)");
			stuff = 0;
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaMinePick gillaMinePick = (GillaMinePick)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2630]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaMinePick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14 (Il2CppClass<GillaMinePick>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X1_v9+130]");
		bool flag3 = num2 < 0;
		object obj13 = !flag3;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14 (Il2CppClass<GillaMinePick>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X1_v9+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				Vector3 at = default;
				object obj16 = default;
				RpcInfo info = default;
				gillaMinePick.RPC_Clang(at, (Vector3)(&obj16), stuff, (float)value, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
