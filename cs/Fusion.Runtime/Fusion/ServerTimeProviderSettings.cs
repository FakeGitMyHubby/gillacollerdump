using System;
using Cpp2ILInjected;

namespace Fusion;

internal struct ServerTimeProviderSettings
{
	public double SimDeltaTime;

	public double MinimumInputDelayRaw;

	public SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit MinimumInputDelayUnit;

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
			return MinimumInputDelayRaw * SimDeltaTime;
		}
	}

	public unsafe static ServerTimeProviderSettings Default()
	{
		//IL_0024: Invalid comparison between VT and I4
		//IL_005a: Expected F8, but got I4
		//IL_0067: Expected native int or pointer, but got VT
		//IL_0079: Expected native int or pointer, but got VT
		//IL_0087: Expected native int or pointer, but got VT
		TickRate.Selection selection = TickRate.Default;
		ServerTimeProviderSettings serverTimeProviderSettings = (ServerTimeProviderSettings)TickRate.Resolve(selection);
		double simDeltaTime = ((serverTimeProviderSettings == (ServerTimeProviderSettings)(object)0) ? 0.0 : (1.0 / (double)serverTimeProviderSettings));
		ServerTimeProviderSettings serverTimeProviderSettings2 = default;
		((ServerTimeProviderSettings*)(nint)serverTimeProviderSettings2)->SimDeltaTime = simDeltaTime;
		((ServerTimeProviderSettings*)(nint)serverTimeProviderSettings2)->MinimumInputDelayRaw = 0.0;
		((ServerTimeProviderSettings*)(nint)serverTimeProviderSettings2)->MinimumInputDelayUnit = (SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List.Unit)0;
		return serverTimeProviderSettings;
	}
}
