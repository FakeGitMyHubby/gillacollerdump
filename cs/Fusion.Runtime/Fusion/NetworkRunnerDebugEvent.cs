using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkRunnerDebugEvent
{
	public readonly NetworkRunner Runner;

	public readonly NetworkRunnerDebugEventType Type;

	public readonly NetworkObjectChange Change;

	public NetworkRunnerDebugEvent(NetworkRunner runner, NetworkRunnerDebugEventType eventType, [In] ref NetworkObjectChange change)
	{
		Runner = runner;
		Type = eventType;
		Change = change;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [change @ X3 (Fusion.NetworkObjectChange&)+10]");
		_ = 0;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003f: Expected VT, but got Ref
		//IL_0048: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A60]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		NetworkObjectChange networkObjectChange = (NetworkObjectChange)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		string arg = ((NetworkObjectChange*)networkObjectChange)->ToString();
		object arg2 = default;
		return string.Format((string)format, arg2, arg);
	}
}
