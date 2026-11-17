using System.Runtime.CompilerServices;

namespace Fusion;

internal static class ScheduledRequestsExt
{
	[MethodImpl((MethodImplOptions)256)]
	public static bool IsSet(ref ScheduledRequests requests, ScheduledRequests target)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = ~requests;
		object obj2 = target & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void Set(ref ScheduledRequests requests, ScheduledRequests target)
	{
		//IL_0012: Expected Obj, but got I4
		object obj = requests | target;
		ref ScheduledRequests reference = ref *(ScheduledRequests*)obj;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void Clear(ref ScheduledRequests requests, ScheduledRequests target)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = ~target;
		object obj2 = requests & obj;
		ref ScheduledRequests reference = ref *(ScheduledRequests*)obj2;
	}
}
