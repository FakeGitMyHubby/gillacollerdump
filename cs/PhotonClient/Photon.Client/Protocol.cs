using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Cpp2ILInjected;

namespace Photon.Client;

public abstract class Protocol
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<IPAddress, string> _003C_003E9__61_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516938]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal string _003CGetIpAddresses_003Eb__61_0(IPAddress x)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_005e: Expected Obj, but got I
			if (x != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DBED8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516950]");
				object format = 0;
				AddressFamily addressFamily = x.AddressFamily;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				AddressFamily addressFamily2 = x.AddressFamily;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object arg = default;
				object arg2 = default;
				return string.Format((string)format, x, arg, arg2);
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public readonly ByteArraySlicePool ByteArraySlicePool;

	internal static readonly Dictionary<Type, CustomType> TypeDict;

	internal static readonly Dictionary<byte, CustomType> CodeDict;

	public abstract string ProtocolType { get; }

	public abstract byte[] VersionBytes { get; }

	public abstract void Serialize(StreamBuffer dout, object serObject, bool setType);

	public abstract void SerializeShort(StreamBuffer dout, short serObject, bool setType);

	public abstract void SerializeString(StreamBuffer dout, string serObject, bool setType);

	public abstract void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType);

	public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, ParameterDictionary parameters, bool setType);

	public abstract void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType);

	public abstract object Deserialize(StreamBuffer din, byte type, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags));

	public abstract short DeserializeShort(StreamBuffer din);

	public abstract byte DeserializeByte(StreamBuffer din);

	public abstract EventData DeserializeEventData(StreamBuffer din, EventData target = null, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags));

	public abstract OperationRequest DeserializeOperationRequest(StreamBuffer din, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags));

	public abstract OperationResponse DeserializeOperationResponse(StreamBuffer stream, Protocol16.DeserializationFlags flags = default(Protocol16.DeserializationFlags));

	public abstract DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream);

	public byte[] Serialize(object obj)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StreamBuffer streamBuffer = default;
		streamBuffer._002Ector(64);
		string text = ((Enum)this).ToString((string)(object)streamBuffer, (IFormatProvider)obj);
		if (streamBuffer != null)
		{
			return streamBuffer.ToArray();
		}
		return (byte[])(object)new NullReferenceException();
	}

	public object Deserialize(StreamBuffer stream)
	{
		//IL_002f: Expected I, but got Obj
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		if (stream != null)
		{
			byte b = stream.ReadByte();
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<Photon.Client.Protocol>)+1F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<Photon.Client.Protocol>)+200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v35 @ X5_v1 (should have been resolved before IL gen)");
		}
		return new NullReferenceException();
	}

	public object Deserialize(byte[] serializedData)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0027: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4AE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StreamBuffer streamBuffer = default;
		streamBuffer._002Ector(serializedData);
		if (streamBuffer != null)
		{
			byte b = streamBuffer.ReadByte();
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<Photon.Client.Protocol>)+1F8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<Photon.Client.Protocol>)+200]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X5_v1 (should have been resolved before IL gen)");
		}
		return new NullReferenceException();
	}

	public object DeserializeMessage(StreamBuffer stream)
	{
		//IL_002f: Expected I, but got Obj
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		if (stream != null)
		{
			byte b = stream.ReadByte();
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<Photon.Client.Protocol>)+1F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<Photon.Client.Protocol>)+200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v35 @ X5_v1 (should have been resolved before IL gen)");
		}
		return new NullReferenceException();
	}

	internal void SerializeMessage(StreamBuffer ms, object msg)
	{
		//IL_0005: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Photon.Client.Protocol>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Photon.Client.Protocol>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static bool TryRegisterType(Type type, byte typeCode, SerializeStreamMethod serializeFunction, DeserializeStreamMethod deserializeFunction)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I
		//IL_02fd: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+8]");
		if ((nint)0 == 0)
		{
			goto IL_02ef;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168D8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+8]");
		bool flag2 = ((Dictionary<byte, System.__Canon>)0).ContainsKey(typeCode);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		bool result;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v11+E8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = type == null;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v16+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v16+A0]");
				object obj13 = 0;
				if (obj13 == null)
				{
					goto IL_02ef;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168E0]");
				object obj14 = 0;
				if (!((Dictionary<System.__Canon, System.__Canon>)obj13).ContainsKey((System.__Canon)(object)type))
				{
					bool flag8 = serializeFunction == null;
					result = false;
					if (!flag8)
					{
						bool flag9 = deserializeFunction == null;
						result = false;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168C0]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							CustomType customType = default;
							customType._002Ector(type, typeCode, serializeFunction, deserializeFunction);
							object obj16 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v23+E4]");
							bool flag10 = (nint)0 == 0;
							object obj17 = !flag10;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj16 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v23+A0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v20+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v20+8]");
								((Dictionary<byte, System.__Canon>)0).Add(typeCode, (System.__Canon)(object)customType);
								object obj19 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v23+A0]");
								object obj20 = 0;
								if (obj20 != null)
								{
									((Dictionary<System.__Canon, System.__Canon>)obj20).Add((System.__Canon)(object)type, (System.__Canon)(object)customType);
									result = true;
									goto IL_0362;
								}
							}
							goto IL_02ef;
						}
					}
					goto IL_0362;
				}
			}
		}
		result = false;
		goto IL_0362;
		IL_02ef:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0362:
		return result;
	}

	protected Protocol()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516960]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ByteArraySlicePool byteArraySlicePool = default;
		byteArraySlicePool._002Ector();
		object obj2 = this + 16;
		obj2 = byteArraySlicePool;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static Protocol()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516968]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516978]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = dictionary;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<byte, System.__Canon> dictionary2 = default;
		dictionary2._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
