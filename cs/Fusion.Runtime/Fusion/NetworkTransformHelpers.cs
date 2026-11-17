using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public static class NetworkTransformHelpers
{
	public enum BodyInterpolation
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		Interpolate,
		// error: enumerator has no value
		Extrapolate
	}

	private const float _fallingEpsilon = default(float);

	public static float DefaultStalledErrorCorrectionDetection(NetworkTransform networkTransform, float physicsDt, AbstractPhysicsBody physicsBody, Vector3 previousLocalPosition, Vector3 previousExtrapolatedPosition, ref KinematicSnapshot localSnapshot, ref KinematicSnapshot extrapolatedSnapshot)
	{
		//IL_02c7: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_0239: Invalid comparison between F4 and I
		//IL_0260: Invalid comparison between F4 and I
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		object obj9 = default;
		object obj10 = default;
		object obj8 = obj9 - obj10;
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj * obj;
		object obj14 = obj4 * obj4;
		object obj15 = obj13 + obj14;
		object obj16 = obj8 * obj8;
		object obj17 = obj16 + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj18;
		object obj19;
		object obj20;
		if ((nint)obj17 > 0)
		{
			obj18 = obj / obj17;
			obj19 = obj4 / obj17;
			obj20 = obj8 / obj17;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12+A0]");
			object obj23 = 0;
			obj18 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v13+4]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v13+8]");
			obj20 = 0;
		}
		object obj24 = previousLocalPosition - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousLocalPosition @ X2 (Fusion.AbstractPhysicsBody)+4]");
		object obj25 = 0 - obj6;
		float num = previousExtrapolatedPosition.x - (float)previousLocalPosition;
		float num2 = previousExtrapolatedPosition.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousLocalPosition @ X2 (Fusion.AbstractPhysicsBody)+4]");
		float num3 = num2 - 0f;
		float num4 = previousExtrapolatedPosition.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousLocalPosition @ X2 (Fusion.AbstractPhysicsBody)+8]");
		float num5 = num4 - 0f;
		float num6 = (float)obj * num;
		float num7 = (float)obj4 * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousLocalPosition @ X2 (Fusion.AbstractPhysicsBody)+8]");
		object obj26 = 0 - obj10;
		object obj27 = obj24 * obj18;
		object obj28 = obj25 * obj19;
		float num8 = num6 + num7;
		float num9 = (float)obj8 * num5;
		object obj29 = obj27 + obj28;
		object obj30 = obj26 * obj20;
		float num10 = num9 + num8;
		float num11 = (float)obj30 + (float)obj29;
		networkTransform.RecordStallHeuristicData(num10, num11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [networkTransform @ X0 (Fusion.NetworkTransform)+134]");
		float result;
		if (num10 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [networkTransform @ X0 (Fusion.NetworkTransform)+130]");
			bool flag2 = num11 < 0f;
			result = 1f;
			if (flag2)
			{
				goto IL_0298;
			}
		}
		result = -1f;
		goto IL_0298;
		IL_0298:
		return result;
	}

	public unsafe static void ComputeExtrapolatedSnapshot(NetworkTransform nt, float physicsDt, AbstractPhysicsBody physicsBody, float ticksToExtrapolate, ref KinematicSnapshot local, ref KinematicSnapshot remote, out KinematicSnapshot result)
	{
		//IL_002c: Expected Obj, but got I
		//IL_0034: Expected I, but got Obj
		//IL_0042: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got Ref
		//IL_005f: Expected Obj, but got Ref
		//IL_005f: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_0680: Expected Obj, but got I4
		//IL_00af: Expected F4, but got I
		//IL_00bf: Expected F4, but got I
		//IL_00cf: Expected F4, but got I
		//IL_00df: Expected F4, but got I
		//IL_07e1: Expected F4, but got I
		//IL_07f1: Expected Obj, but got I
		//IL_0811: Expected F4, but got I
		//IL_0829: Expected F4, but got I
		//IL_0836: Expected F4, but got VT
		//IL_0115: Expected F4, but got I
		//IL_0125: Expected F4, but got I
		//IL_013d: Expected F4, but got I
		//IL_014a: Expected F4, but got VT
		//IL_015a: Expected F4, but got I
		//IL_016a: Expected F4, but got I
		//IL_017a: Expected F4, but got I
		//IL_0b8c: Expected Obj, but got I4
		//IL_0213: Invalid comparison between F4 and I
		//IL_04e2: Expected Obj, but got I
		//IL_0511: Expected VT, but got Ref
		//IL_0511: Expected VT, but got I
		//IL_0284: Expected Obj, but got I
		//IL_028c: Expected F4, but got Obj
		//IL_029c: Expected F4, but got I
		//IL_02ac: Expected F4, but got I
		//IL_0950: Expected Obj, but got I
		//IL_097a: Expected Obj, but got I4
		//IL_0726: Expected F4, but got I
		//IL_0736: Expected F4, but got I
		//IL_0746: Expected F4, but got I
		//IL_0756: Expected Obj, but got I
		//IL_076e: Expected F4, but got I
		//IL_077e: Expected F4, but got I
		//IL_0796: Expected F4, but got I
		//IL_07a3: Expected F4, but got VT
		//IL_07c3: Expected F4, but got I
		//IL_086b: Expected Obj, but got I
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected Obj, but got Unknown
		//IL_089d: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_0c5d: Expected Obj, but got I4
		//IL_0bb2: Expected Obj, but got I
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_09ac: Invalid comparison between F4 and I
		//IL_05a7: Expected F4, but got I
		//IL_05af: Expected F4, but got Obj
		//IL_05bf: Expected F4, but got I
		//IL_05dc: Expected Obj, but got I
		//IL_05f4: Expected F4, but got I
		//IL_0917: Expected Ref, but got F4
		//IL_03c9: Expected Obj, but got I
		//IL_03e1: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I
		//IL_0418: Expected F4, but got I
		//IL_0420: Expected F4, but got Obj
		//IL_0430: Expected F4, but got I
		//IL_0332: Expected Obj, but got I
		//IL_0adf: Expected F4, but got Obj
		//IL_0adf: Expected VT, but got I4
		//IL_0b53: Expected F4, but got Obj
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I
		//IL_047e: Expected Obj, but got I
		//IL_08fa: Expected VT, but got Obj
		//IL_090a: Expected F4, but got I
		//IL_04a5: Expected F4, but got I
		//IL_04b5: Expected F4, but got I
		//IL_04bd: Expected F4, but got Obj
		//IL_04cd: Expected F4, but got I
		_ = 0;
		_ = 0;
		_ = 0;
		ref KinematicSnapshot reference = ref *(KinematicSnapshot*)null;
		float deltaTime = ((SimulationBehaviour)nt)._runner.DeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		nint num = (nint)physicsBody;
		ref KinematicSnapshot reference2 = default;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 28));
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 40));
		ref KinematicSnapshot reference3 = default;
		string text = ((Enum)(object)physicsBody).ToString((string)0, (IFormatProvider)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+114]");
		float num2;
		float num3;
		float num4;
		float num5;
		float num9 = default;
		float num13;
		float num6;
		object obj4;
		float num8;
		float num14;
		float num15;
		object obj6;
		float num11;
		float num12;
		float num16;
		float num10;
		if ((nint)0 != 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+114]");
			bool flag = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
			num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
			num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
			num5 = 0f;
			if (!flag)
			{
				float num7 = default;
				num6 = num7;
				object obj5 = default;
				obj4 = obj5;
				num8 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
				num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+30]");
				num11 = 0f;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+4]");
				num12 = 0f;
				num13 = (float)reference2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
				num14 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
				num15 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
				num16 = 0f;
				goto IL_0621;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v60+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
			float num17 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
			float num18 = num17 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
			float num19 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
			float num20 = num19 * 0f;
			float num21 = num18 + num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X0_v64+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num22 = num21 * physicsDt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num23;
			float num24;
			float num25;
			if (num21 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
				num23 = 0f / num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
				num24 = 0f / num21;
				num25 = num9 / num21;
			}
			else
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v72+A0]");
				object obj13 = 0;
				num23 = (float)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v73+4]");
				num24 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v73+8]");
				num25 = 0f;
			}
			float num26 = (float)obj2 * num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
			float num27 = 0f * num24;
			float num28 = num26 + num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
			num9 = 0f * num25;
			float num29 = num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA4]");
			num4 = num29 + 0f;
			num3 = num9 + num28;
			bool flag4 = !(num3 < num4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
			num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
			num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA4]");
			obj4 = 0;
			num8 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
			num10 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+30]");
			num11 = 0f;
			obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+4]");
			num12 = 0f;
			num13 = (float)reference2;
			num14 = num3;
			num15 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
			num16 = 0f;
			if (flag4)
			{
				goto IL_0621;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
		num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA4]");
		obj4 = 0;
		num8 = num9;
		num10 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+30]");
		num11 = 0f;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+4]");
		num12 = 0f;
		num13 = (float)reference2;
		num14 = num3;
		num15 = num4;
		num16 = num5;
		goto IL_0621;
		IL_090f:
		reference = ref *(KinematicSnapshot*)num13;
		return;
		IL_0b9a:
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v36+A0]");
		object obj15 = 0;
		object obj17;
		object obj16 = obj17 - obj15;
		object obj19;
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v30+8]");
		object obj20 = obj18 - 0;
		object obj21 = obj16 * obj16;
		object obj22 = obj20 * obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj23 = obj22 + obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if ((nint)obj23 >= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj24 = 0;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v33+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v34+C0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v34+C0]");
			bool flag5 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
			float num30 = 0f;
			float num31 = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+8]");
			float num32 = 0f;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68A8]");
				object format = 0;
				object arg = default;
				string text2 = string.Format((string)format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X21_v7+10]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v767 @ X9_v8+188] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
				num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
				num30 = 0f;
				num31 = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+8]");
				num32 = 0f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+20]");
			float num30 = 0f;
			float num31 = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+8]");
			float num32 = 0f;
		}
		goto IL_090f;
		IL_0621:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+34]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD000]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v545 @ X8_v9+208] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v9+210]");
			Vector3 initPos = default;
			Vector3 vector = FloatTrajectoryPredictor.PredictPosition(deltaTime, ticksToExtrapolate, initPos, (Vector3)0, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3), num13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj31 = 0;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj33 = !flag6;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj34 = obj6 * obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj35 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v17+E4]");
			bool flag7 = (nint)0 == 0;
			object obj36 = !flag7;
			float num33 = num12;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num33 = num12;
			}
			float num34 = deltaTime * ticksToExtrapolate;
			float num35 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj38;
			float num36;
			object obj39;
			if (num35 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj37 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				obj38 = obj37 / 0;
				num36 = num11 / num33;
				obj39 = obj6;
			}
			else
			{
				object obj40 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v20+A0]");
				object obj41 = 0;
				obj38 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v21+8]");
				num36 = 0f;
				obj39 = obj6;
			}
			float num37 = num34 * num33;
			Vector3 axis = default;
			Quaternion initVel = Quaternion.Internal_AngleAxis(num37, ref axis);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
			object obj42 = default;
			float num38 = 0f * (float)obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
			float num39 = 0f * (float)obj2;
			float num40 = num33 * num37;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			float num41 = num38 + num40;
			float num42 = num38 - num40;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			float num43 = num42 - num39;
			float num44 = num41 + num40;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
			float num45 = num44 - num43;
			Vector3 vector2 = FloatTrajectoryPredictor.PredictVelocity(deltaTime, ticksToExtrapolate, (Vector3)initVel, (Vector3)0, (float)obj2);
			object obj44 = default;
			object obj43 = obj38 * obj44;
			float num46 = num37 * num36;
			obj6 = obj39 + obj43;
			num11 += num46;
			num10 = num45;
			float num30 = ticksToExtrapolate;
			float num31 = deltaTime;
			float num32 = num13;
			num12 = ticksToExtrapolate;
			num13 = deltaTime;
			num16 = (float)obj2;
			goto IL_090f;
		}
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v34+A0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+1C]");
		object obj47 = 0 - obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+24]");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v27+8]");
		object obj48 = num47 - 0;
		object obj49 = obj47 * obj47;
		object obj50 = obj48 * obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj51 = obj50 + obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if ((nint)obj51 >= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj52 = 0;
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v43+A0]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v44+C0]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v44+C0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68A0]");
				object format2 = 0;
				object arg2 = default;
				string text3 = string.Format((string)format2, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X26_v7+10]");
				object obj56 = 0;
				object obj57 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v659 @ X9_v10+188] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+28]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+30]");
				obj19 = 0;
				Vector3 axis = (Vector3)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+C]");
				num10 = 0f;
				goto IL_0b9a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+28]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X3_v3 (Fusion.KinematicSnapshot&)+30]");
		obj19 = 0;
		goto IL_0b9a;
	}

	public unsafe static void ApplyCorrection(NetworkTransform nt, float physicsDt, float physicsFps, AbstractPhysicsBody physicsBody, float timeSinceLastOnCollisionEnter, ref KinematicSnapshot localSnapshot, ref KinematicSnapshot remoteSnapshot, ref KinematicSnapshot extrapolatedSnapshot)
	{
		//IL_0010: Invalid comparison between I and F4
		//IL_0072: Invalid comparison between F4 and I4
		//IL_0081: Expected F8, but got I4
		//IL_04a1: Expected F4, but got I
		//IL_01d8: Expected Obj, but got I
		//IL_0229: Invalid comparison between F8 and I4
		//IL_0238: Invalid comparison between F8 and I4
		//IL_0250: Expected Obj, but got F8
		//IL_025d: Expected Obj, but got F8
		//IL_0292: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02f8: Expected F4, but got I
		//IL_03e1: Invalid comparison between F8 and I4
		//IL_030c: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_0343: Expected Obj, but got VT
		//IL_0360: Expected Obj, but got I
		//IL_041b: Invalid comparison between F8 and I4
		//IL_0471: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I
		//IL_0461: Expected VT, but got Ref
		//IL_0461: Expected VT, but got Ref
		//IL_0461: Expected VT, but got I4
		//IL_0178: Invalid comparison between F8 and I4
		//IL_0154: Invalid comparison between I and F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+160]");
		if (0f > timeSinceLastOnCollisionEnter)
		{
			return;
		}
		float num = timeSinceLastOnCollisionEnter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+160]");
		float num2 = num - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+164]");
		double num3 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+160]");
		double num4 = num3 - 0.0;
		float num5 = num2 / (float)num4;
		bool flag = num5 < 0f;
		double num6 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)num5 > 1.0);
			num6 = num5;
			if (!flag2)
			{
				num6 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+140]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+140]");
			if ((nint)0 == 2)
			{
				goto IL_02df;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+140]");
			if ((nint)0 != 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+14C]");
			if ((nint)0 >= (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+14C]");
				if (!(0.0 > 1.0))
				{
				}
			}
			((object)physicsBody).Finalize();
			if (!(num6 < 0.0) && num6 > 1.0)
			{
				goto IL_01ab;
			}
			int hashCode = ((Enum)(object)physicsBody).GetHashCode();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+150]");
		Quaternion a = default;
		Quaternion b = default;
		Quaternion quaternion = Quaternion.Internal_Slerp(ref a, ref b, 0f);
		goto IL_01ab;
		IL_01ab:
		string text = ((Enum)(object)physicsBody).ToString();
		Quaternion quaternion2 = Quaternion.Internal_Slerp(ref a, ref b, (float)num6);
		int num7 = ((Enum)(object)physicsBody).CompareTo((object)0);
		((object)physicsBody).Finalize();
		Vector3 vector = CalculateLinearVelocity(nt, physicsFps, ref localSnapshot, ref extrapolatedSnapshot);
		((object)physicsBody).Finalize();
		double num8 = num6 - 1.0;
		bool flag3 = num8 < 0.0;
		bool flag4 = num8 == 0.0;
		object obj = num6 ^ 1.0;
		object obj2 = num6 ^ num8;
		object obj3 = obj & obj2;
		bool flag5 = (nint)obj3 < 0;
		bool flag6 = flag3 == flag5;
		object obj4 = !flag6;
		object obj5 = obj4 | flag4;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
		}
		if (num6 < 0.0)
		{
		}
		int hashCode2 = physicsBody.GetHashCode();
		string text2 = physicsBody.ToString();
		if (num6 < 0.0 || !(num6 > 1.0))
		{
			bool flag7 = ((Enum)(object)physicsBody).Equals((object)0);
			((object)physicsBody).Finalize();
			nt.RecordForecastData((Vector3)0, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref extrapolatedSnapshot), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref remoteSnapshot), (float)num6);
			return;
		}
		goto IL_02df;
		IL_02df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+150]");
		Quaternion quaternion3 = Quaternion.Internal_Slerp(ref a, ref b, 0f);
		int num9 = ((Enum)(object)physicsBody).CompareTo((object)0);
		int hashCode3 = physicsBody.GetHashCode();
		bool flag8 = ((Enum)(object)physicsBody).Equals((object)0);
		object obj7 = nt.PositionError__BackingField * nt.PositionError__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+238]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+238]");
		object obj8 = num10 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj9 = obj8 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if ((nint)obj9 >= 0)
		{
		}
		byte b2 = ((Enum)(object)physicsBody).System_002EIConvertible_002EToByte((IFormatProvider)0);
		string text3 = ((UnityEngine.Object)(object)physicsBody).ToString();
	}

	[MethodImpl((MethodImplOptions)256)]
	private static Vector3 CalculateAngularVelocity(NetworkTransform nt, [In] ref KinematicSnapshot remoteSnapshot, [In] ref KinematicSnapshot extrapolatedSnapshot)
	{
		//IL_0030: Expected VT, but got Obj
		//IL_0022: Expected VT, but got Obj
		if ((object)nt == null)
		{
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		return (Vector3)nt;
	}

	private static Vector3 CalculateLinearVelocity(NetworkTransform nt, float physicsFps, [In] ref KinematicSnapshot localSnapshot, [In] ref KinematicSnapshot extrapolatedSnapshot)
	{
		//IL_0172: Expected VT, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_0065: Invalid comparison between F4 and I4
		//IL_0074: Expected F4, but got I4
		//IL_00a9: Invalid comparison between F4 and I4
		//IL_00b8: Invalid comparison between F4 and I4
		//IL_00cb: Expected Obj, but got F4
		//IL_00d8: Expected Obj, but got F4
		//IL_010d: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_01c7: Expected VT, but got Obj
		//IL_01e9: Expected Obj, but got I4
		if ((object)nt == null)
		{
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj4 = default;
		float num = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nt @ X0 (Fusion.NetworkTransform)+144]");
		float num2 = num * 0f;
		bool flag2 = num2 < 0f;
		float num3 = 0f;
		if (!flag2)
		{
			num3 = (float)obj4 * physicsFps;
			float num4 = num2 - num3;
			bool flag3 = num4 < 0f;
			bool flag4 = num4 == 0f;
			object obj5 = num2 ^ num3;
			object obj6 = num2 ^ num4;
			object obj7 = obj5 & obj6;
			bool flag5 = (nint)obj7 < 0;
			bool flag6 = flag3 == flag5;
			object obj8 = !flag6;
			object obj9 = obj8 | flag4;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				num3 = num2;
			}
		}
		object obj11 = obj4;
		Vector3 result = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v8 (UnityEngine.Vector3)+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj4;
		}
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if ((nint)obj13 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		}
		return result;
	}
}
