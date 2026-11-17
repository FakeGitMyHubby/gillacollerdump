using System;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public struct RpcSendResult
{
	public RpcSendMessageResult Result;

	public int MessageSize;

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_006f: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		if (stringBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A98]");
			object value2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A90]");
			object value3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
			object value4 = 0;
			StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
			object obj2 = default;
			string value5 = ((Enum)(&obj2)).ToString();
			StringBuilder stringBuilder3 = stringBuilder.Append(value5);
			StringBuilder stringBuilder4 = stringBuilder.Append((string)value2);
			StringBuilder stringBuilder5 = stringBuilder.Append(MessageSize);
			StringBuilder stringBuilder6 = stringBuilder.Append((string)value3);
			StringBuilder stringBuilder7 = stringBuilder.Append((string)value4);
			((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
			string result = default;
			return result;
		}
		return (string)(object)new NullReferenceException();
	}
}
