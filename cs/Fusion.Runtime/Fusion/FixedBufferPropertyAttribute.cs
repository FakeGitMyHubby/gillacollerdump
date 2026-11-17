using System;
using Cpp2ILInjected;

namespace Fusion;

public class FixedBufferPropertyAttribute : PropertyAttribute
{
	private readonly Type Type__BackingField;

	private readonly Type SurrogateType__BackingField;

	private readonly int Capacity__BackingField;

	public Type Type => Type__BackingField;

	public Type SurrogateType => SurrogateType__BackingField;

	public int Capacity => Capacity__BackingField;

	public FixedBufferPropertyAttribute(Type fieldType, Type surrogateType, int capacity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
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
		obj3 = fieldType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = this + 32;
		obj4 = surrogateType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
