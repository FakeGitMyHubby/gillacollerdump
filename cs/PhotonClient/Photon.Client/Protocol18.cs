using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Photon.Client.StructWrapping;

namespace Photon.Client;

public class Protocol18 : Protocol
{
	public enum GpType : byte
	{
		// error: enumerator has no value
		Unknown,
		// error: enumerator has no value
		Array,
		// error: enumerator has no value
		Boolean,
		// error: enumerator has no value
		Byte,
		// error: enumerator has no value
		ByteArray,
		// error: enumerator has no value
		ObjectArray,
		// error: enumerator has no value
		Short,
		// error: enumerator has no value
		Float,
		// error: enumerator has no value
		Dictionary,
		// error: enumerator has no value
		Double,
		// error: enumerator has no value
		Hashtable,
		// error: enumerator has no value
		Integer,
		// error: enumerator has no value
		IntegerArray,
		// error: enumerator has no value
		Long,
		// error: enumerator has no value
		String,
		// error: enumerator has no value
		StringArray,
		// error: enumerator has no value
		Custom,
		// error: enumerator has no value
		Null,
		// error: enumerator has no value
		EventData,
		// error: enumerator has no value
		OperationRequest,
		// error: enumerator has no value
		OperationResponse
	}

	private readonly byte[] versionBytes;

	private static readonly byte[] boolMasks;

	private readonly double[] memDoubleBlock;

	private readonly float[] memFloatBlock;

	private readonly byte[] memCustomTypeBodyLengthSerialized;

	private readonly byte[] memCompressedUInt32;

	private byte[] memCompressedUInt64;

