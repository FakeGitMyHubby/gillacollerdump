using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;

namespace Photon.Client;

public class SupportClass
{
	private class ReceiveContext
	{
		public Socket workSocket;

		public int ReceivedHeaderBytes;

		public byte[] HeaderBuffer;

		public int ExpectedMessageBytes;

		public int ReceivedMessageBytes;

		public byte[] MessageBuffer;

		public bool ReadingHeader => ExpectedMessageBytes == 0;

		public bool ReadingMessage
		{
			get
			{
				bool flag = ExpectedMessageBytes == 0;
				return !flag;
			}
		}

		public byte[] CurrentBuffer
		{
			get
			{
				//IL_0039: Expected Obj, but got I4
				//IL_004b: Expected Obj, but got I
				//IL_002b: Expected Obj, but got I4
				if (ExpectedMessageBytes == 0)
				{
					object obj = 32;
				}
				else
				{
					object obj = 48;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.SupportClass+ReceiveContext)+v16 @ X8_v2]");
				return (byte[])0;
			}
		}

		public int CurrentOffset
		{
			get
			{
				//IL_0039: Expected Obj, but got I4
				//IL_002b: Expected Obj, but got I4
				if (ExpectedMessageBytes == 0)
				{
					object obj = 24;
				}
				else
				{
					object obj = 44;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.SupportClass+ReceiveContext)+v16 @ X8_v2]");
				return 0;
			}
		}

		public int CurrentExpected
		{
			get
			{
				if (ExpectedMessageBytes == 0)
				{
					return 9;
				}
				return ExpectedMessageBytes;
			}
		}

		public ReceiveContext(Socket socket, byte[] headerBuffer, byte[] messageBuffer)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected Obj, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = headerBuffer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj2 = this + 48;
			obj2 = messageBuffer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = this + 16;
			obj3 = socket;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public void Reset()
		{
			ReceivedHeaderBytes = 0;
			ExpectedMessageBytes = 0;
		}
	}

	private static uint[] crcLookupTable;

	public static List<MethodInfo> GetMethods(Type type, Type attribute)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_008f: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I8
		//IL_0118: Expected Obj, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_0208: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FCF98]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FCF88]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X23_v4+E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = type == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_0449;
		}
		if ((object)type != null)
		{
			nint num = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v7 (Il2CppClass<System.Type>)+7B0]");
			object obj7 = 0;
			Type type2 = ((System.RuntimeType)type).MakeByRefType();
			if ((object)type2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15 (System.Type)+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0449;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15 (System.Type)+18]");
				object obj8 = 0 & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FCF78]");
				object obj9 = 0;
				object obj10 = type2 + 32;
				object obj11 = 0;
				System.__Canon _Canon = (System.__Canon)52;
				object obj17 = default;
				object obj19 = default;
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
					object obj12 = !flag4;
					if (obj12 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X23_v4+E8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v5+v172 @ X24_v6*8]");
					System.__Canon _Canon2 = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v17+E4]");
					bool flag5 = (nint)0 == 0;
					object obj14 = !flag5;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = attribute == null;
					bool flag7 = !flag6;
					object obj15 = !flag7;
					object obj16 = 0;
					object obj20;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v5+v172 @ X24_v6*8]");
						if ((nint)0 == 0)
						{
							goto IL_044e;
						}
						nint num2 = (nint)_Canon2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v18 (Il2CppClass<System.__Canon>)+200]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X8_v18 (Il2CppClass<System.__Canon>)+1F8] (should have been resolved before IL gen)");
						object obj18 = obj19 & 1;
						bool flag8 = obj18 == null;
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v18 (Il2CppClass<System.__Canon>)+200]");
						obj20 = 0;
						obj7 = 0;
						_Canon = (System.__Canon)(object)attribute;
						if (flag8)
						{
							goto IL_03ff;
						}
					}
					if (list != null)
					{
						System.__Canon[] items = list._items;
						object obj21 = obj9;
						int version = list._version + 1;
						list._version = version;
						if (list._items != null)
						{
							bool flag9 = list._size < items.Length;
							object obj22 = !flag9;
							if (obj22 == null)
							{
								object obj23 = list._items + list._size;
								int size = list._size + 1;
								list._size = size;
								object obj24 = obj23 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v5+v172 @ X24_v6*8]");
								obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								obj20 = obj17;
								obj7 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v5+v172 @ X24_v6*8]");
								_Canon = (System.__Canon)0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X9_v8+20]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v16+A8]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v17+70]");
								obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v5+v172 @ X24_v6*8]");
								list.AddWithResize((System.__Canon)0);
								obj20 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v5+v172 @ X24_v6*8]");
								_Canon = (System.__Canon)0;
							}
							goto IL_03ff;
						}
					}
					goto IL_044e;
					IL_03ff:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15 (System.Type)+18]");
					obj8 = 0;
					obj11++;
					object obj27 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15 (System.Type)+18]");
					bool flag10 = (nint)obj27 < 0;
					obj17 = obj20;
					if (flag10)
					{
						continue;
					}
					goto IL_0449;
				}
				goto IL_045c;
			}
		}
		goto IL_044e;
		IL_0449:
		return (List<MethodInfo>)(object)list;
		IL_045c:
		return (List<MethodInfo>)(object)new IndexOutOfRangeException();
		IL_044e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_045c;
	}

	public static void WriteStackTrace(Exception throwable, TextWriter stream = null)
	{
		//IL_008b: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got F8
		//IL_0028: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0056: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		if (stream != null)
		{
			ushort num = ((Enum)(object)throwable).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
			((object)stream).Finalize();
			double num2 = ((Enum)(object)throwable).System_002EIConvertible_002EToDouble((IFormatProvider)0);
			((object)stream).Finalize();
			nint num3 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7 (Il2CppClass<System.IO.TextWriter>)+1D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7 (Il2CppClass<System.IO.TextWriter>)+1E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v53 @ X2_v3 (should have been resolved before IL gen)");
		}
		string message = (string)((Enum)(object)throwable).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
		Debug.WriteLine(message);
		string message2 = (string)((Enum)(object)throwable).System_002EIConvertible_002EToDouble((IFormatProvider)0);
		Debug.WriteLine(message2);
	}

	public unsafe static string DictionaryToString(IDictionary dictionary, bool includeTypes = default(bool))
	{
		//IL_0150: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_008c: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_1d69: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0193: Expected I, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_1db1: Expected Obj, but got I
		//IL_1dd2: Expected Obj, but got Ref
		//IL_01fb: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_2119: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0323: Expected I, but got Obj
		//IL_1e15: Expected Obj, but got I
		//IL_1e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2d: Expected Obj, but got Unknown
		//IL_02c3: Expected Obj, but got I
		//IL_18f6: Expected Obj, but got Ref
		//IL_18fe: Expected Obj, but got Ref
		//IL_190c: Expected Obj, but got I4
		//IL_1915: Expected Obj, but got I4
		//IL_2397: Expected Obj, but got I
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_2313: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_1932: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_1a1c: Expected Obj, but got I4
		//IL_19cd: Expected I, but got Obj
		//IL_2355: Expected Obj, but got I
		//IL_196d: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I
		//IL_048d: Expected I, but got Obj
		//IL_049d: Expected Obj, but got I
		//IL_1a8f: Expected Obj, but got I
		//IL_19f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f5: Expected Obj, but got Unknown
		//IL_046f: Expected Obj, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_1a69: Expected Obj, but got I4
		//IL_1988: Expected Obj, but got I
		//IL_1991: Unknown result type (might be due to invalid IL or missing references)
		//IL_1996: Expected Obj, but got Unknown
		//IL_04d8: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_061b: Expected Obj, but got I
		//IL_063d: Expected Obj, but got I4
		//IL_0670: Expected VT, but got I
		//IL_068d: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I4
		//IL_0560: Expected I, but got Obj
		//IL_0570: Expected Obj, but got I
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_1f76: Expected Obj, but got I
		//IL_1f86: Expected Obj, but got I
		//IL_1f8e: Expected VT, but got Obj
		//IL_1fb0: Expected Obj, but got I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected Obj, but got Unknown
		//IL_05ab: Expected Obj, but got I
		//IL_084b: Expected Obj, but got I4
		//IL_0908: Expected I, but got Obj
		//IL_0918: Expected Obj, but got I
		//IL_06ed: Expected I, but got Obj
		//IL_06fd: Expected Obj, but got I
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected Obj, but got Unknown
		//IL_0869: Expected Obj, but got I
		//IL_0879: Expected Obj, but got I
		//IL_0881: Expected VT, but got Obj
		//IL_08a3: Expected Obj, but got I4
		//IL_05c6: Expected Obj, but got I
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_0953: Expected Obj, but got I
		//IL_0738: Expected Obj, but got I
		//IL_0b45: Expected VT, but got Obj
		//IL_0b69: Expected Obj, but got I4
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected Obj, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected Obj, but got Unknown
		//IL_09c3: Expected Obj, but got I
		//IL_09d3: Expected Obj, but got I
		//IL_09db: Expected VT, but got Obj
		//IL_09fd: Expected Obj, but got I4
		//IL_07e0: Expected Obj, but got I
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected Obj, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_096e: Expected Obj, but got I
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got Unknown
		//IL_0753: Expected Obj, but got I
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected Obj, but got Unknown
		//IL_108e: Expected Obj, but got I
		//IL_10b8: Expected Obj, but got I4
		//IL_10c8: Expected I, but got Obj
		//IL_1112: Expected Obj, but got I
		//IL_1122: Expected Obj, but got I
		//IL_1144: Expected Obj, but got I4
		//IL_10e7: Expected Obj, but got I4
		//IL_0ba3: Expected Obj, but got I
		//IL_0bc5: Expected Obj, but got I4
		//IL_1b9f: Expected Obj, but got I4
		//IL_116a: Expected VT, but got Obj
		//IL_0a62: Expected I, but got Obj
		//IL_0a72: Expected Obj, but got I
		//IL_0bfd: Expected Obj, but got I4
		//IL_1264: Expected Obj, but got I
		//IL_1274: Expected Obj, but got I
		//IL_127c: Expected VT, but got Obj
		//IL_129e: Expected Obj, but got I4
		//IL_0aad: Expected Obj, but got I
		//IL_1bea: Expected Obj, but got Ref
		//IL_1bf2: Expected Obj, but got Ref
		//IL_1c00: Expected Obj, but got I4
		//IL_11a9: Expected I, but got Obj
		//IL_11b9: Expected Obj, but got I
		//IL_0c23: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I
		//IL_0c46: Invalid comparison between VT and I4
		//IL_12e6: Expected I, but got Obj
		//IL_12f6: Expected Obj, but got I
		//IL_13ee: Expected Obj, but got I
		//IL_13fe: Expected I, but got Obj
		//IL_140e: Expected Obj, but got I
		//IL_141e: Expected Obj, but got I
		//IL_1447: Expected Obj, but got I4
		//IL_13be: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Expected Obj, but got Unknown
		//IL_13cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d1: Expected Obj, but got Unknown
		//IL_218d: Expected Obj, but got I
		//IL_219e: Invalid comparison between VT and I4
		//IL_11f4: Expected Obj, but got I
		//IL_0ac8: Expected Obj, but got I
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected Obj, but got Unknown
		//IL_147b: Expected Obj, but got I
		//IL_14a4: Expected Obj, but got I
		//IL_14b4: Expected Obj, but got I
		//IL_1524: Expected Obj, but got I
		//IL_22b9: Expected Obj, but got I
		//IL_22d7: Expected I, but got Obj
		//IL_15c4: Expected Obj, but got I
		//IL_15f0: Expected Obj, but got I4
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Expected Obj, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Expected Obj, but got Unknown
		//IL_0c9c: Expected Obj, but got I
		//IL_0cd5: Expected Obj, but got I
		//IL_2208: Expected Obj, but got Ref
		//IL_2210: Expected Obj, but got Ref
		//IL_2226: Expected Obj, but got I4
		//IL_134e: Expected Obj, but got I
		//IL_120f: Expected Obj, but got I
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected Obj, but got Unknown
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected Obj, but got Unknown
		//IL_0d55: Expected Obj, but got I
		//IL_17cf: Expected Obj, but got I
		//IL_17f0: Expected Obj, but got I
		//IL_1819: Expected Obj, but got I4
		//IL_179f: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a4: Expected Obj, but got Unknown
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b2: Expected Obj, but got Unknown
		//IL_160e: Expected Obj, but got Ref
		//IL_1616: Expected Obj, but got Ref
		//IL_1624: Expected Obj, but got I4
		//IL_153f: Expected Obj, but got I
		//IL_1548: Unknown result type (might be due to invalid IL or missing references)
		//IL_154d: Expected Obj, but got Unknown
		//IL_167b: Expected Obj, but got I
		//IL_1683: Expected VT, but got Obj
		//IL_16a4: Expected Obj, but got Ref
		//IL_16ac: Expected Obj, but got Ref
		//IL_16c2: Expected Obj, but got I4
		//IL_164b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1650: Expected Obj, but got Unknown
		//IL_1659: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Expected Obj, but got Unknown
		//IL_184e: Expected Obj, but got I
		//IL_185e: Expected Obj, but got I
		//IL_1369: Expected Obj, but got I
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1377: Expected Obj, but got Unknown
		//IL_0dab: Expected Obj, but got I8
		//IL_16e8: Expected Obj, but got I
		//IL_16f0: Expected VT, but got Obj
		//IL_1711: Expected Obj, but got Ref
		//IL_1719: Expected Obj, but got Ref
		//IL_172f: Expected Obj, but got I4
		//IL_1895: Expected Obj, but got I
		//IL_18af: Expected Obj, but got I
		//IL_18d9: Expected Obj, but got I4
		//IL_18e9: Expected I, but got Obj
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Expected Obj, but got Unknown
		//IL_1c73: Invalid comparison between VT and I4
		//IL_175f: Expected Obj, but got I
		//IL_1cba: Invalid comparison between VT and I4
		//IL_1785: Expected Obj, but got I
		//IL_178a: Expected I, but got Obj
		//IL_0e2d: Expected I, but got Obj
		//IL_0e3d: Expected Obj, but got I
		//IL_0ed9: Expected Obj, but got I4
		//IL_0eef: Expected Obj, but got I
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Expected Obj, but got Unknown
		//IL_1cac: Expected Obj, but got I4
		//IL_0e80: Expected Obj, but got I
		//IL_1cfb: Expected Obj, but got I4
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f40: Expected Obj, but got Unknown
		//IL_0f48: Expected Obj, but got I4
		//IL_0fdd: Expected Obj, but got I8
		//IL_0f8c: Expected VT, but got I
		//IL_1013: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Expected Obj, but got Unknown
		//IL_103a: Expected Obj, but got I
		//IL_1053: Expected Obj, but got VT
		//IL_1079: Expected I, but got VT
		StringBuilder stringBuilder = default;
		object obj2;
		object obj3;
		object obj6;
		nint num2;
		object obj4;
		if (dictionary != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			stringBuilder._002Ector();
			bool flag = stringBuilder == null;
			obj2 = 0;
			if (flag)
			{
				goto IL_1c05;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED50]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
			obj3 = 0;
			StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
			nint num = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v32 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v32 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0128;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v32 (Il2CppClass<System.Collections.IDictionary>)+98]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X10_v117-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v32 (Il2CppClass<System.Collections.IDictionary>)+12E]");
				obj4 = -1;
				obj6 = obj5 + 16;
				bool flag2 = (nint)obj4 != 1;
				obj5 = obj6;
				if (flag2)
				{
					continue;
				}
				goto IL_0128;
			}
			obj4 = obj5 + 2;
			object obj7 = num + obj4;
			object obj8 = obj7 + 312;
			obj6 = obj5;
			num2 = unchecked((nint)null);
			goto IL_1d47;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4958]");
		object obj9 = 0;
		string result = (string)obj9;
		goto IL_1d77;
		IL_1b2a:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_1b38;
		IL_1af6:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1b04;
		IL_1ae8:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_1af6;
		IL_1ada:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_1ae8;
		IL_1d77:
		return result;
		IL_1acc:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_1ada;
		IL_1b62:
		throw new IndexOutOfRangeException();
		IL_0128:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num2 = 2;
		goto IL_1d47;
		IL_1d47:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v565 @ X0_v52] (should have been resolved before IL gen)");
		object obj10 = default;
		bool flag3 = obj10 == null;
		obj2 = 0;
		if (flag3)
		{
			goto IL_1c05;
		}
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8968]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v35+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v35+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0244;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v35+98]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X10_v112-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj12--;
			obj6 = obj13 + 16;
			bool flag4 = (nint)obj12 != 1;
			obj13 = obj6;
			if (flag4)
			{
				continue;
			}
			goto IL_0244;
		}
		object obj14 = obj11 + obj13;
		object obj15 = obj14 + 312;
		obj6 = obj13;
		goto IL_1da1;
		IL_1abe:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_1acc;
		IL_1ab0:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_1abe;
		IL_1c05:
		throw new NullReferenceException();
		IL_1a32:
		object obj16;
		string text;
		if ((nint)obj16 != 19)
		{
			bool flag5 = obj16 == null;
			object obj17 = !flag5;
			result = text;
			if (obj17 != null)
			{
				goto IL_1d77;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A90]");
		object value2 = 0;
		StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		goto IL_1d77;
		IL_1b54:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_1b62;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num2 = unchecked((nint)null);
		goto IL_1da1;
		IL_1da1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v55+8]");
		string text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v772 @ X0_v55] (should have been resolved before IL gen)");
		object obj18 = default;
		bool flag6 = obj18 == null;
		object obj19 = default;
		obj4 = (object)(&obj19);
		if (flag6)
		{
			goto IL_1ab0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj21 = 0;
		object obj22 = obj18;
		object obj27 = default;
		object obj34 = default;
		object obj35 = default;
		object obj39 = default;
		object obj53 = default;
		string text4 = default;
		object obj60 = default;
		object obj62 = default;
		object arg = default;
		string result2 = default;
		object obj64 = default;
		string text7 = default;
		IDictionary dictionary2 = default;
		NonAllocDictionary<byte, object> nonAllocDictionary = default;
		object obj77 = default;
		object obj85 = default;
		object obj90 = default;
		RuntimeTypeHandle runtimeTypeHandle3 = default;
		object obj92 = default;
		ArgumentNullException ex10 = default;
		InvalidCastException ex13 = default;
		ArgumentNullException ex15 = default;
		object obj107 = default;
		Type type2 = default;
		string text8 = default;
		RuntimeTypeHandle runtimeTypeHandle4 = default;
		string[] array = default;
		IndexOutOfRangeException ex14 = default;
		while (true)
		{
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v58+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v58+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0314;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v58+98]");
			object obj24 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X10_v107-8]");
				if (0 == (nint)obj20)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v58+12E]");
				obj4 = -1;
				obj6 = obj24 + 16;
				bool flag7 = (nint)obj4 != 1;
				obj24 = obj6;
				if (flag7)
				{
					continue;
				}
				goto IL_0314;
			}
			obj4 = obj24;
			object obj25 = obj23 + obj24;
			object obj26 = obj25 + 312;
			obj6 = obj24;
			goto IL_1e05;
			IL_2261:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2673 @ X0_v192+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2673 @ X0_v192] (should have been resolved before IL gen)");
			if (obj27 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
				object obj28 = 0;
				obj4 = obj28;
				object obj29 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X9_v54+130]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ X8_v106+130]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X9_v54+130]");
				bool flag8 = num3 < 0;
				object obj30 = !flag8;
				object obj31 = ~obj30;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ X8_v106+B0]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X9_v54+130]");
					object obj32 = num4 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2683 @ X10_v55-8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2683 @ X10_v55-8]");
					if (0 == (nint)obj4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ X8_v106+1B8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2318 @ X8_v106+1B8] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54A8]");
						object obj33 = 0;
						text2 = (string)obj33;
						StringBuilder stringBuilder4 = stringBuilder.AppendFormat((string)obj33, obj34, obj35);
						object obj36 = 0;
						object obj37 = obj35;
						num2 = (nint)obj34;
						goto IL_10cd;
					}
				}
			}
			goto IL_22dc;
			IL_1c43:
			InvalidCastException ex9 = new InvalidCastException();
			goto IL_1c51;
			IL_1ba4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ex10 = new ArgumentNullException();
			string text3 = null;
			goto IL_1bc1;
			IL_0314:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num2 = unchecked((nint)null);
			goto IL_1e05;
			IL_1e05:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X0_v100+8]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1106 @ X0_v100] (should have been resolved before IL gen)");
			object obj38 = obj39 & 1;
			if (obj38 != null)
			{
				if (obj18 == null)
				{
					break;
				}
				object obj40 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X8_v61+12E]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X8_v61+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0411;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X8_v61+98]");
				object obj42 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ X10_v102-8]");
					if (0 == (nint)obj20)
					{
						break;
					}
					obj41--;
					obj6 = obj42 + 16;
					bool flag9 = (nint)obj41 != 1;
					obj42 = obj6;
					if (flag9)
					{
						continue;
					}
					goto IL_0411;
				}
				object obj43 = obj42 + 1;
				object obj44 = obj40 + obj43;
				object obj45 = obj44 + 312;
				obj6 = obj42;
				goto IL_1e6f;
			}
			object obj46 = (object)(&obj19);
			object obj47 = (object)(&obj2);
			text = null;
			object obj48 = 0;
			obj16 = 19;
			goto IL_2387;
			IL_22f9:
			bool flag10 = text == null;
			object obj49 = !flag10;
			if (obj49 != null)
			{
				goto IL_1c26;
			}
			bool flag11 = obj48 == null;
			object obj50 = !flag11;
			OutOfMemoryException ex11 = (OutOfMemoryException)(object)text;
			if (obj50 == null)
			{
				goto IL_1a32;
			}
			goto IL_1c34;
			IL_2387:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj51 = 0;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			obj46 = obj53;
			if (obj53 == null)
			{
				goto IL_22f9;
			}
			object obj54 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v16+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v16+12E]");
			if ((nint)0 == 0)
			{
				goto IL_19be;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v16+98]");
			object obj55 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1416 @ X10_v8-8]");
				if (0 == (nint)obj51)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v16+12E]");
				obj4 = -1;
				obj6 = obj55 + 16;
				bool flag12 = (nint)obj4 != 1;
				obj55 = obj6;
				if (flag12)
				{
					continue;
				}
				goto IL_19be;
			}
			obj4 = obj55;
			object obj56 = obj54 + obj55;
			object obj57 = obj56 + 312;
			obj6 = obj55;
			goto IL_2345;
			IL_10cd:
			bool flag13 = obj18 == null;
			object obj58 = !flag13;
			obj22 = obj18;
			if (obj58 != null)
			{
				continue;
			}
			goto IL_1ab0;
			IL_1c51:
			throw new NullReferenceException();
			IL_21d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2665 @ X0_v201+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2665 @ X0_v201] (should have been resolved before IL gen)");
			bool flag14 = text4 == null;
			obj46 = (object)(&obj19);
			obj47 = (object)(&obj2);
			obj2 = obj18;
			text = null;
			obj48 = 0;
			string text5 = text4;
			if (flag14)
			{
				goto IL_1c51;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj59 = 0;
			RuntimeTypeHandle runtimeTypeHandle = (RuntimeTypeHandle)obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag15 = obj60 == null;
			obj46 = (object)(&obj19);
			obj47 = (object)(&obj2);
			obj2 = obj18;
			text = null;
			obj48 = 0;
			text5 = text4;
			if (flag15)
			{
				goto IL_1c43;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj61 = 0;
			runtimeTypeHandle = (RuntimeTypeHandle)obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag16 = obj62 == null;
			obj46 = (object)(&obj19);
			obj47 = (object)(&obj2);
			obj2 = obj18;
			text = null;
			obj48 = 0;
			text5 = text4;
			string text6;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DF8]");
				object format = 0;
				text6 = string.Format((string)format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v207+18]");
				object obj63 = 0;
				num2 = unchecked((nint)null);
				goto IL_0b86;
			}
			InvalidCastException ex12 = new InvalidCastException();
			if (runtimeTypeHandle == (RuntimeTypeHandle)(object)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj48 = 1;
			}
			else
			{
				if (runtimeTypeHandle != (RuntimeTypeHandle)(object)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				text = (string)obj64;
			}
			obj16 = 0;
			goto IL_2387;
			IL_0411:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num2 = 1;
			goto IL_1e6f;
			IL_1e6f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1449 @ X0_v103] (should have been resolved before IL gen)");
			int length = stringBuilder.Length;
			if (length > 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
				object value3 = 0;
				StringBuilder stringBuilder5 = stringBuilder.Append((string)value3);
			}
			nint num5 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ X8_v65 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ X8_v65 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0521;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ X8_v65 (Il2CppClass<System.Collections.IDictionary>)+98]");
			object obj66 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X10_v97-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj65--;
				obj6 = obj66 + 16;
				bool flag17 = (nint)obj65 != 1;
				obj66 = obj6;
				if (flag17)
				{
					continue;
				}
				goto IL_0521;
			}
			object obj67 = num5 + obj66;
			object obj68 = obj67 + 312;
			obj6 = obj66;
			goto IL_1ecb;
			IL_204f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2196 @ X0_v157+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2196 @ X0_v157] (should have been resolved before IL gen)");
			if (text7 != null)
			{
				runtimeTypeHandle = (RuntimeTypeHandle)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag18 = dictionary2 == null;
				object obj69 = !flag18;
				if (obj69 == null)
				{
					ex13 = new InvalidCastException();
					RuntimeTypeHandle runtimeTypeHandle2 = runtimeTypeHandle;
					goto IL_1b83;
				}
			}
			else
			{
				dictionary2 = null;
			}
			text6 = DictionaryToString(dictionary2, includeTypes: true);
			goto IL_0b86;
			IL_09a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_204f;
			IL_0afe:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_20ab;
			IL_20ab:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ X0_v230+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2434 @ X0_v230] (should have been resolved before IL gen)");
			bool flag19 = nonAllocDictionary == null;
			object obj70 = obj6;
			if (flag19)
			{
				goto IL_14c2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516468]");
			object obj71 = 0;
			object obj72 = obj71;
			nint num6 = (nint)nonAllocDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2081 @ X8_v137 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+130]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X1_v113+130]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2081 @ X8_v137 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+130]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X1_v113+130]");
			bool flag20 = num7 < 0;
			object obj73 = !flag20;
			object obj74 = ~obj73;
			object obj76;
			if (obj74 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2081 @ X8_v137 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+B0]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X1_v113+130]");
				object obj75 = num8 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2456 @ X8_v139-8]");
				bool flag21 = 0 != (nint)obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2081 @ X8_v137 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+130]");
				obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X1_v113+130]");
				obj76 = 0;
				if (!flag21)
				{
					goto IL_14c2;
				}
			}
			goto IL_1bd9;
			IL_1c26:
			ex11 = new OutOfMemoryException();
			goto IL_1c34;
			IL_0521:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_1ecb;
			IL_1ecb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X0_v109+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1743 @ X0_v109] (should have been resolved before IL gen)");
			if (obj77 != null)
			{
				nint num9 = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1800 @ X8_v145 (Il2CppClass<System.Collections.IDictionary>)+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1800 @ X8_v145 (Il2CppClass<System.Collections.IDictionary>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05fc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1800 @ X8_v145 (Il2CppClass<System.Collections.IDictionary>)+98]");
				object obj78 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1887 @ X10_v92-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1800 @ X8_v145 (Il2CppClass<System.Collections.IDictionary>)+12E]");
					obj4 = -1;
					obj6 = obj78 + 16;
					bool flag22 = (nint)obj4 != 1;
					obj78 = obj6;
					if (flag22)
					{
						continue;
					}
					goto IL_05fc;
				}
				obj4 = obj78;
				object obj79 = num9 + obj78;
				object obj80 = obj79 + 312;
				obj6 = obj78;
				goto IL_1f27;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X29_v11+E8]");
			object obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1804 @ X0_v240+E4]");
			bool flag23 = (nint)0 == 0;
			object obj82 = !flag23;
			if (obj82 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X29_v11+10]");
			RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
			Type typeFromHandle = Type.GetTypeFromHandle(handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4958]");
			object obj83 = 0;
			text5 = (string)obj83;
			Type type = typeFromHandle;
			object obj84 = 0;
			goto IL_1f66;
			IL_2345:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v15+8]");
			obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1496 @ X0_v15] (should have been resolved before IL gen)");
			goto IL_22f9;
			IL_139f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_21d7;
			IL_0b86:
			text5 = text6;
			goto IL_22dc;
			IL_1c34:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_1c43;
			IL_05fc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_1f27;
			IL_1f27:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ X0_v245+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1939 @ X0_v245] (should have been resolved before IL gen)");
			bool flag24 = obj85 == null;
			text2 = (string)obj34;
			if (flag24)
			{
				goto IL_1ada;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			nint num10 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ X8_v148 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ X8_v148 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0789;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ X8_v148 (Il2CppClass<System.Collections.IDictionary>)+98]");
			object obj86 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ X10_v87-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ X8_v148 (Il2CppClass<System.Collections.IDictionary>)+12E]");
				obj4 = -1;
				obj6 = obj86 + 16;
				bool flag25 = (nint)obj4 != 1;
				obj86 = obj6;
				if (flag25)
				{
					continue;
				}
				goto IL_0789;
			}
			obj4 = obj86;
			object obj87 = num10 + obj86;
			object obj88 = obj87 + 312;
			obj6 = obj86;
			goto IL_1fe3;
			IL_22dc:
			object obj97;
			if (includeTypes)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj89 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag26 = obj34 == null;
				text2 = (string)4;
				if (flag26)
				{
					goto IL_1af6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
				bool flag27 = obj90 == null;
				runtimeTypeHandle = runtimeTypeHandle3;
				text2 = (string)4;
				if (flag27)
				{
					goto IL_1ae8;
				}
				object obj91 = obj90;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ X8_v75+1B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ X8_v75+1C0]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1595 @ X8_v75+1B8] (should have been resolved before IL gen)");
				bool flag28 = runtimeTypeHandle3 == (RuntimeTypeHandle)(object)0;
				runtimeTypeHandle = runtimeTypeHandle3;
				if (flag28)
				{
					goto IL_1b46;
				}
				object obj93;
				if (obj92 != null)
				{
					IntPtr value4 = runtimeTypeHandle3.value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2010 @ X8_v89 (System.IntPtr)+40]");
					text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag29 = ex10 == null;
					obj93 = obj92;
					runtimeTypeHandle = runtimeTypeHandle3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2010 @ X8_v89 (System.IntPtr)+40]");
					text3 = (string)0;
					if (flag29)
					{
						goto IL_1bc1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v123 (System.RuntimeTypeHandle)+18]");
				bool flag30 = (nint)0 == 0;
				obj93 = obj92;
				runtimeTypeHandle = runtimeTypeHandle3;
				if (flag30)
				{
					goto IL_1b04;
				}
				object obj94 = runtimeTypeHandle3 + 32;
				obj94 = obj92;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				IntPtr value5 = runtimeTypeHandle3.value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X8_v78 (System.IntPtr)+40]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag31 = ex14 == null;
				obj93 = obj92;
				runtimeTypeHandle = runtimeTypeHandle3;
				if (flag31)
				{
					goto IL_1b12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v123 (System.RuntimeTypeHandle)+18]");
				object obj95 = 0 & 0xFFFFFFFEL;
				bool flag32 = obj95 == null;
				obj93 = obj92;
				runtimeTypeHandle = runtimeTypeHandle3;
				if (flag32)
				{
					goto IL_1b2a;
				}
				object obj96 = runtimeTypeHandle3 + 40;
				obj96 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag33 = (object)type == null;
				obj93 = obj92;
				runtimeTypeHandle = runtimeTypeHandle3;
				if (flag33)
				{
					goto IL_1b38;
				}
				nint num11 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2685 @ X8_v80 (Il2CppClass<System.Type>)+1B8]");
				obj4 = 0;
				bool flag34 = ((System.RuntimeType)type).IsArrayImpl();
				if (flag34)
				{
					IntPtr value6 = runtimeTypeHandle3.value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1932 @ X8_v88 (System.IntPtr)+40]");
					obj97 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag35 = ex15 == null;
					obj93 = obj92;
					runtimeTypeHandle = runtimeTypeHandle3;
					if (flag35)
					{
						goto IL_1ba4;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v123 (System.RuntimeTypeHandle)+18]");
				bool flag36 = (nint)0 < (nint)2;
				object obj98 = !flag36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v123 (System.RuntimeTypeHandle)+18]");
				object obj99 = -2;
				bool flag37 = obj99 == null;
				object obj100 = ~obj98;
				object obj101 = obj100 | flag37;
				obj93 = obj92;
				runtimeTypeHandle = runtimeTypeHandle3;
				if (obj101 != null)
				{
					goto IL_1b62;
				}
				object obj102 = runtimeTypeHandle3 + 48;
				obj102 = flag34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (text5 != null)
				{
					IntPtr value7 = runtimeTypeHandle3.value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v87 (System.IntPtr)+40]");
					RuntimeTypeHandle runtimeTypeHandle2 = (RuntimeTypeHandle)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag38 = ex13 == null;
					obj93 = obj92;
					runtimeTypeHandle = runtimeTypeHandle3;
					if (flag38)
					{
						goto IL_1b83;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v123 (System.RuntimeTypeHandle)+18]");
				object obj103 = 0 & 0xFFFFFFFCL;
				bool flag39 = obj103 == null;
				obj93 = obj92;
				runtimeTypeHandle = runtimeTypeHandle3;
				if (flag39)
				{
					goto IL_1b54;
				}
				object obj104 = runtimeTypeHandle3 + 56;
				obj104 = text5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DE8]");
				object obj105 = 0;
				text2 = (string)obj105;
				StringBuilder stringBuilder6 = stringBuilder.AppendFormat((string)obj105, (object[])runtimeTypeHandle3);
				object obj37 = null;
				obj93 = obj92;
				runtimeTypeHandle = runtimeTypeHandle3;
				num2 = (nint)runtimeTypeHandle3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54A8]");
				object obj106 = 0;
				text2 = (string)obj106;
				StringBuilder stringBuilder7 = stringBuilder.AppendFormat((string)obj106, obj34, text5);
				object obj36 = 0;
				object obj37 = text5;
				num2 = (nint)obj34;
			}
			goto IL_10cd;
			IL_1b83:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ex15 = new ArgumentNullException();
			obj97 = 0;
			goto IL_1ba4;
			IL_1bd9:
			InvalidCastException ex16 = new InvalidCastException();
			obj46 = (object)(&obj19);
			obj47 = (object)(&obj2);
			text = null;
			obj48 = 0;
			goto IL_1c05;
			IL_1bc1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex17 = new ArgumentNullException();
			goto IL_1bd9;
			IL_0789:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_1fe3;
			IL_1fe3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2131 @ X0_v249+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2131 @ X0_v249] (should have been resolved before IL gen)");
			bool flag40 = obj107 == null;
			type = type2;
			text2 = (string)obj34;
			if (flag40)
			{
				goto IL_1acc;
			}
			object obj108 = obj107;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v151+170]");
			obj84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1964 @ X8_v151+168] (should have been resolved before IL gen)");
			text5 = text8;
			type = type2;
			goto IL_1f66;
			IL_1245:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_2163;
			IL_14c2:
			text6 = DictionaryToString(nonAllocDictionary, includeTypes: true);
			obj6 = obj70;
			obj4 = obj76;
			goto IL_0b86;
			IL_19be:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num2 = unchecked((nint)null);
			goto IL_2345;
			IL_2163:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2526 @ X0_v216+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2526 @ X0_v216] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
			object obj109 = 0;
			text5 = (string)obj109;
			string[] value8;
			if (runtimeTypeHandle4 != (RuntimeTypeHandle)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj110 = 0;
				object obj93 = obj110;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag41 = array == null;
				object obj111 = !flag41;
				value8 = array;
				if (obj111 == null)
				{
					obj46 = (object)(&obj19);
					obj47 = (object)(&obj2);
					text = null;
					obj48 = 0;
					runtimeTypeHandle = runtimeTypeHandle4;
					InvalidCastException ex18 = new InvalidCastException();
					obj52 = obj93;
					goto IL_1c26;
				}
			}
			else
			{
				value8 = null;
			}
			string arg2 = string.Join(text5, value8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DF0]");
			object format2 = 0;
			text6 = string.Format((string)format2, arg2);
			runtimeTypeHandle = runtimeTypeHandle4;
			num2 = unchecked((nint)null);
			goto IL_0b86;
			IL_1f66:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X29_v11+E8]");
			object obj112 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FD200]");
			object obj113 = 0;
			runtimeTypeHandle = (RuntimeTypeHandle)obj113;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1965 @ X0_v113+E4]");
			bool flag42 = (nint)0 == 0;
			object obj114 = !flag42;
			if (obj114 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle2 = Type.GetTypeFromHandle(runtimeTypeHandle);
			bool flag43 = type == typeFromHandle2;
			bool flag44 = !flag43;
			object obj115 = !flag44;
			if (obj115 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X29_v11+E8]");
				object obj116 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A10]");
				object obj117 = 0;
				runtimeTypeHandle = (RuntimeTypeHandle)obj117;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2104 @ X0_v168+E4]");
				bool flag45 = (nint)0 == 0;
				object obj118 = !flag45;
				if (obj118 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle3 = Type.GetTypeFromHandle(runtimeTypeHandle);
				if (!(type == typeFromHandle3))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X29_v11+E8]");
					object obj119 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DE0]");
					object obj120 = 0;
					runtimeTypeHandle = (RuntimeTypeHandle)obj120;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2202 @ X0_v174+E4]");
					bool flag46 = (nint)0 == 0;
					object obj121 = !flag46;
					if (obj121 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle4 = Type.GetTypeFromHandle(runtimeTypeHandle);
					if (type == typeFromHandle4)
					{
						nint num12 = (nint)dictionary;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2322 @ X8_v131 (Il2CppClass<System.Collections.IDictionary>)+12E]");
						obj76 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2322 @ X8_v131 (Il2CppClass<System.Collections.IDictionary>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0afe;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2322 @ X8_v131 (Il2CppClass<System.Collections.IDictionary>)+98]");
						object obj122 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2402 @ X10_v80-8]");
							if (0 == (nint)obj3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2322 @ X8_v131 (Il2CppClass<System.Collections.IDictionary>)+12E]");
							obj76 = -1;
							obj6 = obj122 + 16;
							bool flag47 = (nint)obj76 != 1;
							obj122 = obj6;
							if (flag47)
							{
								continue;
							}
							goto IL_0afe;
						}
						obj76 = obj122;
						object obj123 = num12 + obj122;
						object obj124 = obj123 + 312;
						obj6 = obj122;
						goto IL_20ab;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X29_v11+E8]");
					object obj125 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6504228]");
					object obj126 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2326 @ X0_v180+E4]");
					bool flag48 = (nint)0 == 0;
					object obj127 = !flag48;
					if (obj127 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj126);
					if (type == typeFromHandle5)
					{
						nint num13 = (nint)dictionary;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2445 @ X8_v120 (Il2CppClass<System.Collections.IDictionary>)+12E]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2445 @ X8_v120 (Il2CppClass<System.Collections.IDictionary>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_1245;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2445 @ X8_v120 (Il2CppClass<System.Collections.IDictionary>)+98]");
						object obj128 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2503 @ X10_v72-8]");
							if (0 == (nint)obj3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2445 @ X8_v120 (Il2CppClass<System.Collections.IDictionary>)+12E]");
							obj4 = -1;
							obj6 = obj128 + 16;
							bool flag49 = (nint)obj4 != 1;
							obj128 = obj6;
							if (flag49)
							{
								continue;
							}
							goto IL_1245;
						}
						obj4 = obj128;
						object obj129 = num13 + obj128;
						object obj130 = obj129 + 312;
						obj6 = obj128;
						goto IL_2163;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X29_v11+E8]");
					object obj131 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FD0A8]");
					object obj132 = 0;
					runtimeTypeHandle = (RuntimeTypeHandle)obj132;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2449 @ X0_v186+E4]");
					bool flag50 = (nint)0 == 0;
					object obj133 = !flag50;
					if (obj133 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle6 = Type.GetTypeFromHandle(runtimeTypeHandle);
					bool flag51 = type == typeFromHandle6;
					nint num14 = (nint)dictionary;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v101 (Il2CppClass<System.Collections.IDictionary>)+12E]");
					obj4 = 0;
					if (flag51)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v101 (Il2CppClass<System.Collections.IDictionary>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_139f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v101 (Il2CppClass<System.Collections.IDictionary>)+98]");
						object obj134 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2628 @ X10_v66-8]");
							if (0 == (nint)obj3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v101 (Il2CppClass<System.Collections.IDictionary>)+12E]");
							obj4 = -1;
							obj6 = obj134 + 16;
							bool flag52 = (nint)obj4 != 1;
							obj134 = obj6;
							if (flag52)
							{
								continue;
							}
							goto IL_139f;
						}
						obj4 = obj134;
						object obj135 = num14 + obj134;
						object obj136 = obj135 + 312;
						obj6 = obj134;
						goto IL_21d7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v101 (Il2CppClass<System.Collections.IDictionary>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_1575;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v101 (Il2CppClass<System.Collections.IDictionary>)+98]");
					object obj137 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2649 @ X10_v60-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v101 (Il2CppClass<System.Collections.IDictionary>)+12E]");
						obj4 = -1;
						obj6 = obj137 + 16;
						bool flag53 = (nint)obj4 != 1;
						obj137 = obj6;
						if (flag53)
						{
							continue;
						}
						goto IL_1575;
					}
					obj4 = obj137;
					object obj138 = num14 + obj137;
					object obj139 = obj138 + 312;
					obj6 = obj137;
					goto IL_2261;
				}
			}
			nint num15 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X8_v93 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X8_v93 (Il2CppClass<System.Collections.IDictionary>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_09a4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X8_v93 (Il2CppClass<System.Collections.IDictionary>)+98]");
			object obj140 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2179 @ X10_v51-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X8_v93 (Il2CppClass<System.Collections.IDictionary>)+12E]");
				obj4 = -1;
				obj6 = obj140 + 16;
				bool flag54 = (nint)obj4 != 1;
				obj140 = obj6;
				if (flag54)
				{
					continue;
				}
				goto IL_09a4;
			}
			obj4 = obj140;
			object obj141 = num15 + obj140;
			object obj142 = obj141 + 312;
			obj6 = obj140;
			goto IL_204f;
			IL_1575:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_2261;
		}
		goto IL_1abe;
		IL_1b38:
		NullReferenceException ex19 = new NullReferenceException();
		goto IL_1b46;
		IL_1b46:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_1b54;
		IL_1b12:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex21 = new ArgumentNullException();
		goto IL_1b2a;
		IL_1b04:
		ex14 = new IndexOutOfRangeException();
		goto IL_1b12;
	}

	public unsafe static string DictionaryToString(NonAllocDictionary<byte, object> dictionary, bool includeTypes = default(bool))
	{
		//IL_1443: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_14e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ec: Expected Obj, but got Unknown
		//IL_10f7: Expected Obj, but got I4
		//IL_1100: Expected Obj, but got I4
		//IL_1108: Expected Obj, but got Ref
		//IL_1111: Expected Obj, but got I4
		//IL_1587: Expected Obj, but got I
		//IL_158f: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_15eb: Expected Obj, but got I4
		//IL_0175: Expected I, but got Obj
		//IL_1130: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_02a5: Expected VT, but got I
		//IL_02c2: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_01a4: Expected I, but got Obj
		//IL_1356: Expected Obj, but got I
		//IL_1470: Expected Obj, but got I
		//IL_148d: Expected VT, but got I
		//IL_14af: Expected Obj, but got I4
		//IL_11a3: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_117d: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_03ee: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I
		//IL_0367: Expected VT, but got I
		//IL_0389: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_042d: Expected VT, but got Obj
		//IL_0451: Expected Obj, but got I4
		//IL_0a53: Expected Obj, but got I
		//IL_0a70: Expected VT, but got I
		//IL_0a92: Expected Obj, but got I4
		//IL_09ff: Expected Obj, but got I
		//IL_0a26: Expected Obj, but got I4
		//IL_048b: Expected Obj, but got I
		//IL_127e: Expected Obj, but got I4
		//IL_129f: Expected Obj, but got I4
		//IL_0c0a: Expected Obj, but got I
		//IL_0c3c: Expected Obj, but got I4
		//IL_12c0: Expected Obj, but got I4
		//IL_0c67: Expected VT, but got I
		//IL_0af7: Expected I, but got Obj
		//IL_0506: Invalid comparison between VT and I4
		//IL_0d54: Expected Obj, but got I
		//IL_0d71: Expected VT, but got I
		//IL_0d93: Expected Obj, but got I4
		//IL_0b2e: Expected Obj, but got I
		//IL_0b3e: Expected I, but got Obj
		//IL_0b77: Expected Obj, but got I4
		//IL_0ca6: Expected I, but got Obj
		//IL_0cc0: Expected Obj, but got I
		//IL_0cd1: Invalid comparison between VT and I4
		//IL_0ddb: Expected I, but got Obj
		//IL_0bab: Expected Obj, but got I
		//IL_0564: Expected VT, but got I
		//IL_0f71: Invalid comparison between VT and I4
		//IL_152a: Expected Obj, but got I
		//IL_1550: Expected I, but got Obj
		//IL_0cf5: Expected Obj, but got I
		//IL_0d21: Expected Obj, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_0e22: Expected Obj, but got I4
		//IL_0e2b: Expected Obj, but got I4
		//IL_0e33: Expected Obj, but got Ref
		//IL_0f9d: Expected Obj, but got I
		//IL_0fdc: Expected Obj, but got I4
		//IL_06aa: Expected Obj, but got I8
		//IL_0e59: Expected Obj, but got I
		//IL_0e61: Expected VT, but got Obj
		//IL_0e8b: Expected Obj, but got I4
		//IL_0e94: Expected Obj, but got I4
		//IL_0e9c: Expected Obj, but got Ref
		//IL_12fa: Expected Obj, but got I4
		//IL_1303: Expected Obj, but got I4
		//IL_130b: Expected Obj, but got Ref
		//IL_0649: Expected Obj, but got I
		//IL_1018: Expected Obj, but got I
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_1378: Invalid comparison between VT and I4
		//IL_0eca: Expected Obj, but got I
		//IL_0ed2: Expected VT, but got Obj
		//IL_0efc: Expected Obj, but got I4
		//IL_0f05: Expected Obj, but got I4
		//IL_0f0d: Expected Obj, but got Ref
		//IL_1098: Expected Obj, but got I
		//IL_13c8: Invalid comparison between VT and I4
		//IL_074c: Expected I, but got Obj
		//IL_10bf: Expected Obj, but got I4
		//IL_0f3e: Expected Obj, but got I
		//IL_0808: Expected Obj, but got I4
		//IL_081e: Expected Obj, but got I
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_13b1: Expected Obj, but got I4
		//IL_13ba: Expected Obj, but got I4
		//IL_0f59: Expected I, but got Obj
		//IL_079f: Expected Obj, but got I
		//IL_1410: Expected Obj, but got I
		//IL_1420: Expected I, but got Obj
		//IL_1429: Expected Obj, but got I4
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected Obj, but got Unknown
		//IL_0887: Expected Obj, but got I4
		//IL_092c: Expected Obj, but got I8
		//IL_08cb: Expected Obj, but got I
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got Unknown
		//IL_0999: Expected Obj, but got I
		//IL_09aa: Expected Obj, but got VT
		//IL_09e0: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4958]");
		object obj = 0;
		StringBuilder stringBuilder = default;
		object obj23;
		string text3;
		if (dictionary != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			stringBuilder._002Ector();
			bool flag = stringBuilder == null;
			object obj3 = 0;
			object obj4 = 0;
			object obj5 = 0;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED50]");
				object value = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DD8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DC0]");
				Type type = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DC8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8178]");
				object obj8 = 0;
				StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3AB8B54");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj9 = 0;
				object[] array = null;
				object obj11 = default;
				object obj13 = default;
				object obj14 = default;
				object obj15 = default;
				string text2 = default;
				Type type2 = default;
				NonAllocDictionary<byte, object> nonAllocDictionary = default;
				RuntimeTypeHandle runtimeTypeHandle = default;
				string[] array2 = default;
				RuntimeTypeHandle runtimeTypeHandle2 = default;
				object obj55 = default;
				object obj56 = default;
				object obj60 = default;
				string text5 = default;
				object obj61 = default;
				object obj63 = default;
				object obj64 = default;
				string result = default;
				object obj66 = default;
				object arg2 = default;
				string text6 = default;
				IDictionary dictionary2 = default;
				object obj70 = default;
				RuntimeTypeHandle runtimeTypeHandle4 = default;
				object obj72 = default;
				InvalidCastException ex11 = default;
				object obj74 = default;
				ArgumentNullException ex8 = default;
				ArgumentNullException ex6 = default;
				object obj46;
				object obj86 = default;
				ArgumentNullException ex12 = default;
				RuntimeTypeHandle handle2;
				object obj21;
				object obj22;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3AB8C58");
					object obj10 = obj11 & 1;
					string text;
					nint num;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DD0]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3AB8C0C");
						int length = stringBuilder.Length;
						if (length > 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
							object value2 = 0;
							StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
						}
						num = (nint)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
						object obj17;
						if (obj13 != null)
						{
							num = (nint)obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
							if (obj14 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
								num = (nint)obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
								if (obj15 != null)
								{
									object obj16 = obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v109+170]");
									obj17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v898 @ X8_v109+168] (should have been resolved before IL gen)");
									text = text2;
									type = type2;
									goto IL_1460;
								}
								NullReferenceException ex = new NullReferenceException();
							}
							NullReferenceException ex2 = new NullReferenceException();
							goto IL_11ed;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X27_v5+E8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X0_v205+E4]");
						bool flag2 = (nint)0 == 0;
						object obj19 = !flag2;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X27_v5+10]");
						RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
						Type typeFromHandle = Type.GetTypeFromHandle(handle);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4958]");
						object obj20 = 0;
						text = (string)obj20;
						type = typeFromHandle;
						obj17 = 0;
						goto IL_1460;
					}
					obj21 = 0;
					obj22 = 0;
					text3 = (string)(&obj3);
					obj23 = 19;
					goto IL_1577;
					IL_1217:
					IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
					goto IL_1225;
					IL_0be3:
					string text4 = DictionaryToString(nonAllocDictionary, includeTypes: true);
					goto IL_046e;
					IL_1241:
					throw new IndexOutOfRangeException();
					IL_1233:
					IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
					goto IL_1241;
					IL_12c5:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
					ArgumentNullException ex5 = new ArgumentNullException();
					goto IL_12dd;
					IL_1577:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DB8]");
					object obj24 = 0;
					num = (nint)array;
					object obj25 = obj22;
					goto IL_15bf;
					IL_12a4:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
					ex6 = new ArgumentNullException();
					object obj26 = 0;
					goto IL_12c5;
					IL_15bf:
					obj5 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3AB8CE4");
					bool flag3 = obj25 == null;
					object obj27 = !flag3;
					if (obj27 == null)
					{
						bool flag4 = obj21 == null;
						object obj28 = !flag4;
						OutOfMemoryException ex7 = (OutOfMemoryException)(object)text3;
						if (obj28 == null)
						{
							goto IL_1146;
						}
					}
					else
					{
						OutOfMemoryException ex7 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					goto IL_1340;
					IL_1283:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
					ex8 = new ArgumentNullException();
					object obj29 = 0;
					goto IL_12a4;
					IL_12dd:
					throw new InvalidCastException();
					IL_1340:
					InvalidCastException ex9 = new InvalidCastException();
					goto IL_134e;
					IL_1460:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X27_v5+E8]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FD200]");
					nint num2 = 0;
					handle2 = (RuntimeTypeHandle)((IntPtr*)num2)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v56+E4]");
					bool flag5 = (nint)0 == 0;
					object obj31 = !flag5;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
					bool flag6 = type == typeFromHandle2;
					bool flag7 = !flag6;
					object obj32 = !flag7;
					object obj57;
					object obj58;
					object obj59;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X27_v5+E8]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A10]");
						num2 = 0;
						handle2 = (RuntimeTypeHandle)((IntPtr*)num2)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ X0_v112+E4]");
						bool flag8 = (nint)0 == 0;
						object obj34 = !flag8;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle3 = Type.GetTypeFromHandle(handle2);
						if (!(type == typeFromHandle3))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X27_v5+E8]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DE0]");
							num2 = 0;
							handle2 = (RuntimeTypeHandle)((IntPtr*)num2)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X0_v118+E4]");
							bool flag9 = (nint)0 == 0;
							object obj36 = !flag9;
							if (obj36 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle4 = Type.GetTypeFromHandle(handle2);
							nint num4;
							if (type == typeFromHandle4)
							{
								num = (nint)obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
								if (nonAllocDictionary == null)
								{
									goto IL_0be3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516468]");
								object obj37 = 0;
								object obj38 = obj37;
								nint num3 = (nint)nonAllocDictionary;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X1_v81+130]");
								num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1431 @ X8_v88 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+130]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X1_v81+130]");
								bool flag10 = num5 < 0;
								object obj39 = !flag10;
								object obj40 = ~obj39;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1431 @ X8_v88 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+B0]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X1_v81+130]");
									object obj41 = num6 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1462 @ X8_v90-8]");
									bool flag11 = 0 != (nint)obj38;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X1_v81+130]");
									num2 = 0;
									if (!flag11)
									{
										goto IL_0be3;
									}
								}
								goto IL_12dd;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X27_v5+E8]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6504228]");
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X0_v124+E4]");
							bool flag12 = (nint)0 == 0;
							object obj43 = !flag12;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)((IntPtr*)num4)->m_value);
							if (type == typeFromHandle5)
							{
								num = (nint)obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
								object obj44 = 0;
								text = (string)obj44;
								string[] value3;
								if (runtimeTypeHandle != (RuntimeTypeHandle)(object)0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
									object obj45 = 0;
									obj46 = obj45;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag13 = array2 == null;
									object obj47 = !flag13;
									value3 = array2;
									if (obj47 == null)
									{
										break;
									}
								}
								else
								{
									value3 = null;
								}
								string arg = string.Join(text, value3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DF0]");
								object format = 0;
								text4 = string.Format((string)format, arg);
								handle2 = runtimeTypeHandle;
								num2 = num4;
								num = unchecked((nint)null);
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X27_v5+E8]");
								object obj48 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FD0A8]");
								num2 = 0;
								handle2 = (RuntimeTypeHandle)((IntPtr*)num2)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1504 @ X0_v130+E4]");
								bool flag14 = (nint)0 == 0;
								object obj49 = !flag14;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Type typeFromHandle6 = Type.GetTypeFromHandle(handle2);
								bool flag15 = type == typeFromHandle6;
								num = (nint)obj8;
								if (!flag15)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
									bool flag16 = runtimeTypeHandle2 == (RuntimeTypeHandle)(object)0;
									handle2 = runtimeTypeHandle2;
									if (!flag16)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
										object obj50 = 0;
										num2 = runtimeTypeHandle2.value;
										object obj51 = obj50;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X9_v37 (System.IntPtr)+130]");
										nint num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v67+130]");
										bool flag17 = num7 < 0;
										object obj52 = !flag17;
										object obj53 = ~obj52;
										handle2 = runtimeTypeHandle2;
										if (obj53 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X9_v37 (System.IntPtr)+B0]");
											nint num8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v67+130]");
											object obj54 = num8 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1559 @ X9_v30-8]");
											num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1559 @ X9_v30-8]");
											bool flag18 = 0 != (nint)obj51;
											handle2 = runtimeTypeHandle2;
											if (!flag18)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												IntPtr value4 = runtimeTypeHandle2.value;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1575 @ X8_v68 (System.IntPtr)+1B8]");
												num2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1575 @ X8_v68 (System.IntPtr)+1B8] (should have been resolved before IL gen)");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54A8]");
												object format2 = 0;
												StringBuilder stringBuilder4 = stringBuilder.AppendFormat((string)format2, obj55, obj56);
												obj57 = 0;
												obj58 = obj56;
												obj59 = obj60;
												handle2 = runtimeTypeHandle2;
												array = (object[])obj55;
												continue;
											}
										}
									}
									goto IL_1555;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
								bool flag19 = text5 == null;
								text = text5;
								obj21 = 0;
								obj22 = 0;
								text3 = (string)(&obj3);
								obj3 = obj61;
								if (flag19)
								{
									goto IL_134e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
								object obj62 = 0;
								handle2 = (RuntimeTypeHandle)obj62;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag20 = obj63 == null;
								text = text5;
								obj21 = 0;
								obj22 = 0;
								text3 = (string)(&obj3);
								obj3 = obj61;
								array = (object[])obj8;
								if (flag20)
								{
									InvalidCastException ex10 = new InvalidCastException();
									if (handle2 == (RuntimeTypeHandle)(object)2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										obj21 = 1;
										obj23 = 0;
										goto IL_1577;
									}
									if (handle2 == (RuntimeTypeHandle)(object)1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										obj25 = obj64;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DB8]");
										obj24 = 0;
										obj22 = obj64;
										num = (nint)array;
										obj23 = 0;
										goto IL_15bf;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB9DC");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return result;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
								object obj65 = 0;
								handle2 = (RuntimeTypeHandle)obj65;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag21 = obj66 == null;
								text = text5;
								obj21 = 0;
								obj22 = 0;
								text3 = (string)(&obj3);
								obj3 = obj61;
								if (flag21)
								{
									goto IL_1340;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DF8]");
								object format3 = 0;
								text4 = string.Format((string)format3, arg2);
								num = unchecked((nint)null);
							}
							goto IL_046e;
						}
					}
					num = (nint)obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
					if (text6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
						object obj67 = 0;
						handle2 = (RuntimeTypeHandle)obj67;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag22 = dictionary2 == null;
						object obj68 = !flag22;
						if (obj68 == null)
						{
							ex11 = new InvalidCastException();
							RuntimeTypeHandle runtimeTypeHandle3 = handle2;
							goto IL_1262;
						}
					}
					else
					{
						dictionary2 = null;
					}
					text4 = DictionaryToString(dictionary2, includeTypes: true);
					goto IL_046e;
					IL_046e:
					text = text4;
					goto IL_1555;
					IL_1555:
					object obj78;
					if (includeTypes)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
						object obj69 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
						bool flag23 = obj70 == null;
						obj59 = obj60;
						handle2 = runtimeTypeHandle4;
						if (flag23)
						{
							goto IL_11fb;
						}
						object obj71 = obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v40+1B8]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v969 @ X8_v40+1B8] (should have been resolved before IL gen)");
						bool flag24 = runtimeTypeHandle4 == (RuntimeTypeHandle)(object)0;
						obj59 = obj60;
						handle2 = runtimeTypeHandle4;
						if (flag24)
						{
							goto IL_1209;
						}
						if (obj72 != null)
						{
							IntPtr value5 = runtimeTypeHandle4.value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X8_v55 (System.IntPtr)+40]");
							RuntimeTypeHandle runtimeTypeHandle3 = (RuntimeTypeHandle)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag25 = ex11 == null;
							obj46 = obj72;
							obj59 = obj60;
							handle2 = runtimeTypeHandle4;
							if (flag25)
							{
								goto IL_1262;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v68 (System.RuntimeTypeHandle)+18]");
						bool flag26 = (nint)0 == 0;
						obj46 = obj72;
						obj59 = obj60;
						handle2 = runtimeTypeHandle4;
						if (flag26)
						{
							goto IL_11ed;
						}
						object obj73 = runtimeTypeHandle4 + 32;
						obj73 = obj72;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj75;
						if (obj74 != null)
						{
							IntPtr value6 = runtimeTypeHandle4.value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1381 @ X8_v54 (System.IntPtr)+40]");
							obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag27 = ex8 == null;
							obj75 = obj60;
							obj46 = obj72;
							obj59 = obj60;
							handle2 = runtimeTypeHandle4;
							if (flag27)
							{
								goto IL_12a4;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v68 (System.RuntimeTypeHandle)+18]");
						object obj76 = 0 & 0xFFFFFFFEL;
						bool flag28 = obj76 == null;
						obj75 = obj60;
						obj46 = obj72;
						obj59 = obj60;
						handle2 = runtimeTypeHandle4;
						if (flag28)
						{
							goto IL_1233;
						}
						object obj77 = runtimeTypeHandle4 + 40;
						obj77 = obj74;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag29 = (object)type == null;
						obj75 = obj60;
						obj46 = obj72;
						obj59 = obj60;
						handle2 = runtimeTypeHandle4;
						if (flag29)
						{
							goto IL_1225;
						}
						nint num9 = (nint)type;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ X8_v45 (Il2CppClass<System.Type>)+1B8]");
						num2 = 0;
						bool flag30 = ((System.RuntimeType)type).IsArrayImpl();
						if (flag30)
						{
							IntPtr value7 = runtimeTypeHandle4.value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ X8_v53 (System.IntPtr)+40]");
							obj78 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag31 = ex12 == null;
							obj75 = obj60;
							obj46 = obj72;
							obj59 = obj60;
							handle2 = runtimeTypeHandle4;
							if (flag31)
							{
								goto IL_1283;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v68 (System.RuntimeTypeHandle)+18]");
						bool flag32 = (nint)0 < (nint)2;
						object obj79 = !flag32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v68 (System.RuntimeTypeHandle)+18]");
						object obj80 = -2;
						bool flag33 = obj80 == null;
						object obj81 = ~obj79;
						object obj82 = obj81 | flag33;
						obj75 = obj60;
						obj46 = obj72;
						obj59 = obj60;
						handle2 = runtimeTypeHandle4;
						if (obj82 == null)
						{
							object obj83 = runtimeTypeHandle4 + 48;
							obj83 = flag30;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (text != null)
							{
								IntPtr value8 = runtimeTypeHandle4.value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v52 (System.IntPtr)+40]");
								obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag34 = ex6 == null;
								obj75 = obj60;
								obj46 = obj72;
								obj59 = obj60;
								handle2 = runtimeTypeHandle4;
								if (flag34)
								{
									goto IL_12c5;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v68 (System.RuntimeTypeHandle)+18]");
							object obj84 = 0 & 0xFFFFFFFCL;
							bool flag35 = obj84 == null;
							obj75 = obj60;
							obj46 = obj72;
							obj59 = obj60;
							handle2 = runtimeTypeHandle4;
							if (!flag35)
							{
								object obj85 = runtimeTypeHandle4 + 56;
								obj85 = text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DE8]");
								object format4 = 0;
								StringBuilder stringBuilder5 = stringBuilder.AppendFormat((string)format4, (object[])runtimeTypeHandle4);
								obj58 = null;
								obj75 = obj60;
								obj46 = obj72;
								obj59 = obj60;
								handle2 = runtimeTypeHandle4;
								array = (object[])runtimeTypeHandle4;
								continue;
							}
							goto IL_1217;
						}
						goto IL_1241;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54A8]");
					object format5 = 0;
					StringBuilder stringBuilder6 = stringBuilder.AppendFormat((string)format5, obj86, text);
					obj57 = 0;
					obj58 = text;
					obj59 = obj60;
					array = (object[])obj86;
					continue;
					IL_134e:
					array = (object[])num;
					throw new NullReferenceException();
					IL_11ed:
					IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
					goto IL_11fb;
					IL_11fb:
					NullReferenceException ex14 = new NullReferenceException();
					goto IL_1209;
					IL_1262:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
					ex12 = new ArgumentNullException();
					obj78 = 0;
					goto IL_1283;
					IL_1225:
					NullReferenceException ex15 = new NullReferenceException();
					goto IL_1233;
					IL_1209:
					NullReferenceException ex16 = new NullReferenceException();
					goto IL_1217;
				}
				handle2 = runtimeTypeHandle;
				InvalidCastException ex17 = new InvalidCastException();
				obj21 = 0;
				obj22 = 0;
				text3 = (string)(&obj3);
				obj5 = obj46;
			}
			throw new NullReferenceException();
		}
		string result2 = (string)obj;
		goto IL_1572;
		IL_1572:
		return result2;
		IL_1146:
		if ((nint)obj23 != 19)
		{
			bool flag36 = obj23 == null;
			object obj87 = !flag36;
			result2 = text3;
			if (obj87 != null)
			{
				goto IL_1572;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A90]");
		object value9 = 0;
		StringBuilder stringBuilder7 = stringBuilder.Append((string)value9);
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		goto IL_1572;
	}

	public static string ByteArrayToString(byte[] list, int length = default(int))
	{
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_002c: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		if (list != null)
		{
			object obj = list.Length - length;
			bool flag = (nint)obj < 0;
			int num = list.Length ^ length;
			int num2 = list.Length ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			int num4 = ((obj3 != null) ? length : list.Length);
			bool flag4 = length < 0;
			int num5 = length ^ length;
			int num6 = length & num5;
			bool flag5 = num6 < 0;
			bool flag6 = flag4 == flag5;
			object obj4 = !flag6;
			object obj5 = ~obj4;
			int num7 = ((obj5 != null) ? num4 : list.Length);
			return BitConverter.ToString(list, 0, num7);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2+98]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v3+A0]");
		return (string)0;
	}

	private static uint[] InitializeTable(uint polynomial)
	{
		//IL_0010: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8BC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int num = 0;
		int num3 = default;
		object obj3 = default;
		uint[] array = default;
		while (true)
		{
			int num2 = num;
			object obj2 = 8;
			num2 = num3;
			obj2 = obj3;
			do
			{
				int num4 = num2 & 1;
				obj2--;
				int num5 = num4 & (int)polynomial;
				num2 = num5 ^ num2;
			}
			while ((nint)obj2 != 1);
			if (array != null)
			{
				bool flag = num < array.Length;
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				object obj5 = array + num;
				num++;
				if (num == 256)
				{
					return array;
				}
				continue;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		return (uint[])(object)new IndexOutOfRangeException();
	}

	public static uint CalculateCrc(byte[] buffer, int offset, int length)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I4
		//IL_0200: Expected I4, but got I8
		//IL_0023: Expected I4, but got I8
		//IL_003f: Expected Obj, but got I
		//IL_0221: Expected I4, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_027e: Expected I4, but got I8
		//IL_0101: Expected Obj, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517088]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj3 = 0;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			uint[] array = InitializeTable(3988292384u);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v13+A0]");
			object obj6 = 0;
			obj6 = array;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		uint num2;
		if (length >= 1)
		{
			if (buffer != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9+A0]");
				object obj9 = 0;
				object obj10 = buffer.Length - offset;
				bool flag2 = (nint)obj10 < offset;
				object obj11 = !flag2;
				object obj12 = ~obj11;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					obj10 = 0;
				}
				object obj14 = obj9;
				int num = length;
				num2 = 4294967295u;
				int num3 = offset;
				while (true)
				{
					if (obj10 != null)
					{
						if (obj9 == null)
						{
							break;
						}
						object obj15 = buffer + num3;
						int num4 = (int)(num2 & 0xFF);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X11_v5+20]");
						int num5 = (int)((nint)num4 ^ (nint)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v11+18]");
						bool flag3 = (nint)num5 < (nint)0;
						object obj16 = !flag3;
						if (obj16 == null)
						{
							object obj17 = obj9 + num5;
							num--;
							num3++;
							obj10--;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X11_v8+20]");
							num2 = (uint)((nuint)0u ^ (nuint)(int)num2);
							if (num != 1)
							{
								continue;
							}
							goto IL_02a8;
						}
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					break;
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (uint)(int)ex2;
		}
		num2 = 4294967295u;
		goto IL_02a8;
		IL_02a8:
		return num2;
	}

	public static uint CalculateCrc(byte[] buffer, int length)
	{
		return CalculateCrc(buffer, 0, length);
	}
}
