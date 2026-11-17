using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Fusion.Statistics;

public class NetworkObjectStatisticsSnapshot
{
	public Dictionary<NetworkId, Dictionary<FusionObjectStatType, float>> NetworkObjectStatistics;

	public NetworkObjectStatisticsSnapshot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6748]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<NetworkId, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj2 = this + 16;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
