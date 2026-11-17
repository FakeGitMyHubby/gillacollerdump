using System;
using Cpp2ILInjected;
using Fusion.Sockets;

namespace Fusion;

internal struct NetworkRunnerInitializeArgs
{
	public NetworkSceneInfo? Scene;

	public NetAddress? Address;

	public NetAddress? PublicAddress;

	public int? PlayerCount;

	public SimulationModes? SimulationMode;

	public int? InputWordCount;

	public int? SceneInfoWordCount;

	public NetworkProjectConfig Config;

	public Action<NetworkRunner> OnGameStarted;

	public INetworkObjectProvider ObjectProvider;

	public INetworkSceneManager SceneManager;

	public INetworkRunnerUpdater Updater;

	public INetworkObjectInitializer ObjectInitializer;

	public Type[] CustomCallbackInterfaces;

	public byte[] ConnectionToken;

	public NetworkId? ResumeId;

	public Tick? ResumeTick;

	public byte[] ResumeState;

	public Action<NetworkRunner> HostMigrationResume;

	public NetworkRunnerFlags Flags;

	public bool IsSinglePlayer
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerInitializeArgs)+114]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerInitializeArgs)+10C]");
				object obj = -1;
				return obj == null;
			}
			return false;
		}
	}
}
