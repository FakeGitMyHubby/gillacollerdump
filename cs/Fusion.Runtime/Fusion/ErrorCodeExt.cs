using Cpp2ILInjected;

namespace Fusion;

internal static class ErrorCodeExt
{
	public static ShutdownReason ConvertToShutdownReason(short errorCode)
	{
		//IL_0017: Expected Obj, but got I8
		//IL_0031: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		if ((errorCode & 0xFFFF) != 0)
		{
			object obj = 4294934545L + errorCode;
			bool flag = (nint)obj < 16;
			object obj2 = !flag;
			object obj3 = obj - 16;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 17588224 + 3320;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v2+v44 @ X8_v5]");
				object obj7 = (nint)50946044 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X10_v2 (should have been resolved before IL gen)");
			}
			return (ShutdownReason)1;
		}
		return (ShutdownReason)0;
	}
}
