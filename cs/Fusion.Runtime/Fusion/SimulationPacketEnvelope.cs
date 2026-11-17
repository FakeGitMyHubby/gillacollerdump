using System;
using Cpp2ILInjected;

namespace Fusion;

internal class SimulationPacketEnvelope
{
	public Tick Tick;

	public Fusion.PooledList<NetworkObjectPacketData> Objects;

	public Fusion.PooledList<SimulationMessagePacketData> Messages;

	public int RefCount;

	internal void PoolInit(Simulation simulation, Tick tick)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		Tick = tick;
		RefCount = 1;
		Fusion.PooledList<NetworkObjectPacketData> pooledList = simulation.AcquireNetworkObjectPacketDataList(64);
		object obj = this + 24;
		Fusion.PooledList<NetworkObjectPacketData> objects = default;
		Objects = objects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Fusion.PooledList<SimulationMessagePacketData> pooledList2 = simulation.AcquireSimulationMessagePacketDataList(0);
		object obj2 = this + 56;
		Fusion.PooledList<SimulationMessagePacketData> messages = default;
		Messages = messages;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal unsafe void PoolReset(Simulation simulation)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00f5: Expected VT, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Ref, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Ref, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA880]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9570]");
		object obj = 0;
		bool condition = RefCount == 0;
		Assert.Always(condition, (string)error);
		Tick = (Tick)0;
		ArgumentNullException ex = new ArgumentNullException();
		if ((nint)obj >= 1)
		{
			object obj2 = obj & 0xFFFFFFFFL;
			ArgumentNullException ex2 = ex;
			do
			{
				ex2 = (ArgumentNullException)(ex2 + 24);
				bool flag = simulation.ReleaseReference((SimulationMessage)(object)ex2);
				obj2--;
			}
			while ((nint)obj2 != 1);
		}
		simulation.Release(ref *(Fusion.PooledList<NetworkObjectPacketData>*)(this + 24));
		simulation.Release(ref *(Fusion.PooledList<SimulationMessagePacketData>*)(this + 56));
	}
}
