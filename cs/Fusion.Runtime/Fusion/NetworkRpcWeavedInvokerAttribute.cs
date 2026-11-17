namespace Fusion;

public class NetworkRpcWeavedInvokerAttribute : RpcAttributeBase
{
	private readonly uint Key__BackingField;

	private bool HasPartialInvoker__BackingField;

	public uint Key => Key__BackingField;

	public bool HasPartialInvoker
	{
		get
		{
			return HasPartialInvoker__BackingField;
		}
		set
		{
			HasPartialInvoker__BackingField = value;
		}
	}

	public NetworkRpcWeavedInvokerAttribute(uint key)
	{
		Key__BackingField = key;
	}
}
