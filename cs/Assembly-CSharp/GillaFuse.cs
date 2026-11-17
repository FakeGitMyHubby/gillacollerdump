using Cpp2ILInjected;
using UnityEngine;

public class GillaFuse : MonoBehaviour
{
	private GillaItem item;

	public GillaItem Item
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_00d1: Expected Obj, but got I4
			//IL_006c: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((Object)obj3 != null)
			{
				return (GillaItem)obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			GillaItem result = default;
			item = result;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return result;
		}
	}
}
