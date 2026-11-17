using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Fusion.Sockets.Stun;
using Photon.Client.Encryption;
using Unity.IL2CPP.Metadata;

namespace Photon.Client;

public class PhotonPeer
{
	public const bool NoSocket = default(bool);

	public const bool DebugBuild = default(bool);

	public const int NativeEncryptorApiVersion = default(int);

	public TargetFrameworks TargetFramework;

	public byte ClientSdkId;

	private static string clientVersion;

	public static bool NoNativeCallbacks;

	public bool RemoveAppIdFromWebSocketPath;

	internal bool UseInitV3;

	public bool EnableEncryptedFlag;

	private SerializationProtocol SerializationProtocolType__BackingField;

	public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig;

	private Type SocketImplementation__BackingField;

	public LogLevel LogLevel;

	private IPhotonPeerListener Listener__BackingField;

	private bool reuseEventInstance;

	private bool useByteArraySlicePoolForEvents;

	private bool wrapIncomingStructs;

	public bool SendInCreationOrder;

	public int SendWindowSize;

	private byte quickResendAttempts;

	public int MaxResends;

	public int InitialResendTimeMax;

	private int disconnectTimeout;

	private bool crcEnabled;

	public int PingInterval;

	public byte ChannelCount;

	private ConnectionProtocol TransportProtocol__BackingField;

	public static int OutgoingStreamBufferSize;

	private int mtu;

	public static bool AsyncKeyExchange;

	internal bool RandomizeSequenceNumbers;

	internal byte[] RandomizedSequenceNumbers;

	private Type payloadEncryptorType;

	protected internal byte[] PayloadEncryptionSecret;

	private Type encryptorType;

	protected internal IPhotonEncryptor Encryptor;

	public ITrafficRecorder TrafficRecorder;

	private bool EnableServerTracing__BackingField;

	public bool PingUsedAsInit;

	private int CountDiscarded__BackingField;

	private int DeltaUnreliableNumber__BackingField;

	private TrafficStats Stats__BackingField;

	public bool TrafficStatsEnabled;

	internal PeerBase peerBase;

	internal readonly object sendOutgoingLockObject;

	private readonly object dispatchLockObject;

	internal readonly object enqueueLock;

	protected internal byte ClientSdkIdShifted => (byte)(ClientSdkId << 1);

