using System;
using UnityEngine.InputSystem;

namespace Fusion;

public interface IInputAuthorityLost : Action<InputActionAsset>
{
	void InputAuthorityLost();
}
