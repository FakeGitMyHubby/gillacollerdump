using System;
using UnityEngine.InputSystem.LowLevel;

namespace Fusion;

public interface IBeforeAllTicks : Action<IMECompositionString>
{
	void BeforeAllTicks(bool resimulation, int tickCount);
}
