using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;

namespace Photon.Client.Encryption;

internal class DiffieHellmanCryptoProvider : _0021_00210, IEnumerable<KeyValue<_00210, _00211>>
{
	private static readonly BigInteger primeRoot;

	private readonly BigInteger prime;

	private readonly BigInteger secret;

	private readonly BigInteger publicKey;

	private Rijndael crypto;

	private byte[] sharedKey;

	public bool IsInitialized
	{
		get
		{
			bool flag = crypto == null;
			return !flag;
		}
	}

	public byte[] PublicKey
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0076: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CE0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			BigInteger bigInteger = default;
			byte[] array = bigInteger.ToByteArray();
			return ((DiffieHellmanCryptoProvider)(object)array).MsBigIntArrayToPhotonBigIntArray(array);
		}
	}

	public DiffieHellmanCryptoProvider()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0100: Expected VT, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517318]");
		object obj = 0;
		base._002Ector();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+8]");
		BigInteger bigInteger = new BigInteger((byte[])0);
		object obj5 = this + 24;
		prime = (BigInteger)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		BigInteger bigInteger2 = GenerateRandomSecret(160);
		secret = bigInteger2;
		object obj6 = this + 40;
		obj6 = 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		BigInteger bigInteger3 = CalculatePublicKey();
		object obj7 = this + 56;
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public DiffieHellmanCryptoProvider(byte[] cryptoKey)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6501F40]");
		object obj = 0;
		RijndaelManaged rijndaelManaged = default;
		while (true)
		{
			base._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			rijndaelManaged._002Ector();
			object obj2 = this + 64;
			obj2 = rijndaelManaged;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = obj2;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ X8_v4+208] (should have been resolved before IL gen)");
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ X8_v5+1E8] (should have been resolved before IL gen)");
			object obj8 = obj2;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+290]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+288]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v89 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public unsafe void DeriveSharedKey(byte[] otherPartyPublicKey)
	{
		//IL_0010: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_04b3: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got Ref
		//IL_04fd: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0298: Expected I, but got Obj
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_0307: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_039e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6501D80]");
		object obj2 = 0;
		byte[] value = PhotonBigIntArrayToMsBigIntArray(otherPartyPublicKey);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		BigInteger otherPartyPublicKey2 = new BigInteger(value);
		BigInteger bigInteger = CalculateSharedKey(otherPartyPublicKey2);
		BigInteger bigInteger2 = default;
		byte[] array = bigInteger2.ToByteArray();
		byte[] array2 = ((DiffieHellmanCryptoProvider)(object)array).MsBigIntArrayToPhotonBigIntArray(array);
		object obj6 = this + 72;
		obj6 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SHA256Managed sHA256Managed = default;
		sHA256Managed._002Ector();
		bool flag2 = sHA256Managed == null;
		object obj7 = 0;
		OutOfMemoryException ex = null;
		object obj8 = 0;
		RijndaelManaged rijndaelManaged = null;
		DiffieHellmanCryptoProvider diffieHellmanCryptoProvider = this;
		if (flag2)
		{
			goto IL_03b7;
		}
		byte[] array3 = (byte[])obj6;
		byte[] array4 = sHA256Managed.ComputeHash((byte[])obj6);
		obj7 = 0;
		ex = null;
		obj8 = 0;
		diffieHellmanCryptoProvider = this;
		byte[] array5 = array4;
		goto IL_0571;
		IL_052f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v31+8]");
		array3 = (byte[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v359 @ X0_v31] (should have been resolved before IL gen)");
		goto IL_04e3;
		IL_03cd:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_03db;
		IL_01d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj8 = 0;
		goto IL_052f;
		IL_0571:
		object obj10 = default;
		object obj9 = (object)(&obj10);
		object obj11 = obj9;
		if (obj9 == null)
		{
			goto IL_04e3;
		}
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15+12E]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15+98]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X10_v9-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15+12E]");
			obj4 = -1;
			obj13 = obj14 + 16;
			bool flag3 = (nint)obj4 != 1;
			obj14 = obj13;
			if (flag3)
			{
				continue;
			}
			goto IL_01d0;
		}
		obj4 = obj14;
		object obj15 = obj12 + obj14;
		object obj16 = obj15 + 312;
		obj13 = obj14;
		goto IL_052f;
		IL_04e3:
		bool flag4 = ex == null;
		object obj17 = !flag4;
		if (obj17 != null)
		{
			goto IL_03cd;
		}
		bool flag5 = obj7 == null;
		object obj18 = !flag5;
		ex2 = ex;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6501F40]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			RijndaelManaged rijndaelManaged2 = default;
			rijndaelManaged2._002Ector();
			diffieHellmanCryptoProvider = (DiffieHellmanCryptoProvider)(diffieHellmanCryptoProvider + 64);
			diffieHellmanCryptoProvider = (DiffieHellmanCryptoProvider)(object)rijndaelManaged2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			nint num = (nint)diffieHellmanCryptoProvider;
			bool flag6 = diffieHellmanCryptoProvider == null;
			rijndaelManaged = rijndaelManaged2;
			if (!flag6)
			{
				object obj20 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v12+208]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v12+210]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v382 @ X8_v12+208] (should have been resolved before IL gen)");
				nint num2 = (nint)diffieHellmanCryptoProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag7 = diffieHellmanCryptoProvider == null;
				rijndaelManaged = (RijndaelManaged)16;
				if (!flag7)
				{
					object obj22 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v13+1E8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v13+1F0]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X8_v13+1E8] (should have been resolved before IL gen)");
					nint num3 = (nint)diffieHellmanCryptoProvider;
					bool flag8 = diffieHellmanCryptoProvider == null;
					RijndaelManaged rijndaelManaged3 = default;
					rijndaelManaged = rijndaelManaged3;
					if (!flag8)
					{
						object obj23 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v428 @ X8_v14+288] (should have been resolved before IL gen)");
						return;
					}
				}
			}
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_03b7;
		}
		goto IL_03db;
		IL_03db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)array3 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj7 = 1;
		}
		else
		{
			if ((nint)array3 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj24 = default;
			ex = (OutOfMemoryException)obj24;
		}
		array5 = null;
		goto IL_0571;
		IL_03b7:
		NullReferenceException ex4 = new NullReferenceException();
		array3 = (byte[])(object)rijndaelManaged;
		goto IL_03cd;
	}

	private byte[] PhotonBigIntArrayToMsBigIntArray(byte[] array)
	{
		//IL_0034: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I8
		//IL_0090: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		Array.Reverse((Array)array);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj = array.Length - 1;
				object obj2 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v2+20]");
				object obj3 = 0 & 0x80000000L;
				bool flag = obj3 == null;
				byte[] result = array;
				if (!flag)
				{
					object obj4 = array.Length + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Array array2 = default;
					Buffer.BlockCopy(array, 0, array2, 0, array.Length);
					result = (byte[])array2;
				}
				return result;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (byte[])(object)new IndexOutOfRangeException();
	}

	private byte[] MsBigIntArrayToPhotonBigIntArray(byte[] array)
	{
		//IL_0048: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		Array.Reverse((Array)array);
		if (array != null)
		{
			if (array.Length != 0)
			{
				bool flag = array[0] == 0;
				object obj = !flag;
				byte[] result = array;
				if (obj == null)
				{
					object obj2 = array.Length - 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					int count = array.Length - 1;
					Array array2 = default;
					Buffer.BlockCopy(array, 1, array2, 0, count);
					result = (byte[])array2;
				}
				return result;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (byte[])(object)new IndexOutOfRangeException();
	}

	public byte[] Encrypt(byte[] data)
	{
		if (data != null)
		{
			return Encrypt(data, 0, data.Length);
		}
		return (byte[])(object)new NullReferenceException();
	}

	public unsafe byte[] Encrypt(byte[] data, int offset, int count)
	{
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got Ref
		//IL_007b: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got Ref
		//IL_00d6: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I4
		//IL_0430: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		Rijndael rijndael = crypto;
		byte[] array;
		object obj2 = default;
		OutOfMemoryException ex = default;
		object obj3 = default;
		DiffieHellmanCryptoProvider diffieHellmanCryptoProvider2 = default;
		byte[] array2 = default;
		if (crypto != null)
		{
			nint num = (nint)rijndael;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v17 (Il2CppClass<System.Security.Cryptography.Rijndael>)+298]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v17 (Il2CppClass<System.Security.Cryptography.Rijndael>)+2A0]");
			array = (byte[])0;
			((object)crypto).Finalize();
			DiffieHellmanCryptoProvider diffieHellmanCryptoProvider = default;
			bool flag = diffieHellmanCryptoProvider == null;
			obj2 = 0;
			ex = null;
			obj3 = (object)(&diffieHellmanCryptoProvider2);
			diffieHellmanCryptoProvider2 = diffieHellmanCryptoProvider;
			if (!flag)
			{
				nint num2 = (nint)diffieHellmanCryptoProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FF280]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0127;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+98]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X10_v19-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
					obj = -1;
					obj4 = obj5 + 16;
					bool flag2 = (nint)obj != 1;
					obj5 = obj4;
					if (flag2)
					{
						continue;
					}
					goto IL_0127;
				}
				obj = obj5 + 5;
				object obj6 = num2 + obj;
				object obj7 = obj6 + 312;
				obj4 = obj5;
				goto IL_03cf;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			diffieHellmanCryptoProvider2 = null;
			array = array2;
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_02c5;
		IL_0462:
		object obj8 = obj3;
		if (obj3 != null)
		{
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+12E]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0220;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+98]");
			object obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v9-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+12E]");
				obj = -1;
				obj4 = obj10 + 16;
				bool flag3 = (nint)obj != 1;
				obj10 = obj4;
				if (flag3)
				{
					continue;
				}
				goto IL_0220;
			}
			obj = obj10;
			object obj11 = obj9 + obj10;
			object obj12 = obj11 + 312;
			obj4 = obj10;
			goto IL_0420;
		}
		goto IL_0487;
		IL_03cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X0_v33] (should have been resolved before IL gen)");
		obj2 = 0;
		ex = null;
		obj3 = (object)(&diffieHellmanCryptoProvider2);
		byte[] array3 = default;
		byte[] result = array3;
		goto IL_0462;
		IL_0127:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_03cf;
		IL_0487:
		bool flag4 = ex == null;
		object obj13 = !flag4;
		array = array2;
		if (obj13 != null)
		{
			goto IL_02c5;
		}
		bool flag5 = obj2 == null;
		object obj14 = !flag5;
		array = array2;
		OutOfMemoryException ex4 = ex;
		if (obj14 == null)
		{
			return result;
		}
		goto IL_02d3;
		IL_02d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				byte[] result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj15 = default;
			ex = (OutOfMemoryException)obj15;
		}
		array2 = array;
		result = null;
		goto IL_0462;
		IL_0420:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v7+8]");
		array2 = (byte[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v408 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_0487;
		IL_02c5:
		ex4 = new OutOfMemoryException();
		goto IL_02d3;
		IL_0220:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0420;
	}

	public byte[] Decrypt(byte[] data)
	{
		if (data != null)
		{
			return Decrypt(data, 0, data.Length);
		}
		return (byte[])(object)new NullReferenceException();
	}

	public unsafe byte[] Decrypt(byte[] data, int offset, int count)
	{
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got Ref
		//IL_007f: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got Ref
		//IL_00da: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I4
		//IL_04a5: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_027d: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		Rijndael rijndael = crypto;
		byte[] array;
		object obj2 = default;
		OutOfMemoryException ex = default;
		object obj3 = default;
		DiffieHellmanCryptoProvider diffieHellmanCryptoProvider2 = default;
		byte[] array2 = default;
		if (crypto != null)
		{
			nint num = (nint)rijndael;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v17 (Il2CppClass<System.Security.Cryptography.Rijndael>)+2B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v17 (Il2CppClass<System.Security.Cryptography.Rijndael>)+2C0]");
			array = (byte[])0;
			DiffieHellmanCryptoProvider diffieHellmanCryptoProvider = (DiffieHellmanCryptoProvider)(object)crypto.ToString();
			bool flag = diffieHellmanCryptoProvider == null;
			obj2 = 0;
			ex = null;
			obj3 = (object)(&diffieHellmanCryptoProvider2);
			diffieHellmanCryptoProvider2 = diffieHellmanCryptoProvider;
			if (!flag)
			{
				nint num2 = (nint)diffieHellmanCryptoProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FF280]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+98]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X10_v19-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v19 (Il2CppClass<Photon.Client.Encryption.DiffieHellmanCryptoProvider>)+12E]");
					obj = -1;
					obj4 = obj5 + 16;
					bool flag2 = (nint)obj != 1;
					obj5 = obj4;
					if (flag2)
					{
						continue;
					}
					goto IL_012b;
				}
				obj = obj5 + 5;
				object obj6 = num2 + obj;
				object obj7 = obj6 + 312;
				obj4 = obj5;
				goto IL_03d3;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			diffieHellmanCryptoProvider2 = null;
			array = array2;
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_02c9;
		IL_0466:
		object obj8 = obj3;
		if (obj3 != null)
		{
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+12E]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0224;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+98]");
			object obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v9-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7+12E]");
				obj = -1;
				obj4 = obj10 + 16;
				bool flag3 = (nint)obj != 1;
				obj10 = obj4;
				if (flag3)
				{
					continue;
				}
				goto IL_0224;
			}
			obj = obj10;
			object obj11 = obj9 + obj10;
			object obj12 = obj11 + 312;
			obj4 = obj10;
			goto IL_0424;
		}
		goto IL_048b;
		IL_03d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X0_v33] (should have been resolved before IL gen)");
		obj2 = 0;
		ex = null;
		obj3 = (object)(&diffieHellmanCryptoProvider2);
		byte[] array3 = default;
		byte[] result = array3;
		goto IL_0466;
		IL_012b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_03d3;
		IL_048b:
		bool flag4 = ex == null;
		object obj13 = !flag4;
		array = array2;
		if (obj13 != null)
		{
			goto IL_02c9;
		}
		bool flag5 = obj2 == null;
		object obj14 = !flag5;
		array = array2;
		OutOfMemoryException ex4 = ex;
		if (obj14 == null)
		{
			return result;
		}
		goto IL_02d7;
		IL_02d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				byte[] result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj15 = default;
			ex = (OutOfMemoryException)obj15;
		}
		array2 = array;
		result = null;
		goto IL_0466;
		IL_0424:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v7+8]");
		array2 = (byte[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v408 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_048b;
		IL_02c9:
		ex4 = new OutOfMemoryException();
		goto IL_02d7;
		IL_0224:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0424;
	}

	public void Dispose()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8C60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GC.SuppressFinalize(this);
	}

	protected void Dispose(bool disposing)
	{
	}

	private BigInteger CalculatePublicKey()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0056: Expected VT, but got I
		//IL_0056: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516590]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CE0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj5 = 0;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+8]");
		return BigInteger.ModPow((BigInteger)obj5, (BigInteger)0, secret);
	}

	private BigInteger CalculateSharedKey(BigInteger otherPartyPublicKey)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_0037: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CE0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IntPtr intPtr = default;
		return BigInteger.ModPow(otherPartyPublicKey, (BigInteger)(nint)intPtr, secret);
	}

	private BigInteger GenerateRandomSecret(int secretLength)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I4
		//IL_0170: Expected VT, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_025e: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I4
		//IL_0092: Expected VT, but got I
		//IL_00a4: Expected VT, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_00d7: Expected VT, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_0143: Expected I8, but got I4
		//IL_0150: Expected VT, but got I4
		//IL_0158: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6501E88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RNGCryptoServiceProvider rNGCryptoServiceProvider = default;
		rNGCryptoServiceProvider._002Ector();
		int num = secretLength + 7;
		bool flag = secretLength < 0;
		int num2 = secretLength ^ secretLength;
		int num3 = secretLength & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj3 = !flag3;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			num = secretLength;
		}
		int num4 = num >> 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (rNGCryptoServiceProvider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CE0]");
			object obj5 = 0;
			BigInteger bigInteger;
			byte[] value = default;
			object obj12;
			do
			{
				nint num5 = (nint)rNGCryptoServiceProvider;
				string text = ((MethodResponse)(object)rNGCryptoServiceProvider).System_002ERuntime_002ERemoting_002EMessaging_002EIInternalMessage_002EUri;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bigInteger = new BigInteger(value);
				BigInteger bigInteger2 = 1;
				BigInteger bigInteger3 = prime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.Encryption.DiffieHellmanCryptoProvider)+18]");
				BigInteger bigInteger4 = bigInteger3 - (BigInteger)0;
				bool flag5 = bigInteger >= (BigInteger)0;
				bool flag6 = !flag5;
				object obj8 = !flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.Encryption.DiffieHellmanCryptoProvider)+18]");
				BigInteger bigInteger5 = (BigInteger)0;
				object obj9 = 1;
				if (obj8 == null)
				{
					object obj10 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v21+E4]");
					bool flag7 = (nint)0 == 0;
					object obj11 = !flag7;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = bigInteger < 0L;
					bigInteger5 = (BigInteger)0;
					obj9 = flag8;
				}
				bool flag9 = obj9 == null;
				obj12 = !flag9;
			}
			while (obj12 != null);
			return bigInteger;
		}
		NullReferenceException ex = new NullReferenceException();
		return (BigInteger)ex;
	}

	static DiffieHellmanCryptoProvider()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_0091: Expected I4, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517318]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516590]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj5 = 0;
		BigInteger bigInteger = new BigInteger((int)obj5);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+A0]");
		object obj7 = 0;
		obj7 = 0;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+A0]");
		object obj9 = (nint)0 + (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
