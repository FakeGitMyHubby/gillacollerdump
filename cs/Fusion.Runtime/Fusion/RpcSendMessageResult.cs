namespace Fusion;

public enum RpcSendMessageResult
{
	// error: enumerator has no value
	Sent,
	// error: enumerator has no value
	SentToServerForForwarding,
	// error: enumerator has no value
	SentToTargetClient,
	// error: enumerator has no value
	SentBroadcast,
	// error: enumerator has no value
	TargetObjectNotInPlayerInterest,
	// error: enumerator has no value
	TargetPlayerNotAvailable,
	// error: enumerator has no value
	NotInvokableDuringResim,
	// error: enumerator has no value
	PayloadSizeExceeded,
	// error: enumerator has no value
	InsufficientSourceAuthority,
	// error: enumerator has no value
	TargetPlayerIsLocalPlayer,
	// error: enumerator has no value
	NoActiveConnections,
	// error: enumerator has no value
	InsufficientTargetAuthority,
	// error: enumerator has no value
	NoConnectionsWithAuthorityOrInterest,
	// error: enumerator has no value
	MaskSent,
	// error: enumerator has no value
	MaskNotSent,
	// error: enumerator has no value
	MaskBroadcast,
	// error: enumerator has no value
	MaskCulled,
	// error: enumerator has no value
	NotSentTargetObjectNotConfirmed,
	// error: enumerator has no value
	NotSentTargetObjectNotInPlayerInterest,
	// error: enumerator has no value
	NotSentTargetClientNotAvailable,
	// error: enumerator has no value
	NotSentBroadcastNoActiveConnections,
	// error: enumerator has no value
	NotSentBroadcastNoConfirmedNorInterestedClients
}
