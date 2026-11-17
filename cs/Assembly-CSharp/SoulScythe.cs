using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.XR;

public class SoulScythe : MonoBehaviour, _0021_00211
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass37_0
	{
		public float radius;
	}

	public Transform bladeBase;

	public Transform tip;

	public TrailRenderer arc;

	public float arcSpeed;

	public float hitRadius;

	public float cooldown;

	public float perPlayer;

	public Material ghost;

	public AudioClip[] swishes;

	public AudioClip[] yanks;

	public AudioClip[] snaps;

	private bool live;

	private int hand;

	private Vector3 lastTip;

	private float speed;

	private float lastSwish;

	private float lastYank;

	private bool swinging;

	private readonly Dictionary<int, float> yanked;

	private static SoulScythe prefab;

	public void Live()
	{
		live = true;
	}

	public void Taken(int h)
	{
		hand = h;
	}

	public bool LetGo(Vector3 velocity)
	{
		//IL_000f: Expected I4, but got I8
		hand = -1;
		return false;
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
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
		bool flag2 = tip != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			Vector3 position = tip.position;
			Vector3 vector = default;
			lastTip = vector;
			obj4 = null;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (arc != null)
		{
			arc.Clear();
			arc.emitting = false;
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0502: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0065: Invalid comparison between F4 and I4
		//IL_0076: Expected Obj, but got I4
		//IL_007f: Invalid comparison between F4 and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_0548: Expected Obj, but got I
		//IL_0589: Expected Obj, but got I4
		//IL_00f4: Expected VT, but got F4
		//IL_017f: Invalid comparison between F8 and I4
		//IL_018e: Expected F8, but got I4
		//IL_05d9: Invalid comparison between F4 and I4
		//IL_0613: Expected Obj, but got I4
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected I4, but got Unknown
		//IL_0642: Expected Obj, but got I4
		//IL_01f4: Invalid comparison between F4 and I4
		//IL_0203: Invalid comparison between F4 and I4
		//IL_0218: Expected Obj, but got F4
		//IL_0225: Expected Obj, but got F4
		//IL_029d: Expected Obj, but got I4
		//IL_02a6: Expected VT, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_02d4: Expected VT, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_049f: Expected I4, but got I8
		//IL_04b9: Expected Obj, but got I4
		//IL_0660: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I4
		//IL_03fa: Expected F4, but got I
		//IL_040a: Invalid comparison between F8 and I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float deltaTime = Time.deltaTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tip == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		bool flag4 = deltaTime < 0f;
		object obj5 = !flag4;
		bool flag5 = deltaTime == 0f;
		object obj6 = ~obj5;
		object obj7 = obj6 | flag5;
		if (obj7 != null)
		{
			return;
		}
		Vector3 position = tip.position;
		float num = deltaTime - (float)lastTip;
		float num3 = default;
		float num2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulScythe)+74]");
		float num4 = num2 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj8 = 0;
		float num6 = default;
		float num5 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulScythe)+78]");
		float num7 = num5 - 0f;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num8 = num * num;
		float num9 = num4 * num4;
		lastTip = (Vector3)deltaTime;
		float num10 = num7 * num7;
		float num11 = num8 + num9;
		float num12 = num11 + num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num13 = num12 / deltaTime;
		float num14 = deltaTime * -25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num15 = 1.0 - (double)num14;
		bool flag7 = num15 < 0.0;
		double num16 = 0.0;
		if (!flag7)
		{
			bool flag8 = !(num15 > 1.0);
			num16 = num15;
			if (!flag8)
			{
				num16 = 1.0;
			}
		}
		float num17 = num13 - speed;
		object obj11 = obj;
		float num18 = num17 * (float)num16;
		float num19 = speed + num18;
		bool flag9;
		bool flag10;
		bool flag11;
		if (num13 < 1.1146363E+09f)
		{
			float num20 = num19 - arcSpeed;
			flag9 = num20 < 0f;
			flag10 = num20 == 0f;
			object obj12 = num19 ^ arcSpeed;
			object obj13 = num19 ^ num20;
			object obj14 = obj12 & obj13;
			flag11 = (nint)obj14 < 0;
		}
		else
		{
			flag11 = false;
			flag10 = true;
			flag9 = false;
		}
		speed = num19;
		bool flag12 = flag9 == flag11;
		object obj15 = !flag10;
		bool flag13 = (byte)((flag12 & obj15) ? 1 : 0) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v16+E4]");
		bool flag14 = (nint)0 == 0;
		object obj16 = !flag14;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = arc != null;
		bool flag16 = !flag15;
		object obj17 = 0;
		Vector3 at = (Vector3)0;
		if (!flag16)
		{
			arc.emitting = flag13;
			obj17 = 0;
			at = (Vector3)flag13;
		}
		if (flag13)
		{
			bool flag17 = (byte)(~(swinging ? 1u : 0u)) != 0;
			object obj18 = !flag17;
			if (obj18 == null)
			{
				float time = Time.time;
				float num21 = time - lastSwish;
				if ((double)num21 > 0.25)
				{
					AudioClip[] array = swishes;
					if (swishes != null && array.Length != 0)
					{
						float time2 = Time.time;
						lastSwish = time2;
						double num22 = (double)speed * 0.125;
						if (!(num22 < 0.25))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
							time2 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
							if (num22 > 0.0)
							{
								goto IL_041c;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj19 = 0;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v25+E4]");
						bool flag18 = (nint)0 == 0;
						object obj21 = !flag18;
						if (obj21 == null)
						{
							goto IL_041c;
						}
						goto IL_042b;
					}
				}
			}
		}
		goto IL_044b;
		IL_044b:
		swinging = flag13;
		if (~(live ? 1u : 0u) == 0 && flag13)
		{
			int num23 = (int)(hand & 0x80000000L);
			bool flag19 = num23 == 0;
			object obj22 = !flag19;
			if (obj22 == null)
			{
				Reap();
			}
		}
		return;
		IL_041c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_042b;
		IL_042b:
		Sfx.Play(swishes, at, deltaTime, num3, num6);
		goto IL_044b;
	}

	private unsafe void Reap()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a60: Expected I, but got Obj
		//IL_0a82: Expected Obj, but got I4
		//IL_0a98: Expected I, but got Obj
		//IL_0aa8: Expected Obj, but got I
		//IL_0aca: Expected Obj, but got I4
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		//IL_003b: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I4
		//IL_0af0: Expected Obj, but got I
		//IL_0b10: Expected F4, but got I4
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected VT, but got I4
		//IL_0952: Expected VT, but got I4
		//IL_0198: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_01ec: Expected F4, but got I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected F4, but got Unknown
		//IL_01fd: Expected VT, but got I4
		//IL_0892: Expected VT, but got I4
		//IL_08a0: Expected Obj, but got I4
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got I4
		//IL_0c87: Expected Obj, but got I
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected Ref, but got Unknown
		//IL_0cb2: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_027a: Expected VT, but got I4
		//IL_08e2: Expected Obj, but got I4
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected Obj, but got Unknown
		//IL_02b2: Expected Obj, but got I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I4
		//IL_0303: Expected VT, but got I4
		//IL_0918: Expected Obj, but got I4
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected VT, but got I4
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I4
		//IL_03ae: Expected VT, but got I4
		//IL_09fc: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I4
		//IL_03ec: Expected VT, but got I4
		//IL_0421: Expected Obj, but got I4
		//IL_042a: Expected VT, but got I4
		//IL_0464: Expected Obj, but got I4
		//IL_046d: Expected VT, but got I4
		//IL_0496: Expected VT, but got I4
		//IL_04a4: Expected Obj, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected VT, but got I4
		//IL_05a9: Expected VT, but got I4
		//IL_05b7: Expected Obj, but got I4
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected VT, but got Ref
		//IL_05f9: Expected Obj, but got I
		//IL_057a: Expected VT, but got Ref
		//IL_0618: Expected Obj, but got I
		//IL_0b78: Expected I, but got Obj
		//IL_0b88: Expected Obj, but got I
		//IL_0b95: Expected VT, but got I4
		//IL_06cd: Expected VT, but got I4
		//IL_06db: Expected Obj, but got I4
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected VT, but got Ref
		//IL_063e: Expected Obj, but got I
		//IL_0656: Expected VT, but got I4
		//IL_0691: Expected VT, but got Ref
		//IL_0728: Expected Obj, but got I
		//IL_0730: Expected VT, but got Obj
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Invalid comparison between Unknown and I4
		//IL_0764: Expected VT, but got I4
		//IL_0772: Expected Obj, but got I4
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected Obj, but got I
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected VT, but got Ref
		//IL_07cb: Expected VT, but got I
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07df: Expected I4, but got I8
		//IL_07f9: Expected Obj, but got I4
		//IL_0803: Expected F4, but got I4
		//IL_080c: Expected Obj, but got I4
		//IL_081d: Expected F4, but got I4
		//IL_0825: Expected VT, but got Ref
		//IL_084f: Expected Obj, but got I4
		//IL_0be9: Expected F4, but got I
		//IL_0bf9: Expected F4, but got I
		//IL_0c1f: Expected F4, but got I
		//IL_0c1f: Expected F4, but got I
		//IL_0c2e: Expected F4, but got I4
		//IL_0c37: Expected Obj, but got I4
		//IL_0c45: Expected Obj, but got I4
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Expected VT, but got I4
		//IL_0c72: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		Dictionary<int, float> dictionary = (Dictionary<int, float>)0;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num2 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		nint num3 = num2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)dictionary;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)val == null;
		bool flag5 = !flag4;
		object obj6 = !flag5;
		if (obj6 != null)
		{
			return;
		}
		float time = Time.time;
		float num4 = time - lastYank;
		float num5 = cooldown;
		if (num4 < cooldown)
		{
			return;
		}
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = bladeBase == null;
		bool flag8 = !flag7;
		object obj9 = !flag8;
		if (obj9 != null)
		{
			return;
		}
		nint num6 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v16 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj10 = !flag9;
		nint num7 = num6;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num7 = (nint)dictionary;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v17 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v11+8]");
		bool flag10 = (nint)0 == 0;
		float value = 0f;
		UnityEngine.Object obj13 = default;
		UnityEngine.Object obj12 = obj13;
		Enumerator<, > val2 = (Enumerator<, >)0;
		RpcInfo rpcInfo = (RpcInfo)0;
		UnityEngine.Object obj14 = null;
		InputDevice inputDevice;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v11+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7168]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			dictionary = (Dictionary<int, float>)0;
			value = 0f;
			Enumerator<, > val3 = default;
			num4 = (float)val3;
			rpcInfo = (RpcInfo)0;
			object obj18 = default;
			float num14 = default;
			object obj40 = default;
			object obj31;
			Enumerator<, > val4;
			while (true)
			{
				bool flag11 = val2.MoveNext();
				bool flag12 = !flag11;
				object obj17 = obj18;
				object obj39;
				if (!flag12)
				{
					object obj19 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v52+E4]");
					bool flag13 = (nint)0 == 0;
					object obj20 = !flag13;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = obj13 == null;
					bool flag15 = !flag14;
					object obj21 = !flag15;
					rpcInfo = (RpcInfo)0;
					if (obj21 != null)
					{
						continue;
					}
					object obj22 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v56+E4]");
					bool flag16 = (nint)0 == 0;
					object obj23 = !flag16;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag17 = obj13 == (UnityEngine.Object)val;
					bool flag18 = !flag17;
					object obj24 = !flag18;
					rpcInfo = (RpcInfo)0;
					if (obj24 != null)
					{
						continue;
					}
					if ((object)obj13 == null)
					{
						break;
					}
					object obj25 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X0_v61+E4]");
					bool flag19 = (nint)0 == 0;
					object obj26 = !flag19;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+68]");
					bool flag20 = (UnityEngine.Object)0 == null;
					bool flag21 = !flag20;
					object obj27 = !flag21;
					rpcInfo = (RpcInfo)0;
					if (obj27 != null)
					{
						continue;
					}
					bool isMonster = ((NetworkApe)obj13).IsMonster;
					bool flag22 = !isMonster;
					object obj28 = !flag22;
					rpcInfo = (RpcInfo)0;
					if (obj28 != null)
					{
						continue;
					}
					bool busy = ((NetworkApe)obj13).Busy;
					bool flag23 = !busy;
					object obj29 = !flag23;
					rpcInfo = (RpcInfo)0;
					if (obj29 != null)
					{
						continue;
					}
					bool flag24 = ((NetworkApe)obj13).IsTorn((ApePart)0);
					bool flag25 = !flag24;
					object obj30 = !flag25;
					rpcInfo = (RpcInfo)0;
					if (obj30 != null)
					{
						continue;
					}
					bool flag26 = yanked == null;
					inputDevice = (InputDevice)0;
					obj12 = null;
					obj31 = 0;
					val2 = val3;
					val = (Enumerator<, >)(ref val2);
					val4 = (Enumerator<, >)(ref val2);
					rpcInfo = (RpcInfo)0;
					obj14 = null;
					if (flag26)
					{
						goto IL_097a;
					}
					object obj32 = obj16;
					Dictionary<int, float> dictionary2 = yanked;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+6CC]");
					bool flag27 = dictionary2.TryGetValue(0, out value);
					bool flag28 = !flag27;
					float num8 = num5;
					float num9 = num4;
					if (!flag28)
					{
						float time2 = Time.time;
						num9 = time2 - value;
						num8 = perPlayer;
						bool flag29 = num9 < perPlayer;
						num5 = perPlayer;
						num4 = num9;
						rpcInfo = (RpcInfo)(&value);
						if (flag29)
						{
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+68]");
					bool flag30 = (nint)0 == 0;
					inputDevice = (InputDevice)0;
					obj12 = null;
					obj31 = 0;
					val2 = val3;
					val = (Enumerator<, >)(ref val2);
					val4 = (Enumerator<, >)(ref val2);
					num5 = num8;
					num4 = num9;
					rpcInfo = (RpcInfo)(&value);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+6CC]");
					obj14 = (UnityEngine.Object)0;
					if (flag30)
					{
						goto IL_0988;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+68]");
					Vector3 position = ((Transform)0).position;
					nint num10 = (nint)dictionary;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v35 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+A0]");
					object obj33 = 0;
					float num11 = Near((Vector3)0);
					float num12 = hitRadius;
					bool flag31 = !(num11 > hitRadius);
					obj17 = obj18;
					if (!flag31)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v36+20]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						object obj34 = num13 * 0;
						obj17 = obj18 - obj34;
						num4 = Near((Vector3)0);
						num12 = hitRadius;
						bool flag32 = num4 > hitRadius;
						obj18 = obj17;
						num5 = hitRadius;
						rpcInfo = (RpcInfo)(&value);
						if (flag32)
						{
							continue;
						}
					}
					num4 = (lastYank = Time.time);
					bool flag33 = yanked == null;
					inputDevice = (InputDevice)0;
					obj12 = null;
					obj31 = 0;
					val2 = val3;
					val = (Enumerator<, >)(ref val2);
					val4 = (Enumerator<, >)(ref val2);
					num5 = num12;
					rpcInfo = (RpcInfo)(&value);
					obj14 = null;
					if (flag33)
					{
						goto IL_099e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F28]");
					object obj35 = 0;
					rpcInfo = (RpcInfo)obj35;
					Dictionary<int, float> dictionary3 = yanked;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+6CC]");
					dictionary3.set_Item(0, num4);
					bool flag34 = (int)val == 0;
					inputDevice = (InputDevice)0;
					obj12 = null;
					obj31 = 0;
					val2 = val3;
					val = (Enumerator<, >)(ref val2);
					val4 = (Enumerator<, >)(ref val2);
					num5 = num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+6CC]");
					obj14 = (UnityEngine.Object)0;
					if (flag34)
					{
						goto IL_09ac;
					}
					Enumerator<, > val5 = val;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-D8 (UnityEngine.Object)+6D0]");
					((NetworkApe)val5).RPC_SoulYank((PlayerRef)0, (RpcInfo)(&num14));
					int num15 = (int)(hand & 0x80000000L);
					bool flag35 = num15 == 0;
					object obj36 = !flag35;
					num14 = 0f;
					obj32 = 0;
					num5 = num12;
					num4 = 0f;
					rpcInfo = (RpcInfo)(&num14);
					if (obj36 == null)
					{
						bool flag36 = hand == 0;
						object obj37 = !flag36;
						object obj38 = ~obj37;
						XRNode node = ((obj38 != null) ? ((XRNode)4) : ((XRNode)5));
						InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						num4 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
						num5 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
						bool flag37 = inputDevice.SendHapticImpulse(0u, num16, 0f);
						num14 = 0f;
						obj32 = 0;
						obj12 = null;
						obj31 = 0;
						val2 = val3;
						val = (Enumerator<, >)17276928;
						val4 = (Enumerator<, >)(ref val2);
						rpcInfo = (RpcInfo)0;
						obj39 = 0;
						goto IL_0c77;
					}
				}
				inputDevice = (InputDevice)0;
				obj12 = null;
				obj31 = 0;
				val2 = val3;
				val = (Enumerator<, >)(ref val2);
				val4 = (Enumerator<, >)(ref val2);
				obj39 = 0;
				goto IL_0c77;
				IL_09ac:
				NullReferenceException ex = new NullReferenceException();
				if ((nint)obj14 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = (UnityEngine.Object)1;
					obj39 = obj31;
				}
				else
				{
					if ((nint)obj14 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj39 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj31 = obj40;
				}
				goto IL_0c77;
				IL_099e:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_09ac;
				IL_097a:
				NullReferenceException ex3 = new NullReferenceException();
				goto IL_0988;
				IL_0c77:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
				object obj41 = 0;
				obj14 = (UnityEngine.Object)obj41;
				((Enumerator<, >*)val4)->Dispose();
				bool flag38 = obj39 == null;
				object obj42 = !flag38;
				obj18 = obj17;
				if (obj42 == null)
				{
					bool flag39 = (object)obj12 == null;
					object obj43 = !flag39;
					obj18 = obj17;
					OutOfMemoryException ex4 = (OutOfMemoryException)val4;
					if (obj43 == null)
					{
						return;
					}
				}
				else
				{
					OutOfMemoryException ex4 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_097a;
				IL_0988:
				NullReferenceException ex5 = new NullReferenceException();
				obj17 = obj18;
				goto IL_099e;
			}
			NullReferenceException ex6 = new NullReferenceException();
			obj12 = null;
			obj31 = 0;
			val2 = val3;
			val = (Enumerator<, >)(ref val2);
			val4 = (Enumerator<, >)(ref val2);
			rpcInfo = (RpcInfo)0;
			obj14 = (UnityEngine.Object)val;
		}
		inputDevice = (InputDevice)0;
		throw new NullReferenceException();
	}

	private float Near(Vector3 p)
	{
		//IL_0119: Invalid comparison between F8 and I4
		//IL_0128: Expected F8, but got I4
		//IL_0293: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got I4
		Vector3 position = bladeBase.position;
		Vector3 position2 = tip.position;
		object obj2 = default;
		object obj = obj2 - obj2;
		object obj4 = default;
		object obj3 = obj4 - obj4;
		object obj6 = default;
		object obj5 = obj6 - obj6;
		object obj7 = obj2 - obj2;
		object obj8 = obj4 - obj4;
		object obj9 = obj6 - obj6;
		object obj10 = obj * obj;
		object obj11 = obj3 * obj3;
		object obj12 = obj7 * obj;
		object obj13 = obj8 * obj3;
		object obj14 = obj10 + obj11;
		object obj15 = obj5 * obj5;
		object obj16 = obj12 + obj13;
		double num = (double)obj9 * (double)obj5;
		object obj17 = obj15 + obj14;
		double num2 = num + (double)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num3 = num2 / num;
		bool flag = num3 < 0.0;
		double num4 = 0.0;
		if (!flag)
		{
			bool flag2 = !(num3 > 1.0);
			num = 1.0;
			num4 = num3;
			if (!flag2)
			{
				num = 1.0;
				num4 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num5 = (double)obj3 * num4;
		double num6 = (double)obj * num4;
		double num7 = (double)obj5 * num4;
		double num8 = (double)obj4 + num5;
		double num9 = (double)obj2 + num6;
		double num10 = (double)obj6 + num7;
		double num11 = num8 - (double)obj4;
		double num12 = num9 - (double)obj2;
		double num13 = num10 - (double)obj6;
		double num14 = num12 * num12;
		double num15 = num11 * num11;
		double num16 = num14 + num15;
		double num17 = num13 * num13;
		float result = (float)num17 + (float)num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
	}

	public static void Yank(NetworkApe by, PlayerRef target)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c51: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_0c89: Expected Obj, but got I4
		//IL_0f4a: Expected Obj, but got I
		//IL_0f6c: Expected Obj, but got I4
		//IL_0cdf: Expected Obj, but got I
		//IL_0cf9: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I4
		//IL_0a7f: Expected Obj, but got I4
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected VT, but got Unknown
		//IL_0ae5: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I4
		//IL_0cc1: Expected Obj, but got I4
		//IL_0b2a: Expected Obj, but got I4
		//IL_0f8a: Expected Obj, but got I
		//IL_0d45: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I4
		//IL_0b62: Expected Obj, but got I4
		//IL_0faf: Expected Obj, but got I
		//IL_0fbf: Expected Obj, but got I
		//IL_0fe1: Expected Obj, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_0393: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I4
		//IL_0bc0: Expected Obj, but got I
		//IL_077c: Expected Obj, but got I
		//IL_0bdf: Expected Obj, but got I
		//IL_0c04: Expected I4, but got Obj
		//IL_03dd: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I4
		//IL_08ed: Expected Obj, but got I
		//IL_0917: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I4
		//IL_0e71: Expected Obj, but got I
		//IL_0e81: Expected Obj, but got I
		//IL_0ea3: Expected Obj, but got I4
		//IL_09a3: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I
		//IL_095e: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I4
		//IL_09f8: Expected Obj, but got I
		//IL_0a22: Expected Obj, but got I4
		//IL_0ec1: Expected Obj, but got I
		//IL_0edb: Expected Obj, but got I
		//IL_0eec: Expected I, but got Obj
		//IL_0f0a: Expected Obj, but got I
		//IL_0f25: Expected Obj, but got I4
		//IL_0a50: Expected VT, but got Obj
		//IL_098e: Expected Obj, but got I
		//IL_0829: Expected Obj, but got I8
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_0840: Expected Obj, but got I4
		//IL_04db: Expected Obj, but got I4
		//IL_0e53: Expected Obj, but got I4
		//IL_0503: Expected Obj, but got I8
		//IL_0513: Expected Obj, but got I
		//IL_0529: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I4
		//IL_0880: Expected F4, but got I
		//IL_0880: Expected F4, but got I
		//IL_0e2c: Expected Obj, but got I4
		//IL_0899: Expected Obj, but got I
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08c6: Expected Obj, but got I4
		//IL_056d: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I4
		//IL_0722: Expected Obj, but got I
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected Obj, but got Unknown
		//IL_0605: Expected Obj, but got I
		//IL_0627: Expected Obj, but got I4
		//IL_0d63: Expected Obj, but got I
		//IL_0d73: Expected Obj, but got I
		//IL_0d95: Expected Obj, but got I4
		//IL_0fff: Expected Obj, but got I
		//IL_066e: Expected Obj, but got I4
		//IL_06d1: Expected Obj, but got I
		//IL_0db3: Expected Obj, but got I
		//IL_0dcd: Expected Obj, but got I
		//IL_0dde: Expected I, but got Obj
		//IL_0dfc: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I
		//IL_06ac: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		SoulScythe soulScythe = Prefab();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = soulScythe == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkApe networkApe = default;
		bool flag5 = (UnityEngine.Object)networkApe == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = networkApe.head == null;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v21+E4]");
		bool flag11 = (nint)0 == 0;
		object obj15 = !flag11;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj11;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v21+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v12+E4]");
		bool flag12 = (nint)0 == 0;
		object obj18 = !flag12;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17;
		if ((UnityEngine.Object)obj17 != null)
		{
			object obj19 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v122+E4]");
			bool flag13 = (nint)0 == 0;
			object obj20 = !flag13;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj21 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v126+E4]");
			bool flag14 = (nint)0 == 0;
			object obj22 = !flag14;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v126+A0]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v127+E4]");
			bool flag15 = (nint)0 == 0;
			object obj27 = !flag15;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v85+6D0]");
			object obj28 = 0 - target;
			bool flag16 = obj28 == null;
			flag17 = flag16;
		}
		else
		{
			flag17 = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D98]");
		object obj30 = 0;
		List<System.__Canon> list = default;
		list._002Ector();
		List<System.__Canon> list2;
		if (flag17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj31 = 0;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v67+E4]");
			bool flag18 = (nint)0 == 0;
			object obj33 = !flag18;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj34 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v71+E4]");
			bool flag19 = (nint)0 == 0;
			object obj35 = !flag19;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj34 = obj31;
			}
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v71+A0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X9_v20+8]");
			UnityEngine.Object obj38 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v45+E4]");
			bool flag20 = (nint)0 == 0;
			object obj39 = !flag20;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X9_v20+8]");
			bool flag21 = (UnityEngine.Object)0 != null;
			bool flag22 = !flag21;
			list2 = list;
			object obj40 = 0;
			if (!flag22)
			{
				object obj41 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X22_v12 (UnityEngine.Object)+68]");
				UnityEngine.Object obj42 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v85+E4]");
				bool flag23 = (nint)0 == 0;
				object obj43 = !flag23;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag24 = obj42 != null;
				bool flag25 = !flag24;
				list2 = list;
				obj40 = 0;
				if (!flag25)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X22_v12 (UnityEngine.Object)+68]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v55+20]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v55+20]");
					bool flag26 = (nint)0 == 0;
					list2 = list;
					obj40 = 0;
					if (!flag26)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X27_v7+18]");
						bool flag27 = (nint)0 < (nint)1;
						list2 = list;
						obj40 = 0;
						if (!flag27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X27_v7+18]");
							object obj46 = 0 & 0xFFFFFFFFL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB20]");
							object obj47 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v55+20]");
							object obj48 = (nint)0 + (nint)32;
							object obj50 = default;
							object obj49 = obj50;
							object obj51 = 0;
							List<System.__Canon> list3 = list;
							object obj52 = 0;
							UnityEngine.Object obj53 = null;
							Predicate<System.__Canon> predicate2 = default;
							IEnumerable<System.__Canon> enumerable = default;
							while (true)
							{
								bool flag28 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46);
								object obj54 = !flag28;
								if (obj54 != null)
								{
									break;
								}
								object obj55 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X29_v7+v343 @ X28_v8*8]");
								UnityEngine.Object obj56 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v90+E4]");
								bool flag29 = (nint)0 == 0;
								object obj57 = !flag29;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X29_v7+v343 @ X28_v8*8]");
								bool flag30 = (UnityEngine.Object)0 != null;
								bool flag31 = !flag30;
								obj40 = 0;
								obj53 = null;
								if (!flag31)
								{
									object obj58 = obj47;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X22_v17 (UnityEngine.Object)+20]");
									obj42 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X0_v96+E4]");
									bool flag32 = (nint)0 == 0;
									object obj59 = !flag32;
									if (obj59 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj58 = obj47;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X0_v96+A0]");
									object obj60 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v71+8]");
									Predicate<System.__Canon> predicate = (Predicate<System.__Canon>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v71+8]");
									bool flag33 = (nint)0 == 0;
									object obj61 = !flag33;
									if (obj61 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X0_v96+E4]");
										bool flag34 = (nint)0 == 0;
										object obj62 = !flag34;
										if (obj62 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											object obj63 = obj47;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v77+A0]");
											obj60 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA8]");
										object obj64 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB18]");
										object obj65 = 0;
										predicate2._002Ector(obj60, (IntPtr)obj65);
										object obj66 = obj47;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X8_v76+A0]");
										object obj67 = (nint)0 + (nint)8;
										obj67 = predicate2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										obj49 = 0;
										predicate = predicate2;
										list3 = list;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D68]");
									object obj68 = 0;
									obj40 = obj68;
									bool flag35 = Array.Exists((System.__Canon[])(object)obj42, predicate);
									bool flag36 = !flag35;
									obj53 = (UnityEngine.Object)(object)predicate;
									if (!flag36)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9070]");
										object obj69 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAF0]");
										object obj70 = 0;
										obj40 = obj70;
										list3.AddRange(enumerable);
										obj53 = (UnityEngine.Object)enumerable;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X27_v7+18]");
								obj46 = 0;
								obj51++;
								object obj71 = obj51;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X27_v7+18]");
								bool flag37 = (nint)obj71 < 0;
								obj50 = obj49;
								list2 = list3;
								obj52 = obj40;
								if (flag37)
								{
									continue;
								}
								goto IL_076c;
							}
							goto IL_0c09;
						}
					}
				}
			}
			goto IL_076c;
		}
		object obj72 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v28+E4]");
		bool flag38 = (nint)0 == 0;
		object obj73 = !flag38;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef player = (PlayerRef)(target & 0xFFFFFFFFL);
		NetworkApe networkApe2 = NetworkApe.Find(player);
		object obj74 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v19+E4]");
		bool flag39 = (nint)0 == 0;
		object obj75 = !flag39;
		if (obj75 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag40 = (UnityEngine.Object)networkApe2 == (UnityEngine.Object)null;
		bool flag41 = !flag40;
		object obj76 = !flag41;
		if (obj76 == null)
		{
			object obj77 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v35+E4]");
			bool flag42 = (nint)0 == 0;
			object obj78 = !flag42;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (networkApe2.ape == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAE8]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAF0]");
			object obj80 = 0;
			object obj40 = obj80;
			IEnumerable<System.__Canon> enumerable2 = default;
			list.AddRange(enumerable2);
			list2 = list;
			uint num = (uint)(int)enumerable2;
			goto IL_08dd;
		}
		return;
		IL_08dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB20]");
		object obj81 = 0;
		object obj82 = obj81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v48+E4]");
		bool flag43 = (nint)0 == 0;
		object obj83 = !flag43;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj82 = obj81;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v48+A0]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v35+10]");
		Predicate<System.__Canon> match = (Predicate<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v35+10]");
		bool flag44 = (nint)0 == 0;
		object obj85 = !flag44;
		if (obj85 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v48+E4]");
			bool flag45 = (nint)0 == 0;
			object obj86 = !flag45;
			if (obj86 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj87 = obj81;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X8_v39+A0]");
				obj84 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B60]");
			object obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB10]");
			object obj89 = 0;
			Predicate<System.__Canon> predicate3 = default;
			predicate3._002Ector(obj84, (IntPtr)obj89);
			object obj90 = obj81;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v38+A0]");
			object obj91 = (nint)0 + (nint)16;
			obj91 = predicate3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj50 = 0;
			match = predicate3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAF8]");
		object scythe = 0;
		int num2 = list2.RemoveAll(match);
		if (list2._size != 0)
		{
			Vector3 position = networkApe.head.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB08]");
			object obj92 = 0;
			object obj93 = obj92;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v54+E4]");
			bool flag46 = (nint)0 == 0;
			object obj94 = !flag46;
			if (obj94 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SoulGhost.Spawn((List<SkinnedMeshRenderer>)(object)list2, (Vector3)soulScythe, (SoulScythe)scythe);
		}
		return;
		IL_0c09:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_076c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB98]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v79+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v79+18]");
			bool flag47 = (nint)0 == 1;
			_ = 4;
			if (!flag47)
			{
				_ = 5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v79+18]");
				bool flag48 = (nint)0 < (nint)1;
				uint num = 2u;
				if (flag48)
				{
					goto IL_08dd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v79+18]");
				object obj96 = 0 & 0xFFFFFFFFL;
				object obj98 = default;
				object obj97 = obj98 + 32;
				object obj99 = 0;
				InputDevice inputDevice = default;
				while (true)
				{
					bool flag49 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj99) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj96);
					object obj100 = !flag49;
					if (obj100 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X24_v11+v710 @ X23_v14*4]");
					InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					bool flag50 = inputDevice.SendHapticImpulse(0u, num3, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v79+18]");
					obj96 = 0;
					obj99++;
					object obj101 = obj99;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v79+18]");
					bool flag51 = (nint)obj101 < 0;
					object obj40 = 0;
					num = 0u;
					if (flag51)
					{
						continue;
					}
					goto IL_08dd;
				}
			}
		}
		goto IL_0c09;
	}

	private static SoulScythe Prefab()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v13+A0]");
			return (SoulScythe)0;
		}
		int count = CosmeticCatalog.Count;
		if (count >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB30]");
			object obj8 = 0;
			SoulScythe soulScythe = null;
			object obj9 = 0;
			int num = 1;
			object obj13 = default;
			while (true)
			{
				CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num);
				if (entry != null)
				{
					object obj10 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v16+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = entry.prefab != null;
					bool flag4 = !flag3;
					obj9 = 0;
					if (!flag4)
					{
						if ((object)entry.prefab == null)
						{
							goto IL_0244;
						}
						obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
						object obj12 = obj13 & 1;
						bool flag5 = obj12 == null;
						object obj14 = !flag5;
						if (obj14 != null)
						{
							object obj15 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v10+A0]");
							object obj16 = 0;
							obj16 = soulScythe;
							object obj17 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							return soulScythe;
						}
					}
					num++;
					int count2 = CosmeticCatalog.Count;
					if (num > count2)
					{
						break;
					}
					continue;
				}
				goto IL_0244;
				IL_0244:
				return (SoulScythe)(object)new NullReferenceException();
			}
		}
		return null;
	}

	public SoulScythe()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002c: Expected I4, but got I8
		//IL_003e: Expected F4, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7138]");
		object obj = 0;
		hand = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FC10]");
		arcSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, float> dictionary = default;
		dictionary._002Ector();
		object obj2 = this + 144;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
