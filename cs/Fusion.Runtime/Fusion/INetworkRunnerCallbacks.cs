using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Fusion.Sockets;
using PlayFab.ClientModels;

namespace Fusion;

public interface INetworkRunnerCallbacks : Action<UnlinkKongregateAccountResult>
{
	void OnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player);

	void OnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player);

	void OnPlayerJoined(NetworkRunner runner, PlayerRef player);

	void OnPlayerLeft(NetworkRunner runner, PlayerRef player);

	void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason);

	void OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason);

	void OnConnectRequest(NetworkRunner runner, NetworkRunnerUpdaterDefault.PlayerLoopSystemRegistration.ConnectRequest request, byte[] token);

	void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason);

	void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}

	void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ReadOnlySpan<byte> data);

	void OnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress);

	void OnInput(NetworkRunner runner, NetworkInput input);

	void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input);

	void OnConnectedToServer(NetworkRunner runner);

	void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList);

	void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data);

	void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken);

	void OnSceneLoadDone(NetworkRunner runner);

	void OnSceneLoadStart(NetworkRunner runner);
}
