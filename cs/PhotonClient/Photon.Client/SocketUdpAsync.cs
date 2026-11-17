using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;

namespace Photon.Client;

public class SocketUdpAsync : PhotonSocket, _0021_00210
{
	private Socket sock;

	private SocketAsyncEventArgs receiveArgs;

	private readonly object syncer;

	private readonly object sendLockObject;

	public SocketUdpAsync(PeerBase npeer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = this + 112;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj4 = default;
		obj4._002Ector();
		object obj5 = this + 120;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector(npeer);
		if (!ReportDebugOfLevel((LogLevel)3))
		{
			goto IL_01ac;
		}
		IPhotonPeerListener listener = Listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj6 = 0;
		nint num = (nint)listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517000]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v4 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v4 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0148;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v4 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X10_v8-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj8--;
			obj9 += 16;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0148;
		}
		object obj10 = (object)(num + obj9) + 312;
		goto IL_01dc;
		IL_01dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_01ac;
		IL_01ac:
		PollReceive = false;
		return;
		IL_0148:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01dc;
	}

	unsafe ~SocketUdpAsync()
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
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c3: Expected I, but got Obj
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
		object obj2 = this + 104;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517008]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517010]");
			object obj4 = 0;
			EventHandler<System.__Canon> eventHandler = default;
			eventHandler._002Ector((object)this, (IntPtr)obj4);
			((SocketAsyncEventArgs)obj2).Completed -= (EventHandler<SocketAsyncEventArgs>)(object)eventHandler;
			((SocketAsyncEventArgs)obj2).Dispose();
		}
	}

	private void CloseSocketSafely()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 96;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((Socket)obj)?.Close();
	}

	public unsafe override bool Connect()
	{
		//IL_004c: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got Ref
		//IL_001e: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got Ref
		//IL_00cd: Expected Obj, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_01d6: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0149: Expected I, but got Obj
		//IL_0225: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(syncer, ref lockTaken);
		OutOfMemoryException ex;
		object obj;
		PhotonSocketState photonSocketState;
		object obj3;
		if (base.Connect())
		{
			State = (PhotonSocketState)1;
			ex = null;
			obj = 0;
			object obj2 = 0;
			photonSocketState = (PhotonSocketState)1;
			obj3 = 4;
		}
		else
		{
			ex = null;
			obj = 0;
			object obj2 = 0;
			photonSocketState = (PhotonSocketState)0;
			obj3 = 3;
		}
		object obj6 = default;
		object obj9 = default;
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
					break;
				}
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
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
				ex = (OutOfMemoryException)obj9;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			obj3 = 0;
		}
		object obj10 = obj3 | 4;
		if ((nint)obj10 == 4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0D0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517020]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			WaitCallback waitCallback = default;
			waitCallback._002Ector(this, (IntPtr)obj12);
			bool flag3 = ThreadPool.QueueUserWorkItem(waitCallback);
			return true;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517028]");
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

	public unsafe override PhotonSocketError Send(byte[] data, int length)
	{
		//IL_0086: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got Ref
		//IL_00ea: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got Ref
		//IL_0112: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_020f: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0373: Expected I, but got Obj
		//IL_037b: Expected Obj, but got I
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got Ref
		//IL_0817: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got Ref
		//IL_02b9: Expected Obj, but got I8
		//IL_02d3: Expected Obj, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02fb: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_07a1: Expected Obj, but got I4
		//IL_04db: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I
		//IL_05ae: Expected Obj, but got I
		//IL_0599: Expected Obj, but got I
		//IL_05fe: Expected Obj, but got I4
		//IL_0640: Expected I4, but got Obj
		//IL_0649: Expected Obj, but got I4
		//IL_0676: Expected Obj, but got I
		//IL_0704: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I
		Socket socket = sock;
		if (sock != null && ~(socket.is_connected ? 1u : 0u) == 0)
		{
			bool lockTaken = default;
			Monitor.Enter(sendLockObject, ref lockTaken);
			int num = sock.Send(data, 0, length, (SocketFlags)0);
			byte[] array = data;
			object obj = 0;
			OutOfMemoryException ex = null;
			object obj4 = default;
			object obj7 = default;
			while (true)
			{
				object obj2 = (object)(&lockTaken);
				if (obj2 != null)
				{
					object obj3 = (object)(&obj4);
					Monitor.Exit(obj3);
					array = null;
				}
				bool flag = ex == null;
				object obj5 = !flag;
				if (obj5 == null)
				{
					bool flag2 = obj == null;
					object obj6 = !flag2;
					OutOfMemoryException ex2 = ex;
					if (obj6 == null)
					{
						return (PhotonSocketError)0;
					}
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)array == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj = 1;
					continue;
				}
				if ((nint)array != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (OutOfMemoryException)obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
			bool flag3 = (nint)array != 1;
			int num2 = 0;
			object obj9 = default;
			object obj8 = obj9;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				SocketException ex3 = default;
				nint num3 = (nint)ex3;
				object obj10 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj12 = default;
				object obj11 = obj12 & 1;
				object obj15 = default;
				int num4;
				if (obj11 != null)
				{
					object obj13 = 0;
					SocketException ex4 = ex3;
					object obj14 = (object)(&obj15);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					bool flag4 = ex3 == null;
					num4 = 0;
					if (flag4)
					{
						goto IL_07eb;
					}
					SocketError socketErrorCode = ex3.SocketErrorCode;
					object obj16 = (long)socketErrorCode + 4294957292L;
					bool flag5 = (nint)obj16 < 51;
					object obj17 = !flag5;
					object obj18 = obj16 - 51;
					bool flag6 = obj18 == null;
					object obj19 = !flag6;
					object obj20 = obj17 & obj19;
					if (obj20 == null)
					{
						object obj21 = 1 << (int)obj16;
						object obj22 = obj21 & -9221120230598639615L;
						if (obj22 != null)
						{
							return (PhotonSocketError)4;
						}
					}
					SocketError socketErrorCode2 = ex4.SocketErrorCode;
					base.SocketErrorCode__BackingField = (int)socketErrorCode2;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					nint num5 = (nint)ex3;
					obj10 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj24 = default;
					object obj23 = obj24 & 1;
					bool flag7 = obj23 == null;
					num4 = 0;
					SocketException ex4 = ex3;
					if (flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj25 = ex4;
						array = (byte[])(101789696 + 1224);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num2 = 0;
						object obj26 = default;
						obj8 = obj26;
						goto IL_0846;
					}
					object obj27 = 0;
					object obj28 = (object)(&obj15);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex4 = ex3;
				}
				PhotonSocketState state = State;
				if (state == (PhotonSocketState)3 || State == 0)
				{
					goto IL_07dd;
				}
				bool flag8 = ReportDebugOfLevel((LogLevel)3);
				bool flag9 = !flag8;
				int num6 = length;
				string text = null;
				LogLevel logLevel = (LogLevel)3;
				if (flag9)
				{
					goto IL_0788;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				EndPoint localEndPoint = sock.LocalEndPoint;
				object[] array2 = default;
				bool flag10 = array2 == null;
				num4 = 0;
				obj10 = 0;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					EndPoint remoteEndPoint = sock.RemoteEndPoint;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					if (!socket.is_connected)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F08]");
						object obj29 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F00]");
						object obj29 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					if (!socket.is_bound)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F18]");
						object obj30 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F10]");
						object obj30 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					string format = default;
					string text2 = string.Format(format, array2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object[] array3 = default;
					bool flag11 = array3 == null;
					num4 = 0;
					obj10 = 5;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						bool flag12 = peerBase == null;
						num4 = (int)base.ServerAddress__BackingField;
						obj10 = 0;
						if (!flag12)
						{
							int timeInt = peerBase.timeInt;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							if (~(base.AddressResolvedAsIpv6__BackingField ? 1u : 0u) == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								object obj33 = default;
								object obj32 = obj33;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X25_v6+98]");
								object obj34 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v24+A0]");
								object obj35 = 0;
								object obj32 = obj35;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							string format2 = default;
							string text3 = string.Format(format2, array3);
							EnqueueDebugReturn((LogLevel)3, text3);
							num6 = 0;
							text = text3;
							logLevel = (LogLevel)3;
							goto IL_0788;
						}
					}
				}
				goto IL_07eb;
			}
			goto IL_0846;
		}
		return (PhotonSocketError)1;
		IL_0788:
		bool flag13 = (byte)(~(socket.is_connected ? 1u : 0u)) != 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string message = default;
			EnqueueDebugReturn((LogLevel)3, message);
			HandleException((StatusCode)1030);
		}
		goto IL_07dd;
		IL_0846:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		PhotonSocketError result = default;
		return result;
		IL_07dd:
		return (PhotonSocketError)3;
		IL_07eb:
		throw new NullReferenceException();
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
		//IL_04c7: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I4
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
			goto IL_027a;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X26_v7+v186 @ X24_v8*8]");
			IPAddress iPAddress = (IPAddress)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X26_v7+v186 @ X24_v8*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X26_v7+v186 @ X24_v8*8]");
				AddressFamily addressFamily = ((IPAddress)0).AddressFamily;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				socket._002Ector(addressFamily, (SocketType)2, (ProtocolType)17);
				sock = socket;
				object obj9 = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (sock != null)
				{
					num = base.ServerPort__BackingField;
					Socket socket2 = sock;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X26_v7+v186 @ X24_v8*8]");
					socket2.Connect((IPAddress)0, base.ServerPort__BackingField);
					Socket socket3 = sock;
					object obj11;
					ProtocolType protocolType;
					if (sock != null)
					{
						bool flag3 = (byte)(~(socket3.is_connected ? 1u : 0u)) != 0;
						object obj10 = !flag3;
						obj11 = 0;
						protocolType = (ProtocolType)0;
						if (obj10 != null)
						{
							goto IL_027a;
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
					goto IL_027a;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03de;
		IL_03de:
		throw new NullReferenceException();
		IL_027a:
		Socket socket4 = sock;
		if (sock != null && ~(socket4.is_connected ? 1u : 0u) == 0)
		{
			object obj12 = socket4.addressFamily - 23;
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
				StartReceive();
				return;
			}
			goto IL_03de;
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

	public void StartReceive()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_00a0: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517038]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SocketAsyncEventArgs e = default;
		e._002Ector();
		object obj3 = this + 104;
		obj3 = e;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int mTU = MTU;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int mTU2 = MTU;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517008]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517010]");
		object obj5 = 0;
		byte[] buffer = default;
		((SocketAsyncEventArgs)obj3).SetBuffer(buffer, 0, mTU2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EventHandler<System.__Canon> eventHandler = default;
		eventHandler._002Ector((object)this, (IntPtr)obj5);
		receiveArgs.Completed += (EventHandler<SocketAsyncEventArgs>)(object)eventHandler;
		ReceiveAsyncLoop();
	}

	private void ReceiveAsyncLoop()
	{
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		if (sock == null)
		{
			return;
		}
		object obj2;
		do
		{
			PhotonSocketState state = State;
			if (state == (PhotonSocketState)2)
			{
				bool flag = sock.ReceiveAsync(receiveArgs);
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj == null)
				{
					bool flag3 = ProcessReceive(receiveArgs);
					bool flag4 = !flag3;
					obj2 = !flag4;
					continue;
				}
				break;
			}
			break;
		}
		while (obj2 != null);
	}

	private void OnReceiveCompleted(object sender, SocketAsyncEventArgs args)
	{
		if (ProcessReceive(args))
		{
			ReceiveAsyncLoop();
		}
	}

	private unsafe bool ProcessReceive(SocketAsyncEventArgs args)
	{
		//IL_0398: Expected I4, but got Obj
		//IL_013a: Expected Obj, but got I8
		//IL_0154: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got Ref
		//IL_02f7: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0333: Expected Obj, but got Ref
		PhotonSocketState state = State;
		if (state == (PhotonSocketState)3 || State == 0)
		{
			goto IL_037c;
		}
		if (args == null)
		{
			goto IL_038a;
		}
		bool result;
		if (args.SocketError__BackingField != 0)
		{
			if (args.SocketError__BackingField <= (SocketError)10036)
			{
				object obj = (long)args.SocketError__BackingField + 4294957292L;
				bool flag = (nint)obj < 32;
				object obj2 = !flag;
				object obj3 = obj - 32;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				object obj5 = obj2 & obj4;
				if (obj5 == null)
				{
					object obj6 = 1 << (int)obj;
					object obj7 = obj6 & 0x180000001L;
					if (obj7 != null)
					{
						result = true;
						goto IL_03bf;
					}
				}
				goto IL_01e2;
			}
			bool flag3 = args.SocketError__BackingField == (SocketError)10040;
			result = true;
			if (!flag3)
			{
				bool flag4 = args.SocketError__BackingField == (SocketError)10055;
				result = true;
				if (!flag4)
				{
					goto IL_01e2;
				}
			}
		}
		else
		{
			byte[] buffer = args.Buffer;
			HandleReceivedDatagram(buffer, args.BytesTransferred__BackingField, willBeReused: true);
			result = true;
		}
		goto IL_03bf;
		IL_037c:
		result = false;
		goto IL_03bf;
		IL_01e2:
		PhotonSocketState state2 = State;
		if (state2 != (PhotonSocketState)3 && State != 0)
		{
			base.SocketErrorCode__BackingField = (int)args.SocketError__BackingField;
			if (ReportDebugOfLevel((LogLevel)1))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				string[] array = default;
				if (array == null)
				{
					goto IL_038a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517048]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				PhotonSocketState state3 = State;
				object obj10 = default;
				string text = ((Enum)(&obj10)).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516F70]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517040]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				object obj13 = default;
				string text2 = ((Enum)(&obj13)).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				string message = string.Concat(array);
				EnqueueDebugReturn((LogLevel)1, message);
			}
			HandleException((StatusCode)1039);
		}
		goto IL_037c;
		IL_03bf:
		return result;
		IL_038a:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void _003CConnect_003Eb__8_0(object _)
	{
		DnsAndConnect();
	}
}
