namespace Fusion;

public enum RpcLocalInvokeResult
{
	// error: enumerator has no value
	Invoked,
	// error: enumerator has no value
	NotInvokableLocally,
	// error: enumerator has no value
	NotInvokableDuringResim,
	// error: enumerator has no value
	InsufficientSourceAuthority,
	// error: enumerator has no value
	InsufficientTargetAuthority,
	// error: enumerator has no value
	TargetPlayerIsNotLocal,
	// error: enumerator has no value
	PayloadSizeExceeded,
	// error: enumerator has no value
	Forwarded,
	// error: enumerator has no value
	TagetPlayerIsNotLocal
}
