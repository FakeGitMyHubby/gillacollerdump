using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

[StructLayout((LayoutKind)2)]
public struct NetworkRNG : Action<long>
{
	public const int SIZE = default(int);

	public const uint MAX = default(uint);

	[FieldOffset(0)]
	private ulong state;

	[FieldOffset(8)]
	private ulong inc;

	internal const double FP_32_32_ToUnitDoubleInclusive = default(double);

	internal const double FP_32_32_ToUnitDoubleExclusive = default(double);

	internal const float FP_8_24_ToUnitSingleInclusive = default(float);

	internal const float FP_8_24_ToUnitSingleExclusive = default(float);

	public NetworkRNG Peek
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0007: Expected VT, but got I8
			return (NetworkRNG)state;
		}
	}

	public uint Next(uint maxExclusive)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_005f: Expected Obj, but got I8
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I8, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I8
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected I4, but got Unknown
		//IL_00fc: Expected Obj, but got I8
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected I8, but got Unknown
		//IL_0139: Expected Obj, but got I4
		object obj = 0 - maxExclusive;
		int num = (int)(obj / maxExclusive);
		long num2 = (long)state >> 45;
		long num3 = (long)state >> 27;
		long num4 = (long)(inc | 1);
		object obj2 = state * 6364136223846793005L;
		ulong num5 = (ulong)(num4 + obj2);
		object obj3 = num * (int)maxExclusive;
		object obj4 = obj - obj3;
		long num6 = num2 ^ num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		state = num5;
		bool flag = num6 < (long)obj4;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj8;
			do
			{
				long num7 = (long)num5 >> 45;
				long num8 = (long)num5 >> 27;
				object obj6 = num5 * 6364136223846793005L;
				num5 = (ulong)(num4 + obj6);
				num6 = num7 ^ num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
				bool flag2 = num6 < (long)obj4;
				object obj7 = !flag2;
				obj8 = ~obj7;
			}
			while (obj8 != null);
			state = num5;
		}
		long num9 = num6 / (int)maxExclusive;
		object obj9 = num9 * (int)maxExclusive;
		return (uint)(int)(num6 - obj9);
	}

	public unsafe uint NextInclusive(uint maxInclusive)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I8
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected I8, but got Unknown
		object obj = maxInclusive + 1;
		if (obj != null)
		{
			uint maxExclusive = maxInclusive + 1;
			return Next(maxExclusive);
		}
		long num = (long)(inc | 1);
		object obj2 = state * 6364136223846793005L;
		ulong num2 = (ulong)(num + obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		state = num2;
		return (uint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
	}

	public ulong Next(ulong maxExclusive)
	{
		//IL_020c: Expected I4, but got I8
		//IL_0215: Expected I8, but got I4
		//IL_0039: Expected Obj, but got I8
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I8, but got Unknown
		//IL_006a: Expected Obj, but got I8
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I8
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected I8, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I8, but got Unknown
		//IL_00fa: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I8
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected I8, but got Unknown
		//IL_0124: Expected Obj, but got I8
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected I8, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected I8, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		long num = (long)maxExclusive >> 32;
		if (num != 0)
		{
			object obj = 0 - maxExclusive;
			long num2 = (long)(obj / maxExclusive);
			long num3 = (long)(inc | 1);
			object obj2 = state * 6364136223846793005L;
			object obj3 = num3 + obj2;
			long num4 = (long)state >> 59;
			object obj4 = num2 * (long)maxExclusive;
			object obj5 = obj - obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
			object obj6 = obj3 * 6364136223846793005L;
			ulong num5 = (ulong)(num3 + obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
			long num6 = obj3 | num4;
			bool flag = num6 < (long)obj5;
			object obj7 = !flag;
			state = num5;
			if (obj7 == null)
			{
				object obj15;
				do
				{
					object obj8 = num5 * 6364136223846793005L;
					object obj9 = num3 + obj8;
					long num7 = (long)num5 >> 45;
					long num8 = (long)num5 >> 27;
					long num9 = num7 ^ num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
					object obj10 = obj9 >> 45;
					object obj11 = obj9 >> 27;
					object obj12 = obj9 * 6364136223846793005L;
					num5 = (ulong)(num3 + obj12);
					object obj13 = obj10 ^ obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
					num6 = obj13 | num9;
					bool flag2 = num6 < (long)obj5;
					object obj14 = !flag2;
					obj15 = ~obj14;
				}
				while (obj15 != null);
				state = num5;
			}
			long num10 = num6 / (long)maxExclusive;
			object obj16 = num10 * (long)maxExclusive;
			return (ulong)(num6 - obj16);
		}
		uint num11 = Next((uint)maxExclusive);
		return (ulong)(int)num11;
	}

	public ulong NextInclusive(ulong maxInclusive)
	{
		//IL_000e: Expected Obj, but got I8
		//IL_0070: Expected Obj, but got I8
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected I8, but got Unknown
		object obj = maxInclusive + 1;
		if (obj != null)
		{
			ulong maxExclusive = maxInclusive + 1;
			return Next(maxExclusive);
		}
		long num = (long)(inc | 1);
		object obj2 = state * 6364136223846793005L;
		object obj3 = num + obj2;
		long num2 = (long)state >> 59;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		object obj4 = obj3 * 6364136223846793005L;
		ulong num3 = (ulong)(num + obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		ulong result = (ulong)(0x5851F42D4C957F2DL | num2);
		state = num3;
		return result;
	}

	public ulong NextUInt64()
	{
		//IL_0024: Expected Obj, but got I8
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected I8, but got Unknown
		long num = (long)(inc | 1);
		object obj = state * 6364136223846793005L;
		object obj2 = num + obj;
		long num2 = (long)state >> 59;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		object obj3 = obj2 * 6364136223846793005L;
		ulong num3 = (ulong)(num + obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		ulong result = (ulong)(num | num2);
		state = num3;
		return result;
	}

	public unsafe int NextInt32()
	{
		//IL_0024: Expected Obj, but got I8
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I8, but got Unknown
		long num = (long)(inc | 1);
		object obj = state * 6364136223846793005L;
		ulong num2 = (ulong)(num + obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		state = num2;
		return (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
	}

	public long NextInt64()
	{
		//IL_0024: Expected Obj, but got I8
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected I8, but got Unknown
		long num = (long)(inc | 1);
		object obj = state * 6364136223846793005L;
		object obj2 = num + obj;
		long num2 = (long)state >> 59;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		object obj3 = obj2 * 6364136223846793005L;
		ulong num3 = (ulong)(num + obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		long result = num | num2;
		state = num3;
		return result;
	}

	public NetworkRNG(int seed)
	{
		//IL_0012: Expected Obj, but got I8
		//IL_0024: Expected Obj, but got I8
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ad: Expected I8, but got Obj
		//IL_00ba: Expected I8, but got Obj
		object obj = -7046029254386353131L + seed;
		object obj2 = 4354685564936845354L + seed;
		object obj3 = obj ^ obj;
		object obj4 = obj2 ^ obj2;
		object obj5 = obj3 * -4658895280553007687L;
		object obj6 = obj4 * -4658895280553007687L;
		object obj7 = obj5 ^ obj5;
		object obj8 = obj6 ^ obj6;
		object obj9 = obj7 * -7723592293110705685L;
		object obj10 = obj8 * -7723592293110705685L;
		ulong num = (ulong)(obj9 ^ obj9);
		ulong num2 = (ulong)(obj10 ^ obj10);
		state = num;
		inc = num2;
	}

	public unsafe uint NextUInt32()
	{
		//IL_0024: Expected Obj, but got I8
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I8, but got Unknown
		long num = (long)(inc | 1);
		object obj = state * 6364136223846793005L;
		ulong num2 = (ulong)(num + obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		state = num2;
		return (uint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
	}

	public unsafe override int GetHashCode()
	{
		//IL_0034: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		int hashCode = ((ulong)this).GetHashCode();
		ulong num = (ulong)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		int hashCode2 = ((ulong*)num)->GetHashCode();
		object obj = hashCode2 - hashCode;
		object obj2 = obj + hashCode;
		return obj2 + 16337;
	}

	private unsafe static ulong NextSplitMix64(ref ulong x)
	{
		//IL_0017: Expected Obj, but got I8
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006a: Expected I8, but got Obj
		object obj = (long)x + -7046029254386353131L;
		object obj2 = obj ^ obj;
		ref ulong reference = ref *(ulong*)obj;
		object obj3 = obj2 * -4658895280553007687L;
		object obj4 = obj3 ^ obj3;
		object obj5 = obj4 * -7723592293110705685L;
		return (ulong)(obj5 ^ obj5);
	}

	[MethodImpl((MethodImplOptions)256)]
	public double NextDouble()
	{
		//IL_0072: Expected Obj, but got I8
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I8, but got Unknown
		long num = (long)state >> 45;
		long num2 = (long)state >> 27;
		long num3 = (long)(inc | 1);
		long num4 = num ^ num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		double num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5D0]");
		double result = num5 * 0.0;
		object obj = state * 6364136223846793005L;
		ulong num6 = (ulong)(num3 + obj);
		state = num6;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public double NextDoubleExclusive()
	{
		//IL_0051: Expected Obj, but got I8
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I8, but got Unknown
		//IL_0077: Expected F8, but got I8
		long num = (long)state >> 45;
		long num2 = (long)state >> 27;
		long num3 = (long)(inc | 1);
		long num4 = num ^ num2;
		object obj = state * 6364136223846793005L;
		ulong num5 = (ulong)(num3 + obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		state = num5;
		return num4;
	}

	[MethodImpl((MethodImplOptions)256)]
	public float NextSingle()
	{
		//IL_0080: Expected Obj, but got I8
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I8, but got Unknown
		long num = (long)state >> 45;
		long num2 = (long)state >> 27;
		long num3 = (long)(inc | 1);
		long num4 = num ^ num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		long num5 = num4 >> 8;
		float num6 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF2C]");
		float result = num6 * 0f;
		object obj = state * 6364136223846793005L;
		ulong num7 = (ulong)(num3 + obj);
		state = num7;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public float NextSingleExclusive()
	{
		//IL_0051: Expected Obj, but got I8
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I8, but got Unknown
		//IL_0085: Expected F4, but got I8
		long num = (long)state >> 45;
		long num2 = (long)state >> 27;
		long num3 = (long)(inc | 1);
		long num4 = num ^ num2;
		object obj = state * 6364136223846793005L;
		ulong num5 = (ulong)(num3 + obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		long num6 = num4 >> 8;
		state = num5;
		return num6;
	}

	[MethodImpl((MethodImplOptions)256)]
	public float Next()
	{
		//IL_0080: Expected Obj, but got I8
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I8, but got Unknown
		long num = (long)state >> 45;
		long num2 = (long)state >> 27;
		long num3 = (long)(inc | 1);
		long num4 = num ^ num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		long num5 = num4 >> 8;
		float num6 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF2C]");
		float result = num6 * 0f;
		object obj = state * 6364136223846793005L;
		ulong num7 = (ulong)(num3 + obj);
		state = num7;
		return result;
	}

	public int Next(int minInclusive, int maxExclusive)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0087: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		int num = default;
		object obj = num - maxExclusive;
		bool flag = (nint)obj < 0;
		bool flag2 = num == maxExclusive;
		int num2 = num ^ maxExclusive;
		int num3 = num ^ obj;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		if (!flag2)
		{
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			object obj3 = flag4 & obj2;
			object obj4 = ~obj3;
			int num5 = ((obj4 != null) ? maxExclusive : num);
			bool flag5 = flag == flag3;
			object obj5 = !flag5;
			object obj6 = ~obj5;
			int num6 = ((obj6 != null) ? maxExclusive : num);
			uint maxExclusive2 = (uint)(num5 - num6);
			uint num7 = Next(maxExclusive2);
			return (int)num7 + num6;
		}
		return num;
	}

	public int NextInclusive(int minInclusive, int maxInclusive)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected I4, but got Unknown
		object obj = minInclusive - maxInclusive;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = minInclusive ^ maxInclusive;
		int num2 = minInclusive ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? maxInclusive : minInclusive);
		bool flag5 = flag == flag3;
		object obj5 = !flag5;
		object obj6 = ~obj5;
		int num5 = ((obj6 != null) ? maxInclusive : minInclusive);
		object obj7 = num4 - num5;
		uint maxExclusive = (uint)(obj7 + 1);
		uint num6 = Next(maxExclusive);
		return (int)num6 + num5;
	}

	public uint Next(uint minInclusive, uint maxExclusive)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		uint num = default;
		bool flag = (int)num < (int)maxExclusive;
		object obj = !flag;
		bool flag2 = num == maxExclusive;
		if (!flag2)
		{
			object obj2 = !flag2;
			object obj3 = obj & obj2;
			object obj4 = ~obj3;
			uint num2 = ((obj4 != null) ? maxExclusive : num);
			object obj5 = ~obj;
			object obj6 = ~obj5;
			uint num3 = ((obj6 != null) ? maxExclusive : num);
			uint maxExclusive2 = num2 - num3;
			uint num4 = Next(maxExclusive2);
			return num4 + num3;
		}
		return num;
	}

	public uint NextInclusive(uint minInclusive, uint maxInclusive)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected I4, but got Unknown
		bool flag = (int)minInclusive < (int)maxInclusive;
		object obj = !flag;
		object obj2 = minInclusive - maxInclusive;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		object obj5 = ~obj4;
		uint num = ((obj5 != null) ? maxInclusive : minInclusive);
		object obj6 = ~obj;
		object obj7 = ~obj6;
		uint num2 = ((obj7 != null) ? maxInclusive : minInclusive);
		object obj8 = num - num2;
		uint maxExclusive = (uint)(obj8 + 1);
		uint num3 = Next(maxExclusive);
		return num3 + num2;
	}

	public long Next(long minInclusive, long maxExclusive)
	{
		//IL_000d: Expected Obj, but got I8
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I8, but got Unknown
		//IL_0087: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		long num = default;
		object obj = num - maxExclusive;
		bool flag = (nint)obj < 0;
		bool flag2 = num == maxExclusive;
		long num2 = num ^ maxExclusive;
		long num3 = num ^ obj;
		long num4 = num2 & num3;
		bool flag3 = num4 < 0;
		if (!flag2)
		{
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			object obj3 = flag4 & obj2;
			object obj4 = ~obj3;
			long num5 = ((obj4 != null) ? maxExclusive : num);
			bool flag5 = flag == flag3;
			object obj5 = !flag5;
			object obj6 = ~obj5;
			long num6 = ((obj6 != null) ? maxExclusive : num);
			ulong maxExclusive2 = (ulong)(num5 - num6);
			ulong num7 = Next(maxExclusive2);
			return (long)num7 + num6;
		}
		return num;
	}

	public long NextInclusive(long minInclusive, long maxInclusive)
	{
		//IL_000d: Expected Obj, but got I8
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I8, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I8
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected I8, but got Unknown
		object obj = minInclusive - maxInclusive;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		long num = minInclusive ^ maxInclusive;
		long num2 = minInclusive ^ obj;
		long num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		long num4 = ((obj4 != null) ? maxInclusive : minInclusive);
		bool flag5 = flag == flag3;
		object obj5 = !flag5;
		object obj6 = ~obj5;
		long num5 = ((obj6 != null) ? maxInclusive : minInclusive);
		object obj7 = num4 - num5;
		ulong maxExclusive = (ulong)(long)(obj7 + 1);
		ulong num6 = Next(maxExclusive);
		return (long)num6 + num5;
	}

	public ulong Next(ulong minInclusive, ulong maxExclusive)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		ulong num = default;
		bool flag = (long)num < (long)maxExclusive;
		object obj = !flag;
		bool flag2 = num == maxExclusive;
		if (!flag2)
		{
			object obj2 = !flag2;
			object obj3 = obj & obj2;
			object obj4 = ~obj3;
			ulong num2 = ((obj4 != null) ? maxExclusive : num);
			object obj5 = ~obj;
			object obj6 = ~obj5;
			ulong num3 = ((obj6 != null) ? maxExclusive : num);
			ulong maxExclusive2 = num2 - num3;
			ulong num4 = Next(maxExclusive2);
			return num4 + num3;
		}
		return num;
	}

	public ulong NextInclusive(ulong minInclusive, ulong maxInclusive)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I8
		//IL_0040: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I8
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected I8, but got Unknown
		bool flag = (long)minInclusive < (long)maxInclusive;
		object obj = !flag;
		object obj2 = minInclusive - maxInclusive;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		object obj5 = ~obj4;
		ulong num = ((obj5 != null) ? maxInclusive : minInclusive);
		object obj6 = ~obj;
		object obj7 = ~obj6;
		ulong num2 = ((obj7 != null) ? maxInclusive : minInclusive);
		object obj8 = num - num2;
		ulong maxExclusive = (ulong)(long)(obj8 + 1);
		ulong num3 = Next(maxExclusive);
		return num3 + num2;
	}

	public float NextInclusive(float minInclusive, float maxInclusive)
	{
		//IL_0018: Invalid comparison between F4 and I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_003a: Expected Obj, but got F4
		//IL_0047: Expected Obj, but got F4
		//IL_009c: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I8
		//IL_0189: Expected Obj, but got I8
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected I8, but got Unknown
		float num2 = default;
		float num = num2 - maxInclusive;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj = num2 ^ maxInclusive;
		object obj2 = num2 ^ num;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		long num3 = (long)state >> 45;
		long num4 = (long)state >> 27;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		float num5 = ((obj6 != null) ? maxInclusive : num2);
		bool flag5 = flag == flag3;
		object obj7 = !flag2;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		long num6 = (long)(inc | 1);
		long num7 = num3 ^ num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		long num8 = num7 >> 8;
		float num9 = num5 - maxInclusive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF2C]");
		object obj10 = num8 * 0;
		object obj11 = state * 6364136223846793005L;
		ulong num10 = (ulong)(num6 + obj11);
		float num11 = num9 * (float)obj10;
		state = num10;
		return maxInclusive + num11;
	}

	public double NextInclusive(double minInclusive, double maxInclusive)
	{
		//IL_0018: Invalid comparison between F8 and I4
		//IL_0027: Invalid comparison between F8 and I4
		//IL_003a: Expected Obj, but got F8
		//IL_0047: Expected Obj, but got F8
		//IL_009c: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I8
		//IL_017b: Expected Obj, but got I8
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected I8, but got Unknown
		double num2 = default;
		double num = num2 - maxInclusive;
		bool flag = num < 0.0;
		bool flag2 = num == 0.0;
		object obj = num2 ^ maxInclusive;
		object obj2 = num2 ^ num;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		long num3 = (long)state >> 45;
		long num4 = (long)state >> 27;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		double num5 = ((obj6 != null) ? maxInclusive : num2);
		bool flag5 = flag == flag3;
		object obj7 = !flag2;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		long num6 = (long)(inc | 1);
		long num7 = num3 ^ num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		double num8 = num5 - maxInclusive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5D0]");
		object obj10 = num7 * 0;
		object obj11 = state * 6364136223846793005L;
		ulong num9 = (ulong)(num6 + obj11);
		double num10 = num8 * (double)obj10;
		state = num9;
		return maxInclusive + num10;
	}

	[MethodImpl((MethodImplOptions)256)]
	public double RangeInclusive(double minInclusive, double maxInclusive)
	{
		//IL_0018: Invalid comparison between F8 and I4
		//IL_0027: Invalid comparison between F8 and I4
		//IL_003a: Expected Obj, but got F8
		//IL_0047: Expected Obj, but got F8
		//IL_009c: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I8
		//IL_017b: Expected Obj, but got I8
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected I8, but got Unknown
		double num2 = default;
		double num = num2 - maxInclusive;
		bool flag = num < 0.0;
		bool flag2 = num == 0.0;
		object obj = num2 ^ maxInclusive;
		object obj2 = num2 ^ num;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		long num3 = (long)state >> 45;
		long num4 = (long)state >> 27;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		double num5 = ((obj6 != null) ? maxInclusive : num2);
		bool flag5 = flag == flag3;
		object obj7 = !flag2;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		long num6 = (long)(inc | 1);
		long num7 = num3 ^ num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		double num8 = num5 - maxInclusive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5D0]");
		object obj10 = num7 * 0;
		object obj11 = state * 6364136223846793005L;
		ulong num9 = (ulong)(num6 + obj11);
		double num10 = num8 * (double)obj10;
		state = num9;
		return maxInclusive + num10;
	}

	[MethodImpl((MethodImplOptions)256)]
	public float RangeInclusive(float minInclusive, float maxInclusive)
	{
		//IL_0018: Invalid comparison between F4 and I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_003a: Expected Obj, but got F4
		//IL_0047: Expected Obj, but got F4
		//IL_009c: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I8
		//IL_0189: Expected Obj, but got I8
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected I8, but got Unknown
		float num2 = default;
		float num = num2 - maxInclusive;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj = num2 ^ maxInclusive;
		object obj2 = num2 ^ num;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		long num3 = (long)state >> 45;
		long num4 = (long)state >> 27;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		float num5 = ((obj6 != null) ? maxInclusive : num2);
		bool flag5 = flag == flag3;
		object obj7 = !flag2;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		long num6 = (long)(inc | 1);
		long num7 = num3 ^ num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ROR not yet implemented.\"");
		long num8 = num7 >> 8;
		float num9 = num5 - maxInclusive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF2C]");
		object obj10 = num8 * 0;
		object obj11 = state * 6364136223846793005L;
		ulong num10 = (ulong)(num6 + obj11);
		float num11 = num9 * (float)obj10;
		state = num10;
		return maxInclusive + num11;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int RangeInclusive(int minInclusive, int maxInclusive)
	{
		return NextInclusive(minInclusive, maxInclusive);
	}

	[MethodImpl((MethodImplOptions)256)]
	public uint RangeInclusive(uint minInclusive, uint maxInclusive)
	{
		return NextInclusive(minInclusive, maxInclusive);
	}

	[MethodImpl((MethodImplOptions)256)]
	public int RangeExclusive(int minExclusive, int maxExclusive)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0087: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		int num = default;
		object obj = num - maxExclusive;
		bool flag = (nint)obj < 0;
		bool flag2 = num == maxExclusive;
		int num2 = num ^ maxExclusive;
		int num3 = num ^ obj;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		if (!flag2)
		{
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			object obj3 = flag4 & obj2;
			object obj4 = ~obj3;
			int num5 = ((obj4 != null) ? maxExclusive : num);
			bool flag5 = flag == flag3;
			object obj5 = !flag5;
			object obj6 = ~obj5;
			int num6 = ((obj6 != null) ? maxExclusive : num);
			uint maxExclusive2 = (uint)(num5 - num6);
			uint num7 = Next(maxExclusive2);
			return (int)num7 + num6;
		}
		return num;
	}

	[MethodImpl((MethodImplOptions)256)]
	public uint RangeExclusive(uint minExclusive, uint maxExclusive)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		uint num = default;
		bool flag = (int)num < (int)maxExclusive;
		object obj = !flag;
		bool flag2 = num == maxExclusive;
		if (!flag2)
		{
			object obj2 = !flag2;
			object obj3 = obj & obj2;
			object obj4 = ~obj3;
			uint num2 = ((obj4 != null) ? maxExclusive : num);
			object obj5 = ~obj;
			object obj6 = ~obj5;
			uint num3 = ((obj6 != null) ? maxExclusive : num);
			uint maxExclusive2 = num2 - num3;
			uint num4 = Next(maxExclusive2);
			return num4 + num3;
		}
		return num;
	}
}
