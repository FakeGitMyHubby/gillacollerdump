using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.GroupsModels;
using UnityEngine;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 16)]
public struct Vector4Compressed : Action<ListGroupApplicationsResponse>, _0021_00210
{
	[FieldOffset(0)]
	public int xEncoded;

	[FieldOffset(4)]
	public int yEncoded;

	[FieldOffset(8)]
	public int zEncoded;

	[FieldOffset(12)]
	public int wEncoded;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_X_ENCODED = default(int);

	internal const int BYTE_COUNT_OF_X_ENCODED = default(int);

	internal const int BYTE_OF_Y_ENCODED = default(int);

	internal const int BYTE_COUNT_OF_Y_ENCODED = default(int);

	internal const int BYTE_OF_Z_ENCODED = default(int);

	internal const int BYTE_COUNT_OF_Z_ENCODED = default(int);

	internal const int BYTE_OF_W_ENCODED = default(int);

	internal const int BYTE_COUNT_OF_W_ENCODED = default(int);

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

	public float Z
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
			int num = zEncoded & 1;
			object obj4 = -num;
			int num2 = obj4 ^ zEncoded;
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
			zEncoded = num4;
		}
	}

	public float W
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
			int num = wEncoded & 1;
			object obj4 = -num;
			int num2 = obj4 ^ wEncoded;
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
			wEncoded = num4;
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator Vector4Compressed(Vector4 v)
	{
		//IL_0156: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0141: Expected VT, but got Obj
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
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj11 = default;
		object obj12 = default;
		object obj10 = obj11 * obj12;
		object obj14 = default;
		object obj13 = obj14 * obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj15 = 63 - obj12;
		object obj17 = default;
		object obj16 = 63 - obj17;
		object obj18 = obj10 + obj15;
		object obj19 = obj13 + obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj20 = obj18 + obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj21 = obj19 + obj19;
		object obj22 = 0x3F ^ obj20;
		object obj23 = obj13 ^ obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		return (Vector4Compressed)(obj23 | obj22);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator Vector4(Vector4Compressed q)
	{
		//IL_007e: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_012e: Expected VT, but got Obj
		//IL_0150: Expected Obj, but got I4
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
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector4 result = (Vector4)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v9 (UnityEngine.Vector4)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		return result;
	}

	public bool Equals(Vector4Compressed other)
	{
		//IL_000a: Invalid comparison between I4 and VT
		//IL_002f: Expected Obj, but got VT
		//IL_007f: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		if ((object)xEncoded == (object)other)
		{
			object obj = other >> 32;
			nint num = default;
			if (yEncoded == (nint)obj && zEncoded == num)
			{
				object obj2 = num >> 32;
				object obj3 = wEncoded - obj2;
				return obj3 == null;
			}
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C38]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int num = xEncoded;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if ((nint)num == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					object obj3 = (nint)0 >> 32;
					if (yEncoded == (nint)obj3)
					{
						int num2 = zEncoded;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
						if ((nint)num2 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
							object obj4 = (nint)0 >> 32;
							object obj5 = wEncoded - obj4;
							return obj5 == null;
						}
					}
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
		//IL_002d: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I4, but got Unknown
		//IL_004a: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
		object obj = xEncoded * 397;
		int num = obj ^ yEncoded;
		object obj2 = num * 397;
		int num2 = obj2 ^ zEncoded;
		object obj3 = num2 * 397;
		return obj3 ^ wEncoded;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(Vector4Compressed left, Vector4Compressed right)
	{
		//IL_0008: Invalid comparison between VT and I
		//IL_0030: Invalid comparison between VT and Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		IntPtr intPtr = default;
		bool flag = left != (Vector4Compressed)(object)(nint)intPtr;
		bool result = false;
		if (!flag)
		{
			object obj = default;
			bool flag2 = right != (Vector4Compressed)obj;
			result = false;
			if (!flag2)
			{
				object obj2 = obj ^ right;
				object obj3 = obj2 >> 32;
				bool flag3 = obj3 == null;
				result = flag3;
			}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(Vector4Compressed left, Vector4Compressed right)
	{
		//IL_0008: Invalid comparison between VT and I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		IntPtr intPtr = default;
		bool flag = left != (Vector4Compressed)(object)(nint)intPtr;
		bool result = true;
		if (!flag)
		{
			object obj2 = default;
			object obj = obj2 ^ right;
			object obj3 = obj >> 32;
			bool flag2 = obj3 == null;
			bool flag3 = !flag2;
			object obj4 = right - obj2;
			bool flag4 = obj4 == null;
			object obj5 = !flag4;
			object obj6 = ~obj5;
			result = obj6 == null || flag3;
		}
		return result;
	}
}
