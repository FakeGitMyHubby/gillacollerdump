using System;
using UnityEngine.UIElements;

namespace Fusion;

public interface IInterestExit : Action<UnityEngine.UIElements.IVisualElementReferenceHandler>
{
	void InterestExit(PlayerRef player);
}
