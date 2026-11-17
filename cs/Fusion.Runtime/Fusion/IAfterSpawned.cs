using System;
using Liv.Lck;

namespace Fusion;

public interface IAfterSpawned : Action<ILckResult>
{
	void AfterSpawned();
}
