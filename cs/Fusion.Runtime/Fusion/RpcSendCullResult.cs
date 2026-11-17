namespace Fusion;

public enum RpcSendCullResult
{
	// error: enumerator has no value
	NotCulled,
	// error: enumerator has no value
	NotInvokableDuringResim,
	// error: enumerator has no value
	InsufficientSourceAuthority,
	// error: enumerator has no value
	NoActiveConnections,
	// error: enumerator has no value
	TargetPlayerUnreachable,
	// error: enumerator has no value
	TargetPlayerIsLocalButRpcIsNotInvokableLocally,
	// error: enumerator has no value
	PayloadSizeExceeded
}
