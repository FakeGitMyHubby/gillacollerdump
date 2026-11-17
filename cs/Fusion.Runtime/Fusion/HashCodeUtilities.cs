using System;
using Cpp2ILInjected;

namespace Fusion;

internal static class HashCodeUtilities
{
	public const int InitialHash = default(int);

	public static int GetHashDeterministic(string str, int initialHash = default(int))
	{
		//IL_004a: Expected I4, but got Obj
		if (str != null)
		{
			return GetHashDeterministicInternal(str, str._stringLength, initialHash);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	internal static int GetHashDeterministicInternal(string str, int len, int initialHash)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected I4, but got Unknown
		//IL_00ff: Expected I4, but got Obj
		//IL_013d: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected I4, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected I4, but got Unknown
		object obj = len - 1;
		int num;
		int num3;
		if (len >= 1)
		{
			if (str == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			num = initialHash;
			int num2 = 0;
			num3 = initialHash;
			do
			{
				char c = str.get_Chars(num2);
				object obj2 = num3 + num3;
				int num4 = c & 0xFFFF;
				bool flag = num2 == (nint)obj;
				num3 = obj2 ^ num4;
				if (flag)
				{
					break;
				}
				int index = num2 + 1;
				char c2 = str.get_Chars(index);
				object obj3 = num + num;
				num2 += 2;
				int num5 = c2 & 0xFFFF;
				num = obj3 ^ num5;
			}
			while (num2 < len);
		}
		else
		{
			num = initialHash;
			num3 = initialHash;
		}
		object obj4 = num * 1566083941;
		return num3 + obj4;
	}

	public static int CombineHashCodes(int a, int b)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		object obj = a + a;
		return obj ^ b;
	}

	public static int CombineHashCodes(int a, int b, int c)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		object obj = a + a;
		int num = obj ^ b;
		object obj2 = num + num;
		return obj2 ^ c;
	}

	public unsafe static int GetArrayHashCode<T>(T* ptr, int length, int initialHash = default(int)) where T : struct
	{
		//IL_0059: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		bool flag = length < 1;
		int result = initialHash;
		if (!flag)
		{
			int num = length;
			T* ptr2 = ptr;
			do
			{
				int hashCode = ((byte*)ptr2)->GetHashCode();
				object obj = hashCode - initialHash;
				num--;
				ptr2 = (T*)((byte*)ptr2 + 1);
				result = obj + initialHash;
			}
			while (num != 1);
		}
		return result;
	}

	public static int GetHashCodeDeterministic(byte[] data, int initialHash = default(int))
	{
		//IL_00f5: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I8
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		int num = default;
		if (data != null)
		{
			if (data.Length < 1)
			{
				goto IL_00d4;
			}
			object obj = ~data.Length;
			object obj2 = data.Length & obj;
			object obj3 = data.Length & 0xFFFFFFFFL;
			object obj4 = data + 32;
			while (obj3 != null)
			{
				obj4++;
				obj3--;
				object obj5 = obj4 - num;
				num = obj5 + num;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00d4;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_00d4:
		return num;
	}

	public static int GetHashCodeDeterministic(string data, int initialHash = default(int))
	{
		//IL_0068: Expected I4, but got Obj
		//IL_00a2: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected I4, but got Unknown
		if (data != null)
		{
			bool flag = data._stringLength < 1;
			int result = initialHash;
			if (!flag)
			{
				int num = 0;
				do
				{
					char c = data.get_Chars(num);
					int num2 = initialHash << 5;
					num++;
					object obj = num2 - initialHash;
					result = (int)(obj + c);
				}
				while (num < data._stringLength);
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int GetHashCodeDeterministic<T>(T data, int initialHash = default(int)) where T : struct
	{
		//IL_0022: Expected Obj, but got I
		nint num = 0;
		object obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v41 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public unsafe static int GetHashCodeDeterministic<T>(T* data, int initialHash = default(int)) where T : struct
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		object obj = 0;
		object obj2 = default;
		obj = obj2;
		int num = default;
		do
		{
			obj++;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X0 (T*)+v34 @ X8_v2]");
			object obj3 = -num;
			num = obj3 + num;
		}
		while ((nint)obj != 192);
		return num;
	}
}
