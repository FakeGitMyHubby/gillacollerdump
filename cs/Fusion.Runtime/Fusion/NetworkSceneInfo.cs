using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.SceneManagement;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 192)]
public struct NetworkSceneInfo : _0021_00210, Action<UpdateUserTitleDisplayNameResult>
{
	private sealed class _003CCreateDeferredOpTask_003Ed__17 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SceneRef sceneRef;

		public Task blockingTask;

		public NetworkRunner runner;

		public Func<NetworkRunner, SceneRef, NetworkSceneAsyncOp> op;

		private TaskAwaiter _003C_003Eu__1;

		private NetworkSceneAsyncOp.Awaiter _003C_003Eu__2;

		private unsafe void MoveNext()
		{
			//IL_0765: Expected Obj, but got I
			//IL_0775: Expected Obj, but got I
			//IL_006b: Expected VT, but got I4
			//IL_007a: Expected I4, but got I8
			//IL_01f4: Expected Obj, but got I
			//IL_0204: Expected Obj, but got I
			//IL_0220: Expected I, but got Obj
			//IL_00a1: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I
			//IL_023e: Expected Obj, but got I
			//IL_0259: Expected Obj, but got I
			//IL_003c: Expected VT, but got I4
			//IL_0051: Expected I4, but got I8
			//IL_02fd: Expected Obj, but got I
			//IL_0315: Expected Obj, but got I
			//IL_027f: Expected Obj, but got I
			//IL_05b6: Expected Obj, but got I
			//IL_00e6: Expected Obj, but got I
			//IL_0101: Expected Obj, but got I
			//IL_038e: Expected Obj, but got I
			//IL_039e: Expected Obj, but got I
			//IL_034a: Expected Obj, but got VT
			//IL_034f: Expected I, but got Obj
			//IL_0127: Expected Obj, but got I
			//IL_07f3: Expected I4, but got I8
			//IL_0815: Expected Obj, but got I4
			//IL_0484: Unknown result type (might be due to invalid IL or missing references)
			//IL_0489: Expected Obj, but got Unknown
			//IL_04bd: Expected Obj, but got I4
			//IL_02cc: Expected Obj, but got I
			//IL_02e8: Expected I, but got Obj
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Expected VT, but got Unknown
			//IL_0464: Expected Ref, but got VT
			//IL_03d3: Expected Obj, but got I
			//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Expected VT, but got Unknown
			//IL_04f7: Expected Ref, but got VT
			//IL_0502: Unknown result type (might be due to invalid IL or missing references)
			//IL_0507: Expected Obj, but got Unknown
			//IL_050f: Expected Obj, but got VT
			//IL_0549: Expected Obj, but got I4
			//IL_0174: Expected Obj, but got I
			//IL_0190: Expected I, but got Obj
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Expected VT, but got Unknown
			//IL_0583: Expected Ref, but got VT
			//IL_0408: Expected Obj, but got I
			//IL_041a: Expected I, but got Obj
			//IL_0432: Expected Obj, but got I
			//IL_0633: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Expected Obj, but got Unknown
			//IL_0710: Expected Obj, but got I4
			//IL_065e: Expected Obj, but got I4
			//IL_0666: Expected Obj, but got Ref
			//IL_0684: Expected I4, but got I8
			//IL_06b5: Expected Obj, but got I4
			//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dd: Expected VT, but got Unknown
			//IL_06ea: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj2 = 0;
			NetworkSceneAsyncOp.Awaiter awaiter2;
			TaskAwaiter awaiter4 = default;
			System.__Canon stateMachine = default;
			object obj9;
			nint num = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					NetworkSceneAsyncOp.Awaiter awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = (NetworkSceneAsyncOp.Awaiter)0;
					_ = 0;
					_003C_003E1__state = -1;
					awaiter2 = _003C_003Eu__2;
					goto IL_036d;
				}
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v42+A0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v43+58]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v43+58]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EB0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F30]");
					object format = 0;
					object obj7 = default;
					string text = string.Format((string)format, obj7);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v10+10]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v10+10]");
					bool flag = (nint)0 == 0;
					string text2 = text;
					obj9 = obj7;
					if (flag)
					{
						goto IL_05c9;
					}
					object obj10 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v53+190]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ X8_v53+188] (should have been resolved before IL gen)");
					text2 = text;
					num = (nint)runner;
				}
				if (blockingTask == null)
				{
					goto IL_05a5;
				}
				TaskAwaiter awaiter3 = blockingTask.GetAwaiter();
				if (!awaiter4.IsCompleted)
				{
					object obj12 = this + 80;
					obj12 = awaiter4;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj13 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v71+E4]");
					bool flag2 = (nint)0 == 0;
					object obj14 = !flag2;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter4, ref stateMachine);
					return;
				}
			}
			else
			{
				_003C_003Eu__1 = (TaskAwaiter)0;
				_003C_003E1__state = -1;
				awaiter4 = _003C_003Eu__1;
			}
			awaiter4.GetResult();
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v27+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v28+58]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v28+58]");
			bool flag3 = (nint)0 == 0;
			num = unchecked((nint)null);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EB0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F20]");
				object format2 = 0;
				object obj19 = default;
				string text3 = string.Format((string)format2, obj19);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X23_v9+10]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X23_v9+10]");
				bool flag4 = (nint)0 == 0;
				string text2 = text3;
				obj9 = obj19;
				if (flag4)
				{
					goto IL_05bb;
				}
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v40+190]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X8_v40+188] (should have been resolved before IL gen)");
				text2 = text3;
				num = (nint)runner;
			}
			Func<NetworkRunner, SceneRef, NetworkSceneAsyncOp> func = op;
			if (op != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v30 (System.Func`3<Fusion.NetworkRunner, Fusion.SceneRef, Fusion.NetworkSceneAsyncOp>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X8_v30 (System.Func`3<Fusion.NetworkRunner, Fusion.SceneRef, Fusion.NetworkSceneAsyncOp>)+18] (should have been resolved before IL gen)");
				NetworkSceneAsyncOp.Awaiter awaiter5 = default;
				object obj22 = (nint)(&awaiter5) | (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				NetworkSceneAsyncOp awaiter6 = default;
				bool isDone = awaiter6.IsDone;
				bool flag5 = !isDone;
				string text2 = (string)sceneRef;
				num = unchecked((nint)null);
				awaiter2 = (NetworkSceneAsyncOp.Awaiter)awaiter6;
				NetworkSceneAsyncOp.Awaiter awaiter = awaiter5;
				if (!flag5)
				{
					goto IL_036d;
				}
				_003C_003E1__state = 1;
				_003C_003Eu__2 = (NetworkSceneAsyncOp.Awaiter)awaiter6;
				object obj23 = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj24 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v53+E4]");
				bool flag6 = (nint)0 == 0;
				object obj25 = !flag6;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(this + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->AwaitOnCompleted<NetworkSceneAsyncOp.Awaiter, System.__Canon>(ref *(NetworkSceneAsyncOp.Awaiter*)(&awaiter6), ref stateMachine);
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0597;
			IL_05c9:
			NullReferenceException ex2 = new NullReferenceException();
			bool flag7 = (nint)obj9 != 1;
			NullReferenceException ex3 = ex2;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj27 = default;
				object obj26 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj29 = default;
				object obj28 = obj29 & 1;
				if (obj28 != null)
				{
					object obj30 = 0;
					object obj32 = default;
					object obj31 = (object)(&obj32);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v21+E4]");
					bool flag8 = (nint)0 == 0;
					object obj33 = !flag8;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetException((Exception)obj27);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj34 = obj27;
				obj9 = 101789696 + 1224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				string text2 = null;
				NullReferenceException ex4 = default;
				ex3 = ex4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_05bb:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_05c9;
			IL_036d:
			awaiter2.GetResult();
			object obj35 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v17+A0]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v18+58]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v18+58]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v19+10]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v19+10]");
				if ((nint)0 == 0)
				{
					goto IL_0597;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F28]");
				object obj39 = 0;
				object obj40 = obj38;
				num = (nint)runner;
				string text2 = (string)obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X9_v8+190]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v284 @ X9_v8+188] (should have been resolved before IL gen)");
			}
			object obj41 = obj2;
			_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v35+E4]");
			bool flag9 = (nint)0 == 0;
			object obj42 = !flag9;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder4 = (AsyncTaskMethodBuilder)(this + 24);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder4)->SetResult();
			return;
			IL_05a5:
			NullReferenceException ex6 = new NullReferenceException();
			obj9 = num;
			goto IL_05bb;
			IL_0597:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_05a5;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private class DebuggerProxy
	{
		private readonly SceneRef[] Scenes__BackingField;

		private readonly NetworkLoadSceneParameters[] SceneParams__BackingField;

		private readonly int Version__BackingField;

		public SceneRef[] Scenes => Scenes__BackingField;

		public NetworkLoadSceneParameters[] SceneParams => SceneParams__BackingField;

		public int Version => Version__BackingField;

		public unsafe DebuggerProxy(NetworkSceneInfo sceneInfo)
		{
			//IL_0083: Expected Ref, but got VT
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected Obj, but got Unknown
			//IL_0010: Expected Ref, but got VT
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_0056: Expected Obj, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected I4, but got Unknown
			ReadOnlySpan<SceneRef> scenes = ((NetworkSceneInfo*)sceneInfo)->Scenes;
			ReadOnlySpan<SceneRef> readOnlySpan = default;
			SceneRef[] array = readOnlySpan.ToArray();
			object obj = this + 16;
			obj = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			ReadOnlySpan<NetworkLoadSceneParameters> sceneParams = ((NetworkSceneInfo*)sceneInfo)->SceneParams;
			ReadOnlySpan<NetworkLoadSceneParameters> readOnlySpan2 = default;
			NetworkLoadSceneParameters[] array2 = readOnlySpan2.ToArray();
			object obj2 = this + 24;
			obj2 = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Version__BackingField = (object)((int)sceneInfo._flags >> 5) & 0xFFFF;
			base._002Ector();
		}
	}

	[StructLayout((LayoutKind)0, Size = 62)]
	public struct _003C_sceneLoadMeta_003Ee__FixedBuffer
	{
		public ushort FixedElementField;
	}

	public const int MaxScenes = default(int);

	internal const int SceneCountBits = default(int);

	internal const int VersionBits = default(int);

	[FieldOffset(0)]
	private NetworkSceneInfoDefaultFlags _flags;

	[FieldOffset(4)]
	private Simulation.AreaOfInterest._003C_sceneRef_003Ee__FixedBuffer _sceneRef;

	[FieldOffset(128)]
	private _003C_sceneLoadMeta_003Ee__FixedBuffer _sceneLoadMeta;

	[FieldOffset(190)]
	private ushort _padding;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF__FLAGS = default(int);

	internal const int BYTE_COUNT_OF__FLAGS = default(int);

	internal const int BYTE_OF__SCENE_REF = default(int);

	internal const int BYTE_COUNT_OF__SCENE_REF = default(int);

	internal const int BYTE_OF__SCENE_LOAD_META = default(int);

	internal const int BYTE_COUNT_OF__SCENE_LOAD_META = default(int);

	internal const int BYTE_OF__PADDING = default(int);

	internal const int BYTE_COUNT_OF__PADDING = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public unsafe ReadOnlySpan<SceneRef> Scenes
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00be: Expected VT, but got Ref
			//IL_00cc: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F50]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F58]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+38]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v5+38]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			ReadOnlySpan<uint> span = (ReadOnlySpan<uint>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			return (ReadOnlySpan<SceneRef>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));
		}
	}

	public unsafe ReadOnlySpan<NetworkLoadSceneParameters> SceneParams
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00be: Expected VT, but got Ref
			//IL_00cc: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F68]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+38]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v5+38]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			ReadOnlySpan<ushort> span = (ReadOnlySpan<ushort>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 128));
			return (ReadOnlySpan<NetworkLoadSceneParameters>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));
		}
	}

	public int SceneCount
	{
		get
		{
			return (int)(_flags & (NetworkSceneInfoDefaultFlags)0x1Fu);
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
			_flags = _flags;
		}
	}

	public int Version
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)_flags >> 5;
			return obj & 0xFFFF;
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			_flags = _flags;
		}
	}

	public int IndexOf(SceneRef sceneRef, NetworkLoadSceneParameters sceneParams)
	{
		//IL_00fb: Invalid comparison between VT and I4
		//IL_00cb: Expected I4, but got I8
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected VT, but got Unknown
		//IL_013b: Expected VT, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_00de: Expected I4, but got Obj
		ReadOnlySpan<SceneRef> scenes = Scenes;
		ReadOnlySpan<NetworkLoadSceneParameters> sceneParams2 = SceneParams;
		if (sceneRef < (object)1)
		{
			goto IL_00be;
		}
		object obj = sceneParams & 0xFFFF;
		object obj2 = sceneRef & 0xFFFFFFFFL;
		object obj3 = sceneRef & 0xFFFFFFFFL;
		int num = 0;
		while (true)
		{
			SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.ReadOnlySpan`1<Fusion.SceneRef>)+v143 @ X21_v2 (System.Int32)*4]");
			if ((SceneRef)0 == sceneRef2)
			{
				bool flag = num < (nint)obj2;
				object obj4 = !flag;
				if (obj4 != null)
				{
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					return (int)ex;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5 (System.ReadOnlySpan`1<Fusion.NetworkLoadSceneParameters>)+v143 @ X21_v2 (System.Int32)*2]");
				if (0 == (nint)obj)
				{
					break;
				}
			}
			num++;
			if ((nint)obj3 != num)
			{
				continue;
			}
			goto IL_00be;
		}
		goto IL_010f;
		IL_010f:
		return num;
		IL_00be:
		num = -1;
		goto IL_010f;
	}

	public int IndexOf((SceneRef, NetworkLoadSceneParameters) scene)
	{
		//IL_000e: Expected Obj, but got VT
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected VT, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected VT, but got Unknown
		object obj = scene >> 32;
		NetworkLoadSceneParameters sceneParams = (NetworkLoadSceneParameters)(obj & 0xFFFF);
		SceneRef sceneRef = (SceneRef)(scene & 0xFFFFFFFFL);
		return IndexOf(sceneRef, sceneParams);
	}

	public int AddSceneRef(SceneRef sceneRef, LoadSceneMode loadSceneMode = default(LoadSceneMode), LocalPhysicsMode localPhysicsMode = default(LocalPhysicsMode), bool activeOnLoad = default(bool))
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_002c: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected I4, but got Unknown
		//IL_004c: Expected Obj, but got I4
		bool flag = !activeOnLoad;
		SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = ((obj2 != null) ? ((object)0) : ((object)8));
		bool flag2 = loadSceneMode == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		NetworkLoadSceneParametersFlags flags = (NetworkLoadSceneParametersFlags)((flag2 | obj3) ? 1 : 0);
		return AddSceneRef(sceneRef2, flags);
	}

	internal int AddSceneRef(SceneRef sceneRef, NetworkLoadSceneParametersFlags flags)
	{
		//IL_0010: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got I8
		//IL_030f: Expected Obj, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0348: Expected I4, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_02dc: Expected I4, but got I8
		//IL_0203: Expected Obj, but got I4
		//IL_0211: Expected I8, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0264: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		//IL_029f: Expected I8, but got Obj
		//IL_02c0: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F78]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F88]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+38]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		object obj8 = obj6;
		object obj9 = flags & (NetworkLoadSceneParametersFlags)0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F80]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+38]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8+38]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		NetworkSceneInfoDefaultFlags networkSceneInfoDefaultFlags = _flags;
		ref byte b = ref System.Runtime.CompilerServices.Unsafe.As<NetworkSceneInfo, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
		ref byte b2 = ref System.Runtime.CompilerServices.Unsafe.As<NetworkSceneInfo, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 128));
		object obj14 = obj9 & 1;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9FB0]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v13+20]");
			object obj17 = (nint)0 + (nint)309;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9FA8]");
			object obj18 = 0;
			object obj19 = obj17 & 1;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj21 = networkSceneInfoDefaultFlags & (NetworkSceneInfoDefaultFlags)0x1Fu;
			ulong byteLength = (ulong)(obj21 << 2);
			System.SpanHelpers.ClearWithoutReferences(ref b, byteLength);
			object obj22 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v16+20]");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag6 = obj24 == null;
			object obj25 = !flag6;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj26 = _flags & (NetworkSceneInfoDefaultFlags)0x1Fu;
			ulong byteLength2 = (ulong)(obj26 << 1);
			System.SpanHelpers.ClearWithoutReferences(ref b2, byteLength2);
			networkSceneInfoDefaultFlags = (_flags = (NetworkSceneInfoDefaultFlags)((int)_flags & 0xFFFFFFE0L));
		}
		int num = (int)(networkSceneInfoDefaultFlags & (NetworkSceneInfoDefaultFlags)0x1Fu);
		if (num == 31)
		{
			num = -1;
		}
		else
		{
			object obj27 = obj9 << 8;
			object obj28 = (int)networkSceneInfoDefaultFlags & 0xFFE00000L;
			object obj29 = networkSceneInfoDefaultFlags + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
			object obj30 = obj29 & 0x1FFFE0;
			NetworkSceneInfoDefaultFlags flags2 = (NetworkSceneInfoDefaultFlags)(obj28 | obj30);
			_flags = flags2;
		}
		return num;
	}

	public unsafe bool RemoveSceneRef(SceneRef sceneRef)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got Ref
		//IL_015c: Expected Obj, but got Ref
		//IL_0167: Expected Obj, but got Ref
		//IL_0170: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I4
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected VT, but got Unknown
		//IL_037d: Expected VT, but got I
		//IL_0391: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0272: Expected Obj, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01c1: Expected Obj, but got I4
		//IL_030e: Expected I4, but got Obj
		//IL_0233: Expected Obj, but got Ref
		//IL_0296: Expected Obj, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F78]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F88]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+38]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F80]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+38]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+38]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		object obj13 = _flags & (NetworkSceneInfoDefaultFlags)0x1Fu;
		if (obj13 != null)
		{
			object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 128));
			object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			object obj17 = -130;
			object obj18 = 0;
			object obj22;
			object obj28 = default;
			object obj29 = default;
			object obj30 = default;
			do
			{
				SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X24_v7-4]");
				bool flag5 = (SceneRef)0 == sceneRef2;
				object obj19 = _flags & (NetworkSceneInfoDefaultFlags)0x1Fu;
				bool flag6 = !flag5;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					obj18++;
					obj16 += 4;
					obj17 -= 2;
					bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
					object obj21 = !flag7;
					obj22 = ~obj21;
					continue;
				}
				object obj23 = obj18 + 1;
				bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
				object obj24 = !flag8;
				object obj25 = obj19 - 1;
				if (obj24 == null)
				{
					object obj26 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkSceneInfo, byte>(ref this)) - (ref *(byte*)obj17);
					object obj27 = obj25;
					obj27 = obj28;
					obj26 = obj29;
					obj16 = obj30;
					do
					{
						obj27--;
						obj16 += 4;
						obj26 += 2;
					}
					while (obj18 != obj27);
				}
				bool flag9 = (nint)obj25 < 31;
				object obj31 = !flag9;
				if (obj31 == null)
				{
					_ = 0;
					object obj32 = _flags & (NetworkSceneInfoDefaultFlags)0x1Fu;
					object obj33 = obj32 - 1;
					bool flag10 = (nint)obj33 < 31;
					object obj34 = !flag10;
					if (obj34 == null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
						_flags = _flags;
						return true;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (byte)(int)ex != 0;
			}
			while (obj22 != null);
		}
		return false;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected VT, but got Unknown
		//IL_0160: Expected Ref, but got VT
		//IL_01b3: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object value2;
		if (stringBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9FB8]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
			value2 = 0;
			StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
			object obj2 = _flags & (NetworkSceneInfoDefaultFlags)0x1Fu;
			if (obj2 == null)
			{
				goto IL_0338;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9FC0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F40]");
			object obj7 = 0;
			object obj8 = 0;
			object obj9 = 0;
			object obj10 = 0;
			object obj13 = default;
			object value4 = default;
			while (true)
			{
				if (obj8 != null)
				{
					StringBuilder stringBuilder3 = stringBuilder.Append((string)obj6);
				}
				StringBuilder stringBuilder4 = stringBuilder.Append((string)obj3);
				ReadOnlySpan<SceneRef> scenes = Scenes;
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj11 = !flag;
				if (obj11 != null)
				{
					break;
				}
				SceneRef sceneRef = (SceneRef)(scenes + obj9);
				string value3 = ((SceneRef*)sceneRef)->ToString(brackets: false, prefix: false);
				StringBuilder stringBuilder5 = stringBuilder.Append(value3);
				StringBuilder stringBuilder6 = stringBuilder.Append((string)obj4);
				ReadOnlySpan<NetworkLoadSceneParameters> sceneParams = SceneParams;
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj12 = !flag2;
				if (obj12 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				StringBuilder stringBuilder7 = stringBuilder.Append(obj13);
				ReadOnlySpan<NetworkLoadSceneParameters> sceneParams2 = SceneParams;
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
				object obj14 = !flag3;
				if (obj14 != null)
				{
					break;
				}
				object obj15 = sceneParams2 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v12+1]");
				if ((nint)0 != 0)
				{
					StringBuilder stringBuilder8 = stringBuilder.Append((string)obj6);
					ReadOnlySpan<NetworkLoadSceneParameters> sceneParams3 = SceneParams;
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
					object obj16 = !flag4;
					if (obj16 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					StringBuilder stringBuilder9 = stringBuilder.Append(value4);
				}
				StringBuilder stringBuilder10 = stringBuilder.Append((string)value2);
				obj8++;
				obj9 += 4;
				obj10 += 2;
				object obj17 = _flags & (NetworkSceneInfoDefaultFlags)0x1Fu;
				bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
				object obj18 = !flag5;
				object obj19 = ~obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v28 (System.ReadOnlySpan`1<Fusion.NetworkLoadSceneParameters>)+v105 @ X22_v5]");
				object obj20 = 0;
				if (obj19 != null)
				{
					continue;
				}
				goto IL_0338;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
		IL_0338:
		StringBuilder stringBuilder11 = stringBuilder.Append((string)value2);
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		string result = default;
		return result;
	}

	public unsafe bool Equals(NetworkSceneInfo other)
	{
		//IL_0043: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_0089: Expected I8, but got I4
		//IL_0089: Expected I, but got VT
		//IL_000e: Invalid comparison between VT and I4
		bool flag = System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40E0]");
		object obj = 0;
		object obj2 = !flag;
		object obj3 = ~obj2;
		bool flag2 = obj3 != null || other == (NetworkSceneInfo)(object)0;
		object obj4 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F6408");
		int num = UnsafeUtility.MemCmp(System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void*)(nint)other, 192L);
		return num == 0;
	}

	public unsafe override bool Equals(object obj)
	{
		//IL_0039: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0069: Expected VT, but got Ref
		//IL_0075: Expected VT, but got Ref
		bool result;
		NetworkSceneInfo networkSceneInfo;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7EA8]");
			object obj2 = 0;
			if (obj == obj2)
			{
				object obj3 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				object obj4 = default;
				result = Equals((NetworkSceneInfo)(&obj4));
				networkSceneInfo = (NetworkSceneInfo)(&obj4);
				goto IL_007a;
			}
		}
		networkSceneInfo = (NetworkSceneInfo)obj;
		result = false;
		goto IL_007a;
		IL_007a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9FC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3630100");
		int result = default;
		return result;
	}

	public static implicit operator NetworkSceneInfo(SceneRef sceneRef)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		SceneRef sceneRef2 = (SceneRef)(sceneRef & 0xFFFFFFFFL);
		NetworkSceneInfo networkSceneInfo = default;
		int num = networkSceneInfo.AddSceneRef(sceneRef2, (NetworkLoadSceneParametersFlags)1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
		NetworkSceneInfo result = default;
		if (num2 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkSceneInfo result2 = default;
		return result2;
	}
}
