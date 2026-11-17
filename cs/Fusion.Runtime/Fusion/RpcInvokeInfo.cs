using System;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public struct RpcInvokeInfo
{
	public RpcLocalInvokeResult LocalInvokeResult;

	public RpcSendMessageResult SendMessageResult;

	public int PayloadSize;

	public RpcSendCullResult SendCullResult => (RpcSendCullResult)0;

	public RpcSendResult SendResult
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (RpcSendResult)0;
		}
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A80]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A88]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		object arg3 = default;
		return string.Format((string)format, arg, arg2, arg3);
	}

	public static RpcInvokeInfo Create(RpcLocalInvokeResult local, RpcSendMessageResult remote, int payloadSize)
	{
		//IL_000d: Expected VT, but got I4
		return (RpcInvokeInfo)((int)local | (int)remote);
	}
}
