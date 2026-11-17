namespace Fusion.Statistics;

public class BehaviourStatisticsSnapshot
{
	private int FixedUpdateNetworkExecutionCount__BackingField;

	private int RenderExecutionCount__BackingField;

	private double FixedUpdateNetworkExecutionTime__BackingField;

	private double RenderExecutionTime__BackingField;

	public int FixedUpdateNetworkExecutionCount
	{
		get
		{
			return FixedUpdateNetworkExecutionCount__BackingField;
		}
		private set
		{
			FixedUpdateNetworkExecutionCount__BackingField = value;
		}
	}

	public int RenderExecutionCount
	{
		get
		{
			return RenderExecutionCount__BackingField;
		}
		private set
		{
			RenderExecutionCount__BackingField = value;
		}
	}

	public double FixedUpdateNetworkExecutionTime
	{
		get
		{
			return FixedUpdateNetworkExecutionTime__BackingField;
		}
		private set
		{
			FixedUpdateNetworkExecutionTime__BackingField = value;
		}
	}

	public double RenderExecutionTime
	{
		get
		{
			return RenderExecutionTime__BackingField;
		}
		private set
		{
			RenderExecutionTime__BackingField = value;
		}
	}

	internal void ClearSnapshot()
	{
		FixedUpdateNetworkExecutionCount__BackingField = 0;
		FixedUpdateNetworkExecutionTime__BackingField = 0.0;
		RenderExecutionTime__BackingField = 0.0;
	}

	internal void CopyFromSnapshot(BehaviourStatisticsSnapshot snapshot)
	{
		FixedUpdateNetworkExecutionCount__BackingField = snapshot.FixedUpdateNetworkExecutionCount__BackingField;
		FixedUpdateNetworkExecutionTime__BackingField = snapshot.FixedUpdateNetworkExecutionTime__BackingField;
	}

	internal void AccumulateFixedUpdateNetworkExecutionCount(int count)
	{
		int num = FixedUpdateNetworkExecutionCount__BackingField + count;
		FixedUpdateNetworkExecutionCount__BackingField = num;
	}

	internal void AccumulateRenderExecutionCount(int count)
	{
		int num = RenderExecutionCount__BackingField + count;
		RenderExecutionCount__BackingField = num;
	}

	internal void AccumulateFixedUpdateNetworkExecutionTime(double time)
	{
		double num = FixedUpdateNetworkExecutionTime__BackingField + time;
		FixedUpdateNetworkExecutionTime__BackingField = num;
	}

	internal void AccumulateRenderExecutionTime(double time)
	{
		double num = RenderExecutionTime__BackingField + time;
		RenderExecutionTime__BackingField = num;
	}
}
