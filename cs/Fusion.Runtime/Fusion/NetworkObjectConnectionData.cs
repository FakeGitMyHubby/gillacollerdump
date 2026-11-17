using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal class NetworkObjectConnectionData
{
	private class DebuggerProxy
	{
		public readonly NetworkObjectConnectionData[] Items;

		public DebuggerProxy(NetworkObjectGuid.List list)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected Obj, but got Unknown
			NetworkObjectGuid.List list2 = default;
			NetworkObjectConnectionData[] array = list2.ToArray();
			object obj = this + 16;
			obj = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	private Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData> _node;

	public NetworkId Id;

	public int PriorityLevel = 1;

	private NetworkObjectConnectionDataStatus Status__BackingField;

	private Tick _tickAcknowledged;

	private Tick _tickSent;

	public NetworkObjectConnectionDataFlags Flags;

	public Tick TickMin;

	public ulong Filter = 18446744073709551615uL;

	private NetworkObjectHeaderPlayerDataFlags PlayerFlags__BackingField;

	private ChangeTick PlayerFlagsChangeTick__BackingField;

	public NetworkObjectConnectionDataStatus Status
	{
		get
		{
			return Status__BackingField;
		}
		private set
		{
			Status__BackingField = value;
		}
	}

	public Tick TickSent
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _tickSent;
		}
	}

	public Tick TickAcknowledged
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _tickAcknowledged;
		}
	}

	public NetworkObjectHeaderPlayerDataFlags PlayerFlags
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return PlayerFlags__BackingField;
		}
		[MethodImpl((MethodImplOptions)256)]
		private set
		{
			PlayerFlags__BackingField = value;
		}
	}

	public ChangeTick PlayerFlagsChangeTick
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return PlayerFlagsChangeTick__BackingField;
		}
		[MethodImpl((MethodImplOptions)256)]
		private set
		{
			PlayerFlagsChangeTick__BackingField = value;
		}
	}

	public void SetPlayerFlag(NetworkObjectHeaderPlayerDataFlags flags, Simulation simulation)
	{
		NetworkObjectHeaderPlayerDataFlags networkObjectHeaderPlayerDataFlags = PlayerFlags__BackingField | flags;
		PlayerFlags__BackingField = networkObjectHeaderPlayerDataFlags;
		ChangeTick changeTick = ChangeTick.FromSimulationTick(simulation._tick);
		PlayerFlagsChangeTick__BackingField = changeTick;
		TickMin = simulation._tick;
	}

	public void ClearPlayerFlag(NetworkObjectHeaderPlayerDataFlags flags, Simulation simulation)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		object obj = ~flags;
		NetworkObjectHeaderPlayerDataFlags networkObjectHeaderPlayerDataFlags = (NetworkObjectHeaderPlayerDataFlags)(PlayerFlags__BackingField & obj);
		PlayerFlags__BackingField = networkObjectHeaderPlayerDataFlags;
		ChangeTick changeTick = ChangeTick.FromSimulationTick(simulation._tick);
		PlayerFlagsChangeTick__BackingField = changeTick;
		TickMin = simulation._tick;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void SetStatus(SimulationConnection sc, NetworkObjectConnectionDataStatus status, string caller = null)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got VT
		//IL_0101: Expected Obj, but got VT
		//IL_0117: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_0237: Expected Obj, but got I8
		//IL_01d3: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_07b0: Expected Obj, but got I
		//IL_07b8: Expected I, but got Obj
		//IL_07e9: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_034b: Expected Obj, but got Ref
		//IL_03ed: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_02d6: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_0381: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I
		//IL_06db: Expected Obj, but got I
		//IL_0705: Expected Obj, but got I4
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got I
		//IL_0486: Expected Obj, but got Ref
		//IL_0500: Expected Obj, but got I8
		//IL_049c: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0563: Expected Obj, but got Ref
		//IL_05e5: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I4
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0579: Expected I, but got Obj
		//IL_0589: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_066e: Expected Obj, but got I
		if (Status__BackingField == status)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+A8]");
		object[] array = default;
		SimulationConnection simulationConnection3;
		string text;
		object obj16;
		string format;
		object obj18;
		NullReferenceException ex = default;
		NetworkObjectConnectionDataStatus networkObjectConnectionDataStatus;
		SimulationConnection simulationConnection;
		if ((nint)0 != 0)
		{
			bool flag = sc == null;
			networkObjectConnectionDataStatus = status;
			simulationConnection = sc;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				simulationConnection = (SimulationConnection)Id;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30D749C");
				bool flag2 = array == null;
				networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
				if (!flag2)
				{
					SimulationConnection simulationConnection2 = default;
					bool flag3 = simulationConnection2 == null;
					simulationConnection3 = (SimulationConnection)Id;
					if (!flag3)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
						simulationConnection3 = (SimulationConnection)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
						simulationConnection = (SimulationConnection)0;
						if (flag4)
						{
							goto IL_075d;
						}
					}
					if (array.Length != 0)
					{
						object obj6 = array + 32;
						obj6 = simulationConnection2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag5 = caller == null;
						simulationConnection3 = simulationConnection2;
						if (!flag5)
						{
							nint num2 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
							simulationConnection3 = (SimulationConnection)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
							simulationConnection = (SimulationConnection)0;
							if (flag6)
							{
								goto IL_075d;
							}
						}
						object obj7 = array.Length & 0xFFFFFFFEL;
						if (obj7 != null)
						{
							object obj8 = array + 40;
							obj8 = caller;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Simulation simulation = sc.Simulation;
							bool flag7 = (object)sc.Simulation == null;
							networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
							simulationConnection = (SimulationConnection)(object)caller;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
								object obj9 = 0;
								nint num3 = (nint)simulation;
								object obj10 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X9_v6 (Il2CppClass<Fusion.Simulation>)+130]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v24+130]");
								bool flag8 = num4 < 0;
								object obj11 = !flag8;
								object obj12 = ~obj11;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X9_v6 (Il2CppClass<Fusion.Simulation>)+B0]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v24+130]");
									object obj13 = num5 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X9_v14-8]");
									if (0 == (nint)obj10)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7238]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										object obj15 = 0;
										text = (string)obj14;
										obj16 = obj15;
										bool flag9 = obj15 == null;
										object obj17 = !flag9;
										if (obj17 != null)
										{
											goto IL_0369;
										}
										simulationConnection3 = (SimulationConnection)(object)caller;
										format = (string)obj14;
										obj18 = obj15;
										goto IL_03d1;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7238]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
								object obj20 = 0;
								text = (string)obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj21 = default;
								bool flag10 = obj21 == null;
								obj16 = obj21;
								object obj22 = default;
								simulationConnection3 = (SimulationConnection)(&obj22);
								format = (string)obj19;
								obj18 = obj21;
								if (!flag10)
								{
									goto IL_0369;
								}
								goto IL_03d1;
							}
							goto IL_074f;
						}
					}
					goto IL_0730;
				}
			}
			goto IL_074f;
		}
		goto IL_0791;
		IL_074f:
		ex = new NullReferenceException();
		goto IL_075d;
		IL_075d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0791:
		Status__BackingField = status;
		return;
		IL_0369:
		nint num6 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
		simulationConnection3 = (SimulationConnection)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		bool flag11 = ex == null;
		format = text;
		obj18 = obj16;
		networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
		simulationConnection = (SimulationConnection)0;
		if (!flag11)
		{
			goto IL_03d1;
		}
		goto IL_075d;
		IL_0730:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
		simulationConnection = simulationConnection3;
		goto IL_074f;
		IL_03d1:
		bool flag12 = array.Length < 2;
		object obj23 = !flag12;
		object obj24 = array.Length - 2;
		bool flag13 = obj24 == null;
		object obj25 = ~obj23;
		object obj26 = obj25 | flag13;
		if (obj26 == null)
		{
			object obj27 = array + 48;
			obj27 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7230]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj29 = default;
			bool flag14 = obj29 == null;
			object obj30 = default;
			simulationConnection3 = (SimulationConnection)(&obj30);
			if (!flag14)
			{
				nint num7 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				simulationConnection3 = (SimulationConnection)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag15 = ex == null;
				networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				simulationConnection = (SimulationConnection)0;
				if (flag15)
				{
					goto IL_075d;
				}
			}
			object obj31 = array.Length & 0xFFFFFFFCL;
			if (obj31 != null)
			{
				object obj32 = array + 56;
				obj32 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj33 = default;
				bool flag16 = obj33 == null;
				object obj34 = default;
				simulationConnection3 = (SimulationConnection)(&obj34);
				if (!flag16)
				{
					nint num8 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
					simulationConnection3 = (SimulationConnection)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag17 = ex == null;
					networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
					simulationConnection = (SimulationConnection)0;
					if (flag17)
					{
						goto IL_075d;
					}
				}
				bool flag18 = array.Length < 4;
				object obj35 = !flag18;
				object obj36 = array.Length - 4;
				bool flag19 = obj36 == null;
				object obj37 = ~obj35;
				object obj38 = obj37 | flag19;
				if (obj38 == null)
				{
					object obj39 = array + 64;
					obj39 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text2 = string.Format(format, array);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v3+10]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v3+10]");
					bool flag20 = (nint)0 == 0;
					networkObjectConnectionDataStatus = (NetworkObjectConnectionDataStatus)0;
					simulationConnection = (SimulationConnection)(object)array;
					if (flag20)
					{
						goto IL_074f;
					}
					object obj41 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X9_v8+188] (should have been resolved before IL gen)");
					goto IL_0791;
				}
			}
		}
		goto IL_0730;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void SetTickAck(SimulationConnection sc, Tick tick, string caller = null)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got VT
		//IL_00da: Expected VT, but got I4
		//IL_0101: Expected Obj, but got VT
		//IL_0742: Expected VT, but got I4
		//IL_0117: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0149: Expected VT, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_0237: Expected Obj, but got I8
		//IL_01d3: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0205: Expected VT, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_029e: Expected VT, but got I4
		//IL_07b0: Expected Obj, but got I
		//IL_07b8: Expected I, but got Obj
		//IL_07e9: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_034b: Expected Obj, but got Ref
		//IL_03ed: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_02d6: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_0381: Expected Obj, but got I
		//IL_03b3: Expected VT, but got I4
		//IL_03c3: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I
		//IL_06db: Expected Obj, but got I
		//IL_0705: Expected Obj, but got I4
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got I
		//IL_0486: Expected Obj, but got Ref
		//IL_0500: Expected Obj, but got I8
		//IL_049c: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I
		//IL_04ce: Expected VT, but got I4
		//IL_04de: Expected Obj, but got I
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0563: Expected Obj, but got Ref
		//IL_05e5: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I4
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0579: Expected I, but got Obj
		//IL_0589: Expected Obj, but got I
		//IL_05ab: Expected VT, but got I4
		//IL_05bb: Expected Obj, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_066e: Expected Obj, but got I
		//IL_068e: Expected VT, but got I4
		if (_tickAcknowledged == tick)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+A8]");
		object[] array = default;
		SimulationConnection simulationConnection3;
		string text;
		object obj16;
		string format;
		object obj18;
		NullReferenceException ex = default;
		Tick tick2;
		SimulationConnection simulationConnection;
		if ((nint)0 != 0)
		{
			bool flag = sc == null;
			tick2 = tick;
			simulationConnection = sc;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				simulationConnection = (SimulationConnection)Id;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30D749C");
				bool flag2 = array == null;
				tick2 = (Tick)0;
				if (!flag2)
				{
					SimulationConnection simulationConnection2 = default;
					bool flag3 = simulationConnection2 == null;
					simulationConnection3 = (SimulationConnection)Id;
					if (!flag3)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
						simulationConnection3 = (SimulationConnection)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						tick2 = (Tick)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
						simulationConnection = (SimulationConnection)0;
						if (flag4)
						{
							goto IL_075d;
						}
					}
					if (array.Length != 0)
					{
						object obj6 = array + 32;
						obj6 = simulationConnection2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag5 = caller == null;
						simulationConnection3 = simulationConnection2;
						if (!flag5)
						{
							nint num2 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
							simulationConnection3 = (SimulationConnection)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							tick2 = (Tick)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
							simulationConnection = (SimulationConnection)0;
							if (flag6)
							{
								goto IL_075d;
							}
						}
						object obj7 = array.Length & 0xFFFFFFFEL;
						if (obj7 != null)
						{
							object obj8 = array + 40;
							obj8 = caller;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Simulation simulation = sc.Simulation;
							bool flag7 = (object)sc.Simulation == null;
							tick2 = (Tick)0;
							simulationConnection = (SimulationConnection)(object)caller;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
								object obj9 = 0;
								nint num3 = (nint)simulation;
								object obj10 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X9_v6 (Il2CppClass<Fusion.Simulation>)+130]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v24+130]");
								bool flag8 = num4 < 0;
								object obj11 = !flag8;
								object obj12 = ~obj11;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X9_v6 (Il2CppClass<Fusion.Simulation>)+B0]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v24+130]");
									object obj13 = num5 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X9_v14-8]");
									if (0 == (nint)obj10)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7248]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										object obj15 = 0;
										text = (string)obj14;
										obj16 = obj15;
										bool flag9 = obj15 == null;
										object obj17 = !flag9;
										if (obj17 != null)
										{
											goto IL_0369;
										}
										simulationConnection3 = (SimulationConnection)(object)caller;
										format = (string)obj14;
										obj18 = obj15;
										goto IL_03d1;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7248]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
								object obj20 = 0;
								text = (string)obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj21 = default;
								bool flag10 = obj21 == null;
								obj16 = obj21;
								object obj22 = default;
								simulationConnection3 = (SimulationConnection)(&obj22);
								format = (string)obj19;
								obj18 = obj21;
								if (!flag10)
								{
									goto IL_0369;
								}
								goto IL_03d1;
							}
							goto IL_074f;
						}
					}
					goto IL_0730;
				}
			}
			goto IL_074f;
		}
		goto IL_0791;
		IL_074f:
		ex = new NullReferenceException();
		goto IL_075d;
		IL_075d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0791:
		_tickAcknowledged = tick;
		return;
		IL_0369:
		nint num6 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
		simulationConnection3 = (SimulationConnection)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		bool flag11 = ex == null;
		format = text;
		obj18 = obj16;
		tick2 = (Tick)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
		simulationConnection = (SimulationConnection)0;
		if (!flag11)
		{
			goto IL_03d1;
		}
		goto IL_075d;
		IL_0730:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		tick2 = (Tick)0;
		simulationConnection = simulationConnection3;
		goto IL_074f;
		IL_03d1:
		bool flag12 = array.Length < 2;
		object obj23 = !flag12;
		object obj24 = array.Length - 2;
		bool flag13 = obj24 == null;
		object obj25 = ~obj23;
		object obj26 = obj25 | flag13;
		if (obj26 == null)
		{
			object obj27 = array + 48;
			obj27 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj29 = default;
			bool flag14 = obj29 == null;
			object obj30 = default;
			simulationConnection3 = (SimulationConnection)(&obj30);
			if (!flag14)
			{
				nint num7 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				simulationConnection3 = (SimulationConnection)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag15 = ex == null;
				tick2 = (Tick)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				simulationConnection = (SimulationConnection)0;
				if (flag15)
				{
					goto IL_075d;
				}
			}
			object obj31 = array.Length & 0xFFFFFFFCL;
			if (obj31 != null)
			{
				object obj32 = array + 56;
				obj32 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj33 = default;
				bool flag16 = obj33 == null;
				object obj34 = default;
				simulationConnection3 = (SimulationConnection)(&obj34);
				if (!flag16)
				{
					nint num8 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
					simulationConnection3 = (SimulationConnection)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag17 = ex == null;
					tick2 = (Tick)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
					simulationConnection = (SimulationConnection)0;
					if (flag17)
					{
						goto IL_075d;
					}
				}
				bool flag18 = array.Length < 4;
				object obj35 = !flag18;
				object obj36 = array.Length - 4;
				bool flag19 = obj36 == null;
				object obj37 = ~obj35;
				object obj38 = obj37 | flag19;
				if (obj38 == null)
				{
					object obj39 = array + 64;
					obj39 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text2 = string.Format(format, array);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v3+10]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v3+10]");
					bool flag20 = (nint)0 == 0;
					tick2 = (Tick)0;
					simulationConnection = (SimulationConnection)(object)array;
					if (flag20)
					{
						goto IL_074f;
					}
					object obj41 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X9_v8+188] (should have been resolved before IL gen)");
					goto IL_0791;
				}
			}
		}
		goto IL_0730;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void SetTickSent(SimulationConnection sc, Tick tick, string extraLogMessagePleaseDoNotAlloc = null, string caller = null)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got VT
		//IL_00da: Expected VT, but got I4
		//IL_0101: Expected Obj, but got VT
		//IL_083e: Expected VT, but got I4
		//IL_0117: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0149: Expected VT, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_0237: Expected Obj, but got I8
		//IL_01d3: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0205: Expected VT, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I4
		//IL_031d: Expected Obj, but got I4
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_02a1: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_02d3: Expected VT, but got I4
		//IL_02e3: Expected Obj, but got I
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_039a: Expected VT, but got I4
		//IL_08ac: Expected Obj, but got I
		//IL_08b4: Expected I, but got Obj
		//IL_08e5: Expected Obj, but got I4
		//IL_0406: Expected Obj, but got I
		//IL_0416: Expected Obj, but got I
		//IL_0447: Expected Obj, but got Ref
		//IL_04e1: Expected Obj, but got I8
		//IL_03d2: Expected Obj, but got I
		//IL_046d: Expected I, but got Obj
		//IL_047d: Expected Obj, but got I
		//IL_04af: Expected VT, but got I4
		//IL_04bf: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I
		//IL_07d7: Expected Obj, but got I
		//IL_0801: Expected Obj, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_052e: Expected Obj, but got I
		//IL_0554: Expected Obj, but got Ref
		//IL_05d6: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I4
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_056a: Expected I, but got Obj
		//IL_057a: Expected Obj, but got I
		//IL_059c: Expected VT, but got I4
		//IL_05ac: Expected Obj, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_065f: Expected Obj, but got Ref
		//IL_06e1: Expected Obj, but got I4
		//IL_06f1: Expected Obj, but got I4
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_0675: Expected I, but got Obj
		//IL_0685: Expected Obj, but got I
		//IL_06a7: Expected VT, but got I4
		//IL_06b7: Expected Obj, but got I
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_076a: Expected Obj, but got I
		//IL_078a: Expected VT, but got I4
		if (_tickSent == tick)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+A8]");
		object[] array = default;
		SimulationConnection simulationConnection3;
		string text;
		object obj21;
		string format;
		object obj23;
		Tick tick2;
		SimulationConnection simulationConnection;
		NullReferenceException ex = default;
		if ((nint)0 != 0)
		{
			bool flag = sc == null;
			tick2 = tick;
			simulationConnection = sc;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				simulationConnection = (SimulationConnection)Id;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30D749C");
				bool flag2 = array == null;
				tick2 = (Tick)0;
				if (!flag2)
				{
					SimulationConnection simulationConnection2 = default;
					bool flag3 = simulationConnection2 == null;
					simulationConnection3 = (SimulationConnection)Id;
					if (!flag3)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v46 (Il2CppClass<System.Object[]>)+40]");
						simulationConnection3 = (SimulationConnection)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						tick2 = (Tick)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v46 (Il2CppClass<System.Object[]>)+40]");
						simulationConnection = (SimulationConnection)0;
						if (flag4)
						{
							goto IL_0859;
						}
					}
					if (array.Length != 0)
					{
						object obj6 = array + 32;
						obj6 = simulationConnection2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag5 = caller == null;
						simulationConnection3 = simulationConnection2;
						if (!flag5)
						{
							nint num2 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
							simulationConnection3 = (SimulationConnection)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							tick2 = (Tick)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
							simulationConnection = (SimulationConnection)0;
							if (flag6)
							{
								goto IL_0859;
							}
						}
						object obj7 = array.Length & 0xFFFFFFFEL;
						if (obj7 != null)
						{
							object obj8 = array + 40;
							obj8 = caller;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag7 = extraLogMessagePleaseDoNotAlloc == null;
							simulationConnection3 = (SimulationConnection)(object)caller;
							if (!flag7)
							{
								nint num3 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
								simulationConnection3 = (SimulationConnection)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag8 = ex == null;
								tick2 = (Tick)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
								simulationConnection = (SimulationConnection)0;
								if (flag8)
								{
									goto IL_0859;
								}
							}
							bool flag9 = array.Length < 2;
							object obj9 = !flag9;
							object obj10 = array.Length - 2;
							bool flag10 = obj10 == null;
							object obj11 = ~obj9;
							object obj12 = obj11 | flag10;
							if (obj12 == null)
							{
								object obj13 = array + 48;
								obj13 = extraLogMessagePleaseDoNotAlloc;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Simulation simulation = sc.Simulation;
								bool flag11 = (object)sc.Simulation == null;
								tick2 = (Tick)0;
								simulationConnection = (SimulationConnection)(object)extraLogMessagePleaseDoNotAlloc;
								if (!flag11)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
									object obj14 = 0;
									nint num4 = (nint)simulation;
									object obj15 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v6 (Il2CppClass<Fusion.Simulation>)+130]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v26+130]");
									bool flag12 = num5 < 0;
									object obj16 = !flag12;
									object obj17 = ~obj16;
									if (obj17 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v6 (Il2CppClass<Fusion.Simulation>)+B0]");
										nint num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v26+130]");
										object obj18 = num6 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X9_v14-8]");
										if (0 == (nint)obj15)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7250]");
											object obj19 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
											object obj20 = 0;
											text = (string)obj19;
											obj21 = obj20;
											bool flag13 = obj20 == null;
											object obj22 = !flag13;
											if (obj22 != null)
											{
												goto IL_0465;
											}
											simulationConnection3 = (SimulationConnection)(object)extraLogMessagePleaseDoNotAlloc;
											format = (string)obj19;
											obj23 = obj20;
											goto IL_04cd;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7250]");
									object obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
									object obj25 = 0;
									text = (string)obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj26 = default;
									bool flag14 = obj26 == null;
									obj21 = obj26;
									object obj27 = default;
									simulationConnection3 = (SimulationConnection)(&obj27);
									format = (string)obj24;
									obj23 = obj26;
									if (!flag14)
									{
										goto IL_0465;
									}
									goto IL_04cd;
								}
								goto IL_084b;
							}
						}
					}
					goto IL_082c;
				}
			}
			goto IL_084b;
		}
		goto IL_088d;
		IL_0465:
		nint num7 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
		simulationConnection3 = (SimulationConnection)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		bool flag15 = ex == null;
		format = text;
		obj23 = obj21;
		tick2 = (Tick)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
		simulationConnection = (SimulationConnection)0;
		if (!flag15)
		{
			goto IL_04cd;
		}
		goto IL_0859;
		IL_082c:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		tick2 = (Tick)0;
		simulationConnection = simulationConnection3;
		goto IL_084b;
		IL_04cd:
		object obj28 = array.Length & 0xFFFFFFFCL;
		if (obj28 != null)
		{
			object obj29 = array + 56;
			obj29 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj31 = default;
			bool flag16 = obj31 == null;
			object obj32 = default;
			simulationConnection3 = (SimulationConnection)(&obj32);
			if (!flag16)
			{
				nint num8 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
				simulationConnection3 = (SimulationConnection)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag17 = ex == null;
				tick2 = (Tick)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
				simulationConnection = (SimulationConnection)0;
				if (flag17)
				{
					goto IL_0859;
				}
			}
			bool flag18 = array.Length < 4;
			object obj33 = !flag18;
			object obj34 = array.Length - 4;
			bool flag19 = obj34 == null;
			object obj35 = ~obj33;
			object obj36 = obj35 | flag19;
			if (obj36 == null)
			{
				object obj37 = array + 64;
				obj37 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj38 = default;
				bool flag20 = obj38 == null;
				object obj39 = default;
				simulationConnection3 = (SimulationConnection)(&obj39);
				if (!flag20)
				{
					nint num9 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
					simulationConnection3 = (SimulationConnection)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag21 = ex == null;
					tick2 = (Tick)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
					simulationConnection = (SimulationConnection)0;
					if (flag21)
					{
						goto IL_0859;
					}
				}
				bool flag22 = array.Length < 5;
				object obj40 = !flag22;
				object obj41 = array.Length - 5;
				bool flag23 = obj41 == null;
				object obj42 = ~obj40;
				object obj43 = obj42 | flag23;
				if (obj43 == null)
				{
					object obj44 = array + 72;
					obj44 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text2 = string.Format(format, array);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X27_v3+10]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X27_v3+10]");
					bool flag24 = (nint)0 == 0;
					tick2 = (Tick)0;
					simulationConnection = (SimulationConnection)(object)array;
					if (flag24)
					{
						goto IL_084b;
					}
					object obj46 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ X9_v8+188] (should have been resolved before IL gen)");
					goto IL_088d;
				}
			}
		}
		goto IL_082c;
		IL_084b:
		ex = new NullReferenceException();
		goto IL_0859;
		IL_088d:
		_tickSent = tick;
		return;
		IL_0859:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	public NetworkObjectConnectionData()
	{
		//IL_0016: Expected I8, but got I4
	}
}
