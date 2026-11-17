using Cpp2ILInjected;

namespace Fusion;

public sealed class DefaultForPropertyAttribute : PropertyAttribute
{
	private readonly string PropertyName__BackingField;

	private readonly int WordOffset__BackingField;

	private readonly int WordCount__BackingField;

	public string PropertyName => PropertyName__BackingField;

	public int WordOffset => WordOffset__BackingField;

	public int WordCount => WordCount__BackingField;

	public DefaultForPropertyAttribute(string propertyName, int wordOffset, int wordCount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3A20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector(applyToCollection: false);
		object obj3 = this + 24;
		obj3 = propertyName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
