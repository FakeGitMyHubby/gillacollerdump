using System;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public struct PhysicsSettings
{
	public bool ForecastEnabled;

	[NonSerialized]
	public bool SetForecastDisabledProxyRigidbodiesToKinematic;

	[NonSerialized]
	public bool SetPhysicsInterpolationToDisabledWhenKinematic;

	public bool DebugPhysics;

	public GravityForecast GravityForecast;

	public float MaxExtrapolationTime;

	public float MinLinearDetectedError;

	public float MinAngularDetectedError;

	public DeadzoneVelocityMode DeadzoneVelocityMode;

	public float MaxLinearError;

	public float MaxAngularError;

	public float LowCorrectionProgressThreshold;

	public float HighErrorSimilarityThreshold;

	public float MaxErrorTotalTime;

	public float MaxRemoteSleepIgnoreTime;

	public PhysicsCorrection ErrorCorrectionType = (PhysicsCorrection)0;

	public float LinearVelCorrectionMul;

	public float AngularVelCorrectionMul;

	public float PositionCorrectionLerp;

	public float RotationCorrectionLerp;

	public float Spring;

	public float Damper;

	public float MinImpactfulCollisionAlignment;

	public float ImpactStartCorrectionTime;

	public float ImpactCorrectionTimeComplete;

	public PhysicsSettings()
	{
		//IL_003a: Expected F4, but got I
		//IL_0057: Expected F4, but got I
		//IL_0069: Expected F4, but got I
		//IL_0074: Expected F4, but got I4
		//IL_0086: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BFC8]");
		ForecastEnabled = false;
		GravityForecast = (GravityForecast)2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EA90]");
		MaxLinearError = 0f;
		MinAngularDetectedError = 3f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E8D0]");
		LinearVelCorrectionMul = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B108]");
		MaxExtrapolationTime = 0f;
		MaxErrorTotalTime = 63f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E530]");
		Spring = 0f;
		ImpactCorrectionTimeComplete = 0.3f;
	}
}
