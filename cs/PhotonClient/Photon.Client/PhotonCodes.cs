using Cpp2ILInjected;

namespace Photon.Client;

internal static class PhotonCodes
{
	internal static byte ClientKey;

	internal static byte ModeKey;

	internal static byte ServerKey;

	internal static byte InitEncryption;

	internal static byte Ping;

	public const byte Ok = default(byte);

	static PhotonCodes()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C700]");
		obj3 = 0;
		_ = 1;
	}
}
