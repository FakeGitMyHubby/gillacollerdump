using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;

public static class GillaTeleport
{
	private const int Floors = default(int);

	public unsafe static bool To(Vector3 feet, Vector3 facing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0603: Expected Obj, but got I4
		//IL_0629: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I4
		//IL_087f: Expected Obj, but got I
		//IL_08a9: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_05d9: Expected I4, but got Obj
		//IL_00cc: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0134: Expected VT, but got I4
		//IL_013e: Expected VT, but got I4
		//IL_0186: Expected Obj, but got I
		//IL_066e: Expected Obj, but got I
		//IL_067e: Expected Obj, but got I
		//IL_06a8: Expected Obj, but got I4
		//IL_01ec: Expected VT, but got I8
		//IL_01ec: Expected VT, but got Ref
		//IL_06e0: Expected Obj, but got I
		//IL_08d4: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_0901: Expected Obj, but got I
		//IL_0933: Expected Obj, but got I
		//IL_0943: Expected Obj, but got I
		//IL_095a: Invalid comparison between F4 and Obj
		//IL_0373: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		//IL_073c: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I
		//IL_07dd: Invalid comparison between F4 and I
		//IL_04ee: Invalid comparison between F8 and I
		//IL_082b: Expected VT, but got I4
		//IL_083b: Expected Obj, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_059c: Expected VT, but got I4
		//IL_05af: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v6+A0]");
		object obj8 = 0;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			if (obj8 != null)
			{
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v15+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X19_v3 (UnityEngine.Object)+20]");
				if ((UnityEngine.Object)0 == null)
				{
					goto IL_011c;
				}
				GillaPlaces.Prepare((Vector3)0);
				GillaBackroomsSwitch.Prepare((Vector3)0);
				Transform transform = ((Component)obj8).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X19_v3 (UnityEngine.Object)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X19_v3 (UnityEngine.Object)+20]");
					Transform transform2 = ((Component)0).transform;
					if ((object)transform2 != null)
					{
						Vector3 position = transform2.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v27+E4]");
						bool flag7 = (nint)0 == 0;
						object obj17 = !flag7;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj18 = default;
						float maxDistance = default;
						QueryTriggerInteraction queryTriggerInteraction = default;
						if (Physics.Raycast((Vector3)(&obj18), (Vector3)4294959355L, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction))
						{
							Vector3 position2 = transform2.position;
						}
						Vector3 forward = transform2.forward;
						object obj19 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v20+A0]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+18]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+18]");
						object obj21 = num * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+1C]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+1C]");
						object obj22 = num2 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
						object obj23 = 0;
						object obj24 = obj23;
						object obj25 = obj21 + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+20]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+20]");
						object obj26 = num3 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v23+A0]");
						object obj27 = 0;
						float num4 = (float)obj26 + (float)obj25;
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
						float num6 = default;
						float num5 = num6;
						float num8 = default;
						float num7 = num8;
						float num10 = default;
						float num9 = num10;
						if (!flag8)
						{
							float num11 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+18]");
							float num12 = num11 * 0f;
							float num13 = num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+1C]");
							float num14 = num13 * 0f;
							float num15 = num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+20]");
							float num16 = num15 * 0f;
							float num17 = num12 + num14;
							float num18 = num16 + num17;
							float num19 = num18 / num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+18]");
							float num20 = 0f * num19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+1C]");
							float num21 = 0f * num19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+20]");
							float num22 = 0f * num19;
							num7 = num8 - num20;
							num5 = num6 - num21;
							num9 = num10 - num22;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A0]");
						object obj30;
						object obj31;
						object obj32;
						if ((nint)0 != 0)
						{
							object obj28 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v51+A0]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v52+18]");
							obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v52+1C]");
							obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v52+20]");
							obj32 = 0;
						}
						else
						{
							object obj33 = obj14;
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v49+A0]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v50+18]");
							obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v50+1C]");
							obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v50+20]");
							obj32 = 0;
						}
						object obj35 = obj30 * obj30;
						object obj36 = obj31 * obj31;
						object obj37 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v27+A0]");
						object obj38 = 0;
						object obj39 = obj35 + obj36;
						object obj40 = obj32 * obj32;
						object obj41 = obj40 + obj39;
						double num24;
						double num25 = default;
						double num26;
						double num27 = default;
						double num28;
						double num29 = default;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38))
						{
							double num23 = 3.0;
							num24 = num25;
							num26 = num27;
							num28 = num29;
						}
						else
						{
							double num30 = num25 * (double)obj32;
							double num31 = num27 * (double)obj30;
							double num32 = num29 * (double)obj31;
							double num33 = num31 + num32;
							double num34 = num30 + num33;
							double num35 = num34 / (double)obj41;
							double num36 = (double)obj30 * num35;
							double num37 = (double)obj31 * num35;
							double num38 = (double)obj32 * num35;
							num26 = num27 - num36;
							num28 = num29 - num37;
							num24 = num25 - num38;
							double num23 = num27;
						}
						float num39 = num7 * num7;
						float num40 = num5 * num5;
						float num41 = num39 + num40;
						float num42 = num9 * num9;
						float num43 = num41 + num42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
						if (num43 > 0f)
						{
							double num44 = num26 * num26;
							double num45 = num28 * num28;
							double num46 = num44 + num45;
							double num47 = num24 * num24;
							double num48 = num46 + num47;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
							if (num48 > 0.0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72DCC");
								((Player)obj8).Turn(num7);
							}
						}
						if ((object)transform != null)
						{
							Vector3 position3 = transform.position;
							Vector3 position4 = transform2.position;
							transform.position = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
							object obj44 = default;
							object obj43 = obj44 & 1;
							if (obj43 == null)
							{
								goto IL_05b4;
							}
							Vector3 position5 = transform.position;
							Rigidbody rigidbody = default;
							if ((object)rigidbody != null)
							{
								rigidbody.position = (Vector3)0;
								if ((object)rigidbody != null)
								{
									rigidbody.linearVelocity = (Vector3)0;
									goto IL_05b4;
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_011c;
		IL_05b4:
		((Player)obj8).InitializeValues();
		return true;
		IL_011c:
		return false;
	}

	public unsafe static Vector3 FloorUnder(Vector3 p, float down = default(float))
	{
		//IL_009a: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0038: Expected VT, but got I8
		//IL_0038: Expected VT, but got Ref
		//IL_003c: Expected VT, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		Vector3 vector = (Vector3)Physics.Raycast((Vector3)(&obj4), (Vector3)4294959355L, out *(RaycastHit*)1, down, 0, queryTriggerInteraction);
		object obj5 = vector & 1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		object obj8 = !flag2;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		object obj10 = !flag2;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
		}
		return vector;
	}
}
