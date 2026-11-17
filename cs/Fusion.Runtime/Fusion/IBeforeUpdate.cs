using System;
using UnityEngine.UIElements;

namespace Fusion;

public interface IBeforeUpdate : Action<IRuntimePanel>
{
	void BeforeUpdate();
}
