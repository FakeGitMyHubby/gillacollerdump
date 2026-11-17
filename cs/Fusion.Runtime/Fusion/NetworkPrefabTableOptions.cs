using System;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public struct NetworkPrefabTableOptions
{
	public bool UnloadPrefabOnReleasingLastInstance;

	public bool UnloadUnusedPrefabsOnShutdown;

	public static NetworkPrefabTableOptions Default;

	static NetworkPrefabTableOptions()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8970]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 256;
	}
}
