namespace Fusion;

public static class AuthorityMasks
{
	public const int STATE = default(int);

	public const int INPUT = default(int);

	public const int PROXY = default(int);

	public const int NONE = default(int);

	public const int ALL = default(int);

	internal static int Create(bool state, bool input)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		bool flag = !input;
		object obj = !flag;
		object obj2 = ~obj;
		int result = ((obj2 != null) ? 1 : 3);
		object obj3 = !flag;
		object obj4 = ~obj3;
		int result2 = ((obj4 != null) ? 4 : 2);
		bool flag2 = !state;
		object obj5 = !flag2;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return result;
		}
		return result2;
	}

	internal static RpcTargets CreateTargets(bool state, bool input)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		bool flag = !input;
		object obj = !flag;
		object obj2 = ~obj;
		RpcTargets result = ((obj2 != null) ? ((RpcTargets)1) : ((RpcTargets)3));
		object obj3 = !flag;
		object obj4 = ~obj3;
		RpcTargets result2 = ((obj4 != null) ? ((RpcTargets)4) : ((RpcTargets)2));
		bool flag2 = !state;
		object obj5 = !flag2;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return result;
		}
		return result2;
	}
}
