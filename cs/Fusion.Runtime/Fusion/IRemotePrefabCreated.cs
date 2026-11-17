using System;
using PlayFab.ProgressionModels;

namespace Fusion;

public interface IRemotePrefabCreated : Action<IncrementLeaderboardVersionResponse>
{
	void RemotePrefabCreated();
}
