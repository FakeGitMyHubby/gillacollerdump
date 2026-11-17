using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 56)]
public struct NetworkTRSPData : Action<int>
{
	public const int WORDS = default(int);

	public const int POSITION_OFFSET = default(int);

	[FieldOffset(0)]
	public NetworkBehaviourId Parent;

	internal const int POSITION_X = default(int);

	internal const int POSITION_Y = default(int);

	internal const int POSITION_Z = default(int);

	internal const int ROTATION_X = default(int);

	internal const int ROTATION_Y = default(int);

	internal const int ROTATION_Z = default(int);

	internal const int ROTATION_W = default(int);

	[FieldOffset(8)]
	public Vector3 Position;

	[FieldOffset(20)]
	public Quaternion Rotation;

	[FieldOffset(36)]
	public Vector3Compressed Scale;

	[FieldOffset(48)]
	public int TeleportKey;

	[FieldOffset(52)]
	public NetworkId AreaOfInterestOverride;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_PARENT = default(int);

	internal const int BYTE_COUNT_OF_PARENT = default(int);

	internal const int BYTE_OF_POSITION = default(int);

	internal const int BYTE_COUNT_OF_POSITION = default(int);

	internal const int BYTE_OF_ROTATION = default(int);

	internal const int BYTE_COUNT_OF_ROTATION = default(int);

	internal const int BYTE_OF_SCALE = default(int);

	internal const int BYTE_COUNT_OF_SCALE = default(int);

	internal const int BYTE_OF_TELEPORT_KEY = default(int);

	internal const int BYTE_COUNT_OF_TELEPORT_KEY = default(int);

	internal const int BYTE_OF_AREA_OF_INTEREST_OVERRIDE = default(int);

	internal const int BYTE_COUNT_OF_AREA_OF_INTEREST_OVERRIDE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static NetworkBehaviourId NonNetworkedParent
	{
		get
		{
			//IL_000a: Expected VT, but got I8
			return (NetworkBehaviourId)4294967296L;
		}
	}
}
