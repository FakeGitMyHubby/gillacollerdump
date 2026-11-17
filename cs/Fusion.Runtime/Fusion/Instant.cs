namespace Fusion;

internal struct Instant
{
	private double Input__BackingField;

	private double Local__BackingField;

	private double Remote__BackingField;

	public double Input
	{
		get
		{
			return Input__BackingField;
		}
		internal set
		{
			Input__BackingField = value;
		}
	}

	public double Local
	{
		get
		{
			return Local__BackingField;
		}
		internal set
		{
			Local__BackingField = value;
		}
	}

	public double Remote
	{
		get
		{
			return Remote__BackingField;
		}
		internal set
		{
			Remote__BackingField = value;
		}
	}
}
