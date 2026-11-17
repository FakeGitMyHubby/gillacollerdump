using Cpp2ILInjected;

namespace Fusion;

internal class SimulationHistoryEntry
{
	private class DebuggerProxy
	{
		public readonly SimulationHistoryEntry[] Items;

		public DebuggerProxy(SimulationConfig.List list)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected Obj, but got Unknown
			SimulationHistoryEntry[] array = list.ToArray();
			object obj = this + 16;
			obj = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	private Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry> _node;

	public Tick Tick;

	public double Time;
}
