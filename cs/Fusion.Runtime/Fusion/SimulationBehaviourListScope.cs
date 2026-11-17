using System;
using Cpp2ILInjected;
using UnityEngine.InputSystem.LowLevel;

namespace Fusion;

public struct SimulationBehaviourListScope : Action<InputUpdateType>
{
	private SimulationBehaviourUpdater.BehaviourList _list;

	internal SimulationBehaviourListScope(SimulationBehaviourUpdater.BehaviourList list)
	{
		_list = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		SimulationBehaviourUpdater.BehaviourList list2 = _list;
		int lockCount = list2.LockCount + 1;
		list2.LockCount = lockCount;
	}

	public void Dispose()
	{
		SimulationBehaviourUpdater.BehaviourList list = _list;
		int num = list.LockCount - 1;
		bool flag = num == 1;
		list.LockCount = num;
		if (flag)
		{
			list.RemoveAllPending();
		}
	}
}
