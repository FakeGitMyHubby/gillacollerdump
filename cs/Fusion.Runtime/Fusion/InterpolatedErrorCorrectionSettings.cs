using System;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public class InterpolatedErrorCorrectionSettings
{
	public float MinRate;

	public float MaxRate;

	public float PosBlendStart;

	public float PosBlendEnd;

	public float PosMinCorrection;

	public float PosTeleportDistance;

	public float RotBlendStart;

	public float RotBlendEnd;

	public float RotTeleportRadians = 1.5f;

	public InterpolatedErrorCorrectionSettings()
	{
		//IL_001d: Expected F4, but got I
		//IL_002f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F4D0]");
		MinRate = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C950]");
		PosMinCorrection = 0f;
		base._002Ector();
	}
}
