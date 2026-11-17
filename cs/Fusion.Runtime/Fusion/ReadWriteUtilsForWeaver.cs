using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Fusion.Async;

namespace Fusion;

public static class ReadWriteUtilsForWeaver
{
	private const float ACCURACY = default(float);

	private const int STRING_LENGTH_INDEX = default(int);

	private const int STRING_HASHCODE_INDEX = default(int);

	private const int STRING_DATA_INDEX = default(int);

	private const int STRING_NOHASHCODE_DATA_INDEX = default(int);

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static bool ReadBoolean(int* data)
	{
		bool flag = data == null;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void WriteBoolean(int* data, bool value)
	{
		int* ptr = (int*)(value ? 1 : 0);
	}

	public unsafe static int GetByteArrayHashCode(byte* ptr, int length)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @362FF80");
		int result = default;
		return result;
	}

	public unsafe static int WriteStringUtf8NoHash(void* destination, string str)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0104: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00db: Expected I4, but got Obj
		object obj;
		if (str != null)
		{
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			obj = str + offsetToStringData;
		}
		else
		{
			obj = null;
		}
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			int count = default;
			CancellationToken cancellationToken = default;
			Task task = ((Stream)(object)uTF).WriteAsync((byte[])(object)str, 0, count, cancellationToken);
			Encoding uTF2 = Encoding.UTF8;
			if (str != null && uTF2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4208]");
				object format = 0;
				bool flag = ((object)uTF2).Equals(obj);
				object obj2 = task - flag;
				bool condition = obj2 == null;
				Assert.Check(condition, (string)format, (int)task, flag ? 1 : 0);
				int result = (flag ? 1 : 0) + 4;
				void* ptr = (void*)(flag ? 1 : 0);
				return result;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public unsafe static int ReadStringUtf8NoHash(void* source, out string result)
	{
		//IL_0081: Expected I4, but got Obj
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			byte* bytes = (byte*)source + 4;
			string text = uTF.GetString(bytes, (int)source);
			ref string reference = ref *(string*)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (int)((byte*)source + 4);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int GetByteCountUtf8NoHash(string value)
	{
		//IL_0062: Expected I4, but got Obj
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			int count = default;
			CancellationToken cancellationToken = default;
			Task task = ((Stream)(object)uTF).WriteAsync((byte[])(object)value, 0, count, cancellationToken);
			return task + 4;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int GetStringHashCode(string value, int maxLength)
	{
		//IL_00a0: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		if (value != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int len = Math.Min(value._stringLength, maxLength);
			return HashCodeUtilities.GetHashDeterministicInternal(value, len, 352654597);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public unsafe static int WriteStringUtf32NoHash(int* ptr, int maxLength, string value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_002c: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E40]");
		object error = 0;
		int num = ~maxLength;
		bool condition = (byte)(num >> 31) != 0;
		Assert.Always(condition, (string)error);
		string text = (string)(maxLength + 1);
		bool flag = (nint)text < 0;
		object obj = !flag;
		if (obj == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		return WriteStringUtf32NoHash((Span<int>)ptr, text);
	}

	public static int WriteStringUtf32NoHash(Span<int> ptr, string value)
	{
		//IL_01c1: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_01b8: Expected I4, but got Obj
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected VT, but got Unknown
		//IL_0152: Expected Obj, but got I
		//IL_002b: Expected VT, but got I4
		//IL_0181: Expected Obj, but got VT
		//IL_0197: Expected VT, but got Obj
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected I4, but got Unknown
		IntPtr intPtr = default;
		if (string.IsNullOrEmpty((string)(nint)intPtr))
		{
			if (value != null)
			{
				Span<int> span = (Span<int>)0;
				return 4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
			object obj = 0;
			object obj2 = obj;
			bool flag = value == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X23_v4+20]");
			object obj4 = (nint)0 + (nint)309;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E48]");
			object obj5 = 0;
			object obj6 = obj4 & 1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+38]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			Span<uint> dst = (Span<uint>)(ptr + 4);
			TaskManager._003C_003Ec__DisplayClass10_0.ConversionResult conversionResult = UTF32Tools.Convert((string)(nint)intPtr, dst);
			if (value != null)
			{
				object obj10 = conversionResult >> 32;
				object obj11 = obj10 << 2;
				Span<int> span = (Span<int>)obj10;
				return obj11 + 4;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
	}

	public unsafe static int ReadStringUtf32NoHash(int* ptr, int maxLength, out string result)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_002c: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E40]");
		object error = 0;
		int num = ~maxLength;
		bool condition = (byte)(num >> 31) != 0;
		Assert.Always(condition, (string)error);
		ref string reference = ref *(string*)(maxLength + 1);
		bool flag = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) < unchecked((nint)null);
		object obj = !flag;
		if (obj == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		return ReadStringUtf32NoHash((ReadOnlySpan<int>)ptr, out reference);
	}

	public unsafe static int ReadStringUtf32NoHash(ReadOnlySpan<int> ptr, out string result)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I8
		//IL_0210: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_01dc: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_010e: Expected I4, but got VT
		//IL_01ae: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E68]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref result) & 0xFFFFFFFFL;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		int val = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 4294967295L));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X23_v2+20]");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = Math.Min((int)ptr, val);
			nint num3;
			if (num != 0)
			{
				ReadOnlySpan<int> readOnlySpan = default;
				ref int reference = ref readOnlySpan.GetPinnableReference();
				Encoding uTF = Encoding.UTF32;
				int num2 = num << 2;
				string text = ((string)null).CreateString((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), 0, num2, uTF);
				num3 = (nint)text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return num2 + 4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj11 = 0;
			num3 = (nint)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return 4;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
	}

	public unsafe static int WriteStringUtf32WithHash(int* ptr, int maxLength, string value, ref string cache)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_0030: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E40]");
		object error = 0;
		int num = ~maxLength;
		bool condition = (byte)(num >> 31) != 0;
		Assert.Always(condition, (string)error);
		string text = (string)(maxLength + 2);
		bool flag = (nint)text < 0;
		object obj = !flag;
		if (obj == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		return WriteStringUtf32WithHash((Span<int>)ptr, text, ref *(string*)value);
	}

