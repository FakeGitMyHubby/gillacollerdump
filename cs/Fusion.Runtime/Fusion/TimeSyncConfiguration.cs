using System;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public class TimeSyncConfiguration : _0021_00210
{
	public enum ReliableDataTransfers
	{
		// error: enumerator has no value
		ClientToServer,
		// error: enumerator has no value
		ClientToClientWithServerProxy
	}

	public enum Selection
	{
		// error: enumerator has no value
		Default,
		// error: enumerator has no value
		Custom
	}

	internal const float DEFAULT_MAX_LATE_SNAPSHOTS_PERCENTILE = default(float);

	internal const float DEFAULT_REDUNDANT_SNAPSHOTS = default(float);

	internal const int DEFAULT_STATE_BUFFER_DELAY_ADDED = default(int);

	internal const SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit DEFAULT_STATE_BUFFER_DELAY_ADDED_UNIT = default(SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit);

	internal const float DEFAULT_MAX_LATE_INPUTS_PERCENTILE = default(float);

	internal const float DEFAULT_REDUNDANT_INPUTS = default(float);

	internal const int DEFAULT_INPUT_BUFFER_DELAY_ADDED = default(int);

	internal const SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit DEFAULT_INPUT_BUFFER_DELAY_ADDED_UNIT = default(SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit);

	internal const int DEFAULT_MAX_RESIMS_PER_FRAME = default(int);

	internal const int DEFAULT_MINIMUM_INPUT_DELAY = default(int);

	internal const SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit DEFAULT_MINIMUM_INPUT_DELAY_UNIT = default(SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit);

	public Selection StateReceiveBufferSettings = (Selection)0;

	public float MaxLateSnapshots;

	public float RedundantSnapshots;

	public int StateReceiveBufferDelayAdded = 0;

	public SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit StateReceiveBufferDelayAddedUnit = (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)0;

	public Selection InputReceiveBufferSettings;

	public float MaxLateInputs;

	public float RedundantInputs;

	public int InputReceiveBufferDelayAdded;

	public SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit InputReceiveBufferDelayAddedUnit;

	public Selection InputDelaySettings;

	public int MinimumInputDelay;

	public SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit MinimumInputDelayUnit;

	public bool ClientsCanAddInputDelayToLimitResims;

	public int ClientMaxResimsPerFrame;

	public void SanityCheck()
	{
		//IL_03b2: Expected Obj, but got I
		//IL_0135: Expected F4, but got I
		//IL_0015: Expected F8, but got I
		//IL_0027: Invalid comparison between F4 and I
		//IL_025a: Expected F4, but got I
		//IL_0277: Expected F4, but got I
		//IL_014a: Expected F8, but got I
		//IL_015c: Invalid comparison between F4 and I
		//IL_044c: Expected Obj, but got I4
		//IL_038b: Expected I4, but got I8
		//IL_049b: Invalid comparison between F4 and I4
		//IL_04aa: Expected F8, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0108: Expected I, but got Obj
		//IL_02a6: Expected Obj, but got I4
		//IL_04ec: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_023d: Expected I, but got Obj
		//IL_039d: Expected I4, but got I8
		//IL_0329: Expected Obj, but got I4
		//IL_035f: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		if (StateReceiveBufferSettings == (Selection)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			double num = 0.0;
			float maxLateSnapshots = MaxLateSnapshots;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			if (!(maxLateSnapshots < 0f))
			{
				bool flag = !((double)MaxLateSnapshots > 20.0);
				num = MaxLateSnapshots;
				if (!flag)
				{
					num = 20.0;
				}
			}
			float redundantSnapshots = RedundantSnapshots;
			MaxLateSnapshots = (float)num;
			bool flag2 = (double)RedundantSnapshots < -1.0;
			double num2 = -1.0;
			if (!flag2)
			{
				bool flag3 = !((double)RedundantSnapshots > 10.0);
				num2 = RedundantSnapshots;
				if (!flag3)
				{
					num2 = 10.0;
				}
			}
			object obj2 = obj;
			RedundantSnapshots = (float)num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v22+E4]");
			bool flag4 = (nint)0 == 0;
			object obj3 = !flag4;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int stateReceiveBufferDelayAdded = Maths.Clamp(StateReceiveBufferDelayAdded, 0, 1000);
			StateReceiveBufferDelayAdded = stateReceiveBufferDelayAdded;
			object obj4 = 0;
			int num3 = 1000;
			nint num4 = unchecked((nint)null);
		}
		else
		{
			StateReceiveBufferDelayAdded = 0;
			StateReceiveBufferDelayAddedUnit = (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDD0]");
			MaxLateSnapshots = 0f;
		}
		if (InputReceiveBufferSettings == (Selection)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			double num = 0.0;
			float maxLateInputs = MaxLateInputs;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			if (!(maxLateInputs < 0f))
			{
				bool flag5 = !((double)MaxLateInputs > 20.0);
				num = MaxLateInputs;
				if (!flag5)
				{
					num = 20.0;
				}
			}
			float redundantSnapshots = RedundantInputs;
			MaxLateInputs = (float)num;
			bool flag6 = RedundantInputs < 0f;
			double num5 = 0.0;
			if (!flag6)
			{
				bool flag7 = !((double)RedundantInputs > 10.0);
				num5 = RedundantInputs;
				if (!flag7)
				{
					num5 = 10.0;
				}
			}
			object obj5 = obj;
			RedundantInputs = (float)num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v17+E4]");
			bool flag8 = (nint)0 == 0;
			object obj6 = !flag8;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int inputReceiveBufferDelayAdded = Maths.Clamp(InputReceiveBufferDelayAdded, 0, 1000);
			InputReceiveBufferDelayAdded = inputReceiveBufferDelayAdded;
			object obj4 = 0;
			int num3 = 1000;
			nint num4 = unchecked((nint)null);
			float num6 = (float)num5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDD0]");
			float num6 = 0f;
			InputReceiveBufferDelayAdded = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDD0]");
			MaxLateInputs = 0f;
		}
		int clientMaxResimsPerFrame;
		if (InputDelaySettings == (Selection)1)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v6+E4]");
			bool flag9 = (nint)0 == 0;
			object obj8 = !flag9;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int minimumInputDelay = Maths.Clamp(MinimumInputDelay, 0, 1000);
			MinimumInputDelay = minimumInputDelay;
			if (~(ClientsCanAddInputDelayToLimitResims ? 1u : 0u) == 0)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v11+E4]");
				bool flag10 = (nint)0 == 0;
				object obj10 = !flag10;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				clientMaxResimsPerFrame = Maths.Clamp(ClientMaxResimsPerFrame, -1, 1000);
			}
			else
			{
				clientMaxResimsPerFrame = -1;
			}
		}
		else
		{
			MinimumInputDelay = 0;
			MinimumInputDelayUnit = (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)0;
			clientMaxResimsPerFrame = -1;
		}
		ClientMaxResimsPerFrame = clientMaxResimsPerFrame;
	}

	public TimeSyncConfiguration()
	{
		//IL_0033: Expected F4, but got I
		//IL_0045: Expected F4, but got I
		//IL_006a: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDD0]");
		MaxLateSnapshots = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDD0]");
		MaxLateInputs = 0f;
		InputReceiveBufferDelayAdded = 0;
		InputDelaySettings = (Selection)0;
		ClientMaxResimsPerFrame = -1;
		_ = 0;
		base._002Ector();
	}
}
