using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion.Sockets;
using Unity.IL2CPP.Metadata;

namespace Fusion;

internal class SimulationConnection
{
	public const int INTEGRATOR_HISTORY_MULT = default(int);

	public readonly Simulation Simulation;

	private Dictionary<NetworkId, NetworkObjectConnectionData> _objects;

	private Queue<NetworkId> _objectsDestroyed;

	public PlayerRef Player;

	public bool AreaOfInterestHasBeenUpdated;

	public HashSet<int> AreaOfInterestCells;

	internal double LastSend;

	internal int SendCounter;

	internal TimeSeries _packetRecvDelta;

	internal Timer _packetRecvDeltaTimer;

	internal SimulationInput.Buffer _inputs;

	internal TimeSeries _clientOffset;

	internal Tick _latestTickReceived;

	internal Tick _latestTickAcknowledged;

	internal NetworkInterestedObjectList InterestedObjectList;

	internal unsafe NetConnection* Connection;

	internal NetConnectionId ConnectionId;

	public Queue<SimulationMessagePacketData> MessagesOutV2;

	public ulong MessagesOutSequenceV2;

	public ulong MessagesInSequenceV2;

	public Fusion.DualChannelPriorityQueue<(SimulationMessage, int)> MessagesInV2;

	public unsafe int ConnectionIndex
	{
		get
		{
			//IL_0044: Expected I4, but got Obj
			NetConnection* connection = Connection;
			if (Connection != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.Sockets.NetConnection*)+1A]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int DestroysPending
	{
		get
		{
			//IL_0020: Expected I4, but got Obj
			Queue<NetworkId> objectsDestroyed = _objectsDestroyed;
			if ((object)_objectsDestroyed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3 (System.Collections.Generic.Queue`1<Fusion.NetworkId>)+20]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public static implicit operator PlayerRef(SimulationConnection c)
	{
		//IL_0117: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_007a: Invalid comparison between VT and I4
		//IL_008e: Invalid comparison between VT and I4
		//IL_00ab: Expected Obj, but got VT
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected I4, but got Unknown
		if (c != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6D8]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = c.Player < (object)0;
			bool flag3 = c.Player == (PlayerRef)(object)0;
			object obj4 = c.Player ^ c.Player;
			object obj5 = c.Player & obj4;
			bool flag4 = (nint)obj5 < 0;
			bool flag5 = flag2 == flag4;
			object obj6 = !flag3;
			bool condition = (byte)((flag5 & obj6) ? 1 : 0) != 0;
			Assert.Check(condition, (string)error);
			return c.Player;
		}
		NullReferenceException ex = new NullReferenceException();
		return (PlayerRef)ex;
	}

	internal SimulationConnection(Simulation simulation)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_009b: Expected I8, but got I4
		//IL_00a6: Expected I8, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_018e: Expected I4, but got VT
		//IL_01b0: Expected Obj, but got I4
		//IL_01fb: Expected I4, but got VT
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0261: Expected VT, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I
		//IL_03fc: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8F50]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8F40]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6E8]");
		object obj5 = 0;
		AreaOfInterestHasBeenUpdated = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<int> hashSet = default;
		hashSet._002Ector();
		object obj6 = this + 48;
		obj6 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<SimulationMessagePacketData> queue = default;
		queue._002Ector(64);
		object obj7 = this + 152;
		obj7 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		MessagesOutSequenceV2 = 0uL;
		MessagesInSequenceV2 = 0uL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A095EC");
		object obj8 = this + 176;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		object obj10 = this + 16;
		obj10 = simulation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 1;
		SimulationConfig config = simulation._config;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA0C0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6FC0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj14 = 0;
		TickRate.Resolved resolved = TickRate.Resolve(config.TickRateSelection);
		object obj15 = obj11;
		int val = resolved >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v23+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int capacity = Math.Max(val, 5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SimulationInput.Buffer buffer = default;
		buffer._002Ector((int)resolved);
		object obj16 = this + 104;
		obj16 = buffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TimeSeries timeSeries = default;
		timeSeries._002Ector(capacity);
		object obj17 = this + 112;
		obj17 = timeSeries;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_latestTickReceived = (Tick)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TimeSeries timeSeries2 = default;
		timeSeries2._002Ector(capacity);
		object obj18 = this + 72;
		obj18 = timeSeries2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = obj14;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v41+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6F8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6F0]");
		object obj21 = 0;
		object obj22 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D83B0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA700]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v45+E4]");
		bool flag = (nint)0 == 0;
		object obj25 = !flag;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v45+A0]");
		object comparer = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<NetworkId, System.__Canon> dictionary = default;
		dictionary._002Ector((IEqualityComparer<NetworkId>)comparer);
		object obj26 = this + 24;
		obj26 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<NetworkId> queue2 = default;
		queue2._002Ector();
		object obj27 = this + 32;
		obj27 = queue2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkInterestedObjectList networkInterestedObjectList = default;
		networkInterestedObjectList._002Ector();
		object obj28 = this + 128;
		obj28 = networkInterestedObjectList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe bool TryGetObjectData(NetworkId id, out NetworkObjectConnectionData data)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		NetworkId id2 = (NetworkId)(id & 0xFFFFFFFFL);
		NetworkObjectConnectionData objectData = GetObjectData(id2, create: false, allowFail: false);
		ref NetworkObjectConnectionData reference = ref *(NetworkObjectConnectionData*)objectData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = objectData == null;
		return !flag;
	}

	public unsafe NetworkObjectConnectionData GetObjectData(NetworkId id, bool create, bool allowFail = default(bool))
	{
		//IL_0c48: Expected Obj, but got I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0027: Expected Obj, but got I
		//IL_002f: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got Ref
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected VT, but got Unknown
		//IL_098f: Expected Obj, but got Ref
		//IL_0108: Expected Obj, but got I
		//IL_0148: Expected Obj, but got Ref
		//IL_0151: Expected VT, but got I4
		//IL_017a: Expected I8, but got I4
		//IL_01a2: Expected Obj, but got Ref
		//IL_01ab: Expected VT, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got Ref
		//IL_048e: Expected VT, but got I4
		//IL_0267: Expected Obj, but got Ref
		//IL_0270: Expected VT, but got I4
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected VT, but got Unknown
		//IL_04be: Expected Obj, but got I
		//IL_04c6: Expected I4, but got Obj
		//IL_02b8: Expected Obj, but got Ref
		//IL_02c1: Expected VT, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I4
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Expected Obj, but got Unknown
		//IL_0bd9: Expected Obj, but got I4
		//IL_0b36: Expected Obj, but got I4
		//IL_0b3e: Expected Obj, but got Ref
		//IL_0b6c: Expected Obj, but got I
		//IL_0b7c: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0340: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I
		//IL_0d49: Expected Obj, but got Ref
		//IL_0d52: Expected VT, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_0367: Expected Obj, but got I
		//IL_0397: Expected Obj, but got Ref
		//IL_03a0: Expected VT, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c79: Expected Obj, but got Unknown
		//IL_06c0: Expected VT, but got I4
		//IL_0406: Expected Obj, but got Ref
		//IL_040f: Expected VT, but got I4
		//IL_06f1: Expected Obj, but got I
		//IL_0709: Expected Obj, but got I
		//IL_0719: Expected Obj, but got I
		//IL_0433: Expected Obj, but got I4
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_07a6: Expected Obj, but got I
		//IL_07c1: Expected Obj, but got I
		//IL_08c4: Expected I, but got Obj
		//IL_08d4: Expected Obj, but got I
		//IL_08e4: Expected Obj, but got I
		//IL_07e1: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Unknown
		//IL_091f: Expected Obj, but got I
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected Obj, but got Unknown
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected Obj, but got Unknown
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Obj, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected Obj, but got Unknown
		bool flag = (object)_objects == null;
		bool flag2 = allowFail;
		System.__Canon value = null;
		System.__Canon _Canon = (System.__Canon)create;
		NetworkId networkId = id;
		NetworkObjectMeta meta;
		NetworkObjectConnectionData networkObjectConnectionData3 = default;
		NetworkObjectConnectionData networkObjectConnectionData;
		if (!flag)
		{
			networkId = (NetworkId)(id & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA528]");
			object obj = 0;
			flag2 = (byte)(int)obj != 0;
			bool flag3 = ((Dictionary<NetworkId, System.__Canon>)(object)_objects).TryGetValue(networkId, out value);
			bool flag4 = !flag3;
			object obj2 = !flag4;
			if (obj2 != null || !create)
			{
				goto IL_0c5e;
			}
			bool flag5 = (object)Simulation == null;
			_Canon = (System.__Canon)(&value);
			if (!flag5)
			{
				networkId = (NetworkId)(id & 0xFFFFFFFFL);
				if (!Simulation.TryGetMeta(networkId, out meta))
				{
					bool flag6 = !allowFail;
					flag2 = false;
					_Canon = (System.__Canon)(&meta);
					if (!flag6)
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format = default;
					object arg = default;
					string message = string.Format(format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					InvalidOperationException ex = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					ArgumentNullException ex2 = new ArgumentNullException();
					NetworkObjectMeta networkObjectMeta = null;
					NetworkObjectConnectionData networkObjectConnectionData2 = default;
					networkObjectConnectionData = networkObjectConnectionData2;
					goto IL_0a77;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA530]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				networkObjectConnectionData3._002Ector();
				bool flag7 = networkObjectConnectionData3 == null;
				flag2 = false;
				value = (System.__Canon)(object)networkObjectConnectionData3;
				_Canon = (System.__Canon)(&meta);
				networkId = (NetworkId)0;
				if (!flag7)
				{
					networkObjectConnectionData3.Id = id;
					networkObjectConnectionData3.Filter = 18446744073709551615uL;
					bool flag8 = meta == null;
					flag2 = false;
					value = (System.__Canon)(object)networkObjectConnectionData3;
					_Canon = (System.__Canon)(&meta);
					networkId = (NetworkId)0;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj4 = 0;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v63+E4]");
						bool flag9 = (nint)0 == 0;
						object obj6 = !flag9;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!meta.Instance)
						{
							goto IL_045b;
						}
						bool flag10 = meta == null;
						flag2 = false;
						value = (System.__Canon)(object)networkObjectConnectionData3;
						_Canon = (System.__Canon)(&meta);
						networkId = (NetworkId)0;
						if (!flag10)
						{
							NetworkObject instance = meta.Instance;
							bool flag11 = (object)meta.Instance == null;
							flag2 = false;
							value = (System.__Canon)(object)networkObjectConnectionData3;
							_Canon = (System.__Canon)(&meta);
							networkId = (NetworkId)0;
							if (!flag11)
							{
								NetworkBehaviour[] networkedBehaviours = instance.NetworkedBehaviours;
								if (instance.NetworkedBehaviours == null || networkedBehaviours.Length < 1)
								{
									goto IL_045b;
								}
								object obj7 = ~networkedBehaviours.Length;
								object obj8 = networkedBehaviours.Length & obj7;
								object obj9 = 0;
								while (true)
								{
									bool flag12 = networkedBehaviours.Length == (nint)obj9;
									flag2 = false;
									value = (System.__Canon)(object)networkObjectConnectionData3;
									_Canon = (System.__Canon)(&meta);
									networkId = (NetworkId)0;
									if (flag12)
									{
										break;
									}
									object obj10 = (object)instance.NetworkedBehaviours + obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X14_v12+20]");
									object obj11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X14_v12+20]");
									bool flag13 = (nint)0 == 0;
									flag2 = false;
									value = (System.__Canon)(object)networkObjectConnectionData3;
									_Canon = (System.__Canon)(&meta);
									networkId = (NetworkId)0;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X14_v13+5C]");
										bool flag14 = (nint)0 == 0;
										object obj12 = !flag14;
										if (obj12 == null)
										{
											bool flag15 = networkObjectConnectionData3 == null;
											flag2 = false;
											value = (System.__Canon)(object)networkObjectConnectionData3;
											_Canon = (System.__Canon)(&meta);
											networkId = (NetworkId)0;
											if (flag15)
											{
												goto IL_09d5;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X14_v13+58]");
											object obj13 = 1 << 0;
											object obj14 = ~obj13;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v62 (Fusion.NetworkObjectConnectionData)+40]");
											object obj15 = 0 & obj14;
										}
										obj9++;
										if (obj8 != obj9)
										{
											continue;
										}
										goto IL_045b;
									}
									goto IL_09d5;
								}
								goto IL_09e3;
							}
						}
					}
				}
			}
		}
		goto IL_09d5;
		IL_0960:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0ced;
		IL_0ced:
		object obj16 = id & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v795 @ X0_v71] (should have been resolved before IL gen)");
		value = (System.__Canon)(object)networkObjectConnectionData3;
		goto IL_0c5e;
		IL_0c5e:
		return (NetworkObjectConnectionData)(object)value;
		IL_0aa1:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag16 = (nint)networkObjectConnectionData != 1;
		NullReferenceException ex4 = ex3;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj18 = default;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj20 = default;
			object obj19 = obj20 & 1;
			if (obj19 != null)
			{
				object obj21 = 0;
				object obj23 = default;
				object obj22 = (object)(&obj23);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v25+A0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v11+20]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v701 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				goto IL_0c5e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj27 = obj18;
			networkObjectConnectionData = (NetworkObjectConnectionData)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NetworkObjectMeta networkObjectMeta = null;
			NullReferenceException ex5 = default;
			ex4 = ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		NetworkObjectConnectionData result = default;
		return result;
		IL_045b:
		bool flag17 = (object)_objects == null;
		flag2 = false;
		value = (System.__Canon)(object)networkObjectConnectionData3;
		_Canon = (System.__Canon)(&meta);
		networkId = (NetworkId)0;
		if (!flag17)
		{
			networkId = (NetworkId)(id & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA520]");
			object obj28 = 0;
			flag2 = (byte)(int)obj28 != 0;
			((Dictionary<NetworkId, System.__Canon>)(object)_objects).Add(networkId, (System.__Canon)(object)networkObjectConnectionData3);
			bool flag18 = meta == null;
			value = (System.__Canon)(object)networkObjectConnectionData3;
			_Canon = (System.__Canon)(object)networkObjectConnectionData3;
			if (!flag18)
			{
				int* ptr = meta._ptr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v29 (System.Int32*)+18]");
				object obj29 = (nint)0 & (nint)0x20;
				bool flag19 = obj29 == null;
				object obj30 = !flag19;
				value = (System.__Canon)(object)networkObjectConnectionData3;
				if (obj30 != null)
				{
					goto IL_0c5e;
				}
				Simulation simulation = Simulation;
				bool flag20 = (object)Simulation == null;
				value = (System.__Canon)(object)networkObjectConnectionData3;
				_Canon = (System.__Canon)(object)Simulation;
				if (!flag20)
				{
					SimulationConfig config = simulation._config;
					bool flag21 = simulation._config == null;
					value = (System.__Canon)(object)networkObjectConnectionData3;
					_Canon = (System.__Canon)(object)Simulation;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v29 (System.Int32*)+18]");
						object obj31 = (nint)0 & (nint)1;
						bool flag22 = obj31 == null;
						value = (System.__Canon)(object)networkObjectConnectionData3;
						if (!flag22)
						{
							object obj32 = config.ReplicationFeatures & (NetworkProjectConfig.ReplicationFeatures)2;
							bool flag23 = obj32 == null;
							value = (System.__Canon)(object)networkObjectConnectionData3;
							if (!flag23)
							{
								bool flag24 = networkObjectConnectionData3 == null;
								value = (System.__Canon)(object)networkObjectConnectionData3;
								_Canon = (System.__Canon)(object)Simulation;
								if (!flag24)
								{
									networkObjectConnectionData3.SetPlayerFlag((NetworkObjectHeaderPlayerDataFlags)2, Simulation);
									bool flag25 = InterestedObjectList == null;
									flag2 = false;
									value = (System.__Canon)(object)networkObjectConnectionData3;
									_Canon = (System.__Canon)(object)Simulation;
									networkId = (NetworkId)2;
									if (!flag25)
									{
										InterestedObjectList.SetActive(networkObjectConnectionData3, meta);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
										object obj33 = 0;
										object obj34 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v34+A0]");
										object obj35 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v35+90]");
										object obj36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v35+90]");
										bool flag26 = (nint)0 == 0;
										flag2 = false;
										NetworkObjectMeta networkObjectMeta = meta;
										networkObjectConnectionData = networkObjectConnectionData3;
										if (!flag26)
										{
											bool flag27 = meta == null;
											flag2 = false;
											value = (System.__Canon)(object)networkObjectConnectionData3;
											networkObjectMeta = meta;
											networkObjectConnectionData = networkObjectConnectionData3;
											if (flag27)
											{
												goto IL_0a93;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
											object obj37 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
											object obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA538]");
											object format2 = 0;
											object obj39 = default;
											object arg2 = default;
											string text = string.Format((string)format2, obj39, arg2);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X23_v9+10]");
											object obj40 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X23_v9+10]");
											bool flag28 = (nint)0 == 0;
											flag2 = false;
											value = (System.__Canon)(object)networkObjectConnectionData3;
											networkObjectMeta = (NetworkObjectMeta)(object)text;
											networkObjectConnectionData = (NetworkObjectConnectionData)obj39;
											if (flag28)
											{
												goto IL_0aa1;
											}
											object obj41 = obj40;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v49+190]");
											flag2 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v717 @ X8_v49+188] (should have been resolved before IL gen)");
											networkObjectMeta = (NetworkObjectMeta)(object)text;
											networkObjectConnectionData = (NetworkObjectConnectionData)(object)Simulation;
										}
										Simulation simulation2 = Simulation;
										bool flag29 = (object)Simulation == null;
										value = (System.__Canon)(object)networkObjectConnectionData3;
										if (flag29)
										{
											goto IL_0a77;
										}
										Simulation.ICallbacks callbacks = simulation2._callbacks;
										bool flag30 = simulation2._callbacks == null;
										value = (System.__Canon)(object)networkObjectConnectionData3;
										if (flag30)
										{
											goto IL_0a85;
										}
										nint num = (nint)callbacks;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7188]");
										object obj42 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v38 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
										object obj43 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v38 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_0960;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v38 (Il2CppClass<Fusion.Simulation+ICallbacks>)+98]");
										object obj44 = (nint)0 + (nint)8;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X10_v17-8]");
											if (0 == (nint)obj42)
											{
												break;
											}
											obj43--;
											obj44 += 16;
											if ((nint)obj43 != 1)
											{
												continue;
											}
											goto IL_0960;
										}
										object obj45 = obj44 + 27;
										object obj46 = num + obj45;
										object obj47 = obj46 + 312;
										goto IL_0ced;
									}
								}
								goto IL_09d5;
							}
						}
						goto IL_0c5e;
					}
				}
			}
		}
		goto IL_09d5;
		IL_0a77:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0a85;
		IL_0a85:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0a93;
		IL_0a93:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_0aa1;
		IL_09d5:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_09e3;
		IL_09e3:
		throw new IndexOutOfRangeException();
	}

	public unsafe bool DestroyedNextId(out NetworkId id)
	{
		//IL_0392: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected I4, but got Unknown
		//IL_0061: Expected Ref, but got VT
		//IL_02ed: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I
		//IL_0298: Expected I4, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got VT
		Queue<NetworkId> objectsDestroyed = _objectsDestroyed;
		bool flag = (object)_objectsDestroyed == null;
		Simulation simulation = (Simulation)109899776;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA5A0]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA590]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA5A8]");
			object format2 = 0;
			object arg2 = default;
			object arg3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v8 (System.Collections.Generic.Queue`1<Fusion.NetworkId>)+20]");
				simulation = (Simulation)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v8 (System.Collections.Generic.Queue`1<Fusion.NetworkId>)+20]");
				if ((nint)0 > (nint)0)
				{
					NetworkId networkId = objectsDestroyed.Dequeue();
					ref NetworkId reference = ref *(NetworkId*)networkId;
					if ((object)_objects == null)
					{
						break;
					}
					if (((Dictionary<NetworkId, System.__Canon>)(object)_objects).TryGetValue(networkId, out System.__Canon value))
					{
						if (value == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ stack_-68_v6 (System.__Canon)+28]");
						Simulation simulation2;
						bool flag2;
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ stack_-68_v6 (System.__Canon)+28]");
							if ((nint)0 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA598]");
								object obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @314ED94");
								goto IL_02fc;
							}
							simulation2 = Simulation;
							if ((object)Simulation == null)
							{
								break;
							}
							flag2 = false;
						}
						else
						{
							simulation2 = Simulation;
							if ((object)Simulation == null)
							{
								break;
							}
							SimulationConfig config = simulation2._config;
							if (simulation2._config == null)
							{
								break;
							}
							Topologies topology = config.Topology;
							object obj4 = config.Topology - 2;
							bool flag3 = obj4 == null;
							flag2 = flag3;
						}
						bool condition = flag2;
						NetworkId arg = id;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ stack_-68_v6 (System.__Canon)+28]");
						Assert.Check(condition, (string)format, arg, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0, (System.__Canon)(object)simulation2.Runner);
						object obj5 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v9+A0]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v10+A8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v10+A8]");
						if ((nint)0 != 0)
						{
							simulation = Simulation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							if (value == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7230]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							string text = string.Format((string)format2, arg2, arg3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X29_v6+10]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X29_v6+10]");
							if ((nint)0 == 0)
							{
								break;
							}
							Topologies topology = (Topologies)obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ X9_v6 (Fusion.Topologies)+188] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ stack_-68_v6 (System.__Canon)+28]");
							object obj11 = 0;
							object obj12 = id;
						}
						objectsDestroyed = _objectsDestroyed;
						bool flag4 = (object)_objectsDestroyed == null;
						object obj13 = !flag4;
						if (obj13 == null)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					ref NetworkId reference = ref *(NetworkId*)null;
				}
				goto IL_02fc;
				IL_02fc:
				bool flag5 = (nint)simulation < 0;
				bool flag6 = (object)simulation == null;
				object obj14 = (object)simulation ^ (object)simulation;
				object obj15 = (object)simulation & obj14;
				bool flag7 = (nint)obj15 < 0;
				bool flag8 = flag5 == flag7;
				object obj16 = !flag6;
				return (byte)((flag8 & obj16) ? 1 : 0) != 0;
			}
		}
		throw new NullReferenceException();
	}

	public void ObjectData_Remove(SimulationConnection sc, NetworkId id)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0027: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0230: Expected I, but got Obj
		//IL_0261: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		NetworkId key = (NetworkId)(id & 0xFFFFFFFFL);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA610]");
		object obj = 0;
		if (!((Dictionary<NetworkId, System.__Canon>)(object)_objects).Remove(key, out System.__Canon _))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v10+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v10+A8]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Simulation simulation = sc.Simulation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
		object obj7 = 0;
		nint num = (nint)simulation;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v17+130]");
		bool flag = num2 < 0;
		object obj9 = !flag;
		object obj10 = ~obj9;
		string format;
		object arg;
		NetworkId networkId;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v17+130]");
			object obj11 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X9_v12-8]");
			if (0 == (nint)obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA618]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj13 = 0;
				format = (string)obj12;
				arg = obj13;
				networkId = id;
				goto IL_0176;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA618]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj15 = 0;
		format = (string)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		networkId = (NetworkId)sc.Player;
		object obj16 = default;
		arg = obj16;
		goto IL_0176;
		IL_0176:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7230]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg2 = default;
		object arg3 = default;
		string text = string.Format(format, arg2, arg, arg3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X23_v4+10]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X9_v7+188] (should have been resolved before IL gen)");
	}

	public void ObjectData_Destroyed(NetworkId id, bool force = default(bool))
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected VT, but got Unknown
		//IL_0081: Expected Obj, but got I
		NetworkId key = (NetworkId)(id & 0xFFFFFFFFL);
		if (((Dictionary<NetworkId, System.__Canon>)(object)_objects).TryGetValue(key, out System.__Canon _))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-28_v3 (System.__Canon)+28]");
			if ((nint)0 == 2)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA578]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @314ED94");
		}
		else if (!force)
		{
			return;
		}
		NetworkId item = (NetworkId)(id & 0xFFFFFFFFL);
		_objectsDestroyed.Enqueue(item);
	}

	public unsafe bool ObjectData_CreateConfirmed(NetworkObjectMeta meta, bool force = default(bool))
	{
		//IL_0150: Expected I4, but got Obj
		//IL_00b2: Expected VT, but got I
		//IL_0043: Expected VT, but got I
		//IL_0061: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		if (force)
		{
			if (meta != null)
			{
				int* ptr = meta._ptr;
				NetworkObjectConnectionData objectData = GetObjectData((NetworkId)ptr, create: true, allowFail: false);
				bool flag = objectData == null;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0107;
				}
			}
		}
		else if (meta != null)
		{
			int* ptr2 = meta._ptr;
			NetworkObjectConnectionData objectData2 = GetObjectData((NetworkId)ptr2, create: false, allowFail: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (objectData2 == null)
			{
				return false;
			}
			NetworkObjectConnectionData networkObjectConnectionData = default;
			bool flag2 = networkObjectConnectionData == null;
			NetworkObjectConnectionData objectData = networkObjectConnectionData;
			if (!flag2)
			{
				goto IL_0107;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0107:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA580]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @314ED94");
		return true;
	}

	public bool? ObjectData_IsCreateUnconfirmed(NetworkId id)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected VT, but got Unknown
		//IL_0076: Expected VT, but got Obj
		//IL_0030: Expected VT, but got I4
		NetworkId id2 = (NetworkId)(id & 0xFFFFFFFFL);
		NetworkObjectConnectionData objectData = GetObjectData(id2, create: false, allowFail: false);
		bool flag = objectData == null;
		bool? result = (bool?)(object)objectData;
		if (!flag)
		{
			bool value = objectData.Status__BackingField == 0;
			bool? flag2 = value;
			result = (bool?)(object)0;
		}
		return result;
	}

	public bool? ObjectData_IsDestroyUnconfirmedOrPending(NetworkId id)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		//IL_0096: Expected VT, but got Obj
		//IL_001d: Expected Obj, but got I8
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0050: Expected VT, but got I4
		NetworkId id2 = (NetworkId)(id & 0xFFFFFFFFL);
		NetworkObjectConnectionData objectData = GetObjectData(id2, create: false, allowFail: false);
		bool flag = objectData == null;
		bool? result = (bool?)(object)objectData;
		if (!flag)
		{
			object obj = (long)objectData.Status__BackingField & 0xFFFFFFFEL;
			object obj2 = obj - 2;
			bool value = obj2 == null;
			bool? flag2 = value;
			result = (bool?)(object)0;
		}
		return result;
	}

	public void Free(Simulation simulation)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got VT
		//IL_0157: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I
		Fusion.DualChannelPriorityQueue<(SimulationMessage, int)> messagesInV = MessagesInV2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9338]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9340]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA720]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj4 = 0;
		object obj5 = 0;
		object obj6 = default;
		SimulationMessage obj7 = default;
		object arg = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A092C8");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A09310");
				bool flag = simulation.ReleaseReference(obj7);
				messagesInV = MessagesInV2;
				obj5++;
				bool flag2 = MessagesInV2 == null;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					break;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A09568");
			Queue<SimulationMessagePacketData> messagesOutV = MessagesOutV2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v11 (System.Collections.Generic.Queue`1<Fusion.SimulationMessagePacketData>)+20]");
			if ((nint)0 >= (nint)1)
			{
				object obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v4+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v2+60]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v2+60]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA730]");
					object format = 0;
					string text = string.Format((string)format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X21_v5+10]");
					object obj12 = 0;
					obj10 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X9_v2+188] (should have been resolved before IL gen)");
					goto IL_0251;
				}
			}
			goto IL_01b3;
			IL_01b3:
			if (messagesOutV.TryDequeue(out var result))
			{
				bool flag3 = simulation.ReleaseReference((SimulationMessage)result);
				goto IL_0251;
			}
			MessagesOutV2.Clear();
			LastSend = 0.0;
			return;
			IL_0251:
			messagesOutV = MessagesOutV2;
			goto IL_01b3;
		}
		throw new NullReferenceException();
	}

	public void PacketReceiveDelta()
	{
		//IL_008b: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I
		//IL_0497: Expected Obj, but got I
		//IL_04b6: Invalid comparison between F8 and I
		//IL_0435: Expected Obj, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_0479: Expected Obj, but got I4
		//IL_01ef: Expected VT, but got I8
		//IL_038c: Expected Obj, but got I
		//IL_0394: Expected I, but got Obj
		//IL_03c5: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I
		//IL_02f2: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.SimulationConnection)+60]");
		object obj;
		object obj3;
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CECDD]");
			object obj2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.SimulationConnection)+58]");
				obj2 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.SimulationConnection)+58]");
				obj2 = 0;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.SimulationConnection)+60]");
				bool flag = (nint)0 != 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.SimulationConnection)+58]");
				obj3 = 0;
				if (flag)
				{
					goto IL_03d3;
				}
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v51+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long timestamp = Stopwatch.GetTimestamp();
			object obj6 = timestamp + obj2;
			obj3 = obj6 - _packetRecvDeltaTimer;
			goto IL_03d3;
		}
		Timer timer = Timer.StartNew();
		Timer packetRecvDeltaTimer = default;
		_packetRecvDeltaTimer = packetRecvDeltaTimer;
		bool isEmpty = _packetRecvDelta.IsEmpty;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA738]");
		object error = 0;
		Assert.Check(isEmpty, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkId runtimeConfig = NetworkId.RuntimeConfig;
		if (!Simulation.TryGetStruct(runtimeConfig, out var _))
		{
			return;
		}
		Simulation simulation = Simulation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
		object obj10 = 0;
		nint num = (nint)simulation;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v19+130]");
		bool flag4 = num2 < 0;
		object obj12 = !flag4;
		Simulation simulation2;
		object obj14;
		if (obj12 == null)
		{
			simulation2 = Simulation;
		}
		else
		{
			simulation2 = Simulation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v19+130]");
			object obj13 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X9_v9-8]");
			if (0 == (nint)obj11)
			{
				ref SimulationRuntimeConfig runtimeConfigRef = ref Simulation.RuntimeConfigRef;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v25 (Fusion.SimulationRuntimeConfig&)+C]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v25 (Fusion.SimulationRuntimeConfig&)+C]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 != null)
				{
					goto IL_0281;
				}
				goto IL_02e9;
			}
		}
		ref SimulationRuntimeConfig runtimeConfigRef2 = ref simulation2.RuntimeConfigRef;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v23 (Fusion.SimulationRuntimeConfig&)+4]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v23 (Fusion.SimulationRuntimeConfig&)+4]");
		if ((nint)0 != 0)
		{
			goto IL_0281;
		}
		goto IL_02e9;
		IL_02f7:
		double value;
		_packetRecvDelta.Add(value);
		return;
		IL_03d3:
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v36+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v36+A0]");
		object obj18 = 0;
		double num4 = (double)obj3 / (double)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C520]");
		if (!(num4 < 0.0))
		{
			_packetRecvDelta.Add(num4);
			object obj19 = obj;
			_ = 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v39+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long timestamp2 = Stopwatch.GetTimestamp();
			_packetRecvDeltaTimer = (Timer)timestamp2;
		}
		return;
		IL_0281:
		value = 1.0 / (double)obj14;
		goto IL_02f7;
		IL_02e9:
		value = 0.0;
		goto IL_02f7;
	}

	public void ResetTimeFeedback()
	{
		//IL_0026: Expected VT, but got I4
		_clientOffset.Clear();
		_packetRecvDelta.Clear();
		_packetRecvDeltaTimer = (Timer)0;
		_ = 0;
		_ = 0;
	}

	public void InputReceiveDelta(Tick tick, double receive, double expected)
	{
		if (_latestTickReceived < tick)
		{
			_latestTickReceived = tick;
			double value = expected - receive;
			_clientOffset.Add(value);
		}
	}

	public void SetActive(NetworkObjectConnectionData data, NetworkObjectMeta meta)
	{
		InterestedObjectList.SetActive(data, meta);
	}

	public void SetIdle(NetworkObjectConnectionData data)
	{
		InterestedObjectList.SetIdle(data);
	}

	public unsafe bool AddAlwaysInterested(NetworkObjectMeta meta)
	{
		//IL_0028: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_050e: Expected I4, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected I4, but got Unknown
		//IL_0107: Expected VT, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		NetworkObjectConnectionData objectData;
		if (meta != null)
		{
			int* ptr = meta._ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (System.Int32*)+18]");
			object obj = (nint)0 & (nint)1;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Simulation simulation = Simulation;
				if ((object)Simulation != null)
				{
					SimulationConfig config = simulation._config;
					if (simulation._config != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA748]");
						object error = 0;
						object obj3 = (int)config.ReplicationFeatures >> 1;
						bool condition = (byte)(obj3 & 1) != 0;
						Assert.Check(condition, (string)error);
						int* ptr2 = meta._ptr;
						objectData = GetObjectData((NetworkId)ptr2, create: true, allowFail: false);
						if (objectData != null)
						{
							object obj4 = objectData.PlayerFlags__BackingField & (NetworkObjectHeaderPlayerDataFlags)2;
							bool flag2 = obj4 == null;
							object obj5 = !flag2;
							if (obj5 != null)
							{
								goto IL_048a;
							}
							if ((object)Simulation != null)
							{
								int* ptr3 = meta._ptr;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BBB4");
								object obj7 = default;
								object obj6 = obj7 & 1;
								bool flag3 = obj6 == null;
								object obj8 = !flag3;
								if (obj8 == null)
								{
									if ((object)Simulation == null)
									{
										goto IL_0500;
									}
									int* ptr4 = meta._ptr;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3124AF0");
									object obj10 = default;
									object obj9 = obj10 & 1;
									bool flag4 = obj9 == null;
									object obj11 = !flag4;
									if (obj11 == null)
									{
										object obj12 = objectData.PlayerFlags__BackingField & (NetworkObjectHeaderPlayerDataFlags)3;
										bool flag5 = obj12 == null;
										object obj13 = !flag5;
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
											object obj14 = 0;
											object obj15 = obj14;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v20+A0]");
											object obj16 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v21+90]");
											object obj17 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v21+90]");
											bool flag6 = (nint)0 == 0;
											object obj18 = 0;
											if (!flag6)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
												object obj19 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
												object obj20 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA740]");
												object format = 0;
												object arg = default;
												object arg2 = default;
												string text = string.Format((string)format, arg, arg2);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X24_v5+10]");
												object obj21 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X24_v5+10]");
												if ((nint)0 == 0)
												{
													goto IL_0500;
												}
												object obj22 = obj21;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v18+190]");
												obj18 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X9_v18+188] (should have been resolved before IL gen)");
											}
											Simulation simulation2 = Simulation;
											if ((object)Simulation != null)
											{
												Simulation.ICallbacks callbacks = simulation2._callbacks;
												if (simulation2._callbacks != null)
												{
													nint num = (nint)callbacks;
													int* ptr5 = meta._ptr;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7188]");
													object obj23 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v24 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
													object obj24 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v24 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
													if ((nint)0 == 0)
													{
														goto IL_047b;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v24 (Il2CppClass<Fusion.Simulation+ICallbacks>)+98]");
													object obj25 = (nint)0 + (nint)8;
													while (true)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X10_v10-8]");
														if (0 == (nint)obj23)
														{
															break;
														}
														obj24--;
														obj25 += 16;
														if ((nint)obj24 != 1)
														{
															continue;
														}
														goto IL_047b;
													}
													object obj26 = obj25 + 27;
													object obj27 = num + obj26;
													object obj28 = obj27 + 312;
													goto IL_0597;
												}
											}
											goto IL_0500;
										}
									}
								}
								goto IL_052b;
							}
						}
					}
				}
				goto IL_0500;
			}
		}
		goto IL_048a;
		IL_048a:
		return false;
		IL_0500:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_052b:
		if (InterestedObjectList != null)
		{
			InterestedObjectList.SetActive(objectData, meta);
			objectData.SetPlayerFlag((NetworkObjectHeaderPlayerDataFlags)2, Simulation);
			return true;
		}
		goto IL_0500;
		IL_047b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0597;
		IL_0597:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v388 @ X0_v20] (should have been resolved before IL gen)");
		goto IL_052b;
	}

	public unsafe bool RemoveAlwaysInterested(NetworkObjectMeta meta)
	{
		//IL_0028: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_04d4: Expected I4, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected I4, but got Unknown
		//IL_0107: Expected VT, but got I
		//IL_0127: Expected I4, but got Obj
		//IL_0148: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I
		//IL_03e0: Expected I, but got Obj
		//IL_03fd: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I
		//IL_0448: Expected Obj, but got I
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		NetworkObjectConnectionData objectData;
		bool result;
		if (meta != null)
		{
			int* ptr = meta._ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (System.Int32*)+18]");
			object obj = (nint)0 & (nint)1;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Simulation simulation = Simulation;
				if ((object)Simulation != null)
				{
					SimulationConfig config = simulation._config;
					if (simulation._config != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA748]");
						object error = 0;
						object obj3 = (int)config.ReplicationFeatures >> 1;
						bool condition = (byte)(obj3 & 1) != 0;
						Assert.Check(condition, (string)error);
						int* ptr2 = meta._ptr;
						objectData = GetObjectData((NetworkId)ptr2, create: false, allowFail: false);
						bool flag2 = objectData == null;
						result = (byte)(int)objectData != 0;
						if (flag2)
						{
							goto IL_04f1;
						}
						object obj4 = objectData.PlayerFlags__BackingField & (NetworkObjectHeaderPlayerDataFlags)2;
						bool flag3 = obj4 == null;
						object obj5 = !flag3;
						if (obj5 == null)
						{
							goto IL_0170;
						}
						if ((object)Simulation != null)
						{
							int* ptr3 = meta._ptr;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BBB4");
							object obj7 = default;
							object obj6 = obj7 & 1;
							bool flag4 = obj6 == null;
							object obj8 = !flag4;
							if (obj8 == null)
							{
								if ((object)Simulation == null)
								{
									goto IL_04c6;
								}
								int* ptr4 = meta._ptr;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3124AF0");
								object obj10 = default;
								object obj9 = obj10 & 1;
								bool flag5 = obj9 == null;
								object obj11 = !flag5;
								if (obj11 == null)
								{
									object obj12 = objectData.PlayerFlags__BackingField & (NetworkObjectHeaderPlayerDataFlags)3;
									if ((nint)obj12 == 2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
										object obj13 = 0;
										object obj14 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v20+A0]");
										object obj15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v21+90]");
										object obj16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v21+90]");
										bool flag6 = (nint)0 == 0;
										object obj17 = 0;
										if (!flag6)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
											object obj18 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
											object obj19 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA750]");
											object format = 0;
											object arg = default;
											object arg2 = default;
											string text = string.Format((string)format, arg, arg2);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X24_v5+10]");
											object obj20 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X24_v5+10]");
											if ((nint)0 == 0)
											{
												goto IL_04c6;
											}
											object obj21 = obj20;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X9_v18+190]");
											obj17 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X9_v18+188] (should have been resolved before IL gen)");
										}
										Simulation simulation2 = Simulation;
										if ((object)Simulation != null)
										{
											Simulation.ICallbacks callbacks = simulation2._callbacks;
											if (simulation2._callbacks != null)
											{
												nint num = (nint)callbacks;
												int* ptr5 = meta._ptr;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7188]");
												object obj22 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v24 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
												object obj23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v24 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
												if ((nint)0 == 0)
												{
													goto IL_0489;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v24 (Il2CppClass<Fusion.Simulation+ICallbacks>)+98]");
												object obj24 = (nint)0 + (nint)8;
												while (true)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X10_v10-8]");
													if (0 == (nint)obj22)
													{
														break;
													}
													obj23--;
													obj24 += 16;
													if ((nint)obj23 != 1)
													{
														continue;
													}
													goto IL_0489;
												}
												object obj25 = obj24 + 28;
												object obj26 = num + obj25;
												object obj27 = obj26 + 312;
												goto IL_0565;
											}
										}
										goto IL_04c6;
									}
								}
							}
							goto IL_04f6;
						}
					}
				}
				goto IL_04c6;
			}
		}
		goto IL_0170;
		IL_0170:
		result = false;
		goto IL_04f1;
		IL_0565:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v392 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_04f6;
		IL_04f1:
		return result;
		IL_04c6:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0489:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0565;
		IL_04f6:
		objectData.ClearPlayerFlag((NetworkObjectHeaderPlayerDataFlags)2, Simulation);
		result = true;
		goto IL_04f1;
	}

	public void EnqueueMessage([In] ref SimulationMessage msg)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		//IL_009c: Expected I4, but got VT
		//IL_0061: Expected I8, but got I4
		Simulation simulation = Simulation;
		SimulationMessage simulationMessage = msg;
		object obj = simulationMessage.Header & 0x10;
		bool flag = obj == null;
		object obj2 = !flag;
		EnqueueMessage(sequence: (obj2 == null) ? 0 : (++MessagesOutSequenceV2), msg: simulationMessage, tick: (int)simulation._tick);
	}

	public unsafe void EnqueueMessage(SimulationMessage msg, int tick, ulong sequence)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a3: Expected VT, but got Ref
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		bool flag = sequence == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA760]");
		object error = 0;
		object obj = msg.Header & 0x10;
		bool condition = (byte)((flag ^ obj) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		Simulation.AddReference(msg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9518]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj3 = 0;
		SimulationMessage simulationMessage = default;
		MessagesOutV2.Enqueue((SimulationMessagePacketData)(&simulationMessage));
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+60]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA758]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			object arg2 = default;
			object arg3 = default;
			string text = string.Format((string)format, arg, arg2, arg3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X23_v4+10]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X9_v7+188] (should have been resolved before IL gen)");
		}
	}

	public unsafe void RequeueMessage(SimulationMessage msg, int tick, ulong sequence)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a3: Expected VT, but got Ref
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		bool flag = sequence == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA760]");
		object error = 0;
		object obj = msg.Header & 0x10;
		bool condition = (byte)((flag ^ obj) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		Simulation.AddReference(msg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9518]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj3 = 0;
		SimulationMessage simulationMessage = default;
		MessagesOutV2.Enqueue((SimulationMessagePacketData)(&simulationMessage));
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+60]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA768]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			object arg2 = default;
			object arg3 = default;
			string text = string.Format((string)format, arg, arg2, arg3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X23_v4+10]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X9_v7+188] (should have been resolved before IL gen)");
		}
	}
}