	public unsafe static int WriteStringUtf32WithHash(Span<int> ptr, string value, ref string cache)
	{
		//IL_038a: Expected Obj, but got Ref
		//IL_0076: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected VT, but got Unknown
		//IL_01aa: Expected Obj, but got Ref
		//IL_0381: Expected I4, but got Obj
		//IL_003a: Expected VT, but got I4
		//IL_01d9: Expected Obj, but got VT
		//IL_01e1: Expected VT, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_02a3: Invalid comparison between I and VT
		//IL_030f: Expected Obj, but got I4
		//IL_02cc: Expected I4, but got VT
		//IL_02cc: Expected Obj, but got Ref
		//IL_02d8: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I4
		//IL_02e9: Expected I4, but got VT
		//IL_033b: Expected Obj, but got I
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected I4, but got Unknown
		if (string.IsNullOrEmpty((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cache)))
		{
			if (value != null)
			{
				bool flag = (nint)value == 1;
				Span<int> span = (Span<int>)0;
				if (!flag)
				{
					_ = 0;
					return 8;
				}
			}
		}
		else
		{
			bool flag2 = (nint)value < 1;
			object obj = !flag2;
			object obj2 = value - 1;
			bool flag3 = obj2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = !flag3;
			object obj6 = obj & obj5;
			if (obj6 == null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X24_v5+20]");
			object obj7 = (nint)0 + (nint)309;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E48]");
			object obj8 = 0;
			object obj9 = obj7 & 1;
			bool flag4 = obj9 == null;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v12+38]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			Span<uint> dst = (Span<uint>)(ptr + 8);
			TaskManager._003C_003Ec__DisplayClass10_0.ConversionResult conversionResult = UTF32Tools.Convert((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cache), dst);
			if (value != null)
			{
				object obj13 = conversionResult >> 32;
				Span<int> span = (Span<int>)obj13;
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref cache) == null)
				{
					goto IL_0373;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E70]");
				object error = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cache @ X2 (System.String&)+10]");
				object obj14 = 0 - conversionResult;
				bool flag6 = (nint)obj14 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cache @ X2 (System.String&)+10]");
				object obj15 = 0 ^ conversionResult;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cache @ X2 (System.String&)+10]");
				object obj16 = 0 ^ obj14;
				object obj17 = obj15 & obj16;
				bool flag7 = (nint)obj17 < 0;
				bool condition = flag6 == flag7;
				Assert.Check(condition, (string)error);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cache @ X2 (System.String&)+10]");
				nint num;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) > System.Runtime.CompilerServices.Unsafe.As<TaskManager._003C_003Ec__DisplayClass10_0.ConversionResult, UIntPtr>(ref conversionResult))
				{
					string text = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cache)).Substring(0, (int)conversionResult);
					num = (nint)text;
					object obj18 = 0;
					int num2 = (int)conversionResult;
					ref string reference = ref *(string*)text;
					IntPtr intPtr = num;
				}
				else
				{
					num = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cache);
					object obj18 = 0;
					int num2 = 0;
					ref string reference = ref cache;
					IntPtr intPtr = num;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((nint)value != 1)
				{
					int hashDeterministic = HashCodeUtilities.GetHashDeterministic((string)num, 352654597);
					object obj19 = obj13 << 2;
					return obj19 + 8;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0373;
		IL_0373:
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
	}

	public unsafe static int ReadStringUtf32WithHash(int* ptr, int maxLength, ref string cache)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_002c: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E40]");
		object error = 0;
		int num = ~maxLength;
		bool condition = (byte)(num >> 31) != 0;
		Assert.Always(condition, (string)error);
		ref string reference = ref *(string*)(maxLength + 2);
		bool flag = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) < unchecked((nint)null);
		object obj = !flag;
		if (obj == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		return ReadStringUtf32WithHash((ReadOnlySpan<int>)ptr, ref reference);
	}

	public unsafe static int ReadStringUtf32WithHash(ReadOnlySpan<int> ptr, ref string cache)
	{
		//IL_043e: Expected Obj, but got I8
		//IL_042c: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected VT, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_00fc: Expected I4, but got VT
		//IL_03ed: Expected Obj, but got I
		//IL_03fd: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_03c7: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01c1: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0314: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I4
		//IL_049d: Expected VT, but got Ref
		//IL_049d: Expected Obj, but got I
		object obj = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cache) & 0xFFFFFFFEL;
		int num3;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E68]");
			object obj2 = 0;
			int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref cache, 4294967294L));
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+20]");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			ReadOnlySpan<int> span = (ReadOnlySpan<int>)(ptr + 8);
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num2 = Math.Min((int)ptr, num);
			num3 = num2 << 2;
			if (num2 != 0)
			{
				nint num4 = default;
				object obj10 = num4;
				if (num4 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v14+10]");
					bool flag3 = (nint)0 < (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v14+10]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v14+10]");
					object obj11 = num5 ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v14+10]");
					object obj12 = 0 & obj11;
					bool flag4 = (nint)obj12 < 0;
					bool flag5 = flag3 == flag4;
					object obj13 = !flag5;
					object obj14 = ~obj13;
					object obj15;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v14+10]");
						obj15 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v14+10]");
						obj15 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v14+10]");
					if ((nint)num2 <= (nint)0)
					{
						object obj16 = obj15 >> 1;
						if (num2 >= (nint)obj16)
						{
							object obj17 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X8_v17+158] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ptr @ X0 (System.ReadOnlySpan`1<System.Int32>)+4]");
							object obj18 = default;
							if (0 == (nint)obj18)
							{
								object obj19 = obj2;
								bool flag6 = num2 < num;
								object obj20 = !flag6;
								object obj21 = num2 - num;
								bool flag7 = obj21 == null;
								object obj22 = ~obj20;
								object obj23 = obj22 | flag7;
								if (obj23 == null)
								{
									System.ThrowHelper.ThrowArgumentOutOfRangeException();
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X25_v7+20]");
								object obj24 = (nint)0 + (nint)309;
								object obj25 = obj24 & 1;
								bool flag8 = obj25 == null;
								object obj26 = !flag8;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D31C8]");
								object obj27 = 0;
								object obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X25_v8+38]");
								bool flag9 = (nint)0 == 0;
								object obj29 = !flag9;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
								}
								if (UTF32Tools.CompareOrdinal((string)num4, (ReadOnlySpan<uint>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref MemoryMarshal.GetReference(span)), (byte)num2 != 0) == 0)
								{
									goto IL_040b;
								}
							}
						}
					}
				}
				ReadOnlySpan<int> readOnlySpan = default;
				ref int reference = ref readOnlySpan.GetPinnableReference();
				Encoding uTF = Encoding.UTF32;
				string text = ((string)null).CreateString((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), 0, num3, uTF);
				num4 = (nint)text;
				int num6 = 0;
				string text2 = text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj30 = 0;
				string text2 = (string)obj30;
				nint num4 = (nint)obj30;
				int num6 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_040b;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_040b:
		return num3 + 8;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static int GetWordCountString(int capacity, bool withCaching)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected I4, but got Unknown
		//IL_0040: Expected Obj, but got I4
		bool flag = !withCaching;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = ((obj2 != null) ? ((object)1) : ((object)(1 + 1)));
		return obj3 + capacity;
	}

	public static int VerifyRawNetworkUnwrap<T>(int actual, int maxBytes)
	{
		//IL_0045: Expected Obj, but got I
		//IL_0056: Expected VT, but got I
		//IL_00f0: Expected I4, but got Obj
		if (actual <= maxBytes)
		{
			return actual;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Type[] genericArguments = ((System.RuntimeType)typeFromHandle).GetGenericArguments();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format = default;
		object arg = default;
		object arg2 = default;
		string message = string.Format(format, genericArguments, arg, arg2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
	}

	public static int VerifyRawNetworkWrap<T>(int actual, int maxBytes)
	{
		//IL_0045: Expected Obj, but got I
		//IL_0056: Expected VT, but got I
		//IL_00f0: Expected I4, but got Obj
		if (actual <= maxBytes)
		{
			return actual;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Type[] genericArguments = ((System.RuntimeType)typeFromHandle).GetGenericArguments();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format = default;
		object arg = default;
		object arg2 = default;
		string message = string.Format(format, genericArguments, arg, arg2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
	}
}
