using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct SimulationBehaviourMeta
{
	public readonly SimulationStages Stages;

	public readonly SimulationModes Modes;

	public readonly Topologies Topologies;

	public readonly int? StaticWordCount;

	public readonly Dictionary<string, NetworkPropertyMeta> Properties;

	public unsafe SimulationBehaviourMeta(SimulationStages stages, SimulationModes modes, Topologies topologies, int? staticWordCount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005d: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6030]");
		object obj = 0;
		Stages = stages;
		Modes = modes;
		Topologies = topologies;
		StaticWordCount = staticWordCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, NetworkPropertyMeta> dictionary = default;
		dictionary._002Ector();
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
