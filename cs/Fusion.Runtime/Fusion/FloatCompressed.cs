using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.MultiplayerModels;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 4)]
public struct FloatCompressed : Action<ListCertificateSummariesResponse>, _0021_00210
{
	[FieldOffset(0)]
	public int valueEncoded;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_VALUE_ENCODED = default(int);

	internal const int BYTE_COUNT_OF_VALUE_ENCODED = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator FloatCompressed(float v)
	{
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got F4
		//IL_0063: Expected Obj, but got F4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = v >> 31;
		float num = v * 1.1492393E+09f;
		double num2 = 0.5 - (double)obj4;
		float num3 = num + (float)num2;
		object obj5 = num3 >> 31;
		return (FloatCompressed)(obj5 ^ num3);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator float(FloatCompressed q)
	{
		//IL_0052: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected F4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = q & 1;
		object obj5 = 0 - obj4;
		return obj5 ^ q;
	}

	public bool Equals(FloatCompressed other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = valueEncoded - other;
		return obj == null;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C20]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int num = valueEncoded;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)num - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return valueEncoded;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(FloatCompressed left, FloatCompressed right)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = left - right;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(FloatCompressed left, FloatCompressed right)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = left - right;
		bool flag = obj == null;
		return !flag;
	}
}
