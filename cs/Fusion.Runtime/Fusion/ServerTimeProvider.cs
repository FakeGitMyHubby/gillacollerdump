using Fusion.Statistics;

namespace Fusion;

internal class ServerTimeProvider : _0021_00210
{
	private ServerTimeProviderSettings _settings;

	private double _time;

	internal ServerTimeProvider()
	{
		ServerTimeProviderSettings serverTimeProviderSettings = ServerTimeProviderSettings.Default();
		ServerTimeProviderSettings settings = default;
		_settings = settings;
	}

	internal ServerTimeProvider(ServerTimeProviderSettings settings)
	{
		//IL_001f: Expected VT, but got F8
		_ = settings.MinimumInputDelayUnit;
		_settings = (ServerTimeProviderSettings)settings.SimDeltaTime;
	}

	private void Reset(Tick snapshot)
	{
		double time = (double)_settings * (double)snapshot;
		_time = time;
	}

	private void Update(double unscaledDeltaTime)
	{
		double time = _time + unscaledDeltaTime;
		_time = time;
	}

	private bool Fusion_002EITimeProvider_002EIsRunning()
	{
		return true;
	}

	private void Fusion_002EITimeProvider_002EConfigure(SimulationRuntimeConfig src)
	{
		//IL_000e: Invalid comparison between VT and I4
		//IL_0049: Expected F8, but got I4
		//IL_0058: Expected VT, but got F8
		double num = ((src.TickRate == (TickRate.Resolved)(object)0) ? 0.0 : (1.0 / (double)src.TickRate));
		_settings = (ServerTimeProviderSettings)num;
	}

	private void Fusion_002EITimeProvider_002EConfigure(TimeSyncConfiguration tsc)
	{
		tsc.SanityCheck();
		_ = tsc.MinimumInputDelayUnit;
		_ = tsc.MinimumInputDelay;
	}

	private void Fusion_002EITimeProvider_002EReset(double roundTripTime, Tick snapshot)
	{
		double time = (double)_settings * (double)snapshot;
		_time = time;
	}

	private void Fusion_002EITimeProvider_002ESnap()
	{
	}

	private void Fusion_002EITimeProvider_002EUpdate(double unscaledDeltaTime)
	{
		double time = _time + unscaledDeltaTime;
		_time = time;
	}

	private void Fusion_002EITimeProvider_002EOnSnapshotReceived(double roundTripTime, Tick snapshot, double? snapshotDeltaTime)
	{
	}

	private void Fusion_002EITimeProvider_002EOnFeedbackReceived(Simulation.TimeFeedback feedback)
	{
	}

	private void Fusion_002EITimeProvider_002EResetFeedback()
	{
	}

	private unsafe Instant Fusion_002EITimeProvider_002ENow()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected VT, but got Unknown
		//IL_0014: Expected Ref, but got VT
		Instant instant = (Instant)(this + 16);
		double minimumInputDelay = ((ServerTimeProviderSettings*)instant)->MinimumInputDelay;
		return instant;
	}

	private unsafe DebugInstant Fusion_002EITimeProvider_002EDebugNow()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected VT, but got Unknown
		//IL_0014: Expected Ref, but got VT
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected VT, but got Unknown
		//IL_003d: Expected Ref, but got VT
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected VT, but got Unknown
		//IL_005a: Expected Ref, but got VT
		//IL_006b: Expected native int or pointer, but got VT
		//IL_007d: Expected native int or pointer, but got VT
		//IL_008a: Expected native int or pointer, but got VT
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00a4: Expected native int or pointer, but got VT
		//IL_00b3: Expected native int or pointer, but got VT
		//IL_00c2: Expected native int or pointer, but got VT
		//IL_00d4: Expected native int or pointer, but got VT
		//IL_00e6: Expected native int or pointer, but got VT
		ServerTimeProviderSettings serverTimeProviderSettings = (ServerTimeProviderSettings)(this + 16);
		double minimumInputDelay = ((ServerTimeProviderSettings*)serverTimeProviderSettings)->MinimumInputDelay;
		ServerTimeProviderSettings serverTimeProviderSettings2 = (ServerTimeProviderSettings)(this + 16);
		double input = _time + minimumInputDelay;
		double minimumInputDelay2 = ((ServerTimeProviderSettings*)serverTimeProviderSettings2)->MinimumInputDelay;
		DebugInstant debugInstant = (DebugInstant)(this + 16);
		double minimumInputDelay3 = ((ServerTimeProviderSettings*)debugInstant)->MinimumInputDelay;
		DebugInstant debugInstant2 = default;
		((DebugInstant*)(nint)debugInstant2)->InputOffset = 0.0;
		((DebugInstant*)(nint)debugInstant2)->TargetInputOffset = 0.0;
		((DebugInstant*)(nint)debugInstant2)->InputDelay = minimumInputDelay2;
		((DebugInstant*)(nint)debugInstant2)->TargetInputDelay = minimumInputDelay3;
		((DebugInstant*)(nint)debugInstant2)->Input = input;
		((DebugInstant*)(nint)debugInstant2)->Local = _time;
		((DebugInstant*)(nint)debugInstant2)->Remote = _time;
		((DebugInstant*)(nint)debugInstant2)->InterpDelay = 0.0;
		((DebugInstant*)(nint)debugInstant2)->TargetInterpDelay = 0.0;
		return debugInstant;
	}

	private void Fusion_002EITimeProvider_002ELog(FusionStatisticsManager stats)
	{
	}

	private void Fusion_002EITimeProvider_002ESetPlayerIndex(int index)
	{
	}

	private void Fusion_002EITimeProvider_002EStartTrace()
	{
	}

	private void Fusion_002EITimeProvider_002EStopTrace()
	{
	}
}
