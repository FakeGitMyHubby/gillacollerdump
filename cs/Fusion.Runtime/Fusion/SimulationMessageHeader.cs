using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion.Sockets;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 32)]
internal struct SimulationMessageHeader
{
	[FieldOffset(0)]
	public SimulationMessageHeaderFlags Flags;

	[FieldOffset(4)]
	public int PayloadNumBytes;

	[FieldOffset(8)]
	public PlayerRef SourcePlayer;

	[FieldOffset(12)]
	public PlayerRef TargetPlayer;

	[FieldOffset(16)]
	public uint MessageType;

	[FieldOffset(20)]
	public NetworkBehaviourId TargetObject;

	[FieldOffset(16)]
	public ReliableKey ReliableKey;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_FLAGS = default(int);

	internal const int BYTE_COUNT_OF_FLAGS = default(int);

	internal const int BYTE_OF_PAYLOAD_NUM_BYTES = default(int);

	internal const int BYTE_COUNT_OF_PAYLOAD_NUM_BYTES = default(int);

	internal const int BYTE_OF_SOURCE_PLAYER = default(int);

	internal const int BYTE_COUNT_OF_SOURCE_PLAYER = default(int);

	internal const int BYTE_OF_TARGET_PLAYER = default(int);

	internal const int BYTE_COUNT_OF_TARGET_PLAYER = default(int);

	internal const int BYTE_OF_MESSAGE_TYPE = default(int);

	internal const int BYTE_COUNT_OF_MESSAGE_TYPE = default(int);

	internal const int BYTE_OF_TARGET_OBJECT = default(int);

	internal const int BYTE_COUNT_OF_TARGET_OBJECT = default(int);

	internal const int BYTE_OF_RELIABLE_KEY = default(int);

	internal const int BYTE_COUNT_OF_RELIABLE_KEY = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I8
		//IL_00ff: Expected Obj, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01ce: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I8
		//IL_0269: Expected Obj, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0328: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_039e: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03f7: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_046d: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array != null)
		{
			if (array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA898]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA888]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA8B8]");
				object format = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8430]");
				object arg = 0;
				object obj4 = array + 32;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object arg2 = default;
				string text = string.Format((string)format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X21_v6-8]");
				object obj5 = 0 & 0xFFFFFFFEL;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA8B0]");
					object arg3 = 0;
					object obj6 = array + 40;
					obj6 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object arg4 = default;
					string text2 = string.Format((string)format, arg3, arg4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X21_v8-10]");
					bool flag = (nint)0 < (nint)2;
					object obj8 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X21_v8-10]");
					object obj9 = -2;
					bool flag2 = obj9 == null;
					object obj10 = ~obj8;
					object obj11 = obj10 | flag2;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AD0]");
						object arg5 = 0;
						object obj13 = array + 48;
						obj13 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object arg6 = default;
						string text3 = string.Format((string)format, arg5, arg6);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X21_v10-18]");
						object obj14 = 0 & 0xFFFFFFFCL;
						if (obj14 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9AE0]");
							object arg7 = 0;
							object obj15 = array + 56;
							obj15 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object arg8 = default;
							string text4 = string.Format((string)format, arg7, arg8);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X21_v12-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj16 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X21_v12-20]");
							object obj17 = -4;
							bool flag4 = obj17 == null;
							object obj18 = ~obj16;
							object obj19 = obj18 | flag4;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C30]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA8A8]");
								object arg9 = 0;
								object obj21 = array + 64;
								obj21 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object arg10 = default;
								string text5 = string.Format((string)format, arg9, arg10);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X21_v14-28]");
								bool flag5 = (nint)0 < (nint)5;
								object obj22 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X21_v14-28]");
								object obj23 = -5;
								bool flag6 = obj23 == null;
								object obj24 = ~obj22;
								object obj25 = obj24 | flag6;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA8A0]");
									object format2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA890]");
									object arg11 = 0;
									object obj26 = array + 72;
									obj26 = text5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object arg12 = default;
									string text6 = string.Format((string)format2, arg11, arg12);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X21_v16-30]");
									bool flag7 = (nint)0 < (nint)6;
									object obj27 = !flag7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X21_v16-30]");
									object obj28 = -6;
									bool flag8 = obj28 == null;
									object obj29 = ~obj27;
									object obj30 = obj29 | flag8;
									if (obj30 == null)
									{
										object obj31 = array + 80;
										obj31 = text6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										return string.Concat(array);
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
	}

	public unsafe static bool TryRead(ReadBuffer buffer, out SimulationMessageHeader header)
	{
		//IL_034d: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got I4
		ref SimulationMessageHeader reference;
		if (buffer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			byte b = buffer.Byte();
			reference = ref *(SimulationMessageHeader*)b;
			int num = buffer.IntVar();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (PlayerRef.TryRead(buffer, out System.Runtime.CompilerServices.Unsafe.As<SimulationMessageHeader, PlayerRef>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref header, 8))))
			{
				object obj4 = header & 0x80000000L;
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v39+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef invalid = PlayerRef.Invalid;
				}
				else
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v34+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!PlayerRef.TryRead(buffer, out System.Runtime.CompilerServices.Unsafe.As<SimulationMessageHeader, PlayerRef>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref header, 12))))
					{
						goto IL_027c;
					}
				}
				object obj10 = header & 4;
				bool flag5 = obj10 == null;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					uint num2 = buffer.UInt();
					object obj12 = header & 0x40;
					bool flag6 = obj12 == null;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						_ = 0;
						return true;
					}
					uint num3 = buffer.UIntVar();
					int num4 = buffer.IntVar();
					return true;
				}
				int key = buffer.Int();
				int key2 = buffer.Int();
				int key3 = buffer.Int();
				int key4 = buffer.Int();
				ReliableKey reliableKey = ReliableKey.FromInts(key, key2, key3, key4);
				return true;
			}
			goto IL_027c;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_027c:
		reference = ref *(SimulationMessageHeader*)null;
		_ = 0;
		return false;
	}

	public unsafe static void Write(Fusion.Sockets.WriteBuffer buffer, [In] ref SimulationMessageHeader header)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected I4, but got VT
		//IL_006b: Expected Obj, but got I4
		//IL_009d: Expected VT, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_01f6: Expected VT, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0234: Expected VT, but got Ref
		//IL_024d: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		buffer.Byte((byte)(int)header);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X1 (Fusion.SimulationMessageHeader&)+4]");
		buffer.IntVar(0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X1 (Fusion.SimulationMessageHeader&)+8]");
		PlayerRef.Write(buffer, (PlayerRef)0);
		object obj4 = header & 0x80000000L;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = header & 0xFF;
			object obj7 = obj6 & 4;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				goto IL_0125;
			}
		}
		else
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X1 (Fusion.SimulationMessageHeader&)+C]");
			PlayerRef.Write(buffer, (PlayerRef)0);
			object obj11 = header & 4;
			if (obj11 == null)
			{
				goto IL_0125;
			}
		}
		ReliableKey reliableKey = (ReliableKey)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref header, 16));
		((ReliableKey*)reliableKey)->GetInts(out var key, out var key2, out var key3, out var key4);
		buffer.Int(key);
		buffer.Int(key2);
		buffer.Int(key3);
		buffer.Int(key4);
		return;
		IL_0125:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X1 (Fusion.SimulationMessageHeader&)+10]");
		buffer.UInt(0u);
		object obj12 = header & 0x40;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X1 (Fusion.SimulationMessageHeader&)+14]");
			buffer.UIntVar(0u);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X1 (Fusion.SimulationMessageHeader&)+18]");
			buffer.IntVar(0);
		}
	}
}
