using System;
using UnityEngine.UIElements;

namespace Fusion;

public interface IDespawned : Action<IRuntimePanel>
{
	void Despawned(NetworkRunner runner, bool hasState);
}
