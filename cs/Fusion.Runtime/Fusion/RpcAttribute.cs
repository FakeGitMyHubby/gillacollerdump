using System;
using Cpp2ILInjected;

namespace Fusion;

public class RpcAttribute : RpcAttributeBase
{
	private readonly RpcSources Sources__BackingField;

	private readonly RpcTargets Targets__BackingField;

	private RpcInvokeLocalMode InvokeLocalMode__BackingField;

	private RpcChannel Channel__BackingField;

	private bool TickAligned__BackingField;

	private uint Key__BackingField;

	private RpcHostMode HostMode__BackingField;

	public const int MaxPayloadSize = default(int);

	public RpcSources Sources => Sources__BackingField;

	public RpcTargets Targets => Targets__BackingField;

	public bool InvokeLocal
	{
		get
		{
			return InvokeLocalMode__BackingField == 0;
		}
		set
		{
			//IL_001a: Expected Obj, but got I4
			bool flag = !value;
			object obj = !flag;
			object obj2 = ~obj;
			RpcInvokeLocalMode rpcInvokeLocalMode = ((obj2 != null) ? ((RpcInvokeLocalMode)2) : ((RpcInvokeLocalMode)0));
			InvokeLocalMode__BackingField = rpcInvokeLocalMode;
		}
	}

	public RpcInvokeLocalMode InvokeLocalMode
	{
		get
		{
			return InvokeLocalMode__BackingField;
		}
		set
		{
			InvokeLocalMode__BackingField = value;
		}
	}

	public RpcChannel Channel
	{
		get
		{
			return Channel__BackingField;
		}
		set
		{
			Channel__BackingField = value;
		}
	}

	public bool TickAligned
	{
		get
		{
			return TickAligned__BackingField;
		}
		set
		{
			TickAligned__BackingField = value;
		}
	}

	public uint Key
	{
		get
		{
			return Key__BackingField;
		}
		set
		{
			Key__BackingField = value;
		}
	}

	public RpcHostMode HostMode
	{
		get
		{
			return HostMode__BackingField;
		}
		set
		{
			HostMode__BackingField = value;
		}
	}

	public RpcAttribute()
	{
		TickAligned__BackingField = true;
		Key__BackingField = 0u;
		HostMode__BackingField = (RpcHostMode)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D1A0]");
		Sources__BackingField = (RpcSources)0;
		((Attribute)this)._002Ector();
	}

	public RpcAttribute(RpcSources sources, RpcTargets targets)
	{
		TickAligned__BackingField = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D1A0]");
		Sources__BackingField = (RpcSources)0;
		Key__BackingField = 0u;
		HostMode__BackingField = (RpcHostMode)0;
		((Attribute)this)._002Ector();
		Sources__BackingField = sources;
		Targets__BackingField = targets;
	}
}
