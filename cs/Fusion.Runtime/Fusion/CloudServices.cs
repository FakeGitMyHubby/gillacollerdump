using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Fusion.Async;
using Fusion.Encryption;
using Fusion.Matchmaking;
using Fusion.Matchmaking.Extensions;
using Fusion.Photon.Realtime;
using Fusion.Protocol;
using Fusion.Sockets;
using Fusion.Sockets.Stun;
using Liv.Lck;
using NanoSockets;
using Photon.Client;
using Photon.Realtime;
using PlayFab.ClientModels;
using PlayFab.MultiplayerModels;
using PlayFab.ProgressionModels;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Rendering;

namespace Fusion;

internal class CloudServices : _0021_00210, Action<IDebugDisplaySettingsData>, _0021_00210, Action<ILckCamera>, _0021_00210
{
	private sealed class _003C_003CRun_ReversePing_003Eb__0_003Ed : Action<GetPurchaseResult>
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken token;

		public _003C_003Ec__DisplayClass114_0 _003C_003E4__this;

		private int _003Ci_003E5__1;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_08f6: Expected Obj, but got I
			//IL_0906: Expected Obj, but got I
			//IL_0916: Expected Obj, but got I
			//IL_01ae: Expected VT, but got I4
			//IL_01bd: Expected I4, but got I8
			//IL_0489: Expected I, but got Obj
			//IL_049e: Expected I, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_003d: Expected Obj, but got I
			//IL_02c3: Expected Obj, but got I4
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Expected VT, but got Unknown
			//IL_02f4: Expected Ref, but got VT
			//IL_04cb: Expected I4, but got I8
			//IL_04ed: Expected Obj, but got I4
			//IL_065b: Expected I, but got Obj
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Expected VT, but got Unknown
			//IL_051e: Expected Ref, but got VT
			//IL_0523: Expected I, but got Obj
			//IL_052b: Expected Obj, but got VT
			//IL_0339: Expected VT, but got Ref
			//IL_0681: Expected I, but got Obj
			//IL_039c: Expected Obj, but got I4
			//IL_00dc: Expected Obj, but got I
			//IL_00f7: Expected Obj, but got I
			//IL_03eb: Expected I, but got VT
			//IL_011d: Expected Obj, but got I
			//IL_0144: Expected I, but got Obj
			//IL_015a: Expected I, but got Obj
			//IL_016b: Expected Obj, but got I
			//IL_0185: Expected Obj, but got I
			//IL_019e: Expected I, but got Obj
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_053b: Expected Obj, but got Unknown
			//IL_0545: Expected Obj, but got VT
			//IL_057f: Expected Obj, but got I4
			//IL_0724: Expected I, but got Obj
			//IL_0737: Unknown result type (might be due to invalid IL or missing references)
			//IL_073c: Expected Obj, but got Unknown
			//IL_05ac: Expected Obj, but got I
			//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bf: Expected VT, but got Unknown
			//IL_05d0: Expected Ref, but got VT
			//IL_05d8: Expected Obj, but got Ref
			//IL_05e8: Expected Obj, but got VT
			//IL_0762: Expected Obj, but got I4
			//IL_076a: Expected Obj, but got Ref
			//IL_0788: Expected I4, but got I8
			//IL_07b9: Expected Obj, but got I4
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Expected VT, but got Unknown
			//IL_07ee: Expected Ref, but got VT
			//IL_0803: Expected I, but got Obj
			//IL_0813: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
			object obj3 = 0;
			_003C_003CRun_ReversePing_003Eb__0_003Ed obj11;
			nint num = default;
			object obj12 = default;
			string text2 = default;
			NetAddress netAddress = default;
			if (_003C_003E1__state != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v37+A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v38+E0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v38+E0]");
				if ((nint)0 != 0)
				{
					_003C_003Ec__DisplayClass114_0 obj8 = _003C_003E4__this;
					NullReferenceException ex;
					if (_003C_003E4__this != null)
					{
						CloudServices cloudServices = obj8._003C_003E4__this;
						bool flag = (object)obj8._003C_003E4__this == null;
						ex = (NullReferenceException)(object)this;
						if (!flag)
						{
							netAddress = obj8.remoteAddr;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5568]");
							object format = 0;
							object obj10 = default;
							string text = string.Format((string)format, obj10);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X25_v7+10]");
							obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X25_v7+10]");
							bool flag2 = (nint)0 == 0;
							text2 = text;
							num = (nint)obj10;
							if (flag2)
							{
								goto IL_025c;
							}
							nint num2 = (nint)obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v49 (Il2CppClass<Fusion.CloudServices+<<Run_ReversePing>b__0>d>)+190]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X25_v7+10]");
							bool flag3 = ((UnityEngine.Object)0).Equals(cloudServices._runner);
							text2 = text;
							num = (nint)cloudServices._runner;
							goto IL_0935;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
						bool flag4 = num3 != 0;
						obj11 = this;
						if (flag4)
						{
							goto IL_08cc;
						}
						ex = new NullReferenceException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
					bool flag5 = num4 != 0;
					obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)(object)ex;
					if (!flag5)
					{
						NullReferenceException ex2 = new NullReferenceException();
						obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)(object)ex2;
						goto IL_025c;
					}
					goto IL_08cc;
				}
				goto IL_0935;
			}
			_003C_003Eu__1 = (TaskAwaiter)0;
			_003C_003E1__state = -1;
			TaskAwaiter awaiter = _003C_003Eu__1;
			goto IL_0452;
			IL_025c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			NullReferenceException ex3;
			if (num5 == 0)
			{
				ex3 = new NullReferenceException();
				goto IL_06cb;
			}
			goto IL_08cc;
			IL_04b4:
			object obj13 = obj;
			_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v28+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(this + 24);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetResult();
			num = unchecked((nint)null);
			obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)asyncTaskMethodBuilder;
			goto IL_05ed;
			IL_08cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0299:
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v35+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CancellationToken cancellationToken = (CancellationToken)(this + 48);
			((CancellationToken*)cancellationToken)->ThrowIfCancellationRequested();
			_003C_003Ec__DisplayClass114_0 obj17 = _003C_003E4__this;
			NetAddress netAddress2;
			object obj18;
			string text3;
			nint num6;
			if (_003C_003E4__this != null)
			{
				netAddress2 = obj17.remoteAddr;
				NetAddress netAddress3 = default;
				bool flag8 = _003C_003E4__this._003CRun_ReversePing_003Eg__SendPing_007C1((NetAddress)(&netAddress3));
				bool flag9 = !flag8;
				obj18 = obj12;
				text3 = text2;
				num6 = (nint)(&netAddress3);
				if (flag9)
				{
					goto IL_04b4;
				}
				object obj19 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v43+E4]");
				bool flag10 = (nint)0 == 0;
				object obj20 = !flag10;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Task task = TaskManager.Delay(100, token);
				bool flag11 = task == null;
				text2 = null;
				num = (nint)token;
				netAddress = netAddress2;
				obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)(object)task;
				if (!flag11)
				{
					TaskAwaiter awaiter2 = task.GetAwaiter();
					bool isCompleted = awaiter.IsCompleted;
					bool flag12 = !isCompleted;
					text2 = null;
					netAddress = netAddress2;
					if (!flag12)
					{
						goto IL_0452;
					}
					object obj21 = this + 72;
					obj21 = _003C_003Eu__1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj22 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v53+E4]");
					bool flag13 = (nint)0 == 0;
					object obj23 = !flag13;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5560]");
					object obj24 = 0;
					obj18 = obj24;
					AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(this + 24);
					System.__Canon stateMachine = default;
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
					text3 = (string)(&stateMachine);
					num = (nint)(&awaiter);
					obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)asyncTaskMethodBuilder2;
					goto IL_05ed;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				bool flag14 = num7 != 0;
				num = unchecked((nint)null);
				obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)(object)_003C_003E4__this;
				if (flag14)
				{
					goto IL_08cc;
				}
				NullReferenceException ex4 = new NullReferenceException();
				num = unchecked((nint)null);
				obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)(object)ex4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			if (num8 == 0)
			{
				ex3 = new NullReferenceException();
				goto IL_06cb;
			}
			goto IL_08cc;
			IL_0452:
			awaiter.GetResult();
			bool flag15 = ++_003Ci_003E5__1 < 10;
			num = unchecked((nint)null);
			obj18 = obj12;
			text3 = text2;
			num6 = unchecked((nint)null);
			netAddress2 = netAddress;
			if (flag15)
			{
				goto IL_0299;
			}
			goto IL_04b4;
			IL_0935:
			_003Ci_003E5__1 = 0;
			goto IL_0299;
			IL_06cb:
			bool flag16 = num != 1;
			obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)(object)ex3;
			NullReferenceException ex5 = ex3;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj26 = default;
				object obj25 = obj26;
				num = (nint)obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj28 = default;
				object obj27 = obj28 & 1;
				if (obj27 != null)
				{
					object obj29 = 0;
					object obj31 = default;
					object obj30 = (object)(&obj31);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v22+E4]");
					bool flag17 = (nint)0 == 0;
					object obj32 = !flag17;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetException((Exception)obj26);
					obj18 = obj12;
					text3 = null;
					num = (nint)obj26;
					netAddress2 = netAddress;
					obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)asyncTaskMethodBuilder3;
					goto IL_05ed;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				obj11 = (_003C_003CRun_ReversePing_003Eb__0_003Ed)obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				if (num9 != 0)
				{
					goto IL_08cc;
				}
				num = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				text2 = null;
				NullReferenceException ex6 = default;
				ex5 = ex6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			if (num10 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			}
			goto IL_08cc;
			IL_05ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
			bool flag18 = num11 != 0;
			obj12 = obj18;
			text2 = text3;
			netAddress = netAddress2;
			if (!flag18)
			{
				return;
			}
			goto IL_08cc;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private static class ErrorMessages
	{
		public const string StartBeforeJoin = null;

		public const string RunnerFailInit = null;

		public const string JoinTimeout = null;
	}

	private sealed class _003C_003CHandleReflexiveInfoMessage_003Eb__98_0_003Ed : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken token;

		public CloudServices _003C_003E4__this;

		private int _003Ctimeout_003E5__1;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_048c: Expected Obj, but got I
			//IL_049c: Expected Obj, but got I
			//IL_0020: Expected VT, but got I4
			//IL_002f: Expected I4, but got I8
			//IL_0153: Expected I, but got Obj
			//IL_01e9: Expected I4, but got I8
			//IL_020b: Expected Obj, but got I4
			//IL_0356: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected Obj, but got Unknown
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected VT, but got Unknown
			//IL_023c: Expected Ref, but got VT
			//IL_009f: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I4
			//IL_00f2: Expected I, but got VT
			//IL_0455: Expected Obj, but got I4
			//IL_0381: Expected Obj, but got I4
			//IL_0389: Expected Obj, but got Ref
			//IL_03a7: Expected I4, but got I8
			//IL_03d8: Expected Obj, but got I4
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Expected VT, but got Unknown
			//IL_040d: Expected Ref, but got VT
			//IL_0137: Expected Obj, but got I4
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Expected Obj, but got Unknown
			//IL_0256: Expected Obj, but got VT
			//IL_0290: Expected Obj, but got I4
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Expected VT, but got Unknown
			//IL_02ca: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
			object obj2 = 0;
			if (_003C_003E1__state != 0)
			{
				_003Ctimeout_003E5__1 = 10;
				goto IL_0158;
			}
			_003C_003Eu__1 = (TaskAwaiter)0;
			_003C_003E1__state = -1;
			TaskAwaiter awaiter = _003C_003Eu__1;
			goto IL_0145;
			IL_02ec:
			NullReferenceException ex = new NullReferenceException();
			nint num = default;
			bool flag = num != 1;
			NullReferenceException ex2 = ex;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj4 = default;
				object obj3 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj6 = default;
				object obj5 = obj6 & 1;
				if (obj5 != null)
				{
					object obj7 = 0;
					object obj9 = default;
					object obj8 = (object)(&obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v22+E4]");
					bool flag2 = (nint)0 == 0;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetException((Exception)obj4);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj11 = obj4;
				num = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj12 = 0;
				NullReferenceException ex3 = default;
				ex2 = ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0145:
			awaiter.GetResult();
			num = unchecked((nint)null);
			goto IL_0158;
			IL_0158:
			CloudServices cloudServices = _003C_003E4__this;
			if ((object)_003C_003E4__this != null)
			{
				CloudServicesMetadata metadata = cloudServices._metadata;
				if (cloudServices._metadata != null)
				{
					if (metadata.RemoteReflexiveInfo__BackingField == null)
					{
						int num2 = _003Ctimeout_003E5__1 - 1;
						if (num2 >= 1)
						{
							object obj13 = obj2;
							_003Ctimeout_003E5__1 = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v34+E4]");
							bool flag3 = (nint)0 == 0;
							object obj14 = !flag3;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Task task = TaskManager.Delay(10, token);
							bool flag4 = task == null;
							object obj12 = 0;
							num = (nint)token;
							if (!flag4)
							{
								TaskAwaiter awaiter2 = task.GetAwaiter();
								bool isCompleted = awaiter.IsCompleted;
								bool flag5 = !isCompleted;
								obj12 = 0;
								if (!flag5)
								{
									goto IL_0145;
								}
								object obj15 = this + 72;
								obj15 = _003C_003Eu__1;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj16 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v44+E4]");
								bool flag6 = (nint)0 == 0;
								object obj17 = !flag6;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(this + 24);
								System.__Canon stateMachine = default;
								((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
								return;
							}
							goto IL_02ec;
						}
					}
					object obj18 = obj;
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v30+E4]");
					bool flag7 = (nint)0 == 0;
					object obj19 = !flag7;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetResult();
					return;
				}
			}
			else
			{
				NullReferenceException ex4 = new NullReferenceException();
			}
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_02ec;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003C_003CMoveSessionToNewRoom_003Eg__RejoinSession_007C117_1_003Ed : Action<GetPublisherDataResult>
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameMode gameMode;

		public CancellationToken cancellationToken;

		public string targetSession;

		public CloudServices _003C_003E4__this;

		private RejoinMetadata _003CrejoinMetadata_003E5__1;

		private short _003CenterRoomResult_003E5__2;

		private int _003CplayerRefCountOverride_003E5__3;

		private ShutdownReason _003Cresult_003E5__4;

		private short _003C_003Es__5;

		private IEnumerator<PlayerRef> _003C_003Es__6;

		private PlayerRef _003Cref_003E5__7;

		private ShutdownReason _003C_003Es__8;

		private Exception _003Ce_003E5__9;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<short> _003C_003Eu__2;

		private TaskAwaiter<ShutdownReason> _003C_003Eu__3;

		private unsafe void MoveNext()
		{
			//IL_3978: Expected Obj, but got I
			//IL_158d: Expected VT, but got I4
			//IL_159c: Expected I4, but got I8
			//IL_15af: Expected VT, but got I4
			//IL_15b7: Expected I4, but got VT
			//IL_15bf: Expected VT, but got Ref
			//IL_15c7: Expected I8, but got Obj
			//IL_15d0: Expected VT, but got I4
			//IL_15dd: Expected I4, but got I8
			//IL_21ab: Expected Obj, but got I
			//IL_21d0: Expected Obj, but got I4
			//IL_21d9: Expected Obj, but got I4
			//IL_21e3: Expected I, but got Obj
			//IL_21ec: Expected VT, but got I4
			//IL_21f4: Expected Obj, but got Ref
			//IL_0eb9: Expected VT, but got I4
			//IL_0ec8: Expected I4, but got I8
			//IL_0eda: Expected VT, but got Ref
			//IL_0ee7: Expected I4, but got I8
			//IL_2b5c: Expected VT, but got I4
			//IL_0160: Expected Obj, but got I4
			//IL_0169: Expected Obj, but got I4
			//IL_0172: Expected VT, but got I4
			//IL_0180: Expected VT, but got I4
			//IL_0188: Expected VT, but got Ref
			//IL_0191: Expected VT, but got I4
			//IL_019a: Expected VT, but got I4
			//IL_3a6d: Expected Obj, but got I4
			//IL_3a76: Expected Obj, but got I4
			//IL_3a7f: Expected VT, but got I4
			//IL_3a89: Expected I, but got Obj
			//IL_3a92: Expected VT, but got I4
			//IL_3a9b: Expected VT, but got I4
			//IL_3aa3: Expected Obj, but got Ref
			//IL_2212: Expected Obj, but got I
			//IL_2237: Expected Obj, but got I4
			//IL_2240: Expected Obj, but got I4
			//IL_224d: Expected VT, but got I4
			//IL_2252: Expected I, but got Obj
			//IL_225b: Expected VT, but got I4
			//IL_2263: Expected Obj, but got Ref
			//IL_2ef2: Expected I8, but got Obj
			//IL_00d9: Expected VT, but got I4
			//IL_00e8: Expected I4, but got I8
			//IL_00f1: Expected VT, but got I4
			//IL_00fa: Expected VT, but got I4
			//IL_0102: Expected I4, but got VT
			//IL_010a: Expected VT, but got Ref
			//IL_0112: Expected I8, but got Obj
			//IL_0125: Expected VT, but got I4
			//IL_0132: Expected I4, but got I8
			//IL_2c70: Expected I8, but got Obj
			//IL_2b7b: Expected VT, but got I4
			//IL_01d9: Expected Obj, but got I4
			//IL_01e2: Expected Obj, but got I4
			//IL_01eb: Expected VT, but got I4
			//IL_01f9: Expected VT, but got I4
			//IL_0201: Expected VT, but got Ref
			//IL_020a: Expected VT, but got I4
			//IL_0213: Expected VT, but got I4
			//IL_23c3: Expected Obj, but got I
			//IL_23e5: Expected Obj, but got I
			//IL_23f5: Expected Obj, but got I
			//IL_2414: Expected I4, but got VT
			//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efa: Expected Obj, but got Unknown
			//IL_0f19: Expected VT, but got Ref
			//IL_0f19: Expected Obj, but got I
			//IL_0051: Expected VT, but got I4
			//IL_0060: Expected I4, but got I8
			//IL_0069: Expected VT, but got I4
			//IL_0071: Expected VT, but got Ref
			//IL_0088: Expected I4, but got I8
			//IL_2296: Expected Obj, but got I4
			//IL_229f: Expected Obj, but got I4
			//IL_22ac: Expected VT, but got I4
			//IL_22b1: Expected I, but got Obj
			//IL_22ba: Expected VT, but got I4
			//IL_22ca: Expected Obj, but got I
			//IL_2f37: Expected I8, but got Obj
			//IL_3f32: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f37: Expected Obj, but got Unknown
			//IL_3f4f: Expected Obj, but got I4
			//IL_3f58: Expected Obj, but got I4
			//IL_3f66: Expected I8, but got I4
			//IL_3f6b: Expected I, but got Obj
			//IL_2c8f: Expected I8, but got Obj
			//IL_0f3f: Expected Obj, but got I4
			//IL_0f48: Expected Obj, but got I4
			//IL_0f51: Expected VT, but got I4
			//IL_0f5f: Expected I8, but got I4
			//IL_0f70: Expected VT, but got I4
			//IL_0f79: Expected VT, but got I4
			//IL_0fee: Expected Obj, but got I
			//IL_0ff6: Expected I, but got Obj
			//IL_1013: Expected I8, but got I
			//IL_103a: Expected Obj, but got I
			//IL_104a: Expected Obj, but got I
			//IL_1069: Expected I4, but got VT
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected Obj, but got Unknown
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected Obj, but got Unknown
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected Obj, but got Unknown
			//IL_252b: Expected VT, but got I4
			//IL_2534: Expected Obj, but got I4
			//IL_243a: Expected Obj, but got I
			//IL_2454: Expected Obj, but got I
			//IL_2464: Expected Obj, but got I
			//IL_3ad6: Expected Obj, but got I4
			//IL_3adf: Expected Obj, but got I4
			//IL_3ae8: Expected VT, but got I4
			//IL_3af5: Expected I8, but got Obj
			//IL_3afe: Expected VT, but got I4
			//IL_3b0e: Expected Obj, but got I
			//IL_22e8: Expected Obj, but got I
			//IL_22f0: Expected I, but got Obj
			//IL_2301: Expected Obj, but got I
			//IL_2322: Expected Obj, but got I4
			//IL_232b: Expected Obj, but got I4
			//IL_2338: Expected VT, but got I4
			//IL_2340: Expected Obj, but got I8
			//IL_2349: Expected VT, but got I4
			//IL_2f56: Expected I8, but got Obj
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Expected Obj, but got Unknown
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Expected Obj, but got Unknown
			//IL_02b5: Expected Obj, but got I
			//IL_3e4e: Expected Obj, but got Ref
			//IL_3e5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e60: Expected Obj, but got Unknown
			//IL_248e: Expected Obj, but got I
			//IL_24b3: Expected Obj, but got I4
			//IL_24bc: Expected Obj, but got I4
			//IL_24ca: Expected VT, but got I4
			//IL_24d2: Expected VT, but got I4
			//IL_24da: Expected I8, but got Obj
			//IL_24e2: Expected I, but got Obj
			//IL_109c: Expected Obj, but got I
			//IL_2bfd: Expected Obj, but got I8
			//IL_2c2b: Expected I8, but got Obj
			//IL_02d4: Expected Obj, but got I
			//IL_02dc: Expected I8, but got Obj
			//IL_02ff: Expected VT, but got I
			//IL_030f: Expected Obj, but got I
			//IL_0341: Expected Obj, but got I4
			//IL_034a: Expected Obj, but got I4
			//IL_0353: Expected VT, but got I4
			//IL_0361: Expected VT, but got I4
			//IL_0366: Expected I, but got Obj
			//IL_036f: Expected VT, but got I4
			//IL_0378: Expected VT, but got I4
			//IL_038a: Expected Obj, but got Ref
			//IL_27e9: Expected Obj, but got I4
			//IL_0fc8: Expected Obj, but got I4
			//IL_11c8: Expected Obj, but got I
			//IL_11d8: Expected Obj, but got I
			//IL_1203: Expected Obj, but got I4
			//IL_120c: Expected Obj, but got I4
			//IL_1215: Expected VT, but got I4
			//IL_1222: Expected I8, but got Obj
			//IL_122b: Expected VT, but got I4
			//IL_123b: Expected Obj, but got I
			//IL_10bb: Expected Obj, but got I
			//IL_10cb: Expected Obj, but got I
			//IL_10f0: Expected Obj, but got I
			//IL_1115: Expected Obj, but got I4
			//IL_111e: Expected Obj, but got I4
			//IL_1127: Expected VT, but got I4
			//IL_1135: Expected VT, but got I4
			//IL_113d: Expected VT, but got I4
			//IL_114d: Expected I, but got Obj
			//IL_1156: Expected VT, but got I4
			//IL_271d: Expected VT, but got Ref
			//IL_2725: Expected Obj, but got VT
			//IL_2735: Expected Obj, but got I
			//IL_2501: Expected Obj, but got I
			//IL_15f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_15fb: Expected Obj, but got Unknown
			//IL_162f: Expected Obj, but got I4
			//IL_2ead: Expected I8, but got Obj
			//IL_03a8: Expected Obj, but got I
			//IL_03cd: Expected Obj, but got I4
			//IL_03d6: Expected Obj, but got I4
			//IL_03df: Expected VT, but got I4
			//IL_03ed: Expected VT, but got I4
			//IL_03f2: Expected I, but got Obj
			//IL_03fb: Expected VT, but got I4
			//IL_0404: Expected VT, but got I4
			//IL_0416: Expected Obj, but got Ref
			//IL_2819: Expected Obj, but got I4
			//IL_2e7f: Expected Obj, but got I8
			//IL_165c: Expected Obj, but got I
			//IL_1664: Expected VT, but got Obj
			//IL_166d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1672: Expected VT, but got Unknown
			//IL_1683: Expected Ref, but got VT
			//IL_168c: Expected VT, but got I4
			//IL_169c: Expected I4, but got VT
			//IL_16b5: Expected VT, but got I4
			//IL_126e: Expected Obj, but got I4
			//IL_1277: Expected Obj, but got I4
			//IL_1280: Expected VT, but got I4
			//IL_128d: Expected I4, but got VT
			//IL_1295: Expected VT, but got I4
			//IL_129d: Expected I8, but got Obj
			//IL_12a6: Expected VT, but got I4
			//IL_12b6: Expected Obj, but got I
			//IL_116c: Expected I, but got Obj
			//IL_117c: Expected Obj, but got I
			//IL_118d: Expected Obj, but got I
			//IL_119a: Expected VT, but got I4
			//IL_11aa: Expected I, but got Obj
			//IL_254d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2552: Expected Obj, but got Unknown
			//IL_2586: Expected Obj, but got I4
			//IL_2772: Expected Obj, but got I
			//IL_26f6: Expected Obj, but got I4
			//IL_26ff: Expected Obj, but got I4
			//IL_2707: Expected Obj, but got VT
			//IL_2710: Expected Obj, but got I4
			//IL_2ae1: Expected I4, but got VT
			//IL_2ae9: Expected VT, but got I4
			//IL_2b17: Expected VT, but got I4
			//IL_25b3: Expected Obj, but got I
			//IL_25bb: Expected VT, but got Obj
			//IL_25c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25c9: Expected VT, but got Unknown
			//IL_25da: Expected Ref, but got VT
			//IL_25ea: Expected I4, but got VT
			//IL_0434: Expected Obj, but got I
			//IL_0459: Expected Obj, but got I4
			//IL_0462: Expected Obj, but got I4
			//IL_046b: Expected VT, but got I4
			//IL_0479: Expected VT, but got I4
			//IL_047e: Expected I, but got Obj
			//IL_0487: Expected VT, but got I4
			//IL_0490: Expected VT, but got I4
			//IL_04a2: Expected Obj, but got Ref
			//IL_12d5: Expected Obj, but got I
			//IL_12f0: Expected VT, but got I4
			//IL_12f8: Expected I8, but got Obj
			//IL_12fd: Expected I, but got Obj
			//IL_1305: Expected Obj, but got I4
			//IL_28b0: Expected Obj, but got I4
			//IL_27bb: Expected Obj, but got I
			//IL_27ca: Expected I, but got Obj
			//IL_3b2c: Expected Obj, but got I
			//IL_3b51: Expected Obj, but got I4
			//IL_3b5a: Expected Obj, but got I4
			//IL_3b63: Expected VT, but got I4
			//IL_3b71: Expected VT, but got I4
			//IL_04c0: Expected Obj, but got I
			//IL_04e5: Expected Obj, but got I4
			//IL_04ee: Expected Obj, but got I4
			//IL_04f7: Expected VT, but got I4
			//IL_0505: Expected VT, but got I4
			//IL_050a: Expected I, but got Obj
			//IL_0513: Expected VT, but got I4
			//IL_051c: Expected VT, but got I4
			//IL_28d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_28db: Expected VT, but got Unknown
			//IL_28e4: Expected Ref, but got VT
			//IL_28e9: Expected I, but got Obj
			//IL_28f1: Expected Obj, but got VT
			//IL_1323: Expected Obj, but got I
			//IL_1348: Expected Obj, but got I4
			//IL_1351: Expected Obj, but got I4
			//IL_135a: Expected VT, but got I4
			//IL_1367: Expected I8, but got Obj
			//IL_136c: Expected I, but got Obj
			//IL_1375: Expected VT, but got I4
			//IL_137d: Expected Obj, but got I4
			//IL_1da4: Expected Obj, but got I4
			//IL_1dad: Expected Obj, but got I4
			//IL_1db6: Expected VT, but got I4
			//IL_1dc4: Expected VT, but got I4
			//IL_055a: Expected Obj, but got I
			//IL_056a: Expected Obj, but got I
			//IL_0584: Expected Obj, but got I
			//IL_05a9: Expected Obj, but got I4
			//IL_05b2: Expected Obj, but got I4
			//IL_05bb: Expected VT, but got I4
			//IL_05c9: Expected VT, but got I4
			//IL_05d2: Expected VT, but got I4
			//IL_05db: Expected VT, but got I4
			//IL_139b: Expected VT, but got I
			//IL_13c0: Expected Obj, but got I4
			//IL_13c9: Expected Obj, but got I4
			//IL_13d2: Expected VT, but got I4
			//IL_13df: Expected I8, but got Obj
			//IL_13e4: Expected I, but got Obj
			//IL_13ed: Expected VT, but got I4
			//IL_13f5: Expected Obj, but got I4
			//IL_1de2: Expected Obj, but got I
			//IL_1dea: Expected I, but got Obj
			//IL_0603: Expected VT, but got I
			//IL_0613: Expected I8, but got I
			//IL_062d: Expected Obj, but got I
			//IL_063d: Expected Obj, but got I
			//IL_064d: Expected VT, but got Obj
			//IL_066b: Expected VT, but got I
			//IL_1e1e: Expected VT, but got I
			//IL_1e43: Expected Obj, but got I4
			//IL_1e4c: Expected Obj, but got I4
			//IL_1e55: Expected VT, but got I4
			//IL_1e63: Expected I8, but got I4
			//IL_1e6c: Expected VT, but got I4
			//IL_1e74: Expected Obj, but got I8
			//IL_1413: Expected VT, but got I
			//IL_0695: Expected Obj, but got I4
			//IL_069e: Expected Obj, but got I4
			//IL_06a7: Expected VT, but got I4
			//IL_06b5: Expected VT, but got I4
			//IL_06be: Expected F4, but got I4
			//IL_06c6: Expected I8, but got Obj
			//IL_06df: Expected VT, but got I4
			//IL_06e8: Expected VT, but got I4
			//IL_3ba4: Expected Obj, but got I4
			//IL_3bad: Expected Obj, but got I4
			//IL_3bb6: Expected VT, but got I4
			//IL_3bc3: Expected I8, but got Obj
			//IL_3bc8: Expected I, but got Obj
			//IL_3bd1: Expected VT, but got I4
			//IL_3be1: Expected Obj, but got I
			//IL_1e92: Expected Obj, but got I
			//IL_1eb7: Expected Obj, but got I4
			//IL_1ec0: Expected Obj, but got I4
			//IL_1ec9: Expected VT, but got I4
			//IL_1ed7: Expected I8, but got I4
			//IL_1ee0: Expected VT, but got I4
			//IL_1ee8: Expected Obj, but got I8
			//IL_0723: Expected Obj, but got I
			//IL_073d: Expected Obj, but got I
			//IL_0755: Expected Obj, but got I
			//IL_0765: Expected Obj, but got I
			//IL_1466: Expected Obj, but got I
			//IL_1487: Expected Obj, but got I4
			//IL_1490: Expected Obj, but got I4
			//IL_1499: Expected VT, but got I4
			//IL_14a6: Expected I8, but got Obj
			//IL_14ab: Expected I, but got Obj
			//IL_14b4: Expected VT, but got I4
			//IL_39a7: Expected Obj, but got I
			//IL_39cc: Expected Obj, but got I4
			//IL_39d5: Expected Obj, but got I4
			//IL_39de: Expected VT, but got I4
			//IL_39ec: Expected VT, but got I4
			//IL_39f5: Expected F4, but got I4
			//IL_39fd: Expected I8, but got Obj
			//IL_3a05: Expected I, but got Obj
			//IL_3a0e: Expected VT, but got I4
			//IL_3a17: Expected VT, but got I4
			//IL_3a31: Expected Obj, but got I
			//IL_1f1b: Expected Obj, but got I4
			//IL_1f24: Expected Obj, but got I4
			//IL_1f2d: Expected VT, but got I4
			//IL_1f3b: Expected I8, but got I4
			//IL_1f44: Expected VT, but got I4
			//IL_1f54: Expected Obj, but got I
			//IL_07a2: Expected Obj, but got I
			//IL_07b2: Expected VT, but got I
			//IL_07cb: Expected Obj, but got I
			//IL_07cb: Expected Obj, but got VT
			//IL_07df: Expected Obj, but got I
			//IL_0804: Expected Obj, but got I4
			//IL_080d: Expected Obj, but got I4
			//IL_0816: Expected VT, but got I4
			//IL_0824: Expected VT, but got I4
			//IL_082d: Expected F4, but got I4
			//IL_0836: Expected VT, but got I4
			//IL_0846: Expected I8, but got I
			//IL_084e: Expected I, but got VT
			//IL_0857: Expected VT, but got I4
			//IL_0860: Expected VT, but got I4
			//IL_14d2: Expected I, but got Obj
			//IL_14e2: Expected Obj, but got I
			//IL_14f2: Expected Obj, but got I
			//IL_0b5c: Expected Obj, but got I4
			//IL_0b65: Expected Obj, but got I4
			//IL_0b6e: Expected VT, but got I4
			//IL_0b7c: Expected VT, but got I4
			//IL_0b85: Expected F4, but got I4
			//IL_0b8d: Expected I8, but got Obj
			//IL_0b95: Expected I, but got Obj
			//IL_0b9e: Expected VT, but got I4
			//IL_0ba7: Expected VT, but got I4
			//IL_0bc1: Expected Obj, but got I
			//IL_1f93: Expected Obj, but got I
			//IL_0890: Expected Obj, but got I
			//IL_08b5: Expected Obj, but got I4
			//IL_08be: Expected Obj, but got I4
			//IL_08c7: Expected VT, but got I4
			//IL_08d5: Expected VT, but got I4
			//IL_08de: Expected F4, but got I4
			//IL_08e7: Expected VT, but got I4
			//IL_08f7: Expected I8, but got I
			//IL_08ff: Expected I, but got VT
			//IL_0908: Expected VT, but got I4
			//IL_0911: Expected VT, but got I4
			//IL_3c2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c31: Expected Obj, but got Unknown
			//IL_3c4b: Expected Obj, but got I
			//IL_3c6a: Expected VT, but got Ref
			//IL_3c72: Expected I8, but got Obj
			//IL_152d: Expected Obj, but got I
			//IL_0bfe: Expected Obj, but got I4
			//IL_0c07: Expected Obj, but got I4
			//IL_0c10: Expected VT, but got I4
			//IL_0c1e: Expected VT, but got I4
			//IL_0c27: Expected F4, but got I4
			//IL_0c2f: Expected I8, but got Obj
			//IL_0c37: Expected I, but got Obj
			//IL_0c40: Expected VT, but got I4
			//IL_0c49: Expected VT, but got I4
			//IL_0c63: Expected Obj, but got I
			//IL_3eaa: Expected VT, but got I
			//IL_3eaa: Expected Obj, but got I
			//IL_3ed3: Expected Obj, but got I4
			//IL_3edc: Expected Obj, but got I4
			//IL_3ee5: Expected VT, but got I4
			//IL_3ef2: Expected VT, but got I4
			//IL_3f13: Expected VT, but got I4
			//IL_1fc4: Expected Obj, but got I
			//IL_1fe9: Expected Obj, but got I4
			//IL_1ff2: Expected Obj, but got I4
			//IL_1ffb: Expected VT, but got I4
			//IL_2009: Expected I8, but got I4
			//IL_200e: Expected I, but got Obj
			//IL_2017: Expected VT, but got I4
			//IL_201f: Expected Obj, but got I4
			//IL_0941: Expected Obj, but got I
			//IL_0966: Expected Obj, but got I4
			//IL_096f: Expected Obj, but got I4
			//IL_0978: Expected VT, but got I4
			//IL_0986: Expected VT, but got I4
			//IL_098f: Expected F4, but got I4
			//IL_0998: Expected VT, but got I4
			//IL_09a8: Expected I8, but got I
			//IL_09b0: Expected I, but got VT
			//IL_09b9: Expected VT, but got I4
			//IL_09c2: Expected VT, but got I4
			//IL_32f9: Expected VT, but got I4
			//IL_16f3: Expected Obj, but got I
			//IL_171c: Expected VT, but got Ref
			//IL_16cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d0: Expected Obj, but got Unknown
			//IL_16d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16de: Expected Obj, but got Unknown
			//IL_0c8e: Expected VT, but got I
			//IL_0cc0: Expected VT, but got I
			//IL_0cc0: Expected Obj, but got I
			//IL_0cc0: Expected Obj, but got I
			//IL_0ce1: Expected Obj, but got I4
			//IL_0cea: Expected Obj, but got I4
			//IL_0cf3: Expected VT, but got I4
			//IL_0d01: Expected VT, but got I4
			//IL_0d0a: Expected F4, but got I4
			//IL_0d12: Expected I4, but got VT
			//IL_0d1f: Expected I8, but got Obj
			//IL_0d38: Expected VT, but got I4
			//IL_0d41: Expected VT, but got I4
			//IL_203d: Expected Obj, but got I
			//IL_2062: Expected Obj, but got I4
			//IL_206b: Expected Obj, but got I4
			//IL_2074: Expected VT, but got I4
			//IL_2082: Expected I8, but got I4
			//IL_2087: Expected I, but got Obj
			//IL_2090: Expected VT, but got I4
			//IL_2098: Expected Obj, but got I4
			//IL_4003: Expected Obj, but got I
			//IL_153b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1540: Expected Obj, but got Unknown
			//IL_1549: Unknown result type (might be due to invalid IL or missing references)
			//IL_154e: Expected Obj, but got Unknown
			//IL_3183: Expected I4, but got VT
			//IL_09f2: Expected Obj, but got I
			//IL_0a02: Expected VT, but got I
			//IL_0a1b: Expected Obj, but got I
			//IL_0a1b: Expected Obj, but got VT
			//IL_0a2f: Expected Obj, but got I
			//IL_1793: Expected I8, but got I4
			//IL_0a59: Expected Obj, but got I
			//IL_0a7e: Expected Obj, but got I4
			//IL_0a87: Expected Obj, but got I4
			//IL_0a90: Expected VT, but got I4
			//IL_0a9e: Expected VT, but got I4
			//IL_0aa7: Expected F4, but got I4
			//IL_0ab0: Expected VT, but got I4
			//IL_0ab8: Expected I8, but got Obj
			//IL_0ac0: Expected I, but got Obj
			//IL_0ac9: Expected VT, but got I4
			//IL_0ad2: Expected VT, but got I4
			//IL_261c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2621: Expected Obj, but got Unknown
			//IL_2655: Expected Obj, but got I4
			//IL_20b6: Expected Obj, but got I
			//IL_20db: Expected Obj, but got I4
			//IL_20e4: Expected Obj, but got I4
			//IL_20ed: Expected VT, but got I4
			//IL_20fb: Expected I8, but got I4
			//IL_2100: Expected I, but got Obj
			//IL_2109: Expected VT, but got I4
			//IL_2111: Expected Obj, but got I4
			//IL_3cd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cd5: Expected Obj, but got Unknown
			//IL_1737: Expected VT, but got I
			//IL_0d9a: Expected Obj, but got I4
			//IL_0da3: Expected F4, but got I4
			//IL_2682: Expected Obj, but got I
			//IL_268a: Expected VT, but got Obj
			//IL_2693: Unknown result type (might be due to invalid IL or missing references)
			//IL_2698: Expected VT, but got Unknown
			//IL_26a9: Expected Ref, but got VT
			//IL_26c1: Expected I4, but got VT
			//IL_26da: Expected VT, but got I4
			//IL_3f8f: Expected I4, but got I8
			//IL_0af2: Expected I, but got Obj
			//IL_0b02: Expected Obj, but got I
			//IL_0b13: Expected Obj, but got I
			//IL_0b20: Expected VT, but got I4
			//IL_212f: Expected Obj, but got I
			//IL_3dce: Expected Obj, but got I4
			//IL_3dd7: Expected Obj, but got I4
			//IL_3de3: Expected VT, but got I4
			//IL_3df9: Expected VT, but got I4
			//IL_17d8: Expected Obj, but got I
			//IL_17a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a5: Expected Obj, but got Unknown
			//IL_17ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b3: Expected Obj, but got Unknown
			//IL_17c3: Expected I8, but got Obj
			//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd4: Expected Obj, but got Unknown
			//IL_0e08: Expected Obj, but got I4
			//IL_34f2: Expected I4, but got VT
			//IL_1a07: Expected VT, but got Ref
			//IL_1a0f: Expected Obj, but got VT
			//IL_1a1f: Expected Obj, but got I
			//IL_1745: Unknown result type (might be due to invalid IL or missing references)
			//IL_174a: Expected Obj, but got Unknown
			//IL_1753: Unknown result type (might be due to invalid IL or missing references)
			//IL_1758: Expected VT, but got Unknown
			//IL_0e35: Expected Obj, but got I
			//IL_0e3d: Expected VT, but got Obj
			//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4b: Expected VT, but got Unknown
			//IL_0e5c: Expected Ref, but got VT
			//IL_0e65: Expected VT, but got I4
			//IL_0e76: Expected F4, but got I4
			//IL_0e7e: Expected I4, but got VT
			//IL_0e97: Expected VT, but got I4
			//IL_0ea0: Expected VT, but got I4
			//IL_1815: Expected Obj, but got I
			//IL_1a5c: Expected VT, but got I
			//IL_1a6c: Expected Obj, but got I
			//IL_296c: Expected Obj, but got I4
			//IL_2975: Expected Obj, but got I4
			//IL_2981: Expected VT, but got I4
			//IL_2997: Expected VT, but got I4
			//IL_18ac: Expected I8, but got I4
			//IL_1b03: Expected I8, but got I4
			//IL_3d62: Expected Obj, but got I4
			//IL_1850: Expected VT, but got I
			//IL_1aa7: Expected VT, but got I
			//IL_18f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f6: Expected VT, but got Unknown
			//IL_18ff: Expected Ref, but got VT
			//IL_1921: Expected I, but got Obj
			//IL_1929: Expected Obj, but got I4
			//IL_3e13: Invalid comparison between I and VT
			//IL_3d80: Expected Obj, but got I
			//IL_3da2: Expected Obj, but got I4
			//IL_3db2: Expected Obj, but got I8
			//IL_18b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_18be: Expected Obj, but got Unknown
			//IL_18c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_18cc: Expected Obj, but got Unknown
			//IL_1b10: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b15: Expected Obj, but got Unknown
			//IL_1b1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b23: Expected Obj, but got Unknown
			//IL_196e: Expected Obj, but got I4
			//IL_185e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1863: Expected Obj, but got Unknown
			//IL_186c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1871: Expected VT, but got Unknown
			//IL_1ab5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aba: Expected Obj, but got Unknown
			//IL_1ac3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ac8: Expected VT, but got Unknown
			//IL_1994: Unknown result type (might be due to invalid IL or missing references)
			//IL_1999: Expected VT, but got Unknown
			//IL_19a2: Expected Ref, but got VT
			//IL_19b0: Expected I, but got Obj
			//IL_19b8: Expected Obj, but got I4
			//IL_3582: Expected I, but got Obj
			//IL_3595: Unknown result type (might be due to invalid IL or missing references)
			//IL_359a: Expected Obj, but got Unknown
			//IL_3737: Expected Obj, but got I4
			//IL_3786: Expected Obj, but got I4
			//IL_35bf: Expected Obj, but got Ref
			//IL_35dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_35e1: Expected Obj, but got Unknown
			//IL_37b4: Expected I, but got Obj
			//IL_37c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_37cc: Expected Obj, but got Unknown
			//IL_36f0: Expected I8, but got I4
			//IL_360a: Expected Obj, but got I
			//IL_361a: Expected Obj, but got I
			//IL_3639: Expected I, but got Obj
			//IL_3fb4: Expected I4, but got VT
			//IL_37f1: Expected Obj, but got Ref
			//IL_364f: Expected I, but got Obj
			//IL_366f: Expected I8, but got I
			//IL_3684: Expected Obj, but got I
			//IL_3688: Expected Obj, but got I4
			//IL_38f4: Expected I8, but got I4
			//IL_383b: Expected Obj, but got I4
			//IL_3861: Unknown result type (might be due to invalid IL or missing references)
			//IL_3866: Expected VT, but got Unknown
			//IL_3873: Expected Ref, but got VT
			//IL_387c: Expected I8, but got I4
			//IL_3884: Expected I, but got Obj
			//IL_388c: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			TaskAwaiter awaiter;
			System.__Canon _Canon = default;
			int num;
			TaskAwaiter awaiter2;
			int num2;
			AuthenticationValues authenticationValues = default;
			TaskAwaiter<short> taskAwaiter2;
			CancellationToken cancellationToken = default;
			TaskAwaiter<short> taskAwaiter;
			long num3;
			TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> taskAwaiter3;
			if (_003C_003E1__state <= 1)
			{
				if (_003C_003E1__state == 0)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					awaiter = _003C_003Eu__1;
					taskAwaiter = (TaskAwaiter<short>)(&_Canon);
					num = -1;
					goto IL_3a3f;
				}
				if (_003C_003E1__state == 1)
				{
					_003C_003Eu__2 = (TaskAwaiter<short>)0;
					_003C_003E1__state = -1;
					awaiter = (TaskAwaiter)0;
					taskAwaiter = (TaskAwaiter<short>)(&_Canon);
					taskAwaiter2 = _003C_003Eu__2;
					num = -1;
					goto IL_0fde;
				}
			}
			else
			{
				if (_003C_003E1__state == 2)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					awaiter2 = _003C_003Eu__1;
					awaiter = (TaskAwaiter)0;
					num2 = (int)cancellationToken;
					taskAwaiter = (TaskAwaiter<short>)(&_Canon);
					num3 = (long)authenticationValues;
					taskAwaiter2 = (TaskAwaiter<short>)0;
					num = -1;
					goto IL_2192;
				}
				if (_003C_003E1__state == 3)
				{
					_003C_003Eu__3 = (TaskAwaiter<ShutdownReason>)0;
					_003C_003E1__state = -1;
					awaiter2 = (TaskAwaiter)0;
					awaiter = (TaskAwaiter)0;
					num2 = (int)cancellationToken;
					taskAwaiter = (TaskAwaiter<short>)(&_Canon);
					num3 = (long)authenticationValues;
					taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)_003C_003Eu__3;
					taskAwaiter2 = (TaskAwaiter<short>)0;
					num = -1;
					goto IL_23a5;
				}
			}
			CloudServices cloudServices = _003C_003E4__this;
			bool flag = (object)_003C_003E4__this == null;
			NullReferenceException ex = null;
			object obj2 = 0;
			object obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			System.__Canon stateMachine = null;
			awaiter = (TaskAwaiter)0;
			taskAwaiter = (TaskAwaiter<short>)(&_Canon);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			NullReferenceException ex2 = (NullReferenceException)(object)this;
			if (flag)
			{
				goto IL_2ec9;
			}
			bool flag2 = cloudServices._metadata == null;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			taskAwaiter = (TaskAwaiter<short>)(&_Canon);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			ex2 = (NullReferenceException)(object)this;
			if (flag2)
			{
				goto IL_2f0e;
			}
			object obj4 = this + 80;
			object obj5 = cloudServices._metadata + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
			object obj6 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+38]");
			_ = 0;
			object obj7 = _Canon + 552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = _Canon + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+40]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5970]");
			object obj9 = 0;
			num3 = (long)obj9;
			bool? flag3 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+30]");
			taskAwaiter = (TaskAwaiter<short>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag4 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			nint num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			ex2 = (NullReferenceException)(&flag3);
			if (flag4)
			{
				goto IL_2f5b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2555 @ X9_v171+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2555 @ X9_v171+28]");
			bool flag5 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			ex2 = (NullReferenceException)(&flag3);
			if (flag5)
			{
				goto IL_2f98;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2888 @ X9_v172+2F8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2888 @ X9_v172+2F8]");
			bool flag6 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			ex2 = (NullReferenceException)(&flag3);
			if (flag6)
			{
				goto IL_2fd5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
			ex2 = (NullReferenceException)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
			bool flag7 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			if (flag7)
			{
				goto IL_3012;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3046 @ X9_v173+18]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
			object obj13 = (nint)0 + (nint)80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3046 @ X9_v173+18]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag8 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			if (flag8)
			{
				goto IL_304f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5450]");
			taskAwaiter = (TaskAwaiter<short>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3309 @ X9_v174+28]");
			long num5 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54B0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5440]");
			object obj16 = 0;
			string text = (string)obj15;
			cancellationToken = (CancellationToken)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+38]");
			Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> asyncOperationHandler = default;
			asyncOperationHandler._002Ector((CancellationToken)0, 120f, (string)obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3309 @ X9_v174+28]");
			bool flag9 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			float num6 = 1.1230249E+09f;
			num3 = (long)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+38]");
			num4 = 0;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			ex2 = (NullReferenceException)(object)asyncOperationHandler;
			if (flag9)
			{
				goto IL_308c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3309 @ X9_v174+28]");
			object obj17 = (nint)0 + (nint)792;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3568 @ X8_v254+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3569 @ X8_v255+E0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3569 @ X8_v255+E0]");
			bool flag10 = (nint)0 == 0;
			Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> asyncOperationHandler2 = asyncOperationHandler;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54E0]");
				object format = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54F0]");
				taskAwaiter = (TaskAwaiter<short>)0;
				TaskAwaiter<short> taskAwaiter4 = taskAwaiter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
				string text2 = string.Format((string)format, taskAwaiter4, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
				bool flag11 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				awaiter = (TaskAwaiter)0;
				num6 = 1.1230249E+09f;
				cancellationToken = (CancellationToken)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
				num3 = 0L;
				num4 = (nint)taskAwaiter;
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<short>)0;
				num = _003C_003E1__state;
				ex2 = (NullReferenceException)(object)text2;
				if (flag11)
				{
					goto IL_33fb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3685 @ X8_v265+30]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3685 @ X8_v265+30]");
				bool flag12 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				awaiter = (TaskAwaiter)0;
				num6 = 1.1230249E+09f;
				cancellationToken = (CancellationToken)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
				num3 = 0L;
				num4 = (nint)taskAwaiter;
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<short>)0;
				num = _003C_003E1__state;
				ex2 = (NullReferenceException)(object)text2;
				if (flag12)
				{
					goto IL_3438;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3737 @ X8_v266+38]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3737 @ X8_v266+38]");
				bool flag13 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				awaiter = (TaskAwaiter)0;
				num6 = 1.1230249E+09f;
				cancellationToken = (CancellationToken)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
				num3 = 0L;
				num4 = (nint)taskAwaiter;
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<short>)0;
				num = _003C_003E1__state;
				ex2 = (NullReferenceException)(object)text2;
				if (flag13)
				{
					goto IL_3475;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54A8]");
				object format2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54C8]");
				taskAwaiter = (TaskAwaiter<short>)0;
				TaskAwaiter<short> taskAwaiter5 = taskAwaiter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3806 @ X8_v267+40]");
				string text3 = string.Format((string)format2, taskAwaiter5, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54B8]");
				object obj25 = 0;
				string text4 = (string)obj25 + text2 + text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X20_v72+10]");
				ex2 = (NullReferenceException)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X20_v72+10]");
				bool flag14 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				awaiter = (TaskAwaiter)0;
				num6 = 1.1230249E+09f;
				cancellationToken = (CancellationToken)0;
				num3 = (long)text3;
				num4 = (nint)text4;
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<short>)0;
				num = _003C_003E1__state;
				if (flag14)
				{
					goto IL_34b2;
				}
				nint num7 = (nint)ex2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3627 @ X8_v270 (Il2CppClass<System.NullReferenceException>)+1A0]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X20_v72+10]");
				TypeCode typeCode = ((Enum)0).GetTypeCode();
				cancellationToken = (CancellationToken)0;
				asyncOperationHandler2 = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)text4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			CloudServices cloudServices2 = (CloudServices)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag15 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			num6 = 1.1230249E+09f;
			num3 = (long)text;
			num4 = (nint)asyncOperationHandler2;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			ex2 = (NullReferenceException)0;
			if (flag15)
			{
				goto IL_30c9;
			}
			CloudCommunicator communicator = cloudServices2._communicator;
			bool flag16 = (object)cloudServices2._communicator == null;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			num6 = 1.1230249E+09f;
			num3 = (long)text;
			num4 = (nint)asyncOperationHandler2;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			ex2 = (NullReferenceException)0;
			if (flag16)
			{
				goto IL_3106;
			}
			RealtimeClient realtimeClient = communicator.Client__BackingField;
			bool flag17 = communicator.Client__BackingField == null;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			num6 = 1.1230249E+09f;
			num3 = (long)text;
			num4 = (nint)asyncOperationHandler2;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			ex2 = (NullReferenceException)0;
			if (flag17)
			{
				goto IL_3143;
			}
			authenticationValues = realtimeClient.AuthValues__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+38]");
			cancellationToken = (CancellationToken)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
			nint num9 = 0;
			AuthenticationValues authentication = realtimeClient.AuthValues__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+38]");
			Task task = ((CloudServices)num8).ConnectToCloud((AppSettings)num9, authentication, (CancellationToken)0);
			bool flag18 = task == null;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			awaiter = (TaskAwaiter)0;
			num6 = 1.1230249E+09f;
			ShutdownReason shutdownReason = (ShutdownReason)flag3;
			num3 = (long)realtimeClient.AuthValues__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+58]");
			num4 = 0;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			num = _003C_003E1__state;
			ex2 = (NullReferenceException)(object)task;
			if (flag18)
			{
				goto IL_3188;
			}
			TaskAwaiter awaiter3 = task.GetAwaiter();
			bool isCompleted = awaiter.IsCompleted;
			bool flag19 = !isCompleted;
			object obj26 = !flag19;
			num6 = 1.1230249E+09f;
			num = _003C_003E1__state;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder;
			Unity.IL2CPP.Metadata.__Il2CppInt32Enum _Il2CppInt32Enum;
			if (obj26 == null)
			{
				_ = 0;
				object obj27 = _Canon + 608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4150 @ X0_v307+E4]");
				bool flag20 = (nint)0 == 0;
				object obj29 = !flag20;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5468]");
				object obj30 = 0;
				cancellationToken = (CancellationToken)obj30;
				asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(_Canon + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
				awaiter2 = (TaskAwaiter)0;
				stateMachine = _Canon;
				num6 = 1.1230249E+09f;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)flag3;
				num3 = (nint)(&stateMachine);
				num4 = (nint)(&awaiter);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				taskAwaiter2 = (TaskAwaiter<short>)0;
				num = 0;
				goto IL_26e8;
			}
			goto IL_3a3f;
			IL_2ec9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag21 = num10 != 0;
			num3 = (long)authenticationValues;
			if (!flag21)
			{
				ex2 = new NullReferenceException();
				goto IL_2f0e;
			}
			goto IL_394e;
			IL_3344:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num11 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_3381;
			}
			goto IL_394e;
			IL_2f0e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag22 = num12 != 0;
			num3 = (long)authenticationValues;
			if (!flag22)
			{
				ex2 = new NullReferenceException();
				num3 = (long)authenticationValues;
				goto IL_2f5b;
			}
			goto IL_394e;
			IL_3106:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num13 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_3143;
			}
			goto IL_394e;
			IL_2e84:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag23 = num14 != 0;
			num3 = (long)authenticationValues;
			if (!flag23)
			{
				ex2 = new NullReferenceException();
				goto IL_2ec9;
			}
			goto IL_394e;
			IL_26e8:
			ex = null;
			obj2 = 0;
			obj3 = 0;
			ex2 = (NullReferenceException)asyncTaskMethodBuilder;
			object obj31 = 18;
			goto IL_3e46;
			IL_3202:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num15 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_323f;
			}
			goto IL_394e;
			IL_30c9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num16 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_3106;
			}
			goto IL_394e;
			IL_2926:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num17 == 0)
			{
				ex2 = new NullReferenceException();
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)(int)(&num);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				goto IL_299c;
			}
			goto IL_394e;
			IL_299c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num18 == 0)
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
				shutdownReason = (ShutdownReason)_Il2CppInt32Enum;
				ex2 = (NullReferenceException)(object)ex3;
				goto IL_29e9;
			}
			goto IL_394e;
			IL_3e46:
			object obj32 = (object)(&num);
			object obj33 = obj32 & 0x80000000L;
			if (obj33 == null)
			{
				goto IL_27cf;
			}
			TaskAwaiter<short> taskAwaiter6 = (TaskAwaiter<short>)(&_Canon);
			object obj34 = taskAwaiter6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v13+48]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v13+48]");
			bool flag24 = (nint)0 == 0;
			shutdownReason = (ShutdownReason)_Il2CppInt32Enum;
			if (!flag24)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2943 @ X8_v14+28]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2943 @ X8_v14+28]");
				bool flag25 = (nint)0 == 0;
				shutdownReason = (ShutdownReason)_Il2CppInt32Enum;
				if (!flag25)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2943 @ X8_v14+28]");
					object obj37 = (nint)0 + (nint)792;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num4 = unchecked((nint)null);
					goto IL_27cf;
				}
			}
			goto IL_2a27;
			IL_34b2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			NullReferenceException ex5;
			if (num19 == 0)
			{
				ex2 = new NullReferenceException();
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				if (num20 == 0)
				{
					NullReferenceException ex4 = new NullReferenceException();
					object obj43 = default;
					if (num4 != 2)
					{
						if (num4 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj2 = 1;
						}
						else
						{
							if (num4 != 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A37A0");
								bool flag26 = num4 != 2;
								ex5 = ex4;
								if (flag26)
								{
									goto IL_3910;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								object obj39 = default;
								object obj38 = obj39;
								num4 = (nint)obj38;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
								object obj41 = default;
								object obj40 = obj41 & 1;
								if (obj40 != null)
								{
									object obj42 = (object)(&obj43);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									_ = 4294967294L;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4367 @ X0_v51+E4]");
									bool flag27 = (nint)0 == 0;
									object obj44 = !flag27;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(_Canon + 24);
									((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetException((Exception)obj39);
									num3 = 0L;
									num4 = (nint)obj39;
									ex2 = (NullReferenceException)asyncTaskMethodBuilder2;
									goto IL_28f6;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
								ex2 = (NullReferenceException)obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
								nint num21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
								if (num21 == 0)
								{
									num4 = 101790920;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
									num3 = 0L;
									goto IL_38f9;
								}
								goto IL_394e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							object obj45 = default;
							ex = (NullReferenceException)obj45;
						}
						obj31 = 0;
						goto IL_3e46;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj47 = default;
					object obj46 = obj47;
					num4 = (nint)obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj49 = default;
					object obj48 = obj49 & 1;
					if (obj48 != null)
					{
						object obj50 = (object)(&obj43);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						object obj51 = _Canon + 600;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4338 @ X0_v75+A0]");
						object obj52 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4345 @ X8_v49+20]");
						ex2 = (NullReferenceException)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4345 @ X8_v49+20]");
						bool flag28 = (nint)0 == 0;
						num4 = (nint)obj47;
						if (!flag28)
						{
							nint num22 = (nint)ex2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+258]");
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X9_v14 (Il2CppClass<System.NullReferenceException>)+1E0]");
							num3 = 0L;
							NullReferenceException ex6 = ex2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+258]");
							ex2 = (NullReferenceException)((Enum)(object)ex6).System_002EIConvertible_002EToByte((IFormatProvider)0);
						}
						num2 = (int)cancellationToken;
						goto IL_2523;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					ex2 = (NullReferenceException)obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
					if (num23 == 0)
					{
						num4 = 101790920;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						num3 = 0L;
						goto IL_38f9;
					}
				}
			}
			goto IL_394e;
			IL_29e9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num24 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_2a27;
			}
			goto IL_394e;
			IL_2a27:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num25 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2a64;
			}
			goto IL_394e;
			IL_3475:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num26 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_34b2;
			}
			goto IL_394e;
			IL_2a64:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num27 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2aa1;
			}
			goto IL_394e;
			IL_2aa1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num28 == 0)
			{
				ex2 = new NullReferenceException();
				num2 = (int)cancellationToken;
				flag3 = (bool?)(object)shutdownReason;
				goto IL_2aee;
			}
			goto IL_394e;
			IL_3381:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num29 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_33be;
			}
			goto IL_394e;
			IL_156e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			authenticationValues = null;
			goto IL_3c14;
			IL_3c14:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3592 @ X0_v223] (should have been resolved before IL gen)");
			object obj53 = _Canon + 584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+248]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+248]");
			bool flag29 = (nint)0 == 0;
			taskAwaiter = (TaskAwaiter<short>)(&_Canon);
			num3 = (long)authenticationValues;
			IntPtr intPtr = default;
			num4 = intPtr;
			if (flag29)
			{
				goto IL_19c5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDF8]");
			int num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			int num31 = 0;
			TaskAwaiter<short> taskAwaiter7 = (TaskAwaiter<short>)(&_Canon);
			while (true)
			{
				object obj56 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3786 @ X8_v219+12E]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3786 @ X8_v219+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1780;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3786 @ X8_v219+98]");
				TaskAwaiter<short> taskAwaiter8 = (TaskAwaiter<short>)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3927 @ X10_v92 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)-8]");
					if (0 == (nint)obj55)
					{
						break;
					}
					obj57--;
					taskAwaiter7 = (TaskAwaiter<short>)(taskAwaiter8 + 16);
					bool flag30 = (nint)obj57 != 1;
					taskAwaiter8 = taskAwaiter7;
					if (flag30)
					{
						continue;
					}
					goto IL_1780;
				}
				object obj58 = obj56 + taskAwaiter8;
				object obj59 = obj58 + 312;
				taskAwaiter7 = taskAwaiter8;
				num3 = (long)authenticationValues;
				goto IL_3cad;
				IL_3cad:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3968 @ X0_v248+8]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3968 @ X0_v248] (should have been resolved before IL gen)");
				object obj60 = ex2 & 1;
				bool flag31 = obj60 == null;
				taskAwaiter = taskAwaiter7;
				if (flag31)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+248]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+248]");
				if ((nint)0 == 0)
				{
					goto IL_2926;
				}
				object obj62 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4034 @ X8_v224+12E]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4034 @ X8_v224+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1899;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4034 @ X8_v224+98]");
				TaskAwaiter<short> taskAwaiter9 = (TaskAwaiter<short>)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4156 @ X10_v87 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)-8]");
					if ((nint)0 == ((int*)num30)->m_value)
					{
						break;
					}
					obj63--;
					taskAwaiter7 = (TaskAwaiter<short>)(taskAwaiter9 + 16);
					bool flag32 = (nint)obj63 != 1;
					taskAwaiter9 = taskAwaiter7;
					if (flag32)
					{
						continue;
					}
					goto IL_1899;
				}
				object obj64 = obj62 + taskAwaiter9;
				object obj65 = obj64 + 312;
				taskAwaiter7 = taskAwaiter9;
				goto IL_3d24;
				IL_3d24:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4200 @ X0_v252] (should have been resolved before IL gen)");
				int value = ((int*)num31)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4208 @ X0_v255 (System.Int32)+E4]");
				bool flag33 = (nint)0 == 0;
				object obj66 = !flag33;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = (PlayerRef)(_Canon + 592);
				int asIndex = ((PlayerRef*)playerRef)->AsIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+23C]");
				bool flag34 = (nint)asIndex <= (nint)0;
				num4 = unchecked((nint)null);
				ex2 = (NullReferenceException)asIndex;
				System.__Canon _Canon2 = _Canon;
				if (!flag34)
				{
					int value2 = ((int*)num31)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4247 @ X0_v260 (System.Int32)+E4]");
					bool flag35 = (nint)0 == 0;
					object obj67 = !flag35;
					if (obj67 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef playerRef2 = (PlayerRef)(_Canon + 592);
					int asIndex2 = ((PlayerRef*)playerRef2)->AsIndex;
					num4 = unchecked((nint)null);
					ex2 = (NullReferenceException)asIndex2;
					_Canon2 = _Canon;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4254 @ X19_v86 (System.__Canon)+248]");
				obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4254 @ X19_v86 (System.__Canon)+248]");
				bool flag36 = (nint)0 == 0;
				object obj68 = !flag36;
				taskAwaiter = taskAwaiter7;
				authenticationValues = (AuthenticationValues)num3;
				if (obj68 != null)
				{
					continue;
				}
				goto IL_19c5;
				IL_1899:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num3 = 0L;
				goto IL_3d24;
				IL_1780:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num3 = 0L;
				goto IL_3cad;
			}
			Unity.IL2CPP.Metadata.__Il2CppInt32Enum _Il2CppInt32Enum2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)(int)(&num);
			if ((int)(((Unity.IL2CPP.Metadata.__Il2CppInt32Enum*)(int)_Il2CppInt32Enum2)->value__ & 0x80000000L) != 0)
			{
				TaskAwaiter<short> taskAwaiter10 = (TaskAwaiter<short>)(&_Canon);
				object obj69 = taskAwaiter10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3973 @ X8_v211+248]");
				object obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3973 @ X8_v211+248]");
				if ((nint)0 != 0)
				{
					object obj71 = obj70;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
					taskAwaiter = (TaskAwaiter<short>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4020 @ X8_v212+12E]");
					object obj72 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4020 @ X8_v212+12E]");
					if ((nint)0 == 0)
					{
						goto IL_1af0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4020 @ X8_v212+98]");
					TaskAwaiter<short> taskAwaiter11 = (TaskAwaiter<short>)((nint)0 + (nint)8);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4125 @ X10_v78 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)-8]");
						if ((object)0 == (object)taskAwaiter)
						{
							break;
						}
						obj72--;
						taskAwaiter = (TaskAwaiter<short>)(taskAwaiter11 + 16);
						bool flag37 = (nint)obj72 != 1;
						taskAwaiter11 = taskAwaiter;
						if (flag37)
						{
							continue;
						}
						goto IL_1af0;
					}
					object obj73 = obj71 + taskAwaiter11;
					object obj74 = obj73 + 312;
					taskAwaiter = taskAwaiter11;
					goto IL_3e27;
				}
			}
			goto IL_3dc0;
			IL_27cf:
			bool flag38 = ex == null;
			object obj75 = !flag38;
			ex2 = ex;
			if (obj75 != null)
			{
				goto IL_299c;
			}
			bool flag39 = obj2 == null;
			object obj76 = !flag39;
			shutdownReason = (ShutdownReason)_Il2CppInt32Enum;
			ex2 = ex;
			if (obj76 == null)
			{
				if (obj31 != null)
				{
					bool flag40 = (nint)obj31 != 40;
					ex2 = ex;
					if (flag40)
					{
						goto IL_28f6;
					}
				}
				object obj77 = obj;
				_ = 4294967294L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3147 @ X0_v5+E4]");
				bool flag41 = (nint)0 == 0;
				object obj78 = !flag41;
				if (obj78 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(_Canon + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetResult();
				num4 = unchecked((nint)null);
				ex2 = (NullReferenceException)asyncTaskMethodBuilder3;
				goto IL_28f6;
			}
			goto IL_29e9;
			IL_38f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex7 = default;
			ex5 = ex7;
			goto IL_3910;
			IL_2aee:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag42 = num32 != 0;
			cancellationToken = (CancellationToken)num2;
			if (!flag42)
			{
				ex2 = new NullReferenceException();
				goto IL_2b33;
			}
			goto IL_394e;
			IL_3438:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num33 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_3475;
			}
			goto IL_394e;
			IL_33fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num34 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_3438;
			}
			goto IL_394e;
			IL_2523:
			cancellationToken = (CancellationToken)num2;
			obj31 = 40;
			goto IL_3e46;
			IL_3a3f:
			awaiter.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag43 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			ex2 = (NullReferenceException)(&awaiter);
			if (flag43)
			{
				goto IL_2c47;
			}
			object obj79 = _Canon + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			object obj80 = default;
			Task<short> task2 = ((CloudServices)0).EnterRoom((StartGameArgs)(&obj80));
			bool flag44 = task2 == null;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num3 = 472L;
			num4 = (nint)(&obj80);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			taskAwaiter2 = (TaskAwaiter<short>)0;
			ex2 = (NullReferenceException)(object)task2;
			if (!flag44)
			{
				TaskAwaiter<short> awaiter4 = task2.GetAwaiter();
				TaskAwaiter<short> awaiter5 = default;
				bool isCompleted2 = awaiter5.IsCompleted;
				bool flag45 = !isCompleted2;
				authenticationValues = (AuthenticationValues)472;
				taskAwaiter2 = awaiter5;
				if (!flag45)
				{
					goto IL_0fde;
				}
				_ = 1;
				object obj81 = _Canon + 616;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj82 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3119 @ X0_v22+E4]");
				bool flag46 = (nint)0 == 0;
				object obj83 = !flag46;
				if (obj83 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5458]");
				object obj84 = 0;
				cancellationToken = (CancellationToken)obj84;
				asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(_Canon + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<short>, System.__Canon>(ref awaiter5, ref stateMachine);
				awaiter2 = (TaskAwaiter)0;
				stateMachine = _Canon;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)flag3;
				num3 = (nint)(&stateMachine);
				num4 = (nint)(&awaiter5);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				num = 1;
				goto IL_26e8;
			}
			goto IL_2c94;
			IL_3910:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num35 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			}
			goto IL_394e;
			IL_2b33:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag47 = num36 != 0;
			cancellationToken = (CancellationToken)num2;
			if (!flag47)
			{
				ex2 = new NullReferenceException();
				cancellationToken = (CancellationToken)num2;
				goto IL_2b80;
			}
			goto IL_394e;
			IL_2f5b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num37 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2f98;
			}
			goto IL_394e;
			IL_3143:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num38 == 0)
			{
				ex2 = new NullReferenceException();
				shutdownReason = (ShutdownReason)flag3;
				goto IL_3188;
			}
			goto IL_394e;
			IL_2b80:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num39 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2bbd;
			}
			goto IL_394e;
			IL_19c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num40 == 0)
			{
				throw new NullReferenceException();
			}
			goto IL_394e;
			IL_28f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num41 == 0)
			{
				return;
			}
			goto IL_394e;
			IL_33be:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num42 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_33fb;
			}
			goto IL_394e;
			IL_23a5:
			Unity.IL2CPP.Metadata.__Il2CppInt32Enum result = taskAwaiter3.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj85 = 0;
			object obj86 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2433 @ X9_v112+A0]");
			object obj87 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ X9_v113+E0]");
			object obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ X9_v113+E0]");
			bool flag48 = (nint)0 == 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)flag3;
			System.__Canon _Canon3 = _Canon;
			if (!flag48)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
				object obj89 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54D8]");
				object format3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54D0]");
				object arg = 0;
				object obj90 = default;
				string text5 = string.Format((string)format3, arg, obj90);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2435 @ X19_v67+10]");
				ex2 = (NullReferenceException)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2435 @ X19_v67+10]");
				bool flag49 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				stateMachine = null;
				cancellationToken = (CancellationToken)0;
				flag3 = (bool?)(object)result;
				num3 = (long)obj90;
				num4 = (nint)text5;
				if (flag49)
				{
					goto IL_2e3f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2435 @ X19_v67+10]");
				TypeCode typeCode2 = ((Enum)0).GetTypeCode();
				num2 = 0;
				_Il2CppInt32Enum = result;
				_Canon3 = _Canon;
			}
			object obj91 = _Canon3 + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			ex = null;
			obj2 = 0;
			obj3 = 0;
			stateMachine = null;
			num3 = 488L;
			num4 = unchecked((nint)null);
			goto IL_2523;
			IL_0fde:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5480]");
			object obj92 = 0;
			num4 = (nint)obj92;
			short result2 = taskAwaiter2.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			num5 = 0L;
			long value3 = ((long*)num5)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X9_v121 (System.Int64)+A0]");
			object obj93 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X9_v122+E0]");
			object obj94 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X9_v122+E0]");
			bool flag50 = (nint)0 == 0;
			shutdownReason = (ShutdownReason)flag3;
			System.__Canon _Canon4 = _Canon;
			if (!flag50)
			{
				ShutdownReason shutdownReason2 = ErrorCodeExt.ConvertToShutdownReason(result2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
				object obj95 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54C0]");
				object format4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54D0]");
				object arg2 = 0;
				object obj96 = default;
				string text6 = string.Format((string)format4, arg2, obj96);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X19_v71+10]");
				ex2 = (NullReferenceException)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X19_v71+10]");
				bool flag51 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				cancellationToken = (CancellationToken)0;
				flag3 = (bool?)(object)shutdownReason2;
				authenticationValues = (AuthenticationValues)obj96;
				num4 = (nint)text6;
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				if (flag51)
				{
					goto IL_2e84;
				}
				nint num43 = (nint)ex2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2975 @ X8_v240 (Il2CppClass<System.NullReferenceException>)+1A0]");
				authenticationValues = (AuthenticationValues)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X19_v71+10]");
				TypeCode typeCode3 = ((Enum)0).GetTypeCode();
				cancellationToken = (CancellationToken)0;
				shutdownReason = shutdownReason2;
				num4 = (nint)text6;
				_Canon4 = _Canon;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2470 @ X8_v177 (System.__Canon)+48]");
			bool flag52 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num3 = (long)authenticationValues;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2470 @ X8_v177 (System.__Canon)+48]");
			ex2 = (NullReferenceException)0;
			if (flag52)
			{
				goto IL_2a64;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2470 @ X8_v177 (System.__Canon)+48]");
			((CloudServices)0).OnRoomChanged();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			object obj97 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag53 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num3 = (long)authenticationValues;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2470 @ X8_v177 (System.__Canon)+48]");
			ex2 = (NullReferenceException)0;
			if (flag53)
			{
				goto IL_2aa1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2680 @ X8_v178+28]");
			bool flag54 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num2 = (int)cancellationToken;
			flag3 = (bool?)(object)shutdownReason;
			num3 = (long)authenticationValues;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2680 @ X8_v178+28]");
			ex2 = (NullReferenceException)0;
			if (flag54)
			{
				goto IL_2aee;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2680 @ X8_v178+28]");
			bool isServer = ((NetworkRunner)0).IsServer;
			bool flag55 = !isServer;
			flag3 = (bool?)(object)shutdownReason;
			num3 = (long)authenticationValues;
			num4 = unchecked((nint)null);
			ex2 = (NullReferenceException)isServer;
			if (!flag55)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
				object obj98 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
				bool flag56 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				num3 = (long)authenticationValues;
				num4 = unchecked((nint)null);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				ex2 = (NullReferenceException)isServer;
				if (flag56)
				{
					goto IL_31c5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3100 @ X8_v191+20]");
				taskAwaiter = (TaskAwaiter<short>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3100 @ X8_v191+20]");
				bool flag57 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				num3 = (long)authenticationValues;
				num4 = unchecked((nint)null);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				ex2 = (NullReferenceException)isServer;
				if (flag57)
				{
					goto IL_3202;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+1C0]");
				taskAwaiter = (TaskAwaiter<short>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+1C0]");
				nint num44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+23C]");
				if (num44 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+1C0]");
					_ = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3100 @ X8_v191+28]");
				bool flag58 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				num3 = (long)authenticationValues;
				num4 = unchecked((nint)null);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3100 @ X8_v191+28]");
				ex2 = (NullReferenceException)0;
				if (flag58)
				{
					goto IL_323f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3100 @ X8_v191+28]");
				IEnumerable<PlayerRef> activePlayers = ((NetworkRunner)0).ActivePlayers;
				bool flag59 = activePlayers == null;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				num3 = (long)authenticationValues;
				num4 = unchecked((nint)null);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				ex2 = (NullReferenceException)activePlayers;
				if (flag59)
				{
					goto IL_327c;
				}
				nint num45 = (nint)activePlayers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDF0]");
				object obj99 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3428 @ X8_v192 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+12E]");
				object obj100 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3428 @ X8_v192 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_156e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3428 @ X8_v192 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+98]");
				object obj101 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3522 @ X10_v97-8]");
					if (0 == (nint)obj99)
					{
						break;
					}
					obj100--;
					obj101 += 16;
					if ((nint)obj100 != 1)
					{
						continue;
					}
					goto IL_156e;
				}
				object obj102 = num45 + obj101;
				object obj103 = obj102 + 312;
				goto IL_3c14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			CloudServices cloudServices3 = (CloudServices)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag60 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			if (flag60)
			{
				goto IL_2cd1;
			}
			CloudServicesMetadata metadata = cloudServices3._metadata;
			bool flag61 = cloudServices3._metadata == null;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			if (flag61)
			{
				goto IL_2d0e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5470]");
			object obj104 = 0;
			num4 = (nint)obj104;
			ReadOnlySpan<byte> value4 = metadata.UniqueId__BackingField;
			long num46 = BitConverter.ToInt64(value4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			taskAwaiter = (TaskAwaiter<short>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag62 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num3 = 0L;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			ex2 = (NullReferenceException)num46;
			if (flag62)
			{
				goto IL_2d4b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+20]");
			object obj105 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+20]");
			bool flag63 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num3 = 0L;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			ex2 = (NullReferenceException)num46;
			if (flag63)
			{
				goto IL_2d88;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+28]");
			bool flag64 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			num3 = 0L;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+28]");
			ex2 = (NullReferenceException)0;
			if (flag64)
			{
				goto IL_2dc5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X9_v127+1C0]");
			num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+23C]");
			num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X10_v6 (System.Runtime.CompilerServices.TaskAwaiter`1<System.Int16>)+28]");
			bool isServer2 = ((NetworkRunner)0).IsServer;
			byte[] encryptionKeyOverride;
			if (isServer2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
				object obj106 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
				bool flag65 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				num3 = 0L;
				num4 = unchecked((nint)null);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				ex2 = (NullReferenceException)isServer2;
				if (flag65)
				{
					goto IL_3344;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3604 @ X8_v188+20]");
				object obj107 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3604 @ X8_v188+20]");
				bool flag66 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				num3 = 0L;
				num4 = unchecked((nint)null);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				ex2 = (NullReferenceException)isServer2;
				if (flag66)
				{
					goto IL_3381;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3664 @ X8_v189+1C8]");
				object obj108 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3664 @ X8_v189+1C8]");
				bool flag67 = (nint)0 == 0;
				ex = null;
				obj2 = 0;
				obj3 = 0;
				awaiter2 = (TaskAwaiter)0;
				stateMachine = null;
				num3 = 0L;
				num4 = unchecked((nint)null);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				ex2 = (NullReferenceException)isServer2;
				if (flag67)
				{
					goto IL_33be;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3682 @ X8_v190+10]");
				encryptionKeyOverride = (byte[])0;
			}
			else
			{
				encryptionKeyOverride = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			nint num47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+38]");
			Task task3 = ((CloudServices)num47).SendJoin((CancellationToken)0, num46, num30, num31, encryptionKeyOverride);
			bool flag68 = task3 == null;
			int num48 = num31;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			cancellationToken = (CancellationToken)num30;
			num3 = num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+38]");
			num4 = 0;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			ex2 = (NullReferenceException)(object)task3;
			if (!flag68)
			{
				TaskAwaiter awaiter6 = task3.GetAwaiter();
				bool isCompleted3 = awaiter2.IsCompleted;
				bool flag69 = !isCompleted3;
				num48 = num31;
				num2 = num30;
				num3 = num46;
				if (!flag69)
				{
					goto IL_2192;
				}
				_ = 2;
				object obj109 = _Canon + 608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj110 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4025 @ X0_v217+E4]");
				bool flag70 = (nint)0 == 0;
				object obj111 = !flag70;
				if (obj111 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5468]");
				object obj112 = 0;
				cancellationToken = (CancellationToken)obj112;
				asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(_Canon + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter2, ref stateMachine);
				num48 = num31;
				stateMachine = _Canon;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)flag3;
				num3 = (nint)(&stateMachine);
				num4 = (nint)(&awaiter2);
				taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
				num = 2;
				goto IL_26e8;
			}
			goto IL_2e02;
			IL_2c02:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag71 = num49 != 0;
			num3 = (long)authenticationValues;
			if (!flag71)
			{
				ex2 = new NullReferenceException();
				goto IL_2c47;
			}
			goto IL_394e;
			IL_1af0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num3 = 0L;
			goto IL_3e27;
			IL_2bbd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num50 == 0)
			{
				ex2 = new NullReferenceException();
				authenticationValues = (AuthenticationValues)num3;
				goto IL_2c02;
			}
			goto IL_394e;
			IL_3e27:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4180 @ X0_v239+8]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4180 @ X0_v239] (should have been resolved before IL gen)");
			goto IL_3dc0;
			IL_3dc0:
			ex = null;
			obj2 = 0;
			obj3 = 0;
			awaiter2 = (TaskAwaiter)0;
			stateMachine = null;
			shutdownReason = (ShutdownReason)(int)(&num);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			ex2 = null;
			goto IL_32b9;
			IL_394e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_2f98:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num51 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2fd5;
			}
			goto IL_394e;
			IL_323f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num52 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_327c;
			}
			goto IL_394e;
			IL_2c47:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag72 = num53 != 0;
			num3 = (long)authenticationValues;
			if (!flag72)
			{
				ex2 = new NullReferenceException();
				num3 = (long)authenticationValues;
				goto IL_2c94;
			}
			goto IL_394e;
			IL_2fd5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num54 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_3012;
			}
			goto IL_394e;
			IL_2c94:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num55 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2cd1;
			}
			goto IL_394e;
			IL_3188:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num56 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_31c5;
			}
			goto IL_394e;
			IL_2d0e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num57 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2d4b;
			}
			goto IL_394e;
			IL_3012:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num58 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_304f;
			}
			goto IL_394e;
			IL_32b9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num59 == 0)
			{
				OutOfMemoryException ex8 = new OutOfMemoryException();
				flag3 = (bool?)(object)shutdownReason;
				ex2 = (NullReferenceException)(object)ex8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				nint num60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				if (num60 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					goto IL_3344;
				}
			}
			goto IL_394e;
			IL_2d4b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num61 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2d88;
			}
			goto IL_394e;
			IL_304f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num62 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_308c;
			}
			goto IL_394e;
			IL_2cd1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num63 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2d0e;
			}
			goto IL_394e;
			IL_2d88:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num64 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2dc5;
			}
			goto IL_394e;
			IL_31c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num65 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_3202;
			}
			goto IL_394e;
			IL_308c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num66 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_30c9;
			}
			goto IL_394e;
			IL_2dc5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num67 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2e02;
			}
			goto IL_394e;
			IL_2192:
			awaiter2.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			object obj113 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ stack_-238_v2 (System.__Canon)+48]");
			bool flag73 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			stateMachine = null;
			num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			ex2 = (NullReferenceException)(&awaiter2);
			if (flag73)
			{
				goto IL_2b33;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v161+28]");
			object obj114 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v161+28]");
			bool flag74 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			stateMachine = null;
			cancellationToken = (CancellationToken)num2;
			num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			ex2 = (NullReferenceException)(&awaiter2);
			if (flag74)
			{
				goto IL_2b80;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2437 @ X8_v162+318]");
			bool flag75 = (nint)0 == 0;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			stateMachine = null;
			cancellationToken = (CancellationToken)num2;
			num4 = unchecked((nint)null);
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2437 @ X8_v162+318]");
			ex2 = (NullReferenceException)0;
			if (flag75)
			{
				goto IL_2bbd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5448]");
			object obj115 = 0;
			num4 = (nint)obj115;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2437 @ X8_v162+318]");
			Task<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> task4 = ((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0).Task;
			bool flag76 = task4 == null;
			ex = null;
			obj2 = 0;
			obj3 = 0;
			stateMachine = null;
			cancellationToken = (CancellationToken)num2;
			authenticationValues = (AuthenticationValues)num3;
			taskAwaiter3 = (TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)0;
			ex2 = (NullReferenceException)(object)task4;
			if (!flag76)
			{
				TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> awaiter7 = task4.GetAwaiter();
				TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> awaiter8 = default;
				bool isCompleted4 = awaiter8.IsCompleted;
				bool flag77 = !isCompleted4;
				taskAwaiter3 = awaiter8;
				if (!flag77)
				{
					goto IL_23a5;
				}
				_ = 3;
				object obj116 = _Canon + 624;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj117 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3249 @ X0_v193+E4]");
				bool flag78 = (nint)0 == 0;
				object obj118 = !flag78;
				if (obj118 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5460]");
				object obj119 = 0;
				cancellationToken = (CancellationToken)obj119;
				asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(_Canon + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>, System.__Canon>(ref awaiter8, ref stateMachine);
				stateMachine = _Canon;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)flag3;
				num3 = (nint)(&stateMachine);
				num4 = (nint)(&awaiter8);
				num = 3;
				goto IL_26e8;
			}
			goto IL_2c02;
			IL_2e02:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num68 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_2e3f;
			}
			goto IL_394e;
			IL_327c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num69 == 0)
			{
				ex2 = new NullReferenceException();
				goto IL_32b9;
			}
			goto IL_394e;
			IL_2e3f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num70 == 0)
			{
				ex2 = new NullReferenceException();
				authenticationValues = (AuthenticationValues)num3;
				goto IL_2e84;
			}
			goto IL_394e;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003C_003CMoveSessionToNewRoom_003Eg__WaitRejoin_007C117_0_003Ed : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public CloudServices _003C_003E4__this;

		private Stopwatch _003Cwatch_003E5__1;

		private Queue<PlayerRef> _003CplayerRefs_003E5__2;

		private PlayerRef _003CplayerRef_003E5__3;

		private int? _003Cactor_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0cc5: Expected Obj, but got I
			//IL_0cd5: Expected Obj, but got I
			//IL_0ce5: Expected Obj, but got I
			//IL_0cf5: Expected Obj, but got I
			//IL_0d05: Expected Obj, but got I
			//IL_0d15: Expected Obj, but got I
			//IL_01db: Expected VT, but got I4
			//IL_01ea: Expected I4, but got I8
			//IL_0201: Expected I4, but got I8
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0955: Unknown result type (might be due to invalid IL or missing references)
			//IL_095a: Expected Obj, but got Unknown
			//IL_0979: Expected I, but got Obj
			//IL_0d44: Expected Obj, but got I
			//IL_0d6e: Expected Obj, but got I4
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected Obj, but got Unknown
			//IL_0062: Expected Obj, but got I
			//IL_0270: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			//IL_009f: Expected I4, but got Obj
			//IL_00a7: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_0dd4: Expected Obj, but got I
			//IL_0de4: Expected Obj, but got I
			//IL_0aee: Expected Obj, but got I
			//IL_0e18: Expected I4, but got I8
			//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e34: Expected Obj, but got Unknown
			//IL_0e55: Expected Obj, but got I
			//IL_0e7f: Expected Obj, but got I4
			//IL_061b: Expected Obj, but got I
			//IL_062b: Expected Obj, but got I
			//IL_0a50: Expected I, but got Obj
			//IL_016d: Expected Obj, but got I
			//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d8: Expected VT, but got Unknown
			//IL_07e1: Expected Ref, but got VT
			//IL_0742: Expected Obj, but got I
			//IL_02b6: Expected I, but got Obj
			//IL_018c: Expected Obj, but got I
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected Obj, but got Unknown
			//IL_0660: Expected Obj, but got I
			//IL_067a: Expected Obj, but got I
			//IL_068a: Expected Obj, but got I
			//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b54: Expected Obj, but got Unknown
			//IL_079f: Expected Obj, but got I
			//IL_07af: Expected Obj, but got I
			//IL_06b4: Expected Obj, but got I
			//IL_06e8: Expected I, but got Obj
			//IL_02ee: Expected Obj, but got I4
			//IL_0c70: Expected Obj, but got I4
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Expected VT, but got Unknown
			//IL_031f: Expected Ref, but got VT
			//IL_033d: Expected Obj, but got I4
			//IL_035a: Expected I, but got Obj
			//IL_0b7a: Expected Obj, but got I4
			//IL_0b82: Expected Obj, but got Ref
			//IL_0ba0: Expected I4, but got I8
			//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bab: Expected Obj, but got Unknown
			//IL_0bb4: Expected Obj, but got I4
			//IL_070e: Expected Obj, but got I
			//IL_072d: Expected I, but got Obj
			//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bce: Expected Obj, but got Unknown
			//IL_0bd7: Expected Obj, but got I4
			//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bef: Expected VT, but got Unknown
			//IL_0388: Expected I, but got Obj
			//IL_0c20: Expected Obj, but got I4
			//IL_0c4a: Expected Ref, but got VT
			//IL_039e: Expected I, but got Obj
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Expected Obj, but got Unknown
			//IL_0815: Expected I, but got VT
			//IL_0465: Expected Obj, but got I
			//IL_0475: Expected Obj, but got I
			//IL_0499: Expected I, but got VT
			//IL_0833: Expected Obj, but got I
			//IL_0854: Expected Obj, but got I
			//IL_087e: Expected Obj, but got I4
			//IL_0d9e: Expected Obj, but got I4
			//IL_08dd: Expected I, but got VT
			//IL_04d0: Expected Obj, but got I
			//IL_04f9: Expected Obj, but got I
			//IL_0519: Expected Obj, but got I4
			//IL_0531: Expected I, but got Obj
			//IL_0557: Expected Obj, but got I
			//IL_056a: Expected Obj, but got I4
			//IL_058e: Expected I, but got Obj
			//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_09af: Expected Obj, but got Unknown
			//IL_09b9: Expected Obj, but got VT
			//IL_09d9: Expected Obj, but got I
			//IL_0a03: Expected Obj, but got I4
			//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2c: Expected VT, but got Unknown
			//IL_0a3d: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5508]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5500]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5538]");
			object format = 0;
			Queue<PlayerRef> queue2;
			NullReferenceException ex2;
			int num;
			nint num2 = default;
			Stopwatch stopwatch2;
			object obj11 = default;
			if (_003C_003E1__state != 0)
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v72+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v73+E0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v73+E0]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v74+10]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v74+10]");
					if ((nint)0 == 0)
					{
						goto IL_0aa5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5540]");
					object obj10 = 0;
					num = (int)obj9;
					num2 = (nint)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X9_v9 (System.Int32)+1A0]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ X9_v9 (System.Int32)+198] (should have been resolved before IL gen)");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v114+E4]");
				bool flag = (nint)0 == 0;
				object obj14 = !flag;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Stopwatch stopwatch = Stopwatch.StartNew();
				object obj15 = this + 64;
				obj15 = stopwatch;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				CloudServices cloudServices = _003C_003E4__this;
				if ((object)_003C_003E4__this != null)
				{
					if ((object)cloudServices._runner != null)
					{
						IEnumerable<PlayerRef> activePlayers = cloudServices._runner.ActivePlayers;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5528]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5518]");
						object obj17 = 0;
						obj11 = obj17;
						Queue<PlayerRef> queue = default;
						queue._002Ector(activePlayers);
						object obj18 = this + 72;
						obj18 = queue;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						queue2 = queue;
						goto IL_094f;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				ex2 = new NullReferenceException();
				stopwatch2 = stopwatch;
				goto IL_0af3;
			}
			_003C_003Eu__1 = (TaskAwaiter)0;
			_003C_003E1__state = -1;
			TaskAwaiter awaiter = _003C_003Eu__1;
			num = -1;
			goto IL_093c;
			IL_0593:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_05a1;
			IL_0aa5:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0ab3;
			IL_0ac1:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0acf;
			IL_0acf:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0add;
			IL_0add:
			ex2 = new NullReferenceException();
			stopwatch2 = (Stopwatch)num2;
			goto IL_0af3;
			IL_07e7:
			bool flag2 = (object)_003CplayerRefs_003E5__2 == null;
			object obj20;
			object obj19 = obj20;
			object obj22;
			object obj21 = obj22;
			obj11 = null;
			PlayerRef playerRef;
			num2 = (nint)playerRef;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5510]");
				object obj23 = 0;
				_003CplayerRefs_003E5__2.Enqueue(_003CplayerRef_003E5__3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
				object obj24 = 0;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v62+E4]");
				bool flag3 = (nint)0 == 0;
				object obj26 = !flag3;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Task task = TaskManager.Delay(50, this.cancellationToken);
				bool flag4 = task == null;
				obj19 = obj20;
				obj21 = obj22;
				obj11 = null;
				num2 = (nint)this.cancellationToken;
				if (!flag4)
				{
					TaskAwaiter awaiter2 = task.GetAwaiter();
					bool isCompleted = awaiter.IsCompleted;
					bool flag5 = !isCompleted;
					obj19 = obj20;
					obj21 = obj22;
					obj11 = null;
					if (!flag5)
					{
						goto IL_093c;
					}
					object obj27 = this + 96;
					obj27 = _003C_003Eu__1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
					object obj28 = 0;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v72+E4]");
					bool flag6 = (nint)0 == 0;
					object obj30 = !flag6;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(this + 24);
					System.__Canon stateMachine = default;
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
					return;
				}
				goto IL_0acf;
			}
			goto IL_0add;
			IL_05a1:
			bool flag7 = ex3 == null;
			obj20 = obj19;
			obj22 = obj21;
			object obj31 = obj11;
			nint num3;
			num2 = num3;
			if (!flag7)
			{
				goto IL_05de;
			}
			goto IL_0ab3;
			IL_05de:
			object obj32 = obj;
			if ((nint)((Exception)ex3)._data > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v50+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X10_v8+E0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X10_v8+E0]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5548]");
					object format2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54D0]");
					object arg = 0;
					object obj36 = default;
					string text = string.Format((string)format2, arg, obj36);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X21_v15+10]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X21_v15+10]");
					bool flag8 = (nint)0 == 0;
					obj19 = obj20;
					obj21 = null;
					obj11 = obj36;
					num2 = (nint)text;
					if (flag8)
					{
						goto IL_0ac1;
					}
					object obj38 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v65+1A0]");
					obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v728 @ X8_v65+198] (should have been resolved before IL gen)");
					obj32 = obj;
					obj22 = null;
					num3 = (nint)text;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v50+A0]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v51+E0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v51+E0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v52+10]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v52+10]");
				bool flag9 = (nint)0 == 0;
				obj19 = obj20;
				obj21 = obj22;
				obj11 = obj31;
				num2 = num3;
				if (flag9)
				{
					goto IL_0aa5;
				}
				object obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5530]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v58+1A0]");
				obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v578 @ X8_v58+198] (should have been resolved before IL gen)");
			}
			_003C_003E1__state = -2;
			_003Cwatch_003E5__1 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj44 = this + 72;
			_003CplayerRefs_003E5__2 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj45 = 0;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v95+E4]");
			bool flag10 = (nint)0 == 0;
			object obj47 = !flag10;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(this + 24);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
			return;
			IL_093c:
			awaiter.GetResult();
			queue2 = null;
			goto IL_094f;
			IL_0af3:
			bool flag11 = (nint)stopwatch2 != 1;
			NullReferenceException ex7 = ex2;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj49 = default;
				object obj48 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj51 = default;
				object obj50 = obj51 & 1;
				if (obj50 != null)
				{
					object obj52 = 0;
					object obj54 = default;
					object obj53 = (object)(&obj54);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					object obj55 = this + 64;
					obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj56 = this + 72;
					obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(obj56 - 48);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X0_v25+E4]");
					bool flag12 = (nint)0 == 0;
					object obj57 = !flag12;
					if (obj57 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetException((Exception)obj49);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj58 = obj49;
				stopwatch2 = (Stopwatch)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj11 = null;
				NullReferenceException ex8 = default;
				ex7 = ex8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0ab3:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_0ac1;
			IL_094f:
			object obj59 = this + 64;
			Stopwatch stopwatch3 = (Stopwatch)obj59;
			bool flag13 = obj59 == null;
			num3 = (nint)queue2;
			if (flag13)
			{
				goto IL_0593;
			}
			obj20 = obj19;
			obj22 = obj21;
			obj31 = obj11;
			object obj67 = default;
			object obj68 = default;
			while (true)
			{
				long elapsedMilliseconds = stopwatch3.ElapsedMilliseconds;
				ex3 = (NullReferenceException)(object)_003CplayerRefs_003E5__2;
				bool flag14 = elapsedMilliseconds >= 10000;
				obj19 = obj20;
				obj21 = obj22;
				obj11 = obj31;
				num3 = unchecked((nint)null);
				if (flag14)
				{
					break;
				}
				if ((object)_003CplayerRefs_003E5__2 != null)
				{
					bool flag15 = (nint)((Exception)ex3)._data < 1;
					num3 = unchecked((nint)null);
					if (flag15)
					{
						goto IL_05de;
					}
					object obj60 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v53+E4]");
					bool flag16 = (nint)0 == 0;
					object obj61 = !flag16;
					if (obj61 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CancellationToken cancellationToken = (CancellationToken)(this + 48);
					bool isCancellationRequested = ((CancellationToken*)cancellationToken)->IsCancellationRequested;
					bool flag17 = !isCancellationRequested;
					object obj62 = !flag17;
					obj19 = obj20;
					obj21 = obj22;
					obj11 = obj31;
					num3 = unchecked((nint)null);
					ex3 = (NullReferenceException)(object)_003CplayerRefs_003E5__2;
					if (obj62 != null)
					{
						break;
					}
					bool flag18 = (object)_003CplayerRefs_003E5__2 == null;
					num2 = unchecked((nint)null);
					if (flag18)
					{
						goto IL_0a63;
					}
					num2 = (nint)obj3;
					playerRef = _003CplayerRefs_003E5__2.Dequeue();
					CloudServices cloudServices2 = _003C_003E4__this;
					_003CplayerRef_003E5__3 = playerRef;
					if ((object)_003C_003E4__this != null)
					{
						if ((object)cloudServices2._runner != null)
						{
							int? playerActorId = cloudServices2._runner.GetPlayerActorId(playerRef);
							object obj63 = (_003F?)playerActorId & 0xFF;
							bool flag19 = obj63 == null;
							_003Cactor_003E5__4 = playerActorId;
							if (!flag19)
							{
								object obj64 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v40+A0]");
								object obj65 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X8_v41+E0]");
								object obj66 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X8_v41+E0]");
								bool flag20 = (nint)0 == 0;
								obj31 = null;
								num3 = (nint)playerRef;
								if (!flag20)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54D0]");
									object arg2 = 0;
									string text2 = string.Format((string)format, arg2, obj67, obj68);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v8+10]");
									object obj69 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v8+10]");
									bool flag21 = (nint)0 == 0;
									obj20 = 0;
									obj22 = obj68;
									obj31 = obj67;
									num2 = (nint)text2;
									if (flag21)
									{
										goto IL_0a7f;
									}
									object obj70 = obj69;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v47+1A0]");
									obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v898 @ X8_v47+198] (should have been resolved before IL gen)");
									obj20 = 0;
									obj22 = obj68;
									int? num4 = _003Cactor_003E5__4;
									PlayerRef playerRef2 = _003CplayerRef_003E5__3;
									num3 = (nint)text2;
								}
								stopwatch3 = (Stopwatch)obj59;
								bool flag22 = obj59 == null;
								object obj71 = !flag22;
								obj19 = obj20;
								obj21 = obj22;
								obj11 = obj31;
								if (obj71 != null)
								{
									continue;
								}
								goto IL_0593;
							}
							goto IL_07e7;
						}
						goto IL_0a71;
					}
				}
				else
				{
					NullReferenceException ex10 = new NullReferenceException();
					num2 = unchecked((nint)null);
				}
				NullReferenceException ex11 = new NullReferenceException();
				goto IL_0a63;
				IL_0a7f:
				NullReferenceException ex12 = new NullReferenceException();
				obj19 = obj20;
				obj21 = obj22;
				obj11 = obj31;
				goto IL_0aa5;
				IL_0a71:
				NullReferenceException ex13 = new NullReferenceException();
				goto IL_0a7f;
				IL_0a63:
				NullReferenceException ex14 = new NullReferenceException();
				goto IL_0a71;
			}
			goto IL_05a1;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Region, string> _003C_003E9__5_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FD0]");
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

		internal string _003COnRegionListReceived_003Eb__5_0(Region region)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			if (region != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
				object obj2 = 0;
				return region.Code__BackingField + (string)obj + region.HostAndPort__BackingField + (string)obj2;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		[StructLayout((LayoutKind)2, Size = 4)]
		private struct Segment
		{
			[FieldOffset(0)]
			public Allocator.Ptr Next;

			public const int SIZE = default(int);

			public const int WORD_COUNT = default(int);

			internal const int BYTE_OF_NEXT = default(int);

			internal const int BYTE_COUNT_OF_NEXT = default(int);

			private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);
		}

		public CloudServices _003C_003E4__this;

		public NetAddress remoteAddr;

		internal unsafe Task _003CRun_ReversePing_003Eb__0(CancellationToken token)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_017d: Expected Obj, but got I4
			//IL_006a: Expected Obj, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected Obj, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected Obj, but got Unknown
			//IL_00c4: Expected Obj, but got VT
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected VT, but got Unknown
			//IL_0129: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5550]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj3 = default;
			obj3._002Ector();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5558]");
				object obj6 = 0;
				object obj7 = obj3 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj8 = obj3 + 56;
				obj8 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj9 = obj3 + 48;
				obj9 = token;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj10 = obj3 + 24;
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35014A8");
				object obj11 = default;
				if (obj11 != null)
				{
					AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj11 + 24);
					return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Task;
				}
			}
			return (Task)(object)new NullReferenceException();
		}

		internal unsafe bool _003CRun_ReversePing_003Eg__SendPing_007C1(NetAddress netAddress)
		{
			//IL_01b5: Expected Obj, but got I4
			//IL_0055: Expected I4, but got Obj
			//IL_007b: Expected I, but got Obj
			//IL_007b: Expected VT, but got Ref
			//IL_008f: Expected Obj, but got I
			//IL_00bc: Expected Obj, but got I4
			//IL_00cb: Expected Obj, but got I4
			//IL_00e5: Expected Obj, but got I4
			//IL_00f2: Expected I4, but got Obj
			CloudServices cloudServices = _003C_003E4__this;
			if ((object)_003C_003E4__this != null)
			{
				NetworkRunner runner = cloudServices._runner;
				bool flag2;
				if ((object)cloudServices._runner != null)
				{
					bool flag = (object)runner._simulation == null;
					flag2 = (byte)(int)runner._simulation != 0;
					if (!flag)
					{
						object obj = default;
						bool value = runner._simulation.NetworkSendPing((NetAddress)(&obj), (void*)unchecked((nint)null), 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5970]");
						object obj2 = 0;
						bool? flag3 = value;
						bool flag4 = 0 < 255;
						object obj3 = !flag4;
						object obj4 = -255;
						bool flag5 = obj4 == null;
						object obj5 = !flag5;
						bool flag6 = (byte)(obj3 & obj5) != 0;
						flag2 = flag6;
					}
				}
				else
				{
					flag2 = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
				bool flag7 = num != 0;
				NullReferenceException ex = (NullReferenceException)flag2;
				if (!flag7)
				{
					return flag2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
				bool flag8 = num2 != 0;
				NullReferenceException ex = (NullReferenceException)(object)this;
				if (!flag8)
				{
					ex = new NullReferenceException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			bool result = default;
			return result;
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public CloudServices _003C_003E4__this;

		public string sessionId;

		internal Task _003CTriggerMoveSessionToNewRoom_003Eb__0(CancellationToken token)
		{
			if ((object)_003C_003E4__this != null)
			{
				return _003C_003E4__this.MoveSessionToNewRoom(token, sessionId);
			}
			return (Task)(object)new NullReferenceException();
		}
	}

	private sealed class _003CConfirmJoin_003Ed__102 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CloudServices _003C_003E4__this;

		private Stopwatch _003Ctimer_003E5__1;

		private JoinProcessStage _003C_003Es__2;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0703: Expected Obj, but got I
			//IL_0085: Expected VT, but got I4
			//IL_0094: Expected I4, but got I8
			//IL_0015: Expected Obj, but got I
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected Obj, but got Unknown
			//IL_0269: Expected Obj, but got I
			//IL_0281: Expected Obj, but got I
			//IL_0291: Expected Obj, but got I
			//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a7: Expected Obj, but got Unknown
			//IL_0732: Expected I4, but got I8
			//IL_076d: Expected Obj, but got I4
			//IL_02c6: Expected Obj, but got I
			//IL_06aa: Expected Obj, but got I4
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected VT, but got Unknown
			//IL_0388: Expected Ref, but got VT
			//IL_07a1: Expected Obj, but got I
			//IL_06cc: Expected Obj, but got I4
			//IL_05cd: Expected Obj, but got I4
			//IL_05d5: Expected Obj, but got Ref
			//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Expected Obj, but got Unknown
			//IL_05f8: Expected Obj, but got I4
			//IL_061a: Unknown result type (might be due to invalid IL or missing references)
			//IL_061f: Expected VT, but got Unknown
			//IL_064b: Expected Obj, but got I4
			//IL_067f: Expected Ref, but got VT
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Expected Obj, but got Unknown
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected Obj, but got Unknown
			//IL_02e6: Expected Obj, but got I
			//IL_02fe: Expected Obj, but got I
			//IL_030e: Expected Obj, but got I
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected Obj, but got Unknown
			//IL_0343: Expected Obj, but got I
			//IL_039e: Expected Obj, but got I
			//IL_03c8: Expected Obj, but got I4
			//IL_03f4: Expected VT, but got I4
			//IL_0410: Expected Obj, but got I4
			//IL_045a: Expected Obj, but got I4
			//IL_0486: Unknown result type (might be due to invalid IL or missing references)
			//IL_048b: Expected Obj, but got Unknown
			//IL_0495: Expected Obj, but got VT
			//IL_04cf: Expected Obj, but got I4
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Expected VT, but got Unknown
			//IL_0509: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5318]");
			object obj = 0;
			NullReferenceException ex;
			Stopwatch stopwatch2;
			if (_003C_003E1__state != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Stopwatch stopwatch = default;
				stopwatch._002Ector();
				object obj3 = this + 56;
				obj3 = stopwatch;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj3 != null)
				{
					((Stopwatch)obj3).Start();
					stopwatch2 = null;
					goto IL_00ba;
				}
				ex = new NullReferenceException();
				stopwatch2 = stopwatch;
				goto IL_0546;
			}
			_003C_003Eu__1 = (TaskAwaiter)0;
			_003C_003E1__state = -1;
			TaskAwaiter awaiter = _003C_003Eu__1;
			goto IL_0468;
			IL_00ba:
			Task task;
			object obj8;
			while (true)
			{
				bool result;
				if (_003Ctimer_003E5__1 != null)
				{
					long elapsedMilliseconds = _003Ctimer_003E5__1.ElapsedMilliseconds;
					object obj12;
					if (elapsedMilliseconds <= 30000)
					{
						CloudServices cloudServices = _003C_003E4__this;
						bool flag = (object)_003C_003E4__this == null;
						stopwatch2 = null;
						if (flag)
						{
							goto IL_051c;
						}
						CloudServicesMetadata metadata = cloudServices._metadata;
						bool flag2 = cloudServices._metadata == null;
						stopwatch2 = null;
						if (flag2)
						{
							goto IL_052a;
						}
						_003C_003Es__2 = metadata.CurrentJoinStage__BackingField;
						object obj4;
						if (metadata.CurrentJoinStage__BackingField > (JoinProcessStage)1)
						{
							if (metadata.CurrentJoinStage__BackingField != (JoinProcessStage)2)
							{
								bool flag3 = metadata.CurrentJoinStage__BackingField != (JoinProcessStage)3;
								stopwatch2 = null;
								if (flag3)
								{
									continue;
								}
								obj4 = this + 56;
								result = false;
							}
							else
							{
								obj4 = this + 56;
								result = true;
							}
							goto IL_0723;
						}
						if (metadata.CurrentJoinStage__BackingField != 0)
						{
							bool flag4 = metadata.CurrentJoinStage__BackingField != (JoinProcessStage)1;
							stopwatch2 = null;
							if (flag4)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
							object obj5 = 0;
							object obj6 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v52+E4]");
							bool flag5 = (nint)0 == 0;
							object obj7 = !flag5;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							task = TaskManager.Delay(10, (CancellationToken)0);
							bool flag6 = task == null;
							obj8 = 0;
							stopwatch2 = null;
							if (!flag6)
							{
								break;
							}
							goto IL_0538;
						}
						obj4 = this + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
						object obj9 = 0;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v34+A0]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v35+18]");
						obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v35+18]");
						if ((nint)0 == 0)
						{
							goto IL_077b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5588]");
						object obj13 = 0;
					}
					else
					{
						object obj4 = this + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
						object obj14 = 0;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v25+A0]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v26+18]");
						obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v26+18]");
						if ((nint)0 == 0)
						{
							goto IL_077b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5580]");
						object obj13 = 0;
					}
					object obj17 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v3+1A0]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X9_v3+198] (should have been resolved before IL gen)");
					goto IL_077b;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_051c;
				IL_052a:
				NullReferenceException ex3 = new NullReferenceException();
				goto IL_0538;
				IL_077b:
				result = false;
				goto IL_0723;
				IL_0723:
				_003C_003E1__state = -2;
				_003Ctimer_003E5__1 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v46+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<bool>)(this + 24);
				((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder)->SetResult(result);
				return;
				IL_051c:
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_052a;
				IL_0538:
				ex = new NullReferenceException();
				goto IL_0546;
			}
			TaskAwaiter awaiter2 = task.GetAwaiter();
			bool isCompleted = awaiter.IsCompleted;
			bool flag8 = !isCompleted;
			obj8 = 0;
			if (!flag8)
			{
				goto IL_0468;
			}
			object obj20 = this + 72;
			obj20 = _003C_003Eu__1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v62+E4]");
			bool flag9 = (nint)0 == 0;
			object obj22 = !flag9;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<bool>)(this + 24);
			System.__Canon stateMachine = default;
			((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder2)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
			return;
			IL_0546:
			bool flag10 = (nint)stopwatch2 != 1;
			NullReferenceException ex5 = ex;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj24 = default;
				object obj23 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj26 = default;
				object obj25 = obj26 & 1;
				if (obj25 != null)
				{
					object obj27 = 0;
					object obj29 = default;
					object obj28 = (object)(&obj29);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj30 = this + 56;
					obj30 = 0;
					_ = 4294967294L;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<bool>)(obj30 - 32);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v22+E4]");
					bool flag11 = (nint)0 == 0;
					object obj31 = !flag11;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder3)->SetException((Exception)obj24);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj32 = obj24;
				stopwatch2 = (Stopwatch)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj8 = 0;
				NullReferenceException ex6 = default;
				ex5 = ex6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0468:
			awaiter.GetResult();
			stopwatch2 = null;
			goto IL_00ba;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CConnectToCloud_003Ed__72 : Action<GetQueueStatisticsResult>
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppSettings appSettings;

		public AuthenticationValues authentication;

		public CancellationToken cancellationToken;

		public CloudServices _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0d79: Expected Obj, but got I
			//IL_0d89: Expected Obj, but got I
			//IL_0845: Expected VT, but got I4
			//IL_0854: Expected I4, but got I8
			//IL_0e2b: Expected Obj, but got I
			//IL_0e3b: Expected Obj, but got I
			//IL_0e57: Expected I, but got Obj
			//IL_0e7c: Expected I4, but got I8
			//IL_0e9e: Expected Obj, but got I4
			//IL_092c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0931: Expected VT, but got Unknown
			//IL_093a: Expected Ref, but got VT
			//IL_0883: Expected I, but got Obj
			//IL_0b60: Expected Obj, but got I
			//IL_08a1: Expected Obj, but got I
			//IL_08bd: Expected I, but got Obj
			//IL_08db: Expected Obj, but got I
			//IL_08f0: Expected I, but got Obj
			//IL_0900: Expected Obj, but got I
			//IL_00ac: Expected I, but got Obj
			//IL_0b92: Expected I, but got Obj
			//IL_0183: Expected I, but got Obj
			//IL_00e0: Expected I, but got Obj
			//IL_01b7: Expected I, but got Obj
			//IL_0114: Expected I, but got Obj
			//IL_01de: Expected I, but got Obj
			//IL_01f6: Expected I, but got Obj
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Expected Obj, but got Unknown
			//IL_0958: Expected Obj, but got I
			//IL_0968: Expected Obj, but got I
			//IL_0984: Expected I, but got Obj
			//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4c: Expected Obj, but got Unknown
			//IL_09a2: Expected Obj, but got I
			//IL_09be: Expected I, but got Obj
			//IL_0c72: Expected Obj, but got I4
			//IL_0c7a: Expected Obj, but got Ref
			//IL_0c98: Expected I4, but got I8
			//IL_09dc: Expected Obj, but got I
			//IL_09f1: Expected I, but got Obj
			//IL_0a01: Expected Obj, but got I
			//IL_0cc9: Expected Obj, but got I4
			//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf1: Expected VT, but got Unknown
			//IL_0cfe: Expected Ref, but got VT
			//IL_0db8: Expected Obj, but got I
			//IL_0dc8: Expected Obj, but got I
			//IL_0ebc: Expected Obj, but got I
			//IL_0edb: Expected I, but got Obj
			//IL_02eb: Expected Obj, but got I
			//IL_02fb: Expected Obj, but got I
			//IL_0330: Expected Obj, but got I
			//IL_0356: Expected Obj, but got I
			//IL_0382: Expected I, but got Obj
			//IL_040b: Expected Obj, but got I
			//IL_0438: Expected Obj, but got I
			//IL_04f0: Expected Obj, but got I
			//IL_0513: Expected Obj, but got I
			//IL_053c: Expected I, but got Obj
			//IL_03a8: Expected Obj, but got I
			//IL_05c2: Expected Obj, but got I
			//IL_05ec: Expected Obj, but got I4
			//IL_047d: Expected Obj, but got I
			//IL_049f: Expected Obj, but got I
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Expected Obj, but got Unknown
			//IL_0562: Expected Obj, but got I
			//IL_058b: Expected I, but got Obj
			//IL_0662: Expected I, but got Obj
			//IL_0699: Expected I, but got Obj
			//IL_06d0: Expected I, but got Obj
			//IL_070f: Expected Obj, but got I
			//IL_0730: Expected Obj, but got I4
			//IL_078f: Expected Obj, but got I4
			//IL_0798: Expected Obj, but got I4
			//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b9: Expected Obj, but got Unknown
			//IL_07c1: Expected Obj, but got VT
			//IL_07fb: Expected Obj, but got I4
			//IL_081f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0824: Expected VT, but got Unknown
			//IL_0835: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj2 = 0;
			nint num3;
			object obj11;
			TaskAwaiter awaiter2 = default;
			nint num2;
			nint num;
			if (_003C_003E1__state != 0)
			{
				CloudServices cloudServices = _003C_003E4__this;
				if ((object)_003C_003E4__this != null)
				{
					CloudCommunicator communicator = cloudServices._communicator;
					if ((object)cloudServices._communicator != null)
					{
						if (communicator.Client__BackingField.IsConnectedAndReady)
						{
							CloudServices cloudServices2 = _003C_003E4__this;
							bool flag = (object)_003C_003E4__this == null;
							num = unchecked((nint)null);
							if (flag)
							{
								goto IL_0ba5;
							}
							CloudCommunicator communicator2 = cloudServices2._communicator;
							bool flag2 = (object)cloudServices2._communicator == null;
							num = unchecked((nint)null);
							if (flag2)
							{
								goto IL_0bb3;
							}
							RealtimeClient realtimeClient = communicator2.Client__BackingField;
							bool flag3 = communicator2.Client__BackingField == null;
							num = unchecked((nint)null);
							if (flag3)
							{
								goto IL_0bc1;
							}
							if (realtimeClient.Server__BackingField == 0)
							{
								object obj3 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X9_v56+A0]");
								object obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X9_v57+E0]");
								object obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X9_v57+E0]");
								bool flag4 = (nint)0 == 0;
								num2 = unchecked((nint)null);
								if (!flag4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v58+10]");
									object obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v58+10]");
									bool flag5 = (nint)0 == 0;
									num = unchecked((nint)null);
									if (flag5)
									{
										goto IL_0bdd;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55A8]");
									object obj7 = 0;
									object obj8 = obj6;
									num2 = (nint)cloudServices2._runner;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v24+190]");
									object obj9 = 0;
									AsyncConfig asyncConfig = (AsyncConfig)obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X10_v24+188] (should have been resolved before IL gen)");
								}
								goto IL_0e65;
							}
						}
						if (this.appSettings != null)
						{
							CloudServices cloudServices3 = _003C_003E4__this;
							bool flag6 = (object)_003C_003E4__this == null;
							num3 = unchecked((nint)null);
							if (!flag6)
							{
								CloudCommunicator communicator3 = cloudServices3._communicator;
								bool flag7 = (object)cloudServices3._communicator == null;
								num3 = unchecked((nint)null);
								if (flag7)
								{
									goto IL_0aa7;
								}
								bool flag8 = communicator3.Client__BackingField == null;
								num3 = unchecked((nint)null);
								if (flag8)
								{
									goto IL_0ab5;
								}
								num3 = (nint)authentication;
								object obj10 = communicator3.Client__BackingField + 64;
								obj10 = authentication;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								CloudServices cloudServices4 = _003C_003E4__this;
								if ((object)_003C_003E4__this == null)
								{
									goto IL_0ac3;
								}
								CloudCommunicator communicator4 = cloudServices4._communicator;
								if ((object)cloudServices4._communicator == null)
								{
									goto IL_0ad1;
								}
								RealtimeClient realtimeClient2 = communicator4.Client__BackingField;
								if (communicator4.Client__BackingField == null)
								{
									goto IL_0adf;
								}
								obj11 = realtimeClient2.AuthValues__BackingField;
								object obj12 = obj;
								object obj9;
								AsyncConfig asyncConfig;
								if (realtimeClient2.AuthValues__BackingField != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v37+A0]");
									object obj13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v23+E0]");
									object obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v23+E0]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55B8]");
										object format = 0;
										string text = string.Format((string)format, realtimeClient2.AuthValues__BackingField);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X21_v28+10]");
										object obj15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X21_v28+10]");
										bool flag9 = (nint)0 == 0;
										asyncConfig = (AsyncConfig)(object)text;
										num = (nint)realtimeClient2.AuthValues__BackingField;
										if (flag9)
										{
											goto IL_0bcf;
										}
										object obj16 = obj15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v70+190]");
										obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v660 @ X8_v70+188] (should have been resolved before IL gen)");
										obj12 = obj;
										cloudServices4 = _003C_003E4__this;
										asyncConfig = (AsyncConfig)(object)text;
										obj11 = cloudServices4._runner;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v37+A0]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X9_v39+C8]");
								object obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X9_v39+C8]");
								if ((nint)0 != 0)
								{
									if ((object)cloudServices4 == null)
									{
										goto IL_0b65;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55B0]");
									object format2 = 0;
									obj11 = this.appSettings;
									string text2 = string.Format((string)format2, this.appSettings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X21_v24+10]");
									object obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X21_v24+10]");
									bool flag10 = (nint)0 == 0;
									asyncConfig = (AsyncConfig)(object)text2;
									if (flag10)
									{
										goto IL_0b73;
									}
									object obj20 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v67+190]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v684 @ X8_v67+188] (should have been resolved before IL gen)");
									object obj21 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v68+A0]");
									obj17 = 0;
									cloudServices4 = _003C_003E4__this;
									asyncConfig = (AsyncConfig)(object)text2;
									obj11 = cloudServices4._runner;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X9_v39+E0]");
								object obj22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X9_v39+E0]");
								bool flag11 = (nint)0 == 0;
								num3 = (nint)obj11;
								if (!flag11)
								{
									if ((object)cloudServices4 == null)
									{
										goto IL_0b81;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55B0]");
									object format3 = 0;
									string text3 = string.Format((string)format3, this.appSettings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X21_v25+10]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X21_v25+10]");
									bool flag12 = (nint)0 == 0;
									asyncConfig = (AsyncConfig)(object)text3;
									num = (nint)this.appSettings;
									if (flag12)
									{
										goto IL_0b97;
									}
									object obj24 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v65+190]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v698 @ X8_v65+188] (should have been resolved before IL gen)");
									cloudServices4 = _003C_003E4__this;
									asyncConfig = (AsyncConfig)(object)text3;
									num3 = (nint)cloudServices4._runner;
								}
								if ((object)cloudServices4 == null)
								{
									goto IL_0aed;
								}
								if (cloudServices4._metadata == null)
								{
									goto IL_0afb;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
								object obj25 = 0;
								object obj26 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v106+E4]");
								bool flag13 = (nint)0 == 0;
								object obj27 = !flag13;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								AppSettings appSettings = RealtimeClientExtensions.SetupAppSettings(this.appSettings);
								object obj28 = cloudServices4._metadata + 496;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								CloudServices cloudServices5 = _003C_003E4__this;
								bool flag14 = (object)_003C_003E4__this == null;
								num3 = (nint)appSettings;
								if (flag14)
								{
									goto IL_0b09;
								}
								CloudCommunicator communicator5 = cloudServices5._communicator;
								bool flag15 = (object)cloudServices5._communicator == null;
								num3 = (nint)appSettings;
								if (flag15)
								{
									goto IL_0b17;
								}
								CloudServicesMetadata metadata = cloudServices5._metadata;
								bool flag16 = cloudServices5._metadata == null;
								num3 = (nint)appSettings;
								if (flag16)
								{
									goto IL_0b25;
								}
								CloudServices cloudServices6 = default;
								AsyncConfig asyncConfig2 = cloudServices6.BuildAsyncConfig(cancellationToken);
								RealtimeClient client = communicator5.Client__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v60 (Fusion.CloudServicesMetadata)+1F0]");
								Task task = AsyncExtensions.ConnectUsingSettingsAsync(client, (AppSettings)0, asyncConfig2);
								bool flag17 = task == null;
								obj9 = 0;
								asyncConfig = asyncConfig2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v60 (Fusion.CloudServicesMetadata)+1F0]");
								num3 = 0;
								if (flag17)
								{
									goto IL_0b33;
								}
								TaskAwaiter awaiter = task.GetAwaiter();
								bool isCompleted = awaiter2.IsCompleted;
								bool flag18 = !isCompleted;
								object obj29 = !flag18;
								obj9 = 0;
								asyncConfig = asyncConfig2;
								if (obj29 == null)
								{
									object obj30 = this + 80;
									obj30 = awaiter2;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj31 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v121+E4]");
									bool flag19 = (nint)0 == 0;
									object obj32 = !flag19;
									if (obj32 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(this + 24);
									System.__Canon stateMachine = default;
									((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter2, ref stateMachine);
									return;
								}
								goto IL_0e0a;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							InvalidOperationException ex = default;
							string message = default;
							ex._002Ector(message);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentNullException ex2 = new ArgumentNullException();
							AsyncConfig asyncConfig = null;
							IntPtr intPtr = default;
							num3 = intPtr;
						}
						NullReferenceException ex3 = new NullReferenceException();
						goto IL_0aa7;
					}
				}
				else
				{
					NullReferenceException ex4 = new NullReferenceException();
				}
				NullReferenceException ex5 = new NullReferenceException();
				throw new NullReferenceException();
			}
			_003C_003Eu__1 = (TaskAwaiter)0;
			_003C_003E1__state = -1;
			awaiter2 = _003C_003Eu__1;
			goto IL_0e0a;
			IL_0b81:
			NullReferenceException ex6 = new NullReferenceException();
			num = (nint)obj11;
			goto IL_0b97;
			IL_0ad1:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0adf;
			IL_0b17:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0b25;
			IL_0b09:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_0b17;
			IL_0adf:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_0aed;
			IL_0bb3:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_0bc1;
			IL_0ba5:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_0bb3;
			IL_0b33:
			NullReferenceException ex13 = new NullReferenceException();
			goto IL_0b41;
			IL_0bcf:
			NullReferenceException ex14 = new NullReferenceException();
			goto IL_0bdd;
			IL_0e0a:
			awaiter2.GetResult();
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+A0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v8+E0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v8+E0]");
			bool flag20 = (nint)0 == 0;
			num2 = unchecked((nint)null);
			if (!flag20)
			{
				CloudServices cloudServices7 = _003C_003E4__this;
				bool flag21 = (object)_003C_003E4__this == null;
				num3 = unchecked((nint)null);
				if (flag21)
				{
					goto IL_0b41;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4+10]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4+10]");
				bool flag22 = (nint)0 == 0;
				num3 = unchecked((nint)null);
				if (flag22)
				{
					goto IL_0b4f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55A0]");
				object obj37 = 0;
				object obj38 = obj36;
				num2 = (nint)cloudServices7._runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X10_v3+190]");
				object obj9 = 0;
				AsyncConfig asyncConfig = (AsyncConfig)obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ X10_v3+188] (should have been resolved before IL gen)");
			}
			goto IL_0e65;
			IL_0bc1:
			NullReferenceException ex15 = new NullReferenceException();
			goto IL_0bcf;
			IL_0b41:
			NullReferenceException ex16 = new NullReferenceException();
			goto IL_0b4f;
			IL_0e65:
			object obj39 = obj2;
			_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v3+E4]");
			bool flag23 = (nint)0 == 0;
			object obj40 = !flag23;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(this + 24);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
			return;
			IL_0b25:
			NullReferenceException ex17 = new NullReferenceException();
			goto IL_0b33;
			IL_0aed:
			NullReferenceException ex18 = new NullReferenceException();
			goto IL_0afb;
			IL_0bdd:
			NullReferenceException ex19 = new NullReferenceException();
			bool flag24 = num != 1;
			NullReferenceException ex20 = ex19;
			if (!flag24)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj42 = default;
				object obj41 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj44 = default;
				object obj43 = obj44 & 1;
				if (obj43 != null)
				{
					object obj45 = 0;
					object obj47 = default;
					object obj46 = (object)(&obj47);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v30+E4]");
					bool flag25 = (nint)0 == 0;
					object obj48 = !flag25;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetException((Exception)obj42);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj49 = obj42;
				num = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				AsyncConfig asyncConfig = null;
				NullReferenceException ex21 = default;
				ex20 = ex21;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0b4f:
			NullReferenceException ex22 = new NullReferenceException();
			obj11 = num3;
			goto IL_0b65;
			IL_0b65:
			NullReferenceException ex23 = new NullReferenceException();
			goto IL_0b73;
			IL_0aa7:
			NullReferenceException ex24 = new NullReferenceException();
			goto IL_0ab5;
			IL_0afb:
			NullReferenceException ex25 = new NullReferenceException();
			goto IL_0b09;
			IL_0ab5:
			NullReferenceException ex26 = new NullReferenceException();
			goto IL_0ac3;
			IL_0b73:
			NullReferenceException ex27 = new NullReferenceException();
			goto IL_0b81;
			IL_0ac3:
			NullReferenceException ex28 = new NullReferenceException();
			goto IL_0ad1;
			IL_0b97:
			NullReferenceException ex29 = new NullReferenceException();
			goto IL_0ba5;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CDisconnectFromCloud_003Ed__75 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CloudServices _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0a68: Expected Obj, but got I
			//IL_0a78: Expected Obj, but got I
			//IL_005b: Expected VT, but got I4
			//IL_006a: Expected I4, but got I8
			//IL_0b3e: Expected I, but got Obj
			//IL_0032: Expected VT, but got I4
			//IL_0041: Expected I4, but got I8
			//IL_02ed: Expected I, but got Obj
			//IL_0654: Expected Obj, but got I
			//IL_0664: Expected Obj, but got I
			//IL_0ad7: Expected I4, but got I8
			//IL_0af9: Expected Obj, but got I4
			//IL_0363: Expected Obj, but got I4
			//IL_0748: Unknown result type (might be due to invalid IL or missing references)
			//IL_074d: Expected VT, but got Unknown
			//IL_0756: Expected Ref, but got VT
			//IL_0119: Expected I, but got Obj
			//IL_06c2: Expected Obj, but got I
			//IL_013f: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I
			//IL_016b: Expected I, but got Obj
			//IL_03b9: Expected I, but got Obj
			//IL_06f7: Expected Obj, but got I
			//IL_070c: Expected I, but got Obj
			//IL_071c: Expected Obj, but got I
			//IL_0724: Expected I4, but got Obj
			//IL_0199: Expected I, but got Obj
			//IL_03df: Expected Obj, but got I
			//IL_03ef: Expected Obj, but got I
			//IL_040b: Expected I, but got Obj
			//IL_01b7: Expected Obj, but got I
			//IL_01d3: Expected I, but got Obj
			//IL_0439: Expected I, but got Obj
			//IL_028c: Expected I, but got Obj
			//IL_01f1: Expected Obj, but got I
			//IL_0206: Expected I, but got Obj
			//IL_0216: Expected Obj, but got I
			//IL_021e: Expected I4, but got Obj
			//IL_0457: Expected Obj, but got I
			//IL_0473: Expected I, but got Obj
			//IL_0531: Expected Obj, but got I4
			//IL_0544: Expected I, but got Obj
			//IL_0932: Unknown result type (might be due to invalid IL or missing references)
			//IL_0937: Expected Obj, but got Unknown
			//IL_0491: Expected Obj, but got I
			//IL_04a6: Expected I, but got Obj
			//IL_04b6: Expected Obj, but got I
			//IL_04be: Expected I4, but got Obj
			//IL_0762: Unknown result type (might be due to invalid IL or missing references)
			//IL_0767: Expected Obj, but got Unknown
			//IL_076f: Expected Obj, but got VT
			//IL_07a9: Expected Obj, but got I4
			//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d2: Expected VT, but got Unknown
			//IL_07e3: Expected Ref, but got VT
			//IL_095d: Expected Obj, but got I4
			//IL_0965: Expected Obj, but got Ref
			//IL_0983: Expected I4, but got I8
			//IL_058b: Expected Obj, but got I4
			//IL_0594: Expected Obj, but got I4
			//IL_09b4: Expected Obj, but got I4
			//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09dc: Expected VT, but got Unknown
			//IL_09e9: Expected Ref, but got VT
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bb: Expected Obj, but got Unknown
			//IL_05c3: Expected Obj, but got VT
			//IL_05fd: Expected Obj, but got I4
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_0626: Expected VT, but got Unknown
			//IL_0637: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj2 = 0;
			TaskAwaiter awaiter = default;
			TaskAwaiter awaiter3 = default;
			System.__Canon stateMachine = default;
			nint num = default;
			bool flag6;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					awaiter = _003C_003Eu__1;
					goto IL_02df;
				}
				CloudServices cloudServices = _003C_003E4__this;
				if ((object)_003C_003E4__this == null)
				{
					goto IL_082e;
				}
				CloudCommunicator communicator = cloudServices._communicator;
				if ((object)cloudServices._communicator == null)
				{
					goto IL_063c;
				}
				bool flag = (byte)(~(communicator.WasExtracted__BackingField ? 1u : 0u)) != 0;
				object obj3 = !flag;
				if (obj3 != null)
				{
					goto IL_0ac0;
				}
				if (communicator.Client__BackingField == null)
				{
					goto IL_0882;
				}
				bool inRoom = communicator.Client__BackingField.InRoom;
				bool flag2 = !inRoom;
				num = unchecked((nint)null);
				if (flag2)
				{
					goto IL_0079;
				}
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v53+A0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v54+E0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v54+E0]");
				bool flag3 = (nint)0 == 0;
				num = unchecked((nint)null);
				AsyncConfig asyncConfig;
				if (!flag3)
				{
					CloudServices cloudServices2 = _003C_003E4__this;
					bool flag4 = (object)_003C_003E4__this == null;
					num = unchecked((nint)null);
					if (flag4)
					{
						goto IL_08ba;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X9_v33+10]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X9_v33+10]");
					bool flag5 = (nint)0 == 0;
					num = unchecked((nint)null);
					if (flag5)
					{
						goto IL_08c8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55D8]");
					object obj8 = 0;
					object obj9 = obj7;
					num = (nint)cloudServices2._runner;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X10_v26+190]");
					asyncConfig = (AsyncConfig)0;
					flag6 = (byte)(int)obj8 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v643 @ X10_v26+188] (should have been resolved before IL gen)");
				}
				CloudServices cloudServices3 = _003C_003E4__this;
				if ((object)_003C_003E4__this == null)
				{
					goto IL_0890;
				}
				CloudCommunicator communicator2 = cloudServices3._communicator;
				if ((object)cloudServices3._communicator == null)
				{
					goto IL_089e;
				}
				Task task = AsyncExtensions.LeaveRoomAsync(communicator2.Client__BackingField, becomeInactive: false, throwOnError: true);
				bool flag7 = task == null;
				object obj10 = 0;
				flag6 = true;
				asyncConfig = null;
				num = unchecked((nint)null);
				if (flag7)
				{
					goto IL_08ac;
				}
				TaskAwaiter awaiter2 = task.GetAwaiter();
				bool isCompleted = awaiter3.IsCompleted;
				bool flag8 = !isCompleted;
				object obj11 = !flag8;
				obj10 = 0;
				flag6 = true;
				asyncConfig = null;
				if (obj11 == null)
				{
					object obj12 = this + 56;
					obj12 = awaiter3;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v98+E4]");
					bool flag9 = (nint)0 == 0;
					object obj14 = !flag9;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter3, ref stateMachine);
					return;
				}
			}
			else
			{
				_003C_003Eu__1 = (TaskAwaiter)0;
				_003C_003E1__state = -1;
				awaiter3 = _003C_003Eu__1;
			}
			awaiter3.GetResult();
			num = unchecked((nint)null);
			goto IL_0079;
			IL_082e:
			NullReferenceException ex = new NullReferenceException();
			goto IL_083c;
			IL_0812:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0820;
			IL_084a:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0858;
			IL_0820:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_082e;
			IL_0858:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0866;
			IL_0866:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0874;
			IL_0874:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0882;
			IL_0882:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0890;
			IL_0890:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_089e;
			IL_063c:
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v31+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v32+E0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v32+E0]");
			if ((nint)0 != 0)
			{
				CloudServices cloudServices4 = _003C_003E4__this;
				if ((object)_003C_003E4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X9_v21+10]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X9_v21+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55E0]");
						object obj19 = 0;
						object obj20 = obj18;
						num = (nint)cloudServices4._runner;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X10_v20+190]");
						AsyncConfig asyncConfig = (AsyncConfig)0;
						flag6 = (byte)(int)obj19 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v309 @ X10_v20+188] (should have been resolved before IL gen)");
						goto IL_0ac0;
					}
				}
				else
				{
					NullReferenceException ex10 = new NullReferenceException();
				}
				NullReferenceException ex11 = new NullReferenceException();
				goto IL_0804;
			}
			goto IL_0ac0;
			IL_0ac0:
			object obj21 = obj;
			_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v5+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(this + 24);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
			return;
			IL_089e:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_08ac;
			IL_08ac:
			NullReferenceException ex13 = new NullReferenceException();
			goto IL_08ba;
			IL_083c:
			NullReferenceException ex14 = new NullReferenceException();
			goto IL_084a;
			IL_02df:
			awaiter.GetResult();
			num = unchecked((nint)null);
			goto IL_063c;
			IL_0804:
			NullReferenceException ex15 = new NullReferenceException();
			goto IL_0812;
			IL_0079:
			CloudServices cloudServices5 = _003C_003E4__this;
			if ((object)_003C_003E4__this == null)
			{
				goto IL_0804;
			}
			CloudCommunicator communicator3 = cloudServices5._communicator;
			if ((object)cloudServices5._communicator == null)
			{
				goto IL_0812;
			}
			if (communicator3.Client__BackingField == null)
			{
				goto IL_0820;
			}
			bool isConnectedAndReady = communicator3.Client__BackingField.IsConnectedAndReady;
			bool flag11 = !isConnectedAndReady;
			num = unchecked((nint)null);
			if (flag11)
			{
				goto IL_063c;
			}
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v39+A0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v40+E0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v40+E0]");
			bool flag12 = (nint)0 == 0;
			num = unchecked((nint)null);
			if (!flag12)
			{
				CloudServices cloudServices6 = _003C_003E4__this;
				bool flag13 = (object)_003C_003E4__this == null;
				num = unchecked((nint)null);
				if (flag13)
				{
					goto IL_0866;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X9_v26+10]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X9_v26+10]");
				bool flag14 = (nint)0 == 0;
				num = unchecked((nint)null);
				if (flag14)
				{
					goto IL_0874;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55E8]");
				object obj27 = 0;
				object obj28 = obj26;
				num = (nint)cloudServices6._runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X10_v24+190]");
				AsyncConfig asyncConfig = (AsyncConfig)0;
				flag6 = (byte)(int)obj27 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v677 @ X10_v24+188] (should have been resolved before IL gen)");
			}
			CloudServices cloudServices7 = _003C_003E4__this;
			if ((object)_003C_003E4__this == null)
			{
				goto IL_083c;
			}
			CloudCommunicator communicator4 = cloudServices7._communicator;
			if ((object)cloudServices7._communicator == null)
			{
				goto IL_084a;
			}
			Task task2 = AsyncExtensions.DisconnectAsync(communicator4.Client__BackingField);
			bool flag15 = task2 == null;
			flag6 = false;
			num = unchecked((nint)null);
			if (!flag15)
			{
				TaskAwaiter awaiter4 = task2.GetAwaiter();
				bool isCompleted2 = awaiter.IsCompleted;
				bool flag16 = !isCompleted2;
				flag6 = false;
				if (!flag16)
				{
					goto IL_02df;
				}
				object obj29 = this + 56;
				obj29 = awaiter;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj30 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v81+E4]");
				bool flag17 = (nint)0 == 0;
				object obj31 = !flag17;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(this + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
				return;
			}
			goto IL_0858;
			IL_08c8:
			NullReferenceException ex16 = new NullReferenceException();
			bool flag18 = num != 1;
			NullReferenceException ex17 = ex16;
			if (!flag18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj33 = default;
				object obj32 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj35 = default;
				object obj34 = obj35 & 1;
				if (obj34 != null)
				{
					object obj36 = 0;
					object obj38 = default;
					object obj37 = (object)(&obj38);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v28+E4]");
					bool flag19 = (nint)0 == 0;
					object obj39 = !flag19;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder4 = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder4)->SetException((Exception)obj33);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj40 = obj33;
				num = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				flag6 = false;
				NullReferenceException ex18 = default;
				ex17 = ex18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_08ba:
			NullReferenceException ex19 = new NullReferenceException();
			goto IL_08c8;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CHandleReflexiveInfoMessage_003Ed__98 : Action<GetRemoteLoginEndpointResponse>
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int sender;

		public Fusion.Protocol.ReflexiveInfo reflexiveInfo;

		public CloudServices _003C_003E4__this;

		private bool _003C_003Es__1;

		private GameMode _003C_003Es__2;

		private long _003CuniqueId_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private unsafe void MoveNext()
		{
			//IL_05b0: Expected VT, but got I4
			//IL_05bf: Expected I4, but got I8
			//IL_06f2: Expected Obj, but got I
			//IL_06fa: Expected I8, but got Obj
			//IL_0bf6: Expected Obj, but got I
			//IL_0c0e: Expected Obj, but got I
			//IL_0c1e: Expected VT, but got I
			//IL_05de: Expected Obj, but got I
			//IL_05ee: Expected Obj, but got I
			//IL_0607: Expected I8, but got Obj
			//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ab: Expected VT, but got Unknown
			//IL_15ba: Expected I4, but got I8
			//IL_15c3: Expected Ref, but got VT
			//IL_0751: Expected VT, but got I4
			//IL_16f8: Expected VT, but got Obj
			//IL_0032: Expected VT, but got I4
			//IL_0041: Expected I4, but got I8
			//IL_160e: Expected I8, but got Obj
			//IL_27d6: Expected I8, but got I4
			//IL_27de: Expected VT, but got Ref
			//IL_27f7: Expected I8, but got I4
			//IL_27ff: Expected Obj, but got Ref
			//IL_076f: Expected Obj, but got I
			//IL_078e: Expected VT, but got I4
			//IL_173d: Expected VT, but got Obj
			//IL_16b3: Expected VT, but got Obj
			//IL_0c7c: Expected Obj, but got I
			//IL_0c99: Expected Obj, but got I
			//IL_0ca1: Expected I4, but got Obj
			//IL_1806: Expected VT, but got Obj
			//IL_191d: Expected VT, but got Obj
			//IL_175c: Expected VT, but got Obj
			//IL_1863: Expected VT, but got Obj
			//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbb: Expected Obj, but got Unknown
			//IL_0cc3: Expected Obj, but got VT
			//IL_0ce3: Expected Obj, but got I
			//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf6: Expected VT, but got Unknown
			//IL_0d07: Expected Ref, but got VT
			//IL_008c: Expected VT, but got Obj
			//IL_0d1c: Expected Obj, but got Ref
			//IL_1972: Expected VT, but got Obj
			//IL_07eb: Expected Obj, but got I
			//IL_080a: Expected VT, but got I4
			//IL_17b1: Expected VT, but got Obj
			//IL_18c8: Expected VT, but got Obj
			//IL_083a: Expected Obj, but got I4
			//IL_084a: Expected VT, but got I4
			//IL_19c7: Expected VT, but got Obj
			//IL_1b90: Expected VT, but got Obj
			//IL_0b43: Expected Obj, but got I
			//IL_0872: Expected Obj, but got I
			//IL_088c: Expected Obj, but got I
			//IL_089f: Expected I, but got Obj
			//IL_281d: Expected Obj, but got I
			//IL_284e: Expected Obj, but got I
			//IL_011f: Expected VT, but got I8
			//IL_012c: Expected VT, but got Obj
			//IL_08c8: Expected Obj, but got I4
			//IL_08d0: Expected I4, but got Obj
			//IL_08e2: Expected VT, but got Obj
			//IL_0bb9: Expected Obj, but got I
			//IL_0bc1: Expected I4, but got Obj
			//IL_0b75: Expected Obj, but got I
			//IL_0b7d: Expected I4, but got Obj
			//IL_1ab7: Expected I8, but got VT
			//IL_1a1c: Expected VT, but got Obj
			//IL_1be5: Expected VT, but got Obj
			//IL_208c: Expected I8, but got Obj
			//IL_0be1: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got I4
			//IL_090d: Expected Obj, but got I4
			//IL_0915: Expected I4, but got Obj
			//IL_092c: Expected VT, but got Obj
			//IL_1ad6: Expected VT, but got Obj
			//IL_20ab: Expected VT, but got Obj
			//IL_20d9: Expected I8, but got Obj
			//IL_1b14: Expected I8, but got VT
			//IL_0198: Expected I8, but got I4
			//IL_01a0: Expected VT, but got I4
			//IL_1a71: Expected VT, but got I8
			//IL_1a79: Expected VT, but got Obj
			//IL_1c3a: Expected VT, but got Obj
			//IL_095c: Expected Obj, but got I
			//IL_0986: Expected Obj, but got I4
			//IL_20f8: Expected VT, but got Obj
			//IL_09d1: Expected Obj, but got I4
			//IL_09e2: Expected Obj, but got VT
			//IL_09ea: Expected VT, but got Obj
			//IL_1b33: Expected I8, but got VT
			//IL_1b3b: Expected VT, but got Obj
			//IL_01d8: Expected I8, but got I4
			//IL_01e0: Expected VT, but got I4
			//IL_2126: Expected I8, but got Obj
			//IL_1c8f: Expected VT, but got Obj
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected Obj, but got Unknown
			//IL_023f: Expected I8, but got Obj
			//IL_2145: Expected VT, but got Obj
			//IL_0a31: Expected Obj, but got I4
			//IL_0a3a: Expected Obj, but got I4
			//IL_2173: Expected I8, but got Obj
			//IL_0255: Expected Obj, but got Ref
			//IL_1ce4: Expected VT, but got Obj
			//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5c: Expected Obj, but got Unknown
			//IL_0a64: Expected Obj, but got VT
			//IL_0a84: Expected Obj, but got I
			//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a97: Expected VT, but got Unknown
			//IL_0aa8: Expected Ref, but got VT
			//IL_2192: Expected VT, but got Obj
			//IL_0abd: Expected Obj, but got Ref
			//IL_12af: Expected I8, but got Obj
			//IL_02a6: Expected I8, but got Obj
			//IL_21c0: Expected I8, but got Obj
			//IL_0f81: Expected I8, but got Obj
			//IL_1d39: Expected VT, but got Obj
			//IL_12e6: Expected I8, but got Obj
			//IL_02d2: Expected I8, but got Obj
			//IL_21df: Expected VT, but got Obj
			//IL_0fab: Expected I8, but got Obj
			//IL_1d8e: Expected VT, but got Obj
			//IL_220d: Expected I8, but got Obj
			//IL_1304: Expected Obj, but got I
			//IL_132e: Expected Obj, but got I4
			//IL_1e38: Expected VT, but got Obj
			//IL_02f0: Expected Obj, but got I
			//IL_031a: Expected Obj, but got I4
			//IL_136f: Expected VT, but got Ref
			//IL_0fc9: Expected Obj, but got I
			//IL_0ff3: Expected Obj, but got I4
			//IL_1de3: Expected VT, but got Obj
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Expected VT, but got Unknown
			//IL_0353: Expected Ref, but got VT
			//IL_037d: Expected VT, but got I4
			//IL_223c: Expected VT, but got Obj
			//IL_1e95: Expected VT, but got Obj
			//IL_101e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1023: Expected VT, but got Unknown
			//IL_102c: Expected Ref, but got VT
			//IL_1056: Expected VT, but got I4
			//IL_0f26: Expected I8, but got Obj
			//IL_227a: Expected I8, but got Obj
			//IL_03b9: Expected VT, but got I4
			//IL_202f: Expected I8, but got Obj
			//IL_1082: Expected VT, but got I4
			//IL_2299: Expected VT, but got Obj
			//IL_1f0a: Expected VT, but got Obj
			//IL_0405: Expected VT, but got I4
			//IL_22d7: Expected I8, but got Obj
			//IL_205e: Expected VT, but got Obj
			//IL_10be: Expected VT, but got I4
			//IL_0451: Expected VT, but got I4
			//IL_22f6: Expected VT, but got Obj
			//IL_1f57: Expected VT, but got Obj
			//IL_10fa: Expected VT, but got I4
			//IL_2334: Expected I8, but got Obj
			//IL_0485: Expected VT, but got Ref
			//IL_04aa: Expected Obj, but got Ref
			//IL_04b2: Expected VT, but got I4
			//IL_1140: Expected VT, but got I4
			//IL_2353: Expected VT, but got Obj
			//IL_1fa4: Expected VT, but got Obj
			//IL_04d9: Expected Obj, but got Ref
			//IL_04e1: Expected VT, but got I4
			//IL_2391: Expected I8, but got Obj
			//IL_1170: Expected I8, but got I4
			//IL_1178: Expected VT, but got I4
			//IL_0518: Expected Obj, but got Ref
			//IL_0520: Expected VT, but got I4
			//IL_23b0: Expected VT, but got Obj
			//IL_1ff1: Expected Obj, but got I8
			//IL_1ff9: Expected VT, but got Obj
			//IL_11b8: Expected I8, but got I4
			//IL_11c0: Expected VT, but got I4
			//IL_23ee: Expected I8, but got Obj
			//IL_250c: Expected VT, but got Obj
			//IL_055f: Expected VT, but got I4
			//IL_1200: Expected I8, but got I4
			//IL_1208: Expected VT, but got I4
			//IL_240d: Expected I8, but got Obj
			//IL_2415: Expected VT, but got Obj
			//IL_2559: Expected VT, but got Obj
			//IL_0598: Expected VT, but got Ref
			//IL_1230: Expected Obj, but got VT
			//IL_1244: Expected VT, but got Ref
			//IL_2472: Expected VT, but got Obj
			//IL_25bd: Expected VT, but got Obj
			//IL_24bf: Expected VT, but got Obj
			//IL_25fc: Expected I8, but got Obj
			//IL_260f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2614: Expected Obj, but got Unknown
			//IL_26ad: Expected native int or pointer, but got VT
			//IL_263a: Expected Obj, but got I4
			//IL_2642: Expected Obj, but got Ref
			//IL_2657: Unknown result type (might be due to invalid IL or missing references)
			//IL_265c: Expected VT, but got Unknown
			//IL_266b: Expected I4, but got I8
			//IL_2678: Expected Ref, but got VT
			//IL_26f8: Expected I8, but got I4
			TaskAwaiter awaiter = default;
			NullReferenceException ex;
			NullReferenceException ex2;
			object obj4 = default;
			TaskAwaiter<bool> taskAwaiter;
			System.__Canon stateMachine = default;
			Exception ex3;
			TaskCreationOptions taskCreationOptions2 = default;
			object obj3;
			TaskCreationOptions taskCreationOptions;
			long num;
			TaskAwaiter taskAwaiter2;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003Eu__2 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					awaiter = _003C_003Eu__2;
					goto IL_27a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5610]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
				object obj2 = 0;
				bool flag = sender == 0;
				num = (long)obj;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
				bool flag2 = (object)_003C_003E4__this == null;
				taskCreationOptions = (TaskCreationOptions)sender;
				ex = (NullReferenceException)(object)_003C_003E4__this;
				if (flag2)
				{
					goto IL_16cf;
				}
				Task<bool> task = _003C_003E4__this.ConfirmJoin();
				bool flag3 = task == null;
				taskCreationOptions = (TaskCreationOptions)sender;
				ex2 = (NullReferenceException)(object)task;
				if (flag3)
				{
					goto IL_1714;
				}
				TaskAwaiter<bool> awaiter2 = task.GetAwaiter();
				TaskAwaiter<bool> awaiter3 = default;
				bool isCompleted = awaiter3.IsCompleted;
				bool flag4 = !isCompleted;
				obj4 = obj2;
				taskAwaiter = awaiter3;
				taskCreationOptions2 = (TaskCreationOptions)sender;
				if (flag4)
				{
					object obj5 = this + 96;
					obj5 = awaiter3;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55F0]");
					object obj6 = 0;
					obj4 = obj6;
					AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)(this + 24);
					((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<bool>, System.__Canon>(ref awaiter3, ref stateMachine);
					taskCreationOptions2 = (TaskCreationOptions)(int)(&stateMachine);
					ex3 = (Exception)(&awaiter3);
					taskAwaiter2 = (TaskAwaiter)asyncVoidMethodBuilder;
					goto IL_15d5;
				}
			}
			else
			{
				_003C_003Eu__1 = (TaskAwaiter<bool>)0;
				_003C_003E1__state = -1;
				taskAwaiter = _003C_003Eu__1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4500]");
			object obj7 = 0;
			num = (long)obj7;
			bool flag5 = (_003C_003Es__1 = taskAwaiter.GetResult());
			long num2;
			CloudServices cloudServices;
			object obj14;
			if (flag5)
			{
				object obj8 = _003C_003E4__this;
				bool flag6 = (object)_003C_003E4__this == null;
				taskAwaiter2 = (TaskAwaiter)flag5;
				if (flag6)
				{
					goto IL_17b6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X20_v58 (System.Object)+28]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X20_v58 (System.Object)+28]");
				bool flag7 = (nint)0 == 0;
				taskAwaiter2 = (TaskAwaiter)flag5;
				if (flag7)
				{
					goto IL_180b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X8_v119+2F0]");
				_003C_003Es__2 = (GameMode)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X8_v119+2F0]");
				if ((nint)0 == 5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X20_v58 (System.Object)+20]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X20_v58 (System.Object)+20]");
					bool flag8 = (nint)0 == 0;
					taskAwaiter2 = (TaskAwaiter)flag5;
					if (flag8)
					{
						goto IL_1b40;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1822 @ X8_v142+1B0]");
					bool flag9 = (nint)0 == 0;
					object obj11 = !flag9;
					num2 = num;
					taskAwaiter2 = (TaskAwaiter)flag5;
					cloudServices = _003C_003E4__this;
					if (obj11 != null)
					{
						goto IL_0050;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5390]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5600]");
					object obj13 = 0;
					Func<CancellationToken, System.__Canon> func = default;
					func._002Ector((object)_003C_003E4__this, (IntPtr)obj13);
					CloudServices cloudServices2 = _003C_003E4__this;
					bool flag10 = (object)_003C_003E4__this == null;
					obj3 = 0;
					taskCreationOptions = (TaskCreationOptions)obj13;
					obj14 = _003C_003E4__this;
					taskAwaiter2 = (TaskAwaiter)func;
					if (flag10)
					{
						goto IL_2063;
					}
					bool flag11 = (object)cloudServices2._runner == null;
					obj3 = 0;
					taskCreationOptions = (TaskCreationOptions)obj13;
					obj14 = _003C_003E4__this;
					taskAwaiter2 = (TaskAwaiter)cloudServices2._runner;
					if (flag11)
					{
						goto IL_20b0;
					}
					CancellationToken operationsCancellationToken = cloudServices2._runner.OperationsCancellationToken;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
					object obj15 = 0;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2155 @ X0_v136+E4]");
					bool flag12 = (nint)0 == 0;
					object obj17 = !flag12;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Task task2 = TaskManager.Run((Func<CancellationToken, Task>)(object)func, operationsCancellationToken, (TaskCreationOptions)0);
					bool flag13 = task2 == null;
					obj3 = 0;
					taskCreationOptions = (TaskCreationOptions)0;
					obj14 = operationsCancellationToken;
					taskAwaiter2 = (TaskAwaiter)task2;
					if (flag13)
					{
						goto IL_20fd;
					}
					TaskAwaiter awaiter4 = task2.GetAwaiter();
					bool isCompleted2 = awaiter.IsCompleted;
					bool flag14 = !isCompleted2;
					object obj18 = !flag14;
					obj4 = 0;
					taskCreationOptions2 = (TaskCreationOptions)0;
					if (obj18 == null)
					{
						object obj19 = this + 104;
						obj19 = awaiter;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D55F8]");
						object obj20 = 0;
						obj4 = obj20;
						AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)(this + 24);
						((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
						taskCreationOptions2 = (TaskCreationOptions)(int)(&stateMachine);
						ex3 = (Exception)(&awaiter);
						taskAwaiter2 = (TaskAwaiter)asyncVoidMethodBuilder2;
						goto IL_15d5;
					}
					goto IL_27a9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj21 = 0;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v115+A0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v116+10]");
				taskAwaiter2 = (TaskAwaiter)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v116+10]");
				if ((nint)0 != 0)
				{
					CloudServices cloudServices3 = _003C_003E4__this;
					if ((object)_003C_003E4__this == null)
					{
						goto IL_18cd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5620]");
					object obj24 = 0;
					Task task3 = taskAwaiter2.m_task;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1554 @ X10_v46 (System.Threading.Tasks.Task)+190]");
					obj4 = 0;
					taskCreationOptions2 = (TaskCreationOptions)obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1554 @ X10_v46 (System.Threading.Tasks.Task)+188] (should have been resolved before IL gen)");
				}
			}
			goto IL_15a0;
			IL_1868:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag15 = num3 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = num2;
			if (!flag15)
			{
				NullReferenceException ex4 = new NullReferenceException();
				num = num2;
				taskAwaiter2 = (TaskAwaiter)ex4;
				goto IL_18cd;
			}
			goto IL_2770;
			IL_1ce9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag16 = num4 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag16)
			{
				NullReferenceException ex5 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex5;
				goto IL_1d3e;
			}
			goto IL_2770;
			IL_18cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag17 = num5 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			NetAddress netAddress;
			if (!flag17)
			{
				NullReferenceException ex6 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				bool flag18 = num6 != 0;
				obj3 = obj4;
				taskCreationOptions = taskCreationOptions2;
				if (!flag18)
				{
					NullReferenceException ex7 = new NullReferenceException();
					taskAwaiter2 = (TaskAwaiter)ex7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
					bool flag19 = num7 != 0;
					obj3 = obj4;
					taskCreationOptions = taskCreationOptions2;
					if (!flag19)
					{
						NullReferenceException ex8 = new NullReferenceException();
						taskAwaiter2 = (TaskAwaiter)ex8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
						bool flag20 = num8 != 0;
						obj3 = obj4;
						taskCreationOptions = taskCreationOptions2;
						if (!flag20)
						{
							NullReferenceException ex9 = new NullReferenceException();
							taskAwaiter2 = (TaskAwaiter)ex9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
							bool flag21 = num9 != 0;
							obj3 = obj4;
							taskCreationOptions = taskCreationOptions2;
							if (!flag21)
							{
								NullReferenceException ex10 = new NullReferenceException();
								netAddress = (NetAddress)num;
								taskAwaiter2 = (TaskAwaiter)ex10;
								goto IL_1a7e;
							}
						}
					}
				}
			}
			goto IL_2770;
			IL_241a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag22 = num10 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag22)
			{
				NullReferenceException ex11 = new NullReferenceException();
				taskCreationOptions = taskCreationOptions2;
				taskAwaiter2 = (TaskAwaiter)ex11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				bool flag23 = num11 != 0;
				obj3 = obj4;
				if (!flag23)
				{
					NullReferenceException ex12 = new NullReferenceException();
					taskAwaiter2 = (TaskAwaiter)ex12;
					goto IL_24c4;
				}
			}
			goto IL_2770;
			IL_2197:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag24 = num12 != 0;
			num = (long)obj14;
			if (!flag24)
			{
				NullReferenceException ex13 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex13;
				goto IL_21e4;
			}
			goto IL_2770;
			IL_2770:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_180b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag25 = num13 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag25)
			{
				NullReferenceException ex14 = new NullReferenceException();
				num2 = num;
				taskAwaiter2 = (TaskAwaiter)ex14;
				goto IL_1868;
			}
			goto IL_2770;
			IL_1d93:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag26 = num14 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag26)
			{
				NullReferenceException ex15 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex15;
				goto IL_1de8;
			}
			goto IL_2770;
			IL_1e9a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag27 = num15 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			NetAddress netAddress3;
			NetAddress netAddress2 = netAddress3;
			TaskAwaiter taskAwaiter3;
			taskAwaiter2 = taskAwaiter3;
			TaskAwaiter taskAwaiter4;
			if (!flag27)
			{
				NullReferenceException ex16 = new NullReferenceException();
				taskCreationOptions = taskCreationOptions2;
				netAddress2 = netAddress3;
				taskAwaiter2 = (TaskAwaiter)ex16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				bool flag28 = num16 != 0;
				obj3 = obj4;
				if (!flag28)
				{
					NullReferenceException ex17 = new NullReferenceException();
					taskAwaiter2 = (TaskAwaiter)ex17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
					bool flag29 = num17 != 0;
					obj3 = obj4;
					if (!flag29)
					{
						NullReferenceException ex18 = new NullReferenceException();
						taskAwaiter2 = (TaskAwaiter)ex18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
						nint num18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
						bool flag30 = num18 != 0;
						obj3 = obj4;
						if (!flag30)
						{
							NullReferenceException ex19 = new NullReferenceException();
							obj14 = num;
							taskAwaiter4 = (TaskAwaiter)ex19;
							goto IL_1ffe;
						}
					}
				}
			}
			goto IL_2770;
			IL_1b95:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag31 = num19 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag31)
			{
				NullReferenceException ex20 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex20;
				goto IL_1bea;
			}
			goto IL_2770;
			IL_21e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag32 = num20 != 0;
			num = (long)obj14;
			if (!flag32)
			{
				NullReferenceException ex21 = new NullReferenceException();
				obj4 = obj3;
				taskCreationOptions2 = taskCreationOptions;
				taskAwaiter2 = (TaskAwaiter)ex21;
				goto IL_2241;
			}
			goto IL_2770;
			IL_1de8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag33 = num21 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag33)
			{
				NullReferenceException ex22 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex22;
				goto IL_1e3d;
			}
			goto IL_2770;
			IL_2358:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag34 = num22 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = (long)obj14;
			if (!flag34)
			{
				NullReferenceException ex23 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex23;
				goto IL_23b5;
			}
			goto IL_2770;
			IL_1ffe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag35 = num23 != 0;
			obj3 = obj4;
			num = (long)obj14;
			taskAwaiter2 = taskAwaiter4;
			if (!flag35)
			{
				NullReferenceException ex24 = new NullReferenceException();
				obj3 = obj4;
				taskAwaiter2 = (TaskAwaiter)ex24;
				goto IL_2063;
			}
			goto IL_2770;
			IL_15d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag36 = num24 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = (long)ex3;
			if (!flag36)
			{
				return;
			}
			goto IL_2770;
			IL_1c3f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag37 = num25 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag37)
			{
				NullReferenceException ex25 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex25;
				goto IL_1c94;
			}
			goto IL_2770;
			IL_1a7e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag38 = num26 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = (long)netAddress;
			if (!flag38)
			{
				NullReferenceException ex26 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				bool flag39 = num27 != 0;
				obj3 = obj4;
				taskCreationOptions = taskCreationOptions2;
				num = (long)netAddress;
				if (!flag39)
				{
					NullReferenceException ex27 = new NullReferenceException();
					num = (long)netAddress;
					taskAwaiter2 = (TaskAwaiter)ex27;
					goto IL_1b40;
				}
			}
			goto IL_2770;
			IL_2241:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag40 = num28 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = (long)obj14;
			if (!flag40)
			{
				NullReferenceException ex28 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex28;
				goto IL_229e;
			}
			goto IL_2770;
			IL_1b40:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag41 = num29 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag41)
			{
				NullReferenceException ex29 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex29;
				goto IL_1b95;
			}
			goto IL_2770;
			IL_24c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag42 = num30 != 0;
			obj3 = obj4;
			if (!flag42)
			{
				NullReferenceException ex30 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex30;
				goto IL_2511;
			}
			goto IL_2770;
			IL_229e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag43 = num31 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = (long)obj14;
			if (!flag43)
			{
				NullReferenceException ex31 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex31;
				goto IL_22fb;
			}
			goto IL_2770;
			IL_2511:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag44 = num32 != 0;
			obj3 = obj4;
			if (!flag44)
			{
				NullReferenceException ex32 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex32;
				goto IL_255e;
			}
			goto IL_2770;
			IL_214a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag45 = num33 != 0;
			num = (long)obj14;
			if (!flag45)
			{
				NullReferenceException ex33 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex33;
				goto IL_2197;
			}
			goto IL_2770;
			IL_27a9:
			awaiter.GetResult();
			cloudServices = _003C_003E4__this;
			bool flag46 = (object)_003C_003E4__this == null;
			num2 = 0L;
			taskAwaiter2 = (TaskAwaiter)(&awaiter);
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = 0L;
			NullReferenceException ex34 = (NullReferenceException)(&awaiter);
			if (!flag46)
			{
				goto IL_0050;
			}
			goto IL_168a;
			IL_0050:
			CloudServicesMetadata metadata = cloudServices._metadata;
			if (cloudServices._metadata != null)
			{
				int? num34 = (int?)(object)metadata.RemoteReflexiveInfo__BackingField;
				if (metadata.RemoteReflexiveInfo__BackingField != null)
				{
					Fusion.Protocol.ReflexiveInfo reflexiveInfo = this.reflexiveInfo;
					if (this.reflexiveInfo == null)
					{
						goto IL_1868;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ X8_v160 (System.Nullable`1<System.Int32>)+28]");
					if ((nint)0 == reflexiveInfo.ActorNr)
					{
						bool flag47 = (object)cloudServices._runner == null;
						netAddress = (NetAddress)num2;
						taskAwaiter2 = (TaskAwaiter)cloudServices._runner;
						if (!flag47)
						{
							bool isConnectedToServer = cloudServices._runner.IsConnectedToServer;
							bool flag48 = !isConnectedToServer;
							object obj25 = !flag48;
							if (obj25 == null)
							{
								CloudServices cloudServices4 = _003C_003E4__this;
								bool flag49 = (object)_003C_003E4__this == null;
								num = 0L;
								taskAwaiter2 = (TaskAwaiter)isConnectedToServer;
								if (flag49)
								{
									goto IL_1b95;
								}
								CloudServicesMetadata metadata2 = cloudServices4._metadata;
								bool flag50 = cloudServices4._metadata == null;
								num = 0L;
								taskAwaiter2 = (TaskAwaiter)isConnectedToServer;
								if (flag50)
								{
									goto IL_1bea;
								}
								metadata2.RemoteReflexiveInfo__BackingField = this.reflexiveInfo;
								object obj26 = cloudServices4._metadata + 432;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								CloudServices cloudServices5 = _003C_003E4__this;
								bool flag51 = (object)_003C_003E4__this == null;
								num = (long)this.reflexiveInfo;
								if (flag51)
								{
									goto IL_1c3f;
								}
								object obj28 = default;
								object obj27 = (object)(&obj28);
								bool flag52 = (byte)(~(cloudServices5.IsNATPunchthroughEnabled__BackingField ? 1u : 0u)) != 0;
								object obj29 = this.reflexiveInfo;
								if (!flag52)
								{
									CloudServicesMetadata metadata3 = cloudServices5._metadata;
									bool flag53 = cloudServices5._metadata == null;
									num = (long)this.reflexiveInfo;
									if (flag53)
									{
										goto IL_1d3e;
									}
									bool flag54 = metadata3.RemoteReflexiveInfo__BackingField == null;
									num = (long)this.reflexiveInfo;
									if (flag54)
									{
										goto IL_1d93;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
									object obj30 = 0;
									object obj31 = obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2350 @ X0_v180+E4]");
									bool flag55 = (nint)0 == 0;
									object obj32 = !flag55;
									if (obj32 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									NetAddress netAddress4 = (NetAddress)(metadata3.RemoteReflexiveInfo__BackingField + 72);
									bool isValid = ((NetAddress*)netAddress4)->IsValid;
									cloudServices5 = _003C_003E4__this;
									bool flag56 = !isValid;
									obj29 = null;
									taskAwaiter2 = (TaskAwaiter)isValid;
									if (!flag56)
									{
										bool flag57 = (object)_003C_003E4__this == null;
										obj3 = obj4;
										taskCreationOptions = taskCreationOptions2;
										obj14 = null;
										taskAwaiter2 = (TaskAwaiter)isValid;
										if (flag57)
										{
											goto IL_214a;
										}
										CloudServicesMetadata metadata4 = cloudServices5._metadata;
										bool flag58 = cloudServices5._metadata == null;
										obj3 = obj4;
										taskCreationOptions = taskCreationOptions2;
										obj14 = null;
										taskAwaiter2 = (TaskAwaiter)isValid;
										if (flag58)
										{
											goto IL_2197;
										}
										Fusion.Protocol.ReflexiveInfo reflexiveInfo2 = metadata4.RemoteReflexiveInfo__BackingField;
										bool flag59 = metadata4.RemoteReflexiveInfo__BackingField == null;
										obj3 = obj4;
										taskCreationOptions = taskCreationOptions2;
										obj14 = null;
										taskAwaiter2 = (TaskAwaiter)isValid;
										if (flag59)
										{
											goto IL_21e4;
										}
										netAddress2 = reflexiveInfo2.PrivateAddr;
										_ = reflexiveInfo2.PrivateAddr;
										object obj33 = default;
										bool flag60 = _003C_003E4__this.CheckSubnet((NetAddress)(&obj33));
										cloudServices5 = _003C_003E4__this;
										bool flag61 = !flag60;
										obj29 = (object)(&obj33);
										taskAwaiter2 = (TaskAwaiter)flag60;
										if (!flag61)
										{
											bool flag62 = (object)_003C_003E4__this == null;
											obj14 = (object)(&obj33);
											taskAwaiter2 = (TaskAwaiter)flag60;
											if (flag62)
											{
												goto IL_2358;
											}
											CloudServicesMetadata metadata5 = cloudServices5._metadata;
											bool flag63 = cloudServices5._metadata == null;
											obj14 = (object)(&obj33);
											taskAwaiter2 = (TaskAwaiter)flag60;
											if (flag63)
											{
												goto IL_23b5;
											}
											Fusion.Protocol.ReflexiveInfo reflexiveInfo3 = metadata5.RemoteReflexiveInfo__BackingField;
											bool flag64 = metadata5.RemoteReflexiveInfo__BackingField == null;
											num = (nint)(&obj33);
											taskAwaiter2 = (TaskAwaiter)flag60;
											if (!flag64)
											{
												netAddress2 = reflexiveInfo3.PrivateAddr;
												_ = reflexiveInfo3.PrivateAddr;
												object obj34 = default;
												_003C_003E4__this.Connect((NATPunchStage)1, (NetAddress)(&obj34));
												taskCreationOptions2 = (TaskCreationOptions)(int)(&obj34);
												goto IL_15a0;
											}
											goto IL_241a;
										}
									}
									bool flag65 = (object)cloudServices5 == null;
									netAddress3 = netAddress2;
									num = (long)obj29;
									taskAwaiter3 = taskAwaiter2;
									if (flag65)
									{
										goto IL_1e9a;
									}
								}
								if (~(cloudServices5.IsNATPunchthroughEnabled__BackingField ? 1u : 0u) == 0)
								{
									CloudServicesMetadata metadata6 = cloudServices5._metadata;
									bool flag66 = cloudServices5._metadata == null;
									num = (long)obj29;
									if (flag66)
									{
										goto IL_1de8;
									}
									bool flag67 = metadata6.RemoteReflexiveInfo__BackingField == null;
									num = (long)obj29;
									if (flag67)
									{
										goto IL_1e3d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
									object obj35 = 0;
									object obj36 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2404 @ X0_v171+E4]");
									bool flag68 = (nint)0 == 0;
									object obj37 = !flag68;
									if (obj37 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									NetAddress netAddress5 = (NetAddress)(metadata6.RemoteReflexiveInfo__BackingField + 48);
									bool isValid2 = ((NetAddress*)netAddress5)->IsValid;
									cloudServices5 = _003C_003E4__this;
									bool flag69 = !isValid2;
									obj29 = null;
									taskAwaiter2 = (TaskAwaiter)isValid2;
									if (!flag69)
									{
										bool flag70 = (object)_003C_003E4__this == null;
										obj14 = null;
										taskAwaiter2 = (TaskAwaiter)isValid2;
										if (flag70)
										{
											goto IL_2241;
										}
										CloudServicesMetadata metadata7 = cloudServices5._metadata;
										bool flag71 = cloudServices5._metadata == null;
										obj14 = null;
										taskAwaiter2 = (TaskAwaiter)isValid2;
										if (flag71)
										{
											goto IL_229e;
										}
										Fusion.Protocol.ReflexiveInfo reflexiveInfo4 = metadata7.RemoteReflexiveInfo__BackingField;
										bool flag72 = metadata7.RemoteReflexiveInfo__BackingField == null;
										obj14 = null;
										taskAwaiter2 = (TaskAwaiter)isValid2;
										if (flag72)
										{
											goto IL_22fb;
										}
										bool flag73 = Fusion.Sockets.Stun.StunNatTypeExtensions.IsValid(reflexiveInfo4.NatType);
										cloudServices5 = _003C_003E4__this;
										bool flag74 = !flag73;
										obj29 = null;
										taskAwaiter2 = (TaskAwaiter)flag73;
										if (!flag74)
										{
											bool flag75 = (object)_003C_003E4__this == null;
											taskCreationOptions = taskCreationOptions2;
											num = 0L;
											taskAwaiter2 = (TaskAwaiter)flag73;
											if (flag75)
											{
												goto IL_24c4;
											}
											CloudServicesMetadata metadata8 = cloudServices5._metadata;
											bool flag76 = cloudServices5._metadata == null;
											taskCreationOptions = taskCreationOptions2;
											num = 0L;
											taskAwaiter2 = (TaskAwaiter)flag73;
											if (flag76)
											{
												goto IL_2511;
											}
											Fusion.Protocol.ReflexiveInfo reflexiveInfo5 = metadata8.RemoteReflexiveInfo__BackingField;
											bool flag77 = metadata8.RemoteReflexiveInfo__BackingField == null;
											taskCreationOptions = taskCreationOptions2;
											num = 0L;
											taskAwaiter2 = (TaskAwaiter)flag73;
											if (!flag77)
											{
												netAddress2 = reflexiveInfo5.PublicAddr;
												obj27 = reflexiveInfo5.PublicAddr;
												_003C_003E4__this.Connect((NATPunchStage)2, (NetAddress)(&obj28));
												taskCreationOptions2 = (TaskCreationOptions)(int)(&obj28);
												goto IL_15a0;
											}
											goto IL_255e;
										}
									}
									bool flag78 = (object)cloudServices5 == null;
									taskCreationOptions = taskCreationOptions2;
									obj14 = obj29;
									taskAwaiter4 = taskAwaiter2;
									if (flag78)
									{
										goto IL_1ffe;
									}
								}
								CloudServicesMetadata metadata9 = cloudServices5._metadata;
								bool flag79 = cloudServices5._metadata == null;
								num = (long)obj29;
								if (flag79)
								{
									goto IL_1c94;
								}
								Fusion.Protocol.ReflexiveInfo reflexiveInfo6 = metadata9.RemoteReflexiveInfo__BackingField;
								bool flag80 = metadata9.RemoteReflexiveInfo__BackingField == null;
								num = (long)obj29;
								if (flag80)
								{
									goto IL_1ce9;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
								object obj38 = 0;
								object obj39 = obj38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v165+E4]");
								bool flag81 = (nint)0 == 0;
								object obj40 = !flag81;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								NetAddress netAddress6 = NetAddress.FromActorId(reflexiveInfo6.ActorNr);
								NetAddress netAddress7 = default;
								cloudServices5.Connect((NATPunchStage)3, (NetAddress)(&netAddress7));
								taskCreationOptions2 = (TaskCreationOptions)(int)(&netAddress7);
								NetAddress netAddress8 = default;
								netAddress2 = netAddress8;
							}
							goto IL_15a0;
						}
						goto IL_1a7e;
					}
				}
				NetworkRunner runner = cloudServices._runner;
				bool flag82 = (object)cloudServices._runner == null;
				obj3 = obj4;
				taskCreationOptions = taskCreationOptions2;
				num = num2;
				if (!flag82)
				{
					if (runner.StartGameOperation != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5618]");
						object format = 0;
						if (metadata.RemoteReflexiveInfo__BackingField != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
							object obj41 = 0;
							taskCreationOptions2 = (TaskCreationOptions)obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ X8_v160 (System.Nullable`1<System.Int32>)+28]");
							int? num35 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5500]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object arg = default;
						string customMsg = string.Format((string)format, arg, this.reflexiveInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F58]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						StartGameException ex35 = default;
						ex35._002Ector((ShutdownReason)1, customMsg);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F50]");
						object obj44 = 0;
						taskCreationOptions2 = (TaskCreationOptions)obj44;
						((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner.StartGameOperation).SetException((Exception)ex35);
						obj4 = 0;
					}
					goto IL_15a0;
				}
				goto IL_1761;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag83 = num36 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = num2;
			if (!flag83)
			{
				ex34 = new NullReferenceException();
				obj3 = obj4;
				taskCreationOptions = taskCreationOptions2;
				num = num2;
				goto IL_168a;
			}
			goto IL_2770;
			IL_1e3d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag84 = num37 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag84)
			{
				NullReferenceException ex36 = new NullReferenceException();
				netAddress3 = netAddress2;
				taskAwaiter3 = (TaskAwaiter)ex36;
				goto IL_1e9a;
			}
			goto IL_2770;
			IL_1c94:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag85 = num38 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag85)
			{
				NullReferenceException ex37 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex37;
				goto IL_1ce9;
			}
			goto IL_2770;
			IL_168a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag86 = num39 != 0;
			taskAwaiter2 = (TaskAwaiter)ex34;
			if (!flag86)
			{
				ex = new NullReferenceException();
				goto IL_16cf;
			}
			goto IL_2770;
			IL_2063:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag87 = num40 != 0;
			num = (long)obj14;
			if (!flag87)
			{
				NullReferenceException ex38 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex38;
				goto IL_20b0;
			}
			goto IL_2770;
			IL_16cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag88 = num41 != 0;
			taskAwaiter2 = (TaskAwaiter)ex;
			if (!flag88)
			{
				ex2 = new NullReferenceException();
				goto IL_1714;
			}
			goto IL_2770;
			IL_23b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag89 = num42 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = (long)obj14;
			if (!flag89)
			{
				NullReferenceException ex39 = new NullReferenceException();
				num = (long)obj14;
				taskAwaiter2 = (TaskAwaiter)ex39;
				goto IL_241a;
			}
			goto IL_2770;
			IL_1714:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag90 = num43 != 0;
			taskAwaiter2 = (TaskAwaiter)ex2;
			if (!flag90)
			{
				NullReferenceException ex40 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex40;
				goto IL_1761;
			}
			goto IL_2770;
			IL_20b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag91 = num44 != 0;
			num = (long)obj14;
			if (!flag91)
			{
				NullReferenceException ex41 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex41;
				goto IL_20fd;
			}
			goto IL_2770;
			IL_15a0:
			AsyncVoidMethodBuilder asyncVoidMethodBuilder3 = (AsyncVoidMethodBuilder)(this + 24);
			_003C_003E1__state = -2;
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder3)->SetResult();
			ex3 = null;
			taskAwaiter2 = (TaskAwaiter)asyncVoidMethodBuilder3;
			goto IL_15d5;
			IL_22fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag92 = num45 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			num = (long)obj14;
			if (!flag92)
			{
				NullReferenceException ex42 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex42;
				goto IL_2358;
			}
			goto IL_2770;
			IL_1d3e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag93 = num46 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag93)
			{
				NullReferenceException ex43 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex43;
				goto IL_1d93;
			}
			goto IL_2770;
			IL_1bea:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag94 = num47 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag94)
			{
				NullReferenceException ex44 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex44;
				goto IL_1c3f;
			}
			goto IL_2770;
			IL_1761:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			if (num48 == 0)
			{
				NullReferenceException ex45 = new NullReferenceException();
				obj4 = obj3;
				taskCreationOptions2 = taskCreationOptions;
				taskAwaiter2 = (TaskAwaiter)ex45;
				goto IL_17b6;
			}
			goto IL_2770;
			IL_255e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag95 = num49 != 0;
			obj3 = obj4;
			if (!flag95)
			{
				NullReferenceException ex46 = new NullReferenceException();
				bool flag96 = num != 1;
				taskAwaiter2 = (TaskAwaiter)ex46;
				NullReferenceException ex47 = ex46;
				if (!flag96)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj46 = default;
					object obj45 = obj46;
					num = (long)obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj48 = default;
					object obj47 = obj48 & 1;
					if (obj47 != null)
					{
						object obj49 = 0;
						object obj51 = default;
						object obj50 = (object)(&obj51);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						AsyncVoidMethodBuilder asyncVoidMethodBuilder4 = (AsyncVoidMethodBuilder)(this + 24);
						_003C_003E1__state = -2;
						((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder4)->SetException((Exception)obj46);
						taskCreationOptions2 = (TaskCreationOptions)0;
						ex3 = (Exception)obj46;
						taskAwaiter2 = (TaskAwaiter)asyncVoidMethodBuilder4;
						goto IL_15d5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					System.Runtime.CompilerServices.Unsafe.Write(&((TaskAwaiter*)(nint)taskAwaiter2)->m_task, obj46);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
					nint num50 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
					bool flag97 = num50 != 0;
					obj3 = obj4;
					if (flag97)
					{
						goto IL_2770;
					}
					num = 101790920L;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					taskCreationOptions = (TaskCreationOptions)0;
					NullReferenceException ex48 = default;
					ex47 = ex48;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				nint num51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
				bool flag98 = num51 != 0;
				obj3 = obj4;
				if (!flag98)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					obj3 = obj4;
				}
			}
			goto IL_2770;
			IL_17b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag99 = num52 != 0;
			obj3 = obj4;
			taskCreationOptions = taskCreationOptions2;
			if (!flag99)
			{
				NullReferenceException ex49 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex49;
				goto IL_180b;
			}
			goto IL_2770;
			IL_20fd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag100 = num53 != 0;
			num = (long)obj14;
			if (!flag100)
			{
				NullReferenceException ex50 = new NullReferenceException();
				taskAwaiter2 = (TaskAwaiter)ex50;
				goto IL_214a;
			}
			goto IL_2770;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CHandleStartMessage_003Ed__95 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int sender;

		public Fusion.Protocol.Start start;

		public CloudServices _003C_003E4__this;

		private bool _003C_003Es__1;

		private bool _003Cresult_003E5__2;

		private NetworkRunnerInitializeArgs _003CinitArgs_003E5__3;

		private bool _003C_003Es__4;

		private GameMode _003C_003Es__5;

		private CloudServicesMetadata _003C_003Es__6;

		private Fusion.Sockets.Stun.StunResult _003C_003Es__7;

		private Fusion.Sockets.Stun.StunResult _003C_003Es__8;

		private CloudServicesMetadata _003C_003Es__9;

		private Fusion.Sockets.Stun.StunResult _003C_003Es__10;

		private Fusion.Sockets.Stun.StunResult _003C_003Es__11;

		private Exception _003Cex_003E5__12;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<Fusion.Sockets.Stun.StunResult> _003C_003Eu__2;

		private unsafe void MoveNext()
		{
			//IL_2b1c: Expected Obj, but got I
			//IL_01a9: Expected VT, but got I4
			//IL_01b8: Expected I4, but got I8
			//IL_01cf: Expected I4, but got I8
			//IL_2b43: Expected I, but got Obj
			//IL_2b71: Expected VT, but got I4
			//IL_0011: Expected VT, but got I4
			//IL_0016: Expected I4, but got Obj
			//IL_07de: Expected Obj, but got I
			//IL_07f6: Expected Obj, but got I
			//IL_0806: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_0045: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			//IL_0066: Expected VT, but got Obj
			//IL_2c8c: Expected VT, but got I4
			//IL_01eb: Expected Obj, but got Ref
			//IL_18a2: Expected I4, but got Obj
			//IL_18ac: Expected VT, but got I4
			//IL_084e: Expected VT, but got I4
			//IL_0988: Expected VT, but got I4
			//IL_0997: Expected I4, but got I8
			//IL_08d4: Expected VT, but got I4
			//IL_2d94: Expected I4, but got Obj
			//IL_2dcf: Expected Obj, but got I4
			//IL_2dd7: Expected Obj, but got I4
			//IL_18f9: Expected VT, but got I4
			//IL_086c: Expected Obj, but got I
			//IL_0874: Expected I, but got Obj
			//IL_0881: Expected I, but got Obj
			//IL_0891: Expected VT, but got I
			//IL_0899: Expected I4, but got Obj
			//IL_08a6: Expected Obj, but got I4
			//IL_0b70: Expected Obj, but got I4
			//IL_09b6: Expected Obj, but got I
			//IL_09ce: Expected Obj, but got I
			//IL_09de: Expected Obj, but got I
			//IL_0224: Expected VT, but got I4
			//IL_0233: Expected I4, but got I8
			//IL_1920: Expected VT, but got I4
			//IL_0108: Expected Obj, but got I4
			//IL_2ca0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ca5: Expected VT, but got Unknown
			//IL_2cb4: Expected I4, but got I8
			//IL_2cbd: Expected Ref, but got VT
			//IL_2cca: Expected VT, but got I4
			//IL_2cd2: Expected Obj, but got VT
			//IL_2d14: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d19: Expected Obj, but got Unknown
			//IL_2d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d38: Expected Obj, but got Unknown
			//IL_1159: Expected I4, but got Obj
			//IL_0914: Expected Obj, but got I
			//IL_092e: Expected Obj, but got I
			//IL_025d: Expected I, but got Obj
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected Obj, but got Unknown
			//IL_0158: Expected Obj, but got I
			//IL_0160: Expected VT, but got Obj
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected VT, but got Unknown
			//IL_017c: Expected Ref, but got VT
			//IL_0955: Expected Obj, but got I
			//IL_095d: Expected I4, but got Obj
			//IL_0978: Expected VT, but got I4
			//IL_0189: Expected Obj, but got Ref
			//IL_0191: Expected VT, but got Ref
			//IL_0199: Expected Obj, but got VT
			//IL_0a3c: Expected Obj, but got I
			//IL_0a44: Expected I, but got Obj
			//IL_0a51: Expected I4, but got Obj
			//IL_0a61: Expected VT, but got I
			//IL_0a69: Expected VT, but got Obj
			//IL_0a76: Expected Obj, but got I4
			//IL_1438: Expected Obj, but got I4
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Expected Obj, but got Unknown
			//IL_103c: Expected Obj, but got I
			//IL_1054: Expected Obj, but got I
			//IL_1064: Expected Obj, but got I
			//IL_1083: Expected I4, but got VT
			//IL_0ac6: Expected I4, but got VT
			//IL_0c08: Expected Obj, but got I4
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Expected Obj, but got Unknown
			//IL_02b6: Expected Obj, but got I4
			//IL_02c9: Expected Obj, but got I4
			//IL_1478: Expected Obj, but got I4
			//IL_02e1: Expected Obj, but got I4
			//IL_02f4: Expected VT, but got I4
			//IL_0da7: Expected Obj, but got I4
			//IL_0ae4: Expected Obj, but got I
			//IL_0afe: Expected Obj, but got I
			//IL_0c48: Expected Obj, but got I4
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected Obj, but got Unknown
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Expected Obj, but got Unknown
			//IL_0b25: Expected Obj, but got I
			//IL_0b2d: Expected I4, but got Obj
			//IL_0b48: Expected VT, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected Obj, but got Unknown
			//IL_034a: Expected Obj, but got I4
			//IL_10c1: Expected Obj, but got I
			//IL_0de4: Expected Obj, but got I
			//IL_0e0e: Expected Obj, but got I4
			//IL_16f9: Expected Obj, but got I4
			//IL_0e49: Expected Obj, but got I
			//IL_0e59: Expected Obj, but got I
			//IL_0e6b: Expected VT, but got Ref
			//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c2: Expected Obj, but got Unknown
			//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d5: Expected Obj, but got Unknown
			//IL_14e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ea: Expected Obj, but got Unknown
			//IL_10f6: Expected Obj, but got I
			//IL_10fe: Expected I, but got Obj
			//IL_110e: Expected VT, but got I
			//IL_1116: Expected I4, but got Obj
			//IL_1127: Expected Obj, but got I
			//IL_0e81: Expected VT, but got Ref
			//IL_1723: Expected Obj, but got I4
			//IL_1526: Expected VT, but got I4
			//IL_0c9e: Expected Obj, but got I
			//IL_0ca6: Expected VT, but got Obj
			//IL_173f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1744: Expected Obj, but got Unknown
			//IL_1760: Expected VT, but got Ref
			//IL_1553: Expected Obj, but got I
			//IL_155b: Expected VT, but got Obj
			//IL_0407: Expected I4, but got Obj
			//IL_1789: Expected VT, but got I4
			//IL_159d: Expected Obj, but got Ref
			//IL_0448: Expected I4, but got Obj
			//IL_15be: Expected Obj, but got I4
			//IL_17da: Expected Obj, but got I4
			//IL_17eb: Expected VT, but got I4
			//IL_2d7e: Expected Obj, but got Ref
			//IL_0477: Expected I4, but got I8
			//IL_04af: Expected I, but got Obj
			//IL_15f1: Expected Obj, but got I
			//IL_1814: Unknown result type (might be due to invalid IL or missing references)
			//IL_1819: Expected Obj, but got Unknown
			//IL_1833: Expected Obj, but got I
			//IL_183b: Expected VT, but got Obj
			//IL_1841: Unknown result type (might be due to invalid IL or missing references)
			//IL_1846: Expected VT, but got Unknown
			//IL_1857: Expected Ref, but got VT
			//IL_161f: Expected Obj, but got Ref
			//IL_04eb: Expected I, but got Obj
			//IL_1864: Expected Obj, but got Ref
			//IL_186c: Expected VT, but got Ref
			//IL_1874: Expected Obj, but got VT
			//IL_163b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1640: Expected Obj, but got Unknown
			//IL_1646: Unknown result type (might be due to invalid IL or missing references)
			//IL_164b: Expected Obj, but got Unknown
			//IL_1663: Unknown result type (might be due to invalid IL or missing references)
			//IL_1668: Expected Obj, but got Unknown
			//IL_167d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1682: Expected Obj, but got Unknown
			//IL_16b9: Expected VT, but got I4
			//IL_16be: Expected I, but got Obj
			//IL_16c7: Expected VT, but got I4
			//IL_16cf: Expected Obj, but got I4
			//IL_0edc: Expected I, but got Obj
			//IL_0ee9: Expected I, but got Obj
			//IL_0ef1: Expected Obj, but got I4
			//IL_0555: Expected I, but got Obj
			//IL_055d: Expected Obj, but got I4
			//IL_0f70: Expected Obj, but got I4
			//IL_059d: Expected Obj, but got I4
			//IL_05ca: Expected Obj, but got I4
			//IL_0607: Expected I, but got Obj
			//IL_1011: Expected I, but got Obj
			//IL_101a: Expected VT, but got I4
			//IL_063d: Expected I, but got Obj
			//IL_0645: Expected Obj, but got I4
			//IL_0663: Expected Obj, but got I
			//IL_068d: Expected Obj, but got I4
			//IL_2b8f: Expected Obj, but got I
			//IL_2ba4: Expected Obj, but got I
			//IL_2bbe: Expected Obj, but got I
			//IL_2be4: Expected VT, but got Ref
			//IL_2be4: Expected VT, but got Ref
			//IL_2bff: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c04: Expected Obj, but got Unknown
			//IL_06f9: Expected VT, but got Ref
			//IL_0701: Expected I, but got Obj
			//IL_0709: Expected VT, but got Ref
			//IL_0711: Expected Obj, but got I4
			//IL_0766: Expected VT, but got Ref
			//IL_076e: Expected I4, but got Obj
			//IL_0776: Expected VT, but got Ref
			//IL_077e: Expected Obj, but got I4
			//IL_079f: Expected Obj, but got I4
			//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ad: Expected I4, but got Unknown
			//IL_2c54: Expected VT, but got Ref
			//IL_2c5c: Expected I, but got Obj
			//IL_2c64: Expected VT, but got Ref
			//IL_26da: Expected Obj, but got I4
			//IL_2721: Expected I4, but got Obj
			//IL_2734: Unknown result type (might be due to invalid IL or missing references)
			//IL_2739: Expected Obj, but got Unknown
			//IL_2995: Expected I4, but got Obj
			//IL_29a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_29ad: Expected Obj, but got Unknown
			//IL_275f: Expected Obj, but got I4
			//IL_2767: Expected Obj, but got Ref
			//IL_277c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2781: Expected Obj, but got Unknown
			//IL_29d2: Expected Obj, but got Ref
			//IL_29e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_29ec: Expected VT, but got Unknown
			//IL_29fb: Expected I4, but got I8
			//IL_2a08: Expected Ref, but got VT
			//IL_28ad: Expected VT, but got I4
			//IL_2a8e: Expected VT, but got I4
			//IL_2a1e: Expected VT, but got I4
			//IL_2a26: Expected Obj, but got VT
			//IL_28db: Expected I4, but got Obj
			//IL_2928: Expected I4, but got Obj
			//IL_2845: Expected I4, but got VT
			//IL_26a2: Expected Obj, but got I4
			//IL_26b2: Expected I4, but got Obj
			//IL_26ba: Expected I4, but got Obj
			int num = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4500]");
			object obj = 0;
			int num2 = default;
			nint num3;
			TaskAwaiter<bool> taskAwaiter;
			System.__Canon stateMachine = default;
			Exception ex2;
			bool flag;
			NetAddress netAddress2 = default;
			NetAddress netAddress;
			Unity.IL2CPP.Metadata.__Il2CppInt32Enum _Il2CppInt32Enum;
			CloudServices cloudServices;
			if (_003C_003E1__state != 0)
			{
				netAddress = (NetAddress)num2;
				flag = (byte)(int)this != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5668]");
				object obj2 = 0;
				num2 = sender;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
				object obj3 = 0;
				bool flag2 = sender == 0;
				num3 = (nint)obj2;
				netAddress2 = (NetAddress)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
				cloudServices = _003C_003E4__this;
				NullReferenceException ex;
				if ((object)_003C_003E4__this != null)
				{
					Task<bool> task = _003C_003E4__this.ConfirmJoin();
					bool flag3 = task == null;
					ex = (NullReferenceException)(object)task;
					if (!flag3)
					{
						TaskAwaiter<bool> awaiter = task.GetAwaiter();
						TaskAwaiter<bool> awaiter2 = default;
						bool isCompleted = awaiter2.IsCompleted;
						bool flag4 = !isCompleted;
						object obj4 = !flag4;
						taskAwaiter = awaiter2;
						if (obj4 == null)
						{
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter2;
							object obj5 = this + 552;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5638]");
							object obj6 = 0;
							netAddress2 = (NetAddress)obj6;
							AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)(this + 24);
							((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<bool>, System.__Canon>(ref awaiter2, ref stateMachine);
							ex2 = (Exception)(&awaiter2);
							netAddress = (NetAddress)(&stateMachine);
							cloudServices = (CloudServices)asyncVoidMethodBuilder;
							goto IL_1130;
						}
						goto IL_2b3b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
					bool flag5 = num4 != 0;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj2;
					netAddress = (NetAddress)sender;
					if (flag5)
					{
						goto IL_2ae8;
					}
					ex = new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				bool flag6 = num5 != 0;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
				netAddress = (NetAddress)num2;
				cloudServices = (CloudServices)(object)ex;
				if (!flag6)
				{
					NullReferenceException ex3 = new NullReferenceException();
					netAddress = (NetAddress)num2;
					cloudServices = (CloudServices)(object)ex3;
					goto IL_192d;
				}
				goto IL_2ae8;
			}
			_003C_003Eu__1 = (TaskAwaiter<bool>)0;
			_003C_003E1__state = -1;
			taskAwaiter = _003C_003Eu__1;
			num = -1;
			goto IL_2b3b;
			IL_248e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag7 = num6 != 0;
			nint num7;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num7;
			NetAddress netAddress3;
			netAddress = netAddress3;
			if (!flag7)
			{
				NullReferenceException ex4 = new NullReferenceException();
				netAddress = netAddress3;
				cloudServices = (CloudServices)(object)ex4;
				goto IL_24eb;
			}
			goto IL_2ae8;
			IL_1fe9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num8 == 0)
			{
				NullReferenceException ex5 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex5;
				goto IL_202e;
			}
			goto IL_2ae8;
			IL_0cc7:
			CloudServices cloudServices2 = _003C_003E4__this;
			bool flag8 = (object)_003C_003E4__this == null;
			Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> asyncOperationHandler;
			cloudServices = (CloudServices)(object)asyncOperationHandler;
			if (flag8)
			{
				goto IL_1c08;
			}
			NetworkRunner runner = cloudServices2._runner;
			bool flag9 = (object)cloudServices2._runner == null;
			cloudServices = (CloudServices)(object)asyncOperationHandler;
			object obj13 = default;
			object obj11 = default;
			if (!flag9)
			{
				_003C_003Es__5 = runner.GameMode__BackingField;
				if (runner.GameMode__BackingField == (GameMode)2)
				{
					Fusion.Protocol.Start start = this.start;
					bool flag10 = this.start == null;
					cloudServices = (CloudServices)(object)asyncOperationHandler;
					if (flag10)
					{
						goto IL_20b8;
					}
					object obj7 = start.StartRequests & (Fusion.Protocol.StartRequests)2u;
					bool flag11 = obj7 == null;
					num3 = (nint)_Il2CppInt32Enum;
					cloudServices = (CloudServices)(object)asyncOperationHandler;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
						object obj8 = 0;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3116 @ X0_v190+E4]");
						bool flag12 = (nint)0 == 0;
						object obj10 = !flag12;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NetAddress netAddress4 = NetAddress.FromActorId(0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X25_v47+20]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X25_v47+20]");
						object obj12 = 0;
						cloudServices2.Connect((NATPunchStage)3, (NetAddress)(&obj13));
						num3 = 3;
						netAddress = (NetAddress)(&obj13);
						cloudServices = cloudServices2;
					}
				}
				else
				{
					num3 = (nint)_Il2CppInt32Enum;
					cloudServices = (CloudServices)(object)asyncOperationHandler;
				}
				goto IL_102c;
			}
			goto IL_1c4d;
			IL_1efa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag13 = num9 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag13)
			{
				NullReferenceException ex6 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex6;
				goto IL_1f47;
			}
			goto IL_2ae8;
			IL_2187:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num10 == 0)
			{
				NullReferenceException ex7 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex7;
				goto IL_21cc;
			}
			goto IL_2ae8;
			IL_1a61:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag14 = num11 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag14)
			{
				NullReferenceException ex8 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex8;
				goto IL_1aae;
			}
			goto IL_2ae8;
			IL_2a93:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex10 = default;
			NullReferenceException ex9 = ex10;
			goto IL_2aaa;
			IL_258d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			NullReferenceException ex14;
			Unity.IL2CPP.Metadata.__Il2CppInt32Enum _Il2CppInt32Enum2;
			object obj21 = default;
			if (num12 == 0)
			{
				NullReferenceException ex11 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				if (num13 == 0)
				{
					NullReferenceException ex12 = new NullReferenceException();
					cloudServices = (CloudServices)(object)ex12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
					if (num14 == 0)
					{
						NullReferenceException ex13 = new NullReferenceException();
						cloudServices = (CloudServices)(object)ex13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
						nint num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
						if (num15 == 0)
						{
							ex14 = new NullReferenceException();
							bool flag15 = _Il2CppInt32Enum != (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1;
							object obj14 = 0;
							ex9 = ex14;
							_Il2CppInt32Enum2 = _Il2CppInt32Enum;
							if (flag15)
							{
								goto IL_2944;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							object obj16 = default;
							object obj15 = obj16;
							_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
							object obj18 = default;
							object obj17 = obj18 & 1;
							if (obj17 != null)
							{
								object obj19 = 0;
								object obj20 = (object)(&obj21);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								object exception = this + 544;
								_003Cex_003E5__12 = (Exception)obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								CloudServices cloudServices3 = _003C_003E4__this;
								if ((object)_003C_003E4__this != null)
								{
									NetworkRunner runner2 = cloudServices3._runner;
									if ((object)cloudServices3._runner != null)
									{
										if (runner2.StartGameOperation != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
											((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner2.StartGameOperation).SetException((Exception)exception);
											NetAddress netAddress5 = default;
											netAddress = netAddress5;
										}
										num2 = (int)netAddress;
										goto IL_2c9a;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
									nint num16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
									bool flag16 = num16 != 0;
									_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj16;
									if (flag16)
									{
										goto IL_2ae8;
									}
									NullReferenceException ex15 = new NullReferenceException();
									cloudServices = (CloudServices)(object)ex15;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
								nint num17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
								bool flag17 = num17 != 0;
								_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj16;
								if (!flag17)
								{
									ex14 = new NullReferenceException();
									obj14 = 1;
									ex9 = ex14;
									_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj16;
									_Il2CppInt32Enum2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj16;
									goto IL_2944;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
								cloudServices = (CloudServices)obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
								nint num18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
								if (num18 == 0)
								{
									_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)101790920;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
									netAddress = (NetAddress)0;
									goto IL_2a93;
								}
							}
						}
					}
				}
			}
			goto IL_2ae8;
			IL_2b3b:
			num3 = (nint)obj;
			flag = (_003C_003Es__1 = taskAwaiter.GetResult());
			bool flag18 = !flag;
			netAddress = (NetAddress)num2;
			NetAddress netAddress6;
			Version version;
			Fusion.Protocol.ProtocolMessageVersion protocolMessageVersion;
			byte[] array;
			NATType nATType;
			object obj30;
			object obj32;
			NetAddress netAddress7;
			NetAddress netAddress8;
			Version version2 = default;
			Fusion.Protocol.ProtocolMessageVersion protocolMessageVersion2 = default;
			byte[] array2 = default;
			NATType nATType2 = default;
			object obj31 = default;
			if (!flag18)
			{
				bool flag19 = num == 1;
				object obj12 = (object)(&obj13);
				TaskAwaiter<bool> taskAwaiter3;
				if (!flag19)
				{
					if (num == 2)
					{
						_003C_003Eu__2 = (TaskAwaiter<Fusion.Sockets.Stun.StunResult>)0;
						_003C_003E1__state = -1;
						TaskAwaiter<System.__Canon> taskAwaiter2 = (TaskAwaiter<System.__Canon>)_003C_003Eu__2;
						System.__Canon result = taskAwaiter2.GetResult();
						object obj22 = this + 528;
						_003C_003Es__10 = (Fusion.Sockets.Stun.StunResult)(object)result;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj23 = this + 536;
						_003C_003Es__11 = _003C_003Es__10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag20 = _003C_003Es__9 == null;
						num3 = (nint)_003C_003Es__10;
						if (!flag20)
						{
							_003C_003Es__9.LocalReflexiveInfo = _003C_003Es__10;
							_003C_003Es__8 = _003C_003Es__11;
							object obj24 = this + 512;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj25 = this + 520;
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							netAddress = (NetAddress)0;
							_003C_003Es__6 = null;
							object obj26 = this + 496;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_003C_003Es__7 = null;
							object obj27 = this + 504;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj28 = this + 512;
							obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							CloudServices cloudServices4 = _003C_003E4__this;
							bool flag21 = (object)_003C_003E4__this == null;
							_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
							if (flag21)
							{
								goto IL_1c92;
							}
							bool flag22 = cloudServices4._metadata == null;
							_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
							cloudServices = (CloudServices)(object)cloudServices4._metadata;
							if (flag22)
							{
								goto IL_1cd7;
							}
							Fusion.Sockets.Stun.StunResult localReflexiveInfo = cloudServices4._metadata.LocalReflexiveInfo;
							_003C_003E4__this.SendReflexiveInfo(localReflexiveInfo);
							CloudServices cloudServices5 = _003C_003E4__this;
							bool flag23 = (object)_003C_003E4__this == null;
							_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)localReflexiveInfo;
							cloudServices = _003C_003E4__this;
							if (flag23)
							{
								goto IL_1d1c;
							}
							CloudServicesMetadata metadata = cloudServices5._metadata;
							bool flag24 = cloudServices5._metadata == null;
							_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)localReflexiveInfo;
							cloudServices = _003C_003E4__this;
							if (flag24)
							{
								goto IL_1d61;
							}
							ScheduledRequests scheduledRequests = (ScheduledRequests)((int)metadata.ScheduledRequests & 0xFFFFFFFDL);
							metadata.ScheduledRequests = scheduledRequests;
							cloudServices2 = _003C_003E4__this;
							bool flag25 = (object)_003C_003E4__this == null;
							Fusion.Sockets.Stun.StunResult stunResult = localReflexiveInfo;
							num3 = (nint)localReflexiveInfo;
							netAddress6 = netAddress;
							cloudServices = _003C_003E4__this;
							if (!flag25)
							{
								bool flag26 = (object)cloudServices2._runner == null;
								num3 = (nint)stunResult;
								cloudServices = (CloudServices)(object)cloudServices2._runner;
								if (flag26)
								{
									goto IL_1a61;
								}
								bool isClient = cloudServices2._runner.IsClient;
								CloudServices cloudServices6 = _003C_003E4__this;
								nint num19;
								if (isClient)
								{
									bool flag27 = (object)_003C_003E4__this == null;
									num3 = unchecked((nint)null);
									cloudServices = (CloudServices)isClient;
									if (flag27)
									{
										goto IL_1f47;
									}
									CloudServicesMetadata metadata2 = cloudServices6._metadata;
									bool flag28 = cloudServices6._metadata == null;
									_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
									cloudServices = (CloudServices)isClient;
									if (flag28)
									{
										goto IL_1fe9;
									}
									bool flag29 = metadata2.RemoteReflexiveInfo__BackingField == null;
									object obj29 = !flag29;
									version = version2;
									protocolMessageVersion = protocolMessageVersion2;
									array = array2;
									nATType = nATType2;
									obj30 = obj31;
									obj32 = obj11;
									netAddress7 = netAddress2;
									num19 = unchecked((nint)null);
									netAddress8 = netAddress;
									if (obj29 == null)
									{
										Fusion.Protocol.Start start2 = this.start;
										bool flag30 = this.start == null;
										num7 = unchecked((nint)null);
										cloudServices = (CloudServices)isClient;
										if (flag30)
										{
											goto IL_24eb;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
										object obj33 = 0;
										object obj34 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3592 @ X0_v202+E4]");
										bool flag31 = (nint)0 == 0;
										object obj35 = !flag31;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj34 = obj33;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3592 @ X0_v202+A0]");
										object obj36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5270]");
										object obj37 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X25_v47+20]");
										obj11 = 0;
										Fusion.Protocol.ReflexiveInfo reflexiveInfo = default;
										object obj38 = default;
										object obj39 = default;
										reflexiveInfo._002Ector(start2.RemoteServerID, (NetAddress)(&obj38), (NetAddress)(&obj39), (NATType)1, null, (Fusion.Protocol.ProtocolMessageVersion)12);
										metadata2.RemoteReflexiveInfo__BackingField = reflexiveInfo;
										object obj40 = cloudServices6._metadata + 432;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										cloudServices6 = _003C_003E4__this;
										bool flag32 = (object)_003C_003E4__this == null;
										version2 = null;
										protocolMessageVersion2 = (Fusion.Protocol.ProtocolMessageVersion)12;
										array2 = null;
										nATType2 = (NATType)1;
										obj31 = obj36;
										netAddress2 = (NetAddress)(&obj39);
										num7 = (nint)reflexiveInfo;
										netAddress = (NetAddress)(&obj38);
										cloudServices = (CloudServices)isClient;
										if (flag32)
										{
											goto IL_2538;
										}
										Fusion.Protocol.Start start3 = this.start;
										bool flag33 = this.start == null;
										version2 = null;
										protocolMessageVersion2 = (Fusion.Protocol.ProtocolMessageVersion)12;
										array2 = null;
										nATType2 = (NATType)1;
										obj31 = obj36;
										netAddress2 = (NetAddress)(&obj39);
										_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)reflexiveInfo;
										netAddress = (NetAddress)(&obj38);
										cloudServices = (CloudServices)isClient;
										if (flag33)
										{
											goto IL_258d;
										}
										object obj41 = (int)start3.StartRequests >> 2;
										bool flag34 = (byte)(obj41 & 1) != 0;
										if (!cloudServices6.IsNATPunchthroughEnabled__BackingField)
										{
											flag34 = false;
										}
										cloudServices6.IsNATPunchthroughEnabled__BackingField = flag34;
										version = null;
										protocolMessageVersion = (Fusion.Protocol.ProtocolMessageVersion)12;
										array = null;
										nATType = (NATType)1;
										obj30 = obj36;
										obj32 = obj11;
										netAddress7 = (NetAddress)(&obj39);
										num19 = (nint)reflexiveInfo;
										netAddress8 = (NetAddress)(&obj38);
									}
								}
								else
								{
									bool flag35 = (object)_003C_003E4__this == null;
									version = version2;
									protocolMessageVersion = protocolMessageVersion2;
									array = array2;
									nATType = nATType2;
									obj30 = obj31;
									obj32 = obj11;
									netAddress7 = netAddress2;
									num19 = unchecked((nint)null);
									netAddress8 = netAddress;
									num3 = unchecked((nint)null);
									cloudServices = (CloudServices)isClient;
									if (flag35)
									{
										goto IL_1f94;
									}
								}
								CloudServicesMetadata metadata3 = cloudServices6._metadata;
								bool flag36 = cloudServices6._metadata == null;
								version2 = version;
								protocolMessageVersion2 = protocolMessageVersion;
								array2 = array;
								nATType2 = nATType;
								obj31 = obj30;
								obj11 = obj32;
								netAddress2 = netAddress7;
								num3 = num19;
								netAddress = netAddress8;
								cloudServices = (CloudServices)isClient;
								if (flag36)
								{
									goto IL_1aae;
								}
								bool flag37 = (object)cloudServices6._runner == null;
								_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num19;
								cloudServices = (CloudServices)(object)cloudServices6._runner;
								if (!flag37)
								{
									cloudServices6._runner.SetupEncryption(metadata3.EncryptionToken__BackingField);
									version2 = version;
									protocolMessageVersion2 = protocolMessageVersion;
									array2 = array;
									nATType2 = nATType;
									obj31 = obj30;
									obj11 = obj32;
									netAddress2 = netAddress7;
									num3 = (nint)metadata3.EncryptionToken__BackingField;
									netAddress = (NetAddress)0;
									cloudServices = (CloudServices)(object)cloudServices6._runner;
									goto IL_102c;
								}
								goto IL_1b43;
							}
							goto IL_1db6;
						}
						goto IL_1e13;
					}
					CloudServices cloudServices7 = _003C_003E4__this;
					bool flag38 = (object)_003C_003E4__this == null;
					cloudServices = (CloudServices)flag;
					if (flag38)
					{
						goto IL_1e60;
					}
					bool flag39 = (object)cloudServices7._runner == null;
					cloudServices = (CloudServices)(object)cloudServices7._runner;
					if (flag39)
					{
						goto IL_1ead;
					}
					bool isRunning = cloudServices7._runner.IsRunning;
					CloudServices cloudServices8 = _003C_003E4__this;
					if (isRunning)
					{
						bool flag40 = (object)_003C_003E4__this == null;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
						cloudServices = (CloudServices)isRunning;
						if (flag40)
						{
							goto IL_20fd;
						}
						NetworkRunner runner3 = cloudServices8._runner;
						bool flag41 = (object)cloudServices8._runner == null;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
						cloudServices = (CloudServices)isRunning;
						if (!flag41)
						{
							asyncOperationHandler = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner3.StartGameOperation;
							bool flag42 = runner3.StartGameOperation == null;
							_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
							if (!flag42)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5630]");
								object obj42 = 0;
								netAddress = (NetAddress)obj42;
								((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner3.StartGameOperation).SetResult((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0);
								_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
							}
							goto IL_0cc7;
						}
						goto IL_2187;
					}
					bool flag43 = (object)_003C_003E4__this == null;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
					cloudServices = (CloudServices)isRunning;
					if (flag43)
					{
						goto IL_2142;
					}
					CloudServicesMetadata metadata4 = cloudServices8._metadata;
					bool flag44 = cloudServices8._metadata == null;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
					cloudServices = (CloudServices)isRunning;
					if (flag44)
					{
						goto IL_21cc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2814 @ X9_v138 (Fusion.CloudServicesMetadata)+124]");
					bool flag45 = (nint)0 != 4;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
					if (!flag45)
					{
						object obj43 = this + 88;
						object obj44 = cloudServices8._metadata + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj45 = this + 384;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						cloudServices = _003C_003E4__this;
						bool flag46 = (object)_003C_003E4__this == null;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
						netAddress = (NetAddress)400;
						if (flag46)
						{
							goto IL_236a;
						}
						int sessionSlots = _003C_003E4__this.SessionSlots;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
						object obj46 = 0;
						netAddress = (NetAddress)obj46;
						int? num20 = sessionSlots;
						Fusion.Protocol.Start start4 = this.start;
						bool flag47 = this.start == null;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)sessionSlots;
						cloudServices = (CloudServices)(&num20);
						if (flag47)
						{
							goto IL_23af;
						}
						object obj47 = start4.StartRequests & (Fusion.Protocol.StartRequests)8u;
						if (obj47 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v1 (Fusion.CloudServices+<HandleStartMessage>d__95)+1E0]");
							object obj48 = (nint)0 | (nint)4;
						}
						CloudServices cloudServices9 = _003C_003E4__this;
						bool flag48 = (object)_003C_003E4__this == null;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)sessionSlots;
						cloudServices = (CloudServices)(&num20);
						if (flag48)
						{
							goto IL_23f4;
						}
						bool flag49 = cloudServices9._metadata == null;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)sessionSlots;
						cloudServices = (CloudServices)(&num20);
						if (flag49)
						{
							goto IL_2439;
						}
						object obj49 = cloudServices9._metadata + 16;
						object obj50 = this + 88;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj51 = cloudServices9._metadata + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj52 = this + 88;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
						cloudServices8 = _003C_003E4__this;
						bool flag50 = (object)_003C_003E4__this == null;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
						netAddress = (NetAddress)400;
						num7 = unchecked((nint)null);
						netAddress3 = (NetAddress)400;
						cloudServices = (CloudServices)isRunning;
						if (flag50)
						{
							goto IL_248e;
						}
					}
					bool flag51 = cloudServices8._metadata == null;
					cloudServices = (CloudServices)isRunning;
					if (flag51)
					{
						goto IL_2211;
					}
					bool flag52 = (object)cloudServices8._runner == null;
					cloudServices = (CloudServices)isRunning;
					if (flag52)
					{
						goto IL_2256;
					}
					object obj53 = cloudServices8._metadata + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
					object obj54 = default;
					Task<bool> task2 = cloudServices8._runner.Initialize((NetworkRunnerInitializeArgs)(&obj54));
					bool flag53 = task2 == null;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)(int)(&obj54);
					netAddress = (NetAddress)0;
					cloudServices = (CloudServices)(object)task2;
					if (flag53)
					{
						goto IL_229b;
					}
					TaskAwaiter<bool> awaiter3 = task2.GetAwaiter();
					TaskAwaiter<bool> awaiter4 = default;
					bool isCompleted2 = awaiter4.IsCompleted;
					bool flag54 = !isCompleted2;
					object obj55 = !flag54;
					taskAwaiter3 = awaiter4;
					netAddress = (NetAddress)0;
					if (obj55 == null)
					{
						_003C_003E1__state = 1;
						_003C_003Eu__1 = awaiter4;
						object obj56 = this + 552;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5638]");
						object obj57 = 0;
						netAddress2 = (NetAddress)obj57;
						AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)(this + 24);
						((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->AwaitUnsafeOnCompleted<TaskAwaiter<bool>, System.__Canon>(ref awaiter4, ref stateMachine);
						ex2 = (Exception)(&awaiter4);
						netAddress = (NetAddress)(&stateMachine);
						cloudServices = (CloudServices)asyncVoidMethodBuilder2;
						goto IL_1130;
					}
				}
				else
				{
					_003C_003Eu__1 = (TaskAwaiter<bool>)0;
					_003C_003E1__state = -1;
					taskAwaiter3 = _003C_003Eu__1;
				}
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj;
				bool flag55 = (_003Cresult_003E5__2 = (_003C_003Es__4 = taskAwaiter3.GetResult()));
				bool flag56 = !flag55;
				object obj58 = !flag56;
				asyncOperationHandler = (Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)flag55;
				if (obj58 != null)
				{
					goto IL_0cc7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj59 = 0;
				object obj60 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2378 @ X8_v139+A0]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2379 @ X8_v140+10]");
				cloudServices = (CloudServices)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2379 @ X8_v140+10]");
				if ((nint)0 != 0)
				{
					CloudServices cloudServices10 = _003C_003E4__this;
					if ((object)_003C_003E4__this == null)
					{
						goto IL_22e0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5678]");
					object obj62 = 0;
					nint num21 = (nint)cloudServices;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)cloudServices10._runner;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X10_v52 (Il2CppClass<Fusion.CloudServices>)+190]");
					netAddress2 = (NetAddress)0;
					netAddress = (NetAddress)obj62;
					cloudServices = (CloudServices)((NetworkBehaviour)(object)cloudServices).Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002EGetElementWordCount();
				}
				CloudServices cloudServices11 = _003C_003E4__this;
				if ((object)_003C_003E4__this == null)
				{
					goto IL_202e;
				}
				NetworkRunner runner4 = cloudServices11._runner;
				if ((object)cloudServices11._runner == null)
				{
					goto IL_2073;
				}
				bool flag57 = runner4.StartGameOperation == null;
				num2 = (int)netAddress;
				if (!flag57)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F58]");
					object obj63 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5678]");
					object customMsg = 0;
					StartGameException ex16 = default;
					ex16._002Ector((ShutdownReason)1, (string)customMsg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F50]");
					object obj64 = 0;
					num2 = (int)obj64;
					((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner4.StartGameOperation).SetException((Exception)ex16);
					netAddress2 = (NetAddress)0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj65 = 0;
				object obj66 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v10+A0]");
				object obj67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v11+10]");
				cloudServices = (CloudServices)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v11+10]");
				if ((nint)0 != 0)
				{
					CloudServices cloudServices12 = _003C_003E4__this;
					bool flag58 = (object)_003C_003E4__this == null;
					netAddress = (NetAddress)num2;
					if (flag58)
					{
						goto IL_1efa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5680]");
					object obj68 = 0;
					nint num22 = (nint)cloudServices;
					num3 = (nint)cloudServices12._runner;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2321 @ X10_v3 (Il2CppClass<Fusion.CloudServices>)+190]");
					netAddress2 = (NetAddress)0;
					num2 = (int)obj68;
					cloudServices = (CloudServices)((NetworkBehaviour)(object)cloudServices).Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002EGetElementWordCount();
				}
				CloudServices cloudServices13 = _003C_003E4__this;
				bool flag59 = (object)_003C_003E4__this == null;
				netAddress = (NetAddress)num2;
				if (flag59)
				{
					goto IL_192d;
				}
				NetworkRunner runner5 = cloudServices13._runner;
				bool flag60 = (object)cloudServices13._runner == null;
				netAddress = (NetAddress)num2;
				if (flag60)
				{
					goto IL_197a;
				}
				if (runner5.StartGameOperation != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F58]");
					object obj69 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5680]");
					object customMsg2 = 0;
					StartGameException ex17 = default;
					ex17._002Ector((ShutdownReason)1, (string)customMsg2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F50]");
					object obj70 = 0;
					num2 = (int)obj70;
					((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner5.StartGameOperation).SetException((Exception)ex17);
					netAddress2 = (NetAddress)0;
				}
			}
			goto IL_2c9a;
			IL_1f47:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag61 = num23 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag61)
			{
				NullReferenceException ex18 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex18;
				goto IL_1f94;
			}
			goto IL_2ae8;
			IL_23f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num24 == 0)
			{
				NullReferenceException ex19 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex19;
				goto IL_2439;
			}
			goto IL_2ae8;
			IL_2073:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num25 == 0)
			{
				NullReferenceException ex20 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex20;
				goto IL_20b8;
			}
			goto IL_2ae8;
			IL_202e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num26 == 0)
			{
				NullReferenceException ex21 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex21;
				goto IL_2073;
			}
			goto IL_2ae8;
			IL_192d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag62 = num27 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag62)
			{
				NullReferenceException ex22 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex22;
				goto IL_197a;
			}
			goto IL_2ae8;
			IL_20fd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num28 == 0)
			{
				NullReferenceException ex23 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex23;
				goto IL_2142;
			}
			goto IL_2ae8;
			IL_1ead:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag63 = num29 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag63)
			{
				NullReferenceException ex24 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex24;
				goto IL_1efa;
			}
			goto IL_2ae8;
			IL_197a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag64 = num30 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag64)
			{
				NullReferenceException ex25 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex25;
				goto IL_19c7;
			}
			goto IL_2ae8;
			IL_2c9a:
			AsyncVoidMethodBuilder asyncVoidMethodBuilder3 = (AsyncVoidMethodBuilder)(this + 24);
			_003C_003E1__state = -2;
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder3)->SetResult();
			ex2 = null;
			netAddress = (NetAddress)num2;
			cloudServices = (CloudServices)asyncVoidMethodBuilder3;
			goto IL_1130;
			IL_20b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num31 == 0)
			{
				NullReferenceException ex26 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex26;
				goto IL_20fd;
			}
			goto IL_2ae8;
			IL_2439:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num32 == 0)
			{
				NullReferenceException ex27 = new NullReferenceException();
				num7 = (nint)_Il2CppInt32Enum;
				netAddress3 = netAddress;
				cloudServices = (CloudServices)(object)ex27;
				goto IL_248e;
			}
			goto IL_2ae8;
			IL_236a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num33 == 0)
			{
				NullReferenceException ex28 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex28;
				goto IL_23af;
			}
			goto IL_2ae8;
			IL_23af:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num34 == 0)
			{
				NullReferenceException ex29 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex29;
				goto IL_23f4;
			}
			goto IL_2ae8;
			IL_2aaa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num35 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			}
			goto IL_2ae8;
			IL_102c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj71 = 0;
			object obj72 = obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3030 @ X8_v158+A0]");
			object obj73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2767 @ X8_v159+E0]");
			object obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2767 @ X8_v159+E0]");
			bool flag65 = (nint)0 == 0;
			num2 = (int)netAddress;
			if (!flag65)
			{
				if ((object)_003C_003E4__this == null)
				{
					goto IL_19c7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2736 @ X9_v113+10]");
				cloudServices = (CloudServices)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2736 @ X9_v113+10]");
				if ((nint)0 == 0)
				{
					goto IL_1a14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5670]");
				object obj75 = 0;
				nint num36 = (nint)cloudServices;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2668 @ X10_v55 (Il2CppClass<Fusion.CloudServices>)+190]");
				netAddress2 = (NetAddress)0;
				num2 = (int)obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2736 @ X9_v113+10]");
				int num37 = ((NetworkBehaviour)0).Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002EGetElementWordCount();
			}
			goto IL_2c9a;
			IL_19c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag66 = num38 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag66)
			{
				NullReferenceException ex30 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex30;
				goto IL_1a14;
			}
			goto IL_2ae8;
			IL_2142:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num39 == 0)
			{
				NullReferenceException ex31 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex31;
				goto IL_2187;
			}
			goto IL_2ae8;
			IL_1a14:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag67 = num40 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag67)
			{
				NullReferenceException ex32 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex32;
				goto IL_1a61;
			}
			goto IL_2ae8;
			IL_1aae:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag68 = num41 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag68)
			{
				NullReferenceException ex33 = new NullReferenceException();
				version = version2;
				protocolMessageVersion = protocolMessageVersion2;
				array = array2;
				nATType = nATType2;
				obj30 = obj31;
				obj32 = obj11;
				netAddress7 = netAddress2;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
				netAddress8 = netAddress;
				cloudServices = (CloudServices)(object)ex33;
				goto IL_1b43;
			}
			goto IL_2ae8;
			IL_1130:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag69 = num42 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)ex2;
			if (!flag69)
			{
				return;
			}
			goto IL_2ae8;
			IL_21cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num43 == 0)
			{
				NullReferenceException ex34 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex34;
				goto IL_2211;
			}
			goto IL_2ae8;
			IL_1c08:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num44 == 0)
			{
				NullReferenceException ex35 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex35;
				goto IL_1c4d;
			}
			goto IL_2ae8;
			IL_24eb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag70 = num45 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num7;
			if (!flag70)
			{
				NullReferenceException ex36 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex36;
				goto IL_2538;
			}
			goto IL_2ae8;
			IL_2211:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num46 == 0)
			{
				NullReferenceException ex37 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex37;
				goto IL_2256;
			}
			goto IL_2ae8;
			IL_1c4d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num47 == 0)
			{
				NullReferenceException ex38 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex38;
				goto IL_1c92;
			}
			goto IL_2ae8;
			IL_1c92:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num48 == 0)
			{
				NullReferenceException ex39 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex39;
				goto IL_1cd7;
			}
			goto IL_2ae8;
			IL_2ae8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_1b43:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag71 = num49 != 0;
			version2 = version;
			protocolMessageVersion2 = protocolMessageVersion;
			array2 = array;
			nATType2 = nATType;
			obj31 = obj30;
			obj11 = obj32;
			netAddress2 = netAddress7;
			netAddress = netAddress8;
			if (!flag71)
			{
				NullReferenceException ex40 = new NullReferenceException();
				version2 = version;
				protocolMessageVersion2 = protocolMessageVersion;
				array2 = array;
				nATType2 = nATType;
				obj31 = obj30;
				obj11 = obj32;
				netAddress2 = netAddress7;
				netAddress = netAddress8;
				cloudServices = (CloudServices)(object)ex40;
				goto IL_1c08;
			}
			goto IL_2ae8;
			IL_1cd7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num50 == 0)
			{
				NullReferenceException ex41 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex41;
				goto IL_1d1c;
			}
			goto IL_2ae8;
			IL_2256:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num51 == 0)
			{
				NullReferenceException ex42 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex42;
				goto IL_229b;
			}
			goto IL_2ae8;
			IL_1d1c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num52 == 0)
			{
				NullReferenceException ex43 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex43;
				goto IL_1d61;
			}
			goto IL_2ae8;
			IL_1f94:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag72 = num53 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag72)
			{
				NullReferenceException ex44 = new NullReferenceException();
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
				cloudServices = (CloudServices)(object)ex44;
				goto IL_1fe9;
			}
			goto IL_2ae8;
			IL_1d61:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num54 == 0)
			{
				NullReferenceException ex45 = new NullReferenceException();
				num3 = (nint)_Il2CppInt32Enum;
				netAddress6 = netAddress;
				cloudServices = (CloudServices)(object)ex45;
				goto IL_1db6;
			}
			goto IL_2ae8;
			IL_1db6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag73 = num55 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			netAddress = netAddress6;
			if (!flag73)
			{
				NullReferenceException ex46 = new NullReferenceException();
				netAddress = netAddress6;
				cloudServices = (CloudServices)(object)ex46;
				goto IL_1e13;
			}
			goto IL_2ae8;
			IL_2944:
			bool flag74 = _Il2CppInt32Enum2 != (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1;
			cloudServices = (CloudServices)(object)ex14;
			if (flag74)
			{
				goto IL_2aaa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj77 = default;
			object obj76 = obj77;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj79 = default;
			object obj78 = obj79 & 1;
			if (obj78 != null)
			{
				object obj80 = (object)(&obj21);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				AsyncVoidMethodBuilder asyncVoidMethodBuilder4 = (AsyncVoidMethodBuilder)(this + 24);
				_003C_003E1__state = -2;
				((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder4)->SetException((Exception)obj77);
				ex2 = (Exception)obj77;
				netAddress = (NetAddress)0;
				cloudServices = (CloudServices)asyncVoidMethodBuilder4;
				goto IL_1130;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			cloudServices = (CloudServices)obj77;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num56 == 0)
			{
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				netAddress = (NetAddress)0;
				goto IL_2a93;
			}
			goto IL_2ae8;
			IL_229b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num57 == 0)
			{
				NullReferenceException ex47 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex47;
				goto IL_22e0;
			}
			goto IL_2ae8;
			IL_1e13:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag75 = num58 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag75)
			{
				NullReferenceException ex48 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex48;
				goto IL_1e60;
			}
			goto IL_2ae8;
			IL_22e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			if (num59 == 0)
			{
				NullReferenceException ex49 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				nint num60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
				if (num60 == 0)
				{
					NullReferenceException ex50 = new NullReferenceException();
					cloudServices = (CloudServices)(object)ex50;
					goto IL_236a;
				}
			}
			goto IL_2ae8;
			IL_1e60:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag76 = num61 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num3;
			if (!flag76)
			{
				NullReferenceException ex51 = new NullReferenceException();
				cloudServices = (CloudServices)(object)ex51;
				goto IL_1ead;
			}
			goto IL_2ae8;
			IL_2538:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			nint num62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
			bool flag77 = num62 != 0;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num7;
			if (!flag77)
			{
				NullReferenceException ex52 = new NullReferenceException();
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)num7;
				cloudServices = (CloudServices)(object)ex52;
				goto IL_258d;
			}
			goto IL_2ae8;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CMoveSessionToNewRoom_003Ed__117 : Action<GetStatisticsForEntitiesResponse>
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken token;

		public string sessionId;

		public CloudServices _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_10f0: Expected Obj, but got I
			//IL_1100: Expected Obj, but got I
			//IL_098d: Expected VT, but got I4
			//IL_099c: Expected I4, but got I8
			//IL_054d: Expected VT, but got I4
			//IL_055c: Expected I4, but got I8
			//IL_0101: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0e3b: Expected VT, but got I4
			//IL_0e43: Expected Obj, but got I4
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected VT, but got Unknown
			//IL_015c: Expected Ref, but got VT
			//IL_0170: Expected Obj, but got I
			//IL_0183: Expected Obj, but got I4
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected I4, but got Unknown
			//IL_00c3: Expected VT, but got I4
			//IL_00d2: Expected I4, but got I8
			//IL_00e2: Expected VT, but got I4
			//IL_058e: Expected I4, but got Obj
			//IL_01bb: Expected Obj, but got I
			//IL_01cb: Expected Obj, but got I
			//IL_0051: Expected VT, but got I4
			//IL_0060: Expected I4, but got I8
			//IL_0068: Expected VT, but got I4
			//IL_09ff: Expected VT, but got I4
			//IL_0bcc: Expected Obj, but got I
			//IL_0bdc: Expected Obj, but got I
			//IL_05b8: Expected I4, but got Obj
			//IL_0209: Expected Obj, but got I
			//IL_0219: Expected Obj, but got I
			//IL_0248: Expected Obj, but got I
			//IL_122a: Expected I4, but got I8
			//IL_124c: Expected Obj, but got I4
			//IL_0a36: Expected VT, but got I4
			//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9f: Expected VT, but got Unknown
			//IL_0ca8: Expected Ref, but got VT
			//IL_0c11: Expected Obj, but got I
			//IL_0c38: Expected I4, but got VT
			//IL_05f7: Expected VT, but got I4
			//IL_0e9f: Expected I4, but got VT
			//IL_0c56: Expected Obj, but got I
			//IL_0c66: Expected I4, but got Obj
			//IL_0c76: Expected VT, but got I
			//IL_0853: Expected VT, but got I4
			//IL_0ded: Expected I4, but got VT
			//IL_031a: Expected Obj, but got I
			//IL_032a: Expected Obj, but got I
			//IL_0349: Expected Obj, but got I4
			//IL_088e: Expected VT, but got I4
			//IL_0898: Expected Obj, but got VT
			//IL_0f17: Expected Obj, but got I4
			//IL_0367: Expected Obj, but got I
			//IL_0386: Expected I4, but got Obj
			//IL_0fbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc3: Expected Obj, but got Unknown
			//IL_08df: Expected Obj, but got I4
			//IL_03a4: Expected Obj, but got I
			//IL_03c4: Expected Obj, but got I
			//IL_109b: Expected Obj, but got I4
			//IL_06a7: Expected Obj, but got I
			//IL_0b4a: Expected I4, but got VT
			//IL_0b53: Expected Obj, but got I4
			//IL_0437: Expected Obj, but got I4
			//IL_0445: Expected Obj, but got I4
			//IL_0fe9: Expected Obj, but got I4
			//IL_0ff1: Expected Obj, but got Ref
			//IL_100f: Expected I4, but got I8
			//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0901: Expected Obj, but got Unknown
			//IL_0909: Expected Obj, but got VT
			//IL_0943: Expected Obj, but got I4
			//IL_1040: Expected Obj, but got I4
			//IL_0967: Unknown result type (might be due to invalid IL or missing references)
			//IL_096c: Expected VT, but got Unknown
			//IL_097d: Expected Ref, but got VT
			//IL_1063: Unknown result type (might be due to invalid IL or missing references)
			//IL_1068: Expected VT, but got Unknown
			//IL_1075: Expected Ref, but got VT
			//IL_0491: Expected Obj, but got I4
			//IL_049a: Expected Obj, but got I4
			//IL_073e: Expected Obj, but got I4
			//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb9: Expected Obj, but got Unknown
			//IL_0cc1: Expected Obj, but got VT
			//IL_0cfb: Expected Obj, but got I4
			//IL_0d1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d24: Expected VT, but got Unknown
			//IL_0d35: Expected Ref, but got VT
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Expected Obj, but got Unknown
			//IL_04c9: Expected Obj, but got VT
			//IL_0503: Expected Obj, but got I4
			//IL_11c2: Expected Obj, but got VT
			//IL_11ca: Expected Obj, but got I4
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_052c: Expected VT, but got Unknown
			//IL_053d: Expected Ref, but got VT
			//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d45: Expected Obj, but got Unknown
			//IL_0d4d: Expected Obj, but got VT
			//IL_0d87: Expected Obj, but got I4
			//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db0: Expected VT, but got Unknown
			//IL_0dc1: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj2 = 0;
			TaskAwaiter awaiter = default;
			bool flag = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter awaiter3 = default;
			string text;
			TaskAwaiter awaiter4 = default;
			CancellationToken cancellationToken;
			AsyncConfig asyncConfig = default;
			if (_003C_003E1__state <= 1)
			{
				if (_003C_003E1__state == 0)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					awaiter = _003C_003Eu__1;
					goto IL_1171;
				}
				if (_003C_003E1__state == 1)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					cancellationToken = (CancellationToken)flag;
					awaiter2 = _003C_003Eu__1;
					goto IL_07bd;
				}
			}
			else
			{
				if (_003C_003E1__state == 2)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					awaiter3 = _003C_003Eu__1;
					goto IL_11d8;
				}
				if (_003C_003E1__state == 3)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					text = (string)(object)asyncConfig;
					cancellationToken = (CancellationToken)flag;
					awaiter4 = _003C_003Eu__1;
					goto IL_0b9d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v138+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CancellationToken cancellationToken2 = (CancellationToken)(this + 48);
			bool isCancellationRequested = ((CancellationToken*)cancellationToken2)->IsCancellationRequested;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56A8]");
			object obj6 = 0;
			string text2 = (string)obj6;
			object obj7 = !isCancellationRequested;
			bool condition = (byte)(1 & obj7) != 0;
			Assert.Check(condition, (string)obj6);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v79+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v80+E0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v80+E0]");
			bool flag3 = (nint)0 == 0;
			flag = false;
			string text3;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5698]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
				object obj12 = 0;
				text3 = (string)obj12;
				string text4 = (string)obj11 + sessionId + (string)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v41+10]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v41+10]");
				bool flag4 = (nint)0 == 0;
				asyncConfig = null;
				text2 = text4;
				if (flag4)
				{
					goto IL_0f2a;
				}
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v98+1A0]");
				flag = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v604 @ X8_v98+198] (should have been resolved before IL gen)");
				asyncConfig = null;
				text2 = text4;
			}
			CloudServices cloudServices = _003C_003E4__this;
			if ((object)_003C_003E4__this == null)
			{
				goto IL_0eb2;
			}
			if (cloudServices._metadata == null)
			{
				goto IL_0ec0;
			}
			_ = 1;
			if (!_003C_003E4__this.IsInRoom)
			{
				goto IL_056b;
			}
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v83+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X8_v84+E0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X8_v84+E0]");
			bool flag5 = (nint)0 == 0;
			text3 = (string)flag;
			bool flag7;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v85+10]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v85+10]");
				bool flag6 = (nint)0 == 0;
				flag7 = (byte)(int)text2 != 0;
				if (flag6)
				{
					goto IL_0df2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56A0]");
				object obj19 = 0;
				object obj20 = obj18;
				text2 = (string)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1128 @ X9_v42+1A0]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1128 @ X9_v42+198] (should have been resolved before IL gen)");
			}
			CloudServices cloudServices2 = _003C_003E4__this;
			if ((object)_003C_003E4__this == null)
			{
				goto IL_0f38;
			}
			CloudCommunicator communicator = cloudServices2._communicator;
			if ((object)cloudServices2._communicator == null)
			{
				goto IL_0f46;
			}
			Task task = AsyncExtensions.LeaveRoomAsync(communicator.Client__BackingField, becomeInactive: false, throwOnError: true);
			bool flag8 = task == null;
			object obj21 = 0;
			asyncConfig = null;
			text3 = (string)1;
			text2 = null;
			if (flag8)
			{
				goto IL_0f54;
			}
			TaskAwaiter awaiter5 = task.GetAwaiter();
			bool isCompleted = awaiter.IsCompleted;
			bool flag9 = !isCompleted;
			object obj22 = !flag9;
			obj21 = 0;
			asyncConfig = null;
			flag = true;
			System.__Canon stateMachine = default;
			if (obj22 == null)
			{
				object obj23 = this + 72;
				obj23 = awaiter;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj24 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X0_v155+E4]");
				bool flag10 = (nint)0 == 0;
				object obj25 = !flag10;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(this + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter, ref stateMachine);
				return;
			}
			goto IL_1171;
			IL_0df2:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0e00;
			IL_0e2a:
			NullReferenceException ex2 = new NullReferenceException();
			cancellationToken = (CancellationToken)flag;
			text2 = (string)flag7;
			goto IL_0e48;
			IL_0e48:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0e56;
			IL_0ef8:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0f06;
			IL_0e00:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0e0e;
			IL_0e0e:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0e1c;
			IL_0eb2:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0ec0;
			IL_0bb4:
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v41+A0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v42+E0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v42+E0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v43+10]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v43+10]");
				bool flag11 = (nint)0 == 0;
				asyncConfig = (AsyncConfig)(object)text;
				flag = (byte)(int)cancellationToken != 0;
				if (flag11)
				{
					goto IL_0df2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56B0]");
				object obj30 = 0;
				object obj31 = obj29;
				flag7 = (byte)(int)obj30 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X9_v31+1A0]");
				cancellationToken = (CancellationToken)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X9_v31+198] (should have been resolved before IL gen)");
			}
			object obj32 = obj2;
			_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v79+E4]");
			bool flag12 = (nint)0 == 0;
			object obj33 = !flag12;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(this + 24);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
			return;
			IL_0eea:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0ef8;
			IL_0f1c:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_0f2a;
			IL_07bd:
			awaiter2.GetResult();
			CloudServices cloudServices3 = _003C_003E4__this;
			bool flag13 = (object)_003C_003E4__this == null;
			text2 = null;
			if (flag13)
			{
				goto IL_0e56;
			}
			bool flag14 = (object)cloudServices3._runner == null;
			text2 = null;
			if (flag14)
			{
				goto IL_0e64;
			}
			text2 = sessionId;
			cloudServices3._runner.RequestRejoinAllPlayers(sessionId);
			bool flag15 = (object)_003C_003E4__this == null;
			cancellationToken = (CancellationToken)0;
			if (flag15)
			{
				goto IL_0e72;
			}
			Task task2 = _003C_003E4__this._003CMoveSessionToNewRoom_003Eg__WaitRejoin_007C117_0(token);
			bool flag16 = task2 == null;
			cancellationToken = (CancellationToken)0;
			text2 = (string)token;
			if (flag16)
			{
				goto IL_0e80;
			}
			TaskAwaiter awaiter6 = task2.GetAwaiter();
			bool isCompleted2 = awaiter3.IsCompleted;
			bool flag17 = !isCompleted2;
			object obj34 = !flag17;
			flag = false;
			if (obj34 == null)
			{
				object obj35 = this + 72;
				obj35 = awaiter3;
				_ = 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X0_v116+E4]");
				bool flag18 = (nint)0 == 0;
				object obj37 = !flag18;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(this + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter3, ref stateMachine);
				return;
			}
			goto IL_11d8;
			IL_0e56:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_0e64;
			IL_0e1c:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_0e2a;
			IL_0e64:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_0e72;
			IL_0e72:
			NullReferenceException ex13 = new NullReferenceException();
			goto IL_0e80;
			IL_0e80:
			NullReferenceException ex14 = new NullReferenceException();
			goto IL_0e8e;
			IL_0ec0:
			NullReferenceException ex15 = new NullReferenceException();
			goto IL_0ece;
			IL_0ece:
			NullReferenceException ex16 = new NullReferenceException();
			goto IL_0edc;
			IL_11d8:
			awaiter3.GetResult();
			CloudServices cloudServices4 = _003C_003E4__this;
			bool flag19 = (object)_003C_003E4__this == null;
			flag7 = false;
			if (flag19)
			{
				goto IL_0e1c;
			}
			NetworkRunner runner = cloudServices4._runner;
			bool flag20 = (object)cloudServices4._runner == null;
			flag7 = false;
			if (flag20)
			{
				goto IL_0e2a;
			}
			bool flag21 = runner.SessionInfo__BackingField == null;
			cancellationToken = (CancellationToken)flag;
			text2 = null;
			if (!flag21)
			{
				runner.SessionInfo__BackingField.IsVisible = true;
				text = (string)(object)asyncConfig;
				cancellationToken = (CancellationToken)0;
				flag7 = true;
				goto IL_0a44;
			}
			goto IL_0e48;
			IL_0edc:
			NullReferenceException ex17 = new NullReferenceException();
			goto IL_0eea;
			IL_0a44:
			CloudServices cloudServices5 = _003C_003E4__this;
			if ((object)_003C_003E4__this != null)
			{
				if ((object)cloudServices5._runner != null)
				{
					bool isClient = cloudServices5._runner.IsClient;
					bool flag22 = !isClient;
					flag7 = false;
					if (flag22)
					{
						goto IL_0bb4;
					}
					bool flag23 = (object)_003C_003E4__this == null;
					asyncConfig = (AsyncConfig)(object)text;
					text2 = null;
					if (flag23)
					{
						goto IL_0e8e;
					}
					cancellationToken = token;
					text = sessionId;
					Task task3 = _003C_003E4__this._003CMoveSessionToNewRoom_003Eg__RejoinSession_007C117_1((GameMode)5, token, sessionId);
					bool flag24 = task3 == null;
					asyncConfig = (AsyncConfig)(object)sessionId;
					flag = (byte)(int)token != 0;
					text2 = (string)5;
					if (!flag24)
					{
						TaskAwaiter awaiter7 = task3.GetAwaiter();
						if (awaiter4.IsCompleted)
						{
							goto IL_0b9d;
						}
						object obj38 = this + 72;
						obj38 = awaiter4;
						_ = 3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj39 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X0_v101+E4]");
						bool flag25 = (nint)0 == 0;
						object obj40 = !flag25;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AsyncTaskMethodBuilder asyncTaskMethodBuilder4 = (AsyncTaskMethodBuilder)(this + 24);
						((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder4)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter4, ref stateMachine);
						return;
					}
					goto IL_0ea4;
				}
			}
			else
			{
				NullReferenceException ex18 = new NullReferenceException();
			}
			NullReferenceException ex19 = new NullReferenceException();
			asyncConfig = (AsyncConfig)(object)text;
			flag = (byte)(int)cancellationToken != 0;
			goto IL_0df2;
			IL_0f06:
			NullReferenceException ex20 = new NullReferenceException();
			text3 = (string)flag;
			goto IL_0f1c;
			IL_1171:
			awaiter.GetResult();
			text2 = null;
			goto IL_056b;
			IL_056b:
			CloudServices cloudServices6 = _003C_003E4__this;
			bool flag26 = (object)_003C_003E4__this == null;
			flag7 = (byte)(int)text2 != 0;
			if (flag26)
			{
				goto IL_0e00;
			}
			bool flag27 = (object)cloudServices6._runner == null;
			flag7 = (byte)(int)text2 != 0;
			if (flag27)
			{
				goto IL_0e0e;
			}
			bool isServer = cloudServices6._runner.IsServer;
			bool flag28 = !isServer;
			text = (string)(object)asyncConfig;
			cancellationToken = (CancellationToken)flag;
			flag7 = false;
			if (flag28)
			{
				goto IL_0a44;
			}
			CloudServices cloudServices7 = _003C_003E4__this;
			bool flag29 = (object)_003C_003E4__this == null;
			text2 = null;
			if (flag29)
			{
				goto IL_0ece;
			}
			CloudServicesMetadata metadata = cloudServices7._metadata;
			bool flag30 = cloudServices7._metadata == null;
			text2 = null;
			if (flag30)
			{
				goto IL_0edc;
			}
			bool flag31 = metadata.UniqueIdToReflexiveInfoTable == null;
			text2 = null;
			if (flag31)
			{
				goto IL_0eea;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5690]");
			object obj41 = 0;
			text2 = (string)obj41;
			((Dictionary<long, System.__Canon>)(object)metadata.UniqueIdToReflexiveInfoTable).Clear();
			CloudServices cloudServices8 = _003C_003E4__this;
			if ((object)_003C_003E4__this == null)
			{
				goto IL_0ef8;
			}
			if ((object)cloudServices8._runner == null)
			{
				goto IL_0f06;
			}
			bool isPlayer = cloudServices8._runner.IsPlayer;
			cancellationToken = token;
			bool flag32 = !isPlayer;
			object obj42 = !flag32;
			object obj43 = ~obj42;
			GameMode gameMode = ((obj43 != null) ? ((GameMode)3) : ((GameMode)4));
			Task task4 = _003C_003E4__this._003CMoveSessionToNewRoom_003Eg__RejoinSession_007C117_1(gameMode, cancellationToken, sessionId);
			bool flag33 = task4 == null;
			asyncConfig = (AsyncConfig)(object)sessionId;
			text3 = (string)cancellationToken;
			text2 = (string)gameMode;
			if (!flag33)
			{
				TaskAwaiter awaiter8 = task4.GetAwaiter();
				bool isCompleted3 = awaiter2.IsCompleted;
				bool flag34 = !isCompleted3;
				asyncConfig = (AsyncConfig)(object)sessionId;
				if (!flag34)
				{
					goto IL_07bd;
				}
				object obj44 = this + 72;
				obj44 = awaiter2;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj45 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ X0_v134+E4]");
				bool flag35 = (nint)0 == 0;
				object obj46 = !flag35;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder5 = (AsyncTaskMethodBuilder)(this + 24);
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder5)->AwaitUnsafeOnCompleted<TaskAwaiter, System.__Canon>(ref awaiter2, ref stateMachine);
				return;
			}
			goto IL_0f1c;
			IL_0f2a:
			NullReferenceException ex21 = new NullReferenceException();
			goto IL_0f38;
			IL_0f38:
			NullReferenceException ex22 = new NullReferenceException();
			goto IL_0f46;
			IL_0f46:
			NullReferenceException ex23 = new NullReferenceException();
			goto IL_0f54;
			IL_0f54:
			NullReferenceException ex24 = new NullReferenceException();
			bool flag36 = (nint)text2 != 1;
			NullReferenceException ex25 = ex24;
			if (!flag36)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj48 = default;
				object obj47 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj50 = default;
				object obj49 = obj50 & 1;
				if (obj49 != null)
				{
					object obj51 = 0;
					object obj53 = default;
					object obj52 = (object)(&obj53);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X0_v26+E4]");
					bool flag37 = (nint)0 == 0;
					object obj54 = !flag37;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder asyncTaskMethodBuilder6 = (AsyncTaskMethodBuilder)(this + 24);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder6)->SetException((Exception)obj48);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj55 = obj48;
				text2 = (string)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				text3 = null;
				NullReferenceException ex26 = default;
				ex25 = ex26;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0e8e:
			NullReferenceException ex27 = new NullReferenceException();
			flag = (byte)(int)cancellationToken != 0;
			goto IL_0ea4;
			IL_0ea4:
			NullReferenceException ex28 = new NullReferenceException();
			goto IL_0eb2;
			IL_0b9d:
			awaiter4.GetResult();
			flag7 = false;
			goto IL_0bb4;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CQueryReflexiveInfo_003Ed__110 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Fusion.Sockets.Stun.StunResult> _003C_003Et__builder;

		public CloudServices _003C_003E4__this;

		private NetAddress _003CboundLocalAddress_003E5__1;

		private Fusion.Sockets.Stun.StunResult _003C_003Es__2;

		private TaskAwaiter<Fusion.Sockets.Stun.StunResult> _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0af9: Expected Obj, but got I
			//IL_05ed: Expected VT, but got I4
			//IL_05fc: Expected I4, but got I8
			//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b31: Expected Obj, but got Unknown
			//IL_0623: Expected Obj, but got I
			//IL_0632: Expected I4, but got I8
			//IL_0654: Expected Obj, but got I4
			//IL_0679: Expected VT, but got Obj
			//IL_067f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0684: Expected VT, but got Unknown
			//IL_0691: Expected Ref, but got VT
			//IL_0699: Expected I, but got Obj
			//IL_06a1: Expected Obj, but got VT
			//IL_058e: Expected Obj, but got I
			//IL_05b8: Expected Obj, but got I4
			//IL_0b60: Expected Obj, but got I
			//IL_0b68: Expected Obj, but got I
			//IL_0063: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I
			//IL_00cd: Expected Obj, but got I
			//IL_06e6: Expected Obj, but got I
			//IL_0710: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I
			//IL_0114: Expected VT, but got I
			//IL_013b: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_017d: Expected I, but got Obj
			//IL_0185: Expected VT, but got Obj
			//IL_01cb: Expected I, but got Obj
			//IL_01d3: Expected VT, but got Obj
			//IL_0211: Expected Obj, but got Ref
			//IL_022b: Expected Obj, but got I
			//IL_0250: Expected VT, but got I4
			//IL_0278: Expected Obj, but got I
			//IL_029d: Expected VT, but got I4
			//IL_02c5: Expected Obj, but got I
			//IL_02df: Expected Obj, but got I
			//IL_02f2: Expected I, but got Obj
			//IL_0307: Expected Obj, but got I
			//IL_0331: Expected Obj, but got I4
			//IL_0364: Expected Obj, but got I
			//IL_0383: Expected VT, but got I
			//IL_03a8: Expected Obj, but got I
			//IL_03a8: Expected VT, but got Ref
			//IL_03a8: Expected VT, but got Ref
			//IL_03c4: Expected Obj, but got I4
			//IL_03ee: Expected Obj, but got I
			//IL_03f6: Expected I, but got Obj
			//IL_03fe: Expected VT, but got Ref
			//IL_0921: Expected I, but got Obj
			//IL_0934: Unknown result type (might be due to invalid IL or missing references)
			//IL_0939: Expected Obj, but got Unknown
			//IL_095f: Expected Obj, but got I4
			//IL_0967: Expected Obj, but got Ref
			//IL_0985: Expected I4, but got I8
			//IL_044f: Expected Obj, but got I4
			//IL_0460: Expected Obj, but got I4
			//IL_048a: Expected Obj, but got I
			//IL_0492: Expected VT, but got Ref
			//IL_0a84: Expected VT, but got I4
			//IL_09b6: Expected Obj, but got I4
			//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e8: Expected VT, but got Unknown
			//IL_09f5: Expected Ref, but got VT
			//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Expected Obj, but got Unknown
			//IL_04b3: Expected Obj, but got VT
			//IL_04ed: Expected Obj, but got I4
			//IL_0a02: Expected I, but got Obj
			//IL_0a12: Expected Obj, but got VT
			//IL_051a: Expected Obj, but got I
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Expected VT, but got Unknown
			//IL_053e: Expected Ref, but got VT
			//IL_0547: Expected Obj, but got I4
			//IL_0571: Expected VT, but got Ref
			//IL_0579: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5360]");
			object obj = 0;
			TaskAwaiter<System.__Canon> taskAwaiter;
			object obj27;
			object obj28;
			NetAddress? netAddress;
			nint num = default;
			_003CQueryReflexiveInfo_003Ed__110 obj9;
			if (_003C_003E1__state != 0)
			{
				object obj2 = _003C_003E4__this;
				if ((object)_003C_003E4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v8 (System.Object)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v8 (System.Object)+28]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v8 (System.Object)+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v39+58]");
							object obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v39+58]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v40+138]");
								object obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v40+138]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56D8]");
									object obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v41+130]");
									_003CboundLocalAddress_003E5__1 = (NetAddress)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v41+140]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56D0]");
									object obj7 = 0;
									Func<System.__Canon, NetAddress, bool> func = default;
									func._002Ector((object)_003C_003E4__this, (IntPtr)obj7);
									object obj8 = _003C_003E4__this;
									bool flag = (object)_003C_003E4__this == null;
									string text = null;
									num = (nint)_003C_003E4__this;
									netAddress = (NetAddress?)obj7;
									NetAddress netAddress2 = _003CboundLocalAddress_003E5__1;
									obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)func;
									if (flag)
									{
										goto IL_0777;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v11 (System.Object)+20]");
									bool flag2 = (nint)0 == 0;
									text = null;
									num = (nint)_003C_003E4__this;
									netAddress = (NetAddress?)obj7;
									netAddress2 = _003CboundLocalAddress_003E5__1;
									obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)func;
									if (flag2)
									{
										goto IL_07bc;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v11 (System.Object)+20]");
									num = (nint)0 + (nint)16;
									object obj11 = default;
									object obj10 = (object)(&obj11);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v11 (System.Object)+28]");
									object obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v11 (System.Object)+28]");
									bool flag3 = (nint)0 == 0;
									text = null;
									netAddress = (NetAddress?)(object)400;
									netAddress2 = _003CboundLocalAddress_003E5__1;
									if (flag3)
									{
										goto IL_0801;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v47+A8]");
									object obj13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v47+A8]");
									bool flag4 = (nint)0 == 0;
									text = null;
									netAddress = (NetAddress?)(object)400;
									netAddress2 = _003CboundLocalAddress_003E5__1;
									if (flag4)
									{
										goto IL_0846;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F28]");
									object obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56C8]");
									object obj15 = 0;
									Func<bool> func2 = default;
									func2._002Ector((object)_003C_003E4__this, (IntPtr)obj15);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56E0]");
									object obj16 = 0;
									object obj17 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X0_v63+E4]");
									bool flag5 = (nint)0 == 0;
									object obj18 = !flag5;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v48+24]");
									object obj19 = -1;
									bool flag6 = obj19 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X26_v9+F8]");
									netAddress2 = (NetAddress)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v11 (System.Object)+18]");
									NetAddress netAddress3 = default;
									object obj20 = default;
									Task<Fusion.Sockets.Stun.StunResult> task = Fusion.Sockets.Stun.StunClient.QueryReflexiveInfo((NetAddress)(&netAddress3), (Func<byte[], NetAddress, bool>)func, (NetAddress?)(object)(&obj20), (string)0, flag6, func2);
									bool flag7 = task == null;
									object obj21 = 0;
									Func<bool> func3 = func2;
									bool flag8 = flag6;
									NetAddress netAddress4 = _003CboundLocalAddress_003E5__1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v11 (System.Object)+18]");
									text = (string)0;
									num = (nint)func;
									netAddress = (NetAddress?)(object)(&obj20);
									obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)task;
									if (flag7)
									{
										goto IL_088b;
									}
									TaskAwaiter<System.__Canon> awaiter = ((Task<System.__Canon>)(object)task).GetAwaiter();
									TaskAwaiter<System.__Canon> awaiter2 = default;
									bool isCompleted = awaiter2.IsCompleted;
									bool flag9 = !isCompleted;
									object obj22 = !flag9;
									taskAwaiter = awaiter2;
									obj21 = 0;
									func3 = func2;
									flag8 = flag6;
									netAddress4 = _003CboundLocalAddress_003E5__1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v11 (System.Object)+18]");
									text = (string)0;
									netAddress = (NetAddress?)(object)(&obj20);
									if (obj22 == null)
									{
										object obj23 = this + 88;
										obj23 = awaiter2;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj24 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X0_v73+E4]");
										bool flag10 = (nint)0 == 0;
										object obj25 = !flag10;
										if (obj25 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56B8]");
										object obj26 = 0;
										text = (string)obj26;
										AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
										System.__Canon stateMachine = default;
										((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<System.__Canon>, System.__Canon>(ref awaiter2, ref stateMachine);
										obj21 = 0;
										func3 = func2;
										flag8 = flag6;
										netAddress4 = _003CboundLocalAddress_003E5__1;
										num = (nint)(&awaiter2);
										netAddress = (NetAddress?)(object)(&stateMachine);
										obj9 = (_003CQueryReflexiveInfo_003Ed__110)asyncTaskMethodBuilder;
										goto IL_06a6;
									}
									goto IL_0b18;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56E8]");
								obj27 = 0;
								obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v50+E4]");
								bool flag11 = (nint)0 == 0;
								object obj29 = !flag11;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									goto IL_05d5;
								}
								goto IL_0b50;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56E8]");
					obj27 = 0;
					obj28 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v50+E4]");
					bool flag12 = (nint)0 == 0;
					object obj30 = !flag12;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						goto IL_05d5;
					}
					goto IL_0b50;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				bool flag13 = num2 != 0;
				obj9 = this;
				if (!flag13)
				{
					NullReferenceException ex = new NullReferenceException();
					obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)ex;
					goto IL_0777;
				}
				goto IL_0acf;
			}
			_003C_003Eu__1 = (TaskAwaiter<Fusion.Sockets.Stun.StunResult>)0;
			_003C_003E1__state = -1;
			taskAwaiter = (TaskAwaiter<System.__Canon>)_003C_003Eu__1;
			goto IL_0b18;
			IL_05d5:
			obj28 = obj27;
			goto IL_0b50;
			IL_0b18:
			System.__Canon result = taskAwaiter.GetResult();
			object obj31 = this + 80;
			obj31 = result;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			System.__Canon _Canon = result;
			goto IL_060b;
			IL_088b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			if (num3 == 0)
			{
				NullReferenceException ex2 = new NullReferenceException();
				bool flag14 = num != 1;
				obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)ex2;
				NullReferenceException ex3 = ex2;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj33 = default;
					object obj32 = obj33;
					num = (nint)obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj35 = default;
					object obj34 = obj35 & 1;
					if (obj34 != null)
					{
						object obj36 = 0;
						object obj38 = default;
						object obj37 = (object)(&obj38);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						_003C_003E1__state = -2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v34+E4]");
						bool flag15 = (nint)0 == 0;
						object obj39 = !flag15;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
						((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder2)->SetException((Exception)obj33);
						num = (nint)obj33;
						NetAddress? netAddress5 = default;
						netAddress = netAddress5;
						obj9 = (_003CQueryReflexiveInfo_003Ed__110)asyncTaskMethodBuilder2;
						goto IL_06a6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					obj9 = (_003CQueryReflexiveInfo_003Ed__110)obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
					if (num4 != 0)
					{
						goto IL_0acf;
					}
					num = 101790920;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					netAddress = (NetAddress?)(object)0;
					NullReferenceException ex4 = default;
					ex3 = ex4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				if (num5 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
			}
			goto IL_0acf;
			IL_06a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			if (num6 == 0)
			{
				return;
			}
			goto IL_0acf;
			IL_0b50:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v50+A0]");
			obj31 = 0;
			_Canon = (System.__Canon)num;
			goto IL_060b;
			IL_0846:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			if (num7 == 0)
			{
				NullReferenceException ex5 = new NullReferenceException();
				obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)ex5;
				goto IL_088b;
			}
			goto IL_0acf;
			IL_0801:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			if (num8 == 0)
			{
				NullReferenceException ex6 = new NullReferenceException();
				obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)ex6;
				goto IL_0846;
			}
			goto IL_0acf;
			IL_0777:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			if (num9 == 0)
			{
				NullReferenceException ex7 = new NullReferenceException();
				obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)ex7;
				goto IL_07bc;
			}
			goto IL_0acf;
			IL_0acf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_07bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			if (num10 == 0)
			{
				NullReferenceException ex8 = new NullReferenceException();
				obj9 = (_003CQueryReflexiveInfo_003Ed__110)(object)ex8;
				goto IL_0801;
			}
			goto IL_0acf;
			IL_060b:
			object obj40 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56C0]");
			object obj41 = 0;
			_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v12+E4]");
			bool flag16 = (nint)0 == 0;
			object obj42 = !flag16;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			netAddress = (NetAddress?)obj41;
			AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<System.__Canon>)(this + 24);
			((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder3)->SetResult((System.__Canon)obj31);
			num = (nint)obj31;
			obj9 = (_003CQueryReflexiveInfo_003Ed__110)asyncTaskMethodBuilder3;
			goto IL_06a6;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CSendJoin_003Ed__88 : Action<IAsyncOperation>
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken externalCancellationToken;

		public long uniqueId;

		public int playerRefOverride;

		public int playerRefCountOverride;

		public byte[] encryptionKeyOverride;

		public CloudServices _003C_003E4__this;

		private Fusion.Protocol.PeerMode _003CpeerMode_003E5__1;

		private Fusion.Protocol.PluginGameMode _003CjoinMode_003E5__2;

		private Fusion.Protocol.JoinMessageType _003CjoinType_003E5__3;

		private Fusion.Protocol.Join _003CjoinRequest_003E5__4;

		private Fusion.Protocol.Join _003CjoinResponse_003E5__5;

		private GameMode _003C_003Es__6;

		private Fusion.Protocol.Join _003C_003Es__7;

		private TaskAwaiter<Fusion.Protocol.Join> _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_1f82: Expected Obj, but got I
			//IL_01a3: Expected Obj, but got I4
			//IL_01ab: Expected Obj, but got Ref
			//IL_0866: Expected VT, but got I4
			//IL_0878: Expected I4, but got I8
			//IL_20f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_20f7: Expected Obj, but got Unknown
			//IL_2112: Unknown result type (might be due to invalid IL or missing references)
			//IL_2117: Expected Obj, but got Unknown
			//IL_0893: Unknown result type (might be due to invalid IL or missing references)
			//IL_0898: Expected Obj, but got Unknown
			//IL_08a1: Expected Obj, but got I4
			//IL_08b0: Expected I, but got Obj
			//IL_08b9: Expected Obj, but got I4
			//IL_2145: Expected Obj, but got I8
			//IL_0948: Expected Obj, but got I4
			//IL_08d6: Expected Obj, but got I
			//IL_0970: Expected Obj, but got I4
			//IL_00cc: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I4
			//IL_0911: Expected Obj, but got I
			//IL_091a: Expected Obj, but got I4
			//IL_0929: Expected I, but got Obj
			//IL_014e: Expected Obj, but got I4
			//IL_09bd: Expected Obj, but got I4
			//IL_0a12: Expected Obj, but got I
			//IL_0a25: Expected Obj, but got I4
			//IL_0a6f: Expected I, but got Obj
			//IL_0a77: Expected Obj, but got I4
			//IL_172e: Expected I, but got Obj
			//IL_13c5: Expected I, but got Obj
			//IL_0aa6: Expected I, but got Obj
			//IL_0aae: Expected Obj, but got I4
			//IL_1752: Expected I, but got Obj
			//IL_13e9: Expected I, but got Obj
			//IL_200d: Expected Obj, but got I
			//IL_2050: Unknown result type (might be due to invalid IL or missing references)
			//IL_2055: Expected Obj, but got Unknown
			//IL_01f1: Expected I, but got Obj
			//IL_0af2: Expected I, but got Obj
			//IL_0afa: Expected Obj, but got I4
			//IL_0245: Expected Obj, but got I4
			//IL_0256: Expected I, but got Obj
			//IL_0e35: Expected Obj, but got I4
			//IL_0fcb: Expected Obj, but got I4
			//IL_0b18: Expected Obj, but got I
			//IL_0282: Expected Obj, but got I4
			//IL_0b68: Expected I, but got Obj
			//IL_20aa: Expected Obj, but got I4
			//IL_20bb: Expected I, but got Obj
			//IL_02d5: Expected Obj, but got I4
			//IL_02e6: Expected I, but got Obj
			//IL_0b97: Expected I, but got Obj
			//IL_038d: Expected I, but got Obj
			//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb6: Expected Obj, but got Unknown
			//IL_0ed0: Expected Obj, but got I
			//IL_0efa: Expected Obj, but got I4
			//IL_0bba: Expected I, but got Obj
			//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc8: Expected Obj, but got Unknown
			//IL_03ff: Expected I, but got Obj
			//IL_0f2a: Expected VT, but got Ref
			//IL_10e8: Expected I, but got Obj
			//IL_1108: Unknown result type (might be due to invalid IL or missing references)
			//IL_110d: Expected Obj, but got Unknown
			//IL_0f6f: Expected Obj, but got I4
			//IL_0f77: Expected I, but got Obj
			//IL_0f95: Expected Obj, but got I4
			//IL_0f9d: Expected I, but got Obj
			//IL_0c20: Expected I, but got Obj
			//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2e: Expected Obj, but got Unknown
			//IL_0471: Expected Obj, but got I4
			//IL_0479: Expected Obj, but got Ref
			//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8c: Expected Obj, but got Unknown
			//IL_0ca6: Expected Obj, but got I
			//IL_0cbe: Expected Obj, but got I
			//IL_0cce: Expected Obj, but got I
			//IL_0cf2: Expected I, but got Obj
			//IL_04a9: Expected Obj, but got I
			//IL_04c3: Expected Obj, but got I
			//IL_04d3: Expected Obj, but got I
			//IL_04e3: Expected I4, but got Obj
			//IL_1d7b: Expected I, but got Obj
			//IL_1d8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d93: Expected Obj, but got Unknown
			//IL_053d: Expected I, but got VT
			//IL_0d36: Expected I, but got Obj
			//IL_1db9: Expected Obj, but got I4
			//IL_1dc1: Expected Obj, but got Ref
			//IL_1dd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dde: Expected Obj, but got Unknown
			//IL_1de7: Expected Obj, but got I4
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Expected Obj, but got Unknown
			//IL_05c0: Expected I, but got Obj
			//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e0e: Expected Obj, but got Unknown
			//IL_1e17: Expected Obj, but got I4
			//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ea: Expected Obj, but got Unknown
			//IL_11f3: Expected Obj, but got I4
			//IL_1210: Unknown result type (might be due to invalid IL or missing references)
			//IL_1215: Expected Obj, but got Unknown
			//IL_121e: Expected Obj, but got I4
			//IL_0d72: Expected I, but got Obj
			//IL_1e52: Expected Obj, but got I4
			//IL_1257: Expected Obj, but got I4
			//IL_0627: Expected I, but got Obj
			//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e7d: Expected VT, but got Unknown
			//IL_1e8a: Expected Ref, but got VT
			//IL_1e97: Expected I, but got Obj
			//IL_1e9f: Expected Obj, but got VT
			//IL_127d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1282: Expected VT, but got Unknown
			//IL_128b: Expected Ref, but got VT
			//IL_1290: Expected I, but got Obj
			//IL_1298: Expected Obj, but got VT
			//IL_0d90: Expected Obj, but got I
			//IL_0db6: Expected Obj, but got I
			//IL_0dda: Expected I, but got Obj
			//IL_0645: Expected Obj, but got I
			//IL_064d: Expected I, but got Obj
			//IL_0df0: Expected I, but got Obj
			//IL_0e00: Expected Obj, but got I
			//IL_0e0d: Expected Obj, but got I4
			//IL_0e15: Expected I, but got Obj
			//IL_06e7: Expected Obj, but got I4
			//IL_0728: Expected Obj, but got I4
			//IL_0730: Expected Obj, but got Ref
			//IL_0751: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Expected Obj, but got Unknown
			//IL_075e: Expected Obj, but got VT
			//IL_0798: Expected Obj, but got I4
			//IL_07c5: Expected Obj, but got I
			//IL_07cd: Expected I4, but got Obj
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07db: Expected VT, but got Unknown
			//IL_07ec: Expected Ref, but got VT
			//IL_081b: Expected Obj, but got Ref
			//IL_0835: Expected Obj, but got I4
			//IL_083d: Expected Obj, but got Ref
			//IL_0853: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			_003CSendJoin_003Ed__88 obj2 = default;
			int num3 = default;
			object obj13;
			object obj14;
			GameMode gameMode;
			NullReferenceException ex2;
			_003CSendJoin_003Ed__88 obj15;
			NullReferenceException ex3;
			TaskAwaiter<System.__Canon> taskAwaiter;
			object obj26;
			IMessage message = default;
			nint num;
			NullReferenceException ex;
			if (_003C_003E1__state != 0)
			{
				CloudServices cloudServices = _003C_003E4__this;
				bool flag = (object)_003C_003E4__this == null;
				ex = (NullReferenceException)(object)this;
				obj2 = this;
				if (flag)
				{
					goto IL_15de;
				}
				CloudServicesMetadata metadata = cloudServices._metadata;
				bool flag2 = cloudServices._metadata == null;
				ex = (NullReferenceException)(object)this;
				obj2 = this;
				if (flag2)
				{
					goto IL_161b;
				}
				metadata.CurrentJoinStage__BackingField = (JoinProcessStage)0;
				NetworkRunner runner = cloudServices._runner;
				bool flag3 = (object)cloudServices._runner == null;
				ex = (NullReferenceException)(object)this;
				obj2 = this;
				if (flag3)
				{
					goto IL_1658;
				}
				object obj3 = runner.GameMode__BackingField - 2;
				_003C_003Es__6 = runner.GameMode__BackingField;
				bool flag4 = (nint)obj3 < 4;
				object obj4 = !flag4;
				obj2 = this;
				if (obj4 == null)
				{
					object obj5 = obj3 << 3;
					Fusion.Protocol.PeerMode peerMode = (Fusion.Protocol.PeerMode)(33620226 >> (int)obj5);
					Fusion.Protocol.PluginGameMode pluginGameMode = (Fusion.Protocol.PluginGameMode)(16843010 >> (int)obj5);
					bool flag5 = playerRefOverride == 0;
					object obj6 = !flag5;
					object obj7 = ~obj6;
					Fusion.Protocol.JoinMessageType joinMessageType = ((obj7 != null) ? ((Fusion.Protocol.JoinMessageType)1) : ((Fusion.Protocol.JoinMessageType)3));
					_003CpeerMode_003E5__1 = peerMode;
					_003CjoinMode_003E5__2 = pluginGameMode;
					_003CjoinType_003E5__3 = joinMessageType;
					int playerCounterRef;
					byte[] array;
					if (playerRefOverride != 0)
					{
						playerCounterRef = playerRefCountOverride;
						array = encryptionKeyOverride;
					}
					else
					{
						array = null;
						playerCounterRef = 0;
					}
					byte[] array2;
					if (uniqueId != 0)
					{
						byte[] bytes = BitConverter.GetBytes(uniqueId);
						array2 = bytes;
						num = unchecked((nint)null);
					}
					else
					{
						array2 = null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5720]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Fusion.Protocol.Join obj9 = default;
					obj9._002Ector(joinMessageType, pluginGameMode, peerMode, playerRefOverride, (Fusion.Protocol.JoinRequests)0u, array2, array, null, playerCounterRef, (Fusion.Protocol.ProtocolMessageVersion)12);
					object obj10 = this + 96;
					obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					CloudServices cloudServices2 = _003C_003E4__this;
					bool flag6 = (object)_003C_003E4__this == null;
					byte[] array3 = array;
					byte[] array4 = array2;
					int num2 = playerRefOverride;
					Fusion.Protocol.PeerMode peerMode2 = peerMode;
					message = (IMessage)pluginGameMode;
					Fusion.Protocol.JoinRequests joinRequests = (Fusion.Protocol.JoinRequests)0u;
					num = (nint)obj9;
					obj2 = this;
					if (!flag6)
					{
						bool flag7 = (byte)(~(cloudServices2.IsNATPunchthroughEnabled__BackingField ? 1u : 0u)) != 0;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							Fusion.Protocol.Join obj12 = _003CjoinRequest_003E5__4;
							bool flag8 = _003CjoinRequest_003E5__4 == null;
							array3 = array;
							array4 = array2;
							num2 = playerRefOverride;
							peerMode2 = peerMode;
							message = (IMessage)pluginGameMode;
							joinRequests = (Fusion.Protocol.JoinRequests)0u;
							num = (nint)obj9;
							obj2 = this;
							if (flag8)
							{
								goto IL_1d15;
							}
							Fusion.Protocol.JoinRequests joinRequests2 = obj12.JoinRequests | (Fusion.Protocol.JoinRequests)8u;
							obj12.JoinRequests = joinRequests2;
						}
						bool flag9 = (object)cloudServices2._communicator == null;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						peerMode2 = peerMode;
						message = (IMessage)pluginGameMode;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						num = (nint)obj9;
						ex = (NullReferenceException)(object)cloudServices2._communicator;
						obj2 = this;
						if (flag9)
						{
							goto IL_179c;
						}
						message = (IMessage)_003CjoinRequest_003E5__4;
						cloudServices2._communicator.SendMessage(0, (IMessage)_003CjoinRequest_003E5__4);
						CloudServices cloudServices3 = _003C_003E4__this;
						bool flag10 = (object)_003C_003E4__this == null;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						peerMode2 = (Fusion.Protocol.PeerMode)0;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						num = unchecked((nint)null);
						ex = (NullReferenceException)(object)cloudServices2._communicator;
						obj2 = this;
						if (flag10)
						{
							goto IL_17d9;
						}
						CloudServicesMetadata metadata2 = cloudServices3._metadata;
						bool flag11 = cloudServices3._metadata == null;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						peerMode2 = (Fusion.Protocol.PeerMode)0;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						num = unchecked((nint)null);
						ex = (NullReferenceException)(object)cloudServices2._communicator;
						obj2 = this;
						if (flag11)
						{
							goto IL_1816;
						}
						metadata2.CurrentJoinStage__BackingField = (JoinProcessStage)1;
						bool flag12 = num3 == 0;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						peerMode2 = (Fusion.Protocol.PeerMode)0;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						obj13 = 0;
						obj14 = (object)(&obj2);
						gameMode = (GameMode)(int)(&num3);
						ex2 = null;
						obj15 = this;
						if (flag12)
						{
							goto IL_0858;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5708]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5748]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D56F8]");
						object obj18 = 0;
						message = (IMessage)obj17;
						peerMode2 = (Fusion.Protocol.PeerMode)(int)obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3D59200");
						bool flag13 = (object)_003C_003E4__this == null;
						double num4 = 30.0;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						num = (nint)externalCancellationToken;
						if (flag13)
						{
							goto IL_1984;
						}
						object obj19 = _003C_003E4__this + 64;
						obj19 = ex;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						CloudServices cloudServices4 = _003C_003E4__this;
						bool flag14 = (object)_003C_003E4__this == null;
						num4 = 30.0;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						num = (nint)ex;
						if (flag14)
						{
							goto IL_19c1;
						}
						ex3 = (NullReferenceException)(object)cloudServices4._joinAsyncHandler;
						bool flag15 = cloudServices4._joinAsyncHandler == null;
						num4 = 30.0;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						num = (nint)ex;
						if (flag15)
						{
							goto IL_1a06;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5700]");
						object obj20 = 0;
						num = (nint)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3D591E8");
						Task<System.__Canon> task = default;
						bool flag16 = task == null;
						num4 = 30.0;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						ex = (NullReferenceException)(object)task;
						if (flag16)
						{
							goto IL_1a4b;
						}
						TaskAwaiter<System.__Canon> awaiter = task.GetAwaiter();
						TaskAwaiter<System.__Canon> awaiter2 = default;
						bool isCompleted = awaiter2.IsCompleted;
						bool flag17 = !isCompleted;
						object obj21 = !flag17;
						taskAwaiter = awaiter2;
						num4 = 30.0;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						obj13 = 0;
						obj14 = (object)(&obj2);
						gameMode = (GameMode)(int)(&num3);
						ex2 = null;
						if (obj21 != null)
						{
							goto IL_20db;
						}
						object obj22 = this + 128;
						obj22 = awaiter2;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj23 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2887 @ X0_v212+E4]");
						bool flag18 = (nint)0 == 0;
						object obj24 = !flag18;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5710]");
						object obj25 = 0;
						peerMode2 = (Fusion.Protocol.PeerMode)(int)obj25;
						AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(obj2 + 24);
						System.__Canon stateMachine = default;
						((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<System.__Canon>, System.__Canon>(ref awaiter2, ref stateMachine);
						num4 = 30.0;
						array3 = array;
						array4 = array2;
						num2 = playerRefOverride;
						message = (IMessage)(&stateMachine);
						joinRequests = (Fusion.Protocol.JoinRequests)0u;
						num = (nint)(&awaiter2);
						obj13 = 0;
						obj14 = (object)(&obj2);
						gameMode = (GameMode)(int)(&num3);
						ex2 = null;
						obj26 = 28;
						goto IL_2133;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format = default;
					object arg = default;
					string message2 = string.Format(format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					InvalidOperationException ex4 = default;
					ex4._002Ector(message2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
					bool flag19 = num5 != 0;
					message = null;
					num = (nint)ex;
					if (flag19)
					{
						goto IL_1f58;
					}
					ArgumentNullException ex5 = new ArgumentNullException();
					message = null;
					num = (nint)ex;
					ex = (NullReferenceException)(object)ex5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				if (num6 == 0)
				{
					ex = new NullReferenceException();
					goto IL_179c;
				}
				goto IL_1f58;
			}
			obj13 = 0;
			obj14 = (object)(&obj2);
			gameMode = (GameMode)(int)(&num3);
			ex2 = null;
			obj15 = this;
			goto IL_0858;
			IL_190a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num7 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1947;
			}
			goto IL_1f58;
			IL_1470:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num8 == 0)
			{
				ex = new NullReferenceException();
				goto IL_14ad;
			}
			goto IL_1f58;
			IL_1433:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num9 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1470;
			}
			goto IL_1f58;
			IL_2133:
			object obj27 = (long)gameMode & 0x80000000L;
			if (obj27 != null)
			{
				object obj28 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2070 @ X8_v62+50]");
				ex = (NullReferenceException)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2070 @ X8_v62+50]");
				if ((nint)0 == 0)
				{
					goto IL_1a88;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2070 @ X8_v62+50]");
				object obj29 = (nint)0 + (nint)64;
				obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num = unchecked((nint)null);
			}
			bool flag20 = ex2 == null;
			object obj30 = !flag20;
			IMessage message3;
			nint num10;
			NullReferenceException ex6;
			if (obj30 == null)
			{
				bool flag21 = obj13 == null;
				object obj31 = !flag21;
				ex = ex2;
				if (obj31 == null)
				{
					if ((nint)obj26 != 33)
					{
						bool flag22 = obj26 == null;
						object obj32 = !flag22;
						ex = ex2;
						if (obj32 != null)
						{
							goto IL_129d;
						}
					}
					Fusion.Protocol.Join obj33 = obj2._003CjoinResponse_003E5__5;
					if (obj2._003CjoinResponse_003E5__5 == null)
					{
						goto IL_1358;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5740]");
					object obj34 = 0;
					object obj35 = obj33.Type - 2;
					bool flag23 = obj35 == null;
					Assert.Check(flag23, (string)obj34);
					Fusion.Protocol.Join obj36 = obj2._003CjoinResponse_003E5__5;
					bool flag24 = obj2._003CjoinResponse_003E5__5 == null;
					message = null;
					num = (nint)obj34;
					ex = (NullReferenceException)flag23;
					if (flag24)
					{
						goto IL_13f6;
					}
					bool flag25 = obj36.EncryptionKey == null;
					message = null;
					num = (nint)obj34;
					ex = (NullReferenceException)flag23;
					_003CSendJoin_003Ed__88 obj37 = obj2;
					if (!flag25)
					{
						CloudServices cloudServices5 = obj2._003C_003E4__this;
						bool flag26 = (object)obj2._003C_003E4__this == null;
						message = null;
						num = (nint)obj34;
						ex = (NullReferenceException)flag23;
						if (flag26)
						{
							goto IL_1853;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5718]");
						object obj38 = 0;
						CloudServicesMetadata metadata3 = cloudServices5._metadata;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Fusion.Encryption.EncryptionToken encryptionToken = default;
						encryptionToken._002Ector();
						Fusion.Protocol.Join obj39 = obj2._003CjoinResponse_003E5__5;
						bool flag27 = obj2._003CjoinResponse_003E5__5 == null;
						message = null;
						num = unchecked((nint)null);
						ex = (NullReferenceException)(object)encryptionToken;
						if (flag27)
						{
							goto IL_1890;
						}
						bool flag28 = encryptionToken == null;
						message = null;
						num = unchecked((nint)null);
						ex = (NullReferenceException)(object)encryptionToken;
						if (flag28)
						{
							goto IL_18cd;
						}
						num = (nint)obj39.EncryptionKey;
						object obj40 = encryptionToken + 16;
						obj40 = obj39.EncryptionKey;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Fusion.Protocol.Join obj41 = obj2._003CjoinResponse_003E5__5;
						bool flag29 = obj2._003CjoinResponse_003E5__5 == null;
						message = null;
						if (flag29)
						{
							goto IL_190a;
						}
						num = (nint)obj41.EncryptionKeySecret;
						object obj42 = encryptionToken + 24;
						obj42 = obj41.EncryptionKeySecret;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag30 = cloudServices5._metadata == null;
						message = null;
						if (flag30)
						{
							goto IL_1947;
						}
						metadata3.EncryptionToken__BackingField = encryptionToken;
						object obj43 = cloudServices5._metadata + 456;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
						object obj44 = 0;
						object obj45 = obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2790 @ X8_v54+A0]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2791 @ X8_v55+70]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2791 @ X8_v55+70]");
						bool flag31 = (nint)0 == 0;
						message = null;
						num = (nint)encryptionToken;
						obj37 = obj2;
						if (!flag31)
						{
							CloudServices cloudServices6 = obj2._003C_003E4__this;
							bool flag32 = (object)obj2._003C_003E4__this == null;
							message3 = null;
							num10 = (nint)encryptionToken;
							if (flag32)
							{
								goto IL_1c1e;
							}
							CloudServicesMetadata metadata4 = cloudServices6._metadata;
							bool flag33 = cloudServices6._metadata == null;
							message3 = null;
							num10 = (nint)encryptionToken;
							if (flag33)
							{
								goto IL_1c6b;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5750]");
							object format2 = 0;
							string text = string.Format((string)format2, metadata4.EncryptionToken__BackingField);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2352 @ X19_v17+10]");
							ex = (NullReferenceException)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2352 @ X19_v17+10]");
							bool flag34 = (nint)0 == 0;
							message3 = null;
							num10 = (nint)text;
							if (flag34)
							{
								goto IL_1cb8;
							}
							nint num11 = (nint)ex;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X8_v59 (Il2CppClass<System.NullReferenceException>)+1A0]");
							message = (IMessage)0;
							ex = (NullReferenceException)((Enum)(object)ex).GetTypeCode();
							num = (nint)text;
							obj37 = obj2;
						}
					}
					Fusion.Protocol.Join obj48 = obj37._003CjoinResponse_003E5__5;
					if (obj37._003CjoinResponse_003E5__5 == null)
					{
						goto IL_1433;
					}
					object obj49 = obj48.JoinRequests & (Fusion.Protocol.JoinRequests)2u;
					if (obj49 != null)
					{
						CloudServices cloudServices7 = obj2._003C_003E4__this;
						if ((object)obj2._003C_003E4__this == null)
						{
							goto IL_1ac5;
						}
						if (cloudServices7._metadata == null)
						{
							goto IL_1b02;
						}
						object obj50 = cloudServices7._metadata + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
						object obj51 = 0;
						object obj52 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2561 @ X0_v55+E4]");
						bool flag35 = (nint)0 == 0;
						object obj53 = !flag35;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						object obj54 = default;
						NetworkProjectConfig networkProjectConfig = NetworkRunner.SetupNetworkProjectConfig((NetworkRunnerInitializeArgs)(&obj54));
						obj2._003C_003E4__this.SendNetworkSyncMessage(networkProjectConfig);
						obj48 = obj2._003CjoinResponse_003E5__5;
						bool flag36 = obj2._003CjoinResponse_003E5__5 == null;
						message = (IMessage)400;
						num = (nint)networkProjectConfig;
						ex = (NullReferenceException)(object)obj2._003C_003E4__this;
						obj37 = obj2;
						message3 = (IMessage)400;
						num10 = (nint)networkProjectConfig;
						ex6 = (NullReferenceException)(object)obj2._003C_003E4__this;
						if (flag36)
						{
							goto IL_1bc9;
						}
					}
					object obj55 = obj48.JoinRequests & (Fusion.Protocol.JoinRequests)4u;
					if (obj55 != null)
					{
						CloudServices cloudServices8 = obj37._003C_003E4__this;
						if ((object)obj37._003C_003E4__this == null)
						{
							goto IL_1b3f;
						}
						CloudServicesMetadata metadata5 = cloudServices8._metadata;
						if (cloudServices8._metadata == null)
						{
							goto IL_1b7c;
						}
						ScheduledRequests scheduledRequests = metadata5.ScheduledRequests | (ScheduledRequests)2u;
						metadata5.ScheduledRequests = scheduledRequests;
					}
					CloudServices cloudServices9 = obj37._003C_003E4__this;
					if ((object)obj37._003C_003E4__this == null)
					{
						goto IL_1470;
					}
					Fusion.Protocol.Join obj56 = obj37._003CjoinResponse_003E5__5;
					if (obj37._003CjoinResponse_003E5__5 == null)
					{
						goto IL_14ad;
					}
					CloudServicesMetadata metadata6 = cloudServices9._metadata;
					if (cloudServices9._metadata == null)
					{
						goto IL_14ea;
					}
					metadata6.CurrentProtocolMessageVersion__BackingField = obj56.ProtocolVersion;
					num = (nint)obj56.UniqueId;
					metadata6.UniqueId__BackingField = obj56.UniqueId;
					object obj57 = cloudServices9._metadata + 440;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					CloudServices cloudServices10 = obj2._003C_003E4__this;
					bool flag37 = (object)obj2._003C_003E4__this == null;
					ex = (NullReferenceException)(object)obj2;
					if (flag37)
					{
						goto IL_1527;
					}
					Fusion.Protocol.Join obj58 = obj2._003CjoinResponse_003E5__5;
					bool flag38 = obj2._003CjoinResponse_003E5__5 == null;
					ex = (NullReferenceException)(object)obj2;
					if (flag38)
					{
						goto IL_1564;
					}
					CloudServicesMetadata metadata7 = cloudServices10._metadata;
					bool flag39 = cloudServices10._metadata == null;
					ex = (NullReferenceException)(object)obj2;
					if (!flag39)
					{
						metadata7.CurrentJoinStage__BackingField = (JoinProcessStage)2;
						metadata7.PlayerRef__BackingField = obj58.PlayerRef;
						object obj59 = obj2 + 96;
						obj59 = 0;
						_ = 4294967294L;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj60 = obj2 + 104;
						obj60 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj61 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2846 @ X0_v49+E4]");
						bool flag40 = (nint)0 == 0;
						object obj62 = !flag40;
						if (obj62 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj2 + 24);
						((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
						num = unchecked((nint)null);
						ex = (NullReferenceException)asyncTaskMethodBuilder2;
						goto IL_129d;
					}
					goto IL_15a1;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				bool flag41 = num12 != 0;
				ex = ex2;
				if (flag41)
				{
					goto IL_1f58;
				}
				OutOfMemoryException ex7 = new OutOfMemoryException();
				ex = (NullReferenceException)(object)ex7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num13 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_1358;
			}
			goto IL_1f58;
			IL_19c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag42 = num14 != 0;
			NullReferenceException ex8 = default;
			ex = ex8;
			if (!flag42)
			{
				ex3 = new NullReferenceException();
				goto IL_1a06;
			}
			goto IL_1f58;
			IL_1a4b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num15 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1a88;
			}
			goto IL_1f58;
			IL_1c6b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag43 = num16 != 0;
			message = message3;
			num = num10;
			if (!flag43)
			{
				ex = new NullReferenceException();
				goto IL_1cb8;
			}
			goto IL_1f58;
			IL_14ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num17 == 0)
			{
				ex = new NullReferenceException();
				goto IL_14ea;
			}
			goto IL_1f58;
			IL_1a06:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag44 = num18 != 0;
			ex = ex3;
			if (!flag44)
			{
				ex = new NullReferenceException();
				goto IL_1a4b;
			}
			goto IL_1f58;
			IL_1bc9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag45 = num19 != 0;
			message = message3;
			num = num10;
			ex = ex6;
			if (!flag45)
			{
				ex = new NullReferenceException();
				goto IL_1c1e;
			}
			goto IL_1f58;
			IL_15a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num20 == 0)
			{
				ex = new NullReferenceException();
				goto IL_15de;
			}
			goto IL_1f58;
			IL_1cb8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag46 = num21 != 0;
			message = message3;
			num = num10;
			if (!flag46)
			{
				ex = new NullReferenceException();
				message = message3;
				num = num10;
				goto IL_1d15;
			}
			goto IL_1f58;
			IL_14ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num22 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1527;
			}
			goto IL_1f58;
			IL_1d15:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num23 == 0)
			{
				ex = new NullReferenceException();
				bool flag47 = num != 1;
				NullReferenceException ex9 = ex;
				if (!flag47)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj64 = default;
					object obj63 = obj64;
					num = (nint)obj63;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj66 = default;
					object obj65 = obj66 & 1;
					if (obj65 != null)
					{
						object obj67 = 0;
						object obj69 = default;
						object obj68 = (object)(&obj69);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						object obj70 = obj2 + 96;
						obj70 = 0;
						_ = 4294967294L;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj71 = obj2 + 104;
						obj71 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2850 @ X0_v119+E4]");
						bool flag48 = (nint)0 == 0;
						object obj72 = !flag48;
						if (obj72 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)(obj2 + 24);
						((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetException((Exception)obj64);
						message = null;
						num = (nint)obj64;
						ex = (NullReferenceException)asyncTaskMethodBuilder3;
						goto IL_129d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					ex = (NullReferenceException)obj64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
					nint num24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
					if (num24 != 0)
					{
						goto IL_1f58;
					}
					num = 101790920;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					message = null;
					NullReferenceException ex10 = default;
					ex9 = ex10;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				if (num25 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
			}
			goto IL_1f58;
			IL_1658:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num26 == 0)
			{
				throw new NullReferenceException();
			}
			goto IL_1f58;
			IL_1358:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex11 = default;
			string message4 = default;
			ex11._002Ector(message4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag49 = num27 != 0;
			message = null;
			num = (nint)ex;
			if (!flag49)
			{
				ArgumentNullException ex12 = new ArgumentNullException();
				message = null;
				num = (nint)ex;
				ex = (NullReferenceException)(object)ex12;
				goto IL_13f6;
			}
			goto IL_1f58;
			IL_1a88:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num28 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1ac5;
			}
			goto IL_1f58;
			IL_15de:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num29 == 0)
			{
				ex = new NullReferenceException();
				goto IL_161b;
			}
			goto IL_1f58;
			IL_129d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num30 == 0)
			{
				return;
			}
			goto IL_1f58;
			IL_1b02:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num31 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1b3f;
			}
			goto IL_1f58;
			IL_1f58:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_1527:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num32 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1564;
			}
			goto IL_1f58;
			IL_13f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num33 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1433;
			}
			goto IL_1f58;
			IL_179c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num34 == 0)
			{
				ex = new NullReferenceException();
				goto IL_17d9;
			}
			goto IL_1f58;
			IL_1947:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num35 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1984;
			}
			goto IL_1f58;
			IL_1564:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num36 == 0)
			{
				ex = new NullReferenceException();
				goto IL_15a1;
			}
			goto IL_1f58;
			IL_17d9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num37 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1816;
			}
			goto IL_1f58;
			IL_1c1e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag50 = num38 != 0;
			message = message3;
			num = num10;
			if (!flag50)
			{
				ex = new NullReferenceException();
				goto IL_1c6b;
			}
			goto IL_1f58;
			IL_1853:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num39 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1890;
			}
			goto IL_1f58;
			IL_1816:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num40 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1853;
			}
			goto IL_1f58;
			IL_1984:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num41 == 0)
			{
				ex8 = new NullReferenceException();
				goto IL_19c1;
			}
			goto IL_1f58;
			IL_1b7c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num42 == 0)
			{
				ex6 = new NullReferenceException();
				message3 = message;
				num10 = num;
				goto IL_1bc9;
			}
			goto IL_1f58;
			IL_0858:
			obj15._003C_003Eu__1 = (TaskAwaiter<Fusion.Protocol.Join>)0;
			obj15._003C_003E1__state = -1;
			taskAwaiter = (TaskAwaiter<System.__Canon>)obj15._003C_003Eu__1;
			goto IL_20db;
			IL_161b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num43 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1658;
			}
			goto IL_1f58;
			IL_1890:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num44 == 0)
			{
				ex = new NullReferenceException();
				goto IL_18cd;
			}
			goto IL_1f58;
			IL_1b3f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num45 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1b7c;
			}
			goto IL_1f58;
			IL_1ac5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num46 == 0)
			{
				ex = new NullReferenceException();
				goto IL_1b02;
			}
			goto IL_1f58;
			IL_18cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num47 == 0)
			{
				ex = new NullReferenceException();
				goto IL_190a;
			}
			goto IL_1f58;
			IL_20db:
			System.__Canon result = taskAwaiter.GetResult();
			object obj73 = obj2 + 120;
			obj73 = result;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj74 = obj2 + 104;
			obj74 = obj2._003C_003Es__7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj75 = obj2 + 120;
			obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num = unchecked((nint)null);
			obj26 = 33;
			goto IL_2133;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003CService_HostMigrationSnapshot_003Ed__105 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CloudServices _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_05d9: Expected Obj, but got I
			//IL_02ab: Expected VT, but got I4
			//IL_02ba: Expected I4, but got I8
			//IL_0608: Expected Obj, but got I
			//IL_0610: Expected I, but got Obj
			//IL_063a: Expected I4, but got I8
			//IL_065c: Expected Obj, but got I4
			//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Expected VT, but got Unknown
			//IL_0311: Expected Ref, but got VT
			//IL_0076: Expected I, but got Obj
			//IL_00a4: Expected I, but got Obj
			//IL_00cb: Expected I, but got Obj
			//IL_03b3: Expected Obj, but got I
			//IL_03c3: Expected I, but got Obj
			//IL_03db: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Expected Obj, but got Unknown
			//IL_02dc: Expected I, but got Obj
			//IL_0494: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Expected Obj, but got Unknown
			//IL_0128: Expected I, but got Obj
			//IL_0593: Expected Obj, but got I4
			//IL_045b: Expected Obj, but got I4
			//IL_0406: Expected Obj, but got I4
			//IL_040e: Expected Obj, but got Ref
			//IL_04bf: Expected Obj, but got I4
			//IL_04c7: Expected Obj, but got Ref
			//IL_04e5: Expected I4, but got I8
			//IL_015c: Expected I, but got Obj
			//IL_0516: Expected Obj, but got I4
			//IL_0543: Unknown result type (might be due to invalid IL or missing references)
			//IL_0548: Expected VT, but got Unknown
			//IL_0555: Expected Ref, but got VT
			//IL_01b5: Expected I, but got Obj
			//IL_01fe: Expected Obj, but got I4
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected Obj, but got Unknown
			//IL_0227: Expected Obj, but got VT
			//IL_0261: Expected Obj, but got I4
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected VT, but got Unknown
			//IL_029b: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5318]");
			object obj = 0;
			TaskAwaiter<bool> taskAwaiter;
			bool result;
			nint num;
			nint num2 = default;
			if (_003C_003E1__state != 0)
			{
				CloudServices cloudServices = _003C_003E4__this;
				if ((object)_003C_003E4__this != null)
				{
					if ((object)cloudServices._runner != null)
					{
						bool isRunning = cloudServices._runner.IsRunning;
						bool flag = !isRunning;
						num = unchecked((nint)null);
						if (flag)
						{
							goto IL_02c9;
						}
						CloudServices cloudServices2 = _003C_003E4__this;
						bool flag2 = (object)_003C_003E4__this == null;
						num2 = unchecked((nint)null);
						if (flag2)
						{
							goto IL_0333;
						}
						bool flag3 = (object)cloudServices2._runner == null;
						num2 = unchecked((nint)null);
						if (flag3)
						{
							goto IL_0341;
						}
						if (cloudServices2._runner.IsServer)
						{
							CloudServices cloudServices3 = _003C_003E4__this;
							bool flag4 = (object)_003C_003E4__this == null;
							num2 = unchecked((nint)null);
							if (flag4)
							{
								goto IL_034f;
							}
							NetworkRunner runner = cloudServices3._runner;
							bool flag5 = (object)cloudServices3._runner == null;
							num2 = unchecked((nint)null);
							if (flag5)
							{
								goto IL_035d;
							}
							if (runner.GameMode__BackingField == (GameMode)4)
							{
								Task<bool> task = cloudServices3._runner.SendHostMigrationSnapshot();
								bool flag6 = task == null;
								num2 = unchecked((nint)null);
								if (flag6)
								{
									goto IL_036b;
								}
								TaskAwaiter<bool> awaiter = task.GetAwaiter();
								TaskAwaiter<bool> awaiter2 = default;
								bool isCompleted = awaiter2.IsCompleted;
								bool flag7 = !isCompleted;
								object obj2 = !flag7;
								taskAwaiter = awaiter2;
								if (obj2 == null)
								{
									object obj3 = this + 56;
									obj3 = awaiter2;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj4 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v71+E4]");
									bool flag8 = (nint)0 == 0;
									object obj5 = !flag8;
									if (obj5 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<bool>)(this + 24);
									System.__Canon stateMachine = default;
									((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<bool>, System.__Canon>(ref awaiter2, ref stateMachine);
									return;
								}
								goto IL_05f8;
							}
						}
						num = unchecked((nint)null);
						result = false;
						goto IL_0622;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0333;
			}
			_003C_003Eu__1 = (TaskAwaiter<bool>)0;
			_003C_003E1__state = -1;
			taskAwaiter = _003C_003Eu__1;
			goto IL_05f8;
			IL_0622:
			object obj6 = obj;
			_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v3+E4]");
			bool flag9 = (nint)0 == 0;
			object obj7 = !flag9;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<bool>)(this + 24);
			((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder2)->SetResult(result);
			return;
			IL_0341:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_034f;
			IL_02c9:
			result = true;
			goto IL_0622;
			IL_034f:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_035d;
			IL_05f8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4500]");
			object obj8 = 0;
			num = (nint)obj8;
			bool result2 = taskAwaiter.GetResult();
			goto IL_02c9;
			IL_035d:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_036b;
			IL_05af:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0333:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0341;
			IL_036b:
			NullReferenceException ex7 = new NullReferenceException();
			object obj16 = default;
			NullReferenceException ex8;
			if (num2 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj9 = 0;
				object obj11 = default;
				object obj10 = obj11;
				num = (nint)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj13 = default;
				object obj12 = obj13 & 1;
				if (obj12 != null)
				{
					object obj14 = 0;
					object obj15 = (object)(&obj16);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					goto IL_02c9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj17 = obj11;
				num2 = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				object obj18 = 0;
			}
			else
			{
				bool flag10 = num2 != 1;
				ex8 = ex7;
				if (flag10)
				{
					goto IL_05af;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj20 = default;
				object obj19 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj22 = default;
				object obj21 = obj22 & 1;
				if (obj21 != null)
				{
					object obj23 = 0;
					object obj24 = (object)(&obj16);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v26+E4]");
					bool flag11 = (nint)0 == 0;
					object obj25 = !flag11;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<bool>)(this + 24);
					((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder3)->SetException((Exception)obj20);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj26 = obj20;
				num2 = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				object obj18 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex9 = default;
			ex8 = ex9;
			goto IL_05af;
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private bool IsNATPunchthroughEnabled__BackingField;

	private string CustomSTUNServer__BackingField;

	private readonly CloudServicesMetadata _metadata;

	private readonly NetworkRunner _runner;

	private CloudCommunicator _communicator;

	private readonly Dictionary<string, SessionInfo> _cachedSessionList;

	private Fusion.Async.AsyncOperationHandler<Fusion.Protocol.Join> _joinAsyncHandler;

	private byte[] _dummyData;

	private CancellationTokenSource _dummyTrafficCts;

	private CancellationTokenSource _dummyTrafficLinkCts;

	public bool IsCloudReady
	{
		get
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null && communicator.Client__BackingField != null)
			{
				return communicator.Client__BackingField.IsConnectedAndReady;
			}
			return false;
		}
	}

	public string UserId
	{
		get
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null && communicator.Client__BackingField != null && communicator.Client__BackingField.IsConnectedAndReady)
			{
				CloudCommunicator communicator2 = _communicator;
				if ((object)_communicator != null && communicator2.Client__BackingField != null)
				{
					return communicator2.Client__BackingField.UserId;
				}
				return (string)(object)new NullReferenceException();
			}
			return null;
		}
	}

	public bool IsInRoom
	{
		get
		{
			//IL_00f0: Expected I4, but got Obj
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null && communicator.Client__BackingField != null && communicator.Client__BackingField.IsConnectedAndReady)
			{
				CloudCommunicator communicator2 = _communicator;
				if ((object)_communicator != null && communicator2.Client__BackingField != null)
				{
					return communicator2.Client__BackingField.InRoom;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public bool IsInLobby
	{
		get
		{
			//IL_00f0: Expected I4, but got Obj
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null && communicator.Client__BackingField != null && communicator.Client__BackingField.IsConnectedAndReady)
			{
				CloudCommunicator communicator2 = _communicator;
				if ((object)_communicator != null && communicator2.Client__BackingField != null)
				{
					return communicator2.Client__BackingField.InLobby;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public JoinProcessStage CurrentJoinStage
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			CloudServicesMetadata metadata = _metadata;
			if (_metadata != null)
			{
				return metadata.CurrentJoinStage__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (JoinProcessStage)ex;
		}
	}

	public Fusion.Protocol.ProtocolMessageVersion CurrentProtocolMessageVersion
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			CloudServicesMetadata metadata = _metadata;
			if (_metadata != null)
			{
				return metadata.CurrentProtocolMessageVersion__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Fusion.Protocol.ProtocolMessageVersion)(int)ex;
		}
	}

	public int SessionSlots
	{
		get
		{
			//IL_00cd: Expected I4, but got I8
			//IL_00e0: Expected I4, but got Obj
			if (IsInRoom)
			{
				CloudCommunicator communicator = _communicator;
				if ((object)_communicator != null)
				{
					RealtimeClient realtimeClient = communicator.Client__BackingField;
					if (communicator.Client__BackingField != null)
					{
						Room room = realtimeClient.CurrentRoom__BackingField;
						if (realtimeClient.CurrentRoom__BackingField != null)
						{
							return ((RoomInfo)room).maxPlayers;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return -1;
		}
	}

	public bool IsMasterClient
	{
		get
		{
			//IL_00cc: Expected I4, but got Obj
			if (IsInRoom)
			{
				CloudCommunicator communicator = _communicator;
				if ((object)_communicator != null)
				{
					RealtimeClient realtimeClient = communicator.Client__BackingField;
					if (communicator.Client__BackingField != null && realtimeClient.LocalPlayer != null)
					{
						return realtimeClient.LocalPlayer.IsMasterClient;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public int MasterClientActorId
	{
		get
		{
			//IL_00dc: Expected I4, but got Obj
			if (IsInRoom)
			{
				CloudCommunicator communicator = _communicator;
				if ((object)_communicator != null)
				{
					RealtimeClient realtimeClient = communicator.Client__BackingField;
					if (communicator.Client__BackingField != null)
					{
						Room room = realtimeClient.CurrentRoom__BackingField;
						if (realtimeClient.CurrentRoom__BackingField != null)
						{
							return ((RoomInfo)room).masterClientId;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return 0;
		}
	}

	public unsafe (double, double) RoundTripTime
	{
		get
		{
			//IL_01ad: Expected F4, but got I4
			//IL_01b6: Expected F4, but got I4
			//IL_0214: Expected F8, but got VT
			//IL_0219: Expected VT, but got Ref
			//IL_01c9: Expected VT, but got Obj
			//IL_00c2: Expected Obj, but got I
			float item;
			float item2;
			if (IsInRoom)
			{
				CloudCommunicator communicator = _communicator;
				if ((object)_communicator != null)
				{
					RealtimeClient realtimeClient = communicator.Client__BackingField;
					if (communicator.Client__BackingField != null)
					{
						PhotonPeer realtimePeer = realtimeClient.RealtimePeer;
						if (realtimeClient.RealtimePeer != null && realtimePeer.Stats__BackingField != null)
						{
							int index = default;
							((Fusion.Sockets.Stun.StunClient.List*)realtimePeer.Stats__BackingField)->Fusion_002EIIntrusiveLinkedList_002ECopyTo((Array)0, index);
							CloudCommunicator communicator2 = _communicator;
							if ((object)_communicator != null)
							{
								RealtimeClient realtimeClient2 = communicator2.Client__BackingField;
								if (communicator2.Client__BackingField != null)
								{
									PhotonPeer realtimePeer2 = realtimeClient2.RealtimePeer;
									if (realtimeClient2.RealtimePeer != null && realtimePeer2.Stats__BackingField != null)
									{
										string text = ((object)realtimePeer2.Stats__BackingField).ToString();
										object obj = default;
										item = (float)obj / 1.1488461E+09f;
										item2 = (float)text / 1.1488461E+09f;
										goto IL_01f1;
									}
								}
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return ((double, double))ex;
			}
			item = 0f;
			item2 = 0f;
			goto IL_01f1;
			IL_01f1:
			(float, float) tuple = (item, item2);
			double item3 = default;
			(double, double) tuple2 = ((double)tuple, item3);
			return ((double, double))(&tuple2);
		}
	}

	public AuthenticationValues AuthenticationValues
	{
		get
		{
			CloudCommunicator communicator = _communicator;
			AuthenticationValues result;
			if ((object)_communicator != null)
			{
				bool flag = communicator.Client__BackingField == null;
				result = (AuthenticationValues)(object)communicator.Client__BackingField;
				if (!flag)
				{
					bool isConnectedAndReady = communicator.Client__BackingField.IsConnectedAndReady;
					bool flag2 = !isConnectedAndReady;
					result = null;
					if (!flag2)
					{
						CloudCommunicator communicator2 = _communicator;
						if ((object)_communicator != null)
						{
							RealtimeClient realtimeClient = communicator2.Client__BackingField;
							if (communicator2.Client__BackingField != null)
							{
								result = realtimeClient.AuthValues__BackingField;
								goto IL_010e;
							}
						}
						return (AuthenticationValues)(object)new NullReferenceException();
					}
				}
			}
			else
			{
				result = null;
			}
			goto IL_010e;
			IL_010e:
			return result;
		}
	}

	public ICommunicator Communicator => (ICommunicator)_communicator;

	public string CachedRegionSummary
	{
		get
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null && communicator.Client__BackingField != null)
			{
				return communicator.Client__BackingField.SummaryToCache;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public bool IsNATPunchthroughEnabled
	{
		get
		{
			return IsNATPunchthroughEnabled__BackingField;
		}
		internal set
		{
			IsNATPunchthroughEnabled__BackingField = value;
		}
	}

	public bool IsEncryptionEnabled
	{
		get
		{
			//IL_0101: Expected I4, but got Obj
			//IL_008f: Expected Obj, but got I
			//IL_00b9: Expected Obj, but got I4
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null && communicator.Client__BackingField != null && communicator.Client__BackingField.IsConnectedAndReady)
			{
				CloudCommunicator communicator2 = _communicator;
				if ((object)_communicator != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return RealtimeClientExtensions.IsEncryptionEnabled(communicator2.Client__BackingField);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public string CustomSTUNServer
	{
		get
		{
			return CustomSTUNServer__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public NATType NATType
	{
		get
		{
			//IL_001b: Expected I4, but got Obj
			//IL_004f: Expected I4, but got Obj
			//IL_00c8: Expected I4, but got Obj
			bool flag = _metadata == null;
			NATType result = (NATType)(int)_metadata;
			if (!flag)
			{
				Fusion.Sockets.Stun.StunResult localReflexiveInfo = _metadata.LocalReflexiveInfo;
				bool flag2 = localReflexiveInfo == null;
				result = (NATType)(int)localReflexiveInfo;
				if (!flag2)
				{
					if (_metadata != null)
					{
						Fusion.Sockets.Stun.StunResult localReflexiveInfo2 = _metadata.LocalReflexiveInfo;
						if (localReflexiveInfo2 != null)
						{
							result = localReflexiveInfo2.NatType;
							goto IL_00c8;
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (NATType)(int)ex;
				}
			}
			goto IL_00c8;
			IL_00c8:
			return result;
		}
	}

	public PlayerRef LocalPlayerRef
	{
		get
		{
			//IL_007d: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			CloudServicesMetadata metadata = _metadata;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			int index;
			if (_metadata != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
				object obj2 = 0;
				int? num = metadata.PlayerRef__BackingField;
				int num2 = default;
				index = num2;
			}
			else
			{
				index = 0;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return PlayerRef.FromIndex(index);
		}
	}

	private bool IsServerOrMasterClient
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0123: Expected Obj, but got I4
			//IL_00f9: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)_runner != (UnityEngine.Object)null)
			{
				if ((object)_runner != null)
				{
					if (_runner.IsServer)
					{
						return true;
					}
					if ((object)_runner != null)
					{
						return _runner.IsSharedModeMasterClient;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public IEnumerable<PlayerRef> CommittedPlayerInternal
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected I4, but got I8
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53E8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NetworkBehaviourUtils.ChangeDetector._003Cget_CommittedPlayerInternal_003Ed__120 obj2 = default;
			obj2._002Ector(-2);
			if ((object)obj2 != null)
			{
				object obj3 = obj2 + 32;
				obj3 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return (IEnumerable<PlayerRef>)(object)obj2;
			}
			return (IEnumerable<PlayerRef>)new NullReferenceException();
		}
	}

	public void OnConnected()
	{
	}

	public void OnConnectedToMaster()
	{
	}

	public void OnCustomAuthenticationFailed(string debugMessage)
	{
		OperationFailHandler(32755, debugMessage);
	}

	public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
	{
		if ((object)_runner != null)
		{
			_runner.InvokeCustomAuthenticationResponse(data);
		}
	}

	public void OnDisconnected(DisconnectCause cause)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I
		//IL_0209: Expected I, but got Obj
		//IL_0213: Expected I4, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I
		//IL_036c: Expected I, but got Obj
		//IL_0376: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		ShutdownReason shutdownReason = DisconnectCauseExt.ConvertToShutdownReason(cause);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v7+8]");
		bool flag3 = (nint)0 == 0;
		ShutdownReason shutdownReason2 = (ShutdownReason)0;
		if (!flag3)
		{
			bool flag4 = HandlePhotonCloudDisconnect(shutdownReason);
			bool flag5 = !flag4;
			shutdownReason2 = shutdownReason;
			if (!flag5)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v38+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v39+E0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v39+E0]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v40+10]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F90]");
				object obj12 = 0;
				object obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v16+198]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v16+1A0]");
				object obj15 = 0;
				object obj16 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v254 @ X3_v11 (should have been resolved before IL gen)");
			}
		}
		object obj17 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v11+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v12+E0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v12+E0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3050]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F98]");
			object format = 0;
			object arg = default;
			object arg2 = default;
			string text = string.Format((string)format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X24_v4+10]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v15+190]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ X9_v15+188] (should have been resolved before IL gen)");
			nint num = (nint)text;
			shutdownReason2 = (ShutdownReason)_runner;
		}
		CloudServicesMetadata metadata = _metadata;
		Fusion.Protocol.Disconnect lastDisconnectMsg = metadata.LastDisconnectMsg;
		string customMsg;
		ShutdownReason shutdownReason4;
		if (metadata.LastDisconnectMsg != null)
		{
			ShutdownReason shutdownReason3 = DisconnectReasonExt.ConvertToShutdownReason(lastDisconnectMsg.DisconnectReason);
			CloudServicesMetadata metadata2 = _metadata;
			Fusion.Protocol.Disconnect lastDisconnectMsg2 = metadata2.LastDisconnectMsg;
			object obj25 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X9_v8+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v9+10]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v9+10]");
			bool flag6 = (nint)0 == 0;
			shutdownReason2 = (ShutdownReason)0;
			customMsg = ((Fusion.Protocol.Message)lastDisconnectMsg2)._customData;
			shutdownReason4 = shutdownReason3;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F78]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F80]");
				object format2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F88]");
				object arg3 = 0;
				object arg4 = default;
				string text2 = string.Format((string)format2, arg3, arg4, ((Fusion.Protocol.Message)lastDisconnectMsg2)._customData);
				object obj29 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v29+190]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X8_v29+188] (should have been resolved before IL gen)");
				nint num = (nint)text2;
				shutdownReason2 = (ShutdownReason)_runner;
				customMsg = ((Fusion.Protocol.Message)lastDisconnectMsg2)._customData;
				shutdownReason4 = shutdownReason3;
			}
		}
		else
		{
			customMsg = null;
			shutdownReason4 = shutdownReason;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F58]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StartGameException ex = default;
		ex._002Ector(shutdownReason4, customMsg);
		if (_joinAsyncHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F70]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3D59484");
		}
		NetworkRunner runner = _runner;
		if (runner.StartGameOperation != null)
		{
			((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner.StartGameOperation).SetException((Exception)ex);
		}
		else
		{
			Task task = runner.Shutdown(destroyGameObject: true, shutdownReason4, forceShutdownProcedure: true);
		}
	}

	public void OnRegionListReceived(RegionHandler regionHandler)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_025e: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FB0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FD0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
		object separator = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35B5DE8");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X9_v6+8]");
		Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X9_v6+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v20+A0]");
				obj5 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FC0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FC8]");
			object obj11 = 0;
			Func<System.__Canon, System.__Canon> func = default;
			func._002Ector(obj5, (IntPtr)obj11);
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v19+A0]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			selector = func;
		}
		IEnumerable<System.__Canon> source = default;
		IEnumerable<System.__Canon> values = Enumerable.Select(source, selector);
		string text = string.Join((string)separator, (IEnumerable<string>)values);
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v9+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+E0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+E0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FD8]");
			object obj17 = 0;
			string text2 = (string)obj17 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X19_v4+10]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X9_v5+198]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X9_v5+1A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v131 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	public void OnCreatedRoom()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		if ((nint)0 != 0)
		{
			CloudCommunicator communicator = _communicator;
			RealtimeClient realtimeClient = communicator.Client__BackingField;
			Room room = realtimeClient.CurrentRoom__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FE0]");
			object obj5 = 0;
			NetworkRunner runner = _runner;
			string text = (string)obj5 + ((RoomInfo)room).name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X20_v2+10]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X9_v4+188]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X9_v4+190]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v76 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	public unsafe void OnJoinedRoom()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00b3: Expected Ref, but got VT
		//IL_0058: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		if ((nint)0 != 0)
		{
			CloudCommunicator communicator = _communicator;
			RealtimeClient realtimeClient = communicator.Client__BackingField;
			Room room = realtimeClient.CurrentRoom__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FE8]");
			object obj5 = 0;
			string text = (string)obj5 + ((RoomInfo)room).name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X21_v3+10]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ X9_v5+188] (should have been resolved before IL gen)");
		}
		RejoinMetadata rejoinMetadata = (RejoinMetadata)(_metadata + 488);
		((RejoinMetadata*)rejoinMetadata)->Reset();
		NetworkRunner runner = _runner;
		runner.LobbyInfo__BackingField.Reset();
	}

	public void OnLeftRoom()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FF0]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ X9_v3+188] (should have been resolved before IL gen)");
		}
		NetworkRunner runner = _runner;
		runner.LobbyInfo__BackingField.Reset();
	}

	public void OnFriendListUpdate(List<global::Photon.Realtime.FriendInfo> friendList)
	{
	}

	public void OnCreateRoomFailed(short returnCode, string message)
	{
		OperationFailHandler(returnCode, message);
	}

	public void OnJoinRandomFailed(short returnCode, string message)
	{
		OperationFailHandler(returnCode, message);
	}

	public void OnJoinRoomFailed(short returnCode, string message)
	{
		OperationFailHandler(returnCode, message);
	}

	public void OnJoinedLobby()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		NetworkRunner runner = _runner;
		LobbyInfo lobbyInfo = runner.LobbyInfo__BackingField;
		CloudCommunicator communicator = _communicator;
		lobbyInfo.IsValid__BackingField = true;
		RealtimeClient realtimeClient = communicator.Client__BackingField;
		TypedLobby typedLobby = realtimeClient.CurrentLobby__BackingField;
		object obj = lobbyInfo + 24;
		obj = typedLobby.Name__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		NetworkRunner runner2 = _runner;
		CloudCommunicator communicator2 = _communicator;
		RealtimeClient realtimeClient2 = communicator2.Client__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5000]");
		object oldValue = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object newValue = 0;
		string text = realtimeClient2.CurrentRegion__BackingField.Replace((string)oldValue, (string)newValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj2 = 0;
		object obj3 = runner2.LobbyInfo__BackingField + 32;
		obj3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v9+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v10+E0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v10+E0]");
		if ((nint)0 != 0)
		{
			NetworkRunner runner3 = _runner;
			LobbyInfo lobbyInfo2 = runner3.LobbyInfo__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FF8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5008]");
			object obj8 = 0;
			string text2 = (string)obj7 + lobbyInfo2.Name__BackingField + (string)obj8 + lobbyInfo2.Region__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v5+10]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v9+188]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v9+190]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v112 @ X4_v3 (should have been resolved before IL gen)");
		}
	}

	public void OnLeftLobby()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		NetworkRunner runner = _runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		runner.LobbyInfo__BackingField.Reset();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+E0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v7+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5010]");
			object obj6 = 0;
			object obj7 = obj5;
			NetworkRunner runner2 = _runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v1+188]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v1+190]");
			object obj9 = 0;
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	public void OnRoomListUpdate(List<RoomInfo> roomList)
	{
		OnRoomListChanged(roomList);
	}

	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
	{
	}

	private void OperationFailHandler(short returnCode, string message)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+10]");
		bool flag = (nint)0 == 0;
		string text = message;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F68]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			string text2 = string.Format((string)format, arg, message);
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ X8_v28+188] (should have been resolved before IL gen)");
			text = text2;
		}
		ShutdownReason shutdownReason = ErrorCodeExt.ConvertToShutdownReason(returnCode);
		NetworkRunner runner = _runner;
		if (runner.StartGameOperation != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F58]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			StartGameException ex = default;
			ex._002Ector(shutdownReason, message);
			((Fusion.Async.AsyncOperationHandler<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)runner.StartGameOperation).SetException((Exception)ex);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v12+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v13+8]");
		if ((nint)0 != 0 && HandlePhotonCloudDisconnect(shutdownReason))
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16+E0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16+E0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v17+10]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F60]");
				object obj18 = 0;
				object obj19 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X9_v3+198] (should have been resolved before IL gen)");
			}
		}
		else
		{
			Task task = _runner.Shutdown(destroyGameObject: true, shutdownReason, forceShutdownProcedure: true);
		}
	}

	public void OnPlayerPropertiesUpdate(Player targetPlayer, PhotonHashtable changedProps)
	{
	}

	public void OnMasterClientSwitched(Player newMasterClient)
	{
		OnRoomChanged();
	}

	public void OnPlayerEnteredRoom(Player newPlayer)
	{
		OnRoomChanged();
	}

	public void OnPlayerLeftRoom(Player otherPlayer)
	{
		OnRoomChanged();
	}

	public void OnRoomPropertiesUpdate(PhotonHashtable propertiesThatChanged)
	{
		OnRoomChanged();
	}

	public CloudServices(NetworkRunner runner, CloudCommunicator communicator = null, RealtimeClient client = null, FusionAppSettings appSettings = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0550: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_0243: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_029f: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_02fb: Expected I, but got Obj
		//IL_0310: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_0357: Expected I, but got Obj
		//IL_036c: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_03b3: Expected I, but got Obj
		//IL_03c8: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_040f: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I
		//IL_0444: Expected Obj, but got I
		//IL_046b: Expected I, but got Obj
		//IL_0480: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I
		//IL_04c7: Expected I, but got Obj
		//IL_04dc: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5088]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
		object obj2 = 0;
		IsNATPunchthroughEnabled__BackingField = true;
		object obj3 = this + 24;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj4 = this + 56;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		object obj5 = this + 40;
		obj5 = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v14+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TaskManager.Setup();
		object obj7 = (object)communicator != null;
		FusionAppSettings fusionAppSettings = (FusionAppSettings)(object)communicator;
		CloudCommunicator cloudCommunicator = communicator;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50E0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			CloudCommunicator cloudCommunicator2 = default;
			cloudCommunicator2._002Ector(client, appSettings);
			fusionAppSettings = appSettings;
			cloudCommunicator = cloudCommunicator2;
		}
		object obj9 = this + 48;
		obj9 = cloudCommunicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v6+38]");
		((RealtimeClient)0).AddCallbackTarget(this);
		object obj11 = _communicator.Client__BackingField + 112;
		obj11 = runner.CloudAddressRewriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50D0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5108]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5150]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50D8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5130]");
		object obj16 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action2 = default;
		action2._002Ector((object)this, (IntPtr)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5178]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50F0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action3 = default;
		action3._002Ector((object)this, (IntPtr)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5138]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5120]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action4 = default;
		action4._002Ector((object)this, (IntPtr)obj22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5168]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50A8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5110]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action5 = default;
		action5._002Ector((object)this, (IntPtr)obj25);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5158]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50C0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5100]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action6 = default;
		action6._002Ector((object)this, (IntPtr)obj28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5148]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5128]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action7 = default;
		action7._002Ector((object)this, (IntPtr)obj31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5170]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50C8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5118]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action8 = default;
		action8._002Ector((object)this, (IntPtr)obj34);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5160]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5098]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50F8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, System.__Canon> action9 = default;
		action9._002Ector((object)this, (IntPtr)obj37);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5140]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50E8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EC0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		CloudServicesMetadata cloudServicesMetadata = default;
		cloudServicesMetadata._002Ector();
		object obj40 = this + 32;
		obj40 = cloudServicesMetadata;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public CloudCommunicator ExtractCommunicator()
	{
		CloudCommunicator communicator = _communicator;
		if ((object)_communicator != null && communicator.Client__BackingField != null)
		{
			communicator.Client__BackingField.RemoveCallbackTarget(this);
			if ((object)_communicator != null)
			{
				_communicator.Reset();
				CloudCommunicator communicator2 = _communicator;
				if ((object)_communicator != null)
				{
					communicator2.WasExtracted__BackingField = true;
					return _communicator;
				}
			}
		}
		return (CloudCommunicator)(object)new NullReferenceException();
	}

	public void Update()
	{
		//IL_004e: Expected I, but got Obj
		CloudCommunicator communicator = _communicator;
		if ((object)_communicator == null || ~(communicator.WasExtracted__BackingField ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)communicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v8 @ X8_v3 (Il2CppClass<Fusion.CloudCommunicator>)+208] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public unsafe Task ConnectToCloud(AppSettings appSettings, AuthenticationValues authentication = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0109: Expected Obj, but got VT
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected VT, but got Unknown
		//IL_016e: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5180]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5188]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 72;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 48;
			obj9 = appSettings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj3 + 56;
			obj10 = authentication;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj11 = obj3 + 64;
			obj11 = cancellationToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj12 = obj3 + 24;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35014A8");
			object obj13 = default;
			if (obj13 != null)
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj13 + 24);
				return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Task;
			}
		}
		return (Task)(object)new NullReferenceException();
	}

	public Task<short> JoinSessionLobby(SessionLobby sessionLobby, string lobbyID = null, LobbyType lobbyType = default(LobbyType), CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0373: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_03f2: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
		object obj2 = 0;
		CloudCommunicator communicator = _communicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5190]");
		object obj3 = 0;
		bool flag = (object)_communicator == null;
		SessionLobby sessionLobby2 = sessionLobby;
		object obj4;
		CloudServices cloudServices;
		TypedLobby lobby;
		if (!flag)
		{
			bool flag2 = communicator.Client__BackingField == null;
			sessionLobby2 = sessionLobby;
			if (!flag2)
			{
				bool isConnectedAndReady = communicator.Client__BackingField.IsConnectedAndReady;
				bool flag3 = !isConnectedAndReady;
				sessionLobby2 = (SessionLobby)0;
				if (!flag3)
				{
					if (sessionLobby != (SessionLobby)3)
					{
						if (sessionLobby != (SessionLobby)2)
						{
							if (sessionLobby != (SessionLobby)1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51A8]");
								obj4 = 0;
								goto IL_0408;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50E8]");
							object obj5 = 0;
							cloudServices = (CloudServices)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (Fusion.CloudServices)+E4]");
							bool flag4 = (nint)0 == 0;
							object obj6 = !flag4;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								cloudServices = (CloudServices)obj5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (Fusion.CloudServices)+A0]");
							object obj7 = 0;
							lobby = (TypedLobby)obj7;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50E8]");
							object obj8 = 0;
							cloudServices = (CloudServices)obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (Fusion.CloudServices)+E4]");
							bool flag5 = (nint)0 == 0;
							object obj9 = !flag5;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								cloudServices = (CloudServices)obj8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (Fusion.CloudServices)+A0]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v16+8]");
							lobby = (TypedLobby)0;
						}
						goto IL_0284;
					}
					if (lobbyID != null)
					{
						string value = lobbyID.Trim();
						bool flag6 = string.IsNullOrEmpty(value);
						bool flag7 = !flag6;
						object obj11 = !flag7;
						object obj12 = 0;
						if (obj11 == null)
						{
							string name = lobbyID.Trim();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5198]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							TypedLobby typedLobby = default;
							typedLobby._002Ector(name, lobbyType);
							cloudServices = (CloudServices)(object)typedLobby;
							lobby = typedLobby;
							goto IL_0284;
						}
					}
					else
					{
						bool flag8 = string.IsNullOrEmpty(null);
						bool flag9 = !flag8;
						object obj12 = 0;
						if (flag9)
						{
							goto IL_0355;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51B0]");
					obj4 = 0;
					goto IL_0408;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		string message = (string)obj14;
		goto IL_0415;
		IL_0408:
		message = (string)obj4;
		goto IL_0415;
		IL_0415:
		InvalidOperationException ex = default;
		ex._002Ector(message);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v3+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @378A584");
		Task<short> result = default;
		return result;
		IL_0284:
		CloudCommunicator communicator2 = _communicator;
		if ((object)_communicator != null)
		{
			AsyncConfig config = cloudServices.BuildAsyncConfig(cancellationToken);
			return AsyncExtensions.JoinLobbyAsync(communicator2.Client__BackingField, lobby, throwOnError: true, config);
		}
		goto IL_0355;
		IL_0355:
		return (Task<short>)(object)new NullReferenceException();
	}

	public unsafe Task<short> EnterRoom(StartGameArgs args)
	{
		//IL_12f0: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0059: Expected VT, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I4
		//IL_0378: Expected Obj, but got I4
		//IL_0386: Invalid comparison between VT and I4
		//IL_03b6: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I
		//IL_03ee: Expected I4, but got Obj
		//IL_0417: Expected VT, but got I4
		//IL_0412: Expected native int or pointer, but got VT
		//IL_0420: Expected VT, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_1331: Expected Obj, but got I4
		//IL_133f: Expected Obj, but got I4
		//IL_1359: Expected Obj, but got I4
		//IL_137f: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I
		//IL_0454: Expected I4, but got Obj
		//IL_047d: Expected VT, but got I4
		//IL_0478: Expected native int or pointer, but got VT
		//IL_0486: Expected VT, but got I4
		//IL_048f: Expected Obj, but got I4
		//IL_04a2: Expected Obj, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04d8: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected VT, but got Unknown
		//IL_052b: Expected Ref, but got VT
		//IL_0554: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_069d: Expected Obj, but got I
		//IL_0755: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I4
		//IL_1423: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got I4
		//IL_140e: Expected Obj, but got I
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_1465: Expected Obj, but got Unknown
		//IL_08b1: Expected I4, but got VT
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected VT, but got Unknown
		//IL_09df: Expected Obj, but got I
		//IL_09ed: Expected Ref, but got VT
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Expected VT, but got Unknown
		//IL_0a0d: Expected Ref, but got VT
		//IL_0a26: Expected Obj, but got I
		//IL_0a50: Expected Obj, but got I4
		//IL_0a87: Expected Obj, but got I4
		//IL_0a90: Expected I4, but got Obj
		//IL_0ae4: Expected Obj, but got I
		//IL_0afc: Expected Obj, but got I
		//IL_0b0c: Expected Obj, but got I
		//IL_0cb4: Expected Obj, but got VT
		//IL_151e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1523: Expected Obj, but got Unknown
		//IL_0b49: Expected Obj, but got VT
		//IL_0cd2: Expected Obj, but got I
		//IL_0b60: Invalid comparison between VT and I4
		//IL_11c6: Expected Obj, but got VT
		//IL_0b84: Expected Obj, but got I
		//IL_0d32: Expected Obj, but got I
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Expected Obj, but got Unknown
		//IL_0d5b: Invalid comparison between VT and I4
		//IL_12ac: Expected Obj, but got VT
		//IL_1226: Expected Obj, but got VT
		//IL_0d83: Expected Obj, but got I8
		//IL_1183: Expected Obj, but got VT
		//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Expected Obj, but got Unknown
		//IL_0de7: Expected Obj, but got I4
		//IL_0dfd: Expected Obj, but got I
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected Obj, but got Unknown
		//IL_0c11: Expected Obj, but got I
		//IL_0c21: Expected Obj, but got I
		//IL_0e40: Expected Obj, but got I
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected Obj, but got Unknown
		//IL_0e70: Expected Obj, but got I
		//IL_155d: Expected Obj, but got I
		//IL_0c5d: Expected Obj, but got I
		//IL_0c6d: Expected Obj, but got I
		//IL_0ea9: Expected Obj, but got I8
		//IL_10ce: Expected Obj, but got I
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Expected Obj, but got Unknown
		//IL_0ee4: Expected Obj, but got I
		//IL_0f10: Expected Obj, but got I4
		//IL_0f26: Expected Obj, but got I
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected Obj, but got Unknown
		//IL_0f69: Expected Obj, but got I
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f77: Expected Obj, but got Unknown
		//IL_1587: Expected Obj, but got I4
		//IL_1597: Expected Obj, but got I4
		//IL_15b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bc: Expected Obj, but got Unknown
		//IL_1013: Expected Obj, but got I
		//IL_1023: Expected Obj, but got I
		//IL_1088: Unknown result type (might be due to invalid IL or missing references)
		//IL_108d: Expected Obj, but got Unknown
		CloudCommunicator communicator = _communicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
		object obj = 0;
		bool flag = (object)_communicator == null;
		StartGameArgs startGameArgs = args;
		GameMode gameMode;
		object obj6;
		object obj11;
		bool? flag8 = default;
		int? num;
		if (!flag)
		{
			bool flag2 = communicator.Client__BackingField == null;
			startGameArgs = args;
			if (!flag2)
			{
				bool isConnectedAndReady = communicator.Client__BackingField.IsConnectedAndReady;
				bool flag3 = !isConnectedAndReady;
				startGameArgs = (StartGameArgs)0;
				if (!flag3)
				{
					if (IsInRoom)
					{
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v126+E4]");
						bool flag4 = (nint)0 == 0;
						object obj3 = !flag4;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						return Task.FromResult((short)0);
					}
					if (_metadata != null)
					{
						object obj4 = _metadata + 504;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj5 = _metadata + 512;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						gameMode = args.GameMode;
						obj6 = args.GameMode - 3;
						bool flag5 = (nint)obj6 < 3;
						object obj7 = !flag5;
						object obj8 = obj6 - 3;
						bool flag6 = obj8 == null;
						object obj9 = !flag6;
						object obj10 = obj7 & obj9;
						LobbyType lobbyType = (LobbyType)216;
						if (obj10 != null)
						{
							goto IL_0350;
						}
						CloudCommunicator communicator2 = _communicator;
						if ((object)_communicator != null)
						{
							RealtimeClient realtimeClient = communicator2.Client__BackingField;
							if (communicator2.Client__BackingField != null && realtimeClient.RealtimePeer != null)
							{
								realtimeClient.RealtimePeer.DisconnectTimeout = 5000;
								gameMode = args.GameMode;
								bool flag7 = args.GameMode != (GameMode)4;
								lobbyType = (LobbyType)0;
								if (flag7)
								{
									goto IL_0350;
								}
								num = (int?)flag8;
								lobbyType = (LobbyType)0;
								obj11 = 0;
								goto IL_0559;
							}
						}
					}
					goto IL_12ba;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51A0]");
		object message = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5190]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex = default;
		ex._002Ector((string)message);
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @378A584");
		Task<short> result = default;
		return result;
		IL_0350:
		object obj16 = gameMode - 3;
		bool flag10 = obj16 == null;
		object obj17 = !flag10;
		object obj18;
		if (args.EnableClientSessionCreation != (object)0)
		{
			obj18 = 1;
		}
		else
		{
			object obj19 = gameMode | (GameMode)4;
			if ((nint)obj19 == 6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5970]");
				object obj20 = 0;
				LobbyType lobbyType = (LobbyType)(int)obj20;
				flag8 = true;
				gameMode = args.GameMode;
				((StartGameArgs*)(nint)args)->EnableClientSessionCreation = (bool?)(object)0;
				flag8 = (bool?)(object)0;
				obj18 = 0;
			}
			else
			{
				obj18 = 0;
			}
			if (gameMode == (GameMode)5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5970]");
				object obj21 = 0;
				LobbyType lobbyType = (LobbyType)(int)obj21;
				flag8 = false;
				gameMode = args.GameMode;
				((StartGameArgs*)(nint)args)->EnableClientSessionCreation = (bool?)(object)0;
				flag8 = (bool?)(object)0;
				obj18 = 0;
			}
		}
		bool flag11 = gameMode < (GameMode)6;
		object obj22 = !flag11;
		object obj23 = gameMode - 6;
		bool flag12 = obj23 == null;
		object obj24 = !flag12;
		object obj25 = obj22 & obj24;
		num = (int?)flag8;
		obj11 = obj17;
		object obj26 = 0;
		if (obj25 == null)
		{
			object obj27 = 1 << (int)gameMode;
			object obj28 = obj27 & 0x64;
			bool flag13 = obj28 == null;
			num = (int?)flag8;
			obj11 = obj17;
			obj26 = 0;
			if (!flag13)
			{
				bool flag14 = obj18 == null;
				num = (int?)flag8;
				obj11 = obj17;
				if (flag14)
				{
					goto IL_0559;
				}
				bool? flag15 = (bool?)(object)(args + 432);
				bool value = ((bool?*)flag15)->Value;
				gameMode = args.GameMode;
				num = (int?)flag8;
				obj11 = obj17;
				obj26 = value;
			}
		}
		goto IL_13ad;
		IL_10be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X28_v5+10]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X28_v5+10]");
		if ((nint)0 == 0)
		{
			goto IL_12ba;
		}
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v977 @ X9_v15+188] (should have been resolved before IL gen)");
		goto IL_14f5;
		IL_0559:
		obj26 = 0;
		goto IL_13ad;
		IL_13d6:
		string text2;
		if (args.SessionName != null)
		{
			string text = args.SessionName.Trim();
			text2 = text;
		}
		else
		{
			text2 = null;
		}
		bool flag16 = string.IsNullOrEmpty(text2);
		if (!flag16)
		{
			goto IL_1452;
		}
		Func<string> sessionNameGenerator = args.SessionNameGenerator;
		if (args.SessionNameGenerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v867 @ X8_v58 (System.Func`1<System.String>)+18] (should have been resolved before IL gen)");
			string text3 = default;
			if (text3 != null)
			{
				string text4 = text3.Trim();
				text2 = text4;
				goto IL_1482;
			}
		}
		text2 = null;
		goto IL_1482;
		IL_14f5:
		CloudServices cloudServices;
		AsyncConfig config = cloudServices.BuildAsyncConfig(args.StartGameCancellationToken);
		CloudCommunicator communicator3 = _communicator;
		object obj31 = obj11 & 1;
		TypedLobby typedLobby;
		(EnterRoomArgs, JoinRandomRoomArgs) tuple;
		if (obj31 != null)
		{
			if (flag16)
			{
				if (obj26 != null)
				{
					if ((object)_communicator != null)
					{
						return AsyncExtensions.JoinRandomOrCreateRoomAsync(communicator3.Client__BackingField, (JoinRandomRoomArgs)(object)typedLobby, tuple, throwOnError: true, config);
					}
				}
				else if ((object)_communicator != null)
				{
					return AsyncExtensions.JoinRandomRoomAsync(communicator3.Client__BackingField, (JoinRandomRoomArgs)(object)typedLobby, throwOnError: true, config);
				}
			}
			else if (obj26 != null)
			{
				if ((object)_communicator != null)
				{
					return AsyncExtensions.JoinOrCreateRoomAsync(communicator3.Client__BackingField, tuple, throwOnError: true, config);
				}
			}
			else if ((object)_communicator != null)
			{
				return AsyncExtensions.JoinRoomAsync(communicator3.Client__BackingField, tuple, throwOnError: true, config);
			}
		}
		else if ((object)_communicator != null)
		{
			return AsyncExtensions.CreateAndJoinRoomAsync(communicator3.Client__BackingField, tuple, throwOnError: true, config);
		}
		goto IL_12ba;
		IL_1452:
		object obj32 = (_003F?)args.PlayerCount & 0xFF;
		int num2;
		if (obj32 != null)
		{
			num2 = (_003F?)args.PlayerCount >> 32;
			goto IL_14ac;
		}
		NetworkProjectConfig config2 = args.Config;
		if ((object)args.Config != null)
		{
			SimulationConfig simulation = config2.Simulation;
			if (config2.Simulation != null)
			{
				num = simulation.PlayerCount;
			}
		}
		NetworkProjectConfig global = NetworkProjectConfig.Global;
		if ((object)global != null)
		{
			SimulationConfig simulation2 = global.Simulation;
			if (global.Simulation != null)
			{
				num2 = simulation2.PlayerCount;
				goto IL_14ac;
			}
		}
		goto IL_12ba;
		IL_12ba:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_12c8;
		IL_13ad:
		CloudCommunicator communicator4 = _communicator;
		if ((object)_communicator != null && communicator4.Client__BackingField != null)
		{
			if (!communicator4.Client__BackingField.InLobby)
			{
				string text5 = args.CustomLobbyName;
				if (args.CustomLobbyName != null)
				{
					text5 = text5.Trim();
				}
				if (string.IsNullOrEmpty(text5))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50E8]");
					object obj33 = 0;
					object obj34 = obj33;
					object obj36;
					if (args.GameMode == (GameMode)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v110+E4]");
						bool flag17 = (nint)0 == 0;
						object obj35 = !flag17;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj34 = obj33;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v110+A0]");
						obj36 = (nint)0 + (nint)8;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v110+E4]");
						bool flag18 = (nint)0 == 0;
						object obj37 = !flag18;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj34 = obj33;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v110+A0]");
						obj36 = 0;
					}
					typedLobby = (TypedLobby)obj36;
				}
				else
				{
					if (args.CustomLobbyName == null)
					{
						goto IL_12ba;
					}
					string name = args.CustomLobbyName.Trim();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5198]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					TypedLobby typedLobby2 = default;
					typedLobby2._002Ector(name, (LobbyType)0);
					LobbyType lobbyType = (LobbyType)0;
					typedLobby = typedLobby2;
				}
				goto IL_13d6;
			}
			CloudCommunicator communicator5 = _communicator;
			if ((object)_communicator != null)
			{
				RealtimeClient realtimeClient2 = communicator5.Client__BackingField;
				if (communicator5.Client__BackingField != null)
				{
					typedLobby = realtimeClient2.CurrentLobby__BackingField;
					goto IL_13d6;
				}
			}
		}
		goto IL_12ba;
		IL_1482:
		if (string.IsNullOrEmpty(text2))
		{
			Guid guid = Guid.NewGuid();
			Guid guid2 = default;
			string text6 = guid2.ToString();
			text2 = text6;
		}
		goto IL_1452;
		IL_14ac:
		CloudCommunicator communicator6 = _communicator;
		int num3 = ((gameMode != (GameMode)3) ? num2 : (num2 + 1));
		if ((object)_communicator == null)
		{
			goto IL_12ba;
		}
		bool? flag19 = (bool?)(object)(args + 384);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51C0]");
		object obj39 = 0;
		bool flag20 = (*(bool?*)flag19) ?? true;
		bool? flag21 = (bool?)(object)(args + 386);
		bool flag22 = (*(bool?*)flag21) ?? true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
		object obj40 = 0;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v17+E4]");
		bool flag23 = (nint)0 == 0;
		object obj42 = !flag23;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = (nint)obj6 < 4;
		object obj43 = !flag24;
		bool flag25 = (byte)(int)(~obj43) != 0;
		RealtimeClient client = communicator6.Client__BackingField;
		TypedLobby typedLobby3 = typedLobby;
		string roomName = text2;
		Dictionary<string, SessionProperty> sessionProperties = args.SessionProperties;
		bool isOpen = flag20;
		bool isVisible = flag22;
		bool extendedTtl = flag25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ X1 (Fusion.StartGameArgs)+185]");
		tuple = RealtimeClientExtensions.BuildRoomArgs(client, typedLobby3, roomName, num3, sessionProperties, isOpen, isVisible, 0, extendedTtl, (MatchmakingMode)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj44 = 0;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v21+A0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v22+E0]");
		object obj47 = 0;
		if (flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v22+E0]");
			bool flag26 = (nint)0 == 0;
			cloudServices = (CloudServices)tuple;
			if (!flag26)
			{
				if (tuple != ((EnterRoomArgs, JoinRandomRoomArgs))(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v38 (System.ValueTuple`2<Photon.Realtime.EnterRoomArgs, Photon.Realtime.JoinRandomRoomArgs>)+20]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v38 (System.ValueTuple`2<Photon.Realtime.EnterRoomArgs, Photon.Realtime.JoinRandomRoomArgs>)+20]");
					if ((nint)0 != 0)
					{
						CloudCommunicator communicator7 = _communicator;
						if ((object)_communicator != null)
						{
							RealtimeClient realtimeClient3 = communicator7.Client__BackingField;
							if (communicator7.Client__BackingField != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5008]");
								object obj49 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51E8]");
								object obj50 = 0;
								NetworkRunner runner = _runner;
								string text8;
								if (realtimeClient3.CurrentRegion__BackingField != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5000]");
									object oldValue = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
									object newValue = 0;
									string text7 = realtimeClient3.CurrentRegion__BackingField.Replace((string)oldValue, (string)newValue);
									text8 = text7;
								}
								else
								{
									text8 = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v46+10]");
								string text9 = (string)obj50 + (string)0 + (string)obj49 + text8;
								Dictionary<string, SessionProperty> dictionary = null;
								goto IL_10be;
							}
						}
					}
				}
				goto IL_12ba;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v22+E0]");
			bool flag27 = (nint)0 == 0;
			cloudServices = (CloudServices)tuple;
			if (!flag27)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj51 = 0;
				NetworkRunner runner = _runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				string[] array = default;
				if (array == null)
				{
					goto IL_12ba;
				}
				if (array.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51F0]");
					object obj52 = 0;
					object obj53 = array + 32;
					obj53 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (tuple == ((EnterRoomArgs, JoinRandomRoomArgs))(object)0)
					{
						goto IL_12ba;
					}
					object obj54 = array.Length & 0xFFFFFFFEL;
					if (obj54 != null)
					{
						object obj55 = array + 40;
						(obj55, _) = tuple;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X26_v10-10]");
						bool flag28 = (nint)0 < (nint)2;
						object obj56 = !flag28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X26_v10-10]");
						object obj57 = -2;
						bool flag29 = obj57 == null;
						object obj58 = ~obj56;
						object obj59 = obj58 | flag29;
						if (obj59 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51E0]");
							object obj60 = 0;
							object obj61 = array + 48;
							obj61 = obj60;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v38 (System.ValueTuple`2<Photon.Realtime.EnterRoomArgs, Photon.Realtime.JoinRandomRoomArgs>)+20]");
							object obj62 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v38 (System.ValueTuple`2<Photon.Realtime.EnterRoomArgs, Photon.Realtime.JoinRandomRoomArgs>)+20]");
							if ((nint)0 == 0)
							{
								goto IL_12ba;
							}
							object obj63 = array.Length & 0xFFFFFFFCL;
							if (obj63 != null)
							{
								object obj64 = array + 56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v36+10]");
								obj64 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X26_v12-20]");
								bool flag30 = (nint)0 < (nint)4;
								object obj65 = !flag30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X26_v12-20]");
								object obj66 = -4;
								bool flag31 = obj66 == null;
								object obj67 = ~obj65;
								object obj68 = obj67 | flag31;
								if (obj68 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5008]");
									object obj69 = 0;
									object obj70 = array + 64;
									obj70 = obj69;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									CloudCommunicator communicator8 = _communicator;
									if ((object)_communicator != null)
									{
										RealtimeClient realtimeClient4 = communicator8.Client__BackingField;
										if (communicator8.Client__BackingField != null)
										{
											string text12;
											if (realtimeClient4.CurrentRegion__BackingField != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5000]");
												object oldValue2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
												object obj71 = 0;
												string text10 = (string)obj71;
												string text11 = realtimeClient4.CurrentRegion__BackingField.Replace((string)oldValue2, (string)obj71);
												int num4 = 0;
												text12 = text11;
											}
											else
											{
												int num4 = num3;
												string text10 = text2;
												text12 = null;
											}
											bool flag32 = array.Length < 5;
											object obj72 = !flag32;
											object obj73 = array.Length - 5;
											bool flag33 = obj73 == null;
											object obj74 = ~obj72;
											object obj75 = obj74 | flag33;
											if (obj75 == null)
											{
												object obj76 = array + 72;
												obj76 = text12;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												string text9 = string.Concat(array);
												Dictionary<string, SessionProperty> dictionary = args.SessionProperties;
												goto IL_10be;
											}
											goto IL_12c8;
										}
									}
									goto IL_12ba;
								}
							}
						}
					}
				}
				goto IL_12c8;
			}
		}
		goto IL_14f5;
		IL_12c8:
		return (Task<short>)(object)new IndexOutOfRangeException();
	}

	public unsafe Task DisconnectFromCloud()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected VT, but got Unknown
		//IL_0104: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5200]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 48;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 24;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35014A8");
			object obj10 = default;
			if (obj10 != null)
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj10 + 24);
				return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Task;
			}
		}
		return (Task)(object)new NullReferenceException();
	}

	public string GetActorUserID(int actorID)
	{
		//IL_0113: Expected Obj, but got I
		bool isInRoom = IsInRoom;
		bool flag = !isInRoom;
		string result = null;
		if (!flag)
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null)
			{
				RealtimeClient realtimeClient = communicator.Client__BackingField;
				if (communicator.Client__BackingField != null)
				{
					Room room = realtimeClient.CurrentRoom__BackingField;
					if (realtimeClient.CurrentRoom__BackingField != null && room.players != null)
					{
						if (((Dictionary<int, System.__Canon>)(object)room.players).TryGetValue(actorID, out System.__Canon value))
						{
							if (value == null)
							{
								goto IL_0122;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ stack_-28_v4 (System.__Canon)+28]");
							result = (string)0;
						}
						else
						{
							result = null;
						}
						goto IL_015c;
					}
				}
			}
			goto IL_0122;
		}
		goto IL_015c;
		IL_0122:
		return (string)(object)new NullReferenceException();
		IL_015c:
		return result;
	}

	public unsafe bool TryGetActorIdByUniqueId(long uniqueId, out int actorId)
	{
		//IL_00b1: Expected I4, but got Obj
		//IL_009e: Expected Obj, but got I8
		//IL_008c: Expected Obj, but got I
		CloudServicesMetadata metadata = _metadata;
		if (_metadata != null && metadata.UniqueIdToReflexiveInfoTable != null)
		{
			bool flag = ((Dictionary<long, System.__Canon>)(object)metadata.UniqueIdToReflexiveInfoTable).TryGetValue(uniqueId, out System.__Canon value);
			object obj;
			if (flag)
			{
				if (value == null)
				{
					goto IL_00a3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-28_v3 (System.__Canon)+28]");
				obj = 0;
			}
			else
			{
				obj = 4294967295L;
			}
			ref int reference = ref *(int*)obj;
			return flag;
		}
		goto IL_00a3;
		IL_00a3:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	internal unsafe void OnInternalConnectionAttempt(int attempt, int totalConnectionAttempts, out bool shouldChange, out NetAddress newAddress)
	{
		//IL_024f: Expected Obj, but got I4
		//IL_026b: Invalid comparison between F8 and I4
		//IL_027c: Expected Obj, but got I4
		//IL_0294: Invalid comparison between F8 and I4
		//IL_02a5: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I
		//IL_0392: Expected Obj, but got I4
		//IL_03ce: Expected Ref, but got F8
		//IL_040a: Expected Obj, but got VT
		//IL_01e4: Expected F8, but got VT
		//IL_01fe: Expected Ref, but got VT
		//IL_0538: Expected Obj, but got VT
		ref bool reference = ref *(bool*)null;
		ref NetAddress reference2 = ref *(NetAddress*)null;
		_ = 0;
		_ = 0;
		NetworkRunner runner = _runner;
		bool flag = (object)_runner == null;
		int num2 = default;
		int num = num2;
		CloudServices cloudServices = this;
		if (flag)
		{
			goto IL_0440;
		}
		bool flag2 = runner.GameMode__BackingField != (GameMode)5;
		CloudServices cloudServices2 = this;
		CloudServicesMetadata metadata3;
		NATPunchStage nATPunchStage;
		NetAddress netAddress = default;
		if (!flag2)
		{
			CloudServicesMetadata metadata = _metadata;
			bool flag3 = _metadata == null;
			num = num2;
			cloudServices = this;
			if (flag3)
			{
				goto IL_0440;
			}
			if (metadata.CurrentPunchStage__BackingField != (NATPunchStage)2)
			{
				if (metadata.CurrentPunchStage__BackingField != (NATPunchStage)1)
				{
					bool flag4 = metadata.CurrentPunchStage__BackingField == 0;
					object obj = !flag4;
					cloudServices2 = this;
					if (obj == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5218]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5228]");
						object format = 0;
						object arg = default;
						string text = string.Format((string)format, arg);
						Assert.AlwaysFail(text);
						num2 = 0;
						cloudServices2 = (CloudServices)(object)text;
					}
				}
				else
				{
					bool flag5 = num2 < 3;
					cloudServices2 = this;
					if (!flag5)
					{
						reference = ref *(bool*)1;
						CloudServicesMetadata metadata2 = _metadata;
						bool flag6 = _metadata == null;
						num = num2;
						cloudServices = this;
						if (!flag6)
						{
							Fusion.Protocol.ReflexiveInfo reflexiveInfo = metadata2.RemoteReflexiveInfo__BackingField;
							bool flag7 = metadata2.RemoteReflexiveInfo__BackingField == null;
							num = num2;
							cloudServices = this;
							if (!flag7)
							{
								double num3 = (double)reflexiveInfo.PublicAddr;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v22 (Fusion.Protocol.ReflexiveInfo)+40]");
								_ = 0;
								reference2 = ref *(NetAddress*)reflexiveInfo.PublicAddr;
								metadata3 = _metadata;
								bool flag8 = _metadata == null;
								num = num2;
								cloudServices = this;
								if (!flag8)
								{
									nATPunchStage = (NATPunchStage)2;
									goto IL_0523;
								}
							}
						}
						goto IL_0440;
					}
				}
			}
			else
			{
				int num4 = default;
				object obj3 = num4 + num4;
				double num3 = (double)obj3 / 3.0;
				bool flag9 = num3 < (double)num2;
				object obj4 = !flag9;
				double num5 = num3 - (double)num2;
				bool flag10 = num5 == 0.0;
				object obj5 = !flag10;
				object obj6 = obj4 & obj5;
				int num6 = num2;
				cloudServices2 = this;
				if (obj6 == null)
				{
					reference = ref *(bool*)1;
					CloudServicesMetadata metadata4 = _metadata;
					bool flag11 = _metadata == null;
					num6 = num2;
					num = num2;
					cloudServices = this;
					if (!flag11)
					{
						Fusion.Protocol.ReflexiveInfo reflexiveInfo2 = metadata4.RemoteReflexiveInfo__BackingField;
						bool flag12 = metadata4.RemoteReflexiveInfo__BackingField == null;
						num6 = num2;
						num = num2;
						cloudServices = this;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
							object obj7 = 0;
							object obj8 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v8+E4]");
							bool flag13 = (nint)0 == 0;
							object obj9 = !flag13;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							netAddress = NetAddress.FromActorId(reflexiveInfo2.ActorNr);
							double num7 = default;
							reference2 = ref *(NetAddress*)num7;
							metadata3 = _metadata;
							bool flag14 = _metadata == null;
							num6 = num2;
							num3 = num7;
							num = 0;
							cloudServices = (CloudServices)netAddress;
							if (!flag14)
							{
								num6 = num2;
								num3 = num7;
								nATPunchStage = (NATPunchStage)3;
								num2 = 0;
								goto IL_0523;
							}
						}
					}
					goto IL_0440;
				}
			}
		}
		goto IL_04e4;
		IL_0485:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		return;
		IL_0440:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		bool flag15 = num8 != 0;
		NullReferenceException ex = (NullReferenceException)(object)cloudServices;
		if (!flag15)
		{
			ex = new NullReferenceException();
		}
		goto IL_0485;
		IL_0523:
		metadata3.CurrentPunchStage__BackingField = nATPunchStage;
		cloudServices2 = (CloudServices)netAddress;
		goto IL_04e4;
		IL_04e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		bool flag16 = num9 != 0;
		num = num2;
		ex = (NullReferenceException)(object)cloudServices2;
		if (!flag16)
		{
			return;
		}
		goto IL_0485;
	}

	private unsafe void Connect(NATPunchStage punchStage, NetAddress endPoint)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_0092: Expected VT, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_0150: Expected VT, but got Ref
		//IL_017e: Expected I, but got Obj
		//IL_018e: Expected VT, but got I
		//IL_0196: Expected Obj, but got Ref
		//IL_00d2: Expected VT, but got Obj
		//IL_00dc: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+E0]");
		bool flag = (nint)0 == 0;
		NetAddress netAddress = endPoint;
		NATPunchStage nATPunchStage = punchStage;
		string text;
		object obj8;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
			object obj5 = 0;
			Address nativeAddress = endPoint.NativeAddress;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5230]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj6 = default;
			text = string.Format((string)format, obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v3+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v3+10]");
			bool flag2 = (nint)0 == 0;
			netAddress = (NetAddress)0;
			obj8 = obj6;
			if (flag2)
			{
				goto IL_01af;
			}
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v8+190]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ X9_v8+188] (should have been resolved before IL gen)");
			netAddress = (NetAddress)text;
			nATPunchStage = (NATPunchStage)_runner;
		}
		CloudServicesMetadata metadata = _metadata;
		bool flag3 = _metadata == null;
		obj8 = nATPunchStage;
		text = (string)(object)this;
		NullReferenceException runner2;
		if (!flag3)
		{
			metadata.CurrentPunchStage__BackingField = punchStage;
			bool flag4 = (object)_runner == null;
			obj8 = nATPunchStage;
			text = (string)(object)_runner;
			if (!flag4)
			{
				Address nativeAddress = endPoint.NativeAddress;
				NetworkRunner runner = _runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7 (Fusion.CloudServicesMetadata)+170]");
				object obj10 = default;
				runner.Connect((NetAddress)(&obj10), (byte[])0, metadata.UniqueId__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				bool flag5 = num2 != 0;
				nint num = (nint)metadata.UniqueId__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7 (Fusion.CloudServicesMetadata)+170]");
				netAddress = (NetAddress)0;
				obj8 = (object)(&obj10);
				runner2 = (NullReferenceException)(object)_runner;
				if (!flag5)
				{
					return;
				}
				goto IL_01f4;
			}
		}
		goto IL_01af;
		IL_01f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		return;
		IL_01af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		bool flag6 = num3 != 0;
		runner2 = (NullReferenceException)(object)text;
		if (!flag6)
		{
			runner2 = new NullReferenceException();
		}
		goto IL_01f4;
	}

	public void Dispose()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		object obj = this + 48;
		object obj2 = obj;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X0_v1+40]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				object obj4 = obj + 56;
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal void OnRoomChanged()
	{
		//IL_007b: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		bool isInRoom = IsInRoom;
		if (!isInRoom)
		{
			return;
		}
		NetworkRunner runner = _runner;
		if (runner.SessionInfo__BackingField != null)
		{
			CloudCommunicator communicator = _communicator;
			RealtimeClient realtimeClient = communicator.Client__BackingField;
			((CloudServices)isInRoom).UpdateSessionInfo(runner.SessionInfo__BackingField, realtimeClient.CurrentRoom__BackingField, realtimeClient.CurrentRegion__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v10+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v11+E0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v11+E0]");
			if ((nint)0 != 0)
			{
				NetworkRunner runner2 = _runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5078]");
				object format = 0;
				string text = string.Format((string)format, runner2.SessionInfo__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X20_v5+10]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+188]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+190]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X4_v1 (should have been resolved before IL gen)");
			}
		}
	}

	internal bool UpdateRoomProperties(Dictionary<string, SessionProperty> customProperties)
	{
		//IL_00db: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		if (IsServerOrMasterClient && IsInRoom)
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return RealtimeClientExtensions.UpdateRoomProperties(communicator.Client__BackingField, customProperties);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	internal bool UpdateRoomIsOpen(bool status)
	{
		//IL_00db: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		if (IsServerOrMasterClient && IsInRoom)
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return RealtimeClientExtensions.UpdateRoomIsOpen(communicator.Client__BackingField, status);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	internal bool UpdateRoomIsVisible(bool status)
	{
		//IL_00db: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		if (IsServerOrMasterClient && IsInRoom)
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return RealtimeClientExtensions.UpdateRoomIsVisible(communicator.Client__BackingField, status);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	private unsafe void OnRoomListChanged(List<RoomInfo> roomList)
	{
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_0651: Expected Obj, but got I
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Ref, but got Unknown
		//IL_067c: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I4
		//IL_01ff: Expected I, but got Obj
		//IL_00d9: Expected I, but got Obj
		//IL_05aa: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got I
		//IL_0406: Expected I, but got Obj
		//IL_0222: Expected I, but got Obj
		//IL_0199: Expected I, but got Obj
		//IL_02c1: Expected I, but got Obj
		bool flag = roomList == null;
		RoomInfo roomInfo2 = default;
		RoomInfo roomInfo = roomInfo2;
		Enumerator<, > val = (Enumerator<, >)0;
		IEnumerable<System.__Canon> enumerable = (IEnumerable<System.__Canon>)roomList;
		CloudServices cloudServices = this;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5048]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5018]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5028]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5070]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5038]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5020]");
			object obj6 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)roomList).GetEnumerator();
			SessionInfo sessionInfo = default;
			Enumerator<, > val2 = default;
			object obj14 = default;
			List<System.__Canon> list = default;
			while (true)
			{
				System.__Canon _Canon = (System.__Canon)obj;
				nint num;
				if (val.MoveNext())
				{
					if (roomInfo2 != null)
					{
						if (~(roomInfo2.RemovedFromList ? 1u : 0u) != 0)
						{
							if ((object)_cachedSessionList == null)
							{
								goto IL_0475;
							}
							_Canon = (System.__Canon)(object)roomInfo2.name;
							System.__Canon _Canon2 = (System.__Canon)obj2;
							bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)(object)_cachedSessionList).ContainsKey((System.__Canon)(object)roomInfo2.name);
							bool flag3 = !flag2;
							object obj7 = !flag3;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								sessionInfo._002Ector();
								bool flag4 = (object)_cachedSessionList == null;
								num = unchecked((nint)null);
								enumerable = null;
								if (flag4)
								{
									goto IL_04a7;
								}
								string text = (string)obj5;
								((Dictionary<System.__Canon, System.__Canon>)(object)_cachedSessionList).set_Item((System.__Canon)(object)roomInfo2.name, (System.__Canon)(object)sessionInfo);
								_Canon2 = (System.__Canon)(object)sessionInfo;
								_Canon = (System.__Canon)(object)roomInfo2.name;
							}
							bool flag5 = (object)_cachedSessionList == null;
							num = (nint)_Canon2;
							if (!flag5)
							{
								_Canon = (System.__Canon)(object)roomInfo2.name;
								num = (nint)obj3;
								System.__Canon _Canon3 = ((Dictionary<System.__Canon, System.__Canon>)(object)_cachedSessionList).get_Item((System.__Canon)(object)roomInfo2.name);
								CloudCommunicator communicator = _communicator;
								if ((object)_communicator == null)
								{
									goto IL_0467;
								}
								RealtimeClient realtimeClient = communicator.Client__BackingField;
								if (communicator.Client__BackingField != null)
								{
									string text = realtimeClient.CurrentRegion__BackingField;
									((CloudServices)(object)_Canon3).UpdateSessionInfo((SessionInfo)(object)_Canon3, roomInfo2, realtimeClient.CurrentRegion__BackingField);
									num = (nint)roomInfo2;
									continue;
								}
								goto IL_0483;
							}
							goto IL_0491;
						}
						if ((object)_cachedSessionList != null)
						{
							num = (nint)obj6;
							bool flag6 = ((Dictionary<System.__Canon, System.__Canon>)(object)_cachedSessionList).Remove((System.__Canon)(object)roomInfo2.name);
							continue;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_0467;
				}
				roomInfo = null;
				val = val2;
				object obj8 = 0;
				Enumerator<, > val3 = val2;
				Enumerator<, > val4 = (Enumerator<, >)(ref val);
				cloudServices = this;
				object obj9 = 0;
				object obj10 = 7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5040]");
					object obj11 = 0;
					enumerable = (IEnumerable<System.__Canon>)obj11;
					((Enumerator<, >*)val4)->Dispose();
					bool flag7 = obj9 == null;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						bool flag8 = roomInfo == null;
						object obj13 = !flag8;
						OutOfMemoryException ex3 = (OutOfMemoryException)val4;
						if (obj13 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)enumerable == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						roomInfo = (RoomInfo)1;
						obj9 = obj8;
					}
					else
					{
						if ((nint)enumerable != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3688");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj9 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj8 = obj14;
					}
					obj10 = 0;
				}
				if ((nint)obj10 != 7)
				{
					bool flag9 = obj10 == null;
					object obj15 = !flag9;
					if (obj15 != null)
					{
						return;
					}
				}
				if ((object)cloudServices._cachedSessionList == null)
				{
					break;
				}
				cloudServices = (CloudServices)(object)cloudServices._runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5030]");
				object obj16 = 0;
				ValueCollection<> values = ((Dictionary<System.__Canon, System.__Canon>)(object)cloudServices._cachedSessionList).Values;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5068]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5060]");
				object obj18 = 0;
				num = (nint)obj18;
				list._002Ector((IEnumerable<System.__Canon>)values);
				bool flag10 = (object)cloudServices == null;
				enumerable = (IEnumerable<System.__Canon>)values;
				if (flag10)
				{
					break;
				}
				((NetworkRunner)(object)cloudServices).InvokeSessionListUpdated((List<SessionInfo>)(object)list);
				return;
				IL_0483:
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_0491;
				IL_0467:
				NullReferenceException ex5 = new NullReferenceException();
				goto IL_0475;
				IL_04a7:
				NullReferenceException ex6 = new NullReferenceException();
				roomInfo = null;
				val = val2;
				obj8 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				cloudServices = this;
				break;
				IL_0491:
				NullReferenceException ex7 = new NullReferenceException();
				enumerable = (IEnumerable<System.__Canon>)_Canon;
				goto IL_04a7;
				IL_0475:
				NullReferenceException ex8 = new NullReferenceException();
				goto IL_0483;
			}
		}
		throw new NullReferenceException();
	}

	internal unsafe Task SendJoin(CancellationToken externalCancellationToken = default(CancellationToken), long uniqueId = default(long), int playerRefOverride = default(int), int playerRefCountOverride = default(int), byte[] encryptionKeyOverride = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got VT
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected VT, but got Unknown
		//IL_0158: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5250]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5258]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 80;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 48;
			obj9 = externalCancellationToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj3 + 72;
			obj10 = encryptionKeyOverride;
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

	private void SendNetworkSyncMessage(NetworkProjectConfig projectConfig)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		string text = NetworkProjectConfig.SerializeMinimal(projectConfig);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E0]");
		bool flag = (nint)0 == 0;
		NetworkRunner networkRunner = null;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5268]");
			object obj5 = 0;
			string text2 = (string)obj5 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X22_v2+10]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ X9_v5+188] (should have been resolved before IL gen)");
			networkRunner = _runner;
		}
		CloudServicesMetadata metadata = _metadata;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5260]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Fusion.Protocol.NetworkConfigSync networkConfigSync = default;
		networkConfigSync._002Ector((Fusion.Protocol.SyncType)2, text, metadata.CurrentProtocolMessageVersion__BackingField);
		_communicator.SendMessage(0, (IMessage)networkConfigSync);
	}

	private unsafe void SendReflexiveInfo(Fusion.Sockets.Stun.StunResult stunResult)
	{
		//IL_021c: Expected I4, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_002a: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		//IL_00b3: Expected VT, but got Ref
		//IL_00b3: Expected VT, but got Ref
		//IL_00b3: Expected I4, but got Obj
		//IL_00f5: Expected VT, but got Ref
		//IL_0105: Expected I4, but got Obj
		//IL_017f: Expected VT, but got I4
		//IL_0187: Expected I, but got Obj
		Fusion.Protocol.CommunicatorBase communicatorBase = _communicator;
		bool flag = (object)_communicator == null;
		int num = (int)stunResult;
		NullReferenceException communicator;
		if (!flag)
		{
			nint num2 = (nint)communicatorBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7 (Il2CppClass<Fusion.Protocol.CommunicatorBase>)+200]");
			num = 0;
			communicatorBase = (Fusion.Protocol.CommunicatorBase)((Attribute)(object)communicatorBase).IsDefaultAttribute();
			if (stunResult != null)
			{
				CloudServicesMetadata metadata = _metadata;
				if (_metadata != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5270]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Fusion.Protocol.ReflexiveInfo reflexiveInfo = default;
					object obj2 = default;
					object obj3 = default;
					reflexiveInfo._002Ector((int)communicatorBase, (NetAddress)(&obj2), (NetAddress)(&obj3), stunResult.NatType, null, metadata.CurrentProtocolMessageVersion__BackingField);
					bool flag2 = (object)_communicator == null;
					Version version = null;
					Fusion.Protocol.ProtocolMessageVersion protocolMessageVersion = metadata.CurrentProtocolMessageVersion__BackingField;
					byte[] array = null;
					NATType natType = stunResult.NatType;
					NetAddress netAddress = (NetAddress)(&obj3);
					nint num3 = (nint)(&obj2);
					num = (int)communicatorBase;
					communicatorBase = _communicator;
					if (!flag2)
					{
						_communicator.SendMessage(0, (IMessage)reflexiveInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
						bool flag3 = num4 != 0;
						version = null;
						protocolMessageVersion = metadata.CurrentProtocolMessageVersion__BackingField;
						array = null;
						natType = stunResult.NatType;
						netAddress = (NetAddress)0;
						num3 = (nint)reflexiveInfo;
						num = 0;
						communicator = (NullReferenceException)(object)_communicator;
						if (!flag3)
						{
							return;
						}
						goto IL_01ee;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		bool flag4 = num5 != 0;
		communicator = (NullReferenceException)(object)communicatorBase;
		if (!flag4)
		{
			communicator = new NullReferenceException();
		}
		goto IL_01ee;
		IL_01ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public void SendChangeMasterClient(int newCandidate)
	{
		//IL_0015: Expected Obj, but got I
		CloudServicesMetadata metadata = _metadata;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5278]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Fusion.Protocol.ChangeMasterClient changeMasterClient = default;
		changeMasterClient._002Ector(newCandidate, metadata.CurrentProtocolMessageVersion__BackingField);
		_communicator.SendMessage(0, (IMessage)changeMasterClient);
	}

	public void SendStateSnapshot(byte[] data, int snapshotSize, int tick, uint lastId)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		//IL_0107: Expected I, but got Obj
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I
		CloudServicesMetadata metadata = _metadata;
		byte[] array;
		if (_metadata != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5280]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Fusion.Protocol.Snapshot snapshot = default;
			snapshot._002Ector(tick, lastId, (Fusion.Protocol.SnapshotType)1, snapshotSize, data, metadata.CurrentProtocolMessageVersion__BackingField);
			bool flag = snapshot == null;
			Version version = null;
			Fusion.Protocol.ProtocolMessageVersion protocolMessageVersion = metadata.CurrentProtocolMessageVersion__BackingField;
			nint num = (nint)data;
			uint num2 = (uint)snapshotSize;
			int num3 = 1;
			int num4 = (int)lastId;
			array = (byte[])tick;
			if (!flag)
			{
				string text = ((object)snapshot).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5288]");
				object obj2 = 0;
				bool condition = (byte)(text & 1) != 0;
				Assert.Check(condition, (string)obj2);
				bool flag2 = (object)_communicator == null;
				version = null;
				protocolMessageVersion = metadata.CurrentProtocolMessageVersion__BackingField;
				num = (nint)data;
				num2 = (uint)snapshotSize;
				num3 = 1;
				num4 = 0;
				array = (byte[])obj2;
				if (!flag2)
				{
					_communicator.SendMessage(0, (IMessage)snapshot);
					return;
				}
				goto IL_018d;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			uint num2 = lastId;
			int num3 = tick;
			int num4 = snapshotSize;
			array = data;
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_018d;
		IL_018d:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag3 = (nint)array != 1;
		NullReferenceException ex4 = ex3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj4 = default;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj6 = default;
			object obj5 = obj6 & 1;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v21+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v8+20]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v8+20]");
				if ((nint)0 == 0)
				{
					return;
				}
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v227 @ X8_v9+1D8] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj10 = obj4;
			array = (byte[])(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			int num4 = 0;
			NullReferenceException ex5 = default;
			ex4 = ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public void SendClearSnapshot()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected I4, but got Unknown
		//IL_0123: Expected I, but got Obj
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		CloudServicesMetadata metadata = _metadata;
		nint num3 = default;
		if (_metadata != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5280]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Fusion.Protocol.Snapshot snapshot = default;
			snapshot._002Ector(0, 0u, (Fusion.Protocol.SnapshotType)4, 0, null, metadata.CurrentProtocolMessageVersion__BackingField);
			bool flag = snapshot == null;
			Version version = null;
			Fusion.Protocol.ProtocolMessageVersion protocolMessageVersion = metadata.CurrentProtocolMessageVersion__BackingField;
			byte[] array = null;
			int num = 0;
			Fusion.Protocol.SnapshotType snapshotType = (Fusion.Protocol.SnapshotType)4;
			uint num2 = 0u;
			num3 = unchecked((nint)null);
			if (!flag)
			{
				string text = ((object)snapshot).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5288]");
				object obj2 = 0;
				bool condition = (byte)(text & 1) != 0;
				Assert.Check(condition, (string)obj2);
				bool flag2 = (object)_communicator == null;
				version = null;
				protocolMessageVersion = metadata.CurrentProtocolMessageVersion__BackingField;
				array = null;
				num = 0;
				snapshotType = (Fusion.Protocol.SnapshotType)4;
				num2 = 0u;
				num3 = (nint)obj2;
				if (!flag2)
				{
					_communicator.SendMessage(0, (IMessage)snapshot);
					return;
				}
				goto IL_0167;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0167;
		IL_0167:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag3 = num3 != 1;
		NullReferenceException ex4 = ex3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj4 = default;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj6 = default;
			object obj5 = obj6 & 1;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8+20]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8+20]");
				if ((nint)0 == 0)
				{
					return;
				}
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v205 @ X8_v9+1D8] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj10 = obj4;
			num3 = 101790920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			uint num2 = 0u;
			NullReferenceException ex5 = default;
			ex4 = ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private void HandleJoinMessage(int sender, Fusion.Protocol.Join join)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5290]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj2 = 0;
		bool flag = sender == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		if (_joinAsyncHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3D5941C");
		}
	}

	private void HandleStartMessage(int sender, Fusion.Protocol.Start start)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52B0]");
		object obj3 = 0;
		object obj4 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2 + 72;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 64;
		obj6 = start;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj2 + 24;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @350D458");
	}

	private void HandleDisconnectMessage(int sender, Fusion.Protocol.Disconnect disconnect)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj2 = 0;
		bool flag = sender == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		CloudServicesMetadata metadata = _metadata;
		metadata.LastDisconnectMsg = disconnect;
		object obj3 = metadata + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void HandleNetworkConfigMessage(int sender, Fusion.Protocol.NetworkConfigSync configSync)
	{
	}

	private void HandleReflexiveInfoMessage(int sender, Fusion.Protocol.ReflexiveInfo reflexiveInfo)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52C8]");
		object obj3 = 0;
		object obj4 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2 + 72;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 64;
		obj6 = reflexiveInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj2 + 24;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @350D458");
	}

	private void HandleHostMigrationMessage(int sender, Fusion.Protocol.HostMigration hostMigration)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj2 = 0;
		bool flag = sender == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		_runner.SetupHostMigration(hostMigration);
		if (hostMigration.PeerMode == (Fusion.Protocol.PeerMode)2)
		{
			_runner.StartHostMigration();
		}
	}

	private unsafe void HandleSnapshotMessage(int sender, Fusion.Protocol.Snapshot snapshot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Ref, but got Unknown
		//IL_0142: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj2 = 0;
		bool flag = sender == 0;
		string text = (string)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		if (snapshot.SnapshotType__BackingField != (Fusion.Protocol.SnapshotType)2)
		{
			if (snapshot.SnapshotType__BackingField == (Fusion.Protocol.SnapshotType)1)
			{
				_runner.StartHostMigration(snapshot);
			}
			return;
		}
		NetworkRunner runner = _runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		bool flag2 = runner.LastSnapshotTick == snapshot.Tick__BackingField;
		int num = sender;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v24+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v25+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v25+10]");
			bool flag3 = (nint)0 == 0;
			num = sender;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52E8]");
				object format = 0;
				object arg = default;
				string text2 = string.Format((string)format, arg);
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v32+1A0]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X8_v32+198] (should have been resolved before IL gen)");
				text = text2;
			}
		}
		NetworkRunner runner2 = _runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		if (runner2.LastConfirmedSnapshotTick < snapshot.Tick__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			int num2 = Interlocked.Exchange(ref *(int*)(_runner + 52), snapshot.Tick__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v13+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v14+68]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v14+68]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52E0]");
				object format2 = 0;
				object arg2 = default;
				string text3 = string.Format((string)format2, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v5+10]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X9_v4+198] (should have been resolved before IL gen)");
			}
		}
	}

	private void HandleDummyTrafficSync(int sender, Fusion.Protocol.DummyTrafficSync dummyTrafficSync)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj2 = 0;
		bool flag = sender == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		SetupDummyTraffic(dummyTrafficSync);
	}

	private unsafe Task<bool> ConfirmJoin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected VT, but got Unknown
		//IL_00c4: Expected Ref, but got VT
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected VT, but got Unknown
		//IL_00f9: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5310]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5318]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<bool>.Create();
		if (obj3 != null)
		{
			object obj6 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj3 + 48;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<bool>)(obj3 + 24);
			_ = 4294967295L;
			System.__Canon stateMachine = default;
			((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder2)->Start<System.__Canon>(ref stateMachine);
			if (stateMachine != null)
			{
				AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<bool>)(stateMachine + 24);
				return ((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder3)->Task;
			}
		}
		return (Task<bool>)(object)new NullReferenceException();
	}

	private void HandlePlayerRefMapping(int sender, Fusion.Protocol.PlayerRefMapping msg)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		NetworkRunner runner = _runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef = PlayerRef.FromIndex(msg.PlayerRef);
		runner._simulation.RegisterUniqueIdPlayerMapping(msg.ActorId, msg.UniqueId, playerRef);
	}

	internal void StartBackgroundCloudServices()
	{
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I4
		NetworkRunner runner = _runner;
		NetworkProjectConfig config = runner._config;
		HostMigrationConfig hostMigration = config.HostMigration;
		if (~(hostMigration.EnableAutoUpdate ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4400]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5338]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Func<System.__Canon> func = default;
			func._002Ector((object)this, (IntPtr)obj2);
			CancellationToken operationsCancellationToken = _runner.OperationsCancellationToken;
			NetworkRunner runner2 = _runner;
			NetworkProjectConfig config2 = runner2._config;
			HostMigrationConfig hostMigration2 = config2.HostMigration;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5340]");
			object serviceName = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int interval = hostMigration2.UpdateDelay * 1000;
			Task task = TaskManager.Service((Func<Task<bool>>)(object)func, operationsCancellationToken, interval, (string)serviceName);
		}
	}

	private unsafe Task<bool> Service_HostMigrationSnapshot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected VT, but got Unknown
		//IL_00cc: Expected Ref, but got VT
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected VT, but got Unknown
		//IL_0101: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5348]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5318]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CService_HostMigrationSnapshot_003Ed__105 obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<bool>.Create();
		if (obj3 != null)
		{
			object obj6 = obj3 + 24;
			AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder2 = default;
			obj3._003C_003Et__builder = asyncTaskMethodBuilder2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj3 + 48;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<bool>)(obj3 + 24);
			_ = 4294967295L;
			System.__Canon stateMachine = default;
			((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder3)->Start<System.__Canon>(ref stateMachine);
			if (stateMachine != null)
			{
				AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder4 = (AsyncTaskMethodBuilder<bool>)(stateMachine + 24);
				return ((AsyncTaskMethodBuilder<bool>*)asyncTaskMethodBuilder4)->Task;
			}
		}
		return (Task<bool>)(object)new NullReferenceException();
	}

	private void SetupDummyTraffic(Fusion.Protocol.DummyTrafficSync dummyTrafficSyncMessage)
	{
		//IL_0212: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_03e1: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_02f1: Expected I, but got Obj
		//IL_0309: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I
		//IL_0446: Expected Obj, but got I
		//IL_0454: Expected I, but got Obj
		//IL_033e: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I
		if (dummyTrafficSyncMessage != null)
		{
			nint num = (nint)dummyTrafficSyncMessage;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v12 (Il2CppClass<Fusion.Protocol.DummyTrafficSync>)+180]");
			object obj = 0;
			ushort num2 = ((Enum)(object)dummyTrafficSyncMessage).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
			if ((num2 & 1) != 0)
			{
				object obj2 = this + 80;
				if (obj2 != null)
				{
					((CancellationTokenSource)obj2).Cancel();
					((CancellationTokenSource)obj2).Dispose();
					obj = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7050]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				CancellationTokenSource cancellationTokenSource = default;
				cancellationTokenSource._002Ector();
				obj2 = cancellationTokenSource;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				CancellationToken token = ((CancellationTokenSource)obj2).Token;
				CancellationToken operationsCancellationToken = _runner.OperationsCancellationToken;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(token, operationsCancellationToken);
				object obj6 = this + 88;
				obj6 = cancellationTokenSource2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj7 = this + 72;
				object obj8 = obj7;
				object obj10;
				object obj9;
				if (obj7 != null)
				{
					int num3 = dummyTrafficSyncMessage.Size__BackingField;
					int num4 = dummyTrafficSyncMessage.Size__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v15+18]");
					if ((nint)num4 == 0)
					{
						obj9 = 0;
						obj10 = dummyTrafficSyncMessage.Size__BackingField;
						goto IL_041c;
					}
				}
				else
				{
					int num3 = dummyTrafficSyncMessage.Size__BackingField;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj12 = default;
				obj7 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				System.Random random = default;
				random._002Ector();
				nint num5 = (nint)random;
				obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v31 (Il2CppClass<System.Random>)+1D0]");
				obj9 = 0;
				bool flag2 = ((Enum)(object)random).Equals(obj7);
				goto IL_041c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+78]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+78]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v9+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5308]");
			object obj19 = 0;
			object obj20 = obj18;
			NetworkRunner runner = _runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v3+188]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v3+190]");
			object obj22 = 0;
			object obj23 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X4_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_041c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4400]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D52F8]");
		object obj25 = 0;
		Func<System.__Canon> func = default;
		func._002Ector((object)this, (IntPtr)obj25);
		CancellationToken token2 = _dummyTrafficLinkCts.Token;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v23+E4]");
		bool flag3 = (nint)0 == 0;
		object obj28 = !flag3;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5300]");
		object serviceName = 0;
		Task task = TaskManager.Service((Func<Task<bool>>)(object)func, token2, dummyTrafficSyncMessage.SendInterval__BackingField, (string)serviceName);
	}

	private unsafe Task<Fusion.Sockets.Stun.StunResult> QueryReflexiveInfo()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected VT, but got Unknown
		//IL_00c4: Expected Ref, but got VT
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected VT, but got Unknown
		//IL_00f9: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5360]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<System.__Canon>.Create();
		if (obj3 != null)
		{
			object obj6 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj3 + 48;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<System.__Canon>)(obj3 + 24);
			_ = 4294967295L;
			System.__Canon stateMachine = default;
			((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder2)->Start<System.__Canon>(ref stateMachine);
			if (stateMachine != null)
			{
				AsyncTaskMethodBuilder<System.__Canon> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<System.__Canon>)(stateMachine + 24);
				return (Task<Fusion.Sockets.Stun.StunResult>)(object)((AsyncTaskMethodBuilder<System.__Canon>*)asyncTaskMethodBuilder3)->Task;
			}
		}
		return (Task<Fusion.Sockets.Stun.StunResult>)(object)new NullReferenceException();
	}

	public void UpdateInitializeArgs(NetworkRunnerInitializeArgs newArgs)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		object obj = _metadata + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
		object obj2 = _metadata + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private unsafe bool CheckSubnet(NetAddress remotePrivateEndPoint)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0034: Expected VT, but got I4
		//IL_003c: Expected I4, but got Obj
		//IL_01fd: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00aa: Expected Ref, but got VT
		//IL_010e: Expected VT, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00dc: Expected VT, but got I4
		//IL_0143: Expected VT, but got I4
		//IL_0169: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_01be: Expected VT, but got Ref
		//IL_01be: Expected VT, but got Ref
		//IL_01cf: Expected VT, but got Ref
		CloudServicesMetadata cloudServicesMetadata = _metadata;
		bool flag = _metadata == null;
		NetAddress netAddress = remotePrivateEndPoint;
		bool flag3;
		if (!flag)
		{
			Fusion.Sockets.Stun.StunResult localReflexiveInfo = _metadata.LocalReflexiveInfo;
			bool flag2 = localReflexiveInfo == null;
			IntPtr intPtr = default;
			NetAddress[] array = (NetAddress[])(nint)intPtr;
			netAddress = (NetAddress)0;
			flag3 = (byte)(int)localReflexiveInfo != 0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+E4]");
				bool flag4 = (nint)0 == 0;
				object obj3 = !flag4;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!((NetAddress*)remotePrivateEndPoint)->IsIPv6)
				{
					cloudServicesMetadata = _metadata;
					bool flag5 = _metadata == null;
					netAddress = (NetAddress)0;
					if (!flag5)
					{
						Fusion.Sockets.Stun.StunResult localReflexiveInfo2 = _metadata.LocalReflexiveInfo;
						bool flag6 = localReflexiveInfo2 == null;
						netAddress = (NetAddress)0;
						cloudServicesMetadata = (CloudServicesMetadata)(object)localReflexiveInfo2;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5380]");
							object obj4 = 0;
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+E4]");
							bool flag7 = (nint)0 == 0;
							object obj6 = !flag7;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj7 = default;
							object obj8 = default;
							flag3 = NetBitBuffer.SubnetMask.IsSameSubNet((NetAddress)(&obj7), (NetAddress)(&obj8));
							array = null;
							netAddress = (NetAddress)(&obj8);
							goto IL_01d4;
						}
					}
					goto IL_0210;
				}
				array = (NetAddress[])(nint)intPtr;
				netAddress = (NetAddress)0;
				flag3 = true;
			}
			goto IL_01d4;
		}
		goto IL_0210;
		IL_01d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		bool flag8 = num != 0;
		NullReferenceException ex = (NullReferenceException)flag3;
		if (!flag8)
		{
			return flag3;
		}
		goto IL_0255;
		IL_0255:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
		IL_0210:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		bool flag9 = num2 != 0;
		ex = (NullReferenceException)(object)cloudServicesMetadata;
		if (!flag9)
		{
			ex = new NullReferenceException();
		}
		goto IL_0255;
	}

	private void UpdateSessionInfo(SessionInfo sessionInfo, RoomInfo roomInfo, string region)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5248]");
		object obj = 0;
		nint num = (nint)roomInfo;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v2 (Il2CppClass<Photon.Realtime.RoomInfo>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		int num4;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v2 (Il2CppClass<Photon.Realtime.RoomInfo>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v6-8]");
			if (0 == (nint)obj2)
			{
				object obj6 = sessionInfo + 16;
				obj6 = roomInfo.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = roomInfo.isOpen;
				_ = roomInfo.maxPlayers;
				num4 = ((Room)roomInfo).PlayerCount;
				goto IL_0177;
			}
		}
		object obj7 = sessionInfo + 16;
		obj7 = roomInfo.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = roomInfo.isOpen;
		num4 = roomInfo.PlayerCount__BackingField;
		_ = roomInfo.maxPlayers;
		goto IL_0177;
		IL_0177:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5240]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5238]");
		object obj9 = 0;
		sessionInfo.PlayerCount__BackingField = num4;
		object obj10 = sessionInfo + 24;
		obj10 = region;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Dictionary<string, SessionProperty> customProperties = Fusion.Matchmaking.Extensions.RealtimeExtensionsRoomInfo.GetCustomProperties(roomInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4283AD0");
		object obj11 = sessionInfo + 32;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 1;
	}

	private unsafe void Run_ReversePing(NetAddress remoteAddr)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected VT, but got Unknown
		//IL_00b4: Expected Ref, but got VT
		//IL_00e5: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5388]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj3;
		_ = remoteAddr.Block2;
		_ = remoteAddr.NativeAddress;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetAddress netAddress = (NetAddress)(obj4 + 8);
		if (((NetAddress*)netAddress)->IsValid)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5390]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5398]");
			object obj8 = 0;
			Func<CancellationToken, System.__Canon> func = default;
			func._002Ector(obj2, (IntPtr)obj8);
			CancellationToken operationsCancellationToken = _runner.OperationsCancellationToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Task task = TaskManager.Run((Func<CancellationToken, Task>)(object)func, operationsCancellationToken, (TaskCreationOptions)0);
		}
	}

	private unsafe bool HandlePhotonCloudDisconnect(ShutdownReason shutdownReason)
	{
		//IL_0293: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_0897: Expected I4, but got Obj
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected Obj, but got Unknown
		//IL_09a5: Expected I, but got Obj
		//IL_08d4: Expected Obj, but got Ref
		//IL_02f6: Expected Obj, but got I4
		//IL_0902: Expected Obj, but got I
		//IL_0912: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0961: Expected I4, but got Obj
		//IL_0353: Expected Obj, but got I4
		//IL_080c: Invalid comparison between VT and I4
		//IL_0136: Expected Obj, but got I4
		//IL_03bb: Expected VT, but got I4
		//IL_09fb: Invalid comparison between VT and I4
		//IL_0560: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_0a86: Expected Obj, but got I4
		//IL_0a24: Expected Obj, but got I
		//IL_0a4e: Expected Obj, but got I4
		//IL_0b52: Expected Obj, but got I
		//IL_0b74: Expected Obj, but got I4
		//IL_0b86: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I
		//IL_0b34: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I4
		//IL_07a9: Expected Obj, but got I4
		//IL_0471: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		//IL_0209: Expected VT, but got I4
		//IL_0225: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I4
		//IL_0232: Expected I, but got Obj
		//IL_04ab: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I4
		//IL_04f9: Expected VT, but got I4
		//IL_0501: Expected I, but got Obj
		//IL_0509: Expected I4, but got Obj
		//IL_061b: Expected Obj, but got I4
		//IL_07c1: Expected I4, but got Obj
		//IL_07de: Expected Obj, but got I
		//IL_07f1: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_0261: Expected I, but got Obj
		//IL_052f: Expected VT, but got I
		//IL_0541: Expected I, but got Obj
		//IL_054b: Expected I4, but got Obj
		//IL_0642: Expected Obj, but got I
		//IL_065a: Expected Obj, but got I
		//IL_066a: Expected Obj, but got I
		//IL_0abf: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I
		//IL_0757: Expected VT, but got I4
		//IL_0760: Expected Obj, but got I4
		//IL_06df: Expected Obj, but got I
		//IL_06ff: Expected Obj, but got I4
		//IL_0704: Expected I, but got Obj
		//IL_070c: Expected I4, but got Obj
		//IL_0732: Expected VT, but got I
		//IL_0744: Expected I, but got Obj
		ShutdownReason shutdownReason2;
		object obj;
		if (shutdownReason != 0)
		{
			NetworkRunner runner = _runner;
			bool flag = (object)_runner == null;
			obj = 0;
			shutdownReason2 = shutdownReason;
			if (!flag)
			{
				if (shutdownReason != (ShutdownReason)4)
				{
					bool flag2 = runner.StartGameOperation == null;
					object obj2 = !flag2;
					if (obj2 == null)
					{
						bool isServer = _runner.IsServer;
						bool flag3 = !isServer;
						shutdownReason2 = (ShutdownReason)0;
						if (!flag3)
						{
							goto IL_00be;
						}
						bool flag4 = (object)_runner == null;
						obj = 0;
						shutdownReason2 = (ShutdownReason)0;
						if (flag4)
						{
							goto IL_082a;
						}
						if (_runner.IsClient)
						{
							bool flag5 = (object)_runner == null;
							obj = 0;
							shutdownReason2 = (ShutdownReason)0;
							if (flag5)
							{
								goto IL_082a;
							}
							ConnectionType currentConnectionType = _runner.CurrentConnectionType;
							bool flag6 = currentConnectionType == (ConnectionType)2;
							shutdownReason2 = (ShutdownReason)0;
							if (flag6)
							{
								goto IL_00be;
							}
						}
					}
				}
				goto IL_039f;
			}
		}
		else
		{
			CloudServicesMetadata metadata = _metadata;
			bool flag7 = _metadata == null;
			obj = 0;
			shutdownReason2 = shutdownReason;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v18 (Fusion.CloudServicesMetadata)+1E9]");
				if ((nint)0 != 0)
				{
					return true;
				}
				goto IL_039f;
			}
		}
		goto IL_082a;
		IL_039f:
		return false;
		IL_0838:
		NullReferenceException ex = new NullReferenceException();
		bool flag8 = shutdownReason2 != (ShutdownReason)1;
		NullReferenceException ex2 = ex;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj4 = default;
			object obj3 = obj4;
			shutdownReason2 = (ShutdownReason)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj6 = default;
			object obj5 = obj6 & 1;
			nint num;
			if (obj5 != null)
			{
				object obj8 = default;
				object obj7 = (object)(&obj8);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v24+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v13+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v13+20]");
				if ((nint)0 != 0)
				{
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v15+1E0]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v519 @ X8_v15+1D8] (should have been resolved before IL gen)");
					shutdownReason2 = (ShutdownReason)obj4;
				}
				goto IL_0ad6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj12 = obj4;
			shutdownReason2 = (ShutdownReason)101790920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num = unchecked((nint)null);
			NullReferenceException ex3 = default;
			ex2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_0ad6:
		CloudServicesMetadata metadata2 = _metadata;
		if (_metadata != null)
		{
			bool flag9 = metadata2.RejoinMetadata == (RejoinMetadata)(object)0;
			return !flag9;
		}
		goto IL_082a;
		IL_082a:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0838;
		IL_0a14:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v43+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v43+A0]");
		object obj16 = 0;
		object obj17 = obj16;
		bool flag11 = obj16 == null;
		obj = 0;
		if (!flag11)
		{
			CloudServicesMetadata metadata3 = _metadata;
			bool flag12 = _metadata == null;
			obj = 0;
			if (flag12)
			{
				goto IL_0838;
			}
			shutdownReason2 = (ShutdownReason)_runner;
			RejoinMetadata rejoinMetadata = metadata3.RejoinMetadata;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v28+18]");
			metadata3 = (CloudServicesMetadata)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ X8_v28+18] (should have been resolved before IL gen)");
			obj = 0;
			nint num = (nint)shutdownReason;
		}
		goto IL_0ad6;
		IL_09ed:
		CloudServicesMetadata metadata4;
		if (metadata4.RejoinMetadata != (RejoinMetadata)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X21_v9 (Fusion.CloudServicesMetadata)+1EC]");
			object obj19 = -1;
			CloudServicesMetadata metadata3 = (CloudServicesMetadata)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X9_v11 (Fusion.CloudServicesMetadata)+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v50+E0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v50+E0]");
			if ((nint)0 != 0)
			{
				bool flag13 = _metadata == null;
				obj = 0;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					metadata3 = (CloudServicesMetadata)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FA8]");
					object format = 0;
					object obj23 = default;
					object obj24 = default;
					string text = string.Format((string)format, obj23, obj24);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X23_v1+10]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X23_v1+10]");
					bool flag14 = (nint)0 == 0;
					obj = 0;
					RejoinMetadata rejoinMetadata = (RejoinMetadata)0;
					nint num = (nint)obj24;
					shutdownReason2 = (ShutdownReason)obj23;
					if (!flag14)
					{
						metadata3 = (CloudServicesMetadata)obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X9_v11 (Fusion.CloudServicesMetadata)+190]");
						rejoinMetadata = (RejoinMetadata)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X9_v11 (Fusion.CloudServicesMetadata)+188] (should have been resolved before IL gen)");
						num = (nint)text;
						shutdownReason2 = (ShutdownReason)_runner;
						goto IL_0a14;
					}
				}
				goto IL_082a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj26 = 0;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v48+E4]");
			bool flag15 = (nint)0 == 0;
			object obj28 = !flag15;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj29 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v52+E4]");
			bool flag16 = (nint)0 == 0;
			object obj30 = !flag16;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj29 = obj26;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v52+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v33+8]");
			bool flag17 = (nint)0 < (nint)2;
			object obj32 = !flag17;
			object obj33 = ~obj32;
			object obj34 = 109895680;
			if (obj33 == null)
			{
				bool flag18 = (object)_runner == null;
				obj = 0;
				obj34 = 109895680;
				if (flag18)
				{
					goto IL_082a;
				}
				bool isServer2 = _runner.IsServer;
				bool flag19 = !isServer2;
				obj34 = 109895680;
				shutdownReason2 = (ShutdownReason)0;
				if (!flag19)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj35 = 0;
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v37+A0]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v38+E0]");
					obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v38+E0]");
					CloudServicesMetadata metadata3;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4FA0]");
						object format2 = 0;
						object obj39 = default;
						string text2 = string.Format((string)format2, obj39);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X22_v6 (System.Object)+10]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X22_v6 (System.Object)+10]");
						bool flag20 = (nint)0 == 0;
						obj = 0;
						nint num = unchecked((nint)null);
						shutdownReason2 = (ShutdownReason)obj39;
						if (flag20)
						{
							goto IL_082a;
						}
						metadata3 = (CloudServicesMetadata)obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X9_v11 (Fusion.CloudServicesMetadata)+190]");
						RejoinMetadata rejoinMetadata = (RejoinMetadata)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X9_v11 (Fusion.CloudServicesMetadata)+188] (should have been resolved before IL gen)");
						num = (nint)text2;
					}
					TriggerMoveSessionToNewRoom();
					CloudServicesMetadata metadata5 = _metadata;
					bool flag21 = _metadata == null;
					obj = 0;
					shutdownReason2 = (ShutdownReason)0;
					if (flag21)
					{
						goto IL_082a;
					}
					metadata5.RejoinMetadata = (RejoinMetadata)1;
					metadata3 = (CloudServicesMetadata)1;
					shutdownReason2 = (ShutdownReason)0;
				}
			}
		}
		goto IL_0a14;
		IL_00be:
		NetworkRunner runner2 = _runner;
		bool flag22 = (object)_runner == null;
		obj = 0;
		if (!flag22)
		{
			if (runner2.GameMode__BackingField < (GameMode)3)
			{
				goto IL_039f;
			}
			metadata4 = _metadata;
			bool flag23 = _metadata == null;
			obj = 0;
			if (!flag23)
			{
				if (shutdownReason == (ShutdownReason)14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X21_v9 (Fusion.CloudServicesMetadata)+1EC]");
					if ((nint)0 > (nint)0)
					{
						CloudCommunicator communicator = _communicator;
						bool flag24 = (object)_communicator == null;
						obj = 0;
						if (!flag24)
						{
							bool flag25 = communicator.Client__BackingField == null;
							obj = 0;
							if (!flag25)
							{
								bool flag26 = communicator.Client__BackingField.ReconnectAndRejoin();
								metadata4.RejoinMetadata = (RejoinMetadata)flag26;
								bool flag27 = _metadata == null;
								object obj41 = !flag27;
								CloudServicesMetadata metadata3 = (CloudServicesMetadata)flag26;
								nint num = unchecked((nint)null);
								shutdownReason2 = (ShutdownReason)0;
								metadata4 = _metadata;
								if (obj41 != null)
								{
									goto IL_09ed;
								}
								obj = 0;
								num = unchecked((nint)null);
								shutdownReason2 = (ShutdownReason)0;
							}
						}
						goto IL_082a;
					}
				}
				metadata4.RejoinMetadata = (RejoinMetadata)0;
				goto IL_09ed;
			}
		}
		goto IL_082a;
	}

	internal void TriggerMoveSessionToNewRoom(string sessionId = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got I
		//IL_0571: Expected Obj, but got I
		//IL_0581: Expected Obj, but got I
		//IL_0592: Expected Obj, but got I
		//IL_05a1: Expected Obj, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected I4, but got Unknown
		//IL_05dc: Expected I, but got Obj
		//IL_05fb: Expected Obj, but got I4
		//IL_0603: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I4
		//IL_0629: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_01eb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I4
		//IL_0760: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I4
		//IL_0270: Expected I, but got Obj
		//IL_02c6: Expected Obj, but got I4
		//IL_02ce: Expected I, but got Obj
		//IL_030b: Expected Obj, but got I4
		//IL_0313: Expected I, but got Obj
		//IL_047e: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_034b: Expected I, but got Obj
		//IL_054c: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I4
		//IL_041f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		string text = null;
		string text4;
		object obj4;
		object obj8;
		nint num;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj4 = obj2 + 24;
			obj4 = sessionId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (!string.IsNullOrEmpty((string)obj4))
			{
				goto IL_0551;
			}
			bool flag2 = (object)_runner == null;
			text = null;
			if (!flag2)
			{
				bool isClient = _runner.IsClient;
				bool flag3 = !isClient;
				object obj5 = !flag3;
				text = null;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					ArgumentException ex = default;
					string message = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					throw new ArgumentNullException();
				}
				bool flag4 = (object)_runner == null;
				text = null;
				if (!flag4)
				{
					if (!_runner.IsServer)
					{
						goto IL_0551;
					}
					Guid guid = Guid.NewGuid();
					Guid guid2 = default;
					string text2 = guid2.ToString();
					bool flag5 = text2 == null;
					text = null;
					if (!flag5)
					{
						string text3 = text2.Substring(0, 6);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53B8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
						object obj7 = 0;
						text4 = (string)obj6 + text3 + (string)obj7;
						CloudServicesMetadata metadata = _metadata;
						bool flag6 = _metadata == null;
						obj8 = 0;
						num = (nint)obj7;
						text = text3;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11 (Fusion.CloudServicesMetadata)+208]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11 (Fusion.CloudServicesMetadata)+208]");
							string text7;
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v12+28]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X8_v12+18] (should have been resolved before IL gen)");
								string text5 = default;
								bool flag7 = text5 == null;
								obj8 = 0;
								num = (nint)obj7;
								if (flag7)
								{
									goto IL_0696;
								}
								string text6 = text5.Trim();
								text7 = text6;
							}
							else
							{
								text7 = null;
							}
							obj4 = text7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag8 = string.IsNullOrEmpty((string)obj4);
							bool flag9 = !flag8;
							obj8 = 0;
							num = (nint)obj7;
							text = null;
							if (flag9)
							{
								goto IL_042c;
							}
							NetworkRunner runner = _runner;
							bool flag10 = (object)_runner == null;
							obj8 = 0;
							num = (nint)obj7;
							text = null;
							if (!flag10)
							{
								SessionInfo sessionInfo = runner.SessionInfo__BackingField;
								bool flag11 = runner.SessionInfo__BackingField == null;
								obj8 = 0;
								num = (nint)obj7;
								text = null;
								if (!flag11)
								{
									bool flag12 = sessionInfo.Name__BackingField == null;
									obj8 = 0;
									num = (nint)obj7;
									text = null;
									if (!flag12)
									{
										string input = sessionInfo.Name__BackingField.Trim();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C70]");
										object obj10 = 0;
										object obj11 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v22+E4]");
										bool flag13 = (nint)0 == 0;
										object obj12 = !flag13;
										if (obj12 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53C0]");
										object pattern = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										object obj13 = 0;
										string text8 = Regex.Replace(input, (string)pattern, (string)obj13);
										obj4 = text8;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										obj8 = 0;
										num = (nint)obj13;
										text = text8;
										goto IL_042c;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0696;
		IL_042c:
		string text9 = (string)obj4;
		if (obj4 != null && text4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v57+E4]");
			bool flag14 = (nint)0 == 0;
			object obj16 = !flag14;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int val = 200 - text4._stringLength;
			int length = Math.Min(text9._stringLength, val);
			string text10 = ((string)obj4).Substring(0, length);
			obj4 = text10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string text11 = (string)obj4 + text4;
			obj4 = text11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj8 = 0;
			goto IL_0551;
		}
		goto IL_0696;
		IL_0551:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53B0]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5390]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		bool flag15 = string.IsNullOrEmpty((string)0);
		object obj19 = !flag15;
		bool condition = (byte)(1 & obj19) != 0;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<CancellationToken, System.__Canon> func = default;
		func._002Ector(obj2, (IntPtr)obj18);
		bool flag16 = (object)_runner == null;
		obj8 = 0;
		num = (nint)obj18;
		text = (string)obj2;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
			object obj20 = 0;
			CancellationToken operationsCancellationToken = _runner.OperationsCancellationToken;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v7+E4]");
			bool flag17 = (nint)0 == 0;
			object obj22 = !flag17;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Task task = TaskManager.Run((Func<CancellationToken, Task>)(object)func, operationsCancellationToken, (TaskCreationOptions)0);
			return;
		}
		goto IL_0696;
		IL_0696:
		throw new NullReferenceException();
	}

	private unsafe Task MoveSessionToNewRoom(CancellationToken token, string sessionId)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got VT
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected VT, but got Unknown
		//IL_0149: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53E0]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 64;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 48;
			obj9 = token;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj3 + 56;
			obj10 = sessionId;
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

	private AsyncConfig BuildAsyncConfig(CancellationToken externalCancellationToken = default(CancellationToken))
	{
		//IL_0010: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_015d: Expected VT, but got Obj
		//IL_0193: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D51B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncConfig asyncConfig = AsyncConfig.CreateUnityAsyncConfig();
		if (asyncConfig != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
			object obj4 = 0;
			asyncConfig.OperationTimeoutSec__BackingField = 45f;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CancellationToken none = CancellationToken.None;
			if (externalCancellationToken != none)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7050]");
				object obj7 = 0;
				object obj8 = asyncConfig + 40;
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v16+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource((CancellationToken)obj8, externalCancellationToken);
				if (cancellationTokenSource == null)
				{
					goto IL_01a7;
				}
				CancellationToken token = cancellationTokenSource.Token;
				obj8 = token;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			return asyncConfig;
		}
		goto IL_01a7;
		IL_01a7:
		return (AsyncConfig)(object)new NullReferenceException();
	}

	public bool IsPlayerCommitted(PlayerRef player)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected VT, but got Unknown
		if (IsInRoom)
		{
			CloudCommunicator communicator = _communicator;
			if ((object)_communicator != null)
			{
				RealtimeClient realtimeClient = communicator.Client__BackingField;
				if (communicator.Client__BackingField != null)
				{
					Room room = realtimeClient.CurrentRoom__BackingField;
					if (realtimeClient.CurrentRoom__BackingField != null && room.players != null)
					{
						PlayerRef playerRef = (PlayerRef)(player & 0xFFFFFFFFL);
						return IsPlayerCommitted(realtimeClient.CurrentRoom__BackingField, playerRef);
					}
				}
			}
		}
		return false;
	}

	private bool IsPlayerCommitted(Room room, PlayerRef playerRef)
	{
		//IL_00d0: Expected I4, but got Obj
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		if ((object)_runner != null)
		{
			PlayerRef player = (PlayerRef)(playerRef & 0xFFFFFFFFL);
			int? playerActorId = _runner.GetPlayerActorId(player);
			object obj = (_003F?)playerActorId & 0xFF;
			if (obj != null)
			{
				int? num = default;
				int value = num.Value;
				if (room == null)
				{
					goto IL_00c2;
				}
				((object)room).Finalize();
				object obj2 = default;
				if (obj2 != null)
				{
					return true;
				}
			}
			return false;
		}
		goto IL_00c2;
		IL_00c2:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe Task _003CHandleReflexiveInfoMessage_003Eb__98_0(CancellationToken token)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got VT
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got Unknown
		//IL_0129: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5400]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 56;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 48;
			obj9 = token;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj3 + 24;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35014A8");
			object obj11 = default;
			if (obj11 != null)
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj11 + 24);
				return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Task;
			}
		}
		return (Task)(object)new NullReferenceException();
	}

	private Task<bool> _003CSetupDummyTraffic_003Eb__109_0()
	{
		//IL_0015: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I
		if ((object)_runner != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D43F0]");
			object obj = 0;
			if (_runner.IsRunning)
			{
				if ((object)_runner == null)
				{
					goto IL_0139;
				}
				Topologies topology = _runner.Topology;
				if (topology != (Topologies)1)
				{
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v17+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v17+A0]");
					return (Task<bool>)((nint)0 + (nint)16);
				}
			}
			_003CSetupDummyTraffic_003Eg__SendDummyTraffic_007C109_1(_dummyData);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v11+A0]");
			return (Task<bool>)((nint)0 + (nint)8);
		}
		goto IL_0139;
		IL_0139:
		return (Task<bool>)(object)new NullReferenceException();
	}

	private void _003CSetupDummyTraffic_003Eg__SendDummyTraffic_007C109_1(byte[] buffer)
	{
		//IL_00e0: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00fd: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		if (!_runner.IsRunning)
		{
			return;
		}
		CloudCommunicator communicator = _communicator;
		if (!communicator.Client__BackingField.IsConnectedAndReady)
		{
			return;
		}
		if (buffer != null)
		{
			object obj = buffer + 32;
			if (buffer.Length == 0)
			{
				object obj2 = 0;
			}
			else
			{
				object obj2 = obj;
			}
		}
		else
		{
			object obj2 = 0;
		}
		CloudCommunicator communicator2 = _communicator;
		((NetworkBehaviour)(object)_communicator).PreRender();
		nint num = (nint)communicator2;
		((NetworkBehaviour)(object)_communicator).Spawned();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+78]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+78]");
		if ((nint)0 != 0)
		{
			((NetworkBehaviour)(object)_communicator).PreRender();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5408]");
			object format = 0;
			object arg = default;
			object arg2 = default;
			string text = string.Format((string)format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X20_v5+10]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ X9_v7+198] (should have been resolved before IL gen)");
		}
	}

	private bool _003CQueryReflexiveInfo_003Eg__KeepRunning_007C110_0()
	{
		//IL_005a: Expected I4, but got Obj
		//IL_0039: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		if ((object)_runner != null)
		{
			bool isShutdown = _runner.IsShutdown;
			object obj = !isShutdown;
			return (byte)(1 & obj) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe bool _003CQueryReflexiveInfo_003Eg__SendAnyData_007C110_1(byte[] requestBytes, NetAddress target)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I4
		//IL_002d: Expected Ref, but got VT
		//IL_013b: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I, but got Unknown
		//IL_0169: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_0190: Expected I, but got Obj
		//IL_05fb: Expected Obj, but got Ref
		//IL_0604: Expected Obj, but got I4
		//IL_0614: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0527: Expected Obj, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_0473: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got Ref
		//IL_0493: Expected Obj, but got I4
		//IL_04a0: Expected Obj, but got Ref
		//IL_04ba: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5220]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetAddress netAddress = default;
		bool result;
		object obj11;
		object obj10;
		NullReferenceException ex2;
		if (((NetAddress*)netAddress)->IsValid)
		{
			NetworkRunner runner = _runner;
			if ((object)_runner != null)
			{
				Simulation simulation = runner._simulation;
				if ((object)runner._simulation != null)
				{
					NetPeer* netPeer = simulation._netPeer;
					bool flag2 = simulation._netPeer == null;
					result = false;
					if (!flag2)
					{
						INetSocket netSocket = simulation._netSocket;
						bool flag3 = simulation._netSocket == null;
						result = false;
						if (!flag3)
						{
							if (requestBytes != null)
							{
								nint num = (nint)netSocket;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5410]");
								object obj4 = 0;
								nint num2 = (nint)(requestBytes + 32);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v27 (Il2CppClass<Fusion.Sockets.INetSocket>)+12E]");
								object obj5 = 0;
								if (requestBytes.Length == 0)
								{
									nint num3 = unchecked((nint)null);
								}
								else
								{
									nint num3 = num2;
								}
								if (obj5 == null)
								{
									goto IL_01f9;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v27 (Il2CppClass<Fusion.Sockets.INetSocket>)+98]");
								object obj6 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X9_v15-8]");
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
									goto IL_01f9;
								}
								object obj7 = obj6 + 7;
								object obj8 = num + obj7;
								object obj9 = obj8 + 312;
								goto IL_05e9;
							}
							NullReferenceException ex = new NullReferenceException();
							obj10 = 0;
							obj11 = 0;
							ex2 = ex;
							goto IL_0619;
						}
					}
					goto IL_05a3;
				}
			}
		}
		result = false;
		goto IL_05a3;
		IL_05e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v419 @ X0_v48] (should have been resolved before IL gen)");
		object obj13 = default;
		object obj12 = (object)(&obj13);
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X9_v2 (Fusion.Sockets.NetPeer*)+128]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = new OutOfMemoryException();
		obj11 = obj10;
		ex2 = (NullReferenceException)(object)ex3;
		goto IL_0619;
		IL_05a3:
		return result;
		IL_0619:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A36C4");
		if ((nint)obj11 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj15 = default;
			object obj14 = obj15;
			object obj16 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj18 = default;
			object obj17 = obj18 & 1;
			if (obj17 != null)
			{
				object obj19 = 0;
				object obj21 = default;
				object obj20 = (object)(&obj21);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj22 = 0;
				object obj23 = (object)(&obj21);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v30+A0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v17+20]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v17+20]");
				if ((nint)0 != 0)
				{
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v528 @ X8_v19+1D8] (should have been resolved before IL gen)");
				}
				result = false;
				goto IL_05a3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj27 = obj15;
			obj10 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex4 = default;
			ex2 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result2 = default;
		return result2;
		IL_01f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_05e9;
	}

	private unsafe Task _003CMoveSessionToNewRoom_003Eg__WaitRejoin_007C117_0(CancellationToken cancellationToken)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got VT
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got Unknown
		//IL_0129: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5418]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5420]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 56;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 48;
			obj9 = cancellationToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj3 + 24;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35014A8");
			object obj11 = default;
			if (obj11 != null)
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj11 + 24);
				return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Task;
			}
		}
		return (Task)(object)new NullReferenceException();
	}

	private unsafe Task _003CMoveSessionToNewRoom_003Eg__RejoinSession_007C117_1(GameMode gameMode, CancellationToken cancellationToken, string targetSession)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got VT
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected VT, but got Unknown
		//IL_014e: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5428]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5430]");
			object obj6 = 0;
			object obj7 = obj3 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3 + 72;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj3 + 56;
			obj9 = cancellationToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj3 + 64;
			obj10 = targetSession;
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
}
