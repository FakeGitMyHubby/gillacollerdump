using Fusion.Sockets;

namespace Fusion;

internal struct SimulationArgs
{
	public SimulationModes Mode;

	public NetAddress Address;

	public INetSocket Socket;

	public NetworkProjectConfig Config;

	public Simulation.ICallbacks Callbacks;

	public Tick ResumeTick;

	public byte[] ResumeState;

	public NetworkId ResumeNetworkId;

	public bool IsPlayer
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected Obj, but got I4
			//IL_0051: Expected Obj, but got I4
			object obj = Mode - 4;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				object obj4 = Mode - 2;
				return obj4 == null;
			}
			return true;
		}
	}

	public bool IsServer
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			object obj = Mode - 1;
			bool flag = (nint)obj < 2;
			object obj2 = !flag;
			return (byte)(int)(~obj2) != 0;
		}
	}
}
