using System;
using Liv.Lck;

namespace Fusion;

public interface IAfterAllTicks : Action<ILckCamera>
{
	void AfterAllTicks(bool resimulation, int tickCount);
}
