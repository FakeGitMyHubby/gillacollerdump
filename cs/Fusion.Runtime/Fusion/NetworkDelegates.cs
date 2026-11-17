using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Fusion.Async;
using Fusion.Sockets;
using PlayFab.ClientModels;
using Unity.IL2CPP.Metadata;

namespace Fusion;

public class NetworkDelegates : Action<UnlinkGoogleAccountResult>, _0021_00210
{
	private sealed class _003CStartGameModeSinglePlayer_003Ed__485 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<StartGameResult> _003C_003Et__builder;

		public StartGameArgs args;

		public NetworkRunner _003C_003E4__this;

		private object _003C_003Es__1;

		private int _003C_003Es__2;

		private NetworkRunnerInitializeArgs _003CrunnerArgs_003E5__3;

		private ShutdownReason _003Cresult_003E5__4;

		private ShutdownReason _003C_003Es__5;

		private Exception _003Ce_003E5__6;

		private StartGameResult _003C_003Es__7;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<ShutdownReason> _003C_003Eu__2;

		private TaskAwaiter<StartGameResult> _003C_003Eu__3;

		private unsafe void MoveNext()
		{
			//IL_1eb8: Expected Obj, but got I4
			//IL_1ecf: Expected Obj, but got I4
			//IL_1ef9: Expected Obj, but got I4
			//IL_1f09: Expected Obj, but got I4
			//IL_1f29: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f2e: Expected Obj, but got Unknown
			//IL_0015: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I
			//IL_0077: Expected VT, but got I
			//IL_0abe: Expected VT, but got I4
			//IL_0acd: Expected I4, but got I8
			//IL_0ada: Expected VT, but got I8
			//IL_0ae7: Expected I4, but got I8
			//IL_0096: Expected F4, but got I4
			//IL_00a6: Expected VT, but got I
			//IL_00b9: Expected Obj, but got I4
			//IL_00c2: Expected VT, but got I4
			//IL_00cb: Expected VT, but got I4
			//IL_00d4: Expected VT, but got I4
			//IL_1f7f: Expected Obj, but got I
			//IL_1f87: Expected VT, but got Obj
			//IL_1fb7: Expected VT, but got Ref
			//IL_1fbf: Expected Obj, but got Ref
			//IL_1fcd: Expected Obj, but got I4
			//IL_1fd6: Expected Obj, but got I4
			//IL_1fdf: Expected VT, but got I4
			//IL_1fe8: Expected VT, but got I4
			//IL_1ff5: Expected Obj, but got I4
			//IL_01f6: Expected VT, but got I4
			//IL_0205: Expected I4, but got I8
			//IL_0212: Expected VT, but got I8
			//IL_021f: Expected I4, but got I8
			//IL_0232: Expected VT, but got I4
			//IL_0247: Expected Obj, but got I
			//IL_027c: Expected Obj, but got I4
			//IL_0c46: Expected Obj, but got I
			//IL_0c63: Expected Obj, but got I
			//IL_02af: Expected VT, but got I4
			//IL_02af: Expected VT, but got I
			//IL_02cb: Expected VT, but got I4
			//IL_02d3: Expected VT, but got I4
			//IL_0156: Expected VT, but got I4
			//IL_0165: Expected I4, but got I8
			//IL_016d: Expected VT, but got Ref
			//IL_0175: Expected Obj, but got Ref
			//IL_0183: Expected Obj, but got I4
			//IL_0190: Expected I4, but got I8
			//IL_019d: Expected I4, but got I8
			//IL_01a6: Expected Obj, but got I4
			//IL_01af: Expected VT, but got I4
			//IL_01c2: Expected VT, but got I4
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			//IL_011c: Expected F4, but got I4
			//IL_0b12: Expected VT, but got Ref
			//IL_0b1a: Expected Obj, but got Ref
			//IL_0b28: Expected Obj, but got I4
			//IL_0b31: Expected Obj, but got I4
			//IL_0b3a: Expected VT, but got I4
			//IL_0b43: Expected VT, but got I4
			//IL_0cb8: Expected VT, but got Ref
			//IL_0cc0: Expected Obj, but got Ref
			//IL_0cce: Expected Obj, but got I4
			//IL_0cd8: Expected VT, but got Obj
			//IL_0ce6: Expected Obj, but got I4
			//IL_0cef: Expected VT, but got I4
			//IL_035a: Expected Obj, but got I
			//IL_0379: Expected VT, but got Ref
			//IL_0381: Expected Obj, but got Ref
			//IL_038f: Expected Obj, but got I4
			//IL_0397: Expected VT, but got Ref
			//IL_03af: Expected Obj, but got I4
			//IL_03b8: Expected VT, but got I4
			//IL_03c1: Expected VT, but got I4
			//IL_03ca: Expected VT, but got I4
			//IL_03d7: Expected Obj, but got VT
			//IL_20d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_20dc: Expected Obj, but got Unknown
			//IL_20f8: Expected VT, but got I4
			//IL_2100: Expected I4, but got Obj
			//IL_030b: Expected Obj, but got I4
			//IL_0fc4: Expected Obj, but got I4
			//IL_0b73: Expected Obj, but got I
			//IL_0b7b: Expected VT, but got Obj
			//IL_0ba4: Expected VT, but got Ref
			//IL_0bac: Expected Obj, but got Ref
			//IL_0bba: Expected Obj, but got I4
			//IL_0bc3: Expected Obj, but got I4
			//IL_0bcc: Expected VT, but got I4
			//IL_0bd5: Expected VT, but got I4
			//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d27: Expected Obj, but got Unknown
			//IL_0d41: Expected Obj, but got I
			//IL_03f5: Expected Obj, but got I
			//IL_0414: Expected VT, but got Ref
			//IL_041c: Expected Obj, but got Ref
			//IL_042a: Expected Obj, but got I4
			//IL_0432: Expected VT, but got Ref
			//IL_044a: Expected Obj, but got I4
			//IL_0453: Expected VT, but got I4
			//IL_045c: Expected VT, but got I4
			//IL_0465: Expected VT, but got I4
			//IL_0472: Expected Obj, but got VT
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Expected VT, but got Unknown
			//IL_033c: Expected Ref, but got VT
			//IL_0345: Expected VT, but got I4
			//IL_208f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2094: Expected Obj, but got Unknown
			//IL_20ab: Expected VT, but got I4
			//IL_0e8f: Expected Obj, but got I
			//IL_0ea7: Expected Obj, but got I
			//IL_118f: Expected Obj, but got I4
			//IL_2013: Expected Obj, but got I
			//IL_2035: Expected VT, but got Ref
			//IL_203d: Expected Obj, but got Ref
			//IL_204b: Expected Obj, but got I4
			//IL_2067: Expected Obj, but got I4
			//IL_2070: Expected VT, but got I4
			//IL_0d8e: Expected VT, but got Ref
			//IL_0d96: Expected Obj, but got Ref
			//IL_0da4: Expected Obj, but got I4
			//IL_0db4: Expected VT, but got I
			//IL_0dc2: Expected Obj, but got I4
			//IL_0dcb: Expected VT, but got I4
			//IL_0499: Expected Obj, but got I
			//IL_10fc: Expected Obj, but got VT
			//IL_110c: Expected Obj, but got I
			//IL_112b: Expected VT, but got I4
			//IL_0edc: Expected Obj, but got I
			//IL_0ef7: Expected Obj, but got I
			//IL_04b8: Expected F4, but got I
			//IL_04c0: Expected Obj, but got Ref
			//IL_04da: Expected Obj, but got Ref
			//IL_11b7: Expected Obj, but got I4
			//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe9: Expected Obj, but got Unknown
			//IL_1003: Expected Obj, but got I
			//IL_102d: Expected Obj, but got I4
			//IL_0f1d: Expected Obj, but got I
			//IL_0f3c: Expected VT, but got Ref
			//IL_0f44: Expected Obj, but got Ref
			//IL_0f52: Expected Obj, but got I4
			//IL_0f5a: Expected VT, but got Obj
			//IL_0f68: Expected Obj, but got I4
			//IL_0f71: Expected VT, but got I4
			//IL_0dfa: Expected VT, but got Ref
			//IL_0e02: Expected Obj, but got Ref
			//IL_0e10: Expected Obj, but got I4
			//IL_0e20: Expected VT, but got I
			//IL_0e2e: Expected Obj, but got I4
			//IL_0e37: Expected VT, but got I4
			//IL_1f4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f51: Expected Obj, but got Unknown
			//IL_115d: Expected Obj, but got I
			//IL_1170: Expected VT, but got I4
			//IL_105a: Expected Obj, but got I
			//IL_1068: Unknown result type (might be due to invalid IL or missing references)
			//IL_106d: Expected VT, but got Unknown
			//IL_107e: Expected Ref, but got VT
			//IL_1086: Expected VT, but got Ref
			//IL_108e: Expected Obj, but got Ref
			//IL_109c: Expected Obj, but got I4
			//IL_10b4: Expected Obj, but got Ref
			//IL_10c6: Expected Obj, but got I4
			//IL_10cf: Expected VT, but got I4
			//IL_10dc: Expected Obj, but got VT
			//IL_0693: Expected Obj, but got I
			//IL_069b: Expected Obj, but got Ref
			//IL_06c3: Expected Obj, but got Ref
			//IL_050b: Expected Obj, but got I
			//IL_052a: Expected VT, but got Ref
			//IL_0532: Expected Obj, but got Ref
			//IL_0540: Expected Obj, but got I4
			//IL_0549: Expected VT, but got Obj
			//IL_0559: Expected VT, but got Ref
			//IL_0561: Expected VT, but got Obj
			//IL_0579: Expected Obj, but got I4
			//IL_0582: Expected VT, but got I4
			//IL_058b: Expected VT, but got I4
			//IL_0594: Expected VT, but got I4
			//IL_05a1: Expected Obj, but got I4
			//IL_10ef: Expected Obj, but got I4
			//IL_0f8c: Expected I, but got Obj
			//IL_0f9c: Expected Obj, but got I
			//IL_0e71: Expected Obj, but got I
			//IL_06e0: Expected Obj, but got Ref
			//IL_06f8: Expected Obj, but got Ref
			//IL_126c: Expected Obj, but got I
			//IL_1283: Expected I4, but got I8
			//IL_12a5: Expected Obj, but got I4
			//IL_0715: Expected Obj, but got Ref
			//IL_072d: Expected Obj, but got Ref
			//IL_05bf: Expected Obj, but got I
			//IL_05ca: Expected I4, but got VT
			//IL_05ed: Expected VT, but got Ref
			//IL_05f5: Expected Obj, but got Ref
			//IL_0603: Expected Obj, but got I4
			//IL_060c: Expected VT, but got Obj
			//IL_061c: Expected VT, but got Ref
			//IL_0625: Expected VT, but got I4
			//IL_063d: Expected Obj, but got I4
			//IL_0646: Expected VT, but got I4
			//IL_064f: Expected VT, but got I4
			//IL_0658: Expected VT, but got I4
			//IL_0665: Expected Obj, but got VT
			//IL_12c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_12cd: Expected VT, but got Unknown
			//IL_12dd: Expected Obj, but got I
			//IL_12f2: Expected Ref, but got VT
			//IL_12fa: Expected VT, but got Obj
			//IL_1302: Expected Obj, but got VT
			//IL_1204: Expected Obj, but got I4
			//IL_074a: Expected Obj, but got Ref
			//IL_0762: Expected Obj, but got Ref
			//IL_077f: Expected Obj, but got Ref
			//IL_078f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0794: Expected Obj, but got Unknown
			//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ae: Expected Obj, but got Unknown
			//IL_07d1: Expected VT, but got Ref
			//IL_07d9: Expected Obj, but got Ref
			//IL_07e7: Expected Obj, but got I4
			//IL_07f0: Expected VT, but got Ref
			//IL_07f9: Expected F4, but got I4
			//IL_0802: Expected VT, but got I4
			//IL_080b: Expected Obj, but got I4
			//IL_081e: Expected Obj, but got I4
			//IL_0827: Expected VT, but got I4
			//IL_0830: Expected VT, but got I4
			//IL_0839: Expected VT, but got I4
			//IL_1820: Invalid comparison between VT and I4
			//IL_1831: Expected I4, but got VT
			//IL_0852: Unknown result type (might be due to invalid IL or missing references)
			//IL_0857: Expected Obj, but got Unknown
			//IL_0870: Expected VT, but got Ref
			//IL_1c0f: Invalid comparison between VT and I4
			//IL_0890: Expected VT, but got Ref
			//IL_0898: Expected Obj, but got Ref
			//IL_08a6: Expected Obj, but got I4
			//IL_08b7: Expected VT, but got Ref
			//IL_08c0: Expected F4, but got I4
			//IL_08c8: Expected VT, but got Ref
			//IL_08e0: Expected Obj, but got I4
			//IL_08e9: Expected VT, but got I4
			//IL_08f2: Expected VT, but got I4
			//IL_08fb: Expected VT, but got I4
			//IL_1c56: Invalid comparison between VT and I4
			//IL_1869: Expected Obj, but got I
			//IL_1888: Expected VT, but got Obj
			//IL_189b: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a0: Expected Obj, but got Unknown
			//IL_211d: Invalid comparison between VT and I4
			//IL_212e: Expected VT, but got I4
			//IL_1c48: Expected Obj, but got I4
			//IL_0951: Expected Obj, but got I4
			//IL_095a: Expected VT, but got Ref
			//IL_0963: Expected F4, but got I4
			//IL_1ca4: Expected Obj, but got I4
			//IL_18c5: Expected Obj, but got Ref
			//IL_18e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e9: Expected Obj, but got Unknown
			//IL_1b56: Expected VT, but got I4
			//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a8: Expected Obj, but got Unknown
			//IL_09c2: Expected Obj, but got I
			//IL_09ec: Expected Obj, but got I4
			//IL_1cd2: Expected VT, but got Obj
			//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cea: Expected Obj, but got Unknown
			//IL_192c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1931: Expected Obj, but got Unknown
			//IL_0a19: Expected Obj, but got I
			//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2c: Expected VT, but got Unknown
			//IL_0a3d: Expected Ref, but got VT
			//IL_0a45: Expected VT, but got Ref
			//IL_0a4d: Expected Obj, but got Ref
			//IL_0a5b: Expected Obj, but got I4
			//IL_0a64: Expected VT, but got Ref
			//IL_0a6d: Expected F4, but got I4
			//IL_0a7d: Expected Obj, but got Ref
			//IL_0a8f: Expected Obj, but got I4
			//IL_0a98: Expected VT, but got I4
			//IL_0aa1: Expected VT, but got I4
			//IL_0aae: Expected Obj, but got VT
			//IL_1d0f: Expected Obj, but got Ref
			//IL_1d2d: Expected I4, but got I8
			//IL_1988: Expected VT, but got Obj
			//IL_1e0f: Expected VT, but got I4
			//IL_1d5e: Expected Obj, but got I4
			//IL_1d8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d90: Expected VT, but got Unknown
			//IL_1d9d: Expected Ref, but got VT
			//IL_1daa: Expected VT, but got Obj
			//IL_1dba: Expected Obj, but got VT
			//IL_19de: Expected Obj, but got I4
			//IL_19ee: Expected I4, but got VT
			//IL_17fd: Expected I4, but got VT
			//IL_1a29: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a2e: Expected Obj, but got Unknown
			//IL_1a48: Expected Obj, but got I
			//IL_1a72: Expected Obj, but got I4
			//IL_1a9f: Expected Obj, but got I
			//IL_1aad: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ab2: Expected VT, but got Unknown
			//IL_1ac3: Expected Ref, but got VT
			//IL_1ae3: Expected Obj, but got Ref
			//IL_1b01: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			bool flag = _003C_003E1__state < 3;
			object obj = !flag;
			object obj2 = ~obj;
			Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> asyncOperationHandler = null;
			string text = (string)400;
			int num2 = default;
			System.__Canon stateMachine;
			_003CStartGameModeSinglePlayer_003Ed__485 obj7 = default;
			TaskAwaiter<bool> taskAwaiter3;
			TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> taskAwaiter;
			object obj6;
			TaskAwaiter<System.__Canon> taskAwaiter2;
			CancellationToken cancellationToken;
			Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> asyncOperationHandler3 = default;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5450]");
				object obj3 = 0;
				NetworkRunner networkRunner = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8C30]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5440]");
				object obj5 = 0;
				text = (string)obj4;
				string text2 = (string)obj5;
				Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> asyncOperationHandler2 = asyncOperationHandler3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1F8]");
				asyncOperationHandler2._002Ector((CancellationToken)0, 120f, (string)obj4);
				bool flag2 = (object)_003C_003E4__this == null;
				float num = 1.1230249E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1F8]");
				cancellationToken = (CancellationToken)0;
				num2 = _003C_003E1__state;
				obj6 = 0;
				taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
				taskAwaiter3 = (TaskAwaiter<bool>)0;
				stateMachine = null;
				obj7 = this;
				if (flag2)
				{
					goto IL_13c2;
				}
				networkRunner.StartGameOperation = (Fusion.Async.AsyncOperationHandler<ShutdownReason>)(object)asyncOperationHandler3;
				object obj8 = _003C_003E4__this + 792;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num = 1.1230249E+09f;
				asyncOperationHandler = asyncOperationHandler3;
			}
			bool flag3 = _003C_003E1__state < 1;
			object obj9 = !flag3;
			object obj10 = _003C_003E1__state - 1;
			bool flag4 = obj10 == null;
			object obj11 = ~obj9;
			object obj12 = obj11 | flag4;
			TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> taskAwaiter4 = default;
			object obj13 = default;
			Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> asyncOperationHandler4 = default;
			object obj14 = default;
			int num3;
			TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> taskAwaiter5 = default;
			TickRate.Selection selection;
			CancellationToken cancellationToken3;
			int? num4 = default;
			ShutdownReason shutdownReason;
			StartGameResult startGameResult = default;
			if (obj12 == null)
			{
				if (_003C_003E1__state == 2)
				{
					_003C_003Eu__3 = (TaskAwaiter<StartGameResult>)0;
					_003C_003E1__state = -1;
					taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					obj13 = (object)(&num2);
					asyncOperationHandler4 = null;
					obj14 = 0;
					num3 = -1;
					num2 = -1;
					obj6 = 0;
					taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
					taskAwaiter2 = (TaskAwaiter<System.__Canon>)_003C_003Eu__3;
					taskAwaiter3 = (TaskAwaiter<bool>)0;
					stateMachine = null;
					goto IL_20b9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
				object obj15 = 0;
				_003C_003Es__2 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v57+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1F8]");
				bool flag6 = (CancellationToken)0 != (CancellationToken)0;
				bool flag7 = !flag6;
				cancellationToken = (CancellationToken)0;
				CancellationToken cancellationToken2 = (CancellationToken)flag6;
				if (!flag7)
				{
					object obj18 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X0_v110+E4]");
					bool flag8 = (nint)0 == 0;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					cancellationToken2 = (CancellationToken)(this + 504);
					((CancellationToken*)cancellationToken2)->ThrowIfCancellationRequested();
					cancellationToken = (CancellationToken)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+A8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+A8]");
				bool flag9 = (nint)0 == 0;
				taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				obj13 = (object)(&num2);
				asyncOperationHandler4 = null;
				obj14 = 0;
				taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				text = null;
				num2 = _003C_003E1__state;
				obj6 = 0;
				taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
				taskAwaiter3 = (TaskAwaiter<bool>)0;
				stateMachine = null;
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)cancellationToken2;
				if (flag9)
				{
					goto IL_162f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X8_v70+50]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X8_v70+50]");
				bool flag10 = (nint)0 == 0;
				taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				obj13 = (object)(&num2);
				asyncOperationHandler4 = null;
				obj14 = 0;
				taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				text = null;
				num2 = _003C_003E1__state;
				obj6 = 0;
				taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
				taskAwaiter3 = (TaskAwaiter<bool>)0;
				stateMachine = null;
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)cancellationToken2;
				if (flag10)
				{
					goto IL_1674;
				}
				TickRate.Selection zero = TickRate.Zero;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F48]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ X19_v14+30]");
				float num = 0f;
				Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = default;
				object obj23 = (object)(&_Il2CppInt32Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ X19_v14+30]");
				_ = 0;
				object obj24 = default;
				bool flag11 = ((ValueType)(&_Il2CppInt32Enum)).Equals(obj24);
				if (flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+A8]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+A8]");
					bool flag12 = (nint)0 == 0;
					taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					obj13 = (object)(&num2);
					asyncOperationHandler4 = null;
					obj14 = 0;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)obj22;
					selection = zero;
					taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					cancellationToken3 = (CancellationToken)obj24;
					text = null;
					num2 = _003C_003E1__state;
					obj6 = 0;
					taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
					taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
					taskAwaiter3 = (TaskAwaiter<bool>)0;
					stateMachine = null;
					asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)flag11;
					if (flag12)
					{
						goto IL_1763;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ X9_v28+50]");
					object obj26 = 0;
					TickRate.Selection selection2 = TickRate.GetDefault((GameMode)args);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ X9_v28+50]");
					bool flag13 = (nint)0 == 0;
					taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					obj13 = (object)(&num2);
					asyncOperationHandler4 = null;
					obj14 = 0;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)obj22;
					selection = zero;
					taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					cancellationToken3 = (CancellationToken)0;
					text = null;
					num2 = _003C_003E1__state;
					obj6 = 0;
					taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
					taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
					taskAwaiter3 = (TaskAwaiter<bool>)0;
					stateMachine = null;
					asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)selection2;
					if (flag13)
					{
						goto IL_17b0;
					}
					_ = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				object obj27 = this + 184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
				object obj28 = 0;
				object obj30 = default;
				object obj29 = (object)(&obj30);
				_ = 0;
				_ = 0;
				num4 = 1;
				object obj32 = default;
				object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 296));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj33 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 304));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj34 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 312));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj35 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 320));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 328));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 336));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj38 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 344));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj32, 352));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj40 = this + 544;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				object obj41 = this + 840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag14 = (object)_003C_003E4__this == null;
				taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				obj13 = (object)(&num2);
				asyncOperationHandler4 = null;
				obj14 = 0;
				taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				num = 0f;
				cancellationToken3 = (CancellationToken)0;
				text = (string)400;
				num2 = _003C_003E1__state;
				obj6 = 0;
				taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
				taskAwaiter3 = (TaskAwaiter<bool>)0;
				stateMachine = null;
				if (flag14)
				{
					goto IL_16c1;
				}
				object obj42 = this + 544;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				object obj43 = default;
				Task<bool> task = _003C_003E4__this.Initialize((NetworkRunnerInitializeArgs)(&obj43));
				bool flag15 = task == null;
				taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				obj13 = (object)(&num2);
				asyncOperationHandler4 = null;
				obj14 = 0;
				selection = (TickRate.Selection)num4;
				taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				num = 0f;
				cancellationToken3 = (CancellationToken)(&obj43);
				text = null;
				num2 = _003C_003E1__state;
				obj6 = 0;
				taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
				taskAwaiter3 = (TaskAwaiter<bool>)0;
				stateMachine = null;
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)task;
				if (flag15)
				{
					goto IL_1716;
				}
				TaskAwaiter<bool> awaiter = task.GetAwaiter();
				TaskAwaiter<bool> awaiter2 = default;
				bool isCompleted = awaiter2.IsCompleted;
				bool flag16 = !isCompleted;
				object obj44 = !flag16;
				taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				num = 0f;
				text = null;
				num2 = _003C_003E1__state;
				taskAwaiter3 = awaiter2;
				if (obj44 == null)
				{
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter2;
					object obj45 = this + 968;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D82D8]");
					object obj46 = 0;
					object obj47 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2319 @ X0_v104+E4]");
					bool flag17 = (nint)0 == 0;
					object obj48 = !flag17;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D97F8]");
					object obj49 = 0;
					string text2 = (string)obj49;
					AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
					((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<bool>, System.__Canon>(ref awaiter2, ref stateMachine);
					taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					obj13 = (object)(&num2);
					asyncOperationHandler4 = null;
					obj14 = 0;
					taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					num = 0f;
					shutdownReason = (ShutdownReason)(int)(&awaiter2);
					text = (string)(&stateMachine);
					num2 = 0;
					obj6 = 0;
					taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
					taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
					stateMachine = (System.__Canon)(object)this;
					startGameResult = (StartGameResult)asyncTaskMethodBuilder;
					goto IL_10e1;
				}
			}
			else
			{
				if (_003C_003E1__state != 0)
				{
					_003C_003Eu__2 = (TaskAwaiter<ShutdownReason>)0;
					_003C_003E1__state = -1;
					taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)4294967295L;
					num2 = -1;
					taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)_003C_003Eu__2;
					taskAwaiter3 = (TaskAwaiter<bool>)0;
					goto IL_0c36;
				}
				_003C_003Eu__1 = (TaskAwaiter<bool>)0;
				_003C_003E1__state = -1;
				taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)4294967295L;
				num2 = -1;
				taskAwaiter3 = _003C_003Eu__1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4500]");
			object obj50 = 0;
			cancellationToken = (CancellationToken)obj50;
			bool result = taskAwaiter3.GetResult();
			NetworkRunner networkRunner2 = _003C_003E4__this;
			bool flag18 = (object)_003C_003E4__this == null;
			taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
			obj13 = (object)(&num2);
			asyncOperationHandler4 = null;
			obj14 = 0;
			obj6 = 0;
			taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
			stateMachine = null;
			asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)result;
			if (flag18)
			{
				goto IL_1491;
			}
			bool flag19 = networkRunner2.StartGameOperation == null;
			taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
			obj13 = (object)(&num2);
			asyncOperationHandler4 = null;
			obj14 = 0;
			obj6 = 0;
			taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
			stateMachine = null;
			asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)networkRunner2.StartGameOperation;
			if (flag19)
			{
				goto IL_14d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5448]");
			object obj51 = 0;
			cancellationToken = (CancellationToken)obj51;
			Task<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> task2 = ((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)networkRunner2.StartGameOperation).Task;
			bool flag20 = task2 == null;
			taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
			obj13 = (object)(&num2);
			asyncOperationHandler4 = null;
			obj14 = 0;
			obj6 = 0;
			taskAwaiter = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
			stateMachine = null;
			asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)task2;
			if (!flag20)
			{
				TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> awaiter3 = task2.GetAwaiter();
				TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> awaiter4 = default;
				bool isCompleted2 = awaiter4.IsCompleted;
				bool flag21 = !isCompleted2;
				taskAwaiter = awaiter4;
				if (!flag21)
				{
					goto IL_0c36;
				}
				_003C_003E1__state = 1;
				_003C_003Eu__2 = (TaskAwaiter<ShutdownReason>)awaiter4;
				object obj52 = this + 976;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D82D8]");
				object obj53 = 0;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1962 @ X0_v34+E4]");
				bool flag22 = (nint)0 == 0;
				object obj55 = !flag22;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9808]");
				object obj56 = 0;
				string text2 = (string)obj56;
				AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
				((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder2)->AwaitUnsafeOnCompleted<TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>, System.__Canon>(ref awaiter4, ref stateMachine);
				taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				obj13 = (object)(&num2);
				asyncOperationHandler4 = null;
				obj14 = 0;
				taskAwaiter5 = awaiter4;
				shutdownReason = (ShutdownReason)(int)(&awaiter4);
				text = (string)(&stateMachine);
				num2 = 1;
				obj6 = 0;
				taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
				stateMachine = (System.__Canon)(object)this;
				startGameResult = (StartGameResult)asyncTaskMethodBuilder2;
				goto IL_10e1;
			}
			goto IL_151b;
			IL_1407:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num5 == 0)
			{
				NullReferenceException ex = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex;
				goto IL_144c;
			}
			goto IL_1e78;
			IL_144c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num6 == 0)
			{
				NullReferenceException ex2 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex2;
				goto IL_1491;
			}
			goto IL_1e78;
			IL_16c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			bool flag23 = num7 != 0;
			cancellationToken = cancellationToken3;
			if (!flag23)
			{
				NullReferenceException ex3 = new NullReferenceException();
				selection = (TickRate.Selection)num4;
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex3;
				goto IL_1716;
			}
			goto IL_1e78;
			IL_10e1:
			System.__Canon _Canon = null;
			object obj57 = 20;
			goto IL_2082;
			IL_1716:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			bool flag24 = num8 != 0;
			cancellationToken = cancellationToken3;
			if (!flag24)
			{
				NullReferenceException ex4 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex4;
				goto IL_1763;
			}
			goto IL_1e78;
			IL_1674:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num9 == 0)
			{
				NullReferenceException ex5 = new NullReferenceException();
				cancellationToken3 = cancellationToken;
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex5;
				goto IL_16c1;
			}
			goto IL_1e78;
			IL_0c36:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5478]");
			object obj58 = 0;
			Unity.IL2CPP.Metadata.__Il2CppInt32Enum result2 = taskAwaiter.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5070]");
			object obj59 = 0;
			NetworkRunner networkRunner3 = _003C_003E4__this;
			_003C_003Es__5 = (ShutdownReason)result2;
			_003Cresult_003E5__4 = (ShutdownReason)result2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			SessionInfo sessionInfo = default;
			sessionInfo._002Ector(_003C_003E4__this);
			bool flag25 = (object)_003C_003E4__this == null;
			taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
			obj13 = (object)(&num2);
			asyncOperationHandler4 = null;
			obj14 = 0;
			cancellationToken = (CancellationToken)_003C_003E4__this;
			text = null;
			obj6 = 0;
			taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
			stateMachine = null;
			asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)sessionInfo;
			StartGameResult startGameResult2;
			if (!flag25)
			{
				networkRunner3.SessionInfo__BackingField = sessionInfo;
				object obj60 = _003C_003E4__this + 760;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1A8]");
				Dictionary<string, SessionProperty> dictionary = (Dictionary<string, SessionProperty>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1A8]");
				bool flag26 = (nint)0 == 0;
				string text3 = null;
				if (!flag26)
				{
					NetworkRunner networkRunner4 = _003C_003E4__this;
					bool flag27 = (object)_003C_003E4__this == null;
					taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					obj13 = (object)(&num2);
					asyncOperationHandler4 = null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1A8]");
					cancellationToken = (CancellationToken)0;
					text = null;
					obj6 = 0;
					taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
					stateMachine = null;
					if (flag27)
					{
						goto IL_1560;
					}
					bool flag28 = networkRunner4.SessionInfo__BackingField == null;
					taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					obj13 = (object)(&num2);
					asyncOperationHandler4 = null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1A8]");
					cancellationToken = (CancellationToken)0;
					text = null;
					obj6 = 0;
					taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
					stateMachine = null;
					asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)networkRunner4.SessionInfo__BackingField;
					if (flag28)
					{
						goto IL_15a5;
					}
					SessionInfo sessionInfo2 = networkRunner4.SessionInfo__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDelegates+<StartGameModeSinglePlayer>d__485)+1A8]");
					bool flag29 = sessionInfo2.UpdateCustomProperties((Dictionary<string, SessionProperty>)0);
					text3 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj61 = 0;
				object obj62 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1744 @ X8_v57+A0]");
				object obj63 = 0;
				object obj64 = obj63;
				if (obj63 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
					object obj65 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8C20]");
					object format = 0;
					object arg = default;
					string text4 = string.Format((string)format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1746 @ X19_v10+10]");
					asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1746 @ X19_v10+10]");
					bool flag30 = (nint)0 == 0;
					taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
					obj13 = (object)(&num2);
					asyncOperationHandler4 = null;
					obj14 = 0;
					cancellationToken = (CancellationToken)text4;
					text = null;
					obj6 = 0;
					taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
					stateMachine = null;
					if (flag30)
					{
						goto IL_15ea;
					}
					nint num10 = (nint)asyncOperationHandler3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1810 @ X8_v66 (Il2CppClass<Fusion.Async.AsyncOperationHandler`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>>)+1A0]");
					text3 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1810 @ X8_v66 (Il2CppClass<Fusion.Async.AsyncOperationHandler`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>>)+198] (should have been resolved before IL gen)");
					dictionary = (Dictionary<string, SessionProperty>)(object)text4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8300]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				startGameResult._002Ector((ShutdownReason)0);
				taskAwaiter4 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(&obj7);
				obj13 = (object)(&num2);
				asyncOperationHandler4 = null;
				obj14 = 0;
				shutdownReason = (ShutdownReason)0;
				string text2 = null;
				text = null;
				obj6 = 0;
				taskAwaiter2 = (TaskAwaiter<System.__Canon>)0;
				stateMachine = null;
				startGameResult2 = startGameResult;
				goto IL_0fb3;
			}
			goto IL_1407;
			IL_14d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num11 == 0)
			{
				NullReferenceException ex6 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex6;
				goto IL_151b;
			}
			goto IL_1e78;
			IL_1491:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num12 == 0)
			{
				NullReferenceException ex7 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex7;
				goto IL_14d6;
			}
			goto IL_1e78;
			IL_15a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num13 == 0)
			{
				NullReferenceException ex8 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex8;
				goto IL_15ea;
			}
			goto IL_1e78;
			IL_1560:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num14 == 0)
			{
				NullReferenceException ex9 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex9;
				goto IL_15a5;
			}
			goto IL_1e78;
			IL_1e3a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num15 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			}
			goto IL_1e78;
			IL_151b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num16 == 0)
			{
				NullReferenceException ex10 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex10;
				goto IL_1560;
			}
			goto IL_1e78;
			IL_162f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num17 == 0)
			{
				NullReferenceException ex11 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex11;
				goto IL_1674;
			}
			goto IL_1e78;
			IL_1763:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			bool flag31 = num18 != 0;
			cancellationToken = cancellationToken3;
			if (!flag31)
			{
				NullReferenceException ex12 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex12;
				goto IL_17b0;
			}
			goto IL_1e78;
			IL_17b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			bool flag32 = num19 != 0;
			cancellationToken = cancellationToken3;
			CancellationToken cancellationToken4;
			object obj73 = default;
			NullReferenceException ex14;
			if (!flag32)
			{
				NullReferenceException ex13 = new NullReferenceException();
				bool flag33 = cancellationToken3 != (CancellationToken)(object)2;
				shutdownReason = (ShutdownReason)cancellationToken3;
				cancellationToken4 = cancellationToken3;
				ex14 = ex13;
				if (flag33)
				{
					goto IL_1c06;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5388]");
				object obj67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj69 = default;
				object obj68 = obj69;
				cancellationToken = (CancellationToken)obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj71 = default;
				object obj70 = obj71 & 1;
				if (obj70 != null)
				{
					object obj72 = (object)(&obj73);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003Es__1 = obj69;
					object obj74 = this + 528;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_003C_003Es__2 = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28ACC4C");
					Exception ex15 = default;
					_003Ce_003E5__6 = ex15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28ACC4C");
					object obj75 = this + 952;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if ((object)_003C_003E4__this != null)
					{
						Task<StartGameResult> task3 = _003C_003E4__this.ShutdownAndBuildResult(_003Ce_003E5__6);
						bool flag34 = task3 == null;
						cancellationToken = (CancellationToken)_003Ce_003E5__6;
						text = null;
						asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)task3;
						if (!flag34)
						{
							TaskAwaiter<System.__Canon> awaiter5 = ((Task<System.__Canon>)(object)task3).GetAwaiter();
							TaskAwaiter<System.__Canon> awaiter6 = default;
							bool isCompleted3 = awaiter6.IsCompleted;
							bool flag35 = !isCompleted3;
							object obj76 = !flag35;
							num4 = (int?)selection;
							num3 = (int)taskAwaiter5;
							text = null;
							NetworkRunner networkRunner = (NetworkRunner)(object)this;
							taskAwaiter2 = awaiter6;
							if (obj76 == null)
							{
								_003C_003E1__state = 2;
								_003C_003Eu__3 = (TaskAwaiter<StartGameResult>)awaiter6;
								object obj77 = this + 984;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D82D8]");
								object obj78 = 0;
								object obj79 = obj78;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2324 @ X0_v181+E4]");
								bool flag36 = (nint)0 == 0;
								object obj80 = !flag36;
								if (obj80 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9800]");
								object obj81 = 0;
								string text2 = (string)obj81;
								AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
								((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder3)->AwaitUnsafeOnCompleted<TaskAwaiter<System.__Canon>, System.__Canon>(ref awaiter6, ref stateMachine);
								num4 = (int?)selection;
								taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)awaiter6;
								shutdownReason = (ShutdownReason)(int)(&awaiter6);
								text = (string)(&stateMachine);
								networkRunner = (NetworkRunner)(object)this;
								num2 = 2;
								taskAwaiter2 = awaiter6;
								startGameResult = (StartGameResult)asyncTaskMethodBuilder3;
								goto IL_10e1;
							}
							goto IL_20b9;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
						nint num20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
						bool flag37 = num20 != 0;
						CancellationToken cancellationToken5 = default;
						cancellationToken = cancellationToken5;
						asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)_003C_003E4__this;
						if (flag37)
						{
							goto IL_1e78;
						}
						NullReferenceException ex16 = new NullReferenceException();
						cancellationToken = cancellationToken5;
						asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
					if (num21 == 0)
					{
						NullReferenceException ex17 = new NullReferenceException();
						shutdownReason = (ShutdownReason)cancellationToken;
						NetworkRunner networkRunner = (NetworkRunner)(object)this;
						cancellationToken4 = cancellationToken;
						ex14 = ex17;
						goto IL_1c06;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
					if (num22 == 0)
					{
						cancellationToken = (CancellationToken)(101789696 + 1224);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						text = null;
						goto IL_1e23;
					}
				}
			}
			goto IL_1e78;
			IL_20b9:
			System.__Canon _Canon2 = (System.__Canon)(object)(_003C_003Es__7 = (StartGameResult)(object)taskAwaiter2.GetResult());
			object obj82 = this + 960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			startGameResult2 = _003C_003Es__7;
			taskAwaiter5 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)num3;
			shutdownReason = (ShutdownReason)_Canon2;
			goto IL_0fb3;
			IL_0fb3:
			_Canon = (System.__Canon)(object)startGameResult2;
			obj57 = 25;
			goto IL_2082;
			IL_2082:
			object obj83 = obj13 & 0x80000000L;
			bool flag38 = obj83 == null;
			cancellationToken = (CancellationToken)shutdownReason;
			if (!flag38)
			{
				object obj84 = taskAwaiter4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X8_v25+208]");
				object obj85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X8_v25+208]");
				bool flag39 = (nint)0 == 0;
				cancellationToken = (CancellationToken)shutdownReason;
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)startGameResult;
				if (flag39)
				{
					goto IL_144c;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X8_v25+208]");
				object obj86 = (nint)0 + (nint)792;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				cancellationToken = (CancellationToken)0;
			}
			bool flag40 = asyncOperationHandler4 == null;
			object obj87 = !flag40;
			if (obj87 == null)
			{
				bool flag41 = obj14 == null;
				object obj88 = !flag41;
				asyncOperationHandler3 = asyncOperationHandler4;
				if (obj88 == null)
				{
					if ((nint)obj57 != 25)
					{
						bool flag42 = obj57 == null;
						object obj89 = !flag42;
						asyncOperationHandler3 = asyncOperationHandler4;
						if (obj89 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
							nint num23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
							bool flag43 = num23 != 0;
							asyncOperationHandler3 = asyncOperationHandler4;
							if (!flag43)
							{
								throw new NullReferenceException();
							}
							goto IL_1e78;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D82D8]");
						object obj90 = 0;
						object obj91 = obj90;
						_003C_003E1__state = -2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1836 @ X0_v16+E4]");
						bool flag44 = (nint)0 == 0;
						object obj92 = !flag44;
						if (obj92 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder4 = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8B50]");
						object obj93 = 0;
						text = (string)obj93;
						((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder4)->SetResult(_Canon);
						cancellationToken = (CancellationToken)_Canon;
						asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)asyncTaskMethodBuilder4;
					}
					goto IL_1307;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
				bool flag45 = num24 != 0;
				asyncOperationHandler3 = asyncOperationHandler4;
				if (flag45)
				{
					goto IL_1e78;
				}
				OutOfMemoryException ex18 = new OutOfMemoryException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num25 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_13c2;
			}
			goto IL_1e78;
			IL_15ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num26 == 0)
			{
				NullReferenceException ex19 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex19;
				goto IL_162f;
			}
			goto IL_1e78;
			IL_1e23:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex20 = default;
			ex14 = ex20;
			goto IL_1e3a;
			IL_1c06:
			if (cancellationToken4 == (CancellationToken)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj14 = 1;
			}
			else
			{
				if (cancellationToken4 != (CancellationToken)(object)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AC638");
					bool flag46 = cancellationToken4 != (CancellationToken)(object)2;
					cancellationToken = (CancellationToken)shutdownReason;
					if (flag46)
					{
						goto IL_1e3a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj95 = default;
					object obj94 = obj95;
					cancellationToken = (CancellationToken)obj94;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj97 = default;
					object obj96 = obj97 & 1;
					if (obj96 != null)
					{
						object obj98 = (object)(&obj73);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						_003C_003E1__state = -2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2267 @ X0_v141+E4]");
						bool flag47 = (nint)0 == 0;
						object obj99 = !flag47;
						if (obj99 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder5 = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
						((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder5)->SetException((Exception)obj95);
						cancellationToken = (CancellationToken)obj95;
						string text5 = default;
						text = text5;
						asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)asyncTaskMethodBuilder5;
						goto IL_1307;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)obj95;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
					nint num27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
					if (num27 == 0)
					{
						cancellationToken = (CancellationToken)(101789696 + 1224);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						text = null;
						goto IL_1e23;
					}
					goto IL_1e78;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj100 = default;
				asyncOperationHandler4 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)obj100;
			}
			num4 = (int?)selection;
			_Canon = null;
			obj57 = 0;
			goto IL_2082;
			IL_1e78:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_1307:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num28 == 0)
			{
				return;
			}
			goto IL_1e78;
			IL_13c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
			if (num29 == 0)
			{
				NullReferenceException ex21 = new NullReferenceException();
				asyncOperationHandler3 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)ex21;
				goto IL_1407;
			}
			goto IL_1e78;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public Action<NetworkRunner, PlayerRef> OnPlayerJoined;

	public Action<NetworkRunner, PlayerRef> OnPlayerLeft;

	public Action<NetworkRunner, NetworkInput> OnInput;

	public Action<NetworkRunner, PlayerRef, NetworkInput> OnInputMissing;

	public Action<NetworkRunner, ShutdownReason> OnShutdown;

	public Action<NetworkRunner, NetDisconnectReason> OnDisconnectedFromServer;

	public Action<NetworkRunner, NetworkRunnerUpdaterDefault.PlayerLoopSystemRegistration.ConnectRequest, byte[]> OnConnectRequest;

	public Action<NetworkRunner, NetAddress, NetConnectFailedReason> OnConnectFailed;

	public NetworkEvents.OnReliableDataReceivedDelegate OnReliableDataReceived;

	public Action<NetworkRunner, PlayerRef, ReliableKey, float> OnReliableDataProgress;

	public Action<NetworkRunner, NetworkObject, PlayerRef> OnObjectExitAOI;

	public Action<NetworkRunner, NetworkObject, PlayerRef> OnObjectEnterAOI;

	public Action<NetworkRunner> OnConnectedToServer;

	public Action<NetworkRunner> OnSceneLoadDone;

	public Action<NetworkRunner> OnSceneLoadStart;

	public Action<NetworkRunner, List<SessionInfo>> OnSessionListUpdated;

	public Action<NetworkRunner, Dictionary<string, object>> OnCustomAuthenticationResponse;

	public Action<NetworkRunner, HostMigrationToken> OnHostMigration;

	private void Fusion_002EINetworkRunnerCallbacks_002EOnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		Action<NetworkRunner, NetworkObject, PlayerRef> onObjectExitAOI = OnObjectExitAOI;
		if (OnObjectExitAOI != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>)+28]");
			object obj3 = 0;
			object obj4 = player & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X5_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		Action<NetworkRunner, NetworkObject, PlayerRef> onObjectEnterAOI = OnObjectEnterAOI;
		if (OnObjectEnterAOI != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>)+28]");
			object obj3 = 0;
			object obj4 = player & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X5_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnPlayerJoined(NetworkRunner runner, PlayerRef player)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		Action<NetworkRunner, PlayerRef> onPlayerJoined = OnPlayerJoined;
		if (OnPlayerJoined != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.PlayerRef>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.PlayerRef>)+28]");
			object obj2 = 0;
			object obj3 = player & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.PlayerRef>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnPlayerLeft(NetworkRunner runner, PlayerRef player)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		Action<NetworkRunner, PlayerRef> onPlayerLeft = OnPlayerLeft;
		if (OnPlayerLeft != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.PlayerRef>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.PlayerRef>)+28]");
			object obj2 = 0;
			object obj3 = player & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.PlayerRef>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner, NetDisconnectReason> onDisconnectedFromServer = OnDisconnectedFromServer;
		if (OnDisconnectedFromServer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.Sockets.NetDisconnectReason>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.Sockets.NetDisconnectReason>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.Sockets.NetDisconnectReason>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner, ShutdownReason> onShutdown = OnShutdown;
		if (OnShutdown != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.ShutdownReason>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.ShutdownReason>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.ShutdownReason>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnConnectRequest(NetworkRunner runner, NetworkRunnerUpdaterDefault.PlayerLoopSystemRegistration.ConnectRequest request, byte[] token)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner, NetworkRunnerUpdaterDefault.PlayerLoopSystemRegistration.ConnectRequest, byte[]> onConnectRequest = OnConnectRequest;
		if (OnConnectRequest != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration+ConnectRequest, System.Byte[]>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration+ConnectRequest, System.Byte[]>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration+ConnectRequest, System.Byte[]>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X5_v1 (should have been resolved before IL gen)");
		}
	}

	private unsafe void Fusion_002EINetworkRunnerCallbacks_002EOnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
	{
		//IL_003b: Expected VT, but got Ref
		Action<NetworkRunner, NetAddress, NetConnectFailedReason> onConnectFailed = OnConnectFailed;
		if (OnConnectFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ X8_v2 (System.Action`3<Fusion.NetworkRunner, Fusion.Sockets.NetAddress, Fusion.Sockets.NetConnectFailedReason>)+18] (should have been resolved before IL gen)");
			object obj = default;
			NetAddress netAddress = (NetAddress)(&obj);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ReadOnlySpan<byte> data)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		NetworkEvents.OnReliableDataReceivedDelegate onReliableDataReceived = OnReliableDataReceived;
		if (OnReliableDataReceived != null)
		{
			IntPtr intPtr = ((Delegate)onReliableDataReceived).invoke_impl;
			IntPtr intPtr2 = ((Delegate)onReliableDataReceived).method_code;
			object obj = player & 0xFFFFFFFFL;
			IntPtr intPtr3 = ((Delegate)onReliableDataReceived).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X9_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		Action<NetworkRunner, PlayerRef, ReliableKey, float> onReliableDataProgress = OnReliableDataProgress;
		if (OnReliableDataProgress != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`4<Fusion.NetworkRunner, Fusion.PlayerRef, Fusion.Sockets.ReliableKey, System.Single>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`4<Fusion.NetworkRunner, Fusion.PlayerRef, Fusion.Sockets.ReliableKey, System.Single>)+18]");
			object obj2 = 0;
			object obj3 = player & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`4<Fusion.NetworkRunner, Fusion.PlayerRef, Fusion.Sockets.ReliableKey, System.Single>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X6_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnInput(NetworkRunner runner, NetworkInput input)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner, NetworkInput> onInput = OnInput;
		if (OnInput != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.NetworkInput>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.NetworkInput>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.NetworkInput>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X5_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		Action<NetworkRunner, PlayerRef, NetworkInput> onInputMissing = OnInputMissing;
		if (OnInputMissing != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.PlayerRef, Fusion.NetworkInput>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.PlayerRef, Fusion.NetworkInput>)+18]");
			object obj2 = 0;
			object obj3 = player & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<Fusion.NetworkRunner, Fusion.PlayerRef, Fusion.NetworkInput>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X6_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnConnectedToServer(NetworkRunner runner)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner> onConnectedToServer = OnConnectedToServer;
		if (OnConnectedToServer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner, List<SessionInfo>> onSessionListUpdated = OnSessionListUpdated;
		if (OnSessionListUpdated != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, System.Collections.Generic.List`1<Fusion.SessionInfo>>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, System.Collections.Generic.List`1<Fusion.SessionInfo>>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, System.Collections.Generic.List`1<Fusion.SessionInfo>>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSceneLoadDone(NetworkRunner runner)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner> onSceneLoadDone = OnSceneLoadDone;
		if (OnSceneLoadDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSceneLoadStart(NetworkRunner runner)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner> onSceneLoadStart = OnSceneLoadStart;
		if (OnSceneLoadStart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Fusion.NetworkRunner>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner, Dictionary<string, object>> onCustomAuthenticationResponse = OnCustomAuthenticationResponse;
		if (OnCustomAuthenticationResponse != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<NetworkRunner, HostMigrationToken> onHostMigration = OnHostMigration;
		if (OnHostMigration != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.HostMigrationToken>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.HostMigrationToken>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<Fusion.NetworkRunner, Fusion.HostMigrationToken>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		}
	}
}
