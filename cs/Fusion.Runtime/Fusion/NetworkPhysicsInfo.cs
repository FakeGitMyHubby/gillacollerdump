using System.Runtime.InteropServices;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 40)]
public struct NetworkPhysicsInfo : _0021_00210
{
	[FieldOffset(0)]
	public float TimeScale;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_TIME_SCALE = default(int);

	internal const int BYTE_COUNT_OF_TIME_SCALE = default(int);
}
