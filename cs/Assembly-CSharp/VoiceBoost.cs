using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class VoiceBoost : MonoBehaviour
{
	public float gain = 4f;

	private const float Knee = default(float);

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaVoiceVolume.Ready();
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I8
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0258: Invalid comparison between F4 and I4
		//IL_026b: Expected Obj, but got F4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02d5: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float factor = GillaVoiceVolume.Factor;
		bool flag2 = data == null;
		if (data.Length < 1)
		{
			return;
		}
		float num = gain * factor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		object obj5 = data.Length & 0xFFFFFFFFL;
		object obj6 = data + 32;
		object obj7 = 0;
		object obj9 = default;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			object obj8 = !flag3;
			if (obj8 != null)
			{
				break;
			}
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X22_v5+v140 @ X20_v6*4]");
			float num3 = num2 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			if ((nint)obj9 > 0)
			{
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v13+E4]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = data.Length;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA8C]");
				object obj11 = obj9 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC8]");
				object obj12 = obj11 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D150");
				bool flag4 = num3 < 0f;
				object obj13 = num3 ^ num3;
				object obj14 = num3 & obj13;
				bool flag5 = (nint)obj14 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC8]");
				object obj15 = obj12 * 0;
				float num4 = (float)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num5 = num4 + 0f;
				float num6 = 0f - num5;
				bool flag6 = flag4 == flag5;
				object obj16 = !flag6;
				object obj17 = ~obj16;
				if (obj17 == null)
				{
					num3 = num6;
				}
				else
				{
					num3 = num5;
				}
			}
			object obj18 = obj5 & 0xFFFFFFFFL;
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
			object obj19 = !flag7;
			if (obj19 != null)
			{
				break;
			}
			obj7++;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
