using System;
using Cpp2ILInjected;
using Fusion.Sockets.Stun;

namespace Photon.Client;

public class TrafficStatsBase
{
	private long BytesIn__BackingField;

	private long BytesOut__BackingField;

	private int PackagesIn__BackingField;

	private int PackagesOut__BackingField;

	private int UdpFragmentsIn__BackingField;

	private int UdpFragmentsOut__BackingField;

	private int UdpUnreliableCommandsSent__BackingField;

	private int UdpReliableCommandsSent__BackingField;

	private int UdpReliableCommandsResent__BackingField;

	private int UdpReliableCommandsInFlight__BackingField;

	private int DispatchIncomingCommandsCalls__BackingField;

	private int SendOutgoingCommandsCalls__BackingField;

	private long RoundtripTime__BackingField;

	private long RoundtripTimeVariance__BackingField;

	private long LastRoundtripTime__BackingField;

	public long BytesIn
	{
		get
		{
			return BytesIn__BackingField;
		}
		internal set
		{
			BytesIn__BackingField = value;
		}
	}

	public long BytesOut
	{
		get
		{
			return BytesOut__BackingField;
		}
		internal set
		{
			BytesOut__BackingField = value;
		}
	}

	public int PackagesIn
	{
		get
		{
			return PackagesIn__BackingField;
		}
		internal set
		{
			PackagesIn__BackingField = value;
		}
	}

	public int PackagesOut
	{
		get
		{
			return PackagesOut__BackingField;
		}
		internal set
		{
			PackagesOut__BackingField = value;
		}
	}

	public int UdpFragmentsIn
	{
		get
		{
			return UdpFragmentsIn__BackingField;
		}
		internal set
		{
			UdpFragmentsIn__BackingField = value;
		}
	}

	public int UdpFragmentsOut
	{
		get
		{
			return UdpFragmentsOut__BackingField;
		}
		internal set
		{
			UdpFragmentsOut__BackingField = value;
		}
	}

	public int UdpUnreliableCommandsSent
	{
		get
		{
			return UdpUnreliableCommandsSent__BackingField;
		}
		internal set
		{
			UdpUnreliableCommandsSent__BackingField = value;
		}
	}

	public int UdpReliableCommandsSent
	{
		get
		{
			return UdpReliableCommandsSent__BackingField;
		}
		internal set
		{
			UdpReliableCommandsSent__BackingField = value;
		}
	}

	public int UdpReliableCommandsResent
	{
		get
		{
			return UdpReliableCommandsResent__BackingField;
		}
		internal set
		{
			UdpReliableCommandsResent__BackingField = value;
		}
	}

	public int UdpReliableCommandsInFlight
	{
		get
		{
			return UdpReliableCommandsInFlight__BackingField;
		}
		internal set
		{
			UdpReliableCommandsInFlight__BackingField = value;
		}
	}

	public int DispatchIncomingCommandsCalls
	{
		get
		{
			return DispatchIncomingCommandsCalls__BackingField;
		}
		internal set
		{
			DispatchIncomingCommandsCalls__BackingField = value;
		}
	}

	public int SendOutgoingCommandsCalls
	{
		get
		{
			return SendOutgoingCommandsCalls__BackingField;
		}
		internal set
		{
			SendOutgoingCommandsCalls__BackingField = value;
		}
	}

	public virtual long RoundtripTime
	{
		get
		{
			return RoundtripTime__BackingField;
		}
		internal set
		{
			RoundtripTime__BackingField = value;
		}
	}

	public virtual long RoundtripTimeVariance
	{
		get
		{
			return RoundtripTimeVariance__BackingField;
		}
		internal set
		{
			RoundtripTimeVariance__BackingField = value;
		}
	}

	public virtual long LastRoundtripTime
	{
		get
		{
			return LastRoundtripTime__BackingField;
		}
		internal set
		{
			LastRoundtripTime__BackingField = value;
		}
	}

	public TrafficStatsBase()
	{
	}

	public unsafe TrafficStatsBase(TrafficStatsBase origin = null)
	{
		//IL_0061: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		PackagesIn__BackingField = origin.PackagesIn__BackingField;
		BytesIn__BackingField = origin.BytesIn__BackingField;
		UdpUnreliableCommandsSent__BackingField = origin.UdpUnreliableCommandsSent__BackingField;
		DispatchIncomingCommandsCalls__BackingField = origin.DispatchIncomingCommandsCalls__BackingField;
		bool isEmpty = ((Fusion.Sockets.Stun.StunClient.List.List*)origin)->IsEmpty;
		((Fusion.Sockets.Stun.StunClient.List.List*)this)->Fusion_002EIIntrusiveLinkedList_002ECopyTo((Array)isEmpty, 0);
		bool flag = origin.Equals(0);
		base.Finalize();
		int hashCode = origin.GetHashCode();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v55 @ X8_v6 (Il2CppClass<Photon.Client.TrafficStatsBase>)+1C8] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
