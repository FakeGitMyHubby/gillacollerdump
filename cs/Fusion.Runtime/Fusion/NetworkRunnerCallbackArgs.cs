using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public static class NetworkRunnerCallbackArgs
{
	public struct Awaiter : _0021_00210
	{
		[Serializable]
		public struct SerializableSimulationBehaviourMeta
		{
			public SerializableType<SimulationBehaviour> Type;

			public int ExecutionOrder;
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Action continuation;

			public SendOrPostCallback _003C_003E9__1;

			internal void _003COnCompleted_003Eb__1(object _)
			{
				// ILSpy could not decompile this. Please report the exception below,
				// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
				// System.IndexOutOfRangeException: Index was outside the bounds of the array.
				//    at ICSharpCode.Decompiler.Util.BitSet.get_Item(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 65
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 567
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
				//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
			}
		}

		private NetworkSpawnOp _op;

		public unsafe bool IsCompleted
		{
			get
			{
				//IL_011f: Expected Obj, but got Ref
				//IL_0023: Expected Obj, but got I
				//IL_0058: Expected Obj, but got I
				//IL_0091: Expected Obj, but got I4
				//IL_00c3: Expected Obj, but got I
				//IL_00e0: Expected Obj, but got I
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				if (obj != null)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj3 = 0;
					object obj4 = obj2;
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X11_v3+130]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v5+130]");
					bool flag = num < 0;
					object obj6 = !flag;
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
						object obj7 = (nint)0 + (nint)16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X11_v3+B0]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v5+130]");
						object obj8 = num2 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X11_v5-8]");
						if (0 == (nint)obj5)
						{
							obj = obj7;
						}
						bool flag2 = obj == null;
						return !flag2;
					}
				}
				return false;
			}
		}

		public Awaiter([In] ref NetworkSpawnOp op)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
			_ = 0;
			_op = op;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public unsafe NetworkObject GetResult()
		{
			//IL_03d6: Expected Obj, but got I4
			//IL_0427: Expected Obj, but got Ref
			//IL_042f: Expected I4, but got Obj
			//IL_043f: Expected Obj, but got I
			//IL_0459: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			//IL_00a5: Expected Obj, but got I
			//IL_0047: Expected Obj, but got I
			//IL_0395: Expected VT, but got I4
			//IL_040e: Expected Obj, but got I4
			//IL_04d3: Expected Obj, but got I
			//IL_00da: Expected Obj, but got I
			//IL_0113: Expected Obj, but got I4
			//IL_0145: Expected Obj, but got I
			//IL_0162: Expected Obj, but got I
			//IL_04be: Expected I4, but got Obj
			//IL_020a: Expected Obj, but got I
			//IL_021a: Expected I, but got Obj
			//IL_022a: Expected Obj, but got I
			//IL_0253: Expected Obj, but got I4
			//IL_02bb: Expected Obj, but got I
			//IL_02e4: Expected Obj, but got I4
			//IL_01c0: Expected I, but got Obj
			//IL_01d0: Expected Obj, but got I
			//IL_0287: Expected Obj, but got I
			//IL_0318: Expected Obj, but got I
			bool isCompleted = IsCompleted;
			bool flag = !isCompleted;
			object obj = !flag;
			if (obj == null)
			{
				bool isCompleted2 = IsCompleted;
				bool flag2 = !isCompleted2;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B30]");
					object obj3 = 0;
					SpinWait spinWait = default;
					do
					{
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v35+E4]");
						bool flag3 = (nint)0 == 0;
						object obj5 = !flag3;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						spinWait.SpinOnce();
					}
					while (!IsCompleted);
				}
			}
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			NetworkSpawnStatus networkSpawnStatus = (NetworkSpawnStatus)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B38]");
			object obj7 = 0;
			bool flag4 = obj6 == null;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj10 = 0;
					object obj11 = obj9;
					object obj12 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X12_v8+130]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X11_v12+130]");
					bool flag5 = num < 0;
					object obj13 = !flag5;
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
						object obj14 = (nint)0 + (nint)16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X12_v8+B0]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X11_v12+130]");
						object obj15 = num2 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X12_v10-8]");
						if (0 == (nint)obj12)
						{
							obj6 = obj14;
						}
						networkSpawnStatus = (NetworkSpawnStatus)obj6;
						goto IL_0467;
					}
				}
				networkSpawnStatus = (NetworkSpawnStatus)0;
			}
			goto IL_0467;
			IL_02ab:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7970]");
			object obj16 = 0;
			string text = (string)obj16;
			object obj18;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X1_v3 (System.String)+130]");
			bool flag6 = (nint)obj17 < 0;
			object obj19 = !flag6;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v13 (Il2CppClass<Fusion.NetworkObject>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X1_v3 (System.String)+130]");
				object obj21 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v16-8]");
				if (0 == (nint)text)
				{
					goto IL_033f;
				}
			}
			networkSpawnStatus = (NetworkSpawnStatus)109899776;
			throw new InvalidCastException();
			IL_033f:
			NetworkObject networkObject;
			return networkObject;
			IL_0467:
			bool flag7 = networkSpawnStatus == 0;
			text = (string)obj7;
			bool condition = !flag7;
			Assert.Check(condition, (string)obj7);
			if (networkSpawnStatus != (NetworkSpawnStatus)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				NetworkObjectSpawnException ex = default;
				ex._002Ector(networkSpawnStatus, (NetworkObjectTypeId?)(object)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				return (NetworkObject)(object)new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
			networkObject = (NetworkObject)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+8]");
			if ((nint)0 != 0)
			{
				if ((object)networkObject != null)
				{
					nint num4 = (nint)networkObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v13 (Il2CppClass<Fusion.NetworkObject>)+130]");
					obj18 = 0;
					goto IL_02ab;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj22 = 0;
					object obj23 = obj22;
					nint num4 = (nint)networkObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v13 (Il2CppClass<Fusion.NetworkObject>)+130]");
					obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v13 (Il2CppClass<Fusion.NetworkObject>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v8+130]");
					bool flag8 = num5 < 0;
					object obj24 = !flag8;
					object obj25 = ~obj24;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v13 (Il2CppClass<Fusion.NetworkObject>)+B0]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v8+130]");
						object obj26 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X11_v6-8]");
						if (0 == (nint)obj23)
						{
							networkObject = (NetworkObject)(object)((MonoBehaviour)networkObject).m_CancellationTokenSource;
							goto IL_033f;
						}
					}
					goto IL_02ab;
				}
			}
			goto IL_033f;
		}

		public void OnCompleted(Action continuation)
		{
			//IL_0010: Expected Obj, but got I
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_00d8: Expected Obj, but got I
			//IL_0115: Expected Obj, but got I
			//IL_011d: Expected I, but got Obj
			//IL_014e: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got I
			//IL_00ae: Expected Obj, but got I
			//IL_00be: Expected Obj, but got I
			//IL_018a: Expected Obj, but got I
			//IL_01c9: Expected Obj, but got I
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected Obj, but got Unknown
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected Obj, but got Unknown
			//IL_0261: Expected Obj, but got I
			//IL_0280: Expected Obj, but got I
			//IL_0291: Expected I, but got Obj
			//IL_02a6: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B48]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			bool flag = obj2 == null;
			Action action = null;
			if (!flag)
			{
				object obj3 = obj2 + 16;
				obj3 = continuation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (IsCompleted)
				{
					object obj4 = obj3;
					bool flag2 = obj3 == null;
					action = continuation;
					if (flag2)
					{
						goto IL_02ac;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v14+40]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v14+28]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v14+18]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v162 @ X2_v2 (should have been resolved before IL gen)");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
				NetworkSpawnOp.AsyncOpData asyncOpData = (NetworkSpawnOp.AsyncOpData)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
				bool flag3 = (nint)0 == 0;
				action = continuation;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj8 = 0;
					nint num = (nint)asyncOpData;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X9_v3 (Il2CppClass<Fusion.NetworkSpawnOp+AsyncOpData>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v7+130]");
					bool flag4 = num2 < 0;
					object obj10 = !flag4;
					object obj11 = ~obj10;
					action = continuation;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X9_v3 (Il2CppClass<Fusion.NetworkSpawnOp+AsyncOpData>)+B0]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v7+130]");
						object obj12 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v5-8]");
						bool flag5 = 0 != (nint)obj9;
						action = continuation;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B58]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							object obj14 = default;
							obj14._002Ector();
							bool flag6 = obj14 == null;
							action = null;
							if (!flag6)
							{
								object obj15 = obj14 + 24;
								obj15 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								SynchronizationContext current = SynchronizationContext.Current;
								object obj16 = obj14 + 16;
								obj16 = current;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B50]");
								object obj18 = 0;
								Action action2 = default;
								action2._002Ector(obj14, (IntPtr)obj18);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerCallbackArgs+Awaiter)+10]");
								((NetworkSpawnOp.AsyncOpData)0).Completed += action2;
								return;
							}
							goto IL_02ac;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				NotSupportedException ex = default;
				ex._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			goto IL_02ac;
			IL_02ac:
			throw new NullReferenceException();
		}
	}
}
