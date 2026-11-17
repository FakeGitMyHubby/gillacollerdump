using System.Diagnostics;
using Cpp2ILInjected;

namespace Photon.Client;

internal class SimulationItem
{
	internal readonly Stopwatch stopw;

	public int TimeToExecute;

	public byte[] DelayedData;

	private int Delay__BackingField;

	public int Delay
	{
		get
		{
			return Delay__BackingField;
		}
		internal set
		{
			Delay__BackingField = value;
		}
	}

	public SimulationItem()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
		object obj = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Stopwatch stopwatch = default;
		stopwatch._002Ector();
		object obj2 = this + 16;
		obj2 = stopwatch;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((Stopwatch)obj2).Start();
	}
}
