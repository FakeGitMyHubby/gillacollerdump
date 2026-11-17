using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Fusion;

public class NetworkObjectPrefabData : Behaviour
{
	public NetworkObjectGuid Guid;

	private void OnValidate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isEditor)
		{
			GameObject gameObject = base.gameObject;
			Scene scene = gameObject.scene;
			Scene scene2 = default;
			if (scene2.IsValid())
			{
				HideFlags hideFlags = base.hideFlags;
				HideFlags hideFlags2 = hideFlags | (HideFlags)0x3F;
				base.hideFlags = hideFlags2;
			}
		}
	}
}
