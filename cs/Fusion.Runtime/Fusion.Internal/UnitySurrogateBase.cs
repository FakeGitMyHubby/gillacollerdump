using System;
using UnityEngine.InputSystem;

namespace Fusion.Internal;

[Serializable]
public abstract class UnitySurrogateBase : Action<InputActionRebindingExtensions.RebindingOperation>
{
	public unsafe abstract void Read(int* data, int capacity);

	public unsafe abstract void Write(int* data, int capacity);

	public abstract void Init(int capacity);
}
