using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;

namespace Photon.Client;

public class PhotonClientWebSocket : PhotonSocket
{
	private ClientWebSocket clientWebSocket;

	private Task sendTask;

	public PhotonClientWebSocket(PeerBase peerBase)
		: base(peerBase)
	{
		//IL_0022: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		if (~(object)((nint)(object)(base.peerBase.LogLevel & (LogLevel)0xFF) >= 3) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516680]");
			base.peerBase.EnqueueDebugReturn((LogLevel)3, (string)0);
		}
	}

	public override bool Connect()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		//IL_00cf: Expected I4, but got Obj
		bool flag = base.Connect();
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4610]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516698]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4618]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			base.stateField = (PhotonSocketState)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ThreadStart threadStart = default;
			threadStart._002Ector(this, (IntPtr)obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Thread thread = default;
			thread._002Ector(threadStart);
			if (thread == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			thread.IsBackground = true;
			thread.Start();
		}
		return flag;
	}

	private unsafe void AsyncConnectAndReceive()
	{
		//IL_0010: Expected Obj, but got I
		//IL_23be: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c3: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_003f: Expected Obj, but got I4
		//IL_0083: Expected VT, but got I4
		//IL_0378: Expected Obj, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_00b9: Expected VT, but got I4
		//IL_0107: Expected VT, but got I4
		//IL_0400: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_0444: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I4
		//IL_01ae: Expected VT, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_01f8: Expected VT, but got I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_2400: Expected Obj, but got I4
		//IL_240a: Expected VT, but got I4
		//IL_0565: Expected Obj, but got VT
		//IL_0253: Expected VT, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got VT
		//IL_05c7: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_0350: Expected VT, but got I4
		//IL_0676: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_05f2: Expected Obj, but got I
		//IL_06b5: Expected Obj, but got I
		//IL_06c6: Expected Obj, but got I
		//IL_02f2: Expected VT, but got I4
		//IL_180c: Expected I, but got Obj
		//IL_184b: Expected Obj, but got I
		//IL_185c: Expected Obj, but got I
		//IL_186e: Expected I, but got Obj
		//IL_1877: Unknown result type (might be due to invalid IL or missing references)
		//IL_187c: Expected Obj, but got Unknown
		//IL_065f: Expected Obj, but got I4
		//IL_0753: Expected Obj, but got I
		//IL_0795: Expected Obj, but got I4
		//IL_079d: Expected Obj, but got I4
		//IL_1ac5: Expected Obj, but got I
		//IL_1ad6: Expected Obj, but got I
		//IL_18e0: Expected Obj, but got I
		//IL_18fb: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I
		//IL_07f1: Expected Obj, but got I
		//IL_0816: Expected Obj, but got I4
		//IL_1b0a: Expected Obj, but got I4
		//IL_0843: Expected Obj, but got I
		//IL_085d: Expected I, but got Obj
		//IL_1b30: Expected I, but got Obj
		//IL_08b9: Expected Obj, but got I
		//IL_08c9: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I
		//IL_08e9: Expected Obj, but got I
		//IL_08f9: Expected Obj, but got I
		//IL_0909: Expected Obj, but got I
		//IL_0912: Expected Obj, but got I4
		//IL_1b74: Expected Obj, but got I
		//IL_1b8f: Expected Obj, but got I
		//IL_24b7: Expected Obj, but got I
		//IL_24c8: Expected Obj, but got I
		//IL_1bd7: Expected Obj, but got Ref
		//IL_20a3: Expected Obj, but got I
		//IL_091f: Expected I, but got Obj
		//IL_0953: Expected Obj, but got I4
		//IL_1c0c: Expected Obj, but got I
		//IL_1c5c: Expected Obj, but got Ref
		//IL_1977: Expected I, but got Obj
		//IL_1998: Expected Obj, but got I
		//IL_099e: Expected Obj, but got I
		//IL_09af: Expected Obj, but got I
		//IL_1c99: Expected Obj, but got I
		//IL_2195: Expected Obj, but got I
		//IL_0a4b: Expected Obj, but got VT
		//IL_0a53: Expected I, but got Obj
		//IL_19b6: Expected Obj, but got I
		//IL_19c7: Expected Obj, but got I
		//IL_19d9: Expected I, but got Obj
		//IL_19e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e7: Expected Obj, but got Unknown
		//IL_0a02: Expected Obj, but got I4
		//IL_1d5f: Expected Obj, but got I
		//IL_0a89: Expected Obj, but got VT
		//IL_0a9e: Expected Obj, but got I4
		//IL_1a2d: Expected Obj, but got I
		//IL_13d2: Expected I, but got Obj
		//IL_13f6: Expected Obj, but got I4
		//IL_1d7d: Expected Obj, but got I
		//IL_1d8e: Expected Obj, but got I
		//IL_0ab9: Expected I, but got Obj
		//IL_0ada: Expected Obj, but got VT
		//IL_258d: Expected Obj, but got I
		//IL_1a4b: Expected Obj, but got I
		//IL_1a66: Expected Obj, but got I
		//IL_21ff: Expected I, but got Obj
		//IL_2207: Expected Obj, but got I
		//IL_221a: Unknown result type (might be due to invalid IL or missing references)
		//IL_221f: Expected Obj, but got Unknown
		//IL_2387: Expected Obj, but got I4
		//IL_0b0a: Expected Obj, but got I
		//IL_0b1b: Expected Obj, but got I
		//IL_0b3f: Expected Obj, but got VT
		//IL_1dc2: Expected Obj, but got I4
		//IL_1ddc: Expected Obj, but got I4
		//IL_1df2: Expected Obj, but got I4
		//IL_1f7e: Expected I, but got Obj
		//IL_1f9f: Expected Obj, but got I
		//IL_2282: Expected Obj, but got I4
		//IL_1e1a: Expected Obj, but got I
		//IL_1117: Expected Obj, but got VT
		//IL_1fbd: Expected Obj, but got I
		//IL_1fce: Expected Obj, but got I
		//IL_1e60: Expected Obj, but got I
		//IL_1e68: Expected Obj, but got Ref
		//IL_203f: Expected Obj, but got I
		//IL_115c: Expected Obj, but got I4
		//IL_0bc9: Expected Obj, but got VT
		//IL_0be1: Expected Obj, but got Ref
		//IL_200c: Expected Obj, but got I4
		//IL_1e8d: Expected Obj, but got I
		//IL_1ea1: Expected Obj, but got I
		//IL_1ebb: Expected Obj, but got I
		//IL_143d: Expected Obj, but got VT
		//IL_205d: Expected I, but got Obj
		//IL_1f05: Expected Obj, but got I
		//IL_1183: Expected Obj, but got VT
		//IL_0c0b: Expected Obj, but got Ref
		//IL_2338: Expected Obj, but got I4
		//IL_1f67: Expected Obj, but got I4
		//IL_1613: Expected Obj, but got I
		//IL_163d: Expected Obj, but got I4
		//IL_11c3: Expected Obj, but got I4
		//IL_11dd: Expected Obj, but got I4
		//IL_11ee: Expected Obj, but got VT
		//IL_1203: Expected Obj, but got I4
		//IL_0c21: Expected I, but got Obj
		//IL_0c31: Expected Obj, but got I
		//IL_0c62: Expected Obj, but got I
		//IL_1686: Expected Obj, but got VT
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Expected Obj, but got Unknown
		//IL_20e5: Expected Obj, but got VT
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected Obj, but got Unknown
		//IL_176d: Expected Obj, but got VT
		//IL_1230: Expected Obj, but got I
		//IL_0d57: Expected Obj, but got I8
		//IL_16c0: Expected Obj, but got VT
		//IL_14c0: Expected Obj, but got I
		//IL_14ea: Expected Obj, but got I4
		//IL_1276: Expected Obj, but got VT
		//IL_128e: Expected Obj, but got Ref
		//IL_0cf6: Expected I, but got Obj
		//IL_0d06: Expected Obj, but got I
		//IL_0d2f: Expected Obj, but got I
		//IL_17a0: Expected Obj, but got I
		//IL_17d5: Expected Obj, but got I4
		//IL_1533: Expected Obj, but got VT
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected Obj, but got Unknown
		//IL_16eb: Expected I, but got Obj
		//IL_16fb: Expected Obj, but got I
		//IL_170c: Expected Obj, but got I
		//IL_1719: Expected Obj, but got I4
		//IL_1722: Expected Obj, but got I4
		//IL_12b9: Expected Obj, but got I
		//IL_0dba: Expected Obj, but got Ref
		//IL_250e: Expected Obj, but got I4
		//IL_2517: Expected Obj, but got I4
		//IL_251f: Expected Obj, but got I4
		//IL_156d: Expected Obj, but got VT
		//IL_12ef: Expected Obj, but got I
		//IL_0e4b: Expected Obj, but got I4
		//IL_0e61: Expected Obj, but got I
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Expected Obj, but got Unknown
		//IL_0dd0: Expected I, but got Obj
		//IL_0de0: Expected Obj, but got I
		//IL_0e1b: Expected Obj, but got I
		//IL_159b: Expected I, but got Obj
		//IL_15ab: Expected Obj, but got I
		//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected Obj, but got Unknown
		//IL_0ece: Expected I, but got Obj
		//IL_0f06: Expected Obj, but got VT
		//IL_24a2: Expected Obj, but got I4
		//IL_0f39: Expected Obj, but got I
		//IL_0f4a: Expected Obj, but got I
		//IL_0fec: Expected Obj, but got I8
		//IL_0f79: Expected I, but got Obj
		//IL_0f89: Expected Obj, but got I
		//IL_0fc4: Expected Obj, but got I
		//IL_1024: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Expected Obj, but got Unknown
		//IL_107c: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD98]");
		MemoryStream memoryStream = (MemoryStream)0;
		SynchronizationContext.SetSynchronizationContext(null);
		Uri uri = (Uri)(this + 40);
		string text = (string)(object)uri;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Uri uri2 = default;
		uri2._002Ector((string)(object)uri);
		nint num = (nint)memoryStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5 (Il2CppClass<System.IO.MemoryStream>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = uri2 != null;
		bool flag3 = !flag2;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
		string text2 = null;
		object obj2 = null;
		Uri uri3 = null;
		CancellationTokenSource cancellationTokenSource;
		IPhotonPeerListener photonPeerListener;
		if (!flag3)
		{
			bool flag4 = (object)uri2 == null;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
			text2 = null;
			obj2 = null;
			Uri uri4 = null;
			Uri uri5 = uri2;
			if (flag4)
			{
				goto IL_235b;
			}
			UriHostNameType hostNameType = uri2.HostNameType;
			bool flag5 = hostNameType != (UriHostNameType)2;
			_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
			text2 = null;
			obj2 = null;
			uri3 = null;
			if (!flag5)
			{
				string host = uri2.Host;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DC148]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v299+E4]");
				bool flag6 = (nint)0 == 0;
				object obj5 = !flag6;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IPAddress[] hostAddresses = Dns.GetHostAddresses(host);
				bool flag7 = hostAddresses == null;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
				text2 = null;
				obj2 = null;
				Uri uri6 = null;
				uri5 = uri2;
				if (flag7)
				{
					goto IL_2136;
				}
				object obj6 = hostAddresses.Length;
				bool flag8 = hostAddresses.Length < 1;
				_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
				text2 = null;
				obj2 = null;
				uri3 = null;
				if (!flag8)
				{
					string text3 = (string)(hostAddresses + 32);
					photonPeerListener = null;
					uri6 = null;
					while (true)
					{
						bool flag9 = System.Runtime.CompilerServices.Unsafe.As<IPhotonPeerListener, UIntPtr>(ref photonPeerListener) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						object obj7 = !flag9;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
						text2 = null;
						obj2 = null;
						uri5 = uri2;
						if (obj7 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X24_v13 (System.String)+v149 @ X23_v5 (Photon.Client.IPhotonPeerListener)*8]");
						bool flag10 = (nint)0 == 0;
						_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
						text2 = null;
						cancellationTokenSource = (CancellationTokenSource)photonPeerListener;
						obj2 = null;
						uri5 = uri2;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X24_v13 (System.String)+v149 @ X23_v5 (Photon.Client.IPhotonPeerListener)*8]");
							AddressFamily addressFamily = ((IPAddress)0).AddressFamily;
							if (addressFamily != (AddressFamily)23)
							{
								obj6 = hostAddresses.Length;
								photonPeerListener = (IPhotonPeerListener)(photonPeerListener + 1);
								bool flag11 = (nint)photonPeerListener < hostAddresses.Length;
								uri6 = null;
								if (flag11)
								{
									continue;
								}
								goto IL_02e8;
							}
							goto IL_0306;
						}
						goto IL_2112;
					}
					goto IL_20fc;
				}
			}
		}
		goto IL_0368;
		IL_235b:
		throw new NullReferenceException();
		IL_2136:
		throw new NullReferenceException();
		IL_20fc:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		cancellationTokenSource = (CancellationTokenSource)photonPeerListener;
		goto IL_2112;
		IL_2112:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_2120;
		IL_0306:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516410]");
		object obj8 = 0;
		base.AddressResolvedAsIpv6__BackingField = true;
		string text4 = ConnectAddress + (string)obj8;
		uri = (Uri)(object)text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
		text2 = null;
		obj2 = null;
		uri3 = (Uri)(object)text4;
		goto IL_0368;
		IL_02e8:
		_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
		text2 = null;
		obj2 = null;
		uri3 = null;
		goto IL_0368;
		IL_2120:
		NullReferenceException ex3 = new NullReferenceException();
		photonPeerListener = (IPhotonPeerListener)cancellationTokenSource;
		goto IL_2136;
		IL_0368:
		ClientWebSocket clientWebSocket = default;
		CancellationTokenSource cancellationTokenSource2 = default;
		Uri uri7 = default;
		object obj14 = default;
		MemoryStream memoryStream2 = default;
		string text7 = default;
		object obj26 = default;
		Task task2 = default;
		string text9 = default;
		IPhotonPeerListener photonPeerListener2 = default;
		Uri uri10 = default;
		int num8 = default;
		IPhotonPeerListener photonPeerListener3 = default;
		IndexOutOfRangeException ex4 = default;
		object obj49 = default;
		object obj51 = default;
		object obj52 = default;
		int num12 = default;
		string text14 = default;
		int num15 = default;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum2 = default;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum value = default;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum3 = default;
		object obj71 = default;
		object obj73 = default;
		PhotonSocket photonSocket = default;
		object obj75 = default;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum4 = default;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum value2 = default;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum5 = default;
		int num24 = default;
		object obj84 = default;
		Uri uri11 = default;
		NullReferenceException ex8 = default;
		string text17 = default;
		object obj88 = default;
		NullReferenceException ex9 = default;
		string format5 = default;
		Uri uri12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166C0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			clientWebSocket._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			Uri uri5 = (Uri)(this + 96);
			uri5 = (Uri)(object)clientWebSocket;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			text = (string)(object)uri5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			bool flag12 = (object)uri5 == null;
			Uri uri4 = (Uri)(object)clientWebSocket;
			if (flag12)
			{
				break;
			}
			text = (string)text._stringLength;
			string serializationProtocol = SerializationProtocol;
			bool flag13 = text._stringLength == 0;
			uri4 = (Uri)(object)clientWebSocket;
			if (flag13)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7050]");
			object obj10 = 0;
			((ClientWebSocketOptions)text._stringLength).AddSubProtocol(serializationProtocol);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			cancellationTokenSource2._002Ector(10000);
			text = (string)(object)uri5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			string text3 = (string)(object)uri;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			uri7._002Ector((string)(object)uri);
			bool flag14 = cancellationTokenSource2 == null;
			photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
			obj2 = null;
			uri4 = uri;
			uri = uri7;
			if (flag14)
			{
				break;
			}
			CancellationToken token = cancellationTokenSource2.Token;
			bool flag15 = text == null;
			photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
			obj2 = null;
			uri4 = null;
			uri = uri7;
			if (flag15)
			{
				break;
			}
			Task task = ((ClientWebSocket)(object)text).ConnectAsync(uri7, token);
			bool flag16 = task == null;
			object obj11 = null;
			cancellationTokenSource = cancellationTokenSource2;
			obj2 = token;
			Uri uri6 = uri7;
			uri = (Uri)(object)task;
			if (!flag16)
			{
				task.Wait();
				bool isFaulted = task.IsFaulted;
				bool flag17 = !isFaulted;
				obj11 = null;
				obj2 = token;
				uri4 = null;
				PeerBase peerBase = (PeerBase)isFaulted;
				if (!flag17)
				{
					AggregateException exception = task.Exception;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516700]");
					object obj12 = 0;
					string text5;
					if (exception != null)
					{
						string message = ((Exception)exception).Message;
						text5 = message;
					}
					else
					{
						text5 = null;
					}
					string text6 = (string)obj12 + text5;
					bool flag18 = base.peerBase == null;
					obj11 = null;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					obj2 = null;
					uri4 = (Uri)(object)text5;
					uri = (Uri)obj12;
					if (flag18)
					{
						break;
					}
					base.peerBase.EnqueueDebugReturn((LogLevel)1, text6);
					obj11 = null;
					obj2 = text6;
					uri4 = (Uri)1;
					peerBase = base.peerBase;
				}
				nint num2 = (nint)uri5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				bool flag19 = (object)uri5 == null;
				photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
				uri = uri5;
				if (flag19)
				{
					break;
				}
				object obj13 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v20+1B0]");
				uri4 = (Uri)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v630 @ X8_v20+1A8] (should have been resolved before IL gen)");
				TaskStatus taskStatus;
				if ((nint)obj14 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					base.stateField = (PhotonSocketState)2;
					bool flag20 = base.peerBase == null;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					uri = uri5;
					if (flag20)
					{
						break;
					}
					int mtu = base.peerBase.mtu;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D39E0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					memoryStream2._002Ector(mtu);
					bool flag21 = base.peerBase == null;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					obj2 = null;
					uri4 = (Uri)mtu;
					text = (string)mtu;
					uri = (Uri)(object)memoryStream2;
					if (flag21)
					{
						break;
					}
					int mtu2 = base.peerBase.mtu;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6DF8]");
					object obj17 = 0;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v52+E4]");
					bool flag22 = (byte)(~(nuint)0u) != 0;
					object obj19 = !flag22;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FADE0]");
					object obj20 = 0;
					obj2 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4969834");
					nint num3 = (nint)uri5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					bool flag23 = (object)uri5 == null;
					photonPeerListener = (IPhotonPeerListener)uri5;
					uri4 = (Uri)(object)text7;
					text = text7;
					uri = (Uri)(object)memoryStream2;
					if (flag23)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166E0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516710]");
					object format = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166E8]");
					uri = (Uri)0;
					object obj24 = 0;
					while (true)
					{
						object obj25 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v56+1B0]");
						uri4 = (Uri)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v632 @ X8_v56+1A8] (should have been resolved before IL gen)");
						CancellationToken none;
						TaskStatus status;
						string text11;
						LogLevel logLevel;
						object obj43;
						PeerBase peerBase2;
						if ((nint)obj26 == 2)
						{
							nint num4 = (nint)uri5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							object obj27 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1316 @ X0_v167+E4]");
							bool flag24 = (nint)0 == 0;
							object obj28 = !flag24;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							none = CancellationToken.None;
							NullReferenceException ex5;
							if (num4 != 0)
							{
								object obj29 = num4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v82+200]");
								string text8 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v618 @ X8_v82+1F8] (should have been resolved before IL gen)");
								bool flag25 = task2 == null;
								obj2 = null;
								if (!flag25)
								{
									while (true)
									{
										bool isCompleted = task2.IsCompleted;
										bool flag26 = !isCompleted;
										object obj30 = !flag26;
										if (obj30 != null)
										{
											break;
										}
										bool flag27 = task2.Wait(50);
										obj2 = null;
									}
									bool isCompleted2 = task2.IsCompleted;
									bool flag28 = !isCompleted2;
									obj11 = none;
									text3 = text2;
									uri4 = null;
									peerBase2 = (PeerBase)isCompleted2;
									memoryStream = null;
									if (!flag28)
									{
										nint num5 = (nint)uri5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
										bool flag29 = (object)uri5 == null;
										obj11 = none;
										text3 = (string)(object)uri5;
										photonPeerListener = (IPhotonPeerListener)task2;
										uri4 = null;
										memoryStream = null;
										if (flag29)
										{
											break;
										}
										object obj31 = num5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v84+1B0]");
										uri4 = (Uri)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v622 @ X8_v84+1A8] (should have been resolved before IL gen)");
										bool flag30 = (nint)peerBase2 != 2;
										obj11 = none;
										text3 = (string)(object)uri5;
										memoryStream = null;
										if (!flag30)
										{
											if (task2.IsCanceled)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												status = task2.Status;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												bool flag31 = text9 == null;
												taskStatus = status;
												obj11 = none;
												text3 = text9;
												photonPeerListener = (IPhotonPeerListener)task2;
												uri4 = (Uri)(&taskStatus);
												memoryStream = null;
												if (flag31)
												{
													break;
												}
												bool flag32 = photonPeerListener2 == null;
												Uri uri8 = (Uri)(&taskStatus);
												Uri uri9;
												if (!flag32)
												{
													nint num6 = (nint)text9;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1515 @ X8_v133 (Il2CppClass<System.String>)+40]");
													uri8 = (Uri)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag33 = ex4 == null;
													photonPeerListener = photonPeerListener2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1515 @ X8_v133 (Il2CppClass<System.String>)+40]");
													uri9 = (Uri)0;
													if (flag33)
													{
														goto IL_20c2;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v241 (System.String)+18]");
												bool flag34 = (nint)0 == 0;
												photonPeerListener = photonPeerListener2;
												if (!flag34)
												{
													object obj32 = text9 + 32;
													obj32 = photonPeerListener2;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													photonPeerListener = (IPhotonPeerListener)(object)base.ServerAddress__BackingField;
													bool flag35 = base.ServerAddress__BackingField == null;
													uri8 = (Uri)photonPeerListener2;
													if (!flag35)
													{
														nint num7 = (nint)text9;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ X8_v132 (Il2CppClass<System.String>)+40]");
														uri8 = (Uri)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag36 = ex4 == null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ X8_v132 (Il2CppClass<System.String>)+40]");
														uri9 = (Uri)0;
														if (flag36)
														{
															goto IL_20c2;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v241 (System.String)+18]");
													object obj33 = 0 & 0xFFFFFFFEL;
													if (obj33 != null)
													{
														object obj34 = text9 + 40;
														obj34 = photonPeerListener;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														bool flag37 = (object)uri10 == null;
														uri8 = (Uri)(&num8);
														if (!flag37)
														{
															nint num9 = (nint)text9;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X8_v131 (Il2CppClass<System.String>)+40]");
															uri8 = (Uri)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag38 = ex4 == null;
															num8 = base.ServerPort__BackingField;
															photonPeerListener = (IPhotonPeerListener)uri10;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X8_v131 (Il2CppClass<System.String>)+40]");
															uri9 = (Uri)0;
															if (flag38)
															{
																goto IL_20c2;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v241 (System.String)+18]");
														bool flag39 = (nint)0 < (nint)2;
														object obj35 = !flag39;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v241 (System.String)+18]");
														object obj36 = -2;
														bool flag40 = obj36 == null;
														object obj37 = ~obj35;
														object obj38 = obj37 | flag40;
														num8 = base.ServerPort__BackingField;
														photonPeerListener = (IPhotonPeerListener)uri10;
														if (obj38 == null)
														{
															object obj39 = text9 + 48;
															obj39 = uri10;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															nint num10 = (nint)uri5;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
															bool flag41 = (object)uri5 == null;
															num8 = base.ServerPort__BackingField;
															taskStatus = status;
															obj11 = none;
															text3 = text9;
															photonPeerListener = (IPhotonPeerListener)uri5;
															uri4 = uri10;
															memoryStream = null;
															if (flag41)
															{
																break;
															}
															object obj40 = num10;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X8_v126+1A0]");
															uri8 = (Uri)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1699 @ X8_v126+198] (should have been resolved before IL gen)");
															if (photonPeerListener3 != null)
															{
																nint num11 = (nint)text9;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1589 @ X8_v130 (Il2CppClass<System.String>)+40]");
																uri8 = (Uri)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag42 = ex4 == null;
																num8 = base.ServerPort__BackingField;
																photonPeerListener = photonPeerListener3;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1589 @ X8_v130 (Il2CppClass<System.String>)+40]");
																uri9 = (Uri)0;
																if (flag42)
																{
																	goto IL_20c2;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v241 (System.String)+18]");
															object obj41 = 0 & 0xFFFFFFFCL;
															bool flag43 = obj41 == null;
															num8 = base.ServerPort__BackingField;
															photonPeerListener = photonPeerListener3;
															if (!flag43)
															{
																object obj42 = text9 + 56;
																obj42 = photonPeerListener3;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																string text10 = string.Format((string)format, (object[])(object)text9);
																bool flag44 = base.peerBase == null;
																num8 = base.ServerPort__BackingField;
																taskStatus = status;
																obj11 = none;
																text3 = text9;
																photonPeerListener = photonPeerListener3;
																obj2 = null;
																uri4 = (Uri)(object)text9;
																memoryStream = null;
																if (flag44)
																{
																	break;
																}
																num8 = base.ServerPort__BackingField;
																taskStatus = status;
																text3 = text9;
																text11 = text10;
																logLevel = (LogLevel)1;
																peerBase2 = base.peerBase;
																obj43 = null;
																goto IL_247c;
															}
														}
													}
												}
												ex4 = new IndexOutOfRangeException();
												uri9 = uri8;
												goto IL_20c2;
											}
											uri4 = uri;
											System.__Canon result = ((Task<System.__Canon>)task2).Result;
											bool flag45 = result == null;
											obj11 = none;
											text3 = (string)(object)uri5;
											photonPeerListener = (IPhotonPeerListener)task2;
											memoryStream = null;
											if (flag45)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v191 (System.__Canon)+10]");
											bool flag46 = (nint)0 == 0;
											object obj44 = !flag46;
											if (obj44 == null)
											{
												bool flag47 = base.peerBase == null;
												obj11 = none;
												text3 = (string)(object)uri5;
												photonPeerListener = (IPhotonPeerListener)task2;
												memoryStream = null;
												if (flag47)
												{
													break;
												}
												LogLevel logLevel2 = base.peerBase.LogLevel;
												object obj45 = logLevel2 & (LogLevel)0xFF;
												bool flag48 = (nint)obj45 < 3;
												object obj46 = !flag48;
												object obj47 = ~obj46;
												obj11 = none;
												text3 = (string)(object)uri5;
												uri4 = null;
												peerBase2 = (PeerBase)logLevel2;
												memoryStream = null;
												if (obj47 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166A0]");
													object obj48 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													memoryStream = (MemoryStream)(object)this.clientWebSocket;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
													bool flag49 = this.clientWebSocket == null;
													taskStatus = (TaskStatus)base.stateField;
													obj11 = none;
													text3 = (string)obj49;
													photonPeerListener = (IPhotonPeerListener)task2;
													uri4 = (Uri)(&taskStatus);
													if (flag49)
													{
														break;
													}
													((object)this.clientWebSocket).Finalize();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166F0]");
													object obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													TaskStatus status2 = task2.Status;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516718]");
													object format2 = 0;
													string text12 = string.Format((string)format2, obj49, obj51, obj52);
													bool flag50 = base.peerBase == null;
													TaskStatus taskStatus2 = status2;
													num8 = num12;
													taskStatus = (TaskStatus)base.stateField;
													text8 = null;
													obj11 = obj52;
													text3 = (string)obj49;
													photonPeerListener = (IPhotonPeerListener)task2;
													obj2 = obj51;
													uri4 = (Uri)obj49;
													memoryStream = (MemoryStream)obj51;
													if (flag50)
													{
														break;
													}
													taskStatus2 = status2;
													num8 = num12;
													taskStatus = (TaskStatus)base.stateField;
													text8 = null;
													text3 = (string)obj49;
													text11 = text12;
													logLevel = (LogLevel)3;
													peerBase2 = base.peerBase;
													obj43 = obj51;
													goto IL_247c;
												}
											}
											else
											{
												uri4 = uri;
												System.__Canon result2 = ((Task<System.__Canon>)task2).Result;
												bool flag51 = result2 == null;
												obj11 = none;
												text3 = (string)(object)uri5;
												photonPeerListener = (IPhotonPeerListener)task2;
												memoryStream = null;
												if (flag51)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v193 (System.__Canon)+14]");
												if ((nint)0 != 0)
												{
													object obj53 = obj24 & 1;
													int num14;
													if (obj53 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6DF8]");
														object obj54 = 0;
														object obj55 = obj54;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1597 @ X0_v208+E4]");
														bool flag52 = (nint)0 == 0;
														object obj56 = !flag52;
														if (obj56 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														uri4 = uri;
														System.__Canon result3 = ((Task<System.__Canon>)task2).Result;
														bool flag53 = result3 == null;
														obj11 = none;
														text3 = text2;
														photonPeerListener = (IPhotonPeerListener)task2;
														memoryStream = null;
														if (flag53)
														{
															break;
														}
														bool flag54 = memoryStream2 == null;
														obj11 = none;
														text3 = text2;
														photonPeerListener = (IPhotonPeerListener)task2;
														memoryStream = memoryStream2;
														if (flag54)
														{
															break;
														}
														nint num13 = (nint)memoryStream2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1645 @ X8_v99 (Il2CppClass<System.IO.MemoryStream>)+380]");
														text8 = (string)0;
														int hashCode = ((ValueType)(object)memoryStream2).GetHashCode();
														((object)memoryStream2).Finalize();
														((object)memoryStream2).Finalize();
														int hashCode2 = ((ValueType)(object)memoryStream2).GetHashCode();
														string text13 = ((ValueType)(object)memoryStream2).ToString();
														text3 = text14;
														num14 = num15;
														memoryStream = memoryStream2;
													}
													else
													{
														uri4 = uri;
														System.__Canon result4 = ((Task<System.__Canon>)task2).Result;
														bool flag55 = result4 == null;
														obj11 = none;
														text3 = (string)(object)uri5;
														photonPeerListener = (IPhotonPeerListener)task2;
														memoryStream = null;
														if (flag55)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6DF8]");
														object obj57 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v204 (System.__Canon)+10]");
														num14 = 0;
														object obj58 = obj57;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1618 @ X0_v205+E4]");
														bool flag56 = (byte)(~(nuint)0u) != 0;
														object obj59 = !flag56;
														if (obj59 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														text3 = text2;
														memoryStream = null;
													}
													HandleReceivedDatagram((byte[])(object)text3, num14, willBeReused: true);
													obj24 = 0;
													obj11 = 1;
													obj2 = num14;
													uri4 = (Uri)(object)text3;
													peerBase2 = (PeerBase)(object)this;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6DF8]");
													object obj60 = 0;
													object obj61 = obj60;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X0_v194+E4]");
													bool flag57 = (nint)0 == 0;
													object obj62 = !flag57;
													if (obj62 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													uri4 = uri;
													System.__Canon result5 = ((Task<System.__Canon>)task2).Result;
													bool flag58 = result5 == null;
													obj11 = none;
													text3 = text2;
													photonPeerListener = (IPhotonPeerListener)task2;
													memoryStream = null;
													if (flag58)
													{
														break;
													}
													bool flag59 = memoryStream2 == null;
													obj11 = none;
													text3 = text2;
													photonPeerListener = (IPhotonPeerListener)task2;
													memoryStream = null;
													if (flag59)
													{
														break;
													}
													nint num16 = (nint)memoryStream2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v197 (System.__Canon)+10]");
													obj11 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1639 @ X8_v91 (Il2CppClass<System.IO.MemoryStream>)+380]");
													text8 = (string)0;
													peerBase2 = (PeerBase)((ValueType)(object)memoryStream2).GetHashCode();
													obj24 = 1;
													text3 = text2;
													obj2 = null;
													uri4 = (Uri)(object)text2;
													memoryStream = null;
												}
											}
										}
									}
									goto IL_13ca;
								}
								ex5 = new NullReferenceException();
								obj11 = none;
								num4 = (nint)task2;
								obj2 = null;
								uri4 = (Uri)(object)text2;
							}
							else
							{
								ex5 = new NullReferenceException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							text3 = text2;
							photonPeerListener = (IPhotonPeerListener)num4;
							NullReferenceException ex6 = ex5;
							memoryStream = null;
							goto IL_21a7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						if (base.stateField != (PhotonSocketState)3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							if (base.stateField != 0)
							{
								nint num17 = (nint)uri5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
								bool flag60 = (object)uri5 == null;
								photonPeerListener = (IPhotonPeerListener)num3;
								uri = uri5;
								if (flag60)
								{
									break;
								}
								object obj63 = num17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v59+190]");
								uri4 = (Uri)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v633 @ X8_v59+188] (should have been resolved before IL gen)");
								nint num18 = (nint)uri5;
								text = (string)((_003F?)_Il2CppInt32Enum2 & 0xFF);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
								if (text != null)
								{
									bool flag61 = (object)uri5 == null;
									_Il2CppInt32Enum = _Il2CppInt32Enum2;
									photonPeerListener = (IPhotonPeerListener)num3;
									uri = uri5;
									if (flag61)
									{
										break;
									}
									object obj64 = num18;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1436 @ X8_v77+188] (should have been resolved before IL gen)");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166D0]");
									object obj65 = 0;
									uri4 = (Uri)obj65;
									value = _Il2CppInt32Enum.Value;
									_Il2CppInt32Enum = _Il2CppInt32Enum3;
								}
								else
								{
									bool flag62 = (object)uri5 == null;
									_Il2CppInt32Enum = _Il2CppInt32Enum2;
									photonPeerListener = (IPhotonPeerListener)num3;
									uri = uri5;
									if (flag62)
									{
										break;
									}
									object obj66 = num18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v76+1B0]");
									uri4 = (Uri)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1447 @ X8_v76+1A8] (should have been resolved before IL gen)");
									_Il2CppInt32Enum = _Il2CppInt32Enum2;
								}
								base.SocketErrorCode__BackingField = (int)value;
								bool flag63 = base.peerBase == null;
								photonPeerListener = (IPhotonPeerListener)num3;
								uri = uri5;
								if (flag63)
								{
									break;
								}
								LogLevel logLevel3 = base.peerBase.LogLevel;
								object obj67 = logLevel3 & (LogLevel)0xFF;
								bool flag64 = (nint)obj67 < 3;
								object obj68 = !flag64;
								object obj69 = ~obj68;
								uri4 = null;
								PeerBase peerBase3 = (PeerBase)logLevel3;
								if (obj69 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166A0]");
									object obj70 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									text = (string)(object)this.clientWebSocket;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
									bool flag65 = this.clientWebSocket == null;
									taskStatus = (TaskStatus)base.stateField;
									photonPeerListener = (IPhotonPeerListener)num3;
									uri4 = (Uri)(&taskStatus);
									uri = (Uri)obj71;
									if (flag65)
									{
										break;
									}
									bool flag66 = ((ValueType)(object)this.clientWebSocket).Equals((object)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166F0]");
									object obj72 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166F8]");
									object format3 = 0;
									string text15 = string.Format((string)format3, obj71, obj73);
									bool flag67 = base.peerBase == null;
									num8 = (flag66 ? 1 : 0);
									taskStatus = (TaskStatus)base.stateField;
									obj11 = null;
									photonPeerListener = (IPhotonPeerListener)num3;
									obj2 = obj73;
									uri4 = (Uri)obj71;
									uri = (Uri)obj71;
									if (flag67)
									{
										break;
									}
									base.peerBase.EnqueueDebugReturn((LogLevel)3, text15);
									num8 = (flag66 ? 1 : 0);
									taskStatus = (TaskStatus)base.stateField;
									obj11 = null;
									obj2 = text15;
									uri4 = (Uri)3;
									peerBase3 = base.peerBase;
								}
								nint num19 = (nint)uri5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
								bool flag68 = (object)uri5 == null;
								photonPeerListener = (IPhotonPeerListener)num3;
								uri = uri5;
								if (flag68)
								{
									break;
								}
								object obj74 = num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v64+1B0]");
								uri4 = (Uri)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ X8_v64+1A8] (should have been resolved before IL gen)");
								if ((nint)photonSocket == 4)
								{
									HandleException((StatusCode)1043);
									uri4 = (Uri)1043;
									photonSocket = this;
								}
								uri5 = uri5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
								bool flag69 = (object)uri5 == null;
								photonPeerListener = (IPhotonPeerListener)num3;
								uri = uri5;
								if (flag69)
								{
									break;
								}
								nint num20 = (nint)uri5;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1346 @ X8_v65 (Il2CppClass<System.Uri>)+1A8] (should have been resolved before IL gen)");
								if ((nint)obj75 == 6)
								{
									HandleException((StatusCode)1044);
								}
							}
						}
						string text16 = ((Enum)(object)this).ToString((string)0, (IFormatProvider)obj2);
						return;
						IL_13ca:
						num3 = (nint)uri5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						bool flag70 = (object)uri5 == null;
						object obj76 = !flag70;
						if (obj76 == null)
						{
							photonPeerListener = (IPhotonPeerListener)uri5;
							break;
						}
						continue;
						IL_20c2:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
						ArgumentNullException ex7 = new ArgumentNullException();
						taskStatus = status;
						obj11 = none;
						text3 = text9;
						uri6 = null;
						memoryStream = null;
						goto IL_20fc;
						IL_247c:
						peerBase2.EnqueueDebugReturn(logLevel, text11);
						obj11 = null;
						obj2 = text11;
						uri4 = (Uri)logLevel;
						memoryStream = (MemoryStream)obj43;
						goto IL_13ca;
					}
					break;
				}
				nint num21 = (nint)uri5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				bool flag71 = (object)uri5 == null;
				photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
				uri = uri5;
				if (flag71)
				{
					break;
				}
				object obj77 = num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v22+190]");
				uri4 = (Uri)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v631 @ X8_v22+188] (should have been resolved before IL gen)");
				nint num22 = (nint)uri5;
				text = (string)((_003F?)_Il2CppInt32Enum4 & 0xFF);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				if (text != null)
				{
					bool flag72 = (object)uri5 == null;
					_Il2CppInt32Enum = _Il2CppInt32Enum4;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					uri = uri5;
					if (flag72)
					{
						break;
					}
					object obj78 = num22;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1145 @ X8_v40+188] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166D0]");
					object obj79 = 0;
					uri4 = (Uri)obj79;
					value2 = _Il2CppInt32Enum.Value;
					_Il2CppInt32Enum = _Il2CppInt32Enum5;
				}
				else
				{
					bool flag73 = (object)uri5 == null;
					_Il2CppInt32Enum = _Il2CppInt32Enum4;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					uri = uri5;
					if (flag73)
					{
						break;
					}
					object obj80 = num22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v39+1B0]");
					uri4 = (Uri)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1156 @ X8_v39+1A8] (should have been resolved before IL gen)");
					_Il2CppInt32Enum = _Il2CppInt32Enum4;
				}
				base.SocketErrorCode__BackingField = (int)value2;
				bool flag74 = base.peerBase == null;
				photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
				uri = uri5;
				if (flag74)
				{
					break;
				}
				LogLevel logLevel4 = base.peerBase.LogLevel;
				object obj81 = logLevel4 & (LogLevel)0xFF;
				if (obj81 != null)
				{
					nint num23 = (nint)uri5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					bool flag75 = (object)uri5 == null;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					uri4 = null;
					uri = uri5;
					if (flag75)
					{
						break;
					}
					object obj82 = num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1203 @ X8_v26+1A8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166F0]");
					object obj83 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					text = (string)(object)uri5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					bool flag76 = (object)uri5 == null;
					num8 = num24;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					uri4 = (Uri)(&num8);
					uri = (Uri)obj84;
					if (flag76)
					{
						break;
					}
					int hashCode3 = ((ValueType)(object)uri5).GetHashCode();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166D8]");
					object obj85 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					text = (string)(object)uri5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					bool flag77 = (object)uri5 == null;
					num8 = num24;
					taskStatus = (TaskStatus)hashCode3;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					uri4 = (Uri)(&taskStatus);
					uri = (Uri)obj84;
					uri5 = uri11;
					if (flag77)
					{
						break;
					}
					object obj86 = ((ValueType)(object)uri11).ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516708]");
					object format4 = 0;
					string debugReturn = string.Format((string)format4, obj84, uri11, obj86);
					bool flag78 = base.peerBase == null;
					num8 = num24;
					taskStatus = (TaskStatus)hashCode3;
					string text8 = null;
					obj11 = obj86;
					photonPeerListener = (IPhotonPeerListener)cancellationTokenSource2;
					obj2 = uri11;
					uri4 = (Uri)obj84;
					uri = (Uri)obj84;
					uri5 = uri11;
					if (flag78)
					{
						break;
					}
					base.peerBase.EnqueueDebugReturn((LogLevel)1, debugReturn);
				}
				HandleException((StatusCode)1023);
				return;
			}
			goto IL_2120;
			IL_21a7:
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				bool flag79 = (nint)uri4 != 1;
				NullReferenceException ex6 = ex8;
				if (!flag79)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					nint num25 = (nint)text17;
					uri4 = (Uri)num25;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj87 = obj88 & 1;
					bool flag80 = obj87 == null;
					text = text17;
					if (!flag80)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj89 = text;
					uri4 = (Uri)(101789696 + 1224);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					obj2 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex6 = ex9;
				}
			}
			text = text17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			bool flag81 = ReportDebugOfLevel((LogLevel)1);
			bool flag82 = !flag81;
			uri3 = (Uri)1;
			if (!flag82)
			{
				IPhotonPeerListener listener = Listener;
				string host2 = uri5.Host;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string text18 = string.Format(format5, host2, text);
				bool flag83 = listener == null;
				obj11 = null;
				photonPeerListener = listener;
				obj2 = text;
				uri4 = (Uri)(object)host2;
				uri5 = (Uri)(object)host2;
				if (flag83)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
				string text8 = text18;
				obj11 = 1;
				photonPeerListener = listener;
				obj2 = listener;
				uri3 = uri12;
			}
		}
		goto IL_235b;
	}

	public unsafe override bool Disconnect()
	{
		//IL_0522: Expected Obj, but got I4
		//IL_0040: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got Ref
		//IL_0164: Expected Obj, but got I4
		//IL_0171: Expected I, but got Obj
		//IL_02da: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_0197: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got Ref
		//IL_01ee: Expected Obj, but got I4
		//IL_08e0: Expected Obj, but got I4
		//IL_08e5: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got Ref
		//IL_0418: Expected Obj, but got I4
		//IL_0422: Expected I, but got Obj
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_04c6: Expected Obj, but got I4
		//IL_04cb: Expected I, but got Obj
		//IL_04e8: Expected I, but got Obj
		//IL_06f9: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I
		//IL_0448: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_0478: Expected Obj, but got I4
		//IL_0491: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got Ref
		//IL_04a2: Expected Obj, but got I4
		//IL_060e: Expected Obj, but got Ref
		//IL_07c2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		SynchronizationContext synchronizationContext;
		object obj6;
		CancellationToken cancellationToken;
		object obj8;
		object obj9;
		SynchronizationContext synchronizationContext2 = default;
		object obj10;
		string text2 = default;
		object obj7 = default;
		CancellationToken cancellationToken2 = default;
		nint num3;
		nint num4;
		string text;
		object obj5;
		if (this.clientWebSocket != null)
		{
			ClientWebSocket clientWebSocket = this.clientWebSocket;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			if (this.clientWebSocket == null)
			{
				goto IL_0519;
			}
			nint num = (nint)clientWebSocket;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v33 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1A8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v33 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1B0]");
			num3 = 0;
			((object)this.clientWebSocket).Finalize();
			object obj = default;
			if ((nint)obj == 4)
			{
				SynchronizationContext current = SynchronizationContext.Current;
				SynchronizationContext.SetSynchronizationContext(null);
				ClientWebSocket clientWebSocket2 = this.clientWebSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v85+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CancellationToken none = CancellationToken.None;
				bool flag2 = this.clientWebSocket == null;
				obj5 = 0;
				synchronizationContext = null;
				obj6 = obj7;
				text = text2;
				cancellationToken = cancellationToken2;
				obj8 = 0;
				obj9 = (object)(&synchronizationContext2);
				obj10 = 0;
				synchronizationContext2 = current;
				num4 = unchecked((nint)null);
				if (flag2)
				{
					goto IL_0574;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516760]");
				object obj11 = 0;
				num2 = (nint)clientWebSocket2;
				text2 = (string)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X9_v3 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1D0]");
				obj7 = 0;
				string text3 = this.clientWebSocket.ToString();
				obj5 = 0;
				synchronizationContext = null;
				cancellationToken2 = none;
				obj8 = 0;
				obj9 = (object)(&synchronizationContext2);
				obj10 = 0;
				goto IL_0871;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		SynchronizationContext synchronizationContext3 = default;
		if (this.clientWebSocket != null)
		{
			ClientWebSocket clientWebSocket3 = this.clientWebSocket;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			if (this.clientWebSocket == null)
			{
				goto IL_0519;
			}
			nint num5 = (nint)clientWebSocket3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v23 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1A8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v23 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1B0]");
			num3 = 0;
			((object)this.clientWebSocket).Finalize();
			if ((nint)synchronizationContext3 != 5)
			{
				ClientWebSocket clientWebSocket4 = this.clientWebSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				if (this.clientWebSocket == null)
				{
					goto IL_0519;
				}
				nint num6 = (nint)clientWebSocket4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v24 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1A8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v24 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1B0]");
				num3 = 0;
				((object)this.clientWebSocket).Finalize();
				if ((nint)synchronizationContext3 != 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					base.stateField = (PhotonSocketState)3;
					SynchronizationContext current2 = SynchronizationContext.Current;
					SynchronizationContext.SetSynchronizationContext(null);
					ClientWebSocket clientWebSocket5 = this.clientWebSocket;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
					object obj12 = 0;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v71+E4]");
					bool flag3 = (nint)0 == 0;
					object obj14 = !flag3;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CancellationToken none2 = CancellationToken.None;
					bool flag4 = this.clientWebSocket == null;
					obj5 = 0;
					synchronizationContext = current2;
					obj6 = obj7;
					text = text2;
					cancellationToken = cancellationToken2;
					obj8 = 0;
					obj9 = (object)(&synchronizationContext);
					obj10 = 0;
					synchronizationContext2 = null;
					num4 = unchecked((nint)null);
					if (flag4)
					{
						goto IL_0582;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516768]");
					object obj15 = 0;
					num2 = (nint)clientWebSocket5;
					text2 = (string)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X9_v3 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1E0]");
					obj7 = 0;
					ConfigurationPropertyCollection properties = ((PerformanceCountersElement)(object)this.clientWebSocket).Properties;
					obj5 = 0;
					synchronizationContext = current2;
					cancellationToken2 = none2;
					obj8 = 0;
					obj9 = (object)(&synchronizationContext);
					obj10 = 0;
					synchronizationContext2 = null;
					goto IL_0871;
				}
			}
		}
		goto IL_04fe;
		IL_04fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		base.stateField = (PhotonSocketState)0;
		return true;
		IL_082a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_08b5:
		synchronizationContext3 = (SynchronizationContext)obj9;
		SynchronizationContext.SetSynchronizationContext((SynchronizationContext)obj9);
		object obj16;
		bool flag5 = obj16 == null;
		object obj17 = !flag5;
		num3 = unchecked((nint)null);
		if (obj17 == null)
		{
			bool flag6 = obj10 == null;
			object obj18 = !flag6;
			num3 = unchecked((nint)null);
			obj6 = obj7;
			text = text2;
			cancellationToken = cancellationToken2;
			num4 = unchecked((nint)null);
			OutOfMemoryException ex = (OutOfMemoryException)obj9;
			if (obj18 == null)
			{
				goto IL_04fe;
			}
		}
		else
		{
			OutOfMemoryException ex = new OutOfMemoryException();
			obj6 = obj7;
			text = text2;
			cancellationToken = cancellationToken2;
			num4 = num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0574;
		IL_0574:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0582;
		IL_0582:
		NullReferenceException ex3 = new NullReferenceException();
		if (num4 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj20 = default;
			object obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj22 = default;
			object obj21 = obj22 & 1;
			if (obj21 != null)
			{
				object obj24 = default;
				object obj23 = (object)(&obj24);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				if (ReportDebugOfLevel((LogLevel)4))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format = default;
					string text4 = string.Format(format, obj20);
					EnqueueDebugReturn((LogLevel)4, text4);
					text = text4;
				}
				obj7 = obj6;
				text2 = text;
				cancellationToken2 = cancellationToken;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj25 = obj20;
				num4 = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				if (num4 != 1)
				{
					if (num4 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						object obj26 = default;
						obj16 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj7 = obj6;
						text2 = null;
						cancellationToken2 = cancellationToken;
						obj8 = obj26;
						goto IL_08b5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB444");
					text = null;
					NullReferenceException ex5 = default;
					NullReferenceException ex4 = ex5;
					goto IL_082a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj7 = obj6;
				text2 = null;
				cancellationToken2 = cancellationToken;
				obj10 = 1;
			}
		}
		else
		{
			if (num4 != 1)
			{
				if (num4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					object obj27 = default;
					obj16 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj7 = obj6;
					text2 = text;
					cancellationToken2 = cancellationToken;
					obj8 = obj27;
					goto IL_08b5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB444");
				NullReferenceException ex4 = ex3;
				goto IL_082a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj7 = obj6;
			text2 = text;
			cancellationToken2 = cancellationToken;
			obj10 = 1;
		}
		goto IL_0871;
		IL_0871:
		obj16 = obj8;
		goto IL_08b5;
		IL_0519:
		obj5 = 0;
		synchronizationContext = null;
		synchronizationContext2 = null;
		throw new NullReferenceException();
	}

	public unsafe override PhotonSocketError Send(byte[] data, int length)
	{
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_07ab: Expected Obj, but got I4
		//IL_004e: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got Ref
		//IL_0588: Expected Obj, but got I4
		//IL_0816: Expected Obj, but got I4
		//IL_05b8: Expected I, but got Obj
		//IL_05d0: Expected Obj, but got I4
		//IL_05ec: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got Ref
		//IL_0607: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_0aaf: Expected Obj, but got I4
		//IL_086d: Expected Obj, but got I
		//IL_09cf: Expected I4, but got Obj
		//IL_09e1: Expected I4, but got Obj
		//IL_0990: Expected Obj, but got I4
		//IL_0642: Expected Obj, but got I4
		//IL_011a: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_09ef: Expected Obj, but got I4
		//IL_0279: Expected I, but got Obj
		//IL_028a: Expected Obj, but got I
		//IL_0760: Expected Obj, but got I4
		//IL_0694: Expected Obj, but got I4
		//IL_0195: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_06e6: Expected Obj, but got I4
		//IL_02f6: Expected I, but got Obj
		//IL_0307: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I
		//IL_0239: Expected VT, but got Obj
		//IL_0398: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I
		//IL_039c: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		bool flag = this.clientWebSocket == null;
		byte[] array = data;
		SynchronizationContext synchronizationContext = default;
		StatusCode statusCode;
		PhotonSocket photonSocket;
		int num4 = default;
		ClientWebSocket clientWebSocket;
		if (!flag)
		{
			clientWebSocket = this.clientWebSocket;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			bool flag2 = this.clientWebSocket == null;
			synchronizationContext = null;
			array = data;
			if (flag2)
			{
				goto IL_0918;
			}
			nint num = (nint)clientWebSocket;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v24 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1B0]");
			array = (byte[])0;
			((object)this.clientWebSocket).Finalize();
			object obj = default;
			if ((nint)obj != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				if (base.stateField != (PhotonSocketState)3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					if (base.stateField != 0)
					{
						clientWebSocket = this.clientWebSocket;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						bool flag3 = this.clientWebSocket == null;
						synchronizationContext = null;
						if (!flag3)
						{
							nint num2 = (nint)clientWebSocket;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v25 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1B0]");
							array = (byte[])0;
							((object)this.clientWebSocket).Finalize();
							clientWebSocket = this.clientWebSocket;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							object obj2 = default;
							nint num5 = default;
							if ((nint)obj2 == 4)
							{
								bool flag4 = clientWebSocket == null;
								synchronizationContext = null;
								if (!flag4)
								{
									nint num3 = (nint)clientWebSocket;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v34 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+190]");
									array = (byte[])0;
									string text = ((ConfigurationSection)(object)clientWebSocket).SerializeSection((ConfigurationElement)0, (string)num4, (ConfigurationSaveMode)num5);
									clientWebSocket = this.clientWebSocket;
									object obj3 = text & 0xFF;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
									Unity.IL2CPP.Metadata.__Il2CppInt32Enum value = default;
									if (obj3 != null)
									{
										bool flag5 = this.clientWebSocket == null;
										synchronizationContext = null;
										if (flag5)
										{
											goto IL_0918;
										}
										Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)((ConfigurationSection)(object)this.clientWebSocket).SerializeSection((ConfigurationElement)0, (string)num4, (ConfigurationSaveMode)num5);
										Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum2 = default;
										value = _Il2CppInt32Enum2.Value;
									}
									else
									{
										bool flag6 = this.clientWebSocket == null;
										synchronizationContext = null;
										if (flag6)
										{
											goto IL_0918;
										}
										((object)this.clientWebSocket).Finalize();
									}
									base.SocketErrorCode__BackingField = (int)value;
									statusCode = (StatusCode)1043;
									photonSocket = this;
									goto IL_0ac2;
								}
							}
							else
							{
								bool flag7 = this.clientWebSocket == null;
								synchronizationContext = null;
								if (!flag7)
								{
									nint num6 = (nint)clientWebSocket;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v27 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+1B0]");
									array = (byte[])0;
									((object)this.clientWebSocket).Finalize();
									if ((nint)obj != 6)
									{
										goto IL_03af;
									}
									clientWebSocket = this.clientWebSocket;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
									bool flag8 = this.clientWebSocket == null;
									synchronizationContext = null;
									if (!flag8)
									{
										nint num7 = (nint)clientWebSocket;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v28 (Il2CppClass<System.Net.WebSockets.ClientWebSocket>)+190]");
										array = (byte[])0;
										string text2 = ((ConfigurationSection)(object)this.clientWebSocket).SerializeSection((ConfigurationElement)0, (string)num4, (ConfigurationSaveMode)num5);
										clientWebSocket = this.clientWebSocket;
										object obj4 = text2 & 0xFF;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
										Unity.IL2CPP.Metadata.__Il2CppInt32Enum value2 = default;
										if (obj4 != null)
										{
											bool flag9 = this.clientWebSocket == null;
											synchronizationContext = null;
											if (flag9)
											{
												goto IL_0918;
											}
											Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum3 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)((ConfigurationSection)(object)this.clientWebSocket).SerializeSection((ConfigurationElement)0, (string)num4, (ConfigurationSaveMode)num5);
											Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum4 = default;
											value2 = _Il2CppInt32Enum4.Value;
										}
										else
										{
											bool flag10 = this.clientWebSocket == null;
											synchronizationContext = null;
											if (flag10)
											{
												goto IL_0918;
											}
											((object)this.clientWebSocket).Finalize();
										}
										base.SocketErrorCode__BackingField = (int)value2;
										statusCode = (StatusCode)1044;
										photonSocket = this;
										goto IL_0ac2;
									}
								}
							}
						}
						goto IL_0918;
					}
				}
			}
		}
		goto IL_03af;
		IL_0ac2:
		photonSocket.HandleException(statusCode);
		goto IL_090a;
		IL_03af:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		PhotonSocketError photonSocketError;
		PhotonSocketError photonSocketError2;
		object obj11;
		object obj12;
		object obj13;
		if (this.clientWebSocket != null)
		{
			clientWebSocket = (ClientWebSocket)(this + 104);
			bool flag11 = clientWebSocket == null;
			int num8 = num4;
			if (!flag11)
			{
				bool isCompleted = ((Task)(object)clientWebSocket).IsCompleted;
				bool flag12 = !isCompleted;
				object obj5 = !flag12;
				num8 = num4;
				if (obj5 == null)
				{
					bool flag13 = clientWebSocket == null;
					synchronizationContext = null;
					array = null;
					if (flag13)
					{
						goto IL_0918;
					}
					bool flag14 = ((Task)(object)clientWebSocket).Wait(5);
					bool flag15 = !flag14;
					num8 = 0;
					if (flag15)
					{
						photonSocketError = (PhotonSocketError)4;
						goto IL_0a64;
					}
				}
			}
			SynchronizationContext current = SynchronizationContext.Current;
			SynchronizationContext.SetSynchronizationContext(null);
			ClientWebSocket clientWebSocket2 = this.clientWebSocket;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FADE8]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4969888");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v51+E4]");
			bool flag16 = (nint)0 == 0;
			object obj10 = !flag16;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CancellationToken none = CancellationToken.None;
			bool flag17 = this.clientWebSocket == null;
			nint num5 = num4;
			photonSocketError2 = (PhotonSocketError)0;
			obj11 = (object)(&synchronizationContext);
			obj12 = 0;
			synchronizationContext = current;
			num4 = 0;
			array = data;
			if (flag17)
			{
				goto IL_0940;
			}
			nint num9 = (nint)clientWebSocket2;
			bool flag18 = ((ConfigurationElement)(object)this.clientWebSocket).IsModified();
			clientWebSocket = (ClientWebSocket)flag18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num5 = 1;
			obj7 = 1;
			photonSocketError2 = (PhotonSocketError)0;
			obj11 = (object)(&synchronizationContext);
			obj12 = 0;
			num4 = 0;
			photonSocketError = (PhotonSocketError)0;
			obj13 = 23;
			goto IL_0a8c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		if (base.stateField != (PhotonSocketState)3)
		{
			clientWebSocket = (ClientWebSocket)base.stateField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			if (base.stateField != 0)
			{
				bool flag19 = peerBase == null;
				synchronizationContext = null;
				if (!flag19)
				{
					LogLevel logLevel = peerBase.LogLevel;
					object obj14 = logLevel & (LogLevel)0xFF;
					if (obj14 != null)
					{
						bool flag20 = peerBase == null;
						synchronizationContext = null;
						array = null;
						if (flag20)
						{
							goto IL_0918;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516780]");
						object debugReturn = 0;
						peerBase.EnqueueDebugReturn((LogLevel)1, (string)debugReturn);
					}
					goto IL_090a;
				}
				goto IL_0918;
			}
		}
		photonSocketError = (PhotonSocketError)1;
		goto IL_0a64;
		IL_0a64:
		return photonSocketError;
		IL_0a8c:
		SynchronizationContext.SetSynchronizationContext((SynchronizationContext)obj11);
		bool flag21 = photonSocketError == 0;
		object obj15 = !flag21;
		array = null;
		if (obj15 == null)
		{
			bool flag22 = obj12 == null;
			object obj16 = !flag22;
			array = null;
			OutOfMemoryException ex = (OutOfMemoryException)obj11;
			if (obj16 == null)
			{
				if ((nint)obj13 != 23)
				{
					bool flag23 = obj13 == null;
					object obj17 = !flag23;
					if (obj17 != null)
					{
						goto IL_0a64;
					}
				}
				if (clientWebSocket != null)
				{
					bool isCompleted2 = ((Task)(object)clientWebSocket).IsCompleted;
					bool flag24 = !isCompleted2;
					object obj18 = !flag24;
					if (obj18 == null)
					{
						bool flag25 = clientWebSocket == null;
						array = null;
						if (flag25)
						{
							goto IL_0918;
						}
						bool flag26 = ((Task)(object)clientWebSocket).Wait(5);
						bool flag27 = !flag26;
						num4 = 0;
						photonSocketError = (PhotonSocketError)5;
						if (flag27)
						{
							goto IL_0a64;
						}
					}
				}
				clientWebSocket = (ClientWebSocket)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				photonSocketError = (PhotonSocketError)0;
				goto IL_0a64;
			}
		}
		else
		{
			OutOfMemoryException ex = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0940;
		IL_0918:
		throw new NullReferenceException();
		IL_0940:
		NullReferenceException ex2 = new NullReferenceException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = 1;
			photonSocketError = photonSocketError2;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB444");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				PhotonSocketError result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj19 = default;
			photonSocketError = (PhotonSocketError)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			photonSocketError2 = (PhotonSocketError)obj19;
		}
		obj13 = 0;
		goto IL_0a8c;
		IL_090a:
		photonSocketError = (PhotonSocketError)3;
		goto IL_0a64;
	}

	public override PhotonSocketError Receive(out byte[] data)
	{
		//IL_003f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (PhotonSocketError)ex2;
	}
}
