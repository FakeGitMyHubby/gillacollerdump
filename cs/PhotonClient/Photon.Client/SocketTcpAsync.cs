using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;

namespace Photon.Client;

public class SocketTcpAsync : PhotonSocket, _0021_00210
{
	public enum GpType : byte
	{
		// error: enumerator has no value
		Unknown,
		// error: enumerator has no value
		Boolean,
		// error: enumerator has no value
		Byte,
		// error: enumerator has no value
		Short,
		// error: enumerator has no value
		Float,
		// error: enumerator has no value
		Double,
		// error: enumerator has no value
		String,
		// error: enumerator has no value
		Null,
		// error: enumerator has no value
		CompressedInt,
		// error: enumerator has no value
		CompressedLong,
		// error: enumerator has no value
		Int1,
		// error: enumerator has no value
		Int1_,
		// error: enumerator has no value
		Int2,
		// error: enumerator has no value
		Int2_,
		// error: enumerator has no value
		L1,
		// error: enumerator has no value
		L1_,
		// error: enumerator has no value
		L2,
		// error: enumerator has no value
		L2_,
		// error: enumerator has no value
		Custom,
		// error: enumerator has no value
		CustomTypeSlim,
		// error: enumerator has no value
		Dictionary,
		// error: enumerator has no value
		Hashtable,
		// error: enumerator has no value
		ObjectArray,
		// error: enumerator has no value
		OperationRequest,
		// error: enumerator has no value
		OperationResponse,
		// error: enumerator has no value
		EventData,
		// error: enumerator has no value
		BooleanFalse,
		// error: enumerator has no value
		BooleanTrue,
		// error: enumerator has no value
		ShortZero,
		// error: enumerator has no value
		IntZero,
		// error: enumerator has no value
		LongZero,
		// error: enumerator has no value
		FloatZero,
		// error: enumerator has no value
		DoubleZero,
		// error: enumerator has no value
		ByteZero,
		// error: enumerator has no value
		Array,
		// error: enumerator has no value
		BooleanArray,
		// error: enumerator has no value
		ByteArray,
		// error: enumerator has no value
		ShortArray,
		// error: enumerator has no value
		DoubleArray,
		// error: enumerator has no value
		FloatArray,
		// error: enumerator has no value
		StringArray,
		// error: enumerator has no value
		HashtableArray,
		// error: enumerator has no value
		DictionaryArray,
		// error: enumerator has no value
		CustomTypeArray,
		// error: enumerator has no value
		CompressedIntArray,
		// error: enumerator has no value
		CompressedLongArray
	}

	private Socket sock;

	private readonly object syncer;

