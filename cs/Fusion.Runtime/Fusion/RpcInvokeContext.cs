using System;
using System.Runtime.CompilerServices;

namespace Fusion;

public struct RpcInvokeContext
{
	public readonly NetworkRunner Runner;

	public readonly NetworkBehaviour TargetBehaviour;

	public readonly int Tick;

	public readonly PlayerRef Source;

	public readonly PlayerRef TargetPlayer;

	public readonly ReadOnlySpan<byte> Payload;

	public readonly Type TargetType;

	internal unsafe readonly bool* ValidationResult;

	public unsafe bool IsValidating
	{
		get
		{
			bool flag = ValidationResult == null;
			return !flag;
		}
	}

	public unsafe RpcDataReader PayloadReader
	{
		get
		{
			//IL_000e: Expected VT, but got I4
			//IL_0009: Expected native int or pointer, but got VT
			//IL_001d: Expected native int or pointer, but got VT
			//IL_002c: Expected native int or pointer, but got VT
			//IL_003a: Expected native int or pointer, but got VT
			//IL_0041: Expected VT, but got Ref
			RpcDataReader rpcDataReader = default;
			((RpcDataReader*)(nint)rpcDataReader)->_data = (ReadOnlySpan<byte>)0;
			_ = 0;
			((RpcDataReader*)(nint)rpcDataReader)->_offset = 0;
			((RpcDataReader*)(nint)rpcDataReader)->_data = Payload;
			((RpcDataReader*)(nint)rpcDataReader)->_offset = 0;
			return (RpcDataReader)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	public unsafe RpcInvokeContext(NetworkRunner runner, NetworkBehaviour target, int tick, PlayerRef source, PlayerRef targetPlayer, ReadOnlySpan<byte> payload, bool* validationResult, Type targetType = null)
	{
		//IL_004b: Expected Obj, but got I
		//IL_0055: Expected I, but got Obj
		Runner = runner;
		TargetBehaviour = target;
		Tick = tick;
		Source = source;
		TargetPlayer = targetPlayer;
		Payload = payload;
		IntPtr intPtr = default;
		TargetType = (Type)(nint)intPtr;
		ValidationResult = (bool*)(nint)targetType;
	}
}
