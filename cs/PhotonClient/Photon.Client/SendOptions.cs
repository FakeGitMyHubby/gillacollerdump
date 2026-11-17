using Cpp2ILInjected;

namespace Photon.Client;

public struct SendOptions
{
	public static readonly SendOptions SendReliable;

	public static readonly SendOptions SendUnreliable;

	public DeliveryMode DeliveryMode;

	public bool Encrypt;

	public byte Channel;

	public bool Reliability
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = DeliveryMode - 1;
			return obj == null;
		}
		set
		{
			DeliveryMode = (value ? ((DeliveryMode)1) : ((DeliveryMode)0));
		}
	}

	static SendOptions()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3060]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 1;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v5+A0]");
		object obj5 = 0;
		_ = 0;
	}
}
