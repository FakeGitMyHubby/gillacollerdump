using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Fusion.Sockets;
using Photon.Client.Encryption;

namespace Photon.Client;

internal class EnetPeer : PeerBase
{
	public class ReceiveTrackingValues
	{
		internal bool ReceivedReliableCommandSincePreviousAck2;

		internal HashSet<int> receivedReliableSequenceNumbers;

		internal int reliableSequencedNumbersCompletelyReceived;

		internal int reliableSequencedNumbersHighestReceived;

		public ReceiveTrackingValues()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			HashSet<int> hashSet = default;
			hashSet._002Ector();
			object obj2 = this + 24;
			obj2 = hashSet;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	internal struct GapBlock
	{
		internal byte Offset;

		internal int Block;
	}

	private const int CRC_LENGTH = default(int);

	private const int EncryptedDataGramHeaderSize = default(int);

	private const int EncryptedHeaderSize = default(int);

	private const int MaxFragmentCount = default(int);

	internal Pool<NCommand> nCommandPool;

	private List<NCommand> sentReliableCommands;

	private bool SendWindowUpdateRequired;

	private StreamBuffer outgoingAcknowledgementsBuffer;

	internal const int UnsequencedWindowSize = default(int);

	internal readonly int[] unsequencedWindow;

	internal int outgoingUnsequencedGroupNumber;

	internal int incomingUnsequencedGroupNumber;

	internal const int UnsequencedWindowsFree = default(int);

	internal const int UnsequencedResyncAfter = default(int);

	private int unsequencedGroupsDroppedInARow;

	private byte udpCommandCount;

	private byte[] udpBuffer;

	private int udpBufferIndex;

	private byte[] bufferForEncryption;

	private bool udpBufferEncryptedLayout;

	private int commandBufferSize;

	internal int challenge;

	internal int serverSentTime;

	internal static readonly byte[] udpHeader0xF3;

	private int datagramEncryptedConnectionBackValue;

	private EnetChannel[] channelArray;

	private const byte ControlChannelNumber = default(byte);

	protected internal const short PeerIdForConnect = default(short);

	protected internal const short PeerIdForConnectTrace = default(short);

	private Queue<int> commandsToRemove;

	private ConcurrentQueue<NCommand> CommandQueue;

	private ConcurrentQueue<NCommand> AckQueue;

	private int fragmentLength;

	private int fragmentLengthDatagramEncrypt;

	private int fragmentLengthMtuValue;

	private readonly object datagramAccessLockObject;

	private int[] lowestSentSequenceNumber;

	private int[] gapBlocks;

	private const int SendWindowSkipsMax = default(int);

	private readonly List<NCommand> toRemove;

	private readonly List<int> toRemoveIndices;

