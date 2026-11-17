using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Photon.Client;

public abstract class PhotonSocket
{
	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public PeerBase _003C_003E4__this;

		public StatusCode statusValue;

		internal void _003CEnqueueStatusCallback_003Eb__0()
		{
			//IL_0021: Expected I, but got Obj
			//IL_0031: Expected Obj, but got I
			//IL_004b: Expected Obj, but got I
			//IL_0140: Expected Obj, but got I
			//IL_0086: Expected Obj, but got I
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected Obj, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected Obj, but got Unknown
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected Obj, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected Obj, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected Obj, but got Unknown
			IPhotonPeerListener listener = _003C_003E4__this.Listener;
			nint num = (nint)listener;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
			object obj = 0;
			StatusCode statusCode = statusValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00c7;
			}
			object obj4 = obj3 + 2;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0128;
			IL_00c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0128;
			IL_0128:
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v6+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v54 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	protected internal PeerBase peerBase;

	protected readonly ConnectionProtocol Protocol;

	public bool PollReceive;

	private PhotonSocketState stateField;

	private int SocketErrorCode__BackingField;

	public string ConnectAddress;

	private string ServerAddress__BackingField;

	private string ProxyServerAddress__BackingField;

	private string ServerIpAddress__BackingField;

	private int ServerPort__BackingField;

	private bool AddressResolvedAsIpv6__BackingField;

	private string UrlProtocol__BackingField;

	private string UrlPath__BackingField;

	protected IPhotonPeerListener Listener
	{
		get
		{
			if (peerBase != null)
			{
				return peerBase.Listener;
			}
			return (IPhotonPeerListener)new NullReferenceException();
		}
	}

