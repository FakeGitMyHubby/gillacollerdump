namespace Photon.Client;

public enum ConnectionStateValue : byte
{
	// error: enumerator has no value
	Disconnected,
	// error: enumerator has no value
	Connecting,
	// error: enumerator has no value
	ConnectingHandleVerifyConnect,
	// error: enumerator has no value
	Connected,
	// error: enumerator has no value
	Disconnecting,
	// error: enumerator has no value
	AcknowledgingDisconnect,
	// error: enumerator has no value
	Zombie
}
