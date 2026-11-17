using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Fusion.Photon.Realtime;
using Fusion.Sockets;
using Photon.Realtime;

namespace Fusion;

public struct StartGameArgs
{
	public GameMode GameMode;

	public string SessionName;

	public Func<string> SessionNameGenerator;

	public NetAddress? Address;

	public NetAddress? CustomPublicAddress;

	public INetworkObjectProvider ObjectProvider;

	public INetworkSceneManager SceneManager;

	public INetworkRunnerUpdater Updater;

	public INetworkObjectInitializer ObjectInitializer;

	public NetworkProjectConfig Config;

	public int? PlayerCount;

	public NetworkSceneInfo? Scene;

	public Action<NetworkRunner> OnGameStarted;

	public bool DisableNATPunchthrough;

	public Type[] CustomCallbackInterfaces;

	public byte[] ConnectionToken;

	public long PlayerUniqueId;

	public Dictionary<string, SessionProperty> SessionProperties;

	public bool? IsOpen;

	public bool? IsVisible;

	public MatchmakingMode? MatchmakingMode;

	public string CustomLobbyName;

	public string CustomSTUNServer;

	public AuthenticationValues AuthValues;

	public FusionAppSettings CustomPhotonAppSettings;

	public RealtimeClient RealtimeClient;

	public bool? EnableClientSessionCreation;

	public HostMigrationToken HostMigrationToken;

	public Action<NetworkRunner> HostMigrationResume;

	public CancellationToken StartGameCancellationToken;

	public bool? UseCachedRegions;

