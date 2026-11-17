using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class TryOnTube : MonoBehaviour
{
	public Transform turntable;

	public CosmeticWearer ape;

	public ApeColor apeColour;

	public Transform ring;

	public float ringRadius = 0.32f;

	public Transform[] fingertips;

	public float idleSpin = 18f;

	public Renderer glow;

	public float hover;

	public float bob;

	public float bobTime;

	public float rock;

	private int finger = -1;

	private float lastAngle;

	private float spin;

	private float flash;

	private Vector3 apeRest;

	private Vector3 monsterRest;

	private Quaternion apeRestTurn;

	private Quaternion monsterRestTurn;

	private bool rested;

	private MonsterDisplay monster;

	private MonsterDirector.Entry monsterShown;

	private const float MonsterTaller = default(float);

	private const float MonsterWidest = default(float);

	private static readonly int BaseColor;

	private MaterialPropertyBlock block;

	public string Showing
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I4
			//IL_0044: Expected Obj, but got I
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
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
			bool flag2 = monster != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAC0]");
			object result = 0;
			if (flag2)
			{
				object obj4 = monsterShown + 16;
				if (monsterShown != null)
				{
					result = obj4;
				}
			}
			return (string)result;
		}
	}

	private void Start()
	{
		InYourColour();
		Rest();
	}

	private void Rest()
	{
		//IL_012e: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		bool flag = (byte)(~(rested ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = ape == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				Transform transform = ape.transform;
				Vector3 localPosition = transform.localPosition;
				Vector3 vector = default;
				apeRest = vector;
				Transform transform2 = ape.transform;
				Quaternion localRotation = transform2.localRotation;
				apeRestTurn = (Quaternion)vector;
				rested = true;
			}
		}
	}

	private void InYourColour()
	{
		//IL_0010: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I
		//IL_0252: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(apeColour != null))
		{
			return;
		}
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		object obj13 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X20_v3 (UnityEngine.Object)+48]");
		if ((UnityEngine.Object)0 != null)
		{
			ApeColor apeColor = apeColour;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X20_v3 (UnityEngine.Object)+48]");
			object obj15 = 0;
			Color furColor = apeColor.furColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v12+40]");
			object obj16 = furColor - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v21 (ApeColor)+48]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v12+48]");
			object obj17 = num - 0;
			object obj18 = obj16 * obj16;
			object obj19 = obj17 * obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj21 = default;
			object obj20 = obj18 + obj21;
			object obj22 = obj19 + obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj23 = obj19 + obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
			if ((nint)obj23 >= 0)
			{
				apeColor.SetColor((Color)0);
			}
		}
	}

	private void Update()
	{
		//IL_0028: Expected I4, but got I8
		//IL_0042: Expected Obj, but got I4
		//IL_0417: Expected I4, but got I8
		//IL_0431: Expected Obj, but got I4
		//IL_0062: Expected F4, but got I
		//IL_0360: Invalid comparison between F8 and I4
		//IL_036f: Expected F8, but got I4
		//IL_0093: Expected I4, but got I8
		//IL_03c6: Invalid comparison between F4 and I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I
		//IL_015c: Expected VT, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I4
		//IL_01c9: Expected I, but got Obj
		//IL_022a: Invalid comparison between F4 and I4
		//IL_0239: Expected F4, but got I4
		//IL_04cf: Expected I, but got Obj
		//IL_0250: Invalid comparison between F4 and I4
		//IL_025f: Expected F4, but got I4
		//IL_02d2: Expected Obj, but got I4
		//IL_0276: Invalid comparison between F4 and I4
		//IL_0510: Expected F4, but got I
		//IL_0510: Expected F4, but got I
		//IL_0519: Expected I, but got Obj
		InYourColour();
		float deltaTime = Time.deltaTime;
		int num = (int)(finger & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		int num2;
		if (obj != null)
		{
			num2 = (finger = Touching(0f));
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			num2 = Touching(0f);
			if (num2 != finger)
			{
				finger = -1;
				goto IL_031a;
			}
		}
		int num3 = (int)(num2 & 0x80000000L);
		bool flag2 = num3 == 0;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			goto IL_031a;
		}
		Transform[] array = fingertips;
		float num4;
		float num10;
		nint num5;
		if (fingertips != null)
		{
			bool flag3 = num2 < array.Length;
			object obj3 = !flag3;
			if (obj3 != null)
			{
				goto IL_03fe;
			}
			object obj4 = fingertips + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+20]");
				Vector3 position = ((Transform)0).position;
				num4 = Angle((Vector3)0);
				object obj5 = lastAngle & 0x7FFFFFFF;
				bool flag4 = (nint)obj5 < 2139095040;
				object obj6 = !flag4;
				object obj7 = obj5 - 2139095040;
				bool flag5 = obj7 == null;
				object obj8 = !flag5;
				object obj9 = obj6 & obj8;
				num5 = unchecked((nint)null);
				if (obj9 != null)
				{
					goto IL_030b;
				}
				float num6 = num4 - lastAngle;
				float num7 = num6 / 1.13587E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				float num8 = num7 * 1.13587E+09f;
				float num9 = num6 - num8;
				bool flag6 = num9 < 0f;
				num10 = 0f;
				if (!flag6)
				{
					bool flag7 = num9 > 1.13587E+09f;
					float num11 = 1.13587E+09f;
					if (!flag7)
					{
						bool flag8 = !(num9 > 1.1274813E+09f);
						num11 = num9;
						num10 = num9;
						if (flag8)
						{
							goto IL_043f;
						}
					}
					num10 = num11 + 3.2833536E+09f;
				}
				goto IL_043f;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03fe;
		IL_03fe:
		throw new IndexOutOfRangeException();
		IL_03bb:
		if (!(flash < 0f))
		{
			Glow(deltaTime);
		}
		Float();
		return;
		IL_031a:
		lastAngle = 0f / 0f;
		float num12 = deltaTime * -1.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num13 = 1.0 - (double)num12;
		bool flag9 = num13 < 0.0;
		double num14 = 0.0;
		if (!flag9)
		{
			bool flag10 = !(num13 > 1.0);
			num14 = num13;
			if (!flag10)
			{
				num14 = 1.0;
			}
		}
		float num15 = idleSpin - spin;
		double num16 = (double)num15 * num14;
		double num17 = (double)spin + num16;
		float degrees = deltaTime * (float)num17;
		spin = (float)num17;
		Turn(degrees);
		goto IL_03bb;
		IL_030b:
		lastAngle = num4;
		goto IL_03bb;
		IL_043f:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num18 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num19 = num18 / 0f;
		float num20 = num19 - spin;
		double num21 = (double)num20 * 0.5;
		double num22 = (double)spin + num21;
		spin = (float)num22;
		Turn(num10);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		bool flag11 = !((double)num10 > 0.5);
		num5 = unchecked((nint)null);
		if (!flag11)
		{
			bool flag12 = finger == 0;
			object obj10 = !flag12;
			object obj11 = ~obj10;
			XRNode node = ((obj11 != null) ? ((XRNode)4) : ((XRNode)5));
			InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			InputDevice inputDevice = default;
			bool flag13 = inputDevice.SendHapticImpulse(0u, num23, 0f);
			num5 = unchecked((nint)null);
		}
		goto IL_030b;
	}

	private void Float()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_0273: Expected VT, but got I4
		//IL_0273: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = ape == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F8]");
			float num = 0f / bobTime;
			float time = Time.time;
			float num2 = time * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v11+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD04]");
			float num4 = num3 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num5 = num2 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num6 = num4 * rock;
			float num7 = rock;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num8 = num7 * 0f;
			float num9 = num5 * num8;
			float num10 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num11 = num10 * 0f;
			float num12 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num13 = num12 * 0f;
			Vector3 euler = default;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform transform = ((!(monster != null)) ? ape.transform : monster.transform);
			transform.SetLocalPositionAndRotation((Vector3)0, (Quaternion)0);
		}
	}

	private void Turn(float degrees)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_0092: Expected F4, but got I4
		//IL_009b: Expected Obj, but got I4
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
		bool flag2 = turntable != null;
		bool flag3 = !flag2;
		float num = degrees;
		object obj4 = 0;
		Space space = (Space)0;
		if (!flag3)
		{
			turntable.Rotate(0f, degrees, 0f, (Space)1);
			num = 0f;
			obj4 = 0;
			space = (Space)1;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (ring != null)
		{
			ring.Rotate(0f, degrees, 0f, (Space)1);
		}
	}

	public void TryOn(byte[] bySlot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
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
		if (ape != null)
		{
			ape.Show(bySlot);
		}
	}

	public void ShowMonster(MonsterDirector.Entry e)
	{
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected Obj, but got Unknown
		//IL_0b2e: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_0429: Expected VT, but got I4
		//IL_0429: Expected VT, but got I4
		//IL_0467: Expected Obj, but got I
		//IL_0491: Expected Obj, but got I4
		//IL_05d8: Expected VT, but got I4
		//IL_05d8: Expected VT, but got I4
		//IL_060c: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_067f: Expected Obj, but got I4
		//IL_07af: Expected Obj, but got I
		//IL_0b63: Expected Obj, but got I4
		//IL_07e7: Expected Obj, but got I
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected Obj, but got Unknown
		//IL_0823: Expected Obj, but got I4
		//IL_06ba: Expected Obj, but got I
		//IL_0b8a: Expected Obj, but got I4
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_09af: Expected Obj, but got I4
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Expected Obj, but got Unknown
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected Obj, but got Unknown
		//IL_0863: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected Obj, but got Unknown
		//IL_0750: Expected Obj, but got I
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected Obj, but got Unknown
		//IL_0bf8: Expected Obj, but got I
		//IL_0c10: Expected Obj, but got I
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected Obj, but got Unknown
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected Obj, but got Unknown
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0c5d: Expected VT, but got I4
		//IL_0a79: Expected VT, but got Obj
		//IL_0aa1: Expected VT, but got I4
		object obj = this + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		if (obj == e)
		{
			if (e == null)
			{
				return;
			}
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (monster != null)
			{
				return;
			}
		}
		monsterShown = e;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		object obj6 = this + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj6 != null)
		{
			if (obj6 == null)
			{
				goto IL_0afe;
			}
			GameObject obj8 = ((Component)obj6).gameObject;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v43+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj8);
		}
		monster = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v22+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = ape == null;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		if (obj13 != null)
		{
			return;
		}
		Rest();
		bool flag7 = e == null;
		object obj14 = 0;
		MonsterDisplay monsterDisplay = null;
		if (!flag7)
		{
			MonsterDisplay monsterDisplay2 = MonsterDisplay.Make(e, showOff: true);
			obj6 = monsterDisplay2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj14 = 0;
			monsterDisplay = monsterDisplay2;
		}
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v28+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform2;
		if ((UnityEngine.Object)obj6 == null)
		{
			if ((object)ape != null)
			{
				GameObject gameObject = ape.gameObject;
				if ((object)gameObject != null)
				{
					gameObject.SetActive(value: true);
					return;
				}
			}
		}
		else if ((object)ape != null)
		{
			GameObject gameObject2 = ape.gameObject;
			if ((object)gameObject2 != null)
			{
				gameObject2.SetActive(value: true);
				if ((object)ape != null)
				{
					Transform transform = ape.transform;
					if ((object)transform != null)
					{
						transform.SetLocalPositionAndRotation((Vector3)0, (Quaternion)0);
						if ((object)ape != null)
						{
							GameObject go = ape.gameObject;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAB8]");
							object obj17 = 0;
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v16+E4]");
							bool flag9 = (nint)0 == 0;
							object obj19 = !flag9;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Bounds bounds = Round(go);
							if ((object)ape != null)
							{
								GameObject gameObject3 = ape.gameObject;
								if ((object)gameObject3 != null)
								{
									gameObject3.SetActive(value: false);
									if (obj6 != null)
									{
										transform2 = ((Component)obj6).transform;
										if ((object)ape != null)
										{
											Transform transform3 = ape.transform;
											if ((object)transform3 != null)
											{
												Transform parent = transform3.parent;
												if ((object)transform2 != null)
												{
													transform2.SetParent(parent, worldPositionStays: false);
													transform2.SetLocalPositionAndRotation((Vector3)0, (Quaternion)0);
													if ((object)monster != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
														object obj20 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
														object obj21 = default;
														if (obj21 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v51+18]");
															object obj22 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v51+18]");
															if ((nint)0 < (nint)1)
															{
																goto IL_0782;
															}
															object obj23 = obj21 + 32;
															object obj24 = 0;
															while (true)
															{
																bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
																object obj25 = !flag10;
																if (obj25 != null)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X25_v6+v437 @ X24_v9*8]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X25_v6+v437 @ X24_v9*8]");
																	GameObject gameObject4 = ((Component)0).gameObject;
																	if ((object)ape != null)
																	{
																		GameObject gameObject5 = ape.gameObject;
																		if ((object)gameObject5 != null)
																		{
																			int layer = gameObject5.layer;
																			if ((object)gameObject4 != null)
																			{
																				gameObject4.layer = layer;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v51+18]");
																				obj22 = 0;
																				obj24++;
																				object obj26 = obj24;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v51+18]");
																				if ((nint)obj26 < 0)
																				{
																					continue;
																				}
																				goto IL_0782;
																			}
																		}
																	}
																}
																goto IL_0afe;
															}
															goto IL_0b0c;
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
		}
		goto IL_0afe;
		IL_0782:
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA360]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj28 = default;
			if (obj28 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v54+18]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v54+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_08a6;
				}
				object obj30 = obj28 + 32;
				object obj31 = 0;
				while (true)
				{
					bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
					object obj32 = !flag11;
					if (obj32 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X24_v7+v435 @ X23_v10*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X24_v7+v435 @ X23_v10*8]");
						((Renderer)0).shadowCastingMode = (ShadowCastingMode)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v54+18]");
						obj29 = 0;
						obj31++;
						object obj33 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v54+18]");
						if ((nint)obj33 < 0)
						{
							continue;
						}
						goto IL_08a6;
					}
					goto IL_0afe;
				}
				goto IL_0b0c;
			}
		}
		goto IL_0afe;
		IL_0b0c:
		throw new IndexOutOfRangeException();
		IL_08a6:
		if (obj6 != null)
		{
			GameObject go2 = ((Component)obj6).gameObject;
			Bounds bounds2 = MonsterDisplay.Posed(go2);
			object obj35 = default;
			object obj34 = obj35 + obj35;
			object obj37 = default;
			object obj36 = obj37 + obj37;
			object obj39 = default;
			object obj38 = obj39 + obj39;
			object obj40 = obj35 + obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			object obj41 = obj34 * 0;
			object obj42 = obj36 - obj38;
			bool flag12 = (nint)obj42 < 0;
			bool flag13 = obj42 == null;
			object obj43 = obj36 ^ obj38;
			object obj44 = obj36 ^ obj42;
			object obj45 = obj43 & obj44;
			bool flag14 = (nint)obj45 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			bool flag15 = flag12 == flag14;
			object obj46 = !flag13;
			object obj47 = flag15 & obj46;
			object obj48 = ~obj47;
			if (obj48 != null)
			{
				obj36 = obj38;
			}
			object obj49 = obj41 / obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			object obj50 = 0 / obj36;
			object obj51 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50)) ? obj50 : obj49);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj52 = 0;
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v34+A0]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v35+14]");
			object obj55 = obj51 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v35+C]");
			object obj56 = obj51 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v35+10]");
			object obj57 = obj51 * 0;
			transform2.localScale = (Vector3)0;
			if (obj6 != null)
			{
				GameObject go3 = ((Component)obj6).gameObject;
				Bounds bounds3 = MonsterDisplay.Posed(go3);
				Vector3 position = transform2.position;
				object obj59 = default;
				object obj58 = obj59 - obj35;
				object obj60 = obj59 - obj35;
				object obj62 = default;
				object obj63 = default;
				object obj61 = obj62 - obj63;
				object obj64 = obj58 - obj60;
				object obj66 = default;
				object obj65 = obj66 - obj66;
				Vector3 vector = (Vector3)(obj61 + obj56);
				object obj67 = obj64 + obj57;
				object obj68 = obj65 + obj55;
				transform2.position = (Vector3)0;
				Vector3 localPosition = transform2.localPosition;
				monsterRest = vector;
				Quaternion localRotation = transform2.localRotation;
				monsterRestTurn = (Quaternion)vector;
				Float();
				return;
			}
		}
		goto IL_0afe;
		IL_0afe:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b0c;
	}

	private unsafe static Bounds Round(GameObject go)
	{
		//IL_02d5: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_032d: Invalid comparison between VT and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected VT, but got Unknown
		//IL_029d: Expected VT, but got F8
		//IL_0298: Expected native int or pointer, but got VT
		//IL_02aa: Expected native int or pointer, but got VT
		//IL_00ca: Expected Obj, but got I8
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_0612: Expected VT, but got F8
		//IL_061a: Expected VT, but got F8
		//IL_062a: Expected VT, but got F8
		//IL_063b: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got VT
		//IL_0359: Invalid comparison between F8 and I4
		//IL_0368: Invalid comparison between F8 and I4
		//IL_037b: Expected Obj, but got F8
		//IL_0388: Expected Obj, but got F8
		//IL_03bd: Expected Obj, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_04ae: Invalid comparison between F8 and I4
		//IL_04bd: Invalid comparison between F8 and I4
		//IL_04d0: Expected Obj, but got F8
		//IL_04dd: Expected Obj, but got F8
		//IL_0512: Expected Obj, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		Vector3 vector;
		Bounds result;
		double num22 = default;
		if ((object)go != null)
		{
			Transform transform = go.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C30]");
				object obj = 0;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v8+A0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
				Bounds bounds = default;
				if (bounds != (Bounds)(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v9+8]");
					double num = 0.0 * 0.5;
					vector = (Vector3)(obj4 * 63);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11 (UnityEngine.Bounds)+18]");
					bool flag = (nint)0 < (nint)1;
					double num3 = default;
					double num2 = num3;
					result = bounds;
					if (flag)
					{
						goto IL_0290;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11 (UnityEngine.Bounds)+18]");
					object obj5 = 0 & 0xFFFFFFFFL;
					object obj6 = bounds + 32;
					Vector3 vector2 = vector;
					double num4 = num;
					Vector3 vector4 = default;
					Vector3 vector3 = vector4;
					double num5 = num3;
					object obj7 = 0;
					object obj8 = 0;
					double num9 = default;
					double num10 = default;
					object obj19 = default;
					double num23 = default;
					double num24 = default;
					while (true)
					{
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
						object obj9 = !flag2;
						if (obj9 != null)
						{
							break;
						}
						object obj10 = obj7 & 1;
						double num21;
						if (obj10 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v6+v159 @ X21_v9*8]");
							if ((nint)0 == 0)
							{
								goto IL_02b9;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v6+v159 @ X21_v9*8]");
							result = ((Renderer)0).bounds;
							double num6 = num5 - num4;
							double num7 = num4 + num5;
							double num8 = num9 - num10;
							double num11 = num9 + num10;
							object obj11 = vector3 - vector2;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							if (!(num6 < num8))
							{
								num6 = num8;
							}
							double num12 = num7 - num8;
							bool flag3 = num12 < 0.0;
							bool flag4 = num12 == 0.0;
							object obj12 = num7 ^ num8;
							object obj13 = num7 ^ num12;
							object obj14 = obj12 & obj13;
							bool flag5 = (nint)obj14 < 0;
							bool flag6 = flag3 == flag5;
							object obj15 = !flag4;
							object obj16 = flag6 & obj15;
							object obj17 = ~obj16;
							if (obj17 == null)
							{
								num8 = num7;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
							double num13 = num8 - num6;
							object obj18 = obj19 - obj11;
							double num14 = num13 * 0.5;
							object obj20 = obj18 * 63;
							double num15 = num6 + num14;
							double num16 = num15 - num14;
							double num17 = num14 + num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							if (!(num16 < num11))
							{
								num16 = num11;
							}
							double num18 = num17 - num11;
							bool flag7 = num18 < 0.0;
							bool flag8 = num18 == 0.0;
							object obj21 = num17 ^ num11;
							object obj22 = num17 ^ num18;
							object obj23 = obj21 & obj22;
							bool flag9 = (nint)obj23 < 0;
							bool flag10 = flag7 == flag9;
							object obj24 = !flag8;
							object obj25 = flag10 & obj24;
							object obj26 = ~obj25;
							if (obj26 == null)
							{
								num11 = num17;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
							double num19 = num11 - num16;
							double num20 = (double)obj20 - num15;
							num = num19 * 0.5;
							num21 = num20 * 63.0;
							num2 = num16 + num;
							num22 = num15 + num21;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v6+v159 @ X21_v9*8]");
							if ((nint)0 == 0)
							{
								goto IL_02b9;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v6+v159 @ X21_v9*8]");
							result = ((Renderer)0).bounds;
							num21 = num23;
							num = num10;
							num22 = num24;
							num2 = num9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11 (UnityEngine.Bounds)+18]");
						obj5 = 0;
						obj8++;
						object obj27 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11 (UnityEngine.Bounds)+18]");
						bool flag11 = (nint)obj27 < 0;
						vector = (Vector3)num21;
						vector2 = (Vector3)num21;
						num4 = num;
						vector3 = (Vector3)num22;
						num5 = num2;
						obj7 = 1;
						if (flag11)
						{
							continue;
						}
						goto IL_0290;
					}
					goto IL_02c7;
				}
			}
		}
		goto IL_02b9;
		IL_02c7:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (Bounds)ex;
		IL_02b9:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02c7;
		IL_0290:
		Bounds bounds2 = default;
		((Bounds*)(nint)bounds2)->m_Center = (Vector3)num22;
		((Bounds*)(nint)bounds2)->m_Extents = vector;
		return result;
	}

	public void Flash()
	{
		flash = 0f;
	}

	private void Glow(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_033d: Expected Obj, but got I4
		//IL_008f: Invalid comparison between F4 and I4
		//IL_009e: Expected F8, but got I4
		//IL_010b: Invalid comparison between F8 and I4
		//IL_013d: Invalid comparison between F8 and I4
		//IL_014c: Expected F8, but got I4
		//IL_01d4: Expected VT, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_020a: Expected VT, but got I4
		//IL_035c: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I
		//IL_02a0: Expected VT, but got I4
		//IL_02a0: Expected I4, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_0262: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		float num = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		float num2 = num / 0f;
		float num3 = num2 + flash;
		flash = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (glow == null)
		{
			if ((double)flash < 1.0)
			{
				return;
			}
		}
		else
		{
			bool flag2 = flash < 0f;
			double num4 = 0.0;
			if (!flag2)
			{
				bool flag3 = !((double)flash > 1.0);
				num4 = flash;
				if (!flag3)
				{
					num4 = 1.0;
				}
			}
			double num5 = num4 - 1.0;
			bool flag4 = num5 < 0.0;
			glow.enabled = flag4;
			Transform transform = glow.transform;
			bool flag5 = num4 < 0.0;
			double num6 = 0.0;
			if (!flag5)
			{
				bool flag6 = !(num4 > 1.0);
				num6 = num4;
				if (!flag6)
				{
					num6 = 1.0;
				}
			}
			double num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A940]");
			double num8 = num7 * 0.0;
			double num9 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			double num10 = num9 + 0.0;
			transform.localPosition = (Vector3)0;
			object obj4 = this + 208;
			MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)obj4;
			bool flag7 = obj4 == null;
			object obj5 = !flag7;
			Vector3 vector = (Vector3)0;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock2 = default;
				materialPropertyBlock2._002Ector();
				obj4 = materialPropertyBlock2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				materialPropertyBlock = (MaterialPropertyBlock)obj4;
				vector = (Vector3)materialPropertyBlock2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAB8]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v13+E4]");
			bool flag8 = (nint)0 == 0;
			object obj9 = !flag8;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v12+A0]");
			object obj11 = 0;
			materialPropertyBlock.SetColor((int)obj11, (Color)0);
			glow.SetPropertyBlock(block);
			if ((double)flash < 1.0)
			{
				return;
			}
		}
		flash = -1f;
	}

	private int Touching(float slack)
	{
		//IL_0096: Expected I4, but got I8
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_048b: Expected I4, but got Obj
		//IL_00d4: Expected F4, but got I
		//IL_00e4: Expected F4, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02d3: Expected Obj, but got I
		//IL_0302: Expected VT, but got I4
		//IL_04d4: Expected Obj, but got I4
		//IL_0403: Invalid comparison between F4 and I4
		int num7;
		if (fingertips != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(ring == null))
			{
				Transform[] array = fingertips;
				if (fingertips == null)
				{
					goto IL_046f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				float num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj4 = 0;
				float num3 = slack;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				float num4 = num3 + 0f;
				float num5 = slack;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				float num6 = num5 + 0f;
				object obj5 = 0;
				UnityEngine.Object obj6 = null;
				num7 = 0;
				float num8 = default;
				while (num7 < array.Length)
				{
					bool flag2 = num7 < array.Length;
					object obj7 = !flag2;
					float num9;
					if (obj7 == null)
					{
						object obj8 = obj;
						object obj9 = array + num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v14+E4]");
						bool flag3 = (nint)0 == 0;
						object obj10 = !flag3;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v11+20]");
						bool flag4 = (UnityEngine.Object)0 == null;
						bool flag5 = !flag4;
						object obj11 = !flag5;
						num8 = num8;
						num9 = num2;
						obj6 = null;
						if (obj11 != null)
						{
							goto IL_041c;
						}
						if ((object)ring != null)
						{
							Transform parent = ring.parent;
							Transform[] array2 = fingertips;
							if (fingertips != null)
							{
								bool flag6 = num7 < array2.Length;
								object obj12 = !flag6;
								if (obj12 != null)
								{
									goto IL_047d;
								}
								object obj13 = fingertips + num7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v15+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v15+20]");
									Vector3 position = ((Transform)0).position;
									if ((object)parent != null)
									{
										Vector3 vector = parent.InverseTransformPoint((Vector3)0);
										if ((object)ring != null)
										{
											Vector3 localPosition = ring.localPosition;
											object obj14 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v28+E4]");
											bool flag7 = (nint)0 == 0;
											object obj15 = !flag7;
											if (obj15 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num10 = num - num;
											float num11 = num8 - num8;
											num8 = num2 - num2;
											float num12 = num10 * num10;
											float num13 = num11 * num11;
											float num14 = num12 + num13;
											num9 = ringRadius;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
											bool flag8;
											if (num14 < num4)
											{
												float num15 = ringRadius - num6;
												flag8 = num15 < 0f;
											}
											else
											{
												flag8 = false;
											}
											num = num14;
											obj6 = null;
											if (!flag8)
											{
												goto IL_041c;
											}
											goto IL_051e;
										}
									}
								}
							}
						}
						goto IL_046f;
					}
					goto IL_047d;
					IL_041c:
					array = fingertips;
					num7++;
					bool flag9 = fingertips == null;
					object obj16 = !flag9;
					num2 = num9;
					obj5 = 0;
					if (obj16 != null)
					{
						continue;
					}
					goto IL_046f;
				}
			}
		}
		num7 = -1;
		goto IL_051e;
		IL_047d:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_051e:
		return num7;
		IL_046f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_047d;
	}

	private float Angle(Vector3 world)
	{
		//IL_0059: Expected VT, but got I4
		if ((object)ring != null)
		{
			Transform parent = ring.parent;
			if ((object)parent != null)
			{
				Vector3 vector = parent.InverseTransformPoint((Vector3)0);
				if ((object)ring != null)
				{
					Vector3 localPosition = ring.localPosition;
					float num2 = default;
					float num = num2 - num2;
					object obj2 = default;
					object obj = obj2 - obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
					float num3 = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB4C]");
					return num3 * 0f;
				}
			}
		}
		throw new NullReferenceException();
	}

	public TryOnTube()
	{
		//IL_0025: Expected I4, but got I8
		//IL_0037: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D650]");
		hover = 0f;
		flash = -1f;
		base._002Ector();
	}

	static TryOnTube()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAB8]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
