using System;
using UnityEngine.InputSystem.LowLevel;

namespace Fusion;

public interface ISimulationExit : Action<InputEventPtr>
{
	void SimulationExit();
}