	protected internal int MTU
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if (peerBase != null)
			{
				return peerBase.mtu;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public PhotonSocketState State
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			return stateField;
		}
		protected set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			stateField = value;
		}
	}

	public int SocketErrorCode
	{
		get
		{
			return SocketErrorCode__BackingField;
		}
		protected set
		{
			SocketErrorCode__BackingField = value;
		}
	}

	public bool Connected
	{
		get
		{
			//IL_001a: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			object obj = stateField - 2;
			return obj == null;
		}
	}

	protected LogLevel LogLevel
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if (peerBase != null)
			{
				return peerBase.LogLevel;
			}
			NullReferenceException ex = new NullReferenceException();
			return (LogLevel)(int)ex;
		}
	}

	public string ServerAddress
	{
		get
		{
			return ServerAddress__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string ProxyServerAddress
	{
		get
		{
			return ProxyServerAddress__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string ServerIpAddress
	{
		get
		{
			return ServerIpAddress__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public int ServerPort
	{
		get
		{
			return ServerPort__BackingField;
		}
		protected set
		{
			ServerPort__BackingField = value;
		}
	}

	public bool AddressResolvedAsIpv6
	{
		get
		{
			return AddressResolvedAsIpv6__BackingField;
		}
		protected internal set
		{
			AddressResolvedAsIpv6__BackingField = value;
		}
	}

	public string UrlProtocol
	{
		get
		{
			return UrlProtocol__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string UrlPath
	{
		get
		{
			return UrlPath__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	protected internal string SerializationProtocol
	{
		get
		{
			//IL_017d: Expected Obj, but got I
			//IL_0037: Expected Obj, but got I
			//IL_0047: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0079: Expected Obj, but got I4
			//IL_009f: Expected VT, but got Obj
			//IL_00fe: Expected Obj, but got I
			//IL_0118: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I4
			PeerBase peerBase = this.peerBase;
			if (this.peerBase != null && peerBase.photonPeer != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+E8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516738]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
				PeerBase peerBase2 = this.peerBase;
				if (this.peerBase != null && peerBase2.photonPeer != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516740]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+A0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object value = default;
					return Enum.GetName(typeFromHandle, value);
				}
				return (string)(object)new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516748]");
			return (string)0;
		}
	}

	public PhotonSocket(PeerBase peerBase)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I
		if (peerBase != null)
		{
			object obj = this + 16;
			obj = peerBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj2 = obj;
			_ = peerBase.usedTransportProtocol;
			object obj3 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v2+30]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Exception ex = default;
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
	}

	public unsafe virtual bool Connect()
	{
		//IL_01ee: Expected I4, but got Obj
		//IL_0731: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_052b: Expected Obj, but got I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_0100: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_05af: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_05ea: Expected I, but got Obj
		//IL_05fa: Expected Obj, but got I
		//IL_060a: Expected Obj, but got I
		//IL_0631: Expected Obj, but got Ref
		//IL_0639: Expected Obj, but got Ref
		//IL_0641: Expected Obj, but got Ref
		//IL_03e5: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected Obj, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_0675: Expected Obj, but got I
		//IL_0819: Expected Obj, but got Ref
		//IL_0821: Expected Obj, but got Ref
		//IL_0444: Expected I, but got Obj
		//IL_0454: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected Obj, but got Unknown
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_049f: Expected Obj, but got I
		//IL_06be: Expected Obj, but got Ref
		//IL_06c6: Expected Obj, but got Ref
		//IL_06ce: Expected Obj, but got Ref
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected Obj, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		PeerBase peerBase = this.peerBase;
		nint num;
		object obj6;
		bool result;
		ushort port;
		string scheme;
		string absolutePath;
		IPhotonPeerListener listener3;
		string text4;
		object obj27;
		object obj28;
		object obj29;
		IPhotonPeerListener photonPeerListener;
		string text2;
		if (stateField != 0)
		{
			if (this.peerBase != null)
			{
				LogLevel logLevel = this.peerBase.LogLevel;
				object obj = logLevel & (LogLevel)0xFF;
				if (obj == null)
				{
					goto IL_0764;
				}
				if (this.peerBase != null)
				{
					IPhotonPeerListener listener = this.peerBase.Listener;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166A0]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166B8]");
					object format = 0;
					object arg = default;
					string text = string.Format((string)format, arg);
					if (listener != null)
					{
						num = (nint)listener;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v8 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						object obj4 = 0;
						object obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v8 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						bool flag = (nint)0 == 0;
						photonPeerListener = listener;
						text2 = text;
						if (flag)
						{
							goto IL_01c4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v8 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
						obj6 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v4-8]");
							bool flag2 = 0 == (nint)obj5;
							photonPeerListener = listener;
							text2 = text;
							if (flag2)
							{
								break;
							}
							obj4--;
							obj6 += 16;
							bool flag3 = (nint)obj4 != 1;
							photonPeerListener = listener;
							text2 = text;
							if (flag3)
							{
								continue;
							}
							goto IL_01c4;
						}
						goto IL_06e3;
					}
				}
			}
		}
		else
		{
			bool flag4 = this.peerBase == null;
			result = (byte)(int)this.peerBase != 0;
			if (flag4)
			{
				goto IL_07b5;
			}
			if (Protocol != peerBase.usedTransportProtocol)
			{
				goto IL_0764;
			}
			if (((PhotonSocket)(object)this.peerBase).TryParseAddress(peerBase.ServerAddress__BackingField, out string host, out port, out scheme, out absolutePath))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v5+98]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v13+A0]");
				object obj9 = 0;
				object obj10 = this + 64;
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj11 = this + 48;
				obj11 = host;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				ServerPort__BackingField = port;
				object obj12 = this + 80;
				obj12 = scheme;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj13 = this + 88;
				obj13 = absolutePath;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X20_v11-48]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X20_v11-48]");
					LogLevel logLevel2 = ((PeerBase)0).LogLevel;
					object obj14 = logLevel2 & (LogLevel)0xFF;
					bool flag5 = (nint)obj14 < 4;
					object obj15 = !flag5;
					object obj16 = ~obj15;
					if (obj16 != null)
					{
						goto IL_07ba;
					}
					if (this.peerBase != null)
					{
						IPhotonPeerListener listener2 = this.peerBase.Listener;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514B70]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166B0]");
						object format2 = 0;
						object arg2 = default;
						object arg3 = default;
						string text3 = string.Format((string)format2, ServerAddress__BackingField, arg2, arg3);
						if (listener2 != null)
						{
							nint num2 = (nint)listener2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v24 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v24 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_04e0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v24 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
							object obj20 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X10_v18-8]");
								if (0 == (nint)obj18)
								{
									break;
								}
								obj19--;
								obj20 += 16;
								if ((nint)obj19 != 1)
								{
									continue;
								}
								goto IL_04e0;
							}
							object obj21 = num2 + obj20;
							object obj22 = obj21 + 312;
							goto IL_07ec;
						}
					}
				}
			}
			else if (this.peerBase != null)
			{
				LogLevel logLevel3 = this.peerBase.LogLevel;
				object obj23 = logLevel3 & (LogLevel)0xFF;
				if (obj23 == null)
				{
					goto IL_0764;
				}
				if (this.peerBase != null)
				{
					listener3 = this.peerBase.Listener;
					PeerBase peerBase2 = this.peerBase;
					if (this.peerBase != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65166A8]");
						object obj24 = 0;
						text4 = (string)obj24 + peerBase2.ServerAddress__BackingField;
						if (listener3 != null)
						{
							nint num3 = (nint)listener3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v12 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
							object obj26 = 0;
							object obj5 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v12 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
							bool flag6 = (nint)0 == 0;
							obj27 = (object)(&absolutePath);
							obj28 = (object)(&scheme);
							obj29 = (object)(&port);
							photonPeerListener = listener3;
							text2 = text4;
							if (flag6)
							{
								goto IL_01c4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v12 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
							obj6 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v4-8]");
								bool flag7 = 0 == (nint)obj5;
								obj27 = (object)(&absolutePath);
								obj28 = (object)(&scheme);
								num = num3;
								photonPeerListener = listener3;
								text2 = text4;
								if (flag7)
								{
									break;
								}
								obj26--;
								obj6 += 16;
								if ((nint)obj26 != 1)
								{
									continue;
								}
								goto IL_06b6;
							}
							goto IL_06e3;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_07b5:
		return result;
		IL_06b6:
		obj27 = (object)(&absolutePath);
		obj28 = (object)(&scheme);
		obj29 = (object)(&port);
		photonPeerListener = listener3;
		text2 = text4;
		goto IL_01c4;
		IL_04e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_07ec;
		IL_0764:
		result = false;
		goto IL_07b5;
		IL_07a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v534 @ X0_v5] (should have been resolved before IL gen)");
		goto IL_0764;
		IL_07ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v625 @ X0_v44] (should have been resolved before IL gen)");
		goto IL_07ba;
		IL_07ba:
		result = true;
		goto IL_07b5;
		IL_01c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_07a6;
		IL_06e3:
		object obj30 = num + obj6;
		object obj31 = obj30 + 312;
		goto IL_07a6;
	}

	public abstract bool Disconnect();

	public abstract PhotonSocketError Send(byte[] data, int length);

	public abstract PhotonSocketError Receive(out byte[] data);

	public void HandleReceivedDatagram(byte[] inBuffer, int length, bool willBeReused)
	{
		//IL_0052: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_012e: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		PeerBase peerBase = this.peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		PeerBase peerBase2 = this.peerBase;
		if (peerBase.PhotonSocket != this)
		{
			LogLevel logLevel = peerBase2.LogLevel;
			object obj = logLevel & (LogLevel)0xFF;
			bool flag = (nint)obj < 4;
			object obj2 = !flag;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516758]");
				object format = 0;
				object arg = default;
				string debugReturn = string.Format((string)format, arg);
				this.peerBase.EnqueueDebugReturn((LogLevel)4, debugReturn);
			}
			return;
		}
		PhotonPeer photonPeer = peerBase2.photonPeer;
		ITrafficRecorder trafficRecorder = photonPeer.TrafficRecorder;
		bool flag2 = photonPeer.TrafficRecorder == null;
		bool flag3 = willBeReused;
		if (flag2)
		{
			goto IL_01f9;
		}
		nint num = (nint)trafficRecorder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516358]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v11 (Il2CppClass<Photon.Client.ITrafficRecorder>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v11 (Il2CppClass<Photon.Client.ITrafficRecorder>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v11 (Il2CppClass<Photon.Client.ITrafficRecorder>)+98]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v9-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj6--;
			obj7 += 16;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_01ca;
		}
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_0318;
		IL_01ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0318;
		IL_0318:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v335 @ X0_v16] (should have been resolved before IL gen)");
		peerBase2 = this.peerBase;
		flag3 = true;
		goto IL_01f9;
		IL_01f9:
		NetworkSimulationSet networkSimulationSettings = peerBase2.NetworkSimulationSettings;
		PeerBase peerBase3;
		byte[] dataReceived;
		if (networkSimulationSettings.IsSimulationEnabled)
		{
			if (willBeReused)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Array array = default;
				int count = default;
				Buffer.BlockCopy(inBuffer, 0, array, 0, count);
				peerBase3 = this.peerBase;
				dataReceived = (byte[])array;
				goto IL_033a;
			}
		}
		else
		{
			PeerBase peerBase4 = this.peerBase;
			nint num2 = (nint)peerBase4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v238 @ X8_v7 (Il2CppClass<Photon.Client.PeerBase>)+238] (should have been resolved before IL gen)");
		}
		peerBase3 = this.peerBase;
		dataReceived = inBuffer;
		goto IL_033a;
		IL_033a:
		peerBase3.ReceiveNetworkSimulated(dataReceived);
	}

	public bool ReportDebugOfLevel(LogLevel levelOfMessage)
	{
		//IL_0068: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I4
		if (peerBase != null)
		{
			LogLevel logLevel = peerBase.LogLevel;
			object obj = logLevel & (LogLevel)0xFF;
			bool flag = (nint)obj < (int)levelOfMessage;
			return !flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public void EnqueueDebugReturn(LogLevel logLevel, string message)
	{
		peerBase.EnqueueDebugReturn(logLevel, message);
	}

	protected internal void HandleException(StatusCode statusCode)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0051: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		stateField = (PhotonSocketState)3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516750]");
		object obj2 = 0;
		peerBase.EnqueueStatusCallback(statusCode);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		PeerBase.MyAction myAction = default;
		myAction._002Ector(this, (IntPtr)obj2);
		peerBase.EnqueueActionForDispatch(myAction);
	}

	protected internal unsafe bool TryParseAddress(string url, out string host, out ushort port, out string scheme, out string absolutePath)
	{
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I
		//IL_046c: Expected Obj, but got I
		//IL_002c: Expected Obj, but got I4
		//IL_03cf: Expected I4, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I
		//IL_04c2: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got Ref
		//IL_04e0: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X26_v2+98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+A0]");
		object obj3 = 0;
		ref string reference = ref *(string*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ref ushort reference2 = ref *(ushort*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X26_v2+98]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+A0]");
		object obj5 = 0;
		ref string reference3 = ref *(string*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X26_v2+98]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+A0]");
		object obj7 = 0;
		ref string reference4 = ref *(string*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = string.IsNullOrEmpty(url);
		bool flag2 = !flag;
		object obj8 = !flag2;
		bool result = false;
		Uri result2;
		string text3;
		if (obj8 == null)
		{
			if (url != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168F0]");
				object obj9 = 0;
				string text = (string)obj9;
				bool flag3 = url.Contains((string)obj9);
				bool flag4 = !flag3;
				object obj10 = !flag4;
				string uriString = url;
				object obj11 = 0;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168E8]");
					object obj12 = 0;
					string text2 = (string)obj12 + url;
					uriString = text2;
					obj11 = 0;
					text = url;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD98]");
				object obj13 = 0;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v17+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!Uri.TryCreate(uriString, (UriKind)1, out result2))
				{
					result = false;
					goto IL_0483;
				}
				if ((object)result2 != null)
				{
					string host2 = result2.Host;
					reference = ref *(string*)host2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag6 = !flag3;
					object obj16 = !flag6;
					object obj17 = (object)(&result2);
					if (obj16 == null)
					{
						if ((object)result2 == null)
						{
							goto IL_03c1;
						}
						int port2 = result2.Port;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168F8]");
						object format = 0;
						object arg = default;
						string value = string.Format((string)format, arg);
						bool flag7 = url.Contains(value);
						bool flag8 = !flag7;
						obj17 = 0;
						if (flag8)
						{
							reference2 = ref *(ushort*)null;
							obj17 = 0;
							goto IL_04d0;
						}
					}
					if ((object)result2 != null)
					{
						int port3 = result2.Port;
						reference2 = ref *(ushort*)port3;
						if (!flag3)
						{
							goto IL_04d0;
						}
						if ((object)result2 != null)
						{
							string scheme2 = result2.Scheme;
							text3 = scheme2;
							goto IL_04fd;
						}
					}
				}
			}
			goto IL_03c1;
		}
		goto IL_0483;
		IL_04d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X26_v2+98]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v26+A0]");
		object obj19 = 0;
		text3 = (string)obj19;
		goto IL_04fd;
		IL_04fd:
		reference3 = ref *(string*)text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if ((object)result2 != null)
		{
			string absolutePath2 = result2.AbsolutePath;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
			object obj20 = 0;
			if (obj20 != null)
			{
				string text4;
				if (((string)obj20).Equals(absolutePath2))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X26_v2+98]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v23+A0]");
					object obj22 = 0;
					text4 = (string)obj22;
				}
				else
				{
					if ((object)result2 == null)
					{
						goto IL_03c1;
					}
					string absolutePath3 = result2.AbsolutePath;
					text4 = absolutePath3;
				}
				reference4 = ref *(string*)text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = true;
				goto IL_0483;
			}
		}
		goto IL_03c1;
		IL_0483:
		return result;
		IL_03c1:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe bool IpAddressTryParse(string strIP, out IPAddress address)
	{
		//IL_0357: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_031d: Expected I4, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I8
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got Ref
		ref IPAddress reference = ref *(IPAddress*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = string.IsNullOrEmpty(strIP);
		bool flag2 = !flag;
		object obj = !flag2;
		bool result = false;
		byte[] array3 = default;
		byte result2;
		object obj10;
		object obj11;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			char[] array = default;
			if (array != null)
			{
				if (array.Length == 0)
				{
					goto IL_0301;
				}
				array[0] = '.';
				if (strIP != null)
				{
					string[] array2 = strIP.Split(array);
					if (array2 != null)
					{
						if (array2.Length != 4)
						{
							goto IL_02f3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						if (array2.Length >= 1)
						{
							object obj4 = array2.Length & 0xFFFFFFFFL;
							object obj5 = array2 + 32;
							object obj6 = array3 + 32;
							result2 = 0;
							object obj7 = 0;
							while (true)
							{
								bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
								object obj8 = !flag3;
								if (obj8 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X23_v7+v195 @ X22_v8*8]");
								if (!byte.TryParse((string)0, out result2))
								{
									goto IL_02f3;
								}
								if (array3 != null)
								{
									bool flag4 = (nint)obj7 < array3.Length;
									object obj9 = !flag4;
									if (obj9 != null)
									{
										break;
									}
									_ = 0;
									obj7++;
									obj4 = array2.Length;
									bool flag5 = (nint)obj7 < array2.Length;
									result2 = 0;
									if (flag5)
									{
										continue;
									}
									goto IL_021c;
								}
								goto IL_030f;
							}
							goto IL_0301;
						}
						bool flag6 = array3 == null;
						obj10 = 0;
						obj11 = 4;
						if (!flag6)
						{
							goto IL_0261;
						}
					}
				}
			}
			goto IL_030f;
		}
		goto IL_036e;
		IL_021c:
		obj10 = 0;
		obj11 = (object)(&result2);
		goto IL_0261;
		IL_0301:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_030f;
		IL_0261:
		if (array3.Length == 0)
		{
			goto IL_0301;
		}
		if (array3[0] == 0)
		{
			goto IL_02f3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DB288]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		IPAddress iPAddress = default;
		iPAddress._002Ector(array3);
		reference = ref *(IPAddress*)iPAddress;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		result = true;
		goto IL_036e;
		IL_036e:
		return result;
		IL_030f:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_02f3:
		result = false;
		goto IL_036e;
	}

	protected internal unsafe IPAddress[] GetIpAddresses(string hostname)
	{
		//IL_0010: Expected Obj, but got I
		//IL_08db: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got Ref
		//IL_09e6: Expected Obj, but got I
		//IL_0a00: Expected Obj, but got I
		//IL_0a11: Expected I, but got Obj
		//IL_0a21: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got Ref
		//IL_09c9: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I4
		//IL_08fe: Expected Obj, but got I
		//IL_090e: Expected Obj, but got I
		//IL_0930: Expected Obj, but got I4
		//IL_016f: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I4
		//IL_0953: Expected Obj, but got I
		//IL_096d: Expected Obj, but got I
		//IL_097e: Expected I, but got Obj
		//IL_099c: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I4
		//IL_04a0: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I
		//IL_04ee: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I4
		//IL_0512: Expected Obj, but got I
		//IL_0553: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DB288]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IPAddress[] array;
		IndexOutOfRangeException ex = default;
		if (IPAddress.TryParse(hostname, out var address))
		{
			bool flag2 = address == null;
			object obj4 = 0;
			object obj5 = null;
			Comparison<System.__Canon> comparison = (Comparison<System.__Canon>)(&address);
			PhotonSocket photonSocket = this;
			if (!flag2)
			{
				AddressFamily addressFamily = address.AddressFamily;
				bool flag3 = addressFamily == (AddressFamily)23;
				obj5 = null;
				if (!flag3)
				{
					bool flag4 = ((PhotonSocket)addressFamily).IpAddressTryParse(hostname, out address);
					bool flag5 = !flag4;
					obj5 = (object)(&address);
					if (flag5)
					{
						HandleException((StatusCode)1050);
						array = null;
						goto IL_08e9;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516920]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				IPAddress[] array2 = default;
				bool flag6 = array2 == null;
				obj4 = 0;
				comparison = (Comparison<System.__Canon>)1;
				photonSocket = this;
				if (!flag6)
				{
					bool flag7 = address == null;
					Comparison<System.__Canon> comparison2 = (Comparison<System.__Canon>)1;
					if (!flag7)
					{
						nint num = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v58 (Il2CppClass<System.Net.IPAddress[]>)+40]");
						comparison2 = (Comparison<System.__Canon>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag8 = ex == null;
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v58 (Il2CppClass<System.Net.IPAddress[]>)+40]");
						comparison = (Comparison<System.__Canon>)0;
						photonSocket = (PhotonSocket)(object)address;
						if (flag8)
						{
							goto IL_05cb;
						}
					}
					bool flag9 = array2.Length == 0;
					obj4 = 0;
					comparison = comparison2;
					photonSocket = (PhotonSocket)(object)address;
					if (flag9)
					{
						goto IL_05bd;
					}
					object obj7 = array2 + 32;
					obj7 = address;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					array = array2;
					goto IL_08e9;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DC148]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v88+E4]");
			bool flag10 = (nint)0 == 0;
			object obj10 = !flag10;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IPAddress[] hostAddresses = Dns.GetHostAddresses(ServerAddress__BackingField);
			object obj4 = 0;
			object obj5 = null;
			object obj11 = 0;
			PhotonSocket photonSocket = this;
			array = hostAddresses;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516908]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516928]");
			object obj13 = 0;
			Comparison<System.__Canon> comparison3 = default;
			comparison3._002Ector((object)photonSocket, (IntPtr)obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516900]");
			object obj14 = 0;
			obj5 = obj14;
			Array.Sort((System.__Canon[])(object)array, comparison3);
			bool flag11 = photonSocket.peerBase == null;
			object obj15 = null;
			Comparison<System.__Canon> comparison = comparison3;
			if (!flag11)
			{
				LogLevel logLevel = photonSocket.peerBase.LogLevel;
				object obj16 = logLevel & (LogLevel)0xFF;
				bool flag12 = (nint)obj16 < 3;
				object obj17 = !flag12;
				object obj18 = ~obj17;
				if (obj18 != null)
				{
					goto IL_08e9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516938]");
				object obj19 = 0;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v13+E4]");
				bool flag13 = (nint)0 == 0;
				object obj21 = !flag13;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj19;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v13+A0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v30+8]");
				Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v30+8]");
				bool flag14 = (nint)0 == 0;
				object obj23 = !flag14;
				obj15 = null;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v13+E4]");
					bool flag15 = (nint)0 == 0;
					object obj24 = !flag15;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj25 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v34+A0]");
						obj22 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516918]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516930]");
					object obj27 = 0;
					Func<System.__Canon, System.__Canon> func = default;
					func._002Ector(obj22, (IntPtr)obj27);
					object obj28 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v33+A0]");
					object obj29 = (nint)0 + (nint)8;
					obj29 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj15 = null;
					selector = func;
				}
				IEnumerable<System.__Canon> source = Enumerable.Select((IEnumerable<System.__Canon>)(object)array, selector);
				System.__Canon[] array3 = Enumerable.ToArray(source);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
				object separator = 0;
				string text = string.Join((string)separator, (string[])(object)array3);
				bool flag16 = photonSocket.peerBase == null;
				obj5 = null;
				comparison = (Comparison<System.__Canon>)(object)array3;
				if (!flag16)
				{
					LogLevel logLevel2 = photonSocket.peerBase.LogLevel;
					object obj30 = logLevel2 & (LogLevel)0xFF;
					bool flag17 = (nint)obj30 < 3;
					object obj31 = !flag17;
					object obj32 = ~obj31;
					if (obj32 != null)
					{
						goto IL_08e9;
					}
					bool flag18 = array3 == null;
					obj5 = null;
					comparison = null;
					if (!flag18)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj33 = 0;
						object obj26 = array3.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516940]");
						object format = 0;
						object obj34 = default;
						string debugReturn = string.Format((string)format, photonSocket.ServerAddress__BackingField, obj34, text);
						bool flag19 = photonSocket.peerBase == null;
						object obj35 = array3.Length;
						obj15 = text;
						obj5 = obj34;
						comparison = (Comparison<System.__Canon>)(object)photonSocket.ServerAddress__BackingField;
						if (!flag19)
						{
							photonSocket.peerBase.EnqueueDebugReturn((LogLevel)3, debugReturn);
							goto IL_08e9;
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_05bd;
		IL_08e9:
		return array;
		IL_05bd:
		ex = new IndexOutOfRangeException();
		goto IL_05cb;
		IL_05cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex3 = new ArgumentNullException();
		object obj36 = 0;
		ArgumentNullException ex4 = ex3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		IPAddress[] result = default;
		return result;
	}

	private int AddressSortComparer(IPAddress x, IPAddress y)
	{
		//IL_00ff: Expected I4, but got Obj
		//IL_009c: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00ec: Expected I4, but got I8
		//IL_00da: Expected I4, but got I8
		if (x != null)
		{
			AddressFamily addressFamily = x.AddressFamily;
			if (y != null)
			{
				AddressFamily addressFamily2 = y.AddressFamily;
				if (addressFamily == addressFamily2)
				{
					return 0;
				}
				AddressFamily addressFamily3 = x.AddressFamily;
				object obj = addressFamily3 - 23;
				bool flag = obj == null;
				object obj2 = !flag;
				object obj3 = ~obj2;
				if (obj3 == null)
				{
					return 1;
				}
				return -1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void _003CHandleException_003Eb__58_0()
	{
		//IL_0017: Expected I, but got Obj
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		PeerBase peerBase = this.peerBase;
		nint num = (nint)peerBase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Photon.Client.PeerBase>)+1C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Photon.Client.PeerBase>)+1D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
