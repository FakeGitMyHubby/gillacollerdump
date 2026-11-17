using System.Collections.Generic;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;

namespace Fusion.Statistics;

public class FusionStatisticsSnapshot
{
	public Dictionary<FusionStatType, float> Stats;

	public FusionStatisticsSnapshot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6738]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float> dictionary = default;
		dictionary._002Ector();
		object obj2 = this + 16;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
