using System;
using Cpp2ILInjected;

namespace Photon.Client;

internal class CustomType
{
	public readonly byte Code;

	public readonly Type Type;

	public readonly SerializeStreamMethod SerializeStreamFunction;

	public readonly DeserializeStreamMethod DeserializeStreamFunction;

	public CustomType(Type type, byte code, SerializeStreamMethod serializeFunction, DeserializeStreamMethod deserializeFunction)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = type;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Code = code;
		object obj2 = this + 32;
		obj2 = serializeFunction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = this + 40;
		obj3 = deserializeFunction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
