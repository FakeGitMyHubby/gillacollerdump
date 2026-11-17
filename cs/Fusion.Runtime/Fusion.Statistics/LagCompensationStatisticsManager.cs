using Cpp2ILInjected;

namespace Fusion.Statistics;

internal class LagCompensationStatisticsManager
{
	private LagCompensationStatisticsSnapshot _previousUpdateSnapshot;

	private LagCompensationStatisticsSnapshot _currentUpdateSnapshot;

	public LagCompensationStatisticsSnapshot CompletedSnapshot => _previousUpdateSnapshot;

	internal LagCompensationStatisticsSnapshot PendingSnapshot => _currentUpdateSnapshot;

	internal LagCompensationStatisticsManager()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67D0]");
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
		_previousUpdateSnapshot.CopyFromSnapshot(_currentUpdateSnapshot);
		LagCompensationStatisticsSnapshot currentUpdateSnapshot = _currentUpdateSnapshot;
		currentUpdateSnapshot.BVHMaxDeep__BackingField = 0;
		currentUpdateSnapshot.HitboxesCount__BackingField = 0;
		currentUpdateSnapshot.AddOnBufferTime__BackingField = 0.0;
		currentUpdateSnapshot.UpdateBVHTime__BackingField = 0.0;
		currentUpdateSnapshot.AdvanceBufferTime__BackingField = 0.0;
	}
}
