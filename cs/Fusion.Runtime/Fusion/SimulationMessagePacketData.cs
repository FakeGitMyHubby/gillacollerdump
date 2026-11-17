using System;
using System.Text;
using Cpp2ILInjected;

namespace Fusion;

internal struct SimulationMessagePacketData
{
	public readonly SimulationMessage Message;

	public readonly Tick Tick;

	public readonly ulong Sequence;

	public SimulationMessagePacketData(SimulationMessage message, Tick tick, ulong sequence)
	{
		Message = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Tick = tick;
		Sequence = sequence;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c8: Expected I4, but got VT
		//IL_010f: Expected Obj, but got I
		//IL_0140: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		if (stringBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA8F8]");
			object value = 0;
			StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
			if (stringBuilder2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA8E8]");
				object value2 = 0;
				StringBuilder stringBuilder3 = stringBuilder2.Append(Message);
				StringBuilder stringBuilder4 = stringBuilder.Append((string)value2);
				if (stringBuilder4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA8F0]");
					object value3 = 0;
					StringBuilder stringBuilder5 = stringBuilder4.Append((int)Tick);
					StringBuilder stringBuilder6 = stringBuilder.Append((string)value3);
					if (stringBuilder6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
						object value4 = 0;
						StringBuilder stringBuilder7 = stringBuilder6.Append(Sequence);
						StringBuilder stringBuilder8 = stringBuilder.Append((string)value4);
						nint num = (nint)stringBuilder;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+168]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+170]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X2_v9 (should have been resolved before IL gen)");
					}
				}
			}
		}
		return (string)(object)new NullReferenceException();
	}
}
