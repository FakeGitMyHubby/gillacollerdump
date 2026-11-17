using System;
using Cpp2ILInjected;

namespace Fusion;

public class SimulationBehaviourAttribute : Attribute
{
	internal const SimulationStages ALL_STAGES = default(SimulationStages);

	internal const SimulationModes ALL_MODES = default(SimulationModes);

	internal const Topologies ALL_TOPOLOGIES = default(Topologies);

	private SimulationStages Stages__BackingField;

	private SimulationModes Modes__BackingField;

	private Topologies Topologies__BackingField = (Topologies)3;

	public SimulationStages Stages
	{
		get
		{
			return Stages__BackingField;
		}
		set
		{
			Stages__BackingField = value;
		}
	}

	public SimulationModes Modes
	{
		get
		{
			return Modes__BackingField;
		}
		set
		{
			Modes__BackingField = value;
		}
	}

	public Topologies Topologies
	{
		get
		{
			return Topologies__BackingField;
		}
		set
		{
			Topologies__BackingField = value;
		}
	}

	public SimulationBehaviourAttribute()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BF18]");
		Stages__BackingField = (SimulationStages)0;
		base._002Ector();
	}
}
