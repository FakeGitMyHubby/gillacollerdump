using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Photon.Realtime;

namespace Fusion;

internal struct RejoinMetadata
{
	public bool TryingToReconnect;

	public bool TryingMoveSessionToNewRoom;

	public int RejoinAttempts;

	public AppSettings AppSettings;

	public StartGameArgs StartGameArgs;

	private const int RejoinAttemptsMax = default(int);

	public unsafe RejoinMetadata()
	{
		//IL_000b: Expected Obj, but got Ref
		//IL_0036: Expected Obj, but got Ref
		//IL_003f: Expected Obj, but got I4
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		TryingToReconnect = false;
		RejoinAttempts = 5;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public void Reset()
	{
		TryingToReconnect = false;
		RejoinAttempts = 5;
	}
}
