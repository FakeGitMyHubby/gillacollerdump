using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public class NetworkTransformTrace
{
	public struct NormalizedStallHeuristic
	{
		private readonly float _minimumLinearError;

		private readonly float _directionSimilarityThreshold;

		private readonly float _correctionFractionThreshold;

		private readonly float _errorRatioThreshold;

		public readonly AbstractPhysicsBody.CustomErrorDetectionDelegate Delegate;

		public unsafe NormalizedStallHeuristic(float minimumLinearError = default(float), float directionSimilarityThreshold = default(float), float correctionFractionThreshold = default(float), float errorRatioThreshold = default(float))
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_0069: Expected Obj, but got Ref
			//IL_0072: Expected Obj, but got I4
			//IL_0046: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68C0]");
			object obj3 = 0;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_minimumLinearError = minimumLinearError;
			_directionSimilarityThreshold = directionSimilarityThreshold;
			_correctionFractionThreshold = correctionFractionThreshold;
			_errorRatioThreshold = errorRatioThreshold;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			AbstractPhysicsBody.CustomErrorDetectionDelegate customErrorDetectionDelegate = default;
			object obj5 = default;
			customErrorDetectionDelegate._002Ector(obj5, (IntPtr)obj3);
			obj4 = customErrorDetectionDelegate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		private float StalledErrorCorrectionDetection(NetworkTransform networkTransform, float physicsDt, AbstractPhysicsBody physicsBody, Vector3 previousLocalPosition, Vector3 previousExtrapolatedPosition, ref KinematicSnapshot localSnapshot, ref KinematicSnapshot extrapolatedSnapshot)
		{
			//IL_041a: Expected Obj, but got I
			//IL_0537: Expected Obj, but got I4
			//IL_0032: Invalid comparison between Obj and F4
			//IL_010e: Expected F4, but got I4
			//IL_012c: Invalid comparison between F4 and I
			//IL_013b: Expected F4, but got I4
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected Obj, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected Obj, but got Unknown
			//IL_0296: Invalid comparison between F4 and I4
			//IL_02b6: Invalid comparison between F4 and I4
			//IL_02c5: Invalid comparison between F4 and I4
			//IL_02da: Expected Obj, but got F4
			//IL_02e7: Expected Obj, but got F4
			//IL_031c: Expected Obj, but got I4
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Expected Obj, but got Unknown
			//IL_04b8: Expected Obj, but got I4
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Expected Obj, but got Unknown
			//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d2: Expected Obj, but got Unknown
			//IL_04ec: Expected Obj, but got I4
			//IL_035a: Invalid comparison between F4 and I4
			//IL_0369: Invalid comparison between F4 and I4
			//IL_037e: Expected Obj, but got F4
			//IL_038b: Expected Obj, but got F4
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v2+E4]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj * obj;
			object obj13 = obj4 * obj4;
			object obj14 = obj12 + obj13;
			object obj15 = obj8 * obj8;
			object obj16 = obj15 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj18 = !flag;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_minimumLinearError);
			float result = -1f;
			if (!flag2)
			{
				float num = previousExtrapolatedPosition.x - (float)previousLocalPosition;
				float num2 = previousExtrapolatedPosition.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousLocalPosition @ X3 (Fusion.AbstractPhysicsBody)+8]");
				float num3 = num2 - 0f;
				float num4 = num * num;
				float num5 = num3 * num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				float num6 = num4 + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				bool flag3 = num6 < _minimumLinearError;
				result = -1f;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					bool flag4 = (nint)obj16 < 0;
					result = 0f;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						bool flag5 = num6 < 0f;
						result = 0f;
						if (!flag5)
						{
							object obj19 = obj / obj16;
							object obj20 = previousLocalPosition - obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousLocalPosition @ X3 (Fusion.AbstractPhysicsBody)+4]");
							object obj21 = 0 - obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousLocalPosition @ X3 (Fusion.AbstractPhysicsBody)+8]");
							object obj22 = 0 - obj10;
							object obj23 = obj4 / obj16;
							object obj24 = obj19 * obj20;
							object obj25 = obj8 / obj16;
							object obj26 = obj23 * obj21;
							object obj27 = obj24 + obj26;
							float num7 = num / num6;
							object obj28 = obj25 * obj22;
							object obj29 = obj28 + obj27;
							object obj30 = default;
							float num8 = (float)obj30 / num6;
							float num9 = (float)obj19 * num7;
							float num10 = num3 / num6;
							float num11 = (float)obj23 * num8;
							float num12 = num9 + num11;
							object obj31 = obj29 / obj16;
							float num13 = (float)obj25 * num10;
							float num14 = num13 + num12;
							float num15 = num6 / (float)obj16;
							float num16 = (float)obj31 - _correctionFractionThreshold;
							bool flag6 = num16 < 0f;
							float num17 = num15 - _errorRatioThreshold;
							bool flag7 = num17 < 0f;
							bool flag8 = num17 == 0f;
							object obj32 = num15 ^ _errorRatioThreshold;
							object obj33 = num15 ^ num17;
							object obj34 = obj32 & obj33;
							bool flag9 = (nint)obj34 < 0;
							bool flag10 = flag7 == flag9;
							object obj35 = !flag8;
							object obj36 = flag10 & obj35;
							object obj37 = ~obj36;
							bool flag11;
							bool flag12;
							bool flag13;
							if (obj37 == null)
							{
								float num18 = num14 - _directionSimilarityThreshold;
								flag11 = num18 < 0f;
								flag12 = num18 == 0f;
								object obj38 = num14 ^ _directionSimilarityThreshold;
								object obj39 = num14 ^ num18;
								object obj40 = obj38 & obj39;
								flag13 = (nint)obj40 < 0;
							}
							else
							{
								flag13 = false;
								flag12 = true;
								flag11 = false;
							}
							bool flag14 = flag11 == flag13;
							object obj41 = !flag12;
							object obj42 = flag14 & obj41;
							object obj43 = obj42 & flag6;
							bool flag15 = obj43 == null;
							object obj44 = !flag15;
							object obj45 = ~obj44;
							result = ((obj45 != null) ? (-1f) : 1f);
						}
					}
				}
			}
			return result;
		}
	}

	public struct BufferedDataReader<T> where T : struct
	{
		private int _readIndex;

		private BufferedData<T> _bufferedData;

		public unsafe T Recent
		{
			get
			{
				//IL_0008: Expected Obj, but got Ref
				//IL_0025: Expected Obj, but got I
				//IL_003b: Expected Obj, but got I
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Expected Obj, but got Unknown
				//IL_0063: Expected Obj, but got I4
				//IL_01d0: Expected Obj, but got I
				//IL_01e0: Expected Obj, but got I
				//IL_01f6: Expected Obj, but got I
				//IL_0203: Unknown result type (might be due to invalid IL or missing references)
				//IL_0208: Expected Obj, but got Unknown
				//IL_0215: Expected Obj, but got Ref
				//IL_0222: Expected Obj, but got Ref
				//IL_0098: Expected Obj, but got I
				//IL_00ae: Expected Obj, but got I
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Expected Obj, but got Unknown
				//IL_00de: Expected Obj, but got I4
				//IL_0157: Expected Obj, but got I
				//IL_0261: Expected Obj, but got I
				//IL_0271: Expected Obj, but got I
				//IL_027a: Unknown result type (might be due to invalid IL or missing references)
				//IL_027f: Expected Obj, but got Unknown
				//IL_0299: Expected Obj, but got I4
				//IL_0106: Expected Obj, but got I
				//IL_011c: Expected Obj, but got I
				//IL_02b7: Expected Obj, but got I
				//IL_02c5: Expected Obj, but got Ref
				//IL_02d5: Expected Obj, but got I
				object obj2 = default;
				object obj = (object)(&obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X2+20]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X2+20]");
				object obj4 = (nint)0 + (nint)309;
				object obj5 = obj4 & 1;
				bool flag = obj5 == null;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj7 = default;
					obj3 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+FC]");
				object obj10 = (nint)0 + (nint)15;
				object obj11 = obj10 & 0x1FFFFFFF0L;
				object obj13 = default;
				object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
				object obj14 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransformTrace+BufferedDataReader`1<T>)+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X2+20]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X2+20]");
					object obj16 = (nint)0 + (nint)309;
					object obj17 = obj16;
					object obj18 = obj16 & 1;
					bool flag2 = obj18 == null;
					object obj19 = !flag2;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X2+20]");
						obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X2+20]");
						object obj20 = (nint)0 + (nint)309;
						obj17 = obj20;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X2+20]");
						object obj21 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v13+A8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v2+18]");
					object obj23 = 0;
					object obj24 = obj17 & 1;
					bool flag3 = obj24 == null;
					object obj25 = !flag3;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						object obj26 = default;
						obj15 = obj26;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+A8]");
					object obj27 = 0;
					object obj28 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+18]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ X1_v6+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
				T result = default;
				if (num == 0)
				{
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
				T result2 = default;
				return result2;
			}
		}

		public unsafe BufferedDataReader(BufferedData<T> bufferedData)
		{
			//IL_000b: Expected Obj, but got Ref
			//IL_00b6: Expected Obj, but got I4
			//IL_0141: Expected VT, but got Obj
			//IL_0046: Expected Obj, but got I
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected Obj, but got Unknown
			//IL_0076: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got I
			//IL_0103: Expected Obj, but got I
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected Obj, but got Unknown
			//IL_012b: Expected Obj, but got I4
			//IL_009a: Expected Obj, but got I
			//IL_0152: Expected Obj, but got I
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj = bufferedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj12 = default;
			if (bufferedData != null)
			{
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2;
				object obj4 = obj2 & 1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj6 = (nint)0 + (nint)309;
					obj3 = obj6;
					nint num = 0;
				}
				else
				{
					nint num = 0;
					nint num2 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+20]");
				object obj8 = 0;
				object obj9 = obj3 & 1;
				bool flag2 = obj9 == null;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					nint num = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ X10_v3] (should have been resolved before IL gen)");
			}
			else
			{
				obj12 = 0;
			}
			BufferedDataReader<T> bufferedDataReader = (BufferedDataReader<T>)obj12;
		}

		public unsafe bool Read(out T value)
		{
			//IL_000c: Expected Obj, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_00e2: Expected Obj, but got I
			//IL_00f2: Expected Obj, but got I
			//IL_006b: Expected Obj, but got I
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0323: Expected Obj, but got I
			//IL_0333: Expected Obj, but got I
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected Obj, but got Unknown
			//IL_035b: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I
			//IL_042a: Expected Obj, but got I
			//IL_043d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0442: Expected Obj, but got Unknown
			//IL_02ee: Expected I4, but got Obj
			//IL_0134: Expected Obj, but got Ref
			//IL_013c: Expected VT, but got Obj
			//IL_017b: Expected Obj, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected Obj, but got Unknown
			//IL_01ab: Expected Obj, but got I4
			//IL_037e: Expected Obj, but got I
			//IL_038e: Expected Obj, but got I
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Expected Obj, but got Unknown
			//IL_03b6: Expected Obj, but got I4
			//IL_01cf: Expected Obj, but got I
			//IL_046f: Expected Obj, but got I
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Expected Obj, but got Unknown
			//IL_04a2: Invalid comparison between Ref and Obj
			//IL_0212: Expected VT, but got Obj
			//IL_0243: Expected Obj, but got I
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected Obj, but got Unknown
			//IL_0273: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got I
			//IL_03e4: Expected Obj, but got I
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Expected Obj, but got Unknown
			//IL_040c: Expected Obj, but got I4
			//IL_0297: Expected Obj, but got I
			//IL_04c9: Expected Obj, but got I
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Expected Obj, but got Unknown
			//IL_04fb: Expected Obj, but got I4
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransformTrace+BufferedDataReader`1<T>)+8]");
			BufferedDataReader<T> bufferedDataReader;
			if ((nint)0 != 0)
			{
				object obj4 = (nint)0 + (nint)309;
				object obj5 = obj4;
				object obj6 = obj4 & 1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj8 = (nint)0 + (nint)309;
					obj5 = obj8;
					nint num2 = 0;
				}
				else
				{
					nint num3 = 0;
					nint num2 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X10_v3+30]");
				object obj10 = 0;
				object obj11 = obj5 & 1;
				bool flag3 = obj11 == null;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr2 = default;
					nint num2 = intPtr2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v9 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ X10_v4] (should have been resolved before IL gen)");
				object obj15 = default;
				object obj14 = obj15 & 1;
				if (obj14 != null)
				{
					goto IL_0129;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransformTrace+BufferedDataReader`1<T>)+8]");
				if ((nint)0 == 0)
				{
					goto IL_02e0;
				}
				object obj16 = (nint)0 + (nint)309;
				object obj17 = obj16;
				object obj18 = obj16 & 1;
				bool flag4 = obj18 == null;
				object obj19 = !flag4;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj20 = (nint)0 + (nint)309;
					obj17 = obj20;
					nint num4 = 0;
				}
				else
				{
					nint num5 = 0;
					nint num4 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v13 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v6+20]");
				object obj22 = 0;
				object obj23 = obj17 & 1;
				bool flag5 = obj23 == null;
				object obj24 = !flag5;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr3 = default;
					nint num4 = intPtr3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v14 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v108 @ X10_v7] (should have been resolved before IL gen)");
				object obj27 = default;
				object obj26 = obj27 - 30;
				object obj28 = ~obj26;
				object obj29 = obj26 & obj28;
				if (System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref System.Runtime.CompilerServices.Unsafe.As<BufferedDataReader<T>, byte>(ref this), ref *(byte*)obj29))
				{
					bufferedDataReader = (BufferedDataReader<T>)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransformTrace+BufferedDataReader`1<T>)+8]");
					if ((nint)0 == 0)
					{
						goto IL_02e0;
					}
					object obj30 = (nint)0 + (nint)309;
					object obj31 = obj30;
					object obj32 = obj30 & 1;
					bool flag6 = obj32 == null;
					object obj33 = !flag6;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						object obj34 = (nint)0 + (nint)309;
						obj31 = obj34;
						nint num6 = 0;
					}
					else
					{
						nint num7 = 0;
						nint num6 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v17 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X10_v8+30]");
					object obj36 = 0;
					object obj37 = obj31 & 1;
					bool flag7 = obj37 == null;
					object obj38 = !flag7;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						IntPtr intPtr4 = default;
						nint num6 = intPtr4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v19 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ X10_v9] (should have been resolved before IL gen)");
					object obj41 = default;
					object obj40 = obj41 & 1;
					bool flag8 = obj40 == null;
					object obj42 = !flag8;
					if (obj42 != null)
					{
						goto IL_0129;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v2 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedDataReader`1>)+A8]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+10]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			}
			return false;
			IL_0129:
			object obj45 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 1));
			bufferedDataReader = (BufferedDataReader<T>)obj45;
			return true;
			IL_02e0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public class BufferedData<T> where T : struct
	{
		internal const int BufferSize = default(int);

		private T[] DataBuffer;

		private int BufferWriteIndex;

		private int TotalSamplesWritten;

		internal int SamplesWritten => TotalSamplesWritten;

		public bool HasData
		{
			get
			{
				//IL_006a: Expected Obj, but got I4
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Expected I4, but got Unknown
				bool flag = TotalSamplesWritten < 0;
				bool flag2 = TotalSamplesWritten == 0;
				int num = TotalSamplesWritten ^ TotalSamplesWritten;
				int num2 = TotalSamplesWritten & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
		}

		public unsafe T Recent
		{
			get
			{
				//IL_0008: Expected Obj, but got Ref
				//IL_0025: Expected Obj, but got I
				//IL_0035: Expected Obj, but got I
				//IL_0045: Expected Obj, but got I
				//IL_005b: Expected Obj, but got I
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected Obj, but got Unknown
				//IL_007a: Expected Obj, but got Ref
				//IL_0094: Expected Obj, but got I
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Expected Obj, but got Unknown
				//IL_0221: Expected Obj, but got I
				//IL_0231: Expected Obj, but got VT
				//IL_0275: Expected Obj, but got I
				//IL_0102: Expected Obj, but got I4
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Expected Obj, but got Unknown
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Expected Obj, but got Unknown
				//IL_0180: Expected Obj, but got I4
				//IL_02ca: Expected Obj, but got I
				//IL_0196: Expected I, but got Obj
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Expected Obj, but got Unknown
				//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Expected Obj, but got Unknown
				//IL_02f9: Expected Obj, but got I
				object obj2 = default;
				object obj = (object)(&obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X2+20]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X8_v2+A8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X24_v1+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v3+FC]");
				object obj6 = (nint)0 + (nint)15;
				object obj7 = obj6 & 0x1FFFFFFF0L;
				object obj9 = default;
				object obj8 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj7);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X24_v1+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ X1_v3] (should have been resolved before IL gen)");
				NullReferenceException ex = default;
				object obj11 = ex & 1;
				object obj24;
				IndexOutOfRangeException ex2;
				if (obj11 != null)
				{
					T[] dataBuffer = DataBuffer;
					if (DataBuffer != null)
					{
						object obj12 = BufferWriteIndex + 29;
						object obj13 = obj12 * 2290649225L;
						object obj14 = obj13 >> 32;
						object obj15 = obj14 + obj12;
						object obj16 = obj15 >> 4;
						object obj17 = obj16 + obj15;
						object obj18 = obj17 * 30;
						object obj19 = obj12 - obj18;
						bool flag = (nint)obj19 < dataBuffer.Length;
						object obj20 = !flag;
						if (obj20 == null)
						{
							nint num = (nint)dataBuffer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v11 (Il2CppClass<T[]>)+104]");
							object obj21 = 0 * obj19;
							object obj22 = (object)DataBuffer + obj21;
							object obj23 = obj22 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							goto IL_01e6;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-8]");
						bool flag2 = num2 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v3+FC]");
						obj24 = 0;
						ex2 = (IndexOutOfRangeException)(object)ex;
						if (flag2)
						{
							goto IL_02fe;
						}
						ex = new NullReferenceException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-8]");
					bool flag3 = num3 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v3+FC]");
					obj24 = 0;
					ex2 = (IndexOutOfRangeException)(object)ex;
					if (!flag3)
					{
						ex2 = new IndexOutOfRangeException();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v3+FC]");
						obj24 = 0;
					}
					goto IL_02fe;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				goto IL_01e6;
				IL_01e6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-8]");
				bool flag4 = num4 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v3+FC]");
				obj24 = 0;
				obj10 = obj8;
				T val = default;
				ex2 = (IndexOutOfRangeException)val;
				if (!flag4)
				{
					return val;
				}
				goto IL_02fe;
				IL_02fe:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
				T result = default;
				return result;
			}
		}

		internal unsafe void Write(T data)
		{
			//IL_0008: Expected Obj, but got Ref
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0051: Expected Obj, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0070: Expected Obj, but got Ref
			//IL_00a5: Expected Obj, but got I
			//IL_00d0: Expected Obj, but got I4
			//IL_00e0: Expected Obj, but got I
			//IL_00f6: Expected I, but got Obj
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got Unknown
			//IL_011d: Expected Obj, but got I
			//IL_0151: Expected Obj, but got I4
			//IL_0161: Expected Obj, but got I
			//IL_0177: Expected I, but got Obj
			//IL_0194: Expected Obj, but got I
			//IL_01a1: Expected VT, but got Obj
			//IL_01b1: Expected Obj, but got I
			//IL_01cb: Expected Obj, but got I4
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected Obj, but got Unknown
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected Obj, but got Unknown
			//IL_022e: Expected I4, but got Obj
			object obj2 = default;
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			_ = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedData`1>)+A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v4+FC]");
			object obj5 = (nint)0 + (nint)15;
			object obj6 = obj5 & 0x1FFFFFFF0L;
			object obj8 = default;
			object obj7 = (ref *(byte*)(&obj8)) - (ref *(byte*)obj6);
			T[] dataBuffer = DataBuffer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			bool flag = DataBuffer == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v4+FC]");
			object obj9 = 0;
			IndexOutOfRangeException ex2 = default;
			NullReferenceException ex;
			if (!flag)
			{
				bool flag2 = BufferWriteIndex < dataBuffer.Length;
				object obj10 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v4+FC]");
				obj9 = 0;
				if (obj10 == null)
				{
					nint num2 = (nint)dataBuffer;
					object obj11 = DataBuffer + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12 (Il2CppClass<T[]>)+104]");
					object obj12 = (nint)0 * (nint)BufferWriteIndex;
					object obj13 = obj11 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
					bool flag3 = BufferWriteIndex < dataBuffer.Length;
					object obj14 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v4+FC]");
					obj9 = 0;
					if (obj14 == null)
					{
						nint num3 = (nint)dataBuffer;
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v15 (Il2CppClass<T[]>)+104]");
						object obj15 = (nint)0 * (nint)BufferWriteIndex;
						T val = (T)(obj11 + obj15);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v7 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedData`1>)+A8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
						object obj17 = BufferWriteIndex + 1;
						object obj18 = obj17 * 2290649225L;
						object obj19 = obj18 >> 32;
						object obj20 = obj19 + obj17;
						object obj21 = obj20 >> 4;
						object obj22 = obj21 + obj20;
						object obj23 = obj22 * 30;
						int bufferWriteIndex = obj17 - obj23;
						int totalSamplesWritten = TotalSamplesWritten + 1;
						BufferWriteIndex = bufferWriteIndex;
						TotalSamplesWritten = totalSamplesWritten;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
						bool flag4 = num5 != 0;
						obj9 = obj7;
						if (!flag4)
						{
							return;
						}
						goto IL_0314;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
				bool flag5 = num6 != 0;
				ex = (NullReferenceException)(object)ex2;
				if (flag5)
				{
					goto IL_0314;
				}
				ex2 = new IndexOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			bool flag6 = num7 != 0;
			ex = (NullReferenceException)(object)ex2;
			if (!flag6)
			{
				ex = new NullReferenceException();
			}
			goto IL_0314;
			IL_0314:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}

		public unsafe int GetSamplesInOrder(T[] output)
		{
			//IL_0008: Expected Obj, but got Ref
			//IL_0030: Expected Obj, but got I
			//IL_0040: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected Obj, but got Unknown
			//IL_0085: Expected Obj, but got I4
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected I4, but got Unknown
			//IL_00e8: Expected Obj, but got I4
			//IL_0722: Expected Obj, but got I4
			//IL_0673: Expected Obj, but got I
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected Obj, but got Unknown
			//IL_01bc: Expected Obj, but got I4
			//IL_05f9: Expected Obj, but got I
			//IL_0609: Expected Obj, but got I
			//IL_073d: Expected Obj, but got I4
			//IL_0761: Unknown result type (might be due to invalid IL or missing references)
			//IL_0766: Expected I4, but got Unknown
			//IL_0792: Expected Obj, but got I
			//IL_07ab: Expected Obj, but got I4
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected Obj, but got Unknown
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected Obj, but got Unknown
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Expected I4, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Expected Obj, but got Unknown
			//IL_02a9: Expected Obj, but got I4
			//IL_02c4: Expected Obj, but got I4
			//IL_055a: Expected Obj, but got I
			//IL_058c: Expected Obj, but got I4
			//IL_02e2: Expected I, but got Obj
			//IL_02f2: Expected Obj, but got I
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected I4, but got Unknown
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Expected Obj, but got Unknown
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected Obj, but got Unknown
			//IL_0349: Expected Obj, but got I4
			//IL_05cc: Expected Obj, but got I4
			//IL_036f: Expected I, but got Obj
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Expected Obj, but got Unknown
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected I4, but got Unknown
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Expected Obj, but got Unknown
			//IL_03c4: Expected Obj, but got I4
			//IL_03ea: Expected I, but got Obj
			//IL_03fa: Expected Obj, but got I
			//IL_040a: Expected Obj, but got I
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Expected I4, but got Unknown
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Expected Obj, but got Unknown
			//IL_043c: Expected Obj, but got I
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Expected Obj, but got Unknown
			//IL_0476: Expected Obj, but got I4
			//IL_0495: Expected Obj, but got I4
			object obj2 = default;
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
			_ = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedData`1>)+A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v3+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v4+FC]");
			object obj5 = (nint)0 + (nint)15;
			object obj6 = obj5 & 0x1FFFFFFF0L;
			object obj7 = default;
			nint num2 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj6);
			object obj8 = TotalSamplesWritten - 30;
			bool flag = (nint)obj8 < 0;
			int num3 = TotalSamplesWritten ^ 0x1E;
			int num4 = TotalSamplesWritten ^ obj8;
			int num5 = num3 & num4;
			bool flag2 = num5 < 0;
			bool flag3 = flag == flag2;
			object obj9 = !flag3;
			object obj10 = ~obj9;
			int num6 = ((obj10 != null) ? 30 : TotalSamplesWritten);
			T[] array = default;
			T[] array2;
			T[] array3 = default;
			object obj11;
			object obj12 = default;
			IntPtr intPtr;
			nint num7 = default;
			object obj13;
			object obj14 = default;
			int num8;
			int num9 = default;
			object obj15;
			object obj16 = default;
			object obj17;
			object obj18 = default;
			IndexOutOfRangeException ex;
			object obj20 = default;
			int num10;
			int num11;
			object obj19;
			NullReferenceException ex2;
			if (TotalSamplesWritten != 0)
			{
				if (TotalSamplesWritten < 31)
				{
					if (TotalSamplesWritten < 1)
					{
						bool flag4 = array == null;
						array2 = array;
						array3 = array;
						obj11 = obj12;
						intPtr = num7;
						obj13 = obj14;
						num8 = num9;
						obj15 = obj16;
						obj17 = obj18;
						ex = (IndexOutOfRangeException)(object)this;
						obj19 = obj20;
						if (!flag4)
						{
							goto IL_050c;
						}
						goto IL_05e9;
					}
					num10 = 0;
				}
				else
				{
					num10 = BufferWriteIndex;
				}
				bool flag5 = array == null;
				obj19 = obj20;
				if (flag5)
				{
					goto IL_0663;
				}
				obj16 = array + 32;
				array2 = array;
				obj18 = 0;
				ex = (IndexOutOfRangeException)(object)this;
				obj19 = obj20;
				while (true)
				{
					num11 = array.Length;
					bool flag6 = (nint)obj18 >= array.Length;
					num9 = num10;
					if (flag6)
					{
						break;
					}
					T[] dataBuffer = DataBuffer;
					flag5 = DataBuffer == null;
					array3 = array2;
					obj11 = obj12;
					intPtr = num7;
					obj13 = obj14;
					num8 = num10;
					obj15 = obj16;
					obj17 = obj18;
					if (!flag5)
					{
						object obj21 = num10 + obj18;
						object obj22 = obj21 * 2290649225L;
						object obj23 = obj22 >> 32;
						object obj24 = obj23 + obj21;
						object obj25 = obj24 >> 4;
						object obj26 = obj25 + obj24;
						flag5 = (byte)(obj26 * 30) != 0;
						object obj27 = obj21 - flag5;
						obj19 = dataBuffer.Length;
						bool flag7 = (nint)obj27 < dataBuffer.Length;
						object obj28 = !flag7;
						ex2 = (NullReferenceException)(object)ex;
						if (obj28 == null)
						{
							nint num12 = (nint)dataBuffer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X10_v17 (Il2CppClass<T[]>)+104]");
							obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X10_v17 (Il2CppClass<T[]>)+104]");
							flag5 = (byte)(0 * obj27) != 0;
							obj12 = DataBuffer + flag5;
							array2 = (T[])(obj12 + 32);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							bool flag8 = (nint)obj18 < array.Length;
							object obj29 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v4+FC]");
							num7 = 0;
							if (obj29 == null)
							{
								nint num13 = (nint)array;
								array2 = (T[])(obj12 + 32);
								object obj30 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v20 (Il2CppClass<T[]>)+104]");
								flag5 = (byte)(obj30 * 0) != 0;
								object obj31 = obj16 + flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
								bool flag9 = (nint)obj18 < array.Length;
								object obj32 = !flag9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v4+FC]");
								num7 = 0;
								if (obj32 == null)
								{
									nint num14 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
									object obj33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X9_v17+20]");
									object obj34 = 0;
									object obj35 = obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v23 (Il2CppClass<T[]>)+104]");
									flag5 = (byte)(obj35 * 0) != 0;
									array2 = (T[])(object)(obj16 + flag5);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+A8]");
									object obj36 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
									obj18++;
									bool flag10 = num6 != (nint)obj18;
									num7 = num2;
									obj14 = 30;
									if (flag10)
									{
										continue;
									}
									goto IL_0484;
								}
							}
						}
						goto IL_054a;
					}
					goto IL_05e9;
				}
				goto IL_0730;
			}
			array3 = array;
			int num15 = 0;
			obj19 = obj20;
			goto IL_06f9;
			IL_0484:
			num7 = num2;
			obj14 = 30;
			num9 = num10;
			goto IL_050c;
			IL_0654:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			goto IL_0663;
			IL_07f5:
			object obj38;
			object obj37 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
			bool flag11 = obj37 != null;
			obj12 = obj11;
			num7 = intPtr;
			obj14 = obj13;
			num9 = num8;
			obj16 = obj15;
			obj18 = obj17;
			if (!flag11)
			{
				ex2 = new NullReferenceException();
				obj12 = obj11;
				num7 = intPtr;
				obj14 = obj13;
				num9 = num8;
				obj16 = obj15;
				obj18 = obj17;
			}
			goto IL_0654;
			IL_06f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X10_v2+28]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
			bool flag12 = num16 != 0;
			ex2 = (NullReferenceException)num15;
			if (!flag12)
			{
				return num15;
			}
			goto IL_0654;
			IL_0730:
			object obj39 = num6 - num11;
			bool flag13 = (nint)obj39 < 0;
			int num17 = num6 ^ num11;
			int num18 = num6 ^ obj39;
			int num19 = num17 & num18;
			bool flag14 = num19 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
			obj19 = 0;
			bool flag15 = flag13 == flag14;
			object obj40 = !flag15;
			obj10 = ~obj40;
			if (obj10 == null)
			{
				array3 = array2;
				num15 = num6;
			}
			else
			{
				array3 = array2;
				num15 = num11;
			}
			goto IL_06f9;
			IL_054a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v18+28]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
			bool flag16 = num20 != 0;
			array3 = array2;
			obj14 = 30;
			num9 = num10;
			if (!flag16)
			{
				ex = new IndexOutOfRangeException();
				array3 = array2;
				obj11 = obj12;
				intPtr = num7;
				obj13 = 30;
				num8 = num10;
				obj15 = obj16;
				obj17 = obj18;
				goto IL_05e9;
			}
			goto IL_0654;
			IL_0663:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X10_v2+28]");
			obj38 = 0;
			array3 = array3;
			obj11 = obj12;
			intPtr = num7;
			obj13 = obj14;
			num8 = num9;
			obj15 = obj16;
			obj17 = obj18;
			ex2 = (NullReferenceException)(object)this;
			goto IL_07f5;
			IL_05e9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v27+28]");
			obj38 = 0;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_07f5;
			IL_050c:
			num11 = array.Length;
			goto IL_0730;
		}

		public unsafe bool TryGetSample(int sampleIndex, out T value)
		{
			//IL_0008: Expected Obj, but got Ref
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0051: Expected Obj, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0070: Expected Obj, but got Ref
			//IL_008c: Expected I4, but got I8
			//IL_00a6: Expected Obj, but got I4
			//IL_00b6: Expected Obj, but got I
			//IL_03e7: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I
			//IL_0121: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got I4
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected Obj, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected Obj, but got Unknown
			//IL_031a: Expected Obj, but got I
			//IL_01a0: Expected Obj, but got I
			//IL_01ee: Expected Obj, but got I8
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected Obj, but got Unknown
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected Obj, but got Unknown
			//IL_0232: Expected Obj, but got I4
			//IL_0379: Expected Obj, but got I
			//IL_024d: Expected I, but got Obj
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected Obj, but got Unknown
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected Obj, but got Unknown
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected Obj, but got Unknown
			//IL_03a5: Expected Obj, but got I
			//IL_02bc: Expected Obj, but got I
			object obj2 = default;
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			_ = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v2 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedData`1>)+A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v3+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+FC]");
			object obj5 = (nint)0 + (nint)15;
			object obj6 = obj5 & 0x1FFFFFFF0L;
			object obj8 = default;
			object obj7 = (ref *(byte*)(&obj8)) - (ref *(byte*)obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			int num2 = (int)(sampleIndex & 0x80000000L);
			bool flag = num2 == 0;
			object obj9 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+FC]");
			object obj10 = 0;
			ref T reference = ref *(T*)null;
			bool flag2 = false;
			IndexOutOfRangeException ex;
			if (obj9 == null)
			{
				bool flag3 = TotalSamplesWritten <= sampleIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+FC]");
				obj10 = 0;
				reference = ref *(T*)null;
				flag2 = false;
				if (!flag3)
				{
					object obj11 = TotalSamplesWritten - 30;
					object obj12 = ~obj11;
					object obj13 = obj11 & obj12;
					bool flag4 = (nint)obj13 < sampleIndex;
					object obj14 = !flag4;
					object obj15 = obj13 - sampleIndex;
					bool flag5 = obj15 == null;
					object obj16 = ~obj14;
					object obj17 = obj16 | flag5;
					if (obj17 != null)
					{
						T[] dataBuffer = DataBuffer;
						if (DataBuffer != null)
						{
							object obj18 = sampleIndex * 2290649225L;
							object obj19 = obj18 >> 36;
							object obj20 = obj19 * 30;
							object obj21 = sampleIndex - obj20;
							bool flag6 = (nint)obj21 < dataBuffer.Length;
							object obj22 = !flag6;
							ex = null;
							if (obj22 == null)
							{
								nint num3 = (nint)dataBuffer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X10_v6 (Il2CppClass<T[]>)+104]");
								object obj23 = 0 * obj21;
								object obj24 = (object)DataBuffer + obj23;
								object obj25 = obj24 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								object obj26 = obj24 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v16 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedData`1>)+A8]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
								obj10 = obj7;
								reference = ref value;
								flag2 = true;
								goto IL_03be;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
							bool flag7 = num5 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+FC]");
							obj10 = 0;
							reference = ref *(T*)null;
							ex = null;
							if (flag7)
							{
								goto IL_03af;
							}
							NullReferenceException ex2 = new NullReferenceException();
							ex = (IndexOutOfRangeException)(object)ex2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
						bool flag8 = num6 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+FC]");
						obj10 = 0;
						reference = ref *(T*)null;
						if (!flag8)
						{
							ex = new IndexOutOfRangeException();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+FC]");
							obj10 = 0;
							reference = ref *(T*)null;
						}
						goto IL_03af;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+FC]");
					obj10 = 0;
					reference = ref *(T*)null;
					flag2 = false;
				}
			}
			goto IL_03be;
			IL_03af:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			bool result = default;
			return result;
			IL_03be:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag9 = num7 != 0;
			ex = (IndexOutOfRangeException)flag2;
			if (!flag9)
			{
				return flag2;
			}
			goto IL_03af;
		}

		public BufferedData()
		{
			//IL_0016: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v1 (Il2CppClass<Fusion.NetworkTransformTrace+BufferedData`1>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 16;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	public struct StallData
	{
		public float StallScore;

		public float StallProgress;
	}

	public struct StallHeuristicData
	{
		public float ErrorSimilarity;

		public float CorrectionProgress;
	}

	public struct ForecastData
	{
		public Vector3 PreviousVelocity;

		public Vector3 NewVelocity;

		public Vector3 DesiredVelocity;

		public float LerpAlpha;
	}

	public readonly BufferedData<ForecastData> ForecastBuffer;

	public readonly BufferedData<StallHeuristicData> StallHeuristicBuffer;

	public readonly BufferedData<StallData> StallBuffer;

	public readonly BufferedData<NestedComponentUtilities.CollisionEnterData> CollisionEnterBuffer;

	public NetworkTransformTrace()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D68F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BufferedData<ForecastData> bufferedData = default;
		bufferedData._002Ector();
		object obj5 = this + 16;
		obj5 = bufferedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BufferedData<StallHeuristicData> bufferedData2 = default;
		bufferedData2._002Ector();
		object obj6 = this + 24;
		obj6 = bufferedData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BufferedData<StallData> bufferedData3 = default;
		bufferedData3._002Ector();
		object obj7 = this + 32;
		obj7 = bufferedData3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BufferedData<NestedComponentUtilities.CollisionEnterData> bufferedData4 = default;
		bufferedData4._002Ector();
		object obj8 = this + 40;
		obj8 = bufferedData4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
