namespace Fusion;

internal enum SimulationMessageHeaderFlags : byte
{
	// error: enumerator has no value
	None,
	// error: enumerator has no value
	Internal,
	// error: enumerator has no value
	Rpc,
	// error: enumerator has no value
	ReliableData,
	// error: enumerator has no value
	AllowRoundtrip,
	// error: enumerator has no value
	Reliable,
	// error: enumerator has no value
	TickAligned,
	// error: enumerator has no value
	HasTargetObject,
	// error: enumerator has no value
	HasTargetPlayer
}
