using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public class ClientTimeTrace
{
	private readonly long Timestamp;

	private readonly int Player;

	private int Frames;

	private double FrameDeltaTime;

	private bool PacketReceived;

	private int PacketNumber;

	private int Packets;

	private double PacketDeltaTime;

	private double RoundTripTime;

	private Simulation.TimeFeedback PacketFeedback;

	internal string Folder
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_0082: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAA60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string persistentDataPath = Application.persistentDataPath;
			return persistentDataPath + (string)obj3;
		}
	}

	internal string File
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_010e: Expected Obj, but got I
			//IL_0130: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I
			//IL_0044: Expected Obj, but got I
			//IL_008f: Expected Obj, but got I4
			//IL_00cd: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAA70]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAA68]");
			object format = 0;
			DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(Timestamp);
			DateTimeOffset dateTimeOffset2 = default;
			DateTime utcDateTime = dateTimeOffset2.UtcDateTime;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = default;
			string arg = dateTime.ToString((string)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg2 = default;
			return string.Format((string)format, arg2, arg);
		}
	}

	internal ClientTimeTrace(int player, TickRate.Resolved tickRate)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
		object obj2 = 0;
		base._002Ector();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTimeOffset dateTimeOffset = now;
		DateTimeOffset dateTimeOffset2 = default;
		Timestamp = dateTimeOffset2.ToUnixTimeMilliseconds();
		Player = player;
		WriteHeaders(tickRate);
	}

	internal void OnFeedback(Simulation.TimeFeedback packetFeedback)
	{
		Simulation.TimeFeedback packetFeedback2 = default;
		PacketFeedback = packetFeedback2;
	}

	internal void OnPacket(int packetNumber, double packetDeltaTime, double roundTripTime)
	{
		PacketDeltaTime = packetDeltaTime;
		RoundTripTime = roundTripTime;
		PacketReceived = true;
		int packets = Packets + 1;
		PacketNumber = packetNumber;
		Packets = packets;
	}

	internal void OnFrame(double frameDeltaTime)
	{
		FrameDeltaTime = frameDeltaTime;
		int frames = Frames + 1;
		Frames = frames;
		WriteLine();
		PacketReceived = false;
	}

	private unsafe void WriteHeaders(TickRate.Resolved tickRate)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I
		//IL_0680: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_0147: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_01a1: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got Ref
		//IL_02be: Expected Obj, but got I8
		//IL_0263: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0321: Expected Obj, but got Ref
		//IL_039a: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_0337: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0423: Expected Obj, but got Ref
		//IL_0494: Expected Obj, but got I8
		//IL_0439: Expected I, but got Obj
		//IL_0449: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_04f7: Expected Obj, but got Ref
		//IL_0570: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_050d: Expected I, but got Obj
		//IL_051d: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAA78]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D42F8]");
		object format = 0;
		string folder = Folder;
		DirectoryInfo directoryInfo = Directory.CreateDirectory(folder);
		string folder2 = ((ClientTimeTrace)(object)directoryInfo).Folder;
		string file = File;
		string text = folder2 + (string)obj + file;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X24_v2+98]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v3+A0]");
		object contents = 0;
		System.IO.File.WriteAllText(text, (string)contents);
		string folder3 = ((ClientTimeTrace)(object)text).Folder;
		string file2 = File;
		string path = folder3 + (string)obj + file2;
		StreamWriter streamWriter = System.IO.File.AppendText(path);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RuntimePlatform platform = Application.platform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string text2 = string.Format((string)format, arg);
		nint num = (nint)streamWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj8 = 0;
		string stackTrace = ((Exception)(object)streamWriter).StackTrace;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool flag2 = text2 == null;
		object obj9 = 5;
		object[] array = default;
		IndexOutOfRangeException ex = default;
		object obj10;
		if (!flag2)
		{
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag3 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
			obj10 = 0;
			if (flag3)
			{
				goto IL_0641;
			}
		}
		if (array.Length != 0)
		{
			object obj11 = array + 32;
			obj11 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj12 = default;
			bool flag4 = obj12 == null;
			object obj13 = default;
			obj9 = (object)(&obj13);
			if (!flag4)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
				obj10 = 0;
				if (flag5)
				{
					goto IL_0641;
				}
			}
			object obj14 = array.Length & 0xFFFFFFFEL;
			if (obj14 != null)
			{
				object obj15 = array + 40;
				obj15 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj16 = default;
				bool flag6 = obj16 == null;
				object obj17 = default;
				obj9 = (object)(&obj17);
				if (!flag6)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag7 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
					obj10 = 0;
					if (flag7)
					{
						goto IL_0641;
					}
				}
				bool flag8 = array.Length < 2;
				object obj18 = !flag8;
				object obj19 = array.Length - 2;
				bool flag9 = obj19 == null;
				object obj20 = ~obj18;
				object obj21 = obj20 | flag9;
				if (obj21 == null)
				{
					object obj22 = array + 48;
					obj22 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj23 = default;
					bool flag10 = obj23 == null;
					object obj24 = default;
					obj9 = (object)(&obj24);
					if (!flag10)
					{
						nint num5 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag11 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
						obj10 = 0;
						if (flag11)
						{
							goto IL_0641;
						}
					}
					object obj25 = array.Length & 0xFFFFFFFCL;
					if (obj25 != null)
					{
						object obj26 = array + 56;
						obj26 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj27 = default;
						bool flag12 = obj27 == null;
						object obj28 = default;
						obj9 = (object)(&obj28);
						if (!flag12)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag13 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
							obj10 = 0;
							if (flag13)
							{
								goto IL_0641;
							}
						}
						bool flag14 = array.Length < 4;
						object obj29 = !flag14;
						object obj30 = array.Length - 4;
						bool flag15 = obj30 == null;
						object obj31 = ~obj29;
						object obj32 = obj31 | flag15;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAA80]");
							object format2 = 0;
							object obj33 = array + 64;
							obj33 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							FormattableString formattable = FormattableStringFactory.Create((string)format2, array);
							string text3 = FormattableString.Invariant(formattable);
							string stackTrace2 = ((Exception)(object)streamWriter).StackTrace;
							string stackTrace3 = ((Exception)(object)streamWriter).StackTrace;
							((object)streamWriter).Finalize();
							return;
						}
					}
				}
			}
		}
		ex = new IndexOutOfRangeException();
		obj10 = obj9;
		goto IL_0641;
		IL_0641:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
	}

	private unsafe void WriteLine()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0f5f: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0bf2: Expected Obj, but got Ref
		//IL_00af: Expected Obj, but got Ref
		//IL_0c08: Expected I, but got Obj
		//IL_0c18: Expected Obj, but got I
		//IL_0c41: Expected Obj, but got I
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Expected Obj, but got Unknown
		//IL_00c5: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_0cbe: Expected Obj, but got Ref
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0d2f: Expected Obj, but got I8
		//IL_017b: Expected Obj, but got Ref
		//IL_0cd4: Expected I, but got Obj
		//IL_0ce4: Expected Obj, but got I
		//IL_0d0d: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I8
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Expected Obj, but got Unknown
		//IL_0d96: Expected Obj, but got I4
		//IL_0191: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_0e02: Expected Obj, but got Ref
		//IL_0e7b: Expected Obj, but got I4
		//IL_0e8b: Expected Obj, but got I4
		//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got Ref
		//IL_0e18: Expected I, but got Obj
		//IL_0e28: Expected Obj, but got I
		//IL_0e51: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected Obj, but got Unknown
		//IL_0eee: Expected Obj, but got I
		//IL_02d5: Expected I, but got Obj
		//IL_02e5: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_03c1: Expected Obj, but got Ref
		//IL_0432: Expected Obj, but got I8
		//IL_03d7: Expected I, but got Obj
		//IL_03e7: Expected Obj, but got I
		//IL_0410: Expected Obj, but got I
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0495: Expected Obj, but got Ref
		//IL_050e: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_04ab: Expected I, but got Obj
		//IL_04bb: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got Ref
		//IL_061a: Expected Obj, but got I4
		//IL_062a: Expected Obj, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_05b7: Expected I, but got Obj
		//IL_05c7: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_06ad: Expected Obj, but got Ref
		//IL_0726: Expected Obj, but got I4
		//IL_0736: Expected Obj, but got I4
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_06c3: Expected I, but got Obj
		//IL_06d3: Expected Obj, but got I
		//IL_06fc: Expected Obj, but got I
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0799: Expected F8, but got I
		//IL_07bf: Expected Obj, but got Ref
		//IL_0830: Expected Obj, but got I8
		//IL_07d5: Expected I, but got Obj
		//IL_07e5: Expected Obj, but got I
		//IL_080e: Expected Obj, but got I
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected Obj, but got Unknown
		//IL_087d: Expected F8, but got I
		//IL_08a3: Expected Obj, but got Ref
		//IL_091c: Expected Obj, but got I4
		//IL_092c: Expected Obj, but got I4
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_08b9: Expected I, but got Obj
		//IL_08c9: Expected Obj, but got I
		//IL_08f2: Expected Obj, but got I
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected Obj, but got Unknown
		//IL_0989: Expected F8, but got VT
		//IL_09af: Expected Obj, but got Ref
		//IL_0a28: Expected Obj, but got I4
		//IL_0a38: Expected Obj, but got I4
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected Obj, but got Unknown
		//IL_09c5: Expected I, but got Obj
		//IL_09d5: Expected Obj, but got I
		//IL_09fe: Expected Obj, but got I
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected Obj, but got Unknown
		//IL_0a9b: Expected F8, but got I
		//IL_0ac1: Expected Obj, but got Ref
		//IL_0b3a: Expected Obj, but got I4
		//IL_0b4a: Expected Obj, but got I4
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected Obj, but got Unknown
		//IL_0ad7: Expected I, but got Obj
		//IL_0ae7: Expected Obj, but got I
		//IL_0b10: Expected Obj, but got I
		//IL_0b8d: Expected Obj, but got I
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC120]");
		object obj3 = 0;
		string folder = Folder;
		DirectoryInfo directoryInfo = Directory.CreateDirectory(folder);
		string folder2 = ((ClientTimeTrace)(object)directoryInfo).Folder;
		string file = File;
		string path = folder2 + (string)obj + file;
		StreamWriter streamWriter = System.IO.File.AppendText(path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj4 = 0;
		object obj6;
		object obj11 = default;
		object obj34 = default;
		int num9 = default;
		string format;
		object[] arguments;
		IndexOutOfRangeException ex = default;
		object obj8;
		if (~(PacketReceived ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj5 = default;
			bool flag = obj5 == null;
			object obj7 = default;
			obj6 = (object)(&obj7);
			object[] array = default;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
				obj8 = 0;
				if (flag2)
				{
					goto IL_0f30;
				}
			}
			if (array.Length != 0)
			{
				object obj9 = array + 32;
				obj9 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				double frameDeltaTime = FrameDeltaTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj10 = default;
				bool flag3 = obj10 == null;
				obj6 = (object)(&obj11);
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
					obj8 = 0;
					if (flag4)
					{
						goto IL_0f30;
					}
				}
				object obj12 = array.Length & 0xFFFFFFFEL;
				if (obj12 != null)
				{
					object obj13 = array + 40;
					obj13 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj14 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v69+E4]");
					bool flag5 = (nint)0 == 0;
					object obj15 = !flag5;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = !PacketReceived;
					bool value = !flag6;
					int num3 = Convert.ToInt32(value);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj16 = default;
					bool flag7 = obj16 == null;
					int num4 = default;
					obj6 = (object)(&num4);
					if (!flag7)
					{
						nint num5 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag8 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
						obj8 = 0;
						if (flag8)
						{
							goto IL_0f30;
						}
					}
					bool flag9 = array.Length < 2;
					object obj17 = !flag9;
					object obj18 = array.Length - 2;
					bool flag10 = obj18 == null;
					object obj19 = ~obj17;
					object obj20 = obj19 | flag10;
					if (obj20 == null)
					{
						object obj21 = array + 48;
						obj21 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj22 = default;
						bool flag11 = obj22 == null;
						object obj23 = default;
						obj6 = (object)(&obj23);
						if (!flag11)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v61 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag12 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v61 (Il2CppClass<System.Object[]>)+40]");
							obj8 = 0;
							if (flag12)
							{
								goto IL_0f30;
							}
						}
						object obj24 = array.Length & 0xFFFFFFFCL;
						if (obj24 != null)
						{
							object obj25 = array + 56;
							obj25 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj26 = default;
							bool flag13 = obj26 == null;
							object obj27 = default;
							obj6 = (object)(&obj27);
							if (!flag13)
							{
								nint num7 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag14 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
								obj8 = 0;
								if (flag14)
								{
									goto IL_0f30;
								}
							}
							bool flag15 = array.Length < 4;
							object obj28 = !flag15;
							object obj29 = array.Length - 4;
							bool flag16 = obj29 == null;
							object obj30 = ~obj28;
							object obj31 = obj30 | flag16;
							if (obj31 == null)
							{
								object obj32 = array + 64;
								obj32 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								frameDeltaTime = PacketDeltaTime;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj33 = default;
								bool flag17 = obj33 == null;
								obj6 = (object)(&obj34);
								if (!flag17)
								{
									nint num8 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
									obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag18 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
									obj8 = 0;
									if (flag18)
									{
										goto IL_0f30;
									}
								}
								bool flag19 = array.Length < 5;
								object obj35 = !flag19;
								object obj36 = array.Length - 5;
								bool flag20 = obj36 == null;
								object obj37 = ~obj35;
								object obj38 = obj37 | flag20;
								if (obj38 == null)
								{
									object obj39 = array + 72;
									obj39 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									frameDeltaTime = RoundTripTime;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj40 = default;
									bool flag21 = obj40 == null;
									obj6 = (object)(&num9);
									if (!flag21)
									{
										nint num10 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
										obj6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag22 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
										obj8 = 0;
										if (flag22)
										{
											goto IL_0f30;
										}
									}
									bool flag23 = array.Length < 6;
									object obj41 = !flag23;
									object obj42 = array.Length - 6;
									bool flag24 = obj42 == null;
									object obj43 = ~obj41;
									object obj44 = obj43 | flag24;
									if (obj44 == null)
									{
										object obj45 = array + 80;
										obj45 = obj40;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v1 (Fusion.ClientTimeTrace)+50]");
										frameDeltaTime = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										object obj46 = default;
										bool flag25 = obj46 == null;
										object obj47 = default;
										obj6 = (object)(&obj47);
										if (!flag25)
										{
											nint num11 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
											obj6 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag26 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
											obj8 = 0;
											if (flag26)
											{
												goto IL_0f30;
											}
										}
										object obj48 = array.Length & 0xFFFFFFF8L;
										if (obj48 != null)
										{
											object obj49 = array + 88;
											obj49 = obj46;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v1 (Fusion.ClientTimeTrace)+54]");
											frameDeltaTime = 0.0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj50 = default;
											bool flag27 = obj50 == null;
											object obj51 = default;
											obj6 = (object)(&obj51);
											if (!flag27)
											{
												nint num12 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
												obj6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag28 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
												obj8 = 0;
												if (flag28)
												{
													goto IL_0f30;
												}
											}
											bool flag29 = array.Length < 8;
											object obj52 = !flag29;
											object obj53 = array.Length - 8;
											bool flag30 = obj53 == null;
											object obj54 = ~obj52;
											object obj55 = obj54 | flag30;
											if (obj55 == null)
											{
												object obj56 = array + 96;
												obj56 = obj50;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												frameDeltaTime = (double)PacketFeedback;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												object obj57 = default;
												bool flag31 = obj57 == null;
												object obj58 = default;
												obj6 = (object)(&obj58);
												if (!flag31)
												{
													nint num13 = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
													obj6 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag32 = ex == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
													obj8 = 0;
													if (flag32)
													{
														goto IL_0f30;
													}
												}
												bool flag33 = array.Length < 9;
												object obj59 = !flag33;
												object obj60 = array.Length - 9;
												bool flag34 = obj60 == null;
												object obj61 = ~obj59;
												object obj62 = obj61 | flag34;
												if (obj62 == null)
												{
													object obj63 = array + 104;
													obj63 = obj57;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v1 (Fusion.ClientTimeTrace)+4C]");
													frameDeltaTime = 0.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													object obj64 = default;
													bool flag35 = obj64 == null;
													object obj65 = default;
													obj6 = (object)(&obj65);
													if (!flag35)
													{
														nint num14 = (nint)array;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
														obj6 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag36 = ex == null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
														obj8 = 0;
														if (flag36)
														{
															goto IL_0f30;
														}
													}
													bool flag37 = array.Length < 10;
													object obj66 = !flag37;
													object obj67 = array.Length - 10;
													bool flag38 = obj67 == null;
													object obj68 = ~obj66;
													object obj69 = obj68 | flag38;
													if (obj69 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAA0]");
														object obj70 = 0;
														object obj71 = array + 112;
														obj71 = obj64;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														format = (string)obj70;
														arguments = array;
														goto IL_0f88;
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
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj72 = default;
			bool flag39 = obj72 == null;
			obj6 = (object)(&obj34);
			object[] array2 = default;
			if (!flag39)
			{
				nint num15 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag40 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
				obj8 = 0;
				if (flag40)
				{
					goto IL_0f30;
				}
			}
			if (array2.Length != 0)
			{
				object obj73 = array2 + 32;
				obj73 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				double frameDeltaTime = FrameDeltaTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj74 = default;
				bool flag41 = obj74 == null;
				obj6 = (object)(&obj11);
				if (!flag41)
				{
					nint num16 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag42 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
					obj8 = 0;
					if (flag42)
					{
						goto IL_0f30;
					}
				}
				object obj75 = array2.Length & 0xFFFFFFFEL;
				if (obj75 != null)
				{
					object obj76 = array2 + 40;
					obj76 = obj74;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj77 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v38+E4]");
					bool flag43 = (nint)0 == 0;
					object obj78 = !flag43;
					if (obj78 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag44 = !PacketReceived;
					bool value2 = !flag44;
					int num17 = Convert.ToInt32(value2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj79 = default;
					bool flag45 = obj79 == null;
					obj6 = (object)(&num9);
					if (!flag45)
					{
						nint num18 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag46 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
						obj8 = 0;
						if (flag46)
						{
							goto IL_0f30;
						}
					}
					bool flag47 = array2.Length < 2;
					object obj80 = !flag47;
					object obj81 = array2.Length - 2;
					bool flag48 = obj81 == null;
					object obj82 = ~obj80;
					object obj83 = obj82 | flag48;
					if (obj83 == null)
					{
						object obj84 = array2 + 48;
						obj84 = obj79;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAA98]");
						object obj85 = 0;
						format = (string)obj85;
						arguments = array2;
						goto IL_0f88;
					}
				}
			}
		}
		ex = new IndexOutOfRangeException();
		obj8 = obj6;
		goto IL_0f30;
		IL_0f88:
		FormattableString formattable = FormattableStringFactory.Create(format, arguments);
		string text = FormattableString.Invariant(formattable);
		string stackTrace = ((Exception)(object)streamWriter).StackTrace;
		((object)streamWriter).Finalize();
		return;
		IL_0f30:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
	}

	public unsafe static void Replay(TimeSyncConfiguration tsc, string inPath, string outPath)
	{
		//IL_7a82: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0057: Expected VT, but got I4
		//IL_0060: Expected VT, but got I4
		//IL_0069: Expected VT, but got I4
		//IL_0082: Expected I4, but got Obj
		//IL_00a8: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_78b8: Expected I4, but got Obj
		//IL_7b33: Expected Obj, but got I
		//IL_7b77: Expected VT, but got I4
		//IL_7b80: Expected VT, but got I4
		//IL_7b89: Expected VT, but got I4
		//IL_7b9a: Expected I4, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_7ae8: Expected Obj, but got I
		//IL_78fd: Expected I4, but got Obj
		//IL_0199: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_7c1a: Expected VT, but got I4
		//IL_7c23: Expected VT, but got I4
		//IL_7c2c: Expected VT, but got I4
		//IL_01f4: Expected Obj, but got I
		//IL_7bc8: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02da: Expected VT, but got I4
		//IL_02e3: Expected VT, but got I4
		//IL_02fc: Expected VT, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_87e6: Expected Obj, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_79c3: Expected I4, but got Obj
		//IL_7982: Expected F4, but got I4
		//IL_0350: Expected Obj, but got I
		//IL_79e1: Expected Obj, but got I4
		//IL_273b: Expected F4, but got I4
		//IL_274c: Expected F4, but got Ref
		//IL_2775: Expected Obj, but got I4
		//IL_7c52: Expected Obj, but got I
		//IL_8765: Expected Obj, but got F4
		//IL_876e: Invalid comparison between F4 and I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_7f31: Expected Obj, but got I4
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_27aa: Expected Obj, but got I
		//IL_27ba: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_2883: Invalid comparison between F4 and I4
		//IL_2894: Expected Obj, but got I4
		//IL_5682: Expected I4, but got Obj
		//IL_27f5: Expected Obj, but got I
		//IL_7d82: Expected I4, but got Obj
		//IL_044e: Expected Obj, but got I
		//IL_7f57: Expected Obj, but got I
		//IL_7d2d: Expected Obj, but got I
		//IL_291f: Expected Obj, but got I
		//IL_292f: Expected Obj, but got I
		//IL_2868: Unknown result type (might be due to invalid IL or missing references)
		//IL_286d: Expected Obj, but got Unknown
		//IL_5709: Expected F4, but got I4
		//IL_571a: Expected F4, but got Ref
		//IL_573a: Expected I4, but got Obj
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_2973: Expected I4, but got Obj
		//IL_28e1: Expected Obj, but got I4
		//IL_2803: Unknown result type (might be due to invalid IL or missing references)
		//IL_2808: Expected Obj, but got Unknown
		//IL_2811: Unknown result type (might be due to invalid IL or missing references)
		//IL_2816: Expected Obj, but got Unknown
		//IL_1ddc: Expected F4, but got I4
		//IL_1ded: Expected F4, but got Ref
		//IL_1df2: Expected I, but got Obj
		//IL_1e20: Expected I4, but got Obj
		//IL_1e30: Expected I4, but got Obj
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_29ac: Expected Obj, but got I
		//IL_57b7: Expected I4, but got Obj
		//IL_1e56: Expected Obj, but got I4
		//IL_1e9d: Expected F4, but got I4
		//IL_1eae: Expected F4, but got Ref
		//IL_1eb3: Expected I, but got Obj
		//IL_1890: Expected F4, but got I4
		//IL_18a1: Expected F4, but got Ref
		//IL_18a6: Expected I, but got Obj
		//IL_18d4: Expected I4, but got Obj
		//IL_6dcb: Expected I4, but got Obj
		//IL_6c55: Expected I4, but got Obj
		//IL_0593: Expected I, but got Obj
		//IL_1f21: Expected F4, but got I4
		//IL_1f32: Expected F4, but got Ref
		//IL_1f37: Expected I, but got Obj
		//IL_1f66: Expected I4, but got Obj
		//IL_1902: Expected Obj, but got I4
		//IL_1932: Expected Obj, but got I8
		//IL_195b: Expected F4, but got I4
		//IL_196c: Expected F4, but got Ref
		//IL_1971: Expected I, but got Obj
		//IL_2a02: Expected Obj, but got I
		//IL_2a12: Expected Obj, but got I
		//IL_582c: Expected I4, but got Obj
		//IL_6c74: Expected I4, but got Obj
		//IL_6c7c: Expected I4, but got Obj
		//IL_6b0e: Expected I4, but got Obj
		//IL_6887: Expected I4, but got Obj
		//IL_6be8: Expected I4, but got Obj
		//IL_05e8: Expected F4, but got I4
		//IL_05f9: Expected F4, but got Ref
		//IL_05fe: Expected I, but got Obj
		//IL_062c: Expected I4, but got Obj
		//IL_6e38: Expected I4, but got Obj
		//IL_6cca: Expected I4, but got Obj
		//IL_1fa3: Expected Obj, but got I
		//IL_19bc: Expected Obj, but got I
		//IL_19f8: Expected Obj, but got I4
		//IL_2a4d: Expected Obj, but got I
		//IL_6b2d: Expected I4, but got Obj
		//IL_1fc9: Expected Obj, but got I
		//IL_1fea: Expected Obj, but got I8
		//IL_2013: Expected F4, but got I4
		//IL_2024: Expected F4, but got Ref
		//IL_2029: Expected I, but got Obj
		//IL_204e: Expected I4, but got Obj
		//IL_205e: Expected I4, but got Obj
		//IL_6c07: Expected I4, but got Obj
		//IL_0652: Expected Obj, but got I4
		//IL_0671: Expected Obj, but got I
		//IL_06b1: Expected F4, but got I4
		//IL_06c2: Expected F4, but got Ref
		//IL_06c7: Expected I, but got Obj
		//IL_7faa: Expected Obj, but got I
		//IL_58a1: Expected F4, but got VT
		//IL_58a9: Expected I4, but got Obj
		//IL_6ce9: Expected I4, but got Obj
		//IL_6cf1: Expected I4, but got Obj
		//IL_6b7b: Expected I4, but got Obj
		//IL_68f4: Expected I4, but got Obj
		//IL_1a50: Expected Obj, but got I4
		//IL_1a60: Expected Obj, but got I4
		//IL_1a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a85: Expected Obj, but got Unknown
		//IL_1a9f: Expected F4, but got I4
		//IL_1ab0: Expected F4, but got Ref
		//IL_1ab5: Expected I, but got Obj
		//IL_1ada: Expected I4, but got Obj
		//IL_6f87: Expected I4, but got Obj
		//IL_2ae2: Expected Obj, but got I
		//IL_2af2: Expected Obj, but got I
		//IL_2b7b: Expected Obj, but got I4
		//IL_2ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab7: Expected Obj, but got Unknown
		//IL_2ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac5: Expected Obj, but got Unknown
		//IL_58ef: Expected VT, but got F4
		//IL_6ea5: Expected I4, but got Obj
		//IL_6ead: Expected Obj, but got I4
		//IL_209f: Expected F4, but got I4
		//IL_20b0: Expected F4, but got Ref
		//IL_20b5: Expected I, but got Obj
		//IL_20da: Expected I4, but got Obj
		//IL_20ec: Expected I4, but got Obj
		//IL_0735: Expected F4, but got I4
		//IL_0746: Expected F4, but got Ref
		//IL_074b: Expected I, but got Obj
		//IL_0770: Expected I4, but got Obj
		//IL_0782: Expected I4, but got Obj
		//IL_86b5: Expected Obj, but got I
		//IL_2a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a60: Expected Obj, but got Unknown
		//IL_2a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a6e: Expected Obj, but got Unknown
		//IL_6b9a: Expected I4, but got Obj
		//IL_591e: Expected I4, but got Obj
		//IL_6d5e: Expected I4, but got Obj
		//IL_2129: Expected Obj, but got I
		//IL_6961: Expected Obj, but got I4
		//IL_6969: Expected I4, but got Obj
		//IL_1b35: Expected Obj, but got I8
		//IL_1b5e: Expected F4, but got I4
		//IL_1b6f: Expected F4, but got Ref
		//IL_1b74: Expected I, but got Obj
		//IL_1b99: Expected I4, but got Obj
		//IL_6ff4: Expected I4, but got Obj
		//IL_07bf: Expected Obj, but got I
		//IL_2bb6: Expected Obj, but got I
		//IL_5964: Expected VT, but got F4
		//IL_6f1a: Expected I4, but got Obj
		//IL_7061: Expected Obj, but got I4
		//IL_7069: Expected I4, but got Obj
		//IL_214f: Expected Obj, but got I
		//IL_2180: Expected Obj, but got I4
		//IL_2190: Expected Obj, but got I4
		//IL_21b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b5: Expected Obj, but got Unknown
		//IL_21cf: Expected F4, but got I4
		//IL_21e0: Expected F4, but got Ref
		//IL_21e5: Expected I, but got Obj
		//IL_220a: Expected I4, but got Obj
		//IL_221a: Expected I4, but got Obj
		//IL_07e5: Expected Obj, but got I
		//IL_080e: Expected Obj, but got I8
		//IL_0837: Expected F4, but got I4
		//IL_0848: Expected F4, but got Ref
		//IL_084d: Expected I, but got Obj
		//IL_0872: Expected I4, but got Obj
		//IL_8792: Expected VT, but got Ref
		//IL_879f: Expected Obj, but got I4
		//IL_8019: Expected Obj, but got I
		//IL_70b7: Expected I4, but got Obj
		//IL_86f4: Expected VT, but got Ref
		//IL_2ce0: Expected VT, but got Ref
		//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c20: Expected Obj, but got Unknown
		//IL_2c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2e: Expected Obj, but got Unknown
		//IL_5993: Expected I4, but got Obj
		//IL_225b: Expected F4, but got I4
		//IL_226c: Expected F4, but got Ref
		//IL_2271: Expected I, but got Obj
		//IL_22a0: Expected I4, but got Obj
		//IL_69d6: Expected Obj, but got I4
		//IL_69de: Expected I4, but got Obj
		//IL_1c16: Expected Obj, but got I4
		//IL_1c26: Expected Obj, but got I4
		//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4b: Expected Obj, but got Unknown
		//IL_1c65: Expected F4, but got I4
		//IL_1c76: Expected F4, but got Ref
		//IL_1c7b: Expected I, but got Obj
		//IL_1cb8: Expected Obj, but got I4
		//IL_08bb: Expected F4, but got I4
		//IL_08cc: Expected F4, but got Ref
		//IL_08d1: Expected I, but got Obj
		//IL_0900: Expected I4, but got Obj
		//IL_559a: Expected VT, but got Ref
		//IL_54a0: Expected I, but got Obj
		//IL_54b0: Expected Obj, but got I
		//IL_54c0: Expected Obj, but got I
		//IL_2bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc9: Expected Obj, but got Unknown
		//IL_2bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd7: Expected Obj, but got Unknown
		//IL_59d9: Expected VT, but got F4
		//IL_70d6: Expected I4, but got Obj
		//IL_6aa1: Expected I4, but got Obj
		//IL_6a2c: Expected I4, but got Obj
		//IL_7124: Expected I4, but got Obj
		//IL_2d23: Expected Obj, but got I
		//IL_2d33: Expected Obj, but got I
		//IL_22dd: Expected Obj, but got I
		//IL_093d: Expected Obj, but got I
		//IL_54fb: Expected Obj, but got I
		//IL_5a08: Expected I4, but got Obj
		//IL_6ac0: Expected I4, but got Obj
		//IL_2303: Expected Obj, but got I
		//IL_232c: Expected Obj, but got I8
		//IL_2355: Expected F4, but got I4
		//IL_2366: Expected F4, but got Ref
		//IL_236b: Expected I, but got Obj
		//IL_2398: Expected I4, but got Obj
		//IL_6a4b: Expected I4, but got Obj
		//IL_6a53: Expected I4, but got Obj
		//IL_1d10: Expected I, but got Obj
		//IL_1d20: Expected Obj, but got I
		//IL_7143: Expected I4, but got Obj
		//IL_0963: Expected Obj, but got I
		//IL_0994: Expected Obj, but got I4
		//IL_09a4: Expected Obj, but got I4
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected Obj, but got Unknown
		//IL_09e3: Expected F4, but got I4
		//IL_09f4: Expected F4, but got Ref
		//IL_09f9: Expected I, but got Obj
		//IL_871a: Expected Obj, but got I
		//IL_81fb: Expected VT, but got Ref
		//IL_821b: Expected I4, but got Obj
		//IL_2d6e: Expected Obj, but got I
		//IL_5a4e: Expected VT, but got F4
		//IL_7191: Expected I4, but got Obj
		//IL_6786: Expected I4, but got Obj
		//IL_5560: Unknown result type (might be due to invalid IL or missing references)
		//IL_5565: Expected Obj, but got Unknown
		//IL_556e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5573: Expected Obj, but got Unknown
		//IL_811c: Expected Obj, but got I
		//IL_23d9: Expected F4, but got I4
		//IL_23ea: Expected F4, but got Ref
		//IL_23ef: Expected I, but got Obj
		//IL_2414: Expected I4, but got Obj
		//IL_2426: Expected I4, but got Obj
		//IL_7e96: Expected Obj, but got I
		//IL_7ea9: Expected F4, but got I4
		//IL_7eba: Expected Obj, but got I4
		//IL_7ec3: Expected F4, but got I4
		//IL_7ecc: Expected Obj, but got I4
		//IL_7ed5: Expected VT, but got I4
		//IL_7f0e: Expected Obj, but got Ref
		//IL_1d5b: Expected Obj, but got I
		//IL_0a5f: Expected F4, but got I4
		//IL_0a70: Expected F4, but got Ref
		//IL_0a78: Expected Obj, but got I4
		//IL_0a7d: Expected I, but got Obj
		//IL_0aa2: Expected I4, but got Obj
		//IL_0ab4: Expected I4, but got Obj
		//IL_5509: Unknown result type (might be due to invalid IL or missing references)
		//IL_550e: Expected Obj, but got Unknown
		//IL_5517: Unknown result type (might be due to invalid IL or missing references)
		//IL_551c: Expected Obj, but got Unknown
		//IL_2eab: Expected VT, but got Ref
		//IL_2eb3: Expected F4, but got VT
		//IL_2ec0: Expected I, but got Obj
		//IL_2ee6: Expected I4, but got Obj
		//IL_2dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd8: Expected Obj, but got Unknown
		//IL_2de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de6: Expected Obj, but got Unknown
		//IL_5a7d: Expected I4, but got Obj
		//IL_7d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d9e: Expected Obj, but got Unknown
		//IL_7db4: Expected Obj, but got I4
		//IL_7dcc: Expected I4, but got Obj
		//IL_7e44: Expected Obj, but got I4
		//IL_7e62: Expected Obj, but got I
		//IL_71b0: Expected I4, but got Obj
		//IL_67a5: Expected I4, but got Obj
		//IL_67ad: Expected I4, but got Obj
		//IL_2d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d81: Expected Obj, but got Unknown
		//IL_2d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8f: Expected Obj, but got Unknown
		//IL_5ac3: Expected VT, but got F4
		//IL_2463: Expected Obj, but got I
		//IL_26b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b7: Expected Obj, but got Unknown
		//IL_26bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c4: Expected Obj, but got Unknown
		//IL_26cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d2: Expected Obj, but got Unknown
		//IL_71fe: Expected I4, but got Obj
		//IL_0af1: Expected Obj, but got I
		//IL_2f08: Expected Obj, but got I8
		//IL_2fa9: Expected VT, but got Ref
		//IL_2fb6: Expected I, but got Obj
		//IL_2fdc: Expected I4, but got Obj
		//IL_2489: Expected Obj, but got I
		//IL_24ba: Expected Obj, but got I4
		//IL_24ca: Expected Obj, but got I4
		//IL_24ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ef: Expected Obj, but got Unknown
		//IL_2509: Expected F4, but got I4
		//IL_251a: Expected F4, but got Ref
		//IL_251f: Expected I, but got Obj
		//IL_1d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6e: Expected Obj, but got Unknown
		//IL_1d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7c: Expected Obj, but got Unknown
		//IL_0b17: Expected Obj, but got I
		//IL_0b40: Expected Obj, but got I8
		//IL_0b69: Expected F4, but got I4
		//IL_0b7a: Expected F4, but got Ref
		//IL_0b7f: Expected I, but got Obj
		//IL_0ba4: Expected I4, but got Obj
		//IL_5af2: Expected I4, but got Obj
		//IL_75d3: Expected I4, but got Obj
		//IL_721d: Expected I4, but got Obj
		//IL_681a: Expected I4, but got Obj
		//IL_3014: Expected Obj, but got I4
		//IL_5b38: Expected VT, but got F4
		//IL_2585: Expected F4, but got I4
		//IL_2596: Expected F4, but got Ref
		//IL_259b: Expected I, but got Obj
		//IL_25ca: Expected I4, but got Obj
		//IL_726b: Expected I4, but got Obj
		//IL_0bed: Expected F4, but got I4
		//IL_0bfe: Expected F4, but got Ref
		//IL_0c03: Expected I, but got Obj
		//IL_0c32: Expected I4, but got Obj
		//IL_75f2: Expected I4, but got Obj
		//IL_7345: Expected I4, but got Obj
		//IL_3076: Expected Obj, but got I4
		//IL_3086: Expected Obj, but got I4
		//IL_30a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ab: Expected Obj, but got Unknown
		//IL_313d: Expected VT, but got Ref
		//IL_314a: Expected I, but got Obj
		//IL_3167: Expected I4, but got Obj
		//IL_3179: Expected I4, but got Obj
		//IL_5b67: Expected I4, but got Obj
		//IL_7640: Expected I4, but got Obj
		//IL_2607: Expected Obj, but got I
		//IL_728a: Expected I4, but got Obj
		//IL_0c6f: Expected Obj, but got I
		//IL_5bad: Expected VT, but got F4
		//IL_7364: Expected I4, but got Obj
		//IL_262d: Expected Obj, but got I
		//IL_2697: Expected I, but got Obj
		//IL_26a4: Expected I4, but got Obj
		//IL_72d8: Expected I4, but got Obj
		//IL_0c95: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I4
		//IL_0cd6: Expected Obj, but got I4
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Expected Obj, but got Unknown
		//IL_0d15: Expected F4, but got I4
		//IL_0d26: Expected F4, but got Ref
		//IL_0d2b: Expected I, but got Obj
		//IL_765f: Expected I4, but got Obj
		//IL_73b2: Expected I4, but got Obj
		//IL_5bdc: Expected I4, but got Obj
		//IL_76ad: Expected I4, but got Obj
		//IL_72f7: Expected I4, but got Obj
		//IL_0d91: Expected F4, but got I4
		//IL_0da2: Expected F4, but got Ref
		//IL_0da7: Expected I, but got Obj
		//IL_0dd6: Expected I4, but got Obj
		//IL_3906: Expected Obj, but got I
		//IL_392b: Expected I, but got Obj
		//IL_3934: Expected VT, but got I4
		//IL_5c22: Expected VT, but got F4
		//IL_73d1: Expected I4, but got Obj
		//IL_82d2: Expected I, but got Obj
		//IL_82e2: Expected Obj, but got I
		//IL_31e9: Expected Obj, but got I4
		//IL_31f9: Expected Obj, but got I4
		//IL_3219: Unknown result type (might be due to invalid IL or missing references)
		//IL_321e: Expected Obj, but got Unknown
		//IL_3240: Expected VT, but got Ref
		//IL_3245: Expected I, but got Obj
		//IL_76cc: Expected I4, but got Obj
		//IL_741f: Expected I4, but got Obj
		//IL_0e13: Expected Obj, but got I
		//IL_3b77: Expected VT, but got I4
		//IL_5f80: Expected VT, but got F4
		//IL_5f88: Expected I4, but got Obj
		//IL_5c51: Expected I4, but got Obj
		//IL_771a: Expected I4, but got Obj
		//IL_0e39: Expected Obj, but got I
		//IL_0e6a: Expected Obj, but got I4
		//IL_0e7a: Expected Obj, but got I4
		//IL_0e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9f: Expected Obj, but got Unknown
		//IL_0eb9: Expected F4, but got I4
		//IL_0eca: Expected F4, but got Ref
		//IL_0ecf: Expected I, but got Obj
		//IL_847c: Expected Obj, but got I
		//IL_8485: Unknown result type (might be due to invalid IL or missing references)
		//IL_848a: Expected I4, but got Unknown
		//IL_849f: Expected I, but got Obj
		//IL_84af: Expected Obj, but got I
		//IL_3b1b: Expected Obj, but got I
		//IL_3292: Expected Obj, but got I4
		//IL_5c97: Expected VT, but got F4
		//IL_743e: Expected I4, but got Obj
		//IL_3c16: Expected Obj, but got I4
		//IL_843e: Expected Obj, but got I
		//IL_5faf: Expected I4, but got Obj
		//IL_7739: Expected I4, but got Obj
		//IL_748c: Expected I4, but got Obj
		//IL_0f35: Expected F4, but got I4
		//IL_0f46: Expected F4, but got Ref
		//IL_0f4b: Expected I, but got Obj
		//IL_0f7a: Expected I4, but got Obj
		//IL_851a: Expected I, but got Obj
		//IL_852a: Expected Obj, but got I
		//IL_3bba: Expected Obj, but got I
		//IL_3b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b89: Expected Obj, but got Unknown
		//IL_3b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b97: Expected Obj, but got Unknown
		//IL_5ffd: Expected VT, but got F4
		//IL_6005: Expected I4, but got Obj
		//IL_32f4: Expected Obj, but got I4
		//IL_3304: Expected Obj, but got I4
		//IL_3324: Unknown result type (might be due to invalid IL or missing references)
		//IL_3329: Expected Obj, but got Unknown
		//IL_334b: Expected VT, but got Ref
		//IL_3350: Expected I, but got Obj
		//IL_5cc6: Expected I4, but got Obj
		//IL_7787: Expected I4, but got Obj
		//IL_3cc8: Expected Obj, but got I4
		//IL_84e4: Expected Obj, but got I
		//IL_3b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b2e: Expected Obj, but got Unknown
		//IL_3b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3c: Expected Obj, but got Unknown
		//IL_5f0b: Expected VT, but got F4
		//IL_5f13: Expected I4, but got Obj
		//IL_5d0c: Expected VT, but got F4
		//IL_74ab: Expected I4, but got Obj
		//IL_0fb7: Expected Obj, but got I
		//IL_859d: Expected Obj, but got I
		//IL_8652: Expected VT, but got Ref
		//IL_867a: Expected Obj, but got F4
		//IL_3c6c: Expected Obj, but got I
		//IL_3c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c29: Expected Obj, but got Unknown
		//IL_3c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c36: Expected Obj, but got Unknown
		//IL_3c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c44: Expected Obj, but got Unknown
		//IL_6024: Expected I4, but got Obj
		//IL_77a6: Expected I4, but got Obj
		//IL_77ae: Expected I4, but got Obj
		//IL_74f9: Expected I4, but got Obj
		//IL_0fdd: Expected Obj, but got I
		//IL_100e: Expected Obj, but got I4
		//IL_101e: Expected Obj, but got I4
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1043: Expected Obj, but got Unknown
		//IL_105d: Expected F4, but got I4
		//IL_106e: Expected F4, but got Ref
		//IL_1073: Expected I, but got Obj
		//IL_855f: Expected Obj, but got I
		//IL_3bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bcd: Expected Obj, but got Unknown
		//IL_3bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bdb: Expected Obj, but got Unknown
		//IL_6072: Expected VT, but got F4
		//IL_607a: Expected I4, but got Obj
		//IL_5f32: Expected I4, but got Obj
		//IL_33ca: Expected Obj, but got I4
		//IL_33da: Expected Obj, but got I4
		//IL_33fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_33ff: Expected Obj, but got Unknown
		//IL_3421: Expected VT, but got Ref
		//IL_342e: Expected I, but got Obj
		//IL_344d: Expected I4, but got Obj
		//IL_5d3b: Expected I4, but got Obj
		//IL_3cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cdb: Expected Obj, but got Unknown
		//IL_3ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ce8: Expected Obj, but got Unknown
		//IL_3cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cf6: Expected Obj, but got Unknown
		//IL_5d81: Expected VT, but got F4
		//IL_7518: Expected I4, but got Obj
		//IL_10d9: Expected F4, but got I4
		//IL_10ea: Expected F4, but got Ref
		//IL_10ef: Expected I, but got Obj
		//IL_111e: Expected I4, but got Obj
		//IL_3e8c: Expected VT, but got Ref
		//IL_3eb4: Expected Obj, but got F4
		//IL_3c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c7f: Expected Obj, but got Unknown
		//IL_3c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c8d: Expected Obj, but got Unknown
		//IL_6099: Expected I4, but got Obj
		//IL_7873: Expected I4, but got Obj
		//IL_7566: Expected I4, but got Obj
		//IL_3d34: Expected I, but got Obj
		//IL_3db3: Expected VT, but got Ref
		//IL_3dc3: Expected Obj, but got F4
		//IL_3ddb: Expected Obj, but got I4
		//IL_60e7: Expected VT, but got F4
		//IL_60ef: Expected I4, but got Obj
		//IL_34aa: Expected Obj, but got I8
		//IL_34e3: Expected VT, but got Ref
		//IL_34f0: Expected I, but got Obj
		//IL_350f: Expected I4, but got Obj
		//IL_5db0: Expected Obj, but got I4
		//IL_5db8: Expected I4, but got Obj
		//IL_115b: Expected Obj, but got I
		//IL_3ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ed0: Expected Obj, but got Unknown
		//IL_3ed8: Expected Obj, but got I4
		//IL_6356: Expected VT, but got F4
		//IL_5dfe: Expected VT, but got F4
		//IL_5e0e: Expected I4, but got Obj
		//IL_7585: Expected I4, but got Obj
		//IL_1181: Expected Obj, but got I
		//IL_11aa: Expected Obj, but got I8
		//IL_11d3: Expected F4, but got I4
		//IL_11e4: Expected F4, but got Ref
		//IL_11e9: Expected I, but got Obj
		//IL_3ff3: Expected Obj, but got I8
		//IL_409c: Expected VT, but got Ref
		//IL_40c4: Expected Obj, but got F4
		//IL_638a: Expected I4, but got Obj
		//IL_615e: Expected VT, but got F4
		//IL_6166: Expected I4, but got Obj
		//IL_3574: Expected Obj, but got I4
		//IL_3584: Expected Obj, but got I4
		//IL_35a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_35a9: Expected Obj, but got Unknown
		//IL_35db: Expected VT, but got Ref
		//IL_35e0: Expected I, but got Obj
		//IL_35ff: Expected I4, but got Obj
		//IL_5ebd: Expected I4, but got Obj
		//IL_124f: Expected F4, but got I4
		//IL_1260: Expected F4, but got Ref
		//IL_1265: Expected I, but got Obj
		//IL_1294: Expected I4, but got Obj
		//IL_3f22: Expected I, but got Obj
		//IL_3fa9: Expected VT, but got Ref
		//IL_3fb9: Expected Obj, but got F4
		//IL_3fd1: Expected Obj, but got I4
		//IL_63d8: Expected VT, but got F4
		//IL_63e8: Expected I4, but got Obj
		//IL_40db: Unknown result type (might be due to invalid IL or missing references)
		//IL_40e0: Expected Obj, but got Unknown
		//IL_40e8: Expected Obj, but got I4
		//IL_64df: Expected VT, but got F4
		//IL_12d1: Expected Obj, but got I
		//IL_61de: Expected VT, but got F4
		//IL_3664: Expected Obj, but got I4
		//IL_3674: Expected Obj, but got I4
		//IL_3694: Unknown result type (might be due to invalid IL or missing references)
		//IL_3699: Expected Obj, but got Unknown
		//IL_36d3: Expected VT, but got Ref
		//IL_36d8: Expected I, but got Obj
		//IL_36f7: Expected I4, but got Obj
		//IL_12f7: Expected Obj, but got I
		//IL_1328: Expected Obj, but got I4
		//IL_1338: Expected Obj, but got I4
		//IL_1358: Unknown result type (might be due to invalid IL or missing references)
		//IL_135d: Expected Obj, but got Unknown
		//IL_1377: Expected F4, but got I4
		//IL_1388: Expected F4, but got Ref
		//IL_138d: Expected I, but got Obj
		//IL_13b2: Expected I4, but got Obj
		//IL_421f: Expected Obj, but got I4
		//IL_422f: Expected Obj, but got I4
		//IL_424f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4254: Expected Obj, but got Unknown
		//IL_42f6: Expected VT, but got Ref
		//IL_431e: Expected Obj, but got F4
		//IL_6457: Expected VT, but got F4
		//IL_6467: Expected I4, but got Obj
		//IL_6689: Expected VT, but got F4
		//IL_6691: Expected I4, but got Obj
		//IL_4132: Expected I, but got Obj
		//IL_4142: Expected Obj, but got I
		//IL_4173: Expected I4, but got Obj
		//IL_41dd: Expected VT, but got Ref
		//IL_41f5: Expected Obj, but got F4
		//IL_6567: Expected VT, but got F4
		//IL_13fb: Expected F4, but got I4
		//IL_140c: Expected F4, but got Ref
		//IL_1411: Expected I, but got Obj
		//IL_1440: Expected I4, but got Obj
		//IL_4335: Unknown result type (might be due to invalid IL or missing references)
		//IL_433a: Expected Obj, but got Unknown
		//IL_4342: Expected Obj, but got I4
		//IL_6256: Expected VT, but got F4
		//IL_6710: Expected VT, but got F4
		//IL_6738: Expected I4, but got Obj
		//IL_375c: Expected Obj, but got I4
		//IL_376c: Expected Obj, but got I4
		//IL_378c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3791: Expected Obj, but got Unknown
		//IL_37d3: Expected VT, but got Ref
		//IL_37d8: Expected I, but got Obj
		//IL_37f7: Expected I4, but got Obj
		//IL_147d: Expected Obj, but got I
		//IL_4479: Expected Obj, but got I8
		//IL_4532: Expected VT, but got Ref
		//IL_455a: Expected Obj, but got F4
		//IL_65e7: Expected VT, but got F4
		//IL_14a3: Expected Obj, but got I
		//IL_14d4: Expected Obj, but got I4
		//IL_14e4: Expected Obj, but got I4
		//IL_1504: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Expected Obj, but got Unknown
		//IL_1523: Expected F4, but got I4
		//IL_1534: Expected F4, but got Ref
		//IL_1539: Expected I, but got Obj
		//IL_438c: Expected I, but got Obj
		//IL_43bd: Expected I4, but got Obj
		//IL_442f: Expected VT, but got Ref
		//IL_4447: Expected Obj, but got F4
		//IL_62ce: Expected VT, but got F4
		//IL_3844: Expected I, but got Obj
		//IL_3854: Expected Obj, but got I
		//IL_4571: Unknown result type (might be due to invalid IL or missing references)
		//IL_4576: Expected Obj, but got Unknown
		//IL_457e: Expected Obj, but got I4
		//IL_663b: Expected I4, but got Obj
		//IL_159f: Expected F4, but got I4
		//IL_15b0: Expected F4, but got Ref
		//IL_15b5: Expected I, but got Obj
		//IL_15e4: Expected I4, but got Obj
		//IL_8295: Expected I, but got Obj
		//IL_82a5: Expected Obj, but got I
		//IL_388f: Expected Obj, but got I
		//IL_46bd: Expected Obj, but got I4
		//IL_46cd: Expected Obj, but got I4
		//IL_46ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f2: Expected Obj, but got Unknown
		//IL_47a4: Expected VT, but got Ref
		//IL_47cc: Expected Obj, but got F4
		//IL_39e1: Expected VT, but got I4
		//IL_8239: Expected Obj, but got I
		//IL_1621: Expected Obj, but got I
		//IL_45c8: Expected I, but got Obj
		//IL_45f9: Expected I4, but got Obj
		//IL_4673: Expected VT, but got Ref
		//IL_4683: Expected Obj, but got F4
		//IL_835f: Expected Obj, but got I4
		//IL_838a: Expected I, but got Obj
		//IL_8392: Expected Obj, but got VT
		//IL_3985: Expected Obj, but got I
		//IL_3942: Unknown result type (might be due to invalid IL or missing references)
		//IL_3947: Expected Obj, but got Unknown
		//IL_394f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3954: Expected Obj, but got Unknown
		//IL_395d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3962: Expected Obj, but got Unknown
		//IL_1647: Expected Obj, but got I
		//IL_1678: Expected Obj, but got I4
		//IL_1688: Expected Obj, but got I4
		//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected Obj, but got Unknown
		//IL_16c7: Expected F4, but got I4
		//IL_16d8: Expected F4, but got Ref
		//IL_16dd: Expected I, but got Obj
		//IL_47e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_47e8: Expected Obj, but got Unknown
		//IL_47f0: Expected Obj, but got I4
		//IL_8317: Expected Obj, but got I
		//IL_389d: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a2: Expected Obj, but got Unknown
		//IL_38ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b0: Expected Obj, but got Unknown
		//IL_3a2c: Expected I, but got Obj
		//IL_3a3c: Expected Obj, but got I
		//IL_39ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f4: Expected Obj, but got Unknown
		//IL_39fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a01: Expected Obj, but got Unknown
		//IL_3a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a0f: Expected Obj, but got Unknown
		//IL_1743: Expected F4, but got I4
		//IL_1754: Expected F4, but got Ref
		//IL_1759: Expected I, but got Obj
		//IL_1788: Expected I4, but got Obj
		//IL_493f: Expected Obj, but got I4
		//IL_494f: Expected Obj, but got I4
		//IL_496f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4974: Expected Obj, but got Unknown
		//IL_4a2e: Expected VT, but got Ref
		//IL_4a56: Expected Obj, but got F4
		//IL_3993: Unknown result type (might be due to invalid IL or missing references)
		//IL_3998: Expected Obj, but got Unknown
		//IL_39a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a6: Expected Obj, but got Unknown
		//IL_483a: Expected I, but got Obj
		//IL_486b: Expected I4, but got Obj
		//IL_48ed: Expected VT, but got Ref
		//IL_4905: Expected Obj, but got F4
		//IL_83e4: Expected VT, but got I
		//IL_8421: Expected I, but got Obj
		//IL_8429: Expected Obj, but got VT
		//IL_3a77: Expected Obj, but got I
		//IL_17c5: Expected Obj, but got I
		//IL_4a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a72: Expected Obj, but got Unknown
		//IL_4a7a: Expected Obj, but got I4
		//IL_83b0: Expected Obj, but got I
		//IL_17eb: Expected Obj, but got I
		//IL_1855: Expected I, but got Obj
		//IL_1862: Expected I4, but got Obj
		//IL_3ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3add: Expected Obj, but got Unknown
		//IL_3ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aea: Expected Obj, but got Unknown
		//IL_3af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af8: Expected Obj, but got Unknown
		//IL_4bd1: Expected Obj, but got I4
		//IL_4be1: Expected Obj, but got I4
		//IL_4c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c06: Expected Obj, but got Unknown
		//IL_4cc8: Expected VT, but got Ref
		//IL_4cf0: Expected Obj, but got F4
		//IL_3a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a8a: Expected Obj, but got Unknown
		//IL_3a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a98: Expected Obj, but got Unknown
		//IL_4ac4: Expected I, but got Obj
		//IL_4af5: Expected I4, but got Obj
		//IL_4b7f: Expected VT, but got Ref
		//IL_4b97: Expected Obj, but got F4
		//IL_4d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d0c: Expected Obj, but got Unknown
		//IL_4d14: Expected Obj, but got I4
		//IL_4d40: Expected Obj, but got Ref
		//IL_4e63: Expected Obj, but got I8
		//IL_4f3c: Expected VT, but got Ref
		//IL_4f64: Expected Obj, but got F4
		//IL_4d5e: Expected I, but got Obj
		//IL_4d6e: Expected Obj, but got I
		//IL_4d8f: Expected I4, but got Obj
		//IL_4e21: Expected VT, but got Ref
		//IL_4e31: Expected Obj, but got F4
		//IL_4e41: Expected Obj, but got I
		//IL_4f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f80: Expected Obj, but got Unknown
		//IL_4f88: Expected Obj, but got I4
		//IL_50e7: Expected Obj, but got I4
		//IL_50f7: Expected Obj, but got I4
		//IL_5117: Unknown result type (might be due to invalid IL or missing references)
		//IL_511c: Expected Obj, but got Unknown
		//IL_51ee: Expected VT, but got Ref
		//IL_5216: Expected Obj, but got F4
		//IL_4fd2: Expected I, but got Obj
		//IL_5003: Expected I4, but got Obj
		//IL_509d: Expected VT, but got Ref
		//IL_50ad: Expected Obj, but got F4
		//IL_522d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5232: Expected Obj, but got Unknown
		//IL_523a: Expected Obj, but got I4
		//IL_5254: Expected Obj, but got I
		//IL_527f: Expected I, but got Obj
		//IL_528f: Expected Obj, but got I
		//IL_529c: Expected I4, but got Obj
		//IL_52a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_52aa: Expected Obj, but got Unknown
		//IL_52c0: Expected Obj, but got I4
		//IL_5378: Expected VT, but got F4
		//IL_5388: Expected Obj, but got F4
		//IL_5398: Expected I4, but got Obj
		//IL_5420: Expected VT, but got F4
		//IL_5430: Expected Obj, but got F4
		//IL_5440: Expected Obj, but got I
		bool flag = System.IO.File.Exists(inPath);
		bool flag2 = !flag;
		TickRate.Resolved resolved = (TickRate.Resolved)0;
		int num = 0;
		string text2 = default;
		string text = text2;
		if (flag2)
		{
			goto IL_7aa1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA0A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ClientTimeProvider clientTimeProvider = default;
		clientTimeProvider._002Ector();
		bool flag3 = clientTimeProvider == null;
		bool flag4 = false;
		bool flag5 = false;
		TickRate.Resolved resolved2 = (TickRate.Resolved)0;
		TickRate.Resolved resolved3 = (TickRate.Resolved)0;
		resolved = (TickRate.Resolved)0;
		string text4 = default;
		string text3 = text4;
		num = 0;
		flag = (byte)(int)clientTimeProvider != 0;
		ClientTimeProvider clientTimeProvider2 = clientTimeProvider;
		text = text2;
		if (flag3)
		{
			goto IL_7878;
		}
		nint num2 = (nint)clientTimeProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7508]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5562 @ X8_v345 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5562 @ X8_v345 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_014c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5562 @ X8_v345 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
		object obj4 = (nint)0 + (nint)8;
		object obj5 = default;
		object obj6;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5653 @ X10_v192-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5653 @ X10_v192-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj3--;
			obj6 = obj4 + 16;
			bool flag6 = (nint)obj3 != 1;
			obj4 = obj6;
			if (flag6)
			{
				continue;
			}
			goto IL_014c;
		}
		object obj7 = obj4 + 2;
		object obj8 = num2 + obj7;
		object obj9 = obj8 + 312;
		obj6 = obj4;
		goto IL_7b0c;
		IL_74b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag7 = num3 != 0;
		float num5;
		float num4 = num5;
		object obj11;
		object obj10 = obj11;
		int num7;
		int num6 = num7;
		TickRate.Resolved resolved4;
		resolved = resolved4;
		string text5;
		num = (int)text5;
		if (!flag7)
		{
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			flag = (byte)(int)ex != 0;
			goto IL_751d;
		}
		goto IL_7a43;
		IL_6c81:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag8 = num8 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		string text6;
		num = (int)text6;
		char c;
		if (!flag8)
		{
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			c = (char)(int)text6;
			flag = (byte)(int)ex2 != 0;
			goto IL_6cf6;
		}
		goto IL_7a43;
		IL_751d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag9 = num9 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag9)
		{
			IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
			flag = (byte)(int)ex3 != 0;
			goto IL_758a;
		}
		goto IL_7a43;
		IL_6ff9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag10 = num10 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag10)
		{
			NullReferenceException ex4 = new NullReferenceException();
			text5 = (string)c;
			flag = (byte)(int)ex4 != 0;
			goto IL_706e;
		}
		goto IL_7a43;
		IL_758a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag11 = num11 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag11)
		{
			IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
			flag = (byte)(int)ex5 != 0;
			goto IL_75f7;
		}
		goto IL_7a43;
		IL_2a96:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		text3 = null;
		goto IL_7fce;
		IL_014c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_7b0c;
		IL_7b0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5705 @ X0_v377] (should have been resolved before IL gen)");
		IEnumerable<string> source = System.IO.File.ReadLines(inPath);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BD8]");
		object obj12 = 0;
		text3 = (string)obj12;
		IEnumerable<System.__Canon> enumerable = Enumerable.Take((IEnumerable<System.__Canon>)source, 3);
		bool flag12 = enumerable == null;
		flag4 = false;
		flag5 = false;
		resolved2 = (TickRate.Resolved)0;
		resolved3 = (TickRate.Resolved)0;
		resolved = (TickRate.Resolved)0;
		num = 3;
		flag = (byte)(int)enumerable != 0;
		clientTimeProvider2 = clientTimeProvider;
		text = text2;
		if (flag12)
		{
			goto IL_7878;
		}
		nint num12 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5742 @ X8_v350 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.__Canon>>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5742 @ X8_v350 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.__Canon>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_023d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5742 @ X8_v350 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.__Canon>>)+98]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5803 @ X10_v187-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5803 @ X10_v187-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj13--;
			obj6 = obj14 + 16;
			bool flag13 = (nint)obj13 != 1;
			obj14 = obj6;
			if (flag13)
			{
				continue;
			}
			goto IL_023d;
		}
		object obj15 = num12 + obj14;
		object obj16 = obj15 + 312;
		obj6 = obj14;
		goto IL_7bec;
		IL_6c0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag14 = num13 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text6;
		int num14;
		if (!flag14)
		{
			IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
			flag = (byte)(int)ex6 != 0;
			num14 = (int)text;
			goto IL_6c81;
		}
		goto IL_7a43;
		IL_75f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag15 = num15 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag15)
		{
			NullReferenceException ex7 = new NullReferenceException();
			flag = (byte)(int)ex7 != 0;
			goto IL_7664;
		}
		goto IL_7a43;
		IL_6eb2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag16 = num16 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag16)
		{
			NullReferenceException ex8 = new NullReferenceException();
			flag = (byte)(int)ex8 != 0;
			goto IL_6f1f;
		}
		goto IL_7a43;
		IL_7664:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag17 = num17 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag17)
		{
			NullReferenceException ex9 = new NullReferenceException();
			flag = (byte)(int)ex9 != 0;
			goto IL_76d1;
		}
		goto IL_7a43;
		IL_6ac5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag18 = num18 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text6;
		if (!flag18)
		{
			NullReferenceException ex10 = new NullReferenceException();
			flag = (byte)(int)ex10 != 0;
			goto IL_6b32;
		}
		goto IL_7a43;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		text3 = null;
		goto IL_7bec;
		IL_7bec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5845 @ X0_v383+8]");
		char c2 = '\0';
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5845 @ X0_v383] (should have been resolved before IL gen)");
		bool flag20 = default;
		bool flag19 = !flag20;
		resolved2 = (TickRate.Resolved)0;
		resolved3 = (TickRate.Resolved)0;
		resolved = (TickRate.Resolved)0;
		flag = flag20;
		if (flag19)
		{
			goto IL_26df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91C0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABD0]");
		object obj19 = 0;
		float num20 = default;
		float num19 = num20;
		object obj21 = default;
		object obj20 = obj21;
		num5 = num4;
		object obj22 = obj5;
		obj11 = obj10;
		TickRate.Resolved resolved5 = (TickRate.Resolved)0;
		TickRate.Resolved resolved6 = (TickRate.Resolved)0;
		bool flag22 = default;
		bool flag21 = flag22;
		num7 = num6;
		resolved4 = (TickRate.Resolved)0;
		int num22 = default;
		int num21 = num22;
		nint num24 = default;
		nint num23 = num24;
		object obj23 = 0;
		string text7 = text3;
		object obj24 = obj6;
		bool flag23 = flag20;
		text = text2;
		string text9 = default;
		float num29 = default;
		float num30 = default;
		string text10 = default;
		string text12 = default;
		char c3;
		string text13;
		string text16;
		object obj29;
		bool flag30 = default;
		string text11 = default;
		TickRate.Resolved resolved8;
		while (true)
		{
			bool value = ((bool*)(flag23 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5937 @ X8_v359 (System.Boolean)+12E]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5937 @ X8_v359 (System.Boolean)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0399;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5937 @ X8_v359 (System.Boolean)+98]");
			object obj26 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6097 @ X10_v182-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6097 @ X10_v182-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj25--;
				obj24 = obj26 + 16;
				bool flag24 = (nint)obj25 != 1;
				obj26 = obj24;
				if (flag24)
				{
					continue;
				}
				goto IL_0399;
			}
			object obj27 = value + obj26;
			object obj28 = obj27 + 312;
			text3 = text7;
			obj24 = obj26;
			goto IL_7c76;
			IL_7e86:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7891 @ X0_v442+8]");
			text3 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7891 @ X0_v442] (should have been resolved before IL gen)");
			num20 = 0f;
			TickRate.Resolved resolved7 = resolved8;
			obj21 = 1;
			num4 = 0f;
			obj10 = 0;
			resolved2 = (TickRate.Resolved)0;
			resolved3 = resolved8;
			flag22 = false;
			int num25;
			num6 = num25;
			resolved = resolved8;
			int num26;
			num22 = num26;
			num24 = num26;
			string text8 = (string)(&resolved7);
			int num28;
			int num27 = num28;
			goto IL_7d90;
			IL_7d90:
			obj29 = obj23 + 1;
			bool flag25 = !flag20;
			object obj30 = !flag25;
			obj5 = obj22;
			obj6 = obj24;
			c2 = (char)(int)text8;
			num19 = num20;
			obj20 = obj21;
			num5 = num4;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = flag22;
			num7 = num6;
			resolved4 = resolved;
			num21 = num22;
			num23 = num24;
			obj23 = obj29;
			text7 = text3;
			flag23 = flag20;
			text = (string)num27;
			if (obj30 != null)
			{
				continue;
			}
			goto IL_26df;
			IL_1da4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_7e86;
			IL_0399:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text3 = null;
			goto IL_7c76;
			IL_7c76:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6140 @ X0_v390+8]");
			c2 = '\0';
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6140 @ X0_v390] (should have been resolved before IL gen)");
			bool flag26 = !flag;
			num20 = num19;
			obj21 = obj20;
			num4 = num5;
			obj5 = obj22;
			obj10 = obj11;
			resolved2 = resolved5;
			resolved3 = resolved6;
			flag22 = flag21;
			num6 = num7;
			resolved = resolved4;
			num22 = num21;
			num24 = num23;
			obj29 = obj23;
			obj6 = obj24;
			if (flag26)
			{
				break;
			}
			if (!flag20)
			{
				goto IL_560a;
			}
			bool value2 = ((bool*)(flag20 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6202 @ X8_v367 (System.Boolean)+12E]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6202 @ X8_v367 (System.Boolean)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0497;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6202 @ X8_v367 (System.Boolean)+98]");
			object obj32 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6268 @ X10_v177-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6268 @ X10_v177-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj31--;
				obj24 = obj32 + 16;
				bool flag27 = (nint)obj31 != 1;
				obj32 = obj24;
				if (flag27)
				{
					continue;
				}
				goto IL_0497;
			}
			object obj33 = value2 + obj32;
			object obj34 = obj33 + 312;
			obj24 = obj32;
			goto IL_7d51;
			IL_0497:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text3 = null;
			goto IL_7d51;
			IL_7d51:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6312 @ X0_v396+8]");
			c2 = '\0';
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6312 @ X0_v396] (should have been resolved before IL gen)");
			bool flag28 = text9 == null;
			flag = (byte)(int)text9 != 0;
			if (flag28)
			{
				goto IL_5687;
			}
			string[] array = text9.Split(',', (StringSplitOptions)0);
			if (obj23 != null)
			{
				if ((nint)obj23 == 1)
				{
					bool flag29 = array == null;
					flag4 = flag20;
					flag5 = false;
					num29 = 0f;
					flag30 = false;
					num30 = (nint)(&flag4);
					num24 = unchecked((nint)null);
					text10 = text4;
					text11 = inPath;
					text12 = text2;
					text3 = null;
					c3 = ',';
					flag = (byte)(int)array != 0;
					clientTimeProvider2 = clientTimeProvider;
					if (flag29)
					{
						goto IL_681f;
					}
					text6 = (string)obj19;
					object obj35 = array.Length - 5;
					bool flag31 = obj35 == null;
					Assert.Always(flag31, (string)obj19);
					object obj36 = array.Length & 0xFFFFFFFEL;
					bool flag32 = obj36 == null;
					flag4 = flag20;
					flag5 = false;
					num29 = 0f;
					flag30 = false;
					num30 = (nint)(&flag4);
					num24 = unchecked((nint)null);
					text10 = text4;
					text11 = inPath;
					text12 = text2;
					text3 = null;
					flag = flag31;
					clientTimeProvider2 = clientTimeProvider;
					if (flag32)
					{
						goto IL_6b9f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB160]");
					object obj37 = 0;
					text = array[1];
					object obj38 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6698 @ X0_v423+E4]");
					bool flag33 = (nint)0 == 0;
					object obj39 = !flag33;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					num28 = int.Parse(text, (IFormatProvider)invariantCulture);
					bool flag34 = array.Length < 2;
					object obj40 = !flag34;
					object obj41 = array.Length - 2;
					bool flag35 = obj41 == null;
					object obj42 = ~obj40;
					object obj43 = obj42 | flag35;
					flag4 = flag20;
					flag5 = false;
					num29 = 0f;
					flag30 = false;
					num30 = (nint)(&flag4);
					num24 = unchecked((nint)null);
					text10 = text4;
					text11 = inPath;
					text12 = text2;
					text3 = null;
					c3 = (char)(int)invariantCulture;
					flag = (byte)num28 != 0;
					clientTimeProvider2 = clientTimeProvider;
					if (obj43 != null)
					{
						goto IL_68f9;
					}
					CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
					int num31 = int.Parse(array[2], (IFormatProvider)invariantCulture2);
					object obj44 = array.Length & 0xFFFFFFFCL;
					bool flag36 = obj44 == null;
					flag4 = flag20;
					flag5 = false;
					num29 = 0f;
					flag30 = false;
					num30 = (nint)(&flag4);
					num24 = unchecked((nint)null);
					text10 = text4;
					text11 = inPath;
					text12 = text2;
					text3 = null;
					c = (char)(int)invariantCulture2;
					flag = (byte)num31 != 0;
					clientTimeProvider2 = clientTimeProvider;
					num14 = num28;
					if (flag36)
					{
						goto IL_6cf6;
					}
					text13 = array[3];
					CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
					num26 = int.Parse(array[3], (IFormatProvider)invariantCulture3);
					bool flag37 = array.Length < 4;
					object obj45 = !flag37;
					object obj46 = array.Length - 4;
					bool flag38 = obj46 == null;
					object obj47 = ~obj45;
					object obj48 = obj47 | flag38;
					flag4 = flag20;
					flag5 = false;
					num29 = 0f;
					flag30 = false;
					num30 = (nint)(&flag4);
					num24 = unchecked((nint)null);
					text10 = text4;
					text11 = inPath;
					text12 = text2;
					text3 = null;
					text6 = (string)(object)invariantCulture3;
					flag = (byte)num26 != 0;
					clientTimeProvider2 = clientTimeProvider;
					text = (string)num28;
					if (obj48 != null)
					{
						goto IL_69e3;
					}
					CultureInfo invariantCulture4 = CultureInfo.InvariantCulture;
					num25 = int.Parse(array[4], (IFormatProvider)invariantCulture4);
					resolved8 = new TickRate.Resolved(num28, num31, num26, num25);
					nint num32 = (nint)clientTimeProvider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7751 @ X8_v405 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7751 @ X8_v405 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_1da4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7751 @ X8_v405 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
					object obj50 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7855 @ X10_v172-8]");
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7855 @ X10_v172-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj49--;
						obj24 = obj50 + 16;
						bool flag39 = (nint)obj49 != 1;
						obj50 = obj24;
						if (flag39)
						{
							continue;
						}
						goto IL_1da4;
					}
					object obj51 = obj50 + 1;
					object obj52 = num32 + obj51;
					object obj53 = obj52 + 312;
					obj24 = obj50;
					goto IL_7e86;
				}
				bool flag40 = (nint)obj23 != 2;
				num20 = num19;
				obj21 = obj20;
				num4 = num5;
				obj5 = obj22;
				obj10 = obj11;
				resolved2 = resolved5;
				resolved3 = resolved6;
				flag22 = flag21;
				num6 = num7;
				resolved = resolved4;
				num22 = num21;
				num24 = unchecked((nint)null);
				obj29 = obj23;
				text3 = null;
				obj6 = obj24;
				c2 = ',';
				if (flag40)
				{
					break;
				}
				bool flag41 = array == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c = ',';
				flag = (byte)(int)array != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag41)
				{
					goto IL_6f1f;
				}
				object obj54 = array.Length - 11;
				bool flag42 = obj54 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAD8]");
				object obj55 = 0;
				text6 = (string)obj55;
				Assert.Always(flag42, (string)obj55);
				bool flag43 = array.Length == 0;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = flag42;
				clientTimeProvider2 = clientTimeProvider;
				if (flag43)
				{
					goto IL_6b32;
				}
				bool flag44 = array[0] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c3 = (char)(int)obj55;
				flag = (byte)(int)array[0] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag44)
				{
					goto IL_688c;
				}
				string text14 = array[0].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB88]");
				object obj56 = 0;
				flag = text14 == (string)obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAB8]");
				object obj57 = 0;
				text5 = (string)obj57;
				Assert.Always(flag, (string)obj57);
				object obj58 = array.Length & 0xFFFFFFFEL;
				bool flag45 = obj58 == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c = (char)(int)obj57;
				clientTimeProvider2 = clientTimeProvider;
				if (flag45)
				{
					goto IL_6f8c;
				}
				bool flag46 = array[1] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[1] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag46)
				{
					goto IL_70db;
				}
				string text15 = array[1].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB00]");
				object obj59 = 0;
				flag = text15 == (string)obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB08]");
				object obj60 = 0;
				text16 = (string)obj60;
				Assert.Always(flag, (string)obj60);
				bool flag47 = array.Length < 2;
				object obj61 = !flag47;
				object obj62 = array.Length - 2;
				bool flag48 = obj62 == null;
				object obj63 = ~obj61;
				object obj64 = obj63 | flag48;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (obj64 != null)
				{
					goto IL_673d;
				}
				bool flag49 = array[2] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				text13 = (string)num21;
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c3 = (char)(int)obj60;
				flag = (byte)(int)array[2] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag49)
				{
					goto IL_696e;
				}
				string text17 = array[2].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAC8]");
				object obj65 = 0;
				flag = text17 == (string)obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAA8]");
				object obj66 = 0;
				text5 = (string)obj66;
				Assert.Always(flag, (string)obj66);
				object obj67 = array.Length & 0xFFFFFFFCL;
				bool flag50 = obj67 == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c3 = (char)(int)obj66;
				clientTimeProvider2 = clientTimeProvider;
				if (flag50)
				{
					goto IL_67b2;
				}
				bool flag51 = array[3] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[3] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag51)
				{
					goto IL_706e;
				}
				string text18 = array[3].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB48]");
				object obj68 = 0;
				flag = text18 == (string)obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB10]");
				object obj69 = 0;
				text5 = (string)obj69;
				Assert.Always(flag, (string)obj69);
				bool flag52 = array.Length < 4;
				object obj70 = !flag52;
				object obj71 = array.Length - 4;
				bool flag53 = obj71 == null;
				object obj72 = ~obj70;
				object obj73 = obj72 | flag53;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (obj73 != null)
				{
					goto IL_7148;
				}
				bool flag54 = array[4] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[4] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag54)
				{
					goto IL_728f;
				}
				string text19 = array[4].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAF0]");
				object obj74 = 0;
				flag = text19 == (string)obj74;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB78]");
				object obj75 = 0;
				text5 = (string)obj75;
				Assert.Always(flag, (string)obj75);
				bool flag55 = array.Length < 5;
				object obj76 = !flag55;
				object obj77 = array.Length - 5;
				bool flag56 = obj77 == null;
				object obj78 = ~obj76;
				object obj79 = obj78 | flag56;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (obj79 != null)
				{
					goto IL_7369;
				}
				bool flag57 = array[5] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[5] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag57)
				{
					goto IL_71b5;
				}
				string text20 = array[5].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB20]");
				object obj80 = 0;
				flag = text20 == (string)obj80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB50]");
				object obj81 = 0;
				text5 = (string)obj81;
				Assert.Always(flag, (string)obj81);
				bool flag58 = array.Length < 6;
				object obj82 = !flag58;
				object obj83 = array.Length - 6;
				bool flag59 = obj83 == null;
				object obj84 = ~obj82;
				object obj85 = obj84 | flag59;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (obj85 != null)
				{
					goto IL_76d1;
				}
				bool flag60 = array[6] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[6] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag60)
				{
					goto IL_7222;
				}
				string text21 = array[6].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB30]");
				object obj86 = 0;
				flag = text21 == (string)obj86;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAD0]");
				object obj87 = 0;
				text5 = (string)obj87;
				Assert.Always(flag, (string)obj87);
				object obj88 = array.Length & 0xFFFFFFF8L;
				bool flag61 = obj88 == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (flag61)
				{
					goto IL_751d;
				}
				bool flag62 = array[7] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[7] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag62)
				{
					goto IL_75f7;
				}
				string text22 = array[7].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABC8]");
				object obj89 = 0;
				flag = text22 == (string)obj89;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAE8]");
				object obj90 = 0;
				text5 = (string)obj90;
				Assert.Always(flag, (string)obj90);
				bool flag63 = array.Length < 8;
				object obj91 = !flag63;
				object obj92 = array.Length - 8;
				bool flag64 = obj92 == null;
				object obj93 = ~obj91;
				object obj94 = obj93 | flag64;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				num = (int)obj90;
				clientTimeProvider2 = clientTimeProvider;
				if (obj94 != null)
				{
					goto IL_77b3;
				}
				bool flag65 = array[8] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[8] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag65)
				{
					goto IL_7664;
				}
				string text23 = array[8].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB40]");
				object obj95 = 0;
				flag = text23 == (string)obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB58]");
				object obj96 = 0;
				text5 = (string)obj96;
				Assert.Always(flag, (string)obj96);
				bool flag66 = array.Length < 9;
				object obj97 = !flag66;
				object obj98 = array.Length - 9;
				bool flag67 = obj98 == null;
				object obj99 = ~obj97;
				object obj100 = obj99 | flag67;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (obj100 != null)
				{
					goto IL_773e;
				}
				bool flag68 = array[9] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[9] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag68)
				{
					goto IL_7443;
				}
				string text24 = array[9].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB18]");
				object obj101 = 0;
				flag = text24 == (string)obj101;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABA0]");
				object obj102 = 0;
				text5 = (string)obj102;
				Assert.Always(flag, (string)obj102);
				bool flag69 = array.Length < 10;
				object obj103 = !flag69;
				object obj104 = array.Length - 10;
				bool flag70 = obj104 == null;
				object obj105 = ~obj103;
				object obj106 = obj105 | flag70;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (obj106 != null)
				{
					goto IL_74b0;
				}
				bool flag71 = array[10] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[10] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag71)
				{
					goto IL_73d6;
				}
				string text25 = array[10].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAF8]");
				object obj107 = 0;
				flag = text25 == (string)obj107;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABC0]");
				object obj108 = 0;
				text8 = (string)obj108;
				Assert.Always(flag, (string)obj108);
				num20 = num19;
				obj21 = obj20;
				num4 = num5;
				obj10 = obj11;
				resolved2 = resolved5;
				resolved3 = resolved6;
				flag22 = flag21;
				num6 = num7;
				resolved = resolved4;
				num22 = num21;
				num24 = unchecked((nint)null);
				text3 = null;
				num27 = (int)text;
			}
			else
			{
				bool flag72 = array == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c = ',';
				flag = (byte)(int)array != 0;
				clientTimeProvider2 = clientTimeProvider;
				num14 = (int)text;
				if (flag72)
				{
					goto IL_6d63;
				}
				text6 = (string)obj19;
				object obj109 = array.Length - 5;
				bool flag73 = obj109 == null;
				Assert.Always(flag73, (string)obj19);
				bool flag74 = array.Length == 0;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = flag73;
				clientTimeProvider2 = clientTimeProvider;
				if (flag74)
				{
					goto IL_6c0c;
				}
				bool flag75 = array[0] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[0] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag75)
				{
					goto IL_6ac5;
				}
				string text26 = array[0].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAE0]");
				object obj110 = 0;
				flag = text26 == (string)obj110;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB98]");
				object obj111 = 0;
				Assert.Always(flag, (string)obj111);
				object obj112 = array.Length & 0xFFFFFFFEL;
				bool flag76 = obj112 == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c = (char)(int)obj111;
				clientTimeProvider2 = clientTimeProvider;
				num14 = (int)text;
				if (flag76)
				{
					goto IL_6dd0;
				}
				bool flag77 = array[1] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c = (char)(int)obj111;
				flag = (byte)(int)array[1] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag77)
				{
					goto IL_6ff9;
				}
				string text27 = array[1].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAB0]");
				object obj113 = 0;
				flag = text27 == (string)obj113;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB28]");
				object obj114 = 0;
				text6 = (string)obj114;
				Assert.Always(flag, (string)obj114);
				bool flag78 = array.Length < 2;
				object obj115 = !flag78;
				object obj116 = array.Length - 2;
				bool flag79 = obj116 == null;
				object obj117 = ~obj115;
				object obj118 = obj117 | flag79;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c = (char)(int)obj114;
				clientTimeProvider2 = clientTimeProvider;
				num14 = (int)text;
				if (obj118 != null)
				{
					goto IL_6e3d;
				}
				bool flag80 = array[2] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[2] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag80)
				{
					goto IL_6a58;
				}
				string text28 = array[2].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB70]");
				object obj119 = 0;
				flag = text28 == (string)obj119;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB80]");
				object obj120 = 0;
				text6 = (string)obj120;
				Assert.Always(flag, (string)obj120);
				object obj121 = array.Length & 0xFFFFFFFCL;
				bool flag81 = obj121 == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				num14 = (int)text;
				if (flag81)
				{
					goto IL_6c81;
				}
				bool flag82 = array[3] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				c = (char)(int)obj120;
				flag = (byte)(int)array[3] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag82)
				{
					goto IL_6eb2;
				}
				string text29 = array[3].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABB0]");
				object obj122 = 0;
				flag = text29 == (string)obj122;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAAC0]");
				object obj123 = 0;
				text5 = (string)obj123;
				Assert.Always(flag, (string)obj123);
				bool flag83 = array.Length < 4;
				object obj124 = !flag83;
				object obj125 = array.Length - 4;
				bool flag84 = obj125 == null;
				object obj126 = ~obj124;
				object obj127 = obj126 | flag84;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				clientTimeProvider2 = clientTimeProvider;
				if (obj127 != null)
				{
					goto IL_758a;
				}
				bool flag85 = array[4] == null;
				flag4 = flag20;
				flag5 = false;
				num29 = 0f;
				flag30 = false;
				num30 = (nint)(&flag4);
				num24 = unchecked((nint)null);
				text10 = text4;
				text11 = inPath;
				text12 = text2;
				text3 = null;
				flag = (byte)(int)array[4] != 0;
				clientTimeProvider2 = clientTimeProvider;
				if (flag85)
				{
					goto IL_72fc;
				}
				string text30 = array[4].Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABA8]");
				object obj128 = 0;
				flag = text30 == (string)obj128;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB38]");
				object obj129 = 0;
				text8 = (string)obj129;
				Assert.Always(flag, (string)obj129);
				num20 = num19;
				obj21 = obj20;
				num4 = num5;
				obj10 = obj11;
				resolved2 = resolved5;
				resolved3 = resolved6;
				flag22 = flag21;
				num6 = num7;
				resolved = resolved4;
				num22 = num21;
				num24 = unchecked((nint)null);
				text3 = null;
				num27 = (int)text;
			}
			goto IL_7d90;
		}
		flag4 = flag20;
		flag5 = false;
		num29 = 0f;
		flag30 = false;
		num30 = (nint)(&flag4);
		string path = inPath;
		text10 = text4;
		text11 = inPath;
		text12 = text2;
		object obj130 = 11;
		string path2 = text4;
		clientTimeProvider2 = clientTimeProvider;
		text = text2;
		goto IL_875d;
		IL_283e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		text3 = null;
		goto IL_7f7b;
		IL_76d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag86 = num33 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag86)
		{
			IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
			flag = (byte)(int)ex11 != 0;
			goto IL_773e;
		}
		goto IL_7a43;
		IL_5ccb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag87 = num34 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		float num35;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag87)
		{
			IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
			flag = (byte)(int)ex12 != 0;
			goto IL_5d40;
		}
		goto IL_7a43;
		IL_6d63:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag88 = num36 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag88)
		{
			NullReferenceException ex13 = new NullReferenceException();
			flag = (byte)(int)ex13 != 0;
			goto IL_6dd0;
		}
		goto IL_7a43;
		IL_5c56:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag89 = num37 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag89)
		{
			IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
			flag = (byte)(int)ex14 != 0;
			goto IL_5ccb;
		}
		goto IL_7a43;
		IL_728f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag90 = num38 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag90)
		{
			NullReferenceException ex15 = new NullReferenceException();
			flag = (byte)(int)ex15 != 0;
			goto IL_72fc;
		}
		goto IL_7a43;
		IL_6cf6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag91 = num39 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag91)
		{
			IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
			flag = (byte)(int)ex16 != 0;
			goto IL_6d63;
		}
		goto IL_7a43;
		IL_5be1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag92 = num40 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag92)
		{
			IndexOutOfRangeException ex17 = new IndexOutOfRangeException();
			flag = (byte)(int)ex17 != 0;
			goto IL_5c56;
		}
		goto IL_7a43;
		IL_72fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag93 = num41 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag93)
		{
			NullReferenceException ex18 = new NullReferenceException();
			flag = (byte)(int)ex18 != 0;
			goto IL_7369;
		}
		goto IL_7a43;
		IL_560a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag94 = num42 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num24 = num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6140 @ X0_v390+8]");
		num = 0;
		if (!flag94)
		{
			NullReferenceException ex19 = new NullReferenceException();
			flag = (byte)(int)ex19 != 0;
			goto IL_5687;
		}
		goto IL_7a43;
		IL_773e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag95 = num43 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag95)
		{
			IndexOutOfRangeException ex20 = new IndexOutOfRangeException();
			num = (int)text5;
			flag = (byte)(int)ex20 != 0;
			goto IL_77b3;
		}
		goto IL_7a43;
		IL_5b6c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag96 = num44 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag96)
		{
			IndexOutOfRangeException ex21 = new IndexOutOfRangeException();
			flag = (byte)(int)ex21 != 0;
			goto IL_5be1;
		}
		goto IL_7a43;
		IL_6b32:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag97 = num45 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text6;
		if (!flag97)
		{
			IndexOutOfRangeException ex22 = new IndexOutOfRangeException();
			flag = (byte)(int)ex22 != 0;
			goto IL_6b9f;
		}
		goto IL_7a43;
		IL_5f37:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag98 = num46 != 0;
		float num48;
		float num47 = num48;
		float num50;
		float num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		IFormatProvider formatProvider;
		num = (int)formatProvider;
		float num51;
		if (!flag98)
		{
			IndexOutOfRangeException ex23 = new IndexOutOfRangeException();
			num51 = num35;
			flag = (byte)(int)ex23 != 0;
			goto IL_5fb4;
		}
		goto IL_7a43;
		IL_78bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5440 @ X23_v61 (System.String)+28]");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		if (num52 == 0)
		{
			OutOfMemoryException ex24 = new OutOfMemoryException();
			flag = (byte)(int)ex24 != 0;
			goto IL_7902;
		}
		goto IL_7a43;
		IL_5d40:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag99 = num53 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag99)
		{
			IndexOutOfRangeException ex25 = new IndexOutOfRangeException();
			formatProvider = (IFormatProvider)c2;
			flag = (byte)(int)ex25 != 0;
			goto IL_5dbd;
		}
		goto IL_7a43;
		IL_5fb4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag100 = num54 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num51;
		num = (int)formatProvider;
		if (!flag100)
		{
			IndexOutOfRangeException ex26 = new IndexOutOfRangeException();
			flag = (byte)(int)ex26 != 0;
			goto IL_6029;
		}
		goto IL_7a43;
		IL_5dbd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag101 = num55 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = (int)formatProvider;
		bool flag102;
		object obj131;
		object obj133;
		float num56;
		float num58;
		float num60;
		float num62;
		object obj135;
		bool flag103 = default;
		object obj132 = default;
		object obj134 = default;
		float num57 = default;
		float num59 = default;
		float num61 = default;
		float num63 = default;
		if (!flag101)
		{
			IndexOutOfRangeException ex27 = new IndexOutOfRangeException();
			num48 = num47;
			num50 = num49;
			num20 = num19;
			obj21 = obj20;
			flag102 = flag103;
			obj131 = obj132;
			obj133 = obj134;
			num56 = num57;
			num58 = num59;
			num60 = num61;
			num62 = num63;
			obj10 = obj11;
			resolved2 = resolved5;
			resolved3 = resolved6;
			num22 = num21;
			num24 = num23;
			obj29 = obj23;
			obj135 = obj17;
			flag = (byte)(int)ex27 != 0;
			goto IL_5ec2;
		}
		goto IL_7a43;
		IL_5687:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag104 = num64 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num24 = num23;
		num = c2;
		bool flag105;
		string text31;
		if (!flag104)
		{
			NullReferenceException ex28 = new NullReferenceException();
			flag4 = flag20;
			flag5 = false;
			num29 = 0f;
			flag105 = false;
			num30 = (nint)(&flag4);
			text10 = text4;
			text31 = inPath;
			text12 = text2;
			flag = (byte)(int)ex28 != 0;
			clientTimeProvider2 = clientTimeProvider;
			goto IL_5747;
		}
		goto IL_7a43;
		IL_706e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag106 = num65 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag106)
		{
			NullReferenceException ex29 = new NullReferenceException();
			flag = (byte)(int)ex29 != 0;
			goto IL_70db;
		}
		goto IL_7a43;
		IL_6029:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag107 = num66 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num51;
		num = (int)formatProvider;
		if (!flag107)
		{
			IndexOutOfRangeException ex30 = new IndexOutOfRangeException();
			flag = (byte)(int)ex30 != 0;
			goto IL_609e;
		}
		goto IL_7a43;
		IL_681f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag108 = num67 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c3;
		if (!flag108)
		{
			NullReferenceException ex31 = new NullReferenceException();
			flag = (byte)(int)ex31 != 0;
			goto IL_688c;
		}
		goto IL_7a43;
		IL_6f8c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag109 = num68 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag109)
		{
			IndexOutOfRangeException ex32 = new IndexOutOfRangeException();
			flag = (byte)(int)ex32 != 0;
			goto IL_6ff9;
		}
		goto IL_7a43;
		IL_688c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag110 = num69 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c3;
		if (!flag110)
		{
			NullReferenceException ex33 = new NullReferenceException();
			flag = (byte)(int)ex33 != 0;
			goto IL_68f9;
		}
		goto IL_7a43;
		IL_57bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag111 = num70 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num24 = num23;
		num = c2;
		if (!flag111)
		{
			IndexOutOfRangeException ex34 = new IndexOutOfRangeException();
			flag = (byte)(int)ex34 != 0;
			goto IL_5831;
		}
		goto IL_7a43;
		IL_58ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag112 = num71 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag112)
		{
			NullReferenceException ex35 = new NullReferenceException();
			flag = (byte)(int)ex35 != 0;
			goto IL_5923;
		}
		goto IL_7a43;
		IL_68f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag113 = num72 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c3;
		if (!flag113)
		{
			IndexOutOfRangeException ex36 = new IndexOutOfRangeException();
			text13 = (string)num21;
			flag = (byte)(int)ex36 != 0;
			goto IL_696e;
		}
		goto IL_7a43;
		IL_7f1b:
		bool flag114 = !flag30;
		object obj136 = !flag114;
		flag = flag30;
		if (obj136 != null)
		{
			goto IL_78bd;
		}
		bool flag115 = num29 == 0f;
		object obj137 = !flag115;
		flag = flag30;
		StreamWriter streamWriter;
		if (obj137 == null)
		{
			if ((nint)obj130 != 11)
			{
				bool flag116 = obj130 == null;
				object obj138 = !flag116;
				text4 = text3;
				flag = flag30;
				if (obj138 != null)
				{
					goto IL_7aa1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3109 @ X25_v50 (System.Int32)+98]");
			object obj139 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6219 @ X8_v13+A0]");
			object contents = 0;
			System.IO.File.WriteAllText(path2, (string)contents);
			streamWriter = System.IO.File.AppendText(path2);
			bool flag117 = streamWriter == null;
			text3 = null;
			num = 0;
			flag = (byte)(int)streamWriter != 0;
			if (!flag117)
			{
				string stackTrace = ((Exception)(object)streamWriter).StackTrace;
				IEnumerable<string> enumerable2 = System.IO.File.ReadLines(path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BD0]");
				object obj140 = 0;
				text3 = (string)obj140;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E0E0C");
				bool flag118 = !flag;
				num = 3;
				if (!flag118)
				{
					bool value3 = ((bool*)(flag ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6440 @ X8_v20 (System.Boolean)+12E]");
					object obj141 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6440 @ X8_v20 (System.Boolean)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_2a96;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6440 @ X8_v20 (System.Boolean)+98]");
					object obj142 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6575 @ X10_v74-8]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6575 @ X10_v74-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj141--;
						obj6 = obj142 + 16;
						bool flag119 = (nint)obj141 != 1;
						obj142 = obj6;
						if (flag119)
						{
							continue;
						}
						goto IL_2a96;
					}
					object obj143 = value3 + obj142;
					object obj144 = obj143 + 312;
					obj6 = obj142;
					goto IL_7fce;
				}
			}
			goto IL_7878;
		}
		goto IL_7902;
		IL_696e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag120 = num73 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c3;
		if (!flag120)
		{
			NullReferenceException ex37 = new NullReferenceException();
			text6 = (string)c3;
			flag = (byte)(int)ex37 != 0;
			goto IL_69e3;
		}
		goto IL_7a43;
		IL_5831:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag121 = num74 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num24 = num23;
		num = c2;
		if (!flag121)
		{
			NullReferenceException ex38 = new NullReferenceException();
			num35 = (float)resolved4;
			flag = (byte)(int)ex38 != 0;
			goto IL_58ae;
		}
		goto IL_7a43;
		IL_7aa1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5440 @ X23_v61 (System.String)+28]");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag122 = num75 != 0;
		text3 = text4;
		if (!flag122)
		{
			return;
		}
		goto IL_7a43;
		IL_6a58:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag123 = num76 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text6;
		if (!flag123)
		{
			NullReferenceException ex39 = new NullReferenceException();
			flag = (byte)(int)ex39 != 0;
			goto IL_6ac5;
		}
		goto IL_7a43;
		IL_648c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag124 = num77 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		float num78;
		resolved = (TickRate.Resolved)num78;
		num24 = num23;
		char c4;
		num = c4;
		ArgumentNullException ex40 = default;
		if (!flag124)
		{
			ex40 = new ArgumentNullException();
			num = 0;
			goto IL_6514;
		}
		goto IL_7a43;
		IL_77b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag125 = num79 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		if (!flag125)
		{
			IndexOutOfRangeException ex41 = new IndexOutOfRangeException();
			num20 = num19;
			obj21 = obj20;
			num4 = num5;
			obj5 = obj22;
			obj10 = obj11;
			resolved2 = resolved5;
			resolved3 = resolved6;
			num6 = num7;
			resolved = resolved4;
			num22 = num21;
			obj29 = obj23;
			obj6 = obj24;
			flag = (byte)(int)ex41 != 0;
			goto IL_7878;
		}
		goto IL_7a43;
		IL_71b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag126 = num80 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag126)
		{
			NullReferenceException ex42 = new NullReferenceException();
			flag = (byte)(int)ex42 != 0;
			goto IL_7222;
		}
		goto IL_7a43;
		IL_6514:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag127 = num81 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num78;
		num24 = num23;
		ArgumentNullException ex43 = default;
		if (!flag127)
		{
			ex43 = new ArgumentNullException();
			num = 0;
			goto IL_6594;
		}
		goto IL_7a43;
		IL_69e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag128 = num82 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text6;
		if (!flag128)
		{
			IndexOutOfRangeException ex44 = new IndexOutOfRangeException();
			num21 = (int)text13;
			flag = (byte)(int)ex44 != 0;
			goto IL_6a58;
		}
		goto IL_7a43;
		IL_6594:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag129 = num83 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num78;
		num24 = num23;
		float num84;
		if (!flag129)
		{
			ArgumentNullException ex45 = new ArgumentNullException();
			num59 = num58;
			num61 = num60;
			num63 = num62;
			num84 = num78;
			num24 = num23;
			text16 = null;
			flag = (byte)(int)ex45 != 0;
			goto IL_6640;
		}
		goto IL_7a43;
		IL_5ec2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag130 = num85 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num = (int)formatProvider;
		if (!flag130)
		{
			IndexOutOfRangeException ex46 = new IndexOutOfRangeException();
			flag = (byte)(int)ex46 != 0;
			goto IL_5f37;
		}
		goto IL_7a43;
		IL_7a43:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_6640:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag131 = num86 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num84;
		num = (int)text16;
		if (!flag131)
		{
			IndexOutOfRangeException ex47 = new IndexOutOfRangeException();
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag103 = flag102;
			flag30 = flag105;
			obj132 = obj131;
			obj134 = obj133;
			num57 = num56;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			resolved4 = (TickRate.Resolved)num84;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text11 = text31;
			flag = (byte)(int)ex47 != 0;
			goto IL_673d;
		}
		goto IL_7a43;
		IL_7148:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag132 = num87 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag132)
		{
			IndexOutOfRangeException ex48 = new IndexOutOfRangeException();
			flag = (byte)(int)ex48 != 0;
			goto IL_71b5;
		}
		goto IL_7a43;
		IL_673d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag133 = num88 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text16;
		if (!flag133)
		{
			IndexOutOfRangeException ex49 = new IndexOutOfRangeException();
			c3 = (char)(int)text16;
			flag = (byte)(int)ex49 != 0;
			goto IL_67b2;
		}
		goto IL_7a43;
		IL_6e3d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag134 = num89 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag134)
		{
			IndexOutOfRangeException ex50 = new IndexOutOfRangeException();
			flag = (byte)(int)ex50 != 0;
			text = (string)num14;
			goto IL_6eb2;
		}
		goto IL_7a43;
		IL_67b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag135 = num90 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c3;
		if (!flag135)
		{
			IndexOutOfRangeException ex51 = new IndexOutOfRangeException();
			flag = (byte)(int)ex51 != 0;
			goto IL_681f;
		}
		goto IL_7a43;
		IL_7878:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5440 @ X23_v61 (System.String)+28]");
		nint num91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		if (num91 == 0)
		{
			NullReferenceException ex52 = new NullReferenceException();
			flag = (byte)(int)ex52 != 0;
			goto IL_78bd;
		}
		goto IL_7a43;
		IL_26df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		nint num92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag136 = num92 != 0;
		num = c2;
		if (!flag136)
		{
			throw new NullReferenceException();
		}
		goto IL_7a43;
		IL_70db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag137 = num93 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag137)
		{
			NullReferenceException ex53 = new NullReferenceException();
			flag = (byte)(int)ex53 != 0;
			goto IL_7148;
		}
		goto IL_7a43;
		IL_609e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag138 = num94 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num51;
		num = (int)formatProvider;
		IndexOutOfRangeException ex54 = default;
		if (!flag138)
		{
			ex54 = new IndexOutOfRangeException();
			goto IL_610b;
		}
		goto IL_7a43;
		IL_6b9f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag139 = num95 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text6;
		if (!flag139)
		{
			IndexOutOfRangeException ex55 = new IndexOutOfRangeException();
			flag = (byte)(int)ex55 != 0;
			goto IL_6c0c;
		}
		goto IL_7a43;
		IL_5544:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		text3 = null;
		goto IL_873e;
		IL_610b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag140 = num96 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num51;
		num = (int)formatProvider;
		ArgumentNullException ex56 = default;
		if (!flag140)
		{
			ex56 = new ArgumentNullException();
			num = 0;
			goto IL_618b;
		}
		goto IL_7a43;
		IL_873e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7462 @ X0_v28+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7462 @ X0_v28] (should have been resolved before IL gen)");
		goto IL_86da;
		IL_618b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag141 = num97 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num51;
		ArgumentNullException ex57 = default;
		if (!flag141)
		{
			ex57 = new ArgumentNullException();
			num = 0;
			goto IL_6203;
		}
		goto IL_7a43;
		IL_86da:
		bool flag142 = default;
		flag5 = flag142;
		flag22 = false;
		resolved8 = (TickRate.Resolved)(&flag5);
		flag = false;
		text = text12;
		flag5 = flag142;
		flag22 = false;
		resolved8 = (TickRate.Resolved)(&flag5);
		flag = false;
		text = text12;
		goto IL_7902;
		IL_6203:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag143 = num98 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num51;
		ArgumentNullException ex58 = default;
		if (!flag143)
		{
			ex58 = new ArgumentNullException();
			num = 0;
			goto IL_627b;
		}
		goto IL_7a43;
		IL_6f1f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag144 = num99 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag144)
		{
			NullReferenceException ex59 = new NullReferenceException();
			flag = (byte)(int)ex59 != 0;
			goto IL_6f8c;
		}
		goto IL_7a43;
		IL_627b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag145 = num100 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num51;
		char c5;
		if (!flag145)
		{
			ArgumentNullException ex60 = new ArgumentNullException();
			num78 = num51;
			num23 = num24;
			c5 = '\0';
			goto IL_6303;
		}
		goto IL_7a43;
		IL_5747:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag146 = num101 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num24 = num23;
		num = c2;
		if (!flag146)
		{
			NullReferenceException ex61 = new NullReferenceException();
			flag = (byte)(int)ex61 != 0;
			goto IL_57bc;
		}
		goto IL_7a43;
		IL_6303:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag147 = num102 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num78;
		num24 = num23;
		num = c5;
		IFormatProvider formatProvider2;
		if (!flag147)
		{
			ArgumentNullException ex62 = new ArgumentNullException();
			formatProvider2 = null;
			flag = (byte)(int)ex62 != 0;
			goto IL_638f;
		}
		goto IL_7a43;
		IL_7fce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6681 @ X0_v20+8]");
		c2 = '\0';
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6681 @ X0_v20] (should have been resolved before IL gen)");
		bool flag148 = !flag142;
		flag = flag142;
		if (flag148)
		{
			goto IL_5456;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB160]");
		obj29 = 0;
		num48 = num47;
		num50 = num49;
		num5 = num4;
		obj22 = obj5;
		flag102 = flag103;
		flag105 = flag30;
		obj131 = obj132;
		obj133 = obj134;
		num56 = num57;
		num58 = num59;
		num60 = num61;
		num62 = num63;
		float num104 = default;
		float num103 = num104;
		num7 = num6;
		resolved4 = resolved;
		num23 = num24;
		obj135 = 0;
		text31 = text11;
		string text32 = text3;
		obj24 = obj6;
		bool flag149 = flag142;
		object[] array2 = default;
		object obj163 = default;
		object obj164 = default;
		float num112 = default;
		float num113 = default;
		float num114 = default;
		float num115 = default;
		bool flag157 = default;
		bool flag162 = default;
		bool flag163 = default;
		bool flag167 = default;
		float num118 = default;
		bool flag172 = default;
		object obj173 = default;
		bool flag176 = default;
		object obj176 = default;
		bool flag181 = default;
		float num122 = default;
		bool flag186 = default;
		float num124 = default;
		bool flag191 = default;
		float num126 = default;
		IndexOutOfRangeException ex64 = default;
		bool flag195 = default;
		float num128 = default;
		string text34 = default;
		object obj245 = default;
		while (true)
		{
			bool value4 = ((bool*)(flag149 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6944 @ X8_v37 (System.Boolean)+12E]");
			object obj145 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6944 @ X8_v37 (System.Boolean)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_2bff;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6944 @ X8_v37 (System.Boolean)+98]");
			object obj146 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7139 @ X10_v69-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7139 @ X10_v69-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj145--;
				obj24 = obj146 + 16;
				bool flag150 = (nint)obj145 != 1;
				obj146 = obj24;
				if (flag150)
				{
					continue;
				}
				goto IL_2bff;
			}
			object obj147 = value4 + obj146;
			object obj148 = obj147 + 312;
			text3 = text32;
			obj24 = obj146;
			goto IL_803d;
			IL_825d:
			int num106;
			int num105 = ~num106;
			int num107 = num106 & num105;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9182 @ X0_v178+8]");
			num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9182 @ X0_v178] (should have been resolved before IL gen)");
			nint num108 = (nint)clientTimeProvider2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9191 @ X8_v108 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			object obj149 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9191 @ X8_v108 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_39ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9191 @ X8_v108 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
			object obj150 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9249 @ X10_v54-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9249 @ X10_v54-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj149--;
				obj24 = obj150 + 16;
				bool flag151 = (nint)obj149 != 1;
				obj150 = obj24;
				if (flag151)
				{
					continue;
				}
				goto IL_39ce;
			}
			object obj151 = obj150 + 7;
			object obj152 = num108 + obj151;
			object obj153 = obj152 + 312;
			double? num110;
			double? num109 = num110;
			obj24 = obj150;
			goto IL_833b;
			IL_38d8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_825d;
			IL_82ca:
			nint num111 = (nint)clientTimeProvider2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8298 @ X8_v47 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			object obj154 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8298 @ X8_v47 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_3b64;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8298 @ X8_v47 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
			object obj155 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8465 @ X10_v41-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8465 @ X10_v41-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj154--;
				obj24 = obj155 + 16;
				bool flag152 = (nint)obj154 != 1;
				obj155 = obj24;
				if (flag152)
				{
					continue;
				}
				goto IL_3b64;
			}
			object obj156 = num111 + obj155;
			object obj157 = obj156 + 312;
			obj24 = obj155;
			goto IL_8462;
			IL_2bff:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text3 = null;
			goto IL_803d;
			IL_803d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7222 @ X0_v37+8]");
			c2 = '\0';
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7222 @ X0_v37] (should have been resolved before IL gen)");
			bool flag153 = !flag;
			num47 = num48;
			num49 = num50;
			num4 = num5;
			obj5 = obj22;
			flag103 = flag102;
			flag30 = flag105;
			obj132 = obj131;
			obj134 = obj133;
			num57 = num56;
			num59 = num58;
			num61 = num60;
			num63 = num62;
			num104 = num103;
			num6 = num7;
			resolved = resolved4;
			num24 = num23;
			obj17 = obj135;
			text11 = text31;
			obj6 = obj24;
			if (flag153)
			{
				break;
			}
			bool flag154 = !flag142;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag102;
			obj132 = obj131;
			obj134 = obj133;
			num57 = num56;
			num59 = num58;
			num61 = num60;
			num63 = num62;
			num104 = num103;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			if (flag154)
			{
				goto IL_5747;
			}
			bool value5 = ((bool*)(flag142 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7377 @ X8_v40 (System.Boolean)+12E]");
			object obj158 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91C0]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7377 @ X8_v40 (System.Boolean)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_2db7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7377 @ X8_v40 (System.Boolean)+98]");
			object obj159 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7526 @ X10_v64-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7526 @ X10_v64-8]");
				if (0 == (nint)obj24)
				{
					break;
				}
				obj158--;
				obj24 = obj159 + 16;
				bool flag155 = (nint)obj158 != 1;
				obj159 = obj24;
				if (flag155)
				{
					continue;
				}
				goto IL_2db7;
			}
			object obj160 = value5 + obj159;
			object obj161 = obj160 + 312;
			obj24 = obj159;
			goto IL_8140;
			IL_3cb5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text3 = (string)10;
			goto IL_8583;
			IL_8583:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8829 @ X0_v61] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj162 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag156 = array2 == null;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			c2 = (char)(ushort)(&num30);
			flag = flag157;
			if (flag156)
			{
				goto IL_5a0d;
			}
			bool flag158 = !flag157;
			c2 = (char)(ushort)(&num30);
			flag = flag157;
			if (!flag158)
			{
				nint num116 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8899 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
				c2 = '\0';
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag159 = !flag;
				flag5 = flag142;
				flag102 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num78 = num115;
				text31 = (string)num115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8899 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
				c5 = '\0';
				ArgumentNullException ex60 = (ArgumentNullException)flag;
				if (flag159)
				{
					goto IL_6303;
				}
			}
			bool flag160 = array2.Length == 0;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (flag160)
			{
				goto IL_5af7;
			}
			object obj165 = array2 + 32;
			obj165 = flag157;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag161 = !flag162;
			c2 = (char)(ushort)(&flag163);
			flag = flag162;
			if (!flag161)
			{
				nint num117 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9013 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
				c2 = '\0';
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag164 = !flag;
				flag5 = flag142;
				flag102 = flag105;
				flag163 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num78 = num115;
				text31 = (string)num115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9013 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
				c4 = '\0';
				ArgumentNullException ex63 = (ArgumentNullException)flag;
				if (flag164)
				{
					goto IL_648c;
				}
			}
			object obj166 = array2.Length & 0xFFFFFFFEL;
			bool flag165 = obj166 == null;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			flag163 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (flag165)
			{
				goto IL_5a82;
			}
			object obj167 = array2 + 40;
			obj167 = flag162;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag166 = !flag167;
			c2 = (char)(ushort)(&num118);
			flag = flag167;
			if (!flag166)
			{
				nint num119 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8717 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
				formatProvider = (IFormatProvider)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag168 = ex54 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8717 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
				c2 = '\0';
				flag = (byte)(int)ex54 != 0;
				flag5 = flag142;
				flag102 = flag105;
				num118 = num29;
				flag163 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num51 = num115;
				num24 = num23;
				text31 = (string)num115;
				if (flag168)
				{
					goto IL_610b;
				}
			}
			bool flag169 = array2.Length < 2;
			object obj168 = !flag169;
			object obj169 = array2.Length - 2;
			bool flag170 = obj169 == null;
			object obj170 = ~obj168;
			object obj171 = obj170 | flag170;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			num118 = num29;
			flag163 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (obj171 != null)
			{
				goto IL_5998;
			}
			object obj172 = array2 + 48;
			obj172 = flag167;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag171 = !flag172;
			c2 = (char)(ushort)(&obj173);
			flag = flag172;
			if (!flag171)
			{
				nint num120 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8883 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
				c2 = '\0';
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag173 = ex57 == null;
				flag = (byte)(int)ex57 != 0;
				flag5 = flag142;
				flag102 = flag105;
				obj173 = obj163;
				num118 = num29;
				flag163 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num51 = num115;
				num24 = num23;
				text31 = (string)num115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8883 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
				num = 0;
				if (flag173)
				{
					goto IL_6203;
				}
			}
			object obj174 = array2.Length & 0xFFFFFFFCL;
			bool flag174 = obj174 == null;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			obj173 = obj163;
			num118 = num29;
			flag163 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (flag174)
			{
				goto IL_5c56;
			}
			object obj175 = array2 + 56;
			obj175 = flag172;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag175 = !flag176;
			c2 = (char)(ushort)(&obj176);
			flag = flag176;
			if (!flag175)
			{
				nint num121 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9159 @ X8_v85 (Il2CppClass<System.Object[]>)+40]");
				c2 = '\0';
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag177 = ex40 == null;
				flag = (byte)(int)ex40 != 0;
				flag5 = flag142;
				flag102 = flag105;
				obj176 = obj164;
				obj173 = obj163;
				num118 = num29;
				flag163 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num78 = num115;
				text31 = (string)num115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9159 @ X8_v85 (Il2CppClass<System.Object[]>)+40]");
				num = 0;
				if (flag177)
				{
					goto IL_6514;
				}
			}
			bool flag178 = array2.Length < 4;
			object obj177 = !flag178;
			object obj178 = array2.Length - 4;
			bool flag179 = obj178 == null;
			object obj179 = ~obj177;
			object obj180 = obj179 | flag179;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			obj176 = obj164;
			obj173 = obj163;
			num118 = num29;
			flag163 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (obj180 != null)
			{
				goto IL_5ccb;
			}
			object obj181 = array2 + 64;
			obj181 = flag176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag180 = !flag181;
			c2 = (char)(ushort)(&num122);
			flag = flag181;
			if (!flag180)
			{
				nint num123 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8822 @ X8_v84 (Il2CppClass<System.Object[]>)+40]");
				c2 = '\0';
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag182 = ex56 == null;
				flag = (byte)(int)ex56 != 0;
				flag5 = flag142;
				flag102 = flag105;
				num122 = num114;
				obj176 = obj164;
				obj173 = obj163;
				num118 = num29;
				flag163 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num51 = num115;
				num24 = num23;
				text31 = (string)num115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8822 @ X8_v84 (Il2CppClass<System.Object[]>)+40]");
				num = 0;
				if (flag182)
				{
					goto IL_618b;
				}
			}
			bool flag183 = array2.Length < 5;
			object obj182 = !flag183;
			object obj183 = array2.Length - 5;
			bool flag184 = obj183 == null;
			object obj184 = ~obj182;
			object obj185 = obj184 | flag184;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			num122 = num114;
			obj176 = obj164;
			obj173 = obj163;
			num118 = num29;
			flag163 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (obj185 != null)
			{
				goto IL_5be1;
			}
			object obj186 = array2 + 72;
			obj186 = flag181;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag185 = !flag186;
			c2 = (char)(ushort)(&num124);
			flag = flag186;
			if (!flag185)
			{
				nint num125 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8956 @ X8_v83 (Il2CppClass<System.Object[]>)+40]");
				c2 = '\0';
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag187 = ex58 == null;
				flag = (byte)(int)ex58 != 0;
				flag5 = flag142;
				flag102 = flag105;
				num124 = num112;
				num122 = num114;
				obj176 = obj164;
				obj173 = obj163;
				num118 = num29;
				flag163 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num51 = num115;
				num24 = num23;
				text31 = (string)num115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8956 @ X8_v83 (Il2CppClass<System.Object[]>)+40]");
				num = 0;
				if (flag187)
				{
					goto IL_627b;
				}
			}
			bool flag188 = array2.Length < 6;
			object obj187 = !flag188;
			object obj188 = array2.Length - 6;
			bool flag189 = obj188 == null;
			object obj189 = ~obj187;
			object obj190 = obj189 | flag189;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			num124 = num112;
			num122 = num114;
			obj176 = obj164;
			obj173 = obj163;
			num118 = num29;
			flag163 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (obj190 != null)
			{
				goto IL_5d40;
			}
			object obj191 = array2 + 80;
			obj191 = flag186;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag190 = !flag191;
			formatProvider = (IFormatProvider)(&num126);
			flag = flag191;
			if (!flag190)
			{
				nint num127 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9052 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
				formatProvider = (IFormatProvider)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag192 = ex64 == null;
				flag = (byte)(int)ex64 != 0;
				flag5 = flag142;
				flag102 = flag105;
				num126 = num113;
				num124 = num112;
				num122 = num114;
				obj176 = obj164;
				obj173 = obj163;
				num118 = num29;
				flag163 = flag105;
				obj131 = obj163;
				obj133 = obj164;
				num56 = num112;
				num58 = num113;
				num60 = num114;
				num62 = num29;
				num104 = num30;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num78 = num115;
				text31 = (string)num115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9052 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
				formatProvider2 = (IFormatProvider)0;
				if (flag192)
				{
					goto IL_6404;
				}
			}
			object obj192 = array2.Length & 0xFFFFFFF8L;
			bool flag193 = obj192 == null;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag105;
			num126 = num113;
			num124 = num112;
			num122 = num114;
			obj176 = obj164;
			obj173 = obj163;
			num118 = num29;
			flag163 = flag105;
			obj132 = obj163;
			obj134 = obj164;
			num57 = num112;
			num59 = num113;
			num61 = num114;
			num63 = num29;
			num104 = num30;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = num115;
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			text31 = (string)num115;
			if (!flag193)
			{
				object obj193 = array2 + 88;
				obj193 = flag191;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				bool flag194 = !flag195;
				c2 = (char)(ushort)(&num128);
				flag = flag195;
				if (!flag194)
				{
					nint num129 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9275 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
					c2 = '\0';
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag196 = ex43 == null;
					flag = (byte)(int)ex43 != 0;
					flag5 = flag142;
					flag102 = flag105;
					num128 = num115;
					num126 = num113;
					num124 = num112;
					num122 = num114;
					obj176 = obj164;
					obj173 = obj163;
					num118 = num29;
					flag163 = flag105;
					obj131 = obj163;
					obj133 = obj164;
					num56 = num112;
					num58 = num113;
					num60 = num114;
					num62 = num29;
					num104 = num30;
					flag21 = false;
					resolved8 = (TickRate.Resolved)(&flag5);
					num78 = num115;
					text31 = (string)num115;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9275 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag196)
					{
						goto IL_6594;
					}
				}
				bool flag197 = array2.Length < 8;
				object obj194 = !flag197;
				object obj195 = array2.Length - 8;
				bool flag198 = obj195 == null;
				object obj196 = ~obj194;
				object obj197 = obj196 | flag198;
				num47 = num48;
				num49 = num50;
				num19 = num20;
				obj20 = obj21;
				flag5 = flag142;
				flag103 = flag105;
				num128 = num115;
				num126 = num113;
				num124 = num112;
				num122 = num114;
				obj176 = obj164;
				obj173 = obj163;
				num118 = num29;
				flag163 = flag105;
				obj132 = obj163;
				obj134 = obj164;
				num57 = num112;
				num59 = num113;
				num61 = num114;
				num63 = num29;
				num104 = num30;
				obj11 = obj10;
				resolved5 = resolved2;
				resolved6 = resolved3;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num35 = num115;
				num21 = num22;
				obj23 = obj29;
				obj17 = obj135;
				text31 = (string)num115;
				if (obj197 == null)
				{
					object obj198 = array2 + 96;
					obj198 = flag195;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB90]");
					object format = 0;
					FormattableString formattable = FormattableStringFactory.Create((string)format, array2);
					string text33 = FormattableString.Invariant(formattable);
					nint num130 = (nint)streamWriter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6823 @ X8_v80 (Il2CppClass<System.IO.StreamWriter>)+280]");
					text3 = (string)0;
					flag = (byte)(int)((Exception)(object)streamWriter).StackTrace != 0;
					obj17 = obj135 + 1;
					bool flag199 = !flag142;
					object obj199 = !flag199;
					num47 = num48;
					num49 = num50;
					num4 = num5;
					obj5 = obj22;
					flag103 = flag105;
					num128 = num115;
					num126 = num113;
					num124 = num112;
					num122 = num114;
					obj176 = obj164;
					obj173 = obj163;
					num118 = num29;
					flag163 = flag105;
					flag30 = flag105;
					obj132 = obj163;
					obj134 = obj164;
					num57 = num112;
					num59 = num113;
					num61 = num114;
					num63 = num29;
					num104 = num30;
					num6 = num7;
					resolved = (TickRate.Resolved)num115;
					num24 = num23;
					text11 = (string)num115;
					obj6 = obj24;
					c2 = (char)(int)text33;
					flag102 = flag105;
					num128 = num115;
					num126 = num113;
					num124 = num112;
					num122 = num114;
					obj176 = obj164;
					obj173 = obj163;
					num118 = num29;
					flag163 = flag105;
					obj131 = obj163;
					obj133 = obj164;
					num56 = num112;
					num58 = num113;
					num60 = num114;
					num62 = num29;
					num103 = num30;
					resolved4 = (TickRate.Resolved)num115;
					obj135 = obj17;
					text31 = (string)num115;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6823 @ X8_v80 (Il2CppClass<System.IO.StreamWriter>)+280]");
					text32 = (string)0;
					flag149 = flag142;
					if (obj199 != null)
					{
						continue;
					}
					goto IL_5456;
				}
				goto IL_5b6c;
			}
			goto IL_5dbd;
			IL_39ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num109 = (double?)(object)7;
			goto IL_833b;
			IL_833b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9286 @ X0_v181] (should have been resolved before IL gen)");
			bool flag200 = obj135 == null;
			object obj200 = !flag200;
			num48 = num84;
			num50 = num51;
			float num131;
			num5 = num131;
			flag105 = false;
			path = null;
			num23 = unchecked((nint)null);
			text = (string)num110;
			if (obj200 != null)
			{
				goto IL_82ca;
			}
			nint num132 = (nint)clientTimeProvider2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9298 @ X8_v111 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			object obj201 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9298 @ X8_v111 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_3ac0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9298 @ X8_v111 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
			object obj202 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9346 @ X10_v49-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9346 @ X10_v49-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj201--;
				obj24 = obj202 + 16;
				bool flag201 = (nint)obj201 != 1;
				obj202 = obj24;
				if (flag201)
				{
					continue;
				}
				goto IL_3ac0;
			}
			object obj203 = obj202 + 3;
			object obj204 = num132 + obj203;
			object obj205 = obj204 + 312;
			obj24 = obj202;
			goto IL_83d4;
			IL_3c03:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text3 = (string)5;
			goto IL_8508;
			IL_2db7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text3 = null;
			goto IL_8140;
			IL_8140:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7576 @ X0_v40+8]");
			c2 = '\0';
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7576 @ X0_v40] (should have been resolved before IL gen)");
			bool flag202 = text34 == null;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag102;
			obj132 = obj131;
			obj134 = obj133;
			num57 = num56;
			num59 = num58;
			num61 = num60;
			num63 = num62;
			num104 = num103;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num21 = num22;
			obj23 = obj29;
			obj17 = obj135;
			flag = (byte)(int)text34 != 0;
			if (flag202)
			{
				goto IL_5831;
			}
			string[] array3 = text34.Split(',', (StringSplitOptions)0);
			bool flag203 = array3 == null;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag102;
			obj132 = obj131;
			obj134 = obj133;
			num57 = num56;
			num59 = num58;
			num61 = num60;
			num63 = num62;
			num104 = num103;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num35 = (float)resolved4;
			num21 = num22;
			num23 = unchecked((nint)null);
			obj23 = obj29;
			obj17 = obj135;
			text3 = null;
			c2 = ',';
			flag = (byte)(int)array3 != 0;
			if (flag203)
			{
				goto IL_58ae;
			}
			object obj206 = array3.Length & 0xFFFFFFFEL;
			bool flag204 = obj206 == null;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag102;
			obj132 = obj131;
			obj134 = obj133;
			num57 = num56;
			num59 = num58;
			num61 = num60;
			num63 = num62;
			num104 = num103;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num21 = num22;
			num23 = unchecked((nint)null);
			obj23 = obj29;
			obj17 = obj135;
			text3 = null;
			c2 = ',';
			flag = (byte)(int)array3 != 0;
			if (flag204)
			{
				goto IL_57bc;
			}
			object obj207 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7758 @ X0_v44+E4]");
			bool flag205 = (nint)0 == 0;
			object obj208 = !flag205;
			if (obj208 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CultureInfo invariantCulture5 = CultureInfo.InvariantCulture;
			num35 = float.Parse(array3[1], (IFormatProvider)invariantCulture5);
			bool flag206 = array3.Length < 2;
			object obj209 = !flag206;
			object obj210 = array3.Length - 2;
			bool flag207 = obj210 == null;
			object obj211 = ~obj209;
			object obj212 = obj211 | flag207;
			num47 = num48;
			num49 = num50;
			num19 = num20;
			obj20 = obj21;
			flag5 = flag142;
			flag103 = flag102;
			obj132 = obj131;
			obj134 = obj133;
			num57 = num56;
			num59 = num58;
			num61 = num60;
			num63 = num62;
			num104 = num103;
			obj11 = obj10;
			resolved5 = resolved2;
			resolved6 = resolved3;
			flag21 = false;
			resolved8 = (TickRate.Resolved)(&flag5);
			num21 = num22;
			num23 = unchecked((nint)null);
			obj23 = obj29;
			obj17 = obj135;
			text3 = null;
			c2 = (char)(int)invariantCulture5;
			flag = (byte)(int)array3[1] != 0;
			if (obj212 != null)
			{
				goto IL_5923;
			}
			CultureInfo invariantCulture6 = CultureInfo.InvariantCulture;
			int num133 = int.Parse(array3[2], (IFormatProvider)invariantCulture6);
			float num135;
			if (num133 != 0)
			{
				bool flag208 = array3.Length < 4;
				object obj213 = !flag208;
				object obj214 = array3.Length - 4;
				bool flag209 = obj214 == null;
				object obj215 = ~obj213;
				object obj216 = obj215 | flag209;
				flag5 = flag142;
				num104 = num35;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num24 = unchecked((nint)null);
				text3 = null;
				formatProvider = (IFormatProvider)invariantCulture6;
				flag = (byte)num133 != 0;
				if (obj216 != null)
				{
					goto IL_5f37;
				}
				object obj217 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8168 @ X0_v153+E4]");
				bool flag210 = (nint)0 == 0;
				object obj218 = !flag210;
				if (obj218 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture7 = CultureInfo.InvariantCulture;
				num106 = int.Parse(array3[4], (IFormatProvider)invariantCulture7);
				bool flag211 = array3.Length < 5;
				object obj219 = !flag211;
				object obj220 = array3.Length - 5;
				bool flag212 = obj220 == null;
				object obj221 = ~obj219;
				object obj222 = obj221 | flag212;
				flag5 = flag142;
				num104 = num35;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num24 = unchecked((nint)null);
				text3 = null;
				formatProvider = (IFormatProvider)invariantCulture7;
				flag = (byte)num106 != 0;
				if (obj222 != null)
				{
					goto IL_5ec2;
				}
				text = array3[5];
				CultureInfo invariantCulture8 = CultureInfo.InvariantCulture;
				float num134 = float.Parse(array3[5], (IFormatProvider)invariantCulture8);
				bool flag213 = array3.Length < 6;
				object obj223 = !flag213;
				object obj224 = array3.Length - 6;
				bool flag214 = obj224 == null;
				object obj225 = ~obj223;
				object obj226 = obj225 | flag214;
				flag5 = flag142;
				num104 = num35;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num51 = num134;
				num24 = unchecked((nint)null);
				text3 = null;
				formatProvider = (IFormatProvider)invariantCulture8;
				flag = (byte)(int)array3[5] != 0;
				if (obj226 != null)
				{
					goto IL_6029;
				}
				text = array3[6];
				CultureInfo invariantCulture9 = CultureInfo.InvariantCulture;
				num135 = float.Parse(array3[6], (IFormatProvider)invariantCulture9);
				object obj227 = array3.Length & 0xFFFFFFF8L;
				bool flag215 = obj227 == null;
				flag5 = flag142;
				num62 = num134;
				num104 = num35;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num51 = num135;
				num24 = unchecked((nint)null);
				text3 = null;
				formatProvider = (IFormatProvider)invariantCulture9;
				flag = (byte)(int)array3[6] != 0;
				if (flag215)
				{
					goto IL_609e;
				}
				text = array3[7];
				CultureInfo invariantCulture10 = CultureInfo.InvariantCulture;
				num51 = float.Parse(array3[7], (IFormatProvider)invariantCulture10);
				bool flag216 = array3.Length < 8;
				object obj228 = !flag216;
				object obj229 = array3.Length - 8;
				bool flag217 = obj229 == null;
				object obj230 = ~obj228;
				object obj231 = obj230 | flag217;
				flag5 = flag142;
				num60 = num135;
				num62 = num134;
				num104 = num35;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num24 = unchecked((nint)null);
				text3 = null;
				formatProvider = (IFormatProvider)invariantCulture10;
				flag = (byte)(int)array3[7] != 0;
				if (obj231 != null)
				{
					goto IL_5fb4;
				}
				text = array3[8];
				CultureInfo invariantCulture11 = CultureInfo.InvariantCulture;
				num84 = float.Parse(array3[8], (IFormatProvider)invariantCulture11);
				bool flag218 = array3.Length < 9;
				object obj232 = !flag218;
				object obj233 = array3.Length - 9;
				bool flag219 = obj233 == null;
				object obj234 = ~obj232;
				object obj235 = obj234 | flag219;
				flag5 = flag142;
				num59 = num51;
				num61 = num135;
				num63 = num134;
				num104 = num35;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num24 = unchecked((nint)null);
				text3 = null;
				text16 = (string)(object)invariantCulture11;
				flag = (byte)(int)array3[8] != 0;
				if (obj235 != null)
				{
					goto IL_6640;
				}
				text = array3[9];
				CultureInfo invariantCulture12 = CultureInfo.InvariantCulture;
				num78 = float.Parse(array3[9], (IFormatProvider)invariantCulture12);
				bool flag220 = array3.Length < 10;
				object obj236 = !flag220;
				object obj237 = array3.Length - 10;
				bool flag221 = obj237 == null;
				object obj238 = ~obj236;
				object obj239 = obj238 | flag221;
				flag5 = flag142;
				num56 = num84;
				num58 = num51;
				num60 = num135;
				num62 = num134;
				num104 = num35;
				flag21 = false;
				resolved8 = (TickRate.Resolved)(&flag5);
				num23 = unchecked((nint)null);
				text3 = null;
				formatProvider2 = (IFormatProvider)invariantCulture12;
				flag = (byte)(int)array3[9] != 0;
				if (obj239 != null)
				{
					goto IL_638f;
				}
				CultureInfo invariantCulture13 = CultureInfo.InvariantCulture;
				num131 = float.Parse(array3[10], (IFormatProvider)invariantCulture13);
				num110 = num134;
				nint num136 = (nint)clientTimeProvider2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9075 @ X8_v105 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
				object obj240 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9075 @ X8_v105 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_38d8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9075 @ X8_v105 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
				object obj241 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9133 @ X10_v59-8]");
					obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9133 @ X10_v59-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj240--;
					obj24 = obj241 + 16;
					bool flag222 = (nint)obj240 != 1;
					obj241 = obj24;
					if (flag222)
					{
						continue;
					}
					goto IL_38d8;
				}
				object obj242 = obj241 + 6;
				object obj243 = num136 + obj242;
				object obj244 = obj243 + 312;
				obj24 = obj241;
				goto IL_825d;
			}
			bool flag223 = obj135 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAB60]");
			object error = 0;
			bool condition = !flag223;
			Assert.Always(condition, (string)error);
			num78 = num35;
			num23 = unchecked((nint)null);
			num109 = (double?)(object)0;
			goto IL_82ca;
			IL_3b64:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num109 = (double?)(object)0;
			goto IL_8462;
			IL_8462:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8553 @ X0_v54] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DABB8]");
			object error2 = 0;
			bool condition2 = (byte)(obj245 & 1) != 0;
			Assert.Always(condition2, (string)error2);
			nint num137 = (nint)clientTimeProvider2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8567 @ X8_v52 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			object obj246 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8567 @ X8_v52 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_3c03;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8567 @ X8_v52 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
			object obj247 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8675 @ X10_v36-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8675 @ X10_v36-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj246--;
				obj24 = obj247 + 16;
				bool flag224 = (nint)obj246 != 1;
				obj247 = obj24;
				if (flag224)
				{
					continue;
				}
				goto IL_3c03;
			}
			object obj248 = obj247 + 5;
			object obj249 = num137 + obj248;
			object obj250 = obj249 + 312;
			text3 = null;
			obj24 = obj247;
			goto IL_8508;
			IL_8508:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8736 @ X0_v58] (should have been resolved before IL gen)");
			nint num138 = (nint)clientTimeProvider2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8743 @ X8_v55 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			object obj251 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8743 @ X8_v55 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_3cb5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8743 @ X8_v55 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
			object obj252 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8794 @ X10_v31-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8794 @ X10_v31-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj251--;
				obj24 = obj252 + 16;
				bool flag225 = (nint)obj251 != 1;
				obj252 = obj24;
				if (flag225)
				{
					continue;
				}
				goto IL_3cb5;
			}
			object obj253 = obj252 + 10;
			object obj254 = num138 + obj253;
			object obj255 = obj254 + 312;
			obj24 = obj252;
			goto IL_8583;
			IL_83d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9372 @ X0_v184+8]");
			num109 = (double?)(object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9372 @ X0_v184] (should have been resolved before IL gen)");
			num48 = num84;
			num50 = num51;
			num5 = num131;
			flag105 = false;
			num78 = num135;
			path = null;
			num23 = unchecked((nint)null);
			text = (string)num110;
			goto IL_82ca;
			IL_3ac0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_83d4;
		}
		TickRate.Resolved resolved9 = (TickRate.Resolved)(&flag5);
		clientTimeProvider2 = (ClientTimeProvider)resolved9.Client;
		bool flag226 = resolved9.Client == 0;
		num = c2;
		if (flag226)
		{
			goto IL_86da;
		}
		nint num139 = (nint)clientTimeProvider2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7227 @ X8_v29 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
		object obj256 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7227 @ X8_v29 (Il2CppClass<Fusion.ClientTimeProvider>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_5544;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7227 @ X8_v29 (Il2CppClass<Fusion.ClientTimeProvider>)+98]");
		object obj257 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7393 @ X10_v16-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7393 @ X10_v16-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj256--;
			obj6 = obj257 + 16;
			bool flag227 = (nint)obj256 != 1;
			obj257 = obj6;
			if (flag227)
			{
				continue;
			}
			goto IL_5544;
		}
		object obj258 = num139 + obj257;
		object obj259 = obj258 + 312;
		obj6 = obj257;
		goto IL_873e;
		IL_5af7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag228 = num140 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag228)
		{
			IndexOutOfRangeException ex65 = new IndexOutOfRangeException();
			flag = (byte)(int)ex65 != 0;
			goto IL_5b6c;
		}
		goto IL_7a43;
		IL_7369:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag229 = num141 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag229)
		{
			IndexOutOfRangeException ex66 = new IndexOutOfRangeException();
			flag = (byte)(int)ex66 != 0;
			goto IL_73d6;
		}
		goto IL_7a43;
		IL_5a82:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag230 = num142 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag230)
		{
			IndexOutOfRangeException ex67 = new IndexOutOfRangeException();
			flag = (byte)(int)ex67 != 0;
			goto IL_5af7;
		}
		goto IL_7a43;
		IL_7902:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5440 @ X23_v61 (System.String)+28]");
		nint num143 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		if (num143 != 0)
		{
			goto IL_7a43;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num29 = 1f;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
				nint num144 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
				if (num144 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_7a43;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj260 = default;
			flag30 = (byte)(int)obj260 != 0;
		}
		path = text11;
		c2 = (char)num;
		obj130 = 0;
		path2 = text10;
		text = text12;
		goto IL_875d;
		IL_5a0d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num145 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag231 = num145 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag231)
		{
			NullReferenceException ex68 = new NullReferenceException();
			flag = (byte)(int)ex68 != 0;
			goto IL_5a82;
		}
		goto IL_7a43;
		IL_875d:
		object obj261 = num30;
		bool flag232 = num30 == 0f;
		num = c2;
		if (flag232)
		{
			goto IL_7f1b;
		}
		object obj262 = obj261;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6109 @ X8_v120+12E]");
		object obj263 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6109 @ X8_v120+12E]");
		if ((nint)0 == 0)
		{
			goto IL_283e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6109 @ X8_v120+98]");
		object obj264 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6187 @ X10_v82-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6187 @ X10_v82-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj263--;
			obj6 = obj264 + 16;
			bool flag233 = (nint)obj263 != 1;
			obj264 = obj6;
			if (flag233)
			{
				continue;
			}
			goto IL_283e;
		}
		object obj265 = obj262 + obj264;
		object obj266 = obj265 + 312;
		obj6 = obj264;
		goto IL_7f7b;
		IL_5998:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag234 = num146 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag234)
		{
			IndexOutOfRangeException ex69 = new IndexOutOfRangeException();
			flag = (byte)(int)ex69 != 0;
			goto IL_5a0d;
		}
		goto IL_7a43;
		IL_7f7b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6212 @ X0_v207+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6212 @ X0_v207] (should have been resolved before IL gen)");
		goto IL_7f1b;
		IL_638f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag235 = num147 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num78;
		num24 = num23;
		num = (int)formatProvider2;
		if (!flag235)
		{
			ex64 = new IndexOutOfRangeException();
			goto IL_6404;
		}
		goto IL_7a43;
		IL_7222:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num148 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag236 = num148 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag236)
		{
			NullReferenceException ex70 = new NullReferenceException();
			flag = (byte)(int)ex70 != 0;
			goto IL_728f;
		}
		goto IL_7a43;
		IL_6404:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num149 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag237 = num149 != 0;
		num47 = num48;
		num49 = num50;
		num4 = num5;
		num6 = num7;
		resolved = (TickRate.Resolved)num78;
		num24 = num23;
		num = (int)formatProvider2;
		if (!flag237)
		{
			ArgumentNullException ex63 = new ArgumentNullException();
			c4 = '\0';
			goto IL_648c;
		}
		goto IL_7a43;
		IL_6dd0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num150 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag238 = num150 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = c;
		if (!flag238)
		{
			IndexOutOfRangeException ex71 = new IndexOutOfRangeException();
			flag = (byte)(int)ex71 != 0;
			goto IL_6e3d;
		}
		goto IL_7a43;
		IL_73d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag239 = num151 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag239)
		{
			NullReferenceException ex72 = new NullReferenceException();
			flag = (byte)(int)ex72 != 0;
			goto IL_7443;
		}
		goto IL_7a43;
		IL_5456:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag240 = num152 != 0;
		num = c2;
		if (!flag240)
		{
			throw new NullReferenceException();
		}
		goto IL_7a43;
		IL_7443:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num153 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag241 = num153 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = resolved4;
		num = (int)text5;
		if (!flag241)
		{
			NullReferenceException ex73 = new NullReferenceException();
			flag = (byte)(int)ex73 != 0;
			goto IL_74b0;
		}
		goto IL_7a43;
		IL_5923:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3721 @ stack_-1B0_v47 (System.String)+28]");
		nint num154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG (System.String)+28]");
		bool flag242 = num154 != 0;
		num4 = num5;
		obj10 = obj11;
		num6 = num7;
		resolved = (TickRate.Resolved)num35;
		num24 = num23;
		num = c2;
		if (!flag242)
		{
			IndexOutOfRangeException ex74 = new IndexOutOfRangeException();
			flag = (byte)(int)ex74 != 0;
			goto IL_5998;
		}
		goto IL_7a43;
	}
}
