using System;
using Cpp2ILInjected;

namespace Photon.Client;

internal class NCommand : _0021_00210
{
	internal const byte Ack2FeatureFlag = default(byte);

	internal const byte ReliableSendWindowFeatureFlag = default(byte);

	internal const byte FeatureFlagsLow = default(byte);

	internal const byte FV_UNRELIABLE = default(byte);

	internal const byte FV_RELIABLE = default(byte);

	internal const byte FV_UNRELIABLE_UNSEQUENCED = default(byte);

	internal const byte FV_RELIBALE_UNSEQUENCED = default(byte);

	internal const byte CT_NONE = default(byte);

	internal const byte CT_ACK = default(byte);

	internal const byte CT_CONNECT = default(byte);

	internal const byte CT_VERIFYCONNECT = default(byte);

	internal const byte CT_DISCONNECT = default(byte);

	internal const byte CT_PING = default(byte);

	internal const byte CT_SENDRELIABLE = default(byte);

	internal const byte CT_SENDUNRELIABLE = default(byte);

	internal const byte CT_SENDFRAGMENT = default(byte);

	internal const byte CT_SENDUNSEQUENCED = default(byte);

	internal const byte CT_EG_SERVERTIME = default(byte);

	internal const byte CT_EG_SEND_UNRELIABLE_PROCESSED = default(byte);

	internal const byte CT_EG_SEND_RELIABLE_UNSEQUENCED = default(byte);

	internal const byte CT_EG_SEND_FRAGMENT_UNSEQUENCED = default(byte);

	internal const byte CT_EG_ACK_UNSEQUENCED = default(byte);

	internal const byte CT_EG_ACK_2 = default(byte);

	internal const byte CT_EG_ACK_2_UNSEQUENCED = default(byte);

	internal const byte CT_EG_ACK_2_NULL = default(byte);

	internal const int HEADER_UDP_PACK_LENGTH = default(int);

	internal const int CmdSizeMinimum = default(int);

	internal const int CmdSizeAck = default(int);

	internal const int CmdSizeConnect = default(int);

	internal const int CmdSizeVerifyConnect = default(int);

	internal const int CmdSizeDisconnect = default(int);

	internal const int CmdSizePing = default(int);

	internal const int CmdSizeReliableHeader = default(int);

	internal const int CmdSizeUnreliableHeader = default(int);

	internal const int CmdSizeUnsequencedHeader = default(int);

	internal const int CmdSizeFragmentHeader = default(int);

	internal const int CmdSizeMaxHeader = default(int);

	internal byte commandFlags;

	internal byte commandType;

	internal byte commandChannelID;

	internal int reliableSequenceNumber;

	internal int unreliableSequenceNumber;

	internal int unsequencedGroupNumber;

	internal byte reservedByte = 4;

	internal int startSequenceNumber;

	internal int fragmentCount;

	internal int fragmentNumber;

	internal int totalLength;

	internal int fragmentOffset;

	internal int fragmentsRemaining;

	internal int fragmentBytesRemaining;

	internal int commandSentTime;

	internal byte commandSentCount;

	internal int roundTripTimeout;

	internal int timeoutTime;

	internal int ackReceivedReliableSequenceNumber;

	internal int ackReceivedSentTime;

	internal int TimeOfReceive;

	internal int datagramSentTime;

	internal int Size;

	internal StreamBuffer Payload;

	protected internal int SizeOfPayload
	{
		get
		{
			//IL_003a: Expected I4, but got Obj
			if (Payload != null)
			{
				return Payload.Length;
			}
			return (int)Payload;
		}
	}

	protected internal bool IsFlaggedUnsequenced
	{
		get
		{
			int num = commandFlags >> 1;
			return (byte)(num & 1) != 0;
		}
	}

