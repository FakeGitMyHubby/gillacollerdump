using System;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Fusion.Sockets.Stun;
using Fusion.Sockets.V2;

namespace Photon.Client;

public class TrafficStatsDelta : TrafficStatsBase
{
	private long RoundtripTime__BackingField;

	private long RoundtripTimeVariance__BackingField;

	private long LastRoundtripTime__BackingField;

	public long DeltaTime;

	private long ReferenceRoundtripTime__BackingField;

	private long ReferenceRoundtripTimeVariance__BackingField;

	private long LaterRoundtripTime__BackingField;

	private long LaterRoundtripTimeVariance__BackingField;

	public override long RoundtripTime
	{
		get
		{
			return RoundtripTime__BackingField;
		}
		internal set
		{
			RoundtripTime__BackingField = value;
		}
	}

	public override long RoundtripTimeVariance
	{
		get
		{
			return RoundtripTimeVariance__BackingField;
		}
		internal set
		{
			RoundtripTimeVariance__BackingField = value;
		}
	}

	public override long LastRoundtripTime
	{
		get
		{
			return LastRoundtripTime__BackingField;
		}
		internal set
		{
			LastRoundtripTime__BackingField = value;
		}
	}

	public long ReferenceRoundtripTime
	{
		get
		{
			return ReferenceRoundtripTime__BackingField;
		}
		set
		{
			ReferenceRoundtripTime__BackingField = value;
		}
	}

	public long ReferenceRoundtripTimeVariance
	{
		get
		{
			return ReferenceRoundtripTimeVariance__BackingField;
		}
		set
		{
			ReferenceRoundtripTimeVariance__BackingField = value;
		}
	}

	public long LaterRoundtripTime
	{
		get
		{
			return LaterRoundtripTime__BackingField;
		}
		set
		{
			LaterRoundtripTime__BackingField = value;
		}
	}

	public long LaterRoundtripTimeVariance
	{
		get
		{
			return LaterRoundtripTimeVariance__BackingField;
		}
		set
		{
			LaterRoundtripTimeVariance__BackingField = value;
		}
	}

	internal unsafe TrafficStatsDelta(TrafficStatsBase reference, TrafficStatsBase now)
	{
		//IL_00a6: Expected I8, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_00bf: Expected I8, but got I4
		//IL_00d6: Expected I8, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00ef: Expected I8, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_0159: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I4
		int num = now.PackagesIn__BackingField - reference.PackagesIn__BackingField;
		base.PackagesIn__BackingField = num;
		int num2 = now.UdpUnreliableCommandsSent__BackingField - reference.UdpUnreliableCommandsSent__BackingField;
		base.UdpUnreliableCommandsSent__BackingField = num2;
		long num3 = now.BytesIn__BackingField - reference.BytesIn__BackingField;
		int num4 = now.DispatchIncomingCommandsCalls__BackingField - reference.DispatchIncomingCommandsCalls__BackingField;
		base.BytesIn__BackingField = num3;
		base.DispatchIncomingCommandsCalls__BackingField = num4;
		bool isEmpty = ((Fusion.Sockets.Stun.StunClient.List.List*)reference)->IsEmpty;
		ReferenceRoundtripTime__BackingField = (isEmpty ? 1 : 0);
		bool flag = reference.Equals(0);
		ReferenceRoundtripTimeVariance__BackingField = (flag ? 1 : 0);
		bool isEmpty2 = ((Fusion.Sockets.Stun.StunClient.List.List*)now)->IsEmpty;
		LaterRoundtripTime__BackingField = (isEmpty2 ? 1 : 0);
		bool flag2 = now.Equals(0);
		LaterRoundtripTimeVariance__BackingField = (flag2 ? 1 : 0);
		bool isEmpty3 = ((Fusion.Sockets.Stun.StunClient.List.List*)now)->IsEmpty;
		bool isEmpty4 = ((Fusion.Sockets.Stun.StunClient.List.List*)reference)->IsEmpty;
		base.Finalize();
		bool flag3 = now.Equals(0);
		bool flag4 = reference.Equals(0);
		string text = ((Fusion.Sockets.V2.PacketGroup.StateType*)this)->ToString();
		int hashCode = now.GetHashCode();
		int hashCode2 = reference.GetHashCode();
		nint num5 = (nint)this;
		object obj = hashCode - hashCode2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v111 @ X8_v13 (Il2CppClass<Photon.Client.TrafficStatsDelta>)+1C8] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public TrafficStatsDelta(TrafficStatsSnapshot reference, TrafficStatsSnapshot now)
		: this((TrafficStatsBase)reference, (TrafficStatsBase)now)
	{
		long deltaTime = now.SnapshotTimestamp - reference.SnapshotTimestamp;
		DeltaTime = deltaTime;
	}

