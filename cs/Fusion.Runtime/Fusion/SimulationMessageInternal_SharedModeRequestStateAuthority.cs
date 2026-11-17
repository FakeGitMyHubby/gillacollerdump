using System.Runtime.InteropServices;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 8)]
internal struct SimulationMessageInternal_SharedModeRequestStateAuthority
{
	[FieldOffset(0)]
	public NetworkId Object;

	[FieldOffset(4)]
	public int Acquire;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_OBJECT = default(int);

	internal const int BYTE_COUNT_OF_OBJECT = default(int);

	internal const int BYTE_OF_ACQUIRE = default(int);

	internal const int BYTE_COUNT_OF_ACQUIRE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);
}
