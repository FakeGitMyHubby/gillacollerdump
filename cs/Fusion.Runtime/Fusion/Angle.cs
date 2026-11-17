using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.GroupsModels;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 4)]
public struct Angle : Action<IsMemberResponse>, _0021_00210
{
	private const int ACCURACY = default(int);

	private const int DECIMALS = default(int);

	private const int _360 = default(int);

	[FieldOffset(0)]
	private int _value;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF__VALUE = default(int);

	internal const int BYTE_COUNT_OF__VALUE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public void Clamp(Angle min, Angle max)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got VT
		//IL_010d: Expected Obj, but got VT
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected I4, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected I4, but got Unknown
		//IL_01d1: Expected Obj, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01ff: Invalid comparison between I4 and VT
		//IL_001f: Expected VT, but got I4
		//IL_005d: Expected Obj, but got VT
		//IL_0079: Expected Obj, but got VT
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_021e: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A88]");
		object error = 0;
		object obj = max - min;
		bool flag = (nint)obj < 0;
		object obj2 = max ^ min;
		object obj3 = max ^ obj;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool condition = flag == flag2;
		Assert.Check(condition, (string)error);
		object obj5 = _value - min;
		bool flag3 = (nint)obj5 < 0;
		bool flag4 = obj5 == null;
		int num = _value ^ min;
		int num2 = _value ^ obj5;
		int num3 = num & num2;
		bool flag5 = num3 < 0;
		bool flag6 = flag3 == flag5;
		object obj6 = !flag4;
		object obj7 = flag6 & obj6;
		object obj8 = ~obj7;
		Angle angle = ((obj8 != null) ? min : ((Angle)_value));
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_value) < System.Runtime.CompilerServices.Unsafe.As<Angle, UIntPtr>(ref min) || angle > max)
		{
			object obj9 = angle - max;
			bool flag7 = (nint)obj9 < 0;
			object obj10 = angle ^ max;
			object obj11 = angle ^ obj9;
			object obj12 = obj10 & obj11;
			bool flag8 = (nint)obj12 < 0;
			bool flag9 = flag7 == flag8;
			object obj13 = !flag9;
			object obj14 = ~obj13;
			if (obj14 != null)
			{
				angle = max;
			}
			_value = (int)angle;
		}
	}

	public static Angle Min(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got VT
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		Angle angle = default;
		object obj = angle - b;
		bool flag = (nint)obj < 0;
		object obj2 = angle ^ b;
		object obj3 = angle ^ obj;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = flag == flag2;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
		}
		return b;
	}

	public static Angle Max(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0038: Expected Obj, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		Angle angle = default;
		object obj = angle - b;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj2 = angle ^ b;
		object obj3 = angle ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		return b;
	}

	public static Angle Lerp(Angle a, Angle b, float t)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I4
		//IL_0206: Invalid comparison between F4 and I4
		//IL_0215: Expected F8, but got I4
		//IL_024a: Invalid comparison between F8 and I4
		//IL_00cc: Expected Obj, but got I4
		//IL_018f: Invalid comparison between F8 and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0291: Expected VT, but got F8
		//IL_01bb: Invalid comparison between F8 and I8
		if (a == b)
		{
			return a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BA00]");
		object obj = a / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BA00]");
		object obj2 = b / 0;
		object obj3 = obj2 - obj;
		object obj4 = obj3 / 1135869952;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj5 = obj4 * 1135869952;
		object obj6 = obj3 - obj5;
		bool flag = (nint)obj6 < 0;
		object obj7 = 0;
		if (!flag)
		{
			bool flag2 = (nint)obj6 > 1135869952;
			object obj8 = 1135869952;
			object obj9;
			if (!flag2)
			{
				bool flag3 = (nint)obj6 <= 1127481344;
				obj8 = obj6;
				obj9 = obj6;
				obj7 = obj6;
				if (flag3)
				{
					goto IL_01fd;
				}
			}
			obj7 = obj8 + 3283353600L;
			obj9 = obj8;
		}
		goto IL_01fd;
		IL_01fd:
		bool flag4 = t < 0f;
		double num = 0.0;
		if (!flag4)
		{
			bool flag5 = !((double)t > 1.0);
			num = t;
			if (!flag5)
			{
				num = 1.0;
			}
		}
		double num2 = (double)obj7 * num;
		double num3 = num2 + (double)obj;
		double num4;
		if (num3 > 1135869952.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D140");
			num4 = num3;
		}
		else
		{
			bool flag6 = !(num3 < 0.0);
			num4 = num3;
			if (!flag6)
			{
				if (num3 < 3283353600.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D140");
				}
				double num5 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C630]");
				num4 = num5 + 0.0;
			}
		}
		double num6 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BA00]");
		double num7 = num6 * 0.0;
		double num8 = num7 + 0.5;
		return (Angle)num8;
	}

	public static Angle Clamp(Angle value, Angle min, Angle max)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0038: Expected Obj, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got VT
		//IL_0157: Expected Obj, but got VT
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got VT
		//IL_01e8: Expected Obj, but got VT
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		object obj = max - min;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj2 = max ^ min;
		object obj3 = max ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		Angle angle = ((obj7 != null) ? min : max);
		bool flag5 = flag == flag3;
		object obj8 = !flag5;
		object obj9 = ~obj8;
		Angle angle2 = ((obj9 != null) ? min : max);
		object obj10 = angle - value;
		bool flag6 = (nint)obj10 < 0;
		object obj11 = angle ^ value;
		object obj12 = angle ^ obj10;
		object obj13 = obj11 & obj12;
		bool flag7 = (nint)obj13 < 0;
		bool flag8 = flag6 == flag7;
		object obj14 = !flag8;
		object obj15 = ~obj14;
		if (obj15 != null)
		{
			angle = value;
		}
		object obj16 = angle2 - value;
		bool flag9 = (nint)obj16 < 0;
		bool flag10 = obj16 == null;
		object obj17 = angle2 ^ value;
		object obj18 = angle2 ^ obj16;
		object obj19 = obj17 & obj18;
		bool flag11 = (nint)obj19 < 0;
		bool flag12 = flag9 == flag11;
		object obj20 = !flag10;
		object obj21 = flag12 & obj20;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
			return angle2;
		}
		return angle;
	}

	public static bool operator <(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got VT
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = flag == flag2;
		return !flag3;
	}

	public static bool operator <=(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0038: Expected Obj, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag4;
		return (byte)((obj5 | flag2) ? 1 : 0) != 0;
	}

	public static bool operator >(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0038: Expected Obj, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		return (byte)((flag4 & obj5) ? 1 : 0) != 0;
	}

	public static bool operator >=(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got VT
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		return flag == flag2;
	}

	public static bool operator ==(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	public static bool operator !=(Angle a, Angle b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}

	public bool Equals(Angle other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = _value - other;
		return obj == null;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A90]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int value = _value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)value - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _value;
	}

	public static Angle operator +(Angle a, Angle b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0048: Invalid comparison between VT and I4
		//IL_0059: Expected Obj, but got I4
		//IL_0062: Expected I4, but got Obj
		//IL_0078: Invalid comparison between VT and I4
		//IL_0089: Expected Obj, but got I4
		//IL_0092: Expected I4, but got Obj
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected VT, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A98]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AA0]");
		object error2 = 0;
		bool flag = a < (object)3600001;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		bool flag2 = b < (object)3600001;
		object obj2 = !flag2;
		bool condition2 = (byte)(int)(~obj2) != 0;
		Assert.Check(condition2, (string)error2);
		Angle angle = b + a;
		object obj3 = angle * 2501999793L;
		object obj4 = obj3 >> 53;
		object obj5 = obj4 * 3600000;
		Angle result = angle - obj5;
		object obj6 = 3600001 - 1;
		object obj7 = angle - obj6;
		bool flag3 = (nint)obj7 < 0;
		bool flag4 = obj7 == null;
		object obj8 = angle ^ obj6;
		object obj9 = angle ^ obj7;
		object obj10 = obj8 & obj9;
		bool flag5 = (nint)obj10 < 0;
		bool flag6 = flag3 == flag5;
		object obj11 = !flag4;
		object obj12 = flag6 & obj11;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			return result;
		}
		return angle;
	}

	public static Angle operator -(Angle a, Angle b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00c3: Invalid comparison between VT and I4
		//IL_00d4: Expected Obj, but got I4
		//IL_00dd: Expected I4, but got Obj
		//IL_00f3: Invalid comparison between VT and I4
		//IL_0104: Expected Obj, but got I4
		//IL_010d: Expected I4, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_0042: Invalid comparison between VT and I8
		//IL_0053: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_008c: Expected I4, but got Obj
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A98]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AA0]");
		object error2 = 0;
		bool flag = a < (object)3600001;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		bool flag2 = b < (object)3600001;
		object obj2 = !flag2;
		bool condition2 = (byte)(int)(~obj2) != 0;
		Assert.Check(condition2, (string)error2);
		Angle angle = a - b;
		if (a < angle)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AA8]");
			object error3 = 0;
			bool flag3 = angle < (object)4291367295L;
			object obj3 = !flag3;
			object obj4 = angle - 4291367295L;
			bool flag4 = obj4 == null;
			object obj5 = !flag4;
			bool condition3 = (byte)(obj3 & obj5) != 0;
			Assert.Check(condition3, (string)error3);
			object obj6 = 3600001 + angle;
			angle = (Angle)(obj6 - 1);
		}
		return angle;
	}

	public static explicit operator float(Angle value)
	{
		float num = (float)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BA00]");
		return num / 0f;
	}

	public static explicit operator double(Angle value)
	{
		double num = (double)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BA00]");
		return num / 0.0;
	}

	public static implicit operator Angle(double value)
	{
		//IL_0010: Invalid comparison between F8 and I
		//IL_003f: Invalid comparison between F8 and I4
		//IL_00d8: Expected VT, but got F8
		//IL_0066: Invalid comparison between F8 and I
		double num2 = default;
		double num = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C630]");
		if (num > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D140");
		}
		else if (num2 < 0.0)
		{
			double num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8C8]");
			if (num3 < 0.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D140");
			}
			double num4 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C630]");
			num2 = num4 + 0.0;
		}
		double num5 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BA00]");
		double num6 = num5 * 0.0;
		double num7 = num6 + 0.5;
		return (Angle)num7;
	}

	public static implicit operator Angle(float value)
	{
		//IL_0009: Invalid comparison between F4 and I4
		//IL_0038: Invalid comparison between F4 and I4
		//IL_00ce: Expected VT, but got F4
		//IL_005c: Invalid comparison between F4 and I8
		float num = default;
		if (num > 1.13587E+09f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D140");
		}
		else if (num < 0f)
		{
			if (num < 3.2833536E+09f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D140");
			}
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C630]");
			num = num2 + 0f;
		}
		float num3 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BA00]");
		float num4 = num3 * 0f;
		float num5 = num4 + 0.5f;
		return (Angle)num5;
	}

	public static implicit operator Angle(int value)
	{
		//IL_0079: Expected I4, but got I8
		//IL_0125: Expected VT, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected I4, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected I4, but got Unknown
		int num = default;
		if (num >= 361)
		{
			int num2 = num >> 3;
			object obj = num2 * 381774871;
			object obj2 = obj >> 34;
			object obj3 = obj2 * 360;
			num -= obj3;
		}
		else if ((int)(num & 0x80000000L) != 0)
		{
			object obj4 = -num;
			object obj5 = obj4 >> 3;
			object obj6 = obj5 * 381774871;
			object obj7 = obj6 >> 34;
			object obj8 = obj7 * 360;
			object obj9 = num + obj8;
			num = obj9 + 360;
		}
		return (Angle)(num * 10000);
	}

	public override string ToString()
	{
		//IL_0015: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		int num = default;
		string text = num.ToString();
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6AB0]");
			object format = 0;
			bool flag = text._stringLength > 3;
			string arg = text;
			if (!flag)
			{
				int count = 4 - text._stringLength;
				string text2 = ((string)null).CreateString('0', count);
				string text3 = text2 + text;
				arg = text3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg2 = default;
			return string.Format((string)format, arg2, arg);
		}
		return (string)(object)new NullReferenceException();
	}
}