	public override string ProtocolType
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516748]");
			return (string)0;
		}
	}

	public override byte[] VersionBytes => versionBytes;

	public override void Serialize(StreamBuffer dout, object serObject, bool setType)
	{
		Write(dout, serObject, setType);
	}

	public override void SerializeShort(StreamBuffer dout, short serObject, bool setType)
	{
		WriteInt16(dout, serObject, setType);
	}

	public override void SerializeString(StreamBuffer dout, string serObject, bool setType)
	{
		WriteString(dout, serObject, setType);
	}

	public override object Deserialize(StreamBuffer din, byte type, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags))
	{
		return Read(din, type, (Protocol16.DeserializationFlags)0);
	}

	public override short DeserializeShort(StreamBuffer din)
	{
		return ReadInt16(din);
	}

	public override byte DeserializeByte(StreamBuffer din)
	{
		//IL_003d: Expected I4, but got Obj
		if (din != null)
		{
			return din.ReadByte();
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex;
	}

	private static Type GetAllowedDictionaryKeyTypes(SocketTcpAsync.GpType gpType)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		object obj = gpType & (SocketTcpAsync.GpType)0xFF;
		object obj2 = obj - 3;
		bool flag = (nint)obj2 < 31;
		object obj3 = !flag;
		object obj4 = obj2 - 31;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		if (obj6 == null)
		{
			object obj7 = 18214912 + 3246;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X9_v2+v8 @ X8_v2]");
			object obj8 = (nint)86070212 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v24 @ X10_v2 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format = default;
		object arg = default;
		string message = string.Format(format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Exception ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		return (Type)(object)new ArgumentNullException();
	}

	private static Type GetClrArrayType(SocketTcpAsync.GpType gpType)
	{
		//IL_00bf: Expected Obj, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_004e: Expected VT, but got Obj
		SocketTcpAsync.GpType gpType2 = default;
		object obj = gpType2 & (SocketTcpAsync.GpType)0xFF;
		object obj2 = obj - 2;
		bool flag = (nint)obj2 < 72;
		object obj3 = !flag;
		object obj4 = obj2 - 72;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		if (obj6 == null)
		{
			object obj7 = 18214912 + 3278;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X10_v2+v36 @ X9_v1]");
			object obj8 = (nint)86070724 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X11_v2 (should have been resolved before IL gen)");
		}
		else if ((nint)obj == 85)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5+E8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516C60]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v2+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Type.GetTypeFromHandle((RuntimeTypeHandle)obj11);
		}
		return null;
	}

	private SocketTcpAsync.GpType GetCodeOfType(Type type)
	{
		//IL_0e0b: Expected Obj, but got I
		//IL_0e1b: Expected Obj, but got I
		//IL_0e3d: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_00b5: Expected VT, but got Obj
		//IL_0112: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_016e: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_0294: Expected VT, but got I
		//IL_0527: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I
		//IL_0559: Expected Obj, but got I4
		//IL_057f: Expected VT, but got Obj
		//IL_0314: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I4
		//IL_037a: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_05d4: Expected Obj, but got I
		//IL_05e4: Expected Obj, but got I
		//IL_0606: Expected Obj, but got I4
		//IL_062c: Expected VT, but got Obj
		//IL_03cc: Expected Obj, but got I4
		//IL_0660: Expected Obj, but got I4
		//IL_0dfb: Expected I4, but got Obj
		//IL_03e8: Expected Obj, but got I4
		//IL_0676: Expected I, but got Obj
		//IL_0686: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_09a4: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I
		//IL_09d6: Expected Obj, but got I4
		//IL_0794: Expected Obj, but got I
		//IL_07b6: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I4
		//IL_09fc: Expected VT, but got Obj
		//IL_06c9: Expected Obj, but got I
		//IL_06d9: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I4
		//IL_07e9: Expected VT, but got I
		//IL_0803: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I4
		//IL_0721: Expected VT, but got Obj
		//IL_0732: Expected Obj, but got I4
		//IL_0a75: Expected Obj, but got I
		//IL_0a85: Expected Obj, but got I
		//IL_0aa7: Expected Obj, but got I4
		//IL_0760: Expected Obj, but got I4
		//IL_0847: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got I4
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I4
		//IL_0acd: Expected VT, but got Obj
		//IL_089c: Expected VT, but got I
		//IL_08b6: Expected Obj, but got I4
		//IL_0a50: Expected Obj, but got I4
		//IL_08d9: Expected Obj, but got I4
		//IL_0bd4: Expected Obj, but got I
		//IL_0be4: Expected Obj, but got I
		//IL_0c06: Expected Obj, but got I4
		//IL_0c2c: Expected VT, but got Obj
		//IL_08f7: Expected Obj, but got I
		//IL_0907: Expected Obj, but got I
		//IL_0929: Expected Obj, but got I4
		//IL_0c60: Expected Obj, but got I4
		//IL_094f: Expected VT, but got Obj
		//IL_0960: Expected Obj, but got I4
		//IL_0b22: Expected Obj, but got I
		//IL_0b32: Expected Obj, but got I
		//IL_0b54: Expected Obj, but got I4
		//IL_0b7a: Expected VT, but got Obj
		//IL_0b8b: Expected Obj, but got I4
		//IL_0ca4: Expected Obj, but got I4
		//IL_0bbf: Expected I4, but got Obj
		//IL_0cd5: Expected Obj, but got I
		//IL_0ce5: Expected Obj, but got I
		//IL_0d07: Expected Obj, but got I4
		//IL_0d2d: Expected VT, but got Obj
		//IL_0d3a: Expected Obj, but got I4
		//IL_0d3e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (type == null)
		{
			return (SocketTcpAsync.GpType)8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516C68]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj5);
		if (type == typeFromHandle)
		{
			return (SocketTcpAsync.GpType)0;
		}
		bool flag3 = (object)type == null;
		object obj7 = 0;
		Type type2 = typeFromHandle;
		if (!flag3)
		{
			bool isPrimitive = type.IsPrimitive;
			bool flag4 = !isPrimitive;
			object obj8 = !flag4;
			object obj9 = 0;
			if (obj8 == null)
			{
				nint num = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v11 (Il2CppClass<System.Type>)+5A0]");
				obj9 = 0;
				MemberInfo[] members = ((System.RuntimeType)type).GetMembers((BindingFlags)0);
				object obj10 = members & 1;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v40+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+98]");
					RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
					if (type == typeFromHandle2)
					{
						return (SocketTcpAsync.GpType)7;
					}
					if (type.IsArray)
					{
						nint num2 = (nint)type;
						bool isEnum = ((System.RuntimeType)type).IsEnum;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v31+E4]");
						bool flag6 = (nint)0 == 0;
						object obj14 = !flag6;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = (Type)isEnum == null;
						bool flag8 = !flag7;
						object obj15 = !flag8;
						obj7 = 0;
						type2 = null;
						if (obj15 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							string format = default;
							string message = string.Format(format, type);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							InvalidDataException ex = default;
							ex._002Ector(message);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentNullException ex2 = new ArgumentNullException();
							return (SocketTcpAsync.GpType)(int)ex2;
						}
						bool flag9 = !isEnum;
						obj7 = 0;
						type2 = null;
						if (flag9)
						{
							goto IL_0d8d;
						}
						if (((Type)isEnum).IsPrimitive)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v159+E4]");
							bool flag10 = (nint)0 == 0;
							object obj17 = !flag10;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							TypeCode typeCode = Type.GetTypeCode((Type)isEnum);
							object obj18 = typeCode - 3;
							bool flag11 = (nint)obj18 < 12;
							object obj19 = !flag11;
							if (obj19 == null)
							{
								object obj20 = 3417 >> (int)obj18;
								object obj21 = obj20 & 1;
								bool flag12 = obj21 == null;
								object obj22 = !flag12;
								if (obj22 != null)
								{
									object obj23 = 18214912 + 3408;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X9_v29+v202 @ X8_v45]");
									return (SocketTcpAsync.GpType)0;
								}
							}
						}
						if (((Type)isEnum).IsArray)
						{
							return (SocketTcpAsync.GpType)64;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v114+E4]");
						bool flag13 = (nint)0 == 0;
						object obj25 = !flag13;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+98]");
						RuntimeTypeHandle handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
						Type typeFromHandle3 = Type.GetTypeFromHandle(handle2);
						if ((Type)isEnum == typeFromHandle3)
						{
							return (SocketTcpAsync.GpType)71;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v120+E4]");
						bool flag14 = (nint)0 == 0;
						object obj27 = !flag14;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+10]");
						RuntimeTypeHandle handle3 = (RuntimeTypeHandle)((nint)0 + (nint)32);
						Type typeFromHandle4 = Type.GetTypeFromHandle(handle3);
						bool flag15 = (Type)isEnum == typeFromHandle4;
						bool flag16 = !flag15;
						object obj28 = !flag16;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516C70]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v126+E4]");
							bool flag17 = (nint)0 == 0;
							object obj31 = !flag17;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj30);
							if (!((Type)isEnum == typeFromHandle5))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A10]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v132+E4]");
								bool flag18 = (nint)0 == 0;
								object obj34 = !flag18;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj33);
								if ((Type)isEnum == typeFromHandle6)
								{
									return (SocketTcpAsync.GpType)(int)typeof(_0021_00210);
								}
								nint num3 = (isEnum ? 1 : 0);
								if (((Type)isEnum).IsExplicitLayout)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
									object obj35 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8428]");
									object obj36 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v142+E4]");
									bool flag19 = (nint)0 == 0;
									object obj37 = !flag19;
									if (obj37 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj36);
									Type type3 = (Type)((Type)isEnum).IsMarshalByRefImpl();
									if (typeFromHandle7 == type3)
									{
										return (SocketTcpAsync.GpType)84;
									}
								}
								return (SocketTcpAsync.GpType)83;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A10]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v50+E4]");
						bool flag20 = (nint)0 == 0;
						object obj40 = !flag20;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle8 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj39);
						if (type == typeFromHandle8)
						{
							return (SocketTcpAsync.GpType)21;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
						object obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6503F78]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v56+E4]");
						bool flag21 = (nint)0 == 0;
						object obj43 = !flag21;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle9 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj42);
						bool flag22 = type == typeFromHandle9;
						bool flag23 = !flag22;
						object obj44 = !flag23;
						if (obj44 == null)
						{
							nint num4 = (nint)type;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v18 (Il2CppClass<System.Type>)+3C0]");
							Type type4 = (Type)0;
							bool isExplicitLayout = type.IsExplicitLayout;
							bool flag24 = !isExplicitLayout;
							object obj45 = 0;
							if (!flag24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
								object obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8428]");
								object obj47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v91+E4]");
								bool flag25 = (nint)0 == 0;
								object obj48 = !flag25;
								if (obj48 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Type typeFromHandle10 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj47);
								Type type5 = (Type)type.IsMarshalByRefImpl();
								bool flag26 = typeFromHandle10 == type5;
								bool flag27 = !flag26;
								obj45 = 0;
								type4 = type5;
								if (!flag27)
								{
									return (SocketTcpAsync.GpType)20;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
							object obj49 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65169F8]");
							object obj50 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v65+E4]");
							bool flag28 = (nint)0 == 0;
							object obj51 = !flag28;
							if (obj51 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle11 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj50);
							if (type == typeFromHandle11)
							{
								return (SocketTcpAsync.GpType)26;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
							object obj52 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A00]");
							object obj53 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v71+E4]");
							bool flag29 = (nint)0 == 0;
							object obj54 = !flag29;
							if (obj54 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle12 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj53);
							if (type == typeFromHandle12)
							{
								return (SocketTcpAsync.GpType)24;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
							object obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A08]");
							object obj56 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v77+E4]");
							bool flag30 = (nint)0 == 0;
							object obj57 = !flag30;
							if (obj57 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle13 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj56);
							bool flag31 = type == typeFromHandle13;
							bool flag32 = !flag31;
							object obj58 = !flag32;
							object obj59 = ~obj58;
							if (obj59 == null)
							{
								return (SocketTcpAsync.GpType)25;
							}
							return (SocketTcpAsync.GpType)0;
						}
					}
					return (SocketTcpAsync.GpType)23;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v32+E4]");
			bool flag33 = (nint)0 == 0;
			object obj61 = !flag33;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TypeCode typeCode2 = Type.GetTypeCode(type);
			return ((Protocol18)typeCode2).GetCodeOfTypeCode(typeCode2);
		}
		goto IL_0d8d;
		IL_0d8d:
		throw new NullReferenceException();
	}

	private SocketTcpAsync.GpType GetCodeOfTypeCode(TypeCode type)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		object obj = type - 3;
		bool flag = (nint)obj < 15;
		object obj2 = !flag;
		object obj3 = obj - 15;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 17293312 + 2720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1]");
			return (SocketTcpAsync.GpType)0;
		}
		return (SocketTcpAsync.GpType)0;
	}

	private object Read(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		if (stream != null)
		{
			byte gpType = stream.ReadByte();
			return Read(stream, gpType, flags, parameters);
		}
		return new NullReferenceException();
	}

	private object Read(StreamBuffer stream, byte gpType, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags), ParameterDictionary parameters = null)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		if (4294967268L < (int)gpType)
		{
			int num = gpType & 0xFF;
			object obj = num - 2;
			bool flag = (nint)obj < 83;
			object obj2 = !flag;
			object obj3 = obj - 83;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 18214912 + 3078;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v2+v62 @ X8_v5*2]");
				object obj7 = (nint)86067872 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v85 @ X10_v2 (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			int position = stream.Position;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			int available = stream.Available;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			object arg2 = default;
			object arg3 = default;
			string message = string.Format(format, arg, arg2, arg3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidDataException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			return new ArgumentNullException();
		}
		return ReadCustomType(stream, gpType);
	}

	internal bool ReadBoolean(StreamBuffer stream)
	{
		//IL_0065: Expected I4, but got Obj
		if (stream != null)
		{
			byte b = stream.ReadByte();
			int num = b & 0xFF;
			bool flag = num == 0;
			return !flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	internal byte ReadByte(StreamBuffer stream)
	{
		//IL_003d: Expected I4, but got Obj
		if (stream != null)
		{
			return stream.ReadByte();
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex;
	}

	internal short ReadInt16(StreamBuffer stream)
	{
		//IL_00fc: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		if (stream != null)
		{
			byte[] bufferAndAdvance = stream.GetBufferAndAdvance(2, out var offset);
			object obj = offset + 1;
			if (bufferAndAdvance != null)
			{
				bool flag = offset < bufferAndAdvance.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					bool flag2 = (nint)obj < bufferAndAdvance.Length;
					object obj3 = !flag2;
					if (obj3 == null)
					{
						object obj4 = bufferAndAdvance + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v3+v6 @ stack_-4_v4 (System.Int32)]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v3+v13 @ X9_v3]");
						return (short)(num | 0);
					}
				}
				goto IL_00ee;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ee;
		IL_00ee:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (short)(int)ex2;
	}

	internal ushort ReadUShort(StreamBuffer stream)
	{
		//IL_00fc: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		if (stream != null)
		{
			byte[] bufferAndAdvance = stream.GetBufferAndAdvance(2, out var offset);
			object obj = offset + 1;
			if (bufferAndAdvance != null)
			{
				bool flag = offset < bufferAndAdvance.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					bool flag2 = (nint)obj < bufferAndAdvance.Length;
					object obj3 = !flag2;
					if (obj3 == null)
					{
						object obj4 = bufferAndAdvance + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v3+v6 @ stack_-4_v4 (System.Int32)]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v3+v13 @ X9_v3]");
						return (ushort)(num | 0);
					}
				}
				goto IL_00ee;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ee;
		IL_00ee:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (ushort)(int)ex2;
	}

	internal int ReadInt32(StreamBuffer stream)
	{
		//IL_01bc: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected I4, but got Unknown
		if (stream != null)
		{
			byte[] bufferAndAdvance = stream.GetBufferAndAdvance(4, out var offset);
			object obj = offset + 1;
			if (bufferAndAdvance != null)
			{
				bool flag = offset < bufferAndAdvance.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = bufferAndAdvance + offset;
					bool flag2 = (nint)obj < bufferAndAdvance.Length;
					object obj4 = !flag2;
					object obj5 = offset + 2;
					if (obj4 == null)
					{
						object obj6 = (object)bufferAndAdvance + obj;
						object obj7 = offset + 3;
						bool flag3 = (nint)obj5 < bufferAndAdvance.Length;
						object obj8 = !flag3;
						if (obj8 == null)
						{
							bool flag4 = (nint)obj7 < bufferAndAdvance.Length;
							object obj9 = !flag4;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X9_v3+20]");
								object obj10 = (nint)0 << 24;
								object obj11 = bufferAndAdvance + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X12_v4+20]");
								object obj12 = obj10 | 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X11_v3+v134 @ X9_v4]");
								object obj13 = obj12 | 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X11_v3+v144 @ X8_v4]");
								return obj13 | 0;
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
	}

	internal long ReadInt64(StreamBuffer stream)
	{
		//IL_0320: Expected I8, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected I8, but got Unknown
		if (stream != null)
		{
			byte[] bufferAndAdvance = stream.GetBufferAndAdvance(8, out var offset);
			object obj = offset + 1;
			if (bufferAndAdvance != null)
			{
				bool flag = offset < bufferAndAdvance.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = bufferAndAdvance + offset;
					object obj4 = offset + 2;
					bool flag2 = (nint)obj < bufferAndAdvance.Length;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						object obj6 = (object)bufferAndAdvance + obj;
						object obj7 = offset + 3;
						bool flag3 = (nint)obj4 < bufferAndAdvance.Length;
						object obj8 = !flag3;
						if (obj8 == null)
						{
							object obj9 = (object)bufferAndAdvance + obj4;
							object obj10 = offset + 4;
							bool flag4 = (nint)obj7 < bufferAndAdvance.Length;
							object obj11 = !flag4;
							if (obj11 == null)
							{
								object obj12 = (object)bufferAndAdvance + obj7;
								object obj13 = offset + 5;
								bool flag5 = (nint)obj10 < bufferAndAdvance.Length;
								object obj14 = !flag5;
								if (obj14 == null)
								{
									object obj15 = (object)bufferAndAdvance + obj10;
									bool flag6 = (nint)obj13 < bufferAndAdvance.Length;
									object obj16 = !flag6;
									object obj17 = offset + 6;
									if (obj16 == null)
									{
										object obj18 = (object)bufferAndAdvance + obj13;
										object obj19 = offset + 7;
										bool flag7 = (nint)obj17 < bufferAndAdvance.Length;
										object obj20 = !flag7;
										if (obj20 == null)
										{
											bool flag8 = (nint)obj19 < bufferAndAdvance.Length;
											object obj21 = !flag8;
											if (obj21 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v3+20]");
												object obj22 = (nint)0 << 56;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v4+20]");
												object obj23 = obj22 | 0;
												object obj24 = bufferAndAdvance + 32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X12_v4+20]");
												object obj25 = obj23 | 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X13_v4+20]");
												object obj26 = obj25 | 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X14_v4+20]");
												object obj27 = obj26 | 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X16_v4+20]");
												object obj28 = obj27 | 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v6+v106 @ X14_v5]");
												object obj29 = obj28 | 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v6+v200 @ X9_v4]");
												return obj29 | 0;
											}
										}
									}
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (long)ex2;
	}

	internal float ReadSingle(StreamBuffer stream)
	{
		byte[] bufferAndAdvance = stream.GetBufferAndAdvance(4, out var offset);
		return BitConverter.ToSingle(bufferAndAdvance, offset);
	}

	internal double ReadDouble(StreamBuffer stream)
	{
		byte[] bufferAndAdvance = stream.GetBufferAndAdvance(8, out var offset);
		return BitConverter.ToDouble(bufferAndAdvance, offset);
	}

	internal ByteArraySlice ReadNonAllocByteArray(StreamBuffer stream)
	{
		uint num = ReadCompressedUInt32(stream);
		if (ByteArraySlicePool != null)
		{
			ByteArraySlice byteArraySlice = ByteArraySlicePool.Acquire((int)num);
			if (byteArraySlice != null && stream != null)
			{
				int num2 = stream.Read(byteArraySlice.Buffer, 0, (int)num);
				byteArraySlice.Count = (int)num;
				return byteArraySlice;
			}
		}
		return (ByteArraySlice)(object)new NullReferenceException();
	}

	internal byte[] ReadByteArray(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		uint count = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (stream != null)
		{
			byte[] array = default;
			int num = stream.Read(array, 0, (int)count);
			return array;
		}
		return (byte[])(object)new NullReferenceException();
	}

	public unsafe object ReadCustomType(StreamBuffer stream, byte gpType = default(byte))
	{
		//IL_0017: Expected I4, but got I8
		//IL_0625: Expected Obj, but got I4
		//IL_063b: Expected I4, but got I8
		//IL_047d: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_0509: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_0147: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I4
		//IL_0682: Expected Obj, but got I
		//IL_0191: Expected I, but got Obj
		//IL_0407: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01ae: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got Ref
		//IL_0564: Expected Obj, but got I
		//IL_0596: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_05da: Expected I, but got Obj
		//IL_0304: Expected Obj, but got I4
		int num;
		System.__Canon value;
		byte b3 = default;
		byte b = default;
		bool flag;
		byte b2;
		if ((b & 0xFF) != 0)
		{
			num = (int)((int)b ^ 0xFFFFFF80L);
		}
		else
		{
			flag = stream == null;
			value = null;
			b2 = b;
			if (flag)
			{
				goto IL_0462;
			}
			b3 = stream.ReadByte();
			num = b3;
		}
		uint num2 = ((Protocol18)b3).ReadCompressedUInt32(stream);
		int num3 = (int)((int)num2 & 0x80000000L);
		bool flag2 = num3 == 0;
		flag = !flag2;
		value = null;
		b2 = (byte)num2;
		int available;
		UnknownType result;
		System.__Canon _Canon;
		byte b6;
		nint num7;
		object obj6;
		string text2;
		byte b5;
		if (!flag)
		{
			flag = stream == null;
			value = null;
			b2 = (byte)num2;
			if (!flag)
			{
				available = stream.Available;
				int num4 = (int)num2 >> 15;
				bool flag3 = num4 == 0;
				object obj = !flag3;
				value = null;
				byte b4 = 0;
				if (obj == null)
				{
					object obj2 = (int)num2 - available;
					bool flag4 = obj2 == null;
					bool flag5 = (int)num2 > available;
					value = null;
					b4 = 0;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
						UnknownType unknownType = (UnknownType)0;
						nint num5 = (nint)unknownType;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v21 (Il2CppClass<Photon.Client.UnknownType>)+E4]");
						bool flag6 = (nint)0 == 0;
						object obj3 = !flag6;
						nint num6 = num5;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num6 = (nint)unknownType;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v22 (Il2CppClass<Photon.Client.UnknownType>)+A0]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v11+8]");
						flag = (nint)0 == 0;
						value = null;
						b2 = (byte)num2;
						if (!flag)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65169C8]");
							object obj5 = 0;
							num7 = (nint)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v11+8]");
							bool flag7 = ((Dictionary<byte, System.__Canon>)0).TryGetValue((byte)num, out value);
							bool flag8 = !flag7;
							b = (byte)(&value);
							b4 = (byte)num;
							if (flag8)
							{
								goto IL_034f;
							}
							flag = 0 == 0;
							b = (byte)(&value);
							b2 = (byte)num2;
							if (!flag)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ stack_-38_v8 (System.__Canon)+28]");
								flag = (nint)0 == 0;
								obj6 = (object)(&value);
								b5 = (byte)num;
								_Canon = null;
								if (flag)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X21_v8 (System.__Canon)+18]");
									string format = default;
									object arg = default;
									string text = string.Format(format, 0, arg);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									NullReferenceException ex = default;
									ex._002Ector(text);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ stack_-38_v8 (System.__Canon)+10]");
									b6 = 0;
									num7 = unchecked((nint)null);
									obj6 = null;
									text2 = text;
									goto IL_051e;
								}
								int position = stream.Position;
								flag = 0 == 0;
								b = (byte)(&value);
								b2 = (byte)num2;
								if (!flag)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ stack_-38_v8 (System.__Canon)+28]");
									object obj8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ stack_-38_v8 (System.__Canon)+28]");
									flag = (nint)0 == 0;
									b = (byte)(&value);
									b2 = (byte)num2;
									if (!flag)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X8_v16+18] (should have been resolved before IL gen)");
										int position2 = stream.Position;
										object obj9 = position2 - position;
										bool flag9 = (nint)obj9 == (int)num2;
										UnknownType unknownType2 = default;
										result = unknownType2;
										if (!flag9)
										{
											int position3 = position + (int)num2;
											stream.Position = position3;
											result = unknownType2;
										}
										goto IL_045d;
									}
								}
							}
						}
						goto IL_0462;
					}
				}
				goto IL_034f;
			}
			goto IL_0462;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		_Canon = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		int position4 = stream.Position;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format2 = default;
		object arg2 = default;
		object obj10 = default;
		string text3 = string.Format(format2, arg2, obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidDataException ex2 = default;
		ex2._002Ector(text3);
		b6 = b2;
		num7 = unchecked((nint)null);
		obj6 = obj10;
		text2 = text3;
		goto IL_051e;
		IL_0462:
		throw new NullReferenceException();
		IL_045d:
		return result;
		IL_034f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516C88]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnknownType unknownType3 = default;
		unknownType3._002Ector();
		flag = unknownType3 == null;
		b2 = (byte)num2;
		if (!flag)
		{
			unknownType3.TypeCode = (byte)num;
			unknownType3.Size = (int)num2;
			bool flag10 = (int)num2 <= available;
			int num8 = (int)num2;
			if (!flag10)
			{
				int available2 = stream.Available;
				num8 = available2;
			}
			bool flag11 = num8 < 1;
			result = unknownType3;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				byte[] array = default;
				int num9 = stream.Read(array, 0, num8);
				object obj13 = unknownType3 + 24;
				obj13 = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = unknownType3;
			}
			goto IL_045d;
		}
		goto IL_0462;
		IL_051e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		byte b7 = default;
		b5 = b7;
		throw new ArgumentNullException();
	}

	public override EventData DeserializeEventData(StreamBuffer din, EventData target = null, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags))
	{
		//IL_0053: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I4
		//IL_02c2: Expected I, but got Obj
		//IL_023b: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I4
		//IL_0364: Expected Obj, but got I4
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected I4, but got Unknown
		//IL_043b: Expected Obj, but got I4
		//IL_0409: Expected I, but got Obj
		EventData eventData2;
		EventData eventData = default;
		if (eventData != null)
		{
			eventData.Reset();
			bool flag = din == null;
			object obj = !flag;
			eventData2 = eventData;
			if (obj != null)
			{
				goto IL_0090;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A68]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			EventData eventData3 = default;
			eventData3._002Ector();
			bool flag2 = din == null;
			eventData2 = eventData3;
			if (!flag2)
			{
				goto IL_0090;
			}
		}
		goto IL_0485;
		IL_0485:
		return (EventData)(object)new NullReferenceException();
		IL_0480:
		return eventData2;
		IL_0090:
		byte code = din.ReadByte();
		if (eventData2 != null)
		{
			eventData2.Code = code;
			byte b = din.ReadByte();
			int num = b & 0xFF;
			if (num == 0)
			{
				goto IL_0480;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516D08]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj3 = 0;
			nint num8 = default;
			object arg = default;
			while (true)
			{
				byte b2 = din.ReadByte();
				byte b3 = din.ReadByte();
				int sender;
				EventData eventData4;
				if (eventData2.SenderKey == b2)
				{
					int num2 = b3 & 0xFF;
					if (num2 <= 12)
					{
						if (num2 != 9)
						{
							if (num2 != 11)
							{
								if (num2 != 12)
								{
									goto IL_039a;
								}
								byte b4 = din.ReadByte();
								sender = -b4;
							}
							else
							{
								byte b5 = din.ReadByte();
								sender = b5 & 0xFF;
							}
						}
						else
						{
							uint num3 = ((Protocol18)b3).ReadCompressedUInt32(din);
							int num4 = (int)(num3 & 1);
							object obj4 = -num4;
							sender = (int)(obj4 ^ num3);
						}
					}
					else if (num2 != 13)
					{
						if (num2 != 14)
						{
							if (num2 != 30)
							{
								goto IL_039a;
							}
							sender = 0;
							eventData4 = eventData2;
							goto IL_04bd;
						}
						ushort num5 = ((Protocol18)b3).ReadUShort(din);
						sender = -num5;
					}
					else
					{
						ushort num6 = ((Protocol18)b3).ReadUShort(din);
						sender = num6 & 0xFFFF;
					}
					eventData4 = eventData2;
					goto IL_04bd;
				}
				object obj5 = flags & (Protocol16.DeserializationFlags)1;
				ParameterDictionary parameterDictionary;
				object obj6;
				if (obj5 != null)
				{
					int num7 = b3 & 0xFF;
					if (num7 == 67)
					{
						ByteArraySlice byteArraySlice = ReadNonAllocByteArray(din);
						parameterDictionary = (ParameterDictionary)num8;
						obj6 = byteArraySlice;
						goto IL_0279;
					}
				}
				parameterDictionary = eventData2.Parameters;
				obj6 = Read(din, b3, flags, eventData2.Parameters);
				goto IL_0279;
				IL_04bd:
				eventData4.Sender = sender;
				eventData = null;
				goto IL_0452;
				IL_0452:
				num--;
				if (num != 1)
				{
					continue;
				}
				goto IL_0480;
				IL_0279:
				if (eventData2.Parameters == null)
				{
					break;
				}
				eventData2.Parameters.Add(b2, obj6);
				eventData = (EventData)obj6;
				num8 = (nint)parameterDictionary;
				goto IL_0452;
				IL_039a:
				object obj7 = Read(din, b3, flags, eventData2.Parameters);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				string message = string.Format((string)format, arg, obj7);
				Debug.WriteLine(message);
				byte b6 = b3;
				eventData = (EventData)obj7;
				num8 = (nint)eventData2.Parameters;
				goto IL_0452;
			}
		}
		goto IL_0485;
	}

	private ParameterDictionary ReadParameterDictionary(StreamBuffer stream, ParameterDictionary target = null, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags))
	{
		//IL_00f4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68D55CF]");
		int num = 0;
		ParameterDictionary parameterDictionary;
		if (stream != null)
		{
			byte b = stream.ReadByte();
			int num2;
			if (target != null)
			{
				num2 = b & 0xFF;
				parameterDictionary = target;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3058]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				num2 = b & 0xFF;
				ParameterDictionary parameterDictionary2 = default;
				parameterDictionary2._002Ector(num2);
				parameterDictionary = parameterDictionary2;
			}
			if ((b & 0xFF) == 0)
			{
				goto IL_01d5;
			}
			while (true)
			{
				byte code = stream.ReadByte();
				byte b2 = stream.ReadByte();
				object obj = flags & (Protocol16.DeserializationFlags)1;
				object value;
				if (obj != null)
				{
					num = b2 & 0xFF;
					if (num == 67)
					{
						ByteArraySlice byteArraySlice = ReadNonAllocByteArray(stream);
						value = byteArraySlice;
						goto IL_0179;
					}
				}
				value = Read(stream, b2, flags, parameterDictionary);
				goto IL_0179;
				IL_0179:
				if (parameterDictionary == null)
				{
					break;
				}
				parameterDictionary.Add(code, value);
				num2--;
				if (num2 != 1)
				{
					continue;
				}
				goto IL_01d5;
			}
		}
		return (ParameterDictionary)(object)new NullReferenceException();
		IL_01d5:
		return parameterDictionary;
	}

	public PhotonHashtable ReadHashtable(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got I4
		//IL_00c4: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		PhotonHashtable photonHashtable = default;
		photonHashtable._002Ector((int)num);
		if ((int)num >= 1)
		{
			if (stream != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CA8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CA0]");
				object obj4 = 0;
				object obj5 = 0;
				byte key = default;
				while (true)
				{
					byte gpType = stream.ReadByte();
					object obj6 = Read(stream, gpType, flags, parameters);
					byte gpType2 = stream.ReadByte();
					object value = Read(stream, gpType2, flags, parameters);
					if (obj6 != null)
					{
						obj2 = obj3;
						nint num2 = (nint)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v4 (Il2CppClass<System.Object>)+130]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+130]");
						bool flag = num3 < 0;
						object obj7 = !flag;
						object obj8 = ~obj7;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v4 (Il2CppClass<System.Object>)+B0]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+130]");
							object obj9 = num4 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X9_v8-8]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X9_v8-8]");
							if (0 == (nint)obj2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @377F8D4");
								if (photonHashtable == null)
								{
									break;
								}
								photonHashtable.set_Item(key, value);
								goto IL_0188;
							}
						}
						if (photonHashtable == null)
						{
							break;
						}
						photonHashtable.set_Item(obj6, value);
					}
					goto IL_0188;
					IL_0188:
					obj5++;
					bool flag2 = (nint)obj5 < (int)num;
					object obj10 = !flag2;
					object obj11 = ~obj10;
					if (obj11 != null)
					{
						continue;
					}
					goto IL_0208;
				}
			}
			return (PhotonHashtable)(object)new NullReferenceException();
		}
		goto IL_0208;
		IL_0208:
		return photonHashtable;
	}

	public int[] ReadIntArray(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		int num = ReadInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Protocol18 protocol = default;
		if (num >= 1)
		{
			object obj2 = protocol + 32;
			object obj3 = 0;
			Protocol18 protocol2 = protocol;
			while (true)
			{
				int num2 = protocol2.ReadInt32(stream);
				if (protocol != null)
				{
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4 (Photon.Client.Protocol18)+18]");
					bool flag = (nint)obj4 < 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj3++;
						bool flag2 = num != (nint)obj3;
						protocol2 = (Protocol18)num2;
						if (!flag2)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				return (int[])(object)new IndexOutOfRangeException();
			}
		}
		return (int[])(object)protocol;
	}

	public override OperationRequest DeserializeOperationRequest(StreamBuffer din, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		OperationRequest operationRequest = default;
		operationRequest._002Ector();
		if (din != null)
		{
			byte operationCode = din.ReadByte();
			if (operationRequest != null)
			{
				operationRequest.OperationCode = operationCode;
				object target = operationRequest + 24;
				ParameterDictionary parameterDictionary = ReadParameterDictionary(din, (ParameterDictionary)target, flags);
				target = parameterDictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return operationRequest;
			}
		}
		return (OperationRequest)(object)new NullReferenceException();
	}

	public override OperationResponse DeserializeOperationResponse(StreamBuffer stream, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		OperationResponse operationResponse = default;
		operationResponse._002Ector();
		if (stream != null)
		{
			byte b = stream.ReadByte();
			if (operationResponse != null)
			{
				operationResponse.OperationCode = b;
				short returnCode = ((Protocol18)b).ReadInt16(stream);
				operationResponse.ReturnCode = returnCode;
				byte gpType = stream.ReadByte();
				object parameters = operationResponse + 32;
				object obj2 = Read(stream, gpType, flags, (ParameterDictionary)parameters);
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v3+98]");
					object obj4 = ((obj2 != null) ? null : obj2);
					object obj5 = operationResponse + 24;
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v3+98]");
					if (obj2 == null)
					{
						object obj6 = obj2;
					}
					else
					{
						object obj6 = null;
					}
				}
				else
				{
					object obj5 = operationResponse + 24;
					obj5 = 0;
					object obj6 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				ParameterDictionary parameters2 = ReadParameterDictionary(stream, operationResponse.Parameters, flags);
				operationResponse.Parameters = parameters2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return operationResponse;
			}
		}
		return (OperationResponse)(object)new NullReferenceException();
	}

	public override DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		DisconnectMessage disconnectMessage = default;
		disconnectMessage._002Ector();
		short code = ((Protocol18)(object)disconnectMessage).ReadInt16(stream);
		if (disconnectMessage != null)
		{
			disconnectMessage.Code = code;
			if (stream != null)
			{
				byte gpType = stream.ReadByte();
				object obj2 = Read(stream, gpType, (Protocol16.DeserializationFlags)0);
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X9_v3+98]");
					object obj4 = ((obj2 != null) ? null : obj2);
					object obj5 = disconnectMessage + 24;
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X9_v3+98]");
					if (obj2 == null)
					{
						object obj6 = obj2;
					}
					else
					{
						object obj6 = null;
					}
				}
				else
				{
					object obj5 = disconnectMessage + 24;
					obj5 = 0;
					object obj6 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object target = disconnectMessage + 32;
				ParameterDictionary parameterDictionary = ReadParameterDictionary(stream, (ParameterDictionary)target, (Protocol16.DeserializationFlags)0);
				target = parameterDictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return disconnectMessage;
			}
		}
		return (DisconnectMessage)(object)new NullReferenceException();
	}

	internal string ReadString(StreamBuffer stream)
	{
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		uint num = ReadCompressedUInt32(stream);
		if (num != 0)
		{
			if (stream != null)
			{
				byte[] bufferAndAdvance = stream.GetBufferAndAdvance((int)num, out var offset);
				Encoding uTF = Encoding.UTF8;
				if (uTF != null)
				{
					return (string)(object)((HashAlgorithm)(object)uTF).TransformFinalBlock(bufferAndAdvance, offset, (int)num);
				}
			}
			return (string)(object)new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v3+98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v4+A0]");
		return (string)0;
	}

	private unsafe object ReadCustomTypeArray(StreamBuffer stream)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0901: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I4
		//IL_053c: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I4
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected I4, but got Unknown
		//IL_04fb: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_09c6: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_0134: Expected I8, but got I4
		//IL_05e4: Expected I, but got Obj
		//IL_05f4: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I
		//IL_0949: Expected I4, but got I8
		//IL_0963: Expected Obj, but got I4
		//IL_0695: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		//IL_06da: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got Ref
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_086b: Expected Obj, but got I4
		//IL_07e4: Expected Obj, but got I
		//IL_0829: Expected Obj, but got I
		//IL_082e: Expected I, but got Obj
		//IL_0836: Expected Obj, but got Ref
		//IL_0720: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_02c9: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03db: Expected Obj, but got I4
		//IL_03e3: Expected I, but got I8
		uint num = ReadCompressedUInt32(stream);
		Array array;
		Array result;
		if (stream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
			object obj = 0;
			byte b = stream.ReadByte();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v12+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65169C8]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v12+8]");
				if (((Dictionary<byte, System.__Canon>)0).TryGetValue(b, out var value))
				{
					bool flag2 = value == null;
					nint num2 = (nint)(&value);
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-48_v8 (System.__Canon)+18]");
						array = Array.CreateInstance((Type)0, (int)num);
						bool flag3 = num == 0;
						result = array;
						if (flag3)
						{
							goto IL_0675;
						}
						num2 = unchecked((nint)null);
						long num3 = 0L;
						Protocol18 protocol = (Protocol18)(object)array;
						object obj11 = default;
						string format = default;
						object arg = default;
						NullReferenceException ex = default;
						int num8 = default;
						object obj21 = default;
						object obj22 = default;
						object obj24 = default;
						object obj25 = default;
						string format2 = default;
						InvalidDataException ex2 = default;
						object obj27 = default;
						while (true)
						{
							uint num4 = protocol.ReadCompressedUInt32(stream);
							int num5 = (int)((int)num4 & 0x80000000L);
							bool flag4 = num5 == 0;
							object obj7 = !flag4;
							object obj20;
							object arg2;
							object obj16;
							string text2;
							if (obj7 == null)
							{
								int available = stream.Available;
								int num6 = (int)num4 >> 15;
								bool flag5 = num6 == 0;
								object obj8 = !flag5;
								if (obj8 == null && (int)num4 <= available)
								{
									if (value == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-48_v8 (System.__Canon)+28]");
									if ((nint)0 != 0)
									{
										int position = stream.Position;
										if (value == null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-48_v8 (System.__Canon)+28]");
										object obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-48_v8 (System.__Canon)+28]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v32+28]");
										obj6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ X8_v32+18] (should have been resolved before IL gen)");
										int position2 = stream.Position;
										object obj10 = position2 - position;
										bool flag6 = (nint)obj10 == (int)num4;
										num2 = (int)num4;
										int num7 = 0;
										StreamBuffer streamBuffer = (StreamBuffer)position2;
										if (!flag6)
										{
											num7 = position + (int)num4;
											stream.Position = num7;
											num2 = unchecked((nint)null);
											streamBuffer = stream;
										}
										bool flag7 = obj11 == null;
										protocol = (Protocol18)(object)streamBuffer;
										if (!flag7)
										{
											if (value == null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-48_v8 (System.__Canon)+18]");
											object obj12 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-48_v8 (System.__Canon)+18]");
											if ((nint)0 == 0)
											{
												break;
											}
											object obj13 = obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v36+2A0]");
											num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ X8_v36+298] (should have been resolved before IL gen)");
											object obj14 = protocol & 1;
											if (obj14 != null)
											{
												if (array == null)
												{
													break;
												}
												array.SetValue(obj11, num3);
												obj6 = 0;
												num2 = (nint)num3;
												protocol = (Protocol18)(object)array;
											}
										}
										num3++;
										if ((int)num != num3)
										{
											continue;
										}
										goto IL_041d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-48_v8 (System.__Canon)+18]");
									string text = string.Format(format, 0, arg);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									ex._002Ector(text);
									obj6 = 0;
									obj16 = null;
									text2 = text;
									goto IL_0880;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
								int length = stream.Length;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
								stream.Position = length;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
								int available2 = stream.Available;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CD0]");
								object obj18 = 0;
								num2 = unchecked((nint)null);
								object obj19 = (object)(&num8);
								obj20 = obj21;
								arg2 = obj22;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
								int position3 = stream.Position;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CC8]");
								object obj18 = 0;
								object obj19 = (object)(&num8);
								obj20 = obj24;
								arg2 = obj25;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							string text3 = string.Format(format2, arg2, obj20);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							ex2._002Ector(text3);
							obj6 = 0;
							obj16 = obj20;
							text2 = text3;
							goto IL_0880;
							IL_0880:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentNullException ex3 = new ArgumentNullException();
							object obj26 = obj27;
							goto IL_08a0;
						}
					}
				}
				else
				{
					int position4 = stream.Position;
					bool flag8 = num == 0;
					uint num9 = num;
					Protocol18 protocol2 = (Protocol18)position4;
					nint num2 = (nint)(&value);
					if (!flag8)
					{
						bool flag12;
						do
						{
							uint num10 = protocol2.ReadCompressedUInt32(stream);
							int available3 = stream.Available;
							object obj28 = (int)num10 - available3;
							bool flag9 = (nint)obj28 < 0;
							int num11 = (int)num10 ^ available3;
							int num12 = (int)(num10 ^ obj28);
							int num13 = num11 & num12;
							bool flag10 = num13 < 0;
							bool flag11 = flag9 == flag10;
							object obj29 = !flag11;
							object obj30 = ~obj29;
							int num14 = ((obj30 != null) ? available3 : ((int)num10));
							int position5 = stream.Position;
							int position6 = num14 + position5;
							stream.Position = position6;
							num9--;
							flag12 = num9 != 1;
							protocol2 = (Protocol18)(object)stream;
							num2 = unchecked((nint)null);
						}
						while (flag12);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CC0]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516C88]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					UnknownType unknownType = default;
					unknownType._002Ector();
					if (unknownType != null)
					{
						unknownType.TypeCode = b;
						int position7 = stream.Position;
						int size = position7 - position4;
						unknownType.Size = size;
						Array array2 = default;
						if (array2 != null)
						{
							nint num15 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v22 (Il2CppClass<System.Array>)+40]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							ArgumentNullException ex3 = default;
							bool flag13 = ex3 == null;
							object obj16 = num2;
							if (flag13)
							{
								goto IL_08a0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v45 (System.Array)+18]");
							if ((nint)0 != 0)
							{
								object obj33 = array2 + 32;
								obj33 = unknownType;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								result = array2;
								goto IL_0675;
							}
							goto IL_08b8;
						}
					}
				}
			}
		}
		throw new NullReferenceException();
		IL_08a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex4 = new ArgumentNullException();
		goto IL_08b8;
		IL_0675:
		return result;
		IL_041d:
		result = array;
		goto IL_0675;
		IL_08b8:
		return new IndexOutOfRangeException();
	}

	private unsafe Type ReadDictionaryType(StreamBuffer stream, out SocketTcpAsync.GpType keyReadType, out SocketTcpAsync.GpType valueReadType)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_0146: Expected VT, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_033f: Expected VT, but got I
		//IL_0282: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I4
		//IL_0667: Expected Obj, but got I4
		//IL_02ae: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I
		//IL_06ac: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I4
		//IL_03ca: Expected VT, but got Obj
		//IL_03f5: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I4
		//IL_0441: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_0553: Expected Obj, but got I8
		//IL_0502: Expected Obj, but got I
		//IL_052b: Expected Obj, but got I
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_05c5: Expected I, but got Obj
		//IL_05d5: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I
		object obj;
		byte b2;
		StreamBuffer streamBuffer2;
		Protocol18 protocol;
		object obj7;
		Type type;
		Type type2;
		StreamBuffer streamBuffer = default;
		if (streamBuffer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE8]");
			obj = 0;
			byte b = streamBuffer.ReadByte();
			ref SocketTcpAsync.GpType reference = ref *(SocketTcpAsync.GpType*)b;
			b2 = streamBuffer.ReadByte();
			ref SocketTcpAsync.GpType reference2 = ref *(SocketTcpAsync.GpType*)b2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			if (keyReadType != 0)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v61+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type allowedDictionaryKeyTypes = GetAllowedDictionaryKeyTypes(keyReadType);
				streamBuffer2 = null;
				protocol = (Protocol18)(object)allowedDictionaryKeyTypes;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v56+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+10]");
				RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				streamBuffer2 = null;
				protocol = (Protocol18)(object)typeFromHandle;
			}
			int num = b2 & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8428]");
			obj7 = 0;
			RuntimeTypeHandle handle2;
			if (num > 22)
			{
				object obj9;
				if (num != 23)
				{
					if (num == 64)
					{
						Type dictArrayType = protocol.GetDictArrayType(streamBuffer);
						reference2 = ref *(SocketTcpAsync.GpType*)null;
						type = dictArrayType;
						goto IL_068c;
					}
					if (num != 85)
					{
						goto IL_0344;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516C60]");
					obj9 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9890]");
					obj9 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v49+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				handle2 = (RuntimeTypeHandle)obj9;
			}
			else
			{
				if (num != 0)
				{
					if (num != 20)
					{
						goto IL_0344;
					}
					type2 = ReadDictionaryType(streamBuffer);
					goto IL_03a5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v43+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+10]");
				handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
			}
			type2 = Type.GetTypeFromHandle(handle2);
			streamBuffer = null;
			goto IL_03a5;
		}
		goto IL_05ef;
		IL_05ef:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05fd;
		IL_0344:
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v38+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		type2 = GetClrArrayType((SocketTcpAsync.GpType)b2);
		streamBuffer = streamBuffer2;
		goto IL_03a5;
		IL_03a5:
		type = type2;
		goto IL_068c;
		IL_060b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (Type)(object)new ArgumentNullException();
		IL_05fd:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_060b;
		IL_068c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = default;
		bool flag7 = obj18 == null;
		streamBuffer = (StreamBuffer)2;
		if (flag7)
		{
			goto IL_05ef;
		}
		bool flag8 = protocol == null;
		StreamBuffer streamBuffer3 = (StreamBuffer)2;
		if (!flag8)
		{
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+40]");
			streamBuffer3 = (StreamBuffer)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag9 = ex2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+40]");
			streamBuffer = (StreamBuffer)0;
			if (flag9)
			{
				goto IL_060b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v20+18]");
		bool flag10 = (nint)0 == 0;
		streamBuffer = streamBuffer3;
		if (!flag10)
		{
			object obj20 = obj18 + 32;
			obj20 = protocol;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag11 = (object)type == null;
			StreamBuffer streamBuffer4 = (StreamBuffer)(object)protocol;
			if (!flag11)
			{
				object obj21 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v16+40]");
				streamBuffer4 = (StreamBuffer)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag12 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v16+40]");
				streamBuffer = (StreamBuffer)0;
				if (flag12)
				{
					goto IL_060b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v20+18]");
			object obj22 = 0 & 0xFFFFFFFEL;
			bool flag13 = obj22 == null;
			streamBuffer = streamBuffer4;
			if (!flag13)
			{
				object obj23 = obj18 + 40;
				obj23 = type;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag14 = (object)typeFromHandle2 == null;
				streamBuffer = (StreamBuffer)(object)type;
				if (!flag14)
				{
					nint num2 = (nint)typeFromHandle2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v15 (Il2CppClass<System.Type>)+940]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v15 (Il2CppClass<System.Type>)+938]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v240 @ X3_v1 (should have been resolved before IL gen)");
				}
				goto IL_05ef;
			}
		}
		goto IL_05fd;
	}

	private Type ReadDictionaryType(StreamBuffer stream)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_013a: Expected VT, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_0347: Expected VT, but got Obj
		//IL_0372: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I4
		//IL_023e: Expected VT, but got I
		//IL_03be: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_04d0: Expected Obj, but got I8
		//IL_047f: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_0542: Expected I, but got Obj
		//IL_0552: Expected Obj, but got I
		//IL_0562: Expected Obj, but got I
		StreamBuffer streamBuffer = default;
		IndexOutOfRangeException ex = default;
		if (streamBuffer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE8]");
			object obj = 0;
			byte b = streamBuffer.ReadByte();
			int num = b & 0xFF;
			byte b2 = streamBuffer.ReadByte();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			StreamBuffer streamBuffer2;
			Protocol18 protocol;
			if (num != 0)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v53+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type allowedDictionaryKeyTypes = GetAllowedDictionaryKeyTypes((SocketTcpAsync.GpType)b);
				streamBuffer2 = null;
				protocol = (Protocol18)(object)allowedDictionaryKeyTypes;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X23_v5+E8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v48+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X23_v5+10]");
				RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				streamBuffer2 = null;
				protocol = (Protocol18)(object)typeFromHandle;
			}
			int num2 = b2 & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8428]");
			object obj7 = 0;
			Type type;
			switch (num2)
			{
			default:
			{
				bool flag3 = num2 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X23_v5+E8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v43+E4]");
					bool flag4 = (nint)0 == 0;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X23_v5+10]");
					RuntimeTypeHandle handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
					type = Type.GetTypeFromHandle(handle2);
					streamBuffer = null;
				}
				else
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v38+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					type = GetClrArrayType((SocketTcpAsync.GpType)b2);
					streamBuffer = streamBuffer2;
				}
				break;
			}
			case 20:
				type = ReadDictionaryType(streamBuffer);
				break;
			case 64:
				type = protocol.GetDictArrayType(streamBuffer);
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X23_v5+E8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj7);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj16 = default;
			bool flag7 = obj16 == null;
			streamBuffer = (StreamBuffer)2;
			if (!flag7)
			{
				bool flag8 = protocol == null;
				StreamBuffer streamBuffer3 = (StreamBuffer)2;
				if (!flag8)
				{
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v17+40]");
					streamBuffer3 = (StreamBuffer)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag9 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v17+40]");
					streamBuffer = (StreamBuffer)0;
					if (flag9)
					{
						goto IL_0588;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v20+18]");
				bool flag10 = (nint)0 == 0;
				streamBuffer = streamBuffer3;
				if (!flag10)
				{
					object obj18 = obj16 + 32;
					obj18 = protocol;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag11 = (object)type == null;
					StreamBuffer streamBuffer4 = (StreamBuffer)(object)protocol;
					if (!flag11)
					{
						object obj19 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v16+40]");
						streamBuffer4 = (StreamBuffer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag12 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v16+40]");
						streamBuffer = (StreamBuffer)0;
						if (flag12)
						{
							goto IL_0588;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v20+18]");
					object obj20 = 0 & 0xFFFFFFFEL;
					bool flag13 = obj20 == null;
					streamBuffer = streamBuffer4;
					if (!flag13)
					{
						object obj21 = obj16 + 40;
						obj21 = type;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag14 = (object)typeFromHandle2 == null;
						streamBuffer = (StreamBuffer)(object)type;
						if (!flag14)
						{
							nint num3 = (nint)typeFromHandle2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v15 (Il2CppClass<System.Type>)+940]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v15 (Il2CppClass<System.Type>)+938]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v214 @ X3_v1 (should have been resolved before IL gen)");
						}
						goto IL_056c;
					}
				}
				goto IL_057a;
			}
		}
		goto IL_056c;
		IL_057a:
		ex = new IndexOutOfRangeException();
		goto IL_0588;
		IL_0588:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (Type)(object)new ArgumentNullException();
		IL_056c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_057a;
	}

	private Type GetDictArrayType(StreamBuffer stream)
	{
		//IL_0015: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		Type type;
		if (stream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE8]");
			object obj = 0;
			byte b = stream.ReadByte();
			int num = b & 0xFF;
			object obj2;
			byte gpType;
			if (num == 64)
			{
				obj2 = 0;
				byte b2;
				int num2;
				do
				{
					obj2++;
					b2 = stream.ReadByte();
					num2 = b2 & 0xFF;
				}
				while (num2 == 64);
				object obj3 = 0;
				gpType = b2;
			}
			else
			{
				obj2 = 0;
				object obj3 = 0;
				gpType = b;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type clrArrayType = GetClrArrayType((SocketTcpAsync.GpType)gpType);
			if ((object)clrArrayType != null)
			{
				type = (Type)((Enum)(object)clrArrayType).GetTypeCode();
				if ((nint)obj2 < 1)
				{
					goto IL_015f;
				}
				Type type2 = type;
				object obj6 = 0;
				while ((object)type2 != null)
				{
					type = (Type)((Enum)(object)type2).GetTypeCode();
					obj6++;
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
					object obj7 = !flag2;
					object obj8 = ~obj7;
					type2 = type;
					if (obj8 != null)
					{
						continue;
					}
					goto IL_015f;
				}
			}
		}
		return (Type)(object)new NullReferenceException();
		IL_015f:
		return type;
	}

	private IDictionary ReadDictionary(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_00fc: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		Type type = ReadDictionaryType(stream, out var _, out var _);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = type == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		IDictionary result = null;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
			object obj5 = 0;
			object obj6 = Activator.CreateInstance(type);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			IDictionary dictionary = default;
			bool flag4 = dictionary == null;
			result = dictionary;
			if (!flag4)
			{
				bool flag5 = ReadDictionaryElements(stream, (SocketTcpAsync.GpType)0, (SocketTcpAsync.GpType)0, dictionary, flags, parameters);
				result = dictionary;
			}
		}
		return result;
	}

	private bool ReadDictionaryElements(StreamBuffer stream, SocketTcpAsync.GpType keyReadType, SocketTcpAsync.GpType valueReadType, IDictionary dictionary, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I4
		//IL_029a: Expected I4, but got Obj
		//IL_0022: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0195: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		StreamBuffer streamBuffer = default;
		uint num = ReadCompressedUInt32(streamBuffer);
		if (num != 0)
		{
			object obj = 0;
			do
			{
				object obj2 = keyReadType & (SocketTcpAsync.GpType)0xFF;
				object obj6;
				object obj8;
				if (obj2 != null)
				{
					object obj3 = valueReadType & (SocketTcpAsync.GpType)0xFF;
					object obj4 = Read(streamBuffer, (byte)keyReadType, (Protocol16.DeserializationFlags)0);
					bool flag = obj3 == null;
					object obj5 = !flag;
					obj6 = obj4;
					if (obj5 != null)
					{
						goto IL_0123;
					}
					bool flag2 = streamBuffer == null;
					object obj7 = !flag2;
					obj8 = obj4;
					if (obj7 != null)
					{
						goto IL_013e;
					}
				}
				else if (streamBuffer != null)
				{
					object obj9 = valueReadType & (SocketTcpAsync.GpType)0xFF;
					byte gpType = streamBuffer.ReadByte();
					object obj10 = Read(streamBuffer, gpType, flags, parameters);
					bool flag3 = obj9 == null;
					obj6 = obj10;
					obj8 = obj10;
					if (!flag3)
					{
						goto IL_0123;
					}
					goto IL_013e;
				}
				goto IL_028c;
				IL_028c:
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
				IL_034d:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v352 @ X0_v9] (should have been resolved before IL gen)");
				goto IL_02fc;
				IL_0241:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_034d;
				IL_02fc:
				obj++;
				continue;
				IL_0123:
				ParameterDictionary parameters2 = null;
				Protocol16.DeserializationFlags flags2 = (Protocol16.DeserializationFlags)0;
				byte gpType2 = (byte)valueReadType;
				goto IL_02c5;
				IL_013e:
				byte b = streamBuffer.ReadByte();
				obj6 = obj8;
				parameters2 = parameters;
				flags2 = flags;
				gpType2 = b;
				goto IL_02c5;
				IL_02c5:
				object obj11 = Read(streamBuffer, gpType2, flags2, parameters2);
				if (obj6 == null)
				{
					goto IL_02fc;
				}
				if (dictionary == null)
				{
					goto IL_028c;
				}
				nint num2 = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v6 (Il2CppClass<System.Collections.IDictionary>)+12E]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v6 (Il2CppClass<System.Collections.IDictionary>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0241;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v6 (Il2CppClass<System.Collections.IDictionary>)+98]");
				object obj14 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X10_v10-8]");
					if (0 == (nint)obj13)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v6 (Il2CppClass<System.Collections.IDictionary>)+12E]");
					obj12 = -1;
					obj13 = obj14 + 16;
					bool flag4 = (nint)obj12 != 1;
					obj14 = obj13;
					if (flag4)
					{
						continue;
					}
					goto IL_0241;
				}
				obj12 = obj14 + 5;
				object obj15 = num2 + obj12;
				object obj16 = obj15 + 312;
				obj13 = obj14;
				goto IL_034d;
			}
			while ((nint)obj != (int)num);
		}
		return true;
	}

	private object[] ReadObjectArray(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_022c: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I4
		//IL_0244: Expected I4, but got Obj
		//IL_007d: Expected I4, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_0115: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I4
		//IL_0093: Expected I, but got Obj
		//IL_00c4: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (num == 0)
		{
			goto IL_017b;
		}
		bool flag = stream == null;
		ParameterDictionary parameterDictionary = parameters;
		Protocol16.DeserializationFlags deserializationFlags = flags;
		uint num2 = num;
		object[] array = default;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			while (true)
			{
				byte b = stream.ReadByte();
				object obj4 = Read(stream, b, flags, parameters);
				bool flag2 = array == null;
				nint num3 = (nint)parameters;
				parameterDictionary = (ParameterDictionary)flags;
				deserializationFlags = (Protocol16.DeserializationFlags)b;
				num2 = (uint)(int)stream;
				if (flag2)
				{
					break;
				}
				bool flag3 = obj4 == null;
				uint num4 = (uint)(int)stream;
				if (!flag3)
				{
					nint num5 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					num4 = 0u;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = ex == null;
					num3 = (nint)parameters;
					parameterDictionary = (ParameterDictionary)flags;
					deserializationFlags = (Protocol16.DeserializationFlags)b;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0u;
					if (flag4)
					{
						goto IL_019c;
					}
				}
				bool flag5 = (nint)obj3 < array.Length;
				object obj5 = !flag5;
				num3 = (nint)parameters;
				parameterDictionary = (ParameterDictionary)flags;
				deserializationFlags = (Protocol16.DeserializationFlags)b;
				num2 = num4;
				if (obj5 == null)
				{
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj3++;
					if ((int)num != (nint)obj3)
					{
						continue;
					}
					goto IL_017b;
				}
				goto IL_018e;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_018e;
		IL_017b:
		return array;
		IL_018e:
		ex = new IndexOutOfRangeException();
		goto IL_019c;
		IL_019c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (object[])(object)new ArgumentNullException();
	}

	private StructWrapper[] ReadWrapperArray(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_007e: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I
		//IL_012a: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_0171: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516D10]");
		object obj = 0;
		StreamBuffer stream2 = default;
		uint num = ReadCompressedUInt32(stream2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		StructWrapper[] array = default;
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516D20]");
			object message = 0;
			object obj3 = array + 32;
			object obj4 = 0;
			StreamBuffer streamBuffer2 = default;
			NullReferenceException ex = default;
			while (true)
			{
				object obj5 = Read(stream2, flags, parameters);
				if (array == null)
				{
					goto IL_030d;
				}
				StreamBuffer streamBuffer;
				if (obj5 != null)
				{
					object obj6 = obj2;
					nint num2 = (nint)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v5 (Il2CppClass<System.Object>)+130]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v18+130]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v5 (Il2CppClass<System.Object>)+130]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v18+130]");
					bool flag = num3 < 0;
					object obj9 = !flag;
					object obj10 = ~obj9;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v5 (Il2CppClass<System.Object>)+B0]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v18+130]");
						object obj11 = num4 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X12_v9-8]");
						if (0 == (nint)obj6)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v19 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper[]>)+40]");
							streamBuffer = (StreamBuffer)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							if (ex == null)
							{
								goto IL_0323;
							}
							obj6 = obj2;
							num2 = (nint)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v5 (Il2CppClass<System.Object>)+130]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v18+130]");
							obj8 = 0;
						}
					}
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
					object obj12 = !flag2;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v5 (Il2CppClass<System.Object>)+B0]");
						object obj13 = 0 + obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X9_v10-8]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X9_v10-8]");
						streamBuffer2 = (StreamBuffer)((0 != (nint)obj6) ? null : obj5);
						goto IL_039c;
					}
				}
				streamBuffer2 = null;
				goto IL_039c;
				IL_030d:
				ex = new NullReferenceException();
				streamBuffer = streamBuffer2;
				goto IL_0323;
				IL_039c:
				bool flag3 = (nint)obj4 < array.Length;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					obj3 = streamBuffer2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag4 = obj5 == null;
					object obj15 = !flag4;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516D18]");
						object message2 = 0;
						Debug.WriteLine((string)message2);
						streamBuffer2 = null;
					}
					bool flag5 = (nint)obj4 < array.Length;
					object obj16 = !flag5;
					if (obj16 == null)
					{
						bool flag6 = obj3 == null;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Debug.WriteLine((string)message);
						}
						obj4++;
						obj3 += 8;
						if ((int)num == (nint)obj4)
						{
							break;
						}
						continue;
					}
				}
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				goto IL_030d;
				IL_0323:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				return (StructWrapper[])(object)new ArgumentNullException();
			}
		}
		return array;
	}

	private bool[] ReadBooleanArray(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I4
		//IL_05ff: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_05b8: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01ec: Expected Obj, but got I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_02a9: Expected Obj, but got I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool[] array = default;
		object obj4;
		if ((int)num >= 8)
		{
			if (stream != null)
			{
				int num2 = (int)num >> 3;
				object obj2 = array + 32;
				object obj3 = num2 + 1;
				obj4 = 0;
				while (true)
				{
					byte b = stream.ReadByte();
					if (array == null)
					{
						break;
					}
					bool flag = (nint)obj4 < array.Length;
					object obj5 = !flag;
					if (obj5 == null)
					{
						object obj6 = obj4 + 1;
						int num3 = b & 1;
						bool flag2 = (nint)obj6 < array.Length;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							int num4 = b >> 1;
							int num5 = num4 & 1;
							object obj8 = obj6 + 1;
							object obj9 = obj2 + obj4;
							bool flag3 = (nint)obj8 < array.Length;
							object obj10 = !flag3;
							if (obj10 == null)
							{
								int num6 = b >> 2;
								int num7 = num6 & 1;
								object obj11 = obj8 + 1;
								bool flag4 = (nint)obj11 < array.Length;
								object obj12 = !flag4;
								if (obj12 == null)
								{
									int num8 = b >> 3;
									int num9 = num8 & 1;
									object obj13 = obj11 + 1;
									object obj14 = obj2 + obj4;
									bool flag5 = (nint)obj13 < array.Length;
									object obj15 = !flag5;
									if (obj15 == null)
									{
										int num10 = b >> 4;
										int num11 = num10 & 1;
										object obj16 = obj13 + 1;
										bool flag6 = (nint)obj16 < array.Length;
										object obj17 = !flag6;
										if (obj17 == null)
										{
											int num12 = b >> 5;
											int num13 = num12 & 1;
											object obj18 = obj16 + 1;
											object obj19 = obj2 + obj4;
											bool flag7 = (nint)obj18 < array.Length;
											object obj20 = !flag7;
											if (obj20 == null)
											{
												int num14 = b >> 6;
												int num15 = num14 & 1;
												object obj21 = obj18 + 1;
												bool flag8 = (nint)obj21 < array.Length;
												object obj22 = !flag8;
												if (obj22 == null)
												{
													int num16 = b >> 7;
													int num17 = num16 & 1;
													obj3--;
													object obj23 = obj2 + obj4;
													obj4 = obj21 + 1;
													if ((nint)obj3 > 1)
													{
														continue;
													}
													goto IL_037b;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_050e;
				}
			}
			goto IL_051c;
		}
		object obj24 = 0;
		goto IL_0589;
		IL_0509:
		return array;
		IL_050e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_051c;
		IL_037b:
		obj24 = obj4 + 8;
		goto IL_0589;
		IL_0589:
		if ((nint)obj24 >= (int)num)
		{
			goto IL_0509;
		}
		if (stream != null)
		{
			byte b2 = stream.ReadByte();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE8]");
			object obj25 = 0;
			object obj26 = obj25;
			object obj27 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj28 = !flag9;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj26 = obj25;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v12+A0]");
				object obj29 = 0;
				object obj30 = obj29;
				if (obj29 == null)
				{
					break;
				}
				object obj31 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v9+18]");
				bool flag10 = (nint)obj31 < 0;
				object obj32 = !flag10;
				if (obj32 == null)
				{
					if (array == null)
					{
						break;
					}
					object obj33 = obj24 + obj27;
					bool flag11 = (nint)obj33 < array.Length;
					object obj34 = !flag11;
					if (obj34 == null)
					{
						object obj35 = obj29 + obj27;
						object obj36 = obj33 + 1;
						object obj37 = (object)array + obj24;
						obj27++;
						int num18 = ~b2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v10+20]");
						int num19 = (int)((nint)0 & (nint)num18);
						bool flag12 = num19 == 0;
						if ((nint)obj36 < (int)num)
						{
							continue;
						}
						goto IL_0509;
					}
				}
				goto IL_050e;
			}
		}
		goto IL_051c;
		IL_051c:
		return (bool[])(object)new NullReferenceException();
	}

	internal short[] ReadInt16Array(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6FB0]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Protocol18 protocol = default;
		if (protocol != null)
		{
			if ((nint)protocol.versionBytes < 1)
			{
				goto IL_009a;
			}
			object obj2 = protocol + 32;
			Protocol18 protocol2 = protocol;
			object obj3 = 0;
			while (true)
			{
				short num2 = protocol2.ReadInt16(stream);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4 (Photon.Client.Protocol18)+18]");
				bool flag = (nint)obj4 < 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					break;
				}
				obj3++;
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4 (Photon.Client.Protocol18)+18]");
				bool flag2 = (nint)obj6 < 0;
				protocol2 = (Protocol18)num2;
				if (flag2)
				{
					continue;
				}
				goto IL_009a;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (short[])(object)new NullReferenceException();
		IL_009a:
		return (short[])(object)protocol;
	}

	private float[] ReadSingleArray(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (stream != null)
		{
			int num2 = (int)(num << 2);
			byte[] bufferAndAdvance = stream.GetBufferAndAdvance(num2, out var offset);
			Array array = default;
			Buffer.BlockCopy(bufferAndAdvance, offset, array, 0, num2);
			return (float[])array;
		}
		return (float[])(object)new NullReferenceException();
	}

	private double[] ReadDoubleArray(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29E8]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (stream != null)
		{
			int num2 = (int)(num << 3);
			byte[] bufferAndAdvance = stream.GetBufferAndAdvance(num2, out var offset);
			Array array = default;
			Buffer.BlockCopy(bufferAndAdvance, offset, array, 0, num2);
			return (double[])array;
		}
		return (double[])(object)new NullReferenceException();
	}

	internal string[] ReadStringArray(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array != null)
		{
			if (array.Length < 1)
			{
				goto IL_008f;
			}
			object obj2 = array + 32;
			object obj3 = 0;
			while (true)
			{
				string text = ReadString(stream);
				bool flag = (nint)obj3 < array.Length;
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				obj2 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj3++;
				if (array.Length > (nint)obj3)
				{
					continue;
				}
				goto IL_008f;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string[])(object)new NullReferenceException();
		IL_008f:
		return array;
	}

	private PhotonHashtable[] ReadHashtableArray(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_005e: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CB0]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		PhotonHashtable[] array = default;
		if (num != 0)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			IndexOutOfRangeException ex = default;
			while (true)
			{
				PhotonHashtable photonHashtable = ReadHashtable(stream, flags, parameters);
				StreamBuffer streamBuffer;
				StreamBuffer streamBuffer2;
				if (array != null)
				{
					bool flag = photonHashtable == null;
					streamBuffer = stream;
					if (!flag)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v10 (Il2CppClass<Photon.Client.PhotonHashtable[]>)+40]");
						streamBuffer = (StreamBuffer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag2 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v10 (Il2CppClass<Photon.Client.PhotonHashtable[]>)+40]");
						streamBuffer2 = (StreamBuffer)0;
						if (flag2)
						{
							goto IL_013f;
						}
					}
					bool flag3 = (nint)obj3 < array.Length;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						obj2 = photonHashtable;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj3++;
						if ((int)num == (nint)obj3)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex2 = new NullReferenceException();
					streamBuffer = stream;
				}
				ex = new IndexOutOfRangeException();
				streamBuffer2 = streamBuffer;
				goto IL_013f;
				IL_013f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				return (PhotonHashtable[])(object)new ArgumentNullException();
			}
		}
		return array;
	}

	private unsafe IDictionary[] ReadDictionaryArray(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_0032: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_015e: Expected Obj, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		Type type = ReadDictionaryType(stream, out var _, out var valueReadType);
		uint num = ((Protocol18)(object)type).ReadCompressedUInt32(stream);
		Array array = Array.CreateInstance(type, (int)num);
		IDictionary[] array3;
		IDictionary[] result;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CB8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			IDictionary[] array2 = default;
			if (array2 == null)
			{
				return (IDictionary[])(object)new InvalidCastException();
			}
			bool flag = num == 0;
			object obj2 = !flag;
			array3 = array2;
			if (obj2 != null)
			{
				goto IL_00bd;
			}
			result = array2;
		}
		else
		{
			bool flag2 = num == 0;
			array3 = null;
			result = null;
			if (!flag2)
			{
				goto IL_00bd;
			}
		}
		goto IL_029e;
		IL_00bd:
		object obj3 = array3 + 32;
		SocketTcpAsync.GpType gpType = (SocketTcpAsync.GpType)(byte)(&valueReadType);
		SocketTcpAsync.GpType gpType2 = (SocketTcpAsync.GpType)0;
		object obj4 = 0;
		object obj10 = default;
		object obj12 = default;
		NullReferenceException ex = default;
		while (true)
		{
			object obj5 = Activator.CreateInstance(type);
			bool flag3 = array3 == null;
			object obj6 = 0;
			object obj7;
			if (!flag3)
			{
				if (obj5 == null)
				{
					obj7 = 0;
					goto IL_0332;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				if (obj10 != null)
				{
					nint num2 = (nint)array3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v16 (Il2CppClass<System.Collections.IDictionary[]>)+40]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					if (ex == null)
					{
						goto IL_02d2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
					object obj11 = 0;
					obj9 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = obj12 == null;
					object obj13 = !flag4;
					obj7 = obj12;
					if (obj13 != null)
					{
						goto IL_0332;
					}
				}
				InvalidCastException ex2 = new InvalidCastException();
				obj6 = obj9;
			}
			ex = new NullReferenceException();
			goto IL_02d2;
			IL_02d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			throw new ArgumentNullException();
			IL_0332:
			bool flag5 = (nint)obj4 < array3.Length;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag6 = (nint)obj4 < array3.Length;
				object obj15 = !flag6;
				if (obj15 == null)
				{
					obj3 += 8;
					bool flag7 = ReadDictionaryElements(stream, (SocketTcpAsync.GpType)0, (SocketTcpAsync.GpType)0, (IDictionary)obj3, flags, parameters);
					obj4++;
					bool flag8 = (int)num != (nint)obj4;
					result = array3;
					gpType = (SocketTcpAsync.GpType)0;
					gpType2 = (SocketTcpAsync.GpType)0;
					if (!flag8)
					{
						break;
					}
					continue;
				}
			}
			throw new IndexOutOfRangeException();
		}
		goto IL_029e;
		IL_029e:
		return result;
	}

	private Array ReadArrayInArray(StreamBuffer stream, Protocol16.DeserializationFlags flags, ParameterDictionary parameters)
	{
		//IL_0058: Expected Obj, but got I
		//IL_006b: Expected I8, but got I4
		//IL_0088: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_013e: Expected I4, but got Obj
		//IL_01a2: Expected I, but got Obj
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		uint num = ReadCompressedUInt32(stream);
		Array array;
		if (num != 0)
		{
			if (stream != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj = 0;
				Type type = null;
				array = null;
				long num2 = 0L;
				Type type2 = default;
				while (true)
				{
					byte b = stream.ReadByte();
					object obj2 = Read(stream, b, flags, parameters);
					if (obj2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X28_v5+A8]");
						nint num3 = 0;
						nint num4 = (nint)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v4 (Il2CppClass<System.Object>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4 (Il2CppClass<System.Type>)+130]");
						bool flag = num5 < 0;
						object obj3 = !flag;
						object obj4 = ~obj3;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v4 (Il2CppClass<System.Object>)+B0]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4 (Il2CppClass<System.Type>)+130]");
							object obj5 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v7-8]");
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v7-8]");
							if (0 == num3)
							{
								bool flag2 = array == null;
								object obj6 = !flag2;
								int num7 = (int)stream;
								byte b2 = b;
								if (obj6 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
									Array array2 = Array.CreateInstance(type2, (int)num);
									num7 = (int)num;
									b2 = 0;
									type = type2;
									array = array2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
								if ((object)type == null)
								{
									break;
								}
								num3 = (nint)type;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4 (Il2CppClass<System.Type>)+298]");
								num4 = 0;
								Type elementType = ((System.RuntimeType)type).GetElementType();
								object obj7 = elementType & 1;
								if (obj7 != null)
								{
									if (array == null)
									{
										break;
									}
									array.SetValue(obj2, num2);
								}
							}
						}
					}
					num2++;
					if ((int)num != num2)
					{
						continue;
					}
					goto IL_02d2;
				}
			}
			return (Array)(object)new NullReferenceException();
		}
		array = null;
		goto IL_02d2;
		IL_02d2:
		return array;
	}

	internal int ReadInt1(StreamBuffer stream, bool signNegative)
	{
		//IL_00a5: Expected I4, but got Obj
		if (signNegative)
		{
			if (stream != null)
			{
				byte b = stream.ReadByte();
				return -b;
			}
		}
		else if (stream != null)
		{
			byte b2 = stream.ReadByte();
			return b2 & 0xFF;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	internal int ReadInt2(StreamBuffer stream, bool signNegative)
	{
		//IL_0036: Expected Obj, but got I4
		ushort num = ReadUShort(stream);
		bool flag = !signNegative;
		int num2 = num & 0xFFFF;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			return -num2;
		}
		return num2;
	}

	internal int ReadCompressedInt32(StreamBuffer stream)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		uint num = ReadCompressedUInt32(stream);
		int num2 = (int)(num & 1);
		object obj = -num2;
		return (int)(obj ^ num);
	}

	private uint ReadCompressedUInt32(StreamBuffer stream)
	{
		//IL_0052: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_03d0: Expected I4, but got Obj
		bool flag = stream == null;
		StreamBuffer streamBuffer = stream;
		if (!flag)
		{
			byte[] buffer = stream.GetBuffer();
			int position = stream.Position;
			object obj = position + 32;
			int num = position;
			int num2 = 0;
			object obj2 = 0;
			int num3 = position;
			int num5 = default;
			string[] array2 = default;
			EndOfStreamException ex = default;
			while (true)
			{
				bool flag2 = (nint)obj2 == 35;
				uint result = (uint)num2;
				int num4 = num3;
				if (!flag2)
				{
					int length = stream.Length;
					bool flag3 = num3 >= length;
					byte[] array = buffer;
					streamBuffer = null;
					StreamBuffer streamBuffer2 = stream;
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
						int length2 = streamBuffer2.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
						streamBuffer2.Position = length2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						string text = num.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
						int length3 = streamBuffer2.Length;
						string text2 = num5.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
						string text3 = num5.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
						int available = streamBuffer2.Available;
						string text4 = num5.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						string message = string.Concat(array2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						ex._002Ector(message);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						ArgumentNullException ex2 = new ArgumentNullException();
						return (uint)(int)ex2;
					}
					bool flag4 = buffer == null;
					array = buffer;
					streamBuffer = null;
					streamBuffer2 = stream;
					if (flag4)
					{
						break;
					}
					bool flag5 = num3 < buffer.Length;
					object obj3 = !flag5;
					array = buffer;
					streamBuffer = null;
					streamBuffer2 = stream;
					if (obj3 != null)
					{
						goto IL_01fa;
					}
					num4 = num3 + 1;
					obj++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X0_v76 (System.Byte[])+v52 @ X24_v5]");
					int num6 = (int)((nint)0 & (nint)0x7F);
					int num7 = num6 << (int)obj2;
					obj2 += 7;
					num2 = num7 | num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X0_v76 (System.Byte[])+v52 @ X24_v5]");
					int num8 = (int)((nint)0 & (nint)0x80);
					bool flag6 = num8 == 0;
					object obj4 = !flag6;
					result = (uint)num2;
					num = num4;
					num3 = num4;
					if (obj4 != null)
					{
						continue;
					}
				}
				stream.Position = num4;
				return result;
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_01fa;
		IL_01fa:
		throw new IndexOutOfRangeException();
	}

	internal long ReadCompressedInt64(StreamBuffer stream)
	{
		//IL_002a: Expected Obj, but got I8
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I8, but got Unknown
		ulong num = ReadCompressedUInt64(stream);
		long num2 = (long)(num & 1);
		object obj = -num2;
		return (long)(obj ^ num);
	}

	private ulong ReadCompressedUInt64(StreamBuffer stream)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Expected I8, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_0200: Expected I8, but got Obj
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected I8, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_0183: Expected I4, but got Obj
		bool flag = stream == null;
		StreamBuffer streamBuffer = stream;
		if (!flag)
		{
			byte[] buffer = stream.GetBuffer();
			int position = stream.Position;
			object obj = buffer + position;
			int num = position + 10;
			object obj2 = obj + 32;
			ulong num2 = 0uL;
			object obj3 = 0;
			streamBuffer = (StreamBuffer)position;
			EndOfStreamException ex = default;
			string message = default;
			while (true)
			{
				int position2;
				if ((nint)obj3 != 70)
				{
					if (buffer == null)
					{
						break;
					}
					bool flag2 = (nint)streamBuffer < buffer.Length;
					object obj4 = !flag2;
					if ((nint)streamBuffer >= buffer.Length)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						ex._002Ector(message);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						ArgumentNullException ex2 = new ArgumentNullException();
						return (ulong)(long)ex2;
					}
					if (obj4 != null)
					{
						goto IL_01a3;
					}
					obj2++;
					streamBuffer = (StreamBuffer)(streamBuffer + 1);
					object obj5 = obj2 & 0x7F;
					object obj6 = obj5 << (int)obj3;
					obj3 += 7;
					num2 = (ulong)(long)(obj6 | num2);
					object obj7 = obj2 & 0x80;
					bool flag3 = obj7 == null;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						continue;
					}
					position2 = (int)streamBuffer;
				}
				else
				{
					position2 = num;
				}
				stream.Position = position2;
				return num2;
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_01a3;
		IL_01a3:
		throw new IndexOutOfRangeException();
	}

	internal int[] ReadCompressedInt32Array(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Protocol18 protocol = default;
		if (protocol != null)
		{
			if ((nint)protocol.versionBytes < 1)
			{
				goto IL_00c3;
			}
			object obj2 = protocol + 32;
			Protocol18 protocol2 = protocol;
			object obj3 = 0;
			while (true)
			{
				uint num2 = protocol2.ReadCompressedUInt32(stream);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4 (Photon.Client.Protocol18)+18]");
				bool flag = (nint)obj4 < 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					break;
				}
				int num3 = (int)(num2 & 1);
				object obj6 = -num3;
				int num4 = (int)(obj6 ^ num2);
				obj3++;
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4 (Photon.Client.Protocol18)+18]");
				bool flag2 = (nint)obj7 < 0;
				protocol2 = (Protocol18)num2;
				if (flag2)
				{
					continue;
				}
				goto IL_00c3;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (int[])(object)new NullReferenceException();
		IL_00c3:
		return (int[])(object)protocol;
	}

	internal long[] ReadCompressedInt64Array(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I8
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I8, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6503928]");
		object obj = 0;
		uint num = ReadCompressedUInt32(stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Protocol18 protocol = default;
		if (protocol != null)
		{
			if ((nint)protocol.versionBytes < 1)
			{
				goto IL_00c3;
			}
			object obj2 = protocol + 32;
			Protocol18 protocol2 = protocol;
			object obj3 = 0;
			while (true)
			{
				ulong num2 = protocol2.ReadCompressedUInt64(stream);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4 (Photon.Client.Protocol18)+18]");
				bool flag = (nint)obj4 < 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					break;
				}
				long num3 = (long)(num2 & 1);
				object obj6 = -num3;
				long num4 = (long)(obj6 ^ num2);
				obj3++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4 (Photon.Client.Protocol18)+18]");
				bool flag2 = 0 > (nint)obj3;
				protocol2 = (Protocol18)num2;
				if (flag2)
				{
					continue;
				}
				goto IL_00c3;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (long[])(object)new NullReferenceException();
		IL_00c3:
		return (long[])(object)protocol;
	}

	private int DecodeZigZag32(uint value)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got Unknown
		int num = (int)(value & 1);
		object obj = -num;
		return (int)(obj ^ value);
	}

	private long DecodeZigZag64(ulong value)
	{
		//IL_001c: Expected Obj, but got I8
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I8, but got Unknown
		long num = (long)(value & 1);
		object obj = -num;
		return (long)(obj ^ value);
	}

	internal void Write(StreamBuffer stream, object value, bool writeType)
	{
		object obj = default;
		bool writeType2;
		SocketTcpAsync.GpType gpType;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			Type type = default;
			SocketTcpAsync.GpType codeOfType = GetCodeOfType(type);
			writeType2 = writeType;
			gpType = codeOfType;
		}
		else
		{
			writeType2 = writeType;
			gpType = (SocketTcpAsync.GpType)8;
		}
		StreamBuffer stream2 = default;
		Write(stream2, obj, gpType, writeType2);
	}

	private void Write(StreamBuffer stream, object value, SocketTcpAsync.GpType gpType, bool writeType)
	{
		//IL_043d: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		object obj = gpType & (SocketTcpAsync.GpType)0xFF;
		if ((nint)obj <= 63)
		{
			bool flag = (nint)obj < 26;
			object obj2 = !flag;
			object obj3 = obj - 26;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 != null)
			{
				return;
			}
			object obj6 = 18214912 + 3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v2+v47 @ X8_v3*2]");
			object obj7 = (nint)86085320 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X10_v2 (should have been resolved before IL gen)");
		}
		if ((nint)obj <= 70)
		{
			if ((nint)obj <= 67)
			{
				if ((nint)obj != 64)
				{
					if ((nint)obj != 66)
					{
						if ((nint)obj == 67)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
							byte[] value2 = default;
							WriteByteArray(stream, value2, writeType);
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
						bool[] value3 = default;
						WriteBoolArray(stream, value3, writeType);
					}
				}
				else
				{
					WriteArrayInArray(stream, value, writeType: false);
				}
			}
			else if ((nint)obj != 68)
			{
				if ((nint)obj != 69)
				{
					if ((nint)obj == 70)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29E8]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
						double[] values = default;
						WriteDoubleArray(stream, values, writeType);
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
					float[] values2 = default;
					WriteSingleArray(stream, values2, writeType);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6FB0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
				short[] value4 = default;
				WriteInt16Array(stream, value4, writeType);
			}
		}
		else if ((nint)obj <= 82)
		{
			if ((nint)obj != 71)
			{
				if ((nint)obj != 73)
				{
					if ((nint)obj == 74)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6503928]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
						long[] values3 = default;
						WriteInt64ArrayCompressed(stream, values3, writeType);
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
					int[] value5 = default;
					WriteInt32ArrayCompressed(stream, value5, writeType);
				}
			}
			else
			{
				WriteStringArray(stream, value, writeType);
			}
		}
		else if ((nint)obj != 83)
		{
			if ((nint)obj != 84)
			{
				if ((nint)obj == 85)
				{
					WriteHashtableArray(stream, value, writeType);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CB8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28BBB98");
				IDictionary[] dictArray = default;
				WriteDictionaryArray(stream, dictArray, writeType: false);
			}
		}
		else
		{
			WriteCustomTypeArray(stream, value, writeType);
		}
	}

	public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType)
	{
		if (setType)
		{
			stream.WriteByte(26);
		}
		stream.WriteByte(serObject.Code);
		WriteParameterTable(stream, serObject.Parameters);
	}

	private unsafe void WriteParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters)
	{
		//IL_0252: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_012d: Expected VT, but got Ref
		//IL_0136: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got Ref
		//IL_01d6: Expected Obj, but got I4
		Dictionary<byte, object> dictionary = default;
		bool flag = dictionary == null;
		StreamBuffer streamBuffer = stream;
		object obj = 109924352;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A78]");
			obj = 0;
			streamBuffer = (StreamBuffer)obj;
			if (((Dictionary<byte, System.__Canon>)(object)dictionary).Count != 0)
			{
				streamBuffer = (StreamBuffer)obj;
				int count = ((Dictionary<byte, System.__Canon>)(object)dictionary).Count;
				if (stream != null)
				{
					stream.WriteByte((byte)count);
					Dictionary<byte, System.__Canon>.Enumerator enumerator = ((Dictionary<byte, System.__Canon>)(object)dictionary).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A88]");
					obj = 0;
					object obj2 = null;
					Dictionary<byte, System.__Canon>.Enumerator enumerator2 = default;
					object obj3 = default;
					while (enumerator2.MoveNext())
					{
						stream.WriteByte(0);
						Write(stream, obj3, writeType: true);
						obj2 = obj3;
					}
					object obj4 = 0;
					object obj5 = 0;
					Dictionary<byte, System.__Canon>.Enumerator enumerator3 = (Dictionary<byte, System.__Canon>.Enumerator)(&enumerator2);
					object obj6 = 0;
					object obj10 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A80]");
						object obj7 = 0;
						streamBuffer = (StreamBuffer)obj7;
						enumerator2.Dispose();
						bool flag2 = obj6 == null;
						object obj8 = !flag2;
						if (obj8 == null)
						{
							bool flag3 = obj4 == null;
							object obj9 = !flag3;
							OutOfMemoryException ex = (OutOfMemoryException)(&enumerator2);
							if (obj9 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)streamBuffer == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj4 = 1;
							obj6 = obj5;
							continue;
						}
						if ((nint)streamBuffer != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj6 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj5 = obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB90C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				goto IL_016c;
			}
		}
		if (stream != null)
		{
			stream.WriteByte(0);
			return;
		}
		goto IL_016c;
		IL_016c:
		throw new NullReferenceException();
	}

	private unsafe void WriteParameterTable(StreamBuffer stream, ParameterDictionary parameters)
	{
		//IL_0178: Expected VT, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got Ref
		//IL_0138: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got Ref
		//IL_01eb: Expected Obj, but got I4
		ParameterDictionary parameterDictionary = default;
		bool flag = parameterDictionary == null;
		StreamBuffer streamBuffer = stream;
		NonAllocDictionary<byte, object>.PairIterator pairIterator = default;
		object obj;
		if (!flag)
		{
			int count = parameterDictionary.Count;
			bool flag2 = count == 0;
			streamBuffer = null;
			if (!flag2)
			{
				int count2 = parameterDictionary.Count;
				bool flag3 = stream == null;
				streamBuffer = null;
				if (!flag3)
				{
					stream.WriteByte((byte)count2);
					NonAllocDictionary<byte, object>.PairIterator enumerator = parameterDictionary.GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A40]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A48]");
					object obj2 = 0;
					object obj3 = null;
					object obj5 = default;
					byte value = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F330");
						object obj4 = obj5 & 1;
						if (obj4 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F298");
						stream.WriteByte(value);
						Write(stream, obj2, writeType: true);
						obj3 = obj2;
					}
					object obj6 = 0;
					object obj7 = 0;
					OutOfMemoryException ex = (OutOfMemoryException)(&pairIterator);
					object obj8 = 0;
					object obj12 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A38]");
						object obj9 = 0;
						streamBuffer = (StreamBuffer)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F3BC");
						bool flag4 = obj8 == null;
						object obj10 = !flag4;
						if (obj10 == null)
						{
							bool flag5 = obj6 == null;
							object obj11 = !flag5;
							OutOfMemoryException ex2 = (OutOfMemoryException)(&pairIterator);
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
						if ((nint)streamBuffer == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj6 = 1;
							obj8 = obj7;
							continue;
						}
						if ((nint)streamBuffer != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj8 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj7 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB948");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				goto IL_016e;
			}
		}
		if (stream != null)
		{
			stream.WriteByte(0);
			return;
		}
		goto IL_016e;
		IL_016e:
		pairIterator = (NonAllocDictionary<byte, object>.PairIterator)0;
		obj = 109924352;
		throw new NullReferenceException();
	}

	private void SerializeOperationRequest(StreamBuffer stream, OperationRequest operation, bool setType)
	{
		//IL_0005: Expected I, but got Obj
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		nint num = (nint)this;
		ParameterDictionary parameters = operation.Parameters;
		byte operationCode = operation.OperationCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1 (Il2CppClass<Photon.Client.Protocol18>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1 (Il2CppClass<Photon.Client.Protocol18>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X6_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, ParameterDictionary parameters, bool setType)
	{
		if (setType)
		{
			stream.WriteByte(24);
		}
		stream.WriteByte(operationCode);
		WriteParameterTable(stream, parameters);
	}

	public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType)
	{
		if (setType)
		{
			stream.WriteByte(25);
		}
		stream.WriteByte(serObject.OperationCode);
		byte v = (byte)(serObject.ReturnCode >> 8);
		stream.WriteBytes((byte)serObject.ReturnCode, v);
		if (string.IsNullOrEmpty(serObject.DebugMessage))
		{
			stream.WriteByte(8);
		}
		else
		{
			stream.WriteByte(7);
			WriteString(stream, serObject.DebugMessage, writeType: false);
		}
		WriteParameterTable(stream, serObject.Parameters);
	}

	internal void WriteByte(StreamBuffer stream, byte value, bool writeType)
	{
		//IL_007d: Expected Obj, but got I4
		byte value2;
		if (writeType)
		{
			if ((value & 0xFF) != 0)
			{
				stream.WriteByte(3);
				value2 = value;
			}
			else
			{
				value2 = 34;
			}
		}
		else
		{
			bool flag = stream == null;
			object obj = !flag;
			value2 = value;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		stream.WriteByte(value2);
	}

	internal void WriteBoolean(StreamBuffer stream, bool value, bool writeType)
	{
		byte value2;
		if (writeType)
		{
			value2 = (byte)((!value) ? 27 : 28);
		}
		else
		{
			value2 = (value ? ((byte)1) : ((byte)0));
		}
		stream.WriteByte(value2);
	}

	internal void WriteUShort(StreamBuffer stream, ushort value)
	{
		int num = value >> 8;
		int v = num & 0xFF;
		stream.WriteBytes((byte)value, (byte)v);
	}

	internal void WriteInt16(StreamBuffer stream, short value, bool writeType)
	{
		//IL_009c: Expected I4, but got Obj
		if (writeType)
		{
			if ((value & 0xFFFF) == 0)
			{
				stream.WriteByte((byte)(int)typeof(_0021_00210));
				return;
			}
			stream.WriteByte(4);
		}
		int num = value >> 8;
		byte v = (byte)(num & 0xFF);
		stream.WriteBytes((byte)value, v);
	}

	internal unsafe void WriteDouble(StreamBuffer stream, double value, bool writeType)
	{
		//IL_00b8: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got Ref
		//IL_00cd: Expected Obj, but got Ref
		//IL_00d3: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got Ref
		//IL_0125: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got Ref
		//IL_013a: Expected Obj, but got Ref
		//IL_0140: Expected I, but got Obj
		//IL_0151: Expected Obj, but got Ref
		//IL_019d: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got Ref
		//IL_01b2: Expected Obj, but got Ref
		//IL_01c3: Expected I4, but got Obj
		//IL_01f1: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_0313: Expected I4, but got Obj
		//IL_022c: Expected Obj, but got I4
		//IL_0361: Expected I4, but got Obj
		//IL_0254: Expected Obj, but got I4
		StreamBuffer streamBuffer = default;
		bool flag = default;
		if (flag)
		{
			if (streamBuffer != null)
			{
				streamBuffer.WriteByte(6);
				goto IL_006a;
			}
		}
		else if (streamBuffer != null)
		{
			goto IL_006a;
		}
		NullReferenceException ex = new NullReferenceException();
		bool lockTaken = false;
		object obj = null;
		int num = 0;
		goto IL_0290;
		IL_02bb:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		object obj2 = default;
		int num2;
		NullReferenceException ex3 = default;
		if ((nint)streamBuffer == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
			num2 = (int)streamBuffer;
		}
		else
		{
			if ((nint)streamBuffer != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj3 = default;
			ex3 = (NullReferenceException)obj3;
			num2 = (int)streamBuffer;
		}
		goto IL_01da;
		IL_01da:
		object obj4 = default;
		bool flag2 = obj4 == null;
		streamBuffer = (StreamBuffer)num2;
		object obj5 = default;
		if (!flag2)
		{
			Monitor.Exit(obj5);
			streamBuffer = null;
		}
		bool flag3 = ex3 == null;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_0290;
		}
		bool flag4 = obj2 == null;
		object obj7 = !flag4;
		NullReferenceException ex4 = ex3;
		if (obj7 == null)
		{
			return;
		}
		goto IL_02ac;
		IL_029e:
		ex4 = new NullReferenceException();
		goto IL_02ac;
		IL_02ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_02bb;
		IL_006a:
		byte[] bufferAndAdvance = streamBuffer.GetBufferAndAdvance(8, out num);
		Monitor.Enter(memDoubleBlock, ref lockTaken);
		Array array = memDoubleBlock;
		bool flag5 = memDoubleBlock == null;
		obj2 = 0;
		ex3 = null;
		obj5 = (object)(&obj);
		obj4 = (object)(&lockTaken);
		nint num3 = unchecked((nint)null);
		flag = false;
		streamBuffer = (StreamBuffer)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlock;
		if (flag5)
		{
			goto IL_029e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v29 (System.Array)+18]");
		bool flag6 = (nint)0 == 0;
		obj2 = 0;
		ex3 = null;
		obj5 = (object)(&obj);
		obj4 = (object)(&lockTaken);
		num3 = unchecked((nint)null);
		flag = false;
		streamBuffer = (StreamBuffer)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlock;
		if (!flag6)
		{
			Buffer.BlockCopy(memDoubleBlock, 0, bufferAndAdvance, num, 8);
			obj2 = 0;
			ex3 = null;
			obj5 = (object)(&obj);
			obj4 = (object)(&lockTaken);
			num3 = num;
			flag = (byte)(int)bufferAndAdvance != 0;
			num2 = 0;
			lockTaken = false;
			goto IL_01da;
		}
		goto IL_02bb;
		IL_0290:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_029e;
	}

	internal unsafe void WriteSingle(StreamBuffer stream, float value, bool writeType)
	{
		//IL_00b8: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got Ref
		//IL_00cd: Expected Obj, but got Ref
		//IL_00d3: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got Ref
		//IL_0125: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got Ref
		//IL_013a: Expected Obj, but got Ref
		//IL_0140: Expected I, but got Obj
		//IL_0151: Expected Obj, but got Ref
		//IL_019d: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got Ref
		//IL_01b2: Expected Obj, but got Ref
		//IL_01c3: Expected I4, but got Obj
		//IL_01f1: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_0313: Expected I4, but got Obj
		//IL_022c: Expected Obj, but got I4
		//IL_0361: Expected I4, but got Obj
		//IL_0254: Expected Obj, but got I4
		StreamBuffer streamBuffer = default;
		bool flag = default;
		if (flag)
		{
			if (streamBuffer != null)
			{
				streamBuffer.WriteByte(5);
				goto IL_006a;
			}
		}
		else if (streamBuffer != null)
		{
			goto IL_006a;
		}
		NullReferenceException ex = new NullReferenceException();
		bool lockTaken = false;
		object obj = null;
		int num = 0;
		goto IL_0290;
		IL_02bb:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		object obj2 = default;
		int num2;
		NullReferenceException ex3 = default;
		if ((nint)streamBuffer == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
			num2 = (int)streamBuffer;
		}
		else
		{
			if ((nint)streamBuffer != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj3 = default;
			ex3 = (NullReferenceException)obj3;
			num2 = (int)streamBuffer;
		}
		goto IL_01da;
		IL_01da:
		object obj4 = default;
		bool flag2 = obj4 == null;
		streamBuffer = (StreamBuffer)num2;
		object obj5 = default;
		if (!flag2)
		{
			Monitor.Exit(obj5);
			streamBuffer = null;
		}
		bool flag3 = ex3 == null;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_0290;
		}
		bool flag4 = obj2 == null;
		object obj7 = !flag4;
		NullReferenceException ex4 = ex3;
		if (obj7 == null)
		{
			return;
		}
		goto IL_02ac;
		IL_029e:
		ex4 = new NullReferenceException();
		goto IL_02ac;
		IL_02ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_02bb;
		IL_006a:
		byte[] bufferAndAdvance = streamBuffer.GetBufferAndAdvance(4, out num);
		Monitor.Enter(memFloatBlock, ref lockTaken);
		Array array = memFloatBlock;
		bool flag5 = memFloatBlock == null;
		obj2 = 0;
		ex3 = null;
		obj5 = (object)(&obj);
		obj4 = (object)(&lockTaken);
		nint num3 = unchecked((nint)null);
		flag = false;
		streamBuffer = (StreamBuffer)(&lockTaken);
		lockTaken = false;
		obj = memFloatBlock;
		if (flag5)
		{
			goto IL_029e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v29 (System.Array)+18]");
		bool flag6 = (nint)0 == 0;
		obj2 = 0;
		ex3 = null;
		obj5 = (object)(&obj);
		obj4 = (object)(&lockTaken);
		num3 = unchecked((nint)null);
		flag = false;
		streamBuffer = (StreamBuffer)(&lockTaken);
		lockTaken = false;
		obj = memFloatBlock;
		if (!flag6)
		{
			Buffer.BlockCopy(memFloatBlock, 0, bufferAndAdvance, num, 4);
			obj2 = 0;
			ex3 = null;
			obj5 = (object)(&obj);
			obj4 = (object)(&lockTaken);
			num3 = num;
			flag = (byte)(int)bufferAndAdvance != 0;
			num2 = 0;
			lockTaken = false;
			goto IL_01da;
		}
		goto IL_02bb;
		IL_0290:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_029e;
	}

	internal unsafe void WriteString(StreamBuffer stream, string value, bool writeType)
	{
		//IL_0090: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00b7: Expected VT, but got I
		//IL_00d5: Expected I4, but got Obj
		//IL_00f1: Expected I4, but got Obj
		//IL_0108: Expected I4, but got Obj
		//IL_012f: Expected I4, but got Obj
		//IL_0161: Expected I4, but got Obj
		//IL_0169: Expected Obj, but got Ref
		//IL_0197: Expected I4, but got Obj
		//IL_019f: Expected Obj, but got Ref
		//IL_01ba: Expected VT, but got Obj
		bool flag2 = default;
		bool flag = !flag2;
		string text = value;
		if (!flag)
		{
			bool flag3 = stream == null;
			text = value;
			if (flag3)
			{
				goto IL_01bb;
			}
			stream.WriteByte(7);
			text = null;
		}
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			nint num = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v3 (Il2CppClass<System.Text.Encoding>)+1F0]");
			text = (string)0;
			IntPtr intPtr = default;
			Task task = ((Stream)(object)uTF).WriteAsync((byte[])(object)value, 0, flag2 ? 1 : 0, (CancellationToken)(nint)intPtr);
			bool flag4 = (nint)task >= 32768;
			int num2 = (int)task;
			if (flag4)
			{
				string text2 = num2.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string text3 = default;
				string message = text3 + text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				NotSupportedException ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			WriteCompressedUInt32(stream, (uint)(int)task);
			bool flag5 = stream == null;
			num2 = (int)task;
			text = (string)(object)task;
			if (!flag5)
			{
				byte[] bufferAndAdvance = stream.GetBufferAndAdvance((int)task, out var offset);
				Encoding uTF2 = Encoding.UTF8;
				bool flag6 = value == null;
				flag2 = false;
				num2 = (int)task;
				text = (string)(&offset);
				if (!flag6)
				{
					bool flag7 = uTF2 == null;
					flag2 = false;
					num2 = (int)task;
					text = (string)(&offset);
					if (!flag7)
					{
						((Stream)(object)uTF2).Write((ReadOnlySpan<byte>)value);
						return;
					}
				}
			}
		}
		goto IL_01bb;
		IL_01bb:
		throw new NullReferenceException();
	}

	private unsafe void WriteHashtable(StreamBuffer stream, object value, bool writeType)
	{
		//IL_0120: Expected I4, but got Obj
		//IL_018b: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I4
		//IL_023c: Expected VT, but got Ref
		//IL_0244: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got Ref
		//IL_0270: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got VT
		//IL_0311: Expected Obj, but got I4
		//IL_0378: Expected Ref, but got VT
		//IL_03a4: Expected Obj, but got VT
		bool flag = value == null;
		StreamBuffer streamBuffer = stream;
		if (flag)
		{
			goto IL_0101;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj = 0;
		StreamBuffer streamBuffer2 = (StreamBuffer)obj;
		nint num = (nint)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v16 (Il2CppClass<System.Object>)+130]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X1_v2 (Photon.Client.StreamBuffer)+130]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v16 (Il2CppClass<System.Object>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X1_v2 (Photon.Client.StreamBuffer)+130]");
		bool flag2 = num2 < 0;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		object obj6 = value;
		object obj8 = default;
		object obj9 = default;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v16 (Il2CppClass<System.Object>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X1_v2 (Photon.Client.StreamBuffer)+130]");
			object obj7 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v18-8]");
			bool flag3 = 0 != (nint)streamBuffer2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X1_v2 (Photon.Client.StreamBuffer)+130]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v16 (Il2CppClass<System.Object>)+130]");
			obj9 = 0;
			streamBuffer = streamBuffer2;
			obj6 = value;
			if (!flag3)
			{
				goto IL_0101;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		goto IL_02c0;
		IL_0422:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A32C8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_028f:
		obj3 = obj8;
		obj2 = obj9;
		streamBuffer2 = streamBuffer;
		throw new NullReferenceException();
		IL_0256:
		object obj10 = default;
		bool flag4 = obj10 == null;
		object obj11 = !flag4;
		obj3 = obj8;
		obj2 = obj9;
		if (obj11 == null)
		{
			return;
		}
		goto IL_02c0;
		IL_0101:
		bool flag6 = default;
		bool flag5 = !flag6;
		obj6 = value;
		byte b = (byte)(int)streamBuffer;
		if (!flag5)
		{
			bool flag7 = stream == null;
			obj6 = value;
			if (flag7)
			{
				goto IL_028f;
			}
			stream.WriteByte(21);
			obj6 = null;
			b = 21;
		}
		bool flag8 = value == null;
		streamBuffer = (StreamBuffer)b;
		object obj12 = default;
		DictionaryEntryEnumerator dictionaryEntryEnumerator2 = default;
		if (!flag8)
		{
			int count = ((Dictionary<System.__Canon, System.__Canon>)value).Count;
			WriteCompressedUInt32(stream, (uint)count);
			DictionaryEntryEnumerator enumerator = ((PhotonHashtable)value).GetEnumerator();
			uint num4 = (uint)count;
			DictionaryEntryEnumerator dictionaryEntryEnumerator = default;
			while (dictionaryEntryEnumerator.MoveNext())
			{
				DictionaryEntry current = dictionaryEntryEnumerator.Current;
				Write(stream, current, writeType: true);
				Write(stream, null, writeType: true);
				num4 = 0u;
			}
			dictionaryEntryEnumerator.Dispose();
			obj10 = 0;
			obj12 = 0;
			dictionaryEntryEnumerator2 = (DictionaryEntryEnumerator)(&dictionaryEntryEnumerator);
			obj6 = num4;
			streamBuffer2 = null;
			ex = (InvalidCastException)(&dictionaryEntryEnumerator);
			goto IL_0256;
		}
		goto IL_028f;
		IL_02c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj13;
		OutOfMemoryException ex2;
		if ((nint)streamBuffer2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj10 = 1;
			obj13 = obj12;
		}
		else
		{
			bool flag9 = (nint)streamBuffer2 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag9)
			{
				goto IL_0422;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj14 = default;
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = obj14;
		}
		((DictionaryEntryEnumerator*)dictionaryEntryEnumerator2)->Dispose();
		bool flag10 = obj13 == null;
		obj8 = obj3;
		obj9 = obj2;
		streamBuffer2 = null;
		ex = (InvalidCastException)dictionaryEntryEnumerator2;
		if (flag10)
		{
			goto IL_0256;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		streamBuffer2 = null;
		ex2 = ex4;
		goto IL_0422;
	}

	internal void WriteByteArray(StreamBuffer stream, byte[] value, bool writeType)
	{
		if (writeType)
		{
			stream.WriteByte(67);
		}
		WriteCompressedUInt32(stream, (uint)value.Length);
		stream.Write(value, 0, value.Length);
	}

	private void WriteArraySegmentByte(StreamBuffer stream, ArraySegment<byte> seg, bool writeType)
	{
		//IL_0126: Expected Obj, but got I
		//IL_0145: Expected I4, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_001c: Expected VT, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got VT
		nint num = default;
		object obj = num & 1;
		bool flag = obj == null;
		ArraySegment<byte> arraySegment = seg;
		byte b = (byte)(int)stream;
		if (!flag)
		{
			stream.WriteByte(67);
			arraySegment = (ArraySegment<byte>)0;
			b = 67;
		}
		uint num2 = (uint)((writeType ? 1 : 0) >> 32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6DF8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		WriteCompressedUInt32(stream, num2);
		if ((int)num2 >= 1)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			stream.Write((byte[])seg, writeType ? 1 : 0, (int)num2);
		}
	}

	private void WriteByteArraySlice(StreamBuffer stream, ByteArraySlice buffer, bool writeType)
	{
		if (writeType)
		{
			stream.WriteByte(67);
		}
		WriteCompressedUInt32(stream, (uint)buffer.Count);
		stream.Write(buffer.Buffer, buffer.Offset, buffer.Count);
		bool flag = buffer.Release();
	}

	internal void WriteInt32ArrayCompressed(StreamBuffer stream, int[] value, bool writeType)
	{
		//IL_0073: Expected Obj, but got I8
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected I4, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		if (writeType)
		{
			stream.WriteByte(73);
		}
		WriteCompressedUInt32(stream, (uint)value.Length);
		if (value.Length < 1)
		{
			return;
		}
		object obj = value.Length & 0xFFFFFFFFL;
		object obj2 = value + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X23_v4+v36 @ X22_v5*4]");
			object obj5 = (nint)0 << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X23_v4+v36 @ X22_v5*4]");
			uint value2 = (uint)(obj5 ^ 0);
			WriteCompressedUInt32(stream, value2);
			obj = value.Length;
			obj3++;
			if ((nint)obj3 >= value.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void WriteInt64ArrayCompressed(StreamBuffer stream, long[] values, bool setType)
	{
		//IL_0073: Expected Obj, but got I8
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected I8, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		if (setType)
		{
			stream.WriteByte(74);
		}
		WriteCompressedUInt32(stream, (uint)values.Length);
		if (values.Length < 1)
		{
			return;
		}
		object obj = values.Length & 0xFFFFFFFFL;
		object obj2 = values + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X23_v4+v36 @ X22_v5*8]");
			object obj5 = (nint)0 << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X23_v4+v36 @ X22_v5*8]");
			ulong value = (ulong)(long)(obj5 ^ 0);
			WriteCompressedUInt64(stream, value);
			obj = values.Length;
			obj3++;
			if ((nint)obj3 >= values.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal void WriteBoolArray(StreamBuffer stream, bool[] value, bool writeType)
	{
		//IL_0028: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_05e1: Expected Obj, but got I4
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03be: Expected Obj, but got I4
		//IL_03c7: Expected Obj, but got I4
		//IL_0659: Expected Obj, but got I4
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_03d5: Expected Obj, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01f1: Expected Obj, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_0322: Expected Obj, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		if (writeType)
		{
			stream.WriteByte(66);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		WriteCompressedUInt32(stream, (uint)value.Length);
		int num = value.Length >> 3;
		object obj2 = num + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		byte[] array = default;
		object obj5;
		if (num >= 1)
		{
			object obj3 = array + 32;
			object obj4 = value + 32;
			obj5 = 0;
			object obj6 = 0;
			while (true)
			{
				bool flag = (nint)obj5 < value.Length;
				object obj7 = !flag;
				if (obj7 != null)
				{
					break;
				}
				object obj8 = obj5 + 1;
				bool flag2 = (nint)obj8 < value.Length;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					break;
				}
				object obj10 = obj8 + 1;
				bool flag3 = (nint)obj10 < value.Length;
				object obj11 = !flag3;
				if (obj11 != null)
				{
					break;
				}
				object obj12 = obj10 + 1;
				bool flag4 = (nint)obj12 < value.Length;
				object obj13 = !flag4;
				if (obj13 != null)
				{
					break;
				}
				object obj14 = obj12 + 1;
				bool flag5 = (nint)obj14 < value.Length;
				object obj15 = !flag5;
				if (obj15 != null)
				{
					break;
				}
				object obj16 = obj14 + 1;
				bool flag6 = (nint)obj16 < value.Length;
				object obj17 = !flag6;
				if (obj17 != null)
				{
					break;
				}
				object obj18 = obj16 + 1;
				bool flag7 = (nint)obj18 < value.Length;
				object obj19 = !flag7;
				if (obj19 != null)
				{
					break;
				}
				object obj20 = obj18 + 1;
				bool flag8 = (nint)obj20 < value.Length;
				object obj21 = !flag8;
				if (obj21 != null)
				{
					break;
				}
				object obj22 = obj4 + obj5;
				object obj23 = obj22 | 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X13_v12+1]");
				object obj24 = (((nint)0 != 0) ? obj23 : obj22);
				object obj25 = obj24 | 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X13_v12+2]");
				if ((nint)0 != 0)
				{
					obj24 = obj25;
				}
				object obj26 = obj24 | 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X13_v12+3]");
				if ((nint)0 != 0)
				{
					obj24 = obj26;
				}
				object obj27 = obj24 | 0x10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X13_v12+4]");
				if ((nint)0 != 0)
				{
					obj24 = obj27;
				}
				object obj28 = obj24 | 0x20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X13_v12+5]");
				if ((nint)0 != 0)
				{
					obj24 = obj28;
				}
				object obj29 = obj24 | 0x40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X13_v12+6]");
				if ((nint)0 != 0)
				{
					obj24 = obj29;
				}
				object obj30 = obj24 | 0xFFFFFF80L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X13_v12+7]");
				if ((nint)0 == 0)
				{
					object obj31 = obj24;
				}
				else
				{
					object obj31 = obj30;
				}
				bool flag9 = (nint)obj6 < array.Length;
				object obj32 = !flag9;
				if (obj32 != null)
				{
					break;
				}
				obj6++;
				obj5 = obj20 + 1;
				if (num != (nint)obj6)
				{
					continue;
				}
				goto IL_0370;
			}
			goto IL_044c;
		}
		object obj33 = 0;
		num = 0;
		goto IL_05ef;
		IL_0370:
		obj33 = obj5 + 8;
		goto IL_05ef;
		IL_05ef:
		object obj34 = value.Length - obj33;
		if (value.Length > (nint)obj33)
		{
			object obj35 = (object)value + obj33;
			object obj36 = obj35 + 32;
			object obj37 = 0;
			object obj38 = 0;
			do
			{
				object obj39 = 1 << (int)obj37;
				obj37++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X11_v5+v414 @ X10_v5]");
				object obj40 = (((nint)0 != 0) ? obj39 : ((object)0));
				obj38 = obj40 | obj38;
			}
			while (obj34 != obj37);
			bool flag10 = num < array.Length;
			object obj41 = !flag10;
			if (obj41 != null)
			{
				goto IL_044c;
			}
			object obj42 = array + num;
			num++;
		}
		stream.Write(array, 0, num);
		return;
		IL_044c:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal void WriteInt16Array(StreamBuffer stream, short[] value, bool writeType)
	{
		//IL_00ad: Expected Obj, but got I8
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		if (writeType)
		{
			if (stream == null)
			{
				goto IL_014c;
			}
			stream.WriteByte(68);
		}
		if (value == null)
		{
			goto IL_014c;
		}
		WriteCompressedUInt32(stream, (uint)value.Length);
		if (value.Length < 1)
		{
			return;
		}
		object obj = value.Length & 0xFFFFFFFFL;
		object obj2 = value + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			if (stream != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X22_v5+v71 @ X21_v7*2]");
				byte v = (byte)((nint)0 >> 8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X22_v5+v71 @ X21_v7*2]");
				stream.WriteBytes(0, v);
				obj = value.Length;
				obj3++;
				if ((nint)obj3 >= value.Length)
				{
					return;
				}
				continue;
			}
			goto IL_014c;
		}
		goto IL_015a;
		IL_014c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_015a;
		IL_015a:
		throw new IndexOutOfRangeException();
	}

	internal void WriteSingleArray(StreamBuffer stream, float[] values, bool setType)
	{
		//IL_0030: Expected I4, but got Obj
		if (setType)
		{
			stream.WriteByte((byte)(int)typeof(_0021_00210));
		}
		WriteCompressedUInt32(stream, (uint)values.Length);
		int num = values.Length << 2;
		byte[] bufferAndAdvance = stream.GetBufferAndAdvance(num, out var offset);
		Buffer.BlockCopy(values, 0, bufferAndAdvance, offset, num);
	}

	internal void WriteDoubleArray(StreamBuffer stream, double[] values, bool setType)
	{
		if (setType)
		{
			stream.WriteByte(70);
		}
		WriteCompressedUInt32(stream, (uint)values.Length);
		int num = values.Length << 3;
		byte[] bufferAndAdvance = stream.GetBufferAndAdvance(num, out var offset);
		Buffer.BlockCopy(values, 0, bufferAndAdvance, offset, num);
	}

	internal void WriteStringArray(StreamBuffer stream, object value0, bool writeType)
	{
		//IL_0091: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		bool flag2 = default;
		object obj4;
		object obj5;
		if (value0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj2 = default;
			if (obj2 == null)
			{
				throw new InvalidCastException();
			}
			bool flag = !flag2;
			object obj3 = !flag;
			obj4 = obj2;
			if (obj3 != null)
			{
				goto IL_00a8;
			}
			obj5 = obj2;
		}
		else
		{
			bool flag3 = !flag2;
			obj4 = 0;
			obj5 = 0;
			if (!flag3)
			{
				goto IL_00a8;
			}
		}
		goto IL_00c3;
		IL_00a8:
		stream.WriteByte(71);
		obj5 = obj4;
		goto IL_00c3;
		IL_00c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X21_v4+18]");
		WriteCompressedUInt32(stream, 0u);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X21_v4+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X21_v4+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj7 = obj5 + 32;
		object obj8 = 0;
		int num = default;
		string text2 = default;
		InvalidDataException ex = default;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			object obj9 = !flag4;
			if (obj9 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X23_v6+v155 @ X22_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X23_v6+v155 @ X22_v7*8]");
				WriteString(stream, (string)0, writeType: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X21_v4+18]");
				obj6 = 0;
				obj8++;
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X21_v4+18]");
				if ((nint)obj10 >= 0)
				{
					return;
				}
				continue;
			}
			string text = num.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string message = text2 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			break;
		}
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void WriteObjectArray(StreamBuffer stream, object array, bool writeType)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I4
		IList array2;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A98]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			IList list = default;
			bool flag = list == null;
			object obj2 = !flag;
			array2 = list;
			if (obj2 == null)
			{
				throw new InvalidCastException();
			}
		}
		else
		{
			array2 = null;
		}
		WriteObjectArray(stream, array2, writeType);
	}

	private void WriteObjectArray(StreamBuffer stream, IList array, bool writeType)
	{
		//IL_0025: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_03e2: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_01cc: Expected I, but got Obj
		//IL_01dc: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_03c5: Expected I4, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		bool flag2 = default;
		bool flag = !flag2;
		IList list = array;
		if (!flag)
		{
			stream.WriteByte(23);
			list = null;
		}
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3 (Il2CppClass<System.Collections.IList>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3 (Il2CppClass<System.Collections.IList>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3 (Il2CppClass<System.Collections.IList>)+98]");
		object obj3 = (nint)0 + (nint)8;
		object obj4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X10_v18-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj2--;
			obj4 = obj3 + 16;
			bool flag3 = (nint)obj2 != 1;
			obj3 = obj4;
			if (flag3)
			{
				continue;
			}
			goto IL_00c9;
		}
		object obj5 = obj3 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		obj4 = obj3;
		goto IL_02e2;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A98]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ X0_v5] (should have been resolved before IL gen)");
		uint num2 = default;
		WriteCompressedUInt32(stream, num2);
		uint num3 = num2;
		object obj9 = 0;
		object obj15 = default;
		object obj20 = default;
		while (true)
		{
			nint num4 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v7 (Il2CppClass<System.Collections.IList>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v7 (Il2CppClass<System.Collections.IList>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0176;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v7 (Il2CppClass<System.Collections.IList>)+98]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X10_v13-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj10--;
				obj4 = obj11 + 16;
				bool flag4 = (nint)obj10 != 1;
				obj11 = obj4;
				if (flag4)
				{
					continue;
				}
				goto IL_0176;
			}
			object obj12 = obj11 + 1;
			object obj13 = num4 + obj12;
			object obj14 = obj13 + 312;
			obj4 = obj11;
			goto IL_0345;
			IL_0345:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X0_v10] (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
			{
				break;
			}
			nint num5 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v10 (Il2CppClass<System.Collections.IList>)+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v10 (Il2CppClass<System.Collections.IList>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v10 (Il2CppClass<System.Collections.IList>)+98]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X10_v8-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj16--;
					obj4 = obj17 + 16;
					bool flag5 = (nint)obj16 != 1;
					obj17 = obj4;
					if (flag5)
					{
						continue;
					}
					goto IL_0260;
				}
				object obj18 = num5 + obj17;
				object obj19 = obj18 + 312;
				obj4 = obj17;
				goto IL_0392;
			}
			goto IL_0260;
			IL_0260:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0392;
			IL_0392:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v378 @ X0_v13] (should have been resolved before IL gen)");
			Write(stream, obj20, writeType: true);
			obj9++;
			num3 = (uint)(int)obj20;
			continue;
			IL_0176:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num3 = 1u;
			goto IL_0345;
		}
		return;
		IL_00c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		list = (IList)1;
		goto IL_02e2;
	}

	private void WriteArrayInArray(StreamBuffer stream, object value, bool writeType)
	{
		//IL_0146: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I8
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		if (value != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj2 = default;
			if (obj2 == null)
			{
				throw new InvalidCastException();
			}
			stream.WriteByte(64);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v12+18]");
			WriteCompressedUInt32(stream, 0u);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v12+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v12+18]");
			object obj3 = 0 & 0xFFFFFFFFL;
			object obj4 = obj2 + 32;
			object obj5 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj6 = !flag;
				if (obj6 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X23_v8+v91 @ X22_v9*8]");
				Write(stream, 0, writeType: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v12+18]");
				obj3 = 0;
				obj5++;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v12+18]");
				if ((nint)obj7 >= 0)
				{
					return;
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		bool flag2 = stream == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		stream.WriteByte(64);
		throw new NullReferenceException();
	}

	private void WriteCustomTypeBody(CustomType customType, StreamBuffer stream, object value)
	{
		//IL_0423: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_020c: Expected I4, but got Obj
		//IL_021e: Expected Obj, but got I4
		//IL_03a1: Expected I4, but got Obj
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected I4, but got Unknown
		//IL_01bd: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		CustomType customType2 = default;
		bool flag = customType2 == null;
		object obj2 = default;
		object obj = obj2;
		StreamBuffer streamBuffer2 = default;
		StreamBuffer streamBuffer = streamBuffer2;
		CustomType customType3 = customType2;
		CustomType customType4 = customType2;
		if (!flag)
		{
			bool flag2 = customType2.SerializeStreamFunction == null;
			customType4 = customType2;
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				string message = string.Format(format, customType4.Type, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				NullReferenceException ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				goto IL_0499;
			}
			bool flag3 = streamBuffer2 == null;
			obj = obj2;
			streamBuffer = streamBuffer2;
			customType3 = customType2;
			customType4 = customType2;
			if (!flag3)
			{
				int position = streamBuffer2.Position;
				int position2 = streamBuffer2.Position;
				int num = (streamBuffer2.Position = position2 + 1);
				SerializeStreamMethod serializeStreamFunction = customType2.SerializeStreamFunction;
				bool flag4 = customType2.SerializeStreamFunction == null;
				obj = obj2;
				streamBuffer = null;
				customType3 = (CustomType)num;
				customType4 = customType2;
				if (!flag4)
				{
					obj = (nint)((Delegate)serializeStreamFunction).method;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v126.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					int position3 = streamBuffer2.Position;
					int num3 = ~position;
					customType4 = (CustomType)(position3 + num3);
					object obj4 = default;
					bool flag5 = customType4 == obj4;
					Protocol18 protocol = (Protocol18)position3;
					if (!flag5)
					{
						bool flag6 = obj2 == null;
						streamBuffer = (StreamBuffer)obj2;
						customType3 = null;
						if (flag6)
						{
							goto IL_03ef;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516D68]");
						object format2 = 0;
						object arg2 = default;
						object arg3 = default;
						object obj6 = default;
						string text = string.Format((string)format2, arg2, arg3, obj6);
						Debug.WriteLine(text);
						obj = obj6;
						protocol = (Protocol18)(object)text;
					}
					int num4 = protocol.WriteCompressedUInt32(memCustomTypeBodyLengthSerialized, (uint)(int)customType4);
					object obj7 = num4 - 1;
					if (num4 != 1)
					{
						if ((nint)obj7 >= 1)
						{
							do
							{
								streamBuffer2.WriteByte(0);
								obj7--;
							}
							while ((nint)obj7 != 1);
						}
						byte[] buffer = streamBuffer2.GetBuffer();
						byte[] buffer2 = streamBuffer2.GetBuffer();
						int num5 = num4 + position;
						int srcOffset = position + 1;
						Buffer.BlockCopy(buffer, srcOffset, buffer2, num5, (int)customType4);
						byte[] buffer3 = streamBuffer2.GetBuffer();
						Buffer.BlockCopy(memCustomTypeBodyLengthSerialized, 0, buffer3, position, num4);
						int position4 = num5 + customType4;
						streamBuffer2.Position = position4;
						return;
					}
					byte[] buffer4 = streamBuffer2.GetBuffer();
					byte[] array = memCustomTypeBodyLengthSerialized;
					bool flag7 = memCustomTypeBodyLengthSerialized == null;
					streamBuffer = (StreamBuffer)(object)customType4;
					customType3 = null;
					if (!flag7)
					{
						bool flag8 = buffer4 == null;
						streamBuffer = (StreamBuffer)(object)customType4;
						customType3 = null;
						if (!flag8)
						{
							bool flag9 = position < buffer4.Length;
							object obj8 = !flag9;
							if (obj8 == null)
							{
								object obj9 = buffer4 + position;
								_ = array[0];
								return;
							}
							goto IL_0499;
						}
					}
				}
			}
		}
		goto IL_03ef;
		IL_0499:
		throw new IndexOutOfRangeException();
		IL_03ef:
		throw new NullReferenceException();
	}

	private unsafe void WriteCustomType(StreamBuffer stream, object value, bool writeType)
	{
		//IL_042f: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		//IL_044d: Expected Obj, but got I
		//IL_0376: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_00fc: Expected I4, but got Obj
		//IL_0130: Expected Obj, but got Ref
		//IL_03b2: Expected Obj, but got I4
		//IL_0268: Expected I4, but got Obj
		//IL_0278: Expected Obj, but got Ref
		//IL_0172: Expected I4, but got Obj
		//IL_0182: Expected Obj, but got Ref
		//IL_02a0: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I4
		//IL_02be: Expected I4, but got Obj
		//IL_02ce: Expected Obj, but got Ref
		//IL_02ea: Expected I4, but got Obj
		//IL_02fa: Expected Obj, but got Ref
		//IL_0214: Expected I4, but got Obj
		//IL_0224: Expected Obj, but got Ref
		//IL_0335: Expected I4, but got Obj
		//IL_033e: Expected Obj, but got I4
		//IL_024c: Expected I4, but got I8
		bool flag = value == null;
		System.__Canon _Canon = (System.__Canon)(object)stream;
		object obj = value;
		System.__Canon _Canon2 = (System.__Canon)109924352;
		if (flag)
		{
			goto IL_037b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
		object obj2 = 0;
		nint num = (nint)value;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v5 (Il2CppClass<System.Object>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v9+130]");
		bool flag2 = num2 < 0;
		object obj5 = !flag2;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v5 (Il2CppClass<System.Object>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v9+130]");
			object obj7 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X9_v9-8]");
			if (0 == (nint)obj3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X2 (System.Object)+18]");
				_Canon2 = (System.__Canon)0;
				goto IL_049a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		System.__Canon _Canon3 = default;
		_Canon2 = _Canon3;
		goto IL_049a;
		IL_049a:
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v24+A0]");
		object obj10 = 0;
		bool flag4 = obj10 == null;
		_Canon = (System.__Canon)(object)stream;
		obj = value;
		System.__Canon value2;
		bool flag9 = default;
		byte value3;
		bool flag5;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516990]");
			object obj11 = 0;
			flag5 = (byte)(int)obj11 != 0;
			bool flag6 = ((Dictionary<System.__Canon, System.__Canon>)obj10).TryGetValue(_Canon2, out value2);
			bool flag7 = !flag6;
			_Canon = _Canon2;
			obj = (object)(&value2);
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				bool flag8 = _Canon2 == null;
				object obj12 = !flag8;
				string text;
				if (obj12 == null)
				{
					text = null;
				}
				else
				{
					string text2 = _Canon2.ToString();
					text = text2;
				}
				string text3 = default;
				string message = text3 + text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Exception ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			if (flag9)
			{
				bool flag10 = value2 == null;
				flag9 = (byte)(int)obj11 != 0;
				_Canon = _Canon2;
				obj = (object)(&value2);
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ stack_-38_v4 (System.__Canon)+10]");
					bool flag11 = (nint)0 < (nint)99;
					object obj13 = !flag11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ stack_-38_v4 (System.__Canon)+10]");
					object obj14 = -99;
					bool flag12 = obj14 == null;
					object obj15 = !flag12;
					object obj16 = obj13 & obj15;
					if (obj16 == null)
					{
						bool flag13 = stream == null;
						flag9 = (byte)(int)obj11 != 0;
						_Canon = _Canon2;
						obj = (object)(&value2);
						if (!flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ stack_-38_v4 (System.__Canon)+10]");
							value3 = 128;
							goto IL_047a;
						}
					}
					else
					{
						bool flag14 = stream == null;
						flag9 = (byte)(int)obj11 != 0;
						_Canon = _Canon2;
						obj = (object)(&value2);
						if (!flag14)
						{
							stream.WriteByte(19);
							bool flag15 = value2 == null;
							System.__Canon _Canon4 = value2;
							flag9 = (byte)(int)obj11 != 0;
							_Canon = (System.__Canon)19;
							obj = null;
							if (!flag15)
							{
								goto IL_0351;
							}
						}
					}
				}
			}
			else
			{
				bool flag16 = value2 == null;
				flag9 = (byte)(int)obj11 != 0;
				_Canon = _Canon2;
				obj = (object)(&value2);
				if (!flag16)
				{
					bool flag17 = stream == null;
					object obj17 = !flag17;
					System.__Canon _Canon4 = value2;
					if (obj17 != null)
					{
						goto IL_0351;
					}
					flag9 = (byte)(int)obj11 != 0;
					_Canon = _Canon2;
					obj = (object)(&value2);
				}
			}
		}
		goto IL_037b;
		IL_037b:
		flag5 = flag9;
		throw new NullReferenceException();
		IL_0351:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v16 (System.__Canon)+10]");
		value3 = 0;
		goto IL_047a;
		IL_047a:
		stream.WriteByte(value3);
		WriteCustomTypeBody((CustomType)(object)value2, stream, value);
	}

	private unsafe void WriteCustomTypeArray(StreamBuffer stream, object value, bool writeType)
	{
		//IL_0015: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I4
		//IL_0a24: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0124: Expected I4, but got Obj
		//IL_0150: Expected Obj, but got Ref
		//IL_077c: Expected Obj, but got I4
		//IL_07a9: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got Ref
		//IL_0200: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got Ref
		//IL_0ac9: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_081a: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_0ce0: Expected Obj, but got I4
		//IL_0b38: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_08d3: Expected Obj, but got I
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_099d: Expected Obj, but got I4
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_090e: Expected Obj, but got I
		//IL_0717: Expected Obj, but got Ref
		//IL_071f: Expected Obj, but got Ref
		//IL_072d: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got I
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected Obj, but got Unknown
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected Obj, but got Unknown
		//IL_0bc7: Expected Obj, but got Ref
		//IL_0bcf: Expected Obj, but got Ref
		//IL_0bdd: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected Obj, but got Unknown
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected Obj, but got Unknown
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected Obj, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_05e2: Expected Obj, but got I
		//IL_06ad: Expected Obj, but got I4
		//IL_0c4f: Expected I4, but got Obj
		//IL_061d: Expected Obj, but got I
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Expected Obj, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		object obj = default;
		bool flag = obj == null;
		bool flag3 = default;
		bool flag2 = flag3;
		object obj2 = obj;
		bool flag4 = flag3;
		object obj4 = default;
		object obj9 = default;
		System.__Canon value2;
		bool flag14 = default;
		OutOfMemoryException ex4 = default;
		object obj21 = default;
		ArgumentNullException ex3;
		bool flag19;
		object obj11;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A98]");
			object obj3 = 0;
			System.__Canon _Canon = (System.__Canon)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag5 = obj4 == null;
			obj2 = obj;
			flag4 = flag3;
			if (flag5)
			{
				flag2 = flag2;
				System.__Canon _Canon2 = _Canon;
				throw new InvalidCastException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			object obj5 = default;
			bool flag6 = obj5 == null;
			flag2 = flag3;
			obj2 = obj;
			flag4 = flag3;
			if (!flag6)
			{
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
				_Canon = (System.__Canon)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X8_v23+418] (should have been resolved before IL gen)");
				nint num = (nint)_Canon;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v24 (Il2CppClass<System.__Canon>)+E4]");
				bool flag7 = (nint)0 == 0;
				object obj7 = !flag7;
				nint num2 = num;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num2 = (nint)_Canon;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v25 (Il2CppClass<System.__Canon>)+A0]");
				object obj8 = 0;
				bool flag8 = obj8 == null;
				flag2 = flag3;
				obj2 = obj9;
				flag4 = flag3;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516990]");
					object obj10 = 0;
					flag2 = (byte)(int)obj10 != 0;
					bool flag9 = ((Dictionary<System.__Canon, System.__Canon>)obj8).TryGetValue((System.__Canon)obj9, out value2);
					bool flag10 = !flag9;
					obj = (object)(&value2);
					System.__Canon _Canon2 = (System.__Canon)obj9;
					obj2 = obj9;
					flag4 = flag3;
					if (!flag10)
					{
						bool flag11 = !flag3;
						obj11 = (object)(&value2);
						if (!flag11)
						{
							bool flag12 = stream == null;
							obj = (object)(&value2);
							obj2 = obj9;
							flag4 = flag3;
							if (flag12)
							{
								goto IL_0732;
							}
							stream.WriteByte(83);
							obj11 = null;
						}
						object obj12 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A90]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v29+12E]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v29+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02c8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v29+98]");
						object obj15 = (nint)0 + (nint)8;
						bool flag13 = flag14;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X10_v39-8]");
							object obj16 = 0 - obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X10_v39-8]");
							if (0 == (nint)obj13)
							{
								break;
							}
							obj14--;
							obj16 = obj14 - 1;
							bool flag15 = obj16 == null;
							obj13 = obj15 + 16;
							flag14 = (nint)obj14 != 1;
							flag13 = flag14;
							obj15 = obj13;
							if (flag14)
							{
								continue;
							}
							goto IL_02c8;
						}
						object obj17 = obj15 + 1;
						object obj18 = obj12 + obj17;
						object obj19 = obj18 + 312;
						flag14 = flag13;
						obj13 = obj15;
						goto IL_0a9a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					bool flag16 = obj2 == null;
					object obj20 = !flag16;
					string text;
					if (obj20 == null)
					{
						text = null;
					}
					else
					{
						int hashCode = obj2.GetHashCode();
						text = (string)hashCode;
					}
					string text2 = default;
					string message = text2 + text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Exception ex = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					ArgumentNullException ex2 = new ArgumentNullException();
					bool flag17 = default;
					if ((flag17 ? 1 : 0) == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj21 = 1;
						obj = null;
					}
					else
					{
						bool flag18 = !flag17;
						obj = null;
						flag19 = flag17;
						ex3 = ex2;
						if (flag18)
						{
							goto IL_0ca3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						object obj22 = default;
						ex4 = (OutOfMemoryException)obj22;
						obj = null;
					}
					goto IL_087f;
				}
			}
		}
		goto IL_0732;
		IL_0b28:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		flag4 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ X0_v65] (should have been resolved before IL gen)");
		object obj23 = default;
		StreamBuffer streamBuffer;
		object obj30 = default;
		object obj32 = default;
		object obj34 = default;
		object obj41 = default;
		object obj31;
		while (true)
		{
			if (obj23 != null)
			{
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v39+12E]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v39+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0561;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v39+98]");
				object obj26 = (nint)0 + (nint)8;
				bool flag20 = flag14;
				object obj13;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X10_v29-8]");
					object obj16 = 0 - obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X10_v29-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj25--;
					obj16 = obj25 - 1;
					bool flag15 = obj16 == null;
					obj13 = obj26 + 16;
					flag14 = (nint)obj25 != 1;
					flag20 = flag14;
					obj26 = obj13;
					if (flag14)
					{
						continue;
					}
					goto IL_0561;
				}
				object obj27 = obj24 + obj26;
				object obj28 = obj27 + 312;
				flag14 = flag20;
				obj13 = obj26;
				obj = streamBuffer;
				goto IL_0b98;
			}
			NullReferenceException ex5 = new NullReferenceException();
			obj = streamBuffer;
			goto IL_0706;
			IL_0b98:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v817 @ X0_v72] (should have been resolved before IL gen)");
			object obj29 = obj30 & 1;
			bool flag21 = obj29 == null;
			obj31 = (object)(&obj32);
			object obj33 = (object)(&obj34);
			ex4 = null;
			obj21 = 0;
			if (flag21)
			{
				break;
			}
			if (obj23 != null)
			{
				object obj35 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v42+12E]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v42+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v42+98]");
					object obj37 = (nint)0 + (nint)8;
					bool flag22 = flag14;
					object obj13;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X10_v24-8]");
						object obj16 = 0 - obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X10_v24-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj36--;
						obj16 = obj36 - 1;
						bool flag15 = obj16 == null;
						obj13 = obj37 + 16;
						flag14 = (nint)obj36 != 1;
						flag22 = flag14;
						obj37 = obj13;
						if (flag14)
						{
							continue;
						}
						goto IL_069a;
					}
					object obj38 = obj37 + 1;
					object obj39 = obj35 + obj38;
					object obj40 = obj39 + 312;
					flag14 = flag22;
					obj13 = obj37;
					goto IL_0c2b;
				}
				goto IL_069a;
			}
			goto IL_0706;
			IL_069a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj = 1;
			goto IL_0c2b;
			IL_0c2b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v880 @ X0_v75] (should have been resolved before IL gen)");
			WriteCustomTypeBody((CustomType)(object)value2, stream, obj41);
			flag2 = (byte)(int)obj41 != 0;
			streamBuffer = stream;
			continue;
			IL_0706:
			NullReferenceException ex6 = new NullReferenceException();
			obj31 = (object)(&obj32);
			obj33 = (object)(&obj34);
			ex4 = null;
			obj21 = 0;
			goto IL_0732;
			IL_0561:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj = null;
			goto IL_0b98;
		}
		goto IL_087f;
		IL_087f:
		flag19 = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj42 = default;
		obj31 = obj42;
		if (obj42 == null)
		{
			goto IL_0cc6;
		}
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v10+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_094f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v10+98]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X10_v8-8]");
			if ((nint)0 == (((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0))
			{
				break;
			}
			obj44--;
			obj45 += 16;
			if ((nint)obj44 != 1)
			{
				continue;
			}
			goto IL_094f;
		}
		object obj46 = obj43 + obj45;
		object obj47 = obj46 + 312;
		goto IL_0d17;
		IL_0ca3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0cc6:
		bool flag23 = ex4 == null;
		object obj48 = !flag23;
		if (obj48 == null)
		{
			bool flag24 = obj21 == null;
			object obj49 = !flag24;
			OutOfMemoryException ex7 = ex4;
			if (obj49 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex7 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		ArgumentNullException ex8 = default;
		ex3 = ex8;
		goto IL_0ca3;
		IL_0d17:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v16+8]");
		flag19 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v758 @ X0_v16] (should have been resolved before IL gen)");
		goto IL_0cc6;
		IL_0a9a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ X0_v60] (should have been resolved before IL gen)");
		uint num3 = default;
		WriteCompressedUInt32(stream, num3);
		bool flag25 = value2 == null;
		obj = num3;
		obj2 = obj9;
		flag4 = flag3;
		if (!flag25)
		{
			bool flag26 = stream == null;
			obj = num3;
			obj2 = obj9;
			flag4 = flag3;
			if (!flag26)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8968]");
				object obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ stack_-38_v7 (System.__Canon)+10]");
				stream.WriteByte(0);
				object obj51 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v33+12E]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v33+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0448;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v33+98]");
				object obj53 = (nint)0 + (nint)8;
				bool flag27 = flag14;
				object obj13;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X10_v34-8]");
					object obj16 = 0 - obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X10_v34-8]");
					if (0 == (nint)obj50)
					{
						break;
					}
					obj52--;
					obj16 = obj52 - 1;
					bool flag15 = obj16 == null;
					obj13 = obj53 + 16;
					flag14 = (nint)obj52 != 1;
					flag27 = flag14;
					obj53 = obj13;
					if (flag14)
					{
						continue;
					}
					goto IL_0448;
				}
				object obj54 = obj51 + obj53;
				object obj55 = obj54 + 312;
				flag14 = flag27;
				obj13 = obj53;
				streamBuffer = null;
				goto IL_0b28;
			}
		}
		goto IL_0732;
		IL_0732:
		throw new NullReferenceException();
		IL_02c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj11 = 1;
		goto IL_0a9a;
		IL_094f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj = null;
		goto IL_0d17;
		IL_0448:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		streamBuffer = null;
		goto IL_0b28;
	}

	private bool WriteArrayHeader(StreamBuffer stream, Type type)
	{
		//IL_0025: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_00cf: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_01ae: Expected I4, but got I8
		Type type2 = default;
		if ((object)type2 != null)
		{
			nint num = (nint)type2;
			bool isEnum = ((System.RuntimeType)type2).IsEnum;
			bool flag = !isEnum;
			Protocol18 protocol = this;
			StreamBuffer streamBuffer = stream;
			if (!flag)
			{
				Type type3 = type2;
				Type type4 = (Type)isEnum;
				nint num2 = num;
				object obj;
				do
				{
					bool isArray = type4.IsArray;
					bool flag2 = !isArray;
					type2 = type3;
					Type type5 = type4;
					protocol = this;
					streamBuffer = stream;
					num = num2;
					if (!flag2)
					{
						bool flag3 = stream == null;
						type2 = type3;
						type5 = type4;
						protocol = this;
						streamBuffer = stream;
						num = num2;
						if (flag3)
						{
							break;
						}
						stream.WriteByte(64);
						num = (nint)type4;
						bool isEnum2 = ((System.RuntimeType)type4).IsEnum;
						bool flag4 = !isEnum2;
						obj = !flag4;
						type2 = null;
						type5 = (Type)isEnum2;
						protocol = this;
						streamBuffer = stream;
						type3 = null;
						type4 = (Type)isEnum2;
						num2 = num;
						continue;
					}
					SocketTcpAsync.GpType codeOfType = protocol.GetCodeOfType(type5);
					object obj2 = codeOfType & (SocketTcpAsync.GpType)0xFF;
					if (obj2 != null)
					{
						bool flag5 = streamBuffer == null;
						protocol = (Protocol18)codeOfType;
						if (flag5)
						{
							break;
						}
						byte value = (byte)((int)codeOfType | 0xFFFFFF80L);
						streamBuffer.WriteByte(value);
					}
					object obj3 = codeOfType & (SocketTcpAsync.GpType)0xFF;
					bool flag6 = obj3 == null;
					return !flag6;
				}
				while (obj != null);
			}
		}
		throw new NullReferenceException();
	}

	private void WriteDictionaryElements(StreamBuffer stream, IDictionary dictionary, SocketTcpAsync.GpType keyWriteType, SocketTcpAsync.GpType valueWriteType)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		object obj = 109924352;
		IDictionary dictionary2 = default;
		if (dictionary2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CE44");
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		StreamBuffer streamBuffer = default;
		NullReferenceException ex2;
		if ((nint)streamBuffer == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		else
		{
			bool flag = (nint)streamBuffer != 1;
			ex2 = ex;
			if (flag)
			{
				goto IL_021a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		streamBuffer = (StreamBuffer)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj3 = default;
		object obj2 = obj3;
		if (obj3 == null)
		{
			goto IL_023d;
		}
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v10+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0171;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v10+98]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5--;
			obj6 += 16;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_0171;
		}
		object obj7 = obj4 + obj6;
		object obj8 = obj7 + 312;
		goto IL_0289;
		IL_0171:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0289;
		IL_021a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0289:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v17+8]");
		streamBuffer = (StreamBuffer)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v17] (should have been resolved before IL gen)");
		goto IL_023d;
		IL_023d:
		object obj9 = default;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			bool flag3 = 1 == 0;
			object obj11 = !flag3;
			OutOfMemoryException ex3 = (OutOfMemoryException)obj9;
			if (obj11 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex4 = default;
		ex2 = ex4;
		goto IL_021a;
	}

	private void WriteDictionary(StreamBuffer stream, object dict, bool setType)
	{
		//IL_00bf: Expected I4, but got Obj
		//IL_0036: Expected Obj, but got I
		bool flag = !setType;
		object obj = dict;
		byte b = (byte)(int)stream;
		if (!flag)
		{
			stream.WriteByte(20);
			obj = null;
			b = 20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		Type type = default;
		WriteDictionaryHeader(stream, type, out var keyWriteType, out var valueWriteType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		IDictionary dictionary = default;
		if (dictionary != null)
		{
			WriteDictionaryElements(stream, dictionary, keyWriteType, valueWriteType);
			return;
		}
		throw new InvalidCastException();
	}

	private unsafe void WriteDictionaryHeader(StreamBuffer stream, Type type, out SocketTcpAsync.GpType keyWriteType, out SocketTcpAsync.GpType valueWriteType)
	{
		//IL_098d: Expected Obj, but got I4
		//IL_002d: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_09f6: Expected Obj, but got I
		//IL_0a06: Expected Obj, but got I
		//IL_0a7b: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_0105: Expected VT, but got I
		//IL_0127: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I8
		//IL_04c2: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I4
		//IL_03c0: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I
		//IL_0517: Expected VT, but got I
		//IL_0539: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I
		//IL_02fc: Expected VT, but got I
		//IL_031e: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I8
		//IL_0341: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I8
		//IL_0720: Expected Obj, but got I
		//IL_0732: Expected Obj, but got I4
		//IL_0906: Expected Obj, but got I8
		//IL_092b: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I
		//IL_06c4: Expected Obj, but got I4
		//IL_0957: Expected Obj, but got I
		//IL_07ce: Expected Obj, but got I8
		//IL_07fa: Expected Obj, but got I
		//IL_0798: Expected Obj, but got I
		//IL_087c: Expected Obj, but got I8
		//IL_0818: Expected Obj, but got I
		//IL_082e: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I4
		//IL_08b1: Expected Obj, but got I
		//IL_08c1: Expected Obj, but got I
		Type type2 = default;
		bool flag = (object)type2 == null;
		StreamBuffer streamBuffer = stream;
		bool flag2;
		bool flag4 = default;
		ref SocketTcpAsync.GpType reference = default;
		if (!flag)
		{
			nint num = (nint)type2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v9 (Il2CppClass<System.Type>)+460]");
			streamBuffer = (StreamBuffer)0;
			flag2 = ((System.RuntimeType)type2).IsPrimitiveImpl();
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
				bool flag3 = (nint)0 == 0;
				flag4 = flag2;
				if (flag3)
				{
					goto IL_09bb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+E8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v27+E4]");
				bool flag5 = (nint)0 == 0;
				object obj3 = !flag5;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+10]");
				RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+20]");
				if ((Type)0 == typeFromHandle)
				{
					bool flag6 = stream == null;
					type2 = null;
					flag4 = flag2;
					streamBuffer = (StreamBuffer)(object)typeFromHandle;
					if (!flag6)
					{
						stream.WriteByte(0);
						reference = ref *(SocketTcpAsync.GpType*)null;
						type2 = null;
						streamBuffer = null;
						goto IL_0473;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
					bool flag7 = (nint)0 == 0;
					type2 = null;
					flag4 = flag2;
					streamBuffer = (StreamBuffer)(object)typeFromHandle;
					if (flag7)
					{
						goto IL_09bb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+20]");
					bool flag8 = (nint)0 == 0;
					type2 = null;
					flag4 = flag2;
					streamBuffer = (StreamBuffer)(object)typeFromHandle;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+20]");
						bool isPrimitive = ((Type)0).IsPrimitive;
						bool flag9 = !isPrimitive;
						object obj4 = !flag9;
						Type type3 = null;
						StreamBuffer streamBuffer2 = null;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
							bool flag10 = (nint)0 == 0;
							type2 = null;
							flag4 = flag2;
							streamBuffer = null;
							if (flag10)
							{
								goto IL_09bb;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+E8]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v63+E4]");
							bool flag11 = (nint)0 == 0;
							object obj6 = !flag11;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+98]");
							RuntimeTypeHandle handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
							Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+20]");
							bool flag12 = (Type)0 != typeFromHandle2;
							bool flag13 = !flag12;
							object obj7 = !flag13;
							type3 = null;
							streamBuffer2 = (StreamBuffer)(object)typeFromHandle2;
							type2 = null;
							flag4 = flag2;
							streamBuffer = (StreamBuffer)(object)typeFromHandle2;
							if (obj7 != null)
							{
								goto IL_096b;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
						bool flag14 = (nint)0 == 0;
						type2 = type3;
						flag4 = flag2;
						streamBuffer = streamBuffer2;
						if (flag14)
						{
							goto IL_09bb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+20]");
						SocketTcpAsync.GpType codeOfType = GetCodeOfType((Type)0);
						object obj8 = codeOfType & (SocketTcpAsync.GpType)0xFF;
						bool flag15 = obj8 == null;
						reference = ref *(SocketTcpAsync.GpType*)(byte)codeOfType;
						type2 = type3;
						flag4 = flag2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+20]");
						streamBuffer = (StreamBuffer)0;
						if (flag15)
						{
							goto IL_096b;
						}
						bool flag16 = stream == null;
						type2 = type3;
						flag4 = flag2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+20]");
						streamBuffer = (StreamBuffer)0;
						if (!flag16)
						{
							stream.WriteByte((byte)codeOfType);
							type2 = null;
							streamBuffer = (StreamBuffer)codeOfType;
							goto IL_0473;
						}
					}
				}
			}
		}
		goto IL_095d;
		IL_0862:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
		object obj9 = 0 & 0xFFFFFFFEL;
		bool flag17 = obj9 == null;
		flag4 = flag2;
		if (flag17)
		{
			goto IL_09bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B60]");
		object obj11 = 0;
		ref SocketTcpAsync.GpType reference2 = ref valueWriteType;
		Type type4 = type2;
		StreamBuffer streamBuffer3 = streamBuffer;
		goto IL_0a57;
		IL_09bb:
		reference2 = ref valueWriteType;
		type4 = type2;
		bool flag18 = flag4;
		streamBuffer3 = streamBuffer;
		throw new IndexOutOfRangeException();
		IL_096b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X19_v5 (System.Boolean)+18]");
		bool flag19 = (nint)0 == 0;
		object obj12 = !flag19;
		reference2 = ref reference;
		type4 = type2;
		flag18 = flag4;
		streamBuffer3 = streamBuffer;
		if (obj12 == null)
		{
			goto IL_09bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X19_v4 (System.Boolean)+20]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B58]");
		obj11 = 0;
		goto IL_0a57;
		IL_0a57:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		bool flag20 = obj10 == null;
		object obj13 = !flag20;
		string text;
		if (obj13 == null)
		{
			text = null;
		}
		else
		{
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X8_v3+168] (should have been resolved before IL gen)");
			string text2 = default;
			text = text2;
		}
		string text3 = default;
		string message = text3 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidDataException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
		IL_0473:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
		object obj15 = 0 & 0xFFFFFFFEL;
		bool flag21 = obj15 == null;
		flag4 = flag2;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+E8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v34+E4]");
			bool flag22 = (nint)0 == 0;
			object obj17 = !flag22;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+10]");
			RuntimeTypeHandle handle3 = (RuntimeTypeHandle)((nint)0 + (nint)32);
			Type typeFromHandle3 = Type.GetTypeFromHandle(handle3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
			if ((Type)0 == typeFromHandle3)
			{
				stream.WriteByte(0);
				ref SocketTcpAsync.GpType reference3 = ref *(SocketTcpAsync.GpType*)null;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
			object obj18 = 0 & 0xFFFFFFFEL;
			bool flag23 = obj18 == null;
			type2 = null;
			flag4 = flag2;
			streamBuffer = (StreamBuffer)(object)typeFromHandle3;
			if (!flag23)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
				bool flag24 = (nint)0 == 0;
				type2 = null;
				flag4 = flag2;
				streamBuffer = (StreamBuffer)(object)typeFromHandle3;
				if (flag24)
				{
					goto IL_095d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
				bool isArray = ((Type)0).IsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
				object obj19 = 0 & 0xFFFFFFFEL;
				if (isArray)
				{
					bool flag25 = obj19 == null;
					type2 = null;
					flag4 = flag2;
					streamBuffer = null;
					if (!flag25)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
						type2 = (Type)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
						bool flag26 = WriteArrayType(stream, (Type)0, out valueWriteType);
						bool flag27 = !flag26;
						object obj20 = !flag27;
						if (obj20 == null)
						{
							streamBuffer = stream;
							goto IL_0862;
						}
						return;
					}
				}
				else
				{
					bool flag28 = obj19 == null;
					type2 = null;
					flag4 = flag2;
					streamBuffer = null;
					if (!flag28)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
						SocketTcpAsync.GpType codeOfType2 = GetCodeOfType((Type)0);
						object obj21 = codeOfType2 & (SocketTcpAsync.GpType)0xFF;
						ref SocketTcpAsync.GpType reference3 = ref *(SocketTcpAsync.GpType*)(byte)codeOfType2;
						if ((nint)obj21 != 20)
						{
							if ((nint)obj21 != 64)
							{
								bool flag29 = obj21 == null;
								type2 = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
								streamBuffer = (StreamBuffer)0;
								if (!flag29)
								{
									stream.WriteByte((byte)codeOfType2);
									return;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
								object obj22 = 0 & 0xFFFFFFFEL;
								bool flag30 = obj22 == null;
								type2 = null;
								flag4 = flag2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
								streamBuffer = (StreamBuffer)0;
								if (flag30)
								{
									goto IL_09bb;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
								type2 = (Type)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
								bool flag31 = WriteArrayHeader(stream, (Type)0);
								bool flag32 = !flag31;
								object obj23 = !flag32;
								streamBuffer = stream;
								if (obj23 != null)
								{
									return;
								}
							}
							goto IL_0862;
						}
						stream.WriteByte(20);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+18]");
						object obj24 = 0 & 0xFFFFFFFEL;
						bool flag33 = obj24 == null;
						type2 = null;
						flag4 = flag2;
						streamBuffer = (StreamBuffer)20;
						if (!flag33)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v26 (System.Boolean)+28]");
							WriteDictionaryHeader(stream, (Type)0, out var _, out var _);
							return;
						}
					}
				}
			}
		}
		goto IL_09bb;
		IL_095d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_096b;
	}

	private unsafe bool WriteArrayType(StreamBuffer stream, Type type, out SocketTcpAsync.GpType writeType)
	{
		//IL_000d: Expected I, but got Obj
		//IL_002a: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_07e3: Expected I4, but got Obj
		//IL_00e9: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I
		//IL_04b6: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_04e9: Expected VT, but got I
		//IL_0503: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I4
		//IL_0583: Expected Obj, but got I
		//IL_05a5: Expected Obj, but got I4
		//IL_082c: Expected Obj, but got I4
		//IL_05d8: Expected VT, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I4
		//IL_0672: Expected Obj, but got I
		//IL_0682: Expected Obj, but got I
		//IL_06a4: Expected Obj, but got I4
		//IL_035b: Expected VT, but got Obj
		//IL_06ca: Expected VT, but got Obj
		//IL_06db: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I4
		//IL_0763: Expected I, but got Obj
		//IL_0228: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I4
		//IL_073a: Expected I4, but got Obj
		//IL_0750: Expected I, but got Obj
		bool flag = (object)type == null;
		Type type2 = type;
		Type type3 = (Type)(object)stream;
		bool flag11;
		nint num3;
		if (!flag)
		{
			nint num = (nint)type;
			bool isEnum = ((System.RuntimeType)type).IsEnum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (Type)isEnum == null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			type2 = null;
			type3 = null;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string assembly = (string)(object)((System.RuntimeType)type).Assembly;
				string text = default;
				string message = text + assembly;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				InvalidDataException ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (byte)(int)ex2 != 0;
			}
			bool flag5 = !isEnum;
			type2 = null;
			type3 = null;
			if (!flag5)
			{
				bool isArray = ((Type)isEnum).IsArray;
				bool flag6 = !isArray;
				Type type4 = null;
				object obj5 = 0;
				Type type5 = (Type)isEnum;
				if (!flag6)
				{
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+E8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v75+E4]");
						bool flag7 = (nint)0 == 0;
						object obj7 = !flag7;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(type5 != null))
						{
							break;
						}
						bool flag8 = (object)type5 == null;
						type2 = null;
						type3 = null;
						if (!flag8)
						{
							if (!type5.IsArray)
							{
								break;
							}
							bool flag9 = stream == null;
							type2 = null;
							type3 = null;
							if (!flag9)
							{
								stream.WriteByte(64);
								nint num2 = (nint)type5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v20 (Il2CppClass<System.Type>)+420]");
								obj5 = 0;
								Type type6 = (Type)((System.RuntimeType)type5).IsEnum;
								type4 = null;
								type5 = type6;
								continue;
							}
						}
						goto IL_0768;
					}
					SocketTcpAsync.GpType codeOfType = GetCodeOfType(type5);
					bool flag10 = stream == null;
					type2 = null;
					type3 = type5;
					if (flag10)
					{
						goto IL_0768;
					}
					byte value = (byte)(codeOfType | (SocketTcpAsync.GpType)0x40);
					stream.WriteByte(value);
					flag11 = true;
					num3 = 64;
				}
				else if (((Type)isEnum).IsPrimitive)
				{
					SocketTcpAsync.GpType codeOfType2 = GetCodeOfType((Type)isEnum);
					byte b = (byte)(codeOfType2 | (SocketTcpAsync.GpType)0x40);
					int num4 = b & 0xFF;
					byte b2 = (byte)((num4 != 226) ? b : 67);
					bool flag12 = stream == null;
					type2 = null;
					type3 = (Type)isEnum;
					if (flag12)
					{
						goto IL_0768;
					}
					stream.WriteByte(b2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+E8]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516D80]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v62+E4]");
					bool flag13 = (nint)0 == 0;
					object obj10 = !flag13;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v17+E4]");
					bool flag14 = (nint)0 == 0;
					object obj12 = !flag14;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object value2 = default;
					flag11 = Enum.IsDefined(typeFromHandle, value2);
					bool flag15 = !flag11;
					object obj13 = !flag15;
					object obj14 = ~obj13;
					byte b3 = (byte)((obj14 == null) ? b2 : 0);
					num3 = (int)b3;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+E8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v32+E4]");
					bool flag16 = (nint)0 == 0;
					object obj16 = !flag16;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+98]");
					RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
					byte value3;
					StreamBuffer streamBuffer;
					if ((Type)isEnum == typeFromHandle2)
					{
						bool flag17 = stream == null;
						type2 = null;
						type3 = typeFromHandle2;
						if (flag17)
						{
							goto IL_0768;
						}
						value3 = 71;
						streamBuffer = stream;
						num3 = 71;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+E8]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v40+E4]");
						bool flag18 = (nint)0 == 0;
						object obj18 = !flag18;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+10]");
						RuntimeTypeHandle handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
						Type typeFromHandle3 = Type.GetTypeFromHandle(handle2);
						if ((Type)isEnum == typeFromHandle3)
						{
							bool flag19 = stream == null;
							type2 = null;
							type3 = typeFromHandle3;
							if (flag19)
							{
								goto IL_0768;
							}
							value3 = 23;
							streamBuffer = stream;
							num3 = 23;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v4+E8]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A10]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v46+E4]");
							bool flag20 = (nint)0 == 0;
							object obj21 = !flag20;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj20);
							if (!((Type)isEnum == typeFromHandle4))
							{
								flag11 = false;
								num3 = unchecked((nint)null);
								goto IL_0847;
							}
							bool flag21 = stream == null;
							type2 = null;
							type3 = typeFromHandle4;
							if (flag21)
							{
								goto IL_0768;
							}
							value3 = (byte)(int)typeof(_0021_00210);
							streamBuffer = stream;
							num3 = (nint)typeof(_0021_00210);
						}
					}
					streamBuffer.WriteByte(value3);
					flag11 = true;
				}
				goto IL_0847;
			}
		}
		goto IL_0768;
		IL_0847:
		ref SocketTcpAsync.GpType reference = ref *(SocketTcpAsync.GpType*)num3;
		return flag11;
		IL_0768:
		throw new NullReferenceException();
	}

	private void WriteHashtableArray(StreamBuffer stream, object value, bool writeType)
	{
		//IL_0091: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00bb: Expected I4, but got Obj
		//IL_011d: Expected Obj, but got I8
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		object obj4;
		object obj5;
		if (value != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CB0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj2 = default;
			if (obj2 == null)
			{
				throw new InvalidCastException();
			}
			bool flag = !writeType;
			object obj3 = !flag;
			obj4 = obj2;
			if (obj3 != null)
			{
				goto IL_00a8;
			}
			obj5 = obj2;
		}
		else
		{
			bool flag2 = !writeType;
			obj4 = 0;
			obj5 = 0;
			if (!flag2)
			{
				goto IL_00a8;
			}
		}
		goto IL_00c8;
		IL_00a8:
		stream.WriteByte((byte)(int)typeof(_0021_00210));
		obj5 = obj4;
		goto IL_00c8;
		IL_00c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X21_v4+18]");
		WriteCompressedUInt32(stream, 0u);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X21_v4+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X21_v4+18]");
		object obj6 = 0 & 0xFFFFFFFFL;
		object obj7 = obj5 + 32;
		object obj8 = 0;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			object obj9 = !flag3;
			if (obj9 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X23_v6+v144 @ X22_v7*8]");
			WriteHashtable(stream, 0, writeType: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X21_v4+18]");
			obj6 = 0;
			obj8++;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X21_v4+18]");
			if ((nint)obj10 >= 0)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void WriteDictionaryArray(StreamBuffer stream, IDictionary[] dictArray, bool writeType)
	{
		//IL_0092: Expected Obj, but got I8
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		stream.WriteByte(84);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		object obj2 = default;
		object obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X8_v2+418] (should have been resolved before IL gen)");
		Type type = default;
		WriteDictionaryHeader(stream, type, out var keyWriteType, out var valueWriteType);
		WriteCompressedUInt32(stream, (uint)dictArray.Length);
		if (dictArray.Length < 1)
		{
			return;
		}
		object obj3 = dictArray.Length & 0xFFFFFFFFL;
		object obj4 = dictArray + 32;
		object obj5 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X25_v4+v31 @ X24_v5*8]");
			WriteDictionaryElements(stream, (IDictionary)0, keyWriteType, valueWriteType);
			obj3 = dictArray.Length;
			obj5++;
			if ((nint)obj5 >= dictArray.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void WriteIntLength(StreamBuffer stream, int value)
	{
		WriteCompressedUInt32(stream, (uint)value);
	}

	private void WriteVarInt32(StreamBuffer stream, int value, bool writeType)
	{
		WriteCompressedInt32(stream, value, writeType);
	}

	private void WriteCompressedInt32(StreamBuffer stream, int value, bool writeType)
	{
		//IL_010b: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		byte value2;
		StreamBuffer streamBuffer;
		if (writeType)
		{
			if (value == 0)
			{
				value2 = 30;
				streamBuffer = stream;
				goto IL_0229;
			}
			if (value >= 1)
			{
				bool flag = value < 255;
				object obj = !flag;
				object obj2 = value - 255;
				bool flag2 = obj2 == null;
				object obj3 = !flag2;
				object obj4 = obj & obj3;
				if (obj4 == null)
				{
					stream.WriteByte(11);
					value2 = (byte)value;
					streamBuffer = stream;
					goto IL_0229;
				}
				int num = value >> 16;
				bool flag3 = num == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					stream.WriteByte(13);
					byte v = (byte)(value >> 8);
					stream.WriteBytes((byte)value, v);
					return;
				}
			}
			else
			{
				bool flag4 = value < 4294901761L;
				object obj6 = !flag4;
				object obj7 = ~obj6;
				if (obj7 == null)
				{
					stream.WriteByte(14);
					ushort value3 = (ushort)(-value);
					((Protocol18)(object)stream).WriteUShort(stream, value3);
					return;
				}
			}
			stream.WriteByte(9);
		}
		int num2 = value << 1;
		uint value4 = (uint)(num2 ^ value);
		WriteCompressedUInt32(stream, value4);
		return;
		IL_0229:
		streamBuffer.WriteByte(value2);
	}

	private void WriteCompressedInt64(StreamBuffer stream, long value, bool writeType)
	{
		//IL_014b: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I8
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_01da: Expected I4, but got I8
		//IL_01ac: Expected I4, but got I8
		//IL_00da: Expected Obj, but got I4
		//IL_0104: Expected I4, but got I8
		//IL_0115: Expected I4, but got I8
		byte value2;
		StreamBuffer streamBuffer;
		if (writeType)
		{
			if (value == 0)
			{
				value2 = 31;
				streamBuffer = stream;
				goto IL_021a;
			}
			if (value >= 1)
			{
				bool flag = value < 255;
				object obj = !flag;
				object obj2 = value - 255;
				bool flag2 = obj2 == null;
				object obj3 = ~obj;
				object obj4 = obj3 | flag2;
				if (obj4 != null)
				{
					stream.WriteByte(15);
					value2 = (byte)value;
					streamBuffer = stream;
					goto IL_021a;
				}
				long num = value >> 16;
				bool flag3 = num == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					stream.WriteByte(17);
					byte v = (byte)(value >> 8);
					stream.WriteBytes((byte)value, v);
					return;
				}
			}
			else
			{
				bool flag4 = value < -65535;
				object obj6 = !flag4;
				if (obj6 != null)
				{
					stream.WriteByte(18);
					ushort value3 = (ushort)(-value);
					((Protocol18)(object)stream).WriteUShort(stream, value3);
					return;
				}
			}
			stream.WriteByte(10);
		}
		long num2 = value << 1;
		ulong value4 = (ulong)(num2 ^ value);
		WriteCompressedUInt64(stream, value4);
		return;
		IL_021a:
		streamBuffer.WriteByte(value2);
	}

	private unsafe void WriteCompressedUInt32(StreamBuffer stream, uint value)
	{
		//IL_004f: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got Ref
		//IL_00f9: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got Ref
		//IL_0121: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(memCompressedUInt32, ref lockTaken);
		uint value2 = default;
		int count = ((Protocol18)(object)memCompressedUInt32).WriteCompressedUInt32(memCompressedUInt32, value2);
		bool flag = stream == null;
		byte[] array = memCompressedUInt32;
		object obj = 0;
		OutOfMemoryException ex = null;
		byte[] array2;
		if (!flag)
		{
			stream.Write(memCompressedUInt32, 0, count);
			array2 = memCompressedUInt32;
			obj = 0;
			ex = null;
			goto IL_0097;
		}
		goto IL_0155;
		IL_0155:
		NullReferenceException ex2 = new NullReferenceException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			array2 = array;
			obj = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			array2 = array;
			object obj2 = default;
			ex = (OutOfMemoryException)obj2;
		}
		goto IL_0097;
		IL_0097:
		object obj3 = (object)(&lockTaken);
		bool flag2 = obj3 == null;
		array = array2;
		if (!flag2)
		{
			object obj5 = default;
			object obj4 = (object)(&obj5);
			Monitor.Exit(obj4);
			array = null;
		}
		bool flag3 = ex == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			bool flag4 = obj == null;
			object obj7 = !flag4;
			OutOfMemoryException ex3 = ex;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0155;
	}

	private int WriteCompressedUInt32(byte[] buffer, uint value)
	{
		//IL_0194: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected I4, but got Unknown
		if (buffer != null)
		{
			if (buffer.Length != 0)
			{
				uint num2 = default;
				int num = (int)(num2 & 0x7F);
				bool flag = (int)num2 < 128;
				object obj = !flag;
				buffer[0] = (byte)num;
				object obj2 = ~obj;
				if (obj2 != null)
				{
					return 1;
				}
				object obj3 = 0;
				while (true)
				{
					bool flag2 = (nint)obj3 < buffer.Length;
					object obj4 = !flag2;
					if (obj4 != null)
					{
						break;
					}
					object obj5 = (object)buffer + obj3;
					obj3++;
					int num3 = num | 0x80;
					bool flag3 = (nint)obj3 < buffer.Length;
					object obj6 = !flag3;
					if (obj6 != null)
					{
						break;
					}
					int num4 = (int)num2 >> 7;
					num = num4 & 0x7F;
					int num5 = (int)num2 >> 14;
					num2 = (uint)((int)num2 >> 7);
					bool flag4 = num5 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						return obj3 + 1;
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
	}

	private unsafe void WriteCompressedUInt64(StreamBuffer stream, ulong value)
	{
		//IL_003b: Expected Obj, but got Ref
		//IL_0044: Expected Obj, but got I4
		//IL_0071: Expected I8, but got I4
		//IL_0093: Expected Obj, but got Ref
		//IL_009c: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_00f1: Expected I4, but got I8
		//IL_0116: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got Ref
		//IL_04c6: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_012d: Expected I8, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got Ref
		//IL_03ad: Expected Obj, but got Ref
		//IL_03b6: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_017b: Expected I8, but got I
		//IL_0306: Expected Obj, but got I8
		//IL_0352: Expected Obj, but got I4
		//IL_01bd: Expected I8, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected I8, but got Unknown
		//IL_01e6: Expected Obj, but got I4
		//IL_01f0: Expected I8, but got Obj
		//IL_0242: Expected Obj, but got I4
		//IL_0251: Expected I8, but got Obj
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected I4, but got Unknown
		bool lockTaken = default;
		Monitor.Enter(memCompressedUInt64, ref lockTaken);
		byte[] array = memCompressedUInt64;
		bool flag = memCompressedUInt64 == null;
		int num = 0;
		byte[] array2 = (byte[])(&lockTaken);
		object obj = 0;
		NullReferenceException ex = null;
		object obj2 = default;
		long num2 = (nint)(&obj2);
		ulong num3 = value;
		if (flag)
		{
			goto IL_03ce;
		}
		num2 = array.Length;
		bool flag2 = array.Length == 0;
		num = 0;
		array2 = (byte[])(&lockTaken);
		obj = 0;
		ex = null;
		num3 = value;
		if (flag2)
		{
			goto IL_03eb;
		}
		num2 = (long)(value & 0x7F);
		bool flag3 = (long)value < 128L;
		object obj3 = !flag3;
		array[0] = (byte)num2;
		int num4;
		if (obj3 == null)
		{
			num4 = 1;
		}
		else
		{
			object obj4 = 0;
			num3 = value;
			while (true)
			{
				byte[] array3 = memCompressedUInt64;
				if (memCompressedUInt64 != null)
				{
					long num5 = array3.Length;
					bool flag4 = (nint)obj4 < array3.Length;
					object obj5 = !flag4;
					if (obj5 != null)
					{
						goto IL_0393;
					}
					object obj6 = (object)memCompressedUInt64 + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X9_v16+20]");
					num5 = (nint)0 | (nint)0x80;
					byte[] array4 = memCompressedUInt64;
					bool flag5 = memCompressedUInt64 == null;
					array3 = memCompressedUInt64;
					if (!flag5)
					{
						num5 = array4.Length;
						long num6 = obj4 + 1;
						bool flag6 = num6 < array4.Length;
						object obj7 = !flag6;
						num2 = (long)memCompressedUInt64;
						if (obj7 == null)
						{
							num6 = (long)num3 >> 7;
							long num7 = (long)num3 >> 7;
							num5 = num7 & 0x7F;
							bool flag7 = (long)num3 < 16384L;
							object obj8 = !flag7;
							num2 = (long)((object)memCompressedUInt64 + obj4);
							obj4++;
							if (obj8 == null)
							{
								break;
							}
							continue;
						}
						goto IL_0385;
					}
				}
				else
				{
					NullReferenceException ex2 = new NullReferenceException();
				}
				NullReferenceException ex3 = new NullReferenceException();
				goto IL_0385;
				IL_0393:
				IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
				num = 0;
				array2 = (byte[])(&lockTaken);
				obj = 0;
				ex = null;
				goto IL_03c0;
				IL_0385:
				IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
				goto IL_0393;
			}
			num4 = obj4 + 1;
		}
		bool flag8 = stream == null;
		nint num8 = num4;
		num = 0;
		array2 = (byte[])(&lockTaken);
		obj = 0;
		ex = null;
		if (!flag8)
		{
			array2 = memCompressedUInt64;
			stream.Write(memCompressedUInt64, 0, num4);
			num8 = num4;
			num = 0;
			obj = 0;
			ex = null;
			goto IL_02cb;
		}
		goto IL_03f9;
		IL_02cb:
		object obj9 = (object)(&lockTaken);
		if (obj9 != null)
		{
			long num9 = (nint)(&obj2);
			Monitor.Exit(((long*)num9)->m_value);
			array2 = null;
		}
		bool flag9 = ex == null;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			goto IL_03c0;
		}
		bool flag10 = obj == null;
		object obj11 = !flag10;
		NullReferenceException ex6 = ex;
		if (obj11 == null)
		{
			return;
		}
		goto IL_03dc;
		IL_03eb:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_03f9;
		IL_03ce:
		ex6 = new NullReferenceException();
		goto IL_03dc;
		IL_03dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_03eb;
		IL_03f9:
		NullReferenceException ex8 = new NullReferenceException();
		if ((nint)array2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)array2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj12 = default;
			ex = (NullReferenceException)obj12;
		}
		goto IL_02cb;
		IL_03c0:
		OutOfMemoryException ex9 = new OutOfMemoryException();
		goto IL_03ce;
	}

	private uint EncodeZigZag32(int value)
	{
		int num = value << 1;
		return (uint)(num ^ value);
	}

	private ulong EncodeZigZag64(long value)
	{
		long num = value << 1;
		return (ulong)(num ^ value);
	}

	public Protocol18()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 1;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29E8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
				object obj4 = 0;
				_ = 8;
				object obj5 = this + 24;
				object obj6 = default;
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj7 = this + 32;
				object obj8 = default;
				obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj9 = this + 40;
				object obj10 = default;
				obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj11 = this + 48;
				object obj12 = default;
				obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj13 = this + 56;
				object obj14 = default;
				obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj15 = this + 64;
				object obj16 = default;
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj17 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v35+E4]");
				if ((object)((nint)0 != 0) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				base._002Ector();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static Protocol18()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516D98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = obj2;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+A0]");
		object obj6 = 0;
		object obj7 = default;
		obj6 = obj7;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
