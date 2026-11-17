using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public static class JsonNetworkObjectDB
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass26_0
	{
		public double priorCount;

		public double binCount;

		public double binLowerBound;

		public double binUpperBound;
	}

	[Serializable]
	public class ObjectDataBase
	{
		public string TypeName;

		public string Id;

		public object UserData;
	}

	[Serializable]
	public class NetworkBehaviourData : ObjectDataBase
	{
		public int WordCount;

		public string Data;
	}

	[Serializable]
	public class NetworkObjectData : ObjectDataBase
	{
		public string Name;

		public List<NetworkBehaviourData> NetworkedBehaviours;

		public NetworkObjectFlags Flags;

		public NetworkObjectData()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D60]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list = default;
			list._002Ector();
			object obj2 = this + 48;
			obj2 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			((object)this)._002Ector();
		}
	}

	[Serializable]
	public class PrefabNetworkObjectData : NetworkObjectData
	{
		public int NestedObjectCount;
	}

	[Serializable]
	public class SceneData
	{
		public string UnityAssetGuid;

		public string SceneRef;

		public string ScenePath;

		public NetworkObjectData[] Objects;

		public object UserData;
	}

	[Serializable]
	public class PrefabData
	{
		public string UnityAssetPath;

		public string UnityAssetGuid;

		public PrefabNetworkObjectData[] Objects;

		public object UserData;
	}
}
