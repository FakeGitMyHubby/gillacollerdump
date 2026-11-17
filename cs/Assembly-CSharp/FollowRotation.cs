using Cpp2ILInjected;
using UnityEngine;

public class FollowRotation : MonoBehaviour
{
	public Transform source;

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0082: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (source != null)
		{
			Transform transform = base.transform;
			Quaternion rotation = source.rotation;
			transform.rotation = (Quaternion)0;
		}
	}
}
