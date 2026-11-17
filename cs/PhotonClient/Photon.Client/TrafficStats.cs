using System;
using System.Diagnostics;
using Cpp2ILInjected;

namespace Photon.Client;

public class TrafficStats : TrafficStatsBase
{
	internal readonly Stopwatch connectionStopwatch;

	public int LastSendOutgoingTimestamp;

	public int LastSendAckTimestamp;

	private int LastReceiveTimestamp__BackingField;

	private int LastDispatchTimestamp__BackingField;

	private int LongestDeltaBetweenDispatchCalls__BackingField;

	private int LastDispatchDuration__BackingField;

	private int LongestDeltaBetweenSendOutgoingCalls__BackingField;

	public int LastSendOutgoingDeltaTime
	{
		get
		{
			//IL_0050: Expected I4, but got Obj
			//IL_003d: Expected I4, but got I8
			if (connectionStopwatch != null)
			{
				long elapsedMilliseconds = connectionStopwatch.ElapsedMilliseconds;
				return (int)(elapsedMilliseconds - LastSendOutgoingTimestamp);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastSendAckDeltaTime
	{
		get
		{
			//IL_0050: Expected I4, but got Obj
			//IL_003d: Expected I4, but got I8
			if (connectionStopwatch != null)
			{
				long elapsedMilliseconds = connectionStopwatch.ElapsedMilliseconds;
				return (int)(elapsedMilliseconds - LastSendAckTimestamp);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastReceiveTimestamp
	{
		get
		{
			return LastReceiveTimestamp__BackingField;
		}
		internal set
		{
			LastReceiveTimestamp__BackingField = value;
		}
	}

	public int LastReceiveDeltaTime
	{
		get
		{
			//IL_0050: Expected I4, but got Obj
			//IL_003d: Expected I4, but got I8
			if (connectionStopwatch != null)
			{
				long elapsedMilliseconds = connectionStopwatch.ElapsedMilliseconds;
				return (int)(elapsedMilliseconds - LastReceiveTimestamp__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LastDispatchTimestamp
	{
		get
		{
			return LastDispatchTimestamp__BackingField;
		}
		internal set
		{
			LastDispatchTimestamp__BackingField = value;
		}
	}

	public int LastDispatchDeltaTime
	{
		get
		{
			//IL_0050: Expected I4, but got Obj
			//IL_003d: Expected I4, but got I8
			if (connectionStopwatch != null)
			{
				long elapsedMilliseconds = connectionStopwatch.ElapsedMilliseconds;
				return (int)(elapsedMilliseconds - LastDispatchTimestamp__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int LongestDeltaBetweenDispatchCalls
	{
		get
		{
			return LongestDeltaBetweenDispatchCalls__BackingField;
		}
		internal set
		{
			LongestDeltaBetweenDispatchCalls__BackingField = value;
		}
	}

	public int LastDispatchDuration
	{
		get
		{
			return LastDispatchDuration__BackingField;
		}
		internal set
		{
			LastDispatchDuration__BackingField = value;
		}
	}

	public int LongestDeltaBetweenSendOutgoingCalls
	{
		get
		{
			return LongestDeltaBetweenSendOutgoingCalls__BackingField;
		}
		internal set
		{
			LongestDeltaBetweenSendOutgoingCalls__BackingField = value;
		}
	}

	public TrafficStats(Stopwatch connectionTimeSw)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 96;
		obj = connectionTimeSw;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public TrafficStatsSnapshot ToSnapshot()
	{
		//IL_003f: Expected Obj, but got I
		//IL_002a: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517180]");
		object obj = 0;
		if (connectionStopwatch != null)
		{
			long elapsedMilliseconds = connectionStopwatch.ElapsedMilliseconds;
			long num = elapsedMilliseconds;
		}
		else
		{
			long num = 0L;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TrafficStatsBase trafficStatsBase = default;
		trafficStatsBase._002Ector(this);
		return (TrafficStatsSnapshot)trafficStatsBase;
	}

	public TrafficStatsDelta ToDelta(TrafficStatsSnapshot reference)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TrafficStatsDelta trafficStatsDelta = default;
		trafficStatsDelta._002Ector(reference, this);
		return trafficStatsDelta;
	}

	internal void DispatchIncomingCommandsCalled(int timestamp)
	{
		if (LastDispatchTimestamp__BackingField != 0)
		{
			int num = timestamp - LastDispatchTimestamp__BackingField;
			if (num > LongestDeltaBetweenDispatchCalls__BackingField)
			{
				LongestDeltaBetweenDispatchCalls__BackingField = num;
			}
		}
		LastDispatchTimestamp__BackingField = timestamp;
		int num2 = base.DispatchIncomingCommandsCalls__BackingField + 1;
		base.DispatchIncomingCommandsCalls__BackingField = num2;
	}

	internal void SendOutgoingCommandsCalled(int timestamp)
	{
		if (LastSendOutgoingTimestamp != 0)
		{
			int num = timestamp - LastSendOutgoingTimestamp;
			if (num > LongestDeltaBetweenSendOutgoingCalls__BackingField)
			{
				LongestDeltaBetweenSendOutgoingCalls__BackingField = num;
			}
		}
		LastSendOutgoingTimestamp = timestamp;
		int num2 = base.SendOutgoingCommandsCalls__BackingField + 1;
		base.SendOutgoingCommandsCalls__BackingField = num2;
	}

	public void ResetMaximumCounters()
	{
		LongestDeltaBetweenSendOutgoingCalls__BackingField = 0;
		LastDispatchTimestamp__BackingField = 0;
		LongestDeltaBetweenDispatchCalls__BackingField = 0;
		LastSendOutgoingTimestamp = 0;
	}

	public override string ToString()
	{
		return ToString(extended: true);
	}

	public unsafe string ToString(bool extended)
	{
		//IL_0e37: Expected Obj, but got I
		//IL_0e47: Expected Obj, but got I
		//IL_0071: Expected Obj, but got Ref
		//IL_0087: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_0a58: Expected Obj, but got Ref
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got Ref
		//IL_0a6e: Expected I, but got Obj
		//IL_0a7e: Expected Obj, but got I
		//IL_0aa7: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I8
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected Obj, but got Unknown
		//IL_0149: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_0b1a: Expected Obj, but got Ref
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_0b8b: Expected Obj, but got I8
		//IL_0207: Expected Obj, but got Ref
		//IL_0b30: Expected I, but got Obj
		//IL_0b40: Expected Obj, but got I
		//IL_0b69: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected Obj, but got Unknown
		//IL_021d: Expected I, but got Obj
		//IL_022d: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I
		//IL_0bee: Expected Obj, but got Ref
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_0c67: Expected Obj, but got I4
		//IL_0c77: Expected Obj, but got I4
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected Obj, but got Unknown
		//IL_0309: Expected Obj, but got Ref
		//IL_0c04: Expected I, but got Obj
		//IL_0c14: Expected Obj, but got I
		//IL_0c3d: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I8
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected Obj, but got Unknown
		//IL_031f: Expected I, but got Obj
		//IL_032f: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I
		//IL_0cf0: Expected Obj, but got Ref
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_0d61: Expected Obj, but got I8
		//IL_03dd: Expected Obj, but got Ref
		//IL_0d06: Expected I, but got Obj
		//IL_0d16: Expected Obj, but got I
		//IL_0d3f: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Expected Obj, but got Unknown
		//IL_0dae: Expected Obj, but got I
		//IL_03f3: Expected I, but got Obj
		//IL_0403: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04df: Expected Obj, but got Ref
		//IL_0618: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I4
		//IL_0568: Expected Obj, but got I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_04f5: Expected I, but got Obj
		//IL_0505: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I
		//IL_0655: Expected I, but got Obj
		//IL_065e: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_06a6: Expected Obj, but got I8
		//IL_06ba: Expected I, but got Obj
		//IL_06e0: Expected Obj, but got I
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_071f: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I4
		//IL_0768: Expected Obj, but got I
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		//IL_0792: Expected I, but got Obj
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected Obj, but got Unknown
		//IL_07e7: Expected Obj, but got I
		//IL_0812: Expected Obj, but got I8
		//IL_0826: Expected I, but got Obj
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_087b: Expected Obj, but got I
		//IL_08ae: Expected Obj, but got I4
		//IL_08c4: Expected Obj, but got I
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected Obj, but got Unknown
		//IL_08ee: Expected I, but got Obj
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_0943: Expected Obj, but got I
		//IL_0976: Expected Obj, but got I4
		//IL_098c: Expected Obj, but got I
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_09b6: Expected I, but got Obj
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		object obj4;
		long num = default;
		int num3 = default;
		int num5 = default;
		long num7 = default;
		string format;
		object[] args;
		IndexOutOfRangeException ex = default;
		object obj5;
		if (base.UdpFragmentsIn__BackingField > 0 || base.UdpFragmentsOut__BackingField >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array = default;
			if (array != null)
			{
				object obj3 = default;
				bool flag = obj3 == null;
				obj4 = (object)(&num);
				if (!flag)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					if (flag2)
					{
						goto IL_0e01;
					}
				}
				if (array.Length != 0)
				{
					object obj6 = array + 32;
					obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj7 = default;
					bool flag3 = obj7 == null;
					obj4 = (object)(&num3);
					if (!flag3)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						if (flag4)
						{
							goto IL_0e01;
						}
					}
					object obj8 = array.Length & 0xFFFFFFFEL;
					if (obj8 != null)
					{
						object obj9 = array + 40;
						obj9 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj10 = default;
						bool flag5 = obj10 == null;
						obj4 = (object)(&num5);
						if (!flag5)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							if (flag6)
							{
								goto IL_0e01;
							}
						}
						bool flag7 = array.Length < 2;
						object obj11 = !flag7;
						object obj12 = array.Length - 2;
						bool flag8 = obj12 == null;
						object obj13 = ~obj11;
						object obj14 = obj13 | flag8;
						if (obj14 == null)
						{
							object obj15 = array + 48;
							obj15 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj16 = default;
							bool flag9 = obj16 == null;
							obj4 = (object)(&num7);
							if (!flag9)
							{
								nint num8 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag10 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
								obj5 = 0;
								if (flag10)
								{
									goto IL_0e01;
								}
							}
							object obj17 = array.Length & 0xFFFFFFFCL;
							if (obj17 != null)
							{
								object obj18 = array + 56;
								obj18 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj19 = default;
								bool flag11 = obj19 == null;
								object obj20 = default;
								obj4 = (object)(&obj20);
								if (!flag11)
								{
									nint num9 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag12 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
									obj5 = 0;
									if (flag12)
									{
										goto IL_0e01;
									}
								}
								bool flag13 = array.Length < 4;
								object obj21 = !flag13;
								object obj22 = array.Length - 4;
								bool flag14 = obj22 == null;
								object obj23 = ~obj21;
								object obj24 = obj23 | flag14;
								if (obj24 == null)
								{
									object obj25 = array + 64;
									obj25 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj26 = default;
									bool flag15 = obj26 == null;
									object obj27 = default;
									obj4 = (object)(&obj27);
									if (!flag15)
									{
										nint num10 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
										obj4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag16 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
										obj5 = 0;
										if (flag16)
										{
											goto IL_0e01;
										}
									}
									bool flag17 = array.Length < 5;
									object obj28 = !flag17;
									object obj29 = array.Length - 5;
									bool flag18 = obj29 == null;
									object obj30 = ~obj28;
									object obj31 = obj30 | flag18;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65171A0]");
										object obj32 = 0;
										object obj33 = array + 72;
										obj33 = obj26;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										format = (string)obj32;
										num7 = base.BytesOut__BackingField;
										num5 = base.UdpFragmentsIn__BackingField;
										num3 = base.PackagesIn__BackingField;
										num = base.BytesIn__BackingField;
										args = array;
										goto IL_0e6b;
									}
								}
							}
						}
					}
				}
				goto IL_0deb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array2 = default;
			if (array2 != null)
			{
				object obj34 = default;
				bool flag19 = obj34 == null;
				obj4 = (object)(&num);
				if (!flag19)
				{
					nint num11 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v77 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag20 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v77 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					if (flag20)
					{
						goto IL_0e01;
					}
				}
				if (array2.Length != 0)
				{
					object obj35 = array2 + 32;
					obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj36 = default;
					bool flag21 = obj36 == null;
					obj4 = (object)(&num3);
					if (!flag21)
					{
						nint num12 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v76 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag22 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v76 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						if (flag22)
						{
							goto IL_0e01;
						}
					}
					object obj37 = array2.Length & 0xFFFFFFFEL;
					if (obj37 != null)
					{
						object obj38 = array2 + 40;
						obj38 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj39 = default;
						bool flag23 = obj39 == null;
						obj4 = (object)(&num7);
						if (!flag23)
						{
							nint num13 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v75 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag24 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v75 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							if (flag24)
							{
								goto IL_0e01;
							}
						}
						bool flag25 = array2.Length < 2;
						object obj40 = !flag25;
						object obj41 = array2.Length - 2;
						bool flag26 = obj41 == null;
						object obj42 = ~obj40;
						object obj43 = obj42 | flag26;
						if (obj43 == null)
						{
							object obj44 = array2 + 48;
							obj44 = obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj45 = default;
							bool flag27 = obj45 == null;
							obj4 = (object)(&num5);
							if (!flag27)
							{
								nint num14 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v74 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag28 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v74 (Il2CppClass<System.Object[]>)+40]");
								obj5 = 0;
								if (flag28)
								{
									goto IL_0e01;
								}
							}
							object obj46 = array2.Length & 0xFFFFFFFCL;
							if (obj46 != null)
							{
								object obj47 = array2 + 56;
								obj47 = obj45;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65171B0]");
								object obj48 = 0;
								format = (string)obj48;
								num7 = base.BytesOut__BackingField;
								num5 = base.PackagesOut__BackingField;
								num3 = base.PackagesIn__BackingField;
								num = base.BytesIn__BackingField;
								args = array2;
								goto IL_0e6b;
							}
						}
					}
				}
				goto IL_0deb;
			}
		}
		goto IL_0e19;
		IL_0e01:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_0e19;
		IL_0e19:
		return (string)(object)new NullReferenceException();
		IL_0e66:
		string result;
		return result;
		IL_0e6b:
		string text = string.Format(format, args);
		bool flag29 = !extended;
		result = text;
		if (!flag29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string[] array3 = default;
			if (array3 != null)
			{
				bool flag30 = array3.Length == 0;
				nint num15 = unchecked((nint)null);
				obj4 = 6;
				if (!flag30)
				{
					object obj50 = array3 + 32;
					obj50 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X22_v5-8]");
					object obj51 = 0 & 0xFFFFFFFEL;
					bool flag31 = obj51 == null;
					num15 = unchecked((nint)null);
					obj4 = text;
					if (!flag31)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A68]");
						object obj52 = 0;
						object obj53 = array3 + 40;
						obj53 = obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517198]");
						object format2 = 0;
						object obj54 = default;
						string text2 = string.Format((string)format2, obj54);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X21_v7-10]");
						bool flag32 = (nint)0 < (nint)2;
						object obj55 = !flag32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X21_v7-10]");
						object obj56 = -2;
						bool flag33 = obj56 == null;
						object obj57 = ~obj55;
						object obj58 = obj57 | flag33;
						num15 = unchecked((nint)null);
						obj4 = obj54;
						if (obj58 == null)
						{
							object obj59 = array3 + 48;
							obj59 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65171B8]");
							object format3 = 0;
							object obj60 = default;
							string text3 = string.Format((string)format3, obj60);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X21_v9-18]");
							object obj61 = 0 & 0xFFFFFFFCL;
							bool flag34 = obj61 == null;
							num15 = unchecked((nint)null);
							obj4 = obj60;
							if (!flag34)
							{
								object obj62 = array3 + 56;
								obj62 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65171A8]");
								object format4 = 0;
								object obj63 = default;
								string text4 = string.Format((string)format4, obj63);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X21_v11-20]");
								bool flag35 = (nint)0 < (nint)4;
								object obj64 = !flag35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X21_v11-20]");
								object obj65 = -4;
								bool flag36 = obj65 == null;
								object obj66 = ~obj64;
								object obj67 = obj66 | flag36;
								num15 = unchecked((nint)null);
								obj4 = obj63;
								if (obj67 == null)
								{
									object obj68 = array3 + 64;
									obj68 = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517190]");
									object format5 = 0;
									object obj69 = default;
									string text5 = string.Format((string)format5, obj69);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X21_v13-28]");
									bool flag37 = (nint)0 < (nint)5;
									object obj70 = !flag37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X21_v13-28]");
									object obj71 = -5;
									bool flag38 = obj71 == null;
									object obj72 = ~obj70;
									object obj73 = obj72 | flag38;
									num15 = unchecked((nint)null);
									obj4 = obj69;
									if (obj73 == null)
									{
										object obj74 = array3 + 72;
										obj74 = text5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string text6 = string.Concat(array3);
										result = text6;
										goto IL_0e66;
									}
								}
							}
						}
					}
				}
				goto IL_0deb;
			}
			goto IL_0e19;
		}
		goto IL_0e66;
		IL_0deb:
		ex = new IndexOutOfRangeException();
		obj5 = obj4;
		goto IL_0e01;
	}
}
