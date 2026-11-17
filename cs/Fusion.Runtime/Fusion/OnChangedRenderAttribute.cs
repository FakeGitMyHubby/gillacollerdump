using System;
using Cpp2ILInjected;

namespace Fusion;

public sealed class OnChangedRenderAttribute : Attribute
{
	private string MethodName__BackingField;

	public string MethodName
	{
		get
		{
			return MethodName__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public OnChangedRenderAttribute(string methodName)
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		bool flag = string.IsNullOrEmpty(methodName);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			object obj2 = this + 16;
			obj2 = methodName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		string message = default;
		ex._002Ector(paramName, message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}
}
