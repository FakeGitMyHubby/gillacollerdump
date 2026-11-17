using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

namespace Fusion;

public struct RpcDataReader(ReadOnlySpan<byte> data)
{
	private readonly ReadOnlySpan<byte> _data = data;

	private int _offset = 0;

	[MethodImpl((MethodImplOptions)256)]
	private static int AlignOffset(int offset)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		object obj = offset + 3;
		return (int)(obj & 0xFFFFFFFCL);
	}

	private ReadOnlySpan<byte> GetAndAdvanceData(int bytes)
	{
		//IL_0010: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected VT, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3200]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcDataReader)+8]");
		object obj3 = -_offset;
		bool flag = (nint)obj3 < _offset;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			bool flag2 = (nint)obj3 < bytes;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_0046;
			}
		}
		System.ThrowHelper.ThrowArgumentOutOfRangeException();
		goto IL_0046;
		IL_0046:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v3+20]");
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		ReadOnlySpan<byte> result = (ReadOnlySpan<byte>)(_data + _offset);
		object obj10 = bytes + _offset;
		object obj11 = obj10 + 3;
		int offset = (int)(obj11 & 0xFFFFFFFCL);
		_offset = offset;
		return result;
	}

	public unsafe void Read<T>(out T value, int size) where T : struct
	{
		ReadOnlySpan<byte> andAdvanceData = GetAndAdvanceData(size);
		if (size <= 0)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException((System.ExceptionArgument)28);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36A197C");
		object obj = default;
		ref T reference = ref *(T*)obj;
	}

	public unsafe void Read<T>(out T[] value, int elementSize) where T : struct
	{
		//IL_0029: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E58]");
		object obj = 0;
		Read(out int _, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		ref T[] reference = ref *(T[]*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int bytes = 0 * elementSize;
		ReadOnlySpan<byte> andAdvanceData = GetAndAdvanceData(bytes);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ X2_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ X1_v5 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ X3_v2 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
	}

	public unsafe void Read<T>(out ReadOnlySpan<T> value, int elementSize) where T : struct
	{
		//IL_0029: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E58]");
		object obj = 0;
		Read(out int _, 4);
		int bytes = 0 * elementSize;
		ReadOnlySpan<byte> andAdvanceData = GetAndAdvanceData(bytes);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ X2_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj2 = default;
		ref ReadOnlySpan<T> reference = ref *(ReadOnlySpan<T>*)obj2;
	}

	public unsafe void ReadCount<T>(out T[] array)
	{
		//IL_0029: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E58]");
		object obj = 0;
		Read(out int _, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		ref T[] reference = ref *(T[]*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe void Read(out string value)
	{
		Read(out int _, 4);
		Encoding uTF = Encoding.UTF8;
		ReadOnlySpan<byte> andAdvanceData = GetAndAdvanceData(0);
		string text = uTF.GetString(andAdvanceData);
		ref string reference = ref *(string*)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe void Read(out string[] value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj2 = 0;
		Read(out int _, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = default;
		ref string[] reference = ref *(string[]*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (0 < 1)
		{
			return;
		}
		object obj4 = 0;
		object obj5 = 32;
		while (true)
		{
			string[] array = value;
			if (value != null)
			{
				bool flag = (nint)obj4 < array.Length;
				object obj6 = !flag;
				if (obj6 != null)
				{
					break;
				}
				Read(out *(string*)((object)value + obj5));
				obj4++;
				obj5 += 8;
				if ((nint)obj4 >= 0)
				{
					return;
				}
				continue;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	public unsafe void Read(out bool value)
	{
		//IL_001f: Expected VT, but got I4
		Read(out NetworkBool _, 4);
		bool flag = (NetworkBool)0;
		ref bool reference = ref *(flag ? ((bool*)1) : ((bool*)null));
	}

	public unsafe void Read(out bool[] value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj2 = 0;
		Read(out int value2, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = default;
		ref bool[] reference = ref *(bool[]*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (value2 < 1)
		{
			return;
		}
		object obj4 = 32;
		while (true)
		{
			Read(out NetworkBool value3, 4);
			bool[] array = value;
			bool flag = value3;
			if (value != null)
			{
				object obj5 = obj4 - 32;
				bool flag2 = (nint)obj5 < array.Length;
				object obj6 = !flag2;
				if (obj6 != null)
				{
					break;
				}
				object obj7 = obj4 - 31;
				object obj8 = obj4 + 1;
				bool flag3 = (nint)obj7 < value2;
				obj4 = obj8;
				if (!flag3)
				{
					return;
				}
				continue;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}
}
