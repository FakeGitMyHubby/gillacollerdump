using Cpp2ILInjected;
using Photon.Realtime;

namespace Fusion;

internal static class DisconnectCauseExt
{
	public static ShutdownReason ConvertToShutdownReason(DisconnectCause disconnectCause)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		object obj = disconnectCause - 1;
		bool flag = (nint)obj < 16;
		object obj2 = !flag;
		object obj3 = obj - 16;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 17588224 + 3340;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1*4]");
			return (ShutdownReason)0;
		}
		return (ShutdownReason)0;
	}
}
