namespace Photon.Client.Encryption;

public interface IPhotonEncryptor
{
	int LogLevel { get; set; }

	void Init(byte[] encryptionSecret, byte[] hmacSecret, byte[] ivBytes = null, bool chainingModeGCM = default(bool), int mtu = default(int));

	void Encrypt2(byte[] data, int len, byte[] header, byte[] output, int outOffset, ref int outSize);

	byte[] Decrypt2(byte[] data, int offset, int len, byte[] header, out int outLen);

	int CalculateEncryptedSize(int unencryptedSize);

	int CalculateFragmentLength();
}
