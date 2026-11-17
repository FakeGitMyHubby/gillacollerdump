using Cpp2ILInjected;
using UnityEngine;

public static class GillaSharpen
{
	public const float Strength = default(float);

	private static readonly int Id;

	public static void Set(float strength)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_0081: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7310]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj4 = 0;
		Shader.SetGlobalFloat((int)obj4, strength);
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7310]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Set(0.75f);
	}

	static GillaSharpen()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7318]");
		object name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7310]");
		object obj = 0;
		int num = Shader.PropertyToID((string)name);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = num;
	}
}
