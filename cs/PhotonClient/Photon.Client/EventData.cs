using System;
using Cpp2ILInjected;

namespace Photon.Client;

public class EventData
{
	public byte Code;

	public readonly ParameterDictionary Parameters;

	public byte SenderKey;

	private int sender;

	public byte CustomDataKey;

	private object customData;

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(byte key)
	{
		if (Parameters != null)
		{
			bool flag = Parameters.TryGetValue(key, out var value);
			return value;
		}
		return new NullReferenceException();
	}

	internal void set_Item(byte key, object value)
	{
		Parameters.Add(key, value);
	}

	public int Sender
	{
		get
		{
			//IL_00c0: Expected Obj, but got I4
			//IL_00da: Expected Obj, but got I4
			//IL_00a6: Expected I4, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			//IL_0066: Expected Obj, but got I4
			int result = sender;
			object obj = sender + 1;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				if (Parameters == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (int)ex;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E00]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36E10F8");
				object obj5 = default;
				object obj4 = obj5 & 1;
				bool flag2 = obj4 == null;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				int num = default;
				result = (sender = ((obj7 != null) ? (-1) : num));
			}
			return result;
		}
		internal set
		{
			sender = value;
		}
	}

	public unsafe object CustomData
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Ref, but got Unknown
			//IL_002f: Expected Obj, but got I4
			ref object reference = ref *(object*)(this + 48);
			object result = reference;
			bool flag = reference == null;
			object obj = !flag;
			if (obj == null)
			{
				if (Parameters == null)
				{
					return new NullReferenceException();
				}
				bool flag2 = Parameters.TryGetValue(CustomDataKey, out reference);
				result = customData;
			}
			return result;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public EventData()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004d: Expected I4, but got I8
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3058]");
		object obj = 0;
		SenderKey = 254;
		sender = -1;
		CustomDataKey = 245;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ParameterDictionary parameterDictionary = default;
		parameterDictionary._002Ector();
		object obj2 = this + 24;
		obj2 = parameterDictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal void Reset()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		Code = 0;
		Parameters.Clear();
		object obj = this + 48;
		obj = 0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E08]");
		object format = 0;
		byte b = (byte)(this + 16);
		string arg = ((byte*)b)->ToString();
		return string.Format((string)format, arg);
	}

	public string ToStringFull()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516E10]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		NonAllocDictionary<byte, object> dictionary = Parameters;
		string arg = SupportClass.DictionaryToString(dictionary, includeTypes: true);
		object arg2 = default;
		return string.Format((string)format, arg2, arg);
	}
}
