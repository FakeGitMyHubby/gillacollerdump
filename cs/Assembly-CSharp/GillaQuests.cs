using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaQuests
{
	private class Pull
	{
		public NetworkApe by;

		public bool right;

		public NetworkApe who;

		public GillaDummy dummy;

		public GillaCorpse body;

		public Dismemberment ape;

		public bool yours;

		public ApePart part;

		public bool middle;

		public Transform grip;

		public Transform pulling;

		public Transform holding;

		public float start;

		public float tears;

		public Vector3 from;

		public Vector3 way;

		public float strain;

		public float blend;

		public float x;

		public float v;

		public bool live;

		public bool snapped;

		public int said;

		public readonly List<GillaPull.Limb> limbs;

		public Pull()
		{
			//IL_001c: Expected Obj, but got I
			//IL_0032: Expected Obj, but got I
			//IL_004a: Expected Obj, but got I
			//IL_0067: Expected VT, but got I
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6008]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+A0]");
			object obj3 = 0;
			live = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8+18]");
			way = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list = default;
			list._002Ector();
			object obj4 = this + 160;
			obj4 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	public enum Stat
	{
		// error: enumerator has no value
		Recycle,
		// error: enumerator has no value
		RecycleGold,
		// error: enumerator has no value
		RecycleDiamond,
		// error: enumerator has no value
		RecycleBolts,
		// error: enumerator has no value
		Doors,
		// error: enumerator has no value
		Glass,
		// error: enumerator has no value
		FlashlightSeconds,
		// error: enumerator has no value
		Stow,
		// error: enumerator has no value
		Metres,
		// error: enumerator has no value
		MonsterRound,
		// error: enumerator has no value
		Caught,
		// error: enumerator has no value
		TryOn,
		// error: enumerator has no value
		SplashRace
	}

	public static readonly GillaRecycler.Quest[] Pool;

	private static readonly int[] Repurposed;

	public const int Count = default(int);

	public const int CoinsEach = default(int);

	private const string SaveKey = null;

	private static Action m_Changed;

	private static Action<int, int, int> m_Claimed;

	private static int day;

	private static readonly GillaRecycler.Quest[] today;

	private static readonly int[] progress;

	private static readonly bool[] claimed;

	private static float lastSave;

	private static bool unsaved;

	public static int Day
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e1: Expected Obj, but got I
			//IL_0103: Expected Obj, but got I4
			//IL_006c: Expected VT, but got I4
			//IL_009a: Expected Obj, but got I4
			//IL_00c9: Expected I4, but got F8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = new DateTime(2026, 1, 1, 0, 0, 0, (DateTimeKind)1);
			TimeSpan timeSpan = utcNow - (DateTime)0;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default;
			double totalDays = timeSpan2.TotalDays;
			return (int)totalDays;
		}
	}

	public static TimeSpan UntilNew
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default;
			DateTime date = dateTime.Date;
			DateTime dateTime2 = dateTime.AddDays(1.0);
			DateTime utcNow2 = DateTime.UtcNow;
			return dateTime2 - utcNow2;
		}
	}

	public static event Action Changed
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static event Action<int, int, int> Claimed
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			//IL_0176: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61D0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			object obj8 = default;
			Delegate obj15 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				if ((object)obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = obj8 == null;
					object obj9 = !flag2;
					object obj10 = obj8;
					Delegate obj11 = (Delegate)obj5;
					if (obj9 == null)
					{
						break;
					}
				}
				else
				{
					object obj10 = 0;
					Delegate obj11 = value;
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+A0]");
				object obj14 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj15 != obj6;
				obj6 = obj15;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			//IL_0176: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61D0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			object obj8 = default;
			Delegate obj15 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				if ((object)obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = obj8 == null;
					object obj9 = !flag2;
					object obj10 = obj8;
					Delegate obj11 = (Delegate)obj5;
					if (obj9 == null)
					{
						break;
					}
				}
				else
				{
					object obj10 = 0;
					Delegate obj11 = value;
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+A0]");
				object obj14 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj15 != obj6;
				obj6 = obj15;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static GillaRecycler.Quest QuestAt(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+28]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+18]");
			bool flag2 = (nint)0 < (nint)i;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+18]");
			object obj8 = -i;
			bool flag3 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+28]");
				object obj11 = (nint)0 + (nint)i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+20]");
				return (GillaRecycler.Quest)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (GillaRecycler.Quest)(object)new IndexOutOfRangeException();
	}

	public static int ProgressAt(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_02cc: Expected I4, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected I4, but got Unknown
		//IL_026f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+30]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)i;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj8 = -i;
			bool flag3 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag3;
			if (obj10 != null)
			{
				goto IL_02be;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4+18]");
				bool flag4 = (nint)0 < (nint)i;
				object obj12 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4+18]");
				object obj13 = -i;
				bool flag5 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag5;
				if (obj15 != null)
				{
					goto IL_02be;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+28]");
				object obj16 = (nint)0 + (nint)i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v5+20]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v5+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+30]");
					object obj18 = (nint)0 + (nint)i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+20]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v6+14]");
					object obj19 = num - 0;
					bool flag6 = (nint)obj19 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+20]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v6+14]");
					int num3 = (int)(num2 ^ 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+20]");
					int num4 = 0 ^ obj19;
					int num5 = num3 & num4;
					bool flag7 = num5 < 0;
					bool flag8 = flag6 == flag7;
					object obj20 = !flag8;
					object obj21 = ~obj20;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+20]");
						return 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v6+14]");
					return 0;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02be;
		IL_02be:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	public static bool DoneAt(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0285: Expected I4, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+30]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)i;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj8 = -i;
			bool flag3 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag3;
			if (obj10 != null)
			{
				goto IL_0277;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4+18]");
				bool flag4 = (nint)0 < (nint)i;
				object obj12 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4+18]");
				object obj13 = -i;
				bool flag5 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag5;
				if (obj15 != null)
				{
					goto IL_0277;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+28]");
				object obj16 = (nint)0 + (nint)i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v5+20]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v5+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+30]");
					object obj18 = (nint)0 + (nint)i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+20]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v6+14]");
					object obj19 = num - 0;
					bool flag6 = (nint)obj19 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+20]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v6+14]");
					object obj20 = num2 ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+20]");
					object obj21 = 0 ^ obj19;
					object obj22 = obj20 & obj21;
					bool flag7 = (nint)obj22 < 0;
					return flag6 == flag7;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0277;
		IL_0277:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public static bool ClaimedAt(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_011d: Expected I4, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+38]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+18]");
			bool flag2 = (nint)0 < (nint)i;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+18]");
			object obj8 = -i;
			bool flag3 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+38]");
				object obj11 = (nint)0 + (nint)i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+20]");
				return false;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public static void Report(Stat stat, int amount = default(int))
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected Obj, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected Obj, but got Unknown
		//IL_0a79: Expected Obj, but got I4
		//IL_08d7: Expected Obj, but got I4
		//IL_07f6: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I
		//IL_084b: Expected Obj, but got I
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_065f: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_06d7: Expected Obj, but got I4
		//IL_099b: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_0aa0: Expected Obj, but got I4
		//IL_071e: Expected Obj, but got I4
		//IL_0880: Expected Obj, but got I
		//IL_0890: Expected Obj, but got I
		//IL_0a03: Expected Obj, but got I
		//IL_0a13: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_0789: Expected Obj, but got I
		//IL_0799: Expected Obj, but got I
		//IL_07a9: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_03e3: Expected Obj, but got I4
		//IL_08f5: Expected Obj, but got I
		//IL_0905: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I4
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0476: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I
		//IL_04f1: Expected Obj, but got I4
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got I
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got I
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05e4: Expected Obj, but got I4
		//IL_094a: Expected Obj, but got I4
		if (amount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		object obj5 = 0;
		object obj6 = 0;
		float num3 = default;
		while (true)
		{
			object obj7 = obj5 << 3;
			object obj8 = obj5 << 2;
			object obj9 = obj7 + 32;
			object obj10 = obj8 + 32;
			object obj11 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v9+28]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v9+28]");
				if ((nint)0 != 0)
				{
					object obj15 = obj5 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v10+18]");
					bool flag3 = (nint)obj15 < 0;
					object obj16 = !flag3;
					if (obj16 != null)
					{
						goto IL_07c2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v9+28]");
					object obj17 = 0 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v13+v174 @ X23_v5*8]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v13+v174 @ X23_v5*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v14+10]");
						if ((nint)0 != (nint)stat)
						{
							goto IL_0381;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+E4]");
						bool flag4 = (nint)0 == 0;
						object obj19 = !flag4;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj4 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+A0]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v30+38]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v30+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v31+18]");
							bool flag5 = (nint)obj15 < 0;
							object obj22 = !flag5;
							if (obj22 != null)
							{
								goto IL_07c2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v30+38]");
							object obj23 = 0 + obj5;
							object obj24 = obj23 + obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v33+20]");
							bool flag6 = (nint)0 == 0;
							object obj25 = !flag6;
							if (obj25 != null)
							{
								goto IL_0381;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+E4]");
							bool flag7 = (nint)0 == 0;
							object obj26 = !flag7;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj4 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+A0]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v12+30]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v12+30]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v36+18]");
								bool flag8 = (nint)obj15 < 0;
								object obj29 = !flag8;
								if (obj29 != null)
								{
									goto IL_07c2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v12+28]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v12+28]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v13+18]");
									object obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v13+18]");
									bool flag9 = (nint)obj15 < 0;
									object obj32 = !flag9;
									if (obj32 != null)
									{
										goto IL_07c2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v12+28]");
									object obj33 = 0 + obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X9_v14+v174 @ X23_v5*8]");
									object obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X9_v14+v174 @ X23_v5*8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v12+30]");
										object obj35 = 0 + obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v37+v174 @ X23_v5*4]");
										nint num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X9_v15+14]");
										if (num >= 0)
										{
											goto IL_0381;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+E4]");
										bool flag10 = (nint)0 == 0;
										object obj36 = !flag10;
										if (obj36 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj4 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+A0]");
										object obj37 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v40+28]");
										object obj38 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v40+28]");
										if ((nint)0 != 0)
										{
											object obj39 = obj5 + obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v17+18]");
											bool flag11 = (nint)obj39 < 0;
											object obj40 = !flag11;
											if (obj40 != null)
											{
												goto IL_07c2;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v40+28]");
											object obj41 = 0 + obj5;
											object obj42 = obj41 + obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X9_v19+20]");
											object obj43 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X9_v19+20]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v40+30]");
												object obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v40+30]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v41+18]");
													bool flag12 = (nint)obj39 < 0;
													object obj45 = !flag12;
													if (obj45 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v40+30]");
														object obj46 = 0 + obj5;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v20+14]");
														object obj47 = 0;
														object obj48 = obj5 + obj11;
														obj5 = obj48 + 1;
														object obj49 = obj46 + obj11;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v43+20]");
														obj31 = (nint)0 + (nint)amount;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v20+14]");
														object obj50 = 0 - obj31;
														bool flag13 = (nint)obj50 < 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v20+14]");
														object obj51 = 0 ^ obj31;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v20+14]");
														object obj52 = 0 ^ obj50;
														object obj53 = obj51 & obj52;
														bool flag14 = (nint)obj53 < 0;
														bool flag15 = flag13 == flag14;
														object obj54 = !flag15;
														object obj55 = ~obj54;
														if (obj55 != null)
														{
															obj47 = obj31;
														}
														bool flag16 = (nint)obj48 != 2;
														obj6 = 1;
														if (flag16)
														{
															break;
														}
														goto IL_063d;
													}
													goto IL_07c2;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_07c2;
				IL_07c2:
				throw new IndexOutOfRangeException();
				IL_063d:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+E4]");
				bool flag17 = (nint)0 == 0;
				object obj56 = !flag17;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+A0]");
				object obj57 = 0;
				bool flag18 = stat == (Stat)8;
				_ = 1;
				double num4;
				float num5;
				object obj60;
				if (flag18 || stat == (Stat)6)
				{
					float unscaledTime = Time.unscaledTime;
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+E4]");
					bool flag19 = (nint)0 == 0;
					object obj58 = !flag19;
					if (obj58 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+A0]");
					object obj59 = 0;
					float num2 = unscaledTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v26+40]");
					num3 = num2 - 0f;
					bool flag20 = !((double)num3 > 10.0);
					num4 = 10.0;
					num5 = num3;
					obj60 = obj4;
					if (flag20)
					{
						goto IL_0a7e;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v34+E4]");
				bool flag21 = (nint)0 == 0;
				object obj61 = !flag21;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Save();
				obj60 = obj;
				num4 = 10.0;
				num5 = num3;
				goto IL_0a7e;
				IL_0a7e:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v16+E4]");
				bool flag22 = (nint)0 == 0;
				object obj62 = !flag22;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj60 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v16+A0]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v21+10]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v21+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v22+40]");
					object obj65 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v22+28]");
					object obj66 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v22+18]");
					object obj67 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v163 @ X2_v1 (should have been resolved before IL gen)");
				}
				return;
				IL_0381:
				obj11++;
				object obj68 = obj5 + obj11;
				if ((nint)obj68 != 3)
				{
					continue;
				}
				object obj69 = obj6 & 1;
				if (obj69 != null)
				{
					goto IL_063d;
				}
				return;
			}
		}
	}

	public static int Claim(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0950: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_037c: Expected I4, but got I8
		//IL_00b0: Expected Obj, but got I4
		//IL_096e: Expected Obj, but got I
		//IL_097e: Expected Obj, but got I
		//IL_0926: Expected I4, but got Obj
		//IL_00f6: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_09b3: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I4
		//IL_09e8: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_03f9: Expected Obj, but got I4
		//IL_040e: Expected Obj, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_0456: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_052c: Expected Obj, but got I
		//IL_053c: Expected Obj, but got I
		//IL_0590: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I4
		//IL_05f9: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I
		//IL_064f: Expected Obj, but got I4
		//IL_0664: Expected Obj, but got I
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_06ac: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got I
		//IL_06d1: Expected Obj, but got I
		//IL_06e5: Expected Obj, but got I
		//IL_070f: Expected Obj, but got I4
		//IL_0759: Expected Obj, but got I
		//IL_0769: Expected Obj, but got I
		//IL_0a2f: Expected Obj, but got I4
		//IL_0a87: Expected Obj, but got I
		//IL_0a97: Expected Obj, but got I
		//IL_07f6: Expected Obj, but got I4
		//IL_0a52: Expected Obj, but got I
		//IL_0826: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_08a9: Expected Obj, but got I
		//IL_08b9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		bool flag2 = i < 2;
		object obj4 = !flag2;
		object obj5 = i - 2;
		bool flag3 = obj5 == null;
		object obj6 = !flag3;
		object obj7 = obj4 & obj6;
		if (obj7 != null)
		{
			goto IL_036f;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v14+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+38]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+38]");
		int result;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v3+18]");
			bool flag5 = (nint)0 < (nint)i;
			object obj12 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v3+18]");
			object obj13 = -i;
			bool flag6 = obj13 == null;
			object obj14 = ~obj12;
			object obj15 = obj14 | flag6;
			if (obj15 != null)
			{
				goto IL_0918;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+38]");
			object obj16 = (nint)0 + (nint)i;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X9_v6+20]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 != null)
			{
				goto IL_036f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v14+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v14+A0]");
				obj10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+30]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+30]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v9+18]");
				bool flag9 = (nint)0 < (nint)i;
				object obj20 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v9+18]");
				object obj21 = -i;
				bool flag10 = obj21 == null;
				object obj22 = ~obj20;
				object obj23 = obj22 | flag10;
				if (obj23 != null)
				{
					goto IL_0918;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+28]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X10_v7+18]");
					bool flag11 = (nint)0 < (nint)i;
					object obj25 = !flag11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X10_v7+18]");
					object obj26 = -i;
					bool flag12 = obj26 == null;
					object obj27 = ~obj25;
					object obj28 = obj27 | flag12;
					if (obj28 != null)
					{
						goto IL_0918;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+28]");
					object obj29 = (nint)0 + (nint)i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X10_v8+20]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X10_v8+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+30]");
						object obj31 = (nint)0 + (nint)i;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v10+20]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v9+14]");
						if (num < 0)
						{
							goto IL_036f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v14+E4]");
						bool flag13 = (nint)0 == 0;
						object obj32 = !flag13;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj33 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v38+A0]");
							obj10 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+38]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v12+18]");
							bool flag14 = (nint)0 < (nint)i;
							object obj35 = !flag14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v12+18]");
							object obj36 = -i;
							bool flag15 = obj36 == null;
							object obj37 = ~obj35;
							object obj38 = obj37 | flag15;
							if (obj38 != null)
							{
								goto IL_0918;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v11+38]");
							object obj39 = (nint)0 + (nint)i;
							_ = 1;
							Save();
							object obj40 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v14+A0]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v15+28]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v15+28]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v16+18]");
								bool flag16 = (nint)0 < (nint)i;
								object obj43 = !flag16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v16+18]");
								object obj44 = -i;
								bool flag17 = obj44 == null;
								object obj45 = ~obj43;
								object obj46 = obj45 | flag17;
								if (obj46 != null)
								{
									goto IL_0918;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v15+28]");
								object obj47 = (nint)0 + (nint)i;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v17+20]");
								object obj48 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v17+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v18+18]");
									int num2 = GillaLevel.Add(0, quiet: true, boost: true);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
									object obj49 = 0;
									object obj50 = obj49;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v21+E4]");
									bool flag18 = (nint)0 == 0;
									object obj51 = !flag18;
									if (obj51 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Coins.Add(50);
									object obj52 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v22+A0]");
									object array = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v23+28]");
									object obj53 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v23+28]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X9_v17+18]");
										bool flag19 = (nint)0 < (nint)i;
										object obj54 = !flag19;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X9_v17+18]");
										object obj55 = -i;
										bool flag20 = obj55 == null;
										object obj56 = ~obj54;
										object obj57 = obj56 | flag20;
										if (obj57 != null)
										{
											goto IL_0918;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v23+28]");
										object obj58 = (nint)0 + (nint)i;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6170]");
										object obj59 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v18+20]");
										int num3 = Array.IndexOf((System.__Canon[])array, (System.__Canon)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
										object obj60 = 0;
										object obj61 = obj60;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v26+E4]");
										bool flag21 = (nint)0 == 0;
										object obj62 = !flag21;
										if (obj62 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v23+20]");
										GillaCloud.QuestClaimed(0, num3);
										object obj63 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v25+A0]");
										object obj64 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v27+10]");
										object obj65 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v27+10]");
										bool flag22 = (nint)0 == 0;
										int num4 = num3;
										if (!flag22)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v28+28]");
											num4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X8_v28+18] (should have been resolved before IL gen)");
											obj63 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v25+E4]");
										bool flag23 = (nint)0 == 0;
										object obj66 = !flag23;
										if (obj66 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj63 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v25+A0]");
										object obj67 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+18]");
										object obj68 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+18]");
										bool flag24 = (nint)0 == 0;
										result = num2;
										if (flag24)
										{
											goto IL_0a3d;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v25+E4]");
										bool flag25 = (nint)0 == 0;
										object obj69 = !flag25;
										if (obj69 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											object obj70 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v36+A0]");
											obj67 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+28]");
										object obj71 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+28]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v32+18]");
											bool flag26 = (nint)0 < (nint)i;
											object obj72 = !flag26;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v32+18]");
											object obj73 = -i;
											bool flag27 = obj73 == null;
											object obj74 = ~obj72;
											object obj75 = obj74 | flag27;
											if (obj75 != null)
											{
												goto IL_0918;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+28]");
											object obj76 = (nint)0 + (nint)i;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v33+20]");
											object obj77 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v33+20]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v34+18]");
												int num5 = GillaLevel.ForYou(0);
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ X21_v6+18] (should have been resolved before IL gen)");
												result = num2;
												goto IL_0a3d;
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
		NullReferenceException ex = new NullReferenceException();
		goto IL_0918;
		IL_036f:
		result = -1;
		goto IL_0a3d;
		IL_0a3d:
		return result;
		IL_0918:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	public static void Adopt(int serverDay, int[] claimedPool)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05cb: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_0675: Expected Obj, but got I4
		//IL_05e9: Expected Obj, but got I
		//IL_05f9: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0162: Expected Obj, but got I4
		//IL_062e: Expected Obj, but got I
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I4
		//IL_051c: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I
		//IL_0224: Expected I4, but got I8
		//IL_023b: Expected Obj, but got I4
		//IL_0561: Expected Obj, but got I
		//IL_0571: Expected Obj, but got I
		//IL_0581: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I4
		//IL_0693: Expected Obj, but got I
		//IL_06a3: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_0396: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_0411: Expected Obj, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_0469: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		if (claimedPool == null)
		{
			return;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+20]");
		if ((nint)0 != serverDay)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55E8]");
		object obj6 = 0;
		int[] array = claimedPool;
		object obj7 = 0;
		object obj8 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v18+38]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v18+38]");
			if ((nint)0 != 0)
			{
				object obj12 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v3+18]");
				bool flag3 = (nint)obj12 < 0;
				object obj13 = !flag3;
				if (obj13 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v18+38]");
				object obj14 = 0 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X9_v6+20]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				if (obj15 != null)
				{
					goto IL_0249;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+E4]");
				bool flag5 = (nint)0 == 0;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v24+A0]");
					obj10 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v18+28]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v18+28]");
				if ((nint)0 != 0)
				{
					object obj19 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v11+18]");
					bool flag6 = (nint)obj19 < 0;
					object obj20 = !flag6;
					if (obj20 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v18+28]");
					object obj21 = 0 + obj8;
					object array2 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X9_v12+20]");
					int num = Array.IndexOf((System.__Canon[])array2, (System.__Canon)0);
					int num2 = Array.IndexOf(claimedPool, num);
					obj4 = obj;
					int num3 = (int)(num2 & 0x80000000L);
					bool flag7 = num3 == 0;
					array = (int[])num;
					if (!flag7)
					{
						goto IL_0249;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+E4]");
					bool flag8 = (nint)0 == 0;
					object obj22 = !flag8;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+A0]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+38]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+38]");
					if ((nint)0 != 0)
					{
						object obj25 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v13+18]");
						bool flag9 = (nint)obj25 < 0;
						object obj26 = !flag9;
						if (obj26 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+28]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+38]");
						object obj28 = 0 + obj8;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+28]");
						if ((nint)0 != 0)
						{
							object obj29 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X10_v10+18]");
							bool flag10 = (nint)obj29 < 0;
							object obj30 = !flag10;
							if (obj30 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+28]");
							object obj31 = 0 + obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X9_v16+20]");
							object obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X9_v16+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+30]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+30]");
								if ((nint)0 != 0)
								{
									object obj34 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v22+18]");
									bool flag11 = (nint)obj34 < 0;
									object obj35 = !flag11;
									if (obj35 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+30]");
									object obj36 = 0 + obj8;
									object obj37 = obj8 + 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v17+14]");
									_ = 0;
									bool flag12 = (nint)obj8 != 2;
									array = (int[])num;
									obj7 = 1;
									obj8 = obj37;
									if (flag12)
									{
										continue;
									}
									array = (int[])num;
									goto IL_04c0;
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_04c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+E4]");
			bool flag13 = (nint)0 == 0;
			object obj38 = !flag13;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Save();
			object obj39 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v14+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v15+10]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v15+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v16+40]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v16+28]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v16+18]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v162 @ X2_v6 (should have been resolved before IL gen)");
			}
			return;
			IL_0249:
			obj8++;
			if ((nint)obj8 != 3)
			{
				continue;
			}
			object obj45 = obj7 & 1;
			if (obj45 != null)
			{
				goto IL_04c0;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe static void Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0ab2: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0ae0: Expected Obj, but got I
		//IL_0af8: Expected Obj, but got I
		//IL_0b13: Expected Obj, but got I
		//IL_0b2b: Expected Obj, but got I
		//IL_0b46: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0a3f: Expected Obj, but got I4
		//IL_0cf7: Expected Obj, but got I
		//IL_0d07: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_0286: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0d56: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I
		//IL_03f2: Expected I4, but got Obj
		//IL_040f: Expected Obj, but got I
		//IL_040f: Expected Obj, but got I
		//IL_0425: Expected I4, but got I8
		//IL_043f: Expected Obj, but got I4
		//IL_0bb3: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I4
		//IL_05e2: Expected Obj, but got I4
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got Unknown
		//IL_04ce: Expected Obj, but got I4
		//IL_04f4: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I4
		//IL_0be1: Expected Obj, but got I
		//IL_0bf1: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I4
		//IL_055c: Expected Obj, but got I4
		//IL_0855: Expected Obj, but got I4
		//IL_0c6d: Expected Obj, but got I
		//IL_0c7d: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I4
		//IL_06fd: Expected Obj, but got I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_057f: Expected Obj, but got I
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Ref, but got Unknown
		//IL_074d: Expected Obj, but got I
		//IL_075d: Expected Obj, but got I
		//IL_089b: Expected Obj, but got I4
		//IL_07b8: Expected Obj, but got I4
		//IL_08b9: Expected Obj, but got I
		//IL_08e3: Expected Obj, but got I
		//IL_08f7: Expected Obj, but got I
		//IL_08ff: Expected I4, but got Obj
		//IL_0914: Expected Obj, but got I
		//IL_092f: Expected I4, but got I8
		//IL_0949: Expected Obj, but got I4
		//IL_07f7: Expected Obj, but got I4
		//IL_0810: Expected Obj, but got I4
		//IL_0989: Expected Obj, but got I4
		//IL_0cb2: Expected Obj, but got I
		//IL_0cc2: Expected Obj, but got I
		//IL_09df: Expected Obj, but got I4
		//IL_0a02: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Day;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v3+20]");
		if ((nint)0 == num)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61E0]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object defaultValue = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+E4]");
		bool flag2 = (byte)(~(nuint)0u) != 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v54+A0]");
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v3+28]");
		Pick((GillaRecycler.Quest[])0, num, withRetired: false);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v8+30]");
		Array.Clear((Array)0, 0, 3);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v10+38]");
		Array.Clear((Array)0, 0, 3);
		string text = PlayerPrefs.GetString((string)key, (string)defaultValue);
		if (text != null)
		{
			string[] array = text.Split('|', (StringSplitOptions)0);
			if (array != null)
			{
				bool flag3 = array.Length < 3;
				object obj12 = 0;
				StringSplitOptions stringSplitOptions = (StringSplitOptions)0;
				char c = '|';
				if (!flag3)
				{
					bool flag4 = int.TryParse(array[0], out var result);
					bool flag5 = !flag4;
					obj12 = 0;
					stringSplitOptions = (StringSplitOptions)0;
					c = (char)(ushort)(&result);
					if (!flag5)
					{
						bool flag6 = result != num;
						obj12 = 0;
						stringSplitOptions = (StringSplitOptions)0;
						c = (char)(ushort)(&result);
						if (!flag6)
						{
							object obj13 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v27+E4]");
							bool flag7 = (nint)0 == 0;
							object obj14 = !flag7;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj13 = obj;
							}
							GillaRecycler.Quest[] array2;
							if (array.Length > 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v27+A0]");
								int num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X9_v10 (System.Int32)+28]");
								array2 = (GillaRecycler.Quest[])0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61D8]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj16 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v52+E4]");
								int num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v52+E4]");
								bool flag8 = (nint)0 == 0;
								object obj17 = !flag8;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaRecycler.Quest[] array3 = default;
								Pick(array3, num, withRetired: true);
								array2 = array3;
							}
							if (array[1] != null)
							{
								string[] array4 = array[1].Split(',', (StringSplitOptions)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6170]");
								object obj18 = 0;
								object obj19 = array2 + 32;
								object obj20 = array4 + 32;
								int num3 = 0;
								StringSplitOptions stringSplitOptions2 = (StringSplitOptions)0;
								char c2 = ',';
								int[] array5 = default;
								while (true)
								{
									object obj21 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v33+E4]");
									bool flag9 = (nint)0 == 0;
									object obj22 = !flag9;
									if (obj22 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj21 = obj;
									}
									if (array2 == null)
									{
										break;
									}
									bool flag10 = num3 < array2.Length;
									object obj23 = !flag10;
									int num5;
									string text2;
									ref int reference;
									if (obj23 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v33+A0]");
										object obj24 = 0;
										stringSplitOptions = (StringSplitOptions)obj18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v25+28]");
										nint num4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X26_v6+v283 @ X22_v7 (System.Int32)*8]");
										num5 = Array.IndexOf((System.__Canon[])num4, (System.__Canon)0);
										int num6 = (int)(num5 & 0x80000000L);
										bool flag11 = num6 == 0;
										object obj25 = !flag11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X26_v6+v283 @ X22_v7 (System.Int32)*8]");
										c = '\0';
										if (obj25 != null)
										{
											goto IL_0b8a;
										}
										if (array4 == null)
										{
											break;
										}
										bool flag12 = num3 >= array4.Length;
										text2 = (string)(object)array5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X26_v6+v283 @ X22_v7 (System.Int32)*8]");
										reference = ref *(int*)null;
										if (flag12)
										{
											goto IL_05ac;
										}
										bool flag13 = num3 < array4.Length;
										object obj26 = !flag13;
										if (obj26 == null)
										{
											object obj27 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X29_v6+v283 @ X22_v7 (System.Int32)*8]");
											text2 = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v58+E4]");
											bool flag14 = (nint)0 == 0;
											object obj28 = !flag14;
											if (obj28 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj27 = obj;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v58+A0]");
											object obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v47+30]");
											object obj30 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v47+30]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v48+18]");
											bool flag15 = (nint)num5 < (nint)0;
											object obj31 = !flag15;
											if (obj31 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v47+30]");
												object obj32 = (nint)0 + (nint)num5;
												reference = ref *(int*)(obj32 + 32);
												bool flag16 = int.TryParse(text2, out reference);
												stringSplitOptions = (StringSplitOptions)0;
												goto IL_05ac;
											}
										}
									}
									goto IL_0a81;
									IL_05ac:
									object obj33 = array.Length;
									bool flag17 = array.Length < 2;
									object obj34 = !flag17;
									object obj35 = array.Length - 2;
									bool flag18 = obj35 == null;
									object obj36 = ~obj34;
									object obj37 = obj36 | flag18;
									if (obj37 != null)
									{
										goto IL_0a81;
									}
									string text3 = array[2];
									if (array[2] == null)
									{
										break;
									}
									int num2 = text3._stringLength;
									bool flag19 = num3 >= text3._stringLength;
									array5 = (int[])(object)text2;
									c = (char)(ushort)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									if (!flag19)
									{
										object obj38 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v52+E4]");
										bool flag20 = (nint)0 == 0;
										object obj39 = !flag20;
										if (obj39 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											bool flag21 = array.Length < 2;
											object obj40 = !flag21;
											object obj41 = array.Length - 2;
											bool flag22 = obj41 == null;
											object obj42 = ~obj40;
											object obj43 = obj42 | flag22;
											if (obj43 != null)
											{
												goto IL_0a81;
											}
											obj38 = obj;
										}
										if (array[2] == null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v52+A0]");
										object obj44 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X9_v18+38]");
										array5 = (int[])0;
										char c3 = array[2].get_Chars(num3);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X9_v18+38]");
										if ((nint)0 == 0)
										{
											break;
										}
										bool flag23 = num5 < array5.Length;
										object obj45 = !flag23;
										if (obj45 != null)
										{
											goto IL_0a81;
										}
										int num7 = c3 & 0xFFFF;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X9_v18+38]");
										num2 = (int)((nint)0 + (nint)num5);
										object obj46 = num7 - 49;
										bool flag24 = obj46 == null;
										obj33 = array.Length;
										stringSplitOptions = (StringSplitOptions)0;
										c = (char)num3;
									}
									if ((nint)obj33 <= 3)
									{
										object obj47 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v40+E4]");
										bool flag25 = (nint)0 == 0;
										object obj48 = !flag25;
										if (obj48 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj47 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v40+A0]");
										object array6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v32+28]");
										object obj49 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v32+28]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X9_v15+18]");
										bool flag26 = (nint)num5 < (nint)0;
										object obj50 = !flag26;
										if (obj50 != null)
										{
											goto IL_0a81;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v32+8]");
										array5 = (int[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v32+28]");
										num2 = (int)((nint)0 + (nint)num5);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X9_v10 (System.Int32)+20]");
										int num8 = Array.IndexOf((System.__Canon[])array6, (System.__Canon)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55E8]");
										object obj51 = 0;
										stringSplitOptions = (StringSplitOptions)obj51;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v32+8]");
										int num9 = Array.IndexOf((int[])0, num8);
										int num10 = (int)(num9 & 0x80000000L);
										bool flag27 = num10 == 0;
										object obj52 = !flag27;
										c = (char)num8;
										if (obj52 == null)
										{
											object obj53 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v46+E4]");
											bool flag28 = (nint)0 == 0;
											object obj54 = !flag28;
											if (obj54 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj53 = obj;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v46+A0]");
											object obj55 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v36+30]");
											object obj56 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v36+30]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v37+18]");
											num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v37+18]");
											bool flag29 = (nint)num5 < (nint)0;
											object obj57 = !flag29;
											if (obj57 != null)
											{
												goto IL_0a81;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v36+30]");
											object obj58 = (nint)0 + (nint)num5;
											_ = 0;
											c = (char)num8;
										}
									}
									goto IL_0b8a;
									IL_0b8a:
									num3++;
									bool flag30 = num3 != 3;
									obj12 = 0;
									stringSplitOptions2 = stringSplitOptions;
									c2 = c;
									if (flag30)
									{
										continue;
									}
									goto IL_0a15;
								}
							}
							goto IL_0a73;
						}
					}
				}
				goto IL_0a15;
			}
		}
		goto IL_0a73;
		IL_0a15:
		object obj59 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v19+E4]");
		bool flag31 = (nint)0 == 0;
		object obj60 = !flag31;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj59 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v19+A0]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v16+10]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v16+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ X8_v17+18] (should have been resolved before IL gen)");
		}
		return;
		IL_0a81:
		throw new IndexOutOfRangeException();
		IL_0a73:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0a81;
	}

	private static bool Retired(GillaRecycler.Quest q)
	{
		//IL_0052: Expected I4, but got Obj
		//IL_0030: Expected Obj, but got I4
		if (q != null)
		{
			object obj = q.stat - 7;
			return obj == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static void Pick(GillaRecycler.Quest[] into, int d, bool withRetired)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05db: Expected Obj, but got I4
		//IL_06ce: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I8
		//IL_00d1: Expected Obj, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I8
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_061e: Expected Obj, but got I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02de: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_06b0: Expected Obj, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_0659: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_026f: Expected Obj, but got I8
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_0421: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0689: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_04c7: Expected Obj, but got I4
		//IL_04e7: Expected Obj, but got I4
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj9 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj10 = 0 & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0134;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj11 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj12 = 0 & obj11;
		object obj14 = default;
		object obj13 = obj14 + 32;
		object obj15 = 0;
		while (obj10 != obj15)
		{
			obj15++;
			if (obj12 != obj15)
			{
				continue;
			}
			goto IL_0134;
		}
		goto IL_059c;
		IL_062c:
		object obj16;
		if ((nint)obj16 < 1)
		{
			return;
		}
		object obj17 = into + 32;
		object obj18 = obj14 + 32;
		object obj19 = 0;
		object obj20 = 0;
		object obj21 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
			object obj22 = !flag2;
			if (obj22 != null)
			{
				break;
			}
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj24 = !flag3;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj23 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+A0]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X26_v5+v92 @ X24_v6*4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v14+18]");
			bool flag4 = num < 0;
			object obj27 = !flag4;
			if (obj27 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X26_v5+v92 @ X24_v6*4]");
			object obj28 = obj26 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v15+20]");
			object obj29 = 0;
			object obj30;
			if (withRetired)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X22_v8+10]");
				obj30 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj31 = !flag5;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X22_v8+10]");
				obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X22_v8+10]");
				if ((nint)0 == 7)
				{
					goto IL_0559;
				}
			}
			bool flag6 = (nint)obj30 < 4;
			object obj32 = !flag6;
			object obj33 = obj19 & 1;
			object obj34 = ~obj32;
			obj10 = ((obj34 != null) ? obj33 : ((object)0));
			object obj35 = ~obj32;
			bool flag7 = obj10 == null;
			object obj36 = !flag7;
			if (obj36 == null)
			{
				object obj37 = obj35 | obj33;
				bool flag8 = obj37 == null;
				object obj38 = !flag8;
				bool flag9 = (nint)obj20 < into.Length;
				object obj39 = !flag9;
				if (obj39 != null)
				{
					break;
				}
				object obj40 = (object)into + obj20;
				object obj41 = obj17 + obj20;
				obj20++;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag10 = (nint)obj20 == 3;
				obj19 = obj38;
				obj7 = obj29;
				if (flag10)
				{
					return;
				}
			}
			goto IL_0559;
			IL_0559:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
			obj16 = 0;
			obj21++;
			object obj42 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
			if ((nint)obj42 >= 0)
			{
				return;
			}
		}
		goto IL_059c;
		IL_059c:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0134:
		if ((nint)obj9 >= 1)
		{
			object obj43 = obj14 + 32;
			object obj44 = d * 2654435761L;
			object obj45 = 12345 + obj44;
			while (true)
			{
				bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
				object obj46 = !flag11;
				if (obj46 != null)
				{
					break;
				}
				object obj47 = obj45 * 1664525;
				obj45 = 1013904223 + obj47;
				object obj48 = obj45 / obj8;
				object obj49 = obj48 * obj8;
				object obj50 = obj45 - obj49;
				bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
				object obj51 = !flag12;
				if (obj51 != null)
				{
					break;
				}
				object obj52 = obj14 + obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X10_v12+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
				bool flag13 = (nint)obj50 < 0;
				object obj53 = !flag13;
				if (obj53 != null)
				{
					break;
				}
				obj9--;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
				obj10 = 0 & 0xFFFFFFFFL;
				obj8--;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X13_v5+v408 @ X9_v12*4]");
				_ = 0;
				if ((nint)obj9 > 1)
				{
					continue;
				}
				goto IL_062c;
			}
			goto IL_059c;
		}
		obj16 = obj8;
		goto IL_062c;
	}

	private unsafe static void Save()
	{
		//IL_0010: Expected Obj, but got I
		//IL_09d5: Expected Obj, but got I4
		//IL_0bc1: Expected Obj, but got I
		//IL_0bdb: Expected Obj, but got I8
		//IL_0bf5: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I8
		//IL_011b: Expected Obj, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected I4, but got Unknown
		//IL_01c4: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I8
		//IL_026e: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_02a6: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I8
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected I4, but got Unknown
		//IL_0329: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_042f: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I
		//IL_0466: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected I4, but got Unknown
		//IL_04e6: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0563: Expected Obj, but got I8
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_05b8: Expected Obj, but got I
		//IL_05c8: Expected Obj, but got I
		//IL_060e: Expected Obj, but got I4
		//IL_061e: Expected Obj, but got I4
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_0661: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected Obj, but got Unknown
		//IL_0a56: Expected Obj, but got I4
		//IL_0699: Expected Obj, but got I
		//IL_0a74: Expected Obj, but got I
		//IL_0a84: Expected Obj, but got I
		//IL_06e4: Expected Obj, but got I8
		//IL_071d: Expected Obj, but got I4
		//IL_072d: Expected Obj, but got I4
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_07ad: Expected Obj, but got I
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected Obj, but got Unknown
		//IL_0ad3: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I
		//IL_0af1: Expected Obj, but got I
		//IL_0b01: Expected Obj, but got I
		//IL_07eb: Expected Obj, but got I4
		//IL_0801: Expected Obj, but got I
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected Obj, but got Unknown
		//IL_0850: Expected Obj, but got I4
		//IL_0860: Expected Obj, but got I4
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_08e0: Expected Obj, but got I
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected Obj, but got Unknown
		//IL_0b48: Expected Obj, but got I4
		//IL_0b5e: Expected Obj, but got I
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_08cb: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_0971: Expected Obj, but got I4
		//IL_0ba1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+20]");
		object obj5 = 0 & 0x80000000L;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v10+A0]");
		int num = (int)((nint)0 + (nint)32);
		string text = ((int*)num)->ToString();
		string[] array = default;
		if (array.Length != 0)
		{
			object obj10 = array + 32;
			obj10 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X20_v6-8]");
			object obj11 = 0 & 0xFFFFFFFEL;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
				object obj12 = 0;
				object obj13 = array + 40;
				obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v16+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v17+30]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v18+18]");
				if ((nint)0 != 0)
				{
					int num2 = obj16 + 32;
					string text2 = ((int*)num2)->ToString();
					bool flag4 = array.Length < 2;
					object obj17 = !flag4;
					object obj18 = array.Length - 2;
					bool flag5 = obj18 == null;
					object obj19 = ~obj17;
					object obj20 = obj19 | flag5;
					if (obj20 == null)
					{
						object obj21 = array + 48;
						obj21 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X20_v8-18]");
						object obj22 = 0 & 0xFFFFFFFCL;
						if (obj22 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
							object obj23 = 0;
							object obj24 = array + 56;
							obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj25 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v21+A0]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v22+30]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v23+18]");
							object obj28 = 0 & 0xFFFFFFFEL;
							if (obj28 != null)
							{
								int num3 = obj27 + 36;
								string text3 = ((int*)num3)->ToString();
								bool flag6 = array.Length < 4;
								object obj29 = !flag6;
								object obj30 = array.Length - 4;
								bool flag7 = obj30 == null;
								object obj31 = ~obj29;
								object obj32 = obj31 | flag7;
								if (obj32 == null)
								{
									object obj33 = array + 64;
									obj33 = text3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X20_v10-28]");
									bool flag8 = (nint)0 < (nint)5;
									object obj34 = !flag8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X20_v10-28]");
									object obj35 = -5;
									bool flag9 = obj35 == null;
									object obj36 = ~obj34;
									object obj37 = obj36 | flag9;
									if (obj37 == null)
									{
										object obj38 = array + 72;
										obj38 = obj23;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj39 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v26+A0]");
										object obj40 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v27+30]");
										object obj41 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v28+18]");
										bool flag10 = (nint)0 < (nint)2;
										object obj42 = !flag10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v28+18]");
										object obj43 = -2;
										bool flag11 = obj43 == null;
										object obj44 = ~obj42;
										object obj45 = obj44 | flag11;
										if (obj45 == null)
										{
											int num4 = obj41 + 40;
											string text4 = ((int*)num4)->ToString();
											bool flag12 = array.Length < 6;
											object obj46 = !flag12;
											object obj47 = array.Length - 6;
											bool flag13 = obj47 == null;
											object obj48 = ~obj46;
											object obj49 = obj48 | flag13;
											if (obj49 == null)
											{
												object obj50 = array + 80;
												obj50 = text4;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X20_v12-38]");
												object obj51 = 0 & 0xFFFFFFF8L;
												if (obj51 != null)
												{
													object obj52 = array + 88;
													obj52 = obj12;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													object obj53 = obj;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v31+A0]");
													object obj54 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v32+38]");
													object obj55 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v33+18]");
													if ((nint)0 != 0)
													{
														bool flag14 = array.Length < 8;
														object obj56 = !flag14;
														object obj57 = array.Length - 8;
														bool flag15 = obj57 == null;
														object obj58 = ~obj56;
														object obj59 = obj58 | flag15;
														if (obj59 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61E0]");
															object key = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v33+20]");
															object obj60;
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
																obj60 = 0;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F8]");
																obj60 = 0;
															}
															object obj61 = array + 96;
															obj61 = obj60;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj62 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v44+E4]");
															bool flag16 = (nint)0 == 0;
															object obj63 = !flag16;
															if (obj63 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																obj62 = obj;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v44+A0]");
															object obj64 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v38+38]");
															object obj65 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v39+18]");
															object obj66 = 0 & 0xFFFFFFFEL;
															if (obj66 != null)
															{
																bool flag17 = array.Length < 9;
																object obj67 = !flag17;
																object obj68 = array.Length - 9;
																bool flag18 = obj68 == null;
																object obj69 = ~obj67;
																object obj70 = obj69 | flag18;
																if (obj70 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v39+21]");
																	object obj71;
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
																		obj71 = 0;
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F8]");
																		obj71 = 0;
																	}
																	object obj72 = array + 104;
																	obj72 = obj71;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	object obj73 = obj;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v49+E4]");
																	bool flag19 = (nint)0 == 0;
																	object obj74 = !flag19;
																	if (obj74 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		obj73 = obj;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v49+A0]");
																	object obj75 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v43+38]");
																	object obj76 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v44+18]");
																	bool flag20 = (nint)0 < (nint)2;
																	object obj77 = !flag20;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v44+18]");
																	object obj78 = -2;
																	bool flag21 = obj78 == null;
																	object obj79 = ~obj77;
																	object obj80 = obj79 | flag21;
																	if (obj80 == null)
																	{
																		bool flag22 = array.Length < 10;
																		object obj81 = !flag22;
																		object obj82 = array.Length - 10;
																		bool flag23 = obj82 == null;
																		object obj83 = ~obj81;
																		object obj84 = obj83 | flag23;
																		if (obj84 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v44+22]");
																			object obj85;
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
																				obj85 = 0;
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F8]");
																				obj85 = 0;
																			}
																			object obj86 = array + 112;
																			obj86 = obj85;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v10-58]");
																			bool flag24 = (nint)0 < (nint)11;
																			object obj87 = !flag24;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v10-58]");
																			object obj88 = -11;
																			bool flag25 = obj88 == null;
																			object obj89 = ~obj87;
																			object obj90 = obj89 | flag25;
																			if (obj90 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61E8]");
																				object obj91 = 0;
																				object obj92 = array + 120;
																				obj92 = obj91;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				string value = string.Concat(array);
																				PlayerPrefs.SetString((string)key, value);
																				PlayerPrefs.Save();
																				float unscaledTime = Time.unscaledTime;
																				object obj93 = obj;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v61+E4]");
																				bool flag26 = (nint)0 == 0;
																				object obj94 = !flag26;
																				if (obj94 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																					obj93 = obj;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v61+A0]");
																				object obj95 = 0;
																				_ = 0;
																				return;
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
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Flush()
	{
		//IL_0010: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+44]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Save();
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
		object obj4 = 0;
		_ = 4294967295L;
		_ = 0;
	}

	static GillaQuests()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I8
		//IL_0152: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I8
		//IL_02f4: Expected Obj, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0386: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0471: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04ca: Expected Obj, but got I
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_055c: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05b5: Expected Obj, but got I
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_063f: Expected Obj, but got I8
		//IL_066c: Expected Obj, but got I
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_06fe: Expected Obj, but got I4
		//IL_0714: Expected Obj, but got I
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected Obj, but got Unknown
		//IL_0757: Expected Obj, but got I
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected Obj, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07e9: Expected Obj, but got I4
		//IL_07ff: Expected Obj, but got I
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Obj, but got Unknown
		//IL_0842: Expected Obj, but got I
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected Obj, but got Unknown
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected Obj, but got Unknown
		//IL_08d4: Expected Obj, but got I4
		//IL_08ea: Expected Obj, but got I
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected Obj, but got Unknown
		//IL_092d: Expected Obj, but got I
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected Obj, but got Unknown
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_09bf: Expected Obj, but got I4
		//IL_09d5: Expected Obj, but got I
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected Obj, but got Unknown
		//IL_0a18: Expected Obj, but got I
		//IL_0a28: Expected Obj, but got I
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected Obj, but got Unknown
		//IL_0a60: Expected Obj, but got I
		//IL_0acb: Expected Obj, but got I
		//IL_0ae7: Expected Obj, but got I
		//IL_0b11: Expected Obj, but got I
		//IL_0b48: Expected Obj, but got I
		//IL_0b87: Expected Obj, but got I
		//IL_0bc6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6208]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6210]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj4 = default;
		obj4._002Ector();
		_ = 200;
		object obj5 = obj4 + 32;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C6A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6268]");
			object obj6 = 0;
			object obj8 = default;
			object obj7 = obj8 + 32;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj9 = default;
			obj9._002Ector();
			_ = 150;
			object obj10 = obj9 + 32;
			obj10 = obj6;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X21_v5-8]");
			object obj11 = 0 & 0xFFFFFFFEL;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6230]");
				object obj12 = 0;
				object obj13 = obj8 + 40;
				obj13 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj14 = default;
				obj14._002Ector();
				_ = 300;
				object obj15 = obj14 + 32;
				obj15 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C330]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X21_v7-10]");
				bool flag = (nint)0 < (nint)2;
				object obj16 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X21_v7-10]");
				object obj17 = -2;
				bool flag2 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag2;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6250]");
					object obj20 = 0;
					object obj21 = obj8 + 48;
					obj21 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj22 = default;
					obj22._002Ector();
					_ = 200;
					object obj23 = obj22 + 32;
					obj23 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B7E0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X21_v9-18]");
					object obj24 = 0 & 0xFFFFFFFCL;
					if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6220]");
						object obj25 = 0;
						object obj26 = obj8 + 56;
						obj26 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						object obj27 = default;
						obj27._002Ector();
						_ = 125;
						object obj28 = obj27 + 32;
						obj28 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCA8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X21_v11-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj29 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X21_v11-20]");
						object obj30 = -4;
						bool flag4 = obj30 == null;
						object obj31 = ~obj29;
						object obj32 = obj31 | flag4;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6248]");
							object obj33 = 0;
							object obj34 = obj8 + 64;
							obj34 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							object obj35 = default;
							obj35._002Ector();
							_ = 125;
							object obj36 = obj35 + 32;
							obj36 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1A8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X21_v13-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj37 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X21_v13-28]");
							object obj38 = -5;
							bool flag6 = obj38 == null;
							object obj39 = ~obj37;
							object obj40 = obj39 | flag6;
							if (obj40 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6260]");
								object obj41 = 0;
								object obj42 = obj8 + 72;
								obj42 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								object obj43 = default;
								obj43._002Ector();
								_ = 150;
								object obj44 = obj43 + 32;
								obj44 = obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAB8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X21_v15-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj45 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X21_v15-30]");
								object obj46 = -6;
								bool flag8 = obj46 == null;
								object obj47 = ~obj45;
								object obj48 = obj47 | flag8;
								if (obj48 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6258]");
									object obj49 = 0;
									object obj50 = obj8 + 80;
									obj50 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									object obj51 = default;
									obj51._002Ector();
									_ = 125;
									object obj52 = obj51 + 32;
									obj52 = obj49;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1B0]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X21_v17-38]");
									object obj53 = 0 & 0xFFFFFFF8L;
									if (obj53 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6218]");
										object obj54 = 0;
										object obj55 = obj8 + 88;
										obj55 = obj51;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										object obj56 = default;
										obj56._002Ector();
										_ = 175;
										object obj57 = obj56 + 32;
										obj57 = obj54;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C070]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X21_v19-40]");
										bool flag9 = (nint)0 < (nint)8;
										object obj58 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X21_v19-40]");
										object obj59 = -8;
										bool flag10 = obj59 == null;
										object obj60 = ~obj58;
										object obj61 = obj60 | flag10;
										if (obj61 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6228]");
											object obj62 = 0;
											object obj63 = obj8 + 96;
											obj63 = obj56;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											object obj64 = default;
											obj64._002Ector();
											_ = 200;
											object obj65 = obj64 + 32;
											obj65 = obj62;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B678]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X21_v21-48]");
											bool flag11 = (nint)0 < (nint)9;
											object obj66 = !flag11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X21_v21-48]");
											object obj67 = -9;
											bool flag12 = obj67 == null;
											object obj68 = ~obj66;
											object obj69 = obj68 | flag12;
											if (obj69 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6238]");
												object obj70 = 0;
												object obj71 = obj8 + 104;
												obj71 = obj64;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												object obj72 = default;
												obj72._002Ector();
												_ = 100;
												object obj73 = obj72 + 32;
												obj73 = obj70;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B348]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X21_v23-50]");
												bool flag13 = (nint)0 < (nint)10;
												object obj74 = !flag13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X21_v23-50]");
												object obj75 = -10;
												bool flag14 = obj75 == null;
												object obj76 = ~obj74;
												object obj77 = obj76 | flag14;
												if (obj77 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6240]");
													object obj78 = 0;
													object obj79 = obj8 + 112;
													obj79 = obj72;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													object obj80 = default;
													obj80._002Ector();
													_ = 100;
													object obj81 = obj80 + 32;
													obj81 = obj78;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCB0]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X21_v25-58]");
													bool flag15 = (nint)0 < (nint)11;
													object obj82 = !flag15;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X21_v25-58]");
													object obj83 = -11;
													bool flag16 = obj83 == null;
													object obj84 = ~obj82;
													object obj85 = obj84 | flag16;
													if (obj85 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
														object obj86 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
														object obj87 = 0;
														object obj88 = obj8 + 120;
														obj88 = obj80;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj89 = obj86;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v30+A0]");
														object obj90 = 0;
														obj90 = obj8;
														object obj91 = obj86;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v96+18]");
														if ((nint)0 != 0)
														{
															object obj92 = obj86;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
															object obj93 = 0;
															_ = 11;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v34+A0]");
															object obj94 = (nint)0 + (nint)8;
															object obj95 = default;
															obj94 = obj95;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj96 = obj86;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v35+A0]");
															object obj97 = 0;
															_ = 4294967295L;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															object obj98 = obj86;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v37+A0]");
															object obj99 = (nint)0 + (nint)40;
															object obj100 = default;
															obj99 = obj100;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															object obj101 = obj86;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v40+A0]");
															object obj102 = (nint)0 + (nint)48;
															object obj103 = default;
															obj102 = obj103;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															object obj104 = obj86;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v43+A0]");
															object obj105 = (nint)0 + (nint)56;
															object obj106 = default;
															obj105 = obj106;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															return;
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
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