	protected internal bool IsFlaggedReliable
	{
		get
		{
			//IL_002a: Expected Obj, but got I4
			//IL_005a: Expected Obj, but got I4
			//IL_0063: Expected I4, but got Obj
			int num = commandFlags & 1;
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				return false;
			}
			bool flag2 = commandType < 17;
			object obj2 = !flag2;
			return (byte)(int)(~obj2) != 0;
		}
	}

	internal static void CreateAck(byte[] buffer, int offset, NCommand commandToAck, int sentTime)
	{
		//IL_0279: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		object obj = offset + 1;
		int num = commandToAck.commandFlags & 2;
		bool flag = num == 0;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 16;
		}
		else
		{
			object obj4 = 1;
		}
		bool flag2 = buffer.Length < offset;
		object obj5 = !flag2;
		object obj6 = buffer.Length - offset;
		bool flag3 = obj6 == null;
		object obj7 = ~obj5;
		object obj8 = obj7 | flag3;
		if (obj8 == null)
		{
			object obj9 = buffer + offset;
			object obj10 = offset + 2;
			bool flag4 = (nint)obj < buffer.Length;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				object obj12 = (object)buffer + obj;
				_ = commandToAck.commandChannelID;
				object obj13 = offset + 3;
				bool flag5 = (nint)obj10 < buffer.Length;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					object obj15 = (object)buffer + obj10;
					_ = 0;
					bool flag6 = (nint)obj13 < buffer.Length;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						object obj17 = (object)buffer + obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
						object obj18 = 0;
						_ = 4;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v5+E4]");
						bool flag7 = (nint)0 == 0;
						object obj20 = !flag7;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int targetOffset = default;
						MessageProtocol.Serialize(20, buffer, ref targetOffset);
						MessageProtocol.Serialize(0, buffer, ref targetOffset);
						MessageProtocol.Serialize(commandToAck.reliableSequenceNumber, buffer, ref targetOffset);
						MessageProtocol.Serialize(sentTime, buffer, ref targetOffset);
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal static void CreateAck2(byte[] buffer, int offset, byte channelId, int completeSequence, int gapBlock, byte gapBlockOffset, int sentTime, bool isSequenced)
	{
		//IL_023e: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I4
		bool flag = !isSequenced;
		object obj = offset + 1;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 17 + 1;
		}
		else
		{
			object obj3 = 17;
		}
		bool flag2 = buffer.Length < offset;
		object obj4 = !flag2;
		object obj5 = buffer.Length - offset;
		bool flag3 = obj5 == null;
		object obj6 = ~obj4;
		object obj7 = obj6 | flag3;
		if (obj7 == null)
		{
			object obj8 = buffer + offset;
			object obj9 = offset + 2;
			bool flag4 = (nint)obj < buffer.Length;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				object obj11 = (object)buffer + obj;
				object obj12 = offset + 3;
				bool flag5 = (nint)obj9 < buffer.Length;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					object obj14 = (object)buffer + obj9;
					bool flag6 = (nint)obj12 < buffer.Length;
					object obj15 = !flag6;
					if (obj15 == null)
					{
						object obj16 = (object)buffer + obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
						object obj17 = 0;
						_ = 4;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+E4]");
						bool flag7 = (nint)0 == 0;
						object obj19 = !flag7;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int targetOffset = default;
						MessageProtocol.Serialize(20, buffer, ref targetOffset);
						MessageProtocol.Serialize(gapBlock, buffer, ref targetOffset);
						MessageProtocol.Serialize(completeSequence, buffer, ref targetOffset);
						MessageProtocol.Serialize(sentTime, buffer, ref targetOffset);
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal void Initialize(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel, ConnectionStateValue connectionStateForDisconnect = default(ConnectionStateValue))
	{
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I4
		//IL_039b: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_042c: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_04d0: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0574: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I4
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_062a: Expected Obj, but got I4
		//IL_063a: Expected Obj, but got I4
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_06d2: Expected Obj, but got I4
		//IL_06e2: Expected Obj, but got I4
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_0776: Expected Obj, but got I4
		//IL_0786: Expected Obj, but got I4
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07e8: Expected Obj, but got I4
		//IL_07f8: Expected Obj, but got I4
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_084e: Expected Obj, but got I
		object obj = this + 104;
		obj = payload;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
		int size;
		if ((nint)0 <= (nint)7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
			if ((nint)0 <= (nint)5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
				if ((nint)0 != 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
					if ((nint)0 == 4)
					{
						object obj2 = connectionStateForDisconnect & (ConnectionStateValue)0xFF;
						Size = 12;
						if ((nint)obj2 != 3)
						{
							byte b = (byte)(((nint)obj2 != 6) ? 4 : 2);
							commandFlags = 2;
							reservedByte = b;
						}
					}
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj3 = 0;
				Size = 44;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				byte[] array = default;
				if (array.Length != 0)
				{
					bool flag = array.Length == 1;
					array[0] = 0;
					if (!flag)
					{
						array[1] = 0;
						int maximumTransferUnit = peer.photonPeer.MaximumTransferUnit;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
						object obj4 = 0;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v22+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int targetOffset = default;
						MessageProtocol.Serialize((short)maximumTransferUnit, array, ref targetOffset);
						bool flag3 = array.Length < 4;
						object obj7 = !flag3;
						object obj8 = array.Length - 4;
						bool flag4 = obj8 == null;
						object obj9 = ~obj7;
						object obj10 = obj9 | flag4;
						if (obj10 == null)
						{
							bool flag5 = array.Length == 5;
							array[4] = 0;
							if (!flag5)
							{
								bool flag6 = array.Length < 6;
								object obj11 = !flag6;
								object obj12 = array.Length - 6;
								bool flag7 = obj12 == null;
								array[5] = 2;
								object obj13 = ~obj11;
								object obj14 = obj13 | flag7;
								if (obj14 == null)
								{
									bool flag8 = array.Length == 7;
									array[6] = 128;
									if (!flag8)
									{
										bool flag9 = array.Length < 8;
										object obj15 = !flag9;
										object obj16 = array.Length - 8;
										bool flag10 = obj16 == null;
										array[7] = 0;
										object obj17 = ~obj15;
										object obj18 = obj17 | flag10;
										if (obj18 == null)
										{
											bool flag11 = array.Length == 9;
											array[8] = 0;
											if (!flag11)
											{
												bool flag12 = array.Length < 10;
												object obj19 = !flag12;
												object obj20 = array.Length - 10;
												bool flag13 = obj20 == null;
												array[9] = 0;
												object obj21 = ~obj19;
												object obj22 = obj21 | flag13;
												if (obj22 == null)
												{
													array[10] = 0;
													PhotonPeer photonPeer = peer.photonPeer;
													if (array.Length != 11)
													{
														bool flag14 = array.Length < 12;
														object obj23 = !flag14;
														object obj24 = array.Length - 12;
														bool flag15 = obj24 == null;
														array[11] = photonPeer.ChannelCount;
														object obj25 = ~obj23;
														object obj26 = obj25 | flag15;
														if (obj26 == null)
														{
															bool flag16 = array.Length == 13;
															array[12] = 255;
															if (!flag16)
															{
																bool flag17 = array.Length < 22;
																object obj27 = !flag17;
																object obj28 = array.Length - 22;
																bool flag18 = obj28 == null;
																array[13] = 255;
																object obj29 = ~obj27;
																object obj30 = obj29 | flag18;
																if (obj30 == null)
																{
																	bool flag19 = array.Length == 23;
																	array[22] = 19;
																	if (!flag19)
																	{
																		bool flag20 = array.Length < 27;
																		object obj31 = !flag20;
																		object obj32 = array.Length - 27;
																		bool flag21 = obj32 == null;
																		array[23] = 136;
																		object obj33 = ~obj31;
																		object obj34 = obj33 | flag21;
																		if (obj34 == null)
																		{
																			bool flag22 = array.Length < 31;
																			object obj35 = !flag22;
																			object obj36 = array.Length - 31;
																			bool flag23 = obj36 == null;
																			array[27] = 2;
																			object obj37 = ~obj35;
																			object obj38 = obj37 | flag23;
																			if (obj38 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
																				object obj39 = 0;
																				array[31] = 2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																				StreamBuffer streamBuffer = default;
																				streamBuffer._002Ector(array);
																				obj = streamBuffer;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				return;
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
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
			if ((nint)0 != 6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
				if ((nint)0 != 7)
				{
					return;
				}
				int length = payload.Length;
				commandFlags = 0;
				size = length + 16;
			}
			else
			{
				int length2 = payload.Length;
				size = length2 + 12;
			}
			goto IL_099e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
		int size2;
		byte b2;
		if ((nint)0 <= (nint)13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
			if ((nint)0 == 8)
			{
				int length3 = payload.Length;
				size = length3 + 32;
				goto IL_099e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
			if ((nint)0 != 11)
			{
				return;
			}
			int length4 = payload.Length;
			size2 = length4 + 16;
			b2 = 2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
			if ((nint)0 != 14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v3-57]");
				if ((nint)0 != 15)
				{
					return;
				}
				int length5 = payload.Length;
				size2 = length5 + 32;
				b2 = 3;
			}
			else
			{
				int length6 = payload.Length;
				size2 = length6 + 12;
				b2 = 3;
			}
		}
		Size = size2;
		commandFlags = b2;
		return;
		IL_099e:
		Size = size;
	}

	internal unsafe bool Initialize(EnetPeer peer, byte[] inBuff, ref int readingOffset, int dataLength, int timeOfReceive, int datagramSentTime)
	{
		//IL_0ca1: Expected Obj, but got I8
		//IL_0cbb: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0c8a: Expected I4, but got Obj
		//IL_0095: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Ref, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Ref, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_086f: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I4
		//IL_05e2: Expected Obj, but got I4
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected Obj, but got Unknown
		//IL_08b5: Expected Obj, but got I4
		//IL_0a53: Expected Obj, but got I4
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected Obj, but got Unknown
		//IL_0a72: Expected Obj, but got I4
		//IL_09c7: Expected Obj, but got I4
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Ref, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected Ref, but got Unknown
		//IL_067c: Expected Obj, but got I4
		//IL_0941: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_0918: Expected Obj, but got I4
		//IL_0a0d: Expected Obj, but got I4
		//IL_06c2: Expected Obj, but got I4
		//IL_0987: Expected Obj, but got I4
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Ref, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected Ref, but got Unknown
		//IL_0481: Expected Obj, but got I4
		//IL_0de2: Expected Obj, but got I4
		//IL_0aed: Expected Obj, but got I4
		//IL_0d06: Expected I4, but got I8
		//IL_0740: Expected Obj, but got I4
		//IL_0753: Expected Obj, but got I4
		//IL_0776: Expected Obj, but got I4
		//IL_04c7: Expected Obj, but got I4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Ref, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Ref, but got Unknown
		//IL_07a8: Expected Obj, but got I4
		//IL_0b47: Expected Obj, but got I
		//IL_0b71: Expected Obj, but got I4
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Ref, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Ref, but got Unknown
		//IL_0e0d: Expected Obj, but got I
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Ref, but got Unknown
		//IL_05ab: Expected Obj, but got I4
		//IL_07ec: Expected Obj, but got I4
		//IL_0ba6: Expected Obj, but got I
		//IL_0e48: Expected Obj, but got I4
		//IL_082f: Expected Obj, but got I4
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected Obj, but got Unknown
		//IL_0846: Expected Obj, but got I4
		//IL_0c46: Expected Obj, but got I4
		object obj = readingOffset & 0x80000000L;
		bool flag = obj == null;
		object obj2 = !flag;
		bool result = false;
		object obj16;
		int num;
		ref int value;
		object obj23;
		ref int reference2;
		ref int reference;
		if (obj2 == null)
		{
			object obj3 = readingOffset + 12;
			bool flag2 = (nint)obj3 > dataLength;
			result = false;
			if (!flag2)
			{
				object obj4 = readingOffset + 1;
				reference = ref *(int*)obj4;
				if (inBuff != null)
				{
					bool flag3 = readingOffset < inBuff.Length;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						object obj6 = inBuff + readingOffset;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v9+20]");
						commandType = 0;
						object obj7 = readingOffset + 1;
						reference = ref *(int*)obj7;
						bool flag4 = readingOffset < inBuff.Length;
						object obj8 = !flag4;
						if (obj8 == null)
						{
							object obj9 = inBuff + readingOffset;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v12+20]");
							commandChannelID = 0;
							object obj10 = readingOffset + 1;
							reference = ref *(int*)obj10;
							bool flag5 = readingOffset < inBuff.Length;
							object obj11 = !flag5;
							if (obj11 == null)
							{
								object obj12 = inBuff + readingOffset;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v15+20]");
								commandFlags = 0;
								object obj13 = readingOffset + 1;
								reference = ref *(int*)obj13;
								bool flag6 = readingOffset < inBuff.Length;
								object obj14 = !flag6;
								if (obj14 == null)
								{
									object obj15 = inBuff + readingOffset;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
									obj16 = 0;
									object obj17 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v18+20]");
									reservedByte = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v8+E4]");
									bool flag7 = (nint)0 == 0;
									object obj18 = !flag7;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									MessageProtocol.Deserialize(out *(int*)(this + 96), inBuff, ref readingOffset);
									MessageProtocol.Deserialize(out *(int*)(this + 20), inBuff, ref readingOffset);
									num = Size - 12;
									bool flag8 = Size < 12;
									result = false;
									if (!flag8)
									{
										object obj19 = Size + readingOffset;
										bool flag9 = (nint)obj19 > dataLength;
										result = false;
										if (!flag9)
										{
											TimeOfReceive = timeOfReceive;
											this.datagramSentTime = datagramSentTime;
											if (commandType > 10)
											{
												if (commandType <= 15)
												{
													if (commandType == 11)
													{
														object obj20 = readingOffset + 4;
														if ((nint)obj20 > dataLength)
														{
															goto IL_0b0c;
														}
														object obj21 = obj16;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v57+E4]");
														bool flag10 = (nint)0 == 0;
														object obj22 = !flag10;
														if (obj22 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														value = ref *(int*)(this + 28);
														goto IL_0db8;
													}
													bool flag11 = commandType == 14;
													obj23 = 0;
													reference2 = ref readingOffset;
													if (flag11)
													{
														goto IL_0cd7;
													}
													if (commandType == 15)
													{
														goto IL_046e;
													}
												}
												else
												{
													object obj24 = commandType - 16;
													bool flag12 = (nint)obj24 < 2;
													object obj25 = !flag12;
													object obj26 = obj24 - 2;
													bool flag13 = obj26 == null;
													object obj27 = ~obj25;
													object obj28 = obj27 | flag13;
													if (obj28 != null)
													{
														goto IL_085c;
													}
												}
												goto IL_0a3f;
											}
											if (commandType > 5)
											{
												bool flag14 = commandType == 6;
												obj23 = 0;
												reference2 = ref readingOffset;
												if (flag14)
												{
													goto IL_0cd7;
												}
												if (commandType != 7)
												{
													if (commandType == 8)
													{
														goto IL_046e;
													}
													goto IL_0a3f;
												}
												object obj29 = readingOffset + 4;
												if ((nint)obj29 <= dataLength)
												{
													object obj30 = obj16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v53+E4]");
													bool flag15 = (nint)0 == 0;
													object obj31 = !flag15;
													if (obj31 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													value = ref *(int*)(this + 24);
													goto IL_0db8;
												}
											}
											else
											{
												if (commandType == 1)
												{
													goto IL_085c;
												}
												if (commandType != 3)
												{
													goto IL_0a3f;
												}
												object obj32 = readingOffset + 32;
												if ((nint)obj32 <= dataLength)
												{
													object obj33 = obj16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v45+E4]");
													bool flag16 = (nint)0 == 0;
													object obj34 = !flag16;
													if (obj34 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													MessageProtocol.Deserialize(out short value2, inBuff, ref readingOffset);
													MessageProtocol.Deserialize(out short _, inBuff, ref readingOffset);
													MessageProtocol.Deserialize(out short value4, inBuff, ref readingOffset);
													MessageProtocol.Deserialize(out short _, inBuff, ref readingOffset);
													object obj35 = readingOffset + 4;
													object obj36 = readingOffset + 3;
													reference = ref *(int*)obj35;
													bool flag17 = (nint)obj36 < inBuff.Length;
													object obj37 = !flag17;
													if (obj37 != null)
													{
														goto IL_0c6e;
													}
													MessageProtocol.Deserialize(out short value6, inBuff, ref readingOffset);
													object obj38 = readingOffset + 18;
													reference = ref *(int*)obj38;
													if (peer != null)
													{
														bool flag18 = peer.peerID < 65534;
														object obj39 = !flag18;
														object obj40 = ~obj39;
														if (obj40 == null)
														{
															peer.peerID = value2;
														}
														bool flag19 = value4 == 0;
														int num2 = value4 >> 1;
														int num3 = num2 & 1;
														int num4 = value4 & 1;
														bool flag20 = !flag19;
														((PeerBase)peer).serverFeatureFlags = (ushort)value4;
														((PeerBase)peer).serverFeatureAck2Available__BackingField = (byte)num4 != 0;
														((PeerBase)peer).serverFeatureFlagsAvailable__BackingField = flag20;
														((PeerBase)peer).serverFeatureSyncReliableQueue__BackingField = (byte)num3 != 0;
														short num5;
														if (value4 != 0)
														{
															bool flag21 = num3 == 0;
															object obj41 = !flag21;
															if (obj41 == null)
															{
																obj23 = 0;
																reference2 = ref readingOffset;
																num = 0;
																goto IL_0a88;
															}
															num5 = value6;
														}
														else
														{
															num5 = 0;
														}
														((PeerBase)peer).ServerMaxQueueableReliableCommands__BackingField = (ushort)num5;
														obj23 = 0;
														reference2 = ref readingOffset;
														num = 0;
														goto IL_0a88;
													}
													goto IL_0c7c;
												}
											}
											goto IL_0b0c;
										}
									}
									goto IL_0cd2;
								}
							}
						}
					}
					goto IL_0c6e;
				}
				goto IL_0c7c;
			}
		}
		goto IL_0cd2;
		IL_0cd7:
		if (peer != null)
		{
			goto IL_0a88;
		}
		goto IL_0c7c;
		IL_0a3f:
		object obj42 = Size + readingOffset;
		object obj43 = obj42 - 12;
		reference = ref *(int*)obj43;
		obj23 = 0;
		reference2 = ref readingOffset;
		num = 0;
		goto IL_0cd7;
		IL_0b0c:
		result = false;
		goto IL_0cd2;
		IL_085c:
		object obj44 = readingOffset + 8;
		if ((nint)obj44 > dataLength)
		{
			goto IL_0b0c;
		}
		object obj45 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v32+E4]");
		bool flag22 = (nint)0 == 0;
		object obj46 = !flag22;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MessageProtocol.Deserialize(out *(int*)(this + 80), inBuff, ref readingOffset);
		MessageProtocol.Deserialize(out *(int*)(this + 84), inBuff, ref readingOffset);
		obj23 = 0;
		reference2 = ref readingOffset;
		num = 0;
		goto IL_0cd7;
		IL_0c7c:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0def:
		result = true;
		goto IL_0cd2;
		IL_0c6e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0c7c;
		IL_0cf4:
		if ((int)(num & 0x80000000L) != 0)
		{
			goto IL_0b0c;
		}
		goto IL_0cd7;
		IL_0db8:
		MessageProtocol.Deserialize(out value, inBuff, ref readingOffset);
		num = Size - 16;
		obj23 = 0;
		reference2 = ref readingOffset;
		goto IL_0cf4;
		IL_046e:
		object obj47 = readingOffset + 20;
		if ((nint)obj47 > dataLength)
		{
			goto IL_0b0c;
		}
		object obj48 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v37+E4]");
		bool flag23 = (nint)0 == 0;
		object obj49 = !flag23;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MessageProtocol.Deserialize(out *(int*)(this + 36), inBuff, ref readingOffset);
		MessageProtocol.Deserialize(out *(int*)(this + 40), inBuff, ref readingOffset);
		MessageProtocol.Deserialize(out *(int*)(this + 44), inBuff, ref readingOffset);
		MessageProtocol.Deserialize(out *(int*)(this + 48), inBuff, ref readingOffset);
		MessageProtocol.Deserialize(out *(int*)(this + 52), inBuff, ref readingOffset);
		num = Size - 32;
		fragmentsRemaining = fragmentCount;
		fragmentBytesRemaining = totalLength;
		obj23 = 0;
		reference2 = ref readingOffset;
		goto IL_0cf4;
		IL_0a88:
		if (peer.photonPeer != null)
		{
			int maximumTransferUnit = peer.photonPeer.MaximumTransferUnit;
			if (num < maximumTransferUnit)
			{
				object obj50 = readingOffset + num;
				if ((nint)obj50 <= dataLength)
				{
					if (num != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
						object obj51 = 0;
						object obj52 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X0_v24+E4]");
						bool flag24 = (nint)0 == 0;
						object obj53 = !flag24;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj52 = obj51;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X0_v24+A0]");
						object obj54 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v31+8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516208]");
							object obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099170");
							StreamBuffer streamBuffer = default;
							if (streamBuffer != null)
							{
								streamBuffer.Write(inBuff, readingOffset, num);
								object obj56 = this + 104;
								obj56 = streamBuffer;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								if (obj56 != null)
								{
									((StreamBuffer)obj56).Position = 0;
									object obj57 = readingOffset + num;
									reference = ref *(int*)obj57;
									goto IL_0def;
								}
							}
						}
						goto IL_0c7c;
					}
					goto IL_0def;
				}
			}
			goto IL_0b0c;
		}
		goto IL_0c7c;
		IL_0cd2:
		return result;
	}

	public void Reset()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 104;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 4;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal unsafe void SerializeHeader(byte[] buffer, ref int bufferIndex)
	{
		//IL_03b6: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		object obj = bufferIndex + 1;
		ref int reference = ref *(int*)obj;
		bool flag = bufferIndex < buffer.Length;
		object obj2 = !flag;
		object obj13;
		int value;
		if (obj2 == null)
		{
			object obj3 = buffer + bufferIndex;
			_ = commandType;
			object obj4 = bufferIndex + 1;
			reference = ref *(int*)obj4;
			bool flag2 = bufferIndex < buffer.Length;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				object obj6 = buffer + bufferIndex;
				_ = commandChannelID;
				object obj7 = bufferIndex + 1;
				reference = ref *(int*)obj7;
				bool flag3 = bufferIndex < buffer.Length;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					object obj9 = buffer + bufferIndex;
					_ = commandFlags;
					object obj10 = bufferIndex + 1;
					reference = ref *(int*)obj10;
					bool flag4 = bufferIndex < buffer.Length;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						object obj12 = buffer + bufferIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
						obj13 = 0;
						_ = reservedByte;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v5+E4]");
						bool flag5 = (nint)0 == 0;
						object obj15 = !flag5;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						MessageProtocol.Serialize(Size, buffer, ref bufferIndex);
						MessageProtocol.Serialize(reliableSequenceNumber, buffer, ref bufferIndex);
						if (commandType <= 10)
						{
							if (commandType != 7)
							{
								if (commandType != 8)
								{
									return;
								}
								goto IL_0293;
							}
							object obj16 = obj13;
							value = unreliableSequenceNumber;
						}
						else
						{
							if (commandType != 11)
							{
								if (commandType != 15)
								{
									return;
								}
								goto IL_0293;
							}
							object obj16 = obj13;
							value = unsequencedGroupNumber;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v9+E4]");
						bool flag6 = (nint)0 == 0;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						goto IL_037c;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0293:
		object obj18 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MessageProtocol.Serialize(startSequenceNumber, buffer, ref bufferIndex);
		MessageProtocol.Serialize(fragmentCount, buffer, ref bufferIndex);
		MessageProtocol.Serialize(fragmentNumber, buffer, ref bufferIndex);
		MessageProtocol.Serialize(totalLength, buffer, ref bufferIndex);
		value = fragmentOffset;
		goto IL_037c;
		IL_037c:
		MessageProtocol.Serialize(value, buffer, ref bufferIndex);
	}

	internal byte[] Serialize()
	{
		if (Payload != null)
		{
			return Payload.GetBuffer();
		}
		return (byte[])(object)new NullReferenceException();
	}

	public void FreePayload()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		object obj = this + 104;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516128]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516210]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099000");
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public int CompareTo(NCommand other)
	{
		//IL_007a: Expected Obj, but got I4
		int result;
		if (other != null)
		{
			result = reliableSequenceNumber - other.reliableSequenceNumber;
			if ((commandFlags & 1) != 0)
			{
				bool flag = commandType < 17;
				object obj = !flag;
				object obj2 = ~obj;
				if (obj2 != null)
				{
					goto IL_00b4;
				}
			}
			if (reliableSequenceNumber != other.reliableSequenceNumber)
			{
				goto IL_00b4;
			}
			return unreliableSequenceNumber - other.unreliableSequenceNumber;
		}
		return 1;
		IL_00b4:
		return result;
	}

	public override string ToString()
	{
		return ToString(full: false);
	}

	public unsafe string ToString(bool full = default(bool))
	{
		//IL_1321: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I
		//IL_133f: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_1274: Expected Obj, but got I
		//IL_129d: Expected Obj, but got I
		//IL_0834: Expected Obj, but got I4
		//IL_0eec: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_084a: Expected I, but got Obj
		//IL_085a: Expected Obj, but got I
		//IL_0883: Expected Obj, but got I
		//IL_0f02: Expected I, but got Obj
		//IL_0f12: Expected Obj, but got I
		//IL_0f3b: Expected Obj, but got I
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected Obj, but got Unknown
		//IL_08e0: Expected Obj, but got I
		//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Expected Obj, but got Unknown
		//IL_0f98: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_0906: Expected Obj, but got Ref
		//IL_0fbe: Expected Obj, but got Ref
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I
		//IL_0977: Expected Obj, but got I8
		//IL_102f: Expected Obj, but got I8
		//IL_015d: Expected Obj, but got Ref
		//IL_091c: Expected I, but got Obj
		//IL_092c: Expected Obj, but got I
		//IL_0955: Expected Obj, but got I
		//IL_0fd4: Expected I, but got Obj
		//IL_0fe4: Expected Obj, but got I
		//IL_100d: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I8
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_1055: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Expected Obj, but got Unknown
		//IL_0173: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_09da: Expected Obj, but got Ref
		//IL_1092: Expected Obj, but got Ref
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0a53: Expected Obj, but got I4
		//IL_0a63: Expected Obj, but got I4
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Expected Obj, but got Unknown
		//IL_110b: Expected Obj, but got I4
		//IL_111b: Expected Obj, but got I4
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got Ref
		//IL_09f0: Expected I, but got Obj
		//IL_0a00: Expected Obj, but got I
		//IL_0a29: Expected Obj, but got I
		//IL_10a8: Expected I, but got Obj
		//IL_10b8: Expected Obj, but got I
		//IL_10e1: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Expected Obj, but got Unknown
		//IL_0247: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_0adc: Expected Obj, but got Ref
		//IL_1194: Expected Obj, but got Ref
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0b4d: Expected Obj, but got I8
		//IL_1205: Expected Obj, but got I8
		//IL_0333: Expected Obj, but got Ref
		//IL_0af2: Expected I, but got Obj
		//IL_0b02: Expected Obj, but got I
		//IL_0b2b: Expected Obj, but got I
		//IL_11aa: Expected I, but got Obj
		//IL_11ba: Expected Obj, but got I
		//IL_11e3: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I8
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected Obj, but got Unknown
		//IL_122b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1230: Expected Obj, but got Unknown
		//IL_1252: Expected Obj, but got I
		//IL_0349: Expected I, but got Obj
		//IL_0359: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I
		//IL_0bb0: Expected Obj, but got Ref
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_0c29: Expected Obj, but got I4
		//IL_0c39: Expected Obj, but got I4
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected Obj, but got Unknown
		//IL_0407: Expected Obj, but got Ref
		//IL_0bc6: Expected I, but got Obj
		//IL_0bd6: Expected Obj, but got I
		//IL_0bff: Expected Obj, but got I
		//IL_0480: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I4
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected Obj, but got Unknown
		//IL_041d: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I
		//IL_0cb2: Expected Obj, but got Ref
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_0d2b: Expected Obj, but got I4
		//IL_0d3b: Expected Obj, but got I4
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected Obj, but got Unknown
		//IL_0509: Expected Obj, but got Ref
		//IL_0cc8: Expected I, but got Obj
		//IL_0cd8: Expected Obj, but got I
		//IL_0d01: Expected Obj, but got I
		//IL_0582: Expected Obj, but got I4
		//IL_0592: Expected Obj, but got I4
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected Obj, but got Unknown
		//IL_051f: Expected I, but got Obj
		//IL_052f: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0db4: Expected Obj, but got Ref
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected Obj, but got Unknown
		//IL_0e2d: Expected Obj, but got I4
		//IL_0e3d: Expected Obj, but got I4
		//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Expected Obj, but got Unknown
		//IL_060b: Expected Obj, but got Ref
		//IL_0dca: Expected I, but got Obj
		//IL_0dda: Expected Obj, but got I
		//IL_0e03: Expected Obj, but got I
		//IL_0684: Expected Obj, but got I4
		//IL_0694: Expected Obj, but got I4
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Obj, but got Unknown
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected Obj, but got Unknown
		//IL_0ea0: Expected Obj, but got I
		//IL_0621: Expected I, but got Obj
		//IL_0631: Expected Obj, but got I
		//IL_065a: Expected Obj, but got I
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		//IL_070d: Expected Obj, but got Ref
		//IL_077e: Expected Obj, but got I8
		//IL_0723: Expected I, but got Obj
		//IL_0733: Expected Obj, but got I
		//IL_075c: Expected Obj, but got I
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected Obj, but got Unknown
		//IL_07cb: Expected Obj, but got I
		int num = commandFlags & 2;
		bool flag = num == 0;
		object obj = !flag;
		object obj2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			obj2 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0D0]");
			obj2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj3 = 0;
		object obj4;
		object obj9 = default;
		object obj13 = default;
		object obj20 = default;
		object obj24 = default;
		object obj38 = default;
		object obj45 = default;
		object format;
		object[] args;
		IndexOutOfRangeException ex = default;
		object obj5;
		if (unreliableSequenceNumber != 0)
		{
			if (full)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object[] array = default;
				if (array != null)
				{
					bool flag2 = obj2 == null;
					obj4 = 8;
					if (!flag2)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v94 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag3 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v94 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						if (flag3)
						{
							goto IL_12d1;
						}
					}
					if (array.Length != 0)
					{
						object obj6 = array + 32;
						obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj8 = default;
						bool flag4 = obj8 == null;
						obj4 = (object)(&obj9);
						if (!flag4)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v93 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag5 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v93 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							if (flag5)
							{
								goto IL_12d1;
							}
						}
						object obj10 = array.Length & 0xFFFFFFFEL;
						if (obj10 != null)
						{
							object obj11 = array + 40;
							obj11 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj12 = default;
							bool flag6 = obj12 == null;
							obj4 = (object)(&obj13);
							if (!flag6)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v92 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag7 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v92 (Il2CppClass<System.Object[]>)+40]");
								obj5 = 0;
								if (flag7)
								{
									goto IL_12d1;
								}
							}
							bool flag8 = array.Length < 2;
							object obj14 = !flag8;
							object obj15 = array.Length - 2;
							bool flag9 = obj15 == null;
							object obj16 = ~obj14;
							object obj17 = obj16 | flag9;
							if (obj17 == null)
							{
								object obj18 = array + 48;
								obj18 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj19 = default;
								bool flag10 = obj19 == null;
								obj4 = (object)(&obj20);
								if (!flag10)
								{
									nint num5 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v91 (Il2CppClass<System.Object[]>)+40]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag11 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v91 (Il2CppClass<System.Object[]>)+40]");
									obj5 = 0;
									if (flag11)
									{
										goto IL_12d1;
									}
								}
								object obj21 = array.Length & 0xFFFFFFFCL;
								if (obj21 != null)
								{
									object obj22 = array + 56;
									obj22 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj23 = default;
									bool flag12 = obj23 == null;
									obj4 = (object)(&obj24);
									if (!flag12)
									{
										nint num6 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v90 (Il2CppClass<System.Object[]>)+40]");
										obj4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag13 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v90 (Il2CppClass<System.Object[]>)+40]");
										obj5 = 0;
										if (flag13)
										{
											goto IL_12d1;
										}
									}
									bool flag14 = array.Length < 4;
									object obj25 = !flag14;
									object obj26 = array.Length - 4;
									bool flag15 = obj26 == null;
									object obj27 = ~obj25;
									object obj28 = obj27 | flag15;
									if (obj28 == null)
									{
										object obj29 = array + 64;
										obj29 = obj23;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										object obj30 = default;
										bool flag16 = obj30 == null;
										object obj31 = default;
										obj4 = (object)(&obj31);
										if (!flag16)
										{
											nint num7 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
											obj4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag17 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
											obj5 = 0;
											if (flag17)
											{
												goto IL_12d1;
											}
										}
										bool flag18 = array.Length < 5;
										object obj32 = !flag18;
										object obj33 = array.Length - 5;
										bool flag19 = obj33 == null;
										object obj34 = ~obj32;
										object obj35 = obj34 | flag19;
										if (obj35 == null)
										{
											object obj36 = array + 72;
											obj36 = obj30;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj37 = default;
											bool flag20 = obj37 == null;
											obj4 = (object)(&obj38);
											if (!flag20)
											{
												nint num8 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
												obj4 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag21 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
												obj5 = 0;
												if (flag21)
												{
													goto IL_12d1;
												}
											}
											bool flag22 = array.Length < 6;
											object obj39 = !flag22;
											object obj40 = array.Length - 6;
											bool flag23 = obj40 == null;
											object obj41 = ~obj39;
											object obj42 = obj41 | flag23;
											if (obj42 == null)
											{
												object obj43 = array + 80;
												obj43 = obj37;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												object obj44 = default;
												bool flag24 = obj44 == null;
												obj4 = (object)(&obj45);
												if (!flag24)
												{
													nint num9 = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
													obj4 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag25 = ex == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
													obj5 = 0;
													if (flag25)
													{
														goto IL_12d1;
													}
												}
												object obj46 = array.Length & 0xFFFFFFF8L;
												if (obj46 != null)
												{
													object obj47 = array + 88;
													obj47 = obj44;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516328]");
													format = 0;
													args = array;
													goto IL_135e;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_12bb;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object[] array2 = default;
				if (array2 != null)
				{
					bool flag26 = obj2 == null;
					obj4 = 4;
					if (!flag26)
					{
						nint num10 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v61 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag27 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v61 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						if (flag27)
						{
							goto IL_12d1;
						}
					}
					if (array2.Length != 0)
					{
						object obj48 = array2 + 32;
						obj48 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj50 = default;
						bool flag28 = obj50 == null;
						obj4 = (object)(&obj9);
						if (!flag28)
						{
							nint num11 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag29 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							if (flag29)
							{
								goto IL_12d1;
							}
						}
						object obj51 = array2.Length & 0xFFFFFFFEL;
						if (obj51 != null)
						{
							object obj52 = array2 + 40;
							obj52 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj53 = default;
							bool flag30 = obj53 == null;
							obj4 = (object)(&obj13);
							if (!flag30)
							{
								nint num12 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag31 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
								obj5 = 0;
								if (flag31)
								{
									goto IL_12d1;
								}
							}
							bool flag32 = array2.Length < 2;
							object obj54 = !flag32;
							object obj55 = array2.Length - 2;
							bool flag33 = obj55 == null;
							object obj56 = ~obj54;
							object obj57 = obj56 | flag33;
							if (obj57 == null)
							{
								object obj58 = array2 + 48;
								obj58 = obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj59 = default;
								bool flag34 = obj59 == null;
								obj4 = (object)(&obj38);
								if (!flag34)
								{
									nint num13 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag35 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
									obj5 = 0;
									if (flag35)
									{
										goto IL_12d1;
									}
								}
								object obj60 = array2.Length & 0xFFFFFFFCL;
								if (obj60 != null)
								{
									object obj61 = array2 + 56;
									obj61 = obj59;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516318]");
									format = 0;
									args = array2;
									goto IL_135e;
								}
							}
						}
					}
					goto IL_12bb;
				}
			}
		}
		else
		{
			if (!full)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj62 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516330]");
				object format2 = 0;
				object arg = default;
				object arg2 = default;
				return string.Format((string)format2, obj2, arg, arg2);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object[] array3 = default;
			if (array3 != null)
			{
				bool flag36 = obj2 == null;
				obj4 = 7;
				if (!flag36)
				{
					nint num14 = (nint)array3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag37 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					if (flag37)
					{
						goto IL_12d1;
					}
				}
				if (array3.Length != 0)
				{
					object obj63 = array3 + 32;
					obj63 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj65 = default;
					bool flag38 = obj65 == null;
					obj4 = (object)(&obj9);
					if (!flag38)
					{
						nint num15 = (nint)array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag39 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						if (flag39)
						{
							goto IL_12d1;
						}
					}
					object obj66 = array3.Length & 0xFFFFFFFEL;
					if (obj66 != null)
					{
						object obj67 = array3 + 40;
						obj67 = obj65;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj68 = default;
						bool flag40 = obj68 == null;
						obj4 = (object)(&obj45);
						if (!flag40)
						{
							nint num16 = (nint)array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag41 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							if (flag41)
							{
								goto IL_12d1;
							}
						}
						bool flag42 = array3.Length < 2;
						object obj69 = !flag42;
						object obj70 = array3.Length - 2;
						bool flag43 = obj70 == null;
						object obj71 = ~obj69;
						object obj72 = obj71 | flag43;
						if (obj72 == null)
						{
							object obj73 = array3 + 48;
							obj73 = obj68;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj74 = default;
							bool flag44 = obj74 == null;
							obj4 = (object)(&obj20);
							if (!flag44)
							{
								nint num17 = (nint)array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag45 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
								obj5 = 0;
								if (flag45)
								{
									goto IL_12d1;
								}
							}
							object obj75 = array3.Length & 0xFFFFFFFCL;
							if (obj75 != null)
							{
								object obj76 = array3 + 56;
								obj76 = obj74;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj77 = default;
								bool flag46 = obj77 == null;
								obj4 = (object)(&obj24);
								if (!flag46)
								{
									nint num18 = (nint)array3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag47 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
									obj5 = 0;
									if (flag47)
									{
										goto IL_12d1;
									}
								}
								bool flag48 = array3.Length < 4;
								object obj78 = !flag48;
								object obj79 = array3.Length - 4;
								bool flag49 = obj79 == null;
								object obj80 = ~obj78;
								object obj81 = obj80 | flag49;
								if (obj81 == null)
								{
									object obj82 = array3 + 64;
									obj82 = obj77;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj83 = default;
									bool flag50 = obj83 == null;
									obj4 = (object)(&obj13);
									if (!flag50)
									{
										nint num19 = (nint)array3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
										obj4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag51 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
										obj5 = 0;
										if (flag51)
										{
											goto IL_12d1;
										}
									}
									bool flag52 = array3.Length < 5;
									object obj84 = !flag52;
									object obj85 = array3.Length - 5;
									bool flag53 = obj85 == null;
									object obj86 = ~obj84;
									object obj87 = obj86 | flag53;
									if (obj87 == null)
									{
										object obj88 = array3 + 72;
										obj88 = obj83;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										object obj89 = default;
										bool flag54 = obj89 == null;
										obj4 = (object)(&obj38);
										if (!flag54)
										{
											nint num20 = (nint)array3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
											obj4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag55 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
											obj5 = 0;
											if (flag55)
											{
												goto IL_12d1;
											}
										}
										bool flag56 = array3.Length < 6;
										object obj90 = !flag56;
										object obj91 = array3.Length - 6;
										bool flag57 = obj91 == null;
										object obj92 = ~obj90;
										object obj93 = obj92 | flag57;
										if (obj93 == null)
										{
											object obj94 = array3 + 80;
											obj94 = obj89;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516320]");
											format = 0;
											args = array3;
											goto IL_135e;
										}
									}
								}
							}
						}
					}
				}
				goto IL_12bb;
			}
		}
		goto IL_12e9;
		IL_12d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_12e9;
		IL_12e9:
		return (string)(object)new NullReferenceException();
		IL_135e:
		return string.Format((string)format, args);
		IL_12bb:
		ex = new IndexOutOfRangeException();
		obj5 = obj4;
		goto IL_12d1;
	}
}
