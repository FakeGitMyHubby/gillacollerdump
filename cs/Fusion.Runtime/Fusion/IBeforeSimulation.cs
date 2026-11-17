using System;
using UnityEngine.UIElements;

namespace Fusion;

public interface IBeforeSimulation : Action<UnityEngine.UIElements.IPanelInputProvider>
{
	void BeforeSimulation(int forwardTickCount);
}
