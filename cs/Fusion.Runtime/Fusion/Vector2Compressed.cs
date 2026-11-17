using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.MultiplayerModels;
using UnityEngine;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 8)]
public struct Vector2Compressed : Action<ListContainerImagesResponse>, _0021_00210
{
	[FieldOffset(0)]
	public int xEncoded;

	[FieldOffset(4)]
	public int yEncoded;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_X_ENCODED = default(int);

	internal const int BYTE_COUNT_OF_X_ENCODED = default(int);

	internal const int BYTE_OF_Y_ENCODED = default(int);

	internal const int BYTE_COUNT_OF_Y_ENCODED = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public float X
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0056: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I4
			//IL_0032: Expected Obj, but got I4
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected I4, but got Unknown
			//IL_0046: Expected F4, but got I4
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
			int num = xEncoded & 1;
			object obj4 = -num;
			int num2 = obj4 ^ xEncoded;
			return num2;
		}
		[MethodImpl((MethodImplOptions)256)]
		set
		{
			//IL_008b: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I4
			//IL_0022: Expected Obj, but got F4
			//IL_0063: Expected Obj, but got F4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = value >> 31;
			float num = value * 1.1492393E+09f;
			double num2 = 0.5 - (double)obj4;
			float num3 = num + (float)num2;
			object obj5 = num3 >> 31;
			int num4 = obj5 ^ num3;
			xEncoded = num4;
		}
	}

	public float Y
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0056: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I4
			//IL_0032: Expected Obj, but got I4
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected I4, but got Unknown
			//IL_0046: Expected F4, but got I4
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
			int num = yEncoded & 1;
			object obj4 = -num;
			int num2 = obj4 ^ yEncoded;
			return num2;
		}
		[MethodImpl((MethodImplOptions)256)]
		set
		{
			//IL_008b: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I4
			//IL_0022: Expected Obj, but got F4
			//IL_0063: Expected Obj, but got F4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = value >> 31;
			float num = value * 1.1492393E+09f;
			double num2 = 0.5 - (double)obj4;
			float num3 = num + (float)num2;
			object obj5 = num3 >> 31;
			int num4 = obj5 ^ num3;
			yEncoded = num4;
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator Vector2Compressed(Vector2 v)
	{
		//IL_00f9: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got F8
		//IL_00bd: Expected Obj, but got F8
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e4: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default;
		object obj6 = obj7 >> 31;
		object obj9 = default;
		object obj8 = obj9 >> 31;
		object obj10 = obj7 * 1149239296;
		object obj11 = obj9 * 1149239296;
		double num = 0.5 - (double)obj6;
		double num2 = 0.5 - (double)obj8;
		double num3 = (double)obj10 + num;
		double num4 = (double)obj11 + num2;
		object obj12 = num3 >> 31;
		object obj13 = num4 >> 31;
		object obj14 = obj12 ^ num3;
		object obj15 = obj13 ^ num4;
		return (Vector2Compressed)(obj14 | obj15);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator Vector2(Vector2Compressed q)
	{
		//IL_0038: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_0078: Expected VT, but got Obj
		//IL_009a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 result = (Vector2)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v5 (UnityEngine.Vector2)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return result;
	}

	public bool Equals(Vector2Compressed other)
	{
		//IL_000a: Invalid comparison between I4 and VT
		//IL_002f: Expected Obj, but got VT
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		if ((object)xEncoded == (object)other)
		{
			object obj = other >> 32;
			object obj2 = yEncoded - obj;
			return obj2 == null;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C28]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int num = xEncoded;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if ((nint)num == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					object obj3 = (nint)0 >> 32;
					object obj4 = yEncoded - obj3;
					return obj4 == null;
				}
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		object obj = xEncoded * 397;
		return obj ^ yEncoded;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(Vector2Compressed left, Vector2Compressed right)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = left - right;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(Vector2Compressed left, Vector2Compressed right)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = left - right;
		bool flag = obj == null;
		return !flag;
	}
}
