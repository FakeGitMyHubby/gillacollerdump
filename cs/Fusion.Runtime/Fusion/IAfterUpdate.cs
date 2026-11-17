using System;
using Liv.Lck;

namespace Fusion;

public interface IAfterUpdate : Action<ILckResult>
{
	void AfterUpdate();
}
