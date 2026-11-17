namespace Photon.Client.Encryption;

internal interface ICryptoProvider : _0021_00210
{
	bool IsInitialized { get; }

	byte[] PublicKey { get; }

	void DeriveSharedKey(byte[] otherPartyPublicKey);

	byte[] Encrypt(byte[] data);

	byte[] Encrypt(byte[] data, int offset, int count);

	byte[] Decrypt(byte[] data);

	byte[] Decrypt(byte[] data, int offset, int count);
}
