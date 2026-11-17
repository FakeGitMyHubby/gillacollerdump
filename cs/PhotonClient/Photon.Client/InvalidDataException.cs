using System;
using Cpp2ILInjected;

namespace Photon.Client;

public class InvalidDataException : Exception
{
	public InvalidDataException(string message)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5388]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector(message);
	}
}
