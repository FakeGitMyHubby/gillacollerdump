using System;
using Liv.Lck;

namespace Fusion;

public interface IAfterHostMigration : Action<ILckMonitor>
{
	void AfterHostMigration();
}
