using System;
using Cpp2ILInjected;
using UnityEngine;

public class CosmeticToy : MonoBehaviour
{
	public ToyKind kind;

	public Transform grip;

	public Transform grab;

	public float reach = 0.2f;

	private const float PalmSkin = default(float);

	public static readonly Vector3 FingersInHand;

	public static readonly Vector3 HeadInHand;

	private const float IntoPalm = default(float);

	public Vector3 GrabPoint
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0159: Expected Obj, but got I4
			//IL_008a: Expected Obj, but got I4
			//IL_012f: Expected VT, but got Obj
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
			Transform transform;
			if (grab != null)
			{
				transform = grab;
			}
			else
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				transform = ((!(grip != null)) ? base.transform : grip);
			}
			if ((object)transform != null)
			{
				return transform.position;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public void PoseIn(Transform hand, float palmSide = default(float))
	{
		//IL_02c1: Expected VT, but got I
		//IL_0148: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_008f: Expected VT, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_010c: Expected VT, but got I4
		//IL_015f: Invalid comparison between F4 and I4
		//IL_02fb: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I4
		//IL_0342: Expected VT, but got I4
		//IL_0342: Expected VT, but got I4
		//IL_0223: Expected VT, but got I4
		//IL_0223: Expected VT, but got I4
		//IL_036c: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I4
		//IL_0278: Expected VT, but got I4
		//IL_0278: Expected VT, but got I4
		//IL_028b: Expected VT, but got I4
		//IL_028b: Expected VT, but got I4
		//IL_02a4: Expected VT, but got I4
		//IL_02a4: Expected VT, but got I4
		bool flag = kind != (ToyKind)2;
		IntPtr intPtr = default;
		Quaternion turn = (Quaternion)(nint)intPtr;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = grip == null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			turn = (Quaternion)0;
			if (obj4 == null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj6 = !flag5;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = grab == null;
				bool flag7 = !flag6;
				turn = (Quaternion)0;
				if (flag7)
				{
					Vector3 right = hand.right;
					if (palmSide < 0f)
					{
					}
					Vector3 lossyScale = hand.lossyScale;
					Quaternion rotation = hand.rotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
					object obj7 = 0;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v24+E4]");
					bool flag8 = (nint)0 == 0;
					object obj9 = !flag8;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Vector3 vector = (Quaternion)0 * (Vector3)0;
					Vector3 forward = default;
					Vector3 upwards = default;
					Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
					Quaternion rotation2 = grip.rotation;
					Quaternion rotation3 = default;
					Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation3);
					Vector3 position = grab.position;
					Vector3 position2 = grip.position;
					double num = 1.0 - 1.0;
					double num2 = -1.0 - -1.0;
					object obj11 = default;
					object obj10 = obj11 - obj11;
					Vector3 vector2 = (Quaternion)0 * (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj12 = 0;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v41+E4]");
					bool flag9 = (nint)0 == 0;
					object obj14 = !flag9;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Vector3 position3 = hand.position;
					Quaternion rotation4 = hand.rotation;
					Vector3 vector3 = (Quaternion)0 * (Vector3)0;
					Vector3 vector4 = (Quaternion)0 * (Vector3)0;
					PoseAt((Vector3)0, (Quaternion)0);
					return;
				}
			}
		}
		Vector3 position4 = hand.position;
		Quaternion rotation5 = hand.rotation;
		PoseAt((Vector3)0, turn);
	}

	public unsafe void Sit(Vector3 at, Vector3 behind)
	{
		//IL_0025: Expected VT, but got I4
		//IL_0025: Expected VT, but got Ref
		Vector3 forward = default;
		Vector3 upwards = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		PoseAt((Vector3)(&upwards), (Quaternion)0);
	}

	public void PoseAt(Vector3 at, Quaternion turn)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_00a3: Expected VT, but got I4
		//IL_0073: Expected VT, but got I4
		//IL_0073: Expected VT, but got I4
		//IL_00e1: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = grip == null;
		Transform transform = base.transform;
		if (flag2)
		{
			transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
			return;
		}
		Quaternion localRotation = grip.localRotation;
		Quaternion rotation = default;
		Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation);
		transform.rotation = (Quaternion)0;
		Transform transform2 = base.transform;
		Vector3 position = transform2.position;
		Vector3 position2 = grip.position;
		transform2.position = (Vector3)0;
	}

	public static float Elastic(float t)
	{
		//IL_0009: Invalid comparison between F4 and I4
		//IL_001a: Expected Obj, but got I4
		//IL_0023: Invalid comparison between F4 and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0048: Expected F4, but got I4
		bool flag = t < 0f;
		object obj = !flag;
		bool flag2 = t == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		float result = 0f;
		if (obj3 == null)
		{
			bool flag3 = !((double)t < 1.0);
			result = 1f;
			if (!flag3)
			{
				float num = t * -10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				float num2 = t;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9A4]");
				float num3 = num2 + 0f;
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F8]");
				float num5 = num4 * 0f;
				float num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num7 = num6 / 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				float num8 = num * num7;
				result = num8 + 1f;
			}
		}
		return result;
	}

	static CosmeticToy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B280]");
		obj3 = 0;
		object obj4 = obj;
		_ = 1056964608;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X10_v1+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B040]");
		_ = 0;
		_ = 1063105069;
	}
}
