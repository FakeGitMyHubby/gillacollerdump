using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;

namespace Fusion;

internal struct RpcDataWriter(Span<byte> data)
{
	private readonly Span<byte> _data = data;

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

	private Span<byte> GetAndAdvanceData(int bytes)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3208]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.RpcDataWriter)+8]");
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
		Span<byte> result = (Span<byte>)(_data + _offset);
		object obj10 = bytes + _offset;
		object obj11 = obj10 + 3;
		int offset = (int)(obj11 & 0xFFFFFFFCL);
		_offset = offset;
		return result;
	}

	public void Write<T>(T value, int size) where T : struct
	{
		Span<byte> andAdvanceData = GetAndAdvanceData(size);
		andAdvanceData = (Span<byte>)value;
	}

	public void Write<T>(T[] value, int elementSize) where T : struct
	{
		//IL_0029: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D50]");
		object obj = 0;
		Write(value.Length, 4);
		int bytes = value.Length * elementSize;
		Span<byte> andAdvanceData = GetAndAdvanceData(bytes);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ X2_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		nint num2 = 0;
		object obj2 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v72 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void Write<T>(ReadOnlySpan<T> value, int elementSize) where T : struct
	{
		//IL_0010: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected I4, but got Unknown
		//IL_012d: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
				obj = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v2+8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ X1_v1] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D50]");
		object obj5 = 0;
		int value2 = default;
		Write(value2, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ X1_v3] (should have been resolved before IL gen)");
		object obj8 = default;
		IntPtr intPtr = default;
		int bytes = (int)(obj8 * (nint)intPtr);
		Span<byte> andAdvanceData = GetAndAdvanceData(bytes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ X2_v3] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X4+38]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v10+28]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ X3_v2] (should have been resolved before IL gen)");
	}

	public void WriteCount<T>(T[] array)
	{
		Write(array.Length, 4);
	}

	public void Write(string value)
	{
		//IL_0045: Expected I4, but got Obj
		//IL_006a: Expected I4, but got I8
		//IL_009b: Expected I4, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00f3: Expected I4, but got Obj
		if (value != null)
		{
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
		}
		Encoding uTF = Encoding.UTF8;
		int count = default;
		CancellationToken cancellationToken = default;
		Task task = ((Stream)(object)uTF).WriteAsync((byte[])(object)value, 0, count, cancellationToken);
		Write((int)task, 4);
		Encoding uTF2 = Encoding.UTF8;
		if ((int)(value._stringLength & 0x80000000L) != 0)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Span<byte> andAdvanceData = GetAndAdvanceData((int)task);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A28]");
		object format = 0;
		int outputBlockSize = ((HashAlgorithm)(object)uTF2).OutputBlockSize;
		object obj = task - outputBlockSize;
		bool condition = obj == null;
		Assert.Check(condition, (string)format, (int)task, outputBlockSize);
	}

	public void Write(bool value)
	{
		NetworkBool value2 = value;
		Write(value2, 4);
	}

	public void Write(bool[] value)
	{
		//IL_004a: Expected Obj, but got I8
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		Write(value.Length, 4);
		if (value.Length < 1)
		{
			return;
		}
		object obj = value.Length & 0xFFFFFFFFL;
		object obj2 = value + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4+v93 @ X21_v6]");
			NetworkBool value2 = false;
			Write(value2, 4);
			obj = value.Length;
			obj3++;
			if ((nint)obj3 >= value.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public void Write(string[] value)
	{
		//IL_004a: Expected Obj, but got I8
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		Write(value.Length, 4);
		if (value.Length < 1)
		{
			return;
		}
		object obj = value.Length & 0xFFFFFFFFL;
		object obj2 = value + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v4+v84 @ X21_v6*8]");
			Write((string)0);
			obj = value.Length;
			obj3++;
			if ((nint)obj3 >= value.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static int GetBytePayloadSize(int size)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		object obj = size + 3;
		return (int)(obj & 0xFFFFFFFCL);
	}

	public static int GetBytePayloadSize(int count, int elementSize)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		object obj = elementSize * count;
		object obj2 = 7 + obj;
		return (int)(obj2 & 0xFFFFFFFCL);
	}

	public static int GetPayloadSize(string str)
	{
		//IL_0074: Expected I4, but got Obj
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			int count = default;
			CancellationToken cancellationToken = default;
			Task task = ((Stream)(object)uTF).WriteAsync((byte[])(object)str, 0, count, cancellationToken);
			object obj = task + 7;
			return (int)(obj & 0xFFFFFFFCL);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int GetPayloadSize(string[] strings)
	{
		//IL_00fc: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I8
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		int num;
		if (strings != null)
		{
			if (strings.Length < 1)
			{
				num = 4;
				goto IL_0123;
			}
			object obj = strings.Length & 0xFFFFFFFFL;
			object obj2 = strings + 32;
			num = 4;
			object obj3 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X22_v4+v32 @ X21_v5*8]");
				int payloadSize = GetPayloadSize((string)0);
				obj = strings.Length;
				obj3++;
				num = payloadSize + num;
				if ((nint)obj3 < strings.Length)
				{
					continue;
				}
				goto IL_0123;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_0123:
		return num;
	}

	public static int GetPayloadSize(bool value)
	{
		return 4;
	}

	public static int GetPayloadSize(bool[] value)
	{
		//IL_004e: Expected I4, but got Obj
		//IL_002d: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected I4, but got Unknown
		if (value != null)
		{
			object obj = value.Length << 2;
			return obj + 4;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
