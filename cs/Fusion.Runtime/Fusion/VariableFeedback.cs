using System;
using Cpp2ILInjected;
using UnityEngine.InputSystem;

namespace Fusion;

internal class VariableFeedback : Action<InputActionAsset.CallbackContext>
{
	private readonly double _Kp;

	private readonly double _Ki;

	private readonly double _Kd;

	private readonly double _outputMin;

	private readonly double _outputMax;

	private double _lastSample;

	private double _sum;

	private double _output;

	public VariableFeedback(double Kp, double Ki, double Kd, double outputMin, double outputMax)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_033c: Expected Obj, but got I4
		//IL_0345: Expected I4, but got Obj
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_00be: Expected I4, but got Obj
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_0142: Expected I4, but got Obj
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_01c6: Expected I4, but got Obj
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got I4
		//IL_020c: Expected I4, but got Obj
		//IL_0237: Expected Obj, but got I4
		//IL_024f: Invalid comparison between F8 and I4
		//IL_0265: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC30]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC38]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC40]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC48]");
		object error4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC50]");
		object error5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC58]");
		object error6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABD8]");
		object error7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABE0]");
		object error8 = 0;
		base._002Ector();
		object obj = Kp & 0x7FFFFFFFFFFFFFFFL;
		bool flag = (long)obj < 9218868437227405313L;
		object obj2 = !flag;
		bool condition = (byte)(int)(~obj2) != 0;
		Assert.Check(condition, (string)error);
		object obj3 = obj - 9218868437227405312L;
		bool flag2 = obj3 == null;
		bool condition2 = !flag2;
		Assert.Check(condition2, (string)error2);
		object obj4 = Ki & 0x7FFFFFFFFFFFFFFFL;
		Assert.Check((byte)(int)(~(object)((long)obj4 >= 9218868437227405313L)) != 0, (string)error3);
		Assert.Check((object)(obj4 - 9218868437227405312L) != null, (string)error4);
		object obj5 = Kd & 0x7FFFFFFFFFFFFFFFL;
		Assert.Check((byte)(int)(~(object)((long)obj5 >= 9218868437227405313L)) != 0, (string)error5);
		Assert.Check((object)(obj5 - 9218868437227405312L) != null, (string)error6);
		Assert.Check((byte)(int)(~(object)((long)(object)(outputMin & 0x7FFFFFFFFFFFFFFFL) >= 9218868437227405313L)) != 0, (string)error7);
		Assert.Check((byte)(int)(~(object)((long)(object)(outputMax & 0x7FFFFFFFFFFFFFFFL) >= 9218868437227405313L)) != 0, (string)error8);
		object obj6 = !(outputMin < outputMax);
		bool flag3 = outputMin - outputMax == 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABF8]");
		Assert.Check((byte)((~obj6 | flag3) ? 1 : 0) != 0, (string)0);
		double ki = Kp * Ki;
		double kd = Kp * Kd;
		_outputMin = outputMin;
		_outputMax = outputMax;
		_sum = 0.0;
		_output = 0.0;
		_lastSample = 0.0;
		_Kp = Kp;
		_Ki = ki;
		_Kd = kd;
	}

	private double Fusion_002EIFeedbackController_002EOutput()
	{
		return _output;
	}

	private void Fusion_002EIFeedbackController_002EUpdate(double sample, double target, double dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0304: Expected Obj, but got I4
		//IL_030d: Expected I4, but got Obj
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0383: Expected Obj, but got I4
		//IL_038c: Expected I4, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00e7: Expected I4, but got Obj
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_014b: Invalid comparison between F8 and I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC00]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC08]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC10]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC18]");
		object error4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC20]");
		object error5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F28]");
		object error6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC60]");
		object error7 = 0;
		object obj = sample & 0x7FFFFFFFFFFFFFFFL;
		bool flag = (long)obj < 9218868437227405313L;
		object obj2 = !flag;
		bool condition = (byte)(int)(~obj2) != 0;
		Assert.Check(condition, (string)error);
		object obj3 = obj - 9218868437227405312L;
		bool flag2 = obj3 == null;
		bool condition2 = !flag2;
		Assert.Check(condition2, (string)error2);
		object obj4 = target & 0x7FFFFFFFFFFFFFFFL;
		bool flag3 = (long)obj4 < 9218868437227405313L;
		object obj5 = !flag3;
		bool condition3 = (byte)(int)(~obj5) != 0;
		Assert.Check(condition3, (string)error3);
		object obj6 = obj4 - 9218868437227405312L;
		bool flag4 = obj6 == null;
		bool condition4 = !flag4;
		Assert.Check(condition4, (string)error4);
		object obj7 = dt & 0x7FFFFFFFFFFFFFFFL;
		bool flag5 = (long)obj7 < 9218868437227405313L;
		object obj8 = !flag5;
		bool condition5 = (byte)(int)(~obj8) != 0;
		Assert.Check(condition5, (string)error5);
		object obj9 = obj7 - 9218868437227405312L;
		bool flag6 = obj9 == null;
		bool condition6 = !flag6;
		Assert.Check(condition6, (string)error6);
		double num = dt - 1.0;
		bool flag7 = num < 0.0;
		object obj10 = dt ^ 1;
		object obj11 = dt ^ num;
		object obj12 = obj10 & obj11;
		bool flag8 = (nint)obj12 < 0;
		bool condition7 = flag7 == flag8;
		Assert.Check(condition7, (string)error7);
		double num2 = target - sample;
		double num3 = num2 * _Kp;
		double num4 = _outputMax;
		_lastSample = sample;
		double num5 = sample - _lastSample;
		_output = num3;
		bool flag9 = num3 > _outputMax;
		double num6 = _outputMax;
		if (!flag9)
		{
			num6 = _outputMin;
			if (!(num3 < _outputMin))
			{
				goto IL_039e;
			}
		}
		_output = num6;
		num3 = num6;
		goto IL_039e;
		IL_039e:
		double num7 = _Kd / dt;
		double num8 = _Ki * dt;
		double num9 = num2 * num8;
		double num10 = num5 * num7;
		double num11 = num9 - num10;
		double num12 = _sum + num11;
		double num13 = num3 + num12;
		_sum = num12;
		_output = num13;
		double sum;
		if (num13 > num4)
		{
			double num14 = num13 - num4;
			sum = num12 - num14;
		}
		else
		{
			num4 = _outputMin;
			if (!(num13 < _outputMin))
			{
				return;
			}
			double num15 = _outputMin - num13;
			sum = num12 + num15;
		}
		_sum = sum;
		_output = num4;
	}

	private void Fusion_002EIFeedbackController_002EReset()
	{
		_lastSample = 0.0;
		_sum = 0.0;
		_output = 0.0;
	}

	private void Fusion_002EIFeedbackController_002EResetOutput()
	{
		_output = 0.0;
	}
}
