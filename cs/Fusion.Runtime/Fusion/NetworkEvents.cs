using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Fusion.Sockets;
using PlayFab.ClientModels;
using Unity.IL2CPP.Metadata;
using UnityEngine.Events;

namespace Fusion;

public class NetworkEvents : Behaviour, Action<UnlinkGooglePlayGamesServicesAccountResult>, _0021_00210
{
	public delegate void OnReliableDataReceivedDelegate(NetworkRunner runner, PlayerRef player, ReliableKey key, ReadOnlySpan<byte> data);

	[Serializable]
	public class InputEvent : UnityEvent<NetworkRunner, NetworkInput>
	{
		public InputEvent()
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9898]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @44F84A4");
		}
	}

	[Serializable]
	public class InputPlayerEvent : UnityEvent<NetworkRunner, PlayerRef, NetworkInput>
	{
		public InputPlayerEvent()
		{
			((UnityEvent<System.__Canon, PlayerRef, NetworkInput>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class ConnectRequestEvent : UnityEvent<NetworkRunner, NetworkRunnerUpdaterDefault.PlayerLoopSystemRegistration.ConnectRequest, byte[]>
	{
		public ConnectRequestEvent()
		{
			((UnityEvent<System.__Canon, System.__Canon, System.__Canon>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class ConnectFailedEvent : UnityEvent<NetworkRunner, NetAddress, NetConnectFailedReason>
	{
		public ConnectFailedEvent()
		{
			((UnityEvent<System.__Canon, NetAddress, Unity.IL2CPP.Metadata.__Il2CppByteEnum>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class DisconnectFromServerEvent : UnityEvent<NetworkRunner, NetDisconnectReason>
	{
		public DisconnectFromServerEvent()
		{
			((UnityEvent<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class ShutdownEvent : UnityEvent<NetworkRunner, ShutdownReason>
	{
		public ShutdownEvent()
		{
			((UnityEvent<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class PlayerEvent : UnityEvent<NetworkRunner, PlayerRef>
	{
		public PlayerEvent()
		{
			((UnityEvent<System.__Canon, PlayerRef>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class RunnerEvent : UnityEvent<NetworkRunner>
	{
		public RunnerEvent()
		{
			((UnityEvent<System.__Canon>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class SessionListUpdateEvent : UnityEvent<NetworkRunner, List<SessionInfo>>
	{
		public SessionListUpdateEvent()
		{
			((UnityEvent<System.__Canon, System.__Canon>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class CustomAuthenticationResponse : UnityEvent<NetworkRunner, Dictionary<string, object>>
	{
		public CustomAuthenticationResponse()
		{
			((UnityEvent<System.__Canon, System.__Canon>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class HostMigrationEvent : UnityEvent<NetworkRunner, HostMigrationToken>
	{
		public HostMigrationEvent()
		{
			((UnityEvent<System.__Canon, System.__Canon>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class ReliableDataEvent : UnityEvent<NetworkRunner, PlayerRef, ReliableKey, byte[]>
	{
		public ReliableDataEvent()
		{
			((UnityEvent<System.__Canon, PlayerRef, ReliableKey, System.__Canon>)(object)this)._002Ector();
		}
	}

	[Serializable]
	public class ReliableProgressEvent : UnityEvent<NetworkRunner, PlayerRef, ReliableKey, float>
	{
		public ReliableProgressEvent()
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D98F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @44FBFB4");
		}
	}

	[Serializable]
	public class ObjectEvent : UnityEvent<NetworkRunner, NetworkObject>
	{
		public ObjectEvent()
		{
			((UnityEvent<System.__Canon, System.__Canon>)(object)this)._002Ector();
		}
	}

	public InputEvent OnInput;

	public InputPlayerEvent OnInputMissing;

	public RunnerEvent OnConnectedToServer;

	public DisconnectFromServerEvent OnDisconnectedFromServer;

	public ConnectRequestEvent OnConnectRequest;

	public ConnectFailedEvent OnConnectFailed;

	public PlayerEvent PlayerJoined;

	public PlayerEvent PlayerLeft;

	public ShutdownEvent OnShutdown;

	public SessionListUpdateEvent OnSessionListUpdate;

	public CustomAuthenticationResponse OnCustomAuthenticationResponse;

	public HostMigrationEvent OnHostMigration;

	public RunnerEvent OnSceneLoadDone;

	public RunnerEvent OnSceneLoadStart;

	public ReliableDataEvent OnReliableData;

	public ReliableProgressEvent OnReliableDataProgress;

	public NetworkProjectConfig.ObjectPlayerEvent OnObjectEnterAOI;

	public NetworkProjectConfig.ObjectPlayerEvent OnObjectExitAOI;

	private void Fusion_002EINetworkRunnerCallbacks_002EOnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		PlayerRef arg = (PlayerRef)(player & 0xFFFFFFFFL);
		((UnityEvent<System.__Canon, System.__Canon, PlayerRef>)(object)OnObjectExitAOI).Invoke((System.__Canon)(object)runner, (System.__Canon)(object)obj, arg);
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		PlayerRef arg = (PlayerRef)(player & 0xFFFFFFFFL);
		((UnityEvent<System.__Canon, System.__Canon, PlayerRef>)(object)OnObjectEnterAOI).Invoke((System.__Canon)(object)runner, (System.__Canon)(object)obj, arg);
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnPlayerJoined(NetworkRunner runner, PlayerRef player)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		if (PlayerJoined != null)
		{
			PlayerRef arg = (PlayerRef)(player & 0xFFFFFFFFL);
			((UnityEvent<System.__Canon, PlayerRef>)(object)PlayerJoined).Invoke((System.__Canon)(object)runner, arg);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnPlayerLeft(NetworkRunner runner, PlayerRef player)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		if (PlayerLeft != null)
		{
			PlayerRef arg = (PlayerRef)(player & 0xFFFFFFFFL);
			((UnityEvent<System.__Canon, PlayerRef>)(object)PlayerLeft).Invoke((System.__Canon)(object)runner, arg);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnInput(NetworkRunner runner, NetworkInput input)
	{
		if (OnInput != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @44F8638");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		if (OnInputMissing != null)
		{
			PlayerRef arg = (PlayerRef)(player & 0xFFFFFFFFL);
			((UnityEvent<System.__Canon, PlayerRef, NetworkInput>)(object)OnInputMissing).Invoke((System.__Canon)(object)runner, arg, input);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
	{
		if (OnShutdown != null)
		{
			((UnityEvent<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)(object)OnShutdown).Invoke((System.__Canon)(object)runner, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)shutdownReason);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnConnectedToServer(NetworkRunner runner)
	{
		if (OnConnectedToServer != null)
		{
			((UnityEvent<System.__Canon>)(object)OnConnectedToServer).Invoke((System.__Canon)(object)runner);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason)
	{
		if (OnDisconnectedFromServer != null)
		{
			((UnityEvent<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>)(object)OnDisconnectedFromServer).Invoke((System.__Canon)(object)runner, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)reason);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnConnectRequest(NetworkRunner runner, NetworkRunnerUpdaterDefault.PlayerLoopSystemRegistration.ConnectRequest request, byte[] token)
	{
		if (OnConnectRequest != null)
		{
			((UnityEvent<System.__Canon, System.__Canon, System.__Canon>)(object)OnConnectRequest).Invoke((System.__Canon)(object)runner, (System.__Canon)(object)request, (System.__Canon)(object)token);
		}
	}

	private unsafe void Fusion_002EINetworkRunnerCallbacks_002EOnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002c: Expected VT, but got Ref
		//IL_0044: Expected VT, but got Ref
		bool flag = OnConnectFailed == null;
		Unity.IL2CPP.Metadata.__Il2CppByteEnum _Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)reason;
		System.__Canon _Canon = (System.__Canon)(object)runner;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9860]");
			object obj = 0;
			object obj2 = default;
			((UnityEvent<System.__Canon, NetAddress, Unity.IL2CPP.Metadata.__Il2CppByteEnum>)(object)OnConnectFailed).Invoke((System.__Canon)(object)runner, (NetAddress)(&obj2), (Unity.IL2CPP.Metadata.__Il2CppByteEnum)reason);
			_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)reason;
			_Canon = (System.__Canon)(object)runner;
			NetAddress netAddress = (NetAddress)(&obj2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
	{
		if (OnSessionListUpdate != null)
		{
			((UnityEvent<System.__Canon, System.__Canon>)(object)OnSessionListUpdate).Invoke((System.__Canon)(object)runner, (System.__Canon)(object)sessionList);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ReadOnlySpan<byte> data)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected VT, but got Unknown
		//IL_0040: Expected Obj, but got VT
		if (OnReliableData != null)
		{
			ReadOnlySpan<byte> readOnlySpan = default;
			byte[] array = readOnlySpan.ToArray();
			PlayerRef arg = (PlayerRef)(player & 0xFFFFFFFFL);
			((UnityEvent<System.__Canon, PlayerRef, ReliableKey, System.__Canon>)(object)OnReliableData).Invoke((System.__Canon)(object)runner, arg, key, (System.__Canon)data);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I
		if (OnReliableDataProgress != null)
		{
			object obj = player & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9880]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @44FC1E0");
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSceneLoadDone(NetworkRunner runner)
	{
		if (OnSceneLoadDone != null)
		{
			((UnityEvent<System.__Canon>)(object)OnSceneLoadDone).Invoke((System.__Canon)(object)runner);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSceneLoadStart(NetworkRunner runner)
	{
		if (OnSceneLoadStart != null)
		{
			((UnityEvent<System.__Canon>)(object)OnSceneLoadStart).Invoke((System.__Canon)(object)runner);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
	{
		if (OnCustomAuthenticationResponse != null)
		{
			((UnityEvent<System.__Canon, System.__Canon>)(object)OnCustomAuthenticationResponse).Invoke((System.__Canon)(object)runner, (System.__Canon)(object)data);
		}
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
	{
		if (OnHostMigration != null)
		{
			((UnityEvent<System.__Canon, System.__Canon>)(object)OnHostMigration).Invoke((System.__Canon)(object)runner, (System.__Canon)(object)hostMigrationToken);
		}
	}
}
