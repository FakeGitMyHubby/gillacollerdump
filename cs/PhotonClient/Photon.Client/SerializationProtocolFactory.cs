using Cpp2ILInjected;

namespace Photon.Client;

internal static class SerializationProtocolFactory
{
	internal static Protocol Create(SerializationProtocol serializationProtocol)
	{
		//IL_004a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		if (serializationProtocol == (SerializationProtocol)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Protocol18 protocol = default;
			protocol._002Ector();
			return protocol;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516958]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Protocol16 protocol2 = default;
		protocol2._002Ector();
		return protocol2;
	}
}
