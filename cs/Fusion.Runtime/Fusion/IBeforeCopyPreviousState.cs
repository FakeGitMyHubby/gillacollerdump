using System;
using UnityEngine.UIElements;

namespace Fusion;

public interface IBeforeCopyPreviousState : Action<IPanel>
{
	void BeforeCopyPreviousState();
}
