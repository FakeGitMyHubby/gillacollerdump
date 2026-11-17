using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Fusion.Sockets;
using Fusion.Sockets.Stun;
using Fusion.Sockets.V2;

namespace Photon.Client;

internal class TPeer : PeerBase
{
	public class ThreadSafeRandom
	{
		private static readonly Random _r;

		public unsafe static int Next()
		{
			//IL_0010: Expected Obj, but got I
			//IL_01ec: Expected Obj, but got I4
			//IL_029e: Expected Obj, but got I
			//IL_02d5: Expected Obj, but got I4
			//IL_020a: Expected Obj, but got I
			//IL_022f: Expected Obj, but got I4
			//IL_0237: Expected Obj, but got Ref
			//IL_005b: Expected Obj, but got I
			//IL_0073: Expected Obj, but got I4
			//IL_0271: Expected Obj, but got Ref
			//IL_00b9: Expected Obj, but got I4
			//IL_0169: Expected Obj, but got I4
			//IL_0088: Expected Obj, but got Ref
			//IL_009a: Expected Obj, but got I4
			//IL_00e1: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+A0]");
			object obj4 = 0;
			bool lockTaken = default;
			Monitor.Enter(obj4, ref lockTaken);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+A0]");
			object obj7 = 0;
			object obj8 = obj7;
			bool flag3 = obj7 == null;
			OutOfMemoryException ex = null;
			object obj9 = 0;
			object obj10 = (object)(&lockTaken);
			if (flag3)
			{
				goto IL_0119;
			}
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v18+190]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X8_v18+188] (should have been resolved before IL gen)");
			ex = null;
			obj9 = 0;
			int num = default;
			int result = num;
			goto IL_0269;
			IL_0119:
			NullReferenceException ex2 = new NullReferenceException();
			if ((nint)obj10 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj9 = 1;
			}
			else
			{
				if ((nint)obj10 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					int result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj12 = default;
				ex = (OutOfMemoryException)obj12;
			}
			result = 0;
			goto IL_0269;
			IL_0269:
			object obj13 = (object)(&lockTaken);
			if (obj13 != null)
			{
				object obj15 = default;
				object obj14 = (object)(&obj15);
				Monitor.Exit(obj14);
				obj10 = 0;
			}
			bool flag4 = ex == null;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				bool flag5 = obj9 == null;
				object obj17 = !flag5;
				OutOfMemoryException ex3 = ex;
				if (obj17 == null)
				{
					return result;
				}
			}
			else
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0119;
		}

		public unsafe static int Next(int maxValue)
		{
			//IL_0010: Expected Obj, but got I
			//IL_01f4: Expected Obj, but got I4
			//IL_02af: Expected Obj, but got I
			//IL_02e6: Expected Obj, but got I4
			//IL_0212: Expected Obj, but got I
			//IL_0237: Expected Obj, but got I4
			//IL_0248: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got I
			//IL_0073: Expected Obj, but got I4
			//IL_0282: Expected Obj, but got Ref
			//IL_00c1: Expected Obj, but got I4
			//IL_0171: Expected Obj, but got I4
			//IL_0090: Expected Obj, but got Ref
			//IL_00e9: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
			object obj4 = 0;
			bool lockTaken = default;
			Monitor.Enter(obj4, ref lockTaken);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
			object obj7 = 0;
			object obj8 = obj7;
			bool flag3 = obj7 == null;
			OutOfMemoryException ex = null;
			object obj9 = 0;
			int num = (int)(&lockTaken);
			object obj10 = 0;
			if (flag3)
			{
				goto IL_0121;
			}
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v18+1B0]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ X8_v18+1A8] (should have been resolved before IL gen)");
			ex = null;
			obj9 = 0;
			num = maxValue;
			int num2 = default;
			int result = num2;
			goto IL_027a;
			IL_0121:
			NullReferenceException ex2 = new NullReferenceException();
			if (num == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj9 = 1;
			}
			else
			{
				if (num != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					int result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj12 = default;
				ex = (OutOfMemoryException)obj12;
			}
			result = 0;
			goto IL_027a;
			IL_027a:
			object obj13 = (object)(&lockTaken);
			if (obj13 != null)
			{
				object obj15 = default;
				object obj14 = (object)(&obj15);
				Monitor.Exit(obj14);
				num = 0;
			}
			bool flag4 = ex == null;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				bool flag5 = obj9 == null;
				object obj17 = !flag5;
				OutOfMemoryException ex3 = ex;
				if (obj17 == null)
				{
					return result;
				}
			}
			else
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0121;
		}

		static ThreadSafeRandom()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0051: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Random random = default;
			random._002Ector();
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = random;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	internal const int TCP_HEADER_BYTES = default(int);

	internal const int MSG_HEADER_BYTES = default(int);

	public const int ALL_HEADER_BYTES = default(int);

	private Queue<_003CPrivateImplementationDetails_003E.IncomingMessage> incomingList;

	internal Queue<StreamBuffer> outgoingStream;

	private StreamBuffer pendingSendBuffer;

	private int dispatchArrivalTime;

	private int lastPingActivity;

	private readonly ParameterDictionary pingParamDict;

	internal static readonly byte[] tcpFramedMessageHead;

	internal static readonly byte[] tcpMsgHead;

	protected internal bool DoFraming;

	internal override int QueuedIncomingCommandsCount
	{
		get
		{
			//IL_0020: Expected I4, but got Obj
			Queue<_003CPrivateImplementationDetails_003E.IncomingMessage> queue = incomingList;
			if (incomingList != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3 (System.Collections.Generic.Queue`1<<PrivateImplementationDetails>+IncomingMessage>)+20]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	internal override int QueuedOutgoingCommandsCount
	{
		get
		{
			//IL_001d: Expected I4, but got Obj
			Queue<StreamBuffer> queue = outgoingStream;
			if (outgoingStream != null)
			{
				return queue._size;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	internal TPeer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3058]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<_003CPrivateImplementationDetails_003E.IncomingMessage> queue = default;
		queue._002Ector(32);
		object obj5 = this + 288;
		incomingList = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ParameterDictionary parameterDictionary = default;
		parameterDictionary._002Ector();
		object obj6 = this + 320;
		pingParamDict = parameterDictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj4;
		DoFraming = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v10+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector();
	}

	internal override bool IsTransportEncrypted()
	{
		//IL_0010: Expected Obj, but got I4
		object obj = usedTransportProtocol - 5;
		return obj == null;
	}

	internal unsafe override void Reset()
	{
		//IL_0010: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I8
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected I4, but got Unknown
		//IL_00f8: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
		object obj = 0;
		base.Reset();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = ThreadSafeRandom.Next();
		object obj4 = num * 2147549187L;
		object obj5 = obj4 >> 32;
		object obj6 = obj5 + num;
		object obj7 = obj6 >> 14;
		object obj8 = obj7 + obj6;
		object obj9 = obj8 - obj8;
		PhotonPeer photonPeer = base.photonPeer;
		short num2 = (short)(num + obj9);
		peerID = num2;
		if (photonPeer.PayloadEncryptionSecret != null && usedTransportProtocol != (ConnectionProtocol)5)
		{
			((Fusion.Sockets.Stun.StunClient.List.List*)this)->AddLast((Fusion.Sockets.V2.Packet*)(nint)photonPeer.PayloadEncryptionSecret);
		}
		ClearIncomingList();
		TrafficStats stats = Stats;
		int num3 = timeInt;
		stats.LastReceiveTimestamp__BackingField = num3;
	}

	internal unsafe override bool Connect(string serverAddress, string proxyServerAddress, string appID, object photonToken)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_026c: Expected I4, but got Obj
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected I4, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516530]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		string text = (string)obj2;
		Queue<System.__Canon> queue = default;
		queue._002Ector(8);
		object obj4 = this + 296;
		outgoingStream = (Queue<StreamBuffer>)(object)queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj3;
		object obj7;
		if (~(DoFraming ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v30+A0]");
			obj7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v30+A0]");
			obj7 = (nint)0 + (nint)8;
		}
		string text2 = (string)obj7;
		object obj9 = this + 232;
		obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X23_v5-C8]");
		object obj10 = (nint)0 & (nint)0xFE;
		bool flag3 = (nint)obj10 != 4;
		object obj11 = photonToken;
		object obj12 = appID;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			string text3 = PrepareWebSocketUrl(serverAddress, appID, photonToken);
			if (PhotonSocket == null)
			{
				goto IL_025e;
			}
			object obj13 = PhotonSocket + 40;
			obj13 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj11 = null;
			obj12 = photonToken;
			text2 = text3;
			text = appID;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		if (PhotonSocket != null)
		{
			((NetPeerGroup.List*)PhotonSocket)->FreeAll();
			object obj15 = default;
			object obj14 = obj15 & 1;
			if (obj14 != null)
			{
				peerConnectionState = (ConnectionStateValue)1;
				int num = timeInt;
				lastPingActivity = num;
				bool flag4 = (byte)(~(DoFraming ? 1u : 0u)) != 0;
				object obj16 = !flag4;
				if (obj16 != null || PhotonToken != null)
				{
					byte[] initRequestBytes = WriteInitRequest();
					EnqueueInit(initRequestBytes);
				}
			}
			return (byte)(obj15 & 1) != 0;
		}
		goto IL_025e;
		IL_025e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Disconnect()
	{
		//IL_0005: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Photon.Client.TPeer>)+1C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Photon.Client.TPeer>)+1D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	internal unsafe override void Disconnect(bool queueStatusChangeCallback = default(bool))
	{
		//IL_055d: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_05b4: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I4
		//IL_0635: Expected Obj, but got Ref
		//IL_063d: Expected Obj, but got Ref
		//IL_064b: Expected I, but got Obj
		//IL_0233: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got Ref
		//IL_0248: Expected Obj, but got Ref
		//IL_0263: Expected I, but got Obj
		//IL_026b: Expected Obj, but got Ref
		//IL_0134: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_04f9: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_03a5: Expected I, but got Obj
		//IL_03b5: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		ConnectionStateValue connectionStateValue = peerConnectionState;
		object obj = connectionStateValue & (ConnectionStateValue)0xFF;
		if (obj == null)
		{
			return;
		}
		ConnectionStateValue connectionStateValue2 = peerConnectionState;
		object obj2 = connectionStateValue2 & (ConnectionStateValue)0xFF;
		if ((nint)obj2 == 4)
		{
			return;
		}
		LogLevel logLevel = LogLevel;
		object obj3 = logLevel & (LogLevel)0xFF;
		bool flag = (nint)obj3 < 4;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 != null)
		{
			goto IL_057b;
		}
		IPhotonPeerListener listener = Listener;
		bool flag2 = listener == null;
		object obj6 = null;
		bool lockTaken = false;
		ConnectionStateValue connectionStateValue3 = (ConnectionStateValue)0;
		if (flag2)
		{
			goto IL_047e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj7 = 0;
		nint num = (nint)listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170C8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0185;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v22-8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v22-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			obj9 = -1;
			obj7 = obj10 + 16;
			bool flag3 = (nint)obj9 != 1;
			obj10 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_0185;
		}
		obj9 = obj10;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		goto IL_05ff;
		IL_057b:
		peerConnectionState = (ConnectionStateValue)4;
		PhotonPeer photonPeer = base.photonPeer;
		bool flag4 = base.photonPeer == null;
		obj6 = null;
		lockTaken = false;
		nint num2 = unchecked((nint)null);
		connectionStateValue3 = (ConnectionStateValue)4;
		object obj13 = default;
		OutOfMemoryException ex = default;
		object obj14 = default;
		object obj15 = default;
		if (!flag4)
		{
			Monitor.Enter(photonPeer.sendOutgoingLockObject, ref lockTaken);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			bool flag5 = PhotonSocket == null;
			obj9 = (object)(&obj6);
			if (!flag5)
			{
				PhotonSocket photonSocket = PhotonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				bool flag6 = PhotonSocket == null;
				obj13 = 0;
				ex = null;
				obj14 = (object)(&obj6);
				obj15 = (object)(&lockTaken);
				obj6 = photonPeer.sendOutgoingLockObject;
				lockTaken = false;
				num2 = unchecked((nint)null);
				obj9 = (object)(&obj6);
				connectionStateValue3 = (ConnectionStateValue)(byte)(&lockTaken);
				if (flag6)
				{
					goto IL_04a9;
				}
				nint num3 = (nint)photonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v10 (Il2CppClass<Photon.Client.PhotonSocket>)+188]");
				obj9 = 0;
				int count = ((NetPeerGroup.List*)PhotonSocket)->Count;
			}
			ClearOutgoingList();
			peerConnectionState = (ConnectionStateValue)0;
			obj13 = 0;
			ex = null;
			obj14 = (object)(&obj6);
			obj15 = (object)(&lockTaken);
			lockTaken = false;
			num2 = unchecked((nint)null);
			connectionStateValue3 = (ConnectionStateValue)0;
			goto IL_02ae;
		}
		goto IL_047e;
		IL_048c:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_049a;
		IL_047e:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_048c;
		IL_0441:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_067d;
		IL_049a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_04a9;
		IL_02ae:
		if (obj15 != null)
		{
			Monitor.Exit(obj14);
			connectionStateValue3 = (ConnectionStateValue)0;
		}
		bool flag7 = ex == null;
		object obj16 = !flag7;
		if (obj16 != null)
		{
			goto IL_048c;
		}
		bool flag8 = obj13 == null;
		object obj17 = !flag8;
		ex2 = ex;
		if (obj17 != null)
		{
			goto IL_049a;
		}
		ClearIncomingList();
		if (queueStatusChangeCallback)
		{
			EnqueueStatusCallback((StatusCode)1025);
			return;
		}
		IPhotonPeerListener listener2 = Listener;
		bool flag9 = listener2 == null;
		connectionStateValue3 = (ConnectionStateValue)0;
		if (flag9)
		{
			goto IL_047e;
		}
		nint num4 = (nint)listener2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v22 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v22 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0441;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v22 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X10_v14-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj19--;
			obj20 += 16;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_0441;
		}
		object obj21 = obj20 + 2;
		object obj22 = num4 + obj21;
		object obj23 = obj22 + 312;
		goto IL_067d;
		IL_04a9:
		NullReferenceException ex4 = new NullReferenceException();
		if (connectionStateValue3 == (ConnectionStateValue)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj13 = 1;
		}
		else
		{
			if (connectionStateValue3 != (ConnectionStateValue)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj24 = default;
			ex = (OutOfMemoryException)obj24;
		}
		goto IL_02ae;
		IL_067d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v571 @ X0_v44] (should have been resolved before IL gen)");
		return;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_05ff;
		IL_05ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ X0_v53] (should have been resolved before IL gen)");
		goto IL_057b;
	}

	internal unsafe override void SimulateTimeoutDisconnect(bool queueStatusChangeCallback = default(bool))
	{
		//IL_055d: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_05b4: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I4
		//IL_0635: Expected Obj, but got Ref
		//IL_063d: Expected Obj, but got Ref
		//IL_064b: Expected I, but got Obj
		//IL_0233: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got Ref
		//IL_0248: Expected Obj, but got Ref
		//IL_0263: Expected I, but got Obj
		//IL_026b: Expected Obj, but got Ref
		//IL_0134: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_04f9: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_03a5: Expected I, but got Obj
		//IL_03b5: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		ConnectionStateValue connectionStateValue = peerConnectionState;
		object obj = connectionStateValue & (ConnectionStateValue)0xFF;
		if (obj == null)
		{
			return;
		}
		ConnectionStateValue connectionStateValue2 = peerConnectionState;
		object obj2 = connectionStateValue2 & (ConnectionStateValue)0xFF;
		if ((nint)obj2 == 4)
		{
			return;
		}
		LogLevel logLevel = LogLevel;
		object obj3 = logLevel & (LogLevel)0xFF;
		bool flag = (nint)obj3 < 4;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 != null)
		{
			goto IL_057b;
		}
		IPhotonPeerListener listener = Listener;
		bool flag2 = listener == null;
		object obj6 = null;
		bool lockTaken = false;
		ConnectionStateValue connectionStateValue3 = (ConnectionStateValue)0;
		if (flag2)
		{
			goto IL_047e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj7 = 0;
		nint num = (nint)listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170C8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0185;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v22-8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v22-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v27 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			obj9 = -1;
			obj7 = obj10 + 16;
			bool flag3 = (nint)obj9 != 1;
			obj10 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_0185;
		}
		obj9 = obj10;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		goto IL_05ff;
		IL_057b:
		peerConnectionState = (ConnectionStateValue)4;
		PhotonPeer photonPeer = base.photonPeer;
		bool flag4 = base.photonPeer == null;
		obj6 = null;
		lockTaken = false;
		nint num2 = unchecked((nint)null);
		connectionStateValue3 = (ConnectionStateValue)4;
		object obj13 = default;
		OutOfMemoryException ex = default;
		object obj14 = default;
		object obj15 = default;
		if (!flag4)
		{
			Monitor.Enter(photonPeer.sendOutgoingLockObject, ref lockTaken);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			bool flag5 = PhotonSocket == null;
			obj9 = (object)(&obj6);
			if (!flag5)
			{
				PhotonSocket photonSocket = PhotonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				bool flag6 = PhotonSocket == null;
				obj13 = 0;
				ex = null;
				obj14 = (object)(&obj6);
				obj15 = (object)(&lockTaken);
				obj6 = photonPeer.sendOutgoingLockObject;
				lockTaken = false;
				num2 = unchecked((nint)null);
				obj9 = (object)(&obj6);
				connectionStateValue3 = (ConnectionStateValue)(byte)(&lockTaken);
				if (flag6)
				{
					goto IL_04a9;
				}
				nint num3 = (nint)photonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v10 (Il2CppClass<Photon.Client.PhotonSocket>)+188]");
				obj9 = 0;
				int count = ((NetPeerGroup.List*)PhotonSocket)->Count;
			}
			ClearOutgoingList();
			peerConnectionState = (ConnectionStateValue)0;
			obj13 = 0;
			ex = null;
			obj14 = (object)(&obj6);
			obj15 = (object)(&lockTaken);
			lockTaken = false;
			num2 = unchecked((nint)null);
			connectionStateValue3 = (ConnectionStateValue)0;
			goto IL_02ae;
		}
		goto IL_047e;
		IL_048c:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_049a;
		IL_047e:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_048c;
		IL_0441:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_067d;
		IL_049a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_04a9;
		IL_02ae:
		if (obj15 != null)
		{
			Monitor.Exit(obj14);
			connectionStateValue3 = (ConnectionStateValue)0;
		}
		bool flag7 = ex == null;
		object obj16 = !flag7;
		if (obj16 != null)
		{
			goto IL_048c;
		}
		bool flag8 = obj13 == null;
		object obj17 = !flag8;
		ex2 = ex;
		if (obj17 != null)
		{
			goto IL_049a;
		}
		ClearIncomingList();
		if (queueStatusChangeCallback)
		{
			EnqueueStatusCallback((StatusCode)1040);
			return;
		}
		IPhotonPeerListener listener2 = Listener;
		bool flag9 = listener2 == null;
		connectionStateValue3 = (ConnectionStateValue)0;
		if (flag9)
		{
			goto IL_047e;
		}
		nint num4 = (nint)listener2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v22 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v22 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0441;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v22 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X10_v14-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj19--;
			obj20 += 16;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_0441;
		}
		object obj21 = obj20 + 2;
		object obj22 = num4 + obj21;
		object obj23 = obj22 + 312;
		goto IL_067d;
		IL_04a9:
		NullReferenceException ex4 = new NullReferenceException();
		if (connectionStateValue3 == (ConnectionStateValue)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj13 = 1;
		}
		else
		{
			if (connectionStateValue3 != (ConnectionStateValue)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj24 = default;
			ex = (OutOfMemoryException)obj24;
		}
		goto IL_02ae;
		IL_067d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v571 @ X0_v44] (should have been resolved before IL gen)");
		return;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_05ff;
		IL_05ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ X0_v53] (should have been resolved before IL gen)");
		goto IL_057b;
	}

	internal override void FetchServerTimestamp()
	{
		//IL_01c6: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00e3: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		ConnectionStateValue connectionStateValue = peerConnectionState;
		object obj = connectionStateValue & (ConnectionStateValue)0xFF;
		if ((nint)obj == 3 && ~(ApplicationIsInitialized ? 1u : 0u) == 0)
		{
			SendPing(sendImmediately: false);
			serverTimeOffsetIsAvailable = false;
			return;
		}
		LogLevel logLevel = LogLevel;
		object obj2 = logLevel & (LogLevel)0xFF;
		bool flag = (nint)obj2 < 3;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			return;
		}
		IPhotonPeerListener listener = Listener;
		ConnectionStateValue connectionStateValue2 = peerConnectionState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161E8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170D8]");
		object format = 0;
		object arg = default;
		string text = string.Format((string)format, arg);
		nint num = (nint)listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v13 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v13 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_017f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v13 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v8-8]");
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
			goto IL_017f;
		}
		object obj9 = num + obj8;
		object obj10 = obj9 + 312;
		goto IL_020b;
		IL_017f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_020b;
		IL_020b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X0_v16] (should have been resolved before IL gen)");
	}

	private void EnqueueInit(byte[] initRequestBytes)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I4
		if (initRequestBytes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			int size = initRequestBytes.Length + 32;
			StreamBuffer streamBuffer = default;
			streamBuffer._002Ector(size);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			byte[] array = default;
			if (array != null)
			{
				bool flag = array.Length < 6;
				object obj3 = !flag;
				object obj4 = array.Length - 6;
				bool flag2 = obj4 == null;
				array[0] = 251;
				object obj5 = ~obj3;
				object obj6 = obj5 | flag2;
				if (obj6 != null)
				{
					goto IL_01ef;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
				object obj7 = 0;
				array[6] = 1;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int value = initRequestBytes.Length + array.Length;
				int targetOffset = default;
				MessageProtocol.Serialize(value, array, ref targetOffset);
				if (streamBuffer != null)
				{
					streamBuffer.Write(array, 0, array.Length);
					streamBuffer.Write(initRequestBytes, 0, initRequestBytes.Length);
					bool flag4 = EnqueueMessageAsPayload((DeliveryMode)1, streamBuffer, 0);
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01ef;
		IL_01ef:
		throw new IndexOutOfRangeException();
	}

	private unsafe void ClearIncomingList()
	{
		//IL_0281: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I4
		//IL_02a3: Expected VT, but got Ref
		//IL_002d: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got Ref
		//IL_0105: Invalid comparison between VT and I4
		//IL_01f8: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_0151: Invalid comparison between VT and I4
		//IL_01c7: Expected Obj, but got Ref
		//IL_01d9: Expected VT, but got I4
		//IL_02b8: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(incomingList, ref lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516210]");
		object obj2 = 0;
		object obj3 = 0;
		_003CPrivateImplementationDetails_003E.IncomingMessage incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)(&lockTaken);
		object obj8 = default;
		object obj11 = default;
		NullReferenceException ex7 = default;
		while (true)
		{
			Queue<_003CPrivateImplementationDetails_003E.IncomingMessage> queue = incomingList;
			OutOfMemoryException ex;
			object obj4;
			if (incomingList != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v29 (System.Collections.Generic.Queue`1<<PrivateImplementationDetails>+IncomingMessage>)+20]");
				bool flag = (nint)0 <= (nint)0;
				ex = null;
				obj4 = 0;
				if (flag)
				{
					goto IL_019a;
				}
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					queue = incomingList;
					if (incomingList == null)
					{
						goto IL_00ee;
					}
					obj5 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v19+A0]");
				object obj7 = 0;
				_003CPrivateImplementationDetails_003E.IncomingMessage incomingMessage2 = queue.Dequeue();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v20+8]");
				bool flag3 = (nint)0 == 0;
				incomingMessage = incomingMessage2;
				if (!flag3)
				{
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
					incomingMessage = incomingMessage2;
					continue;
				}
			}
			else
			{
				NullReferenceException ex2 = new NullReferenceException();
			}
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_00ee;
			IL_00ee:
			NullReferenceException ex4 = new NullReferenceException();
			NullReferenceException ex5;
			if (incomingMessage == (_003CPrivateImplementationDetails_003E.IncomingMessage)(object)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = null;
				obj4 = 1;
			}
			else
			{
				bool flag4 = incomingMessage != (_003CPrivateImplementationDetails_003E.IncomingMessage)(object)1;
				ex5 = ex4;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (OutOfMemoryException)obj8;
				obj4 = 0;
			}
			goto IL_019a;
			IL_019a:
			object obj9 = (object)(&lockTaken);
			if (obj9 != null)
			{
				object obj10 = (object)(&obj11);
				Monitor.Exit(obj10);
				incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
			}
			bool flag5 = ex == null;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				bool flag6 = obj4 == null;
				object obj13 = !flag6;
				OutOfMemoryException ex6 = ex;
				if (obj13 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex6 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			ex5 = ex7;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private unsafe void ClearOutgoingList()
	{
		//IL_019f: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got Ref
		//IL_007a: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got Ref
		//IL_005b: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(outgoingStream, ref lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170D0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X9_v2+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726C04");
		OutOfMemoryException ex = null;
		object obj7 = 0;
		object obj10 = default;
		object obj14 = default;
		while (true)
		{
			object obj8 = (object)(&lockTaken);
			if (obj8 != null)
			{
				object obj9 = (object)(&obj10);
				Monitor.Exit(obj9);
				obj6 = 0;
			}
			bool flag2 = ex == null;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				bool flag3 = obj7 == null;
				object obj12 = !flag3;
				OutOfMemoryException ex2 = ex;
				if (obj12 == null)
				{
					object obj13 = this + 304;
					pendingSendBuffer = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj6 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj7 = 1;
				continue;
			}
			if ((nint)obj6 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex = (OutOfMemoryException)obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	internal unsafe override bool DispatchIncomingCommands()
	{
		//IL_07e9: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got Ref
		//IL_0325: Expected Obj, but got I4
		//IL_004e: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		//IL_0811: Expected Obj, but got Ref
		//IL_0137: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got Ref
		//IL_01cf: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_017a: Expected Obj, but got Ref
		//IL_0188: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_00e4: Expected I, but got Obj
		//IL_076b: Expected Obj, but got I4
		//IL_07ba: Expected Obj, but got I4
		//IL_07cc: Expected VT, but got I4
		//IL_0557: Expected Obj, but got I4
		//IL_0538: Expected I, but got Obj
		//IL_057f: Expected Obj, but got I4
		//IL_05f0: Invalid comparison between VT and I4
		//IL_05cc: Expected Obj, but got I4
		//IL_060c: Expected I, but got Obj
		//IL_063f: Expected Obj, but got I
		//IL_064c: Expected I, but got VT
		//IL_065c: Expected Obj, but got I
		//IL_0686: Expected Obj, but got I4
		//IL_08bd: Expected Obj, but got I
		//IL_08dc: Expected I, but got VT
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected I4, but got Unknown
		//IL_06bb: Expected Obj, but got I
		ConnectionStateValue connectionStateValue = peerConnectionState;
		object obj = connectionStateValue & (ConnectionStateValue)0xFF;
		bool lockTaken = default;
		object obj2 = default;
		Fusion.Sockets.V2.Packet* ptr;
		TPeer tPeer;
		object obj3;
		bool flag2;
		if ((nint)obj == 3)
		{
			int num = timeInt;
			TrafficStats stats = Stats;
			bool flag = stats == null;
			lockTaken = false;
			obj2 = null;
			obj3 = null;
			flag2 = false;
			ptr = (Fusion.Sockets.V2.Packet*)unchecked((nint)null);
			tPeer = this;
			if (flag)
			{
				goto IL_06f9;
			}
			int disconnectTimeout = DisconnectTimeout;
			object obj4 = num - stats.LastReceiveTimestamp__BackingField;
			if ((nint)obj4 > disconnectTimeout)
			{
				EnqueueStatusCallback((StatusCode)1040);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517100]");
				object obj6 = 0;
				MyAction myAction = default;
				myAction._002Ector(this, (IntPtr)obj6);
				EnqueueActionForDispatch(myAction);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65162E0]");
		object obj7 = 0;
		System.__Canon _Canon = null;
		Monitor.Enter(ActionQueue, ref lockTaken);
		Queue<System.__Canon> actionQueue = (Queue<System.__Canon>)(object)ActionQueue;
		object obj11 = default;
		OutOfMemoryException ex = default;
		object obj12 = default;
		object obj13;
		if ((object)ActionQueue != null)
		{
			if (actionQueue._size >= 1)
			{
				ptr = (Fusion.Sockets.V2.Packet*)(nint)obj7;
				System.__Canon _Canon2 = ((Queue<System.__Canon>)(object)ActionQueue).Dequeue();
				_Canon = _Canon2;
				object obj8 = 9;
			}
			else
			{
				ptr = (Fusion.Sockets.V2.Packet*)(&lockTaken);
				object obj8 = 8;
			}
			object obj9 = (object)(&lockTaken);
			if (obj9 != null)
			{
				object obj10 = (object)(&obj2);
				Monitor.Exit(obj10);
				ptr = (Fusion.Sockets.V2.Packet*)unchecked((nint)null);
			}
			lockTaken = false;
			obj2 = ActionQueue;
			obj11 = 0;
			ex = null;
			obj12 = (object)(&obj2);
			obj3 = null;
			flag2 = false;
			obj13 = 0;
			tPeer = this;
			goto IL_06dc;
		}
		NullReferenceException ex2 = new NullReferenceException();
		lockTaken = false;
		obj2 = ActionQueue;
		obj11 = 0;
		ex = null;
		obj12 = (object)(&obj2);
		obj3 = null;
		flag2 = false;
		obj13 = 0;
		ptr = (Fusion.Sockets.V2.Packet*)(&lockTaken);
		tPeer = this;
		goto IL_0866;
		IL_06f9:
		NullReferenceException ex3 = new NullReferenceException();
		ex2 = new NullReferenceException();
		goto IL_0866;
		IL_06ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_06f9;
		IL_06dc:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_06ea;
		IL_089a:
		TPeer tPeer2;
		return (byte)(tPeer2 & 1) != 0;
		IL_0866:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		NullReferenceException ex5 = ex2;
		object obj14 = default;
		NullReferenceException ex6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			if (ptr == (Fusion.Sockets.V2.Packet*)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj11 = 1;
				break;
			}
			if (ptr == (Fusion.Sockets.V2.Packet*)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (OutOfMemoryException)obj14;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
			ex5 = ex6;
		}
		object obj15 = 0;
		int num2 = 0;
		_003CPrivateImplementationDetails_003E.IncomingMessage incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
		object obj16 = default;
		if (obj16 != null)
		{
			Monitor.Exit(obj12);
			ptr = (Fusion.Sockets.V2.Packet*)unchecked((nint)null);
		}
		bool flag3 = ex == null;
		object obj17 = !flag3;
		if (obj17 != null)
		{
			goto IL_06dc;
		}
		bool flag4 = obj11 == null;
		object obj18 = !flag4;
		ex4 = ex;
		if (obj18 != null)
		{
			goto IL_06ea;
		}
		if ((nint)obj15 != 12)
		{
			bool flag5 = obj15 == null;
			object obj19 = !flag5;
			if (obj19 != null)
			{
				tPeer2 = null;
				goto IL_089a;
			}
		}
		tPeer.dispatchArrivalTime = num2;
		if (incomingMessage != (_003CPrivateImplementationDetails_003E.IncomingMessage)(object)0)
		{
			nint num3 = (nint)tPeer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X20_v4 (<PrivateImplementationDetails>+IncomingMessage)+14]");
			int byteCountCurrentDispatch = (int)((nint)0 + (nint)3);
			tPeer.ByteCountCurrentDispatch = byteCountCurrentDispatch;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X9_v3 (Il2CppClass<Photon.Client.TPeer>)+260]");
			obj13 = 0;
			((Fusion.Sockets.Stun.StunClient.List.List*)tPeer)->AddFirst((Fusion.Sockets.V2.Packet*)(nint)incomingMessage);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v14+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v15+8]");
			bool flag7 = (nint)0 == 0;
			ptr = (Fusion.Sockets.V2.Packet*)(nint)incomingMessage;
			TPeer tPeer3 = default;
			tPeer = tPeer3;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516210]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
				tPeer2 = tPeer3;
				goto IL_089a;
			}
		}
		goto IL_06f9;
	}

	internal unsafe override bool SendOutgoingCommands()
	{
		//IL_09aa: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_0942: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I4
		//IL_05e7: Expected Obj, but got I4
		//IL_05f0: Expected Obj, but got I4
		//IL_05f8: Expected Obj, but got Ref
		//IL_0604: Expected Obj, but got Ref
		//IL_084a: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got Ref
		//IL_082b: Expected Obj, but got I4
		//IL_09cf: Expected Obj, but got Ref
		//IL_01d9: Expected Obj, but got I
		//IL_0877: Expected I4, but got Obj
		//IL_0265: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got Ref
		//IL_0224: Expected Obj, but got Ref
		//IL_0236: Expected Obj, but got I4
		ConnectionStateValue connectionStateValue = peerConnectionState;
		object obj = connectionStateValue & (ConnectionStateValue)0xFF;
		if (obj == null)
		{
			goto IL_08a6;
		}
		PhotonSocket photonSocket = PhotonSocket;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		bool flag = PhotonSocket == null;
		bool lockTaken = false;
		object obj2 = null;
		object obj3 = null;
		bool flag2 = false;
		object obj4 = 0;
		object obj14 = default;
		object obj15 = default;
		object obj16 = default;
		NullReferenceException ex;
		object obj12;
		bool flag4;
		if (!flag)
		{
			if (!PhotonSocket.Connected)
			{
				goto IL_08a6;
			}
			TrafficStats stats = Stats;
			int num = timeInt;
			bool flag3 = stats == null;
			lockTaken = false;
			obj2 = null;
			obj3 = null;
			flag2 = false;
			obj4 = 0;
			photonSocket = (PhotonSocket)(object)stats;
			if (!flag3)
			{
				int num2 = timeInt;
				timeIntCurrentSend = num2;
				int num3 = timeInt;
				int pingInterval = PingInterval;
				object obj5 = num3 - lastPingActivity;
				if ((nint)obj5 > pingInterval)
				{
					SendPing(sendImmediately: false);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517108]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
				object obj7 = 0;
				obj3 = null;
				flag2 = false;
				object obj8 = 0;
				PhotonSocketError photonSocketError = (PhotonSocketError)lastPingActivity;
				photonSocket = null;
				Monitor.Enter(outgoingStream, ref lockTaken);
				Queue<System.__Canon> queue = (Queue<System.__Canon>)(object)outgoingStream;
				object obj13;
				if (outgoingStream != null)
				{
					if (queue._size != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517110]");
						object obj9 = 0;
						obj4 = obj9;
						System.__Canon _Canon = ((Queue<System.__Canon>)(object)outgoingStream).Peek();
						photonSocketError = (PhotonSocketError)10;
						photonSocket = (PhotonSocket)(object)_Canon;
					}
					else
					{
						photonSocketError = (PhotonSocketError)9;
						obj4 = (object)(&lockTaken);
					}
					object obj10 = (object)(&lockTaken);
					if (obj10 != null)
					{
						object obj11 = (object)(&obj2);
						Monitor.Exit(obj11);
						obj4 = 0;
					}
					lockTaken = false;
					obj2 = outgoingStream;
					obj12 = null;
					flag4 = false;
					obj13 = 0;
					obj14 = 0;
					obj15 = 0;
					obj16 = (object)(&obj2);
					goto IL_08d0;
				}
				ex = new NullReferenceException();
				lockTaken = false;
				obj2 = outgoingStream;
				obj12 = null;
				flag4 = false;
				obj13 = 0;
				obj14 = 0;
				obj15 = 0;
				obj16 = (object)(&obj2);
				obj4 = (object)(&lockTaken);
				goto IL_0aae;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj12 = null;
		flag4 = false;
		goto IL_08d0;
		IL_0aea:
		bool result;
		return result;
		IL_0aae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		NullReferenceException ex3 = ex;
		object obj17 = default;
		NullReferenceException ex4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			if ((nint)obj4 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj14 = 1;
				break;
			}
			if ((nint)obj4 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj15 = obj17;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
			ex3 = ex4;
		}
		TPeer tPeer = null;
		object obj18 = default;
		if (obj18 != null)
		{
			Monitor.Exit(obj16);
			obj4 = 0;
		}
		bool flag5 = obj15 == null;
		object obj19 = !flag5;
		if (obj19 != null)
		{
			goto IL_08d0;
		}
		bool flag6 = obj14 == null;
		object obj20 = obj15;
		result = (byte)(int)tPeer != 0;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			int num4 = tPeer.mtu;
			goto IL_08a6;
		}
		goto IL_0aea;
		IL_08a6:
		result = false;
		goto IL_0aea;
		IL_08d0:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		ex = new NullReferenceException();
		goto IL_0aae;
	}

	internal override bool SendAcksOnly()
	{
		//IL_0121: Expected I4, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		if (PhotonSocket != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			if (PhotonSocket == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			if (PhotonSocket.Connected)
			{
				ConnectionStateValue connectionStateValue = peerConnectionState;
				object obj = connectionStateValue & (ConnectionStateValue)0xFF;
				if ((nint)obj == 3)
				{
					int num = timeInt;
					int pingInterval = PingInterval;
					object obj2 = num - lastPingActivity;
					if ((nint)obj2 > pingInterval)
					{
						SendPing(sendImmediately: true);
					}
				}
			}
		}
		return false;
	}

	internal override bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams)
	{
		//IL_000e: Expected I4, but got VT
		//IL_0020: Expected I4, but got VT
		byte channelId = (byte)(sendParams >> 40);
		return EnqueueMessageAsPayload((DeliveryMode)sendParams, opBytes, channelId);
	}

	internal unsafe bool EnqueueMessageAsPayload(DeliveryMode deliveryMode, StreamBuffer opMessage, byte channelId)
	{
		//IL_021b: Expected Obj, but got I4
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected I4, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got Ref
		//IL_0040: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I4
		//IL_0364: Expected Obj, but got Ref
		//IL_037b: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got Ref
		//IL_03ba: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0396: Expected Obj, but got I4
		//IL_048c: Expected Obj, but got Ref
		//IL_03e2: Expected Obj, but got I4
		//IL_0460: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got Ref
		//IL_042f: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got Ref
		//IL_0690: Expected I4, but got Obj
		//IL_02da: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_0583: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I4
		int targetOffset;
		byte[] array;
		bool lockTaken = default;
		object obj4 = default;
		int num = default;
		NullReferenceException ex = default;
		object obj11 = default;
		object obj13 = default;
		System.__Canon _Canon;
		TPeer tPeer;
		object obj14;
		StreamBuffer streamBuffer;
		byte[] array2;
		object obj5;
		if (opMessage != null)
		{
			bool flag = (byte)(~(DoFraming ? 1u : 0u)) != 0;
			targetOffset = 0;
			array = (byte[])109924352;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
				object obj = 0;
				array = opMessage.buf;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v49+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				MessageProtocol.Serialize(opMessage.len, array, ref targetOffset);
				bool flag3 = array == null;
				lockTaken = false;
				obj4 = null;
				array2 = array;
				obj5 = (object)(&targetOffset);
				targetOffset = 1;
				if (flag3)
				{
					goto IL_04c6;
				}
				bool flag4 = array.Length < 5;
				object obj6 = !flag4;
				object obj7 = array.Length - 5;
				bool flag5 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag5;
				if (obj9 != null)
				{
					goto IL_0465;
				}
				byte b = default;
				array[5] = b;
				object obj10;
				if (deliveryMode <= (DeliveryMode)1)
				{
					if (deliveryMode != 0)
					{
						bool flag6 = deliveryMode != (DeliveryMode)1;
						lockTaken = false;
						obj4 = null;
						array2 = array;
						obj5 = (object)(&targetOffset);
						targetOffset = 1;
						if (flag6)
						{
							goto IL_04d1;
						}
						if (array.Length == 6)
						{
							goto IL_0465;
						}
						obj10 = 1;
					}
					else
					{
						if (array.Length == 6)
						{
							goto IL_0465;
						}
						obj10 = 0;
					}
				}
				else if (deliveryMode != (DeliveryMode)2)
				{
					bool flag7 = deliveryMode != (DeliveryMode)3;
					lockTaken = false;
					obj4 = null;
					array2 = array;
					obj5 = (object)(&targetOffset);
					targetOffset = 1;
					if (flag7)
					{
						goto IL_04d1;
					}
					if (array.Length == 6)
					{
						goto IL_0465;
					}
					obj10 = 3;
				}
				else
				{
					if (array.Length == 6)
					{
						goto IL_0465;
					}
					obj10 = 2;
				}
				array[6] = (byte)(int)obj10;
				targetOffset = 1;
			}
			Monitor.Enter(outgoingStream, ref lockTaken);
			bool flag8 = outgoingStream == null;
			num = (int)(&obj4);
			lockTaken = false;
			obj4 = outgoingStream;
			ex = null;
			obj11 = 0;
			array2 = (byte[])(&lockTaken);
			obj5 = null;
			if (flag8)
			{
				goto IL_04a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170E0]");
			object obj12 = 0;
			obj5 = obj12;
			((Queue<System.__Canon>)(object)outgoingStream).Enqueue((System.__Canon)(object)opMessage);
			num = (int)(&obj4);
			lockTaken = false;
			obj4 = outgoingStream;
			ex = null;
			obj11 = 0;
			obj13 = (object)(&lockTaken);
			_Canon = (System.__Canon)(object)opMessage;
			tPeer = this;
			obj14 = 14;
			streamBuffer = opMessage;
			goto IL_06d4;
		}
		object obj15 = 0;
		goto IL_069e;
		IL_069e:
		return (byte)(obj15 & 1) != 0;
		IL_06d4:
		bool flag9 = obj13 == null;
		array2 = (byte[])(object)_Canon;
		if (!flag9)
		{
			Monitor.Exit(((int*)num)->m_value);
			array2 = null;
		}
		bool flag10 = ex == null;
		object obj16 = !flag10;
		if (obj16 != null)
		{
			goto IL_049b;
		}
		bool flag11 = obj11 == null;
		object obj17 = !flag11;
		NullReferenceException ex2 = ex;
		if (obj17 != null)
		{
			goto IL_04b7;
		}
		if ((nint)obj14 != 14)
		{
			bool flag12 = obj14 == null;
			object obj18 = !flag12;
			obj15 = obj11;
			if (obj18 != null)
			{
				goto IL_069e;
			}
		}
		tPeer.ByteCountLastOperation = streamBuffer.len;
		obj15 = 1;
		goto IL_069e;
		IL_04a9:
		ex2 = new NullReferenceException();
		goto IL_04b7;
		IL_04d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		TPeer tPeer2 = default;
		string paramName = default;
		StreamBuffer streamBuffer2 = default;
		((ArgumentOutOfRangeException)(object)tPeer2)._002Ector(paramName, (object)streamBuffer2, (string)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex3 = new ArgumentNullException();
		System.__Canon _Canon2 = default;
		if ((nint)_Canon2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj11 = 1;
		}
		else
		{
			if ((nint)_Canon2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj19 = default;
			ex = (NullReferenceException)obj19;
		}
		_Canon = _Canon2;
		obj5 = streamBuffer2;
		tPeer = tPeer2;
		obj14 = 0;
		streamBuffer = streamBuffer2;
		goto IL_06d4;
		IL_0465:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		lockTaken = false;
		obj4 = null;
		array2 = array;
		obj5 = (object)(&targetOffset);
		targetOffset = 1;
		goto IL_049b;
		IL_049b:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_04a9;
		IL_04c6:
		throw new NullReferenceException();
		IL_04b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_04c6;
	}

	internal unsafe void SendPing(bool sendImmediately = default(bool))
	{
		//IL_07d1: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I
		//IL_080e: Expected Obj, but got I
		//IL_055e: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got Ref
		//IL_0586: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_006c: Expected I4, but got Obj
		//IL_05ca: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I4
		//IL_08ae: Expected Obj, but got I
		//IL_0903: Expected Obj, but got I4
		//IL_0918: Expected Obj, but got Ref
		//IL_0930: Expected I, but got Obj
		//IL_0943: Expected Obj, but got I4
		//IL_0767: Expected Obj, but got I4
		//IL_064f: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		//IL_0677: Expected Obj, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got Ref
		//IL_0397: Expected I, but got Obj
		//IL_03be: Expected Obj, but got I
		//IL_03c6: Expected I, but got Obj
		//IL_03dd: Expected Obj, but got Ref
		//IL_03f4: Expected I4, but got Obj
		//IL_042f: Expected Obj, but got I4
		//IL_0444: Expected Obj, but got Ref
		//IL_02fd: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I
		//IL_0890: Expected I4, but got Obj
		//IL_0332: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj = 0;
		int num = (lastPingActivity = timeInt);
		object obj5;
		bool lockTaken;
		object obj6;
		bool lockTaken2;
		int targetOffset;
		int num2;
		StreamBuffer streamBuffer2;
		object obj14 = default;
		OutOfMemoryException ex = default;
		int num5 = default;
		object obj15 = default;
		byte b;
		object obj20;
		nint num3;
		if (~(DoFraming ? 1u : 0u) == 0)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v57+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v57+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v40+8]");
			bool flag2 = (nint)0 == 0;
			obj5 = null;
			lockTaken = false;
			obj6 = null;
			lockTaken2 = false;
			targetOffset = 0;
			num2 = 0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516208]");
				object obj7 = 0;
				num2 = (int)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
				StreamBuffer streamBuffer = default;
				bool flag3 = streamBuffer == null;
				obj5 = null;
				lockTaken = false;
				obj6 = null;
				lockTaken2 = false;
				targetOffset = 0;
				if (!flag3)
				{
					num2 = (streamBuffer.pos += 5);
					if (streamBuffer.len < num2)
					{
						streamBuffer.len = num2;
						bool flag4 = streamBuffer.CheckSize(num2);
					}
					byte[] buf = streamBuffer.buf;
					bool flag5 = streamBuffer.buf == null;
					obj5 = null;
					lockTaken = false;
					obj6 = null;
					lockTaken2 = false;
					targetOffset = streamBuffer.pos;
					if (!flag5)
					{
						bool flag6 = streamBuffer.pos < buf.Length;
						object obj8 = !flag6;
						obj5 = null;
						lockTaken = false;
						obj6 = null;
						lockTaken2 = false;
						targetOffset = streamBuffer.pos;
						if (obj8 == null)
						{
							object obj9 = streamBuffer.buf + streamBuffer.pos;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
							object obj10 = 0;
							_ = 240;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v61+E4]");
							bool flag7 = (nint)0 == 0;
							object obj12 = !flag7;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							MessageProtocol.Serialize(num, streamBuffer.buf, ref targetOffset);
							obj5 = null;
							lockTaken = false;
							obj6 = null;
							lockTaken2 = false;
							num3 = (nint)(&targetOffset);
							streamBuffer2 = streamBuffer;
							goto IL_028b;
						}
						goto IL_06f3;
					}
				}
			}
		}
		else
		{
			PhotonPeer photonPeer = base.photonPeer;
			bool flag8 = base.photonPeer == null;
			obj5 = null;
			lockTaken = false;
			obj6 = null;
			lockTaken2 = false;
			targetOffset = 0;
			num2 = 0;
			if (!flag8)
			{
				Monitor.Enter(photonPeer.enqueueLock, ref lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				bool flag9 = pingParamDict == null;
				int num4 = num;
				obj5 = photonPeer.enqueueLock;
				lockTaken = false;
				obj14 = 0;
				ex = null;
				num5 = (int)(&obj5);
				obj15 = (object)(&lockTaken);
				obj6 = null;
				lockTaken2 = false;
				num3 = unchecked((nint)null);
				targetOffset = 0;
				b = (byte)(&num4);
				if (flag9)
				{
					goto IL_0717;
				}
				object value = default;
				pingParamDict.set_Item((byte)1, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164B8]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v38+E4]");
				bool flag10 = (nint)0 == 0;
				object obj18 = !flag10;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v38+A0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v25+4]");
				b = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v25+4]");
				StreamBuffer streamBuffer3 = SerializeOperationToMessage(0, pingParamDict, (EgMessageType)6, encrypt: false);
				obj5 = photonPeer.enqueueLock;
				lockTaken = false;
				obj14 = 0;
				ex = null;
				num5 = (int)(&obj5);
				obj15 = (object)(&lockTaken);
				obj6 = null;
				lockTaken2 = false;
				num3 = (nint)pingParamDict;
				targetOffset = 0;
				obj20 = 3;
				streamBuffer2 = streamBuffer3;
				goto IL_0973;
			}
		}
		goto IL_06c8;
		IL_0717:
		NullReferenceException ex2 = new NullReferenceException();
		if (b == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj14 = 1;
		}
		else
		{
			if (b != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj21 = default;
			ex = (OutOfMemoryException)obj21;
		}
		obj20 = 0;
		streamBuffer2 = null;
		goto IL_0973;
		IL_06e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_06f3;
		IL_06c8:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_06d6;
		IL_0701:
		NullReferenceException ex4 = new NullReferenceException();
		b = (byte)num2;
		goto IL_0717;
		IL_0973:
		bool flag11 = obj15 == null;
		num2 = b;
		if (!flag11)
		{
			Monitor.Exit(((int*)num5)->m_value);
			num2 = 0;
		}
		bool flag12 = ex == null;
		object obj22 = !flag12;
		if (obj22 != null)
		{
			goto IL_06d6;
		}
		bool flag13 = obj14 == null;
		object obj23 = !flag13;
		OutOfMemoryException ex5 = ex;
		if (obj23 == null)
		{
			if (obj20 != null && (nint)obj20 != 3)
			{
				return;
			}
			goto IL_028b;
		}
		goto IL_06e4;
		IL_028b:
		if (sendImmediately)
		{
			PhotonSocketError photonSocketError = SendBuffer(streamBuffer2);
			if (photonSocketError != (PhotonSocketError)5)
			{
				object obj24 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v52+E4]");
				bool flag14 = (nint)0 == 0;
				object obj25 = !flag14;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj24 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v52+A0]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v36+8]");
				bool flag15 = (nint)0 == 0;
				num2 = (int)streamBuffer2;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516210]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
					return;
				}
				goto IL_06c8;
			}
			return;
		}
		Monitor.Enter(outgoingStream, ref lockTaken2);
		bool flag16 = outgoingStream == null;
		obj14 = 0;
		ex = null;
		num5 = (int)(&obj6);
		obj15 = (object)(&lockTaken2);
		obj6 = outgoingStream;
		lockTaken2 = false;
		num3 = unchecked((nint)null);
		num2 = (int)(&lockTaken2);
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65170E0]");
			object obj28 = 0;
			num3 = (nint)obj28;
			((Queue<System.__Canon>)(object)outgoingStream).Enqueue((System.__Canon)(object)streamBuffer2);
			object obj29 = (object)(&lockTaken2);
			bool flag17 = obj29 == null;
			num2 = (int)streamBuffer2;
			if (!flag17)
			{
				int num6 = (int)(&obj6);
				Monitor.Exit(((int*)num6)->m_value);
				num2 = 0;
			}
			obj14 = 0;
			ex = null;
			num5 = (int)(&obj6);
			obj15 = (object)(&lockTaken2);
			obj6 = outgoingStream;
			lockTaken2 = false;
			goto IL_06d6;
		}
		goto IL_0701;
		IL_06d6:
		ex5 = new OutOfMemoryException();
		goto IL_06e4;
		IL_06f3:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_0701;
	}

	private PhotonSocketError SendBuffer(StreamBuffer msg)
	{
		//IL_018b: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0109: Expected I4, but got Obj
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		PhotonSocketError photonSocketError;
		if (msg != null)
		{
			int len = msg.len;
			photonSocketError = SendData(msg.buf, msg.len);
			if (photonSocketError != (PhotonSocketError)5)
			{
				bool flag = photonSocketError == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0178;
				}
			}
			if (pendingSendBuffer != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v12+A0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8+8]");
				if ((nint)0 == 0)
				{
					goto IL_017d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516210]");
				object obj6 = 0;
				len = (int)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
				object obj7 = this + 304;
				pendingSendBuffer = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			if (photonSocketError == (PhotonSocketError)5)
			{
				object obj8 = this + 304;
				pendingSendBuffer = msg;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			goto IL_0178;
		}
		goto IL_017d;
		IL_017d:
		NullReferenceException ex = new NullReferenceException();
		return (PhotonSocketError)ex;
		IL_0178:
		return photonSocketError;
	}

	internal unsafe PhotonSocketError SendData(byte[] data, int length)
	{
		//IL_004f: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I4
		//IL_00b7: Expected I, but got Obj
		//IL_04f1: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_045a: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I4
		NetworkSimulationSet networkSimulationSet = NetworkSimulationSettings;
		PhotonSocketError result;
		object obj3;
		int num3;
		if (networkSimulationSet != null)
		{
			bool isSimulationEnabled = networkSimulationSet.IsSimulationEnabled;
			bool flag = !isSimulationEnabled;
			nint num2 = default;
			int num = (int)num2;
			num3 = length;
			TrafficStats stats2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Array array = default;
				Buffer.BlockCopy(data, 0, array, 0, length);
				SendNetworkSimulated((byte[])array);
				TrafficStats stats = Stats;
				bool flag2 = stats == null;
				object obj2 = 0;
				int num4 = length;
				num2 = unchecked((nint)null);
				num3 = 0;
				obj3 = null;
				if (flag2)
				{
					goto IL_02ed;
				}
				long num5 = ((TrafficStatsBase)stats).BytesOut__BackingField + length;
				((TrafficStatsBase)stats).BytesOut__BackingField = num5;
				stats2 = Stats;
				bool flag3 = stats2 == null;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					obj2 = 0;
					num4 = length;
					num = 0;
					num3 = 0;
					throw new NullReferenceException();
				}
			}
			else
			{
				int num6 = timeInt;
				PhotonSocket photonSocket = PhotonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				bool flag4 = PhotonSocket == null;
				num2 = num;
				obj3 = null;
				if (flag4)
				{
					goto IL_02df;
				}
				nint num7 = (nint)photonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v16 (Il2CppClass<Photon.Client.PhotonSocket>)+1A0]");
				num2 = 0;
				bool isEmpty = ((NetPeerGroup.List*)PhotonSocket)->IsEmpty;
				int num8 = timeInt;
				int num9 = num8 - num6;
				if (num9 > longestSendCall)
				{
					longestSendCall = num9;
				}
				bool flag5 = !isEmpty;
				object obj5 = !flag5;
				result = (isEmpty ? ((PhotonSocketError)1) : ((PhotonSocketError)0));
				if (obj5 != null)
				{
					goto IL_052f;
				}
				TrafficStats stats3 = Stats;
				bool flag6 = stats3 == null;
				num3 = length;
				obj3 = null;
				if (flag6)
				{
					goto IL_02fb;
				}
				long num10 = ((TrafficStatsBase)stats3).BytesOut__BackingField + length;
				((TrafficStatsBase)stats3).BytesOut__BackingField = num10;
				stats2 = Stats;
				bool flag7 = stats2 == null;
				num3 = length;
				obj3 = null;
				if (flag7)
				{
					goto IL_0309;
				}
			}
			int num11 = ((TrafficStatsBase)stats2).PackagesOut__BackingField + 1;
			((TrafficStatsBase)stats2).PackagesOut__BackingField = num11;
			result = (PhotonSocketError)0;
			goto IL_052f;
		}
		NullReferenceException ex = new NullReferenceException();
		num3 = length;
		obj3 = null;
		goto IL_02df;
		IL_0492:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		PhotonSocketError result2 = default;
		return result2;
		IL_0472:
		NullReferenceException ex2 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		NullReferenceException ex3 = ex2;
		goto IL_0492;
		IL_02fb:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0309;
		IL_02df:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_02ed;
		IL_02ed:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_02fb;
		IL_052f:
		return result;
		IL_0309:
		NullReferenceException ex7 = new NullReferenceException();
		bool flag8 = (nint)obj3 != 1;
		ex3 = ex7;
		if (flag8)
		{
			goto IL_0492;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		object obj7 = default;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
		object obj9 = default;
		object obj8 = obj9 & 1;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			LogLevel logLevel = LogLevel;
			object obj10 = logLevel & (LogLevel)0xFF;
			bool flag9 = obj10 == null;
			result = (PhotonSocketError)0;
			if (!flag9)
			{
				IPhotonPeerListener listener = Listener;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				string text = string.Format(format, obj7);
				bool flag10 = listener == null;
				num3 = 0;
				obj3 = obj7;
				if (flag10)
				{
					goto IL_0472;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
				result = (PhotonSocketError)0;
			}
			goto IL_052f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
		object obj11 = obj7;
		obj3 = 101789696 + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
		num3 = 0;
		goto IL_0472;
	}

	internal unsafe override void ReceiveIncomingCommands(byte[] inbuff, int dataLength)
	{
		//IL_06ca: Expected VT, but got I4
		//IL_049c: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		//IL_04c9: Expected Obj, but got I
		//IL_006b: Expected VT, but got I4
		//IL_05e5: Expected VT, but got I4
		//IL_00a8: Expected VT, but got I4
		//IL_00f7: Expected VT, but got I4
		//IL_061d: Invalid comparison between VT and I4
		//IL_066c: Invalid comparison between VT and I4
		//IL_013f: Expected VT, but got I4
		//IL_0656: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I4
		//IL_0428: Expected VT, but got I4
		//IL_01b2: Expected VT, but got I4
		//IL_051c: Expected Obj, but got I4
		//IL_06f2: Expected Obj, but got I
		//IL_06fa: Expected I, but got Obj
		//IL_071c: Expected Obj, but got I4
		//IL_0765: Expected Obj, but got I
		//IL_01e2: Expected VT, but got I4
		//IL_0553: Expected VT, but got I4
		//IL_0230: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_024d: Expected VT, but got Obj
		//IL_0219: Expected VT, but got I4
		//IL_0571: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I
		//IL_02af: Expected I4, but got I8
		//IL_0333: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got Ref
		//IL_034c: Expected Obj, but got Ref
		//IL_0379: Expected VT, but got Obj
		//IL_0397: Expected Obj, but got I
		//IL_039f: Expected I, but got Obj
		//IL_03b7: Expected Obj, but got I4
		//IL_03c0: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got Ref
		//IL_03d0: Expected Obj, but got Ref
		bool flag = inbuff == null;
		_003CPrivateImplementationDetails_003E.IncomingMessage incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
		TPeer tPeer = this;
		if (flag)
		{
			goto IL_0481;
		}
		ConnectionStateValue connectionStateValue = peerConnectionState;
		object obj = connectionStateValue & (ConnectionStateValue)0xFF;
		if (obj == null)
		{
			return;
		}
		int num = timeInt;
		TrafficStats stats = Stats;
		bool flag2 = stats == null;
		incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
		bool lockTaken = default;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		_003CPrivateImplementationDetails_003E.IncomingMessage incomingMessage2 = default;
		if (!flag2)
		{
			stats.LastReceiveTimestamp__BackingField = num;
			TrafficStats stats2 = Stats;
			bool flag3 = stats2 == null;
			incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
			if (!flag3)
			{
				int num3 = default;
				long num2 = ((TrafficStatsBase)stats2).BytesIn__BackingField + num3;
				((TrafficStatsBase)stats2).BytesIn__BackingField = num2;
				TrafficStats stats3 = Stats;
				bool flag4 = stats3 == null;
				incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
				if (!flag4)
				{
					int num4 = ((TrafficStatsBase)stats3).PackagesIn__BackingField + 1;
					((TrafficStatsBase)stats3).PackagesIn__BackingField = num4;
					bool flag5 = inbuff.Length == 0;
					incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
					if (!flag5)
					{
						if (inbuff[0] == 240)
						{
							ReadPingResult(inbuff);
							return;
						}
						if (inbuff[0] == 243)
						{
							bool flag6 = (byte)(~(DoFraming ? 1u : 0u)) != 0;
							incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
							if (!flag6)
							{
								TrafficStats stats4 = Stats;
								bool flag7 = stats4 == null;
								incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
								if (flag7)
								{
									goto IL_05c4;
								}
								long num5 = ((TrafficStatsBase)stats4).BytesIn__BackingField + 7;
								((TrafficStatsBase)stats4).BytesIn__BackingField = num5;
								incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
							StreamBuffer streamBuffer = (StreamBuffer)0;
							nint num6 = (nint)streamBuffer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v51 (Il2CppClass<Photon.Client.StreamBuffer>)+E4]");
							bool flag8 = (nint)0 == 0;
							object obj2 = !flag8;
							nint num7 = num6;
							if (obj2 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num7 = (nint)streamBuffer;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v52 (Il2CppClass<Photon.Client.StreamBuffer>)+A0]");
							object obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v33+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516208]");
								object obj4 = 0;
								incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
								StreamBuffer streamBuffer2 = default;
								if (streamBuffer2 != null)
								{
									streamBuffer2.Write(inbuff, 0, num3);
									streamBuffer2.pos = 0;
									if ((int)(streamBuffer2.len & 0x80000000L) != 0)
									{
										streamBuffer2.len = 0;
										bool flag9 = streamBuffer2.CheckSize(0);
									}
									Monitor.Enter(incomingList, ref lockTaken);
									tPeer = (TPeer)(object)incomingList;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag10 = incomingList == null;
									obj5 = 0;
									obj6 = 0;
									obj7 = (object)(&obj8);
									obj9 = (object)(&lockTaken);
									obj8 = incomingList;
									lockTaken = false;
									nint num8 = num3;
									num3 = 0;
									incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)streamBuffer2;
									if (!flag10)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517120]");
										object obj10 = 0;
										num8 = (nint)obj10;
										incomingList.Enqueue(incomingMessage2);
										obj5 = 0;
										obj6 = 0;
										obj7 = (object)(&obj8);
										obj9 = (object)(&lockTaken);
										obj8 = incomingList;
										lockTaken = false;
										num3 = num;
										incomingMessage = incomingMessage2;
										goto IL_03f9;
									}
									goto IL_0606;
								}
							}
							goto IL_05c4;
						}
						LogLevel logLevel = LogLevel;
						if (num3 < 1)
						{
							return;
						}
						object obj11 = logLevel & (LogLevel)0xFF;
						if (obj11 == null)
						{
							return;
						}
						bool flag11 = inbuff.Length == 0;
						incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517128]");
							object format = 0;
							object arg = default;
							object arg2 = default;
							string debugReturn = string.Format((string)format, arg, arg2);
							EnqueueDebugReturn((LogLevel)1, debugReturn);
							return;
						}
					}
					goto IL_05d2;
				}
			}
		}
		goto IL_05c4;
		IL_05c4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05d2;
		IL_03f9:
		if (obj9 != null)
		{
			Monitor.Exit(obj7);
			incomingMessage = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
		}
		bool flag12 = obj6 == null;
		object obj13 = !flag12;
		if (obj13 == null)
		{
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_0481;
			}
			return;
		}
		goto IL_05f8;
		IL_05d2:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		incomingMessage2 = (_003CPrivateImplementationDetails_003E.IncomingMessage)0;
		obj8 = null;
		lockTaken = false;
		goto IL_05f8;
		IL_0481:
		LogLevel logLevel2 = LogLevel;
		object obj14 = logLevel2 & (LogLevel)0xFF;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517130]");
			object debugReturn2 = 0;
			tPeer.EnqueueDebugReturn((LogLevel)1, (string)debugReturn2);
		}
		return;
		IL_0606:
		NullReferenceException ex3 = new NullReferenceException();
		if (incomingMessage == (_003CPrivateImplementationDetails_003E.IncomingMessage)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj5 = 1;
			tPeer = (TPeer)(object)ex3;
		}
		else
		{
			if (incomingMessage != (_003CPrivateImplementationDetails_003E.IncomingMessage)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj15 = default;
			obj6 = obj15;
			tPeer = (TPeer)(object)ex3;
		}
		goto IL_03f9;
		IL_05f8:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_0606;
	}

	private void ReadPingResult(byte[] inbuff)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_009a: Expected F4, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int offset = default;
		MessageProtocol.Deserialize(out int value, inbuff, ref offset);
		MessageProtocol.Deserialize(out int value2, inbuff, ref offset);
		int num = timeInt;
		int num2 = (lastRoundTripTime = num - value2);
		bool flag2 = (byte)(~(serverTimeOffsetIsAvailable ? 1u : 0u)) != 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			roundTripTime = num2;
		}
		UpdateRoundTripTimeAndVariance(num2);
		bool flag3 = (byte)(~(serverTimeOffsetIsAvailable ? 1u : 0u)) != 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			int num3 = timeInt;
			object obj6 = value + lastRoundTripTime;
			serverTimeOffsetIsAvailable = true;
			int num4 = obj6 - num3;
			serverTimeOffset = num4;
		}
	}

	protected internal void ReadPingResult(OperationResponse operationResponse)
	{
		//IL_0083: Expected Obj, but got I
		//IL_008b: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0138: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_01b6: Expected F4, but got I4
		//IL_01d2: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected I4, but got Unknown
		if (operationResponse != null && operationResponse.Parameters != null)
		{
			object obj = operationResponse.Parameters.get_Item((byte)2);
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj2 = 0;
				nint num = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v4+50]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v3 (Il2CppClass<System.Object>)+40]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X1_v4+40]");
				if (num2 != 0)
				{
					goto IL_0209;
				}
				if (operationResponse.Parameters != null)
				{
					object obj4 = operationResponse.Parameters.get_Item((byte)1);
					if (obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v4+50]");
						object obj5 = 0;
						nint num3 = (nint)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6 (Il2CppClass<System.Object>)+40]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X1_v6+40]");
						if (num4 == 0)
						{
							int num5 = dispatchArrivalTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v8 (System.Object)+10]");
							int num6 = (lastRoundTripTime = (int)((nint)num5 - (nint)0));
							bool flag = (byte)(~(serverTimeOffsetIsAvailable ? 1u : 0u)) != 0;
							object obj6 = !flag;
							if (obj6 == null)
							{
								roundTripTime = num6;
							}
							UpdateRoundTripTimeAndVariance(num6);
							bool flag2 = (byte)(~(serverTimeOffsetIsAvailable ? 1u : 0u)) != 0;
							object obj7 = !flag2;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6 (System.Object)+10]");
								object obj8 = (nint)0 + (nint)lastRoundTripTime;
								int num7 = obj8 - dispatchArrivalTime;
								serverTimeOffset = num7;
								serverTimeOffsetIsAvailable = true;
							}
							return;
						}
						goto IL_0209;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0209;
		IL_0209:
		throw new InvalidCastException();
	}

	static TPeer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516530]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+8]");
		_ = 0;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+A0]");
		object obj6 = 0;
		object obj7 = default;
		obj6 = obj7;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v7+18]");
			bool flag = (nint)0 == 1;
			_ = 243;
			if (!flag)
			{
				_ = 2;
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11+A0]");
				object obj10 = (nint)0 + (nint)8;
				object obj11 = default;
				obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
