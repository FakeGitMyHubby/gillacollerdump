using System;

namespace Fusion;

[Serializable]
public class HostMigrationConfig
{
	public bool EnableAutoUpdate;

	public int UpdateDelay = 10;
}
