using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal static class ArraySpecialized
{
	private const int IntrosortSizeThreshold = default(int);

	private static int FloorLog2(int n)
	{
		//IL_0061: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		int num = default;
		int num2;
		if (num >= 1)
		{
			num2 = 0;
			int num3 = default;
			num2 = num3;
			object obj4;
			do
			{
				bool flag = num < 1;
				object obj = !flag;
				object obj2 = num - 1;
				bool flag2 = obj2 == null;
				num2++;
				object obj3 = !flag2;
				obj4 = obj & obj3;
			}
			while (obj4 != null);
		}
		else
		{
			num2 = 0;
		}
		return num2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private static void Swap<T>(T[] a, int i, int j)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AC0]");
		object error = 0;
		object obj = i - j;
		bool flag = obj == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		bool flag2 = a.Length < i;
		object obj2 = !flag2;
		object obj3 = a.Length - i;
		bool flag3 = obj3 == null;
		object obj4 = ~obj2;
		object obj5 = obj4 | flag3;
		if (obj5 == null)
		{
			bool flag4 = a.Length < j;
			object obj6 = !flag4;
			object obj7 = a.Length - j;
			bool flag5 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag5;
			if (obj9 == null)
			{
				object obj10 = a + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+j @ X2 (System.Int32)*4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+i @ X1 (System.Int32)*4]");
				_ = 0;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Sort(int[] array, int index, int length)
	{
		//IL_0027: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected I4, but got Unknown
		//IL_004b: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		if (length < 2)
		{
			return;
		}
		object obj = array.Length;
		int depthLimit;
		if (array.Length >= 1)
		{
			nint num = unchecked((nint)null);
			IntPtr intPtr = default;
			num = intPtr;
			object obj2 = default;
			obj = obj2;
			object obj6;
			do
			{
				bool flag = (nint)obj < 1;
				object obj3 = !flag;
				object obj4 = obj - 1;
				bool flag2 = obj4 == null;
				num += 2;
				object obj5 = !flag2;
				obj6 = obj3 & obj5;
			}
			while (obj6 != null);
			depthLimit = (int)num;
		}
		else
		{
			depthLimit = 0;
		}
		object obj7 = index + length;
		int hi = obj7 - 1;
		IntroSort(array, index, hi, depthLimit);
	}

	[MethodImpl((MethodImplOptions)256)]
	private static int Compare(int x, int y)
	{
		return x - y;
	}

	private static void SwapIfGreater(int[] array, int a, int b)
	{
		//IL_0037: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I
		if (a == b)
		{
			return;
		}
		bool flag = array.Length < a;
		object obj = !flag;
		object obj2 = array.Length - a;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			bool flag3 = array.Length < b;
			object obj5 = !flag3;
			object obj6 = array.Length - b;
			bool flag4 = obj6 == null;
			object obj7 = ~obj5;
			object obj8 = obj7 | flag4;
			if (obj8 == null)
			{
				object obj9 = array + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v4+a @ X1 (System.Int32)*4]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v4+b @ X2 (System.Int32)*4]");
				object obj10 = num - 0;
				if ((nint)obj10 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v4+b @ X2 (System.Int32)*4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v4+a @ X1 (System.Int32)*4]");
					_ = 0;
				}
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static void IntroSort(int[] array, int lo, int hi, int depthLimit)
	{
		//IL_01b9: Expected Obj, but got I4
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I4
		int num = default;
		if (hi <= num)
		{
			return;
		}
		int num3 = default;
		int num2 = num3 - 1;
		int num4 = hi;
		int num7 = default;
		while (true)
		{
			object obj = num4 - num;
			object obj2 = obj + 1;
			if ((nint)obj2 > 16)
			{
				object obj3 = num2 + 1;
				if (obj3 == null)
				{
					break;
				}
				int num5 = PickPivotAndPartition(array, num, num4);
				int lo2 = num5 + 1;
				IntroSort(array, lo2, num4, num2);
				num4 = num5 - 1;
				int num6 = num2 - 1;
				bool flag = num4 > num;
				num2 = num6;
				if (!flag)
				{
					return;
				}
				continue;
			}
			if (num4 == num)
			{
				return;
			}
			int[] array2;
			if ((nint)obj != 2)
			{
				bool flag2 = (nint)obj == 1;
				array2 = array;
				if (!flag2)
				{
					InsertionSort(array, num, num4);
					return;
				}
			}
			else
			{
				num7 = num4 - 1;
				SwapIfGreater(array, num, num7);
				SwapIfGreater(array, num, num4);
				array2 = array;
			}
			SwapIfGreater(array2, num7, num4);
			return;
		}
		Heapsort(array, num, num4);
	}

	private static int PickPivotAndPartition(int[] array, int lo, int hi)
	{
		//IL_02c4: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected I4, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_02b7: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_039d: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I4
		//IL_03da: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_042b: Expected Obj, but got I4
		//IL_04f0: Expected Obj, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_049e: Expected Obj, but got I4
		//IL_04b9: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		object obj = hi - lo;
		bool flag = (nint)obj < 0;
		object obj2 = obj ^ obj;
		object obj3 = obj & obj2;
		bool flag2 = (nint)obj3 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			obj++;
		}
		int num = lo + obj;
		SwapIfGreater(array, lo, num);
		SwapIfGreater(array, lo, hi);
		SwapIfGreater(array, num, hi);
		object obj8;
		object error;
		int num2;
		if (array != null)
		{
			bool flag4 = num < array.Length;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				object obj7 = array + num;
				obj8 = hi - 1;
				object obj9 = obj7 + 32;
				object obj10 = num - obj8;
				bool flag5 = obj10 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AC0]");
				error = 0;
				bool condition = !flag5;
				Assert.Check(condition, (string)error);
				object obj11 = array.Length;
				bool flag6 = num < array.Length;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					bool flag7 = (nint)obj8 < array.Length;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						object obj14 = (object)array + obj8;
						object obj15 = obj14 + 32;
						obj9 = obj15;
						obj15 = obj9;
						bool flag8 = (nint)obj8 <= lo;
						num2 = lo;
						if (flag8)
						{
							goto IL_03e8;
						}
						object obj16 = obj8;
						num2 = lo;
						while (true)
						{
							num2++;
							bool flag9 = num2 < (nint)obj11;
							object obj17 = !flag9;
							if (obj17 != null)
							{
								break;
							}
							object obj18 = array + num2;
							object obj19 = obj18 + 32;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
							{
								continue;
							}
							object obj20 = obj16 - 1;
							object obj23;
							while (true)
							{
								bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
								object obj21 = !flag10;
								if (obj21 != null)
								{
									break;
								}
								object obj22 = (object)array + obj20;
								obj20--;
								obj23 = obj22 + 32;
								object obj24 = obj9 - obj23;
								object obj25 = obj24 & 0x80000000L;
								bool flag11 = obj25 == null;
								object obj26 = !flag11;
								if (obj26 != null)
								{
									continue;
								}
								goto IL_01d6;
							}
							break;
							IL_01d6:
							obj16 = obj20 + 1;
							if (num2 < (nint)obj16)
							{
								object obj27 = num2 - obj20;
								bool flag12 = obj27 == null;
								bool condition2 = !flag12;
								Assert.Check(condition2, (string)error);
								obj11 = array.Length;
								bool flag13 = num2 < array.Length;
								object obj28 = !flag13;
								if (obj28 != null)
								{
									break;
								}
								bool flag14 = (nint)obj16 < array.Length;
								object obj29 = !flag14;
								if (obj29 != null)
								{
									break;
								}
								obj19 = obj23;
								obj23 = obj19;
								continue;
							}
							goto IL_03e8;
						}
					}
				}
			}
			goto IL_029b;
		}
		goto IL_02a9;
		IL_029b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_02a9;
		IL_02a9:
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_04fe:
		return num2;
		IL_03e8:
		if (num2 != (nint)obj8)
		{
			Assert.Check(condition: true, (string)error);
			bool flag15 = num2 < array.Length;
			object obj30 = !flag15;
			if (obj30 == null)
			{
				bool flag16 = (nint)obj8 < array.Length;
				object obj31 = !flag16;
				if (obj31 == null)
				{
					object obj32 = array + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v16+20]");
					object obj15 = 0;
					goto IL_04fe;
				}
			}
			goto IL_029b;
		}
		goto IL_04fe;
	}

	private static void Heapsort(int[] array, int lo, int hi)
	{
		//IL_01a7: Expected Obj, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected I4, but got Unknown
		//IL_020f: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected I4, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		object obj = hi - lo;
		int num = obj + 1;
		if (num < 2)
		{
			return;
		}
		int num2 = num >> 1;
		object obj5;
		do
		{
			DownHeap(array, num2, num, lo);
			num2--;
			bool flag = num2 < 1;
			object obj2 = !flag;
			object obj3 = num2 - 1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			obj5 = obj2 & obj4;
		}
		while (obj5 != null);
		if (num < 2)
		{
			return;
		}
		object obj6 = num + 1;
		object obj7 = array + lo;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AC0]");
		object error = 0;
		object obj8 = -lo;
		int num3 = hi;
		while (true)
		{
			object obj9 = lo - num3;
			bool flag3 = obj9 == null;
			bool condition = !flag3;
			Assert.Check(condition, (string)error);
			bool flag4 = array.Length < lo;
			object obj10 = !flag4;
			object obj11 = array.Length - lo;
			bool flag5 = obj11 == null;
			object obj12 = ~obj10;
			object obj13 = obj12 | flag5;
			if (obj13 != null)
			{
				break;
			}
			bool flag6 = num3 < array.Length;
			object obj14 = !flag6;
			if (obj14 != null)
			{
				break;
			}
			object obj15 = array + num3;
			int n = obj8 + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v9+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X23_v6+20]");
			_ = 0;
			DownHeap(array, 1, n, lo);
			obj6--;
			num3--;
			if ((nint)obj6 <= 2)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static void DownHeap(int[] array, int i, int n, int lo)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected I4, but got Unknown
		object obj = lo - 1;
		int num = default;
		object obj2 = obj + num;
		bool flag = (nint)obj2 < array.Length;
		object obj3 = !flag;
		if (obj3 == null)
		{
			bool flag2 = n < 0;
			int num2 = n ^ n;
			int num3 = n & num2;
			bool flag3 = num3 < 0;
			object obj4 = (object)array + obj2;
			bool flag4 = flag2 == flag3;
			object obj5 = !flag4;
			object obj6 = ~obj5;
			int num4 = ((obj6 != null) ? n : (n + 1));
			int num5 = num4 >> 1;
			if (num5 < num)
			{
				goto IL_02f8;
			}
			int num6 = default;
			while (true)
			{
				num6 <<= 1;
				if (num6 < n)
				{
					object obj7 = num6 + lo;
					object obj8 = obj7 - 1;
					bool flag5 = (nint)obj8 < array.Length;
					object obj9 = !flag5;
					if (obj9 != null)
					{
						break;
					}
					bool flag6 = (nint)obj7 < array.Length;
					object obj10 = !flag6;
					if (obj10 != null)
					{
						break;
					}
					object obj11 = array + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X15_v7+v108 @ X14_v7*4]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X15_v7+v158 @ X13_v11*4]");
					object obj12 = num7 - 0;
					num6 |= obj12;
				}
				object obj13 = obj + num6;
				bool flag7 = (nint)obj13 < array.Length;
				object obj14 = !flag7;
				if (obj14 != null)
				{
					break;
				}
				object obj15 = (object)array + obj13;
				obj2 = obj + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X12_v3+20]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X13_v7+20]");
				if (num8 < 0)
				{
					bool flag8 = (nint)obj2 < array.Length;
					object obj16 = !flag8;
					if (obj16 != null)
					{
						break;
					}
					object obj17 = (object)array + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X13_v7+20]");
					_ = 0;
					if (num6 <= num5)
					{
						continue;
					}
					obj2 = obj13;
				}
				goto IL_02f8;
			}
		}
		goto IL_0283;
		IL_0283:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_02f8:
		bool flag9 = (nint)obj2 < array.Length;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			object obj19 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X12_v3+20]");
			_ = 0;
			return;
		}
		goto IL_0283;
	}

	private static void InsertionSort(int[] array, int lo, int hi)
	{
		//IL_01fe: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		if (lo >= hi)
		{
			return;
		}
		int num = lo;
		object obj4 = default;
		while (true)
		{
			int num2 = num + 1;
			bool flag = num2 < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				break;
			}
			object obj2 = array + num2;
			bool flag2 = num < lo;
			object obj3 = obj4;
			int num3 = num;
			if (!flag2)
			{
				while (true)
				{
					bool flag3 = num < array.Length;
					object obj5 = !flag3;
					if (obj5 != null)
					{
						break;
					}
					object obj6 = array + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X13_v5+20]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X14_v7+20]");
					bool flag4 = num4 >= 0;
					obj3 = obj4;
					num3 = num;
					if (!flag4)
					{
						object obj7 = num + 1;
						num--;
						obj4 = (object)array + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X14_v7+20]");
						_ = 0;
						bool flag5 = num >= lo;
						obj3 = obj4;
						num3 = num;
						if (flag5)
						{
							continue;
						}
					}
					goto IL_013f;
				}
				break;
			}
			goto IL_013f;
			IL_013f:
			object obj8 = num3 + 1;
			bool flag6 = (nint)obj8 < array.Length;
			object obj9 = !flag6;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = (object)array + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X13_v5+20]");
			_ = 0;
			bool flag7 = num2 != hi;
			obj4 = obj3;
			num = num2;
			if (!flag7)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Sort(SimulationInput[] array, int index, int length)
	{
		//IL_0027: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected I4, but got Unknown
		//IL_004b: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		if (length < 2)
		{
			return;
		}
		object obj = array.Length;
		int depthLimit;
		if (array.Length >= 1)
		{
			nint num = unchecked((nint)null);
			IntPtr intPtr = default;
			num = intPtr;
			object obj2 = default;
			obj = obj2;
			object obj6;
			do
			{
				bool flag = (nint)obj < 1;
				object obj3 = !flag;
				object obj4 = obj - 1;
				bool flag2 = obj4 == null;
				num += 2;
				object obj5 = !flag2;
				obj6 = obj3 & obj5;
			}
			while (obj6 != null);
			depthLimit = (int)num;
		}
		else
		{
			depthLimit = 0;
		}
		object obj7 = index + length;
		int hi = obj7 - 1;
		IntroSort(array, index, hi, depthLimit);
	}

	[MethodImpl((MethodImplOptions)256)]
	private static int Compare(SimulationInput x, SimulationInput y)
	{
		//IL_0082: Expected I4, but got Obj
		if (x != null)
		{
			ref SimulationInputHeader header = ref x.Header;
			if (y != null)
			{
				return System.Runtime.CompilerServices.Unsafe.As<SimulationInputHeader, Tick>(ref header).CompareTo((Tick)y.Header);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private static void SwapIfGreater(SimulationInput[] array, int a, int b)
	{
		//IL_005c: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_025d: Expected I4, but got VT
		//IL_0286: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02d0: Expected I4, but got VT
		//IL_02fa: Expected I4, but got VT
		//IL_04eb: Expected Obj, but got I4
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0310: Expected I, but got Obj
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_03a3: Expected I4, but got Obj
		//IL_0424: Expected Obj, but got I4
		//IL_0433: Expected Obj, but got I4
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_035a: Expected Obj, but got I4
		//IL_03b9: Expected I, but got Obj
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		int num = default;
		if (a == num)
		{
			return;
		}
		bool flag = array == null;
		int num2 = a;
		int num3 = default;
		NullReferenceException ex = default;
		int num6;
		if (!flag)
		{
			bool flag2 = array.Length < a;
			object obj = !flag2;
			object obj2 = array.Length - a;
			bool flag3 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag3;
			num3 = num;
			num2 = a;
			if (obj4 == null)
			{
				bool flag4 = array.Length < num;
				object obj5 = !flag4;
				object obj6 = array.Length - num;
				bool flag5 = obj6 == null;
				object obj7 = ~obj5;
				object obj8 = obj7 | flag5;
				num3 = num;
				num2 = a;
				if (obj8 == null)
				{
					object obj9 = array + a;
					object obj10 = obj9 + 32;
					bool flag6 = obj10 == null;
					num2 = a;
					if (!flag6)
					{
						object obj11 = array + num;
						object obj12 = obj11 + 32;
						ref SimulationInputHeader header = ref ((SimulationInput)obj10).Header;
						bool flag7 = obj12 == null;
						num2 = 0;
						if (!flag7)
						{
							ref SimulationInputHeader header2 = ref ((SimulationInput)obj12).Header;
							int num4 = System.Runtime.CompilerServices.Unsafe.As<SimulationInputHeader, Tick>(ref header).CompareTo((Tick)header2);
							if (num4 < 1)
							{
								return;
							}
							object obj13 = array.Length;
							bool flag8 = array.Length < a;
							object obj14 = !flag8;
							object obj15 = array.Length - a;
							bool flag9 = obj15 == null;
							object obj16 = ~obj14;
							object obj17 = obj16 | flag9;
							num3 = 0;
							num2 = (int)header2;
							if (obj17 == null)
							{
								bool flag10 = array.Length < num;
								object obj18 = !flag10;
								object obj19 = array.Length - num;
								bool flag11 = obj19 == null;
								object obj20 = ~obj18;
								object obj21 = obj20 | flag11;
								num3 = 0;
								num2 = (int)header2;
								if (obj21 == null)
								{
									bool flag12 = obj12 == null;
									num2 = (int)header2;
									if (!flag12)
									{
										nint num5 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
										num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag13 = ex == null;
										num6 = 0;
										if (flag13)
										{
											goto IL_04bc;
										}
										obj13 = array.Length;
									}
									bool flag14 = (nint)obj13 < a;
									object obj22 = !flag14;
									object obj23 = obj13 - a;
									bool flag15 = obj23 == null;
									object obj24 = ~obj22;
									object obj25 = obj24 | flag15;
									num3 = 0;
									if (obj25 == null)
									{
										object obj26 = array + 32;
										obj10 = obj12;
										object obj27 = obj26 + a;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool flag16 = obj10 == null;
										int num7 = (int)obj12;
										if (!flag16)
										{
											nint num8 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v12 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
											num7 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag17 = ex == null;
											num6 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v12 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
											num2 = 0;
											if (flag17)
											{
												goto IL_04bc;
											}
										}
										bool flag18 = array.Length < num;
										object obj28 = !flag18;
										object obj29 = array.Length - num;
										bool flag19 = obj29 == null;
										object obj30 = ~obj28;
										object obj31 = obj30 | flag19;
										num3 = 0;
										num2 = num7;
										if (obj31 == null)
										{
											obj12 = obj10;
											object obj32 = obj26 + num;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											return;
										}
									}
								}
							}
							goto IL_0498;
						}
					}
					goto IL_04a6;
				}
			}
			goto IL_0498;
		}
		goto IL_04a6;
		IL_04bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_04a6:
		ex = new NullReferenceException();
		num6 = num3;
		goto IL_04bc;
		IL_0498:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_04a6;
	}

	private static void IntroSort(SimulationInput[] array, int lo, int hi, int depthLimit)
	{
		//IL_01b9: Expected Obj, but got I4
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I4
		int num = default;
		if (hi <= num)
		{
			return;
		}
		int num3 = default;
		int num2 = num3 - 1;
		int num4 = hi;
		int num7 = default;
		while (true)
		{
			object obj = num4 - num;
			object obj2 = obj + 1;
			if ((nint)obj2 > 16)
			{
				object obj3 = num2 + 1;
				if (obj3 == null)
				{
					break;
				}
				int num5 = PickPivotAndPartition(array, num, num4);
				int lo2 = num5 + 1;
				IntroSort(array, lo2, num4, num2);
				num4 = num5 - 1;
				int num6 = num2 - 1;
				bool flag = num4 > num;
				num2 = num6;
				if (!flag)
				{
					return;
				}
				continue;
			}
			if (num4 == num)
			{
				return;
			}
			SimulationInput[] array2;
			if ((nint)obj != 2)
			{
				bool flag2 = (nint)obj == 1;
				array2 = array;
				if (!flag2)
				{
					InsertionSort(array, num, num4);
					return;
				}
			}
			else
			{
				num7 = num4 - 1;
				SwapIfGreater(array, num, num7);
				SwapIfGreater(array, num, num4);
				array2 = array;
			}
			SwapIfGreater(array2, num7, num4);
			return;
		}
		Heapsort(array, num, num4);
	}

	private static int PickPivotAndPartition(SimulationInput[] array, int lo, int hi)
	{
		//IL_0314: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected I4, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0307: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_017d: Expected I4, but got I8
		//IL_0197: Expected Obj, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01ce: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I
		//IL_0265: Expected I4, but got I8
		//IL_027f: Expected Obj, but got I4
		object obj = hi - lo;
		bool flag = (nint)obj < 0;
		object obj2 = obj ^ obj;
		object obj3 = obj & obj2;
		bool flag2 = (nint)obj3 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			obj++;
		}
		int num = lo + obj;
		SwapIfGreater(array, lo, num);
		SwapIfGreater(array, lo, hi);
		SwapIfGreater(array, num, hi);
		if (array == null)
		{
			goto IL_02eb;
		}
		bool flag4 = num < array.Length;
		object obj6 = !flag4;
		object obj8;
		int num2;
		if (obj6 == null)
		{
			object obj7 = array + num;
			obj8 = hi - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AC8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C61E4");
			bool flag5 = (nint)obj8 <= lo;
			num2 = lo;
			if (flag5)
			{
				goto IL_02bb;
			}
			object obj10 = obj8;
			num2 = lo;
			while (true)
			{
				num2++;
				bool flag6 = num2 < array.Length;
				object obj11 = !flag6;
				if (obj11 != null)
				{
					break;
				}
				object obj12 = array + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12+20]");
					ref SimulationInputHeader header = ref ((SimulationInput)0).Header;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+20]");
						int num3 = System.Runtime.CompilerServices.Unsafe.As<SimulationInputHeader, Tick>(ref header).CompareTo((Tick)((SimulationInput)0).Header);
						int num4 = (int)(num3 & 0x80000000L);
						bool flag7 = num4 == 0;
						object obj13 = !flag7;
						if (obj13 != null)
						{
							continue;
						}
						while (true)
						{
							obj10--;
							bool flag8 = (nint)obj10 < array.Length;
							object obj14 = !flag8;
							if (obj14 != null)
							{
								break;
							}
							object obj15 = (object)array + obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+20]");
							ref SimulationInputHeader header2 = ref ((SimulationInput)0).Header;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v15+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v15+20]");
								int num5 = System.Runtime.CompilerServices.Unsafe.As<SimulationInputHeader, Tick>(ref header2).CompareTo((Tick)((SimulationInput)0).Header);
								int num6 = (int)(num5 & 0x80000000L);
								bool flag9 = num6 == 0;
								object obj16 = !flag9;
								if (obj16 != null)
								{
									continue;
								}
								goto IL_028d;
							}
							goto IL_02eb;
						}
						break;
					}
				}
				goto IL_02eb;
				IL_028d:
				if (num2 < (nint)obj10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C61E4");
					continue;
				}
				goto IL_02bb;
			}
		}
		goto IL_02f9;
		IL_02bb:
		if (num2 != (nint)obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C61E4");
		}
		return num2;
		IL_02eb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02f9;
		IL_02f9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	private static void Heapsort(SimulationInput[] array, int lo, int hi)
	{
		//IL_006e: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected I4, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I4
		object obj = hi - lo;
		int num = obj + 1;
		if (num < 2)
		{
			return;
		}
		int num2 = num >> 1;
		object obj5;
		do
		{
			DownHeap(array, num2, num, lo);
			num2--;
			bool flag = num2 < 1;
			object obj2 = !flag;
			object obj3 = num2 - 1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			obj5 = obj2 & obj4;
		}
		while (obj5 != null);
		if (num >= 2)
		{
			object obj6 = -lo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AC8]");
			object obj7 = 0;
			int num3 = hi;
			object obj13;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C61E4");
				int n = obj6 + num3;
				DownHeap(array, 1, n, lo);
				num3--;
				object obj8 = obj6 + num3;
				object obj9 = obj8 + 2;
				bool flag3 = (nint)obj9 < 2;
				object obj10 = !flag3;
				object obj11 = obj9 - 2;
				bool flag4 = obj11 == null;
				object obj12 = !flag4;
				obj13 = obj10 & obj12;
			}
			while (obj13 != null);
		}
	}

	private static void DownHeap(SimulationInput[] array, int i, int n, int lo)
	{
		//IL_0033: Expected Obj, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_06a3: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_0640: Expected Obj, but got I4
		//IL_05cb: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_0510: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_0559: Expected Obj, but got I
		//IL_037c: Expected I4, but got I8
		//IL_0233: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got I4
		//IL_03d4: Expected I4, but got VT
		//IL_0276: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I4
		//IL_02c2: Expected I4, but got VT
		//IL_03fe: Expected I4, but got VT
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0674: Expected Obj, but got I4
		//IL_0414: Expected I, but got Obj
		//IL_04ae: Expected I4, but got Obj
		//IL_045e: Expected Obj, but got I4
		bool flag = array == null;
		int num2 = default;
		int num = num2;
		object obj;
		int num8;
		int num9;
		int num10;
		NullReferenceException ex = default;
		int num3 = default;
		if (!flag)
		{
			obj = lo - 1;
			object obj2 = obj + num3;
			bool flag2 = (nint)obj2 < array.Length;
			object obj3 = !flag2;
			num = num2;
			if (obj3 == null)
			{
				bool flag3 = num2 < 0;
				int num4 = num2 ^ num2;
				int num5 = num2 & num4;
				bool flag4 = num5 < 0;
				object obj4 = (object)array + obj2;
				bool flag5 = flag3 == flag4;
				object obj5 = !flag5;
				object obj6 = ~obj5;
				int num6 = ((obj6 != null) ? num2 : (num2 + 1));
				int num7 = num6 >> 1;
				if (num7 < num3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v5+20]");
					bool flag6 = (nint)0 == 0;
					object obj7 = !flag6;
					num8 = num3;
					if (obj7 == null)
					{
						num9 = num3;
						num8 = num3;
						goto IL_04e8;
					}
					goto IL_05c3;
				}
				object obj8 = array + 32;
				num = num2;
				num10 = num3;
				while (true)
				{
					num8 = num10 << 1;
					object obj9 = array.Length;
					if (num8 < num2)
					{
						object obj10 = num8 + lo;
						object obj11 = obj10 - 1;
						bool flag7 = (nint)obj11 < array.Length;
						object obj12 = !flag7;
						if (obj12 != null)
						{
							break;
						}
						bool flag8 = (nint)obj10 < array.Length;
						object obj13 = !flag8;
						if (obj13 != null)
						{
							break;
						}
						object obj14 = (object)array + obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v19+20]");
						if ((nint)0 != 0)
						{
							object obj15 = (object)array + obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v19+20]");
							ref SimulationInputHeader header = ref ((SimulationInput)0).Header;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v20+20]");
							bool flag9 = (nint)0 == 0;
							num3 = 0;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v20+20]");
								ref SimulationInputHeader header2 = ref ((SimulationInput)0).Header;
								int num11 = System.Runtime.CompilerServices.Unsafe.As<SimulationInputHeader, Tick>(ref header).CompareTo((Tick)header2);
								obj9 = array.Length;
								num8 |= num11;
								num = 0;
								num3 = (int)header2;
								goto IL_061a;
							}
						}
						goto IL_0572;
					}
					goto IL_061a;
					IL_061a:
					object obj16 = obj + num8;
					bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
					object obj17 = !flag10;
					if (obj17 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v5+20]");
					if ((nint)0 != 0)
					{
						object obj18 = (object)array + obj16;
						object obj19 = obj18 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v5+20]");
						ref SimulationInputHeader header3 = ref ((SimulationInput)0).Header;
						bool flag11 = obj19 == null;
						num3 = 0;
						if (!flag11)
						{
							ref SimulationInputHeader header4 = ref ((SimulationInput)obj19).Header;
							int num12 = System.Runtime.CompilerServices.Unsafe.As<SimulationInputHeader, Tick>(ref header3).CompareTo((Tick)header4);
							if ((int)(num12 & 0x80000000L) != 0)
							{
								object obj20 = array.Length;
								bool flag12 = (nint)obj16 < array.Length;
								object obj21 = !flag12;
								num = 0;
								num3 = (int)header4;
								if (obj21 != null)
								{
									break;
								}
								bool flag13 = obj19 == null;
								num3 = (int)header4;
								if (!flag13)
								{
									nint num13 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v17 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag14 = ex == null;
									num = 0;
									if (flag14)
									{
										goto IL_0580;
									}
									obj20 = array.Length;
								}
								object obj22 = obj + num10;
								bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
								object obj23 = !flag15;
								num = 0;
								if (obj23 != null)
								{
									break;
								}
								object obj24 = (object)array + obj22;
								object obj25 = obj8 + obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag16 = num8 <= num7;
								num = 0;
								num3 = (int)obj19;
								num10 = num8;
								if (flag16)
								{
									continue;
								}
								goto IL_04c4;
							}
							goto IL_04d2;
						}
					}
					goto IL_0572;
				}
			}
			goto IL_0564;
		}
		goto IL_0572;
		IL_04d2:
		num2 = 0;
		num8 = num10;
		goto IL_05c3;
		IL_0580:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_04e8:
		object obj26 = obj + num8;
		bool flag17 = (nint)obj26 < array.Length;
		object obj27 = !flag17;
		num = num2;
		num3 = num9;
		if (obj27 == null)
		{
			object obj28 = (object)array + obj26;
			object obj29 = obj28 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v5+20]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		goto IL_0564;
		IL_0564:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0572;
		IL_0572:
		ex = new NullReferenceException();
		goto IL_0580;
		IL_05c3:
		nint num14 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
		num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		bool flag18 = ex == null;
		num = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
		num3 = 0;
		if (!flag18)
		{
			goto IL_04e8;
		}
		goto IL_0580;
		IL_04c4:
		num2 = 0;
		goto IL_05c3;
	}

	private unsafe static void InsertionSort(SimulationInput[] array, int lo, int hi)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0506: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_035e: Expected I, but got Obj
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I4
		//IL_01d6: Expected I4, but got I8
		//IL_0216: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_0247: Expected I4, but got VT
		//IL_025d: Expected I4, but got Obj
		//IL_0279: Expected I4, but got VT
		//IL_04ad: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_028f: Expected I, but got Obj
		//IL_02d9: Expected Obj, but got I4
		if (lo >= hi)
		{
			return;
		}
		bool flag = array == null;
		int num = hi;
		int num2 = lo;
		NullReferenceException ex = default;
		if (!flag)
		{
			object obj = array + 32;
			num = hi;
			num2 = lo;
			int num3 = lo;
			while (true)
			{
				int num4 = num3 + 1;
				bool flag2 = num4 < array.Length;
				object obj2 = !flag2;
				int num5;
				int num6;
				int num7;
				if (obj2 == null)
				{
					object obj3 = array + num4;
					if (num3 < lo)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v7+20]");
						bool flag3 = (nint)0 == 0;
						object obj4 = !flag3;
						num5 = num;
						num6 = num3;
						if (obj4 != null)
						{
							goto IL_0356;
						}
						num5 = num;
						num7 = num2;
						goto IL_03b5;
					}
					while (true)
					{
						bool flag4 = num3 < array.Length;
						object obj5 = !flag4;
						if (obj5 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v7+20]");
						if ((nint)0 == 0)
						{
							goto end_IL_04dd;
						}
						object obj6 = array + num3;
						object obj7 = obj6 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v7+20]");
						ref SimulationInputHeader header = ref ((SimulationInput)0).Header;
						bool flag5 = obj7 == null;
						num2 = 0;
						if (flag5)
						{
							goto end_IL_04dd;
						}
						ref SimulationInputHeader header2 = ref ((SimulationInput)obj7).Header;
						int num8 = System.Runtime.CompilerServices.Unsafe.As<SimulationInputHeader, Tick>(ref header).CompareTo((Tick)header2);
						int num9 = (int)(num8 & 0x80000000L);
						bool flag6 = num9 == 0;
						num5 = 0;
						int num10 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref header);
						num6 = num3;
						if (!flag6)
						{
							object obj8 = array.Length;
							bool flag7 = num3 < array.Length;
							object obj9 = !flag7;
							num = 0;
							num2 = (int)header2;
							if (obj9 != null)
							{
								break;
							}
							num10 = (int)obj7;
							bool flag8 = obj7 == null;
							num2 = (int)header2;
							if (!flag8)
							{
								nint num11 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v17 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag9 = ex == null;
								num = 0;
								if (flag9)
								{
									goto IL_0489;
								}
								obj8 = array.Length;
							}
							object obj10 = num3 + 1;
							bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
							object obj11 = !flag10;
							num = 0;
							if (obj11 != null)
							{
								break;
							}
							object obj12 = (object)array + obj10;
							object obj13 = obj + obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							num3--;
							bool flag11 = num3 >= lo;
							num = 0;
							num2 = num10;
							num5 = 0;
							num6 = num3;
							if (flag11)
							{
								continue;
							}
						}
						goto IL_0356;
					}
				}
				goto IL_046d;
				IL_03b5:
				object obj14 = num3 + 1;
				bool flag12 = (nint)obj14 < array.Length;
				object obj15 = !flag12;
				num = num5;
				num2 = num7;
				if (obj15 == null)
				{
					object obj16 = (object)array + obj14;
					object obj17 = obj + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v7+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag13 = num4 != hi;
					num = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v7+20]");
					num2 = 0;
					num3 = num4;
					if (!flag13)
					{
						return;
					}
					continue;
				}
				goto IL_046d;
				IL_0356:
				nint num12 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v11 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag14 = ex == null;
				num3 = num6;
				num = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v11 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
				num2 = 0;
				if (!flag14)
				{
					goto IL_03b5;
				}
				goto IL_0489;
				IL_046d:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				break;
				continue;
				end_IL_04dd:
				break;
			}
		}
		ex = new NullReferenceException();
		goto IL_0489;
		IL_0489:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}
}
