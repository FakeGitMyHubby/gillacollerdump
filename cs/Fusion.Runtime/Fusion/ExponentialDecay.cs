using Cpp2ILInjected;

namespace Fusion;

internal class ExponentialDecay
{
	private double Fraction__BackingField;

	private double Time__BackingField;

	private double TimeScale__BackingField;

	public double Fraction
	{
		get
		{
			return Fraction__BackingField;
		}
		internal set
		{
			Fraction__BackingField = value;
		}
	}

	public double Time
	{
		get
		{
			return Time__BackingField;
		}
		internal set
		{
			Time__BackingField = value;
		}
	}

	public double TimeScale
	{
		get
		{
			return TimeScale__BackingField;
		}
		internal set
		{
			TimeScale__BackingField = value;
		}
	}

	public double Rate
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I4
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
			double num = Time__BackingField * TimeScale__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D180");
			return Fraction__BackingField / num;
		}
	}

	public double Calculate(double elapsed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		double rate = Rate;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double result = rate * elapsed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D190");
		return result;
	}

	public double CalculateLimit(double period)
	{
		double num = Calculate(period);
		double num2 = 1.0 - num;
		return 1.0 / num2;
	}

	public ExponentialDecay(double fraction, double time)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0058: Invalid comparison between F8 and I4
		//IL_0067: Invalid comparison between F8 and I4
		//IL_007a: Expected Obj, but got F8
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00f7: Invalid comparison between F8 and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0126: Invalid comparison between F8 and I4
		//IL_0135: Invalid comparison between F8 and I4
		//IL_0148: Expected Obj, but got F8
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C80]");
		object error = 0;
		base._002Ector();
		bool flag = fraction < 0.0;
		bool flag2 = fraction == 0.0;
		object obj2 = fraction ^ fraction;
		object obj3 = fraction & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		bool flag5 = fraction < 1.0;
		object obj6 = !flag5;
		double num = fraction - 1.0;
		bool flag6 = num == 0.0;
		object obj7 = ~obj6;
		object obj8 = obj7 | flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F72FC");
		bool flag7 = time < 0.0;
		bool flag8 = time == 0.0;
		object obj9 = time ^ time;
		object obj10 = time & obj9;
		bool flag9 = (nint)obj10 < 0;
		bool flag10 = flag7 == flag9;
		object obj11 = !flag8;
		bool condition = (byte)((flag10 & obj11) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		Fraction__BackingField = fraction;
		Time__BackingField = time;
		TimeScale__BackingField = 1.0;
	}
}
