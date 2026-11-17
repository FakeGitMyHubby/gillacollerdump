using Cpp2ILInjected;

namespace Fusion;

public struct TickAccumulator
{
	private double _time;

	private double _scale;

	private int _ticks;

	private bool _running;

	public int Pending => _ticks;

	public double Remainder => _time;

	public bool Running => _running;

	public double TimeScale
	{
		get
		{
			return _scale;
		}
		set
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41C8]");
			object error = 0;
			bool flag = value < 0.0;
			bool flag2 = value == 0.0;
			object obj = value ^ value;
			object obj2 = value & obj;
			bool flag3 = (nint)obj2 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			bool condition = (byte)((flag4 & obj3) ? 1 : 0) != 0;
			Assert.Check(condition, (string)error);
			_scale = value;
		}
	}

	public float Alpha(double step)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double v = (double)_ticks / step;
		double num = Maths.Clamp01(v);
		return (float)num;
	}

	public void AddTicks(int ticks)
	{
		int ticks2 = _ticks + ticks;
		_ticks = ticks2;
	}

	public void AddTime(double dt, double step, int? maxTicks = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0281: Invalid comparison between F8 and I4
		//IL_0294: Expected Obj, but got F8
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02d4: Invalid comparison between F8 and I4
		//IL_02e3: Invalid comparison between F8 and I4
		//IL_02f6: Expected Obj, but got F8
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected I4, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0050: Invalid comparison between F8 and I4
		//IL_0061: Invalid comparison between F8 and I4
		//IL_0078: Expected Obj, but got F8
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected I4, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0191: Invalid comparison between VT and I4
		//IL_01bf: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F18]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F20]");
		object error2 = 0;
		bool flag = dt < 0.0;
		object obj = dt ^ dt;
		object obj2 = dt & obj;
		bool flag2 = (nint)obj2 < 0;
		bool condition = flag == flag2;
		Assert.Check(condition, (string)error);
		bool flag3 = step < 0.0;
		bool flag4 = step == 0.0;
		object obj3 = step ^ step;
		object obj4 = step & obj3;
		bool flag5 = (nint)obj4 < 0;
		bool flag6 = flag3 == flag5;
		object obj5 = !flag4;
		bool condition2 = (byte)((flag6 & obj5) ? 1 : 0) != 0;
		Assert.Check(condition2, (string)error2);
		if (~(_running ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F30]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F28]");
		object error4 = 0;
		bool flag7 = _scale < 0.0;
		bool flag8 = _scale == 0.0;
		object obj6 = _scale ^ _scale;
		object obj7 = _scale & obj6;
		bool flag9 = (nint)obj7 < 0;
		bool flag10 = flag7 == flag9;
		object obj8 = !flag8;
		bool condition3 = (byte)((flag10 & obj8) ? 1 : 0) != 0;
		Assert.Check(condition3, (string)error3);
		object obj9 = dt & 0x7FFFFFFFFFFFFFFFL;
		object obj10 = obj9 - 9218868437227405312L;
		bool flag11 = obj10 == null;
		bool condition4 = !flag11;
		Assert.Check(condition4, (string)error4);
		double num = _scale * dt;
		double time = _time + num;
		_time = time;
		int? num2 = maxTicks;
		int? num4 = default;
		while (!(_time < step))
		{
			double time2 = _time - step;
			int num3 = ++_ticks;
			_time = time2;
			if (num2 != (object)0)
			{
				int value = num4.Value;
				object obj11 = num3 - value;
				bool flag12 = (nint)obj11 < 0;
				int num5 = num3 ^ value;
				int num6 = num3 ^ obj11;
				int num7 = num5 & num6;
				bool flag13 = num7 < 0;
				bool flag14 = flag12 == flag13;
				bool flag15 = !flag14;
				num2 = num4;
				if (!flag15)
				{
					int? num8 = num4;
					_time = 0.0;
					int value2 = num8.Value;
					_ticks = value2;
					break;
				}
			}
			else
			{
				int? num8 = num2;
			}
		}
	}

	public void Stop()
	{
		_running = false;
	}

	public void Start()
	{
		_running = true;
	}

	public unsafe bool ConsumeTick(out bool last)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F38]");
		object error = 0;
		int num = ~_ticks;
		bool condition = (byte)(num >> 31) != 0;
		Assert.Check(condition, (string)error);
		int num2 = _ticks - 1;
		bool flag2;
		if (_ticks >= 1)
		{
			bool flag = num2 == 0;
			_ticks = num2;
			flag2 = flag;
		}
		else
		{
			flag2 = false;
		}
		ref bool reference = ref *(flag2 ? ((bool*)1) : ((bool*)null));
		bool flag3 = _ticks < 0;
		bool flag4 = _ticks == 0;
		int num3 = _ticks ^ _ticks;
		int num4 = _ticks & num3;
		bool flag5 = num4 < 0;
		bool flag6 = flag3 == flag5;
		object obj = !flag4;
		return (byte)((flag6 & obj) ? 1 : 0) != 0;
	}

	public unsafe static TickAccumulator StartNew()
	{
		//IL_001f: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		//IL_0037: Expected VT, but got Ref
		TickAccumulator tickAccumulator = default;
		tickAccumulator.TimeScale = 1.0;
		TickAccumulator tickAccumulator2 = default;
		((TickAccumulator*)(nint)tickAccumulator2)->_time = 0.0;
		((TickAccumulator*)(nint)tickAccumulator2)->_ticks = 0;
		return (TickAccumulator)(&tickAccumulator);
	}
}
