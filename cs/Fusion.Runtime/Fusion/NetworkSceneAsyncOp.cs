using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Fusion;

public struct NetworkSceneAsyncOp : Action<UpdatePlayerCustomPropertiesResult>
{
	private sealed class _003C_003Ec__DisplayClass5_1
	{
		public SynchronizationContext capturedContext;

		public Awaiter._003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

		internal void _003COnCompleted_003Eb__0(NetworkSceneAsyncOp _)
		{
			//IL_00b1: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I
			//IL_00e6: Expected Obj, but got I
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_0097: Expected I, but got Obj
			//IL_004b: Expected Obj, but got I
			//IL_0065: Expected Obj, but got I
			//IL_0076: Expected I, but got Obj
			SendOrPostCallback sendOrPostCallback = default;
			while (true)
			{
				SynchronizationContext synchronizationContext = capturedContext;
				object obj = CS_0024_003C_003E8__locals1;
				if (capturedContext != null)
				{
					object obj2 = obj + 24;
					bool flag = obj2 == null;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B68]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F08]");
						object obj5 = 0;
						sendOrPostCallback._002Ector(obj, (IntPtr)obj5);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					nint num = (nint)synchronizationContext;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v72 @ X8_v6 (Il2CppClass<System.Threading.SynchronizationContext>)+188] (should have been resolved before IL gen)");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (System.Object)+10]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+40]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v89 @ X2_v1 (should have been resolved before IL gen)");
			}
		}
	}

	public struct Awaiter : Action<UpdateInventoryItemsResponse>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<NetworkRunner> _003C_003E9__11_0;

			static _003C_003Ec()
			{
				//IL_0010: Expected Obj, but got I
				//IL_0041: Expected Obj, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9CA8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj2 = default;
				obj2._002Ector();
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
				object obj4 = 0;
				obj4 = obj2;
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}

			internal bool _003CInvokeRender_003Eb__11_0(NetworkRunner x)
			{
				//IL_004f: Expected Obj, but got I
				//IL_0079: Expected Obj, but got I4
				//IL_002c: Expected Obj, but got I4
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Expected I4, but got Unknown
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = x;
				object obj4 = !flag2;
				return (byte)(1 & obj4) != 0;
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Action continuation;

			public SendOrPostCallback _003C_003E9__1;

			internal void _003COnCompleted_003Eb__1(object __)
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

		private NetworkSceneAsyncOp _op;

		public bool IsCompleted => IsDone;

		public unsafe Awaiter([In] ref NetworkSceneAsyncOp op)
		{
			//IL_000b: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			_op = op;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public void GetResult()
		{
			//IL_00c8: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			//IL_0047: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I4
			//IL_008f: Expected I, but got Obj
			bool isDone = IsDone;
			bool flag = !isDone;
			object obj = !flag;
			if (obj == null)
			{
				bool isDone2 = IsDone;
				bool flag2 = !isDone2;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B30]");
					object obj3 = 0;
					IntPtr intPtr = default;
					nint num = intPtr;
					SpinWait spinWait = default;
					bool flag4;
					do
					{
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v9+E4]");
						bool flag3 = (nint)0 == 0;
						object obj5 = !flag3;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						spinWait.SpinOnce();
						bool isDone3 = IsDone;
						flag4 = !isDone3;
						num = unchecked((nint)null);
					}
					while (flag4);
				}
			}
			ThrowIfError();
		}

		public void OnCompleted(Action continuation)
		{
			//IL_0010: Expected Obj, but got I
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_00b8: Expected Obj, but got I
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected Obj, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected Obj, but got Unknown
			//IL_012e: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I
			//IL_008e: Expected Obj, but got I
			//IL_009e: Expected Obj, but got I
			//IL_014d: Expected Obj, but got I
			//IL_015e: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EF0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj2 + 16;
			obj3 = continuation;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (IsDone)
			{
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v10+40]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v10+28]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v10+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v84 @ X2_v2 (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F00]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj9 = default;
			obj9._002Ector();
			object obj10 = obj9 + 24;
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			SynchronizationContext current = SynchronizationContext.Current;
			object obj11 = obj9 + 16;
			obj11 = current;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7ED8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EF8]");
			object obj13 = 0;
			Action<NetworkSceneAsyncOp> action = default;
			action._002Ector(obj9, (IntPtr)obj13);
			AddOnCompleted(action);
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public Action<NetworkSceneAsyncOp> action;

		public NetworkSceneAsyncOp captured;

		internal void _003CAddOnCompleted_003Eb__0(AsyncOperation _)
		{
			//IL_001f: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I
			Action<NetworkSceneAsyncOp> action = this.action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+40]");
			object obj = 0;
			NetworkSceneAsyncOp networkSceneAsyncOp = captured;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkSceneAsyncOp+<>c__DisplayClass18_0)+20]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void _003CAddOnCompleted_003Eb__1(IAsyncOperation _)
		{
			//IL_001f: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I
			Action<NetworkSceneAsyncOp> action = this.action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+40]");
			object obj = 0;
			NetworkSceneAsyncOp networkSceneAsyncOp = captured;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkSceneAsyncOp+<>c__DisplayClass18_0)+20]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void _003CAddOnCompleted_003Eb__2(Task _)
		{
			//IL_001f: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I
			Action<NetworkSceneAsyncOp> action = this.action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+40]");
			object obj = 0;
			NetworkSceneAsyncOp networkSceneAsyncOp = captured;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkSceneAsyncOp+<>c__DisplayClass18_0)+20]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (System.Action`1<Fusion.NetworkSceneAsyncOp>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public readonly SceneRef SceneRef;

	private readonly object _data;

	public bool IsValid
	{
		get
		{
			//IL_0010: Expected VT, but got I4
			return SceneRef != (SceneRef)0;
		}
	}

	public bool IsDone
	{
		get
		{
			//IL_0319: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			//IL_001d: Expected I, but got Obj
			//IL_004e: Expected Obj, but got I4
			//IL_022a: Expected Obj, but got I
			//IL_023a: Expected Obj, but got I
			//IL_00ca: Expected Obj, but got I4
			//IL_0082: Expected Obj, but got I
			//IL_0374: Expected Obj, but got I
			//IL_0275: Expected Obj, but got I
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected Obj, but got Unknown
			//IL_010f: Expected Obj, but got I
			//IL_0117: Expected I, but got Obj
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected Obj, but got Unknown
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected Obj, but got Unknown
			//IL_0143: Expected Obj, but got I
			//IL_0174: Expected Obj, but got I4
			//IL_01a8: Expected Obj, but got I
			AsyncOperation asyncOperation = (AsyncOperation)_data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E60]");
			object obj = 0;
			object obj9;
			if (_data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E50]");
				object obj2 = 0;
				nint num = (nint)asyncOperation;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X10_v11 (Il2CppClass<UnityEngine.AsyncOperation>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v11+130]");
				bool flag = num2 < 0;
				object obj4 = !flag;
				object obj5 = ~obj4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X10_v11 (Il2CppClass<UnityEngine.AsyncOperation>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v11+130]");
					object obj6 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X10_v15-8]");
					if (0 == (nint)obj3)
					{
						return ((AsyncOperation)_data).isDone;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				object obj7 = default;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				obj9 = obj7;
				if (obj8 != null)
				{
					goto IL_0212;
				}
				if (_data != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3E00]");
					object obj10 = 0;
					nint num4 = (nint)asyncOperation;
					if (asyncOperation != obj10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11 (Il2CppClass<UnityEngine.AsyncOperation>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X9_v15+130]");
						bool flag3 = num5 < 0;
						object obj13 = !flag3;
						object obj14 = ~obj13;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11 (Il2CppClass<UnityEngine.AsyncOperation>)+B0]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X9_v15+130]");
							object obj15 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13-8]");
							if (0 == (nint)obj12)
							{
								return ((Task)_data).IsCompleted;
							}
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				object obj16 = default;
				bool flag4 = obj16 == null;
				obj9 = obj16;
				if (!flag4)
				{
					goto IL_0212;
				}
			}
			return true;
			IL_0212:
			object obj17 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E58]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02b6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+98]");
			object obj20 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X10_v9-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj19--;
				obj20 += 16;
				if ((nint)obj19 != 1)
				{
					continue;
				}
				goto IL_02b6;
			}
			object obj21 = obj17 + obj20;
			object obj22 = obj21 + 312;
			goto IL_035c;
			IL_035c:
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v5+8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v225 @ X2_v2 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_02b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_035c;
		}
	}

	public Exception Error
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_003d: Expected Obj, but got I
			//IL_00f7: Expected Obj, but got I
			//IL_0107: Expected I, but got Obj
			//IL_0130: Expected Obj, but got I4
			//IL_0198: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I
			//IL_020b: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got I
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Expected Obj, but got Unknown
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Expected Obj, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected Obj, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E60]");
			object obj = 0;
			Task task = (Task)_data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj2 = default;
			if (obj2 != null)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E58]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00b9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+98]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X10_v13-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj5--;
					obj6 += 16;
					if ((nint)obj5 != 1)
					{
						continue;
					}
					goto IL_00b9;
				}
				object obj7 = obj6 + 3;
				object obj8 = obj3 + obj7;
				object obj9 = obj8 + 312;
				goto IL_0279;
			}
			if (_data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
				object obj10 = 0;
				object obj11 = obj10;
				nint num = (nint)task;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7 (Il2CppClass<System.Threading.Tasks.Task>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v3+130]");
				bool flag = num2 < 0;
				object obj12 = !flag;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7 (Il2CppClass<System.Threading.Tasks.Task>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v3+130]");
					object obj14 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v5-8]");
					if (0 == (nint)obj11)
					{
						return ((Task)_data).Exception;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3E00]");
				object obj15 = 0;
				if (num == (nint)obj15)
				{
					return (Exception)task.m_taskId;
				}
			}
			return null;
			IL_0279:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X0_v9] (should have been resolved before IL gen)");
			Exception ex = default;
			if (ex != null)
			{
				return (Exception)(object)ex._className;
			}
			return ex;
			IL_00b9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0279;
		}
	}

	private object System_002ECollections_002EIEnumerator_002ECurrent => null;

	private unsafe NetworkSceneAsyncOp(SceneRef sceneRef, object data)
	{
		//IL_0032: Expected Obj, but got Ref
		SceneRef = sceneRef;
		if (data != null)
		{
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj = data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}

	private unsafe NetworkSceneAsyncOp(SceneRef sceneRef)
	{
		//IL_0015: Expected Obj, but got Ref
		//IL_001e: Expected Obj, but got I4
		SceneRef = sceneRef;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal void ThrowIfError()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_02a8: Expected Obj, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E60]");
		object obj = 0;
		Task task = (Task)_data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj2 = default;
		object obj4;
		if (obj2 != null)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E58]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v15+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v15+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v15+98]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X10_v14-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj5--;
				obj6 += 16;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_00b9;
			}
			object obj7 = obj6 + 3;
			object obj8 = obj3 + obj7;
			object obj9 = obj8 + 312;
			goto IL_03bc;
		}
		if (_data == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3E00]");
		object obj10 = 0;
		nint num = (nint)task;
		if (task != obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v9 (Il2CppClass<System.Threading.Tasks.Task>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v6+130]");
			bool flag = num2 < 0;
			object obj13 = !flag;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v9 (Il2CppClass<System.Threading.Tasks.Task>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v6+130]");
				object obj15 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v11-8]");
				if (0 == (nint)obj12 && ((Task)_data).IsFaulted)
				{
					TaskAwaiter awaiter = ((Task)_data).GetAwaiter();
					TaskAwaiter taskAwaiter = default;
					taskAwaiter.GetResult();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E68]");
					object error = 0;
					Assert.AlwaysFail((string)error);
				}
			}
			return;
		}
		ExceptionDispatchInfo exceptionDispatchInfo = (ExceptionDispatchInfo)_data;
		goto IL_0330;
		IL_02e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		object obj16 = 3;
		goto IL_0407;
		IL_0330:
		exceptionDispatchInfo.Throw();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E68]");
		object error2 = 0;
		Assert.AlwaysFail((string)error2);
		return;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj16 = 3;
		goto IL_03bc;
		IL_0407:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v17] (should have been resolved before IL gen)");
		goto IL_0330;
		IL_03bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v278 @ X0_v14] (should have been resolved before IL gen)");
		object obj17 = default;
		if (obj17 == null)
		{
			return;
		}
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v18+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v18+98]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X10_v9-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj19--;
			obj20 += 16;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_02e9;
		}
		object obj21 = obj20 + 3;
		object obj22 = obj18 + obj21;
		object obj23 = obj22 + 312;
		goto IL_0407;
	}

	public static NetworkSceneAsyncOp FromAsyncOperation(SceneRef sceneRef, AsyncOperation asyncOp)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected VT, but got Unknown
		//IL_0046: Expected VT, but got I4
		//IL_0098: Expected VT, but got Obj
		if (asyncOp != null)
		{
			SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
			NetworkSceneAsyncOp networkSceneAsyncOp = new NetworkSceneAsyncOp(sceneRef2, asyncOp);
			return (NetworkSceneAsyncOp)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkSceneAsyncOp)ex2;
	}

	public static NetworkSceneAsyncOp FromCoroutine(SceneRef sceneRef, ICoroutine coroutine)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected VT, but got Unknown
		//IL_0046: Expected VT, but got I4
		//IL_0098: Expected VT, but got Obj
		if ((object)coroutine != null)
		{
			SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
			NetworkSceneAsyncOp networkSceneAsyncOp = new NetworkSceneAsyncOp(sceneRef2, coroutine);
			return (NetworkSceneAsyncOp)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkSceneAsyncOp)ex2;
	}

	public static NetworkSceneAsyncOp FromTask(SceneRef sceneRef, Task task)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected VT, but got Unknown
		//IL_0046: Expected VT, but got I4
		//IL_0098: Expected VT, but got Obj
		if (task != null)
		{
			SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
			NetworkSceneAsyncOp networkSceneAsyncOp = new NetworkSceneAsyncOp(sceneRef2, task);
			return (NetworkSceneAsyncOp)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkSceneAsyncOp)ex2;
	}

	public static NetworkSceneAsyncOp FromError(SceneRef sceneRef, Exception error)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected VT, but got Unknown
		//IL_0058: Expected VT, but got I4
		//IL_00aa: Expected VT, but got Obj
		if (error != null)
		{
			ExceptionDispatchInfo exceptionDispatchInfo = ExceptionDispatchInfo.Capture(error);
			SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
			NetworkSceneAsyncOp networkSceneAsyncOp = new NetworkSceneAsyncOp(sceneRef2, exceptionDispatchInfo);
			return (NetworkSceneAsyncOp)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkSceneAsyncOp)ex2;
	}

	public unsafe static NetworkSceneAsyncOp FromCompleted(SceneRef sceneRef)
	{
		//IL_000e: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (NetworkSceneAsyncOp)sceneRef;
	}

	internal static NetworkSceneAsyncOp FromDeferred(SceneRef sceneRef, Task blockingTask, NetworkRunner runner, Func<NetworkRunner, SceneRef, NetworkSceneAsyncOp> op)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected VT, but got Unknown
		SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
		Task task = CreateDeferredOpTask(sceneRef2, blockingTask, runner, op);
		SceneRef sceneRef3 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
		return FromTask(sceneRef3, task);
	}

	private unsafe static Task CreateDeferredOpTask(SceneRef sceneRef, Task blockingTask, NetworkRunner runner, Func<NetworkRunner, SceneRef, NetworkSceneAsyncOp> op)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected VT, but got Unknown
		//IL_0151: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EB0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EB8]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 56;
			obj8 = blockingTask;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 64;
			obj9 = runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj3 + 72;
			obj10 = op;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj11 = obj3 + 24;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35014A8");
			object obj12 = default;
			if (obj12 != null)
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj12 + 24);
				return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Task;
			}
		}
		return (Task)(object)new NullReferenceException();
	}

	public void AddOnCompleted(Action<NetworkSceneAsyncOp> action)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_009a: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_01a5: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_028c: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_0380: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I
		//IL_03d0: Expected I, but got Obj
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EC0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = obj2 + 16;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj3 + 16;
		_ = SceneRef;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		AsyncOperation asyncOperation = (AsyncOperation)_data;
		if (_data != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E50]");
			object obj5 = 0;
			nint num = (nint)asyncOperation;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X9_v15 (Il2CppClass<UnityEngine.AsyncOperation>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v23+130]");
			bool flag = num2 < 0;
			object obj7 = !flag;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X9_v15 (Il2CppClass<UnityEngine.AsyncOperation>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v23+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X9_v17-8]");
				if (0 == (nint)obj6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9ED0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9ED8]");
					object obj11 = 0;
					Action<System.__Canon> action2 = default;
					action2._002Ector(obj2, (IntPtr)obj11);
					((AsyncOperation)_data).completed += (Action<AsyncOperation>)action2;
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj13 = default;
		object obj17 = default;
		object obj19 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EC8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EE0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E58]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action3 = default;
			action3._002Ector(obj2, (IntPtr)obj15);
			obj17 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18+12E]");
			if ((nint)0 == 0)
			{
				goto IL_023e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18+98]");
			obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X10_v12-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj18--;
				obj19 += 16;
				if ((nint)obj18 != 1)
				{
					continue;
				}
				goto IL_023e;
			}
			goto IL_0317;
		}
		if (_data != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
			object obj20 = 0;
			object obj21 = obj20;
			nint num4 = (nint)asyncOperation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v11 (Il2CppClass<UnityEngine.AsyncOperation>)+130]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X9_v4+130]");
			bool flag2 = num5 < 0;
			object obj22 = !flag2;
			object obj23 = ~obj22;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v11 (Il2CppClass<UnityEngine.AsyncOperation>)+B0]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X9_v4+130]");
				object obj24 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v6-8]");
				if (0 == (nint)obj21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8670]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9EE8]");
					object obj26 = 0;
					Action<System.__Canon> action4 = default;
					action4._002Ector(obj2, (IntPtr)obj26);
					Task task = ((Task)_data).ContinueWith((Action<Task>)action4);
					return;
				}
			}
		}
		goto IL_042f;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0425;
		IL_0425:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v401 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_042f;
		IL_042f:
		object obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v108 @ X8_v8+18] (should have been resolved before IL gen)");
		goto IL_0317;
		IL_0317:
		object obj28 = obj19 + 1;
		object obj29 = obj17 + obj28;
		object obj30 = obj29 + 312;
		goto IL_0425;
	}

	public unsafe Awaiter GetAwaiter()
	{
		//IL_000e: Expected Obj, but got I
		object obj2 = default;
		object obj = (nint)(&obj2) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (Awaiter)SceneRef;
	}

	private bool System_002ECollections_002EIEnumerator_002EMoveNext()
	{
		//IL_0015: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		bool isDone = IsDone;
		object obj = !isDone;
		return (byte)(1 & obj) != 0;
	}

	private void System_002ECollections_002EIEnumerator_002EReset()
	{
	}
}
