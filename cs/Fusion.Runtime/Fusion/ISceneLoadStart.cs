using System;
using PlayFab.ProgressionModels;

namespace Fusion;

public interface ISceneLoadStart : Action<IncrementStatisticVersionResponse>
{
	void SceneLoadStart(SceneRef sceneRef);
}