	internal unsafe override int QueuedIncomingCommandsCount
	{
		get
		{
			//IL_031a: Expected I4, but got Obj
			//IL_0265: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_001d: Expected Obj, but got Ref
			//IL_0026: Expected Obj, but got I4
			//IL_021c: Expected I4, but got Obj
			//IL_0272: Expected Obj, but got Ref
			//IL_004f: Expected Obj, but got I4
			//IL_0297: Expected Obj, but got Ref
			//IL_02a9: Expected Obj, but got I4
			//IL_00f9: Expected I4, but got Obj
			//IL_0127: Expected Obj, but got I4
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected I4, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected Obj, but got Unknown
			bool lockTaken = default;
			Monitor.Enter(channelArray, ref lockTaken);
			EnetChannel[] array = channelArray;
			bool flag = channelArray == null;
			int num = (int)channelArray;
			EnetChannel enetChannel;
			EnetChannel enetChannel2 = default;
			bool flag3;
			EnetChannel[] array2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160D8]");
				object obj = 0;
				object obj2 = (object)(&lockTaken);
				object obj3 = 0;
				int num2 = 0;
				object obj9 = default;
				int result = default;
				while (true)
				{
					if ((nint)obj3 < array.Length)
					{
						bool flag2 = (nint)obj3 < array.Length;
						object obj4 = !flag2;
						enetChannel = enetChannel2;
						object obj5 = obj3;
						flag3 = flag;
						array2 = array;
						if (obj4 != null)
						{
							break;
						}
						array2 = (EnetChannel[])(object)((object)array + obj3);
						enetChannel = array2[0];
						flag3 = array2[0] == null;
						obj5 = obj3;
						if (flag3)
						{
							goto IL_020b;
						}
						flag3 = enetChannel.incomingReliableCommandsList == null;
						obj5 = obj3;
						num = (int)array2;
						if (flag3)
						{
							goto IL_0221;
						}
						int count = ((NonAllocDictionary<int, System.__Canon>)(object)enetChannel.incomingReliableCommandsList).Count;
						object obj6 = count + num2;
						flag3 = enetChannel.incomingUnreliableCommandsList == null;
						obj5 = obj3;
						num = count;
						if (!flag3)
						{
							int count2 = ((NonAllocDictionary<int, System.__Canon>)(object)enetChannel.incomingUnreliableCommandsList).Count;
							array2 = channelArray;
							num2 = count2 + obj6;
							obj5 = obj3 + 1;
							bool flag4 = channelArray == null;
							flag3 = !flag4;
							obj2 = obj;
							enetChannel2 = array2[0];
							obj3 = obj5;
							flag = flag3;
							array = channelArray;
							if (flag3)
							{
								continue;
							}
							goto IL_01ef;
						}
						goto IL_022f;
					}
					object obj7 = (object)(&lockTaken);
					if (obj7 != null)
					{
						object obj8 = (object)(&obj9);
						Monitor.Exit(obj8);
						obj2 = 0;
					}
					OutOfMemoryException ex = new OutOfMemoryException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
				}
				goto IL_01fd;
			}
			goto IL_024d;
			IL_022f:
			NullReferenceException ex2 = new NullReferenceException();
			enetChannel2 = enetChannel;
			flag = flag3;
			goto IL_024d;
			IL_0221:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_022f;
			IL_01ef:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_01fd;
			IL_01fd:
			IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
			goto IL_020b;
			IL_020b:
			NullReferenceException ex6 = new NullReferenceException();
			num = (int)array2;
			goto IL_0221;
			IL_024d:
			enetChannel = enetChannel2;
			flag3 = flag;
			array2 = (EnetChannel[])num;
			goto IL_01ef;
		}
	}

	internal unsafe override int QueuedOutgoingCommandsCount
	{
		get
		{
			//IL_02ad: Expected Obj, but got I4
			//IL_02b5: Expected Obj, but got Ref
			//IL_000e: Expected Obj, but got I4
			//IL_0016: Expected Obj, but got Ref
			//IL_001f: Expected Obj, but got I4
			//IL_047c: Expected Obj, but got I4
			//IL_035b: Expected Obj, but got Ref
			//IL_03b1: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I4
			//IL_0380: Expected Obj, but got Ref
			//IL_0392: Expected Obj, but got I4
			//IL_03d9: Expected Obj, but got I4
			//IL_0073: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I4
			//IL_0219: Expected Obj, but got Ref
			//IL_0221: Expected Obj, but got Ref
			//IL_034e: Expected Obj, but got I4
			//IL_0304: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I
			//IL_0238: Expected Obj, but got I4
			//IL_0240: Expected Obj, but got Ref
			//IL_0248: Expected Obj, but got Ref
			//IL_00f2: Expected Obj, but got I
			//IL_025f: Expected Obj, but got I4
			//IL_0267: Expected Obj, but got Ref
			//IL_026f: Expected Obj, but got Ref
			//IL_04a0: Expected Obj, but got Ref
			//IL_04b7: Expected Obj, but got Ref
			//IL_016e: Expected Obj, but got I4
			//IL_0176: Expected Obj, but got Ref
			//IL_014e: Expected Obj, but got Ref
			//IL_0160: Expected Obj, but got I4
			bool lockTaken = default;
			Monitor.Enter(channelArray, ref lockTaken);
			EnetChannel[] array = channelArray;
			OutOfMemoryException ex;
			object obj4;
			int num;
			NullReferenceException ex3;
			object obj2;
			if (channelArray != null)
			{
				object obj = 0;
				obj2 = (object)(&lockTaken);
				object obj3 = 0;
				num = 0;
				bool flag = (nint)obj3 >= array.Length;
				ex = null;
				obj4 = 0;
				if (flag)
				{
					goto IL_0353;
				}
				bool flag2 = (nint)obj3 < array.Length;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					goto IL_0291;
				}
				object obj6 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v21+20]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v21+20]");
				bool lockTaken2 = default;
				Monitor.Enter(0, ref lockTaken2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v21+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v12 (System.Object)+38]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v12 (System.Object)+38]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v12 (System.Object)+40]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v22+18]");
						num = (int)((nint)0 + (nint)num);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v12 (System.Object)+40]");
						object obj13;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v23+18]");
							num = (int)((nint)0 + (nint)num);
							object obj10 = (object)(&lockTaken2);
							bool flag3 = obj10 == null;
							obj2 = (object)(&lockTaken2);
							if (!flag3)
							{
								object obj12 = default;
								object obj11 = (object)(&obj12);
								Monitor.Exit(obj11);
								obj2 = 0;
							}
							obj = 0;
							obj13 = (object)(&lockTaken2);
							goto IL_0291;
						}
						ex3 = new NullReferenceException();
						obj = 0;
						obj2 = (object)(&lockTaken2);
						obj13 = (object)(&lockTaken2);
					}
					else
					{
						ex3 = new NullReferenceException();
						obj = 0;
						obj2 = (object)(&lockTaken2);
						object obj13 = (object)(&lockTaken2);
					}
				}
				else
				{
					ex3 = new NullReferenceException();
					obj = 0;
					obj2 = (object)(&lockTaken2);
					object obj13 = (object)(&lockTaken2);
				}
			}
			else
			{
				object obj = 0;
				obj2 = (object)(&lockTaken);
				num = 0;
				ex3 = new NullReferenceException();
			}
			NullReferenceException ex4 = ex3;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
			if ((nint)obj14 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = null;
				obj4 = 1;
			}
			else
			{
				if ((nint)obj14 != 1)
				{
					goto IL_04f4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj15 = default;
				ex = (OutOfMemoryException)obj15;
				obj4 = 0;
			}
			goto IL_0353;
			IL_04f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			int result = default;
			return result;
			IL_0291:
			throw new OutOfMemoryException();
			IL_0353:
			object obj16 = (object)(&lockTaken);
			if (obj16 != null)
			{
				object obj18 = default;
				object obj17 = (object)(&obj18);
				Monitor.Exit(obj17);
				obj2 = 0;
			}
			bool flag4 = ex == null;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				bool flag5 = obj4 == null;
				object obj20 = !flag5;
				OutOfMemoryException ex5 = ex;
				if (obj20 == null)
				{
					return num;
				}
			}
			else
			{
				OutOfMemoryException ex5 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			NullReferenceException ex6 = default;
			ex4 = ex6;
			goto IL_04f4;
		}
	}

	private unsafe bool DatagramEncryptedConnection
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Ref, but got Unknown
			//IL_0030: Expected Obj, but got I4
			int num = Interlocked.CompareExchange(ref *(int*)(this + 384), 1, 1);
			object obj = num - 1;
			return obj == null;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Ref, but got Unknown
			ref int location = ref *(int*)(this + 384);
			if (value)
			{
				int num = Interlocked.CompareExchange(ref location, 1, 0);
			}
			else
			{
				int num2 = Interlocked.CompareExchange(ref location, 0, 1);
			}
		}
	}

	private bool useAck2
	{
		get
		{
			//IL_0090: Expected I4, but got Obj
			if (photonPeer != null)
			{
				if (photonPeer.UseAck2)
				{
					bool flag = !base.serverFeatureAck2Available__BackingField;
					return !flag;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	internal EnetPeer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I4
		//IL_06a2: Expected Obj, but got I
		//IL_06b2: Expected Obj, but got I
		//IL_06d4: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I4
		//IL_06f2: Expected Obj, but got I
		//IL_0702: Expected Obj, but got I
		//IL_0712: Expected Obj, but got I
		//IL_0722: Expected Obj, but got I
		//IL_0744: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_056b: Expected Obj, but got I
		//IL_0585: Expected Obj, but got I
		//IL_058d: Expected I, but got Obj
		//IL_059e: Expected I, but got Obj
		//IL_05bc: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_009c: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_05e3: Expected Obj, but got I
		//IL_05fd: Expected Obj, but got I
		//IL_0605: Expected I, but got Obj
		//IL_0616: Expected I, but got Obj
		//IL_0634: Expected Obj, but got I
		//IL_0657: Expected Obj, but got I4
		//IL_065f: Expected I, but got Obj
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03e6: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0447: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I
		//IL_04ce: Expected Obj, but got I4
		//IL_0674: Expected Obj, but got I
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v28+8]");
		Func<System.__Canon> func = (Func<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v28+8]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v32+A0]");
				obj3 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516118]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516140]");
			object obj7 = 0;
			nint num = (nint)obj7;
			Func<System.__Canon> func2 = default;
			func2._002Ector(obj3, (IntPtr)obj7);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v31+A0]");
			object obj9 = (nint)0 + (nint)8;
			obj9 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj2 = obj;
			object obj10 = 0;
			nint num2 = (nint)func2;
			func = func2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516138]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v22+10]");
		Action<System.__Canon> action = (Action<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516130]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v22+10]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v26+A0]");
				obj11 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160F0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516148]");
			object obj17 = 0;
			nint num = (nint)obj17;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj11, (IntPtr)obj17);
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v25+A0]");
			object obj19 = (nint)0 + (nint)16;
			obj19 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			action = action2;
			object obj10 = 0;
			nint num2 = (nint)action2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4098DE4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516070]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516108]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F50]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516100]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8F40]");
		object obj25 = 0;
		object obj26 = this + 288;
		Pool<NCommand> pool = default;
		nCommandPool = pool;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj27 = this + 296;
		sentReliableCommands = (List<NCommand>)(object)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int[] array = default;
		unsequencedWindow = array;
		object obj28 = this + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		commandBufferSize = 100;
		datagramEncryptedConnectionBackValue = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		EnetChannel[] array2 = default;
		channelArray = array2;
		object obj29 = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<int> queue = default;
		queue._002Ector();
		object obj30 = this + 400;
		commandsToRemove = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ConcurrentQueue<System.__Canon> concurrentQueue = default;
		concurrentQueue._002Ector();
		object obj31 = this + 408;
		CommandQueue = (ConcurrentQueue<NCommand>)(object)concurrentQueue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ConcurrentQueue<System.__Canon> concurrentQueue2 = default;
		concurrentQueue2._002Ector();
		object obj32 = this + 416;
		AckQueue = (ConcurrentQueue<NCommand>)(object)concurrentQueue2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		fragmentLength = 0;
		fragmentLengthMtuValue = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj33 = default;
		obj33._002Ector();
		object obj34 = this + 440;
		datagramAccessLockObject = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int[] array3 = default;
		gapBlocks = array3;
		object obj35 = this + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516078]");
		object obj36 = 0;
		List<System.__Canon> list2 = default;
		list2._002Ector(32);
		object obj37 = this + 464;
		toRemove = (List<NCommand>)(object)list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
		object obj39 = 0;
		List<int> list3 = default;
		list3._002Ector(32);
		object obj40 = this + 472;
		toRemoveIndices = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v52+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516110]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v56+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj43 = obj42;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v56+A0]");
		object obj44 = 0;
		object obj45 = this + 232;
		obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal unsafe override bool IsTransportEncrypted()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		//IL_0030: Expected Obj, but got I4
		int num = Interlocked.CompareExchange(ref *(int*)(this + 384), 1, 1);
		object obj = num - 1;
		return obj == null;
	}

	internal unsafe override void Reset()
	{
		//IL_0012: Expected I, but got Obj
		//IL_005d: Expected Obj, but got I4
		//IL_0dc2: Expected Obj, but got I4
		//IL_01be: Expected I4, but got I8
		//IL_0ee6: Expected Obj, but got I4
		//IL_01ac: Expected I4, but got I8
		//IL_007d: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0267: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Ref, but got Unknown
		//IL_03b9: Expected Obj, but got I4
		//IL_03ce: Expected Obj, but got Ref
		//IL_03ea: Expected Obj, but got I4
		//IL_041b: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got Ref
		//IL_056a: Expected Obj, but got I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I4
		//IL_05d8: Expected Obj, but got Ref
		//IL_05f4: Expected Obj, but got I4
		//IL_0f0d: Expected Obj, but got I4
		//IL_0626: Expected Obj, but got I4
		//IL_0d39: Expected Obj, but got I4
		//IL_0d4e: Expected Obj, but got Ref
		//IL_0d60: Expected Obj, but got I4
		//IL_0d65: Expected I, but got Obj
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected Obj, but got Unknown
		//IL_0f4a: Expected Obj, but got I
		//IL_0f7e: Expected Obj, but got I4
		//IL_0fa4: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I
		//IL_04b5: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I4
		//IL_04e7: Expected I, but got Obj
		//IL_04f9: Expected I, but got Obj
		//IL_0888: Expected Obj, but got I4
		//IL_089d: Expected Obj, but got Ref
		//IL_08b9: Expected Obj, but got I4
		//IL_09c4: Expected Obj, but got I4
		//IL_09e3: Expected Obj, but got I4
		//IL_09f8: Expected Obj, but got Ref
		//IL_0a14: Expected Obj, but got I4
		//IL_0908: Expected I, but got Obj
		//IL_0950: Expected Obj, but got I4
		//IL_0965: Expected Obj, but got Ref
		//IL_0981: Expected Obj, but got I4
		//IL_0785: Expected Obj, but got I4
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected Obj, but got Unknown
		//IL_0a9b: Expected Obj, but got I4
		//IL_0ab0: Expected Obj, but got Ref
		//IL_0ac2: Expected Obj, but got I4
		//IL_0ad4: Expected I, but got Obj
		//IL_0709: Expected I, but got Obj
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07e7: Expected Obj, but got I4
		//IL_0b28: Expected Obj, but got I4
		//IL_0b30: Expected I4, but got Obj
		//IL_0b04: Expected Obj, but got I4
		//IL_0b09: Expected I, but got Obj
		//IL_0b58: Expected Obj, but got I4
		//IL_0b60: Expected I4, but got Obj
		//IL_0b95: Expected Obj, but got I
		//IL_0b9f: Expected I, but got Obj
		//IL_0ba7: Expected I4, but got Obj
		//IL_0fd2: Expected Obj, but got Ref
		//IL_0bf1: Expected I4, but got Obj
		//IL_0bfa: Expected Obj, but got I4
		//IL_0c0f: Expected Obj, but got Ref
		//IL_0bcc: Expected Obj, but got I4
		//IL_0bd1: Expected I, but got Obj
		base.Reset();
		PhotonPeer photonPeer = base.photonPeer;
		bool flag = base.photonPeer == null;
		object obj = null;
		bool lockTaken = false;
		int num3 = default;
		bool flag4;
		nint num;
		if (!flag)
		{
			num = (nint)photonPeer.PayloadEncryptionSecret;
			bool flag2 = photonPeer.PayloadEncryptionSecret == null;
			int num2 = num3;
			PeerBase peerBase = this;
			if (!flag2)
			{
				bool flag3 = usedTransportProtocol == 0;
				object obj2 = !flag3;
				num2 = num3;
				peerBase = this;
				if (obj2 == null)
				{
					nint num4 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v69 (Il2CppClass<Photon.Client.EnetPeer>)+268]");
					flag4 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v69 (Il2CppClass<Photon.Client.EnetPeer>)+270]");
					num2 = 0;
					peerBase = (PeerBase)((Enum)(object)this).System_002EIConvertible_002EToInt32((IFormatProvider)(object)photonPeer.PayloadEncryptionSecret);
					photonPeer = base.photonPeer;
					bool flag5 = base.photonPeer == null;
					obj = null;
					lockTaken = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v69 (Il2CppClass<Photon.Client.EnetPeer>)+270]");
					num3 = 0;
					if (flag5)
					{
						goto IL_0d6a;
					}
				}
			}
			if (photonPeer.Encryptor != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				photonPeer = base.photonPeer;
				isEncryptionAvailable = true;
				bool flag6 = base.photonPeer == null;
				obj = null;
				lockTaken = false;
				num3 = num2;
				flag4 = true;
				if (flag6)
				{
					goto IL_0d6a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516188]");
			flag4 = false;
			short num5 = (short)(photonPeer.EnableServerTracing__BackingField ? 4294967294L : (4294967294L + 1));
			bool value = ((bool*)(flag4 ? 1 : 0))->m_value;
			peerID = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v49 (System.Boolean)+E4]");
			bool flag7 = (nint)0 == 0;
			object obj3 = !flag7;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num6 = TPeer.ThreadSafeRandom.Next();
			byte[] array = udpBuffer;
			challenge = num6;
			if (udpBuffer != null)
			{
				bool flag8 = base.photonPeer == null;
				obj = null;
				lockTaken = false;
				num3 = num2;
				if (flag8)
				{
					goto IL_0d6a;
				}
				int maximumTransferUnit = base.photonPeer.MaximumTransferUnit;
				bool flag9 = maximumTransferUnit == array.Length;
				num = unchecked((nint)null);
				if (flag9)
				{
					goto IL_02fc;
				}
			}
			bool flag10 = base.photonPeer == null;
			obj = null;
			lockTaken = false;
			num3 = num2;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj4 = 0;
				int maximumTransferUnit2 = base.photonPeer.MaximumTransferUnit;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				byte[] array2 = default;
				udpBuffer = array2;
				object obj5 = this + 344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				goto IL_02fc;
			}
		}
		goto IL_0d6a;
		IL_0dd5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0de3;
		IL_0d94:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0da3;
		IL_0d86:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_0d94;
		IL_0dc7:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0dd5;
		IL_0507:
		EnetChannel[] array3 = channelArray;
		bool flag11 = channelArray == null;
		object obj6 = null;
		bool lockTaken2 = false;
		object obj7 = 0;
		OutOfMemoryException ex4 = null;
		bool flag12 = (byte)(&obj) != 0;
		object obj8 = (object)(&lockTaken);
		obj = channelArray;
		lockTaken = false;
		object obj9 = 0;
		num3 = 0;
		flag4 = (byte)(&obj) != 0;
		if (flag11)
		{
			goto IL_0db1;
		}
		PhotonPeer photonPeer2 = base.photonPeer;
		bool flag13 = base.photonPeer == null;
		obj6 = null;
		lockTaken2 = false;
		byte b = default;
		EnetChannel enetChannel = (EnetChannel)b;
		obj7 = 0;
		ex4 = null;
		flag12 = (byte)(&obj) != 0;
		obj8 = (object)(&lockTaken);
		obj = channelArray;
		lockTaken = false;
		obj9 = 0;
		num3 = 0;
		flag4 = (byte)(&obj) != 0;
		object obj11 = default;
		byte b2;
		EnetChannel enetChannel4 = default;
		IndexOutOfRangeException ex6 = default;
		NullReferenceException ex5;
		if (!flag13)
		{
			EnetChannel enetChannel2 = (EnetChannel)(photonPeer2.ChannelCount + 1);
			if ((nint)enetChannel2 != array3.Length)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516108]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				photonPeer2 = base.photonPeer;
				bool flag14 = base.photonPeer == null;
				int num7 = 0;
				if (flag14)
				{
					goto IL_0829;
				}
				EnetChannel[] array4 = default;
				array3 = array4;
			}
			obj11 = array3 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516178]");
			object obj12 = 0;
			object obj13 = obj11;
			b2 = 0;
			int num8 = 0;
			EnetChannel enetChannel3 = enetChannel2;
			EnetChannel enetChannel5 = default;
			while (true)
			{
				enetChannel4 = (EnetChannel)photonPeer2.ChannelCount;
				ex5 = (NullReferenceException)obj12;
				bool flag15 = b2 < photonPeer2.ChannelCount;
				object obj14 = !flag15;
				object obj15 = obj13;
				int num7 = num8;
				enetChannel2 = enetChannel3;
				if (obj14 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				enetChannel5._002Ector(b2, commandBufferSize);
				nint num9;
				nint num11;
				if (array3 != null)
				{
					bool flag16 = enetChannel5 == null;
					num9 = (int)b2;
					if (!flag16)
					{
						nint num10 = (nint)array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v53 (Il2CppClass<Photon.Client.EnetChannel[]>)+40]");
						num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag17 = ex6 == null;
						enetChannel4 = enetChannel5;
						obj15 = obj13;
						num3 = commandBufferSize;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v53 (Il2CppClass<Photon.Client.EnetChannel[]>)+40]");
						num11 = 0;
						if (flag17)
						{
							goto IL_0d15;
						}
					}
					bool flag18 = b2 < array3.Length;
					object obj16 = !flag18;
					if (obj16 == null)
					{
						obj13 = enetChannel5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						photonPeer2 = base.photonPeer;
						b2++;
						obj15 = obj13 + 8;
						bool flag19 = base.photonPeer == null;
						object obj17 = !flag19;
						enetChannel4 = enetChannel5;
						num7 = commandBufferSize;
						enetChannel2 = enetChannel5;
						obj13 = obj15;
						num8 = commandBufferSize;
						enetChannel3 = enetChannel5;
						if (obj17 != null)
						{
							continue;
						}
						goto IL_0829;
					}
				}
				else
				{
					NullReferenceException ex7 = new NullReferenceException();
					num9 = (int)b2;
				}
				IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
				num3 = commandBufferSize;
				num11 = num9;
				goto IL_0cf9;
			}
			goto IL_0837;
		}
		goto IL_0dc7;
		IL_0837:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EnetChannel enetChannel6 = default;
		enetChannel6._002Ector(255, commandBufferSize);
		bool flag20 = array3 == null;
		obj6 = null;
		lockTaken2 = false;
		enetChannel = enetChannel6;
		obj7 = 0;
		ex4 = null;
		flag12 = (byte)(&obj) != 0;
		obj8 = (object)(&lockTaken);
		obj = channelArray;
		lockTaken = false;
		obj9 = 0;
		num3 = commandBufferSize;
		num = 255;
		if (flag20)
		{
			goto IL_0dd5;
		}
		bool flag21 = enetChannel6 == null;
		nint num12 = 255;
		IndexOutOfRangeException ex9 = default;
		if (!flag21)
		{
			nint num13 = (nint)array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v58 (Il2CppClass<Photon.Client.EnetChannel[]>)+40]");
			num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag22 = ex9 == null;
			obj6 = null;
			lockTaken2 = false;
			enetChannel = enetChannel6;
			obj7 = 0;
			ex4 = null;
			flag12 = (byte)(&obj) != 0;
			obj8 = (object)(&lockTaken);
			obj = channelArray;
			lockTaken = false;
			obj9 = 0;
			num3 = commandBufferSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v58 (Il2CppClass<Photon.Client.EnetChannel[]>)+40]");
			num = 0;
			if (flag22)
			{
				goto IL_0df1;
			}
		}
		bool flag23 = (nint)enetChannel4 < array3.Length;
		object obj18 = !flag23;
		obj6 = null;
		lockTaken2 = false;
		enetChannel = enetChannel6;
		obj7 = 0;
		ex4 = null;
		flag12 = (byte)(&obj) != 0;
		obj8 = (object)(&lockTaken);
		obj = channelArray;
		lockTaken = false;
		obj9 = 0;
		num3 = commandBufferSize;
		num = num12;
		if (obj18 == null)
		{
			object obj19 = (object)array3 + (object)enetChannel4;
			object obj20 = obj11 + (object)enetChannel4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			channelArray = array3;
			object obj21 = this + 392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj6 = null;
			lockTaken2 = false;
			enetChannel = enetChannel6;
			obj7 = 0;
			ex4 = null;
			flag12 = (byte)(&obj) != 0;
			obj8 = (object)(&lockTaken);
			lockTaken = false;
			obj9 = 0;
			num3 = commandBufferSize;
			num = (nint)array3;
			if (obj8 != null)
			{
				Monitor.Exit(((bool*)(flag12 ? 1 : 0))->m_value);
				num = unchecked((nint)null);
			}
			bool flag24 = ex4 == null;
			object obj22 = !flag24;
			b = (byte)(int)enetChannel;
			if (obj22 == null)
			{
				bool flag25 = obj7 == null;
				object obj23 = !flag25;
				b = (byte)(int)enetChannel;
				ex2 = ex4;
				if (obj23 != null)
				{
					goto IL_0d94;
				}
				Monitor.Enter(sentReliableCommands, ref lockTaken2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160C0]");
				object obj24 = 0;
				num = (nint)nCommandPool;
				num3 = (int)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726B48");
				object obj25 = (object)(&lockTaken2);
				if (obj25 != null)
				{
					bool flag26 = (byte)(&obj6) != 0;
					Monitor.Exit(((bool*)(flag26 ? 1 : 0))->m_value);
					num = unchecked((nint)null);
				}
				obj6 = sentReliableCommands;
				lockTaken2 = false;
				b = (byte)(int)enetChannel;
				obj7 = 0;
				ex4 = null;
				flag12 = (byte)(&obj6) != 0;
				obj8 = (object)(&lockTaken2);
				flag4 = (byte)(&obj6) != 0;
			}
			goto IL_0d86;
		}
		goto IL_0de3;
		IL_0d6a:
		NullReferenceException ex10 = new NullReferenceException();
		obj6 = null;
		lockTaken2 = false;
		goto IL_0d86;
		IL_0d07:
		ex6 = new IndexOutOfRangeException();
		goto IL_0d15;
		IL_0cf9:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0d07;
		IL_0d15:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex12 = new ArgumentNullException();
		b = b2;
		obj7 = 0;
		ex4 = null;
		flag12 = (byte)(&obj) != 0;
		obj8 = (object)(&lockTaken);
		lockTaken = false;
		obj9 = 0;
		num = unchecked((nint)null);
		goto IL_0d6a;
		IL_0db1:
		NullReferenceException ex13 = new NullReferenceException();
		enetChannel = (EnetChannel)b;
		goto IL_0dc7;
		IL_0df1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex14 = new ArgumentNullException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0da3:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_0db1;
		IL_0829:
		ex5 = new NullReferenceException();
		goto IL_0837;
		IL_0de3:
		ex9 = new IndexOutOfRangeException();
		goto IL_0df1;
		IL_02fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516180]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726AD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726AD0");
		int num14 = Interlocked.CompareExchange(ref *(int*)(this + 384), 0, 1);
		timeoutInt = 0;
		outgoingUnsequencedGroupNumber = 0;
		MoveUnsequencedWindowTo(0);
		unsequencedGroupsDroppedInARow = 0;
		Monitor.Enter(channelArray, ref lockTaken);
		EnetChannel[] array5 = channelArray;
		bool flag27 = channelArray == null;
		obj6 = null;
		lockTaken2 = false;
		obj7 = 0;
		ex4 = null;
		flag12 = (byte)(&obj) != 0;
		obj8 = (object)(&lockTaken);
		obj = channelArray;
		lockTaken = false;
		obj9 = 0;
		num3 = 0;
		flag4 = (byte)(&obj) != 0;
		num = (nint)(&lockTaken);
		if (!flag27)
		{
			object obj27 = array5.Length;
			bool flag28 = array5.Length < 1;
			num = (nint)(&lockTaken);
			if (flag28)
			{
				goto IL_0507;
			}
			object obj15 = channelArray + 32;
			b2 = 0;
			nint num11 = (nint)(&lockTaken);
			while (true)
			{
				bool flag29 = (int)b2 < (nint)obj27;
				object obj28 = !flag29;
				num3 = 0;
				flag4 = (byte)(&obj) != 0;
				if (obj28 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X22_v19+v76 @ X21_v12 (System.Byte)*8]");
				bool flag30 = (nint)0 == 0;
				num3 = 0;
				flag4 = (byte)(&obj) != 0;
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X22_v19+v76 @ X21_v12 (System.Byte)*8]");
					((EnetChannel)0).clearAll(nCommandPool);
					obj27 = array5.Length;
					b = (byte)(b2 + 1);
					bool flag31 = b < array5.Length;
					num = (nint)nCommandPool;
					b2 = b;
					num11 = (nint)nCommandPool;
					if (flag31)
					{
						continue;
					}
					goto IL_0507;
				}
				goto IL_0cf9;
			}
			goto IL_0d07;
		}
		goto IL_0da3;
	}

	internal unsafe void ApplyRandomizedSequenceNumbers()
	{
		//IL_0033: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got Ref
		//IL_040c: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got Ref
		//IL_0434: Expected Obj, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got Ref
		//IL_02bb: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got Ref
		//IL_020f: Expected Obj, but got Ref
		//IL_0218: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got Ref
		bool lockTaken = default;
		Monitor.Enter(channelArray, ref lockTaken);
		EnetChannel[] array = channelArray;
		bool flag = channelArray == null;
		object obj = 0;
		int num = (int)(&lockTaken);
		object obj3;
		OutOfMemoryException ex;
		NullReferenceException ex2 = default;
		if (!flag)
		{
			object obj2 = 0;
			obj = 0;
			num = (int)(&lockTaken);
			bool flag2 = (nint)obj2 >= array.Length;
			obj3 = 0;
			ex = null;
			if (flag2)
			{
				goto IL_03ae;
			}
			bool flag3 = (nint)obj2 < array.Length;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				PhotonPeer photonPeer = base.photonPeer;
				if (base.photonPeer == null)
				{
					goto IL_02f2;
				}
				byte[] randomizedSequenceNumbers = photonPeer.RandomizedSequenceNumbers;
				if (photonPeer.RandomizedSequenceNumbers == null)
				{
					goto IL_0300;
				}
				object obj5 = obj2 / randomizedSequenceNumbers.Length;
				object obj6 = obj5 * randomizedSequenceNumbers.Length;
				object obj7 = obj2 - obj6;
				bool flag4 = (nint)obj7 < randomizedSequenceNumbers.Length;
				object obj8 = !flag4;
				if (obj8 != null)
				{
					goto IL_030e;
				}
				object obj9 = (object)array + obj2;
				object obj10 = (object)photonPeer.RandomizedSequenceNumbers + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v22+20]");
				bool lockTaken2 = default;
				Monitor.Enter(0, ref lockTaken2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v22+20]");
				object obj14;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v22+20]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v16+20]");
					((EnetChannel)num2).ApplySequenceNumberModifier(0);
					object obj11 = (object)(&lockTaken2);
					bool flag5 = obj11 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v16+20]");
					num = 0;
					if (!flag5)
					{
						object obj13 = default;
						object obj12 = (object)(&obj13);
						Monitor.Exit(obj12);
						num = 0;
					}
					obj14 = (object)(&lockTaken2);
					obj = 0;
					goto IL_02e4;
				}
				ex2 = new NullReferenceException();
				obj14 = (object)(&lockTaken2);
				obj = 0;
				num = (int)(&lockTaken2);
				goto IL_04a5;
			}
		}
		else
		{
			NullReferenceException ex3 = new NullReferenceException();
		}
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_02e4;
		IL_030e:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_04a5;
		IL_04a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		NullReferenceException ex6;
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj3 = 1;
			ex = null;
		}
		else
		{
			bool flag6 = num != 1;
			ex6 = ex2;
			if (flag6)
			{
				goto IL_04d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj3 = 0;
			object obj15 = default;
			ex = (OutOfMemoryException)obj15;
		}
		goto IL_03ae;
		IL_04d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0300:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_030e;
		IL_03ae:
		object obj16 = (object)(&lockTaken);
		if (obj16 != null)
		{
			object obj18 = default;
			object obj17 = (object)(&obj18);
			Monitor.Exit(obj17);
			num = 0;
		}
		bool flag7 = ex == null;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			bool flag8 = obj3 == null;
			object obj20 = !flag8;
			OutOfMemoryException ex8 = ex;
			if (obj20 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex8 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex9 = default;
		ex6 = ex9;
		goto IL_04d4;
		IL_02e4:
		OutOfMemoryException ex10 = new OutOfMemoryException();
		goto IL_02f2;
		IL_02f2:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0300;
	}

	private EnetChannel GetChannel(byte channelNumber)
	{
		//IL_0078: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I
		int num = ~channelNumber;
		int num2 = 0xFF & num;
		bool flag = num2 == 0;
		EnetChannel[] array = channelArray;
		int num3;
		if (!flag)
		{
			if (channelArray == null)
			{
				goto IL_0120;
			}
			bool flag2 = array.Length < channelNumber;
			object obj = !flag2;
			object obj2 = array.Length - channelNumber;
			bool flag3 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag3;
			if (obj4 != null)
			{
				goto IL_012e;
			}
			num3 = channelNumber & 0xFF;
		}
		else
		{
			if (channelArray == null)
			{
				goto IL_0120;
			}
			if (array.Length == 0)
			{
				goto IL_012e;
			}
			num3 = array.Length - 1;
		}
		object obj5 = channelArray + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v3+20]");
		return (EnetChannel)0;
		IL_0120:
		NullReferenceException ex = new NullReferenceException();
		goto IL_012e;
		IL_012e:
		return (EnetChannel)(object)new IndexOutOfRangeException();
	}

	internal unsafe override bool Connect(string ipport, string proxyServerAddress, string appID, object photonToken)
	{
		//IL_00f8: Expected I4, but got Obj
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected I4, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Ref, but got Unknown
		//IL_0087: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		object obj2 = default;
		if (PhotonSocket != null)
		{
			((NetPeerGroup.List*)PhotonSocket)->FreeAll();
			object obj = obj2 & 1;
			if (obj == null)
			{
				goto IL_00d7;
			}
			int num = Interlocked.Exchange(ref *(int*)(this + 64), 1);
			if (nCommandPool != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161A0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
				NCommand nCommand = default;
				if (nCommand != null)
				{
					nCommand.Initialize(this, 2, null, 255, (ConnectionStateValue)3);
					QueueOutgoingReliableCommand(nCommand);
					goto IL_00d7;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00d7:
		return (byte)(obj2 & 1) != 0;
	}

	internal unsafe override void Disconnect(bool queueStatusChangeCallback = default(bool))
	{
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected Ref, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Ref, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Ref, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got Ref
		//IL_029a: Expected Obj, but got Ref
		//IL_02a4: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got Ref
		//IL_0102: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got Ref
		//IL_013a: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got Ref
		//IL_0158: Expected Obj, but got Ref
		//IL_0bb0: Expected Obj, but got Ref
		//IL_03e5: Expected Obj, but got I4
		//IL_03f2: Expected Obj, but got Ref
		//IL_03fa: Expected Obj, but got Ref
		//IL_0404: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got Ref
		//IL_01b0: Expected Obj, but got I4
		//IL_09f4: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got Ref
		//IL_0ad1: Expected Obj, but got I4
		//IL_0a43: Expected Obj, but got I4
		//IL_0920: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_095d: Expected Obj, but got I4
		//IL_096a: Expected Obj, but got Ref
		//IL_0972: Expected Obj, but got Ref
		//IL_0360: Expected Obj, but got I
		//IL_036a: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I4
		int num = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
		object obj;
		bool lockTaken;
		EnetPeer enetPeer;
		int num6;
		Pool<NCommand> pool;
		object obj5;
		object obj6;
		OutOfMemoryException ex;
		object obj7;
		object obj8;
		object obj4;
		if ((num & 0xFF) != 0)
		{
			int num2 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
			int num3 = num2 & 0xFF;
			if (num3 != 4)
			{
				int num4 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
				int num5 = Interlocked.Exchange(ref *(int*)(this + 64), 4);
				bool flag = sentReliableCommands == null;
				obj = null;
				lockTaken = false;
				bool lockTaken2 = false;
				object obj2 = null;
				StreamBuffer streamBuffer = null;
				enetPeer = this;
				num6 = num4;
				if (flag)
				{
					goto IL_0233;
				}
				Monitor.Enter(sentReliableCommands, ref lockTaken2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160C0]");
				object obj3 = 0;
				pool = nCommandPool;
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726B48");
				obj = null;
				lockTaken = false;
				obj5 = 7;
				obj6 = 0;
				ex = null;
				obj7 = (object)(&obj2);
				obj8 = (object)(&lockTaken2);
				lockTaken2 = false;
				obj2 = sentReliableCommands;
				streamBuffer = null;
				enetPeer = this;
				num6 = num4;
				goto IL_0b83;
			}
			return;
		}
		return;
		IL_0233:
		Monitor.Enter(enetPeer.channelArray, ref lockTaken);
		EnetChannel[] array = enetPeer.channelArray;
		bool flag2 = enetPeer.channelArray == null;
		obj = enetPeer.channelArray;
		lockTaken = false;
		obj6 = 0;
		ex = null;
		obj7 = (object)(&obj);
		obj8 = (object)(&lockTaken);
		obj4 = 0;
		Pool<NCommand> pool2 = (Pool<NCommand>)(&lockTaken);
		if (!flag2)
		{
			object obj9 = array.Length;
			bool flag3 = array.Length < 1;
			pool2 = (Pool<NCommand>)(&lockTaken);
			if (!flag3)
			{
				object obj10 = enetPeer.channelArray + 32;
				bool flag4 = false;
				Pool<NCommand> pool3 = (Pool<NCommand>)(&lockTaken);
				while (true)
				{
					bool flag5 = (flag4 ? 1 : 0) < (nint)obj9;
					object obj11 = !flag5;
					bool flag6;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X24_v5+v518 @ X23_v8 (System.Boolean)*8]");
						if ((nint)0 != 0)
						{
							pool2 = enetPeer.nCommandPool;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X24_v5+v518 @ X23_v8 (System.Boolean)*8]");
							((EnetChannel)0).clearAll(enetPeer.nCommandPool);
							obj9 = array.Length;
							flag6 = (byte)((flag4 ? 1u : 0u) + 1u) != 0;
							bool flag7 = (flag6 ? 1 : 0) < array.Length;
							flag4 = flag6;
							pool3 = enetPeer.nCommandPool;
							if (!flag7)
							{
								break;
							}
							continue;
						}
						NullReferenceException ex2 = new NullReferenceException();
					}
					IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
					obj4 = 0;
					int num7 = num6;
					NullReferenceException ex4 = new NullReferenceException();
					flag6 = flag4;
					obj = enetPeer.channelArray;
					lockTaken = false;
					obj6 = 0;
					ex = null;
					obj7 = (object)(&obj);
					obj8 = (object)(&lockTaken);
					pool2 = pool3;
					num6 = num7;
					goto IL_0987;
				}
			}
			object obj12 = (object)(&lockTaken);
			if (obj12 != null)
			{
				object obj13 = (object)(&obj);
				Monitor.Exit(obj13);
				pool2 = null;
			}
			obj = enetPeer.channelArray;
			lockTaken = false;
			obj6 = 0;
			ex = null;
			obj7 = (object)(&obj);
			obj8 = (object)(&lockTaken);
			obj4 = 0;
			goto IL_0987;
		}
		goto IL_09a4;
		IL_0995:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_09a4;
		IL_09a4:
		NullReferenceException ex5 = new NullReferenceException();
		if ((nint)pool2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj6 = 1;
		}
		else
		{
			if ((nint)pool2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj14 = default;
			ex = (OutOfMemoryException)obj14;
		}
		obj5 = 0;
		pool = pool2;
		goto IL_0b83;
		IL_0b83:
		bool flag8 = obj8 == null;
		pool2 = pool;
		if (!flag8)
		{
			Monitor.Exit(obj7);
			pool2 = null;
		}
		bool flag9 = ex == null;
		object obj15 = !flag9;
		if (obj15 != null)
		{
			goto IL_0987;
		}
		bool flag10 = obj6 == null;
		object obj16 = !flag10;
		OutOfMemoryException ex6 = ex;
		if (obj16 == null)
		{
			if ((nint)obj5 != 7)
			{
				bool flag11 = obj5 == null;
				object obj17 = !flag11;
				if (obj17 != null)
				{
					return;
				}
			}
			goto IL_0233;
		}
		goto IL_0995;
		IL_0987:
		ex6 = new OutOfMemoryException();
		goto IL_0995;
	}

	internal unsafe override void SimulateTimeoutDisconnect(bool queueStatusChangeCallback = default(bool))
	{
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected Ref, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got Ref
		//IL_0265: Expected Obj, but got Ref
		//IL_026d: Expected Obj, but got Ref
		//IL_0276: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got Ref
		//IL_00c2: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got Ref
		//IL_00fa: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got Ref
		//IL_010f: Expected Obj, but got Ref
		//IL_012a: Expected Obj, but got Ref
		//IL_0133: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0bfd: Expected Obj, but got Ref
		//IL_03b7: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got Ref
		//IL_03cc: Expected Obj, but got Ref
		//IL_03d4: Expected Obj, but got Ref
		//IL_03dd: Expected Obj, but got I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02d9: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got Ref
		//IL_017b: Expected Obj, but got I4
		//IL_098e: Expected Obj, but got I4
		//IL_0385: Expected Obj, but got Ref
		//IL_0a6b: Expected Obj, but got I4
		//IL_09e5: Expected Obj, but got I4
		//IL_08e0: Expected Obj, but got I4
		//IL_08ed: Expected Obj, but got Ref
		//IL_08f5: Expected Obj, but got Ref
		//IL_08fd: Expected Obj, but got Ref
		//IL_0906: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I4
		int num = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
		object obj;
		bool lockTaken;
		EnetPeer enetPeer;
		Pool<NCommand> pool;
		object obj6;
		OutOfMemoryException ex;
		object obj7;
		object obj8;
		object obj10;
		object obj9;
		object obj5;
		if ((num & 0xFF) != 0)
		{
			int num2 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
			int num3 = num2 & 0xFF;
			if (num3 != 4)
			{
				bool flag = sentReliableCommands == null;
				obj = null;
				lockTaken = false;
				bool lockTaken2 = false;
				object obj2 = null;
				object obj3 = 0;
				enetPeer = this;
				bool flag2 = queueStatusChangeCallback;
				if (flag)
				{
					goto IL_01fe;
				}
				Monitor.Enter(sentReliableCommands, ref lockTaken2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65160C0]");
				object obj4 = 0;
				pool = nCommandPool;
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726B48");
				obj = null;
				lockTaken = false;
				obj6 = 0;
				ex = null;
				obj7 = (object)(&obj2);
				obj8 = (object)(&lockTaken2);
				lockTaken2 = false;
				obj2 = sentReliableCommands;
				obj9 = (object)(&obj2);
				obj3 = 0;
				enetPeer = this;
				flag2 = queueStatusChangeCallback;
				obj10 = 7;
				goto IL_0bd0;
			}
			return;
		}
		return;
		IL_01fe:
		Monitor.Enter(enetPeer.channelArray, ref lockTaken);
		EnetChannel[] array = enetPeer.channelArray;
		bool flag3 = enetPeer.channelArray == null;
		obj = enetPeer.channelArray;
		lockTaken = false;
		obj6 = 0;
		ex = null;
		obj7 = (object)(&obj);
		obj8 = (object)(&lockTaken);
		obj9 = (object)(&obj);
		obj5 = 0;
		Pool<NCommand> pool2 = (Pool<NCommand>)(&lockTaken);
		if (!flag3)
		{
			object obj11 = array.Length;
			bool flag4 = array.Length < 1;
			pool2 = (Pool<NCommand>)(&lockTaken);
			if (!flag4)
			{
				object obj12 = enetPeer.channelArray + 32;
				object obj13 = 0;
				Pool<NCommand> pool3 = (Pool<NCommand>)(&lockTaken);
				while (true)
				{
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
					object obj14 = !flag5;
					object obj15;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X23_v5+v442 @ X22_v11*8]");
						if ((nint)0 != 0)
						{
							pool2 = enetPeer.nCommandPool;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X23_v5+v442 @ X22_v11*8]");
							((EnetChannel)0).clearAll(enetPeer.nCommandPool);
							obj11 = array.Length;
							obj15 = obj13 + 1;
							bool flag6 = (nint)obj15 < array.Length;
							obj13 = obj15;
							pool3 = enetPeer.nCommandPool;
							if (!flag6)
							{
								break;
							}
							continue;
						}
						NullReferenceException ex2 = new NullReferenceException();
					}
					IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
					obj15 = obj13;
					obj = enetPeer.channelArray;
					lockTaken = false;
					obj6 = 0;
					ex = null;
					obj7 = (object)(&obj);
					obj8 = (object)(&lockTaken);
					obj9 = (object)(&obj);
					obj5 = 0;
					pool2 = pool3;
					goto IL_0913;
				}
			}
			object obj16 = (object)(&lockTaken);
			if (obj16 != null)
			{
				object obj17 = (object)(&obj);
				Monitor.Exit(obj17);
				pool2 = null;
			}
			obj = enetPeer.channelArray;
			lockTaken = false;
			obj6 = 0;
			ex = null;
			obj7 = (object)(&obj);
			obj8 = (object)(&lockTaken);
			obj9 = (object)(&obj);
			obj5 = 0;
			goto IL_0913;
		}
		goto IL_093e;
		IL_0921:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_093e;
		IL_093e:
		NullReferenceException ex5 = new NullReferenceException();
		if ((nint)pool2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj6 = 1;
		}
		else
		{
			if ((nint)pool2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj18 = default;
			ex = (OutOfMemoryException)obj18;
		}
		pool = pool2;
		obj10 = 0;
		goto IL_0bd0;
		IL_0bd0:
		bool flag7 = obj8 == null;
		pool2 = pool;
		if (!flag7)
		{
			Monitor.Exit(obj7);
			pool2 = null;
		}
		bool flag8 = ex == null;
		object obj19 = !flag8;
		if (obj19 != null)
		{
			goto IL_0913;
		}
		bool flag9 = obj6 == null;
		object obj20 = !flag9;
		OutOfMemoryException ex6 = ex;
		if (obj20 == null)
		{
			if ((nint)obj10 != 7)
			{
				bool flag10 = obj10 == null;
				object obj21 = !flag10;
				if (obj21 != null)
				{
					return;
				}
			}
			goto IL_01fe;
		}
		goto IL_0921;
		IL_0913:
		ex6 = new OutOfMemoryException();
		goto IL_0921;
	}

	internal unsafe override void FetchServerTimestamp()
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Ref, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Ref, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		int num = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
		int num2 = num & 0xFF;
		if (num2 == 3 && ~(ApplicationIsInitialized ? 1u : 0u) == 0)
		{
			bool flag = CreateAndEnqueueCommand(12, null, 255);
			return;
		}
		PhotonPeer photonPeer = base.photonPeer;
		bool flag2 = (int)photonPeer.LogLevel < 3;
		object obj = !flag2;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			int num3 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161E8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161F0]");
			object format = 0;
			object arg = default;
			string debugReturn = string.Format((string)format, arg);
			EnqueueDebugReturn((LogLevel)3, debugReturn);
		}
	}

	private static bool IsAckCommand(byte commandType)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		int num = commandType & 0xFF;
		object obj = num - 1;
		bool flag = obj == null;
		int num2 = commandType & 0xFC;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = num2 - 16;
			return obj4 == null;
		}
		return true;
	}

	private void DispatchCommandQueue()
	{
		//IL_003b: Expected Obj, but got I4
		ConcurrentQueue<System.__Canon> commandQueue = (ConcurrentQueue<System.__Canon>)(object)CommandQueue;
		System.__Canon result;
		while (commandQueue.TryDequeue(out result))
		{
			ExecuteCommand((NCommand)(object)result);
			commandQueue = (ConcurrentQueue<System.__Canon>)(object)CommandQueue;
			bool flag = CommandQueue == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	private void DispatchAckQueue()
	{
		//IL_003b: Expected Obj, but got I4
		ConcurrentQueue<System.__Canon> ackQueue = (ConcurrentQueue<System.__Canon>)(object)AckQueue;
		System.__Canon result;
		while (ackQueue.TryDequeue(out result))
		{
			ExecuteCommand((NCommand)(object)result);
			ackQueue = (ConcurrentQueue<System.__Canon>)(object)AckQueue;
			bool flag = AckQueue == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	internal unsafe override bool DispatchIncomingCommands()
	{
		//IL_0ebc: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_014e: Expected VT, but got Ref
		//IL_0ed4: Expected VT, but got Ref
		//IL_0edd: Invalid comparison between VT and I4
		//IL_002f: Expected I4, but got Obj
		//IL_0092: Expected Obj, but got I4
		//IL_009a: Expected VT, but got Ref
		//IL_0072: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65162E0]");
		object obj = 0;
		DispatchCommandQueue();
		System.__Canon _Canon = null;
		bool lockTaken = default;
		Monitor.Enter(ActionQueue, ref lockTaken);
		Queue<System.__Canon> actionQueue = (Queue<System.__Canon>)(object)ActionQueue;
		object obj4;
		NonAllocDictionary<int, System.__Canon>.KeyIterator keyIterator2;
		int num;
		if ((object)ActionQueue != null)
		{
			if (actionQueue._size >= 1)
			{
				num = (int)obj;
				System.__Canon _Canon2 = ((Queue<System.__Canon>)(object)ActionQueue).Dequeue();
				_Canon = _Canon2;
				int num2 = 6;
			}
			else
			{
				num = (int)(&lockTaken);
				int num2 = 5;
			}
			NonAllocDictionary<int, System.__Canon>.KeyIterator keyIterator = (NonAllocDictionary<int, System.__Canon>.KeyIterator)(&lockTaken);
			if (keyIterator != (NonAllocDictionary<int, System.__Canon>.KeyIterator)(object)0)
			{
				object obj3 = default;
				System.__Canon obj2 = (System.__Canon)(&obj3);
				Monitor.Exit(obj2);
				num = 0;
			}
			obj4 = 0;
			keyIterator2 = (NonAllocDictionary<int, System.__Canon>.KeyIterator)(&lockTaken);
			OutOfMemoryException ex = new OutOfMemoryException();
			throw new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj4 = 0;
		keyIterator2 = (NonAllocDictionary<int, System.__Canon>.KeyIterator)(&lockTaken);
		num = (int)(&lockTaken);
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB260");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
	}

	private unsafe int GetFragmentLength()
	{
		//IL_0269: Expected I4, but got Obj
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Ref, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		if (fragmentLength != 0)
		{
			if (base.photonPeer == null)
			{
				goto IL_025b;
			}
			int maximumTransferUnit = base.photonPeer.MaximumTransferUnit;
			if (maximumTransferUnit == fragmentLengthMtuValue)
			{
				goto IL_0288;
			}
		}
		PhotonPeer photonPeer;
		int num3 = default;
		if (base.photonPeer != null)
		{
			int maximumTransferUnit2 = base.photonPeer.MaximumTransferUnit;
			fragmentLengthMtuValue = maximumTransferUnit2;
			if (base.photonPeer != null)
			{
				int maximumTransferUnit3 = base.photonPeer.MaximumTransferUnit;
				photonPeer = base.photonPeer;
				int num = maximumTransferUnit3 - 48;
				fragmentLength = num;
				if (base.photonPeer != null)
				{
					IPhotonEncryptor encryptor = photonPeer.Encryptor;
					if (photonPeer.Encryptor != null)
					{
						nint num2 = (nint)encryptor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49E0]");
						object obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_01cb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+98]");
						object obj3 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X10_v10-8]");
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
							goto IL_01cb;
						}
						object obj4 = obj3 + 6;
						object obj5 = num2 + obj4;
						object obj6 = obj5 + 312;
						goto IL_02ee;
					}
					num3 = 0;
					goto IL_0230;
				}
			}
		}
		goto IL_025b;
		IL_01cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_02ee;
		IL_0288:
		int num4 = Interlocked.CompareExchange(ref *(int*)(this + 384), 1, 1);
		if (num4 == 1)
		{
			object obj7 = 428;
		}
		else
		{
			object obj7 = 424;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.EnetPeer)+v196 @ X8_v6]");
		return 0;
		IL_025b:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_02ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X0_v15] (should have been resolved before IL gen)");
		if (photonPeer.Encryptor != null && this != null)
		{
			goto IL_0230;
		}
		goto IL_025b;
		IL_0230:
		fragmentLengthDatagramEncrypt = num3;
		goto IL_0288;
	}

	private bool IsOutgoingDatagramFull()
	{
		//IL_00e6: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected I4, but got Unknown
		int inSize = udpBufferIndex + 12;
		int num = CalculatePacketSize(inSize);
		if (photonPeer != null)
		{
			int maximumTransferUnit = photonPeer.MaximumTransferUnit;
			object obj = num - maximumTransferUnit;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num2 = num ^ maximumTransferUnit;
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			return (byte)((flag4 & obj2) ? 1 : 0) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private int CalculatePacketSize(int inSize)
	{
		//IL_0151: Expected I4, but got Obj
		//IL_0065: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		if (~(udpBufferEncryptedLayout ? 1u : 0u) == 0)
		{
			PhotonPeer photonPeer = base.photonPeer;
			if (base.photonPeer != null)
			{
				IPhotonEncryptor encryptor = photonPeer.Encryptor;
				if (photonPeer.Encryptor != null)
				{
					nint num = (nint)encryptor;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49E0]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0101;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+98]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v7-8]");
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
						goto IL_0101;
					}
					object obj4 = obj3 + 5;
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					goto IL_018e;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		return inSize;
		IL_018e:
		object obj7 = inSize + 7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v168 @ X0_v4] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0101:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_018e;
	}

	private int CalculateInitialOffset()
	{
		//IL_00b0: Expected I4, but got Obj
		//IL_006f: Expected Obj, but got I4
		if (~(udpBufferEncryptedLayout ? 1u : 0u) == 0)
		{
			return 5;
		}
		if (photonPeer != null)
		{
			bool crcEnabled = photonPeer.CrcEnabled;
			bool flag = !crcEnabled;
			object obj = !flag;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return 16;
			}
			return 12;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	internal override bool SendAcksOnly()
	{
		return SendOutgoingCommands(sendAcksOnly: true);
	}

	internal override bool SendOutgoingCommands()
	{
		return SendOutgoingCommands(sendAcksOnly: false);
	}

	internal unsafe bool SendOutgoingCommands(bool sendAcksOnly)
	{
		//IL_459a: Unknown result type (might be due to invalid IL or missing references)
		//IL_459f: Expected Ref, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0080: Expected I4, but got Obj
		//IL_407d: Expected I4, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Ref, but got Unknown
		//IL_018e: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got Ref
		//IL_0231: Expected Obj, but got Ref
		//IL_024c: Expected Obj, but got Ref
		//IL_028a: Expected I4, but got I8
		//IL_40be: Expected I4, but got Obj
		//IL_02e2: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got Ref
		//IL_0313: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got Ref
		//IL_032c: Expected Obj, but got Ref
		//IL_0347: Expected Obj, but got Ref
		//IL_40e2: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got Ref
		//IL_0449: Expected Obj, but got I4
		//IL_0452: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got Ref
		//IL_0462: Expected Obj, but got Ref
		//IL_04ef: Expected Obj, but got I4
		//IL_0506: Expected Obj, but got I4
		//IL_051b: Expected Obj, but got Ref
		//IL_0537: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_0548: Expected Obj, but got Ref
		//IL_0550: Expected Obj, but got Ref
		//IL_2357: Expected Obj, but got I4
		//IL_486b: Expected Obj, but got Ref
		//IL_05ba: Expected Obj, but got I4
		//IL_05c2: Expected Obj, but got I4
		//IL_061e: Expected Obj, but got I4
		//IL_0633: Expected Obj, but got Ref
		//IL_064f: Expected Obj, but got I4
		//IL_0658: Expected Obj, but got I4
		//IL_0660: Expected Obj, but got Ref
		//IL_0668: Expected Obj, but got Ref
		//IL_0683: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I4
		//IL_41a2: Expected Obj, but got I4
		//IL_41c6: Expected Obj, but got I4
		//IL_41ea: Expected I4, but got Obj
		//IL_41f2: Expected Obj, but got I4
		//IL_41fa: Expected I4, but got Obj
		//IL_4234: Expected Obj, but got I4
		//IL_42c6: Expected I4, but got Obj
		//IL_4316: Expected I4, but got Obj
		//IL_431e: Expected Obj, but got I4
		//IL_43a7: Expected Obj, but got I4
		//IL_4406: Expected Obj, but got I4
		//IL_4435: Expected Obj, but got I4
		//IL_3c5b: Expected Obj, but got I4
		//IL_3c6b: Expected Obj, but got I4
		//IL_3c33: Expected Obj, but got I4
		//IL_453a: Expected Obj, but got I4
		//IL_3c93: Expected Obj, but got I4
		//IL_3c9b: Expected Obj, but got I4
		//IL_3cab: Expected Obj, but got I4
		//IL_3d10: Expected Obj, but got I4
		//IL_3e0c: Expected Obj, but got I4
		//IL_3e16: Expected I4, but got Obj
		//IL_3e1e: Expected Obj, but got I4
		//IL_3e5f: Expected Obj, but got I4
		//IL_3e69: Expected I4, but got Obj
		//IL_3e71: Expected Obj, but got I4
		//IL_3f28: Expected Obj, but got I4
		//IL_3f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f35: Expected I4, but got Unknown
		//IL_3f79: Expected I4, but got Obj
		int num = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
		if ((num & 0xFF) == 0)
		{
			goto IL_2340;
		}
		int num2 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
		int num3 = num2 & 0xFF;
		bool flag = num3 == 6;
		bool result = false;
		StreamBuffer streamBuffer;
		object obj7 = default;
		object obj8 = default;
		List<NCommand> list = default;
		object obj9 = default;
		object obj10 = default;
		OutOfMemoryException ex = default;
		int num8 = default;
		object obj11 = default;
		object[] array;
		PhotonSocket photonSocket;
		int num12 = default;
		int num11;
		int num10;
		List<NCommand> list2 = default;
		int num4;
		int num5;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			bool flag2 = PhotonSocket == null;
			result = (byte)(int)PhotonSocket != 0;
			if (!flag2)
			{
				photonSocket = PhotonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				bool flag3 = PhotonSocket == null;
				object obj = null;
				bool flag4 = false;
				object obj2 = null;
				bool flag5 = false;
				bool flag6 = false;
				object obj3 = null;
				object obj4 = null;
				bool lockTaken = false;
				object obj5 = null;
				bool lockTaken2 = false;
				streamBuffer = null;
				num4 = 0;
				num5 = 0;
				if (!flag3)
				{
					if (!PhotonSocket.Connected)
					{
						goto IL_2340;
					}
					Monitor.Enter(datagramAccessLockObject, ref lockTaken2);
					int num6 = Interlocked.CompareExchange(ref *(int*)(this + 384), 1, 1);
					object obj6 = num6 - 1;
					bool flag7 = obj6 == null;
					udpBufferEncryptedLayout = flag7;
					int num7 = CalculateInitialOffset();
					udpCommandCount = 0;
					udpBufferIndex = num7;
					bool flag8 = watch == null;
					obj = null;
					flag4 = false;
					obj2 = null;
					flag5 = false;
					flag6 = false;
					obj3 = null;
					obj4 = null;
					lockTaken = false;
					obj7 = 0;
					obj8 = 0;
					list = (List<NCommand>)(&obj5);
					obj9 = (object)(&lockTaken2);
					obj5 = datagramAccessLockObject;
					lockTaken2 = false;
					list2 = (List<NCommand>)(&obj5);
					streamBuffer = null;
					num4 = 1;
					num5 = 1;
					if (!flag8)
					{
						long elapsedMilliseconds = watch.ElapsedMilliseconds;
						timeIntCurrentSend = (int)elapsedMilliseconds;
						Monitor.Enter(outgoingAcknowledgementsBuffer, ref lockTaken);
						bool flag9 = outgoingAcknowledgementsBuffer == null;
						obj = null;
						flag4 = false;
						obj2 = null;
						flag5 = false;
						flag6 = false;
						obj3 = null;
						obj10 = 0;
						ex = null;
						num8 = (int)(&obj4);
						obj11 = (object)(&lockTaken);
						obj4 = outgoingAcknowledgementsBuffer;
						lockTaken = false;
						obj7 = 0;
						obj8 = 0;
						list = (List<NCommand>)(&obj5);
						obj9 = (object)(&lockTaken2);
						obj5 = datagramAccessLockObject;
						lockTaken2 = false;
						list2 = (List<NCommand>)(&obj4);
						streamBuffer = null;
						num4 = 0;
						num5 = (int)(&lockTaken);
						if (flag9)
						{
							goto IL_405e;
						}
						int length = outgoingAcknowledgementsBuffer.Length;
						if (length > 0 || useAck2)
						{
							int num9 = SerializeAckToBuffer();
							PhotonPeer photonPeer = base.photonPeer;
							bool flag10 = base.photonPeer == null;
							obj = null;
							flag4 = false;
							obj2 = null;
							flag5 = false;
							flag6 = false;
							obj3 = null;
							obj10 = 0;
							ex = null;
							num8 = (int)(&obj4);
							obj11 = (object)(&lockTaken);
							obj4 = outgoingAcknowledgementsBuffer;
							lockTaken = false;
							obj7 = 0;
							obj8 = 0;
							list = (List<NCommand>)(&obj5);
							obj9 = (object)(&lockTaken2);
							obj5 = datagramAccessLockObject;
							lockTaken2 = false;
							num10 = (int)(&obj4);
							streamBuffer = null;
							num4 = 0;
							num5 = 0;
							num11 = num9;
							if (flag10)
							{
								goto IL_40d1;
							}
							TrafficStats trafficStats = photonPeer.Stats__BackingField;
							bool flag11 = photonPeer.Stats__BackingField == null;
							obj = null;
							flag4 = false;
							obj2 = null;
							flag5 = false;
							array = (object[])num12;
							flag6 = false;
							obj3 = null;
							obj10 = 0;
							ex = null;
							num8 = (int)(&obj4);
							obj11 = (object)(&lockTaken);
							obj4 = outgoingAcknowledgementsBuffer;
							lockTaken = false;
							obj7 = 0;
							obj8 = 0;
							list = (List<NCommand>)(&obj5);
							obj9 = (object)(&lockTaken2);
							obj5 = datagramAccessLockObject;
							lockTaken2 = false;
							num10 = (int)(&obj4);
							streamBuffer = null;
							num4 = 0;
							num5 = 0;
							num11 = num9;
							if (flag11)
							{
								goto IL_40e7;
							}
							num10 = timeIntCurrentSend;
							trafficStats.LastSendAckTimestamp = timeIntCurrentSend;
							object obj12 = 12;
							photonSocket = (PhotonSocket)num9;
						}
						else
						{
							object obj12 = 12;
							num10 = (int)(&obj4);
							photonSocket = null;
						}
						object obj13 = (object)(&lockTaken);
						bool flag12 = obj13 == null;
						num5 = 0;
						if (!flag12)
						{
							int num13 = (int)(&obj4);
							Monitor.Exit(((int*)num13)->m_value);
							num5 = 0;
						}
						obj = null;
						flag4 = false;
						obj2 = null;
						flag5 = false;
						flag6 = false;
						obj3 = null;
						obj10 = 0;
						ex = null;
						num8 = (int)(&obj4);
						obj11 = (object)(&lockTaken);
						obj4 = outgoingAcknowledgementsBuffer;
						lockTaken = false;
						obj7 = 0;
						obj8 = 0;
						list = (List<NCommand>)(&obj5);
						obj9 = (object)(&lockTaken2);
						obj5 = datagramAccessLockObject;
						lockTaken2 = false;
						list2 = (List<NCommand>)num10;
						streamBuffer = null;
						num4 = 0;
						goto IL_406c;
					}
				}
				else
				{
					NullReferenceException ex2 = new NullReferenceException();
				}
				NullReferenceException ex3 = new NullReferenceException();
				goto IL_405e;
			}
		}
		goto IL_45e1;
		IL_40e7:
		NullReferenceException ex4 = new NullReferenceException();
		NullReferenceException ex5 = new NullReferenceException();
		bool flag13 = (byte)num5 != 0;
		NullReferenceException ex6 = new NullReferenceException();
		NullReferenceException ex7 = new NullReferenceException();
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		NullReferenceException ex10 = new NullReferenceException();
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		NullReferenceException ex13 = new NullReferenceException();
		NullReferenceException ex14 = new NullReferenceException();
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		num5 = (flag13 ? 1 : 0);
		photonSocket = (PhotonSocket)num11;
		NullReferenceException ex16 = new NullReferenceException();
		NullReferenceException ex17 = new NullReferenceException();
		PhotonPeer photonPeer2 = (PhotonPeer)num10;
		object obj14 = default;
		object obj21 = default;
		ConnectionStateValue connectionStateValue2 = default;
		byte b2 = default;
		bool result2 = default;
		while (true)
		{
			NullReferenceException ex18 = new NullReferenceException();
			while (true)
			{
				IL_41d9:
				NullReferenceException ex19 = new NullReferenceException();
				num12 = (int)array;
				NCommand nCommand = (NCommand)num5;
				num11 = (int)photonSocket;
				while (true)
				{
					NullReferenceException ex20 = new NullReferenceException();
					byte b = b2;
					NullReferenceException ex21 = new NullReferenceException();
					NullReferenceException ex33;
					object obj15;
					int num14;
					int num15;
					while (true)
					{
						IL_4223:
						OutOfMemoryException ex22 = new OutOfMemoryException();
						object[] array2 = (object[])num12;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
							ArgumentNullException ex23 = new ArgumentNullException();
							bool flag14 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
							ArgumentNullException ex24 = new ArgumentNullException();
							bool flag15 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
							ArgumentNullException ex25 = new ArgumentNullException();
							bool flag16 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
							ArgumentNullException ex26 = new ArgumentNullException();
							num10 = (int)photonPeer2;
							bool flag17 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
							ArgumentNullException ex27 = new ArgumentNullException();
							b2 = b;
							num14 = num4;
							num15 = 0;
							OutOfMemoryException ex28 = new OutOfMemoryException();
							num12 = (int)array2;
							list2 = (List<NCommand>)num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							b = b2;
							NullReferenceException ex29 = new NullReferenceException();
							NullReferenceException ex30 = new NullReferenceException();
							NullReferenceException ex31 = new NullReferenceException();
							NullReferenceException ex32 = new NullReferenceException();
							ex33 = new NullReferenceException();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
							if (num15 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj10 = 1;
							}
							else
							{
								if (num15 != 1)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								ex = (OutOfMemoryException)obj14;
							}
							num4 = num14;
							num5 = num15;
							obj15 = 0;
							if (obj11 != null)
							{
								Monitor.Exit(((int*)num8)->m_value);
								num5 = 0;
							}
							bool flag18 = ex == null;
							object obj16 = !flag18;
							photonPeer2 = (PhotonPeer)(object)list2;
							nCommand = (NCommand)num5;
							if (obj16 != null)
							{
								goto IL_4223;
							}
							bool flag19 = obj10 == null;
							object obj17 = !flag19;
							array2 = (object[])num12;
							photonPeer2 = (PhotonPeer)(object)list2;
							nCommand = (NCommand)num5;
							ex22 = ex;
							if (obj17 != null)
							{
								continue;
							}
							goto IL_3cc1;
						}
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					object obj18;
					object obj19;
					List<NCommand> obj20;
					StreamBuffer streamBuffer2;
					OutOfMemoryException ex34;
					if (num15 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						b2 = b;
						obj18 = 1;
						obj19 = obj8;
						obj20 = list;
						streamBuffer2 = streamBuffer;
						num4 = num14;
						num5 = num15;
					}
					else
					{
						bool flag20 = num15 != 1;
						b2 = b;
						ex34 = (OutOfMemoryException)(object)ex33;
						streamBuffer2 = streamBuffer;
						num4 = num14;
						num5 = num15;
						if (flag20)
						{
							goto IL_49ae;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						b2 = b;
						obj18 = obj7;
						obj19 = obj21;
						obj20 = list;
						streamBuffer2 = streamBuffer;
						num4 = num14;
						num5 = num15;
					}
					goto IL_44fb;
					IL_44fb:
					result = false;
					goto IL_4947;
					IL_3cc1:
					bool flag21 = (nint)obj15 == 43;
					ConnectionStateValue connectionStateValue = connectionStateValue2;
					num14 = num4;
					num15 = num5;
					if (!flag21)
					{
						bool flag22 = obj15 == null;
						object obj22 = !flag22;
						connectionStateValue = connectionStateValue2;
						num14 = num4;
						num15 = num5;
						b2 = b;
						obj18 = obj7;
						obj19 = obj8;
						obj20 = list;
						streamBuffer2 = streamBuffer;
						if (obj22 != null)
						{
							goto IL_44fb;
						}
					}
					bool flag23 = udpCommandCount == 0;
					connectionStateValue2 = connectionStateValue;
					b2 = b;
					obj18 = obj7;
					obj19 = obj8;
					obj20 = list;
					streamBuffer2 = streamBuffer;
					num4 = num14;
					num5 = num15;
					if (flag23)
					{
						goto IL_44fb;
					}
					num4 = udpBufferIndex;
					SendData(udpBuffer, udpBufferIndex);
					photonPeer2 = base.photonPeer;
					bool flag24 = base.photonPeer == null;
					connectionStateValue2 = connectionStateValue;
					b2 = b;
					array = (object[])num12;
					num5 = (int)udpBuffer;
					photonSocket = (PhotonSocket)num11;
					if (flag24)
					{
						break;
					}
					List<NCommand> list3 = sentReliableCommands;
					bool flag25 = sentReliableCommands == null;
					connectionStateValue2 = connectionStateValue;
					b2 = b;
					array = (object[])num12;
					num5 = (int)udpBuffer;
					photonSocket = (PhotonSocket)num11;
					if (flag25)
					{
						goto IL_41d9;
					}
					photonPeer2 = (PhotonPeer)(object)photonPeer2.Stats__BackingField;
					bool flag26 = photonPeer2.Stats__BackingField == null;
					connectionStateValue2 = connectionStateValue;
					b2 = b;
					nCommand = (NCommand)(object)udpBuffer;
					if (flag26)
					{
						continue;
					}
					bool flag27 = num11 < 0;
					bool flag28 = num11 == 0;
					int num16 = num11 ^ num11;
					int num17 = num11 & num16;
					bool flag29 = num17 < 0;
					bool flag30 = flag27 == flag29;
					object obj23 = !flag28;
					bool flag31 = (byte)((flag30 & obj23) ? 1 : 0) != 0;
					_ = list3._size;
					connectionStateValue2 = connectionStateValue;
					b2 = b;
					obj18 = obj7;
					obj19 = obj8;
					obj20 = list;
					streamBuffer2 = streamBuffer;
					num5 = (int)udpBuffer;
					result = flag31;
					goto IL_4947;
					IL_49ae:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result2;
					IL_4947:
					if (obj9 != null)
					{
						Monitor.Exit(obj20);
						num5 = 0;
					}
					bool flag32 = obj19 == null;
					object obj24 = !flag32;
					if (obj24 == null)
					{
						if (obj18 == null)
						{
							goto end_IL_41cb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					}
					OutOfMemoryException ex35 = new OutOfMemoryException();
					ex34 = ex35;
					goto IL_49ae;
				}
				break;
			}
			continue;
			end_IL_41cb:
			break;
		}
		goto IL_45e1;
		IL_405e:
		NullReferenceException ex36 = new NullReferenceException();
		goto IL_406c;
		IL_40d1:
		NullReferenceException ex37 = new NullReferenceException();
		array = (object[])num12;
		goto IL_40e7;
		IL_45e1:
		return result;
		IL_406c:
		OutOfMemoryException ex38 = new OutOfMemoryException();
		num10 = (int)list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex39 = new NullReferenceException();
		NullReferenceException ex40 = new NullReferenceException();
		NullReferenceException ex41 = new NullReferenceException();
		num11 = (int)photonSocket;
		NullReferenceException ex42 = new NullReferenceException();
		goto IL_40d1;
		IL_2340:
		result = false;
		goto IL_45e1;
	}

	private unsafe void UpdateSendWindow()
	{
		//IL_028c: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got Ref
		//IL_02b2: Expected Obj, but got Ref
		//IL_02cd: Expected Obj, but got Ref
		//IL_02e5: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got Ref
		//IL_0341: Expected Obj, but got Ref
		//IL_0e9e: Expected Obj, but got I4
		//IL_0cf7: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_0cd8: Expected I, but got Obj
		//IL_104c: Expected Obj, but got I4
		//IL_105d: Expected Obj, but got I4
		//IL_106a: Expected Obj, but got Ref
		//IL_1072: Expected Obj, but got Ref
		//IL_0125: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_0d1f: Expected Obj, but got I4
		//IL_0f92: Expected Obj, but got I4
		//IL_0fa2: Expected Obj, but got Ref
		//IL_03a9: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got Ref
		//IL_040b: Expected Obj, but got Ref
		//IL_0583: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I4
		//IL_05a4: Expected Obj, but got Ref
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I8
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_11c7: Expected Obj, but got Ref
		//IL_0499: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got Ref
		//IL_04bf: Expected Obj, but got Ref
		//IL_0831: Expected Obj, but got I4
		//IL_083e: Expected Obj, but got Ref
		//IL_0846: Expected Obj, but got Ref
		//IL_07f6: Expected Obj, but got Ref
		//IL_0804: Expected I, but got Obj
		//IL_0d5e: Expected Obj, but got I4
		//IL_0d6b: Expected Obj, but got Ref
		//IL_0d73: Expected Obj, but got Ref
		//IL_05fe: Expected Obj, but got I
		//IL_0618: Expected Obj, but got I4
		//IL_10c7: Expected Obj, but got I4
		//IL_123c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1241: Expected Obj, but got Unknown
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_124f: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I4
		//IL_06a3: Expected Obj, but got Ref
		//IL_06ab: Expected Obj, but got Ref
		//IL_06db: Expected Obj, but got I4
		//IL_06fe: Expected Obj, but got I4
		//IL_072e: Expected Obj, but got I4
		//IL_073b: Expected Obj, but got Ref
		//IL_0743: Expected Obj, but got Ref
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected Obj, but got Unknown
		//IL_07b0: Expected Obj, but got I4
		//IL_07ce: Expected Obj, but got I
		//IL_07de: Expected Obj, but got I
		PhotonPeer photonPeer = base.photonPeer;
		SendWindowUpdateRequired = false;
		bool flag = base.photonPeer == null;
		bool lockTaken = false;
		object obj = null;
		object obj2 = null;
		bool flag2 = false;
		object obj3 = null;
		bool lockTaken2 = false;
		object obj4;
		nint num = default;
		object obj6 = default;
		OutOfMemoryException ex = default;
		int[] obj7 = default;
		object obj8 = default;
		object obj5;
		int[] array6;
		int[] array2;
		int[] array3 = default;
		if (!flag)
		{
			if (photonPeer.SendWindowSize < 1)
			{
				return;
			}
			obj4 = sentReliableCommands;
			bool flag3 = sentReliableCommands == null;
			lockTaken = false;
			obj = null;
			obj2 = null;
			flag2 = false;
			obj3 = null;
			lockTaken2 = false;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X0_v42 (System.Object)+18]");
				if ((nint)0 == 0)
				{
					Monitor.Enter(channelArray, ref lockTaken2);
					EnetChannel[] array = channelArray;
					bool flag4 = channelArray == null;
					lockTaken = false;
					obj = null;
					obj2 = null;
					flag2 = false;
					obj5 = 0;
					num = (nint)(&lockTaken2);
					obj6 = 0;
					ex = null;
					obj7 = (int[])(&obj3);
					obj8 = (object)(&lockTaken2);
					obj3 = channelArray;
					lockTaken2 = false;
					array2 = (int[])(&obj3);
					if (!flag4)
					{
						array2 = (int[])array.Length;
						bool flag5 = array.Length < 1;
						lockTaken = false;
						obj = null;
						obj2 = null;
						flag2 = false;
						obj5 = 0;
						num = (nint)(&lockTaken2);
						obj6 = 0;
						ex = null;
						obj7 = (int[])(&obj3);
						obj8 = (object)(&lockTaken2);
						obj3 = channelArray;
						lockTaken2 = false;
						if (flag5)
						{
							goto IL_0cad;
						}
						object obj9 = ~array.Length;
						array3 = (int[])(array.Length & obj9);
						object obj10 = 0;
						while (true)
						{
							bool flag6 = array2 == obj10;
							lockTaken = false;
							obj = null;
							obj2 = null;
							flag2 = false;
							obj5 = 0;
							num = (nint)(&lockTaken2);
							obj6 = 0;
							ex = null;
							obj7 = (int[])(&obj3);
							obj8 = (object)(&lockTaken2);
							obj3 = channelArray;
							lockTaken2 = false;
							if (flag6)
							{
								break;
							}
							object obj11 = (object)channelArray + obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X12_v15+20]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X12_v15+20]");
							bool flag7 = (nint)0 == 0;
							lockTaken = false;
							obj = null;
							obj2 = null;
							flag2 = false;
							obj5 = 0;
							num = (nint)(&lockTaken2);
							obj6 = 0;
							ex = null;
							obj7 = (int[])(&obj3);
							obj8 = (object)(&lockTaken2);
							obj3 = channelArray;
							lockTaken2 = false;
							if (!flag7)
							{
								obj10++;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X12_v18+68]");
								EnetChannel[] array4 = (EnetChannel[])((nint)0 + (nint)1);
								if (array3 != obj10)
								{
									continue;
								}
								goto IL_0474;
							}
							goto IL_0dcf;
						}
						goto IL_0dc1;
					}
					goto IL_0e4e;
				}
				array2 = lowestSentSequenceNumber;
				EnetChannel[] array5 = channelArray;
				if (lowestSentSequenceNumber != null)
				{
					bool flag8 = channelArray == null;
					lockTaken = false;
					obj = null;
					obj2 = null;
					flag2 = false;
					obj3 = null;
					lockTaken2 = false;
					if (!flag8)
					{
						array6 = (int[])array2.Length;
						object obj13 = array5.Length;
						if (array2.Length != array5.Length)
						{
							goto IL_0526;
						}
						if (array2.Length >= 1)
						{
							object obj14 = array2.Length & 0xFFFFFFFFL;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							object obj15 = obj14 + 3;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D820]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EA80]");
							object obj17 = 0;
							object obj18 = obj15 & 0x1FFFFFFFCL;
							object obj19 = lowestSentSequenceNumber + 44;
							object obj20 = default;
							do
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
								obj17 += obj20;
								obj16 += obj20;
								obj18 -= 4;
								obj19 += 16;
							}
							while ((nint)obj18 != 4);
							object obj12 = 17289216;
							obj13 = 4;
							array6 = (int[])17293312;
						}
						goto IL_0f61;
					}
				}
				else
				{
					bool flag9 = channelArray == null;
					object obj10 = default;
					object obj13 = obj10;
					array6 = array3;
					lockTaken = false;
					obj = null;
					obj2 = null;
					flag2 = false;
					obj3 = null;
					lockTaken2 = false;
					if (!flag9)
					{
						goto IL_0526;
					}
				}
			}
		}
		goto IL_0e07;
		IL_0526:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int[] array7 = default;
		lowestSentSequenceNumber = array7;
		object obj22 = this + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj4 = sentReliableCommands;
		goto IL_0f61;
		IL_0dcf:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ddd;
		IL_0e31:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0e4e;
		IL_0deb:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0e07;
		IL_0e4e:
		NullReferenceException ex6 = new NullReferenceException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj6 = 1;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj23 = default;
			ex = (OutOfMemoryException)obj23;
		}
		goto IL_0cad;
		IL_0ddd:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0deb;
		IL_0e07:
		NullReferenceException ex8 = new NullReferenceException();
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0e23;
		IL_07e3:
		throw new NullReferenceException();
		IL_0e23:
		OutOfMemoryException ex10 = new OutOfMemoryException();
		goto IL_0e31;
		IL_0474:
		lockTaken = false;
		obj = null;
		obj2 = null;
		flag2 = false;
		obj5 = 0;
		num = (nint)(&lockTaken2);
		obj6 = 0;
		ex = null;
		obj7 = (int[])(&obj3);
		obj8 = (object)(&lockTaken2);
		lockTaken2 = false;
		goto IL_0cad;
		IL_0cad:
		if (obj8 != null)
		{
			Monitor.Exit(obj7);
			num = unchecked((nint)null);
		}
		bool flag10 = ex == null;
		object obj24 = !flag10;
		if (obj24 != null)
		{
			goto IL_0e23;
		}
		bool flag11 = obj6 == null;
		object obj25 = !flag11;
		ex10 = ex;
		if (obj25 == null)
		{
			return;
		}
		goto IL_0e31;
		IL_0d36:
		NullReferenceException ex11 = new NullReferenceException();
		obj2 = null;
		flag2 = false;
		int num3;
		int num2 = num3;
		obj6 = 0;
		ex = null;
		obj7 = (int[])(&obj);
		obj8 = (object)(&lockTaken);
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		NullReferenceException ex13 = new NullReferenceException();
		num = num2;
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		lockTaken = false;
		obj3 = null;
		lockTaken2 = false;
		goto IL_0dc1;
		IL_0f61:
		Monitor.Enter(obj4, ref lockTaken);
		List<System.__Canon> list = (List<System.__Canon>)(object)sentReliableCommands;
		bool flag12 = sentReliableCommands == null;
		obj5 = 0;
		int num4 = (int)(&lockTaken);
		array2 = (int[])(&obj);
		if (flag12)
		{
			goto IL_07e3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516268]");
		object obj26 = 0;
		object obj27 = 0;
		int num5 = (int)(&lockTaken);
		array3 = array6;
		int[] array8 = (int[])(&obj);
		num3 = 0;
		while (true)
		{
			bool flag13 = num3 >= list._size;
			obj5 = obj27;
			num4 = num5;
			array6 = array3;
			array2 = array8;
			if (flag13)
			{
				break;
			}
			obj5 = obj26;
			System.__Canon _Canon = list.get_Item(num3);
			if (_Canon != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X0_v58 (System.__Canon)+10]");
				object obj28 = (nint)0 & (nint)2;
				bool flag14 = obj28 == null;
				object obj29 = !flag14;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X0_v58 (System.__Canon)+12]");
					if ((nint)0 != 255)
					{
						int[] array9 = lowestSentSequenceNumber;
						bool flag15 = lowestSentSequenceNumber == null;
						lockTaken = false;
						obj = obj4;
						obj2 = null;
						flag2 = false;
						num = num3;
						obj6 = 0;
						ex = null;
						obj7 = (int[])(&obj);
						obj8 = (object)(&lockTaken);
						obj3 = null;
						lockTaken2 = false;
						array2 = lowestSentSequenceNumber;
						if (flag15)
						{
							goto IL_0ddd;
						}
						array3 = (int[])array9.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X0_v58 (System.__Canon)+12]");
						bool flag16 = (nint)0 < (nint)array9.Length;
						object obj30 = !flag16;
						lockTaken = false;
						obj = obj4;
						obj2 = null;
						flag2 = false;
						num = num3;
						obj6 = 0;
						ex = null;
						obj7 = (int[])(&obj);
						obj8 = (object)(&lockTaken);
						obj3 = null;
						lockTaken2 = false;
						array2 = lowestSentSequenceNumber;
						if (obj30 != null)
						{
							goto IL_0deb;
						}
						int[] array10 = lowestSentSequenceNumber;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X0_v58 (System.__Canon)+12]");
						object obj31 = array10 + 0;
						object obj32 = obj31 + 32;
						array8 = (int[])obj32;
						bool flag17 = obj32 == null;
						object obj33 = !flag17;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X0_v58 (System.__Canon)+14]");
							array8 = (int[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X0_v58 (System.__Canon)+14]");
							obj32 = 0;
						}
					}
				}
				list = (List<System.__Canon>)(object)sentReliableCommands;
				int num6 = num3 + 1;
				bool flag18 = sentReliableCommands == null;
				object obj34 = !flag18;
				num4 = num3;
				array6 = array3;
				array2 = array8;
				obj27 = obj5;
				num5 = num3;
				num3 = num6;
				if (obj34 != null)
				{
					continue;
				}
				goto IL_07e3;
			}
			goto IL_0d36;
		}
		object obj35 = (object)(&lockTaken);
		bool flag19 = obj35 == null;
		num = num4;
		if (!flag19)
		{
			int[] obj36 = (int[])(&obj);
			Monitor.Exit(obj36);
			num = unchecked((nint)null);
		}
		lockTaken = false;
		obj = obj4;
		obj2 = null;
		flag2 = false;
		obj6 = 0;
		ex = null;
		obj7 = (int[])(&obj);
		obj8 = (object)(&lockTaken);
		obj3 = null;
		lockTaken2 = false;
		array3 = array6;
		goto IL_0e23;
		IL_0dc1:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		goto IL_0dcf;
	}

	internal override bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams)
	{
		//IL_000e: Expected Obj, but got VT
		//IL_0017: Invalid comparison between VT and I4
		//IL_0028: Expected Obj, but got I4
		//IL_0036: Expected I4, but got VT
		object obj = sendParams << 3;
		bool flag = sendParams < (object)4;
		object obj2 = !flag;
		byte channelNumber = (byte)(sendParams >> 40);
		byte b = (byte)(235603463 >> (int)obj);
		object obj3 = ~obj2;
		object obj4 = ~obj3;
		byte commandType = (byte)((obj4 != null) ? 7 : b);
		bool flag2 = CreateAndEnqueueCommand(commandType, opBytes, channelNumber);
		return true;
	}

	internal unsafe bool CreateAndEnqueueCommand(byte commandType, StreamBuffer payload, byte channelNumber)
	{
		//IL_006a: Expected Obj, but got I
		//IL_001f: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I
		//IL_028a: Expected I4, but got Obj
		//IL_012f: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got Ref
		//IL_03cb: Expected Obj, but got I4
		//IL_0367: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0407: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got Ref
		//IL_0ae4: Expected Obj, but got I4
		//IL_0bd4: Expected Obj, but got I4
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got Unknown
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected I4, but got Unknown
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Expected I4, but got Unknown
		//IL_0c17: Expected Obj, but got I4
		//IL_0b33: Expected Obj, but got I4
		//IL_03bc: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_048d: Expected Obj, but got I4
		//IL_0880: Expected Obj, but got I4
		//IL_07fc: Expected I4, but got Obj
		//IL_080d: Expected Obj, but got I4
		//IL_0822: Expected Obj, but got Ref
		//IL_0833: Expected Obj, but got I4
		//IL_0845: Expected Obj, but got I4
		//IL_0858: Expected Obj, but got I4
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_08b0: Expected Obj, but got I4
		//IL_0c3e: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got I4
		//IL_0d2f: Expected Obj, but got I
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected I4, but got Unknown
		//IL_09f3: Expected I4, but got Obj
		//IL_0574: Expected Obj, but got I
		//IL_0923: Expected Obj, but got I
		//IL_094d: Expected Obj, but got I4
		//IL_0a09: Expected I4, but got Obj
		//IL_0a19: Expected Obj, but got I4
		//IL_0591: Expected Obj, but got I
		//IL_0599: Expected I4, but got Obj
		//IL_0cb2: Expected Obj, but got I
		//IL_0905: Expected Obj, but got I4
		//IL_0a30: Expected Obj, but got I4
		//IL_0a45: Expected Obj, but got Ref
		//IL_05d5: Expected I4, but got Obj
		//IL_05ee: Expected Obj, but got I4
		//IL_05ff: Expected I4, but got Obj
		//IL_0982: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I
		//IL_064e: Expected Obj, but got I4
		//IL_065f: Expected I4, but got Obj
		//IL_06ed: Expected I4, but got Obj
		//IL_0770: Expected I4, but got Obj
		//IL_0785: Expected Obj, but got I4
		//IL_078d: Expected I4, but got Obj
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected Obj, but got Unknown
		byte b = default;
		EnetChannel channel = GetChannel(b);
		ByteCountLastOperation = 0;
		int num = GetFragmentLength();
		string text;
		int num2;
		byte b2;
		int num3;
		StreamBuffer streamBuffer;
		if (num != 0)
		{
			bool flag = payload == null;
			object obj = !flag;
			text = (string)(object)payload;
			num2 = num;
			if (obj != null)
			{
				goto IL_00c1;
			}
			streamBuffer = payload;
			b2 = b;
			num3 = num;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516218]");
			object obj2 = 0;
			text = (string)obj2;
			EnqueueDebugReturn((LogLevel)2, (string)obj2);
			bool flag2 = payload == null;
			num2 = 1000;
			streamBuffer = (StreamBuffer)obj2;
			b2 = 2;
			num3 = 1000;
			if (!flag2)
			{
				goto IL_00c1;
			}
		}
		goto IL_0245;
		IL_0a69:
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_0a77;
		IL_03d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v41 (System.Int32)+60]");
		ByteCountLastOperation = 0;
		goto IL_0991;
		IL_00c1:
		int length = payload.Length;
		bool flag3 = length <= num2;
		streamBuffer = (StreamBuffer)(object)text;
		b2 = 0;
		num3 = num2;
		if (flag3)
		{
			goto IL_0245;
		}
		bool lockTaken = default;
		Monitor.Enter(channel, ref lockTaken);
		int num4 = commandType & 0xFF;
		object obj3 = num4 - 14;
		bool flag4 = obj3 == null;
		object obj4 = !flag4;
		object obj5 = ~obj4;
		bool flag5;
		if (obj5 == null)
		{
			object obj6 = num4 - 11;
			flag5 = obj6 == null;
		}
		else
		{
			flag5 = true;
		}
		byte b3 = ((!flag5) ? ((byte)1) : ((byte)0));
		int length2 = payload.Length;
		object obj7 = default;
		OutOfMemoryException ex2 = default;
		int num6 = default;
		EnetChannel enetChannel = default;
		object obj8 = default;
		object obj9;
		byte b4;
		int num5;
		EnetChannel enetChannel2;
		if (num4 == 11 || num4 == 14)
		{
			bool flag6 = channel == null;
			num5 = length2;
			obj7 = 0;
			ex2 = null;
			num6 = (int)(&enetChannel);
			obj8 = (object)(&lockTaken);
			lockTaken = false;
			enetChannel = channel;
			int num7 = (int)(&enetChannel);
			streamBuffer = null;
			b2 = 0;
			enetChannel2 = channel;
			b4 = b3;
			num3 = num2;
			if (flag6)
			{
				goto IL_0a86;
			}
			obj9 = channel + 88;
		}
		else
		{
			bool flag7 = channel == null;
			num5 = length2;
			obj7 = 0;
			ex2 = null;
			num6 = (int)(&enetChannel);
			obj8 = (object)(&lockTaken);
			lockTaken = false;
			enetChannel = channel;
			int num7 = (int)(&enetChannel);
			streamBuffer = null;
			b2 = 0;
			enetChannel2 = channel;
			b4 = b3;
			num3 = num2;
			if (flag7)
			{
				goto IL_0a94;
			}
			obj9 = channel + 80;
		}
		byte[] buffer = payload.GetBuffer();
		object obj10 = num2 + length2;
		bool flag8 = b3 == 0;
		object obj11 = obj10 - 1;
		int fragmentCount = obj11 / num2;
		b4 = (byte)(obj9 + 1);
		object obj12 = !flag8;
		obj5 = ~obj12;
		int num8;
		StreamBuffer streamBuffer2;
		byte b5;
		byte b6;
		nint num9 = default;
		if (obj5 == null)
		{
			num8 = 0;
			streamBuffer2 = (StreamBuffer)b;
			b5 = (byte)num9;
			num5 = 8;
			int num7 = 8;
			b6 = 0;
			enetChannel2 = null;
		}
		else
		{
			num8 = 0;
			streamBuffer2 = (StreamBuffer)b;
			b5 = (byte)num9;
			num5 = 15;
			int num7 = 8;
			b6 = 0;
			enetChannel2 = null;
		}
		StreamBuffer streamBuffer3 = default;
		NCommand nCommand2 = default;
		while (true)
		{
			int length3 = payload.Length;
			if ((nint)enetChannel2 >= length3)
			{
				break;
			}
			int length4 = payload.Length;
			object obj13 = length4 - enetChannel2;
			bool flag9 = (nint)obj13 >= num2;
			NCommand nCommand = null;
			if (!flag9)
			{
				int length5 = payload.Length;
				num2 = length5 - enetChannel2;
				nCommand = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v61+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
				object obj17 = 0;
				obj15 = obj17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v61+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v42+8]");
			if ((nint)0 == 0)
			{
				goto IL_09e2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516208]");
			object obj19 = 0;
			b2 = (byte)(int)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
			if (streamBuffer3 != null)
			{
				streamBuffer3.Write(buffer, (int)enetChannel2, num2);
				bool flag11 = nCommandPool == null;
				streamBuffer2 = (StreamBuffer)num2;
				b5 = 0;
				b6 = (byte)(int)enetChannel2;
				nCommand = (NCommand)(object)buffer;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161A0]");
					object obj20 = 0;
					nCommand = (NCommand)obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
					bool flag12 = nCommand2 == null;
					streamBuffer2 = (StreamBuffer)num2;
					b5 = 0;
					b6 = (byte)(int)enetChannel2;
					if (flag12)
					{
						goto IL_09d4;
					}
					b5 = channel.ChannelNumber;
					nCommand2.Initialize(this, (byte)num5, streamBuffer3, channel.ChannelNumber, (ConnectionStateValue)3);
					nCommand2.fragmentCount = fragmentCount;
					nCommand2.fragmentNumber = num8;
					nCommand2.startSequenceNumber = b4;
					int length6 = payload.Length;
					nCommand2.totalLength = length6;
					nCommand2.fragmentOffset = (int)enetChannel2;
					QueueOutgoingReliableCommand(nCommand2);
					PhotonPeer photonPeer = base.photonPeer;
					int num7 = nCommand2.Size + ByteCountLastOperation;
					ByteCountLastOperation = num7;
					ConnectionStateValue connectionStateValue;
					if (base.photonPeer != null)
					{
						TrafficStats trafficStats = photonPeer.Stats__BackingField;
						bool flag13 = photonPeer.Stats__BackingField == null;
						connectionStateValue = (ConnectionStateValue)3;
						b = (byte)(int)streamBuffer3;
						num9 = (int)channel.ChannelNumber;
						streamBuffer = (StreamBuffer)num5;
						b2 = (byte)(int)nCommand2;
						if (!flag13)
						{
							num8++;
							enetChannel2 = (EnetChannel)(num2 + enetChannel2);
							num7 = ((TrafficStatsBase)trafficStats).UdpFragmentsOut__BackingField + 1;
							((TrafficStatsBase)trafficStats).UdpFragmentsOut__BackingField = num7;
							connectionStateValue = (ConnectionStateValue)3;
							streamBuffer2 = streamBuffer3;
							b6 = (byte)num5;
							continue;
						}
						goto IL_0a1e;
					}
					NullReferenceException ex3 = new NullReferenceException();
					connectionStateValue = (ConnectionStateValue)3;
					streamBuffer2 = streamBuffer3;
					b6 = (byte)num5;
					nCommand = nCommand2;
				}
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_09d4;
			}
			goto IL_09f8;
			IL_09f8:
			NullReferenceException ex5 = new NullReferenceException();
			b = (byte)(int)streamBuffer2;
			num9 = (int)b5;
			streamBuffer = (StreamBuffer)b6;
			goto IL_0a1e;
			IL_0a1e:
			NullReferenceException ex6 = new NullReferenceException();
			obj7 = 0;
			ex2 = null;
			num6 = (int)(&enetChannel);
			obj8 = (object)(&lockTaken);
			lockTaken = false;
			num3 = num2;
			goto IL_0a5b;
			IL_09e2:
			NullReferenceException ex7 = new NullReferenceException();
			b2 = (byte)(int)nCommand;
			goto IL_09f8;
			IL_09d4:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_09e2;
		}
		b = (byte)(int)streamBuffer2;
		num9 = (int)b5;
		obj7 = 0;
		ex2 = null;
		num6 = (int)(&enetChannel);
		obj8 = (object)(&lockTaken);
		lockTaken = false;
		streamBuffer = (StreamBuffer)b6;
		b2 = 0;
		object obj21 = 18;
		goto IL_0d02;
		IL_0a77:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0a86;
		IL_0a86:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0a94;
		IL_0991:
		return true;
		IL_0a5b:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_0a69;
		IL_0245:
		bool flag14 = nCommandPool == null;
		lockTaken = false;
		enetChannel = null;
		if (!flag14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161A0]");
			object obj22 = 0;
			b2 = (byte)(int)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
			bool flag15 = channel == null;
			lockTaken = false;
			enetChannel = null;
			if (!flag15)
			{
				int num10 = default;
				bool flag16 = num10 == 0;
				lockTaken = false;
				enetChannel = null;
				num3 = num10;
				if (!flag16)
				{
					((NCommand)num10).Initialize(this, commandType, payload, channel.ChannelNumber, (ConnectionStateValue)3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v41 (System.Int32)+10]");
					object obj23 = (nint)0 & (nint)1;
					if (obj23 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v41 (System.Int32)+11]");
						bool flag17 = (nint)0 < (nint)16;
						object obj24 = !flag17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v41 (System.Int32)+11]");
						object obj25 = -16;
						bool flag18 = obj25 == null;
						object obj26 = !flag18;
						object obj27 = obj24 & obj26;
						if (obj27 == null)
						{
							QueueOutgoingReliableCommand((NCommand)num10);
							goto IL_03d0;
						}
					}
					QueueOutgoingUnreliableCommand((NCommand)num10);
					goto IL_03d0;
				}
			}
		}
		goto IL_0a5b;
		IL_0d02:
		if (obj8 != null)
		{
			Monitor.Exit(((int*)num6)->m_value);
			b2 = 0;
		}
		bool flag19 = ex2 == null;
		object obj28 = !flag19;
		num3 = num2;
		if (obj28 != null)
		{
			goto IL_0a69;
		}
		bool flag20 = obj7 == null;
		object obj29 = !flag20;
		ex = ex2;
		num3 = num2;
		if (obj29 == null)
		{
			if ((nint)obj21 != 18)
			{
				bool flag21 = obj21 == null;
				object obj30 = !flag21;
				if (obj30 != null)
				{
					goto IL_0991;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
			object obj31 = 0;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v10+E4]");
			bool flag22 = (nint)0 == 0;
			object obj33 = !flag22;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj32 = obj31;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v10+A0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v9+8]");
			bool flag23 = (nint)0 == 0;
			num3 = num2;
			if (!flag23)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516210]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
				goto IL_0991;
			}
			goto IL_0a5b;
		}
		goto IL_0a77;
		IL_0a94:
		NullReferenceException ex11 = new NullReferenceException();
		if (b2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj7 = 1;
		}
		else
		{
			if (b2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj36 = default;
			ex2 = (OutOfMemoryException)obj36;
		}
		obj21 = 0;
		num2 = num3;
		goto IL_0d02;
	}

	internal unsafe int SerializeAckToBuffer()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Ref, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected I4, but got Unknown
		//IL_0ab9: Expected I8, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_0c09: Expected Obj, but got I4
		//IL_0c22: Expected Obj, but got I4
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Expected Obj, but got Unknown
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected I4, but got Unknown
		//IL_0c67: Expected I4, but got Obj
		//IL_0c8e: Expected Obj, but got I4
		//IL_14d9: Expected Obj, but got I4
		//IL_0ff3: Expected Obj, but got I4
		//IL_100a: Expected Obj, but got I4
		//IL_1502: Expected Obj, but got Ref
		//IL_1169: Expected Obj, but got I4
		//IL_0d22: Expected Obj, but got I4
		//IL_0d2f: Expected Obj, but got I4
		//IL_0d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d67: Expected I4, but got Unknown
		//IL_0d8e: Expected Obj, but got I4
		//IL_1145: Expected Obj, but got I4
		//IL_114a: Expected I, but got Obj
		//IL_01b6: Expected I4, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_11a1: Expected Obj, but got I4
		//IL_12ca: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected I4, but got Unknown
		//IL_0fbc: Expected Obj, but got I4
		//IL_0fe5: Expected I4, but got Obj
		//IL_027b: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_0e45: Expected Obj, but got I4
		//IL_0e5f: Expected I4, but got Obj
		//IL_0e85: Expected Obj, but got I4
		//IL_11fe: Expected Obj, but got I4
		//IL_1035: Expected Obj, but got I4
		//IL_103a: Expected I, but got Obj
		//IL_1391: Expected Obj, but got I4
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Expected I4, but got Unknown
		//IL_1114: Expected Obj, but got I4
		//IL_112a: Expected Obj, but got I4
		//IL_02cd: Expected I, but got Obj
		//IL_1439: Expected Obj, but got I4
		//IL_105f: Expected I, but got Obj
		//IL_10c9: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I4
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected I4, but got Unknown
		//IL_0634: Expected Obj, but got I4
		//IL_0641: Expected Obj, but got I4
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected I4, but got Unknown
		//IL_06a0: Expected Obj, but got I4
		//IL_06f3: Expected I, but got Obj
		//IL_03a3: Expected Obj, but got I4
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_09f9: Expected Obj, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected I4, but got Unknown
		//IL_03f8: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I4
		//IL_04e9: Expected I4, but got Obj
		//IL_1470: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_15ba: Expected Obj, but got I4
		//IL_15c9: Expected Obj, but got I4
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1603: Expected I4, but got Unknown
		//IL_080d: Expected Obj, but got I4
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected I4, but got Unknown
		//IL_0892: Expected Obj, but got I4
		//IL_096f: Expected Obj, but got I4
		//IL_0983: Expected I4, but got Obj
		//IL_14a6: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I4
		int result;
		object obj23;
		nint num7 = default;
		object obj5 = default;
		if (useAck2)
		{
			int num = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
			int num2 = num & 0xFF;
			bool flag = num2 < 3;
			object obj = !flag;
			object obj2 = num2 - 3;
			bool flag2 = (nint)obj2 < 0;
			bool flag3 = obj2 == null;
			int num3 = num2 ^ 3;
			int num4 = num2 ^ obj2;
			int num5 = num3 & num4;
			bool flag4 = num5 < 0;
			bool flag5 = num2 != 3;
			result = 0;
			if (!flag5)
			{
				bool lockTaken = default;
				Monitor.Enter(channelArray, ref lockTaken);
				EnetChannel[] array = channelArray;
				bool flag6 = channelArray == null;
				object obj3 = default;
				int num6 = (int)(&obj3);
				EnetChannel enetChannel = null;
				num7 = (nint)(&lockTaken);
				if (!flag6)
				{
					byte b2 = default;
					byte b = b2;
					int num9 = default;
					int num8 = num9;
					object obj4 = obj5;
					object obj6 = 0;
					EnetChannel[] array2 = channelArray;
					int num10 = 0;
					Array array3 = null;
					nint num11 = (nint)(&lockTaken);
					int completeSequenceNumber = 0;
					int num15 = default;
					bool flag16 = default;
					int num17 = default;
					byte b4 = default;
					int result2 = default;
					object obj24 = default;
					while (true)
					{
						num6 = array2.Length;
						bool flag7 = (nint)obj6 < array2.Length;
						object obj7 = !flag7;
						int[] array5;
						bool flag13;
						byte b3;
						int num14;
						bool flag15;
						int num16;
						bool flag22;
						int[] array7;
						nint num20;
						EnetChannel[] array10;
						int num21;
						bool flag35;
						byte b7;
						int num22;
						int num23;
						byte b8;
						object obj21;
						object obj22;
						OutOfMemoryException ex2;
						int num24;
						int num25;
						Array array11;
						if ((nint)obj6 < array2.Length)
						{
							if (obj7 != null)
							{
								goto IL_127e;
							}
							num6 = (int)((object)array2 + obj6);
							int[] array4 = gapBlocks;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v10 (System.Int32)+20]");
							enetChannel = (EnetChannel)0;
							bool flag8 = gapBlocks == null;
							completeSequenceNumber = 0;
							if (flag8)
							{
								goto IL_1270;
							}
							num6 = udpBufferIndex;
							object obj8 = array4.Length * 20;
							int num12 = udpBufferIndex + obj8;
							int num13 = CalculatePacketSize(num12);
							bool flag9 = photonPeer == null;
							num11 = num12;
							completeSequenceNumber = 0;
							if (flag9)
							{
								goto IL_1262;
							}
							int maximumTransferUnit = photonPeer.MaximumTransferUnit;
							object obj9 = num13 - maximumTransferUnit;
							bool flag10 = obj9 == null;
							obj4 = !flag10;
							if (num13 <= maximumTransferUnit)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v10 (System.Int32)+20]");
								bool flag11 = (nint)0 == 0;
								num11 = unchecked((nint)null);
								completeSequenceNumber = 0;
								if (flag11)
								{
									goto IL_128c;
								}
								array5 = gapBlocks;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v10 (System.Int32)+20]");
								bool gapBlock = ((EnetChannel)0).GetGapBlock(out completeSequenceNumber, gapBlocks, isSequenced: true);
								int[] array6 = gapBlocks;
								if (gapBlock)
								{
									bool flag12 = gapBlocks == null;
									flag13 = true;
									num11 = (nint)(&completeSequenceNumber);
									if (flag12)
									{
										goto IL_121a;
									}
									b3 = 0;
									flag13 = true;
									num11 = (nint)(&completeSequenceNumber);
									while (true)
									{
										num6 = array6.Length;
										bool flag14 = b3 >= array6.Length;
										num14 = num15;
										flag15 = flag16;
										b2 = b;
										num16 = num17;
										num9 = num8;
										if (flag14)
										{
											break;
										}
										bool flag17 = b3 < array6.Length;
										object obj10 = !flag17;
										b4 = b3;
										if (obj10 != null)
										{
											goto IL_1228;
										}
										num6 = array6 + b3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v10 (System.Int32)+20]");
										num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v10 (System.Int32)+20]");
										bool flag18 = (nint)0 == 0;
										object obj11 = !flag18;
										if (obj11 == null)
										{
											bool flag19 = b3 == 0;
											object obj12 = !flag19;
											if (obj12 != null)
											{
												goto IL_1448;
											}
										}
										num17 = serverSentTime;
										NCommand.CreateAck2(udpBuffer, udpBufferIndex, enetChannel.ChannelNumber, completeSequenceNumber, num8, b3, serverSentTime, isSequenced: true);
										num15 = udpBufferIndex + 20;
										byte b5 = (byte)(udpCommandCount + 1);
										udpBufferIndex = num15;
										udpCommandCount = b5;
										flag16 = true;
										b = b3;
										num6 = b5;
										array6 = gapBlocks;
										flag13 = (byte)completeSequenceNumber != 0;
										array5 = (int[])enetChannel.ChannelNumber;
										num11 = udpBufferIndex;
										gapBlock = (byte)(int)udpBuffer != 0;
										goto IL_1448;
										IL_1448:
										b3++;
										bool flag20 = array6 == null;
										object obj13 = !flag20;
										if (obj13 != null)
										{
											continue;
										}
										goto IL_04ee;
									}
								}
								else
								{
									bool flag21 = gapBlocks == null;
									num14 = num15;
									flag15 = flag16;
									b2 = b;
									num16 = num17;
									num9 = num8;
									b3 = b4;
									flag13 = true;
									flag22 = true;
									array7 = gapBlocks;
									num11 = (nint)(&completeSequenceNumber);
									if (flag21)
									{
										goto IL_12b8;
									}
								}
								num6 = udpBufferIndex;
								object obj14 = array6.Length * 20;
								int num18 = udpBufferIndex + obj14;
								int num19 = CalculatePacketSize(num18);
								bool flag23 = photonPeer == null;
								num15 = num14;
								flag16 = flag15;
								b = b2;
								num17 = num16;
								num8 = num9;
								b4 = b3;
								flag22 = flag13;
								array7 = array5;
								num11 = num18;
								if (flag23)
								{
									goto IL_12aa;
								}
								int maximumTransferUnit2 = photonPeer.MaximumTransferUnit;
								bool flag24 = num19 < maximumTransferUnit2;
								obj = !flag24;
								obj2 = num19 - maximumTransferUnit2;
								flag2 = (nint)obj2 < 0;
								flag3 = obj2 == null;
								num3 = num19 ^ maximumTransferUnit2;
								num4 = num19 ^ obj2;
								num5 = num3 & num4;
								flag4 = num5 < 0;
								obj4 = !flag3;
								flag5 = num19 > maximumTransferUnit2;
								num15 = num14;
								flag16 = flag15;
								b = b2;
								num17 = num16;
								num8 = num9;
								b4 = b3;
								num10 = (flag13 ? 1 : 0);
								array3 = array5;
								num20 = unchecked((nint)null);
								if (!flag5)
								{
									int[] array8 = gapBlocks;
									bool gapBlock2 = enetChannel.GetGapBlock(out completeSequenceNumber, gapBlocks, isSequenced: false);
									bool flag25 = !gapBlock2;
									flag13 = false;
									num7 = (nint)(&completeSequenceNumber);
									if (!flag25)
									{
										int[] array9 = gapBlocks;
										bool flag26 = gapBlocks == null;
										num15 = num14;
										flag16 = flag15;
										b = b2;
										num17 = num16;
										num8 = num9;
										b4 = b3;
										flag13 = false;
										array5 = gapBlocks;
										num11 = (nint)(&completeSequenceNumber);
										if (flag26)
										{
											goto IL_1236;
										}
										b3 = 0;
										flag13 = false;
										array5 = gapBlocks;
										num7 = (nint)(&completeSequenceNumber);
										while (true)
										{
											num6 = array9.Length;
											bool flag27 = b3 < array9.Length;
											obj = !flag27;
											obj2 = b3 - array9.Length;
											flag2 = (nint)obj2 < 0;
											flag3 = obj2 == null;
											num3 = b3 ^ array9.Length;
											num4 = b3 ^ obj2;
											num5 = num3 & num4;
											flag4 = num5 < 0;
											flag5 = b3 >= array9.Length;
											array8 = array5;
											if (flag5)
											{
												break;
											}
											bool flag28 = b3 < array9.Length;
											object obj15 = !flag28;
											num15 = num14;
											flag16 = flag15;
											b = b2;
											num17 = num16;
											num8 = num9;
											b4 = b3;
											num11 = num7;
											if (obj15 != null)
											{
												goto IL_1244;
											}
											num6 = array9 + b3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v10 (System.Int32)+20]");
											num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v10 (System.Int32)+20]");
											bool flag29 = (nint)0 == 0;
											object obj16 = !flag29;
											if (obj16 == null)
											{
												bool flag30 = b3 == 0;
												object obj17 = !flag30;
												if (obj17 != null)
												{
													goto IL_147e;
												}
											}
											num16 = serverSentTime;
											NCommand.CreateAck2(udpBuffer, udpBufferIndex, enetChannel.ChannelNumber, completeSequenceNumber, num9, b3, serverSentTime, isSequenced: false);
											num14 = udpBufferIndex + 20;
											byte b6 = (byte)(udpCommandCount + 1);
											udpBufferIndex = num14;
											udpCommandCount = b6;
											flag15 = false;
											b2 = b3;
											num6 = b6;
											array9 = gapBlocks;
											flag13 = (byte)completeSequenceNumber != 0;
											array5 = (int[])enetChannel.ChannelNumber;
											num7 = udpBufferIndex;
											gapBlock2 = (byte)(int)udpBuffer != 0;
											goto IL_147e;
											IL_147e:
											b3++;
											bool flag31 = array9 == null;
											object obj18 = !flag31;
											if (obj18 != null)
											{
												continue;
											}
											goto IL_0988;
										}
									}
									array = channelArray;
									obj6++;
									bool flag32 = channelArray == null;
									object obj19 = !flag32;
									obj5 = obj4;
									num15 = num14;
									flag16 = flag15;
									b = b2;
									num17 = num16;
									num8 = num9;
									b4 = b3;
									array2 = channelArray;
									num10 = (flag13 ? 1 : 0);
									array3 = array8;
									num11 = num7;
									if (obj19 == null)
									{
										break;
									}
									continue;
								}
							}
							else
							{
								array10 = channelArray;
								bool flag33 = channelArray == null;
								object obj20 = !flag33;
								num20 = unchecked((nint)null);
								completeSequenceNumber = 0;
								if (obj20 != null)
								{
									goto IL_10fc;
								}
								NullReferenceException ex = new NullReferenceException();
								num20 = unchecked((nint)null);
								completeSequenceNumber = 0;
							}
							array10 = channelArray;
							bool flag34 = channelArray == null;
							num21 = num15;
							flag35 = flag16;
							b7 = b;
							num22 = num17;
							num23 = num8;
							b8 = b4;
							obj21 = obj4;
							obj22 = 0;
							ex2 = null;
							num24 = num6;
							num25 = num10;
							array11 = array3;
							num11 = num20;
							if (!flag34)
							{
								goto IL_10fc;
							}
							goto IL_1341;
						}
						obj22 = 0;
						ex2 = null;
						result = 0;
						obj23 = 23;
						goto IL_14fa;
						IL_12e2:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						num21 = num15;
						flag35 = flag16;
						b7 = b;
						num22 = num17;
						num23 = num8;
						b8 = b4;
						obj21 = obj4;
						num24 = num6;
						num25 = (flag22 ? 1 : 0);
						array11 = array7;
						goto IL_1341;
						IL_0988:
						num15 = num14;
						flag16 = flag15;
						b = b2;
						num17 = num16;
						num8 = num9;
						b4 = b3;
						num11 = num7;
						goto IL_1236;
						IL_1236:
						NullReferenceException ex3 = new NullReferenceException();
						goto IL_1244;
						IL_1244:
						IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
						num10 = (flag13 ? 1 : 0);
						array3 = array5;
						goto IL_1262;
						IL_1341:
						NullReferenceException ex5 = new NullReferenceException();
						if (num11 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj22 = 1;
						}
						else
						{
							if (num11 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return result2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							ex2 = (OutOfMemoryException)obj24;
						}
						num15 = num21;
						flag16 = flag35;
						b = b7;
						num17 = num22;
						num8 = num23;
						b4 = b8;
						obj4 = obj21;
						num6 = num24;
						result = 0;
						num10 = num25;
						array3 = array11;
						obj23 = 0;
						goto IL_14fa;
						IL_12d4:
						OutOfMemoryException ex6 = new OutOfMemoryException();
						goto IL_12e2;
						IL_1262:
						NullReferenceException ex7 = new NullReferenceException();
						goto IL_1270;
						IL_127e:
						IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
						goto IL_128c;
						IL_128c:
						NullReferenceException ex9 = new NullReferenceException();
						flag22 = (byte)num10 != 0;
						array7 = (int[])array3;
						goto IL_12aa;
						IL_04ee:
						b4 = b3;
						goto IL_121a;
						IL_121a:
						NullReferenceException ex10 = new NullReferenceException();
						goto IL_1228;
						IL_1228:
						IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
						goto IL_1236;
						IL_1270:
						NullReferenceException ex12 = new NullReferenceException();
						goto IL_127e;
						IL_10fc:
						result = array10.Length - obj6;
						obj22 = 0;
						ex2 = null;
						num11 = num20;
						obj23 = 4;
						goto IL_14fa;
						IL_12aa:
						NullReferenceException ex13 = new NullReferenceException();
						goto IL_12b8;
						IL_12b8:
						NullReferenceException ex14 = new NullReferenceException();
						obj22 = 0;
						ex2 = null;
						goto IL_12d4;
						IL_14fa:
						object obj25 = (object)(&lockTaken);
						if (obj25 != null)
						{
							int num26 = (int)(&obj3);
							Monitor.Exit(((int*)num26)->m_value);
							num11 = unchecked((nint)null);
						}
						bool flag36 = ex2 == null;
						object obj26 = !flag36;
						flag22 = (byte)num10 != 0;
						array7 = (int[])array3;
						if (obj26 != null)
						{
							goto IL_12d4;
						}
						bool flag37 = obj22 == null;
						object obj27 = !flag37;
						flag22 = (byte)num10 != 0;
						array7 = (int[])array3;
						ex6 = ex2;
						if (obj27 == null)
						{
							goto IL_11c7;
						}
						goto IL_12e2;
					}
				}
				StreamBuffer streamBuffer = (StreamBuffer)(object)array;
				throw new NullReferenceException();
			}
			goto IL_1443;
		}
		bool flag38 = outgoingAcknowledgementsBuffer == null;
		int num27 = (int)num7;
		int num28 = 0;
		if (!flag38)
		{
			long num29 = outgoingAcknowledgementsBuffer.Seek(0L, (SeekOrigin)0);
			StreamBuffer streamBuffer2 = outgoingAcknowledgementsBuffer;
			bool flag39 = outgoingAcknowledgementsBuffer == null;
			object obj28 = obj5;
			int num6 = default;
			byte b9 = (byte)num6;
			bool flag5 = default;
			bool flag40 = flag5;
			bool flag4 = default;
			bool flag41 = flag4;
			int num5 = default;
			int num30 = num5;
			int num4 = default;
			int num31 = num4;
			int num3 = default;
			int num32 = num3;
			bool flag3 = default;
			bool flag42 = flag3;
			bool flag2 = default;
			bool flag43 = flag2;
			object obj2 = default;
			object obj29 = obj2;
			object obj = default;
			object obj30 = obj;
			num28 = 0;
			num27 = 0;
			num28 = 0;
			if (!flag39)
			{
				while (true)
				{
					int position = streamBuffer2.Position;
					StreamBuffer streamBuffer = outgoingAcknowledgementsBuffer;
					bool flag44 = outgoingAcknowledgementsBuffer == null;
					obj5 = obj28;
					flag5 = flag40;
					flag4 = flag41;
					num5 = num30;
					num4 = num31;
					num3 = num32;
					flag3 = flag42;
					flag2 = flag43;
					obj2 = obj29;
					obj = obj30;
					num27 = 0;
					if (flag44)
					{
						break;
					}
					int length = outgoingAcknowledgementsBuffer.Length;
					streamBuffer = (StreamBuffer)(position + 20);
					bool flag45 = (nint)streamBuffer < length;
					obj = !flag45;
					obj2 = streamBuffer - length;
					flag2 = (nint)obj2 < 0;
					flag3 = obj2 == null;
					num3 = streamBuffer ^ length;
					num4 = (object)streamBuffer ^ obj2;
					num5 = num3 & num4;
					flag4 = num5 < 0;
					obj5 = !flag3;
					flag5 = (nint)streamBuffer > length;
					num27 = 0;
					if (!flag5)
					{
						num27 = udpBufferIndex + 20;
						int num33 = CalculatePacketSize(num27);
						bool flag46 = photonPeer == null;
						streamBuffer = (StreamBuffer)(object)photonPeer;
						if (flag46)
						{
							break;
						}
						int maximumTransferUnit3 = photonPeer.MaximumTransferUnit;
						bool flag47 = num33 < maximumTransferUnit3;
						obj = !flag47;
						obj2 = num33 - maximumTransferUnit3;
						flag2 = (nint)obj2 < 0;
						flag3 = obj2 == null;
						num3 = num33 ^ maximumTransferUnit3;
						num4 = num33 ^ obj2;
						num5 = num3 & num4;
						flag4 = num5 < 0;
						obj5 = !flag3;
						flag5 = num33 > maximumTransferUnit3;
						streamBuffer = (StreamBuffer)(object)photonPeer;
						num27 = 0;
						if (!flag5)
						{
							bool flag48 = outgoingAcknowledgementsBuffer == null;
							streamBuffer = (StreamBuffer)(object)photonPeer;
							num27 = 0;
							if (flag48)
							{
								break;
							}
							byte[] bufferAndAdvance = outgoingAcknowledgementsBuffer.GetBufferAndAdvance(20, out num28);
							Buffer.BlockCopy(bufferAndAdvance, num28, udpBuffer, udpBufferIndex, 20);
							streamBuffer2 = outgoingAcknowledgementsBuffer;
							streamBuffer = (StreamBuffer)(udpBufferIndex + 20);
							b9 = (byte)(udpCommandCount + 1);
							udpBufferIndex = (int)streamBuffer;
							udpCommandCount = b9;
							bool flag49 = outgoingAcknowledgementsBuffer == null;
							object obj31 = !flag49;
							obj28 = obj5;
							flag40 = flag5;
							flag41 = flag4;
							num30 = num5;
							num31 = num4;
							num32 = num3;
							flag42 = flag3;
							flag43 = flag2;
							obj29 = obj2;
							obj30 = obj;
							byte b2 = 0;
							int num9 = 20;
							num27 = num28;
							if (obj31 == null)
							{
								break;
							}
							continue;
						}
					}
					goto IL_0f0a;
				}
			}
		}
		goto IL_0eff;
		IL_0f0a:
		if (outgoingAcknowledgementsBuffer != null)
		{
			outgoingAcknowledgementsBuffer.Compact();
			bool flag50 = outgoingAcknowledgementsBuffer == null;
			num27 = 0;
			if (!flag50)
			{
				int length2 = outgoingAcknowledgementsBuffer.Length;
				outgoingAcknowledgementsBuffer.Position = length2;
				if (outgoingAcknowledgementsBuffer != null)
				{
					int length3 = outgoingAcknowledgementsBuffer.Length;
					object obj32 = length3 * 1717986919;
					object obj33 = obj32 >> 63;
					object obj34 = obj32 >> 35;
					result = (int)(obj34 + obj33);
					goto IL_1443;
				}
			}
		}
		goto IL_0eff;
		IL_0eff:
		throw new NullReferenceException();
		IL_11c7:
		if ((nint)obj23 != 23)
		{
			bool flag51 = obj23 == null;
			object obj35 = !flag51;
			if (obj35 != null)
			{
				goto IL_1443;
			}
		}
		result = 0;
		goto IL_1443;
		IL_1443:
		return result;
	}

	internal int SerializeToBuffer(List<NCommand> commandList, int channelSequenceLimit)
	{
		//IL_039a: Expected I4, but got Obj
		//IL_0035: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected I4, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_040b: Expected I4, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		int result;
		if (commandList != null)
		{
			if (commandList._size == 0)
			{
				result = 0;
				goto IL_0429;
			}
			object obj = channelSequenceLimit - 1;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num = channelSequenceLimit ^ 1;
			int num2 = channelSequenceLimit ^ obj;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			object obj3 = flag4 & obj2;
			object obj4 = ~obj3;
			int num4;
			int num5;
			if (obj4 == null)
			{
				num4 = channelSequenceLimit;
				num5 = 0;
			}
			else
			{
				num4 = 1;
				num5 = 0;
			}
			while (true)
			{
				int size = commandList._size;
				System.__Canon _Canon;
				if (num5 < commandList._size)
				{
					_Canon = ((List<System.__Canon>)(object)commandList).get_Item(num5);
					if (_Canon == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10 (System.__Canon)+10]");
					object obj5 = (nint)0 & (nint)1;
					bool flag5 = obj5 == null;
					object obj6 = !flag5;
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10 (System.__Canon)+10]");
						object obj7 = (nint)0 & (nint)2;
						bool flag6 = obj7 == null;
						object obj8 = !flag6;
						if (obj8 == null)
						{
							bool flag7 = ((NCommand)(object)_Canon).commandType < 16;
							object obj9 = !flag7;
							object obj10 = ((NCommand)(object)_Canon).commandType - 16;
							bool flag8 = obj10 == null;
							object obj11 = !flag8;
							object obj12 = obj9 & obj11;
							if (obj12 == null)
							{
								PhotonPeer photonPeer = base.photonPeer;
								if (base.photonPeer == null)
								{
									break;
								}
								if (photonPeer.SendWindowSize >= 1 && ((NCommand)(object)_Canon).commandChannelID != 255)
								{
									if (((NCommand)(object)_Canon).startSequenceNumber != 0)
									{
										if (((NCommand)(object)_Canon).startSequenceNumber < num4)
										{
											goto IL_0162;
										}
									}
									else if (((NCommand)(object)_Canon).reliableSequenceNumber < channelSequenceLimit)
									{
										goto IL_0162;
									}
									num5++;
									if (num5 != 32)
									{
										continue;
									}
									size = commandList._size;
									num5 = commandList._size;
									goto IL_03e8;
								}
							}
						}
					}
					goto IL_0162;
				}
				goto IL_03e8;
				IL_03e8:
				object obj13 = size - num5;
				object obj14 = ~obj13;
				result = obj13 & obj14;
				int num6 = throttledBySendWindow + num5;
				throttledBySendWindow = num6;
				goto IL_0429;
				IL_0162:
				if (SerializeCommandToBuffer((NCommand)(object)_Canon, commandIsInSentQueue: false))
				{
					((List<System.__Canon>)(object)commandList).RemoveAt(num5);
					continue;
				}
				size = commandList._size;
				goto IL_03e8;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0429:
		return result;
	}

	private unsafe bool SerializeCommandToBuffer(NCommand command, bool commandIsInSentQueue = default(bool))
	{
		//IL_00f9: Expected I4, but got Obj
		//IL_0af0: Expected I4, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Ref, but got Unknown
		//IL_07a7: Expected I4, but got Obj
		//IL_01bc: Expected I, but got Obj
		//IL_08f1: Expected Obj, but got I4
		//IL_0904: Expected Obj, but got I4
		//IL_091e: Expected Obj, but got I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0958: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I8
		//IL_0286: Expected I, but got Obj
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_0a8a: Expected Obj, but got I
		//IL_0ba4: Expected I4, but got Obj
		//IL_08bb: Expected Obj, but got I4
		//IL_08cd: Expected I4, but got Obj
		//IL_03cd: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_0362: Expected I, but got Obj
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_04cf: Expected Obj, but got I8
		//IL_046c: Expected I, but got Obj
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_05b3: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I4
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_0548: Expected I, but got Obj
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_06bd: Expected Obj, but got I4
		//IL_06cd: Expected Obj, but got I4
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_0652: Expected I, but got Obj
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_0730: Expected Obj, but got I
		if (command == null)
		{
			goto IL_0a99;
		}
		NullReferenceException ex = default;
		if (command.commandType != 0 && command.Size != 0)
		{
			int inSize = command.Size + udpBufferIndex;
			int num = CalculatePacketSize(inSize);
			bool flag = base.photonPeer == null;
			bool flag2 = commandIsInSentQueue;
			if (!flag)
			{
				int maximumTransferUnit = base.photonPeer.MaximumTransferUnit;
				if (num > maximumTransferUnit)
				{
					return false;
				}
				ref int reference = ref *(int*)(this + 352);
				command.SerializeHeader(udpBuffer, ref reference);
				bool flag3 = command.Payload == null;
				flag2 = (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0;
				inSize = (int)udpBuffer;
				if (!flag3)
				{
					int length = command.Payload.Length;
					bool flag4 = length < 1;
					flag2 = (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0;
					inSize = 0;
					if (!flag4)
					{
						bool flag5 = command.Payload == null;
						flag2 = (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0;
						inSize = 0;
						if (flag5)
						{
							goto IL_0ac5;
						}
						byte[] buffer = command.Payload.GetBuffer();
						int count;
						if (command.Payload != null)
						{
							int length2 = command.Payload.Length;
							count = length2;
						}
						else
						{
							count = 0;
						}
						Buffer.BlockCopy(buffer, 0, udpBuffer, udpBufferIndex, count);
						bool flag6 = command.Payload == null;
						inSize = 0;
						int num2 = (int)command.Payload;
						if (!flag6)
						{
							num2 = command.Payload.Length;
							inSize = 0;
						}
						object obj = num2 + reference;
						reference = ref *(int*)obj;
						flag2 = (byte)(int)udpBuffer != 0;
					}
				}
				byte b = (byte)(udpCommandCount + 1);
				udpCommandCount = b;
				if ((command.commandFlags & 1) != 0)
				{
					bool flag7 = command.commandType < 16;
					object obj2 = !flag7;
					object obj3 = command.commandType - 16;
					bool flag8 = obj3 == null;
					object obj4 = !flag8;
					object obj5 = obj2 & obj4;
					if (obj5 == null)
					{
						bool flag9 = command.commandSentCount == 0;
						object obj6 = !flag9;
						if (obj6 == null)
						{
							PhotonPeer photonPeer = base.photonPeer;
							if (base.photonPeer != null)
							{
								TrafficStats trafficStats = photonPeer.Stats__BackingField;
								if (photonPeer.Stats__BackingField != null)
								{
									int num3 = ((TrafficStatsBase)trafficStats).UdpReliableCommandsSent__BackingField + 1;
									((TrafficStatsBase)trafficStats).UdpReliableCommandsSent__BackingField = num3;
									goto IL_0bb2;
								}
							}
							goto IL_0ac5;
						}
						goto IL_0bb2;
					}
				}
				PhotonPeer photonPeer2 = base.photonPeer;
				if (base.photonPeer != null)
				{
					TrafficStats trafficStats2 = photonPeer2.Stats__BackingField;
					if (photonPeer2.Stats__BackingField != null)
					{
						int num4 = ((TrafficStatsBase)trafficStats2).UdpUnreliableCommandsSent__BackingField + 1;
						((TrafficStatsBase)trafficStats2).UdpUnreliableCommandsSent__BackingField = num4;
						if (nCommandPool != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516278]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
							goto IL_0a99;
						}
					}
				}
			}
		}
		else
		{
			PhotonPeer photonPeer3 = base.photonPeer;
			bool flag10 = base.photonPeer == null;
			bool flag2 = commandIsInSentQueue;
			int inSize = (int)command;
			if (!flag10)
			{
				if (photonPeer3.LogLevel == 0)
				{
					goto IL_0a99;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object[] array = default;
				bool flag11 = array == null;
				flag2 = commandIsInSentQueue;
				object obj10 = default;
				inSize = (int)(&obj10);
				if (!flag11)
				{
					object obj11 = default;
					bool flag12 = obj11 == null;
					int num5 = (int)(&obj10);
					if (!flag12)
					{
						nint num6 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
						num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag13 = ex == null;
						flag2 = commandIsInSentQueue;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
						inSize = 0;
						if (flag13)
						{
							goto IL_0ad3;
						}
					}
					if (array.Length != 0)
					{
						object obj12 = array + 32;
						obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj13 = default;
						bool flag14 = obj13 == null;
						object obj14 = default;
						num5 = (int)(&obj14);
						if (!flag14)
						{
							nint num7 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
							num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag15 = ex == null;
							flag2 = commandIsInSentQueue;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
							inSize = 0;
							if (flag15)
							{
								goto IL_0ad3;
							}
						}
						object obj15 = array.Length & 0xFFFFFFFEL;
						if (obj15 != null)
						{
							object obj16 = array + 40;
							obj16 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj17 = default;
							bool flag16 = obj17 == null;
							object obj18 = default;
							num5 = (int)(&obj18);
							if (!flag16)
							{
								nint num8 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
								num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag17 = ex == null;
								flag2 = commandIsInSentQueue;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
								inSize = 0;
								if (flag17)
								{
									goto IL_0ad3;
								}
							}
							bool flag18 = array.Length < 2;
							object obj19 = !flag18;
							object obj20 = array.Length - 2;
							bool flag19 = obj20 == null;
							object obj21 = ~obj19;
							object obj22 = obj21 | flag19;
							if (obj22 == null)
							{
								object obj23 = array + 48;
								obj23 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj24 = default;
								bool flag20 = obj24 == null;
								object obj25 = default;
								num5 = (int)(&obj25);
								if (!flag20)
								{
									nint num9 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
									num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag21 = ex == null;
									flag2 = commandIsInSentQueue;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
									inSize = 0;
									if (flag21)
									{
										goto IL_0ad3;
									}
								}
								object obj26 = array.Length & 0xFFFFFFFCL;
								if (obj26 != null)
								{
									object obj27 = array + 56;
									obj27 = obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj28 = default;
									bool flag22 = obj28 == null;
									object obj29 = default;
									num5 = (int)(&obj29);
									if (!flag22)
									{
										nint num10 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
										num5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag23 = ex == null;
										flag2 = commandIsInSentQueue;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
										inSize = 0;
										if (flag23)
										{
											goto IL_0ad3;
										}
									}
									bool flag24 = array.Length < 4;
									object obj30 = !flag24;
									object obj31 = array.Length - 4;
									bool flag25 = obj31 == null;
									object obj32 = ~obj30;
									object obj33 = obj32 | flag25;
									if (obj33 == null)
									{
										object obj34 = array + 64;
										obj34 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										object obj35 = default;
										bool flag26 = obj35 == null;
										object obj36 = default;
										num5 = (int)(&obj36);
										if (!flag26)
										{
											nint num11 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
											num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag27 = ex == null;
											flag2 = commandIsInSentQueue;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
											inSize = 0;
											if (flag27)
											{
												goto IL_0ad3;
											}
										}
										bool flag28 = array.Length < 5;
										object obj37 = !flag28;
										object obj38 = array.Length - 5;
										bool flag29 = obj38 == null;
										object obj39 = ~obj37;
										object obj40 = obj39 | flag29;
										if (obj40 == null)
										{
											object obj41 = array + 72;
											obj41 = obj35;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516338]");
											object format = 0;
											string debugReturn = string.Format((string)format, array);
											EnqueueDebugReturn((LogLevel)1, debugReturn);
											return true;
										}
									}
								}
							}
						}
					}
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					flag2 = commandIsInSentQueue;
					inSize = num5;
				}
			}
		}
		goto IL_0ac5;
		IL_0bb2:
		QueueSentCommand(command, commandIsInSentQueue);
		goto IL_0a99;
		IL_0ac5:
		ex = new NullReferenceException();
		goto IL_0ad3;
		IL_0a99:
		return true;
		IL_0ad3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex3 = new ArgumentNullException();
		return (byte)(int)ex3 != 0;
	}

	internal unsafe void SendData(byte[] data, int length)
	{
		//IL_0028: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got Ref
		//IL_00ee: Expected Obj, but got I8
		//IL_011d: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I8
		//IL_019a: Expected I4, but got Obj
		//IL_03db: Expected I, but got Obj
		//IL_03e3: Expected Obj, but got I
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_056e: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got Ref
		//IL_024d: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got Ref
		//IL_02c2: Expected Obj, but got I4
		//IL_04b8: Expected I, but got Obj
		//IL_04c3: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		if (~(udpBufferEncryptedLayout ? 1u : 0u) == 0)
		{
			SendDataEncrypted(data, length);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int targetOffset = default;
		MessageProtocol.Serialize(peerID, data, ref targetOffset);
		byte[] array;
		object obj14;
		object obj15;
		if (base.photonPeer != null)
		{
			bool crcEnabled = base.photonPeer.CrcEnabled;
			bool flag2 = !crcEnabled;
			object obj4 = !flag2;
			object obj5 = ~obj4;
			object obj6 = ((obj5 != null) ? ((object)0) : ((object)4294967244L));
			bool flag3 = data == null;
			array = null;
			if (!flag3)
			{
				bool flag4 = data.Length < 2;
				object obj7 = !flag4;
				object obj8 = data.Length - 2;
				bool flag5 = obj8 == null;
				object obj9 = ~obj7;
				object obj10 = obj9 | flag5;
				array = null;
				if (obj10 != null)
				{
					goto IL_0357;
				}
				object obj11 = data.Length & 0xFFFFFFFCL;
				bool flag6 = obj11 == null;
				data[2] = (byte)(int)obj6;
				array = null;
				if (flag6)
				{
					goto IL_0365;
				}
				data[3] = udpCommandCount;
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v48+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				MessageProtocol.Serialize(timeIntCurrentSend, data, ref targetOffset);
				MessageProtocol.Serialize(challenge, data, ref targetOffset);
				bool flag8 = base.photonPeer == null;
				obj14 = 0;
				obj15 = (object)(&targetOffset);
				array = data;
				if (!flag8)
				{
					if (base.photonPeer.CrcEnabled)
					{
						object obj16 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v56+E4]");
						bool flag9 = (nint)0 == 0;
						object obj17 = !flag9;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						MessageProtocol.Serialize(0, data, ref targetOffset);
						uint value = SupportClass.CalculateCrc(data, length);
						MessageProtocol.Serialize((int)value, data, ref targetOffset);
					}
					SendToSocket(data, length);
					return;
				}
				goto IL_0384;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			array = data;
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0357;
		IL_0384:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag10 = (nint)array != 1;
		NullReferenceException ex4 = ex3;
		Exception ex6;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Exception ex5 = default;
			nint num = (nint)ex5;
			string text = (string)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj19 = default;
			object obj18 = obj19 & 1;
			bool flag11 = obj18 == null;
			ex6 = ex5;
			if (!flag11)
			{
				object obj20 = 0;
				ex6 = ex5;
				object obj22 = default;
				object obj21 = (object)(&obj22);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				PhotonPeer photonPeer = base.photonPeer;
				if (base.photonPeer != null)
				{
					if (photonPeer.LogLevel == 0)
					{
						goto IL_0533;
					}
					if (ex5 != null)
					{
						nint num2 = (nint)ex6;
						ushort num3 = ((Enum)(object)ex5).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						string text3 = default;
						string text2 = text3 + (string)num3;
						bool flag12 = photonPeer.Listener__BackingField == null;
						obj15 = 0;
						text = (string)num3;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
							goto IL_0533;
						}
					}
				}
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj23 = ex6;
			array = (byte[])(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj15 = 0;
			NullReferenceException ex7 = default;
			ex4 = ex7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0533:
		SupportClass.WriteStackTrace(ex6);
		return;
		IL_0365:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		obj14 = 0;
		obj15 = (object)(&targetOffset);
		goto IL_0384;
		IL_0357:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_0365;
	}

	private unsafe void SendToSocket(byte[] data, int length)
	{
		//IL_0044: Expected Obj, but got I
		//IL_0056: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_0220: Expected I4, but got I8
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		PhotonPeer photonPeer = base.photonPeer;
		ITrafficRecorder trafficRecorder = photonPeer.TrafficRecorder;
		if (photonPeer.TrafficRecorder == null)
		{
			goto IL_0111;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		nint num = (nint)trafficRecorder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12 (Il2CppClass<Photon.Client.ITrafficRecorder>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12 (Il2CppClass<Photon.Client.ITrafficRecorder>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12 (Il2CppClass<Photon.Client.ITrafficRecorder>)+98]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X10_v9-8]");
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
			goto IL_00e2;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		goto IL_0283;
		IL_0283:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v293 @ X0_v17] (should have been resolved before IL gen)");
		photonPeer = base.photonPeer;
		goto IL_0111;
		IL_0111:
		TrafficStats trafficStats = photonPeer.Stats__BackingField;
		int num3 = default;
		long num2 = ((TrafficStatsBase)trafficStats).BytesOut__BackingField + num3;
		NetworkSimulationSet networkSimulationSet = base.networkSimulationSettings;
		int num4 = ((TrafficStatsBase)trafficStats).PackagesOut__BackingField + 1;
		((TrafficStatsBase)trafficStats).PackagesOut__BackingField = num4;
		((TrafficStatsBase)trafficStats).BytesOut__BackingField = num2;
		if (~(networkSimulationSet.isSimulationEnabled ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Array array = default;
			Buffer.BlockCopy(data, 0, array, 0, num3);
			SendNetworkSimulated((byte[])array);
			return;
		}
		long elapsedMilliseconds = watch.ElapsedMilliseconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		bool isEmpty = ((NetPeerGroup.List*)PhotonSocket)->IsEmpty;
		long elapsedMilliseconds2 = watch.ElapsedMilliseconds;
		int num5 = (int)(elapsedMilliseconds2 - elapsedMilliseconds);
		if (num5 > longestSendCall)
		{
			longestSendCall = num5;
		}
		return;
		IL_00e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0283;
	}

	private void SendDataEncrypted(byte[] data, int length)
	{
		//IL_0085: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_029d: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got I
		//IL_03ef: Expected I4, but got Obj
		//IL_02f8: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		byte[] array = bufferForEncryption;
		if (bufferForEncryption != null)
		{
			if (base.photonPeer == null)
			{
				goto IL_0376;
			}
			int maximumTransferUnit = base.photonPeer.MaximumTransferUnit;
			bool flag = maximumTransferUnit == array.Length;
			byte[] array2 = null;
			if (flag)
			{
				goto IL_00cf;
			}
		}
		if (base.photonPeer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj = 0;
			int maximumTransferUnit2 = base.photonPeer.MaximumTransferUnit;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			byte[] array3 = default;
			bufferForEncryption = array3;
			object obj2 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			byte[] array2 = array3;
			goto IL_00cf;
		}
		goto IL_0376;
		IL_03d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X0_v12] (should have been resolved before IL gen)");
		object obj3;
		object obj4 = default;
		int length2 = (int)(obj3 + obj4);
		SendToSocket(bufferForEncryption, length2);
		return;
		IL_0376:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0384;
		IL_0339:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_03d8;
		IL_0384:
		throw new IndexOutOfRangeException();
		IL_00cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
		object obj5 = 0;
		byte[] array4 = bufferForEncryption;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int targetOffset = default;
		MessageProtocol.Serialize(peerID, bufferForEncryption, ref targetOffset);
		if (bufferForEncryption != null)
		{
			bool flag3 = array4.Length < 2;
			object obj8 = !flag3;
			object obj9 = array4.Length - 2;
			bool flag4 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag4;
			if (obj11 != null)
			{
				goto IL_0384;
			}
			array4[2] = 1;
			obj3 = targetOffset + 1;
			MessageProtocol.Serialize(challenge, bufferForEncryption, ref targetOffset);
			if (data != null)
			{
				data[0] = udpCommandCount;
				int targetOffset2 = default;
				MessageProtocol.Serialize(timeIntCurrentSend, data, ref targetOffset2);
				PhotonPeer photonPeer = base.photonPeer;
				if (base.photonPeer != null)
				{
					IPhotonEncryptor encryptor = photonPeer.Encryptor;
					if (photonPeer.Encryptor != null)
					{
						nint num = (nint)encryptor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49E0]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v18 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v18 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0339;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v18 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+98]");
						object obj14 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X10_v7-8]");
							if (0 == (nint)obj12)
							{
								break;
							}
							obj13--;
							obj14 += 16;
							if ((nint)obj13 != 1)
							{
								continue;
							}
							goto IL_0339;
						}
						object obj15 = obj14 + 3;
						object obj16 = num + obj15;
						object obj17 = obj16 + 312;
						goto IL_03d8;
					}
				}
			}
		}
		goto IL_0376;
	}

	internal unsafe void QueueSentCommand(NCommand command, bool commandIsAlreadyInSentQueue = default(bool))
	{
		//IL_015e: Invalid comparison between F4 and I4
		//IL_016e: Expected F4, but got I4
		//IL_0178: Expected F4, but got I4
		//IL_0850: Expected I4, but got Obj
		//IL_0195: Invalid comparison between F4 and I4
		//IL_01a5: Expected F4, but got I4
		//IL_01af: Expected F4, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_0269: Expected F4, but got I
		//IL_027a: Expected I4, but got F4
		//IL_029b: Expected F4, but got I
		//IL_01c7: Expected F4, but got I4
		//IL_0756: Expected Obj, but got I4
		//IL_00c5: Expected I4, but got Obj
		//IL_02f5: Expected F4, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_068e: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got I4
		//IL_08bd: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got Ref
		//IL_0443: Expected Obj, but got Ref
		//IL_0469: Expected Obj, but got I
		//IL_047e: Expected I4, but got Obj
		//IL_04bb: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got Ref
		//IL_04f4: Expected Obj, but got Ref
		//IL_0522: Expected Obj, but got I4
		//IL_05d4: Expected Obj, but got I
		//IL_05e4: Expected Obj, but got I
		//IL_060c: Expected Obj, but got I4
		//IL_0621: Expected Obj, but got Ref
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_0590: Expected Obj, but got I4
		//IL_05a5: Expected Obj, but got Ref
		bool flag = command == null;
		NCommand nCommand = command;
		int num = 109924352;
		PhotonPeer photonPeer;
		int num6;
		int roundTripTimeout;
		if (!flag)
		{
			roundTripTimeout = command.roundTripTimeout;
			command.commandSentTime = timeIntCurrentSend;
			if (command.roundTripTimeout != 0)
			{
				bool flag2 = base.photonPeer == null;
				nCommand = command;
				num = 109924352;
				if (!flag2)
				{
					num = command.commandSentCount;
					byte quickResendAttempts = base.photonPeer.QuickResendAttempts;
					bool flag3 = command.commandSentCount < quickResendAttempts;
					object obj = !flag3;
					if (obj == null)
					{
						roundTripTimeout = (int)sentReliableCommands;
						bool flag4 = sentReliableCommands == null;
						nCommand = null;
						if (!flag4)
						{
							photonPeer = base.photonPeer;
							bool flag5 = base.photonPeer == null;
							nCommand = null;
							if (!flag5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v6 (System.Int32)+18]");
								if ((nint)0 >= (nint)photonPeer.SendWindowSize)
								{
									goto IL_0328;
								}
								goto IL_07e0;
							}
						}
					}
					else
					{
						photonPeer = base.photonPeer;
						bool flag6 = base.photonPeer == null;
						nCommand = null;
						if (!flag6)
						{
							goto IL_0328;
						}
					}
				}
			}
			else
			{
				float num2 = roundTripTimeVariance;
				bool flag7 = roundTripTimeVariance < (float)varianceJitterMin;
				float num3 = varianceJitterMin;
				float num4 = varianceJitterMin;
				if (!flag7)
				{
					bool flag8 = roundTripTimeVariance > (float)varianceJitterMax;
					num3 = varianceJitterMax;
					num4 = varianceJitterMax;
					if (!flag8)
					{
						num3 = varianceJitterMax;
						num4 = roundTripTimeVariance;
					}
				}
				roundTripTimeout = (int)base.photonPeer;
				bool flag9 = base.photonPeer == null;
				nCommand = command;
				num = 109924352;
				if (!flag9)
				{
					float num5 = (float)varianceJitterFactor * num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					num6 = 0;
					int value = ((int*)num6)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v31 (System.Int32)+E4]");
					bool flag10 = (nint)0 == 0;
					object obj2 = !flag10;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float val = roundTripTime + num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v6 (System.Int32)+50]");
					num2 = Math.Min(val, 0f);
					command.roundTripTimeout = (int)num2;
					bool flag11 = base.photonPeer == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v6 (System.Int32)+50]");
					num3 = 0f;
					nCommand = command;
					num = 109924352;
					if (!flag11)
					{
						int disconnectTimeout = base.photonPeer.DisconnectTimeout;
						int timeoutTime = disconnectTimeout + timeIntCurrentSend;
						command.timeoutTime = timeoutTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v6 (System.Int32)+50]");
						num3 = 0f;
						goto IL_07e0;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		object obj3 = null;
		bool lockTaken = false;
		goto IL_06e9;
		IL_06e9:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06f7;
		IL_0705:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj4 = default;
		System.__Canon _Canon;
		OutOfMemoryException ex3 = default;
		if ((nint)nCommand == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj4 = 1;
			_Canon = (System.__Canon)(object)nCommand;
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
			object obj5 = default;
			ex3 = (OutOfMemoryException)obj5;
			_Canon = (System.__Canon)(object)nCommand;
		}
		goto IL_0637;
		IL_06f7:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_0705;
		IL_07e0:
		num6 = command.commandSentCount;
		int num7 = command.roundTripTimeout + command.commandSentTime;
		byte commandSentCount = (byte)(command.commandSentCount + 1);
		command.commandSentCount = commandSentCount;
		if (num7 < timeoutInt)
		{
			timeoutInt = num7;
		}
		bool flag13 = default;
		bool flag12 = !flag13;
		object obj6 = !flag12;
		if (obj6 != null)
		{
			return;
		}
		Monitor.Enter(sentReliableCommands, ref lockTaken);
		List<System.__Canon> list = (List<System.__Canon>)(object)sentReliableCommands;
		bool flag14 = sentReliableCommands == null;
		obj4 = 0;
		ex3 = null;
		int num8 = (int)(&obj3);
		object obj7 = (object)(&lockTaken);
		obj3 = sentReliableCommands;
		lockTaken = false;
		flag13 = false;
		nCommand = (NCommand)(&lockTaken);
		roundTripTimeout = (int)(&obj3);
		if (!flag14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161A8]");
			object obj8 = 0;
			System.__Canon[] items = list._items;
			roundTripTimeout = (int)obj8;
			num6 = list._version + 1;
			list._version = num6;
			bool flag15 = list._items == null;
			obj4 = 0;
			ex3 = null;
			num8 = (int)(&obj3);
			obj7 = (object)(&lockTaken);
			obj3 = sentReliableCommands;
			lockTaken = false;
			flag13 = false;
			nCommand = (NCommand)(&lockTaken);
			if (!flag15)
			{
				bool flag16 = list._size < items.Length;
				object obj9 = !flag16;
				if (obj9 == null)
				{
					object obj10 = list._items + list._size;
					roundTripTimeout = list._size + 1;
					list._size = roundTripTimeout;
					object obj11 = obj10 + 32;
					obj11 = command;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj4 = 0;
					ex3 = null;
					num8 = (int)(&obj3);
					obj7 = (object)(&lockTaken);
					lockTaken = false;
					flag13 = false;
					_Canon = (System.__Canon)(object)command;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v6 (System.Int32)+20]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v22+A8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v23+70]");
					flag13 = false;
					((List<System.__Canon>)(object)sentReliableCommands).AddWithResize((System.__Canon)(object)command);
					obj4 = 0;
					ex3 = null;
					num8 = (int)(&obj3);
					obj7 = (object)(&lockTaken);
					lockTaken = false;
					_Canon = (System.__Canon)(object)command;
				}
				goto IL_0637;
			}
		}
		goto IL_06e9;
		IL_0328:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj14 = 0;
		object obj15 = obj14;
		num = command.roundTripTimeout << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v39+E4]");
		bool flag17 = (nint)0 == 0;
		object obj16 = !flag17;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int val2 = photonPeer.InitialResendTimeMax << 1;
		int roundTripTimeout2 = Math.Min(num, val2);
		command.roundTripTimeout = roundTripTimeout2;
		goto IL_07e0;
		IL_0637:
		bool flag18 = obj7 == null;
		nCommand = (NCommand)(object)_Canon;
		if (!flag18)
		{
			Monitor.Exit(((int*)num8)->m_value);
			nCommand = null;
		}
		bool flag19 = ex3 == null;
		object obj17 = !flag19;
		if (obj17 != null)
		{
			goto IL_06f7;
		}
		bool flag20 = obj4 == null;
		object obj18 = !flag20;
		ex4 = ex3;
		if (obj18 == null)
		{
			return;
		}
		goto IL_0705;
	}

	internal unsafe void QueueOutgoingReliableCommand(NCommand command)
	{
		//IL_00af: Expected Obj, but got I4
		//IL_0157: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got Ref
		//IL_0196: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got Ref
		//IL_0110: Expected Obj, but got Ref
		//IL_0408: Expected I, but got Obj
		//IL_0411: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got Ref
		//IL_0437: Expected Obj, but got Ref
		//IL_01d9: Expected Obj, but got I
		//IL_01ee: Expected I4, but got Obj
		//IL_04cd: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got Ref
		//IL_0397: Expected Obj, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02ba: Expected I, but got Obj
		//IL_02c3: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got Ref
		//IL_03e3: Expected Obj, but got I4
		NCommand nCommand = default;
		bool flag = nCommand == null;
		EnetChannel enetChannel = null;
		bool lockTaken = false;
		if (flag)
		{
			goto IL_043c;
		}
		EnetChannel channel = GetChannel(nCommand.commandChannelID);
		Monitor.Enter(channel, ref lockTaken);
		if (nCommand.reliableSequenceNumber != 0)
		{
			bool flag2 = channel == null;
			object obj = !flag2;
			if (obj != null)
			{
				goto IL_0554;
			}
			NullReferenceException ex = new NullReferenceException();
		}
		int num = nCommand.commandFlags & 2;
		bool flag3 = num == 0;
		object obj2 = !flag3;
		object obj3 = default;
		OutOfMemoryException ex2 = default;
		int num3 = default;
		object obj4 = default;
		NCommand nCommand2;
		int reliableSequenceNumber;
		int num4;
		nint num2;
		if (obj2 == null)
		{
			bool flag4 = channel == null;
			num2 = unchecked((nint)null);
			obj3 = 0;
			ex2 = null;
			num3 = (int)(&enetChannel);
			obj4 = (object)(&lockTaken);
			enetChannel = channel;
			lockTaken = false;
			num4 = (int)(&enetChannel);
			nCommand2 = (NCommand)(&lockTaken);
			if (flag4)
			{
				goto IL_046f;
			}
			reliableSequenceNumber = ++channel.outgoingReliableSequenceNumber;
		}
		else
		{
			bool flag5 = channel == null;
			num2 = unchecked((nint)null);
			obj3 = 0;
			ex2 = null;
			num3 = (int)(&enetChannel);
			obj4 = (object)(&lockTaken);
			enetChannel = channel;
			lockTaken = false;
			num4 = (int)(&enetChannel);
			nCommand2 = (NCommand)(&lockTaken);
			if (flag5)
			{
				goto IL_047d;
			}
			reliableSequenceNumber = ++channel.outgoingReliableUnsequencedNumber;
		}
		nCommand.reliableSequenceNumber = reliableSequenceNumber;
		goto IL_0554;
		IL_0458:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		nCommand2 = nCommand;
		goto IL_046f;
		IL_0554:
		List<System.__Canon> outgoingReliableCommandsList = (List<System.__Canon>)(object)channel.outgoingReliableCommandsList;
		bool flag6 = channel.outgoingReliableCommandsList == null;
		num4 = (int)(&enetChannel);
		System.__Canon _Canon;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161A8]");
			object obj5 = 0;
			System.__Canon[] items = outgoingReliableCommandsList._items;
			num4 = (int)obj5;
			int version = outgoingReliableCommandsList._version + 1;
			outgoingReliableCommandsList._version = version;
			if (outgoingReliableCommandsList._items != null)
			{
				bool flag7 = outgoingReliableCommandsList._size < items.Length;
				object obj6 = !flag7;
				if (obj6 == null)
				{
					object obj7 = outgoingReliableCommandsList._items + outgoingReliableCommandsList._size;
					num4 = outgoingReliableCommandsList._size + 1;
					outgoingReliableCommandsList._size = num4;
					object obj8 = obj7 + 32;
					obj8 = nCommand;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num2 = unchecked((nint)null);
					obj3 = 0;
					ex2 = null;
					num3 = (int)(&enetChannel);
					obj4 = (object)(&lockTaken);
					lockTaken = false;
					_Canon = (System.__Canon)(object)nCommand;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X9_v6 (System.Int32)+20]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v21+A8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v22+70]");
					num2 = 0;
					((List<System.__Canon>)(object)channel.outgoingReliableCommandsList).AddWithResize((System.__Canon)(object)nCommand);
					obj3 = 0;
					ex2 = null;
					num3 = (int)(&enetChannel);
					obj4 = (object)(&lockTaken);
					lockTaken = false;
					_Canon = (System.__Canon)(object)nCommand;
				}
				goto IL_0364;
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		num2 = unchecked((nint)null);
		obj3 = 0;
		ex2 = null;
		num3 = (int)(&enetChannel);
		obj4 = (object)(&lockTaken);
		lockTaken = false;
		nCommand = (NCommand)(&lockTaken);
		goto IL_043c;
		IL_047d:
		NullReferenceException ex4 = new NullReferenceException();
		if ((nint)nCommand2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj3 = 1;
			_Canon = (System.__Canon)(object)nCommand2;
		}
		else
		{
			if ((nint)nCommand2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj11 = default;
			ex2 = (OutOfMemoryException)obj11;
			_Canon = (System.__Canon)(object)nCommand2;
		}
		goto IL_0364;
		IL_0364:
		bool flag8 = obj4 == null;
		nCommand = (NCommand)(object)_Canon;
		if (!flag8)
		{
			Monitor.Exit(((int*)num3)->m_value);
			nCommand = null;
		}
		bool flag9 = ex2 == null;
		object obj12 = !flag9;
		if (obj12 != null)
		{
			goto IL_044a;
		}
		bool flag10 = obj3 == null;
		object obj13 = !flag10;
		OutOfMemoryException ex5 = ex2;
		if (obj13 == null)
		{
			return;
		}
		goto IL_0458;
		IL_046f:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_047d;
		IL_044a:
		ex5 = new OutOfMemoryException();
		goto IL_0458;
		IL_043c:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_044a;
	}

	internal unsafe void QueueOutgoingUnreliableCommand(NCommand command)
	{
		//IL_0057: Expected Obj, but got I4
		//IL_08d1: Expected I, but got Obj
		//IL_08da: Expected Obj, but got I4
		//IL_08ef: Expected Obj, but got Ref
		//IL_0908: Expected Obj, but got I4
		//IL_0910: Expected Obj, but got Ref
		//IL_0079: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got Ref
		//IL_00b0: Expected Obj, but got Ref
		//IL_00b8: Expected Obj, but got Ref
		//IL_0166: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_0360: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got Ref
		//IL_039c: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got Ref
		//IL_01ac: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got Ref
		//IL_01e3: Expected Obj, but got Ref
		//IL_03d8: Expected I, but got Obj
		//IL_03e1: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got Ref
		//IL_040f: Expected Obj, but got Ref
		//IL_0829: Expected Obj, but got I4
		//IL_046b: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I4
		//IL_0489: Expected Obj, but got Ref
		//IL_04af: Expected Obj, but got Ref
		//IL_0732: Expected I, but got Obj
		//IL_073b: Expected Obj, but got I4
		//IL_0750: Expected Obj, but got Ref
		//IL_0761: Expected Obj, but got Ref
		//IL_06d5: Expected Obj, but got I4
		//IL_04e7: Expected Obj, but got I4
		//IL_06b1: Expected Obj, but got I4
		//IL_0618: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I4
		//IL_0668: Expected Obj, but got Ref
		//IL_02a1: Expected Obj, but got I4
		//IL_0705: Expected Obj, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0551: Expected I, but got Obj
		//IL_055a: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got Ref
		//IL_0595: Expected Obj, but got I
		//IL_05a5: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I4
		//IL_05e5: Expected Obj, but got Ref
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_030b: Expected I, but got Obj
		//IL_0314: Expected Obj, but got I4
		//IL_0329: Expected Obj, but got Ref
		NCommand nCommand = default;
		bool flag = nCommand == null;
		EnetChannel enetChannel = null;
		bool lockTaken = false;
		object obj2 = default;
		OutOfMemoryException ex = default;
		int num3 = default;
		object obj3 = default;
		System.__Canon[] array;
		NCommand nCommand2;
		System.__Canon[] array2 = default;
		System.__Canon _Canon;
		if (!flag)
		{
			EnetChannel channel = GetChannel(nCommand.commandChannelID);
			Monitor.Enter(channel, ref lockTaken);
			int num = nCommand.commandFlags & 2;
			bool flag2 = num == 0;
			object obj = !flag2;
			int num4;
			nint num2;
			if (obj == null)
			{
				bool flag3 = channel == null;
				num2 = unchecked((nint)null);
				obj2 = 0;
				ex = null;
				num3 = (int)(&enetChannel);
				obj3 = (object)(&lockTaken);
				enetChannel = channel;
				lockTaken = false;
				array = (System.__Canon[])(&enetChannel);
				nCommand2 = (NCommand)(&lockTaken);
				if (flag3)
				{
					goto IL_07cb;
				}
				num4 = channel.outgoingReliableSequenceNumber;
				int unreliableSequenceNumber = ++channel.outgoingUnreliableSequenceNumber;
				nCommand.reliableSequenceNumber = channel.outgoingReliableSequenceNumber;
				nCommand.unreliableSequenceNumber = unreliableSequenceNumber;
			}
			else
			{
				nCommand.reliableSequenceNumber = 0;
				nCommand.unsequencedGroupNumber = ++outgoingUnsequencedGroupNumber;
				num4 = (int)(&enetChannel);
			}
			PhotonPeer photonPeer = base.photonPeer;
			bool flag4 = base.photonPeer == null;
			num2 = unchecked((nint)null);
			obj2 = 0;
			ex = null;
			num3 = (int)(&enetChannel);
			obj3 = (object)(&lockTaken);
			enetChannel = channel;
			lockTaken = false;
			array2 = (System.__Canon[])num4;
			nCommand2 = (NCommand)(&lockTaken);
			if (flag4)
			{
				goto IL_0799;
			}
			array2 = (System.__Canon[])photonPeer.SendInCreationOrder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161A8]");
			object obj4 = 0;
			if (!photonPeer.SendInCreationOrder)
			{
				bool flag5 = channel == null;
				num2 = unchecked((nint)null);
				obj2 = 0;
				ex = null;
				num3 = (int)(&enetChannel);
				obj3 = (object)(&lockTaken);
				enetChannel = channel;
				lockTaken = false;
				array = (System.__Canon[])photonPeer.SendInCreationOrder;
				nCommand2 = (NCommand)(&lockTaken);
				if (!flag5)
				{
					List<System.__Canon> outgoingUnreliableCommandsList = (List<System.__Canon>)(object)channel.outgoingUnreliableCommandsList;
					bool flag6 = channel.outgoingUnreliableCommandsList == null;
					num2 = unchecked((nint)null);
					obj2 = 0;
					ex = null;
					num3 = (int)(&enetChannel);
					obj3 = (object)(&lockTaken);
					enetChannel = channel;
					lockTaken = false;
					nCommand2 = (NCommand)(&lockTaken);
					if (!flag6)
					{
						array = outgoingUnreliableCommandsList._items;
						object obj5 = obj4;
						int version = outgoingUnreliableCommandsList._version + 1;
						outgoingUnreliableCommandsList._version = version;
						bool flag7 = outgoingUnreliableCommandsList._items == null;
						num2 = unchecked((nint)null);
						obj2 = 0;
						ex = null;
						num3 = (int)(&enetChannel);
						obj3 = (object)(&lockTaken);
						enetChannel = channel;
						lockTaken = false;
						array2 = outgoingUnreliableCommandsList._items;
						nCommand2 = (NCommand)(&lockTaken);
						if (!flag7)
						{
							int num5 = array.Length;
							bool flag8 = outgoingUnreliableCommandsList._size < array.Length;
							object obj6 = !flag8;
							if (obj6 == null)
							{
								object obj7 = outgoingUnreliableCommandsList._items + outgoingUnreliableCommandsList._size;
								num5 = outgoingUnreliableCommandsList._size + 1;
								outgoingUnreliableCommandsList._size = num5;
								object obj8 = obj7 + 32;
								obj8 = nCommand;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								num2 = unchecked((nint)null);
								obj2 = 0;
								ex = null;
								num3 = (int)(&enetChannel);
								obj3 = (object)(&lockTaken);
								lockTaken = false;
								_Canon = (System.__Canon)(object)nCommand;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v25+20]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v26+A8]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v27+70]");
								num2 = 0;
								((List<System.__Canon>)(object)channel.outgoingUnreliableCommandsList).AddWithResize((System.__Canon)(object)nCommand);
								obj2 = 0;
								ex = null;
								num3 = (int)(&enetChannel);
								obj3 = (object)(&lockTaken);
								lockTaken = false;
								_Canon = (System.__Canon)(object)nCommand;
							}
							goto IL_067e;
						}
					}
					goto IL_07a7;
				}
				goto IL_07d9;
			}
			bool flag9 = channel == null;
			num2 = unchecked((nint)null);
			obj2 = 0;
			ex = null;
			num3 = (int)(&enetChannel);
			obj3 = (object)(&lockTaken);
			enetChannel = channel;
			lockTaken = false;
			nCommand2 = (NCommand)(&lockTaken);
			if (flag9)
			{
				goto IL_07b5;
			}
			List<System.__Canon> outgoingReliableCommandsList = (List<System.__Canon>)(object)channel.outgoingReliableCommandsList;
			if (channel.outgoingReliableCommandsList != null)
			{
				array2 = outgoingReliableCommandsList._items;
				object obj11 = obj4;
				int version = outgoingReliableCommandsList._version + 1;
				outgoingReliableCommandsList._version = version;
				if (outgoingReliableCommandsList._items != null)
				{
					int num5 = array2.Length;
					bool flag10 = outgoingReliableCommandsList._size < array2.Length;
					object obj12 = !flag10;
					if (obj12 == null)
					{
						object obj13 = outgoingReliableCommandsList._items + outgoingReliableCommandsList._size;
						num5 = outgoingReliableCommandsList._size + 1;
						outgoingReliableCommandsList._size = num5;
						object obj14 = obj13 + 32;
						obj14 = nCommand;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						num2 = unchecked((nint)null);
						obj2 = 0;
						ex = null;
						num3 = (int)(&enetChannel);
						obj3 = (object)(&lockTaken);
						lockTaken = false;
						array = outgoingReliableCommandsList._items;
						_Canon = (System.__Canon)(object)nCommand;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v31+20]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v32+A8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v33+70]");
						num2 = 0;
						((List<System.__Canon>)(object)channel.outgoingReliableCommandsList).AddWithResize((System.__Canon)(object)nCommand);
						obj2 = 0;
						ex = null;
						num3 = (int)(&enetChannel);
						obj3 = (object)(&lockTaken);
						lockTaken = false;
						array = outgoingReliableCommandsList._items;
						_Canon = (System.__Canon)(object)nCommand;
					}
					goto IL_067e;
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			num2 = unchecked((nint)null);
			obj2 = 0;
			ex = null;
			num3 = (int)(&enetChannel);
			obj3 = (object)(&lockTaken);
			lockTaken = false;
			nCommand = (NCommand)(&lockTaken);
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0774;
		IL_0782:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		nCommand2 = nCommand;
		goto IL_0799;
		IL_07cb:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_07d9;
		IL_0799:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_07a7;
		IL_067e:
		bool flag11 = obj3 == null;
		nCommand = (NCommand)(object)_Canon;
		if (!flag11)
		{
			Monitor.Exit(((int*)num3)->m_value);
			nCommand = null;
		}
		bool flag12 = ex == null;
		object obj17 = !flag12;
		array2 = array;
		if (obj17 != null)
		{
			goto IL_0774;
		}
		bool flag13 = obj2 == null;
		object obj18 = !flag13;
		array2 = array;
		OutOfMemoryException ex6 = ex;
		if (obj18 == null)
		{
			return;
		}
		goto IL_0782;
		IL_07a7:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_07b5;
		IL_07d9:
		NullReferenceException ex8 = new NullReferenceException();
		if ((nint)nCommand2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
			_Canon = (System.__Canon)(object)nCommand2;
		}
		else
		{
			if ((nint)nCommand2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj19 = default;
			ex = (OutOfMemoryException)obj19;
			_Canon = (System.__Canon)(object)nCommand2;
		}
		goto IL_067e;
		IL_07b5:
		NullReferenceException ex9 = new NullReferenceException();
		array = array2;
		goto IL_07cb;
		IL_0774:
		ex6 = new OutOfMemoryException();
		goto IL_0782;
	}

	internal unsafe void QueueOutgoingAcknowledgement(NCommand readCommand, int sendTime)
	{
		//IL_02fa: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got Ref
		//IL_030f: Expected Obj, but got Ref
		//IL_009b: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got Ref
		//IL_00b0: Expected Obj, but got Ref
		//IL_037d: Expected Obj, but got I4
		//IL_038a: Expected Obj, but got Ref
		//IL_0392: Expected Obj, but got Ref
		//IL_0134: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got Ref
		//IL_0149: Expected Obj, but got Ref
		//IL_03fc: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got Ref
		//IL_01cc: Expected Obj, but got Ref
		//IL_01da: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got Ref
		//IL_01ef: Expected Obj, but got Ref
		//IL_04c4: Expected Obj, but got I4
		//IL_04cc: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got I4
		//IL_0245: Expected I4, but got Obj
		//IL_052a: Expected Obj, but got I4
		//IL_0532: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_0561: Expected Obj, but got I4
		bool flag = useAck2;
		bool flag2 = !flag;
		int offset = 0;
		bool lockTaken = false;
		object obj = null;
		bool lockTaken2 = false;
		EnetChannel enetChannel = null;
		bool lockTaken3 = false;
		object obj2 = null;
		EnetPeer enetPeer = this;
		NCommand nCommand2 = default;
		NCommand nCommand = nCommand2;
		if (flag2)
		{
			goto IL_02be;
		}
		Monitor.Enter(channelArray, ref lockTaken3);
		bool flag3 = nCommand2 == null;
		NCommand nCommand3 = null;
		int num = (int)(&lockTaken3);
		object obj3 = 0;
		OutOfMemoryException ex = null;
		object obj4 = (object)(&obj2);
		object obj5 = (object)(&lockTaken3);
		offset = 0;
		lockTaken = false;
		obj = null;
		lockTaken2 = false;
		enetChannel = null;
		lockTaken3 = false;
		obj2 = channelArray;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		if (!flag3)
		{
			EnetChannel channel = GetChannel(nCommand2.commandChannelID);
			bool flag4 = channel == null;
			nCommand3 = null;
			num = nCommand2.commandChannelID;
			obj3 = 0;
			ex = null;
			obj4 = (object)(&obj2);
			obj5 = (object)(&lockTaken3);
			offset = 0;
			lockTaken = false;
			obj = null;
			lockTaken2 = false;
			enetChannel = null;
			lockTaken3 = false;
			obj2 = channelArray;
			if (!flag4)
			{
				Monitor.Enter(channel, ref lockTaken2);
				channel.Received(nCommand2);
				obj6 = 0;
				obj7 = 0;
				obj8 = (object)(&enetChannel);
				obj9 = (object)(&lockTaken2);
				nCommand3 = null;
				obj3 = 0;
				ex = null;
				obj4 = (object)(&obj2);
				obj5 = (object)(&lockTaken3);
				offset = 0;
				lockTaken = false;
				obj = null;
				lockTaken2 = false;
				lockTaken3 = false;
				enetPeer = (EnetPeer)(object)channel;
				nCommand = nCommand2;
				goto IL_022e;
			}
			goto IL_03ae;
		}
		goto IL_0458;
		IL_03ae:
		if (obj5 != null)
		{
			Monitor.Exit(obj4);
			num = 0;
		}
		bool flag5 = ex == null;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			bool flag6 = obj3 == null;
			object obj11 = !flag6;
			OutOfMemoryException ex2 = ex;
			if (obj11 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0458;
		IL_0466:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0474;
		IL_02be:
		Monitor.Enter(enetPeer.outgoingAcknowledgementsBuffer, ref lockTaken);
		bool flag7 = enetPeer.outgoingAcknowledgementsBuffer == null;
		nCommand3 = null;
		num = (int)(&lockTaken);
		obj3 = 0;
		ex = null;
		obj4 = (object)(&obj);
		obj5 = (object)(&lockTaken);
		lockTaken = false;
		obj = enetPeer.outgoingAcknowledgementsBuffer;
		if (!flag7)
		{
			byte[] bufferAndAdvance = enetPeer.outgoingAcknowledgementsBuffer.GetBufferAndAdvance(20, out offset);
			NCommand.CreateAck(bufferAndAdvance, offset, nCommand, sendTime);
			nCommand3 = nCommand;
			num = offset;
			obj3 = 0;
			ex = null;
			obj4 = (object)(&obj);
			obj5 = (object)(&lockTaken);
			lockTaken = false;
			obj = enetPeer.outgoingAcknowledgementsBuffer;
			goto IL_03ae;
		}
		goto IL_0466;
		IL_022e:
		bool flag8 = obj9 == null;
		num = (int)nCommand2;
		if (!flag8)
		{
			Monitor.Exit(obj8);
			num = 0;
		}
		bool flag9 = obj7 == null;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_02be;
			}
			goto IL_03ae;
		}
		goto IL_0474;
		IL_0458:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0466;
		IL_0474:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj6 = 1;
			nCommand2 = (NCommand)num;
			enetPeer = (EnetPeer)num;
			nCommand = (NCommand)(object)ex5;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				if (num == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj3 = 1;
				}
				else
				{
					if (num != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj13 = default;
					ex = (OutOfMemoryException)obj13;
				}
				goto IL_03ae;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj14 = default;
			obj7 = obj14;
			nCommand2 = (NCommand)num;
			enetPeer = (EnetPeer)num;
			nCommand = (NCommand)(object)ex5;
		}
		goto IL_022e;
	}

	internal unsafe override void ReceiveIncomingCommands(byte[] inBuff, int inDataLength)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Ref, but got Unknown
		//IL_00c3: Expected I4, but got I8
		//IL_012f: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I4
		//IL_01e7: Expected I, but got Obj
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Ref, but got Unknown
		//IL_056e: Expected Obj, but got I4
		//IL_0573: Expected I, but got Obj
		//IL_0585: Expected Obj, but got I4
		//IL_025a: Expected I, but got Obj
		//IL_04aa: Expected I, but got Obj
		//IL_04bc: Expected Obj, but got I4
		//IL_05da: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I4
		//IL_04fc: Expected Obj, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got I4
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected Ref, but got Unknown
		//IL_053f: Expected Obj, but got I
		//IL_065e: Expected I, but got Obj
		//IL_097d: Expected I, but got Obj
		//IL_0333: Expected I, but got Obj
		//IL_06b6: Expected Obj, but got I4
		//IL_142e: Expected I4, but got Obj
		//IL_09b8: Expected Obj, but got I4
		//IL_09cb: Expected Obj, but got I4
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected Obj, but got Unknown
		//IL_0d5c: Expected Obj, but got I
		//IL_0d6c: Expected Obj, but got I
		//IL_0d7c: Expected Obj, but got I
		//IL_0d85: Expected Obj, but got I4
		//IL_0377: Expected I, but got Obj
		//IL_10d7: Expected Obj, but got I4
		//IL_10ea: Expected Obj, but got I4
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_110f: Expected Obj, but got Unknown
		//IL_0735: Expected I, but got Obj
		//IL_0746: Expected Obj, but got I4
		//IL_0a0e: Expected Obj, but got I
		//IL_039d: Expected I, but got Obj
		//IL_03ad: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_0a38: Expected Obj, but got I
		//IL_112d: Expected Obj, but got I
		//IL_1147: Expected Obj, but got I
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Ref, but got Unknown
		//IL_1660: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I
		//IL_0dd7: Expected I4, but got I8
		//IL_07eb: Expected I, but got Obj
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected Ref, but got Unknown
		//IL_0c07: Expected I, but got Obj
		//IL_0c19: Expected Obj, but got I4
		//IL_1470: Expected I, but got Obj
		//IL_1478: Expected Obj, but got I
		//IL_148b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1490: Expected Obj, but got Unknown
		//IL_118a: Expected I4, but got I8
		//IL_11aa: Expected I4, but got Obj
		//IL_16c3: Expected I4, but got Obj
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected Ref, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected Obj, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected Obj, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected Obj, but got Unknown
		//IL_0e22: Expected I4, but got Obj
		//IL_082a: Expected Obj, but got I4
		//IL_083d: Expected Obj, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Ref, but got Unknown
		//IL_0c59: Expected I, but got Obj
		//IL_0c6b: Expected Obj, but got I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_14c6: Expected Obj, but got I4
		//IL_14d6: Expected Obj, but got Ref
		//IL_11cd: Expected Obj, but got I
		//IL_11f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fc: Expected Ref, but got Unknown
		//IL_0ef6: Expected Obj, but got I4
		//IL_0c91: Expected I4, but got Obj
		//IL_0b26: Expected I4, but got Obj
		//IL_0b2b: Expected I, but got Obj
		//IL_0e54: Expected Obj, but got I4
		//IL_0e67: Expected Obj, but got I4
		//IL_0e81: Expected Obj, but got I4
		//IL_0e96: Expected I4, but got Obj
		//IL_0880: Expected Obj, but got I
		//IL_0fe1: Expected I4, but got I8
		//IL_08a9: Expected Obj, but got I
		//IL_0cdb: Expected Obj, but got I4
		//IL_0b66: Expected Obj, but got I4
		//IL_1266: Expected I4, but got I8
		//IL_127b: Expected I, but got Obj
		//IL_0d19: Expected I4, but got Obj
		//IL_0d27: Expected I, but got Obj
		//IL_100f: Expected I4, but got Obj
		//IL_0b8d: Expected Obj, but got I
		//IL_0ba7: Expected Obj, but got I
		//IL_12ba: Expected Obj, but got I4
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_1039: Expected Obj, but got Unknown
		//IL_1052: Expected I4, but got I8
		//IL_0f7e: Expected I4, but got I8
		//IL_12e2: Expected Obj, but got I
		//IL_0fac: Expected I4, but got Obj
		//IL_130b: Expected Obj, but got I
		bool flag = watch == null;
		byte[] array = inBuff;
		byte[] array2 = inBuff;
		long elapsedMilliseconds;
		object obj;
		int offset = default;
		byte[] array3;
		byte b;
		int value3;
		byte[] array4;
		byte[] array5;
		int num10;
		int num2 = default;
		int num15;
		int num6;
		nint num5;
		if (!flag)
		{
			elapsedMilliseconds = watch.ElapsedMilliseconds;
			PhotonPeer photonPeer = base.photonPeer;
			bool flag2 = base.photonPeer == null;
			array = null;
			array2 = inBuff;
			if (!flag2)
			{
				TrafficStats trafficStats = photonPeer.Stats__BackingField;
				bool flag3 = photonPeer.Stats__BackingField == null;
				array = null;
				array2 = inBuff;
				if (!flag3)
				{
					ref int location = ref *(int*)(this + 64);
					long num = ((TrafficStatsBase)trafficStats).BytesIn__BackingField + num2;
					int num3 = ((TrafficStatsBase)trafficStats).PackagesIn__BackingField + 1;
					trafficStats.LastReceiveTimestamp__BackingField = (int)elapsedMilliseconds;
					((TrafficStatsBase)trafficStats).BytesIn__BackingField = num;
					((TrafficStatsBase)trafficStats).PackagesIn__BackingField = num3;
					int num4 = Interlocked.CompareExchange(ref location, 0, 0);
					if ((num4 & 0xFF) == 0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
					obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v18+E4]");
					bool flag4 = (nint)0 == 0;
					object obj3 = !flag4;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					MessageProtocol.Deserialize(out short _, inBuff, ref offset);
					object obj4 = offset + 1;
					bool flag5 = inBuff == null;
					num5 = unchecked((nint)null);
					num6 = (int)(&offset);
					array3 = inBuff;
					if (flag5)
					{
						goto IL_1359;
					}
					bool flag6 = offset < inBuff.Length;
					object obj5 = !flag6;
					num5 = unchecked((nint)null);
					num6 = (int)(&offset);
					array3 = inBuff;
					if (obj5 != null)
					{
						goto IL_1367;
					}
					object obj6 = inBuff + offset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v34+20]");
					int value2;
					if ((nint)0 == 1)
					{
						PhotonPeer photonPeer2 = base.photonPeer;
						bool flag7 = base.photonPeer == null;
						num5 = unchecked((nint)null);
						num6 = (int)(&offset);
						array3 = inBuff;
						if (flag7)
						{
							goto IL_1391;
						}
						if (photonPeer2.Encryptor == null)
						{
							return;
						}
						object obj7 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X0_v134+E4]");
						bool flag8 = (nint)0 == 0;
						object obj8 = !flag8;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						MessageProtocol.Deserialize(out value2, inBuff, ref offset);
						if (value2 == challenge)
						{
							PhotonPeer photonPeer3 = base.photonPeer;
							bool flag9 = base.photonPeer == null;
							num5 = unchecked((nint)null);
							num6 = (int)(&offset);
							array3 = inBuff;
							if (flag9)
							{
								goto IL_13bb;
							}
							IPhotonEncryptor encryptor = photonPeer3.Encryptor;
							bool flag10 = photonPeer3.Encryptor == null;
							num5 = unchecked((nint)null);
							num6 = (int)(&offset);
							array3 = inBuff;
							if (flag10)
							{
								goto IL_13c9;
							}
							nint num7 = (nint)encryptor;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49E0]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v93 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v93 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0439;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v93 (Il2CppClass<Photon.Client.Encryption.IPhotonEncryptor>)+98]");
							object obj11 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X10_v32-8]");
								if (0 == (nint)obj9)
								{
									break;
								}
								obj10--;
								obj11 += 16;
								if ((nint)obj10 != 1)
								{
									continue;
								}
								goto IL_0439;
							}
							object obj12 = obj11 + 4;
							object obj13 = num7 + obj12;
							object obj14 = obj13 + 312;
							goto IL_1643;
						}
						int num8 = packetLossByChallenge + 1;
						packetLossByChallenge = num8;
						return;
					}
					int num9 = Interlocked.CompareExchange(ref *(int*)(this + 384), 1, 1);
					if (num9 == 1)
					{
						PhotonPeer photonPeer4 = base.photonPeer;
						bool flag11 = base.photonPeer == null;
						num5 = unchecked((nint)null);
						num6 = 1;
						array3 = (byte[])1;
						if (!flag11)
						{
							bool flag12 = (int)photonPeer4.LogLevel < 1;
							object obj15 = !flag12;
							object obj16 = photonPeer4.LogLevel - 1;
							bool flag13 = obj16 == null;
							object obj17 = ~obj15;
							object obj18 = obj17 | flag13;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516380]");
								object debugReturn = 0;
								EnqueueDebugReturn((LogLevel)2, (string)debugReturn);
							}
							return;
						}
						goto IL_139f;
					}
					bool flag14 = (nint)obj4 < inBuff.Length;
					object obj19 = !flag14;
					num5 = unchecked((nint)null);
					num6 = 1;
					array3 = (byte[])1;
					if (obj19 != null)
					{
						goto IL_13ad;
					}
					object obj20 = obj;
					object obj21 = (object)inBuff + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v61+20]");
					b = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ X0_v103+E4]");
					bool flag15 = (nint)0 == 0;
					object obj22 = !flag15;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					MessageProtocol.Deserialize(out value3, inBuff, ref offset);
					MessageProtocol.Deserialize(out value2, inBuff, ref offset);
					if (value2 == challenge)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v34+20]");
						bool flag16 = (nint)0 != 204;
						num5 = unchecked((nint)null);
						num6 = (int)(&offset);
						array4 = inBuff;
						array5 = inBuff;
						num10 = num2;
						if (!flag16)
						{
							object obj23 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ X0_v116+E4]");
							bool flag17 = (nint)0 == 0;
							object obj24 = !flag17;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							MessageProtocol.Deserialize(out int value4, inBuff, ref offset);
							int num11 = offset - 4;
							MessageProtocol.Serialize(0, inBuff, ref offset);
							uint num12 = SupportClass.CalculateCrc(inBuff, num2);
							bool flag18 = value4 == (int)num12;
							offset = num11;
							num5 = unchecked((nint)null);
							num6 = 0;
							array4 = (byte[])num2;
							array5 = inBuff;
							num10 = num2;
							if (!flag18)
							{
								int num13 = packetLossByCrc + 1;
								packetLossByCrc = num13;
								int num14 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
								if ((num14 & 0xFF) == 0)
								{
									return;
								}
								PhotonPeer photonPeer5 = base.photonPeer;
								bool flag19 = base.photonPeer == null;
								num5 = unchecked((nint)null);
								num6 = 0;
								num15 = 0;
								if (!flag19)
								{
									bool flag20 = (int)photonPeer5.LogLevel < 3;
									object obj25 = !flag20;
									object obj26 = photonPeer5.LogLevel - 3;
									bool flag21 = obj26 == null;
									object obj27 = ~obj25;
									object obj28 = obj27 | flag21;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
										object obj29 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516378]");
										object format = 0;
										object arg = default;
										object arg2 = default;
										string debugReturn2 = string.Format((string)format, arg, arg2);
										EnqueueDebugReturn((LogLevel)4, debugReturn2);
									}
									return;
								}
								goto IL_1441;
							}
						}
						goto IL_1687;
					}
					int num16 = packetLossByChallenge + 1;
					packetLossByChallenge = num16;
					int num17 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
					if ((num17 & 0xFF) == 0)
					{
						return;
					}
					PhotonPeer photonPeer6 = base.photonPeer;
					bool flag22 = base.photonPeer == null;
					num5 = unchecked((nint)null);
					num6 = 0;
					array3 = null;
					if (!flag22)
					{
						bool flag23 = (int)photonPeer6.LogLevel < 3;
						object obj30 = !flag23;
						object obj31 = photonPeer6.LogLevel - 3;
						bool flag24 = obj31 == null;
						object obj32 = ~obj30;
						object obj33 = obj32 | flag24;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516398]");
							object format2 = 0;
							object arg3 = default;
							object arg4 = default;
							string debugReturn3 = string.Format((string)format2, arg3, arg4);
							EnqueueDebugReturn((LogLevel)4, debugReturn3);
						}
						return;
					}
					goto IL_13d7;
				}
			}
		}
		goto IL_157b;
		IL_1383:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1391;
		IL_1391:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_139f;
		IL_1401:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_140f;
		IL_140f:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_141d;
		IL_1433:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_1441;
		IL_13ad:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_13bb;
		IL_1643:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1433 @ X0_v137+8]");
		int num18 = 0;
		object obj35 = num2 - offset;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1433 @ X0_v137] (should have been resolved before IL gen)");
		int num19 = default;
		int num22;
		int num23;
		if (num19 <= 4)
		{
			int num20 = packetLossByCrc + 1;
			packetLossByCrc = num20;
			int num21 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
			if ((num21 & 0xFF) == 0)
			{
				return;
			}
			PhotonPeer photonPeer7 = base.photonPeer;
			bool flag25 = base.photonPeer == null;
			num22 = (int)(&num19);
			num23 = (int)inBuff;
			num5 = unchecked((nint)null);
			num6 = 0;
			array3 = null;
			if (!flag25)
			{
				bool flag26 = (int)photonPeer7.LogLevel < 4;
				object obj36 = !flag26;
				object obj37 = ~obj36;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516390]");
					object format3 = 0;
					object arg5 = default;
					string debugReturn4 = string.Format((string)format3, arg5);
					EnqueueDebugReturn((LogLevel)4, debugReturn4);
				}
				return;
			}
			goto IL_141d;
		}
		int num24 = Interlocked.CompareExchange(ref *(int*)(this + 384), 1, 1);
		bool flag27 = num24 == 1;
		num5 = unchecked((nint)null);
		num6 = 1;
		array3 = (byte[])1;
		if (!flag27)
		{
			int num25 = Interlocked.CompareExchange(ref *(int*)(this + 384), 1, 0);
			fragmentLength = 0;
			num5 = unchecked((nint)null);
			num6 = 0;
			array3 = (byte[])1;
		}
		byte[] array6 = default;
		bool flag28 = array6 == null;
		num22 = (int)(&num19);
		num23 = (int)inBuff;
		if (flag28)
		{
			goto IL_13e5;
		}
		bool flag29 = array6.Length == 0;
		num22 = (int)(&num19);
		num23 = (int)inBuff;
		if (flag29)
		{
			goto IL_13f3;
		}
		object obj39 = obj;
		b = array6[0];
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1649 @ X0_v143+E4]");
		bool flag30 = (nint)0 == 0;
		object obj40 = !flag30;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MessageProtocol.Deserialize(out value3, array6, ref offset);
		num22 = (int)(&num19);
		num23 = (int)inBuff;
		offset = 1;
		num5 = unchecked((nint)null);
		num6 = (int)(&offset);
		array4 = array6;
		array5 = array6;
		num10 = num19;
		goto IL_1687;
		IL_0439:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_1643;
		IL_1441:
		NullReferenceException ex7 = new NullReferenceException();
		bool flag31 = num15 != 1;
		NullReferenceException ex8 = ex7;
		if (!flag31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			byte[] array7 = default;
			nint num26 = (nint)array7;
			array = (byte[])num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj42 = default;
			object obj41 = obj42 & 1;
			bool flag32 = obj41 == null;
			num2 = num6;
			array2 = array7;
			if (!flag32)
			{
				object obj43 = 0;
				array2 = array7;
				object obj45 = default;
				object obj44 = (object)(&obj45);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				PhotonPeer photonPeer8 = base.photonPeer;
				bool flag33 = base.photonPeer == null;
				num2 = num6;
				if (!flag33)
				{
					if (photonPeer8.LogLevel != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						string format4 = default;
						string debugReturn5 = string.Format(format4, array7);
						EnqueueDebugReturn((LogLevel)1, debugReturn5);
					}
					SupportClass.WriteStackTrace((Exception)(object)array2);
					return;
				}
				goto IL_157b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj46 = array2;
			num15 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num6 = 0;
			NullReferenceException ex9 = default;
			ex8 = ex9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_13bb:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_13c9;
		IL_13e5:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_13f3;
		IL_1359:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_1367;
		IL_139f:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_13ad;
		IL_1687:
		if (b != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161A0]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516110]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516370]");
			object obj49 = 0;
			object obj50 = 0;
			NCommand nCommand = default;
			while (true)
			{
				if (nCommandPool != null)
				{
					array3 = (byte[])obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
					if (nCommand != null)
					{
						if (!nCommand.Initialize(this, array5, ref offset, num10, (int)elapsedMilliseconds, value3))
						{
							break;
						}
						int num27 = nCommand.commandFlags & 1;
						bool flag34 = num27 == 0;
						num6 = (int)array5;
						array3 = (byte[])(object)this;
						if (!flag34)
						{
							bool flag35 = nCommand.commandType < 16;
							object obj51 = !flag35;
							object obj52 = nCommand.commandType - 16;
							bool flag36 = obj52 == null;
							object obj53 = !flag36;
							object obj54 = obj51 & obj53;
							num6 = (int)array5;
							array3 = (byte[])(object)this;
							if (obj54 == null)
							{
								QueueOutgoingAcknowledgement(nCommand, value3);
								num6 = value3;
								array3 = (byte[])(object)nCommand;
							}
						}
						object obj55 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X0_v94+E4]");
						bool flag37 = (nint)0 == 0;
						object obj56 = !flag37;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (nCommand.commandType != 1)
						{
							int num28 = nCommand.commandType & 0xFC;
							if (num28 != 16)
							{
								bool flag38 = CommandQueue == null;
								num22 = (int)elapsedMilliseconds;
								num23 = num10;
								num18 = value3;
								num5 = (nint)(&offset);
								if (!flag38)
								{
									num6 = (int)obj49;
									((ConcurrentQueue<System.__Canon>)(object)CommandQueue).Enqueue((System.__Canon)(object)nCommand);
									array4 = (byte[])(object)nCommand;
									goto IL_102b;
								}
								goto IL_1375;
							}
						}
						bool flag39 = AckQueue == null;
						num22 = (int)elapsedMilliseconds;
						num23 = num10;
						num18 = value3;
						num5 = (nint)(&offset);
						if (!flag39)
						{
							num6 = (int)obj49;
							((ConcurrentQueue<System.__Canon>)(object)AckQueue).Enqueue((System.__Canon)(object)nCommand);
							array4 = (byte[])(object)nCommand;
							goto IL_102b;
						}
						goto IL_1383;
					}
				}
				else
				{
					NullReferenceException ex14 = new NullReferenceException();
					array3 = array4;
				}
				NullReferenceException ex15 = new NullReferenceException();
				goto IL_1359;
				IL_102b:
				obj50++;
				bool flag40 = (int)b != (nint)obj50;
				num22 = (int)elapsedMilliseconds;
				num23 = num10;
				num18 = value3;
				num5 = (nint)(&offset);
				if (!flag40)
				{
					serverSentTime = value3;
					return;
				}
			}
			bool flag41 = nCommandPool == null;
			num22 = (int)elapsedMilliseconds;
			num23 = num10;
			num18 = value3;
			num5 = (nint)(&offset);
			num6 = (int)array5;
			array3 = (byte[])(object)this;
			if (flag41)
			{
				goto IL_140f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516278]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
			int num29 = packetLossByCrc + 1;
			packetLossByCrc = num29;
			int num30 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
			if ((num30 & 0xFF) == 0)
			{
				return;
			}
			PhotonPeer photonPeer9 = base.photonPeer;
			bool flag42 = base.photonPeer == null;
			num22 = (int)elapsedMilliseconds;
			num23 = num10;
			num18 = value3;
			num5 = unchecked((nint)null);
			num6 = 0;
			num15 = 0;
			if (!flag42)
			{
				bool flag43 = (int)photonPeer9.LogLevel < 4;
				object obj58 = !flag43;
				object obj59 = ~obj58;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj60 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516388]");
					object format5 = 0;
					object arg6 = default;
					object arg7 = default;
					string debugReturn6 = string.Format((string)format5, arg6, arg7);
					EnqueueDebugReturn((LogLevel)4, debugReturn6);
				}
				return;
			}
			goto IL_1433;
		}
		PhotonPeer photonPeer10 = base.photonPeer;
		bool flag44 = base.photonPeer == null;
		array3 = array4;
		if (!flag44)
		{
			bool flag45 = (int)photonPeer10.LogLevel < 3;
			object obj61 = !flag45;
			object obj62 = photonPeer10.LogLevel - 3;
			bool flag46 = obj62 == null;
			object obj63 = ~obj61;
			object obj64 = obj63 | flag46;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163A0]");
				object format6 = 0;
				object arg8 = default;
				string debugReturn7 = string.Format((string)format6, arg8);
				EnqueueDebugReturn((LogLevel)4, debugReturn7);
			}
			return;
		}
		goto IL_1401;
		IL_13f3:
		IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
		goto IL_1401;
		IL_157b:
		throw new NullReferenceException();
		IL_13d7:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_13e5;
		IL_1367:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_1375;
		IL_141d:
		NullReferenceException ex19 = new NullReferenceException();
		num15 = (int)array3;
		goto IL_1433;
		IL_1375:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_1383;
		IL_13c9:
		NullReferenceException ex21 = new NullReferenceException();
		goto IL_13d7;
	}

	private void DropFragmentSeries(EnetChannel channel, int startSequenceNumber, int fragmentCount, bool isSequencedFragment)
	{
		//IL_009e: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		NCommand nCommand = (NCommand)(fragmentCount + startSequenceNumber);
		if ((nint)nCommand <= startSequenceNumber)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516278]");
		object obj = 0;
		int num = startSequenceNumber;
		int num2 = fragmentCount;
		do
		{
			if (channel.TryGetFragment(num, isSequencedFragment, out var fragment))
			{
				channel.RemoveFragment(fragment.reliableSequenceNumber, isSequencedFragment);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
			}
			num2--;
			num++;
		}
		while (num2 != 1);
	}

	internal void ExecuteCommand(NCommand command)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005a: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_01c5: Expected I, but got Obj
		//IL_02b0: Expected Obj, but got I
		//IL_02b8: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0205: Expected I4, but got Obj
		//IL_020e: Expected Obj, but got I4
		//IL_022c: Expected I, but got Obj
		bool flag = command == null;
		NCommand nCommand = command;
		if (!flag)
		{
			object obj = command.commandType - 1;
			bool flag2 = (nint)obj < 18;
			object obj2 = !flag2;
			object obj3 = obj - 18;
			bool flag3 = obj3 == null;
			object obj4 = !flag3;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 18214912 + 2936;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X10_v2+v73 @ X9_v3*2]");
				object obj7 = (nint)85955312 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v189 @ X11_v2 (should have been resolved before IL gen)");
			}
			bool flag4 = nCommandPool == null;
			nCommand = command;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516278]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
				return;
			}
		}
		object obj10 = default;
		object obj11 = default;
		object obj14 = default;
		object obj16 = default;
		while (true)
		{
			NullReferenceException ex = new NullReferenceException();
			PhotonPeer photonPeer = base.photonPeer;
			if (base.photonPeer == null)
			{
				continue;
			}
			if (photonPeer.LogLevel != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65162B0]");
				object format = 0;
				string text = string.Format((string)format, obj10, null, obj11);
				bool flag5 = photonPeer.Listener__BackingField == null;
				bool flag6 = false;
				object obj12 = obj11;
				object obj13 = obj14;
				object obj15 = obj16;
				nint num = unchecked((nint)null);
				nCommand = (NCommand)obj10;
				if (flag5)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				object obj17 = 0;
				nCommand = (NCommand)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
				flag6 = (byte)(int)text != 0;
				obj12 = 1;
				obj13 = obj14;
				obj15 = obj16;
				num = (nint)photonPeer.Listener__BackingField;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v6+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
				object obj21 = 0;
				obj19 = obj21;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v6+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v10+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516210]");
				object obj23 = 0;
				nint num = (nint)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
				NCommand nCommand2 = null;
				nCommand = command;
			}
		}
	}

	private void MoveUnsequencedWindowTo(int windowBaseGroupNumber)
	{
		//IL_0043: Expected Obj, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I8
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		int[] array = unsequencedWindow;
		incomingUnsequencedGroupNumber = windowBaseGroupNumber;
		if (array.Length < 1)
		{
			return;
		}
		object obj = ~array.Length;
		object obj2 = array.Length & obj;
		object obj3 = array.Length & 0xFFFFFFFFL;
		object obj4 = array + 32;
		while (obj3 != null)
		{
			obj3--;
			obj4 = 0;
			obj4 += 4;
			if ((nint)obj2 == 1)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal bool QueueIncomingCommand(NCommand command)
	{
		//IL_0d24: Expected I4, but got Obj
		//IL_0062: Expected Obj, but got I4
		//IL_06a5: Expected I4, but got I8
		//IL_06bf: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I
		//IL_0354: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I4
		//IL_06f4: Expected Obj, but got I4
		//IL_070e: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		//IL_0394: Expected I, but got Obj
		//IL_03a4: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_0736: Expected Obj, but got I4
		//IL_0865: Expected Obj, but got I4
		//IL_0c37: Expected Obj, but got I4
		//IL_0570: Expected Obj, but got I4
		//IL_0dea: Expected Obj, but got I
		//IL_0df3: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I
		//IL_0a12: Expected Obj, but got I4
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Expected Obj, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected Obj, but got Unknown
		//IL_0b4a: Expected Obj, but got I4
		//IL_0796: Expected Obj, but got I4
		//IL_08bb: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_0a39: Expected Obj, but got I
		//IL_0c9a: Expected Obj, but got I
		//IL_0caa: Expected Obj, but got I
		//IL_0cc3: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I
		//IL_05db: Expected I, but got Obj
		//IL_05eb: Expected Obj, but got I
		//IL_05fb: Expected Obj, but got I
		//IL_0a6c: Expected Obj, but got I
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected Obj, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_08e2: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_0e49: Expected Obj, but got I
		//IL_0e52: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I
		//IL_0abc: Expected Obj, but got I
		//IL_0948: Expected Obj, but got I
		//IL_096e: Expected Obj, but got I4
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected Obj, but got Unknown
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected Obj, but got Unknown
		//IL_0227: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected Obj, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected Obj, but got Unknown
		//IL_0d8b: Expected Obj, but got I
		//IL_0d9c: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected Obj, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		EnetChannel channel;
		PhotonPeer photonPeer;
		string text;
		object obj13 = default;
		PhotonPeer photonPeer2;
		string text2;
		object obj21 = default;
		int num8;
		PhotonPeer photonPeer5;
		string text5;
		object obj47 = default;
		if (command != null)
		{
			channel = GetChannel(command.commandChannelID);
			if (channel != null)
			{
				int num = command.commandFlags & 2;
				bool flag = num == 0;
				object obj = !flag;
				if (obj == null)
				{
					if ((command.commandFlags & 1) != 0)
					{
						bool flag2 = command.commandType < 16;
						object obj2 = !flag2;
						object obj3 = command.commandType - 16;
						bool flag3 = obj3 == null;
						object obj4 = !flag3;
						object obj5 = obj2 & obj4;
						if (obj5 == null)
						{
							if (command.reliableSequenceNumber > channel.incomingReliableSequenceNumber)
							{
								goto IL_083a;
							}
							photonPeer = base.photonPeer;
							if (base.photonPeer != null)
							{
								int num2 = photonPeer.CountDiscarded__BackingField + 1;
								bool flag4 = (int)photonPeer.LogLevel < 4;
								object obj6 = !flag4;
								photonPeer.CountDiscarded__BackingField = num2;
								object obj7 = ~obj6;
								if (obj7 != null)
								{
									goto IL_0d41;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj8 = 0;
								IPhotonPeerListener photonPeerListener = photonPeer.Listener__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163E8]");
								object format = 0;
								object arg = default;
								text = string.Format((string)format, command, arg);
								if (photonPeer.Listener__BackingField != null)
								{
									nint num3 = (nint)photonPeerListener;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
									object obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v67 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
									object obj10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v67 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_02c3;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v67 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
									object obj11 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X10_v43-8]");
										if (0 == (nint)obj9)
										{
											break;
										}
										obj10--;
										obj11 += 16;
										if ((nint)obj10 != 1)
										{
											continue;
										}
										goto IL_02c3;
									}
									object obj12 = num3 + obj11;
									obj13 = obj12 + 312;
									goto IL_0d73;
								}
							}
							goto IL_0d08;
						}
					}
					if (command.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
					{
						photonPeer2 = base.photonPeer;
						if (base.photonPeer != null)
						{
							int num4 = photonPeer2.CountDiscarded__BackingField + 1;
							bool flag5 = (int)photonPeer2.LogLevel < 4;
							object obj14 = !flag5;
							photonPeer2.CountDiscarded__BackingField = num4;
							object obj15 = ~obj14;
							if (obj15 != null)
							{
								goto IL_0d41;
							}
							IPhotonPeerListener photonPeerListener2 = photonPeer2.Listener__BackingField;
							if (photonPeer2.Listener__BackingField != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
								object obj16 = 0;
								nint num5 = (nint)photonPeerListener2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163C8]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v58 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
								object obj18 = 0;
								text2 = (string)obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v58 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_067f;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v58 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
								object obj19 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X10_v31-8]");
									if (0 == (nint)obj16)
									{
										break;
									}
									obj18--;
									obj19 += 16;
									if ((nint)obj18 != 1)
									{
										continue;
									}
									goto IL_067f;
								}
								object obj20 = num5 + obj19;
								obj21 = obj20 + 312;
								goto IL_0e31;
							}
						}
					}
					else
					{
						if (command.unreliableSequenceNumber > channel.incomingUnreliableSequenceNumber)
						{
							goto IL_083a;
						}
						PhotonPeer photonPeer3 = base.photonPeer;
						if (base.photonPeer != null)
						{
							int num6 = photonPeer3.CountDiscarded__BackingField + 1;
							bool flag6 = (int)photonPeer3.LogLevel < 4;
							object obj22 = !flag6;
							photonPeer3.CountDiscarded__BackingField = num6;
							object obj23 = ~obj22;
							if (obj23 != null)
							{
								goto IL_0d41;
							}
							IPhotonPeerListener photonPeerListener3 = photonPeer3.Listener__BackingField;
							if (photonPeer3.Listener__BackingField != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
								object obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163D0]");
								object obj25 = 0;
								object obj26 = obj24;
								string text3 = (string)obj25;
								object obj27 = 0;
								goto IL_0e69;
							}
						}
					}
				}
				else
				{
					if ((command.commandFlags & 1) != 0)
					{
						bool flag7 = command.commandType < 16;
						object obj28 = !flag7;
						object obj29 = command.commandType - 16;
						bool flag8 = obj29 == null;
						object obj30 = !flag8;
						object obj31 = obj28 & obj30;
						if (obj31 == null)
						{
							return channel.QueueIncomingReliableUnsequenced(command);
						}
					}
					int num7 = (int)(command.unsequencedGroupNumber & 0x80000000L);
					bool flag9 = num7 == 0;
					object obj32 = !flag9;
					if (obj32 != null)
					{
						goto IL_0d41;
					}
					num8 = command.unsequencedGroupNumber & 0x7F;
					object obj33 = command.unsequencedGroupNumber - incomingUnsequencedGroupNumber;
					bool flag10 = (nint)obj33 < 4096;
					object obj34 = !flag10;
					if (obj34 == null)
					{
						bool flag11 = (nint)obj33 < 128;
						object obj35 = !flag11;
						if (obj35 != null)
						{
							goto IL_0acb;
						}
						int[] array = unsequencedWindow;
						if (unsequencedWindow != null)
						{
							int num9 = num8 >> 5;
							bool flag12 = num9 < array.Length;
							object obj36 = !flag12;
							if (obj36 == null)
							{
								object obj37 = unsequencedWindow + num9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v39+20]");
								int num10 = (int)((nint)0 >> command.unsequencedGroupNumber);
								if ((num10 & 1) != 0)
								{
									unsequencedGroupsDroppedInARow = 0;
									return false;
								}
								goto IL_0aed;
							}
							goto IL_0d16;
						}
					}
					else
					{
						if (++unsequencedGroupsDroppedInARow < 16)
						{
							goto IL_0d41;
						}
						PhotonPeer photonPeer4 = base.photonPeer;
						if (base.photonPeer != null)
						{
							bool flag13 = (int)photonPeer4.LogLevel < 2;
							object obj38 = !flag13;
							object obj39 = ~obj38;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163E0]");
								object format2 = 0;
								object arg2 = default;
								object arg3 = default;
								object arg4 = default;
								string text4 = string.Format((string)format2, arg2, arg3, arg4);
								if (photonPeer4.Listener__BackingField == null)
								{
									goto IL_0d08;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
								object obj41 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
							}
							goto IL_0acb;
						}
					}
				}
			}
			else
			{
				photonPeer5 = base.photonPeer;
				if (base.photonPeer != null)
				{
					if (photonPeer5.LogLevel == 0)
					{
						goto IL_0d41;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj42 = 0;
					IPhotonPeerListener photonPeerListener4 = photonPeer5.Listener__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163C0]");
					object format3 = 0;
					object arg5 = default;
					text5 = string.Format((string)format3, arg5);
					if (photonPeer5.Listener__BackingField != null)
					{
						nint num11 = (nint)photonPeerListener4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v13 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v13 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0430;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v13 (Il2CppClass<Photon.Client.IPhotonPeerListener>)+98]");
						object obj45 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X10_v14-8]");
							if (0 == (nint)obj43)
							{
								break;
							}
							obj44--;
							obj45 += 16;
							if ((nint)obj44 != 1)
							{
								continue;
							}
							goto IL_0430;
						}
						object obj46 = num11 + obj45;
						obj47 = obj46 + 312;
						goto IL_0dd2;
					}
				}
			}
		}
		goto IL_0d08;
		IL_083a:
		bool flag14 = channel.AddSequencedIfNew(command);
		bool flag15 = !flag14;
		object obj48 = !flag15;
		if (obj48 != null)
		{
			goto IL_0bce;
		}
		PhotonPeer photonPeer6 = base.photonPeer;
		if (base.photonPeer != null)
		{
			bool flag16 = (int)photonPeer6.LogLevel < 4;
			object obj49 = !flag16;
			object obj50 = ~obj49;
			if (obj50 != null)
			{
				goto IL_0d41;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163D8]");
			object format4 = 0;
			object arg6 = default;
			string text6 = string.Format((string)format4, command, arg6);
			if (photonPeer6.Listener__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B0]");
				object obj52 = 0;
				object obj26 = obj52;
				string text3 = text6;
				IPhotonPeerListener photonPeerListener3 = photonPeer6.Listener__BackingField;
				object obj27 = 0;
				goto IL_0e69;
			}
		}
		goto IL_0d08;
		IL_0e69:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB29C");
		goto IL_0d41;
		IL_0aed:
		int[] array2 = unsequencedWindow;
		unsequencedGroupsDroppedInARow = 0;
		if (unsequencedWindow != null)
		{
			int num12 = num8 >> 5;
			bool flag17 = num12 < array2.Length;
			object obj53 = !flag17;
			if (obj53 != null)
			{
				goto IL_0d16;
			}
			object obj54 = unsequencedWindow + num12;
			int num13 = 1 << command.unsequencedGroupNumber;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v24+20]");
			int num14 = (int)((nint)0 | (nint)num13);
			if (channel.incomingUnsequencedCommandsList != null)
			{
				((Queue<System.__Canon>)(object)channel.incomingUnsequencedCommandsList).Enqueue((System.__Canon)(object)command);
				goto IL_0bce;
			}
		}
		goto IL_0d08;
		IL_0d08:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0d16;
		IL_0d16:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_0e31:
		object obj55 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X0_v52+8]");
		object obj56 = 0;
		object obj57 = 4;
		IPhotonPeerListener photonPeerListener5 = photonPeer2.Listener__BackingField;
		goto IL_0e87;
		IL_0d73:
		obj55 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X0_v61+8]");
		obj56 = 0;
		string text7 = text;
		obj57 = 4;
		photonPeerListener5 = photonPeer.Listener__BackingField;
		goto IL_0e78;
		IL_02c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0d73;
		IL_0d41:
		return false;
		IL_0430:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0dd2;
		IL_0dd2:
		obj55 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v18+8]");
		obj56 = 0;
		obj57 = 1;
		photonPeerListener5 = photonPeer5.Listener__BackingField;
		text2 = text5;
		goto IL_0e87;
		IL_0acb:
		int windowBaseGroupNumber = command.unsequencedGroupNumber & 0x7FFFFF80;
		MoveUnsequencedWindowTo(windowBaseGroupNumber);
		goto IL_0aed;
		IL_0bce:
		return true;
		IL_067f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0e31;
		IL_0e78:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v581 @ X8_v6 (should have been resolved before IL gen)");
		goto IL_0d41;
		IL_0e87:
		text7 = text2;
		goto IL_0e78;
	}

	internal unsafe NCommand RemoveSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel, bool isUnsequenced)
	{
		//IL_017f: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got Ref
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Ref, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I4
		//IL_0373: Expected Obj, but got Ref
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Ref, but got Unknown
		//IL_03cc: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Ref, but got Unknown
		//IL_02ee: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got I4
		//IL_0406: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(sentReliableCommands, ref lockTaken);
		List<System.__Canon> list = (List<System.__Canon>)(object)sentReliableCommands;
		bool flag = sentReliableCommands == null;
		int num = (int)(&lockTaken);
		string text = null;
		int num2 = 109924352;
		if (flag)
		{
			goto IL_0148;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516268]");
		object obj = 0;
		int num3 = (int)(&lockTaken);
		string text2 = null;
		int num4 = 0;
		System.__Canon _Canon;
		bool flag3 = default;
		while (true)
		{
			bool flag2 = num4 >= list._size;
			num = num3;
			text = text2;
			num2 = num4;
			if (flag2)
			{
				break;
			}
			text = (string)obj;
			_Canon = list.get_Item(num4);
			if (_Canon != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v47 (System.__Canon)+14]");
				if ((nint)0 == ackReceivedReliableSequenceNumber)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v47 (System.__Canon)+12]");
					if ((nint)0 == ackReceivedChannel)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v47 (System.__Canon)+10]");
						object obj2 = (nint)0 & (nint)2;
						if ((flag3 ? 1 : 0) == (nint)obj2)
						{
							goto IL_03e7;
						}
					}
				}
			}
			list = (List<System.__Canon>)(object)sentReliableCommands;
			num2 = num4 + 1;
			bool flag4 = sentReliableCommands == null;
			object obj3 = !flag4;
			num = num4;
			num3 = num4;
			text2 = text;
			num4 = num2;
			if (obj3 != null)
			{
				continue;
			}
			goto IL_0148;
		}
		goto IL_0156;
		IL_03e7:
		bool flag5 = sentReliableCommands == null;
		OutOfMemoryException ex = null;
		object obj4 = 0;
		num = num4;
		if (flag5)
		{
			goto IL_0491;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516348]");
		object obj5 = 0;
		text = (string)obj5;
		((List<System.__Canon>)(object)sentReliableCommands).RemoveAt(num4);
		ex = null;
		obj4 = 0;
		LogLevel logLevel = (LogLevel)num4;
		System.__Canon result = _Canon;
		goto IL_05b5;
		IL_0156:
		PhotonPeer photonPeer = base.photonPeer;
		bool flag6 = base.photonPeer == null;
		ex = null;
		obj4 = 0;
		if (flag6)
		{
			goto IL_0483;
		}
		bool flag7 = (int)photonPeer.LogLevel < 4;
		object obj6 = !flag7;
		object obj7 = ~obj6;
		object obj8 = flag3;
		logLevel = (LogLevel)num;
		if (obj7 == null)
		{
			int num5 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
			int num6 = num5 & 0xFF;
			bool flag8 = num6 == 3;
			obj8 = null;
			logLevel = (LogLevel)0;
			text = null;
			if (!flag8)
			{
				int num7 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
				int num8 = num7 & 0xFF;
				bool flag9 = num8 == 4;
				obj8 = null;
				logLevel = (LogLevel)0;
				text = null;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					int num9 = Interlocked.CompareExchange(ref *(int*)(this + 64), 0, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161E8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65163B8]");
					object format = 0;
					int num10 = default;
					int num11 = default;
					object obj11 = default;
					string text3 = string.Format((string)format, num10, num11, obj11);
					EnqueueDebugReturn((LogLevel)4, text3);
					obj8 = obj11;
					logLevel = (LogLevel)4;
					text = text3;
				}
			}
		}
		ex = null;
		obj4 = 0;
		result = null;
		goto IL_05b5;
		IL_0491:
		NullReferenceException ex2 = new NullReferenceException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj4 = 1;
			logLevel = (LogLevel)num;
			result = null;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				NCommand result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj12 = default;
			ex = (OutOfMemoryException)obj12;
			logLevel = (LogLevel)num;
			result = null;
		}
		goto IL_05b5;
		IL_0148:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0156;
		IL_05b5:
		object obj13 = (object)(&lockTaken);
		bool flag10 = obj13 == null;
		num = (int)logLevel;
		if (!flag10)
		{
			object obj15 = default;
			object obj14 = (object)(&obj15);
			Monitor.Exit(obj14);
			num = 0;
		}
		bool flag11 = ex == null;
		object obj16 = !flag11;
		if (obj16 == null)
		{
			bool flag12 = obj4 == null;
			object obj17 = !flag12;
			OutOfMemoryException ex4 = ex;
			if (obj17 == null)
			{
				return (NCommand)(object)result;
			}
		}
		else
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0483;
		IL_0483:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0491;
	}

	internal string CommandListToString(NCommand[] list)
	{
		//IL_0024: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		PhotonPeer photonPeer = base.photonPeer;
		StringBuilder stringBuilder = default;
		if (base.photonPeer != null)
		{
			bool flag = (int)photonPeer.LogLevel < 3;
			object obj = !flag;
			object obj2 = photonPeer.LogLevel - 3;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v19+98]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v20+A0]");
				return (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			stringBuilder._002Ector();
			if (list != null)
			{
				if (list.Length < 1)
				{
					goto IL_01d4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D45E0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516430]");
				object value = 0;
				int num = default;
				while (true)
				{
					string text = num.ToString();
					string value2 = text + (string)obj8;
					if (stringBuilder == null)
					{
						break;
					}
					StringBuilder stringBuilder2 = stringBuilder.Append(value2);
					bool flag3 = num < list.Length;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						object obj10 = list + num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v15+20]");
						StringBuilder stringBuilder3 = stringBuilder.Append((object)0);
						StringBuilder stringBuilder4 = stringBuilder.Append((string)value);
						object obj11 = num + 1;
						if ((nint)obj11 < list.Length)
						{
							continue;
						}
						goto IL_01d4;
					}
					goto IL_020f;
				}
			}
		}
		goto IL_0201;
		IL_01d4:
		if (stringBuilder != null)
		{
			((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
			string result = default;
			return result;
		}
		goto IL_0201;
		IL_0201:
		NullReferenceException ex = new NullReferenceException();
		goto IL_020f;
		IL_020f:
		return (string)(object)new IndexOutOfRangeException();
	}

	static EnetPeer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 243;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516110]");
				object obj2 = 0;
				_ = 2;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v5+A0]");
				object obj4 = 0;
				object obj5 = default;
				obj4 = obj5;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void _003CSendOutgoingCommands_003Eb__64_0()
	{
		//IL_0005: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Photon.Client.EnetPeer>)+1C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Photon.Client.EnetPeer>)+1D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void _003CExecuteCommand_003Eb__86_1()
	{
		//IL_0021: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		PhotonSocket photonSocket = PhotonSocket;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		nint num = (nint)photonSocket;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v1 (Il2CppClass<Photon.Client.PhotonSocket>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v1 (Il2CppClass<Photon.Client.PhotonSocket>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v25 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void _003CExecuteCommand_003Eb__86_0()
	{
		//IL_0021: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		PhotonSocket photonSocket = PhotonSocket;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		nint num = (nint)photonSocket;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v1 (Il2CppClass<Photon.Client.PhotonSocket>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v1 (Il2CppClass<Photon.Client.PhotonSocket>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v25 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
