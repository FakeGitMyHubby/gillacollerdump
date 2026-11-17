using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class DesktopTestRig : MonoBehaviour
{
	public Transform head;

	public Transform leftHand;

	public Transform rightHand;

	public float moveSpeed;

	public float lookSpeed;

	private float yaw;

	private float pitch;

	private bool active;

	private static readonly Quaternion GripFromAim;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected I4, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I
		//IL_0246: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isEditor)
		{
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)3);
			UnityEngine.XR.InputDevice inputDevice = default;
			bool isValid = inputDevice.isValid;
			object obj4 = !isValid;
			object obj5 = !isValid;
			bool flag2 = (byte)(1 & obj5) != 0;
			active = flag2;
			object obj6 = obj4 & 1;
			bool flag3 = obj6 == null;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				enabled = false;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Object obj12 = default;
			bool flag5 = obj12 != null;
			bool flag6 = !flag5;
			object obj13 = 0;
			bool flag7 = false;
			if (!flag6)
			{
				((Behaviour)obj12).enabled = false;
				obj13 = 0;
				flag7 = false;
			}
			object obj14 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v20+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = head != null;
			bool flag10 = !flag9;
			Object obj16 = null;
			if (!flag10)
			{
				head.localPosition = (Vector3)0;
				Vector3 localEulerAngles = head.localEulerAngles;
				yaw = 1.5f;
				obj16 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v25+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE8]");
			object message = 0;
			Debug.Log(message);
		}
		else
		{
			enabled = false;
		}
	}

	private void Update()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_0cba: Expected Obj, but got I
		//IL_0cd2: Expected Obj, but got I
		//IL_0cec: Expected Obj, but got I4
		//IL_0d0a: Expected Obj, but got I
		//IL_0d22: Expected Obj, but got I
		//IL_0e56: Expected Obj, but got I
		//IL_0e6e: Expected Obj, but got I
		//IL_01d4: Expected VT, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_0452: Expected F8, but got I4
		//IL_045b: Expected F8, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0163: Invalid comparison between F4 and I8
		//IL_0180: Expected F4, but got I8
		//IL_022a: Expected Obj, but got I4
		//IL_05ff: Expected F8, but got I4
		//IL_0197: Invalid comparison between F4 and I4
		//IL_0db3: Expected Obj, but got I
		//IL_0ddd: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I4
		//IL_026f: Expected F8, but got I4
		//IL_01bf: Expected F4, but got I4
		//IL_06c7: Expected VT, but got I4
		//IL_055c: Expected F8, but got I
		//IL_0571: Invalid comparison between F8 and I
		//IL_0583: Expected F8, but got I4
		//IL_058c: Expected F8, but got I4
		//IL_0595: Expected F8, but got I4
		//IL_07a4: Expected F8, but got I
		//IL_07b4: Expected F8, but got I
		//IL_07bd: Expected VT, but got I4
		//IL_0ebd: Expected Obj, but got I4
		//IL_05e9: Expected F8, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_07f9: Expected VT, but got I4
		//IL_0b4e: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I4
		//IL_0768: Expected F8, but got I
		//IL_03d9: Expected Obj, but got I4
		//IL_0392: Expected F8, but got I4
		//IL_0839: Expected VT, but got I4
		//IL_0839: Expected VT, but got I4
		//IL_0e21: Expected Obj, but got I4
		//IL_087f: Expected VT, but got I4
		//IL_078f: Expected F8, but got I
		//IL_0bca: Expected VT, but got I4
		//IL_0bca: Expected VT, but got I4
		//IL_08a3: Expected Obj, but got I
		//IL_08cd: Expected Obj, but got I4
		//IL_0e41: Expected VT, but got I4
		//IL_0c10: Expected VT, but got I4
		//IL_0902: Expected Obj, but got I
		//IL_0b16: Expected VT, but got I4
		//IL_0b1f: Expected VT, but got I4
		//IL_0c34: Expected Obj, but got I
		//IL_0c5e: Expected Obj, but got I4
		//IL_0c8b: Expected VT, but got I4
		if (~(active ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10+A0]");
		object obj7 = 0;
		bool flag4 = obj7 == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D08]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v17+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v22+A0]");
		object obj14 = 0;
		object obj15 = obj14;
		float num2 = default;
		float num6 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X21_v4+1D0]");
			if (((ButtonControl)0).isPressed)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X21_v4+190]");
				Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				object obj17 = default;
				object obj16 = obj17 * 0;
				float num = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				float num3 = num * 0f;
				float num4 = (float)obj16 * lookSpeed;
				float num5 = num3 * lookSpeed;
				num2 = pitch - num4;
				num6 = yaw + num5;
				bool flag5 = num2 < 3.265921E+09f;
				yaw = num6;
				float num7 = 3.265921E+09f;
				if (!flag5)
				{
					bool flag6 = !(num2 > 1.1184374E+09f);
					num7 = num2;
					if (!flag6)
					{
						num7 = 1.1184374E+09f;
					}
				}
				pitch = num7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		double num8 = (double)yaw * (double)num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		head.localRotation = (Quaternion)0;
		double num9;
		if (obj11 != null)
		{
			KeyControl wKey = ((Keyboard)obj11).wKey;
			bool isPressed = wKey.isPressed;
			bool flag7 = !isPressed;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				KeyControl upArrowKey = ((Keyboard)obj11).upArrowKey;
				bool isPressed2 = upArrowKey.isPressed;
				bool flag8 = !isPressed2;
				num9 = 0.0;
				if (flag8)
				{
					goto IL_0d6d;
				}
			}
			num9 = 1.0;
			goto IL_0d6d;
		}
		double num10 = 0.0;
		num9 = 0.0;
		goto IL_0460;
		IL_0460:
		Vector3 forward = head.forward;
		double num11 = num9 * (double)num6;
		double num12 = num9 * num8;
		Vector3 right = head.right;
		double num13 = num10 * num8;
		double num14 = num10 * (double)num6;
		double num15 = num12 + num13;
		double num16 = num11 + num14;
		double num17 = num15 * num15;
		double num18 = num16 * num16;
		double num19 = num17 + num18;
		double num20;
		double num21;
		double num22;
		if (!(num19 > 1.0))
		{
			num20 = num16;
			num21 = 0.0;
			num22 = num15;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v70+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num18 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			bool flag10 = !(1.0 > 0.0);
			num20 = 0.0;
			num21 = 0.0;
			num22 = 0.0;
			if (!flag10)
			{
				num22 = num15 / 1.0;
				num21 = 0.0 / 1.0;
				num20 = num16 / 1.0;
				num18 = 0.0;
			}
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		double num23 = num22 * (double)moveSpeed;
		double num24 = num21 * (double)moveSpeed;
		double num25 = num20 * (double)moveSpeed;
		float deltaTime = Time.deltaTime;
		double num26 = num23 * (double)deltaTime;
		float num27 = (float)num24 * deltaTime;
		float num28 = (float)num25 * deltaTime;
		double num29 = 1.0 + num26;
		float num30 = (float)num18 + num27;
		float num31 = num6 + num28;
		transform.position = (Vector3)0;
		if (obj11 != null)
		{
			KeyControl qKey = ((Keyboard)obj11).qKey;
			bool isPressed3 = qKey.isPressed;
			KeyControl eKey = ((Keyboard)obj11).eKey;
			bool flag11 = !isPressed3;
			object obj22 = !flag11;
			object obj23 = ~obj22;
			if (obj23 == null)
			{
				double num32 = 0.75;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
				double num32 = 0.0;
			}
			bool isPressed4 = eKey.isPressed;
			bool flag12 = !isPressed4;
			object obj24 = !flag12;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				double num33 = 0.75;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
				double num33 = 0.0;
			}
			Vector3 vector2 = (Vector3)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			double num32 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			double num33 = 0.0;
			Vector3 vector2 = (Vector3)0;
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v26+E4]");
		bool flag13 = (nint)0 == 0;
		object obj27 = !flag13;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = leftHand != null;
		bool flag15 = !flag14;
		Quaternion quaternion2 = (Quaternion)0;
		if (!flag15)
		{
			Vector3 position2 = head.position;
			Quaternion rotation = head.rotation;
			Vector3 vector3 = (Quaternion)0 * (Vector3)0;
			float num34 = num31 + num31;
			float num35 = num30 + num30;
			double num36 = num29 + num29;
			leftHand.position = (Vector3)0;
			Quaternion rotation2 = head.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CF0]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v58+E4]");
			bool flag16 = (nint)0 == 0;
			object obj30 = !flag16;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj31 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v37+A0]");
			object obj32 = 0;
			double num37 = num36 * (double)obj32;
			float num38 = num28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+4]");
			float num39 = num38 * 0f;
			float num40 = num28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+C]");
			float num41 = num40 * 0f;
			float num42 = num28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+8]");
			float num43 = num42 * 0f;
			float num44 = num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+C]");
			float num45 = num44 * 0f;
			float num46 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+C]");
			float num47 = num46 * 0f;
			float num48 = num28 * (float)obj32;
			double num49 = num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+C]");
			double num50 = num49 * 0.0;
			double num51 = num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+8]");
			double num52 = num51 * 0.0;
			float num53 = num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+4]");
			float num54 = num53 * 0f;
			float num55 = num41 - (float)num37;
			float num56 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+4]");
			float num57 = num56 * 0f;
			float num58 = num45 + num43;
			double num59 = num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+4]");
			double num60 = num59 * 0.0;
			float num61 = num47 + num39;
			float num62 = num34 * (float)obj32;
			double num63 = num50 + (double)num48;
			float num64 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+8]");
			float num65 = num64 * 0f;
			float num66 = num35 * (float)obj32;
			float num67 = num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v38+8]");
			float num68 = num67 * 0f;
			float num69 = num55 - num57;
			double num70 = num60 + (double)num58;
			float num71 = num62 + num61;
			double num72 = num63 + (double)num65;
			num28 = num69 - num68;
			num31 = (float)num70 - num66;
			num30 = num71 - (float)num52;
			num29 = num72 - (double)num54;
			leftHand.rotation = (Quaternion)0;
			quaternion2 = (Quaternion)0;
		}
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v31+E4]");
		bool flag17 = (nint)0 == 0;
		object obj34 = !flag17;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (rightHand != null)
		{
			Vector3 position3 = head.position;
			Quaternion rotation3 = head.rotation;
			Vector3 vector4 = (Quaternion)0 * (Vector3)0;
			float num73 = num31 + num31;
			float num74 = num30 + num30;
			double num75 = num29 + num29;
			rightHand.position = (Vector3)0;
			Quaternion rotation4 = head.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CF0]");
			object obj35 = 0;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v44+E4]");
			bool flag18 = (nint)0 == 0;
			object obj37 = !flag18;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			rightHand.rotation = (Quaternion)0;
		}
		return;
		IL_0d91:
		KeyControl aKey = ((Keyboard)obj11).aKey;
		bool isPressed5 = aKey.isPressed;
		bool flag19 = !isPressed5;
		object obj38 = !flag19;
		if (obj38 == null)
		{
			KeyControl leftArrowKey = ((Keyboard)obj11).leftArrowKey;
			if (!leftArrowKey.isPressed)
			{
				goto IL_0460;
			}
		}
		num10 += -1.0;
		num8 = -1.0;
		goto IL_0460;
		IL_0d6d:
		KeyControl sKey = ((Keyboard)obj11).sKey;
		bool isPressed6 = sKey.isPressed;
		bool flag20 = !isPressed6;
		object obj39 = !flag20;
		if (obj39 == null)
		{
			KeyControl downArrowKey = ((Keyboard)obj11).downArrowKey;
			if (!downArrowKey.isPressed)
			{
				goto IL_0d7f;
			}
		}
		num9 += -1.0;
		num8 = -1.0;
		goto IL_0d7f;
		IL_0d7f:
		KeyControl dKey = ((Keyboard)obj11).dKey;
		bool isPressed7 = dKey.isPressed;
		bool flag21 = !isPressed7;
		object obj40 = !flag21;
		if (obj40 == null)
		{
			KeyControl rightArrowKey = ((Keyboard)obj11).rightArrowKey;
			bool isPressed8 = rightArrowKey.isPressed;
			bool flag22 = !isPressed8;
			num10 = 0.0;
			if (flag22)
			{
				goto IL_0d91;
			}
		}
		num10 = 1.0;
		goto IL_0d91;
	}

	public DesktopTestRig()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B898]");
		moveSpeed = 0f;
		base._002Ector();
	}

	static DesktopTestRig()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CF0]");
		object obj = 0;
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C420]");
		obj3 = 0;
	}
}
