using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

public interface INetworkObjectProvider
{
	NetworkObjectAcquireResult AcquireInstance(NetworkRunner runner, [In] ref NetworkObjectAcquireContext context, out NetworkObject result);

	NetworkObjectAcquireResult AcquirePrefabInstance(NetworkRunner runner, [In] ref NetworkPrefabAcquireContext context, out NetworkObject result)
	{
		//IL_003f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkObjectAcquireResult)ex2;
	}

	void ReleaseInstance(NetworkRunner runner, [In] ref NetworkObjectReleaseContext context);

	NetworkPrefabId GetPrefabId(NetworkRunner runner, NetworkObjectGuid prefabGuid)
	{
		//IL_006b: Expected VT, but got Obj
		if ((object)runner != null)
		{
			NetworkPrefabTable prefabs = runner.Prefabs;
			if (prefabs != null)
			{
				return prefabs.GetId(prefabGuid);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (NetworkPrefabId)ex;
	}

	NetworkPrefabId GetPrefabId(NetworkRunner runner, string prefabName)
	{
		//IL_003f: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkPrefabId)ex2;
	}

	void Shutdown(NetworkRunner networkRunner)
	{
	}

	void Initialize(NetworkRunner networkRunner)
	{
	}
}
