using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkRunnerDebugRpcEvent
{
	public readonly NetworkRunnerDebugRpcEventType EventType;

	public readonly Tick Tick;

	public readonly NetworkRunner Runner;

	public readonly NetworkBehaviour Behaviour;

	public readonly MethodBase MethodBase;

	public readonly int SentBytes;

	public readonly PlayerRef SourcePlayer;

	public readonly PlayerRef? TargetPlayer;

	public readonly RpcInvokeInfo? LocalInvokeInfo;

	internal NetworkRunnerDebugRpcEvent(NetworkRunner runner, NetworkBehaviour behaviour, Tick tick, MethodBase methodBase, int sentBytes, PlayerRef sourcePlayer, PlayerRef? targetPlayer, RpcInvokeInfo? localInvokeInfo = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj = (_003F?)localInvokeInfo & 0xFF;
		bool eventType = obj == null;
		Runner = runner;
		Behaviour = behaviour;
		LocalInvokeInfo = localInvokeInfo;
		EventType = (eventType ? ((NetworkRunnerDebugRpcEventType)1) : ((NetworkRunnerDebugRpcEventType)0));
		Tick = tick;
		MethodBase = methodBase;
		SentBytes = sentBytes;
		SourcePlayer = sourcePlayer;
		TargetPlayer = targetPlayer;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I8
		//IL_012d: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_07b2: Expected Obj, but got I8
		//IL_0233: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got I
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_037d: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_041c: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0492: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0506: Invalid comparison between VT and I4
		//IL_0596: Expected Obj, but got I
		//IL_05a7: Expected Obj, but got I4
		//IL_07e3: Expected Obj, but got I8
		//IL_052a: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I4
		//IL_0579: Expected I4, but got VT
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_05e9: Expected Obj, but got Ref
		//IL_0678: Expected Obj, but got I
		//IL_081c: Expected Obj, but got I4
		//IL_082c: Expected Obj, but got I4
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_0616: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I4
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected Obj, but got Unknown
		//IL_06c7: Expected Obj, but got I4
		//IL_06dd: Expected Obj, but got I
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_0720: Expected Obj, but got I
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A98]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string text = string.Format((string)format, arg);
		string[] array = default;
		if (array != null)
		{
			if (array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AD8]");
				object format2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A38]");
				object arg2 = 0;
				object obj4 = array + 32;
				obj4 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object arg3 = default;
				string text2 = string.Format((string)format2, arg2, arg3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X21_v6-8]");
				object obj5 = 0 & 0xFFFFFFFEL;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AE8]");
					object format3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AB8]");
					object arg4 = 0;
					object obj6 = array + 40;
					obj6 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text3 = string.Format((string)format3, arg4, Runner);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X21_v8-10]");
					bool flag = (nint)0 < (nint)2;
					object obj7 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X21_v8-10]");
					object obj8 = -2;
					bool flag2 = obj8 == null;
					object obj9 = ~obj7;
					object obj10 = obj9 | flag2;
					if (obj10 == null)
					{
						object obj11 = array + 48;
						obj11 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						string text5;
						if ((object)Behaviour != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AA8]");
							object arg5 = 0;
							string text4 = string.Format((string)format3, arg5, Behaviour);
							object obj12 = 0;
							text5 = text4;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj13 = 0;
							text5 = (string)obj13;
							object obj12 = 0;
						}
						object obj14 = array.Length & 0xFFFFFFFCL;
						if (obj14 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AC0]");
							object arg6 = 0;
							object obj15 = array + 56;
							obj15 = text5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text6 = string.Format((string)format3, arg6, MethodBase);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X21_v10-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj16 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X21_v10-20]");
							object obj17 = -4;
							bool flag4 = obj17 == null;
							object obj18 = ~obj16;
							object obj19 = obj18 | flag4;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AB0]");
								object arg7 = 0;
								object obj20 = array + 64;
								obj20 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object arg8 = default;
								string text7 = string.Format((string)format3, arg7, arg8);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X21_v12-28]");
								bool flag5 = (nint)0 < (nint)5;
								object obj22 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X21_v12-28]");
								object obj23 = -5;
								bool flag6 = obj23 == null;
								object obj24 = ~obj22;
								object obj25 = obj24 | flag6;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AD0]");
									object arg9 = 0;
									object obj27 = array + 72;
									obj27 = text7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj28 = default;
									string text8 = string.Format((string)format3, arg9, obj28);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X21_v14-30]");
									bool flag7 = (nint)0 < (nint)6;
									object obj29 = !flag7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X21_v14-30]");
									object obj30 = -6;
									bool flag8 = obj30 == null;
									object obj31 = ~obj29;
									object obj32 = obj31 | flag8;
									if (obj32 == null)
									{
										object obj33 = array + 80;
										obj33 = text8;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string text10;
										if ((PlayerRef)TargetPlayer != (PlayerRef)(object)0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8AB0]");
											object obj34 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AE0]");
											object arg10 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj35 = default;
											string text9 = string.Format((string)format3, arg10, obj35);
											object obj36 = 0;
											object obj37 = obj35;
											int num = (int)TargetPlayer;
											text10 = text9;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
											object obj38 = 0;
											text10 = (string)obj38;
											object obj36 = 0;
											object obj37 = obj28;
											int num = SentBytes;
										}
										object obj39 = array.Length & 0xFFFFFFF8L;
										if (obj39 != null)
										{
											object obj40 = array + 88;
											obj40 = text10;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
											string text12;
											if (obj41 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AA0]");
												object obj42 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AC8]");
												object arg11 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												object obj43 = default;
												string text11 = string.Format((string)format3, arg11, obj43);
												object obj36 = 0;
												object obj37 = obj43;
												text12 = text11;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
												object obj44 = 0;
												text12 = (string)obj44;
											}
											bool flag9 = array.Length < 8;
											object obj45 = !flag9;
											object obj46 = array.Length - 8;
											bool flag10 = obj46 == null;
											object obj47 = ~obj45;
											object obj48 = obj47 | flag10;
											if (obj48 == null)
											{
												object obj49 = array + 96;
												obj49 = text12;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X19_v7-48]");
												bool flag11 = (nint)0 < (nint)9;
												object obj50 = !flag11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X19_v7-48]");
												object obj51 = -9;
												bool flag12 = obj51 == null;
												object obj52 = ~obj50;
												object obj53 = obj52 | flag12;
												if (obj53 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
													object obj54 = 0;
													object obj55 = array + 104;
													obj55 = obj54;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													return string.Concat(array);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
	}

	internal unsafe static NetworkRunnerDebugRpcEvent FromLocalCall(object runnerOrBehaviour, MethodBase method, RpcInvokeInfo invokeInfo, RpcHostMode hostMode, PlayerRef target)
	{
		//IL_0131: Invalid comparison between VT and I4
		//IL_011b: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001e: Expected Obj, but got VT
		//IL_0033: Expected I4, but got VT
		//IL_0033: Expected Obj, but got VT
		//IL_004c: Expected Obj, but got I
		//IL_008f: Expected VT, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0081: Expected VT, but got I
		//IL_0108: Expected VT, but got I4
		//IL_00d2: Expected VT, but got I8
		//IL_00e9: Expected VT, but got I4
		//IL_00f2: Expected VT, but got I4
		//IL_019d: Expected Obj, but got VT
		//IL_0198: Expected native int or pointer, but got VT
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_01b2: Expected native int or pointer, but got VT
		//IL_01bf: Expected native int or pointer, but got VT
		//IL_01cc: Expected native int or pointer, but got VT
		//IL_01e0: Expected Obj, but got I4
		//IL_01f7: Expected native int or pointer, but got VT
		//IL_020a: Expected VT, but got I4
		//IL_0205: Expected native int or pointer, but got VT
		//IL_0212: Expected native int or pointer, but got VT
		//IL_021f: Expected native int or pointer, but got VT
		//IL_0229: Expected VT, but got Ref
		(NetworkRunner, NetworkBehaviour) tuple = ResolveRunner(runnerOrBehaviour);
		if (tuple != ((NetworkRunner, NetworkBehaviour))(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			PlayerRef localPlayer = ((NetworkRunner)tuple).LocalPlayer;
			PlayerRef sourcePlayer = RpcInfo.ResolveLocalSourcePlayer(tuple, localPlayer, (RpcHostMode)target);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.ValueTuple`2<Fusion.NetworkRunner, Fusion.NetworkBehaviour>)+58]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.ValueTuple`2<Fusion.NetworkRunner, Fusion.NetworkBehaviour>)+58]");
			Tick tick;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v2+50]");
				tick = (Tick)0;
			}
			else
			{
				tick = (Tick)0;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default;
			RpcInvokeInfo? rpcInvokeInfo;
			RpcInvokeInfo? targetPlayer;
			if ((nint)intPtr >= 1)
			{
				PlayerRef value = (PlayerRef)((nint)intPtr & 0xFFFFFFFFL);
				PlayerRef? playerRef = value;
				rpcInvokeInfo = (RpcInvokeInfo?)(object)0;
				targetPlayer = (RpcInvokeInfo?)(object)0;
			}
			else
			{
				PlayerRef? playerRef = default;
				rpcInvokeInfo = (RpcInvokeInfo?)playerRef;
				targetPlayer = (RpcInvokeInfo?)(object)0;
			}
			rpcInvokeInfo = invokeInfo;
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->Runner, (NetworkRunner)tuple);
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->Behaviour, method);
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->MethodBase, method);
			((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->SentBytes = (int)hostMode;
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->SourcePlayer, sourcePlayer);
			object obj5 = 0 & 0xFF;
			bool eventType = obj5 == null;
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->TargetPlayer, (PlayerRef?)targetPlayer);
			((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->LocalInvokeInfo = (RpcInvokeInfo?)(object)0;
			((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->EventType = (eventType ? ((NetworkRunnerDebugRpcEventType)1) : ((NetworkRunnerDebugRpcEventType)0));
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->Tick, tick);
			return (NetworkRunnerDebugRpcEvent)(&rpcInvokeInfo);
		}
		NullReferenceException ex = new NullReferenceException();
		return (NetworkRunnerDebugRpcEvent)ex;
	}

	internal unsafe static NetworkRunnerDebugRpcEvent FromRemoteCall([In] ref RpcInvokeContext context, MethodBase method, RpcHostMode hostMode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a1: Expected VT, but got I
		//IL_00a1: Expected Obj, but got VT
		//IL_00cf: Expected Obj, but got I4
		//IL_007e: Expected VT, but got I4
		//IL_005f: Expected VT, but got I
		//IL_0067: Expected VT, but got Ref
		//IL_0070: Expected VT, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected VT, but got Unknown
		//IL_0122: Expected Obj, but got VT
		//IL_011d: Expected native int or pointer, but got VT
		//IL_0137: Expected Obj, but got I
		//IL_0132: Expected native int or pointer, but got VT
		//IL_013f: Expected native int or pointer, but got VT
		//IL_014d: Expected native int or pointer, but got VT
		//IL_015a: Expected native int or pointer, but got VT
		//IL_016f: Expected native int or pointer, but got VT
		//IL_017c: Expected native int or pointer, but got VT
		//IL_018f: Expected VT, but got I4
		//IL_018a: Expected native int or pointer, but got VT
		//IL_019d: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		RpcInvokeContext rpcInvokeContext = context;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+14]");
		PlayerRef playerRef = RpcInfo.ResolveRemoteSourcePlayer((NetworkRunner)rpcInvokeContext, (PlayerRef)0, hostMode);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		PlayerRef result = playerRef;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+18]");
		PlayerRef? targetPlayer;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+18]");
			PlayerRef? playerRef2 = (PlayerRef)0;
			result = (PlayerRef)(&playerRef2);
			targetPlayer = (PlayerRef?)(object)0;
		}
		else
		{
			targetPlayer = (PlayerRef?)(object)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+10]");
		object obj4 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+10]");
		Tick tick = (Tick)(0 & obj4);
		NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = default;
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->Runner, (NetworkRunner)context);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->Behaviour, (NetworkBehaviour)0);
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->MethodBase, method);
		((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->EventType = (NetworkRunnerDebugRpcEventType)1;
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->Tick, tick);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+28]");
		((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->SentBytes = 0;
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->SourcePlayer, playerRef);
		((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->LocalInvokeInfo = (RpcInvokeInfo?)(object)0;
		_ = 0;
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerDebugRpcEvent*)(nint)networkRunnerDebugRpcEvent)->TargetPlayer, targetPlayer);
		return (NetworkRunnerDebugRpcEvent)result;
	}

	private unsafe static (NetworkRunner, NetworkBehaviour) ResolveRunner(object runnerOrBehaviour)
	{
		//IL_0140: Expected VT, but got Ref
		//IL_0151: Expected native int or pointer, but got VT
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00ff: Expected VT, but got I4
		//IL_0107: Expected VT, but got Ref
		System.__Canon item;
		System.__Canon item2;
		(NetworkRunner, NetworkBehaviour) result = default;
		(System.__Canon, System.__Canon) tuple;
		if (runnerOrBehaviour != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D60D8]");
			object obj = 0;
			object obj2 = obj;
			nint num = (nint)runnerOrBehaviour;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X9_v6 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v4+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X9_v6 (Il2CppClass<System.Object>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v4+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X11_v6-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [runnerOrBehaviour @ X0 (System.Object)+38]");
					item = (System.__Canon)0;
					item2 = (System.__Canon)runnerOrBehaviour;
					result = ((NetworkRunner, NetworkBehaviour))0;
					tuple = ((System.__Canon, System.__Canon))(&result);
					goto IL_0145;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj6 = 0;
			if (num != (nint)obj6)
			{
				throw new InvalidCastException();
			}
		}
		item2 = null;
		item = (System.__Canon)runnerOrBehaviour;
		tuple = ((System.__Canon, System.__Canon))(&result);
		goto IL_0145;
		IL_0145:
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (item, item2));
		return result;
	}
}