	public unsafe static string Version
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0767: Expected Obj, but got I4
			//IL_080f: Expected Obj, but got I
			//IL_06df: Expected Obj, but got I4
			//IL_07fa: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I4
			//IL_0785: Expected Obj, but got I
			//IL_07a5: Expected Obj, but got I4
			//IL_00c5: Expected Obj, but got I4
			//IL_00e3: Expected Obj, but got I
			//IL_0104: Expected Obj, but got Ref
			//IL_0129: Expected Obj, but got Ref
			//IL_013f: Expected I, but got Obj
			//IL_014f: Expected Obj, but got I
			//IL_0178: Expected Obj, but got I
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected Obj, but got Unknown
			//IL_01e5: Expected Obj, but got I
			//IL_022c: Expected Obj, but got I8
			//IL_0272: Expected Obj, but got Ref
			//IL_02e3: Expected Obj, but got I8
			//IL_0288: Expected I, but got Obj
			//IL_0298: Expected Obj, but got I
			//IL_02c1: Expected Obj, but got I
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Expected Obj, but got Unknown
			//IL_0340: Expected Obj, but got I
			//IL_038f: Expected Obj, but got I4
			//IL_03a5: Expected Obj, but got I
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Expected Obj, but got Unknown
			//IL_0401: Expected Obj, but got Ref
			//IL_047a: Expected Obj, but got I4
			//IL_048a: Expected Obj, but got I4
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Expected Obj, but got Unknown
			//IL_0417: Expected I, but got Obj
			//IL_0427: Expected Obj, but got I
			//IL_0450: Expected Obj, but got I
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Expected Obj, but got Unknown
			//IL_04fd: Expected Obj, but got I
			//IL_0544: Expected Obj, but got I8
			//IL_058a: Expected Obj, but got Ref
			//IL_05fb: Expected Obj, but got I8
			//IL_05a0: Expected I, but got Obj
			//IL_05b0: Expected Obj, but got I
			//IL_05d9: Expected Obj, but got I
			//IL_0629: Unknown result type (might be due to invalid IL or missing references)
			//IL_062e: Expected Obj, but got Unknown
			//IL_0650: Expected Obj, but got I
			//IL_0690: Expected Obj, but got I4
			//IL_07c3: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B38]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object value = 0;
			bool flag2 = string.IsNullOrEmpty((string)value);
			bool flag3 = !flag2;
			string text = null;
			if (flag3)
			{
				goto IL_06b5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163F0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v11+A0]");
			object obj8 = 0;
			object obj9 = obj8;
			bool flag5 = obj8 == null;
			object obj10 = 4;
			NullReferenceException ex = default;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+18]");
				bool flag6 = (nint)0 == 0;
				obj10 = 4;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object[] array = default;
					bool flag7 = array == null;
					object obj12 = default;
					obj10 = (object)(&obj12);
					if (flag7)
					{
						goto IL_0712;
					}
					object obj13 = default;
					bool flag8 = obj13 == null;
					object obj14 = (object)(&obj12);
					if (!flag8)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag9 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
						obj10 = 0;
						if (flag9)
						{
							goto IL_0720;
						}
					}
					bool flag10 = array.Length == 0;
					obj10 = obj14;
					if (!flag10)
					{
						object obj15 = array + 32;
						obj15 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj16 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v20+A0]");
						object obj17 = 0;
						object obj18 = obj17;
						bool flag11 = obj17 == null;
						obj10 = obj13;
						if (flag11)
						{
							goto IL_0712;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v22+18]");
						object obj19 = 0 & 0xFFFFFFFEL;
						bool flag12 = obj19 == null;
						obj10 = obj13;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj20 = default;
							bool flag13 = obj20 == null;
							object obj22 = default;
							object obj21 = (object)(&obj22);
							if (!flag13)
							{
								nint num2 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
								obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag14 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
								obj10 = 0;
								if (flag14)
								{
									goto IL_0720;
								}
							}
							object obj23 = array.Length & 0xFFFFFFFEL;
							bool flag15 = obj23 == null;
							obj10 = obj21;
							if (!flag15)
							{
								object obj24 = array + 40;
								obj24 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj25 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v26+A0]");
								object obj26 = 0;
								object obj27 = obj26;
								bool flag16 = obj26 == null;
								obj10 = obj20;
								if (flag16)
								{
									goto IL_0712;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v28+18]");
								bool flag17 = (nint)0 < (nint)2;
								object obj28 = !flag17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v28+18]");
								object obj29 = -2;
								bool flag18 = obj29 == null;
								object obj30 = ~obj28;
								object obj31 = obj30 | flag18;
								obj10 = obj20;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj32 = default;
									bool flag19 = obj32 == null;
									object obj34 = default;
									object obj33 = (object)(&obj34);
									if (!flag19)
									{
										nint num3 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v46 (Il2CppClass<System.Object[]>)+40]");
										obj33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag20 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v46 (Il2CppClass<System.Object[]>)+40]");
										obj10 = 0;
										if (flag20)
										{
											goto IL_0720;
										}
									}
									bool flag21 = array.Length < 2;
									object obj35 = !flag21;
									object obj36 = array.Length - 2;
									bool flag22 = obj36 == null;
									object obj37 = ~obj35;
									object obj38 = obj37 | flag22;
									obj10 = obj33;
									if (obj38 == null)
									{
										object obj39 = array + 48;
										obj39 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj40 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v32+A0]");
										object obj41 = 0;
										object obj42 = obj41;
										bool flag23 = obj41 == null;
										obj10 = obj32;
										if (flag23)
										{
											goto IL_0712;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v34+18]");
										object obj43 = 0 & 0xFFFFFFFCL;
										bool flag24 = obj43 == null;
										obj10 = obj32;
										if (!flag24)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj44 = default;
											bool flag25 = obj44 == null;
											object obj46 = default;
											object obj45 = (object)(&obj46);
											if (!flag25)
											{
												nint num4 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
												obj45 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag26 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
												obj10 = 0;
												if (flag26)
												{
													goto IL_0720;
												}
											}
											object obj47 = array.Length & 0xFFFFFFFCL;
											bool flag27 = obj47 == null;
											obj10 = obj45;
											if (!flag27)
											{
												object obj48 = array + 56;
												obj48 = obj44;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516790]");
												object format = 0;
												string text2 = string.Format((string)format, array);
												object obj49 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v41+E4]");
												bool flag28 = (nint)0 == 0;
												object obj50 = !flag28;
												if (obj50 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj49 = obj;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v41+A0]");
												object obj51 = 0;
												obj51 = text2;
												object obj52 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												text = text2;
												goto IL_06b5;
											}
										}
									}
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			}
			goto IL_0712;
			IL_0720:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			return (string)(object)new ArgumentNullException();
			IL_0712:
			ex = new NullReferenceException();
			goto IL_0720;
			IL_06b5:
			object obj53 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v8+E4]");
			bool flag29 = (nint)0 == 0;
			object obj54 = !flag29;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj53 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v8+A0]");
			return (string)0;
		}
	}

	public bool UseAck2
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAck2Available => false;

	public SerializationProtocol SerializationProtocolType
	{
		get
		{
			return SerializationProtocolType__BackingField;
		}
		set
		{
			SerializationProtocolType__BackingField = value;
		}
	}

	public Type SocketImplementation
	{
		get
		{
			return SocketImplementation__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public int SocketErrorCode
	{
		get
		{
			//IL_00e5: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				if (peerBase.PhotonSocket != null)
				{
					PeerBase peerBase2 = this.peerBase;
					if (this.peerBase != null)
					{
						PhotonSocket photonSocket = peerBase2.PhotonSocket;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						if (peerBase2.PhotonSocket != null)
						{
							return photonSocket.SocketErrorCode__BackingField;
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (int)ex;
				}
			}
			return 0;
		}
	}

	public LogLevel DebugOut
	{
		get
		{
			return LogLevel;
		}
		set
		{
			LogLevel = value;
		}
	}

	public IPhotonPeerListener Listener
	{
		get
		{
			return Listener__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public PeerStateValue PeerState
	{
		get
		{
			//IL_00f3: Expected I4, but got Obj
			//IL_0046: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got I4
			if (this.peerBase != null)
			{
				ConnectionStateValue peerConnectionState = this.peerBase.peerConnectionState;
				PeerBase peerBase = this.peerBase;
				object obj = peerConnectionState & (ConnectionStateValue)0xFF;
				if ((nint)obj == 3)
				{
					if (this.peerBase != null)
					{
						bool flag = (byte)(~(peerBase.ApplicationIsInitialized ? 1u : 0u)) != 0;
						object obj2 = !flag;
						if (obj2 == null)
						{
							return (PeerStateValue)10;
						}
						goto IL_00d1;
					}
				}
				else if (this.peerBase != null)
				{
					goto IL_00d1;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (PeerStateValue)(int)ex;
			IL_00d1:
			return (PeerStateValue)this.peerBase.peerConnectionState;
		}
	}

	public string PeerID
	{
		get
		{
			//IL_0031: Expected I, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				nint num = (nint)peerBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (Il2CppClass<Photon.Client.PeerBase>)+198] (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public unsafe bool ReuseEventInstance
	{
		get
		{
			return reuseEventInstance;
		}
		set
		{
			//IL_0033: Expected Obj, but got I4
			//IL_003b: Expected Obj, but got Ref
			//IL_0044: Expected Obj, but got I4
			//IL_00d3: Expected Obj, but got Ref
			//IL_0129: Expected Obj, but got I4
			//IL_0070: Expected Obj, but got Ref
			//IL_0079: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got Ref
			//IL_010a: Expected Obj, but got I4
			//IL_0151: Expected Obj, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_00a5: Expected Obj, but got I4
			//IL_00b8: Expected Obj, but got I4
			//IL_00c1: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got I4
			bool lockTaken = default;
			Monitor.Enter(dispatchLockObject, ref lockTaken);
			reuseEventInstance = value;
			bool flag = !value;
			object obj = !flag;
			object obj2 = (object)(&lockTaken);
			object obj3 = 0;
			OutOfMemoryException ex = null;
			if (obj == null)
			{
				bool flag2 = peerBase == null;
				obj2 = (object)(&lockTaken);
				obj3 = 0;
				ex = null;
				if (flag2)
				{
					goto IL_0185;
				}
				object obj4 = peerBase + 184;
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj2 = 0;
				obj3 = 0;
				ex = null;
			}
			goto IL_00cb;
			IL_00cb:
			object obj5 = (object)(&lockTaken);
			if (obj5 != null)
			{
				object obj7 = default;
				object obj6 = (object)(&obj7);
				Monitor.Exit(obj6);
				obj2 = 0;
			}
			bool flag3 = ex == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				bool flag4 = obj3 == null;
				object obj9 = !flag4;
				OutOfMemoryException ex2 = ex;
				if (obj9 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0185;
			IL_0185:
			NullReferenceException ex3 = new NullReferenceException();
			if ((nint)obj2 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj3 = 1;
			}
			else
			{
				if ((nint)obj2 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj10 = default;
				ex = (OutOfMemoryException)obj10;
			}
			goto IL_00cb;
		}
	}

	public bool UseByteArraySlicePoolForEvents
	{
		get
		{
			return useByteArraySlicePoolForEvents;
		}
		set
		{
			useByteArraySlicePoolForEvents = value;
		}
	}

	public bool WrapIncomingStructs
	{
		get
		{
			return wrapIncomingStructs;
		}
		set
		{
			wrapIncomingStructs = value;
		}
	}

	public ByteArraySlicePool ByteArraySlicePool
	{
		get
		{
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				Protocol serializationProtocol = peerBase.SerializationProtocol;
				if (peerBase.SerializationProtocol != null)
				{
					return serializationProtocol.ByteArraySlicePool;
				}
			}
			return (ByteArraySlicePool)(object)new NullReferenceException();
		}
	}

	public static Pool<StreamBuffer> MessageBufferPool
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return (Pool<StreamBuffer>)0;
		}
	}

	public int SequenceDeltaLimitSends
	{
		get
		{
			return SendWindowSize;
		}
		set
		{
			SendWindowSize = value;
		}
	}

	public byte QuickResendAttempts
	{
		get
		{
			return quickResendAttempts;
		}
		set
		{
			//IL_0032: Expected Obj, but got I4
			//IL_0040: Expected Obj, but got I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			int num = value & 0xFF;
			quickResendAttempts = value;
			bool flag = num < 4;
			object obj = !flag;
			object obj2 = num - 4;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			byte b;
			if (obj4 == null)
			{
				b = 4;
			}
			else
			{
				if ((value & 0xFF) != 0)
				{
					return;
				}
				b = 1;
			}
			quickResendAttempts = b;
		}
	}

	public int SentCountAllowance
	{
		get
		{
			return MaxResends;
		}
		set
		{
			MaxResends = value;
		}
	}

	public int DisconnectTimeout
	{
		get
		{
			return disconnectTimeout;
		}
		set
		{
			//IL_0012: Expected I4, but got I8
			if ((int)(value & 0x80000000L) != 0)
			{
				disconnectTimeout = 10000;
			}
			disconnectTimeout = value;
		}
	}

	public bool CrcEnabled
	{
		get
		{
			return crcEnabled;
		}
		set
		{
			//IL_003b: Expected Obj, but got I4
			//IL_0055: Expected Obj, but got I4
			bool flag = default;
			if (crcEnabled != flag)
			{
				ConnectionStateValue peerConnectionState = peerBase.peerConnectionState;
				object obj = peerConnectionState & (ConnectionStateValue)0xFF;
				bool flag2 = obj == null;
				object obj2 = !flag2;
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Exception ex = default;
					string message = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					throw new ArgumentNullException();
				}
				crcEnabled = flag;
			}
		}
	}

	public int TimePingInterval
	{
		get
		{
			return PingInterval;
		}
		set
		{
			PingInterval = value;
		}
	}

	public string ServerAddress
	{
		get
		{
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.ServerAddress__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public string ServerIpAddress
	{
		get
		{
			//IL_00d2: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I
			//IL_00f2: Expected Obj, but got I
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected Obj, but got Unknown
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				if (peerBase.PhotonSocket != null)
				{
					PeerBase peerBase2 = this.peerBase;
					if (this.peerBase != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						if (peerBase2.PhotonSocket != null)
						{
							return (string)(peerBase2.PhotonSocket + 64);
						}
					}
					return (string)(object)new NullReferenceException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v4+98]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v5+A0]");
			return (string)0;
		}
	}

	public ConnectionProtocol UsedProtocol
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.usedTransportProtocol;
			}
			NullReferenceException ex = new NullReferenceException();
			return (ConnectionProtocol)(int)ex;
		}
	}

	public ConnectionProtocol TransportProtocol
	{
		get
		{
			return TransportProtocol__BackingField;
		}
		set
		{
			TransportProtocol__BackingField = value;
		}
	}

	public unsafe virtual bool IsSimulationEnabled
	{
		get
		{
			//IL_006b: Expected I4, but got Obj
			if (peerBase != null)
			{
				NetworkSimulationSet networkSimulationSettings = peerBase.NetworkSimulationSettings;
				if (networkSimulationSettings != null)
				{
					return networkSimulationSettings.IsSimulationEnabled;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		set
		{
			//IL_00aa: Expected I, but got Obj
			//IL_00b3: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got Ref
			//IL_00c8: Expected Obj, but got Ref
			//IL_0115: Expected I, but got Obj
			//IL_011e: Expected Obj, but got I4
			//IL_012b: Expected Obj, but got Ref
			//IL_0133: Expected Obj, but got Ref
			//IL_02d1: Expected Obj, but got I4
			//IL_0170: Expected I, but got Obj
			//IL_0179: Expected Obj, but got I4
			//IL_0186: Expected Obj, but got Ref
			//IL_018e: Expected Obj, but got Ref
			//IL_01eb: Expected Obj, but got I4
			//IL_021b: Expected Obj, but got I4
			bool flag = peerBase == null;
			bool flag3 = default;
			bool flag2 = flag3;
			bool lockTaken = default;
			object obj = default;
			NullReferenceException ex = default;
			object obj2 = default;
			object obj3 = default;
			object obj4 = default;
			if (!flag)
			{
				NetworkSimulationSet networkSimulationSettings = peerBase.NetworkSimulationSettings;
				bool flag4 = networkSimulationSettings == null;
				flag2 = false;
				if (!flag4)
				{
					bool isSimulationEnabled = networkSimulationSettings.IsSimulationEnabled;
					if (isSimulationEnabled != flag3)
					{
						Monitor.Enter(sendOutgoingLockObject, ref lockTaken);
						bool flag5 = peerBase == null;
						nint num = unchecked((nint)null);
						obj = 0;
						ex = null;
						obj2 = (object)(&obj3);
						obj4 = (object)(&lockTaken);
						flag2 = (byte)(&lockTaken) != 0;
						lockTaken = false;
						obj3 = sendOutgoingLockObject;
						if (flag5)
						{
							goto IL_0264;
						}
						NetworkSimulationSet networkSimulationSettings2 = peerBase.NetworkSimulationSettings;
						bool flag6 = networkSimulationSettings2 == null;
						num = unchecked((nint)null);
						obj = 0;
						ex = null;
						obj2 = (object)(&obj3);
						obj4 = (object)(&lockTaken);
						flag2 = false;
						lockTaken = false;
						obj3 = sendOutgoingLockObject;
						if (!flag6)
						{
							networkSimulationSettings2.IsSimulationEnabled = flag3;
							num = unchecked((nint)null);
							obj = 0;
							ex = null;
							obj2 = (object)(&obj3);
							obj4 = (object)(&lockTaken);
							lockTaken = false;
							goto IL_019d;
						}
						goto IL_0281;
					}
					return;
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			lockTaken = false;
			obj3 = null;
			goto IL_0256;
			IL_019d:
			if (obj4 != null)
			{
				Monitor.Exit(obj2);
				flag3 = false;
			}
			bool flag7 = ex == null;
			object obj5 = !flag7;
			flag2 = flag3;
			if (obj5 != null)
			{
				goto IL_0256;
			}
			bool flag8 = obj == null;
			object obj6 = !flag8;
			flag2 = flag3;
			NullReferenceException ex3 = ex;
			if (obj6 == null)
			{
				return;
			}
			goto IL_0272;
			IL_0264:
			ex3 = new NullReferenceException();
			goto IL_0272;
			IL_0281:
			NullReferenceException ex4 = new NullReferenceException();
			if ((flag2 ? 1 : 0) == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj = 1;
				flag3 = flag2;
			}
			else
			{
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj7 = default;
				ex = (NullReferenceException)obj7;
				flag3 = flag2;
			}
			goto IL_019d;
			IL_0272:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0281;
			IL_0256:
			OutOfMemoryException ex5 = new OutOfMemoryException();
			goto IL_0264;
		}
	}

	public NetworkSimulationSet NetworkSimulationSettings
	{
		get
		{
			if (peerBase != null)
			{
				return peerBase.NetworkSimulationSettings;
			}
			return (NetworkSimulationSet)(object)new NullReferenceException();
		}
	}

	public unsafe int MaximumTransferUnit
	{
		get
		{
			return mtu;
		}
		set
		{
			//IL_0018: Expected Obj, but got I4
			//IL_0032: Expected Obj, but got I4
			//IL_011d: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got I4
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected I4, but got Unknown
			//IL_00bc: Expected Obj, but got I4
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected Obj, but got Unknown
			PeerStateValue peerState = PeerState;
			object obj = peerState & (PeerStateValue)0xFF;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = value - 576;
				bool flag2 = (nint)obj3 < 0;
				bool flag3 = obj3 == null;
				int num = value ^ 0x240;
				int num2 = value ^ obj3;
				int num3 = num & num2;
				bool flag4 = num3 < 0;
				bool flag5 = flag2 == flag4;
				object obj4 = !flag3;
				object obj5 = flag5 & obj4;
				object obj6 = ~obj5;
				int num4 = ((obj6 != null) ? 576 : value);
				mtu = num4;
				return;
			}
			PeerStateValue peerState2 = PeerState;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj7 = default;
			string text = ((Enum)(&obj7)).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text2 = default;
			string message = text2 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Exception ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	public bool IsEncryptionAvailable
	{
		get
		{
			//IL_004b: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				return peerBase.isEncryptionAvailable;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Type PayloadEncryptorType
	{
		get
		{
			return payloadEncryptorType;
		}
		set
		{
			//IL_025c: Expected Obj, but got I
			//IL_026c: Expected Obj, but got I
			//IL_028e: Expected Obj, but got I4
			//IL_003c: Expected Obj, but got I4
			//IL_0045: Expected Obj, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected Obj, but got Unknown
			//IL_0063: Expected Obj, but got I
			//IL_0073: Expected Obj, but got I
			//IL_0095: Expected Obj, but got I4
			//IL_00bb: Expected VT, but got Obj
			//IL_00cc: Expected I, but got Obj
			//IL_00dc: Expected Obj, but got I
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected Obj, but got Unknown
			//IL_0170: Expected Obj, but got I
			//IL_0178: Expected I, but got Obj
			//IL_0188: Expected Obj, but got I
			//IL_0198: Expected Obj, but got I
			//IL_02d8: Expected Obj, but got I
			//IL_01db: Expected Obj, but got I
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected Obj, but got Unknown
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected Obj, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected Obj, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X21_v3+E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = value == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			object obj5 = 0;
			object obj16 = default;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X21_v3+E8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65167B8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj7);
				nint num = (nint)typeFromHandle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8 (Il2CppClass<System.Type>)+2A0]");
				obj5 = 0;
				Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
				object obj9 = elementType & 1;
				if (obj9 == null)
				{
					if (LogLevel == 0)
					{
						return;
					}
					IPhotonPeerListener photonPeerListener = Listener__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
					object obj10 = 0;
					nint num2 = (nint)photonPeerListener;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65167C0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v10 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
					object obj12 = 0;
					object obj13 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v10 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_021c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v10 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
					object obj14 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X10_v7-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						obj12--;
						obj14 += 16;
						if ((nint)obj12 != 1)
						{
							continue;
						}
						goto IL_021c;
					}
					object obj15 = num2 + obj14;
					obj16 = obj15 + 312;
					goto IL_02c0;
				}
			}
			object obj17 = this + 120;
			obj17 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
			IL_02c0:
			object obj18 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v16+8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_021c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_02c0;
		}
	}

	public Type EncryptorType
	{
		get
		{
			return encryptorType;
		}
		set
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

	public int ServerTimeInMilliseconds
	{
		get
		{
			//IL_0087: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				if (~(peerBase.serverTimeOffsetIsAvailable ? 1u : 0u) == 0)
				{
					int timeInt = this.peerBase.timeInt;
					return timeInt + peerBase.serverTimeOffset;
				}
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public bool EnableServerTracing
	{
		get
		{
			return EnableServerTracing__BackingField;
		}
		set
		{
			EnableServerTracing__BackingField = value;
		}
	}

	public int ConnectionTime
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if (peerBase != null)
			{
				return peerBase.timeInt;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int RoundTripTime
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			//IL_0033: Expected I4, but got F4
			PeerBase peerBase = this.peerBase;
			if (this.peerBase == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return (int)peerBase.roundTripTime;
		}
	}

	public int RoundTripTimeVariance
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			//IL_0033: Expected I4, but got F4
			PeerBase peerBase = this.peerBase;
			if (this.peerBase == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return (int)peerBase.roundTripTimeVariance;
		}
	}

	public int LastRoundTripTime
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.lastRoundTripTime;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public long BytesIn
	{
		get
		{
			//IL_0041: Expected I8, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return ((TrafficStatsBase)trafficStats).BytesIn__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	public long BytesOut
	{
		get
		{
			//IL_0041: Expected I8, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return ((TrafficStatsBase)trafficStats).BytesOut__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	public int ByteCountCurrentDispatch
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.ByteCountCurrentDispatch;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public string CommandInfoCurrentDispatch
	{
		get
		{
			//IL_0077: Expected Obj, but got I
			//IL_0087: Expected Obj, but got I
			//IL_0097: Expected Obj, but got I
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				if (peerBase.CommandInCurrentDispatch != null)
				{
					return peerBase.CommandInCurrentDispatch.ToString(full: false);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v3+98]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v4+A0]");
				return (string)0;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public int ByteCountLastOperation
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.ByteCountLastOperation;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int PacketLossByCrc
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.packetLossByCrc;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int PacketLossByChallenge
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.packetLossByChallenge;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int ResentReliableCommands
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return ((TrafficStatsBase)trafficStats).UdpReliableCommandsResent__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastSendAckTime
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return trafficStats.LastSendAckTimestamp;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastSendAckDeltaTime
	{
		get
		{
			//IL_007c: Expected I4, but got Obj
			if (peerBase != null)
			{
				int timeInt = peerBase.timeInt;
				TrafficStats trafficStats = Stats__BackingField;
				if (Stats__BackingField != null)
				{
					return timeInt - trafficStats.LastSendAckTimestamp;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastSendOutgoingTime
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return trafficStats.LastSendOutgoingTimestamp;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastSendOutgoingDeltaTime
	{
		get
		{
			//IL_007c: Expected I4, but got Obj
			if (peerBase != null)
			{
				int timeInt = peerBase.timeInt;
				TrafficStats trafficStats = Stats__BackingField;
				if (Stats__BackingField != null)
				{
					return timeInt - trafficStats.LastSendOutgoingTimestamp;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int TimestampOfLastSocketReceive
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return trafficStats.LastReceiveTimestamp__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastReceiveDeltaTime
	{
		get
		{
			//IL_007c: Expected I4, but got Obj
			if (peerBase != null)
			{
				int timeInt = peerBase.timeInt;
				TrafficStats trafficStats = Stats__BackingField;
				if (Stats__BackingField != null)
				{
					return timeInt - trafficStats.LastReceiveTimestamp__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LongestSendCall
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				return peerBase.longestSendCall;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		set
		{
			PeerBase peerBase = this.peerBase;
			peerBase.longestSendCall = value;
		}
	}

	public int CountDiscarded
	{
		get
		{
			return CountDiscarded__BackingField;
		}
		set
		{
			CountDiscarded__BackingField = value;
		}
	}

	public int DeltaUnreliableNumber
	{
		get
		{
			return DeltaUnreliableNumber__BackingField;
		}
		set
		{
			DeltaUnreliableNumber__BackingField = value;
		}
	}

	public int QueuedIncomingCommands
	{
		get
		{
			//IL_0049: Expected I4, but got Obj
			//IL_0031: Expected I, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				nint num = (nint)peerBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (Il2CppClass<Photon.Client.PeerBase>)+178] (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int QueuedOutgoingCommands
	{
		get
		{
			//IL_0049: Expected I4, but got Obj
			//IL_0031: Expected I, but got Obj
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null)
			{
				nint num = (nint)peerBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (Il2CppClass<Photon.Client.PeerBase>)+188] (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int ReliableCommandsInFlight
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return ((TrafficStatsBase)trafficStats).UdpReliableCommandsInFlight__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int SentReliableCommandsCount
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			TrafficStats trafficStats = Stats__BackingField;
			if (Stats__BackingField != null)
			{
				return ((TrafficStatsBase)trafficStats).UdpReliableCommandsSent__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public TrafficStats Stats
	{
		get
		{
			return Stats__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 176;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public unsafe string VitalStatsToString(bool all = default(bool))
	{
		//IL_0064: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I8
		//IL_0095: Expected Obj, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_072b: Expected Obj, but got I
		//IL_074d: Expected Obj, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
		//IL_017a: Expected Obj, but got I4
		//IL_0110: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I8
		//IL_02a0: Expected Obj, but got I4
		//IL_0224: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I4
		//IL_0348: Expected I, but got Obj
		//IL_037a: Expected Obj, but got I4
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_04c8: Expected Obj, but got I8
		//IL_04e0: Expected Obj, but got I4
		//IL_0464: Expected I, but got Obj
		//IL_0496: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_05be: Expected Obj, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_05fc: Expected Obj, but got I4
		//IL_0552: Expected I, but got Obj
		//IL_0584: Expected Obj, but got I4
		//IL_0622: Expected Obj, but got I
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected Obj, but got Unknown
		//IL_068d: Expected Obj, but got I
		bool flag = peerBase == null;
		bool flag2 = all;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			int timeInt = peerBase.timeInt;
			bool flag3 = Stats__BackingField == null;
			flag2 = false;
			if (!flag3)
			{
				int num = timeInt / 1148846080;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMULH not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj = 0;
				object obj2 = 18446744073709551L + 2361183241434822607L;
				bool flag4 = num < 0;
				object obj3 = !flag4;
				bool flag5 = num == 0;
				object obj4 = ~obj3;
				object obj5 = obj4 | flag5;
				if (obj5 == null)
				{
					int num2 = obj2 / num;
				}
				else
				{
					int num2 = timeInt;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object[] array = default;
				bool flag6 = array == null;
				object obj7 = 1148846080;
				object obj8 = default;
				flag2 = (byte)(&obj8) != 0;
				if (!flag6)
				{
					bool flag8 = default;
					bool flag7 = !flag8;
					bool flag9 = (byte)(&obj8) != 0;
					if (!flag7)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
						flag9 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag10 = ex == null;
						obj7 = 1148846080;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
						flag2 = false;
						if (flag10)
						{
							goto IL_06cd;
						}
					}
					bool flag11 = array.Length == 0;
					obj7 = 1148846080;
					flag2 = flag9;
					if (!flag11)
					{
						object obj9 = array + 32;
						obj9 = flag8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag12 = Stats__BackingField == null;
						obj7 = 1148846080;
						flag2 = flag8;
						if (flag12)
						{
							goto IL_06b1;
						}
						IntPtr intPtr = default;
						((Fusion.Sockets.Stun.StunClient.List*)Stats__BackingField)->Fusion_002EIIntrusiveLinkedList_002ECopyTo((Array)0, (int)(nint)intPtr);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						bool flag14 = default;
						bool flag13 = !flag14;
						object obj10 = default;
						bool flag15 = (byte)(&obj10) != 0;
						if (!flag13)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
							flag15 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag16 = ex == null;
							obj7 = 1148846080;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
							flag2 = false;
							if (flag16)
							{
								goto IL_06cd;
							}
						}
						object obj11 = array.Length & 0xFFFFFFFEL;
						bool flag17 = obj11 == null;
						obj7 = 1148846080;
						flag2 = flag15;
						if (!flag17)
						{
							object obj12 = array + 40;
							obj12 = flag14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag18 = Stats__BackingField == null;
							obj7 = 1148846080;
							flag2 = flag14;
							if (flag18)
							{
								goto IL_06b1;
							}
							((object)Stats__BackingField).Finalize();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj13 = default;
							bool flag19 = obj13 == null;
							object obj14 = default;
							bool flag20 = (byte)(&obj14) != 0;
							if (!flag19)
							{
								nint num5 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
								flag20 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag21 = ex == null;
								obj7 = 1148846080;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
								flag2 = false;
								if (flag21)
								{
									goto IL_06cd;
								}
							}
							bool flag22 = array.Length < 2;
							object obj15 = !flag22;
							object obj16 = array.Length - 2;
							bool flag23 = obj16 == null;
							object obj17 = ~obj15;
							object obj18 = obj17 | flag23;
							obj7 = 1148846080;
							flag2 = flag20;
							if (obj18 == null)
							{
								object obj19 = array + 48;
								obj19 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj20 = default;
								bool flag24 = obj20 == null;
								object obj21 = default;
								bool flag25 = (byte)(&obj21) != 0;
								if (!flag24)
								{
									nint num6 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									flag25 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag26 = ex == null;
									obj7 = 1148846080;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									flag2 = false;
									if (flag26)
									{
										goto IL_06cd;
									}
								}
								object obj22 = array.Length & 0xFFFFFFFCL;
								bool flag27 = obj22 == null;
								obj7 = 1148846080;
								flag2 = flag25;
								if (!flag27)
								{
									object obj23 = array + 56;
									obj23 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj24 = default;
									bool flag28 = obj24 == null;
									object obj25 = default;
									bool flag29 = (byte)(&obj25) != 0;
									if (!flag28)
									{
										nint num7 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
										flag29 = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag30 = ex == null;
										obj7 = 1148846080;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
										flag2 = false;
										if (flag30)
										{
											goto IL_06cd;
										}
									}
									bool flag31 = array.Length < 4;
									object obj26 = !flag31;
									object obj27 = array.Length - 4;
									bool flag32 = obj27 == null;
									object obj28 = ~obj26;
									object obj29 = obj28 | flag32;
									obj7 = 1148846080;
									flag2 = flag29;
									if (obj29 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65167D8]");
										object format = 0;
										object obj30 = array + 64;
										obj30 = obj24;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string text = string.Format((string)format, array);
										bool flag33 = !all;
										string result = text;
										if (!flag33)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65167E0]");
											object format2 = 0;
											string text2 = string.Format((string)format2, text, Stats__BackingField);
											result = text2;
										}
										return result;
									}
								}
							}
						}
					}
					goto IL_06bf;
				}
			}
		}
		goto IL_06b1;
		IL_06bf:
		ex = new IndexOutOfRangeException();
		goto IL_06cd;
		IL_06b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06bf;
		IL_06cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (string)(object)new ArgumentNullException();
	}

	public PhotonPeer(ConnectionProtocol protocolType)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_016b: Expected VT, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01af: Expected VT, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_01e3: Expected VT, but got Obj
		//IL_0207: Expected VT, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65167E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65167F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65167F8]");
		object obj4 = 0;
		ClientSdkId = 15;
		LogLevel = (LogLevel)1;
		TargetFramework = (TargetFrameworks)2;
		SendWindowSize = 50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDF8]");
		reuseEventInstance = false;
		disconnectTimeout = 10000;
		PingInterval = 1000;
		EnableEncryptedFlag = false;
		quickResendAttempts = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B090]");
		MaxResends = 0;
		ChannelCount = 2;
		mtu = 1200;
		PingUsedAsInit = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj5 = default;
		obj5._002Ector();
		object obj6 = this + 200;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj7 = default;
		obj7._002Ector();
		object obj8 = this + 208;
		obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj9 = default;
		obj9._002Ector();
		object obj10 = this + 216;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		TransportProtocol__BackingField = protocolType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon> dictionary = default;
		dictionary._002Ector(5);
		object obj11 = this + 32;
		obj11 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v12+E8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v22+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515B00]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516808]");
		object obj15 = 0;
		((Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon>)obj11).set_Item((Unity.IL2CPP.Metadata.__Il2CppByteEnum)0, (System.__Canon)(object)typeFromHandle);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516800]");
		object obj16 = 0;
		((Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon>)obj11).set_Item((Unity.IL2CPP.Metadata.__Il2CppByteEnum)1, (System.__Canon)(object)typeFromHandle2);
		((Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon>)obj11).set_Item((Unity.IL2CPP.Metadata.__Il2CppByteEnum)4, (System.__Canon)(object)Type.GetTypeFromHandle((RuntimeTypeHandle)obj16));
		((Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon>)obj11).set_Item((Unity.IL2CPP.Metadata.__Il2CppByteEnum)5, (System.__Canon)(object)Type.GetTypeFromHandle((RuntimeTypeHandle)obj16));
		CreatePeerBase();
		PeerBase peerBase = this.peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516810]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TrafficStats trafficStats = default;
		trafficStats._002Ector(peerBase.watch);
		object obj18 = this + 176;
		obj18 = trafficStats;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public PhotonPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		: this(protocolType)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		object obj = this + 56;
		obj = listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public virtual bool Connect(string serverAddress, string proxyServerAddress, string appId, object photonToken, object customInitData = null)
	{
		//IL_0005: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (Il2CppClass<Photon.Client.PhotonPeer>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (Il2CppClass<Photon.Client.PhotonPeer>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v11 @ X7_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public unsafe virtual bool Connect(string serverAddress, string appId, object photonToken, object customInitData = null, string proxyServerAddress = null)
	{
		//IL_02de: Expected Obj, but got I4
		//IL_1424: Expected Obj, but got I4
		//IL_1437: Expected Obj, but got I4
		//IL_1444: Expected Obj, but got Ref
		//IL_145d: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_10a7: Expected Obj, but got I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got I4
		//IL_034e: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got Ref
		//IL_03d9: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got Ref
		//IL_00bd: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got Ref
		//IL_012c: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_046c: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got Ref
		//IL_0e3f: Expected Obj, but got I4
		//IL_0e17: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_04f3: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I4
		//IL_051b: Expected Obj, but got Ref
		//IL_0e67: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_01c4: Expected I4, but got Obj
		//IL_01cd: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got Ref
		//IL_01f3: Expected Obj, but got I4
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_057a: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got Ref
		//IL_0f05: Expected Obj, but got Ref
		//IL_0209: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_0f5b: Expected Obj, but got I4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_0601: Expected Obj, but got I4
		//IL_061c: Expected Obj, but got I4
		//IL_0629: Expected Obj, but got Ref
		//IL_0f2a: Expected Obj, but got Ref
		//IL_139b: Expected Obj, but got I
		//IL_13b3: Expected Obj, but got I4
		//IL_13d2: Expected Obj, but got I4
		//IL_13df: Expected Obj, but got Ref
		//IL_13f0: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_1151: Expected I4, but got Obj
		//IL_0f83: Expected Obj, but got I4
		//IL_1367: Expected Obj, but got I
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected Obj, but got Unknown
		//IL_0688: Expected Obj, but got I4
		//IL_06a3: Expected Obj, but got I4
		//IL_06b0: Expected Obj, but got Ref
		//IL_0dd9: Expected I4, but got Obj
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Expected Obj, but got Unknown
		//IL_0def: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df4: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		//IL_070f: Expected Obj, but got I4
		//IL_072a: Expected Obj, but got I4
		//IL_0737: Expected Obj, but got Ref
		//IL_0765: Expected Obj, but got I
		//IL_079d: Expected Obj, but got Ref
		//IL_0c02: Expected Obj, but got I
		//IL_0c3f: Expected Obj, but got I
		//IL_0c73: Expected Obj, but got I4
		//IL_0c91: Expected Obj, but got I4
		//IL_0c9e: Expected Obj, but got Ref
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got Unknown
		//IL_07e8: Expected Obj, but got I
		//IL_0828: Expected Obj, but got I4
		//IL_0838: Expected Obj, but got Ref
		//IL_0841: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I4
		//IL_0857: Expected Obj, but got Ref
		//IL_0cce: Expected Obj, but got I4
		//IL_0ced: Expected Obj, but got I4
		//IL_0cfa: Expected Obj, but got Ref
		//IL_0889: Expected Obj, but got I4
		//IL_0958: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got Ref
		//IL_0971: Expected Obj, but got I4
		//IL_097e: Expected Obj, but got Ref
		//IL_089f: Expected I, but got Obj
		//IL_08d8: Expected Obj, but got I
		//IL_08e6: Expected Obj, but got I4
		//IL_08f6: Expected Obj, but got Ref
		//IL_08ff: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got Ref
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected Obj, but got Unknown
		//IL_09df: Expected Obj, but got I4
		//IL_09fd: Expected Obj, but got I4
		//IL_0a0a: Expected Obj, but got Ref
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Expected Obj, but got Unknown
		//IL_0d30: Expected Obj, but got I4
		//IL_149e: Expected Obj, but got I4
		//IL_14b3: Expected I4, but got Obj
		//IL_14bc: Expected Obj, but got I4
		//IL_14c9: Expected Obj, but got Ref
		//IL_0a4f: Expected Obj, but got I
		//IL_0a57: Expected I, but got Obj
		//IL_0a6f: Expected Obj, but got I
		//IL_0a98: Expected Obj, but got I4
		//IL_0d3d: Expected I, but got Obj
		//IL_0d5d: Expected Obj, but got I
		//IL_0d7e: Expected Obj, but got I4
		//IL_0da6: Expected I4, but got Obj
		//IL_0daf: Expected Obj, but got I4
		//IL_0dbc: Expected Obj, but got Ref
		//IL_0acc: Expected Obj, but got I
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected Obj, but got Unknown
		//IL_0b11: Expected I, but got Obj
		//IL_0b21: Expected Obj, but got I
		//IL_0b4a: Expected Obj, but got I4
		//IL_0b8e: Expected Obj, but got I
		//IL_0bb4: Expected Obj, but got I
		bool lockTaken = default;
		Monitor.Enter(dispatchLockObject, ref lockTaken);
		bool lockTaken2 = default;
		Monitor.Enter(sendOutgoingLockObject, ref lockTaken2);
		bool flag = this.peerBase == null;
		LogLevel logLevel = (LogLevel)(byte)(&lockTaken2);
		System.__Canon value;
		LogLevel logLevel2;
		object obj7 = default;
		string text2;
		object obj14 = default;
		object obj9 = default;
		object obj12 = default;
		object obj6;
		LogLevel logLevel3;
		OutOfMemoryException ex;
		object obj4;
		string text;
		object obj5;
		OutOfMemoryException ex2;
		ConnectionProtocol connectionProtocol;
		object obj8;
		TrafficStats trafficStats;
		if (!flag)
		{
			ConnectionStateValue peerConnectionState = this.peerBase.peerConnectionState;
			object obj = peerConnectionState & (ConnectionStateValue)0xFF;
			bool flag2 = obj == null;
			logLevel = (LogLevel)0;
			if (!flag2)
			{
				bool flag3 = (int)LogLevel < 2;
				object obj2 = !flag3;
				object obj3 = ~obj2;
				ex = null;
				obj4 = 0;
				value = null;
				text = null;
				logLevel2 = (LogLevel)0;
				obj5 = 0;
				ex2 = null;
				obj6 = (object)(&lockTaken2);
				connectionProtocol = (ConnectionProtocol)(byte)(&obj7);
				obj8 = obj9;
				trafficStats = (TrafficStats)109924352;
				if (obj3 != null)
				{
					goto IL_1341;
				}
				bool flag4 = this.peerBase == null;
				ex = null;
				obj4 = 0;
				value = null;
				text = null;
				logLevel3 = (LogLevel)0;
				obj5 = 0;
				ex2 = null;
				obj6 = (object)(&lockTaken2);
				connectionProtocol = (ConnectionProtocol)(byte)(&obj7);
				obj8 = obj9;
				trafficStats = (TrafficStats)109924352;
				if (flag4)
				{
					goto IL_11ac;
				}
				IPhotonPeerListener photonPeerListener = Listener__BackingField;
				ConnectionStateValue peerConnectionState2 = this.peerBase.peerConnectionState;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161E8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516830]");
				object format = 0;
				object obj11 = default;
				text2 = string.Format((string)format, obj11);
				bool flag5 = Listener__BackingField == null;
				ex = null;
				obj4 = 0;
				value = null;
				text = null;
				logLevel3 = (LogLevel)(int)obj11;
				obj5 = 0;
				ex2 = null;
				obj6 = (object)(&lockTaken2);
				connectionProtocol = (ConnectionProtocol)(byte)(&obj7);
				obj8 = obj9;
				trafficStats = (TrafficStats)109924352;
				if (flag5)
				{
					goto IL_11ba;
				}
				nint num = (nint)photonPeerListener;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v69 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				connectionProtocol = (ConnectionProtocol)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v69 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02b5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v69 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
				object obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X10_v33-8]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X10_v33-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v69 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
					connectionProtocol = (ConnectionProtocol)(-1);
					obj12 = obj13 + 16;
					bool flag6 = connectionProtocol != (ConnectionProtocol)1;
					obj13 = obj12;
					if (flag6)
					{
						continue;
					}
					goto IL_02b5;
				}
				connectionProtocol = (ConnectionProtocol)(int)obj13;
				object obj15 = num + obj13;
				object obj16 = obj15 + 312;
				obj12 = obj13;
				goto IL_138b;
			}
		}
		object obj17 = default;
		bool flag7 = obj17 == null;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			object obj19 = this + 144;
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj20 = this + 112;
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			RandomizeSequenceNumbers = false;
			logLevel = (LogLevel)0;
		}
		CreatePeerBase();
		PeerBase peerBase = this.peerBase;
		bool flag8 = this.peerBase == null;
		OutOfMemoryException ex3 = null;
		object obj21 = 0;
		value = null;
		string text3 = null;
		object obj22 = 0;
		OutOfMemoryException ex4 = null;
		obj6 = (object)(&lockTaken2);
		ConnectionProtocol connectionProtocol2 = (ConnectionProtocol)(byte)(&obj7);
		object obj23 = obj9;
		TrafficStats trafficStats2 = (TrafficStats)109924352;
		if (flag8)
		{
			goto IL_1096;
		}
		nint num2 = (nint)peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v41 (Il2CppClass<Photon.Client.PeerBase>)+1A8]");
		connectionProtocol2 = (ConnectionProtocol)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v41 (Il2CppClass<Photon.Client.PeerBase>)+1B0]");
		TrafficStats trafficStats3 = (TrafficStats)0;
		byte b = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToByte((IFormatProvider)0);
		PeerBase peerBase2 = this.peerBase;
		bool flag9 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		value = null;
		text3 = null;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj9;
		trafficStats2 = (TrafficStats)109924352;
		if (flag9)
		{
			goto IL_10ac;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516810]");
		connectionProtocol2 = (ConnectionProtocol)0;
		Stopwatch stopwatch = peerBase2.watch;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TrafficStats trafficStats4 = default;
		trafficStats4._002Ector(peerBase2.watch);
		object obj24 = this + 176;
		obj24 = trafficStats4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PingUsedAsInit = false;
		bool flag10 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		value = null;
		text3 = null;
		trafficStats3 = trafficStats4;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj9;
		trafficStats2 = trafficStats4;
		if (flag10)
		{
			goto IL_10ba;
		}
		object obj25 = this.peerBase + 48;
		obj25 = serverAddress;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag11 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		value = null;
		text3 = null;
		trafficStats3 = (TrafficStats)(object)serverAddress;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj9;
		trafficStats2 = trafficStats4;
		if (flag11)
		{
			goto IL_10c8;
		}
		object obj26 = this.peerBase + 56;
		string text4 = default;
		obj26 = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag12 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		value = null;
		text3 = null;
		trafficStats3 = (TrafficStats)(object)text4;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj9;
		trafficStats2 = trafficStats4;
		if (flag12)
		{
			goto IL_10d6;
		}
		object obj27 = this.peerBase + 176;
		obj27 = appId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag13 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		value = null;
		text3 = null;
		trafficStats3 = (TrafficStats)(object)appId;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj9;
		trafficStats2 = trafficStats4;
		if (flag13)
		{
			goto IL_10e4;
		}
		object obj28 = this.peerBase + 160;
		obj28 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag14 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		value = null;
		text3 = null;
		trafficStats3 = (TrafficStats)obj17;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj9;
		trafficStats2 = trafficStats4;
		if (flag14)
		{
			goto IL_10f2;
		}
		object obj29 = this.peerBase + 168;
		obj29 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag15 = SocketImplementationConfig == null;
		ex3 = null;
		obj21 = 0;
		value = null;
		text3 = null;
		trafficStats3 = (TrafficStats)obj9;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj9;
		trafficStats2 = trafficStats4;
		if (flag15)
		{
			goto IL_1100;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516818]");
		object obj30 = 0;
		object obj31 = obj30;
		bool flag16 = ((Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon>)(object)SocketImplementationConfig).TryGetValue((Unity.IL2CPP.Metadata.__Il2CppByteEnum)TransportProtocol__BackingField, out value);
		bool flag17 = !flag16;
		string text5 = (string)(&value);
		obj23 = obj9;
		trafficStats2 = trafficStats4;
		Stopwatch stopwatch2 = default;
		object obj35;
		PeerBase peerBase3 = default;
		NullReferenceException ex5 = default;
		if (!flag17)
		{
			object obj32 = this + 40;
			obj32 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj33 = 0;
			obj23 = this.peerBase;
			trafficStats2 = (TrafficStats)(object)SocketImplementation__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag18 = stopwatch2 == null;
			ex3 = null;
			obj21 = 0;
			stopwatch = stopwatch2;
			text3 = (string)(&value);
			trafficStats3 = (TrafficStats)1;
			obj22 = 0;
			ex4 = null;
			obj6 = (object)(&lockTaken2);
			if (flag18)
			{
				goto IL_1116;
			}
			peerBase3 = this.peerBase;
			bool flag19 = this.peerBase == null;
			trafficStats3 = (TrafficStats)1;
			if (!flag19)
			{
				nint num3 = (nint)stopwatch2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v62 (Il2CppClass<System.Diagnostics.Stopwatch>)+40]");
				logLevel3 = (LogLevel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag20 = ex5 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v62 (Il2CppClass<System.Diagnostics.Stopwatch>)+40]");
				trafficStats3 = (TrafficStats)0;
				ex = null;
				obj4 = 0;
				stopwatch = stopwatch2;
				text = (string)(&value);
				obj5 = 0;
				ex2 = null;
				obj6 = (object)(&lockTaken2);
				connectionProtocol = connectionProtocol2;
				obj8 = this.peerBase;
				trafficStats = (TrafficStats)(object)SocketImplementation__BackingField;
				if (flag20)
				{
					goto IL_11d0;
				}
			}
			bool flag21 = stopwatch2.started == 0;
			ex3 = null;
			obj21 = 0;
			stopwatch = stopwatch2;
			text3 = (string)(&value);
			obj22 = 0;
			ex4 = null;
			obj6 = (object)(&lockTaken2);
			if (flag21)
			{
				goto IL_1132;
			}
			object obj34 = stopwatch2 + 32;
			obj34 = peerBase3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj35 = Activator.CreateInstance((Type)(object)trafficStats2, (object[])(object)stopwatch2);
			bool flag22 = obj23 == null;
			ex3 = null;
			obj21 = 0;
			stopwatch = stopwatch2;
			text3 = null;
			trafficStats3 = (TrafficStats)(object)stopwatch2;
			obj22 = 0;
			ex4 = null;
			obj6 = (object)(&lockTaken2);
			if (flag22)
			{
				goto IL_1140;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			if (obj35 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516820]");
				object obj36 = 0;
				nint num4 = (nint)obj35;
				object obj37 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X9_v31 (Il2CppClass<Photon.Client.TrafficStats>)+130]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X9_v31 (Il2CppClass<Photon.Client.TrafficStats>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X1_v53+130]");
				bool flag23 = num5 < 0;
				object obj39 = !flag23;
				object obj40 = ~obj39;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X9_v31 (Il2CppClass<Photon.Client.TrafficStats>)+B0]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X1_v53+130]");
					object obj41 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X9_v34-8]");
					if (0 == (nint)obj37)
					{
						obj23 += 40;
						obj23 = obj35;
						nint num7 = (nint)obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X9_v36 (Il2CppClass<Photon.Client.TrafficStats>)+130]");
						obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X9_v36 (Il2CppClass<Photon.Client.TrafficStats>)+130]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X1_v53+130]");
						bool flag24 = num8 < 0;
						object obj42 = !flag24;
						object obj43 = ~obj42;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X9_v36 (Il2CppClass<Photon.Client.TrafficStats>)+B0]");
							connectionProtocol2 = (ConnectionProtocol)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X9_v36 (Il2CppClass<Photon.Client.TrafficStats>)+B0]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X1_v53+130]");
							object obj44 = num9 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X8_v60-8]");
							bool flag25 = 0 == (nint)obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X9_v36 (Il2CppClass<Photon.Client.TrafficStats>)+130]");
							obj12 = 0;
							obj8 = obj23;
							if (flag25)
							{
								goto IL_146b;
							}
						}
					}
				}
				stopwatch = stopwatch2;
				obj12 = obj38;
				text5 = null;
				trafficStats2 = (TrafficStats)obj35;
				throw new InvalidCastException();
			}
			obj8 = obj23 + 40;
			obj8 = 0;
			goto IL_146b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B70]");
		object obj45 = 0;
		connectionProtocol2 = TransportProtocol__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		string text6 = SupportClass.DictionaryToString((IDictionary)SocketImplementationConfig, includeTypes: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516828]");
		object format2 = 0;
		object obj46 = default;
		string text7 = string.Format((string)format2, obj46, text6);
		bool flag26 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		obj31 = null;
		text3 = text6;
		trafficStats3 = (TrafficStats)obj46;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		if (flag26)
		{
			goto IL_1124;
		}
		this.peerBase.EnqueueDebugReturn((LogLevel)1, text7);
		ex = null;
		obj4 = 0;
		obj17 = null;
		text = text7;
		logLevel2 = (LogLevel)1;
		obj5 = 0;
		ex2 = null;
		obj6 = (object)(&lockTaken2);
		connectionProtocol = TransportProtocol__BackingField;
		obj8 = obj23;
		trafficStats = trafficStats2;
		goto IL_1341;
		IL_10ac:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_10ba;
		IL_1096:
		NullReferenceException ex7 = new NullReferenceException();
		trafficStats3 = (TrafficStats)logLevel;
		goto IL_10ac;
		IL_10ba:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_10c8;
		IL_1057:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj47;
		obj14 = obj47;
		object obj48;
		obj9 = obj48;
		PeerBase peerBase4;
		peerBase3 = peerBase4;
		object obj49;
		obj17 = obj49;
		Stopwatch stopwatch3;
		stopwatch = stopwatch3;
		object obj50;
		obj12 = obj50;
		goto IL_1096;
		IL_146b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PeerBase peerBase5 = this.peerBase;
		bool flag27 = this.peerBase == null;
		ex3 = null;
		obj21 = 0;
		stopwatch = stopwatch2;
		text3 = null;
		logLevel3 = (LogLevel)(int)obj35;
		obj22 = 0;
		ex4 = null;
		obj6 = (object)(&lockTaken2);
		obj23 = obj8;
		trafficStats2 = (TrafficStats)obj35;
		if (flag27)
		{
			goto IL_1156;
		}
		nint num10 = (nint)peerBase5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v55 (Il2CppClass<Photon.Client.PeerBase>)+1B8]");
		connectionProtocol = (ConnectionProtocol)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v55 (Il2CppClass<Photon.Client.PeerBase>)+1C0]");
		string text8 = (string)0;
		short num11 = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToInt16((IFormatProvider)(object)serverAddress);
		ex = null;
		obj4 = 0;
		obj9 = obj17;
		obj17 = appId;
		stopwatch = stopwatch2;
		text = text4;
		logLevel2 = (LogLevel)(int)serverAddress;
		obj5 = 0;
		ex2 = null;
		obj6 = (object)(&lockTaken2);
		short num12 = num11;
		trafficStats = (TrafficStats)obj35;
		goto IL_14e7;
		IL_10c8:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_10d6;
		IL_11d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex10 = new ArgumentNullException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_02b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_138b;
		IL_138b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X0_v142+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1048 @ X0_v142] (should have been resolved before IL gen)");
		ex = null;
		obj4 = 0;
		value = null;
		text = text2;
		logLevel2 = (LogLevel)2;
		obj5 = 0;
		ex2 = null;
		obj6 = (object)(&lockTaken2);
		obj8 = obj9;
		trafficStats = (TrafficStats)109924352;
		goto IL_1341;
		IL_1341:
		text8 = text4;
		num12 = 0;
		goto IL_14e7;
		IL_14e7:
		if (obj6 != null)
		{
			ConnectionProtocol connectionProtocol3 = (ConnectionProtocol)(byte)(&obj7);
			Monitor.Exit(((ConnectionProtocol*)(int)connectionProtocol3)->value__);
			logLevel2 = (LogLevel)0;
		}
		bool flag28 = ex2 == null;
		object obj51 = !flag28;
		OutOfMemoryException ex11;
		if (obj51 == null)
		{
			bool flag29 = obj5 == null;
			object obj52 = !flag29;
			obj47 = obj14;
			ex3 = ex;
			obj21 = obj4;
			obj48 = obj9;
			text4 = text8;
			peerBase4 = peerBase3;
			obj49 = obj17;
			stopwatch3 = stopwatch;
			obj50 = obj12;
			text3 = text;
			logLevel = logLevel2;
			obj22 = obj5;
			ex4 = ex2;
			connectionProtocol2 = connectionProtocol;
			ex11 = ex2;
			obj23 = obj8;
			trafficStats2 = trafficStats;
			if (obj52 != null)
			{
				goto IL_1057;
			}
			object obj53 = (object)(&lockTaken);
			if (obj53 != null)
			{
				object obj55 = default;
				object obj54 = (object)(&obj55);
				Monitor.Exit(obj54);
				logLevel2 = (LogLevel)0;
			}
			bool flag30 = ex == null;
			object obj56 = !flag30;
			if (obj56 == null)
			{
				bool flag31 = obj4 == null;
				object obj57 = !flag31;
				OutOfMemoryException ex12 = ex;
				if (obj57 == null)
				{
					return (byte)(num12 & 1) != 0;
				}
			}
			else
			{
				OutOfMemoryException ex12 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		}
		ex11 = new OutOfMemoryException();
		obj47 = obj14;
		ex3 = ex;
		obj21 = obj4;
		obj48 = obj9;
		text4 = text8;
		peerBase4 = peerBase3;
		obj49 = obj17;
		stopwatch3 = stopwatch;
		obj50 = obj12;
		text3 = text;
		logLevel = logLevel2;
		obj22 = obj5;
		ex4 = ex2;
		connectionProtocol2 = connectionProtocol;
		obj23 = obj8;
		trafficStats2 = trafficStats;
		goto IL_1057;
		IL_10f2:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_1100;
		IL_1116:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_1124;
		IL_10d6:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_10e4;
		IL_10e4:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_10f2;
		IL_1124:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_1132;
		IL_1132:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_1140;
		IL_1140:
		NullReferenceException ex19 = new NullReferenceException();
		logLevel3 = (LogLevel)(int)trafficStats3;
		goto IL_1156;
		IL_11ba:
		ex5 = new NullReferenceException();
		obj31 = obj17;
		goto IL_11d0;
		IL_11ac:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_11ba;
		IL_1100:
		NullReferenceException ex21 = new NullReferenceException();
		obj31 = obj17;
		goto IL_1116;
		IL_1156:
		NullReferenceException ex22 = new NullReferenceException();
		ex = ex3;
		obj4 = obj21;
		obj17 = obj31;
		text = text3;
		obj5 = obj22;
		ex2 = ex4;
		connectionProtocol = connectionProtocol2;
		obj8 = obj23;
		trafficStats = trafficStats2;
		goto IL_11ac;
	}

	private void CreatePeerBase()
	{
		//IL_02bb: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I
		//IL_0090: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		ConnectionProtocol connectionProtocol = TransportProtocol__BackingField;
		bool flag = (int)TransportProtocol__BackingField < 5;
		object obj = !flag;
		object obj2 = TransportProtocol__BackingField - 5;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		TPeer tPeer;
		if (obj4 == null)
		{
			object obj5 = 1 << (int)TransportProtocol__BackingField;
			object obj6 = obj5 & 0x32;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516530]");
				object obj7 = 0;
				object obj8 = this + 192;
				tPeer = (TPeer)obj8;
				object obj9 = obj7;
				if (obj8 != null)
				{
					nint num = (nint)tPeer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v15 (Il2CppClass<Photon.Client.TPeer>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v12+130]");
					bool flag3 = num2 < 0;
					object obj10 = !flag3;
					object obj11 = ~obj10;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v15 (Il2CppClass<Photon.Client.TPeer>)+B0]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v12+130]");
						object obj12 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v17-8]");
						if (0 == (nint)obj7)
						{
							goto IL_0300;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				TPeer tPeer2 = default;
				tPeer2._002Ector();
				obj8 = tPeer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				connectionProtocol = TransportProtocol__BackingField;
				tPeer = tPeer2;
				goto IL_0300;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516110]");
		object obj13 = 0;
		object obj14 = this + 192;
		object obj15 = obj14;
		object obj16 = obj13;
		if (obj14 != null)
		{
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v9+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+130]");
			bool flag4 = num4 < 0;
			object obj18 = !flag4;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v9+B0]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+130]");
				object obj20 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11-8]");
				if (0 == (nint)obj13)
				{
					goto IL_0257;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EnetPeer enetPeer = default;
		enetPeer._002Ector();
		obj14 = enetPeer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_0257;
		IL_0257:
		object obj21 = this.peerBase + 16;
		obj21 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PeerBase peerBase = this.peerBase;
		peerBase.usedTransportProtocol = TransportProtocol__BackingField;
		return;
		IL_0300:
		object obj22 = connectionProtocol - 1;
		bool doFraming = obj22 == null;
		tPeer.DoFraming = doFraming;
		goto IL_0257;
	}

	public unsafe virtual void Disconnect()
	{
		//IL_0047: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got Ref
		//IL_005d: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got Ref
		//IL_006e: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got Ref
		//IL_0091: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got Ref
		//IL_00e4: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got Ref
		//IL_0154: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got Ref
		//IL_01fc: Expected Obj, but got I4
		//IL_038a: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got Ref
		//IL_0224: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(dispatchLockObject, ref lockTaken);
		bool lockTaken2 = default;
		Monitor.Enter(sendOutgoingLockObject, ref lockTaken2);
		PeerBase peerBase = this.peerBase;
		bool flag = this.peerBase == null;
		object obj = 0;
		OutOfMemoryException ex = null;
		object obj2 = (object)(&lockTaken2);
		object obj3 = 0;
		IFormatProvider formatProvider = (IFormatProvider)(&lockTaken2);
		object obj4 = 0;
		OutOfMemoryException ex2 = null;
		object obj6 = default;
		object obj5 = (object)(&obj6);
		if (flag)
		{
			goto IL_0290;
		}
		nint num = (nint)peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v23 (Il2CppClass<Photon.Client.PeerBase>)+1C8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v23 (Il2CppClass<Photon.Client.PeerBase>)+1D0]");
		obj3 = 0;
		ushort num2 = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToUInt16((IFormatProvider)1);
		obj = 0;
		ex = null;
		obj2 = (object)(&lockTaken2);
		formatProvider = (IFormatProvider)1;
		obj4 = 0;
		ex2 = null;
		goto IL_0416;
		IL_01a2:
		object obj7 = (object)(&lockTaken);
		IFormatProvider formatProvider2;
		if (obj7 != null)
		{
			object obj9 = default;
			object obj8 = (object)(&obj9);
			Monitor.Exit(obj8);
			formatProvider2 = null;
		}
		OutOfMemoryException ex3;
		bool flag2 = ex3 == null;
		object obj10 = !flag2;
		object obj11;
		if (obj10 == null)
		{
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			OutOfMemoryException ex4 = ex3;
			if (obj12 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj13;
		obj = obj13;
		OutOfMemoryException ex5;
		ex = ex5;
		object obj14;
		obj3 = obj14;
		formatProvider = formatProvider2;
		obj4 = obj11;
		ex2 = ex3;
		object obj15;
		obj5 = obj15;
		goto IL_0290;
		IL_0416:
		if (obj2 != null)
		{
			object obj16 = (object)(&obj6);
			Monitor.Exit(obj16);
			formatProvider = null;
		}
		bool flag4 = ex == null;
		object obj17 = !flag4;
		if (obj17 != null)
		{
			goto IL_029e;
		}
		bool flag5 = obj == null;
		object obj18 = !flag5;
		obj13 = obj;
		ex5 = ex;
		obj14 = obj3;
		formatProvider2 = formatProvider;
		obj11 = obj4;
		ex3 = ex2;
		obj15 = obj5;
		OutOfMemoryException ex6 = ex;
		if (obj18 == null)
		{
			goto IL_01a2;
		}
		goto IL_02ac;
		IL_029e:
		ex6 = new OutOfMemoryException();
		goto IL_02ac;
		IL_02ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)formatProvider == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)formatProvider != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				if ((nint)formatProvider == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj13 = obj;
					ex5 = ex;
					obj14 = obj3;
					formatProvider2 = formatProvider;
					obj11 = 1;
					ex3 = ex2;
					obj15 = obj5;
				}
				else
				{
					if ((nint)formatProvider != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj13 = obj;
					ex5 = ex;
					obj14 = obj3;
					formatProvider2 = formatProvider;
					obj11 = obj4;
					object obj19 = default;
					ex3 = (OutOfMemoryException)obj19;
					obj15 = obj5;
				}
				goto IL_01a2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj20 = default;
			ex = (OutOfMemoryException)obj20;
		}
		goto IL_0416;
		IL_0290:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_029e;
	}

	public unsafe virtual void SimulateTimeoutDisconnect()
	{
		//IL_0047: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got Ref
		//IL_005d: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got Ref
		//IL_006e: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got Ref
		//IL_0091: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got Ref
		//IL_00e4: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got Ref
		//IL_0154: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got Ref
		//IL_01fc: Expected Obj, but got I4
		//IL_038a: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got Ref
		//IL_0224: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(dispatchLockObject, ref lockTaken);
		bool lockTaken2 = default;
		Monitor.Enter(sendOutgoingLockObject, ref lockTaken2);
		PeerBase peerBase = this.peerBase;
		bool flag = this.peerBase == null;
		object obj = 0;
		OutOfMemoryException ex = null;
		object obj2 = (object)(&lockTaken2);
		object obj3 = 0;
		IFormatProvider formatProvider = (IFormatProvider)(&lockTaken2);
		object obj4 = 0;
		OutOfMemoryException ex2 = null;
		object obj6 = default;
		object obj5 = (object)(&obj6);
		if (flag)
		{
			goto IL_0290;
		}
		nint num = (nint)peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v23 (Il2CppClass<Photon.Client.PeerBase>)+1D8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v23 (Il2CppClass<Photon.Client.PeerBase>)+1E0]");
		obj3 = 0;
		int num2 = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToInt32((IFormatProvider)1);
		obj = 0;
		ex = null;
		obj2 = (object)(&lockTaken2);
		formatProvider = (IFormatProvider)1;
		obj4 = 0;
		ex2 = null;
		goto IL_0416;
		IL_01a2:
		object obj7 = (object)(&lockTaken);
		IFormatProvider formatProvider2;
		if (obj7 != null)
		{
			object obj9 = default;
			object obj8 = (object)(&obj9);
			Monitor.Exit(obj8);
			formatProvider2 = null;
		}
		OutOfMemoryException ex3;
		bool flag2 = ex3 == null;
		object obj10 = !flag2;
		object obj11;
		if (obj10 == null)
		{
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			OutOfMemoryException ex4 = ex3;
			if (obj12 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj13;
		obj = obj13;
		OutOfMemoryException ex5;
		ex = ex5;
		object obj14;
		obj3 = obj14;
		formatProvider = formatProvider2;
		obj4 = obj11;
		ex2 = ex3;
		object obj15;
		obj5 = obj15;
		goto IL_0290;
		IL_0416:
		if (obj2 != null)
		{
			object obj16 = (object)(&obj6);
			Monitor.Exit(obj16);
			formatProvider = null;
		}
		bool flag4 = ex == null;
		object obj17 = !flag4;
		if (obj17 != null)
		{
			goto IL_029e;
		}
		bool flag5 = obj == null;
		object obj18 = !flag5;
		obj13 = obj;
		ex5 = ex;
		obj14 = obj3;
		formatProvider2 = formatProvider;
		obj11 = obj4;
		ex3 = ex2;
		obj15 = obj5;
		OutOfMemoryException ex6 = ex;
		if (obj18 == null)
		{
			goto IL_01a2;
		}
		goto IL_02ac;
		IL_029e:
		ex6 = new OutOfMemoryException();
		goto IL_02ac;
		IL_02ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)formatProvider == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)formatProvider != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				if ((nint)formatProvider == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj13 = obj;
					ex5 = ex;
					obj14 = obj3;
					formatProvider2 = formatProvider;
					obj11 = 1;
					ex3 = ex2;
					obj15 = obj5;
				}
				else
				{
					if ((nint)formatProvider != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj13 = obj;
					ex5 = ex;
					obj14 = obj3;
					formatProvider2 = formatProvider;
					obj11 = obj4;
					object obj19 = default;
					ex3 = (OutOfMemoryException)obj19;
					obj15 = obj5;
				}
				goto IL_01a2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj20 = default;
			ex = (OutOfMemoryException)obj20;
		}
		goto IL_0416;
		IL_0290:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_029e;
	}

	public unsafe virtual void FetchServerTimestamp()
	{
		//IL_0032: Expected Obj, but got Ref
		//IL_003b: Expected Obj, but got I4
		//IL_0057: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got Ref
		//IL_00c5: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got Ref
		//IL_00a6: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(sendOutgoingLockObject, ref lockTaken);
		PeerBase peerBase = this.peerBase;
		bool flag = this.peerBase == null;
		object obj = (object)(&lockTaken);
		object obj2 = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_0112;
		}
		nint num = (nint)peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v12 (Il2CppClass<Photon.Client.PeerBase>)+1F0]");
		obj = 0;
		uint num2 = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToUInt32((IFormatProvider)0);
		obj2 = 0;
		ex = null;
		goto IL_01bd;
		IL_0112:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0120;
		IL_01bd:
		object obj3 = (object)(&lockTaken);
		if (obj3 != null)
		{
			object obj5 = default;
			object obj4 = (object)(&obj5);
			Monitor.Exit(obj4);
			obj = 0;
		}
		bool flag2 = ex == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			bool flag3 = obj2 == null;
			object obj7 = !flag3;
			ex2 = ex;
			if (obj7 == null)
			{
				return;
			}
			goto IL_0120;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_0112;
		IL_0120:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if ((nint)obj != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj8 = default;
			ex = (NullReferenceException)obj8;
		}
		goto IL_01bd;
	}

	public bool EstablishEncryption()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I
		//IL_00c3: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B38]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0D0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516840]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			WaitCallback waitCallback = default;
			waitCallback._002Ector(this, (IntPtr)obj6);
			bool flag2 = ThreadPool.QueueUserWorkItem(waitCallback);
			return true;
		}
		if (peerBase != null)
		{
			return peerBase.ExchangeKeysForEncryption(enqueueLock);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool InitDatagramEncryption(byte[] encryptionSecret, byte[] hmacSecret, bool randomizedSequenceNumbers, bool chainingModeGCM)
	{
		//IL_0172: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0099: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		if (randomizedSequenceNumbers && chainingModeGCM)
		{
			return InitDatagramEncryption(encryptionSecret, hmacSecret);
		}
		if (LogLevel == 0)
		{
			goto IL_018f;
		}
		IPhotonPeerListener photonPeerListener = Listener__BackingField;
		if (Listener__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj = 0;
			nint num = (nint)photonPeerListener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516848]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0135;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3--;
				obj4 += 16;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_0135;
			}
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_01b9;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_018f:
		return false;
		IL_0135:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01b9;
		IL_01b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ X0_v5] (should have been resolved before IL gen)");
		goto IL_018f;
	}

	public bool InitDatagramEncryption(byte[] encryptionSecret, byte[] hmacSecret)
	{
		//IL_01c1: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_0b7d: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_0a86: Expected Obj, but got I4
		//IL_02e6: Expected Obj, but got I
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I
		//IL_00e4: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_038b: Expected I, but got Obj
		//IL_039b: Expected Obj, but got I
		//IL_03ab: Expected Obj, but got I
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0344: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I
		//IL_047c: Expected I, but got Obj
		//IL_048c: Expected Obj, but got I
		//IL_049c: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_0afb: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I
		//IL_04e7: Expected Obj, but got I
		//IL_081f: Expected Obj, but got I4
		//IL_05ab: Expected I, but got Obj
		//IL_05bb: Expected Obj, but got I
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0bcc: Expected Obj, but got I4
		//IL_0bdc: Expected Obj, but got I4
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected Obj, but got Unknown
		//IL_0c06: Expected I, but got Obj
		//IL_05f6: Expected Obj, but got I
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected Obj, but got Unknown
		//IL_0698: Expected Obj, but got I4
		//IL_069d: Expected I, but got Obj
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected Obj, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected Obj, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected Obj, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_0990: Expected Obj, but got I4
		//IL_06df: Expected Obj, but got I
		//IL_0719: Expected Obj, but got I4
		//IL_071e: Expected I, but got Obj
		//IL_090e: Expected I, but got Obj
		//IL_0741: Expected I, but got Obj
		//IL_0751: Expected Obj, but got I
		//IL_0761: Expected Obj, but got I
		//IL_079c: Expected Obj, but got I
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected Obj, but got Unknown
		nint num;
		byte[] array2;
		object obj13;
		Type type3;
		Type type;
		IPhotonPeerListener photonPeerListener;
		byte[] array = default;
		if (encryptionSecret != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			type = encryptorType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v16+E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(type == null))
			{
				object obj4 = Activator.CreateInstance(encryptorType);
				object obj7;
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49E0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					object obj6 = default;
					if (obj6 != null)
					{
						obj7 = this + 144;
						obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						Type type2 = default;
						bool flag2 = (object)type2 == null;
						object obj8 = !flag2;
						type3 = type2;
						if (obj8 != null)
						{
							goto IL_0a94;
						}
					}
					throw new InvalidCastException();
				}
				obj7 = this + 144;
				obj7 = 0;
				type3 = null;
				goto IL_0a94;
			}
			photonPeerListener = Listener__BackingField;
			bool flag3 = Listener__BackingField == null;
			array = null;
			type3 = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				object obj9 = 0;
				num = (nint)photonPeerListener;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516868]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				object obj11 = 0;
				object obj12 = obj9;
				array2 = (byte[])obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0528;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
				obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X10_v7-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					obj11--;
					obj13 += 16;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_0528;
				}
				goto IL_0537;
			}
		}
		else
		{
			photonPeerListener = Listener__BackingField;
			bool flag4 = Listener__BackingField == null;
			type3 = (Type)(object)encryptionSecret;
			type = (Type)109924352;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				object obj14 = 0;
				nint num2 = (nint)photonPeerListener;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516850]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v14 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				object obj16 = 0;
				object obj12 = obj14;
				array2 = (byte[])obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v14 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
				bool flag5 = (nint)0 == 0;
				type = (Type)109924352;
				if (flag5)
				{
					goto IL_0528;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v14 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
				obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X10_v7-8]");
					bool flag6 = 0 == (nint)obj12;
					num = num2;
					type = (Type)109924352;
					if (flag6)
					{
						break;
					}
					obj16--;
					obj13 += 16;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_029c;
				}
				goto IL_0537;
			}
		}
		goto IL_09a9;
		IL_0b52:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v6+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v370 @ X0_v6] (should have been resolved before IL gen)");
		array = array2;
		type3 = (Type)1;
		goto IL_0c64;
		IL_0ba6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v831 @ X0_v61] (should have been resolved before IL gen)");
		bool flag7 = (int)LogLevel < 2;
		object obj17 = !flag7;
		object obj18 = LogLevel - 2;
		bool flag8 = obj18 == null;
		object obj19 = ~obj17;
		object obj20 = obj19 | flag8;
		nint num4 = unchecked((nint)null);
		string text2;
		object obj21;
		byte[] array3;
		if (obj20 == null)
		{
			bool flag9 = Encryptor == null;
			int num5 = mtu;
			string text = (string)1;
			num3 = unchecked((nint)null);
			array3 = array;
			obj21 = encryptionSecret;
			if (flag9)
			{
				goto IL_0824;
			}
			IPhotonPeerListener photonPeerListener2 = Listener__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516858]");
			object format = 0;
			object obj22 = default;
			text2 = string.Format((string)format, obj22);
			bool flag10 = Listener__BackingField == null;
			num5 = mtu;
			text = (string)1;
			num3 = unchecked((nint)null);
			array3 = null;
			obj21 = obj22;
			if (flag10)
			{
				goto IL_0832;
			}
			nint num6 = (nint)photonPeerListener2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v33 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v33 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v33 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			object obj25 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X10_v32-8]");
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
				goto IL_07dd;
			}
			object obj26 = num6 + obj25;
			object obj27 = obj26 + 312;
			goto IL_0c38;
		}
		goto IL_0c83;
		IL_0528:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0b52;
		IL_0427:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0aeb;
		IL_0537:
		object obj28 = num + obj13;
		object obj29 = obj28 + 312;
		goto IL_0b52;
		IL_029c:
		type = (Type)109924352;
		goto IL_0528;
		IL_07dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0c38;
		IL_0832:
		NullReferenceException ex = new NullReferenceException();
		bool flag11 = (nint)obj21 != 1;
		NullReferenceException ex2 = ex;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj31 = default;
			object obj30 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj33 = default;
			object obj32 = obj33 & 1;
			if (obj32 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				type = (Type)Encryptor;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format2 = default;
				string text3 = string.Format(format2, Encryptor, obj31);
				bool flag12 = Listener__BackingField == null;
				num3 = unchecked((nint)null);
				array = (byte[])obj31;
				type3 = (Type)Encryptor;
				if (flag12)
				{
					goto IL_09a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
				string text = text3;
				num3 = 1;
				array = (byte[])(object)Listener__BackingField;
				Type type4 = default;
				type3 = type4;
				goto IL_0c64;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj34 = obj31;
			obj21 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			array3 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex3 = default;
			ex2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_09a9:
		throw new NullReferenceException();
		IL_0637:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0ba6;
		IL_0824:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0832;
		IL_0aeb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v34+8]");
		array3 = (byte[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v684 @ X0_v34] (should have been resolved before IL gen)");
		IPhotonEncryptor encryptor = Encryptor;
		object obj37;
		if (Encryptor != null)
		{
			nint num7 = (nint)encryptor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v26 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v26 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0637;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v26 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+98]");
			object obj36 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X10_v37-8]");
				if (0 == (nint)obj37)
				{
					break;
				}
				obj35--;
				obj36 += 16;
				if ((nint)obj35 != 1)
				{
					continue;
				}
				goto IL_0637;
			}
			object obj38 = obj36 + 2;
			object obj39 = num7 + obj38;
			object obj40 = obj39 + 312;
			goto IL_0ba6;
		}
		NullReferenceException ex5 = new NullReferenceException();
		obj21 = LogLevel;
		goto IL_0824;
		IL_0c64:
		if (peerBase != null)
		{
			peerBase.EnqueueStatusCallback((StatusCode)1049);
			return false;
		}
		goto IL_09a9;
		IL_0a94:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		type = (Type)Encryptor;
		if (Encryptor != null)
		{
			nint num8 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49E0]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v19 (Il2CppClass<System.Type>)+12E]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v19 (Il2CppClass<System.Type>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0427;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v19 (Il2CppClass<System.Type>)+98]");
			object obj42 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X10_v42-8]");
				if (0 == (nint)obj37)
				{
					break;
				}
				obj41--;
				obj42 += 16;
				if ((nint)obj41 != 1)
				{
					continue;
				}
				goto IL_0427;
			}
			object obj43 = obj42 + 1;
			object obj44 = num8 + obj43;
			object obj45 = obj44 + 312;
			goto IL_0aeb;
		}
		photonPeerListener = Listener__BackingField;
		bool flag13 = Listener__BackingField == null;
		array = null;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj46 = 0;
			num = (nint)photonPeerListener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516860]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj48 = 0;
			object obj12 = obj46;
			array2 = (byte[])obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0528;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X10_v7-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj48--;
				obj13 += 16;
				if ((nint)obj48 != 1)
				{
					continue;
				}
				goto IL_0528;
			}
			goto IL_0537;
		}
		goto IL_09a9;
		IL_0c38:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v72+8]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v940 @ X0_v72] (should have been resolved before IL gen)");
		array = (byte[])(object)text2;
		goto IL_0c83;
		IL_0c83:
		object obj49 = this + 112;
		obj49 = encryptionSecret;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 1;
		return true;
	}

	public void InitPayloadEncryption(byte[] secret)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 128;
		obj = secret;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public virtual void Service()
	{
		//IL_0008: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		object obj2;
		do
		{
			DateTime dateTime = ((Enum)this).System_002EIConvertible_002EToDateTime((IFormatProvider)0);
			object obj = dateTime & 1;
			bool flag = obj == null;
			obj2 = !flag;
		}
		while (obj2 != null);
	}

	public unsafe virtual bool SendOutgoingCommands()
	{
		//IL_0044: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got Ref
		//IL_00ae: Expected Obj, but got Ref
		//IL_00b8: Expected Obj, but got I4
		//IL_00e9: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got Ref
		//IL_0129: Expected Obj, but got Ref
		//IL_0132: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I4
		//IL_029e: Expected F4, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_0156: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected I4, but got Unknown
		nint num = default;
		bool lockTaken = default;
		object obj = default;
		NullReferenceException ex = default;
		object obj2 = default;
		object obj3 = default;
		object obj4 = default;
		float num4;
		if (this.peerBase != null)
		{
			int timeInt = this.peerBase.timeInt;
			bool flag = Stats__BackingField == null;
			num = unchecked((nint)null);
			if (!flag)
			{
				Stats__BackingField.SendOutgoingCommandsCalled(timeInt);
				Monitor.Enter(sendOutgoingLockObject, ref lockTaken);
				PeerBase peerBase = this.peerBase;
				bool flag2 = this.peerBase == null;
				obj = 0;
				ex = null;
				obj2 = (object)(&obj3);
				obj4 = (object)(&lockTaken);
				object obj5 = 0;
				num = (nint)(&lockTaken);
				lockTaken = false;
				obj3 = sendOutgoingLockObject;
				if (flag2)
				{
					goto IL_01f0;
				}
				nint num2 = (nint)peerBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14 (Il2CppClass<Photon.Client.PeerBase>)+220]");
				num = 0;
				float num3 = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToSingle((IFormatProvider)0);
				obj = 0;
				ex = null;
				obj2 = (object)(&obj3);
				obj4 = (object)(&lockTaken);
				obj5 = 0;
				lockTaken = false;
				num4 = num3;
				goto IL_02cb;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		lockTaken = false;
		obj3 = null;
		goto IL_01e2;
		IL_01f0:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_01fe;
		IL_02cb:
		if (obj4 != null)
		{
			Monitor.Exit(obj2);
			num = unchecked((nint)null);
		}
		bool flag3 = ex == null;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_01e2;
		}
		bool flag4 = obj == null;
		object obj7 = !flag4;
		ex3 = ex;
		if (obj7 == null)
		{
			return (byte)(num4 & 1) != 0;
		}
		goto IL_01fe;
		IL_01fe:
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
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj8 = default;
			ex = (NullReferenceException)obj8;
		}
		num4 = 0f;
		goto IL_02cb;
		IL_01e2:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_01f0;
	}

	public unsafe virtual bool SendAcksOnly()
	{
		//IL_0032: Expected Obj, but got Ref
		//IL_003b: Expected Obj, but got I4
		//IL_0057: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got Ref
		//IL_00cd: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got Ref
		//IL_00ae: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_01da: Expected F8, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected I4, but got Unknown
		bool lockTaken = default;
		Monitor.Enter(sendOutgoingLockObject, ref lockTaken);
		PeerBase peerBase = this.peerBase;
		bool flag = this.peerBase == null;
		object obj = (object)(&lockTaken);
		object obj2 = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_012c;
		}
		nint num = (nint)peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v13 (Il2CppClass<Photon.Client.PeerBase>)+230]");
		obj = 0;
		double num2 = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToDouble((IFormatProvider)0);
		obj2 = 0;
		ex = null;
		double num3 = num2;
		goto IL_0207;
		IL_012c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_013a;
		IL_0207:
		object obj3 = (object)(&lockTaken);
		if (obj3 != null)
		{
			object obj5 = default;
			object obj4 = (object)(&obj5);
			Monitor.Exit(obj4);
			obj = 0;
		}
		bool flag2 = ex == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			bool flag3 = obj2 == null;
			object obj7 = !flag3;
			ex2 = ex;
			if (obj7 == null)
			{
				return (byte)(num3 & 1) != 0;
			}
			goto IL_013a;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_012c;
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if ((nint)obj != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj8 = default;
			ex = (NullReferenceException)obj8;
		}
		num3 = 0.0;
		goto IL_0207;
	}

	public unsafe virtual bool DispatchIncomingCommands()
	{
		//IL_0044: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got Ref
		//IL_00ae: Expected Obj, but got Ref
		//IL_00b8: Expected Obj, but got I4
		//IL_00e9: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got Ref
		//IL_0137: Expected Obj, but got Ref
		//IL_0140: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_02ac: Expected VT, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected I4, but got Unknown
		nint num = default;
		bool lockTaken = default;
		object obj = default;
		NullReferenceException ex = default;
		object obj2 = default;
		object obj3 = default;
		object obj4 = default;
		DateTime dateTime2;
		if (this.peerBase != null)
		{
			int timeInt = this.peerBase.timeInt;
			bool flag = Stats__BackingField == null;
			num = unchecked((nint)null);
			if (!flag)
			{
				Stats__BackingField.DispatchIncomingCommandsCalled(timeInt);
				Monitor.Enter(dispatchLockObject, ref lockTaken);
				PeerBase peerBase = this.peerBase;
				bool flag2 = this.peerBase == null;
				obj = 0;
				ex = null;
				obj2 = (object)(&obj3);
				obj4 = (object)(&lockTaken);
				object obj5 = 0;
				num = (nint)(&lockTaken);
				lockTaken = false;
				obj3 = dispatchLockObject;
				if (flag2)
				{
					goto IL_01fe;
				}
				nint num2 = (nint)peerBase;
				peerBase.ByteCountCurrentDispatch = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14 (Il2CppClass<Photon.Client.PeerBase>)+250]");
				num = 0;
				DateTime dateTime = ((Enum)(object)this.peerBase).System_002EIConvertible_002EToDateTime((IFormatProvider)0);
				obj = 0;
				ex = null;
				obj2 = (object)(&obj3);
				obj4 = (object)(&lockTaken);
				obj5 = 0;
				lockTaken = false;
				dateTime2 = dateTime;
				goto IL_02d9;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		lockTaken = false;
		obj3 = null;
		goto IL_01f0;
		IL_01fe:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_020c;
		IL_02d9:
		if (obj4 != null)
		{
			Monitor.Exit(obj2);
			num = unchecked((nint)null);
		}
		bool flag3 = ex == null;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_01f0;
		}
		bool flag4 = obj == null;
		object obj7 = !flag4;
		ex3 = ex;
		if (obj7 == null)
		{
			return (byte)(dateTime2 & 1) != 0;
		}
		goto IL_020c;
		IL_020c:
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
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj8 = default;
			ex = (NullReferenceException)obj8;
		}
		dateTime2 = (DateTime)0;
		goto IL_02d9;
		IL_01f0:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_01fe;
	}

	public unsafe virtual bool SendOperation(byte operationCode, ParameterDictionary operationParameters, SendOptions sendOptions)
	{
		//IL_0d0d: Expected Obj, but got I4
		//IL_0d26: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_0089: Expected I4, but got VT
		//IL_00a4: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_04cf: Expected Obj, but got I
		//IL_04dc: Expected VT, but got Obj
		//IL_050a: Expected Obj, but got Ref
		//IL_06d2: Expected Obj, but got I4
		//IL_08b7: Expected I, but got Obj
		//IL_08c7: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_0542: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I
		//IL_06fa: Expected VT, but got Obj
		//IL_0221: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got Ref
		//IL_091a: Expected Obj, but got I
		//IL_0561: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I4
		//IL_059b: Expected VT, but got I4
		//IL_05b3: Expected Obj, but got I4
		//IL_0998: Expected I, but got Obj
		//IL_09a8: Expected Obj, but got I
		//IL_09b8: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got Ref
		//IL_01ab: Expected Obj, but got I4
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected I4, but got Unknown
		//IL_076e: Expected VT, but got Obj
		//IL_0773: Expected I, but got Obj
		//IL_0291: Expected Obj, but got VT
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected I4, but got Unknown
		//IL_02e1: Expected Obj, but got I4
		//IL_02ea: Expected VT, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_0c79: Expected Obj, but got I4
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected Obj, but got Unknown
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected Obj, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected Obj, but got Unknown
		//IL_05e6: Expected Obj, but got I
		//IL_09fb: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I4
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected Obj, but got Unknown
		//IL_07d4: Expected Obj, but got I
		//IL_036d: Expected I, but got Obj
		//IL_038d: Expected VT, but got I
		//IL_03a0: Expected Obj, but got I8
		//IL_03a9: Expected Obj, but got I4
		//IL_03b9: Expected Obj, but got VT
		//IL_03c2: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I4
		//IL_0a96: Expected Obj, but got I4
		//IL_0a9f: Expected Obj, but got I4
		//IL_0ad2: Expected Obj, but got Ref
		//IL_0aef: Expected Obj, but got I4
		//IL_0db2: Expected VT, but got I
		//IL_0ddd: Expected Obj, but got I4
		//IL_0de5: Expected I4, but got Obj
		//IL_0631: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I4
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Obj, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Obj, but got Unknown
		//IL_0e55: Expected VT, but got I
		//IL_0e6e: Expected I, but got Obj
		//IL_0e87: Expected Obj, but got I4
		//IL_0e8f: Expected I4, but got Obj
		//IL_081f: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I4
		//IL_0887: Expected I4, but got Obj
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected Obj, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_0968: Expected I4, but got Obj
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got Unknown
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected Obj, but got Unknown
		//IL_0b75: Expected Obj, but got I4
		//IL_0b7e: Expected Obj, but got I4
		//IL_0bce: Expected Obj, but got I4
		bool flag = this.peerBase == null;
		object obj = operationParameters;
		object obj2 = null;
		bool lockTaken = false;
		object obj3 = operationCode;
		byte b = operationCode;
		SendOptions sendOptions3 = default;
		SendOptions sendOptions2 = sendOptions3;
		object obj4 = 109924352;
		PhotonPeer photonPeer;
		byte b2;
		byte b3;
		PeerBase peerBase;
		object obj11;
		object obj12 = default;
		object obj13 = default;
		LogLevel logLevel = default;
		byte b4 = default;
		SendOptions sendOptions4;
		string text;
		object obj16 = default;
		LogLevel logLevel2;
		ConnectionStateValue channelCount;
		nint num;
		if (!flag)
		{
			ConnectionStateValue peerConnectionState = this.peerBase.peerConnectionState;
			object obj5 = peerConnectionState & (ConnectionStateValue)0xFF;
			bool flag2 = (nint)obj5 != 3;
			obj = operationParameters;
			obj2 = null;
			lockTaken = false;
			obj3 = null;
			photonPeer = this;
			b2 = operationCode;
			sendOptions2 = sendOptions3;
			obj4 = 109924352;
			if (flag2)
			{
				goto IL_049d;
			}
			b3 = (byte)(sendOptions3 >> 40);
			bool flag3 = ChannelCount < b3;
			object obj6 = !flag3;
			object obj7 = ChannelCount - b3;
			bool flag4 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag4;
			if (obj9 == null)
			{
				Monitor.Enter(enqueueLock, ref lockTaken);
				peerBase = this.peerBase;
				object obj10 = sendOptions3 & 0x100000000L;
				bool flag5 = obj10 == null;
				obj11 = 109924352;
				if (!flag5)
				{
					bool flag6 = this.peerBase == null;
					obj = null;
					obj12 = 0;
					obj13 = 0;
					logLevel = (LogLevel)(byte)(&obj2);
					b4 = (byte)(&lockTaken);
					obj2 = enqueueLock;
					lockTaken = false;
					logLevel2 = (LogLevel)(byte)(&obj2);
					obj3 = (object)(&lockTaken);
					b = operationCode;
					sendOptions2 = sendOptions3;
					obj4 = 109924352;
					if (flag6)
					{
						goto IL_0c1b;
					}
					obj11 = peerBase.isEncryptionAvailable;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					peerBase = this.peerBase;
					if (!peerBase.isEncryptionAvailable)
					{
						bool flag7 = peerBase == null;
						obj = null;
						obj12 = 0;
						obj13 = 0;
						logLevel = (LogLevel)(byte)(&obj2);
						b4 = (byte)(&lockTaken);
						obj2 = enqueueLock;
						lockTaken = false;
						logLevel2 = (LogLevel)(byte)(&obj2);
						obj3 = (object)(&lockTaken);
						b = operationCode;
						sendOptions2 = sendOptions3;
						obj4 = peerBase.isEncryptionAvailable;
						if (!flag7)
						{
							if (peerBase.usedTransportProtocol == (ConnectionProtocol)5)
							{
								goto IL_0283;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentException ex = default;
							string message = default;
							ex._002Ector(message);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentNullException ex2 = new ArgumentNullException();
							obj = null;
							obj12 = 0;
							obj13 = 0;
							logLevel = (LogLevel)(byte)(&obj2);
							b4 = (byte)(&lockTaken);
							obj2 = enqueueLock;
							lockTaken = false;
							logLevel2 = (LogLevel)(byte)(&obj2);
							object obj14 = default;
							obj3 = obj14;
							b = operationCode;
							sendOptions2 = sendOptions3;
							obj4 = peerBase.isEncryptionAvailable;
							goto IL_0bd3;
						}
						goto IL_0c29;
					}
				}
				bool flag8 = peerBase == null;
				sendOptions4 = sendOptions3;
				obj = null;
				obj12 = 0;
				obj13 = 0;
				logLevel = (LogLevel)(byte)(&obj2);
				b4 = (byte)(&lockTaken);
				obj2 = enqueueLock;
				lockTaken = false;
				logLevel2 = (LogLevel)(byte)(&obj2);
				obj3 = (object)(&lockTaken);
				b = operationCode;
				sendOptions2 = sendOptions3;
				obj4 = obj11;
				if (!flag8)
				{
					goto IL_0283;
				}
				goto IL_0c05;
			}
			logLevel2 = LogLevel;
			bool flag9 = LogLevel == 0;
			obj = operationParameters;
			obj3 = null;
			b = operationCode;
			sendOptions2 = sendOptions3;
			obj4 = 109924352;
			if (flag9)
			{
				goto IL_0dea;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj15 = 0;
			sendOptions2 = (SendOptions)Listener__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516880]");
			object format = 0;
			ParameterDictionary parameterDictionary = default;
			object obj17 = default;
			text = string.Format((string)format, parameterDictionary, obj16, obj17);
			bool flag10 = Listener__BackingField == null;
			channelCount = (ConnectionStateValue)ChannelCount;
			sendOptions3 = (SendOptions)obj17;
			num = unchecked((nint)null);
			obj = obj16;
			b4 = b3;
			obj2 = null;
			lockTaken = false;
			obj3 = parameterDictionary;
			b = operationCode;
			obj4 = obj16;
			if (!flag10)
			{
				DeliveryMode deliveryMode = sendOptions2.DeliveryMode;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v49 (Photon.Client.DeliveryMode)+12E]");
				logLevel2 = (LogLevel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v49 (Photon.Client.DeliveryMode)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0870;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v49 (Photon.Client.DeliveryMode)+98]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X10_v41-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v49 (Photon.Client.DeliveryMode)+12E]");
					logLevel2 = (LogLevel)(-1);
					obj18 = obj19 + 16;
					bool flag11 = logLevel2 != (LogLevel)1;
					obj19 = obj18;
					if (flag11)
					{
						continue;
					}
					goto IL_0870;
				}
				logLevel2 = (LogLevel)(int)obj19;
				object obj20 = deliveryMode + obj19;
				object obj21 = obj20 + 312;
				obj18 = obj19;
				goto IL_0e45;
			}
		}
		goto IL_0bd3;
		IL_0c05:
		NullReferenceException ex3 = new NullReferenceException();
		sendOptions3 = sendOptions4;
		goto IL_0c1b;
		IL_0bf7:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0c05;
		IL_0283:
		object obj22 = sendOptions3 >> 32;
		bool flag12 = (byte)(obj22 & 1) != 0;
		StreamBuffer streamBuffer = peerBase.SerializeOperationToMessage(operationCode, operationParameters, (EgMessageType)2, flag12);
		PeerBase peerBase2 = this.peerBase;
		bool flag13 = this.peerBase == null;
		object obj23 = 0;
		sendOptions4 = (SendOptions)2;
		num = (flag12 ? 1 : 0);
		obj = operationParameters;
		obj12 = 0;
		obj13 = 0;
		logLevel = (LogLevel)(byte)(&obj2);
		b4 = (byte)(&lockTaken);
		obj2 = enqueueLock;
		lockTaken = false;
		logLevel2 = (LogLevel)(byte)(&obj2);
		obj3 = streamBuffer;
		b = operationCode;
		sendOptions2 = sendOptions3;
		obj4 = obj11;
		if (flag13)
		{
			goto IL_0bf7;
		}
		nint num2 = (nint)peerBase2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v55 (Il2CppClass<Photon.Client.PeerBase>)+208]");
		logLevel2 = (LogLevel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v55 (Il2CppClass<Photon.Client.PeerBase>)+210]");
		SendOptions sendOptions5 = (SendOptions)0;
		PhotonPeer photonPeer2 = (PhotonPeer)((Enum)(object)this.peerBase).System_002EIConvertible_002EToUInt64((IFormatProvider)streamBuffer);
		obj23 = 0;
		num = (flag12 ? 1 : 0);
		obj = sendOptions3;
		obj12 = 0;
		obj13 = 0;
		logLevel = (LogLevel)(byte)(&obj2);
		b4 = (byte)(&lockTaken);
		lockTaken = false;
		obj3 = streamBuffer;
		photonPeer = photonPeer2;
		b = operationCode;
		sendOptions2 = sendOptions3;
		goto IL_0f23;
		IL_049d:
		ConnectionStateValue peerConnectionState2;
		string text2;
		if (photonPeer.LogLevel != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj24 = 0;
			sendOptions2 = (SendOptions)photonPeer.Listener__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag14 = photonPeer.peerBase == null;
			b4 = b2;
			obj3 = (object)(&b4);
			b = b2;
			if (!flag14)
			{
				peerConnectionState2 = photonPeer.peerBase.peerConnectionState;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161E8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516888]");
				object format2 = 0;
				byte b5 = default;
				object obj26 = default;
				text2 = string.Format((string)format2, b5, obj26);
				bool flag15 = photonPeer.Listener__BackingField == null;
				channelCount = peerConnectionState2;
				sendOptions3 = (SendOptions)0;
				obj = obj26;
				b4 = b2;
				obj3 = b5;
				b = b5;
				if (!flag15)
				{
					DeliveryMode deliveryMode2 = sendOptions2.DeliveryMode;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v37 (Photon.Client.DeliveryMode)+12E]");
					logLevel2 = (LogLevel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v37 (Photon.Client.DeliveryMode)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0682;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v37 (Photon.Client.DeliveryMode)+98]");
					object obj27 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X10_v26-8]");
						if (0 == (nint)obj18)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v37 (Photon.Client.DeliveryMode)+12E]");
						logLevel2 = (LogLevel)(-1);
						obj18 = obj27 + 16;
						bool flag16 = logLevel2 != (LogLevel)1;
						obj27 = obj18;
						if (flag16)
						{
							continue;
						}
						goto IL_0682;
					}
					logLevel2 = (LogLevel)(int)obj27;
					object obj28 = deliveryMode2 + obj27;
					object obj29 = obj28 + 312;
					obj18 = obj27;
					goto IL_0da2;
				}
			}
			goto IL_0bd3;
		}
		goto IL_0d47;
		IL_0d47:
		IPhotonPeerListener photonPeerListener = photonPeer.Listener__BackingField;
		bool flag17 = photonPeer.Listener__BackingField == null;
		b = b2;
		nint num3;
		object obj33;
		if (!flag17)
		{
			num3 = (nint)photonPeerListener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v21 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj31 = 0;
			object obj32 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v21 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a3c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v21 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			obj33 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X10_v10-8]");
				if (0 == (nint)obj32)
				{
					break;
				}
				obj31--;
				obj33 += 16;
				if ((nint)obj31 != 1)
				{
					continue;
				}
				goto IL_0a3c;
			}
			goto IL_0a4b;
		}
		goto IL_0bd3;
		IL_0be1:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		sendOptions4 = sendOptions3;
		goto IL_0bf7;
		IL_0bd3:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0be1;
		IL_0da2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X0_v52+8]");
		sendOptions3 = (SendOptions)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1069 @ X0_v52] (should have been resolved before IL gen)");
		channelCount = peerConnectionState2;
		obj = text2;
		b4 = b2;
		obj3 = 1;
		b2 = (byte)(int)text2;
		goto IL_0d47;
		IL_0d34:
		return (byte)(photonPeer & 1) != 0;
		IL_0870:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0e45;
		IL_0e45:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X0_v68+8]");
		sendOptions3 = (SendOptions)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1061 @ X0_v68] (should have been resolved before IL gen)");
		channelCount = (ConnectionStateValue)ChannelCount;
		num = unchecked((nint)null);
		obj = text;
		b4 = b3;
		obj3 = 1;
		b = (byte)(int)text;
		obj4 = obj16;
		goto IL_0dea;
		IL_0dea:
		photonPeerListener = Listener__BackingField;
		bool flag18 = Listener__BackingField == null;
		obj2 = null;
		lockTaken = false;
		if (!flag18)
		{
			nint num4 = (nint)photonPeerListener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v44 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj35 = 0;
			object obj32 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v44 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a3c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v44 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			obj33 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X10_v10-8]");
				bool flag19 = 0 == (nint)obj32;
				num3 = num4;
				if (flag19)
				{
					break;
				}
				obj35--;
				obj33 += 16;
				if ((nint)obj35 != 1)
				{
					continue;
				}
				goto IL_0a3c;
			}
			goto IL_0a4b;
		}
		goto IL_0bd3;
		IL_0682:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0da2;
		IL_0a4b:
		object obj36 = obj33 + 2;
		object obj37 = num3 + obj36;
		object obj38 = obj37 + 312;
		goto IL_0eec;
		IL_0eec:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v778 @ X0_v8] (should have been resolved before IL gen)");
		photonPeer = null;
		goto IL_0d34;
		IL_0a3c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0eec;
		IL_0c1b:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0c29;
		IL_0c29:
		NullReferenceException ex8 = new NullReferenceException();
		if ((nint)obj3 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = 1;
		}
		else
		{
			if ((nint)obj3 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj39 = default;
			obj13 = obj39;
		}
		sendOptions5 = sendOptions3;
		photonPeer = null;
		obj11 = obj4;
		goto IL_0f23;
		IL_0f23:
		if (((byte*)(int)b4)->m_value != 0)
		{
			Monitor.Exit(((LogLevel*)(int)logLevel)->value__);
			obj3 = null;
		}
		bool flag20 = obj13 == null;
		object obj40 = !flag20;
		sendOptions3 = sendOptions5;
		obj4 = obj11;
		if (obj40 != null)
		{
			goto IL_0be1;
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			sendOptions3 = sendOptions5;
			b2 = b;
			obj4 = obj11;
			goto IL_049d;
		}
		goto IL_0d34;
	}

	public unsafe virtual bool SendMessage(object message, SendOptions sendOptions)
	{
		//IL_0bf5: Expected Obj, but got VT
		//IL_0c24: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got VT
		//IL_006d: Expected Obj, but got I4
		//IL_0089: Expected I4, but got VT
		//IL_00a4: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_05ee: Expected Obj, but got VT
		//IL_060c: Expected Obj, but got I4
		//IL_07dd: Expected I, but got Obj
		//IL_07ed: Expected Obj, but got I
		//IL_07fd: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I
		//IL_062a: Expected Obj, but got I
		//IL_0634: Expected VT, but got Obj
		//IL_0211: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got Ref
		//IL_0840: Expected Obj, but got I
		//IL_04c0: Expected Obj, but got I
		//IL_08be: Expected I, but got Obj
		//IL_08ce: Expected Obj, but got I
		//IL_08de: Expected Obj, but got I
		//IL_065e: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I4
		//IL_0699: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got Ref
		//IL_01a3: Expected Obj, but got I4
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Expected I4, but got Unknown
		//IL_0279: Expected Obj, but got VT
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected I4, but got Unknown
		//IL_02bc: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_0b7f: Expected Obj, but got I4
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected Obj, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected Obj, but got Unknown
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected Obj, but got Unknown
		//IL_0510: Expected I, but got Obj
		//IL_0520: Expected Obj, but got I
		//IL_0921: Expected Obj, but got I
		//IL_06fa: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I4
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected Obj, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got Unknown
		//IL_032f: Expected I, but got Obj
		//IL_0362: Expected Obj, but got I8
		//IL_036a: Expected Obj, but got VT
		//IL_0373: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I4
		//IL_09bc: Expected Obj, but got I4
		//IL_09c5: Expected Obj, but got I4
		//IL_09f8: Expected Obj, but got Ref
		//IL_0a0d: Expected Obj, but got I4
		//IL_0ccb: Expected Obj, but got I4
		//IL_056b: Expected Obj, but got I
		//IL_0d4f: Expected Obj, but got I4
		//IL_0d68: Expected Obj, but got I4
		//IL_0745: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I4
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected Obj, but got Unknown
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_07ad: Expected I4, but got Obj
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_088e: Expected I4, but got Obj
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected Obj, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected Obj, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_0a93: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I4
		//IL_0ae4: Expected Obj, but got I4
		bool flag = this.peerBase == null;
		object obj = sendOptions;
		object obj2 = null;
		bool lockTaken = false;
		object obj3 = message;
		object obj4 = message;
		SendOptions sendOptions2 = sendOptions;
		object obj5 = 109924352;
		PhotonPeer photonPeer;
		ConnectionStateValue connectionStateValue;
		PeerBase peerBase;
		object obj12;
		object obj13 = default;
		object obj14 = default;
		LogLevel logLevel = default;
		ConnectionStateValue connectionStateValue2 = default;
		string text;
		object obj17 = default;
		LogLevel logLevel2;
		nint num;
		object obj19;
		if (!flag)
		{
			ConnectionStateValue peerConnectionState = this.peerBase.peerConnectionState;
			object obj6 = peerConnectionState & (ConnectionStateValue)0xFF;
			bool flag2 = (nint)obj6 != 3;
			obj = sendOptions;
			obj2 = null;
			lockTaken = false;
			obj3 = null;
			photonPeer = this;
			obj4 = message;
			sendOptions2 = sendOptions;
			obj5 = 109924352;
			if (flag2)
			{
				goto IL_042e;
			}
			connectionStateValue = (ConnectionStateValue)(sendOptions >> 40);
			bool flag3 = (int)ChannelCount < (int)connectionStateValue;
			object obj7 = !flag3;
			object obj8 = ChannelCount - connectionStateValue;
			bool flag4 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag4;
			if (obj10 == null)
			{
				Monitor.Enter(enqueueLock, ref lockTaken);
				peerBase = this.peerBase;
				object obj11 = sendOptions & 0x100000000L;
				bool flag5 = obj11 == null;
				obj12 = 109924352;
				if (!flag5)
				{
					bool flag6 = this.peerBase == null;
					obj = null;
					obj13 = 0;
					obj14 = 0;
					logLevel = (LogLevel)(byte)(&obj2);
					connectionStateValue2 = (ConnectionStateValue)(byte)(&lockTaken);
					obj2 = enqueueLock;
					lockTaken = false;
					logLevel2 = (LogLevel)(byte)(&obj2);
					obj3 = (object)(&lockTaken);
					obj4 = message;
					obj5 = 109924352;
					if (flag6)
					{
						goto IL_0b21;
					}
					obj12 = peerBase.isEncryptionAvailable;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					peerBase = this.peerBase;
					if (!peerBase.isEncryptionAvailable)
					{
						bool flag7 = peerBase == null;
						obj = null;
						obj13 = 0;
						obj14 = 0;
						logLevel = (LogLevel)(byte)(&obj2);
						connectionStateValue2 = (ConnectionStateValue)(byte)(&lockTaken);
						obj2 = enqueueLock;
						lockTaken = false;
						logLevel2 = (LogLevel)(byte)(&obj2);
						obj3 = (object)(&lockTaken);
						obj4 = message;
						obj5 = peerBase.isEncryptionAvailable;
						if (!flag7)
						{
							if (peerBase.usedTransportProtocol == (ConnectionProtocol)5)
							{
								goto IL_026b;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentException ex = default;
							string message2 = default;
							ex._002Ector(message2);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentNullException ex2 = new ArgumentNullException();
							obj = null;
							obj13 = 0;
							obj14 = 0;
							logLevel = (LogLevel)(byte)(&obj2);
							connectionStateValue2 = (ConnectionStateValue)(byte)(&lockTaken);
							obj2 = enqueueLock;
							lockTaken = false;
							logLevel2 = (LogLevel)(byte)(&obj2);
							object obj15 = default;
							obj3 = obj15;
							obj4 = message;
							obj5 = peerBase.isEncryptionAvailable;
							goto IL_0ae9;
						}
						goto IL_0b2f;
					}
				}
				bool flag8 = peerBase == null;
				obj = null;
				obj13 = 0;
				obj14 = 0;
				logLevel = (LogLevel)(byte)(&obj2);
				connectionStateValue2 = (ConnectionStateValue)(byte)(&lockTaken);
				obj2 = enqueueLock;
				lockTaken = false;
				logLevel2 = (LogLevel)(byte)(&obj2);
				obj3 = (object)(&lockTaken);
				obj4 = message;
				obj5 = obj12;
				if (!flag8)
				{
					goto IL_026b;
				}
				goto IL_0b13;
			}
			logLevel2 = LogLevel;
			bool flag9 = LogLevel == 0;
			obj = sendOptions;
			obj3 = null;
			obj4 = message;
			sendOptions2 = sendOptions;
			obj5 = 109924352;
			if (flag9)
			{
				goto IL_0cd0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj16 = 0;
			sendOptions2 = (SendOptions)Listener__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168A0]");
			object format = 0;
			object obj18 = default;
			text = string.Format((string)format, obj17, obj18, message);
			bool flag10 = Listener__BackingField == null;
			obj19 = 0;
			num = (nint)message;
			obj = obj18;
			connectionStateValue2 = connectionStateValue;
			obj2 = null;
			lockTaken = false;
			obj3 = obj17;
			obj4 = message;
			obj5 = obj17;
			if (!flag10)
			{
				DeliveryMode deliveryMode = sendOptions2.DeliveryMode;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v46 (Photon.Client.DeliveryMode)+12E]");
				logLevel2 = (LogLevel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v46 (Photon.Client.DeliveryMode)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0796;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v46 (Photon.Client.DeliveryMode)+98]");
				object obj21 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X10_v41-8]");
					if (0 == (nint)obj20)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v46 (Photon.Client.DeliveryMode)+12E]");
					logLevel2 = (LogLevel)(-1);
					obj20 = obj21 + 16;
					bool flag11 = logLevel2 != (LogLevel)1;
					obj21 = obj20;
					if (flag11)
					{
						continue;
					}
					goto IL_0796;
				}
				logLevel2 = (LogLevel)(int)obj21;
				object obj22 = deliveryMode + obj21;
				object obj23 = obj22 + 312;
				obj20 = obj21;
				goto IL_0d2c;
			}
		}
		goto IL_0ae9;
		IL_0b13:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0b21;
		IL_0b05:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0b13;
		IL_026b:
		object obj24 = sendOptions >> 32;
		bool flag12 = (byte)(obj24 & 1) != 0;
		StreamBuffer streamBuffer = peerBase.SerializeMessageToMessage(message, flag12);
		PeerBase peerBase2 = this.peerBase;
		bool flag13 = this.peerBase == null;
		num = unchecked((nint)null);
		obj = flag12;
		obj13 = 0;
		obj14 = 0;
		logLevel = (LogLevel)(byte)(&obj2);
		connectionStateValue2 = (ConnectionStateValue)(byte)(&lockTaken);
		obj2 = enqueueLock;
		lockTaken = false;
		logLevel2 = (LogLevel)(byte)(&obj2);
		obj3 = streamBuffer;
		obj4 = message;
		obj5 = obj12;
		if (flag13)
		{
			goto IL_0b05;
		}
		nint num2 = (nint)peerBase2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v52 (Il2CppClass<Photon.Client.PeerBase>)+208]");
		logLevel2 = (LogLevel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v52 (Il2CppClass<Photon.Client.PeerBase>)+210]");
		num = 0;
		PhotonPeer photonPeer2 = (PhotonPeer)((Enum)(object)this.peerBase).System_002EIConvertible_002EToUInt64((IFormatProvider)streamBuffer);
		obj = sendOptions;
		obj13 = 0;
		obj14 = 0;
		logLevel = (LogLevel)(byte)(&obj2);
		connectionStateValue2 = (ConnectionStateValue)(byte)(&lockTaken);
		lockTaken = false;
		obj3 = streamBuffer;
		photonPeer = photonPeer2;
		obj4 = message;
		goto IL_0e04;
		IL_042e:
		ConnectionStateValue peerConnectionState2;
		string text2;
		if (photonPeer.LogLevel != 0)
		{
			if (photonPeer.peerBase != null)
			{
				obj4 = photonPeer.Listener__BackingField;
				peerConnectionState2 = photonPeer.peerBase.peerConnectionState;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161E8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168A8]");
				object format2 = 0;
				object obj26 = default;
				text2 = string.Format((string)format2, obj26);
				bool flag14 = photonPeer.Listener__BackingField == null;
				obj = null;
				connectionStateValue2 = peerConnectionState2;
				obj3 = obj26;
				if (!flag14)
				{
					nint num3 = (nint)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v34 (Il2CppClass<System.Object>)+12E]");
					logLevel2 = (LogLevel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v34 (Il2CppClass<System.Object>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_05bc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v34 (Il2CppClass<System.Object>)+98]");
					object obj27 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X10_v26-8]");
						if (0 == (nint)obj20)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v34 (Il2CppClass<System.Object>)+12E]");
						logLevel2 = (LogLevel)(-1);
						obj20 = obj27 + 16;
						bool flag15 = logLevel2 != (LogLevel)1;
						obj27 = obj20;
						if (flag15)
						{
							continue;
						}
						goto IL_05bc;
					}
					logLevel2 = (LogLevel)(int)obj27;
					object obj28 = num3 + obj27;
					object obj29 = obj28 + 312;
					obj20 = obj27;
					goto IL_0c98;
				}
			}
			goto IL_0ae9;
		}
		goto IL_0c45;
		IL_0c45:
		IPhotonPeerListener photonPeerListener = photonPeer.Listener__BackingField;
		nint num4;
		object obj33;
		if (photonPeer.Listener__BackingField != null)
		{
			num4 = (nint)photonPeerListener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v21 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj31 = 0;
			object obj32 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v21 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0962;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v21 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			obj33 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X10_v10-8]");
				if (0 == (nint)obj32)
				{
					break;
				}
				obj31--;
				obj33 += 16;
				if ((nint)obj31 != 1)
				{
					continue;
				}
				goto IL_0962;
			}
			goto IL_0971;
		}
		goto IL_0ae9;
		IL_0af7:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_0b05;
		IL_0ae9:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0af7;
		IL_0c98:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X0_v50+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1003 @ X0_v50] (should have been resolved before IL gen)");
		obj = text2;
		connectionStateValue2 = peerConnectionState2;
		obj3 = 1;
		goto IL_0c45;
		IL_0c32:
		return (byte)(photonPeer & 1) != 0;
		IL_0796:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0d2c;
		IL_0d2c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v64+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v995 @ X0_v64] (should have been resolved before IL gen)");
		obj19 = 0;
		obj = text;
		connectionStateValue2 = connectionStateValue;
		obj3 = 1;
		obj4 = text;
		obj5 = obj17;
		goto IL_0cd0;
		IL_0cd0:
		photonPeerListener = Listener__BackingField;
		bool flag16 = Listener__BackingField == null;
		obj2 = null;
		lockTaken = false;
		if (!flag16)
		{
			nint num5 = (nint)photonPeerListener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v41 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj35 = 0;
			object obj32 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v41 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0962;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v41 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			obj33 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X10_v10-8]");
				bool flag17 = 0 == (nint)obj32;
				num4 = num5;
				if (flag17)
				{
					break;
				}
				obj35--;
				obj33 += 16;
				if ((nint)obj35 != 1)
				{
					continue;
				}
				goto IL_0962;
			}
			goto IL_0971;
		}
		goto IL_0ae9;
		IL_05bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0c98;
		IL_0971:
		object obj36 = obj33 + 2;
		object obj37 = num4 + obj36;
		object obj38 = obj37 + 312;
		goto IL_0dcd;
		IL_0dcd:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v723 @ X0_v8] (should have been resolved before IL gen)");
		photonPeer = null;
		goto IL_0c32;
		IL_0962:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0dcd;
		IL_0b21:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0b2f;
		IL_0b2f:
		NullReferenceException ex8 = new NullReferenceException();
		if ((nint)obj3 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj13 = 1;
		}
		else
		{
			if ((nint)obj3 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj39 = default;
			obj14 = obj39;
		}
		photonPeer = null;
		obj12 = obj5;
		goto IL_0e04;
		IL_0e04:
		if (((ConnectionStateValue*)(int)connectionStateValue2)->value__ != 0)
		{
			Monitor.Exit(((LogLevel*)(int)logLevel)->value__);
			obj3 = null;
		}
		bool flag18 = obj14 == null;
		object obj40 = !flag18;
		obj5 = obj12;
		if (obj40 != null)
		{
			goto IL_0af7;
		}
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			obj5 = obj12;
			goto IL_042e;
		}
		goto IL_0c32;
	}

	public static bool RegisterType(Type customType, byte code, SerializeStreamMethod serializeMethod, DeserializeStreamMethod deserializeMethod)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Protocol.TryRegisterType(customType, code, serializeMethod, deserializeMethod);
	}

	static PhotonPeer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B38]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		_ = 1200;
		_ = 0;
	}

	private void _003CEstablishEncryption_003Eb__201_0(object state)
	{
		bool flag = peerBase.ExchangeKeysForEncryption(enqueueLock);
	}
}
