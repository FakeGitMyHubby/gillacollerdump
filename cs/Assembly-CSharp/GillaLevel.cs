using System;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaLevel
{
	private const string SaveKey = null;

	private static bool loaded;

	private static int xp;

	private static Action m_Changed;

	private static Action<int, int> m_Gained;

	public static int Xp
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0032: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
			object obj = 0;
			Load();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4+4]");
			return 0;
		}
	}

	public static int Level
	{
		get
		{
			//IL_0012: Expected Obj, but got I4
			//IL_0017: Expected I, but got Obj
			//IL_003f: Expected Obj, but got I
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected Obj, but got Unknown
			int num = Xp;
			object obj = 50;
			nint num2 = unchecked((nint)null);
			object obj2 = default;
			obj = obj2;
			IntPtr intPtr = default;
			num2 = intPtr;
			int result;
			object obj4;
			do
			{
				object obj3 = num2 + 2;
				result = (int)(num2 + 1);
				obj4 = obj * obj3;
				obj += 50;
			}
			while ((nint)obj4 <= num);
			return result;
		}
	}

	public static int IntoLevel
	{
		get
		{
			//IL_0024: Expected Obj, but got I8
			//IL_002d: Expected Obj, but got I4
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected Obj, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			int num = Xp;
			int num2 = Xp;
			object obj = 4294967295L;
			object obj2 = 0;
			object obj3 = default;
			obj = obj3;
			object obj4 = default;
			obj2 = obj4;
			object obj6;
			do
			{
				object obj5 = obj + 3;
				obj2 += 50;
				obj++;
				obj6 = obj2 * obj5;
			}
			while ((nint)obj6 <= num2);
			object obj7 = obj2 * obj;
			return num - obj7;
		}
	}

	public static int ForNext
	{
		get
		{
			//IL_0012: Expected Obj, but got I4
			//IL_001b: Expected Obj, but got I4
			//IL_0020: Expected I, but got Obj
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected Obj, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got Unknown
			int num = Xp;
			object obj = 2;
			object obj2 = 50;
			nint num2 = unchecked((nint)null);
			object obj3 = default;
			obj = obj3;
			object obj4 = default;
			obj2 = obj4;
			IntPtr intPtr = default;
			num2 = intPtr;
			object obj5;
			int result;
			do
			{
				obj5 = obj2 * obj;
				result = (int)(num2 + 100);
				obj2 += 50;
				obj++;
			}
			while ((nint)obj5 <= num);
			return result;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+8]");
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
				object obj8 = (nint)0 + (nint)8;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+8]");
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
				object obj8 = (nint)0 + (nint)8;
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

	public static event Action<int, int> Gained
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_0082: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I
			//IL_005d: Expected Obj, but got I4
			//IL_00c5: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj7 = default;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag = obj7 == null;
					object obj8 = !flag;
					object obj9 = obj7;
					if (obj8 == null)
					{
						break;
					}
				}
				else
				{
					object obj9 = 0;
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag2 = (object)obj12 != obj5;
				obj5 = obj12;
				if (!flag2)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_0082: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I
			//IL_005d: Expected Obj, but got I4
			//IL_00c5: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj7 = default;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag = obj7 == null;
					object obj8 = !flag;
					object obj9 = obj7;
					if (obj8 == null)
					{
						break;
					}
				}
				else
				{
					object obj9 = 0;
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag2 = (object)obj12 != obj5;
				obj5 = obj12;
				if (!flag2)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static int Need(int level)
	{
		return level * 100;
	}

	public static int TotalFor(int level)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got Unknown
		object obj = level - 1;
		object obj2 = level * obj;
		return obj2 * 50;
	}

	private static int LevelAt(int total)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		object obj = 50;
		int num = 0;
		object obj2 = default;
		obj = obj2;
		num = total;
		object obj4;
		do
		{
			object obj3 = num + 2;
			num++;
			obj4 = obj * obj3;
			obj += 50;
		}
		while ((nint)obj4 <= total);
		return num;
	}

	public static int ForYou(int xp)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0173: Expected I4, but got Obj
		bool flag = xp < 1;
		int result = xp;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool xpBoost = GillaPurchases.XpBoost;
			bool flag3 = !xpBoost;
			result = xp;
			if (!flag3)
			{
				object obj4 = xp + xp;
				object obj5 = obj4 + 1;
				object obj6 = obj4 + 2;
				bool flag4 = (nint)obj5 < 0;
				object obj7 = obj5 ^ obj5;
				object obj8 = obj5 & obj7;
				bool flag5 = (nint)obj8 < 0;
				bool flag6 = flag4 == flag5;
				object obj9 = !flag6;
				object obj10 = ~obj9;
				object obj11 = ((obj10 != null) ? ((object)(obj4 + 1)) : obj6);
				result = obj11 >> 1;
			}
		}
		return result;
	}

	public static int Add(int amount, bool quiet = default(bool), bool boost = default(bool))
	{
		//IL_01c4: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		Load();
		int num = default;
		int num7;
		if (num >= 1)
		{
			bool flag = !boost;
			int num2 = num;
			int num3 = num;
			if (!flag)
			{
				num2 = ForYou(num);
				num3 = num2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD0]");
			object key = 0;
			int num4 = Xp;
			object obj2 = 50;
			int num5 = 0;
			object obj3 = default;
			obj2 = obj3;
			int num6 = default;
			num5 = num6;
			object obj5;
			do
			{
				object obj4 = num5 + 2;
				num5++;
				obj5 = obj2 * obj4;
				obj2 += 50;
			}
			while ((nint)obj5 <= num4);
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v7+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v8+4]");
			int value = (int)((nint)0 + (nint)num3);
			PlayerPrefs.SetInt((string)key, value);
			PlayerPrefs.Save();
			object obj8 = obj;
			num7 = -num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v9+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v10+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v10+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X8_v11+18] (should have been resolved before IL gen)");
			}
			int num8 = Xp;
			object obj11 = 2;
			object obj12 = 50;
			object obj13 = default;
			obj11 = obj13;
			obj12 = obj3;
			num7 = num6;
			object obj14;
			do
			{
				obj14 = obj12 * obj11;
				num7++;
				obj12 += 50;
				obj11++;
			}
			while ((nint)obj14 <= num8);
			bool flag2 = !quiet;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v15+A0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v16+10]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v16+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X8_v17+18] (should have been resolved before IL gen)");
				}
			}
		}
		else
		{
			num7 = 0;
		}
		return num7;
	}

	public static void Adopt(int total)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
		object obj = 0;
		Load();
		object obj2 = obj;
		int num2 = default;
		int num = ~num2;
		int num3 = num2 & num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+4]");
		if ((nint)num3 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD0]");
			object key = 0;
			PlayerPrefs.SetInt((string)key, num3);
			PlayerPrefs.Save();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+40]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v74 @ X2_v3 (should have been resolved before IL gen)");
			}
		}
	}

	private static void Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_002e: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3+A0]");
		object obj3 = 0;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD0]");
			object key = 0;
			obj3 = 1;
			int num = PlayerPrefs.GetInt((string)key, 0);
			object obj5 = obj;
			int num2 = ~num;
			int num3 = num & num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+A0]");
			object obj6 = 0;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
	}
}
