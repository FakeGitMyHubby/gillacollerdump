using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Photon.Voice.Unity;
using Unity.Profiling.LowLevel.Unsafe;

namespace Fusion;

internal struct RpcBuilder : Action<Speaker>
{
	public readonly Simulation Simulation;

	internal readonly RpcMeta RpcMeta;

	public readonly int PayloadNumBytes;

	private NetworkBehaviour _targetBehaviour;

	private PlayerRef _targetPlayer;

	private int _localAuthorityMask;

	private Fusion.PooledList<SimulationConnection> _connections;

	private SimulationMessage _msg;

	internal unsafe RpcBuilder(Simulation simulation, RpcMeta rpcMeta, int payloadBytes, NetworkBehaviour targetBehaviour, PlayerRef targetPlayer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I4
		//IL_0065: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		_targetBehaviour = null;
		_msg = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef invalid = PlayerRef.Invalid;
		Simulation = simulation;
		_targetPlayer = invalid;
		_localAuthorityMask = 7;
		PayloadNumBytes = payloadBytes;
		RpcMeta = (RpcMeta)rpcMeta.Key;
		_ = rpcMeta.IsTickAligned;
		_ = rpcMeta.Sources;
		if ((object)targetBehaviour != null)
		{
			NetworkObject networkObject = ((SimulationBehaviour)targetBehaviour)._object;
			_targetBehaviour = targetBehaviour;
			int localAuthorityMask = simulation.GetLocalAuthorityMask(ref *(NetworkObjectHeader*)networkObject.Ptr);
			_targetPlayer = targetPlayer;
			_localAuthorityMask = localAuthorityMask;
		}
		else
		{
			_targetPlayer = targetPlayer;
		}
		Fusion.PooledList<SimulationConnection> pooledList = simulation.AcquireSimulationConnectionList(0);
		Fusion.PooledList<SimulationConnection> connections = default;
		_connections = connections;
	}

