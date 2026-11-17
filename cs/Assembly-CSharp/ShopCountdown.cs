using System;
using Cpp2ILInjected;
using UnityEngine;

public class ShopCountdown : MonoBehaviour
{
	private PixelLabel label;

	private float next;

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 0;
	}

	private void Update()
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		float unscaledTime = Time.unscaledTime;
		if (!(unscaledTime < next))
		{
			float unscaledTime2 = Time.unscaledTime;
			float num = unscaledTime2 + 1f;
			next = num;
			string text = Text();
			PixelLabel pixelLabel = label;
			if (!(text == pixelLabel.text))
			{
				object obj = label + 32;
				obj = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				label.Redraw();
			}
		}
	}

	public static string Text()
	{
		//IL_0010: Expected Obj, but got I
		//IL_063f: Expected Obj, but got I
		//IL_0661: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_067f: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I
		//IL_069c: Expected VT, but got Obj
		//IL_06f9: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I4
		//IL_05fd: Expected Obj, but got I4
		//IL_0717: Expected Obj, but got I
		//IL_071f: Expected VT, but got Obj
		//IL_0195: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I8
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got I
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_0414: Expected Obj, but got I8
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0473: Expected Obj, but got I4
		//IL_0489: Expected Obj, but got I
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_0521: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_057a: Expected Obj, but got I
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
		object obj5 = 0;
		DateTime nextStock = ShopStand.NextStock;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		TimeSpan timeSpan = nextStock - utcNow;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj11 = 0;
		bool flag4 = timeSpan < (TimeSpan)obj10;
		bool flag5 = !flag4;
		TimeSpan timeSpan2 = timeSpan;
		if (!flag5)
		{
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v69+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v69+A0]");
			object obj14 = 0;
			timeSpan2 = (TimeSpan)obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int days = timeSpan2.Days;
		int num = default;
		string[] array = default;
		string text3;
		if (days > 0)
		{
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9D8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v57+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int days2 = timeSpan2.Days;
			string text = num.ToString();
			string text2 = text + (string)obj18;
			bool flag9 = array == null;
			object obj20 = 0;
			text3 = text2;
			if (!flag9)
			{
				goto IL_0232;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj21 = 0;
			text3 = (string)obj21;
			bool flag10 = array == null;
			object obj22 = !flag10;
			object obj20 = 0;
			if (obj22 != null)
			{
				goto IL_0232;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0619;
		IL_0619:
		return (string)(object)new IndexOutOfRangeException();
		IL_0232:
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
			object obj23 = 0;
			object obj24 = array + 32;
			obj24 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj25 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v27+E4]");
			bool flag11 = (nint)0 == 0;
			object obj26 = !flag11;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int hours = timeSpan2.Hours;
			string text4 = num.ToString((string)obj23);
			object obj27 = array.Length & 0xFFFFFFFEL;
			if (obj27 != null)
			{
				object obj28 = array + 40;
				obj28 = text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X20_v6-10]");
				bool flag12 = (nint)0 < (nint)2;
				object obj29 = !flag12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X20_v6-10]");
				object obj30 = -2;
				bool flag13 = obj30 == null;
				object obj31 = ~obj29;
				object obj32 = obj31 | flag13;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
					object obj33 = 0;
					object obj34 = array + 48;
					obj34 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int minutes = timeSpan2.Minutes;
					string text5 = num.ToString((string)obj23);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X20_v8-18]");
					object obj35 = 0 & 0xFFFFFFFCL;
					if (obj35 != null)
					{
						object obj36 = array + 56;
						obj36 = text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v10-20]");
						bool flag14 = (nint)0 < (nint)4;
						object obj37 = !flag14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v10-20]");
						object obj38 = -4;
						bool flag15 = obj38 == null;
						object obj39 = ~obj37;
						object obj40 = obj39 | flag15;
						if (obj40 == null)
						{
							object obj41 = array + 64;
							obj41 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int seconds = timeSpan2.Seconds;
							string text6 = num.ToString((string)obj23);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X20_v12-28]");
							bool flag16 = (nint)0 < (nint)5;
							object obj42 = !flag16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X20_v12-28]");
							object obj43 = -5;
							bool flag17 = obj43 == null;
							object obj44 = ~obj42;
							object obj45 = obj44 | flag17;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9D0]");
								object obj46 = 0;
								object obj47 = array + 72;
								obj47 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text7 = string.Concat(array);
								return (string)obj46 + text7;
							}
						}
					}
				}
			}
		}
		goto IL_0619;
	}
}
