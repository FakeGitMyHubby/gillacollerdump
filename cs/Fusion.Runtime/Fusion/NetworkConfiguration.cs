using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion.Sockets;

namespace Fusion;

[Serializable]
public class NetworkConfiguration : _0021_00210
{
	public enum SimulationTimeMode
	{
		// error: enumerator has no value
		UnscaledDeltaTime,
		// error: enumerator has no value
		DeltaTime
	}

	public double ConnectionTimeout;

	public double ConnectionShutdownTime;

	public TimeSyncConfiguration.ReliableDataTransfers ReliableDataTransferModes;

	public int GameChannelSendCount;

	public int GameReliableChannelSendCount = 1;

	public int SocketSendBufferSize => 256;

	public int SocketRecvBufferSize => 256;

	public int ConnectAttempts => 10;

	public double ConnectInterval => 0.5;

	public double ConnectionDefaultRtt
	{
		get
		{
			//IL_000d: Expected F8, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAC8]");
			return 0.0;
		}
	}

	public double ConnectionPingInterval => 1.0;

	public NetworkConfiguration Init()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		NetworkConfiguration networkConfiguration = (NetworkConfiguration)MemberwiseClone();
		if (networkConfiguration != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9970]");
			object obj = 0;
			object obj2 = obj;
			nint num = (nint)networkConfiguration;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6 (Il2CppClass<Fusion.NetworkConfiguration>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6 (Il2CppClass<Fusion.NetworkConfiguration>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9-8]");
				if (0 == (nint)obj2)
				{
					goto IL_00a9;
				}
			}
			return (NetworkConfiguration)(object)new InvalidCastException();
		}
		goto IL_00a9;
		IL_00a9:
		return networkConfiguration;
	}

	internal unsafe NetConfig ToNetConfig(NetAddress address)
	{
		//IL_0017: Expected Obj, but got Ref
		//IL_002e: Expected native int or pointer, but got VT
		//IL_003c: Expected native int or pointer, but got VT
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0057: Expected native int or pointer, but got VT
		//IL_0069: Expected native int or pointer, but got VT
		//IL_0077: Expected native int or pointer, but got VT
		//IL_0089: Expected native int or pointer, but got VT
		//IL_009b: Expected native int or pointer, but got VT
		//IL_00aa: Expected native int or pointer, but got VT
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00c6: Expected native int or pointer, but got VT
		//IL_00d8: Expected native int or pointer, but got VT
		//IL_00f4: Expected native int or pointer, but got VT
		//IL_0103: Expected native int or pointer, but got VT
		NetConfig defaults = NetConfig.Defaults;
		int connectionSendBuffers = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref connectionSendBuffers, 28));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		NetConfig netConfig = default;
		int packetSize = default;
		((NetConfig*)(nint)netConfig)->PacketSize = packetSize;
		((NetConfig*)(nint)netConfig)->ConnectAttempts = 10;
		object obj2 = netConfig + 112;
		((NetConfig*)(nint)netConfig)->ConnectionSendBuffers = connectionSendBuffers;
		((NetConfig*)(nint)netConfig)->ConnectInterval = 0.5;
		((NetConfig*)(nint)netConfig)->SocketSendBuffer = 4;
		((NetConfig*)(nint)netConfig)->ConnectionDefaultRtt = -0.10000000000000002;
		((NetConfig*)(nint)netConfig)->ConnectionPingInterval = 1.0;
		((NetConfig*)(nint)netConfig)->ConnectionTimeout = ConnectionTimeout;
		((NetConfig*)(nint)netConfig)->ConnectionShutdownTime = ConnectionShutdownTime;
		int maxConnections = default;
		((NetConfig*)(nint)netConfig)->MaxConnections = maxConnections;
		double operationExpireTime = default;
		((NetConfig*)(nint)netConfig)->OperationExpireTime = operationExpireTime;
		_ = address.Block2;
		((NetConfig*)(nint)netConfig)->Address = (NetAddress)address.NativeAddress;
		((NetConfig*)(nint)netConfig)->GameSendCount = GameChannelSendCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		NetConfig result = default;
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetConfig result2 = default;
		return result2;
	}

	public void SanityCheck()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_005b: Expected F8, but got I
		//IL_006d: Invalid comparison between F8 and I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double connectionShutdownTime = Math.Max(1.0, ConnectionShutdownTime);
		ConnectionShutdownTime = connectionShutdownTime;
		bool flag2 = ConnectionTimeout < 1.0;
		double connectionTimeout = 1.0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B410]");
			connectionTimeout = 0.0;
			double connectionTimeout2 = ConnectionTimeout;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B410]");
			if (!(connectionTimeout2 > 0.0))
			{
				connectionTimeout = ConnectionTimeout;
			}
		}
		ConnectionTimeout = connectionTimeout;
	}

	public NetworkConfiguration()
	{
		//IL_001d: Expected F8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DBF0]");
		ConnectionTimeout = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B418]");
		ReliableDataTransferModes = (TimeSyncConfiguration.ReliableDataTransfers)0;
		base._002Ector();
	}
}
