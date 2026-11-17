using System.Runtime.InteropServices;
using UnityEngine;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 16)]
internal struct SimulationMessageInternal_SetAreaOfInterest
{
	[FieldOffset(0)]
	public Vector3 Center;

	[FieldOffset(12)]
	public float Radius;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_CENTER = default(int);

	internal const int BYTE_COUNT_OF_CENTER = default(int);

	internal const int BYTE_OF_RADIUS = default(int);

	internal const int BYTE_COUNT_OF_RADIUS = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);
}
