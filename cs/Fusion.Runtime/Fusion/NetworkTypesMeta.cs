using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Fusion;

internal class NetworkTypesMeta
{
	internal struct AnimatorData
	{
		public readonly int Param32Count;

		public readonly int ParamBoolCount;

		public readonly AnimatorControllerParameter[] Parameters;

		public readonly int ParameterCount;

		public readonly int[] ParameterHashes;

		public readonly int LayerCount;

		public readonly int SyncedLayerCount;

		public readonly int ParamBoolsWordCount;

		public readonly int ParamBoolsPtrOffset;

		public readonly int WordCount;

		public readonly int[] PrevBoolsBitmask;

		public unsafe AnimatorData(Animator animator, AnimatorSyncSettings syncSettings)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0183: Expected Obj, but got I
			//IL_01a5: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I
			//IL_006b: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got Ref
			//IL_0158: Expected Obj, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D58]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool condition = animator;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj4 = 0;
			AnimatorControllerParameter[] parameters = animator.parameters;
			object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj5 = parameters;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int parameterCount = animator.parameterCount;
			ParameterCount = parameterCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
			object obj7 = default;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int wordCount = GetWordCount(syncSettings, (AnimatorControllerParameter[])obj5, (int[])obj6, LayerCount = animator.layerCount, out System.Runtime.CompilerServices.Unsafe.As<AnimatorData, int>(ref this), out System.Runtime.CompilerServices.Unsafe.As<AnimatorData, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4)), out System.Runtime.CompilerServices.Unsafe.As<AnimatorData, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 36)), out System.Runtime.CompilerServices.Unsafe.As<AnimatorData, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40)));
			ParamBoolsPtrOffset = Param32Count;
			WordCount = wordCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
			object obj9 = default;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public unsafe static int GetWordCount(AnimatorSyncSettings syncSettings, AnimatorControllerParameter[] parameters, int[] parameterHashes, int layerCount, out int param32Count, out int paramBoolCount, out int syncedLayerCount, out int wordsUsedForBools)
		{
			//IL_03a4: Expected I4, but got Obj
			//IL_0313: Expected Obj, but got I4
			//IL_0330: Expected Obj, but got I4
			//IL_033b: Expected Obj, but got I4
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected Obj, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0073: Expected Obj, but got I4
			//IL_0430: Expected Obj, but got I4
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Expected Obj, but got Unknown
			//IL_0457: Expected Obj, but got I4
			//IL_045f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Expected Obj, but got Unknown
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0471: Expected Obj, but got Unknown
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Expected I4, but got Unknown
			//IL_0498: Expected Obj, but got I4
			//IL_0532: Expected Obj, but got I4
			//IL_0383: Expected Obj, but got I4
			//IL_04c2: Expected Obj, but got I4
			//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Expected Obj, but got Unknown
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Expected Obj, but got Unknown
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Expected Obj, but got Unknown
			//IL_04fc: Expected I4, but got Obj
			//IL_0088: Expected Obj, but got I
			//IL_00be: Expected Obj, but got I
			//IL_00fa: Expected Obj, but got I4
			//IL_02d0: Expected Obj, but got I4
			//IL_02ea: Expected Obj, but got I4
			//IL_026d: Expected Obj, but got I4
			//IL_028d: Expected Obj, but got I4
			//IL_02a7: Expected Obj, but got I4
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected Obj, but got Unknown
			//IL_0210: Expected Obj, but got I4
			//IL_01cd: Expected Obj, but got I4
			//IL_01e7: Expected Obj, but got I4
			ref int reference = ref *(int*)null;
			ref int reference2 = ref *(int*)null;
			if (parameters == null)
			{
				goto IL_0388;
			}
			if (parameters.Length < 1)
			{
				goto IL_0305;
			}
			object obj = parameters + 32;
			object obj2 = parameterHashes + 32;
			object obj3 = 0;
			while (true)
			{
				bool flag = (nint)obj3 < parameters.Length;
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v5+v73 @ X29_v6*8]");
				AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v5+v73 @ X29_v6*8]");
				ref int reference3;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v5+v73 @ X29_v6*8]");
					int nameHash = ((AnimatorControllerParameter)0).nameHash;
					if (parameterHashes != null)
					{
						bool flag2 = (nint)obj3 < parameterHashes.Length;
						object obj5 = !flag2;
						if (obj5 != null)
						{
							break;
						}
						if (animatorControllerParameter.m_Type <= (AnimatorControllerParameterType)2)
						{
							if (animatorControllerParameter.m_Type != (AnimatorControllerParameterType)1)
							{
								if (animatorControllerParameter.m_Type != (AnimatorControllerParameterType)2)
								{
									goto IL_0202;
								}
							}
							else
							{
								object obj6 = syncSettings & (AnimatorSyncSettings)2;
								bool flag3 = obj6 == null;
								object obj7 = !flag3;
								reference3 = ref param32Count;
								if (obj7 != null)
								{
									goto IL_025a;
								}
							}
						}
						else if (animatorControllerParameter.m_Type != (AnimatorControllerParameterType)3)
						{
							if (animatorControllerParameter.m_Type != (AnimatorControllerParameterType)4)
							{
								goto IL_0202;
							}
							object obj8 = syncSettings & (AnimatorSyncSettings)4;
							bool flag4 = obj8 == null;
							object obj9 = !flag4;
							reference3 = ref paramBoolCount;
							if (obj9 != null)
							{
								goto IL_025a;
							}
						}
						else
						{
							object obj10 = syncSettings & (AnimatorSyncSettings)1;
							bool flag5 = obj10 == null;
							object obj11 = !flag5;
							reference3 = ref param32Count;
							if (obj11 != null)
							{
								goto IL_025a;
							}
						}
						goto IL_03a4;
					}
				}
				goto IL_0388;
				IL_0202:
				object obj12 = syncSettings & (AnimatorSyncSettings)8;
				if (obj12 != null)
				{
					bool flag6 = animatorControllerParameter.m_Type != (AnimatorControllerParameterType)9;
					reference3 = ref paramBoolCount;
					if (!flag6)
					{
						goto IL_025a;
					}
				}
				goto IL_03a4;
				IL_03a4:
				obj3++;
				if (parameters.Length != (nint)obj3)
				{
					continue;
				}
				goto IL_0305;
				IL_025a:
				object obj13 = reference3 + 1;
				reference3 = ref *(int*)obj13;
				goto IL_03a4;
			}
			goto IL_0396;
			IL_0396:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (int)ex;
			IL_0305:
			object obj14 = syncSettings & (AnimatorSyncSettings)0x20;
			bool flag7 = obj14 == null;
			object obj15 = layerCount - 1;
			object obj16 = !flag7;
			object obj17 = ~obj16;
			int num = ((obj17 != null) ? 1 : layerCount);
			bool flag8 = layerCount < 0;
			bool flag9 = layerCount == 0;
			int num2 = layerCount ^ layerCount;
			int num3 = layerCount & num2;
			bool flag10 = num3 < 0;
			ref int reference4 = ref *(int*)num;
			object obj18 = (int)syncSettings >> 4;
			object obj19 = obj18 & 1;
			bool flag11 = flag8 == flag10;
			object obj20 = !flag9;
			object obj21 = flag11 & obj20;
			object obj22 = obj21 & syncSettings;
			bool flag12 = obj22 == null;
			int num4 = obj19 & num;
			object obj23 = !flag12;
			object obj24 = ~obj23;
			object obj25 = ((obj24 != null) ? ((object)0) : obj15);
			object obj26 = paramBoolCount << 2;
			object obj27 = param32Count + obj25;
			object obj28 = obj27 + num4;
			object obj29 = obj26 + 31;
			int result = (int)(obj28 + obj29);
			object obj30 = obj29 >> 5;
			ref int reference5 = ref *(int*)obj30;
			return result;
			IL_0388:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0396;
		}
	}

	private static class InstanceHolder
	{
		public static readonly NetworkTypesMeta Instance;

		static InstanceHolder()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0036: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
			object obj = 0;
			NetworkTypesMeta networkTypesMeta = CreateFromLoadedAssemblies();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3+A0]");
			object obj3 = 0;
			obj3 = networkTypesMeta;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private class GenericRpcInvoker
	{
		private MethodInfo _003Cmethod_003EP;

		private Dictionary<Type, RpcInvokeDelegate> Cache;

		public GenericRpcInvoker(MethodInfo method)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected Obj, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6058]");
			object obj = 0;
			object obj2 = this + 16;
			obj2 = method;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			object obj3 = this + 24;
			obj3 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}

		public unsafe void Invoke([In] ref RpcInvokeContext context)
		{
			//IL_0952: Expected Obj, but got I
			//IL_0962: Expected Obj, but got I
			//IL_0984: Expected Obj, but got I4
			//IL_0026: Expected Obj, but got I
			//IL_0044: Expected Obj, but got I4
			//IL_0744: Expected Obj, but got I4
			//IL_0868: Expected I, but got Obj
			//IL_0878: Expected Obj, but got I
			//IL_0883: Expected Obj, but got I
			//IL_08a8: Expected Obj, but got I4
			//IL_09f1: Expected I, but got Obj
			//IL_0a03: Expected Obj, but got I4
			//IL_08d3: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I
			//IL_00af: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I
			//IL_00f0: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got Ref
			//IL_0919: Expected Obj, but got I4
			//IL_0116: Expected Obj, but got I
			//IL_011e: Expected Obj, but got Ref
			//IL_09a2: Expected Obj, but got I
			//IL_09c4: Expected Obj, but got I4
			//IL_0580: Expected I, but got Obj
			//IL_058f: Expected Obj, but got I4
			//IL_059f: Expected Obj, but got I
			//IL_0621: Expected Obj, but got I4
			//IL_02b4: Expected I, but got Obj
			//IL_02c4: Expected Obj, but got I
			//IL_02cf: Expected Obj, but got I
			//IL_02db: Expected Obj, but got I4
			//IL_01fb: Expected I, but got Obj
			//IL_020b: Expected Obj, but got I
			//IL_021a: Expected Obj, but got I4
			//IL_022a: Expected Obj, but got I
			//IL_024c: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got I4
			//IL_0299: Expected Obj, but got I4
			//IL_0301: Expected Obj, but got I4
			//IL_0328: Expected Obj, but got I4
			//IL_034e: Expected Obj, but got I
			//IL_035e: Expected Obj, but got I
			//IL_036e: Expected Obj, but got I
			//IL_0390: Expected Obj, but got I4
			//IL_03b6: Expected VT, but got Obj
			//IL_03fd: Expected Obj, but got I
			//IL_0416: Expected Obj, but got I4
			//IL_04ef: Expected Obj, but got I
			//IL_0512: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X24_v2+E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.RpcInvokeContext&)+30]");
			bool flag2 = (Type)0 == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			System.__Canon value = null;
			System.__Canon _Canon = null;
			GenericRpcInvoker genericRpcInvoker = this;
			Type type;
			bool flag10;
			Type type2;
			bool flag16;
			bool flag18;
			object obj15;
			object obj17;
			object obj19;
			bool flag20;
			bool flag22;
			object obj21;
			object obj23;
			Type type5;
			object obj25;
			Type type6;
			NullReferenceException ex2;
			GenericRpcInvoker genericRpcInvoker2;
			bool flag17 = default;
			bool flag19 = default;
			object obj16 = default;
			object obj18 = default;
			object obj20 = default;
			bool flag21 = default;
			bool flag23 = default;
			object obj22 = default;
			object obj24 = default;
			Type type3 = default;
			object obj9 = default;
			Type type4 = default;
			object obj14 = default;
			string text = default;
			string text7;
			object obj27;
			string text8;
			System.__Canon _Canon4;
			if (obj4 == null)
			{
				bool flag4 = (object)Cache == null;
				value = null;
				_Canon = null;
				genericRpcInvoker = this;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6070]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.RpcInvokeContext&)+30]");
					System.__Canon _Canon2 = (System.__Canon)0;
					text = (string)obj5;
					Dictionary<Type, RpcInvokeDelegate> cache = Cache;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.RpcInvokeContext&)+30]");
					bool flag5 = ((Dictionary<System.__Canon, System.__Canon>)(object)cache).TryGetValue((System.__Canon)0, out value);
					bool flag6 = !flag5;
					object obj6 = !flag6;
					_Canon = (System.__Canon)(&value);
					if (obj6 != null)
					{
						goto IL_0537;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.RpcInvokeContext&)+30]");
					type = (Type)0;
					System.__Canon _Canon3 = (System.__Canon)(&value);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X24_v2+E8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v43+E4]");
						bool flag7 = (nint)0 == 0;
						object obj8 = !flag7;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(type != null))
						{
							break;
						}
						bool flag8 = (object)type == null;
						_Canon = null;
						genericRpcInvoker = this;
						if (!flag8)
						{
							bool isExplicitLayout = type.IsExplicitLayout;
							bool flag9 = !isExplicitLayout;
							_Canon3 = null;
							if (flag9)
							{
								goto IL_02ac;
							}
							flag10 = type.IsMarshalByRefImpl();
							MethodInfo methodInfo = _003Cmethod_003EP;
							bool flag11 = (object)_003Cmethod_003EP == null;
							_Canon = null;
							genericRpcInvoker = this;
							if (!flag11)
							{
								nint num = (nint)methodInfo;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X9_v18 (Il2CppClass<System.Reflection.MethodInfo>)+1C8]");
								obj9 = 0;
								type2 = (Type)((Type)(object)_003Cmethod_003EP).IsMarshalByRefImpl();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X24_v2+E8]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v25+E4]");
								bool flag12 = (nint)0 == 0;
								object obj11 = !flag12;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag13 = (Type)flag10 != type2;
								bool flag14 = !flag13;
								type3 = type2;
								type4 = (Type)flag10;
								_Canon3 = null;
								if (!flag14)
								{
									goto IL_02ac;
								}
								goto IL_02e0;
							}
						}
						goto IL_07d2;
						IL_02ac:
						nint num2 = (nint)type;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v22 (Il2CppClass<System.Type>)+870]");
						_Canon2 = (System.__Canon)0;
						bool flag15 = ((object)type).Equals((object)0);
						type = (Type)flag15;
					}
					MethodInfo methodInfo2 = _003Cmethod_003EP;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
					nint num3 = (nint)methodInfo2;
					string text2 = (string)((Type)(object)_003Cmethod_003EP).IsMarshalByRef;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.RpcInvokeContext&)+30]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v411 @ X8_v19+2D8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string text4 = default;
					string text5 = default;
					string text6 = default;
					string text3 = text4 + text2 + text5 + text6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					InvalidOperationException ex = default;
					ex._002Ector(text3);
					obj14 = 0;
					flag16 = flag17;
					flag18 = flag19;
					obj15 = obj16;
					obj17 = obj18;
					obj19 = obj20;
					flag20 = flag21;
					flag22 = flag23;
					obj21 = obj22;
					obj23 = obj24;
					type5 = type3;
					obj25 = obj9;
					type6 = type4;
					text = text6;
					_Canon = null;
					text7 = text3;
					genericRpcInvoker = (GenericRpcInvoker)(object)ex;
					goto IL_06a3;
				}
			}
			else
			{
				ex2 = (NullReferenceException)(object)genericRpcInvoker._003Cmethod_003EP;
				bool flag24 = (object)genericRpcInvoker._003Cmethod_003EP == null;
				object obj26 = !flag24;
				obj27 = obj14;
				flag16 = flag17;
				flag18 = flag19;
				obj15 = obj16;
				obj17 = obj18;
				obj19 = obj20;
				flag20 = flag21;
				flag22 = flag23;
				obj21 = obj22;
				obj23 = obj24;
				type5 = type3;
				obj25 = obj9;
				type6 = type4;
				text8 = text;
				_Canon4 = _Canon;
				genericRpcInvoker2 = genericRpcInvoker;
				if (obj26 != null)
				{
					goto IL_0860;
				}
			}
			goto IL_07d2;
			IL_0537:
			bool flag25 = value == null;
			genericRpcInvoker = this;
			if (!flag25)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ stack_-38_v4 (System.__Canon)+18] (should have been resolved before IL gen)");
				return;
			}
			goto IL_07d2;
			IL_06a3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			flag17 = flag16;
			flag19 = flag18;
			obj16 = obj15;
			obj18 = obj17;
			obj20 = obj19;
			flag21 = flag20;
			flag23 = flag22;
			obj22 = obj21;
			obj24 = obj23;
			type3 = type5;
			obj9 = obj25;
			type4 = type6;
			throw new ArgumentNullException();
			IL_0860:
			nint num4 = (nint)ex2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+1D0]");
			object obj28 = 0;
			sbyte b = ((Enum)(object)ex2).System_002EIConvertible_002EToSByte((IFormatProvider)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			bool flag26 = b == 0;
			string text9 = (string)b;
			if (!flag26)
			{
				sbyte value2 = ((sbyte*)b)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v8 (System.SByte)+2E0]");
				obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X8_v8 (System.SByte)+2D8] (should have been resolved before IL gen)");
				string text10 = default;
				text9 = text10;
			}
			MethodInfo methodInfo3 = genericRpcInvoker2._003Cmethod_003EP;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			nint num5 = (nint)methodInfo3;
			string text11 = (string)((Type)(object)genericRpcInvoker2._003Cmethod_003EP).IsMarshalByRef;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text13 = default;
			string text14 = default;
			string text12 = text13 + text9 + text14 + text11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex3 = default;
			ex3._002Ector(text12);
			obj14 = 0;
			text = text11;
			_Canon = null;
			text7 = text12;
			genericRpcInvoker = (GenericRpcInvoker)(object)ex3;
			goto IL_06a3;
			IL_07d2:
			ex2 = new NullReferenceException();
			obj27 = obj14;
			flag16 = flag17;
			flag18 = flag19;
			obj15 = obj16;
			obj17 = obj18;
			obj19 = obj20;
			flag20 = flag21;
			flag22 = flag23;
			obj21 = obj22;
			obj23 = obj24;
			type5 = type3;
			obj25 = obj9;
			type6 = type4;
			text8 = text;
			_Canon4 = _Canon;
			genericRpcInvoker2 = genericRpcInvoker;
			goto IL_0860;
			IL_02e0:
			bool flag27 = (object)_003Cmethod_003EP == null;
			type3 = type2;
			type4 = (Type)flag10;
			_Canon = null;
			genericRpcInvoker = this;
			if (!flag27)
			{
				string name = (string)((Type)(object)_003Cmethod_003EP).IsMarshalByRef;
				MethodInfo method = type.GetMethod(name, (BindingFlags)40);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X24_v2+E8]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FA8]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v27+E4]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v27+E4]");
				bool flag28 = (nint)0 == 0;
				object obj31 = !flag28;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj30);
				Delegate obj32 = Delegate.CreateDelegate(typeFromHandle, method);
				if ((object)obj32 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FB0]");
					object obj33 = 0;
					bool flag29 = System.Runtime.CompilerServices.Unsafe.As<Delegate, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33);
					obj24 = !flag29;
					obj22 = (object)obj32 - obj33;
					flag23 = (nint)obj22 < 0;
					flag21 = obj22 == null;
					obj20 = (object)obj32 ^ obj33;
					obj18 = (object)obj32 ^ obj22;
					obj16 = obj20 & obj18;
					flag19 = (nint)obj16 < 0;
					flag17 = obj32 != obj33;
					if (flag17)
					{
						throw new InvalidCastException();
					}
				}
				bool flag30 = (object)Cache == null;
				type3 = type2;
				type4 = (Type)obj30;
				text = null;
				value = (System.__Canon)(object)obj32;
				_Canon = (System.__Canon)(object)obj32;
				genericRpcInvoker = this;
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6068]");
					object obj34 = 0;
					text = (string)obj34;
					Dictionary<Type, RpcInvokeDelegate> cache2 = Cache;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.RpcInvokeContext&)+30]");
					((Dictionary<System.__Canon, System.__Canon>)(object)cache2).Add((System.__Canon)0, (System.__Canon)(object)obj32);
					type3 = type2;
					type4 = (Type)obj30;
					value = (System.__Canon)(object)obj32;
					_Canon = (System.__Canon)(object)obj32;
					goto IL_0537;
				}
			}
			goto IL_07d2;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass16_0
	{
		public HashSet<uint> partialInvokers;

		public Dictionary<uint, (MethodInfo, NetworkRpcWeavedInvokerAttribute)> invokers;

		public Dictionary<uint, RpcAttribute> rpcs;
	}

	public readonly Dictionary<Type, SimulationBehaviourMeta> Behaviours;

	public readonly SortedList<uint, RpcMeta> Rpcs;

	public readonly Dictionary<Type, NetworkStructMeta> Structs;

	public readonly SortedList<uint, NetworkInputMeta> Inputs;

	public static NetworkTypesMeta Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			return (NetworkTypesMeta)0;
		}
	}

	public bool TryGetBehaviourMeta(Type type, out SimulationBehaviourMeta meta)
	{
		//IL_0030: Expected I4, but got Obj
		if ((object)Behaviours != null)
		{
			return ((Dictionary<System.__Canon, SimulationBehaviourMeta>)(object)Behaviours).TryGetValue((System.__Canon)(object)type, out meta);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool TryGetRpcMeta(uint key, out RpcMeta meta)
	{
		//IL_0030: Expected I4, but got Obj
		if (Rpcs != null)
		{
			return Rpcs.TryGetValue(key, out meta);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public int GetMaxInputWordCount()
	{
		//IL_02cf: Expected I4, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0414: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected I4, but got Unknown
		//IL_0110: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0371: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_01e3: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		if (Inputs != null)
		{
			IList<NetworkInputMeta> values = Inputs.Values;
			if (values != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D78]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D80]");
				object obj2 = 0;
				object obj3 = 0;
				object obj4 = 0;
				object obj11 = default;
				object obj12 = default;
				object obj18 = default;
				while (true)
				{
					nint num = (nint)values;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00c8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
					object obj6 = (nint)0 + (nint)8;
					object obj7;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X10_v19-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj5--;
						obj7 = obj6 + 16;
						bool flag = (nint)obj5 != 1;
						obj6 = obj7;
						if (flag)
						{
							continue;
						}
						goto IL_00c8;
					}
					object obj8 = num + obj6;
					object obj9 = obj8 + 312;
					obj7 = obj6;
					goto IL_0313;
					IL_0277:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_03cc;
					IL_03cc:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v15+8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v397 @ X0_v15] (should have been resolved before IL gen)");
					obj3 = obj11 >> 32;
					goto IL_03f9;
					IL_01a4:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_0361;
					IL_00c8:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					obj10 = 0;
					goto IL_0313;
					IL_0313:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v227 @ X0_v7] (should have been resolved before IL gen)");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
					{
						break;
					}
					nint num2 = (nint)values;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01a4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
					object obj14 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v14-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj13--;
						obj7 = obj14 + 16;
						bool flag2 = (nint)obj13 != 1;
						obj14 = obj7;
						if (flag2)
						{
							continue;
						}
						goto IL_01a4;
					}
					object obj15 = num2 + obj14;
					object obj16 = obj15 + 312;
					obj7 = obj14;
					goto IL_0361;
					IL_0361:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v11+8]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v11] (should have been resolved before IL gen)");
					object obj17 = obj18 >> 32;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
					{
						goto IL_03f9;
					}
					nint num3 = (nint)values;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v15 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v15 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0277;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v15 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
					object obj20 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X10_v9-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj19--;
						obj7 = obj20 + 16;
						bool flag3 = (nint)obj19 != 1;
						obj20 = obj7;
						if (flag3)
						{
							continue;
						}
						goto IL_0277;
					}
					object obj21 = num3 + obj20;
					object obj22 = obj21 + 312;
					obj7 = obj20;
					goto IL_03cc;
					IL_03f9:
					obj4++;
				}
				return obj3 + 1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public unsafe bool TryGetInputWordCount(Type type, out int wordCount)
	{
		//IL_0321: Expected I4, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0404: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		//IL_0117: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_03cc: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I4
		//IL_0258: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_02a3: Expected Obj, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		if (Inputs != null)
		{
			IList<NetworkInputMeta> values = Inputs.Values;
			if (values != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D78]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D80]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj3 = 0;
				ref int reference = ref wordCount;
				Type type2 = null;
				object obj16;
				object obj17 = default;
				object obj18 = default;
				while (true)
				{
					nint num = (nint)values;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00d3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
					object obj5 = (nint)0 + (nint)8;
					object obj6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v19-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4--;
						obj6 = obj5 + 16;
						bool flag = (nint)obj4 != 1;
						obj5 = obj6;
						if (flag)
						{
							continue;
						}
						goto IL_00d3;
					}
					object obj7 = num + obj5;
					object obj8 = obj7 + 312;
					obj6 = obj5;
					goto IL_0365;
					IL_02e4:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_04d5;
					IL_03b2:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v359 @ X0_v12] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X27_v2+E8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = type2 == type;
					bool flag4 = !flag3;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						type2 = (Type)(type2 + 1);
						reference = ref *(int*)null;
						continue;
					}
					nint num2 = (nint)values;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v16 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v16 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02e4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v16 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
					object obj13 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X10_v9-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj12--;
						obj13 += 16;
						if ((nint)obj12 != 1)
						{
							continue;
						}
						goto IL_02e4;
					}
					object obj14 = num2 + obj13;
					object obj15 = obj14 + 312;
					goto IL_04d5;
					IL_04d5:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v432 @ X0_v19] (should have been resolved before IL gen)");
					obj16 = obj17 >> 32;
					break;
					IL_00d3:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					reference = ref *(int*)null;
					goto IL_0365;
					IL_0365:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v253 @ X0_v7] (should have been resolved before IL gen)");
					if (System.Runtime.CompilerServices.Unsafe.As<Type, UIntPtr>(ref type2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18))
					{
						nint num3 = (nint)values;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v12 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v12 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_01ab;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v12 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
						object obj20 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X10_v14-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj19--;
							obj6 = obj20 + 16;
							bool flag5 = (nint)obj19 != 1;
							obj20 = obj6;
							if (flag5)
							{
								continue;
							}
							goto IL_01ab;
						}
						object obj21 = num3 + obj20;
						object obj22 = obj21 + 312;
						obj6 = obj20;
						goto IL_03b2;
					}
					obj16 = 0;
					break;
					IL_01ab:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_03b2;
				}
				object obj23 = (object)type2 - obj18;
				bool flag6 = (nint)obj23 < 0;
				object obj24 = (object)type2 ^ obj18;
				object obj25 = (object)type2 ^ obj23;
				object obj26 = obj24 & obj25;
				bool flag7 = (nint)obj26 < 0;
				ref int reference2 = ref *(int*)obj16;
				bool flag8 = flag6 == flag7;
				return !flag8;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe bool TryGetInputTypeKey(Type type, out int key)
	{
		//IL_0237: Expected I4, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_031a: Expected I, but got Obj
		//IL_032a: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_02e2: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		if (Inputs != null)
		{
			IList<NetworkInputMeta> values = Inputs.Values;
			if (values != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D78]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D80]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj3 = 0;
				ref int reference = ref key;
				Type type2 = null;
				object obj8 = default;
				Type type3;
				while (true)
				{
					nint num = (nint)values;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00cb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
					object obj5 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v16-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4--;
						obj5 += 16;
						if ((nint)obj4 != 1)
						{
							continue;
						}
						goto IL_00cb;
					}
					object obj6 = num + obj5;
					object obj7 = obj6 + 312;
					goto IL_027b;
					IL_027b:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v253 @ X0_v7] (should have been resolved before IL gen)");
					if (System.Runtime.CompilerServices.Unsafe.As<Type, UIntPtr>(ref type2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
					{
						nint num2 = (nint)values;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v11 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v11 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0193;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v11 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
						object obj10 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X10_v11-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj9--;
							obj10 += 16;
							if ((nint)obj9 != 1)
							{
								continue;
							}
							goto IL_0193;
						}
						object obj11 = num2 + obj10;
						object obj12 = obj11 + 312;
						goto IL_02c8;
					}
					type3 = null;
					break;
					IL_02c8:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v343 @ X0_v12] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X27_v2+E8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v15+E4]");
					bool flag = (nint)0 == 0;
					object obj14 = !flag;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag2 = type2 == type;
					type2 = (Type)(type2 + 1);
					bool flag3 = !flag2;
					reference = ref *(int*)null;
					if (!flag3)
					{
						type3 = type2;
						break;
					}
					continue;
					IL_0193:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_02c8;
					IL_00cb:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					reference = ref *(int*)null;
					goto IL_027b;
				}
				object obj15 = (object)type2 - obj8;
				bool flag4 = (nint)obj15 < 0;
				object obj16 = (object)type2 ^ obj8;
				object obj17 = (object)type2 ^ obj15;
				object obj18 = obj16 & obj17;
				bool flag5 = (nint)obj18 < 0;
				ref int reference2 = ref *(int*)type3;
				bool flag6 = flag4 == flag5;
				return !flag6;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe bool TryGetInputType(int key, out Type type)
	{
		//IL_0190: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0182: Expected I4, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		object obj = key - 1;
		if ((nint)obj >= 1)
		{
			SortedList<uint, NetworkInputMeta> inputs = Inputs;
			if (Inputs != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7 (System.Collections.Generic.SortedList`2<System.UInt32, Fusion.NetworkInputMeta>)+20]");
				if ((nint)obj >= 0)
				{
					goto IL_0135;
				}
				IList<NetworkInputMeta> values = Inputs.Values;
				if (values != null)
				{
					nint num = (nint)values;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D80]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0126;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9 (Il2CppClass<System.Collections.Generic.IList`1<Fusion.NetworkInputMeta>>)+98]");
					object obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X10_v8-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj3--;
						obj4 += 16;
						if ((nint)obj3 != 1)
						{
							continue;
						}
						goto IL_0126;
					}
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					goto IL_01d1;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0135;
		IL_01d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v11+8]");
		ref Type reference = ref *(Type*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X0_v11] (should have been resolved before IL gen)");
		object obj7 = obj;
		bool result = true;
		goto IL_0201;
		IL_0201:
		ref Type reference2 = ref *(Type*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return result;
		IL_0135:
		reference = ref type;
		obj7 = 0;
		result = false;
		goto IL_0201;
		IL_0126:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01d1;
	}

	public int GetStructWordCount<T>() where T : struct, INetworkStruct
	{
		//IL_0056: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_002a: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X9_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		return GetStructWordCount(typeFromHandle);
	}

	public int GetStructWordCount(Type type)
	{
		//IL_003f: Expected I4, but got VT
		//IL_0091: Expected I4, but got Obj
		Type key = default;
		if (!((Dictionary<System.__Canon, NetworkStructMeta>)(object)Structs).TryGetValue((System.__Canon)(object)key, out NetworkStructMeta value))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentOutOfRangeException ex = default;
			string paramName = default;
			ex._002Ector(paramName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (int)ex2;
		}
		return (int)value;
	}

	public unsafe bool TryGetPropertyMeta(Type behaviourType, string propertyName, out NetworkPropertyMeta propertyMeta)
	{
		//IL_006e: Expected I4, but got Obj
		if (TryGetBehaviourMeta(behaviourType, out var _))
		{
			Dictionary<System.__Canon, NetworkPropertyMeta> dictionary = default;
			if (dictionary != null)
			{
				return dictionary.TryGetValue((System.__Canon)(object)propertyName, out propertyMeta);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		_ = 0;
		_ = 0;
		ref NetworkPropertyMeta reference = ref *(NetworkPropertyMeta*)null;
		return false;
	}

	public unsafe static NetworkTypesMeta CreateFromLoadedAssemblies()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0e26: Expected Obj, but got Ref
		//IL_006e: Expected Obj, but got Ref
		//IL_00c7: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got Ref
		//IL_017b: Expected Obj, but got Ref
		//IL_0a50: Expected Obj, but got I
		//IL_0a68: Expected Obj, but got I
		//IL_0a78: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I8
		//IL_0205: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got Ref
		//IL_0e4e: Expected Obj, but got I4
		//IL_0ae7: Expected Obj, but got I
		//IL_023d: Expected VT, but got I
		//IL_024d: Expected Obj, but got I
		//IL_0b06: Expected Obj, but got I
		//IL_0b27: Expected Obj, but got I
		//IL_0b47: Expected Obj, but got I4
		//IL_0286: Expected Obj, but got I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got Ref
		//IL_0365: Expected Obj, but got I8
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected Obj, but got Unknown
		//IL_0e75: Expected Obj, but got I4
		//IL_0db8: Expected Obj, but got I4
		//IL_0dcb: Expected Obj, but got I4
		//IL_0cf5: Expected Obj, but got I4
		//IL_0d05: Expected Obj, but got Ref
		//IL_0391: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_0d33: Expected Obj, but got I
		//IL_0d43: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I
		//IL_0480: Expected VT, but got Obj
		//IL_04a2: Expected Obj, but got I4
		//IL_0d80: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_04ff: Expected I, but got Obj
		//IL_0510: Expected Obj, but got I
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0558: Expected Obj, but got I
		//IL_0560: Expected VT, but got Obj
		//IL_0582: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_05e5: Expected Obj, but got I4
		//IL_0778: Expected I, but got Obj
		//IL_0788: Expected Obj, but got I
		//IL_07b0: Expected Obj, but got I4
		//IL_060b: Expected Obj, but got I
		//IL_0613: Expected VT, but got Obj
		//IL_0635: Expected Obj, but got I4
		//IL_07ce: Expected Obj, but got I
		//IL_07de: Expected Obj, but got I
		//IL_07e6: Expected VT, but got Obj
		//IL_0808: Expected Obj, but got I4
		//IL_068f: Expected Obj, but got I4
		//IL_0698: Expected Obj, but got I4
		//IL_0864: Expected I, but got Obj
		//IL_0875: Expected Obj, but got I
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected Obj, but got Unknown
		//IL_06c6: Expected Obj, but got I4
		//IL_0904: Expected Obj, but got I
		//IL_0914: Expected Obj, but got I
		//IL_091c: Expected VT, but got Obj
		//IL_093e: Expected Obj, but got I4
		//IL_070f: Expected Obj, but got Ref
		//IL_099a: Expected I, but got Obj
		//IL_09ab: Expected Obj, but got I
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DB0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DC0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DD0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DE0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<uint, System.__Canon> dictionary = default;
		dictionary._002Ector();
		_003C_003Ec__DisplayClass16_0 obj6 = default;
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<uint, (System.__Canon, System.__Canon)> dictionary2 = default;
		dictionary2._002Ector();
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<uint> hashSet = default;
		hashSet._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkTypesMeta networkTypesMeta = default;
		networkTypesMeta._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		AppDomain currentDomain = AppDomain.CurrentDomain;
		bool flag2 = currentDomain == null;
		HashSet<uint> hashSet2 = hashSet;
		object obj11 = (object)(&obj6);
		if (flag2)
		{
			goto IL_0c0a;
		}
		Assembly[] assemblies = currentDomain.GetAssemblies();
		bool flag3 = assemblies == null;
		hashSet2 = null;
		obj11 = (object)(&obj6);
		object obj17 = default;
		HashSet<uint> hashSet3 = default;
		object obj18 = default;
		if (!flag3)
		{
			bool flag4 = assemblies.Length < 1;
			object obj12 = default;
			obj11 = obj12;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5840]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj15 = 0;
				object obj16 = assemblies.Length & 0xFFFFFFFFL;
				obj17 = obj18;
				object obj19 = 0;
				hashSet3 = null;
				Type type = (Type)109895680;
				obj11 = (object)(&obj6);
				object obj22;
				object obj23 = default;
				while (true)
				{
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
					object obj20 = !flag5;
					if (obj20 == null)
					{
						object obj21 = (object)assemblies + obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v34+20]");
						RuntimeTypeHandle runtimeTypeHandle = (RuntimeTypeHandle)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DE8]");
						obj22 = 0;
						hashSet3 = (HashSet<uint>)obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35997A4");
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v34+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							IntPtr value = runtimeTypeHandle.value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v45 (System.IntPtr)+270]");
							hashSet3 = (HashSet<uint>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v354 @ X8_v45 (System.IntPtr)+268] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v88+18]");
							bool flag6 = (nint)0 < (nint)1;
							obj11 = obj12;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v88+18]");
								object obj24 = 0 & 0xFFFFFFFFL;
								object obj25 = obj12 + 32;
								obj2 = 0;
								while (true)
								{
									bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
									object obj26 = !flag7;
									if (obj26 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v14+E8]");
										object obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X29_v18+v360 @ X24_v22*8]");
										type = (Type)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X0_v96+E4]");
										bool flag8 = (nint)0 == 0;
										object obj28 = !flag8;
										if (obj28 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag9 = type == null;
										bool flag10 = !flag9;
										obj17 = 0;
										hashSet3 = null;
										if (flag10)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v14+E8]");
											object obj29 = 0;
											runtimeTypeHandle = (RuntimeTypeHandle)obj13;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X0_v100+E4]");
											bool flag11 = (nint)0 == 0;
											object obj30 = !flag11;
											if (obj30 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle);
											bool flag12 = (object)typeFromHandle == null;
											obj17 = 0;
											hashSet3 = null;
											if (flag12)
											{
												goto IL_0b82;
											}
											nint num = (nint)typeFromHandle;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v53 (Il2CppClass<System.Type>)+2A0]");
											obj17 = 0;
											Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
											object obj31 = elementType & 1;
											if (obj31 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v14+E8]");
												object obj32 = 0;
												runtimeTypeHandle = (RuntimeTypeHandle)obj14;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v123+E4]");
												bool flag13 = (nint)0 == 0;
												object obj33 = !flag13;
												if (obj33 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Type typeFromHandle2 = Type.GetTypeFromHandle(runtimeTypeHandle);
												bool flag14 = type == typeFromHandle2;
												bool flag15 = !flag14;
												object obj34 = !flag15;
												obj17 = 0;
												hashSet3 = (HashSet<uint>)(object)typeFromHandle2;
												if (obj34 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v14+E8]");
													object obj35 = 0;
													runtimeTypeHandle = (RuntimeTypeHandle)obj13;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v129+E4]");
													bool flag16 = (nint)0 == 0;
													object obj36 = !flag16;
													if (obj36 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Type typeFromHandle3 = Type.GetTypeFromHandle(runtimeTypeHandle);
													bool flag17 = type == typeFromHandle3;
													bool flag18 = !flag17;
													object obj37 = !flag18;
													obj17 = 0;
													hashSet3 = (HashSet<uint>)(object)typeFromHandle3;
													if (obj37 == null)
													{
														bool flag19 = networkTypesMeta == null;
														obj17 = 0;
														hashSet3 = (HashSet<uint>)(object)typeFromHandle3;
														obj11 = obj12;
														if (flag19)
														{
															break;
														}
														networkTypesMeta.AddBehaviour(type);
														_003CCreateFromLoadedAssemblies_003Eg__AddRpcs_007C16_0(type, networkTypesMeta, ref obj6);
														obj17 = (object)(&obj6);
														hashSet3 = (HashSet<uint>)(object)networkTypesMeta;
													}
												}
											}
											else
											{
												bool flag20 = (object)type == null;
												hashSet3 = (HashSet<uint>)(object)type;
												if (flag20)
												{
													goto IL_0b90;
												}
												bool isValueType = type.IsValueType;
												bool flag21 = !isValueType;
												hashSet3 = null;
												if (!flag21)
												{
													nint num2 = (nint)type;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v54 (Il2CppClass<System.Type>)+3D0]");
													hashSet3 = (HashSet<uint>)0;
													bool isCOMObject = type.IsCOMObject;
													bool flag22 = !isCOMObject;
													object obj38 = !flag22;
													if (obj38 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v14+E8]");
														object obj39 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DF0]");
														object obj40 = 0;
														runtimeTypeHandle = (RuntimeTypeHandle)obj40;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X0_v109+E4]");
														bool flag23 = (nint)0 == 0;
														object obj41 = !flag23;
														if (obj41 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Type typeFromHandle4 = Type.GetTypeFromHandle(runtimeTypeHandle);
														bool flag24 = (object)typeFromHandle4 == null;
														hashSet3 = null;
														obj11 = obj12;
														if (flag24)
														{
															goto IL_0bb4;
														}
														nint num3 = (nint)typeFromHandle4;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v56 (Il2CppClass<System.Type>)+2A0]");
														obj17 = 0;
														Type elementType2 = ((System.RuntimeType)typeFromHandle4).GetElementType();
														object obj42 = elementType2 & 1;
														if (obj42 != null)
														{
															bool flag25 = networkTypesMeta == null;
															hashSet3 = (HashSet<uint>)(object)type;
															obj11 = obj12;
															if (flag25)
															{
																goto IL_0bde;
															}
															networkTypesMeta.AddInput(type);
															hashSet3 = (HashSet<uint>)(object)type;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v14+E8]");
															object obj43 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DF8]");
															object obj44 = 0;
															runtimeTypeHandle = (RuntimeTypeHandle)obj44;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X0_v114+E4]");
															bool flag26 = (nint)0 == 0;
															object obj45 = !flag26;
															if (obj45 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															Type typeFromHandle5 = Type.GetTypeFromHandle(runtimeTypeHandle);
															bool flag27 = (object)typeFromHandle5 == null;
															hashSet3 = null;
															obj11 = obj12;
															if (flag27)
															{
																goto IL_0bd0;
															}
															nint num4 = (nint)typeFromHandle5;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v58 (Il2CppClass<System.Type>)+2A0]");
															obj17 = 0;
															Type elementType3 = ((System.RuntimeType)typeFromHandle5).GetElementType();
															object obj46 = elementType3 & 1;
															bool flag28 = obj46 == null;
															hashSet3 = (HashSet<uint>)(object)type;
															if (!flag28)
															{
																bool flag29 = networkTypesMeta == null;
																hashSet3 = (HashSet<uint>)(object)type;
																obj11 = obj12;
																if (flag29)
																{
																	goto IL_0bec;
																}
																networkTypesMeta.AddStruct(type);
																hashSet3 = (HashSet<uint>)(object)type;
															}
														}
													}
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v88+18]");
										obj24 = 0;
										obj2++;
										object obj47 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v88+18]");
										if ((nint)obj47 < 0)
										{
											continue;
										}
										goto IL_045b;
									}
									IndexOutOfRangeException ex = new IndexOutOfRangeException();
									goto IL_0b82;
									IL_0b90:
									NullReferenceException ex2 = new NullReferenceException();
									obj11 = obj12;
									goto IL_0ba6;
									IL_0b82:
									NullReferenceException ex3 = new NullReferenceException();
									goto IL_0b90;
								}
								goto IL_0bc2;
							}
						}
						goto IL_027c;
					}
					goto IL_0ba6;
					IL_0bb4:
					NullReferenceException ex4 = new NullReferenceException();
					goto IL_0bc2;
					IL_0bc2:
					NullReferenceException ex5 = new NullReferenceException();
					goto IL_0bd0;
					IL_0bd0:
					NullReferenceException ex6 = new NullReferenceException();
					goto IL_0bde;
					IL_0bde:
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_0bec;
					IL_0bec:
					NullReferenceException ex8 = new NullReferenceException();
					obj18 = obj17;
					hashSet2 = hashSet3;
					goto IL_0c0a;
					IL_045b:
					obj11 = obj12;
					goto IL_027c;
					IL_027c:
					obj16 = assemblies.Length;
					obj19++;
					if ((nint)obj19 < assemblies.Length)
					{
						continue;
					}
					goto IL_02b2;
					IL_0ba6:
					IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
					goto IL_0bb4;
				}
				NullReferenceException ex10 = new NullReferenceException();
				NullReferenceException ex11 = new NullReferenceException();
				bool flag30 = (nint)obj22 != 1;
				NullReferenceException ex12 = ex11;
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj49 = default;
					object obj48 = obj49;
					object obj50 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj52 = default;
					object obj51 = obj52 & 1;
					bool flag31 = obj51 == null;
					object obj53 = obj49;
					if (!flag31)
					{
						object obj54 = 0;
						obj53 = obj49;
						object obj56 = default;
						object obj55 = (object)(&obj56);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X0_v81+A0]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v42+20]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v42+20]");
						if ((nint)0 != 0)
						{
							object obj59 = obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v44+1E0]");
							obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v921 @ X8_v44+1D8] (should have been resolved before IL gen)");
							obj50 = obj49;
						}
						throw new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj60 = obj53;
					hashSet3 = (HashSet<uint>)(101789696 + 1224);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					NullReferenceException ex13 = default;
					ex12 = ex13;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				NetworkTypesMeta result = default;
				return result;
			}
			goto IL_0a40;
		}
		goto IL_0c18;
		IL_0c26:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_0c34;
		IL_0c34:
		throw new NullReferenceException();
		IL_0c18:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_0c26;
		IL_0a40:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj61 = 0;
		object obj62 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v17+A0]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v18+38]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v18+38]");
		if ((nint)0 != 0)
		{
			bool flag32 = stopwatch == null;
			obj18 = obj17;
			hashSet2 = hashSet3;
			if (flag32)
			{
				goto IL_0c26;
			}
			TimeSpan elapsed = stopwatch.Elapsed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E00]");
			object format = 0;
			object arg = default;
			string text = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X20_v11+10]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X20_v11+10]");
			bool flag33 = (nint)0 == 0;
			obj18 = 0;
			hashSet2 = (HashSet<uint>)(object)text;
			if (flag33)
			{
				goto IL_0c34;
			}
			object obj67 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v428 @ X8_v25+198] (should have been resolved before IL gen)");
		}
		return networkTypesMeta;
		IL_0c0a:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_0c18;
		IL_02b2:
		obj17 = obj18;
		hashSet3 = null;
		obj11 = (object)(&obj6);
		goto IL_0a40;
	}

	public unsafe void AddInput(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0023: Expected Obj, but got Ref
		//IL_005f: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37681E4");
		object obj3 = default;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		SortedList<uint, NetworkInputMeta> inputs = Inputs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+10]");
		inputs.Add((uint)num, (NetworkInputMeta)0);
	}

	public unsafe void AddBehaviour(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_187d: Expected Obj, but got I
		//IL_188d: Expected Obj, but got I
		//IL_18af: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0049: Expected VT, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected VT, but got I4
		//IL_0065: Expected VT, but got I4
		//IL_0080: Expected I, but got Obj
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00c3: Expected VT, but got I4
		//IL_02b4: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_18e6: Expected Obj, but got I
		//IL_1908: Expected Obj, but got I4
		//IL_0188: Expected VT, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected VT, but got I4
		//IL_01a4: Expected VT, but got I4
		//IL_0348: Expected VT, but got Obj
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected VT, but got I4
		//IL_0127: Expected I4, but got I8
		//IL_0141: Expected Obj, but got I4
		//IL_014a: Expected VT, but got I4
		//IL_01bf: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I4
		//IL_0225: Expected VT, but got I4
		//IL_0399: Expected I, but got Obj
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected VT, but got I4
		//IL_023b: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_0296: Expected VT, but got I4
		//IL_0424: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I
		//IL_14fb: Expected Obj, but got I4
		//IL_14ce: Expected VT, but got Ref
		//IL_0464: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_19a8: Expected Obj, but got I
		//IL_19ca: Expected Obj, but got I4
		//IL_1519: Expected Obj, but got I
		//IL_1531: Expected Obj, but got I
		//IL_1541: Expected Obj, but got I
		//IL_1561: Expected VT, but got I4
		//IL_04c2: Expected I, but got Obj
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected VT, but got I4
		//IL_1577: Expected I, but got Obj
		//IL_1597: Expected Obj, but got I
		//IL_15bc: Expected VT, but got I4
		//IL_15c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Expected VT, but got I4
		//IL_15e1: Expected VT, but got I4
		//IL_04e5: Expected Obj, but got I
		//IL_04ed: Expected VT, but got Obj
		//IL_050f: Expected Obj, but got I4
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected Obj, but got I
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1625: Expected Obj, but got I
		//IL_1647: Expected VT, but got I4
		//IL_164d: Unknown result type (might be due to invalid IL or missing references)
		//IL_165a: Expected VT, but got I4
		//IL_166c: Expected VT, but got I4
		//IL_0563: Expected I, but got Obj
		//IL_13d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13de: Expected Obj, but got I4
		//IL_13e7: Expected Obj, but got I4
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f8: Expected Obj, but got I4
		//IL_1401: Expected Obj, but got I4
		//IL_1693: Expected Obj, but got I
		//IL_16a3: Expected Obj, but got I
		//IL_16c0: Expected Obj, but got I
		//IL_16ef: Expected VT, but got I4
		//IL_1aae: Expected Obj, but got I
		//IL_1ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abf: Expected Ref, but got Unknown
		//IL_1ad9: Expected Obj, but got I4
		//IL_1ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae1: Expected VT, but got Unknown
		//IL_0ad6: Invalid comparison between VT and I4
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected Obj, but got I4
		//IL_0af6: Expected Obj, but got I4
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected VT, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected VT, but got I4
		//IL_05a8: Expected I, but got Obj
		//IL_17ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1420: Expected Obj, but got I4
		//IL_1420: Unknown result type (might be due to invalid IL or missing references)
		//IL_1428: Expected Obj, but got Unknown
		//IL_0b31: Expected Obj, but got I
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected Obj, but got I4
		//IL_0b74: Expected Obj, but got I4
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected VT, but got Unknown
		//IL_05c6: Expected I, but got Obj
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected VT, but got I4
		//IL_0626: Expected Obj, but got I4
		//IL_144d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1455: Expected VT, but got Unknown
		//IL_0bc1: Expected Obj, but got I
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Expected Obj, but got Unknown
		//IL_0d98: Expected Obj, but got I
		//IL_0da8: Expected VT, but got I
		//IL_0dca: Expected Obj, but got I4
		//IL_0a0e: Expected I, but got Obj
		//IL_0a2e: Expected Obj, but got I
		//IL_0a39: Expected Obj, but got I
		//IL_0a3d: Expected Obj, but got I4
		//IL_0a45: Expected VT, but got Obj
		//IL_1808: Expected Obj, but got I4
		//IL_147d: Expected Obj, but got I4
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148d: Expected VT, but got Unknown
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected VT, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected Obj, but got I4
		//IL_0c1f: Expected Obj, but got I4
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Expected VT, but got Unknown
		//IL_0673: Expected Obj, but got I8
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected I4, but got Unknown
		//IL_06cb: Expected Obj, but got I4
		//IL_1867: Expected Obj, but got I4
		//IL_0e2c: Expected I, but got Obj
		//IL_192f: Expected Obj, but got I4
		//IL_193d: Unknown result type (might be due to invalid IL or missing references)
		//IL_194a: Expected VT, but got I4
		//IL_197a: Expected VT, but got Obj
		//IL_11b1: Expected Obj, but got I4
		//IL_0c5f: Expected Obj, but got I
		//IL_0c7c: Expected VT, but got I4
		//IL_0c9e: Expected Obj, but got I4
		//IL_19e8: Expected Obj, but got I
		//IL_1a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1a: Expected Obj, but got I4
		//IL_1a23: Expected Obj, but got I4
		//IL_1a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a33: Expected VT, but got Unknown
		//IL_1a3b: Expected VT, but got Obj
		//IL_0e4a: Expected Obj, but got I
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7c: Expected Obj, but got I4
		//IL_0e85: Expected Obj, but got I4
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e95: Expected VT, but got Unknown
		//IL_0ea2: Expected I, but got Obj
		//IL_06e0: Expected Obj, but got I
		//IL_099c: Expected Obj, but got I
		//IL_11e3: Expected Obj, but got I
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_120d: Expected Obj, but got I4
		//IL_1216: Expected Obj, but got I4
		//IL_121a: Unknown result type (might be due to invalid IL or missing references)
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected VT, but got Unknown
		//IL_122e: Expected VT, but got Obj
		//IL_0ec0: Expected Obj, but got I
		//IL_0ecf: Expected I, but got Obj
		//IL_0ee4: Expected Obj, but got I
		//IL_0f01: Expected VT, but got I4
		//IL_0f23: Expected Obj, but got I4
		//IL_0717: Expected I4, but got Obj
		//IL_0730: Expected Obj, but got I
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected VT, but got I4
		//IL_076f: Expected I, but got Obj
		//IL_0778: Expected VT, but got I4
		//IL_0788: Expected VT, but got Obj
		//IL_0790: Expected I, but got Obj
		//IL_07a0: Expected Obj, but got I
		//IL_0d0b: Expected Obj, but got I
		//IL_0d37: Expected Obj, but got I4
		//IL_0d3c: Expected I, but got Obj
		//IL_12a0: Expected I4, but got Obj
		//IL_12d9: Expected VT, but got Obj
		//IL_12dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ea: Expected Obj, but got I4
		//IL_12f3: Expected Obj, but got I4
		//IL_12f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected VT, but got I4
		//IL_130c: Expected VT, but got Obj
		//IL_1314: Expected I4, but got Obj
		//IL_1334: Expected Obj, but got I
		//IL_1013: Expected Obj, but got I
		//IL_1023: Expected Obj, but got I
		//IL_07be: Expected Obj, but got I
		//IL_07e1: Expected Obj, but got I
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected VT, but got I4
		//IL_0825: Expected I, but got Obj
		//IL_082e: Expected VT, but got I4
		//IL_083e: Expected VT, but got Obj
		//IL_0843: Expected I, but got Obj
		//IL_104d: Expected Obj, but got I
		//IL_106a: Expected VT, but got I4
		//IL_108c: Expected Obj, but got I4
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected Obj, but got I4
		//IL_0d64: Expected Obj, but got I4
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected VT, but got Unknown
		//IL_0d79: Expected I, but got Obj
		//IL_1352: Expected Obj, but got I
		//IL_135a: Expected I4, but got Obj
		//IL_136b: Expected VT, but got Ref
		//IL_1375: Expected VT, but got I4
		//IL_139f: Expected VT, but got Obj
		//IL_13a8: Expected VT, but got I4
		//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c0: Expected VT, but got Obj
		//IL_0f90: Expected Obj, but got I
		//IL_0fb6: Expected I, but got Obj
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected Obj, but got I4
		//IL_0fd0: Expected Obj, but got I4
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected VT, but got Unknown
		//IL_0fed: Expected I, but got Obj
		//IL_0866: Expected Obj, but got I
		//IL_0876: Expected Obj, but got I
		//IL_089f: Expected Obj, but got I4
		//IL_10e0: Expected I, but got Obj
		//IL_0941: Expected Obj, but got I
		//IL_0951: Expected Obj, but got I
		//IL_096f: Expected VT, but got I4
		//IL_0974: Expected I, but got Obj
		//IL_097d: Expected VT, but got I4
		//IL_0982: Expected I, but got Obj
		//IL_08ca: Expected Obj, but got I
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected Obj, but got Unknown
		//IL_08fc: Expected Obj, but got I4
		//IL_0911: Expected I, but got Obj
		//IL_091a: Expected VT, but got I4
		//IL_0922: Expected I4, but got Obj
		//IL_0927: Expected I, but got Obj
		//IL_10fe: Expected Obj, but got I
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Expected Obj, but got I4
		//IL_1139: Expected Obj, but got I4
		//IL_113d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1141: Unknown result type (might be due to invalid IL or missing references)
		//IL_1149: Expected VT, but got Unknown
		//IL_1156: Expected I, but got Obj
		//IL_1174: Expected Obj, but got I
		//IL_1184: Expected Obj, but got I
		//IL_1194: Expected Obj, but got I
		//IL_1199: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
		Dictionary<System.__Canon, NetworkPropertyMeta> dictionary = (Dictionary<System.__Canon, NetworkPropertyMeta>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)dictionary);
		bool flag2 = (object)typeFromHandle == null;
		SimulationBehaviourMeta simulationBehaviourMeta = (SimulationBehaviourMeta)0;
		Enumerator<, > val = (Enumerator<, >)0;
		SimulationBehaviourMeta simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
		int? num = (int?)(object)0;
		Type type2 = null;
		NetworkBehaviourWeavedAttribute inheritedWeavedAttribute = default;
		Topologies topologies;
		nint num4;
		if (!flag2)
		{
			nint num2 = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v29 (Il2CppClass<System.Type>)+298]");
			int num3 = 0;
			Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
			object obj4 = elementType & 1;
			bool flag3 = obj4 == null;
			num = (int?)(object)0;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E58]");
				object obj5 = 0;
				num4 = (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599904");
				if (inheritedWeavedAttribute != null)
				{
					goto IL_0110;
				}
				bool flag4 = (object)type == null;
				simulationBehaviourMeta = (SimulationBehaviourMeta)0;
				val = (Enumerator<, >)0;
				simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
				num = (int?)(object)0;
				type2 = null;
				if (flag4)
				{
					goto IL_16f4;
				}
				nint num5 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v86 (Il2CppClass<System.Type>)+2D8]");
				num3 = 0;
				string genericArguments = (string)(object)((System.RuntimeType)type).GetGenericArguments();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F00]");
				object b = 0;
				bool flag5 = string.Equals(genericArguments, (string)b, (StringComparison)4);
				bool flag6 = !flag5;
				object obj6 = !flag6;
				num = (int?)(object)0;
				if (obj6 == null)
				{
					nint num6 = (nint)type;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v89 (Il2CppClass<System.Type>)+2D8]");
					num3 = 0;
					string genericArguments2 = (string)(object)((System.RuntimeType)type).GetGenericArguments();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EF8]");
					object b2 = 0;
					bool flag7 = string.Equals(genericArguments2, (string)b2, (StringComparison)4);
					bool flag8 = !flag7;
					num = (int?)(object)0;
					if (flag8)
					{
						inheritedWeavedAttribute = GetInheritedWeavedAttribute(type);
						bool flag9 = inheritedWeavedAttribute == null;
						object obj7 = !flag9;
						if (obj7 != null)
						{
							goto IL_0110;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
						object obj8 = 0;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X8_v94+A0]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v95+18]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v95+18]");
						bool flag10 = (nint)0 == 0;
						num = (int?)(object)0;
						if (!flag10)
						{
							nint num7 = (nint)type;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v96 (Il2CppClass<System.Type>)+2E8]");
							num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v96 (Il2CppClass<System.Type>)+2F0]");
							type2 = (Type)0;
							int genericParameterPosition = ((System.RuntimeType)type).GenericParameterPosition;
							bool flag11 = genericParameterPosition == 0;
							simulationBehaviourMeta = (SimulationBehaviourMeta)0;
							val = (Enumerator<, >)0;
							simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
							topologies = (Topologies)0;
							num = (int?)(object)0;
							num4 = 4;
							if (!flag11)
							{
								int value = ((int*)genericParameterPosition)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v97 (System.Int32)+2A8]");
								num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v97 (System.Int32)+2B0]");
								type2 = (Type)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ X8_v97 (System.Int32)+2A8] (should have been resolved before IL gen)");
								object obj12 = default;
								bool flag12 = obj12 == null;
								simulationBehaviourMeta = (SimulationBehaviourMeta)0;
								val = (Enumerator<, >)0;
								simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
								topologies = (Topologies)0;
								num = (int?)(object)0;
								num4 = 4;
								if (!flag12)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CF8]");
									object format = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D00]");
									object arg = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v165+10]");
									string text = string.Format((string)format, type, 0, arg);
									object obj13 = obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v100+198]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ X8_v100+198] (should have been resolved before IL gen)");
									num = (int?)(object)0;
									goto IL_02a4;
								}
							}
							goto IL_16f4;
						}
					}
				}
			}
			goto IL_02a4;
		}
		goto IL_16f4;
		IL_1796:
		throw new NullReferenceException();
		IL_16f4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1702;
		IL_177a:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1788;
		IL_176c:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_177a;
		IL_1788:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_1796;
		IL_1718:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_1726;
		IL_1750:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_175e;
		IL_1702:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		SimulationBehaviourMeta simulationBehaviourMeta4 = default;
		SimulationBehaviourMeta simulationBehaviourMeta3 = simulationBehaviourMeta4;
		goto IL_1718;
		IL_1726:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_1734;
		IL_1734:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_1742;
		IL_1742:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_1750;
		IL_175e:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_176c;
		IL_0110:
		int num8 = (int)(inheritedWeavedAttribute.WordCount__BackingField & 0x80000000L);
		bool flag13 = num8 == 0;
		object obj14 = !flag13;
		num = (int?)(object)0;
		if (obj14 == null)
		{
			num = inheritedWeavedAttribute.WordCount__BackingField;
		}
		goto IL_02a4;
		IL_0d4a:
		(System.__Canon, System.__Canon) tuple = default;
		val = (Enumerator<, >)tuple;
		object obj15 = 0;
		object obj16 = 0;
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		Enumerator<, > val3;
		simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
		num4 = unchecked((nint)null);
		goto IL_177a;
		IL_02a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E88]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599904");
		object obj18 = default;
		SimulationStages stages;
		SimulationModes simulationModes;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v55+10]");
			stages = (SimulationStages)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v55+14]");
			simulationModes = (SimulationModes)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v55+18]");
			topologies = (Topologies)0;
		}
		else
		{
			topologies = (Topologies)3;
			simulationModes = (SimulationModes)7;
			stages = (SimulationStages)6;
		}
		simulationBehaviourMeta = new SimulationBehaviourMeta(stages, simulationModes, topologies, num);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v57+E4]");
		bool flag14 = (nint)0 == 0;
		object obj20 = !flag14;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)dictionary);
		bool flag15 = (object)typeFromHandle2 == null;
		int? num9 = num;
		val = (Enumerator<, >)0;
		simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
		num4 = (nint)simulationModes;
		type2 = null;
		if (!flag15)
		{
			nint num10 = (nint)typeFromHandle2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v34 (Il2CppClass<System.Type>)+298]");
			int num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v34 (Il2CppClass<System.Type>)+2A0]");
			num4 = 0;
			Type elementType2 = ((System.RuntimeType)typeFromHandle2).GetElementType();
			object obj21 = elementType2 & 1;
			bool flag16 = obj21 == null;
			num9 = num;
			val = (Enumerator<, >)0;
			simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
			type2 = type;
			NetworkPropertyMeta networkPropertyMeta = default;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5ED0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EC8]");
				object obj23 = 0;
				object obj24 = obj23;
				List<(System.__Canon, System.__Canon)> list = default;
				list._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A98]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EF0]");
				System.__Canon _Canon = (System.__Canon)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EB8]");
				NetworkPropertyMetaFlags networkPropertyMetaFlags = (NetworkPropertyMetaFlags)0;
				Type type3 = type;
				System.__Canon _Canon3 = default;
				System.__Canon _Canon4 = default;
				object obj34 = default;
				object obj32 = default;
				nint num14 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1277 @ X0_v65+E4]");
					bool flag17 = (nint)0 == 0;
					object obj27 = !flag17;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag18 = type3 != null;
					bool flag19 = !flag18;
					num4 = unchecked((nint)null);
					type2 = null;
					if (flag19)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
					object obj28 = 0;
					RuntimeTypeHandle handle = (RuntimeTypeHandle)dictionary;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X0_v130+E4]");
					bool flag20 = (nint)0 == 0;
					object obj29 = !flag20;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle3 = Type.GetTypeFromHandle(handle);
					bool flag21 = type3 != typeFromHandle3;
					bool flag22 = !flag21;
					num4 = unchecked((nint)null);
					type2 = typeFromHandle3;
					if (flag22)
					{
						break;
					}
					bool flag23 = (object)type3 == null;
					num9 = num;
					val = (Enumerator<, >)0;
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
					num4 = unchecked((nint)null);
					type2 = typeFromHandle3;
					IEnumerable<Type> implementedInterfaces;
					if (!flag23)
					{
						nint num11 = (nint)type3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v73 (Il2CppClass<System.Type>)+838]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v73 (Il2CppClass<System.Type>)+840]");
						num4 = 0;
						implementedInterfaces = ((TypeInfo)type3).ImplementedInterfaces;
						bool flag24 = implementedInterfaces == null;
						num9 = num;
						val = (Enumerator<, >)0;
						simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
						type2 = (Type)54;
						if (!flag24)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v137 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
							if ((nint)0 < (nint)1)
							{
								goto IL_0a06;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v137 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
							object obj30 = 0 & 0xFFFFFFFFL;
							int num12 = implementedInterfaces + 32;
							object obj31 = obj32;
							object obj33 = obj34;
							nint num13 = num14;
							System.__Canon _Canon2 = _Canon3;
							int num15 = 0;
							Topologies topologies2 = topologies;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v73 (Il2CppClass<System.Type>)+840]");
							nint num16 = 0;
							type2 = (Type)54;
							while (true)
							{
								bool flag25 = num15 < (nint)obj30;
								object obj35 = !flag25;
								num9 = num;
								val = (Enumerator<, >)0;
								simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
								obj32 = obj31;
								obj34 = obj33;
								num14 = num13;
								_Canon3 = _Canon2;
								int num17 = num15;
								handle = (RuntimeTypeHandle)implementedInterfaces;
								topologies = topologies2;
								num4 = num16;
								if (obj35 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X29_v23 (System.Int32)+v169 @ X28_v24 (System.Int32)*8]");
								_Canon3 = (System.__Canon)0;
								type2 = (Type)obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
								if (_Canon4 == null)
								{
									goto IL_098c;
								}
								topologies = (Topologies)_Canon;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X29_v23 (System.Int32)+v169 @ X28_v24 (System.Int32)*8]");
								tuple = ((System.__Canon)0, _Canon4);
								bool flag26 = list == null;
								num9 = num;
								val = (Enumerator<, >)0;
								simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
								obj32 = obj31;
								obj34 = obj33;
								num14 = unchecked((nint)null);
								tuple = ((System.__Canon, System.__Canon))0;
								num17 = num15;
								handle = (RuntimeTypeHandle)implementedInterfaces;
								num4 = (nint)_Canon4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X29_v23 (System.Int32)+v169 @ X28_v24 (System.Int32)*8]");
								type2 = (Type)0;
								if (!flag26)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
									object obj36 = 0;
									num3 = ((NetworkPropertyMetaFlags*)(int)networkPropertyMetaFlags)->value__;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+1C]");
									obj34 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
									bool flag27 = (nint)0 == 0;
									num9 = num;
									val = (Enumerator<, >)0;
									simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
									obj32 = obj31;
									num14 = unchecked((nint)null);
									tuple = ((System.__Canon, System.__Canon))0;
									num17 = num15;
									handle = (RuntimeTypeHandle)implementedInterfaces;
									num4 = unchecked((nint)null);
									type2 = null;
									if (!flag27)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+18]");
										obj33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v81+18]");
										obj31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+18]");
										nint num18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v81+18]");
										bool flag28 = num18 < 0;
										object obj37 = !flag28;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
											nint num19 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+18]");
											object obj38 = num19 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v63 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+18]");
											num3 = (int)((nint)0 + (nint)1);
											object obj39 = obj38 + 32;
											obj39 = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											num13 = unchecked((nint)null);
											tuple = ((System.__Canon, System.__Canon))0;
											topologies2 = (Topologies)_Canon;
											num16 = unchecked((nint)null);
											type2 = null;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X9_v26 (System.Int32)+20]");
											object obj40 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X8_v82+A8]");
											object obj41 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X8_v83+70]");
											topologies2 = (Topologies)0;
											list.AddWithResize(((System.__Canon, System.__Canon))0);
											num13 = unchecked((nint)null);
											tuple = ((System.__Canon, System.__Canon))0;
											num16 = unchecked((nint)null);
											type2 = null;
										}
										goto IL_098c;
									}
								}
								goto IL_16f4;
								IL_098c:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v137 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
								obj30 = 0;
								num17 = num15 + 1;
								int num20 = num17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v137 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
								bool flag29 = (nint)num20 < (nint)0;
								obj32 = obj31;
								obj34 = obj33;
								num14 = num13;
								topologies = topologies2;
								num4 = num16;
								_Canon2 = _Canon3;
								num15 = num17;
								if (!flag29)
								{
									goto IL_0a06;
								}
							}
							goto IL_1702;
						}
					}
					goto IL_16f4;
					IL_0a06:
					nint num21 = (nint)type3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X8_v76 (Il2CppClass<System.Type>)+868]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X8_v76 (Il2CppClass<System.Type>)+870]");
					obj24 = 0;
					Type type4 = (Type)((object)type3).Equals((object)0);
					handle = (RuntimeTypeHandle)implementedInterfaces;
					type3 = type4;
				}
				bool flag30 = list == null;
				num9 = num;
				val = (Enumerator<, >)0;
				simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
				if (flag30)
				{
					goto IL_16f4;
				}
				Enumerator<, > enumerator = list.GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EA8]");
				object obj42 = 0;
				simulationBehaviourMeta3 = simulationBehaviourMeta4;
				num9 = num;
				SimulationBehaviourMeta simulationBehaviourMeta5 = simulationBehaviourMeta4;
				val3 = (Enumerator<, >)tuple;
				object obj43 = default;
				object obj46 = default;
				object obj47 = default;
				Type type5 = default;
				object obj52 = default;
				object obj59 = default;
				Type type8 = default;
				object obj64 = default;
				object obj66 = default;
				int num24 = default;
				Type type10 = default;
				Dictionary<System.__Canon, NetworkPropertyMeta> dictionary2 = default;
				System.__Canon key = default;
				while (true)
				{
					type2 = (Type)obj42;
					if (!val.MoveNext())
					{
						break;
					}
					bool flag31 = simulationBehaviourMeta4 == (SimulationBehaviourMeta)(object)0;
					val = (Enumerator<, >)tuple;
					obj15 = 0;
					obj16 = 0;
					val2 = (Enumerator<, >)(ref val);
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
					if (flag31)
					{
						goto IL_1726;
					}
					SimulationStages stages2 = simulationBehaviourMeta4.Stages;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v47 (Fusion.SimulationStages)+240]");
					type2 = (Type)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v47 (Fusion.SimulationStages)+238]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v651 @ X8_v47 (Fusion.SimulationStages)+238] (should have been resolved before IL gen)");
					bool flag32 = obj43 == null;
					val = (Enumerator<, >)tuple;
					obj15 = 0;
					obj16 = 0;
					val2 = (Enumerator<, >)(ref val);
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
					if (flag32)
					{
						goto IL_1734;
					}
					object obj44 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1634 @ X8_v48+3B8] (should have been resolved before IL gen)");
					num3 = (int)simulationBehaviourMeta4.Stages;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X9_v26 (System.Int32)+240]");
					type2 = (Type)0;
					object obj45 = obj46 & 1;
					Type type6;
					Type type7;
					RuntimeTypeHandle handle;
					if (obj45 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v706 @ X9_v26 (System.Int32)+238] (should have been resolved before IL gen)");
						bool flag33 = obj47 == null;
						val = (Enumerator<, >)tuple;
						obj15 = 0;
						obj16 = 0;
						val2 = (Enumerator<, >)(ref val);
						simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
						if (flag33)
						{
							goto IL_175e;
						}
						object obj48 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1666 @ X8_v61+438] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5ED8]");
						int num22 = 0;
						handle = (RuntimeTypeHandle)((int*)num22)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ X0_v102+E4]");
						bool flag34 = (nint)0 == 0;
						object obj50 = !flag34;
						if (obj50 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle4 = Type.GetTypeFromHandle(handle);
						nint num23;
						if (type5 == typeFromHandle4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E68]");
							object obj51 = 0;
							type2 = (Type)obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
							bool flag35 = obj52 == null;
							object obj53 = !flag35;
							num23 = unchecked((nint)null);
							if (obj53 == null)
							{
								goto IL_0d4a;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
							object obj54 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EE8]");
							num22 = 0;
							handle = (RuntimeTypeHandle)((int*)num22)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1744 @ X0_v109+E4]");
							bool flag36 = (nint)0 == 0;
							object obj55 = !flag36;
							if (obj55 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle5 = Type.GetTypeFromHandle(handle);
							if (!(type5 == typeFromHandle5))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
								object obj56 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EE0]");
								num3 = 0;
								handle = (RuntimeTypeHandle)((int*)num3)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ X0_v115+E4]");
								bool flag37 = (nint)0 == 0;
								object obj57 = !flag37;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Type typeFromHandle6 = Type.GetTypeFromHandle(handle);
								bool flag38 = type5 == typeFromHandle6;
								bool flag39 = !flag38;
								num4 = unchecked((nint)null);
								if (flag39)
								{
									goto IL_119e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E70]");
								object obj58 = 0;
								type2 = (Type)obj58;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
								bool flag40 = obj59 == null;
								val = (Enumerator<, >)tuple;
								obj15 = 0;
								obj16 = 0;
								val2 = (Enumerator<, >)(ref val);
								simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
								type3 = type5;
								num4 = unchecked((nint)null);
								if (flag40)
								{
									goto IL_1796;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X0_v122+20]");
								type6 = (Type)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X0_v122+28]");
								type7 = (Type)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X0_v122+10]");
								type3 = (Type)0;
								num4 = unchecked((nint)null);
								goto IL_19d8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E78]");
							object obj60 = 0;
							type2 = (Type)obj60;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
							bool flag41 = obj52 == null;
							num23 = unchecked((nint)null);
							val = (Enumerator<, >)tuple;
							obj15 = 0;
							obj16 = 0;
							val2 = (Enumerator<, >)(ref val);
							simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
							type3 = type5;
							num4 = unchecked((nint)null);
							num3 = num22;
							if (flag41)
							{
								goto IL_1788;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1763 @ X0_v108+10]");
						type3 = (Type)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1763 @ X0_v108+18]");
						type7 = (Type)0;
						type6 = null;
						num4 = num23;
						num3 = num22;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v706 @ X9_v26 (System.Int32)+238] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+E8]");
						object obj61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v2+98]");
						handle = (RuntimeTypeHandle)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1656 @ X0_v90+E4]");
						bool flag42 = (nint)0 == 0;
						object obj62 = !flag42;
						if (obj62 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						RuntimeTypeHandle handle2 = (RuntimeTypeHandle)(handle + 32);
						Type typeFromHandle7 = Type.GetTypeFromHandle(handle2);
						bool flag43 = type8 == typeFromHandle7;
						bool flag44 = !flag43;
						num4 = unchecked((nint)null);
						if (flag44)
						{
							goto IL_119e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E80]");
						object obj63 = 0;
						type2 = (Type)obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
						bool flag45 = obj64 == null;
						val = (Enumerator<, >)tuple;
						obj15 = 0;
						obj16 = 0;
						val2 = (Enumerator<, >)(ref val);
						simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
						type3 = type8;
						num4 = unchecked((nint)null);
						if (flag45)
						{
							goto IL_176c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X0_v97+10]");
						type3 = (Type)0;
						type6 = null;
						type7 = null;
						num4 = unchecked((nint)null);
					}
					goto IL_19d8;
					IL_119e:
					type6 = null;
					type7 = null;
					type3 = (Type)1;
					goto IL_19d8;
					IL_19d8:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E60]");
					object obj65 = 0;
					type2 = (Type)obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
					bool flag46 = obj66 == null;
					val = (Enumerator<, >)tuple;
					obj15 = 0;
					obj16 = 0;
					val2 = (Enumerator<, >)(ref val);
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
					handle = (RuntimeTypeHandle)type7;
					if (flag46)
					{
						goto IL_1742;
					}
					SimulationStages stages3 = simulationBehaviourMeta4.Stages;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v53 (Fusion.SimulationStages)+1B8]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v53 (Fusion.SimulationStages)+1C0]");
					type2 = (Type)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v507 @ X8_v53 (Fusion.SimulationStages)+1B8] (should have been resolved before IL gen)");
					bool flag47 = num24 == 0;
					val = (Enumerator<, >)tuple;
					obj15 = 0;
					obj16 = 0;
					val2 = (Enumerator<, >)(ref val);
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
					handle = (RuntimeTypeHandle)type7;
					if (flag47)
					{
						goto IL_1718;
					}
					SimulationStages stages4 = simulationBehaviourMeta4.Stages;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v54 (Fusion.SimulationStages)+238]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v793 @ X8_v54 (Fusion.SimulationStages)+238] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ stack_-C8 (System.Int32)+10]");
					nint num25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ stack_-C8 (System.Int32)+14]");
					nint num26 = 0;
					Type type9 = type3;
					Type valueReaderWriterType = type7;
					Type keyReaderWriterType = type6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v80+18]");
					networkPropertyMeta = new NetworkPropertyMeta((int)num25, (int)num26, (int)type9, type10, valueReaderWriterType, keyReaderWriterType, (NetworkPropertyMetaFlags)0);
					bool flag48 = dictionary2 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v80+18]");
					NetworkPropertyMetaFlags networkPropertyMetaFlags2 = (NetworkPropertyMetaFlags)0;
					Type type11 = type6;
					Type type12 = type7;
					num9 = (int?)(object)type10;
					val = (Enumerator<, >)tuple;
					obj15 = 0;
					obj16 = 0;
					val2 = (Enumerator<, >)(ref val);
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
					handle = (RuntimeTypeHandle)type7;
					topologies = (Topologies)type3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ stack_-C8 (System.Int32)+14]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ stack_-C8 (System.Int32)+10]");
					type2 = (Type)0;
					if (!flag48)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E90]");
						object obj67 = 0;
						topologies = (Topologies)obj67;
						dictionary2.Add(key, (NetworkPropertyMeta)(&tuple));
						simulationBehaviourMeta3 = (SimulationBehaviourMeta)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v80+18]");
						networkPropertyMetaFlags2 = (NetworkPropertyMetaFlags)0;
						type11 = type6;
						type12 = type7;
						num9 = (int?)(object)type10;
						simulationBehaviourMeta5 = (SimulationBehaviourMeta)0;
						val3 = (Enumerator<, >)networkPropertyMeta;
						tuple = ((System.__Canon, System.__Canon))networkPropertyMeta;
						handle = (RuntimeTypeHandle)type7;
						num4 = (nint)(&tuple);
						continue;
					}
					goto IL_1750;
				}
				val = (Enumerator<, >)tuple;
				obj15 = 0;
				obj16 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj68 = 0;
				object obj69 = 36;
				object obj73 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5EA0]");
					object obj70 = 0;
					type2 = (Type)obj70;
					((Enumerator<, >*)val2)->Dispose();
					bool flag49 = obj68 == null;
					object obj71 = !flag49;
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
					if (obj71 == null)
					{
						bool flag50 = obj15 == null;
						object obj72 = !flag50;
						OutOfMemoryException ex12 = (OutOfMemoryException)val2;
						if (obj72 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex12 = new OutOfMemoryException();
						val3 = (Enumerator<, >)simulationBehaviourMeta2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)type2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj15 = 1;
						obj68 = obj16;
					}
					else
					{
						if ((nint)type2 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A469C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj68 = obj73;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj16 = obj73;
					}
					obj69 = 0;
				}
				bool flag51 = (nint)obj69 == 36;
				simulationBehaviourMeta4 = simulationBehaviourMeta3;
				simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
				if (!flag51)
				{
					bool flag52 = obj69 == null;
					object obj74 = !flag52;
					simulationBehaviourMeta4 = simulationBehaviourMeta3;
					simulationBehaviourMeta2 = (SimulationBehaviourMeta)val3;
					if (obj74 != null)
					{
						return;
					}
				}
			}
			if ((object)Behaviours != null)
			{
				((Dictionary<System.__Canon, SimulationBehaviourMeta>)(object)Behaviours).Add((System.__Canon)(object)type, (SimulationBehaviourMeta)(&networkPropertyMeta));
				return;
			}
		}
		goto IL_16f4;
	}

	private static NetworkBehaviourWeavedAttribute GetInheritedWeavedAttribute(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_0308: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00cf: Expected VT, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_02a6: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I8
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E58]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E60]");
		object obj3 = 0;
		Type type2 = type;
		object obj14 = default;
		NetworkBehaviourWeavedAttribute networkBehaviourWeavedAttribute = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v4+E8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (type2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v4+E8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
				if (type2 != typeFromHandle)
				{
					if ((object)type2 != null)
					{
						nint num = (nint)type2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<System.Type>)+840]");
						object obj9 = 0;
						IEnumerable<Type> implementedInterfaces = ((TypeInfo)type2).ImplementedInterfaces;
						if (implementedInterfaces != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v18 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
							if ((nint)0 < (nint)1)
							{
								goto IL_023c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v18 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
							object obj10 = 0 & 0xFFFFFFFFL;
							object obj11 = implementedInterfaces + 32;
							object obj12 = 0;
							while (true)
							{
								bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
								object obj13 = !flag3;
								if (obj13 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
								bool flag4 = obj14 == null;
								object obj15 = !flag4;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v18 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
									obj10 = 0;
									object obj16 = obj12 + 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v18 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
									bool flag5 = (nint)obj16 < 0;
									obj12 = obj16;
									if (flag5)
									{
										continue;
									}
									goto IL_023c;
								}
								goto IL_02c2;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
						}
					}
					return (NetworkBehaviourWeavedAttribute)(object)new NullReferenceException();
				}
			}
			goto IL_02c2;
			IL_02c2:
			return null;
			IL_023c:
			if (((object)type2).Equals((object)0))
			{
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599904");
				bool flag6 = networkBehaviourWeavedAttribute == null;
				object obj17 = !flag6;
				if (obj17 != null)
				{
					break;
				}
			}
			nint num2 = (nint)type2;
			Type type3 = (Type)((object)type2).Equals((object)0);
			type2 = type3;
		}
		return networkBehaviourWeavedAttribute;
	}

	public unsafe void AddStruct(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0063: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_00e8: Expected I, but got Obj
		//IL_0321: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		//IL_0196: Expected Obj, but got Ref
		//IL_021a: Expected Obj, but got I4
		//IL_023c: Expected VT, but got I4
		//IL_023c: Expected Obj, but got VT
		//IL_01cd: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got VT
		//IL_01f7: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = (object)typeFromHandle == null;
		Type type2 = null;
		Type type3 = type;
		if (!flag2)
		{
			nint num = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6 (Il2CppClass<System.Type>)+2E0]");
			type2 = (Type)0;
			string genericArguments = (string)(object)((System.RuntimeType)typeFromHandle).GetGenericArguments();
			bool flag3 = (object)type == null;
			type3 = type;
			if (!flag3)
			{
				Type type4 = type.GetInterface(genericArguments);
				bool flag4 = type4 == null;
				bool flag5 = !flag4;
				object obj5 = !flag5;
				nint num2 = unchecked((nint)null);
				type2 = null;
				type3 = type;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format = default;
					object arg = default;
					string message = string.Format(format, type3, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					InvalidOperationException ex = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					throw new ArgumentNullException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v2+E8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v33+E4]");
				bool flag6 = (nint)0 == 0;
				object obj7 = !flag6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool condition = type != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4178]");
				object error = 0;
				Assert.Always(condition, (string)error);
				int num3 = UnsafeUtility.SizeOf(type);
				SimulationBehaviourUpdater._003C_003Ec__DisplayClass21_0 obj8 = default;
				int num4 = _003CAddStruct_003Eg__GetWordCount_007C21_0(type, ref obj8);
				int num5 = num4 << 2;
				bool flag7 = num5 >= num3;
				num2 = unchecked((nint)null);
				type2 = (Type)(&obj8);
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6010]");
					object format2 = 0;
					object obj9 = default;
					object arg2 = default;
					string error2 = string.Format((string)format2, obj8, obj9, arg2);
					Assert.AlwaysFail(error2);
					num2 = (nint)obj9;
					type2 = null;
				}
				bool flag8 = (object)Structs == null;
				type3 = (Type)num4;
				if (!flag8)
				{
					((Dictionary<System.__Canon, NetworkStructMeta>)(object)Structs).Add((System.__Canon)obj8, (NetworkStructMeta)num4);
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	public NetworkTypesMeta()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E48]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5E50]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, SimulationBehaviourMeta> dictionary = default;
		dictionary._002Ector();
		object obj6 = this + 16;
		obj6 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SortedList<uint, RpcMeta> sortedList = default;
		sortedList._002Ector();
		object obj7 = this + 24;
		obj7 = sortedList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, NetworkStructMeta> dictionary2 = default;
		dictionary2._002Ector();
		object obj8 = this + 32;
		obj8 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4357D18");
		object obj9 = this + 40;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	internal unsafe static void _003CCreateFromLoadedAssemblies_003Eg__AddRpcs_007C16_0(Type type, NetworkTypesMeta meta, ref _003C_003Ec__DisplayClass16_0 P_2)
	{
		//IL_3332: Expected Obj, but got Ref
		//IL_3347: Expected Obj, but got I4
		//IL_3355: Invalid comparison between VT and I4
		//IL_3374: Expected VT, but got I4
		//IL_3387: Expected VT, but got I4
		//IL_3390: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected Obj, but got VT
		//IL_005b: Expected VT, but got I4
		//IL_006e: Expected VT, but got I4
		//IL_0077: Expected VT, but got I4
		//IL_009e: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00e7: Expected VT, but got I4
		//IL_00fa: Expected VT, but got I4
		//IL_0103: Expected VT, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_016b: Expected VT, but got I4
		//IL_017e: Expected VT, but got I4
		//IL_0187: Expected VT, but got I4
		//IL_01a6: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_01fb: Expected VT, but got I4
		//IL_020e: Expected VT, but got I4
		//IL_0217: Expected VT, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I4
		//IL_2686: Expected VT, but got I4
		//IL_2699: Expected VT, but got I4
		//IL_26a2: Expected VT, but got I4
		//IL_026d: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I8
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02e0: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I4
		//IL_26c0: Expected Obj, but got I
		//IL_26d9: Expected Obj, but got I
		//IL_26ed: Expected Obj, but got I4
		//IL_35e2: Expected Obj, but got I4
		//IL_3153: Expected VT, but got I4
		//IL_3166: Expected VT, but got I4
		//IL_316f: Expected VT, but got I4
		//IL_274e: Expected VT, but got I4
		//IL_2761: Expected VT, but got I4
		//IL_276a: Expected VT, but got I4
		//IL_031e: Expected Obj, but got I
		//IL_33bf: Expected Obj, but got I
		//IL_33c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cd: Expected Obj, but got Unknown
		//IL_2799: Expected Obj, but got I
		//IL_27a9: Expected Obj, but got I
		//IL_27ba: Expected Obj, but got I
		//IL_27c6: Expected Obj, but got Ref
		//IL_27ce: Expected Obj, but got Ref
		//IL_27de: Expected VT, but got I
		//IL_27ee: Expected VT, but got I
		//IL_27fe: Expected VT, but got I
		//IL_281b: Expected Obj, but got I
		//IL_2841: Expected VT, but got I4
		//IL_2854: Expected VT, but got I4
		//IL_0362: Expected I, but got Obj
		//IL_0372: Expected Obj, but got I
		//IL_039b: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I
		//IL_042b: Expected I4, but got Obj
		//IL_044c: Expected Obj, but got I4
		//IL_30c1: Expected Obj, but got I4
		//IL_30ca: Expected Obj, but got I4
		//IL_30d2: Expected VT, but got Ref
		//IL_30da: Expected Obj, but got Ref
		//IL_30e2: Expected Obj, but got Ref
		//IL_30eb: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I
		//IL_04dc: Expected I4, but got Obj
		//IL_04ec: Expected Obj, but got I
		//IL_050d: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_355d: Expected Obj, but got I
		//IL_356e: Expected Ref, but got VT
		//IL_3588: Expected Obj, but got I4
		//IL_2871: Expected VT, but got I
		//IL_287a: Expected I, but got Obj
		//IL_28ab: Expected Obj, but got I4
		//IL_28b4: Expected Obj, but got I4
		//IL_28bc: Expected Obj, but got Ref
		//IL_28cc: Expected Obj, but got Ref
		//IL_28d4: Expected Obj, but got Ref
		//IL_28e4: Expected Obj, but got Ref
		//IL_0575: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I
		//IL_0732: Expected Obj, but got I
		//IL_073a: Expected I, but got Obj
		//IL_0753: Expected Obj, but got I
		//IL_0783: Expected VT, but got I4
		//IL_0796: Expected VT, but got I4
		//IL_079f: Expected VT, but got I4
		//IL_07a9: Expected VT, but got I4
		//IL_07c1: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I
		//IL_0541: Expected Obj, but got I
		//IL_11ec: Expected Obj, but got I
		//IL_310a: Expected Obj, but got I4
		//IL_3122: Expected Obj, but got VT
		//IL_28ff: Expected I, but got Obj
		//IL_2918: Expected Obj, but got I
		//IL_05f2: Expected VT, but got I4
		//IL_0605: Expected VT, but got I4
		//IL_060e: Expected VT, but got I4
		//IL_062e: Expected Obj, but got I
		//IL_1c5b: Invalid comparison between VT and I4
		//IL_1c7a: Expected VT, but got I4
		//IL_1c8d: Expected VT, but got I4
		//IL_1c96: Expected VT, but got I4
		//IL_1cbe: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I
		//IL_0831: Expected VT, but got I4
		//IL_0831: Expected Obj, but got I
		//IL_085f: Expected Obj, but got I4
		//IL_0869: Expected VT, but got I4
		//IL_086e: Expected I, but got Obj
		//IL_087e: Expected Obj, but got I
		//IL_088e: Expected Obj, but got I
		//IL_08ab: Expected Obj, but got I
		//IL_08bb: Expected Obj, but got I
		//IL_2b6f: Expected Obj, but got I
		//IL_2b87: Expected Obj, but got I
		//IL_2b97: Expected Obj, but got I
		//IL_2bbe: Expected VT, but got I
		//IL_122a: Expected VT, but got I4
		//IL_123d: Expected VT, but got I4
		//IL_1246: Expected VT, but got I4
		//IL_126e: Expected Obj, but got I
		//IL_12a6: Expected Obj, but got I
		//IL_2949: Expected VT, but got I
		//IL_2952: Expected Obj, but got I4
		//IL_295b: Expected Obj, but got I4
		//IL_2963: Expected Obj, but got Ref
		//IL_296b: Expected Obj, but got Ref
		//IL_2974: Expected Obj, but got Ref
		//IL_2994: Expected Obj, but got I4
		//IL_0674: Expected I, but got Obj
		//IL_068e: Expected Obj, but got I
		//IL_069e: Expected Obj, but got I
		//IL_06bf: Expected I, but got Obj
		//IL_06cf: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I
		//IL_06fd: Expected Obj, but got I4
		//IL_0705: Expected I, but got Obj
		//IL_1d04: Expected Obj, but got I
		//IL_1d26: Expected Obj, but got VT
		//IL_1d44: Expected Obj, but got I4
		//IL_1d5c: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_0901: Expected Obj, but got I
		//IL_0922: Expected VT, but got I4
		//IL_0927: Expected I, but got Obj
		//IL_0937: Expected Obj, but got I
		//IL_0954: Expected Obj, but got I
		//IL_0964: Expected Obj, but got I
		//IL_2be5: Expected Obj, but got I
		//IL_2bff: Expected Obj, but got I
		//IL_12c4: Expected Obj, but got I
		//IL_12cc: Expected I, but got Obj
		//IL_12ed: Expected Obj, but got I
		//IL_130b: Expected Obj, but got I4
		//IL_132b: Expected Obj, but got I
		//IL_32ae: Expected Obj, but got I4
		//IL_2c1d: Expected I, but got Obj
		//IL_2c2d: Expected Obj, but got I
		//IL_2c4e: Expected Obj, but got I
		//IL_2c62: Expected VT, but got I
		//IL_2c6a: Expected VT, but got I4
		//IL_1d7a: Expected Obj, but got I
		//IL_1d92: Expected Obj, but got I
		//IL_1da2: Expected Obj, but got I
		//IL_1dd1: Expected Obj, but got I
		//IL_0982: Expected Obj, but got I
		//IL_099c: Expected Obj, but got I
		//IL_1349: Expected Obj, but got I
		//IL_1361: Expected Obj, but got I
		//IL_1371: Expected Obj, but got I
		//IL_13a8: Expected Obj, but got I
		//IL_09d3: Expected VT, but got I4
		//IL_09e6: Expected VT, but got I4
		//IL_09ef: Expected VT, but got I4
		//IL_0a00: Expected VT, but got I
		//IL_0a0d: Expected I, but got Obj
		//IL_0a1d: Expected Obj, but got I
		//IL_0a42: Expected Obj, but got Ref
		//IL_1def: Expected Obj, but got I
		//IL_1e09: Expected Obj, but got I
		//IL_1e40: Expected VT, but got I4
		//IL_1e53: Expected VT, but got I4
		//IL_1e5c: Expected VT, but got I4
		//IL_1e6c: Expected VT, but got I
		//IL_1e8c: Expected Obj, but got I
		//IL_1e9c: Expected Obj, but got I
		//IL_1ecc: Expected Obj, but got Ref
		//IL_13c6: Expected Obj, but got I
		//IL_13e0: Expected Obj, but got I
		//IL_0a67: Expected Obj, but got Ref
		//IL_1417: Expected VT, but got I4
		//IL_142a: Expected VT, but got I4
		//IL_1433: Expected VT, but got I4
		//IL_1443: Expected VT, but got I
		//IL_1453: Expected I, but got Obj
		//IL_1463: Expected Obj, but got I
		//IL_1473: Expected Obj, but got I
		//IL_14a3: Expected Obj, but got Ref
		//IL_0b71: Expected VT, but got I
		//IL_0b76: Expected I, but got Obj
		//IL_1ef1: Expected Obj, but got Ref
		//IL_0a92: Expected Obj, but got I
		//IL_0ac4: Expected VT, but got I4
		//IL_0ad7: Expected VT, but got I4
		//IL_0ae0: Expected VT, but got I4
		//IL_0af1: Expected VT, but got I
		//IL_0afe: Expected I, but got Obj
		//IL_0b0e: Expected Obj, but got I
		//IL_0b3b: Expected Obj, but got I
		//IL_2017: Expected VT, but got I
		//IL_14c8: Expected Obj, but got Ref
		//IL_0bbf: Expected Obj, but got I4
		//IL_0bee: Expected Obj, but got I
		//IL_1f1c: Expected Obj, but got I
		//IL_1f4e: Expected VT, but got I4
		//IL_1f61: Expected VT, but got I4
		//IL_1f6a: Expected VT, but got I4
		//IL_1f7a: Expected VT, but got I
		//IL_1f9a: Expected Obj, but got I
		//IL_1faa: Expected Obj, but got I
		//IL_1fe2: Expected Obj, but got I
		//IL_15ee: Expected VT, but got I
		//IL_0c25: Expected VT, but got I4
		//IL_0c38: Expected VT, but got I4
		//IL_0c41: Expected VT, but got I4
		//IL_0c52: Expected VT, but got I
		//IL_0c5f: Expected I, but got Obj
		//IL_204b: Expected Obj, but got I4
		//IL_207a: Expected Obj, but got I
		//IL_14f3: Expected Obj, but got I
		//IL_1525: Expected VT, but got I4
		//IL_1538: Expected VT, but got I4
		//IL_1541: Expected VT, but got I4
		//IL_1551: Expected VT, but got I
		//IL_1561: Expected I, but got Obj
		//IL_1571: Expected Obj, but got I
		//IL_1581: Expected Obj, but got I
		//IL_15b9: Expected Obj, but got I
		//IL_20b1: Expected VT, but got I4
		//IL_20c4: Expected VT, but got I4
		//IL_20cd: Expected VT, but got I4
		//IL_20dd: Expected VT, but got I
		//IL_162a: Expected Obj, but got I4
		//IL_1659: Expected Obj, but got I
		//IL_0ca2: Expected Obj, but got I
		//IL_0cbc: Expected Obj, but got I8
		//IL_0cdc: Expected VT, but got I
		//IL_0ce1: Expected I, but got Obj
		//IL_0d16: Expected Obj, but got I
		//IL_1690: Expected VT, but got I4
		//IL_16a3: Expected VT, but got I4
		//IL_16ac: Expected VT, but got I4
		//IL_16bc: Expected VT, but got I
		//IL_2143: Expected Obj, but got I
		//IL_215d: Expected Obj, but got I8
		//IL_217c: Expected VT, but got I
		//IL_219c: Expected Obj, but got I
		//IL_0d32: Expected Obj, but got I4
		//IL_0d4c: Expected I, but got Obj
		//IL_0d5c: Expected Obj, but got I
		//IL_0d6c: Expected Obj, but got I
		//IL_1722: Expected Obj, but got I
		//IL_173c: Expected Obj, but got I8
		//IL_175b: Expected VT, but got I
		//IL_1783: Expected Obj, but got I
		//IL_0e8c: Expected Obj, but got I4
		//IL_0ea2: Expected Obj, but got I
		//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec7: Expected Obj, but got Unknown
		//IL_0ed8: Expected VT, but got I
		//IL_0edd: Expected I, but got Obj
		//IL_21b8: Expected Obj, but got I4
		//IL_21d2: Expected I, but got Obj
		//IL_21e2: Expected Obj, but got I
		//IL_21f2: Expected Obj, but got I
		//IL_0db3: Expected Obj, but got I
		//IL_0de5: Expected VT, but got I4
		//IL_0df8: Expected VT, but got I4
		//IL_0e01: Expected VT, but got I4
		//IL_0e12: Expected VT, but got I
		//IL_0e1f: Expected I, but got Obj
		//IL_0e47: Expected Obj, but got I
		//IL_0e5c: Expected Obj, but got I
		//IL_2327: Expected Obj, but got I4
		//IL_233d: Expected Obj, but got I
		//IL_235d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2362: Expected Obj, but got Unknown
		//IL_2372: Expected VT, but got I
		//IL_179f: Expected Obj, but got I4
		//IL_17b9: Expected I, but got Obj
		//IL_17c9: Expected Obj, but got I
		//IL_17d9: Expected Obj, but got I
		//IL_0f1e: Expected Obj, but got I4
		//IL_0f58: Expected VT, but got I4
		//IL_0f6b: Expected VT, but got I4
		//IL_0f74: Expected VT, but got I4
		//IL_0f85: Expected VT, but got I
		//IL_0f92: Expected I, but got Obj
		//IL_2239: Expected Obj, but got I
		//IL_226b: Expected VT, but got I4
		//IL_227e: Expected VT, but got I4
		//IL_2287: Expected VT, but got I4
		//IL_2297: Expected VT, but got I
		//IL_22df: Expected Obj, but got I
		//IL_22f7: Expected Obj, but got I
		//IL_190e: Expected Obj, but got I4
		//IL_1924: Expected Obj, but got I
		//IL_1944: Unknown result type (might be due to invalid IL or missing references)
		//IL_1949: Expected Obj, but got Unknown
		//IL_1959: Expected VT, but got I
		//IL_239e: Expected Obj, but got I4
		//IL_23d8: Expected VT, but got I4
		//IL_23eb: Expected VT, but got I4
		//IL_23f4: Expected VT, but got I4
		//IL_2404: Expected VT, but got I
		//IL_1820: Expected Obj, but got I
		//IL_1852: Expected VT, but got I4
		//IL_1865: Expected VT, but got I4
		//IL_186e: Expected VT, but got I4
		//IL_187e: Expected VT, but got I
		//IL_18c6: Expected Obj, but got I
		//IL_18de: Expected Obj, but got I
		//IL_0fd5: Expected I, but got Obj
		//IL_0fe5: Expected Obj, but got I
		//IL_0ff5: Expected Obj, but got I
		//IL_198d: Expected Obj, but got I4
		//IL_19c7: Expected VT, but got I4
		//IL_19da: Expected VT, but got I4
		//IL_19e3: Expected VT, but got I4
		//IL_19f3: Expected VT, but got I
		//IL_110a: Expected Obj, but got I8
		//IL_112a: Expected VT, but got I
		//IL_112f: Expected I, but got Obj
		//IL_246a: Expected I, but got Obj
		//IL_247a: Expected Obj, but got I
		//IL_248a: Expected Obj, but got I
		//IL_1039: Expected Obj, but got I
		//IL_106b: Expected VT, but got I4
		//IL_107e: Expected VT, but got I4
		//IL_1087: Expected VT, but got I4
		//IL_1098: Expected VT, but got I
		//IL_10a5: Expected I, but got Obj
		//IL_10e2: Expected Obj, but got I
		//IL_25b4: Expected Obj, but got I8
		//IL_25d3: Expected VT, but got I
		//IL_1a59: Expected I, but got Obj
		//IL_1a69: Expected Obj, but got I
		//IL_1a79: Expected Obj, but got I
		//IL_1170: Expected Obj, but got I4
		//IL_1192: Expected Obj, but got I
		//IL_11a3: Expected VT, but got I
		//IL_11a8: Expected I, but got Obj
		//IL_11b8: Expected Obj, but got I4
		//IL_24ce: Expected Obj, but got I
		//IL_2500: Expected VT, but got I4
		//IL_2513: Expected VT, but got I4
		//IL_251c: Expected VT, but got I4
		//IL_252c: Expected VT, but got I
		//IL_258c: Expected Obj, but got I
		//IL_1ba3: Expected Obj, but got I8
		//IL_1bc2: Expected VT, but got I
		//IL_346a: Expected I, but got Obj
		//IL_347a: Expected Obj, but got I
		//IL_25ff: Expected Obj, but got I4
		//IL_2621: Expected Obj, but got I
		//IL_2631: Expected VT, but got I
		//IL_2651: Expected Obj, but got I4
		//IL_1abd: Expected Obj, but got I
		//IL_1aef: Expected VT, but got I4
		//IL_1b02: Expected VT, but got I4
		//IL_1b0b: Expected VT, but got I4
		//IL_1b1b: Expected VT, but got I
		//IL_1b7b: Expected Obj, but got I
		//IL_1bf6: Expected Obj, but got I4
		//IL_1c18: Expected Obj, but got I
		//IL_1c28: Expected VT, but got I
		//IL_1c48: Expected Obj, but got I4
		Dictionary<uint, (System.__Canon, System.__Canon)>.Enumerator enumerator = default;
		object obj = (object)(&enumerator);
		_ = 0;
		_ = 0;
		obj = 0;
		bool flag = P_2 == (_003C_003Ec__DisplayClass16_0)(object)0;
		uint num = 0u;
		System.__Canon _Canon = null;
		(System.__Canon, System.__Canon) value = ((System.__Canon, System.__Canon))0;
		uint key = 0u;
		KeyValuePair<uint, (System.__Canon, System.__Canon)> keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
		KeyValuePair<uint, (System.__Canon, System.__Canon)> keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
		ref _003C_003Ec__DisplayClass16_0 reference = ref P_2;
		System.__Canon _Canon2 = (System.__Canon)(object)meta;
		Type type2;
		object obj6;
		uint num3;
		object obj9;
		nint num4;
		ref _003C_003Ec__DisplayClass16_0 reference2;
		System.__Canon _Canon3;
		(System.__Canon, System.__Canon) tuple;
		Dictionary<uint, (System.__Canon, System.__Canon)> dictionary2 = default;
		object obj22;
		NullReferenceException ex = default;
		object obj10 = default;
		nint num5 = default;
		uint num11;
		object obj23;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F78]");
			object obj2 = 0;
			_Canon2 = (System.__Canon)obj2;
			((HashSet<uint>)P_2).Clear();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
			bool flag2 = (nint)0 == 0;
			num = 0u;
			_Canon = null;
			value = ((System.__Canon, System.__Canon))0;
			key = 0u;
			keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
			keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
			reference = ref P_2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F18]");
				object obj3 = 0;
				_Canon2 = (System.__Canon)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
				((Dictionary<uint, (System.__Canon, System.__Canon)>)0).Clear();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+10]");
				bool flag3 = (nint)0 == 0;
				num = 0u;
				_Canon = null;
				value = ((System.__Canon, System.__Canon))0;
				key = 0u;
				keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
				keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
				reference = ref P_2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F10]");
					object obj4 = 0;
					_Canon2 = (System.__Canon)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+10]");
					((Dictionary<uint, System.__Canon>)0).Clear();
					bool flag4 = (object)type == null;
					num = 0u;
					_Canon = null;
					value = ((System.__Canon, System.__Canon))0;
					key = 0u;
					keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
					keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
					reference = ref P_2;
					if (!flag4)
					{
						nint num2 = (nint)type;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v28 (Il2CppClass<System.Type>)+7A8]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v28 (Il2CppClass<System.Type>)+7B0]");
						reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
						type2 = ((System.RuntimeType)type).MakeByRefType();
						bool flag5 = (object)type2 == null;
						num = 0u;
						_Canon = null;
						value = ((System.__Canon, System.__Canon))0;
						key = 0u;
						keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
						keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
						_Canon2 = (System.__Canon)62;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v47 (System.Type)+18]");
							bool flag6 = (nint)0 < (nint)1;
							_Canon2 = (System.__Canon)62;
							if (flag6)
							{
								goto IL_2656;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F08]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F98]");
							num3 = 0u;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v47 (System.Type)+18]");
							object obj7 = 0 & 0xFFFFFFFFL;
							object obj8 = type2 + 32;
							obj9 = obj10;
							num4 = num5;
							Dictionary<uint, (System.__Canon, System.__Canon)> dictionary = dictionary2;
							object obj12 = default;
							object obj11 = obj12;
							object obj14 = default;
							object obj13 = obj14;
							uint num7 = default;
							uint num6 = num7;
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v28 (Il2CppClass<System.Type>)+7B0]");
							reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v28 (Il2CppClass<System.Type>)+7A8]");
							object obj16 = 0;
							_Canon3 = (System.__Canon)62;
							System.__Canon _Canon5 = default;
							uint num13 = default;
							object obj30 = default;
							System.__Canon _Canon6 = default;
							uint num18 = default;
							object obj52 = default;
							System.__Canon _Canon7 = default;
							uint num22 = default;
							object obj75 = default;
							System.__Canon _Canon8 = default;
							object obj89 = default;
							while (true)
							{
								bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
								object obj17 = !flag7;
								if (obj17 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1558 @ X28_v2+v197 @ X29_v16*8]");
								System.__Canon _Canon4 = (System.__Canon)0;
								_Canon2 = (System.__Canon)obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
								object format;
								object[] args;
								if (_Canon5 != null)
								{
									num7 = ((uint*)(int)num3)->m_value;
									nint num8 = (nint)_Canon5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+130]");
									obj5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+130]");
									nint num9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1434 @ X10_v21 (System.UInt32)+130]");
									bool flag8 = num9 < 0;
									object obj18 = !flag8;
									object obj19 = ~obj18;
									if (obj19 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+B0]");
										obj11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+B0]");
										nint num10 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1434 @ X10_v21 (System.UInt32)+130]");
										object obj20 = num10 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X11_v28-8]");
										obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X11_v28-8]");
										if ((nint)0 == (int)num7)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
											num11 = 0u;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FC0]");
											object obj21 = 0;
											num5 = (nint)obj21;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1558 @ X28_v2+v197 @ X29_v16*8]");
											tuple = ((System.__Canon)0, _Canon5);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
											bool flag9 = (nint)0 == 0;
											num = 0u;
											_Canon = null;
											value = ((System.__Canon, System.__Canon))0;
											key = 0u;
											keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
											keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
											tuple = ((System.__Canon, System.__Canon))0;
											obj10 = obj9;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+B0]");
											obj12 = 0;
											obj22 = obj15;
											obj23 = obj6;
											reference = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1558 @ X28_v2+v197 @ X29_v16*8]");
											_Canon2 = (System.__Canon)0;
											if (flag9)
											{
												goto IL_31b2;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F38]");
											object obj24 = 0;
											obj9 = obj24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
											nint num12 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
											bool flag10 = ((Dictionary<uint, (System.__Canon, System.__Canon)>)num12).TryAdd(0u, ((System.__Canon, System.__Canon))0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F98]");
											num3 = 0u;
											bool flag11 = !flag10;
											object obj25 = !flag11;
											tuple = ((System.__Canon, System.__Canon))0;
											num4 = unchecked((nint)null);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
											dictionary = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X11_v28-8]");
											obj13 = 0;
											num6 = num7;
											reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+130]");
											obj16 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
											_Canon2 = (System.__Canon)0;
											if (obj25 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
												object obj26 = 0;
												object obj27 = obj26;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X8_v146+A0]");
												object obj28 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ X8_v147+18]");
												dictionary = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ X8_v147+18]");
												bool flag12 = (nint)0 == 0;
												tuple = ((System.__Canon, System.__Canon))0;
												num4 = unchecked((nint)null);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X11_v28-8]");
												obj13 = 0;
												num6 = num7;
												reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+130]");
												obj16 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
												_Canon2 = (System.__Canon)0;
												if (!flag12)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
													object obj29 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													obj5 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													bool flag13 = num13 == 0;
													num = 0u;
													_Canon = null;
													value = ((System.__Canon, System.__Canon))0;
													key = 0u;
													keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
													keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
													tuple = ((System.__Canon, System.__Canon))0;
													obj10 = obj24;
													num5 = unchecked((nint)null);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ X8_v147+18]");
													dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
													obj22 = obj15;
													num11 = num13;
													obj23 = obj6;
													reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
													_Canon2 = (System.__Canon)(&tuple);
													if (!flag13)
													{
														bool flag14 = obj30 == null;
														_Canon3 = (System.__Canon)(&tuple);
														if (!flag14)
														{
															uint value2 = ((uint*)(int)num13)->m_value;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X8_v165 (System.UInt32)+40]");
															_Canon3 = (System.__Canon)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag15 = ex == null;
															num = 0u;
															_Canon = null;
															value = ((System.__Canon, System.__Canon))0;
															key = 0u;
															keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															obj10 = obj24;
															num5 = unchecked((nint)null);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ X8_v147+18]");
															dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
															obj22 = obj15;
															num11 = num13;
															obj23 = obj30;
															reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X8_v165 (System.UInt32)+40]");
															_Canon2 = (System.__Canon)0;
															if (flag15)
															{
																goto IL_3222;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1792 @ X0_v177 (System.UInt32)+18]");
														bool flag16 = (nint)0 == 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														num4 = unchecked((nint)null);
														obj13 = obj14;
														num6 = num7;
														num3 = num13;
														obj6 = obj30;
														reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
														obj16 = obj5;
														if (flag16)
														{
															break;
														}
														object obj31 = num13 + 32;
														obj31 = obj30;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														uint value3 = ((uint*)(int)num13)->m_value;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v153 (System.UInt32)+40]");
														_Canon2 = (System.__Canon)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag17 = ex == null;
														num = 0u;
														_Canon = null;
														value = ((System.__Canon, System.__Canon))0;
														key = 0u;
														keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														obj10 = obj9;
														num5 = unchecked((nint)null);
														dictionary2 = dictionary;
														obj22 = obj15;
														num11 = num13;
														obj23 = obj30;
														reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
														if (flag17)
														{
															goto IL_3222;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F08]");
														obj6 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1792 @ X0_v177 (System.UInt32)+18]");
														object obj32 = 0 & 0xFFFFFFFEL;
														bool flag18 = obj32 == null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														num4 = unchecked((nint)null);
														obj13 = obj14;
														num6 = num7;
														num3 = num13;
														reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
														obj16 = obj5;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v153 (System.UInt32)+40]");
														_Canon3 = (System.__Canon)0;
														if (flag18)
														{
															break;
														}
														object obj33 = num13 + 40;
														obj33 = _Canon5;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														nint num14 = (nint)type;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1956 @ X8_v155 (Il2CppClass<System.Type>)+2D8]");
														obj5 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1956 @ X8_v155 (Il2CppClass<System.Type>)+2E0]");
														_Canon3 = (System.__Canon)0;
														Type[] genericArguments = ((System.RuntimeType)type).GetGenericArguments();
														if (genericArguments != null)
														{
															uint value4 = ((uint*)(int)num13)->m_value;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v164 (System.UInt32)+40]");
															_Canon3 = (System.__Canon)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag19 = ex == null;
															num = 0u;
															_Canon = null;
															value = ((System.__Canon, System.__Canon))0;
															key = 0u;
															keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															obj10 = obj9;
															num5 = unchecked((nint)null);
															dictionary2 = dictionary;
															obj22 = obj15;
															num11 = num13;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F08]");
															obj23 = 0;
															reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v164 (System.UInt32)+40]");
															_Canon2 = (System.__Canon)0;
															if (flag19)
															{
																goto IL_3222;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1792 @ X0_v177 (System.UInt32)+18]");
														bool flag20 = (nint)0 < (nint)2;
														object obj34 = !flag20;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1792 @ X0_v177 (System.UInt32)+18]");
														object obj35 = -2;
														bool flag21 = obj35 == null;
														object obj36 = ~obj34;
														object obj37 = obj36 | flag21;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														num4 = unchecked((nint)null);
														obj13 = obj14;
														num6 = num7;
														num3 = num13;
														reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
														obj16 = obj5;
														if (obj37 != null)
														{
															break;
														}
														object obj38 = num13 + 48;
														obj38 = genericArguments;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														bool flag22 = _Canon4 == null;
														num = 0u;
														_Canon = null;
														value = ((System.__Canon, System.__Canon))0;
														key = 0u;
														keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														obj10 = obj9;
														num5 = unchecked((nint)null);
														dictionary2 = dictionary;
														obj22 = obj15;
														num11 = num13;
														obj23 = obj6;
														reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
														_Canon2 = (System.__Canon)(object)genericArguments;
														if (!flag22)
														{
															nint num15 = (nint)_Canon4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X8_v158 (Il2CppClass<System.__Canon>)+1B8]");
															obj5 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X8_v158 (Il2CppClass<System.__Canon>)+1C0]");
															_Canon3 = (System.__Canon)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2002 @ X8_v158 (Il2CppClass<System.__Canon>)+1B8] (should have been resolved before IL gen)");
															if (_Canon6 != null)
															{
																uint value5 = ((uint*)(int)num13)->m_value;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v163 (System.UInt32)+40]");
																_Canon3 = (System.__Canon)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag23 = ex == null;
																num = 0u;
																_Canon = null;
																value = ((System.__Canon, System.__Canon))0;
																key = 0u;
																keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
																tuple = ((System.__Canon, System.__Canon))0;
																obj10 = obj9;
																num5 = unchecked((nint)null);
																dictionary2 = dictionary;
																_Canon4 = _Canon6;
																obj22 = obj15;
																num11 = num13;
																obj23 = obj6;
																reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v163 (System.UInt32)+40]");
																_Canon2 = (System.__Canon)0;
																if (flag23)
																{
																	goto IL_3222;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1792 @ X0_v177 (System.UInt32)+18]");
															object obj39 = 0 & 0xFFFFFFFCL;
															bool flag24 = obj39 == null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															num4 = unchecked((nint)null);
															obj13 = obj14;
															num6 = num7;
															num3 = num13;
															reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
															obj16 = obj5;
															if (flag24)
															{
																break;
															}
															object obj40 = num13 + 56;
															obj40 = _Canon6;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FD8]");
															format = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															num4 = unchecked((nint)null);
															_Canon4 = _Canon6;
															args = (object[])num13;
															goto IL_3451;
														}
													}
													goto IL_31b2;
												}
											}
											goto IL_33af;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FA0]");
									object obj41 = 0;
									num6 = (uint)(int)obj41;
									object obj42 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
									bool flag25 = (nint)obj42 < 0;
									object obj43 = !flag25;
									object obj44 = ~obj43;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+B0]");
										obj11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+B0]");
										nint num16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
										object obj45 = num16 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X11_v26-8]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X11_v26-8]");
										if ((nint)0 == (int)num6)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
											bool flag26 = (nint)0 == 0;
											obj16 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
											_Canon2 = (System.__Canon)0;
											if (!flag26)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+10]");
												bool flag27 = (nint)0 == 0;
												num = 0u;
												_Canon = null;
												value = ((System.__Canon, System.__Canon))0;
												key = 0u;
												keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
												keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
												obj10 = obj9;
												num5 = num4;
												dictionary2 = dictionary;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X11_v26-8]");
												obj14 = 0;
												num7 = num6;
												obj22 = obj15;
												num11 = num3;
												obj23 = obj6;
												reference = ref reference2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
												_Canon2 = (System.__Canon)0;
												if (flag27)
												{
													goto IL_31b2;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F30]");
												object obj46 = 0;
												num4 = (nint)obj46;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+10]");
												nint num17 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
												bool flag28 = ((Dictionary<uint, System.__Canon>)num17).TryAdd(0u, _Canon5);
												bool flag29 = !flag28;
												object obj47 = !flag29;
												reference2 = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
												obj16 = obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
												_Canon2 = (System.__Canon)0;
												if (obj47 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
													object obj48 = 0;
													object obj49 = obj48;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ X8_v120+A0]");
													object obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1485 @ X8_v121+18]");
													dictionary = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1485 @ X8_v121+18]");
													bool flag30 = (nint)0 == 0;
													reference2 = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
													obj16 = obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
													_Canon2 = (System.__Canon)0;
													if (!flag30)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
														object obj51 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
														obj5 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														bool flag31 = num18 == 0;
														num = 0u;
														_Canon = null;
														value = ((System.__Canon, System.__Canon))0;
														key = 0u;
														keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
														tuple = ((System.__Canon, System.__Canon))0;
														obj10 = obj9;
														num5 = (nint)obj46;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1485 @ X8_v121+18]");
														dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X11_v26-8]");
														obj14 = 0;
														num7 = num6;
														obj22 = obj15;
														num11 = num18;
														obj23 = obj6;
														reference = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
														_Canon2 = (System.__Canon)(&tuple);
														if (!flag31)
														{
															bool flag32 = obj52 == null;
															_Canon3 = (System.__Canon)(&tuple);
															if (!flag32)
															{
																uint value6 = ((uint*)(int)num18)->m_value;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v139 (System.UInt32)+40]");
																_Canon3 = (System.__Canon)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag33 = ex == null;
																num = 0u;
																_Canon = null;
																value = ((System.__Canon, System.__Canon))0;
																key = 0u;
																keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
																tuple = ((System.__Canon, System.__Canon))0;
																obj10 = obj9;
																num5 = (nint)obj46;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1485 @ X8_v121+18]");
																dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X11_v26-8]");
																obj14 = 0;
																num7 = num6;
																obj22 = obj15;
																num11 = num18;
																obj23 = obj52;
																reference = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v139 (System.UInt32)+40]");
																_Canon2 = (System.__Canon)0;
																if (flag33)
																{
																	goto IL_3222;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X0_v143 (System.UInt32)+18]");
															bool flag34 = (nint)0 == 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
															tuple = ((System.__Canon, System.__Canon))0;
															num3 = num18;
															obj6 = obj52;
															reference2 = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
															obj16 = obj5;
															if (flag34)
															{
																break;
															}
															object obj53 = num18 + 32;
															obj53 = obj52;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															uint value7 = ((uint*)(int)num18)->m_value;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v127 (System.UInt32)+40]");
															_Canon2 = (System.__Canon)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag35 = ex == null;
															num = 0u;
															_Canon = null;
															value = ((System.__Canon, System.__Canon))0;
															key = 0u;
															keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
															tuple = ((System.__Canon, System.__Canon))0;
															obj10 = obj9;
															num5 = num4;
															dictionary2 = dictionary;
															obj14 = obj13;
															num7 = num6;
															obj22 = obj15;
															num11 = num18;
															obj23 = obj52;
															reference = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
															if (flag35)
															{
																goto IL_3222;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F08]");
															obj6 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X0_v143 (System.UInt32)+18]");
															object obj54 = 0 & 0xFFFFFFFEL;
															bool flag36 = obj54 == null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
															tuple = ((System.__Canon, System.__Canon))0;
															num3 = num18;
															reference2 = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
															obj16 = obj5;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v127 (System.UInt32)+40]");
															_Canon3 = (System.__Canon)0;
															if (flag36)
															{
																break;
															}
															object obj55 = num18 + 40;
															obj55 = _Canon5;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															nint num19 = (nint)type;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1977 @ X8_v129 (Il2CppClass<System.Type>)+2D8]");
															obj5 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1977 @ X8_v129 (Il2CppClass<System.Type>)+2E0]");
															_Canon3 = (System.__Canon)0;
															Type[] genericArguments2 = ((System.RuntimeType)type).GetGenericArguments();
															if (genericArguments2 != null)
															{
																uint value8 = ((uint*)(int)num18)->m_value;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ X8_v138 (System.UInt32)+40]");
																_Canon3 = (System.__Canon)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag37 = ex == null;
																num = 0u;
																_Canon = null;
																value = ((System.__Canon, System.__Canon))0;
																key = 0u;
																keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
																tuple = ((System.__Canon, System.__Canon))0;
																obj10 = obj9;
																num5 = num4;
																dictionary2 = dictionary;
																obj14 = obj13;
																num7 = num6;
																obj22 = obj15;
																num11 = num18;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F08]");
																obj23 = 0;
																reference = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ X8_v138 (System.UInt32)+40]");
																_Canon2 = (System.__Canon)0;
																if (flag37)
																{
																	goto IL_3222;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X0_v143 (System.UInt32)+18]");
															bool flag38 = (nint)0 < (nint)2;
															object obj56 = !flag38;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X0_v143 (System.UInt32)+18]");
															object obj57 = -2;
															bool flag39 = obj57 == null;
															object obj58 = ~obj56;
															object obj59 = obj58 | flag39;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
															tuple = ((System.__Canon, System.__Canon))0;
															num3 = num18;
															reference2 = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
															obj16 = obj5;
															if (obj59 != null)
															{
																break;
															}
															object obj60 = num18 + 48;
															obj60 = genericArguments2;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															bool flag40 = _Canon4 == null;
															num = 0u;
															_Canon = null;
															value = ((System.__Canon, System.__Canon))0;
															key = 0u;
															keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
															tuple = ((System.__Canon, System.__Canon))0;
															obj10 = obj9;
															num5 = num4;
															dictionary2 = dictionary;
															obj14 = obj13;
															num7 = num6;
															obj22 = obj15;
															num11 = num18;
															obj23 = obj6;
															reference = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
															_Canon2 = (System.__Canon)(object)genericArguments2;
															if (!flag40)
															{
																nint num20 = (nint)_Canon4;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2011 @ X8_v132 (Il2CppClass<System.__Canon>)+1B8]");
																obj5 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2011 @ X8_v132 (Il2CppClass<System.__Canon>)+1C0]");
																_Canon3 = (System.__Canon)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2011 @ X8_v132 (Il2CppClass<System.__Canon>)+1B8] (should have been resolved before IL gen)");
																if (_Canon7 != null)
																{
																	uint value9 = ((uint*)(int)num18)->m_value;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v137 (System.UInt32)+40]");
																	_Canon3 = (System.__Canon)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																	bool flag41 = ex == null;
																	num = 0u;
																	_Canon = null;
																	value = ((System.__Canon, System.__Canon))0;
																	key = 0u;
																	keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																	keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
																	tuple = ((System.__Canon, System.__Canon))0;
																	obj10 = obj9;
																	num5 = num4;
																	dictionary2 = dictionary;
																	obj14 = obj13;
																	num7 = num6;
																	_Canon4 = _Canon7;
																	obj22 = obj15;
																	num11 = num18;
																	obj23 = obj6;
																	reference = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v137 (System.UInt32)+40]");
																	_Canon2 = (System.__Canon)0;
																	if (flag41)
																	{
																		goto IL_3222;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X0_v143 (System.UInt32)+18]");
																object obj61 = 0 & 0xFFFFFFFCL;
																bool flag42 = obj61 == null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
																tuple = ((System.__Canon, System.__Canon))0;
																num3 = num18;
																reference2 = ref *(_003C_003Ec__DisplayClass16_0*)_Canon5;
																obj16 = obj5;
																if (flag42)
																{
																	break;
																}
																object obj62 = num18 + 56;
																obj62 = _Canon7;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FF0]");
																format = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+24]");
																tuple = ((System.__Canon, System.__Canon))0;
																obj14 = obj13;
																num7 = num6;
																_Canon4 = _Canon7;
																args = (object[])num18;
																goto IL_3451;
															}
														}
														goto IL_31b2;
													}
												}
											}
											goto IL_33af;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F90]");
									object obj63 = 0;
									num6 = (uint)(int)obj63;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
									obj13 = 0;
									object obj64 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
									bool flag43 = (nint)obj64 < 0;
									object obj65 = !flag43;
									object obj66 = ~obj65;
									if (obj66 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v76 (Il2CppClass<System.__Canon>)+B0]");
										nint num21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
										object obj67 = num21 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ X8_v90-8]");
										if ((nint)0 == (int)num6)
										{
											bool flag44 = P_2 == (_003C_003Ec__DisplayClass16_0)(object)0;
											num = 0u;
											_Canon = null;
											value = ((System.__Canon, System.__Canon))0;
											key = 0u;
											keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
											keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
											obj10 = obj9;
											num5 = num4;
											dictionary2 = dictionary;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
											obj14 = 0;
											num7 = num6;
											obj22 = obj15;
											num11 = num3;
											obj23 = obj6;
											reference = ref reference2;
											if (flag44)
											{
												goto IL_31b2;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F70]");
											object obj68 = 0;
											reference2 = ref *(_003C_003Ec__DisplayClass16_0*)obj68;
											_003C_003Ec__DisplayClass16_0 obj69 = P_2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
											bool flag45 = ((HashSet<uint>)obj69).Add(0u);
											bool flag46 = !flag45;
											object obj70 = !flag46;
											obj16 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
											_Canon2 = (System.__Canon)0;
											if (obj70 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
												object obj71 = 0;
												object obj72 = obj71;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1798 @ X8_v96+A0]");
												object obj73 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X8_v97+18]");
												dictionary = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X8_v97+18]");
												bool flag47 = (nint)0 == 0;
												obj16 = obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
												_Canon2 = (System.__Canon)0;
												if (!flag47)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
													object obj74 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													obj5 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													bool flag48 = num22 == 0;
													num = 0u;
													_Canon = null;
													value = ((System.__Canon, System.__Canon))0;
													key = 0u;
													keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
													keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
													tuple = ((System.__Canon, System.__Canon))0;
													obj10 = obj9;
													num5 = num4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X8_v97+18]");
													dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
													obj14 = 0;
													num7 = num6;
													obj22 = obj15;
													num11 = num22;
													obj23 = obj6;
													reference = ref *(_003C_003Ec__DisplayClass16_0*)obj68;
													_Canon2 = (System.__Canon)(&tuple);
													if (!flag48)
													{
														bool flag49 = obj75 == null;
														_Canon3 = (System.__Canon)(&tuple);
														if (!flag49)
														{
															uint value10 = ((uint*)(int)num22)->m_value;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X8_v115 (System.UInt32)+40]");
															_Canon3 = (System.__Canon)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag50 = ex == null;
															num = 0u;
															_Canon = null;
															value = ((System.__Canon, System.__Canon))0;
															key = 0u;
															keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															obj10 = obj9;
															num5 = num4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X8_v97+18]");
															dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v15 (System.UInt32)+130]");
															obj14 = 0;
															num7 = num6;
															obj22 = obj15;
															num11 = num22;
															obj23 = obj75;
															reference = ref *(_003C_003Ec__DisplayClass16_0*)obj68;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X8_v115 (System.UInt32)+40]");
															_Canon2 = (System.__Canon)0;
															if (flag50)
															{
																goto IL_3222;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ X0_v110 (System.UInt32)+18]");
														bool flag51 = (nint)0 == 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														num3 = num22;
														obj6 = obj75;
														obj16 = obj5;
														if (flag51)
														{
															break;
														}
														object obj76 = num22 + 32;
														obj76 = obj75;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														uint value11 = ((uint*)(int)num22)->m_value;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v103 (System.UInt32)+40]");
														_Canon2 = (System.__Canon)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag52 = ex == null;
														num = 0u;
														_Canon = null;
														value = ((System.__Canon, System.__Canon))0;
														key = 0u;
														keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														obj10 = obj9;
														num5 = num4;
														dictionary2 = dictionary;
														obj14 = obj13;
														num7 = num6;
														obj22 = obj15;
														num11 = num22;
														obj23 = obj75;
														reference = ref reference2;
														if (flag52)
														{
															goto IL_3222;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F08]");
														obj6 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ X0_v110 (System.UInt32)+18]");
														object obj77 = 0 & 0xFFFFFFFEL;
														bool flag53 = obj77 == null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														num3 = num22;
														obj16 = obj5;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v103 (System.UInt32)+40]");
														_Canon3 = (System.__Canon)0;
														if (flag53)
														{
															break;
														}
														object obj78 = num22 + 40;
														obj78 = _Canon5;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														nint num23 = (nint)type;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1982 @ X8_v105 (Il2CppClass<System.Type>)+2D8]");
														obj5 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1982 @ X8_v105 (Il2CppClass<System.Type>)+2E0]");
														_Canon3 = (System.__Canon)0;
														Type[] genericArguments3 = ((System.RuntimeType)type).GetGenericArguments();
														if (genericArguments3 != null)
														{
															uint value12 = ((uint*)(int)num22)->m_value;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v114 (System.UInt32)+40]");
															_Canon3 = (System.__Canon)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag54 = ex == null;
															num = 0u;
															_Canon = null;
															value = ((System.__Canon, System.__Canon))0;
															key = 0u;
															keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															obj10 = obj9;
															num5 = num4;
															dictionary2 = dictionary;
															obj14 = obj13;
															num7 = num6;
															obj22 = obj15;
															num11 = num22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F08]");
															obj23 = 0;
															reference = ref reference2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v114 (System.UInt32)+40]");
															_Canon2 = (System.__Canon)0;
															if (flag54)
															{
																goto IL_3222;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ X0_v110 (System.UInt32)+18]");
														bool flag55 = (nint)0 < (nint)2;
														object obj79 = !flag55;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ X0_v110 (System.UInt32)+18]");
														object obj80 = -2;
														bool flag56 = obj80 == null;
														object obj81 = ~obj79;
														object obj82 = obj81 | flag56;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														num3 = num22;
														obj16 = obj5;
														if (obj82 != null)
														{
															break;
														}
														object obj83 = num22 + 48;
														obj83 = genericArguments3;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														bool flag57 = _Canon4 == null;
														num = 0u;
														_Canon = null;
														value = ((System.__Canon, System.__Canon))0;
														key = 0u;
														keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
														tuple = ((System.__Canon, System.__Canon))0;
														obj10 = obj9;
														num5 = num4;
														dictionary2 = dictionary;
														obj14 = obj13;
														num7 = num6;
														obj22 = obj15;
														num11 = num22;
														obj23 = obj6;
														reference = ref reference2;
														_Canon2 = (System.__Canon)(object)genericArguments3;
														if (!flag57)
														{
															nint num24 = (nint)_Canon4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2016 @ X8_v108 (Il2CppClass<System.__Canon>)+1B8]");
															obj5 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2016 @ X8_v108 (Il2CppClass<System.__Canon>)+1C0]");
															_Canon3 = (System.__Canon)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2016 @ X8_v108 (Il2CppClass<System.__Canon>)+1B8] (should have been resolved before IL gen)");
															if (_Canon8 != null)
															{
																uint value13 = ((uint*)(int)num22)->m_value;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v113 (System.UInt32)+40]");
																_Canon3 = (System.__Canon)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag58 = ex == null;
																num = 0u;
																_Canon = null;
																value = ((System.__Canon, System.__Canon))0;
																key = 0u;
																keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
																tuple = ((System.__Canon, System.__Canon))0;
																obj10 = obj9;
																num5 = num4;
																dictionary2 = dictionary;
																obj14 = obj13;
																num7 = num6;
																_Canon4 = _Canon8;
																obj22 = obj15;
																num11 = num22;
																obj23 = obj6;
																reference = ref reference2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v113 (System.UInt32)+40]");
																_Canon2 = (System.__Canon)0;
																if (flag58)
																{
																	goto IL_3222;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ X0_v110 (System.UInt32)+18]");
															object obj84 = 0 & 0xFFFFFFFCL;
															bool flag59 = obj84 == null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															num3 = num22;
															obj16 = obj5;
															if (flag59)
															{
																break;
															}
															object obj85 = num22 + 56;
															obj85 = _Canon8;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FC8]");
															format = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v94 (System.__Canon)+10]");
															tuple = ((System.__Canon, System.__Canon))0;
															obj14 = obj13;
															num7 = num6;
															_Canon4 = _Canon8;
															args = (object[])num22;
															goto IL_3451;
														}
													}
													goto IL_31b2;
												}
											}
											goto IL_33af;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
									object obj86 = 0;
									object obj87 = obj86;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1720 @ X8_v82+A0]");
									object obj88 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v83+18]");
									dictionary = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v83+18]");
									bool flag60 = (nint)0 == 0;
									obj16 = obj5;
									if (!flag60)
									{
										bool flag61 = _Canon4 == null;
										num = 0u;
										_Canon = null;
										value = ((System.__Canon, System.__Canon))0;
										key = 0u;
										keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
										keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
										obj10 = obj9;
										num5 = num4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v83+18]");
										dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)0;
										obj14 = obj13;
										num7 = num6;
										obj22 = obj15;
										num11 = num3;
										obj23 = obj6;
										reference = ref reference2;
										if (flag61)
										{
											goto IL_31b2;
										}
										nint num25 = (nint)_Canon4;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1748 @ X8_v84 (Il2CppClass<System.__Canon>)+1B8] (should have been resolved before IL gen)");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FD0]");
										object format2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FE8]");
										object arg = 0;
										string text = string.Format((string)format2, arg, _Canon5, obj89);
										nint num26 = (nint)dictionary;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X8_v88 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>>)+198]");
										obj16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X8_v88 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>>)+1A0]");
										reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v83+18]");
										int writeTimeout = ((Stream)0).WriteTimeout;
										obj9 = 0;
										num4 = (nint)obj89;
										_Canon2 = (System.__Canon)(object)text;
									}
								}
								goto IL_33af;
								IL_3451:
								string text2 = string.Format((string)format, args);
								nint num27 = (nint)dictionary;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X8_v78 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>>)+198]");
								obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X8_v78 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>>)+1A0]");
								reference2 = ref *(_003C_003Ec__DisplayClass16_0*)null;
								int writeTimeout2 = ((Stream)(object)dictionary).WriteTimeout;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F98]");
								num3 = 0u;
								obj13 = obj14;
								num6 = num7;
								_Canon2 = (System.__Canon)(object)text2;
								goto IL_33af;
								IL_33af:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v47 (System.Type)+18]");
								obj7 = 0;
								obj22 = obj15 + 1;
								object obj90 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v47 (System.Type)+18]");
								bool flag62 = (nint)obj90 < 0;
								obj10 = obj9;
								num5 = num4;
								dictionary2 = dictionary;
								obj12 = obj11;
								obj14 = obj13;
								num7 = num6;
								num11 = num3;
								obj23 = obj6;
								reference = ref reference2;
								obj5 = obj16;
								obj15 = obj22;
								_Canon3 = _Canon2;
								if (flag62)
								{
									continue;
								}
								goto IL_2656;
							}
							IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
							num = 0u;
							_Canon = null;
							value = ((System.__Canon, System.__Canon))0;
							key = 0u;
							keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
							keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
							goto IL_3174;
						}
					}
				}
			}
		}
		goto IL_31b2;
		IL_2656:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
		bool flag63 = (nint)0 == 0;
		num = 0u;
		_Canon = null;
		value = ((System.__Canon, System.__Canon))0;
		key = 0u;
		keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
		keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
		object obj94;
		object obj95;
		Dictionary<uint, (System.__Canon, System.__Canon)> dictionary4;
		if (!flag63)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F40]");
			object obj91 = 0;
			_Canon2 = (System.__Canon)obj91;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
			int count = ((Dictionary<uint, (System.__Canon, System.__Canon)>)0).Count;
			object obj92 = count - 1;
			bool flag64 = obj92 == null;
			if (count < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
			bool flag65 = (nint)0 == 0;
			num = 0u;
			_Canon = null;
			value = ((System.__Canon, System.__Canon))0;
			key = 0u;
			keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
			keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
			if (!flag65)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F50]");
				num3 = 0u;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F88]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+8]");
				Dictionary<uint, (System.__Canon, System.__Canon)>.Enumerator enumerator2 = ((Dictionary<uint, (System.__Canon, System.__Canon)>)0).GetEnumerator();
				object obj93 = (object)(&enumerator);
				Dictionary<uint, (System.__Canon, System.__Canon)> dictionary3 = (Dictionary<uint, (System.__Canon, System.__Canon)>)(&enumerator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X8_v37+30]");
				keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X8_v37+40]");
				KeyValuePair<uint, (System.__Canon, System.__Canon)> keyValuePair3 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X8_v37+50]");
				(System.__Canon, System.__Canon) tuple2 = ((System.__Canon, System.__Canon))0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X8_v37+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X8_v37+30]");
				obj93 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X8_v37+40]");
				_ = 0;
				num = 0u;
				_Canon = null;
				value = ((System.__Canon, System.__Canon))0;
				key = 0u;
				keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
				Type type3 = type2;
				object arg2 = default;
				object obj104 = default;
				while (true)
				{
					if (enumerator.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X25_v18 (System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
						keyValuePair2 = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
						num4 = (nint)obj6;
						keyValuePair.Deconstruct(out key, out value);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+10]");
						bool flag66 = (nint)0 == 0;
						obj94 = 0;
						obj95 = 0;
						dictionary4 = (Dictionary<uint, (System.__Canon, System.__Canon)>)(&enumerator);
						obj9 = obj10;
						Dictionary<uint, (System.__Canon, System.__Canon)> dictionary = (Dictionary<uint, (System.__Canon, System.__Canon)>)(&enumerator);
						object obj15 = (object)(&num);
						reference2 = ref *(_003C_003Ec__DisplayClass16_0*)(&value);
						_Canon3 = (System.__Canon)(&key);
						if (flag66)
						{
							break;
						}
						GenericRpcInvoker genericRpcInvoker = null;
						num5 = (nint)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass16_0&)+10]");
						if (((Dictionary<uint, System.__Canon>)0).Remove(key, out _Canon))
						{
							goto IL_2939;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
						object obj96 = 0;
						object obj97 = obj96;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ X8_v42+A0]");
						object obj98 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ X8_v43+18]");
						type3 = (Type)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ X8_v43+18]");
						bool flag67 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X25_v18 (System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
						keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
						reference = ref *(_003C_003Ec__DisplayClass16_0*)(&_Canon);
						if (!flag67)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj99 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5FE0]");
							object format3 = 0;
							string text3 = string.Format((string)format3, arg2);
							nint num28 = (nint)type3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v48 (Il2CppClass<System.Type>)+198]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v48 (Il2CppClass<System.Type>)+1A0]");
							reference = ref *(_003C_003Ec__DisplayClass16_0*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ X8_v43+18]");
							Type underlyingSystemType = ((System.RuntimeType)0).UnderlyingSystemType;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X25_v18 (System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
							keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
							tuple = ((System.__Canon, System.__Canon))key;
						}
						continue;
					}
					obj94 = 0;
					obj95 = 0;
					Dictionary<uint, (System.__Canon, System.__Canon)>.Enumerator enumerator3 = (Dictionary<uint, (System.__Canon, System.__Canon)>.Enumerator)(&enumerator);
					dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)(&enumerator);
					obj22 = (object)(&num);
					object obj100 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5F48]");
						object obj101 = 0;
						_Canon2 = (System.__Canon)obj101;
						((Dictionary<uint, (System.__Canon, System.__Canon)>.Enumerator*)enumerator3)->Dispose();
						bool flag68 = obj100 == null;
						object obj102 = !flag68;
						num11 = num3;
						obj23 = obj6;
						if (obj102 == null)
						{
							bool flag69 = obj94 == null;
							object obj103 = !flag69;
							num11 = num3;
							obj23 = obj6;
							OutOfMemoryException ex3 = (OutOfMemoryException)enumerator3;
							if (obj103 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)_Canon2 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj94 = 1;
							num3 = num11;
							obj6 = obj23;
							obj100 = obj95;
							continue;
						}
						if ((nint)_Canon2 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj100 = obj104;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj95 = obj104;
						num3 = num11;
						obj6 = obj23;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A46D8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				goto IL_3174;
			}
		}
		goto IL_31b2;
		IL_2939:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X25_v18 (System.Collections.Generic.Dictionary`2<System.UInt32, System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
		keyValuePair = (KeyValuePair<uint, (System.__Canon, System.__Canon)>)0;
		obj94 = 0;
		obj95 = 0;
		dictionary4 = (Dictionary<uint, (System.__Canon, System.__Canon)>)(&enumerator);
		dictionary2 = (Dictionary<uint, (System.__Canon, System.__Canon)>)(&enumerator);
		obj22 = (object)(&num);
		num11 = num3;
		obj23 = obj6;
		reference = ref *(_003C_003Ec__DisplayClass16_0*)(&_Canon);
		_Canon2 = (System.__Canon)key;
		goto IL_31ce;
		IL_3222:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		_Canon2 = null;
		throw new ArgumentNullException();
		IL_31ce:
		NullReferenceException ex4 = new NullReferenceException();
		NullReferenceException ex5 = new NullReferenceException();
		NullReferenceException ex6 = new NullReferenceException();
		NullReferenceException ex7 = new NullReferenceException();
		NullReferenceException ex8 = new NullReferenceException();
		ex = new NullReferenceException();
		goto IL_3222;
		IL_31b2:
		NullReferenceException ex9 = new NullReferenceException();
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_31ce;
		IL_3174:
		NullReferenceException ex11 = new NullReferenceException();
		obj10 = obj9;
		num5 = num4;
		num11 = num3;
		obj23 = obj6;
		reference = ref reference2;
		_Canon2 = _Canon3;
		goto IL_31b2;
	}

	internal unsafe static int _003CAddStruct_003Eg__GetWordCount_007C21_0(Type t, ref SimulationBehaviourUpdater._003C_003Ec__DisplayClass21_0 P_1)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0302: Expected I4, but got Obj
		//IL_0057: Expected Obj, but got VT
		//IL_0065: Invalid comparison between VT and I4
		//IL_0089: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got VT
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected I4, but got Unknown
		//IL_00dc: Expected Obj, but got VT
		//IL_00e9: Expected Obj, but got VT
		//IL_00f7: Invalid comparison between VT and I4
		//IL_017f: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I8
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I4
		//IL_022d: Expected VT, but got Obj
		//IL_0256: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0339: Expected Obj, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_02c3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6040]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37681E4");
		object obj2 = default;
		int result;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+10]");
			result = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+14]");
			if ((nint)0 == 0)
			{
				goto IL_02e1;
			}
			object obj3 = P_1;
			if (P_1 != (SimulationBehaviourUpdater._003C_003Ec__DisplayClass21_0)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6050]");
				object format = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6048]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X8_v7+3B8] (should have been resolved before IL gen)");
				System.__Canon _Canon = (System.__Canon)P_1;
				object obj6 = default;
				bool condition = (byte)(obj6 & 1) != 0;
				Assert.Always(condition, (string)format, (System.__Canon)P_1);
				object obj7 = P_1;
				if (P_1 != (SimulationBehaviourUpdater._003C_003Ec__DisplayClass21_0)(object)0)
				{
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+460]");
					ref SimulationBehaviourUpdater._003C_003Ec__DisplayClass21_0 reference = ref *(SimulationBehaviourUpdater._003C_003Ec__DisplayClass21_0*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ X8_v8+458] (should have been resolved before IL gen)");
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+18]");
						if ((nint)0 < (nint)1)
						{
							goto IL_02e1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DF8]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+18]");
						object obj12 = 0 & 0xFFFFFFFFL;
						object obj13 = obj9 + 32;
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+10]");
						int num = 0;
						while (true)
						{
							bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
							object obj15 = !flag;
							if (obj15 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v6+E8]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v16+E4]");
							bool flag2 = (nint)0 == 0;
							object obj17 = !flag2;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj10);
							if ((object)typeFromHandle != null)
							{
								nint num2 = (nint)typeFromHandle;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v13 (Il2CppClass<System.Type>)+2A0]");
								_Canon = (System.__Canon)0;
								Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
								object obj18 = elementType & 1;
								bool flag3 = obj18 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v5+v71 @ X24_v6*8]");
								reference = ref *(SimulationBehaviourUpdater._003C_003Ec__DisplayClass21_0*)null;
								if (!flag3)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v5+v71 @ X24_v6*8]");
									int num3 = _003CAddStruct_003Eg__GetWordCount_007C21_0((Type)0, ref P_1);
									num = num3 + num;
									reference = ref P_1;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+18]");
								obj12 = 0;
								obj14++;
								object obj19 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+18]");
								bool flag4 = (nint)obj19 < 0;
								result = num;
								if (flag4)
								{
									continue;
								}
								goto IL_02e1;
							}
							goto IL_02e6;
						}
						goto IL_02f4;
					}
				}
			}
		}
		goto IL_02e6;
		IL_02f4:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_02e1:
		return result;
		IL_02e6:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02f4;
	}
}
