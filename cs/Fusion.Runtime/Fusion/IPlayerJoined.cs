using System;
using UnityEngine.UIElements;

namespace Fusion;

public interface IPlayerJoined : Action<UnityEngine.UIElements.IVisualElementReferenceHandler>
{
	void PlayerJoined(PlayerRef player);
}
