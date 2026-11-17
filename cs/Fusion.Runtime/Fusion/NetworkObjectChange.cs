using System;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkObjectChange(NetworkId id, NetworkObjectChangeType changeType, PlayerRef player, ReadOnlySpan<(int, int)> wordsAffected)
{
	public readonly NetworkId Id = id;

	public readonly PlayerRef Player = player;

	public readonly NetworkObjectChangeType ChangeType = changeType;

	public readonly ReadOnlySpan<(int, int)> WordsAffected = wordsAffected;

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8100]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A68]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		object arg3 = default;
		return string.Format((string)format, arg, arg2, arg3);
	}
}