	public unsafe override string ToString()
	{
		//IL_2363: Expected Obj, but got I
		//IL_239c: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_23cb: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_021f: Expected VT, but got I4
		//IL_0228: Expected VT, but got I4
		//IL_00a6: Expected VT, but got I4
		//IL_2424: Expected Obj, but got I
		//IL_244e: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0162: Expected VT, but got Ref
		//IL_016b: Expected Obj, but got I4
		//IL_217d: Expected Obj, but got I
		//IL_24cd: Expected Ref, but got VT
		//IL_24e7: Expected Obj, but got I4
		//IL_24ef: Expected Obj, but got VT
		//IL_0280: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I8
		//IL_0328: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got VT
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0388: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0446: Expected Obj, but got I8
		//IL_0468: Expected Obj, but got I4
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_051a: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got VT
		//IL_22c2: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I
		//IL_0550: Expected Obj, but got I
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_2321: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_05d4: Expected Obj, but got I
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got I4
		//IL_213c: Expected Obj, but got I
		//IL_0638: Expected Obj, but got I
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_06a6: Expected Obj, but got I4
		//IL_06bc: Expected Obj, but got I
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected Obj, but got Unknown
		//IL_06fc: Expected Obj, but got I4
		//IL_072a: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_07a0: Expected Obj, but got I8
		//IL_07cc: Expected Obj, but got I4
		//IL_07dc: Expected Obj, but got I
		//IL_0814: Expected Obj, but got I
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_084e: Expected Obj, but got I
		//IL_089c: Expected Obj, but got I4
		//IL_08b2: Expected Obj, but got I
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected Obj, but got Unknown
		//IL_08fe: Expected Obj, but got I4
		//IL_092c: Expected Obj, but got I
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_099c: Expected Obj, but got I4
		//IL_09b2: Expected Obj, but got I
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected Obj, but got Unknown
		//IL_09fe: Expected Obj, but got I4
		//IL_0a24: Expected Obj, but got I
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected Obj, but got Unknown
		//IL_0a94: Expected Obj, but got I4
		//IL_0aaa: Expected Obj, but got I
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Expected Obj, but got Unknown
		//IL_0af6: Expected Obj, but got I4
		//IL_0b1c: Expected Obj, but got I
		//IL_0b2c: Expected Obj, but got I
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected Obj, but got Unknown
		//IL_0b9a: Expected Obj, but got I4
		//IL_0bb0: Expected Obj, but got I
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Expected Obj, but got Unknown
		//IL_0c06: Expected Obj, but got I4
		//IL_0c34: Expected Obj, but got I
		//IL_0c44: Expected Obj, but got I
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected Obj, but got Unknown
		//IL_0c6f: Expected Obj, but got Ref
		//IL_0ccc: Expected Obj, but got I4
		//IL_0ce2: Expected Obj, but got I
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected Obj, but got Unknown
		//IL_0d38: Expected Obj, but got I4
		//IL_0d66: Expected Obj, but got I
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected Obj, but got Unknown
		//IL_0dd4: Expected Obj, but got I4
		//IL_0dea: Expected Obj, but got I
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Expected Obj, but got Unknown
		//IL_0e52: Expected Obj, but got I4
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected Obj, but got Unknown
		//IL_0eb2: Expected Obj, but got I4
		//IL_0ec8: Expected Obj, but got I
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eed: Expected Obj, but got Unknown
		//IL_0f30: Expected Obj, but got I4
		//IL_0f6e: Expected Obj, but got I
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected Obj, but got Unknown
		//IL_0fb0: Expected Obj, but got I8
		//IL_1002: Expected Obj, but got I4
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Expected Obj, but got Unknown
		//IL_1062: Expected Obj, but got I4
		//IL_1078: Expected Obj, but got I
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Expected Obj, but got Unknown
		//IL_10e0: Expected Obj, but got I4
		//IL_1116: Expected Obj, but got I
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected Obj, but got Unknown
		//IL_1160: Expected Obj, but got I4
		//IL_1176: Expected Obj, but got I
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected Obj, but got Unknown
		//IL_11d6: Expected Obj, but got I4
		//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Expected Obj, but got Unknown
		//IL_1236: Expected Obj, but got I4
		//IL_124c: Expected Obj, but got I
		//IL_126c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1271: Expected Obj, but got Unknown
		//IL_12ac: Expected Obj, but got I4
		//IL_12e2: Expected Obj, but got I
		//IL_12f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f8: Expected Obj, but got Unknown
		//IL_132c: Expected Obj, but got I4
		//IL_1342: Expected Obj, but got I
		//IL_1362: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected Obj, but got Unknown
		//IL_13a2: Expected Obj, but got I4
		//IL_13c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ce: Expected Obj, but got Unknown
		//IL_1402: Expected Obj, but got I4
		//IL_1418: Expected Obj, but got I
		//IL_1438: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Expected Obj, but got Unknown
		//IL_1478: Expected Obj, but got I4
		//IL_14ae: Expected Obj, but got I
		//IL_14bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c4: Expected Obj, but got Unknown
		//IL_14f8: Expected Obj, but got I4
		//IL_150e: Expected Obj, but got I
		//IL_152e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1533: Expected Obj, but got Unknown
		//IL_156e: Expected Obj, but got I4
		//IL_159f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Expected Obj, but got Unknown
		//IL_15da: Expected Obj, but got I4
		//IL_15f0: Expected Obj, but got I
		//IL_1610: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Expected Obj, but got Unknown
		//IL_1650: Expected Obj, but got I4
		//IL_167e: Expected Obj, but got I
		//IL_168f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1694: Expected Obj, but got Unknown
		//IL_16c8: Expected Obj, but got I4
		//IL_16de: Expected Obj, but got I
		//IL_16fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1703: Expected Obj, but got Unknown
		//IL_173e: Expected Obj, but got I4
		//IL_176f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1774: Expected Obj, but got Unknown
		//IL_17aa: Expected Obj, but got I4
		//IL_17c0: Expected Obj, but got I
		//IL_17e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e5: Expected Obj, but got Unknown
		//IL_1820: Expected Obj, but got I4
		//IL_184e: Expected Obj, but got I
		//IL_1857: Unknown result type (might be due to invalid IL or missing references)
		//IL_185c: Expected Obj, but got Unknown
		//IL_18be: Expected Obj, but got I4
		//IL_18d4: Expected Obj, but got I
		//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f9: Expected Obj, but got Unknown
		//IL_1934: Expected Obj, but got I4
		//IL_195a: Expected Obj, but got I
		//IL_1963: Unknown result type (might be due to invalid IL or missing references)
		//IL_1968: Expected Obj, but got Unknown
		//IL_19ca: Expected Obj, but got I4
		//IL_19e0: Expected Obj, but got I
		//IL_1a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a05: Expected Obj, but got Unknown
		//IL_1a5c: Expected Obj, but got I4
		//IL_1a82: Expected Obj, but got I
		//IL_1a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a90: Expected Obj, but got Unknown
		//IL_1af0: Expected Obj, but got I4
		//IL_1b06: Expected Obj, but got I
		//IL_1b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2b: Expected Obj, but got Unknown
		//IL_1b8c: Expected Obj, but got I4
		//IL_1bba: Expected Obj, but got I
		//IL_1bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc8: Expected Obj, but got Unknown
		//IL_1c2a: Expected Obj, but got I4
		//IL_1c40: Expected Obj, but got I
		//IL_1c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c65: Expected Obj, but got Unknown
		//IL_1cc6: Expected Obj, but got I4
		//IL_1cec: Expected Obj, but got I
		//IL_1cfc: Expected Obj, but got I
		//IL_1d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0f: Expected Obj, but got Unknown
		//IL_1d67: Expected Obj, but got I4
		//IL_1d7d: Expected Obj, but got I
		//IL_1d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da2: Expected Obj, but got Unknown
		//IL_1e0d: Expected Obj, but got I4
		//IL_1e3b: Expected Obj, but got I
		//IL_1e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4e: Expected Obj, but got Unknown
		//IL_1ea6: Expected Obj, but got I4
		//IL_1ebc: Expected Obj, but got I
		//IL_1edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee1: Expected Obj, but got Unknown
		//IL_1f56: Expected Obj, but got I4
		//IL_1f84: Expected Obj, but got I
		//IL_1f94: Expected Obj, but got I
		//IL_1fa4: Expected Obj, but got I
		//IL_1fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb7: Expected Obj, but got Unknown
		//IL_2007: Expected Obj, but got I8
		//IL_2095: Expected Obj, but got I4
		//IL_20c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c6: Expected Obj, but got Unknown
		//IL_20e6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
		object obj = 0;
		string text2;
		if (CustomCallbackInterfaces != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9CF0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35B5DE8");
			object obj4 = obj3;
			IEnumerable<System.__Canon> values = default;
			string text = string.Join((string)obj, values);
			text2 = text;
		}
		else
		{
			text2 = null;
		}
		byte[] connectionToken = ConnectionToken;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		string text3 = (string)0;
		string text5;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = default;
		if (ConnectionToken != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D50]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			string text4 = string.Format((string)format, arg);
			text5 = text4;
			enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)connectionToken.Length;
			object obj4 = null;
		}
		else
		{
			text5 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54E0]");
		object format2 = 0;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = default;
		object obj6 = default;
		string text8;
		object obj8;
		object obj9;
		object obj10 = default;
		object obj12;
		object obj13;
		object obj14 = default;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator5;
		object obj5 = default;
		if ((object)SessionProperties != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4A60]");
			obj5 = 0;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = ((Dictionary<System.__Canon, System.__Canon>)(object)SessionProperties).GetEnumerator();
			string text6 = null;
			object arg2 = default;
			while (enumerator3.MoveNext())
			{
				string text7 = string.Format((string)format2, obj6, arg2);
				text6 += text7;
				object obj7 = 0;
				object obj4 = null;
			}
			text8 = text6;
			obj8 = 9;
			obj9 = null;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4 = default;
			enumerator3 = enumerator4;
			obj10 = 0;
			object obj11 = obj6;
			enumerator5 = enumerator4;
			enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator3);
			obj12 = 0;
			obj13 = obj14;
			goto IL_24bc;
		}
		object obj15 = null;
		enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		obj13 = obj14;
		goto IL_2414;
		IL_2242:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X25_v13+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num != 0)
		{
			goto IL_2335;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj16;
		if ((nint)obj16 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj9 = 1;
			obj12 = obj10;
		}
		else
		{
			if ((nint)obj16 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A32FC");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X25_v13+28]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				if (num2 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_2335;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj17 = default;
			obj12 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj10 = obj17;
		}
		obj8 = 0;
		goto IL_24bc;
		IL_24bc:
		obj16 = obj5;
		((Dictionary<System.__Canon, System.__Canon>.Enumerator*)enumerator)->Dispose();
		bool flag = obj12 == null;
		object obj18 = !flag;
		string text9 = (string)enumerator;
		if (obj18 != null)
		{
			goto IL_21fd;
		}
		bool flag2 = obj9 == null;
		object obj19 = !flag2;
		text9 = (string)enumerator;
		if (obj19 != null)
		{
			goto IL_2242;
		}
		bool flag3 = (nint)obj8 == 9;
		obj15 = text8;
		obj6 = obj9;
		if (!flag3)
		{
			bool flag4 = obj8 == null;
			obj15 = text8;
			obj6 = obj9;
			if (!flag4)
			{
				text9 = (string)enumerator;
				goto IL_20f8;
			}
		}
		goto IL_2414;
		IL_21fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X25_v13+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num3 == 0)
		{
			OutOfMemoryException ex = new OutOfMemoryException();
			text9 = (string)(object)ex;
			goto IL_2242;
		}
		goto IL_2335;
		IL_2414:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		IndexOutOfRangeException ex2 = default;
		bool flag5 = ex2 == null;
		text8 = (string)obj15;
		obj16 = 32;
		string text10;
		IndexOutOfRangeException ex3;
		object obj158;
		if (!flag5)
		{
			bool flag6 = ((Exception)ex2)._message == null;
			text10 = text2;
			obj16 = 32;
			ex3 = ex2;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D78]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5768]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8C80]");
				text10 = (string)0;
				obj5 = ex2 + 32;
				obj5 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				obj16 = text10;
				object obj23 = default;
				string text11 = string.Format((string)format2, text10, obj23);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-8]");
				object obj24 = 0 & 0xFFFFFFFEL;
				bool flag7 = obj24 == null;
				GameMode gameMode = GameMode;
				object obj7 = 0;
				object obj4 = obj23;
				ex3 = (IndexOutOfRangeException)(object)text11;
				if (!flag7)
				{
					obj5 = ex2 + 40;
					obj5 = text11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-10]");
					bool flag8 = (nint)0 < (nint)2;
					object obj25 = !flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-10]");
					object obj26 = -2;
					bool flag9 = obj26 == null;
					object obj27 = ~obj25;
					object obj28 = obj27 | flag9;
					gameMode = GameMode;
					obj7 = 0;
					obj4 = obj23;
					obj16 = text11;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D58]");
						object obj29 = 0;
						obj16 = obj29;
						obj5 = ex2 + 48;
						obj5 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-18]");
						object obj30 = 0 & 0xFFFFFFFCL;
						bool flag10 = obj30 == null;
						gameMode = GameMode;
						obj7 = 0;
						obj4 = obj23;
						if (!flag10)
						{
							obj16 = SessionName;
							obj5 = ex2 + 56;
							obj5 = SessionName;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-20]");
							bool flag11 = (nint)0 < (nint)4;
							object obj31 = !flag11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-20]");
							object obj32 = -4;
							bool flag12 = obj32 == null;
							object obj33 = ~obj31;
							object obj34 = obj33 | flag12;
							gameMode = GameMode;
							obj7 = 0;
							obj4 = obj23;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D00]");
								object obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5838]");
								text10 = (string)0;
								obj5 = ex2 + 64;
								obj5 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								obj16 = text10;
								object obj36 = default;
								text9 = string.Format((string)format2, text10, obj36);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-28]");
								bool flag13 = (nint)0 < (nint)5;
								object obj37 = !flag13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-28]");
								object obj38 = -5;
								bool flag14 = obj38 == null;
								object obj39 = ~obj37;
								object obj40 = obj39 | flag14;
								object obj41 = obj;
								obj7 = 0;
								obj4 = obj36;
								object obj42 = obj13;
								bool? isVisible;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5818]");
									text10 = (string)0;
									obj5 = ex2 + 72;
									obj5 = text9;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									obj16 = text10;
									object obj43 = default;
									text9 = string.Format((string)format2, text10, obj43);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-30]");
									bool flag15 = (nint)0 < (nint)6;
									object obj44 = !flag15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-30]");
									object obj45 = -6;
									bool flag16 = obj45 == null;
									object obj46 = ~obj44;
									object obj47 = obj46 | flag16;
									obj41 = obj;
									bool? isOpen = IsOpen;
									obj7 = 0;
									obj4 = obj43;
									obj42 = obj;
									if (obj47 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D10]");
										text10 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D40]");
										obj41 = 0;
										obj5 = ex2 + 80;
										obj5 = text9;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										obj16 = obj41;
										object obj48 = default;
										text9 = string.Format((string)format2, obj41, obj48);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-38]");
										object obj49 = 0 & 0xFFFFFFF8L;
										bool flag17 = obj49 == null;
										Dictionary<System.__Canon, System.__Canon>.Enumerator address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
										isOpen = IsOpen;
										obj7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.StartGameArgs)+28]");
										object obj11 = 0;
										enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
										obj4 = obj48;
										obj42 = obj;
										if (!flag17)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D28]");
											obj41 = 0;
											obj5 = ex2 + 88;
											obj5 = text9;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.StartGameArgs)+48]");
											obj11 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											obj16 = obj41;
											object obj50 = default;
											text9 = string.Format((string)format2, obj41, obj50);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-40]");
											bool flag18 = (nint)0 < (nint)8;
											object obj51 = !flag18;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-40]");
											object obj52 = -8;
											bool flag19 = obj52 == null;
											object obj53 = ~obj51;
											object obj54 = obj53 | flag19;
											Dictionary<System.__Canon, System.__Canon>.Enumerator customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
											address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
											isOpen = IsOpen;
											obj7 = 0;
											obj4 = obj50;
											obj42 = obj;
											if (obj54 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DA8]");
												obj41 = 0;
												obj5 = ex2 + 96;
												obj5 = text9;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												obj4 = ObjectProvider;
												obj16 = obj41;
												text9 = string.Format((string)format2, obj41, ObjectProvider);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-48]");
												bool flag20 = (nint)0 < (nint)9;
												object obj55 = !flag20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-48]");
												object obj56 = -9;
												bool flag21 = obj56 == null;
												object obj57 = ~obj55;
												object obj58 = obj57 | flag21;
												customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
												address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
												isOpen = IsOpen;
												obj7 = 0;
												obj42 = obj;
												if (obj58 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D80]");
													obj41 = 0;
													obj5 = ex2 + 104;
													obj5 = text9;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													obj4 = SceneManager;
													obj16 = obj41;
													text9 = string.Format((string)format2, obj41, SceneManager);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-50]");
													bool flag22 = (nint)0 < (nint)10;
													object obj59 = !flag22;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-50]");
													object obj60 = -10;
													bool flag23 = obj60 == null;
													object obj61 = ~obj59;
													object obj62 = obj61 | flag23;
													customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
													address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
													isOpen = IsOpen;
													obj7 = 0;
													obj42 = obj;
													if (obj62 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5500]");
														obj41 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5810]");
														text10 = (string)0;
														obj5 = ex2 + 112;
														obj5 = text9;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														obj16 = text10;
														object obj63 = default;
														text9 = string.Format((string)format2, text10, obj63);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-58]");
														bool flag24 = (nint)0 < (nint)11;
														object obj64 = !flag24;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-58]");
														object obj65 = -11;
														bool flag25 = obj65 == null;
														object obj66 = ~obj64;
														object obj67 = obj66 | flag25;
														int? playerCount = PlayerCount;
														customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
														address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
														isOpen = IsOpen;
														obj7 = 0;
														obj4 = obj63;
														obj42 = obj;
														if (obj67 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D08]");
															obj41 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DC0]");
															text10 = (string)0;
															obj5 = ex2 + 120;
															obj5 = text9;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj68 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 136));
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
															obj16 = text10;
															object obj69 = default;
															text9 = string.Format((string)format2, text10, obj69);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-60]");
															bool flag26 = (nint)0 < (nint)12;
															object obj70 = !flag26;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-60]");
															object obj71 = -12;
															bool flag27 = obj71 == null;
															object obj72 = ~obj70;
															object obj73 = obj72 | flag27;
															playerCount = PlayerCount;
															customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
															address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
															isOpen = IsOpen;
															obj7 = 0;
															obj4 = obj69;
															obj42 = obj;
															if (obj73 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DB8]");
																obj41 = 0;
																obj5 = ex2 + 128;
																obj5 = text9;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																obj16 = obj41;
																object obj74 = default;
																text9 = string.Format((string)format2, obj41, obj74);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-68]");
																bool flag28 = (nint)0 < (nint)13;
																object obj75 = !flag28;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-68]");
																object obj76 = -13;
																bool flag29 = obj76 == null;
																object obj77 = ~obj75;
																object obj78 = obj77 | flag29;
																text3 = text2;
																bool disableNATPunchthrough = DisableNATPunchthrough;
																playerCount = PlayerCount;
																customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																isOpen = IsOpen;
																obj7 = 0;
																obj4 = obj74;
																obj42 = obj;
																if (obj78 == null)
																{
																	obj5 = ex2 + 136;
																	obj5 = text9;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-70]");
																	bool flag30 = (nint)0 < (nint)14;
																	object obj79 = !flag30;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-70]");
																	object obj80 = -14;
																	bool flag31 = obj80 == null;
																	object obj81 = ~obj79;
																	object obj82 = obj81 | flag31;
																	text3 = text2;
																	disableNATPunchthrough = DisableNATPunchthrough;
																	playerCount = PlayerCount;
																	customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																	address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																	isOpen = IsOpen;
																	obj7 = 0;
																	obj4 = obj74;
																	obj16 = text9;
																	string text12 = default;
																	text9 = text12;
																	obj42 = obj;
																	if (obj82 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D60]");
																		object obj83 = 0;
																		obj16 = obj83;
																		obj5 = ex2 + 144;
																		obj5 = obj83;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-78]");
																		object obj84 = 0 & 0xFFFFFFF0L;
																		bool flag32 = obj84 == null;
																		text3 = text2;
																		disableNATPunchthrough = DisableNATPunchthrough;
																		playerCount = PlayerCount;
																		customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																		address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																		isOpen = IsOpen;
																		obj7 = 0;
																		obj4 = obj74;
																		obj42 = obj;
																		if (!flag32)
																		{
																			obj5 = ex2 + 152;
																			obj5 = text2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-80]");
																			bool flag33 = (nint)0 < (nint)16;
																			object obj85 = !flag33;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X24_v40-80]");
																			object obj86 = -16;
																			bool flag34 = obj86 == null;
																			object obj87 = ~obj85;
																			object obj88 = obj87 | flag34;
																			text3 = text2;
																			disableNATPunchthrough = DisableNATPunchthrough;
																			playerCount = PlayerCount;
																			customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																			address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																			isOpen = IsOpen;
																			obj7 = 0;
																			obj4 = obj74;
																			obj16 = text2;
																			obj42 = obj;
																			if (obj88 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D98]");
																				object obj89 = 0;
																				obj16 = obj89;
																				text3 = (string)(ex2 + 160);
																				text3 = (string)obj89;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-88]");
																				bool flag35 = (nint)0 < (nint)17;
																				object obj90 = !flag35;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-88]");
																				object obj91 = -17;
																				bool flag36 = obj91 == null;
																				object obj92 = ~obj90;
																				object obj93 = obj92 | flag36;
																				disableNATPunchthrough = DisableNATPunchthrough;
																				playerCount = PlayerCount;
																				customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																				address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																				isOpen = IsOpen;
																				obj7 = 0;
																				obj4 = obj74;
																				obj42 = obj;
																				if (obj93 == null)
																				{
																					text3 = (string)(ex2 + 168);
																					text3 = text5;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-90]");
																					bool flag37 = (nint)0 < (nint)18;
																					object obj94 = !flag37;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-90]");
																					object obj95 = -18;
																					bool flag38 = obj95 == null;
																					object obj96 = ~obj94;
																					object obj97 = obj96 | flag38;
																					disableNATPunchthrough = DisableNATPunchthrough;
																					playerCount = PlayerCount;
																					customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																					address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																					isOpen = IsOpen;
																					obj7 = 0;
																					obj4 = obj74;
																					obj16 = text5;
																					obj42 = obj;
																					if (obj97 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D90]");
																						object obj98 = 0;
																						obj16 = obj98;
																						text3 = (string)(ex2 + 176);
																						text3 = (string)obj98;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-98]");
																						bool flag39 = (nint)0 < (nint)19;
																						object obj99 = !flag39;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-98]");
																						object obj100 = -19;
																						bool flag40 = obj100 == null;
																						object obj101 = ~obj99;
																						object obj102 = obj101 | flag40;
																						disableNATPunchthrough = DisableNATPunchthrough;
																						playerCount = PlayerCount;
																						customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																						address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																						isOpen = IsOpen;
																						obj7 = 0;
																						obj4 = obj74;
																						obj42 = obj;
																						if (obj102 == null)
																						{
																							text3 = (string)(ex2 + 184);
																							text3 = (string)obj15;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-A0]");
																							bool flag41 = (nint)0 < (nint)20;
																							object obj103 = !flag41;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-A0]");
																							object obj104 = -20;
																							bool flag42 = obj104 == null;
																							object obj105 = ~obj103;
																							object obj106 = obj105 | flag42;
																							disableNATPunchthrough = DisableNATPunchthrough;
																							playerCount = PlayerCount;
																							customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																							address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																							isOpen = IsOpen;
																							obj7 = 0;
																							obj4 = obj74;
																							obj16 = obj15;
																							obj42 = obj;
																							if (obj106 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DB0]");
																								object obj107 = 0;
																								obj16 = obj107;
																								text3 = (string)(ex2 + 192);
																								text3 = (string)obj107;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-A8]");
																								bool flag43 = (nint)0 < (nint)21;
																								object obj108 = !flag43;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-A8]");
																								object obj109 = -21;
																								bool flag44 = obj109 == null;
																								object obj110 = ~obj108;
																								object obj111 = obj110 | flag44;
																								disableNATPunchthrough = DisableNATPunchthrough;
																								playerCount = PlayerCount;
																								customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																								address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																								isOpen = IsOpen;
																								obj7 = 0;
																								obj4 = obj74;
																								obj42 = obj;
																								if (obj111 == null)
																								{
																									obj16 = CustomLobbyName;
																									text3 = (string)(ex2 + 200);
																									text3 = CustomLobbyName;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-B0]");
																									bool flag45 = (nint)0 < (nint)22;
																									object obj112 = !flag45;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-B0]");
																									object obj113 = -22;
																									bool flag46 = obj113 == null;
																									object obj114 = ~obj112;
																									object obj115 = obj114 | flag46;
																									disableNATPunchthrough = DisableNATPunchthrough;
																									playerCount = PlayerCount;
																									customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																									address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																									isOpen = IsOpen;
																									obj7 = 0;
																									obj4 = obj74;
																									obj42 = obj;
																									if (obj115 == null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DA0]");
																										object obj116 = 0;
																										obj16 = obj116;
																										text3 = (string)(ex2 + 208);
																										text3 = (string)obj116;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-B8]");
																										bool flag47 = (nint)0 < (nint)23;
																										object obj117 = !flag47;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-B8]");
																										object obj118 = -23;
																										bool flag48 = obj118 == null;
																										object obj119 = ~obj117;
																										object obj120 = obj119 | flag48;
																										disableNATPunchthrough = DisableNATPunchthrough;
																										playerCount = PlayerCount;
																										customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																										address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																										isOpen = IsOpen;
																										obj7 = 0;
																										obj4 = obj74;
																										obj42 = obj;
																										if (obj120 == null)
																										{
																											obj16 = CustomSTUNServer;
																											text3 = (string)(ex2 + 216);
																											text3 = CustomSTUNServer;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-C0]");
																											bool flag49 = (nint)0 < (nint)24;
																											object obj121 = !flag49;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-C0]");
																											object obj122 = -24;
																											bool flag50 = obj122 == null;
																											object obj123 = ~obj121;
																											object obj124 = obj123 | flag50;
																											disableNATPunchthrough = DisableNATPunchthrough;
																											playerCount = PlayerCount;
																											customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																											address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																											isOpen = IsOpen;
																											obj7 = 0;
																											obj4 = obj74;
																											obj42 = obj;
																											if (obj124 == null)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54C8]");
																												text5 = (string)0;
																												text3 = (string)(ex2 + 224);
																												text3 = (string)obj;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												obj4 = AuthValues;
																												obj16 = text5;
																												text9 = string.Format((string)format2, text5, AuthValues);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-C8]");
																												bool flag51 = (nint)0 < (nint)25;
																												object obj125 = !flag51;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-C8]");
																												object obj126 = -25;
																												bool flag52 = obj126 == null;
																												object obj127 = ~obj125;
																												object obj128 = obj127 | flag52;
																												disableNATPunchthrough = DisableNATPunchthrough;
																												playerCount = PlayerCount;
																												customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																												address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																												isOpen = IsOpen;
																												obj7 = 0;
																												obj42 = obj;
																												if (obj128 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D38]");
																													text5 = (string)0;
																													text3 = (string)(ex2 + 232);
																													text3 = text9;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																													obj4 = CustomPhotonAppSettings;
																													obj16 = text5;
																													string text13 = string.Format((string)format2, text5, CustomPhotonAppSettings);
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-D0]");
																													bool flag53 = (nint)0 < (nint)26;
																													object obj129 = !flag53;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-D0]");
																													object obj130 = -26;
																													bool flag54 = obj130 == null;
																													object obj131 = ~obj129;
																													object obj132 = obj131 | flag54;
																													disableNATPunchthrough = DisableNATPunchthrough;
																													playerCount = PlayerCount;
																													customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																													address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																													obj = obj41;
																													isOpen = IsOpen;
																													isVisible = IsVisible;
																													gameMode = GameMode;
																													obj7 = 0;
																													ex3 = (IndexOutOfRangeException)(object)text13;
																													if (obj132 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D20]");
																														text5 = (string)0;
																														text3 = (string)(ex2 + 240);
																														text3 = text13;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																														obj16 = text5;
																														object obj133 = default;
																														string text14 = string.Format((string)format2, text5, obj133);
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-D8]");
																														bool flag55 = (nint)0 < (nint)27;
																														object obj134 = !flag55;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-D8]");
																														object obj135 = -27;
																														bool flag56 = obj135 == null;
																														object obj136 = ~obj134;
																														object obj137 = obj136 | flag56;
																														bool? enableClientSessionCreation = EnableClientSessionCreation;
																														disableNATPunchthrough = DisableNATPunchthrough;
																														playerCount = PlayerCount;
																														customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																														address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																														obj = obj41;
																														isOpen = IsOpen;
																														isVisible = IsVisible;
																														gameMode = GameMode;
																														obj7 = 0;
																														obj4 = obj133;
																														ex3 = (IndexOutOfRangeException)(object)text14;
																														if (obj137 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D70]");
																															text5 = (string)0;
																															text3 = (string)(ex2 + 248);
																															text3 = text14;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																															obj4 = HostMigrationToken;
																															obj16 = text5;
																															string text15 = string.Format((string)format2, text5, HostMigrationToken);
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-E0]");
																															bool flag57 = (nint)0 < (nint)28;
																															object obj138 = !flag57;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X21_v8 (System.String)-E0]");
																															object obj139 = -28;
																															bool flag58 = obj139 == null;
																															object obj140 = ~obj138;
																															object obj141 = obj140 | flag58;
																															enableClientSessionCreation = EnableClientSessionCreation;
																															disableNATPunchthrough = DisableNATPunchthrough;
																															playerCount = PlayerCount;
																															customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																															address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																															obj = obj41;
																															isOpen = IsOpen;
																															isVisible = IsVisible;
																															gameMode = GameMode;
																															obj7 = 0;
																															ex3 = (IndexOutOfRangeException)(object)text15;
																															if (obj141 == null)
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
																																text3 = (string)0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D30]");
																																text5 = (string)0;
																																object obj142 = ex2 + 256;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																obj16 = text5;
																																object obj143 = default;
																																string text16 = string.Format((string)format2, text5, obj143);
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v11 (System.IndexOutOfRangeException)+18]");
																																bool flag59 = (nint)0 < (nint)29;
																																object obj144 = !flag59;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v11 (System.IndexOutOfRangeException)+18]");
																																object obj145 = -29;
																																bool flag60 = obj145 == null;
																																object obj146 = ~obj144;
																																object obj147 = obj146 | flag60;
																																CancellationToken startGameCancellationToken = StartGameCancellationToken;
																																enableClientSessionCreation = EnableClientSessionCreation;
																																disableNATPunchthrough = DisableNATPunchthrough;
																																playerCount = PlayerCount;
																																customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																																address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																																obj = obj41;
																																isOpen = IsOpen;
																																isVisible = IsVisible;
																																gameMode = GameMode;
																																obj7 = 0;
																																obj4 = obj143;
																																ex3 = (IndexOutOfRangeException)(object)text16;
																																if (obj147 == null)
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D48]");
																																	text3 = (string)0;
																																	object obj148 = ex2 + 264;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																	obj16 = text3;
																																	object obj149 = default;
																																	string text17 = string.Format((string)format2, text3, obj149);
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v11 (System.IndexOutOfRangeException)+18]");
																																	bool flag61 = (nint)0 < (nint)30;
																																	object obj150 = !flag61;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v11 (System.IndexOutOfRangeException)+18]");
																																	object obj151 = -30;
																																	bool flag62 = obj151 == null;
																																	object obj152 = ~obj150;
																																	object obj153 = obj152 | flag62;
																																	bool? useCachedRegions = UseCachedRegions;
																																	startGameCancellationToken = StartGameCancellationToken;
																																	enableClientSessionCreation = EnableClientSessionCreation;
																																	disableNATPunchthrough = DisableNATPunchthrough;
																																	playerCount = PlayerCount;
																																	customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																																	address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																																	obj = obj41;
																																	isOpen = IsOpen;
																																	isVisible = IsVisible;
																																	gameMode = GameMode;
																																	obj7 = 0;
																																	obj4 = obj149;
																																	ex3 = (IndexOutOfRangeException)(object)text17;
																																	if (obj153 == null)
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9CF8]");
																																		text3 = (string)0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D68]");
																																		text5 = (string)0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9D88]");
																																		obj15 = 0;
																																		object obj154 = ex2 + 272;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																		obj16 = obj15;
																																		object obj155 = default;
																																		string text18 = string.Format(text5, obj15, obj155);
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v11 (System.IndexOutOfRangeException)+18]");
																																		object obj156 = 0 & 0xFFFFFFE0L;
																																		bool flag63 = obj156 == null;
																																		MatchmakingMode? matchmakingMode = MatchmakingMode;
																																		useCachedRegions = UseCachedRegions;
																																		startGameCancellationToken = StartGameCancellationToken;
																																		enableClientSessionCreation = EnableClientSessionCreation;
																																		disableNATPunchthrough = DisableNATPunchthrough;
																																		playerCount = PlayerCount;
																																		customPublicAddress = (Dictionary<System.__Canon, System.__Canon>.Enumerator)CustomPublicAddress;
																																		address = (Dictionary<System.__Canon, System.__Canon>.Enumerator)Address;
																																		obj = obj41;
																																		isOpen = IsOpen;
																																		isVisible = IsVisible;
																																		gameMode = GameMode;
																																		obj7 = 0;
																																		obj4 = obj155;
																																		ex3 = (IndexOutOfRangeException)(object)text18;
																																		if (!flag63)
																																		{
																																			object obj157 = ex2 + 280;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																			text9 = string.Concat((string[])(object)ex2);
																																			obj7 = 0;
																																			obj4 = obj155;
																																			obj16 = null;
																																			goto IL_20f8;
																																		}
																																	}
																																}
																															}
																														}
																													}
																													goto IL_216d;
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X25_v13+28]");
								obj158 = 0;
								obj = obj41;
								isVisible = IsVisible;
								gameMode = GameMode;
								text8 = (string)obj15;
								obj13 = obj42;
								goto IL_245c;
							}
						}
					}
				}
			}
			goto IL_216d;
		}
		goto IL_21a8;
		IL_20f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X25_v13+28]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num4 == 0)
		{
			return text9;
		}
		goto IL_2335;
		IL_2335:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		string result = default;
		return result;
		IL_216d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X25_v13+28]");
		obj158 = 0;
		text8 = (string)obj15;
		text9 = (string)(object)ex3;
		goto IL_245c;
		IL_21a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X25_v13+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag64 = num5 != 0;
		text9 = (string)(object)ex2;
		if (!flag64)
		{
			NullReferenceException ex4 = new NullReferenceException();
			obj9 = obj6;
			text9 = (string)(object)ex4;
			goto IL_21fd;
		}
		goto IL_2335;
		IL_245c:
		object obj159 = obj158;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (obj159 == null)
		{
			ex2 = new IndexOutOfRangeException();
			text2 = text10;
			goto IL_21a8;
		}
		goto IL_2335;
	}
}