	public SocketTcpAsync(PeerBase npeer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = this + 104;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector(npeer);
		if (!ReportDebugOfLevel((LogLevel)3))
		{
			goto IL_0177;
		}
		IPhotonPeerListener listener = Listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj4 = 0;
		nint num = (nint)listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516ED0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X10_v8-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj6--;
			obj7 += 16;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj8 = (object)(num + obj7) + 312;
		goto IL_01a7;
		IL_01a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X0_v14] (should have been resolved before IL gen)");
		goto IL_0177;
		IL_0177:
		PollReceive = false;
		return;
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01a7;
	}

	unsafe ~SocketTcpAsync()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got Ref
		//IL_0102: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		Dispose();
		object obj = 0;
		object obj2 = 0;
		object obj3 = 0;
		object obj5 = default;
		object obj4 = (object)(&obj5);
		obj4.Finalize();
		bool flag = obj == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			bool flag2 = obj2 == null;
			object obj7 = !flag2;
			OutOfMemoryException ex = (OutOfMemoryException)obj4;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3AB4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public void Dispose()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		State = (PhotonSocketState)3;
		object obj = this + 96;
		Socket socket = (Socket)obj;
		if (obj != null && ~(socket.is_connected ? 1u : 0u) == 0)
		{
			((Socket)obj).Close();
		}
		sock = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		State = (PhotonSocketState)0;
	}

	public unsafe override bool Connect()
	{
		//IL_0051: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got Ref
		//IL_001e: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got Ref
		//IL_00d7: Expected Obj, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_012b: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_0166: Expected I, but got Obj
		//IL_0262: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_01a7: Expected I4, but got Obj
		bool lockTaken = default;
		Monitor.Enter(syncer, ref lockTaken);
		OutOfMemoryException ex;
		object obj;
		PhotonSocketState photonSocketState;
		SocketTcpAsync socketTcpAsync;
		object obj3;
		if (base.Connect())
		{
			State = (PhotonSocketState)1;
			ex = null;
			obj = 0;
			object obj2 = 0;
			photonSocketState = (PhotonSocketState)1;
			socketTcpAsync = this;
			obj3 = 4;
		}
		else
		{
			ex = null;
			obj = 0;
			object obj2 = 0;
			photonSocketState = (PhotonSocketState)0;
			socketTcpAsync = this;
			obj3 = 3;
		}
		object obj6 = default;
		ThreadStart threadStart = default;
		Thread thread = default;
		object obj13 = default;
		bool result = default;
		while (true)
		{
			object obj4 = (object)(&lockTaken);
			if (obj4 != null)
			{
				object obj5 = (object)(&obj6);
				Monitor.Exit(obj5);
				photonSocketState = (PhotonSocketState)0;
			}
			bool flag = ex == null;
			object obj7 = !flag;
			if (obj7 == null)
			{
				bool flag2 = obj == null;
				object obj8 = !flag2;
				OutOfMemoryException ex2 = ex;
				if (obj8 == null)
				{
					object obj9 = obj3 | 4;
					if ((nint)obj9 != 4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4610]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516EE0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4618]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					threadStart._002Ector(socketTcpAsync, (IntPtr)obj11);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					thread._002Ector(threadStart);
					bool flag3 = thread == null;
					object obj2 = 0;
					photonSocketState = (PhotonSocketState)threadStart;
					socketTcpAsync = (SocketTcpAsync)(object)thread;
					if (!flag3)
					{
						thread.IsBackground = true;
						thread.Start();
						return true;
					}
					goto IL_0212;
				}
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0212;
			IL_0212:
			NullReferenceException ex3 = new NullReferenceException();
			switch (photonSocketState)
			{
			case (PhotonSocketState)2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj = 1;
				break;
			case (PhotonSocketState)1:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (OutOfMemoryException)obj13;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			obj3 = 0;
		}
		return false;
	}

	public unsafe override bool Disconnect()
	{
		//IL_006b: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got Ref
		//IL_009c: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got Ref
		//IL_0158: Expected Obj, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0346: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got Ref
		//IL_0317: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I4
		if (ReportDebugOfLevel((LogLevel)3))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516EE8]");
			object message = 0;
			EnqueueDebugReturn((LogLevel)3, (string)message);
			object obj = 0;
		}
		bool lockTaken = default;
		Monitor.Enter(syncer, ref lockTaken);
		State = (PhotonSocketState)3;
		bool flag = sock == null;
		object obj2 = 0;
		object obj3 = 0;
		OutOfMemoryException ex = null;
		if (!flag)
		{
			sock.Close();
			obj2 = 0;
			obj3 = 0;
			ex = null;
		}
		object obj7 = default;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
		object obj17 = default;
		object obj18 = default;
		bool result = default;
		object obj21 = default;
		string text2 = default;
		string text4 = default;
		string text5 = default;
		while (true)
		{
			State = (PhotonSocketState)0;
			object obj4 = 0;
			PhotonSocketState photonSocketState = (PhotonSocketState)0;
			while (true)
			{
				object obj5 = (object)(&lockTaken);
				if (obj5 != null)
				{
					object obj6 = (object)(&obj7);
					Monitor.Exit(obj6);
					photonSocketState = (PhotonSocketState)0;
				}
				bool flag2 = ex == null;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					bool flag3 = obj3 == null;
					object obj9 = !flag3;
					OutOfMemoryException ex2 = ex;
					if (obj9 == null)
					{
						return true;
					}
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				bool flag4 = photonSocketState != (PhotonSocketState)1;
				PhotonSocketState photonSocketState2 = photonSocketState;
				object obj10 = obj11;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj14 = obj15 & 1;
					if (obj14 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj16 = obj13;
					photonSocketState = (PhotonSocketState)101790920;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					photonSocketState2 = photonSocketState;
					obj4 = 0;
					obj10 = obj17;
				}
				switch (photonSocketState2)
				{
				case (PhotonSocketState)2:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj3 = 1;
					break;
				case (PhotonSocketState)1:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex = (OutOfMemoryException)obj18;
					break;
				default:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
				}
			}
			object obj19 = obj13;
			object obj20 = (object)(&obj21);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			if (ReportDebugOfLevel((LogLevel)3))
			{
				string text;
				string text3;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj22 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v282 @ X8_v20+168] (should have been resolved before IL gen)");
					text = text2;
					text3 = text4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					text = text5;
					text3 = null;
				}
				string message2 = text + text3;
				EnqueueDebugReturn((LogLevel)3, message2);
				object obj = 0;
			}
		}
	}

	public override PhotonSocketError Send(byte[] data, int length)
	{
		Socket socket = sock;
		if (sock != null && ~(socket.is_connected ? 1u : 0u) == 0)
		{
			int num = sock.Send(data, 0, length, (SocketFlags)0);
			return (PhotonSocketError)0;
		}
		return (PhotonSocketError)1;
	}

	public unsafe override PhotonSocketError Receive(out byte[] data)
	{
		ref byte[] reference = ref *(byte[]*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (PhotonSocketError)2;
	}

	internal void DnsAndConnect()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I8
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_0642: Expected Obj, but got I4
		//IL_0526: Expected Obj, but got I
		//IL_045d: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		IPAddress[] ipAddresses = GetIpAddresses(base.ServerAddress__BackingField);
		if (ipAddresses == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+A0]");
		object obj3 = 0;
		bool flag = ipAddresses.Length < 1;
		int num = 0;
		if (flag)
		{
			goto IL_0405;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DBF00]");
		object obj4 = 0;
		object obj5 = ipAddresses.Length & 0xFFFFFFFFL;
		object obj6 = ipAddresses + 32;
		num = 0;
		object obj7 = 0;
		Socket socket = default;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			object obj8 = !flag2;
			if (obj8 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X28_v6+v186 @ X26_v7*8]");
			IPAddress iPAddress = (IPAddress)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X28_v6+v186 @ X26_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X28_v6+v186 @ X26_v7*8]");
				AddressFamily addressFamily = ((IPAddress)0).AddressFamily;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				socket._002Ector(addressFamily, (SocketType)1, (ProtocolType)6);
				sock = socket;
				object obj9 = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (sock != null)
				{
					sock.NoDelay = true;
					if (peerBase != null)
					{
						Socket socket2 = sock;
						int disconnectTimeout = peerBase.DisconnectTimeout;
						if (sock != null)
						{
							sock.ReceiveTimeout = disconnectTimeout;
							if (peerBase != null)
							{
								socket2 = sock;
								int disconnectTimeout2 = peerBase.DisconnectTimeout;
								if (sock != null)
								{
									sock.SendTimeout = disconnectTimeout2;
									if (sock != null)
									{
										num = base.ServerPort__BackingField;
										Socket socket3 = sock;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X28_v6+v186 @ X26_v7*8]");
										socket3.Connect((IPAddress)0, base.ServerPort__BackingField);
										Socket socket4 = sock;
										object obj11;
										ProtocolType protocolType;
										if (sock != null)
										{
											bool flag3 = (byte)(~(socket4.is_connected ? 1u : 0u)) != 0;
											object obj10 = !flag3;
											obj11 = 0;
											protocolType = (ProtocolType)0;
											if (obj10 != null)
											{
												goto IL_0405;
											}
										}
										obj5 = ipAddresses.Length;
										obj7++;
										bool flag4 = (nint)obj7 < ipAddresses.Length;
										obj11 = 0;
										protocolType = (ProtocolType)0;
										if (flag4)
										{
											continue;
										}
										obj11 = 0;
										protocolType = (ProtocolType)0;
										goto IL_0405;
									}
									throw new NullReferenceException();
								}
								throw new NullReferenceException();
							}
							throw new NullReferenceException();
						}
						throw new NullReferenceException();
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_056a;
		IL_056a:
		throw new NullReferenceException();
		IL_0405:
		Socket socket5 = sock;
		if (sock != null && ~(socket5.is_connected ? 1u : 0u) == 0)
		{
			object obj12 = socket5.addressFamily - 23;
			bool flag5 = obj12 == null;
			base.AddressResolvedAsIpv6__BackingField = flag5;
			EndPoint remoteEndPoint = sock.RemoteEndPoint;
			if (remoteEndPoint != null)
			{
				string text = ((Enum)(object)remoteEndPoint).ToString((IFormatProvider)0);
				object obj13 = this + 64;
				obj13 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				State = (PhotonSocketState)2;
				ReceiveAsync();
				return;
			}
			goto IL_056a;
		}
		if (ReportDebugOfLevel((LogLevel)1))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F30]");
			object obj14 = 0;
			string message = (string)obj14 + (string)obj3;
			EnqueueDebugReturn((LogLevel)1, message);
		}
		HandleException((StatusCode)1023);
	}

	private unsafe void ReceiveAsync(SupportClass.ReceiveContext context = null)
	{
		//IL_048d: Expected Obj, but got I4
		//IL_0495: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_00a7: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I
		//IL_051f: Expected I, but got Obj
		//IL_052d: Expected I, but got Obj
		//IL_0195: Expected Obj, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got Ref
		//IL_03eb: Expected Obj, but got I4
		bool flag = context == null;
		object obj = !flag;
		IntPtr intPtr = default;
		byte[] array = (byte[])(nint)intPtr;
		Socket socket = (Socket)(object)context;
		SupportClass.ReceiveContext receiveContext = context;
		byte[] array4;
		object obj4;
		nint num;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			int mTU = MTU;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F58]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			SupportClass.ReceiveContext receiveContext2 = default;
			byte[] array2 = default;
			byte[] array3 = default;
			receiveContext2._002Ector(sock, array2, array3);
			bool flag2 = receiveContext2 == null;
			array = array2;
			socket = sock;
			receiveContext = receiveContext2;
			array4 = array3;
			num = (nint)array2;
			obj4 = sock;
			if (flag2)
			{
				goto IL_01b7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6E58]");
		object obj5 = 0;
		if (receiveContext.ExpectedMessageBytes == 0)
		{
			object obj6 = 32;
		}
		else
		{
			object obj6 = 48;
		}
		if (receiveContext.ExpectedMessageBytes == 0)
		{
			object obj7 = 24;
		}
		else
		{
			object obj7 = 44;
		}
		int num2 = ((receiveContext.ExpectedMessageBytes != 0) ? receiveContext.ExpectedMessageBytes : 9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F60]");
		object obj8 = 0;
		num = (nint)obj8;
		AsyncCallback asyncCallback = default;
		asyncCallback._002Ector(this, (IntPtr)obj8);
		if (sock != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X20_v11 (Photon.Client.SupportClass+ReceiveContext)+v115 @ X11_v4]");
			int size = (int)((nint)num2 - (nint)0);
			Socket socket2 = sock;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X20_v11 (Photon.Client.SupportClass+ReceiveContext)+v108 @ X10_v4]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X20_v11 (Photon.Client.SupportClass+ReceiveContext)+v115 @ X11_v4]");
			IAsyncResult asyncResult = socket2.BeginReceive((byte[])num3, 0, size, (SocketFlags)0, asyncCallback, receiveContext);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		array4 = null;
		obj4 = this;
		goto IL_01b7;
		IL_0459:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_01b7:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag3 = (nint)obj4 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj12 = default;
			object obj11 = obj12 & 1;
			if (obj11 != null)
			{
				object obj13 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				PhotonSocketState state = State;
				if (state == (PhotonSocketState)3 || State == 0)
				{
					return;
				}
				if (ReportDebugOfLevel((LogLevel)1))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					string[] array5 = default;
					bool flag4 = array5 == null;
					num = 0;
					obj4 = 6;
					if (flag4)
					{
						goto IL_0439;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					PhotonSocketState state2 = State;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj14 = default;
					string text = ((Enum)(&obj14)).ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					if (obj10 != null)
					{
						object obj15 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v424 @ X8_v11+168] (should have been resolved before IL gen)");
						object obj17 = default;
						object obj16 = obj17;
					}
					else
					{
						object obj16 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					string message = string.Concat(array5);
					EnqueueDebugReturn((LogLevel)1, message);
				}
				HandleException((StatusCode)1039);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj18 = obj10;
			obj4 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			num = 0;
			goto IL_0439;
		}
		goto IL_0459;
		IL_0439:
		NullReferenceException ex4 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		ex3 = ex4;
		goto IL_0459;
	}

	private unsafe void ReceiveAsync(IAsyncResult ar)
	{
		//IL_007f: Expected I, but got Obj
		//IL_00a9: Expected I, but got Obj
		//IL_0819: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got Unknown
		//IL_01c9: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_0202: Expected Obj, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Expected Obj, but got Unknown
		//IL_0236: Expected Obj, but got I
		//IL_0d89: Expected Obj, but got I4
		//IL_0da7: Expected I, but got Obj
		//IL_0d1f: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I4
		//IL_0e7d: Expected Obj, but got I
		//IL_040e: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got Ref
		//IL_0c6a: Expected Obj, but got Ref
		//IL_03ef: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_0a35: Expected I4, but got Obj
		//IL_0f4e: Expected Obj, but got I4
		//IL_0a8f: Expected Obj, but got Ref
		//IL_04e9: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I4
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_05b5: Expected Obj, but got I4
		//IL_0af2: Expected Obj, but got I
		//IL_0b07: Expected Obj, but got I4
		//IL_0ef5: Expected Obj, but got I8
		//IL_0616: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I4
		//IL_06e3: Expected Obj, but got I4
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		//IL_0765: Expected Obj, but got I8
		PhotonSocketState state = State;
		int num3;
		IAsyncResult asyncResult;
		nint num2;
		IAsyncResult asyncResult4;
		IAsyncResult asyncResult2;
		if (state != (PhotonSocketState)3 && State != 0)
		{
			bool flag = sock == null;
			asyncResult = null;
			IAsyncResult asyncResult3 = default;
			asyncResult2 = asyncResult3;
			if (flag)
			{
				goto IL_07ca;
			}
			int num = sock.EndReceive(asyncResult3);
			bool flag2 = num == 0;
			num2 = unchecked((nint)null);
			asyncResult2 = asyncResult3;
			if (!flag2)
			{
				bool flag3 = asyncResult3 == null;
				num2 = unchecked((nint)null);
				asyncResult2 = asyncResult3;
				num3 = num;
				asyncResult4 = asyncResult3;
				if (!flag3)
				{
					goto IL_00cf;
				}
				goto IL_0d3e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			SocketException ex = default;
			ex._002Ector(10054);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			num2 = unchecked((nint)null);
			IAsyncResult asyncResult5 = default;
			asyncResult = asyncResult5;
			goto IL_0826;
		}
		return;
		IL_0826:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		bool flag4 = (nint)asyncResult != 1;
		IndexOutOfRangeException ex4 = ex3;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj2 = default;
			object obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj4 = default;
			object obj3 = obj4 & 1;
			object obj5 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				PhotonSocketState state2 = State;
				if (state2 == (PhotonSocketState)3 || State == 0)
				{
					goto IL_0d05;
				}
				if (ReportDebugOfLevel((LogLevel)1))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					IAsyncResult asyncResult6 = default;
					bool flag5 = asyncResult6 == null;
					asyncResult4 = asyncResult2;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						PhotonSocketState state3 = State;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						string text = ((Enum)(&obj5)).ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						bool flag6 = obj2 == null;
						asyncResult4 = asyncResult6;
						if (!flag6)
						{
							int num4 = (int)((Hashtable)obj2).System_002ECollections_002EIEnumerable_002EGetEnumerator();
							int num5 = default;
							string text2 = num5.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							SocketError socketErrorCode = ((SocketException)obj2).SocketErrorCode;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							object obj6 = default;
							string text3 = ((Enum)(&obj6)).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							((Hashtable)obj2).Clear();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							bool flag7 = ((Hashtable)obj2).Contains((object)0);
							bool flag8 = flag7;
							object obj7 = 11;
							asyncResult4 = asyncResult6;
							goto IL_0f1a;
						}
					}
					goto IL_0d3e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj10 = default;
				object obj9 = obj10 & 1;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj11 = obj2;
					asyncResult = (IAsyncResult)(101789696 + 1224);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num2 = unchecked((nint)null);
					IndexOutOfRangeException ex5 = default;
					ex4 = ex5;
					goto IL_0db4;
				}
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				PhotonSocketState state4 = State;
				if (state4 == (PhotonSocketState)3 || State == 0)
				{
					goto IL_0d05;
				}
				if (ReportDebugOfLevel((LogLevel)1))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					IAsyncResult asyncResult7 = default;
					bool flag9 = asyncResult7 == null;
					asyncResult4 = asyncResult2;
					if (flag9)
					{
						goto IL_0d3e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					PhotonSocketState state5 = State;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string text4 = ((Enum)(&obj5)).ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					bool flag10 = obj2 == null;
					asyncResult4 = asyncResult7;
					if (!flag10)
					{
						object obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v588 @ X8_v16+168] (should have been resolved before IL gen)");
						bool flag11 = default;
						bool flag8 = flag11;
						asyncResult4 = asyncResult7;
					}
					else
					{
						bool flag8 = false;
					}
					object obj7 = 5;
					IAsyncResult asyncResult6 = asyncResult4;
					goto IL_0f1a;
				}
			}
			goto IL_0d57;
		}
		goto IL_0db4;
		IL_0db4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0d57:
		HandleException((StatusCode)1039);
		return;
		IL_0d3e:
		throw new NullReferenceException();
		IL_07ca:
		throw new NullReferenceException();
		IL_00cf:
		nint num6 = (nint)asyncResult2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6E50]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v23 (Il2CppClass<System.IAsyncResult>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v23 (Il2CppClass<System.IAsyncResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0173;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v23 (Il2CppClass<System.IAsyncResult>)+98]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X10_v21-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj15--;
			obj16 += 16;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0173;
		}
		object obj17 = obj16 + 2;
		object obj18 = num6 + obj17;
		object obj19 = obj18 + 312;
		goto IL_0e19;
		IL_0f1a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		string message = string.Concat((string[])(object)asyncResult4);
		EnqueueDebugReturn((LogLevel)1, message);
		goto IL_0d57;
		IL_0e9c:
		PhotonSocket photonSocket;
		byte[] inBuffer;
		int num7;
		photonSocket.HandleReceivedDatagram(inBuffer, num7, willBeReused: true);
		_ = 0;
		_ = 0;
		IAsyncResult asyncResult8 = default;
		SupportClass.ReceiveContext context = (SupportClass.ReceiveContext)asyncResult8;
		goto IL_0ed8;
		IL_0d05:
		bool flag12 = asyncResult2 == null;
		object obj20 = !flag12;
		num3 = 0;
		asyncResult4 = asyncResult2;
		if (obj20 != null)
		{
			goto IL_00cf;
		}
		goto IL_0d3e;
		IL_0ed8:
		ReceiveAsync(context);
		return;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num2 = 2;
		goto IL_0e19;
		IL_0e19:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v601 @ X0_v167] (should have been resolved before IL gen)");
		bool flag13 = asyncResult8 == null;
		asyncResult4 = asyncResult2;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F58]");
			object obj21 = 0;
			asyncResult = (IAsyncResult)obj21;
			nint num8 = (nint)asyncResult8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v28 (Il2CppClass<System.IAsyncResult>)+130]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X1_v14 (System.IAsyncResult)+130]");
			bool flag14 = num9 < 0;
			object obj22 = !flag14;
			object obj23 = ~obj22;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v28 (Il2CppClass<System.IAsyncResult>)+B0]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X1_v14 (System.IAsyncResult)+130]");
				object obj24 = num10 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v31-8]");
				if (0 == (nint)asyncResult)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+28]");
					num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+28]");
					if ((nint)0 == 0)
					{
						object obj25 = 24;
					}
					else
					{
						object obj25 = 44;
					}
					int num11 = ((num7 != 0) ? num7 : 9);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+v771 @ X8_v34]");
					object obj26 = (nint)0 + (nint)num3;
					if ((nint)obj26 == num11)
					{
						if (num7 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+30]");
							inBuffer = (byte[])0;
							photonSocket = this;
							goto IL_0e9c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+20]");
						byte[] array = (byte[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+20]");
						bool flag15 = (nint)0 == 0;
						asyncResult4 = asyncResult8;
						if (!flag15)
						{
							num2 = array.Length;
							bool flag16 = array.Length == 0;
							asyncResult2 = asyncResult8;
							if (!flag16)
							{
								if (array[0] == 240)
								{
									num7 = (int)num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+20]");
									inBuffer = (byte[])0;
									photonSocket = this;
									goto IL_0e9c;
								}
								bool flag17 = array.Length == 1;
								asyncResult2 = asyncResult8;
								if (!flag17)
								{
									bool flag18 = array.Length < 2;
									object obj27 = !flag18;
									object obj28 = array.Length - 2;
									bool flag19 = obj28 == null;
									object obj29 = ~obj27;
									object obj30 = obj29 | flag19;
									asyncResult2 = asyncResult8;
									if (obj30 == null)
									{
										bool flag20 = array.Length == 3;
										asyncResult2 = asyncResult8;
										if (!flag20)
										{
											bool flag21 = array.Length < 4;
											object obj31 = !flag21;
											object obj32 = array.Length - 4;
											bool flag22 = obj32 == null;
											object obj33 = ~obj31;
											object obj34 = obj33 | flag22;
											asyncResult2 = asyncResult8;
											if (obj34 == null)
											{
												int num12 = array[1] << 24;
												int num13 = num12 | array[2];
												int num14 = num13 | array[3];
												int num15 = num14 | array[4];
												object obj35 = asyncResult8 + 48;
												object obj36 = obj35;
												asyncResult = (IAsyncResult)(num15 - 7);
												bool flag23 = obj35 == null;
												asyncResult4 = asyncResult8;
												if (flag23)
												{
													goto IL_0d3e;
												}
												IAsyncResult asyncResult9 = asyncResult;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v50+18]");
												if ((nint)asyncResult9 > 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
													object obj37 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													IAsyncResult asyncResult10 = default;
													obj35 = asyncResult10;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													obj36 = obj35;
													num2 = array.Length;
													asyncResult = asyncResult10;
												}
												object obj38 = num2 & 0xFFFFFFF8L;
												bool flag24 = obj38 == null;
												asyncResult2 = asyncResult8;
												if (!flag24)
												{
													bool flag25 = obj36 == null;
													asyncResult4 = asyncResult8;
													if (flag25)
													{
														goto IL_0d3e;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v50+18]");
													bool flag26 = (nint)0 == 0;
													asyncResult2 = asyncResult8;
													if (!flag26)
													{
														_ = array[7];
														bool flag27 = array.Length < 8;
														object obj39 = !flag27;
														object obj40 = array.Length - 8;
														bool flag28 = obj40 == null;
														object obj41 = ~obj39;
														object obj42 = obj41 | flag28;
														asyncResult2 = asyncResult8;
														if (obj42 == null)
														{
															object obj43 = obj35;
															bool flag29 = obj35 == null;
															asyncResult4 = asyncResult8;
															if (flag29)
															{
																goto IL_0d3e;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v52+18]");
															object obj44 = 0 & 0xFFFFFFFEL;
															bool flag30 = obj44 == null;
															asyncResult2 = asyncResult8;
															if (!flag30)
															{
																_ = array[8];
																_ = 2;
																num7 = (int)num2;
																context = (SupportClass.ReceiveContext)asyncResult8;
																goto IL_0ed8;
															}
														}
													}
												}
											}
										}
									}
								}
							}
							goto IL_0826;
						}
						goto IL_0d3e;
					}
					if (num7 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+2C]");
						object obj45 = (nint)0 + (nint)num3;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v169 (System.IAsyncResult)+18]");
						object obj46 = (nint)0 + (nint)num3;
					}
					context = (SupportClass.ReceiveContext)asyncResult8;
					goto IL_0ed8;
				}
			}
			InvalidCastException ex6 = new InvalidCastException();
			asyncResult2 = asyncResult8;
			goto IL_07ca;
		}
		goto IL_0d3e;
	}
}
