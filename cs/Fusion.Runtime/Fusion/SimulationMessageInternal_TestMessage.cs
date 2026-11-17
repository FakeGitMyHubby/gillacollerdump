using System.Runtime.InteropServices;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 12)]
internal struct SimulationMessageInternal_TestMessage
{
	[FieldOffset(0)]
	public int Item;

	[FieldOffset(4)]
	public NetworkId Id;

	[FieldOffset(8)]
	public int Value;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_ITEM = default(int);

	internal const int BYTE_COUNT_OF_ITEM = default(int);

	internal const int BYTE_OF_ID = default(int);

	internal const int BYTE_COUNT_OF_ID = default(int);

	internal const int BYTE_OF_VALUE = default(int);

	internal const int BYTE_COUNT_OF_VALUE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);
}
