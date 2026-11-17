using System;
using Cpp2ILInjected;

namespace Fusion;

internal struct ClientTimeProviderSettings
{
	public Topologies Topology;

	public double TimeScaleOffsetMax;

	public double SampleWindowSeconds;

	public double OutgoingQuantile;

	public double IncomingQuantile;

	public double OutgoingRedundancy;

	public double IncomingRedundancy;

	public double OutgoingAddedRaw;

	public SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit OutgoingAddedUnit;

	public double IncomingAddedRaw;

	public SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit IncomingAddedUnit;

	public int OutgoingSendRate;

	public int IncomingSendRate;

	public double OutgoingSendDelta;

	public double IncomingSendDelta;

	public int MaxResimulations;

	public double MinimumInputDelayRaw;

	public SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit MinimumInputDelayUnit;

	public int ClientTickRate;

	public double ClientSimDeltaTime;

	public int ServerTickRate;

	public double ServerSimDeltaTime;

	public double OutgoingAdded
	{
		get
		{
			//IL_003b: Expected Obj, but got I4
			if (OutgoingAddedUnit != (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)1)
			{
				bool flag = OutgoingAddedUnit == 0;
				object obj = !flag;
				if (obj == null)
				{
					double num = OutgoingAddedRaw;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C438]");
					return num / 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentOutOfRangeException ex = default;
				string paramName = default;
				ex._002Ector(paramName);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			return OutgoingAddedRaw * ClientSimDeltaTime;
		}
	}

	public double IncomingAdded
	{
		get
		{
			//IL_003b: Expected Obj, but got I4
			if (IncomingAddedUnit != (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)1)
			{
				bool flag = IncomingAddedUnit == 0;
				object obj = !flag;
				if (obj == null)
				{
					double num = IncomingAddedRaw;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C438]");
					return num / 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentOutOfRangeException ex = default;
				string paramName = default;
				ex._002Ector(paramName);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			return IncomingAddedRaw * ClientSimDeltaTime;
		}
	}

	public double MinimumInputDelay
	{
		get
		{
			//IL_003b: Expected Obj, but got I4
			if (MinimumInputDelayUnit != (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)1)
			{
				bool flag = MinimumInputDelayUnit == 0;
				object obj = !flag;
				if (obj == null)
				{
					double num = MinimumInputDelayRaw;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C438]");
					return num / 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentOutOfRangeException ex = default;
				string paramName = default;
				ex._002Ector(paramName);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			return MinimumInputDelayRaw * ClientSimDeltaTime;
		}
	}

	public unsafe static ClientTimeProviderSettings Default()
	{
		//IL_0029: Expected I4, but got VT
		//IL_004f: Expected F8, but got I4
		//IL_00d9: Expected F8, but got I4
		//IL_0116: Invalid comparison between VT and I4
		//IL_0125: Expected F8, but got I4
		//IL_00ff: Expected F8, but got I4
		//IL_013c: Expected native int or pointer, but got VT
		//IL_0149: Expected native int or pointer, but got VT
		//IL_0157: Expected native int or pointer, but got VT
		//IL_0169: Expected native int or pointer, but got VT
		//IL_017e: Expected native int or pointer, but got VT
		//IL_01a2: Expected F8, but got I
		//IL_019d: Expected native int or pointer, but got VT
		//IL_01af: Expected native int or pointer, but got VT
		//IL_01bc: Expected native int or pointer, but got VT
		//IL_01cf: Expected native int or pointer, but got VT
		//IL_01e1: Expected native int or pointer, but got VT
		//IL_01ee: Expected native int or pointer, but got VT
		//IL_01fb: Expected native int or pointer, but got VT
		//IL_0212: Expected I4, but got I8
		//IL_020d: Expected native int or pointer, but got VT
		//IL_022b: Expected I4, but got VT
		//IL_0226: Expected native int or pointer, but got VT
		//IL_0233: Expected native int or pointer, but got VT
		//IL_0240: Expected native int or pointer, but got VT
		//IL_0253: Expected native int or pointer, but got VT
		TickRate.Selection selection = TickRate.Default;
		ClientTimeProviderSettings clientTimeProviderSettings = (ClientTimeProviderSettings)TickRate.Resolve(selection);
		int num = clientTimeProviderSettings >> 32;
		int num3 = default;
		int num2 = num3 >> 32;
		bool flag = num == 0;
		double outgoingSendDelta = 0.0;
		if (!flag)
		{
			outgoingSendDelta = 1.0 / (double)num;
		}
		bool flag2 = num2 == 0;
		double incomingSendDelta = 0.0;
		if (!flag2)
		{
			incomingSendDelta = 1.0 / (double)num2;
		}
		bool flag3 = clientTimeProviderSettings == (ClientTimeProviderSettings)(object)0;
		double clientSimDeltaTime = 0.0;
		if (!flag3)
		{
			clientSimDeltaTime = 1.0 / (double)clientTimeProviderSettings;
		}
		bool flag4 = num3 == 0;
		double serverSimDeltaTime = 0.0;
		if (!flag4)
		{
			serverSimDeltaTime = 1.0 / (double)num3;
		}
		ClientTimeProviderSettings clientTimeProviderSettings2 = default;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->IncomingAddedUnit = (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)0;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->OutgoingSendRate = num;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->OutgoingAddedUnit = (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)0;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->IncomingAddedRaw = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B968]");
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->Topology = (Topologies)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F980]");
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->TimeScaleOffsetMax = 0.0;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->OutgoingAddedRaw = 0.0;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->IncomingSendRate = num2;
		_ = 0;
		double outgoingQuantile = default;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->OutgoingQuantile = outgoingQuantile;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->OutgoingRedundancy = 6.835426893334123E-304;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->OutgoingSendDelta = outgoingSendDelta;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->IncomingSendDelta = incomingSendDelta;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->MaxResimulations = -1;
		_ = 0;
		_ = 0;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->ClientTickRate = (int)clientTimeProviderSettings;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->ClientSimDeltaTime = clientSimDeltaTime;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->ServerTickRate = num3;
		_ = 0;
		((ClientTimeProviderSettings*)(nint)clientTimeProviderSettings2)->ServerSimDeltaTime = serverSimDeltaTime;
		return clientTimeProviderSettings;
	}
}
