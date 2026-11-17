using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;

namespace Fusion;

[StructLayout((LayoutKind)2)]
public struct NetworkPhysicsData : _0021_00210
{
	public const int WORDS = default(int);

	[FieldOffset(0)]
	public Vector3Compressed LinearVelocity;

	[FieldOffset(12)]
	public Vector3Compressed AngularVelocity;

	[FieldOffset(24)]
	public int _flagsEncoded;

	public NetworkRigidbodyFlags Flags
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return (NetworkRigidbodyFlags)_flagsEncoded;
		}
	}

	public int Constraints
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkPhysicsData)+19]");
			return 0;
		}
	}

	public (NetworkRigidbodyFlags, int) FlagsAndConstraints
	{
		get
		{
			//IL_0016: Expected Obj, but got I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected I4, but got Unknown
			//IL_003d: Expected VT, but got I4
			object obj = _flagsEncoded >> 8;
			int item = obj & 0xFF;
			(Unity.IL2CPP.Metadata.__Il2CppByteEnum, int) tuple = ((Unity.IL2CPP.Metadata.__Il2CppByteEnum)_flagsEncoded, item);
			return ((NetworkRigidbodyFlags, int))0;
		}
		set
		{
			//IL_000e: Expected I4, but got VT
			int flagsEncoded = value >> 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
			_flagsEncoded = flagsEncoded;
		}
	}
}