	public unsafe void Dispose()
	{
		//IL_0250: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_001c: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got Ref
		//IL_00d1: Expected I, but got Obj
		//IL_010c: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got Ref
		//IL_00e8: Expected I, but got Obj
		//IL_00ed: Expected I, but got Obj
		//IL_023a: Expected Obj, but got Ref
		//IL_0134: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X20_v2+258]");
		nint num = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X20_v2+258]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			num = unchecked((nint)null);
		}
		ref Fusion.PooledList<SimulationConnection> reference;
		OutOfMemoryException ex;
		object obj4;
		SimulationMessage simulationMessage;
		if ((object)Simulation != null)
		{
			reference = ref System.Runtime.CompilerServices.Unsafe.As<RpcBuilder, Fusion.PooledList<SimulationConnection>>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 80));
			Simulation.Release(ref reference);
			bool flag = (object)Simulation == null;
			ex = null;
			obj4 = 0;
			object obj5 = 0;
			if (!flag)
			{
				simulationMessage = _msg;
				bool flag2 = Simulation.ReleaseReference(_msg);
				ex = null;
				obj4 = 0;
				obj5 = 0;
				goto IL_00b2;
			}
			goto IL_0194;
		}
		NullReferenceException ex2 = new NullReferenceException();
		ex = null;
		obj4 = 0;
		goto IL_016f;
		IL_00b2:
		object obj7 = default;
		object obj6 = (object)(&obj7);
		bool flag3 = obj6 == null;
		num = (nint)simulationMessage;
		if (!flag3)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj6);
			num = unchecked((nint)null);
		}
		bool flag4 = ex == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_016f;
		}
		bool flag5 = obj4 == null;
		object obj9 = !flag5;
		reference = ref *(Fusion.PooledList<SimulationConnection>*)num;
		OutOfMemoryException ex3 = ex;
		if (obj9 == null)
		{
			return;
		}
		goto IL_0185;
		IL_016f:
		ex3 = new OutOfMemoryException();
		reference = ref *(Fusion.PooledList<SimulationConnection>*)num;
		goto IL_0185;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0194;
		IL_0194:
		NullReferenceException ex4 = new NullReferenceException();
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == (void*)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj4 = 1;
			simulationMessage = (SimulationMessage)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		}
		else
		{
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj10 = default;
			ex = (OutOfMemoryException)obj10;
			simulationMessage = (SimulationMessage)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		}
		goto IL_00b2;
	}

	public unsafe RpcInvokeInfo Prepare(out RpcDataWriter writer)
	{
		//IL_015c: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_01be: Expected VT, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got Ref
		//IL_0051: Expected Obj, but got I4
		//IL_002d: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_0142: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X21_v2+268]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X21_v2+268]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
		}
		RpcLocalInvokeResult rpcLocalInvokeResult = CheckLocalInvoke();
		RpcSendMessageResult rpcSendMessageResult = CheckSend(out writer);
		RpcInvokeInfo result = (RpcInvokeInfo)((int)rpcLocalInvokeResult | (int)rpcSendMessageResult);
		OutOfMemoryException ex = null;
		object obj4 = 0;
		ref RpcDataWriter reference = ref writer;
		object obj6 = default;
		object obj9 = default;
		while (true)
		{
			object obj5 = (object)(&obj6);
			if (obj5 != null)
			{
				ProfilerUnsafeUtility.EndSample((IntPtr)obj5);
				reference = ref *(RpcDataWriter*)null;
			}
			bool flag = ex == null;
			object obj7 = !flag;
			if (obj7 == null)
			{
				bool flag2 = obj4 == null;
				object obj8 = !flag2;
				OutOfMemoryException ex2 = ex;
				if (obj8 == null)
				{
					return result;
				}
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == (void*)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj4 = 1;
			}
			else
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (OutOfMemoryException)obj9;
			}
			result = (RpcInvokeInfo)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		RpcInvokeInfo result2 = default;
		return result2;
	}

	private unsafe RpcLocalInvokeResult CheckLocalInvoke()
	{
		//IL_02d6: Expected I4, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I4
		//IL_0149: Expected VT, but got Ref
		//IL_0152: Expected Ref, but got VT
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+30]");
		if ((nint)0 == 2)
		{
			return (RpcLocalInvokeResult)1;
		}
		Simulation simulation = Simulation;
		if ((object)Simulation != null)
		{
			if (simulation._stage == (SimulationStages)4)
			{
				return (RpcLocalInvokeResult)2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+2C]");
			if ((nint)0 == 2 || PayloadNumBytes <= 512)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+18]");
				if ((int)((nint)0 & (nint)_localAuthorityMask) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v6+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef playerRef = (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
					if (((PlayerRef*)playerRef)->IsValid)
					{
						if ((object)Simulation == null)
						{
							goto IL_02c8;
						}
						if (!Simulation.IsLocalPlayer(_targetPlayer))
						{
							return (RpcLocalInvokeResult)5;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+1C]");
					if ((int)((nint)0 & (nint)_localAuthorityMask) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+30]");
						if ((nint)0 == 1)
						{
							if ((object)Simulation == null)
							{
								goto IL_02c8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310ACC8");
							object obj5 = default;
							object obj4 = obj5 & 1;
							if (obj4 != null)
							{
								return (RpcLocalInvokeResult)7;
							}
						}
						return (RpcLocalInvokeResult)0;
					}
					return (RpcLocalInvokeResult)4;
				}
				return (RpcLocalInvokeResult)3;
			}
			return (RpcLocalInvokeResult)6;
		}
		goto IL_02c8;
		IL_02c8:
		NullReferenceException ex = new NullReferenceException();
		return (RpcLocalInvokeResult)ex;
	}

	private unsafe RpcSendMessageResult CheckSend(out RpcDataWriter writer)
	{
		//IL_06de: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_0112: Expected VT, but got Ref
		//IL_011b: Expected Ref, but got VT
		//IL_01a2: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I
		//IL_075a: Expected Obj, but got I
		//IL_0762: Expected I, but got Obj
		//IL_0793: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_07d4: Expected Obj, but got I4
		//IL_0640: Expected Obj, but got I4
		//IL_03e0: Expected VT, but got Ref
		//IL_03e9: Expected Ref, but got VT
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0398: Expected Obj, but got I
		//IL_07ed: Expected Obj, but got Ref
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_058a: Expected Obj, but got I
		_ = 0;
		_ = 0;
		ref RpcDataWriter reference = ref *(RpcDataWriter*)null;
		Simulation simulation = Simulation;
		object obj;
		NetworkObjectMeta networkObjectMeta;
		object obj14;
		ref Fusion.PooledList<SimulationConnection> reference2;
		if ((object)Simulation != null)
		{
			if (simulation._stage == (SimulationStages)4)
			{
				return (RpcSendMessageResult)521;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+2C]");
			if ((nint)0 != 2 && PayloadNumBytes > 512)
			{
				return (RpcSendMessageResult)522;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+18]");
			if ((int)((nint)0 & (nint)_localAuthorityMask) == 0)
			{
				return (RpcSendMessageResult)523;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
			object obj4;
			if (((PlayerRef*)playerRef)->IsValid)
			{
				if ((object)Simulation == null)
				{
					goto IL_06d0;
				}
				bool flag2 = Simulation.IsLocalPlayer(_targetPlayer);
				obj4 = flag2;
			}
			else
			{
				obj4 = 0;
			}
			Simulation simulation2 = Simulation;
			if ((object)Simulation != null && simulation2._connections != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89D8]");
				object obj5 = 0;
				if (((Dictionary<int, System.__Canon>)(object)simulation2._connections).Count == 0)
				{
					goto IL_03ae;
				}
				Simulation simulation3 = Simulation;
				if ((object)Simulation != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
					object obj6 = 0;
					nint num = (nint)simulation3;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X9_v5 (Il2CppClass<Fusion.Simulation>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v19+130]");
					bool flag3 = num2 < 0;
					object obj8 = !flag3;
					object obj9 = ~obj8;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X9_v5 (Il2CppClass<Fusion.Simulation>)+B0]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v19+130]");
						object obj10 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v12-8]");
						if (0 == (nint)obj7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+30]");
							if ((nint)0 != 1)
							{
								bool flag4 = obj4 == null;
								object obj11 = !flag4;
								if (obj11 != null)
								{
									goto IL_0294;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+1C]");
								if ((nint)0 == 1 && _localAuthorityMask == 1)
								{
									goto IL_0698;
								}
							}
							if ((object)Simulation == null)
							{
								goto IL_06d0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AD48");
							object obj13 = default;
							object obj12 = obj13 & 1;
							if (obj12 == null)
							{
								goto IL_03ae;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89E0]");
							obj14 = 0;
							int num4 = 0;
							ref Fusion.PooledList<SimulationConnection> reference3 = default;
							reference2 = ref reference3;
							goto IL_07e2;
						}
					}
					if (obj4 != null)
					{
						goto IL_0294;
					}
					NetworkBehaviour targetBehaviour = _targetBehaviour;
					if ((object)_targetBehaviour != null)
					{
						NetworkObject networkObject = ((SimulationBehaviour)targetBehaviour)._object;
						if ((object)((SimulationBehaviour)targetBehaviour)._object != null)
						{
							networkObjectMeta = networkObject.Meta;
							goto IL_07aa;
						}
					}
					networkObjectMeta = null;
					goto IL_07aa;
				}
			}
		}
		goto IL_06d0;
		IL_0601:
		RpcDataWriter rpcDataWriter = CreateReaderWriter();
		object obj15 = default;
		reference = ref *(RpcDataWriter*)obj15;
		return (RpcSendMessageResult)0;
		IL_0294:
		return (RpcSendMessageResult)524;
		IL_057a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89E0]");
		obj14 = 0;
		SimulationConnection simulationConnection = default;
		reference2 = ref *(Fusion.PooledList<SimulationConnection>*)simulationConnection;
		goto IL_07e2;
		IL_0698:
		return (RpcSendMessageResult)527;
		IL_06d0:
		NullReferenceException ex = new NullReferenceException();
		return (RpcSendMessageResult)ex;
		IL_03ae:
		return (RpcSendMessageResult)525;
		IL_07e2:
		object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 80));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310B07C");
		goto IL_0601;
		IL_07aa:
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef2 = (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
		if (((PlayerRef*)playerRef2)->IsValid)
		{
			if ((object)Simulation != null)
			{
				PlayerRef realPlayer = Simulation.GetRealPlayer(_targetPlayer);
				if ((object)Simulation != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310ADB0");
					object obj20 = default;
					object obj19 = obj20 & 1;
					if (obj19 == null)
					{
						return (RpcSendMessageResult)518;
					}
					bool flag6 = networkObjectMeta == null;
					int num4 = 0;
					if (flag6)
					{
						goto IL_057a;
					}
					if ((object)Simulation != null)
					{
						if (!Simulation.HasObjectInterest(simulationConnection, networkObjectMeta))
						{
							return (RpcSendMessageResult)517;
						}
						if ((object)Simulation != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+1C]");
							num4 = 0;
							Simulation simulation4 = Simulation;
							NetworkObjectMeta obj21 = networkObjectMeta;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+1C]");
							if (simulation4.HasObjectAuthority(simulationConnection, obj21, 0))
							{
								goto IL_057a;
							}
							return (RpcSendMessageResult)526;
						}
					}
				}
			}
		}
		else if ((object)Simulation != null)
		{
			reference2 = ref System.Runtime.CompilerServices.Unsafe.As<RpcBuilder, Fusion.PooledList<SimulationConnection>>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 80));
			Simulation simulation5 = Simulation;
			ref Fusion.PooledList<SimulationConnection> list = ref reference2;
			NetworkObjectMeta targetObject = networkObjectMeta;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+1C]");
			if (simulation5.GetSimulationConnections(ref list, targetObject, 0) != 0)
			{
				goto IL_0601;
			}
			goto IL_0698;
		}
		goto IL_06d0;
	}

	public unsafe int Send()
	{
		//IL_0844: Expected Obj, but got I
		//IL_085c: Expected VT, but got I
		//IL_001c: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_080f: Expected Obj, but got Ref
		//IL_05fe: Expected I4, but got Obj
		//IL_03af: Expected Obj, but got I4
		//IL_038f: Expected I, but got Obj
		//IL_0394: Expected I, but got Obj
		//IL_0464: Expected Obj, but got I4
		//IL_046d: Expected I, but got Obj
		//IL_00cc: Expected VT, but got I4
		//IL_03df: Expected Obj, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected VT, but got Unknown
		//IL_0349: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got VT
		//IL_0592: Expected I4, but got Obj
		//IL_04a0: Expected Obj, but got I4
		//IL_04a9: Expected I, but got Obj
		//IL_04b1: Expected I4, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_012c: Expected VT, but got I4
		//IL_0773: Expected I, but got Obj
		//IL_069d: Expected I4, but got Obj
		//IL_065c: Expected Obj, but got I4
		//IL_04f6: Expected I4, but got Obj
		//IL_0156: Expected I4, but got Obj
		//IL_0195: Expected I4, but got VT
		//IL_0545: Expected Obj, but got I4
		//IL_054d: Expected I4, but got Obj
		//IL_01c0: Expected VT, but got Ref
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+A0]");
		Span<byte> span = (Span<byte>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X20_v8 (System.Span`1<System.Byte>)+260]");
		nint num = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X20_v8 (System.Span`1<System.Byte>)+260]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			num = unchecked((nint)null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A00]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+2C]");
		Simulation simulation = default;
		bool flag2;
		object obj3;
		object obj5 = default;
		object obj7 = default;
		ref SimulationMessage reference;
		int connectionIndex;
		ReadOnlySpan<byte> readOnlySpan2;
		object obj10 = default;
		bool flag8;
		object obj11;
		object obj12;
		bool payloadNumBytes2;
		ReadOnlySpan<byte> readOnlySpan;
		bool flag4;
		object obj4;
		object obj6;
		if ((nint)0 == 2)
		{
			SimulationMessageHeader simulationMessageHeader = MakeHeader();
			simulation = Simulation;
			bool flag = (object)Simulation == null;
			flag2 = false;
			obj3 = 0;
			obj4 = obj5;
			obj6 = obj7;
			if (flag)
			{
				goto IL_05d5;
			}
			Span<byte> largeRpcWriteBuffer = Simulation.GetLargeRpcWriteBuffer(PayloadNumBytes, clear: false);
			reference = ref *(SimulationMessage*)num2;
			ArgumentNullException ex = new ArgumentNullException();
			bool flag3 = num2 < 1;
			ref SimulationMessage reference2 = ref *(SimulationMessage*)num2;
			readOnlySpan = (ReadOnlySpan<byte>)0;
			flag4 = false;
			obj4 = obj5;
			obj6 = obj7;
			if (flag3)
			{
				goto IL_035f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A20]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A18]");
			object obj9 = 0;
			ArgumentNullException ex2 = ex;
			reference2 = ref *(SimulationMessage*)num2;
			readOnlySpan = (ReadOnlySpan<byte>)0;
			obj4 = obj5;
			obj6 = obj7;
			while (true)
			{
				bool flag5 = ex2 == null;
				bool flag6 = !flag5;
				Assert.Always(flag6, (string)obj8);
				bool flag7 = ex2 == null;
				int payloadNumBytes = PayloadNumBytes;
				flag4 = false;
				num = (nint)obj8;
				flag8 = flag6;
				if (flag7)
				{
					break;
				}
				connectionIndex = ((SimulationConnection)(object)ex2).ConnectionIndex;
				flag4 = (byte)(int)obj9 != 0;
				readOnlySpan2 = largeRpcWriteBuffer;
				bool flag9 = (object)Simulation == null;
				payloadNumBytes = PayloadNumBytes;
				num = PayloadNumBytes;
				flag8 = (byte)(int)readOnlySpan2 != 0;
				if (!flag9)
				{
					Simulation.SendReliableData(connectionIndex, (SimulationMessageHeader)(&obj10), readOnlySpan2, (byte)PayloadNumBytes != 0);
					reference2 = ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference2, 1);
					ex2 = (ArgumentNullException)(ex2 + 8);
					bool flag10 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != (void*)1;
					obj11 = 0;
					obj12 = 0;
					obj10 = obj7;
					payloadNumBytes2 = (byte)PayloadNumBytes != 0;
					readOnlySpan = readOnlySpan2;
					obj4 = obj5;
					obj6 = obj7;
					if (flag10)
					{
						continue;
					}
					goto IL_0238;
				}
				goto IL_04fb;
			}
		}
		else
		{
			reference = ref *(SimulationMessage*)num2;
			ArgumentNullException ex3 = new ArgumentNullException();
			bool flag11 = num2 < 1;
			int num3 = (int)num2;
			obj6 = 0;
			if (flag11)
			{
				goto IL_035f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A20]");
			ref SimulationMessage reference2 = ref *(SimulationMessage*)null;
			int payloadNumBytes = (int)num2;
			ArgumentNullException ex4 = ex3;
			bool flag13;
			while (true)
			{
				bool flag12 = ex4 == null;
				flag13 = !flag12;
				Assert.Always(flag13, (string)(object)reference2);
				if (ex4 == null)
				{
					break;
				}
				reference = ref System.Runtime.CompilerServices.Unsafe.As<RpcBuilder, SimulationMessage>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 112));
				((SimulationConnection)(object)ex4).EnqueueMessage(ref reference);
				num3 = payloadNumBytes - 1;
				span = (Span<byte>)(ex4 + 8);
				bool flag14 = num3 != 1;
				flag4 = false;
				obj6 = 0;
				ex4 = (ArgumentNullException)span;
				if (flag14)
				{
					continue;
				}
				goto IL_035f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			bool flag15 = num4 != 0;
			flag4 = false;
			obj6 = 0;
			num = (nint)reference2;
			flag8 = flag13;
			if (flag15)
			{
				goto IL_06c7;
			}
			NullReferenceException ex5 = new NullReferenceException();
			flag4 = false;
			obj6 = 0;
			num = (nint)reference2;
			flag8 = (byte)(int)ex5 != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		if (num5 == 0)
		{
			NullReferenceException ex6 = new NullReferenceException();
			flag8 = (byte)(int)ex6 != 0;
			goto IL_04fb;
		}
		goto IL_06c7;
		IL_0807:
		object obj14 = default;
		object obj13 = (object)(&obj14);
		bool flag16 = obj13 == null;
		num = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		if (!flag16)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj13);
			num = unchecked((nint)null);
		}
		bool flag17 = !flag2;
		object obj15 = !flag17;
		flag8 = flag2;
		if (obj15 != null)
		{
			goto IL_0552;
		}
		bool flag18 = obj3 == null;
		object obj16 = !flag18;
		flag8 = flag2;
		if (obj16 != null)
		{
			goto IL_0597;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		bool flag19 = num6 != 0;
		flag8 = flag2;
		int result;
		if (!flag19)
		{
			return result;
		}
		goto IL_06c7;
		IL_04fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		if (num7 == 0)
		{
			NullReferenceException ex7 = new NullReferenceException();
			flag2 = false;
			obj3 = 0;
			flag8 = (byte)(int)ex7 != 0;
			goto IL_0552;
		}
		goto IL_06c7;
		IL_06c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		int result2 = default;
		return result2;
		IL_0552:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		if (num8 == 0)
		{
			OutOfMemoryException ex8 = new OutOfMemoryException();
			flag8 = (byte)(int)ex8 != 0;
			goto IL_0597;
		}
		goto IL_06c7;
		IL_05d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		bool flag20 = num9 != 0;
		flag8 = (byte)(int)simulation != 0;
		if (flag20)
		{
			goto IL_06c7;
		}
		NullReferenceException ex9 = new NullReferenceException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj3 = 1;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				if (num10 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_06c7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj17 = default;
			flag2 = (byte)(int)obj17 != 0;
		}
		reference = ref *(SimulationMessage*)num;
		result = 0;
		goto IL_0807;
		IL_0238:
		obj11 = 0;
		obj12 = 0;
		obj10 = obj7;
		payloadNumBytes2 = (byte)PayloadNumBytes != 0;
		readOnlySpan = readOnlySpan2;
		flag4 = (byte)(&obj10) != 0;
		obj4 = obj5;
		obj6 = obj7;
		reference = ref *(SimulationMessage*)connectionIndex;
		goto IL_035f;
		IL_035f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+68]");
		result = 0;
		flag2 = false;
		obj3 = 0;
		goto IL_0807;
		IL_0597:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		if (num11 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_05d5;
		}
		goto IL_06c7;
	}

	private unsafe SimulationMessageHeader MakeHeader()
	{
		//IL_021f: Expected VT, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_0260: Expected I, but got Obj
		//IL_0291: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I
		//IL_007c: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00a5: Expected VT, but got I4
		//IL_0143: Expected VT, but got I4
		//IL_0337: Expected Obj, but got I
		//IL_0342: Expected VT, but got Ref
		//IL_0352: Expected VT, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected VT, but got Unknown
		//IL_03ca: Expected Ref, but got VT
		//IL_03ce: Expected VT, but got I4
		//IL_03e0: Expected I4, but got I8
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_02fd: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I8
		//IL_0471: Expected native int or pointer, but got VT
		//IL_047e: Expected native int or pointer, but got VT
		//IL_04a3: Expected VT, but got I4
		//IL_049e: Expected native int or pointer, but got VT
		//IL_04b3: Expected native int or pointer, but got VT
		//IL_0135: Expected Obj, but got I
		//IL_04e8: Expected native int or pointer, but got VT
		//IL_04f5: Expected native int or pointer, but got VT
		Simulation simulation = Simulation;
		PlayerRef sourcePlayer;
		if ((object)Simulation != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
			object obj = 0;
			nint num = (nint)simulation;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v19-8]");
				if (0 == (nint)obj2)
				{
					sourcePlayer = (PlayerRef)0;
					goto IL_0327;
				}
			}
			Simulation simulation2 = Simulation;
			if ((object)Simulation != null)
			{
				nint num4 = (nint)simulation2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v39 (Il2CppClass<Fusion.Simulation>)+2A0]");
				nint num5 = 0;
				ushort num6 = ((Enum)(object)Simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
				sourcePlayer = (PlayerRef)num6;
				goto IL_0327;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (SimulationMessageHeader)ex;
		IL_0377:
		object obj7;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X27_v2 (Fusion.NetworkBehaviourId)+58]");
		NetworkBehaviourId targetObject = (NetworkBehaviourId)(obj6 | 0);
		goto IL_02a8;
		IL_0327:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj8 = 0;
		PlayerRef playerRef = (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X22_v4 (Fusion.PlayerRef)-8]");
		targetObject = (NetworkBehaviourId)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X22_v4 (Fusion.PlayerRef)-8]");
		if ((nint)0 == 0)
		{
			goto IL_02a8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X27_v2 (Fusion.NetworkBehaviourId)+40]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X27_v2 (Fusion.NetworkBehaviourId)+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X28_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X28_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X29_v7+4]");
				object obj11 = 0 & -9223372036854775808L;
				if (obj11 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
			object obj12 = 0;
			nint num5 = (nint)obj12;
			Span<int> span = default;
			if (!span.IsEmpty)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X28_v4+20]");
				object obj13 = 0;
				obj7 = obj13;
				goto IL_0377;
			}
		}
		obj7 = 0;
		goto IL_0377;
		IL_02a8:
		object obj14 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+30]");
		SimulationMessageHeaderFlags simulationMessageHeaderFlags = (((nint)0 != 1) ? ((SimulationMessageHeaderFlags)2) : ((SimulationMessageHeaderFlags)10));
		SimulationMessageHeaderFlags simulationMessageHeaderFlags2 = simulationMessageHeaderFlags | (SimulationMessageHeaderFlags)0x40;
		SimulationMessageHeaderFlags simulationMessageHeaderFlags3 = (((object)_targetBehaviour != null) ? simulationMessageHeaderFlags2 : simulationMessageHeaderFlags);
		SimulationMessageHeader simulationMessageHeader = (SimulationMessageHeader)((PlayerRef*)playerRef)->IsValid;
		SimulationMessageHeaderFlags simulationMessageHeaderFlags4 = (SimulationMessageHeaderFlags)((int)simulationMessageHeaderFlags3 | 0xFFFFFF80L);
		object obj16 = simulationMessageHeader & 1;
		bool flag3 = obj16 == null;
		object obj17 = !flag3;
		object obj18 = ~obj17;
		if (obj18 != null)
		{
			simulationMessageHeaderFlags4 = simulationMessageHeaderFlags3;
		}
		_ = 0;
		SimulationMessageHeaderFlags simulationMessageHeaderFlags5 = simulationMessageHeaderFlags4 | (SimulationMessageHeaderFlags)0x10;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+2C]");
		if ((nint)0 == 0)
		{
			simulationMessageHeaderFlags4 = simulationMessageHeaderFlags5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X22_v4 (Fusion.PlayerRef)-10]");
		SimulationMessageHeader simulationMessageHeader2 = default;
		((SimulationMessageHeader*)(nint)simulationMessageHeader2)->PayloadNumBytes = 0;
		System.Runtime.CompilerServices.Unsafe.Write(&((SimulationMessageHeader*)(nint)simulationMessageHeader2)->SourcePlayer, sourcePlayer);
		SimulationMessageHeaderFlags simulationMessageHeaderFlags6 = simulationMessageHeaderFlags4 | (SimulationMessageHeaderFlags)0x20;
		System.Runtime.CompilerServices.Unsafe.Write(&((SimulationMessageHeader*)(nint)simulationMessageHeader2)->TargetPlayer, (PlayerRef)playerRef.Raw);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X22_v4 (Fusion.PlayerRef)-40]");
		((SimulationMessageHeader*)(nint)simulationMessageHeader2)->MessageType = 0u;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcBuilder)+28]");
		if ((nint)0 != 0)
		{
			simulationMessageHeaderFlags4 = simulationMessageHeaderFlags6;
		}
		System.Runtime.CompilerServices.Unsafe.Write(&((SimulationMessageHeader*)(nint)simulationMessageHeader2)->TargetObject, targetObject);
		((SimulationMessageHeader*)(nint)simulationMessageHeader2)->Flags = simulationMessageHeaderFlags4;
		_ = 0;
		return simulationMessageHeader;
	}

	private unsafe RpcDataWriter CreateReaderWriter()
	{
		//IL_01f0: Expected Obj, but got VT
		//IL_001b: Expected VT, but got Ref
		//IL_00d9: Expected VT, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_0148: Expected I, but got Obj
		//IL_0150: Expected VT, but got I4
		//IL_016b: Expected native int or pointer, but got VT
		//IL_017e: Expected native int or pointer, but got VT
		//IL_01b4: Expected Obj, but got VT
		//IL_0253: Expected Obj, but got I
		//IL_025b: Expected I4, but got Obj
		//IL_0275: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v1 (Fusion.RpcBuilder)+2C]");
		RpcBuilder rpcBuilder;
		int num;
		RpcDataWriter rpcDataWriter;
		nint num2;
		if ((nint)0 == 2)
		{
			bool flag = (object)Simulation == null;
			rpcBuilder = (RpcBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			if (!flag)
			{
				num = PayloadNumBytes;
				Span<byte> largeRpcWriteBuffer = Simulation.GetLargeRpcWriteBuffer(PayloadNumBytes, clear: true);
				bool flag2 = true;
				rpcDataWriter = (RpcDataWriter)largeRpcWriteBuffer;
				goto IL_0163;
			}
		}
		else
		{
			SimulationMessageHeader simulationMessageHeader = MakeHeader();
			bool flag3 = (object)Simulation == null;
			rpcBuilder = (RpcBuilder)simulationMessageHeader;
			if (!flag3)
			{
				SimulationMessageHeader header = default;
				SimulationMessage simulationMessage = (_msg = Simulation.AcquireSimulationMessage(ref header));
				bool flag4 = (object)simulationMessage == null;
				bool flag2 = false;
				num2 = (nint)(&header);
				rpcBuilder = (RpcBuilder)simulationMessage;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89F0]");
					object obj = 0;
					object obj2 = simulationMessage.RefCount - 1;
					bool flag5 = obj2 == null;
					Assert.Check(flag5, (string)obj);
					bool flag6 = (object)_msg == null;
					flag2 = false;
					num2 = (nint)obj;
					rpcBuilder = (RpcBuilder)flag5;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89F8]");
						object obj3 = 0;
						num = (int)obj3;
						ArgumentNullException ex = new ArgumentNullException();
						flag2 = false;
						rpcDataWriter = (RpcDataWriter)ex;
						goto IL_0163;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		bool flag7 = num3 != 0;
		NullReferenceException ex2 = (NullReferenceException)rpcBuilder;
		if (!flag7)
		{
			ex2 = new NullReferenceException();
		}
		goto IL_020c;
		IL_0163:
		RpcDataWriter rpcDataWriter2 = default;
		((RpcDataWriter*)(nint)rpcDataWriter2)->_data = (Span<byte>)rpcDataWriter;
		((RpcDataWriter*)(nint)rpcDataWriter2)->_offset = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		bool flag8 = num4 != 0;
		num2 = num;
		ex2 = (NullReferenceException)rpcDataWriter;
		if (!flag8)
		{
			return rpcDataWriter;
		}
		goto IL_020c;
		IL_020c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		RpcDataWriter result = default;
		return result;
	}
}
