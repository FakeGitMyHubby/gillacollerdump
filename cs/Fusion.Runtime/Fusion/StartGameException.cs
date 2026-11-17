using System;
using Cpp2ILInjected;

namespace Fusion;

internal class StartGameException : Exception
{
	private ShutdownReason ShutdownReason__BackingField;

	public ShutdownReason ShutdownReason
	{
		get
		{
			return ShutdownReason__BackingField;
		}
		internal set
		{
			ShutdownReason__BackingField = value;
		}
	}

	internal unsafe StartGameException(ShutdownReason shutdownReason = default(ShutdownReason), string customMsg = null)
	{
		//IL_005c: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5388]");
		object obj = 0;
		bool flag = customMsg == null;
		object obj2 = !flag;
		ShutdownReason shutdownReason2 = shutdownReason;
		string message = customMsg;
		if (obj2 == null)
		{
			object obj3 = default;
			string text = ((Enum)(&obj3)).ToString();
			shutdownReason2 = (ShutdownReason)0;
			message = text;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector(message);
		ShutdownReason__BackingField = shutdownReason;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I4
		//IL_0053: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I8
		//IL_0116: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got Ref
		//IL_025d: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_01fa: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I8
		//IL_02fd: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_039a: Expected I, but got Obj
		//IL_03aa: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_03d9: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DD8]");
			object obj2 = 0;
			bool flag = obj2 == null;
			object obj3 = 5;
			IndexOutOfRangeException ex = default;
			object obj4;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				if (flag2)
				{
					goto IL_04e0;
				}
			}
			if (array.Length != 0)
			{
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DC8]");
				object obj5 = 0;
				object obj6 = array + 32;
				obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj5 != null)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag3 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					if (flag3)
					{
						goto IL_04e0;
					}
				}
				object obj7 = array.Length & 0xFFFFFFFEL;
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
					object obj8 = 0;
					object obj9 = array + 40;
					obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj10 = default;
					bool flag4 = obj10 == null;
					object obj11 = default;
					obj3 = (object)(&obj11);
					if (!flag4)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						if (flag5)
						{
							goto IL_04e0;
						}
					}
					bool flag6 = array.Length < 2;
					object obj12 = !flag6;
					object obj13 = array.Length - 2;
					bool flag7 = obj13 == null;
					object obj14 = ~obj12;
					object obj15 = obj14 | flag7;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DD0]");
						object obj16 = 0;
						object obj17 = array + 48;
						obj17 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag8 = obj16 == null;
						obj3 = obj10;
						if (!flag8)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag9 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							if (flag9)
							{
								goto IL_04e0;
							}
						}
						object obj18 = array.Length & 0xFFFFFFFCL;
						if (obj18 != null)
						{
							object obj19 = array + 56;
							obj19 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							nint num5 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v15 (Il2CppClass<Fusion.StartGameException>)+190]");
							obj3 = 0;
							int hashCode = ((Enum)(object)this).GetHashCode();
							if (hashCode != 0)
							{
								nint num6 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag10 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								if (flag10)
								{
									goto IL_04e0;
								}
							}
							bool flag11 = array.Length < 4;
							object obj20 = !flag11;
							object obj21 = array.Length - 4;
							bool flag12 = obj21 == null;
							object obj22 = ~obj20;
							object obj23 = obj22 | flag12;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DE0]");
								object format = 0;
								object obj24 = array + 64;
								obj24 = hashCode;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return string.Format((string)format, array);
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			obj4 = obj3;
			goto IL_04e0;
		}
		goto IL_04f8;
		IL_04f8:
		return (string)(object)new NullReferenceException();
		IL_04e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_04f8;
	}
}
