using System;
using Cpp2ILInjected;
using UnityEngine.VFX;

namespace Fusion;

public struct NetworkSceneObjectId : Action<VFXOutputEventArgs>
{
	public SceneRef Scene;

	public int ObjectId;

	public NetworkSceneLoadId LoadId;

	public int SceneLoadId
	{
		get
		{
			//IL_0007: Expected I4, but got VT
			return (int)LoadId;
		}
	}

	public bool IsValid => ((SceneRef)this).IsValid;

	public NetworkSceneObjectId(SceneRef scene, int objectId, NetworkSceneLoadId loadId = default(NetworkSceneLoadId))
	{
		Scene = scene;
		ObjectId = objectId;
		LoadId = loadId;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA008]");
		object format = 0;
		string arg = ((SceneRef)this).ToString(false, false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg2 = default;
		object arg3 = default;
		return string.Format((string)format, arg, arg2, arg3);
	}

	public bool Equals(NetworkSceneObjectId other)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		//IL_004b: Expected Obj, but got VT
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		SceneRef other2 = (SceneRef)(other & 0xFFFFFFFFL);
		if (((SceneRef)this).Equals(other2))
		{
			object obj = other >> 32;
			if (ObjectId == (nint)obj)
			{
				IntPtr intPtr = default;
				object obj2 = LoadId - (nint)intPtr;
				return obj2 == null;
			}
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004e: Expected VT, but got I8
		//IL_008f: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA010]");
			object obj2 = 0;
			if (obj == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				SceneRef other = (SceneRef)(0 & 0xFFFFFFFFL);
				if (((SceneRef)this).Equals(other))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					object obj3 = (nint)0 >> 32;
					if (ObjectId == (nint)obj3)
					{
						NetworkSceneLoadId loadId = LoadId;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
						object obj4 = loadId - 0;
						return obj4 == null;
					}
				}
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_0035: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		int hashCode = ((SceneRef)this).GetHashCode();
		object obj = hashCode * 397;
		int num = obj ^ ObjectId;
		object obj2 = num * 397;
		return obj2 ^ LoadId;
	}
}