	public TrafficStatsDelta(TrafficStatsSnapshot reference, TrafficStats now)
		: this((TrafficStatsBase)reference, (TrafficStatsBase)now)
	{
		long elapsedMilliseconds = now.connectionStopwatch.ElapsedMilliseconds;
		long deltaTime = elapsedMilliseconds - reference.SnapshotTimestamp;
		DeltaTime = deltaTime;
	}

	public override string ToString()
	{
		return ToString(udpValues: true, rttValues: true, callValues: true);
	}

	public unsafe string ToString(bool udpValues = default(bool), bool rttValues = default(bool), bool callValues = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0f9b: Expected Obj, but got I
		//IL_0036: Expected I8, but got I4
		//IL_0fe7: Expected Obj, but got I
		//IL_0052: Expected Obj, but got Ref
		//IL_0068: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got Ref
		//IL_019d: Expected Obj, but got I8
		//IL_013a: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got Ref
		//IL_0289: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_021e: Expected I, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_031a: Expected Obj, but got Ref
		//IL_0393: Expected Obj, but got I8
		//IL_0330: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got Ref
		//IL_047f: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I4
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_0414: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_0510: Expected Obj, but got Ref
		//IL_0591: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_0526: Expected I, but got Obj
		//IL_0536: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_0622: Expected Obj, but got Ref
		//IL_06a3: Expected Obj, but got I4
		//IL_06b3: Expected Obj, but got I4
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_0638: Expected I, but got Obj
		//IL_0648: Expected Obj, but got I
		//IL_0679: Expected Obj, but got I
		//IL_06fe: Expected Obj, but got I
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected Obj, but got Unknown
		//IL_0963: Expected I, but got Obj
		//IL_07ea: Expected I4, but got I8
		//IL_08a7: Expected I8, but got I4
		//IL_08cf: Expected Obj, but got I
		//IL_082b: Expected Obj, but got I
		//IL_0f0b: Expected Obj, but got I
		//IL_09ce: Expected Obj, but got Ref
		//IL_0de3: Expected Obj, but got I
		//IL_0909: Expected I8, but got I4
		//IL_0862: Expected I4, but got Obj
		//IL_0875: Expected I8, but got I4
		//IL_087f: Expected I8, but got I4
		//IL_0e28: Expected Obj, but got I4
		//IL_0e44: Expected I8, but got I4
		//IL_0e4e: Expected I8, but got I4
		//IL_0e53: Expected I, but got Obj
		//IL_0e6f: Expected I8, but got I4
		//IL_0e79: Expected I8, but got I4
		//IL_09e4: Expected I, but got Obj
		//IL_09f4: Expected Obj, but got I
		//IL_0a25: Expected Obj, but got I
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected Obj, but got Unknown
		//IL_0aa0: Expected Obj, but got Ref
		//IL_0b19: Expected Obj, but got I8
		//IL_0ab6: Expected I, but got Obj
		//IL_0ac6: Expected Obj, but got I
		//IL_0af7: Expected Obj, but got I
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b84: Expected Obj, but got Ref
		//IL_0c05: Expected Obj, but got I4
		//IL_0c15: Expected Obj, but got I4
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected Obj, but got Unknown
		//IL_0b9a: Expected I, but got Obj
		//IL_0baa: Expected Obj, but got I
		//IL_0bdb: Expected Obj, but got I
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected Obj, but got Unknown
		//IL_0c96: Expected Obj, but got Ref
		//IL_0d0f: Expected Obj, but got I8
		//IL_0cac: Expected I, but got Obj
		//IL_0cbc: Expected Obj, but got I
		//IL_0ced: Expected Obj, but got I
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected Obj, but got Unknown
		//IL_0d64: Expected Obj, but got I
		//IL_0d90: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		long num = ((DeltaTime < 1) ? 0 : (base.BytesOut__BackingField / DeltaTime));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object[] array = default;
		object obj5;
		long num3 = default;
		long num5 = default;
		long num7 = default;
		long num9 = default;
		bool flag3;
		bool flag28;
		IndexOutOfRangeException ex = default;
		object obj7;
		if (array != null)
		{
			object obj4 = default;
			bool flag = obj4 == null;
			object obj6 = default;
			obj5 = (object)(&obj6);
			if (!flag)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v78 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex == null;
				flag3 = callValues;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v78 (Il2CppClass<System.Object[]>)+40]");
				obj7 = 0;
				if (flag2)
				{
					goto IL_0f65;
				}
			}
			bool flag4 = array.Length == 0;
			flag3 = callValues;
			if (!flag4)
			{
				object obj8 = array + 32;
				obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj9 = default;
				bool flag5 = obj9 == null;
				obj5 = (object)(&num3);
				if (!flag5)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v77 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag6 = ex == null;
					flag3 = callValues;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v77 (Il2CppClass<System.Object[]>)+40]");
					obj7 = 0;
					if (flag6)
					{
						goto IL_0f65;
					}
				}
				object obj10 = array.Length & 0xFFFFFFFEL;
				bool flag7 = obj10 == null;
				flag3 = callValues;
				if (!flag7)
				{
					object obj11 = array + 40;
					obj11 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj12 = default;
					bool flag8 = obj12 == null;
					obj5 = (object)(&num5);
					if (!flag8)
					{
						nint num6 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v76 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag9 = ex == null;
						flag3 = callValues;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v76 (Il2CppClass<System.Object[]>)+40]");
						obj7 = 0;
						if (flag9)
						{
							goto IL_0f65;
						}
					}
					bool flag10 = array.Length < 2;
					object obj13 = !flag10;
					object obj14 = array.Length - 2;
					bool flag11 = obj14 == null;
					object obj15 = ~obj13;
					object obj16 = obj15 | flag11;
					flag3 = callValues;
					if (obj16 == null)
					{
						object obj17 = array + 48;
						obj17 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj18 = default;
						bool flag12 = obj18 == null;
						obj5 = (object)(&num7);
						if (!flag12)
						{
							nint num8 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v75 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag13 = ex == null;
							flag3 = callValues;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v75 (Il2CppClass<System.Object[]>)+40]");
							obj7 = 0;
							if (flag13)
							{
								goto IL_0f65;
							}
						}
						object obj19 = array.Length & 0xFFFFFFFCL;
						bool flag14 = obj19 == null;
						flag3 = callValues;
						if (!flag14)
						{
							object obj20 = array + 56;
							obj20 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj21 = default;
							bool flag15 = obj21 == null;
							obj5 = (object)(&num9);
							if (!flag15)
							{
								nint num10 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v74 (Il2CppClass<System.Object[]>)+40]");
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag16 = ex == null;
								flag3 = callValues;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v74 (Il2CppClass<System.Object[]>)+40]");
								obj7 = 0;
								if (flag16)
								{
									goto IL_0f65;
								}
							}
							bool flag17 = array.Length < 4;
							object obj22 = !flag17;
							object obj23 = array.Length - 4;
							bool flag18 = obj23 == null;
							object obj24 = ~obj22;
							object obj25 = obj24 | flag18;
							flag3 = callValues;
							if (obj25 == null)
							{
								object obj26 = array + 64;
								obj26 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj27 = default;
								bool flag19 = obj27 == null;
								object obj28 = default;
								obj5 = (object)(&obj28);
								if (!flag19)
								{
									nint num11 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
									obj5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag20 = ex == null;
									flag3 = callValues;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
									obj7 = 0;
									if (flag20)
									{
										goto IL_0f65;
									}
								}
								bool flag21 = array.Length < 5;
								object obj29 = !flag21;
								object obj30 = array.Length - 5;
								bool flag22 = obj30 == null;
								object obj31 = ~obj29;
								object obj32 = obj31 | flag22;
								flag3 = callValues;
								if (obj32 == null)
								{
									object obj33 = array + 72;
									obj33 = obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj34 = default;
									bool flag23 = obj34 == null;
									object obj35 = default;
									obj5 = (object)(&obj35);
									if (!flag23)
									{
										nint num12 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
										obj5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag24 = ex == null;
										flag3 = callValues;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
										obj7 = 0;
										if (flag24)
										{
											goto IL_0f65;
										}
									}
									bool flag25 = array.Length < 6;
									object obj36 = !flag25;
									object obj37 = array.Length - 6;
									bool flag26 = obj37 == null;
									object obj38 = ~obj36;
									object obj39 = obj38 | flag26;
									flag3 = callValues;
									if (obj39 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517168]");
										object format = 0;
										object obj40 = array + 80;
										obj40 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string value = string.Format((string)format, array);
										if (stringBuilder != null)
										{
											StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
											bool flag27 = !udpValues;
											flag3 = callValues;
											flag28 = false;
											num7 = base.BytesIn__BackingField;
											num5 = num;
											num3 = base.BytesOut__BackingField;
											bool flag32 = default;
											nint num14;
											bool flag33;
											bool flag34;
											if (!flag27)
											{
												bool flag29 = base.UdpReliableCommandsSent__BackingField < 1;
												flag3 = callValues;
												flag28 = false;
												num7 = base.BytesIn__BackingField;
												num5 = num;
												int num13 = (int)base.BytesOut__BackingField;
												if (!flag29)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517160]");
													object format2 = 0;
													object arg = default;
													object arg2 = default;
													object obj41 = default;
													string value2 = string.Format((string)format2, arg, arg2, obj41);
													StringBuilder stringBuilder3 = stringBuilder.AppendLine(value2);
													flag3 = (byte)(int)obj41 != 0;
													flag28 = false;
													num7 = base.UdpReliableCommandsInFlight__BackingField;
													num5 = base.UdpReliableCommandsResent__BackingField;
													num13 = base.UdpReliableCommandsSent__BackingField;
												}
												bool flag30 = base.UdpUnreliableCommandsSent__BackingField < 1;
												num3 = num13;
												if (!flag30)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517158]");
													object format3 = 0;
													object arg3 = default;
													string value3 = string.Format((string)format3, arg3);
													StringBuilder stringBuilder4 = stringBuilder.AppendLine(value3);
													flag28 = false;
													num3 = base.UdpUnreliableCommandsSent__BackingField;
												}
												if (base.UdpFragmentsIn__BackingField > 0 || base.UdpFragmentsOut__BackingField >= 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517178]");
													object format4 = 0;
													object arg4 = default;
													object arg5 = default;
													string value4 = string.Format((string)format4, arg4, arg5);
													StringBuilder stringBuilder5 = stringBuilder.AppendLine(value4);
													bool flag31 = !flag32;
													object obj42 = !flag31;
													flag3 = false;
													flag28 = false;
													num5 = base.UdpFragmentsIn__BackingField;
													num3 = base.UdpFragmentsOut__BackingField;
													num14 = unchecked((nint)null);
													flag33 = false;
													flag34 = false;
													num5 = base.UdpFragmentsIn__BackingField;
													num3 = base.UdpFragmentsOut__BackingField;
													if (obj42 != null)
													{
														goto IL_0981;
													}
													goto IL_0e87;
												}
											}
											bool flag35 = !flag32;
											num14 = unchecked((nint)null);
											flag33 = flag3;
											flag34 = flag28;
											if (!flag35)
											{
												goto IL_0981;
											}
											goto IL_0e87;
										}
										goto IL_0f7d;
									}
								}
							}
						}
					}
				}
			}
			goto IL_0f4f;
		}
		goto IL_0f7d;
		IL_0f65:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_0f7d;
		IL_0e87:
		if (callValues && (base.DispatchIncomingCommandsCalls__BackingField > 0 || base.SendOutgoingCommandsCalls__BackingField >= 1))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517170]");
			object format5 = 0;
			object arg6 = default;
			object arg7 = default;
			string value5 = string.Format((string)format5, arg6, arg7);
			StringBuilder stringBuilder6 = stringBuilder.AppendLine(value5);
			bool flag34 = false;
		}
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		string result = default;
		return result;
		IL_0981:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object[] array2 = default;
		if (array2 != null)
		{
			object obj43 = default;
			bool flag36 = obj43 == null;
			obj5 = (object)(&num3);
			bool flag32;
			if (!flag36)
			{
				nint num15 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag37 = ex == null;
				flag32 = flag28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
				obj7 = 0;
				if (flag37)
				{
					goto IL_0f65;
				}
			}
			bool flag38 = array2.Length == 0;
			flag32 = flag28;
			if (!flag38)
			{
				object obj44 = array2 + 32;
				obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj45 = default;
				bool flag39 = obj45 == null;
				obj5 = (object)(&num5);
				if (!flag39)
				{
					nint num16 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag40 = ex == null;
					flag32 = flag28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
					obj7 = 0;
					if (flag40)
					{
						goto IL_0f65;
					}
				}
				object obj46 = array2.Length & 0xFFFFFFFEL;
				bool flag41 = obj46 == null;
				flag32 = flag28;
				if (!flag41)
				{
					object obj47 = array2 + 40;
					obj47 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj48 = default;
					bool flag42 = obj48 == null;
					obj5 = (object)(&num7);
					if (!flag42)
					{
						nint num17 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag43 = ex == null;
						flag32 = flag28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
						obj7 = 0;
						if (flag43)
						{
							goto IL_0f65;
						}
					}
					bool flag44 = array2.Length < 2;
					object obj49 = !flag44;
					object obj50 = array2.Length - 2;
					bool flag45 = obj50 == null;
					object obj51 = ~obj49;
					object obj52 = obj51 | flag45;
					flag32 = flag28;
					if (obj52 == null)
					{
						object obj53 = array2 + 48;
						obj53 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj54 = default;
						bool flag46 = obj54 == null;
						obj5 = (object)(&num9);
						if (!flag46)
						{
							nint num18 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag47 = ex == null;
							flag32 = flag28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
							obj7 = 0;
							if (flag47)
							{
								goto IL_0f65;
							}
						}
						object obj55 = array2.Length & 0xFFFFFFFCL;
						bool flag48 = obj55 == null;
						flag32 = flag28;
						if (!flag48)
						{
							object obj56 = array2 + 56;
							obj56 = obj54;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517150]");
							object format6 = 0;
							string value6 = string.Format((string)format6, array2);
							StringBuilder stringBuilder7 = stringBuilder.AppendLine(value6);
							nint num14 = unchecked((nint)null);
							bool flag33 = flag3;
							bool flag34 = false;
							num5 = LaterRoundtripTimeVariance__BackingField;
							num3 = ReferenceRoundtripTime__BackingField;
							goto IL_0e87;
						}
					}
				}
			}
			goto IL_0f4f;
		}
		goto IL_0f7d;
		IL_0f7d:
		return (string)(object)new NullReferenceException();
		IL_0f4f:
		ex = new IndexOutOfRangeException();
		obj7 = obj5;
		goto IL_0f65;
	}
}
