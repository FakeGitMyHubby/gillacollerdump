using Cpp2ILInjected;

namespace Fusion.Statistics;

public class BehaviourStatisticsManager
{
	private BehaviourStatisticsSnapshot _previousUpdateSnapshot;

	private BehaviourStatisticsSnapshot _currentUpdateSnapshot;

	public BehaviourStatisticsSnapshot CompletedSnapshot => _previousUpdateSnapshot;

	internal BehaviourStatisticsSnapshot PendingSnapshot => _currentUpdateSnapshot;

	internal BehaviourStatisticsManager()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6708]");
		object obj = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = this + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj4 = default;
		obj4._002Ector();
		object obj5 = this + 24;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal void FinishPendingSnapshot()
	{
		BehaviourStatisticsSnapshot previousUpdateSnapshot = _previousUpdateSnapshot;
		BehaviourStatisticsSnapshot currentUpdateSnapshot = _currentUpdateSnapshot;
		previousUpdateSnapshot.FixedUpdateNetworkExecutionCount__BackingField = currentUpdateSnapshot.FixedUpdateNetworkExecutionCount__BackingField;
		previousUpdateSnapshot.FixedUpdateNetworkExecutionTime__BackingField = currentUpdateSnapshot.FixedUpdateNetworkExecutionTime__BackingField;
		currentUpdateSnapshot.FixedUpdateNetworkExecutionCount__BackingField = 0;
		currentUpdateSnapshot.FixedUpdateNetworkExecutionTime__BackingField = 0.0;
		currentUpdateSnapshot.RenderExecutionTime__BackingField = 0.0;
	}
}
