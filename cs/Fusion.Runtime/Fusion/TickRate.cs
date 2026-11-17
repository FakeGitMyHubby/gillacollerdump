using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

[StructLayout((LayoutKind)2)]
public struct TickRate
{
	public sealed class EqualityComparer : _0021_00210
	{
		public bool Equals(Tick x, Tick y)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = x - y;
			return obj == null;
		}

		public int GetHashCode(Tick obj)
		{
			//IL_0005: Expected I4, but got VT
			return (int)obj;
		}
	}

	[Serializable]
	[StructLayout((LayoutKind)2)]
	public struct Selection
	{
		[FieldOffset(0)]
		public int Client;

		[FieldOffset(8)]
		public int ClientSendInterval;

		[FieldOffset(4)]
		public int ServerTickInterval;

		[FieldOffset(12)]
		public int ServerSendInterval;

		[FieldOffset(8)]
		public int ClientSendIndex;

		[FieldOffset(4)]
		public int ServerIndex;

		[FieldOffset(12)]
		public int ServerSendIndex;

		public unsafe bool ConvertObsoleteIndicesToIntervals()
		{
			//IL_0010: Expected Obj, but got I
			//IL_00b4: Expected Obj, but got Ref
			//IL_00d2: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F48]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			int client = Client;
			object obj2 = default;
			object obj3 = default;
			bool flag = ((ValueType)(&obj2)).Equals(obj3);
			bool flag2 = !flag;
			object obj4 = !flag2;
			bool result;
			if (obj4 != null || ServerTickInterval != 0)
			{
				result = false;
			}
			else
			{
				ServerTickInterval = 1;
				client = ClientSendInterval & 0x1F;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
				ClientSendInterval = client;
				result = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
			if (num == 0)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			bool result2 = default;
			return result2;
		}

		public TimeSeries.ValidateResult Validate()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected Obj, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0052: Expected Obj, but got I4
			//IL_007d: Expected Obj, but got I4
			//IL_0097: Expected Obj, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected Obj, but got Unknown
			//IL_00bf: Expected Obj, but got I4
			//IL_0116: Expected Obj, but got I4
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected Obj, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected Obj, but got Unknown
			//IL_017b: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got I4
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected Obj, but got Unknown
			//IL_01d2: Expected Obj, but got I4
			//IL_0229: Expected Obj, but got I4
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected Obj, but got Unknown
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected Obj, but got Unknown
			//IL_028e: Expected Obj, but got I4
			//IL_0280: Expected Obj, but got I4
			//IL_02a3: Expected Obj, but got I4
			//IL_02bd: Expected Obj, but got I4
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Expected Obj, but got Unknown
			//IL_02e5: Expected Obj, but got I4
			//IL_033c: Expected Obj, but got I4
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Expected Obj, but got Unknown
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected Obj, but got Unknown
			//IL_0373: Expected Obj, but got I4
			//IL_03a4: Expected Obj, but got I4
			//IL_03e1: Expected Obj, but got I4
			object obj = Client - 8;
			bool flag = (nint)obj < 248;
			object obj2 = !flag;
			object obj3 = obj - 248;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = ClientSendInterval - 1;
				bool flag3 = (nint)obj6 < 7;
				object obj7 = !flag3;
				object obj8 = obj6 - 7;
				bool flag4 = obj8 == null;
				object obj9 = !flag4;
				object obj10 = obj7 & obj9;
				if (obj10 == null)
				{
					int num = Client & 0xFFFF;
					int num2 = ClientSendInterval & 0xFFFF;
					int num3 = num / num2;
					object obj11 = num3 * ClientSendInterval;
					object obj12 = Client - obj11;
					object obj13 = obj12 & 0xFFFF;
					object obj14;
					if (obj13 == null)
					{
						bool flag5 = num3 < 4;
						obj14 = !flag5;
					}
					else
					{
						obj14 = 0;
					}
					object obj15 = ~obj14;
					if (obj15 == null)
					{
						object obj16 = ServerTickInterval - 1;
						bool flag6 = (nint)obj16 < 7;
						object obj17 = !flag6;
						object obj18 = obj16 - 7;
						bool flag7 = obj18 == null;
						object obj19 = !flag7;
						object obj20 = obj17 & obj19;
						if (obj20 == null)
						{
							int num4 = Client & 0xFFFF;
							int num5 = ServerTickInterval & 0xFFFF;
							int num6 = num4 / num5;
							object obj21 = num6 * ServerTickInterval;
							object obj22 = Client - obj21;
							object obj23 = obj22 & 0xFFFF;
							object obj24;
							if (obj23 == null)
							{
								bool flag8 = num6 < 8;
								obj24 = !flag8;
							}
							else
							{
								obj24 = 0;
							}
							object obj25 = ~obj24;
							if (obj25 == null)
							{
								object obj26 = ServerSendInterval - 1;
								bool flag9 = (nint)obj26 < 7;
								object obj27 = !flag9;
								object obj28 = obj26 - 7;
								bool flag10 = obj28 == null;
								object obj29 = !flag10;
								object obj30 = obj27 & obj29;
								if (obj30 == null)
								{
									int num7 = Client & 0xFFFF;
									int num8 = ServerSendInterval & 0xFFFF;
									int num9 = num7 / num8;
									object obj31 = num9 * ServerSendInterval;
									object obj32 = Client - obj31;
									object obj33 = obj32 & 0xFFFF;
									bool flag11 = obj33 == null;
									object obj34 = !flag11;
									TimeSeries.ValidateResult result = (TimeSeries.ValidateResult)3;
									if (obj34 == null)
									{
										bool flag12 = num9 < 4;
										object obj35 = !flag12;
										object obj36 = ~obj35;
										result = (TimeSeries.ValidateResult)3;
										if (obj36 == null)
										{
											bool flag13 = ServerSendInterval < ServerTickInterval;
											object obj37 = !flag13;
											object obj38 = ~obj37;
											object obj39 = ~obj38;
											result = ((obj39 == null) ? ((TimeSeries.ValidateResult)7) : ((TimeSeries.ValidateResult)0));
										}
									}
									return result;
								}
							}
						}
					}
				}
			}
			return (TimeSeries.ValidateResult)3;
		}

		internal unsafe bool IsValidForShared(out string invalidReason)
		{
			//IL_000e: Expected Obj, but got Ref
			//IL_0130: Expected Obj, but got I
			//IL_0046: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00e0: Expected Obj, but got I
			//IL_00f0: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			string text;
			ref string reference;
			string text2;
			if (Validate() != 0)
			{
				object obj = default;
				text = ((Enum)(&obj)).ToString();
			}
			else
			{
				if (Client < 33)
				{
					if (ServerTickInterval == 1 && ServerSendInterval == ClientSendInterval)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v13+98]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v14+A0]");
						object obj4 = 0;
						reference = ref *(string*)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return true;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F58]");
					object obj5 = 0;
					text2 = (string)obj5;
					reference = ref *(string*)obj5;
					goto IL_0171;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F60]");
				object format = 0;
				object arg = default;
				text = string.Format((string)format, arg);
			}
			reference = ref *(string*)text;
			text2 = text;
			goto IL_0171;
			IL_0171:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return false;
		}

		internal bool IsValidInterval(int interval, int minResultingRate = default(int))
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0028: Expected Obj, but got I4
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected Obj, but got Unknown
			//IL_0050: Expected Obj, but got I4
			//IL_0087: Expected Obj, but got I4
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I4
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected I4, but got Unknown
			object obj = interval - 1;
			bool flag = (nint)obj < 7;
			object obj2 = !flag;
			object obj3 = obj - 7;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				int num = Client / interval;
				object obj6 = num * interval;
				object obj7 = Client - obj6;
				bool flag3;
				bool flag4;
				if (obj7 == null)
				{
					object obj8 = num - minResultingRate;
					flag3 = (nint)obj8 < 0;
					int num2 = num ^ minResultingRate;
					int num3 = num ^ obj8;
					int num4 = num2 & num3;
					flag4 = num4 < 0;
				}
				else
				{
					flag4 = false;
					flag3 = true;
				}
				return flag3 == flag4;
			}
			return false;
		}

		internal static bool IsValidInterval(int tickRate, int interval, int minResultingRate = default(int))
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0028: Expected Obj, but got I4
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected Obj, but got Unknown
			//IL_0050: Expected Obj, but got I4
			//IL_0085: Expected Obj, but got I4
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			//IL_00bf: Expected Obj, but got I4
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected I4, but got Unknown
			object obj = interval - 1;
			bool flag = (nint)obj < 7;
			object obj2 = !flag;
			object obj3 = obj - 7;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				int num = tickRate / interval;
				object obj6 = num * interval;
				object obj7 = tickRate - obj6;
				bool flag3;
				bool flag4;
				if (obj7 == null)
				{
					object obj8 = num - minResultingRate;
					flag3 = (nint)obj8 < 0;
					int num2 = num ^ minResultingRate;
					int num3 = num ^ obj8;
					int num4 = num2 & num3;
					flag4 = num4 < 0;
				}
				else
				{
					flag4 = false;
					flag3 = true;
				}
				return flag3 == flag4;
			}
			return false;
		}

		internal void Clamp()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int clientSendInterval = ClampToValidInterval(Client = Maths.Clamp(Client, 8, 256), ClientSendInterval, 4);
			ServerTickInterval = 1;
			ClientSendInterval = clientSendInterval;
			int val = ClampToValidInterval(Client, ServerSendInterval, 4);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int serverSendInterval = Math.Max(val, ServerTickInterval);
			ServerSendInterval = serverSendInterval;
		}

		internal int ClampToValidInterval(int interval, int minResultingRate = default(int))
		{
			return ClampToValidInterval(Client, interval, minResultingRate);
		}

		internal static int ClampToValidInterval(int tickRate, int interval, int minResultingRate = default(int))
		{
			//IL_0010: Expected Obj, but got I
			//IL_01d6: Expected Obj, but got I4
			//IL_021f: Expected Obj, but got I4
			//IL_022d: Expected Obj, but got I4
			//IL_0247: Expected Obj, but got I4
			//IL_013d: Expected Obj, but got I4
			//IL_014b: Expected Obj, but got I4
			//IL_0173: Expected Obj, but got I4
			//IL_0088: Expected Obj, but got I4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			//IL_00c2: Expected Obj, but got I4
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			int num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num2 = Maths.Clamp(interval, 1, 8);
			bool flag2 = num2 < 2;
			int num3 = 1;
			if (!flag2)
			{
				num3 = num2;
				while (true)
				{
					bool flag3 = num3 < 8;
					object obj4 = !flag3;
					object obj5 = num3 - 8;
					bool flag4 = obj5 == null;
					object obj6 = !flag4;
					object obj7 = obj4 & obj6;
					if (obj7 == null)
					{
						num = tickRate / num3;
						obj3 = num * num3;
						object obj8 = tickRate - obj3;
						bool flag5;
						bool flag6;
						if (obj8 == null)
						{
							object obj9 = num - minResultingRate;
							flag5 = (nint)obj9 < 0;
							int num4 = num ^ minResultingRate;
							int num5 = num ^ obj9;
							int num6 = num4 & num5;
							flag6 = num6 < 0;
						}
						else
						{
							flag6 = false;
							flag5 = true;
						}
						if (flag5 == flag6)
						{
							break;
						}
					}
					bool flag7 = num3 < 2;
					object obj10 = !flag7;
					object obj11 = num3 - 2;
					bool flag8 = obj11 == null;
					num3--;
					object obj12 = !flag8;
					object obj13 = obj10 & obj12;
					if (obj13 == null)
					{
						num3 = 1;
						break;
					}
				}
			}
			return num3;
		}
	}

	[StructLayout((LayoutKind)2, Size = 16)]
	public struct Resolved
	{
		public const int WORDS = default(int);

		[FieldOffset(0)]
		public int Client;

		[FieldOffset(4)]
		public int ClientSend;

		[FieldOffset(8)]
		public int Server;

		[FieldOffset(12)]
		public int ServerSend;

		public const int SIZE = default(int);

		public const int WORD_COUNT = default(int);

		internal const int BYTE_OF_CLIENT = default(int);

		internal const int BYTE_COUNT_OF_CLIENT = default(int);

		internal const int BYTE_OF_CLIENT_SEND = default(int);

		internal const int BYTE_COUNT_OF_CLIENT_SEND = default(int);

		internal const int BYTE_OF_SERVER = default(int);

		internal const int BYTE_COUNT_OF_SERVER = default(int);

		internal const int BYTE_OF_SERVER_SEND = default(int);

		internal const int BYTE_COUNT_OF_SERVER_SEND = default(int);

		private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

		public double ServerTickDelta
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_0040: Expected F8, but got I4
				if (Server != 0)
				{
					return 1.0 / (double)Server;
				}
				return 0.0;
			}
		}

		public double ServerSendDelta
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_0040: Expected F8, but got I4
				if (ServerSend != 0)
				{
					return 1.0 / (double)ServerSend;
				}
				return 0.0;
			}
		}

		public int ServerTickStride
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				return Client / Server;
			}
		}

		public double ClientTickDelta
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_0040: Expected F8, but got I4
				if (Client != 0)
				{
					return 1.0 / (double)Client;
				}
				return 0.0;
			}
		}

		public double ClientSendDelta
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_0040: Expected F8, but got I4
				if (ClientSend != 0)
				{
					return 1.0 / (double)ClientSend;
				}
				return 0.0;
			}
		}

		public int ClientTickStride
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				return 1;
			}
		}

		internal Resolved(int client, int clientSend, int server, int serverSend)
		{
			Client = client;
			ClientSend = clientSend;
			Server = server;
			ServerSend = serverSend;
		}

		public unsafe override string ToString()
		{
			//IL_0010: Expected Obj, but got I
			//IL_03f3: Expected Obj, but got I
			//IL_002c: Expected Obj, but got Ref
			//IL_0042: Expected I, but got Obj
			//IL_0052: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00ee: Expected Obj, but got Ref
			//IL_015f: Expected Obj, but got I8
			//IL_0104: Expected I, but got Obj
			//IL_0114: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected Obj, but got Unknown
			//IL_01c2: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_01d8: Expected I, but got Obj
			//IL_01e8: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected Obj, but got Unknown
			//IL_02c4: Expected Obj, but got Ref
			//IL_0335: Expected Obj, but got I8
			//IL_02da: Expected I, but got Obj
			//IL_02ea: Expected Obj, but got I
			//IL_0313: Expected Obj, but got I
			//IL_0362: Expected Obj, but got I
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array = default;
			if (array != null)
			{
				object obj3 = default;
				bool flag = obj3 == null;
				object obj5 = default;
				object obj4 = (object)(&obj5);
				IndexOutOfRangeException ex = default;
				object obj6;
				if (!flag)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag2)
					{
						goto IL_03b3;
					}
				}
				if (array.Length != 0)
				{
					object obj7 = array + 32;
					obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj8 = default;
					bool flag3 = obj8 == null;
					object obj9 = default;
					obj4 = (object)(&obj9);
					if (!flag3)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						if (flag4)
						{
							goto IL_03b3;
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
						bool flag5 = obj12 == null;
						object obj13 = default;
						obj4 = (object)(&obj13);
						if (!flag5)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag6)
							{
								goto IL_03b3;
							}
						}
						bool flag7 = array.Length < 2;
						object obj14 = !flag7;
						object obj15 = array.Length - 2;
						bool flag8 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag8;
						if (obj17 == null)
						{
							object obj18 = array + 48;
							obj18 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj19 = default;
							bool flag9 = obj19 == null;
							object obj20 = default;
							obj4 = (object)(&obj20);
							if (!flag9)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag10 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj6 = 0;
								if (flag10)
								{
									goto IL_03b3;
								}
							}
							object obj21 = array.Length & 0xFFFFFFFCL;
							if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F68]");
								object format = 0;
								object obj22 = array + 56;
								obj22 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return string.Format((string)format, array);
							}
						}
					}
				}
				ex = new IndexOutOfRangeException();
				obj6 = obj4;
				goto IL_03b3;
			}
			goto IL_03cb;
			IL_03b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex2 = new ArgumentNullException();
			goto IL_03cb;
			IL_03cb:
			return (string)(object)new NullReferenceException();
		}

		[MethodImpl((MethodImplOptions)256)]
		private static double Inverse(int rate)
		{
			//IL_003c: Expected F8, but got I4
			if (rate != 0)
			{
				return 1.0 / (double)rate;
			}
			return 0.0;
		}
	}

	internal const int SharedMax = default(int);

	internal const int Min = default(int);

	internal const int Max = default(int);

	private const int MinSend = default(int);

	internal const int MinInterval = default(int);

	internal const int MaxInterval = default(int);

	public int Client => 0;

	public int Count => 0;

	// C# has no syntax for parameterized property 'Item'.
	public int get_Item(int index)
	{
		return 0;
	}

	internal static Selection Zero
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (Selection)0;
		}
	}

	internal static Selection Default
	{
		get
		{
			//IL_000a: Expected VT, but got I8
			return (Selection)4294967360L;
		}
	}

	internal static Selection SharedDefault
	{
		get
		{
			//IL_000a: Expected VT, but got I8
			return (Selection)4294967328L;
		}
	}

	public int GetDivisor(int index)
	{
		return 1;
	}

	public int GetTickRate(int index)
	{
		return 0;
	}

	public int[] ToArray()
	{
		//IL_0010: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C98]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X19_v2+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X19_v2+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X19_v2+38]");
			obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X19_v2+38]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v8+10]");
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+A0]");
		return (int[])0;
	}

	public Selection ClampSelection(Selection selection)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_008e: Expected I, but got Obj
		//IL_0097: Expected VT, but got I4
		object obj = selection - 8;
		bool flag = (nint)obj < 248;
		object obj2 = !flag;
		object obj3 = obj - 248;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		Selection result;
		if (obj5 == null)
		{
			Selection selection2 = default;
			selection2.Clamp();
			IntPtr intPtr = default;
			nint num = intPtr;
			result = selection2;
		}
		else
		{
			nint num = unchecked((nint)null);
			result = (Selection)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num2 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Selection result2 = default;
		return result2;
	}

	public TimeSeries.ValidateResult ValidateSelection(Selection selected)
	{
		Selection selection = default;
		TimeSeries.ValidateResult result = selection.Validate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		TimeSeries.ValidateResult result2 = default;
		return result2;
	}

	internal static Selection GetDefault(GameMode forMode)
	{
		//IL_003f: Expected VT, but got I8
		//IL_002d: Expected VT, but got I8
		if (forMode == (GameMode)2)
		{
			return (Selection)4294967328L;
		}
		return (Selection)4294967360L;
	}

	public static bool IsValid(TickRate rate)
	{
		return false;
	}

	public static bool IsValid(int rate)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0031: Expected I4, but got Obj
		object obj = rate - 8;
		bool flag = (nint)obj < 249;
		object obj2 = !flag;
		return (byte)(int)(~obj2) != 0;
	}

	public static TickRate Get(int rate)
	{
		//IL_0006: Expected VT, but got I4
		return (TickRate)0;
	}

	public static Resolved Resolve(Selection selection)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F40]");
		object error = 0;
		Selection selection2 = default;
		TimeSeries.ValidateResult validateResult = selection2.Validate();
		bool condition = validateResult == 0;
		Assert.Always(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
		if (num == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			return (Resolved)selection;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Resolved result = default;
		return result;
	}
}
