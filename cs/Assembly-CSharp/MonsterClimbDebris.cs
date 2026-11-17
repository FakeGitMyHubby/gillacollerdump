using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class MonsterClimbDebris : MonoBehaviour
{
	public float chipsPerMetre;

	public float dustPerMetre;

	private MonsterBrain brain;

	private Debris debris;

	private float lastY;

	private float chipDue;

	private float dustDue;

	private float reach = 1f;

	private bool onWall;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_0085: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_048c: Expected F8, but got I
		//IL_049c: Invalid comparison between F8 and I
		//IL_00fa: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj2 = this + 40;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform = base.transform;
		object obj10;
		object obj11;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			float num = default;
			lastY = num;
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
				object obj4 = 0;
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v9+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
				object obj8 = default;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v19+18]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+8]");
					obj10 = (nint)0 * (nint)63;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v19+18]");
					bool flag = (nint)0 < (nint)1;
					object obj12 = default;
					obj11 = obj12;
					if (flag)
					{
						goto IL_027b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BB8]");
					object obj13 = 0;
					object obj14 = 0;
					object obj15 = obj10;
					object obj17 = default;
					object obj16 = obj17;
					object obj24 = default;
					object obj26 = default;
					while (true)
					{
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
						object obj18 = !flag2;
						if (obj18 != null)
						{
							break;
						}
						object obj19 = obj8 + obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v16+20]");
						Renderer renderer = (Renderer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v16+20]");
						if ((nint)0 != 0)
						{
							bool flag3 = renderer == obj13;
							object obj20 = obj16;
							if (!flag3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v16+20]");
								Bounds bounds = ((Renderer)0).bounds;
								object obj21 = obj16 - obj15;
								object obj22 = obj15 + obj16;
								object obj23 = obj24 - obj24;
								object obj25 = obj24 + obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
								object obj27 = obj23 - obj24;
								object obj28 = obj27 * 63;
								object obj29 = obj24 + obj28;
								obj17 = obj29 - obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
								object obj30 = obj25 - obj17;
								obj15 = obj30 * 63;
								obj20 = obj17 + obj15;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v19+18]");
							obj9 = 0;
							obj14++;
							object obj31 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v19+18]");
							bool flag4 = (nint)obj31 < 0;
							obj10 = obj15;
							obj11 = obj12;
							obj16 = obj20;
							if (flag4)
							{
								continue;
							}
							goto IL_027b;
						}
						goto IL_0371;
					}
					goto IL_037f;
				}
			}
		}
		goto IL_0371;
		IL_0371:
		NullReferenceException ex = new NullReferenceException();
		goto IL_037f;
		IL_037f:
		throw new IndexOutOfRangeException();
		IL_027b:
		object obj32 = obj10 + obj10;
		object obj33 = obj11 - obj32;
		bool flag5 = (nint)obj33 < 0;
		bool flag6 = obj33 == null;
		object obj34 = obj11 ^ obj32;
		object obj35 = obj11 ^ obj33;
		object obj36 = obj34 & obj35;
		bool flag7 = (nint)obj36 < 0;
		bool flag8 = flag5 == flag7;
		object obj37 = !flag6;
		object obj38 = flag8 & obj37;
		object obj39 = ~obj38;
		if (obj39 == null)
		{
			obj32 = obj11;
		}
		double num2 = (double)obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
		double num3 = num2 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		double num4 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		if (!(num3 < 0.0))
		{
			bool flag9 = !(num3 > 3.0);
			num4 = num3;
			if (!flag9)
			{
				num4 = 3.0;
			}
		}
		reach = (float)num4;
	}

	private void LateUpdate()
	{
		//IL_039e: Invalid comparison between F4 and I4
		//IL_03af: Expected Obj, but got I4
		//IL_03b8: Invalid comparison between F4 and I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_0413: Expected Obj, but got I
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0448: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I
		//IL_0606: Invalid comparison between F4 and I4
		//IL_04a0: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I4
		//IL_0129: Invalid comparison between F4 and I4
		//IL_07d0: Invalid comparison between VT and I4
		//IL_014d: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_0911: Expected Obj, but got I
		//IL_092b: Expected F4, but got I
		//IL_0661: Expected F4, but got I4
		//IL_0646: Expected F4, but got I
		//IL_01da: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_087a: Expected VT, but got I4
		//IL_08bd: Expected Obj, but got I
		//IL_0690: Expected F4, but got I
		//IL_0690: Expected F4, but got I
		//IL_0797: Expected I4, but got VT
		//IL_0797: Expected VT, but got I4
		//IL_0797: Expected VT, but got I4
		//IL_07b0: Invalid comparison between F4 and I4
		//IL_02fc: Expected Obj, but got I
		//IL_0365: Expected VT, but got I4
		//IL_0365: Expected VT, but got I4
		//IL_0389: Expected I4, but got VT
		//IL_0389: Expected VT, but got I4
		//IL_0389: Expected VT, but got I4
		Transform transform = base.transform;
		Vector3 position = transform.position;
		MonsterBrain monsterBrain = brain;
		float num = default;
		lastY = num;
		Transform transform2 = base.transform;
		float num2 = num - lastY;
		Vector3 forward = transform2.forward;
		float num3 = monsterBrain.climbPitch;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		float num4 = num3 * 0f;
		Vector3 vector = default;
		int count = default;
		if (monsterBrain.ClimbPitch__BackingField < num4)
		{
			if (~(onWall ? 1u : 0u) != 0 || !(monsterBrain.ClimbPitch__BackingField < num4))
			{
				return;
			}
			onWall = false;
			float num5 = monsterBrain.climbPitch;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num6 = num5 * 0f;
			if (!(monsterBrain.ClimbPitch__BackingField > num6) || num2 < 0f)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = this + 48;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v48+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C90]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X0_v65+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debris debris = Debris.On(this);
				this.debris = debris;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			Transform transform3 = base.transform;
			Vector3 position2 = transform3.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
			Transform transform4 = base.transform;
			Vector3 right = transform4.right;
			float num7 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num8 = num7 * 0f;
			float num9 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num10 = num9 * 0f;
			float num11 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			float num12 = num11 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			object obj8 = num13 * 0;
			float num14 = num8 + num6;
			float num15 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num16 = num15 + 0f;
			float num17 = num14 + num12;
			float num18 = num16 + (float)obj8;
			this.debris.Puff((Vector3)14, (Vector3)0, vector, num17, count, num18);
			((Debris)obj2).Chips((Vector3)10, (Vector3)0, (int)vector, num17, num18);
			return;
		}
		onWall = true;
		bool flag3 = num2 < 0f;
		object obj9 = !flag3;
		bool flag4 = num2 == 0f;
		object obj10 = ~obj9;
		object obj11 = obj10 | flag4;
		if (obj11 != null || (double)num2 > 1.0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj12 = 0;
		object obj13 = this + 48;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C90]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X0_v40+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debris debris2 = Debris.On(this);
			this.debris = debris2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj19 = default;
		float num19 = chipsPerMetre * (float)obj19;
		float num20 = chipDue + num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		float num21 = (chipDue = num20 - chipDue);
		Transform transform5 = base.transform;
		Vector3 position3 = transform5.position;
		float num22 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		float num23 = num22 * 0f;
		float num24 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		float num25 = num24 * 0f;
		float num27 = default;
		float num26 = num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		float num28 = num26 * 0f;
		float num29 = num23 + num21;
		float num30 = num25 + chipDue;
		float num31 = num28 + num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj20 = 0;
		if (!(chipDue < 1f))
		{
			float num32 = chipDue;
			do
			{
				float value = UnityEngine.Random.value;
				float num33;
				float minInclusive;
				if ((double)value < 0.75)
				{
					num33 = 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					minInclusive = 0f;
				}
				else
				{
					num33 = 0.25f;
					minInclusive = 0f;
				}
				float num34 = UnityEngine.Random.Range(minInclusive, num33);
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v27+A0]");
				object obj22 = 0;
				Transform transform6 = base.transform;
				Vector3 right2 = transform6.right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
				nint num35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num36 = UnityEngine.Random.Range(num35, 0f);
				float num37 = num34 * reach;
				float num38 = num27 * num36;
				float num39 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v28+20]");
				float num40 = num39 * 0f;
				float num41 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v28+1C]");
				float num42 = num41 * 0f;
				float num43 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v28+18]");
				float num44 = num43 * 0f;
				float num45 = num31 + num40;
				float num46 = num30 + num42;
				float num47 = num33 * num36;
				float num48 = num34 * num36;
				float num49 = num29 + num44;
				num27 = num45 + num38;
				float spread = num46 + num47;
				float force = num49 + num48;
				this.debris.Chips((Vector3)1, (Vector3)0, (int)vector, force, spread);
				num32--;
			}
			while (num32 != 1f);
		}
		Vector3 vector2 = default;
		if (vector2 >= (object)1)
		{
			object obj23 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v16+A0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num50 = UnityEngine.Random.Range(0f, 1f);
			Transform transform7 = base.transform;
			Vector3 right3 = transform7.right;
			float num51 = num50 * reach;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v17+18]");
			float num52 = 0f * num51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v17+1C]");
			float num53 = 0f * num51;
			float width = num29 + num52;
			float force2 = num30 + num53;
			((Debris)obj13).Puff(vector2, (Vector3)0, vector, width, count, force2);
		}
	}

	public MonsterClimbDebris()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B690]");
		chipsPerMetre = 0f;
		base._002Ector();
	}
}
