using System.Runtime.InteropServices;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 16)]
public struct SimulationInputHeader
{
	[FieldOffset(0)]
	public Tick Tick;

	[FieldOffset(4)]
	public float InterpAlpha;

	[FieldOffset(8)]
	public Tick InterpFrom;

	[FieldOffset(12)]
	public Tick InterpTo;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_TICK = default(int);

	internal const int BYTE_COUNT_OF_TICK = default(int);

	internal const int BYTE_OF_INTERP_ALPHA = default(int);

	internal const int BYTE_COUNT_OF_INTERP_ALPHA = default(int);

	internal const int BYTE_OF_INTERP_FROM = default(int);

	internal const int BYTE_COUNT_OF_INTERP_FROM = default(int);

	internal const int BYTE_OF_INTERP_TO = default(int);

	internal const int BYTE_COUNT_OF_INTERP_TO = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);
}
