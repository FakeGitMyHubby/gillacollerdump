using System;
using Cpp2ILInjected;

namespace Photon.Client;

public class OperationResponse
{
	public byte OperationCode;

	public short ReturnCode;

	public string DebugMessage;

	public ParameterDictionary Parameters;

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(byte parameterCode)
	{
		if (Parameters != null)
		{
			bool flag = Parameters.TryGetValue(parameterCode, out var value);
			return value;
		}
		return new NullReferenceException();
	}

	public void set_Item(byte parameterCode, object value)
	{
		Parameters.Add(parameterCode, value);
	}

	public override string ToString()
	{
		//IL_00b5: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(DebugMessage);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DA0]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			object arg2 = default;
			return string.Format((string)format, arg, arg2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DA8]");
		object format2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg3 = default;
		object arg4 = default;
		return string.Format((string)format2, arg3, arg4, DebugMessage);
	}

	public unsafe string ToStringFull()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0042: Expected I, but got Obj
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I8
		//IL_0104: Expected I, but got Obj
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_01f0: Expected I, but got Obj
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_0340: Expected Obj, but got I8
		//IL_0357: Expected I4, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
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
			object obj4 = default;
			bool flag2 = (byte)(&obj4) != 0;
			IndexOutOfRangeException ex = default;
			bool flag4;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				flag2 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				flag4 = false;
				if (flag3)
				{
					goto IL_03c8;
				}
			}
			if (array.Length != 0)
			{
				object obj5 = array + 32;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj6 = default;
				bool flag5 = obj6 == null;
				object obj7 = default;
				flag2 = (byte)(&obj7) != 0;
				if (!flag5)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
					flag4 = false;
					if (flag6)
					{
						goto IL_03c8;
					}
				}
				object obj8 = array.Length & 0xFFFFFFFEL;
				if (obj8 != null)
				{
					object obj9 = array + 40;
					obj9 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					NonAllocDictionary<byte, object> dictionary = Parameters;
					string text = SupportClass.DictionaryToString(dictionary, includeTypes: true);
					bool flag7 = text == null;
					flag2 = true;
					if (!flag7)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						flag2 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag8 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						flag4 = false;
						if (flag8)
						{
							goto IL_03c8;
						}
					}
					bool flag9 = array.Length < 2;
					object obj10 = !flag9;
					object obj11 = array.Length - 2;
					bool flag10 = obj11 == null;
					object obj12 = ~obj10;
					object obj13 = obj12 | flag10;
					if (obj13 == null)
					{
						object obj14 = array + 48;
						obj14 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag11 = DebugMessage == null;
						string text2 = text;
						if (!flag11)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
							text2 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag12 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
							flag4 = false;
							if (flag12)
							{
								goto IL_03c8;
							}
						}
						object obj15 = array.Length & 0xFFFFFFFCL;
						bool flag13 = obj15 == null;
						flag2 = (byte)(int)text2 != 0;
						if (!flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516DB0]");
							object format = 0;
							object obj16 = array + 56;
							obj16 = DebugMessage;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							return string.Format((string)format, array);
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			flag4 = flag2;
			goto IL_03c8;
		}
		goto IL_03e0;
		IL_03c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_03e0;
		IL_03e0:
		return (string)(object)new NullReferenceException();
	}
}
