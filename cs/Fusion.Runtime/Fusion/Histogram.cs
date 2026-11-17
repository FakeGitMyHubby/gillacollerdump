using System;
using Cpp2ILInjected;

namespace Fusion;

internal class Histogram
{
	public enum QuantileEstimator
	{
		// error: enumerator has no value
		HyndmanFanType1,
		// error: enumerator has no value
		HyndmanFanType2,
		// error: enumerator has no value
		HyndmanFanType3,
		// error: enumerator has no value
		HyndmanFanType4,
		// error: enumerator has no value
		HyndmanFanType5,
		// error: enumerator has no value
		HyndmanFanType6,
		// error: enumerator has no value
		HyndmanFanType7,
		// error: enumerator has no value
		HyndmanFanType8,
		// error: enumerator has no value
		HyndmanFanType9
	}

	private int resolution;

	private int minExp;

	private int maxExp;

	private double count;

	private double zeroCount;

	private readonly RingBuffer<double> bins;

	internal const int MaxResolution = default(int);

	internal const int MaxCapacity = default(int);

	public double Count => count;

	public Histogram()
		: this(256)
	{
	}

	public Histogram(double min, double max, double error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Invalid comparison between F8 and I4
		//IL_002d: Invalid comparison between F8 and I4
		//IL_0040: Expected Obj, but got F8
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CA0]");
		object error2 = 0;
		this._002Ector(Contrast(min, max), Resolution(error));
		Assert.Check((byte)(((error < 0.0 == (nint)(object)(error & (object)(error ^ error)) < 0) & (object)(error != 0.0)) ? 1 : 0) != 0, (string)error2);
	}

	public Histogram(double contrast, int resolution)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CB0]");
		object error = 0;
		this._002Ector(Capacity(contrast, resolution));
		object obj = resolution - 21;
		bool flag = (nint)obj < 0;
		int num = resolution ^ 0x15;
		int num2 = resolution ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		bool condition = !flag3;
		Assert.Check(condition, (string)error);
	}

	public Histogram(int capacity)
	{
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C88]");
		object obj2 = 0;
		base._002Ector();
		bool flag = capacity < 2049;
		string text = null;
		int num = capacity;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+10]");
			bool flag2 = (nint)0 == 0;
			text = null;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C98]");
				object arg = default;
				object arg2 = default;
				string text2 = string.Format((string)0, arg, arg2);
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v120 @ X8_v13+198] (should have been resolved before IL gen)");
				text = text2;
			}
			num = 2048;
		}
		maxExp = 0;
		count = 0.0;
		zeroCount = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B200]");
		resolution = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4335510");
		object obj8 = this + 48;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe void Print()
	{
		//IL_087c: Expected Obj, but got I
		//IL_0894: Expected Obj, but got I
		//IL_08ac: Expected Obj, but got I
		//IL_08c4: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_0907: Expected Obj, but got I4
		//IL_03b9: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got Ref
		//IL_0170: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I8
		//IL_021b: Expected Obj, but got I4
		//IL_03f5: Expected I, but got Obj
		//IL_0405: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_04c3: Expected Obj, but got Ref
		//IL_0291: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I
		//IL_053c: Expected Obj, but got I8
		//IL_02d0: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I8
		//IL_02fd: Expected Obj, but got I4
		//IL_04d9: Expected I, but got Obj
		//IL_04e9: Expected Obj, but got I
		//IL_051a: Expected Obj, but got I
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got Unknown
		//IL_05d7: Expected Obj, but got Ref
		//IL_0650: Expected Obj, but got I4
		//IL_0660: Expected Obj, but got I4
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_05ed: Expected I, but got Obj
		//IL_05fd: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected Obj, but got Unknown
		//IL_06f9: Expected Obj, but got Ref
		//IL_076a: Expected Obj, but got I8
		//IL_070f: Expected I, but got Obj
		//IL_071f: Expected Obj, but got I
		//IL_0748: Expected Obj, but got I
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_07cd: Expected Obj, but got I
		//IL_07ea: Expected Obj, but got I
		//IL_081c: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+A0]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj5 = 0;
		bool flag = obj3 == null;
		object[] array = (object[])109895680;
		double num2 = default;
		int num3 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CE8]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			double num = Base(resolution);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			object arg2 = default;
			string text = string.Format((string)format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v1+10]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X9_v3+1A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X9_v3+198] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v41+A0]");
			object obj11 = 0;
			array = (object[])obj11;
			bool flag2 = obj11 == null;
			object obj12 = 0;
			num2 = num;
			num3 = resolution;
			if (!flag2)
			{
				double num4 = Base(resolution);
				double num5 = num4 + -1.0;
				double num6 = num4 + 1.0;
				double num7 = num5 / num6;
				num = num7 * 4.636737291354636E+18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CD0]");
				object format2 = 0;
				object arg3 = default;
				string text2 = string.Format((string)format2, arg3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X20_v4 (System.Object[])+10]");
				object obj13 = 0;
				obj7 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X9_v3+1A0]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X9_v3+198] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v50+A0]");
				object obj16 = 0;
				array = (object[])obj16;
				bool flag3 = obj16 == null;
				double num8 = 1.0;
				object obj17 = 4636737291354636288L;
				obj12 = 0;
				num2 = num;
				num3 = resolution;
				if (!flag3)
				{
					double num9 = Base(resolution);
					double num10 = num9 + -1.0;
					num = num10 * 4.636737291354636E+18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CE0]");
					object format3 = 0;
					object arg4 = default;
					string text3 = string.Format((string)format3, arg4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X20_v4 (System.Object[])+10]");
					object obj18 = 0;
					obj7 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X9_v3+1A0]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X9_v3+198] (should have been resolved before IL gen)");
					num8 = 1.0;
					obj17 = 4636737291354636288L;
					obj12 = 0;
					num2 = num;
					num3 = resolution;
				}
			}
		}
		RingBuffer<double> ringBuffer = bins;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CD8]");
		object format4 = 0;
		int num11 = 0;
		object obj26 = default;
		object obj28 = default;
		object[] array2 = default;
		object obj31 = default;
		object obj34 = default;
		object obj40 = default;
		double num19 = default;
		IndexOutOfRangeException ex = default;
		while (true)
		{
			int num12 = ringBuffer.Count;
			if (num11 >= num12)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v11+A0]");
			object obj23 = 0;
			object obj24 = obj23;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj25 = minExp + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				bool flag4 = obj26 == null;
				object obj27 = (object)(&obj28);
				object obj29;
				if (!flag4)
				{
					nint num13 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
					obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
					obj29 = 0;
					if (flag5)
					{
						break;
					}
				}
				if (array2.Length != 0)
				{
					object obj30 = array2 + 32;
					obj30 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int exp = minExp + num11;
					double num14 = LowerBound(resolution, exp);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					bool flag6 = obj31 == null;
					obj27 = (object)(&num2);
					double num;
					if (!flag6)
					{
						nint num15 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag7 = ex == null;
						num = num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						obj29 = 0;
						if (flag7)
						{
							break;
						}
					}
					object obj32 = array2.Length & 0xFFFFFFFEL;
					bool flag8 = obj32 == null;
					num = num14;
					if (!flag8)
					{
						object obj33 = array2 + 40;
						obj33 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						int num16 = num11 + 1;
						int exp2 = num16 + minExp;
						num = LowerBound(resolution, exp2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						bool flag9 = obj34 == null;
						obj27 = (object)(&num3);
						if (!flag9)
						{
							nint num17 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
							obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
							obj29 = 0;
							if (flag10)
							{
								break;
							}
						}
						bool flag11 = array2.Length < 2;
						object obj35 = !flag11;
						object obj36 = array2.Length - 2;
						bool flag12 = obj36 == null;
						object obj37 = ~obj35;
						object obj38 = obj37 | flag12;
						if (obj38 == null)
						{
							object obj39 = array2 + 48;
							obj39 = obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj8 = obj20;
							double num18 = bins.get_Item(num11);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							bool flag13 = obj40 == null;
							obj27 = (object)(&num19);
							if (!flag13)
							{
								nint num20 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
								obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag14 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
								obj29 = 0;
								if (flag14)
								{
									break;
								}
							}
							object obj41 = array2.Length & 0xFFFFFFFCL;
							if (obj41 != null)
							{
								object obj42 = array2 + 56;
								obj42 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text4 = string.Format((string)format4, array2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X29_v2+10]");
								object obj43 = 0;
								object obj7 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X9_v3+1A0]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X9_v3+198] (should have been resolved before IL gen)");
								num19 = num;
								obj28 = obj25;
								num11 = num16;
								num2 = num14;
								num3 = (int)num;
								goto IL_08e1;
							}
						}
					}
				}
				ex = new IndexOutOfRangeException();
				obj29 = obj27;
				break;
			}
			num11++;
			goto IL_08e1;
			IL_08e1:
			ringBuffer = bins;
			bool flag15 = (object)bins == null;
			object obj44 = !flag15;
			if (obj44 == null)
			{
				throw new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	public void Clear()
	{
		maxExp = 0;
		count = 0.0;
		zeroCount = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B200]");
		resolution = 0;
		bins.Clear();
	}

	public void Record(double value)
	{
		Record(value, 1.0);
	}

	public void Record(double value, double count)
	{
		//IL_048f: Expected Obj, but got F8
		//IL_04a9: Expected Obj, but got I4
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I4
		//IL_000e: Invalid comparison between F8 and I4
		//IL_0055: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0119: Expected F8, but got Obj
		//IL_043f: Expected Obj, but got I
		//IL_0452: Expected F8, but got Obj
		//IL_0179: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_02eb: Expected Obj, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_03a9: Expected Obj, but got I4
		//IL_03b9: Expected Obj, but got I
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_026b: Expected F8, but got Obj
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_03db: Expected F8, but got Obj
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num = default;
		object obj = num >> 52;
		bool flag = (nint)obj < 2046;
		object obj2 = !flag;
		object obj3 = obj - 2046;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 != null)
		{
			return;
		}
		if (value == 0.0)
		{
			double num2 = zeroCount + count;
			zeroCount = num2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num3 = Exponent(resolution, num);
			if (bins.IsEmpty)
			{
				minExp = num3;
				maxExp = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CF8]");
				object obj9 = 0;
				bins.PushBack((double)obj9);
			}
			bool flag4 = num3 >= minExp;
			int num4 = num3;
			if (!flag4)
			{
				int capacity = bins.Capacity;
				int num5 = bins.Count;
				object obj10 = num5 - capacity;
				object obj11 = obj10 + minExp;
				bool flag5 = num3 >= (nint)obj11;
				num4 = num3;
				if (!flag5)
				{
					int num6 = maxExp;
					int num7 = Downsample(num3, maxExp);
					num4 = num3 >> num7;
				}
				minExp = num4;
				object obj12 = maxExp - num4;
				object obj13 = obj12 + 1;
				int num8 = bins.Count;
				if (num8 < (nint)obj13)
				{
					object obj14 = maxExp - num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D00]");
					object obj15 = 0;
					object obj16 = obj14 + 1;
					do
					{
						bins.PushFront((double)obj15);
						obj16--;
					}
					while (num4 != (nint)obj16);
				}
			}
			if (num4 > maxExp)
			{
				int capacity2 = bins.Capacity;
				int num9 = bins.Count;
				object obj17 = capacity2 - num9;
				object obj18 = obj17 + maxExp;
				if (num4 > (nint)obj18)
				{
					int num10 = Downsample(minExp, num4);
					int num11 = num4 >> num10;
					int num6 = num4;
					num4 = num11;
				}
				maxExp = num4;
				object obj19 = num4 - minExp;
				object obj20 = obj19 + 1;
				int num12 = bins.Count;
				if (num12 < (nint)obj20)
				{
					object obj21 = num12 + minExp;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CF8]");
					object obj22 = 0;
					object obj23 = obj21 - 1;
					do
					{
						bins.PushBack((double)obj22);
						obj23++;
					}
					while (num4 != (nint)obj23);
				}
			}
			int index = BinIndex(num4);
			double num13 = bins.get_Item(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D18]");
			object obj24 = 0;
			bins.set_Item(index, (double)obj24);
		}
		double num14 = this.count + count;
		this.count = num14;
	}

	public void Normalize()
	{
		double scaleFactor = 1.0 / count;
		Rescale(scaleFactor);
	}

	public void Rescale(double scaleFactor)
	{
		//IL_00e5: Expected Obj, but got F8
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0084: Expected F8, but got Obj
		//IL_00bd: Expected Obj, but got I4
		object obj = scaleFactor >> 52;
		object obj2 = obj & 0x7FF;
		bool flag = (nint)obj2 < 2046;
		object obj3 = !flag;
		object obj4 = obj2 - 2046;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		if (obj6 != null)
		{
			return;
		}
		RingBuffer<double> ringBuffer = bins;
		object obj7 = default;
		double num = (count *= (double)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D18]");
		object obj8 = 0;
		int num2 = 0;
		while (true)
		{
			int num3 = ringBuffer.Count;
			if (num2 < num3)
			{
				double num4 = bins.get_Item(num2);
				num *= scaleFactor;
				bins.set_Item(num2, (double)obj8);
				ringBuffer = bins;
				num2++;
				bool flag3 = (object)bins == null;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			break;
		}
	}

	public double Mean()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Expected F8, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_01b7: Expected F8, but got I4
		RingBuffer<double> ringBuffer = bins;
		if ((object)bins != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
			object obj2 = 0;
			double num = 0.0;
			int num2 = 0;
			double num7 = default;
			object obj5;
			object obj8 = default;
			object obj10 = default;
			NullReferenceException ex3 = default;
			do
			{
				object obj3 = obj;
				int num3 = ringBuffer.Count;
				bool flag = num2 >= num3;
				double num4 = num;
				if (!flag)
				{
					if ((object)bins != null)
					{
						object obj4 = obj2;
						double num5 = bins.get_Item(num2);
						double num6 = BinMidpoint(num2);
						num7 *= num6;
						ringBuffer = bins;
						num2++;
						num4 = num + num7;
						bool flag2 = (object)bins == null;
						obj5 = !flag2;
						num = num4;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					bool flag3 = (nint)obj != 1;
					NullReferenceException ex2 = ex;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj6 = 0;
						object obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
						object obj9 = obj10 & 1;
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							return 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj11 = obj8;
						obj3 = 101789696 + 1224;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						object obj4 = 0;
						ex2 = ex3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return num7;
				}
				return num4 / count;
			}
			while (obj5 != null);
		}
		throw new NullReferenceException();
	}

	public double MeanGeometric()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_004e: Expected F8, but got I4
		//IL_033d: Expected I4, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_02d9: Expected Obj, but got I4
		//IL_0296: Expected F8, but got I4
		RingBuffer<double> ringBuffer = bins;
		bool flag = (object)bins == null;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj3 = 0;
			double num3 = default;
			double num2 = num3;
			object obj5 = default;
			object obj4 = obj5;
			double num4 = 0.0;
			int num5 = 0;
			object obj8;
			object obj11 = default;
			object obj13 = default;
			NullReferenceException ex3 = default;
			do
			{
				num = (int)obj;
				int num6 = ringBuffer.Count;
				bool flag2 = num5 >= num6;
				num3 = num2;
				obj5 = obj4;
				double num7 = num4;
				if (!flag2)
				{
					if ((object)bins != null)
					{
						obj5 = obj2;
						double num8 = bins.get_Item(num5);
						double num9 = BinMidpoint(num5);
						object obj6 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v30+E4]");
						bool flag3 = (nint)0 == 0;
						object obj7 = !flag3;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
						num3 = num2 * num9;
						ringBuffer = bins;
						int num10 = num5 + 1;
						num7 = num4 + num3;
						bool flag4 = (object)bins == null;
						obj8 = !flag4;
						num = num5;
						num2 = num3;
						obj4 = obj5;
						num4 = num7;
						num5 = num10;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					bool flag5 = (nint)obj != 1;
					NullReferenceException ex2 = ex;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj9 = 0;
						object obj10 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
						object obj12 = obj13 & 1;
						if (obj12 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							return 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj14 = obj11;
						num = 101789696 + 1224;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj4 = 0;
						ex2 = ex3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return num2;
				}
				object obj15 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v5+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double result = num7 / count;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D190");
				return result;
			}
			while (obj8 != null);
		}
		throw new NullReferenceException();
	}

	public double MeanHarmonic()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Expected F8, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01f1: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_01cb: Expected F8, but got I4
		RingBuffer<double> ringBuffer = bins;
		if ((object)bins != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
			object obj2 = 0;
			double num = 0.0;
			int num2 = 0;
			double num8 = default;
			object obj5;
			object obj8 = default;
			object obj10 = default;
			NullReferenceException ex3 = default;
			do
			{
				object obj3 = obj;
				int num3 = ringBuffer.Count;
				bool flag = num2 >= num3;
				double num4 = num;
				if (!flag)
				{
					if ((object)bins != null)
					{
						object obj4 = obj2;
						double num5 = bins.get_Item(num2);
						double num6 = BinMidpoint(num2);
						double num7 = 1.0 / num6;
						ringBuffer = bins;
						num2++;
						num8 *= num7;
						num4 = num + num8;
						bool flag2 = (object)bins == null;
						obj5 = !flag2;
						num = num4;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					bool flag3 = (nint)obj != 1;
					NullReferenceException ex2 = ex;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj6 = 0;
						object obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
						object obj9 = obj10 & 1;
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							return 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj11 = obj8;
						obj3 = 101789696 + 1224;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						object obj4 = 0;
						ex2 = ex3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return num8;
				}
				return count / num4;
			}
			while (obj5 != null);
		}
		throw new NullReferenceException();
	}

	public double Variance()
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Expected F8, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_01dd: Expected F8, but got I4
		double num = Mean();
		RingBuffer<double> ringBuffer = bins;
		if ((object)bins != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
			object obj = 0;
			double num2 = 0.0;
			int num3 = 0;
			object obj3;
			object obj6 = default;
			object obj8 = default;
			NullReferenceException ex3 = default;
			do
			{
				int num4 = ringBuffer.Count;
				bool flag = num3 >= num4;
				double num5 = num2;
				if (!flag)
				{
					double num6 = BinMidpoint(num3);
					if ((object)bins != null)
					{
						object obj2 = obj;
						double num7 = bins.get_Item(num3);
						double num8 = num6 - num;
						ringBuffer = bins;
						num3++;
						double num9 = num8 * num8;
						double num10 = num9 * num6;
						num5 = num2 + num10;
						bool flag2 = (object)bins == null;
						obj3 = !flag2;
						num2 = num5;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					bool flag3 = num3 != 1;
					int num11 = num3;
					NullReferenceException ex2 = ex;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj4 = 0;
						object obj5 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
						object obj7 = obj8 & 1;
						if (obj7 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							return 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj9 = obj6;
						num11 = 101789696 + 1224;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						object obj2 = 0;
						ex2 = ex3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return num6;
				}
				double num12 = count + -1.0;
				return num5 / num12;
			}
			while (obj3 != null);
		}
		throw new NullReferenceException();
	}

	public double Quantile(double fraction)
	{
		return QuantileWithEstimator(fraction, (QuantileEstimator)6);
	}

	public unsafe double QuantileWithEstimator(double fraction, QuantileEstimator estimator)
	{
		//IL_0b1b: Invalid comparison between F8 and I4
		//IL_0b2e: Expected Obj, but got F8
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected Obj, but got Unknown
		//IL_0b57: Expected Obj, but got I4
		//IL_0b83: Expected Obj, but got I4
		//IL_0ba0: Invalid comparison between F8 and I4
		//IL_0bb1: Expected Obj, but got I4
		//IL_0d03: Expected Obj, but got I4
		//IL_0d1d: Invalid comparison between F8 and I4
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d39: Expected Obj, but got Unknown
		//IL_0d42: Expected F8, but got I4
		//IL_01d1: Expected F8, but got I
		//IL_022f: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_0c7f: Expected I4, but got Obj
		//IL_0463: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I4
		//IL_04eb: Expected Obj, but got I4
		//IL_02c1: Expected I4, but got Obj
		//IL_02ed: Expected Obj, but got I4
		//IL_0305: Invalid comparison between F8 and I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_0339: Expected I4, but got Obj
		//IL_0a4a: Expected Obj, but got I
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I4
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected I4, but got Unknown
		//IL_0571: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I4
		//IL_0ac5: Expected Obj, but got I4
		//IL_0395: Expected I4, but got Obj
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I4
		//IL_03ec: Expected I4, but got Obj
		//IL_0ae7: Expected Obj, but got I4
		//IL_0a9f: Expected F8, but got I4
		//IL_07fe: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I4
		//IL_0944: Expected Obj, but got I4
		//IL_0737: Expected Obj, but got I4
		//IL_0cbc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D48]");
		int num = 0;
		bool flag = fraction < 0.0;
		object obj = fraction ^ fraction;
		object obj2 = fraction & obj;
		bool flag2 = (nint)obj2 < 0;
		string error = (string)((int*)num)->m_value;
		bool flag3 = flag == flag2;
		bool flag4 = fraction < 1.0;
		object obj3 = !flag4;
		double num2 = fraction - 1.0;
		bool flag5 = num2 == 0.0;
		object obj4 = !flag5;
		object obj5 = obj3 & obj4;
		object obj6 = ~obj5;
		bool condition = obj6 != null && flag3;
		Assert.Check(condition, error);
		double num5;
		double num3;
		double num4;
		if (estimator > (QuantileEstimator)4)
		{
			if (estimator <= (QuantileEstimator)6)
			{
				if (estimator == (QuantileEstimator)5)
				{
					num3 = count;
					num4 = count + 1.0;
					goto IL_0c25;
				}
				if (estimator != (QuantileEstimator)6)
				{
					goto IL_018d;
				}
				num5 = count + -1.0;
				num3 = 1.0;
			}
			else if (estimator != (QuantileEstimator)7)
			{
				if (estimator != (QuantileEstimator)8)
				{
					goto IL_018d;
				}
				num5 = count + 0.25;
				num3 = 0.25000000002910383;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B6A8]");
				num3 = 0.0;
				double num6 = count;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B6A8]");
				num5 = num6 + 0.0;
			}
		}
		else
		{
			if (estimator != (QuantileEstimator)1)
			{
				if (estimator == (QuantileEstimator)2)
				{
					num5 = count;
					num3 = -0.5;
					goto IL_0c02;
				}
				if (estimator != (QuantileEstimator)4)
				{
					goto IL_018d;
				}
			}
			num5 = count;
			num3 = 0.5;
		}
		goto IL_0c02;
		IL_0c02:
		num4 = num5 * fraction;
		double num7 = num4 + num3;
		goto IL_0cde;
		IL_018d:
		num4 = count;
		goto IL_0c25;
		IL_0cde:
		double num8 = zeroCount;
		bool flag6 = num7 < zeroCount;
		object obj7 = !flag6;
		double num9 = num7 - zeroCount;
		bool flag7 = num9 == 0.0;
		object obj8 = ~obj7;
		object obj9 = obj8 | flag7;
		double result = 0.0;
		object obj24;
		int num18;
		if (obj9 == null)
		{
			RingBuffer<double> ringBuffer = bins;
			bool flag8 = (object)bins == null;
			object obj10 = 0;
			object obj11 = 109895680;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC0]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
				object obj12 = 0;
				double num10 = zeroCount;
				object obj13 = 0;
				double num11 = num4;
				string text = null;
				object obj20 = default;
				object obj22 = default;
				NullReferenceException ex5 = default;
				while (true)
				{
					error = (string)obj11;
					int num12 = ringBuffer.Count;
					bool flag9 = (nint)text >= num12;
					num8 = num10;
					obj10 = obj13;
					num4 = num11;
					num = (int)text;
					if (flag9)
					{
						goto IL_0425;
					}
					if ((object)bins != null)
					{
						obj10 = obj12;
						double num13 = bins.get_Item((int)text);
						num4 = num10 + num11;
						bool flag10 = num7 < num4;
						object obj14 = !flag10;
						double num14 = num7 - num4;
						bool flag11 = num14 == 0.0;
						object obj15 = ~obj14;
						object obj16 = obj15 | flag11;
						num8 = num10;
						error = text;
						num = (int)text;
						if (obj16 != null)
						{
							goto IL_0425;
						}
						bool flag12 = (object)bins == null;
						error = text;
						obj13 = obj12;
						num11 = num4;
						if (!flag12)
						{
							obj10 = obj12;
							double num15 = bins.get_Item((int)text);
							num8 = num10 + num4;
							ringBuffer = bins;
							string text2 = text + 1;
							bool flag13 = (object)bins == null;
							object obj17 = !flag13;
							error = text;
							num = (int)text2;
							num10 = num8;
							obj13 = obj12;
							num11 = num4;
							text = text2;
							if (obj17 == null)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					obj10 = obj13;
					num4 = num11;
					goto IL_09ec;
					IL_09fa:
					NullReferenceException ex3 = new NullReferenceException();
					bool flag14 = (nint)error != 1;
					NullReferenceException ex4 = ex3;
					if (!flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj18 = 0;
						object obj19 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
						object obj21 = obj22 & 1;
						if (obj21 != null)
						{
							goto IL_0a8c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj23 = obj20;
						error = (string)(101789696 + 1224);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj10 = 0;
						ex4 = ex5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return num4;
					IL_0425:
					if ((object)bins == null)
					{
						goto IL_09ec;
					}
					int num16 = bins.Count;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					obj24 = 0;
					object obj25 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v25+E4]");
					bool flag15 = (nint)0 == 0;
					object obj26 = !flag15;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num17 = num16 - 1;
					num18 = Math.Min(num, num17);
					bool flag16 = (object)bins == null;
					error = (string)num17;
					obj10 = 0;
					if (!flag16)
					{
						goto IL_04f9;
					}
					goto IL_09fa;
					IL_09ec:
					NullReferenceException ex6 = new NullReferenceException();
					goto IL_09fa;
				}
			}
			throw new NullReferenceException();
		}
		goto IL_0c8d;
		IL_0c25:
		num7 = num4 * fraction;
		goto IL_0cde;
		IL_0c8d:
		return result;
		IL_04f9:
		double num19 = bins.get_Item(num18);
		int exp = minExp + num18;
		double num20 = LowerBound(resolution, exp);
		object obj27 = num18 + minExp;
		int exp2 = obj27 + 1;
		double num21 = LowerBound(resolution, exp2);
		object obj28 = estimator - 3;
		bool flag17 = (nint)obj28 < 6;
		object obj29 = !flag17;
		if (obj29 == null)
		{
			object obj30 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v51+E4]");
			bool flag18 = (nint)0 == 0;
			object obj31 = !flag18;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			double num22 = num4 + 1.0;
			double num23 = num21 - num8;
			object obj32 = default;
			double num24 = (double)obj32 - num8;
			double num25 = num7 - num21;
			double num26 = num23 / num22;
			double num27 = num24 / num22;
			double num28 = num21 - num20;
			double num29 = num26 * num28;
			double num30 = num20 + num29;
			double num31 = num27 * num28;
			double num32 = num20 + num31;
			double num33 = num32 - num30;
			double num34 = num25 * num33;
			result = num30 + num34;
		}
		else if (estimator != (QuantileEstimator)1)
		{
			double num40;
			if (estimator == (QuantileEstimator)2)
			{
				object obj33 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v40+E4]");
				bool flag19 = (nint)0 == 0;
				object obj34 = !flag19;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj35 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v43+E4]");
				bool flag20 = (nint)0 == 0;
				object obj36 = !flag20;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num35 = Math.Round(num7, 0, (MidpointRounding)0);
				double num36 = num35 - num8;
				double num37 = num4 + 1.0;
				double num38 = num36 / num37;
				double num39 = num21 - num20;
				num40 = num39 * num38;
			}
			else
			{
				object obj37 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X0_v37+E4]");
				bool flag21 = (nint)0 == 0;
				object obj38 = !flag21;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				double num41 = num4 + 1.0;
				double num42 = num21 - num8;
				double num43 = num42 / num41;
				double num44 = num21 - num20;
				num40 = num43 * num44;
			}
			result = num20 + num40;
		}
		else
		{
			object obj39 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v33+E4]");
			bool flag22 = (nint)0 == 0;
			object obj40 = !flag22;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num45 = num7 + -0.5;
			double num46 = num7 + 0.5;
			double num47 = num4 + 1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num48 = num45 - num8;
			double num49 = num46 - num8;
			double num50 = num48 / num47;
			double num51 = num49 / num47;
			double num52 = num21 - num20;
			double num53 = num50 * num52;
			double num54 = num20 + num53;
			double num55 = num51 * num52;
			double num56 = num20 + num55;
			double num57 = num54 + num56;
			result = num57 * 0.5;
		}
		goto IL_0c8d;
		IL_0a8c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		result = 0.0;
		goto IL_0c8d;
	}

	public double MaxRelativeSampleError()
	{
		double num = Base(resolution);
		double num2 = num + -1.0;
		double num3 = num + 1.0;
		return num2 / num3;
	}

	public double MaxRelativeQuantileError()
	{
		double num = Base(resolution);
		return num + -1.0;
	}

	private unsafe int Downsample(int desiredMinExp, int desiredMaxExp)
	{
		//IL_07df: Expected Obj, but got I4
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected I4, but got Unknown
		//IL_0844: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0890: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_01b3: Expected I4, but got I8
		//IL_01c9: Expected I4, but got I8
		//IL_020f: Expected I4, but got I8
		//IL_0225: Expected I4, but got I8
		//IL_0264: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_04fb: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected I4, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected I4, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected I4, but got Unknown
		//IL_037a: Expected F8, but got I4
		//IL_0384: Expected I4, but got Obj
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected I4, but got Unknown
		//IL_05b5: Expected F8, but got I4
		//IL_05bf: Expected I4, but got Obj
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e7: Expected I4, but got Obj
		//IL_03f4: Expected Obj, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_061a: Expected I4, but got Obj
		//IL_0627: Expected Obj, but got I4
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0476: Expected I4, but got Obj
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_06c1: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D20]");
		int num = 0;
		object obj = desiredMaxExp - desiredMinExp;
		bool flag = (nint)obj < 0;
		int num2 = desiredMaxExp ^ desiredMinExp;
		int num3 = desiredMaxExp ^ obj;
		int num4 = num2 & num3;
		bool flag2 = num4 < 0;
		bool condition = flag == flag2;
		Assert.Check(condition, (string)((int*)num)->m_value);
		RingBuffer<double> ringBuffer = bins;
		bool flag3 = (object)bins == null;
		int num5 = 109895680;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D08]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D38]");
			int num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			num5 = 0;
			int num7 = desiredMinExp;
			int num8 = desiredMaxExp;
			int num9 = 0;
			int num26 = default;
			int num24 = default;
			int num22 = default;
			while (true)
			{
				int capacity = ringBuffer.Capacity;
				object obj3 = capacity + num7;
				bool flag4 = (nint)obj3 > num8;
				num = num9;
				if (!flag4)
				{
					ringBuffer = bins;
					num7 >>= 1;
					num8 >>= 1;
					num = num9 + 1;
					bool flag5 = (object)bins == null;
					object obj4 = !flag5;
					num9 = num;
					if (obj4 == null)
					{
						break;
					}
					continue;
				}
				int num10 = ~num;
				bool condition2 = (byte)(num10 >> 31) != 0;
				Assert.Check(condition2, (string)((int*)num6)->m_value);
				int num11;
				int num12;
				int num15;
				int num16;
				int num17;
				int num18;
				int num19;
				int num20;
				object obj6;
				if (num > 0)
				{
					num6 = maxExp;
					int value = ((int*)num5)->m_value;
					int val = minExp >> num;
					num11 = maxExp >> num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v8 (System.Int32)+E4]");
					bool flag6 = (nint)0 == 0;
					object obj5 = !flag6;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num12 = num & 0x1F;
					int num13 = Math.Min(minExp, -1);
					int num14 = Math.Min(num6, -1);
					num15 = Math.Max(minExp, 1);
					num16 = Math.Max(num6, 1);
					num17 = Math.Min(val, -1);
					num18 = Math.Min(num11, -1);
					num19 = Math.Max(val, 1);
					num20 = Math.Max(num11, 1);
					obj6 = num14 - num13;
					if ((nint)obj6 >= 1 && num14 >= num13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D18]");
						num6 = 0;
						int num21 = num22;
						int num23 = num24;
						object obj8 = 0;
						object obj9 = obj2;
						num5 = num11;
						while (true)
						{
							int num25 = BinIndex(num14);
							bool flag7 = (object)bins == null;
							num22 = num21;
							num26 = num26;
							num24 = num23;
							object obj10 = obj8;
							obj2 = obj9;
							if (flag7)
							{
								break;
							}
							int index = num25 + obj8;
							double num27 = bins.get_Item(index);
							bool flag8 = (object)bins == null;
							num22 = num21;
							num26 = num26;
							num24 = num23;
							obj10 = obj8;
							obj2 = obj9;
							if (flag8)
							{
								break;
							}
							int index2 = num25 + obj8;
							bins.set_Item(index2, (double)((int*)num6)->m_value);
							num5 = (int)bins;
							bool flag9 = (object)bins == null;
							num22 = num21;
							num26 = 0;
							num24 = 0;
							obj10 = obj8;
							obj2 = obj9;
							if (flag9)
							{
								break;
							}
							object obj11 = num14 + obj8;
							int num28 = obj11 >> num12;
							obj2 = num28 - num18;
							object obj12 = num25 + obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @43356F4");
							object obj13 = num25 + obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4335824");
							obj10 = obj8 - 1;
							object obj14 = num14 + obj10;
							bool flag10 = (nint)obj14 >= num13;
							num22 = num18;
							num26 = num26;
							num24 = num26;
							num11 = (int)bins;
							num21 = num18;
							num23 = num26;
							obj8 = obj10;
							obj9 = obj2;
							if (flag10)
							{
								continue;
							}
							goto IL_04a5;
						}
						break;
					}
					goto IL_04a5;
				}
				goto IL_0988;
				IL_0988:
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				int num29 = resolution - num;
				resolution = num29;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SSHL not yet implemented.\"");
				minExp = num26;
				return num;
				IL_06cf:
				object obj15 = num17 + obj6;
				object obj16 = obj15 - num18;
				if ((nint)obj16 >= 1)
				{
					num5 = 0;
					while (true)
					{
						bool flag11 = (object)bins == null;
						num22 = num18;
						if (flag11)
						{
							break;
						}
						double num30 = bins.PopFront();
						num5++;
						if (num5 < (nint)obj16)
						{
							continue;
						}
						goto IL_074e;
					}
					break;
				}
				goto IL_074e;
				IL_074e:
				object obj18;
				object obj17 = num19 + obj18;
				object obj19 = obj17 - num20;
				if ((nint)obj19 >= 1)
				{
					num5 = 0;
					while (true)
					{
						bool flag12 = (object)bins == null;
						num22 = num20;
						if (flag12)
						{
							break;
						}
						double num31 = bins.PopBack();
						num5++;
						if (num5 < (nint)obj19)
						{
							continue;
						}
						goto IL_0988;
					}
					break;
				}
				goto IL_0988;
				IL_04a5:
				obj18 = num16 - num15;
				if ((nint)obj18 >= 1 && num16 >= num15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CC8]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D18]");
					num6 = 0;
					int num32 = num24;
					object obj21 = 0;
					object obj22 = obj2;
					while (true)
					{
						int num33 = BinIndex(num15);
						bool flag13 = (object)bins == null;
						num26 = num26;
						num24 = num32;
						object obj10 = obj21;
						obj2 = obj22;
						num5 = num11;
						if (flag13)
						{
							break;
						}
						int index3 = num33 + obj21;
						double num34 = bins.get_Item(index3);
						bool flag14 = (object)bins == null;
						num26 = num26;
						num24 = num32;
						obj10 = obj21;
						obj2 = obj22;
						num5 = num11;
						if (flag14)
						{
							break;
						}
						int index4 = num33 + obj21;
						bins.set_Item(index4, (double)((int*)num6)->m_value);
						num5 = (int)bins;
						bool flag15 = (object)bins == null;
						num26 = 0;
						num24 = 0;
						obj10 = obj21;
						obj2 = obj22;
						if (flag15)
						{
							break;
						}
						object obj23 = num15 + obj21;
						int num35 = obj23 >> num12;
						obj2 = num35 - num19;
						object obj24 = num33 + obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @43356F4");
						object obj25 = num33 + obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4335824");
						obj10 = obj21 + 1;
						object obj26 = num15 + obj10;
						bool flag16 = (nint)obj26 <= num16;
						num26 = num26;
						num24 = num26;
						num22 = num16;
						num32 = num26;
						obj21 = obj10;
						obj22 = obj2;
						num11 = (int)bins;
						if (flag16)
						{
							continue;
						}
						goto IL_06cf;
					}
					break;
				}
				goto IL_06cf;
			}
		}
		throw new NullReferenceException();
	}

	private int Exponent(double value)
	{
		return Exponent(resolution, value);
	}

	private int BinExponent(int index)
	{
		return minExp + index;
	}

	public int BinIndex(int exponent)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D40]");
		object error = 0;
		int num = exponent - minExp;
		int num2 = ~num;
		bool condition = (byte)(num2 >> 31) != 0;
		Assert.Check(condition, (string)error);
		return num;
	}

	private double BinLowerBound(int index)
	{
		int exp = minExp + index;
		return LowerBound(resolution, exp);
	}

	private double BinMidpoint(int index)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected I4, but got Unknown
		int exp = minExp + index;
		double num = LowerBound(resolution, exp);
		object obj = index + minExp;
		int exp2 = obj + 1;
		double num2 = LowerBound(resolution, exp2);
		double num3 = num + num2;
		return num3 * 0.5;
	}

	private static int Resolution(double error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_00a7: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = error + 1.0;
		double num2 = 1.0 - error;
		double num3 = num / num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B118]");
		double num4 = 0.0 - num3;
		double num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C518]");
		double num6 = num5 * 0.0;
		return (int)num6;
	}

	private static double Contrast(double min, double max)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0079: Invalid comparison between F8 and I4
		//IL_008c: Expected Obj, but got F8
		//IL_0099: Expected Obj, but got F8
		//IL_00fa: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CA8]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		double num = max - min;
		bool flag = num < 0.0;
		object obj2 = max ^ min;
		object obj3 = max ^ num;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool condition = flag == flag2;
		Assert.Check(condition, (string)error);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
		return max - min;
	}

	private static int Capacity(double contrast, int resolution)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I4
		//IL_0078: Invalid comparison between F8 and I4
		//IL_0090: Expected Obj, but got F8
		//IL_009d: Expected Obj, but got F8
		//IL_00de: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6CB8]");
		object error = 0;
		double num = Base(resolution);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
		double num2 = contrast / num;
		double num3 = num2 + 1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num4 = num2 - 1.0;
		bool flag2 = num4 < 0.0;
		object obj4 = num2 ^ 1.0;
		object obj5 = num2 ^ num4;
		object obj6 = obj4 & obj5;
		bool flag3 = (nint)obj6 < 0;
		bool condition = flag2 == flag3;
		Assert.Check(condition, (string)error);
		return (int)num3;
	}

	private static double MaxRelativeSampleError(int resolution)
	{
		double num = Base(resolution);
		double num2 = num + -1.0;
		double num3 = num + 1.0;
		return num2 / num3;
	}

	private static double MaxRelativeQuantileError(int resolution)
	{
		double num = Base(resolution);
		return num + -1.0;
	}

	public double Base()
	{
		return Base(resolution);
	}

	private static double Base(int resolution)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = -resolution;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C120]");
		object obj5 = obj4 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D190");
		double num = (double)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C120]");
		double result = num * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D190");
		return result;
	}

	private static double CopySign(double x, double s)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return s;
	}

	private unsafe static (double, int) FrExp(double value)
	{
		//IL_0126: Invalid comparison between F8 and I4
		//IL_0118: Expected VT, but got Ref
		//IL_0147: Expected native int or pointer, but got VT
		//IL_001d: Expected Obj, but got F8
		//IL_0037: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00f1: Expected VT, but got I4
		//IL_00f9: Expected I4, but got F8
		//IL_0101: Expected VT, but got Ref
		double num = default;
		(double, int) result = default;
		int item;
		(double, int) tuple;
		if (num != 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			double num2 = default;
			object obj = num2 >> 52;
			bool flag = (nint)obj < 2047;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num3 = Math.Log(num2, 2.0);
				double num4 = num3 + 1.0;
				double num5 = Math.Pow(2.0, num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
				result = ((double, int))0;
				item = (int)num4;
				tuple = ((double, int))(&result);
				goto IL_013b;
			}
		}
		item = 0;
		tuple = ((double, int))(&result);
		goto IL_013b;
		IL_013b:
		*((double, int)*)(nint)tuple = (num, item);
		return result;
	}

	private static int Exponent(int resolution, double value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00d4: Expected F8, but got I4
		//IL_0108: Expected F8, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0144: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		double d = default;
		object obj5;
		do
		{
			bool flag = 4472074429978902528L == 0L;
			bool condition = !flag;
			Assert.Check(condition, (string)obj);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = double.IsSubnormal(d);
			bool flag4 = !flag3;
			obj5 = !flag4;
		}
		while (obj5 != null);
		(double, int) tuple = FrExp(9.313225746154785E-10);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = Math.Pow(2.0, resolution);
		double num2 = num * (double)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
		double num3 = Math.Pow(2.0, resolution);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C518]");
		object obj8 = tuple * 0;
		double num4 = (double)obj8 * num3;
		double num5 = num2 + num4;
		return (int)num5;
	}

	private static double LowerBound(int resolution, int exp)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = -resolution;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C120]");
		object obj5 = obj4 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D190");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C120]");
		object obj6 = obj5 * 0;
		double result = (double)obj6 * (double)exp;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D190");
		return result;
	}

	internal static double _003CQuantileWithEstimator_003Eg__Upsample_007C26_0(double cutCount, ref JsonNetworkObjectDB._003C_003Ec__DisplayClass26_0 P_1)
	{
		//IL_005c: Expected Obj, but got I
		double num = cutCount - (double)P_1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X0 (<>c__DisplayClass26_0&)+8]");
		double num2 = 0.0 + 1.0;
		double num3 = num / num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X0 (<>c__DisplayClass26_0&)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X0 (<>c__DisplayClass26_0&)+10]");
		object obj = num4 - 0;
		double num5 = num3 * (double)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X0 (<>c__DisplayClass26_0&)+10]");
		return 0.0 + num5;
	}
}
