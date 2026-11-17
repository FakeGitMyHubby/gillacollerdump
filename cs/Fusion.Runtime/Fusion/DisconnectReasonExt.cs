using Cpp2ILInjected;
using Fusion.Protocol;

namespace Fusion;

internal static class DisconnectReasonExt
{
	public static ShutdownReason ConvertToShutdownReason(DisconnectReason disconnectCause)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		object obj = disconnectCause - 1;
		object obj2 = obj & 0xFF;
		bool flag = (nint)obj2 < 5;
		object obj3 = !flag;
		object obj4 = obj2 - 5;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		if (obj6 == null)
		{
			object obj7 = obj & 0xFF;
			object obj8 = 17588224 + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X9_v3+v14 @ X8_v2*4]");
			return (ShutdownReason)0;
		}
		return (ShutdownReason)1;
	}
}
