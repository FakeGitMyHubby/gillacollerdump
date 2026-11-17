using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

public static class FloatUtils
{
	public const int DEFAULT_ACCURACY = default(int);

	[MethodImpl((MethodImplOptions)256)]
	public static int Compress(float f, int accuracy = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got F4
		//IL_0072: Expected Obj, but got F4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = f >> 31;
		float num = (float)accuracy * f;
		double num2 = 0.5 - (double)obj4;
		float num3 = num + (float)num2;
		object obj5 = num3 >> 31;
		return obj5 ^ num3;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static float Decompress(int value, float accuracy = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = value & 1;
		object obj4 = -num;
		int num2 = obj4 ^ value;
		return (float)num2 / accuracy;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static int DecompressStoreAsInt(int value, float accuracy = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_0061: Expected I4, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = value & 1;
		object obj4 = -num;
		int num2 = obj4 ^ value;
		float num3 = (float)num2 / accuracy;
		return (int)num3;
	}
}
