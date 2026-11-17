using System;
using Cpp2ILInjected;
using UnityEngine.InputSystem;

namespace Fusion;

internal class FixedFeedback : Action<InputActionAsset.CallbackContext>
{
	private readonly double _outputMin;

	private readonly double _outputMax;

	private readonly double _deadzoneMin;

	private readonly double _deadzoneMax;

	private double _output;

	public FixedFeedback(double outputMin, double outputMax, double deadzoneMin, double deadzoneMax)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_019d: Expected I4, but got Obj
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_01e3: Expected I4, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_00fd: Invalid comparison between F8 and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABD8]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABE0]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABE8]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABF0]");
		object error4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABF8]");
		object error5 = 0;
		base._002Ector();
		object obj = outputMin & 0x7FFFFFFFFFFFFFFFL;
		bool flag = (long)obj < 9218868437227405313L;
		object obj2 = !flag;
		bool condition = (byte)(int)(~obj2) != 0;
		Assert.Check(condition, (string)error);
		object obj3 = outputMax & 0x7FFFFFFFFFFFFFFFL;
		bool flag2 = (long)obj3 < 9218868437227405313L;
		object obj4 = !flag2;
		bool condition2 = (byte)(int)(~obj4) != 0;
		Assert.Check(condition2, (string)error2);
		Assert.Check((object)(obj - 9218868437227405312L) != null, (string)error3);
		Assert.Check((object)(obj3 - 9218868437227405312L) != null, (string)error4);
		Assert.Check((byte)((~(object)(!(outputMin < outputMax)) | (outputMin - outputMax == 0.0)) ? 1 : 0) != 0, (string)error5);
		_outputMin = outputMin;
		_outputMax = outputMax;
		_deadzoneMin = deadzoneMin;
		_deadzoneMax = deadzoneMax;
		_output = 0.0;
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
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01cc: Expected Obj, but got I4
		//IL_01d5: Expected I4, but got Obj
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_0254: Expected I4, but got Obj
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_00d7: Expected I4, but got Obj
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_017e: Expected F8, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_026e: Expected F8, but got Obj
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
		double num = target - sample;
		object obj10;
		double output;
		if (num > _deadzoneMax)
		{
			obj10 = this + 24;
		}
		else
		{
			bool flag7 = !(num < _deadzoneMin);
			output = 0.0;
			if (flag7)
			{
				goto IL_0273;
			}
			obj10 = this + 16;
		}
		output = (double)obj10;
		goto IL_0273;
		IL_0273:
		_output = output;
	}

	private void Fusion_002EIFeedbackController_002EReset()
	{
		_output = 0.0;
	}

	private void Fusion_002EIFeedbackController_002EResetOutput()
	{
		_output = 0.0;
	}
}
