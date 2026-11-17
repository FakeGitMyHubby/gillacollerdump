using Cpp2ILInjected;

namespace Fusion;

public class TickRateDivisorAttribute : PropertyAttribute
{
	private readonly string PropertyName__BackingField;

	private readonly string ObsoleteIndexName__BackingField;

	private readonly bool ForceOne__BackingField;

	public string PropertyName => PropertyName__BackingField;

	public string ObsoleteIndexName => ObsoleteIndexName__BackingField;

	public bool ForceOne => ForceOne__BackingField;

	public TickRateDivisorAttribute(string propertyName, string obsoleteIndexName, bool forceOne = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3A20]");
		object obj = 0;
		object obj2 = this + 24;
		obj2 = propertyName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = this + 32;
		obj3 = obsoleteIndexName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector(applyToCollection: false);
	}
}
