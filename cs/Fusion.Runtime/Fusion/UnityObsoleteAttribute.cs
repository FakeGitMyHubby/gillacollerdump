using System;
using Cpp2ILInjected;

namespace Fusion;

internal class UnityObsoleteAttribute : Attribute
{
	private string _003Cmessage_003EP;

	private bool _003Cerror_003EP;

	public string Message => _003Cmessage_003EP;

	public bool IsError => _003Cerror_003EP;

	public UnityObsoleteAttribute(string message, bool error = default(bool))
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_003Cerror_003EP = error;
		base._002Ector();
	}
}
