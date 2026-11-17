using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;

namespace Photon.Client;

internal class EnetChannel
{
	private struct Node<K, V>
	{
		public bool Used;

		public K Key;

		public V Val;

		public int Next;

		public uint Hash;

		private unsafe string DebuggerDisplay
		{
			get
			{
				//IL_00be: Expected Obj, but got I
				//IL_0012: Expected Obj, but got I
				//IL_0022: Expected Obj, but got I
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Expected Obj, but got Unknown
				//IL_004a: Expected Obj, but got I4
				//IL_007d: Expected Obj, but got I
				//IL_00a0: Expected Obj, but got I
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
					object obj = (nint)0 + (nint)309;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1328]");
					object format = 0;
					object obj2 = obj & 1;
					bool flag = obj2 == null;
					object obj3 = !flag;
					nint num = 0;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5 (Il2CppClass<Photon.Client.EnetChannel+Node>)+A8]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel+Node<K, V>)+8]");
					object arg = default;
					return string.Format((string)format, arg, 0);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A98]");
				return (string)0;
			}
		}
	}

	internal byte ChannelNumber;

	internal NonAllocDictionary<int, NCommand> incomingReliableCommandsList;

	internal NonAllocDictionary<int, NCommand> incomingUnreliableCommandsList;

	internal Queue<NCommand> incomingUnsequencedCommandsList;

	internal NonAllocDictionary<int, NCommand> incomingUnsequencedFragments;

	internal List<NCommand> outgoingReliableCommandsList;

	internal List<NCommand> outgoingUnreliableCommandsList;

	internal int incomingReliableSequenceNumber;

	internal int incomingUnreliableSequenceNumber;

	internal int outgoingReliableSequenceNumber;

	internal int outgoingUnreliableSequenceNumber;

	internal int outgoingReliableUnsequencedNumber;

	private int reliableUnsequencedNumbersCompletelyReceived;

	private HashSet<int> reliableUnsequencedNumbersReceived;

	internal int highestReceivedAck;

	internal int lowestUnacknowledgedSequenceNumber;

	private EnetPeer.ReceiveTrackingValues SequencedReceived;

	private EnetPeer.ReceiveTrackingValues UnsequencedReceived;

	public EnetChannel(byte channelNumber, int commandBufferSize)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01c4: Expected I4, but got Obj
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516058]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516060]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516068]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516070]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516078]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<int> hashSet = default;
		hashSet._002Ector();
		object obj7 = this + 96;
		obj7 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EnetPeer.ReceiveTrackingValues receiveTrackingValues = default;
		receiveTrackingValues._002Ector();
		object obj8 = this + 112;
		obj8 = receiveTrackingValues;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EnetPeer.ReceiveTrackingValues receiveTrackingValues2 = default;
		receiveTrackingValues2._002Ector();
		object obj9 = this + 120;
		obj9 = receiveTrackingValues2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		ChannelNumber = channelNumber;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NonAllocDictionary<int, System.__Canon> nonAllocDictionary = default;
		nonAllocDictionary._002Ector((uint)commandBufferSize);
		object obj10 = this + 24;
		obj10 = nonAllocDictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NonAllocDictionary<int, System.__Canon> nonAllocDictionary2 = default;
		nonAllocDictionary2._002Ector((uint)commandBufferSize);
		object obj11 = this + 32;
		obj11 = nonAllocDictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516088]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<System.__Canon> queue = default;
		queue._002Ector();
		object obj13 = this + 40;
		obj13 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NonAllocDictionary<int, System.__Canon> nonAllocDictionary3 = default;
		nonAllocDictionary3._002Ector((uint)(int)typeof(_0021_00210));
		object obj14 = this + 48;
		obj14 = nonAllocDictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector(commandBufferSize);
		object obj15 = this + 56;
		obj15 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector(commandBufferSize);
		object obj16 = this + 64;
		obj16 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public bool ContainsUnreliableSequenceNumber(int unreliableSequenceNumber)
	{
		//IL_002c: Expected I4, but got Obj
		if (incomingUnreliableCommandsList != null)
		{
			return ((NonAllocDictionary<int, System.__Canon>)(object)incomingUnreliableCommandsList).ContainsKey(unreliableSequenceNumber);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public NCommand FetchUnreliableSequenceNumber(int unreliableSequenceNumber)
	{
		if (incomingUnreliableCommandsList != null)
		{
			return (NCommand)(object)((NonAllocDictionary<int, System.__Canon>)(object)incomingUnreliableCommandsList).get_Item(unreliableSequenceNumber);
		}
		return (NCommand)(object)new NullReferenceException();
	}

	public bool ContainsReliableSequenceNumber(int reliableSequenceNumber)
	{
		//IL_002c: Expected I4, but got Obj
		if (incomingReliableCommandsList != null)
		{
			return ((NonAllocDictionary<int, System.__Canon>)(object)incomingReliableCommandsList).ContainsKey(reliableSequenceNumber);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool AddSequencedIfNew(NCommand command)
	{
		//IL_0173: Expected I4, but got Obj
		//IL_0032: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I
		//IL_0104: Expected I4, but got Obj
		//IL_0122: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected I4, but got Unknown
		//IL_0142: Expected I4, but got Obj
		if (command == null)
		{
			goto IL_0165;
		}
		int num = command.commandFlags & 1;
		bool flag = num == 0;
		object obj = !flag;
		NonAllocDictionary<int, NCommand> nonAllocDictionary;
		object obj6;
		NonAllocDictionary<int, System.__Canon> nonAllocDictionary2;
		if (obj == null)
		{
			nonAllocDictionary = incomingUnreliableCommandsList;
		}
		else
		{
			int num2 = command.commandType & 0xFF;
			bool flag2 = num2 < 17;
			object obj2 = !flag2;
			object obj3 = ~obj2;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				object obj5 = 24;
			}
			else
			{
				object obj5 = 32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v115 @ X8_v15]");
			nonAllocDictionary = (NonAllocDictionary<int, NCommand>)0;
			if (obj2 == null)
			{
				obj6 = command + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v115 @ X8_v15]");
				nonAllocDictionary2 = (NonAllocDictionary<int, System.__Canon>)0;
				goto IL_01ae;
			}
		}
		obj6 = command + 24;
		nonAllocDictionary2 = (NonAllocDictionary<int, System.__Canon>)(object)nonAllocDictionary;
		goto IL_01ae;
		IL_01ae:
		if (nonAllocDictionary2 != null)
		{
			bool flag3 = nonAllocDictionary2.ContainsKey((int)obj6);
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				nonAllocDictionary2.Add((int)obj6, (System.__Canon)(object)command);
			}
			object obj8 = !flag3;
			return (byte)(1 & obj8) != 0;
		}
		goto IL_0165;
		IL_0165:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public NCommand FetchReliableSequenceNumber(int reliableSequenceNumber)
	{
		if (incomingReliableCommandsList != null)
		{
			return (NCommand)(object)((NonAllocDictionary<int, System.__Canon>)(object)incomingReliableCommandsList).get_Item(reliableSequenceNumber);
		}
		return (NCommand)(object)new NullReferenceException();
	}

	public bool TryGetFragment(int reliableSequenceNumber, bool isSequenced, out NCommand fragment)
	{
		//IL_002b: Expected Obj, but got I4
		NonAllocDictionary<int, System.__Canon> nonAllocDictionary;
		if (isSequenced)
		{
			nonAllocDictionary = (NonAllocDictionary<int, System.__Canon>)(object)incomingReliableCommandsList;
			bool flag = incomingReliableCommandsList == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			nonAllocDictionary = (NonAllocDictionary<int, System.__Canon>)(object)incomingUnsequencedFragments;
		}
		return nonAllocDictionary.TryGetValue(reliableSequenceNumber, out System.Runtime.CompilerServices.Unsafe.As<NCommand, System.__Canon>(ref fragment));
	}

	public void RemoveFragment(int reliableSequenceNumber, bool isSequenced)
	{
		//IL_002b: Expected Obj, but got I4
		NonAllocDictionary<int, System.__Canon> nonAllocDictionary;
		if (isSequenced)
		{
			nonAllocDictionary = (NonAllocDictionary<int, System.__Canon>)(object)incomingReliableCommandsList;
			bool flag = incomingReliableCommandsList == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			nonAllocDictionary = (NonAllocDictionary<int, System.__Canon>)(object)incomingUnsequencedFragments;
		}
		bool flag2 = nonAllocDictionary.Remove(reliableSequenceNumber);
	}

	public unsafe void clearAll(Pool<NCommand> commandPool)
	{
		//IL_0240: Expected Obj, but got I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got Ref
		//IL_013a: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got Ref
		//IL_0162: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(this, ref lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516058]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EnetPeer.ReceiveTrackingValues receiveTrackingValues = default;
		receiveTrackingValues._002Ector();
		object obj2 = this + 112;
		obj2 = receiveTrackingValues;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EnetPeer.ReceiveTrackingValues receiveTrackingValues2 = default;
		receiveTrackingValues2._002Ector();
		object obj3 = this + 120;
		obj3 = receiveTrackingValues2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160C8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726C7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726C7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726C04");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726C7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160C0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726B48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726B48");
		OutOfMemoryException ex = null;
		object obj7 = 0;
		object obj10 = default;
		object obj13 = default;
		while (true)
		{
			object obj8 = (object)(&lockTaken);
			if (obj8 != null)
			{
				object obj9 = (object)(&obj10);
				Monitor.Exit(obj9);
			}
			bool flag = ex == null;
			object obj11 = !flag;
			if (obj11 == null)
			{
				bool flag2 = obj7 == null;
				object obj12 = !flag2;
				OutOfMemoryException ex2 = ex;
				if (obj12 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if (0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj7 = 1;
				continue;
			}
			if (0 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex = (OutOfMemoryException)obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public bool QueueIncomingReliableUnsequenced(NCommand command)
	{
		//IL_02cf: Expected I4, but got Obj
		//IL_01ba: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68D551F]");
		int num = 0;
		bool flag = command == null;
		int num2 = (int)command;
		if (!flag)
		{
			num2 = command.reliableSequenceNumber;
			num = reliableUnsequencedNumbersCompletelyReceived;
			if (command.reliableSequenceNumber > reliableUnsequencedNumbersCompletelyReceived)
			{
				if (reliableUnsequencedNumbersReceived == null)
				{
					goto IL_01c8;
				}
				if (!reliableUnsequencedNumbersReceived.Contains(command.reliableSequenceNumber))
				{
					num2 = command.reliableSequenceNumber;
					num = reliableUnsequencedNumbersCompletelyReceived + 1;
					if (command.reliableSequenceNumber == num)
					{
						HashSet<int> hashSet = reliableUnsequencedNumbersReceived;
						reliableUnsequencedNumbersCompletelyReceived = command.reliableSequenceNumber;
						if (reliableUnsequencedNumbersReceived == null)
						{
							goto IL_01c8;
						}
						while (true)
						{
							num2 = reliableUnsequencedNumbersCompletelyReceived + 1;
							if (!hashSet.Contains(num2))
							{
								break;
							}
							num2 = ++reliableUnsequencedNumbersCompletelyReceived;
							if (reliableUnsequencedNumbersReceived != null)
							{
								bool flag2 = reliableUnsequencedNumbersReceived.Remove(num2);
								hashSet = reliableUnsequencedNumbersReceived;
								bool flag3 = reliableUnsequencedNumbersReceived == null;
								object obj = !flag3;
								if (obj != null)
								{
									continue;
								}
							}
							goto IL_01c8;
						}
					}
					else
					{
						if (reliableUnsequencedNumbersReceived == null)
						{
							goto IL_01c8;
						}
						bool flag4 = reliableUnsequencedNumbersReceived.Add(num2);
					}
					if (command.commandType == 15)
					{
						if (incomingUnsequencedFragments == null)
						{
							goto IL_01c8;
						}
						((NonAllocDictionary<int, System.__Canon>)(object)incomingUnsequencedFragments).Add(command.reliableSequenceNumber, (System.__Canon)(object)command);
					}
					else
					{
						if (incomingUnsequencedCommandsList == null)
						{
							goto IL_01c8;
						}
						((Queue<System.__Canon>)(object)incomingUnsequencedCommandsList).Enqueue((System.__Canon)(object)command);
					}
					return true;
				}
			}
			return false;
		}
		goto IL_01c8;
		IL_01c8:
		throw new NullReferenceException();
	}

	internal void ApplySequenceNumberModifier(int mod)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		int num = incomingReliableSequenceNumber + mod;
		incomingReliableSequenceNumber = num;
		int num2 = outgoingReliableSequenceNumber + mod;
		int num3 = highestReceivedAck + mod;
		object obj = default;
		int num4 = outgoingReliableUnsequencedNumber + obj;
		outgoingReliableSequenceNumber = num2;
		EnetPeer.ReceiveTrackingValues sequencedReceived = SequencedReceived;
		highestReceivedAck = num3;
		outgoingReliableUnsequencedNumber = num4;
		EnetPeer.ReceiveTrackingValues unsequencedReceived = UnsequencedReceived;
		int reliableSequencedNumbersCompletelyReceived = sequencedReceived.reliableSequencedNumbersCompletelyReceived + mod;
		sequencedReceived.reliableSequencedNumbersCompletelyReceived = reliableSequencedNumbersCompletelyReceived;
		int reliableSequencedNumbersCompletelyReceived2 = unsequencedReceived.reliableSequencedNumbersCompletelyReceived + mod;
		unsequencedReceived.reliableSequencedNumbersCompletelyReceived = reliableSequencedNumbersCompletelyReceived2;
	}

	public unsafe void Received(NCommand inCommand)
	{
		//IL_0538: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0556: Expected Obj, but got I
		//IL_056b: Expected Obj, but got I
		//IL_058a: Expected Obj, but got Ref
		//IL_0592: Expected Obj, but got Ref
		//IL_05a2: Expected Obj, but got I
		//IL_05af: Expected Obj, but got Ref
		//IL_05b4: Expected I, but got Obj
		//IL_05bd: Expected Obj, but got I4
		//IL_05d0: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_05f4: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got Ref
		//IL_0202: Expected Obj, but got Ref
		//IL_0212: Expected Obj, but got I
		//IL_0224: Expected I, but got Obj
		//IL_022d: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_04ad: Expected I4, but got Obj
		//IL_04b6: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got Ref
		//IL_00d2: Expected I, but got Obj
		//IL_0504: Expected I4, but got Obj
		//IL_0392: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got Ref
		//IL_0275: Expected Obj, but got Ref
		//IL_0285: Expected Obj, but got I
		//IL_0292: Expected Obj, but got Ref
		//IL_0297: Expected I, but got Obj
		//IL_02a0: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I
		//IL_02d9: Expected I, but got Obj
		//IL_02ee: Expected I4, but got Obj
		//IL_02ee: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got Ref
		//IL_0302: Expected Obj, but got Ref
		//IL_0312: Expected Obj, but got I
		//IL_031f: Expected I4, but got Obj
		//IL_0328: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got Ref
		//IL_03f8: Expected Obj, but got Ref
		//IL_0408: Expected Obj, but got I
		//IL_0416: Expected Obj, but got I4
		//IL_00df: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0125: Expected Obj, but got Ref
		//IL_012d: Expected Obj, but got Ref
		//IL_013d: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01b3: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		NCommand nCommand = default;
		bool flag = nCommand == null;
		object obj = null;
		bool lockTaken = false;
		NCommand nCommand2 = nCommand;
		object obj2 = 109924352;
		if (flag)
		{
			goto IL_0425;
		}
		nCommand2 = (NCommand)nCommand.reliableSequenceNumber;
		int num = nCommand.commandFlags & 2;
		bool flag2 = num == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			object obj4 = 112;
		}
		else
		{
			object obj4 = 120;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
		Monitor.Enter(0, ref lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
		bool flag3 = (nint)0 == 0;
		object obj6 = (object)(&obj);
		object obj7 = (object)(&lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
		obj = 0;
		NullReferenceException ex = null;
		nCommand = (NCommand)(&lockTaken);
		nint num2 = unchecked((nint)null);
		object obj8 = 0;
		lockTaken = false;
		obj2 = 109924352;
		int num3;
		if (!flag3)
		{
			_ = 1;
			NCommand nCommand3 = nCommand2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+24]");
			if ((nint)nCommand3 > 0)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+20]");
			object obj4 = (nint)0 + (nint)1;
			if (nCommand2 == obj4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C28]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6640]");
				object obj9 = 0;
				nCommand = (NCommand)(&lockTaken);
				num2 = unchecked((nint)null);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+18]");
					if ((nint)0 != 0)
					{
						num2 = (nint)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+20]");
						num3 = (int)((nint)0 + (nint)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+18]");
						bool flag4 = ((HashSet<int>)0).Contains(num3);
						bool flag5 = !flag4;
						obj6 = (object)(&obj);
						obj7 = (object)(&lockTaken);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
						obj = 0;
						ex = null;
						obj8 = 0;
						lockTaken = false;
						if (flag5)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+20]");
						int num4 = (int)((nint)0 + (nint)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+18]");
						bool flag6 = (nint)0 == 0;
						nCommand = (NCommand)num4;
						if (!flag6)
						{
							num2 = (nint)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+18]");
							bool flag7 = ((HashSet<int>)0).Remove(num4);
							nCommand = (NCommand)num4;
							continue;
						}
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
					}
					NullReferenceException ex3 = new NullReferenceException();
					obj6 = (object)(&obj);
					obj7 = (object)(&lockTaken);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
					obj = 0;
					ex = null;
					obj8 = 0;
					lockTaken = false;
					goto IL_0425;
				}
			}
			else
			{
				NCommand nCommand4 = nCommand2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+20]");
				bool flag8 = (nint)nCommand4 <= 0;
				obj6 = (object)(&obj);
				obj7 = (object)(&lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
				obj = 0;
				ex = null;
				num3 = (int)(&lockTaken);
				num2 = unchecked((nint)null);
				obj8 = 0;
				lockTaken = false;
				obj2 = 109924352;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+18]");
					bool flag9 = (nint)0 == 0;
					obj6 = (object)(&obj);
					obj7 = (object)(&lockTaken);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
					obj = 0;
					ex = null;
					nCommand = (NCommand)(&lockTaken);
					num2 = unchecked((nint)null);
					obj8 = 0;
					lockTaken = false;
					obj2 = 109924352;
					if (flag9)
					{
						goto IL_045e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C20]");
					object obj10 = 0;
					num2 = (nint)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X19_v10 (System.Object)+18]");
					bool flag10 = ((HashSet<int>)0).Add((int)nCommand2);
					obj6 = (object)(&obj);
					obj7 = (object)(&lockTaken);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v291 @ X9_v1]");
					obj = 0;
					ex = null;
					num3 = (int)nCommand2;
					obj8 = 0;
					lockTaken = false;
					obj2 = 109924352;
				}
			}
			goto IL_0340;
		}
		goto IL_0441;
		IL_0441:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_044f;
		IL_044f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_045e;
		IL_0433:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_0441;
		IL_0425:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0433;
		IL_0340:
		bool flag11 = obj7 == null;
		nCommand = (NCommand)num3;
		if (!flag11)
		{
			Monitor.Exit(obj6);
			nCommand = null;
		}
		bool flag12 = ex == null;
		object obj11 = !flag12;
		if (obj11 != null)
		{
			goto IL_0433;
		}
		bool flag13 = obj8 == null;
		object obj12 = !flag13;
		ex4 = ex;
		if (obj12 == null)
		{
			return;
		}
		goto IL_044f;
		IL_045e:
		NullReferenceException ex7 = new NullReferenceException();
		if ((nint)nCommand == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = (int)nCommand;
			obj8 = 1;
		}
		else
		{
			if ((nint)nCommand != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj13 = default;
			ex = (NullReferenceException)obj13;
			num3 = (int)nCommand;
		}
		goto IL_0340;
	}

	public unsafe bool GetGapBlock(out int completeSequenceNumber, int[] blocks, bool isSequenced = default(bool))
	{
		//IL_064a: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0671: Expected Obj, but got I
		//IL_0686: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_06c4: Expected Obj, but got Ref
		//IL_0095: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_0508: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got Ref
		//IL_00c3: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I8
		//IL_0190: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_071f: Expected Obj, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_0200: Expected I4, but got Obj
		//IL_0215: Expected Obj, but got I
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I
		//IL_03ae: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I4
		//IL_044f: Expected Obj, but got I4
		bool flag = !isSequenced;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 112;
		}
		else
		{
			object obj3 = 120;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v72 @ X8_v4]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v72 @ X8_v4]");
		bool lockTaken = default;
		Monitor.Enter(0, ref lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetChannel)+v72 @ X8_v4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = 0;
		int num = (int)(&lockTaken);
		if (flag2)
		{
			goto IL_04a5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+20]");
		ref int reference = ref *(int*)null;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+10]");
		bool flag3 = (nint)0 == 0;
		OutOfMemoryException ex = null;
		object obj6 = 0;
		obj5 = 0;
		int num2 = (int)(&lockTaken);
		if (flag3)
		{
			goto IL_056f;
		}
		bool flag4 = blocks == null;
		object obj7 = !flag4;
		num2 = (int)(&lockTaken);
		int[] array = blocks;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			int[] array2 = default;
			bool flag5 = array2 == null;
			num2 = 4;
			array = array2;
			obj5 = 0;
			num = 4;
			if (flag5)
			{
				goto IL_04b3;
			}
		}
		bool flag6 = array.Length < 1;
		ex = null;
		obj6 = 0;
		obj5 = 0;
		bool result = true;
		if (!flag6)
		{
			object obj9 = completeSequenceNumber;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C28]");
			object obj10 = 0;
			object obj11 = array.Length & 0xFFFFFFFFL;
			object obj12 = completeSequenceNumber + 1;
			obj5 = 0;
			object obj13 = 0;
			object obj14 = 0;
			int num3;
			object obj26 = default;
			while (true)
			{
				bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
				object obj15 = !flag7;
				if (obj15 != null)
				{
					goto IL_0481;
				}
				object obj16 = (object)array + obj13;
				object obj17 = obj16 + 32;
				obj17 = 0;
				object obj18 = 0;
				object obj19 = 0;
				object obj21;
				object obj22;
				object obj23;
				object obj25;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+18]");
					if ((nint)0 != 0)
					{
						obj5 = obj10;
						num3 = (int)(obj12 + obj18);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+18]");
						if (((HashSet<int>)0).Contains(num3))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+18]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+18]");
							bool flag8 = (nint)0 == 0;
							num2 = num3;
							if (flag8)
							{
								goto IL_0473;
							}
							obj21 = 1 << (int)obj18;
							obj22 = obj14 + 1;
							obj23 = obj19 | obj21;
							object obj24 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v31+20]");
							bool flag9 = (nint)obj24 >= 0;
							obj25 = obj26;
							if (flag9)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+24]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+24]");
							object obj27 = (nint)num3 - (nint)0;
							bool flag10 = obj27 == null;
							obj26 = !flag10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X20_v2 (System.Object)+24]");
							bool flag11 = (nint)num3 > (nint)0;
							obj19 = obj23;
							obj9 = obj21;
							obj14 = obj22;
							obj25 = obj26;
							if (flag11)
							{
								break;
							}
						}
						obj18++;
						bool flag12 = (nint)obj18 != 32;
						obj25 = obj26;
						obj23 = obj19;
						obj21 = obj9;
						obj22 = obj14;
						num2 = num3;
						if (!flag12)
						{
							break;
						}
						continue;
					}
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_0473;
					IL_0473:
					NullReferenceException ex3 = new NullReferenceException();
					goto IL_0481;
				}
				obj11 = array.Length;
				bool flag13 = (nint)obj13 < array.Length;
				object obj28 = !flag13;
				num2 = num3;
				if (obj28 == null)
				{
					obj13++;
					obj12 += 32;
					obj17 = obj23;
					bool flag14 = (nint)obj13 < array.Length;
					obj26 = obj25;
					obj9 = obj21;
					num2 = num3;
					obj14 = obj22;
					if (!flag14)
					{
						break;
					}
					continue;
				}
				goto IL_048f;
				IL_0481:
				IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
				goto IL_048f;
				IL_048f:
				IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
				num = num2;
				goto IL_04a5;
			}
			ex = null;
			obj6 = 0;
			num2 = num3;
			result = true;
		}
		goto IL_06bc;
		IL_04a5:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_04b3;
		IL_056f:
		result = false;
		goto IL_06bc;
		IL_04b3:
		NullReferenceException ex7 = new NullReferenceException();
		NullReferenceException ex8;
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex = null;
			obj6 = 1;
			num2 = num;
		}
		else
		{
			bool flag15 = num != 1;
			ex8 = ex7;
			if (flag15)
			{
				goto IL_072d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj29 = default;
			ex = (OutOfMemoryException)obj29;
			obj6 = 0;
			num2 = num;
		}
		goto IL_056f;
		IL_072d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result2 = default;
		return result2;
		IL_06bc:
		object obj30 = (object)(&lockTaken);
		if (obj30 != null)
		{
			object obj32 = default;
			object obj31 = (object)(&obj32);
			Monitor.Exit(obj31);
			num2 = 0;
		}
		bool flag16 = ex == null;
		object obj33 = !flag16;
		if (obj33 == null)
		{
			bool flag17 = obj6 == null;
			object obj34 = !flag17;
			OutOfMemoryException ex9 = ex;
			if (obj34 == null)
			{
				return result;
			}
		}
		else
		{
			OutOfMemoryException ex9 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		num = num2;
		NullReferenceException ex10 = default;
		ex8 = ex10;
		goto IL_072d;
	}
}
