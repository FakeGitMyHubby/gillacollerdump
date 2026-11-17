using System.Runtime.InteropServices;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 12)]
internal struct SimulationMessageInternal_SharedModeSetAlwaysInterested
{
	[FieldOffset(0)]
	public NetworkId Object;

	[FieldOffset(4)]
	public int Interested;

	[FieldOffset(8)]
	public int Player;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_OBJECT = default(int);

	internal const int BYTE_COUNT_OF_OBJECT = default(int);

	internal const int BYTE_OF_INTERESTED = default(int);

	internal const int BYTE_COUNT_OF_INTERESTED = default(int);

	internal const int BYTE_OF_PLAYER = default(int);

	internal const int BYTE_COUNT_OF_PLAYER = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);
}
