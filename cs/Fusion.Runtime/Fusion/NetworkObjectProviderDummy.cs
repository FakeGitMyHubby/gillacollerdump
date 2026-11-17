using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.EventsModels;

namespace Fusion;

public class NetworkObjectProviderDummy : Action<SetDataConnectionActiveResponse>
{
	public NetworkObjectAcquireResult AcquireInstance(NetworkRunner runner, [In] ref NetworkObjectAcquireContext context, out NetworkObject instance)
	{
		//IL_003f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkObjectAcquireResult)ex2;
	}

	public void ReleaseInstance(NetworkRunner runner, [In] ref NetworkObjectReleaseContext context)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}

	public NetworkPrefabId GetPrefabId(NetworkRunner runner, NetworkObjectGuid prefabGuid)
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

	private NetworkObjectAcquireResult Fusion_002EINetworkObjectProvider_002EAcquireInstance(NetworkRunner runner, [In] ref NetworkObjectAcquireContext context, out NetworkObject result)
	{
		return AcquireInstance(runner, ref context, out result);
	}

	private void Fusion_002EINetworkObjectProvider_002EReleaseInstance(NetworkRunner runner, [In] ref NetworkObjectReleaseContext context)
	{
		ReleaseInstance(runner, ref context);
	}
}
