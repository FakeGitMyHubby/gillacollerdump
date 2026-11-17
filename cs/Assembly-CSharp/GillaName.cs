using System;
using Cpp2ILInjected;

public static class GillaName
{
	public const int MaxLength = default(int);

	private static string meta;

	private static string disguise;

	private static Action m_Changed;

	public static string Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_0071: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0048: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v4+8]");
			if (string.IsNullOrEmpty((string)0))
			{
				return Real;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6+8]");
			return (string)0;
		}
	}

	public static string Real
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object value = 0;
			if (string.IsNullOrEmpty((string)value))
			{
				return Default;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+A0]");
			return (string)0;
		}
	}

	public static string Disguise
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_003a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4+8]");
			return (string)0;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e5: Expected Obj, but got I
			//IL_00fa: Expected Obj, but got I
			//IL_0118: Expected Obj, but got I4
			//IL_0033: Expected Obj, but got I
			//IL_005d: Expected Obj, but got I
			//IL_006d: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I
			//IL_00b2: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+8]");
			bool flag = value == (string)0;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6+A0]");
				object obj6 = (nint)0 + (nint)8;
				obj6 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+40]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+28]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+18]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X2_v2 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public static bool FromMeta
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0045: Expected Obj, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object value = 0;
			bool flag = string.IsNullOrEmpty((string)value);
			object obj3 = !flag;
			return (byte)(1 & obj3) != 0;
		}
	}

	public static string Default
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e0: Expected Obj, but got I4
			//IL_005a: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I
			//IL_0095: Expected Obj, but got I4
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected Obj, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string playerId = NetworkBootstrap.PlayerId;
			if (playerId != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F98]");
				object obj5 = 0;
				if (playerId._stringLength >= 1)
				{
					object obj6 = 0;
					int num = 0;
					do
					{
						char c = playerId.get_Chars(num);
						object obj7 = obj6 << 5;
						num++;
						object obj8 = obj7 - obj6;
						object obj9 = obj8 + c;
						obj6 = obj9 & 0x7FFFFFFF;
					}
					while (num < playerId._stringLength);
				}
				int num2 = default;
				string text = num2.ToString((string)obj4);
				return (string)obj5 + text;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public static event Action Changed
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static void SetMeta(string username)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		string text = default;
		if (text == null)
		{
		}
		string text2 = ((string)obj).Trim();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
		object obj2 = 0;
		bool flag = text2._stringLength < 21;
		string text3 = text2;
		if (!flag)
		{
			string text4 = text2.Substring(0, 20);
			text3 = text4;
		}
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v5+A0]");
		object obj4 = 0;
		bool flag2 = text3 == (string)obj4;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v8+A0]");
			object obj7 = 0;
			obj7 = text3;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v11+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+10]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v106 @ X8_v13+18] (should have been resolved before IL gen)");
			}
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4FB8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = (nint)0 + (nint)8;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+A0]");
		object obj5 = 0;
		obj5 = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
