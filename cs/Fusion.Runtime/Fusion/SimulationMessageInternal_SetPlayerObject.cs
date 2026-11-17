using System.Runtime.InteropServices;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 4)]
internal struct SimulationMessageInternal_SetPlayerObject
{
	[FieldOffset(0)]
	public NetworkId Object;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_OBJECT = default(int);

	internal const int BYTE_COUNT_OF_OBJECT = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);
}
