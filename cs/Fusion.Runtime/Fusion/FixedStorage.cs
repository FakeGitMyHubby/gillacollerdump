using Cpp2ILInjected;

namespace Fusion;

public static class FixedStorage
{
	public static int GetWordCount<T>() where T : struct, IFixedStorage
	{
		//IL_0037: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_00e3: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<T>)+FC]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<T>)+FC]");
		object obj2 = (nint)0 + (nint)3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<T>)+FC]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<T>)+FC]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<T>)+FC]");
		object obj3 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<T>)+FC]");
		object obj4 = 0 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = flag == flag2;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			obj = obj2;
		}
		return obj >> 2;
	}
}
