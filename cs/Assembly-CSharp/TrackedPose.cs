using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public class TrackedPose : MonoBehaviour
{
	public XRNode node = (XRNode)3;

	public float maxHeadHeight;

	public float armLength;

	private const float LostFor = default(float);

	private const float FurthestReach = default(float);

	private static readonly Vector3 RestFromEyes;

	private const float RestFingersDown = default(float);

	private const float SettleTime = default(float);

	private float lostAt;

	private float parkedAt = -1f;

	private Vector3 parkFrom;

	private Quaternion parkFromTurn;

	private Transform _head;

	private ApeAvatarDriver _body;

	private bool _lookedForHead;

	private bool _lookedForBody;

	private void Update()
	{
		Apply();
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC68]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender += unityAction;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC68]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction;
		parkedAt = -1f;
	}

	private unsafe void Apply()
	{
		//IL_05f8: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I8
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_06f8: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0641: Expected Obj, but got I
		//IL_0649: Expected VT, but got Obj
		//IL_065a: Expected VT, but got Obj
		//IL_0673: Expected Obj, but got I4
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_0695: Expected Obj, but got I8
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_06d7: Expected Obj, but got I4
		//IL_06df: Expected Obj, but got Ref
		//IL_00d4: Expected Obj, but got I4
		//IL_00f9: Invalid comparison between F4 and I4
		//IL_0068: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got Ref
		//IL_0081: Expected Obj, but got I4
		//IL_073b: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I
		//IL_088a: Expected VT, but got I
		//IL_08a6: Expected Obj, but got I4
		//IL_08ae: Expected Obj, but got Ref
		//IL_08b6: Expected VT, but got F4
		//IL_08c6: Expected VT, but got I
		//IL_01a6: Expected VT, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_0827: Expected Obj, but got I
		//IL_0840: Expected VT, but got I
		//IL_08e4: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I
		//IL_0904: Expected VT, but got Obj
		//IL_01f8: Invalid comparison between F4 and I4
		//IL_05e2: Expected VT, but got I4
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_04b8: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I4
		//IL_04ca: Expected F8, but got I4
		//IL_04e2: Expected Obj, but got Ref
		//IL_04eb: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got Ref
		//IL_0503: Expected F8, but got I
		//IL_0513: Expected VT, but got I
		//IL_0263: Expected Obj, but got I4
		//IL_0788: Expected Obj, but got I
		//IL_07a1: Expected VT, but got I
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_053e: Expected VT, but got I4
		//IL_0571: Expected VT, but got I4
		//IL_07e8: Expected Obj, but got I4
		//IL_07f1: Expected F8, but got I4
		//IL_0809: Expected Obj, but got Ref
		//IL_02a0: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got Ref
		//IL_02b8: Expected F8, but got I
		//IL_02c8: Expected VT, but got I
		//IL_03cc: Expected Obj, but got I4
		//IL_03d5: Expected F8, but got I4
		//IL_03ed: Expected Obj, but got Ref
		//IL_02e3: Expected Obj, but got VT
		//IL_0340: Expected F8, but got I
		//IL_0350: Invalid comparison between F8 and I
		//IL_0362: Expected Obj, but got I4
		//IL_0372: Expected F8, but got I
		//IL_037a: Expected Obj, but got Ref
		//IL_0382: Expected VT, but got F8
		//IL_0392: Expected VT, but got I
		//IL_0408: Expected Obj, but got VT
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected VT, but got Unknown
		//IL_046b: Expected Obj, but got I4
		//IL_0483: Expected F8, but got I
		//IL_048b: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
		object obj = 0;
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		XRNode xRNode;
		bool flag3;
		bool flag5;
		object obj12;
		if (inputDevice.isValid)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v53+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v53+A0]");
			object obj4 = 0;
			InputFeatureUsage<bool> inputFeatureUsage = (InputFeatureUsage<bool>)obj4;
			bool flag2 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)obj4, out var value);
			xRNode = node;
			object obj5 = !flag2;
			object obj6 = 1 & obj5;
			object obj7 = (long)node & 0xFFFFFFFEL;
			object obj8 = value | obj6;
			object obj9 = obj7 - 4;
			flag3 = obj9 == null;
			bool flag4 = obj8 == null;
			object obj10 = 0;
			object obj11 = (object)(&value);
			if (!flag4)
			{
				lostAt = -1f;
				obj10 = 0;
				obj11 = (object)(&value);
				flag5 = flag3;
				obj12 = 0;
				goto IL_0706;
			}
		}
		else
		{
			xRNode = node;
			object obj13 = (long)node & 0xFFFFFFFEL;
			object obj14 = obj13 - 4;
			flag3 = obj14 == null;
		}
		object obj15 = !flag3;
		if (obj15 != null)
		{
			return;
		}
		object obj16 = xRNode - 4;
		bool flag6 = obj16 == null;
		int which = ((!flag6) ? 1 : 0);
		if (lostAt < 0f)
		{
			float unscaledTime = Time.unscaledTime;
			lostAt = unscaledTime;
		}
		float num = default;
		double num2;
		if (inputDevice.isValid)
		{
			float unscaledTime2 = Time.unscaledTime;
			num = unscaledTime2 - lostAt;
			if (!((double)num > 1.5))
			{
				num2 = 1.5;
				flag5 = true;
				InputFeatureUsage<bool> inputFeatureUsage = (InputFeatureUsage<bool>)0;
				obj12 = 1;
				goto IL_0706;
			}
		}
		bool isDeviceActive = XRSettings.isDeviceActive;
		Rest(which, isDeviceActive);
		return;
		IL_0706:
		object obj17 = obj;
		parkedAt = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v8+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v5+98]");
		bool flag8 = inputDevice.TryGetFeatureValue((InputFeatureUsage<Vector3>)0, out var value2);
		bool flag9 = !flag8;
		object obj20 = 0;
		object obj21 = (object)(&value2);
		Vector3 vector = (Vector3)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v5+98]");
		Vector3 vector2 = (Vector3)0;
		object obj27;
		double num4;
		double num6 = default;
		double num8 = default;
		object obj28;
		bool flag12;
		Vector3 value3;
		double num13;
		double num5;
		double num7;
		if (!flag9)
		{
			double num3 = default;
			if (node != (XRNode)3 || !(maxHeadHeight > 0f) || !(num3 > (double)maxHeadHeight))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj22 = 0;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v15+A0]");
				object obj24 = 0;
				vector = (Vector3)obj24;
				if (!flag5)
				{
					object obj25 = obj12 & 1;
					bool flag10 = obj25 == null;
					object obj26 = !flag10;
					obj27 = 0;
					num4 = 0.0;
					num5 = num6;
					num7 = num8;
					obj28 = (object)(&value2);
					obj20 = 0;
					obj21 = (object)(&value2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v16+8]");
					num2 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v5+98]");
					vector2 = (Vector3)0;
					if (obj26 == null)
					{
						goto IL_0521;
					}
					goto IL_0576;
				}
			}
			InputDevice deviceAtXRNode2 = InputDevices.GetDeviceAtXRNode((XRNode)3);
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v29+E4]");
			bool flag11 = (nint)0 == 0;
			object obj30 = !flag11;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj29 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v29+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v19+98]");
			InputDevice inputDevice2 = default;
			flag12 = inputDevice2.TryGetFeatureValue((InputFeatureUsage<Vector3>)0, out value3);
			object obj32 = obj12 & 1;
			if (obj32 == null)
			{
				goto IL_07d0;
			}
			bool flag13 = !flag12;
			obj20 = 0;
			obj21 = (object)(&value3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v16+8]");
			num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v19+98]");
			vector2 = (Vector3)0;
			if (!flag13)
			{
				object obj33 = value2 - value3;
				double num9 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v16+8]");
				double num10 = num9 - 0.0;
				object obj34 = obj33 * obj33;
				double num11 = num10 * num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				double num12 = (double)obj34 + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD18]");
				num2 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD18]");
				bool flag14 = !(num12 < 0.0);
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v16+8]");
				num13 = 0.0;
				obj21 = (object)(&value3);
				vector = (Vector3)num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v19+98]");
				vector2 = (Vector3)0;
				if (!flag14)
				{
					flag12 = true;
					goto IL_07d0;
				}
			}
		}
		goto IL_0576;
		IL_0521:
		Transform transform = base.transform;
		transform.localPosition = (Vector3)0;
		obj20 = obj27;
		num13 = num4;
		obj21 = obj28;
		num2 = maxHeadHeight;
		Vector3 vector3 = default;
		vector = vector3;
		vector2 = (Vector3)0;
		goto IL_0576;
		IL_0576:
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v15+E4]");
		bool flag15 = (nint)0 == 0;
		object obj36 = !flag15;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v15+A0]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9+160]");
		if (inputDevice.TryGetFeatureValue((InputFeatureUsage<Quaternion>)0, out var _))
		{
			Transform transform2 = base.transform;
			transform2.localRotation = (Quaternion)0;
		}
		return;
		IL_07d0:
		bool flag16 = !flag12;
		obj27 = 0;
		num4 = 0.0;
		num5 = num6;
		num7 = num8;
		obj28 = (object)(&value3);
		if (!flag16)
		{
			bool flag17 = (double)armLength == 1.0;
			obj27 = 0;
			num4 = 0.0;
			num5 = num6;
			num7 = num8;
			obj28 = (object)(&value3);
			if (!flag17)
			{
				object obj38 = value2 - value3;
				double num14 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v16+8]");
				num5 = num14 - 0.0;
				object obj40 = default;
				object obj39 = obj38 * obj40;
				double num15 = (double)armLength * num5;
				vector3 = value3 + obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v16+8]");
				double num16 = 0.0 + num15;
				obj27 = 0;
				num4 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v16+8]");
				num7 = 0.0;
				obj28 = (object)(&value3);
			}
		}
		goto IL_0521;
	}

	private unsafe void Rest(int which, bool counts)
	{
		//IL_0083: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_0c3d: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_026b: Invalid comparison between F4 and I4
		//IL_0105: Expected Obj, but got I4
		//IL_0c61: Expected Obj, but got I4
		//IL_0c6a: Expected Obj, but got I4
		//IL_068d: Expected Obj, but got I4
		//IL_06ca: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I4
		//IL_02dd: Expected VT, but got F4
		//IL_03e4: Expected Obj, but got I4
		//IL_0cd7: Expected Obj, but got I
		//IL_0ce7: Expected F4, but got I
		//IL_0cf7: Expected F4, but got I
		//IL_0d07: Expected F4, but got I
		//IL_0d16: Expected VT, but got I4
		//IL_0d16: Expected VT, but got I4
		//IL_0d55: Invalid comparison between F4 and I
		//IL_01c0: Expected Obj, but got I
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_032a: Expected VT, but got F4
		//IL_020a: Expected I4, but got Obj
		//IL_1088: Expected Obj, but got I
		//IL_10a9: Expected VT, but got I
		//IL_10c1: Expected F4, but got I
		//IL_10d1: Expected F4, but got I
		//IL_10da: Expected Obj, but got I4
		//IL_1038: Expected Obj, but got I
		//IL_1062: Expected Obj, but got I4
		//IL_0d8b: Invalid comparison between F4 and I
		//IL_0463: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_04c2: Expected Obj, but got I4
		//IL_0a35: Expected Obj, but got I
		//IL_0a5f: Expected Obj, but got I4
		//IL_04d9: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I4
		//IL_0dda: Expected VT, but got I4
		//IL_0dda: Expected VT, but got I4
		//IL_0c91: Expected Obj, but got I4
		//IL_0df2: Expected VT, but got I4
		//IL_0df2: Expected VT, but got I4
		//IL_0e05: Expected VT, but got I4
		//IL_0e05: Expected VT, but got I4
		//IL_0e21: Expected Obj, but got F8
		//IL_0e39: Expected Obj, but got F8
		//IL_0e51: Expected Obj, but got F8
		//IL_0992: Expected Obj, but got I4
		//IL_0aa6: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I
		//IL_0553: Expected Obj, but got I4
		//IL_0f35: Invalid comparison between F4 and I4
		//IL_0f44: Expected F8, but got I4
		//IL_0587: Expected Obj, but got I
		//IL_05a5: Expected Obj, but got I4
		//IL_0ff7: Invalid comparison between F8 and I4
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_063b: Expected Obj, but got I
		//IL_064e: Expected Obj, but got I4
		//IL_065e: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		//IL_05f0: Expected Obj, but got I4
		//IL_0b84: Expected VT, but got I4
		//IL_0611: Expected Obj, but got I4
		//IL_0bd3: Expected VT, but got I4
		bool flag2 = default;
		bool flag = !flag2;
		int num = which;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v140+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaOneArm.Rest(which);
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		bool flag4 = (byte)(~(_lookedForHead ? 1u : 0u)) != 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Transform parent = transform.parent;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v65+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = parent != null;
				bool flag7 = !flag6;
				flag2 = false;
				num = 0;
				if (flag7)
				{
					goto IL_0c13;
				}
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Transform parent2 = transform2.parent;
					if ((object)parent2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4900]");
						object n = 0;
						Transform transform3 = parent2.Find((string)n);
						object obj8 = this + 80;
						obj8 = transform3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1;
						flag2 = false;
						num = (int)transform3;
						goto IL_0c13;
					}
				}
			}
			goto IL_0bd9;
		}
		goto IL_0c13;
		IL_0620:
		object obj9 = this + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v60+20]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v60+20]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		goto IL_0663;
		IL_0c9f:
		double num2 = ((which != 0) ? 1.0 : (-1.0));
		float num4;
		float num6;
		float num8;
		Vector3 upwards = default;
		Quaternion forward2 = default;
		if ((object)_head != null)
		{
			Vector3 localPosition = _head.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC78]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ X0_v18+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			Vector3 vector2 = (Quaternion)0 * (Vector3)0;
			Vector3 vector3 = (Quaternion)0 * (Vector3)0;
			double num3 = num2 * (double)num4;
			object obj15 = 0.0 - num3;
			double num5 = num2 * (double)num6;
			object obj16 = 0.0 - num5;
			double num7 = num2 * (double)num8;
			object obj17 = 0.0 - num7;
			float num9 = num4 * (float)obj16;
			float num10 = num6 * (float)obj15;
			float num11 = num6 * (float)obj17;
			float num12 = num8 * (float)obj16;
			float num13 = num8 * (float)obj15;
			float num14 = num4 * (float)obj17;
			float num15 = num9 - num10;
			float num16 = num11 - num12;
			float num17 = num13 - num14;
			Vector3 forward = default;
			Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			object obj18 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			object obj19 = !flag9;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(_body != null) || (object)_body != null)
			{
				Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref forward);
				float unscaledTime = Time.unscaledTime;
				float num18 = unscaledTime - parkedAt;
				float num19 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num20 = num19 / 0f;
				bool flag10 = num20 < 0f;
				double num21 = 0.0;
				if (!flag10)
				{
					bool flag11 = (double)num20 > 1.0;
					num21 = 1.0;
					if (!flag11)
					{
						num21 = num20;
					}
				}
				double num22 = num21 + num21;
				double num23 = num21 * 3.0;
				double num24 = num21 * num22;
				double num25 = num21 * num24;
				double num26 = num21 * num23;
				double num27 = num26 - num25;
				double num28 = 1.0 - num27;
				double num29 = num28 * 0.0;
				double num30 = num27 + num29;
				Transform transform4 = base.transform;
				if ((!(num30 < 0.0) && num30 > 1.0) || (object)transform4 != null)
				{
					transform4.localPosition = (Vector3)0;
					Transform transform5 = base.transform;
					Quaternion b = default;
					Quaternion quaternion3 = Quaternion.Internal_Slerp(ref forward2, ref b, (float)num30);
					if ((object)transform5 != null)
					{
						transform5.localRotation = (Quaternion)0;
						return;
					}
				}
			}
		}
		goto IL_0bd9;
		IL_0c13:
		object obj20 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v4+E4]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = _head == null;
		bool flag14 = !flag13;
		object obj22 = !flag14;
		if (obj22 != null)
		{
			return;
		}
		float num31 = parkedAt;
		bool flag15 = !(parkedAt < 0f);
		obj11 = null;
		if (!flag15)
		{
			num31 = (parkedAt = Time.unscaledTime);
			Transform transform6 = base.transform;
			if ((object)transform6 != null)
			{
				Vector3 localPosition2 = transform6.localPosition;
				parkFrom = (Vector3)num31;
				Transform transform7 = base.transform;
				if ((object)transform7 != null)
				{
					Quaternion localRotation = transform7.localRotation;
					parkFromTurn = (Quaternion)num31;
					obj11 = null;
					goto IL_0c4b;
				}
			}
			goto IL_0bd9;
		}
		goto IL_0c4b;
		IL_0c4b:
		bool flag16 = (byte)(~(_lookedForBody ? 1u : 0u)) != 0;
		object obj23 = !flag16;
		obj10 = 0;
		if (obj23 != null)
		{
			goto IL_0663;
		}
		Transform transform8 = base.transform;
		if ((object)transform8 != null)
		{
			Transform parent3 = transform8.parent;
			object obj24 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v54+E4]");
			bool flag17 = (nint)0 == 0;
			object obj25 = !flag17;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18 = parent3 != null;
			bool flag19 = !flag18;
			obj10 = 0;
			obj11 = null;
			if (flag19)
			{
				goto IL_0663;
			}
			_lookedForBody = true;
			Transform transform9 = base.transform;
			if ((object)transform9 != null)
			{
				Transform parent4 = transform9.parent;
				if ((object)parent4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC70]");
					object obj26 = 0;
					obj10 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
					object obj27 = default;
					if (obj27 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v101+18]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v101+18]");
						bool flag20 = (nint)0 < (nint)1;
						obj11 = (UnityEngine.Object)1;
						if (flag20)
						{
							goto IL_0663;
						}
						object obj29 = 0;
						UnityEngine.Object obj30 = (UnityEngine.Object)1;
						while (true)
						{
							bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28);
							object obj31 = !flag21;
							if (obj31 != null)
							{
								break;
							}
							object obj32 = obj27 + obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v60+20]");
							UnityEngine.Object obj33 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v60+20]");
							if ((nint)0 != 0)
							{
								object obj34 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X0_v103+E4]");
								bool flag22 = (nint)0 == 0;
								object obj35 = !flag22;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X22_v12 (UnityEngine.Object)+20]");
								bool flag23 = (UnityEngine.Object)0 == _head;
								bool flag24 = !flag23;
								object obj36 = !flag24;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v101+18]");
									obj28 = 0;
									obj29++;
									object obj37 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v101+18]");
									bool flag25 = (nint)obj37 < 0;
									obj10 = 0;
									obj30 = _head;
									if (flag25)
									{
										continue;
									}
									goto IL_0608;
								}
								goto IL_0620;
							}
							goto IL_0bd9;
						}
						goto IL_0be7;
					}
				}
			}
		}
		goto IL_0bd9;
		IL_0997:
		if ((object)_head == null)
		{
			goto IL_0bd9;
		}
		Quaternion localRotation2 = _head.localRotation;
		object obj39;
		object obj38 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v27+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v28+48]");
		float num32 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v28+4C]");
		float num33 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v28+50]");
		float num34 = 0f;
		Vector3 vector4 = (Quaternion)0 * (Vector3)0;
		float num35 = num31 * num31;
		object obj42 = default;
		object obj41 = obj42 * obj42;
		float num36 = num35 + (float)obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num38 = default;
		if (num36 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj43 = 0;
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X0_v68+E4]");
			bool flag26 = (nint)0 == 0;
			object obj45 = !flag26;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num37 = num38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num37 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
		}
		object obj46 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v33+A0]");
		object obj47 = 0;
		Quaternion quaternion4 = Quaternion.Internal_LookRotation(ref *(Vector3*)(&forward2), ref upwards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v34+18]");
		upwards = (Vector3)0;
		num6 = num35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v34+20]");
		num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v34+18]");
		num8 = 0f;
		object obj48 = 0;
		goto IL_0c9f;
		IL_0608:
		obj10 = 0;
		obj11 = _head;
		goto IL_0663;
		IL_0bd9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0be7;
		IL_0be7:
		throw new IndexOutOfRangeException();
		IL_0663:
		object obj49 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v11+E4]");
		bool flag27 = (nint)0 == 0;
		object obj50 = !flag27;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag28 = _body != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		obj39 = 0;
		if (!flag28)
		{
			goto IL_0997;
		}
		if ((object)_body != null)
		{
			if (!_body.isActiveAndEnabled)
			{
				goto IL_0997;
			}
			Transform transform10 = base.transform;
			if ((object)transform10 != null)
			{
				Transform parent5 = transform10.parent;
				if ((object)parent5 != null)
				{
					Quaternion rotation = parent5.rotation;
					Quaternion quaternion5 = Quaternion.Internal_Inverse(ref forward2);
					if ((object)_body != null)
					{
						Transform transform11 = _body.transform;
						if ((object)transform11 != null)
						{
							Quaternion rotation2 = transform11.rotation;
							float num39 = num38 * num31;
							float num40 = num31 * num38;
							object obj51 = default;
							float num41 = num38 * (float)obj51;
							float num42 = (float)obj51 * num38;
							float num43 = num38 * (float)obj42;
							float num44 = (float)obj42 * num38;
							float num45 = num38 * num38;
							float num46 = num31 * num31;
							float num47 = num39 + num40;
							object obj52 = obj51 * obj42;
							float num48 = num31 * (float)obj42;
							float num49 = num41 + num42;
							float num50 = (float)obj42 * num31;
							float num51 = (float)obj51 * num31;
							float num52 = num43 + num44;
							float num53 = num31 * (float)obj51;
							num35 = (float)obj42 * (float)obj42;
							float num54 = num45 - num46;
							object obj53 = obj51 * obj51;
							object obj54 = obj42 * obj51;
							num32 = (float)obj52 + num47;
							num33 = num50 + num49;
							num34 = num53 + num52;
							num38 = num54 - (float)obj53;
							num8 = num32 - (float)obj54;
							num4 = num33 - num48;
							num6 = num34 - num51;
							obj48 = 0;
							goto IL_0c9f;
						}
					}
				}
			}
		}
		goto IL_0bd9;
	}

	public TrackedPose()
	{
		//IL_0028: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C0A0]");
		armLength = 0f;
		base._002Ector();
	}

	static TrackedPose()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC78]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BC10]");
		obj3 = 0;
		_ = 3175926989L;
	}
}
