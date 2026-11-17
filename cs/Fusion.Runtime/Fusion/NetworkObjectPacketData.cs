using System;
using System.Text;
using Cpp2ILInjected;

namespace Fusion;

internal record struct NetworkObjectPacketData : _0021_00210
{
	public NetworkId Id;

	public Tick ResetTick;

	public NetworkObjectPacketFlags Flags;

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_009b: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		if (stringBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86F8]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8700]");
			object value2 = 0;
			StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
			StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
			bool flag = PrintMembers(stringBuilder);
			StringBuilder stringBuilder4 = stringBuilder.Append(' ');
			StringBuilder stringBuilder5 = stringBuilder.Append('}');
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5 (Il2CppClass<System.Text.StringBuilder>)+168]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5 (Il2CppClass<System.Text.StringBuilder>)+170]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v68 @ X2_v5 (should have been resolved before IL gen)");
		}
		return (string)(object)new NullReferenceException();
	}

	private unsafe bool PrintMembers(StringBuilder builder)
	{
		//IL_0142: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got Ref
		if (builder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8718]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8710]");
			object value2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8720]");
			object value3 = 0;
			StringBuilder stringBuilder = builder.Append((string)value);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkId networkId = default;
			string value4 = networkId.ToString();
			StringBuilder stringBuilder2 = builder.Append(value4);
			StringBuilder stringBuilder3 = builder.Append((string)value2);
			Tick tick = default;
			string value5 = tick.ToString();
			StringBuilder stringBuilder4 = builder.Append(value5);
			StringBuilder stringBuilder5 = builder.Append((string)value3);
			object obj4 = default;
			string value6 = ((Enum)(&obj4)).ToString();
			StringBuilder stringBuilder6 = builder.Append(value6);
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I
		//IL_010a: Expected I4, but got Obj
		//IL_002d: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f7: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8728]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AE18");
		object obj2 = default;
		if (obj2 != null)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8738]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ X8_v4+1C8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AEE4");
			object obj5 = default;
			if (obj5 != null)
			{
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8730]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ X8_v6+1C8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AFB0");
				object obj8 = default;
				if (obj8 != null)
				{
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ X8_v8+1C8] (should have been resolved before IL gen)");
					object obj11 = default;
					object obj10 = obj11 * 2773833001L;
					object obj13 = default;
					object obj12 = obj13 + obj10;
					object obj14 = obj12 * 2773833001L;
					object obj15 = default;
					return (int)(obj15 + obj14);
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public bool Equals(NetworkObjectPacketData other)
	{
		//IL_0010: Expected Obj, but got I
		//IL_016d: Expected I4, but got Obj
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8728]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AE18");
		object obj2 = default;
		if (obj2 != null)
		{
			object obj3 = obj2;
			object obj4 = other & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ X8_v4+1B8] (should have been resolved before IL gen)");
			object obj6 = default;
			object obj5 = obj6 & 1;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8738]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AEE4");
				object obj8 = default;
				if (obj8 == null)
				{
					goto IL_015f;
				}
				object obj9 = obj8;
				object obj10 = other >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ X8_v8+1B8] (should have been resolved before IL gen)");
				object obj12 = default;
				object obj11 = obj12 & 1;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8730]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AFB0");
					object obj14 = default;
					if (obj14 == null)
					{
						goto IL_015f;
					}
					object obj15 = obj14;
					NetworkObjectPacketFlags flags = Flags;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v11+1B8]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v11+1C0]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v102 @ X4_v1 (should have been resolved before IL gen)");
				}
			}
			return false;
		}
		goto IL_015f;
		IL_015f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
