using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion.Encryption;
using Fusion.Protocol;
using Fusion.Sockets.Stun;
using Photon.Realtime;

namespace Fusion;

internal class CloudServicesMetadata
{
	public static readonly TypedLobby LobbyClientServer;

	public static readonly TypedLobby LobbyShared;

	private NetworkRunnerInitializeArgs RunnerInitializeArgs__BackingField;

	private NATPunchStage CurrentPunchStage__BackingField;

	private JoinProcessStage CurrentJoinStage__BackingField;

	private Fusion.Protocol.ProtocolMessageVersion CurrentProtocolMessageVersion__BackingField;

	private Fusion.Protocol.ReflexiveInfo RemoteReflexiveInfo__BackingField;

	private byte[] UniqueId__BackingField;

	private int PlayerRef__BackingField;

	private Fusion.Encryption.EncryptionToken EncryptionToken__BackingField;

	public ScheduledRequests ScheduledRequests;

	public Fusion.Protocol.Disconnect LastDisconnectMsg;

	public Dictionary<long, Fusion.Protocol.ReflexiveInfo> UniqueIdToReflexiveInfoTable;

	public RejoinMetadata RejoinMetadata;

	private Fusion.Sockets.Stun.StunResult _localStunResult;

	public NetworkRunnerInitializeArgs RunnerInitializeArgs
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			NetworkRunnerInitializeArgs result = default;
			return result;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			object obj = this + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
			object obj2 = this + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public NATPunchStage CurrentPunchStage
	{
		get
		{
			return CurrentPunchStage__BackingField;
		}
		set
		{
			CurrentPunchStage__BackingField = value;
		}
	}

	public JoinProcessStage CurrentJoinStage
	{
		get
		{
			return CurrentJoinStage__BackingField;
		}
		set
		{
			CurrentJoinStage__BackingField = value;
		}
	}

	public Fusion.Protocol.ProtocolMessageVersion CurrentProtocolMessageVersion
	{
		get
		{
			return CurrentProtocolMessageVersion__BackingField;
		}
		set
		{
			CurrentProtocolMessageVersion__BackingField = value;
		}
	}

	public Fusion.Protocol.ReflexiveInfo RemoteReflexiveInfo
	{
		get
		{
			return RemoteReflexiveInfo__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 432;
			RemoteReflexiveInfo__BackingField = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public Fusion.Sockets.Stun.StunResult LocalReflexiveInfo
	{
		get
		{
			return _localStunResult;
		}
		set
		{
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected Obj, but got Unknown
			//IL_0015: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_003d: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I
			//IL_0095: Expected Obj, but got I
			//IL_00b2: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
			object obj = this + 976;
			_localStunResult = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (_localStunResult != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6+A0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v7+E0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v7+E0]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5788]");
					object format = 0;
					string text = string.Format((string)format, _localStunResult);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X19_v4+10]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v1+198]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v1+1A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v66 @ X3_v1 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public byte[] UniqueId
	{
		get
		{
			return UniqueId__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 440;
			UniqueId__BackingField = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public int PlayerRef
	{
		get
		{
			return PlayerRef__BackingField;
		}
		set
		{
			PlayerRef__BackingField = value;
		}
	}

	public Fusion.Encryption.EncryptionToken EncryptionToken
	{
		get
		{
			return EncryptionToken__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 456;
			EncryptionToken__BackingField = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public unsafe CloudServicesMetadata()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003b: Expected I4, but got I8
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got Ref
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5790]");
		object obj = 0;
		object obj2 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj3 = this + 432;
		CurrentProtocolMessageVersion__BackingField = (Fusion.Protocol.ProtocolMessageVersion)12;
		RemoteReflexiveInfo__BackingField = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = this + 440;
		UniqueId__BackingField = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = this + 472;
		ScheduledRequests = (ScheduledRequests)0u;
		PlayerRef__BackingField = -1;
		LastDisconnectMsg = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<long, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj6 = this + 480;
		UniqueIdToReflexiveInfoTable = (Dictionary<long, Fusion.Protocol.ReflexiveInfo>)(object)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj8 = default;
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = this + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj10 = this + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = this + 976;
		_localStunResult = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	static CloudServicesMetadata()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57A0]");
		object name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D50E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57A8]");
		object name2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TypedLobby typedLobby = default;
		typedLobby._002Ector((string)name, (LobbyType)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = typedLobby;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TypedLobby typedLobby2 = default;
		typedLobby2._002Ector((string)name2, (LobbyType)0);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+A0]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = typedLobby2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
