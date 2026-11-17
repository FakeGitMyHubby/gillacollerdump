namespace Photon.Client;

public enum StatusCode
{
	// error: enumerator has no value
	Connect,
	// error: enumerator has no value
	Disconnect,
	// error: enumerator has no value
	Exception,
	// error: enumerator has no value
	ExceptionOnConnect,
	// error: enumerator has no value
	ServerAddressInvalid,
	// error: enumerator has no value
	DnsExceptionOnConnect,
	// error: enumerator has no value
	SecurityExceptionOnConnect,
	// error: enumerator has no value
	SendError,
	// error: enumerator has no value
	ExceptionOnReceive,
	// error: enumerator has no value
	TimeoutDisconnect,
	// error: enumerator has no value
	DisconnectByServerTimeout,
	// error: enumerator has no value
	DisconnectByServerUserLimit,
	// error: enumerator has no value
	DisconnectByServerLogic,
	// error: enumerator has no value
	DisconnectByServerReasonUnknown,
	// error: enumerator has no value
	EncryptionEstablished,
	// error: enumerator has no value
	EncryptionFailedToEstablish
}
