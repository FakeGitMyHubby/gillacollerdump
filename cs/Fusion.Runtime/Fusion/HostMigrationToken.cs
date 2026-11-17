using Cpp2ILInjected;
using Fusion.Protocol;

namespace Fusion;

public sealed class HostMigrationToken
{
	private GameMode GameMode__BackingField;

	private CloudCommunicator CloudCommunicator__BackingField;

	private readonly Fusion.Protocol.Snapshot HostSnapshot__BackingField;

	public GameMode GameMode
	{
		get
		{
			return GameMode__BackingField;
		}
		private set
		{
			GameMode__BackingField = value;
		}
	}

	internal CloudCommunicator CloudCommunicator
	{
		get
		{
			return CloudCommunicator__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	internal byte[] ResumeState
	{
		get
		{
			Fusion.Protocol.Snapshot snapshot = HostSnapshot__BackingField;
			if (HostSnapshot__BackingField != null)
			{
				return snapshot.Data__BackingField;
			}
			return null;
		}
	}

	internal Tick? ResumeTick
	{
		get
		{
			//IL_0043: Expected VT, but got I4
			Fusion.Protocol.Snapshot snapshot = HostSnapshot__BackingField;
			if (HostSnapshot__BackingField != null)
			{
				int? num = snapshot.Tick__BackingField;
			}
			return (Tick?)(object)0;
		}
	}

	internal NetworkId? ResumeId
	{
		get
		{
			//IL_0042: Expected VT, but got I4
			//IL_0026: Expected VT, but got I4
			//IL_0034: Expected VT, but got I4
			Fusion.Protocol.Snapshot snapshot = HostSnapshot__BackingField;
			if (HostSnapshot__BackingField != null)
			{
				NetworkId networkId = new NetworkId(snapshot.NetworkID__BackingField);
				NetworkId? networkId2 = (NetworkId)0;
				return (NetworkId?)(object)0;
			}
			return (NetworkId?)(object)0;
		}
	}

	private Fusion.Protocol.Snapshot HostSnapshot => HostSnapshot__BackingField;

	internal HostMigrationToken(Fusion.Protocol.Snapshot hostSnapshot, CloudCommunicator cloudCommunicator, GameMode gameMode)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		object obj = this + 32;
		obj = hostSnapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 24;
		obj2 = cloudCommunicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
