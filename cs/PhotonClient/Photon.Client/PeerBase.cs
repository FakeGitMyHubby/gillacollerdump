using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Photon.Client.Encryption;

namespace Photon.Client;

public abstract class PeerBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly PeerBase._003C_003Ec _003C_003E9;

		public static Func<NCommand> _003C_003E9__34_0;

		public static Action<NCommand> _003C_003E9__34_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160E8]");
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

		internal NCommand _003C_002Ector_003Eb__34_0()
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516438]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			_ = 4;
			object obj2 = default;
			obj2._002Ector();
			return (NCommand)obj2;
		}

		internal void _003C_002Ector_003Eb__34_1(NCommand cmd)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected Obj, but got Unknown
			//IL_0020: Expected Obj, but got I4
			cmd.FreePayload();
			object obj = cmd + 104;
			obj = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 4;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	internal delegate void MyAction();

	private static class GpBinaryV3Parameters
	{
		public const byte CustomObject = default(byte);

		public const byte ExtraPlatformParams = default(byte);
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly PeerBase._003C_003Ec _003C_003E9;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516648]");
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

		internal StreamBuffer _003C_002Ecctor_003Eb__142_0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0044: Expected Obj, but got I
			//IL_0066: Expected Obj, but got I4
			//IL_0084: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B38]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+C]");
			StreamBuffer streamBuffer = default;
			streamBuffer._002Ector(0);
			return streamBuffer;
		}

		internal void _003C_002Ecctor_003Eb__142_1(StreamBuffer buffer)
		{
			buffer.Reset();
		}
	}

	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public PeerBase _003C_003E4__this;

		public LogLevel level;

		public string debugReturn;

		internal void _003CEnqueueDebugReturn_003Eb__0()
		{
			//IL_0021: Expected I, but got Obj
			//IL_0031: Expected Obj, but got I
			//IL_0055: Expected Obj, but got I
			//IL_013c: Expected Obj, but got I
			//IL_0090: Expected Obj, but got I
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected Obj, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected Obj, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			IPhotonPeerListener listener = _003C_003E4__this.Listener;
			nint num = (nint)listener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj = 0;
			LogLevel logLevel = level;
			string text = debugReturn;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00d1;
			}
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			goto IL_0124;
			IL_00d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0124;
			IL_0124:
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v6+8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	internal PhotonPeer photonPeer;

	public Protocol SerializationProtocol;

	internal ConnectionProtocol usedTransportProtocol;

	internal PhotonSocket PhotonSocket;

	private string ServerAddress__BackingField;

	private string ProxyServerAddress__BackingField;

	private int peerConnectionStateField;

	internal int ByteCountLastOperation;

	internal int ByteCountCurrentDispatch;

	internal NCommand CommandInCurrentDispatch;

	internal int packetLossByCrc;

	internal int packetLossByChallenge;

	internal int throttledBySendWindow;

	internal readonly Queue<MyAction> ActionQueue;

	internal short peerID;

	internal static short peerCount;

	internal int serverTimeOffset;

	internal bool serverTimeOffsetIsAvailable;

	internal float roundTripTime;

	internal float roundTripTimeVariance;

	internal int lastRoundTripTime;

	internal int lowestRoundTripTime;

	internal int highestRoundTripTimeVariance;

	internal int varianceJitterMin;

	internal int varianceJitterMax;

	internal int varianceJitterFactor;

	internal object PhotonToken;

	internal object CustomInitData;

	public string AppId;

	internal EventData reusableEventData;

	internal Stopwatch watch;

	internal int timeoutInt;

	internal int timeLastAckReceive;

	internal int longestSendCall;

	internal int timeIntCurrentSend;

	internal bool ApplicationIsInitialized;

	internal bool isEncryptionAvailable;

	private ushort serverFeatureFlags;

	private bool serverFeatureFlagsAvailable__BackingField;

	private bool serverFeatureAck2Available__BackingField;

	private bool serverFeatureSyncReliableQueue__BackingField;

	private ushort ServerMaxQueueableReliableCommands__BackingField;

	protected internal static Pool<StreamBuffer> MessageBufferPool;

	internal byte[] messageHeader;

	private int prepareWebSocketUrlCount;

	private StringBuilder prepareWebSocketUrlSB;

	internal ICryptoProvider CryptoProvider;

	internal readonly LinkedList<SimulationItem> NetSimListOutgoing;

	internal readonly LinkedList<SimulationItem> NetSimListIncoming;

	private readonly NetworkSimulationSet networkSimulationSettings;

	internal TrafficStats Stats
	{
		get
		{
			PhotonPeer photonPeer = this.photonPeer;
			if (this.photonPeer != null)
			{
				return photonPeer.Stats__BackingField;
			}
			return (TrafficStats)(object)new NullReferenceException();
		}
	}

	internal IPhotonPeerListener Listener
	{
		get
		{
			PhotonPeer photonPeer = this.photonPeer;
			if (this.photonPeer != null)
			{
				return photonPeer.Listener__BackingField;
			}
			return (IPhotonPeerListener)new NullReferenceException();
		}
	}

	internal LogLevel LogLevel
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PhotonPeer photonPeer = this.photonPeer;
			if (this.photonPeer != null)
			{
				return photonPeer.LogLevel;
			}
			NullReferenceException ex = new NullReferenceException();
			return (LogLevel)(int)ex;
		}
	}

	public string ServerAddress
	{
		get
		{
			return ServerAddress__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string ProxyServerAddress
	{
		get
		{
			return ProxyServerAddress__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	internal unsafe ConnectionStateValue peerConnectionState
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Ref, but got Unknown
			return (ConnectionStateValue)Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Ref, but got Unknown
			ref int location = ref *(int*)(this + 64);
			int value2 = (int)(value & (ConnectionStateValue)0xFF);
			int num = Interlocked.Exchange(ref location, value2);
		}
	}

	internal string rttVarString
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516340]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			object arg2 = default;
			return string.Format((string)format, arg, arg2);
		}
	}

	internal int TimeoutVarianceCompensation
	{
		get
		{
			//IL_0016: Invalid comparison between F4 and I4
			//IL_0040: Invalid comparison between F4 and I4
			//IL_005e: Expected I4, but got F4
			int num = varianceJitterMin;
			if (!(roundTripTimeVariance < (float)varianceJitterMin))
			{
				num = varianceJitterMax;
				if (!(roundTripTimeVariance > (float)varianceJitterMax))
				{
					num = (int)roundTripTimeVariance;
				}
			}
			return varianceJitterFactor * num;
		}
	}

	internal int DisconnectTimeout
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if (photonPeer != null)
			{
				return photonPeer.DisconnectTimeout;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	internal int PingInterval
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PhotonPeer photonPeer = this.photonPeer;
			if (this.photonPeer != null)
			{
				return photonPeer.PingInterval;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	internal byte ChannelCount
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PhotonPeer photonPeer = this.photonPeer;
			if (this.photonPeer != null)
			{
				return photonPeer.ChannelCount;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex;
		}
	}

	internal abstract int QueuedIncomingCommandsCount { get; }

	internal abstract int QueuedOutgoingCommandsCount { get; }

	public virtual string PeerID
	{
		get
		{
			ushort num = default;
			return num.ToString();
		}
	}

	internal int timeInt
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			//IL_002e: Expected I4, but got I8
			if (watch != null)
			{
				return (int)watch.ElapsedMilliseconds;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public ushort ServerFeatureFlags
	{
		get
		{
			return serverFeatureFlags;
		}
		internal set
		{
			int num = value & 0xFFFF;
			bool flag = num == 0;
			int num2 = value >> 1;
			int num3 = num2 & 1;
			int num4 = value & 1;
			bool flag2 = !flag;
			serverFeatureFlags = value;
			serverFeatureAck2Available__BackingField = (byte)num4 != 0;
			serverFeatureFlagsAvailable__BackingField = flag2;
			serverFeatureSyncReliableQueue__BackingField = (byte)num3 != 0;
			if (num == 0)
			{
				ServerMaxQueueableReliableCommands__BackingField = 0;
			}
		}
	}

	internal bool serverFeatureFlagsAvailable
	{
		get
		{
			return serverFeatureFlagsAvailable__BackingField;
		}
		private set
		{
			serverFeatureFlagsAvailable__BackingField = value;
		}
	}

	internal bool serverFeatureAck2Available
	{
		get
		{
			return serverFeatureAck2Available__BackingField;
		}
		private set
		{
			serverFeatureAck2Available__BackingField = value;
		}
	}

	internal bool serverFeatureSyncReliableQueue
	{
		get
		{
			return serverFeatureSyncReliableQueue__BackingField;
		}
		private set
		{
			serverFeatureSyncReliableQueue__BackingField = value;
		}
	}

	public ushort ServerMaxQueueableReliableCommands
	{
		get
		{
			return ServerMaxQueueableReliableCommands__BackingField;
		}
		internal set
		{
			ServerMaxQueueableReliableCommands__BackingField = value;
		}
	}

	internal int mtu
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if (photonPeer != null)
			{
				return photonPeer.MaximumTransferUnit;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	protected internal bool IsIpv6
	{
		get
		{
			//IL_00a4: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			if (PhotonSocket != null)
			{
				PhotonSocket photonSocket = PhotonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				if (PhotonSocket != null)
				{
					bool flag = !photonSocket.AddressResolvedAsIpv6__BackingField;
					return !flag;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public NetworkSimulationSet NetworkSimulationSettings => networkSimulationSettings;

	internal unsafe bool TryUpdateConnectionState(ConnectionStateValue expected, ConnectionStateValue desired)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		//IL_0049: Expected Obj, but got I4
		ref int location = ref *(int*)(this + 64);
		int value = (int)(desired & (ConnectionStateValue)0xFF);
		int comparand = (int)(expected & (ConnectionStateValue)0xFF);
		int num = Interlocked.CompareExchange(ref location, value, comparand);
		object obj = num - (int)expected;
		return obj == null;
	}

	protected PeerBase()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ca: Expected I4, but got I8
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516150]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516168]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516170]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<System.__Canon> queue = default;
		queue._002Ector();
		object obj5 = this + 104;
		obj5 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2;
		_ = 65535;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5F0]");
		_ = 0;
		_ = 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		object obj7 = this + 192;
		obj7 = stopwatch;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		prepareWebSocketUrlCount = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		LinkedList<System.__Canon> linkedList = default;
		linkedList._002Ector();
		object obj8 = this + 264;
		NetSimListOutgoing = (LinkedList<SimulationItem>)(object)linkedList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		LinkedList<System.__Canon> linkedList2 = default;
		linkedList2._002Ector();
		object obj9 = this + 272;
		NetSimListIncoming = (LinkedList<SimulationItem>)(object)linkedList2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkSimulationSet networkSimulationSet = default;
		networkSimulationSet._002Ector();
		object obj10 = this + 280;
		networkSimulationSettings = networkSimulationSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj11 = 0;
		object obj12 = networkSimulationSettings + 48;
		obj12 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v32+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v32+A0]");
		object obj14 = 0;
		object obj15 = obj14 + 1;
		obj14 = obj15;
	}

	internal unsafe virtual void Reset()
	{
		//IL_088d: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got Ref
		//IL_0211: Expected Obj, but got Ref
		//IL_022d: Expected Obj, but got Ref
		//IL_07db: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got Ref
		//IL_0605: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got Ref
		//IL_02d1: Expected Obj, but got Ref
		//IL_027b: Expected Obj, but got Ref
		//IL_062d: Expected Obj, but got I4
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Ref, but got Unknown
		//IL_067a: Expected Obj, but got I4
		//IL_06b2: Expected Obj, but got I4
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected Obj, but got Unknown
		//IL_073f: Expected F4, but got I
		PhotonPeer photonPeer = this.photonPeer;
		bool flag = this.photonPeer == null;
		object obj = null;
		bool flag2 = false;
		object obj2 = null;
		bool flag3 = false;
		object obj3 = null;
		bool lockTaken = false;
		IntPtr intPtr = default;
		Protocol protocol = (Protocol)(nint)intPtr;
		object obj9 = default;
		OutOfMemoryException ex = default;
		object obj10 = default;
		object obj11 = default;
		if (!flag)
		{
			Protocol protocol2 = SerializationProtocolFactory.Create(photonPeer.SerializationProtocolType__BackingField);
			object obj4 = this + 24;
			obj4 = protocol2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X20_v13-8]");
			object obj5 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X20_v13-8]");
			bool flag4 = (nint)0 == 0;
			obj = null;
			flag2 = false;
			obj2 = null;
			flag3 = false;
			obj3 = null;
			lockTaken = false;
			protocol = protocol2;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v20+B0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v20+B0]");
				bool flag5 = (nint)0 == 0;
				obj = null;
				flag2 = false;
				obj2 = null;
				flag3 = false;
				obj3 = null;
				lockTaken = false;
				protocol = protocol2;
				if (!flag5)
				{
					_ = 0;
					_ = 0;
					NetworkSimulationSet networkSimulationSet = networkSimulationSettings;
					packetLossByCrc = 0;
					bool flag6 = networkSimulationSettings == null;
					obj = null;
					flag2 = false;
					obj2 = null;
					flag3 = false;
					obj3 = null;
					lockTaken = false;
					protocol = protocol2;
					if (!flag6)
					{
						networkSimulationSet.LostPackagesOut__BackingField = 0;
						throttledBySendWindow = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516190]");
						object obj7 = 0;
						Monitor.Enter(NetSimListOutgoing, ref lockTaken);
						bool flag7 = NetSimListOutgoing == null;
						obj = null;
						flag2 = false;
						obj2 = null;
						flag3 = false;
						object obj8 = 0;
						obj9 = 0;
						ex = null;
						obj10 = (object)(&obj3);
						obj11 = (object)(&lockTaken);
						obj3 = NetSimListOutgoing;
						lockTaken = false;
						protocol = (Protocol)(&lockTaken);
						if (!flag7)
						{
							protocol = (Protocol)obj7;
							((LinkedList<System.__Canon>)(object)NetSimListOutgoing).Clear();
							object obj12 = (object)(&lockTaken);
							if (obj12 != null)
							{
								object obj13 = (object)(&obj3);
								Monitor.Exit(obj13);
								protocol = null;
							}
							obj = null;
							flag2 = false;
							obj2 = null;
							flag3 = false;
							obj8 = 0;
							obj9 = 0;
							ex = null;
							obj10 = (object)(&obj3);
							obj11 = (object)(&lockTaken);
							obj3 = NetSimListOutgoing;
							lockTaken = false;
							goto IL_0752;
						}
						goto IL_076f;
					}
				}
			}
		}
		goto IL_0744;
		IL_0760:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_076f;
		IL_0744:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0752;
		IL_076f:
		NullReferenceException ex3 = new NullReferenceException();
		NullReferenceException ex4 = new NullReferenceException();
		NullReferenceException ex5 = new NullReferenceException();
		if ((nint)protocol == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj9 = 1;
		}
		else
		{
			if ((nint)protocol != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj14 = default;
			ex = (OutOfMemoryException)obj14;
		}
		if (obj11 != null)
		{
			Monitor.Exit(obj10);
			protocol = null;
		}
		bool flag8 = ex == null;
		object obj15 = !flag8;
		if (obj15 != null)
		{
			goto IL_0752;
		}
		bool flag9 = obj9 == null;
		object obj16 = !flag9;
		OutOfMemoryException ex6 = ex;
		if (obj16 == null)
		{
			int num = Interlocked.Exchange(ref *(int*)(this + 64), 0);
			bool flag10 = watch == null;
			object obj8 = 0;
			protocol = null;
			if (!flag10)
			{
				watch.Reset();
				bool flag11 = watch == null;
				obj8 = 0;
				protocol = null;
				if (!flag11)
				{
					watch.Start();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					object obj17 = this + 256;
					ServerMaxQueueableReliableCommands__BackingField = 0;
					CryptoProvider = null;
					ApplicationIsInitialized = false;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					serverTimeOffsetIsAvailable = false;
					serverTimeOffset = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDF0]");
					roundTripTime = 0f;
					return;
				}
			}
			goto IL_0744;
		}
		goto IL_0760;
		IL_0752:
		ex6 = new OutOfMemoryException();
		goto IL_0760;
	}

	internal abstract bool Connect(string serverAddress, string proxyServerAddress, string appID, object photonToken);

	private unsafe string GetHttpKeyValueString(Dictionary<string, string> dic)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0353: Expected VT, but got I4
		//IL_035c: Expected VT, but got I4
		//IL_036a: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I4
		//IL_017c: Expected VT, but got Ref
		//IL_0185: Expected Obj, but got I4
		//IL_03bb: Expected Ref, but got VT
		//IL_03d5: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got VT
		//IL_0235: Expected Obj, but got I4
		//IL_024e: Expected VT, but got Ref
		//IL_00ab: Expected I, but got Obj
		//IL_01f5: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I4
		//IL_011c: Expected I, but got Obj
		//IL_0148: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		bool flag = (object)dic == null;
		string text2 = default;
		string text = text2;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		string text3 = null;
		object obj2 = 109924352;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCBE0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D45E0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1498]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCBD8]");
			obj2 = 0;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = ((Dictionary<System.__Canon, System.__Canon>)(object)dic).GetEnumerator();
			string text4 = default;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4 = default;
			object obj9 = default;
			string result = default;
			string result2 = default;
			while (true)
			{
				text3 = (string)obj3;
				if (enumerator.MoveNext())
				{
					if (stringBuilder != null)
					{
						StringBuilder stringBuilder2 = stringBuilder.Append(text2);
						bool flag2 = stringBuilder2 == null;
						nint num = unchecked((nint)null);
						text3 = text2;
						if (flag2)
						{
							goto IL_0216;
						}
						text3 = (string)obj4;
						StringBuilder stringBuilder3 = stringBuilder2.Append((string)obj4);
						if (stringBuilder3 != null)
						{
							StringBuilder stringBuilder4 = stringBuilder3.Append(text4);
							bool flag3 = stringBuilder4 == null;
							num = unchecked((nint)null);
							text3 = text4;
							if (!flag3)
							{
								StringBuilder stringBuilder5 = stringBuilder4.Append((string)value);
								num = unchecked((nint)null);
								continue;
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
							num = unchecked((nint)null);
						}
						NullReferenceException ex2 = new NullReferenceException();
					}
					NullReferenceException ex3 = new NullReferenceException();
					goto IL_0216;
				}
				text = null;
				enumerator = enumerator4;
				object obj5 = 0;
				string text5 = text2;
				enumerator2 = enumerator4;
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
				object obj6 = 0;
				while (true)
				{
					text3 = (string)obj2;
					((Dictionary<System.__Canon, System.__Canon>.Enumerator*)enumerator5)->Dispose();
					bool flag4 = obj6 == null;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						bool flag5 = text == null;
						object obj8 = !flag5;
						OutOfMemoryException ex4 = (OutOfMemoryException)enumerator5;
						if (obj8 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex4 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)text3 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						text = (string)1;
						obj6 = obj5;
						continue;
					}
					if ((nint)text3 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj6 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj5 = obj9;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FE74");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
				}
				if (stringBuilder == null)
				{
					break;
				}
				((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
				return result2;
				IL_0216:
				NullReferenceException ex5 = new NullReferenceException();
				text = null;
				enumerator = enumerator4;
				obj5 = 0;
				text5 = text2;
				enumerator2 = enumerator4;
				enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
				break;
			}
		}
		throw new NullReferenceException();
	}

	internal unsafe byte[] WriteInitRequest()
	{
		//IL_0051: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got Ref
		//IL_058a: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I
		//IL_05ac: Expected I, but got Obj
		//IL_05ce: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got Ref
		//IL_1a80: Expected Obj, but got I4
		//IL_1a95: Expected Obj, but got Ref
		//IL_0146: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_05f6: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got Ref
		//IL_16bc: Expected Obj, but got I4
		//IL_062c: Expected Obj, but got I4
		//IL_0641: Expected Obj, but got Ref
		//IL_1698: Expected Obj, but got I4
		//IL_169d: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_16e4: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I4
		//IL_06de: Expected Obj, but got Ref
		//IL_0243: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02ab: Expected I4, but got Obj
		//IL_0759: Expected Obj, but got I4
		//IL_076e: Expected Obj, but got Ref
		//IL_02f5: Expected I, but got Obj
		//IL_02fe: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got Ref
		//IL_07a3: Expected I, but got Obj
		//IL_07d0: Expected Obj, but got I
		//IL_07fa: Expected Obj, but got I4
		//IL_080f: Expected Obj, but got Ref
		//IL_0347: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_037e: Expected I4, but got Obj
		//IL_03b9: Expected I, but got Obj
		//IL_03c2: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got Ref
		//IL_0871: Expected Obj, but got I4
		//IL_0886: Expected Obj, but got Ref
		//IL_043c: Expected Obj, but got I
		//IL_0444: Expected I4, but got Obj
		//IL_08c6: Expected Obj, but got I4
		//IL_08d6: Expected Obj, but got I4
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_0912: Expected Obj, but got I4
		//IL_0927: Expected Obj, but got Ref
		//IL_0497: Expected I, but got Obj
		//IL_04a0: Expected Obj, but got I4
		//IL_04b5: Expected Obj, but got Ref
		//IL_0997: Expected Obj, but got I4
		//IL_09ac: Expected Obj, but got Ref
		//IL_1b8e: Expected Obj, but got I
		//IL_1ba8: Expected Obj, but got I
		//IL_1be3: Expected I4, but got Obj
		//IL_1bf5: Expected I, but got Obj
		//IL_1bfe: Expected Obj, but got I4
		//IL_1c13: Expected Obj, but got Ref
		//IL_141c: Expected Obj, but got I
		//IL_0514: Expected I, but got Obj
		//IL_051d: Expected Obj, but got I4
		//IL_0532: Expected Obj, but got Ref
		//IL_09e8: Expected I, but got Obj
		//IL_0a15: Expected Obj, but got I
		//IL_0a3f: Expected Obj, but got I4
		//IL_0a54: Expected Obj, but got Ref
		//IL_144f: Expected Obj, but got I
		//IL_1498: Expected I4, but got Obj
		//IL_1524: Expected Obj, but got I4
		//IL_1539: Expected Obj, but got Ref
		//IL_0aa2: Expected Obj, but got I8
		//IL_0ac8: Expected Obj, but got I4
		//IL_0add: Expected Obj, but got Ref
		//IL_14f1: Expected Obj, but got I4
		//IL_14fe: Expected I, but got Obj
		//IL_1565: Expected I, but got Obj
		//IL_15be: Expected Obj, but got I4
		//IL_15e1: Expected Obj, but got I4
		//IL_15f6: Expected Obj, but got Ref
		//IL_0b15: Expected Obj, but got I8
		//IL_0b3b: Expected Obj, but got I4
		//IL_0b50: Expected Obj, but got Ref
		//IL_1960: Expected Obj, but got I4
		//IL_0bb6: Expected Obj, but got I4
		//IL_0bcb: Expected Obj, but got Ref
		//IL_0c2a: Expected Obj, but got I4
		//IL_0c3a: Expected Obj, but got I4
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0c72: Expected I, but got Obj
		//IL_0c7b: Expected Obj, but got I4
		//IL_0c90: Expected Obj, but got Ref
		//IL_0cf8: Expected I, but got Obj
		//IL_0d01: Expected Obj, but got I4
		//IL_0d16: Expected Obj, but got Ref
		//IL_0d78: Expected I, but got Obj
		//IL_0d81: Expected Obj, but got I4
		//IL_0d96: Expected Obj, but got Ref
		//IL_0dde: Expected I, but got Obj
		//IL_0de7: Expected Obj, but got I4
		//IL_0dfc: Expected Obj, but got Ref
		//IL_0e44: Expected I, but got Obj
		//IL_0e4d: Expected Obj, but got I4
		//IL_0e62: Expected Obj, but got Ref
		//IL_0edf: Expected Obj, but got I4
		//IL_0efb: Expected I, but got Obj
		//IL_0f04: Expected Obj, but got I4
		//IL_0f19: Expected Obj, but got Ref
		//IL_0f59: Expected Obj, but got I4
		//IL_0f69: Expected Obj, but got I4
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Expected Obj, but got Unknown
		//IL_0fa1: Expected I, but got Obj
		//IL_0faa: Expected Obj, but got I4
		//IL_0fbf: Expected Obj, but got Ref
		//IL_101d: Expected I4, but got I8
		//IL_103f: Expected I, but got Obj
		//IL_1048: Expected Obj, but got I4
		//IL_105d: Expected Obj, but got Ref
		//IL_10a5: Expected I, but got Obj
		//IL_10ae: Expected Obj, but got I4
		//IL_10c3: Expected Obj, but got Ref
		//IL_1115: Expected Obj, but got I4
		//IL_1125: Expected Obj, but got I4
		//IL_1161: Unknown result type (might be due to invalid IL or missing references)
		//IL_1166: Expected Obj, but got Unknown
		//IL_1179: Expected I, but got Obj
		//IL_1182: Expected Obj, but got I4
		//IL_1197: Expected Obj, but got Ref
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eb: Expected Obj, but got Unknown
		//IL_122e: Expected Obj, but got I
		//IL_1236: Expected I4, but got Obj
		//IL_1727: Expected Obj, but got I4
		//IL_173c: Expected Obj, but got Ref
		//IL_1ad9: Expected Obj, but got I4
		//IL_1af4: Expected Obj, but got I4
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Expected I4, but got Unknown
		//IL_12cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d0: Expected I4, but got Unknown
		//IL_131b: Expected Obj, but got I4
		//IL_132b: Expected Obj, but got I4
		//IL_161d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1622: Expected Obj, but got Unknown
		//IL_1634: Expected Obj, but got I4
		//IL_1649: Expected Obj, but got Ref
		//IL_1368: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Expected Obj, but got Unknown
		//IL_1387: Expected Obj, but got I4
		//IL_139c: Expected Obj, but got Ref
		//IL_1b53: Expected Obj, but got I4
		//IL_1b68: Expected Obj, but got Ref
		//IL_13e4: Expected I4, but got I8
		PhotonPeer photonPeer = this.photonPeer;
		bool flag = this.photonPeer == null;
		object obj = null;
		bool lockTaken = false;
		if (flag)
		{
			goto IL_174a;
		}
		Monitor.Enter(photonPeer.enqueueLock, ref lockTaken);
		PhotonPeer photonPeer2 = this.photonPeer;
		bool flag2 = this.photonPeer == null;
		byte b = 0;
		Array array = null;
		nint num = (nint)(&lockTaken);
		object obj2 = 0;
		NullReferenceException ex = null;
		byte b2 = (byte)(&obj);
		object obj3 = (object)(&lockTaken);
		obj = photonPeer.enqueueLock;
		lockTaken = false;
		byte b3 = (byte)(&obj);
		if (flag2)
		{
			goto IL_176f;
		}
		int num2;
		byte[] result;
		int num5;
		if (~(photonPeer2.UseInitV3 ? 1u : 0u) == 0)
		{
			byte[] array2 = WriteInitV3();
			b = 0;
			array = null;
			num2 = (int)(&lockTaken);
			obj2 = 0;
			ex = null;
			b2 = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			obj = photonPeer.enqueueLock;
			lockTaken = false;
			b3 = (byte)(&obj);
			result = array2;
		}
		else
		{
			int num12;
			byte[] array3;
			if (PhotonToken == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163F0]");
				array3 = (byte[])0;
				nint num3 = (nint)array3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v84 (Il2CppClass<System.Byte[]>)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				nint num4 = num3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num4 = (nint)array3;
				}
				byte[] array4 = default;
				bool flag4 = array4 == null;
				b = 0;
				array = null;
				num = 41;
				obj2 = 0;
				ex = null;
				b2 = (byte)(&obj);
				obj3 = (object)(&lockTaken);
				obj = photonPeer.enqueueLock;
				lockTaken = false;
				num5 = (int)(&obj);
				if (flag4)
				{
					goto IL_1812;
				}
				bool flag5 = array4.Length == 0;
				b = 0;
				array = null;
				num = 41;
				obj2 = 0;
				ex = null;
				b2 = (byte)(&obj);
				obj3 = (object)(&lockTaken);
				obj = photonPeer.enqueueLock;
				lockTaken = false;
				num5 = (int)(&obj);
				if (flag5)
				{
					goto IL_1820;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v85 (Il2CppClass<System.Byte[]>)+A0]");
				object obj6 = 0;
				bool flag6 = array4.Length == 1;
				array3 = (byte[])obj6;
				array4[0] = 243;
				b = 0;
				array = null;
				num = 41;
				obj2 = 0;
				ex = null;
				b2 = (byte)(&obj);
				obj3 = (object)(&lockTaken);
				obj = photonPeer.enqueueLock;
				lockTaken = false;
				num5 = 243;
				if (flag6)
				{
					goto IL_182e;
				}
				array4[1] = 0;
				Protocol serializationProtocol = SerializationProtocol;
				bool flag7 = SerializationProtocol == null;
				b = 0;
				array = null;
				num = 41;
				obj2 = 0;
				ex = null;
				b2 = (byte)(&obj);
				obj3 = (object)(&lockTaken);
				obj = photonPeer.enqueueLock;
				lockTaken = false;
				num5 = 243;
				if (flag7)
				{
					goto IL_183c;
				}
				nint num6 = (nint)serializationProtocol;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v52 (Il2CppClass<Photon.Client.Protocol>)+188]");
				b3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v52 (Il2CppClass<Photon.Client.Protocol>)+190]");
				num = 0;
				int num7 = ((Enum)(object)SerializationProtocol).CompareTo((object)0);
				bool flag8 = num7 == 0;
				b = 0;
				array = null;
				obj2 = 0;
				ex = null;
				b2 = (byte)(&obj);
				obj3 = (object)(&lockTaken);
				obj = photonPeer.enqueueLock;
				lockTaken = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v52 (Il2CppClass<Photon.Client.Protocol>)+188]");
				num5 = 0;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v87 (System.Int32)+18]");
					bool flag9 = (nint)0 == 0;
					b = 0;
					array = null;
					obj2 = 0;
					ex = null;
					b2 = (byte)(&obj);
					obj3 = (object)(&lockTaken);
					obj = photonPeer.enqueueLock;
					lockTaken = false;
					if (!flag9)
					{
						bool flag10 = array4.Length < 2;
						object obj7 = !flag10;
						object obj8 = array4.Length - 2;
						bool flag11 = obj8 == null;
						object obj9 = ~obj7;
						object obj10 = obj9 | flag11;
						b = 0;
						array = null;
						obj2 = 0;
						ex = null;
						b2 = (byte)(&obj);
						obj3 = (object)(&lockTaken);
						obj = photonPeer.enqueueLock;
						lockTaken = false;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v87 (System.Int32)+20]");
							array4[2] = 0;
							Protocol serializationProtocol2 = SerializationProtocol;
							bool flag12 = SerializationProtocol == null;
							b = 0;
							array = null;
							obj2 = 0;
							ex = null;
							b2 = (byte)(&obj);
							obj3 = (object)(&lockTaken);
							obj = photonPeer.enqueueLock;
							lockTaken = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v52 (Il2CppClass<Photon.Client.Protocol>)+188]");
							num5 = 0;
							if (flag12)
							{
								goto IL_1858;
							}
							nint num8 = (nint)serializationProtocol2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v56 (Il2CppClass<Photon.Client.Protocol>)+188]");
							b3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v56 (Il2CppClass<Photon.Client.Protocol>)+190]");
							num = 0;
							int num9 = ((Enum)(object)SerializationProtocol).CompareTo((object)0);
							bool flag13 = num9 == 0;
							b = 0;
							array = null;
							obj2 = 0;
							ex = null;
							b2 = (byte)(&obj);
							obj3 = (object)(&lockTaken);
							obj = photonPeer.enqueueLock;
							lockTaken = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v56 (Il2CppClass<Photon.Client.Protocol>)+188]");
							num5 = 0;
							if (!flag13)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v89 (System.Int32)+18]");
								object obj11 = 0 & 0xFFFFFFFEL;
								bool flag14 = obj11 == null;
								b = 0;
								array = null;
								obj2 = 0;
								ex = null;
								b2 = (byte)(&obj);
								obj3 = (object)(&lockTaken);
								obj = photonPeer.enqueueLock;
								lockTaken = false;
								if (!flag14)
								{
									object obj12 = array4.Length & 0xFFFFFFFCL;
									bool flag15 = obj12 == null;
									b = 0;
									array = null;
									obj2 = 0;
									ex = null;
									b2 = (byte)(&obj);
									obj3 = (object)(&lockTaken);
									obj = photonPeer.enqueueLock;
									lockTaken = false;
									if (!flag15)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v89 (System.Int32)+21]");
										array4[3] = 0;
										bool flag16 = this.photonPeer == null;
										b = 0;
										array = null;
										obj2 = 0;
										ex = null;
										b2 = (byte)(&obj);
										obj3 = (object)(&lockTaken);
										obj = photonPeer.enqueueLock;
										lockTaken = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v56 (Il2CppClass<Photon.Client.Protocol>)+188]");
										num5 = 0;
										if (flag16)
										{
											goto IL_1874;
										}
										byte clientSdkIdShifted = this.photonPeer.ClientSdkIdShifted;
										bool flag17 = array4.Length < 4;
										object obj13 = !flag17;
										object obj14 = array4.Length - 4;
										bool flag18 = obj14 == null;
										object obj15 = ~obj13;
										object obj16 = obj15 | flag18;
										b = 0;
										array = null;
										num = unchecked((nint)null);
										obj2 = 0;
										ex = null;
										b2 = (byte)(&obj);
										obj3 = (object)(&lockTaken);
										obj = photonPeer.enqueueLock;
										lockTaken = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v56 (Il2CppClass<Photon.Client.Protocol>)+188]");
										num5 = 0;
										if (obj16 != null)
										{
											goto IL_1882;
										}
										array4[4] = clientSdkIdShifted;
										bool flag19 = obj6 == null;
										b = 0;
										array = null;
										num = unchecked((nint)null);
										obj2 = 0;
										ex = null;
										b2 = (byte)(&obj);
										obj3 = (object)(&lockTaken);
										obj = photonPeer.enqueueLock;
										lockTaken = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v56 (Il2CppClass<Photon.Client.Protocol>)+188]");
										num5 = 0;
										if (flag19)
										{
											goto IL_1890;
										}
										num5 = array3.Length;
										bool flag20 = array3.Length == 1;
										b = 0;
										array = null;
										num = unchecked((nint)null);
										obj2 = 0;
										ex = null;
										b2 = (byte)(&obj);
										obj3 = (object)(&lockTaken);
										obj = photonPeer.enqueueLock;
										lockTaken = false;
										if (flag20)
										{
											goto IL_189e;
										}
										bool flag21 = array3.Length == 0;
										b = 0;
										array = null;
										num = unchecked((nint)null);
										obj2 = 0;
										ex = null;
										b2 = (byte)(&obj);
										obj3 = (object)(&lockTaken);
										obj = photonPeer.enqueueLock;
										lockTaken = false;
										if (flag21)
										{
											goto IL_18ac;
										}
										bool flag22 = array4.Length == 5;
										b = 0;
										array = null;
										num = unchecked((nint)null);
										obj2 = 0;
										ex = null;
										b2 = (byte)(&obj);
										obj3 = (object)(&lockTaken);
										obj = photonPeer.enqueueLock;
										lockTaken = false;
										if (flag22)
										{
											goto IL_18ba;
										}
										int num10 = array3[1] | array3[0];
										array4[5] = (byte)num10;
										num5 = array3.Length;
										bool flag23 = array3.Length < 3;
										object obj17 = !flag23;
										object obj18 = ~obj17;
										b = 0;
										array = null;
										num = unchecked((nint)null);
										obj2 = 0;
										ex = null;
										b2 = (byte)(&obj);
										obj3 = (object)(&lockTaken);
										obj = photonPeer.enqueueLock;
										lockTaken = false;
										if (obj18 == null)
										{
											bool flag24 = array4.Length < 6;
											object obj19 = !flag24;
											object obj20 = array4.Length - 6;
											bool flag25 = obj20 == null;
											object obj21 = ~obj19;
											object obj22 = obj21 | flag25;
											b = 0;
											array = null;
											num = unchecked((nint)null);
											obj2 = 0;
											ex = null;
											b2 = (byte)(&obj);
											obj3 = (object)(&lockTaken);
											obj = photonPeer.enqueueLock;
											lockTaken = false;
											if (obj22 == null)
											{
												array4[6] = array3[2];
												num5 = array3.Length;
												int num11 = (int)(array3.Length & 0xFFFFFFFCL);
												bool flag26 = num11 == 0;
												b = 0;
												array = null;
												num = unchecked((nint)null);
												obj2 = 0;
												ex = null;
												b2 = (byte)(&obj);
												obj3 = (object)(&lockTaken);
												obj = photonPeer.enqueueLock;
												lockTaken = false;
												if (!flag26)
												{
													bool flag27 = array4.Length == 7;
													b = 0;
													array = null;
													num = unchecked((nint)null);
													obj2 = 0;
													ex = null;
													b2 = (byte)(&obj);
													obj3 = (object)(&lockTaken);
													obj = photonPeer.enqueueLock;
													lockTaken = false;
													if (!flag27)
													{
														b3 = array3[3];
														bool flag28 = array4.Length < 8;
														object obj23 = !flag28;
														object obj24 = array4.Length - 8;
														bool flag29 = obj24 == null;
														array4[7] = array3[3];
														object obj25 = ~obj23;
														object obj26 = obj25 | flag29;
														b = 0;
														array = null;
														num = unchecked((nint)null);
														obj2 = 0;
														ex = null;
														b2 = (byte)(&obj);
														obj3 = (object)(&lockTaken);
														obj = photonPeer.enqueueLock;
														lockTaken = false;
														num5 = array3[3];
														if (obj26 != null)
														{
															goto IL_18e4;
														}
														array4[8] = 0;
														array3 = (byte[])(this + 176);
														bool flag30 = string.IsNullOrEmpty((string)(object)array3);
														bool flag31 = !flag30;
														num2 = 0;
														if (!flag31)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163F8]");
															object obj27 = 0;
															num2 = (int)obj27;
															array3 = (byte[])obj27;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														}
														num12 = 0;
														array = null;
														while (true)
														{
															string text = (string)(object)array3;
															if (array3 != null)
															{
																if (num12 < text._stringLength)
																{
																	char c = ((string)(object)array3).get_Chars(num12);
																	array = null;
																	num2 = num12;
																}
																else
																{
																	char c = '\0';
																}
																b3 = (byte)array4.Length;
																object obj28 = num12 + 9;
																bool flag32 = (nint)obj28 < array4.Length;
																object obj29 = !flag32;
																num = num2;
																if (obj29 == null)
																{
																	b3 = (byte)(array4 + num12);
																	num12 = obj28 - 8;
																	if (num12 == 32)
																	{
																		break;
																	}
																	continue;
																}
															}
															else
															{
																NullReferenceException ex2 = new NullReferenceException();
																num = num2;
															}
															IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
															obj2 = 0;
															ex = null;
															b2 = (byte)(&obj);
															obj3 = (object)(&lockTaken);
															lockTaken = false;
															goto IL_174a;
														}
														bool isIpv = IsIpv6;
														bool flag33 = array4.Length < 5;
														object obj30 = !flag33;
														object obj31 = array4.Length - 5;
														bool flag34 = obj31 == null;
														int num13;
														if (isIpv)
														{
															object obj32 = ~obj30;
															object obj33 = obj32 | flag34;
															b = 0;
															num = num2;
															obj2 = 0;
															ex = null;
															b2 = (byte)(&obj);
															obj3 = (object)(&lockTaken);
															obj = photonPeer.enqueueLock;
															lockTaken = false;
															num5 = b3;
															if (obj33 != null)
															{
																goto IL_18f2;
															}
															num13 = (int)((int)array4[5] | 0xFFFFFF80L);
														}
														else
														{
															object obj34 = ~obj30;
															object obj35 = obj34 | flag34;
															b = 0;
															obj2 = 0;
															ex = null;
															b2 = (byte)(&obj);
															obj3 = (object)(&lockTaken);
															obj = photonPeer.enqueueLock;
															lockTaken = false;
															if (obj35 != null)
															{
																goto IL_1910;
															}
															num13 = array4[5] & 0x7F;
														}
														array4[5] = (byte)num13;
														b = 0;
														obj2 = 0;
														ex = null;
														b2 = (byte)(&obj);
														obj3 = (object)(&lockTaken);
														lockTaken = false;
														result = array4;
														goto IL_19ec;
													}
												}
												goto IL_18d6;
											}
										}
										goto IL_18c8;
									}
								}
								goto IL_179a;
							}
							goto IL_1866;
						}
					}
					goto IL_178c;
				}
				goto IL_184a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A00]");
			object obj37 = 0;
			num = (nint)obj37;
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			bool flag35 = dictionary == null;
			b = 0;
			array = null;
			obj2 = 0;
			ex = null;
			b2 = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			obj = photonPeer.enqueueLock;
			lockTaken = false;
			b3 = (byte)(&obj);
			if (flag35)
			{
				goto IL_17a8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516400]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A30]");
			array3 = (byte[])0;
			dictionary.set_Item((System.__Canon)key, (System.__Canon)null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516420]");
			object key2 = 0;
			dictionary.set_Item((System.__Canon)key2, (System.__Canon)(object)AppId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B38]");
			object obj38 = 0;
			object obj39 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X0_v113+E4]");
			bool flag36 = (nint)0 == 0;
			object obj40 = !flag36;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string version = PhotonPeer.Version;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516428]");
			object obj41 = 0;
			int num14 = (int)array3;
			dictionary.set_Item((System.__Canon)obj41, (System.__Canon)(object)version);
			Protocol serializationProtocol3 = SerializationProtocol;
			bool flag37 = SerializationProtocol == null;
			b = 0;
			array = (Array)(object)version;
			num = (nint)obj41;
			obj2 = 0;
			ex = null;
			b2 = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			obj = photonPeer.enqueueLock;
			lockTaken = false;
			b3 = (byte)(&obj);
			if (flag37)
			{
				goto IL_17b6;
			}
			nint num15 = (nint)serializationProtocol3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X8_v87 (Il2CppClass<Photon.Client.Protocol>)+178]");
			num5 = 0;
			System.__Canon _Canon = (System.__Canon)(object)((Enum)(object)SerializationProtocol).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515AD0]");
			object obj42 = 0;
			num14 = (int)array3;
			dictionary.set_Item((System.__Canon)obj42, _Canon);
			bool flag38 = this.photonPeer == null;
			b = 0;
			array = (Array)(object)_Canon;
			num = (nint)obj42;
			obj2 = 0;
			ex = null;
			b2 = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			obj = photonPeer.enqueueLock;
			lockTaken = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X8_v87 (Il2CppClass<Photon.Client.Protocol>)+178]");
			b3 = 0;
			if (flag38)
			{
				goto IL_17c4;
			}
			byte clientSdkIdShifted2 = this.photonPeer.ClientSdkIdShifted;
			string text2 = b.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516408]");
			object key3 = 0;
			num14 = (int)array3;
			dictionary.set_Item((System.__Canon)key3, (System.__Canon)(object)text2);
			PeerBase peerBase;
			if (PhotonToken != null)
			{
				bool flag39 = SerializationProtocol == null;
				array = (Array)(object)text2;
				num = (nint)PhotonToken;
				obj2 = 0;
				ex = null;
				b2 = (byte)(&obj);
				obj3 = (object)(&lockTaken);
				obj = photonPeer.enqueueLock;
				lockTaken = false;
				if (flag39)
				{
					goto IL_17f6;
				}
				byte[] array5 = SerializationProtocol.Serialize(PhotonToken);
				bool flag40 = array5 == null;
				array3 = array5;
				array = null;
				num = (nint)PhotonToken;
				obj2 = 0;
				ex = null;
				b2 = (byte)(&obj);
				obj3 = (object)(&lockTaken);
				obj = photonPeer.enqueueLock;
				lockTaken = false;
				if (flag40)
				{
					goto IL_1804;
				}
				num12 = array5.Length;
				array3 = array5;
				System.__Canon _Canon2 = null;
				peerBase = (PeerBase)(object)array5;
			}
			else
			{
				num12 = 0;
				array3 = null;
				System.__Canon _Canon2 = (System.__Canon)(object)text2;
				peerBase = (PeerBase)(object)dictionary;
			}
			string httpKeyValueString = peerBase.GetHttpKeyValueString((Dictionary<string, string>)(object)dictionary);
			bool isIpv2 = IsIpv6;
			bool flag41 = !isIpv2;
			string text3 = httpKeyValueString;
			if (!flag41)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516410]");
				object obj43 = 0;
				string text4 = httpKeyValueString + (string)obj43;
				System.__Canon _Canon2 = null;
				text3 = text4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516418]");
			object format = 0;
			object obj45 = default;
			string text5 = string.Format((string)format, text3, ServerAddress__BackingField, obj45);
			bool flag42 = text5 == null;
			int num16 = 0;
			num14 = (int)obj45;
			array = (Array)(object)ServerAddress__BackingField;
			num = (nint)text3;
			obj2 = 0;
			ex = null;
			b2 = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			obj = photonPeer.enqueueLock;
			lockTaken = false;
			if (flag42)
			{
				goto IL_17da;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj46 = 0;
			num5 = text5._stringLength;
			num = text5._stringLength + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag43 = array3 == null;
			num16 = 0;
			num14 = (int)obj45;
			array = (Array)(object)ServerAddress__BackingField;
			byte[] array6 = default;
			object obj47;
			if (!flag43)
			{
				num14 = text5._stringLength;
				num16 = array3.Length;
				Buffer.BlockCopy(array3, 0, array6, text5._stringLength, array3.Length);
				obj47 = 0;
				array = array6;
				num = unchecked((nint)null);
			}
			Encoding uTF = Encoding.UTF8;
			bool flag44 = uTF == null;
			obj2 = 0;
			ex = null;
			b2 = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			obj = photonPeer.enqueueLock;
			lockTaken = false;
			if (flag44)
			{
				goto IL_17e8;
			}
			nint num17 = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v99 (Il2CppClass<System.Text.Encoding>)+258]");
			b3 = 0;
			((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)text5, 0, num14);
			num16 = text5._stringLength;
			Array src = default;
			Buffer.BlockCopy(src, 0, array6, 0, text5._stringLength);
			obj47 = 0;
			num14 = 0;
			array = array6;
			num2 = 0;
			obj2 = 0;
			ex = null;
			b2 = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			lockTaken = false;
			result = array6;
		}
		goto IL_19ec;
		IL_18f2:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		num2 = (int)num;
		b3 = (byte)num5;
		goto IL_1910;
		IL_1890:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_189e;
		IL_18ac:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_18ba;
		IL_174a:
		NullReferenceException ex7 = new NullReferenceException();
		b = 0;
		goto IL_1761;
		IL_1866:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_1874;
		IL_1858:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_1866;
		IL_1874:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_1882;
		IL_182e:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		goto IL_183c;
		IL_184a:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_1858;
		IL_183c:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_184a;
		IL_1910:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		if (num2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if (num2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				byte[] result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj48 = default;
			ex = (NullReferenceException)obj48;
		}
		result = null;
		goto IL_19ec;
		IL_18ba:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		goto IL_18c8;
		IL_1882:
		IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
		goto IL_1890;
		IL_19ec:
		bool flag45 = obj3 == null;
		num = num2;
		if (!flag45)
		{
			Monitor.Exit(((byte*)(int)b2)->m_value);
			num = unchecked((nint)null);
		}
		bool flag46 = ex == null;
		object obj49 = !flag46;
		if (obj49 != null)
		{
			goto IL_1761;
		}
		bool flag47 = obj2 == null;
		object obj50 = !flag47;
		NullReferenceException ex17 = ex;
		if (obj50 == null)
		{
			return result;
		}
		goto IL_177d;
		IL_18d6:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_18e4;
		IL_18c8:
		IndexOutOfRangeException ex19 = new IndexOutOfRangeException();
		goto IL_18d6;
		IL_1761:
		OutOfMemoryException ex20 = new OutOfMemoryException();
		goto IL_176f;
		IL_176f:
		ex17 = new NullReferenceException();
		goto IL_177d;
		IL_18e4:
		IndexOutOfRangeException ex21 = new IndexOutOfRangeException();
		goto IL_18f2;
		IL_177d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_178c;
		IL_178c:
		IndexOutOfRangeException ex22 = new IndexOutOfRangeException();
		goto IL_179a;
		IL_179a:
		IndexOutOfRangeException ex23 = new IndexOutOfRangeException();
		goto IL_17a8;
		IL_17a8:
		NullReferenceException ex24 = new NullReferenceException();
		goto IL_17b6;
		IL_17b6:
		NullReferenceException ex25 = new NullReferenceException();
		goto IL_17c4;
		IL_17c4:
		NullReferenceException ex26 = new NullReferenceException();
		num5 = b3;
		goto IL_17da;
		IL_17da:
		NullReferenceException ex27 = new NullReferenceException();
		goto IL_17e8;
		IL_17e8:
		NullReferenceException ex28 = new NullReferenceException();
		goto IL_17f6;
		IL_17f6:
		NullReferenceException ex29 = new NullReferenceException();
		goto IL_1804;
		IL_1812:
		NullReferenceException ex30 = new NullReferenceException();
		goto IL_1820;
		IL_1804:
		NullReferenceException ex31 = new NullReferenceException();
		goto IL_1812;
		IL_1820:
		IndexOutOfRangeException ex32 = new IndexOutOfRangeException();
		goto IL_182e;
		IL_189e:
		IndexOutOfRangeException ex33 = new IndexOutOfRangeException();
		goto IL_18ac;
	}

	private unsafe byte[] WriteInitV3()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_079d: Expected Obj, but got I4
		//IL_07aa: Expected I4, but got Obj
		//IL_00a7: Expected Obj, but got I4
		//IL_00c2: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I8
		//IL_0807: Expected Obj, but got I
		//IL_083e: Expected Obj, but got I4
		//IL_085c: Expected Obj, but got I
		//IL_088d: Expected Obj, but got I4
		//IL_08a7: Expected I4, but got Obj
		//IL_0697: Expected I, but got Obj
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I
		//IL_0261: Expected I4, but got Obj
		//IL_02c1: Expected I, but got Obj
		//IL_02c9: Expected I4, but got Obj
		//IL_0305: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I4
		//IL_0494: Expected I4, but got Obj
		//IL_0426: Expected Obj, but got I4
		//IL_0441: Expected I4, but got Obj
		//IL_0541: Expected Obj, but got I4
		//IL_04da: Expected I4, but got Obj
		//IL_056a: Expected I4, but got Obj
		//IL_04f8: Expected Obj, but got I
		//IL_0500: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StreamBuffer streamBuffer = default;
		streamBuffer._002Ector(0);
		bool flag = streamBuffer == null;
		byte b = 0;
		int num = 0;
		if (!flag)
		{
			streamBuffer.WriteByte(245);
			bool isIpv = IsIpv6;
			PhotonPeer photonPeer = this.photonPeer;
			bool flag2 = this.photonPeer == null;
			b = 0;
			num = 245;
			if (!flag2)
			{
				bool flag3 = !isIpv;
				object obj2 = !flag3;
				object obj3 = ~obj2;
				object obj4 = ((obj3 != null) ? ((object)0) : ((object)2));
				bool flag4 = photonPeer.Encryptor == null;
				object obj5 = !flag4;
				b = (byte)(obj4 | obj5);
				streamBuffer.WriteBytes(0, b);
				Protocol serializationProtocol = SerializationProtocol;
				bool flag5 = SerializationProtocol == null;
				int num2 = 0;
				num = 0;
				if (!flag5)
				{
					nint num3 = (nint)serializationProtocol;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v12 (Il2CppClass<Photon.Client.Protocol>)+190]");
					num = 0;
					int num4 = ((Enum)(object)SerializationProtocol).CompareTo((object)0);
					bool flag6 = num4 == 0;
					num2 = 0;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v50 (System.Int32)+18]");
						object obj6 = 0 & 0xFFFFFFFEL;
						bool flag7 = obj6 == null;
						num2 = 0;
						if (flag7)
						{
							goto IL_05af;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v50 (System.Int32)+21]");
						byte value;
						if ((nint)0 != 6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v50 (System.Int32)+21]");
							bool flag8 = (nint)0 != 8;
							num2 = 0;
							Exception ex = (Exception)(object)this;
							if (flag8)
							{
								string message = ex._message;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
								nint num5 = (nint)message;
								int hashCode = ((ValueType)ex._message).GetHashCode();
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB354");
								byte b2 = default;
								string text = ((byte*)b2)->ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								string text2 = default;
								string message2 = text2 + text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Exception ex2 = default;
								ex2._002Ector(message2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								return (byte[])(object)new ArgumentNullException();
							}
							value = 18;
						}
						else
						{
							value = 16;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163F0]");
						object obj7 = 0;
						streamBuffer.WriteByte(value);
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v53+E4]");
						bool flag9 = (nint)0 == 0;
						object obj9 = !flag9;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj8 = obj7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v53+A0]");
						object obj10 = 0;
						streamBuffer.Write((byte[])obj10, 0, 4);
						bool flag10 = this.photonPeer == null;
						object obj11 = 0;
						num2 = 4;
						b = 0;
						num = (int)obj10;
						if (!flag10)
						{
							byte clientSdkIdShifted = this.photonPeer.ClientSdkIdShifted;
							streamBuffer.WriteByte(clientSdkIdShifted);
							streamBuffer.WriteByte(0);
							object obj12 = this + 176;
							bool flag11 = string.IsNullOrEmpty((string)obj12);
							bool flag12 = !flag11;
							num = 0;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164D0]");
								object obj13 = 0;
								num = (int)obj13;
								obj12 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							Encoding uTF = Encoding.UTF8;
							bool flag13 = uTF == null;
							obj11 = 0;
							num2 = 4;
							b = 0;
							if (!flag13)
							{
								nint num6 = (nint)uTF;
								num = (int)obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v18 (Il2CppClass<System.Text.Encoding>)+260]");
								b = 0;
								((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])obj12, 0, 4);
								byte[] array = default;
								bool flag14 = array == null;
								obj11 = 0;
								num2 = 4;
								if (!flag14)
								{
									bool flag15 = array.Length >= 256;
									obj11 = 0;
									num2 = 4;
									num = array.Length;
									if (!flag15)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515C20]");
										object obj15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164C8]");
										object obj16 = 0;
										streamBuffer.WriteByte((byte)array.Length);
										streamBuffer.Write(array, 0, array.Length);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										byte[] array2 = default;
										if (array2 != null)
										{
											byte v = (byte)(array2.Length >> 8);
											streamBuffer.WriteBytes(v, (byte)array2.Length);
											streamBuffer.Write(array2, 0, array2.Length);
											obj11 = 0;
											num2 = array2.Length;
											byte b3 = 0;
											byte b4 = (byte)(int)array2;
										}
										else
										{
											streamBuffer.WriteBytes(0, 0);
											obj11 = 0;
											num2 = 0;
											byte b3 = 0;
											byte b4 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										num = (int)obj16;
										Dictionary<byte, System.__Canon> dictionary = default;
										dictionary._002Ector();
										if (CustomInitData != null)
										{
											bool flag16 = dictionary == null;
											b = (byte)(int)CustomInitData;
											if (flag16)
											{
												goto IL_05a1;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164C0]");
											object obj17 = 0;
											num2 = (int)obj17;
											dictionary.Add(0, (System.__Canon)CustomInitData);
											num = 0;
										}
										bool flag17 = photonPeer.Encryptor == null;
										object obj18 = !flag17;
										if (obj18 == null)
										{
											bool flag18 = SerializationProtocol == null;
											b = (byte)(int)CustomInitData;
											if (!flag18)
											{
												string text3 = ((Enum)(object)SerializationProtocol).ToString((string)(object)streamBuffer, (IFormatProvider)dictionary);
												return streamBuffer.ToArray();
											}
											goto IL_05a1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Exception ex3 = default;
										string text4 = default;
										((NotImplementedException)ex3)._002Ector(text4);
										b = 0;
										string text5 = text4;
										Exception ex = ex3;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Exception ex4 = default;
										string text6 = default;
										ex4._002Ector(text6);
										b = 0;
										string text5 = text6;
										Exception ex = ex4;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									int num7 = default;
									num = num7;
									throw new ArgumentNullException();
								}
							}
						}
					}
				}
			}
		}
		goto IL_05a1;
		IL_05af:
		throw new IndexOutOfRangeException();
		IL_05a1:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_05af;
	}

	internal string PrepareWebSocketUrl(string serverAddress, string appId, object photonToken)
	{
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_04fe: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I
		//IL_046c: Expected Obj, but got I
		//IL_038b: Expected Obj, but got I
		object obj = this + 248;
		StringBuilder stringBuilder = (StringBuilder)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		string text = appId;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			StringBuilder stringBuilder2 = default;
			stringBuilder2._002Ector(256);
			obj = stringBuilder2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			stringBuilder = (StringBuilder)obj;
			bool flag2 = obj == null;
			text = null;
			if (flag2)
			{
				goto IL_04c3;
			}
		}
		StringBuilder stringBuilder3 = stringBuilder.Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		int num = prepareWebSocketUrlCount + 1;
		prepareWebSocketUrlCount = num;
		if (prepareWebSocketUrlSB != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B38]");
			object obj4 = 0;
			StringBuilder stringBuilder4 = prepareWebSocketUrlSB.Append(serverAddress);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string version = PhotonPeer.Version;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516510]");
				object format = 0;
				StringBuilder stringBuilder5 = ((StringBuilder)obj).AppendFormat((string)format, (object)version);
				if (this.photonPeer != null)
				{
					byte clientSdkIdShifted = this.photonPeer.ClientSdkIdShifted;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					if (prepareWebSocketUrlSB != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516508]");
						object format2 = 0;
						object arg = default;
						StringBuilder stringBuilder6 = prepareWebSocketUrlSB.AppendFormat((string)format2, arg);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						if (prepareWebSocketUrlSB != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516500]");
							object format3 = 0;
							object obj8 = default;
							object obj9 = default;
							StringBuilder stringBuilder7 = prepareWebSocketUrlSB.AppendFormat((string)format3, obj8, obj9);
							PhotonPeer photonPeer = this.photonPeer;
							if (this.photonPeer != null)
							{
								bool flag4 = appId == null;
								object obj10 = obj9;
								object obj11 = obj8;
								if (!flag4)
								{
									bool flag5 = (byte)(~(photonPeer.RemoveAppIdFromWebSocketPath ? 1u : 0u)) != 0;
									object obj12 = !flag5;
									obj10 = obj9;
									obj11 = obj8;
									if (obj12 == null)
									{
										bool flag6 = appId._stringLength < 8;
										obj10 = obj9;
										obj11 = obj8;
										if (!flag6)
										{
											string text2 = appId.Substring(0, 8);
											if (obj == null)
											{
												goto IL_04c3;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164F8]");
											object format4 = 0;
											StringBuilder stringBuilder8 = ((StringBuilder)obj).AppendFormat((string)format4, (object)text2);
											obj10 = null;
											obj11 = text2;
										}
									}
								}
								if (IsIpv6)
								{
									if (obj == null)
									{
										goto IL_04c3;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516410]");
									object value = 0;
									StringBuilder stringBuilder9 = ((StringBuilder)obj).Append((string)value);
									obj11 = null;
								}
								if (photonToken != null)
								{
									if (obj == null)
									{
										goto IL_04c3;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516518]");
									object value2 = 0;
									StringBuilder stringBuilder10 = ((StringBuilder)obj).Append((string)value2);
									obj11 = null;
								}
								object obj13 = obj;
								if (obj != null)
								{
									object obj14 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X8_v19+168] (should have been resolved before IL gen)");
									string result = default;
									return result;
								}
							}
						}
					}
				}
			}
		}
		goto IL_04c3;
		IL_04c3:
		return (string)(object)new NullReferenceException();
	}

	public void OnConnect()
	{
	}

	internal unsafe void OnInitResponse()
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Ref, but got Unknown
		//IL_003b: Expected Obj, but got I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0068: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		int num = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
		int num2 = num & 0xFF;
		if (num2 == 1)
		{
			int num3 = Interlocked.Exchange(ref *(int*)(this + 64), 3);
		}
		ApplicationIsInitialized = true;
		uint num4 = ((Enum)this).System_002EIConvertible_002EToUInt32((IFormatProvider)0);
		PhotonPeer photonPeer = this.photonPeer;
		IPhotonPeerListener photonPeerListener = photonPeer.Listener__BackingField;
		nint num5 = (nint)photonPeerListener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0104;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj2--;
			obj3 += 16;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_0104;
		}
		object obj4 = obj3 + 2;
		object obj5 = num5 + obj4;
		object obj6 = obj5 + 312;
		goto IL_01b6;
		IL_01b6:
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v111 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0104:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01b6;
	}

	internal abstract void Disconnect(bool queueStatusChangeCallback = default(bool));

	internal abstract void SimulateTimeoutDisconnect(bool queueStatusChangeCallback = default(bool));

	internal abstract void FetchServerTimestamp();

	internal abstract bool IsTransportEncrypted();

	internal abstract bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams);

	internal StreamBuffer SerializeOperationToMessage(byte opCode, ParameterDictionary parameters, EgMessageType messageType, bool encrypt)
	{
		//IL_0537: Expected Obj, but got I
		//IL_0042: Expected I8, but got I4
		//IL_057e: Expected Obj, but got I4
		//IL_000a: Expected I, but got Obj
		//IL_0022: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected I8, but got I4
		//IL_0107: Expected I, but got Obj
		//IL_032c: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected I8, but got Unknown
		//IL_016a: Expected I, but got Obj
		//IL_017a: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I4
		//IL_05c8: Expected I8, but got I4
		//IL_01c5: Expected Obj, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_039f: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_04b5: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj = 0;
		long num3;
		if (encrypt)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v33 (Il2CppClass<Photon.Client.PeerBase>)+200]");
			byte b = 0;
			long num2 = ((Enum)this).System_002EIConvertible_002EToInt64((IFormatProvider)0);
			num3 = num2 ^ 1;
		}
		else
		{
			num3 = 0L;
			byte b = opCode;
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+8]");
		StreamBuffer streamBuffer = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516208]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
			if (streamBuffer != null)
			{
				streamBuffer.SetLength(0L);
				long num4 = num3 & 1;
				if (num4 != 0)
				{
					Protocol serializationProtocol = SerializationProtocol;
					if (SerializationProtocol != null)
					{
						nint num5 = (nint)serializationProtocol;
						sbyte b2 = ((Enum)(object)SerializationProtocol).System_002EIConvertible_002EToSByte((IFormatProvider)streamBuffer);
						ICryptoProvider cryptoProvider = CryptoProvider;
						byte[] buffer = streamBuffer.GetBuffer();
						int length = streamBuffer.Length;
						if (CryptoProvider != null)
						{
							nint num6 = (nint)cryptoProvider;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516520]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v28 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v28 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0206;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v28 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+98]");
							object obj8 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X10_v10-8]");
								if (0 == (nint)obj6)
								{
									break;
								}
								obj7--;
								obj8 += 16;
								if ((nint)obj7 != 1)
								{
									continue;
								}
								goto IL_0206;
							}
							object obj9 = obj8 + 4;
							object obj10 = num6 + obj9;
							object obj11 = obj10 + 312;
							goto IL_05b0;
						}
					}
				}
				else
				{
					byte[] array = messageHeader;
					if (messageHeader != null)
					{
						streamBuffer.Write(messageHeader, 0, array.Length);
						if (SerializationProtocol != null)
						{
							sbyte b3 = ((Enum)(object)SerializationProtocol).System_002EIConvertible_002EToSByte((IFormatProvider)streamBuffer);
							goto IL_0311;
						}
					}
				}
			}
		}
		goto IL_050b;
		IL_050b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0519;
		IL_0519:
		return (StreamBuffer)(object)new IndexOutOfRangeException();
		IL_045f:
		byte[] array2 = messageHeader;
		byte[] buffer2;
		if (messageHeader == null || buffer2 == null)
		{
			goto IL_050b;
		}
		object obj12 = array2.Length - 1;
		bool flag2 = (nint)obj12 < buffer2.Length;
		object obj13 = !flag2;
		if (obj13 != null)
		{
			goto IL_0519;
		}
		object obj14 = (object)buffer2 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v19+20]");
		object obj15 = (nint)0 | (nint)0x80;
		goto IL_0634;
		IL_0634:
		return streamBuffer;
		IL_0311:
		buffer2 = streamBuffer.GetBuffer();
		object obj16 = messageType & (EgMessageType)0xFF;
		if ((nint)obj16 != 2)
		{
			byte[] array3 = messageHeader;
			if (messageHeader == null || buffer2 == null)
			{
				goto IL_050b;
			}
			object obj17 = array3.Length - 1;
			bool flag3 = (nint)obj17 < buffer2.Length;
			object obj18 = !flag3;
			if (obj18 != null)
			{
				goto IL_0519;
			}
			object obj19 = (object)buffer2 + obj17;
		}
		object obj20 = !encrypt;
		long num7 = num3 | obj20;
		long num8 = num7 & 1;
		if (num8 != 0)
		{
			long num9 = num3 & 1;
			bool flag4 = num9 == 0;
			object obj21 = !flag4;
			if (obj21 != null)
			{
				goto IL_045f;
			}
		}
		else
		{
			PhotonPeer photonPeer = this.photonPeer;
			if (this.photonPeer == null)
			{
				goto IL_050b;
			}
			if (~(photonPeer.EnableEncryptedFlag ? 1u : 0u) == 0)
			{
				goto IL_045f;
			}
		}
		goto IL_0634;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_05b0;
		IL_05b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v412 @ X0_v24] (should have been resolved before IL gen)");
		streamBuffer.SetLength(0L);
		byte[] array4 = messageHeader;
		if (messageHeader != null)
		{
			streamBuffer.Write(messageHeader, 0, array4.Length);
			byte[] array5 = default;
			if (array5 != null)
			{
				streamBuffer.Write(array5, 0, array5.Length);
				goto IL_0311;
			}
		}
		goto IL_050b;
	}

	internal StreamBuffer SerializeMessageToMessage(object message, bool encrypt)
	{
		//IL_064f: Expected Obj, but got I
		//IL_0042: Expected I8, but got I4
		//IL_0696: Expected Obj, but got I4
		//IL_000a: Expected I, but got Obj
		//IL_001a: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_073b: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected I8, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_0481: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I4
		//IL_02d0: Expected I, but got Obj
		//IL_02e0: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_0496: Expected Obj, but got I4
		//IL_04b1: Expected Obj, but got I4
		//IL_06e0: Expected I8, but got I4
		//IL_032b: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I4
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected I8, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_053c: Expected Obj, but got I4
		//IL_05cd: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj = 0;
		long num3;
		if (encrypt)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v28 (Il2CppClass<Photon.Client.PeerBase>)+200]");
			object obj2 = 0;
			long num2 = ((Enum)this).System_002EIConvertible_002EToInt64((IFormatProvider)0);
			num3 = num2 ^ 1;
		}
		else
		{
			num3 = 0L;
			object obj2 = message;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+8]");
		StreamBuffer streamBuffer = default;
		object obj10 = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516208]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
			if (streamBuffer != null)
			{
				streamBuffer.SetLength(0L);
				long num4 = num3 & 1;
				bool flag2 = num4 == 0;
				object obj7 = !flag2;
				IntPtr intPtr = default;
				int num5 = (int)(nint)intPtr;
				int num6 = 0;
				if (obj7 == null)
				{
					byte[] array = messageHeader;
					if (messageHeader == null)
					{
						goto IL_0623;
					}
					num5 = array.Length;
					streamBuffer.Write(messageHeader, 0, array.Length);
					object obj8 = 0;
					num6 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					byte[] array2 = default;
					if (array2 != null)
					{
						int num7 = array2.Length;
						streamBuffer.Write(array2, 0, array2.Length);
						long num8 = num3 & 1;
						bool flag3 = num8 == 0;
						object obj11 = !flag3;
						object obj8 = 0;
						if (obj11 != null)
						{
							goto IL_0280;
						}
						goto IL_03fd;
					}
				}
				else if (SerializationProtocol != null)
				{
					SerializationProtocol.SerializeMessage(streamBuffer, message);
					long num9 = num3 & 1;
					bool flag4 = num9 == 0;
					int num7 = 0;
					if (!flag4)
					{
						goto IL_0280;
					}
					goto IL_03fd;
				}
			}
		}
		goto IL_0623;
		IL_0726:
		return streamBuffer;
		IL_0623:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0631;
		IL_03fd:
		byte[] buffer = streamBuffer.GetBuffer();
		byte[] array3 = messageHeader;
		if (messageHeader != null)
		{
			bool flag5 = obj10 == null;
			object obj12 = !flag5;
			object obj13 = ~obj12;
			if (obj13 == null)
			{
				object obj14 = 8 + 1;
			}
			else
			{
				object obj14 = 8;
			}
			if (buffer != null)
			{
				object obj15 = array3.Length - 1;
				bool flag6 = (nint)obj15 < buffer.Length;
				object obj16 = !flag6;
				if (obj16 != null)
				{
					goto IL_0631;
				}
				object obj17 = (object)buffer + obj15;
				object obj18 = !encrypt;
				long num10 = num3 | obj18;
				long num11 = num10 & 1;
				if (num11 != 0)
				{
					long num12 = num3 & 1;
					bool flag7 = num12 == 0;
					object obj19 = !flag7;
					if (obj19 != null)
					{
						goto IL_0594;
					}
				}
				else
				{
					PhotonPeer photonPeer = this.photonPeer;
					if (this.photonPeer == null)
					{
						goto IL_0623;
					}
					if (~(photonPeer.EnableEncryptedFlag ? 1u : 0u) == 0)
					{
						goto IL_0594;
					}
				}
				goto IL_0726;
			}
		}
		goto IL_0623;
		IL_0631:
		return (StreamBuffer)(object)new IndexOutOfRangeException();
		IL_06c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v426 @ X0_v23] (should have been resolved before IL gen)");
		streamBuffer.SetLength(0L);
		byte[] array4 = messageHeader;
		if (messageHeader != null)
		{
			streamBuffer.Write(messageHeader, 0, array4.Length);
			byte[] array5 = default;
			if (array5 != null)
			{
				streamBuffer.Write(array5, 0, array5.Length);
				goto IL_03fd;
			}
		}
		goto IL_0623;
		IL_036c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_06c8;
		IL_0280:
		ICryptoProvider cryptoProvider = CryptoProvider;
		byte[] buffer2 = streamBuffer.GetBuffer();
		int length = streamBuffer.Length;
		if (CryptoProvider == null)
		{
			goto IL_0623;
		}
		nint num13 = (nint)cryptoProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516520]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v23 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v23 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_036c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v23 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+98]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X10_v12-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj21--;
			obj22 += 16;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_036c;
		}
		object obj23 = obj22 + 4;
		object obj24 = num13 + obj23;
		object obj25 = obj24 + 312;
		goto IL_06c8;
		IL_0594:
		byte[] array6 = messageHeader;
		if (messageHeader == null)
		{
			goto IL_0623;
		}
		object obj26 = array6.Length - 1;
		bool flag8 = (nint)obj26 < buffer.Length;
		object obj27 = !flag8;
		if (obj27 != null)
		{
			goto IL_0631;
		}
		object obj28 = (object)buffer + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v18+20]");
		object obj29 = (nint)0 | (nint)0x80;
		goto IL_0726;
	}

	internal abstract bool SendOutgoingCommands();

	internal virtual bool SendAcksOnly()
	{
		return false;
	}

	internal abstract void ReceiveIncomingCommands(byte[] inBuff, int dataLength);

	internal abstract bool DispatchIncomingCommands();

	internal unsafe virtual bool DeserializeMessageAndCallback(StreamBuffer stream)
	{
		//IL_029c: Expected I4, but got I8
		//IL_02b6: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_02d7: Expected I8, but got I4
		//IL_02e0: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_02ee: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_06b4: Expected I, but got Obj
		//IL_0526: Expected I, but got Obj
		//IL_0536: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I
		//IL_03cd: Expected I, but got Obj
		//IL_0134: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_16ab: Expected Obj, but got I
		//IL_16d3: Expected Obj, but got I
		//IL_16ef: Expected I, but got Obj
		//IL_0581: Expected Obj, but got I
		//IL_03f3: Expected I, but got Obj
		//IL_0403: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_045e: Expected Obj, but got I
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_0f1c: Expected I, but got Obj
		//IL_0e4d: Expected I, but got Obj
		//IL_0d35: Expected I, but got Obj
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0f97: Expected I, but got Obj
		//IL_149a: Unknown result type (might be due to invalid IL or missing references)
		//IL_149f: Expected Obj, but got Unknown
		//IL_08c5: Expected I, but got Obj
		//IL_08cf: Expected I, but got Obj
		//IL_08df: Expected Obj, but got I
		//IL_08f2: Expected Obj, but got I4
		//IL_0e78: Expected I, but got Obj
		//IL_0b4b: Expected I, but got Obj
		//IL_0d96: Expected I, but got Obj
		//IL_153f: Expected Obj, but got I4
		//IL_0fd9: Expected Obj, but got I
		//IL_0ff3: Expected I, but got I8
		//IL_0ffb: Expected Obj, but got I4
		//IL_0cb2: Expected Obj, but got I
		//IL_0ccc: Expected Obj, but got I
		//IL_0749: Expected I, but got Obj
		//IL_076c: Expected Obj, but got I8
		//IL_078a: Expected I, but got Obj
		//IL_1553: Expected I, but got Obj
		//IL_094a: Expected I, but got Obj
		//IL_0eba: Expected Obj, but got I
		//IL_0ed9: Expected I, but got Obj
		//IL_0ee1: Expected Obj, but got I4
		//IL_0b8a: Expected Obj, but got I
		//IL_0dd0: Expected Obj, but got I
		//IL_07b8: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I4
		//IL_0994: Expected Obj, but got I
		//IL_09c9: Expected I, but got Obj
		//IL_1734: Expected Obj, but got I
		//IL_10a3: Expected Obj, but got I4
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected I4, but got Unknown
		//IL_0a12: Expected I, but got Obj
		//IL_0c35: Expected Obj, but got I4
		//IL_0816: Expected I, but got Obj
		//IL_0826: Expected Obj, but got I4
		//IL_131a: Expected I, but got Obj
		//IL_132a: Expected Obj, but got I4
		//IL_10d3: Expected Obj, but got I
		//IL_0a5b: Expected I, but got Obj
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Expected Ref, but got Unknown
		//IL_111f: Expected I, but got Obj
		//IL_1124: Expected I, but got Obj
		//IL_1351: Expected I, but got Obj
		//IL_1361: Expected Obj, but got I4
		//IL_1235: Expected Obj, but got I
		//IL_123a: Expected I, but got Obj
		//IL_126b: Expected Obj, but got I4
		//IL_127c: Expected Obj, but got I4
		//IL_1147: Expected Obj, but got I4
		//IL_115e: Expected I, but got Obj
		//IL_1163: Expected I, but got Obj
		//IL_138c: Expected Obj, but got I
		//IL_12a7: Expected Obj, but got I
		//IL_12c8: Expected Obj, but got I4
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected Obj, but got Unknown
		//IL_13b9: Expected I, but got Obj
		//IL_13c2: Expected Obj, but got I4
		//IL_13ca: Expected Obj, but got I4
		//IL_1196: Expected I, but got Obj
		//IL_119b: Expected I, but got Obj
		//IL_11a8: Expected Obj, but got I4
		//IL_12e5: Expected I, but got Obj
		//IL_12f5: Expected Obj, but got I4
		//IL_11c6: Expected Obj, but got I
		//IL_11ee: Expected Obj, but got I
		//IL_11fc: Expected I, but got Obj
		//IL_1210: Expected I, but got Obj
		//IL_1218: Expected I, but got Obj
		bool flag = stream == null;
		object obj = stream;
		StreamBuffer streamBuffer = stream;
		string text;
		nint num2;
		object obj9;
		int num4;
		StreamBuffer streamBuffer2;
		int length3;
		string text2;
		nint num8;
		object obj17;
		nint num;
		if (!flag)
		{
			int length = stream.Length;
			if (length <= 1)
			{
				PhotonPeer photonPeer = this.photonPeer;
				bool flag2 = this.photonPeer == null;
				obj = null;
				streamBuffer = stream;
				if (!flag2)
				{
					bool flag3 = (int)photonPeer.LogLevel < 4;
					object obj2 = !flag3;
					object obj3 = ~obj2;
					if (obj3 != null)
					{
						goto IL_15fa;
					}
					IPhotonPeerListener photonPeerListener = photonPeer.Listener__BackingField;
					int length2 = stream.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516540]");
					object format = 0;
					object obj5 = default;
					text = string.Format((string)format, obj5);
					bool flag4 = photonPeer.Listener__BackingField == null;
					num = unchecked((nint)null);
					obj = obj5;
					streamBuffer = stream;
					if (!flag4)
					{
						num2 = (nint)photonPeerListener;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						object obj7 = 0;
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						bool flag5 = (nint)0 == 0;
						text2 = text;
						if (flag5)
						{
							goto IL_04a7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
						obj9 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X10_v7-8]");
							bool flag6 = 0 == (nint)obj8;
							text2 = text;
							if (flag6)
							{
								break;
							}
							obj7--;
							obj9 += 16;
							if ((nint)obj7 != 1)
							{
								continue;
							}
							goto IL_01e0;
						}
						goto IL_04b6;
					}
				}
			}
			else
			{
				byte b = stream.ReadByte();
				int num3 = b & 0xFF;
				if (num3 == 243 || num3 == 253)
				{
					byte b2 = stream.ReadByte();
					num4 = b2 & 0x7F;
					bool flag7 = num4 == 1;
					obj = null;
					streamBuffer2 = stream;
					if (!flag7)
					{
						int num5 = (int)((int)b2 & 0x80000000L);
						bool flag8 = num5 == 0;
						object obj10 = !flag8;
						if (obj10 != null)
						{
							ICryptoProvider cryptoProvider = CryptoProvider;
							byte[] buffer = stream.GetBuffer();
							length3 = stream.Length;
							if (CryptoProvider != null)
							{
								nint num6 = (nint)cryptoProvider;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516520]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v86 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v86 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_05c2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v86 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+98]");
								object obj13 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X10_v29-8]");
									if (0 == (nint)obj11)
									{
										break;
									}
									obj12--;
									obj13 += 16;
									if ((nint)obj12 != 1)
									{
										continue;
									}
									goto IL_05c2;
								}
								object obj14 = obj13 + 6;
								object obj15 = num6 + obj14;
								object obj16 = obj15 + 312;
								goto IL_169b;
							}
							NullReferenceException ex = new NullReferenceException();
							obj17 = null;
							goto IL_13e2;
						}
						long num7 = stream.Seek(2L, (SeekOrigin)0);
						num8 = unchecked((nint)null);
						num = unchecked((nint)null);
						obj = 2;
						streamBuffer2 = stream;
					}
					goto IL_05ff;
				}
				PhotonPeer photonPeer2 = this.photonPeer;
				bool flag9 = this.photonPeer == null;
				obj = null;
				streamBuffer = stream;
				if (!flag9)
				{
					bool flag10 = (int)photonPeer2.LogLevel < 4;
					object obj18 = !flag10;
					object obj19 = ~obj18;
					if (obj19 != null)
					{
						goto IL_15fa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj20 = 0;
					IPhotonPeerListener photonPeerListener = photonPeer2.Listener__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516538]");
					object format2 = 0;
					object obj21 = default;
					string text3 = string.Format((string)format2, obj21);
					bool flag11 = photonPeer2.Listener__BackingField == null;
					num = unchecked((nint)null);
					obj = obj21;
					streamBuffer = stream;
					if (!flag11)
					{
						nint num9 = (nint)photonPeerListener;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v97 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						object obj23 = 0;
						object obj8 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v97 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						bool flag12 = (nint)0 == 0;
						text2 = text3;
						if (flag12)
						{
							goto IL_04a7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v97 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
						obj9 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X10_v7-8]");
							bool flag13 = 0 == (nint)obj8;
							num2 = num9;
							text2 = text3;
							if (flag13)
							{
								break;
							}
							obj23--;
							obj9 += 16;
							bool flag14 = (nint)obj23 != 1;
							text2 = text3;
							if (flag14)
							{
								continue;
							}
							goto IL_04a7;
						}
						goto IL_04b6;
					}
				}
			}
		}
		goto IL_1558;
		IL_15fa:
		return false;
		IL_169b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v134+8]");
		object obj24 = 0;
		num8 = length3 - 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1029 @ X0_v134] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StreamBuffer streamBuffer3 = default;
		byte[] array = default;
		streamBuffer3._002Ector(array);
		num = unchecked((nint)null);
		obj = array;
		streamBuffer2 = streamBuffer3;
		goto IL_05ff;
		IL_04b6:
		object obj26 = num2 + obj9;
		object obj27 = obj26 + 312;
		goto IL_1668;
		IL_01e0:
		text2 = text;
		goto IL_04a7;
		IL_141a:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1428;
		IL_05c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_169b;
		IL_0c4a:
		PhotonPeer photonPeer3 = this.photonPeer;
		bool flag15 = this.photonPeer == null;
		obj = null;
		streamBuffer = streamBuffer2;
		if (flag15)
		{
			goto IL_1558;
		}
		if (photonPeer3.LogLevel != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516550]");
			object format3 = 0;
			object arg = default;
			string debugReturn = string.Format((string)format3, arg);
			EnqueueDebugReturn((LogLevel)1, debugReturn);
			return true;
		}
		goto IL_1760;
		IL_05ff:
		bool flag16 = this.photonPeer == null;
		streamBuffer = streamBuffer2;
		if (!flag16)
		{
			bool useByteArraySlicePoolForEvents = this.photonPeer.UseByteArraySlicePoolForEvents;
			bool flag17 = this.photonPeer == null;
			obj = null;
			streamBuffer = streamBuffer2;
			if (!flag17)
			{
				bool wrapIncomingStructs = this.photonPeer.WrapIncomingStructs;
				bool flag18 = !wrapIncomingStructs;
				object obj29 = !flag18;
				object obj30 = ~obj29;
				IntPtr intPtr = ((obj30 != null) ? ((IntPtr)null) : ((IntPtr)2));
				if (num4 > 4)
				{
					if (num4 <= 7)
					{
						if (num4 == 5)
						{
							Protocol serializationProtocol = SerializationProtocol;
							bool flag19 = SerializationProtocol == null;
							obj17 = null;
							if (flag19)
							{
								goto IL_13fe;
							}
							nint num10 = (nint)serializationProtocol;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X8_v57 (Il2CppClass<Photon.Client.Protocol>)+260]");
							num = 0;
							float num11 = ((Enum)(object)SerializationProtocol).System_002EIConvertible_002EToSingle((IFormatProvider)streamBuffer2);
							PhotonPeer photonPeer4 = this.photonPeer;
							bool flag20 = this.photonPeer == null;
							obj17 = streamBuffer2;
							if (flag20)
							{
								goto IL_141a;
							}
							num = (nint)photonPeer4.Listener__BackingField;
							bool flag21 = photonPeer4.Listener__BackingField == null;
							obj17 = streamBuffer2;
							if (flag21)
							{
								goto IL_1428;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AC7D0");
							goto IL_1760;
						}
						if (num4 != 7)
						{
							goto IL_0c4a;
						}
						Protocol serializationProtocol2 = SerializationProtocol;
						bool flag22 = SerializationProtocol == null;
						obj17 = null;
						if (flag22)
						{
							goto IL_13e2;
						}
						nint num12 = (nint)serializationProtocol2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v61 (Il2CppClass<Photon.Client.Protocol>)+250]");
						num8 = 0;
						OperationResponse operationResponse = (OperationResponse)((Enum)(object)SerializationProtocol).System_002EIConvertible_002EToUInt64((IFormatProvider)streamBuffer2);
						int num13 = timeInt;
						bool flag23 = operationResponse == null;
						num = unchecked((nint)null);
						obj = streamBuffer2;
						streamBuffer = streamBuffer2;
						if (!flag23)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164B8]");
							object obj32 = 0;
							object obj33 = obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v111+E4]");
							bool flag24 = (nint)0 == 0;
							object obj34 = !flag24;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj33 = obj32;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v111+A0]");
							object obj35 = 0;
							byte operationCode = operationResponse.OperationCode;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X8_v64+3]");
							if ((nint)(int)operationCode == 0)
							{
								DeriveSharedKey(operationResponse);
								num = unchecked((nint)null);
								obj = operationResponse;
								streamBuffer = (StreamBuffer)num13;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v111+E4]");
								bool flag25 = (nint)0 == 0;
								object obj36 = !flag25;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj37 = obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1310 @ X8_v81+A0]");
									obj35 = 0;
								}
								byte operationCode2 = operationResponse.OperationCode;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X8_v64+4]");
								if ((nint)(int)operationCode2 == 0)
								{
									int num14 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
									int num15 = num14 & 0xFF;
									bool flag26 = num15 != 1;
									num8 = unchecked((nint)null);
									num = unchecked((nint)null);
									obj = null;
									if (!flag26)
									{
										object obj38 = usedTransportProtocol & (ConnectionProtocol)0xFE;
										bool flag27 = (nint)obj38 != 4;
										num8 = unchecked((nint)null);
										num = unchecked((nint)null);
										obj = null;
										if (!flag27)
										{
											PhotonPeer photonPeer5 = this.photonPeer;
											bool flag28 = this.photonPeer == null;
											num8 = unchecked((nint)null);
											num = unchecked((nint)null);
											obj = null;
											streamBuffer = (StreamBuffer)num13;
											if (flag28)
											{
												goto IL_1558;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D0]");
											object obj39 = 0;
											photonPeer5.PingUsedAsInit = true;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516528]");
											object obj40 = 0;
											MyAction myAction = default;
											myAction._002Ector(this, (IntPtr)obj40);
											EnqueueActionForDispatch(myAction);
											num8 = unchecked((nint)null);
											num = (nint)obj40;
											obj = myAction;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516530]");
									object obj41 = 0;
									nint num16 = (nint)this;
									object obj42 = obj41;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ X9_v26 (Il2CppClass<Photon.Client.PeerBase>)+130]");
									nint num17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v75+130]");
									bool flag29 = num17 < 0;
									object obj43 = !flag29;
									object obj44 = ~obj43;
									streamBuffer = (StreamBuffer)num13;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ X9_v26 (Il2CppClass<Photon.Client.PeerBase>)+B0]");
										nint num18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v75+130]");
										object obj45 = num18 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X9_v28-8]");
										bool flag30 = 0 != (nint)obj42;
										streamBuffer = (StreamBuffer)num13;
										if (!flag30)
										{
											((TPeer)this).ReadPingResult(operationResponse);
											num = unchecked((nint)null);
											obj = operationResponse;
											streamBuffer = (StreamBuffer)num13;
										}
									}
								}
								else
								{
									PhotonPeer photonPeer6 = this.photonPeer;
									bool flag31 = this.photonPeer == null;
									num = unchecked((nint)null);
									obj = streamBuffer2;
									streamBuffer = (StreamBuffer)num13;
									if (flag31)
									{
										goto IL_1558;
									}
									bool flag32 = photonPeer6.LogLevel == 0;
									num = unchecked((nint)null);
									obj = streamBuffer2;
									streamBuffer = (StreamBuffer)num13;
									if (!flag32)
									{
										string text4 = operationResponse.ToStringFull();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516548]");
										object obj46 = 0;
										string text5 = (string)obj46 + text4;
										EnqueueDebugReturn((LogLevel)1, text5);
										num = (nint)text5;
										obj = 1;
										streamBuffer = (StreamBuffer)num13;
									}
								}
							}
							goto IL_1000;
						}
					}
					else if (num4 != 8)
					{
						if (num4 != 9)
						{
							goto IL_0c4a;
						}
						int num19 = timeInt;
						PhotonPeer photonPeer7 = this.photonPeer;
						bool flag33 = this.photonPeer == null;
						obj = null;
						streamBuffer = streamBuffer2;
						if (!flag33)
						{
							num = (nint)photonPeer7.Listener__BackingField;
							bool flag34 = photonPeer7.Listener__BackingField == null;
							obj = null;
							streamBuffer = streamBuffer2;
							if (!flag34)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
								object obj47 = 0;
								obj = obj47;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB374");
								PhotonPeer photonPeer8 = this.photonPeer;
								bool flag35 = this.photonPeer == null;
								obj24 = streamBuffer2;
								num8 = 1;
								streamBuffer = streamBuffer2;
								if (!flag35)
								{
									streamBuffer = (StreamBuffer)(object)photonPeer8.Stats__BackingField;
									int num20 = timeInt;
									bool flag36 = photonPeer8.Stats__BackingField == null;
									obj24 = streamBuffer2;
									num8 = 1;
									if (!flag36)
									{
										object obj48 = num20 - num19;
										goto IL_1760;
									}
								}
							}
						}
					}
					else
					{
						bool flag37 = SerializationProtocol == null;
						obj = null;
						streamBuffer = streamBuffer2;
						if (!flag37)
						{
							object obj49 = SerializationProtocol.DeserializeMessage(streamBuffer2);
							int num21 = timeInt;
							PhotonPeer photonPeer9 = this.photonPeer;
							bool flag38 = this.photonPeer == null;
							num = unchecked((nint)null);
							obj = streamBuffer2;
							streamBuffer = streamBuffer2;
							if (!flag38)
							{
								num = (nint)photonPeer9.Listener__BackingField;
								bool flag39 = photonPeer9.Listener__BackingField == null;
								obj = streamBuffer2;
								streamBuffer = streamBuffer2;
								if (!flag39)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
									object obj50 = 0;
									obj = obj50;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB374");
									obj24 = obj49;
									num8 = unchecked((nint)null);
									streamBuffer = (StreamBuffer)num21;
									goto IL_1000;
								}
							}
						}
					}
				}
				else
				{
					if (num4 == 1)
					{
						OnInitResponse();
						goto IL_1760;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
					if (num4 != 3)
					{
						if (num4 != 4)
						{
							goto IL_0c4a;
						}
						Protocol serializationProtocol3 = SerializationProtocol;
						bool flag40 = SerializationProtocol == null;
						obj17 = null;
						if (flag40)
						{
							goto IL_13f0;
						}
						nint num22 = (nint)serializationProtocol3;
						num = (nint)reusableEventData;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X9_v20 (Il2CppClass<Photon.Client.Protocol>)+230]");
						obj24 = 0;
						StreamBuffer streamBuffer4 = (StreamBuffer)((Enum)(object)SerializationProtocol).System_002EIConvertible_002EToUInt32((IFormatProvider)streamBuffer2);
						int num23 = timeInt;
						PhotonPeer photonPeer10 = this.photonPeer;
						bool flag41 = this.photonPeer == null;
						num8 = intPtr;
						obj = streamBuffer2;
						streamBuffer = streamBuffer4;
						if (!flag41)
						{
							num = (nint)photonPeer10.Listener__BackingField;
							bool flag42 = photonPeer10.Listener__BackingField == null;
							num8 = intPtr;
							obj = streamBuffer2;
							streamBuffer = streamBuffer4;
							if (!flag42)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
								object obj51 = 0;
								obj = obj51;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AC7D0");
								PhotonPeer photonPeer11 = this.photonPeer;
								bool flag43 = this.photonPeer == null;
								num8 = (nint)streamBuffer4;
								streamBuffer = streamBuffer4;
								if (!flag43)
								{
									TrafficStats trafficStats = photonPeer11.Stats__BackingField;
									int num24 = timeInt;
									bool flag44 = photonPeer11.Stats__BackingField == null;
									num8 = (nint)streamBuffer4;
									streamBuffer = streamBuffer4;
									if (!flag44)
									{
										int num25 = num24 - num23;
										trafficStats.LastDispatchDuration__BackingField = num25;
										bool flag45 = this.photonPeer == null;
										num8 = (nint)streamBuffer4;
										streamBuffer = streamBuffer4;
										if (!flag45)
										{
											if (this.photonPeer.ReuseEventInstance)
											{
												object obj52 = this + 184;
												reusableEventData = (EventData)(object)streamBuffer4;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											}
											goto IL_1760;
										}
									}
								}
							}
						}
					}
					else
					{
						Protocol serializationProtocol4 = SerializationProtocol;
						bool flag46 = SerializationProtocol == null;
						obj17 = null;
						if (flag46)
						{
							goto IL_140c;
						}
						nint num26 = (nint)serializationProtocol4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X9_v19 (Il2CppClass<Photon.Client.Protocol>)+250]");
						num8 = 0;
						ulong num27 = ((Enum)(object)SerializationProtocol).System_002EIConvertible_002EToUInt64((IFormatProvider)streamBuffer2);
						int num28 = timeInt;
						PhotonPeer photonPeer12 = this.photonPeer;
						bool flag47 = this.photonPeer == null;
						num = intPtr;
						obj = streamBuffer2;
						streamBuffer = streamBuffer2;
						if (!flag47)
						{
							num = (nint)photonPeer12.Listener__BackingField;
							bool flag48 = photonPeer12.Listener__BackingField == null;
							obj = streamBuffer2;
							streamBuffer = streamBuffer2;
							if (!flag48)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
								object obj53 = 0;
								obj = obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AC7D0");
								num8 = (nint)num27;
								streamBuffer = (StreamBuffer)num28;
								goto IL_1000;
							}
						}
					}
				}
			}
		}
		goto IL_1558;
		IL_1558:
		throw new NullReferenceException();
		IL_1668:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v890 @ X0_v17] (should have been resolved before IL gen)");
		goto IL_15fa;
		IL_04a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_1668;
		IL_1760:
		return true;
		IL_1000:
		PhotonPeer photonPeer13 = this.photonPeer;
		if (this.photonPeer != null)
		{
			TrafficStats trafficStats2 = photonPeer13.Stats__BackingField;
			int num29 = timeInt;
			if (photonPeer13.Stats__BackingField != null)
			{
				int num30 = num29 - streamBuffer;
				trafficStats2.LastDispatchDuration__BackingField = num30;
				goto IL_1760;
			}
		}
		goto IL_1558;
		IL_13f0:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_13fe;
		IL_13e2:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_13f0;
		IL_1428:
		NullReferenceException ex5 = new NullReferenceException();
		bool flag49 = (nint)obj17 != 1;
		NullReferenceException ex6 = ex5;
		if (!flag49)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj55 = default;
			object obj54 = obj55;
			obj = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj57 = default;
			object obj56 = obj57 & 1;
			if (obj56 != null)
			{
				streamBuffer = (StreamBuffer)obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				PhotonPeer photonPeer14 = this.photonPeer;
				if (this.photonPeer == null)
				{
					goto IL_1558;
				}
				if (photonPeer14.LogLevel != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format4 = default;
					string debugReturn2 = string.Format(format4, streamBuffer);
					EnqueueDebugReturn((LogLevel)1, debugReturn2);
				}
				goto IL_15fa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj58 = obj55;
			obj17 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			num = unchecked((nint)null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex7 = default;
			ex6 = ex7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_13fe:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_140c;
		IL_140c:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_141a;
	}

	internal void UpdateRoundTripTimeAndVariance(int lastRoundtripTime)
	{
		//IL_0012: Expected I4, but got I8
		//IL_002c: Expected Obj, but got I4
		//IL_0055: Invalid comparison between F4 and I4
		//IL_0066: Expected Obj, but got I4
		//IL_0080: Invalid comparison between F4 and I4
		//IL_010c: Expected Obj, but got I4
		//IL_0209: Invalid comparison between F4 and I4
		//IL_0239: Invalid comparison between F4 and I4
		//IL_014c: Expected I4, but got F4
		//IL_0172: Expected Obj, but got F4
		//IL_015b: Expected I4, but got F4
		//IL_01c0: Expected I, but got Obj
		int num = (int)(lastRoundtripTime & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			float num2 = (float)lastRoundtripTime - roundTripTime;
			bool flag2 = roundTripTime < (float)lastRoundtripTime;
			object obj2 = !flag2;
			float num3 = roundTripTime - (float)lastRoundtripTime;
			bool flag3 = num3 == 0f;
			float num4 = num2 * 0.125f;
			float num5 = roundTripTime + num4;
			float num6 = (float)lastRoundtripTime - num5;
			float num7 = num6 * 0.25f;
			float num8 = num6 * 0.25f;
			float num9 = 0f - num8;
			float num10 = roundTripTimeVariance * 0.25f;
			object obj3 = !flag3;
			object obj4 = obj2 & obj3;
			object obj5 = ~obj4;
			if (obj5 != null)
			{
				num9 = num7;
			}
			float num11 = roundTripTimeVariance - num10;
			float num12 = num11 + num9;
			roundTripTime = num5;
			roundTripTimeVariance = num12;
			if (num5 < (float)lowestRoundTripTime)
			{
				lowestRoundTripTime = (int)num5;
			}
			if (num12 > (float)highestRoundTripTimeVariance)
			{
				highestRoundTripTimeVariance = (int)num12;
			}
			PhotonPeer photonPeer = this.photonPeer;
			bool flag4 = photonPeer.Stats__BackingField.Equals(num5);
			PhotonPeer photonPeer2 = this.photonPeer;
			int hashCode = photonPeer2.Stats__BackingField.GetHashCode();
			PhotonPeer photonPeer3 = this.photonPeer;
			TrafficStats trafficStats = photonPeer3.Stats__BackingField;
			nint num13 = (nint)trafficStats;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v68 @ X8_v8 (Il2CppClass<Photon.Client.TrafficStats>)+1C8] (should have been resolved before IL gen)");
		}
	}

	internal unsafe bool ExchangeKeysForEncryption(object lockObject)
	{
		//IL_095d: Expected VT, but got I4
		//IL_001f: Expected VT, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_00f7: Expected VT, but got I4
		//IL_0322: Expected Obj, but got I
		//IL_0345: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_0148: Expected VT, but got I4
		//IL_03b6: Expected Obj, but got I4
		//IL_0999: Expected Obj, but got I4
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_03e3: Expected I, but got Obj
		//IL_0403: Expected Obj, but got I
		//IL_0266: Expected VT, but got I4
		//IL_08fc: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_01eb: Expected VT, but got I4
		//IL_0209: Expected I4, but got Obj
		//IL_020e: Expected I, but got Obj
		//IL_09e4: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02e1: Expected VT, but got I4
		//IL_0239: Expected I4, but got Obj
		//IL_04bd: Expected Obj, but got I
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_054a: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Expected Obj, but got Unknown
		//IL_0a48: Expected Obj, but got I
		//IL_0a72: Expected Obj, but got I4
		//IL_0684: Expected Obj, but got I4
		//IL_0560: Expected I, but got Obj
		//IL_0570: Expected Obj, but got I
		//IL_0580: Expected Obj, but got I
		//IL_0ac3: Expected Obj, but got I
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected I4, but got Unknown
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected I4, but got Unknown
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Expected Obj, but got Unknown
		//IL_0b19: Expected I, but got Obj
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected Obj, but got Unknown
		//IL_0b37: Expected Obj, but got I8
		//IL_060f: Expected Obj, but got I4
		//IL_0b44: Expected Obj, but got Ref
		//IL_05bb: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got VT
		//IL_06b1: Expected Obj, but got Ref
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected Obj, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_0638: Expected Obj, but got I4
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		object obj = default;
		bool flag = obj == null;
		SendOptions sendOptions = (SendOptions)0;
		bool lockTaken = false;
		object obj2 = null;
		object obj3 = obj;
		object obj8 = default;
		string text;
		PeerBase peerBase;
		object obj9;
		DiffieHellmanCryptoProvider diffieHellmanCryptoProvider2;
		Type type;
		string text2;
		Type type2;
		byte b;
		nint num;
		object obj6;
		if (!flag)
		{
			bool flag2 = photonPeer == null;
			sendOptions = (SendOptions)0;
			lockTaken = false;
			obj2 = null;
			obj3 = obj;
			if (!flag2)
			{
				Type payloadEncryptorType = photonPeer.PayloadEncryptorType;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v42+E8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v43+E4]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v43+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516520]");
				obj8 = 0;
				bool flag4 = payloadEncryptorType != null;
				bool flag5 = !flag4;
				sendOptions = (SendOptions)0;
				lockTaken = false;
				obj2 = null;
				text = null;
				LogLevel logLevel = (LogLevel)0;
				peerBase = this;
				obj9 = obj;
				if (!flag5)
				{
					bool flag6 = photonPeer == null;
					sendOptions = (SendOptions)0;
					lockTaken = false;
					obj2 = null;
					text2 = null;
					type = null;
					peerBase = this;
					obj3 = obj;
					if (flag6)
					{
						goto IL_07e2;
					}
					Type payloadEncryptorType2 = photonPeer.PayloadEncryptorType;
					object obj10 = Activator.CreateInstance(payloadEncryptorType2);
					bool flag7 = obj10 == null;
					type = null;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						DiffieHellmanCryptoProvider diffieHellmanCryptoProvider = default;
						bool flag8 = diffieHellmanCryptoProvider == null;
						object obj11 = !flag8;
						sendOptions = (SendOptions)0;
						lockTaken = false;
						obj2 = null;
						diffieHellmanCryptoProvider2 = diffieHellmanCryptoProvider;
						b = (byte)(int)obj8;
						num = unchecked((nint)null);
						type2 = (Type)obj8;
						peerBase = this;
						obj9 = obj;
						if (obj11 == null)
						{
							b = (byte)(int)obj8;
							type = (Type)obj8;
							throw new InvalidCastException();
						}
						goto IL_034f;
					}
					bool flag9 = photonPeer == null;
					sendOptions = (SendOptions)0;
					lockTaken = false;
					obj2 = null;
					text2 = null;
					peerBase = this;
					obj3 = obj;
					if (flag9)
					{
						goto IL_07f0;
					}
					Type payloadEncryptorType3 = photonPeer.PayloadEncryptorType;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516598]");
					object format = 0;
					string text3 = string.Format((string)format, payloadEncryptorType3);
					EnqueueDebugReturn((LogLevel)2, text3);
					sendOptions = (SendOptions)0;
					lockTaken = false;
					obj2 = null;
					text = text3;
					logLevel = (LogLevel)2;
					peerBase = this;
					obj9 = obj;
				}
				goto IL_0312;
			}
			goto IL_0750;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotSupportedException ex = default;
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		text2 = null;
		Type type3 = default;
		type = type3;
		NotSupportedException ex3 = ex;
		goto IL_07bd;
		IL_0750:
		throw new NullReferenceException();
		IL_05fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		object obj12 = 0;
		goto IL_0aa4;
		IL_0aa4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v766 @ X0_v76] (should have been resolved before IL gen)");
		goto IL_0a13;
		IL_07f0:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag10 = (nint)type != 1;
		NullReferenceException ex5 = ex4;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj14 = default;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj16 = default;
			object obj15 = obj16 & 1;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format2 = default;
				string text4 = string.Format(format2, obj14);
				peerBase.EnqueueDebugReturn((LogLevel)2, text4);
				text = text4;
				LogLevel logLevel = (LogLevel)2;
				obj9 = obj3;
				goto IL_0312;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj17 = obj14;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			text2 = null;
			NullReferenceException ex6 = default;
			ex5 = ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_0a13:
		peerBase.CryptoProvider = (ICryptoProvider)diffieHellmanCryptoProvider2;
		object obj18 = peerBase + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3060]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v60+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		sendOptions.Reliability = true;
		object obj23;
		object obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v64+E4]");
		bool flag12 = (nint)0 == 0;
		object obj24 = !flag12;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v64+A0]");
		object obj25 = 0;
		object obj26 = default;
		bool encrypt = (byte)(obj26 & 1) != 0;
		PeerBase peerBase2 = peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v25+3]");
		ParameterDictionary parameterDictionary = default;
		StreamBuffer streamBuffer = peerBase2.SerializeOperationToMessage(0, parameterDictionary, (EgMessageType)6, encrypt);
		object obj27 = default;
		byte b2 = default;
		int num2 = obj27 | b2;
		obj6 = sendOptions | obj26;
		nint num3 = (nint)peerBase;
		text2 = (string)(obj6 | num2);
		NotSupportedException ex7 = (NotSupportedException)((Enum)(object)peerBase).System_002EIConvertible_002EToUInt64((IFormatProvider)streamBuffer);
		object obj28 = (object)(&lockTaken);
		bool flag13 = obj28 == null;
		type = (Type)(object)streamBuffer;
		if (!flag13)
		{
			object obj29 = (object)(&obj2);
			Monitor.Exit(obj29);
			type = null;
		}
		lockTaken = false;
		obj2 = obj9;
		b = b2;
		obj8 = obj27;
		ex3 = ex7;
		obj3 = sendOptions;
		goto IL_07bd;
		IL_07e2:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_07f0;
		IL_0312:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516590]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		DiffieHellmanCryptoProvider diffieHellmanCryptoProvider3 = default;
		diffieHellmanCryptoProvider3._002Ector();
		diffieHellmanCryptoProvider2 = diffieHellmanCryptoProvider3;
		num = (nint)text;
		type2 = null;
		goto IL_034f;
		IL_09d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v51+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v646 @ X0_v51] (should have been resolved before IL gen)");
		bool flag14 = parameterDictionary == null;
		obj3 = obj9;
		if (flag14)
		{
			goto IL_0750;
		}
		object value = default;
		parameterDictionary.set_Item(b, value);
		Monitor.Enter(obj9, ref lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		ICryptoProvider cryptoProvider = peerBase.CryptoProvider;
		peerBase.isEncryptionAvailable = false;
		bool flag15 = peerBase.CryptoProvider == null;
		obj12 = 0;
		if (flag15)
		{
			goto IL_0a13;
		}
		nint num4 = (nint)cryptoProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v33 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v33 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05fc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v33 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+98]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X10_v18-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj32--;
			obj33 += 16;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_05fc;
		}
		object obj34 = num4 + obj33;
		object obj35 = obj34 + 312;
		obj12 = 0;
		goto IL_0aa4;
		IL_07bd:
		OutOfMemoryException ex9 = new OutOfMemoryException();
		peerBase = (PeerBase)(object)ex3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_07e2;
		IL_0497:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num = 1;
		goto IL_09d4;
		IL_034f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3058]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164B8]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		parameterDictionary._002Ector(1);
		object obj37 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v50+E4]");
		bool flag16 = (nint)0 == 0;
		object obj38 = !flag16;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj37 = obj23;
		}
		bool flag17 = diffieHellmanCryptoProvider2 == null;
		obj = 1;
		obj3 = obj9;
		if (flag17)
		{
			goto IL_0750;
		}
		nint num5 = (nint)diffieHellmanCryptoProvider2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v50+A0]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v16 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
		obj6 = 0;
		b = (byte)num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v16 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0497;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v16 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+98]");
		nint num6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v23 (Il2CppClass<Photon.Client.PeerBase>)-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v16 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
			obj6 = -1;
			num3 = num6 + 16;
			bool flag18 = (nint)obj6 != 1;
			num6 = num3;
			if (flag18)
			{
				continue;
			}
			goto IL_0497;
		}
		obj6 = num6 + 1;
		object obj39 = num5 + obj6;
		object obj40 = obj39 + 312;
		num3 = num6;
		goto IL_09d4;
	}

	internal void DeriveSharedKey(OperationResponse operationResponse)
	{
		//IL_0061: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_016e: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		string text;
		string text2;
		if (operationResponse.ReturnCode != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516580]");
			object obj = 0;
			text = operationResponse.ToStringFull();
			text2 = (string)obj;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164B8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+A0]");
			object obj6 = 0;
			ParameterDictionary parameters = operationResponse.Parameters;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10+2]");
			object obj7 = parameters.get_Item((byte)0);
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				object obj9 = default;
				if (obj9 == null)
				{
					throw new InvalidCastException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+18]");
				if ((nint)0 != 0)
				{
					ICryptoProvider cryptoProvider = CryptoProvider;
					nint num = (nint)cryptoProvider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516520]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_020a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<Photon.Client.Encryption.ICryptoProvider>)+98]");
					object obj12 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v8-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						obj11--;
						obj12 += 16;
						if ((nint)obj11 != 1)
						{
							continue;
						}
						goto IL_020a;
					}
					object obj13 = obj12 + 2;
					object obj14 = num + obj13;
					object obj15 = obj14 + 312;
					goto IL_02cb;
				}
			}
			text = operationResponse.ToStringFull();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516588]");
			object obj16 = 0;
			text2 = (string)obj16;
		}
		string debugReturn = text2 + text;
		EnqueueDebugReturn((LogLevel)1, debugReturn);
		StatusCode statusValue = (StatusCode)1049;
		goto IL_02f9;
		IL_02f9:
		EnqueueStatusCallback(statusValue);
		return;
		IL_020a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_02cb;
		IL_02cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X0_v21] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		isEncryptionAvailable = true;
		statusValue = (StatusCode)1048;
		goto IL_02f9;
	}

	internal virtual void InitEncryption(byte[] secret)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0095: Expected I, but got Obj
		//IL_083d: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_04da: Expected Obj, but got I
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_01ba: Expected I, but got Obj
		//IL_0158: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_05fb: Expected Obj, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_079d: Expected Obj, but got I
		//IL_07ac: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I
		//IL_07ca: Expected I, but got Obj
		//IL_030e: Expected I, but got Obj
		//IL_0542: Expected I, but got Obj
		//IL_02e9: Expected I, but got Obj
		//IL_069a: Expected Obj, but got I4
		//IL_06ad: Expected Obj, but got I4
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_033b: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_0378: Expected I, but got Obj
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_06f5: Expected I, but got Obj
		//IL_070c: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_072e: Expected I, but got Obj
		//IL_0736: Expected Obj, but got I
		//IL_03e1: Expected I, but got Obj
		//IL_03ff: Expected I, but got Obj
		//IL_040f: Expected Obj, but got I
		//IL_041f: Expected Obj, but got I
		//IL_0766: Expected Obj, but got I4
		//IL_0773: Expected I, but got Obj
		//IL_08a6: Expected Obj, but got I
		//IL_08b8: Expected I, but got Obj
		//IL_08c1: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got I
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		bool flag = this.photonPeer == null;
		object obj = secret;
		nint num = 109924352;
		if (flag)
		{
			goto IL_0780;
		}
		Type payloadEncryptorType = this.photonPeer.PayloadEncryptorType;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = payloadEncryptorType != null;
		bool flag4 = !flag3;
		nint num2 = unchecked((nint)null);
		Type type = null;
		object obj8;
		IndexOutOfRangeException ex = default;
		if (!flag4)
		{
			bool flag5 = this.photonPeer == null;
			num2 = unchecked((nint)null);
			Type type2 = null;
			if (!flag5)
			{
				Type payloadEncryptorType2 = this.photonPeer.PayloadEncryptorType;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object[] array = default;
				bool flag6 = array == null;
				num2 = unchecked((nint)null);
				type2 = (Type)1;
				if (flag6)
				{
					goto IL_055d;
				}
				bool flag7 = secret == null;
				Type type3 = (Type)1;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
					type3 = (Type)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag8 = ex == null;
					num2 = unchecked((nint)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
					type2 = (Type)0;
					if (flag8)
					{
						goto IL_0579;
					}
				}
				bool flag9 = array.Length == 0;
				num2 = unchecked((nint)null);
				type2 = type3;
				if (flag9)
				{
					goto IL_056b;
				}
				object obj6 = array + 32;
				obj6 = secret;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj7 = Activator.CreateInstance(payloadEncryptorType2, array);
				if (obj7 == null)
				{
					obj8 = this + 256;
					CryptoProvider = null;
					type = null;
					goto IL_084b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516520]");
				object obj9 = 0;
				Type type4 = (Type)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				ICryptoProvider cryptoProvider = default;
				if (cryptoProvider != null)
				{
					type4 = (Type)obj9;
					CryptoProvider = cryptoProvider;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					Type type5 = default;
					if ((object)type5 != null)
					{
						obj8 = this + 256;
						type = type5;
						goto IL_084b;
					}
				}
				InvalidCastException ex2 = new InvalidCastException();
				num2 = unchecked((nint)null);
				type2 = type4;
			}
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_055d;
		}
		goto IL_0821;
		IL_0596:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_05a4;
		IL_049b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0896;
		IL_05a4:
		NullReferenceException ex5 = new NullReferenceException();
		bool flag10 = (nint)type != 1;
		NullReferenceException ex6 = ex5;
		object obj17;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			IntPtr intPtr = default;
			object obj10 = (nint)intPtr;
			obj = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj12 = default;
			object obj11 = obj12 & 1;
			bool flag11 = obj11 == null;
			num = intPtr;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				PhotonPeer photonPeer = this.photonPeer;
				bool flag12 = this.photonPeer == null;
				num = intPtr;
				if (flag12)
				{
					goto IL_0780;
				}
				bool flag13 = (int)photonPeer.LogLevel < 1;
				object obj13 = !flag13;
				object obj14 = photonPeer.LogLevel - 1;
				bool flag14 = obj14 == null;
				object obj15 = ~obj13;
				object obj16 = obj15 | flag14;
				type = (Type)obj10;
				if (obj16 == null)
				{
					num = (nint)photonPeer.Listener__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format = default;
					string text = string.Format(format, (nint)intPtr);
					bool flag15 = photonPeer.Listener__BackingField == null;
					num2 = unchecked((nint)null);
					obj = (nint)intPtr;
					if (flag15)
					{
						goto IL_0780;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
					obj17 = 2;
					num2 = (nint)photonPeer.Listener__BackingField;
					Type type6 = default;
					type = type6;
				}
				goto IL_0821;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj18 = num;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num2 = unchecked((nint)null);
			NullReferenceException ex7 = default;
			ex6 = ex7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_055d:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_056b;
		IL_056b:
		ex = new IndexOutOfRangeException();
		goto IL_0579;
		IL_0579:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex9 = new ArgumentNullException();
		type = null;
		goto IL_0596;
		IL_084b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string text2;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			isEncryptionAvailable = true;
			num2 = unchecked((nint)null);
		}
		else
		{
			PhotonPeer photonPeer2 = this.photonPeer;
			bool flag16 = this.photonPeer == null;
			num2 = unchecked((nint)null);
			if (flag16)
			{
				goto IL_0596;
			}
			bool flag17 = (int)photonPeer2.LogLevel < 1;
			object obj19 = !flag17;
			object obj20 = photonPeer2.LogLevel - 1;
			bool flag18 = obj20 == null;
			object obj21 = ~obj19;
			object obj22 = obj21 | flag18;
			num2 = unchecked((nint)null);
			if (obj22 == null)
			{
				IPhotonPeerListener photonPeerListener = photonPeer2.Listener__BackingField;
				Type payloadEncryptorType3 = this.photonPeer.PayloadEncryptorType;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516598]");
				object format2 = 0;
				text2 = string.Format((string)format2, payloadEncryptorType3);
				bool flag19 = photonPeer2.Listener__BackingField == null;
				num2 = unchecked((nint)null);
				type = payloadEncryptorType3;
				if (flag19)
				{
					goto IL_05a4;
				}
				nint num4 = (nint)photonPeerListener;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v32 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v32 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_049b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v32 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
				object obj25 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X10_v8-8]");
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
					goto IL_049b;
				}
				object obj26 = num4 + obj25;
				object obj27 = obj26 + 312;
				goto IL_0896;
			}
		}
		goto IL_0821;
		IL_0821:
		bool flag20 = CryptoProvider == null;
		object obj28 = !flag20;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516590]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			DiffieHellmanCryptoProvider diffieHellmanCryptoProvider = default;
			diffieHellmanCryptoProvider._002Ector(secret);
			object obj30 = this + 256;
			CryptoProvider = (ICryptoProvider)diffieHellmanCryptoProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			isEncryptionAvailable = true;
		}
		return;
		IL_0780:
		throw new NullReferenceException();
		IL_0896:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v71+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v514 @ X0_v71] (should have been resolved before IL gen)");
		num2 = (nint)text2;
		type = (Type)2;
		goto IL_0821;
	}

	internal unsafe void EnqueueActionForDispatch(MyAction action)
	{
		//IL_01c7: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got Ref
		//IL_01d8: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got Ref
		//IL_00a1: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got Ref
		//IL_014d: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(ActionQueue, ref lockTaken);
		bool flag = (object)ActionQueue == null;
		NullReferenceException ex = null;
		object obj = 0;
		System.__Canon _Canon = (System.__Canon)(&lockTaken);
		object obj2 = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D8]");
			object obj3 = 0;
			obj2 = obj3;
			((Queue<System.__Canon>)(object)ActionQueue).Enqueue((System.__Canon)(object)action);
			ex = null;
			obj = 0;
			_Canon = (System.__Canon)(object)action;
			goto IL_0047;
		}
		goto IL_00ee;
		IL_00ee:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_00fc;
		IL_0047:
		object obj4 = (object)(&lockTaken);
		if (obj4 != null)
		{
			object obj6 = default;
			object obj5 = (object)(&obj6);
			Monitor.Exit(obj5);
			_Canon = null;
		}
		bool flag2 = ex == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			bool flag3 = obj == null;
			object obj8 = !flag3;
			ex2 = ex;
			if (obj8 == null)
			{
				return;
			}
			goto IL_00fc;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_00ee;
		IL_00fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)_Canon == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)_Canon != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj9 = default;
			ex = (NullReferenceException)obj9;
		}
		goto IL_0047;
	}

	internal unsafe void EnqueueDebugReturn(LogLevel level, string debugReturn)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got Ref
		//IL_00e7: Expected Obj, but got Ref
		//IL_0121: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got Ref
		//IL_015b: Expected Obj, but got Ref
		//IL_02a3: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass128_0 obj2 = default;
		obj2._002Ector();
		bool lockTaken = default;
		object obj7 = default;
		OutOfMemoryException ex = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11;
		System.__Canon _Canon;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 32;
			string text = default;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Monitor.Enter(ActionQueue, ref lockTaken);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516200]");
			object obj6 = 0;
			MyAction myAction = default;
			myAction._002Ector(obj2, (IntPtr)obj6);
			bool flag = (object)ActionQueue == null;
			nint num = unchecked((nint)null);
			text = (string)obj6;
			obj7 = 0;
			ex = null;
			obj8 = (object)(&obj9);
			obj10 = (object)(&lockTaken);
			obj9 = ActionQueue;
			lockTaken = false;
			obj11 = obj2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D8]");
				object obj12 = 0;
				text = (string)obj12;
				((Queue<System.__Canon>)(object)ActionQueue).Enqueue((System.__Canon)(object)myAction);
				num = unchecked((nint)null);
				obj7 = 0;
				ex = null;
				obj8 = (object)(&obj9);
				obj10 = (object)(&lockTaken);
				obj9 = ActionQueue;
				lockTaken = false;
				_Canon = (System.__Canon)(object)myAction;
				goto IL_017c;
			}
			goto IL_0253;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj9 = null;
		lockTaken = false;
		_Canon = null;
		goto IL_022e;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0253;
		IL_0253:
		NullReferenceException ex3 = new NullReferenceException();
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj7 = 1;
			_Canon = (System.__Canon)obj11;
		}
		else
		{
			if ((nint)obj11 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj13 = default;
			ex = (OutOfMemoryException)obj13;
			_Canon = (System.__Canon)obj11;
		}
		goto IL_017c;
		IL_022e:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		obj11 = _Canon;
		goto IL_0244;
		IL_017c:
		if (obj10 != null)
		{
			Monitor.Exit(obj8);
			_Canon = null;
		}
		bool flag2 = ex == null;
		object obj14 = !flag2;
		if (obj14 != null)
		{
			goto IL_022e;
		}
		bool flag3 = obj7 == null;
		object obj15 = !flag3;
		obj11 = _Canon;
		ex4 = ex;
		if (obj15 == null)
		{
			return;
		}
		goto IL_0244;
	}

	internal unsafe void EnqueueStatusCallback(StatusCode statusValue)
	{
		//IL_0010: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0086: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got Ref
		//IL_00cb: Expected Obj, but got Ref
		//IL_0105: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got Ref
		//IL_0143: Expected Obj, but got Ref
		//IL_0294: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		PhotonSocket._003C_003Ec__DisplayClass129_0 obj2 = default;
		obj2._002Ector();
		bool lockTaken = default;
		object obj7 = default;
		OutOfMemoryException ex = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11;
		System.__Canon _Canon;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Monitor.Enter(ActionQueue, ref lockTaken);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161E0]");
			object obj5 = 0;
			MyAction myAction = default;
			myAction._002Ector(obj2, (IntPtr)obj5);
			bool flag = (object)ActionQueue == null;
			object obj6 = 0;
			nint num = (nint)obj5;
			obj7 = 0;
			ex = null;
			obj8 = (object)(&obj9);
			obj10 = (object)(&lockTaken);
			obj9 = ActionQueue;
			lockTaken = false;
			obj11 = obj2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D8]");
				object obj12 = 0;
				num = (nint)obj12;
				((Queue<System.__Canon>)(object)ActionQueue).Enqueue((System.__Canon)(object)myAction);
				obj6 = 0;
				obj7 = 0;
				ex = null;
				obj8 = (object)(&obj9);
				obj10 = (object)(&lockTaken);
				obj9 = ActionQueue;
				lockTaken = false;
				_Canon = (System.__Canon)(object)myAction;
				goto IL_0164;
			}
			goto IL_0244;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj9 = null;
		lockTaken = false;
		_Canon = null;
		obj3 = 109924352;
		goto IL_021f;
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0244;
		IL_0244:
		NullReferenceException ex3 = new NullReferenceException();
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj7 = 1;
			_Canon = (System.__Canon)obj11;
		}
		else
		{
			if ((nint)obj11 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj13 = default;
			ex = (OutOfMemoryException)obj13;
			_Canon = (System.__Canon)obj11;
		}
		goto IL_0164;
		IL_021f:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		obj11 = _Canon;
		goto IL_0235;
		IL_0164:
		if (obj10 != null)
		{
			Monitor.Exit(obj8);
			_Canon = null;
		}
		bool flag2 = ex == null;
		object obj14 = !flag2;
		if (obj14 != null)
		{
			goto IL_021f;
		}
		bool flag3 = obj7 == null;
		object obj15 = !flag3;
		obj11 = _Canon;
		ex4 = ex;
		if (obj15 == null)
		{
			return;
		}
		goto IL_0235;
	}

	internal void SendNetworkSimulated(byte[] dataToSend)
	{
		//IL_009a: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I4
		NetworkSimulationSet networkSimulationSet = networkSimulationSettings;
		bool flag = networkSimulationSettings == null;
		byte[] array2 = default;
		byte[] array = array2;
		if (!flag)
		{
			if (~(networkSimulationSet.isSimulationEnabled ? 1u : 0u) == 0)
			{
				if (usedTransportProtocol == 0 && networkSimulationSet.outgoingLossPercentage >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v18+E4]");
					bool flag2 = (nint)0 == 0;
					object obj3 = !flag2;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num = TPeer.ThreadSafeRandom.Next(100);
					networkSimulationSet = networkSimulationSettings;
					bool flag3 = networkSimulationSettings == null;
					array = null;
					if (flag3)
					{
						goto IL_0162;
					}
					if (num < networkSimulationSet.outgoingLossPercentage)
					{
						int num2 = networkSimulationSet.LostPackagesOut__BackingField + 1;
						networkSimulationSet.LostPackagesOut__BackingField = num2;
						return;
					}
				}
				NetworkSimQueueOrDeliver(array2, NetSimListOutgoing, networkSimulationSet.outgoingLag, networkSimulationSet.outgoingJitter, outgoing: true);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NotImplementedException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
		goto IL_0162;
		IL_0162:
		throw new NullReferenceException();
	}

	internal void ReceiveNetworkSimulated(byte[] dataReceived)
	{
		//IL_009a: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I4
		NetworkSimulationSet networkSimulationSet = networkSimulationSettings;
		bool flag = networkSimulationSettings == null;
		byte[] array2 = default;
		byte[] array = array2;
		if (!flag)
		{
			if (~(networkSimulationSet.isSimulationEnabled ? 1u : 0u) == 0)
			{
				if (usedTransportProtocol == 0 && networkSimulationSet.incomingLossPercentage >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v18+E4]");
					bool flag2 = (nint)0 == 0;
					object obj3 = !flag2;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num = TPeer.ThreadSafeRandom.Next(100);
					networkSimulationSet = networkSimulationSettings;
					bool flag3 = networkSimulationSettings == null;
					array = null;
					if (flag3)
					{
						goto IL_0162;
					}
					if (num < networkSimulationSet.incomingLossPercentage)
					{
						int num2 = networkSimulationSet.LostPackagesIn__BackingField + 1;
						networkSimulationSet.LostPackagesIn__BackingField = num2;
						return;
					}
				}
				NetworkSimQueueOrDeliver(array2, NetSimListIncoming, networkSimulationSet.incomingLag, networkSimulationSet.incomingJitter, outgoing: false);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NotImplementedException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
		goto IL_0162;
		IL_0162:
		throw new NullReferenceException();
	}

	private unsafe void NetworkSimQueueOrDeliver(byte[] data, LinkedList<SimulationItem> list, int lag, int jitterRange, bool outgoing)
	{
		//IL_0092: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got Ref
		//IL_017a: Expected Obj, but got Ref
		//IL_0084: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got Ref
		//IL_0230: Expected I4, but got I8
		//IL_0238: Expected I4, but got Obj
		//IL_00dc: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got Ref
		//IL_00f1: Expected Obj, but got Ref
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected I4, but got Unknown
		//IL_0280: Expected Obj, but got I8
		//IL_029a: Expected I4, but got Obj
		//IL_02b7: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got Ref
		//IL_02e1: Expected I4, but got I8
		//IL_02e9: Expected I4, but got Obj
		//IL_0655: Expected Obj, but got Ref
		//IL_0313: Expected Obj, but got I4
		//IL_0970: Expected Obj, but got I4
		//IL_0978: Expected I8, but got I4
		//IL_0980: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got Ref
		//IL_0832: Expected Obj, but got I4
		//IL_083f: Expected Obj, but got Ref
		//IL_084c: Expected I8, but got I4
		//IL_0854: Expected Obj, but got I4
		//IL_09ce: Expected I8, but got I4
		//IL_09d6: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got Ref
		//IL_058b: Expected Obj, but got I4
		//IL_08ca: Expected I4, but got I8
		//IL_08d2: Expected I4, but got Obj
		//IL_055e: Expected Obj, but got Ref
		//IL_0353: Expected Obj, but got I
		//IL_0380: Expected Obj, but got Ref
		//IL_06f5: Expected Obj, but got I4
		//IL_0702: Expected Obj, but got Ref
		//IL_070f: Expected I8, but got I4
		//IL_0717: Expected Obj, but got I4
		//IL_05b3: Expected Obj, but got I4
		//IL_05c3: Expected I4, but got I8
		//IL_05cb: Expected I4, but got Obj
		//IL_048b: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I4
		//IL_088c: Expected Obj, but got I4
		//IL_0782: Expected Obj, but got I4
		//IL_078f: Expected Obj, but got Ref
		//IL_079c: Expected I8, but got I4
		//IL_07a4: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I4
		//IL_07cf: Expected Obj, but got I4
		//IL_07dc: Expected Obj, but got Ref
		//IL_07e9: Expected I8, but got I4
		//IL_07f1: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I4
		object obj4;
		if (jitterRange >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v67+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int maxValue = jitterRange << 1;
			int num = TPeer.ThreadSafeRandom.Next(maxValue);
			obj4 = num - jitterRange;
		}
		else
		{
			obj4 = 0;
		}
		bool lockTaken = default;
		Monitor.Enter(list, ref lockTaken);
		int num2 = default;
		OutOfMemoryException ex;
		object obj6;
		object obj7 = default;
		LinkedListNode<System.__Canon> linkedListNode;
		PeerBase peerBase;
		int num4;
		bool flag4;
		long num5;
		SimulationItem simulationItem;
		byte[] array;
		int num3;
		System.__Canon _Canon2;
		System.__Canon _Canon;
		if (num2 <= 0)
		{
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				bool flag3 = list == null;
				ex = null;
				obj6 = 0;
				_Canon = null;
				_Canon2 = (System.__Canon)(&obj7);
				linkedListNode = (LinkedListNode<System.__Canon>)(&lockTaken);
				peerBase = this;
				array = data;
				num3 = num2;
				num4 = jitterRange;
				flag4 = outgoing;
				if (flag3)
				{
					goto IL_0920;
				}
				if (list.count == 0)
				{
					bool flag5 = !lockTaken;
					linkedListNode = (LinkedListNode<System.__Canon>)(&lockTaken);
					object obj8 = list;
					if (!flag5)
					{
						Monitor.Exit(list);
						linkedListNode = null;
						obj8 = list;
					}
					if (outgoing)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						if (PhotonSocket == null)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						bool flag6 = PhotonSocket == null;
						ex = null;
						obj6 = 0;
						_Canon = null;
						_Canon2 = (System.__Canon)(&obj7);
						peerBase = this;
						num5 = jitterRange;
						simulationItem = (SimulationItem)outgoing;
						if (!flag6)
						{
							if (!PhotonSocket.Connected)
							{
								return;
							}
							peerBase = (PeerBase)(object)PhotonSocket;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							bool flag7 = data == null;
							ex = null;
							obj6 = 0;
							_Canon = null;
							_Canon2 = (System.__Canon)(&obj7);
							linkedListNode = null;
							num5 = jitterRange;
							simulationItem = (SimulationItem)outgoing;
							if (!flag7)
							{
								bool flag8 = peerBase == null;
								ex = null;
								obj6 = 0;
								_Canon = null;
								_Canon2 = (System.__Canon)(&obj7);
								linkedListNode = null;
								num5 = jitterRange;
								simulationItem = (SimulationItem)outgoing;
								if (!flag8)
								{
									sbyte b = ((Enum)(object)peerBase).System_002EIConvertible_002EToSByte((IFormatProvider)(object)data);
									return;
								}
							}
						}
					}
					else
					{
						bool flag9 = data == null;
						ex = null;
						obj6 = 0;
						_Canon = null;
						_Canon2 = (System.__Canon)(&obj7);
						peerBase = this;
						num5 = jitterRange;
						simulationItem = (SimulationItem)outgoing;
						if (!flag9)
						{
							decimal num6 = ((Enum)this).System_002EIConvertible_002EToDecimal((IFormatProvider)(object)data);
							return;
						}
					}
					goto IL_08ab;
				}
			}
		}
		bool flag10 = watch == null;
		ex = null;
		obj6 = 0;
		_Canon = null;
		_Canon2 = (System.__Canon)(&obj7);
		linkedListNode = (LinkedListNode<System.__Canon>)(&lockTaken);
		peerBase = this;
		array = data;
		num3 = num2;
		num4 = jitterRange;
		flag4 = outgoing;
		if (flag10)
		{
			goto IL_08e6;
		}
		long elapsedMilliseconds = watch.ElapsedMilliseconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65165F0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SimulationItem simulationItem2 = default;
		simulationItem2._002Ector();
		bool flag11 = simulationItem2 == null;
		ex = null;
		obj6 = 0;
		_Canon = null;
		_Canon2 = (System.__Canon)(&obj7);
		byte[] array2 = null;
		peerBase = this;
		array = data;
		num3 = num2;
		num4 = (int)elapsedMilliseconds;
		flag4 = (byte)(int)simulationItem2 != 0;
		if (flag11)
		{
			goto IL_08fc;
		}
		object obj10 = simulationItem2 + 32;
		obj10 = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num7 = obj4 + num2;
		array = (byte[])(num7 + elapsedMilliseconds);
		simulationItem2.Delay__BackingField = num7;
		simulationItem2.TimeToExecute = (int)array;
		bool flag12 = list == null;
		ex = null;
		obj6 = 0;
		_Canon = null;
		_Canon2 = (System.__Canon)(&obj7);
		array2 = data;
		peerBase = this;
		num3 = num2;
		num4 = (int)elapsedMilliseconds;
		flag4 = (byte)(int)simulationItem2 != 0;
		LinkedListNode<System.__Canon> linkedListNode2;
		if (!flag12)
		{
			bool flag13 = usedTransportProtocol == 0;
			object obj11 = !flag13;
			if (obj11 == null && list.count != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65165E8]");
				object obj12 = 0;
				linkedListNode = (LinkedListNode<System.__Canon>)obj12;
				LinkedListNode<System.__Canon> last = ((LinkedList<System.__Canon>)(object)list).Last;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65165C0]");
				num3 = 0;
				_Canon2 = (System.__Canon)(&obj7);
				linkedListNode2 = last;
				while (linkedListNode2 != null)
				{
					_Canon2 = linkedListNode2.item;
					if (linkedListNode2.item != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v6 (System.__Canon)+18]");
						_Canon2 = (System.__Canon)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v6 (System.__Canon)+18]");
						if (0 > (nint)array)
						{
							linkedListNode = (LinkedListNode<System.__Canon>)((int*)num3)->m_value;
							LinkedListNode<System.__Canon> previous = linkedListNode2.Previous;
							linkedListNode2 = previous;
							continue;
						}
						goto IL_04d4;
					}
					goto IL_0875;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65165D8]");
				object obj13 = 0;
				_Canon = (System.__Canon)obj13;
				LinkedListNode<System.__Canon> linkedListNode3 = ((LinkedList<System.__Canon>)(object)list).AddFirst((System.__Canon)(object)simulationItem2);
				ex = null;
				obj6 = 0;
				linkedListNode = (LinkedListNode<System.__Canon>)(object)simulationItem2;
				peerBase = this;
				num5 = elapsedMilliseconds;
				simulationItem = simulationItem2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65165E0]");
				object obj14 = 0;
				_Canon = (System.__Canon)obj14;
				LinkedListNode<System.__Canon> linkedListNode4 = ((LinkedList<System.__Canon>)(object)list).AddLast((System.__Canon)(object)simulationItem2);
				ex = null;
				obj6 = 0;
				_Canon2 = (System.__Canon)(&obj7);
				linkedListNode = (LinkedListNode<System.__Canon>)(object)simulationItem2;
				peerBase = this;
				num5 = elapsedMilliseconds;
				simulationItem = simulationItem2;
			}
			goto IL_0531;
		}
		goto IL_090a;
		IL_0875:
		NullReferenceException ex2 = new NullReferenceException();
		ex = null;
		obj6 = 0;
		_Canon = null;
		peerBase = this;
		num5 = elapsedMilliseconds;
		simulationItem = simulationItem2;
		goto IL_08ab;
		IL_08fc:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_090a;
		IL_090a:
		NullReferenceException ex4 = new NullReferenceException();
		linkedListNode = (LinkedListNode<System.__Canon>)(object)array2;
		goto IL_0920;
		IL_0531:
		object obj15 = (object)(&lockTaken);
		if (obj15 != null)
		{
			System.__Canon obj16 = (System.__Canon)(&obj7);
			Monitor.Exit(obj16);
			linkedListNode = null;
		}
		bool flag14 = ex == null;
		object obj17 = !flag14;
		if (obj17 != null)
		{
			goto IL_08b9;
		}
		bool flag15 = obj6 == null;
		object obj18 = !flag15;
		OutOfMemoryException ex5 = ex;
		num4 = (int)num5;
		flag4 = (byte)(int)simulationItem != 0;
		if (obj18 == null)
		{
			NetworkSimulationSet networkSimulationSet = peerBase.networkSimulationSettings;
			if (peerBase.networkSimulationSettings != null && networkSimulationSet.NetSimWakeEvent != null)
			{
				bool flag16 = networkSimulationSet.NetSimWakeEvent.Set();
				return;
			}
			goto IL_08ab;
		}
		goto IL_08d7;
		IL_08d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_08e6;
		IL_08b9:
		ex5 = new OutOfMemoryException();
		num4 = (int)num5;
		flag4 = (byte)(int)simulationItem != 0;
		goto IL_08d7;
		IL_08e6:
		NullReferenceException ex6 = new NullReferenceException();
		array2 = (byte[])(object)linkedListNode;
		goto IL_08fc;
		IL_08ab:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_08b9;
		IL_0920:
		NullReferenceException ex8 = new NullReferenceException();
		if ((nint)linkedListNode == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj6 = 1;
			num5 = num4;
			simulationItem = (SimulationItem)flag4;
		}
		else
		{
			if ((nint)linkedListNode != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj19 = default;
			ex = (OutOfMemoryException)obj19;
			num5 = num4;
			simulationItem = (SimulationItem)flag4;
		}
		goto IL_0531;
		IL_04d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65165D0]");
		_Canon2 = (System.__Canon)0;
		LinkedListNode<System.__Canon> linkedListNode5 = ((LinkedList<System.__Canon>)(object)list).AddAfter(linkedListNode2, (System.__Canon)(object)simulationItem2);
		ex = null;
		obj6 = 0;
		_Canon = (System.__Canon)(object)simulationItem2;
		linkedListNode = linkedListNode2;
		peerBase = this;
		num5 = elapsedMilliseconds;
		simulationItem = simulationItem2;
		goto IL_0531;
	}

	protected internal void NetworkSimRun()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0161: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516608]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516610]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = obj2;
		List<System.__Canon> list = default;
		list._002Ector();
		while (true)
		{
			bool flag = networkSimulationSettings.ShouldNetSimThreadExit();
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				break;
			}
			NetSimDeliverDue(NetSimListIncoming, (List<SimulationItem>)(object)list, outgoing: false);
			NetSimDeliverDue(NetSimListOutgoing, (List<SimulationItem>)(object)list, outgoing: true);
			long num = NetSimTimeUntilNextDue();
			long num2 = num & -9223372036854775808L;
			bool flag3 = num2 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				bool flag4 = num < 3;
				object obj6 = !flag4;
				object obj7 = ~obj6;
				if (obj7 == null)
				{
					NetworkSimulationSet networkSimulationSet = networkSimulationSettings;
					obj3 = num - 2;
					bool flag5 = networkSimulationSet.NetSimWakeEvent.Equals(obj3);
				}
				else
				{
					Thread.SpinWait(100);
					obj3 = null;
				}
			}
			else
			{
				NetworkSimulationSet networkSimulationSet2 = networkSimulationSettings;
				AutoResetEvent netSimWakeEvent = networkSimulationSet2.NetSimWakeEvent;
				nint num3 = (nint)netSimWakeEvent;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6 (Il2CppClass<System.Threading.AutoResetEvent>)+1E0]");
				obj3 = 0;
				((System.Threading.Tasks.ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>)(object)netSimWakeEvent).InnerInvoke();
			}
		}
	}

	private unsafe void NetSimDeliverDue(LinkedList<SimulationItem> list, List<SimulationItem> dueItems, bool outgoing)
	{
		//IL_099e: Expected I4, but got Obj
		//IL_09af: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got Ref
		//IL_00f0: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I4
		//IL_0421: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got Ref
		//IL_0448: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got Ref
		//IL_091c: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_096b: Expected Obj, but got I4
		//IL_0456: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got Ref
		//IL_04a6: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got Ref
		//IL_04f3: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I
		//IL_03f5: Expected I4, but got Obj
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_07bb: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I
		//IL_0808: Expected Obj, but got I
		//IL_05de: Expected Obj, but got I4
		//IL_081b: Expected I, but got Obj
		//IL_082b: Expected Obj, but got I
		//IL_084d: Expected Obj, but got I
		//IL_0851: Expected Obj, but got VT
		//IL_0871: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_06ed: Expected I, but got Obj
		//IL_06fd: Expected Obj, but got I
		//IL_0724: Expected Obj, but got I
		//IL_0728: Expected Obj, but got I4
		bool flag = dueItems == null;
		bool lockTaken = false;
		LinkedList<SimulationItem> linkedList = null;
		bool flag2 = outgoing;
		int num = (int)list;
		List<SimulationItem> list2 = dueItems;
		PhotonSocket photonSocket = (PhotonSocket)109924352;
		if (flag)
		{
			goto IL_0877;
		}
		int version = dueItems._version + 1;
		dueItems._size = 0;
		dueItems._version = version;
		bool flag3 = dueItems._size < 1;
		flag2 = outgoing;
		if (!flag3)
		{
			Array.Clear(dueItems._items, 0, dueItems._size);
			flag2 = false;
		}
		Monitor.Enter(list, ref lockTaken);
		bool flag4 = list == null;
		object obj = 0;
		NullReferenceException ex = null;
		nint num2 = (nint)(&linkedList);
		object obj2 = (object)(&lockTaken);
		lockTaken = false;
		linkedList = list;
		nint num3 = (nint)(&linkedList);
		num = (int)(&lockTaken);
		list2 = null;
		photonSocket = (PhotonSocket)109924352;
		if (flag4)
		{
			goto IL_08bd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516628]");
		int num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516618]");
		object obj3 = 0;
		num3 = (nint)(&linkedList);
		num = (int)(&lockTaken);
		list2 = null;
		photonSocket = (PhotonSocket)109924352;
		while (true)
		{
			LinkedListNode<SimulationItem> head = list.head;
			if (list.head == null)
			{
				break;
			}
			System.__Canon item = (System.__Canon)(object)head.item;
			bool flag5 = head.item == null;
			obj = 0;
			ex = null;
			num2 = (nint)(&linkedList);
			obj2 = (object)(&lockTaken);
			lockTaken = false;
			linkedList = list;
			photonSocket = (PhotonSocket)(object)head.item;
			if (flag5)
			{
				goto IL_0893;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X23_v20 (System.__Canon)+10]");
			bool flag6 = (nint)0 == 0;
			obj = 0;
			ex = null;
			num2 = (nint)(&linkedList);
			obj2 = (object)(&lockTaken);
			lockTaken = false;
			linkedList = list;
			photonSocket = (PhotonSocket)(object)head.item;
			if (flag6)
			{
				goto IL_0885;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X23_v20 (System.__Canon)+10]");
			long elapsedMilliseconds = ((Stopwatch)0).ElapsedMilliseconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X23_v20 (System.__Canon)+28]");
			bool flag7 = elapsedMilliseconds < 0;
			num = 0;
			photonSocket = (PhotonSocket)(object)head.item;
			if (flag7)
			{
				break;
			}
			SimulationItem[] items = dueItems._items;
			int num5 = ((int*)num4)->m_value;
			int version2 = dueItems._version + 1;
			dueItems._version = version2;
			bool flag8 = dueItems._items == null;
			obj = 0;
			ex = null;
			num2 = (nint)(&linkedList);
			obj2 = (object)(&lockTaken);
			lockTaken = false;
			linkedList = list;
			num3 = ((int*)num4)->m_value;
			num = 0;
			photonSocket = (PhotonSocket)(object)head.item;
			if (!flag8)
			{
				version2 = dueItems._size;
				bool flag9 = dueItems._size < items.Length;
				object obj4 = !flag9;
				if (obj4 == null)
				{
					object obj5 = dueItems._items + dueItems._size;
					num5 = ++dueItems._size;
					object obj6 = obj5 + 32;
					obj6 = head.item;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v17 (System.Int32)+20]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v37+A8]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v38+70]");
					list2 = (List<SimulationItem>)0;
					((List<System.__Canon>)(object)dueItems).AddWithResize((System.__Canon)(object)head.item);
				}
				num = (int)obj3;
				((LinkedList<System.__Canon>)(object)list).RemoveFirst();
				num3 = num5;
				photonSocket = (PhotonSocket)(object)head.item;
				continue;
			}
			goto IL_08a1;
		}
		obj = 0;
		ex = null;
		num2 = (nint)(&linkedList);
		obj2 = (object)(&lockTaken);
		lockTaken = false;
		object obj9 = 6;
		goto IL_0a3e;
		IL_08cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj10 = default;
			ex = (NullReferenceException)obj10;
		}
		obj9 = 0;
		goto IL_0a3e;
		IL_08a1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_08af;
		IL_0885:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0893;
		IL_08af:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_08bd;
		IL_08bd:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_08cb;
		IL_0877:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0885;
		IL_0893:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_08a1;
		IL_0a3e:
		if (obj2 != null)
		{
			Monitor.Exit(num2);
			num = 0;
		}
		bool flag10 = ex == null;
		object obj11 = !flag10;
		if (obj11 != null)
		{
			goto IL_08af;
		}
		bool flag11 = obj == null;
		object obj12 = !flag11;
		ex5 = ex;
		if (obj12 == null)
		{
			if ((nint)obj9 != 6)
			{
				bool flag12 = obj9 == null;
				object obj13 = !flag12;
				if (obj13 != null)
				{
					return;
				}
			}
			if (dueItems._size < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516640]");
			obj3 = 0;
			NullReferenceException ex8 = ex;
			int num6 = 0;
			while (true)
			{
				if (outgoing)
				{
					photonSocket = PhotonSocket;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					if (PhotonSocket != null)
					{
						photonSocket = PhotonSocket;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						if (PhotonSocket == null)
						{
							break;
						}
						bool connected = PhotonSocket.Connected;
						bool flag13 = !connected;
						num = 0;
						ex8 = (NullReferenceException)connected;
						if (!flag13)
						{
							photonSocket = PhotonSocket;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							list2 = (List<SimulationItem>)obj3;
							System.__Canon _Canon = ((List<System.__Canon>)(object)dueItems).get_Item(num6);
							bool flag14 = _Canon == null;
							num = num6;
							if (flag14)
							{
								break;
							}
							list2 = (List<SimulationItem>)obj3;
							System.__Canon _Canon2 = ((List<System.__Canon>)(object)dueItems).get_Item(num6);
							bool flag15 = _Canon2 == null;
							num = num6;
							if (flag15)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v22 (System.__Canon)+20]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v22 (System.__Canon)+20]");
							bool flag16 = (nint)0 == 0;
							num = num6;
							if (flag16)
							{
								break;
							}
							bool flag17 = PhotonSocket == null;
							num = num6;
							if (flag17)
							{
								break;
							}
							num3 = (nint)photonSocket;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v15+18]");
							list2 = (List<SimulationItem>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X9_v4 (Il2CppClass<Photon.Client.PeerBase>)+1A0]");
							flag2 = false;
							PhotonSocket photonSocket2 = PhotonSocket;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v20 (System.__Canon)+20]");
							ex8 = (NullReferenceException)((Enum)(object)photonSocket2).System_002EIConvertible_002EToSByte((IFormatProvider)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v20 (System.__Canon)+20]");
							num = 0;
						}
					}
				}
				else
				{
					list2 = (List<SimulationItem>)obj3;
					System.__Canon _Canon3 = ((List<System.__Canon>)(object)dueItems).get_Item(num6);
					bool flag18 = _Canon3 == null;
					num = num6;
					if (flag18)
					{
						break;
					}
					list2 = (List<SimulationItem>)obj3;
					System.__Canon _Canon4 = ((List<System.__Canon>)(object)dueItems).get_Item(num6);
					bool flag19 = _Canon4 == null;
					num = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9 (System.__Canon)+20]");
					photonSocket = (PhotonSocket)0;
					if (flag19)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v11 (System.__Canon)+20]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v11 (System.__Canon)+20]");
					bool flag20 = (nint)0 == 0;
					num = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9 (System.__Canon)+20]");
					photonSocket = (PhotonSocket)0;
					if (flag20)
					{
						break;
					}
					num3 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v13+18]");
					list2 = (List<SimulationItem>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X9_v4 (Il2CppClass<Photon.Client.PeerBase>)+240]");
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9 (System.__Canon)+20]");
					ex8 = (NullReferenceException)((Enum)this).System_002EIConvertible_002EToDecimal((IFormatProvider)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9 (System.__Canon)+20]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9 (System.__Canon)+20]");
					photonSocket = (PhotonSocket)0;
				}
				num6++;
				if (num6 >= dueItems._size)
				{
					return;
				}
			}
			goto IL_0877;
		}
		goto IL_08cb;
	}

	private long NetSimTimeUntilNextDue()
	{
		//IL_0010: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I8
		//IL_00e1: Expected Obj, but got I4
		//IL_010e: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long val = NetSimHeadRemaining(NetSimListIncoming);
		long val2 = NetSimHeadRemaining(NetSimListOutgoing);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long num = Math.Min(val, val2);
		long num2 = ~num;
		long result = num & num2;
		object obj7 = num - 9223372036854775807L;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			return result;
		}
		return -1L;
	}

	private unsafe static long NetSimHeadRemaining(LinkedList<SimulationItem> list)
	{
		//IL_02a1: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got Ref
		//IL_00ff: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got Ref
		//IL_02bf: Expected Obj, but got Ref
		//IL_0063: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got Ref
		//IL_0152: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got Ref
		//IL_0133: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got Ref
		//IL_017a: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		//IL_026d: Expected I8, but got I4
		bool lockTaken = default;
		Monitor.Enter(list, ref lockTaken);
		bool flag = list == null;
		NullReferenceException ex = null;
		object obj = 0;
		object obj2 = (object)(&lockTaken);
		if (flag)
		{
			goto IL_01a3;
		}
		LinkedListNode<SimulationItem> head = list.head;
		long result;
		if (list.head != null)
		{
			SimulationItem item = head.item;
			bool flag2 = head.item == null;
			ex = null;
			obj = 0;
			obj2 = (object)(&lockTaken);
			if (flag2)
			{
				goto IL_01c0;
			}
			bool flag3 = item.stopw == null;
			ex = null;
			obj = 0;
			obj2 = (object)(&lockTaken);
			if (flag3)
			{
				goto IL_01ce;
			}
			long elapsedMilliseconds = item.stopw.ElapsedMilliseconds;
			result = item.Delay__BackingField - elapsedMilliseconds;
			ex = null;
			obj = 0;
			obj2 = 0;
		}
		else
		{
			ex = null;
			obj = 0;
			obj2 = (object)(&lockTaken);
			result = 9223372036854775807L;
		}
		goto IL_02b7;
		IL_02b7:
		object obj3 = (object)(&lockTaken);
		if (obj3 != null)
		{
			object obj5 = default;
			object obj4 = (object)(&obj5);
			Monitor.Exit(obj4);
			obj2 = 0;
		}
		bool flag4 = ex == null;
		object obj6 = !flag4;
		NullReferenceException ex2;
		if (obj6 == null)
		{
			bool flag5 = obj == null;
			object obj7 = !flag5;
			ex2 = ex;
			if (obj7 == null)
			{
				return result;
			}
			goto IL_01b1;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_01a3;
		IL_01c0:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_01ce;
		IL_01ce:
		NullReferenceException ex5 = new NullReferenceException();
		if ((nint)obj2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)obj2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				long result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj8 = default;
			ex = (NullReferenceException)obj8;
		}
		result = 0L;
		goto IL_02b7;
		IL_01b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_01c0;
		IL_01a3:
		ex2 = new NullReferenceException();
		goto IL_01b1;
	}

	static PeerBase()
	{
		//IL_0010: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_015f: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_003d: Expected I, but got Obj
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516648]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516658]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516670]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516650]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516678]");
		object obj5 = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516668]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516660]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<System.__Canon> func = default;
		func._002Ector(obj11, (IntPtr)obj3);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v5+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector(obj13, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4098DE4");
		object obj14 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+A0]");
		object obj15 = (nint)0 + (nint)8;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void _003CDeserializeMessageAndCallback_003Eb__121_0()
	{
		OnInitResponse();
	}
}
