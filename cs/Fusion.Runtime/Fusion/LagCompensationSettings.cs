using System;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public class LagCompensationSettings
{
	public bool Enabled = false;

	public int HitboxBufferLengthInMs;

	public int HitboxDefaultCapacity;

	public int CachedStaticCollidersSize = 64;

	public float ExpansionFactor
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			return 0f;
		}
	}

	public bool Optimize => false;

	public LagCompensationSettings()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B110]");
		HitboxBufferLengthInMs = 0;
		base._002Ector();
	}
}
