using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;

namespace Photon.Client;

public class SocketTcp : PhotonSocket, IEnumerable<KeyValue<_00210, _00211>>
{
	private Socket sock;

	private readonly object syncer;

	public SocketTcp(PeerBase npeer)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E18]");
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

	unsafe ~SocketTcp()
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
		SocketTcp socketTcp;
		object obj3;
		if (base.Connect())
		{
			State = (PhotonSocketState)1;
			ex = null;
			obj = 0;
			object obj2 = 0;
			photonSocketState = (PhotonSocketState)1;
			socketTcp = this;
			obj3 = 4;
		}
		else
		{
			ex = null;
			obj = 0;
			object obj2 = 0;
			photonSocketState = (PhotonSocketState)0;
			socketTcp = this;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E28]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4618]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					threadStart._002Ector(socketTcp, (IntPtr)obj11);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					thread._002Ector(threadStart);
					bool flag3 = thread == null;
					object obj2 = 0;
					photonSocketState = (PhotonSocketState)threadStart;
					socketTcp = (SocketTcp)(object)thread;
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
		//IL_00c2: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got Ref
		//IL_009b: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got Ref
		//IL_0156: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got Ref
		//IL_02e0: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		if (ReportDebugOfLevel((LogLevel)3))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E30]");
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
		object obj20 = default;
		string format = default;
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
			object obj19 = (object)(&obj20);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			if (ReportDebugOfLevel((LogLevel)3))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string message2 = string.Format(format, obj13);
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
		//IL_06db: Expected Obj, but got I4
		//IL_05b0: Expected Obj, but got I
		//IL_0439: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_04f2: Expected I, but got Obj
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0507: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_031a: Expected Obj, but got I4
		IPAddress[] ipAddresses = GetIpAddresses(base.ServerAddress__BackingField);
		if (ipAddresses == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v4+98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+A0]");
		object arg = 0;
		bool flag = ipAddresses.Length < 1;
		int num = 0;
		if (flag)
		{
			goto IL_03e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DBF00]");
		object obj3 = 0;
		object obj4 = ipAddresses.Length & 0xFFFFFFFFL;
		object obj5 = ipAddresses + 32;
		num = 0;
		object obj6 = 0;
		Socket socket = default;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
			object obj7 = !flag2;
			if (obj7 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X28_v6+v199 @ X26_v7*8]");
			IPAddress iPAddress = (IPAddress)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X28_v6+v199 @ X26_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X28_v6+v199 @ X26_v7*8]");
				AddressFamily addressFamily = ((IPAddress)0).AddressFamily;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				socket._002Ector(addressFamily, (SocketType)1, (ProtocolType)6);
				sock = socket;
				object obj8 = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (sock != null)
				{
					sock.NoDelay = true;
					if (peerBase != null)
					{
						int disconnectTimeout = peerBase.DisconnectTimeout;
						if (sock != null)
						{
							sock.ReceiveTimeout = disconnectTimeout;
							if (peerBase != null)
							{
								int disconnectTimeout2 = peerBase.DisconnectTimeout;
								if (sock != null)
								{
									sock.SendTimeout = disconnectTimeout2;
									if (sock != null)
									{
										num = base.ServerPort__BackingField;
										Socket socket2 = sock;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X28_v6+v199 @ X26_v7*8]");
										socket2.Connect((IPAddress)0, base.ServerPort__BackingField);
										Socket socket3 = sock;
										object obj10;
										ProtocolType protocolType;
										if (sock != null)
										{
											bool flag3 = (byte)(~(socket3.is_connected ? 1u : 0u)) != 0;
											object obj9 = !flag3;
											obj10 = 0;
											protocolType = (ProtocolType)0;
											if (obj9 != null)
											{
												goto IL_03e1;
											}
										}
										obj4 = ipAddresses.Length;
										obj6++;
										bool flag4 = (nint)obj6 < ipAddresses.Length;
										obj10 = 0;
										protocolType = (ProtocolType)0;
										if (flag4)
										{
											continue;
										}
										obj10 = 0;
										protocolType = (ProtocolType)0;
										goto IL_03e1;
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
		goto IL_0603;
		IL_0603:
		throw new NullReferenceException();
		IL_03e1:
		Socket socket4 = sock;
		if (sock != null && ~(socket4.is_connected ? 1u : 0u) == 0)
		{
			object obj11 = socket4.addressFamily - 23;
			bool flag5 = obj11 == null;
			base.AddressResolvedAsIpv6__BackingField = flag5;
			EndPoint remoteEndPoint = sock.RemoteEndPoint;
			if (remoteEndPoint != null)
			{
				string text = ((Enum)(object)remoteEndPoint).ToString((IFormatProvider)0);
				object obj12 = this + 64;
				obj12 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				State = (PhotonSocketState)2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4610]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E68]");
				object obj14 = 0;
				ThreadStart threadStart = default;
				threadStart._002Ector(this, (IntPtr)obj14);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4618]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Thread thread = default;
				thread._002Ector(threadStart);
				bool flag6 = thread == null;
				ProtocolType protocolType = (ProtocolType)0;
				if (!flag6)
				{
					thread.IsBackground = true;
					thread.Start();
					return;
				}
			}
			goto IL_0603;
		}
		if (ReportDebugOfLevel((LogLevel)1))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E70]");
			object format = 0;
			object arg2 = default;
			string message = string.Format((string)format, base.ServerAddress__BackingField, arg2, arg);
			EnqueueDebugReturn((LogLevel)1, message);
		}
		HandleException((StatusCode)1023);
	}

	public unsafe void ReceiveLoop()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_08fd: Expected Obj, but got I4
		//IL_0925: Expected Obj, but got Ref
		//IL_0a59: Expected Obj, but got I4
		//IL_096f: Expected Obj, but got I4
		//IL_0997: Expected Obj, but got Ref
		//IL_0a31: Expected Obj, but got I4
		//IL_0a81: Expected Obj, but got I4
		//IL_09c4: Expected I, but got Obj
		//IL_09f7: Expected Obj, but got I4
		//IL_0a15: Expected Obj, but got Ref
		//IL_0af1: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0170: Expected I4, but got Obj
		//IL_0b8f: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I4
		//IL_01f6: Expected I4, but got Obj
		//IL_0358: Expected Obj, but got I4
		//IL_0368: Expected Obj, but got I4
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I4
		//IL_04c9: Expected Obj, but got I4
		//IL_04e2: Expected I4, but got Obj
		//IL_043f: Expected Obj, but got I
		//IL_0c8d: Expected I4, but got Obj
		//IL_072d: Expected Obj, but got I
		//IL_0776: Expected Obj, but got I
		//IL_0cc2: Expected Obj, but got I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I4
		//IL_08b2: Expected I4, but got Obj
		//IL_08ba: Expected I4, but got Obj
		//IL_07a4: Expected I4, but got Obj
		//IL_0673: Expected Obj, but got I4
		//IL_0695: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj2 = 0;
		int mTU = MTU;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StreamBuffer streamBuffer = default;
		streamBuffer._002Ector(mTU);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		int num3 = default;
		byte[] array = default;
		object arg = default;
		object obj18 = default;
		object obj19 = default;
		bool lockTaken = default;
		object obj20 = default;
		OutOfMemoryException ex10 = default;
		int num12 = default;
		object obj21 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		SocketException ex12 = default;
		int num14 = default;
		SocketException ex13 = default;
		int num15 = default;
		while (true)
		{
			PhotonSocketState state = State;
			int num;
			int pos;
			int num2;
			ArgumentNullException ex2;
			object obj5;
			SocketFlags socketFlags;
			bool flag3;
			int num5;
			if (state == (PhotonSocketState)2)
			{
				if (streamBuffer != null)
				{
					streamBuffer.len = 0;
					bool flag = streamBuffer.CheckSize(0);
					pos = streamBuffer.pos;
					if (streamBuffer.pos > streamBuffer.len)
					{
						streamBuffer.pos = streamBuffer.len;
					}
					num = 0;
					num2 = 0;
					while (num <= 8)
					{
						num3 = 9 - num;
						if (sock != null)
						{
							int num4 = sock.Receive(array, num, num3, (SocketFlags)0);
							num = num4 + num;
							bool flag2 = num4 == 0;
							object obj4 = !flag2;
							obj5 = 0;
							socketFlags = (SocketFlags)0;
							flag3 = (byte)num3 != 0;
							num5 = num;
							num2 = (int)array;
							if (obj4 != null)
							{
								continue;
							}
							goto IL_017e;
						}
						throw new NullReferenceException();
					}
					if (array != null)
					{
						num5 = array.Length;
						if (array.Length != 0)
						{
							if (array[0] == 240)
							{
								HandleReceivedDatagram(array, array.Length, willBeReused: true);
								socketFlags = (SocketFlags)0;
								flag3 = true;
								continue;
							}
							if (array.Length != 1)
							{
								bool flag4 = array.Length < 2;
								object obj6 = !flag4;
								object obj7 = array.Length - 2;
								bool flag5 = obj7 == null;
								object obj8 = ~obj6;
								object obj9 = obj8 | flag5;
								if (obj9 == null)
								{
									if (array.Length != 3)
									{
										bool flag6 = array.Length < 4;
										object obj10 = !flag6;
										object obj11 = array.Length - 4;
										bool flag7 = obj11 == null;
										object obj12 = ~obj10;
										object obj13 = obj12 | flag7;
										if (obj13 == null)
										{
											bool flag8 = ReportDebugOfLevel((LogLevel)4);
											int num6 = array[1] << 24;
											int num7 = num6 | array[2];
											int num8 = num7 | array[3];
											int num9 = num8 | array[4];
											if (flag8)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516EA8]");
												object format = 0;
												string message = string.Format((string)format, arg);
												EnqueueDebugReturn((LogLevel)4, message);
											}
											num3 = num9 - 7;
											bool flag9 = streamBuffer.CheckSize(num3);
											int num10 = num - 7;
											streamBuffer.Write(array, 7, num10);
											object obj14 = num9 - 9;
											object obj15 = 0;
											flag3 = (byte)num10 != 0;
											num5 = 7;
											num2 = (int)array;
											while (true)
											{
												num = obj14 - obj15;
												if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
												{
													break;
												}
												if (sock != null)
												{
													num5 = streamBuffer.pos;
													int num11 = sock.Receive(streamBuffer.buf, streamBuffer.pos, num, (SocketFlags)0);
													pos = streamBuffer.len;
													num2 = (streamBuffer.pos += num11);
													if (streamBuffer.len < num2)
													{
														streamBuffer.len = num2;
														bool flag10 = streamBuffer.CheckSize(num2);
													}
													obj15 = num11 + obj15;
													bool flag11 = num11 == 0;
													object obj16 = !flag11;
													obj5 = 0;
													socketFlags = (SocketFlags)0;
													flag3 = (byte)num != 0;
													if (obj16 != null)
													{
														continue;
													}
													goto IL_061d;
												}
												throw new NullReferenceException();
											}
											byte[] inBuffer = streamBuffer.ToArray();
											HandleReceivedDatagram(inBuffer, streamBuffer.len, willBeReused: false);
											bool flag12 = ReportDebugOfLevel((LogLevel)4);
											bool flag13 = !flag12;
											socketFlags = (SocketFlags)0;
											flag3 = false;
											num5 = 0;
											if (flag13)
											{
												continue;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E90]");
											object obj17 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E98]");
											pos = 0;
											if (streamBuffer.len != num3)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516EA0]");
												obj17 = 0;
											}
											string text = string.Format((string)((int*)pos)->m_value, obj18, obj17);
											if (this != null)
											{
												EnqueueDebugReturn((LogLevel)4, text);
												socketFlags = (SocketFlags)0;
												flag3 = false;
												num5 = (int)text;
												continue;
											}
											NullReferenceException ex = new NullReferenceException();
											obj19 = null;
											lockTaken = false;
											socketFlags = (SocketFlags)0;
											flag3 = false;
											num5 = (int)obj17;
											num2 = (int)obj18;
											ex2 = (ArgumentNullException)(object)ex;
										}
										else
										{
											IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
											obj19 = null;
											lockTaken = false;
											ex2 = (ArgumentNullException)(object)ex3;
										}
									}
									else
									{
										IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
										obj19 = null;
										lockTaken = false;
										ex2 = (ArgumentNullException)(object)ex4;
									}
								}
								else
								{
									IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
									obj19 = null;
									lockTaken = false;
									ex2 = (ArgumentNullException)(object)ex5;
								}
							}
							else
							{
								IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
								obj19 = null;
								lockTaken = false;
								ex2 = (ArgumentNullException)(object)ex6;
							}
						}
						else
						{
							IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
							obj19 = null;
							lockTaken = false;
							ex2 = (ArgumentNullException)(object)ex7;
						}
					}
					else
					{
						NullReferenceException ex8 = new NullReferenceException();
						obj19 = null;
						lockTaken = false;
						ex2 = (ArgumentNullException)(object)ex8;
					}
					goto IL_0b18;
				}
				NullReferenceException ex9 = new NullReferenceException();
				obj19 = null;
				lockTaken = false;
				num2 = 0;
				goto IL_0abd;
			}
			Monitor.Enter(syncer, ref lockTaken);
			PhotonSocketState state2 = State;
			bool flag14 = state2 == (PhotonSocketState)3;
			obj20 = 0;
			ex10 = null;
			num12 = (int)(&obj19);
			obj19 = syncer;
			lockTaken = false;
			obj21 = (object)(&lockTaken);
			num5 = 0;
			pos = (int)(&obj19);
			num2 = 0;
			if (!flag14)
			{
				PhotonSocketState state3 = State;
				bool flag15 = state3 == 0;
				obj20 = 0;
				ex10 = null;
				num12 = (int)(&obj19);
				obj19 = syncer;
				lockTaken = false;
				obj21 = (object)(&lockTaken);
				num5 = 0;
				pos = (int)(&obj19);
				num2 = 0;
				if (!flag15)
				{
					nint num13 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v19 (Il2CppClass<Photon.Client.SocketTcp>)+188]");
					pos = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v19 (Il2CppClass<Photon.Client.SocketTcp>)+190]");
					num2 = 0;
					string text2 = base.ToString();
					obj20 = 0;
					ex10 = null;
					num12 = (int)(&obj19);
					lockTaken = false;
					obj21 = (object)(&lockTaken);
					num5 = 0;
				}
			}
			goto IL_0ce0;
			IL_0acb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj22 = ((int*)num3)->m_value;
			num2 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			num5 = 0;
			goto IL_0b18;
			IL_0b18:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj23 = obj24;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				if (num2 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj20 = 1;
					break;
				}
				if (num2 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex10 = (OutOfMemoryException)obj25;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				obj23 = obj26;
			}
			goto IL_0ce0;
			IL_0ce0:
			if (obj21 != null)
			{
				Monitor.Exit(((int*)num12)->m_value);
				num2 = 0;
			}
			bool flag16 = ex10 == null;
			object obj27 = !flag16;
			if (obj27 != null)
			{
				goto IL_0abd;
			}
			bool flag17 = obj20 == null;
			object obj28 = !flag17;
			OutOfMemoryException ex11 = ex10;
			if (obj28 == null)
			{
				break;
			}
			goto IL_0acb;
			IL_061d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ex12._002Ector(10054);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ex2 = new ArgumentNullException();
			obj19 = null;
			lockTaken = false;
			obj5 = 0;
			socketFlags = (SocketFlags)0;
			flag3 = (byte)num != 0;
			num5 = 0;
			num3 = (int)ex12;
			num2 = num14;
			goto IL_0b18;
			IL_0abd:
			ex11 = new OutOfMemoryException();
			goto IL_0acb;
			IL_017e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ex13._002Ector(10054);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ex2 = new ArgumentNullException();
			obj19 = null;
			lockTaken = false;
			obj5 = 0;
			socketFlags = (SocketFlags)0;
			flag3 = (byte)num3 != 0;
			num5 = 0;
			num3 = (int)ex13;
			num2 = num15;
			goto IL_0b18;
		}
	}
}
