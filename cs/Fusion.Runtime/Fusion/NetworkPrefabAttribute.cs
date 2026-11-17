using Cpp2ILInjected;

namespace Fusion;

public sealed class NetworkPrefabAttribute : PropertyAttribute
{
	public NetworkPrefabAttribute()
	{
		//IL_0010: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3A20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector(applyToCollection: false);
	}
}
