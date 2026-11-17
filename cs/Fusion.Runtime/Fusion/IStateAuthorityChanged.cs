using System;
using UnityEngine.InputSystem.LowLevel;

namespace Fusion;

public interface IStateAuthorityChanged : Action<InputUpdateType>
{
	void StateAuthorityChanged();
}
