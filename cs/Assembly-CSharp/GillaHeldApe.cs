using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaHeldApe : MonoBehaviour
{
	private const int Free = default(int);

	private const int Held = default(int);

	private const int Dropped = default(int);

	private const int Down = default(int);

	private const float SeamRate = default(float);

	private const float LongestSeam = default(float);

	private const float EyesOverFloor = default(float);

	private const float HeadRadius = default(float);

	private const float MostGoing = default(float);

	private const float LongestFall = default(float);

	private const float DrawnBehindWord = default(float);

	private const int Solid = default(int);

	private NetworkApe who;

	private Transform yourHand;

	private float yourHandTill;

	private Vector3 yourEyes;

	private int state;

	private bool started;

	private bool falling;

	private bool landed;

	private Vector3 seam;

	private Vector3 drawn;

	private Vector3 fallAt;

	private Vector3 fallGoing;

	private Vector3 lastNet;

	private Vector3 going;

	private float fellFor;

	private float landedAfter;

	private float toldFor;

	private float tiltFollow;

	private float yawTook;

	private bool tookAgain;

	public bool InHand
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = state - 1;
			return obj == null;
		}
	}

	public bool Falling => falling;

	public Vector3 Going
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA460]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public void Take(Transform hand, Vector3 eyesFromHand)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 40;
		obj = hand;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float time = Time.time;
		_ = 0;
		float num = time + 2.139095E+09f;
	}

	public void Take(Transform hand, float seconds = default(float))
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 40;
		obj = hand;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float time = Time.time;
		float num = time + seconds;
		_ = 0;
	}

	public void NotFalling()
	{
		falling = false;
	}

	public void LetGo(Vector3 eyes, Vector3 velocity)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 40;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 1;
		_ = 0;
		_ = 0;
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_10a1: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_10c1: Invalid comparison between F4 and I4
		//IL_111e: Expected Obj, but got I4
		//IL_0355: Expected F4, but got VT
		//IL_0183: Expected Obj, but got VT
		//IL_01f3: Invalid comparison between F8 and I4
		//IL_0202: Expected F8, but got I4
		//IL_03ac: Expected Obj, but got I4
		//IL_1485: Invalid comparison between F4 and I4
		//IL_0405: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I4
		//IL_11a9: Expected VT, but got F4
		//IL_025e: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_0305: Expected F4, but got I4
		//IL_11ec: Expected Obj, but got I4
		//IL_04c2: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I4
		//IL_1203: Unknown result type (might be due to invalid IL or missing references)
		//IL_1208: Expected Obj, but got Unknown
		//IL_053f: Expected Obj, but got I4
		//IL_0548: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I4
		//IL_0830: Expected F4, but got VT
		//IL_0840: Expected F4, but got I
		//IL_0850: Expected F4, but got I
		//IL_0867: Expected VT, but got I4
		//IL_05f0: Invalid comparison between F4 and I4
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_07af: Expected Obj, but got I4
		//IL_0a4f: Expected F4, but got VT
		//IL_0a60: Expected Obj, but got I4
		//IL_08a7: Expected Obj, but got I4
		//IL_0b45: Expected VT, but got F4
		//IL_0b9a: Expected VT, but got F4
		//IL_0aaa: Expected Obj, but got I4
		//IL_0a26: Expected Obj, but got I4
		//IL_068b: Expected F4, but got I4
		//IL_0ac9: Expected F4, but got I
		//IL_0ad9: Expected F4, but got I
		//IL_0947: Invalid comparison between F4 and I4
		//IL_0956: Expected F4, but got I4
		//IL_1352: Expected VT, but got F4
		//IL_1375: Expected VT, but got F4
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_138d: Expected Obj, but got Unknown
		//IL_129d: Expected VT, but got I4
		//IL_129d: Expected VT, but got I4
		//IL_0e30: Invalid comparison between F4 and I
		//IL_13c9: Expected Obj, but got I
		//IL_13e1: Expected Obj, but got I
		//IL_13e9: Expected VT, but got Obj
		//IL_13f9: Expected F4, but got I
		//IL_1409: Expected F4, but got I
		//IL_1420: Expected VT, but got Obj
		//IL_096d: Invalid comparison between F4 and I4
		//IL_097c: Expected F4, but got I4
		//IL_0bcf: Expected VT, but got I4
		//IL_0993: Invalid comparison between F4 and I4
		//IL_0ead: Expected VT, but got I4
		//IL_0c08: Expected Obj, but got I4
		//IL_0c50: Expected Obj, but got I4
		//IL_0c59: Expected VT, but got I4
		//IL_0eeb: Expected Obj, but got I4
		//IL_0f33: Expected VT, but got I4
		//IL_0cf5: Expected Obj, but got I4
		//IL_0fe9: Expected Obj, but got I4
		//IL_0ca5: Expected VT, but got I4
		//IL_0cae: Expected Obj, but got I4
		//IL_0cb7: Expected VT, but got I4
		//IL_0fa2: Expected VT, but got I4
		//IL_0fab: Expected VT, but got I4
		//IL_0d94: Expected Obj, but got I4
		//IL_1440: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)who == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		NetworkApe networkApe = who;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = networkApe.head == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		NetworkApe networkApe2 = who;
		Vector3 position = networkApe2.head.position;
		bool flag7 = (byte)(~(started ? 1u : 0u)) != 0;
		object obj8 = !flag7;
		Vector3 vector = default;
		if (obj8 == null)
		{
			lastNet = vector;
			drawn = vector;
			started = true;
		}
		float deltaTime = Time.deltaTime;
		bool flag8 = !(deltaTime > 0f);
		float num2 = default;
		float num = num2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj9 = vector - lastNet;
			float num3 = (float)obj9 / num2;
			float num4 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+80]");
			float num5 = num4 - 0f;
			float num6 = num5 / deltaTime;
			float num7 = deltaTime * -12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			double num8 = 1.0 - (double)num7;
			bool flag9 = num8 < 0.0;
			double num9 = 0.0;
			if (!flag9)
			{
				bool flag10 = !(num8 > 1.0);
				num9 = num8;
				if (!flag10)
				{
					num9 = 1.0;
				}
			}
			float num10 = num3 - (float)going;
			float num11 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+8C]");
			num = num11 - 0f;
			object obj10 = default;
			float num12 = num10 * (float)obj10;
			float num13 = num * (float)num9;
			float num14 = (float)going + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+8C]");
			float num15 = 0f + num13;
			float num16 = num14 * num14;
			float num17 = num15 * num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			float num18 = num17 + num16;
			bool flag11 = !(num18 > 1.125122E+09f);
			double num19 = deltaTime;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v121+E4]");
				bool flag12 = (nint)0 == 0;
				object obj13 = !flag12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num20 = num14 / num17;
				float num21 = num15 / 1.125122E+09f;
				num14 = num20 * 0f;
				num15 = num21 * 12f;
				num = 0f;
				num19 = 12.0;
			}
			going = (Vector3)num14;
		}
		object obj14 = obj;
		lastNet = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v17+E4]");
		bool flag13 = (nint)0 == 0;
		object obj15 = !flag13;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = yourHand != null;
		bool flag15 = !flag14;
		float num23 = default;
		float num22 = num23;
		float num24 = (float)vector;
		Transform transform;
		object obj16;
		UnityEngine.Object obj17;
		if (!flag15)
		{
			num22 = Time.time;
			num24 = yourHandTill;
			if (num22 < yourHandTill)
			{
				transform = yourHand;
				obj16 = 0;
				obj17 = null;
				goto IL_11b3;
			}
		}
		Transform holderHand = who.HolderHand;
		obj16 = 1;
		transform = holderHand;
		obj17 = null;
		goto IL_11b3;
		IL_12be:
		int num25;
		Vector3 vector2;
		float num26;
		float num27;
		float num29;
		float num30;
		float num31;
		if (num25 == state)
		{
			vector2 = seam;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+4C]");
			num26 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+50]");
			num27 = 0f;
		}
		else
		{
			float num28 = (float)drawn - num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+58]");
			num26 = 0f - num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+5C]");
			num27 = 0f - num31;
			float num32 = num28 * num28;
			float num33 = num26 * num26;
			seam = (Vector3)num28;
			float num34 = num32 + num33;
			float num35 = num27 * num27;
			float num36 = num34 + num35;
			bool flag16 = !((double)num36 > 16.0);
			vector2 = (Vector3)num28;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X8_v40+A0]");
				object obj20 = 0;
				vector2 = (Vector3)obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v41+4]");
				num26 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v41+8]");
				num27 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v41+8]");
				_ = 0;
				seam = (Vector3)obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v41+4]");
				_ = 0;
			}
			state = num25;
		}
		float num37 = deltaTime * -25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		float num38 = num37 * (float)vector2;
		float num39 = num37 * num26;
		float num40 = num37 * num27;
		float num41 = num29 + num38;
		float num42 = num30 + num39;
		seam = (Vector3)num38;
		float num43 = num31 + num40;
		drawn = (Vector3)num41;
		object obj22;
		object obj21 = obj22 & 1;
		NetworkApe networkApe6;
		Transform rightHand;
		if (obj21 != null)
		{
			NetworkApe networkApe3 = who;
			networkApe3.head.position = (Vector3)0;
			NetworkApe networkApe4 = who;
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X0_v62+E4]");
			bool flag17 = (nint)0 == 0;
			object obj24 = !flag17;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18 = networkApe4.leftHand != null;
			bool flag19 = !flag18;
			object obj25 = 0;
			Vector3 vector3 = (Vector3)0;
			if (!flag19)
			{
				NetworkApe networkApe5 = who;
				Vector3 vector4 = networkApe6.limp.Hand(right: false);
				networkApe5.leftHand.position = (Vector3)0;
				obj25 = 0;
				vector3 = (Vector3)0;
			}
			NetworkApe networkApe7 = who;
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X0_v67+E4]");
			bool flag20 = (nint)0 == 0;
			object obj27 = !flag20;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(networkApe7.rightHand != null))
			{
				return;
			}
			NetworkApe networkApe8 = who;
			rightHand = networkApe8.rightHand;
			Vector3 vector5 = networkApe6.limp.Hand(right: true);
			bool flag21 = (object)networkApe8.rightHand == null;
			object obj28 = !flag21;
			if (obj28 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			float num44 = num43 - num2;
			float num45 = num41 - (float)vector;
			float num46 = num42 - num23;
			float num47 = num45 * num45;
			float num48 = num46 * num46;
			float num49 = num47 + num48;
			float num50 = num44 * num44;
			float num51 = num49 + num50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			if (num51 < 0f)
			{
				return;
			}
			NetworkApe networkApe9 = who;
			Vector3 position2 = networkApe9.head.position;
			float num52 = num45 + num51;
			float num53 = num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			float num54 = num53 + 0f;
			float num55 = num44 + num43;
			networkApe9.head.position = (Vector3)0;
			NetworkApe networkApe10 = who;
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v45+E4]");
			bool flag22 = (nint)0 == 0;
			object obj30 = !flag22;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag23 = networkApe10.leftHand != null;
			bool flag24 = !flag23;
			Vector3 vector6 = (Vector3)0;
			if (!flag24)
			{
				NetworkApe networkApe11 = who;
				Vector3 position3 = networkApe11.leftHand.position;
				num52 = num45 + num52;
				num54 = num46 + num54;
				num55 = num44 + num55;
				networkApe11.leftHand.position = (Vector3)0;
				vector6 = (Vector3)0;
			}
			NetworkApe networkApe12 = who;
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v50+E4]");
			bool flag25 = (nint)0 == 0;
			object obj32 = !flag25;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(networkApe12.rightHand != null))
			{
				return;
			}
			NetworkApe networkApe13 = who;
			rightHand = networkApe13.rightHand;
			Vector3 position4 = networkApe13.rightHand.position;
		}
		rightHand.position = (Vector3)0;
		return;
		IL_11b3:
		networkApe6 = who;
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v22+E4]");
		bool flag26 = (nint)0 == 0;
		object obj34 = !flag26;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag27;
		if (networkApe6.limp != null)
		{
			bool isDown = networkApe6.limp.IsDown;
			flag27 = isDown;
			UnityEngine.Object obj35 = null;
		}
		else
		{
			flag27 = false;
			UnityEngine.Object obj35 = null;
		}
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X0_v27+E4]");
		bool flag28 = (nint)0 == 0;
		object obj37 = !flag28;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag29 = transform != null;
		bool flag30 = !flag29;
		object obj38 = flag29 | flag27;
		object obj39 = !flag30;
		num25 = ((obj39 != null) ? 1 : 3);
		object obj40 = obj38 & 1;
		object obj41;
		if (obj40 != null)
		{
			obj22 = (flag29 ? 1 : 0) ^ 1;
			obj41 = 0;
		}
		else
		{
			bool flag31 = !falling;
			num25 = (int)((falling ? 1u : 0u) << 1);
			object obj42 = !flag31;
			obj22 = 0;
			obj41 = obj42;
		}
		ApeAvatarDriver avatarDriver = who.AvatarDriver;
		object obj43 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v16+E4]");
		bool flag32 = (nint)0 == 0;
		object obj44 = !flag32;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag33 = avatarDriver != null;
		bool flag34 = !flag33;
		UnityEngine.Object obj45 = null;
		if (!flag34)
		{
			float num56 = tiltFollow;
			if (tiltFollow < 0f)
			{
				num56 = avatarDriver.bodyTiltFollow;
				tiltFollow = avatarDriver.bodyTiltFollow;
			}
			UnityEngine.Object obj46;
			bool flag35;
			if (flag29)
			{
				avatarDriver.bodyTiltFollow = 0f;
				avatarDriver.turnHeld = true;
				obj46 = null;
				flag35 = flag33;
			}
			else
			{
				flag35 = who.Busy;
				bool turnHeld;
				if (flag35)
				{
					num56 = 0f;
					turnHeld = true;
				}
				else
				{
					num56 = tiltFollow;
					turnHeld = false;
				}
				avatarDriver.bodyTiltFollow = num56;
				avatarDriver.turnHeld = turnHeld;
				bool flag36 = !flag29;
				obj46 = null;
				num22 = num56;
				obj45 = null;
				flag33 = flag35;
				if (flag36)
				{
					goto IL_1225;
				}
			}
			if (state == 1)
			{
				bool flag37 = (byte)(~(tookAgain ? 1u : 0u)) != 0;
				num22 = num56;
				obj45 = obj46;
				flag33 = flag35;
				if (flag37)
				{
					goto IL_1225;
				}
			}
			num22 = avatarDriver.yaw;
			yawTook = avatarDriver.yaw;
			obj45 = obj46;
			flag33 = flag35;
		}
		goto IL_1225;
		IL_126a:
		float num57 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		num22 = num57 * 0f;
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		Vector3 vector7 = (Quaternion)0 * (Vector3)0;
		float num58 = num24;
		float num59 = num;
		float num60 = num22;
		goto IL_09e3;
		IL_1225:
		tookAgain = false;
		Vector3 eyesFromHolder;
		if (obj16 != null)
		{
			eyesFromHolder = who.EyesFromHolder;
			bool flag38 = !flag29;
			object obj47 = !flag38;
			obj45 = null;
			num58 = num24;
			num59 = num;
			num60 = num22;
			UnityEngine.Object obj48 = null;
			if (obj47 == null)
			{
				goto IL_07df;
			}
		}
		else
		{
			num60 = (float)yourEyes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+38]");
			num58 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+3C]");
			num59 = 0f;
			bool flag39 = !flag29;
			eyesFromHolder = (Vector3)flag33;
			UnityEngine.Object obj48 = obj45;
			if (flag39)
			{
				goto IL_07df;
			}
		}
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v84+E4]");
		bool flag40 = (nint)0 == 0;
		object obj50 = !flag40;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(avatarDriver != null))
		{
			goto IL_09e3;
		}
		float num61 = avatarDriver.yaw - yawTook;
		float num62 = num61 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		num24 = num62 * 1.13587E+09f;
		float num63 = num61 - num24;
		bool flag41 = num63 < 0f;
		num = 0f;
		if (!flag41)
		{
			bool flag42 = num63 > 1.13587E+09f;
			float num64 = 1.13587E+09f;
			if (!flag42)
			{
				bool flag43 = !(num63 > 1.1274813E+09f);
				num64 = num63;
				num = num63;
				num24 = num63;
				if (flag43)
				{
					goto IL_126a;
				}
			}
			num = num64 + 3.2833536E+09f;
			num24 = num64;
		}
		goto IL_126a;
		IL_07df:
		object obj51 = obj22 & 1;
		object obj52;
		if (obj51 != null)
		{
			eyesFromHolder = networkApe6.limp.Eyes;
			obj45 = null;
		}
		else
		{
			bool flag44 = obj41 == null;
			num30 = num23;
			num29 = (float)vector;
			num31 = num2;
			obj52 = 0;
			if (flag44)
			{
				goto IL_12be;
			}
			eyesFromHolder = Fall(deltaTime);
			num22 = deltaTime;
		}
		num30 = num24;
		num29 = num22;
		num31 = num;
		obj52 = 0;
		goto IL_12be;
		IL_09e3:
		eyesFromHolder = transform.position;
		num29 = num60 + num22;
		num30 = num58 + num24;
		num31 = num59 + num;
		obj52 = 0;
		obj45 = null;
		goto IL_12be;
	}

	private bool Slammed(Vector3 at, Vector3 normal)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CCD4");
		bool result = default;
		return result;
	}

	private unsafe Vector3 Fall(float dt)
	{
		//IL_0540: Expected Obj, but got I4
		//IL_0505: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_00c4: Expected VT, but got F4
		//IL_057c: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I4
		//IL_010b: Invalid comparison between F4 and I
		//IL_07a2: Expected VT, but got I4
		//IL_0322: Expected F4, but got I
		//IL_0354: Expected VT, but got F4
		//IL_06e4: Invalid comparison between F4 and I4
		//IL_06f5: Expected Obj, but got I4
		//IL_06fe: Invalid comparison between F4 and I4
		//IL_070f: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		//IL_05dc: Expected F4, but got Obj
		//IL_05dc: Expected VT, but got I8
		//IL_05dc: Expected F4, but got Obj
		//IL_05dc: Expected VT, but got Ref
		//IL_060e: Expected I, but got I8
		//IL_0626: Expected F4, but got Obj
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0754: Expected Obj, but got I4
		//IL_0210: Expected VT, but got F4
		//IL_0229: Expected VT, but got I4
		//IL_0229: Expected VT, but got I8
		//IL_0247: Expected Obj, but got I4
		//IL_024f: Expected VT, but got I4
		//IL_03a1: Expected F4, but got Obj
		//IL_03a1: Expected VT, but got I8
		//IL_03a1: Expected VT, but got Ref
		//IL_026d: Expected F4, but got I
		//IL_03d6: Expected VT, but got I4
		//IL_03d6: Expected VT, but got I8
		//IL_03f4: Expected Obj, but got I4
		//IL_03fc: Expected VT, but got I4
		//IL_066f: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I
		//IL_06ad: Expected F4, but got Obj
		//IL_06b5: Invalid comparison between F4 and Obj
		//IL_06cd: Expected F4, but got VT
		//IL_07b1: Expected VT, but got F4
		//IL_07d5: Expected I, but got I8
		//IL_07e6: Expected F4, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		float num = fellFor;
		float num3 = default;
		float num2 = (fellFor += num3);
		bool flag = (byte)(~(landed ? 1u : 0u)) != 0;
		object obj = !flag;
		object obj2;
		QueryTriggerInteraction queryTriggerInteraction = default;
		Vector3 result;
		float num22;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			obj2 = 0;
			landedAfter = num2;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 gravity = Physics.gravity;
			float num4 = num * num3;
			object obj5 = default;
			float num5 = num2 * (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+74]");
			float num6 = 0f + num4;
			float num7 = (float)fallGoing + num5;
			fallGoing = (Vector3)num7;
			float num8 = num7 * (float)obj5;
			float num9 = num6 * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num10 = num9 * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num12 = default;
			float num11 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num25;
			float num26;
			if (num11 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num13 = num9 / num12;
				object obj9 = obj2;
				object obj10 = this + 96;
				object obj11 = obj10 + 4;
				object obj12 = obj10 + 8;
				float num14 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num15 = num14 / 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v27+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj14 = default;
				bool flag5 = Physics.SphereCast((Vector3)(&obj14), (float)obj10, (Vector3)4294961403L, out *(RaycastHit*)1, (float)obj11, 0, queryTriggerInteraction);
				bool flag6 = !flag5;
				int num16 = 0;
				ref RaycastHit reference = ref *(RaycastHit*)1;
				nint num17 = unchecked((nint)4294961403L);
				float num18 = num13;
				object obj16 = default;
				object obj15 = obj16;
				num = (float)obj12;
				float num19 = num15;
				if (!flag6)
				{
					object obj17 = default;
					float num20 = num15 * (float)obj17;
					object obj18 = default;
					float num21 = num13 * (float)obj18;
					num18 = (float)fallAt + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+68]");
					num12 = 0f + num21;
					fallAt = (Vector3)num18;
					bool flag7 = Slammed((Vector3)4294961403L, (Vector3)1);
					bool flag8 = !flag7;
					object obj19 = !flag8;
					result = (Vector3)flag7;
					if (obj19 != null)
					{
						goto IL_063c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+70]");
					num22 = 0f;
					object obj21 = default;
					object obj20 = obj21 * obj21;
					float num23 = 0f * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
					object obj22 = 0;
					object obj23 = obj22;
					float num24 = (float)obj20 + num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v30+A0]");
					object obj24 = 0;
					object obj25 = default;
					num25 = (float)obj25 + num24;
					num26 = (float)obj24;
					bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
					float num27 = default;
					num = num27;
					float num28 = (float)fallGoing;
					if (!flag9)
					{
						object obj26 = fallGoing * obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+70]");
						float num29 = 0f * 0f;
						float num30 = (float)obj26 + num29;
						float num32 = default;
						float num31 = num32 + num30;
						float num33 = num31 / num25;
						num26 = (float)obj21 * num33;
						num25 = 0f * (float)obj17;
						num28 = (float)fallGoing - num26;
						num22 -= num25;
						num = num32;
					}
					fallGoing = (Vector3)num28;
					num16 = 0;
					reference = ref *(RaycastHit*)1;
					num17 = unchecked((nint)4294961403L);
					object obj27 = default;
					obj15 = obj27;
					num19 = 0f;
					goto IL_06db;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+70]");
			num22 = 0f;
			num25 = num8 + (float)fallAt;
			float num34 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeldApe)+68]");
			num26 = num34 + 0f;
			fallAt = (Vector3)num25;
			goto IL_06db;
		}
		goto IL_0762;
		IL_079a:
		bool busy;
		result = (Vector3)busy;
		goto IL_063c;
		IL_0762:
		if ((object)who != null)
		{
			busy = who.Busy;
			bool flag10 = !busy;
			object obj28 = !flag10;
			if (obj28 == null)
			{
				float num35 = toldFor + num3;
				toldFor = num35;
			}
			if (~(landed ? 1u : 0u) == 0)
			{
				double num36 = (double)landedAfter + 0.25;
				if (!((double)toldFor < num36))
				{
					goto IL_04e7;
				}
			}
			if ((double)fellFor > 4.0)
			{
				goto IL_04e7;
			}
			goto IL_079a;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_06db:
		bool flag11 = num22 < 0f;
		object obj29 = !flag11;
		bool flag12 = num22 == 0f;
		object obj30 = !flag12;
		object obj31 = obj29 & obj30;
		if (obj31 == null)
		{
			object obj32 = this + 96;
			object obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v16+E4]");
			bool flag13 = (nint)0 == 0;
			object obj34 = !flag13;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj35 = default;
			if (Physics.Raycast((Vector3)(&obj35), (Vector3)4294961403L, out *(RaycastHit*)1, (float)obj32, 0, queryTriggerInteraction))
			{
				bool flag14 = Slammed((Vector3)4294961403L, (Vector3)1);
				bool flag15 = !flag14;
				object obj36 = !flag15;
				result = (Vector3)flag14;
				if (obj36 != null)
				{
					goto IL_063c;
				}
				landed = true;
				object obj37 = default;
				double num37 = (double)obj37 + 0.5;
			}
		}
		goto IL_0762;
		IL_04e7:
		falling = false;
		goto IL_079a;
		IL_063c:
		return result;
	}

	public GillaHeldApe()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected VT, but got Unknown
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+A0]");
		object obj3 = 0;
		tiltFollow = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+18]");
		object obj4 = default;
		Vector3 vector = (Vector3)(0 * obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+20]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB7C]");
		object obj5 = num * 0;
		yourEyes = vector;
		base._002Ector();
	}
}
