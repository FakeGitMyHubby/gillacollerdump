using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.XR;

public class SnapTurn : MonoBehaviour
{
	public float deadzone;

	public float smoothDeadzone;

	public static Vector2? TestStick;

	private bool latched;

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_04a7: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I
		//IL_04ef: Expected Obj, but got I4
		//IL_05bc: Expected Obj, but got I
		//IL_05de: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0179: Expected F4, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_00ea: Expected F4, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I4
		//IL_034d: Invalid comparison between F4 and I4
		//IL_01df: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_03d4: Invalid comparison between F4 and I4
		//IL_03e7: Expected Obj, but got F4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_041c: Expected Obj, but got I4
		//IL_0226: Invalid comparison between I4 and F4
		//IL_0267: Expected Obj, but got I4
		//IL_029b: Invalid comparison between F4 and I4
		//IL_02ae: Expected Obj, but got F4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got I4
		//IL_0318: Expected F4, but got I4
		//IL_030b: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (Object)obj8 == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAC8]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v11+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
		object obj14 = 0;
		float num;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v12+4]");
			num = 0f;
			object obj15 = 0;
			bool flag6 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v31+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector2 vector = GillaSticks.Read((XRNode)5, 0f, trustPushes: false);
			num = 0f;
			object obj15 = 0;
			bool flag6 = false;
		}
		object obj19 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int mode = GillaTurn.Mode;
		if (mode != 1)
		{
			bool flag9 = mode == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				bool flag10 = (byte)(~(latched ? 1u : 0u)) != 0;
				object obj22 = !flag10;
				if (obj22 == null && 0f > deadzone)
				{
					object obj23 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v24+E4]");
					bool flag11 = (nint)0 == 0;
					object obj24 = !flag11;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int snapAngle = GillaTurn.SnapAngle;
					bool flag12 = num < 0f;
					object obj25 = num ^ num;
					object obj26 = num & obj25;
					bool flag13 = (nint)obj26 < 0;
					int num2 = -snapAngle;
					bool flag14 = flag12 == flag13;
					object obj27 = !flag14;
					object obj28 = ~obj27;
					float degrees = ((obj28 != null) ? ((float)snapAngle) : ((float)num2));
					((Player)obj8).Turn(degrees);
					latched = true;
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				if ((nint)0 >= (nint)0)
				{
					return;
				}
			}
			latched = false;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		latched = false;
		float num3 = 0f - smoothDeadzone;
		if (num3 > 0f)
		{
			object obj29 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v18+E4]");
			bool flag15 = (nint)0 == 0;
			object obj30 = !flag15;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float degreesPerSecond = GillaTurn.DegreesPerSecond;
			float deltaTime = Time.deltaTime;
			float num4 = 0f - num3;
			bool flag16 = num < 0f;
			object obj31 = num ^ num;
			object obj32 = num & obj31;
			bool flag17 = (nint)obj32 < 0;
			bool flag18 = flag16 == flag17;
			object obj33 = !flag18;
			object obj34 = ~obj33;
			if (obj34 != null)
			{
				num4 = num3;
			}
			double num5 = 1.0 - (double)smoothDeadzone;
			float num6 = num4 / (float)num5;
			float num7 = num6 * degreesPerSecond;
			float degrees2 = num7 * deltaTime;
			((Player)obj8).Turn(degrees2);
		}
	}

	public SnapTurn()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B400]");
		deadzone = 0f;
		base._002Ector();
	}
}
