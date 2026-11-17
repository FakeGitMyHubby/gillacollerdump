using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;
using UnityEngine.XR;

public class ScrollDrum : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public string sku;

		public Action<GillaPurchases.Result> done;

		internal void _003CBuy_003Eb__0(Message<Purchase> message)
		{
			//IL_0010: Expected Obj, but got I
			//IL_041b: Expected Obj, but got I4
			//IL_0477: Expected Obj, but got I
			//IL_02e4: Expected Obj, but got I
			//IL_0307: Expected Obj, but got I
			//IL_0331: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			//IL_0367: Expected Obj, but got I
			//IL_0391: Expected Obj, but got I4
			//IL_0439: Expected Obj, but got I
			//IL_0442: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got I
			//IL_010c: Expected Obj, but got I
			//IL_03eb: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got I
			//IL_0142: Expected Obj, but got I
			//IL_0152: Expected Obj, but got I
			//IL_04b7: Expected Obj, but got I
			//IL_04c7: Expected Obj, but got I
			//IL_04d7: Expected Obj, but got I
			//IL_0182: Expected Obj, but got I
			//IL_01ac: Expected Obj, but got I4
			//IL_01ec: Expected Obj, but got I4
			//IL_020a: Expected Obj, but got I
			//IL_0234: Expected Obj, but got I4
			//IL_02a4: Expected Obj, but got I4
			//IL_02cf: Expected Obj, but got I4
			//IL_0462: Expected Obj, but got I4
			//IL_02c1: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			if ((string)obj4 == sku)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v41+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v41+A0]");
				object obj7 = 0;
				obj7 = 0;
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			if (message.IsError)
			{
				NetSyncSetSessionPropertyResult netSyncSetSessionPropertyResult = ((Message<ChallengeList>)(object)message).GetNetSyncSetSessionPropertyResult();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v25 (Oculus.Platform.Models.NetSyncSetSessionPropertyResult)+18]");
				string text;
				if ((nint)0 == 0)
				{
					text = (string)obj9;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v25 (Oculus.Platform.Models.NetSyncSetSessionPropertyResult)+18]");
					text = (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF978]");
				object value = 0;
				bool flag3 = text.Contains((string)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF980]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF970]");
				object obj11 = 0;
				string message2 = (string)obj10 + sku + (string)obj11 + text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v29+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message2);
				bool flag5 = !flag3;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
					object obj16 = 0;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v33+E4]");
					bool flag6 = (nint)0 == 0;
					object obj18 = !flag6;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaCloud.RedeemPurchases(sku);
				}
				Action<GillaPurchases.Result> action = done;
				if (done == null)
				{
					return;
				}
				bool flag7 = !flag3;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					object obj20 = 1 + 1;
				}
				else
				{
					object obj20 = 1;
				}
				object obj21 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF988]");
				object obj22 = 0;
				string message3 = (string)obj22 + sku;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj25 = !flag8;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj26 = 0;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v18+E4]");
				bool flag9 = (nint)0 == 0;
				object obj28 = !flag9;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaCloud.RedeemPurchases(sku);
				Action<GillaPurchases.Result> action = done;
				if (done == null)
				{
					return;
				}
				object obj20 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v7 (System.Action`1<GillaPurchases+Result>)+40]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v7 (System.Action`1<GillaPurchases+Result>)+28]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v7 (System.Action`1<GillaPurchases+Result>)+18]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v154 @ X3_v2 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public Transform[] fingertips;

	public Transform wheel;

	public float radius;

	public float length;

	public int stepsPerTurn = 10;

	public float min;

	public float max = 3f;

	public AudioClip tick;

	public float arc;

	public float wrapDegrees;

	public float hoverGrow = 0.07f;

	private const float MostCarry = default(float);

	private const float CarryDies = default(float);

	private const float Reach = default(float);

	private const float ReachAcross = default(float);

	private const float HoverOver = default(float);

	private const float KeptOver = default(float);

	private float Value__BackingField;

	private int finger;

	private float lastAngle;

	private float velocity;

	private float ticked;

	private float turned;

	private float hover;

	private float hoverGoing;

	public float Value
	{
		get
		{
			return Value__BackingField;
		}
		private set
		{
			Value__BackingField = value;
		}
	}

	public int Step
	{
		get
		{
			//IL_012c: Expected Obj, but got I
			//IL_0156: Expected Obj, but got I4
			//IL_0029: Invalid comparison between F4 and I4
			//IL_01b3: Expected I4, but got F4
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected Obj, but got Unknown
			//IL_019b: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num;
			float num2;
			float num3 = default;
			if (Value__BackingField < 0f)
			{
				if ((double)Value__BackingField == -0.5)
				{
					num = -1.0;
					num2 = num3;
					goto IL_0164;
				}
				num2 = Value__BackingField + -0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			}
			else
			{
				if ((double)Value__BackingField == 0.5)
				{
					num = 1.0;
					num2 = num3;
					goto IL_0164;
				}
				num2 = Value__BackingField + 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			}
			goto IL_01ae;
			IL_01ae:
			return (int)num2;
			IL_0164:
			double num4 = (double)num2 + num;
			object obj4 = num2 & 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				num2 = (float)num4;
			}
			goto IL_01ae;
		}
	}

	public float Turned => turned;

	private void Update()
	{
		//IL_0b15: Expected I4, but got I8
		//IL_0b2f: Expected Obj, but got I4
		//IL_00a4: Expected I4, but got I8
		//IL_00be: Expected Obj, but got I4
		//IL_0b89: Invalid comparison between F4 and I4
		//IL_0b9c: Expected Obj, but got F4
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected Obj, but got Unknown
		//IL_0bdb: Expected Obj, but got I4
		//IL_001d: Expected F4, but got I
		//IL_01da: Expected I4, but got I8
		//IL_0c30: Expected Obj, but got I4
		//IL_0c48: Invalid comparison between F8 and I4
		//IL_0c6a: Expected Obj, but got I4
		//IL_005c: Expected I4, but got I8
		//IL_0207: Expected F8, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_0cde: Invalid comparison between F8 and I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0283: Expected F8, but got VT
		//IL_0163: Expected Obj, but got I
		//IL_0172: Expected VT, but got I4
		//IL_0f8e: Invalid comparison between F8 and I4
		//IL_0f9d: Expected F8, but got I4
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d12: Expected Obj, but got Unknown
		//IL_0d2c: Expected Obj, but got I4
		//IL_0245: Expected F8, but got VT
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_02e8: Invalid comparison between F4 and I4
		//IL_02f7: Expected F4, but got I4
		//IL_1392: Expected Obj, but got I
		//IL_13d6: Expected I4, but got Obj
		//IL_0dd2: Invalid comparison between F4 and I4
		//IL_0de1: Invalid comparison between F4 and I4
		//IL_0df4: Expected Obj, but got F4
		//IL_0e01: Expected Obj, but got F4
		//IL_0e36: Expected Obj, but got I4
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e43: Expected Obj, but got Unknown
		//IL_13f8: Expected I4, but got I8
		//IL_030e: Invalid comparison between F4 and I4
		//IL_031d: Expected F4, but got I4
		//IL_1119: Invalid comparison between F4 and I4
		//IL_04d9: Invalid comparison between F8 and I4
		//IL_11f0: Expected Obj, but got I4
		//IL_0334: Invalid comparison between F4 and I4
		//IL_0940: Expected VT, but got I4
		//IL_08b4: Invalid comparison between F8 and I4
		//IL_08c3: Expected F4, but got I4
		//IL_1173: Invalid comparison between F8 and I4
		//IL_1182: Expected F8, but got I4
		//IL_097c: Invalid comparison between F4 and I4
		//IL_106d: Expected Obj, but got I4
		//IL_0fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected Obj, but got Unknown
		//IL_101e: Expected Obj, but got I4
		//IL_09a4: Expected I4, but got I8
		//IL_09be: Expected Obj, but got I4
		//IL_0798: Expected I4, but got I8
		//IL_07b2: Expected Obj, but got I4
		//IL_1034: Expected F8, but got VT
		//IL_082d: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I
		//IL_0574: Expected F8, but got VT
		//IL_1374: Expected F8, but got I4
		//IL_0963: Expected VT, but got I4
		//IL_096c: Expected VT, but got I4
		//IL_07dc: Expected Obj, but got I4
		//IL_1342: Expected Obj, but got I4
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_0a5f: Expected F8, but got I4
		//IL_1098: Expected F4, but got I
		//IL_10be: Expected F4, but got I
		//IL_10be: Expected F4, but got I
		//IL_10d5: Expected Obj, but got I4
		//IL_0a83: Expected F4, but got I
		//IL_0aac: Expected VT, but got I4
		//IL_06d0: Expected Obj, but got I
		//IL_06fa: Expected Obj, but got I4
		//IL_0727: Expected F8, but got I
		//IL_0737: Expected F8, but got I
		//IL_0751: Expected VT, but got I4
		//IL_077f: Expected I4, but got Obj
		//IL_0aca: Expected VT, but got I4
		//IL_0a2f: Expected VT, but got I4
		float deltaTime = Time.deltaTime;
		int num = finger;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		int num2 = (int)(finger & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		int num3;
		if (obj == null)
		{
			int i = finger;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			if (Near(i, 0f))
			{
				num3 = finger;
				if ((int)(finger & 0x80000000L) == 0)
				{
					goto IL_00cc;
				}
			}
			else
			{
				finger = -1;
			}
		}
		else
		{
			num3 = (finger = Touching());
			int num4 = (int)(num3 & 0x80000000L);
			bool flag2 = num4 == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				goto IL_00cc;
			}
		}
		object obj3 = default;
		double num5 = (double)obj3 * 30.0;
		double num6 = (double)obj3 * 30.0;
		double num7 = 0.0 - num6;
		float num8 = 0f - velocity;
		bool flag3 = num8 < 0f;
		object obj4 = num8 ^ num8;
		object obj5 = num8 & obj4;
		bool flag4 = (nint)obj5 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag5 = flag3 == flag4;
		object obj6 = !flag5;
		object obj7 = ~obj6;
		if (obj7 != null)
		{
			num7 = num5;
		}
		bool flag6 = (double)num8 < num5;
		object obj8 = !flag6;
		double num9 = (double)num8 - num5;
		bool flag7 = num9 == 0.0;
		double num10 = (double)velocity + num7;
		object obj9 = !flag7;
		object obj10 = obj8 & obj9;
		object obj11 = ~obj10;
		double num11 = ((obj11 != null) ? 0.0 : num10);
		lastAngle = 0f / 0f;
		double num12 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		double num13 = num12 * 0.0;
		velocity = (float)num11;
		double num14 = (double)Value__BackingField + num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num15;
		Vector3 axis = default;
		double num16;
		double num17;
		if (num14 < 0.0)
		{
			if (num14 == -0.5)
			{
				num7 = -1.0;
				num15 = (double)axis;
				goto IL_0cf5;
			}
			num16 = num14 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num17 = -0.5;
		}
		else
		{
			if (num14 == 0.5)
			{
				num7 = 1.0;
				num15 = (double)axis;
				goto IL_0cf5;
			}
			num16 = num14 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num17 = 0.5;
		}
		goto IL_0f0b;
		IL_09cc:
		double num18 = 1.0;
		goto IL_124d;
		IL_1039:
		object obj13;
		object obj12 = obj13;
		double num19;
		ticked = (float)num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X0_v39+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = tick != null;
		bool flag10 = !flag9;
		double num21 = default;
		float num20 = (float)num21;
		double num23;
		float num22 = (float)num23;
		uint num24 = 0u;
		if (flag10)
		{
			goto IL_0784;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		double num25;
		double num26;
		if (array != null)
		{
			object obj16 = array + 32;
			obj16 = tick;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X0_v58+E4]");
				bool flag11 = (nint)0 == 0;
				object obj19 = !flag11;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
				num5 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA0C]");
				num25 = 0.0;
				Sfx.Play(array, (Vector3)0, (float)num19, (float)num23, (float)num21);
				num26 = 0.5;
				num20 = (float)num21;
				num22 = (float)num23;
				num24 = 0u;
				flag9 = (byte)(int)array != 0;
				goto IL_0784;
			}
		}
		goto IL_0acf;
		IL_0cf5:
		num16 = num15 + num7;
		object obj20 = num15 & 1;
		bool flag12 = obj20 == null;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			num16 = num15;
		}
		num17 = num15;
		goto IL_0f0b;
		IL_0ac2:
		int num27;
		Quaternion quaternion = (Quaternion)num27;
		goto IL_09cc;
		IL_00cc:
		Transform[] array2 = fingertips;
		float num28;
		float num29;
		float num34;
		if (fingertips != null)
		{
			bool flag13 = num3 < array2.Length;
			object obj22 = !flag13;
			if (obj22 != null)
			{
				goto IL_0add;
			}
			object obj23 = fingertips + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v60+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v60+20]");
				Vector3 position2 = ((Transform)0).position;
				num28 = Angle((Vector3)0);
				object obj24 = lastAngle & 0x7FFFFFFF;
				bool flag14 = (nint)obj24 < 2139095041;
				object obj25 = !flag14;
				object obj26 = ~obj25;
				if (obj26 == null)
				{
					num29 = Value__BackingField;
					goto IL_0bf2;
				}
				float num30 = num28 - lastAngle;
				float num31 = num30 / 1.13587E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				float num32 = num31 * 1.13587E+09f;
				float num33 = num30 - num32;
				bool flag15 = num33 < 0f;
				num34 = 0f;
				if (!flag15)
				{
					bool flag16 = num33 > 1.13587E+09f;
					float num35 = 1.13587E+09f;
					if (!flag16)
					{
						bool flag17 = !(num33 > 1.1274813E+09f);
						num35 = num33;
						num34 = num33;
						if (flag17)
						{
							goto IL_0d47;
						}
					}
					num34 = num35 + 3.2833536E+09f;
				}
				goto IL_0d47;
			}
		}
		goto IL_0acf;
		IL_10e3:
		double num36;
		turned = (float)num36;
		double num37 = num36 / (double)stepsPerTurn;
		double num38 = num37 * 1135869952.0;
		bool flag18 = !(wrapDegrees > 0f);
		float angle = (float)num38;
		if (!flag18)
		{
			double num39 = num38 / (double)wrapDegrees;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num40 = wrapDegrees * (float)num39;
			num37 = num38 - (double)num40;
			bool flag19 = num37 < 0.0;
			angle = 0f;
			if (!flag19)
			{
				bool flag20 = !(num37 > (double)wrapDegrees);
				angle = (float)num37;
				if (!flag20)
				{
					angle = wrapDegrees;
				}
			}
		}
		object obj27 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X0_v8+E4]");
		bool flag21 = (nint)0 == 0;
		object obj28 = !flag21;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag22 = wheel != null;
		bool flag23 = !flag22;
		quaternion = (Quaternion)0;
		if (!flag23)
		{
			Quaternion quaternion2 = Quaternion.Internal_AngleAxis(angle, ref axis);
			if ((object)wheel == null)
			{
				goto IL_0acf;
			}
			wheel.localRotation = (Quaternion)0;
			quaternion = (Quaternion)0;
		}
		if (arc > 0f)
		{
			return;
		}
		int num41 = (int)(finger & 0x80000000L);
		bool flag24 = num41 == 0;
		object obj29 = !flag24;
		if (obj29 == null)
		{
			goto IL_09cc;
		}
		int num42 = 0;
		while (true)
		{
			Transform[] array3 = fingertips;
			bool flag25 = fingertips == null;
			num18 = 0.0;
			if (flag25)
			{
				break;
			}
			bool flag26 = num42 >= array3.Length;
			num18 = 0.0;
			if (flag26)
			{
				break;
			}
			int i2 = num42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			bool flag27 = Near(i2, 0f);
			num27 = num42 + 1;
			bool flag28 = !flag27;
			quaternion = (Quaternion)num42;
			num42 = num27;
			if (flag28)
			{
				continue;
			}
			goto IL_0ac2;
		}
		goto IL_124d;
		IL_0bf2:
		lastAngle = num28;
		num36 = num29;
		num = 0;
		ScrollDrum scrollDrum = this;
		goto IL_1382;
		IL_0add:
		throw new IndexOutOfRangeException();
		IL_0f0b:
		double num43 = min;
		if (!(num16 < (double)min))
		{
			num17 = max;
			bool flag29 = !(num16 > (double)max);
			num43 = num16;
			if (!flag29)
			{
				num43 = max;
			}
		}
		double num44 = (double)obj3 * -10.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num45 = (double)obj3 * num11;
		num26 = 1.0 - num44;
		double num46 = (double)Value__BackingField + num45;
		bool flag30 = num26 < 0.0;
		double num47 = 0.0;
		if (!flag30)
		{
			bool flag31 = !(num26 > 1.0);
			num47 = num26;
			if (!flag31)
			{
				num47 = 1.0;
			}
		}
		num21 = num43 - num46;
		double num48 = num21 * num47;
		num36 = num46 + num48;
		Value__BackingField = (float)num36;
		goto IL_1382;
		IL_0784:
		int num49 = (int)(finger & 0x80000000L);
		bool flag32 = num49 == 0;
		object obj30 = !flag32;
		object obj33;
		if (obj30 == null)
		{
			bool flag33 = finger == 0;
			object obj31 = !flag33;
			object obj32 = ~obj31;
			XRNode node = ((obj32 != null) ? ((XRNode)4) : ((XRNode)5));
			InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			num22 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			nint num50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			InputDevice inputDevice = default;
			flag9 = inputDevice.SendHapticImpulse(0u, num50, 0f);
			num36 = Value__BackingField;
			obj33 = 0;
			num24 = 0u;
			goto IL_13e4;
		}
		num36 = Value__BackingField;
		obj33 = 0;
		goto IL_1138;
		IL_0fe7:
		Vector3 vector;
		num19 = (double)vector + num21;
		object obj34 = vector & 1;
		bool flag34 = obj34 == null;
		object obj35 = !flag34;
		if (obj35 == null)
		{
			num19 = (double)vector;
		}
		num23 = (double)vector;
		goto IL_1039;
		IL_13e4:
		if ((int)(finger & 0x80000000L) == 0)
		{
			goto IL_10e3;
		}
		goto IL_1138;
		IL_0d47:
		float num51 = num34 / 1.13587E+09f;
		float num52 = num51 * (float)stepsPerTurn;
		float num53 = num52 / (float)obj3;
		float num54 = Value__BackingField + num52;
		float num55 = max;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num56 = num55 + 0f;
		float num57 = min;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
		float num58 = num57 + 0f;
		float num59 = num54 - num56;
		bool flag35 = num59 < 0f;
		bool flag36 = num59 == 0f;
		object obj36 = num54 ^ num56;
		object obj37 = num54 ^ num59;
		object obj38 = obj36 & obj37;
		bool flag37 = (nint)obj38 < 0;
		bool flag38 = flag35 == flag37;
		object obj39 = !flag38;
		object obj40 = obj39 | flag36;
		object obj41 = ~obj40;
		num5 = ((obj41 != null) ? ((double)num56) : ((double)num54));
		num29 = ((!(num54 < num58)) ? ((float)num5) : num58);
		float num60 = num53 - velocity;
		Value__BackingField = num29;
		double num61 = (double)num60 * 0.5;
		num21 = (double)velocity + num61;
		bool flag39 = num21 < -5.0;
		double num62 = -5.0;
		if (!flag39)
		{
			bool flag40 = !(num21 > 5.0);
			num62 = num21;
			if (!flag40)
			{
				num62 = 5.0;
			}
		}
		velocity = (float)num62;
		num25 = 0.5;
		num26 = num58;
		goto IL_0bf2;
		IL_0acf:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0add;
		IL_1138:
		double num63 = (double)obj3 * -14.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num64 = 1.0 - num63;
		bool flag41 = num64 < 0.0;
		double num65 = 0.0;
		if (!flag41)
		{
			bool flag42 = !(num64 > 1.0);
			num65 = num64;
			if (!flag42)
			{
				num65 = 1.0;
			}
		}
		double num66 = num36 - (double)turned;
		double num67 = num66 * num65;
		num36 = (double)turned + num67;
		goto IL_10e3;
		IL_124d:
		object obj42 = obj13;
		double num68 = num18 - (double)hover;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		double num69 = (double)hoverGoing * -16.0;
		double num70 = num68 * 1131413504.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC80]");
		double num71 = 0.0 * num69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC80]");
		double num72 = 0.0 * num70;
		double num73 = num72 + num71;
		double num74 = (double)hoverGoing + num73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC80]");
		double num75 = 0.0 * num74;
		double num76 = (double)hover + num75;
		hover = (float)num76;
		hoverGoing = (float)num74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X0_v15+E4]");
		bool flag43 = (nint)0 == 0;
		object obj43 = !flag43;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(wheel != null))
		{
			return;
		}
		if ((object)wheel != null)
		{
			wheel.localScale = (Vector3)0;
			return;
		}
		goto IL_0acf;
		IL_1382:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag44 = (double)ticked < 1.0;
		num20 = (float)num21;
		num22 = 1f;
		num24 = (uint)num;
		flag9 = (byte)(int)scrollDrum != 0;
		if (!flag44)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			if (num36 < 0.0)
			{
				if (num36 == -0.5)
				{
					num21 = -1.0;
					vector = axis;
					goto IL_0fe7;
				}
				num19 = num36 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				num23 = -0.5;
			}
			else
			{
				if (num36 == 0.5)
				{
					num21 = 1.0;
					vector = axis;
					goto IL_0fe7;
				}
				num19 = num36 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num23 = 0.5;
			}
			goto IL_1039;
		}
		goto IL_13e4;
	}

	public void Set(float v)
	{
		//IL_0151: Invalid comparison between F4 and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_019f: Expected Obj, but got I4
		float num = min;
		if (!(min > v))
		{
			bool flag = !(max < v);
			num = v;
			if (!flag)
			{
				num = max;
			}
		}
		Value__BackingField = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num2;
		float num3;
		float num4 = default;
		if (num < 0f)
		{
			if ((double)num == -0.5)
			{
				num2 = -1.0;
				num3 = num4;
				goto IL_0168;
			}
			num3 = num + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if ((double)num == 0.5)
			{
				num2 = 1.0;
				num3 = num4;
				goto IL_0168;
			}
			num3 = num + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_01b2;
		IL_0168:
		double num5 = (double)num3 + num2;
		object obj = num3 & 1;
		bool flag2 = obj == null;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			num3 = (float)num5;
		}
		goto IL_01b2;
		IL_01b2:
		ticked = num3;
		velocity = 0f;
	}

	private int Touching()
	{
		//IL_00cc: Expected I4, but got I8
		//IL_0064: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		Transform[] array = fingertips;
		int num;
		if (fingertips != null)
		{
			num = 0;
			while (num < array.Length)
			{
				bool flag = Near(num, 0f);
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj == null)
				{
					array = fingertips;
					num++;
					bool flag3 = fingertips == null;
					object obj2 = !flag3;
					if (obj2 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				goto IL_00d1;
			}
		}
		num = -1;
		goto IL_00d1;
		IL_00d1:
		return num;
	}

	private bool Near(int i, float slack)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_04e7: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I
		//IL_022b: Expected VT, but got I4
		//IL_0520: Expected Obj, but got I
		//IL_054a: Expected Obj, but got I4
		//IL_0294: Invalid comparison between F4 and I4
		//IL_0372: Invalid comparison between I and F8
		//IL_02bc: Unsupported input type for neg.
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_0308: Invalid comparison between Obj and F8
		//IL_03f7: Invalid comparison between Obj and F4
		//IL_043f: Invalid comparison between F4 and I4
		//IL_044e: Invalid comparison between F4 and I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_04a3: Expected Obj, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected I4, but got Unknown
		Transform[] array = fingertips;
		if (fingertips == null || array.Length <= i)
		{
			goto IL_04bd;
		}
		bool flag = array.Length < i;
		object obj = !flag;
		object obj2 = array.Length - i;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			object obj6 = fingertips + i;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+20]");
			bool flag4 = (UnityEngine.Object)0 == null;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			if (obj9 != null)
			{
				goto IL_04bd;
			}
			Transform transform = base.transform;
			Transform[] array2 = fingertips;
			if (fingertips != null)
			{
				bool flag6 = array2.Length < i;
				object obj10 = !flag6;
				object obj11 = array2.Length - i;
				bool flag7 = obj11 == null;
				object obj12 = ~obj10;
				object obj13 = obj12 | flag7;
				if (obj13 != null)
				{
					goto IL_04d9;
				}
				object obj14 = fingertips + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v10+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v10+20]");
					Vector3 position = ((Transform)0).position;
					if ((object)transform != null)
					{
						Vector3 vector = transform.InverseTransformPoint((Vector3)0);
						Transform transform2 = base.transform;
						if ((object)transform2 != null)
						{
							Vector3 lossyScale = transform2.lossyScale;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj15 = 0;
							object obj16 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v24+E4]");
							bool flag8 = (nint)0 == 0;
							object obj17 = !flag8;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj19 = default;
							object obj18 = obj19 * obj19;
							object obj21 = default;
							if (arc > 0f)
							{
								object obj20 = obj21 * obj21;
								object obj22 = 0 - obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
								object obj23 = obj18 * 0;
								double num = (double)arc + 3.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
								{
									goto IL_04bd;
								}
							}
							double num2 = (double)length * 0.5;
							double num3 = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
							double num4 = num3 + 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							double num5 = num4 + (double)slack;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
							if (0.0 < num5)
							{
								object obj24 = obj21 * obj21;
								object obj25 = obj18 * obj18;
								object obj26 = obj24 * obj24;
								object obj27 = obj25 + obj26;
								float num6 = radius;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
								float num7 = num6 + 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								float num8 = num7 + slack;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num8))
								{
									float num9 = radius;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
									float num10 = num9 * 0f;
									float num11 = (float)obj27 - num10;
									bool flag9 = num11 < 0f;
									bool flag10 = num11 == 0f;
									object obj28 = obj27 ^ num10;
									object obj29 = obj27 ^ num11;
									object obj30 = obj28 & obj29;
									bool flag11 = (nint)obj30 < 0;
									bool flag12 = flag9 == flag11;
									object obj31 = !flag10;
									return (byte)((flag12 & obj31) ? 1 : 0) != 0;
								}
							}
							goto IL_04bd;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
		}
		goto IL_04d9;
		IL_04d9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_04bd:
		return false;
	}

	private float Angle(Vector3 world)
	{
		//IL_001d: Expected VT, but got I4
		//IL_0025: Unsupported input type for neg.
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		Transform transform = base.transform;
		Vector3 vector = transform.InverseTransformPoint((Vector3)0);
		object obj2 = default;
		object obj = 0 - obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
		object obj3 = default;
		float num = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		return num * 0f;
	}

	public unsafe static Mesh WheelMesh(float radius, float length, int ribs)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_1480: Expected Obj, but got I
		//IL_1490: Expected Obj, but got I
		//IL_0069: Expected I4, but got I8
		//IL_0083: Expected Obj, but got I4
		//IL_08d8: Expected Obj, but got I4
		//IL_08e1: Expected Obj, but got I4
		//IL_15c0: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Expected Obj, but got Unknown
		//IL_151c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1521: Expected I4, but got Unknown
		//IL_1534: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Expected Obj, but got Unknown
		//IL_1558: Expected Obj, but got I
		//IL_156b: Expected Obj, but got I4
		//IL_0110: Expected F8, but got I
		//IL_14c8: Expected Obj, but got I
		//IL_0960: Expected Obj, but got I4
		//IL_13b0: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I4
		//IL_0988: Expected Obj, but got I8
		//IL_09af: Expected Obj, but got I4
		//IL_09c0: Expected VT, but got I4
		//IL_0212: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_0237: Expected VT, but got I
		//IL_172b: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I
		//IL_13f5: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_09ff: Expected Obj, but got I
		//IL_0a1d: Expected Obj, but got I
		//IL_02bd: Unsupported input type for neg.
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected F8, but got Unknown
		//IL_02eb: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_0391: Expected VT, but got I
		//IL_0a87: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I
		//IL_0b15: Expected Obj, but got I
		//IL_0b25: Expected Obj, but got I
		//IL_0b35: Expected VT, but got I
		//IL_0b4a: Expected VT, but got I
		//IL_0b53: Expected F8, but got I4
		//IL_0b64: Expected F4, but got I4
		//IL_0abf: Expected Obj, but got I
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected Obj, but got Unknown
		//IL_0aea: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I4
		//IL_04ae: Expected Obj, but got I
		//IL_04be: Expected Obj, but got I
		//IL_04d3: Expected VT, but got I
		//IL_0b96: Expected Obj, but got I
		//IL_0bb4: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0485: Expected Obj, but got I
		//IL_0c07: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I4
		//IL_0cc8: Expected Obj, but got I
		//IL_0cd8: Expected Obj, but got I
		//IL_0ce8: Expected VT, but got I
		//IL_0cfd: Expected VT, but got I
		//IL_0d0f: Expected I4, but got I8
		//IL_0d29: Expected Obj, but got I4
		//IL_0d32: Expected F8, but got I4
		//IL_0d3b: Expected F4, but got I4
		//IL_0d44: Expected F8, but got I4
		//IL_0d54: Expected F4, but got I
		//IL_0d5d: Expected F4, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I
		//IL_060f: Expected VT, but got I
		//IL_0620: Expected F4, but got I4
		//IL_108c: Expected Obj, but got VT
		//IL_0c2b: Expected Obj, but got I
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Expected Obj, but got Unknown
		//IL_0c56: Expected Obj, but got I
		//IL_0c86: Expected I4, but got I8
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_058d: Expected Obj, but got I
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_05b8: Expected Obj, but got I
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected Obj, but got Unknown
		//IL_135c: Expected Obj, but got I
		//IL_1392: Expected VT, but got Obj
		//IL_0d74: Expected Obj, but got I4
		//IL_10ab: Expected Obj, but got I4
		//IL_163f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1644: Expected Obj, but got Unknown
		//IL_1659: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Expected I4, but got Unknown
		//IL_1671: Unknown result type (might be due to invalid IL or missing references)
		//IL_1676: Expected Obj, but got Unknown
		//IL_1695: Expected Obj, but got I
		//IL_16a0: Expected Obj, but got I4
		//IL_0674: Expected Obj, but got I4
		//IL_16e0: Expected Obj, but got I
		//IL_0d9b: Expected F8, but got I
		//IL_1605: Expected Obj, but got I
		//IL_069a: Expected Obj, but got I4
		//IL_1589: Expected Obj, but got I
		//IL_0dd8: Expected Obj, but got I4
		//IL_0e87: Expected Obj, but got I
		//IL_0e97: Expected Obj, but got I
		//IL_0ea7: Expected VT, but got I
		//IL_0ebc: Expected VT, but got I
		//IL_0ed9: Expected Obj, but got I
		//IL_0ef7: Expected Obj, but got I
		//IL_0e23: Expected Obj, but got I
		//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e38: Expected Obj, but got Unknown
		//IL_0e4e: Expected Obj, but got I
		//IL_0e72: Expected VT, but got Ref
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected Obj, but got Unknown
		//IL_1275: Expected Obj, but got I4
		//IL_128b: Expected Obj, but got I
		//IL_12a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a8: Expected Obj, but got Unknown
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c3: Expected Obj, but got Unknown
		//IL_0f4a: Expected Obj, but got I4
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected Obj, but got Unknown
		//IL_115b: Expected Obj, but got I4
		//IL_1171: Expected Obj, but got I
		//IL_1189: Unknown result type (might be due to invalid IL or missing references)
		//IL_118e: Expected Obj, but got Unknown
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a9: Expected Obj, but got Unknown
		//IL_0fd4: Expected Obj, but got I
		//IL_0fe4: Expected Obj, but got I
		//IL_0ff4: Expected VT, but got I
		//IL_1009: Expected VT, but got I
		//IL_1012: Expected F8, but got I4
		//IL_1022: Expected F4, but got I
		//IL_102b: Expected F4, but got I4
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_0734: Expected Obj, but got I4
		//IL_074a: Expected Obj, but got I
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_12da: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Expected Obj, but got Unknown
		//IL_1039: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Expected Obj, but got Unknown
		//IL_0f6e: Expected Obj, but got I
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Expected Obj, but got Unknown
		//IL_0f99: Expected Obj, but got I
		//IL_11c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c5: Expected Obj, but got Unknown
		//IL_1302: Unknown result type (might be due to invalid IL or missing references)
		//IL_1307: Expected Obj, but got Unknown
		//IL_07ce: Expected Obj, but got I4
		//IL_07e4: Expected Obj, but got I
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Expected Obj, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_08ca: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj3 = 0;
		int num = ribs << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BA8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list2 = default;
		list2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list3 = default;
		list3._002Ector();
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj6 = !flag;
		float num3 = radius;
		float num4 = length;
		if (obj6 != null)
		{
			goto IL_08cf;
		}
		double num14 = default;
		if (list != null)
		{
			int num5 = num | 1;
			float num6 = length * 0.5f;
			object obj7 = 0;
			double num13 = default;
			object obj17 = default;
			while (true)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
				object obj9 = obj8 * 0;
				object obj10 = obj9 + obj9;
				int num7 = obj10 / num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
				object obj11 = obj7 & 2;
				bool flag2 = obj11 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj12 = 0;
				object obj13 = obj4;
				object obj14 = !flag2;
				double num8;
				if (obj14 == null)
				{
					num8 = 1.0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF88]");
					num8 = 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj15 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				double num9 = num8 * (double)radius;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v51+18]");
				bool flag3 = num10 < 0;
				object obj16 = !flag3;
				double num11 = num9 * 0.0;
				double num12 = num9 * num13;
				num14 = num9 * (double)obj17;
				double num15 = num11 - (double)num6;
				double num16 = 0.0 - num14;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj18 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj19 = 0 + obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj20 = (nint)0 + (nint)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X9_v31+20]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v73+A8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v74+70]");
					list.AddWithResize((Vector3)0);
					num14 = num16;
				}
				if (list2 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj23 = 0;
				object obj24 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj25 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				double num17 = 0 - obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v53+18]");
				bool flag4 = num18 < 0;
				object obj26 = !flag4;
				double num19;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj27 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj28 = 0 + obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj29 = (nint)0 + (nint)1;
					_ = 0;
					num19 = num12;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v33+20]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v70+A8]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v71+70]");
					list2.AddWithResize((Vector3)0);
					num14 = num17;
					num19 = num13;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj32 = 0;
				object obj33 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj34 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				num3 = num6 + (float)num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v55+18]");
				bool flag5 = num20 < 0;
				object obj35 = !flag5;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj36 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj37 = 0 + obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj38 = (nint)0 + (nint)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X9_v35+20]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v67+A8]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v68+70]");
					list.AddWithResize((Vector3)0);
					num14 = num16;
					num19 = num12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj41 = 0;
				object obj42 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj43 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v57+18]");
				bool flag6 = num21 < 0;
				object obj44 = !flag6;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj45 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj46 = 0 + obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj47 = (nint)0 + (nint)1;
					_ = 0;
					num4 = (float)num19;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v37+20]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v64+A8]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v65+70]");
					list2.AddWithResize((Vector3)0);
					num14 = num17;
					num3 = 0f;
					num4 = (float)num13;
				}
				obj7++;
				if (num5 != (nint)obj7)
				{
					continue;
				}
				goto IL_065a;
			}
		}
		goto IL_1446;
		IL_13a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		if ((object)mesh != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9B8]");
			object obj51 = 0;
			mesh.name = (string)obj51;
			mesh.SetVertices(list);
			mesh.SetNormals(list2);
			mesh.SetTriangles(list3, 0);
			mesh.RecalculateBounds();
			return mesh;
		}
		goto IL_1446;
		IL_1446:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1454;
		IL_065a:
		bool flag7 = num == 0;
		object obj52 = !flag7;
		if (num == 0)
		{
			goto IL_08cf;
		}
		object obj53 = 1;
		int num22 = num;
		IEnumerable<int> enumerable = default;
		object obj65 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			if (enumerable == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
			if ((nint)0 != 0)
			{
				object obj55 = obj53 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
				if ((nint)0 != 1)
				{
					object obj56 = obj53 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
					bool flag8 = (nint)0 < (nint)2;
					object obj57 = !flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
					object obj58 = -2;
					bool flag9 = obj58 == null;
					object obj59 = ~obj57;
					object obj60 = obj59 | flag9;
					if (obj60 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							bool flag10 = (nint)0 < (nint)4;
							object obj61 = !flag10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							object obj62 = -4;
							bool flag11 = obj62 == null;
							object obj63 = ~obj61;
							object obj64 = obj63 | flag11;
							if (obj64 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v53 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
								if ((nint)0 != 5)
								{
									obj53 += 2;
									if (list3 == null)
									{
										break;
									}
									obj65 = obj5;
									list3.AddRange(enumerable);
									num22--;
									if (num22 != 1)
									{
										continue;
									}
									goto IL_08b9;
								}
							}
						}
					}
				}
			}
			goto IL_1454;
		}
		goto IL_1446;
		IL_15b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj67 = default;
		if (obj67 == null)
		{
			goto IL_1446;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v20+18]");
		object obj119;
		object obj118;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v20+18]");
			bool flag12 = (nint)0 == 1;
			_ = 3212836864L;
			if (!flag12)
			{
				_ = 1065353216;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v20+18]");
				bool flag13 = (nint)0 < (nint)1;
				IEnumerable<int> enumerable2 = (IEnumerable<int>)2;
				if (flag13)
				{
					goto IL_13a0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v20+18]");
				object obj68 = 0 & 0xFFFFFFFFL;
				int num23 = num | 1;
				object obj69 = obj65;
				double num24 = num14;
				object obj70 = 0;
				float num25 = num4;
				Vector3 vector = (Vector3)2;
				object obj102 = default;
				object obj103 = default;
				IEnumerable<int> enumerable3 = default;
				while (true)
				{
					bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68);
					object obj71 = !flag14;
					if (obj71 != null)
					{
						break;
					}
					float num27;
					if (list != null)
					{
						object obj72 = obj67 + obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj73 = 0;
						object obj74 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
						object obj75 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X9_v6+20]");
							num3 = 0f * length;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							nint num26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v14+18]");
							bool flag15 = num26 < 0;
							object obj76 = !flag15;
							num27 = num3 * 0.5f;
							if (obj76 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj77 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj78 = 0 + obj77;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj79 = (nint)0 + (nint)1;
								_ = 0;
								_ = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X9_v7+20]");
								object obj80 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X8_v44+A8]");
								object obj81 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X8_v45+70]");
								vector = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X8_v45+70]");
								list.AddWithResize((Vector3)0);
								num24 = 0.0;
								num3 = num27;
								num25 = 0f;
							}
							if (list2 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj82 = 0;
								object obj83 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
								object obj84 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									nint num28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v16+18]");
									bool flag16 = num28 < 0;
									object obj85 = !flag16;
									if (obj85 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										object obj86 = (nint)0 * (nint)12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj87 = 0 + obj86;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										object obj88 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X9_v6+20]");
										_ = 0;
										_ = 0;
										_ = 0;
										if ((int)(num & 0x80000000L) == 0)
										{
											goto IL_0d6b;
										}
										num14 = num24;
										num4 = num25;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X9_v9+20]");
										object obj89 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v41+A8]");
										object obj90 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v42+70]");
										vector = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v42+70]");
										list2.AddWithResize((Vector3)0);
										int num29 = (int)(num & 0x80000000L);
										bool flag17 = num29 == 0;
										object obj91 = !flag17;
										num24 = 0.0;
										num25 = 0f;
										num14 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X9_v6+20]");
										num3 = 0f;
										num4 = 0f;
										if (obj91 == null)
										{
											goto IL_0d6b;
										}
									}
									goto IL_1075;
								}
							}
						}
					}
					goto IL_1446;
					IL_133e:
					obj70++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v20+18]");
					obj68 = 0;
					object obj92 = obj70;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v20+18]");
					bool flag18 = (nint)obj92 < 0;
					obj65 = obj69;
					num24 = num14;
					num25 = num4;
					vector = (Vector3)enumerable2;
					if (flag18)
					{
						continue;
					}
					goto IL_13a0;
					IL_0d6b:
					object obj93 = 0;
					while (true)
					{
						object obj94 = obj93;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X24_v9+E64]");
						object obj95 = obj94 * 0;
						object obj96 = obj95 + obj95;
						int num30 = obj96 / num;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
						object obj97 = obj93 & 2;
						bool flag19 = obj97 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj98 = 0;
						object obj14 = !flag19;
						double num31;
						if (obj14 == null)
						{
							num31 = 1.0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF88]");
							num31 = 0.0;
						}
						object obj99 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
						object obj100 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						double num32 = num31 * (double)radius;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v31+18]");
						bool flag20 = num33 < 0;
						object obj101 = !flag20;
						double num34 = num32 * (double)obj102;
						double num35 = (double)obj103 * num32;
						num14 = 0.0 - num35;
						if (obj101 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj104 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj105 = 0 + obj104;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj106 = (nint)0 + (nint)1;
							num3 = (float)num32;
							vector = (Vector3)(&obj103);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X9_v18+20]");
							object obj107 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v38+A8]");
							object obj108 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v39+70]");
							vector = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v39+70]");
							list.AddWithResize((Vector3)0);
							num3 = num27;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj109 = 0;
						object obj110 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
						object obj111 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v33+18]");
						bool flag21 = num36 < 0;
						object obj112 = !flag21;
						if (obj112 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj113 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj114 = 0 + obj113;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj115 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X9_v6+20]");
							_ = 0;
							_ = 0;
							_ = 0;
							num4 = (float)num34;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v20+20]");
							object obj116 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X8_v35+A8]");
							object obj117 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X8_v36+70]");
							vector = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X8_v36+70]");
							list2.AddWithResize((Vector3)0);
							num14 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X9_v6+20]");
							num3 = 0f;
							num4 = 0f;
						}
						obj118 = obj93 + 1;
						bool flag22 = num23 != (nint)obj118;
						num24 = num14;
						num25 = num4;
						obj93 = obj118;
						if (flag22)
						{
							continue;
						}
						goto IL_1075;
					}
					goto IL_1446;
					IL_1075:
					bool flag23 = obj119 == null;
					enumerable2 = (IEnumerable<int>)vector;
					if (flag23)
					{
						goto IL_133e;
					}
					object obj120 = obj69;
					object obj121 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
						object obj122 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X9_v6+20]");
						if ((nint)0 > (nint)0)
						{
							if (enumerable3 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							if ((nint)0 == 0)
							{
								goto end_IL_1712;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							bool flag24 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							_ = 0;
							if (flag24)
							{
								goto end_IL_1712;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj123 = 0 + obj121;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							bool flag25 = (nint)0 < (nint)2;
							object obj124 = !flag25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							object obj125 = -2;
							bool flag26 = obj125 == null;
							object obj126 = obj123 + 1;
							object obj127 = ~obj124;
							object obj128 = obj127 | flag26;
							if (obj128 != null)
							{
								goto end_IL_1712;
							}
							object obj129 = obj123 + 2;
						}
						else
						{
							if (enumerable3 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							if ((nint)0 == 0)
							{
								goto end_IL_1712;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							bool flag27 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							_ = 0;
							if (flag27)
							{
								goto end_IL_1712;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj130 = 0 + obj121;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							bool flag28 = (nint)0 < (nint)2;
							object obj131 = !flag28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
							object obj132 = -2;
							bool flag29 = obj132 == null;
							object obj133 = obj130 + 2;
							object obj134 = ~obj131;
							object obj135 = obj134 | flag29;
							if (obj135 != null)
							{
								goto end_IL_1712;
							}
							object obj129 = obj130 + 1;
						}
						if (list3 == null)
						{
							break;
						}
						obj69 = obj5;
						list3.AddRange(enumerable3);
						obj118 = obj121 + 1;
						bool flag30 = num != (nint)obj118;
						enumerable2 = enumerable3;
						obj120 = obj5;
						obj121 = obj118;
						if (flag30)
						{
							continue;
						}
						goto IL_133e;
					}
					goto IL_1446;
					continue;
					end_IL_1712:
					break;
				}
			}
		}
		goto IL_1454;
		IL_1454:
		return (Mesh)(object)new IndexOutOfRangeException();
		IL_08b9:
		obj119 = obj52;
		obj118 = 17276928;
		goto IL_15b0;
		IL_08cf:
		obj119 = 0;
		obj118 = 17276928;
		goto IL_15b0;
	}

	public ScrollDrum()
	{
		//IL_0033: Expected F4, but got I
		//IL_0042: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C098]");
		radius = 0f;
		finger = -1;
		base._002Ector();
	}

	internal static float _003CWheelMesh_003Eg__R_007C37_0(int i, ref SoulScythe._003C_003Ec__DisplayClass37_0 P_1)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_005b: Unsupported input type for neg.
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected I4, but got Unknown
		//IL_009a: Expected Obj, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected I4, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_0087: Expected F8, but got I
		object obj = -i;
		int num = i & 3;
		object obj2 = obj & 3;
		int num2 = ((0 >= i) ? (0 - obj2) : num);
		object obj3 = num2 - 2;
		bool flag = (nint)obj3 < 0;
		int num3 = num2 ^ 2;
		int num4 = num2 ^ obj3;
		int num5 = num3 & num4;
		bool flag2 = num5 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		double num6;
		if (obj5 == null)
		{
			num6 = 1.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF88]");
			num6 = 0.0;
		}
		return (float)num6 * (float)P_1;
	}
}
