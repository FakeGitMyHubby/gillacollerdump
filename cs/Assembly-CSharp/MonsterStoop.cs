using Cpp2ILInjected;
using UnityEngine;

public class MonsterStoop : MonoBehaviour
{
	public Transform root;

	public Transform neck;

	public Transform head;

	public Transform upL;

	public Transform loL;

	public Transform endL;

	public Transform upR;

	public Transform loR;

	public Transform endR;

	public float topOverHead;

	public float clearance;

	public float lookAhead;

	public float mostDown;

	public float mostLean = 32f;

	private float Down__BackingField;

	private float ceiling = 1f / 0f;

	private float nextLook;

	private Animator anim;

	private const int Solid = default(int);

	private const float LookEvery = default(float);

	private const float Speed = default(float);

	public float Down
	{
		get
		{
			return Down__BackingField;
		}
		private set
		{
			Down__BackingField = value;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F01C");
		object obj2 = this + 136;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private unsafe void Look()
	{
		//IL_018e: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected F8, but got I
		//IL_01c6: Expected F8, but got I
		//IL_0223: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I4
		//IL_00db: Expected VT, but got I8
		//IL_00db: Expected VT, but got Ref
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02c1: Expected F4, but got I
		float time = Time.time;
		ceiling = 1f / 0f;
		float num = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		float num2 = (nextLook = num + 0f);
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9+1C]");
		double num3 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9+20]");
		double num4 = 0.0;
		object obj4 = default;
		double num5 = (double)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9+20]");
		double num6 = num5 + 0.0;
		float num7 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9+18]");
		float num8 = num7 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		float num9 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9+1C]");
		float num10 = num9 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj5 = 0;
		object obj6 = 0;
		float num11 = num8;
		float num12 = num10;
		object obj11 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		double num18 = default;
		bool flag2;
		do
		{
			Transform transform2 = base.transform;
			Vector3 forward = transform2.forward;
			object obj7 = obj;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v12+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num13 = lookAhead * (float)obj6;
			double num14 = (double)num13 * 0.5;
			double num15 = (double)num12 * num14;
			double num16 = num3 * num14;
			double num17 = num4 * num14;
			num12 = num8 + (float)num15;
			num3 = (double)num10 + num16;
			num4 = num6 + num17;
			if (Physics.Raycast((Vector3)(&obj11), (Vector3)4294961403L, out *(RaycastHit*)1, num12, 0, queryTriggerInteraction))
			{
				num12 = ceiling;
				if (!((double)ceiling < num18))
				{
					num12 = (float)num18;
				}
				ceiling = num12;
				num3 = num18;
			}
			obj6++;
			flag2 = (nint)obj6 != 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v13+18]");
			num11 = 0f;
		}
		while (flag2);
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06b5: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_01fc: Invalid comparison between F4 and I4
		//IL_020b: Expected F4, but got I4
		//IL_071d: Invalid comparison between F4 and I4
		//IL_0730: Expected Obj, but got F4
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_076f: Expected Obj, but got I4
		//IL_079f: Expected Obj, but got I4
		//IL_07b7: Invalid comparison between F4 and I4
		//IL_07d9: Expected Obj, but got I4
		//IL_080d: Invalid comparison between F4 and I
		//IL_0285: Expected F8, but got I
		//IL_02a5: Invalid comparison between F4 and I4
		//IL_02b4: Expected F8, but got I4
		//IL_083b: Expected Obj, but got I
		//IL_0853: Expected Obj, but got I
		//IL_08bb: Expected VT, but got I4
		//IL_0573: Expected VT, but got I4
		//IL_059d: Expected Obj, but got I4
		//IL_0638: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = head == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = root == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (anim != null && !anim.enabled)
		{
			return;
		}
		float time = Time.time;
		if (!(time < nextLook))
		{
			Look();
		}
		Vector3 position = head.position;
		float num = nextLook + topOverHead;
		float num2 = num + clearance;
		float num3 = num2 - ceiling;
		bool flag8 = num3 < 0f;
		float num4 = 0f;
		if (!flag8)
		{
			bool flag9 = !(num3 > mostDown);
			num4 = num3;
			if (!flag9)
			{
				num4 = mostDown;
			}
		}
		float deltaTime = Time.deltaTime;
		float num5 = num4 - Down__BackingField;
		float num6 = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E0]");
		float num7 = num6 * 0f;
		float num8 = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E0]");
		float num9 = num8 * 0f;
		float num10 = 0f - num9;
		bool flag10 = num5 < 0f;
		object obj10 = num5 ^ num5;
		object obj11 = num5 & obj10;
		bool flag11 = (nint)obj11 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag12 = flag10 == flag11;
		object obj12 = !flag12;
		object obj13 = ~obj12;
		if (obj13 != null)
		{
			num10 = num7;
		}
		bool flag13 = num5 < num7;
		object obj14 = !flag13;
		float num11 = num5 - num7;
		bool flag14 = num11 == 0f;
		float num12 = Down__BackingField + num10;
		object obj15 = !flag14;
		object obj16 = obj14 & obj15;
		object obj17 = ~obj16;
		if (obj17 != null)
		{
			num12 = num4;
		}
		float num13 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		bool flag15 = num13 < 0f;
		Down__BackingField = num12;
		if (flag15)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		double num14 = 0.0;
		float num15 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num16 = num15 / 0f;
		bool flag16 = num16 < 0f;
		double num17 = 0.0;
		if (!flag16)
		{
			bool flag17 = !((double)num16 > 1.0);
			num17 = num16;
			num14 = 1.0;
			if (!flag17)
			{
				num17 = 1.0;
				num14 = 1.0;
			}
		}
		Vector3 position2 = endL.position;
		Vector3 position3 = endR.position;
		Quaternion rotation = endL.rotation;
		Quaternion rotation2 = endR.rotation;
		Transform transform = base.transform;
		Vector3 right = transform.right;
		double num18 = (double)mostLean * num17;
		Vector3 position4 = root.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v15+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v16+2C]");
		float num19 = 0f * Down__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v16+28]");
		float num20 = 0f * Down__BackingField;
		double num21 = num14 + (double)num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E0]");
		float num22 = 0f + num19;
		root.position = (Vector3)0;
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis((float)num18, ref axis);
		Quaternion rotation3 = root.rotation;
		float num23 = num19 * num19;
		float num24 = (float)num18 * (float)num18;
		float num25 = num19 * num22;
		float num26 = num22 * num19;
		double num27 = (double)num19 * num21;
		double num28 = num21 * (double)num19;
		float num29 = num19 * (float)num18;
		float num30 = (float)num18 * num19;
		float num31 = num23 - num24;
		double num32 = num21 * num21;
		float num33 = (float)num18 * num22;
		float num34 = num25 + num26;
		float num35 = (float)num18 * (float)num21;
		double num36 = (double)num22 * num21;
		double num37 = num27 + num28;
		float num38 = num22 * (float)num18;
		double num39 = num21 * num18;
		float num40 = num29 + num30;
		double num41 = num21 * (double)num22;
		float num42 = num22 * num22;
		float num43 = num31 - (float)num32;
		float num44 = num35 + num34;
		float num45 = num38 + (float)num37;
		double num46 = num41 + (double)num40;
		float num47 = num43 - num42;
		float num48 = num44 - (float)num39;
		float num49 = num45 - num33;
		double num50 = num46 - num36;
		root.rotation = (Quaternion)0;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v43+E4]");
		bool flag18 = (nint)0 == 0;
		object obj22 = !flag18;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (neck != null)
		{
			float num51 = (float)num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC84]");
			float angle = num51 * 0f;
			Quaternion quaternion2 = Quaternion.Internal_AngleAxis(angle, ref axis);
			Quaternion rotation4 = neck.rotation;
			neck.rotation = (Quaternion)0;
		}
		Vector3 hock = default;
		Quaternion turn = default;
		Vector3 side = default;
		Leg(upL, loL, endL, hock, turn, side);
		Leg(upR, loR, endR, hock, turn, side);
	}

	private void Leg(Transform up, Transform lo, Transform end, Vector3 hock, Quaternion turn, Vector3 side)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_005f: Invalid comparison between F8 and Obj
		//IL_006e: Expected F8, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_00b2: Invalid comparison between F8 and I4
		//IL_00c1: Expected F8, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01f8: Expected VT, but got I4
		//IL_020b: Expected VT, but got I4
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		object obj = default;
		double num = (double)obj + 1.25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
		object obj2 = obj + 0;
		bool flag = (object)num == obj2;
		double num2 = 0.0;
		if (!flag)
		{
			double num3 = (double)obj - num;
			double num4 = (double)obj2 - num;
			double num5 = num3 / num4;
			bool flag2 = num5 < 0.0;
			num2 = 0.0;
			if (!flag2)
			{
				bool flag3 = !(num5 > 1.0);
				num2 = num5;
				if (!flag3)
				{
					num2 = 1.0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v9+A0]");
		object obj5 = 0;
		Transform transform3 = base.transform;
		double num6 = num2 * (double)Down__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v10+24]");
		double num7 = 0.0 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v10+28]");
		double num8 = 0.0 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v10+2C]");
		double num9 = 0.0 * num6;
		object obj7 = default;
		double num10 = (double)obj7 + num7;
		Vector3 forward = transform3.forward;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MonsterAvatar.Reach(up, lo, end, (Vector3)0, hock, (Vector3)turn, (float)num10);
		end.rotation = (Quaternion)0;
	}

	public MonsterStoop()
	{
		//IL_0028: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DEA0]");
		topOverHead = 0f;
		base._002Ector();
	}
}
