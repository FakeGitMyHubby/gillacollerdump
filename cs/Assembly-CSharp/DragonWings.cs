using Cpp2ILInjected;
using UnityEngine;

public class DragonWings : MonoBehaviour
{
	public Transform wingL;

	public Transform wingR;

	public Transform tipL;

	public Transform tipR;

	public Vector3 fold;

	public Vector3 tipFold;

	public float airUp;

	public float airAlong;

	public float stiffness;

	public float damping;

	public float beat;

	public float beatRate;

	private Quaternion restL;

	private Quaternion restR;

	private Quaternion restTipL;

	private Quaternion restTipR;

	private Vector3 lastPos;

	private Vector3 vel;

	private float open;

	private float openSpeed;

	private float airFor;

	private float groundFor;

	private float phase;

	private float flap;

	private bool started;

	private bool ready;

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
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
		bool flag2 = wingL != null;
		bool flag3 = !flag2;
		Object obj4 = null;
		Quaternion quaternion = default;
		if (!flag3)
		{
			Quaternion localRotation = wingL.localRotation;
			restL = quaternion;
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
		bool flag5 = wingR != null;
		bool flag6 = !flag5;
		Object obj7 = null;
		if (!flag6)
		{
			Quaternion localRotation2 = wingR.localRotation;
			restR = quaternion;
			obj7 = null;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = tipL != null;
		bool flag9 = !flag8;
		Object obj10 = null;
		if (!flag9)
		{
			Quaternion localRotation3 = tipL.localRotation;
			restTipL = quaternion;
			obj10 = null;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj12 = !flag10;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tipR != null)
		{
			Quaternion localRotation4 = tipR.localRotation;
			restTipR = quaternion;
		}
		ready = true;
	}

	private void OnEnable()
	{
		started = false;
	}

	private void LateUpdate()
	{
		//IL_0012: Invalid comparison between F4 and I4
		//IL_0023: Expected Obj, but got I4
		//IL_002c: Invalid comparison between F4 and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0118: Expected VT, but got F4
		//IL_04cb: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I
		//IL_04eb: Expected VT, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_0510: Expected VT, but got Obj
		//IL_09ec: Invalid comparison between F8 and I4
		//IL_09fb: Expected F8, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_058b: Expected VT, but got F4
		//IL_05a4: Expected VT, but got F4
		//IL_0231: Invalid comparison between F4 and I
		//IL_0637: Invalid comparison between F4 and I4
		//IL_0646: Invalid comparison between F4 and I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_066e: Expected Obj, but got F4
		//IL_06ad: Expected Obj, but got I4
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I4
		//IL_0274: Invalid comparison between F4 and I
		//IL_028b: Expected F8, but got I4
		//IL_05df: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I4
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I4
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected Obj, but got Unknown
		//IL_02ca: Expected F8, but got I4
		//IL_0342: Expected F8, but got I
		//IL_0352: Invalid comparison between F8 and I
		//IL_0746: Invalid comparison between F8 and I4
		//IL_0755: Expected F8, but got I4
		//IL_0788: Invalid comparison between F8 and I4
		//IL_0797: Expected F8, but got I4
		//IL_07ae: Invalid comparison between F8 and I4
		//IL_0835: Expected F8, but got I4
		//IL_08ca: Invalid comparison between F8 and I4
		//IL_08d9: Expected F8, but got I4
		//IL_0958: Expected F4, but got I
		//IL_0958: Expected F4, but got VT
		//IL_0984: Expected F4, but got I
		//IL_0984: Expected F4, but got VT
		float deltaTime = Time.deltaTime;
		bool flag = deltaTime < 0f;
		object obj = !flag;
		bool flag2 = deltaTime == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		float num;
		float num3 = default;
		float num4;
		float num7;
		Vector3 vector;
		object obj4;
		float num9 = default;
		float num10;
		float num8;
		if (~(started ? 1u : 0u) == 0)
		{
			num = deltaTime - (float)lastPos;
			float num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+B8]");
			num4 = num2 - 0f;
			float num5 = num * num;
			float num6 = num4 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			num7 = num5 + num6;
			if (!((double)num7 > 25.0))
			{
				vector = vel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+C4]");
				obj4 = 0;
				num8 = num9;
				num10 = deltaTime;
				goto IL_0989;
			}
		}
		lastPos = (Vector3)deltaTime;
		num8 = num3;
		num7 = deltaTime;
		num10 = deltaTime;
		num = deltaTime - deltaTime;
		num4 = num3 - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v32+A0]");
		object obj7 = 0;
		vector = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v33+8]");
		obj4 = 0;
		started = true;
		vel = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v33+8]");
		_ = 0;
		goto IL_0989;
		IL_0989:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num11 = num4 / num10;
		float num12 = num10 * -10f;
		float num13 = num / num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num14 = 1.0 - (double)num12;
		bool flag3 = num14 < 0.0;
		double num15 = 0.0;
		if (!flag3)
		{
			bool flag4 = !(num14 > 1.0);
			num15 = num14;
			if (!flag4)
			{
				num15 = 1.0;
			}
		}
		float num16 = num13 - (float)vector;
		float num17 = num11 - (float)obj4;
		object obj8 = default;
		float num18 = num16 * (float)obj8;
		float num19 = num17 * (float)num15;
		float num20 = (float)vector + num18;
		float num21 = (float)obj4 + num19;
		vel = (Vector3)num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		lastPos = (Vector3)deltaTime;
		bool flag5 = num19 > airUp;
		float num22 = deltaTime;
		object obj10 = default;
		if (!flag5)
		{
			num22 = deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj9 = 0;
			obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num22 = deltaTime;
			}
			float num23 = num20 * num20;
			float num24 = num21 * num21;
			float num25 = num23 + num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			if (!(num25 > airAlong))
			{
				airFor = 0f;
				float num26 = num22 + groundFor;
				groundFor = num26;
				goto IL_0262;
			}
		}
		groundFor = 0f;
		float num27 = (airFor = num22 + airFor);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		bool flag7 = num27 > 0f;
		float num28 = num22;
		double num29 = 1.0;
		object obj12 = obj10;
		if (!flag7)
		{
			goto IL_0262;
		}
		goto IL_0617;
		IL_0617:
		float num30 = num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA38]");
		float num31 = num30 - 0f;
		bool flag8 = num31 < 0f;
		bool flag9 = num31 == 0f;
		float num32 = num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA38]");
		object obj13 = num32 ^ 0;
		object obj14 = num28 ^ num31;
		object obj15 = obj13 & obj14;
		bool flag10 = (nint)obj15 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		bool flag11 = flag8 == flag10;
		object obj16 = !flag9;
		object obj17 = flag11 & obj16;
		object obj18 = ~obj17;
		object obj19 = ((obj18 != null) ? ((object)1) : ((object)2));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		object obj20 = 0 / obj19;
		float num33 = open;
		float num34 = openSpeed;
		num33 = num9;
		num34 = num3;
		object obj21 = default;
		obj19 = obj21;
		double num40;
		double num42;
		do
		{
			double num35 = num29 - (double)num33;
			float num36 = num34 * damping;
			obj19--;
			double num37 = (double)stiffness * num35;
			double num38 = num37 - (double)num36;
			double num39 = (double)obj20 * num38;
			num40 = (double)num34 + num39;
			double num41 = (double)obj20 * num40;
			num42 = (double)num33 + num41;
		}
		while ((nint)obj19 != 1);
		open = (float)num42;
		openSpeed = (float)num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
		double num43 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
		if (!(num42 < 0.0))
		{
			bool flag12 = !(num42 > 1.25);
			num43 = num42;
			if (!flag12)
			{
				num43 = 1.25;
			}
		}
		open = (float)num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+C0]");
		double num44 = 0.0 / 3.0;
		bool flag13 = num44 < 0.0;
		double num45 = 0.0;
		if (!flag13)
		{
			bool flag14 = !(num44 > 1.0);
			num45 = num44;
			if (!flag14)
			{
				num45 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+C0]");
		double num46 = 0.0 / -3.0;
		bool flag15 = num46 < 0.0;
		double num47 = 0.0;
		if (!flag15)
		{
			bool flag16 = !(num46 > 1.0);
			num47 = num46;
			if (!flag16)
			{
				num47 = 1.0;
			}
		}
		bool flag17 = num43 < 0.0;
		float num48 = num28 * beatRate;
		float num49 = num48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
		float num50 = num49 * 0f;
		double num51 = num45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		double num52 = num51 + 0.0;
		float num53 = num50 + num50;
		double num54 = num52 * (double)num53;
		double num55 = (double)phase + num54;
		phase = (float)num55;
		double num56 = 0.0;
		if (!flag17)
		{
			bool flag18 = !(num43 > 1.0);
			num56 = num43;
			if (!flag18)
			{
				num56 = 1.0;
			}
		}
		double num57 = num47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		double num58 = num57 * 0.0;
		double num59 = num45 + num58;
		double num60 = num59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		double num61 = num60 + 0.0;
		double num62 = num61 * num56;
		float num63 = num28 * -6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num64 = 1.0 - (double)num63;
		bool flag19 = num64 < 0.0;
		double num65 = 0.0;
		if (!flag19)
		{
			bool flag20 = !(num64 > 1.0);
			num65 = num64;
			if (!flag20)
			{
				num65 = 1.0;
			}
		}
		double num66 = num62 - (double)flap;
		double num67 = num66 * num65;
		double num68 = (double)flap + num67;
		flap = (float)num68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Transform wing = wingL;
		Transform tip = tipL;
		Quaternion quaternion = restL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+74]");
		Quaternion rest = default;
		Quaternion tipRest = default;
		Pose(wing, tip, rest, tipRest, (float)quaternion, 0f);
		Transform wing2 = wingR;
		Transform tip2 = tipR;
		Quaternion quaternion2 = restR;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+84]");
		Pose(wing2, tip2, rest, tipRest, (float)quaternion2, 0f);
		return;
		IL_0262:
		float num69 = groundFor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		bool flag21 = num69 > 0f;
		num28 = num22;
		num29 = 0.0;
		obj12 = obj10;
		if (!flag21)
		{
			bool flag22 = !((double)open > 0.5);
			num28 = num22;
			num29 = 0.0;
			obj12 = obj10;
			if (!flag22)
			{
				num28 = num22;
				num29 = 1.0;
				obj12 = obj10;
			}
		}
		goto IL_0617;
	}

	public void Show(float openness)
	{
		//IL_0016: Expected Obj, but got I4
		//IL_0065: Expected F4, but got I
		//IL_0065: Expected F4, but got VT
		//IL_0091: Expected F4, but got I
		//IL_0091: Expected F4, but got VT
		bool flag = (byte)(~(ready ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			Awake();
		}
		open = openness;
		Transform wing = wingL;
		Transform tip = tipL;
		Quaternion quaternion = restL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+74]");
		Quaternion rest = default;
		Quaternion tipRest = default;
		Pose(wing, tip, rest, tipRest, (float)quaternion, 0f);
		Transform wing2 = wingR;
		Transform tip2 = tipR;
		Quaternion quaternion2 = restR;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+84]");
		Pose(wing2, tip2, rest, tipRest, (float)quaternion2, 0f);
	}

	private void Pose(Transform wing, Transform tip, Quaternion rest, Quaternion tipRest, float side, float swing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I4
		//IL_0060: Expected VT, but got I4
		//IL_031f: Expected Obj, but got I4
		//IL_02df: Expected VT, but got I4
		//IL_02e7: Expected VT, but got F8
		//IL_02f0: Expected VT, but got I4
		//IL_0391: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = 1.0 - (double)open;
		bool flag2 = wing != null;
		bool flag3 = !flag2;
		Quaternion quaternion = (Quaternion)0;
		float num3 = default;
		float num2 = num3;
		Vector3 euler = default;
		if (!flag3)
		{
			double num4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonWings)+48]");
			double num5 = num4 * 0.0;
			object obj4 = default;
			float num6 = num3 * (float)obj4;
			double num7 = num5 * (double)num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			double num8 = num * (double)fold;
			double num9 = (double)num6 + num7;
			double num10 = num8 * (double)obj4;
			double num11 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num12 = num11 * 0.0;
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
			float num14 = default;
			float num13 = num14 * (float)obj4;
			float num15 = side * (float)num12;
			double num16 = (double)num14 * num10;
			float num18 = default;
			float num17 = num18 * (float)obj4;
			float num19 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num20 = num19 * 0f;
			float num22 = default;
			float num21 = num22 * (float)obj4;
			double num23 = (double)num14 * num12;
			float num24 = side * (float)obj4;
			float num25 = num13 - num15;
			float num26 = num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num27 = num26 * 0f;
			float num28 = side * (float)num10;
			double num29 = num16 + (double)num17;
			float num30 = side;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num31 = num30 * 0f;
			float num32 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num33 = num32 * 0f;
			float num34 = num20 + num21;
			double num35 = (double)num18 * num12;
			float num36 = num22 * (float)num12;
			double num37 = num23 + (double)num24;
			float num38 = num22 * (float)num10;
			double num39 = (double)num18 * num10;
			float num40 = num25 - num27;
			float num41 = num31 + (float)num29;
			double num42 = num35 + (double)num34;
			float num43 = num38 + (float)num37;
			num14 = num40 - (float)num39;
			num18 = num41 - num36;
			num22 = (float)num42 - num28;
			num2 = num43 - num33;
			wing.localRotation = (Quaternion)0;
			euler = (Vector3)num10;
			quaternion = (Quaternion)0;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tip != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(ref euler);
			tip.localRotation = (Quaternion)0;
		}
	}

	public DragonWings()
	{
		//IL_0012: Expected VT, but got I
		//IL_0031: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D950]");
		fold = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E080]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F600]");
		stiffness = 0f;
		base._002Ector();
	}
}
