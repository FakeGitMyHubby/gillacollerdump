namespace Fusion.Statistics;

public class FusionMemoryStatisticsSnapshot
{
	public const int BUCKET_COUNT = default(int);

	public FusionAllocatorMemorySnapshot ObjectAllocatorMemorySnapshot;

	public FusionAllocatorMemorySnapshot GeneralAllocatorMemorySnapshot;

	internal unsafe void CollectData(Simulation simulation)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Ref, but got Unknown
		simulation.GetGeneralAllocatorMemorySnapshot(ref *(FusionAllocatorMemorySnapshot*)(this + 72));
		simulation.GetObjectAllocatorMemorySnapshot(ref *(FusionAllocatorMemorySnapshot*)(this + 16));
	}

	public FusionMemoryStatisticsSnapshot()
	{
		//IL_002f: Expected VT, but got I4
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		ObjectAllocatorMemorySnapshot = (FusionAllocatorMemorySnapshot)0;
		base._002Ector();
	}
}
