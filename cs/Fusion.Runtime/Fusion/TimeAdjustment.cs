using Cpp2ILInjected;

namespace Fusion;

internal struct TimeAdjustment(Tick tick, double total)
{
	public Tick Tick = tick;

	public double Total = total;

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA920]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		return string.Format((string)format, arg, arg2);
	}
}
