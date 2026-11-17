using System;

namespace Fusion;

internal struct SimulationRenderSequencer
{
	private ulong _sequence;

	public bool ConsumeRenderUpdate(NetworkRunner runner)
	{
		//IL_0091: Expected I4, but got Obj
		//IL_00a5: Expected Obj, but got I8
		if ((object)runner != null)
		{
			Simulation simulation = runner._simulation;
			if ((object)runner._simulation != null)
			{
				if (simulation._interpolateSequence != _sequence)
				{
					_sequence = simulation._interpolateSequence;
				}
				object obj = simulation._interpolateSequence - _sequence;
				bool flag = obj == null;
				return !flag;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool ConsumeRenderUpdate(Simulation simulation)
	{
		//IL_0062: Expected I4, but got Obj
		//IL_0076: Expected Obj, but got I8
		if ((object)simulation != null)
		{
			if (simulation._interpolateSequence != _sequence)
			{
				_sequence = simulation._interpolateSequence;
			}
			object obj = simulation._interpolateSequence - _sequence;
			bool flag = obj == null;
			return !flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
